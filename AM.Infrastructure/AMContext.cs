using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Interfaces;
using AM.Infrastructure.Configurations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;


namespace AM.Infrastructure
{
    public class AMContext: DbContext
    {
        public DbSet<ArtificialFlower> ArtificialFlowers { get; set; }
        public DbSet<Bouquet> Bouquets { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Flower> Flowers { get; set; }
        public DbSet<NaturalFlower> NaturalFlowers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\mssqllocaldb;
              Initial Catalog=GasmiSkanderBouquet;Integrated Security=true");
            base.OnConfiguring(optionsBuilder);
        }


        public AMContext()
        {
            
        }

        public AMContext(DbContextOptions<AMContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new FlowerConfiguration());
        }
        

        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            configurationBuilder
              .Properties<DateTime>()
                  .HaveColumnType("date");
        }



    }
}
