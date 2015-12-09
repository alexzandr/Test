namespace SmartHomeSolution
{
    partial class EnterCodeDetailsForm
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
            this._teCodeValue = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this._teCodeMac = new DevExpress.XtraEditors.TextEdit();
            this._teCodeName = new DevExpress.XtraEditors.TextEdit();
            this.chkUseMac = new DevExpress.XtraEditors.CheckEdit();
            this.btCancel = new DevExpress.XtraEditors.SimpleButton();
            this._btOk = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this._teCodeValue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._teCodeMac.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._teCodeName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkUseMac.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // _teCodeValue
            // 
            this._teCodeValue.Location = new System.Drawing.Point(12, 53);
            this._teCodeValue.Name = "_teCodeValue";
            this._teCodeValue.Size = new System.Drawing.Size(454, 92);
            this._teCodeValue.TabIndex = 3;
            this._teCodeValue.UseOptimizedRendering = true;
            this._teCodeValue.Validating += new System.ComponentModel.CancelEventHandler(this._teCodeValue_Validating);
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(12, 35);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(29, 13);
            this.labelControl10.TabIndex = 14;
            this.labelControl10.Text = "Code:";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(182, 12);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(78, 13);
            this.labelControl8.TabIndex = 15;
            this.labelControl8.Text = "Device Address:";
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(12, 12);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(31, 13);
            this.labelControl9.TabIndex = 16;
            this.labelControl9.Text = "Name:";
            // 
            // _teCodeMac
            // 
            this._teCodeMac.EditValue = "";
            this._teCodeMac.Location = new System.Drawing.Point(271, 9);
            this._teCodeMac.Name = "_teCodeMac";
            this._teCodeMac.Properties.ReadOnly = true;
            this._teCodeMac.Size = new System.Drawing.Size(106, 20);
            this._teCodeMac.TabIndex = 1;
            this._teCodeMac.Tag = "Type";
            this._teCodeMac.Validating += new System.ComponentModel.CancelEventHandler(this._teCodeMac_Validating);
            // 
            // _teCodeName
            // 
            this._teCodeName.EditValue = "";
            this._teCodeName.Location = new System.Drawing.Point(49, 9);
            this._teCodeName.Name = "_teCodeName";
            this._teCodeName.Size = new System.Drawing.Size(119, 20);
            this._teCodeName.TabIndex = 0;
            this._teCodeName.Tag = "Type";
            this._teCodeName.Validating += new System.ComponentModel.CancelEventHandler(this._teCodeName_Validating);
            // 
            // chkUseMac
            // 
            this.chkUseMac.EditValue = true;
            this.chkUseMac.Location = new System.Drawing.Point(383, 10);
            this.chkUseMac.Name = "chkUseMac";
            this.chkUseMac.Properties.Caption = "Use Selected";
            this.chkUseMac.Size = new System.Drawing.Size(83, 19);
            this.chkUseMac.TabIndex = 2;
            this.chkUseMac.CheckStateChanged += new System.EventHandler(this.chkUseMac_CheckStateChanged);
            // 
            // btCancel
            // 
            this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancel.Location = new System.Drawing.Point(391, 151);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 5;
            this.btCancel.Text = "Cancel";
            // 
            // _btOk
            // 
            this._btOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this._btOk.Location = new System.Drawing.Point(300, 151);
            this._btOk.Name = "_btOk";
            this._btOk.Size = new System.Drawing.Size(75, 23);
            this._btOk.TabIndex = 4;
            this._btOk.Text = "OK";
            this._btOk.Click += new System.EventHandler(this._btOk_Click);
            // 
            // EnterCodeDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 181);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this._btOk);
            this.Controls.Add(this.chkUseMac);
            this.Controls.Add(this._teCodeValue);
            this.Controls.Add(this.labelControl10);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this._teCodeMac);
            this.Controls.Add(this._teCodeName);
            this.Name = "EnterCodeDetailsForm";
            this.Text = "EnterCodeDetails";
            ((System.ComponentModel.ISupportInitialize)(this._teCodeValue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._teCodeMac.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._teCodeName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkUseMac.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.MemoEdit _teCodeValue;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.TextEdit _teCodeMac;
        private DevExpress.XtraEditors.TextEdit _teCodeName;
        private DevExpress.XtraEditors.CheckEdit chkUseMac;
        private DevExpress.XtraEditors.SimpleButton btCancel;
        private DevExpress.XtraEditors.SimpleButton _btOk;
    }
}