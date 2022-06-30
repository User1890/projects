using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Registration : Form
    {
        
        public Registration(Main F, Autorisation A)
        {
            InitializeComponent();
            a = A; f = F;
        }

        private void registr_Click(object sender, EventArgs e)
        {
            File.AppendAllText(@"C:\Users\Ru\source\repos\WindowsFormsApp1-master\WindowsFormsApp1\Users.txt", login.Text + " " + password.Text + "\n");
        }
        private void autoris_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            a.Show(); Close();
        }
        private void Autorisation_FormClosing(object sender, FormClosingEventArgs e)
        {
            f.Show();
        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }
    }
}
