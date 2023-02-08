using Microsoft.EntityFrameworkCore;
using ProjectCRUD.Models;

namespace ProjectCRUD.Data
{
    public class ApplicatinDbContext : DbContext
    {

        public ApplicatinDbContext(DbContextOptions<ApplicatinDbContext> options  ) : base( options )
        {

        }

        public DbSet<Persons> Persons { get; set; }
    }
}
