using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SquareOfFigure;
using SquareOfFigure.Interface;
using SquareOfFigure.ShapeDefinition;

namespace SquareOfFigureTests
{
    [TestClass]
    public class SquareOfFigureTests
    {
        [TestMethod]
        public void CheckCircleSquare()
        {
            double r = 3;
            double expected = Math.PI * Math.Pow(r, 2);

            CircleDefinition circle = new CircleDefinition(r);
            Figure figure = circle.shapeDefinition();
            

            Assert.AreEqual(expected, figure.getSquare());
        }
    }
}
