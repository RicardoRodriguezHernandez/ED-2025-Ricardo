using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenDiagnostico2
{
    internal class Cuadrado: Rectangulo
    {

        private double dblLado;

        public double Lado
        {
            get { return dblLado; }
            set { dblLado = value; }
        }

        public Cuadrado(double dblAncho) :base(dblAncho) 
        {
            Lado = dblAncho;
        }

        public double CalcularArea()
        {
            return (2 * Lado);
        }

        public double CalcularPerimetro()
        {
            return (4 * Lado);
        }
    }
}
