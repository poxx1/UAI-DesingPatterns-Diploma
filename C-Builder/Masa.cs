using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Builder
{
    public class Masa
    {
        protected string _descripcion;
        public string Descripcion { get { return _descripcion; } }
    }

    public class AlMolde : Masa 
    {
        public AlMolde()
        {
            _descripcion = "Masa al molde";
        }
    }

    public class AlaPiedra : Masa
    {
        public AlaPiedra()
        {
            _descripcion = "Masa a la piedra";
        }
    }
    public class Integral : Masa
    {
        public Integral()
        {
            _descripcion = "Masa Integral";
        }
    }

}
