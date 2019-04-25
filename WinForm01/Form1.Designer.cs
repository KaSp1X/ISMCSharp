namespace WinForm01
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
            this.count = new System.Windows.Forms.Button();
            this.labelA = new System.Windows.Forms.Label();
            this.labelB = new System.Windows.Forms.Label();
            this.labelX = new System.Windows.Forms.Label();
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.Data = new System.Windows.Forms.Label();
            this.richTextBoxResult = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // count
            // 
            this.count.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.count.Location = new System.Drawing.Point(12, 201);
            this.count.Name = "count";
            this.count.Size = new System.Drawing.Size(252, 44);
            this.count.TabIndex = 0;
            this.count.Text = "Обчислить";
            this.count.UseVisualStyleBackColor = true;
            this.count.Click += new System.EventHandler(this.count_Click);
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelA.Location = new System.Drawing.Point(9, 65);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(28, 24);
            this.labelA.TabIndex = 1;
            this.labelA.Text = "А:";
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelB.Location = new System.Drawing.Point(10, 106);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(27, 24);
            this.labelB.TabIndex = 2;
            this.labelB.Text = "В:";
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelX.Location = new System.Drawing.Point(9, 152);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(27, 24);
            this.labelX.TabIndex = 3;
            this.labelX.Text = "Х:";
            // 
            // textBoxA
            // 
            this.textBoxA.Location = new System.Drawing.Point(50, 70);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(214, 20);
            this.textBoxA.TabIndex = 4;
            // 
            // textBoxB
            // 
            this.textBoxB.Location = new System.Drawing.Point(50, 111);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(214, 20);
            this.textBoxB.TabIndex = 5;
            // 
            // textBoxX
            // 
            this.textBoxX.Location = new System.Drawing.Point(50, 157);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.Size = new System.Drawing.Size(214, 20);
            this.textBoxX.TabIndex = 6;
            // 
            // Data
            // 
            this.Data.AutoSize = true;
            this.Data.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Data.Location = new System.Drawing.Point(53, 24);
            this.Data.Name = "Data";
            this.Data.Size = new System.Drawing.Size(161, 24);
            this.Data.TabIndex = 7;
            this.Data.Text = "Введите данные";
            // 
            // richTextBoxResult
            // 
            this.richTextBoxResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBoxResult.Location = new System.Drawing.Point(296, 24);
            this.richTextBoxResult.Name = "richTextBoxResult";
            this.richTextBoxResult.Size = new System.Drawing.Size(288, 221);
            this.richTextBoxResult.TabIndex = 8;
            this.richTextBoxResult.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(596, 257);
            this.Controls.Add(this.richTextBoxResult);
            this.Controls.Add(this.Data);
            this.Controls.Add(this.textBoxX);
            this.Controls.Add(this.textBoxB);
            this.Controls.Add(this.textBoxA);
            this.Controls.Add(this.labelX);
            this.Controls.Add(this.labelB);
            this.Controls.Add(this.labelA);
            this.Controls.Add(this.count);
            this.Name = "Form1";
            this.Text = "WinForm01";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button count;
        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.Label Data;
        private System.Windows.Forms.RichTextBox richTextBoxResult;
    }
}

