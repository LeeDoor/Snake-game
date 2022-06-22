using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
	/// <summary>
	/// отвечает за окно настроек
	/// </summary>
	public partial class Form2 : Form
	{
		public Form2()
		{
			InitializeComponent();
			// расширенное окно для выбора цвета
			colorDialog1.FullOpen = true;
			// установка начального цвета для colorDialog
			colorDialog1.Color = this.BackColor;
			CurrentSpeedLabel.Text = Field.StartComplexity.ToString();
			SnakeSizeLabel.Text = Field.StartSnakeSize.ToString();
		}

		/// <summary>
		/// кнопка выбора сложности
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void SelectLevelButton_Click(object sender, EventArgs e)
		{
			Field.StartComplexity += 2;
			if (Field.StartComplexity >= 20) Field.StartComplexity = 0;
			CurrentSpeedLabel.Text = Field.StartComplexity.ToString() ;
		}

		/// <summary>
		/// кнопка выбора цвета фона
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BackgroundColorSelectButton_Click(object sender, EventArgs e)
		{
			if (colorDialog1.ShowDialog() == DialogResult.Cancel)
				return;
			// установка цвета формы
			Palette.FieldBackground = colorDialog1.Color;
			BackgroundColorSelectButton.BackColor = Palette.FieldBackground;
		}

		/// <summary>
		/// кнопка выбора цвета тела змейки
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void SnakeColorSelectButton_Click(object sender, EventArgs e)
		{
			if (colorDialog1.ShowDialog() == DialogResult.Cancel)
				return;
			// установка цвета формы
			Palette.SnakeBody = colorDialog1.Color;
			SnakeColorSelectButton.BackColor = Palette.SnakeBody;
		}

		/// <summary>
		/// кнопка выбора начального размера змейки
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
        private void SnakeSizeButton_Click(object sender, EventArgs e)
        {
			Field.StartSnakeSize += 2;
			if(Field.StartSnakeSize >= 30) Field.StartSnakeSize = 2;
			SnakeSizeLabel.Text = Field.StartSnakeSize.ToString();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
