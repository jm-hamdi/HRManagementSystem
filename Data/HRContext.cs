using Microsoft.EntityFrameworkCore;
using HRManagementSystem.Models; 

public class HRContext : DbContext
{
    public HRContext(DbContextOptions<HRContext> options) : base(options) { }

    // Define the tables (DbSet) for Employee and others
    public DbSet<Employee> Employees { get; set; }
}
