using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LFishkel.Data.Daos
{
    public abstract class AbstractRepository<TEntity> where TEntity : class
    {
        public HashSet<TEntity> GetAll() 
        {
            using (var dbContext = new DbContext("name=lfishkelEntities"))
            {
                var dbSet = dbContext.Set<TEntity>();
                return new HashSet<TEntity>(dbSet.ToArray());
            }
           
        }
    }
}
