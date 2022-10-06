using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Builder
{
    public class Agregado
    {
        protected string _descripcion;
        public string Descripcion { get { return _descripcion; } }
    }

    public class Oregano : Agregado
    {
        public Oregano()
        {
            _descripcion = "Agregado de Oregano";
        }
    }

    public class Anchoas : Agregado
    {
        public Anchoas()
        {
            _descripcion = "Agregado de Anchoas";
        }
    }
    public class Berenjenas : Agregado
    {
        public Berenjenas()
        {
            _descripcion = "Agregado de Berenjenas";
        }
    }
}
