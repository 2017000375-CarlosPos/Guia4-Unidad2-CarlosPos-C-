internal class Program
{
    private static void Main(string[] args)
    {
        int monedas = 0;
        int ingreso;

        Console.WriteLine("--------------");
        Console.WriteLine("Videojuego");
        Console.WriteLine("--------------");

        while (monedas < 350)
        {
            Console.Write("Ingrese monedas hasta llegar a 350: ");
            ingreso = int.Parse(Console.ReadLine());

            monedas = monedas + ingreso;

            Console.WriteLine("Monedas acumuladas: " + monedas);
        }

        Console.WriteLine("Nivel 5 desbloqueado");

        Console.ReadKey();
    }
}