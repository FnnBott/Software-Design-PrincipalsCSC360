namespace SingletonPrac;

public class Singleton
{
    private static Singleton instance = null;
    
    static Singleton() { }

    public static Singleton Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new Singleton();
            }
            return instance;
        }
    }

    public void DoSomething()
    {
        Console.WriteLine("Doing Something");
    }
}