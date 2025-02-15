using System;

namespace Mybatis.DataAccess.Test.Domain
{
	/// <summary>
	/// Summary description for Category.
	/// </summary>
	public class Category
	{
		private int _id;
		private string _name;
		private Guid _guid;

		public Guid EmptyGuid
		{
			get
			{
				return Guid.Empty; 
			}
		}

		public Guid Guid
		{
			get
			{
				return _guid; 
			}
			set
			{ 
				_guid = value; 
			}
		}

		public string GuidString {
			get {
				return _guid.ToString(); 
			}
			set { 
				if (value == null) {
					_guid = Guid.Empty;
				}
				else {
					_guid = new Guid(value.ToString());
				}
			}
		}

		public int Id
		{
			get
			{
				return _id; 
			}
			set
			{ 
				_id = value; 
			}
		}

		public string Name
		{
			get
			{
				return _name; 
			}
			set
			{ 
				_name = value; 
			}
		}

	}
}
