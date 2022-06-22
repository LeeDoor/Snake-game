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
	public partial class Form2 : Form
	{
		public Form2()
		{
			InitializeComponent();
			// расширенное окно для выбора цвета
			colorDialog1.FullOpen = true;
			// установка начального цвета для colorDialog
			colorDialog1.Color = this.BackColor;
		}

		private void SelectLevelButton_Click(object sender, EventArgs e)
		{
			Field.StartComplexity += 2;
			if (Field.StartComplexity >= 20) Field.StartComplexity = 0;
			CurrentSpeedLabel.Text = Field.StartComplexity.ToString() ;
		}

		private void BackgroundColorSelectButton_Click(object sender, EventArgs e)
		{
			if (colorDialog1.ShowDialog() == DialogResult.Cancel)
				return;
			// установка цвета формы
			Palette.FieldBackground = colorDialog1.Color;
			BackgroundColorSelectButton.BackColor = Palette.FieldBackground;
		}

		private void SnakeColorSelectButton_Click(object sender, EventArgs e)
		{
			if (colorDialog1.ShowDialog() == DialogResult.Cancel)
				return;
			// установка цвета формы
			Palette.SnakeBody = colorDialog1.Color;
			SnakeColorSelectButton.BackColor = Palette.SnakeBody;
		}
	}
}
