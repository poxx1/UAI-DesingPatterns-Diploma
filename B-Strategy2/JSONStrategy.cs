using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_Strategy2
{
    public class JSONStrategy : IWebService
    {
        public void serialize()
        {
            //Newtonsoft.JSON.Serialize(string);
            Console.WriteLine("JSON Serialized\r\n");
        }
    }
}
