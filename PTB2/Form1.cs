using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_QLDA
{
    public partial class Form1 : Form
    {
        double a,b,c,d,x1,x2;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                a = Convert.ToDouble(txta.Text);
                b = Convert.ToDouble(txtb.Text);
                c = Convert.ToDouble(txtc.Text);
                d = b * b - 4 * a * c;
                if (d < 0)
                    lblKQ.Text = "Phương trình vô nghiệm";
                else if (d == 0)
                {
                    x1 = -b / (2 * a);
                    lblKQ.Text = "Phương trình có nghiệm kép: x1 = x2 = " + x1;
                }
                else
                {
                    x1 = (-b + Math.Sqrt(d)) / (2 * a);
                    x2 = (-b - Math.Sqrt(d)) / (2 * a);
                    lblKQ.Text = "Phương trình có hai nghiệm phân biệt: x1 = " + Math.Round(x1,1) + ", x2 = " + Math.Round(x2,1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng số!");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnKT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblKQ_Click(object sender, EventArgs e)
        {

        }

        private void txta_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
