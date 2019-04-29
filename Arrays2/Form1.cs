using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arrays2
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
            if (!int.TryParse(textBoxNumberOfElements.Text, out N))
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
                check = double.TryParse(dataGridArray.Rows[0].Cells[i].Value.ToString(), out array[i]);
                if (!check)
                {
                    MessageBox.Show("Какая то ячейка пуста или содержит не число!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            int index_min = -1;
            double Min = double.MaxValue;
            double ProdAfterMin = 1;
            bool second_pos = false;
            int index_pos = -1;
            int index_neg = -1;
            double SumBetweenNegPos = 0;
            int index_first_zero = -1;
            int index_second_zero = -1;
            double SumBetweenZeros = 0;
            int index_min_abs = -1;
            int index_max_abs = -1;
            double MinAbs = double.MaxValue;
            double MaxAbs = double.MinValue;
            double ProdBetweenMinMaxAbs = 1;
            int temp_1, temp_2;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < Min) { Min = array[i]; index_min = i; }
                if (index_neg == -1 && array[i] < 0) index_neg = i;
                if (!second_pos && array[i] > 0) second_pos=true;
                else
                if (second_pos && index_pos == -1 && array[i] > 0) index_pos = i;
                if (index_first_zero == -1 && array[i] == 0) index_first_zero = i;
                else
                if (index_first_zero != -1 && index_second_zero == -1 && array[i] == 0) index_second_zero = i;
                if (Math.Abs(array[i]) < MinAbs) { MinAbs = Math.Abs(array[i]); index_min_abs = i; }
                if (Math.Abs(array[i]) > MaxAbs) { MaxAbs = Math.Abs(array[i]); index_max_abs = i; }
                }
            if (index_min == array.Length - 1)
            {
                textBoxProdAfterMin.Text = "Минимальный элемент массива есть последним!";
            }
            else
            {
                for (int i = index_min + 1; i < array.Length; i++)
                {
                    ProdAfterMin *= array[i];
                }
                textBoxProdAfterMin.Text = Math.Round(ProdAfterMin,3).ToString();
            }

            if (index_pos == -1 && index_neg == -1)
            {
                textBoxSumBetweenNegPos.Text = "Отрицательный и второй позитивный элементы не найдены!";
            }
            else
            if (index_neg == -1)
            {
                textBoxSumBetweenNegPos.Text = "Отрицательный элемент не найден!";
            }
            else
            if (index_pos == -1)
            {
                textBoxSumBetweenNegPos.Text = "Положительный элемент не найден!";
            }
            else
            {
                if (index_pos > index_neg) { temp_1 = index_neg; temp_2 = index_pos; }
                else { temp_1 = index_pos; temp_2 = index_neg; }
                for (int i = temp_1 + 1; i < temp_2; i++)
                {
                    SumBetweenNegPos += array[i];
                }
                textBoxSumBetweenNegPos.Text = Math.Round(SumBetweenNegPos,3).ToString();
            }

            if (index_first_zero==-1)
            {
                textBoxSumBetweenZeros.Text = "Нули не найдены!";
            }
            else
            if (index_second_zero==-1)
            {
                textBoxSumBetweenZeros.Text = "Второй нуль не найден!";
            }
            else
            {
                for (int i = index_first_zero+1; i < index_second_zero; i++)
                {
                    SumBetweenZeros += array[i];
                }
                textBoxSumBetweenZeros.Text = Math.Round(SumBetweenZeros,3).ToString();
            }

            if (index_min_abs + 1 == index_max_abs || index_min_abs == index_max_abs + 1)
            {
                textBoxProdBetweenMaxMinAbs.Text = "Мин и Макс по модулю стоят рядом в массиве!";
            }
            else
            {
                if (index_min_abs > index_max_abs) { temp_1 = index_max_abs; temp_2 = index_min_abs; }
                else { temp_1 = index_min_abs; temp_2 = index_max_abs; }
                for(int i = temp_1 + 1; i < temp_2; i++)
                {
                    ProdBetweenMinMaxAbs *= array[i];
                }
                textBoxProdBetweenMaxMinAbs.Text = Math.Round(ProdBetweenMinMaxAbs,3).ToString();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
