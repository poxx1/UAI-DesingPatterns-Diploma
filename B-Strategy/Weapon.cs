using System;

namespace B_Strategy
{
    public abstract class Weapon
    {
        internal abstract string FireWeapon(); //Can't define behavior of an Abstract class type.

        public override string ToString()
        {
            return this.GetType().Name; //Shows weapon name
        }
    }
}