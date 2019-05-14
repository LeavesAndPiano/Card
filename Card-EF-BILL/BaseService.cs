using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Card_EF_IDAL;
using Car_EF_Factory;
namespace Card_EF_BILL
{
    public abstract class BaseService<T> where T : class,new()
    {
        public IDbSession DbSession =  DbSessionFactory.GetCurrentDbSession();

        public IBaseDal<T> CurrentDal;

        //要求所有的业务方法在执行之前必须给当前的CurrentDal 赋值。
        //构造函数是在实例创建的时候就已经  执行了。
        public BaseService()
        {
            //执行给当前CurrentDal赋值。
            //强迫子类给当前类的CurrentDal属性赋值。
            SetCurrentDAL();//调用了一个抽象方法。
        }

        //纯抽象方法：子类必须重写此方法。
        public abstract void SetCurrentDAL();

        public IList<T> GetListAll()
        {
            return CurrentDal.GetListAll();
        }



    }
}
