using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_18
{
    internal class Circle:Shape
    {
        public int Radius;

        public override void CalculateArea()
        {
            Area = Radius * Radius;
            Console.WriteLine($"Area: {Area}");
        }

    }
}
