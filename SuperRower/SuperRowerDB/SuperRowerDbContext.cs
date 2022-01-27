using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperRowerDB
{
    public class SuperRowerDbContext : IdentityDbContext
    {
        public SuperRowerDbContext(DbContextOptions options) : base(options)
        {

        }



        public DbSet<Customer> Customers { get; set; }
        public DbSet<RowerPrice> Prices { get; set; }
        public DbSet<RowerRent> RowerRents { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
    
    }
}
