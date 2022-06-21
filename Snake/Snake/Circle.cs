using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public class Circle
    {
        public Point position { get; set; }

        public Circle()
        {
            position = new Point(0,0);
        }
    }
}
