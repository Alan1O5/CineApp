using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
    public class CNPeliculas
    
        {
            public static DataTable Listar()
            {
                CDPeliculas Datos = new CDPeliculas();
                return Datos.Listar();
            }

            public static string Guardar(string nombre, int duracion, string clasificacion, string genero, string idioma)
            {
                CDPeliculas Datos = new CDPeliculas();
                Datos.Nombre = nombre;
                Datos.Duracion = duracion;
                Datos.Clasificacion = clasificacion;
                Datos.Genero = genero;
                Datos.Idioma = idioma;

                return Datos.Insertar(Datos);
            }

            public static string Editar(int idpelicula, string nombre, int duracion, string clasificacion, string genero, string idioma)
            {
                CDPeliculas Datos = new CDPeliculas();
                Datos.Idpelicula = idpelicula;
                Datos.Nombre = nombre;
                Datos.Duracion = duracion;
                Datos.Clasificacion = clasificacion;
                Datos.Genero = genero;
                Datos.Idioma = idioma;

                return Datos.Editar(Datos);
            }

            public static string Eliminar(int idpelicula)
            {
                CDPeliculas Datos = new CDPeliculas();
                Datos.Idpelicula = idpelicula;

                return Datos.Eliminar(Datos);
            }

            public static DataTable BuscarNombre(string textoBuscar)
            {
                CDPeliculas Datos = new CDPeliculas();
                Datos.Buscar = textoBuscar;

                return Datos.BuscarNombre(Datos);
            }
        }
    }


