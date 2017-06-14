using Core.DAL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Context
{
    public class TheaterContext : DbContext
    {
        public TheaterContext() : base("name=TheaterContextConnectionString")
        {
        }

        public DbSet<Hall> Halls { get; set; }
        public DbSet<Movie> Movies { get; set; }

        public DbSet<Projection> Projections { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
