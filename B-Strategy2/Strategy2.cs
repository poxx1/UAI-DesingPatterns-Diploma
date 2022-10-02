using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_Strategy2
{
    public class Strategy2
    {
        //Por ejemplo si tengo un servicio de WebServices con SOAP y otro con REST.
        //O por ejemplo si tengo como entrada un GET/POST/PUT.
        //O por ejemplo si tengo como entrada un JSON/XML/PLAINTEXT.

        //Busco reslver un mismo problema, pero utilizando diferentes comportamientos.

        private IWebService _service;
        public void EstablishJSONType()
        {
            this._service = new JSONStrategy();
        }
        public void EstablishXMLType()
        {
            this._service = new XMLStrategy();
        }

        public void Serialize()
        {
            this._service.serialize(); //Serializes the object with the desired type.
        }
        public void UserInterface()
        {
            Console.WriteLine("WebServices - Incoming REST request");
            Console.WriteLine("JSON type request\r\n");

            _service = new JSONStrategy();
            _service.serialize();

            Console.WriteLine("WebServices - Incoming REST request");
            Console.WriteLine("XML type request\r\n");

            _service = new XMLStrategy();
            _service.serialize();
        }
    }
}
