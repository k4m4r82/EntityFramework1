using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using RetailUsingEntityFramework.Models.Mapping;

namespace RetailUsingEntityFramework.Models
{
    public partial class RetailContext : DbContext
    {
        static RetailContext()
        {
            Database.SetInitializer<RetailContext>(null);
        }

        public RetailContext()
            : base("Name=RetailContext")
        {
        }

        public DbSet<Supplier> Suppliers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new SupplierMap());
        }
    }
}
