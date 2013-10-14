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
        public string who = "";
        public LoginWindow LoginW = new LoginWindow();
        public ImportWindow ImportW = new ImportWindow();

        public MenuWindow()
        {
            InitializeComponent();
        }

        private void MenuImport_Click(object sender, EventArgs e)
        {
            this.Close();
            ImportW.Show();
        }

        private void MenuSimple_Click(object sender, EventArgs e)
        {

        }

        private void MenuExit_Click(object sender, EventArgs e)
        {
            Close();
            Application.Exit();
        }

        private void MenuOptions_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginW.who = who;
            LoginW.Show();
            LoginW.Section = "Options";

        }
        private void MenuWindow_Load(object sender, EventArgs e)
        {

        }
    }
}