using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Xml.Linq;
using System.Xml.XPath;

namespace System.Xml
{
  /// <summary>
  /// XML配置结构解析实现基类
  /// Implements the <see cref="ISchema" />
  /// </summary>
  /// <seealso cref="ISchema" />
  public abstract class XSchema : ISchema
  {
    /// <summary>
    /// Initializes a new instance of the <see cref="XSchema"/> class.
    /// </summary>
    public XSchema(){}

    /// <summary>
    /// Initializes a new instance of the <see cref="XSchema"/> class.
    /// </summary>
    /// <param name="reader">The reader.</param>
    protected XSchema(XmlReader reader)
    {
      Parse(reader);
    }

    /// <summary>Initializes a new instance of the <see cref="XSchema"/> class.</summary>
    /// <param name="xnav">The nav.</param>
    protected XSchema(XPathNavigator xnav)
    {
      Parse(xnav);
    }

    /// <summary>
    /// 获取节点名称
    /// </summary>
    /// <value>节点名称</value>
    protected abstract string NodeName { get; }
    /// <summary>
    /// 获取或设置唯一标识
    /// </summary>
    /// <value>The identifier.</value>
    public string Id { get; set; }
    /// <summary>
    /// 获取节点的命名空间 URI
    /// </summary>
    /// <value>节点的命名空间</value>
    public string NamespaceURI { get; private set; }

    /// <summary>
    /// 根据XmlNode遍历和解释XML内容
    /// </summary>
    /// <param name="node"></param>
    public void Parse(XmlNode node)
    {
      if (null == node) return;
      Parse(node.CreateNavigator());
    }

    /// <summary>
    /// 根据XDocument遍历和解释XML内容
    /// </summary>
    /// <param name="doc">The xdoc.</param>
    public void Parse(XDocument doc)
    {
      if (null == doc) return;
      Parse(doc.CreateNavigator());
    }

    /// <summary>
    /// 根据XPathNavigator遍历和解释XML内容
    /// </summary>
    /// <param name="xnav">The xnav.</param>
    /// <exception cref="NotImplementedException"></exception>
    public void Parse(XPathNavigator xnav)
    {
      NamespaceURI = xnav.NamespaceURI;
      if (xnav.MoveToFirstAttribute())
      {
        do
        {
          switch (xnav.Name)
          {
            case "Id":
              Id = xnav.Value;
              break;
            default:
              ParseAttribute(xnav.Name, xnav.Value);
              break;
          }
        } while (xnav.MoveToNextAttribute());
        xnav.MoveToParent();
        if (string.IsNullOrEmpty(Id)) Id = Guid.NewGuid().ToString("N");
        AfterParseAttribute();
      }
      if (xnav.MoveToFirstChild())
      {
        do
        {
          if (xnav.NodeType == XPathNodeType.Comment) continue;
          ParseChild(xnav);
        } while (xnav.MoveToNext());
        xnav.MoveToParent();
        AfterParseChild();
      }
    }

    /// <summary>
    /// 创建作为当前实例副本的新对象。
    /// </summary>
    /// <returns>作为此实例副本的新对象。</returns>
    public object Clone()
    {
      return MemberwiseClone();
    }

    /// <summary>
    /// 根据XPathNavigator遍历和解释XML内容
    /// </summary>
    /// <param name="reader">The reader.</param>
    public void Parse(XmlReader reader)
    {
      if (null == reader) return;
      reader.MoveToContent();
      NamespaceURI = reader.NamespaceURI;

      // Parse the file, save header information when encountered, and yield the  
      // Item XElement objects as they are created.  
      var isEmptyElement = reader.IsEmptyElement;
      if (reader.HasAttributes && reader.MoveToFirstAttribute())
      {
        do
        {
          switch (reader.Name)
          {
            case "Id":
              Id = reader.Value;
              break;
            default:
              ParseAttribute(reader.Name, reader.Value);
              break;
          }
        } while (reader.MoveToNextAttribute());
        if (string.IsNullOrEmpty(Id)) Id = Guid.NewGuid().ToString("N");
        AfterParseAttribute();
      }
      if (!isEmptyElement)
      {
        while (reader.Read())
        {
          if (reader.NodeType == XmlNodeType.Comment) continue;
          if (reader.NodeType == XmlNodeType.EndElement && reader.Name == NodeName) break;
          ParseChild(reader);
        }
        AfterParseChild();
      }
    }

    /// <summary>
    /// 遍历当前XML节点
    /// </summary>
    /// <param name="reader">XmlReader对象</param>
    protected virtual void ParseChild(XmlReader reader)
    {
      if (null == reader) return;
      if (reader.HasAttributes && reader.MoveToFirstAttribute())
      {
        do
        {
          switch (reader.Name)
          {
            case "Id":
              Id = reader.Value;
              break;
            default:
              ParseChildAttribute(reader.Name, reader);
              break;
          }
        } while (reader.MoveToNextAttribute());
      }
    }
    /// <summary>
    /// Parses the childs.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="xnav">The xnav.</param>
    /// <param name="parentNodeName">Name of the parent node.</param>
    /// <param name="nodeName">Name of the node.</param>
    /// <param name="collections">The collections.</param>
    protected void ParseChilds<T>(XmlReader xnav, string parentNodeName, string nodeName, IList<T> collections)
      where T : ISchema, new()
    {
      if (null == xnav) return;
      while (xnav.Read())
      {
        if (xnav.NodeType == XmlNodeType.EndElement && xnav.Name == parentNodeName)
        {
          break;
        }
        if (xnav.Name == nodeName)
        {
          var item = new T();
          item.Parse(xnav);
          collections.Add(item);
        }
      }
    }

    /// <summary>
    /// 遍历当前XML节点子节点的属性
    /// </summary>
    /// <param name="nodeName">当前节点名称</param>
    /// <param name="xnav">XPathNavigator对象</param>
    protected virtual void ParseChildAttribute(string nodeName, XmlReader xnav)
    {

    }

    /// <summary>
    /// 遍历当前XML节点的属性
    /// </summary>
    /// <param name="name">XML节点属性名称</param>
    /// <param name="value">XML节点属性值</param>
    protected virtual void ParseAttribute(string name, string value)
    {

    }

    /// <summary>
    /// 遍历当前XML节点的属性之后
    /// </summary>
    protected virtual void AfterParseAttribute()
    {

    }

    /// <summary>
    /// 遍历当前XML节点
    /// </summary>
    /// <param name="xnav">XPathNavigator对象</param>
    protected virtual void ParseChild(XPathNavigator xnav)
    {
      if (null == xnav) return;
      string nodeName = xnav.Name;
      if (xnav.MoveToFirstAttribute())
      {
        do
        {
          ParseChildAttribute(nodeName, xnav);
        } while (xnav.MoveToNextAttribute());
        xnav.MoveToParent();
      }
    }


    /// <summary>
    /// Parses the childs.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="nodeName">Name of the node.</param>
    /// <param name="xnav">The xnav.</param>
    /// <param name="collections">The collections.</param>
    protected void ParseChilds<T>(string nodeName, XPathNavigator xnav, IList<T> collections)
        where T : ISchema, new()
    {
      if (xnav.MoveToFirstChild())
      {
        do
        {
          if (xnav.Name == nodeName)
          {
            var item = new T();
            item.Parse(xnav);
            collections.Add(item);
          }
        } while (xnav.MoveToNext());
        xnav.MoveToParent();
      }
    }

    /// <summary>
    /// Afters the parse child.
    /// </summary>
    protected virtual void AfterParseChild()
    {
    }

    /// <summary>
    /// 遍历当前XML节点子节点的属性
    /// </summary>
    /// <param name="nodeName">当前节点名称</param>
    /// <param name="xnav">XPathNavigator对象</param>
    protected virtual void ParseChildAttribute(string nodeName, XPathNavigator xnav)
    {

    }
  }
}