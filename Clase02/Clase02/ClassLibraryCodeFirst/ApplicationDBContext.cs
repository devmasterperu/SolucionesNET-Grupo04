using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryCodeFirst
{
    public class ApplicationDBContext : DbContext
    {
        /*
         * DbContext sirve para configurar algunas de las características que tendrá la BD
         * Crear una propiedad DbSet, será en adelante una tabla en BD
         */
        public ApplicationDBContext() : base("connBD")
        {
        }

        public DbSet<Persona> Persona { get; set; }
        public DbSet<TipoDocumento> TipoDocumento { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
    }
}
