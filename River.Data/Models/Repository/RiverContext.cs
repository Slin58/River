using River.Data.Models.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using Microsoft.Extensions.Configuration.Json;

namespace River.Data.Models.Repository
{
    public class RiverContext : DbContext
    {
        public RiverContext() 
        { 
        }

        public DbSet<User> Users { get; set; }
        public DbSet<University> University { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            if(!optionBuilder.IsConfigured)
            {
                IConfiguration configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
                var connectionString = configuration
                    .GetConnectionString("RiverContext");
                optionBuilder.UseSqlServer(connectionString);
                base.OnConfiguring(optionBuilder);
            }
        }
    }
}
