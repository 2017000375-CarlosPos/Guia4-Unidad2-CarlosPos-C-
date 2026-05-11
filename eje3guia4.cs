internal class Program
{
    private static void Main(string[] args)
    {
        int num;
        int crup = 21;

        Console.Write("Ingrese un numero mayor que 20: ");
        num = int.Parse(Console.ReadLine());

        while (crup <= num)
        {
            Console.WriteLine(crup);

            crup = crup + 2;
        }

        Console.ReadKey();
    }
}