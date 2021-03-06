﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.4013
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Debugging.Tests {
    using System;
    using System.Collections.Generic;
    using System.Collections;
    using Castle.ActiveRecord;
    using Castle.Components.Validator;
    
    
    [ActiveRecord()]
    public partial class SimpleClass : ActiveRecordBase {
    }
    
    [ActiveRecord()]
    public partial class ClassWithProperties : ActiveRecordValidationBase {
        
        private string _simpleProperty;
        
        private int _customizedProperty;
        
        private string _propertyWithValidators;
        
        [Property(ColumnType="String")]
        public string SimpleProperty {
            get {
                return this._simpleProperty;
            }
            set {
                this._simpleProperty = value;
            }
        }
        
        [Property("column", ColumnType="Int32", CustomAccess="customAccess", Formula="formula", Insert=false, Length=1, NotNull=true, Unique=true, Update=false, UniqueKey="uniqueKey", Index="index", SqlType="sqlType", Check="check")]
        public int CustomizedProperty {
            get {
                return this._customizedProperty;
            }
            set {
                this._customizedProperty = value;
            }
        }
        
        [Property(ColumnType="String")]
        [ValidateCreditCard((CreditCardValidator.CardType.MasterCard | CreditCardValidator.CardType.VISA), new string[] {
                "exception1",
                "exception2"}, "Dummy error message", FriendlyName="frindlyName", ExecutionOrder=1, RunWhen=RunWhen.Insert)]
        [ValidateEmail("errror", FriendlyName="email", ExecutionOrder=2, RunWhen=RunWhen.Insert)]
        [ValidateRegExp("...", "error", FriendlyName="regexp", ExecutionOrder=3)]
        [ValidateLength(10, "error", FriendlyName="length", ExecutionOrder=1, RunWhen=RunWhen.Insert)]
        [ValidateDate("error", FriendlyName="dt", ExecutionOrder=1, RunWhen=RunWhen.Insert)]
        [ValidateDateTime("error", FriendlyName="dtm", ExecutionOrder=1, RunWhen=RunWhen.Insert)]
        [ValidateDecimal("error", FriendlyName="dec", ExecutionOrder=1, RunWhen=RunWhen.Insert)]
        [ValidateDouble("error", FriendlyName="double", ExecutionOrder=1, RunWhen=RunWhen.Insert)]
        [ValidateInteger("error", FriendlyName="int", ExecutionOrder=1, RunWhen=RunWhen.Insert)]
        [ValidateNonEmpty("error", FriendlyName="ne", ExecutionOrder=1, RunWhen=RunWhen.Insert)]
        [ValidateRange(0, 120, "error", FriendlyName="range", ExecutionOrder=1, RunWhen=RunWhen.Insert)]
        [ValidateSameAs("propertyname", "error", FriendlyName="same", ExecutionOrder=1, RunWhen=RunWhen.Insert)]
        [ValidateSet("error", new string[] {
                "string1",
                "string2"}, FriendlyName="set", ExecutionOrder=1, RunWhen=RunWhen.Insert)]
        [ValidateSingle("error", FriendlyName="single", ExecutionOrder=1, RunWhen=RunWhen.Insert)]
        [ValidateSet(typeof(System.UriFormat), "error", FriendlyName="set2", ExecutionOrder=1, RunWhen=RunWhen.Insert)]
        [ValidateCollectionNotEmpty("Dummy error message", FriendlyName="friendlyNAme", ExecutionOrder=1, RunWhen=RunWhen.Insert)]
        [ValidateGroupNotEmpty("group", "Dummy error message", FriendlyName="friendlyName", ExecutionOrder=1, RunWhen=RunWhen.Insert)]
        public string PropertyWithValidators {
            get {
                return this._propertyWithValidators;
            }
            set {
                this._propertyWithValidators = value;
            }
        }
    }
    
    [ActiveRecord()]
    public partial class ClassWithPK : ActiveRecordBase {
        
        private int _primaryKeyProperty;
        
        [PrimaryKey(PrimaryKeyType.Native, ColumnType="Int32", Params="params", UnsavedValue="unsavedValue")]
        public int PrimaryKeyProperty {
            get {
                return this._primaryKeyProperty;
            }
            set {
                this._primaryKeyProperty = value;
            }
        }
    }
    
    [ActiveRecord()]
    public partial class ClassWithCompositeKey : ActiveRecordBase {
        
        private ClassWithCompositeKeyCompositeKey _classWithCompositeKeyCompositeKey;
        
        [CompositeKey()]
        public ClassWithCompositeKeyCompositeKey ClassWithCompositeKeyCompositeKey {
            get {
                return this._classWithCompositeKeyCompositeKey;
            }
            set {
                this._classWithCompositeKeyCompositeKey = value;
            }
        }
    }
    
    [Serializable()]
    public partial class ClassWithCompositeKeyCompositeKey {
        
        private int _key1;
        
        private int _key2;
        
        [KeyProperty(ColumnType="Int32")]
        public int Key1 {
            get {
                return this._key1;
            }
            set {
                this._key1 = value;
            }
        }
        
        [KeyProperty(ColumnType="Int32")]
        public int Key2 {
            get {
                return this._key2;
            }
            set {
                this._key2 = value;
            }
        }
        
        public override string ToString() {
            return String.Join(":", new string[] {
                        this._key1.ToString(),
                        this._key2.ToString()});
        }
        
        public override bool Equals(object obj) {
            if ((obj == this)) {
                return true;
            }
            if (((obj == null) 
                        || (obj.GetType() != this.GetType()))) {
                return false;
            }
            ClassWithCompositeKeyCompositeKey test = ((ClassWithCompositeKeyCompositeKey)(obj));
            return (((_key1 == test._key1) 
                        || ((_key1 != null) 
                        && _key1.Equals(test._key1))) 
                        && ((_key2 == test._key2) 
                        || ((_key2 != null) 
                        && _key2.Equals(test._key2))));
        }
        
        public override int GetHashCode() {
            return XorHelper(_key1.GetHashCode(), _key2.GetHashCode());
        }
        
        private int XorHelper(int left, int right) {
            return left ^ right;
        }
    }
    
    [ActiveRecord()]
    public partial class ManyToOne_Many : ActiveRecordBase {
        
        private string _post_id;
        
        private ManyToOne_One _sourceProperty;
        
        [PrimaryKey(PrimaryKeyType.Native, ColumnType="String")]
        public string post_id {
            get {
                return this._post_id;
            }
            set {
                this._post_id = value;
            }
        }
        
        [BelongsTo("post_blogid", Cascade=CascadeEnum.All, CustomAccess="SourceCustomAccss", Insert=false, NotNull=true, OuterJoin=OuterJoinEnum.True, Type=typeof(ManyToOne_Many), Unique=true, Update=false, NotFoundBehaviour=NotFoundBehaviour.Ignore)]
        public ManyToOne_One SourceProperty {
            get {
                return this._sourceProperty;
            }
            set {
                this._sourceProperty = value;
            }
        }
    }
    
    [ActiveRecord()]
    public partial class ManyToOne_One : ActiveRecordBase {
        
        private string _blog_id;
        
        private IList<ManyToOne_Many> _manyToOne_Manies;
        
        [PrimaryKey(PrimaryKeyType.Native, ColumnType="String")]
        public string blog_id {
            get {
                return this._blog_id;
            }
            set {
                this._blog_id = value;
            }
        }
        
        [HasMany(typeof(ManyToOne_Many), Cache=CacheEnum.ReadOnly, Cascade=ManyRelationCascadeEnum.All, ColumnKey="post_blogid", CustomAccess="TargetCustomAccess", Inverse=true, Lazy=true, OrderBy="TargetOrderBy", RelationType=RelationType.Bag, Schema="TargetSchema", Table="Posts", Where="TargetWhere", NotFoundBehaviour=NotFoundBehaviour.Exception, Element="TargetElement")]
        public IList<ManyToOne_Many> ManyToOne_Manies {
            get {
                return this._manyToOne_Manies;
            }
            set {
                this._manyToOne_Manies = value;
            }
        }
    }
    
    [ActiveRecord()]
    public partial class ManyToMany_First : ActiveRecordBase {
        
        private string _post_id;
        
        private IList<ManyToMany_Second> _targetProperties;
        
        [PrimaryKey(PrimaryKeyType.Native, ColumnType="String")]
        public string post_id {
            get {
                return this._post_id;
            }
            set {
                this._post_id = value;
            }
        }
        
        [HasAndBelongsToMany(typeof(ManyToMany_Second), Cache=CacheEnum.ReadOnly, Cascade=ManyRelationCascadeEnum.All, CustomAccess="TargetCustomAccess", ColumnRef="tag_id", ColumnKey="post_id", Inverse=true, Lazy=true, MapType=typeof(ManyToMany_Second), OrderBy="TargetOrderBy", RelationType=RelationType.Bag, Where="TargetWhere", NotFoundBehaviour=NotFoundBehaviour.Exception, Schema="dbo", Table="FirstSecond")]
        public IList<ManyToMany_Second> TargetProperties {
            get {
                return this._targetProperties;
            }
            set {
                this._targetProperties = value;
            }
        }
    }
    
    [ActiveRecord()]
    public partial class ManyToMany_Second : ActiveRecordBase {
        
        private string _tag_id;
        
        private IList<ManyToMany_First> _sourceProperties;
        
        [PrimaryKey(PrimaryKeyType.Native, ColumnType="String")]
        public string tag_id {
            get {
                return this._tag_id;
            }
            set {
                this._tag_id = value;
            }
        }
        
        [HasAndBelongsToMany(typeof(ManyToMany_First), Cache=CacheEnum.ReadOnly, Cascade=ManyRelationCascadeEnum.All, CustomAccess="SourceCustomAccess", ColumnRef="post_id", ColumnKey="tag_id", Inverse=true, Lazy=true, MapType=typeof(ManyToMany_First), OrderBy="SourceOrderBy", RelationType=RelationType.Bag, Where="SourceWhere", NotFoundBehaviour=NotFoundBehaviour.Exception, Schema="dbo", Table="FirstSecond")]
        public IList<ManyToMany_First> SourceProperties {
            get {
                return this._sourceProperties;
            }
            set {
                this._sourceProperties = value;
            }
        }
    }
    
    [ActiveRecord()]
    public partial class ExplicitGenericClassInNonGenericModel : ActiveRecordBase<ExplicitGenericClassInNonGenericModel> {
    }
    
    [ActiveRecord()]
    public partial class ExplicitNonGenericClassInNonGenericModel : ActiveRecordBase {
    }
    
    [ActiveRecord()]
    public partial class OneToOne_Target : ActiveRecordBase {
        
        private string _id;
        
        private OneToOne_Source _oneToOne_Source;
        
        [PrimaryKey(PrimaryKeyType.Native, ColumnType="String")]
        public string id {
            get {
                return this._id;
            }
            set {
                this._id = value;
            }
        }
        
        [OneToOne()]
        public OneToOne_Source OneToOne_Source {
            get {
                return this._oneToOne_Source;
            }
            set {
                this._oneToOne_Source = value;
            }
        }
    }
    
    [ActiveRecord()]
    public partial class OneToOne_Source : ActiveRecordBase {
        
        private string _target_id;
        
        private OneToOne_Target _oneToOne_Target;
        
        [PrimaryKey(PrimaryKeyType.Foreign, ColumnType="String")]
        public string target_id {
            get {
                return this._target_id;
            }
            set {
                this._target_id = value;
            }
        }
        
        [OneToOne()]
        public OneToOne_Target OneToOne_Target {
            get {
                return this._oneToOne_Target;
            }
            set {
                this._oneToOne_Target = value;
            }
        }
    }
    
    [ActiveRecord()]
    public partial class LazyOneToOne_Target : ActiveRecordBase {
        
        private string _id;
        
        private LazyOneToOne_Source _lazyOneToOne_Source;
        
        [PrimaryKey(PrimaryKeyType.Native, ColumnType="String")]
        public string id {
            get {
                return this._id;
            }
            set {
                this._id = value;
            }
        }
        
        [BelongsTo()]
        public LazyOneToOne_Source LazyOneToOne_Source {
            get {
                return this._lazyOneToOne_Source;
            }
            set {
                this._lazyOneToOne_Source = value;
            }
        }
    }
    
    [ActiveRecord()]
    public partial class LazyOneToOne_Source : ActiveRecordBase {
        
        private string _target_id;
        
        private LazyOneToOne_Target _lazyOneToOne_Target;
        
        [PrimaryKey(PrimaryKeyType.Foreign, ColumnType="String")]
        public string target_id {
            get {
                return this._target_id;
            }
            set {
                this._target_id = value;
            }
        }
        
        [OneToOne()]
        public LazyOneToOne_Target LazyOneToOne_Target {
            get {
                return this._lazyOneToOne_Target;
            }
            set {
                this._lazyOneToOne_Target = value;
            }
        }
    }
    
    [ActiveRecord()]
    [System.Diagnostics.DebuggerDisplay("DebuggerDisplayProperty = {1}")]
    [System.Reflection.DefaultMember("DefaultMemberProperty")]
    public partial class DebuggerDisplayAndDefaultMemberTestClass : ActiveRecordBase {
        
        private string _debuggerDisplayProperty;
        
        private string _defaultMemberProperty;
        
        [Property(ColumnType="String")]
        public string DebuggerDisplayProperty {
            get {
                return this._debuggerDisplayProperty;
            }
            set {
                this._debuggerDisplayProperty = value;
            }
        }
        
        [Property(ColumnType="String")]
        public string DefaultMemberProperty {
            get {
                return this._defaultMemberProperty;
            }
            set {
                this._defaultMemberProperty = value;
            }
        }
    }
    
    public class GeneratedCodeNonGenericTestModelHelper {
        
        public static Type[] GetTypes() {
            return new Type[] {
                    typeof(SimpleClass),
                    typeof(ClassWithProperties),
                    typeof(ClassWithPK),
                    typeof(ClassWithCompositeKey),
                    typeof(ManyToOne_Many),
                    typeof(ManyToOne_One),
                    typeof(ManyToMany_First),
                    typeof(ManyToMany_Second),
                    typeof(ExplicitGenericClassInNonGenericModel),
                    typeof(ExplicitNonGenericClassInNonGenericModel),
                    typeof(OneToOne_Target),
                    typeof(OneToOne_Source),
                    typeof(LazyOneToOne_Target),
                    typeof(LazyOneToOne_Source),
                    typeof(DebuggerDisplayAndDefaultMemberTestClass)};
        }
    }
}
