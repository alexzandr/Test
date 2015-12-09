using System.Collections.Generic;
using System.Linq;
using System;
using System.Windows.Forms;
using SmartHome.Core.Entities.Devices.API;

namespace SmartHomeSolution
{
    public partial class EnterCodeDetailsForm : Form, IApiCodeInformation
    {
        private IEnumerable<string> forbidenNames;

        public EnterCodeDetailsForm(IApiCodeInformation code, IEnumerable<string> namesList)
        {
            InitializeComponent();
            name = code.name;
            mac = code.mac;
            forbidenNames = namesList;
        }

        public string data
        {
            get { return _teCodeValue.Text; }
            set { _teCodeValue.Text = value; }
        }

        public string name
        {
            get { return _teCodeName.Text; }
            set { _teCodeName.Text = value; }
        }

        public string mac
        {
            get { return _teCodeMac.Text; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    chkUseMac.Checked = false;
                }
                _teCodeMac.Text = value;
            }
        }

        private void chkUseMac_CheckStateChanged(object sender, EventArgs e)
        {
            _teCodeMac.Properties.ReadOnly = chkUseMac.Checked;
        }

        private void _btOk_Click(object sender, EventArgs e)
        {
            _teCodeMac.DoValidate();
            _teCodeName.DoValidate();
            _teCodeValue.DoValidate();
        }

        private void _teCodeMac_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(_teCodeMac.Text))
            {
                e.Cancel = true;
            }
        }

        private void _teCodeName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(_teCodeName.Text) || forbidenNames.Contains(_teCodeName.Text))
            {
                e.Cancel = true;
            }
        }

        private void _teCodeValue_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(_teCodeValue.Text))
            {
                e.Cancel = true;
            }
        }
    }
}
