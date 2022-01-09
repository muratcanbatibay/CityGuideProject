using Microsoft.EntityFrameworkCore;
using SehirRehberi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SehirRehberi.Data
{
    public class DataContext:DbContext
    {

        public DataContext( DbContextOptions<DataContext> options):base(options)
        {
           

        }
        public DbSet<Value> Values { get; set; }
        public DbSet<Photo> Photos { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<City> Cities { get; set; }

    }
}
