using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using S_Proxy.Business;
using S_Proxy.Entities;

namespace S_Proxy.Proxy
{
    public class CustomerRepository : IRepository
    {
        //Aca podria estar la conexion a la base de datos. con sus querys y esas locuras
        IList<Customer> _customers;
        public CustomerRepository() {
            _customers = new List<Customer>();
        }

        public IList<Customer> GetAll()
        {
            return _customers;
        }

        public void Save(Customer customer)
        {
            _customers.Add(customer);
        }
    }
}
