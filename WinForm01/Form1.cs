using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void count_Click(object sender, EventArgs e)
        {
            double a, b, x;
            if (textBoxA.Text == "" || textBoxB.Text == "" || textBoxX.Text == "")
            {
                richTextBoxResult.AppendText("Значение введено неверно!\n");
            }
            else
            if(!double.TryParse(textBoxA.Text, out a) || !double.TryParse(textBoxB.Text, out b) || !double.TryParse(textBoxX.Text, out x))
            {
                richTextBoxResult.AppendText("Значение введено неверно!\n");
            }
            else
            {
                double y = 2.4 * Math.Abs((Math.Pow(x, 2) + b) / a) + (a - b) * Math.Pow(Math.Sin(a - b), 2) + Math.Pow(10, -2) * (x - b);
                richTextBoxResult.AppendText("Решение: " + y + "\n");
            }
        }
    }
}
