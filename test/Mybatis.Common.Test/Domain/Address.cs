
using System;

namespace Mybatis.Common.Test.Domain
{
public class Address : BaseDomain, IAddress 
{  
    private string streetname;
    public string Streetname 
    { 
            get { return streetname; } 
            set { streetname = value; } 
    } 
} 


}

