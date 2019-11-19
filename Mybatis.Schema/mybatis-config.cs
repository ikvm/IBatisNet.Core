namespace Mybatis.Configuration
{
  /// <remarks/>
  public partial class configuration
  {

    private properties propertiesField;

    private setting[] settingsField;

    private typeAliases typeAliasesField;

    private typeHandlers typeHandlersField;

    private objectFactory objectFactoryField;

    private objectWrapperFactory objectWrapperFactoryField;

    private reflectorFactory reflectorFactoryField;

    private plugin[] pluginsField;

    private environments environmentsField;

    private databaseIdProvider databaseIdProviderField;

    private mappers mappersField;

    /// <remarks/>
    public properties properties
    {
      get
      {
        return this.propertiesField;
      }
      set
      {
        this.propertiesField = value;
      }
    }

    /// <remarks/>
    public setting[] settings
    {
      get
      {
        return this.settingsField;
      }
      set
      {
        this.settingsField = value;
      }
    }

    /// <remarks/>
    public typeAliases typeAliases
    {
      get
      {
        return this.typeAliasesField;
      }
      set
      {
        this.typeAliasesField = value;
      }
    }

    /// <remarks/>
    public typeHandlers typeHandlers
    {
      get
      {
        return this.typeHandlersField;
      }
      set
      {
        this.typeHandlersField = value;
      }
    }

    /// <remarks/>
    public objectFactory objectFactory
    {
      get
      {
        return this.objectFactoryField;
      }
      set
      {
        this.objectFactoryField = value;
      }
    }

    /// <remarks/>
    public objectWrapperFactory objectWrapperFactory
    {
      get
      {
        return this.objectWrapperFactoryField;
      }
      set
      {
        this.objectWrapperFactoryField = value;
      }
    }

    /// <remarks/>
    public reflectorFactory reflectorFactory
    {
      get
      {
        return this.reflectorFactoryField;
      }
      set
      {
        this.reflectorFactoryField = value;
      }
    }

    /// <remarks/>
    public plugin[] plugins
    {
      get
      {
        return this.pluginsField;
      }
      set
      {
        this.pluginsField = value;
      }
    }

    /// <remarks/>
    public environments environments
    {
      get
      {
        return this.environmentsField;
      }
      set
      {
        this.environmentsField = value;
      }
    }

    /// <remarks/>
    public databaseIdProvider databaseIdProvider
    {
      get
      {
        return this.databaseIdProviderField;
      }
      set
      {
        this.databaseIdProviderField = value;
      }
    }

    /// <remarks/>
    public mappers mappers
    {
      get
      {
        return this.mappersField;
      }
      set
      {
        this.mappersField = value;
      }
    }
  }

  /// <remarks/>
  public partial class properties
  {

    private property[] propertyField;

    private string resourceField;

    private string urlField;

    /// <remarks/>
    public property[] property
    {
      get
      {
        return this.propertyField;
      }
      set
      {
        this.propertyField = value;
      }
    }

    /// <remarks/>
    public string resource
    {
      get
      {
        return this.resourceField;
      }
      set
      {
        this.resourceField = value;
      }
    }

    /// <remarks/>
    public string url
    {
      get
      {
        return this.urlField;
      }
      set
      {
        this.urlField = value;
      }
    }
  }

  /// <remarks/>
  public partial class property
  {

    private string nameField;

    private string valueField;

    /// <remarks/>
    public string name
    {
      get
      {
        return this.nameField;
      }
      set
      {
        this.nameField = value;
      }
    }

    /// <remarks/>
    public string value
    {
      get
      {
        return this.valueField;
      }
      set
      {
        this.valueField = value;
      }
    }
  }

  /// <remarks/>
  public partial class setting
  {

    private string nameField;

    private string valueField;

    /// <remarks/>
    public string name
    {
      get
      {
        return this.nameField;
      }
      set
      {
        this.nameField = value;
      }
    }

    /// <remarks/>
    public string value
    {
      get
      {
        return this.valueField;
      }
      set
      {
        this.valueField = value;
      }
    }
  }

  /// <remarks/>
  public partial class typeAliases
  {

    private typeAlias[] typeAliasField;

    private package[] packageField;

    /// <remarks/>
    public typeAlias[] typeAlias
    {
      get
      {
        return this.typeAliasField;
      }
      set
      {
        this.typeAliasField = value;
      }
    }

    /// <remarks/>
    public package[] package
    {
      get
      {
        return this.packageField;
      }
      set
      {
        this.packageField = value;
      }
    }
  }

  /// <remarks/>
  public partial class typeAlias
  {

    private string typeField;

    private string aliasField;

    /// <remarks/>
    public string type
    {
      get
      {
        return this.typeField;
      }
      set
      {
        this.typeField = value;
      }
    }

    /// <remarks/>
    public string alias
    {
      get
      {
        return this.aliasField;
      }
      set
      {
        this.aliasField = value;
      }
    }
  }

  /// <remarks/>
  public partial class package
  {

    private string nameField;

    /// <remarks/>
    public string name
    {
      get
      {
        return this.nameField;
      }
      set
      {
        this.nameField = value;
      }
    }
  }

  /// <remarks/>
  public partial class typeHandlers
  {

    private typeHandler[] typeHandlerField;

    private package[] packageField;

    /// <remarks/>
    public typeHandler[] typeHandler
    {
      get
      {
        return this.typeHandlerField;
      }
      set
      {
        this.typeHandlerField = value;
      }
    }

    /// <remarks/>
    public package[] package
    {
      get
      {
        return this.packageField;
      }
      set
      {
        this.packageField = value;
      }
    }
  }

  /// <remarks/>
  public partial class typeHandler
  {

    private string javaTypeField;

    private string jdbcTypeField;

    private string handlerField;

    /// <remarks/>
    public string javaType
    {
      get
      {
        return this.javaTypeField;
      }
      set
      {
        this.javaTypeField = value;
      }
    }

    /// <remarks/>
    public string jdbcType
    {
      get
      {
        return this.jdbcTypeField;
      }
      set
      {
        this.jdbcTypeField = value;
      }
    }

    /// <remarks/>
    public string handler
    {
      get
      {
        return this.handlerField;
      }
      set
      {
        this.handlerField = value;
      }
    }
  }

  /// <remarks/>
  public partial class objectFactory
  {

    private property[] propertyField;

    private string typeField;

    /// <remarks/>
    public property[] property
    {
      get
      {
        return this.propertyField;
      }
      set
      {
        this.propertyField = value;
      }
    }

    /// <remarks/>
    public string type
    {
      get
      {
        return this.typeField;
      }
      set
      {
        this.typeField = value;
      }
    }
  }

  /// <remarks/>
  public partial class objectWrapperFactory
  {

    private string typeField;

    /// <remarks/>
    public string type
    {
      get
      {
        return this.typeField;
      }
      set
      {
        this.typeField = value;
      }
    }
  }

  /// <remarks/>
  public partial class reflectorFactory
  {

    private string typeField;

    /// <remarks/>
    public string type
    {
      get
      {
        return this.typeField;
      }
      set
      {
        this.typeField = value;
      }
    }
  }

  /// <remarks/>
  public partial class plugin
  {

    private property[] propertyField;

    private string interceptorField;

    /// <remarks/>
    public property[] property
    {
      get
      {
        return this.propertyField;
      }
      set
      {
        this.propertyField = value;
      }
    }

    /// <remarks/>
    public string interceptor
    {
      get
      {
        return this.interceptorField;
      }
      set
      {
        this.interceptorField = value;
      }
    }
  }

  /// <remarks/>
  public partial class environments
  {

    private environment[] environmentField;

    private string defaultField;

    /// <remarks/>
    public environment[] environment
    {
      get
      {
        return this.environmentField;
      }
      set
      {
        this.environmentField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string @default
    {
      get
      {
        return this.defaultField;
      }
      set
      {
        this.defaultField = value;
      }
    }
  }

  /// <remarks/>
  public partial class environment
  {

    private transactionManager transactionManagerField;

    private dataSource dataSourceField;

    private string idField;

    /// <remarks/>
    public transactionManager transactionManager
    {
      get
      {
        return this.transactionManagerField;
      }
      set
      {
        this.transactionManagerField = value;
      }
    }

    /// <remarks/>
    public dataSource dataSource
    {
      get
      {
        return this.dataSourceField;
      }
      set
      {
        this.dataSourceField = value;
      }
    }

    /// <remarks/>
    public string id
    {
      get
      {
        return this.idField;
      }
      set
      {
        this.idField = value;
      }
    }
  }

  /// <remarks/>
  public partial class transactionManager
  {

    private property[] propertyField;

    private string typeField;

    /// <remarks/>
    public property[] property
    {
      get
      {
        return this.propertyField;
      }
      set
      {
        this.propertyField = value;
      }
    }

    /// <remarks/>
    public string type
    {
      get
      {
        return this.typeField;
      }
      set
      {
        this.typeField = value;
      }
    }
  }

  /// <remarks/>
  public partial class dataSource
  {

    private property[] propertyField;

    private string typeField;

    /// <remarks/>
    public property[] property
    {
      get
      {
        return this.propertyField;
      }
      set
      {
        this.propertyField = value;
      }
    }

    /// <remarks/>
    public string type
    {
      get
      {
        return this.typeField;
      }
      set
      {
        this.typeField = value;
      }
    }
  }

  /// <remarks/>
  public partial class databaseIdProvider
  {

    private property[] propertyField;

    private string typeField;

    /// <remarks/>
    public property[] property
    {
      get
      {
        return this.propertyField;
      }
      set
      {
        this.propertyField = value;
      }
    }

    /// <remarks/>
    public string type
    {
      get
      {
        return this.typeField;
      }
      set
      {
        this.typeField = value;
      }
    }
  }

  /// <remarks/>
  public partial class mappers
  {

    private mapper[] mapperField;

    private package[] packageField;

    /// <remarks/>
    public mapper[] mapper
    {
      get
      {
        return this.mapperField;
      }
      set
      {
        this.mapperField = value;
      }
    }

    /// <remarks/>
    public package[] package
    {
      get
      {
        return this.packageField;
      }
      set
      {
        this.packageField = value;
      }
    }
  }

  /// <remarks/>
  public partial class mapper
  {

    private string resourceField;

    private string urlField;

    private string classField;

    /// <remarks/>
    public string resource
    {
      get
      {
        return this.resourceField;
      }
      set
      {
        this.resourceField = value;
      }
    }

    /// <remarks/>
    public string url
    {
      get
      {
        return this.urlField;
      }
      set
      {
        this.urlField = value;
      }
    }

    /// <remarks/>
    public string @class
    {
      get
      {
        return this.classField;
      }
      set
      {
        this.classField = value;
      }
    }
  }

  /// <remarks/>
  public partial class settings
  {

    private setting[] settingField;

    /// <remarks/>
    public setting[] setting
    {
      get
      {
        return this.settingField;
      }
      set
      {
        this.settingField = value;
      }
    }
  }

  /// <remarks/>
  public partial class plugins
  {

    private plugin[] pluginField;

    /// <remarks/>
    public plugin[] plugin
    {
      get
      {
        return this.pluginField;
      }
      set
      {
        this.pluginField = value;
      }
    }
  }
}
