namespace System.Xml
{
  public class XSetting : XSchema
  {
    public XSetting(){}
    public XSetting(XmlReader reader) : base(reader) { }
    protected override void ParseAttribute(string name, string value)
    {
      switch (name)
      {
        case "name":
          this.name = value;
          break;
        case "value":
          this.value = value;
          break;
      }
    }

    /// <summary>
    /// ��ȡ�ڵ�����
    /// </summary>
    /// <value>�ڵ�����</value>
    protected override string NodeName { get { return "setting"; } }

    protected override void ParseChild(XmlReader xnav)
    {
      //base.ParseChild(xnav);
    }

    /// <remarks/>
    public string name { get; set; }

    /// <remarks/>
    public string value { get; set; }
  }
}