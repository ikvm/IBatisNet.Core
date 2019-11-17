using Mybatis.Mapper.Configuration.Cache;
using Mybatis.Mapper.Configuration.Cache.Memory;
using NUnit.Framework;

namespace Mybatis.Mapper.Test.NUnit.SqlMapTests.CacheController
{
	/// <summary>
	/// Description résumée de MemoryCacheControllerTest.
	/// </summary>
	[TestFixture]
	public class MemoryCacheControllerTest: LruCacheControllerTest
	{

		protected override ICacheController GetController() 
		{
			return new MemoryCacheControler();
		}

		[Test]
		public override void TestSizeOne() 
		{
			// This is not relevant for this model
		}
	}
}
