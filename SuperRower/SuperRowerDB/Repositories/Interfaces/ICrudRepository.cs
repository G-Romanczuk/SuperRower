using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperRowerDB
{
    public interface ICrudRepository<Entity> where Entity : class
    {
        void Create(Entity entity);
        Entity GetById(string id);
        void Delete(Entity entity);
        void Update(Entity entity);

    }
}
