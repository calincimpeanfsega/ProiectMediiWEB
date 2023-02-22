using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyWebApp.Models;


namespace MyWebApp.Data
{
    public class MyWebAppContext : DbContext
    {
        internal IEnumerable<object> Category;

        public MyWebAppContext(DbContextOptions<MyWebAppContext> options)
            : base(options)
        {
        }

        public DbSet<MyWebApp.Models.Product> Product { get; set; } = default!;

        public DbSet<MyWebApp.Models.Brand> Brand { get; set; }

        public DbSet<MyWebApp.Models.Admin> Admin { get; set; }

        public DbSet<MyWebApp.Models.Client> Client { get; set; }

        public DbSet<MyWebApp.Models.Buying> Buying { get; set; }
      /*  public DbSet<MyWebApp.Models.Admin> Admin { get; set; }
        public DbSet<MyWebApp.Models.Buying> Buying { get; set; }
        public DbSet<MyWebApp.Models.Category> Category { get; set; }
        public DbSet<MyWebApp.Models.Client> Client { get; set; } */


    }
}
