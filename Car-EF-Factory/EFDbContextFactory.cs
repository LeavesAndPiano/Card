using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Entity;
using System.Runtime.Remoting.Messaging;
using Card_EF_Model;
namespace Car_EF_Factory
{
    public class EFDbContextFactory
    {
        /// <summary>
        /// 线程内实例唯一
        /// </summary>
        /// <returns></returns>
        public static DbContext GetCurrentDbContext()
        {
            DbContext db = (DbContext)CallContext.GetData("DbContext");
            if (db == null)
            {
                db = new CardDBEntities();
                CallContext.SetData("DbContext", db);
            }
            return db;
        }
    }
}
