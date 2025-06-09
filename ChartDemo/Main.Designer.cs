namespace ChartDemo
{
    partial class Main
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
            mainChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            groupBox1 = new GroupBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            hInput = new TextBox();
            bInput = new TextBox();
            aInput = new TextBox();
            buildButton = new Button();
            ((System.ComponentModel.ISupportInitialize)mainChart).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // mainChart
            // 
            chartArea1.Name = "ChartArea1";
            mainChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            mainChart.Legends.Add(legend1);
            mainChart.Location = new Point(12, 12);
            mainChart.Name = "mainChart";
            series1.BorderWidth = 5;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = Color.Navy;
            series1.Legend = "Legend1";
            series1.Name = "sin";
            mainChart.Series.Add(series1);
            mainChart.Size = new Size(902, 872);
            mainChart.TabIndex = 0;
            mainChart.Text = "chart1";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.Control;
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(hInput);
            groupBox1.Controls.Add(bInput);
            groupBox1.Controls.Add(aInput);
            groupBox1.Location = new Point(930, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(360, 259);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Range";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 180);
            label3.Name = "label3";
            label3.Size = new Size(16, 15);
            label3.TabIndex = 5;
            label3.Text = "H";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 127);
            label2.Name = "label2";
            label2.Size = new Size(14, 15);
            label2.TabIndex = 4;
            label2.Text = "B";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 72);
            label1.Name = "label1";
            label1.Size = new Size(15, 15);
            label1.TabIndex = 3;
            label1.Text = "A";
            // 
            // hInput
            // 
            hInput.Location = new Point(49, 172);
            hInput.Name = "hInput";
            hInput.Size = new Size(100, 23);
            hInput.TabIndex = 2;
            // 
            // bInput
            // 
            bInput.Location = new Point(49, 119);
            bInput.Name = "bInput";
            bInput.Size = new Size(100, 23);
            bInput.TabIndex = 1;
            // 
            // aInput
            // 
            aInput.Location = new Point(50, 64);
            aInput.Name = "aInput";
            aInput.Size = new Size(100, 23);
            aInput.TabIndex = 0;
            // 
            // buildButton
            // 
            buildButton.Location = new Point(1061, 847);
            buildButton.Name = "buildButton";
            buildButton.Size = new Size(131, 37);
            buildButton.TabIndex = 2;
            buildButton.Text = "Build";
            buildButton.UseVisualStyleBackColor = true;
            buildButton.Click += buildButton_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1302, 896);
            Controls.Add(buildButton);
            Controls.Add(groupBox1);
            Controls.Add(mainChart);
            Name = "Main";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)mainChart).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart mainChart;
        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox hInput;
        private TextBox bInput;
        private TextBox aInput;
        private Button buildButton;
    }
}
