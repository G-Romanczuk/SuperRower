using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperRowerDB
{
    class CustomerRepository
    {
        private readonly SuperRowerDbContext _dbContext;

        private DbSet<Customer> Customers => _dbContext.Customers;

        public CustomerRepository(SuperRowerDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Customer> GetAllUsers()
        {

            return new List<Customer>();
        }

        public void UpdateUser(Customer customer)
        {

        }

        public void DeleteUser(Customer customer)
        {

        }

        public void AddUser(Customer customer)
        {

        }

        public void SaveChanges()
        {

        }
    }
}

