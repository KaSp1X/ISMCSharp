namespace Arrays2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridArray = new System.Windows.Forms.DataGridView();
            this.textBoxNumberOfElements = new System.Windows.Forms.TextBox();
            this.labelNumberOfElements = new System.Windows.Forms.Label();
            this.buttonCount = new System.Windows.Forms.Button();
            this.buttonRandom = new System.Windows.Forms.Button();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.labelProdAfterMin = new System.Windows.Forms.Label();
            this.textBoxProdAfterMin = new System.Windows.Forms.TextBox();
            this.labelSumBetweenNegPos = new System.Windows.Forms.Label();
            this.textBoxSumBetweenNegPos = new System.Windows.Forms.TextBox();
            this.labelSumBetweenZeros = new System.Windows.Forms.Label();
            this.textBoxSumBetweenZeros = new System.Windows.Forms.TextBox();
            this.labelProdBetweenMaxMinAbs = new System.Windows.Forms.Label();
            this.textBoxProdBetweenMaxMinAbs = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridArray)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridArray
            // 
            this.dataGridArray.AllowUserToAddRows = false;
            this.dataGridArray.AllowUserToDeleteRows = false;
            this.dataGridArray.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridArray.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridArray.Location = new System.Drawing.Point(23, 148);
            this.dataGridArray.Name = "dataGridArray";
            this.dataGridArray.Size = new System.Drawing.Size(516, 118);
            this.dataGridArray.TabIndex = 11;
            // 
            // textBoxNumberOfElements
            // 
            this.textBoxNumberOfElements.Location = new System.Drawing.Point(325, 21);
            this.textBoxNumberOfElements.Name = "textBoxNumberOfElements";
            this.textBoxNumberOfElements.Size = new System.Drawing.Size(225, 29);
            this.textBoxNumberOfElements.TabIndex = 7;
            // 
            // labelNumberOfElements
            // 
            this.labelNumberOfElements.AutoSize = true;
            this.labelNumberOfElements.Location = new System.Drawing.Point(11, 24);
            this.labelNumberOfElements.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelNumberOfElements.Name = "labelNumberOfElements";
            this.labelNumberOfElements.Size = new System.Drawing.Size(305, 24);
            this.labelNumberOfElements.TabIndex = 6;
            this.labelNumberOfElements.Text = "Количество элементов массива:";
            // 
            // buttonCount
            // 
            this.buttonCount.Enabled = false;
            this.buttonCount.Location = new System.Drawing.Point(371, 67);
            this.buttonCount.Name = "buttonCount";
            this.buttonCount.Size = new System.Drawing.Size(168, 58);
            this.buttonCount.TabIndex = 10;
            this.buttonCount.Text = "Обчислить";
            this.buttonCount.UseVisualStyleBackColor = true;
            this.buttonCount.Click += new System.EventHandler(this.buttonCount_Click);
            // 
            // buttonRandom
            // 
            this.buttonRandom.Enabled = false;
            this.buttonRandom.Location = new System.Drawing.Point(197, 67);
            this.buttonRandom.Name = "buttonRandom";
            this.buttonRandom.Size = new System.Drawing.Size(168, 58);
            this.buttonRandom.TabIndex = 9;
            this.buttonRandom.Text = "Рандомное заполнение";
            this.buttonRandom.UseVisualStyleBackColor = true;
            this.buttonRandom.Click += new System.EventHandler(this.buttonRandom_Click);
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(23, 67);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(168, 58);
            this.buttonCreate.TabIndex = 8;
            this.buttonCreate.Text = "Создать массив";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // labelProdAfterMin
            // 
            this.labelProdAfterMin.Location = new System.Drawing.Point(19, 279);
            this.labelProdAfterMin.Name = "labelProdAfterMin";
            this.labelProdAfterMin.Size = new System.Drawing.Size(520, 50);
            this.labelProdAfterMin.TabIndex = 6;
            this.labelProdAfterMin.Text = "Произведение элементов массива,что расположены после минимального элемента";
            // 
            // textBoxProdAfterMin
            // 
            this.textBoxProdAfterMin.Enabled = false;
            this.textBoxProdAfterMin.Location = new System.Drawing.Point(23, 330);
            this.textBoxProdAfterMin.Name = "textBoxProdAfterMin";
            this.textBoxProdAfterMin.Size = new System.Drawing.Size(516, 29);
            this.textBoxProdAfterMin.TabIndex = 7;
            // 
            // labelSumBetweenNegPos
            // 
            this.labelSumBetweenNegPos.Location = new System.Drawing.Point(19, 360);
            this.labelSumBetweenNegPos.Name = "labelSumBetweenNegPos";
            this.labelSumBetweenNegPos.Size = new System.Drawing.Size(520, 81);
            this.labelSumBetweenNegPos.TabIndex = 6;
            this.labelSumBetweenNegPos.Text = "Сума элементов массива, что расположены между первым отрицательным и вторым полож" +
    "ительным элементами";
            // 
            // textBoxSumBetweenNegPos
            // 
            this.textBoxSumBetweenNegPos.Enabled = false;
            this.textBoxSumBetweenNegPos.Location = new System.Drawing.Point(23, 442);
            this.textBoxSumBetweenNegPos.Name = "textBoxSumBetweenNegPos";
            this.textBoxSumBetweenNegPos.Size = new System.Drawing.Size(516, 29);
            this.textBoxSumBetweenNegPos.TabIndex = 7;
            // 
            // labelSumBetweenZeros
            // 
            this.labelSumBetweenZeros.Location = new System.Drawing.Point(19, 472);
            this.labelSumBetweenZeros.Name = "labelSumBetweenZeros";
            this.labelSumBetweenZeros.Size = new System.Drawing.Size(515, 55);
            this.labelSumBetweenZeros.TabIndex = 6;
            this.labelSumBetweenZeros.Text = "Сума элементов массива, которые расположены между первым и последним нулевым элем" +
    "ентами";
            // 
            // textBoxSumBetweenZeros
            // 
            this.textBoxSumBetweenZeros.Enabled = false;
            this.textBoxSumBetweenZeros.Location = new System.Drawing.Point(23, 528);
            this.textBoxSumBetweenZeros.Name = "textBoxSumBetweenZeros";
            this.textBoxSumBetweenZeros.Size = new System.Drawing.Size(516, 29);
            this.textBoxSumBetweenZeros.TabIndex = 7;
            // 
            // labelProdBetweenMaxMinAbs
            // 
            this.labelProdBetweenMaxMinAbs.Location = new System.Drawing.Point(19, 558);
            this.labelProdBetweenMaxMinAbs.Name = "labelProdBetweenMaxMinAbs";
            this.labelProdBetweenMaxMinAbs.Size = new System.Drawing.Size(520, 73);
            this.labelProdBetweenMaxMinAbs.TabIndex = 6;
            this.labelProdBetweenMaxMinAbs.Text = "Произведение элементов массива, которые расположены между максимальным по модулю " +
    "и минимальным по модулю элементом";
            // 
            // textBoxProdBetweenMaxMinAbs
            // 
            this.textBoxProdBetweenMaxMinAbs.Enabled = false;
            this.textBoxProdBetweenMaxMinAbs.Location = new System.Drawing.Point(23, 632);
            this.textBoxProdBetweenMaxMinAbs.Name = "textBoxProdBetweenMaxMinAbs";
            this.textBoxProdBetweenMaxMinAbs.Size = new System.Drawing.Size(516, 29);
            this.textBoxProdBetweenMaxMinAbs.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(560, 683);
            this.Controls.Add(this.dataGridArray);
            this.Controls.Add(this.textBoxNumberOfElements);
            this.Controls.Add(this.labelNumberOfElements);
            this.Controls.Add(this.buttonCount);
            this.Controls.Add(this.textBoxProdBetweenMaxMinAbs);
            this.Controls.Add(this.buttonRandom);
            this.Controls.Add(this.labelProdBetweenMaxMinAbs);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.textBoxSumBetweenZeros);
            this.Controls.Add(this.labelProdAfterMin);
            this.Controls.Add(this.labelSumBetweenZeros);
            this.Controls.Add(this.textBoxProdAfterMin);
            this.Controls.Add(this.textBoxSumBetweenNegPos);
            this.Controls.Add(this.labelSumBetweenNegPos);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MinimumSize = new System.Drawing.Size(576, 722);
            this.Name = "Form1";
            this.Text = "Arrays2";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridArray)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridArray;
        private System.Windows.Forms.TextBox textBoxNumberOfElements;
        private System.Windows.Forms.Label labelNumberOfElements;
        private System.Windows.Forms.Button buttonCount;
        private System.Windows.Forms.Button buttonRandom;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Label labelProdAfterMin;
        private System.Windows.Forms.TextBox textBoxProdAfterMin;
        private System.Windows.Forms.Label labelSumBetweenNegPos;
        private System.Windows.Forms.TextBox textBoxSumBetweenNegPos;
        private System.Windows.Forms.Label labelSumBetweenZeros;
        private System.Windows.Forms.TextBox textBoxSumBetweenZeros;
        private System.Windows.Forms.Label labelProdBetweenMaxMinAbs;
        private System.Windows.Forms.TextBox textBoxProdBetweenMaxMinAbs;
    }
}

