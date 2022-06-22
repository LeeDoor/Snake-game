namespace Snake
{
	public partial class Form1 : Form
	{
		private List<Circle> Snake = new List<Circle>();
		private int score, highScore = 0;
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
		private void RestartGame()
		{
			ChangeButtonStatus(false); // hides menu buttons
			Field.ResetField(); 
			ResetScore(); // sets scores 0
			SetNewFood(); // sets new food
			CreateSnake(); // creates snake
			Field.ResetSnakePositions(Snake);
			GameTimer.Interval = Field.StartTickrate;
			GameTimer.Start();
		}

		private void pictureBox1_Paint(object sender, PaintEventArgs e)
		{
			if (!isStarted) return;
			Graphics canvas = e.Graphics;
			Brush brush;
			for (int w = 0; w < Field.fieldWidth; w++)
			{
				for(int h = 0; h < Field.fieldHeight; h++)
				{

					switch (Field.field[w, h])
					{
						case FieldObjects.Empty:
							brush = new SolidBrush(Palette.FieldBackground);
							break;

						case FieldObjects.Body:
							brush = new SolidBrush(Palette.SnakeBody);
							break;

						case FieldObjects.Head:
							brush = new SolidBrush(Palette.SnakeHead);
							break;

						case FieldObjects.Food:
							brush = new SolidBrush(Palette.Food);
							break;

						case FieldObjects.Wall:
							brush = new SolidBrush(Palette.Walls);
							break;

						default:
							brush = new SolidBrush(Palette.FieldBackground);
							break;
					}

					canvas.FillRectangle(brush, new Rectangle(
					w * Field.CellWidth,
					h * Field.CellHeight,
					Field.CellWidth, 
					Field.CellHeight
					));
				}
			}
		}

		private void GameTimer_Tick(object sender, EventArgs e)
		{
			switch (curDirection)
			{
				case Direction.Left:
					Field.direction = Direction.Left;
					break;
					case Direction.Right:
					Field.direction = Direction.Right;
					break;
				case Direction.Up:
					Field.direction = Direction.Up;
					break;
				case Direction.Down:
					Field.direction = Direction.Down;
					break;
			}

			for (int i = Snake.Count - 1; i > 0; i--)
			{
				Snake[i].position = Snake[i - 1].position;
			}
			Point newHeadPosition = new Point();
			switch (Field.direction)
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
			if (Field.field[newHeadPosition.X, newHeadPosition.Y] == FieldObjects.Food)
			{
				EatFood();
			}
			else if(Field.field[newHeadPosition.X, newHeadPosition.Y] != FieldObjects.Empty)
			{
				GameOver();
				return;
			}

			Snake[0].position = newHeadPosition;

			Field.ResetSnakePositions(Snake);

			pictureBox1.Invalidate();
		}
		private void Form1_KeyDown(object sender, KeyEventArgs e)
		{
			switch (e.KeyCode)
			{
				case Keys.Left:
					if (Field.direction != Direction.Right)
						curDirection = Direction.Left;
					break;
				case Keys.Right:
					if (Field.direction != Direction.Left)
						curDirection = Direction.Right;
					break;
				case Keys.Up:
					if (Field.direction != Direction.Down)
						curDirection = Direction.Up;
					break;
				case Keys.Down:
					if (Field.direction != Direction.Up)
						curDirection = Direction.Down;
					break;
			}
		}

		private void EatFood()
		{
			score++;
			ScoreLabel.Text = "Score: " + score;
			Circle body = new Circle();
			body.position = Snake.Last().position;
			Snake.Add(body);

			int intervalDifference = Field.StartTickrate - (score + Field.StartComplexity) / 2 * Field.TickrateDecrease;
			if (intervalDifference < 50) intervalDifference = 50;

			GameTimer.Interval = intervalDifference;

			if (score % 5 == 0)
			{
				Point? newWallPos = Field.GetRandomFreeCell();
				if (newWallPos != null)
				{
					Field.field[newWallPos.Value.X, newWallPos.Value.Y] = FieldObjects.Wall;
				}
			}
			SetNewFood ();
		}
		private void SetNewFood()
		{
			Point? foodPlace = Field.GetRandomFreeCell();
			if (foodPlace == null)
			{
				GameOver(); 
				return;
			}
			Field.field[foodPlace.Value.X, foodPlace.Value.Y] = FieldObjects.Food;
		}
		private void GameOver()
		{
			isStarted = false;
			GameTimer.Stop();
			ChangeButtonStatus(true);
			ResetHighscore();
		}
		private void ChangeButtonStatus(bool stat)
		{
			StartButton.Visible		= stat;
			SettingsButton.Visible	= stat;
			InfoButton.Visible		= stat;
		}
		private void ResetScore()
		{
			score = 0;
			ScoreLabel.Text = "Score: " + score;
		}
		private void ResetHighscore()
		{
			if (score > highScore)
			{
				highScore = score;
			}
			BestScoreLabel.Text = "Best: " + highScore;
		}
		private void CreateSnake()
		{
			Snake.Clear(); // clears
			//adding head
			Snake.Add(new Circle() { position = new Point(10, 5) });

			//adding body
			for (int i = 0; i < Field.StartSnakeSize; i++)
			{
				Snake.Add(new Circle());
			}
		}


		private void SettingsButton_Click(object sender, EventArgs e)
        {
			OpenSettingsMenu();
        }
			
		
		private void InfoButton_Click(object sender, EventArgs e)
		{

		}

		private void OpenSettingsMenu()
        {
			Form2 f = new Form2();
			f.ShowDialog();
        }
	}
}