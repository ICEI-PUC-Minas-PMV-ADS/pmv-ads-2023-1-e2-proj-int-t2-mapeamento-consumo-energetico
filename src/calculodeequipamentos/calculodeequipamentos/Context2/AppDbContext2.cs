using Microsoft.EntityFrameworkCore;
using WebApplication2.Models;

namespace WebApplication2.Context
{
    public class AppDbContext2 : DbContext
    {
        public AppDbContext2(DbContextOptions<AppDbContext2> options) : base(options)
        {
        }

        public DbSet<EquipamentoModel> Equip { get; set; }

    }
}