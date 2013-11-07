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
    public partial class ExportSettings : Form
    {
        bool singleprint;
        string name;
        string add1;
        string add2;
        string add3;
        string city;
        string pcode;
        string orderid;
        string weight;
        string output;
        string[] outputarray = new string[10000];
        int outlength = 1;
        DataTable dt = new DataTable();
        OleDbDataAdapter adapter = new OleDbDataAdapter();
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\Database8.accdb");


        public ExportSettings()
        {
            InitializeComponent();
            adapter.SelectCommand = new OleDbCommand("SELECT * FROM [simplePrint]", con);
            adapter.Fill(dt);
        }

        public void GetMode(bool single)
        {
            if (single == true)
            {
                singleprint = true;
            }
            else
            {
                singleprint = false;
            }
        }

        public void GetOrder(string n, string a1, string a2, string a3, string c, string pc, string oi, string w)
        {
            name = n;
            add1 = a1;
            add2 = a2;
            add3 = a3;
            city = c;
            pcode = pc;
            orderid = oi;
            weight = w;
        }



        private void Continue_Click(object sender, EventArgs e)
        {
            if (singleprint == true)
            {
                outputarray[0] = "ADD GEMMapping";
                outputarray[1] = PrinterCode.Text + "\t" + name + "\t" + add1 + "\t" + add2 + "\t" + add3 + "\t" + city + "\t" + pcode + "\t" + ClientAccessCode.Text + "\t" + PostalService.Text + "\t" + orderid + "\t" + weight + "\t" + PostalClass.Text + "\t" + PostalFormat.Text;
            }
            if (singleprint == false)
            {
                outputarray[0] = "ADD GEMMapping";
                for (int i = 0;i < dt.Rows.Count; i++)
                {
                    outputarray[i+1] = PrinterCode.Text + "\t" + dt.Rows[i].ItemArray[5].ToString() + "\t" + dt.Rows[i].ItemArray[6].ToString() + "\t" + dt.Rows[i].ItemArray[7].ToString() + "\t" + dt.Rows[i].ItemArray[8].ToString() + "\t" + dt.Rows[i].ItemArray[9].ToString() + "\t" + dt.Rows[i].ItemArray[11].ToString() + "\t" + ClientAccessCode.Text + "\t" + PostalService.Text + "\t" + dt.Rows[i].ItemArray[0].ToString() + "\t" + dt.Rows[i].ItemArray[3].ToString() + "\t" + PostalClass.Text + "\t" + PostalFormat.Text;
                }
            }

            if (System.IO.File.Exists("export.txt") == true)
            {

            }
            else
            {
                System.IO.File.Create("export.txt");
            }

            outlength = outputarray.Count(s => s != null);
            for (int i = 0; i <= outlength; i++)
            {
                output = output + outputarray[i];
                output = output + "\r\n";
            }

            // Write the string to a file.
            System.IO.StreamWriter file = new System.IO.StreamWriter("export.txt");
            file.WriteLine(output);

            file.Close();
            MessageBox.Show("TXT File created \n" + (outlength - 1).ToString() + "Orders Exported");
            this.Close();
        }


    }
}
