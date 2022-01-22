using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using SuperRowerDB;

namespace SuperRower.database
{
    public abstract class BaseRepository<Entity> where Entity : class
    {
        protected SuperRowerDbContext _dbContext;

        protected abstract DbSet<Entity> DbSet { get; }

        public BaseRepository(SuperRowerDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Entity> GetAll()
        {
            var list = new List<Entity>();

            var entities = DbSet;

            foreach (var entity in entities)
                list.Add(entity);

            return list;
        }

        public void SaveChanges()
        {
            _dbContext.SaveChanges();
        }
    }
}
