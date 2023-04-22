using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

namespace L01P02_2020ML603_BLOG.Models
{
	public class usuarios
	{
		[Key]
		[Display(Name = "ID del usuario")]
		public int usuarioId { get; set; }

		[Display(Name = "ID del rol")]
		public int rolId { get; set; }

		[Display(Name = "Nombre del Usuario")]
		public string nombreUsuario { get; set; }

		[Display(Name = "Clave")]
		public string clave { get; set; }

		[Display(Name = "Nombre")]
		public string nombre { get; set; }

		[Display(Name = "Apellido")]
		public string apellido { get; set; }

	}
}
