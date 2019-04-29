namespace Arrays1
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
            this.labelNumberOfElements = new System.Windows.Forms.Label();
            this.textBoxNumberOfElements = new System.Windows.Forms.TextBox();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.buttonRandom = new System.Windows.Forms.Button();
            this.buttonCount = new System.Windows.Forms.Button();
            this.dataGridArray = new System.Windows.Forms.DataGridView();
            this.labelSumNeg = new System.Windows.Forms.Label();
            this.textBoxSumNeg = new System.Windows.Forms.TextBox();
            this.labelMaxElement = new System.Windows.Forms.Label();
            this.textBoxMaxElement = new System.Windows.Forms.TextBox();
            this.labelIndexMax = new System.Windows.Forms.Label();
            this.textBoxIndexMax = new System.Windows.Forms.TextBox();
            this.labelMaxAbsElement = new System.Windows.Forms.Label();
            this.textBoxMaxAbsElement = new System.Windows.Forms.TextBox();
            this.labelSumIndex = new System.Windows.Forms.Label();
            this.textBoxSumIndex = new System.Windows.Forms.TextBox();
            this.labelCountInt = new System.Windows.Forms.Label();
            this.textBoxCountInt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridArray)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNumberOfElements
            // 
            this.labelNumberOfElements.AutoSize = true;
            this.labelNumberOfElements.Location = new System.Drawing.Point(8, 21);
            this.labelNumberOfElements.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelNumberOfElements.Name = "labelNumberOfElements";
            this.labelNumberOfElements.Size = new System.Drawing.Size(305, 24);
            this.labelNumberOfElements.TabIndex = 0;
            this.labelNumberOfElements.Text = "Количество элементов массива:";
            // 
            // textBoxNumberOfElements
            // 
            this.textBoxNumberOfElements.Location = new System.Drawing.Point(322, 18);
            this.textBoxNumberOfElements.Name = "textBoxNumberOfElements";
            this.textBoxNumberOfElements.Size = new System.Drawing.Size(225, 29);
            this.textBoxNumberOfElements.TabIndex = 1;
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(20, 64);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(168, 58);
            this.buttonCreate.TabIndex = 2;
            this.buttonCreate.Text = "Создать массив";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // buttonRandom
            // 
            this.buttonRandom.Enabled = false;
            this.buttonRandom.Location = new System.Drawing.Point(194, 64);
            this.buttonRandom.Name = "buttonRandom";
            this.buttonRandom.Size = new System.Drawing.Size(168, 58);
            this.buttonRandom.TabIndex = 3;
            this.buttonRandom.Text = "Рандомное заполнение";
            this.buttonRandom.UseVisualStyleBackColor = true;
            this.buttonRandom.Click += new System.EventHandler(this.buttonRandom_Click);
            // 
            // buttonCount
            // 
            this.buttonCount.Enabled = false;
            this.buttonCount.Location = new System.Drawing.Point(368, 64);
            this.buttonCount.Name = "buttonCount";
            this.buttonCount.Size = new System.Drawing.Size(168, 58);
            this.buttonCount.TabIndex = 4;
            this.buttonCount.Text = "Обчислить";
            this.buttonCount.UseVisualStyleBackColor = true;
            this.buttonCount.Click += new System.EventHandler(this.buttonCount_Click);
            // 
            // dataGridArray
            // 
            this.dataGridArray.AllowUserToAddRows = false;
            this.dataGridArray.AllowUserToDeleteRows = false;
            this.dataGridArray.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridArray.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridArray.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dataGridArray.Location = new System.Drawing.Point(20, 145);
            this.dataGridArray.Name = "dataGridArray";
            this.dataGridArray.Size = new System.Drawing.Size(516, 118);
            this.dataGridArray.TabIndex = 5;
            // 
            // labelSumNeg
            // 
            this.labelSumNeg.AutoSize = true;
            this.labelSumNeg.Location = new System.Drawing.Point(16, 276);
            this.labelSumNeg.Name = "labelSumNeg";
            this.labelSumNeg.Size = new System.Drawing.Size(383, 24);
            this.labelSumNeg.TabIndex = 6;
            this.labelSumNeg.Text = "Сума отрицательных элементов массива";
            // 
            // textBoxSumNeg
            // 
            this.textBoxSumNeg.Enabled = false;
            this.textBoxSumNeg.Location = new System.Drawing.Point(20, 303);
            this.textBoxSumNeg.Name = "textBoxSumNeg";
            this.textBoxSumNeg.Size = new System.Drawing.Size(516, 29);
            this.textBoxSumNeg.TabIndex = 7;
            // 
            // labelMaxElement
            // 
            this.labelMaxElement.AutoSize = true;
            this.labelMaxElement.Location = new System.Drawing.Point(16, 335);
            this.labelMaxElement.Name = "labelMaxElement";
            this.labelMaxElement.Size = new System.Drawing.Size(306, 24);
            this.labelMaxElement.TabIndex = 6;
            this.labelMaxElement.Text = "Максимальный элемент массива";
            // 
            // textBoxMaxElement
            // 
            this.textBoxMaxElement.Enabled = false;
            this.textBoxMaxElement.Location = new System.Drawing.Point(20, 362);
            this.textBoxMaxElement.Name = "textBoxMaxElement";
            this.textBoxMaxElement.Size = new System.Drawing.Size(302, 29);
            this.textBoxMaxElement.TabIndex = 7;
            // 
            // labelIndexMax
            // 
            this.labelIndexMax.AutoSize = true;
            this.labelIndexMax.Location = new System.Drawing.Point(344, 335);
            this.labelIndexMax.Name = "labelIndexMax";
            this.labelIndexMax.Size = new System.Drawing.Size(167, 24);
            this.labelIndexMax.TabIndex = 6;
            this.labelIndexMax.Text = "Индекс элемента";
            // 
            // textBoxIndexMax
            // 
            this.textBoxIndexMax.Enabled = false;
            this.textBoxIndexMax.Location = new System.Drawing.Point(348, 362);
            this.textBoxIndexMax.Name = "textBoxIndexMax";
            this.textBoxIndexMax.Size = new System.Drawing.Size(188, 29);
            this.textBoxIndexMax.TabIndex = 7;
            // 
            // labelMaxAbsElement
            // 
            this.labelMaxAbsElement.AutoSize = true;
            this.labelMaxAbsElement.Location = new System.Drawing.Point(16, 394);
            this.labelMaxAbsElement.Name = "labelMaxAbsElement";
            this.labelMaxAbsElement.Size = new System.Drawing.Size(415, 24);
            this.labelMaxAbsElement.TabIndex = 6;
            this.labelMaxAbsElement.Text = "Максимальный за модулем элемент массива";
            // 
            // textBoxMaxAbsElement
            // 
            this.textBoxMaxAbsElement.Enabled = false;
            this.textBoxMaxAbsElement.Location = new System.Drawing.Point(20, 421);
            this.textBoxMaxAbsElement.Name = "textBoxMaxAbsElement";
            this.textBoxMaxAbsElement.Size = new System.Drawing.Size(516, 29);
            this.textBoxMaxAbsElement.TabIndex = 7;
            // 
            // labelSumIndex
            // 
            this.labelSumIndex.AutoSize = true;
            this.labelSumIndex.Location = new System.Drawing.Point(16, 453);
            this.labelSumIndex.Name = "labelSumIndex";
            this.labelSumIndex.Size = new System.Drawing.Size(478, 24);
            this.labelSumIndex.TabIndex = 6;
            this.labelSumIndex.Text = "Сума индексов положительных элементов массива";
            // 
            // textBoxSumIndex
            // 
            this.textBoxSumIndex.Enabled = false;
            this.textBoxSumIndex.Location = new System.Drawing.Point(20, 480);
            this.textBoxSumIndex.Name = "textBoxSumIndex";
            this.textBoxSumIndex.Size = new System.Drawing.Size(516, 29);
            this.textBoxSumIndex.TabIndex = 7;
            // 
            // labelCountInt
            // 
            this.labelCountInt.AutoSize = true;
            this.labelCountInt.Location = new System.Drawing.Point(16, 512);
            this.labelCountInt.Name = "labelCountInt";
            this.labelCountInt.Size = new System.Drawing.Size(331, 24);
            this.labelCountInt.TabIndex = 6;
            this.labelCountInt.Text = "Количество целых чисел в массиве";
            // 
            // textBoxCountInt
            // 
            this.textBoxCountInt.Enabled = false;
            this.textBoxCountInt.Location = new System.Drawing.Point(20, 539);
            this.textBoxCountInt.Name = "textBoxCountInt";
            this.textBoxCountInt.Size = new System.Drawing.Size(516, 29);
            this.textBoxCountInt.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(559, 601);
            this.Controls.Add(this.textBoxCountInt);
            this.Controls.Add(this.labelCountInt);
            this.Controls.Add(this.textBoxSumIndex);
            this.Controls.Add(this.labelSumIndex);
            this.Controls.Add(this.textBoxMaxAbsElement);
            this.Controls.Add(this.labelMaxAbsElement);
            this.Controls.Add(this.textBoxIndexMax);
            this.Controls.Add(this.labelIndexMax);
            this.Controls.Add(this.textBoxMaxElement);
            this.Controls.Add(this.labelMaxElement);
            this.Controls.Add(this.textBoxSumNeg);
            this.Controls.Add(this.labelSumNeg);
            this.Controls.Add(this.dataGridArray);
            this.Controls.Add(this.textBoxNumberOfElements);
            this.Controls.Add(this.labelNumberOfElements);
            this.Controls.Add(this.buttonCount);
            this.Controls.Add(this.buttonRandom);
            this.Controls.Add(this.buttonCreate);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MinimumSize = new System.Drawing.Size(575, 640);
            this.Name = "Form1";
            this.Text = "Arrays1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridArray)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNumberOfElements;
        private System.Windows.Forms.TextBox textBoxNumberOfElements;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Button buttonRandom;
        private System.Windows.Forms.Button buttonCount;
        private System.Windows.Forms.DataGridView dataGridArray;
        private System.Windows.Forms.Label labelSumNeg;
        private System.Windows.Forms.TextBox textBoxSumNeg;
        private System.Windows.Forms.Label labelMaxElement;
        private System.Windows.Forms.TextBox textBoxMaxElement;
        private System.Windows.Forms.Label labelIndexMax;
        private System.Windows.Forms.TextBox textBoxIndexMax;
        private System.Windows.Forms.Label labelMaxAbsElement;
        private System.Windows.Forms.TextBox textBoxMaxAbsElement;
        private System.Windows.Forms.Label labelSumIndex;
        private System.Windows.Forms.TextBox textBoxSumIndex;
        private System.Windows.Forms.Label labelCountInt;
        private System.Windows.Forms.TextBox textBoxCountInt;
    }
}

