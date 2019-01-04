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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Pretvorigumb_Click(object sender, EventArgs e)
        {
            try
            {
                double a,b;
                a = Convert.ToDouble(txtbox1.Text);
                b = Convert.ToDouble(tecajtxtbox.Text);
                double result = a * b;
                txtbox2.Text = result.ToString();
            }
            catch(Exception)
            {
                MessageBox.Show("Error!");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double a,b;
                a = Convert.ToDouble(txtbox2.Text);
                b = Convert.ToDouble(tecajtxtbox.Text);
                double result = a / b;
                txtbox1.Text = result.ToString();
            }
            catch(Exception)
            {
                MessageBox.Show("Error!");
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

    }
}
