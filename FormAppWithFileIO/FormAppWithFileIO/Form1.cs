using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormAppWithFileIO
{
    public partial class Form1 : Form
    {
        string path = @"../../HelloWorld.txt";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (emailInput.Text != "" || passwordInput.Text != "")
            {
                string[] lines = File.ReadAllLines(path);

                foreach (string line in lines)
                {
                    int emailIndex = line.IndexOf("Email = ");
                    int passwordIndex = line.IndexOf("Password = ");
                    if (emailIndex == -1 || passwordIndex == -1)
                        break;
                    bool strEmailCut = line.Substring(emailIndex + 8, emailInput.Text.Length) == emailInput.Text;
                    bool strPasswordCut = line.Substring(passwordIndex + 11, passwordInput.Text.Length) == passwordInput.Text;
                    if (strEmailCut && strPasswordCut)
                    {
                        MessageBox.Show("Successfully loged in");
                        HomePage homePage = new HomePage();
                        this.Hide();
                        homePage.Show();
                        return;
                    }
                }

                MessageBox.Show("Invalid login");


                //SignupPage signupPage = new SignupPage();

                // this.Hide();
                //signupPage.Show();
            }
            else
                MessageBox.Show("Try again...");

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            SignupPage signupPage = new SignupPage();
            this.Hide();
            signupPage.Show();
        }
    }
}
