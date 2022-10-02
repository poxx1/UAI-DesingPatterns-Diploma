using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_Strategy
{
    public class UserInterface
    {
        List<Weapon> _strategyList;
        Player player = new Player();

        public void ProgramExcecution()
        {
            player.Name = "L337";

            _strategyList = new List<Weapon>();
            _strategyList.Add(new Pistol());
            _strategyList.Add(new Rifles());

            Weapon weapon = _strategyList.ElementAt(0); //Pistol
            player.ChangeStrategy(weapon);

            Console.WriteLine($"Player name: {player.Name}\r\n");
            Console.WriteLine("First strategy selected. Pistol\r\n");

            player.FireWeapon();

            Console.WriteLine("\r\nSecond strategy selected. Rifle\r\n");

            weapon = _strategyList.ElementAt(1); //Rifle
            player.ChangeStrategy(weapon);
            
            player.FireWeapon();
        }
    }
}
