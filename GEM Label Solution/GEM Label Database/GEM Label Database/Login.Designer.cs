namespace GEM_Label_Database
{
    partial class LoginWindow
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
        /// 

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginWindow));
            this.Loginlabel = new GEM_Label_Database.MouseTransparentLabel();
            this.UsernameLabel = new GEM_Label_Database.MouseTransparentLabel();
            this.PasswordLabel = new GEM_Label_Database.MouseTransparentLabel();
            this.Password = new System.Windows.Forms.TextBox();
            this.Username = new GEM_Label_Database.UsernameTextBox();
            this.Logo = new GEM_Label_Database.MouseTransparentPanel();
            this.HSplitter = new GEM_Label_Database.MouseTransparentPanel();
            this.SubmitPanel = new System.Windows.Forms.Panel();
            this.SubmitLabel = new GEM_Label_Database.MouseTransparentLabel();
            this.CancelPanel = new System.Windows.Forms.Panel();
            this.CancelLabel = new GEM_Label_Database.MouseTransparentLabel();
            this.ClosePanel = new System.Windows.Forms.Panel();
            this.MinimizePanel = new System.Windows.Forms.Panel();
            this.EnterPress = new System.Windows.Forms.Button();
            this.SubmitPanel.SuspendLayout();
            this.CancelPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Loginlabel
            // 
            this.Loginlabel.AutoSize = true;
            this.Loginlabel.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold);
            this.Loginlabel.Location = new System.Drawing.Point(20, -3);
            this.Loginlabel.Name = "Loginlabel";
            this.Loginlabel.Size = new System.Drawing.Size(99, 32);
            this.Loginlabel.TabIndex = 0;
            this.Loginlabel.Text = "Log In";
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLabel.Location = new System.Drawing.Point(12, 64);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(59, 14);
            this.UsernameLabel.TabIndex = 0;
            this.UsernameLabel.Text = "Username:";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.Location = new System.Drawing.Point(12, 92);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(60, 14);
            this.PasswordLabel.TabIndex = 0;
            this.PasswordLabel.Text = "Password:";
            // 
            // Password
            // 
            this.Password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Password.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.Location = new System.Drawing.Point(76, 93);
            this.Password.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(100, 13);
            this.Password.TabIndex = 1;
            // 
            // Username
            // 
            this.Username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Username.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.Location = new System.Drawing.Point(76, 65);
            this.Username.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(100, 13);
            this.Username.TabIndex = 0;
            // 
            // Logo
            // 
            this.Logo.BackColor = System.Drawing.Color.Transparent;
            this.Logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Logo.BackgroundImage")));
            this.Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Logo.Location = new System.Drawing.Point(1, 1);
            this.Logo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(24, 24);
            this.Logo.TabIndex = 4;
            // 
            // HSplitter
            // 
            this.HSplitter.BackgroundImage = global::GEM_Label_Database.Properties.Resources.HSplitter;
            this.HSplitter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.HSplitter.Location = new System.Drawing.Point(0, 29);
            this.HSplitter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.HSplitter.Name = "HSplitter";
            this.HSplitter.Size = new System.Drawing.Size(191, 5);
            this.HSplitter.TabIndex = 5;
            // 
            // SubmitPanel
            // 
            this.SubmitPanel.BackColor = System.Drawing.Color.Transparent;
            this.SubmitPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SubmitPanel.Controls.Add(this.SubmitLabel);
            this.SubmitPanel.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitPanel.Location = new System.Drawing.Point(25, 144);
            this.SubmitPanel.Name = "SubmitPanel";
            this.SubmitPanel.Size = new System.Drawing.Size(66, 24);
            this.SubmitPanel.TabIndex = 9;
            this.SubmitPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Submit_Click);
            this.SubmitPanel.MouseLeave += new System.EventHandler(this.Submit_Leave);
            this.SubmitPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Submit_Hover);
            // 
            // SubmitLabel
            // 
            this.SubmitLabel.AutoSize = true;
            this.SubmitLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.SubmitLabel.Location = new System.Drawing.Point(11, 4);
            this.SubmitLabel.Name = "SubmitLabel";
            this.SubmitLabel.Size = new System.Drawing.Size(45, 15);
            this.SubmitLabel.TabIndex = 0;
            this.SubmitLabel.Text = "Submit";
            // 
            // CancelPanel
            // 
            this.CancelPanel.BackColor = System.Drawing.Color.Transparent;
            this.CancelPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelPanel.Controls.Add(this.CancelLabel);
            this.CancelPanel.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelPanel.Location = new System.Drawing.Point(97, 144);
            this.CancelPanel.Name = "CancelPanel";
            this.CancelPanel.Size = new System.Drawing.Size(66, 24);
            this.CancelPanel.TabIndex = 9;
            this.CancelPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Cancel_Click);
            this.CancelPanel.MouseLeave += new System.EventHandler(this.Cancel_Leave);
            this.CancelPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Cancel_Hover);
            // 
            // CancelLabel
            // 
            this.CancelLabel.AutoSize = true;
            this.CancelLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.CancelLabel.Location = new System.Drawing.Point(11, 4);
            this.CancelLabel.Name = "CancelLabel";
            this.CancelLabel.Size = new System.Drawing.Size(44, 15);
            this.CancelLabel.TabIndex = 0;
            this.CancelLabel.Text = "Cancel";
            // 
            // ClosePanel
            // 
            this.ClosePanel.BackColor = System.Drawing.Color.Transparent;
            this.ClosePanel.BackgroundImage = global::GEM_Label_Database.Properties.Resources.Close_Button;
            this.ClosePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClosePanel.Location = new System.Drawing.Point(164, -1);
            this.ClosePanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ClosePanel.Name = "ClosePanel";
            this.ClosePanel.Size = new System.Drawing.Size(27, 29);
            this.ClosePanel.TabIndex = 10;
            this.ClosePanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Close_Click);
            this.ClosePanel.MouseLeave += new System.EventHandler(this.Close_Leave);
            this.ClosePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Close_Hover);
            // 
            // MinimizePanel
            // 
            this.MinimizePanel.BackColor = System.Drawing.Color.Transparent;
            this.MinimizePanel.BackgroundImage = global::GEM_Label_Database.Properties.Resources.Minimize_Button;
            this.MinimizePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MinimizePanel.Location = new System.Drawing.Point(138, -1);
            this.MinimizePanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimizePanel.Name = "MinimizePanel";
            this.MinimizePanel.Size = new System.Drawing.Size(27, 29);
            this.MinimizePanel.TabIndex = 11;
            this.MinimizePanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Minimize_Click);
            this.MinimizePanel.MouseLeave += new System.EventHandler(this.Minimize_Leave);
            this.MinimizePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Minimize_Hover);
            // 
            // EnterPress
            // 
            this.EnterPress.Location = new System.Drawing.Point(97, 115);
            this.EnterPress.Name = "EnterPress";
            this.EnterPress.Size = new System.Drawing.Size(0, 0);
            this.EnterPress.TabIndex = 12;
            this.EnterPress.Text = "Enter";
            this.EnterPress.UseVisualStyleBackColor = true;
            this.EnterPress.UseWaitCursor = true;
            this.EnterPress.Click += new System.EventHandler(this.Submit_Click);
            // 
            // LoginWindow
            // 
            this.AcceptButton = this.EnterPress;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(190, 178);
            this.Controls.Add(this.EnterPress);
            this.Controls.Add(this.ClosePanel);
            this.Controls.Add(this.MinimizePanel);
            this.Controls.Add(this.CancelPanel);
            this.Controls.Add(this.SubmitPanel);
            this.Controls.Add(this.HSplitter);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.Loginlabel);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "LoginWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log In";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SubmitPanel.ResumeLayout(false);
            this.SubmitPanel.PerformLayout();
            this.CancelPanel.ResumeLayout(false);
            this.CancelPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MouseTransparentLabel Loginlabel;
        private MouseTransparentLabel UsernameLabel;
        private MouseTransparentLabel PasswordLabel;
        private System.Windows.Forms.TextBox Password;
        private UsernameTextBox Username;
        private MouseTransparentPanel Logo;
        private MouseTransparentPanel HSplitter;
        private System.Windows.Forms.Panel SubmitPanel;
        private MouseTransparentLabel SubmitLabel;
        private System.Windows.Forms.Panel CancelPanel;
        private MouseTransparentLabel CancelLabel;
        private System.Windows.Forms.Panel ClosePanel;
        private System.Windows.Forms.Panel MinimizePanel;
        private System.Windows.Forms.Button EnterPress;
    }
}

