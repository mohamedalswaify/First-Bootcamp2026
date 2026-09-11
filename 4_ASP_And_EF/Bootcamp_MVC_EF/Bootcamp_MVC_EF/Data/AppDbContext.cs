using Bootcamp_MVC_EF.Models;
using Microsoft.EntityFrameworkCore;


namespace Bootcamp_MVC_EF.Data
{
    public class AppDbContext :DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) :base(options)
        {
        }
         
        public DbSet<Employee> Employees { get; set; } 



        }
}
