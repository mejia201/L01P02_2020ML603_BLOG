using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

namespace L01P02_2020ML603_BLOG.Models
{
    public class calificaciones
    {

        [Key]
        [Display(Name = "ID de la calificación")]
        public int calificacionId { get; set; }

        [Display(Name = "ID de la publicación")]
        public int publicacionId { get; set; }

        [Display(Name = "ID del usuario")]
        public int usuarioId { get; set; }

        [Display(Name = "ID de la calificación")]
        public int calificacion { get; set; }

    }
}
