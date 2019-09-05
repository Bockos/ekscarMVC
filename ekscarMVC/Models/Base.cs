namespace ekscarMVC.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Base : DbContext
    {

        public DbSet<Users> Users { get; set; }

        public Base(): base("name=EkscarConnectionString")
        {
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
