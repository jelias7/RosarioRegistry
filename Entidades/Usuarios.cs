﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rosario_Registry.Entidades
{
    public class Usuarios
    {
        [Key]
        public int UsuarioID { get; set; }
        public string Nombres { get; set; }
        public string Email { get; set; }
        public string NivelUsuario { get; set; }
        public string Usuario { get; set; }
        public DateTime FechaIngreso { get; set; }
        public int Clave { get; set; }

        public Usuarios()
        {
            UsuarioID = 0;
            Nombres = string.Empty;
            Email = string.Empty;
            NivelUsuario = string.Empty;
            Usuario = string.Empty;
            FechaIngreso = DateTime.Now;
            Clave = 0;
        }
    }

}

