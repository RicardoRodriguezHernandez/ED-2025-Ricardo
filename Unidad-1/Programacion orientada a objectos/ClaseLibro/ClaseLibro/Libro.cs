using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseLibro
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

        public override string ToString()
        {
			return("Titulo del libro: " + Titulo +
                   "\nNombre del autor: " + Autor);
        }
    }
}
