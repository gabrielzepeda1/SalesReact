using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DB.Models
{
    public class ItemMenu
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdItemMenu { get; set; }

        public int IdMenu { get; set; }

        [Required]
        [MaxLength(30)]
        public string Nombre { get; set; }

        [Required]
        public bool EsActivo { get; set; }

        [Required]
        public DateTime FechaRegistro { get; set; } = DateTime.Now;

        [Required]
        [MaxLength(30)]
        public string CreadoPor { get; set; } = "SuperAdmin";

        [ForeignKey("IdMenu")]
        public virtual Menu Menu { get; set; }
    }
}