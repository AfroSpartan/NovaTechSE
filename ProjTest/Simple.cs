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
    public partial class SimpleWindow : Form
    {
        public SimpleWindow()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SimpleExit_Click(object sender, EventArgs e)
        {
            Hide();
        }


    }
}
