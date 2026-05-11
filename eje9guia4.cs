internal class Program
{
    private static void Main(string[] args)
    {
        int suma = 0;

        Console.WriteLine("numeros primos:");

        for (int num = 2; num <= 22; num++)
        {
            bool primo = true;

            for (int divisor = 2; divisor < num; divisor++)
            {
                if (num % divisor == 0)
                {
                    primo = false;
                }
            }

            if (primo == true)
            {
                Console.WriteLine(num);

                suma = suma + num;
            }
        }

        Console.WriteLine("Suma: " + suma);

        Console.ReadKey();
    }
}