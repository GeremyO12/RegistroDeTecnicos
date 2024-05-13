using System.ComponentModel.DataAnnotations;

namespace RegistroDeTecnicos.Models
{
	public class Tecnicos
	{
		[Key]
		public int TecnicoId { get; set; }
		[Required(ErrorMessage = "El campo descripcion es obligatorio")]
		public string? Descripcion { get; set; }

        [Required(ErrorMessage = "Los dias de comprimiso deben ser validos")]
        [Range(1, 31, ErrorMessage = "Los dias de comprimisos deben de estar entre 1 y 31")]
        public int DiasCompromiso { get; set; }
    }
}
