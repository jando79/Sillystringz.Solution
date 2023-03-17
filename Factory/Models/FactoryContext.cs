using Microsoft.EntityFrameworkCore;

namespace Factory.Models
{
  public class FactoryContext : DbContext
  {
    public DbSet<Engineer> Engineers { get; set; }
    public DbSet<Machine> Machines { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<MachineDepartment> MachineDepartments { get; set; }
    public DbSet<EngineerMachine> EngineerMachines { get; set; }

    public FactoryContext(DbContextOptions options) : base(options) { }
  }
}
