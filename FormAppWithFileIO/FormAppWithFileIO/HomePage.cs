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
    public partial class HomePage : Form
    {
        string path = @"../../HelloWorld.txt";
        public HomePage()
        {
            InitializeComponent();
        }

        private void btnShowUsers_Click(object sender, EventArgs e)
        {
            lblRes.Text = "";
            string[] arr = File.ReadAllLines(path);
            foreach (var line in arr)
                lblRes.Text += line + "\n";
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }
    }
}
