using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rutcun.Models
{
    public class Usuario
    {
        [Key]
        public int PkUser { get; set; }
        public string Nombre { get; set; }
        public string User { get; set; }
        public string Contraseña { get; set; }

        [ForeignKey("FkRol")]
        public Rol Rol { get; set; }
    }
}
