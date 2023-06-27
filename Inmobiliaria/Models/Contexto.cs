using Microsoft.EntityFrameworkCore;

namespace Inmobiliaria.Models
{
    public class Contexto: DbContext
    {
        public DbSet<Clientes> Clientes { get; set; } 
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                   .SetBasePath(Directory.GetCurrentDirectory())
                   .AddJsonFile("appsettings.json")
                   .Build();
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=InmbobiliariaDataBase;Trusted_Connection=True;TrustServerCertificate=true");
        }
    }
}
