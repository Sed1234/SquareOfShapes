using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SquareOfFigure.Interface;
using SquareOfFigure.ShapeDefinition;
using SquareOfFigure.Shapes;

namespace SquareOfFigureTests
{
    [TestClass]
    public class SquareOfTriangeTests
    {
        [TestMethod]
        public void CheckTriangle()
        {
            double a = 5;
            double b = 4;
            double c = 3;
            double expected = 6;

            TriangleDefinition triangle = new TriangleDefinition(a, b, c);
            Figure figure = triangle.shapeDefinition();

            Assert.AreEqual(expected, figure.getSquare());

        }
        [TestMethod]
        public void CheckTypeOfTriangleTest()
        {
            double a = 5;
            double b = 4;
            double c = 3;
            string expected = "Прямоугольный треугольник";
            
           
            Assert.AreEqual(expected,Triangle.CheckTypeOFTriangle(a,b,c));

        }
    }
}
