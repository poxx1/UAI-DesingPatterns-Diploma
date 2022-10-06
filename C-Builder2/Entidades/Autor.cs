using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Builder2.Entidades
{
    public class Autor
    {
        private string nombreArtista;
        private string descripcionArtista;
        public Autor(string nombreArista, string descripcionArtista)
        {
            this.nombreArtista = nombreArista;
            this.descripcionArtista = descripcionArtista;
        }

        public string NombreArtista
        {
            get { return nombreArtista; }
            set { nombreArtista = value; }
        }

        public string DescripcionArtista
        {
            get { return descripcionArtista; }
            set { descripcionArtista = value; }
        }
    } 
}
