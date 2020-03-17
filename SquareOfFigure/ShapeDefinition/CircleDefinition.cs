using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SquareOfFigure.Interface;

namespace SquareOfFigure.ShapeDefinition
{
   public class CircleDefinition : ShapeDefinition
    {
        double radius;
        public CircleDefinition(double r)
        {
            this.radius = r;
        }
        public override Figure shapeDefinition()
        {
           return  new Shapes.Circle(radius);
        }
    }
}
