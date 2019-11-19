//using System.Collections.ObjectModel;
//using System.Xml.Linq;
//using System.Xml.XPath;
//using Baishi.Xml;
//using Baishi.Xml.Grids;

//namespace System.Xml {
//  /// <summary>
//  /// 配置结构定义基础对象
//  /// </summary>
//  [Serializable]
//  public class XSchema : ISchema {
//    #region ISchema 成员

//    /// <summary>
//    /// 根据XPathNavigator遍历和解释XML内容
//    /// </summary>
//    /// <param name="xnav">XPathNavigator对象</param>
//    void ISchema.Parse(XDocument xdoc) {
//      if (null == xdoc) return;
//      var xnav = xdoc.CreateNavigator(); 
//      Parse(xnav);
//    }

//    /// <summary>
//    /// 根据XPathNavigator遍历和解释XML内容
//    /// </summary>
//    /// <param name="xnav">XPathNavigator对象</param>
//    void ISchema.Parse(XPathNavigator xnav) {
//      if (null == xnav) return;
//      Parse(xnav);
//    }

//    protected virtual void Parse(XmlReader reader) {
//      if (null == reader) return;
//      reader.MoveToContent();
//      NamespaceURI = reader.NamespaceURI;

//      // Parse the file, save header information when encountered, and yield the  
//      // Item XElement objects as they are created.  

//      // loop through Customer elements  
//      while (reader.Read())
//      {
//        if(reader.NodeType == XmlNodeType.Comment) continue;
//        if (reader.HasAttributes && reader.MoveToFirstAttribute())
//        {
//          do
//          {
//            switch (reader.Name)
//            {
//              case "Id":
//                Id = reader.Value;
//                break;
//              default:
//                ParseAttribute(reader.Name, reader.Value);
//                break;
//            }
//          } while (reader.MoveToNextAttribute());
//          if (string.IsNullOrEmpty(Id)) Id = Guid.NewGuid().ToString("N");
//          AfterParseAttribute();
//        }

//        do
//        {
//          ParseChild(reader);
//        } while (reader.NodeType != XmlNodeType.EndElement);
//        AfterParseChild();

//#region comment
//        //if (reader.NodeType == XmlNodeType.Element
//        //    && reader.Name == "Customer")
//        //{
//        //  // move to Name element  
//        //  while (reader.Read())
//        //  {
//        //    if (reader.NodeType == XmlNodeType.Element &&
//        //        reader.Name == "Name")
//        //    {
//        //      name = XElement.ReadFrom(reader) as XElement;
//        //      break;
//        //    }
//        //  }

//        //  // loop through Item elements  
//        //  while (reader.Read())
//        //  {
//        //    if (reader.NodeType == XmlNodeType.EndElement)
//        //      break;
//        //    if (reader.NodeType == XmlNodeType.Element
//        //        && reader.Name == "Item")
//        //    {
//        //      item = XElement.ReadFrom(reader) as XElement;
//        //      if (item != null)
//        //      {
//        //        XElement tempRoot = new XElement("Root",
//        //            new XElement(name)
//        //        );
//        //        tempRoot.Add(item);
//        //        yield return item;
//        //      }
//        //    }
//        //  }
//        //}
//#endregion
//      }  
//    }

//    #region properties

//    /// <summary>
//    /// 获取或设置列集合
//    /// </summary>
//    public XGridColumnCollection Columns { get; set; }

//    /// <summary>
//    /// 获取或设置列分组对象集合
//    /// </summary>
//    public Collection<XGridColumnGroup> ColumnGroup { get; set; }

//    /// <summary>
//    /// 获取或设置 Grid事件集合
//    /// </summary>
//    public Collection<XEvent> Events { get; set; }

//    /// <summary>
//    /// 获取或者设置页脚
//    /// </summary>
//    public XGridFootCollection Foots { get; set; }

//    /// <summary>
//    /// 获取或设置子表集合
//    /// </summary>
//    public XGridChildCollection Childs { get; set; }

//    /// <summary>
//    /// 获取列显示格式设置
//    /// </summary>
//    public XGridColumnSetCollection ColumnSets { get; }

//    /// <summary>
//    /// 获取或设置网格合并对象集合
//    /// </summary>
//    public XGridColumnMergeCollection Merges { get; set; }

//    #endregion

//    /// <summary>
//    /// 遍历当前XML节点
//    /// </summary>
//    /// <param name="xnav">XPathNavigator对象</param>
//    protected virtual void ParseChild(XmlReader xnav)
//    {
//      if (null == xnav) return;
//      switch (xnav.Name)
//      {
//        //case "Column":
//        //  {
//        //    var column = new XGridColumn(xnav);
//        //    //if (column.Field == "RowIndex") HasRowIndexColumn = true;
//        //    Columns.Add(column);
//        //    break;
//        //  }
//        ////case "Tabs":
//        ////  ParseTabs(xnav);
//        ////  break;
//        //case "ColumnGroup":
//        //  ColumnGroup.Add(new XGridColumnGroup(xnav));
//        //  break;
//        //case "ColumnGroups":
//        //  ParseColumnGroups(xnav);
//        //  break;
//        //case "ColumnMerges":
//        //  ParseColumnMerges(xnav);
//        //  break;
//        case "Events":
//          ParseEvents(xnav);
//          break;
//        //case "Foots":
//        //  ParseFoots(xnav);
//        //  break;
//        default:
//          base.ParseChild(xnav);
//          break;
//      }
//    }
//    private void ParseColumnGroups(XmlReader xnav)
//    {
//      //if (xnav.MoveToFirstChild())
//      //{
//      //  do
//      //  {
//      //    if (xnav.Name == "ColumnGroup")
//      //      ColumnGroup.Add(new XGridColumnGroup(xnav));
//      //  } while (xnav.MoveToNext());
//      //  xnav.MoveToParent();
//      //}
//    }
//    private void ParseColumnMerges(XmlReader xnav)
//    {
//      //if (xnav.MoveToFirstAttribute())
//      //{
//      //  do
//      //  {
//      //    if (xnav.Name == "MergeRowHeader")
//      //    {
//      //      Merges.MergeRowHeader = xnav.Value.ToBoolean();
//      //    }
//      //  } while (xnav.MoveToNextAttribute());
//      //  xnav.MoveToParent();
//      //}
//      //if (xnav.MoveToFirstChild())
//      //{
//      //  do
//      //  {
//      //    if (xnav.Name == "ColumnMerge") Merges.Add(new XGridColumnMerge(xnav));
//      //  } while (xnav.MoveToNext());
//      //  xnav.MoveToParent();
//      //}
//    }
    
//    private void ParseEvents(XmlReader xnav)
//    {
//      //xnav.ReadSubtree();
//      //if (xnav.MoveToFirstChild())
//      //{
//      //  do
//      //  {
//      //    if (xnav.Name == "Event") Events.Add(new XEvent(xnav));
//      //  } while (xnav.MoveToNext());
//      //  xnav.MoveToParent();
//      //}
//    }
//    private void ParseFoots(XmlReader xnav)
//    {
//      //if (xnav.MoveToFirstChild())
//      //{
//      //  do
//      //  {
//      //    switch (xnav.Name)
//      //    {
//      //      case "Foot":
//      //        Foots.Add(new XGridFoot(xnav));
//      //        break;
//      //      case "DataSource":
//      //        //Foots.DataSource.Add(new SysDataSource(xnav));
//      //        break;
//      //    }
//      //  } while (xnav.MoveToNext());
//      //  xnav.MoveToParent();
//      //}
//    }
//    /// <summary>
//    /// 遍历当前XML节点子节点的属性
//    /// </summary>
//    /// <param name="nodeName">当前节点名称</param>
//    /// <param name="xnav">XPathNavigator对象</param>
//    protected virtual void ParseChildAttribute(string nodeName, XmlReader xnav)
//    {

//    }


//    /// <summary>
//    /// 根据XPathNavigator遍历和解释XML内容
//    /// </summary>
//    /// <param name="xnav">XPathNavigator对象</param>
//    protected virtual void Parse(XPathNavigator xnav) {
			
//      NamespaceURI = xnav.NamespaceURI;
//      if (xnav.MoveToFirstAttribute()) {
//        do {
//          switch (xnav.Name) {
//            case "Id":
//              Id = xnav.Value;
//              break;
//            default:
//              ParseAttribute(xnav.Name, xnav.Value);
//              break;
//          }
//        } while (xnav.MoveToNextAttribute());
//        xnav.MoveToParent();
//        if (string.IsNullOrEmpty(Id)) Id = Guid.NewGuid().ToString("N");
//        AfterParseAttribute();
//      }
//      if (xnav.MoveToFirstChild()) {
//        do {
//          if (xnav.NodeType == XPathNodeType.Comment) continue;
//          ParseChild(xnav);
//        } while (xnav.MoveToNext());
//        xnav.MoveToParent();
//        AfterParseChild();
//      }
//    }

//    /// <summary>
//    /// 遍历当前XML节点的属性
//    /// </summary>
//    /// <param name="name">XML节点属性名称</param>
//    /// <param name="value">XML节点属性值</param>
//    protected virtual void ParseAttribute(string name, string value) {

//    }

//    /// <summary>
//    /// 遍历当前XML节点的属性之后
//    /// </summary>
//    protected virtual void AfterParseAttribute() {

//    }

//    /// <summary>
//    /// 遍历当前XML节点
//    /// </summary>
//    /// <param name="xnav">XPathNavigator对象</param>
//    protected virtual void ParseChild(XPathNavigator xnav) {
//      if (null == xnav) return;
//      string nodeName = xnav.Name;
//      if (xnav.MoveToFirstAttribute()) {
//        do {
//          ParseChildAttribute(nodeName, xnav);
//        } while (xnav.MoveToNextAttribute());
//        xnav.MoveToParent();
//      }
//    }

//    protected virtual void AfterParseChild() {
//    }

//    /// <summary>
//    /// 遍历当前XML节点子节点的属性
//    /// </summary>
//    /// <param name="nodeName">当前节点名称</param>
//    /// <param name="xnav">XPathNavigator对象</param>
//    protected virtual void ParseChildAttribute(string nodeName, XPathNavigator xnav) {

//    }

//    protected void ParseChilds<T>(string nodeName, XPathNavigator xnav, Collection<T> collections)
//        where T : ISchema, new() {
//      if (xnav.MoveToFirstChild()) {
//        do {
//          if (xnav.Name == nodeName) {
//            var item = new T();
//            item.Parse(xnav);
//            collections.Add(item);
//          }
//        } while (xnav.MoveToNext());
//        xnav.MoveToParent();
//      }
//    }

//    #endregion

//    #region ICloneable 成员

//    /// <summary>
//    /// 创建作为当前实例副本的新对象。
//    /// </summary>
//    /// <returns>
//    /// 作为此实例副本的新对象。
//    /// </returns>
//    public virtual object Clone() {
//      return MemberwiseClone();
//    }

//    #endregion

//    public XSchema() {
//      Id = Guid.NewGuid().ToString("N");
//    }

//    /// <summary>
//    /// 
//    /// </summary>
//    /// <param name="reader"></param>
//    protected XSchema(XmlReader reader) { }

//    /// <summary>
//    /// 获取或设置唯一标识
//    /// </summary>
//    public string Id { get; set; }
//    // ReSharper disable once InconsistentNaming
//    public string NamespaceURI { get; set; }
//  }

//  /// <summary>
//  /// 系统基础集合对象
//  /// </summary>
//  [Serializable]
//  public class SysCollection<T> :
//      KeyedCollection<string, T>
//      where T : ISchema {

//    /// <summary>
//    /// 在派生类中实现时，将从指定元素提取键
//    /// </summary>
//    /// <param name="item">从中提取键的元素</param>
//    /// <returns>
//    /// 指定元素的键
//    /// </returns>
//    protected override string GetKeyForItem(T item) {
//      return item.Id;
//    }

//    /// <summary>
//    /// 将元素插入<see cref="T:System.Collections.ObjectModel.KeyedCollection`2" /> 的指定索引处
//    /// </summary>
//    /// <param name="index">从零开始的索引，应在该位置插入<paramref name="item" /></param>
//    /// <param name="item">要插入的对象</param>
//    protected override void InsertItem(int index, T item) {
//      if (!Contains(item.Id)) base.InsertItem(index, item);
//    }
//  }
//}
