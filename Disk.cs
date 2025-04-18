using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    class Disk : IShape
    {
        private double radius;

        public Disk(double radius)
        {
            if (radius <= 0)
                throw new ArgumentException("Радиус должен быть положительным.");

            this.radius = radius;
        }

        public double Perimeter() => 2 * Math.PI * radius;

        public double Area() => Math.PI * radius * radius;

        public string Name => "Круг";
        public string Parameters => $"Радиус: r = {radius}";
    }
}
