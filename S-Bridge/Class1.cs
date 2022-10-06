using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using S_Bridge.Bridge;

namespace S_Bridge
{
    public class BridgeTruchisimo
    {
        public void UserInterface()
        {
            Dictionary<string,double> productos = new Dictionary<string,double>();

            productos.Add("Prod1", 21.2);
            productos.Add("Prod2", 31.3);
            productos.Add("Prod3", 41.4);

            //PAtron bridge
            Abstraccion bridge = new Abstraccion(new Implementacion(), productos);
            //Abstraccion bridge = new Abstraccion(new ImplementacionV2(), productos);

            //Fijate que el bridge llama a cualquier ade las 2 versiones, como los metodos no cambian, puedo usar cualquiera.

            //El cliente se comunica solo con la abstraccion y esa abstr, es la que hace todo.
            bridge.MostrarTotales();
            bridge.Listar();
        }
    }
}
