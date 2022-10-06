using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C_Builder2.Entidades;

namespace C_Builder2.Builder
{
    public class MaterialDiscograficoBuilder : IMaterialDiscograficoBuilder
    {
        private String nombre;
        private Double precio;
        private int stock;

        private Genero genero;
        private Autor autor;
        private TipoMaterialDiscografico tipoMaterialDiscografico;
        private List<Cancion> canciones;

        public MaterialDiscograficoBuilder ComoAutor(Autor autor)
        {
            this.autor = autor;
            return this;
        }

        public MaterialDiscograficoBuilder ComoCanciones(List<Cancion> canciones)
        {
            this.canciones = canciones;
            return this;
        }

        public MaterialDiscograficoBuilder ComoGenero(Genero genero)
        {
            this.genero = genero;
            return this;
        }

        public MaterialDiscograficoBuilder ComoTipoMaterialDiscografico(TipoMaterialDiscografico tipoMaterialDiscografico)
        {
            this.tipoMaterialDiscografico = tipoMaterialDiscografico;
            return this;
        }

        public MaterialDiscograficoBuilder ConNombre(string nombre)
        {
            this.nombre = nombre;
            return this;
        }

        public MaterialDiscograficoBuilder EnStock(int stock)
        {
            this.stock = stock;
            return this;
        }

        public MaterialDiscograficoBuilder TienePrecio(double precio)
        {
            this.precio = precio;
            return this;
        }

        internal MaterialDiscografico BuildMaterialDiscografico()
        {
            Console.WriteLine("trash");
            return new MaterialDiscografico();
        }
    }
}
