﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using B_Strategy;
using B_Strategy2;
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
            //Console.WriteLine("Creational Pattern - Prototype Deep \r\n");
            //UserInterface strategy = new UserInterface();
            //strategy.ProgramExcecution();
            #endregion

            #region Patron Strategy v1 (Estrategia)
            Console.WriteLine("Behavioural Pattern - Strategy \r\n");
            Strategy2 strategy2 = new Strategy2();
            strategy2.UserInterface();
            #endregion

            Console.ReadKey();
        }
    }
}
