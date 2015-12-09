namespace SmartHomeSolution
{
    partial class RmProConfigForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._devicesList = new DevExpress.XtraEditors.ListBoxControl();
            this._commandsGroup = new DevExpress.XtraEditors.GroupControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this._deviceLockedInfo = new DevExpress.XtraEditors.TextEdit();
            this._deviceAddressInfo = new DevExpress.XtraEditors.TextEdit();
            this._deviceIdInfo = new DevExpress.XtraEditors.TextEdit();
            this._deviceTypeInfo = new DevExpress.XtraEditors.TextEdit();
            this._deviceUrl = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this._btRefreshDevices = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this._statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this._codeGroup = new DevExpress.XtraEditors.GroupControl();
            this._teCodeValue = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this._teCodeMac = new DevExpress.XtraEditors.TextEdit();
            this._teCodeName = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this._btLearnNewCode = new DevExpress.XtraEditors.SimpleButton();
            this._btRemoveSelected = new DevExpress.XtraEditors.SimpleButton();
            this._btUpdateSelectedCode = new DevExpress.XtraEditors.SimpleButton();
            this._btCodeTest = new DevExpress.XtraEditors.SimpleButton();
            this._btCodesDeviceSave = new DevExpress.XtraEditors.SimpleButton();
            this._btCodesDeviceUpdate = new DevExpress.XtraEditors.SimpleButton();
            this._btCodesDeviceLoad = new DevExpress.XtraEditors.SimpleButton();
            this._btCodesDeviceGet = new DevExpress.XtraEditors.SimpleButton();
            this._codesList = new DevExpress.XtraEditors.ListBoxControl();
            ((System.ComponentModel.ISupportInitialize)(this._devicesList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._commandsGroup)).BeginInit();
            this._commandsGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._deviceLockedInfo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._deviceAddressInfo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._deviceIdInfo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._deviceTypeInfo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._deviceUrl.Properties)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._codeGroup)).BeginInit();
            this._codeGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._teCodeValue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._teCodeMac.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._teCodeName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._codesList)).BeginInit();
            this.SuspendLayout();
            // 
            // _devicesList
            // 
            this._devicesList.Location = new System.Drawing.Point(8, 78);
            this._devicesList.Name = "_devicesList";
            this._devicesList.Size = new System.Drawing.Size(222, 63);
            this._devicesList.TabIndex = 1;
            this._devicesList.SelectedValueChanged += new System.EventHandler(this.OnDeviceListSelectedValueChanged);
            // 
            // _commandsGroup
            // 
            this._commandsGroup.AutoSize = true;
            this._commandsGroup.Controls.Add(this.labelControl7);
            this._commandsGroup.Controls.Add(this.labelControl5);
            this._commandsGroup.Controls.Add(this.labelControl6);
            this._commandsGroup.Controls.Add(this.labelControl4);
            this._commandsGroup.Controls.Add(this.labelControl3);
            this._commandsGroup.Controls.Add(this._deviceLockedInfo);
            this._commandsGroup.Controls.Add(this._deviceAddressInfo);
            this._commandsGroup.Controls.Add(this._deviceIdInfo);
            this._commandsGroup.Controls.Add(this._deviceTypeInfo);
            this._commandsGroup.Controls.Add(this._deviceUrl);
            this._commandsGroup.Controls.Add(this.labelControl2);
            this._commandsGroup.Controls.Add(this._btRefreshDevices);
            this._commandsGroup.Controls.Add(this.labelControl1);
            this._commandsGroup.Controls.Add(this._devicesList);
            this._commandsGroup.Dock = System.Windows.Forms.DockStyle.Left;
            this._commandsGroup.Location = new System.Drawing.Point(0, 0);
            this._commandsGroup.Margin = new System.Windows.Forms.Padding(3, 3, 50, 3);
            this._commandsGroup.Name = "_commandsGroup";
            this._commandsGroup.Size = new System.Drawing.Size(237, 304);
            this._commandsGroup.TabIndex = 2;
            this._commandsGroup.Text = "Settings";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(9, 278);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(37, 13);
            this.labelControl7.TabIndex = 5;
            this.labelControl7.Text = "Locked:";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(9, 226);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(15, 13);
            this.labelControl5.TabIndex = 5;
            this.labelControl5.Text = "ID:";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(9, 252);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(43, 13);
            this.labelControl6.TabIndex = 5;
            this.labelControl6.Text = "Address:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(9, 200);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(28, 13);
            this.labelControl4.TabIndex = 5;
            this.labelControl4.Text = "Type:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(9, 179);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(95, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Device Information:";
            // 
            // _deviceLockedInfo
            // 
            this._deviceLockedInfo.EditValue = "";
            this._deviceLockedInfo.Location = new System.Drawing.Point(58, 275);
            this._deviceLockedInfo.Name = "_deviceLockedInfo";
            this._deviceLockedInfo.Properties.ReadOnly = true;
            this._deviceLockedInfo.Size = new System.Drawing.Size(172, 20);
            this._deviceLockedInfo.TabIndex = 2;
            this._deviceLockedInfo.Tag = "Type";
            // 
            // _deviceAddressInfo
            // 
            this._deviceAddressInfo.EditValue = "";
            this._deviceAddressInfo.Location = new System.Drawing.Point(58, 249);
            this._deviceAddressInfo.Name = "_deviceAddressInfo";
            this._deviceAddressInfo.Properties.ReadOnly = true;
            this._deviceAddressInfo.Size = new System.Drawing.Size(172, 20);
            this._deviceAddressInfo.TabIndex = 2;
            this._deviceAddressInfo.Tag = "Type";
            // 
            // _deviceIdInfo
            // 
            this._deviceIdInfo.EditValue = "";
            this._deviceIdInfo.Location = new System.Drawing.Point(58, 223);
            this._deviceIdInfo.Name = "_deviceIdInfo";
            this._deviceIdInfo.Properties.ReadOnly = true;
            this._deviceIdInfo.Size = new System.Drawing.Size(172, 20);
            this._deviceIdInfo.TabIndex = 2;
            this._deviceIdInfo.Tag = "Type";
            // 
            // _deviceTypeInfo
            // 
            this._deviceTypeInfo.EditValue = "";
            this._deviceTypeInfo.Location = new System.Drawing.Point(58, 197);
            this._deviceTypeInfo.Name = "_deviceTypeInfo";
            this._deviceTypeInfo.Properties.ReadOnly = true;
            this._deviceTypeInfo.Size = new System.Drawing.Size(172, 20);
            this._deviceTypeInfo.TabIndex = 2;
            this._deviceTypeInfo.Tag = "Type";
            // 
            // _deviceUrl
            // 
            this._deviceUrl.EditValue = "http://10.0.1.10:7474/";
            this._deviceUrl.Location = new System.Drawing.Point(37, 34);
            this._deviceUrl.Name = "_deviceUrl";
            this._deviceUrl.Size = new System.Drawing.Size(193, 20);
            this._deviceUrl.TabIndex = 0;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(9, 59);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(41, 13);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Devices:";
            // 
            // _btRefreshDevices
            // 
            this._btRefreshDevices.Location = new System.Drawing.Point(155, 149);
            this._btRefreshDevices.Name = "_btRefreshDevices";
            this._btRefreshDevices.Size = new System.Drawing.Size(75, 23);
            this._btRefreshDevices.TabIndex = 1;
            this._btRefreshDevices.Text = "Refresh";
            this._btRefreshDevices.Click += new System.EventHandler(this.OnRefreshDevicesClick);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(9, 37);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(23, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "URL:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this._statusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 304);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(645, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(130, 17);
            this.toolStripStatusLabel1.Text = "Last Operation Results: ";
            // 
            // _statusLabel
            // 
            this._statusLabel.Name = "_statusLabel";
            this._statusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // _codeGroup
            // 
            this._codeGroup.Controls.Add(this._teCodeValue);
            this._codeGroup.Controls.Add(this.labelControl10);
            this._codeGroup.Controls.Add(this.labelControl8);
            this._codeGroup.Controls.Add(this.labelControl9);
            this._codeGroup.Controls.Add(this._teCodeMac);
            this._codeGroup.Controls.Add(this._teCodeName);
            this._codeGroup.Controls.Add(this.simpleButton2);
            this._codeGroup.Controls.Add(this._btLearnNewCode);
            this._codeGroup.Controls.Add(this._btRemoveSelected);
            this._codeGroup.Controls.Add(this._btUpdateSelectedCode);
            this._codeGroup.Controls.Add(this._btCodeTest);
            this._codeGroup.Controls.Add(this._btCodesDeviceSave);
            this._codeGroup.Controls.Add(this._btCodesDeviceUpdate);
            this._codeGroup.Controls.Add(this._btCodesDeviceLoad);
            this._codeGroup.Controls.Add(this._btCodesDeviceGet);
            this._codeGroup.Controls.Add(this._codesList);
            this._codeGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this._codeGroup.Location = new System.Drawing.Point(237, 0);
            this._codeGroup.Name = "_codeGroup";
            this._codeGroup.Size = new System.Drawing.Size(408, 304);
            this._codeGroup.TabIndex = 4;
            this._codeGroup.Text = "Codes";
            // 
            // _teCodeValue
            // 
            this._teCodeValue.Location = new System.Drawing.Point(10, 226);
            this._teCodeValue.Name = "_teCodeValue";
            this._teCodeValue.Size = new System.Drawing.Size(388, 64);
            this._teCodeValue.TabIndex = 8;
            this._teCodeValue.UseOptimizedRendering = true;
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(13, 208);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(29, 13);
            this.labelControl10.TabIndex = 7;
            this.labelControl10.Text = "Code:";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(203, 184);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(78, 13);
            this.labelControl8.TabIndex = 7;
            this.labelControl8.Text = "Device Address:";
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(13, 184);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(31, 13);
            this.labelControl9.TabIndex = 7;
            this.labelControl9.Text = "Name:";
            // 
            // _teCodeMac
            // 
            this._teCodeMac.EditValue = "";
            this._teCodeMac.Location = new System.Drawing.Point(292, 181);
            this._teCodeMac.Name = "_teCodeMac";
            this._teCodeMac.Properties.ReadOnly = true;
            this._teCodeMac.Size = new System.Drawing.Size(106, 20);
            this._teCodeMac.TabIndex = 6;
            this._teCodeMac.Tag = "Type";
            // 
            // _teCodeName
            // 
            this._teCodeName.EditValue = "";
            this._teCodeName.Location = new System.Drawing.Point(50, 181);
            this._teCodeName.Name = "_teCodeName";
            this._teCodeName.Size = new System.Drawing.Size(119, 20);
            this._teCodeName.TabIndex = 6;
            this._teCodeName.Tag = "Type";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(292, 142);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(106, 23);
            this.simpleButton2.TabIndex = 6;
            this.simpleButton2.Text = "Add Manual Code";
            this.simpleButton2.Click += new System.EventHandler(this.OnAddManualCode);
            // 
            // _btLearnNewCode
            // 
            this._btLearnNewCode.Location = new System.Drawing.Point(292, 116);
            this._btLearnNewCode.Name = "_btLearnNewCode";
            this._btLearnNewCode.Size = new System.Drawing.Size(106, 23);
            this._btLearnNewCode.TabIndex = 5;
            this._btLearnNewCode.Text = "Learn New Code";
            this._btLearnNewCode.Click += new System.EventHandler(this.OnLearnNewCode);
            // 
            // _btRemoveSelected
            // 
            this._btRemoveSelected.Location = new System.Drawing.Point(175, 116);
            this._btRemoveSelected.Name = "_btRemoveSelected";
            this._btRemoveSelected.Size = new System.Drawing.Size(106, 23);
            this._btRemoveSelected.TabIndex = 3;
            this._btRemoveSelected.Text = "Remove Selected";
            this._btRemoveSelected.Click += new System.EventHandler(this.OnRemoveSelectedCode);
            // 
            // _btUpdateSelectedCode
            // 
            this._btUpdateSelectedCode.Location = new System.Drawing.Point(175, 90);
            this._btUpdateSelectedCode.Name = "_btUpdateSelectedCode";
            this._btUpdateSelectedCode.Size = new System.Drawing.Size(106, 23);
            this._btUpdateSelectedCode.TabIndex = 2;
            this._btUpdateSelectedCode.Text = "Update Selected";
            this._btUpdateSelectedCode.Click += new System.EventHandler(this.OnUpdateSelectedCodeClick);
            // 
            // _btCodeTest
            // 
            this._btCodeTest.Location = new System.Drawing.Point(175, 142);
            this._btCodeTest.Name = "_btCodeTest";
            this._btCodeTest.Size = new System.Drawing.Size(106, 23);
            this._btCodeTest.TabIndex = 4;
            this._btCodeTest.Text = "Test Selected";
            this._btCodeTest.Click += new System.EventHandler(this.OnCodeTest);
            // 
            // _btCodesDeviceSave
            // 
            this._btCodesDeviceSave.Location = new System.Drawing.Point(292, 63);
            this._btCodesDeviceSave.Name = "_btCodesDeviceSave";
            this._btCodesDeviceSave.Size = new System.Drawing.Size(106, 23);
            this._btCodesDeviceSave.TabIndex = 8;
            this._btCodesDeviceSave.Text = "Save To File";
            this._btCodesDeviceSave.Click += new System.EventHandler(this.OnSaveToFileClick);
            // 
            // _btCodesDeviceUpdate
            // 
            this._btCodesDeviceUpdate.Location = new System.Drawing.Point(175, 63);
            this._btCodesDeviceUpdate.Name = "_btCodesDeviceUpdate";
            this._btCodesDeviceUpdate.Size = new System.Drawing.Size(106, 23);
            this._btCodesDeviceUpdate.TabIndex = 1;
            this._btCodesDeviceUpdate.Text = "Update To Device";
            this._btCodesDeviceUpdate.Click += new System.EventHandler(this._btCodesDeviceUpdate_Click);
            // 
            // _btCodesDeviceLoad
            // 
            this._btCodesDeviceLoad.Location = new System.Drawing.Point(292, 36);
            this._btCodesDeviceLoad.Name = "_btCodesDeviceLoad";
            this._btCodesDeviceLoad.Size = new System.Drawing.Size(106, 23);
            this._btCodesDeviceLoad.TabIndex = 7;
            this._btCodesDeviceLoad.Text = "Load From File";
            this._btCodesDeviceLoad.Click += new System.EventHandler(this._btCodesDeviceLoad_Click);
            // 
            // _btCodesDeviceGet
            // 
            this._btCodesDeviceGet.Location = new System.Drawing.Point(175, 36);
            this._btCodesDeviceGet.Name = "_btCodesDeviceGet";
            this._btCodesDeviceGet.Size = new System.Drawing.Size(106, 23);
            this._btCodesDeviceGet.TabIndex = 0;
            this._btCodesDeviceGet.Text = "Get From Device";
            this._btCodesDeviceGet.Click += new System.EventHandler(this.OnGetCodesFromDeviceClick);
            // 
            // _codesList
            // 
            this._codesList.Location = new System.Drawing.Point(9, 34);
            this._codesList.Name = "_codesList";
            this._codesList.Size = new System.Drawing.Size(160, 131);
            this._codesList.TabIndex = 2;
            this._codesList.SelectedValueChanged += new System.EventHandler(this.OnCodesListSelectedValueChanged);
            // 
            // RmProConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 326);
            this.Controls.Add(this._codeGroup);
            this.Controls.Add(this._commandsGroup);
            this.Controls.Add(this.statusStrip1);
            this.Name = "RmProConfigForm";
            this.Text = "RM Home Configurator";
            ((System.ComponentModel.ISupportInitialize)(this._devicesList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._commandsGroup)).EndInit();
            this._commandsGroup.ResumeLayout(false);
            this._commandsGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._deviceLockedInfo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._deviceAddressInfo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._deviceIdInfo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._deviceTypeInfo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._deviceUrl.Properties)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._codeGroup)).EndInit();
            this._codeGroup.ResumeLayout(false);
            this._codeGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._teCodeValue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._teCodeMac.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._teCodeName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._codesList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.ListBoxControl _devicesList;
        private DevExpress.XtraEditors.GroupControl _commandsGroup;
        private DevExpress.XtraEditors.SimpleButton _btRefreshDevices;
        private DevExpress.XtraEditors.TextEdit _deviceUrl;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel _statusLabel;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit _deviceLockedInfo;
        private DevExpress.XtraEditors.TextEdit _deviceAddressInfo;
        private DevExpress.XtraEditors.TextEdit _deviceIdInfo;
        private DevExpress.XtraEditors.TextEdit _deviceTypeInfo;
        private DevExpress.XtraEditors.GroupControl _codeGroup;
        private DevExpress.XtraEditors.SimpleButton _btCodesDeviceSave;
        private DevExpress.XtraEditors.SimpleButton _btCodesDeviceUpdate;
        private DevExpress.XtraEditors.SimpleButton _btCodesDeviceLoad;
        private DevExpress.XtraEditors.SimpleButton _btCodesDeviceGet;
        private DevExpress.XtraEditors.ListBoxControl _codesList;
        private DevExpress.XtraEditors.MemoEdit _teCodeValue;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.TextEdit _teCodeMac;
        private DevExpress.XtraEditors.TextEdit _teCodeName;
        private DevExpress.XtraEditors.SimpleButton _btUpdateSelectedCode;
        private DevExpress.XtraEditors.SimpleButton _btCodeTest;
        private DevExpress.XtraEditors.SimpleButton _btRemoveSelected;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton _btLearnNewCode;
    }
}

