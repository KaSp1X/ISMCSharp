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
            labelD.Visible = Results.Visible = labelX1.Visible = labelX2.Visible = false;
            textBoxD.Visible = textBoxX1.Visible = textBoxX2.Visible = false;
        }

        private void count_Click(object sender, EventArgs e)
        {
            labelD.Visible = Results.Visible = labelX1.Visible = labelX2.Visible = false;
            textBoxD.Visible = textBoxX1.Visible = textBoxX2.Visible = false;
            double a, b, c;
            if (textBoxA.Text == "" || textBoxB.Text == "" || textBoxC.Text == "")
            { 
            }
            else
            if (!double.TryParse(textBoxA.Text, out a) || !double.TryParse(textBoxB.Text, out b) || !double.TryParse(textBoxC.Text, out c))
            {
            }
            else
            {
                double D = Math.Pow(b, 2) - 4 * a * c;
                labelD.Visible = textBoxD.Visible = true;
                textBoxD.Text = D.ToString();
                if (D < 0) MessageBox.Show("Решений нет!");
                else
                if (D == 0)
                {
                    double x = -b / (2 * a);
                    Results.Visible = labelX1.Visible = textBoxX1.Visible = true;
                    textBoxX1.Text = x.ToString();
                }
                else
                {
                    double x1 = (-b + Math.Pow(D, -2)) / (2 * a);
                    double x2 = (-b - Math.Pow(D, -2)) / (2 * a);
                    Results.Visible = labelX1.Visible = textBoxX1.Visible = true;
                    textBoxX1.Text = x1.ToString();
                    labelX2.Visible = textBoxX2.Visible = true;
                    textBoxX2.Text = x2.ToString();
                }
            }
        }
    }
}
