using System.Diagnostics;

class PerformanceProfiler
{
    private static Stopwatch? sw;
    public static Stopwatch PerformanceSpeedStart()
    {
        sw = new Stopwatch();
        sw.Start();
        return sw;
    }

    public static void PerformanceSpeedEnd(Stopwatch stopwatch, string functionName)
    {
        stopwatch.Stop();
        TimeSpan ts = stopwatch.Elapsed;
        string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
        Console.WriteLine("Run Time for {0}: {1}", functionName, elapsedTime);
    }
}