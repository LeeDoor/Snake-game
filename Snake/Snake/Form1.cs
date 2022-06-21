namespace Snake
{
    public partial class Form1 : Form
    {
        private List<Circle> Snake = new List<Circle>();
        private Circle food = new Circle();
        private int maxWidth, maxHeight, score, highScore;
        private Random rand = new Random();
        private Direction curDirection;


        public Form1()
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    if(Settings.direction!=Direction.Right)
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

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void StartButton_Click(object sender, EventArgs e)
        {
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

        }
    }
}