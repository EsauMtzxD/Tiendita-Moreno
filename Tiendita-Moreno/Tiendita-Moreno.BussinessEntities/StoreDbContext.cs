using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tiendita_Moreno.BussinessEntities
{

    [DbConfigurationType(typeof(MySql.Data.Entity.MySqlEFConfiguration))]
    public class StoreDbContext : DbContext
    {

        public StoreDbContext() : base(StoreDbContext.getConnectionStringName())
        {   }

        public DbSet<Cut> Cuts { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<DetailSale> DetailSales { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public static string getConnectionStringName()
        {

            ConnectionStringSettingsCollection connections = ConfigurationManager.ConnectionStrings;
            String CONNECTIONSTRING = String.Empty;

            if (connections.Count != 0)
            {
                foreach (ConnectionStringSettings connection in connections)
                {
                    CONNECTIONSTRING = connection.Name;
                }
            }

            return CONNECTIONSTRING;

        }

    }
}
