using System;

namespace Mybatis.Common.Test.Domain
{
    public class BaseDomain : IBaseDomain
    {
        private Guid _id;
        public Guid Id
        {
            get { return _id; }
            set { _id = value; } 
        }

    } 

}
