using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Threading.Tasks;
using Rosario_Registry.Entidades;

namespace Rosario_Registry.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Usuarios> User { get; set; }
        public DbSet<Cargos> cargos { get; set; }
        public DbSet<Analisis> analisis { get; set; }
        public DbSet<TiposAnalisis> tiposanalisis { get; set; }
        public DbSet<AnalisisDetalle> analisisdetalle { get; set; }
        
        public Contexto() : base("ConStr") { }
    }
}
