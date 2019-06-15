﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rosario_Registry.Entidades
{
    public class Analisis
    {
        [Key]
        public int AnalisisId { get; set; }
        public DateTime Fecha { get; set; }
        public int UsuarioId { get; set; }

        public virtual List<AnalisisDetalle> Resultado { get; set; }
        public Analisis()
        {
            AnalisisId = 0;
            Fecha = DateTime.Now;
            UsuarioId = 0;
            Resultado = new List<AnalisisDetalle>();
        }
    }


}
