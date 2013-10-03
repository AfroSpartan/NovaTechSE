namespace ProjTest
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
            this.ImportList = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ImportImport = new System.Windows.Forms.Button();
            this.ImportSort = new System.Windows.Forms.Button();
            this.ImportExit = new System.Windows.Forms.Button();
            this.ImportDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ImportList
            // 
            this.ImportList.FormattingEnabled = true;
            this.ImportList.HorizontalScrollbar = true;
            this.ImportList.Location = new System.Drawing.Point(202, 70);
            this.ImportList.Name = "ImportList";
            this.ImportList.ScrollAlwaysVisible = true;
            this.ImportList.Size = new System.Drawing.Size(521, 304);
            this.ImportList.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Import Orders";
            // 
            // ImportImport
            // 
            this.ImportImport.Location = new System.Drawing.Point(13, 70);
            this.ImportImport.Name = "ImportImport";
            this.ImportImport.Size = new System.Drawing.Size(75, 23);
            this.ImportImport.TabIndex = 2;
            this.ImportImport.Text = "Import";
            this.ImportImport.UseVisualStyleBackColor = true;
            this.ImportImport.Click += new System.EventHandler(this.ImportImport_Click);
            // 
            // ImportSort
            // 
            this.ImportSort.Location = new System.Drawing.Point(13, 99);
            this.ImportSort.Name = "ImportSort";
            this.ImportSort.Size = new System.Drawing.Size(75, 23);
            this.ImportSort.TabIndex = 2;
            this.ImportSort.Text = "Sort";
            this.ImportSort.UseVisualStyleBackColor = true;
            // 
            // ImportExit
            // 
            this.ImportExit.Location = new System.Drawing.Point(12, 351);
            this.ImportExit.Name = "ImportExit";
            this.ImportExit.Size = new System.Drawing.Size(75, 23);
            this.ImportExit.TabIndex = 2;
            this.ImportExit.Text = "Exit";
            this.ImportExit.UseVisualStyleBackColor = true;
            this.ImportExit.Click += new System.EventHandler(this.ImportExit_Click);
            // 
            // ImportDelete
            // 
            this.ImportDelete.Location = new System.Drawing.Point(12, 128);
            this.ImportDelete.Name = "ImportDelete";
            this.ImportDelete.Size = new System.Drawing.Size(75, 23);
            this.ImportDelete.TabIndex = 2;
            this.ImportDelete.Text = "Delete";
            this.ImportDelete.UseVisualStyleBackColor = true;
            this.ImportDelete.Click += new System.EventHandler(this.ImportDelete_Click);
            this.ImportDelete.MouseLeave += new System.EventHandler(this.ImportDelete_Leave);
            this.ImportDelete.MouseHover += new System.EventHandler(this.ImportDelete_Hover);
            // 
            // ImportWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 386);
            this.Controls.Add(this.ImportExit);
            this.Controls.Add(this.ImportDelete);
            this.Controls.Add(this.ImportSort);
            this.Controls.Add(this.ImportImport);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ImportList);
            this.Name = "ImportWindow";
            this.Text = "Import";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox ImportList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ImportImport;
        private System.Windows.Forms.Button ImportSort;
        private System.Windows.Forms.Button ImportExit;
        private System.Windows.Forms.Button ImportDelete;
    }
}