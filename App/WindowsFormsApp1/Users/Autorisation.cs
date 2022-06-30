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
    public partial class Autorisation : Form
    {
        public Autorisation(Main F)
        {
            InitializeComponent();
            f = F;
        }

        private void autoris_Click(object sender, EventArgs e)
        {
            try
            {
                if ("root" == login.Text && "root" == password.Text)
                {
                    f.userName.Visible = true;
                    f.userName.Text = login.Text;
                    f.autorisation.Visible = false;
                    f.Show(); Close();
                }
                else throw new Exception();
            }
            catch
            {
                MessageBox.Show("Неверные данные пользователя");
            }
            finally
            {
                login.Text = ""; password.Text = "";
            }
        }

        private void Autorisation_FormClosing(object sender, FormClosingEventArgs e)
        {
            f.Show(); Close();
        }

        private void Autorisation_Load(object sender, EventArgs e)
        {

        }
    }
}
