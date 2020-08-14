using Microsoft.EntityFrameworkCore;
using SMARTCUSTOMERORDER.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SMARTCUSTOMERORDER.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<UserDataTable> UserDataTables { get; set; }
        public DbSet<Products> Productsdb { get; set; }
        public DbSet<Carts> Cartsdb { get; set; }
    }
}
