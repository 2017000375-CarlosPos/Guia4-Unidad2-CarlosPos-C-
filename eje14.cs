internal class Program
{
    private static void Main(string[] args)
    {
        int num1;
        int num2;
        int menor;
        int mayor;
        int suma = 0;

        Console.WriteLine("numeros enteros");

        Console.Write("primer numero: ");
        num1 = int.Parse(Console.ReadLine());

        Console.Write("segundo numero: ");
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
            suma = suma + i;
        }

        Console.WriteLine("La suma es: " + suma);

        Console.ReadKey();
    }
}