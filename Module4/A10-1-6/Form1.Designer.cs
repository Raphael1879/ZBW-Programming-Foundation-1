namespace A10_1_6
{
    partial class A1016
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
            textBox = new TextBox();
            generateButton = new Button();
            maxLabel = new Label();
            maxButton = new Button();
            smallestButton = new Button();
            smallLabel = new Label();
            averageButton = new Button();
            averageLabel = new Label();
            button1 = new Button();
            deltaMaxLabel = new Label();
            button2 = new Button();
            deltaMinLabel = new Label();
            SuspendLayout();
            // 
            // textBox
            // 
            textBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox.Location = new Point(12, 25);
            textBox.Multiline = true;
            textBox.Name = "textBox";
            textBox.ScrollBars = ScrollBars.Vertical;
            textBox.Size = new Size(707, 153);
            textBox.TabIndex = 0;
            // 
            // generateButton
            // 
            generateButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            generateButton.Location = new Point(12, 184);
            generateButton.Name = "generateButton";
            generateButton.Size = new Size(707, 23);
            generateButton.TabIndex = 1;
            generateButton.Text = "Generate Random Numbers";
            generateButton.UseVisualStyleBackColor = true;
            generateButton.Click += generateButton_Click;
            // 
            // maxLabel
            // 
            maxLabel.AutoSize = true;
            maxLabel.Location = new Point(207, 224);
            maxLabel.Name = "maxLabel";
            maxLabel.Size = new Size(0, 15);
            maxLabel.TabIndex = 2;
            // 
            // maxButton
            // 
            maxButton.Location = new Point(12, 220);
            maxButton.Name = "maxButton";
            maxButton.Size = new Size(189, 23);
            maxButton.TabIndex = 3;
            maxButton.Text = "Biggest Number";
            maxButton.UseVisualStyleBackColor = true;
            // 
            // smallestButton
            // 
            smallestButton.Location = new Point(12, 249);
            smallestButton.Name = "smallestButton";
            smallestButton.Size = new Size(189, 23);
            smallestButton.TabIndex = 5;
            smallestButton.Text = "Smallest Number";
            smallestButton.UseVisualStyleBackColor = true;
            // 
            // smallLabel
            // 
            smallLabel.AutoSize = true;
            smallLabel.Location = new Point(207, 253);
            smallLabel.Name = "smallLabel";
            smallLabel.Size = new Size(0, 15);
            smallLabel.TabIndex = 4;
            // 
            // averageButton
            // 
            averageButton.Location = new Point(12, 278);
            averageButton.Name = "averageButton";
            averageButton.Size = new Size(189, 23);
            averageButton.TabIndex = 7;
            averageButton.Text = "Average Number";
            averageButton.UseVisualStyleBackColor = true;
            // 
            // averageLabel
            // 
            averageLabel.AutoSize = true;
            averageLabel.Location = new Point(207, 282);
            averageLabel.Name = "averageLabel";
            averageLabel.Size = new Size(0, 15);
            averageLabel.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(12, 307);
            button1.Name = "button1";
            button1.Size = new Size(189, 23);
            button1.TabIndex = 8;
            button1.Text = "Delta Max";
            button1.UseVisualStyleBackColor = true;
            // 
            // deltaMaxLabel
            // 
            deltaMaxLabel.AutoSize = true;
            deltaMaxLabel.Location = new Point(207, 311);
            deltaMaxLabel.Name = "deltaMaxLabel";
            deltaMaxLabel.Size = new Size(0, 15);
            deltaMaxLabel.TabIndex = 9;
            // 
            // button2
            // 
            button2.Location = new Point(12, 336);
            button2.Name = "button2";
            button2.Size = new Size(189, 23);
            button2.TabIndex = 10;
            button2.Text = "Delta Min";
            button2.UseVisualStyleBackColor = true;
            // 
            // deltaMinLabel
            // 
            deltaMinLabel.AutoSize = true;
            deltaMinLabel.Location = new Point(207, 340);
            deltaMinLabel.Name = "deltaMinLabel";
            deltaMinLabel.Size = new Size(0, 15);
            deltaMinLabel.TabIndex = 11;
            // 
            // A1016
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(731, 380);
            Controls.Add(button2);
            Controls.Add(deltaMinLabel);
            Controls.Add(averageButton);
            Controls.Add(button1);
            Controls.Add(averageLabel);
            Controls.Add(deltaMaxLabel);
            Controls.Add(smallestButton);
            Controls.Add(smallLabel);
            Controls.Add(maxButton);
            Controls.Add(maxLabel);
            Controls.Add(generateButton);
            Controls.Add(textBox);
            Name = "A1016";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox;
        private Button generateButton;
        private Label maxLabel;
        private Button maxButton;
        private Button smallestButton;
        private Label smallLabel;
        private Button averageButton;
        private Label averageLabel;
        private Button button1;
        private Label deltaMaxLabel;
        private Button button2;
        private Label deltaMinLabel;
    }
}
