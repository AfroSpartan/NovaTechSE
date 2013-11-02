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
            this.label1 = new System.Windows.Forms.Label();
            this.ImportSelect = new System.Windows.Forms.Button();
            this.ImportImport = new System.Windows.Forms.Button();
            this.ImportExit = new System.Windows.Forms.Button();
            this.ImportDelete = new System.Windows.Forms.Button();
            this.WHeight = new System.Windows.Forms.Label();
            this.ImportList = new System.Windows.Forms.DataGridView();
            this.Tables = new System.Windows.Forms.TabControl();
            this.ImportedTab = new System.Windows.Forms.TabPage();
            this.SimpleTab = new System.Windows.Forms.TabPage();
            this.SimpleList = new System.Windows.Forms.DataGridView();
            this.ComplexTab = new System.Windows.Forms.TabPage();
            this.ComplexList = new System.Windows.Forms.DataGridView();
            this.WWidth = new System.Windows.Forms.Label();
            this.ImportPrint = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ImportList)).BeginInit();
            this.Tables.SuspendLayout();
            this.ImportedTab.SuspendLayout();
            this.SimpleTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SimpleList)).BeginInit();
            this.ComplexTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ComplexList)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Import Orders";
            // 
            // ImportSelect
            // 
            this.ImportSelect.Location = new System.Drawing.Point(13, 70);
            this.ImportSelect.Name = "ImportSelect";
            this.ImportSelect.Size = new System.Drawing.Size(75, 23);
            this.ImportSelect.TabIndex = 0;
            this.ImportSelect.Text = "Select File";
            this.ImportSelect.UseVisualStyleBackColor = true;
            this.ImportSelect.Click += new System.EventHandler(this.ImportSelect_Click);
            // 
            // ImportImport
            // 
            this.ImportImport.Location = new System.Drawing.Point(13, 99);
            this.ImportImport.Name = "ImportImport";
            this.ImportImport.Size = new System.Drawing.Size(75, 23);
            this.ImportImport.TabIndex = 1;
            this.ImportImport.Text = "Import";
            this.ImportImport.UseVisualStyleBackColor = true;
            this.ImportImport.Click += new System.EventHandler(this.ImportImport_Click);
            // 
            // ImportExit
            // 
            this.ImportExit.Location = new System.Drawing.Point(12, 351);
            this.ImportExit.Name = "ImportExit";
            this.ImportExit.Size = new System.Drawing.Size(75, 23);
            this.ImportExit.TabIndex = 7;
            this.ImportExit.Text = "Close";
            this.ImportExit.UseVisualStyleBackColor = true;
            this.ImportExit.Click += new System.EventHandler(this.ImportExit_Click);
            // 
            // ImportDelete
            // 
            this.ImportDelete.Location = new System.Drawing.Point(12, 128);
            this.ImportDelete.Name = "ImportDelete";
            this.ImportDelete.Size = new System.Drawing.Size(75, 23);
            this.ImportDelete.TabIndex = 3;
            this.ImportDelete.Text = "Delete";
            this.ImportDelete.UseVisualStyleBackColor = true;
            this.ImportDelete.Click += new System.EventHandler(this.ImportDelete_Click);
            this.ImportDelete.MouseLeave += new System.EventHandler(this.ImportDelete_Leave);
            this.ImportDelete.MouseHover += new System.EventHandler(this.ImportDelete_Hover);
            // 
            // WHeight
            // 
            this.WHeight.AutoSize = true;
            this.WHeight.Location = new System.Drawing.Point(53, 183);
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
            this.ImportList.Size = new System.Drawing.Size(578, 362);
            this.ImportList.TabIndex = 5;
            // 
            // Tables
            // 
            this.Tables.Controls.Add(this.ImportedTab);
            this.Tables.Controls.Add(this.SimpleTab);
            this.Tables.Controls.Add(this.ComplexTab);
            this.Tables.Location = new System.Drawing.Point(199, 12);
            this.Tables.Name = "Tables";
            this.Tables.SelectedIndex = 0;
            this.Tables.Size = new System.Drawing.Size(598, 401);
            this.Tables.TabIndex = 6;
            // 
            // ImportedTab
            // 
            this.ImportedTab.Controls.Add(this.ImportList);
            this.ImportedTab.Location = new System.Drawing.Point(4, 22);
            this.ImportedTab.Name = "ImportedTab";
            this.ImportedTab.Padding = new System.Windows.Forms.Padding(3);
            this.ImportedTab.Size = new System.Drawing.Size(590, 375);
            this.ImportedTab.TabIndex = 0;
            this.ImportedTab.Text = "Imported";
            this.ImportedTab.UseVisualStyleBackColor = true;
            // 
            // SimpleTab
            // 
            this.SimpleTab.Controls.Add(this.SimpleList);
            this.SimpleTab.Location = new System.Drawing.Point(4, 22);
            this.SimpleTab.Name = "SimpleTab";
            this.SimpleTab.Padding = new System.Windows.Forms.Padding(3);
            this.SimpleTab.Size = new System.Drawing.Size(590, 375);
            this.SimpleTab.TabIndex = 1;
            this.SimpleTab.Text = "Simple";
            this.SimpleTab.UseVisualStyleBackColor = true;
            // 
            // SimpleList
            // 
            this.SimpleList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SimpleList.Location = new System.Drawing.Point(6, 6);
            this.SimpleList.Name = "SimpleList";
            this.SimpleList.Size = new System.Drawing.Size(578, 363);
            this.SimpleList.TabIndex = 0;
            // 
            // ComplexTab
            // 
            this.ComplexTab.Controls.Add(this.ComplexList);
            this.ComplexTab.Location = new System.Drawing.Point(4, 22);
            this.ComplexTab.Name = "ComplexTab";
            this.ComplexTab.Padding = new System.Windows.Forms.Padding(3);
            this.ComplexTab.Size = new System.Drawing.Size(590, 375);
            this.ComplexTab.TabIndex = 1;
            this.ComplexTab.Text = "Complex";
            this.ComplexTab.UseVisualStyleBackColor = true;
            // 
            // ComplexList
            // 
            this.ComplexList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ComplexList.Location = new System.Drawing.Point(6, 6);
            this.ComplexList.Name = "ComplexList";
            this.ComplexList.Size = new System.Drawing.Size(578, 363);
            this.ComplexList.TabIndex = 0;
            // 
            // WWidth
            // 
            this.WWidth.AutoSize = true;
            this.WWidth.Location = new System.Drawing.Point(12, 183);
            this.WWidth.Name = "WWidth";
            this.WWidth.Size = new System.Drawing.Size(35, 13);
            this.WWidth.TabIndex = 0;
            this.WWidth.Text = "label3";
            // 
            // ImportPrint
            // 
            this.ImportPrint.Location = new System.Drawing.Point(13, 157);
            this.ImportPrint.Name = "ImportPrint";
            this.ImportPrint.Size = new System.Drawing.Size(75, 23);
            this.ImportPrint.TabIndex = 8;
            this.ImportPrint.Text = "Print";
            this.ImportPrint.UseVisualStyleBackColor = true;
            this.ImportPrint.Click += new System.EventHandler(this.ImportPrint_Click);
            // 
            // ImportWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 418);
            this.Controls.Add(this.ImportPrint);
            this.Controls.Add(this.Tables);
            this.Controls.Add(this.WWidth);
            this.Controls.Add(this.WHeight);
            this.Controls.Add(this.ImportExit);
            this.Controls.Add(this.ImportDelete);
            this.Controls.Add(this.ImportImport);
            this.Controls.Add(this.ImportSelect);
            this.Controls.Add(this.label1);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ImportSelect;
        private System.Windows.Forms.Button ImportImport;
        private System.Windows.Forms.Button ImportExit;
        private System.Windows.Forms.Button ImportDelete;
        private System.Windows.Forms.Label WHeight;
        private System.Windows.Forms.DataGridView ImportList;
        private System.Windows.Forms.TabControl Tables;
        private System.Windows.Forms.TabPage SimpleTab;
        private System.Windows.Forms.TabPage ImportedTab;
        private System.Windows.Forms.TabPage ComplexTab;
        private System.Windows.Forms.DataGridView SimpleList;
        private System.Windows.Forms.DataGridView ComplexList;
        private System.Windows.Forms.Label WWidth;
        private System.Windows.Forms.Button ImportPrint;
    }
}