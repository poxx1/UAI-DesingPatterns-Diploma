using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C_Prototype;

namespace PatronesDiploma
{
    public class Prototype
    {
        public void UI()
        {
            //Program excution

            //Prototypes creation
            CarPrototype nissanPrototype = new NissanPrototype();
            CarPrototype bmwPrototype = new BMWPrototype();
            CarPrototype porscheProtoype = new PorschePrototype();

            CarPrototype nissanSilvia = nissanPrototype.Clone(); //Me clono el auto
            nissanSilvia.Model = "Silvia";
            nissanSilvia.Color = "Blue";
            Console.WriteLine(nissanSilvia.ViewCar());
        }
    }
}
