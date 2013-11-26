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
using System.Drawing.Printing;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Interop;
using System.Threading;

namespace GEM_Label_Database
{
    public partial class PrintWindow : Form
    {
        bool singleprint;
        bool edit = false;
        bool editHover = false;
        bool searchHover = false;
        bool prevHover = false;
        bool nextHover = false;
        bool printHover = false;
        bool printAllHover = false;
        bool maximized = false;
        bool minimizeHover = false;
        bool maximizeHover = false;
        bool closeHover = false;
        bool empty = true;
        public int YPos;
        public int XPos;
        public bool imported;
        public int row = 0;
        int weight;
        bool userclosing = false;
        string[] line3 = new string[2];
        char[] delimiters = new char[] { ',' };
        DataTable dt = new DataTable();
        OleDbDataAdapter adapter = new OleDbDataAdapter();
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\Database8.accdb");

        protected override CreateParams CreateParams
        {
            get
            {
                const int CS_DROPSHADOW = 0x20000;
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }

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

        public void Export()
        {
            ExportSettings exportWindow = new ExportSettings();
            exportWindow.Show();
            exportWindow.GetMode(singleprint);
            exportWindow.GetOrder(CustomerName.Text, AddressLine1.Text, AddressLine2.Text, AddressLine3.Text, City.Text, Postcode.Text, OrderID.Text, Weight.Text);
        }

        public PrintWindow()
        {
            InitializeComponent();
            //this.EditLabel.BackColor = Color.Transparent;
            //this.PrintLabel.BackColor = Color.Transparent;
            //this.PrintAllLabel.BackColor = Color.Transparent;
            this.Draggable(true);
            this.GEMCodeList.Visible = false;
        }

        private void Check_AddLine3()
        {
            if (dt.Rows[row][8].ToString() == "" && dt.Rows[row][7].ToString().Contains(",") == true)
            {
                line3 = dt.Rows[row][7].ToString().Split(delimiters, StringSplitOptions.None);
                //line3[1] = line3[1].Replace(" ",string.Empty);
                line3[1] = line3[1].Remove(0,1);
                AddressLine3.Text = line3[1];
                dt.Rows[row][8] = line3[1];
                AddressLine2.Text = line3[0];
            }
            else
            {
                AddressLine3.Text = dt.Rows[row][8].ToString();
            }
        }

        private void Add_Price()
        {
            weight = Convert.ToInt32(Weight.Text);
            if (Country.Text == "GB" &&ServiceLevel.Text == "Standard")
            {
                Price.Text = "£" + (3.00 * Convert.ToDouble(dt.Rows[row][13])).ToString("0.00");
            }
            else if (Country.Text == "GB" && ServiceLevel.Text == "Expedited")
            {
                if (weight > 0 && weight <= 100)
                {
                    Price.Text = (6.22 * Convert.ToDouble(dt.Rows[row][13])).ToString("0.00");
                }
                else if (weight > 100 && weight <= 500)
                {
                    Price.Text = (6.95 * Convert.ToDouble(dt.Rows[row][13])).ToString("0.00");
                }
                else if (weight > 500 && weight <= 1000)
                {
                    Price.Text = (8.25 * Convert.ToDouble(dt.Rows[row][13])).ToString("0.00");
                }
            }
            else if (Country.Text != "GB" && ServiceLevel.Text == "Standard")
            {
                if (weight > 0 && weight <= 100)
                {
                    Price.Text = (3.00 * Convert.ToDouble(dt.Rows[row][13])).ToString("0.00");
                }
                else if (weight > 100 && weight <= 250)
                {
                    Price.Text = (3.50 * Convert.ToDouble(dt.Rows[row][13])).ToString("0.00");
                }
                else if (weight > 250 && weight <= 500)
                {
                    Price.Text = (4.95 * Convert.ToDouble(dt.Rows[row][13])).ToString("0.00");
                }
                else if (weight > 500 && weight <= 750)
                {
                    Price.Text = (6.40 * Convert.ToDouble(dt.Rows[row][13])).ToString("0.00");
                }
                else if (weight > 750 && weight <= 1000)
                {
                    Price.Text = (7.85 * Convert.ToDouble(dt.Rows[row][13])).ToString("0.00");
                }
            }
            else if (Country.Text != "GB" && ServiceLevel.Text == "Expedited")
            {
                Price.Text = (5.30 * Convert.ToDouble(dt.Rows[row][13])).ToString("0.00");
            }
        }

        private void Draw_Label()
        {
            OrderIDPLabel.Text = dt.Rows[row][0].ToString();
            CustomerPLabel.Text = (dt.Rows[row][5].ToString() + "   (" + dt.Rows[row][1].ToString() + ")").ToUpper();
            AddressLine1PLabel.Text = (dt.Rows[row][6].ToString()).ToUpper().Replace(',', ' ');
            AddressLine2PLabel.Text = (dt.Rows[row][7].ToString()).ToUpper().Replace(',', ' ');
            AddressLine3PLabel.Text = (dt.Rows[row][8].ToString()).ToUpper().Replace(',', ' ');
            CityPLabel.Text = (dt.Rows[row][9].ToString()).ToUpper();
            PostcodePLabel.Text = (dt.Rows[row][11].ToString()).ToUpper();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            adapter.SelectCommand = new OleDbCommand("SELECT * FROM [simplePrint]", con);
            adapter.Fill(dt);
            Record.Text = (row + 1).ToString();
            Records.Text = "/ "+dt.Rows.Count.ToString();
            OrderID.Text = dt.Rows[row][0].ToString();
            GemCode.Text = dt.Rows[row][1].ToString();
            ProductDesc.Text = dt.Rows[row][2].ToString();
            Weight.Text = dt.Rows[row][3].ToString();
            ServiceLevel.Text = dt.Rows[row][4].ToString();
            CustomerName.Text = dt.Rows[row][5].ToString();
            AddressLine1.Text = dt.Rows[row][6].ToString();
            AddressLine2.Text = dt.Rows[row][7].ToString();
            Check_AddLine3();
            City.Text = dt.Rows[row][9].ToString();
            StateCounty.Text = dt.Rows[row][10].ToString();
            Postcode.Text = dt.Rows[row][11].ToString();
            Country.Text = dt.Rows[row][12].ToString();
            QtShip.Text = dt.Rows[row][13].ToString();
            Add_Price();
            Draw_Label();
            if (dt.Rows.Count == 0)
            {
                empty = true;
                MessageBox.Show("Database is empty. Please import a text file first.", "Database is empty");
            }
            else
            {
                empty = false;
            }
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if(!this.GEMCodeList.Items.Contains(dt.Rows[i][1]))
                {
                    this.GEMCodeList.Items.Add(dt.Rows[i][1]);
                }
            }
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void Scroll_Wheel(object sender, MouseEventArgs e)
        {
            if (e.Delta == 120)
            {
                Update_Record(1);
            }
            if (e.Delta == -120)
            {
                Update_Record(-1);
            }
        }

        private void Key_Down(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                Update_Record(1);
                e.Handled = true;
            }
            if (e.KeyCode == Keys.Left)
            {
                Update_Record(-1);
                e.Handled = true;
            }
        }

        private void Lost_Focus(object sender, EventArgs e)
        {
            if (edit == true)
            {
                dt.Rows[row][5] = CustomerName.Text;
                dt.Rows[row][6] = AddressLine1.Text;
                dt.Rows[row][7] = AddressLine2.Text;
                dt.Rows[row][8] = AddressLine3.Text;
                dt.Rows[row][9] = City.Text;
                dt.Rows[row][10] = StateCounty.Text;
                dt.Rows[row][11] = Postcode.Text;
                dt.Rows[row][12] = Country.Text;
            }
        }

        private void Update_Record(int yn)
        {

            if (edit == true)
            {
                dt.Rows[row][5] = CustomerName.Text;
                dt.Rows[row][6] = AddressLine1.Text;
                dt.Rows[row][7] = AddressLine2.Text;
                dt.Rows[row][8] = AddressLine3.Text;
                dt.Rows[row][9] = City.Text;
                dt.Rows[row][10] = StateCounty.Text;
                dt.Rows[row][11] = Postcode.Text;
                dt.Rows[row][12] = Country.Text;
                string updateTable = "UPDATE simpleTable SET [recipient-name]='" + dt.Rows[row][5].ToString() + "', [ship-address-1]='" + dt.Rows[row][6].ToString() + "', [ship-address-2]='" + dt.Rows[row][7].ToString() + "', [ship-address-3]='" + dt.Rows[row][8].ToString() + "', [ship-city]='" + dt.Rows[row][9].ToString() + "', [ship-state]='" + dt.Rows[row][10].ToString() + "', [ship-postal-code]='" + dt.Rows[row][11].ToString() + "', [ship-country]='" + dt.Rows[row][12].ToString() + "' WHERE [order-id] ='" + dt.Rows[row][0].ToString() + "';";
                OleDbCommand update = new OleDbCommand(updateTable, con);
                try
                {
                    con.Open();
                    update.ExecuteNonQuery();
                }
                catch (OleDbException er)
                {
                    MessageBox.Show(er.Message);
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
                finally
                {
                    con.Close();
                }
                edit = false;
                this.CustomerName.ReadOnly = true;
                this.AddressLine1.ReadOnly = true;
                this.AddressLine2.ReadOnly = true;
                this.AddressLine3.ReadOnly = true;
                this.City.ReadOnly = true;
                this.StateCounty.ReadOnly = true;
                this.Country.ReadOnly = true;
                this.City.ReadOnly = true;
                this.Postcode.ReadOnly = true;
            }
            if (yn == -1)
            {
                if (row != 0)
                    row -= 1;
                else
                    row = dt.Rows.Count - 1;
            }
            else if (yn == 1)
            {
                if (row != dt.Rows.Count - 1)
                    row += 1;
                else
                    row = 0;
            }
            if (empty == false)
            {
                Record.Text = (row + 1).ToString();
                Records.Text = "/ " + dt.Rows.Count.ToString();
                OrderID.Text = dt.Rows[row][0].ToString();
                GemCode.Text = dt.Rows[row][1].ToString();
                ProductDesc.Text = dt.Rows[row][2].ToString();
                Weight.Text = dt.Rows[row][3].ToString();
                ServiceLevel.Text = dt.Rows[row][4].ToString();
                CustomerName.Text = dt.Rows[row][5].ToString();
                AddressLine1.Text = dt.Rows[row][6].ToString();
                AddressLine2.Text = dt.Rows[row][7].ToString();
                Check_AddLine3();
                City.Text = dt.Rows[row][9].ToString();
                StateCounty.Text = dt.Rows[row][10].ToString();
                Postcode.Text = dt.Rows[row][11].ToString();
                Country.Text = dt.Rows[row][12].ToString();
                QtShip.Text = dt.Rows[row][13].ToString();
                Add_Price();
                Draw_Label();
            }
            else
                MessageBox.Show("Database is empty. Please import a text file first.", "Database is empty");
        }

        #region "Visuals and Buttons"

        private void Search_Click_Color()
        {
            this.SearchPanel.BackColor = Color.FromArgb(100, 59, 227, 255);
            Thread.Sleep(100);
            if (editHover == true)
            {
                this.SearchPanel.BackColor = Color.LightGray;
            }
            if (editHover == false)
            {
                this.SearchPanel.BackColor = Color.Transparent;
            }
        }

        private void Edit_Click_Color()
        {
            this.EditPanel.BackColor = Color.FromArgb(100, 59, 227, 255);
            Thread.Sleep(100);
            if (editHover == true)
            {
                this.EditPanel.BackColor = Color.LightGray;
            }
            if (editHover == false)
            {
                this.EditPanel.BackColor = Color.Transparent;
            }
        }

        private void PrintAll_Click_Color()
        {
            this.PrintAllPanel.BackColor = Color.FromArgb(100, 59, 227, 255);
            Thread.Sleep(100);
            if (printAllHover == true)
            {
                this.PrintAllPanel.BackColor = Color.LightGray;
            }
            if (printAllHover == false)
            {
                this.PrintAllPanel.BackColor = Color.Transparent;
            }
        }

        private void Print_Click_Color()
        {
            this.PrintPanel.BackColor = Color.FromArgb(100, 59, 227, 255);
            Thread.Sleep(100);
            if (printHover == true)
            {
                this.PrintPanel.BackColor = Color.LightGray;
            }
            if (printHover == false)
            {
                this.PrintPanel.BackColor = Color.Transparent;
            }
        }

        private void Prev_Click_Color()
        {
            this.PrevPanel.BackColor = Color.FromArgb(100, 59, 227, 255);
            Thread.Sleep(100);
            if (prevHover == true)
            {
                this.PrevPanel.BackColor = Color.LightGray;
            }
            if (prevHover == false)
            {
                this.PrevPanel.BackColor = Color.Transparent;
            }
        }

        private void Next_Click_Color()
        {
            this.NextPanel.BackColor = Color.FromArgb(100, 59, 227, 255);
            Thread.Sleep(100);
            if (nextHover == true)
            {
                this.NextPanel.BackColor = Color.LightGray;
            }
            if (nextHover == false)
            {
                this.NextPanel.BackColor = Color.Transparent;
            }
        }

        private void Next_Click(object sender, EventArgs e)
        {
            Thread clickColor = new Thread(new ThreadStart(Next_Click_Color));
            clickColor.Start();
            Update_Record(1);
        }

        private void Prev_Click(object sender, EventArgs e)
        {
            Thread clickColor = new Thread(new ThreadStart(Prev_Click_Color));
            clickColor.Start();
            Update_Record(-1);
        }

        private void Close_Click(object sender, EventArgs e)
        {
            if (edit == true)
            {
                dt.Rows[row][5] = CustomerName.Text;
                dt.Rows[row][6] = AddressLine1.Text;
                dt.Rows[row][7] = AddressLine2.Text;
                dt.Rows[row][8] = AddressLine3.Text;
                dt.Rows[row][9] = City.Text;
                dt.Rows[row][10] = StateCounty.Text;
                dt.Rows[row][11] = Postcode.Text;
                dt.Rows[row][12] = Country.Text;
                string updateTable = "UPDATE simpleTable SET [buyer-name]='" + dt.Rows[row][5].ToString() + "', [ship-address-1]='" + dt.Rows[row][6].ToString() + "', [ship-address-2]='" + dt.Rows[row][7].ToString() + "', [ship-address-3]='" + dt.Rows[row][8].ToString() + "', [ship-city]='" + dt.Rows[row][9].ToString() + "', [ship-state]='" + dt.Rows[row][10].ToString() + "', [ship-postal-code]='" + dt.Rows[row][11].ToString() + "', [ship-country]='" + dt.Rows[row][12].ToString() + "' WHERE [order-id] ='" + dt.Rows[row][0].ToString() + "';";
                OleDbCommand update = new OleDbCommand(updateTable, con);
                try
                {
                    con.Open();
                    update.ExecuteNonQuery();
                }
                catch (OleDbException er)
                {
                    MessageBox.Show(er.Message);
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
                finally
                {
                    con.Close();
                }
            }
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

        private void Maximize_Click(object sender, EventArgs e)
        {
            if (maximized == false)
            {
                maximized = true;
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                maximized = false;
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void Maximize_Hover(object sender, EventArgs e)
        {
            if (maximizeHover == false)
            {
                maximizeHover = true;
                this.MaximizePanel.BackColor = Color.LightGray;
                this.MaximizePanel.BackgroundImage = System.Drawing.Image.FromFile(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\Graphics\\Maximize Button Hover.png");
            }
        }

        private void Maximize_Leave(object sender, EventArgs e)
        {
            if (maximizeHover == true)
            {
                maximizeHover = false;
                this.MaximizePanel.BackColor = Color.Transparent;
                this.MaximizePanel.BackgroundImage = System.Drawing.Image.FromFile(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\Graphics\\Maximize Button.png");
            }
        }

        private void Next_Hover(object sender, EventArgs e)
        {
            if (nextHover == false)
            {
                nextHover = true;
                this.NextPanel.BackColor = Color.LightGray;
                this.NextPanel.BackgroundImage = System.Drawing.Image.FromFile(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\Graphics\\Right Arrow Hover.png");
            }
        }

        private void Next_Leave(object sender, EventArgs e)
        {
            if (nextHover == true)
            {
                nextHover = false;
                this.NextPanel.BackColor = Color.Transparent;
                this.NextPanel.BackgroundImage = System.Drawing.Image.FromFile(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\Graphics\\Right Arrow.png");
            }
        }

        private void Prev_Hover(object sender, EventArgs e)
        {
            if (prevHover == false)
            {
                prevHover = true;
                this.PrevPanel.BackColor = Color.LightGray;
                this.PrevPanel.BackgroundImage = System.Drawing.Image.FromFile(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\Graphics\\Left Arrow Hover.png");
            }
        }

        private void Prev_Leave(object sender, EventArgs e)
        {
            if (prevHover == true)
            {
                prevHover = false;
                this.PrevPanel.BackColor = Color.Transparent;
                this.PrevPanel.BackgroundImage = System.Drawing.Image.FromFile(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\Graphics\\Left Arrow.png");
            }
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            Thread clickColor = new Thread(new ThreadStart(Edit_Click_Color));
            clickColor.Start();
            edit = true;
            this.CustomerName.ReadOnly = false;
            this.AddressLine1.ReadOnly = false;
            this.AddressLine2.ReadOnly = false;
            this.AddressLine3.ReadOnly = false;
            this.City.ReadOnly = false;
            this.StateCounty.ReadOnly = false;
            this.Country.ReadOnly = false;
            this.City.ReadOnly = false;
            this.Postcode.ReadOnly = false;

        }

        private void Edit_Hover(object sender, EventArgs e)
        {
            if (editHover == false)
            {
                editHover = true;
                this.EditLabel.ForeColor = Color.Black;
                this.EditPanel.BackColor = Color.LightGray;
            }
        }

        private void Edit_Leave(object sender, EventArgs e)
        {
            if (editHover == true)
            {
                editHover = false;
                this.EditPanel.BackColor = Color.Transparent;
                this.EditLabel.ForeColor = Color.FromName("ControlDarkDark");
            }
        }

        private void Print_Click(object sender, EventArgs e)
        {
            Thread clickColor = new Thread(new ThreadStart(Print_Click_Color));
            clickColor.Start();
            singleprint = true;
            Export();
        }

        private void Print_Hover(object sender, EventArgs e)
        {
            if (printHover == false)
            {
                printHover = true;
                this.PrintLabel.ForeColor = Color.Black;
                this.PrintPanel.BackColor = Color.LightGray;
            }
        }

        private void Print_Leave(object sender, EventArgs e)
        {
            if (printHover == true)
            {
                printHover = false;
                this.PrintPanel.BackColor = Color.Transparent;
                this.PrintLabel.ForeColor = Color.FromName("ControlDarkDark");
            }
        }

        private void PrintAll_Click(object sender, EventArgs e)
        {
            Thread clickColor = new Thread(new ThreadStart(PrintAll_Click_Color));
            clickColor.Start();
            singleprint = false;
            Export();
        }

        private void PrintAll_Hover(object sender, EventArgs e)
        {
            if (printAllHover == false)
            {
                printAllHover = true;
                this.PrintAllLabel.ForeColor = Color.Black;
                this.PrintAllPanel.BackColor = Color.LightGray;
            }
        }

        private void PrintAll_Leave(object sender, EventArgs e)
        {
            if (printAllHover == true)
            {
                printAllHover = false;
                this.PrintAllPanel.BackColor = Color.Transparent;
                this.PrintAllLabel.ForeColor = Color.FromName("ControlDarkDark");
            }
        }

        private void Search_Click(object sender, EventArgs e)
        {
            Thread clickColor = new Thread(new ThreadStart(Search_Click_Color));
            clickColor.Start();
            int amount = 0;
            if (SearchCategory.Text == "Customer Name")
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (dt.Rows[i][5].ToString().Contains(Search.Text.ToString()))
                    {
                        amount++;
                    }
                }
                if (amount > 1)
                {
                    using (ExportSearch searchW = new ExportSearch())
                    {
                        this.Hide();
                        searchW.search = GEMCodeList.Text;
                        searchW.cat = SearchCategory.Text;
                        searchW.AfterInit();
                        searchW.ShowDialog(this);
                    }
                }
                else
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        if (dt.Rows[i][5].ToString().Contains(Search.Text.ToString()))
                        {
                            row = i;
                            Update_Record(0);
                            break;
                        }
                    }
                }
            }
            if (SearchCategory.Text == "Order ID")
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (dt.Rows[i][5].ToString().Contains(Search.Text.ToString()))
                    {
                        amount++;
                    }
                }
                if (amount > 1)
                {
                    using (ExportSearch searchW = new ExportSearch())
                    {
                        this.Hide();
                        searchW.search = GEMCodeList.Text;
                        searchW.cat = SearchCategory.Text;
                        searchW.AfterInit();
                        searchW.ShowDialog(this);
                    }
                }
                else
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        if (dt.Rows[i][0].ToString().Contains(Search.Text.ToString()))
                        {
                            row = i;
                            Update_Record(0);
                            break;
                        }
                    }
                }
            }
            if (SearchCategory.Text == "GEM Code")
            {
                using (ExportSearch searchW = new ExportSearch())
                {
                    this.Hide();
                    searchW.search = GEMCodeList.Text;
                    searchW.cat = SearchCategory.Text;
                    searchW.AfterInit();
                    searchW.ShowDialog(this);
                }
            }
        }

        private void Search_Hover(object sender, EventArgs e)
        {
            if (searchHover == false)
            {
                searchHover = true;
                this.SearchLabel.ForeColor = Color.Black;
                this.SearchPanel.BackColor = Color.LightGray;
            }
        }

        private void Search_Leave(object sender, EventArgs e)
        {
            if (searchHover == true)
            {
                searchHover = false;
                this.SearchPanel.BackColor = Color.Transparent;
                this.SearchLabel.ForeColor = Color.FromName("ControlDarkDark");
            }
        }

        private void Search_Category_Update(object sender, EventArgs e)
        {
            if (SearchCategory.Text == "Order ID" || SearchCategory.Text == "Customer Name")
            {
                this.Search.Visible = true;
                this.GEMCodeList.Visible = false;
            }
            if (SearchCategory.Text == "GEM Code")
            {
                this.Search.Visible = false;
                this.GEMCodeList.Visible = true;
            }
        }

        #endregion

        public void setRow(int sentrow)
        {
            this.Show();
            row = sentrow;
            Update_Record(0);
        }
        

    }
}
