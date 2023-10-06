using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulator_Sederhana
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtNomorA.Clear();
            txtNomorB.Clear();
            lblHasil.Text = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtNomorA.Text) || string.IsNullOrEmpty(txtNomorB.Text))
            {
                MessageBox.Show("Nomor A atau Nomor B Tidak Boleh Kosong!!");
            } else
            {
                int a = int.Parse(txtNomorA.Text);
                int b = int.Parse(txtNomorB.Text);
                int c = a + b;
                lblHasil.Text = c.ToString();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtNomorA.Clear();
            txtNomorB.Clear();
            lblHasil.Text = string.Empty;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNomorA.Text) || string.IsNullOrEmpty(txtNomorB.Text))
            {
                MessageBox.Show("Nomor A atau Nomor B Tidak Boleh Kosong!!");
            }
            else
            {
                int a = int.Parse(txtNomorA.Text);
                int b = int.Parse(txtNomorB.Text);
                int c = a - b;
                lblHasil.Text = c.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNomorA.Text) || string.IsNullOrEmpty(txtNomorB.Text))
            {
                MessageBox.Show("Nomor A atau Nomor B Tidak Boleh Kosong!!");
            }
            else
            {
                int a = int.Parse(txtNomorA.Text);
                int b = int.Parse(txtNomorB.Text);
                int c = a * b;
                lblHasil.Text = c.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNomorA.Text) || string.IsNullOrEmpty(txtNomorB.Text))
            {
                MessageBox.Show("Nomor A atau Nomor B Tidak Boleh Kosong!!");
            }
            else
            {
                int a = int.Parse(txtNomorA.Text);
                int b = int.Parse(txtNomorB.Text);
                int c = a / b;
                lblHasil.Text = c.ToString();
            }
        }
    }
}
