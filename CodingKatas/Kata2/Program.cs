// See https://aka.ms/new-console-template for more information

using Kata2;

class Client
{
    static void Main()
    {
        var facade = new AlgorithmFacade();
        var elements = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };

        Console.WriteLine($"Starting the O(N!^2) algorithm with N={elements.Count}...");

        var result = facade.ExecuteFactorialSquared(elements);

        Console.WriteLine(
            $"Total operations: {result.operationCount}" + '\n' +
            $"Time to complete: {result.elapsedTime}"
        );
    }
}