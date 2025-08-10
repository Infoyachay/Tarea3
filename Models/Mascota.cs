using System.ComponentModel.DataAnnotations;

namespace Tarea3Brandon.Models
{
    public class Mascota
    {
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; } = string.Empty;
        [Required]
        public string Especie { get; set; } = string.Empty;
        public string Raza { get; set; } = string.Empty;
        public int Edad { get; set; }
        public string Propietario { get; set; } = string.Empty;
    }
}
