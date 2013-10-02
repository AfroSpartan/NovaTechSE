namespace ProjTest
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
            this.label1 = new System.Windows.Forms.Label();
            this.MenuImport = new System.Windows.Forms.Button();
            this.MenuSimple = new System.Windows.Forms.Button();
            this.MenuComplex = new System.Windows.Forms.Button();
            this.MenuExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Menu";
            // 
            // MenuImport
            // 
            this.MenuImport.Location = new System.Drawing.Point(58, 60);
            this.MenuImport.Name = "MenuImport";
            this.MenuImport.Size = new System.Drawing.Size(75, 23);
            this.MenuImport.TabIndex = 3;
            this.MenuImport.Text = "Import";
            this.MenuImport.UseVisualStyleBackColor = true;
            this.MenuImport.Click += new System.EventHandler(this.MenuImport_Click);
            // 
            // MenuSimple
            // 
            this.MenuSimple.Location = new System.Drawing.Point(58, 89);
            this.MenuSimple.Name = "MenuSimple";
            this.MenuSimple.Size = new System.Drawing.Size(75, 23);
            this.MenuSimple.TabIndex = 3;
            this.MenuSimple.Text = "Simple";
            this.MenuSimple.UseVisualStyleBackColor = true;
            this.MenuSimple.Click += new System.EventHandler(this.MenuSimple_Click);
            // 
            // MenuComplex
            // 
            this.MenuComplex.Location = new System.Drawing.Point(58, 118);
            this.MenuComplex.Name = "MenuComplex";
            this.MenuComplex.Size = new System.Drawing.Size(75, 23);
            this.MenuComplex.TabIndex = 3;
            this.MenuComplex.Text = "Complex";
            this.MenuComplex.UseVisualStyleBackColor = true;
            this.MenuComplex.Click += new System.EventHandler(this.MenuComplex_Click);
            // 
            // MenuExit
            // 
            this.MenuExit.Location = new System.Drawing.Point(58, 147);
            this.MenuExit.Name = "MenuExit";
            this.MenuExit.Size = new System.Drawing.Size(75, 23);
            this.MenuExit.TabIndex = 3;
            this.MenuExit.Text = "Exit";
            this.MenuExit.UseVisualStyleBackColor = true;
            this.MenuExit.Click += new System.EventHandler(this.MenuExit_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(200, 200);
            this.Controls.Add(this.MenuExit);
            this.Controls.Add(this.MenuComplex);
            this.Controls.Add(this.MenuSimple);
            this.Controls.Add(this.MenuImport);
            this.Controls.Add(this.label1);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button MenuImport;
        private System.Windows.Forms.Button MenuSimple;
        private System.Windows.Forms.Button MenuComplex;
        private System.Windows.Forms.Button MenuExit;
    }
}

