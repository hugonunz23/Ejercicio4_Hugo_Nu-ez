using System;
using System.Collections.Generic;
using System.Text;
// HUGO FERNANDO NUÑEZ LAZO
//20241900216
namespace Ejercicio4_Hugo_Nuñez
{
    public class BicicletaElectrica : Vehiculo
    {
        private double costoEnergiaPorKm;

        public BicicletaElectrica(string placa, int capacidad, double velocidadMaxima, double costoEnergiaPorKm)
            : base(placa, capacidad, velocidadMaxima)
        {
            this.costoEnergiaPorKm = costoEnergiaPorKm;
        }

        public override double CalcularCostoViaje()
        {
            return kilometrosRecorridos * costoEnergiaPorKm;
        }

        public override void MostrarInformacion()
        {
            Console.WriteLine("Bicicleta Eléctrica");
            Console.WriteLine("Placa: " + GetPlaca());
            Console.WriteLine("Kilómetros recorridos: " + GetKilometrosRecorridos());
            Console.WriteLine("Costo total: " + CalcularCostoViaje());
            Console.WriteLine("----------------------------------");
        }
    }
}