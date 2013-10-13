namespace ProjTest
{
    partial class SimpleWindow
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
            this.SimpleList = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ExportButton = new System.Windows.Forms.Button();
            this.ExportAllButton = new System.Windows.Forms.Button();
            this.SimpleDelete = new System.Windows.Forms.Button();
            this.SimpleExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SimpleList
            // 
            this.SimpleList.FormattingEnabled = true;
            this.SimpleList.Location = new System.Drawing.Point(278, 16);
            this.SimpleList.Name = "SimpleList";
            this.SimpleList.Size = new System.Drawing.Size(631, 304);
            this.SimpleList.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Simple Orders";
            // 
            // ExportButton
            // 
            this.ExportButton.Location = new System.Drawing.Point(18, 67);
            this.ExportButton.Name = "ExportButton";
            this.ExportButton.Size = new System.Drawing.Size(75, 23);
            this.ExportButton.TabIndex = 2;
            this.ExportButton.Text = "Export";
            this.ExportButton.UseVisualStyleBackColor = true;
            // 
            // ExportAllButton
            // 
            this.ExportAllButton.Location = new System.Drawing.Point(18, 96);
            this.ExportAllButton.Name = "ExportAllButton";
            this.ExportAllButton.Size = new System.Drawing.Size(75, 23);
            this.ExportAllButton.TabIndex = 2;
            this.ExportAllButton.Text = "Export All";
            this.ExportAllButton.UseVisualStyleBackColor = true;
            // 
            // SimpleDelete
            // 
            this.SimpleDelete.Location = new System.Drawing.Point(18, 125);
            this.SimpleDelete.Name = "SimpleDelete";
            this.SimpleDelete.Size = new System.Drawing.Size(75, 23);
            this.SimpleDelete.TabIndex = 2;
            this.SimpleDelete.Text = "Delete";
            this.SimpleDelete.UseVisualStyleBackColor = true;
            // 
            // SimpleExit
            // 
            this.SimpleExit.Location = new System.Drawing.Point(12, 297);
            this.SimpleExit.Name = "SimpleExit";
            this.SimpleExit.Size = new System.Drawing.Size(75, 23);
            this.SimpleExit.TabIndex = 2;
            this.SimpleExit.Text = "Exit";
            this.SimpleExit.UseVisualStyleBackColor = true;
            this.SimpleExit.Click += new System.EventHandler(this.SimpleExit_Click);
            // 
            // SimpleWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 332);
            this.Controls.Add(this.SimpleExit);
            this.Controls.Add(this.SimpleDelete);
            this.Controls.Add(this.ExportAllButton);
            this.Controls.Add(this.ExportButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SimpleList);
            this.Name = "SimpleWindow";
            this.Text = "Simple";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox SimpleList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ExportButton;
        private System.Windows.Forms.Button ExportAllButton;
        private System.Windows.Forms.Button SimpleDelete;
        private System.Windows.Forms.Button SimpleExit;
    }
}