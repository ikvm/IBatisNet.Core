namespace Mybatis.Mapper {
  /// <remarks/>
    public partial class mapper {
        
        private object[] itemsField;
        
        private string namespaceField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("cache", typeof(cache))]
        [System.Xml.Serialization.XmlElementAttribute("cache-ref", typeof(cacheref))]
        [System.Xml.Serialization.XmlElementAttribute("delete", typeof(delete))]
        [System.Xml.Serialization.XmlElementAttribute("insert", typeof(insert))]
        [System.Xml.Serialization.XmlElementAttribute("parameterMap", typeof(parameterMap))]
        [System.Xml.Serialization.XmlElementAttribute("resultMap", typeof(resultMap))]
        [System.Xml.Serialization.XmlElementAttribute("select", typeof(select))]
        [System.Xml.Serialization.XmlElementAttribute("sql", typeof(sql))]
        [System.Xml.Serialization.XmlElementAttribute("update", typeof(update))]
        public object[] Items
        {
            get {
                return this.itemsField;
            }
            set {
                this.itemsField = value;
            }
        }
        
        /// <remarks/>
        public string @namespace {
            get {
                return this.namespaceField;
            }
            set {
                this.namespaceField = value;
            }
        }
    }
    
    /// <remarks/>
    public partial class cache {
        
        private property[] propertyField;
        
        private string typeField;
        
        private string evictionField;
        
        private string flushIntervalField;
        
        private string sizeField;
        
        private string readOnlyField;
        
        private string blockingField;
        
        /// <remarks/>
        public property[] property {
            get {
                return this.propertyField;
            }
            set {
                this.propertyField = value;
            }
        }
        
        /// <remarks/>
        public string type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
            }
        }
        
        /// <remarks/>
        public string eviction {
            get {
                return this.evictionField;
            }
            set {
                this.evictionField = value;
            }
        }
        
        /// <remarks/>
        public string flushInterval {
            get {
                return this.flushIntervalField;
            }
            set {
                this.flushIntervalField = value;
            }
        }
        
        /// <remarks/>
        public string size {
            get {
                return this.sizeField;
            }
            set {
                this.sizeField = value;
            }
        }
        
        /// <remarks/>
        public string readOnly {
            get {
                return this.readOnlyField;
            }
            set {
                this.readOnlyField = value;
            }
        }
        
        /// <remarks/>
        public string blocking {
            get {
                return this.blockingField;
            }
            set {
                this.blockingField = value;
            }
        }
    }
    
    /// <remarks/>
    public partial class property {
        
        private string nameField;
        
        private string valueField;
        
        /// <remarks/>
        public string name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        public string value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }
    
    /// <remarks/>
    public partial class cacheref {
        
        private string namespaceField;
        
        /// <remarks/>
        public string @namespace {
            get {
                return this.namespaceField;
            }
            set {
                this.namespaceField = value;
            }
        }
    }
    
    /// <remarks/>
    public partial class delete {
        
        private object[] itemsField;
        
        private string[] textField;
        
        private string idField;
        
        private string parameterMapField;
        
        private string parameterTypeField;
        
        private string timeoutField;
        
        private deleteFlushCache flushCacheField;
        
        private bool flushCacheFieldSpecified;
        
        private deleteStatementType statementTypeField;
        
        private bool statementTypeFieldSpecified;
        
        private string databaseIdField;
        
        private string langField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("bind", typeof(bind))]
        [System.Xml.Serialization.XmlElementAttribute("choose", typeof(choose))]
        [System.Xml.Serialization.XmlElementAttribute("foreach", typeof(@foreach))]
        [System.Xml.Serialization.XmlElementAttribute("if", typeof(@if))]
        [System.Xml.Serialization.XmlElementAttribute("include", typeof(include))]
        [System.Xml.Serialization.XmlElementAttribute("set", typeof(set))]
        [System.Xml.Serialization.XmlElementAttribute("trim", typeof(trim))]
        [System.Xml.Serialization.XmlElementAttribute("where", typeof(where))]
        public object[] Items
        {
            get {
                return this.itemsField;
            }
            set {
                this.itemsField = value;
            }
        }
        
        /// <remarks/>
        public string[] Text {
            get {
                return this.textField;
            }
            set {
                this.textField = value;
            }
        }
        
        /// <remarks/>
        public string id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        public string parameterMap {
            get {
                return this.parameterMapField;
            }
            set {
                this.parameterMapField = value;
            }
        }
        
        /// <remarks/>
        public string parameterType {
            get {
                return this.parameterTypeField;
            }
            set {
                this.parameterTypeField = value;
            }
        }
        
        /// <remarks/>
        public string timeout {
            get {
                return this.timeoutField;
            }
            set {
                this.timeoutField = value;
            }
        }
        
        /// <remarks/>
        public deleteFlushCache flushCache {
            get {
                return this.flushCacheField;
            }
            set {
                this.flushCacheField = value;
            }
        }
        
        /// <remarks/>
        public bool flushCacheSpecified {
            get {
                return this.flushCacheFieldSpecified;
            }
            set {
                this.flushCacheFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public deleteStatementType statementType {
            get {
                return this.statementTypeField;
            }
            set {
                this.statementTypeField = value;
            }
        }
        
        /// <remarks/>
        public bool statementTypeSpecified {
            get {
                return this.statementTypeFieldSpecified;
            }
            set {
                this.statementTypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string databaseId {
            get {
                return this.databaseIdField;
            }
            set {
                this.databaseIdField = value;
            }
        }
        
        /// <remarks/>
        public string lang {
            get {
                return this.langField;
            }
            set {
                this.langField = value;
            }
        }
    }
    
    /// <remarks/>
    public partial class bind {
        
        private string nameField;
        
        private string valueField;
        
        /// <remarks/>
        public string name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        public string value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }
    
    /// <remarks/>
    public partial class choose {
        
        private when[] whenField;
        
        private otherwise otherwiseField;
        
        /// <remarks/>
        public when[] when {
            get {
                return this.whenField;
            }
            set {
                this.whenField = value;
            }
        }
        
        /// <remarks/>
        public otherwise otherwise {
            get {
                return this.otherwiseField;
            }
            set {
                this.otherwiseField = value;
            }
        }
    }
    
    /// <remarks/>
    public partial class when {
        
        private object[] itemsField;
        
        private string[] textField;
        
        private string testField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("bind", typeof(bind))]
        [System.Xml.Serialization.XmlElementAttribute("choose", typeof(choose))]
        [System.Xml.Serialization.XmlElementAttribute("foreach", typeof(@foreach))]
        [System.Xml.Serialization.XmlElementAttribute("if", typeof(@if))]
        [System.Xml.Serialization.XmlElementAttribute("include", typeof(include))]
        [System.Xml.Serialization.XmlElementAttribute("set", typeof(set))]
        [System.Xml.Serialization.XmlElementAttribute("trim", typeof(trim))]
        [System.Xml.Serialization.XmlElementAttribute("where", typeof(where))]
        public object[] Items {
            get {
                return this.itemsField;
            }
            set {
                this.itemsField = value;
            }
        }
        
        /// <remarks/>
        public string[] Text {
            get {
                return this.textField;
            }
            set {
                this.textField = value;
            }
        }
        
        /// <remarks/>
        public string test {
            get {
                return this.testField;
            }
            set {
                this.testField = value;
            }
        }
    }
    
    /// <remarks/>
    public partial class @foreach {
        
        private object[] itemsField;
        
        private string[] textField;
        
        private string collectionField;
        
        private string itemField;
        
        private string indexField;
        
        private string openField;
        
        private string closeField;
        
        private string separatorField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("bind", typeof(bind))]
        [System.Xml.Serialization.XmlElementAttribute("choose", typeof(choose))]
        [System.Xml.Serialization.XmlElementAttribute("foreach", typeof(@foreach))]
        [System.Xml.Serialization.XmlElementAttribute("if", typeof(@if))]
        [System.Xml.Serialization.XmlElementAttribute("include", typeof(include))]
        [System.Xml.Serialization.XmlElementAttribute("set", typeof(set))]
        [System.Xml.Serialization.XmlElementAttribute("trim", typeof(trim))]
        [System.Xml.Serialization.XmlElementAttribute("where", typeof(where))]
        public object[] Items {
            get {
                return this.itemsField;
            }
            set {
                this.itemsField = value;
            }
        }
        
        /// <remarks/>
        public string[] Text {
            get {
                return this.textField;
            }
            set {
                this.textField = value;
            }
        }
        
        /// <remarks/>
        public string collection {
            get {
                return this.collectionField;
            }
            set {
                this.collectionField = value;
            }
        }
        
        /// <remarks/>
        public string item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }
        
        /// <remarks/>
        public string index {
            get {
                return this.indexField;
            }
            set {
                this.indexField = value;
            }
        }
        
        /// <remarks/>
        public string open {
            get {
                return this.openField;
            }
            set {
                this.openField = value;
            }
        }
        
        /// <remarks/>
        public string close {
            get {
                return this.closeField;
            }
            set {
                this.closeField = value;
            }
        }
        
        /// <remarks/>
        public string separator {
            get {
                return this.separatorField;
            }
            set {
                this.separatorField = value;
            }
        }
    }
    
    /// <remarks/>
    public partial class @if {
        
        private object[] itemsField;
        
        private string[] textField;
        
        private string testField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("bind", typeof(bind))]
        [System.Xml.Serialization.XmlElementAttribute("choose", typeof(choose))]
        [System.Xml.Serialization.XmlElementAttribute("foreach", typeof(@foreach))]
        [System.Xml.Serialization.XmlElementAttribute("if", typeof(@if))]
        [System.Xml.Serialization.XmlElementAttribute("include", typeof(include))]
        [System.Xml.Serialization.XmlElementAttribute("set", typeof(set))]
        [System.Xml.Serialization.XmlElementAttribute("trim", typeof(trim))]
        [System.Xml.Serialization.XmlElementAttribute("where", typeof(where))]
        public object[] Items {
            get {
                return this.itemsField;
            }
            set {
                this.itemsField = value;
            }
        }
        
        /// <remarks/>
        public string[] Text {
            get {
                return this.textField;
            }
            set {
                this.textField = value;
            }
        }
        
        /// <remarks/>
        public string test {
            get {
                return this.testField;
            }
            set {
                this.testField = value;
            }
        }
    }
    
    /// <remarks/>
    public partial class include {
        
        private property[] propertyField;
        
        private string refidField;
        
        /// <remarks/>
        public property[] property {
            get {
                return this.propertyField;
            }
            set {
                this.propertyField = value;
            }
        }
        
        /// <remarks/>
        public string refid {
            get {
                return this.refidField;
            }
            set {
                this.refidField = value;
            }
        }
    }
    
    /// <remarks/>
    public partial class set {
        
        private object[] itemsField;
        
        private string[] textField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("bind", typeof(bind))]
        [System.Xml.Serialization.XmlElementAttribute("choose", typeof(choose))]
        [System.Xml.Serialization.XmlElementAttribute("foreach", typeof(@foreach))]
        [System.Xml.Serialization.XmlElementAttribute("if", typeof(@if))]
        [System.Xml.Serialization.XmlElementAttribute("include", typeof(include))]
        [System.Xml.Serialization.XmlElementAttribute("set", typeof(set))]
        [System.Xml.Serialization.XmlElementAttribute("trim", typeof(trim))]
        [System.Xml.Serialization.XmlElementAttribute("where", typeof(where))]
        public object[] Items {
            get {
                return this.itemsField;
            }
            set {
                this.itemsField = value;
            }
        }
        
        /// <remarks/>
        public string[] Text {
            get {
                return this.textField;
            }
            set {
                this.textField = value;
            }
        }
    }
    
    /// <remarks/>
    public partial class trim {
        
        private object[] itemsField;
        
        private string[] textField;
        
        private string prefixField;
        
        private string prefixOverridesField;
        
        private string suffixField;
        
        private string suffixOverridesField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("bind", typeof(bind))]
        [System.Xml.Serialization.XmlElementAttribute("choose", typeof(choose))]
        [System.Xml.Serialization.XmlElementAttribute("foreach", typeof(@foreach))]
        [System.Xml.Serialization.XmlElementAttribute("if", typeof(@if))]
        [System.Xml.Serialization.XmlElementAttribute("include", typeof(include))]
        [System.Xml.Serialization.XmlElementAttribute("set", typeof(set))]
        [System.Xml.Serialization.XmlElementAttribute("trim", typeof(trim))]
        [System.Xml.Serialization.XmlElementAttribute("where", typeof(where))]
        public object[] Items {
            get {
                return this.itemsField;
            }
            set {
                this.itemsField = value;
            }
        }
        
        /// <remarks/>
        public string[] Text {
            get {
                return this.textField;
            }
            set {
                this.textField = value;
            }
        }
        
        /// <remarks/>
        public string prefix {
            get {
                return this.prefixField;
            }
            set {
                this.prefixField = value;
            }
        }
        
        /// <remarks/>
        public string prefixOverrides {
            get {
                return this.prefixOverridesField;
            }
            set {
                this.prefixOverridesField = value;
            }
        }
        
        /// <remarks/>
        public string suffix {
            get {
                return this.suffixField;
            }
            set {
                this.suffixField = value;
            }
        }
        
        /// <remarks/>
        public string suffixOverrides {
            get {
                return this.suffixOverridesField;
            }
            set {
                this.suffixOverridesField = value;
            }
        }
    }
    
    /// <remarks/>
    public partial class where {
        
        private object[] itemsField;
        
        private string[] textField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("bind", typeof(bind))]
        [System.Xml.Serialization.XmlElementAttribute("choose", typeof(choose))]
        [System.Xml.Serialization.XmlElementAttribute("foreach", typeof(@foreach))]
        [System.Xml.Serialization.XmlElementAttribute("if", typeof(@if))]
        [System.Xml.Serialization.XmlElementAttribute("include", typeof(include))]
        [System.Xml.Serialization.XmlElementAttribute("set", typeof(set))]
        [System.Xml.Serialization.XmlElementAttribute("trim", typeof(trim))]
        [System.Xml.Serialization.XmlElementAttribute("where", typeof(where))]
        public object[] Items {
            get {
                return this.itemsField;
            }
            set {
                this.itemsField = value;
            }
        }
        
        /// <remarks/>
        public string[] Text {
            get {
                return this.textField;
            }
            set {
                this.textField = value;
            }
        }
    }
    
    /// <remarks/>
    public partial class otherwise {
        
        private object[] itemsField;
        
        private string[] textField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("bind", typeof(bind))]
        [System.Xml.Serialization.XmlElementAttribute("choose", typeof(choose))]
        [System.Xml.Serialization.XmlElementAttribute("foreach", typeof(@foreach))]
        [System.Xml.Serialization.XmlElementAttribute("if", typeof(@if))]
        [System.Xml.Serialization.XmlElementAttribute("include", typeof(include))]
        [System.Xml.Serialization.XmlElementAttribute("set", typeof(set))]
        [System.Xml.Serialization.XmlElementAttribute("trim", typeof(trim))]
        [System.Xml.Serialization.XmlElementAttribute("where", typeof(where))]
        public object[] Items {
            get {
                return this.itemsField;
            }
            set {
                this.itemsField = value;
            }
        }
        
        /// <remarks/>
        public string[] Text {
            get {
                return this.textField;
            }
            set {
                this.textField = value;
            }
        }
    }
    
    /// <remarks/>
    public enum deleteFlushCache {
        
        /// <remarks/>
        @true,
        
        /// <remarks/>
        @false,
    }
    
    /// <remarks/>
    public enum deleteStatementType {
        
        /// <remarks/>
        STATEMENT,
        
        /// <remarks/>
        PREPARED,
        
        /// <remarks/>
        CALLABLE,
    }
    
    /// <remarks/>
    public partial class insert {
        
        private object[] itemsField;
        
        private string[] textField;
        
        private string idField;
        
        private string parameterMapField;
        
        private string parameterTypeField;
        
        private string timeoutField;
        
        private insertFlushCache flushCacheField;
        
        private bool flushCacheFieldSpecified;
        
        private insertStatementType statementTypeField;
        
        private bool statementTypeFieldSpecified;
        
        private string keyPropertyField;
        
        private insertUseGeneratedKeys useGeneratedKeysField;
        
        private bool useGeneratedKeysFieldSpecified;
        
        private string keyColumnField;
        
        private string databaseIdField;
        
        private string langField;
        
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
        public object[] Items {
            get {
                return this.itemsField;
            }
            set {
                this.itemsField = value;
            }
        }
        
        /// <remarks/>
        public string[] Text {
            get {
                return this.textField;
            }
            set {
                this.textField = value;
            }
        }
        
        /// <remarks/>
        public string id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        public string parameterMap {
            get {
                return this.parameterMapField;
            }
            set {
                this.parameterMapField = value;
            }
        }
        
        /// <remarks/>
        public string parameterType {
            get {
                return this.parameterTypeField;
            }
            set {
                this.parameterTypeField = value;
            }
        }
        
        /// <remarks/>
        public string timeout {
            get {
                return this.timeoutField;
            }
            set {
                this.timeoutField = value;
            }
        }
        
        /// <remarks/>
        public insertFlushCache flushCache {
            get {
                return this.flushCacheField;
            }
            set {
                this.flushCacheField = value;
            }
        }
        
        /// <remarks/>
        public bool flushCacheSpecified {
            get {
                return this.flushCacheFieldSpecified;
            }
            set {
                this.flushCacheFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public insertStatementType statementType {
            get {
                return this.statementTypeField;
            }
            set {
                this.statementTypeField = value;
            }
        }
        
        /// <remarks/>
        public bool statementTypeSpecified {
            get {
                return this.statementTypeFieldSpecified;
            }
            set {
                this.statementTypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string keyProperty {
            get {
                return this.keyPropertyField;
            }
            set {
                this.keyPropertyField = value;
            }
        }
        
        /// <remarks/>
        public insertUseGeneratedKeys useGeneratedKeys {
            get {
                return this.useGeneratedKeysField;
            }
            set {
                this.useGeneratedKeysField = value;
            }
        }
        
        /// <remarks/>
        public bool useGeneratedKeysSpecified {
            get {
                return this.useGeneratedKeysFieldSpecified;
            }
            set {
                this.useGeneratedKeysFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string keyColumn {
            get {
                return this.keyColumnField;
            }
            set {
                this.keyColumnField = value;
            }
        }
        
        /// <remarks/>
        public string databaseId {
            get {
                return this.databaseIdField;
            }
            set {
                this.databaseIdField = value;
            }
        }
        
        /// <remarks/>
        public string lang {
            get {
                return this.langField;
            }
            set {
                this.langField = value;
            }
        }
    }
    
    /// <remarks/>
    public partial class selectKey {
        
        private object[] itemsField;
        
        private string[] textField;
        
        private string resultTypeField;
        
        private selectKeyStatementType statementTypeField;
        
        private bool statementTypeFieldSpecified;
        
        private string keyPropertyField;
        
        private string keyColumnField;
        
        private selectKeyOrder orderField;
        
        private bool orderFieldSpecified;
        
        private string databaseIdField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("bind", typeof(bind))]
        [System.Xml.Serialization.XmlElementAttribute("choose", typeof(choose))]
        [System.Xml.Serialization.XmlElementAttribute("foreach", typeof(@foreach))]
        [System.Xml.Serialization.XmlElementAttribute("if", typeof(@if))]
        [System.Xml.Serialization.XmlElementAttribute("include", typeof(include))]
        [System.Xml.Serialization.XmlElementAttribute("set", typeof(set))]
        [System.Xml.Serialization.XmlElementAttribute("trim", typeof(trim))]
        [System.Xml.Serialization.XmlElementAttribute("where", typeof(where))]
        public object[] Items {
            get {
                return this.itemsField;
            }
            set {
                this.itemsField = value;
            }
        }
        
        /// <remarks/>
        public string[] Text {
            get {
                return this.textField;
            }
            set {
                this.textField = value;
            }
        }
        
        /// <remarks/>
        public string resultType {
            get {
                return this.resultTypeField;
            }
            set {
                this.resultTypeField = value;
            }
        }
        
        /// <remarks/>
        public selectKeyStatementType statementType {
            get {
                return this.statementTypeField;
            }
            set {
                this.statementTypeField = value;
            }
        }
        
        /// <remarks/>
        public bool statementTypeSpecified {
            get {
                return this.statementTypeFieldSpecified;
            }
            set {
                this.statementTypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string keyProperty {
            get {
                return this.keyPropertyField;
            }
            set {
                this.keyPropertyField = value;
            }
        }
        
        /// <remarks/>
        public string keyColumn {
            get {
                return this.keyColumnField;
            }
            set {
                this.keyColumnField = value;
            }
        }
        
        /// <remarks/>
        public selectKeyOrder order {
            get {
                return this.orderField;
            }
            set {
                this.orderField = value;
            }
        }
        
        /// <remarks/>
        public bool orderSpecified {
            get {
                return this.orderFieldSpecified;
            }
            set {
                this.orderFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string databaseId {
            get {
                return this.databaseIdField;
            }
            set {
                this.databaseIdField = value;
            }
        }
    }
    
    /// <remarks/>
    public enum selectKeyStatementType {
        
        /// <remarks/>
        STATEMENT,
        
        /// <remarks/>
        PREPARED,
        
        /// <remarks/>
        CALLABLE,
    }
    
    /// <remarks/>
    public enum selectKeyOrder {
        
        /// <remarks/>
        BEFORE,
        
        /// <remarks/>
        AFTER,
    }
    
    /// <remarks/>
    public enum insertFlushCache {
        
        /// <remarks/>
        @true,
        
        /// <remarks/>
        @false,
    }
    
    /// <remarks/>
    public enum insertStatementType {
        
        /// <remarks/>
        STATEMENT,
        
        /// <remarks/>
        PREPARED,
        
        /// <remarks/>
        CALLABLE,
    }
    
    /// <remarks/>
    public enum insertUseGeneratedKeys {
        
        /// <remarks/>
        @true,
        
        /// <remarks/>
        @false,
    }
    
    /// <remarks/>
    public partial class parameterMap {
        
        private parameter[] parameterField;
        
        private string idField;
        
        private string typeField;
        
        /// <remarks/>
        public parameter[] parameter {
            get {
                return this.parameterField;
            }
            set {
                this.parameterField = value;
            }
        }
        
        /// <remarks/>
        public string id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        public string type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
            }
        }
    }
    
    /// <remarks/>
    public partial class parameter {
        
        private string propertyField;
        
        private string javaTypeField;
        
        private string jdbcTypeField;
        
        private parameterMode modeField;
        
        private bool modeFieldSpecified;
        
        private string resultMapField;
        
        private string scaleField;
        
        private string typeHandlerField;
        
        /// <remarks/>
        public string property {
            get {
                return this.propertyField;
            }
            set {
                this.propertyField = value;
            }
        }
        
        /// <remarks/>
        public string javaType {
            get {
                return this.javaTypeField;
            }
            set {
                this.javaTypeField = value;
            }
        }
        
        /// <remarks/>
        public string jdbcType {
            get {
                return this.jdbcTypeField;
            }
            set {
                this.jdbcTypeField = value;
            }
        }
        
        /// <remarks/>
        public parameterMode mode {
            get {
                return this.modeField;
            }
            set {
                this.modeField = value;
            }
        }
        
        /// <remarks/>
        public bool modeSpecified {
            get {
                return this.modeFieldSpecified;
            }
            set {
                this.modeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string resultMap {
            get {
                return this.resultMapField;
            }
            set {
                this.resultMapField = value;
            }
        }
        
        /// <remarks/>
        public string scale {
            get {
                return this.scaleField;
            }
            set {
                this.scaleField = value;
            }
        }
        
        /// <remarks/>
        public string typeHandler {
            get {
                return this.typeHandlerField;
            }
            set {
                this.typeHandlerField = value;
            }
        }
    }
    
    /// <remarks/>
    public enum parameterMode {
        
        /// <remarks/>
        IN,
        
        /// <remarks/>
        OUT,
        
        /// <remarks/>
        INOUT,
    }
    
    /// <remarks/>
    public partial class resultMap {
        
        private constructor constructorField;
        
        private id[] idField;
        
        private result[] resultField;
        
        private association[] associationField;
        
        private collection[] collectionField;
        
        private discriminator discriminatorField;
        
        private string id1Field;
        
        private string typeField;
        
        private string extendsField;
        
        private resultMapAutoMapping autoMappingField;
        
        private bool autoMappingFieldSpecified;
        
        /// <remarks/>
        public constructor constructor {
            get {
                return this.constructorField;
            }
            set {
                this.constructorField = value;
            }
        }
        
        /// <remarks/>
        public id[] id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        public result[] result {
            get {
                return this.resultField;
            }
            set {
                this.resultField = value;
            }
        }
        
        /// <remarks/>
        public association[] association {
            get {
                return this.associationField;
            }
            set {
                this.associationField = value;
            }
        }
        
        /// <remarks/>
        public collection[] collection {
            get {
                return this.collectionField;
            }
            set {
                this.collectionField = value;
            }
        }
        
        /// <remarks/>
        public discriminator discriminator {
            get {
                return this.discriminatorField;
            }
            set {
                this.discriminatorField = value;
            }
        }
        
        /// <remarks/>
        public string id1 {
            get {
                return this.id1Field;
            }
            set {
                this.id1Field = value;
            }
        }
        
        /// <remarks/>
        public string type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
            }
        }
        
        /// <remarks/>
        public string extends {
            get {
                return this.extendsField;
            }
            set {
                this.extendsField = value;
            }
        }
        
        /// <remarks/>
        public resultMapAutoMapping autoMapping {
            get {
                return this.autoMappingField;
            }
            set {
                this.autoMappingField = value;
            }
        }
        
        /// <remarks/>
        public bool autoMappingSpecified {
            get {
                return this.autoMappingFieldSpecified;
            }
            set {
                this.autoMappingFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    public partial class constructor {
        
        private idArg[] idArgField;
        
        private arg[] argField;
        
        /// <remarks/>
        public idArg[] idArg {
            get {
                return this.idArgField;
            }
            set {
                this.idArgField = value;
            }
        }
        
        /// <remarks/>
        public arg[] arg {
            get {
                return this.argField;
            }
            set {
                this.argField = value;
            }
        }
    }
    
    /// <remarks/>
    public partial class idArg {
        
        private string javaTypeField;
        
        private string columnField;
        
        private string jdbcTypeField;
        
        private string typeHandlerField;
        
        private string selectField;
        
        private string resultMapField;
        
        private string nameField;
        
        private string columnPrefixField;
        
        /// <remarks/>
        public string javaType {
            get {
                return this.javaTypeField;
            }
            set {
                this.javaTypeField = value;
            }
        }
        
        /// <remarks/>
        public string column {
            get {
                return this.columnField;
            }
            set {
                this.columnField = value;
            }
        }
        
        /// <remarks/>
        public string jdbcType {
            get {
                return this.jdbcTypeField;
            }
            set {
                this.jdbcTypeField = value;
            }
        }
        
        /// <remarks/>
        public string typeHandler {
            get {
                return this.typeHandlerField;
            }
            set {
                this.typeHandlerField = value;
            }
        }
        
        /// <remarks/>
        public string select {
            get {
                return this.selectField;
            }
            set {
                this.selectField = value;
            }
        }
        
        /// <remarks/>
        public string resultMap {
            get {
                return this.resultMapField;
            }
            set {
                this.resultMapField = value;
            }
        }
        
        /// <remarks/>
        public string name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        public string columnPrefix {
            get {
                return this.columnPrefixField;
            }
            set {
                this.columnPrefixField = value;
            }
        }
    }
    
    /// <remarks/>
    public partial class arg {
        
        private string javaTypeField;
        
        private string columnField;
        
        private string jdbcTypeField;
        
        private string typeHandlerField;
        
        private string selectField;
        
        private string resultMapField;
        
        private string nameField;
        
        private string columnPrefixField;
        
        /// <remarks/>
        public string javaType {
            get {
                return this.javaTypeField;
            }
            set {
                this.javaTypeField = value;
            }
        }
        
        /// <remarks/>
        public string column {
            get {
                return this.columnField;
            }
            set {
                this.columnField = value;
            }
        }
        
        /// <remarks/>
        public string jdbcType {
            get {
                return this.jdbcTypeField;
            }
            set {
                this.jdbcTypeField = value;
            }
        }
        
        /// <remarks/>
        public string typeHandler {
            get {
                return this.typeHandlerField;
            }
            set {
                this.typeHandlerField = value;
            }
        }
        
        /// <remarks/>
        public string select {
            get {
                return this.selectField;
            }
            set {
                this.selectField = value;
            }
        }
        
        /// <remarks/>
        public string resultMap {
            get {
                return this.resultMapField;
            }
            set {
                this.resultMapField = value;
            }
        }
        
        /// <remarks/>
        public string name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        public string columnPrefix {
            get {
                return this.columnPrefixField;
            }
            set {
                this.columnPrefixField = value;
            }
        }
    }
    
    /// <remarks/>
    public partial class id {
        
        private string propertyField;
        
        private string javaTypeField;
        
        private string columnField;
        
        private string jdbcTypeField;
        
        private string typeHandlerField;
        
        /// <remarks/>
        public string property {
            get {
                return this.propertyField;
            }
            set {
                this.propertyField = value;
            }
        }
        
        /// <remarks/>
        public string javaType {
            get {
                return this.javaTypeField;
            }
            set {
                this.javaTypeField = value;
            }
        }
        
        /// <remarks/>
        public string column {
            get {
                return this.columnField;
            }
            set {
                this.columnField = value;
            }
        }
        
        /// <remarks/>
        public string jdbcType {
            get {
                return this.jdbcTypeField;
            }
            set {
                this.jdbcTypeField = value;
            }
        }
        
        /// <remarks/>
        public string typeHandler {
            get {
                return this.typeHandlerField;
            }
            set {
                this.typeHandlerField = value;
            }
        }
    }
    
    /// <remarks/>
    public partial class result {
        
        private string propertyField;
        
        private string javaTypeField;
        
        private string columnField;
        
        private string jdbcTypeField;
        
        private string typeHandlerField;
        
        /// <remarks/>
        public string property {
            get {
                return this.propertyField;
            }
            set {
                this.propertyField = value;
            }
        }
        
        /// <remarks/>
        public string javaType {
            get {
                return this.javaTypeField;
            }
            set {
                this.javaTypeField = value;
            }
        }
        
        /// <remarks/>
        public string column {
            get {
                return this.columnField;
            }
            set {
                this.columnField = value;
            }
        }
        
        /// <remarks/>
        public string jdbcType {
            get {
                return this.jdbcTypeField;
            }
            set {
                this.jdbcTypeField = value;
            }
        }
        
        /// <remarks/>
        public string typeHandler {
            get {
                return this.typeHandlerField;
            }
            set {
                this.typeHandlerField = value;
            }
        }
    }
    
    /// <remarks/>
    public partial class association {
        
        private constructor constructorField;
        
        private id[] idField;
        
        private result[] resultField;
        
        private association[] association1Field;
        
        private collection[] collectionField;
        
        private discriminator discriminatorField;
        
        private string propertyField;
        
        private string columnField;
        
        private string javaTypeField;
        
        private string jdbcTypeField;
        
        private string selectField;
        
        private string resultMapField;
        
        private string typeHandlerField;
        
        private string notNullColumnField;
        
        private string columnPrefixField;
        
        private string resultSetField;
        
        private string foreignColumnField;
        
        private associationAutoMapping autoMappingField;
        
        private bool autoMappingFieldSpecified;
        
        private associationFetchType fetchTypeField;
        
        private bool fetchTypeFieldSpecified;
        
        /// <remarks/>
        public constructor constructor {
            get {
                return this.constructorField;
            }
            set {
                this.constructorField = value;
            }
        }
        
        /// <remarks/>
        public id[] id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        public result[] result {
            get {
                return this.resultField;
            }
            set {
                this.resultField = value;
            }
        }
        
        /// <remarks/>
        public association[] association1 {
            get {
                return this.association1Field;
            }
            set {
                this.association1Field = value;
            }
        }
        
        /// <remarks/>
        public collection[] collection {
            get {
                return this.collectionField;
            }
            set {
                this.collectionField = value;
            }
        }
        
        /// <remarks/>
        public discriminator discriminator {
            get {
                return this.discriminatorField;
            }
            set {
                this.discriminatorField = value;
            }
        }
        
        /// <remarks/>
        public string property {
            get {
                return this.propertyField;
            }
            set {
                this.propertyField = value;
            }
        }
        
        /// <remarks/>
        public string column {
            get {
                return this.columnField;
            }
            set {
                this.columnField = value;
            }
        }
        
        /// <remarks/>
        public string javaType {
            get {
                return this.javaTypeField;
            }
            set {
                this.javaTypeField = value;
            }
        }
        
        /// <remarks/>
        public string jdbcType {
            get {
                return this.jdbcTypeField;
            }
            set {
                this.jdbcTypeField = value;
            }
        }
        
        /// <remarks/>
        public string select {
            get {
                return this.selectField;
            }
            set {
                this.selectField = value;
            }
        }
        
        /// <remarks/>
        public string resultMap {
            get {
                return this.resultMapField;
            }
            set {
                this.resultMapField = value;
            }
        }
        
        /// <remarks/>
        public string typeHandler {
            get {
                return this.typeHandlerField;
            }
            set {
                this.typeHandlerField = value;
            }
        }
        
        /// <remarks/>
        public string notNullColumn {
            get {
                return this.notNullColumnField;
            }
            set {
                this.notNullColumnField = value;
            }
        }
        
        /// <remarks/>
        public string columnPrefix {
            get {
                return this.columnPrefixField;
            }
            set {
                this.columnPrefixField = value;
            }
        }
        
        /// <remarks/>
        public string resultSet {
            get {
                return this.resultSetField;
            }
            set {
                this.resultSetField = value;
            }
        }
        
        /// <remarks/>
        public string foreignColumn {
            get {
                return this.foreignColumnField;
            }
            set {
                this.foreignColumnField = value;
            }
        }
        
        /// <remarks/>
        public associationAutoMapping autoMapping {
            get {
                return this.autoMappingField;
            }
            set {
                this.autoMappingField = value;
            }
        }
        
        /// <remarks/>
        public bool autoMappingSpecified {
            get {
                return this.autoMappingFieldSpecified;
            }
            set {
                this.autoMappingFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public associationFetchType fetchType {
            get {
                return this.fetchTypeField;
            }
            set {
                this.fetchTypeField = value;
            }
        }
        
        /// <remarks/>
        public bool fetchTypeSpecified {
            get {
                return this.fetchTypeFieldSpecified;
            }
            set {
                this.fetchTypeFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    public partial class collection {
        
        private constructor constructorField;
        
        private id[] idField;
        
        private result[] resultField;
        
        private association[] associationField;
        
        private collection[] collection1Field;
        
        private discriminator discriminatorField;
        
        private string propertyField;
        
        private string columnField;
        
        private string javaTypeField;
        
        private string ofTypeField;
        
        private string jdbcTypeField;
        
        private string selectField;
        
        private string resultMapField;
        
        private string typeHandlerField;
        
        private string notNullColumnField;
        
        private string columnPrefixField;
        
        private string resultSetField;
        
        private string foreignColumnField;
        
        private collectionAutoMapping autoMappingField;
        
        private bool autoMappingFieldSpecified;
        
        private collectionFetchType fetchTypeField;
        
        private bool fetchTypeFieldSpecified;
        
        /// <remarks/>
        public constructor constructor {
            get {
                return this.constructorField;
            }
            set {
                this.constructorField = value;
            }
        }
        
        /// <remarks/>
        public id[] id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        public result[] result {
            get {
                return this.resultField;
            }
            set {
                this.resultField = value;
            }
        }
        
        /// <remarks/>
        public association[] association {
            get {
                return this.associationField;
            }
            set {
                this.associationField = value;
            }
        }
        
        /// <remarks/>
        public collection[] collection1 {
            get {
                return this.collection1Field;
            }
            set {
                this.collection1Field = value;
            }
        }
        
        /// <remarks/>
        public discriminator discriminator {
            get {
                return this.discriminatorField;
            }
            set {
                this.discriminatorField = value;
            }
        }
        
        /// <remarks/>
        public string property {
            get {
                return this.propertyField;
            }
            set {
                this.propertyField = value;
            }
        }
        
        /// <remarks/>
        public string column {
            get {
                return this.columnField;
            }
            set {
                this.columnField = value;
            }
        }
        
        /// <remarks/>
        public string javaType {
            get {
                return this.javaTypeField;
            }
            set {
                this.javaTypeField = value;
            }
        }
        
        /// <remarks/>
        public string ofType {
            get {
                return this.ofTypeField;
            }
            set {
                this.ofTypeField = value;
            }
        }
        
        /// <remarks/>
        public string jdbcType {
            get {
                return this.jdbcTypeField;
            }
            set {
                this.jdbcTypeField = value;
            }
        }
        
        /// <remarks/>
        public string select {
            get {
                return this.selectField;
            }
            set {
                this.selectField = value;
            }
        }
        
        /// <remarks/>
        public string resultMap {
            get {
                return this.resultMapField;
            }
            set {
                this.resultMapField = value;
            }
        }
        
        /// <remarks/>
        public string typeHandler {
            get {
                return this.typeHandlerField;
            }
            set {
                this.typeHandlerField = value;
            }
        }
        
        /// <remarks/>
        public string notNullColumn {
            get {
                return this.notNullColumnField;
            }
            set {
                this.notNullColumnField = value;
            }
        }
        
        /// <remarks/>
        public string columnPrefix {
            get {
                return this.columnPrefixField;
            }
            set {
                this.columnPrefixField = value;
            }
        }
        
        /// <remarks/>
        public string resultSet {
            get {
                return this.resultSetField;
            }
            set {
                this.resultSetField = value;
            }
        }
        
        /// <remarks/>
        public string foreignColumn {
            get {
                return this.foreignColumnField;
            }
            set {
                this.foreignColumnField = value;
            }
        }
        
        /// <remarks/>
        public collectionAutoMapping autoMapping {
            get {
                return this.autoMappingField;
            }
            set {
                this.autoMappingField = value;
            }
        }
        
        /// <remarks/>
        public bool autoMappingSpecified {
            get {
                return this.autoMappingFieldSpecified;
            }
            set {
                this.autoMappingFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public collectionFetchType fetchType {
            get {
                return this.fetchTypeField;
            }
            set {
                this.fetchTypeField = value;
            }
        }
        
        /// <remarks/>
        public bool fetchTypeSpecified {
            get {
                return this.fetchTypeFieldSpecified;
            }
            set {
                this.fetchTypeFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    public partial class discriminator {
        
        private @case[] caseField;
        
        private string columnField;
        
        private string javaTypeField;
        
        private string jdbcTypeField;
        
        private string typeHandlerField;
        
        /// <remarks/>
        public @case[] @case {
            get {
                return this.caseField;
            }
            set {
                this.caseField = value;
            }
        }
        
        /// <remarks/>
        public string column {
            get {
                return this.columnField;
            }
            set {
                this.columnField = value;
            }
        }
        
        /// <remarks/>
        public string javaType {
            get {
                return this.javaTypeField;
            }
            set {
                this.javaTypeField = value;
            }
        }
        
        /// <remarks/>
        public string jdbcType {
            get {
                return this.jdbcTypeField;
            }
            set {
                this.jdbcTypeField = value;
            }
        }
        
        /// <remarks/>
        public string typeHandler {
            get {
                return this.typeHandlerField;
            }
            set {
                this.typeHandlerField = value;
            }
        }
    }
    
    /// <remarks/>
    public partial class @case {
        
        private constructor constructorField;
        
        private id[] idField;
        
        private result[] resultField;
        
        private association[] associationField;
        
        private collection[] collectionField;
        
        private discriminator discriminatorField;
        
        private string valueField;
        
        private string resultMapField;
        
        private string resultTypeField;
        
        /// <remarks/>
        public constructor constructor {
            get {
                return this.constructorField;
            }
            set {
                this.constructorField = value;
            }
        }
        
        /// <remarks/>
        public id[] id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        public result[] result {
            get {
                return this.resultField;
            }
            set {
                this.resultField = value;
            }
        }
        
        /// <remarks/>
        public association[] association {
            get {
                return this.associationField;
            }
            set {
                this.associationField = value;
            }
        }
        
        /// <remarks/>
        public collection[] collection {
            get {
                return this.collectionField;
            }
            set {
                this.collectionField = value;
            }
        }
        
        /// <remarks/>
        public discriminator discriminator {
            get {
                return this.discriminatorField;
            }
            set {
                this.discriminatorField = value;
            }
        }
        
        /// <remarks/>
        public string value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
        
        /// <remarks/>
        public string resultMap {
            get {
                return this.resultMapField;
            }
            set {
                this.resultMapField = value;
            }
        }
        
        /// <remarks/>
        public string resultType {
            get {
                return this.resultTypeField;
            }
            set {
                this.resultTypeField = value;
            }
        }
    }
    
    /// <remarks/>
    public enum collectionAutoMapping {
        
        /// <remarks/>
        @true,
        
        /// <remarks/>
        @false,
    }
    
    /// <remarks/>
    public enum collectionFetchType {
        
        /// <remarks/>
        lazy,
        
        /// <remarks/>
        eager,
    }
    
    /// <remarks/>
    public enum associationAutoMapping {
        
        /// <remarks/>
        @true,
        
        /// <remarks/>
        @false,
    }
    
    /// <remarks/>
    public enum associationFetchType {
        
        /// <remarks/>
        lazy,
        
        /// <remarks/>
        eager,
    }
    
    /// <remarks/>
    public enum resultMapAutoMapping {
        
        /// <remarks/>
        @true,
        
        /// <remarks/>
        @false,
    }
    
    /// <remarks/>
    public partial class select {
        
        private object[] itemsField;
        
        private string[] textField;
        
        private string idField;
        
        private string parameterMapField;
        
        private string parameterTypeField;
        
        private string resultMapField;
        
        private string resultTypeField;
        
        private selectResultSetType resultSetTypeField;
        
        private bool resultSetTypeFieldSpecified;
        
        private selectStatementType statementTypeField;
        
        private bool statementTypeFieldSpecified;
        
        private string fetchSizeField;
        
        private string timeoutField;
        
        private selectFlushCache flushCacheField;
        
        private bool flushCacheFieldSpecified;
        
        private selectUseCache useCacheField;
        
        private bool useCacheFieldSpecified;
        
        private string databaseIdField;
        
        private string langField;
        
        private selectResultOrdered resultOrderedField;
        
        private bool resultOrderedFieldSpecified;
        
        private string resultSetsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("bind", typeof(bind))]
        [System.Xml.Serialization.XmlElementAttribute("choose", typeof(choose))]
        [System.Xml.Serialization.XmlElementAttribute("foreach", typeof(@foreach))]
        [System.Xml.Serialization.XmlElementAttribute("if", typeof(@if))]
        [System.Xml.Serialization.XmlElementAttribute("include", typeof(include))]
        [System.Xml.Serialization.XmlElementAttribute("set", typeof(set))]
        [System.Xml.Serialization.XmlElementAttribute("trim", typeof(trim))]
        [System.Xml.Serialization.XmlElementAttribute("where", typeof(where))]
        public object[] Items {
            get {
                return this.itemsField;
            }
            set {
                this.itemsField = value;
            }
        }
        
        /// <remarks/>
        public string[] Text {
            get {
                return this.textField;
            }
            set {
                this.textField = value;
            }
        }
        
        /// <remarks/>
        public string id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        public string parameterMap {
            get {
                return this.parameterMapField;
            }
            set {
                this.parameterMapField = value;
            }
        }
        
        /// <remarks/>
        public string parameterType {
            get {
                return this.parameterTypeField;
            }
            set {
                this.parameterTypeField = value;
            }
        }
        
        /// <remarks/>
        public string resultMap {
            get {
                return this.resultMapField;
            }
            set {
                this.resultMapField = value;
            }
        }
        
        /// <remarks/>
        public string resultType {
            get {
                return this.resultTypeField;
            }
            set {
                this.resultTypeField = value;
            }
        }
        
        /// <remarks/>
        public selectResultSetType resultSetType {
            get {
                return this.resultSetTypeField;
            }
            set {
                this.resultSetTypeField = value;
            }
        }
        
        /// <remarks/>
        public bool resultSetTypeSpecified {
            get {
                return this.resultSetTypeFieldSpecified;
            }
            set {
                this.resultSetTypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public selectStatementType statementType {
            get {
                return this.statementTypeField;
            }
            set {
                this.statementTypeField = value;
            }
        }
        
        /// <remarks/>
        public bool statementTypeSpecified {
            get {
                return this.statementTypeFieldSpecified;
            }
            set {
                this.statementTypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string fetchSize {
            get {
                return this.fetchSizeField;
            }
            set {
                this.fetchSizeField = value;
            }
        }
        
        /// <remarks/>
        public string timeout {
            get {
                return this.timeoutField;
            }
            set {
                this.timeoutField = value;
            }
        }
        
        /// <remarks/>
        public selectFlushCache flushCache {
            get {
                return this.flushCacheField;
            }
            set {
                this.flushCacheField = value;
            }
        }
        
        /// <remarks/>
        public bool flushCacheSpecified {
            get {
                return this.flushCacheFieldSpecified;
            }
            set {
                this.flushCacheFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public selectUseCache useCache {
            get {
                return this.useCacheField;
            }
            set {
                this.useCacheField = value;
            }
        }
        
        /// <remarks/>
        public bool useCacheSpecified {
            get {
                return this.useCacheFieldSpecified;
            }
            set {
                this.useCacheFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string databaseId {
            get {
                return this.databaseIdField;
            }
            set {
                this.databaseIdField = value;
            }
        }
        
        /// <remarks/>
        public string lang {
            get {
                return this.langField;
            }
            set {
                this.langField = value;
            }
        }
        
        /// <remarks/>
        public selectResultOrdered resultOrdered {
            get {
                return this.resultOrderedField;
            }
            set {
                this.resultOrderedField = value;
            }
        }
        
        /// <remarks/>
        public bool resultOrderedSpecified {
            get {
                return this.resultOrderedFieldSpecified;
            }
            set {
                this.resultOrderedFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string resultSets {
            get {
                return this.resultSetsField;
            }
            set {
                this.resultSetsField = value;
            }
        }
    }
    
    /// <remarks/>
    public enum selectResultSetType {
        
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
    public enum selectStatementType {
        
        /// <remarks/>
        STATEMENT,
        
        /// <remarks/>
        PREPARED,
        
        /// <remarks/>
        CALLABLE,
    }
    
    /// <remarks/>
    public enum selectFlushCache {
        
        /// <remarks/>
        @true,
        
        /// <remarks/>
        @false,
    }
    
    /// <remarks/>
    public enum selectUseCache {
        
        /// <remarks/>
        @true,
        
        /// <remarks/>
        @false,
    }
    
    /// <remarks/>
    public enum selectResultOrdered {
        
        /// <remarks/>
        @true,
        
        /// <remarks/>
        @false,
    }
    
    /// <remarks/>
    public partial class sql {
        
        private object[] itemsField;
        
        private string[] textField;
        
        private string idField;
        
        private string langField;
        
        private string databaseIdField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("bind", typeof(bind))]
        [System.Xml.Serialization.XmlElementAttribute("choose", typeof(choose))]
        [System.Xml.Serialization.XmlElementAttribute("foreach", typeof(@foreach))]
        [System.Xml.Serialization.XmlElementAttribute("if", typeof(@if))]
        [System.Xml.Serialization.XmlElementAttribute("include", typeof(include))]
        [System.Xml.Serialization.XmlElementAttribute("set", typeof(set))]
        [System.Xml.Serialization.XmlElementAttribute("trim", typeof(trim))]
        [System.Xml.Serialization.XmlElementAttribute("where", typeof(where))]
        public object[] Items {
            get {
                return this.itemsField;
            }
            set {
                this.itemsField = value;
            }
        }
        
        /// <remarks/>
        public string[] Text {
            get {
                return this.textField;
            }
            set {
                this.textField = value;
            }
        }
        
        /// <remarks/>
        public string id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        public string lang {
            get {
                return this.langField;
            }
            set {
                this.langField = value;
            }
        }
        
        /// <remarks/>
        public string databaseId {
            get {
                return this.databaseIdField;
            }
            set {
                this.databaseIdField = value;
            }
        }
    }
    
    /// <remarks/>
    public partial class update {
        
        private object[] itemsField;
        
        private string[] textField;
        
        private string idField;
        
        private string parameterMapField;
        
        private string parameterTypeField;
        
        private string timeoutField;
        
        private updateFlushCache flushCacheField;
        
        private bool flushCacheFieldSpecified;
        
        private updateStatementType statementTypeField;
        
        private bool statementTypeFieldSpecified;
        
        private string keyPropertyField;
        
        private updateUseGeneratedKeys useGeneratedKeysField;
        
        private bool useGeneratedKeysFieldSpecified;
        
        private string keyColumnField;
        
        private string databaseIdField;
        
        private string langField;
        
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
        public object[] Items {
            get {
                return this.itemsField;
            }
            set {
                this.itemsField = value;
            }
        }
        
        /// <remarks/>
        public string[] Text {
            get {
                return this.textField;
            }
            set {
                this.textField = value;
            }
        }
        
        /// <remarks/>
        public string id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        public string parameterMap {
            get {
                return this.parameterMapField;
            }
            set {
                this.parameterMapField = value;
            }
        }
        
        /// <remarks/>
        public string parameterType {
            get {
                return this.parameterTypeField;
            }
            set {
                this.parameterTypeField = value;
            }
        }
        
        /// <remarks/>
        public string timeout {
            get {
                return this.timeoutField;
            }
            set {
                this.timeoutField = value;
            }
        }
        
        /// <remarks/>
        public updateFlushCache flushCache {
            get {
                return this.flushCacheField;
            }
            set {
                this.flushCacheField = value;
            }
        }
        
        /// <remarks/>
        public bool flushCacheSpecified {
            get {
                return this.flushCacheFieldSpecified;
            }
            set {
                this.flushCacheFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public updateStatementType statementType {
            get {
                return this.statementTypeField;
            }
            set {
                this.statementTypeField = value;
            }
        }
        
        /// <remarks/>
        public bool statementTypeSpecified {
            get {
                return this.statementTypeFieldSpecified;
            }
            set {
                this.statementTypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string keyProperty {
            get {
                return this.keyPropertyField;
            }
            set {
                this.keyPropertyField = value;
            }
        }
        
        /// <remarks/>
        public updateUseGeneratedKeys useGeneratedKeys {
            get {
                return this.useGeneratedKeysField;
            }
            set {
                this.useGeneratedKeysField = value;
            }
        }
        
        /// <remarks/>
        public bool useGeneratedKeysSpecified {
            get {
                return this.useGeneratedKeysFieldSpecified;
            }
            set {
                this.useGeneratedKeysFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string keyColumn {
            get {
                return this.keyColumnField;
            }
            set {
                this.keyColumnField = value;
            }
        }
        
        /// <remarks/>
        public string databaseId {
            get {
                return this.databaseIdField;
            }
            set {
                this.databaseIdField = value;
            }
        }
        
        /// <remarks/>
        public string lang {
            get {
                return this.langField;
            }
            set {
                this.langField = value;
            }
        }
    }
    
    /// <remarks/>
    public enum updateFlushCache {
        
        /// <remarks/>
        @true,
        
        /// <remarks/>
        @false,
    }
    
    /// <remarks/>
    public enum updateStatementType {
        
        /// <remarks/>
        STATEMENT,
        
        /// <remarks/>
        PREPARED,
        
        /// <remarks/>
        CALLABLE,
    }
    
    /// <remarks/>
    public enum updateUseGeneratedKeys {
        
        /// <remarks/>
        @true,
        
        /// <remarks/>
        @false,
    }
    
    /// <remarks/>
    public partial class typeAlias {
        
        private string aliasField;
        
        private string typeField;
        
        /// <remarks/>
        public string alias {
            get {
                return this.aliasField;
            }
            set {
                this.aliasField = value;
            }
        }
        
        /// <remarks/>
        public string type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
            }
        }
    }
}
