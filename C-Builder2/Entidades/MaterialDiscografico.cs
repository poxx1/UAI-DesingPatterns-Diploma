using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Builder2.Entidades
{
    public class MaterialDiscografico
    {
        private String nombre;
        private Double precio;
        private int stock;
        private int duracionTotalSegundos;

        private Genero genero;
        private Autor autor;
        private TipoMaterialDiscografico tipoMaterialDiscografico;
        private List<Cancion> canciones;

        public string Nombre { get; private set; }
        public double Precio { get; private set; }
        public int Stock { get; private set; }
        public int DuracionTotalSegundos { get; private set; }
        public Genero Genero { get; private set; }
        public Autor Autor { get; private set; }
        public TipoMaterialDiscografico TipoMaterialDiscografico { get; private set; }
        public List<Cancion> Canciones { get; private set; }

        public MaterialDiscografico BuildMaterialDiscografico()
        {
            return new MaterialDiscografico()
            {
                Nombre = this.nombre,
                Precio = this.precio,
                Stock = this.stock,
                DuracionTotalSegundos = calcularDuracionTotalSegundos(),
                Genero = this.genero,
                Autor = this.autor,
                TipoMaterialDiscografico = this.tipoMaterialDiscografico,
                Canciones = this.canciones
            };
        }

        private int calcularDuracionTotalSegundos()
        {
            int duracionTotal = 0;

            foreach (var c in canciones) {
                duracionTotal += c.DuracionSegundos;
            }

            return duracionTotal;
        }

        public void showData()
        {
            
        }
    }
}
