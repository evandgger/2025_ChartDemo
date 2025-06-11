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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            mainChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            rangeSeries = new GroupBox();
            rangeLabel = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            stepInput = new TextBox();
            endRangeInput = new TextBox();
            startRangeInput = new TextBox();
            buildButton = new Button();
            seriesGroupBox = new GroupBox();
            label4 = new Label();
            chartTypeComboBox = new ComboBox();
            randomCheckBox = new CheckBox();
            customCheckBox = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)mainChart).BeginInit();
            rangeSeries.SuspendLayout();
            seriesGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // mainChart
            // 
            chartArea2.AxisX.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Lines;
            chartArea2.AxisX.Crossing = 0D;
            chartArea2.AxisX.MajorGrid.Enabled = false;
            chartArea2.AxisX.MinorTickMark.Enabled = true;
            chartArea2.AxisX.Title = "X";
            chartArea2.AxisY.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Lines;
            chartArea2.AxisY.Crossing = 0D;
            chartArea2.AxisY.MajorGrid.Enabled = false;
            chartArea2.AxisY.MinorTickMark.Enabled = true;
            chartArea2.AxisY.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Horizontal;
            chartArea2.AxisY.Title = "Y";
            chartArea2.BackColor = Color.Transparent;
            chartArea2.Name = "ChartArea1";
            mainChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            mainChart.Legends.Add(legend2);
            mainChart.Location = new Point(12, 12);
            mainChart.Name = "mainChart";
            series3.BorderWidth = 5;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Color = Color.Navy;
            series3.Legend = "Legend1";
            series3.Name = "Custom";
            series4.BorderWidth = 5;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Color = Color.FromArgb(255, 128, 0);
            series4.Legend = "Legend1";
            series4.Name = "Random";
            mainChart.Series.Add(series3);
            mainChart.Series.Add(series4);
            mainChart.Size = new Size(902, 872);
            mainChart.TabIndex = 0;
            mainChart.Text = "chart1";
            // 
            // rangeSeries
            // 
            rangeSeries.BackColor = SystemColors.Control;
            rangeSeries.Controls.Add(rangeLabel);
            rangeSeries.Controls.Add(label3);
            rangeSeries.Controls.Add(label2);
            rangeSeries.Controls.Add(label1);
            rangeSeries.Controls.Add(stepInput);
            rangeSeries.Controls.Add(endRangeInput);
            rangeSeries.Controls.Add(startRangeInput);
            rangeSeries.Location = new Point(930, 12);
            rangeSeries.Name = "rangeSeries";
            rangeSeries.Size = new Size(360, 259);
            rangeSeries.TabIndex = 1;
            rangeSeries.TabStop = false;
            rangeSeries.Text = "Range";
            // 
            // rangeLabel
            // 
            rangeLabel.AutoSize = true;
            rangeLabel.Location = new Point(30, 220);
            rangeLabel.Name = "rangeLabel";
            rangeLabel.Size = new Size(0, 15);
            rangeLabel.TabIndex = 6;
            rangeLabel.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 185);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 5;
            label3.Text = "Step:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 127);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 4;
            label2.Text = "End range: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 72);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 3;
            label1.Text = "Start range:";
            // 
            // stepInput
            // 
            stepInput.Location = new Point(102, 177);
            stepInput.Name = "stepInput";
            stepInput.Size = new Size(100, 23);
            stepInput.TabIndex = 2;
            stepInput.Text = "1";
            // 
            // endRangeInput
            // 
            endRangeInput.Location = new Point(102, 119);
            endRangeInput.Name = "endRangeInput";
            endRangeInput.Size = new Size(100, 23);
            endRangeInput.TabIndex = 1;
            endRangeInput.Text = "10";
            // 
            // startRangeInput
            // 
            startRangeInput.Location = new Point(102, 64);
            startRangeInput.Name = "startRangeInput";
            startRangeInput.Size = new Size(100, 23);
            startRangeInput.TabIndex = 0;
            startRangeInput.Text = "-10";
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
            // seriesGroupBox
            // 
            seriesGroupBox.Controls.Add(label4);
            seriesGroupBox.Controls.Add(chartTypeComboBox);
            seriesGroupBox.Controls.Add(randomCheckBox);
            seriesGroupBox.Controls.Add(customCheckBox);
            seriesGroupBox.Location = new Point(930, 277);
            seriesGroupBox.Name = "seriesGroupBox";
            seriesGroupBox.Size = new Size(360, 152);
            seriesGroupBox.TabIndex = 3;
            seriesGroupBox.TabStop = false;
            seriesGroupBox.Text = "Series Configuration";
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
            Controls.Add(seriesGroupBox);
            Controls.Add(buildButton);
            Controls.Add(rangeSeries);
            Controls.Add(mainChart);
            Name = "Main";
            Text = "Main";
            ((System.ComponentModel.ISupportInitialize)mainChart).EndInit();
            rangeSeries.ResumeLayout(false);
            rangeSeries.PerformLayout();
            seriesGroupBox.ResumeLayout(false);
            seriesGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart mainChart;
        private GroupBox rangeSeries;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox stepInput;
        private TextBox endRangeInput;
        private TextBox startRangeInput;
        private Button buildButton;
        private GroupBox seriesGroupBox;
        private CheckBox randomCheckBox;
        private CheckBox customCheckBox;
        private Label rangeLabel;
        private Label label4;
        private ComboBox chartTypeComboBox;
    }
}
