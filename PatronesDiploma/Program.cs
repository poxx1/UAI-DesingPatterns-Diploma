using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using B_Strategy;
using B_Strategy2;
using C_Builder;
using C_Prototype2;
using S_Proxy.UserInterface;

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
            //Console.WriteLine("Creational Pattern - Prototype Deep \r\n");
            //UserInterface strategy = new UserInterface();
            //strategy.ProgramExcecution();
            #endregion

            #region Patron Strategy v1 (Estrategia)
            //Console.WriteLine("Behavioural Pattern - Strategy \r\n");
            //Strategy2 strategy2 = new Strategy2();
            //strategy2.UserInterface();
            #endregion

            #region Patron Builder (Constructor)
            //Console.WriteLine("Creational Pattern - Builder \r\n");
            //Director builder = new Director();
            //builder.PrintPizzas();
            #endregion

            #region Patron Proxy (Apoderado)
            Console.WriteLine("Estructural Pattern - Proxy \r\n");
            PrintConsole proxy = new PrintConsole();
            proxy.UserInterface();
            #endregion

            Console.ReadKey();
        }
    }
}
