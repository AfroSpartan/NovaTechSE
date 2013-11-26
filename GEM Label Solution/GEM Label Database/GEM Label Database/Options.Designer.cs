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
            this.AcceptPanel = new System.Windows.Forms.Panel();
            this.Accept = new GEM_Label_Database.MouseTransparentLabel();
            this.EditPanel = new System.Windows.Forms.Panel();
            this.EditLabel = new GEM_Label_Database.MouseTransparentLabel();
            this.CreatePanel = new System.Windows.Forms.Panel();
            this.CreateLabel = new GEM_Label_Database.MouseTransparentLabel();
            this.DeletePanel = new System.Windows.Forms.Panel();
            this.DeleteLabel = new GEM_Label_Database.MouseTransparentLabel();
            this.CancelPanel = new System.Windows.Forms.Panel();
            this.CancelLabel = new GEM_Label_Database.MouseTransparentLabel();
            this.RetypePassword = new System.Windows.Forms.TextBox();
            this.AccountPassword = new System.Windows.Forms.TextBox();
            this.RetypePasswordLabel = new System.Windows.Forms.Label();
            this.AccountName = new System.Windows.Forms.TextBox();
            this.AccountPasswordLabel = new System.Windows.Forms.Label();
            this.AccountNameLabel = new System.Windows.Forms.Label();
            this.AccountList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Logo = new GEM_Label_Database.MouseTransparentPanel();
            this.HSplitter = new GEM_Label_Database.MouseTransparentPanel();
            this.mouseTransparentLabel1 = new GEM_Label_Database.MouseTransparentLabel();
            this.ClosePanel = new System.Windows.Forms.Panel();
            this.MinimizePanel = new System.Windows.Forms.Panel();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.AcceptPanel.SuspendLayout();
            this.EditPanel.SuspendLayout();
            this.CreatePanel.SuspendLayout();
            this.DeletePanel.SuspendLayout();
            this.CancelPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 36);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(586, 376);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.AcceptPanel);
            this.tabPage1.Controls.Add(this.EditPanel);
            this.tabPage1.Controls.Add(this.CreatePanel);
            this.tabPage1.Controls.Add(this.DeletePanel);
            this.tabPage1.Controls.Add(this.CancelPanel);
            this.tabPage1.Controls.Add(this.RetypePassword);
            this.tabPage1.Controls.Add(this.AccountPassword);
            this.tabPage1.Controls.Add(this.RetypePasswordLabel);
            this.tabPage1.Controls.Add(this.AccountName);
            this.tabPage1.Controls.Add(this.AccountPasswordLabel);
            this.tabPage1.Controls.Add(this.AccountNameLabel);
            this.tabPage1.Controls.Add(this.AccountList);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(578, 350);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Account Settings";
            // 
            // AcceptPanel
            // 
            this.AcceptPanel.BackColor = System.Drawing.Color.Transparent;
            this.AcceptPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AcceptPanel.Controls.Add(this.Accept);
            this.AcceptPanel.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AcceptPanel.Location = new System.Drawing.Point(10, 316);
            this.AcceptPanel.Name = "AcceptPanel";
            this.AcceptPanel.Size = new System.Drawing.Size(66, 22);
            this.AcceptPanel.TabIndex = 11;
            this.AcceptPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Accept_Click);
            this.AcceptPanel.MouseLeave += new System.EventHandler(this.Accept_Leave);
            this.AcceptPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Accept_Hover);
            // 
            // Accept
            // 
            this.Accept.AutoSize = true;
            this.Accept.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Accept.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Accept.Location = new System.Drawing.Point(9, 3);
            this.Accept.Name = "Accept";
            this.Accept.Size = new System.Drawing.Size(49, 16);
            this.Accept.TabIndex = 0;
            this.Accept.Text = "Accept";
            // 
            // EditPanel
            // 
            this.EditPanel.BackColor = System.Drawing.Color.Transparent;
            this.EditPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.EditPanel.Controls.Add(this.EditLabel);
            this.EditPanel.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditPanel.Location = new System.Drawing.Point(121, 206);
            this.EditPanel.Name = "EditPanel";
            this.EditPanel.Size = new System.Drawing.Size(85, 22);
            this.EditPanel.TabIndex = 11;
            this.EditPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Edit_Click);
            this.EditPanel.MouseLeave += new System.EventHandler(this.Edit_Leave);
            this.EditPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Edit_Hover);
            // 
            // EditLabel
            // 
            this.EditLabel.AutoSize = true;
            this.EditLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.EditLabel.Location = new System.Drawing.Point(3, 3);
            this.EditLabel.Name = "EditLabel";
            this.EditLabel.Size = new System.Drawing.Size(82, 16);
            this.EditLabel.TabIndex = 0;
            this.EditLabel.Text = "Edit Account";
            // 
            // CreatePanel
            // 
            this.CreatePanel.BackColor = System.Drawing.Color.Transparent;
            this.CreatePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CreatePanel.Controls.Add(this.CreateLabel);
            this.CreatePanel.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreatePanel.Location = new System.Drawing.Point(10, 206);
            this.CreatePanel.Name = "CreatePanel";
            this.CreatePanel.Size = new System.Drawing.Size(101, 22);
            this.CreatePanel.TabIndex = 11;
            this.CreatePanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Create_Click);
            this.CreatePanel.MouseLeave += new System.EventHandler(this.Create_Leave);
            this.CreatePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Create_Hover);
            // 
            // CreateLabel
            // 
            this.CreateLabel.AutoSize = true;
            this.CreateLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.CreateLabel.Location = new System.Drawing.Point(3, 3);
            this.CreateLabel.Name = "CreateLabel";
            this.CreateLabel.Size = new System.Drawing.Size(97, 16);
            this.CreateLabel.TabIndex = 0;
            this.CreateLabel.Text = "Create Account";
            // 
            // DeletePanel
            // 
            this.DeletePanel.BackColor = System.Drawing.Color.Transparent;
            this.DeletePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DeletePanel.Controls.Add(this.DeleteLabel);
            this.DeletePanel.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeletePanel.Location = new System.Drawing.Point(214, 206);
            this.DeletePanel.Name = "DeletePanel";
            this.DeletePanel.Size = new System.Drawing.Size(101, 22);
            this.DeletePanel.TabIndex = 11;
            this.DeletePanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Delete_Click);
            this.DeletePanel.MouseLeave += new System.EventHandler(this.Delete_Leave);
            this.DeletePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Delete_Hover);
            // 
            // DeleteLabel
            // 
            this.DeleteLabel.AutoSize = true;
            this.DeleteLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.DeleteLabel.Location = new System.Drawing.Point(3, 3);
            this.DeleteLabel.Name = "DeleteLabel";
            this.DeleteLabel.Size = new System.Drawing.Size(96, 16);
            this.DeleteLabel.TabIndex = 0;
            this.DeleteLabel.Text = "Delete Account";
            // 
            // CancelPanel
            // 
            this.CancelPanel.BackColor = System.Drawing.Color.Transparent;
            this.CancelPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelPanel.Controls.Add(this.CancelLabel);
            this.CancelPanel.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelPanel.Location = new System.Drawing.Point(249, 316);
            this.CancelPanel.Name = "CancelPanel";
            this.CancelPanel.Size = new System.Drawing.Size(66, 22);
            this.CancelPanel.TabIndex = 11;
            this.CancelPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Cancel_Click);
            this.CancelPanel.MouseLeave += new System.EventHandler(this.Cancel_Leave);
            this.CancelPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Cancel_Hover);
            // 
            // CancelLabel
            // 
            this.CancelLabel.AutoSize = true;
            this.CancelLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.CancelLabel.Location = new System.Drawing.Point(9, 3);
            this.CancelLabel.Name = "CancelLabel";
            this.CancelLabel.Size = new System.Drawing.Size(48, 16);
            this.CancelLabel.TabIndex = 0;
            this.CancelLabel.Text = "Cancel";
            // 
            // RetypePassword
            // 
            this.RetypePassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RetypePassword.Location = new System.Drawing.Point(112, 289);
            this.RetypePassword.Name = "RetypePassword";
            this.RetypePassword.PasswordChar = '*';
            this.RetypePassword.Size = new System.Drawing.Size(203, 20);
            this.RetypePassword.TabIndex = 7;
            // 
            // AccountPassword
            // 
            this.AccountPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AccountPassword.Location = new System.Drawing.Point(112, 263);
            this.AccountPassword.Name = "AccountPassword";
            this.AccountPassword.PasswordChar = '*';
            this.AccountPassword.Size = new System.Drawing.Size(203, 20);
            this.AccountPassword.TabIndex = 6;
            // 
            // RetypePasswordLabel
            // 
            this.RetypePasswordLabel.AutoSize = true;
            this.RetypePasswordLabel.Location = new System.Drawing.Point(13, 291);
            this.RetypePasswordLabel.Name = "RetypePasswordLabel";
            this.RetypePasswordLabel.Size = new System.Drawing.Size(93, 13);
            this.RetypePasswordLabel.TabIndex = 3;
            this.RetypePasswordLabel.Text = "Retype Password:";
            // 
            // AccountName
            // 
            this.AccountName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AccountName.Location = new System.Drawing.Point(112, 237);
            this.AccountName.Name = "AccountName";
            this.AccountName.Size = new System.Drawing.Size(203, 20);
            this.AccountName.TabIndex = 5;
            // 
            // AccountPasswordLabel
            // 
            this.AccountPasswordLabel.AutoSize = true;
            this.AccountPasswordLabel.Location = new System.Drawing.Point(7, 265);
            this.AccountPasswordLabel.Name = "AccountPasswordLabel";
            this.AccountPasswordLabel.Size = new System.Drawing.Size(99, 13);
            this.AccountPasswordLabel.TabIndex = 3;
            this.AccountPasswordLabel.Text = "Account Password:";
            // 
            // AccountNameLabel
            // 
            this.AccountNameLabel.AutoSize = true;
            this.AccountNameLabel.Location = new System.Drawing.Point(25, 239);
            this.AccountNameLabel.Name = "AccountNameLabel";
            this.AccountNameLabel.Size = new System.Drawing.Size(81, 13);
            this.AccountNameLabel.TabIndex = 3;
            this.AccountNameLabel.Text = "Account Name:";
            // 
            // AccountList
            // 
            this.AccountList.BackColor = System.Drawing.SystemColors.Control;
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
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(578, 390);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            // 
            // Logo
            // 
            this.Logo.BackColor = System.Drawing.Color.Transparent;
            this.Logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Logo.BackgroundImage")));
            this.Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Logo.Location = new System.Drawing.Point(1, 1);
            this.Logo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(24, 22);
            this.Logo.TabIndex = 16;
            // 
            // HSplitter
            // 
            this.HSplitter.BackgroundImage = global::GEM_Label_Database.Properties.Resources.HSplitter;
            this.HSplitter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.HSplitter.Location = new System.Drawing.Point(-1, 26);
            this.HSplitter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.HSplitter.Name = "HSplitter";
            this.HSplitter.Size = new System.Drawing.Size(620, 5);
            this.HSplitter.TabIndex = 15;
            // 
            // mouseTransparentLabel1
            // 
            this.mouseTransparentLabel1.AutoSize = true;
            this.mouseTransparentLabel1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mouseTransparentLabel1.Location = new System.Drawing.Point(25, -3);
            this.mouseTransparentLabel1.Name = "mouseTransparentLabel1";
            this.mouseTransparentLabel1.Size = new System.Drawing.Size(201, 32);
            this.mouseTransparentLabel1.TabIndex = 14;
            this.mouseTransparentLabel1.Text = "Import Orders";
            // 
            // ClosePanel
            // 
            this.ClosePanel.BackColor = System.Drawing.Color.Transparent;
            this.ClosePanel.BackgroundImage = global::GEM_Label_Database.Properties.Resources.Close_Button;
            this.ClosePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClosePanel.Location = new System.Drawing.Point(580, -1);
            this.ClosePanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ClosePanel.Name = "ClosePanel";
            this.ClosePanel.Size = new System.Drawing.Size(27, 27);
            this.ClosePanel.TabIndex = 17;
            this.ClosePanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Close_Click);
            this.ClosePanel.MouseLeave += new System.EventHandler(this.Close_Leave);
            this.ClosePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Close_Hover);
            // 
            // MinimizePanel
            // 
            this.MinimizePanel.BackColor = System.Drawing.Color.Transparent;
            this.MinimizePanel.BackgroundImage = global::GEM_Label_Database.Properties.Resources.Minimize_Button;
            this.MinimizePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MinimizePanel.Location = new System.Drawing.Point(554, -1);
            this.MinimizePanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimizePanel.Name = "MinimizePanel";
            this.MinimizePanel.Size = new System.Drawing.Size(27, 27);
            this.MinimizePanel.TabIndex = 18;
            this.MinimizePanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Minimize_Click);
            this.MinimizePanel.MouseLeave += new System.EventHandler(this.Minimize_Leave);
            this.MinimizePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Minimize_Hover);
            // 
            // OptionsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 424);
            this.Controls.Add(this.ClosePanel);
            this.Controls.Add(this.MinimizePanel);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.HSplitter);
            this.Controls.Add(this.mouseTransparentLabel1);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OptionsWindow";
            this.Text = "Options";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.AcceptPanel.ResumeLayout(false);
            this.AcceptPanel.PerformLayout();
            this.EditPanel.ResumeLayout(false);
            this.EditPanel.PerformLayout();
            this.CreatePanel.ResumeLayout(false);
            this.CreatePanel.PerformLayout();
            this.DeletePanel.ResumeLayout(false);
            this.DeletePanel.PerformLayout();
            this.CancelPanel.ResumeLayout(false);
            this.CancelPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox RetypePassword;
        private System.Windows.Forms.TextBox AccountPassword;
        private System.Windows.Forms.Label RetypePasswordLabel;
        private System.Windows.Forms.TextBox AccountName;
        private System.Windows.Forms.Label AccountPasswordLabel;
        private System.Windows.Forms.Label AccountNameLabel;
        private System.Windows.Forms.ListBox AccountList;
        private MouseTransparentPanel Logo;
        private MouseTransparentPanel HSplitter;
        private MouseTransparentLabel mouseTransparentLabel1;
        private System.Windows.Forms.Panel ClosePanel;
        private System.Windows.Forms.Panel MinimizePanel;
        private System.Windows.Forms.Panel AcceptPanel;
        private MouseTransparentLabel Accept;
        private System.Windows.Forms.Panel EditPanel;
        private MouseTransparentLabel EditLabel;
        private System.Windows.Forms.Panel CreatePanel;
        private MouseTransparentLabel CreateLabel;
        private System.Windows.Forms.Panel DeletePanel;
        private MouseTransparentLabel DeleteLabel;
        private System.Windows.Forms.Panel CancelPanel;
        private MouseTransparentLabel CancelLabel;
    }
}