using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sistema.Models;

namespace Sistema.Data
{
    public class DbInitializer
    {
        public static void Initialize(SistemaContext context)
        {
            context.Database.EnsureCreated();  // Este metodo Crea Automaticamente la Base de datos.

            // Buscar si existen datos en la tabla categoría.

            if (context.Categoria.Any()) // Valida si existen registros en la tabla Categoría. Utiliza el metodo Any().
            {
                return; // Retorna los registros junto a la DB.
            }

            var categorias = new Categoria[] // Instancia de la clase Categoria, se encuentra en la carpeta Models.
                {
                    new Categoria{Nombre = "Programación", Descripcion = "Curso de programación", Estado = true},
                    new Categoria{Nombre = "AngularJS 5", Descripcion = "Curso de Angular", Estado = true}
                };

            foreach (Categoria c in categorias)
            {
                context.Categoria.Add(c);
            }
            context.SaveChanges();

        }
    }
}
