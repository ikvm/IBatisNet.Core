using System.Xml;

namespace Mybatis.Configuration
{
  /// <remarks/>
  public partial class configuration : XSchema
  {
    public configuration()
    {
    }

    public configuration(XmlReader reader) : base(reader)
    {
    }

    /// <summary>
    /// 获取节点名称
    /// </summary>
    /// <value>节点名称</value>
    protected override string NodeName
    {
      get { return "configuration"; }
    }
    /// <summary>
    /// 遍历当前XML节点
    /// </summary>
    /// <param name="xnav">XPathNavigator对象</param>
    protected override void ParseChild(XmlReader xnav)
    {
      if (null == xnav) return;
      switch (xnav.Name)
      {
        case "properties":
        {
          break;
        }
        case "settings":
        {
          ParseChilds(xnav, "settings", "setting", settings);
          break;
        }
        case "typeAliases":
        {
          ParseChilds(xnav, "typeAliases", "typeAlias", typeAliases.typeAlias);
          break;
        }
      }
    }


    /// <remarks/>
    public properties properties { get; set; }

    /// <remarks/>
    public setting[] settings { get; set; }

    /// <remarks/>
    public typeAliases typeAliases { get; set; }

    /// <remarks/>
    public typeHandlers typeHandlers { get; set; }

    /// <remarks/>
    public objectFactory objectFactory { get; set; }

    /// <remarks/>
    public objectWrapperFactory objectWrapperFactory { get; set; }

    /// <remarks/>
    public reflectorFactory reflectorFactory { get; set; }

    /// <remarks/>
    public plugin[] plugins { get; set; }

    /// <remarks/>
    public environments environments { get; set; }

    /// <remarks/>
    public databaseIdProvider databaseIdProvider { get; set; }

    /// <remarks/>
    public mappers mappers { get; set; }
  }

  /// <remarks/>
  public partial class properties : XSchema
  {
    public properties()
    {
    }

    public properties(XmlReader reader)
      : base(reader)
    {
    }

    /// <summary>
    /// 获取节点名称
    /// </summary>
    /// <value>节点名称</value>
    protected override string NodeName
    {
      get { return "properties"; }
    }

    /// <remarks/>
    public property[] property { get; set; }

    /// <remarks/>
    public string resource { get; set; }

    /// <remarks/>
    public string url { get; set; }
  }

  /// <remarks/>
  public partial class property : XSchema
  {
    public property()
    {
    }

    public property(XmlReader reader)
      : base(reader)
    {
    }

    /// <summary>
    /// 获取节点名称
    /// </summary>
    /// <value>节点名称</value>
    protected override string NodeName
    {
      get { return "property"; }
    }

    /// <remarks/>
    public string name { get; set; }

    /// <remarks/>
    public string value { get; set; }
  }

  /// <remarks/>
  public partial class setting : XSchema
  {
    public setting()
    {
    }

    public setting(XmlReader reader)
      : base(reader)
    {
    }

    /// <summary>
    /// 获取节点名称
    /// </summary>
    /// <value>节点名称</value>
    protected override string NodeName
    {
      get { return "setting"; }
    }

    /// <remarks/>
    public string name { get; set; }

    /// <remarks/>
    public string value { get; set; }
  }

  /// <remarks/>
  public partial class typeAliases : XSchema
  {
    public typeAliases()
    {
    }

    public typeAliases(XmlReader reader)
      : base(reader)
    {
    }

    /// <summary>
    /// 获取节点名称
    /// </summary>
    /// <value>节点名称</value>
    protected override string NodeName
    {
      get { return "typeAliases"; }
    }

    /// <remarks/>
    public typeAlias[] typeAlias { get; set; }

    /// <remarks/>
    public package[] package { get; set; }
  }

  /// <remarks/>
  public partial class typeAlias : XSchema
  {
    public typeAlias()
    {
    }

    public typeAlias(XmlReader reader)
      : base(reader)
    {
    }

    /// <summary>
    /// 获取节点名称
    /// </summary>
    /// <value>节点名称</value>
    protected override string NodeName
    {
      get { return "typeAlias"; }
    }

    /// <remarks/>
    public string type { get; set; }

    /// <remarks/>
    public string alias { get; set; }
  }

  /// <remarks/>
  public partial class package : XSchema
  {
    public package()
    {
    }

    public package(XmlReader reader)
      : base(reader)
    {
    }

    /// <summary>
    /// 获取节点名称
    /// </summary>
    /// <value>节点名称</value>
    protected override string NodeName
    {
      get { return "package"; }
    }

    /// <remarks/>
    public string name { get; set; }
  }

  /// <remarks/>
  public partial class typeHandlers : XSchema
  {
    public typeHandlers()
    {
    }

    public typeHandlers(XmlReader reader)
      : base(reader)
    {
    }

    /// <summary>
    /// 获取节点名称
    /// </summary>
    /// <value>节点名称</value>
    protected override string NodeName
    {
      get { return "typeHandlers"; }
    }

    /// <remarks/>
    public typeHandler[] typeHandler { get; set; }

    /// <remarks/>
    public package[] package { get; set; }
  }

  /// <remarks/>
  public partial class typeHandler : XSchema
  {
    public typeHandler()
    {
    }

    public typeHandler(XmlReader reader)
      : base(reader)
    {
    }

    /// <summary>
    /// 获取节点名称
    /// </summary>
    /// <value>节点名称</value>
    protected override string NodeName
    {
      get { return "typeHandler"; }
    }

    /// <remarks/>
    public string javaType { get; set; }

    /// <remarks/>
    public string jdbcType { get; set; }

    /// <remarks/>
    public string handler { get; set; }
  }

  /// <remarks/>
  public partial class objectFactory : XSchema
  {
    public objectFactory()
    {
    }

    public objectFactory(XmlReader reader)
      : base(reader)
    {
    }

    /// <summary>
    /// 获取节点名称
    /// </summary>
    /// <value>节点名称</value>
    protected override string NodeName
    {
      get { return "objectFactory"; }
    }

    /// <remarks/>
    public property[] property { get; set; }

    /// <remarks/>
    public string type { get; set; }
  }

  /// <remarks/>
  public partial class objectWrapperFactory : XSchema
  {
    public objectWrapperFactory()
    {
    }

    public objectWrapperFactory(XmlReader reader)
      : base(reader)
    {
    }

    /// <summary>
    /// 获取节点名称
    /// </summary>
    /// <value>节点名称</value>
    protected override string NodeName
    {
      get { return "objectWrapperFactory"; }
    }

    /// <remarks/>
    public string type { get; set; }
  }

  /// <remarks/>
  public partial class reflectorFactory : XSchema
  {
    public reflectorFactory()
    {
    }

    public reflectorFactory(XmlReader reader)
      : base(reader)
    {
    }

    /// <summary>
    /// 获取节点名称
    /// </summary>
    /// <value>节点名称</value>
    protected override string NodeName
    {
      get { return "reflectorFactory"; }
    }

    /// <remarks/>
    public string type { get; set; }
  }

  /// <remarks/>
  public partial class plugin : XSchema
  {
    public plugin()
    {
    }

    public plugin(XmlReader reader)
      : base(reader)
    {
    }

    /// <summary>
    /// 获取节点名称
    /// </summary>
    /// <value>节点名称</value>
    protected override string NodeName
    {
      get { return "plugin"; }
    }

    /// <remarks/>
    public property[] property { get; set; }

    /// <remarks/>
    public string interceptor { get; set; }
  }

  /// <remarks/>
  public partial class environments : XSchema
  {
    public environments()
    {
    }

    public environments(XmlReader reader)
      : base(reader)
    {
    }

    /// <summary>
    /// 获取节点名称
    /// </summary>
    /// <value>节点名称</value>
    protected override string NodeName
    {
      get { return "environments"; }
    }

    /// <remarks/>
    public environment[] environment { get; set; }

    /// <remarks/>
    public string @default { get; set; }
  }

  /// <remarks/>
  public partial class environment : XSchema
  {
    public environment()
    {
    }

    public environment(XmlReader reader)
      : base(reader)
    {
    }

    /// <summary>
    /// 获取节点名称
    /// </summary>
    /// <value>节点名称</value>
    protected override string NodeName
    {
      get { return "environment"; }
    }

    /// <remarks/>
    public transactionManager transactionManager { get; set; }

    /// <remarks/>
    public dataSource dataSource { get; set; }

    /// <remarks/>
    public string id { get; set; }
  }

  /// <remarks/>
  public partial class transactionManager : XSchema
  {
    public transactionManager()
    {
    }

    public transactionManager(XmlReader reader)
      : base(reader)
    {
    }

    /// <summary>
    /// 获取节点名称
    /// </summary>
    /// <value>节点名称</value>
    protected override string NodeName
    {
      get { return "transactionManager"; }
    }

    /// <remarks/>
    public property[] property { get; set; }

    /// <remarks/>
    public string type { get; set; }
  }

  /// <remarks/>
  public partial class dataSource : XSchema
  {
    public dataSource()
    {
    }

    public dataSource(XmlReader reader)
      : base(reader)
    {
    }

    /// <summary>
    /// 获取节点名称
    /// </summary>
    /// <value>节点名称</value>
    protected override string NodeName
    {
      get { return "dataSource"; }
    }

    /// <remarks/>
    public property[] property { get; set; }

    /// <remarks/>
    public string type { get; set; }
  }

  /// <remarks/>
  public partial class databaseIdProvider : XSchema
  {
    public databaseIdProvider()
    {
    }

    public databaseIdProvider(XmlReader reader)
      : base(reader)
    {
    }

    /// <summary>
    /// 获取节点名称
    /// </summary>
    /// <value>节点名称</value>
    protected override string NodeName
    {
      get { return "databaseIdProvider"; }
    }

    /// <remarks/>
    public property[] property { get; set; }

    /// <remarks/>
    public string type { get; set; }
  }

  /// <remarks/>
  public partial class mappers : XSchema
  {
    public mappers()
    {
    }

    public mappers(XmlReader reader)
      : base(reader)
    {
    }

    /// <summary>
    /// 获取节点名称
    /// </summary>
    /// <value>节点名称</value>
    protected override string NodeName
    {
      get { return "mappers"; }
    }

    /// <remarks/>
    public mapper[] mapper { get; set; }

    /// <remarks/>
    public package[] package { get; set; }
  }

  /// <remarks/>
  public partial class mapper : XSchema
  {
    public mapper()
    {
    }

    public mapper(XmlReader reader)
      : base(reader)
    {
    }

    /// <summary>
    /// 获取节点名称
    /// </summary>
    /// <value>节点名称</value>
    protected override string NodeName
    {
      get { return "mapper"; }
    }

    /// <remarks/>
    public string resource { get; set; }

    /// <remarks/>
    public string url { get; set; }

    /// <remarks/>
    public string @class { get; set; }
  }

  /// <remarks/>
  public partial class settings : XSchema
  {
    public settings()
    {
    }

    public settings(XmlReader reader)
      : base(reader)
    {
    }

    /// <summary>
    /// 获取节点名称
    /// </summary>
    /// <value>节点名称</value>
    protected override string NodeName
    {
      get { return "settings"; }
    }

    /// <remarks/>
    public setting[] setting { get; set; }
  }

  /// <remarks/>
  public partial class plugins : XSchema
  {
    public plugins()
    {
    }

    public plugins(XmlReader reader)
      : base(reader)
    {
    }

    /// <summary>
    /// 获取节点名称
    /// </summary>
    /// <value>节点名称</value>
    protected override string NodeName
    {
      get { return "plugins"; }
    }

    /// <remarks/>
    public plugin[] plugin { get; set; }
  }
}
