using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Prototype
{
    public class NissanPrototype : CarPrototype
    {
        public override CarPrototype Clone()
        {
            return (PorschePrototype)this.MemberwiseClone();
        }

        public override string ViewCar()
        {
            return $"Nissan {_model}, color: {_color}";
        }

    }
}
