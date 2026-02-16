// HUGO FERNANDO NUÑEZ LAZO
//20241900216

using System;

namespace Ejercicio4_Hugo_Nuñez
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("********************************************");
            Console.WriteLine("***   Nombre: Hugo Fernando Nuñez Lazo   ***");
            Console.WriteLine("***         Cuenta: 20241900216          ***");
            Console.WriteLine("********************************************");

            BusUrbano bus = new BusUrbano("BUS123", 40, 80, 2.5);
            Taxi taxi = new Taxi("TAXI456", 4, 120, 10, 3);
            BicicletaElectrica bici = new BicicletaElectrica("BICI789", 1, 25, 1.5);

            // Viaje 1 → 10 km
            bus.RecorrerKilometros(10);
            taxi.RecorrerKilometros(10);
            bici.RecorrerKilometros(10);

            // Viaje 2 → 30 km
            bus.RecorrerKilometros(30);
            taxi.RecorrerKilometros(30);
            bici.RecorrerKilometros(30);

            bus.MostrarInformacion();
            taxi.MostrarInformacion();
            bici.MostrarInformacion();

            Console.ReadLine();
        }
    }
}