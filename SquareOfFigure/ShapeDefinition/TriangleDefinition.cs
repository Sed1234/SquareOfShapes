using SquareOfFigure.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareOfFigure.ShapeDefinition
{
    public class TriangleDefinition:ShapeDefinition
    {
        double a;
        double b;
        double c;
        public TriangleDefinition(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public override Figure shapeDefinition()
        {
            return new Shapes.Triangle(a,b,c);
        }
    }
}
