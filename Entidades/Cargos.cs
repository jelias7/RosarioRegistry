using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rosario_Registry.Entidades
{
    public class Cargos
    { 
        [Key]

        public int CargoID { get; set; }
        public string Descripcion { get; set; }

        public Cargos()
        {
            CargoID = 0;
            Descripcion = string.Empty;
        }
    }
}
