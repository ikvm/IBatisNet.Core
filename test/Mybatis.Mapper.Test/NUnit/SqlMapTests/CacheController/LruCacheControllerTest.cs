using System.Collections;
using System.Collections.Specialized;
using Mybatis.Mapper.Configuration.Cache;
using Mybatis.Mapper.Configuration.Cache.Lru;
using NUnit.Framework;

namespace Mybatis.Mapper.Test.NUnit.SqlMapTests.CacheController
{
	/// <summary>
	/// Description r�sum�e de LruCacheControllerTest.
	/// </summary>
	[TestFixture]
	public class LruCacheControllerTest
	{
		protected virtual ICacheController GetController() 
		{
			return new LruCacheController();
		}

		[Test]
		public virtual void TestSizeOne() 
		{
			ICacheController cc = GetController();
			IDictionary props = new HybridDictionary();
			props.Add("CacheSize", "1");
			cc.Configure(props);

			string testKey = "testKey";
			string testVal = "testVal";
			cc[testKey] = testVal;
			Assert.AreEqual(testVal, cc[testKey] );
			
			string testKey2 = "testKey2";
			string testVal2 = "testVal2";
			cc[testKey2] = testVal2;
			Assert.AreEqual(testVal2, cc[testKey2]);

			Assert.IsNull(cc[testKey]);
		}

		[Test]
		public void TestGetAndPutObject() 
		{
			ICacheController cc = GetController();
			string testKey = "testKey";
			string testVal = "testVal";

			Assert.AreEqual(cc[testKey], null);

			cc[testKey] = testVal;
			Assert.AreEqual(cc[testKey], testVal);

			cc[testKey] = null;
			Assert.AreEqual(cc[testKey], null);
		}

		[Test]
		public void TestRemoveObject() 
		{
			ICacheController cc = GetController();
			string testKey = "testKey";
			string testVal = "testVal";

			Assert.AreEqual(cc[testKey], null);

			cc[testKey] = testVal;
			Assert.AreEqual(cc[testKey], testVal);

			cc.Remove(testKey);
			Assert.AreEqual(cc[testKey], null);
		}

		[Test]
		public void TestFlush() 
		{
			ICacheController cc = GetController();
			string testKey = "testKey";
			string testVal = "testVal";

			Assert.AreEqual(cc[testKey], null);

			cc[testKey] = testVal;
			Assert.AreEqual(cc[testKey], testVal);

			cc.Flush();
			Assert.AreEqual(cc[testKey], null);
		}
	}
}
