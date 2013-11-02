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

namespace GEM_Label_Database
{
    public partial class PrintWindow : Form
    {
        public int YPos;
        public int XPos;
        public bool imported;
        int row = 0;
        int weight;
        bool userclosing = false;
        string[] line3 = new string[2];
        char[] delimiters = new char[] { ',' };
        DataTable dt = new DataTable();
        OleDbDataAdapter adapter = new OleDbDataAdapter();
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\Database8.accdb");

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (userclosing == false)
            {
                MenuWindow MenuW = new MenuWindow();
                userclosing = true;
                this.Close();
                MenuW.Show();
                MenuW.SetPos(this.Left, this.Top);
                MenuW.imported = imported;
            }
        }

        public void SetPos(int x, int y)
        {
            this.Top = y;
            this.Left = x;
        }

        public PrintWindow()
        {
            InitializeComponent();
        }

        private void Check_AddLine3()
        {
            if (dt.Rows[row].ItemArray[8].ToString() == "" && dt.Rows[row].ItemArray[7].ToString().Contains(",") == true)
            {
                line3 = dt.Rows[row].ItemArray[7].ToString().Split(delimiters, StringSplitOptions.None);
                //line3[1] = line3[1].Replace(" ",string.Empty);
                line3[1] = line3[1].Remove(0,1);
                AddressLine3.Text = line3[1];
                AddressLine2.Text = line3[0];
            }
            else
            {
                AddressLine3.Text = dt.Rows[row].ItemArray[8].ToString();
            }
        }

        private void Add_Price()
        {
            weight = Convert.ToInt32(Weight.Text);
            if (Country.Text == "GB" &&ServiceLevel.Text == "Standard")
            {
                Price.Text = "£3.00";
            }
            else if (Country.Text == "GB" && ServiceLevel.Text == "Expedited")
            {
                if (weight > 0 && weight <= 100)
                {
                    Price.Text = "£6.22";
                }
                else if (weight > 100 && weight <= 500)
                {
                    Price.Text = "£6.95";
                }
                else if (weight > 500 && weight <= 1000)
                {
                    Price.Text = "£8.25";
                }
            }
            else if (Country.Text != "GB" && ServiceLevel.Text == "Standard")
            {
                if (weight > 0 && weight <= 100)
                {
                    Price.Text = "£3.00";
                }
                else if (weight > 100 && weight <= 250)
                {
                    Price.Text = "£3.50";
                }
                else if (weight > 250 && weight <= 500)
                {
                    Price.Text = "£4.95";
                }
                else if (weight > 500 && weight <= 750)
                {
                    Price.Text = "£6.40";
                }
                else if (weight > 750 && weight <= 1000)
                {
                    Price.Text = "£7.85";
                }
            }
            else if (Country.Text != "GB" && ServiceLevel.Text == "Expedited")
            {
                Price.Text = "£5.30";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            adapter.SelectCommand = new OleDbCommand("SELECT * FROM [simplePrint]", con);
            adapter.Fill(dt);
            Record.Text = (row + 1).ToString();
            Records.Text = dt.Rows.Count.ToString();
            OrderID.Text = dt.Rows[row].ItemArray[0].ToString();
            GemCode.Text = dt.Rows[row].ItemArray[1].ToString();
            ProductDesc.Text = dt.Rows[row].ItemArray[2].ToString();
            Weight.Text = dt.Rows[row].ItemArray[3].ToString();
            ServiceLevel.Text = dt.Rows[row].ItemArray[4].ToString();
            CustomerName.Text = dt.Rows[row].ItemArray[5].ToString();
            AddressLine1.Text = dt.Rows[row].ItemArray[6].ToString();
            AddressLine2.Text = dt.Rows[row].ItemArray[7].ToString();
            Check_AddLine3();
            City.Text = dt.Rows[row].ItemArray[9].ToString();
            StateCounty.Text = dt.Rows[row].ItemArray[10].ToString();
            Postcode.Text = dt.Rows[row].ItemArray[11].ToString();
            Country.Text = dt.Rows[row].ItemArray[12].ToString();
            QtShip.Text = dt.Rows[row].ItemArray[13].ToString();
            Add_Price();
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void Next_Click(object sender, EventArgs e)
        {

            if (row != dt.Rows.Count - 1)
                row += 1;
            else
                row = 0;
            Record.Text = (row+1).ToString();
            Records.Text = dt.Rows.Count.ToString();
            OrderID.Text = dt.Rows[row].ItemArray[0].ToString();
            GemCode.Text = dt.Rows[row].ItemArray[1].ToString();
            ProductDesc.Text = dt.Rows[row].ItemArray[2].ToString();
            Weight.Text = dt.Rows[row].ItemArray[3].ToString();
            ServiceLevel.Text = dt.Rows[row].ItemArray[4].ToString();
            CustomerName.Text = dt.Rows[row].ItemArray[5].ToString();
            AddressLine1.Text = dt.Rows[row].ItemArray[6].ToString();
            AddressLine2.Text = dt.Rows[row].ItemArray[7].ToString();
            Check_AddLine3();
            City.Text = dt.Rows[row].ItemArray[9].ToString();
            StateCounty.Text = dt.Rows[row].ItemArray[10].ToString();
            Postcode.Text = dt.Rows[row].ItemArray[11].ToString();
            Country.Text = dt.Rows[row].ItemArray[12].ToString();
            QtShip.Text = dt.Rows[row].ItemArray[13].ToString();
            Add_Price();
        }

        private void Prev_Click(object sender, EventArgs e)
        {
            if (row != 0)
                row -= 1;
            else
                row = dt.Rows.Count - 1;
            Record.Text = (row+1).ToString();
            Records.Text = dt.Rows.Count.ToString();
            OrderID.Text = dt.Rows[row].ItemArray[0].ToString();
            GemCode.Text = dt.Rows[row].ItemArray[1].ToString();
            ProductDesc.Text = dt.Rows[row].ItemArray[2].ToString();
            Weight.Text = dt.Rows[row].ItemArray[3].ToString();
            ServiceLevel.Text = dt.Rows[row].ItemArray[4].ToString();
            CustomerName.Text = dt.Rows[row].ItemArray[5].ToString();
            AddressLine1.Text = dt.Rows[row].ItemArray[6].ToString();
            AddressLine2.Text = dt.Rows[row].ItemArray[7].ToString();
            Check_AddLine3();
            City.Text = dt.Rows[row].ItemArray[9].ToString();
            StateCounty.Text = dt.Rows[row].ItemArray[10].ToString();
            Postcode.Text = dt.Rows[row].ItemArray[11].ToString();
            Country.Text = dt.Rows[row].ItemArray[12].ToString();
            QtShip.Text = dt.Rows[row].ItemArray[13].ToString();
            Add_Price();
        }

    }
}
