using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    /// <summary>
    /// класс описывает игровое поле
    /// </summary>
    public static class Field
    {
        /// <summary>
        /// ширина поля в клетках
        /// </summary>
        public const int fieldWidth  = 35;
        /// <summary>
        /// высота поля в клетках
        /// </summary>
        public const int fieldHeight = 35;
        /// <summary>
        /// ширина клетки в пикселях
        /// </summary>
        public static int CellWidth { get; set; } = 20;
        /// <summary>
        /// высота клетки в пикселях
        /// </summary>
        public static int CellHeight { get; set; } = 20;
        /// <summary>
        /// изначальный размер змейки
        /// </summary>
        public static int StartSnakeSize { get; set; } = 4;
        /// <summary>
        /// изначальное время таймера
        /// </summary>
        public static int StartTickrate { get; set; } = 150;
        /// <summary>
        /// на сколько ускоряется таймер после сьедения еды
        /// </summary>
        public static int TickrateDecrease { get; set; } = 10;
        /// <summary>
        /// изначальная сложность. от 0 до 18
        /// </summary>
        public static int StartComplexity { get; set; } = 0;
        /// <summary>
        /// текущее направление змейки
        /// </summary>
        public static Direction direction = Direction.Left;
        /// <summary>
        /// поле
        /// </summary>
        public static FieldObjects[,] field = new FieldObjects[fieldWidth, fieldHeight];
        
        /// <summary>
        /// пересоздает пустое поле со стенками по краям
        /// </summary>
        public static void ResetField()
        {
            for(int i = 0; i < fieldWidth; i++)
            {
                for(int j = 0; j < fieldHeight; j++)
                {
                    if (i == 0 || j == 0 || i == fieldWidth - 1 || j == fieldHeight - 1)
                    {
                        field[i, j] = FieldObjects.Wall;
                    }
                    else
                    {
                        field[i, j] = FieldObjects.Empty;
                    }
                }
            }
        }
        /// <summary>
        /// переписывает значения тела змейки
        /// </summary>
        /// <param name="positions">список позиций змейки</param>
        public static void ResetSnakePositions(List<Point> positions)
        {
            for (int w = 0; w < fieldWidth; w++)
            {
                for (int h = 0; h < fieldHeight; h++)
                {
                    switch (field[w, h])
                    {
                        case FieldObjects.Body:
                        case FieldObjects.Head:
                            field[w, h] = FieldObjects.Empty;
                            break;
                    }
                }
            }
            foreach(Point p in positions)
            {
                field[p.X, p.Y] = FieldObjects.Body;
            }
            field[positions[0].X, positions[0].Y] = FieldObjects.Head;
        }
        /// <summary>
        /// перегрузка метода для воспринимания массива кругов, тк информация о змее хранится как список кругов
        /// </summary>
        /// <param name="circles">круги</param>
        public static void ResetSnakePositions(List<Circle> circles)
        {
            Field.ResetSnakePositions(circles.Select(n => n.position).ToList());
        }
        /// <summary>
        /// функция для нахождения случайной свободной позиции на поле
        /// </summary>
        /// <returns>координаты этой позиции или null, если такой нет</returns>
        public static Point? GetRandomFreeCell()
        {
            List<Point> avaliablePoints = new List<Point>();
            for(int h = 0; h < fieldHeight; h++)
            {
                for (int w = 0; w < fieldWidth; w++)
                {
                    if (field[w,h] == FieldObjects.Empty)
                    {
                        avaliablePoints.Add(new Point(w, h));
                    }
                }
            }
            if (avaliablePoints.Count > 0)
            {
                return avaliablePoints[new Random().Next(0, avaliablePoints.Count - 1)];
            }
            else return null;
        }
    }
}
