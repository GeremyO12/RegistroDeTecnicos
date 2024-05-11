using RegistroDeTecnicos.DAL;
using RegistroDeTecnicos.Models;
using System.Linq.Expressions;

namespace RegistroDeTecnicos.Services
{
	public class TecnicoService
	{
		private readonly Contexto _contexto;
		public TecnicoService(Contexto contexto)
		{
			_contexto = contexto;
		}
	}
}
