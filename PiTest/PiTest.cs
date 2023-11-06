using PI;

namespace PiTest
{
    public class GenerationUnitTests
    {
        const int iterations = 500000;
        [Fact]
        public void Approximations_ObjectArray_IsApproxPi()
        {
            var pi = Approximations.ObjectArray(iterations);
            Assert.Equal(3.14, Math.Round(pi, 2));
        }
        [Fact]
        public void Approximations_NumberArray_IsApproxPi()
        {
            var pi = Approximations.NumberArray(iterations);
            Assert.Equal(3.14, Math.Round(pi, 2));
        }
        [Fact]
        public void Approximations_DirectCalculation_IsApproxPi()
        {
            var pi = Approximations.DirectCalculation(iterations);
            Assert.Equal(3.14, Math.Round(pi, 2));
        }

    }
}