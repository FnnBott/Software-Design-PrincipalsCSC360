using System.Diagnostics;

namespace Kata2;

public class AlgorithmFacade
{
    public (long operationCount, TimeSpan elapsedTime) ExecuteFactorialSquared(List<int> elements)
    {
        var stopwatch = new Stopwatch();
        stopwatch.Start();

        long count = AlgorithmCore.FactorialSquaredAlgorithm(elements);

        stopwatch.Stop();
        
        return (count, stopwatch.Elapsed);
    }
}