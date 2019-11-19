using System.Xml.Linq;
using System.Xml.XPath;

namespace System.Xml {
  /// <summary>
  /// 配置结构接口定义
  /// </summary>
  public interface ISchema : ICloneable {
    /// <summary>
		/// 获取或设置唯一标识
		/// </summary>
		string Id { get; set; }
    /// <summary>
    /// 根据XPathNavigator遍历和解释XML内容
    /// </summary>
    /// <param name="xnav"></param>
    void Parse(XDocument xnav);
    /// <summary>
    /// 根据XPathNavigator遍历和解释XML内容
    /// </summary>
    /// <param name="xnav"></param>
    void Parse(XPathNavigator xnav);
	}
}
