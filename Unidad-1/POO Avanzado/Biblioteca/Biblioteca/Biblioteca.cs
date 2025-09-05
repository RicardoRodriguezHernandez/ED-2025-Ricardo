using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    internal class Biblioteca
    {
		private DateTime _dtmPrestamo;

		public DateTime Prestamo
		{
			get { return _dtmPrestamo; }
			set { _dtmPrestamo = value; }
		}

		private DateTime _dtmDevolucion;

		public DateTime Devolucion
		{
			get { return _dtmDevolucion; }
			set { _dtmDevolucion = value; }
		}

	}
}
