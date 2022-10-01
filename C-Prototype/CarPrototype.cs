using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Prototype
{
    public abstract class CarPrototype
    {
        protected string _color;
        protected string _model;

        public string Color { set => _color = value; }  
        public string Model { set => _model = value;}

        public abstract CarPrototype Clone();
        public abstract string ViewCar();
    }
}
