internal class Program
{
    private static void Main(string[] args)
    {
        int autos;
        int cajones = 200;

        Console.WriteLine("--------------");
        Console.WriteLine("ESTACIONAMIENTO");
        Console.WriteLine("--------------");

        while (cajones > 0)
        {
            Console.Write("Ingrese cantidad de autos: ");
            autos = int.Parse(Console.ReadLine());

            cajones = cajones - autos;

            if (cajones > 0)
            {
                Console.WriteLine("Cajones disponibles: " + cajones);
            }
            else
            {
                Console.WriteLine("Ya no hay cajones disponibles");
            }
        }

        Console.ReadKey();
    }
}