using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperRowerDB
{
    class TransactionRepository
    {
        private readonly SuperRowerDbContext _dbContext;

        private DbSet<Transaction> Transactions => _dbContext.Transactions;

        public TransactionRepository(SuperRowerDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Transaction> GetAllUsers()
        {

            return new List<Transaction>();
        }

        public void UpdateUser(Transaction transaction)
        {

        }

        public void DeleteUser(Transaction transaction)
        {

        }

        public void AddUser(Transaction transaction)
        {

        }

        public void SaveChanges()
        {

        }
    }
}
