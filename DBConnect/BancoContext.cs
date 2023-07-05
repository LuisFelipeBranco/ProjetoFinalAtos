using Microsoft.EntityFrameworkCore;
using TeplanConsultoria.Models;

namespace TeplanConsultoria.DBConnect
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) : base (options)
        {
        }

        public DbSet<PropriedadeModel> Propriedade { get; set; }
    }
}
