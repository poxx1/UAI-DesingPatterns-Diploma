using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using S_Proxy.Business;
using S_Proxy.Entities;

namespace S_Proxy.Proxy
{
    public class CustomerRepositoryProxy : IRepository
    {
        IRepository _real;

        //Aca el proxy lo que soluciona es agrega seguridad a lo que ya tenia el CustomerRepository.
        //Onda con el singleton y la otras boludeces.

        public IList<Customer> GetAll()
        {
            if (_real == null) _real = new CustomerRepository(); //Singleton

            if (Session.CanGetAll)
            {
                return _real.GetAll();
            }
            else
            {
                throw new UnauthorizedAccessException(); //Onda no tenes acceso.
            }
        }

        public void Save(Customer customer)
        {
            if (_real == null) _real = new CustomerRepository(); //Singleton

            if (Session.CanSave)
            {
                _real.Save(customer);
            }
            else
            {
                throw new UnauthorizedAccessException(); //Onda no tenes acceso.
            }
        }
    }
}
