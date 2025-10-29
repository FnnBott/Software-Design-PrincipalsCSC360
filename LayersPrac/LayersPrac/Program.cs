class LayersPrac
{
    public static void Main()
    {
        var readFromFile = File.ReadAllText("C:\\Users\\Dtieben\\Documents\\GitHub\\Software-Design-PrincipalsCSC360\\LayersPrac\\LayersPrac\\_README.txt");
        
        Console.WriteLine(readFromFile);
    }
}