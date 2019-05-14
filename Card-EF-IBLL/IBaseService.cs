using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

using Card_EF_Model; 
namespace Card_EF_IBLL
{
    public interface IBaseService<T> where T : class, new()
    {

        #region SQL查询
        object GetSQLResult(string sql);
        #endregion
        /// <summary>
        /// 分页查询
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="TKey"></typeparam>
        /// <param name="selectLambda"></param>
        /// <param name="whereLambda"></param>
        /// <param name="orderLambda"></param>
        /// <param name="pageSize"></param>
        /// <param name="pageIndex"></param>
        /// <param name="total"></param>
        /// <param name="isAsc"></param>
        /// <returns></returns>
        IQueryable<dynamic> GetListByPage<TKey>(Expression<Func<T, dynamic>> selectLambda, Expression<Func<T, bool>> whereLambda, Expression<Func<T, TKey>> orderLambda, int pageSize, int pageIndex, out int total, bool isAsc);
        IQueryable<T> GetListByPage<TKey>(Expression<Func<T, T>> selectLambda, Expression<Func<T, bool>> whereLambda, Expression<Func<T, TKey>> orderLambda, int pageSize, int pageIndex, out int total, bool isAsc);

        IList<T> GetListAll();


        IQueryable<dynamic> GetListByPageBase<TKey>(Expression<Func<T, dynamic>> selectLambda, Expression<Func<T, bool>> whereLambda, Expression<Func<T, TKey>> orderLambda, bool isAsc);
        IQueryable<T> GetListByPageBase<TKey>(Expression<Func<T, T>> selectLambda, Expression<Func<T, bool>> whereLambda, Expression<Func<T, TKey>> orderLambda, bool isAsc);


        /// <summary>
        /// save a entity
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="input"></param>
        /// <returns></returns>
        T Add(T input);

        /// <summary>
        /// 批量添加
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="input"></param>
        /// <returns></returns>
        int Add(IEnumerable<T> input);

        /// <summary>
        /// 删除一个ID对应的实体
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="id"></param>
        /// <returns></returns>
        bool Delete(long id);

        /// <summary>
        /// 更新ID集合中所有的实体
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="long"></typeparam>
        /// <param name="ids"></param>
        /// <returns></returns>
        int Delete(List<long> ids);

        int Delete(params long[] ids);

        /// <summary>
        /// 更新单个实体
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="long"></typeparam>
        /// <param name="model"></param>
        /// <returns></returns>
        bool Update(T model);

        /// <summary>
        /// 批量更新
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="modelList"></param>
        /// <returns></returns>
        int Update(IEnumerable<T> modelList);

        /// <summary>
        /// 根据ID查询实体
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="id"></param>
        /// <returns></returns>
        T GetModel(long id);

        /// <summary>
        /// 根据ID集合查询实体集合
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="ids"></param>
        /// <returns></returns>
        IList<T> GetModel(List<long> ids);

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        bool Exists(long EntityID);


        //IQueryable<T> GetModel(List<long> ids);

        int Savechanges();
    }

    public partial interface IT_CustomInfo_TBService : IBaseService<T_CustomInfo_TB>
    {
    }
}
