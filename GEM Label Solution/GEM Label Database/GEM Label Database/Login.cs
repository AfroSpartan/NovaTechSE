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
using System.IO;
using System.Threading;

namespace GEM_Label_Database
{
    public partial class LoginWindow : Form
    {
        public string InputUsername;
        public string InputPassword;
        public string Section = "Menu";
        bool userclosing = false;
        private bool submitHover = false;
        private bool cancelHover = false;
        private bool minimizeHover = false;
        private bool closeHover = false;
        public bool imported;
        public string who = "";
        public bool PassOk = false;
        public bool UserOk = false;
        public bool credChecked = false;
        public ArrayList userAccounts = new ArrayList();
        public ArrayList passAccounts = new ArrayList();
        //public Debug DebugMenu = new Debug();

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (userclosing == false && Section != "Menu")
            {
                MenuWindow MenuW = new MenuWindow();
                userclosing = true;
                this.Close();
                MenuW.Show();
                MenuW.imported = imported;
            }
        }

        //public void SplashStart()
        //{
        //    Application.Run(new Splash());
        //}

        public LoginWindow()
        {
            ////Thread t = new Thread(new ThreadStart(SplashStart));
            ////t.Start();
            ////Thread.Sleep(5000);
            InitializeComponent();
            this.Draggable(true);
            ////t.Abort();
            //if (File.Exists("Accounts.txt") == false)
            //{
            //    File.Create("Accounts.txt");
            //}
            ////DebugMenu.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //MenuWindow InitMenu = new MenuWindow();
            //InitMenu.Show();
            //InitMenu.Activate();
        }

        private void Cancel_Click_Color()
        {
            this.CancelPanel.BackColor = Color.FromArgb(100, 59, 227, 255);
            Thread.Sleep(100);
            if (cancelHover == true)
            {
                this.CancelPanel.BackColor = Color.LightGray;
            }
            if (cancelHover == false)
            {
                this.CancelPanel.BackColor = Color.Transparent;
            }
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            Submit_Click_Color();
            credChecked = false;
            //if (Section == "Menu")
            //{
            if (userAccounts.Count == 0 && passAccounts.Count == 0)
            {
                userAccounts.Add("Admin");
                passAccounts.Add("12345678");
            }
            //}
            if (Username.Text != "" || Password.Text != "")
            {
                for (int i = 0; i < userAccounts.Count && credChecked == false; i++)
                {
                    if (Username.Text.ToString() == userAccounts[i].ToString())
                    {
                        UserOk = true;
                        credChecked = true;
                    }
                    if (Password.Text.ToString() == passAccounts[i].ToString())
                    {
                        PassOk = true;
                        credChecked = true;
                    }
                }
                if (UserOk == true)
                {
                    if (PassOk == true)
                    {
                        if (Section == "Menu")
                        {
                            MenuWindow InitMenu = new MenuWindow();
                            InitMenu.Show();
                            InitMenu.Activate();
                            InitMenu.who = Username.Text;
                            Password.Text = "";
                            Username.Text = "";
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
                            Password.Text = "";
                            Username.Text = "";
                            this.Hide();
                        }
                    }
                    else
                    {
                        System.Windows.Forms.MessageBox.Show("Password invalid", "Invalid Password", MessageBoxButtons.OK);
                        Password.ResetText();
                    }
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Username invalid", "Invalid Username", MessageBoxButtons.OK);
                    Password.ResetText();
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
            Cancel_Click_Color();
            if (Section != "Menu")
            {
                MenuWindow InitMenu = new MenuWindow();
                InitMenu.Show();
                InitMenu.Activate();
                InitMenu.who = Username.Text;
                Password.Text = "";
                Username.Text = "";
            }
            this.Dispose();
        }

        private void Submit_Click_Color()
        {
            this.SubmitPanel.BackColor = Color.FromArgb(100, 59, 227, 255);
            Thread.Sleep(100);
            if (submitHover == true)
            {
                this.SubmitPanel.BackColor = Color.LightGray;
            }
            if (submitHover == false)
            {
                this.SubmitPanel.BackColor = Color.Transparent;
            }
        }

        private void Submit_Hover(object sender, EventArgs e)
        {
            if (submitHover == false)
            {
                submitHover = true;
                this.SubmitPanel.BackColor = Color.LightGray;
            }
        }

        private void Submit_Leave(object sender, EventArgs e)
        {
            if (submitHover == true)
            {
                submitHover = false;
                this.SubmitPanel.BackColor = Color.Transparent;
            }
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
