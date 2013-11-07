namespace GEM_Label_Database
{
    partial class ImportWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImportWindow));
            this.label1 = new GEM_Label_Database.MouseTransparentLabel();
            this.WHeight = new GEM_Label_Database.MouseTransparentLabel();
            this.ImportList = new System.Windows.Forms.DataGridView();
            this.Tables = new System.Windows.Forms.TabControl();
            this.ImportedTab = new System.Windows.Forms.TabPage();
            this.SimpleTab = new System.Windows.Forms.TabPage();
            this.SimpleList = new System.Windows.Forms.DataGridView();
            this.ComplexTab = new System.Windows.Forms.TabPage();
            this.ComplexList = new System.Windows.Forms.DataGridView();
            this.WWidth = new GEM_Label_Database.MouseTransparentLabel();
            this.ClosePanel = new System.Windows.Forms.Panel();
            this.HSplitter = new GEM_Label_Database.MouseTransparentPanel();
            this.MinimizePanel = new System.Windows.Forms.Panel();
            this.MaximizePanel = new System.Windows.Forms.Panel();
            this.Logo = new GEM_Label_Database.MouseTransparentPanel();
            this.SelectFilePanel = new System.Windows.Forms.Panel();
            this.SelectFileLabel = new GEM_Label_Database.MouseTransparentLabel();
            this.ExportPanel = new System.Windows.Forms.Panel();
            this.ExportLabel = new GEM_Label_Database.MouseTransparentLabel();
            ((System.ComponentModel.ISupportInitialize)(this.ImportList)).BeginInit();
            this.Tables.SuspendLayout();
            this.ImportedTab.SuspendLayout();
            this.SimpleTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SimpleList)).BeginInit();
            this.ComplexTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ComplexList)).BeginInit();
            this.SelectFilePanel.SuspendLayout();
            this.ExportPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Import Orders";
            // 
            // WHeight
            // 
            this.WHeight.AutoSize = true;
            this.WHeight.Location = new System.Drawing.Point(679, 9);
            this.WHeight.Name = "WHeight";
            this.WHeight.Size = new System.Drawing.Size(35, 13);
            this.WHeight.TabIndex = 0;
            this.WHeight.Text = "label2";
            // 
            // ImportList
            // 
            this.ImportList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ImportList.Location = new System.Drawing.Point(6, 6);
            this.ImportList.Name = "ImportList";
            this.ImportList.Size = new System.Drawing.Size(765, 455);
            this.ImportList.TabIndex = 5;
            // 
            // Tables
            // 
            this.Tables.Controls.Add(this.ImportedTab);
            this.Tables.Controls.Add(this.SimpleTab);
            this.Tables.Controls.Add(this.ComplexTab);
            this.Tables.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tables.Location = new System.Drawing.Point(12, 43);
            this.Tables.Name = "Tables";
            this.Tables.SelectedIndex = 0;
            this.Tables.Size = new System.Drawing.Size(785, 493);
            this.Tables.TabIndex = 6;
            // 
            // ImportedTab
            // 
            this.ImportedTab.Controls.Add(this.ImportList);
            this.ImportedTab.Location = new System.Drawing.Point(4, 23);
            this.ImportedTab.Name = "ImportedTab";
            this.ImportedTab.Padding = new System.Windows.Forms.Padding(3);
            this.ImportedTab.Size = new System.Drawing.Size(777, 466);
            this.ImportedTab.TabIndex = 0;
            this.ImportedTab.Text = "Imported";
            this.ImportedTab.UseVisualStyleBackColor = true;
            // 
            // SimpleTab
            // 
            this.SimpleTab.Controls.Add(this.SimpleList);
            this.SimpleTab.Location = new System.Drawing.Point(4, 23);
            this.SimpleTab.Name = "SimpleTab";
            this.SimpleTab.Padding = new System.Windows.Forms.Padding(3);
            this.SimpleTab.Size = new System.Drawing.Size(777, 466);
            this.SimpleTab.TabIndex = 1;
            this.SimpleTab.Text = "Simple";
            this.SimpleTab.UseVisualStyleBackColor = true;
            // 
            // SimpleList
            // 
            this.SimpleList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SimpleList.Location = new System.Drawing.Point(6, 6);
            this.SimpleList.Name = "SimpleList";
            this.SimpleList.Size = new System.Drawing.Size(765, 454);
            this.SimpleList.TabIndex = 0;
            // 
            // ComplexTab
            // 
            this.ComplexTab.Controls.Add(this.ComplexList);
            this.ComplexTab.Location = new System.Drawing.Point(4, 23);
            this.ComplexTab.Name = "ComplexTab";
            this.ComplexTab.Padding = new System.Windows.Forms.Padding(3);
            this.ComplexTab.Size = new System.Drawing.Size(777, 466);
            this.ComplexTab.TabIndex = 1;
            this.ComplexTab.Text = "Complex";
            this.ComplexTab.UseVisualStyleBackColor = true;
            // 
            // ComplexList
            // 
            this.ComplexList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ComplexList.Location = new System.Drawing.Point(6, 6);
            this.ComplexList.Name = "ComplexList";
            this.ComplexList.Size = new System.Drawing.Size(762, 454);
            this.ComplexList.TabIndex = 0;
            // 
            // WWidth
            // 
            this.WWidth.AutoSize = true;
            this.WWidth.Location = new System.Drawing.Point(638, 9);
            this.WWidth.Name = "WWidth";
            this.WWidth.Size = new System.Drawing.Size(35, 13);
            this.WWidth.TabIndex = 0;
            this.WWidth.Text = "label3";
            // 
            // ClosePanel
            // 
            this.ClosePanel.BackColor = System.Drawing.Color.Transparent;
            this.ClosePanel.BackgroundImage = global::GEM_Label_Database.Properties.Resources.Close_Button;
            this.ClosePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClosePanel.Location = new System.Drawing.Point(783, -1);
            this.ClosePanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ClosePanel.Name = "ClosePanel";
            this.ClosePanel.Size = new System.Drawing.Size(27, 27);
            this.ClosePanel.TabIndex = 0;
            this.ClosePanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Close_Click);
            this.ClosePanel.MouseLeave += new System.EventHandler(this.Close_Leave);
            this.ClosePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Close_Hover);
            // 
            // HSplitter
            // 
            this.HSplitter.BackgroundImage = global::GEM_Label_Database.Properties.Resources.HSplitter;
            this.HSplitter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.HSplitter.Location = new System.Drawing.Point(0, 26);
            this.HSplitter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.HSplitter.Name = "HSplitter";
            this.HSplitter.Size = new System.Drawing.Size(809, 5);
            this.HSplitter.TabIndex = 10;
            // 
            // MinimizePanel
            // 
            this.MinimizePanel.BackColor = System.Drawing.Color.Transparent;
            this.MinimizePanel.BackgroundImage = global::GEM_Label_Database.Properties.Resources.Minimize_Button;
            this.MinimizePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MinimizePanel.Location = new System.Drawing.Point(731, -1);
            this.MinimizePanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimizePanel.Name = "MinimizePanel";
            this.MinimizePanel.Size = new System.Drawing.Size(27, 27);
            this.MinimizePanel.TabIndex = 0;
            this.MinimizePanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Minimize_Click);
            this.MinimizePanel.MouseLeave += new System.EventHandler(this.Minimize_Leave);
            this.MinimizePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Minimize_Hover);
            // 
            // MaximizePanel
            // 
            this.MaximizePanel.BackgroundImage = global::GEM_Label_Database.Properties.Resources.Maximize_Button;
            this.MaximizePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MaximizePanel.Location = new System.Drawing.Point(757, -1);
            this.MaximizePanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizePanel.Name = "MaximizePanel";
            this.MaximizePanel.Size = new System.Drawing.Size(27, 27);
            this.MaximizePanel.TabIndex = 0;
            this.MaximizePanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Maximize_Click);
            this.MaximizePanel.MouseLeave += new System.EventHandler(this.Maximize_Leave);
            this.MaximizePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Maximize_Hover);
            // 
            // Logo
            // 
            this.Logo.BackColor = System.Drawing.Color.Transparent;
            this.Logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Logo.BackgroundImage")));
            this.Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Logo.Location = new System.Drawing.Point(4, 4);
            this.Logo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(24, 22);
            this.Logo.TabIndex = 13;
            // 
            // SelectFilePanel
            // 
            this.SelectFilePanel.BackColor = System.Drawing.Color.Transparent;
            this.SelectFilePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SelectFilePanel.Controls.Add(this.SelectFileLabel);
            this.SelectFilePanel.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectFilePanel.Location = new System.Drawing.Point(719, 542);
            this.SelectFilePanel.Name = "SelectFilePanel";
            this.SelectFilePanel.Size = new System.Drawing.Size(78, 22);
            this.SelectFilePanel.TabIndex = 9;
            this.SelectFilePanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Select_Click);
            this.SelectFilePanel.MouseLeave += new System.EventHandler(this.Select_Leave);
            this.SelectFilePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Select_Hover);
            // 
            // SelectFileLabel
            // 
            this.SelectFileLabel.AutoSize = true;
            this.SelectFileLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectFileLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.SelectFileLabel.Location = new System.Drawing.Point(5, 4);
            this.SelectFileLabel.Name = "SelectFileLabel";
            this.SelectFileLabel.Size = new System.Drawing.Size(70, 16);
            this.SelectFileLabel.TabIndex = 0;
            this.SelectFileLabel.Text = "Select File";
            // 
            // ExportPanel
            // 
            this.ExportPanel.BackColor = System.Drawing.Color.Transparent;
            this.ExportPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ExportPanel.Controls.Add(this.ExportLabel);
            this.ExportPanel.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExportPanel.Location = new System.Drawing.Point(647, 542);
            this.ExportPanel.Name = "ExportPanel";
            this.ExportPanel.Size = new System.Drawing.Size(66, 22);
            this.ExportPanel.TabIndex = 9;
            this.ExportPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Export_Click);
            this.ExportPanel.MouseLeave += new System.EventHandler(this.Export_Leave);
            this.ExportPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Export_Hover);
            // 
            // ExportLabel
            // 
            this.ExportLabel.AutoSize = true;
            this.ExportLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExportLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ExportLabel.Location = new System.Drawing.Point(18, 4);
            this.ExportLabel.Name = "ExportLabel";
            this.ExportLabel.Size = new System.Drawing.Size(31, 16);
            this.ExportLabel.TabIndex = 0;
            this.ExportLabel.Text = "Edit";
            // 
            // ImportWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 575);
            this.Controls.Add(this.ExportPanel);
            this.Controls.Add(this.SelectFilePanel);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.ClosePanel);
            this.Controls.Add(this.HSplitter);
            this.Controls.Add(this.MinimizePanel);
            this.Controls.Add(this.MaximizePanel);
            this.Controls.Add(this.Tables);
            this.Controls.Add(this.WWidth);
            this.Controls.Add(this.WHeight);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ImportWindow";
            this.Text = "Import";
            this.Load += new System.EventHandler(this.ImportWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ImportList)).EndInit();
            this.Tables.ResumeLayout(false);
            this.ImportedTab.ResumeLayout(false);
            this.SimpleTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SimpleList)).EndInit();
            this.ComplexTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ComplexList)).EndInit();
            this.SelectFilePanel.ResumeLayout(false);
            this.SelectFilePanel.PerformLayout();
            this.ExportPanel.ResumeLayout(false);
            this.ExportPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MouseTransparentLabel label1;
        private MouseTransparentLabel WHeight;
        private System.Windows.Forms.DataGridView ImportList;
        private System.Windows.Forms.TabControl Tables;
        private System.Windows.Forms.TabPage SimpleTab;
        private System.Windows.Forms.TabPage ImportedTab;
        private System.Windows.Forms.TabPage ComplexTab;
        private System.Windows.Forms.DataGridView SimpleList;
        private System.Windows.Forms.DataGridView ComplexList;
        private MouseTransparentLabel WWidth;
        private System.Windows.Forms.Panel ClosePanel;
        private MouseTransparentPanel HSplitter;
        private System.Windows.Forms.Panel MinimizePanel;
        private System.Windows.Forms.Panel MaximizePanel;
        private MouseTransparentPanel Logo;
        private System.Windows.Forms.Panel SelectFilePanel;
        private MouseTransparentLabel SelectFileLabel;
        private System.Windows.Forms.Panel ExportPanel;
        private MouseTransparentLabel ExportLabel;
    }
}