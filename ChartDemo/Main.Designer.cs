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
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            mainChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            groupBox1 = new GroupBox();
            rangeLabel = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            hInput = new TextBox();
            bInput = new TextBox();
            aInput = new TextBox();
            buildButton = new Button();
            groupBox2 = new GroupBox();
            label4 = new Label();
            chartTypeComboBox = new ComboBox();
            randomCheckBox = new CheckBox();
            customCheckBox = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)mainChart).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // mainChart
            // 
            chartArea1.AxisX.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Lines;
            chartArea1.AxisX.Crossing = 0D;
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisX.MinorTickMark.Enabled = true;
            chartArea1.AxisX.Title = "X";
            chartArea1.AxisY.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Lines;
            chartArea1.AxisY.Crossing = 0D;
            chartArea1.AxisY.MajorGrid.Enabled = false;
            chartArea1.AxisY.MinorTickMark.Enabled = true;
            chartArea1.AxisY.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Horizontal;
            chartArea1.AxisY.Title = "Y";
            chartArea1.BackColor = Color.Transparent;
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
            series1.Name = "Custom";
            series2.BorderWidth = 5;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Color = Color.FromArgb(255, 128, 0);
            series2.Legend = "Legend1";
            series2.Name = "Random";
            mainChart.Series.Add(series1);
            mainChart.Series.Add(series2);
            mainChart.Size = new Size(902, 872);
            mainChart.TabIndex = 0;
            mainChart.Text = "chart1";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.Control;
            groupBox1.Controls.Add(rangeLabel);
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
            // rangeLabel
            // 
            rangeLabel.AutoSize = true;
            rangeLabel.Location = new Point(30, 220);
            rangeLabel.Name = "rangeLabel";
            rangeLabel.Size = new Size(28, 15);
            rangeLabel.TabIndex = 6;
            rangeLabel.Text = "Text";
            rangeLabel.Visible = false;
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
            // groupBox2
            // 
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(chartTypeComboBox);
            groupBox2.Controls.Add(randomCheckBox);
            groupBox2.Controls.Add(customCheckBox);
            groupBox2.Location = new Point(930, 277);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(360, 152);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Series Configuration";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 115);
            label4.Name = "label4";
            label4.Size = new Size(62, 15);
            label4.TabIndex = 3;
            label4.Text = "Chart type";
            // 
            // chartTypeComboBox
            // 
            chartTypeComboBox.FormattingEnabled = true;
            chartTypeComboBox.Items.AddRange(new object[] { "Dot", "Column", "Spline", "Line" });
            chartTypeComboBox.Location = new Point(93, 112);
            chartTypeComboBox.Name = "chartTypeComboBox";
            chartTypeComboBox.Size = new Size(121, 23);
            chartTypeComboBox.TabIndex = 2;
            chartTypeComboBox.SelectedIndexChanged += chartTypeComboBox_SelectedIndexChanged;
            // 
            // randomCheckBox
            // 
            randomCheckBox.AutoSize = true;
            randomCheckBox.Location = new Point(30, 69);
            randomCheckBox.Name = "randomCheckBox";
            randomCheckBox.Size = new Size(71, 19);
            randomCheckBox.TabIndex = 1;
            randomCheckBox.Text = "Random";
            randomCheckBox.UseVisualStyleBackColor = true;
            // 
            // customCheckBox
            // 
            customCheckBox.AutoSize = true;
            customCheckBox.Checked = true;
            customCheckBox.CheckState = CheckState.Checked;
            customCheckBox.Location = new Point(29, 44);
            customCheckBox.Name = "customCheckBox";
            customCheckBox.Size = new Size(68, 19);
            customCheckBox.TabIndex = 0;
            customCheckBox.Text = "Custom";
            customCheckBox.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1302, 896);
            Controls.Add(groupBox2);
            Controls.Add(buildButton);
            Controls.Add(groupBox1);
            Controls.Add(mainChart);
            Name = "Main";
            Text = "Main";
            ((System.ComponentModel.ISupportInitialize)mainChart).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
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
        private GroupBox groupBox2;
        private CheckBox randomCheckBox;
        private CheckBox customCheckBox;
        private Label rangeLabel;
        private Label label4;
        private ComboBox chartTypeComboBox;
    }
}
