using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProjTest
{
    public partial class MenuWindow : Form
    {
        public static ImportWindow ImportPage = new ImportWindow();
        public static SimpleWindow SimplePage = new SimpleWindow();
        public static OptionsWindow OptionsPage = new OptionsWindow();

        public MenuWindow()
        {
            InitializeComponent();
        }

        private void MenuImport_Click(object sender, EventArgs e)
        {
            ImportPage.Show();
        }

        private void MenuSimple_Click(object sender, EventArgs e)
        {
            SimplePage.Show();
        }

        private void MenuExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MenuOptions_Click(object sender, EventArgs e)
        {
            OptionsPage.Show();
        }

        private void MenuWindow_Load(object sender, EventArgs e)
        {

        }
    }
}
