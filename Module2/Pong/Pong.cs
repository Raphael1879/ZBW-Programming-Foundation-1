
namespace Pong
{
    public partial class Pong : Form
    {
        private System.Windows.Forms.Timer _gameTimer;
        private int _xVelocity;
        private int _yVelocity;
        private int _score;
        private int _level;


        public Pong()
        {
            InitializeComponent();
        }


        private void StartGameLoop()
        {
            ConfigureGame();
            _gameTimer = new System.Windows.Forms.Timer();
            _gameTimer.Interval = 1;
            _gameTimer.Tick += GameLoop;
            _gameTimer.Start();
        }

        private void ConfigureGame()
        {
            var random = new Random();
            _xVelocity = random.Next(1,3);
            _yVelocity = random.Next(1, 3); ;
            _score = 0;
            _level = 1;
            levelLabel.Text = $"Level: {_level.ToString()}";
            scoreLabel.Text = $"Score: {_score.ToString()}";
        }

        private void GameLoop(object sender, EventArgs e)
        {

            ball.Location = new Point
            {
                X = ball.Location.X + _xVelocity * _level,
                Y = ball.Location.Y + _yVelocity * _level
            };

            var playerHit = ball.Bounds.IntersectsWith(player.Bounds);
            var gameOver = ball.Right >= ClientSize.Width;
            if (ball.Left <= 0 || gameOver || playerHit)
            {
                _xVelocity = -_xVelocity; // reverse X direction

                if(playerHit)
                {
                    OnPlayerHit();
                }

                if(gameOver)
                {
                    Gameover();
                }
            }

            // --- Collision with top or bottom edge ---
            if (ball.Top <= 0 || ball.Bottom >= ClientSize.Height)
            {
                _yVelocity = -_yVelocity; // reverse Y direction
            }
        }

        private void OnPlayerHit()
        {
            _score++;
            scoreLabel.Text = $"Score: {_score.ToString()}";

            if(_score % 3 == 0)
            {
                //increase Level
                _level++;
                levelLabel.Text = $"Level: {_level.ToString()}";
            }
        }

        private void Gameover()
        {
            _gameTimer.Stop();
            MessageBox.Show("Game Over!");
            startButton.Visible = true;

            ball.Location = new Point
            {
                X = 15,
                Y = 15
            };
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            startButton.Visible = false;
            StartGameLoop();
        }

        private void Pong_MouseMove(object sender, MouseEventArgs e)
        {
            int newY = e.Location.Y - player.Height / 2;

            // Clamp Y position so the paddle stays inside the window
            if (newY < 0)
                newY = 0;
            else if (newY + player.Height > ClientSize.Height)
                newY = ClientSize.Height - player.Height;

            player.Location = new Point(player.Location.X, newY);
        }
    }
}
