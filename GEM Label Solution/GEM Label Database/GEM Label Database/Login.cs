using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace GEM_Label_Database
{
    public partial class LoginWindow : Form
    {
        public string InputUsername;
        public string InputPassword;
        public string Section = "Menu";
        public string who = "";
        public bool credChecked = false;
        public ArrayList userAccounts = new ArrayList();
        public ArrayList passAccounts = new ArrayList();



        public LoginWindow()
        {
            InitializeComponent();
            if (Section == "Menu")
            {
                userAccounts.Add("Admin");
                passAccounts.Add("12345678");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Submit_Click(object sender, EventArgs e)
        {
            if (Username.Text != "" && Password.Text != "")
            {
                for (int i = 0; i < userAccounts.Count && credChecked == false; i++)
                {
                    if (Username.Text.ToString() == userAccounts[i].ToString())
                    {
                        if (Password.Text.ToString() == passAccounts[i].ToString())
                        {
                            credChecked = true;
                            if (Section == "Menu")
                            {
                                MenuWindow InitMenu = new MenuWindow();
                                InitMenu.Show();
                                InitMenu.Activate();
                                InitMenu.who = Username.Text;
                                Password.ResetText();
                                Username.ResetText();
                                this.Hide();
                            }
                            else if (Section == "Options")
                            {
                                OptionsWindow OptionsW = new OptionsWindow();
                                OptionsW.Activate();
                                OptionsW.Show();
                                OptionsW.who = who;
                                for (int o = 0; o < userAccounts.Count; o++)
                                {
                                    OptionsW.userAccounts.Add(userAccounts[o].ToString());
                                    OptionsW.passAccounts.Add(passAccounts[o].ToString());
                                }
                                Password.ResetText();
                                Username.ResetText();
                                this.Hide();
                            }
                        }
                        else
                        {
                            System.Windows.Forms.MessageBox.Show("Password is invalid", "Invalid Password", MessageBoxButtons.OK);
                            Password.ResetText();
                        }
                    }
                    else
                    {
                        System.Windows.Forms.MessageBox.Show("Username invalid", "Invalid Username", MessageBoxButtons.OK);
                        Password.ResetText();
                    }
                }
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Username or Password are blank","Invalid Credentials",MessageBoxButtons.OK);
                Password.ResetText();
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

    }
}
