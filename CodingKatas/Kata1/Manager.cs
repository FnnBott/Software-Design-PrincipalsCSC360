using System.Diagnostics;

namespace Kata1;

public class Manager
{
    private static Manager? _instance;
    
    private Manager(){}

    public static Manager Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new Manager();
            }
            return _instance;
        }
    }

    public void StartTheFunny(List<int> elements)
    {
        var stopwatch = new Stopwatch();
        stopwatch.Start();
        
        long count = TheFunny(elements);
        
        stopwatch.Stop();
        
        Console.WriteLine($"Total time: {stopwatch.ElapsedMilliseconds}ms" + '\n' + $"Total Operations: {count}" );
    }

    private static long TheFunny(List<int> elements)
    {
        var perms1 = GetPermutations(elements, elements.Count).ToList();
        var perms2 = GetPermutations(elements, elements.Count).ToList();

        long count = 0;
        foreach (var perm in perms1)
        {
            foreach (var perm2 in perms2)
            {
                count++;
            }
        }
        return count;
    }
    
    private static IEnumerable<List<T>> GetPermutations<T>(List<T> list, int length)
    {
        if (length == 1)
            return list.Select(t => new List<T> { t });

        return GetPermutations(list, length - 1)
            .SelectMany(t => list.Where(e => !t.Contains(e)),
                (t1, t2) => new List<T>(t1) { t2 });
    }
}