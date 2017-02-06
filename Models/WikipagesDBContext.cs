using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Wikipages.Models
{
    public class WikipagesDBContext : DbContext
    {
        public virtual DbSet<Business> Businesses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=WikipagesDB;integrated security=True");
        }
    }
}
