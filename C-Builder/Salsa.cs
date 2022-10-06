using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Builder
{
    public class Salsa
    {
        protected string _descripcion;
        public string Descripcion { get { return _descripcion; } }
    }

    public class Tomate : Salsa
    {
        public Tomate()
        {
            _descripcion = "Salsa de tomate";
        }
    }

    public class Oliva : Salsa
    {
        public Oliva()
        {
            _descripcion = "Salsa de Oliva";
        }
    }
    public class Light : Salsa
    {
        public Light()
        {
            _descripcion = "Salsa Light";
        }
    }
}
