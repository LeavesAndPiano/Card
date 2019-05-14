using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Card_EF_Model;
using Card_EF_IDAL;
using System.Data.Entity;
namespace Card_EF_DAL
{
    public class BaseDal<T> : IBaseDal<T> where T:class,new()
    {
        public DbContext context = new CardDBEntities();
        public IList<T> GetListAll()
        {
            return context.Set<T>().ToList();
        }
    }
}
