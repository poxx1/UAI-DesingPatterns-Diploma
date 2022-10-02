using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_Strategy
{
    public class Pistol : Weapon
    {
        internal override string FireWeapon()
        {
            return "Bullet loaded. \r\nWeapon Fired. \r\nNew bullet in chamber. \r\nReady to fire again.";
        }
    }
}
