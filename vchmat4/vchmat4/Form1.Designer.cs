﻿namespace vchmat4
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox19 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox20 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(12, 12);
            this.chart1.Name = "chart1";
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(630, 476);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(649, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите количество аргументов:";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.GhostWhite;
            this.textBox1.Location = new System.Drawing.Point(652, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(47, 20);
            this.textBox1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(649, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Заполните таблицу:";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(648, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "x:";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(648, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "f (x):";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(705, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "Ввести";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.GhostWhite;
            this.textBox2.Location = new System.Drawing.Point(704, 85);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(50, 20);
            this.textBox2.TabIndex = 21;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.GhostWhite;
            this.textBox3.Location = new System.Drawing.Point(760, 85);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(50, 20);
            this.textBox3.TabIndex = 22;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.GhostWhite;
            this.textBox4.Location = new System.Drawing.Point(872, 85);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(50, 20);
            this.textBox4.TabIndex = 24;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.GhostWhite;
            this.textBox5.Location = new System.Drawing.Point(816, 85);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(50, 20);
            this.textBox5.TabIndex = 23;
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.GhostWhite;
            this.textBox6.Location = new System.Drawing.Point(984, 84);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(50, 20);
            this.textBox6.TabIndex = 26;
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.Color.GhostWhite;
            this.textBox7.Location = new System.Drawing.Point(928, 84);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(50, 20);
            this.textBox7.TabIndex = 25;
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.Color.GhostWhite;
            this.textBox8.Location = new System.Drawing.Point(1040, 85);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(50, 20);
            this.textBox8.TabIndex = 27;
            // 
            // textBox9
            // 
            this.textBox9.BackColor = System.Drawing.Color.GhostWhite;
            this.textBox9.Location = new System.Drawing.Point(1040, 106);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(50, 20);
            this.textBox9.TabIndex = 34;
            // 
            // textBox10
            // 
            this.textBox10.BackColor = System.Drawing.Color.GhostWhite;
            this.textBox10.Location = new System.Drawing.Point(984, 105);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(50, 20);
            this.textBox10.TabIndex = 33;
            // 
            // textBox11
            // 
            this.textBox11.BackColor = System.Drawing.Color.GhostWhite;
            this.textBox11.Location = new System.Drawing.Point(928, 105);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(50, 20);
            this.textBox11.TabIndex = 32;
            // 
            // textBox12
            // 
            this.textBox12.BackColor = System.Drawing.Color.GhostWhite;
            this.textBox12.Location = new System.Drawing.Point(872, 106);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(50, 20);
            this.textBox12.TabIndex = 31;
            // 
            // textBox13
            // 
            this.textBox13.BackColor = System.Drawing.Color.GhostWhite;
            this.textBox13.Location = new System.Drawing.Point(816, 106);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(50, 20);
            this.textBox13.TabIndex = 30;
            // 
            // textBox14
            // 
            this.textBox14.BackColor = System.Drawing.Color.GhostWhite;
            this.textBox14.Location = new System.Drawing.Point(760, 106);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(50, 20);
            this.textBox14.TabIndex = 29;
            // 
            // textBox15
            // 
            this.textBox15.BackColor = System.Drawing.Color.GhostWhite;
            this.textBox15.Location = new System.Drawing.Point(704, 106);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(50, 20);
            this.textBox15.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(649, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "Настройки масштаба:";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(652, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 21);
            this.label6.TabIndex = 36;
            this.label6.Text = "xMin:";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Location = new System.Drawing.Point(816, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 21);
            this.label7.TabIndex = 37;
            this.label7.Text = "yMin:";
            // 
            // textBox16
            // 
            this.textBox16.BackColor = System.Drawing.Color.GhostWhite;
            this.textBox16.Location = new System.Drawing.Point(708, 162);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(50, 20);
            this.textBox16.TabIndex = 38;
            // 
            // textBox17
            // 
            this.textBox17.BackColor = System.Drawing.Color.GhostWhite;
            this.textBox17.Location = new System.Drawing.Point(872, 163);
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(50, 20);
            this.textBox17.TabIndex = 39;
            // 
            // textBox18
            // 
            this.textBox18.BackColor = System.Drawing.Color.GhostWhite;
            this.textBox18.Location = new System.Drawing.Point(708, 182);
            this.textBox18.Name = "textBox18";
            this.textBox18.Size = new System.Drawing.Size(50, 20);
            this.textBox18.TabIndex = 41;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Location = new System.Drawing.Point(652, 182);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 21);
            this.label8.TabIndex = 40;
            this.label8.Text = "xMax:";
            // 
            // textBox19
            // 
            this.textBox19.BackColor = System.Drawing.Color.GhostWhite;
            this.textBox19.Location = new System.Drawing.Point(872, 183);
            this.textBox19.Name = "textBox19";
            this.textBox19.Size = new System.Drawing.Size(50, 20);
            this.textBox19.TabIndex = 43;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Location = new System.Drawing.Point(816, 183);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 21);
            this.label9.TabIndex = 42;
            this.label9.Text = "yMax:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(652, 218);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 39);
            this.button2.TabIndex = 44;
            this.button2.Text = "Построить первую производную";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(774, 218);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(116, 39);
            this.button3.TabIndex = 45;
            this.button3.Text = "Построить вторую производную";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox20
            // 
            this.textBox20.Location = new System.Drawing.Point(652, 263);
            this.textBox20.Multiline = true;
            this.textBox20.Name = "textBox20";
            this.textBox20.Size = new System.Drawing.Size(360, 225);
            this.textBox20.TabIndex = 46;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(896, 218);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(116, 39);
            this.button4.TabIndex = 47;
            this.button4.Text = "Построить кубический сплайн";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1114, 496);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBox20);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox19);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox18);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox17);
            this.Controls.Add(this.textBox16);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.textBox12);
            this.Controls.Add(this.textBox13);
            this.Controls.Add(this.textBox14);
            this.Controls.Add(this.textBox15);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.TextBox textBox17;
        private System.Windows.Forms.TextBox textBox18;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox19;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox20;
        private System.Windows.Forms.Button button4;
    }
}

