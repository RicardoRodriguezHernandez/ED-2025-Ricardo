using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenDiagnostico2
{
	internal class Rectangulo
	{
		private double _dblAncho;

		public double Ancho
		{
			get { return _dblAncho; }
			set { _dblAncho = value; }
		}

		private double _dblAlto;

		public double Alto
		{
			get { return _dblAlto; }
			set { _dblAlto = value; }
		}

		public Rectangulo(double dblAncho)
		{
			Ancho = dblAncho;
		}

		public double CalcularArea()
		{
			return (Alto *  Ancho);
		}
		public double CalcularPerimetro()
		{
			return (2 * (Alto + Ancho));
		}
	}
}
