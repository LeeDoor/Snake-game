using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public static class Field
    {
        public const int fieldWidth  = 35;
        public const int fieldHeight = 35;
        public static int CellWidth { get; set; } = 20;
        public static int CellHeight { get; set; } = 20;
        public static int StartSnakeSize { get; set; } = 4;
        public static int StartTickrate { get; set; } = 150;
        public static int TickrateDecrease { get; set; } = 10; 
        public static Direction direction = Direction.Left;
        public static FieldObjects[,] field = new FieldObjects[fieldWidth, fieldHeight];
        
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
        public static void ResetSnakePositions(List<Circle> circles)
        {
            Field.ResetSnakePositions(circles.Select(n => n.position).ToList());
        }
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
        public static void ClearField()
        {
            for(int i = 0; i < fieldWidth; i++)
            {
                for(int j = 0; j < fieldHeight; j++)
                {
                    field[i, j] = FieldObjects.Empty;
                }
            }
        }
        
    }
}
