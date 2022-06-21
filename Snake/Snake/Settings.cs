using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public static class Settings
    {
        public static int CellWidth { get; set; } = 20;
        public static int CellHeight { get; set; } = 20;
        public static int startSnakeSize { get; set; } = 10;
        public static Direction direction = Direction.Left;
    }
}
