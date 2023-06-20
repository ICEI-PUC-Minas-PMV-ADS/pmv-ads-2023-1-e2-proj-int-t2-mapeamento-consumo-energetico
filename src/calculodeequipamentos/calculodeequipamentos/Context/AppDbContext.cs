

using calculodeequipamentos.Models;
using Microsoft.EntityFrameworkCore;


namespace calculodeequipamentos.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<EquipamentoEletronico> Equipamentoss { get; set; }

    }
}