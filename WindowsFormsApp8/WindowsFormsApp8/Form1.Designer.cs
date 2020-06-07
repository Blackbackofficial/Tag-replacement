namespace WindowsFormsApp8
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.richTextBox4 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 49);
            this.button1.TabIndex = 0;
            this.button1.Text = "Genesis";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 99);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 50);
            this.button2.TabIndex = 1;
            this.button2.Text = "WinCC";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1030, 22);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(122, 58);
            this.button3.TabIndex = 2;
            this.button3.Text = "Закрыть";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(823, 146);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(175, 45);
            this.button4.TabIndex = 3;
            this.button4.Text = "Замена тегов";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(1029, 97);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(130, 69);
            this.button5.TabIndex = 4;
            this.button5.Text = "Сохранить как";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 231);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(481, 260);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(12, 544);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(481, 393);
            this.richTextBox2.TabIndex = 6;
            this.richTextBox2.Text = "";
            // 
            // richTextBox3
            // 
            this.richTextBox3.AutoWordSelection = true;
            this.richTextBox3.Location = new System.Drawing.Point(527, 231);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(632, 706);
            this.richTextBox3.TabIndex = 7;
            this.richTextBox3.Text = "";
            // 
            // richTextBox4
            // 
            this.richTextBox4.Location = new System.Drawing.Point(397, 40);
            this.richTextBox4.Name = "richTextBox4";
            this.richTextBox4.Size = new System.Drawing.Size(618, 100);
            this.richTextBox4.TabIndex = 8;
            this.richTextBox4.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(699, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Замена тегов:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(253, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Отображение объектов Genesis";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 511);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(243, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Отображение объектов WinCC";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(580, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(239, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Отображение новых объектов";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 67);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(373, 26);
            this.textBox1.TabIndex = 13;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 155);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(373, 26);
            this.textBox2.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(490, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(238, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Какой тег на какой заменился";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(132, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(243, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Задание пути к файлу Genesis";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(132, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(233, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Задание пути к файлу WinCC";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 966);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox4);
            this.Controls.Add(this.richTextBox3);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.RichTextBox richTextBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

