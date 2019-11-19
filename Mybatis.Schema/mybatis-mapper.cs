namespace Mybatis.Configuration
{
  /// <remarks/>
  public partial class mapper
  {
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("cache", typeof(cache))]
    public cache[] caches { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("cache-ref", typeof(cacheref))]
    public cacheref[] cacherefs { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("delete", typeof(delete))]
    public delete[] deletes { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("insert", typeof(insert))]
    public insert[] inserts { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("parameterMap", typeof(parameterMap))]
    public parameterMap[] parameterMaps { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("resultMap", typeof(resultMap))]
    public resultMap[] resultMaps { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("select", typeof(select))]
    public select[] selects { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("sql", typeof(sql))]
    public sql[] sqls { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("update", typeof(update))]
    public update[] updates { get; set; }
    //public object[] Items { get; set; }

    /// <remarks/>
    public string @namespace { get; set; }
  }

  /// <remarks/>
  public partial class cache
  {
    /// <remarks/>
    public property[] property { get; set; }

    /// <remarks/>
    public string type { get; set; }

    /// <remarks/>
    public string eviction { get; set; }

    /// <remarks/>
    public string flushInterval { get; set; }

    /// <remarks/>
    public string size { get; set; }

    /// <remarks/>
    public string readOnly { get; set; }

    /// <remarks/>
    public string blocking { get; set; }
  }

  ///// <remarks/>
  //public partial class property
  //{
  //  /// <remarks/>
  //  public string name { get; set; }

  //  /// <remarks/>
  //  public string value { get; set; }
  //}

  /// <remarks/>
  public partial class cacheref
  {
    /// <remarks/>
    public string @namespace { get; set; }
  }

  /// <remarks/>
  public partial class delete
  {
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("bind", typeof(bind))]
    public bind[] binds { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("choose", typeof(choose))]
    public choose[] chooses { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("foreach", typeof(@foreach))]
    public @foreach foreachs { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("if", typeof(@if))]
    public @if[] ifs { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("include", typeof(include))]
    public include[] includes { get; set; }

    [System.Xml.Serialization.XmlElementAttribute("set", typeof(set))]
    [System.Xml.Serialization.XmlElementAttribute("trim", typeof(trim))]
    [System.Xml.Serialization.XmlElementAttribute("where", typeof(where))]
    public object[] Items { get; set; }

    /// <remarks/>
    public string[] Text { get; set; }

    /// <remarks/>
    public string id { get; set; }

    /// <remarks/>
    public string parameterMap { get; set; }

    /// <remarks/>
    public string parameterType { get; set; }

    /// <remarks/>
    public string timeout { get; set; }

    /// <remarks/>
    public deleteFlushCache flushCache { get; set; }

    /// <remarks/>
    public bool flushCacheSpecified { get; set; }

    /// <remarks/>
    public deleteStatementType statementType { get; set; }

    /// <remarks/>
    public bool statementTypeSpecified { get; set; }

    /// <remarks/>
    public string databaseId { get; set; }

    /// <remarks/>
    public string lang { get; set; }
  }

  /// <remarks/>
  public partial class bind
  {
    /// <remarks/>
    public string name { get; set; }

    /// <remarks/>
    public string value { get; set; }
  }

  /// <remarks/>
  public partial class choose
  {
    /// <remarks/>
    public when[] when { get; set; }

    /// <remarks/>
    public otherwise otherwise { get; set; }
  }

  /// <remarks/>
  public partial class when
  {
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("bind", typeof(bind))]
    [System.Xml.Serialization.XmlElementAttribute("choose", typeof(choose))]
    [System.Xml.Serialization.XmlElementAttribute("foreach", typeof(@foreach))]
    [System.Xml.Serialization.XmlElementAttribute("if", typeof(@if))]
    [System.Xml.Serialization.XmlElementAttribute("include", typeof(include))]
    [System.Xml.Serialization.XmlElementAttribute("set", typeof(set))]
    [System.Xml.Serialization.XmlElementAttribute("trim", typeof(trim))]
    [System.Xml.Serialization.XmlElementAttribute("where", typeof(where))]
    public object[] Items { get; set; }

    /// <remarks/>
    public string[] Text { get; set; }

    /// <remarks/>
    public string test { get; set; }
  }

  /// <remarks/>
  public partial class @foreach
  {
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("bind", typeof(bind))]
    [System.Xml.Serialization.XmlElementAttribute("choose", typeof(choose))]
    [System.Xml.Serialization.XmlElementAttribute("foreach", typeof(@foreach))]
    [System.Xml.Serialization.XmlElementAttribute("if", typeof(@if))]
    [System.Xml.Serialization.XmlElementAttribute("include", typeof(include))]
    [System.Xml.Serialization.XmlElementAttribute("set", typeof(set))]
    [System.Xml.Serialization.XmlElementAttribute("trim", typeof(trim))]
    [System.Xml.Serialization.XmlElementAttribute("where", typeof(where))]
    public object[] Items { get; set; }

    /// <remarks/>
    public string[] Text { get; set; }

    /// <remarks/>
    public string collection { get; set; }

    /// <remarks/>
    public string item { get; set; }

    /// <remarks/>
    public string index { get; set; }

    /// <remarks/>
    public string open { get; set; }

    /// <remarks/>
    public string close { get; set; }

    /// <remarks/>
    public string separator { get; set; }
  }

  /// <remarks/>
  public partial class @if
  {
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("bind", typeof(bind))]
    [System.Xml.Serialization.XmlElementAttribute("choose", typeof(choose))]
    [System.Xml.Serialization.XmlElementAttribute("foreach", typeof(@foreach))]
    [System.Xml.Serialization.XmlElementAttribute("if", typeof(@if))]
    [System.Xml.Serialization.XmlElementAttribute("include", typeof(include))]
    [System.Xml.Serialization.XmlElementAttribute("set", typeof(set))]
    [System.Xml.Serialization.XmlElementAttribute("trim", typeof(trim))]
    [System.Xml.Serialization.XmlElementAttribute("where", typeof(where))]
    public object[] Items { get; set; }

    /// <remarks/>
    public string[] Text { get; set; }

    /// <remarks/>
    public string test { get; set; }
  }

  /// <remarks/>
  public partial class include
  {
    /// <remarks/>
    public property[] property { get; set; }

    /// <remarks/>
    public string refid { get; set; }
  }

  /// <remarks/>
  public partial class set
  {
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("bind", typeof(bind))]
    [System.Xml.Serialization.XmlElementAttribute("choose", typeof(choose))]
    [System.Xml.Serialization.XmlElementAttribute("foreach", typeof(@foreach))]
    [System.Xml.Serialization.XmlElementAttribute("if", typeof(@if))]
    [System.Xml.Serialization.XmlElementAttribute("include", typeof(include))]
    [System.Xml.Serialization.XmlElementAttribute("set", typeof(set))]
    [System.Xml.Serialization.XmlElementAttribute("trim", typeof(trim))]
    [System.Xml.Serialization.XmlElementAttribute("where", typeof(where))]
    public object[] Items { get; set; }

    /// <remarks/>
    public string[] Text { get; set; }
  }

  /// <remarks/>
  public partial class trim
  {
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("bind", typeof(bind))]
    [System.Xml.Serialization.XmlElementAttribute("choose", typeof(choose))]
    [System.Xml.Serialization.XmlElementAttribute("foreach", typeof(@foreach))]
    [System.Xml.Serialization.XmlElementAttribute("if", typeof(@if))]
    [System.Xml.Serialization.XmlElementAttribute("include", typeof(include))]
    [System.Xml.Serialization.XmlElementAttribute("set", typeof(set))]
    [System.Xml.Serialization.XmlElementAttribute("trim", typeof(trim))]
    [System.Xml.Serialization.XmlElementAttribute("where", typeof(where))]
    public object[] Items { get; set; }

    /// <remarks/>
    public string[] Text { get; set; }

    /// <remarks/>
    public string prefix { get; set; }

    /// <remarks/>
    public string prefixOverrides { get; set; }

    /// <remarks/>
    public string suffix { get; set; }

    /// <remarks/>
    public string suffixOverrides { get; set; }
  }

  /// <remarks/>
  public partial class where
  {
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("bind", typeof(bind))]
    [System.Xml.Serialization.XmlElementAttribute("choose", typeof(choose))]
    [System.Xml.Serialization.XmlElementAttribute("foreach", typeof(@foreach))]
    [System.Xml.Serialization.XmlElementAttribute("if", typeof(@if))]
    [System.Xml.Serialization.XmlElementAttribute("include", typeof(include))]
    [System.Xml.Serialization.XmlElementAttribute("set", typeof(set))]
    [System.Xml.Serialization.XmlElementAttribute("trim", typeof(trim))]
    [System.Xml.Serialization.XmlElementAttribute("where", typeof(where))]
    public object[] Items { get; set; }

    /// <remarks/>
    public string[] Text { get; set; }
  }

  /// <remarks/>
  public partial class otherwise
  {
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("bind", typeof(bind))]
    [System.Xml.Serialization.XmlElementAttribute("choose", typeof(choose))]
    [System.Xml.Serialization.XmlElementAttribute("foreach", typeof(@foreach))]
    [System.Xml.Serialization.XmlElementAttribute("if", typeof(@if))]
    [System.Xml.Serialization.XmlElementAttribute("include", typeof(include))]
    [System.Xml.Serialization.XmlElementAttribute("set", typeof(set))]
    [System.Xml.Serialization.XmlElementAttribute("trim", typeof(trim))]
    [System.Xml.Serialization.XmlElementAttribute("where", typeof(where))]
    public object[] Items { get; set; }

    /// <remarks/>
    public string[] Text { get; set; }
  }

  /// <remarks/>
  public enum deleteFlushCache
  {

    /// <remarks/>
    @true,

    /// <remarks/>
    @false,
  }

  /// <remarks/>
  public enum deleteStatementType
  {

    /// <remarks/>
    STATEMENT,

    /// <remarks/>
    PREPARED,

    /// <remarks/>
    CALLABLE,
  }

  /// <remarks/>
  public partial class insert
  {
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("bind", typeof(bind))]
    [System.Xml.Serialization.XmlElementAttribute("choose", typeof(choose))]
    [System.Xml.Serialization.XmlElementAttribute("foreach", typeof(@foreach))]
    [System.Xml.Serialization.XmlElementAttribute("if", typeof(@if))]
    [System.Xml.Serialization.XmlElementAttribute("include", typeof(include))]
    [System.Xml.Serialization.XmlElementAttribute("selectKey", typeof(selectKey))]
    [System.Xml.Serialization.XmlElementAttribute("set", typeof(set))]
    [System.Xml.Serialization.XmlElementAttribute("trim", typeof(trim))]
    [System.Xml.Serialization.XmlElementAttribute("where", typeof(where))]
    public object[] Items { get; set; }

    /// <remarks/>
    public string[] Text { get; set; }

    /// <remarks/>
    public string id { get; set; }

    /// <remarks/>
    public string parameterMap { get; set; }

    /// <remarks/>
    public string parameterType { get; set; }

    /// <remarks/>
    public string timeout { get; set; }

    /// <remarks/>
    public insertFlushCache flushCache { get; set; }

    /// <remarks/>
    public bool flushCacheSpecified { get; set; }

    /// <remarks/>
    public insertStatementType statementType { get; set; }

    /// <remarks/>
    public bool statementTypeSpecified { get; set; }

    /// <remarks/>
    public string keyProperty { get; set; }

    /// <remarks/>
    public insertUseGeneratedKeys useGeneratedKeys { get; set; }

    /// <remarks/>
    public bool useGeneratedKeysSpecified { get; set; }

    /// <remarks/>
    public string keyColumn { get; set; }

    /// <remarks/>
    public string databaseId { get; set; }

    /// <remarks/>
    public string lang { get; set; }
  }

  /// <remarks/>
  public partial class selectKey
  {
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("bind", typeof(bind))]
    [System.Xml.Serialization.XmlElementAttribute("choose", typeof(choose))]
    [System.Xml.Serialization.XmlElementAttribute("foreach", typeof(@foreach))]
    [System.Xml.Serialization.XmlElementAttribute("if", typeof(@if))]
    [System.Xml.Serialization.XmlElementAttribute("include", typeof(include))]
    [System.Xml.Serialization.XmlElementAttribute("set", typeof(set))]
    [System.Xml.Serialization.XmlElementAttribute("trim", typeof(trim))]
    [System.Xml.Serialization.XmlElementAttribute("where", typeof(where))]
    public object[] Items { get; set; }

    /// <remarks/>
    public string[] Text { get; set; }

    /// <remarks/>
    public string resultType { get; set; }

    /// <remarks/>
    public selectKeyStatementType statementType { get; set; }

    /// <remarks/>
    public bool statementTypeSpecified { get; set; }

    /// <remarks/>
    public string keyProperty { get; set; }

    /// <remarks/>
    public string keyColumn { get; set; }

    /// <remarks/>
    public selectKeyOrder order { get; set; }

    /// <remarks/>
    public bool orderSpecified { get; set; }

    /// <remarks/>
    public string databaseId { get; set; }
  }

  /// <remarks/>
  public enum selectKeyStatementType
  {

    /// <remarks/>
    STATEMENT,

    /// <remarks/>
    PREPARED,

    /// <remarks/>
    CALLABLE,
  }

  /// <remarks/>
  public enum selectKeyOrder
  {

    /// <remarks/>
    BEFORE,

    /// <remarks/>
    AFTER,
  }

  /// <remarks/>
  public enum insertFlushCache
  {

    /// <remarks/>
    @true,

    /// <remarks/>
    @false,
  }

  /// <remarks/>
  public enum insertStatementType
  {

    /// <remarks/>
    STATEMENT,

    /// <remarks/>
    PREPARED,

    /// <remarks/>
    CALLABLE,
  }

  /// <remarks/>
  public enum insertUseGeneratedKeys
  {

    /// <remarks/>
    @true,

    /// <remarks/>
    @false,
  }

  /// <remarks/>
  public partial class parameterMap
  {
    /// <remarks/>
    public parameter[] parameter { get; set; }

    /// <remarks/>
    public string id { get; set; }

    /// <remarks/>
    public string type { get; set; }
  }

  /// <remarks/>
  public partial class parameter
  {
    /// <remarks/>
    public string property { get; set; }

    /// <remarks/>
    public string javaType { get; set; }

    /// <remarks/>
    public string jdbcType { get; set; }

    /// <remarks/>
    public parameterMode mode { get; set; }

    /// <remarks/>
    public bool modeSpecified { get; set; }

    /// <remarks/>
    public string resultMap { get; set; }

    /// <remarks/>
    public string scale { get; set; }

    /// <remarks/>
    public string typeHandler { get; set; }
  }

  /// <remarks/>
  public enum parameterMode
  {

    /// <remarks/>
    IN,

    /// <remarks/>
    OUT,

    /// <remarks/>
    INOUT,
  }

  /// <remarks/>
  public partial class resultMap
  {
    /// <remarks/>
    public constructor constructor { get; set; }

    /// <remarks/>
    public id[] id { get; set; }

    /// <remarks/>
    public result[] result { get; set; }

    /// <remarks/>
    public association[] association { get; set; }

    /// <remarks/>
    public collection[] collection { get; set; }

    /// <remarks/>
    public discriminator discriminator { get; set; }

    /// <remarks/>
    public string id1 { get; set; }

    /// <remarks/>
    public string type { get; set; }

    /// <remarks/>
    public string extends { get; set; }

    /// <remarks/>
    public resultMapAutoMapping autoMapping { get; set; }

    /// <remarks/>
    public bool autoMappingSpecified { get; set; }
  }

  /// <remarks/>
  public partial class constructor
  {
    /// <remarks/>
    public idArg[] idArg { get; set; }

    /// <remarks/>
    public arg[] arg { get; set; }
  }

  /// <remarks/>
  public partial class idArg
  {
    /// <remarks/>
    public string javaType { get; set; }

    /// <remarks/>
    public string column { get; set; }

    /// <remarks/>
    public string jdbcType { get; set; }

    /// <remarks/>
    public string typeHandler { get; set; }

    /// <remarks/>
    public string select { get; set; }

    /// <remarks/>
    public string resultMap { get; set; }

    /// <remarks/>
    public string name { get; set; }

    /// <remarks/>
    public string columnPrefix { get; set; }
  }

  /// <remarks/>
  public partial class arg
  {
    /// <remarks/>
    public string javaType { get; set; }

    /// <remarks/>
    public string column { get; set; }

    /// <remarks/>
    public string jdbcType { get; set; }

    /// <remarks/>
    public string typeHandler { get; set; }

    /// <remarks/>
    public string select { get; set; }

    /// <remarks/>
    public string resultMap { get; set; }

    /// <remarks/>
    public string name { get; set; }

    /// <remarks/>
    public string columnPrefix { get; set; }
  }

  /// <remarks/>
  public partial class id
  {
    /// <remarks/>
    public string property { get; set; }

    /// <remarks/>
    public string javaType { get; set; }

    /// <remarks/>
    public string column { get; set; }

    /// <remarks/>
    public string jdbcType { get; set; }

    /// <remarks/>
    public string typeHandler { get; set; }
  }

  /// <remarks/>
  public partial class result
  {
    /// <remarks/>
    public string property { get; set; }

    /// <remarks/>
    public string javaType { get; set; }

    /// <remarks/>
    public string column { get; set; }

    /// <remarks/>
    public string jdbcType { get; set; }

    /// <remarks/>
    public string typeHandler { get; set; }
  }

  /// <remarks/>
  public partial class association
  {
    /// <remarks/>
    public constructor constructor { get; set; }

    /// <remarks/>
    public id[] id { get; set; }

    /// <remarks/>
    public result[] result { get; set; }

    /// <remarks/>
    public association[] association1 { get; set; }

    /// <remarks/>
    public collection[] collection { get; set; }

    /// <remarks/>
    public discriminator discriminator { get; set; }

    /// <remarks/>
    public string property { get; set; }

    /// <remarks/>
    public string column { get; set; }

    /// <remarks/>
    public string javaType { get; set; }

    /// <remarks/>
    public string jdbcType { get; set; }

    /// <remarks/>
    public string select { get; set; }

    /// <remarks/>
    public string resultMap { get; set; }

    /// <remarks/>
    public string typeHandler { get; set; }

    /// <remarks/>
    public string notNullColumn { get; set; }

    /// <remarks/>
    public string columnPrefix { get; set; }

    /// <remarks/>
    public string resultSet { get; set; }

    /// <remarks/>
    public string foreignColumn { get; set; }

    /// <remarks/>
    public associationAutoMapping autoMapping { get; set; }

    /// <remarks/>
    public bool autoMappingSpecified { get; set; }

    /// <remarks/>
    public associationFetchType fetchType { get; set; }

    /// <remarks/>
    public bool fetchTypeSpecified { get; set; }
  }

  /// <remarks/>
  public partial class collection
  {
    /// <remarks/>
    public constructor constructor { get; set; }

    /// <remarks/>
    public id[] id { get; set; }

    /// <remarks/>
    public result[] result { get; set; }

    /// <remarks/>
    public association[] association { get; set; }

    /// <remarks/>
    public collection[] collection1 { get; set; }

    /// <remarks/>
    public discriminator discriminator { get; set; }

    /// <remarks/>
    public string property { get; set; }

    /// <remarks/>
    public string column { get; set; }

    /// <remarks/>
    public string javaType { get; set; }

    /// <remarks/>
    public string ofType { get; set; }

    /// <remarks/>
    public string jdbcType { get; set; }

    /// <remarks/>
    public string select { get; set; }

    /// <remarks/>
    public string resultMap { get; set; }

    /// <remarks/>
    public string typeHandler { get; set; }

    /// <remarks/>
    public string notNullColumn { get; set; }

    /// <remarks/>
    public string columnPrefix { get; set; }

    /// <remarks/>
    public string resultSet { get; set; }

    /// <remarks/>
    public string foreignColumn { get; set; }

    /// <remarks/>
    public collectionAutoMapping autoMapping { get; set; }

    /// <remarks/>
    public bool autoMappingSpecified { get; set; }

    /// <remarks/>
    public collectionFetchType fetchType { get; set; }

    /// <remarks/>
    public bool fetchTypeSpecified { get; set; }
  }

  /// <remarks/>
  public partial class discriminator
  {
    /// <remarks/>
    public @case[] @case { get; set; }

    /// <remarks/>
    public string column { get; set; }

    /// <remarks/>
    public string javaType { get; set; }

    /// <remarks/>
    public string jdbcType { get; set; }

    /// <remarks/>
    public string typeHandler { get; set; }
  }

  /// <remarks/>
  public partial class @case
  {
    /// <remarks/>
    public constructor constructor { get; set; }

    /// <remarks/>
    public id[] id { get; set; }

    /// <remarks/>
    public result[] result { get; set; }

    /// <remarks/>
    public association[] association { get; set; }

    /// <remarks/>
    public collection[] collection { get; set; }

    /// <remarks/>
    public discriminator discriminator { get; set; }

    /// <remarks/>
    public string value { get; set; }

    /// <remarks/>
    public string resultMap { get; set; }

    /// <remarks/>
    public string resultType { get; set; }
  }

  /// <remarks/>
  public enum collectionAutoMapping
  {

    /// <remarks/>
    @true,

    /// <remarks/>
    @false,
  }

  /// <remarks/>
  public enum collectionFetchType
  {

    /// <remarks/>
    lazy,

    /// <remarks/>
    eager,
  }

  /// <remarks/>
  public enum associationAutoMapping
  {

    /// <remarks/>
    @true,

    /// <remarks/>
    @false,
  }

  /// <remarks/>
  public enum associationFetchType
  {

    /// <remarks/>
    lazy,

    /// <remarks/>
    eager,
  }

  /// <remarks/>
  public enum resultMapAutoMapping
  {

    /// <remarks/>
    @true,

    /// <remarks/>
    @false,
  }

  /// <remarks/>
  public partial class select
  {
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("bind", typeof(bind))]
    [System.Xml.Serialization.XmlElementAttribute("choose", typeof(choose))]
    [System.Xml.Serialization.XmlElementAttribute("foreach", typeof(@foreach))]
    [System.Xml.Serialization.XmlElementAttribute("if", typeof(@if))]
    [System.Xml.Serialization.XmlElementAttribute("include", typeof(include))]
    [System.Xml.Serialization.XmlElementAttribute("set", typeof(set))]
    [System.Xml.Serialization.XmlElementAttribute("trim", typeof(trim))]
    [System.Xml.Serialization.XmlElementAttribute("where", typeof(where))]
    public object[] Items { get; set; }

    /// <remarks/>
    public string[] Text { get; set; }

    /// <remarks/>
    public string id { get; set; }

    /// <remarks/>
    public string parameterMap { get; set; }

    /// <remarks/>
    public string parameterType { get; set; }

    /// <remarks/>
    public string resultMap { get; set; }

    /// <remarks/>
    public string resultType { get; set; }

    /// <remarks/>
    public selectResultSetType resultSetType { get; set; }

    /// <remarks/>
    public bool resultSetTypeSpecified { get; set; }

    /// <remarks/>
    public selectStatementType statementType { get; set; }

    /// <remarks/>
    public bool statementTypeSpecified { get; set; }

    /// <remarks/>
    public string fetchSize { get; set; }

    /// <remarks/>
    public string timeout { get; set; }

    /// <remarks/>
    public selectFlushCache flushCache { get; set; }

    /// <remarks/>
    public bool flushCacheSpecified { get; set; }

    /// <remarks/>
    public selectUseCache useCache { get; set; }

    /// <remarks/>
    public bool useCacheSpecified { get; set; }

    /// <remarks/>
    public string databaseId { get; set; }

    /// <remarks/>
    public string lang { get; set; }

    /// <remarks/>
    public selectResultOrdered resultOrdered { get; set; }

    /// <remarks/>
    public bool resultOrderedSpecified { get; set; }

    /// <remarks/>
    public string resultSets { get; set; }
  }

  /// <remarks/>
  public enum selectResultSetType
  {

    /// <remarks/>
    FORWARD_ONLY,

    /// <remarks/>
    SCROLL_INSENSITIVE,

    /// <remarks/>
    SCROLL_SENSITIVE,

    /// <remarks/>
    DEFAULT,
  }

  /// <remarks/>
  public enum selectStatementType
  {

    /// <remarks/>
    STATEMENT,

    /// <remarks/>
    PREPARED,

    /// <remarks/>
    CALLABLE,
  }

  /// <remarks/>
  public enum selectFlushCache
  {

    /// <remarks/>
    @true,

    /// <remarks/>
    @false,
  }

  /// <remarks/>
  public enum selectUseCache
  {

    /// <remarks/>
    @true,

    /// <remarks/>
    @false,
  }

  /// <remarks/>
  public enum selectResultOrdered
  {

    /// <remarks/>
    @true,

    /// <remarks/>
    @false,
  }

  /// <remarks/>
  public partial class sql
  {
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("bind", typeof(bind))]
    [System.Xml.Serialization.XmlElementAttribute("choose", typeof(choose))]
    [System.Xml.Serialization.XmlElementAttribute("foreach", typeof(@foreach))]
    [System.Xml.Serialization.XmlElementAttribute("if", typeof(@if))]
    [System.Xml.Serialization.XmlElementAttribute("include", typeof(include))]
    [System.Xml.Serialization.XmlElementAttribute("set", typeof(set))]
    [System.Xml.Serialization.XmlElementAttribute("trim", typeof(trim))]
    [System.Xml.Serialization.XmlElementAttribute("where", typeof(where))]
    public object[] Items { get; set; }

    /// <remarks/>
    public string[] Text { get; set; }

    /// <remarks/>
    public string id { get; set; }

    /// <remarks/>
    public string lang { get; set; }

    /// <remarks/>
    public string databaseId { get; set; }
  }

  /// <remarks/>
  public partial class update
  {
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("bind", typeof(bind))]
    [System.Xml.Serialization.XmlElementAttribute("choose", typeof(choose))]
    [System.Xml.Serialization.XmlElementAttribute("foreach", typeof(@foreach))]
    [System.Xml.Serialization.XmlElementAttribute("if", typeof(@if))]
    [System.Xml.Serialization.XmlElementAttribute("include", typeof(include))]
    [System.Xml.Serialization.XmlElementAttribute("selectKey", typeof(selectKey))]
    [System.Xml.Serialization.XmlElementAttribute("set", typeof(set))]
    [System.Xml.Serialization.XmlElementAttribute("trim", typeof(trim))]
    [System.Xml.Serialization.XmlElementAttribute("where", typeof(where))]
    public object[] Items { get; set; }

    /// <remarks/>
    public string[] Text { get; set; }

    /// <remarks/>
    public string id { get; set; }

    /// <remarks/>
    public string parameterMap { get; set; }

    /// <remarks/>
    public string parameterType { get; set; }

    /// <remarks/>
    public string timeout { get; set; }

    /// <remarks/>
    public updateFlushCache flushCache { get; set; }

    /// <remarks/>
    public bool flushCacheSpecified { get; set; }

    /// <remarks/>
    public updateStatementType statementType { get; set; }

    /// <remarks/>
    public bool statementTypeSpecified { get; set; }

    /// <remarks/>
    public string keyProperty { get; set; }

    /// <remarks/>
    public updateUseGeneratedKeys useGeneratedKeys { get; set; }

    /// <remarks/>
    public bool useGeneratedKeysSpecified { get; set; }

    /// <remarks/>
    public string keyColumn { get; set; }

    /// <remarks/>
    public string databaseId { get; set; }

    /// <remarks/>
    public string lang { get; set; }
  }

  /// <remarks/>
  public enum updateFlushCache
  {

    /// <remarks/>
    @true,

    /// <remarks/>
    @false,
  }

  /// <remarks/>
  public enum updateStatementType
  {

    /// <remarks/>
    STATEMENT,

    /// <remarks/>
    PREPARED,

    /// <remarks/>
    CALLABLE,
  }

  /// <remarks/>
  public enum updateUseGeneratedKeys
  {

    /// <remarks/>
    @true,

    /// <remarks/>
    @false,
  }

  ///// <remarks/>
  //public partial class typeAlias
  //{
  //  /// <remarks/>
  //  public string alias { get; set; }

  //  /// <remarks/>
  //  public string type { get; set; }
  //}
}
