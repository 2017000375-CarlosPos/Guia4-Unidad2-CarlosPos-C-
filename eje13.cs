internal class Program
{
    private static void Main(string[] args)
    {
        int num1;
        int num2;
        int menor;
        int mayor;

        Console.WriteLine("Multiplos de 4");

        Console.Write("pon primer numero: ");
        num1 = int.Parse(Console.ReadLine());

        Console.Write("pon segundo numero: ");
        num2 = int.Parse(Console.ReadLine());

        if (num1 < num2)
        {
            menor = num1;
            mayor = num2;
        }
        else
        {
            menor = num2;
            mayor = num1;
        }

        for (int i = menor; i <= mayor; i++)
        {
            if (i % 4 == 0)
            {
                Console.WriteLine(i);
            }
        }

        Console.ReadKey();
    }
}