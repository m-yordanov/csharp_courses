using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Rectangle : Shape
    {
        private int x;
        private int y;

        public Rectangle(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }

        public override double CalculateArea()
        {
            return this.X * this.Y;
        }

        public override double CalculatePerimeter()
        {
            return (this.X * 2) + (this.Y * 2);
        }
    }
}
