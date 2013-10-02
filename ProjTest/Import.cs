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
    public partial class ImportWindow : Form
    {

        public string[,] ImportedArray;
        public string ImportedString;

        


        public void ImportData()
        {
            OpenFileDialog selectFile = new OpenFileDialog();

            selectFile.InitialDirectory = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            selectFile.Filter = "text files (*.txt*)|*.txt";
            selectFile.Title = "Select File to Import";
            if (selectFile.ShowDialog() == DialogResult.OK)
            {
                ImportedString = selectFile.OpenFile().ToString();
                this.ImportList.Items.Add(ImportedString);
            }
        }

        public void ImportDelete_Hover(object sender, EventArgs e)
        {
            ImportDelete.BackColor = Color.FromName("red");
        }

        public void ImportDelete_Leave(object sender, EventArgs e)
        {
            ImportDelete.BackColor = Color.FromName("none");
        }

        public void ImportDelete_Click(object sender, EventArgs e)
        {
            
        }

        public ImportWindow()
        {
            InitializeComponent();
        }

        private void ImportImport_Click(object sender, EventArgs e)
        {
            ImportData();
        }

        private void ImportExit_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
