using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Card_EF_IDAL
{
    public interface IBaseDal<T> where T:class,new()
    {
        IList<T> GetListAll();

    }
}
