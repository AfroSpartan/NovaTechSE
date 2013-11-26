using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace GEM_Label_Database
{
    public partial class MenuWindow : Form
    {
        public bool userclosing;
        public bool closeHover = false;
        public bool exitHover = false;
        public bool optionsHover = false;
        public bool printHover = false;
        public bool importHover = false;
        public bool minimizeHover = false;
        public bool imported = false;
        public bool transit = false;
        public string who = "";
        public LoginWindow LoginW = new LoginWindow();
        public ImportWindow ImportW = new ImportWindow();
        public PrintWindow PrintW = new PrintWindow();

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (transit == false && userclosing == false && MessageBox.Show(this, "Are you sure you want to exit the program?", "Close", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
            else if (transit == false)
            {
                userclosing = true;
                Application.Exit();
            }
        }

        public void SetPos(int x, int y)
        {
            this.Top = y;
            this.Left = x;
        }

        public MenuWindow()
        {
            InitializeComponent();
            this.Draggable(true);
        }

        private void Import_Click(object sender, EventArgs e)
        {
            transit = true;
            this.Close();
            ImportW.Show();
            ImportW.SetPos(this.Left, this.Top);
            ImportW.imported = imported;
        }

        private void Import_Hover(object sender, EventArgs e)
        {
            if (importHover == false)
            {
                importHover = true;
                this.ImportPanel.BackColor = Color.LightGray;
            }
        }

        private void Import_Leave(object sender, EventArgs e)
        {
            if (importHover == true)
            {
                importHover = false;
                this.ImportPanel.BackColor = Color.Transparent;
            }
        }

        private void Print_Click(object sender, EventArgs e)
        {
            transit = true;
            if (imported == false)
            {
                DialogResult = MessageBox.Show("Nothing has been Imported this session \nAre you sure you want to print?", "Nothing Imported", MessageBoxButtons.YesNo);
            }
            else
            {
                PrintW.Show();
                PrintW.SetPos(this.Left, this.Top);
                PrintW.imported = imported;
                this.Close();
            }
            if (DialogResult.ToString() == "Yes")
            {
                PrintW.Show();
                PrintW.SetPos(this.Left, this.Top);
                PrintW.imported = imported;
                this.Close();
            }
            else
            {

            }
        }

        private void Print_Hover(object sender, EventArgs e)
        {
            if (printHover == false)
            {
                printHover = true;
                this.PrintPanel.BackColor = Color.LightGray;
            }
        }

        private void Print_Leave(object sender, EventArgs e)
        {
            if (printHover == true)
            {
                printHover = false;
                this.PrintPanel.BackColor = Color.Transparent;
            }
        }

        private void Options_Click(object sender, EventArgs e)
        {
            transit = true;
            this.Close();
            LoginW.who = who;
            LoginW.imported = imported;
            LoginW.Show();
            LoginW.Section = "Options";
        }

        private void Options_Hover(object sender, EventArgs e)
        {
            if (optionsHover == false)
            {
                optionsHover = true;
                this.OptionsPanel.BackColor = Color.LightGray;
            }
        }

        private void Options_Leave(object sender, EventArgs e)
        {
            if (optionsHover == true)
            {
                optionsHover = false;
                this.OptionsPanel.BackColor = Color.Transparent;
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            if (userclosing == false && MessageBox.Show(this, "Are you sure you want to exit the program?", "Close", MessageBoxButtons.YesNo) == DialogResult.No)
            {

            }
            else
            {
                userclosing = true;
                Application.Exit();
            }
        }

        private void Exit_Hover(object sender, EventArgs e)
        {
            if (exitHover == false)
            {
                exitHover = true;
                this.ExitPanel.BackColor = Color.LightGray;
            }
        }

        private void Exit_Leave(object sender, EventArgs e)
        {
            if (exitHover == true)
            {
                exitHover = false;
                this.ExitPanel.BackColor = Color.Transparent;
            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Close_Hover(object sender, EventArgs e)
        {
            if (closeHover == false)
            {
                closeHover = true;
                this.ClosePanel.BackColor = Color.Red;
                this.ClosePanel.BackgroundImage = System.Drawing.Image.FromFile(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\Graphics\\Close Button Hover.png");
            }
        }

        private void Close_Leave(object sender, EventArgs e)
        {
            if (closeHover == true)
            {
                closeHover = false;
                this.ClosePanel.BackColor = Color.Transparent;
                this.ClosePanel.BackgroundImage = System.Drawing.Image.FromFile(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\Graphics\\Close Button.png");
            }
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Minimize_Hover(object sender, EventArgs e)
        {
            if (minimizeHover == false)
            {
                minimizeHover = true;
                this.MinimizePanel.BackColor = Color.LightGray;
                this.MinimizePanel.BackgroundImage = System.Drawing.Image.FromFile(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\Graphics\\Minimize Button Hover.png");
            }
        }

        private void Minimize_Leave(object sender, EventArgs e)
        {
            if (minimizeHover == true)
            {
                minimizeHover = false;
                this.MinimizePanel.BackColor = Color.Transparent;
                this.MinimizePanel.BackgroundImage = System.Drawing.Image.FromFile(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\Graphics\\Minimize Button.png");
            }
        }
    }
}