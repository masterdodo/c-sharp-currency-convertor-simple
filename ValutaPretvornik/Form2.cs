using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ValutaPretvornik
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void loginbutton_Click(object sender, EventArgs e)
        {
                string a = prijavatxtbox.Text;
                if (a == "12345")
                {
                    Form1 mainForm = new Form1();
                    Form2 loginForm = new Form2();
                    this.Hide();
                    mainForm.Show();
            }
                else
                {
                    prijavatxtbox.Text = "";
                    MessageBox.Show("Napačno geslo");
                }
        }
    }
}