
using System;
using System.Collections;
using System.Collections.Generic;
using Mybatis.Common.Test.Domain;
using Mybatis.Common.Utilities;
using NUnit.Framework;

namespace Mybatis.Common.Test.NUnit.CommonTests.Utilities
{
    [TestFixture]
    public class TypeUtilsTest
    {
        


        /// <summary>
        /// Test IsImplementGenericIListInterface.
        /// </summary>
        [Test]
        public void IsImplementGenericIListInterfaceOnIList()
        {
            Type memberType = typeof(IList<Document>);

            bool isGenericIList = TypeUtils.IsImplementGenericIListInterface(memberType);
            Assert.IsTrue(isGenericIList);

            //Console.Write(typeof(IList).IsAssignableFrom(typeof(Array)));
        }

        /// <summary>
        /// Test IsImplementGenericIListInterface.
        /// </summary>
        [Test]
        public void IsImplementGenericIListInterfaceOnList()
        {
            //GenericDocumentCollection documents = new GenericDocumentCollection();
            Type memberType = typeof(List<Document>);

            bool isGenericIList = TypeUtils.IsImplementGenericIListInterface(memberType);

            Assert.IsTrue(isGenericIList);
        }

        /// <summary>
        /// Test IsImplementGenericIListInterface.
        /// </summary>
        [Test]
        public void IsImplementGenericIListInterfaceOnCustomList()
        {
            Type memberType = typeof(GenericDocumentCollection);

            bool isGenericIList = TypeUtils.IsImplementGenericIListInterface(memberType);

            Assert.IsTrue(isGenericIList);
        }

        /// <summary>
        /// Test IsImplementGenericIListInterface.
        /// </summary>
        [Test]
        public void IsImplementGenericIListInterfaceOnArray()
        {
            Type memberType = typeof(Document[]);

            bool isGenericIList = TypeUtils.IsImplementGenericIListInterface(memberType);

            Assert.IsTrue(isGenericIList);
        }

        /// <summary>
        /// Test IsImplementGenericIListInterface.
        /// </summary>
        [Test]
        public void IsImplementGenericIListInterfaceOnInt()
        {
            Type memberType = typeof(int);

            bool isGenericIList = TypeUtils.IsImplementGenericIListInterface(memberType);

            Assert.IsFalse(isGenericIList);
        }
    }
}
