using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    internal class Libro
    {
		private string _strTitulo;

		public string Titulo
		{
			get { return _strTitulo; }
			set { _strTitulo = value; }
		}

		private string _strAutor;

		public string Autor
		{
			get { return _strAutor; }
			set { _strAutor = value; }
		}

		private string _strISBN;

		public string ISBN
		{
			get { return _strISBN; }
			set { _strISBN = value; }
		}

	}
}
