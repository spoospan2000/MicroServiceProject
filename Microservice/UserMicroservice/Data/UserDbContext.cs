using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserMicroservice.Data.Entities;

namespace UserMicroservice.Data
{
    public class UserDbContext:DbContext
    {
        public DbSet<User> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = LAPTOP-HDHO2R7F\\MSSQLSERVER01; Database = Microservice; Integrated security = true");
        }
    }
}
