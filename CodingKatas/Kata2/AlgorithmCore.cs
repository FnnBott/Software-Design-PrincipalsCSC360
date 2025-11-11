namespace Kata2;

public class AlgorithmCore
{
    internal static long FactorialSquaredAlgorithm(List<int> elements)
    {
        var perms1 = GetPermutations(elements, elements.Count).ToList();
        var perms2 = GetPermutations(elements, elements.Count).ToList();

        long count = 0;

        foreach (var p1 in perms1)
        {
            foreach (var p2 in perms2)
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