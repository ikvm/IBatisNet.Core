using System;

using Mybatis.Common;
using Mybatis.DataAccess; //DaoManager, DaoSession
using Mybatis.DataAccess.Interfaces; //IDao

namespace Mybatis.DataAccess.Test.Implementations
{
	/// <summary>
	/// Description résumée de BaseDao.
	/// </summary>
	public class BaseDao: IDao
	{
		/// <summary>
		/// Get the sesion.
		/// </summary>
		/// <returns>A DaoSession</returns>
		protected DaoSession GetContext()
		{
			IDaoManager daoManager = DaoManager.GetInstance(this);
			return (daoManager.LocalDaoSession as DaoSession);
		}
	}
}
