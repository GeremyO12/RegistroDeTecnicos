using Microsoft.EntityFrameworkCore;
using RegistroDeTecnicos.Models;

namespace RegistroDeTecnicos.DAL
{
	public class Contexto : DbContext
	{
		public Contexto(DbContextOptions<Contexto> options)
		     : base(options){ }
		public DbSet<Tecnicos> Tecnicos { get; set; }
	}
}
