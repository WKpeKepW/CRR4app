﻿namespace CRR4app
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.labelрHeader = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(82, 433);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Начальный столбец";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(82, 457);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(153, 23);
            this.textBox1.TabIndex = 1;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PassNumber);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(138, 511);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(209, 65);
            this.button1.TabIndex = 2;
            this.button1.Text = "Корректировать и сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(254, 457);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(153, 23);
            this.textBox2.TabIndex = 4;
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PassNumber);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(254, 433);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Конечный столбец";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(26, 81);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(47, 23);
            this.textBox3.TabIndex = 6;
            this.textBox3.Text = "10";
            this.textBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PassNumber);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(26, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 27);
            this.label3.TabIndex = 5;
            this.label3.Text = "Старой комиссии";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(340, 82);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(47, 23);
            this.textBox4.TabIndex = 8;
            this.textBox4.Text = "11";
            this.textBox4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PassNumber);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(340, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 22);
            this.label4.TabIndex = 7;
            this.label4.Text = "Новой комиссии";
            // 
            // labelрHeader
            // 
            this.labelрHeader.AutoSize = true;
            this.labelрHeader.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelрHeader.Location = new System.Drawing.Point(139, 10);
            this.labelрHeader.Name = "labelрHeader";
            this.labelрHeader.Size = new System.Drawing.Size(194, 30);
            this.labelрHeader.TabIndex = 9;
            this.labelрHeader.Text = "Номера столбцов";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(178, 82);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(47, 23);
            this.textBox5.TabIndex = 11;
            this.textBox5.Text = "9";
            this.textBox5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PassNumber);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(178, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 22);
            this.label5.TabIndex = 10;
            this.label5.Text = "Цены продавца";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(26, 129);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(47, 23);
            this.textBox6.TabIndex = 13;
            this.textBox6.Text = "12";
            this.textBox6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PassNumber);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(24, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 22);
            this.label6.TabIndex = 12;
            this.label6.Text = "Цены Реализации";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(177, 129);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(47, 23);
            this.textBox7.TabIndex = 15;
            this.textBox7.Text = "13";
            this.textBox7.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PassNumber);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(177, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(156, 22);
            this.label7.TabIndex = 14;
            this.label7.Text = "Количество продаж";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(340, 129);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(47, 23);
            this.textBox8.TabIndex = 17;
            this.textBox8.Text = "22";
            this.textBox8.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PassNumber);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(340, 107);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(156, 22);
            this.label8.TabIndex = 16;
            this.label8.Text = "Итого к выплате";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(27, 222);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(47, 23);
            this.textBox9.TabIndex = 19;
            this.textBox9.Text = "18";
            this.textBox9.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PassNumber);
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(24, 155);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(146, 64);
            this.label9.TabIndex = 18;
            this.label9.Text = "Старой рассчитанной комиссии";
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(177, 222);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(47, 23);
            this.textBox10.TabIndex = 21;
            this.textBox10.Text = "20";
            this.textBox10.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PassNumber);
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(176, 155);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(146, 64);
            this.label10.TabIndex = 20;
            this.label10.Text = "Новой рассчитанной комиссии";
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(27, 271);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(47, 23);
            this.textBox11.TabIndex = 23;
            this.textBox11.Text = "17";
            this.textBox11.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PassNumber);
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(24, 248);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(146, 29);
            this.label11.TabIndex = 22;
            this.label11.Text = "Доплата Ozon";
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(340, 222);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(47, 23);
            this.textBox12.TabIndex = 25;
            this.textBox12.Text = "23";
            this.textBox12.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PassNumber);
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(340, 155);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(120, 64);
            this.label12.TabIndex = 24;
            this.label12.Text = "Цена реализации возврата";
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(177, 271);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(47, 23);
            this.textBox13.TabIndex = 27;
            this.textBox13.Text = "28";
            this.textBox13.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PassNumber);
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(177, 248);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(146, 20);
            this.label13.TabIndex = 26;
            this.label13.Text = "Доплаты возврата";
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(340, 271);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(47, 23);
            this.textBox14.TabIndex = 29;
            this.textBox14.Text = "30";
            this.textBox14.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PassNumber);
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(340, 248);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(147, 29);
            this.label14.TabIndex = 28;
            this.label14.Text = "Комиссия возврата";
            // 
            // textBox15
            // 
            this.textBox15.Location = new System.Drawing.Point(176, 331);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(47, 23);
            this.textBox15.TabIndex = 31;
            this.textBox15.Text = "32";
            this.textBox15.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PassNumber);
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(176, 308);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(147, 29);
            this.label15.TabIndex = 32;
            this.label15.Text = "Итого возвращено";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(69, 518);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(65, 53);
            this.button2.TabIndex = 33;
            this.button2.Text = "Открыть отчёт";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 588);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox15);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.textBox14);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.textBox13);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.textBox12);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelрHeader);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Корректировка отчёта о реализации";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox4;
        private Label label4;
        private Label labelрHeader;
        private TextBox textBox5;
        private Label label5;
        private TextBox textBox6;
        private Label label6;
        private TextBox textBox7;
        private Label label7;
        private TextBox textBox8;
        private Label label8;
        private TextBox textBox9;
        private Label label9;
        private TextBox textBox10;
        private Label label10;
        private TextBox textBox11;
        private Label label11;
        private TextBox textBox12;
        private Label label12;
        private TextBox textBox13;
        private Label label13;
        private TextBox textBox14;
        private Label label14;
        private TextBox textBox15;
        private Label label15;
        private Button button2;
    }
}