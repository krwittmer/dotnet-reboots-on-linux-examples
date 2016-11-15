using System;
using MyMathLibrary.SurfaceArea;

namespace MyMathConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Surface area is: {0}", SurfaceAreaCalculator.CalculateAreaOfSphere(5));
        }
    }
}
