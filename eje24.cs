internal class Program
{
    private static void Main(string[] args)
    {
        int n;
        int sumaTot = 0; 

        Console.Write("Pon un numero para la cuenta regresiva: ");
        n = int.Parse(Console.ReadLine());

        while (n >= 1)
        {
            Console.WriteLine(n);
            sumaTot = sumaTot + n;
            n--;
        }

        Console.WriteLine("La suma es: " + sumaTot);
        Console.ReadKey();
    }
}