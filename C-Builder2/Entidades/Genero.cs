using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Builder2.Entidades
{
    public class Genero
    {
        private string descripcionGenero;

        public Genero(string descripcionGenero)
        {
            this.descripcionGenero = descripcionGenero;
        }

        public string DescripcionGenero
        {
            get { return descripcionGenero;}
            set { descripcionGenero = value;}
        }
    }
}
