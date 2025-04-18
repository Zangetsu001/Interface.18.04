using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    interface IShape
    {
        double Perimeter();
        double Area();
        string Name { get; }
        string Parameters { get; }

    }
}
