using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperRowerDB
{
   public interface ICustomerRepository : ICrudRepository<Customer>
    {
        List<Customer> GetAll();
        void SaveChanges();
    }
}
