using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S_Bridge.Bridge
{
    public interface IBridge
    {
        void MostrarTotales(Dictionary<string, double> pProductos);
        void ListarProductos(Dictionary<string, double> pProductos);
    }
}