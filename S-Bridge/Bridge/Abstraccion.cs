using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S_Bridge.Bridge
{
    public class Abstraccion
    {
        IBridge implementacion;
        Dictionary<string, double> productos;

        //Implementacion concreta
        public Abstraccion(IBridge pImp, Dictionary<string, double> pProd)
        {
            implementacion = pImp;
            productos = pProd;  
        }

        public void MostrarTotales()
        {
            implementacion.MostrarTotales(productos);
        }

        public void Listar()
        {
            implementacion.ListarProductos(productos);
        }
    }
}
