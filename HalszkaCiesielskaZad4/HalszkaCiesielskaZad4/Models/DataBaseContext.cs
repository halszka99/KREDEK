using System.Data.Entity;
using HalszkaCiesielskaZad4.Models.Entities;

namespace HalszkaCiesielskaZad4.Models
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext() : base("ConnectionString")
        {

        }
        // Database tables
        public DbSet<Animal> Animals { get; set; }
        public DbSet<AnimalClass> AnimalClasses { get; set; }
        public DbSet<Area> Areas { get; set; }
        public DbSet<Cage> Cages { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Food> Foods { get; set; }
        public DbSet<Login> Logins { get; set; }
        public DbSet<Position> Positions { get; set; }
    }
}
