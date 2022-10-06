using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S_Bridge.Bridge
{
    public class ImplementacionV2 : IBridge
    {
        public void ListarProductos(Dictionary<string, double> pProductos)
        {
            foreach(KeyValuePair<string, double> keyValuePair in pProductos)
            {
                if (keyValuePair.Key[0] == 'C') Console.ForegroundColor = ConsoleColor.Green;
                if (keyValuePair.Key[0] == 'M') Console.ForegroundColor = ConsoleColor.Red;
                if (keyValuePair.Key[0] == 'D') Console.ForegroundColor = ConsoleColor.Yellow;

                Console.WriteLine($"{keyValuePair.Key}, {keyValuePair.Value}");
            }

        }

        public void MostrarTotales(Dictionary<string, double> pProductos)
        {
            double total = 0; 
            double totalm = 0;
            double totalc = 0;
            double totald = 0;
            int cantidad = 0;

            foreach (KeyValuePair<string, double> p in pProductos)
            {
                //primer letra
                total += p.Value;
                if(p.Key[0] == 'C') totalc += p.Value;
                if(p.Key[0] == 'M') totalm += p.Value;
                if(p.Key[0] == 'D') totald += p.Value;

                cantidad++;
            }

            Console.WriteLine($"El total de comida es {totalc}, el total de Medicamentos es {totalm}");
        }
    }
}
