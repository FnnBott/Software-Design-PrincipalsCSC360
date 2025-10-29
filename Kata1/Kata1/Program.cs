using Kata1;

class Program
{
    static void Main()
    {
        var elements = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };
        
        Manager.Instance.StartTheFunny(elements);
    }
}