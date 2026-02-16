using System;
using System.Collections.Generic;
using System.Text;
// HUGO FERNANDO NUÑEZ LAZO
//20241900216
namespace Ejercicio4_Hugo_Nuñez
{
    public abstract class Vehiculo
    {
        private string placa;
        private int capacidadPasajeros;
        private double velocidadMaxima;
        protected double kilometrosRecorridos;

        public Vehiculo(string placa, int capacidadPasajeros, double velocidadMaxima)
        {
            this.placa = placa;
            this.capacidadPasajeros = capacidadPasajeros;
            this.velocidadMaxima = velocidadMaxima;
            this.kilometrosRecorridos = 0;
        }

        public void RecorrerKilometros(double km)
        {
            kilometrosRecorridos += km;
        }

        public abstract double CalcularCostoViaje();
        public abstract void MostrarInformacion();

        public string GetPlaca()
        {
            return placa;
        }

        public double GetKilometrosRecorridos()
        {
            return kilometrosRecorridos;
        }


    }
}
