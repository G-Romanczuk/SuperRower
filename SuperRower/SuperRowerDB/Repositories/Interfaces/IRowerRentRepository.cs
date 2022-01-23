using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperRowerDB
{
    public interface IRowerRentRepository : ICrudRepository<RowerRent>
    {
        List<RowerRent> GetAll();
        void SaveChanges();
    }
}
