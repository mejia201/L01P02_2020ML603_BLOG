using Microsoft.AspNetCore.DataProtection.KeyManagement;
using System.ComponentModel.DataAnnotations;

namespace L01P02_2020ML603_BLOG.Models
{
	public class roles
	{
		[Key]
		[Display(Name = "ID del rol")]
		public int rolId { get; set; }

		[Display(Name = "Nombre del rol")]
		public string rol { get; set; }

	}
}
