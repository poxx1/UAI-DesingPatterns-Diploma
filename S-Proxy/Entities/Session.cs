using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S_Proxy.Entities
{
    public static class Session
    {
        //Simula un usuario con privilegios de acceso. alto wtf
        public static bool CanSave { get; set; }
        public static bool CanGetAll { get; set; }
    }
}
