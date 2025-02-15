
using System;
using System.Collections;
using System.Collections.Specialized;
using System.Threading;
using System.Configuration;

using NUnit.Framework;

using Mybatis.Common;
using Mybatis.Common.Utilities;
using Mybatis.Mapper;
using Mybatis.Mapper.MappedStatements;

using Mybatis.Mapper.Test;
using Mybatis.Mapper.Test.Domain;

namespace Mybatis.Mapper.Test.NUnit.SqlMapTests
{
	/// <summary>
	/// To test statement namespaces,
	/// set your SqlMap config settings attribute 
	/// useStatementNamespaces="true" 
	/// before running Namespace Tests.
	/// </summary>
	[TestFixture] 
	[Category("StatementNamespaces")]
	public class StatementNamespaceTest : BaseTest
	{
		#region SetUp & TearDown

		/// <summary>
		/// SetUp
		/// </summary>
		[SetUp] 
		public void Init() 
		{
			InitScript( sqlMap.DataSource, ScriptDirectory + "account-init.sql" );
			InitScript( sqlMap.DataSource, ScriptDirectory + "order-init.sql" );
			InitScript( sqlMap.DataSource, ScriptDirectory + "line-item-init.sql" );
			InitScript( sqlMap.DataSource, ScriptDirectory + "category-init.sql" );
		}

	    protected override void ChildSetupProperties(NameValueCollection nvc)
	    {	        
            base.ChildSetupProperties(nvc);
	        nvc["useStatementNamespaces"] = "true";
        }

	    /// <summary>
		/// TearDown
		/// </summary>
		[TearDown] 
		public void Dispose()
		{ /* ... */ } 

		#endregion

		#region Test statement namespaces

		/// <summary>
		/// Test QueryForObject
		/// </summary>
		[Test] 
		public void TestQueryForObject() {
			Account account = sqlMap.QueryForObject("Account.GetAccountViaResultClass", 1) as Account;
			AssertAccount1(account);
		}

		/// <summary>
		/// Test collection mapping: Ilist collection 
		/// order.LineItemsIList 
		/// with statement namespaces enabled
		/// </summary>
		[Test]
		public void TestListMapping() {
			Order order = (Order) sqlMap.QueryForObject("Order.GetOrderWithLineItemsUsingStatementNamespaces", 1);

			AssertOrder1(order);

			// Check IList collection
			Assert.IsNotNull(order.LineItemsIList);
			Assert.AreEqual(3, order.LineItemsIList.Count);

		}

		/// <summary>
		/// Test Insert Via Insert Statement
		/// for support request 1050704:
		/// Unable to use selectKey with 
		/// useStatementNamespaces=true
		/// </summary>
		[Test] 
		public void TestInsertSelectKey() {
			Category category = new Category();
			category.Name = "toto";
			category.Guid = Guid.NewGuid();

			int key = (int)sqlMap.Insert("Category.InsertCategoryViaInsertStatement", category);
			Assert.AreEqual(1, key);
		}

		#endregion
	}
}
