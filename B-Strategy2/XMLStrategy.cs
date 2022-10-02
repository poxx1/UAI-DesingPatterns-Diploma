using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_Strategy2
{
    public class XMLStrategy : IWebService
    {
        public void serialize()
        {
            //XML.Serialize(string);
            Console.WriteLine("XML Serialized\r\n");
        }
    }
}
