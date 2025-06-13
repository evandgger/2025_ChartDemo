namespace ChartDemo.Forms
{
    partial class RandomForm
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
            label1 = new Label();
            label2 = new Label();
            randomMinimumTextBox = new TextBox();
            randomMaximumTextBox = new TextBox();
            setRandomButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(108, 15);
            label1.TabIndex = 0;
            label1.Text = "Random minimum";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 51);
            label2.Name = "label2";
            label2.Size = new Size(109, 15);
            label2.TabIndex = 1;
            label2.Text = "Random maximum";
            // 
            // randomMinimumTextBox
            // 
            randomMinimumTextBox.Location = new Point(126, 7);
            randomMinimumTextBox.Name = "randomMinimumTextBox";
            randomMinimumTextBox.Size = new Size(100, 23);
            randomMinimumTextBox.TabIndex = 2;
            // 
            // randomMaximumTextBox
            // 
            randomMaximumTextBox.Location = new Point(126, 43);
            randomMaximumTextBox.Name = "randomMaximumTextBox";
            randomMaximumTextBox.Size = new Size(100, 23);
            randomMaximumTextBox.TabIndex = 3;
            // 
            // setRandomButton
            // 
            setRandomButton.Location = new Point(12, 100);
            setRandomButton.Name = "setRandomButton";
            setRandomButton.Size = new Size(214, 23);
            setRandomButton.TabIndex = 4;
            setRandomButton.Text = "Set";
            setRandomButton.UseVisualStyleBackColor = true;
            setRandomButton.Click += setRandomButton_Click;
            // 
            // RandomForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(240, 134);
            Controls.Add(setRandomButton);
            Controls.Add(randomMaximumTextBox);
            Controls.Add(randomMinimumTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "RandomForm";
            Text = "RandomForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox randomMinimumTextBox;
        private TextBox randomMaximumTextBox;
        private Button setRandomButton;
    }
}