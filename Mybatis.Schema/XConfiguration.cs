using System.Collections.Generic;

namespace System.Xml
{
  /// <summary>
  /// Class XConfiguration.
  /// Implements the <see cref="XSchema" />
  /// </summary>
  /// <seealso cref="XSchema" />
  public class XConfiguration : XSchema
  {
    /// <summary>
    /// Initializes a new instance of the <see cref="XConfiguration"/> class.
    /// </summary>
    /// <param name="reader">The reader.</param>
    public XConfiguration(XmlReader reader) : base(reader) { }

    /// <summary>
    /// Gets the name of the node.
    /// </summary>
    /// <value>The name of the node.</value>
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
          ParseChilds(xnav, "settings", "setting", Settings);
          //while (xnav.Read())
          //{
          //  if (xnav.NodeType == XmlNodeType.EndElement && xnav.Name == "settings")
          //  {
          //    break;
          //  }
          //  if (xnav.Name == "setting")
          //  {
          //    Settings.Add(new XSetting(xnav));
          //  }
          //}
          break;
        }
        case "typeAliases":
        {
          while (xnav.Read())
          {
            if (xnav.NodeType == XmlNodeType.EndElement && xnav.Name == "typeAliases")
            {
              break;
            }
            if (xnav.Name == "typeAlias")
            {
              TypeAliases.Add(new XTypeAlias(xnav));
            }
          }
          break;
        }
      }
    }

    /// <summary>
    /// The settings
    /// </summary>
    public List<XSetting> Settings = new List<XSetting>();
    /// <summary>
    /// The type aliases
    /// </summary>
    public List<XTypeAlias> TypeAliases = new List<XTypeAlias>();

  }
}