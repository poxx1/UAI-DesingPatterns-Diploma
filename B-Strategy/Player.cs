using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_Strategy
{
    public class Player
    {
        Weapon _strategy; //Agregattion
        
        public void ChangeStrategy(Weapon strategy)
        {
            if (strategy == null) throw new Exception("There is no weapon selected");
            _strategy = strategy;
        }
        public string Name { get; set; }

        public void FireWeapon() 
        {
            if (_strategy == null) Console.WriteLine("Weapon not available");
            Console.WriteLine(_strategy.FireWeapon());
        }
    }
}
