
namespace Lab9
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.prob1 = new System.Windows.Forms.NumericUpDown();
            this.prob2 = new System.Windows.Forms.NumericUpDown();
            this.prob3 = new System.Windows.Forms.NumericUpDown();
            this.prob4 = new System.Windows.Forms.NumericUpDown();
            this.prob5 = new System.Windows.Forms.NumericUpDown();
            this.daysNumeric = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.averageLabel = new System.Windows.Forms.Label();
            this.varietyLabel = new System.Windows.Forms.Label();
            this.xiLabel = new System.Windows.Forms.Label();
            this.averageError = new System.Windows.Forms.Label();
            this.varienceError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prob1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prob2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prob3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prob4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prob5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.daysNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(15, 15);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(491, 319);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // prob1
            // 
            this.prob1.DecimalPlaces = 4;
            this.prob1.Location = new System.Drawing.Point(629, 66);
            this.prob1.Name = "prob1";
            this.prob1.Size = new System.Drawing.Size(106, 22);
            this.prob1.TabIndex = 1;
            this.prob1.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // prob2
            // 
            this.prob2.DecimalPlaces = 4;
            this.prob2.Location = new System.Drawing.Point(629, 108);
            this.prob2.Name = "prob2";
            this.prob2.Size = new System.Drawing.Size(106, 22);
            this.prob2.TabIndex = 2;
            this.prob2.Value = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            // 
            // prob3
            // 
            this.prob3.DecimalPlaces = 4;
            this.prob3.Location = new System.Drawing.Point(629, 162);
            this.prob3.Name = "prob3";
            this.prob3.Size = new System.Drawing.Size(106, 22);
            this.prob3.TabIndex = 3;
            this.prob3.Value = new decimal(new int[] {
            3,
            0,
            0,
            65536});
            // 
            // prob4
            // 
            this.prob4.DecimalPlaces = 4;
            this.prob4.Location = new System.Drawing.Point(629, 216);
            this.prob4.Name = "prob4";
            this.prob4.Size = new System.Drawing.Size(106, 22);
            this.prob4.TabIndex = 4;
            this.prob4.Value = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            // 
            // prob5
            // 
            this.prob5.DecimalPlaces = 4;
            this.prob5.Location = new System.Drawing.Point(629, 271);
            this.prob5.Name = "prob5";
            this.prob5.Size = new System.Drawing.Size(106, 22);
            this.prob5.TabIndex = 5;
            this.prob5.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // daysNumeric
            // 
            this.daysNumeric.Location = new System.Drawing.Point(629, 338);
            this.daysNumeric.Name = "daysNumeric";
            this.daysNumeric.Size = new System.Drawing.Size(106, 22);
            this.daysNumeric.TabIndex = 6;
            this.daysNumeric.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(465, 338);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Experiment\'s number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(512, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Probability 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(512, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Probability 2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(512, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Probability 3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(512, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Probability 4";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(512, 271);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Probability 5";
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(39, 358);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(218, 59);
            this.buttonStart.TabIndex = 13;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(330, 379);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Average:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(330, 400);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "Variance:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(330, 424);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 17);
            this.label9.TabIndex = 16;
            this.label9.Text = "Xi Squared";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(544, 379);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 17);
            this.label10.TabIndex = 17;
            this.label10.Text = "Error (%):";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(544, 400);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 17);
            this.label12.TabIndex = 19;
            this.label12.Text = "Error (%):";
            // 
            // averageLabel
            // 
            this.averageLabel.AutoSize = true;
            this.averageLabel.Location = new System.Drawing.Point(401, 379);
            this.averageLabel.Name = "averageLabel";
            this.averageLabel.Size = new System.Drawing.Size(16, 17);
            this.averageLabel.TabIndex = 20;
            this.averageLabel.Text = "0";
            // 
            // varietyLabel
            // 
            this.varietyLabel.AutoSize = true;
            this.varietyLabel.Location = new System.Drawing.Point(404, 400);
            this.varietyLabel.Name = "varietyLabel";
            this.varietyLabel.Size = new System.Drawing.Size(16, 17);
            this.varietyLabel.TabIndex = 21;
            this.varietyLabel.Text = "0";
            // 
            // xiLabel
            // 
            this.xiLabel.AutoSize = true;
            this.xiLabel.Location = new System.Drawing.Point(414, 424);
            this.xiLabel.Name = "xiLabel";
            this.xiLabel.Size = new System.Drawing.Size(16, 17);
            this.xiLabel.TabIndex = 22;
            this.xiLabel.Text = "0";
            // 
            // averageError
            // 
            this.averageError.AutoSize = true;
            this.averageError.Location = new System.Drawing.Point(620, 379);
            this.averageError.Name = "averageError";
            this.averageError.Size = new System.Drawing.Size(16, 17);
            this.averageError.TabIndex = 23;
            this.averageError.Text = "0";
            // 
            // varienceError
            // 
            this.varienceError.AutoSize = true;
            this.varienceError.Location = new System.Drawing.Point(620, 400);
            this.varienceError.Name = "varienceError";
            this.varienceError.Size = new System.Drawing.Size(16, 17);
            this.varienceError.TabIndex = 24;
            this.varienceError.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.varienceError);
            this.Controls.Add(this.averageError);
            this.Controls.Add(this.xiLabel);
            this.Controls.Add(this.varietyLabel);
            this.Controls.Add(this.averageLabel);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.daysNumeric);
            this.Controls.Add(this.prob5);
            this.Controls.Add(this.prob4);
            this.Controls.Add(this.prob3);
            this.Controls.Add(this.prob2);
            this.Controls.Add(this.prob1);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prob1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prob2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prob3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prob4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prob5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.daysNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.NumericUpDown prob1;
        private System.Windows.Forms.NumericUpDown prob2;
        private System.Windows.Forms.NumericUpDown prob3;
        private System.Windows.Forms.NumericUpDown prob4;
        private System.Windows.Forms.NumericUpDown prob5;
        private System.Windows.Forms.NumericUpDown daysNumeric;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label averageLabel;
        private System.Windows.Forms.Label varietyLabel;
        private System.Windows.Forms.Label xiLabel;
        private System.Windows.Forms.Label averageError;
        private System.Windows.Forms.Label varienceError;
    }
}

