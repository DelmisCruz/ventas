using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Escuela
{
    public class Contexto: DbContext //Herencia para utilizar bd
    {
        public Contexto(): base("RegistroEscolar")
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            Database.SetInitializer(new DatosdeInicio());
        }

        public DbSet<Estudiante> Estudiantes { get; set; } // Lista
        public DbSet<Grado> Grados { get; set; }
        public DbSet<Maestro> Maestros { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Clase> Clases { get; set; }
        public DbSet<Factura> Facturas { get; set; }
        public DbSet<Factura1> Facturas1 { get; set; }
    }
}
