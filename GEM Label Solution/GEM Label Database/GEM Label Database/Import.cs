using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Reflection;
using Access = Microsoft.Office.Interop.Access;
using Microsoft.Office.Core;

namespace GEM_Label_Database
{
    public partial class ImportWindow : Form
    {
        private bool exported = false;
        private bool closeHover = false;
        private bool maximizeHover = false;
        private bool minimizeHover = false;
        private bool exportHover = false;
        private bool selectHover = false;
        private bool maximized = false;
        public bool print = false;
        public bool imported;
        public string[,] ImportedArray;
        public string ImportedString;
        public string[] lines;
        public string[,] sortedlines = new string[1000000, 24];
        public string[] line;
        public bool colNull = false;
        public int colSize = 0;
        char[] delimiters = new char[] { '\t' };
        DataTable dt = new DataTable();
        DataTable sqt = new DataTable();
        DataTable cqt = new DataTable();
        public bool userclosing;

        public void SetPos(int x, int y)
        {
            this.Top = y;
            this.Left = x;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (userclosing == false && print == false)
            {
                MenuWindow MenuW = new MenuWindow();
                userclosing = true;
                this.Close();
                MenuW.Show();
                MenuW.SetPos(this.Left, this.Top);
                MenuW.imported = imported;
            }
        }

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
                dt.Clear();
                dt.Columns.Clear();
                //Adds each line to array
                lines = System.IO.File.ReadAllLines(selectFile.FileName);
                //Splits each line by tabs
                for (int i = 0; i < lines.Length; i++)
                {
                    line = lines[i].Split(delimiters, StringSplitOptions.None);
                    for (int o = 0; o < line.Length; o++)
                    {
                        sortedlines[i, o] = line[o];//.Replace("-","_");
                    }
                }

                for (int i = 0; colNull == false; i++)
                {
                    if (sortedlines[i, 0] != null)
                    {
                        colSize += 1;
                    }
                    else
                    {
                        colNull = true;
                    }
                }

                //for (int i = 0; i < colSize; i++)
                //{
                //    for (int o = 0; o < 24; o++)
                //    {
                //        if (sortedlines[i, o] == "")
                //        {
                //            sortedlines[i, o] = "NULL";
                //        }
                //    }
                //}

                for (int i = 0; i < 24; i++)
                {
                    dt.Columns.Add(sortedlines[0, i], Type.GetType("System.String"));
                }

                for (int i = 1; i < colSize; i++)
                {
                    dt.Rows.Add();
                    for (int o = 0; o < 24; o++)
                    {
                        dt.Rows[dt.Rows.Count - 1][sortedlines[0, o]] = sortedlines[i, o];
                    }
                }

                for (int i = 0; i < colSize; i++)
                {
                    for (int o = 0; o < 24; o++)
                    {
                        ImportList.DataSource = dt;
                    }
                }


                //Adds all lines to the checked list box
                //for (int i = 1; i != lines.Length; i++)
                //{
                //    //Checks for duplicates
                //    if (!ImportList.Rows.Contains(sortedlines[i]))
                //    {
                //        //Adds line i to checkboxlist
                //        this.ImportList.Items.Add(lines[i]);
                //    }
                //}
            }
        }

        public void ImportDelete_Click(object sender, EventArgs e)
        {
            //Displays confirmation of deletion
            DialogResult DeleteMSGResult = MessageBox.Show("Are you sure you want to remove the selected items from the list? (They will still be in the txt file to reimport later)", "Remove Items?", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            //If user clicks OK
            if (DeleteMSGResult == DialogResult.OK)
            {
                //    //While there are checked items in Checkbox List do this
                //    while (ImportList.CheckedIndices.Count > 0)
                //    {
                //        //Removes first checkbox
                //        ImportList.Items.RemoveAt(ImportList.CheckedIndices[0]);
                //    }
                //}
            }
        }

        public ImportWindow()
        {
            InitializeComponent();
            WindowResize();
            this.Draggable(true);
        }

        private void ImportSelect_Click(object sender, EventArgs e)
        {
            
        }

        private void WindowResize()
        {

        }

        private void ImportWindow_Load(object sender, EventArgs e)
        {

        }

        private void RunMacro(object oApp, object[] oRunArgs)
        {
            oApp.GetType().InvokeMember("Run",
            System.Reflection.BindingFlags.Default |
            System.Reflection.BindingFlags.InvokeMethod,
            null, oApp, oRunArgs);
        }

        #region "Appearance and Buttons"

        private void Select_Click(object sender, EventArgs e)
        {
            ImportData();
            if (dt.Rows.Count != 0)
            {
                OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\Database8.accdb");
                string colnames = "CREATE TABLE pImport(";
                string simplequery = "SELECT [order-id], [order-item-id], [purchase-date], [payments-date], [reporting-date], [promise-date], [days-past-promise], [buyer-email], [buyer-name], [buyer-phone-number], [sku], [product-name], [quantity-purchased], [quantity-shipped], [quantity-to-ship], [ship-service-level], [recipient-name], [ship-address-1], [ship-address-2], [ship-address-3], [ship-city], [ship-state], [ship-postal-code], [ship-country] FROM pImport WHERE [ship-country] LIKE " + '"' + "GB" + '"' + " AND [order-id] In (SELECT [order-id] FROM pImport As Tmp GROUP BY [order-id] HAVING Count(*)=1)ORDER BY [order-id]";
                string createsimplequery = "SELECT [order-id], [order-item-id], [purchase-date], [payments-date], [reporting-date], [promise-date], [days-past-promise], [buyer-email], [buyer-name], [buyer-phone-number], [sku], [product-name], [quantity-purchased], [quantity-shipped], [quantity-to-ship], [ship-service-level], [recipient-name], [ship-address-1], [ship-address-2], [ship-address-3], [ship-city], [ship-state], [ship-postal-code], [ship-country] INTO simpleTable FROM pImport WHERE [ship-country] LIKE " + '"' + "GB" + '"' + " AND [order-id] In (SELECT [order-id] FROM pImport As Tmp GROUP BY [order-id] HAVING Count(*)=1)ORDER BY [order-id]";
                string comlpexquery = "SELECT [order-id], [order-item-id], [purchase-date], [payments-date], [reporting-date], [promise-date], [days-past-promise], [buyer-email], [buyer-name], [buyer-phone-number], [sku], [product-name], [quantity-purchased], [quantity-shipped], [quantity-to-ship], [ship-service-level], [recipient-name], [ship-address-1], [ship-address-2], [ship-address-3], [ship-city], [ship-state], [ship-postal-code], [ship-country] FROM pImport WHERE [ship-country] <> " + '"' + "GB" + '"' + " OR [order-id] In (SELECT [order-id] FROM pImport As Tmp GROUP BY [order-id] HAVING Count(*)>1)ORDER BY [order-id]";
                string createcomlpexquery = "SELECT [order-id], [order-item-id], [purchase-date], [payments-date], [reporting-date], [promise-date], [days-past-promise], [buyer-email], [buyer-name], [buyer-phone-number], [sku], [product-name], [quantity-purchased], [quantity-shipped], [quantity-to-ship], [ship-service-level], [recipient-name], [ship-address-1], [ship-address-2], [ship-address-3], [ship-city], [ship-state], [ship-postal-code], [ship-country] INTO complexTable FROM pImport WHERE [ship-country] <> " + '"' + "GB" + '"' + " OR [order-id] In (SELECT [order-id] FROM pImport As Tmp GROUP BY [order-id] HAVING Count(*)>1)ORDER BY [order-id]";
                //string columns = "";

                for (int i = 0; i < 24; i++)
                {
                    colnames = colnames + "[" + sortedlines[0, i] + "]" + " TEXT(255)";
                    if (i == 1)
                    {
                        colnames = colnames + " PRIMARY KEY";
                    }
                    if (i < 23)
                    {
                        colnames = colnames + ", ";
                    }
                }

                colnames = colnames + ")";
                //MessageBox.Show(colnames);
                OleDbCommand create = new OleDbCommand(colnames, con);
                OleDbDataAdapter squery = new OleDbDataAdapter(simplequery, con);
                OleDbDataAdapter cquery = new OleDbDataAdapter(comlpexquery, con);
                OleDbCommand createsquery = new OleDbCommand(createsimplequery, con);
                OleDbCommand createcquery = new OleDbCommand(createcomlpexquery, con);
                //for (int i = 0; i < 24; i++)
                //{
                //    columns = columns + "[" + sortedlines[0, i] + "]";
                //    if (i < 23)
                //    {
                //        columns = columns + ", ";
                //    }
                //    else
                //    {
                //        columns = columns + ")";
                //    }
                //}

                try
                {
                    con.Open();
                    create.ExecuteNonQuery();

                    //for (int i = 1; i < colSize; i++)
                    //{
                    //    string addlines = "INSERT INTO pImport VALUES(";
                    //    for (int o = 0; o < 24; o++)
                    //    {
                    //        addlines = addlines + "[" + sortedlines[i,o] + "]";
                    //    }
                    //    OleDbCommand insert = new OleDbCommand(addlines, con);
                    //    insert.ExecuteNonQuery();
                    //}
                    con.Close();
                }
                catch (OleDbException d)
                {
                    if (d.ErrorCode == -2147217900 || d.ErrorCode == 3010 || d.ErrorCode == 3012)
                    {
                        OleDbCommand delete = new OleDbCommand("DROP TABLE [pImport]", con);
                        delete.ExecuteNonQuery();
                        create.ExecuteNonQuery();
                        //for (int i = 1; i < colSize; i++)
                        //{
                        //    string addlines = "INSERT INTO pImport("+ columns +" VALUES(";
                        //    for (int o = 0; o < 24; o++)
                        //    {
                        //        addlines = addlines + "[" + sortedlines[i, o] + "]";
                        //        if (o < 23)
                        //        {
                        //            addlines = addlines + ", ";
                        //        }
                        //        else
                        //        {
                        //            addlines = addlines + ")";
                        //        }
                        //    }
                        //    MessageBox.Show(addlines);
                        //    OleDbCommand insert = new OleDbCommand(addlines, con);
                        //    insert.ExecuteNonQuery();
                        //}
                        con.Close();
                    }
                }
                OleDbDataAdapter adapter = new OleDbDataAdapter();
                adapter.SelectCommand = new OleDbCommand("SELECT * FROM [pImport]", con);
                OleDbCommandBuilder cbr = new OleDbCommandBuilder(adapter);
                cbr.QuotePrefix = "[";
                cbr.QuoteSuffix = "]";
                cbr.GetDeleteCommand();
                cbr.GetInsertCommand();
                cbr.GetUpdateCommand();
                try
                {
                    con.Open();
                    adapter.Update(dt);
                }
                catch (OleDbException ex)
                {
                    MessageBox.Show(ex.Message, "OledbException Error");
                }
                catch (Exception x)
                {
                    MessageBox.Show(x.Message, "Exception Error");
                }
                finally
                {
                    con.Close();
                }

                try
                {
                    con.Open();
                    createsquery.ExecuteNonQuery();
                    createcquery.ExecuteNonQuery();
                    squery.Fill(sqt);
                    cquery.Fill(cqt);
                    SimpleList.DataSource = sqt;
                    ComplexList.DataSource = cqt;
                }
                catch (OleDbException ex)
                {
                    if (ex.ErrorCode == -2147217900 || ex.ErrorCode == 3010 || ex.ErrorCode == 3012)
                    {
                        if (con.State.ToString() != "Open")
                        {
                            con.Open();
                        }
                        OleDbCommand deleteS = new OleDbCommand("DROP TABLE [simpleTable]", con);
                        OleDbCommand deleteC = new OleDbCommand("DROP TABLE [complexTable]", con);
                        deleteS.ExecuteNonQuery();
                        deleteC.ExecuteNonQuery();
                        createsquery.ExecuteNonQuery();
                        createcquery.ExecuteNonQuery();
                        squery.Fill(sqt);
                        cquery.Fill(cqt);
                        SimpleList.DataSource = sqt;
                        ComplexList.DataSource = cqt;
                    }
                    else
                        MessageBox.Show(ex.Message + "\n" + ex.ErrorCode, "OleDbExeption Error");
                }
                catch (Exception x)
                {
                    MessageBox.Show(x.Message, "Exeption Error");
                }
                finally
                {
                    con.Close();
                }

                try
                {
                    Access.ApplicationClass oAccess = new Access.ApplicationClass();
                    oAccess.Visible = true;
                    oAccess.OpenCurrentDatabase(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\Database8.accdb", false, "");
                    //MessageBox.Show(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\Database8.accdb");
                    RunMacro(oAccess, new Object[] { "TestMacro" });
                    oAccess.DoCmd.Quit(Access.AcQuitOption.acQuitSaveNone);
                }
                catch (OleDbException ex)
                {
                    MessageBox.Show(ex.Message, "OleDbExeption Error");
                }
                catch (Exception x)
                {
                    MessageBox.Show(x.Message, "Exeption Error");
                }
                finally
                {

                }
                //System.Diagnostics.Process.Start("E:\\GEM Label Solution\\GEM Label Database\\GEM Label Database\\bin\\Debug\\ImportToDatabase.bat");
                imported = true;
            }
            else
            {
                MessageBox.Show("No file selected", "Cannot Import");
            }
        }

        private void Select_Hover(object sender, EventArgs e)
        {
            if (selectHover == false)
            {
                selectHover = true;
                this.SelectFilePanel.BackColor = Color.LightGray;
            }
        }

        private void Select_Leave(object sender, EventArgs e)
        {
            if (selectHover == true)
            {
                selectHover = false;
                this.SelectFilePanel.BackColor = Color.Transparent;
            }
        }

        private void Export_Click(object sender, EventArgs e)
        {
            print = true;
            PrintWindow PrintW = new PrintWindow();
            PrintW.Show();
            PrintW.SetPos(this.Left, this.Top);
            PrintW.imported = imported;
            this.Close();
        }

        private void Export_Hover(object sender, EventArgs e)
        {
            if (exportHover == false)
            {
                exportHover = true;
                this.ExportPanel.BackColor = Color.LightGray;
            }
        }

        private void Export_Leave(object sender, EventArgs e)
        {
            if (exportHover == true)
            {
                exportHover = false;
                this.ExportPanel.BackColor = Color.Transparent;
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

        #endregion
    }
}
