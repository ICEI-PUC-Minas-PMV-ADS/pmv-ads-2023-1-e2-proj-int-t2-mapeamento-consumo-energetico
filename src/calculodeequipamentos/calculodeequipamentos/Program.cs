using calculodeequipamentos.Context;
using calculodeequipamentos.Repositorio;
using calculodeequipamentos.Areas.Identity.Data;
using Microsoft.EntityFrameworkCore;




#nullable disable

namespace calculodeequipamentos
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            string mySqlConnection =
            builder.Configuration.GetConnectionString("DefaultConnection");

            var connectionString = builder.Configuration.GetConnectionString("ApplicationDbContextConnection") ?? throw new InvalidOperationException("Connection string 'ApplicationDbContextConnection' not found.");

            builder.Services.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlServer(connectionString));

            builder.Services.AddDefaultIdentity<UsuarioModel>(options => options.SignIn.RequireConfirmedAccount = true)
            .AddEntityFrameworkStores<ApplicationDbContext>();

            builder.Services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer
                ("Data Source=DESKTOP-GFK2EGS\\;Initial Catalog=EquipamentosCadastrados; Integrated Security=True; Encrypt=False"));
            builder.Services.AddScoped<IEquipamentoRepositorio, EquipamentoRepositorio>();



            builder.Services.AddControllersWithViews();



            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
            app.UseAuthentication();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Equipamento}/{action=Index}/{id?}");

            app.MapRazorPages();
            app.Run();
        }
    }
}