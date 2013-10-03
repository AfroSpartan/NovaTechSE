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
        string[] lines;
        

        public void ImportData()
        {
            //Initializes new file dialog
            OpenFileDialog selectFile = new OpenFileDialog();

            //Sets up file dialog
            selectFile.InitialDirectory = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            selectFile.Filter = "text files (*.txt*)|*.txt";
            selectFile.Title = "Select File to Import";
            //Displays file dialog
            if (selectFile.ShowDialog() == DialogResult.OK)
            {
                //Adds each line to array
                lines = System.IO.File.ReadAllLines(selectFile.FileName);
                //Adds all lines to the checked list box
                for (int i = 1; i != lines.Length; i++)
                {
                    //Checks for duplicates
                    if (!ImportList.Items.Contains(lines[i]))
                    {
                        //Adds line i to checkboxlist
                        this.ImportList.Items.Add(lines[i]);
                    }
                }
            }
        }

        public void ImportDelete_Hover(object sender, EventArgs e)
        {
            ImportDelete.ForeColor = Color.FromName("red");
        }

        public void ImportDelete_Leave(object sender, EventArgs e)
        {
            ImportDelete.ForeColor = Color.FromName("none");
        }

        public void ImportDelete_Click(object sender, EventArgs e)
        {
            //Displays confirmation of deletion
            DialogResult DeleteMSGResult = MessageBox.Show("Are you sure you want to remove the selected items from the list? (They will still be in the txt file to reimport later)", "Remove Items?", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            //If user clicks OK
            if (DeleteMSGResult == DialogResult.OK)
            {
                //While there are checked items in Checkbox List do this
                while(ImportList.CheckedIndices.Count > 0)
                {
                    //Removes first checkbox
                    ImportList.Items.RemoveAt(ImportList.CheckedIndices[0]);
                }
            }
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
