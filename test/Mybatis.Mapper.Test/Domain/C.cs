using System;

namespace Mybatis.Mapper.Test.Domain
{
	/// <summary>
	/// Summary description for C.
	/// </summary>
	public class C 
	{
		private string _id;
		private string _libelle;

		public string Id
		{
			get { return _id; }
			set { _id = value; }
		}

		public string Libelle
		{
			get { return _libelle; }
			set { _libelle = value; }
		}
	}
}
