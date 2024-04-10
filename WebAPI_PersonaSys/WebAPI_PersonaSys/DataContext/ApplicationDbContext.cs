using Microsoft.EntityFrameworkCore;
using WebAPI_PersonaSys.Models;

namespace WebAPI_PersonaSys.DataContext
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {
            
        }

        public DbSet<FuncionarioModel> Funcionarios { get; set; }
    }
}
