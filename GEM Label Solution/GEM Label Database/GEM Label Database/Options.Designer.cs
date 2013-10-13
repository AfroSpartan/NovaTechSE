namespace GEM_Label_Database
{
    partial class OptionsWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OptionsWindow));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.AccountCancel = new System.Windows.Forms.Button();
            this.OptionsExitButton = new System.Windows.Forms.Button();
            this.AccountOkay = new System.Windows.Forms.Button();
            this.RetypePassword = new System.Windows.Forms.TextBox();
            this.AccountPassword = new System.Windows.Forms.TextBox();
            this.RetypePasswordLabel = new System.Windows.Forms.Label();
            this.AccountName = new System.Windows.Forms.TextBox();
            this.AccountPasswordLabel = new System.Windows.Forms.Label();
            this.AccountNameLabel = new System.Windows.Forms.Label();
            this.DeleteAccount = new System.Windows.Forms.Button();
            this.EditAccount = new System.Windows.Forms.Button();
            this.CreateAccount = new System.Windows.Forms.Button();
            this.AccountList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(586, 416);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.AccountCancel);
            this.tabPage1.Controls.Add(this.OptionsExitButton);
            this.tabPage1.Controls.Add(this.AccountOkay);
            this.tabPage1.Controls.Add(this.RetypePassword);
            this.tabPage1.Controls.Add(this.AccountPassword);
            this.tabPage1.Controls.Add(this.RetypePasswordLabel);
            this.tabPage1.Controls.Add(this.AccountName);
            this.tabPage1.Controls.Add(this.AccountPasswordLabel);
            this.tabPage1.Controls.Add(this.AccountNameLabel);
            this.tabPage1.Controls.Add(this.DeleteAccount);
            this.tabPage1.Controls.Add(this.EditAccount);
            this.tabPage1.Controls.Add(this.CreateAccount);
            this.tabPage1.Controls.Add(this.AccountList);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(578, 390);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Account Settings";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // AccountCancel
            // 
            this.AccountCancel.Location = new System.Drawing.Point(240, 321);
            this.AccountCancel.Name = "AccountCancel";
            this.AccountCancel.Size = new System.Drawing.Size(75, 23);
            this.AccountCancel.TabIndex = 9;
            this.AccountCancel.Text = "Cancel";
            this.AccountCancel.UseVisualStyleBackColor = true;
            this.AccountCancel.Click += new System.EventHandler(this.AccountCancel_Click);
            // 
            // OptionsExitButton
            // 
            this.OptionsExitButton.Location = new System.Drawing.Point(10, 350);
            this.OptionsExitButton.Name = "OptionsExitButton";
            this.OptionsExitButton.Size = new System.Drawing.Size(75, 23);
            this.OptionsExitButton.TabIndex = 10;
            this.OptionsExitButton.Text = "Exit";
            this.OptionsExitButton.UseVisualStyleBackColor = true;
            this.OptionsExitButton.Click += new System.EventHandler(this.OptionsExit_Click);
            // 
            // AccountOkay
            // 
            this.AccountOkay.Location = new System.Drawing.Point(10, 321);
            this.AccountOkay.Name = "AccountOkay";
            this.AccountOkay.Size = new System.Drawing.Size(75, 23);
            this.AccountOkay.TabIndex = 8;
            this.AccountOkay.Text = "OK";
            this.AccountOkay.UseVisualStyleBackColor = true;
            this.AccountOkay.Click += new System.EventHandler(this.AccountOkay_Click);
            // 
            // RetypePassword
            // 
            this.RetypePassword.Location = new System.Drawing.Point(112, 295);
            this.RetypePassword.Name = "RetypePassword";
            this.RetypePassword.PasswordChar = '*';
            this.RetypePassword.Size = new System.Drawing.Size(203, 20);
            this.RetypePassword.TabIndex = 7;
            // 
            // AccountPassword
            // 
            this.AccountPassword.Location = new System.Drawing.Point(112, 269);
            this.AccountPassword.Name = "AccountPassword";
            this.AccountPassword.PasswordChar = '*';
            this.AccountPassword.Size = new System.Drawing.Size(203, 20);
            this.AccountPassword.TabIndex = 6;
            // 
            // RetypePasswordLabel
            // 
            this.RetypePasswordLabel.AutoSize = true;
            this.RetypePasswordLabel.Location = new System.Drawing.Point(7, 298);
            this.RetypePasswordLabel.Name = "RetypePasswordLabel";
            this.RetypePasswordLabel.Size = new System.Drawing.Size(93, 13);
            this.RetypePasswordLabel.TabIndex = 3;
            this.RetypePasswordLabel.Text = "Retype Password:";
            // 
            // AccountName
            // 
            this.AccountName.Location = new System.Drawing.Point(112, 243);
            this.AccountName.Name = "AccountName";
            this.AccountName.Size = new System.Drawing.Size(203, 20);
            this.AccountName.TabIndex = 5;
            // 
            // AccountPasswordLabel
            // 
            this.AccountPasswordLabel.AutoSize = true;
            this.AccountPasswordLabel.Location = new System.Drawing.Point(7, 272);
            this.AccountPasswordLabel.Name = "AccountPasswordLabel";
            this.AccountPasswordLabel.Size = new System.Drawing.Size(99, 13);
            this.AccountPasswordLabel.TabIndex = 3;
            this.AccountPasswordLabel.Text = "Account Password:";
            // 
            // AccountNameLabel
            // 
            this.AccountNameLabel.AutoSize = true;
            this.AccountNameLabel.Location = new System.Drawing.Point(7, 246);
            this.AccountNameLabel.Name = "AccountNameLabel";
            this.AccountNameLabel.Size = new System.Drawing.Size(81, 13);
            this.AccountNameLabel.TabIndex = 3;
            this.AccountNameLabel.Text = "Account Name:";
            // 
            // DeleteAccount
            // 
            this.DeleteAccount.Location = new System.Drawing.Point(226, 206);
            this.DeleteAccount.Name = "DeleteAccount";
            this.DeleteAccount.Size = new System.Drawing.Size(89, 23);
            this.DeleteAccount.TabIndex = 4;
            this.DeleteAccount.Text = "Delete Account";
            this.DeleteAccount.UseVisualStyleBackColor = true;
            this.DeleteAccount.Click += new System.EventHandler(this.DeleteAccount_Click);
            // 
            // EditAccount
            // 
            this.EditAccount.Location = new System.Drawing.Point(118, 206);
            this.EditAccount.Name = "EditAccount";
            this.EditAccount.Size = new System.Drawing.Size(89, 23);
            this.EditAccount.TabIndex = 3;
            this.EditAccount.Text = "Edit Account";
            this.EditAccount.UseVisualStyleBackColor = true;
            this.EditAccount.Click += new System.EventHandler(this.EditAccount_Click);
            // 
            // CreateAccount
            // 
            this.CreateAccount.Location = new System.Drawing.Point(10, 206);
            this.CreateAccount.Name = "CreateAccount";
            this.CreateAccount.Size = new System.Drawing.Size(89, 23);
            this.CreateAccount.TabIndex = 2;
            this.CreateAccount.Text = "Create Account";
            this.CreateAccount.UseVisualStyleBackColor = true;
            this.CreateAccount.Click += new System.EventHandler(this.CreateAccount_Click);
            // 
            // AccountList
            // 
            this.AccountList.FormattingEnabled = true;
            this.AccountList.Location = new System.Drawing.Point(10, 27);
            this.AccountList.Name = "AccountList";
            this.AccountList.Size = new System.Drawing.Size(305, 173);
            this.AccountList.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Account Settings";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(578, 390);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // OptionsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 440);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OptionsWindow";
            this.Text = "Options";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button CreateAccount;
        private System.Windows.Forms.ListBox AccountList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button EditAccount;
        private System.Windows.Forms.TextBox RetypePassword;
        private System.Windows.Forms.TextBox AccountPassword;
        private System.Windows.Forms.Label RetypePasswordLabel;
        private System.Windows.Forms.TextBox AccountName;
        private System.Windows.Forms.Label AccountPasswordLabel;
        private System.Windows.Forms.Label AccountNameLabel;
        private System.Windows.Forms.Button DeleteAccount;
        private System.Windows.Forms.Button AccountCancel;
        private System.Windows.Forms.Button AccountOkay;
        private System.Windows.Forms.Button OptionsExitButton;
    }
}