using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperRowerDB
{
    class RowerPriceRepository
    {
        private readonly SuperRowerDbContext _dbContext;

        private DbSet<RowerPrice> RowerPrices => _dbContext.Prices;

        public RowerPriceRepository(SuperRowerDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<RowerPrice> GetAllUsers()
        {

            return new List<RowerPrice>();
        }

        public void UpdateUser(RowerPrice rowerPrice)
        {

        }

        public void DeleteUser(RowerPrice rowerPrice)
        {

        }

        public void AddUser(RowerPrice rowerPrice)
        {

        }

        public void SaveChanges()
        {

        }
    }
}
