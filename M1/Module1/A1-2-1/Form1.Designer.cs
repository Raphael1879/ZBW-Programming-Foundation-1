namespace A1_2_1
{
    partial class Form1
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
            yellowButton = new Button();
            yellowLabel = new Label();
            redLabel = new Label();
            redButton = new Button();
            SuspendLayout();
            // 
            // yellowButton
            // 
            yellowButton.Location = new Point(25, 59);
            yellowButton.Name = "yellowButton";
            yellowButton.Size = new Size(75, 23);
            yellowButton.TabIndex = 0;
            yellowButton.Text = "Yellow";
            yellowButton.UseVisualStyleBackColor = true;
            yellowButton.Click += yellowButon_Click;
            // 
            // yellowLabel
            // 
            yellowLabel.AutoSize = true;
            yellowLabel.Location = new Point(135, 63);
            yellowLabel.Name = "yellowLabel";
            yellowLabel.Size = new Size(0, 15);
            yellowLabel.TabIndex = 1;
            // 
            // redLabel
            // 
            redLabel.AutoSize = true;
            redLabel.Location = new Point(135, 92);
            redLabel.Name = "redLabel";
            redLabel.Size = new Size(0, 15);
            redLabel.TabIndex = 3;
            // 
            // redButton
            // 
            redButton.Location = new Point(25, 88);
            redButton.Name = "redButton";
            redButton.Size = new Size(75, 23);
            redButton.TabIndex = 2;
            redButton.Text = "Red";
            redButton.UseVisualStyleBackColor = true;
            redButton.Click += redButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(417, 450);
            Controls.Add(redLabel);
            Controls.Add(redButton);
            Controls.Add(yellowLabel);
            Controls.Add(yellowButton);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button yellowButton;
        private Label yellowLabel;
        private Label redLabel;
        private Button redButton;
    }
}
