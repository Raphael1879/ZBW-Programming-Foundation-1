namespace Pong
{
    partial class Pong
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
            ball = new Panel();
            startButton = new Button();
            player = new Panel();
            scoreLabel = new Label();
            levelLabel = new Label();
            SuspendLayout();
            // 
            // ball
            // 
            ball.BackColor = Color.Red;
            ball.Location = new Point(12, 58);
            ball.Name = "ball";
            ball.Size = new Size(25, 25);
            ball.TabIndex = 0;
            // 
            // startButton
            // 
            startButton.Dock = DockStyle.Top;
            startButton.Location = new Point(0, 0);
            startButton.Name = "startButton";
            startButton.Size = new Size(800, 23);
            startButton.TabIndex = 1;
            startButton.Text = "Start";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += startButton_Click;
            // 
            // player
            // 
            player.Anchor = AnchorStyles.Right;
            player.BackColor = Color.DodgerBlue;
            player.Location = new Point(736, 156);
            player.Name = "player";
            player.Size = new Size(25, 100);
            player.TabIndex = 1;
            // 
            // scoreLabel
            // 
            scoreLabel.AutoSize = true;
            scoreLabel.Dock = DockStyle.Left;
            scoreLabel.Location = new Point(0, 23);
            scoreLabel.Name = "scoreLabel";
            scoreLabel.Size = new Size(48, 15);
            scoreLabel.TabIndex = 2;
            scoreLabel.Text = "Score: 0";
            // 
            // levelLabel
            // 
            levelLabel.AutoSize = true;
            levelLabel.Dock = DockStyle.Left;
            levelLabel.Location = new Point(48, 23);
            levelLabel.Name = "levelLabel";
            levelLabel.Size = new Size(46, 15);
            levelLabel.TabIndex = 3;
            levelLabel.Text = "Level: 1";
            // 
            // Pong
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(levelLabel);
            Controls.Add(scoreLabel);
            Controls.Add(player);
            Controls.Add(startButton);
            Controls.Add(ball);
            Name = "Pong";
            Text = "Pong";
            MouseMove += Pong_MouseMove;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel ball;
        private Button startButton;
        private Panel player;
        private Label scoreLabel;
        private Label levelLabel;
    }
}
