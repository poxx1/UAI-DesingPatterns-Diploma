using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C_Builder2.Builder;
using C_Builder2.Entidades;

namespace C_Builder2
{
    public class Director
    {
        //Este vendria a ser el director

        public void UserInterface()
        {
            //Define atribs
            int numeroDeCancion = 1;

            string nombre = "Meddle";
            double precio  = 30;
            int stock = 2;

            string nombreArtista = "Roger Waters, David Gilmoure, Nick Mason, Rick Wright.";
            string descripcionArtista = "Pink Floyd";
            Autor autor = new Autor(nombreArtista, descripcionArtista);

            string descripcionGenero = "Progressive Rock";
            Genero genero = new Genero(descripcionGenero);

            string nombreMaterialDiscografico = "Echoes";
            TipoMaterialDiscografico tipoMaterialDiscografico = new TipoMaterialDiscografico(nombreMaterialDiscografico);

            List<Cancion> canciones = new List<Cancion>();
            Cancion cancion1 = new Cancion();
            string nombreCancion = "Echoes";
            int duracionSegundos = 1412; //Literalmente 23 min
            cancion1.NombreCancion = nombreCancion;
            cancion1.DuracionSegundos = duracionSegundos;
            canciones.Add(cancion1);

            Cancion cancion2 = new Cancion();
            nombreCancion = "San Tropez";
            duracionSegundos = 223;
            cancion1.NombreCancion = nombreCancion;
            cancion1.DuracionSegundos = duracionSegundos;
            canciones.Add(cancion2);

            Cancion cancion3 = new Cancion();
            nombreCancion = "Seamus";
            duracionSegundos = 135;
            cancion1.NombreCancion = nombreCancion;
            cancion1.DuracionSegundos = duracionSegundos;
            canciones.Add(cancion3);

            //Builder
            MaterialDiscograficoBuilder builderMaterialDiscografico = new MaterialDiscograficoBuilder();
            MaterialDiscografico materialDiscografico = builderMaterialDiscografico
                .ConNombre(nombre)
                .TienePrecio(precio)
                .EnStock(stock)
                .ComoAutor(autor)
                .ComoCanciones(canciones)
                .ComoGenero(genero)
                .ComoTipoMaterialDiscografico(tipoMaterialDiscografico)
                .BuildMaterialDiscografico(); //Esto esta para el orto pensado


            materialDiscografico.showData(); //Deberia escribir las propiedades del disco
        }
    }
}
