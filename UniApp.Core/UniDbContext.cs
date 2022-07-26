using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniApp.Core
{
    public class UniDbContext : DbContext
    {
        public UniDbContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options) 
        {
            options.UseSqlServer(@"Server=.\;Database=UniApp_Db;Trusted_connection=true");
        }

        public DbSet<Faculty> Faculties { get; set; }
        public DbSet<Cathedra> Cathedras { get; set; }
    }
}
