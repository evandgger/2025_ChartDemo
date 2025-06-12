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
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            linearCheckBox = new CheckBox();
            label4 = new Label();
            chartTypeComboBox = new ComboBox();
            randomCheckBox = new CheckBox();
            customCheckBox = new CheckBox();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            instructionsToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)mainChart).BeginInit();
            rangeSeries.SuspendLayout();
            seriesGroupBox.SuspendLayout();
            menuStrip1.SuspendLayout();
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
            mainChart.Location = new Point(12, 27);
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
            series3.BorderColor = Color.Transparent;
            series3.BorderWidth = 5;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Color = Color.Green;
            series3.Legend = "Legend1";
            series3.Name = "y = cos (x)";
            mainChart.Series.Add(series1);
            mainChart.Series.Add(series2);
            mainChart.Series.Add(series3);
            mainChart.Size = new Size(902, 857);
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
            rangeSeries.Location = new Point(930, 27);
            rangeSeries.Name = "rangeSeries";
            rangeSeries.Size = new Size(360, 244);
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
            seriesGroupBox.Controls.Add(linearCheckBox);
            seriesGroupBox.Controls.Add(label4);
            seriesGroupBox.Controls.Add(chartTypeComboBox);
            seriesGroupBox.Controls.Add(randomCheckBox);
            seriesGroupBox.Controls.Add(customCheckBox);
            seriesGroupBox.Location = new Point(930, 277);
            seriesGroupBox.Name = "seriesGroupBox";
            seriesGroupBox.Size = new Size(360, 145);
            seriesGroupBox.TabIndex = 3;
            seriesGroupBox.TabStop = false;
            seriesGroupBox.Text = "Series Configuration";
            // 
            // linearCheckBox
            // 
            linearCheckBox.AutoSize = true;
            linearCheckBox.Location = new Point(23, 57);
            linearCheckBox.Name = "linearCheckBox";
            linearCheckBox.Size = new Size(80, 19);
            linearCheckBox.TabIndex = 4;
            linearCheckBox.Text = "y = cos (x)";
            linearCheckBox.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 113);
            label4.Name = "label4";
            label4.Size = new Size(62, 15);
            label4.TabIndex = 3;
            label4.Text = "Chart type";
            // 
            // chartTypeComboBox
            // 
            chartTypeComboBox.FormattingEnabled = true;
            chartTypeComboBox.Items.AddRange(new object[] { "Dot", "Column", "Spline", "Line" });
            chartTypeComboBox.Location = new Point(91, 110);
            chartTypeComboBox.Name = "chartTypeComboBox";
            chartTypeComboBox.Size = new Size(121, 23);
            chartTypeComboBox.TabIndex = 2;
            chartTypeComboBox.SelectedIndexChanged += chartTypeComboBox_SelectedIndexChanged;
            // 
            // randomCheckBox
            // 
            randomCheckBox.AutoSize = true;
            randomCheckBox.Location = new Point(23, 82);
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
            customCheckBox.Location = new Point(23, 32);
            customCheckBox.Name = "customCheckBox";
            customCheckBox.Size = new Size(68, 19);
            customCheckBox.TabIndex = 0;
            customCheckBox.Text = "Custom";
            customCheckBox.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, instructionsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1302, 24);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem, saveToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(180, 22);
            openToolStripMenuItem.Text = "Open";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(180, 22);
            saveToolStripMenuItem.Text = "Save";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // instructionsToolStripMenuItem
            // 
            instructionsToolStripMenuItem.Name = "instructionsToolStripMenuItem";
            instructionsToolStripMenuItem.Size = new Size(81, 20);
            instructionsToolStripMenuItem.Text = "Instructions";
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
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Main";
            Text = "Main";
            ((System.ComponentModel.ISupportInitialize)mainChart).EndInit();
            rangeSeries.ResumeLayout(false);
            rangeSeries.PerformLayout();
            seriesGroupBox.ResumeLayout(false);
            seriesGroupBox.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
        private CheckBox linearCheckBox;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem instructionsToolStripMenuItem;
    }
}
