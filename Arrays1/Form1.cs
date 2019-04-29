using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arrays1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            int N;
            if(!int.TryParse(textBoxNumberOfElements.Text, out N))
            {
                MessageBox.Show("Введено неверные данные в строку количества элементов массива!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            buttonCount.Enabled = buttonRandom.Enabled = true;
            dataGridArray.ColumnCount = N;
            dataGridArray.RowCount = 1;
            for (int i = 0; i < N; i++)
            {
                dataGridArray.Columns[i].HeaderText = i.ToString();
                dataGridArray.Columns[i].Width = 65;
            }
        }


        private void buttonRandom_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            for (int i = 0; i < dataGridArray.ColumnCount; i++)
            {
                dataGridArray.Rows[0].Cells[i].Value = Math.Round(rand.NextDouble() * 30 - 15, 1);
            }
        }

        private void buttonCount_Click(object sender, EventArgs e)
        {
            double[] array = new double[dataGridArray.ColumnCount];
            bool check = true;
            for (int i = 0; i < dataGridArray.ColumnCount; i++)
            {
                check = double.TryParse(dataGridArray.Rows[0].Cells[i].Value.ToString() , out array[i]);
                if (!check)
                {
                    MessageBox.Show("Какая то ячейка пуста или содержит не число!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            double SumNeg = 0;
            double MaxElement = double.MinValue; int indexMax = -1;
            double MaxAbsElement = -1;
            int SumIndex = 0;
            int CountIntegers = 0;
            for(int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0) SumNeg += array[i];
                if (array[i] > MaxElement) { MaxElement = array[i]; indexMax = i; }
                if (Math.Abs(array[i]) > MaxAbsElement) MaxAbsElement = Math.Abs(array[i]);
                if (array[i] > 0) SumIndex += i;
                if (array[i] % 2 == 0) CountIntegers++;
            }
            textBoxSumNeg.Text = SumNeg.ToString();
            textBoxMaxElement.Text = MaxElement.ToString();
            textBoxIndexMax.Text = indexMax.ToString();
            textBoxMaxAbsElement.Text = MaxAbsElement.ToString();
            textBoxSumIndex.Text = SumIndex.ToString();
            textBoxCountInt.Text = CountIntegers.ToString();
        }
    }
}
