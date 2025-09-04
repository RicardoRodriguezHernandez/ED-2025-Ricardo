using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseAutos
{
    internal class Auto
    {
		private string _strMarca;

		public string Marca
		{
			get { return _strMarca; }
			set { _strMarca = value; }
		}

		private string _strModelo;

		public string Modelo
		{
			get { return _strModelo; }
			set { _strModelo = value; }
		}

		private double _dblVelocidad;

		public double Velocidad
		{
			get { return _dblVelocidad; }
			set { _dblVelocidad = value; }
		}
		public Auto(string marca, string modelo)
		{
			Marca = marca;
			Modelo = modelo;
			Velocidad = 0;
		}
        public void Acelerar(int incremento)
        {
            Velocidad += incremento;
        }
        public void Frenar(int decremento)
        {
            Velocidad -= decremento;
        }
        public string MostrarVelocidad()
        {
            return("Velocidad actual: "+ Velocidad + "km/h");
        }
        ~Auto()
        {
            Console.WriteLine("Auto " + Marca + ""+ Modelo + "destruido.");
        }
    }
}
