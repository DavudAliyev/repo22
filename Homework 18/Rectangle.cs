using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_18
{
    internal class Rectangle:Shape
    {
        public int Height;
        public int Width;

        public override void CalculateArea()
        {
            Area = Height*Width;
            Console.WriteLine($"Area: {Area}");
        }
    }
}
