internal class Program
{
    private static void Main(string[] args)
    {
        double total = 0;
        int adultos = 0;
        int ninos = 0;
        int opcion = 1;
        Console.WriteLine("venta boletos");

        while (opcion != 0)
        {
            Console.WriteLine("1. Adulto Q15");
            Console.WriteLine("2. Niño Q10");
            Console.WriteLine("0. Salir");
            Console.Write("Ingrese una opcion: ");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    adultos++;
                    total = total + 15;
                    Console.WriteLine("boleto de adulto");
                    break;

                case 2:
                    ninos++;
                    total = total + 10;
                    Console.WriteLine("boleto de niño");
                    break;

                case 0:
                    Console.WriteLine("Fin de venta");
                    break;

                default:
                    Console.WriteLine("ERROR");
                    break;
            }
        }

        Console.WriteLine("-------------------");
        Console.WriteLine("Adultos: " + adultos);
        Console.WriteLine("Niños: " + ninos);
        Console.WriteLine("Total recaudado: Q" + total);

        Console.ReadKey();
    }
}