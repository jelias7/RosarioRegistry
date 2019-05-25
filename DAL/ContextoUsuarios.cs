using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Threading.Tasks;
using Rosario_Registry.Entidades;

namespace Rosario_Registry.DAL
{
    public class ContextoUsuarios : DbContext
    {
        public DbSet<Usuarios> User { get; set; }
        
        public ContextoUsuarios() : base("ConStr") { }
    }
}
