using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperRowerDB
{
    public interface ITransactionRepository : ICrudRepository<Transaction>
    {
        List<Transaction> GetAll();
        void SaveChanges();
    }
}
