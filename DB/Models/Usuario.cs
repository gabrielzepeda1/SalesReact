using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DB.Models
{
    public class Usuario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdUsuario { get; set; }
        public int IdRol { get; set; }

        [Required]
        [MaxLength(30)]
        public string NombreUsuario { get; set; }

        [Required]
        [MaxLength(30)]
        public string Password { get; set; }

        [Required]
        public bool EsActivo { get; set; }

        [Required]
        public DateTime FechaRegistro { get; set; }

        [Required]
        [MaxLength(30)]
        public string CreadoPor { get; set; }

        [ForeignKey("IdRol")]
        public virtual Rol Rol { get; set; }
    }
}
