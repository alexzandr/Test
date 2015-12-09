namespace SmartHomeSolution
{
    partial class EnterCodeNameForm
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
            this._txtValue = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this._btOk = new DevExpress.XtraEditors.SimpleButton();
            this.btCancel = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this._txtValue.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // _txtValue
            // 
            this._txtValue.Location = new System.Drawing.Point(106, 12);
            this._txtValue.Name = "_txtValue";
            this._txtValue.Size = new System.Drawing.Size(166, 20);
            this._txtValue.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 15);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(79, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "New Code Name";
            // 
            // _btOk
            // 
            this._btOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this._btOk.Location = new System.Drawing.Point(106, 52);
            this._btOk.Name = "_btOk";
            this._btOk.Size = new System.Drawing.Size(75, 23);
            this._btOk.TabIndex = 2;
            this._btOk.Text = "OK";
            this._btOk.Click += new System.EventHandler(this._btOk_Click);
            // 
            // btCancel
            // 
            this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancel.Location = new System.Drawing.Point(197, 52);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 2;
            this.btCancel.Text = "Cancel";
            // 
            // EnterCodeNameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 91);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this._btOk);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this._txtValue);
            this.Name = "EnterCodeNameForm";
            this.Text = "Learn New Code";
            ((System.ComponentModel.ISupportInitialize)(this._txtValue.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit _txtValue;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton _btOk;
        private DevExpress.XtraEditors.SimpleButton btCancel;
    }
}