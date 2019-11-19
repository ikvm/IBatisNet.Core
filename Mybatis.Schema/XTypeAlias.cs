using System.Collections.Generic;

namespace System.Xml
{
  public class XTypeAliases : XSchema
  {
    /// <summary>
    /// 获取节点名称
    /// </summary>
    /// <value>节点名称</value>
    protected override string NodeName
    {
      get { return "typeAliases"; }
    }

    /// <summary>
    /// Gets or sets the type aliases.
    /// </summary>
    /// <value>The type aliases.</value>
    public List<XTypeAlias> TypeAliases { get; set; }
    
    /// <summary>
    /// Gets or sets the packages.
    /// </summary>
    /// <value>The packages.</value>
    public List<XPackage> Packages { get; set; }
  }
  /// <summary>
  /// Class XPackage.
  /// Implements the <see cref="XSchema" />
  /// </summary>
  /// <seealso cref="XSchema" />
  public class XPackage : XSchema
  {
    /// <summary>
    /// Initializes a new instance of the <see cref="XPackage"/> class.
    /// </summary>
    public XPackage(){}
    /// <summary>
    /// 获取节点名称
    /// </summary>
    /// <value>节点名称</value>
    protected override string NodeName
    {
      get { return "package"; }
    }

    protected override void ParseAttribute(string name, string value)
    {
      switch (name)
      {
        case "name":
          this.name = value;
          break;
      }
    }

    /// <summary>
    /// 获取或设置名称
    /// </summary>
    /// <value>The alias.</value>
    public string name { get; set; }
  }
  /// <summary>
  /// Class XTypeAlias.
  /// Implements the <see cref="System.Xml.XSchema" />
  /// </summary>
  /// <seealso cref="System.Xml.XSchema" />
  public class XTypeAlias : XSchema
  {
    /// <summary>
    /// Initializes a new instance of the <see cref="XTypeAlias"/> class.
    /// </summary>
    public XTypeAlias(){}
    /// <summary>
    /// Initializes a new instance of the <see cref="XTypeAlias"/> class.
    /// </summary>
    /// <param name="reader">The reader.</param>
    public XTypeAlias(XmlReader reader) : base(reader) { }
    /// <summary>
    /// 遍历当前XML节点的属性
    /// </summary>
    /// <param name="name">XML节点属性名称</param>
    /// <param name="value">XML节点属性值</param>
    protected override void ParseAttribute(string name, string value)
    {
      switch (name)
      {
        case "alias":
          this.alias = value;
          break;
        case "type":
          this.type = value;
          break;
      }
    }

    /// <summary>
    /// 获取节点名称
    /// </summary>
    /// <value>节点名称</value>
    protected override string NodeName { get { return "typeAlias"; } }

    /// <summary>
    /// 遍历当前XML节点
    /// </summary>
    /// <param name="xnav">XPathNavigator对象</param>
    protected override void ParseChild(XmlReader xnav)
    {
      //base.ParseChild(xnav);
    }

    /// <summary>
    /// Gets or sets the alias.
    /// </summary>
    /// <value>The alias.</value>
    public string alias { get; set; }

    /// <summary>
    /// Gets or sets the type.
    /// </summary>
    /// <value>The type.</value>
    public string type { get; set; }
  }
}