internal class Program
{
    private static void Main(string[] args)
    {
        double pesoAcum = 0;
        double pesoManzana;
        int contador = 0;

        Console.WriteLine("--------------");
        Console.WriteLine("Bacula");
        Console.WriteLine("--------------");

        while (pesoAcum < 1000)
        {
            Console.Write("Pon el peso de la manzana entre 100 y 300 gramos: ");
            pesoManzana = double.Parse(Console.ReadLine());

            if (pesoManzana >= 100 && pesoManzana <= 300)
            {
                pesoAcum = pesoAcum + pesoManzana;
                contador++;

                Console.WriteLine("Peso acumulado: " + pesoAcum + " gramos");
            }
            else
            {
                Console.WriteLine("ERROR");
            }
        }

        Console.WriteLine("1000 gramos.");
        Console.WriteLine("Total: " + contador);

        Console.ReadKey();
    }
}