using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Card_EF_DAL;
using Card_EF_Model;
using Card_EF_IBLL;
using Car_EF_Factory;
using System.Linq.Expressions;

namespace Card_EF_BILL
{
    public partial class T_CustomInfo_TBService : BaseService<T_CustomInfo_TB>,IT_CustomInfo_TBService
    {
        public T_CustomInfo_TB Add(T_CustomInfo_TB input)
        {
            throw new NotImplementedException();
        }

        public int Add(IEnumerable<T_CustomInfo_TB> input)
        {
            throw new NotImplementedException();
        }

        public bool Delete(long id)
        {
            throw new NotImplementedException();
        }

        public int Delete(List<long> ids)
        {
            throw new NotImplementedException();
        }

        public int Delete(params long[] ids)
        {
            throw new NotImplementedException();
        }

        public bool Exists(long EntityID)
        {
            throw new NotImplementedException();
        }

        public IQueryable<dynamic> GetListByPage<TKey>(Expression<Func<T_CustomInfo_TB, dynamic>> selectLambda, Expression<Func<T_CustomInfo_TB, bool>> whereLambda, Expression<Func<T_CustomInfo_TB, TKey>> orderLambda, int pageSize, int pageIndex, out int total, bool isAsc)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T_CustomInfo_TB> GetListByPage<TKey>(Expression<Func<T_CustomInfo_TB, T_CustomInfo_TB>> selectLambda, Expression<Func<T_CustomInfo_TB, bool>> whereLambda, Expression<Func<T_CustomInfo_TB, TKey>> orderLambda, int pageSize, int pageIndex, out int total, bool isAsc)
        {
            throw new NotImplementedException();
        }

        public IQueryable<dynamic> GetListByPageBase<TKey>(Expression<Func<T_CustomInfo_TB, dynamic>> selectLambda, Expression<Func<T_CustomInfo_TB, bool>> whereLambda, Expression<Func<T_CustomInfo_TB, TKey>> orderLambda, bool isAsc)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T_CustomInfo_TB> GetListByPageBase<TKey>(Expression<Func<T_CustomInfo_TB, T_CustomInfo_TB>> selectLambda, Expression<Func<T_CustomInfo_TB, bool>> whereLambda, Expression<Func<T_CustomInfo_TB, TKey>> orderLambda, bool isAsc)
        {
            throw new NotImplementedException();
        }

        public T_CustomInfo_TB GetModel(long id)
        {
            throw new NotImplementedException();
        }

        public IList<T_CustomInfo_TB> GetModel(List<long> ids)
        {
            throw new NotImplementedException();
        }

        public object GetSQLResult(string sql)
        {
            throw new NotImplementedException();
        }

        public int Savechanges()
        {
            throw new NotImplementedException();
        }

        public override void SetCurrentDAL()
        {
            CurrentDal = DbSession.T_CustomInfo_TBDAL;
        }

        public bool Update(T_CustomInfo_TB model)
        {
            throw new NotImplementedException();
        }

        public int Update(IEnumerable<T_CustomInfo_TB> modelList)
        {
            throw new NotImplementedException();
        }
    }


}
