using Xunit;

namespace MyMathLibrary.SurfaceArea.Tests
{
    public class SurfaceAreaCalculatorTest
    {
        [Fact]
        public void CalculateSphereAreaTest()
        {
            Assert.Equal(314.16, SurfaceAreaCalculator.CalculateAreaOfSphere(5), 2);
        }
    }
}
