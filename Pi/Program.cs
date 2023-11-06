using System.Reflection;

int iterations = 10000000;

// Demonstrating performance improvements by calculating Pi in a few diffrent ways:
DemonstratePi(iterations, PI.Approximations.NumberArray);
DemonstratePi(iterations, PI.Approximations.ObjectArray);
DemonstratePi(iterations, PI.Approximations.DirectCalculation);

static void DemonstratePi(int iterations, Func<int, double> calculationMethod)
{
    var stopwatch = PerformanceProfiler.PerformanceSpeedStart();
    var pi = calculationMethod(iterations);
    Console.WriteLine("Runs: {0}, Pi: {1}", iterations, pi);
    PerformanceProfiler.PerformanceSpeedEnd(stopwatch, calculationMethod.GetMethodInfo().Name);
}