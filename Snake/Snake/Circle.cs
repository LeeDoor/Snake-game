using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    /// <summary>
    /// рисуемый элемент на поле
    /// </summary>
    public class Circle
    {
        /// <summary>
        /// позиция кружка
        /// </summary>
        public Point position { get; set; }

        /// <summary>
        /// конструктор по умолчанию. изначально элементы ставятся в середину поля
        /// </summary>
        public Circle()
        {
            position = new Point(Field.fieldWidth / 2, Field.fieldHeight / 2);
        }
    }
}
