
namespace NuteccUtility
{
    partial class frmnuteccutility
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnOpenTxt = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblmtc = new System.Windows.Forms.Label();
            this.lblpnn50 = new System.Windows.Forms.Label();
            this.lblsd1 = new System.Windows.Forms.Label();
            this.lblrmssd = new System.Windows.Forms.Label();
            this.lblsdnn = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SD1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SDNN = new System.Windows.Forms.Label();
            this.chartFC = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.lblGini = new System.Windows.Forms.Label();
            this.chartGini = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblentr10 = new System.Windows.Forms.Label();
            this.lblentr2 = new System.Windows.Forms.Label();
            this.lbl2v = new System.Windows.Forms.Label();
            this.lbl1v = new System.Windows.Forms.Label();
            this.lbl0v = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartGini)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOpenTxt
            // 
            this.btnOpenTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenTxt.Location = new System.Drawing.Point(26, 13);
            this.btnOpenTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOpenTxt.Name = "btnOpenTxt";
            this.btnOpenTxt.Size = new System.Drawing.Size(312, 55);
            this.btnOpenTxt.TabIndex = 0;
            this.btnOpenTxt.Text = "Open TXT";
            this.btnOpenTxt.UseVisualStyleBackColor = true;
            this.btnOpenTxt.Click += new System.EventHandler(this.btnOpenTxt_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(1723, 10);
            this.listBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(150, 84);
            this.listBox1.TabIndex = 1;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(1723, 186);
            this.listBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(150, 84);
            this.listBox2.TabIndex = 2;
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 16;
            this.listBox3.Location = new System.Drawing.Point(1723, 98);
            this.listBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(150, 84);
            this.listBox3.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblmtc);
            this.groupBox1.Controls.Add(this.lblpnn50);
            this.groupBox1.Controls.Add(this.lblsd1);
            this.groupBox1.Controls.Add(this.lblrmssd);
            this.groupBox1.Controls.Add(this.lblsdnn);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.SD1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.SDNN);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(18, 142);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(312, 222);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "VFC";
            // 
            // lblmtc
            // 
            this.lblmtc.AutoSize = true;
            this.lblmtc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmtc.Location = new System.Drawing.Point(111, 156);
            this.lblmtc.Name = "lblmtc";
            this.lblmtc.Size = new System.Drawing.Size(35, 24);
            this.lblmtc.TabIndex = 15;
            this.lblmtc.Text = ".....";
            // 
            // lblpnn50
            // 
            this.lblpnn50.AutoSize = true;
            this.lblpnn50.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpnn50.Location = new System.Drawing.Point(111, 126);
            this.lblpnn50.Name = "lblpnn50";
            this.lblpnn50.Size = new System.Drawing.Size(35, 24);
            this.lblpnn50.TabIndex = 14;
            this.lblpnn50.Text = ".....";
            // 
            // lblsd1
            // 
            this.lblsd1.AutoSize = true;
            this.lblsd1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsd1.Location = new System.Drawing.Point(111, 97);
            this.lblsd1.Name = "lblsd1";
            this.lblsd1.Size = new System.Drawing.Size(35, 24);
            this.lblsd1.TabIndex = 13;
            this.lblsd1.Text = ".....";
            // 
            // lblrmssd
            // 
            this.lblrmssd.AutoSize = true;
            this.lblrmssd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrmssd.Location = new System.Drawing.Point(111, 66);
            this.lblrmssd.Name = "lblrmssd";
            this.lblrmssd.Size = new System.Drawing.Size(35, 24);
            this.lblrmssd.TabIndex = 12;
            this.lblrmssd.Text = ".....";
            // 
            // lblsdnn
            // 
            this.lblsdnn.AutoSize = true;
            this.lblsdnn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsdnn.Location = new System.Drawing.Point(111, 36);
            this.lblsdnn.Name = "lblsdnn";
            this.lblsdnn.Size = new System.Drawing.Size(35, 24);
            this.lblsdnn.TabIndex = 11;
            this.lblsdnn.Text = ".....";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "MTC5";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "PNN50";
            // 
            // SD1
            // 
            this.SD1.AutoSize = true;
            this.SD1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SD1.Location = new System.Drawing.Point(6, 97);
            this.SD1.Name = "SD1";
            this.SD1.Size = new System.Drawing.Size(51, 25);
            this.SD1.TabIndex = 7;
            this.SD1.Text = "SD1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "rMSSD";
            // 
            // SDNN
            // 
            this.SDNN.AutoSize = true;
            this.SDNN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SDNN.Location = new System.Drawing.Point(6, 36);
            this.SDNN.Name = "SDNN";
            this.SDNN.Size = new System.Drawing.Size(68, 25);
            this.SDNN.TabIndex = 5;
            this.SDNN.Text = "SDNN";
            // 
            // chartFC
            // 
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisX2.MajorGrid.Enabled = false;
            chartArea1.AxisY.MajorGrid.Enabled = false;
            chartArea1.BorderColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chartFC.ChartAreas.Add(chartArea1);
            legend1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            legend1.HeaderSeparatorColor = System.Drawing.Color.Transparent;
            legend1.ItemColumnSeparatorColor = System.Drawing.Color.Transparent;
            legend1.Name = "Legend1";
            this.chartFC.Legends.Add(legend1);
            this.chartFC.Location = new System.Drawing.Point(350, 12);
            this.chartFC.Name = "chartFC";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.LabelForeColor = System.Drawing.Color.Transparent;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartFC.Series.Add(series1);
            this.chartFC.Size = new System.Drawing.Size(1336, 261);
            this.chartFC.TabIndex = 5;
            this.chartFC.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "G=";
            // 
            // lblGini
            // 
            this.lblGini.AutoSize = true;
            this.lblGini.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGini.Location = new System.Drawing.Point(63, 90);
            this.lblGini.Name = "lblGini";
            this.lblGini.Size = new System.Drawing.Size(47, 32);
            this.lblGini.TabIndex = 7;
            this.lblGini.Text = "....";
            // 
            // chartGini
            // 
            chartArea2.AxisX.MajorGrid.Enabled = false;
            chartArea2.AxisX2.MajorGrid.Enabled = false;
            chartArea2.AxisY.MajorGrid.Enabled = false;
            chartArea2.BorderColor = System.Drawing.Color.Transparent;
            chartArea2.Name = "ChartArea1";
            this.chartGini.ChartAreas.Add(chartArea2);
            legend2.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            legend2.HeaderSeparatorColor = System.Drawing.Color.Transparent;
            legend2.ItemColumnSeparatorColor = System.Drawing.Color.Transparent;
            legend2.Name = "Legend1";
            this.chartGini.Legends.Add(legend2);
            this.chartGini.Location = new System.Drawing.Point(716, 279);
            this.chartGini.Name = "chartGini";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.LabelForeColor = System.Drawing.Color.Transparent;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartGini.Series.Add(series2);
            this.chartGini.Size = new System.Drawing.Size(749, 469);
            this.chartGini.TabIndex = 8;
            this.chartGini.Text = "chart1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblentr10);
            this.groupBox2.Controls.Add(this.lblentr2);
            this.groupBox2.Controls.Add(this.lbl2v);
            this.groupBox2.Controls.Add(this.lbl1v);
            this.groupBox2.Controls.Add(this.lbl0v);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(18, 368);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(312, 222);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Simbólica";
            // 
            // lblentr10
            // 
            this.lblentr10.AutoSize = true;
            this.lblentr10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblentr10.Location = new System.Drawing.Point(111, 156);
            this.lblentr10.Name = "lblentr10";
            this.lblentr10.Size = new System.Drawing.Size(35, 24);
            this.lblentr10.TabIndex = 15;
            this.lblentr10.Text = ".....";
            // 
            // lblentr2
            // 
            this.lblentr2.AutoSize = true;
            this.lblentr2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblentr2.Location = new System.Drawing.Point(111, 126);
            this.lblentr2.Name = "lblentr2";
            this.lblentr2.Size = new System.Drawing.Size(35, 24);
            this.lblentr2.TabIndex = 14;
            this.lblentr2.Text = ".....";
            // 
            // lbl2v
            // 
            this.lbl2v.AutoSize = true;
            this.lbl2v.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2v.Location = new System.Drawing.Point(111, 97);
            this.lbl2v.Name = "lbl2v";
            this.lbl2v.Size = new System.Drawing.Size(35, 24);
            this.lbl2v.TabIndex = 13;
            this.lbl2v.Text = ".....";
            // 
            // lbl1v
            // 
            this.lbl1v.AutoSize = true;
            this.lbl1v.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1v.Location = new System.Drawing.Point(111, 66);
            this.lbl1v.Name = "lbl1v";
            this.lbl1v.Size = new System.Drawing.Size(35, 24);
            this.lbl1v.TabIndex = 12;
            this.lbl1v.Text = ".....";
            // 
            // lbl0v
            // 
            this.lbl0v.AutoSize = true;
            this.lbl0v.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl0v.Location = new System.Drawing.Point(111, 36);
            this.lbl0v.Name = "lbl0v";
            this.lbl0v.Size = new System.Drawing.Size(35, 24);
            this.lbl0v.TabIndex = 11;
            this.lbl0v.Text = ".....";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 156);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 25);
            this.label10.TabIndex = 9;
            this.label10.Text = "Entr10";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 126);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 25);
            this.label11.TabIndex = 8;
            this.label11.Text = "Entr2";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(6, 97);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 25);
            this.label12.TabIndex = 7;
            this.label12.Text = "2V";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(6, 66);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(37, 25);
            this.label13.TabIndex = 6;
            this.label13.Text = "1V";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(6, 36);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(37, 25);
            this.label14.TabIndex = 5;
            this.label14.Text = "0V";
            // 
            // frmnuteccutility
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1695, 762);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.chartGini);
            this.Controls.Add(this.lblGini);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chartFC);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnOpenTxt);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmnuteccutility";
            this.Text = "Nutecc Utility";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartGini)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpenTxt;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label SD1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label SDNN;
        private System.Windows.Forms.Label lblsdnn;
        private System.Windows.Forms.Label lblrmssd;
        private System.Windows.Forms.Label lblsd1;
        private System.Windows.Forms.Label lblpnn50;
        private System.Windows.Forms.Label lblmtc;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblGini;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGini;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblentr10;
        private System.Windows.Forms.Label lblentr2;
        private System.Windows.Forms.Label lbl2v;
        private System.Windows.Forms.Label lbl1v;
        private System.Windows.Forms.Label lbl0v;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
    }
}

