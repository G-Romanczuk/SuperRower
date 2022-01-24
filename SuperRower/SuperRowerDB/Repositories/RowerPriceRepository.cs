using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperRowerDB
{
    
        public class RowerPriceRepository : BaseRepository<RowerPrice>, IRowerPriceRepository, ICrudRepository<RowerPrice>
        {
            public RowerPriceRepository(SuperRowerDbContext dbContext) : base(dbContext) { }
            protected override DbSet<RowerPrice> DbSet => _dbContext.Prices;

        public void Create(RowerPrice RowerPrice)
        {
            DbSet.Add(RowerPrice);
            SaveChanges();
        }

        public void Delete(RowerPrice RowerPrice)
        {
            DbSet.Remove(DbSet.Where(x => x.RowerPriceID == RowerPrice.RowerPriceID).FirstOrDefault());
            SaveChanges();
        }

        public RowerPrice GetById(int id)
        {
            return DbSet.FirstOrDefault(x => x.RowerPriceID == id);
            SaveChanges();
        }

        public void Update(RowerPrice RowerPrice)
            {
            var foundRowerPrice = DbSet.Where(x => x.RowerPriceID == RowerPrice.RowerPriceID).FirstOrDefault();
           
                foundRowerPrice.Price = RowerPrice.Price;
                SaveChanges();
            
            }
        }
    }
