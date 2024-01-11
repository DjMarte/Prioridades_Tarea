using System.ComponentModel.DataAnnotations;

namespace PrioridadesTarea.Models
{
    public class Prioridades
    {
        [Key]
        public int PrioridadId { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        public string? Descripcion { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        public int DiasCompromiso { get; set; }


    }
}
