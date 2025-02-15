using System;
using System.Collections;

using NUnit.Framework;

using Mybatis.Mapper.Test.NUnit;
using Mybatis.Mapper.Test.Domain;

namespace Mybatis.Mapper.Test.NUnit.SqlMapTests.Oracle
{
	/// <summary>
	/// Summary description for StatementTest.
	/// </summary>
	[TestFixture] 
	[Category("Oracle")]
	public class StatementTest : BaseTest
	{
		
		#region SetUp & TearDown
		/// <summary>
		/// SetUp
		/// </summary>
		[SetUp] 
		public void Init() 
		{
			InitScript( sqlMap.DataSource, ScriptDirectory + "category-init.sql" );
		}

		/// <summary>
		/// TearDown
		/// </summary>
		[TearDown] 
		public void Dispose()
		{ /* ... */ } 

		#endregion

		#region Specific tests for Oracle

		/// <summary>
		/// Test an insert with sequence key.
		/// </summary>
		[Test] 
		public void TestInsertSequenceViaInsertQuery()
		{
			Category category = new Category();
			category.Name = "toto";
			category.Guid = Guid.NewGuid();

			int key = (int)sqlMap.Insert("InsertCategory", category);
			Assert.AreEqual(1, key);
		}

		/// <summary>
		/// Test Insert Via Insert Statement.
		/// </summary>
		[Test] 
		public void TestInsertViaInsertStatement()
		{
			Category category = new Category();
			category.Name = "toto";
			category.Guid = Guid.NewGuid();

			int key = (int)sqlMap.Insert("InsertCategoryViaInsertStatement", category);
			Assert.AreEqual(1, key);
		}

		/// <summary>
		/// Test guid column/field.
		/// </summary>
		[Test] 
		public void TestGuidColumn()
		{
			Category category = new Category();
			category.Name = "toto";
			category.Guid = Guid.NewGuid();

			int key = (int)sqlMap.Insert("InsertCategoryViaInsertStatement", category);

			Category categoryTest = (Category)sqlMap.QueryForObject("GetCategory", key);
			Assert.AreEqual(key, categoryTest.Id);
			Assert.AreEqual(category.Name, categoryTest.Name);
			Assert.AreEqual(category.Guid, categoryTest.Guid);
		}

		/// <summary>
		/// Test Insert Category Via ParameterMap.
		/// </summary>
		[Test] 
		public void TestInsertCategoryViaParameterMap()
		{
			Category category = new Category();
			category.Name = "Cat";
			category.Guid = Guid.NewGuid();

			int key = (int)sqlMap.Insert("InsertCategoryViaParameterMap", category);
			Assert.AreEqual(1, key);
		}

		/// <summary>
		/// Test Update Category with Extended ParameterMap
		/// </summary>
		[Test] 
		public void TestUpdateCategoryWithExtendParameterMap()
		{
			Category category = new Category();
			category.Name = "Cat";
			category.Guid = Guid.NewGuid();

			int key = (int)sqlMap.Insert("InsertCategoryViaParameterMap", category);
			category.Id = key;

			category.Name = "Dog";
			category.Guid = Guid.NewGuid();

			sqlMap.Update("UpdateCategoryViaParameterMap", category);

			Category categoryRead = null;
			categoryRead = (Category) sqlMap.QueryForObject("GetCategory", key);

			Assert.AreEqual(category.Id, categoryRead.Id);
			Assert.AreEqual(category.Name, categoryRead.Name);
			Assert.AreEqual(category.Guid.ToString(), categoryRead.Guid.ToString());
		}
		#endregion


	}
}
