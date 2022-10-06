using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Builder2.Entidades
{
    public class Cancion
    {
        private string nombreCancion;
        private int duracionSegundos;

        public string NombreCancion
        {
            get { return nombreCancion; }
            set { nombreCancion = value; }
        }

        public int DuracionSegundos
        {
            get { return duracionSegundos; }
            set { duracionSegundos = value; }
        }
    }
}
