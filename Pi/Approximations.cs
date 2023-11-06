namespace PI
{
    public class Approximations
    {
        public static double ObjectArray(int iterations)
        {
            int inCircleCount = 0;
            Number[] randomNumbers = new Number[iterations];
            var rand = new Random();
            var currNumber = new Number();
            for (int i = 0; i < iterations; i++)
            {
                currNumber.X = rand.NextDouble();
                currNumber.Y = rand.NextDouble();
                currNumber.R = Math.Sqrt(Math.Pow(currNumber.X, 2) + Math.Pow(currNumber.Y, 2));
                currNumber.InCircle = currNumber.R <= 1;
                if (currNumber.InCircle)
                {
                    inCircleCount += 1;
                }
                randomNumbers[i] = (currNumber);
            }
            return ((double)inCircleCount / iterations) * 4;
        }
        public static double NumberArray(int iterations)
        {
            int inCircleCount = 0;
            double[,] numbers = new double[iterations, 3];
            var rand = new Random();
            for (int i = 0; i < iterations; i++)
            {
                numbers[i, 0] = rand.NextDouble();
                numbers[i, 1] = rand.NextDouble();
                numbers[i, 2] = Math.Sqrt(Math.Pow(numbers[i, 0], 2) + Math.Pow(numbers[i, 1], 2));
                if (numbers[i, 2] <= 1) // is in circle
                {
                    inCircleCount += 1;
                }
            }
            return ((double)inCircleCount / iterations) * 4;
        }
        public static double DirectCalculation(int iterations)
        {
            int inCircleCount = 0;
            var rand = new Random();
            for (int i = 0; i < iterations; i++)
            {
                var x = rand.NextDouble();
                var y = rand.NextDouble();
                var r = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
                if (r <= 1) // is in circle
                {
                    inCircleCount += 1;
                }
            }
            return ((double)inCircleCount / iterations) * 4;
        }
    }
}