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
    public partial class OptionsWindow: Form
    {
        string accountMode = "";
        string newUser = "";
        string newPassword = "";
        string[,] userAccounts;

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

            for (int i = 0; i < userAccounts.Length; i++)
            {
                AccountList.Items.Add(userAccounts[i, 0]);
            }
        }

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

        private void DeleteAccount_Click(object sender, EventArgs e)
        {

        }

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

        private void AccountOkay_Click(object sender, EventArgs e)
        {
            if(AccountPassword == RetypePassword)
            {
                if (accountMode == "Create")
                {
                    newUser = AccountName.ToString();
                    newPassword = AccountPassword.ToString();
                    if (System.IO.File.Exists(System.IO.Path.GetDirectoryName(Application.ExecutablePath + "config.ini")) == true)
                    {
                        //http://support.microsoft.com/kb/816149
                    }
                }

                AccountList.Items.Add(newUser);
            }
        }

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
    }
}
