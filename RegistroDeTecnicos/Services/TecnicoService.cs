using RegistroDeTecnicos.DAL;
using RegistroDeTecnicos.Models;
using SQLitePCL;
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

	public async Task<bool> Existe(int TecnicoId)
	{
		return await _context.Tecnicos.AnyAsync(p => p.TecnicosId == TecnicoId);
	}
}
