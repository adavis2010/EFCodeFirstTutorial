using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFCodeFirstTutorial.Models {
    
    // Inherit from DB Context
    public class AppDbContext : DbContext {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order>Orders { get; set; } //added for Order Class
        public DbSet<Item> Items { get; set; } //added for Item Class
        public DbSet<Orderline> Orderlines { get; set; }

        //default constructor
        public AppDbContext() { }
        

        protected override void OnConfiguring(DbContextOptionsBuilder builder) {
            
            if (!builder.IsConfigured) {
                //build connection string fro Sql server
                var connStr = "server=localhost\\sqlexpress;" +
                                "database=AppDb1;" +
                                "trusted_connection=true;";
                //pass in connection string
                builder.UseSqlServer(connStr);
            }
        }
        

        protected override void OnModelCreating(ModelBuilder builder) {
            builder.Entity<Customer>(cust => {
                cust.HasIndex(x => x.Code).IsUnique(true);
            });


        }

    }



}
