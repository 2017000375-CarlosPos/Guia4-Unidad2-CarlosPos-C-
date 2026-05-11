internal class Program
{
    private static void Main(string[] args)
    {
        int num;
        int suma = 0;
        int pares = 0;
        Console.WriteLine("Multiplos de 7");

        for (int crup = 1; crup <= 20; crup++)
        {
            num = crup * 7;

            Console.WriteLine(num);

            suma = suma + num;

            if (num % 2 == 0)
            {
                pares++;
            }
        }

        Console.WriteLine("Suma total: " + suma);
        Console.WriteLine("Cantidad de pares: " + pares);

        Console.ReadKey();
    }
}