
namespace lab14
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fl = new System.Windows.Forms.NumericUpDown();
            this.sl = new System.Windows.Forms.NumericUpDown();
            this.TBox = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Nbox = new System.Windows.Forms.NumericUpDown();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Start = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.OpBox = new System.Windows.Forms.NumericUpDown();
            this.AvgInQBox = new System.Windows.Forms.Label();
            this.AllCustomersBox = new System.Windows.Forms.Label();
            this.ServedBox = new System.Windows.Forms.Label();
            this.AvgInBankBox = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OpBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.label1.Font = new System.Drawing.Font("Circe", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(53, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "λ of customers:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.label2.Font = new System.Drawing.Font("Circe", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(75, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "λ of servers:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // fl
            // 
            this.fl.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.fl.DecimalPlaces = 2;
            this.fl.Font = new System.Drawing.Font("Circe", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fl.Location = new System.Drawing.Point(187, 24);
            this.fl.Margin = new System.Windows.Forms.Padding(2);
            this.fl.Name = "fl";
            this.fl.Size = new System.Drawing.Size(63, 25);
            this.fl.TabIndex = 2;
            this.fl.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // sl
            // 
            this.sl.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.sl.DecimalPlaces = 2;
            this.sl.Font = new System.Drawing.Font("Circe", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sl.Location = new System.Drawing.Point(187, 46);
            this.sl.Margin = new System.Windows.Forms.Padding(2);
            this.sl.Name = "sl";
            this.sl.Size = new System.Drawing.Size(63, 25);
            this.sl.TabIndex = 3;
            this.sl.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // TBox
            // 
            this.TBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.TBox.Font = new System.Drawing.Font("Circe", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TBox.Location = new System.Drawing.Point(187, 69);
            this.TBox.Margin = new System.Windows.Forms.Padding(2);
            this.TBox.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.TBox.Name = "TBox";
            this.TBox.Size = new System.Drawing.Size(63, 25);
            this.TBox.TabIndex = 4;
            this.TBox.Value = new decimal(new int[] {
            600,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.label3.Font = new System.Drawing.Font("Circe", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(36, 69);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Total Time Units:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.label4.Font = new System.Drawing.Font("Circe", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(140, 92);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "N:";
            // 
            // Nbox
            // 
            this.Nbox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Nbox.Font = new System.Drawing.Font("Circe", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Nbox.Location = new System.Drawing.Point(187, 92);
            this.Nbox.Margin = new System.Windows.Forms.Padding(2);
            this.Nbox.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.Nbox.Name = "Nbox";
            this.Nbox.Size = new System.Drawing.Size(63, 25);
            this.Nbox.TabIndex = 6;
            this.Nbox.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // chart1
            // 
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.AxisX2.Minimum = 0D;
            chartArea1.AxisY.Minimum = 0D;
            chartArea1.AxisY2.Minimum = 0D;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(11, 198);
            this.chart1.Margin = new System.Windows.Forms.Padding(2);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series1.ChartArea = "ChartArea1";
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            series1.IsValueShownAsLabel = true;
            series1.LabelFormat = "0.00";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(417, 306);
            this.chart1.TabIndex = 8;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // chart2
            // 
            chartArea2.AxisX.Minimum = 0D;
            chartArea2.AxisX2.Minimum = 0D;
            chartArea2.AxisY.Minimum = 0D;
            chartArea2.AxisY2.Minimum = 0D;
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Enabled = false;
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(432, 198);
            this.chart2.Margin = new System.Windows.Forms.Padding(2);
            this.chart2.Name = "chart2";
            this.chart2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series2.ChartArea = "ChartArea1";
            series2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            series2.IsValueShownAsLabel = true;
            series2.LabelFormat = "0.00";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart2.Series.Add(series2);
            this.chart2.Size = new System.Drawing.Size(417, 306);
            this.chart2.TabIndex = 9;
            this.chart2.Text = "chart2";
            // 
            // Start
            // 
            this.Start.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Start.Font = new System.Drawing.Font("Circe Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Start.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Start.Location = new System.Drawing.Point(622, 55);
            this.Start.Margin = new System.Windows.Forms.Padding(2);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(124, 45);
            this.Start.TabIndex = 10;
            this.Start.Text = "Simulate";
            this.Start.UseVisualStyleBackColor = false;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.label5.Font = new System.Drawing.Font("Circe", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(29, 114);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 23);
            this.label5.TabIndex = 11;
            this.label5.Text = "Num of Operators:";
            // 
            // OpBox
            // 
            this.OpBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.OpBox.Font = new System.Drawing.Font("Circe", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OpBox.Location = new System.Drawing.Point(187, 115);
            this.OpBox.Margin = new System.Windows.Forms.Padding(2);
            this.OpBox.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.OpBox.Name = "OpBox";
            this.OpBox.Size = new System.Drawing.Size(63, 25);
            this.OpBox.TabIndex = 12;
            this.OpBox.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // AvgInQBox
            // 
            this.AvgInQBox.AutoSize = true;
            this.AvgInQBox.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.AvgInQBox.Font = new System.Drawing.Font("Circe Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AvgInQBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.AvgInQBox.Location = new System.Drawing.Point(284, 68);
            this.AvgInQBox.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AvgInQBox.Name = "AvgInQBox";
            this.AvgInQBox.Size = new System.Drawing.Size(130, 23);
            this.AvgInQBox.TabIndex = 13;
            this.AvgInQBox.Text = "Avg. time in bank:";
            // 
            // AllCustomersBox
            // 
            this.AllCustomersBox.AutoSize = true;
            this.AllCustomersBox.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.AllCustomersBox.Font = new System.Drawing.Font("Circe Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AllCustomersBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.AllCustomersBox.Location = new System.Drawing.Point(284, 24);
            this.AllCustomersBox.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AllCustomersBox.Name = "AllCustomersBox";
            this.AllCustomersBox.Size = new System.Drawing.Size(126, 23);
            this.AllCustomersBox.TabIndex = 14;
            this.AllCustomersBox.Text = "Total customers:";
            // 
            // ServedBox
            // 
            this.ServedBox.AutoSize = true;
            this.ServedBox.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ServedBox.Font = new System.Drawing.Font("Circe Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ServedBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ServedBox.Location = new System.Drawing.Point(284, 45);
            this.ServedBox.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ServedBox.Name = "ServedBox";
            this.ServedBox.Size = new System.Drawing.Size(99, 23);
            this.ServedBox.TabIndex = 15;
            this.ServedBox.Text = "Total served:";
            // 
            // AvgInBankBox
            // 
            this.AvgInBankBox.AutoSize = true;
            this.AvgInBankBox.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.AvgInBankBox.Font = new System.Drawing.Font("Circe Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AvgInBankBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.AvgInBankBox.Location = new System.Drawing.Point(284, 91);
            this.AvgInBankBox.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AvgInBankBox.Name = "AvgInBankBox";
            this.AvgInBankBox.Size = new System.Drawing.Size(140, 23);
            this.AvgInBankBox.TabIndex = 16;
            this.AvgInBankBox.Text = "Avg. time in queue:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.label6.Font = new System.Drawing.Font("Circe Extra Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(181, 165);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 31);
            this.label6.TabIndex = 17;
            this.label6.Text = "Empiric";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.label7.Font = new System.Drawing.Font("Circe Extra Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(626, 165);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 31);
            this.label7.TabIndex = 18;
            this.label7.Text = "Theoretical";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(856, 525);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.AvgInBankBox);
            this.Controls.Add(this.ServedBox);
            this.Controls.Add(this.AllCustomersBox);
            this.Controls.Add(this.AvgInQBox);
            this.Controls.Add(this.OpBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Nbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TBox);
            this.Controls.Add(this.sl);
            this.Controls.Add(this.fl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.fl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OpBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown fl;
        private System.Windows.Forms.NumericUpDown sl;
        private System.Windows.Forms.NumericUpDown TBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown Nbox;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown OpBox;
        private System.Windows.Forms.Label AvgInQBox;
        private System.Windows.Forms.Label AllCustomersBox;
        private System.Windows.Forms.Label ServedBox;
        private System.Windows.Forms.Label AvgInBankBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

