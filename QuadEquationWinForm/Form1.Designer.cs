namespace QuadEquationWinForm
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
            this.Data = new System.Windows.Forms.Label();
            this.textBoxC = new System.Windows.Forms.TextBox();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.labelC = new System.Windows.Forms.Label();
            this.labelB = new System.Windows.Forms.Label();
            this.labelA = new System.Windows.Forms.Label();
            this.count = new System.Windows.Forms.Button();
            this.labelD = new System.Windows.Forms.Label();
            this.textBoxD = new System.Windows.Forms.TextBox();
            this.Results = new System.Windows.Forms.Label();
            this.textBoxX1 = new System.Windows.Forms.TextBox();
            this.textBoxX2 = new System.Windows.Forms.TextBox();
            this.labelX1 = new System.Windows.Forms.Label();
            this.labelX2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Data
            // 
            this.Data.AutoSize = true;
            this.Data.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Data.Location = new System.Drawing.Point(55, 9);
            this.Data.Name = "Data";
            this.Data.Size = new System.Drawing.Size(161, 24);
            this.Data.TabIndex = 15;
            this.Data.Text = "Введите данные";
            // 
            // textBoxC
            // 
            this.textBoxC.Location = new System.Drawing.Point(52, 142);
            this.textBoxC.Name = "textBoxC";
            this.textBoxC.Size = new System.Drawing.Size(214, 20);
            this.textBoxC.TabIndex = 14;
            // 
            // textBoxB
            // 
            this.textBoxB.Location = new System.Drawing.Point(52, 96);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(214, 20);
            this.textBoxB.TabIndex = 13;
            // 
            // textBoxA
            // 
            this.textBoxA.Location = new System.Drawing.Point(52, 55);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(214, 20);
            this.textBoxA.TabIndex = 12;
            // 
            // labelC
            // 
            this.labelC.AutoSize = true;
            this.labelC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelC.Location = new System.Drawing.Point(11, 137);
            this.labelC.Name = "labelC";
            this.labelC.Size = new System.Drawing.Size(28, 24);
            this.labelC.TabIndex = 11;
            this.labelC.Text = "С:";
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelB.Location = new System.Drawing.Point(12, 91);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(27, 24);
            this.labelB.TabIndex = 10;
            this.labelB.Text = "В:";
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelA.Location = new System.Drawing.Point(11, 50);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(28, 24);
            this.labelA.TabIndex = 9;
            this.labelA.Text = "А:";
            // 
            // count
            // 
            this.count.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.count.Location = new System.Drawing.Point(14, 186);
            this.count.Name = "count";
            this.count.Size = new System.Drawing.Size(252, 44);
            this.count.TabIndex = 8;
            this.count.Text = "Обчислить";
            this.count.UseVisualStyleBackColor = true;
            this.count.Click += new System.EventHandler(this.count_Click);
            // 
            // labelD
            // 
            this.labelD.AutoSize = true;
            this.labelD.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelD.Location = new System.Drawing.Point(358, 9);
            this.labelD.Name = "labelD";
            this.labelD.Size = new System.Drawing.Size(142, 24);
            this.labelD.TabIndex = 16;
            this.labelD.Text = "Дискриминант";
            // 
            // textBoxD
            // 
            this.textBoxD.Enabled = false;
            this.textBoxD.Location = new System.Drawing.Point(319, 50);
            this.textBoxD.Name = "textBoxD";
            this.textBoxD.Size = new System.Drawing.Size(214, 20);
            this.textBoxD.TabIndex = 17;
            // 
            // Results
            // 
            this.Results.AutoSize = true;
            this.Results.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Results.Location = new System.Drawing.Point(337, 91);
            this.Results.Name = "Results";
            this.Results.Size = new System.Drawing.Size(177, 24);
            this.Results.TabIndex = 18;
            this.Results.Text = "Корень уравнения";
            // 
            // textBoxX1
            // 
            this.textBoxX1.Enabled = false;
            this.textBoxX1.Location = new System.Drawing.Point(336, 142);
            this.textBoxX1.Name = "textBoxX1";
            this.textBoxX1.Size = new System.Drawing.Size(214, 20);
            this.textBoxX1.TabIndex = 22;
            // 
            // textBoxX2
            // 
            this.textBoxX2.Enabled = false;
            this.textBoxX2.Location = new System.Drawing.Point(336, 188);
            this.textBoxX2.Name = "textBoxX2";
            this.textBoxX2.Size = new System.Drawing.Size(214, 20);
            this.textBoxX2.TabIndex = 21;
            // 
            // labelX1
            // 
            this.labelX1.AutoSize = true;
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelX1.Location = new System.Drawing.Point(291, 137);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(39, 24);
            this.labelX1.TabIndex = 20;
            this.labelX1.Text = "X1:";
            // 
            // labelX2
            // 
            this.labelX2.AutoSize = true;
            this.labelX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelX2.Location = new System.Drawing.Point(291, 183);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(39, 24);
            this.labelX2.TabIndex = 19;
            this.labelX2.Text = "X2:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(575, 239);
            this.Controls.Add(this.textBoxX1);
            this.Controls.Add(this.textBoxX2);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.Results);
            this.Controls.Add(this.textBoxD);
            this.Controls.Add(this.labelD);
            this.Controls.Add(this.Data);
            this.Controls.Add(this.textBoxC);
            this.Controls.Add(this.textBoxB);
            this.Controls.Add(this.textBoxA);
            this.Controls.Add(this.labelC);
            this.Controls.Add(this.labelB);
            this.Controls.Add(this.labelA);
            this.Controls.Add(this.count);
            this.Name = "Form1";
            this.Text = "QuadEquationWinForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Data;
        private System.Windows.Forms.TextBox textBoxC;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.Label labelC;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.Button count;
        private System.Windows.Forms.Label labelD;
        private System.Windows.Forms.TextBox textBoxD;
        private System.Windows.Forms.Label Results;
        private System.Windows.Forms.TextBox textBoxX1;
        private System.Windows.Forms.TextBox textBoxX2;
        private System.Windows.Forms.Label labelX1;
        private System.Windows.Forms.Label labelX2;
    }
}

