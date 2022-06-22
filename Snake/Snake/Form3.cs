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
    /// окно с информацией о разработчике и справкой
    /// </summary>
    public partial class Form3 : Form
    {
        /// <summary>
        /// вся информация
        /// </summary>
        private string developerInfo = 
            "hello. i am developer of this program. " +
            "i want to introduce you my snake game.";

        public Form3()
        {
            InitializeComponent();

            DelevoperInfoText.Text = developerInfo;
        }

        /// <summary>
        /// если пользователь попытается изменить текст в окне, он тут же сбросится до изначального
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DelevoperInfoText_TextChanged(object sender, EventArgs e)
        {

            DelevoperInfoText.Text = developerInfo;
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
