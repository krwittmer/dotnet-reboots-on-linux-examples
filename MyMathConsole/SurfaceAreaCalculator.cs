using System;

namespace MyMathLibrary.SurfaceArea
{
    public class SurfaceAreaCalculator
    {
        public static double CalculateAreaOfSphere(int radius)
        {
            return 4 * Math.PI * Math.Pow(radius, 2);
        }
    }
}
