

using Mybatis.Mapper.Configuration.Cache;
using NUnit.Framework;

namespace Mybatis.Mapper.Test.NUnit.SqlMapTests
{
	/// <summary>
	/// Summary description for CacheKeyTest.
	/// </summary>
	[TestFixture]
	public class CacheKeyTest
	{
		[Test]
		public void ShouldNotConsider1LAndNegative9223372034707292159LToBeEqual()
		{
			// old version of ObjectProbe gave TestClass based on these longs the same HashCode
			DoTestClassEquals(1L, -9223372034707292159L);
		}

		[Test]
		public void ShouldNotConsider1LAndNegative9223372036524971138LToBeEqual()
		{
			// current version of ObjectProbe gives TestClass based on these longs the same HashCode
			DoTestClassEquals(1L, -9223372036524971138L);
		}

		private static void DoTestClassEquals(long firstLong, long secondLong)
		{
			// Two cache keys are equal except for the parameter.
			CacheKey key = new CacheKey();

			key.Update(firstLong);

			CacheKey aDifferentKey = new CacheKey();

			key.Update(secondLong);

			Assert.IsFalse(aDifferentKey.Equals(key)); // should not be equal.
		}

		[Test]
		public void CacheKeyWithSameHashcode() 
		{
			CacheKey key1 = new CacheKey();
			CacheKey key2 = new CacheKey();

			key1.Update("HS1CS001");
			key2.Update("HS1D4001");
        /*
         The string hash algorithm is not an industry standard and is not guaranteed to produce the same behaviour between versions. 
         And in fact it does not. The .NET 2.0 CLR uses a different algorithm for string hashing than the .NET 1.1 CLR. 
        */

            Assert.Ignore("The .NET 2.0 CLR uses a different algorithm for string hashing than the .NET 1.1 CLR.");
        }

		[Test]
       

		public void CacheKeyWithTwoParamsSameHashcode() 
		{
			CacheKey key1 = new CacheKey();
			CacheKey key2 = new CacheKey();

			key1.Update("HS1CS001");
			key1.Update("HS1D4001");

			key2.Update("HS1D4001");
			key2.Update("HS1CS001");

            Assert.Ignore("The .NET 2.0 CLR uses a different algorithm for string hashing than the .NET 1.1 CLR.");
        }

	}
}
