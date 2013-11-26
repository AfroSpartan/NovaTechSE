namespace GEM_Label_Database
{
    partial class ExportSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExportSearch));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ClosePanel = new System.Windows.Forms.Panel();
            this.HSplitter = new GEM_Label_Database.MouseTransparentPanel();
            this.Logo = new GEM_Label_Database.MouseTransparentPanel();
            this.WTitleLabel = new GEM_Label_Database.MouseTransparentLabel();
            this.SelectPanel = new System.Windows.Forms.Panel();
            this.SelectLabel = new GEM_Label_Database.MouseTransparentLabel();
            this.ExportAllPanel = new System.Windows.Forms.Panel();
            this.ExportAllLabel = new GEM_Label_Database.MouseTransparentLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SelectPanel.SuspendLayout();
            this.ExportAllPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 47);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(578, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // ClosePanel
            // 
            this.ClosePanel.BackColor = System.Drawing.Color.Transparent;
            this.ClosePanel.BackgroundImage = global::GEM_Label_Database.Properties.Resources.Close_Button;
            this.ClosePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClosePanel.Location = new System.Drawing.Point(576, -1);
            this.ClosePanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ClosePanel.Name = "ClosePanel";
            this.ClosePanel.Size = new System.Drawing.Size(27, 27);
            this.ClosePanel.TabIndex = 13;
            this.ClosePanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Close_Click);
            this.ClosePanel.MouseLeave += new System.EventHandler(this.Close_Leave);
            this.ClosePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Close_Hover);
            // 
            // HSplitter
            // 
            this.HSplitter.BackgroundImage = global::GEM_Label_Database.Properties.Resources.HSplitter;
            this.HSplitter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.HSplitter.Location = new System.Drawing.Point(-47, 26);
            this.HSplitter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.HSplitter.Name = "HSplitter";
            this.HSplitter.Size = new System.Drawing.Size(653, 5);
            this.HSplitter.TabIndex = 14;
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
            this.Logo.TabIndex = 17;
            // 
            // WTitleLabel
            // 
            this.WTitleLabel.AutoSize = true;
            this.WTitleLabel.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WTitleLabel.Location = new System.Drawing.Point(23, -3);
            this.WTitleLabel.Name = "WTitleLabel";
            this.WTitleLabel.Size = new System.Drawing.Size(106, 32);
            this.WTitleLabel.TabIndex = 18;
            this.WTitleLabel.Text = "Search";
            // 
            // SelectPanel
            // 
            this.SelectPanel.BackColor = System.Drawing.Color.Transparent;
            this.SelectPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SelectPanel.Controls.Add(this.SelectLabel);
            this.SelectPanel.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectPanel.Location = new System.Drawing.Point(524, 236);
            this.SelectPanel.Name = "SelectPanel";
            this.SelectPanel.Size = new System.Drawing.Size(66, 22);
            this.SelectPanel.TabIndex = 9;
            this.SelectPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Select_Click);
            this.SelectPanel.MouseLeave += new System.EventHandler(this.Select_Leave);
            this.SelectPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Select_Hover);
            // 
            // SelectLabel
            // 
            this.SelectLabel.AutoSize = true;
            this.SelectLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.SelectLabel.Location = new System.Drawing.Point(11, 3);
            this.SelectLabel.Name = "SelectLabel";
            this.SelectLabel.Size = new System.Drawing.Size(45, 16);
            this.SelectLabel.TabIndex = 0;
            this.SelectLabel.Text = "Select";
            // 
            // ExportAllPanel
            // 
            this.ExportAllPanel.BackColor = System.Drawing.Color.Transparent;
            this.ExportAllPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ExportAllPanel.Controls.Add(this.ExportAllLabel);
            this.ExportAllPanel.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExportAllPanel.Location = new System.Drawing.Point(447, 236);
            this.ExportAllPanel.Name = "ExportAllPanel";
            this.ExportAllPanel.Size = new System.Drawing.Size(71, 22);
            this.ExportAllPanel.TabIndex = 10;
            this.ExportAllPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ExportAll_Click);
            this.ExportAllPanel.MouseLeave += new System.EventHandler(this.ExportAll_Leave);
            this.ExportAllPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ExportAll_Hover);
            // 
            // ExportAllLabel
            // 
            this.ExportAllLabel.AutoSize = true;
            this.ExportAllLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExportAllLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ExportAllLabel.Location = new System.Drawing.Point(3, 3);
            this.ExportAllLabel.Name = "ExportAllLabel";
            this.ExportAllLabel.Size = new System.Drawing.Size(64, 16);
            this.ExportAllLabel.TabIndex = 0;
            this.ExportAllLabel.Text = "Export All";
            // 
            // ExportSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 270);
            this.Controls.Add(this.ExportAllPanel);
            this.Controls.Add(this.SelectPanel);
            this.Controls.Add(this.ClosePanel);
            this.Controls.Add(this.HSplitter);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.WTitleLabel);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ExportSearch";
            this.Text = "ExportSearch";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.SelectPanel.ResumeLayout(false);
            this.SelectPanel.PerformLayout();
            this.ExportAllPanel.ResumeLayout(false);
            this.ExportAllPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel ClosePanel;
        private MouseTransparentPanel HSplitter;
        private MouseTransparentPanel Logo;
        private MouseTransparentLabel WTitleLabel;
        private System.Windows.Forms.Panel SelectPanel;
        private MouseTransparentLabel SelectLabel;
        private System.Windows.Forms.Panel ExportAllPanel;
        private MouseTransparentLabel ExportAllLabel;
    }
}