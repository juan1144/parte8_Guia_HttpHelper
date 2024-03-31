using Microsoft.EntityFrameworkCore;
namespace parte8_Guia_HttpHelper.Models
{
    public class parte9_GuiaDbContext : DbContext
    {
        public parte9_GuiaDbContext(DbContextOptions<parte9_GuiaDbContext> options) : base(options) { }

        public DbSet<formulario> formulario { get; set; }
    }
}
