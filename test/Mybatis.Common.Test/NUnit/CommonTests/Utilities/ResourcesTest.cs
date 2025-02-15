using System.IO;
using System.Xml;
using Mybatis.Common.Utilities;
using NUnit.Framework;

namespace Mybatis.Common.Test.NUnit.CommonTests.Utilities
{
	/// <summary>
	/// Description r�sum�e de ResourcesTest.
	/// </summary>
	[TestFixture] 
	public class ResourcesTest
	{
		#region SetUp & TearDown

		/// <summary>
		/// SetUp
		/// </summary>
		[SetUp] 
		public void SetUp() 
		{
		}


		/// <summary>
		/// TearDown
		/// </summary>
		[TearDown] 
		public void Dispose()
		{ 
		} 

		#endregion

		#region Test ResourcesTest

		/// <summary>
		/// Test loading Embedded Resource
		/// </summary>
		[Test] 
		public void TestEmbeddedResource() 
		{
			XmlDocument doc = null;

			doc = Resources.GetEmbeddedResourceAsXmlDocument("IBatisNet.Common.Test.properties.xml, IBatisNet.Common.Test");

			Assert.IsNotNull(doc);
			Assert.IsTrue(doc.HasChildNodes);
			Assert.AreEqual(doc.ChildNodes.Count,2);
			Assert.AreEqual(doc.SelectNodes("/settings/add").Count, 4);
		}

		/// <summary>
		/// Test loading Embedded Resource
		/// </summary>
		[Test] 
		public void TestEmbeddedResourceWhenNamespaceDiffersFromAssemblyName() 
		{
			XmlDocument doc = null;

			doc = Resources.GetEmbeddedResourceAsXmlDocument("CompanyName.ProductName.Maps.ISCard.xml, OctopusService");

			Assert.IsNotNull(doc);
			Assert.IsTrue(doc.HasChildNodes);
			Assert.AreEqual(doc.ChildNodes.Count,2);
		}
		#endregion

		#region GetFileInfo Tests

		[Test] 
		public void GetFileInfoWithRelative() 
		{ 
			FileInfo fileInfo = Resources.GetFileInfo("IBatisNet.Common.Test.dll");
			Assert.IsNotNull(fileInfo);
		}


		[Test] 
		public void GetFileInfoWithAbsolute() 
		{ 
			string resourcePath = Resources.ApplicationBase+Path.DirectorySeparatorChar+"IBatisNet.Common.Test.dll";
			FileInfo fileInfo = Resources.GetFileInfo(resourcePath);
			Assert.IsNotNull(fileInfo);
		}

		[Test] 
		public void GetFileInfoWithAbsoluteProtocol() 
		{ 
			string resourcePath = "file://"+Resources.ApplicationBase+Path.DirectorySeparatorChar+"IBatisNet.Common.Test.dll";
			FileInfo fileInfo = Resources.GetFileInfo(resourcePath);
			Assert.IsNotNull(fileInfo);
		}

		[Test] 
		public void GetFileInfoWithAbsoluteProtocolPlusSlash() 
		{ 
			string resourcePath = "file:///"+Resources.ApplicationBase+Path.DirectorySeparatorChar+"IBatisNet.Common.Test.dll";
			FileInfo fileInfo = Resources.GetFileInfo(resourcePath);
			Assert.IsNotNull(fileInfo);
		}
		#endregion 

		#region GetConfigAsXmlDocument Tests

		[Test] 
		public void GetConfigAsXmlDocumentWithAbsolute() 
		{ 
			string resourcePath = Resources.ApplicationBase+Path.DirectorySeparatorChar+"SqlMap_MSSQL_SqlClient.config";
			XmlDocument doc = Resources.GetConfigAsXmlDocument(resourcePath);
			Assert.IsNotNull(doc);
		}

		[Test] 
		public void GetConfigAsXmlDocumentWithAbsoluteProtocol() 
		{ 
			string resourcePath = "file://"+Resources.ApplicationBase+Path.DirectorySeparatorChar+"SqlMap_MSSQL_SqlClient.config";
			XmlDocument doc = Resources.GetConfigAsXmlDocument(resourcePath);
			Assert.IsNotNull(doc);
		}


		[Test] 
		public void GetConfigAsXmlDocumentWithAbsoluteProtocolPlusSlash() 
		{ 
			XmlDocument doc = Resources.GetConfigAsXmlDocument("file:///"+Resources.ApplicationBase+Path.DirectorySeparatorChar+"SqlMap_MSSQL_SqlClient.config");
			Assert.IsNotNull(doc);
		}

		[Test] 
		public void GetConfigAsXmlDocumentWithRelative() 
		{ 
			XmlDocument doc = Resources.GetConfigAsXmlDocument("SqlMap_MSSQL_SqlClient.config");
			Assert.IsNotNull(doc);
		}

		#endregion 
	}
}
