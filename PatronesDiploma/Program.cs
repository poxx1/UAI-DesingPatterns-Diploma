using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using B_Strategy;
using C_Prototype2;

namespace PatronesDiploma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Patron Prototype Shallow (Superficial)
            //Console.WriteLine("Creational Pattern - Prototype Shallow");
            //Shallow shallow = new Shallow();
            //shallow.UserInterface();
            #endregion

            #region Patron Prototype Deep (Profundo)
            //Console.WriteLine("Creational Pattern - Prototype Deep \r\n");
            //Deep deep = new Deep();
            //deep.UserInterface();
            #endregion

            #region Patron Strategy (Estrategia)
            Console.WriteLine("Creational Pattern - Prototype Deep \r\n");
            UserInterface ui = new UserInterface();
            ui.ProgramExcecution();
            #endregion

            Console.ReadKey();
        }
    }
}
