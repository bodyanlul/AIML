namespace AIML1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.A = new System.Windows.Forms.DataGridView();
            this.index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lower = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.upper = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.B = new System.Windows.Forms.DataGridView();
            this.indexB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lowerB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.upperB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.bigger = new System.Windows.Forms.Label();
            this.biggerorequals = new System.Windows.Forms.Label();
            this.less = new System.Windows.Forms.Label();
            this.lessorequals = new System.Windows.Forms.Label();
            this.equals = new System.Windows.Forms.Label();
            this.notequals = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.indexC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lowerC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.upperC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.A)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.B)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.C)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // A
            // 
            this.A.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.A.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.index,
            this.lower,
            this.upper});
            this.A.Location = new System.Drawing.Point(12, 38);
            this.A.Name = "A";
            this.A.Size = new System.Drawing.Size(193, 102);
            this.A.TabIndex = 0;
            // 
            // index
            // 
            this.index.HeaderText = "alpha lvl";
            this.index.Name = "index";
            this.index.Width = 50;
            // 
            // lower
            // 
            this.lower.HeaderText = "Нижняя";
            this.lower.Name = "lower";
            this.lower.Width = 50;
            // 
            // upper
            // 
            this.upper.HeaderText = "Верхняя";
            this.upper.Name = "upper";
            this.upper.Width = 50;
            // 
            // B
            // 
            this.B.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.B.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.indexB,
            this.lowerB,
            this.upperB});
            this.B.Location = new System.Drawing.Point(12, 159);
            this.B.Name = "B";
            this.B.Size = new System.Drawing.Size(193, 124);
            this.B.TabIndex = 1;
            // 
            // indexB
            // 
            this.indexB.HeaderText = "alpha lvl";
            this.indexB.Name = "indexB";
            this.indexB.Width = 50;
            // 
            // lowerB
            // 
            this.lowerB.HeaderText = "Нижняя";
            this.lowerB.Name = "lowerB";
            this.lowerB.Width = 50;
            // 
            // upperB
            // 
            this.upperB.HeaderText = "Верхняя";
            this.upperB.Name = "upperB";
            this.upperB.Width = 50;
            // 
            // C
            // 
            this.C.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.C.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.indexC,
            this.lowerC,
            this.upperC});
            this.C.Location = new System.Drawing.Point(12, 302);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(193, 124);
            this.C.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Множество А";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Множество В";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 286);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Множество С";
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(334, 22);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(655, 443);
            this.chart1.TabIndex = 6;
            this.chart1.Text = "chart1";
            // 
            // bigger
            // 
            this.bigger.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.bigger.Location = new System.Drawing.Point(228, 86);
            this.bigger.Name = "bigger";
            this.bigger.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bigger.Size = new System.Drawing.Size(35, 35);
            this.bigger.TabIndex = 7;
            this.bigger.Text = ">";
            this.bigger.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // biggerorequals
            // 
            this.biggerorequals.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.biggerorequals.Location = new System.Drawing.Point(280, 86);
            this.biggerorequals.Name = "biggerorequals";
            this.biggerorequals.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.biggerorequals.Size = new System.Drawing.Size(35, 35);
            this.biggerorequals.TabIndex = 8;
            this.biggerorequals.Text = ">=";
            this.biggerorequals.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // less
            // 
            this.less.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.less.Location = new System.Drawing.Point(228, 132);
            this.less.Name = "less";
            this.less.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.less.Size = new System.Drawing.Size(35, 35);
            this.less.TabIndex = 9;
            this.less.Text = "<";
            this.less.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lessorequals
            // 
            this.lessorequals.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lessorequals.Location = new System.Drawing.Point(280, 132);
            this.lessorequals.Name = "lessorequals";
            this.lessorequals.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lessorequals.Size = new System.Drawing.Size(35, 35);
            this.lessorequals.TabIndex = 10;
            this.lessorequals.Text = "<=";
            this.lessorequals.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // equals
            // 
            this.equals.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.equals.Location = new System.Drawing.Point(228, 177);
            this.equals.Name = "equals";
            this.equals.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.equals.Size = new System.Drawing.Size(35, 35);
            this.equals.TabIndex = 11;
            this.equals.Text = "=";
            this.equals.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // notequals
            // 
            this.notequals.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.notequals.Location = new System.Drawing.Point(279, 177);
            this.notequals.Name = "notequals";
            this.notequals.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.notequals.Size = new System.Drawing.Size(35, 35);
            this.notequals.TabIndex = 12;
            this.notequals.Text = "/=";
            this.notequals.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(228, 215);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 35);
            this.button1.TabIndex = 13;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(279, 215);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(35, 35);
            this.button2.TabIndex = 14;
            this.button2.Text = "-";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(228, 256);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(35, 35);
            this.button3.TabIndex = 15;
            this.button3.Text = "*";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(279, 256);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(35, 35);
            this.button4.TabIndex = 16;
            this.button4.Text = "/";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(229, 297);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(86, 23);
            this.button5.TabIndex = 17;
            this.button5.Text = "Построить А";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(228, 355);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(86, 23);
            this.button6.TabIndex = 18;
            this.button6.Text = "Построить С";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(228, 326);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(86, 23);
            this.button7.TabIndex = 19;
            this.button7.Text = "Построить В";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.Button7_Click);
            // 
            // indexC
            // 
            this.indexC.HeaderText = "alpha lvl";
            this.indexC.Name = "indexC";
            this.indexC.Width = 50;
            // 
            // lowerC
            // 
            this.lowerC.HeaderText = "Нижняя";
            this.lowerC.Name = "lowerC";
            this.lowerC.Width = 50;
            // 
            // upperC
            // 
            this.upperC.HeaderText = "Верхняя";
            this.upperC.Name = "upperC";
            this.upperC.Width = 50;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(231, 38);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(86, 23);
            this.button8.TabIndex = 20;
            this.button8.Text = "Сравнить";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.Button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(227, 413);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(86, 23);
            this.button9.TabIndex = 23;
            this.button9.Text = "Очистить В";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.Button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(227, 442);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(86, 23);
            this.button10.TabIndex = 22;
            this.button10.Text = "Очистить С";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.Button10_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(228, 384);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(86, 23);
            this.button11.TabIndex = 21;
            this.button11.Text = "Очистить А";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.Button11_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 483);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.notequals);
            this.Controls.Add(this.equals);
            this.Controls.Add(this.lessorequals);
            this.Controls.Add(this.less);
            this.Controls.Add(this.biggerorequals);
            this.Controls.Add(this.bigger);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.C);
            this.Controls.Add(this.B);
            this.Controls.Add(this.A);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.A)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.B)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.C)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView A;
        private System.Windows.Forms.DataGridViewTextBoxColumn index;
        private System.Windows.Forms.DataGridViewTextBoxColumn lower;
        private System.Windows.Forms.DataGridViewTextBoxColumn upper;
        private System.Windows.Forms.DataGridView B;
        private System.Windows.Forms.DataGridViewTextBoxColumn indexB;
        private System.Windows.Forms.DataGridViewTextBoxColumn lowerB;
        private System.Windows.Forms.DataGridViewTextBoxColumn upperB;
        private System.Windows.Forms.DataGridView C;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label bigger;
        private System.Windows.Forms.Label biggerorequals;
        private System.Windows.Forms.Label less;
        private System.Windows.Forms.Label lessorequals;
        private System.Windows.Forms.Label equals;
        private System.Windows.Forms.Label notequals;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.DataGridViewTextBoxColumn indexC;
        private System.Windows.Forms.DataGridViewTextBoxColumn lowerC;
        private System.Windows.Forms.DataGridViewTextBoxColumn upperC;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
    }
}

