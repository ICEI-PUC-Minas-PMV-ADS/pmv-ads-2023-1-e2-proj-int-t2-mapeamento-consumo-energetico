using Microsoft.EntityFrameworkCore;

using WebApplication2.Models;

namespace WebApplication2.Data
{
    public class BancoContext2 : DbContext
    {
        public BancoContext2(DbContextOptions<BancoContext2> options) : base(options)
        {
        }

        public DbSet<EquipamentoModel> Equip { get; set; }

    }
}