using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

namespace L01P02_2020ML603_BLOG.Models
{
    public class comentarios
    {

        [Key]
        [Display(Name = "ID del comentario")]
        public int cometarioId { get; set; }

        [Display(Name = "ID de la publicación")]
        public int publicacionId { get; set; }

        [Display(Name = "Comentario")]
        public string? comentario { get; set; }

        [Display(Name = "ID del usuario")]
        public int usuarioId { get; set; }

    }
}
