using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Rutcun.Models
{
    public class Calle
    {
        [Key]
        public int PkCalle { get; set; }

        public string Nombre { get; set; }
    }
}
