using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Card_EF_IDAL;
using System.Data.Entity;
using System.Runtime.Remoting.Messaging;
namespace Car_EF_Factory
{
    public class DbSessionFactory
    {
        public static IDbSession GetCurrentDbSession()
        {
            IDbSession dbSession = (IDbSession)CallContext.GetData("DbSession");

            if (dbSession == null)
            {
                dbSession = new DbSession();
                CallContext.SetData("DbSession", dbSession);
            }
            return dbSession;
        }
    }
}
