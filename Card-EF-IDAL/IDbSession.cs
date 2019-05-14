using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Card_EF_Model;
namespace Card_EF_IDAL
{
    public interface IT_CustomInfo_TBDAL : IBaseDal<T_CustomInfo_TB>
    {
    }

    public partial interface IDbSession
    {
        IT_CustomInfo_TBDAL T_CustomInfo_TBDAL { get; }
    }
}
