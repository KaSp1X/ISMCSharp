using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuadEquationWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label5.Visible = label6.Visible = label7.Visible = label8.Visible = false;
            textBox4.Visible = textBox5.Visible = textBox6.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label5.Visible = label6.Visible = label7.Visible = label8.Visible = false;
            textBox4.Visible = textBox5.Visible = textBox6.Visible = false;
            double a, b, c;
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            { 
            }
            else
            if (!double.TryParse(textBox1.Text, out a) || !double.TryParse(textBox2.Text, out b) || !double.TryParse(textBox3.Text, out c))
            {
            }
            else
            {
                double D = Math.Pow(b, 2) - 4 * a * c;
                label5.Visible = textBox4.Visible = true;
                textBox4.Text = D.ToString();
                if (D < 0) MessageBox.Show("Решений нет!");
                else
                if (D == 0)
                {
                    double x = -b / (2 * a);
                    label6.Visible = label7.Visible = textBox5.Visible = true;
                    textBox5.Text = x.ToString();
                }
                else
                {
                    double x1 = (-b + Math.Pow(D, -2)) / (2 * a);
                    double x2 = (-b - Math.Pow(D, -2)) / (2 * a);
                    label6.Visible = label7.Visible = textBox5.Visible = true;
                    textBox5.Text = x1.ToString();
                    label8.Visible = textBox6.Visible = true;
                    textBox6.Text = x2.ToString();
                }
            }
        }
    }
}
