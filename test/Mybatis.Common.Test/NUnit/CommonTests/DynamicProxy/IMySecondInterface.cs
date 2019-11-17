using System;

namespace Mybatis.Common.Test.NUnit.CommonTests.DynamicProxy
{
	/// <summary>
	///  Summary description for IMySecondInterface.
	/// </summary>
	public interface IMySecondInterface : IMyInterface
	{
		string Address
		{
			get;
			set;
		}
	}
}
