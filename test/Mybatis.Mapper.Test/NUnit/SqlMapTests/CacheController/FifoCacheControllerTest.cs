using Mybatis.Mapper.Configuration.Cache;
using Mybatis.Mapper.Configuration.Cache.Fifo;
using NUnit.Framework;

namespace Mybatis.Mapper.Test.NUnit.SqlMapTests.CacheController
{
	/// <summary>
	/// Description résumée de FifoCacheControllerTest.
	/// </summary>
	[TestFixture]
	public class FifoCacheControllerTest : LruCacheControllerTest
	{

		protected override ICacheController GetController() 
		{
			return new FifoCacheController();
		}
	}
}
