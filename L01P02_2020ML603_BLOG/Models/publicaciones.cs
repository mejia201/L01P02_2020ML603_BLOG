using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

namespace L01P02_2020ML603_BLOG.Models
{
    public class publicaciones
    {

        [Key]
        [Display(Name = "ID de la publicación")]
        public int publicacionId { get; set; }

        [Display(Name = "Titulo")]
        public string titulo { get; set; }

        [Display(Name = "Descripción")]
        public string descripcion { get; set; }

        [Display(Name = "ID del usuario")]
        public int usuarioId { get; set; }

    }
}
