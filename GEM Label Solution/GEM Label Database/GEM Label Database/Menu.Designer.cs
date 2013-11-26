namespace GEM_Label_Database
{
    partial class MenuWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuWindow));
            this.HSplitter = new GEM_Label_Database.MouseTransparentPanel();
            this.Logo = new GEM_Label_Database.MouseTransparentPanel();
            this.WTitleLabel = new GEM_Label_Database.MouseTransparentLabel();
            this.ImportPanel = new System.Windows.Forms.Panel();
            this.ImportLabel = new GEM_Label_Database.MouseTransparentLabel();
            this.PrintPanel = new System.Windows.Forms.Panel();
            this.PrintLabel = new GEM_Label_Database.MouseTransparentLabel();
            this.OptionsPanel = new System.Windows.Forms.Panel();
            this.OptionsLabel = new GEM_Label_Database.MouseTransparentLabel();
            this.ExitPanel = new System.Windows.Forms.Panel();
            this.ExitLabel = new GEM_Label_Database.MouseTransparentLabel();
            this.ClosePanel = new System.Windows.Forms.Panel();
            this.MinimizePanel = new System.Windows.Forms.Panel();
            this.ImportPanel.SuspendLayout();
            this.PrintPanel.SuspendLayout();
            this.OptionsPanel.SuspendLayout();
            this.ExitPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // HSplitter
            // 
            this.HSplitter.BackgroundImage = global::GEM_Label_Database.Properties.Resources.HSplitter;
            this.HSplitter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.HSplitter.Location = new System.Drawing.Point(0, 26);
            this.HSplitter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.HSplitter.Name = "HSplitter";
            this.HSplitter.Size = new System.Drawing.Size(200, 5);
            this.HSplitter.TabIndex = 5;
            // 
            // Logo
            // 
            this.Logo.BackColor = System.Drawing.Color.Transparent;
            this.Logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Logo.BackgroundImage")));
            this.Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Logo.Location = new System.Drawing.Point(1, 2);
            this.Logo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(24, 22);
            this.Logo.TabIndex = 6;
            // 
            // WTitleLabel
            // 
            this.WTitleLabel.AutoSize = true;
            this.WTitleLabel.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WTitleLabel.Location = new System.Drawing.Point(21, -2);
            this.WTitleLabel.Name = "WTitleLabel";
            this.WTitleLabel.Size = new System.Drawing.Size(85, 32);
            this.WTitleLabel.TabIndex = 7;
            this.WTitleLabel.Text = "Menu";
            // 
            // ImportPanel
            // 
            this.ImportPanel.BackColor = System.Drawing.Color.Transparent;
            this.ImportPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ImportPanel.Controls.Add(this.ImportLabel);
            this.ImportPanel.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImportPanel.Location = new System.Drawing.Point(62, 50);
            this.ImportPanel.Name = "ImportPanel";
            this.ImportPanel.Size = new System.Drawing.Size(66, 22);
            this.ImportPanel.TabIndex = 9;
            this.ImportPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Import_Click);
            this.ImportPanel.MouseLeave += new System.EventHandler(this.Import_Leave);
            this.ImportPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Import_Hover);
            // 
            // ImportLabel
            // 
            this.ImportLabel.AutoSize = true;
            this.ImportLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImportLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ImportLabel.Location = new System.Drawing.Point(11, 3);
            this.ImportLabel.Name = "ImportLabel";
            this.ImportLabel.Size = new System.Drawing.Size(44, 16);
            this.ImportLabel.TabIndex = 0;
            this.ImportLabel.Text = "Import";
            // 
            // PrintPanel
            // 
            this.PrintPanel.BackColor = System.Drawing.Color.Transparent;
            this.PrintPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PrintPanel.Controls.Add(this.PrintLabel);
            this.PrintPanel.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrintPanel.Location = new System.Drawing.Point(62, 78);
            this.PrintPanel.Name = "PrintPanel";
            this.PrintPanel.Size = new System.Drawing.Size(66, 22);
            this.PrintPanel.TabIndex = 10;
            this.PrintPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Print_Click);
            this.PrintPanel.MouseLeave += new System.EventHandler(this.Print_Leave);
            this.PrintPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Print_Hover);
            // 
            // PrintLabel
            // 
            this.PrintLabel.AutoSize = true;
            this.PrintLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrintLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.PrintLabel.Location = new System.Drawing.Point(15, 3);
            this.PrintLabel.Name = "PrintLabel";
            this.PrintLabel.Size = new System.Drawing.Size(35, 16);
            this.PrintLabel.TabIndex = 0;
            this.PrintLabel.Text = "Print";
            // 
            // OptionsPanel
            // 
            this.OptionsPanel.BackColor = System.Drawing.Color.Transparent;
            this.OptionsPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.OptionsPanel.Controls.Add(this.OptionsLabel);
            this.OptionsPanel.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OptionsPanel.Location = new System.Drawing.Point(62, 106);
            this.OptionsPanel.Name = "OptionsPanel";
            this.OptionsPanel.Size = new System.Drawing.Size(66, 22);
            this.OptionsPanel.TabIndex = 11;
            this.OptionsPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Options_Click);
            this.OptionsPanel.MouseLeave += new System.EventHandler(this.Options_Leave);
            this.OptionsPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Options_Hover);
            // 
            // OptionsLabel
            // 
            this.OptionsLabel.AutoSize = true;
            this.OptionsLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OptionsLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.OptionsLabel.Location = new System.Drawing.Point(6, 3);
            this.OptionsLabel.Name = "OptionsLabel";
            this.OptionsLabel.Size = new System.Drawing.Size(53, 16);
            this.OptionsLabel.TabIndex = 0;
            this.OptionsLabel.Text = "Options";
            // 
            // ExitPanel
            // 
            this.ExitPanel.BackColor = System.Drawing.Color.Transparent;
            this.ExitPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ExitPanel.Controls.Add(this.ExitLabel);
            this.ExitPanel.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitPanel.Location = new System.Drawing.Point(62, 134);
            this.ExitPanel.Name = "ExitPanel";
            this.ExitPanel.Size = new System.Drawing.Size(66, 22);
            this.ExitPanel.TabIndex = 12;
            this.ExitPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Exit_Click);
            this.ExitPanel.MouseLeave += new System.EventHandler(this.Exit_Leave);
            this.ExitPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Exit_Hover);
            // 
            // ExitLabel
            // 
            this.ExitLabel.AutoSize = true;
            this.ExitLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ExitLabel.Location = new System.Drawing.Point(18, 3);
            this.ExitLabel.Name = "ExitLabel";
            this.ExitLabel.Size = new System.Drawing.Size(31, 16);
            this.ExitLabel.TabIndex = 0;
            this.ExitLabel.Text = "Exit";
            // 
            // ClosePanel
            // 
            this.ClosePanel.BackColor = System.Drawing.Color.Transparent;
            this.ClosePanel.BackgroundImage = global::GEM_Label_Database.Properties.Resources.Close_Button;
            this.ClosePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClosePanel.Location = new System.Drawing.Point(174, -1);
            this.ClosePanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ClosePanel.Name = "ClosePanel";
            this.ClosePanel.Size = new System.Drawing.Size(27, 27);
            this.ClosePanel.TabIndex = 13;
            this.ClosePanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Close_Click);
            this.ClosePanel.MouseLeave += new System.EventHandler(this.Close_Leave);
            this.ClosePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Close_Hover);
            // 
            // MinimizePanel
            // 
            this.MinimizePanel.BackColor = System.Drawing.Color.Transparent;
            this.MinimizePanel.BackgroundImage = global::GEM_Label_Database.Properties.Resources.Minimize_Button;
            this.MinimizePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MinimizePanel.Location = new System.Drawing.Point(148, -1);
            this.MinimizePanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimizePanel.Name = "MinimizePanel";
            this.MinimizePanel.Size = new System.Drawing.Size(27, 27);
            this.MinimizePanel.TabIndex = 14;
            this.MinimizePanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Minimize_Click);
            this.MinimizePanel.MouseLeave += new System.EventHandler(this.Minimize_Leave);
            this.MinimizePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Minimize_Hover);
            // 
            // MenuWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(200, 176);
            this.Controls.Add(this.ClosePanel);
            this.Controls.Add(this.MinimizePanel);
            this.Controls.Add(this.ExitPanel);
            this.Controls.Add(this.OptionsPanel);
            this.Controls.Add(this.PrintPanel);
            this.Controls.Add(this.ImportPanel);
            this.Controls.Add(this.HSplitter);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.WTitleLabel);
            this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuWindow";
            this.Text = "Menu";
            this.ImportPanel.ResumeLayout(false);
            this.ImportPanel.PerformLayout();
            this.PrintPanel.ResumeLayout(false);
            this.PrintPanel.PerformLayout();
            this.OptionsPanel.ResumeLayout(false);
            this.OptionsPanel.PerformLayout();
            this.ExitPanel.ResumeLayout(false);
            this.ExitPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MouseTransparentPanel HSplitter;
        private MouseTransparentPanel Logo;
        private MouseTransparentLabel WTitleLabel;
        private System.Windows.Forms.Panel ImportPanel;
        private MouseTransparentLabel ImportLabel;
        private System.Windows.Forms.Panel PrintPanel;
        private MouseTransparentLabel PrintLabel;
        private System.Windows.Forms.Panel OptionsPanel;
        private MouseTransparentLabel OptionsLabel;
        private System.Windows.Forms.Panel ExitPanel;
        private MouseTransparentLabel ExitLabel;
        private System.Windows.Forms.Panel ClosePanel;
        private System.Windows.Forms.Panel MinimizePanel;
    }
}

