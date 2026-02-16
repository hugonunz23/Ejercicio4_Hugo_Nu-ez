using System;
using System.Collections.Generic;
using System.Text;
// HUGO FERNANDO NUÑEZ LAZO
//20241900216
namespace Ejercicio4_Hugo_Nuñez
{
    public class Taxi : Vehiculo
    {
        private double tarifaBase;
        private double tarifaPorKm;

        public Taxi(string placa, int capacidad, double velocidadMaxima, double tarifaBase, double tarifaPorKm)
            : base(placa, capacidad, velocidadMaxima)
        {
            this.tarifaBase = tarifaBase;
            this.tarifaPorKm = tarifaPorKm;
        }

        public override double CalcularCostoViaje()
        {
            return tarifaBase + (kilometrosRecorridos * tarifaPorKm);
        }

        public override void MostrarInformacion()
        {
            Console.WriteLine("Taxi");
            Console.WriteLine("Placa: " + GetPlaca());
            Console.WriteLine("Kilómetros recorridos: " + GetKilometrosRecorridos());
            Console.WriteLine("Costo total: " + CalcularCostoViaje());
            Console.WriteLine("----------------------------------");
        }
    }
}