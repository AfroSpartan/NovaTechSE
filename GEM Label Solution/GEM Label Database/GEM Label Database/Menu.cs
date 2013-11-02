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
        }

        private void MenuImport_Click(object sender, EventArgs e)
        {
            transit = true;
            this.Close();
            ImportW.Show();
            ImportW.SetPos(this.Left, this.Top);
            ImportW.imported = imported;
        }

        private void MenuSimple_Click(object sender, EventArgs e)
        {
            transit = true;
            if (imported == false)
            {
                DialogResult = MessageBox.Show("Nothing has been imported this session \nAre you sure you want to print?", "Nothing Imported", MessageBoxButtons.YesNo);
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

        private void MenuExit_Click(object sender, EventArgs e)
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

        private void MenuOptions_Click(object sender, EventArgs e)
        {
            transit = true;
            this.Close();
            LoginW.who = who;
            LoginW.imported = imported;
            LoginW.Show();
            LoginW.Section = "Options";

        }
        private void MenuWindow_Load(object sender, EventArgs e)
        {

        }
    }
}