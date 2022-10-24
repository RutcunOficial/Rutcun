using System.ComponentModel.DataAnnotations;

namespace Rutcun.Models
{
    public class TipoTrasporte
    {
        [Key]
        public int PkTipo { get; set; }
        public string Nombre { get; set; }
    }
}
