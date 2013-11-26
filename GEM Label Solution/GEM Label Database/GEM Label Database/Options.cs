using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace GEM_Label_Database
{
    public partial class OptionsWindow : Form
    {
        //Declare Vars and Instances
        bool userclosing = false;
        bool imported;
        bool createHover = false;
        bool editHover = false;
        bool deleteHover = false;
        bool acceptHover = false;
        bool cancelHover = false;
        bool closeHover = false;
        bool minimizeHover = false;
        public string who = "";
        bool accountExists = false;
        string accountMode = "";
        public ArrayList userAccounts = new ArrayList();
        public ArrayList passAccounts = new ArrayList();
        public string accountSource = System.IO.Path.GetDirectoryName(Application.ExecutablePath.ToString() + "\\Accounts.txt");
        public string accountTarget = System.IO.Path.GetDirectoryName(Application.ExecutablePath.ToString() + "\\Accounts.txt");
        public string[] accountLines;

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (userclosing == false)
            {
                MenuWindow MenuW = new MenuWindow();
                userclosing = true;
                this.Close();
                MenuW.Show();
                MenuW.SetPos(this.Left, this.Top);
            }
        }

        //Init OptionsWindow
        public OptionsWindow()
        {
            InitializeComponent();
            this.Draggable(true);
            CancelPanel.Hide();
            AcceptPanel.Hide();
            AccountPassword.Hide();
            AccountPasswordLabel.Hide();
            AccountName.Hide();
            AccountNameLabel.Hide();
            RetypePasswordLabel.Hide();
            RetypePassword.Hide();
        }
        //When user clicks Edit Accounts open the accounts editting interface
        private void Edit_Click(object sender, EventArgs e)
        {
            CancelPanel.Show();
            AcceptPanel.Show();
            AccountPassword.Show();
            AccountPasswordLabel.Show();
            AccountName.Show();
            AccountNameLabel.Show();
            RetypePasswordLabel.Show();
            RetypePassword.Show();
            accountMode = "Edit";
        }

        private void Edit_Hover(object sender, EventArgs e)
        {
            if (editHover == false)
            {
                editHover = true;
                this.EditPanel.BackColor = Color.LightGray;
            }
        }

        private void Edit_Leave(object sender, EventArgs e)
        {
            if (editHover == true)
            {
                editHover = false;
                this.EditPanel.BackColor = Color.Transparent;
            }
        }
        //When user clicks Delete Accounts open confirmation box
        private void Delete_Click(object sender, EventArgs e)
        {
            DialogResult DeleteMSGResult = MessageBox.Show("Are you sure you want to delete this User?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            //If confirmation box result is OK scan for account to delete from Arrays and Accounts List
            if (DeleteMSGResult == DialogResult.OK)
            {
                for (int i = 0; i < userAccounts.Count; i++)
                {
                    if (AccountList.GetItemText(AccountList.SelectedItem).ToString() == userAccounts[i].ToString())
                    {
                        userAccounts.RemoveAt(i);
                        passAccounts.RemoveAt(i);
                        AccountList.Items.RemoveAt(AccountList.SelectedIndex);
                    }
                }
            }
        }
        private void Delete_Hover(object sender, EventArgs e)
        {
            if (deleteHover == false)
            {
                deleteHover = true;
                this.DeletePanel.BackColor = Color.LightGray;
            }
        }

        private void Delete_Leave(object sender, EventArgs e)
        {
            if (deleteHover == true)
            {
                deleteHover = false;
                this.DeletePanel.BackColor = Color.Transparent;
            }
        }

        //When user clicks create account show account editting interface
        private void Create_Click(object sender, EventArgs e)
        {
            CancelPanel.Show();
            AcceptPanel.Show();
            AccountPassword.Show();
            AccountPasswordLabel.Show();
            AccountName.Show();
            AccountNameLabel.Show();
            RetypePasswordLabel.Show();
            RetypePassword.Show();
            accountMode = "Create";
        }

        private void Create_Hover(object sender, EventArgs e)
        {
            if (createHover == false)
            {
                createHover = true;
                this.CreatePanel.BackColor = Color.LightGray;
            }
        }

        private void Create_Leave(object sender, EventArgs e)
        {
            if (createHover == true)
            {
                createHover = false;
                this.CreatePanel.BackColor = Color.Transparent;
            }
        }

        //Run on Clicking OKAY
        private void Accept_Click(object sender, EventArgs e)
        {
            //If passwords match
            if (AccountPassword.Text == RetypePassword.Text)
            {
                //If user clicked create account
                if (accountMode == "Create")
                {
                    //check for duplicate accounts
                    for (int i = 0; i < userAccounts.Count; i++)
                    {
                        if (AccountName.Text.ToString() != userAccounts[i].ToString() && accountExists == false)
                        {
                            accountExists = false;
                        }
                        else
                        {
                            accountExists = true;
                        }
                    }
                    //If no account already exists
                    if (accountExists == false)
                    {
                        //Add username and password to arrays and add username to user list. Hide account editing section and reset textboxes.
                        userAccounts.Add(AccountName.Text.ToString());
                        passAccounts.Add(AccountPassword.Text.ToString());
                        AccountList.Items.Add(AccountName.Text.ToString());
                        AccountName.ResetText();
                        AccountPassword.ResetText();
                        RetypePassword.ResetText();
                        CancelPanel.Hide();
                        AcceptPanel.Hide();
                        AccountPassword.Hide();
                        AccountPasswordLabel.Hide();
                        AccountName.Hide();
                        AccountNameLabel.Hide();
                        RetypePasswordLabel.Hide();
                        RetypePassword.Hide();

                        string lineToWrite = null;
                        using (StreamReader reader = new StreamReader(accountSource))
                        {
                            int lineToEdit = File.ReadAllLines(accountSource).Count() + 1;
                            for (int i = 1; i <= lineToEdit; ++i)
                            lineToWrite = reader.ReadLine();
                        }

                        if (lineToWrite == null)
                            throw new InvalidDataException("Line does not exist in " + accountSource);

                        // Read the old file.
                        string[] lines = File.ReadAllLines(accountTarget);

                        // Write the new file over the old file.
                        using (StreamWriter writer = new StreamWriter(accountTarget))
                        {
                            int lineToEdit = File.ReadAllLines(accountSource).Count() + 1;
                            for (int currentLine = 1; currentLine <= lines.Length; ++currentLine)
                            {
                                if (currentLine == lineToEdit)
                                {
                                    writer.WriteLine(lineToWrite);
                                }
                                else
                                {
                                    writer.WriteLine(lines[currentLine - 1]);
                                }
                            }
                        }

                    }
                    else
                    {
                        MessageBox.Show("Account already exists", "Pre-existing Accont", MessageBoxButtons.OK);
                        AccountName.ResetText();
                        AccountPassword.ResetText();
                        RetypePassword.ResetText();
                    }
                }
            }
        }
        //When user clicks cancel hide account editting interface
        private void Accept_Hover(object sender, EventArgs e)
        {
            if (acceptHover == false)
            {
                acceptHover = true;
                this.AcceptPanel.BackColor = Color.LightGray;
            }
        }

        private void Accept_Leave(object sender, EventArgs e)
        {
            if (acceptHover == true)
            {
                acceptHover = false;
                this.AcceptPanel.BackColor = Color.Transparent;
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            CancelPanel.Hide();
            AcceptPanel.Hide();
            AccountPassword.Hide();
            AccountPasswordLabel.Hide();
            AccountName.Hide();
            AccountNameLabel.Hide();
            RetypePasswordLabel.Hide();
            RetypePassword.Hide();
        }

        private void Cancel_Hover(object sender, EventArgs e)
        {
            if (cancelHover == false)
            {
                cancelHover = true;
                this.CancelPanel.BackColor = Color.LightGray;
            }
        }

        private void Cancel_Leave(object sender, EventArgs e)
        {
            if (cancelHover == true)
            {
                cancelHover = false;
                this.CancelPanel.BackColor = Color.Transparent;
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
    }
}
