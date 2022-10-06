using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Builder2.Entidades
{
    public class TipoMaterialDiscografico
    {
        private string nombreTipoMaterialDiscografico;
        public TipoMaterialDiscografico(string nombreTipoMaterialDiscografico)
        {
            this.nombreTipoMaterialDiscografico = nombreTipoMaterialDiscografico;
        }

        public string NombreTipoMaterialDiscografico
        {
            get { return nombreTipoMaterialDiscografico; }
            set { nombreTipoMaterialDiscografico = value; }
        }
    }
}
