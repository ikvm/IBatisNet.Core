using System.Xml.Linq;
using System.Xml.XPath;
using Mybatis.Configuration;

namespace System.Xml
{
  /// <summary>
  /// XML配置结构接口定义
  /// </summary>
  public interface ISchema : ICloneable
  {
    /// <summary>
    /// 获取或设置唯一标识
    /// </summary>
    string Id { get; set; }
    /// <summary>
    /// 获取节点的命名空间 URI
    /// </summary>
    string NamespaceURI { get; }
    /// <summary>
    /// 根据XmlNode遍历和解释XML内容
    /// </summary>
    /// <param name="node"></param>
    void Parse(XmlNode node);
    /// <summary>
    /// 根据XDocument遍历和解释XML内容
    /// </summary>
    /// <param name="doc"></param>
    void Parse(XDocument doc);
    /// <summary>
    /// 根据XPathNavigator遍历和解释XML内容
    /// </summary>
    /// <param name="xnav"></param>
    void Parse(XPathNavigator xnav);
    /// <summary>
    /// 根据XPathNavigator遍历和解释XML内容
    /// </summary>
    /// <param name="reader"></param>
    void Parse(XmlReader reader);
  }
}