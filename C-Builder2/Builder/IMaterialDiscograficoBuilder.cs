using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C_Builder2.Entidades;

namespace C_Builder2.Builder
{
    public interface IMaterialDiscograficoBuilder
    {
        MaterialDiscograficoBuilder ConNombre(String nombre);
        MaterialDiscograficoBuilder TienePrecio(Double precio);
        MaterialDiscograficoBuilder EnStock(int stock);
        MaterialDiscograficoBuilder ComoGenero(Genero genero);
        MaterialDiscograficoBuilder ComoAutor(Autor autor);
        MaterialDiscograficoBuilder ComoTipoMaterialDiscografico(TipoMaterialDiscografico tipoMaterialDiscografico);
        MaterialDiscograficoBuilder ComoCanciones(List<Cancion> canciones);
    }
}
