using API111.Entities;
using Microsoft.EntityFrameworkCore;

namespace API111.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> dbContextOptions) : base(dbContextOptions) 
    {
    }

    public DbSet<Employee> Employees { get; set; }
   
}
