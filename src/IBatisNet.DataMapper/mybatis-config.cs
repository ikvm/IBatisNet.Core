﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

// 
// 此源代码由 xsd 自动生成, Version=4.8.3928.0。
// 
namespace Mybatis.Configuration {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://mybatis.org/schema/mybatis-config")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://mybatis.org/schema/mybatis-config", IsNullable=false)]
    public partial class configuration {
        
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
        public properties properties {
            get {
                return this.propertiesField;
            }
            set {
                this.propertiesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("setting", IsNullable=false)]
        public setting[] settings {
            get {
                return this.settingsField;
            }
            set {
                this.settingsField = value;
            }
        }
        
        /// <remarks/>
        public typeAliases typeAliases {
            get {
                return this.typeAliasesField;
            }
            set {
                this.typeAliasesField = value;
            }
        }
        
        /// <remarks/>
        public typeHandlers typeHandlers {
            get {
                return this.typeHandlersField;
            }
            set {
                this.typeHandlersField = value;
            }
        }
        
        /// <remarks/>
        public objectFactory objectFactory {
            get {
                return this.objectFactoryField;
            }
            set {
                this.objectFactoryField = value;
            }
        }
        
        /// <remarks/>
        public objectWrapperFactory objectWrapperFactory {
            get {
                return this.objectWrapperFactoryField;
            }
            set {
                this.objectWrapperFactoryField = value;
            }
        }
        
        /// <remarks/>
        public reflectorFactory reflectorFactory {
            get {
                return this.reflectorFactoryField;
            }
            set {
                this.reflectorFactoryField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("plugin", IsNullable=false)]
        public plugin[] plugins {
            get {
                return this.pluginsField;
            }
            set {
                this.pluginsField = value;
            }
        }
        
        /// <remarks/>
        public environments environments {
            get {
                return this.environmentsField;
            }
            set {
                this.environmentsField = value;
            }
        }
        
        /// <remarks/>
        public databaseIdProvider databaseIdProvider {
            get {
                return this.databaseIdProviderField;
            }
            set {
                this.databaseIdProviderField = value;
            }
        }
        
        /// <remarks/>
        public mappers mappers {
            get {
                return this.mappersField;
            }
            set {
                this.mappersField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://mybatis.org/schema/mybatis-config")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://mybatis.org/schema/mybatis-config", IsNullable=false)]
    public partial class properties {
        
        private property[] propertyField;
        
        private string resourceField;
        
        private string urlField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("property")]
        public property[] property {
            get {
                return this.propertyField;
            }
            set {
                this.propertyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string resource {
            get {
                return this.resourceField;
            }
            set {
                this.resourceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string url {
            get {
                return this.urlField;
            }
            set {
                this.urlField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://mybatis.org/schema/mybatis-config")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://mybatis.org/schema/mybatis-config", IsNullable=false)]
    public partial class property {
        
        private string nameField;
        
        private string valueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://mybatis.org/schema/mybatis-config")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://mybatis.org/schema/mybatis-config", IsNullable=false)]
    public partial class setting {
        
        private string nameField;
        
        private string valueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://mybatis.org/schema/mybatis-config")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://mybatis.org/schema/mybatis-config", IsNullable=false)]
    public partial class typeAliases {
        
        private typeAlias[] typeAliasField;
        
        private package[] packageField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("typeAlias")]
        public typeAlias[] typeAlias {
            get {
                return this.typeAliasField;
            }
            set {
                this.typeAliasField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("package")]
        public package[] package {
            get {
                return this.packageField;
            }
            set {
                this.packageField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://mybatis.org/schema/mybatis-config")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://mybatis.org/schema/mybatis-config", IsNullable=false)]
    public partial class typeAlias {
        
        private string typeField;
        
        private string aliasField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string alias {
            get {
                return this.aliasField;
            }
            set {
                this.aliasField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://mybatis.org/schema/mybatis-config")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://mybatis.org/schema/mybatis-config", IsNullable=false)]
    public partial class package {
        
        private string nameField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://mybatis.org/schema/mybatis-config")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://mybatis.org/schema/mybatis-config", IsNullable=false)]
    public partial class typeHandlers {
        
        private typeHandler[] typeHandlerField;
        
        private package[] packageField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("typeHandler")]
        public typeHandler[] typeHandler {
            get {
                return this.typeHandlerField;
            }
            set {
                this.typeHandlerField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("package")]
        public package[] package {
            get {
                return this.packageField;
            }
            set {
                this.packageField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://mybatis.org/schema/mybatis-config")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://mybatis.org/schema/mybatis-config", IsNullable=false)]
    public partial class typeHandler {
        
        private string javaTypeField;
        
        private string jdbcTypeField;
        
        private string handlerField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string javaType {
            get {
                return this.javaTypeField;
            }
            set {
                this.javaTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string jdbcType {
            get {
                return this.jdbcTypeField;
            }
            set {
                this.jdbcTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string handler {
            get {
                return this.handlerField;
            }
            set {
                this.handlerField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://mybatis.org/schema/mybatis-config")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://mybatis.org/schema/mybatis-config", IsNullable=false)]
    public partial class objectFactory {
        
        private property[] propertyField;
        
        private string typeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("property")]
        public property[] property {
            get {
                return this.propertyField;
            }
            set {
                this.propertyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://mybatis.org/schema/mybatis-config")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://mybatis.org/schema/mybatis-config", IsNullable=false)]
    public partial class objectWrapperFactory {
        
        private string typeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://mybatis.org/schema/mybatis-config")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://mybatis.org/schema/mybatis-config", IsNullable=false)]
    public partial class reflectorFactory {
        
        private string typeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://mybatis.org/schema/mybatis-config")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://mybatis.org/schema/mybatis-config", IsNullable=false)]
    public partial class plugin {
        
        private property[] propertyField;
        
        private string interceptorField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("property")]
        public property[] property {
            get {
                return this.propertyField;
            }
            set {
                this.propertyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string interceptor {
            get {
                return this.interceptorField;
            }
            set {
                this.interceptorField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://mybatis.org/schema/mybatis-config")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://mybatis.org/schema/mybatis-config", IsNullable=false)]
    public partial class environments {
        
        private environment[] environmentField;
        
        private string defaultField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("environment")]
        public environment[] environment {
            get {
                return this.environmentField;
            }
            set {
                this.environmentField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string @default {
            get {
                return this.defaultField;
            }
            set {
                this.defaultField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://mybatis.org/schema/mybatis-config")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://mybatis.org/schema/mybatis-config", IsNullable=false)]
    public partial class environment {
        
        private transactionManager transactionManagerField;
        
        private dataSource dataSourceField;
        
        private string idField;
        
        /// <remarks/>
        public transactionManager transactionManager {
            get {
                return this.transactionManagerField;
            }
            set {
                this.transactionManagerField = value;
            }
        }
        
        /// <remarks/>
        public dataSource dataSource {
            get {
                return this.dataSourceField;
            }
            set {
                this.dataSourceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://mybatis.org/schema/mybatis-config")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://mybatis.org/schema/mybatis-config", IsNullable=false)]
    public partial class transactionManager {
        
        private property[] propertyField;
        
        private string typeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("property")]
        public property[] property {
            get {
                return this.propertyField;
            }
            set {
                this.propertyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://mybatis.org/schema/mybatis-config")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://mybatis.org/schema/mybatis-config", IsNullable=false)]
    public partial class dataSource {
        
        private property[] propertyField;
        
        private string typeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("property")]
        public property[] property {
            get {
                return this.propertyField;
            }
            set {
                this.propertyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://mybatis.org/schema/mybatis-config")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://mybatis.org/schema/mybatis-config", IsNullable=false)]
    public partial class databaseIdProvider {
        
        private property[] propertyField;
        
        private string typeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("property")]
        public property[] property {
            get {
                return this.propertyField;
            }
            set {
                this.propertyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://mybatis.org/schema/mybatis-config")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://mybatis.org/schema/mybatis-config", IsNullable=false)]
    public partial class mappers {
        
        private mapper[] mapperField;
        
        private package[] packageField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("mapper")]
        public mapper[] mapper {
            get {
                return this.mapperField;
            }
            set {
                this.mapperField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("package")]
        public package[] package {
            get {
                return this.packageField;
            }
            set {
                this.packageField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://mybatis.org/schema/mybatis-config")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://mybatis.org/schema/mybatis-config", IsNullable=false)]
    public partial class mapper {
        
        private string resourceField;
        
        private string urlField;
        
        private string classField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string resource {
            get {
                return this.resourceField;
            }
            set {
                this.resourceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string url {
            get {
                return this.urlField;
            }
            set {
                this.urlField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string @class {
            get {
                return this.classField;
            }
            set {
                this.classField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://mybatis.org/schema/mybatis-config")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://mybatis.org/schema/mybatis-config", IsNullable=false)]
    public partial class settings {
        
        private setting[] settingField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("setting")]
        public setting[] setting {
            get {
                return this.settingField;
            }
            set {
                this.settingField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://mybatis.org/schema/mybatis-config")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://mybatis.org/schema/mybatis-config", IsNullable=false)]
    public partial class plugins {
        
        private plugin[] pluginField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("plugin")]
        public plugin[] plugin {
            get {
                return this.pluginField;
            }
            set {
                this.pluginField = value;
            }
        }
    }
}
