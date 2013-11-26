using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Threading;

namespace GEM_Label_Database
{
    public partial class ExportSearch : Form
    {
        int selected = 0;
        public string[] outputarray = new string[10000];
        public int outlength;
        public string output;
        public string cat;
        public string search;
        public bool closeHover = false;
        public bool selectHover = false;
        public bool exportAllHover = false;
        DataTable dt = new DataTable();
        OleDbDataAdapter adapter = new OleDbDataAdapter();
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\Database8.accdb");

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            PrintWindow parent = (PrintWindow)this.Owner;
            parent.Show();
            this.Close();

        }

        public ExportSearch()
        {
            InitializeComponent();
            this.Draggable(true);
            this.ExportAllPanel.Visible = false;
        }

        public void AfterInit()
        {
            if (cat == "Customer Name")
            {
                adapter.SelectCommand = new OleDbCommand("SELECT [order-id],[recipient-name],[Code],[Product_Name],[ship-postal-code] FROM [simplePrint] WHERE [recipient-name] LIKE '%" + search + "%'", con);
                adapter.Fill(dt);
            }
            else if (cat == "Order ID")
            {
                adapter.SelectCommand = new OleDbCommand("SELECT * FROM [simplePrint] WHERE [order-id] LIKE '%" + search + "%'", con);
                adapter.Fill(dt);
            }
            else
            {
                adapter.SelectCommand = new OleDbCommand("SELECT * FROM [simplePrint] WHERE [Code] LIKE '%" + search + "%'", con);
                adapter.Fill(dt);
                this.ExportAllPanel.Visible = true;
            }
            dataGridView1.DataSource = dt;
        }

        private void ExportAll_Click_Color()
        {
            this.ExportAllLabel.BackColor = Color.FromArgb(100, 59, 227, 255);
            this.ExportAllPanel.BackColor = Color.FromArgb(100, 59, 227, 255);
            Thread.Sleep(100);
            if (exportAllHover == true)
            {
                this.ExportAllLabel.BackColor = Color.Transparent;
                this.ExportAllPanel.BackColor = Color.LightGray;
            }
            if (exportAllHover == false)
            {
                this.ExportAllLabel.BackColor = Color.Transparent;
                this.ExportAllPanel.BackColor = Color.Transparent;
            }
        }

        private void Select_Click_Color()
        {
            this.SelectPanel.BackColor = Color.FromArgb(100, 59, 227, 255);
            Thread.Sleep(100);
            if (selectHover == true)
            {
                this.SelectPanel.BackColor = Color.LightGray;
            }
            if (selectHover == false)
            {
                this.SelectPanel.BackColor = Color.Transparent;
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
        private void ExportAll_Click(object sender, EventArgs e)
        {
            Thread clickColor = new Thread(ExportAll_Click_Color);
            clickColor.Start();
            ExportSettings exportWindow = new ExportSettings();
            exportWindow.Show();
            exportWindow.search = search;
            exportWindow.isGemcode = true;
            exportWindow.AfterInit();
        }

        private void ExportAll_Hover(object sender, EventArgs e)
        {
            if (exportAllHover == false)
            {
                exportAllHover = true;
                this.ExportAllPanel.BackColor = Color.LightGray;
            }
        }

        private void ExportAll_Leave(object sender, EventArgs e)
        {
            if (exportAllHover == true)
            {
                exportAllHover = false;
                this.ExportAllPanel.BackColor = Color.Transparent;
            }
        }
        private void Select_Click(object sender, EventArgs e)
        {
            Thread clickColor = new Thread(Select_Click_Color);
            clickColor.Start();
            DataTable dt2 = new DataTable();
            adapter.SelectCommand = new OleDbCommand("SELECT * FROM [simplePrint]", con);
            adapter.Fill(dt2);
            for (int i = 0; i < dt2.Rows.Count; i++)
            {
                if (dt.Rows[dataGridView1.CurrentRow.Index].ItemArray[0].ToString() == dt2.Rows[i].ItemArray[0].ToString())
                {
                    selected = i;
                    break;
                }
            }
            PrintWindow parent = (PrintWindow)this.Owner;
            parent.setRow(selected);
            this.Close();
        }

        private void Select_Hover(object sender, EventArgs e)
        {
            if (selectHover == false)
            {
                selectHover = true;
                this.SelectPanel.BackColor = Color.LightGray;
            }
        }

        private void Select_Leave(object sender, EventArgs e)
        {
            if (selectHover == true)
            {
                selectHover = false;
                this.SelectPanel.BackColor = Color.Transparent;
            }
        }
    }
}
