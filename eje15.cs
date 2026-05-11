internal class Program
{
    private static void Main(string[] args)
    {
        int num;
        int suma = 0;
        Console.WriteLine("sunma hasta tocar el 9");

        do
        {
            Console.Write("Ingrese un numero y cuando quieras acabar la suma pon el 9: ");
            num = int.Parse(Console.ReadLine());

            if (num != 9)
            {
                suma = suma + num;
            }

        } while (num != 9);

        Console.WriteLine("La suma es: " + suma);

        Console.ReadKey();
    }
}