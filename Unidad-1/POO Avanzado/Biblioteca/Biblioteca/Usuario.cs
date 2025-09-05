using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    internal class Usuario
    {
		private string _strNombre;

		public string Nombre
		{
			get { return _strNombre; }
			set { _strNombre = value; }
		}

		private int _strID;

		public int ID
		{
			get { return _strID; }
			set { _strID = value; }
		}
	}
}
