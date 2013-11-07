namespace GEM_Label_Database
{
    partial class ExportSettings
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
            this.PrinterCodeLabel = new System.Windows.Forms.Label();
            this.ClientAccessCodeLabel = new System.Windows.Forms.Label();
            this.PostalServiceLabel = new System.Windows.Forms.Label();
            this.PostalClassLabel = new System.Windows.Forms.Label();
            this.PostalFormatLabel = new System.Windows.Forms.Label();
            this.PrinterCode = new System.Windows.Forms.TextBox();
            this.ClientAccessCode = new System.Windows.Forms.TextBox();
            this.PostalService = new System.Windows.Forms.TextBox();
            this.PostalClass = new System.Windows.Forms.TextBox();
            this.PostalFormat = new System.Windows.Forms.TextBox();
            this.Continue = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PrinterCodeLabel
            // 
            this.PrinterCodeLabel.AutoSize = true;
            this.PrinterCodeLabel.Location = new System.Drawing.Point(31, 38);
            this.PrinterCodeLabel.Name = "PrinterCodeLabel";
            this.PrinterCodeLabel.Size = new System.Drawing.Size(68, 17);
            this.PrinterCodeLabel.TabIndex = 0;
            this.PrinterCodeLabel.Text = "Printer Code";
            this.PrinterCodeLabel.UseCompatibleTextRendering = true;
            // 
            // ClientAccessCodeLabel
            // 
            this.ClientAccessCodeLabel.AutoSize = true;
            this.ClientAccessCodeLabel.Location = new System.Drawing.Point(31, 64);
            this.ClientAccessCodeLabel.Name = "ClientAccessCodeLabel";
            this.ClientAccessCodeLabel.Size = new System.Drawing.Size(99, 13);
            this.ClientAccessCodeLabel.TabIndex = 1;
            this.ClientAccessCodeLabel.Text = "Client Access Code";
            // 
            // PostalServiceLabel
            // 
            this.PostalServiceLabel.AutoSize = true;
            this.PostalServiceLabel.Location = new System.Drawing.Point(31, 90);
            this.PostalServiceLabel.Name = "PostalServiceLabel";
            this.PostalServiceLabel.Size = new System.Drawing.Size(75, 13);
            this.PostalServiceLabel.TabIndex = 2;
            this.PostalServiceLabel.Text = "Postal Service";
            // 
            // PostalClassLabel
            // 
            this.PostalClassLabel.AutoSize = true;
            this.PostalClassLabel.Location = new System.Drawing.Point(31, 116);
            this.PostalClassLabel.Name = "PostalClassLabel";
            this.PostalClassLabel.Size = new System.Drawing.Size(64, 13);
            this.PostalClassLabel.TabIndex = 3;
            this.PostalClassLabel.Text = "Postal Class";
            // 
            // PostalFormatLabel
            // 
            this.PostalFormatLabel.AutoSize = true;
            this.PostalFormatLabel.Location = new System.Drawing.Point(31, 142);
            this.PostalFormatLabel.Name = "PostalFormatLabel";
            this.PostalFormatLabel.Size = new System.Drawing.Size(71, 13);
            this.PostalFormatLabel.TabIndex = 4;
            this.PostalFormatLabel.Text = "Postal Format";
            // 
            // PrinterCode
            // 
            this.PrinterCode.Location = new System.Drawing.Point(136, 38);
            this.PrinterCode.Name = "PrinterCode";
            this.PrinterCode.Size = new System.Drawing.Size(75, 20);
            this.PrinterCode.TabIndex = 5;
            this.PrinterCode.Text = "2";
            // 
            // ClientAccessCode
            // 
            this.ClientAccessCode.Location = new System.Drawing.Point(136, 64);
            this.ClientAccessCode.Name = "ClientAccessCode";
            this.ClientAccessCode.Size = new System.Drawing.Size(75, 20);
            this.ClientAccessCode.TabIndex = 6;
            this.ClientAccessCode.Text = "081110999";
            // 
            // PostalService
            // 
            this.PostalService.Location = new System.Drawing.Point(136, 87);
            this.PostalService.Name = "PostalService";
            this.PostalService.Size = new System.Drawing.Size(75, 20);
            this.PostalService.TabIndex = 7;
            this.PostalService.Text = "CRL01";
            // 
            // PostalClass
            // 
            this.PostalClass.Location = new System.Drawing.Point(136, 113);
            this.PostalClass.Name = "PostalClass";
            this.PostalClass.Size = new System.Drawing.Size(75, 20);
            this.PostalClass.TabIndex = 8;
            this.PostalClass.Text = "1";
            // 
            // PostalFormat
            // 
            this.PostalFormat.Location = new System.Drawing.Point(136, 139);
            this.PostalFormat.Name = "PostalFormat";
            this.PostalFormat.Size = new System.Drawing.Size(75, 20);
            this.PostalFormat.TabIndex = 9;
            this.PostalFormat.Text = "P";
            // 
            // Continue
            // 
            this.Continue.Location = new System.Drawing.Point(109, 165);
            this.Continue.Name = "Continue";
            this.Continue.Size = new System.Drawing.Size(102, 23);
            this.Continue.TabIndex = 11;
            this.Continue.Text = "Continue";
            this.Continue.UseVisualStyleBackColor = true;
            this.Continue.Click += new System.EventHandler(this.Continue_Click);
            // 
            // ExportSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 203);
            this.Controls.Add(this.Continue);
            this.Controls.Add(this.PostalFormat);
            this.Controls.Add(this.PostalClass);
            this.Controls.Add(this.PostalService);
            this.Controls.Add(this.ClientAccessCode);
            this.Controls.Add(this.PrinterCode);
            this.Controls.Add(this.PostalFormatLabel);
            this.Controls.Add(this.PostalClassLabel);
            this.Controls.Add(this.PostalServiceLabel);
            this.Controls.Add(this.ClientAccessCodeLabel);
            this.Controls.Add(this.PrinterCodeLabel);
            this.Name = "ExportSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Export Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PrinterCodeLabel;
        private System.Windows.Forms.Label ClientAccessCodeLabel;
        private System.Windows.Forms.Label PostalServiceLabel;
        private System.Windows.Forms.Label PostalClassLabel;
        private System.Windows.Forms.Label PostalFormatLabel;
        private System.Windows.Forms.TextBox PrinterCode;
        private System.Windows.Forms.TextBox ClientAccessCode;
        private System.Windows.Forms.TextBox PostalService;
        private System.Windows.Forms.TextBox PostalClass;
        private System.Windows.Forms.TextBox PostalFormat;
        private System.Windows.Forms.Button Continue;
    }
}

