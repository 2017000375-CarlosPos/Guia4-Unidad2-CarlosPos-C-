internal class Program
{
    private static void Main(string[] args)
    {
        
        Console.WriteLine("Impares del 1 al 100");

        for (int crup = 1; crup <= 100; crup = crup + 2)
        {
            Console.WriteLine(crup);
        }

        Console.ReadKey();
    }
}