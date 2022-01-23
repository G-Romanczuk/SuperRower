using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperRowerDB
{
    public class TransactionRepository : BaseRepository<Transaction>, ICrudRepository<Transaction>, ITransactionRepository
    {
        public TransactionRepository(SuperRowerDbContext dbContext) : base(dbContext) { }
        protected override DbSet<Transaction> DbSet => _dbContext.Transactions;

        public void Create(Transaction Transaction) => DbSet.Add(Transaction);
        public void Delete(Transaction Transaction) => DbSet.Remove(DbSet.Where(x => x.TransactionID == Transaction.TransactionID).FirstOrDefault());
        public Transaction GetById(int id) => DbSet.FirstOrDefault(x => x.TransactionID == id);
        public void Update(Transaction Transaction)
        {
            var foundTransaction = DbSet.Where(x => x.TransactionID == Transaction.TransactionID).FirstOrDefault();
            if (foundTransaction == null)
            {
                Create(Transaction);
            }
            else
            {
                foundTransaction.StartDate = Transaction.StartDate;
                foundTransaction.EndDate = Transaction.EndDate;
            }
        }
    } 
}