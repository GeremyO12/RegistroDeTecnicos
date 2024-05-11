using System.ComponentModel.DataAnnotations;

namespace RegistroDeTecnicos.Models
{
	public class Tecnicos
	{
		[Key]
		public int TecnicoId { get; set; }
		[Required(ErrorMessage = "El campo descripci&oacute;n es obligatorio")]
		public string Descripcion { get; set; }
	}
}
