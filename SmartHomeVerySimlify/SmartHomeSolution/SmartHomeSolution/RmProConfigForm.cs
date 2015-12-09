using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using DevExpress.Data.Linq;
using DevExpress.Data.PLinq.Helpers;
using SmartHome.Controllers;
using SmartHome.Core.Entities.Devices;
using SmartHome.Core.Entities.Devices.API;
using SmartHome.Core.Helpers;
using SmartHome.Core.Interfaces.UIInterfaces;

namespace SmartHomeSolution
{
    public partial class RmProConfigForm : Form
    {
        public RmProConfigForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void OnRefreshDevicesClick(object sender, EventArgs e)
        {
            string message;
            int code;
            _btRefreshDevices.Enabled = false;
            var list = ApiHelper.GetDevicesList(_deviceUrl.Text, out message, out code);
            _devicesList.Items.Clear();
            _devicesList.Items.AddRange(list.ToArray());
            _statusLabel.Text = string.Format("Code: {0}; Message: {1}", code, message);
            _btRefreshDevices.Enabled = true;
        }

        private void OnDeviceListSelectedValueChanged(object sender, EventArgs e)
        {
            var item = _devicesList.SelectedItem as RmDeviceInfo;
            if (item == null)
            {
                return;
            }
            _deviceIdInfo.Text = item.Id.ToString("D");
            _deviceLockedInfo.Text = item.Lock ? "Locked" : "Unlocked";
            _deviceTypeInfo.Text = item.Type;
            _deviceAddressInfo.Text = item.Mac;
        }

        private void OnGetCodesFromDeviceClick(object sender, EventArgs e)
        {
            string message;
            int code;
            _btCodesDeviceGet.Enabled = false;
            var list = ApiHelper.GetCodesList(_deviceUrl.Text, out message, out code);
            _codesList.Items.Clear();
            _codesList.Items.AddRange(list.ToArray());
            _statusLabel.Text = string.Format("Code: {0}; Message: {1}", code, message);
            _btCodesDeviceGet.Enabled = true;
        }

        private void OnCodesListSelectedValueChanged(object sender, EventArgs e)
        {
            var item = _codesList.SelectedItem as ApiCodeInformation;
            if (item == null)
            {
                return;
            }
            _teCodeName.Text = item.name;
            _teCodeValue.Text = item.data;
            _teCodeMac.Text = item.mac;
        }

        private void OnUpdateSelectedCodeClick(object sender, EventArgs e)
        {
            var item = _codesList.SelectedItem as ApiCodeInformation;
            if (item == null)
            {
                return;
            }
            item.name = _teCodeName.Text;
            item.data = _teCodeValue.Text;
            item.mac = _teCodeMac.Text;
        }

        private void OnCodeTest(object sender, EventArgs e)
        {
            string message;
            int code;
            _btCodeTest.Enabled = false;
            ApiHelper.SendCode(_deviceUrl.Text, _teCodeMac.Text, _teCodeValue.Text, out message, out code);
            _statusLabel.Text = string.Format("Code: {0}; Message: {1}", code, message);
            _btCodeTest.Enabled = true;
            //DisplayDialogResult(code, message);
        }

        private void OnRemoveSelectedCode(object sender, EventArgs e)
        {
            var item = _codesList.SelectedItem as ApiCodeInformation;
            if (item == null)
            {
                return;
            }
            if (_codesList.Items.Contains(item))
            {
                _codesList.Items.Remove(item);
            }
        }

        private void OnLearnNewCode(object sender, EventArgs e)
        {
            _btLearnNewCode.Enabled = false;
            IEnterNameForm nameForm = new EnterCodeNameForm() {StartPosition = FormStartPosition.CenterParent};
            string message;
            int code;
            var mac_address = _deviceAddressInfo.Text;
            var url = _deviceUrl.Text;

            if (string.IsNullOrEmpty(mac_address))
            {
                MessageBox.Show("Please select device to Learn new code", "Learn New code Exception",
                    MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.ServiceNotification);
                _btLearnNewCode.Enabled = true;
                return;
            }

            var codeInfo = ApiHelper.CodeLearnFullProcess(url, mac_address, nameForm, out message, out code);

            if (codeInfo == null)
            {
                MessageBox.Show("Cant get result code or incorrect name! Please try again!", "Learn Code Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            _codesList.Items.Add(codeInfo);
            _btLearnNewCode.Enabled = true;
        }

        private void OnSaveToFileClick(object sender, EventArgs e)
        {
            using (var saveFileDialog1 = new System.Windows.Forms.SaveFileDialog())
            {
                saveFileDialog1.Filter = "Файл Конфигурации RM Pro(*.rmc)|*.rmc";
                if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    var resultSettings = GetCurrentSettingsXmlString();
                    File.WriteAllText(saveFileDialog1.FileName, resultSettings);
                }
            }
        }

        private string GetCurrentSettingsXmlString()
        {
            var list = _codesList.Items.OfType<ApiCodeInformation>().ToList();
            return list.SerializeObject();
        }

        private void _btCodesDeviceLoad_Click(object sender, EventArgs e)
        {
            using (var openFileDialog1 = new System.Windows.Forms.OpenFileDialog())
            {
                openFileDialog1.Filter = "Файл Конфигурации RM Pro(*.rmc)|*.rmc";
                if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    if (!File.Exists(openFileDialog1.FileName)) throw new NotImplementedException("Не найден файл");
                    using (TextReader reader = File.OpenText(openFileDialog1.FileName))
                    {
                        var sr = new XmlSerializer(typeof (List<ApiCodeInformation>));
                        var settings = (List<ApiCodeInformation>) sr.Deserialize(reader);
                        if (settings == null)
                        {
                            return;
                        }
                        _codesList.Items.Clear();
                        _codesList.Items.AddRange(settings.ToArray());
                    }
                }
            }
        }

        private void _btCodesDeviceUpdate_Click(object sender, EventArgs e)
        {
            string message;
            int code;
            _btCodesDeviceUpdate.Enabled = false;
            var list = _codesList.Items.OfType<ApiCodeInformation>().ToList();
            ApiHelper.UpdateCodesList(_deviceUrl.Text, list, out message, out code);
            _statusLabel.Text = string.Format("Code: {0}; Message: {1}", code, message);
            _btCodesDeviceUpdate.Enabled = true;
            DisplayDialogResult(code, message);
        }

        private static void DisplayDialogResult(int code, string message)
        {
            if (code == 0)
            {
                MessageBox.Show(message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            MessageBox.Show(message, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void OnAddManualCode(object sender, EventArgs e)
        {
            var addCodeForm = new EnterCodeDetailsForm(
                new ApiCodeInformation(){name = "NewName", data = string.Empty, mac = _deviceAddressInfo.Text},
                _codesList.Items.OfType<ApiCodeInformation>().Select(_=>_.name)
                )
            {
                StartPosition = FormStartPosition.CenterParent
            };

            if (DialogResult.OK == addCodeForm.ShowDialog())
            {

                _codesList.Items.Add(new ApiCodeInformation()
                {
                    data = addCodeForm.data,
                    mac = addCodeForm.mac,
                    name = addCodeForm.name,
                    
                });
            }


        }
    }
}
