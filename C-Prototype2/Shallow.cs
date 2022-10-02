using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Prototype2
{
    //https://www.youtube.com/watch?v=dfBbUACMEO8 HDleon
    public class Shallow //Superficial
    {
        public void UserInterface()
        {
            Animal Oveja1 = new Animal();
            Oveja1.Patas = 4;
            Oveja1.Nombre = "Oveja Original";

            //Dos maneras diferentes de definir el tipo
            Animal Oveja2 = (Animal)Oveja1.Clone();
            //Animal Oveja2 = Oveja1 as Animal;
            Oveja2.Nombre = "Oveja Dolly";

            Console.WriteLine($"Se logro clonar con exito. {Oveja2.Nombre} de {Oveja1.Nombre}");
        }
    }

    public class Animal : ICloneable
    { 
        public int Patas { get; set; }  
        public string Nombre { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
