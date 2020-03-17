using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareOfFigure.Shapes
{
    class Circle: Interface.Figure
    {
        string name = "Circle";
        double radius;
        public Circle(double r)
        {
            this.radius = r;
        }
        public double getSquare()
        {
            return Math.PI * Math.Pow(radius, 2);
        }
    }
}
