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
        public string who = "";
        bool accountExists = false;
        string accountMode = "";
        public ArrayList userAccounts = new ArrayList();
        public ArrayList passAccounts = new ArrayList();
        public string accountSource = System.IO.Path.GetDirectoryName(Application.ExecutablePath.ToString() + "\\Accounts.txt");
        public string accountTarget = System.IO.Path.GetDirectoryName(Application.ExecutablePath.ToString() + "\\Accounts.txt");
        public string[] accountLines;
        
        //Init OptionsWindow
        public OptionsWindow()
        {
            InitializeComponent();

            AccountCancel.Hide();
            AccountOkay.Hide();
            AccountPassword.Hide();
            AccountPasswordLabel.Hide();
            AccountName.Hide();
            AccountNameLabel.Hide();
            RetypePasswordLabel.Hide();
            RetypePassword.Hide();
        }
        //When user clicks Edit Accounts open the accounts editting interface
        private void EditAccount_Click(object sender, EventArgs e)
        {
            AccountCancel.Show();
            AccountOkay.Show();
            AccountPassword.Show();
            AccountPasswordLabel.Show();
            AccountName.Show();
            AccountNameLabel.Show();
            RetypePasswordLabel.Show();
            RetypePassword.Show();
            accountMode = "Edit";
        }
        //When user clicks Delete Accounts open confirmation box
        private void DeleteAccount_Click(object sender, EventArgs e)
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
        //When user clicks create account show account editting interface
        private void CreateAccount_Click(object sender, EventArgs e)
        {
            AccountCancel.Show();
            AccountOkay.Show();
            AccountPassword.Show();
            AccountPasswordLabel.Show();
            AccountName.Show();
            AccountNameLabel.Show();
            RetypePasswordLabel.Show();
            RetypePassword.Show();
            accountMode = "Create";
        }
        //Run on Clicking OKAY
        private void AccountOkay_Click(object sender, EventArgs e)
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
                        AccountCancel.Hide();
                        AccountOkay.Hide();
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
        private void AccountCancel_Click(object sender, EventArgs e)
        {
            AccountCancel.Hide();
            AccountOkay.Hide();
            AccountPassword.Hide();
            AccountPasswordLabel.Hide();
            AccountName.Hide();
            AccountNameLabel.Hide();
            RetypePasswordLabel.Hide();
            RetypePassword.Hide();
        }

        private void OptionsExit_Click(object sender, EventArgs e)
        {
            MenuWindow menuWindow = new MenuWindow();
            menuWindow.Visible = true;
            this.Close();
        }
    }
}
