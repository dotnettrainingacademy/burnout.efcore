using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BurnOut.Data
{
    class FitDbContext : DbContext
    {
        public FitDbContext()
        {

        }

        // Configuring Database
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Connecting with Database
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\ProjectsV13;Initial Catalog=BurnOut;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

        // Configuring or Building Tables
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }

        // Entities => Tables
    }
}
