namespace Snake
{
	public partial class Form1 : Form
	{
		private List<Circle> Snake = new List<Circle>();
		private Circle food = new Circle();
		private int maxWidth, maxHeight, score, highScore;
		private Random rand = new Random();
		private Direction curDirection = Direction.Down;
		private bool isStarted = false;

		public Form1()
		{
			InitializeComponent();
		}
		private void StartButton_Click(object sender, EventArgs e)
		{
			isStarted = true;
			RestartGame();
		}

		private void SettingsButton_Click(object sender, EventArgs e)
		{

		}

		private void InfoButton_Click(object sender, EventArgs e)
		{

		}

		private void pictureBox1_Paint(object sender, PaintEventArgs e)
		{
			if (!isStarted) return;
			Graphics canvas = e.Graphics;

			//drawing snake
			Brush snakeBrush = new SolidBrush(Palette.Blue);
			canvas.FillEllipse(snakeBrush, new Rectangle(
				Snake[0].position.X * Settings.CellWidth,
				Snake[0].position.Y * Settings.CellHeight,
				Settings.CellWidth, Settings.CellHeight
				)) ;

			snakeBrush = new SolidBrush(Palette.Green);
			for (int i = 1; i < Snake.Count; i++)
			{
				canvas.FillEllipse(snakeBrush, new Rectangle(
				Snake[i].position.X * Settings.CellWidth,
				Snake[i].position.Y * Settings.CellHeight,
				Settings.CellWidth, Settings.CellHeight
				));
			}

			//drawing food
			canvas.FillEllipse(new SolidBrush(Palette.Pink), new Rectangle(
				food.position.X * Settings.CellWidth,
				food.position.Y * Settings.CellHeight,
				Settings.CellWidth, Settings.CellHeight
				));
		}

		private void GameTimer_Tick(object sender, EventArgs e)
		{
			switch (curDirection)
			{
				case Direction.Left:
					Settings.direction = Direction.Left;
					break;
					case Direction.Right:
					Settings.direction = Direction.Right;
					break;
				case Direction.Up:
					Settings.direction = Direction.Up;
					break;
				case Direction.Down:
					Settings.direction = Direction.Down;
					break;
			}
			for (int i = Snake.Count - 1; i > 0; i--)
			{
                Snake[i].position = Snake[i - 1].position;
			}
			//Snake.Where(n => n.position == Snake[0].position).Count() == 1
			Point newHeadPosition = new Point();
			switch (Settings.direction)
			{
				case Direction.Left:
					newHeadPosition = new Point(Snake[0].position.X - 1, Snake[0].position.Y);
					break;
				case Direction.Right:
					newHeadPosition = new Point(Snake[0].position.X + 1, Snake[0].position.Y);
					break;
				case Direction.Up:
					newHeadPosition = new Point(Snake[0].position.X, Snake[0].position.Y - 1);
					break;
				case Direction.Down:
					newHeadPosition = new Point(Snake[0].position.X, Snake[0].position.Y + 1);
					break;
			}
			if (Snake.Where(n => n.position == newHeadPosition).Count() == 1 
				|| Snake[0].position.X == maxWidth 
				|| Snake[0].position.X == 0 
				|| Snake[0].position.Y == maxHeight 
				|| Snake[0].position.Y == 0)
            {
				GameOver();
            }
			Snake[0].position = newHeadPosition;
			pictureBox1.Invalidate();
		}

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
			switch (e.KeyCode)
			{
				case Keys.Left:
					if (Settings.direction != Direction.Right)
						curDirection = Direction.Left;
					break;
				case Keys.Right:
					if (Settings.direction != Direction.Left)
						curDirection = Direction.Right;
					break;
				case Keys.Up:
					if (Settings.direction != Direction.Down)
						curDirection = Direction.Up;
					break;
				case Keys.Down:
					if (Settings.direction != Direction.Up)
						curDirection = Direction.Down;
					break;
			}
		}

        private void RestartGame()
		{
			maxWidth = pictureBox1.Width / Settings.CellWidth - 1;
			maxHeight = pictureBox1.Height / Settings.CellHeight - 1;

			Snake.Clear();

			StartButton.Visible = false;
			SettingsButton.Visible = false;
			InfoButton.Visible = false;

			score = 0;
			ScoreLabel.Text = "Score: " + score;

			//adding head
			Snake.Add(new Circle() { position = new Point(10, 5) });

			//adding body
			for (int i = 0; i < 10; i++) 
			{
				Snake.Add(new Circle());
			}

			food = new Circle() { position = new Point(rand.Next(2,maxWidth), rand.Next(2,maxHeight))};

			GameTimer.Start();
		}
		private void EatFood()
		{

		}
		private void GameOver()
		{
			isStarted = false;

		}
	}
}