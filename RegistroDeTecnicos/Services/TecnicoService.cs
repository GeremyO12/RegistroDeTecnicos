using Microsoft.EntityFrameworkCore;
using RegistroDeTecnicos.DAL;
using RegistroDeTecnicos.Models;
using System.Linq.Expressions;

namespace RegistroDeTecnicos.Services
{
	public class TecnicoService
	{
		private readonly Contexto _context;
		public TecnicoService(Contexto contexto)
		{
			_context = contexto;
		}

        public async Task<bool> Existe(int TecnicoId)
        {
            return await _context.Tecnicos
                .AnyAsync(p => p.TecnicoId == TecnicoId);
        }

        public async Task<bool> Insertar(Tecnicos Tecnicos)
        {
            _context.Tecnicos.Add(Tecnicos);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<bool> Modificar(Tecnicos Tecnicos)
        {
            _context.Update(Tecnicos);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<bool> Guardar(Tecnicos Tecnico)
        {
            if (!await Existe(Tecnico.TecnicoId))
                return await Insertar(Tecnico);
            else
                return await Modificar(Tecnico);
        }

        public async Task<bool> Eliminar(int id)
        {
            var tecnicos = await _context.Tecnicos.
                Where(P => P.TecnicoId == id).ExecuteDeleteAsync();
            return tecnicos > 0;
        }

        public async Task<Tecnicos?> Buscar(int id)
        {
            return await _context.Tecnicos
                .AsNoTracking().FirstOrDefaultAsync(P => P.TecnicoId == id);
        }

        public List<Tecnicos> Listar(Expression<Func<Tecnicos, bool>> criterio)
        {
            return _context.Tecnicos
                .AsNoTracking()
                .Where(criterio)
                .ToList();
        }
    }
}
