using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_Strategy
{
    public class Rifles : Weapon
    {
        internal override string FireWeapon()
        {
            return "Bullet loaded. \r\nWeapon Fired. \r\nCapsule in chamber. \r\nEscape trigger actioned. \r\nReady to fire again.";
        }
    }
}
