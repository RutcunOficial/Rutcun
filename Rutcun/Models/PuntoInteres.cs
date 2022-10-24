using System.ComponentModel.DataAnnotations;

namespace Rutcun.Models
{
    public class PuntoInteres
    {
        [Key]
        public int PkPunto { get; set; }
        public string Nombre { get; set; }
        public string Coordenadas { get; set; }
    }
}
