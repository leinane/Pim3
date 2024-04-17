using Microsoft.EntityFrameworkCore;
using Pim3.Models;

namespace Pim3.Data
{
    public class AplicationDbContext: DbContext

    {
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options) : base(options) 
        {

        }

        public DbSet<EmprestimosModel> Emprestimos { get; set;}

    }
}
