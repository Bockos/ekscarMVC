using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ekscarMVC.Models
{
    public partial class Base : DbContext
    {

        public DbSet<Region> Region { get; set; }
        public DbSet<City> City { get; set; }

        public DbSet<CarModel> CarModel { get; set; }
        public DbSet<CarBrand> CarBrand { get; set; }

        public Base() : base("name=EkscarConnectionString")
        {
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
