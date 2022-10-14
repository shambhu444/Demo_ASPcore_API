using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace Demo_ASPcore_API.Model
{
    public class EmplDBcontext : DbContext
    {
        public EmplDBcontext(DbContextOptions<EmplDBcontext> options) :
             base(options)
        {
            
        }

        public DbSet<Employee>? Employees { get; set; }
    }
}
