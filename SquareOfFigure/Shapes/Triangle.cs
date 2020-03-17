using SquareOfFigure.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareOfFigure.Shapes
{
    public class Triangle:Figure
    {
        string name = "Triangle";
        double a;
        double b;
        double c;
        public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
         double Figure.getSquare()
        {
            double p = (a + b + c) / 2;
            return Math.Pow((p * (p - a) * (p - b) * (p - c)), 0.5);
        }

        public static string CheckTypeOFTriangle (double a, double b,double c)
        {
            List<double> arr = new List<double>{ a, b, c };

            arr.Sort();
            if (Math.Pow(arr[2], 2) == Math.Pow(arr[0], 2) + Math.Pow(arr[1], 2))

            { return "Прямоугольный треугольник"; }
            return "Обычный Треугольник";
        }
    }
}
