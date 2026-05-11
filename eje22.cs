internal class Program
{
    private static void Main(string[] args)
    {
        int num;
        Console.Write("Pon un numero: ");
        num = int.Parse(Console.ReadLine());

        Console.WriteLine("Los primeros 20 múltiplos son:");
        for (int i = 1; i <= 20; i++)
        { 
            Console.WriteLine(num * i);
        }
        Console.ReadKey();
    }
}