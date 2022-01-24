using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperRowerDB
{
    public class RowerRentRepository : BaseRepository<RowerRent>, ICrudRepository<RowerRent>, IRowerRentRepository
    {
        public RowerRentRepository(SuperRowerDbContext dbContext) : base(dbContext) { }
        protected override DbSet<RowerRent> DbSet => _dbContext.RowerRents;

        public void Create(RowerRent RowerRent)
        {
            DbSet.Add(RowerRent);
            SaveChanges();
        }

        public void Delete(RowerRent RowerRent)
        {
            DbSet.Remove(DbSet.Where(x => x.RowerRentID == RowerRent.RowerRentID).FirstOrDefault());
            SaveChanges();
        }

        public RowerRent GetById(int id) => DbSet.FirstOrDefault(x => x.RowerRentID == id);

        public void Update(RowerRent RowerRent)
        {
            var foundRowerRent = DbSet.Where(x => x.RowerRentID == RowerRent.RowerRentID).FirstOrDefault();
            if (foundRowerRent == null)
            {
                Create(RowerRent);
            }
            else
            {
                foundRowerRent.Country = RowerRent.Country;
                foundRowerRent.Model= RowerRent.Model;
                foundRowerRent.Producent = RowerRent.Producent;
                foundRowerRent.Type = RowerRent.Type;
                foundRowerRent.Year = RowerRent.Year;
                SaveChanges();
            }
        }
    }
}