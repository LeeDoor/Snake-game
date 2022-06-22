using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    /// <summary>
    /// содержит перечисление возможных обьектов на поле
    /// </summary>
    public enum FieldObjects
    {
        Empty,// пусто
        Body, // тело змейки
        Head, // голова змейки
        Wall, // стена
        Food  // еда
    }
}
