using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public static class Palette
    {
        public static Color SnakeBody           = Color.FromArgb(255, 63, 196, 77); // snake body
        public static Color WindowBackground    = Color.FromArgb(255, 241, 247, 238); // background window
        public static Color SnakeHead           = Color.FromArgb(255, 160, 155, 231); // snake head
        public static Color FieldBackground     = Color.FromArgb(255, 236, 185, 167); // field
        public static Color Food                = Color.FromArgb(255, 205, 91, 131); // food
        public static Color Walls               = Color.FromArgb(255, 136, 119, 128); // walls
    }
}
