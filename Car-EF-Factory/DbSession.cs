using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Entity;
using Card_EF_IDAL;
using Card_EF_DAL;
namespace Car_EF_Factory
{
    public partial class DbSession:IDbSession 
    {
        private IT_CustomInfo_TBDAL _T_CustomInfo_TBDAL;
        public IT_CustomInfo_TBDAL T_CustomInfo_TBDAL
        {
            get
            {
                if (_T_CustomInfo_TBDAL == null)
                {
                    _T_CustomInfo_TBDAL = new T_CustomInfo_TBDAL();
                }
                return _T_CustomInfo_TBDAL;
            }
        }

        /// <summary>
        /// 跨世纪的。
        /// 能实现一个设计模式：  UnitWork
        /// 能够做到让开发人员可以随意在BLL层空数据库访问进行批量的提交。
        /// </summary>
        /// <returns></returns>
        public int SaveChanges()
        {
            //这里只需要调用当前线程内部的上下文SaveChange就完事了。
            DbContext dbContext = EFDbContextFactory.GetCurrentDbContext();
            return dbContext.SaveChanges();
        }
    }
}
