using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperRowerDB
{
    class RowerRentRepository
    {
     private readonly SuperRowerDbContext _dbContext;

        private DbSet<RowerRent> RowerRents => _dbContext.RowerRents;

        public RowerRentRepository(SuperRowerDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<RowerRent> GetAllUsers()
        {

            return new List<RowerRent>();
        }

        public void UpdateUser(RowerRent rowerRent)
        {

        }

        public void DeleteUser(RowerRent rowerRent)
        {

        }

        public void AddUser(RowerRent rowerRent)
        {

        }

        public void SaveChanges()
        {

        }
    }
}
