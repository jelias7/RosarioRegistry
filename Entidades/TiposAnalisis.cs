using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rosario_Registry.Entidades
{
    public class TiposAnalisis
    {
        public int TipoId { get; set; }
        public string Descripcion { get; set; }

        public TiposAnalisis()
        {
            TipoId = 0;
            Descripcion = string.Empty;
        }
    }
}
