namespace DefinitleyMyFirstApp
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
            button1 = new Button();
            num1 = new NumericUpDown();
            num2 = new NumericUpDown();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)num1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)num2).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(340, 169);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Calc";
            button1.UseVisualStyleBackColor = true;
            button1.Click += onCalcClick;
            // 
            // num1
            // 
            num1.Location = new Point(63, 171);
            num1.Name = "num1";
            num1.Size = new Size(120, 23);
            num1.TabIndex = 1;
            // 
            // num2
            // 
            num2.Location = new Point(198, 169);
            num2.Name = "num2";
            num2.Size = new Size(120, 23);
            num2.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(433, 168);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(136, 23);
            textBox1.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(num2);
            Controls.Add(num1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "My First App";
            ((System.ComponentModel.ISupportInitialize)num1).EndInit();
            ((System.ComponentModel.ISupportInitialize)num2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private NumericUpDown num1;
        private NumericUpDown num2;
        private TextBox textBox1;
    }
}
