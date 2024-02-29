using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DB.Models
{
    public class Rol
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdRol { get; set; }
        [Required]
        [MaxLength(30)]
        public string Nombre { get; set; }

        [Required]
        public bool EsActivo { get; set; }

        [Required]
        public DateTime FechaRegistro {get; set;}

        [Required]
        [MaxLength(30)]
        public string CreadoPor { get; set; }
    }
}
