namespace A5_1_1
{
    partial class Picker
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
            redLabel = new Label();
            redTrackBar = new TrackBar();
            redValueLabel = new Label();
            greenValueLabel = new Label();
            greenTrackBar = new TrackBar();
            greenLabel = new Label();
            blueValueLabel = new Label();
            blueTrackBar = new TrackBar();
            blueLabel = new Label();
            colorBox = new Panel();
            dezimalRadioButton = new RadioButton();
            hexRadioButton = new RadioButton();
            groupBox1 = new GroupBox();
            colorValueLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)redTrackBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)greenTrackBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)blueTrackBar).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // redLabel
            // 
            redLabel.AutoSize = true;
            redLabel.Location = new Point(30, 59);
            redLabel.Name = "redLabel";
            redLabel.Size = new Size(27, 15);
            redLabel.TabIndex = 0;
            redLabel.Text = "Red";
            // 
            // redTrackBar
            // 
            redTrackBar.Location = new Point(87, 48);
            redTrackBar.Maximum = 255;
            redTrackBar.Name = "redTrackBar";
            redTrackBar.Size = new Size(314, 45);
            redTrackBar.TabIndex = 1;
            redTrackBar.TickFrequency = 10;
            redTrackBar.Scroll += redTrackBar_Scroll;
            // 
            // redValueLabel
            // 
            redValueLabel.AutoSize = true;
            redValueLabel.Location = new Point(407, 59);
            redValueLabel.Name = "redValueLabel";
            redValueLabel.Size = new Size(13, 15);
            redValueLabel.TabIndex = 2;
            redValueLabel.Text = "0";
            // 
            // greenValueLabel
            // 
            greenValueLabel.AutoSize = true;
            greenValueLabel.Location = new Point(407, 110);
            greenValueLabel.Name = "greenValueLabel";
            greenValueLabel.Size = new Size(13, 15);
            greenValueLabel.TabIndex = 5;
            greenValueLabel.Text = "0";
            // 
            // greenTrackBar
            // 
            greenTrackBar.Location = new Point(87, 99);
            greenTrackBar.Maximum = 255;
            greenTrackBar.Name = "greenTrackBar";
            greenTrackBar.Size = new Size(314, 45);
            greenTrackBar.TabIndex = 4;
            greenTrackBar.TickFrequency = 10;
            greenTrackBar.Scroll += greenTrackBar_Scroll;
            // 
            // greenLabel
            // 
            greenLabel.AutoSize = true;
            greenLabel.Location = new Point(30, 110);
            greenLabel.Name = "greenLabel";
            greenLabel.Size = new Size(38, 15);
            greenLabel.TabIndex = 3;
            greenLabel.Text = "Green";
            // 
            // blueValueLabel
            // 
            blueValueLabel.AutoSize = true;
            blueValueLabel.Location = new Point(407, 161);
            blueValueLabel.Name = "blueValueLabel";
            blueValueLabel.Size = new Size(13, 15);
            blueValueLabel.TabIndex = 8;
            blueValueLabel.Text = "0";
            // 
            // blueTrackBar
            // 
            blueTrackBar.Location = new Point(87, 150);
            blueTrackBar.Maximum = 255;
            blueTrackBar.Name = "blueTrackBar";
            blueTrackBar.Size = new Size(314, 45);
            blueTrackBar.TabIndex = 7;
            blueTrackBar.TickFrequency = 10;
            blueTrackBar.Scroll += blueTrackBar_Scroll;
            // 
            // blueLabel
            // 
            blueLabel.AutoSize = true;
            blueLabel.Location = new Point(30, 161);
            blueLabel.Name = "blueLabel";
            blueLabel.Size = new Size(30, 15);
            blueLabel.TabIndex = 6;
            blueLabel.Text = "Blue";
            // 
            // colorBox
            // 
            colorBox.Location = new Point(30, 201);
            colorBox.Name = "colorBox";
            colorBox.Size = new Size(390, 129);
            colorBox.TabIndex = 9;
            // 
            // dezimalRadioButton
            // 
            dezimalRadioButton.AutoSize = true;
            dezimalRadioButton.Location = new Point(142, 22);
            dezimalRadioButton.Name = "dezimalRadioButton";
            dezimalRadioButton.Size = new Size(67, 19);
            dezimalRadioButton.TabIndex = 10;
            dezimalRadioButton.Text = "Dezimal";
            dezimalRadioButton.UseVisualStyleBackColor = true;
            dezimalRadioButton.CheckedChanged += radioButton_CheckedChanged;
            // 
            // hexRadioButton
            // 
            hexRadioButton.AutoSize = true;
            hexRadioButton.Checked = true;
            hexRadioButton.Location = new Point(18, 22);
            hexRadioButton.Name = "hexRadioButton";
            hexRadioButton.Size = new Size(92, 19);
            hexRadioButton.TabIndex = 11;
            hexRadioButton.TabStop = true;
            hexRadioButton.Text = "Hexadezimal";
            hexRadioButton.UseVisualStyleBackColor = true;
            hexRadioButton.CheckedChanged += radioButton_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(colorValueLabel);
            groupBox1.Controls.Add(dezimalRadioButton);
            groupBox1.Controls.Add(hexRadioButton);
            groupBox1.Location = new Point(30, 336);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(390, 102);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            // 
            // colorValueLabel
            // 
            colorValueLabel.AutoSize = true;
            colorValueLabel.Location = new Point(18, 65);
            colorValueLabel.Name = "colorValueLabel";
            colorValueLabel.Size = new Size(0, 15);
            colorValueLabel.TabIndex = 12;
            // 
            // Picker
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(471, 450);
            Controls.Add(groupBox1);
            Controls.Add(colorBox);
            Controls.Add(blueValueLabel);
            Controls.Add(blueTrackBar);
            Controls.Add(blueLabel);
            Controls.Add(greenValueLabel);
            Controls.Add(greenTrackBar);
            Controls.Add(greenLabel);
            Controls.Add(redValueLabel);
            Controls.Add(redTrackBar);
            Controls.Add(redLabel);
            Name = "Picker";
            Text = "Color Picker";
            ((System.ComponentModel.ISupportInitialize)redTrackBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)greenTrackBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)blueTrackBar).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label redLabel;
        private TrackBar redTrackBar;
        private Label redValueLabel;
        private Label greenValueLabel;
        private TrackBar greenTrackBar;
        private Label greenLabel;
        private Label blueValueLabel;
        private TrackBar blueTrackBar;
        private Label blueLabel;
        private Panel colorBox;
        private RadioButton dezimalRadioButton;
        private RadioButton hexRadioButton;
        private GroupBox groupBox1;
        private Label colorValueLabel;
    }
}
