﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Rutcun.Models
{
    public class Rol
    {
        [Key]
        public int PkRol { get; set; }

        public string Nombre { get; set; }
    }
}
