using CoreFinanceApp.Domain;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Data.SqlClient;
using System.Configuration;

namespace CoreFinanceApp.Data
{
    public class CrossFinanceContext : DbContext
    {
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Agreement> Agreements { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<FinancialState> FinancialStates { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsbuilder)
        {
            optionsbuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["CrossFinanceContext"].ConnectionString
                );

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var property in modelBuilder.Model.GetEntityTypes()
               .SelectMany(t => t.GetProperties())
               .Where(p => p.ClrType == typeof(decimal)))
            {
                property.Relational().ColumnType = "decimal(10, 2)";
                property.Relational().DefaultValue = null;
            }
        }
    }
}
