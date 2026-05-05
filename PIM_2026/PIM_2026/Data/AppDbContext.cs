using Microsoft.EntityFrameworkCore;
using PIM_2026.Models;

namespace PIM_2026.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Profissional> Profissionais { get; set; }
        public DbSet<Servicos> Servicos { get; set; }
        public DbSet<Agendamento> Agendamentos { get; set; }
        public DbSet<Horariotrabalho> Horariostrabalho { get; set; }
        public DbSet<Bloqueiohorario> Bloqueioshorario { get; set; }
    }
}