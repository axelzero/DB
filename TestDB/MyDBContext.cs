using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDB
{
    public class MyDBContext : DbContext
    {
        public MyDBContext() : base("DBConnectionString")
        {

        }

        public DbSet<Magazin> Magazins { get; set; }
        public DbSet<Tovar> Tovars { get; set; }
    }
}