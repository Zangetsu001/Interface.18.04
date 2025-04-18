using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    class Triangle : IShape
    {
        private double a, b, c;

        public Triangle(double a, double b, double c)
        {
            if (a + b <= c || a + c <= b || b + c <= a)
                throw new ArgumentException("Стороны не образуют треугольник.");

            this.a = a;
            this.b = b;
            this.c = c;
        }

        public double Perimeter() => a + b + c;

        public double Area()
        {
            double s = Perimeter() / 2;
            return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
        }

        public string Name => "Треугольник";
        public string Parameters => $"Стороны: a = {a}, b = {b}, c = {c}";
    }
}


