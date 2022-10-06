using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using S_Proxy.Business;
using S_Proxy.Entities;
using S_Proxy.Proxy;

namespace S_Proxy.UserInterface
{
    public class PrintConsole
    {
        public void UserInterface()
        {
            try
            {
                IRepository repo = new CustomerRepositoryProxy();

                Session.CanSave = true;
                Session.CanGetAll = true;

                Customer c1 = new Customer("Client 1");
                Customer c2 = new Customer("Client 2");

                repo.Save(c1);
                repo.Save(c2);

                foreach (var c in repo.GetAll())
                {
                    Console.WriteLine($"Customer: {c.Name}");
                }
            }
            catch (Exception ex)
            { 
                Console.WriteLine(ex.Message);
            }
        }
    }
}
