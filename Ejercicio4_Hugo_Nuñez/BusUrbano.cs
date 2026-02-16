using System;
using System.Collections.Generic;
using System.Text;
// HUGO FERNANDO NUÑEZ LAZO
//20241900216
namespace Ejercicio4_Hugo_Nuñez
{
    public class BusUrbano : Vehiculo
    {
        private double tarifaPorKm;

        public BusUrbano(string placa, int capacidad, double velocidadMaxima, double tarifaPorKm)
            : base(placa, capacidad, velocidadMaxima)
        {
            this.tarifaPorKm = tarifaPorKm;
        }

        public override double CalcularCostoViaje()
        {
            return kilometrosRecorridos * tarifaPorKm;
        }

        public override void MostrarInformacion()
        {
            Console.WriteLine("Bus Urbano");
            Console.WriteLine("Placa: " + GetPlaca());
            Console.WriteLine("Kilómetros recorridos: " + GetKilometrosRecorridos());
            Console.WriteLine("Costo total: " + CalcularCostoViaje());
            Console.WriteLine("----------------------------------");
        }
    }
}
