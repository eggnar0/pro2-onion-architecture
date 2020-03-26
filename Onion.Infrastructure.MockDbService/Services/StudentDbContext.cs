using Microsoft.EntityFrameworkCore;
using Onion.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Onion.Infrastructure.MockDbService.Services
{
    class StudentDbContext : DbContext
    {
        public StudentDbContext()
        {

        }

        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=db-mssql;Initial Catalog=s15410;Integrated Security=True");
        }
    }
}
