﻿#region License
//  Copyright 2004-2010 Castle Project - http:www.castleproject.org/
//  
//  Licensed under the Apache License, Version 2.0 (the "License");
//  you may not use this file except in compliance with the License.
//  You may obtain a copy of the License at
//  
//      http:www.apache.org/licenses/LICENSE-2.0
//  
//  Unless required by applicable law or agreed to in writing, software
//  distributed under the License is distributed on an "AS IS" BASIS,
//  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//  See the License for the specific language governing permissions and
//  limitations under the License.
// 
#endregion
using DslModeling = global::Microsoft.VisualStudio.Modeling;
using DslDesign = global::Microsoft.VisualStudio.Modeling.Design;
namespace Castle.ActiveWriter
{
	/// <summary>
	/// DomainClass Model
	/// Domain model
	/// </summary>
	[DslDesign::DisplayNameResource("Castle.ActiveWriter.Model.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
	[DslDesign::DescriptionResource("Castle.ActiveWriter.Model.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
	[DslModeling::DomainModelOwner(typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel))]
	[global::System.CLSCompliant(true)]
	[DslModeling::DomainObjectId("fe94e99d-28aa-4a5d-9e43-168adeb72b60")]
	public partial class Model : DslModeling::ModelElement
	{
		#region Constructors, domain class Id
	
		/// <summary>
		/// Model domain class Id.
		/// </summary>
		public static readonly new global::System.Guid DomainClassId = new global::System.Guid(0xfe94e99d, 0x28aa, 0x4a5d, 0x9e, 0x43, 0x16, 0x8a, 0xde, 0xb7, 0x2b, 0x60);
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="store">Store where new element is to be created.</param>
		/// <param name="propertyAssignments">List of domain property id/value pairs to set once the element is created.</param>
		public Model(DslModeling::Store store, params DslModeling::PropertyAssignment[] propertyAssignments)
			: this(store != null ? store.DefaultPartitionForClass(DomainClassId) : null, propertyAssignments)
		{
		}
		
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="partition">Partition where new element is to be created.</param>
		/// <param name="propertyAssignments">List of domain property id/value pairs to set once the element is created.</param>
		public Model(DslModeling::Partition partition, params DslModeling::PropertyAssignment[] propertyAssignments)
			: base(partition, propertyAssignments)
		{
		}
		#endregion
		#region UseNullables domain property code
		
		/// <summary>
		/// UseNullables domain property Id.
		/// </summary>
		public static readonly global::System.Guid UseNullablesDomainPropertyId = new global::System.Guid(0xf85b9035, 0xc755, 0x438f, 0xb5, 0x4d, 0x2a, 0xce, 0xbc, 0x63, 0x6a, 0x8c);
		
		/// <summary>
		/// Storage for UseNullables
		/// </summary>
		private NullableUsage useNullablesPropertyStorage = NullableUsage.No;
		
		/// <summary>
		/// Gets or sets the value of UseNullables domain property.
		/// Instructs ActiveWriter to generate code using nullables where possible.
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.Model/UseNullables.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.Model/UseNullables.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.Model/UseNullables.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[global::System.ComponentModel.DefaultValue(NullableUsage.No)]
		[DslModeling::DomainObjectId("f85b9035-c755-438f-b54d-2acebc636a8c")]
		public NullableUsage UseNullables
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return useNullablesPropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				UseNullablesPropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the Model.UseNullables domain property.
		/// </summary>
		internal sealed partial class UseNullablesPropertyHandler : DslModeling::DomainPropertyValueHandler<Model, NullableUsage>
		{
			private UseNullablesPropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the Model.UseNullables domain property value handler.
			/// </summary>
			public static readonly UseNullablesPropertyHandler Instance = new UseNullablesPropertyHandler();
		
			/// <summary>
			/// Gets the Id of the Model.UseNullables domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return UseNullablesDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed NullableUsage GetValue(Model element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.useNullablesPropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(Model element, NullableUsage newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				NullableUsage oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.useNullablesPropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region CaseOfPrivateFields domain property code
		
		/// <summary>
		/// CaseOfPrivateFields domain property Id.
		/// </summary>
		public static readonly global::System.Guid CaseOfPrivateFieldsDomainPropertyId = new global::System.Guid(0x571d0e7c, 0xb79b, 0x432e, 0x81, 0xff, 0x2c, 0x76, 0x65, 0xc9, 0x59, 0xb1);
		
		/// <summary>
		/// Storage for CaseOfPrivateFields
		/// </summary>
		private FieldCase caseOfPrivateFieldsPropertyStorage = FieldCase.CamelcaseUnderscore;
		
		/// <summary>
		/// Gets or sets the value of CaseOfPrivateFields domain property.
		/// Tells ActiveWriter how to name private fields of properties if the Access of
		/// Property is PropertyAccess.Property (Default)
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.Model/CaseOfPrivateFields.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.Model/CaseOfPrivateFields.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.Model/CaseOfPrivateFields.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[global::System.ComponentModel.DefaultValue(FieldCase.CamelcaseUnderscore)]
		[DslModeling::DomainObjectId("571d0e7c-b79b-432e-81ff-2c7665c959b1")]
		public FieldCase CaseOfPrivateFields
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return caseOfPrivateFieldsPropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				CaseOfPrivateFieldsPropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the Model.CaseOfPrivateFields domain property.
		/// </summary>
		internal sealed partial class CaseOfPrivateFieldsPropertyHandler : DslModeling::DomainPropertyValueHandler<Model, FieldCase>
		{
			private CaseOfPrivateFieldsPropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the Model.CaseOfPrivateFields domain property value handler.
			/// </summary>
			public static readonly CaseOfPrivateFieldsPropertyHandler Instance = new CaseOfPrivateFieldsPropertyHandler();
		
			/// <summary>
			/// Gets the Id of the Model.CaseOfPrivateFields domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return CaseOfPrivateFieldsDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed FieldCase GetValue(Model element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.caseOfPrivateFieldsPropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(Model element, FieldCase newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				FieldCase oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.caseOfPrivateFieldsPropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region GenerateMonoRailProject domain property code
		
		/// <summary>
		/// GenerateMonoRailProject domain property Id.
		/// </summary>
		public static readonly global::System.Guid GenerateMonoRailProjectDomainPropertyId = new global::System.Guid(0x33b55d51, 0xbc5b, 0x4ef3, 0xa0, 0x7c, 0x8a, 0xe6, 0xf7, 0x25, 0x31, 0xbc);
		
		/// <summary>
		/// Storage for GenerateMonoRailProject
		/// </summary>
		private global::System.Boolean generateMonoRailProjectPropertyStorage;
		
		/// <summary>
		/// Gets or sets the value of GenerateMonoRailProject domain property.
		/// Tells ActiveWriter to generate a seperate MonoRail project with View and
		/// Controller code, taking this file's output as the model.
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.Model/GenerateMonoRailProject.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.Model/GenerateMonoRailProject.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.Model/GenerateMonoRailProject.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[global::System.ComponentModel.Browsable(false)]
		[DslModeling::DomainObjectId("33b55d51-bc5b-4ef3-a07c-8ae6f72531bc")]
		public global::System.Boolean GenerateMonoRailProject
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return generateMonoRailProjectPropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				GenerateMonoRailProjectPropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the Model.GenerateMonoRailProject domain property.
		/// </summary>
		internal sealed partial class GenerateMonoRailProjectPropertyHandler : DslModeling::DomainPropertyValueHandler<Model, global::System.Boolean>
		{
			private GenerateMonoRailProjectPropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the Model.GenerateMonoRailProject domain property value handler.
			/// </summary>
			public static readonly GenerateMonoRailProjectPropertyHandler Instance = new GenerateMonoRailProjectPropertyHandler();
		
			/// <summary>
			/// Gets the Id of the Model.GenerateMonoRailProject domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return GenerateMonoRailProjectDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed global::System.Boolean GetValue(Model element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.generateMonoRailProjectPropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(Model element, global::System.Boolean newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				global::System.Boolean oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.generateMonoRailProjectPropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region MonoRailProjectName domain property code
		
		/// <summary>
		/// MonoRailProjectName domain property Id.
		/// </summary>
		public static readonly global::System.Guid MonoRailProjectNameDomainPropertyId = new global::System.Guid(0x2ac42985, 0x50d1, 0x4ba7, 0xbc, 0x7a, 0x63, 0x43, 0x2a, 0x73, 0x95, 0x78);
		
		/// <summary>
		/// Storage for MonoRailProjectName
		/// </summary>
		private global::System.String monoRailProjectNamePropertyStorage = string.Empty;
		
		/// <summary>
		/// Gets or sets the value of MonoRailProjectName domain property.
		/// Name of the MonoRail project. If a project with the same name already exists in
		/// the solution, it won't be added to the solution.
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.Model/MonoRailProjectName.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.Model/MonoRailProjectName.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.Model/MonoRailProjectName.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[global::System.ComponentModel.Browsable(false)]
		[DslModeling::DomainObjectId("2ac42985-50d1-4ba7-bc7a-63432a739578")]
		public global::System.String MonoRailProjectName
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return monoRailProjectNamePropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				MonoRailProjectNamePropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the Model.MonoRailProjectName domain property.
		/// </summary>
		internal sealed partial class MonoRailProjectNamePropertyHandler : DslModeling::DomainPropertyValueHandler<Model, global::System.String>
		{
			private MonoRailProjectNamePropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the Model.MonoRailProjectName domain property value handler.
			/// </summary>
			public static readonly MonoRailProjectNamePropertyHandler Instance = new MonoRailProjectNamePropertyHandler();
		
			/// <summary>
			/// Gets the Id of the Model.MonoRailProjectName domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return MonoRailProjectNameDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed global::System.String GetValue(Model element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.monoRailProjectNamePropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(Model element, global::System.String newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				global::System.String oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.monoRailProjectNamePropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region MonoRailProjectPath domain property code
		
		/// <summary>
		/// MonoRailProjectPath domain property Id.
		/// </summary>
		public static readonly global::System.Guid MonoRailProjectPathDomainPropertyId = new global::System.Guid(0x2e26d6e6, 0xfc84, 0x4453, 0x82, 0xb0, 0x1a, 0x45, 0x99, 0xeb, 0xa3, 0x9a);
		
		/// <summary>
		/// Storage for MonoRailProjectPath
		/// </summary>
		private global::System.String monoRailProjectPathPropertyStorage = string.Empty;
		
		/// <summary>
		/// Gets or sets the value of MonoRailProjectPath domain property.
		/// Description for Castle.ActiveWriter.Model.MonoRail Project Path
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.Model/MonoRailProjectPath.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.Model/MonoRailProjectPath.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.Model/MonoRailProjectPath.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[global::System.ComponentModel.Browsable(false)]
		[DslModeling::DomainObjectId("2e26d6e6-fc84-4453-82b0-1a4599eba39a")]
		public global::System.String MonoRailProjectPath
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return monoRailProjectPathPropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				MonoRailProjectPathPropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the Model.MonoRailProjectPath domain property.
		/// </summary>
		internal sealed partial class MonoRailProjectPathPropertyHandler : DslModeling::DomainPropertyValueHandler<Model, global::System.String>
		{
			private MonoRailProjectPathPropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the Model.MonoRailProjectPath domain property value handler.
			/// </summary>
			public static readonly MonoRailProjectPathPropertyHandler Instance = new MonoRailProjectPathPropertyHandler();
		
			/// <summary>
			/// Gets the Id of the Model.MonoRailProjectPath domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return MonoRailProjectPathDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed global::System.String GetValue(Model element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.monoRailProjectPathPropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(Model element, global::System.String newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				global::System.String oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.monoRailProjectPathPropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region MonoRailDefaultLayout domain property code
		
		/// <summary>
		/// MonoRailDefaultLayout domain property Id.
		/// </summary>
		public static readonly global::System.Guid MonoRailDefaultLayoutDomainPropertyId = new global::System.Guid(0xb5eb159d, 0xc09e, 0x4bb5, 0xbb, 0xd2, 0xc2, 0x4a, 0x98, 0xa1, 0x87, 0xdb);
		
		/// <summary>
		/// Storage for MonoRailDefaultLayout
		/// </summary>
		private global::System.String monoRailDefaultLayoutPropertyStorage = "default";
		
		/// <summary>
		/// Gets or sets the value of MonoRailDefaultLayout domain property.
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.Model/MonoRailDefaultLayout.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.Model/MonoRailDefaultLayout.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.Model/MonoRailDefaultLayout.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[global::System.ComponentModel.DefaultValue("default")]
		[global::System.ComponentModel.Browsable(false)]
		[DslModeling::DomainObjectId("b5eb159d-c09e-4bb5-bbd2-c24a98a187db")]
		public global::System.String MonoRailDefaultLayout
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return monoRailDefaultLayoutPropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				MonoRailDefaultLayoutPropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the Model.MonoRailDefaultLayout domain property.
		/// </summary>
		internal sealed partial class MonoRailDefaultLayoutPropertyHandler : DslModeling::DomainPropertyValueHandler<Model, global::System.String>
		{
			private MonoRailDefaultLayoutPropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the Model.MonoRailDefaultLayout domain property value handler.
			/// </summary>
			public static readonly MonoRailDefaultLayoutPropertyHandler Instance = new MonoRailDefaultLayoutPropertyHandler();
		
			/// <summary>
			/// Gets the Id of the Model.MonoRailDefaultLayout domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return MonoRailDefaultLayoutDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed global::System.String GetValue(Model element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.monoRailDefaultLayoutPropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(Model element, global::System.String newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				global::System.String oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.monoRailDefaultLayoutPropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region MonoRailDefaultRescue domain property code
		
		/// <summary>
		/// MonoRailDefaultRescue domain property Id.
		/// </summary>
		public static readonly global::System.Guid MonoRailDefaultRescueDomainPropertyId = new global::System.Guid(0x32fc8076, 0x7817, 0x4ad8, 0x91, 0x2d, 0x29, 0x4f, 0xed, 0x66, 0x60, 0x72);
		
		/// <summary>
		/// Storage for MonoRailDefaultRescue
		/// </summary>
		private global::System.String monoRailDefaultRescuePropertyStorage = "generalerror";
		
		/// <summary>
		/// Gets or sets the value of MonoRailDefaultRescue domain property.
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.Model/MonoRailDefaultRescue.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.Model/MonoRailDefaultRescue.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.Model/MonoRailDefaultRescue.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[global::System.ComponentModel.DefaultValue("generalerror")]
		[global::System.ComponentModel.Browsable(false)]
		[DslModeling::DomainObjectId("32fc8076-7817-4ad8-912d-294fed666072")]
		public global::System.String MonoRailDefaultRescue
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return monoRailDefaultRescuePropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				MonoRailDefaultRescuePropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the Model.MonoRailDefaultRescue domain property.
		/// </summary>
		internal sealed partial class MonoRailDefaultRescuePropertyHandler : DslModeling::DomainPropertyValueHandler<Model, global::System.String>
		{
			private MonoRailDefaultRescuePropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the Model.MonoRailDefaultRescue domain property value handler.
			/// </summary>
			public static readonly MonoRailDefaultRescuePropertyHandler Instance = new MonoRailDefaultRescuePropertyHandler();
		
			/// <summary>
			/// Gets the Id of the Model.MonoRailDefaultRescue domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return MonoRailDefaultRescueDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed global::System.String GetValue(Model element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.monoRailDefaultRescuePropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(Model element, global::System.String newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				global::System.String oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.monoRailDefaultRescuePropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region MonoRailViewFileExtension domain property code
		
		/// <summary>
		/// MonoRailViewFileExtension domain property Id.
		/// </summary>
		public static readonly global::System.Guid MonoRailViewFileExtensionDomainPropertyId = new global::System.Guid(0xa2f2a0c7, 0xf6d5, 0x4f0c, 0x8c, 0xa3, 0xf7, 0x92, 0x0c, 0xc4, 0xf5, 0x46);
		
		/// <summary>
		/// Storage for MonoRailViewFileExtension
		/// </summary>
		private global::System.String monoRailViewFileExtensionPropertyStorage = ".vm";
		
		/// <summary>
		/// Gets or sets the value of MonoRailViewFileExtension domain property.
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.Model/MonoRailViewFileExtension.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.Model/MonoRailViewFileExtension.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.Model/MonoRailViewFileExtension.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[global::System.ComponentModel.DefaultValue(".vm")]
		[global::System.ComponentModel.Browsable(false)]
		[DslModeling::DomainObjectId("a2f2a0c7-f6d5-4f0c-8ca3-f7920cc4f546")]
		public global::System.String MonoRailViewFileExtension
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return monoRailViewFileExtensionPropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				MonoRailViewFileExtensionPropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the Model.MonoRailViewFileExtension domain property.
		/// </summary>
		internal sealed partial class MonoRailViewFileExtensionPropertyHandler : DslModeling::DomainPropertyValueHandler<Model, global::System.String>
		{
			private MonoRailViewFileExtensionPropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the Model.MonoRailViewFileExtension domain property value handler.
			/// </summary>
			public static readonly MonoRailViewFileExtensionPropertyHandler Instance = new MonoRailViewFileExtensionPropertyHandler();
		
			/// <summary>
			/// Gets the Id of the Model.MonoRailViewFileExtension domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return MonoRailViewFileExtensionDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed global::System.String GetValue(Model element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.monoRailViewFileExtensionPropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(Model element, global::System.String newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				global::System.String oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.monoRailViewFileExtensionPropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region UseGenerics domain property code
		
		/// <summary>
		/// UseGenerics domain property Id.
		/// </summary>
		public static readonly global::System.Guid UseGenericsDomainPropertyId = new global::System.Guid(0xfb8adf70, 0x25ad, 0x408c, 0x8c, 0x6b, 0x29, 0x7e, 0x2e, 0x71, 0x93, 0x64);
		
		/// <summary>
		/// Storage for UseGenerics
		/// </summary>
		private global::System.Boolean useGenericsPropertyStorage = true;
		
		/// <summary>
		/// Gets or sets the value of UseGenerics domain property.
		/// Instructs ActiveWriter to generate code using generic bases where possible. This
		/// setting is overridable in class level.
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.Model/UseGenerics.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.Model/UseGenerics.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.Model/UseGenerics.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[global::System.ComponentModel.DefaultValue(true)]
		[DslModeling::DomainObjectId("fb8adf70-25ad-408c-8c6b-297e2e719364")]
		public global::System.Boolean UseGenerics
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return useGenericsPropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				UseGenericsPropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the Model.UseGenerics domain property.
		/// </summary>
		internal sealed partial class UseGenericsPropertyHandler : DslModeling::DomainPropertyValueHandler<Model, global::System.Boolean>
		{
			private UseGenericsPropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the Model.UseGenerics domain property value handler.
			/// </summary>
			public static readonly UseGenericsPropertyHandler Instance = new UseGenericsPropertyHandler();
		
			/// <summary>
			/// Gets the Id of the Model.UseGenerics domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return UseGenericsDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed global::System.Boolean GetValue(Model element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.useGenericsPropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(Model element, global::System.Boolean newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				global::System.Boolean oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.useGenericsPropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region UseBaseClass domain property code
		
		/// <summary>
		/// UseBaseClass domain property Id.
		/// </summary>
		public static readonly global::System.Guid UseBaseClassDomainPropertyId = new global::System.Guid(0xbdef414b, 0xe1ca, 0x4d13, 0x9c, 0x39, 0xce, 0x0b, 0xa0, 0x0d, 0xee, 0x7b);
		
		/// <summary>
		/// Storage for UseBaseClass
		/// </summary>
		private global::System.Boolean useBaseClassPropertyStorage = true;
		
		/// <summary>
		/// Gets or sets the value of UseBaseClass domain property.
		/// Instructs ActiveWriter to generate classes inherited from a base class. If Base
		/// Class Name property is empty, ActiveRecordBase or ActiveRecordBase<T> will be
		/// used depending on the Use generics property.
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.Model/UseBaseClass.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.Model/UseBaseClass.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.Model/UseBaseClass.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[global::System.ComponentModel.DefaultValue(true)]
		[DslModeling::DomainObjectId("bdef414b-e1ca-4d13-9c39-ce0ba00dee7b")]
		public global::System.Boolean UseBaseClass
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return useBaseClassPropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				UseBaseClassPropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the Model.UseBaseClass domain property.
		/// </summary>
		internal sealed partial class UseBaseClassPropertyHandler : DslModeling::DomainPropertyValueHandler<Model, global::System.Boolean>
		{
			private UseBaseClassPropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the Model.UseBaseClass domain property value handler.
			/// </summary>
			public static readonly UseBaseClassPropertyHandler Instance = new UseBaseClassPropertyHandler();
		
			/// <summary>
			/// Gets the Id of the Model.UseBaseClass domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return UseBaseClassDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed global::System.Boolean GetValue(Model element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.useBaseClassPropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(Model element, global::System.Boolean newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				global::System.Boolean oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.useBaseClassPropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region BaseClassName domain property code
		
		/// <summary>
		/// BaseClassName domain property Id.
		/// </summary>
		public static readonly global::System.Guid BaseClassNameDomainPropertyId = new global::System.Guid(0xddcc1b4e, 0x07e8, 0x4331, 0x97, 0x78, 0xf7, 0xcb, 0x46, 0x37, 0x5c, 0xc1);
		
		/// <summary>
		/// Storage for BaseClassName
		/// </summary>
		private global::System.String baseClassNamePropertyStorage = string.Empty;
		
		/// <summary>
		/// Gets or sets the value of BaseClassName domain property.
		/// Defines the base class to be inherited. Does have no effect if Use Base Class
		/// property is set to false.
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.Model/BaseClassName.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.Model/BaseClassName.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.Model/BaseClassName.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslModeling::DomainObjectId("ddcc1b4e-07e8-4331-9778-f7cb46375cc1")]
		public global::System.String BaseClassName
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return baseClassNamePropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				BaseClassNamePropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the Model.BaseClassName domain property.
		/// </summary>
		internal sealed partial class BaseClassNamePropertyHandler : DslModeling::DomainPropertyValueHandler<Model, global::System.String>
		{
			private BaseClassNamePropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the Model.BaseClassName domain property value handler.
			/// </summary>
			public static readonly BaseClassNamePropertyHandler Instance = new BaseClassNamePropertyHandler();
		
			/// <summary>
			/// Gets the Id of the Model.BaseClassName domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return BaseClassNameDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed global::System.String GetValue(Model element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.baseClassNamePropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(Model element, global::System.String newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				global::System.String oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.baseClassNamePropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region GeneratesDoubleDerived domain property code
		
		/// <summary>
		/// GeneratesDoubleDerived domain property Id.
		/// </summary>
		public static readonly global::System.Guid GeneratesDoubleDerivedDomainPropertyId = new global::System.Guid(0xc2748bf4, 0x55c5, 0x42b0, 0x88, 0x23, 0x6a, 0xc3, 0x81, 0xaa, 0xb1, 0x3e);
		
		/// <summary>
		/// Storage for GeneratesDoubleDerived
		/// </summary>
		private global::System.Boolean generatesDoubleDerivedPropertyStorage;
		
		/// <summary>
		/// Gets or sets the value of GeneratesDoubleDerived domain property.
		/// If true, will generate a base class with all functionality and a derived partial
		/// class to support customization through overrides.
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.Model/GeneratesDoubleDerived.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.Model/GeneratesDoubleDerived.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.Model/GeneratesDoubleDerived.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslModeling::DomainObjectId("c2748bf4-55c5-42b0-8823-6ac381aab13e")]
		public global::System.Boolean GeneratesDoubleDerived
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return generatesDoubleDerivedPropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				GeneratesDoubleDerivedPropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the Model.GeneratesDoubleDerived domain property.
		/// </summary>
		internal sealed partial class GeneratesDoubleDerivedPropertyHandler : DslModeling::DomainPropertyValueHandler<Model, global::System.Boolean>
		{
			private GeneratesDoubleDerivedPropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the Model.GeneratesDoubleDerived domain property value handler.
			/// </summary>
			public static readonly GeneratesDoubleDerivedPropertyHandler Instance = new GeneratesDoubleDerivedPropertyHandler();
		
			/// <summary>
			/// Gets the Id of the Model.GeneratesDoubleDerived domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return GeneratesDoubleDerivedDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed global::System.Boolean GetValue(Model element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.generatesDoubleDerivedPropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(Model element, global::System.Boolean newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				global::System.Boolean oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.generatesDoubleDerivedPropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region DoubleDerivedNameSuffix domain property code
		
		/// <summary>
		/// DoubleDerivedNameSuffix domain property Id.
		/// </summary>
		public static readonly global::System.Guid DoubleDerivedNameSuffixDomainPropertyId = new global::System.Guid(0x98f6b364, 0x1d02, 0x4613, 0xb2, 0x06, 0x20, 0xbd, 0x68, 0x23, 0xb1, 0x15);
		
		/// <summary>
		/// Storage for DoubleDerivedNameSuffix
		/// </summary>
		private global::System.String doubleDerivedNameSuffixPropertyStorage = "Base";
		
		/// <summary>
		/// Gets or sets the value of DoubleDerivedNameSuffix domain property.
		/// Suffix appended to base class names in double derived code generation. Defaults
		/// to "Base", if not supplied.
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.Model/DoubleDerivedNameSuffix.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.Model/DoubleDerivedNameSuffix.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[global::System.ComponentModel.DefaultValue("Base")]
		[DslModeling::DomainObjectId("98f6b364-1d02-4613-b206-20bd6823b115")]
		public global::System.String DoubleDerivedNameSuffix
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return doubleDerivedNameSuffixPropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				DoubleDerivedNameSuffixPropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the Model.DoubleDerivedNameSuffix domain property.
		/// </summary>
		internal sealed partial class DoubleDerivedNameSuffixPropertyHandler : DslModeling::DomainPropertyValueHandler<Model, global::System.String>
		{
			private DoubleDerivedNameSuffixPropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the Model.DoubleDerivedNameSuffix domain property value handler.
			/// </summary>
			public static readonly DoubleDerivedNameSuffixPropertyHandler Instance = new DoubleDerivedNameSuffixPropertyHandler();
		
			/// <summary>
			/// Gets the Id of the Model.DoubleDerivedNameSuffix domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return DoubleDerivedNameSuffixDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed global::System.String GetValue(Model element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.doubleDerivedNameSuffixPropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(Model element, global::System.String newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				global::System.String oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.doubleDerivedNameSuffixPropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region UseGeneratedCodeAttribute domain property code
		
		/// <summary>
		/// UseGeneratedCodeAttribute domain property Id.
		/// </summary>
		public static readonly global::System.Guid UseGeneratedCodeAttributeDomainPropertyId = new global::System.Guid(0x6fe83f5a, 0xb88d, 0x4b40, 0x89, 0xb2, 0xde, 0xd4, 0xbf, 0xf8, 0x8a, 0x7f);
		
		/// <summary>
		/// Storage for UseGeneratedCodeAttribute
		/// </summary>
		private global::System.Boolean useGeneratedCodeAttributePropertyStorage;
		
		/// <summary>
		/// Gets or sets the value of UseGeneratedCodeAttribute domain property.
		/// Instructs ActiveWriter to decorate each class with GeneratedCodeAttribute. Some
		/// tools evaluate existance of this attribute to handle code differently.
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.Model/UseGeneratedCodeAttribute.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.Model/UseGeneratedCodeAttribute.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.Model/UseGeneratedCodeAttribute.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslModeling::DomainObjectId("6fe83f5a-b88d-4b40-89b2-ded4bff88a7f")]
		public global::System.Boolean UseGeneratedCodeAttribute
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return useGeneratedCodeAttributePropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				UseGeneratedCodeAttributePropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the Model.UseGeneratedCodeAttribute domain property.
		/// </summary>
		internal sealed partial class UseGeneratedCodeAttributePropertyHandler : DslModeling::DomainPropertyValueHandler<Model, global::System.Boolean>
		{
			private UseGeneratedCodeAttributePropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the Model.UseGeneratedCodeAttribute domain property value handler.
			/// </summary>
			public static readonly UseGeneratedCodeAttributePropertyHandler Instance = new UseGeneratedCodeAttributePropertyHandler();
		
			/// <summary>
			/// Gets the Id of the Model.UseGeneratedCodeAttribute domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return UseGeneratedCodeAttributeDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed global::System.Boolean GetValue(Model element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.useGeneratedCodeAttributePropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(Model element, global::System.Boolean newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				global::System.Boolean oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.useGeneratedCodeAttributePropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region Target domain property code
		
		/// <summary>
		/// Target domain property Id.
		/// </summary>
		public static readonly global::System.Guid TargetDomainPropertyId = new global::System.Guid(0x60bf3b58, 0x876b, 0x4d6a, 0x8e, 0x36, 0x21, 0xae, 0x05, 0x4e, 0x0d, 0xaf);
		
		/// <summary>
		/// Storage for Target
		/// </summary>
		private CodeGenerationTarget targetPropertyStorage = CodeGenerationTarget.ActiveRecord;
		
		/// <summary>
		/// Gets or sets the value of Target domain property.
		/// Defines the experimental code generation target.
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.Model/Target.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.Model/Target.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.Model/Target.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[global::System.ComponentModel.DefaultValue(CodeGenerationTarget.ActiveRecord)]
		[DslModeling::DomainObjectId("60bf3b58-876b-4d6a-8e36-21ae054e0daf")]
		public CodeGenerationTarget Target
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return targetPropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				TargetPropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the Model.Target domain property.
		/// </summary>
		internal sealed partial class TargetPropertyHandler : DslModeling::DomainPropertyValueHandler<Model, CodeGenerationTarget>
		{
			private TargetPropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the Model.Target domain property value handler.
			/// </summary>
			public static readonly TargetPropertyHandler Instance = new TargetPropertyHandler();
		
			/// <summary>
			/// Gets the Id of the Model.Target domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return TargetDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed CodeGenerationTarget GetValue(Model element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.targetPropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(Model element, CodeGenerationTarget newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				CodeGenerationTarget oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.targetPropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region AssemblyPath domain property code
		
		/// <summary>
		/// AssemblyPath domain property Id.
		/// </summary>
		public static readonly global::System.Guid AssemblyPathDomainPropertyId = new global::System.Guid(0xc2197ab7, 0xcf01, 0x432f, 0xb4, 0x4d, 0xeb, 0xbb, 0x4b, 0xde, 0xa1, 0x4d);
		
		/// <summary>
		/// Storage for AssemblyPath
		/// </summary>
		private global::System.String assemblyPathPropertyStorage = string.Empty;
		
		/// <summary>
		/// Gets or sets the value of AssemblyPath domain property.
		/// Provides assembly load path for Castle.ActiveRecord.dll and related assemblies.
		/// If required assemblies are in GAC, this setting is omitted. If not and is this
		/// setting is blank, or required assemblies not found under the given path if they
		/// are not in the GAC, an error will be thrown during code generation.
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.Model/AssemblyPath.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.Model/AssemblyPath.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.Model/AssemblyPath.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslModeling::DomainObjectId("c2197ab7-cf01-432f-b44d-ebbb4bdea14d")]
		public global::System.String AssemblyPath
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return assemblyPathPropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				AssemblyPathPropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the Model.AssemblyPath domain property.
		/// </summary>
		internal sealed partial class AssemblyPathPropertyHandler : DslModeling::DomainPropertyValueHandler<Model, global::System.String>
		{
			private AssemblyPathPropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the Model.AssemblyPath domain property value handler.
			/// </summary>
			public static readonly AssemblyPathPropertyHandler Instance = new AssemblyPathPropertyHandler();
		
			/// <summary>
			/// Gets the Id of the Model.AssemblyPath domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return AssemblyPathDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed global::System.String GetValue(Model element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.assemblyPathPropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(Model element, global::System.String newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				global::System.String oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.assemblyPathPropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region ActiveRecordAssemblyName domain property code
		
		/// <summary>
		/// ActiveRecordAssemblyName domain property Id.
		/// </summary>
		public static readonly global::System.Guid ActiveRecordAssemblyNameDomainPropertyId = new global::System.Guid(0x16c1464a, 0xbb58, 0x41bb, 0xad, 0x6b, 0x46, 0xb9, 0x57, 0xee, 0xc2, 0xa2);
		
		/// <summary>
		/// Storage for ActiveRecordAssemblyName
		/// </summary>
		private global::System.String activeRecordAssemblyNamePropertyStorage = "Castle.ActiveRecord";
		
		/// <summary>
		/// Gets or sets the value of ActiveRecordAssemblyName domain property.
		/// Provides assembly name to be used during code generation. You can provide a
		/// fully qualified assembly name to target a specific version from the GAC.
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.Model/ActiveRecordAssemblyName.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.Model/ActiveRecordAssemblyName.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.Model/ActiveRecordAssemblyName.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[global::System.ComponentModel.DefaultValue("Castle.ActiveRecord")]
		[DslModeling::DomainObjectId("16c1464a-bb58-41bb-ad6b-46b957eec2a2")]
		public global::System.String ActiveRecordAssemblyName
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return activeRecordAssemblyNamePropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				ActiveRecordAssemblyNamePropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the Model.ActiveRecordAssemblyName domain property.
		/// </summary>
		internal sealed partial class ActiveRecordAssemblyNamePropertyHandler : DslModeling::DomainPropertyValueHandler<Model, global::System.String>
		{
			private ActiveRecordAssemblyNamePropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the Model.ActiveRecordAssemblyName domain property value handler.
			/// </summary>
			public static readonly ActiveRecordAssemblyNamePropertyHandler Instance = new ActiveRecordAssemblyNamePropertyHandler();
		
			/// <summary>
			/// Gets the Id of the Model.ActiveRecordAssemblyName domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return ActiveRecordAssemblyNameDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed global::System.String GetValue(Model element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.activeRecordAssemblyNamePropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(Model element, global::System.String newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				global::System.String oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.activeRecordAssemblyNamePropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region NHibernateAssemblyName domain property code
		
		/// <summary>
		/// NHibernateAssemblyName domain property Id.
		/// </summary>
		public static readonly global::System.Guid NHibernateAssemblyNameDomainPropertyId = new global::System.Guid(0xa0bcb53c, 0xa856, 0x4a8d, 0x92, 0x45, 0xf9, 0x73, 0xdf, 0xb0, 0x23, 0xd3);
		
		/// <summary>
		/// Storage for NHibernateAssemblyName
		/// </summary>
		private global::System.String nHibernateAssemblyNamePropertyStorage = "NHibernate";
		
		/// <summary>
		/// Gets or sets the value of NHibernateAssemblyName domain property.
		/// Provides assembly name to be used during code generation. You can provide a
		/// fully qualified assembly name to target a specific version from the GAC.
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.Model/NHibernateAssemblyName.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.Model/NHibernateAssemblyName.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.Model/NHibernateAssemblyName.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[global::System.ComponentModel.DefaultValue("NHibernate")]
		[DslModeling::DomainObjectId("a0bcb53c-a856-4a8d-9245-f973dfb023d3")]
		public global::System.String NHibernateAssemblyName
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return nHibernateAssemblyNamePropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				NHibernateAssemblyNamePropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the Model.NHibernateAssemblyName domain property.
		/// </summary>
		internal sealed partial class NHibernateAssemblyNamePropertyHandler : DslModeling::DomainPropertyValueHandler<Model, global::System.String>
		{
			private NHibernateAssemblyNamePropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the Model.NHibernateAssemblyName domain property value handler.
			/// </summary>
			public static readonly NHibernateAssemblyNamePropertyHandler Instance = new NHibernateAssemblyNamePropertyHandler();
		
			/// <summary>
			/// Gets the Id of the Model.NHibernateAssemblyName domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return NHibernateAssemblyNameDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed global::System.String GetValue(Model element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.nHibernateAssemblyNamePropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(Model element, global::System.String newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				global::System.String oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.nHibernateAssemblyNamePropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region RelateWithActiwFile domain property code
		
		/// <summary>
		/// RelateWithActiwFile domain property Id.
		/// </summary>
		public static readonly global::System.Guid RelateWithActiwFileDomainPropertyId = new global::System.Guid(0x3871c9b7, 0x2f36, 0x4c4e, 0xb9, 0x02, 0xc8, 0x84, 0x8a, 0x28, 0x42, 0xbc);
		
		/// <summary>
		/// Storage for RelateWithActiwFile
		/// </summary>
		private global::System.Boolean relateWithActiwFilePropertyStorage = true;
		
		/// <summary>
		/// Gets or sets the value of RelateWithActiwFile domain property.
		/// Instructs ActiveWriter to add hbm.xml file as a nested file of this .actiw file.
		/// Otherwise, file will be added as a standalone item to the project.
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.Model/RelateWithActiwFile.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.Model/RelateWithActiwFile.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.Model/RelateWithActiwFile.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[global::System.ComponentModel.DefaultValue(true)]
		[DslModeling::DomainObjectId("3871c9b7-2f36-4c4e-b902-c8848a2842bc")]
		public global::System.Boolean RelateWithActiwFile
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return relateWithActiwFilePropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				RelateWithActiwFilePropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the Model.RelateWithActiwFile domain property.
		/// </summary>
		internal sealed partial class RelateWithActiwFilePropertyHandler : DslModeling::DomainPropertyValueHandler<Model, global::System.Boolean>
		{
			private RelateWithActiwFilePropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the Model.RelateWithActiwFile domain property value handler.
			/// </summary>
			public static readonly RelateWithActiwFilePropertyHandler Instance = new RelateWithActiwFilePropertyHandler();
		
			/// <summary>
			/// Gets the Id of the Model.RelateWithActiwFile domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return RelateWithActiwFileDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed global::System.Boolean GetValue(Model element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.relateWithActiwFilePropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(Model element, global::System.Boolean newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				global::System.Boolean oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.relateWithActiwFilePropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region UseVirtualProperties domain property code
		
		/// <summary>
		/// UseVirtualProperties domain property Id.
		/// </summary>
		public static readonly global::System.Guid UseVirtualPropertiesDomainPropertyId = new global::System.Guid(0x652aa8bf, 0x1eb6, 0x47ea, 0x92, 0x8a, 0xc1, 0x4b, 0x6b, 0x95, 0x07, 0x91);
		
		/// <summary>
		/// Storage for UseVirtualProperties
		/// </summary>
		private global::System.Boolean useVirtualPropertiesPropertyStorage = true;
		
		/// <summary>
		/// Gets or sets the value of UseVirtualProperties domain property.
		/// Instructs ActiveWriter to generate virtual properties where possible.
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.Model/UseVirtualProperties.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.Model/UseVirtualProperties.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.Model/UseVirtualProperties.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[global::System.ComponentModel.DefaultValue(true)]
		[DslModeling::DomainObjectId("652aa8bf-1eb6-47ea-928a-c14b6b950791")]
		public global::System.Boolean UseVirtualProperties
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return useVirtualPropertiesPropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				UseVirtualPropertiesPropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the Model.UseVirtualProperties domain property.
		/// </summary>
		internal sealed partial class UseVirtualPropertiesPropertyHandler : DslModeling::DomainPropertyValueHandler<Model, global::System.Boolean>
		{
			private UseVirtualPropertiesPropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the Model.UseVirtualProperties domain property value handler.
			/// </summary>
			public static readonly UseVirtualPropertiesPropertyHandler Instance = new UseVirtualPropertiesPropertyHandler();
		
			/// <summary>
			/// Gets the Id of the Model.UseVirtualProperties domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return UseVirtualPropertiesDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed global::System.Boolean GetValue(Model element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.useVirtualPropertiesPropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(Model element, global::System.Boolean newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				global::System.Boolean oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.useVirtualPropertiesPropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region Namespace domain property code
		
		/// <summary>
		/// Namespace domain property Id.
		/// </summary>
		public static readonly global::System.Guid NamespaceDomainPropertyId = new global::System.Guid(0x88ffcb9e, 0xcd62, 0x45cf, 0x8b, 0x96, 0xfb, 0xff, 0x7f, 0x1e, 0x1c, 0x5f);
		
		/// <summary>
		/// Storage for Namespace
		/// </summary>
		private global::System.String namespacePropertyStorage = string.Empty;
		
		/// <summary>
		/// Gets or sets the value of Namespace domain property.
		/// The namespace to be used in generated code. If not supplied (default),
		/// ActiveWriter will use the namespace from the native project structure.
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.Model/Namespace.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.Model/Namespace.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.Model/Namespace.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslModeling::DomainObjectId("88ffcb9e-cd62-45cf-8b96-fbff7f1e1c5f")]
		public global::System.String Namespace
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return namespacePropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				NamespacePropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the Model.Namespace domain property.
		/// </summary>
		internal sealed partial class NamespacePropertyHandler : DslModeling::DomainPropertyValueHandler<Model, global::System.String>
		{
			private NamespacePropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the Model.Namespace domain property value handler.
			/// </summary>
			public static readonly NamespacePropertyHandler Instance = new NamespacePropertyHandler();
		
			/// <summary>
			/// Gets the Id of the Model.Namespace domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return NamespaceDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed global::System.String GetValue(Model element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.namespacePropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(Model element, global::System.String newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				global::System.String oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.namespacePropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region AdditionalImports domain property code
		
		/// <summary>
		/// AdditionalImports domain property Id.
		/// </summary>
		public static readonly global::System.Guid AdditionalImportsDomainPropertyId = new global::System.Guid(0xb0d78aac, 0xcb2a, 0x483c, 0x93, 0xc9, 0xb6, 0x82, 0x24, 0x3a, 0x33, 0x8c);
		
		/// <summary>
		/// Gets or sets the value of AdditionalImports domain property.
		/// List of additional imports to be added to the generated class.
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.Model/AdditionalImports.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.Model/AdditionalImports.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.Model/AdditionalImports.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslModeling::DomainProperty(Kind = DslModeling::DomainPropertyKind.CustomStorage)]
		[DslModeling::DomainObjectId("b0d78aac-cb2a-483c-93c9-b682243a338c")]
		public global::System.Collections.Generic.List<Castle.ActiveWriter.Import> AdditionalImports
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return AdditionalImportsPropertyHandler.Instance.GetValue(this);
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				AdditionalImportsPropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the Model.AdditionalImports domain property.
		/// </summary>
		internal sealed partial class AdditionalImportsPropertyHandler : DslModeling::DomainPropertyValueHandler<Model, global::System.Collections.Generic.List<Castle.ActiveWriter.Import>>
		{
			private AdditionalImportsPropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the Model.AdditionalImports domain property value handler.
			/// </summary>
			public static readonly AdditionalImportsPropertyHandler Instance = new AdditionalImportsPropertyHandler();
		
			/// <summary>
			/// Gets the Id of the Model.AdditionalImports domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return AdditionalImportsDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed global::System.Collections.Generic.List<Castle.ActiveWriter.Import> GetValue(Model element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				// There is no storage for AdditionalImports because its Kind is
				// set to CustomStorage. Please provide the GetAdditionalImportsValue()
				// method on the domain class.
				return element.GetAdditionalImportsValue();
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(Model element, global::System.Collections.Generic.List<Castle.ActiveWriter.Import> newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				global::System.Collections.Generic.List<Castle.ActiveWriter.Import> oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					// There is no storage for AdditionalImports because its Kind is
					// set to CustomStorage. Please provide the SetAdditionalImportsValue()
					// method on the domain class.
					element.SetAdditionalImportsValue(newValue);
					ValueChanged(element, oldValue, GetValue(element));
				}
			}
		}
		
		#endregion
		#region ImplementINotifyPropertyChanged domain property code
		
		/// <summary>
		/// ImplementINotifyPropertyChanged domain property Id.
		/// </summary>
		public static readonly global::System.Guid ImplementINotifyPropertyChangedDomainPropertyId = new global::System.Guid(0x4b0308e4, 0xc189, 0x4ef5, 0x81, 0x8d, 0x59, 0x03, 0x3d, 0xe5, 0xaa, 0xee);
		
		/// <summary>
		/// Storage for ImplementINotifyPropertyChanged
		/// </summary>
		private global::System.Boolean implementINotifyPropertyChangedPropertyStorage;
		
		/// <summary>
		/// Gets or sets the value of ImplementINotifyPropertyChanged domain property.
		/// Instructs ActiveWriter to implement INotifyPropertyChanged interface in each
		/// class generated. This setting is overridable in class level.
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.Model/ImplementINotifyPropertyChanged.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.Model/ImplementINotifyPropertyChanged.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.Model/ImplementINotifyPropertyChanged.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslModeling::DomainObjectId("4b0308e4-c189-4ef5-818d-59033de5aaee")]
		public global::System.Boolean ImplementINotifyPropertyChanged
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return implementINotifyPropertyChangedPropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				ImplementINotifyPropertyChangedPropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the Model.ImplementINotifyPropertyChanged domain property.
		/// </summary>
		internal sealed partial class ImplementINotifyPropertyChangedPropertyHandler : DslModeling::DomainPropertyValueHandler<Model, global::System.Boolean>
		{
			private ImplementINotifyPropertyChangedPropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the Model.ImplementINotifyPropertyChanged domain property value handler.
			/// </summary>
			public static readonly ImplementINotifyPropertyChangedPropertyHandler Instance = new ImplementINotifyPropertyChangedPropertyHandler();
		
			/// <summary>
			/// Gets the Id of the Model.ImplementINotifyPropertyChanged domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return ImplementINotifyPropertyChangedDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed global::System.Boolean GetValue(Model element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.implementINotifyPropertyChangedPropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(Model element, global::System.Boolean newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				global::System.Boolean oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.implementINotifyPropertyChangedPropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region GenerateMetaData domain property code
		
		/// <summary>
		/// GenerateMetaData domain property Id.
		/// </summary>
		public static readonly global::System.Guid GenerateMetaDataDomainPropertyId = new global::System.Guid(0x8a850d5e, 0xb19c, 0x4327, 0xb1, 0x9f, 0x09, 0xd9, 0x9e, 0x97, 0x6d, 0xb5);
		
		/// <summary>
		/// Storage for GenerateMetaData
		/// </summary>
		private MetaDataGeneration generateMetaDataPropertyStorage = MetaDataGeneration.False;
		
		/// <summary>
		/// Gets or sets the value of GenerateMetaData domain property.
		/// Instructs ActiveWriter to generate property metadata to allow typed access to
		/// property names.
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.Model/GenerateMetaData.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.Model/GenerateMetaData.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.Model/GenerateMetaData.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[global::System.ComponentModel.DefaultValue(MetaDataGeneration.False)]
		[DslModeling::DomainObjectId("8a850d5e-b19c-4327-b19f-09d99e976db5")]
		public MetaDataGeneration GenerateMetaData
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return generateMetaDataPropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				GenerateMetaDataPropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the Model.GenerateMetaData domain property.
		/// </summary>
		internal sealed partial class GenerateMetaDataPropertyHandler : DslModeling::DomainPropertyValueHandler<Model, MetaDataGeneration>
		{
			private GenerateMetaDataPropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the Model.GenerateMetaData domain property value handler.
			/// </summary>
			public static readonly GenerateMetaDataPropertyHandler Instance = new GenerateMetaDataPropertyHandler();
		
			/// <summary>
			/// Gets the Id of the Model.GenerateMetaData domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return GenerateMetaDataDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed MetaDataGeneration GetValue(Model element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.generateMetaDataPropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(Model element, MetaDataGeneration newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				MetaDataGeneration oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.generateMetaDataPropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region UseNHQG domain property code
		
		/// <summary>
		/// UseNHQG domain property Id.
		/// </summary>
		public static readonly global::System.Guid UseNHQGDomainPropertyId = new global::System.Guid(0x7d2151aa, 0x6ddb, 0x489c, 0x90, 0xdb, 0x4f, 0xcd, 0x35, 0x4c, 0x43, 0xb7);
		
		/// <summary>
		/// Storage for UseNHQG
		/// </summary>
		private global::System.Boolean useNHQGPropertyStorage;
		
		/// <summary>
		/// Gets or sets the value of UseNHQG domain property.
		/// Instructs ActiveWriter to post process generated code with NHibernate Query
		/// Generator to generate helper Criteria API constructs. For more information on
		/// NHQG, visit http://www.ayende.com
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.Model/UseNHQG.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.Model/UseNHQG.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.Model/UseNHQG.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslModeling::DomainObjectId("7d2151aa-6ddb-489c-90db-4fcd354c43b7")]
		public global::System.Boolean UseNHQG
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return useNHQGPropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				UseNHQGPropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the Model.UseNHQG domain property.
		/// </summary>
		internal sealed partial class UseNHQGPropertyHandler : DslModeling::DomainPropertyValueHandler<Model, global::System.Boolean>
		{
			private UseNHQGPropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the Model.UseNHQG domain property value handler.
			/// </summary>
			public static readonly UseNHQGPropertyHandler Instance = new UseNHQGPropertyHandler();
		
			/// <summary>
			/// Gets the Id of the Model.UseNHQG domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return UseNHQGDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed global::System.Boolean GetValue(Model element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.useNHQGPropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(Model element, global::System.Boolean newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				global::System.Boolean oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.useNHQGPropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region NHQGExecutable domain property code
		
		/// <summary>
		/// NHQGExecutable domain property Id.
		/// </summary>
		public static readonly global::System.Guid NHQGExecutableDomainPropertyId = new global::System.Guid(0x428db86d, 0x0643, 0x4830, 0xa8, 0x41, 0x6b, 0x56, 0x83, 0x0c, 0x73, 0x5b);
		
		/// <summary>
		/// Storage for NHQGExecutable
		/// </summary>
		private global::System.String nHQGExecutablePropertyStorage = "C:\\Program Files\\Rhino\\NHibernate Query Generator\\NHQG.exe";
		
		/// <summary>
		/// Gets or sets the value of NHQGExecutable domain property.
		/// Executable path for NHQG.exe
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.Model/NHQGExecutable.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.Model/NHQGExecutable.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.Model/NHQGExecutable.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[global::System.ComponentModel.DefaultValue("C:\\Program Files\\Rhino\\NHibernate Query Generator\\NHQG.exe")]
		[DslModeling::DomainObjectId("428db86d-0643-4830-a841-6b56830c735b")]
		public global::System.String NHQGExecutable
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return nHQGExecutablePropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				NHQGExecutablePropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the Model.NHQGExecutable domain property.
		/// </summary>
		internal sealed partial class NHQGExecutablePropertyHandler : DslModeling::DomainPropertyValueHandler<Model, global::System.String>
		{
			private NHQGExecutablePropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the Model.NHQGExecutable domain property value handler.
			/// </summary>
			public static readonly NHQGExecutablePropertyHandler Instance = new NHQGExecutablePropertyHandler();
		
			/// <summary>
			/// Gets the Id of the Model.NHQGExecutable domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return NHQGExecutableDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed global::System.String GetValue(Model element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.nHQGExecutablePropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(Model element, global::System.String newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				global::System.String oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.nHQGExecutablePropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region UseGenericRelations domain property code
		
		/// <summary>
		/// UseGenericRelations domain property Id.
		/// </summary>
		public static readonly global::System.Guid UseGenericRelationsDomainPropertyId = new global::System.Guid(0x2023d3af, 0xc8cd, 0x4ae7, 0x80, 0x68, 0x93, 0xd6, 0x99, 0x43, 0xa6, 0xdf);
		
		/// <summary>
		/// Storage for UseGenericRelations
		/// </summary>
		private global::System.Boolean useGenericRelationsPropertyStorage = true;
		
		/// <summary>
		/// Gets or sets the value of UseGenericRelations domain property.
		/// Instructs ActiveWriter to generate code using generic collections for class
		/// relations where possible. This setting is overridable in class level.
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.Model/UseGenericRelations.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.Model/UseGenericRelations.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.Model/UseGenericRelations.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[global::System.ComponentModel.DefaultValue(true)]
		[DslModeling::DomainObjectId("2023d3af-c8cd-4ae7-8068-93d69943a6df")]
		public global::System.Boolean UseGenericRelations
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return useGenericRelationsPropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				UseGenericRelationsPropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the Model.UseGenericRelations domain property.
		/// </summary>
		internal sealed partial class UseGenericRelationsPropertyHandler : DslModeling::DomainPropertyValueHandler<Model, global::System.Boolean>
		{
			private UseGenericRelationsPropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the Model.UseGenericRelations domain property value handler.
			/// </summary>
			public static readonly UseGenericRelationsPropertyHandler Instance = new UseGenericRelationsPropertyHandler();
		
			/// <summary>
			/// Gets the Id of the Model.UseGenericRelations domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return UseGenericRelationsDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed global::System.Boolean GetValue(Model element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.useGenericRelationsPropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(Model element, global::System.Boolean newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				global::System.Boolean oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.useGenericRelationsPropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region PropertyNameFilterExpression domain property code
		
		/// <summary>
		/// PropertyNameFilterExpression domain property Id.
		/// </summary>
		public static readonly global::System.Guid PropertyNameFilterExpressionDomainPropertyId = new global::System.Guid(0x04d53b21, 0x4bae, 0x48c7, 0x89, 0xa7, 0x82, 0xc4, 0xc5, 0xe7, 0x21, 0x5b);
		
		/// <summary>
		/// Storage for PropertyNameFilterExpression
		/// </summary>
		private global::System.String propertyNameFilterExpressionPropertyStorage = string.Empty;
		
		/// <summary>
		/// Gets or sets the value of PropertyNameFilterExpression domain property.
		/// A regular expression to apply to all property names. MAtches will bereplaced
		/// with empty strings.
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.Model/PropertyNameFilterExpression.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.Model/PropertyNameFilterExpression.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.Model/PropertyNameFilterExpression.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslModeling::DomainObjectId("04d53b21-4bae-48c7-89a7-82c4c5e7215b")]
		public global::System.String PropertyNameFilterExpression
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return propertyNameFilterExpressionPropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				PropertyNameFilterExpressionPropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the Model.PropertyNameFilterExpression domain property.
		/// </summary>
		internal sealed partial class PropertyNameFilterExpressionPropertyHandler : DslModeling::DomainPropertyValueHandler<Model, global::System.String>
		{
			private PropertyNameFilterExpressionPropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the Model.PropertyNameFilterExpression domain property value handler.
			/// </summary>
			public static readonly PropertyNameFilterExpressionPropertyHandler Instance = new PropertyNameFilterExpressionPropertyHandler();
		
			/// <summary>
			/// Gets the Id of the Model.PropertyNameFilterExpression domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return PropertyNameFilterExpressionDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed global::System.String GetValue(Model element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.propertyNameFilterExpressionPropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(Model element, global::System.String newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				global::System.String oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.propertyNameFilterExpressionPropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region InitializeIListFields domain property code
		
		/// <summary>
		/// InitializeIListFields domain property Id.
		/// </summary>
		public static readonly global::System.Guid InitializeIListFieldsDomainPropertyId = new global::System.Guid(0x951613a5, 0x1988, 0x44fb, 0xa3, 0xa1, 0xb0, 0xfc, 0xd0, 0x38, 0x8b, 0x9e);
		
		/// <summary>
		/// Storage for InitializeIListFields
		/// </summary>
		private global::System.Boolean initializeIListFieldsPropertyStorage;
		
		/// <summary>
		/// Gets or sets the value of InitializeIListFields domain property.
		/// Initializas private IList fields with List concrete type.
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.Model/InitializeIListFields.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.Model/InitializeIListFields.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.Model/InitializeIListFields.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslModeling::DomainObjectId("951613a5-1988-44fb-a3a1-b0fcd0388b9e")]
		public global::System.Boolean InitializeIListFields
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return initializeIListFieldsPropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				InitializeIListFieldsPropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the Model.InitializeIListFields domain property.
		/// </summary>
		internal sealed partial class InitializeIListFieldsPropertyHandler : DslModeling::DomainPropertyValueHandler<Model, global::System.Boolean>
		{
			private InitializeIListFieldsPropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the Model.InitializeIListFields domain property value handler.
			/// </summary>
			public static readonly InitializeIListFieldsPropertyHandler Instance = new InitializeIListFieldsPropertyHandler();
		
			/// <summary>
			/// Gets the Id of the Model.InitializeIListFields domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return InitializeIListFieldsDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed global::System.Boolean GetValue(Model element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.initializeIListFieldsPropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(Model element, global::System.Boolean newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				global::System.Boolean oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.initializeIListFieldsPropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region ImplementINotifyPropertyChanging domain property code
		
		/// <summary>
		/// ImplementINotifyPropertyChanging domain property Id.
		/// </summary>
		public static readonly global::System.Guid ImplementINotifyPropertyChangingDomainPropertyId = new global::System.Guid(0x2992d717, 0xbd8a, 0x42a9, 0xa4, 0x54, 0xf5, 0xd9, 0xed, 0x76, 0x7e, 0x00);
		
		/// <summary>
		/// Storage for ImplementINotifyPropertyChanging
		/// </summary>
		private global::System.Boolean implementINotifyPropertyChangingPropertyStorage;
		
		/// <summary>
		/// Gets or sets the value of ImplementINotifyPropertyChanging domain property.
		/// Instructs ActiveWriter to implement INotifyPropertyChanging interface in each
		/// class generated. This setting is overridable in class level.
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.Model/ImplementINotifyPropertyChanging.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.Model/ImplementINotifyPropertyChanging.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.Model/ImplementINotifyPropertyChanging.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslModeling::DomainObjectId("2992d717-bd8a-42a9-a454-f5d9ed767e00")]
		public global::System.Boolean ImplementINotifyPropertyChanging
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return implementINotifyPropertyChangingPropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				ImplementINotifyPropertyChangingPropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the Model.ImplementINotifyPropertyChanging domain property.
		/// </summary>
		internal sealed partial class ImplementINotifyPropertyChangingPropertyHandler : DslModeling::DomainPropertyValueHandler<Model, global::System.Boolean>
		{
			private ImplementINotifyPropertyChangingPropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the Model.ImplementINotifyPropertyChanging domain property value handler.
			/// </summary>
			public static readonly ImplementINotifyPropertyChangingPropertyHandler Instance = new ImplementINotifyPropertyChangingPropertyHandler();
		
			/// <summary>
			/// Gets the Id of the Model.ImplementINotifyPropertyChanging domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return ImplementINotifyPropertyChangingDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed global::System.Boolean GetValue(Model element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.implementINotifyPropertyChangingPropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(Model element, global::System.Boolean newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				global::System.Boolean oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.implementINotifyPropertyChangingPropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region CollectionInterface domain property code
		
		/// <summary>
		/// CollectionInterface domain property Id.
		/// </summary>
		public static readonly global::System.Guid CollectionInterfaceDomainPropertyId = new global::System.Guid(0x207c0c14, 0x8ed8, 0x41ad, 0xbd, 0x61, 0xf3, 0xdf, 0xd3, 0x75, 0x7d, 0x2b);
		
		/// <summary>
		/// Storage for CollectionInterface
		/// </summary>
		private global::System.String collectionInterfacePropertyStorage = "IList";
		
		/// <summary>
		/// Gets or sets the value of CollectionInterface domain property.
		/// Interface to use for collections.  If none is specified, IList will be used.
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.Model/CollectionInterface.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.Model/CollectionInterface.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.Model/CollectionInterface.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[global::System.ComponentModel.DefaultValue("IList")]
		[DslModeling::DomainObjectId("207c0c14-8ed8-41ad-bd61-f3dfd3757d2b")]
		public global::System.String CollectionInterface
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return collectionInterfacePropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				CollectionInterfacePropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the Model.CollectionInterface domain property.
		/// </summary>
		internal sealed partial class CollectionInterfacePropertyHandler : DslModeling::DomainPropertyValueHandler<Model, global::System.String>
		{
			private CollectionInterfacePropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the Model.CollectionInterface domain property value handler.
			/// </summary>
			public static readonly CollectionInterfacePropertyHandler Instance = new CollectionInterfacePropertyHandler();
		
			/// <summary>
			/// Gets the Id of the Model.CollectionInterface domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return CollectionInterfaceDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed global::System.String GetValue(Model element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.collectionInterfacePropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(Model element, global::System.String newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				global::System.String oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.collectionInterfacePropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region CollectionImplementation domain property code
		
		/// <summary>
		/// CollectionImplementation domain property Id.
		/// </summary>
		public static readonly global::System.Guid CollectionImplementationDomainPropertyId = new global::System.Guid(0xc5f8cef8, 0xaab9, 0x4666, 0xbc, 0xa7, 0x96, 0x11, 0x79, 0x63, 0x41, 0x66);
		
		/// <summary>
		/// Storage for CollectionImplementation
		/// </summary>
		private global::System.String collectionImplementationPropertyStorage = "List";
		
		/// <summary>
		/// Gets or sets the value of CollectionImplementation domain property.
		/// Concrete class to instantiate for list fields if InitializeIListFields is set to
		/// true.
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.Model/CollectionImplementation.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.Model/CollectionImplementation.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.Model/CollectionImplementation.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[global::System.ComponentModel.DefaultValue("List")]
		[DslModeling::DomainObjectId("c5f8cef8-aab9-4666-bca7-961179634166")]
		public global::System.String CollectionImplementation
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return collectionImplementationPropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				CollectionImplementationPropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the Model.CollectionImplementation domain property.
		/// </summary>
		internal sealed partial class CollectionImplementationPropertyHandler : DslModeling::DomainPropertyValueHandler<Model, global::System.String>
		{
			private CollectionImplementationPropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the Model.CollectionImplementation domain property value handler.
			/// </summary>
			public static readonly CollectionImplementationPropertyHandler Instance = new CollectionImplementationPropertyHandler();
		
			/// <summary>
			/// Gets the Id of the Model.CollectionImplementation domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return CollectionImplementationDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed global::System.String GetValue(Model element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.collectionImplementationPropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(Model element, global::System.String newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				global::System.String oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.collectionImplementationPropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region ManyToManyRelationType domain property code
		
		/// <summary>
		/// ManyToManyRelationType domain property Id.
		/// </summary>
		public static readonly global::System.Guid ManyToManyRelationTypeDomainPropertyId = new global::System.Guid(0x405105d2, 0x70b1, 0x42e5, 0xb4, 0x36, 0x4b, 0x17, 0xa4, 0xf0, 0x2f, 0x63);
		
		/// <summary>
		/// Storage for ManyToManyRelationType
		/// </summary>
		private RelationType manyToManyRelationTypePropertyStorage = RelationType.Guess;
		
		/// <summary>
		/// Gets or sets the value of ManyToManyRelationType domain property.
		/// Default relation type used by ManyToMany relationships.
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.Model/ManyToManyRelationType.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.Model/ManyToManyRelationType.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.Model/ManyToManyRelationType.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[global::System.ComponentModel.DefaultValue(RelationType.Guess)]
		[DslModeling::DomainObjectId("405105d2-70b1-42e5-b436-4b17a4f02f63")]
		public RelationType ManyToManyRelationType
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return manyToManyRelationTypePropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				ManyToManyRelationTypePropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the Model.ManyToManyRelationType domain property.
		/// </summary>
		internal sealed partial class ManyToManyRelationTypePropertyHandler : DslModeling::DomainPropertyValueHandler<Model, RelationType>
		{
			private ManyToManyRelationTypePropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the Model.ManyToManyRelationType domain property value handler.
			/// </summary>
			public static readonly ManyToManyRelationTypePropertyHandler Instance = new ManyToManyRelationTypePropertyHandler();
		
			/// <summary>
			/// Gets the Id of the Model.ManyToManyRelationType domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return ManyToManyRelationTypeDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed RelationType GetValue(Model element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.manyToManyRelationTypePropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(Model element, RelationType newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				RelationType oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.manyToManyRelationTypePropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region ManyToOneRelationType domain property code
		
		/// <summary>
		/// ManyToOneRelationType domain property Id.
		/// </summary>
		public static readonly global::System.Guid ManyToOneRelationTypeDomainPropertyId = new global::System.Guid(0xf0ea48f0, 0xb5a9, 0x4d88, 0x8f, 0x43, 0xa8, 0xb9, 0xcb, 0x98, 0xb4, 0x1a);
		
		/// <summary>
		/// Storage for ManyToOneRelationType
		/// </summary>
		private RelationType manyToOneRelationTypePropertyStorage = RelationType.Guess;
		
		/// <summary>
		/// Gets or sets the value of ManyToOneRelationType domain property.
		/// Default relation type used by ManyToOne relationships.
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.Model/ManyToOneRelationType.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.Model/ManyToOneRelationType.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.Model/ManyToOneRelationType.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[global::System.ComponentModel.DefaultValue(RelationType.Guess)]
		[DslModeling::DomainObjectId("f0ea48f0-b5a9-4d88-8f43-a8b9cb98b41a")]
		public RelationType ManyToOneRelationType
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return manyToOneRelationTypePropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				ManyToOneRelationTypePropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the Model.ManyToOneRelationType domain property.
		/// </summary>
		internal sealed partial class ManyToOneRelationTypePropertyHandler : DslModeling::DomainPropertyValueHandler<Model, RelationType>
		{
			private ManyToOneRelationTypePropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the Model.ManyToOneRelationType domain property value handler.
			/// </summary>
			public static readonly ManyToOneRelationTypePropertyHandler Instance = new ManyToOneRelationTypePropertyHandler();
		
			/// <summary>
			/// Gets the Id of the Model.ManyToOneRelationType domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return ManyToOneRelationTypeDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed RelationType GetValue(Model element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.manyToOneRelationTypePropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(Model element, RelationType newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				RelationType oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.manyToOneRelationTypePropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region ManyToManyCollectionIDColumnFormat domain property code
		
		/// <summary>
		/// ManyToManyCollectionIDColumnFormat domain property Id.
		/// </summary>
		public static readonly global::System.Guid ManyToManyCollectionIDColumnFormatDomainPropertyId = new global::System.Guid(0x4e0c0023, 0x6a86, 0x4801, 0xbb, 0x51, 0x9e, 0xbb, 0xad, 0x2a, 0x1f, 0xd6);
		
		/// <summary>
		/// Storage for ManyToManyCollectionIDColumnFormat
		/// </summary>
		private global::System.String manyToManyCollectionIDColumnFormatPropertyStorage = string.Empty;
		
		/// <summary>
		/// Gets or sets the value of ManyToManyCollectionIDColumnFormat domain property.
		/// This column name is used for many to many collection ID definition.  If a column
		/// name is specified in the relationship itself, the Column Type and Generator
		/// specified in the relationship will be used instead of those specified here in
		/// the model.  Any {0} specified in the format will be replaced with the table name
		/// in the same way as Common Primary Key Format.  If no format is specified here or
		/// in the many to many relationships, the generation system will fall back to the
		/// Common Primary Key information.
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.Model/ManyToManyCollectionIDColumnFormat.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.Model/ManyToManyCollectionIDColumnFormat.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.Model/ManyToManyCollectionIDColumnFormat.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslModeling::DomainObjectId("4e0c0023-6a86-4801-bb51-9ebbad2a1fd6")]
		public global::System.String ManyToManyCollectionIDColumnFormat
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return manyToManyCollectionIDColumnFormatPropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				ManyToManyCollectionIDColumnFormatPropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the Model.ManyToManyCollectionIDColumnFormat domain property.
		/// </summary>
		internal sealed partial class ManyToManyCollectionIDColumnFormatPropertyHandler : DslModeling::DomainPropertyValueHandler<Model, global::System.String>
		{
			private ManyToManyCollectionIDColumnFormatPropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the Model.ManyToManyCollectionIDColumnFormat domain property value handler.
			/// </summary>
			public static readonly ManyToManyCollectionIDColumnFormatPropertyHandler Instance = new ManyToManyCollectionIDColumnFormatPropertyHandler();
		
			/// <summary>
			/// Gets the Id of the Model.ManyToManyCollectionIDColumnFormat domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return ManyToManyCollectionIDColumnFormatDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed global::System.String GetValue(Model element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.manyToManyCollectionIDColumnFormatPropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(Model element, global::System.String newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				global::System.String oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.manyToManyCollectionIDColumnFormatPropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region ManyToManyCollectionIDColumnType domain property code
		
		/// <summary>
		/// ManyToManyCollectionIDColumnType domain property Id.
		/// </summary>
		public static readonly global::System.Guid ManyToManyCollectionIDColumnTypeDomainPropertyId = new global::System.Guid(0xf01307ce, 0x7d91, 0x4b00, 0xb3, 0x52, 0xfe, 0x54, 0x87, 0x58, 0x76, 0x33);
		
		/// <summary>
		/// Storage for ManyToManyCollectionIDColumnType
		/// </summary>
		private NHibernateType manyToManyCollectionIDColumnTypePropertyStorage;
		
		/// <summary>
		/// Gets or sets the value of ManyToManyCollectionIDColumnType domain property.
		/// Description for Castle.ActiveWriter.Model.Many To Many Collection ID Column Type
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.Model/ManyToManyCollectionIDColumnType.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.Model/ManyToManyCollectionIDColumnType.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.Model/ManyToManyCollectionIDColumnType.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslModeling::DomainObjectId("f01307ce-7d91-4b00-b352-fe5487587633")]
		public NHibernateType ManyToManyCollectionIDColumnType
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return manyToManyCollectionIDColumnTypePropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				ManyToManyCollectionIDColumnTypePropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the Model.ManyToManyCollectionIDColumnType domain property.
		/// </summary>
		internal sealed partial class ManyToManyCollectionIDColumnTypePropertyHandler : DslModeling::DomainPropertyValueHandler<Model, NHibernateType>
		{
			private ManyToManyCollectionIDColumnTypePropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the Model.ManyToManyCollectionIDColumnType domain property value handler.
			/// </summary>
			public static readonly ManyToManyCollectionIDColumnTypePropertyHandler Instance = new ManyToManyCollectionIDColumnTypePropertyHandler();
		
			/// <summary>
			/// Gets the Id of the Model.ManyToManyCollectionIDColumnType domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return ManyToManyCollectionIDColumnTypeDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed NHibernateType GetValue(Model element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.manyToManyCollectionIDColumnTypePropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(Model element, NHibernateType newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				NHibernateType oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.manyToManyCollectionIDColumnTypePropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region ManyToManyCollectionIDGenerator domain property code
		
		/// <summary>
		/// ManyToManyCollectionIDGenerator domain property Id.
		/// </summary>
		public static readonly global::System.Guid ManyToManyCollectionIDGeneratorDomainPropertyId = new global::System.Guid(0x7b97e93e, 0xea00, 0x4884, 0xa2, 0xbd, 0xf7, 0xe1, 0x46, 0xd8, 0x84, 0x1c);
		
		/// <summary>
		/// Storage for ManyToManyCollectionIDGenerator
		/// </summary>
		private PrimaryKeyType manyToManyCollectionIDGeneratorPropertyStorage;
		
		/// <summary>
		/// Gets or sets the value of ManyToManyCollectionIDGenerator domain property.
		/// Description for Castle.ActiveWriter.Model.Many To Many Collection ID Generator
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.Model/ManyToManyCollectionIDGenerator.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.Model/ManyToManyCollectionIDGenerator.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.Model/ManyToManyCollectionIDGenerator.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslModeling::DomainObjectId("7b97e93e-ea00-4884-a2bd-f7e146d8841c")]
		public PrimaryKeyType ManyToManyCollectionIDGenerator
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return manyToManyCollectionIDGeneratorPropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				ManyToManyCollectionIDGeneratorPropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the Model.ManyToManyCollectionIDGenerator domain property.
		/// </summary>
		internal sealed partial class ManyToManyCollectionIDGeneratorPropertyHandler : DslModeling::DomainPropertyValueHandler<Model, PrimaryKeyType>
		{
			private ManyToManyCollectionIDGeneratorPropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the Model.ManyToManyCollectionIDGenerator domain property value handler.
			/// </summary>
			public static readonly ManyToManyCollectionIDGeneratorPropertyHandler Instance = new ManyToManyCollectionIDGeneratorPropertyHandler();
		
			/// <summary>
			/// Gets the Id of the Model.ManyToManyCollectionIDGenerator domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return ManyToManyCollectionIDGeneratorDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed PrimaryKeyType GetValue(Model element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.manyToManyCollectionIDGeneratorPropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(Model element, PrimaryKeyType newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				PrimaryKeyType oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.manyToManyCollectionIDGeneratorPropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region ManyToManyIUserCollectionType domain property code
		
		/// <summary>
		/// ManyToManyIUserCollectionType domain property Id.
		/// </summary>
		public static readonly global::System.Guid ManyToManyIUserCollectionTypeDomainPropertyId = new global::System.Guid(0xfd0e9afd, 0xc093, 0x4941, 0xa9, 0xe0, 0xb1, 0xdf, 0x7c, 0x8a, 0xb7, 0xb0);
		
		/// <summary>
		/// Storage for ManyToManyIUserCollectionType
		/// </summary>
		private global::System.String manyToManyIUserCollectionTypePropertyStorage = string.Empty;
		
		/// <summary>
		/// Gets or sets the value of ManyToManyIUserCollectionType domain property.
		/// The type deriving from NHibernate.UserTypes.IUserCollectionType for collections.
		///  This is used unless the collection type is specified in the ManyToMany
		/// relationship.
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.Model/ManyToManyIUserCollectionType.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.Model/ManyToManyIUserCollectionType.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.Model/ManyToManyIUserCollectionType.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslModeling::DomainObjectId("fd0e9afd-c093-4941-a9e0-b1df7c8ab7b0")]
		public global::System.String ManyToManyIUserCollectionType
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return manyToManyIUserCollectionTypePropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				ManyToManyIUserCollectionTypePropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the Model.ManyToManyIUserCollectionType domain property.
		/// </summary>
		internal sealed partial class ManyToManyIUserCollectionTypePropertyHandler : DslModeling::DomainPropertyValueHandler<Model, global::System.String>
		{
			private ManyToManyIUserCollectionTypePropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the Model.ManyToManyIUserCollectionType domain property value handler.
			/// </summary>
			public static readonly ManyToManyIUserCollectionTypePropertyHandler Instance = new ManyToManyIUserCollectionTypePropertyHandler();
		
			/// <summary>
			/// Gets the Id of the Model.ManyToManyIUserCollectionType domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return ManyToManyIUserCollectionTypeDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed global::System.String GetValue(Model element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.manyToManyIUserCollectionTypePropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(Model element, global::System.String newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				global::System.String oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.manyToManyIUserCollectionTypePropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region ManyToOneIUserCollectionType domain property code
		
		/// <summary>
		/// ManyToOneIUserCollectionType domain property Id.
		/// </summary>
		public static readonly global::System.Guid ManyToOneIUserCollectionTypeDomainPropertyId = new global::System.Guid(0x85c3b996, 0x122e, 0x40fa, 0x94, 0x38, 0x70, 0xb5, 0x0f, 0xcd, 0x36, 0x3f);
		
		/// <summary>
		/// Storage for ManyToOneIUserCollectionType
		/// </summary>
		private global::System.String manyToOneIUserCollectionTypePropertyStorage = string.Empty;
		
		/// <summary>
		/// Gets or sets the value of ManyToOneIUserCollectionType domain property.
		/// The type deriving from NHibernate.UserTypes.IUserCollectionType for collections.
		///  This is used unless the collection type is specified in the ManyToOne
		/// relationship.
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.Model/ManyToOneIUserCollectionType.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.Model/ManyToOneIUserCollectionType.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.Model/ManyToOneIUserCollectionType.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslModeling::DomainObjectId("85c3b996-122e-40fa-9438-70b50fcd363f")]
		public global::System.String ManyToOneIUserCollectionType
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return manyToOneIUserCollectionTypePropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				ManyToOneIUserCollectionTypePropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the Model.ManyToOneIUserCollectionType domain property.
		/// </summary>
		internal sealed partial class ManyToOneIUserCollectionTypePropertyHandler : DslModeling::DomainPropertyValueHandler<Model, global::System.String>
		{
			private ManyToOneIUserCollectionTypePropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the Model.ManyToOneIUserCollectionType domain property value handler.
			/// </summary>
			public static readonly ManyToOneIUserCollectionTypePropertyHandler Instance = new ManyToOneIUserCollectionTypePropertyHandler();
		
			/// <summary>
			/// Gets the Id of the Model.ManyToOneIUserCollectionType domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return ManyToOneIUserCollectionTypeDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed global::System.String GetValue(Model element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.manyToOneIUserCollectionTypePropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(Model element, global::System.String newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				global::System.String oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.manyToOneIUserCollectionTypePropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region AutomaticAssociations domain property code
		
		/// <summary>
		/// AutomaticAssociations domain property Id.
		/// </summary>
		public static readonly global::System.Guid AutomaticAssociationsDomainPropertyId = new global::System.Guid(0x03de83cf, 0x2e0e, 0x4b06, 0x99, 0x75, 0xd4, 0xe4, 0x43, 0xf6, 0x88, 0x36);
		
		/// <summary>
		/// Storage for AutomaticAssociations
		/// </summary>
		private global::System.Boolean automaticAssociationsPropertyStorage;
		
		/// <summary>
		/// Gets or sets the value of AutomaticAssociations domain property.
		/// Description for Castle.ActiveWriter.Model.Automatic Associations
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.Model/AutomaticAssociations.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.Model/AutomaticAssociations.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.Model/AutomaticAssociations.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslModeling::DomainObjectId("03de83cf-2e0e-4b06-9975-d4e443f68836")]
		public global::System.Boolean AutomaticAssociations
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return automaticAssociationsPropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				AutomaticAssociationsPropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the Model.AutomaticAssociations domain property.
		/// </summary>
		internal sealed partial class AutomaticAssociationsPropertyHandler : DslModeling::DomainPropertyValueHandler<Model, global::System.Boolean>
		{
			private AutomaticAssociationsPropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the Model.AutomaticAssociations domain property value handler.
			/// </summary>
			public static readonly AutomaticAssociationsPropertyHandler Instance = new AutomaticAssociationsPropertyHandler();
		
			/// <summary>
			/// Gets the Id of the Model.AutomaticAssociations domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return AutomaticAssociationsDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed global::System.Boolean GetValue(Model element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.automaticAssociationsPropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(Model element, global::System.Boolean newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				global::System.Boolean oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.automaticAssociationsPropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region AutomaticAssociationCollectionImplementation domain property code
		
		/// <summary>
		/// AutomaticAssociationCollectionImplementation domain property Id.
		/// </summary>
		public static readonly global::System.Guid AutomaticAssociationCollectionImplementationDomainPropertyId = new global::System.Guid(0x71b0b47d, 0x7c3e, 0x429d, 0xa5, 0x01, 0x1a, 0x91, 0x47, 0x0e, 0x92, 0xaa);
		
		/// <summary>
		/// Storage for AutomaticAssociationCollectionImplementation
		/// </summary>
		private global::System.String automaticAssociationCollectionImplementationPropertyStorage = string.Empty;
		
		/// <summary>
		/// Gets or sets the value of AutomaticAssociationCollectionImplementation domain property.
		/// Description for Castle.ActiveWriter.Model.Automatic Association Collection
		/// Implementation
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.Model/AutomaticAssociationCollectionImplementation.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.Model/AutomaticAssociationCollectionImplementation.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.Model/AutomaticAssociationCollectionImplementation.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslModeling::DomainObjectId("71b0b47d-7c3e-429d-a501-1a91470e92aa")]
		public global::System.String AutomaticAssociationCollectionImplementation
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return automaticAssociationCollectionImplementationPropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				AutomaticAssociationCollectionImplementationPropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the Model.AutomaticAssociationCollectionImplementation domain property.
		/// </summary>
		internal sealed partial class AutomaticAssociationCollectionImplementationPropertyHandler : DslModeling::DomainPropertyValueHandler<Model, global::System.String>
		{
			private AutomaticAssociationCollectionImplementationPropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the Model.AutomaticAssociationCollectionImplementation domain property value handler.
			/// </summary>
			public static readonly AutomaticAssociationCollectionImplementationPropertyHandler Instance = new AutomaticAssociationCollectionImplementationPropertyHandler();
		
			/// <summary>
			/// Gets the Id of the Model.AutomaticAssociationCollectionImplementation domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return AutomaticAssociationCollectionImplementationDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed global::System.String GetValue(Model element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.automaticAssociationCollectionImplementationPropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(Model element, global::System.String newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				global::System.String oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.automaticAssociationCollectionImplementationPropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region ManyToManyTableFormat domain property code
		
		/// <summary>
		/// ManyToManyTableFormat domain property Id.
		/// </summary>
		public static readonly global::System.Guid ManyToManyTableFormatDomainPropertyId = new global::System.Guid(0x602c1f33, 0x5502, 0x484a, 0xbd, 0xb6, 0x08, 0x5f, 0x8d, 0xce, 0x0f, 0xca);
		
		/// <summary>
		/// Storage for ManyToManyTableFormat
		/// </summary>
		private global::System.String manyToManyTableFormatPropertyStorage = "{0}{1}";
		
		/// <summary>
		/// Gets or sets the value of ManyToManyTableFormat domain property.
		/// The format used by default for many-to-many table names.  {0} is replaced by the
		/// source class name and {1} is replaced by the target class name.
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.Model/ManyToManyTableFormat.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.Model/ManyToManyTableFormat.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[global::System.ComponentModel.DefaultValue("{0}{1}")]
		[DslModeling::DomainObjectId("602c1f33-5502-484a-bdb6-085f8dce0fca")]
		public global::System.String ManyToManyTableFormat
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return manyToManyTableFormatPropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				ManyToManyTableFormatPropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the Model.ManyToManyTableFormat domain property.
		/// </summary>
		internal sealed partial class ManyToManyTableFormatPropertyHandler : DslModeling::DomainPropertyValueHandler<Model, global::System.String>
		{
			private ManyToManyTableFormatPropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the Model.ManyToManyTableFormat domain property value handler.
			/// </summary>
			public static readonly ManyToManyTableFormatPropertyHandler Instance = new ManyToManyTableFormatPropertyHandler();
		
			/// <summary>
			/// Gets the Id of the Model.ManyToManyTableFormat domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return ManyToManyTableFormatDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed global::System.String GetValue(Model element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.manyToManyTableFormatPropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(Model element, global::System.String newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				global::System.String oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.manyToManyTableFormatPropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region ForeignKeyFormat domain property code
		
		/// <summary>
		/// ForeignKeyFormat domain property Id.
		/// </summary>
		public static readonly global::System.Guid ForeignKeyFormatDomainPropertyId = new global::System.Guid(0x9e0e8e58, 0x715a, 0x4131, 0x9f, 0x66, 0xfd, 0xb1, 0x50, 0x21, 0x0c, 0x85);
		
		/// <summary>
		/// Storage for ForeignKeyFormat
		/// </summary>
		private global::System.String foreignKeyFormatPropertyStorage = "{0}";
		
		/// <summary>
		/// Gets or sets the value of ForeignKeyFormat domain property.
		/// The format string used by default for foreign key relationships.  {0} is
		/// replaced with the property or class name.  A common format string might be:
		/// {0}_ID
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.Model/ForeignKeyFormat.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.Model/ForeignKeyFormat.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[global::System.ComponentModel.DefaultValue("{0}")]
		[DslModeling::DomainObjectId("9e0e8e58-715a-4131-9f66-fdb150210c85")]
		public global::System.String ForeignKeyFormat
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return foreignKeyFormatPropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				ForeignKeyFormatPropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the Model.ForeignKeyFormat domain property.
		/// </summary>
		internal sealed partial class ForeignKeyFormatPropertyHandler : DslModeling::DomainPropertyValueHandler<Model, global::System.String>
		{
			private ForeignKeyFormatPropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the Model.ForeignKeyFormat domain property value handler.
			/// </summary>
			public static readonly ForeignKeyFormatPropertyHandler Instance = new ForeignKeyFormatPropertyHandler();
		
			/// <summary>
			/// Gets the Id of the Model.ForeignKeyFormat domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return ForeignKeyFormatDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed global::System.String GetValue(Model element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.foreignKeyFormatPropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(Model element, global::System.String newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				global::System.String oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.foreignKeyFormatPropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region CommonPrimaryKeyPropertyFormat domain property code
		
		/// <summary>
		/// CommonPrimaryKeyPropertyFormat domain property Id.
		/// </summary>
		public static readonly global::System.Guid CommonPrimaryKeyPropertyFormatDomainPropertyId = new global::System.Guid(0xebdf3b2b, 0x288b, 0x431a, 0x93, 0xbd, 0xcb, 0xeb, 0x86, 0x97, 0xcc, 0x7a);
		
		/// <summary>
		/// Storage for CommonPrimaryKeyPropertyFormat
		/// </summary>
		private global::System.String commonPrimaryKeyPropertyFormatPropertyStorage = string.Empty;
		
		/// <summary>
		/// Gets or sets the value of CommonPrimaryKeyPropertyFormat domain property.
		/// If no other primary key is specified, a primary key will be generated with this
		/// format.  {0} will be replaced with the class name.  As an example, {0}Id would
		/// generate SomeClassId as the primary key property for SomeClass.  If left blank,
		/// no primary keys will be added to classes without existing primary keys.
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.Model/CommonPrimaryKeyPropertyFormat.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.Model/CommonPrimaryKeyPropertyFormat.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.Model/CommonPrimaryKeyPropertyFormat.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[global::System.ComponentModel.DefaultValue("")]
		[DslModeling::DomainObjectId("ebdf3b2b-288b-431a-93bd-cbeb8697cc7a")]
		public global::System.String CommonPrimaryKeyPropertyFormat
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return commonPrimaryKeyPropertyFormatPropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				CommonPrimaryKeyPropertyFormatPropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the Model.CommonPrimaryKeyPropertyFormat domain property.
		/// </summary>
		internal sealed partial class CommonPrimaryKeyPropertyFormatPropertyHandler : DslModeling::DomainPropertyValueHandler<Model, global::System.String>
		{
			private CommonPrimaryKeyPropertyFormatPropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the Model.CommonPrimaryKeyPropertyFormat domain property value handler.
			/// </summary>
			public static readonly CommonPrimaryKeyPropertyFormatPropertyHandler Instance = new CommonPrimaryKeyPropertyFormatPropertyHandler();
		
			/// <summary>
			/// Gets the Id of the Model.CommonPrimaryKeyPropertyFormat domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return CommonPrimaryKeyPropertyFormatDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed global::System.String GetValue(Model element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.commonPrimaryKeyPropertyFormatPropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(Model element, global::System.String newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				global::System.String oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.commonPrimaryKeyPropertyFormatPropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region CommonPrimaryKeyColumnFormat domain property code
		
		/// <summary>
		/// CommonPrimaryKeyColumnFormat domain property Id.
		/// </summary>
		public static readonly global::System.Guid CommonPrimaryKeyColumnFormatDomainPropertyId = new global::System.Guid(0x51fb36b6, 0x2aaf, 0x424a, 0x98, 0x11, 0x0a, 0xf8, 0x10, 0xb2, 0x7d, 0x87);
		
		/// <summary>
		/// Storage for CommonPrimaryKeyColumnFormat
		/// </summary>
		private global::System.String commonPrimaryKeyColumnFormatPropertyStorage = string.Empty;
		
		/// <summary>
		/// Gets or sets the value of CommonPrimaryKeyColumnFormat domain property.
		/// The column name used for the common primary key property.  If not specified, the
		/// name of the property will be used.  {0} will be replaced with the name of the
		/// table.  For example, you could use the table name with a standard suffix: {0}_ID
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.Model/CommonPrimaryKeyColumnFormat.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.Model/CommonPrimaryKeyColumnFormat.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.Model/CommonPrimaryKeyColumnFormat.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[global::System.ComponentModel.DefaultValue("")]
		[DslModeling::DomainObjectId("51fb36b6-2aaf-424a-9811-0af810b27d87")]
		public global::System.String CommonPrimaryKeyColumnFormat
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return commonPrimaryKeyColumnFormatPropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				CommonPrimaryKeyColumnFormatPropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the Model.CommonPrimaryKeyColumnFormat domain property.
		/// </summary>
		internal sealed partial class CommonPrimaryKeyColumnFormatPropertyHandler : DslModeling::DomainPropertyValueHandler<Model, global::System.String>
		{
			private CommonPrimaryKeyColumnFormatPropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the Model.CommonPrimaryKeyColumnFormat domain property value handler.
			/// </summary>
			public static readonly CommonPrimaryKeyColumnFormatPropertyHandler Instance = new CommonPrimaryKeyColumnFormatPropertyHandler();
		
			/// <summary>
			/// Gets the Id of the Model.CommonPrimaryKeyColumnFormat domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return CommonPrimaryKeyColumnFormatDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed global::System.String GetValue(Model element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.commonPrimaryKeyColumnFormatPropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(Model element, global::System.String newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				global::System.String oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.commonPrimaryKeyColumnFormatPropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region CommonPrimaryKeyColumnType domain property code
		
		/// <summary>
		/// CommonPrimaryKeyColumnType domain property Id.
		/// </summary>
		public static readonly global::System.Guid CommonPrimaryKeyColumnTypeDomainPropertyId = new global::System.Guid(0xd4b5a000, 0x5a74, 0x49fd, 0x84, 0xd9, 0x5c, 0x0f, 0x66, 0x86, 0x45, 0x39);
		
		/// <summary>
		/// Storage for CommonPrimaryKeyColumnType
		/// </summary>
		private NHibernateType commonPrimaryKeyColumnTypePropertyStorage = NHibernateType.Int32;
		
		/// <summary>
		/// Gets or sets the value of CommonPrimaryKeyColumnType domain property.
		/// NHibernate type for common primary key.
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.Model/CommonPrimaryKeyColumnType.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.Model/CommonPrimaryKeyColumnType.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.Model/CommonPrimaryKeyColumnType.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[global::System.ComponentModel.DefaultValue(NHibernateType.Int32)]
		[DslModeling::DomainObjectId("d4b5a000-5a74-49fd-84d9-5c0f66864539")]
		public NHibernateType CommonPrimaryKeyColumnType
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return commonPrimaryKeyColumnTypePropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				CommonPrimaryKeyColumnTypePropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the Model.CommonPrimaryKeyColumnType domain property.
		/// </summary>
		internal sealed partial class CommonPrimaryKeyColumnTypePropertyHandler : DslModeling::DomainPropertyValueHandler<Model, NHibernateType>
		{
			private CommonPrimaryKeyColumnTypePropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the Model.CommonPrimaryKeyColumnType domain property value handler.
			/// </summary>
			public static readonly CommonPrimaryKeyColumnTypePropertyHandler Instance = new CommonPrimaryKeyColumnTypePropertyHandler();
		
			/// <summary>
			/// Gets the Id of the Model.CommonPrimaryKeyColumnType domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return CommonPrimaryKeyColumnTypeDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed NHibernateType GetValue(Model element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.commonPrimaryKeyColumnTypePropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(Model element, NHibernateType newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				NHibernateType oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.commonPrimaryKeyColumnTypePropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region CommonPrimaryKeyGenerator domain property code
		
		/// <summary>
		/// CommonPrimaryKeyGenerator domain property Id.
		/// </summary>
		public static readonly global::System.Guid CommonPrimaryKeyGeneratorDomainPropertyId = new global::System.Guid(0xc867009e, 0xe763, 0x4884, 0xb9, 0xab, 0x99, 0x54, 0xbc, 0x30, 0x47, 0x6f);
		
		/// <summary>
		/// Storage for CommonPrimaryKeyGenerator
		/// </summary>
		private PrimaryKeyType commonPrimaryKeyGeneratorPropertyStorage = PrimaryKeyType.Native;
		
		/// <summary>
		/// Gets or sets the value of CommonPrimaryKeyGenerator domain property.
		/// Generator type for common primary key.
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.Model/CommonPrimaryKeyGenerator.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.Model/CommonPrimaryKeyGenerator.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.Model/CommonPrimaryKeyGenerator.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[global::System.ComponentModel.DefaultValue(PrimaryKeyType.Native)]
		[DslModeling::DomainObjectId("c867009e-e763-4884-b9ab-9954bc30476f")]
		public PrimaryKeyType CommonPrimaryKeyGenerator
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return commonPrimaryKeyGeneratorPropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				CommonPrimaryKeyGeneratorPropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the Model.CommonPrimaryKeyGenerator domain property.
		/// </summary>
		internal sealed partial class CommonPrimaryKeyGeneratorPropertyHandler : DslModeling::DomainPropertyValueHandler<Model, PrimaryKeyType>
		{
			private CommonPrimaryKeyGeneratorPropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the Model.CommonPrimaryKeyGenerator domain property value handler.
			/// </summary>
			public static readonly CommonPrimaryKeyGeneratorPropertyHandler Instance = new CommonPrimaryKeyGeneratorPropertyHandler();
		
			/// <summary>
			/// Gets the Id of the Model.CommonPrimaryKeyGenerator domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return CommonPrimaryKeyGeneratorDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed PrimaryKeyType GetValue(Model element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.commonPrimaryKeyGeneratorPropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(Model element, PrimaryKeyType newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				PrimaryKeyType oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.commonPrimaryKeyGeneratorPropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region MemberTemplateFile domain property code
		
		/// <summary>
		/// MemberTemplateFile domain property Id.
		/// </summary>
		public static readonly global::System.Guid MemberTemplateFileDomainPropertyId = new global::System.Guid(0xce08ed4d, 0x6e7a, 0x43b2, 0xbe, 0xbd, 0xbc, 0xad, 0x15, 0x0a, 0x6d, 0x1a);
		
		/// <summary>
		/// Storage for MemberTemplateFile
		/// </summary>
		private global::System.String memberTemplateFilePropertyStorage = string.Empty;
		
		/// <summary>
		/// Gets or sets the value of MemberTemplateFile domain property.
		/// Methods and propeties from the single class within the template file will be
		/// imported, transformed, and then placed in the generated output.  As an example,
		/// you could specify the ActiveRecordBase.Generic.cs file and the generic methods
		/// would be transformed into specific methods for each class.  The first generic
		/// type parameter is replaced with the generated class type.  There are additional
		/// transformations for subclasses.  The path to the source file is relative to the
		/// .actiw file.  If the path has "..." in it, all parent folders are searched
		/// upwards until a match is found.  For example,
		/// "...\ActiveRecord\ActiveRecordBase.generic.cs" would look for
		/// "ActiveRecord\ActiveRecordBase.generic.cs" in the folder containing the .actiw
		/// file and in all folders up to the root.
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.Model/MemberTemplateFile.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.Model/MemberTemplateFile.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslModeling::DomainObjectId("ce08ed4d-6e7a-43b2-bebd-bcad150a6d1a")]
		public global::System.String MemberTemplateFile
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return memberTemplateFilePropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				MemberTemplateFilePropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the Model.MemberTemplateFile domain property.
		/// </summary>
		internal sealed partial class MemberTemplateFilePropertyHandler : DslModeling::DomainPropertyValueHandler<Model, global::System.String>
		{
			private MemberTemplateFilePropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the Model.MemberTemplateFile domain property value handler.
			/// </summary>
			public static readonly MemberTemplateFilePropertyHandler Instance = new MemberTemplateFilePropertyHandler();
		
			/// <summary>
			/// Gets the Id of the Model.MemberTemplateFile domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return MemberTemplateFileDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed global::System.String GetValue(Model element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.memberTemplateFilePropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(Model element, global::System.String newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				global::System.String oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.memberTemplateFilePropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region BaseClassPropertyChangedMethod domain property code
		
		/// <summary>
		/// BaseClassPropertyChangedMethod domain property Id.
		/// </summary>
		public static readonly global::System.Guid BaseClassPropertyChangedMethodDomainPropertyId = new global::System.Guid(0x7ab0fb5b, 0x7bb6, 0x4a32, 0xb0, 0x1b, 0xdd, 0x80, 0xa6, 0x97, 0xbe, 0x4b);
		
		/// <summary>
		/// Storage for BaseClassPropertyChangedMethod
		/// </summary>
		private global::System.String baseClassPropertyChangedMethodPropertyStorage = string.Empty;
		
		/// <summary>
		/// Gets or sets the value of BaseClassPropertyChangedMethod domain property.
		/// If there is already a PropertyChanged event defined in the base class, specify
		/// the name of a method that takes a single string that can be used to invoke it.
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.Model/BaseClassPropertyChangedMethod.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.Model/BaseClassPropertyChangedMethod.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.Model/BaseClassPropertyChangedMethod.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslModeling::DomainObjectId("7ab0fb5b-7bb6-4a32-b01b-dd80a697be4b")]
		public global::System.String BaseClassPropertyChangedMethod
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return baseClassPropertyChangedMethodPropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				BaseClassPropertyChangedMethodPropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the Model.BaseClassPropertyChangedMethod domain property.
		/// </summary>
		internal sealed partial class BaseClassPropertyChangedMethodPropertyHandler : DslModeling::DomainPropertyValueHandler<Model, global::System.String>
		{
			private BaseClassPropertyChangedMethodPropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the Model.BaseClassPropertyChangedMethod domain property value handler.
			/// </summary>
			public static readonly BaseClassPropertyChangedMethodPropertyHandler Instance = new BaseClassPropertyChangedMethodPropertyHandler();
		
			/// <summary>
			/// Gets the Id of the Model.BaseClassPropertyChangedMethod domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return BaseClassPropertyChangedMethodDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed global::System.String GetValue(Model element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.baseClassPropertyChangedMethodPropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(Model element, global::System.String newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				global::System.String oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.baseClassPropertyChangedMethodPropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region BaseClassPropertyChangingMethod domain property code
		
		/// <summary>
		/// BaseClassPropertyChangingMethod domain property Id.
		/// </summary>
		public static readonly global::System.Guid BaseClassPropertyChangingMethodDomainPropertyId = new global::System.Guid(0x6598afbe, 0xf2a2, 0x434a, 0xb6, 0x6d, 0x29, 0x40, 0x04, 0x61, 0xd6, 0x92);
		
		/// <summary>
		/// Storage for BaseClassPropertyChangingMethod
		/// </summary>
		private global::System.String baseClassPropertyChangingMethodPropertyStorage = string.Empty;
		
		/// <summary>
		/// Gets or sets the value of BaseClassPropertyChangingMethod domain property.
		/// If there is already a PropertyChanging event defined in the base class, specify
		/// the name of a method that takes a single string that can be used to invoke it.
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.Model/BaseClassPropertyChangingMethod.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.Model/BaseClassPropertyChangingMethod.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.Model/BaseClassPropertyChangingMethod.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslModeling::DomainObjectId("6598afbe-f2a2-434a-b66d-29400461d692")]
		public global::System.String BaseClassPropertyChangingMethod
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return baseClassPropertyChangingMethodPropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				BaseClassPropertyChangingMethodPropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the Model.BaseClassPropertyChangingMethod domain property.
		/// </summary>
		internal sealed partial class BaseClassPropertyChangingMethodPropertyHandler : DslModeling::DomainPropertyValueHandler<Model, global::System.String>
		{
			private BaseClassPropertyChangingMethodPropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the Model.BaseClassPropertyChangingMethod domain property value handler.
			/// </summary>
			public static readonly BaseClassPropertyChangingMethodPropertyHandler Instance = new BaseClassPropertyChangingMethodPropertyHandler();
		
			/// <summary>
			/// Gets the Id of the Model.BaseClassPropertyChangingMethod domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return BaseClassPropertyChangingMethodDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed global::System.String GetValue(Model element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.baseClassPropertyChangingMethodPropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(Model element, global::System.String newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				global::System.String oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.baseClassPropertyChangingMethodPropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region Access domain property code
		
		/// <summary>
		/// Access domain property Id.
		/// </summary>
		public static readonly global::System.Guid AccessDomainPropertyId = new global::System.Guid(0xc4d6694d, 0x6588, 0x4d94, 0xb0, 0xfa, 0x74, 0xc1, 0x94, 0xff, 0xaa, 0x4e);
		
		/// <summary>
		/// Storage for Access
		/// </summary>
		private PropertyAccess accessPropertyStorage = PropertyAccess.Property;
		
		/// <summary>
		/// Gets or sets the value of Access domain property.
		/// Global property access setting.  Can be overridden at class or property level.
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.Model/Access.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.Model/Access.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.Model/Access.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[global::System.ComponentModel.DefaultValue(PropertyAccess.Property)]
		[DslModeling::DomainObjectId("c4d6694d-6588-4d94-b0fa-74c194ffaa4e")]
		public PropertyAccess Access
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return accessPropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				AccessPropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the Model.Access domain property.
		/// </summary>
		internal sealed partial class AccessPropertyHandler : DslModeling::DomainPropertyValueHandler<Model, PropertyAccess>
		{
			private AccessPropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the Model.Access domain property value handler.
			/// </summary>
			public static readonly AccessPropertyHandler Instance = new AccessPropertyHandler();
		
			/// <summary>
			/// Gets the Id of the Model.Access domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return AccessDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed PropertyAccess GetValue(Model element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.accessPropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(Model element, PropertyAccess newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				PropertyAccess oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.accessPropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region Classes opposite domain role accessor
		
		/// <summary>
		/// Gets a list of Classes.
		/// Classes of the model
		/// </summary>
		public virtual DslModeling::LinkedElementCollection<ModelClass> Classes
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return GetRoleCollection<DslModeling::LinkedElementCollection<ModelClass>, ModelClass>(global::Castle.ActiveWriter.ModelHasClass.ModelDomainRoleId);
			}
		}
		#endregion
		#region NestedClasses opposite domain role accessor
		
		/// <summary>
		/// Gets a list of NestedClasses.
		/// Description for Castle.ActiveWriter.ModelHasNestedClasses.Model
		/// </summary>
		public virtual DslModeling::LinkedElementCollection<NestedClass> NestedClasses
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return GetRoleCollection<DslModeling::LinkedElementCollection<NestedClass>, NestedClass>(global::Castle.ActiveWriter.ModelHasNestedClasses.ModelDomainRoleId);
			}
		}
		#endregion
		#region ElementGroupPrototype Merge methods
		/// <summary>
		/// Returns a value indicating whether the source element represented by the
		/// specified root ProtoElement can be added to this element.
		/// </summary>
		/// <param name="rootElement">
		/// The root ProtoElement representing a source element.  This can be null, 
		/// in which case the ElementGroupPrototype does not contain an ProtoElements
		/// and the code should inspect the ElementGroupPrototype context information.
		/// </param>
		/// <param name="elementGroupPrototype">The ElementGroupPrototype that contains the root ProtoElement.</param>
		/// <returns>true if the source element represented by the ProtoElement can be added to this target element.</returns>
		protected override bool CanMerge(DslModeling::ProtoElementBase rootElement, DslModeling::ElementGroupPrototype elementGroupPrototype)
		{
			if ( elementGroupPrototype == null ) throw new global::System.ArgumentNullException("elementGroupPrototype");
			
			if (rootElement != null)
			{
				DslModeling::DomainClassInfo rootElementDomainInfo = Partition.DomainDataDirectory.GetDomainClass(rootElement.DomainClassId);
				
				if (rootElementDomainInfo.IsDerivedFrom(global::Castle.ActiveWriter.ModelClass.DomainClassId)) 
				{
					return true;
				}
				
				if (rootElementDomainInfo.IsDerivedFrom(global::Castle.ActiveWriter.NestedClass.DomainClassId)) 
				{
					return true;
				}
			}
			return base.CanMerge(rootElement, elementGroupPrototype);
		}
		
		/// <summary>
		/// Called by the Merge process to create a relationship between 
		/// this target element and the specified source element. 
		/// Typically, a parent-child relationship is established
		/// between the target element (the parent) and the source element 
		/// (the child), but any relationship can be established.
		/// </summary>
		/// <param name="sourceElement">The element that is to be related to this model element.</param>
		/// <param name="elementGroup">The group of source ModelElements that have been rehydrated into the target store.</param>
		/// <remarks>
		/// This method is overriden to create the relationship between the target element and the specified source element.
		/// The base method does nothing.
		/// </remarks>
		protected override void MergeRelate(DslModeling::ModelElement sourceElement, DslModeling::ElementGroup elementGroup)
		{
			// In general, sourceElement is allowed to be null, meaning that the elementGroup must be parsed for special cases.
			// However this is not supported in generated code.  Use double-deriving on this class and then override MergeRelate completely if you 
			// need to support this case.
			if ( sourceElement == null ) throw new global::System.ArgumentNullException("sourceElement");
		
				
			global::Castle.ActiveWriter.ModelClass sourceModelClass1 = sourceElement as global::Castle.ActiveWriter.ModelClass;
			if (sourceModelClass1 != null)
			{
				// Create link for path ModelHasClass.Classes
				Classes.Add(sourceModelClass1);

				return;
			}
				
			global::Castle.ActiveWriter.NestedClass sourceNestedClass2 = sourceElement as global::Castle.ActiveWriter.NestedClass;
			if (sourceNestedClass2 != null)
			{
				// Create link for path ModelHasNestedClasses.NestedClasses
				NestedClasses.Add(sourceNestedClass2);

				return;
			}
		
			// Sdk workaround to runtime bug #879350 (DSL: can't copy and paste a MEL that has a MEX). Avoid MergeRelate on ModelElementExtension
			// during a "Paste".
			if (sourceElement is DslModeling::ExtensionElement
				&& sourceElement.Store.TransactionManager.CurrentTransaction.TopLevelTransaction.Context.ContextInfo.ContainsKey("{9DAFD42A-DC0E-4d78-8C3F-8266B2CF8B33}"))
			{
				return;
			}
		
			// Fall through to base class if this class hasn't handled the merge.
			base.MergeRelate(sourceElement, elementGroup);
		}
		
		/// <summary>
		/// Performs operation opposite to MergeRelate - i.e. disconnects a given
		/// element from the current one (removes links created by MergeRelate).
		/// </summary>
		/// <param name="sourceElement">Element to be unmerged/disconnected.</param>
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
		protected override void MergeDisconnect(DslModeling::ModelElement sourceElement)
		{
			if (sourceElement == null) throw new global::System.ArgumentNullException("sourceElement");
				
			global::Castle.ActiveWriter.ModelClass sourceModelClass1 = sourceElement as global::Castle.ActiveWriter.ModelClass;
			if (sourceModelClass1 != null)
			{
				// Delete link for path ModelHasClass.Classes
				
				foreach (DslModeling::ElementLink link in global::Castle.ActiveWriter.ModelHasClass.GetLinks((global::Castle.ActiveWriter.Model)this, sourceModelClass1))
				{
					// Delete the link, but without possible delete propagation to the element since it's moving to a new location.
					link.Delete(global::Castle.ActiveWriter.ModelHasClass.ModelDomainRoleId, global::Castle.ActiveWriter.ModelHasClass.ClassDomainRoleId);
				}

				return;
			}
				
			global::Castle.ActiveWriter.NestedClass sourceNestedClass2 = sourceElement as global::Castle.ActiveWriter.NestedClass;
			if (sourceNestedClass2 != null)
			{
				// Delete link for path ModelHasNestedClasses.NestedClasses
				
				foreach (DslModeling::ElementLink link in global::Castle.ActiveWriter.ModelHasNestedClasses.GetLinks((global::Castle.ActiveWriter.Model)this, sourceNestedClass2))
				{
					// Delete the link, but without possible delete propagation to the element since it's moving to a new location.
					link.Delete(global::Castle.ActiveWriter.ModelHasNestedClasses.ModelDomainRoleId, global::Castle.ActiveWriter.ModelHasNestedClasses.NestedClassDomainRoleId);
				}

				return;
			}
			// Fall through to base class if this class hasn't handled the unmerge.
			base.MergeDisconnect(sourceElement);
		}
		#endregion
	}
}
namespace Castle.ActiveWriter
{
	/// <summary>
	/// DomainClass ModelClass
	/// A class of the domain
	/// </summary>
	[DslDesign::DisplayNameResource("Castle.ActiveWriter.ModelClass.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
	[DslDesign::DescriptionResource("Castle.ActiveWriter.ModelClass.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
	[DslModeling::DomainModelOwner(typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel))]
	[global::System.CLSCompliant(true)]
	[DslModeling::DomainObjectId("38be3d51-c07f-4b6c-b05a-42f20848e9e2")]
	public partial class ModelClass : ModelElementWithAccess
	{
		#region Constructors, domain class Id
	
		/// <summary>
		/// ModelClass domain class Id.
		/// </summary>
		public static readonly new global::System.Guid DomainClassId = new global::System.Guid(0x38be3d51, 0xc07f, 0x4b6c, 0xb0, 0x5a, 0x42, 0xf2, 0x08, 0x48, 0xe9, 0xe2);
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="store">Store where new element is to be created.</param>
		/// <param name="propertyAssignments">List of domain property id/value pairs to set once the element is created.</param>
		public ModelClass(DslModeling::Store store, params DslModeling::PropertyAssignment[] propertyAssignments)
			: this(store != null ? store.DefaultPartitionForClass(DomainClassId) : null, propertyAssignments)
		{
		}
		
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="partition">Partition where new element is to be created.</param>
		/// <param name="propertyAssignments">List of domain property id/value pairs to set once the element is created.</param>
		public ModelClass(DslModeling::Partition partition, params DslModeling::PropertyAssignment[] propertyAssignments)
			: base(partition, propertyAssignments)
		{
		}
		#endregion
		#region Cache domain property code
		
		/// <summary>
		/// Cache domain property Id.
		/// </summary>
		public static readonly global::System.Guid CacheDomainPropertyId = new global::System.Guid(0x317d9c1a, 0x4f8a, 0x4745, 0x89, 0x02, 0x44, 0xbc, 0x05, 0x40, 0xe0, 0x00);
		
		/// <summary>
		/// Storage for Cache
		/// </summary>
		private CacheEnum cachePropertyStorage = CacheEnum.Undefined;
		
		/// <summary>
		/// Gets or sets the value of Cache domain property.
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.ModelClass/Cache.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.ModelClass/Cache.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.ModelClass/Cache.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[global::System.ComponentModel.DefaultValue(CacheEnum.Undefined)]
		[DslModeling::DomainObjectId("317d9c1a-4f8a-4745-8902-44bc0540e000")]
		public CacheEnum Cache
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return cachePropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				CachePropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the ModelClass.Cache domain property.
		/// </summary>
		internal sealed partial class CachePropertyHandler : DslModeling::DomainPropertyValueHandler<ModelClass, CacheEnum>
		{
			private CachePropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the ModelClass.Cache domain property value handler.
			/// </summary>
			public static readonly CachePropertyHandler Instance = new CachePropertyHandler();
		
			/// <summary>
			/// Gets the Id of the ModelClass.Cache domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return CacheDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed CacheEnum GetValue(ModelClass element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.cachePropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(ModelClass element, CacheEnum newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				CacheEnum oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.cachePropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region DiscriminatorColumn domain property code
		
		/// <summary>
		/// DiscriminatorColumn domain property Id.
		/// </summary>
		public static readonly global::System.Guid DiscriminatorColumnDomainPropertyId = new global::System.Guid(0xba3636a4, 0xae2d, 0x4d3e, 0x9b, 0x2a, 0xe9, 0x3d, 0x74, 0xb3, 0xac, 0x30);
		
		/// <summary>
		/// Storage for DiscriminatorColumn
		/// </summary>
		private global::System.String discriminatorColumnPropertyStorage = string.Empty;
		
		/// <summary>
		/// Gets or sets the value of DiscriminatorColumn domain property.
		/// Discriminator column for a table inheritance modeling
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.ModelClass/DiscriminatorColumn.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.ModelClass/DiscriminatorColumn.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.ModelClass/DiscriminatorColumn.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslModeling::DomainObjectId("ba3636a4-ae2d-4d3e-9b2a-e93d74b3ac30")]
		public global::System.String DiscriminatorColumn
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return discriminatorColumnPropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				DiscriminatorColumnPropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the ModelClass.DiscriminatorColumn domain property.
		/// </summary>
		internal sealed partial class DiscriminatorColumnPropertyHandler : DslModeling::DomainPropertyValueHandler<ModelClass, global::System.String>
		{
			private DiscriminatorColumnPropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the ModelClass.DiscriminatorColumn domain property value handler.
			/// </summary>
			public static readonly DiscriminatorColumnPropertyHandler Instance = new DiscriminatorColumnPropertyHandler();
		
			/// <summary>
			/// Gets the Id of the ModelClass.DiscriminatorColumn domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return DiscriminatorColumnDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed global::System.String GetValue(ModelClass element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.discriminatorColumnPropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(ModelClass element, global::System.String newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				global::System.String oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.discriminatorColumnPropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region DiscriminatorType domain property code
		
		/// <summary>
		/// DiscriminatorType domain property Id.
		/// </summary>
		public static readonly global::System.Guid DiscriminatorTypeDomainPropertyId = new global::System.Guid(0xa895f8a6, 0x03ce, 0x4a11, 0xbe, 0x54, 0xe1, 0x7e, 0x89, 0xa6, 0x42, 0x0a);
		
		/// <summary>
		/// Storage for DiscriminatorType
		/// </summary>
		private global::System.String discriminatorTypePropertyStorage = string.Empty;
		
		/// <summary>
		/// Gets or sets the value of DiscriminatorType domain property.
		/// Column type (like string or integer) for the discriminator column
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.ModelClass/DiscriminatorType.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.ModelClass/DiscriminatorType.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.ModelClass/DiscriminatorType.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslModeling::DomainObjectId("a895f8a6-03ce-4a11-be54-e17e89a6420a")]
		public global::System.String DiscriminatorType
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return discriminatorTypePropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				DiscriminatorTypePropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the ModelClass.DiscriminatorType domain property.
		/// </summary>
		internal sealed partial class DiscriminatorTypePropertyHandler : DslModeling::DomainPropertyValueHandler<ModelClass, global::System.String>
		{
			private DiscriminatorTypePropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the ModelClass.DiscriminatorType domain property value handler.
			/// </summary>
			public static readonly DiscriminatorTypePropertyHandler Instance = new DiscriminatorTypePropertyHandler();
		
			/// <summary>
			/// Gets the Id of the ModelClass.DiscriminatorType domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return DiscriminatorTypeDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed global::System.String GetValue(ModelClass element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.discriminatorTypePropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(ModelClass element, global::System.String newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				global::System.String oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.discriminatorTypePropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region DiscriminatorValue domain property code
		
		/// <summary>
		/// DiscriminatorValue domain property Id.
		/// </summary>
		public static readonly global::System.Guid DiscriminatorValueDomainPropertyId = new global::System.Guid(0x52115192, 0x5af0, 0x4304, 0xa9, 0xaa, 0x1a, 0x69, 0x25, 0xff, 0xb3, 0xc1);
		
		/// <summary>
		/// Storage for DiscriminatorValue
		/// </summary>
		private global::System.String discriminatorValuePropertyStorage = string.Empty;
		
		/// <summary>
		/// Gets or sets the value of DiscriminatorValue domain property.
		/// Value that represents the target class on the discriminator column
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.ModelClass/DiscriminatorValue.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.ModelClass/DiscriminatorValue.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.ModelClass/DiscriminatorValue.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslModeling::DomainObjectId("52115192-5af0-4304-a9aa-1a6925ffb3c1")]
		public global::System.String DiscriminatorValue
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return discriminatorValuePropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				DiscriminatorValuePropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the ModelClass.DiscriminatorValue domain property.
		/// </summary>
		internal sealed partial class DiscriminatorValuePropertyHandler : DslModeling::DomainPropertyValueHandler<ModelClass, global::System.String>
		{
			private DiscriminatorValuePropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the ModelClass.DiscriminatorValue domain property value handler.
			/// </summary>
			public static readonly DiscriminatorValuePropertyHandler Instance = new DiscriminatorValuePropertyHandler();
		
			/// <summary>
			/// Gets the Id of the ModelClass.DiscriminatorValue domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return DiscriminatorValueDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed global::System.String GetValue(ModelClass element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.discriminatorValuePropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(ModelClass element, global::System.String newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				global::System.String oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.discriminatorValuePropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region Lazy domain property code
		
		/// <summary>
		/// Lazy domain property Id.
		/// </summary>
		public static readonly global::System.Guid LazyDomainPropertyId = new global::System.Guid(0x1be0d961, 0x60e7, 0x4ebe, 0xa6, 0xa1, 0x37, 0xcb, 0xdc, 0x7e, 0x1a, 0xc5);
		
		/// <summary>
		/// Storage for Lazy
		/// </summary>
		private global::System.Boolean lazyPropertyStorage;
		
		/// <summary>
		/// Gets or sets the value of Lazy domain property.
		/// Enable lazy loading for the type
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.ModelClass/Lazy.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.ModelClass/Lazy.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.ModelClass/Lazy.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslModeling::DomainObjectId("1be0d961-60e7-4ebe-a6a1-37cbdc7e1ac5")]
		public global::System.Boolean Lazy
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return lazyPropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				LazyPropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the ModelClass.Lazy domain property.
		/// </summary>
		internal sealed partial class LazyPropertyHandler : DslModeling::DomainPropertyValueHandler<ModelClass, global::System.Boolean>
		{
			private LazyPropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the ModelClass.Lazy domain property value handler.
			/// </summary>
			public static readonly LazyPropertyHandler Instance = new LazyPropertyHandler();
		
			/// <summary>
			/// Gets the Id of the ModelClass.Lazy domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return LazyDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed global::System.Boolean GetValue(ModelClass element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.lazyPropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(ModelClass element, global::System.Boolean newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				global::System.Boolean oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.lazyPropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region Proxy domain property code
		
		/// <summary>
		/// Proxy domain property Id.
		/// </summary>
		public static readonly global::System.Guid ProxyDomainPropertyId = new global::System.Guid(0x743abeab, 0x7821, 0x48a6, 0x9f, 0xaa, 0x6b, 0x74, 0xfd, 0xc3, 0x6d, 0x17);
		
		/// <summary>
		/// Storage for Proxy
		/// </summary>
		private global::System.String proxyPropertyStorage = string.Empty;
		
		/// <summary>
		/// Gets or sets the value of Proxy domain property.
		/// Associates a proxy type with the target type
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.ModelClass/Proxy.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.ModelClass/Proxy.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.ModelClass/Proxy.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslModeling::DomainObjectId("743abeab-7821-48a6-9faa-6b74fdc36d17")]
		public global::System.String Proxy
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return proxyPropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				ProxyPropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the ModelClass.Proxy domain property.
		/// </summary>
		internal sealed partial class ProxyPropertyHandler : DslModeling::DomainPropertyValueHandler<ModelClass, global::System.String>
		{
			private ProxyPropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the ModelClass.Proxy domain property value handler.
			/// </summary>
			public static readonly ProxyPropertyHandler Instance = new ProxyPropertyHandler();
		
			/// <summary>
			/// Gets the Id of the ModelClass.Proxy domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return ProxyDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed global::System.String GetValue(ModelClass element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.proxyPropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(ModelClass element, global::System.String newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				global::System.String oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.proxyPropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region Schema domain property code
		
		/// <summary>
		/// Schema domain property Id.
		/// </summary>
		public static readonly global::System.Guid SchemaDomainPropertyId = new global::System.Guid(0x2a4ece06, 0xb2fc, 0x4bdf, 0x82, 0x79, 0x4f, 0xa2, 0x7a, 0xe7, 0xc6, 0xdc);
		
		/// <summary>
		/// Storage for Schema
		/// </summary>
		private global::System.String schemaPropertyStorage = string.Empty;
		
		/// <summary>
		/// Gets or sets the value of Schema domain property.
		/// Schema name associated with the type
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.ModelClass/Schema.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.ModelClass/Schema.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.ModelClass/Schema.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslModeling::DomainObjectId("2a4ece06-b2fc-4bdf-8279-4fa27ae7c6dc")]
		public global::System.String Schema
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return schemaPropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				SchemaPropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the ModelClass.Schema domain property.
		/// </summary>
		internal sealed partial class SchemaPropertyHandler : DslModeling::DomainPropertyValueHandler<ModelClass, global::System.String>
		{
			private SchemaPropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the ModelClass.Schema domain property value handler.
			/// </summary>
			public static readonly SchemaPropertyHandler Instance = new SchemaPropertyHandler();
		
			/// <summary>
			/// Gets the Id of the ModelClass.Schema domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return SchemaDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed global::System.String GetValue(ModelClass element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.schemaPropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(ModelClass element, global::System.String newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				global::System.String oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.schemaPropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region Table domain property code
		
		/// <summary>
		/// Table domain property Id.
		/// </summary>
		public static readonly global::System.Guid TableDomainPropertyId = new global::System.Guid(0x10425242, 0x9835, 0x4fab, 0x8b, 0x43, 0x98, 0xe5, 0x10, 0x35, 0xd3, 0xdf);
		
		/// <summary>
		/// Storage for Table
		/// </summary>
		private global::System.String tablePropertyStorage = string.Empty;
		
		/// <summary>
		/// Gets or sets the value of Table domain property.
		/// Table name associated with the type
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.ModelClass/Table.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.ModelClass/Table.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.ModelClass/Table.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslModeling::DomainObjectId("10425242-9835-4fab-8b43-98e51035d3df")]
		public global::System.String Table
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return tablePropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				TablePropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the ModelClass.Table domain property.
		/// </summary>
		internal sealed partial class TablePropertyHandler : DslModeling::DomainPropertyValueHandler<ModelClass, global::System.String>
		{
			private TablePropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the ModelClass.Table domain property value handler.
			/// </summary>
			public static readonly TablePropertyHandler Instance = new TablePropertyHandler();
		
			/// <summary>
			/// Gets the Id of the ModelClass.Table domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return TableDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed global::System.String GetValue(ModelClass element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.tablePropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(ModelClass element, global::System.String newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				global::System.String oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.tablePropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region Where domain property code
		
		/// <summary>
		/// Where domain property Id.
		/// </summary>
		public static readonly global::System.Guid WhereDomainPropertyId = new global::System.Guid(0x128b9af7, 0x5c8d, 0x4e69, 0xb2, 0x7b, 0xd2, 0xa5, 0xb6, 0x58, 0xa6, 0x18);
		
		/// <summary>
		/// Storage for Where
		/// </summary>
		private global::System.String wherePropertyStorage = string.Empty;
		
		/// <summary>
		/// Gets or sets the value of Where domain property.
		/// SQL condition to retrieve objects
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.ModelClass/Where.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.ModelClass/Where.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.ModelClass/Where.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslModeling::DomainObjectId("128b9af7-5c8d-4e69-b27b-d2a5b658a618")]
		public global::System.String Where
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return wherePropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				WherePropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the ModelClass.Where domain property.
		/// </summary>
		internal sealed partial class WherePropertyHandler : DslModeling::DomainPropertyValueHandler<ModelClass, global::System.String>
		{
			private WherePropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the ModelClass.Where domain property value handler.
			/// </summary>
			public static readonly WherePropertyHandler Instance = new WherePropertyHandler();
		
			/// <summary>
			/// Gets the Id of the ModelClass.Where domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return WhereDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed global::System.String GetValue(ModelClass element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.wherePropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(ModelClass element, global::System.String newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				global::System.String oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.wherePropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region HasKeyProperty domain property code
		
		/// <summary>
		/// HasKeyProperty domain property Id.
		/// </summary>
		public static readonly global::System.Guid HasKeyPropertyDomainPropertyId = new global::System.Guid(0x834cd223, 0x036c, 0x49f8, 0x98, 0x30, 0x61, 0x7b, 0x34, 0xef, 0x00, 0xd4);
		
		/// <summary>
		/// Gets or sets the value of HasKeyProperty domain property.
		/// Description for Castle.ActiveWriter.ModelClass.Has Key Property
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.ModelClass/HasKeyProperty.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.ModelClass/HasKeyProperty.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.ReadOnly(true)]
		[DslModeling::DomainProperty(Kind = DslModeling::DomainPropertyKind.Calculated)]
		[DslModeling::DomainObjectId("834cd223-036c-49f8-9830-617b34ef00d4")]
		public global::System.Boolean HasKeyProperty
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return HasKeyPropertyPropertyHandler.Instance.GetValue(this);
			}
		}
		/// <summary>
		/// Value handler for the ModelClass.HasKeyProperty domain property.
		/// </summary>
		internal sealed partial class HasKeyPropertyPropertyHandler : DslModeling::CalculatedPropertyValueHandler<ModelClass, global::System.Boolean>
		{
			private HasKeyPropertyPropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the ModelClass.HasKeyProperty domain property value handler.
			/// </summary>
			public static readonly HasKeyPropertyPropertyHandler Instance = new HasKeyPropertyPropertyHandler();
		
			/// <summary>
			/// Gets the Id of the ModelClass.HasKeyProperty domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return HasKeyPropertyDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed global::System.Boolean GetValue(ModelClass element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				// There is no storage for HasKeyProperty because its Kind is
				// set to Calculated. Please provide the GetHasKeyPropertyValue()
				// method on the domain class.
				return element.GetHasKeyPropertyValue();
			}
		
		}
		
		#endregion
		#region IsValidatorSet domain property code
		
		/// <summary>
		/// IsValidatorSet domain property Id.
		/// </summary>
		public static readonly global::System.Guid IsValidatorSetDomainPropertyId = new global::System.Guid(0x00ceff38, 0xd06d, 0x4eeb, 0x8a, 0x77, 0x4d, 0xe5, 0xab, 0xfc, 0x48, 0x80);
		
		/// <summary>
		/// Gets or sets the value of IsValidatorSet domain property.
		/// Description for Castle.ActiveWriter.ModelClass.Is Validator Set
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.ModelClass/IsValidatorSet.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.ModelClass/IsValidatorSet.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.ReadOnly(true)]
		[DslModeling::DomainProperty(Kind = DslModeling::DomainPropertyKind.Calculated)]
		[DslModeling::DomainObjectId("00ceff38-d06d-4eeb-8a77-4de5abfc4880")]
		public global::System.Boolean IsValidatorSet
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return IsValidatorSetPropertyHandler.Instance.GetValue(this);
			}
		}
		/// <summary>
		/// Value handler for the ModelClass.IsValidatorSet domain property.
		/// </summary>
		internal sealed partial class IsValidatorSetPropertyHandler : DslModeling::CalculatedPropertyValueHandler<ModelClass, global::System.Boolean>
		{
			private IsValidatorSetPropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the ModelClass.IsValidatorSet domain property value handler.
			/// </summary>
			public static readonly IsValidatorSetPropertyHandler Instance = new IsValidatorSetPropertyHandler();
		
			/// <summary>
			/// Gets the Id of the ModelClass.IsValidatorSet domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return IsValidatorSetDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed global::System.Boolean GetValue(ModelClass element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				// There is no storage for IsValidatorSet because its Kind is
				// set to Calculated. Please provide the GetIsValidatorSetValue()
				// method on the domain class.
				return element.GetIsValidatorSetValue();
			}
		
		}
		
		#endregion
		#region DynamicInsert domain property code
		
		/// <summary>
		/// DynamicInsert domain property Id.
		/// </summary>
		public static readonly global::System.Guid DynamicInsertDomainPropertyId = new global::System.Guid(0x7bfa1887, 0x17b0, 0x45c6, 0xbd, 0x09, 0xa9, 0xaa, 0xae, 0x89, 0xf0, 0x60);
		
		/// <summary>
		/// Storage for DynamicInsert
		/// </summary>
		private global::System.Boolean dynamicInsertPropertyStorage;
		
		/// <summary>
		/// Gets or sets the value of DynamicInsert domain property.
		/// Specifies that INSERT SQL should be generated at runtime and contains only the
		/// columns whose values are not null.
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.ModelClass/DynamicInsert.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.ModelClass/DynamicInsert.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.ModelClass/DynamicInsert.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslModeling::DomainObjectId("7bfa1887-17b0-45c6-bd09-a9aaae89f060")]
		public global::System.Boolean DynamicInsert
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return dynamicInsertPropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				DynamicInsertPropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the ModelClass.DynamicInsert domain property.
		/// </summary>
		internal sealed partial class DynamicInsertPropertyHandler : DslModeling::DomainPropertyValueHandler<ModelClass, global::System.Boolean>
		{
			private DynamicInsertPropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the ModelClass.DynamicInsert domain property value handler.
			/// </summary>
			public static readonly DynamicInsertPropertyHandler Instance = new DynamicInsertPropertyHandler();
		
			/// <summary>
			/// Gets the Id of the ModelClass.DynamicInsert domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return DynamicInsertDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed global::System.Boolean GetValue(ModelClass element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.dynamicInsertPropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(ModelClass element, global::System.Boolean newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				global::System.Boolean oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.dynamicInsertPropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region DynamicUpdate domain property code
		
		/// <summary>
		/// DynamicUpdate domain property Id.
		/// </summary>
		public static readonly global::System.Guid DynamicUpdateDomainPropertyId = new global::System.Guid(0x2de755fe, 0x84c3, 0x4ee3, 0x95, 0x8a, 0x81, 0xca, 0x60, 0x1a, 0xd7, 0xd8);
		
		/// <summary>
		/// Storage for DynamicUpdate
		/// </summary>
		private global::System.Boolean dynamicUpdatePropertyStorage;
		
		/// <summary>
		/// Gets or sets the value of DynamicUpdate domain property.
		/// Specifies that UPDATE SQL should be generated at runtime and contains only those
		/// columns whose values have changed.
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.ModelClass/DynamicUpdate.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.ModelClass/DynamicUpdate.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.ModelClass/DynamicUpdate.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslModeling::DomainObjectId("2de755fe-84c3-4ee3-958a-81ca601ad7d8")]
		public global::System.Boolean DynamicUpdate
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return dynamicUpdatePropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				DynamicUpdatePropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the ModelClass.DynamicUpdate domain property.
		/// </summary>
		internal sealed partial class DynamicUpdatePropertyHandler : DslModeling::DomainPropertyValueHandler<ModelClass, global::System.Boolean>
		{
			private DynamicUpdatePropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the ModelClass.DynamicUpdate domain property value handler.
			/// </summary>
			public static readonly DynamicUpdatePropertyHandler Instance = new DynamicUpdatePropertyHandler();
		
			/// <summary>
			/// Gets the Id of the ModelClass.DynamicUpdate domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return DynamicUpdateDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed global::System.Boolean GetValue(ModelClass element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.dynamicUpdatePropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(ModelClass element, global::System.Boolean newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				global::System.Boolean oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.dynamicUpdatePropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region Persister domain property code
		
		/// <summary>
		/// Persister domain property Id.
		/// </summary>
		public static readonly global::System.Guid PersisterDomainPropertyId = new global::System.Guid(0x5b5a2aba, 0xa22e, 0x40b3, 0xa8, 0xe2, 0x25, 0x3c, 0xe3, 0xe8, 0x7b, 0xe0);
		
		/// <summary>
		/// Storage for Persister
		/// </summary>
		private global::System.String persisterPropertyStorage = string.Empty;
		
		/// <summary>
		/// Gets or sets the value of Persister domain property.
		/// Specifies a custom IEntityPersister.
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.ModelClass/Persister.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.ModelClass/Persister.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.ModelClass/Persister.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslModeling::DomainObjectId("5b5a2aba-a22e-40b3-a8e2-253ce3e87be0")]
		public global::System.String Persister
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return persisterPropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				PersisterPropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the ModelClass.Persister domain property.
		/// </summary>
		internal sealed partial class PersisterPropertyHandler : DslModeling::DomainPropertyValueHandler<ModelClass, global::System.String>
		{
			private PersisterPropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the ModelClass.Persister domain property value handler.
			/// </summary>
			public static readonly PersisterPropertyHandler Instance = new PersisterPropertyHandler();
		
			/// <summary>
			/// Gets the Id of the ModelClass.Persister domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return PersisterDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed global::System.String GetValue(ModelClass element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.persisterPropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(ModelClass element, global::System.String newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				global::System.String oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.persisterPropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region SelectBeforeUpdate domain property code
		
		/// <summary>
		/// SelectBeforeUpdate domain property Id.
		/// </summary>
		public static readonly global::System.Guid SelectBeforeUpdateDomainPropertyId = new global::System.Guid(0x68ae3759, 0xc4b1, 0x4d71, 0xa6, 0x0b, 0x0f, 0x02, 0x29, 0x06, 0xd0, 0x20);
		
		/// <summary>
		/// Storage for SelectBeforeUpdate
		/// </summary>
		private global::System.Boolean selectBeforeUpdatePropertyStorage;
		
		/// <summary>
		/// Gets or sets the value of SelectBeforeUpdate domain property.
		/// Specifies that NHibernate should never perform an SQL UPDATE unless it is
		/// certain that an  object is actually modified. In certain cases (actually, only
		/// when a transient object has been associated with a new session using update()),
		/// this means that NHibernate will perform an extra SQL SELECT to determine if an
		/// UPDATE is actually required.
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.ModelClass/SelectBeforeUpdate.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.ModelClass/SelectBeforeUpdate.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.ModelClass/SelectBeforeUpdate.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslModeling::DomainObjectId("68ae3759-c4b1-4d71-a60b-0f022906d020")]
		public global::System.Boolean SelectBeforeUpdate
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return selectBeforeUpdatePropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				SelectBeforeUpdatePropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the ModelClass.SelectBeforeUpdate domain property.
		/// </summary>
		internal sealed partial class SelectBeforeUpdatePropertyHandler : DslModeling::DomainPropertyValueHandler<ModelClass, global::System.Boolean>
		{
			private SelectBeforeUpdatePropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the ModelClass.SelectBeforeUpdate domain property value handler.
			/// </summary>
			public static readonly SelectBeforeUpdatePropertyHandler Instance = new SelectBeforeUpdatePropertyHandler();
		
			/// <summary>
			/// Gets the Id of the ModelClass.SelectBeforeUpdate domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return SelectBeforeUpdateDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed global::System.Boolean GetValue(ModelClass element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.selectBeforeUpdatePropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(ModelClass element, global::System.Boolean newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				global::System.Boolean oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.selectBeforeUpdatePropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region Polymorphism domain property code
		
		/// <summary>
		/// Polymorphism domain property Id.
		/// </summary>
		public static readonly global::System.Guid PolymorphismDomainPropertyId = new global::System.Guid(0x5e2047eb, 0xe145, 0x40ca, 0x83, 0x80, 0xac, 0x02, 0x34, 0xe3, 0x17, 0x19);
		
		/// <summary>
		/// Storage for Polymorphism
		/// </summary>
		private Polymorphism polymorphismPropertyStorage = Polymorphism.Implicit;
		
		/// <summary>
		/// Gets or sets the value of Polymorphism domain property.
		/// Determines whether implicit or explicit query polymorphism is used.
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.ModelClass/Polymorphism.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.ModelClass/Polymorphism.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.ModelClass/Polymorphism.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[global::System.ComponentModel.DefaultValue(Polymorphism.Implicit)]
		[DslModeling::DomainObjectId("5e2047eb-e145-40ca-8380-ac0234e31719")]
		public Polymorphism Polymorphism
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return polymorphismPropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				PolymorphismPropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the ModelClass.Polymorphism domain property.
		/// </summary>
		internal sealed partial class PolymorphismPropertyHandler : DslModeling::DomainPropertyValueHandler<ModelClass, Polymorphism>
		{
			private PolymorphismPropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the ModelClass.Polymorphism domain property value handler.
			/// </summary>
			public static readonly PolymorphismPropertyHandler Instance = new PolymorphismPropertyHandler();
		
			/// <summary>
			/// Gets the Id of the ModelClass.Polymorphism domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return PolymorphismDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed Polymorphism GetValue(ModelClass element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.polymorphismPropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(ModelClass element, Polymorphism newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				Polymorphism oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.polymorphismPropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region Mutable domain property code
		
		/// <summary>
		/// Mutable domain property Id.
		/// </summary>
		public static readonly global::System.Guid MutableDomainPropertyId = new global::System.Guid(0x35f70fd2, 0x3f8e, 0x48fa, 0x9e, 0x0b, 0xb0, 0x92, 0x39, 0xaa, 0x09, 0x53);
		
		/// <summary>
		/// Storage for Mutable
		/// </summary>
		private global::System.Boolean mutablePropertyStorage = true;
		
		/// <summary>
		/// Gets or sets the value of Mutable domain property.
		/// Specifies that instances of the class are (not) mutable.
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.ModelClass/Mutable.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.ModelClass/Mutable.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.ModelClass/Mutable.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[global::System.ComponentModel.DefaultValue(true)]
		[DslModeling::DomainObjectId("35f70fd2-3f8e-48fa-9e0b-b09239aa0953")]
		public global::System.Boolean Mutable
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return mutablePropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				MutablePropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the ModelClass.Mutable domain property.
		/// </summary>
		internal sealed partial class MutablePropertyHandler : DslModeling::DomainPropertyValueHandler<ModelClass, global::System.Boolean>
		{
			private MutablePropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the ModelClass.Mutable domain property value handler.
			/// </summary>
			public static readonly MutablePropertyHandler Instance = new MutablePropertyHandler();
		
			/// <summary>
			/// Gets the Id of the ModelClass.Mutable domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return MutableDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed global::System.Boolean GetValue(ModelClass element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.mutablePropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(ModelClass element, global::System.Boolean newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				global::System.Boolean oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.mutablePropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region BatchSize domain property code
		
		/// <summary>
		/// BatchSize domain property Id.
		/// </summary>
		public static readonly global::System.Guid BatchSizeDomainPropertyId = new global::System.Guid(0x7b8bf339, 0x10c5, 0x46f8, 0x96, 0xbc, 0xbb, 0x89, 0x3d, 0x7a, 0x40, 0x4d);
		
		/// <summary>
		/// Storage for BatchSize
		/// </summary>
		private global::System.Int32 batchSizePropertyStorage = 1;
		
		/// <summary>
		/// Gets or sets the value of BatchSize domain property.
		/// Specify a "batch size" for fetching instances of this class by identifier.
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.ModelClass/BatchSize.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.ModelClass/BatchSize.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.ModelClass/BatchSize.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[global::System.ComponentModel.DefaultValue(1)]
		[DslModeling::DomainObjectId("7b8bf339-10c5-46f8-96bc-bb893d7a404d")]
		public global::System.Int32 BatchSize
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return batchSizePropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				BatchSizePropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the ModelClass.BatchSize domain property.
		/// </summary>
		internal sealed partial class BatchSizePropertyHandler : DslModeling::DomainPropertyValueHandler<ModelClass, global::System.Int32>
		{
			private BatchSizePropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the ModelClass.BatchSize domain property value handler.
			/// </summary>
			public static readonly BatchSizePropertyHandler Instance = new BatchSizePropertyHandler();
		
			/// <summary>
			/// Gets the Id of the ModelClass.BatchSize domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return BatchSizeDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed global::System.Int32 GetValue(ModelClass element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.batchSizePropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(ModelClass element, global::System.Int32 newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				global::System.Int32 oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.batchSizePropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region Locking domain property code
		
		/// <summary>
		/// Locking domain property Id.
		/// </summary>
		public static readonly global::System.Guid LockingDomainPropertyId = new global::System.Guid(0xe4844c20, 0x3d13, 0x4a57, 0x85, 0xe2, 0x40, 0x49, 0xed, 0x5f, 0xae, 0x88);
		
		/// <summary>
		/// Storage for Locking
		/// </summary>
		private OptimisticLocking lockingPropertyStorage = OptimisticLocking.Version;
		
		/// <summary>
		/// Gets or sets the value of Locking domain property.
		/// Description for Castle.ActiveWriter.ModelClass.Locking
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.ModelClass/Locking.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.ModelClass/Locking.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.ModelClass/Locking.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[global::System.ComponentModel.DefaultValue(OptimisticLocking.Version)]
		[DslModeling::DomainObjectId("e4844c20-3d13-4a57-85e2-4049ed5fae88")]
		public OptimisticLocking Locking
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return lockingPropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				LockingPropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the ModelClass.Locking domain property.
		/// </summary>
		internal sealed partial class LockingPropertyHandler : DslModeling::DomainPropertyValueHandler<ModelClass, OptimisticLocking>
		{
			private LockingPropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the ModelClass.Locking domain property value handler.
			/// </summary>
			public static readonly LockingPropertyHandler Instance = new LockingPropertyHandler();
		
			/// <summary>
			/// Gets the Id of the ModelClass.Locking domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return LockingDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed OptimisticLocking GetValue(ModelClass element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.lockingPropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(ModelClass element, OptimisticLocking newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				OptimisticLocking oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.lockingPropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region UseAutoImport domain property code
		
		/// <summary>
		/// UseAutoImport domain property Id.
		/// </summary>
		public static readonly global::System.Guid UseAutoImportDomainPropertyId = new global::System.Guid(0xbf44f952, 0xfe91, 0x4611, 0x95, 0x3a, 0xdd, 0xca, 0xea, 0xe9, 0x45, 0x8e);
		
		/// <summary>
		/// Storage for UseAutoImport
		/// </summary>
		private global::System.Boolean useAutoImportPropertyStorage = true;
		
		/// <summary>
		/// Gets or sets the value of UseAutoImport domain property.
		/// The auto-import attribute lets us use unqualified class names in the query
		/// language, by default. The assembly and namespace attributes specify the assembly
		/// where persistent classes are located and the namespace they are declared in.
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.ModelClass/UseAutoImport.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.ModelClass/UseAutoImport.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.ModelClass/UseAutoImport.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[global::System.ComponentModel.DefaultValue(true)]
		[DslModeling::DomainObjectId("bf44f952-fe91-4611-953a-ddcaeae9458e")]
		public global::System.Boolean UseAutoImport
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return useAutoImportPropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				UseAutoImportPropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the ModelClass.UseAutoImport domain property.
		/// </summary>
		internal sealed partial class UseAutoImportPropertyHandler : DslModeling::DomainPropertyValueHandler<ModelClass, global::System.Boolean>
		{
			private UseAutoImportPropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the ModelClass.UseAutoImport domain property value handler.
			/// </summary>
			public static readonly UseAutoImportPropertyHandler Instance = new UseAutoImportPropertyHandler();
		
			/// <summary>
			/// Gets the Id of the ModelClass.UseAutoImport domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return UseAutoImportDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed global::System.Boolean GetValue(ModelClass element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.useAutoImportPropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(ModelClass element, global::System.Boolean newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				global::System.Boolean oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.useAutoImportPropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region BaseClassName domain property code
		
		/// <summary>
		/// BaseClassName domain property Id.
		/// </summary>
		public static readonly global::System.Guid BaseClassNameDomainPropertyId = new global::System.Guid(0xce13decc, 0xa9da, 0x4f4a, 0xb0, 0x14, 0x7b, 0x8d, 0xe1, 0xb2, 0x6e, 0x37);
		
		/// <summary>
		/// Storage for BaseClassName
		/// </summary>
		private global::System.String baseClassNamePropertyStorage = string.Empty;
		
		/// <summary>
		/// Gets or sets the value of BaseClassName domain property.
		/// If set and if model level base class usage is set, overrides any base class
		/// defined in the model.
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.ModelClass/BaseClassName.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.ModelClass/BaseClassName.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.ModelClass/BaseClassName.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslModeling::DomainObjectId("ce13decc-a9da-4f4a-b014-7b8de1b26e37")]
		public global::System.String BaseClassName
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return baseClassNamePropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				BaseClassNamePropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the ModelClass.BaseClassName domain property.
		/// </summary>
		internal sealed partial class BaseClassNamePropertyHandler : DslModeling::DomainPropertyValueHandler<ModelClass, global::System.String>
		{
			private BaseClassNamePropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the ModelClass.BaseClassName domain property value handler.
			/// </summary>
			public static readonly BaseClassNamePropertyHandler Instance = new BaseClassNamePropertyHandler();
		
			/// <summary>
			/// Gets the Id of the ModelClass.BaseClassName domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return BaseClassNameDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed global::System.String GetValue(ModelClass element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.baseClassNamePropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(ModelClass element, global::System.String newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				global::System.String oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.baseClassNamePropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region UseGenerics domain property code
		
		/// <summary>
		/// UseGenerics domain property Id.
		/// </summary>
		public static readonly global::System.Guid UseGenericsDomainPropertyId = new global::System.Guid(0xca521240, 0x6ae4, 0x43bc, 0xa5, 0x8f, 0x6b, 0xe1, 0xb5, 0xac, 0x1b, 0x85);
		
		/// <summary>
		/// Storage for UseGenerics
		/// </summary>
		private InheritableBoolean useGenericsPropertyStorage = InheritableBoolean.Inherit;
		
		/// <summary>
		/// Gets or sets the value of UseGenerics domain property.
		/// If set (other than Inherit), overrides model level generics generation for this
		/// class.
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.ModelClass/UseGenerics.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.ModelClass/UseGenerics.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.ModelClass/UseGenerics.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[global::System.ComponentModel.DefaultValue(InheritableBoolean.Inherit)]
		[DslModeling::DomainObjectId("ca521240-6ae4-43bc-a58f-6be1b5ac1b85")]
		public InheritableBoolean UseGenerics
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return useGenericsPropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				UseGenericsPropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the ModelClass.UseGenerics domain property.
		/// </summary>
		internal sealed partial class UseGenericsPropertyHandler : DslModeling::DomainPropertyValueHandler<ModelClass, InheritableBoolean>
		{
			private UseGenericsPropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the ModelClass.UseGenerics domain property value handler.
			/// </summary>
			public static readonly UseGenericsPropertyHandler Instance = new UseGenericsPropertyHandler();
		
			/// <summary>
			/// Gets the Id of the ModelClass.UseGenerics domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return UseGenericsDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed InheritableBoolean GetValue(ModelClass element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.useGenericsPropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(ModelClass element, InheritableBoolean newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				InheritableBoolean oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.useGenericsPropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region ImplementINotifyPropertyChanged domain property code
		
		/// <summary>
		/// ImplementINotifyPropertyChanged domain property Id.
		/// </summary>
		public static readonly global::System.Guid ImplementINotifyPropertyChangedDomainPropertyId = new global::System.Guid(0x097f2266, 0xf8b4, 0x4079, 0xba, 0xfd, 0x9b, 0x16, 0xb9, 0xe8, 0xc4, 0xa3);
		
		/// <summary>
		/// Storage for ImplementINotifyPropertyChanged
		/// </summary>
		private InheritableBoolean implementINotifyPropertyChangedPropertyStorage = InheritableBoolean.Inherit;
		
		/// <summary>
		/// Gets or sets the value of ImplementINotifyPropertyChanged domain property.
		/// Instructs ActiveWriter to implement INotifyPropertyChanged interface in this
		/// class.
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.ModelClass/ImplementINotifyPropertyChanged.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.ModelClass/ImplementINotifyPropertyChanged.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.ModelClass/ImplementINotifyPropertyChanged.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[global::System.ComponentModel.DefaultValue(InheritableBoolean.Inherit)]
		[DslModeling::DomainObjectId("097f2266-f8b4-4079-bafd-9b16b9e8c4a3")]
		public InheritableBoolean ImplementINotifyPropertyChanged
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return implementINotifyPropertyChangedPropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				ImplementINotifyPropertyChangedPropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the ModelClass.ImplementINotifyPropertyChanged domain property.
		/// </summary>
		internal sealed partial class ImplementINotifyPropertyChangedPropertyHandler : DslModeling::DomainPropertyValueHandler<ModelClass, InheritableBoolean>
		{
			private ImplementINotifyPropertyChangedPropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the ModelClass.ImplementINotifyPropertyChanged domain property value handler.
			/// </summary>
			public static readonly ImplementINotifyPropertyChangedPropertyHandler Instance = new ImplementINotifyPropertyChangedPropertyHandler();
		
			/// <summary>
			/// Gets the Id of the ModelClass.ImplementINotifyPropertyChanged domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return ImplementINotifyPropertyChangedDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed InheritableBoolean GetValue(ModelClass element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.implementINotifyPropertyChangedPropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(ModelClass element, InheritableBoolean newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				InheritableBoolean oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.implementINotifyPropertyChangedPropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region UseGenericRelations domain property code
		
		/// <summary>
		/// UseGenericRelations domain property Id.
		/// </summary>
		public static readonly global::System.Guid UseGenericRelationsDomainPropertyId = new global::System.Guid(0xa176d278, 0xb7da, 0x4dc8, 0x8e, 0xbb, 0x9d, 0xb2, 0x2b, 0x96, 0xf0, 0x7f);
		
		/// <summary>
		/// Storage for UseGenericRelations
		/// </summary>
		private InheritableBoolean useGenericRelationsPropertyStorage = InheritableBoolean.Inherit;
		
		/// <summary>
		/// Gets or sets the value of UseGenericRelations domain property.
		/// If set (other than Inherit), overrides model level generic relation generation
		/// for this class.
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.ModelClass/UseGenericRelations.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.ModelClass/UseGenericRelations.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.ModelClass/UseGenericRelations.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[global::System.ComponentModel.DefaultValue(InheritableBoolean.Inherit)]
		[DslModeling::DomainObjectId("a176d278-b7da-4dc8-8ebb-9db22b96f07f")]
		public InheritableBoolean UseGenericRelations
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return useGenericRelationsPropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				UseGenericRelationsPropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the ModelClass.UseGenericRelations domain property.
		/// </summary>
		internal sealed partial class UseGenericRelationsPropertyHandler : DslModeling::DomainPropertyValueHandler<ModelClass, InheritableBoolean>
		{
			private UseGenericRelationsPropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the ModelClass.UseGenericRelations domain property value handler.
			/// </summary>
			public static readonly UseGenericRelationsPropertyHandler Instance = new UseGenericRelationsPropertyHandler();
		
			/// <summary>
			/// Gets the Id of the ModelClass.UseGenericRelations domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return UseGenericRelationsDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed InheritableBoolean GetValue(ModelClass element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.useGenericRelationsPropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(ModelClass element, InheritableBoolean newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				InheritableBoolean oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.useGenericRelationsPropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region ImplementINotifyPropertyChanging domain property code
		
		/// <summary>
		/// ImplementINotifyPropertyChanging domain property Id.
		/// </summary>
		public static readonly global::System.Guid ImplementINotifyPropertyChangingDomainPropertyId = new global::System.Guid(0xbf3cf44e, 0x39c6, 0x43ef, 0x90, 0x7d, 0x42, 0xc5, 0xde, 0x8e, 0x18, 0x48);
		
		/// <summary>
		/// Storage for ImplementINotifyPropertyChanging
		/// </summary>
		private InheritableBoolean implementINotifyPropertyChangingPropertyStorage = InheritableBoolean.Inherit;
		
		/// <summary>
		/// Gets or sets the value of ImplementINotifyPropertyChanging domain property.
		/// Instructs ActiveWriter to implement INotifyPropertyChanging interface in this
		/// class.
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.ModelClass/ImplementINotifyPropertyChanging.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.ModelClass/ImplementINotifyPropertyChanging.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.ModelClass/ImplementINotifyPropertyChanging.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[global::System.ComponentModel.DefaultValue(InheritableBoolean.Inherit)]
		[DslModeling::DomainObjectId("bf3cf44e-39c6-43ef-907d-42c5de8e1848")]
		public InheritableBoolean ImplementINotifyPropertyChanging
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return implementINotifyPropertyChangingPropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				ImplementINotifyPropertyChangingPropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the ModelClass.ImplementINotifyPropertyChanging domain property.
		/// </summary>
		internal sealed partial class ImplementINotifyPropertyChangingPropertyHandler : DslModeling::DomainPropertyValueHandler<ModelClass, InheritableBoolean>
		{
			private ImplementINotifyPropertyChangingPropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the ModelClass.ImplementINotifyPropertyChanging domain property value handler.
			/// </summary>
			public static readonly ImplementINotifyPropertyChangingPropertyHandler Instance = new ImplementINotifyPropertyChangingPropertyHandler();
		
			/// <summary>
			/// Gets the Id of the ModelClass.ImplementINotifyPropertyChanging domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return ImplementINotifyPropertyChangingDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed InheritableBoolean GetValue(ModelClass element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.implementINotifyPropertyChangingPropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(ModelClass element, InheritableBoolean newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				InheritableBoolean oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.implementINotifyPropertyChangingPropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region Model opposite domain role accessor
		/// <summary>
		/// Gets or sets Model.
		/// Model of the class
		/// </summary>
		public virtual Model Model
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return DslModeling::DomainRoleInfo.GetLinkedElement(this, global::Castle.ActiveWriter.ModelHasClass.ClassDomainRoleId) as Model;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				DslModeling::DomainRoleInfo.SetLinkedElement(this, global::Castle.ActiveWriter.ModelHasClass.ClassDomainRoleId, value);
			}
		}
		#endregion
		#region Targets opposite domain role accessor
		
		/// <summary>
		/// Gets a list of Targets.
		/// </summary>
		public virtual DslModeling::LinkedElementCollection<ModelClass> Targets
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return GetRoleCollection<DslModeling::LinkedElementCollection<ModelClass>, ModelClass>(global::Castle.ActiveWriter.ManyToOneRelation.SourceDomainRoleId);
			}
		}
		#endregion
		#region Sources opposite domain role accessor
		
		/// <summary>
		/// Gets a list of Sources.
		/// </summary>
		public virtual DslModeling::LinkedElementCollection<ModelClass> Sources
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return GetRoleCollection<DslModeling::LinkedElementCollection<ModelClass>, ModelClass>(global::Castle.ActiveWriter.ManyToOneRelation.TargetDomainRoleId);
			}
		}
		#endregion
		#region Properties opposite domain role accessor
		
		/// <summary>
		/// Gets a list of Properties.
		/// </summary>
		public virtual DslModeling::LinkedElementCollection<ModelProperty> Properties
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return GetRoleCollection<DslModeling::LinkedElementCollection<ModelProperty>, ModelProperty>(global::Castle.ActiveWriter.ClassHasProperty.ModelClassDomainRoleId);
			}
		}
		#endregion
		#region ManyToManyTargets opposite domain role accessor
		
		/// <summary>
		/// Gets a list of ManyToManyTargets.
		/// </summary>
		public virtual DslModeling::LinkedElementCollection<ModelClass> ManyToManyTargets
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return GetRoleCollection<DslModeling::LinkedElementCollection<ModelClass>, ModelClass>(global::Castle.ActiveWriter.ManyToManyRelation.SourceDomainRoleId);
			}
		}
		#endregion
		#region ManyToManySources opposite domain role accessor
		
		/// <summary>
		/// Gets a list of ManyToManySources.
		/// </summary>
		public virtual DslModeling::LinkedElementCollection<ModelClass> ManyToManySources
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return GetRoleCollection<DslModeling::LinkedElementCollection<ModelClass>, ModelClass>(global::Castle.ActiveWriter.ManyToManyRelation.TargetDomainRoleId);
			}
		}
		#endregion
		#region OneToOneTarget opposite domain role accessor
		/// <summary>
		/// Gets or sets OneToOneTarget.
		/// </summary>
		public virtual ModelClass OneToOneTarget
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return DslModeling::DomainRoleInfo.GetLinkedElement(this, global::Castle.ActiveWriter.OneToOneRelation.SourceDomainRoleId) as ModelClass;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				DslModeling::DomainRoleInfo.SetLinkedElement(this, global::Castle.ActiveWriter.OneToOneRelation.SourceDomainRoleId, value);
			}
		}
		#endregion
		#region OneToOneSources opposite domain role accessor
		
		/// <summary>
		/// Gets a list of OneToOneSources.
		/// </summary>
		public virtual DslModeling::LinkedElementCollection<ModelClass> OneToOneSources
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return GetRoleCollection<DslModeling::LinkedElementCollection<ModelClass>, ModelClass>(global::Castle.ActiveWriter.OneToOneRelation.TargetDomainRoleId);
			}
		}
		#endregion
		#region NestedClasses opposite domain role accessor
		
		/// <summary>
		/// Gets a list of NestedClasses.
		/// Description for Castle.ActiveWriter.NestedClassReferencesModelClasses.ModelClass
		/// </summary>
		public virtual DslModeling::LinkedElementCollection<NestedClass> NestedClasses
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return GetRoleCollection<DslModeling::LinkedElementCollection<NestedClass>, NestedClass>(global::Castle.ActiveWriter.NestedClassReferencesModelClasses.ModelClassDomainRoleId);
			}
		}
		#endregion
		#region TargetModelClasses opposite domain role accessor
		
		/// <summary>
		/// Gets a list of TargetModelClasses.
		/// Description for Castle.ActiveWriter.InheritanceRelation.SourceModelClass
		/// </summary>
		public virtual DslModeling::LinkedElementCollection<ModelClass> TargetModelClasses
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return GetRoleCollection<DslModeling::LinkedElementCollection<ModelClass>, ModelClass>(global::Castle.ActiveWriter.InheritanceRelation.SourceModelClassDomainRoleId);
			}
		}
		#endregion
		#region SourceModelClasses opposite domain role accessor
		
		/// <summary>
		/// Gets a list of SourceModelClasses.
		/// Description for Castle.ActiveWriter.InheritanceRelation.TargetModelClass
		/// </summary>
		public virtual DslModeling::LinkedElementCollection<ModelClass> SourceModelClasses
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return GetRoleCollection<DslModeling::LinkedElementCollection<ModelClass>, ModelClass>(global::Castle.ActiveWriter.InheritanceRelation.TargetModelClassDomainRoleId);
			}
		}
		#endregion
		#region ElementGroupPrototype Merge methods
		/// <summary>
		/// Returns a value indicating whether the source element represented by the
		/// specified root ProtoElement can be added to this element.
		/// </summary>
		/// <param name="rootElement">
		/// The root ProtoElement representing a source element.  This can be null, 
		/// in which case the ElementGroupPrototype does not contain an ProtoElements
		/// and the code should inspect the ElementGroupPrototype context information.
		/// </param>
		/// <param name="elementGroupPrototype">The ElementGroupPrototype that contains the root ProtoElement.</param>
		/// <returns>true if the source element represented by the ProtoElement can be added to this target element.</returns>
		protected override bool CanMerge(DslModeling::ProtoElementBase rootElement, DslModeling::ElementGroupPrototype elementGroupPrototype)
		{
			if ( elementGroupPrototype == null ) throw new global::System.ArgumentNullException("elementGroupPrototype");
			
			if (rootElement != null)
			{
				DslModeling::DomainClassInfo rootElementDomainInfo = Partition.DomainDataDirectory.GetDomainClass(rootElement.DomainClassId);
				
				if (rootElementDomainInfo.IsDerivedFrom(global::Castle.ActiveWriter.ModelProperty.DomainClassId)) 
				{
					return true;
				}
			}
			return base.CanMerge(rootElement, elementGroupPrototype);
		}
		
		/// <summary>
		/// Called by the Merge process to create a relationship between 
		/// this target element and the specified source element. 
		/// Typically, a parent-child relationship is established
		/// between the target element (the parent) and the source element 
		/// (the child), but any relationship can be established.
		/// </summary>
		/// <param name="sourceElement">The element that is to be related to this model element.</param>
		/// <param name="elementGroup">The group of source ModelElements that have been rehydrated into the target store.</param>
		/// <remarks>
		/// This method is overriden to create the relationship between the target element and the specified source element.
		/// The base method does nothing.
		/// </remarks>
		protected override void MergeRelate(DslModeling::ModelElement sourceElement, DslModeling::ElementGroup elementGroup)
		{
			// In general, sourceElement is allowed to be null, meaning that the elementGroup must be parsed for special cases.
			// However this is not supported in generated code.  Use double-deriving on this class and then override MergeRelate completely if you 
			// need to support this case.
			if ( sourceElement == null ) throw new global::System.ArgumentNullException("sourceElement");
		
				
			global::Castle.ActiveWriter.ModelProperty sourceModelProperty1 = sourceElement as global::Castle.ActiveWriter.ModelProperty;
			if (sourceModelProperty1 != null)
			{
				// Create link for path ClassHasProperty.Properties
				Properties.Add(sourceModelProperty1);

				return;
			}
		
			// Sdk workaround to runtime bug #879350 (DSL: can't copy and paste a MEL that has a MEX). Avoid MergeRelate on ModelElementExtension
			// during a "Paste".
			if (sourceElement is DslModeling::ExtensionElement
				&& sourceElement.Store.TransactionManager.CurrentTransaction.TopLevelTransaction.Context.ContextInfo.ContainsKey("{9DAFD42A-DC0E-4d78-8C3F-8266B2CF8B33}"))
			{
				return;
			}
		
			// Fall through to base class if this class hasn't handled the merge.
			base.MergeRelate(sourceElement, elementGroup);
		}
		
		/// <summary>
		/// Performs operation opposite to MergeRelate - i.e. disconnects a given
		/// element from the current one (removes links created by MergeRelate).
		/// </summary>
		/// <param name="sourceElement">Element to be unmerged/disconnected.</param>
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
		protected override void MergeDisconnect(DslModeling::ModelElement sourceElement)
		{
			if (sourceElement == null) throw new global::System.ArgumentNullException("sourceElement");
				
			global::Castle.ActiveWriter.ModelProperty sourceModelProperty1 = sourceElement as global::Castle.ActiveWriter.ModelProperty;
			if (sourceModelProperty1 != null)
			{
				// Delete link for path ClassHasProperty.Properties
				
				foreach (DslModeling::ElementLink link in global::Castle.ActiveWriter.ClassHasProperty.GetLinks((global::Castle.ActiveWriter.ModelClass)this, sourceModelProperty1))
				{
					// Delete the link, but without possible delete propagation to the element since it's moving to a new location.
					link.Delete(global::Castle.ActiveWriter.ClassHasProperty.ModelClassDomainRoleId, global::Castle.ActiveWriter.ClassHasProperty.PropertyDomainRoleId);
				}

				return;
			}
			// Fall through to base class if this class hasn't handled the unmerge.
			base.MergeDisconnect(sourceElement);
		}
		#endregion
	}
}
namespace Castle.ActiveWriter
{
	/// <summary>
	/// DomainClass ModelProperty
	/// A property or field of a class
	/// </summary>
	[DslDesign::DisplayNameResource("Castle.ActiveWriter.ModelProperty.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
	[DslDesign::DescriptionResource("Castle.ActiveWriter.ModelProperty.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
	[DslModeling::DomainModelOwner(typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel))]
	[global::System.CLSCompliant(true)]
	[DslModeling::DomainObjectId("03f30fca-953c-4ab2-b3e4-956a355e0768")]
	public partial class ModelProperty : ModelElementWithAccess
	{
		#region Constructors, domain class Id
	
		/// <summary>
		/// ModelProperty domain class Id.
		/// </summary>
		public static readonly new global::System.Guid DomainClassId = new global::System.Guid(0x03f30fca, 0x953c, 0x4ab2, 0xb3, 0xe4, 0x95, 0x6a, 0x35, 0x5e, 0x07, 0x68);
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="store">Store where new element is to be created.</param>
		/// <param name="propertyAssignments">List of domain property id/value pairs to set once the element is created.</param>
		public ModelProperty(DslModeling::Store store, params DslModeling::PropertyAssignment[] propertyAssignments)
			: this(store != null ? store.DefaultPartitionForClass(DomainClassId) : null, propertyAssignments)
		{
		}
		
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="partition">Partition where new element is to be created.</param>
		/// <param name="propertyAssignments">List of domain property id/value pairs to set once the element is created.</param>
		public ModelProperty(DslModeling::Partition partition, params DslModeling::PropertyAssignment[] propertyAssignments)
			: base(partition, propertyAssignments)
		{
		}
		#endregion
		#region Column domain property code
		
		/// <summary>
		/// Column domain property Id.
		/// </summary>
		public static readonly global::System.Guid ColumnDomainPropertyId = new global::System.Guid(0x37bf5f3f, 0x4a5b, 0x4b1d, 0x80, 0x2b, 0xa6, 0x40, 0x13, 0x24, 0xf1, 0x3f);
		
		/// <summary>
		/// Storage for Column
		/// </summary>
		private global::System.String columnPropertyStorage = string.Empty;
		
		/// <summary>
		/// Gets or sets the value of Column domain property.
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.ModelProperty/Column.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.ModelProperty/Column.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.ModelProperty/Column.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslModeling::DomainObjectId("37bf5f3f-4a5b-4b1d-802b-a6401324f13f")]
		public global::System.String Column
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return columnPropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				ColumnPropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the ModelProperty.Column domain property.
		/// </summary>
		internal sealed partial class ColumnPropertyHandler : DslModeling::DomainPropertyValueHandler<ModelProperty, global::System.String>
		{
			private ColumnPropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the ModelProperty.Column domain property value handler.
			/// </summary>
			public static readonly ColumnPropertyHandler Instance = new ColumnPropertyHandler();
		
			/// <summary>
			/// Gets the Id of the ModelProperty.Column domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return ColumnDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed global::System.String GetValue(ModelProperty element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.columnPropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(ModelProperty element, global::System.String newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				global::System.String oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.columnPropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region ColumnType domain property code
		
		/// <summary>
		/// ColumnType domain property Id.
		/// </summary>
		public static readonly global::System.Guid ColumnTypeDomainPropertyId = new global::System.Guid(0xe0dd7a3b, 0x0ec5, 0x4b7e, 0x9e, 0x50, 0x44, 0x14, 0x11, 0x67, 0xb5, 0xae);
		
		/// <summary>
		/// Storage for ColumnType
		/// </summary>
		private NHibernateType columnTypePropertyStorage = NHibernateType.String;
		
		/// <summary>
		/// Gets or sets the value of ColumnType domain property.
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.ModelProperty/ColumnType.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.ModelProperty/ColumnType.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.ModelProperty/ColumnType.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[global::System.ComponentModel.DefaultValue(NHibernateType.String)]
		[DslModeling::DomainObjectId("e0dd7a3b-0ec5-4b7e-9e50-44141167b5ae")]
		public NHibernateType ColumnType
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return columnTypePropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				ColumnTypePropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the ModelProperty.ColumnType domain property.
		/// </summary>
		internal sealed partial class ColumnTypePropertyHandler : DslModeling::DomainPropertyValueHandler<ModelProperty, NHibernateType>
		{
			private ColumnTypePropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the ModelProperty.ColumnType domain property value handler.
			/// </summary>
			public static readonly ColumnTypePropertyHandler Instance = new ColumnTypePropertyHandler();
		
			/// <summary>
			/// Gets the Id of the ModelProperty.ColumnType domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return ColumnTypeDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed NHibernateType GetValue(ModelProperty element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.columnTypePropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(ModelProperty element, NHibernateType newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				NHibernateType oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.columnTypePropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region CustomColumnType domain property code
		
		/// <summary>
		/// CustomColumnType domain property Id.
		/// </summary>
		public static readonly global::System.Guid CustomColumnTypeDomainPropertyId = new global::System.Guid(0x3b717093, 0x4359, 0x4eef, 0x8d, 0x1f, 0x42, 0xbf, 0xb1, 0x38, 0x4a, 0xf6);
		
		/// <summary>
		/// Storage for CustomColumnType
		/// </summary>
		private global::System.String customColumnTypePropertyStorage = string.Empty;
		
		/// <summary>
		/// Gets or sets the value of CustomColumnType domain property.
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.ModelProperty/CustomColumnType.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.ModelProperty/CustomColumnType.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.ModelProperty/CustomColumnType.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[global::System.ComponentModel.DefaultValue("")]
		[DslModeling::DomainObjectId("3b717093-4359-4eef-8d1f-42bfb1384af6")]
		public global::System.String CustomColumnType
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return customColumnTypePropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				CustomColumnTypePropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the ModelProperty.CustomColumnType domain property.
		/// </summary>
		internal sealed partial class CustomColumnTypePropertyHandler : DslModeling::DomainPropertyValueHandler<ModelProperty, global::System.String>
		{
			private CustomColumnTypePropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the ModelProperty.CustomColumnType domain property value handler.
			/// </summary>
			public static readonly CustomColumnTypePropertyHandler Instance = new CustomColumnTypePropertyHandler();
		
			/// <summary>
			/// Gets the Id of the ModelProperty.CustomColumnType domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return CustomColumnTypeDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed global::System.String GetValue(ModelProperty element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.customColumnTypePropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(ModelProperty element, global::System.String newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				global::System.String oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.customColumnTypePropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region CustomMemberType domain property code
		
		/// <summary>
		/// CustomMemberType domain property Id.
		/// </summary>
		public static readonly global::System.Guid CustomMemberTypeDomainPropertyId = new global::System.Guid(0xb06eb038, 0xc800, 0x4217, 0xbd, 0x0e, 0xe2, 0xb0, 0x0b, 0x15, 0x71, 0x32);
		
		/// <summary>
		/// Storage for CustomMemberType
		/// </summary>
		private global::System.String customMemberTypePropertyStorage = string.Empty;
		
		/// <summary>
		/// Gets or sets the value of CustomMemberType domain property.
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.ModelProperty/CustomMemberType.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.ModelProperty/CustomMemberType.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.ModelProperty/CustomMemberType.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[global::System.ComponentModel.DefaultValue("")]
		[DslModeling::DomainObjectId("b06eb038-c800-4217-bd0e-e2b00b157132")]
		public global::System.String CustomMemberType
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return customMemberTypePropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				CustomMemberTypePropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the ModelProperty.CustomMemberType domain property.
		/// </summary>
		internal sealed partial class CustomMemberTypePropertyHandler : DslModeling::DomainPropertyValueHandler<ModelProperty, global::System.String>
		{
			private CustomMemberTypePropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the ModelProperty.CustomMemberType domain property value handler.
			/// </summary>
			public static readonly CustomMemberTypePropertyHandler Instance = new CustomMemberTypePropertyHandler();
		
			/// <summary>
			/// Gets the Id of the ModelProperty.CustomMemberType domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return CustomMemberTypeDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed global::System.String GetValue(ModelProperty element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.customMemberTypePropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(ModelProperty element, global::System.String newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				global::System.String oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.customMemberTypePropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region Formula domain property code
		
		/// <summary>
		/// Formula domain property Id.
		/// </summary>
		public static readonly global::System.Guid FormulaDomainPropertyId = new global::System.Guid(0x5389a767, 0x406a, 0x408c, 0x9b, 0x0c, 0x87, 0x72, 0x48, 0xab, 0xb6, 0x96);
		
		/// <summary>
		/// Storage for Formula
		/// </summary>
		private global::System.String formulaPropertyStorage = string.Empty;
		
		/// <summary>
		/// Gets or sets the value of Formula domain property.
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.ModelProperty/Formula.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.ModelProperty/Formula.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.ModelProperty/Formula.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslModeling::DomainObjectId("5389a767-406a-408c-9b0c-877248abb696")]
		public global::System.String Formula
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return formulaPropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				FormulaPropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the ModelProperty.Formula domain property.
		/// </summary>
		internal sealed partial class FormulaPropertyHandler : DslModeling::DomainPropertyValueHandler<ModelProperty, global::System.String>
		{
			private FormulaPropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the ModelProperty.Formula domain property value handler.
			/// </summary>
			public static readonly FormulaPropertyHandler Instance = new FormulaPropertyHandler();
		
			/// <summary>
			/// Gets the Id of the ModelProperty.Formula domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return FormulaDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed global::System.String GetValue(ModelProperty element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.formulaPropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(ModelProperty element, global::System.String newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				global::System.String oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.formulaPropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region Insert domain property code
		
		/// <summary>
		/// Insert domain property Id.
		/// </summary>
		public static readonly global::System.Guid InsertDomainPropertyId = new global::System.Guid(0x667f32aa, 0x4de5, 0x4f88, 0x9e, 0x3c, 0xa9, 0xf3, 0xe5, 0x19, 0x08, 0x21);
		
		/// <summary>
		/// Storage for Insert
		/// </summary>
		private global::System.Boolean insertPropertyStorage = true;
		
		/// <summary>
		/// Gets or sets the value of Insert domain property.
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.ModelProperty/Insert.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.ModelProperty/Insert.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.ModelProperty/Insert.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[global::System.ComponentModel.DefaultValue(true)]
		[DslModeling::DomainObjectId("667f32aa-4de5-4f88-9e3c-a9f3e5190821")]
		public global::System.Boolean Insert
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return insertPropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				InsertPropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the ModelProperty.Insert domain property.
		/// </summary>
		internal sealed partial class InsertPropertyHandler : DslModeling::DomainPropertyValueHandler<ModelProperty, global::System.Boolean>
		{
			private InsertPropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the ModelProperty.Insert domain property value handler.
			/// </summary>
			public static readonly InsertPropertyHandler Instance = new InsertPropertyHandler();
		
			/// <summary>
			/// Gets the Id of the ModelProperty.Insert domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return InsertDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed global::System.Boolean GetValue(ModelProperty element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.insertPropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(ModelProperty element, global::System.Boolean newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				global::System.Boolean oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.insertPropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region Length domain property code
		
		/// <summary>
		/// Length domain property Id.
		/// </summary>
		public static readonly global::System.Guid LengthDomainPropertyId = new global::System.Guid(0xc34e5c57, 0x2cee, 0x46ca, 0xb5, 0x59, 0x91, 0xa7, 0x73, 0x81, 0x19, 0x39);
		
		/// <summary>
		/// Storage for Length
		/// </summary>
		private global::System.Int32 lengthPropertyStorage;
		
		/// <summary>
		/// Gets or sets the value of Length domain property.
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.ModelProperty/Length.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.ModelProperty/Length.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.ModelProperty/Length.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslModeling::DomainObjectId("c34e5c57-2cee-46ca-b559-91a773811939")]
		public global::System.Int32 Length
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return lengthPropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				LengthPropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the ModelProperty.Length domain property.
		/// </summary>
		internal sealed partial class LengthPropertyHandler : DslModeling::DomainPropertyValueHandler<ModelProperty, global::System.Int32>
		{
			private LengthPropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the ModelProperty.Length domain property value handler.
			/// </summary>
			public static readonly LengthPropertyHandler Instance = new LengthPropertyHandler();
		
			/// <summary>
			/// Gets the Id of the ModelProperty.Length domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return LengthDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed global::System.Int32 GetValue(ModelProperty element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.lengthPropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(ModelProperty element, global::System.Int32 newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				global::System.Int32 oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.lengthPropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region NotNull domain property code
		
		/// <summary>
		/// NotNull domain property Id.
		/// </summary>
		public static readonly global::System.Guid NotNullDomainPropertyId = new global::System.Guid(0xab4fe9fd, 0xd71b, 0x4aec, 0x98, 0x1e, 0x76, 0x31, 0xbd, 0x7c, 0x9b, 0x06);
		
		/// <summary>
		/// Storage for NotNull
		/// </summary>
		private global::System.Boolean notNullPropertyStorage;
		
		/// <summary>
		/// Gets or sets the value of NotNull domain property.
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.ModelProperty/NotNull.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.ModelProperty/NotNull.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.ModelProperty/NotNull.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslModeling::DomainObjectId("ab4fe9fd-d71b-4aec-981e-7631bd7c9b06")]
		public global::System.Boolean NotNull
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return notNullPropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				NotNullPropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the ModelProperty.NotNull domain property.
		/// </summary>
		internal sealed partial class NotNullPropertyHandler : DslModeling::DomainPropertyValueHandler<ModelProperty, global::System.Boolean>
		{
			private NotNullPropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the ModelProperty.NotNull domain property value handler.
			/// </summary>
			public static readonly NotNullPropertyHandler Instance = new NotNullPropertyHandler();
		
			/// <summary>
			/// Gets the Id of the ModelProperty.NotNull domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return NotNullDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed global::System.Boolean GetValue(ModelProperty element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.notNullPropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(ModelProperty element, global::System.Boolean newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				global::System.Boolean oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.notNullPropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region Unique domain property code
		
		/// <summary>
		/// Unique domain property Id.
		/// </summary>
		public static readonly global::System.Guid UniqueDomainPropertyId = new global::System.Guid(0x29082743, 0xd810, 0x4131, 0x88, 0xa6, 0xed, 0x6b, 0x7e, 0xc2, 0x09, 0xce);
		
		/// <summary>
		/// Storage for Unique
		/// </summary>
		private global::System.Boolean uniquePropertyStorage;
		
		/// <summary>
		/// Gets or sets the value of Unique domain property.
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.ModelProperty/Unique.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.ModelProperty/Unique.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.ModelProperty/Unique.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslModeling::DomainObjectId("29082743-d810-4131-88a6-ed6b7ec209ce")]
		public global::System.Boolean Unique
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return uniquePropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				UniquePropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the ModelProperty.Unique domain property.
		/// </summary>
		internal sealed partial class UniquePropertyHandler : DslModeling::DomainPropertyValueHandler<ModelProperty, global::System.Boolean>
		{
			private UniquePropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the ModelProperty.Unique domain property value handler.
			/// </summary>
			public static readonly UniquePropertyHandler Instance = new UniquePropertyHandler();
		
			/// <summary>
			/// Gets the Id of the ModelProperty.Unique domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return UniqueDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed global::System.Boolean GetValue(ModelProperty element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.uniquePropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(ModelProperty element, global::System.Boolean newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				global::System.Boolean oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.uniquePropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region UnsavedValue domain property code
		
		/// <summary>
		/// UnsavedValue domain property Id.
		/// </summary>
		public static readonly global::System.Guid UnsavedValueDomainPropertyId = new global::System.Guid(0x85b4e54d, 0x4986, 0x463a, 0xa7, 0xe2, 0xb1, 0x57, 0x58, 0xaf, 0x79, 0xaa);
		
		/// <summary>
		/// Storage for UnsavedValue
		/// </summary>
		private global::System.String unsavedValuePropertyStorage = string.Empty;
		
		/// <summary>
		/// Gets or sets the value of UnsavedValue domain property.
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.ModelProperty/UnsavedValue.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.ModelProperty/UnsavedValue.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.ModelProperty/UnsavedValue.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslModeling::DomainObjectId("85b4e54d-4986-463a-a7e2-b15758af79aa")]
		public global::System.String UnsavedValue
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return unsavedValuePropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				UnsavedValuePropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the ModelProperty.UnsavedValue domain property.
		/// </summary>
		internal sealed partial class UnsavedValuePropertyHandler : DslModeling::DomainPropertyValueHandler<ModelProperty, global::System.String>
		{
			private UnsavedValuePropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the ModelProperty.UnsavedValue domain property value handler.
			/// </summary>
			public static readonly UnsavedValuePropertyHandler Instance = new UnsavedValuePropertyHandler();
		
			/// <summary>
			/// Gets the Id of the ModelProperty.UnsavedValue domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return UnsavedValueDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed global::System.String GetValue(ModelProperty element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.unsavedValuePropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(ModelProperty element, global::System.String newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				global::System.String oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.unsavedValuePropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region Update domain property code
		
		/// <summary>
		/// Update domain property Id.
		/// </summary>
		public static readonly global::System.Guid UpdateDomainPropertyId = new global::System.Guid(0xf404d3e6, 0x4cd2, 0x48e0, 0xbb, 0x8f, 0x17, 0x80, 0x86, 0x52, 0x44, 0xa2);
		
		/// <summary>
		/// Storage for Update
		/// </summary>
		private global::System.Boolean updatePropertyStorage = true;
		
		/// <summary>
		/// Gets or sets the value of Update domain property.
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.ModelProperty/Update.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.ModelProperty/Update.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.ModelProperty/Update.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[global::System.ComponentModel.DefaultValue(true)]
		[DslModeling::DomainObjectId("f404d3e6-4cd2-48e0-bb8f-1780865244a2")]
		public global::System.Boolean Update
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return updatePropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				UpdatePropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the ModelProperty.Update domain property.
		/// </summary>
		internal sealed partial class UpdatePropertyHandler : DslModeling::DomainPropertyValueHandler<ModelProperty, global::System.Boolean>
		{
			private UpdatePropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the ModelProperty.Update domain property value handler.
			/// </summary>
			public static readonly UpdatePropertyHandler Instance = new UpdatePropertyHandler();
		
			/// <summary>
			/// Gets the Id of the ModelProperty.Update domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return UpdateDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed global::System.Boolean GetValue(ModelProperty element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.updatePropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(ModelProperty element, global::System.Boolean newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				global::System.Boolean oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.updatePropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region Generator domain property code
		
		/// <summary>
		/// Generator domain property Id.
		/// </summary>
		public static readonly global::System.Guid GeneratorDomainPropertyId = new global::System.Guid(0xfab33357, 0x7061, 0x42bc, 0xb5, 0xa5, 0x52, 0x38, 0xcb, 0x8a, 0xe4, 0xa9);
		
		/// <summary>
		/// Storage for Generator
		/// </summary>
		private PrimaryKeyType generatorPropertyStorage = PrimaryKeyType.Native;
		
		/// <summary>
		/// Gets or sets the value of Generator domain property.
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.ModelProperty/Generator.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.ModelProperty/Generator.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.ModelProperty/Generator.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[global::System.ComponentModel.DefaultValue(PrimaryKeyType.Native)]
		[DslModeling::DomainObjectId("fab33357-7061-42bc-b5a5-5238cb8ae4a9")]
		public PrimaryKeyType Generator
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return generatorPropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				GeneratorPropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the ModelProperty.Generator domain property.
		/// </summary>
		internal sealed partial class GeneratorPropertyHandler : DslModeling::DomainPropertyValueHandler<ModelProperty, PrimaryKeyType>
		{
			private GeneratorPropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the ModelProperty.Generator domain property value handler.
			/// </summary>
			public static readonly GeneratorPropertyHandler Instance = new GeneratorPropertyHandler();
		
			/// <summary>
			/// Gets the Id of the ModelProperty.Generator domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return GeneratorDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed PrimaryKeyType GetValue(ModelProperty element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.generatorPropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(ModelProperty element, PrimaryKeyType newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				PrimaryKeyType oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.generatorPropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region KeyType domain property code
		
		/// <summary>
		/// KeyType domain property Id.
		/// </summary>
		public static readonly global::System.Guid KeyTypeDomainPropertyId = new global::System.Guid(0x04023409, 0xcb73, 0x4f64, 0xae, 0x64, 0x3e, 0x1f, 0xbb, 0xcb, 0x0e, 0xc1);
		
		/// <summary>
		/// Storage for KeyType
		/// </summary>
		private KeyType keyTypePropertyStorage = KeyType.None;
		
		/// <summary>
		/// Gets or sets the value of KeyType domain property.
		/// Denotes if the property is a normal property, a key or part of of a primary key.
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.ModelProperty/KeyType.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.ModelProperty/KeyType.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.ModelProperty/KeyType.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[global::System.ComponentModel.DefaultValue(KeyType.None)]
		[DslModeling::DomainObjectId("04023409-cb73-4f64-ae64-3e1fbbcb0ec1")]
		public KeyType KeyType
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return keyTypePropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				KeyTypePropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the ModelProperty.KeyType domain property.
		/// </summary>
		internal sealed partial class KeyTypePropertyHandler : DslModeling::DomainPropertyValueHandler<ModelProperty, KeyType>
		{
			private KeyTypePropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the ModelProperty.KeyType domain property value handler.
			/// </summary>
			public static readonly KeyTypePropertyHandler Instance = new KeyTypePropertyHandler();
		
			/// <summary>
			/// Gets the Id of the ModelProperty.KeyType domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return KeyTypeDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed KeyType GetValue(ModelProperty element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.keyTypePropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(ModelProperty element, KeyType newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				KeyType oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.keyTypePropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region Params domain property code
		
		/// <summary>
		/// Params domain property Id.
		/// </summary>
		public static readonly global::System.Guid ParamsDomainPropertyId = new global::System.Guid(0x1a3c7764, 0xdb0d, 0x4bcf, 0xbf, 0x5d, 0xdd, 0xe0, 0xad, 0xa9, 0x8f, 0x3d);
		
		/// <summary>
		/// Storage for Params
		/// </summary>
		private global::System.String paramsPropertyStorage = string.Empty;
		
		/// <summary>
		/// Gets or sets the value of Params domain property.
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.ModelProperty/Params.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.ModelProperty/Params.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.ModelProperty/Params.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslModeling::DomainObjectId("1a3c7764-db0d-4bcf-bf5d-dde0ada98f3d")]
		public global::System.String Params
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return paramsPropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				ParamsPropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the ModelProperty.Params domain property.
		/// </summary>
		internal sealed partial class ParamsPropertyHandler : DslModeling::DomainPropertyValueHandler<ModelProperty, global::System.String>
		{
			private ParamsPropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the ModelProperty.Params domain property value handler.
			/// </summary>
			public static readonly ParamsPropertyHandler Instance = new ParamsPropertyHandler();
		
			/// <summary>
			/// Gets the Id of the ModelProperty.Params domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return ParamsDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed global::System.String GetValue(ModelProperty element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.paramsPropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(ModelProperty element, global::System.String newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				global::System.String oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.paramsPropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region SequenceName domain property code
		
		/// <summary>
		/// SequenceName domain property Id.
		/// </summary>
		public static readonly global::System.Guid SequenceNameDomainPropertyId = new global::System.Guid(0x0fd9ef70, 0x8f0b, 0x4d4d, 0xbf, 0x84, 0xd0, 0xdf, 0x06, 0x2d, 0x76, 0x3a);
		
		/// <summary>
		/// Storage for SequenceName
		/// </summary>
		private global::System.String sequenceNamePropertyStorage = string.Empty;
		
		/// <summary>
		/// Gets or sets the value of SequenceName domain property.
		/// Name of the sequence to be used for the primary key. Required when Generator is
		/// Sequence.
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.ModelProperty/SequenceName.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.ModelProperty/SequenceName.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.ModelProperty/SequenceName.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslModeling::DomainObjectId("0fd9ef70-8f0b-4d4d-bf84-d0df062d763a")]
		public global::System.String SequenceName
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return sequenceNamePropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				SequenceNamePropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the ModelProperty.SequenceName domain property.
		/// </summary>
		internal sealed partial class SequenceNamePropertyHandler : DslModeling::DomainPropertyValueHandler<ModelProperty, global::System.String>
		{
			private SequenceNamePropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the ModelProperty.SequenceName domain property value handler.
			/// </summary>
			public static readonly SequenceNamePropertyHandler Instance = new SequenceNamePropertyHandler();
		
			/// <summary>
			/// Gets the Id of the ModelProperty.SequenceName domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return SequenceNameDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed global::System.String GetValue(ModelProperty element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.sequenceNamePropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(ModelProperty element, global::System.String newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				global::System.String oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.sequenceNamePropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region Accessor domain property code
		
		/// <summary>
		/// Accessor domain property Id.
		/// </summary>
		public static readonly global::System.Guid AccessorDomainPropertyId = new global::System.Guid(0x2f3d7c02, 0xf986, 0x4d98, 0x9e, 0x1d, 0xfa, 0xdf, 0xa5, 0x21, 0xdb, 0xd2);
		
		/// <summary>
		/// Storage for Accessor
		/// </summary>
		private Accessor accessorPropertyStorage = Accessor.Public;
		
		/// <summary>
		/// Gets or sets the value of Accessor domain property.
		/// Accessor of the property.
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.ModelProperty/Accessor.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.ModelProperty/Accessor.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.ModelProperty/Accessor.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[global::System.ComponentModel.DefaultValue(Accessor.Public)]
		[DslModeling::DomainObjectId("2f3d7c02-f986-4d98-9e1d-fadfa521dbd2")]
		public Accessor Accessor
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return accessorPropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				AccessorPropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the ModelProperty.Accessor domain property.
		/// </summary>
		internal sealed partial class AccessorPropertyHandler : DslModeling::DomainPropertyValueHandler<ModelProperty, Accessor>
		{
			private AccessorPropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the ModelProperty.Accessor domain property value handler.
			/// </summary>
			public static readonly AccessorPropertyHandler Instance = new AccessorPropertyHandler();
		
			/// <summary>
			/// Gets the Id of the ModelProperty.Accessor domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return AccessorDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed Accessor GetValue(ModelProperty element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.accessorPropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(ModelProperty element, Accessor newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				Accessor oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.accessorPropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region CompositeKeyName domain property code
		
		/// <summary>
		/// CompositeKeyName domain property Id.
		/// </summary>
		public static readonly global::System.Guid CompositeKeyNameDomainPropertyId = new global::System.Guid(0x74868328, 0x9484, 0x406e, 0x94, 0xbe, 0xd6, 0xa8, 0x5d, 0x8a, 0x28, 0xc7);
		
		/// <summary>
		/// Storage for CompositeKeyName
		/// </summary>
		private global::System.String compositeKeyNamePropertyStorage = string.Empty;
		
		/// <summary>
		/// Gets or sets the value of CompositeKeyName domain property.
		/// Name of the composite key class to be generated.
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.ModelProperty/CompositeKeyName.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.ModelProperty/CompositeKeyName.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.ModelProperty/CompositeKeyName.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslModeling::DomainObjectId("74868328-9484-406e-94be-d6a85d8a28c7")]
		public global::System.String CompositeKeyName
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return compositeKeyNamePropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				CompositeKeyNamePropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the ModelProperty.CompositeKeyName domain property.
		/// </summary>
		internal sealed partial class CompositeKeyNamePropertyHandler : DslModeling::DomainPropertyValueHandler<ModelProperty, global::System.String>
		{
			private CompositeKeyNamePropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the ModelProperty.CompositeKeyName domain property value handler.
			/// </summary>
			public static readonly CompositeKeyNamePropertyHandler Instance = new CompositeKeyNamePropertyHandler();
		
			/// <summary>
			/// Gets the Id of the ModelProperty.CompositeKeyName domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return CompositeKeyNameDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed global::System.String GetValue(ModelProperty element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.compositeKeyNamePropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(ModelProperty element, global::System.String newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				global::System.String oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.compositeKeyNamePropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region PropertyType domain property code
		
		/// <summary>
		/// PropertyType domain property Id.
		/// </summary>
		public static readonly global::System.Guid PropertyTypeDomainPropertyId = new global::System.Guid(0x4ed3c7b2, 0x58e8, 0x4db7, 0xbe, 0x1d, 0xbf, 0x46, 0x27, 0x3a, 0x37, 0x56);
		
		/// <summary>
		/// Storage for PropertyType
		/// </summary>
		private PropertyType propertyTypePropertyStorage = PropertyType.Property;
		
		/// <summary>
		/// Gets or sets the value of PropertyType domain property.
		/// Type of the property.
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.ModelProperty/PropertyType.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.ModelProperty/PropertyType.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.ModelProperty/PropertyType.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[global::System.ComponentModel.DefaultValue(PropertyType.Property)]
		[DslModeling::DomainObjectId("4ed3c7b2-58e8-4db7-be1d-bf46273a3756")]
		public PropertyType PropertyType
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return propertyTypePropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				PropertyTypePropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the ModelProperty.PropertyType domain property.
		/// </summary>
		internal sealed partial class PropertyTypePropertyHandler : DslModeling::DomainPropertyValueHandler<ModelProperty, PropertyType>
		{
			private PropertyTypePropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the ModelProperty.PropertyType domain property value handler.
			/// </summary>
			public static readonly PropertyTypePropertyHandler Instance = new PropertyTypePropertyHandler();
		
			/// <summary>
			/// Gets the Id of the ModelProperty.PropertyType domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return PropertyTypeDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed PropertyType GetValue(ModelProperty element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.propertyTypePropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(ModelProperty element, PropertyType newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				PropertyType oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.propertyTypePropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region DebuggerDisplay domain property code
		
		/// <summary>
		/// DebuggerDisplay domain property Id.
		/// </summary>
		public static readonly global::System.Guid DebuggerDisplayDomainPropertyId = new global::System.Guid(0xb70d57e3, 0x356e, 0x4abb, 0xbc, 0xc1, 0xd0, 0xf7, 0x38, 0x6a, 0xd7, 0x4a);
		
		/// <summary>
		/// Storage for DebuggerDisplay
		/// </summary>
		private global::System.Boolean debuggerDisplayPropertyStorage;
		
		/// <summary>
		/// Gets or sets the value of DebuggerDisplay domain property.
		/// Decorates the class this property belongs to with DebuggerDisplay attribute,
		/// using this property as the display source. Example:  [DebuggerDisplay("Name =
		/// {Name}")]
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.ModelProperty/DebuggerDisplay.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.ModelProperty/DebuggerDisplay.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.ModelProperty/DebuggerDisplay.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslModeling::DomainObjectId("b70d57e3-356e-4abb-bcc1-d0f7386ad74a")]
		public global::System.Boolean DebuggerDisplay
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return debuggerDisplayPropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				DebuggerDisplayPropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the ModelProperty.DebuggerDisplay domain property.
		/// </summary>
		internal sealed partial class DebuggerDisplayPropertyHandler : DslModeling::DomainPropertyValueHandler<ModelProperty, global::System.Boolean>
		{
			private DebuggerDisplayPropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the ModelProperty.DebuggerDisplay domain property value handler.
			/// </summary>
			public static readonly DebuggerDisplayPropertyHandler Instance = new DebuggerDisplayPropertyHandler();
		
			/// <summary>
			/// Gets the Id of the ModelProperty.DebuggerDisplay domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return DebuggerDisplayDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed global::System.Boolean GetValue(ModelProperty element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.debuggerDisplayPropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(ModelProperty element, global::System.Boolean newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				global::System.Boolean oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.debuggerDisplayPropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region Validator domain property code
		
		/// <summary>
		/// Validator domain property Id.
		/// </summary>
		public static readonly global::System.Guid ValidatorDomainPropertyId = new global::System.Guid(0x52415453, 0x1653, 0x41e9, 0xa3, 0xf6, 0x77, 0x92, 0x63, 0x4f, 0x39, 0x81);
		
		/// <summary>
		/// Gets or sets the value of Validator domain property.
		/// Defines validators to be used on the property.
		/// </summary>
		[System.ComponentModel.Editor(typeof(Castle.ActiveWriter.UIEditors.PropertyValidationEditor), typeof(System.Drawing.Design.UITypeEditor))]
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.ModelProperty/Validator.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.ModelProperty/Validator.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.ModelProperty/Validator.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslModeling::DomainProperty(Kind = DslModeling::DomainPropertyKind.CustomStorage)]
		[DslModeling::DomainObjectId("52415453-1653-41e9-a3f6-7792634f3981")]
		public global::System.String Validator
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return ValidatorPropertyHandler.Instance.GetValue(this);
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				ValidatorPropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the ModelProperty.Validator domain property.
		/// </summary>
		internal sealed partial class ValidatorPropertyHandler : DslModeling::DomainPropertyValueHandler<ModelProperty, global::System.String>
		{
			private ValidatorPropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the ModelProperty.Validator domain property value handler.
			/// </summary>
			public static readonly ValidatorPropertyHandler Instance = new ValidatorPropertyHandler();
		
			/// <summary>
			/// Gets the Id of the ModelProperty.Validator domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return ValidatorDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed global::System.String GetValue(ModelProperty element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				// There is no storage for Validator because its Kind is
				// set to CustomStorage. Please provide the GetValidatorValue()
				// method on the domain class.
				return element.GetValidatorValue();
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(ModelProperty element, global::System.String newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				global::System.String oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					// There is no storage for Validator because its Kind is
					// set to CustomStorage. Please provide the SetValidatorValue()
					// method on the domain class.
					element.SetValidatorValue(newValue);
					ValueChanged(element, oldValue, GetValue(element));
				}
			}
		}
		
		#endregion
		#region UniqueKey domain property code
		
		/// <summary>
		/// UniqueKey domain property Id.
		/// </summary>
		public static readonly global::System.Guid UniqueKeyDomainPropertyId = new global::System.Guid(0x4044711f, 0xd9ec, 0x4e57, 0xbf, 0x04, 0xad, 0xae, 0x64, 0xce, 0x18, 0x00);
		
		/// <summary>
		/// Storage for UniqueKey
		/// </summary>
		private global::System.String uniqueKeyPropertyStorage = string.Empty;
		
		/// <summary>
		/// Gets or sets the value of UniqueKey domain property.
		/// A unique-key attribute can be used to group columns in a single unit key
		/// constraint.
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.ModelProperty/UniqueKey.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.ModelProperty/UniqueKey.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.ModelProperty/UniqueKey.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslModeling::DomainObjectId("4044711f-d9ec-4e57-bf04-adae64ce1800")]
		public global::System.String UniqueKey
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return uniqueKeyPropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				UniqueKeyPropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the ModelProperty.UniqueKey domain property.
		/// </summary>
		internal sealed partial class UniqueKeyPropertyHandler : DslModeling::DomainPropertyValueHandler<ModelProperty, global::System.String>
		{
			private UniqueKeyPropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the ModelProperty.UniqueKey domain property value handler.
			/// </summary>
			public static readonly UniqueKeyPropertyHandler Instance = new UniqueKeyPropertyHandler();
		
			/// <summary>
			/// Gets the Id of the ModelProperty.UniqueKey domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return UniqueKeyDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed global::System.String GetValue(ModelProperty element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.uniqueKeyPropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(ModelProperty element, global::System.String newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				global::System.String oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.uniqueKeyPropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region Index domain property code
		
		/// <summary>
		/// Index domain property Id.
		/// </summary>
		public static readonly global::System.Guid IndexDomainPropertyId = new global::System.Guid(0x485e004e, 0xdd51, 0x4770, 0x8d, 0x09, 0x77, 0x4b, 0x44, 0xd9, 0xe2, 0x5b);
		
		/// <summary>
		/// Storage for Index
		/// </summary>
		private global::System.String indexPropertyStorage = string.Empty;
		
		/// <summary>
		/// Gets or sets the value of Index domain property.
		/// Specifies the name of a (multi-column) index.
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.ModelProperty/Index.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.ModelProperty/Index.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.ModelProperty/Index.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslModeling::DomainObjectId("485e004e-dd51-4770-8d09-774b44d9e25b")]
		public global::System.String Index
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return indexPropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				IndexPropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the ModelProperty.Index domain property.
		/// </summary>
		internal sealed partial class IndexPropertyHandler : DslModeling::DomainPropertyValueHandler<ModelProperty, global::System.String>
		{
			private IndexPropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the ModelProperty.Index domain property value handler.
			/// </summary>
			public static readonly IndexPropertyHandler Instance = new IndexPropertyHandler();
		
			/// <summary>
			/// Gets the Id of the ModelProperty.Index domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return IndexDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed global::System.String GetValue(ModelProperty element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.indexPropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(ModelProperty element, global::System.String newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				global::System.String oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.indexPropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region SqlType domain property code
		
		/// <summary>
		/// SqlType domain property Id.
		/// </summary>
		public static readonly global::System.Guid SqlTypeDomainPropertyId = new global::System.Guid(0xca48b1f1, 0xfbf3, 0x4a32, 0xb9, 0xd5, 0x4d, 0xd1, 0x0b, 0x96, 0x20, 0x79);
		
		/// <summary>
		/// Storage for SqlType
		/// </summary>
		private global::System.String sqlTypePropertyStorage = string.Empty;
		
		/// <summary>
		/// Gets or sets the value of SqlType domain property.
		/// Overrides the default column type.
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.ModelProperty/SqlType.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.ModelProperty/SqlType.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.ModelProperty/SqlType.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslModeling::DomainObjectId("ca48b1f1-fbf3-4a32-b9d5-4dd10b962079")]
		public global::System.String SqlType
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return sqlTypePropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				SqlTypePropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the ModelProperty.SqlType domain property.
		/// </summary>
		internal sealed partial class SqlTypePropertyHandler : DslModeling::DomainPropertyValueHandler<ModelProperty, global::System.String>
		{
			private SqlTypePropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the ModelProperty.SqlType domain property value handler.
			/// </summary>
			public static readonly SqlTypePropertyHandler Instance = new SqlTypePropertyHandler();
		
			/// <summary>
			/// Gets the Id of the ModelProperty.SqlType domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return SqlTypeDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed global::System.String GetValue(ModelProperty element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.sqlTypePropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(ModelProperty element, global::System.String newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				global::System.String oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.sqlTypePropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region Check domain property code
		
		/// <summary>
		/// Check domain property Id.
		/// </summary>
		public static readonly global::System.Guid CheckDomainPropertyId = new global::System.Guid(0x54fa865c, 0xa419, 0x478c, 0xa4, 0x6d, 0xc1, 0x08, 0x5e, 0x92, 0xa2, 0xb2);
		
		/// <summary>
		/// Storage for Check
		/// </summary>
		private global::System.String checkPropertyStorage = string.Empty;
		
		/// <summary>
		/// Gets or sets the value of Check domain property.
		/// Create an SQL check constraint on either column or table.
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.ModelProperty/Check.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.ModelProperty/Check.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.ModelProperty/Check.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslModeling::DomainObjectId("54fa865c-a419-478c-a46d-c1085e92a2b2")]
		public global::System.String Check
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return checkPropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				CheckPropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the ModelProperty.Check domain property.
		/// </summary>
		internal sealed partial class CheckPropertyHandler : DslModeling::DomainPropertyValueHandler<ModelProperty, global::System.String>
		{
			private CheckPropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the ModelProperty.Check domain property value handler.
			/// </summary>
			public static readonly CheckPropertyHandler Instance = new CheckPropertyHandler();
		
			/// <summary>
			/// Gets the Id of the ModelProperty.Check domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return CheckDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed global::System.String GetValue(ModelProperty element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.checkPropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(ModelProperty element, global::System.String newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				global::System.String oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.checkPropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region DefaultMember domain property code
		
		/// <summary>
		/// DefaultMember domain property Id.
		/// </summary>
		public static readonly global::System.Guid DefaultMemberDomainPropertyId = new global::System.Guid(0x4d4c71f2, 0xb5fe, 0x4acc, 0x8f, 0xc0, 0x38, 0x58, 0xb0, 0xe9, 0xb5, 0xf7);
		
		/// <summary>
		/// Storage for DefaultMember
		/// </summary>
		private global::System.Boolean defaultMemberPropertyStorage;
		
		/// <summary>
		/// Gets or sets the value of DefaultMember domain property.
		/// Decorates the class this property belongs to with DefaultMember attribute, using
		/// this property as the member source. Example:  [DefaultMember("Id")]
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.ModelProperty/DefaultMember.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.ModelProperty/DefaultMember.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.ModelProperty/DefaultMember.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslModeling::DomainObjectId("4d4c71f2-b5fe-4acc-8fc0-3858b0e9b5f7")]
		public global::System.Boolean DefaultMember
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return defaultMemberPropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				DefaultMemberPropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the ModelProperty.DefaultMember domain property.
		/// </summary>
		internal sealed partial class DefaultMemberPropertyHandler : DslModeling::DomainPropertyValueHandler<ModelProperty, global::System.Boolean>
		{
			private DefaultMemberPropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the ModelProperty.DefaultMember domain property value handler.
			/// </summary>
			public static readonly DefaultMemberPropertyHandler Instance = new DefaultMemberPropertyHandler();
		
			/// <summary>
			/// Gets the Id of the ModelProperty.DefaultMember domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return DefaultMemberDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed global::System.Boolean GetValue(ModelProperty element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.defaultMemberPropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(ModelProperty element, global::System.Boolean newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				global::System.Boolean oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.defaultMemberPropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region ColumnDefault domain property code
		
		/// <summary>
		/// ColumnDefault domain property Id.
		/// </summary>
		public static readonly global::System.Guid ColumnDefaultDomainPropertyId = new global::System.Guid(0x32e63dff, 0x41bd, 0x470e, 0xa1, 0x9d, 0x11, 0x4c, 0x64, 0xc0, 0x00, 0x2c);
		
		/// <summary>
		/// Storage for ColumnDefault
		/// </summary>
		private global::System.String columnDefaultPropertyStorage = string.Empty;
		
		/// <summary>
		/// Gets or sets the value of ColumnDefault domain property.
		/// The default value used in database column creation.
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.ModelProperty/ColumnDefault.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.ModelProperty/ColumnDefault.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.ModelProperty/ColumnDefault.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslModeling::DomainObjectId("32e63dff-41bd-470e-a19d-114c64c0002c")]
		public global::System.String ColumnDefault
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return columnDefaultPropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				ColumnDefaultPropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the ModelProperty.ColumnDefault domain property.
		/// </summary>
		internal sealed partial class ColumnDefaultPropertyHandler : DslModeling::DomainPropertyValueHandler<ModelProperty, global::System.String>
		{
			private ColumnDefaultPropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the ModelProperty.ColumnDefault domain property value handler.
			/// </summary>
			public static readonly ColumnDefaultPropertyHandler Instance = new ColumnDefaultPropertyHandler();
		
			/// <summary>
			/// Gets the Id of the ModelProperty.ColumnDefault domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return ColumnDefaultDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed global::System.String GetValue(ModelProperty element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.columnDefaultPropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(ModelProperty element, global::System.String newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				global::System.String oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.columnDefaultPropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region ModelClass opposite domain role accessor
		/// <summary>
		/// Gets or sets ModelClass.
		/// </summary>
		public virtual ModelClass ModelClass
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return DslModeling::DomainRoleInfo.GetLinkedElement(this, global::Castle.ActiveWriter.ClassHasProperty.PropertyDomainRoleId) as ModelClass;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				DslModeling::DomainRoleInfo.SetLinkedElement(this, global::Castle.ActiveWriter.ClassHasProperty.PropertyDomainRoleId, value);
			}
		}
		#endregion
		#region NestedClass opposite domain role accessor
		/// <summary>
		/// Gets or sets NestedClass.
		/// </summary>
		public virtual NestedClass NestedClass
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return DslModeling::DomainRoleInfo.GetLinkedElement(this, global::Castle.ActiveWriter.NestedClassHasProperties.PropertyDomainRoleId) as NestedClass;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				DslModeling::DomainRoleInfo.SetLinkedElement(this, global::Castle.ActiveWriter.NestedClassHasProperties.PropertyDomainRoleId, value);
			}
		}
		#endregion
	}
}
namespace Castle.ActiveWriter
{
	/// <summary>
	/// DomainClass ModelElementWithAccess
	/// Description for Castle.ActiveWriter.ModelElementWithAccess
	/// </summary>
	[DslDesign::DisplayNameResource("Castle.ActiveWriter.ModelElementWithAccess.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
	[DslDesign::DescriptionResource("Castle.ActiveWriter.ModelElementWithAccess.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
	[DslModeling::DomainModelOwner(typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel))]
	[global::System.CLSCompliant(true)]
	[DslModeling::DomainObjectId("cbea293a-1057-4c5b-b60d-78728f734ef2")]
	public abstract partial class ModelElementWithAccess : NamedElement
	{
		#region Constructors, domain class Id
	
		/// <summary>
		/// ModelElementWithAccess domain class Id.
		/// </summary>
		public static readonly new global::System.Guid DomainClassId = new global::System.Guid(0xcbea293a, 0x1057, 0x4c5b, 0xb6, 0x0d, 0x78, 0x72, 0x8f, 0x73, 0x4e, 0xf2);
		/// <summary>
		/// Constructor.
		/// </summary>
		/// <param name="partition">Partition where new element is to be created.</param>
		/// <param name="propertyAssignments">List of domain property id/value pairs to set once the element is created.</param>
		protected ModelElementWithAccess(DslModeling::Partition partition, DslModeling::PropertyAssignment[] propertyAssignments)
			: base(partition, propertyAssignments)
		{
		}
		#endregion
		#region CustomAccess domain property code
		
		/// <summary>
		/// CustomAccess domain property Id.
		/// </summary>
		public static readonly global::System.Guid CustomAccessDomainPropertyId = new global::System.Guid(0x86160079, 0xd659, 0x41e2, 0x87, 0x18, 0xf8, 0x3d, 0xe1, 0x0d, 0xdb, 0x88);
		
		/// <summary>
		/// Storage for CustomAccess
		/// </summary>
		private global::System.String customAccessPropertyStorage = string.Empty;
		
		/// <summary>
		/// Gets or sets the value of CustomAccess domain property.
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.ModelElementWithAccess/CustomAccess.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.ModelElementWithAccess/CustomAccess.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.ModelElementWithAccess/CustomAccess.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslModeling::DomainObjectId("86160079-d659-41e2-8718-f83de10ddb88")]
		public global::System.String CustomAccess
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return customAccessPropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				CustomAccessPropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the ModelElementWithAccess.CustomAccess domain property.
		/// </summary>
		internal sealed partial class CustomAccessPropertyHandler : DslModeling::DomainPropertyValueHandler<ModelElementWithAccess, global::System.String>
		{
			private CustomAccessPropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the ModelElementWithAccess.CustomAccess domain property value handler.
			/// </summary>
			public static readonly CustomAccessPropertyHandler Instance = new CustomAccessPropertyHandler();
		
			/// <summary>
			/// Gets the Id of the ModelElementWithAccess.CustomAccess domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return CustomAccessDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed global::System.String GetValue(ModelElementWithAccess element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.customAccessPropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(ModelElementWithAccess element, global::System.String newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				global::System.String oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.customAccessPropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region Access domain property code
		
		/// <summary>
		/// Access domain property Id.
		/// </summary>
		public static readonly global::System.Guid AccessDomainPropertyId = new global::System.Guid(0x64a542a8, 0xa0ce, 0x42cc, 0xb9, 0xa8, 0x18, 0x45, 0xc7, 0x44, 0xcb, 0x97);
		
		/// <summary>
		/// Storage for Access
		/// </summary>
		private InheritablePropertyAccess accessPropertyStorage = InheritablePropertyAccess.Inherit;
		
		/// <summary>
		/// Gets or sets the value of Access domain property.
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.ModelElementWithAccess/Access.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.ModelElementWithAccess/Access.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.ModelElementWithAccess/Access.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[global::System.ComponentModel.DefaultValue(InheritablePropertyAccess.Inherit)]
		[DslModeling::DomainObjectId("64a542a8-a0ce-42cc-b9a8-1845c744cb97")]
		public InheritablePropertyAccess Access
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return accessPropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				AccessPropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the ModelElementWithAccess.Access domain property.
		/// </summary>
		internal sealed partial class AccessPropertyHandler : DslModeling::DomainPropertyValueHandler<ModelElementWithAccess, InheritablePropertyAccess>
		{
			private AccessPropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the ModelElementWithAccess.Access domain property value handler.
			/// </summary>
			public static readonly AccessPropertyHandler Instance = new AccessPropertyHandler();
		
			/// <summary>
			/// Gets the Id of the ModelElementWithAccess.Access domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return AccessDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed InheritablePropertyAccess GetValue(ModelElementWithAccess element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.accessPropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(ModelElementWithAccess element, InheritablePropertyAccess newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				InheritablePropertyAccess oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.accessPropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
	}
}
namespace Castle.ActiveWriter
{
	/// <summary>
	/// DomainClass NamedElement
	/// Description for Castle.ActiveWriter.NamedElement
	/// </summary>
	[DslDesign::DisplayNameResource("Castle.ActiveWriter.NamedElement.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
	[DslDesign::DescriptionResource("Castle.ActiveWriter.NamedElement.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
	[DslModeling::DomainModelOwner(typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel))]
	[global::System.CLSCompliant(true)]
	[global::System.Diagnostics.DebuggerDisplay("{GetType().Name,nq} (Name = {namePropertyStorage})")]
	[DslModeling::DomainObjectId("ab60f55a-7fb1-44a9-9832-f708caeeee43")]
	public abstract partial class NamedElement : DslModeling::ModelElement
	{
		#region Constructors, domain class Id
	
		/// <summary>
		/// NamedElement domain class Id.
		/// </summary>
		public static readonly new global::System.Guid DomainClassId = new global::System.Guid(0xab60f55a, 0x7fb1, 0x44a9, 0x98, 0x32, 0xf7, 0x08, 0xca, 0xee, 0xee, 0x43);
		/// <summary>
		/// Constructor.
		/// </summary>
		/// <param name="partition">Partition where new element is to be created.</param>
		/// <param name="propertyAssignments">List of domain property id/value pairs to set once the element is created.</param>
		protected NamedElement(DslModeling::Partition partition, DslModeling::PropertyAssignment[] propertyAssignments)
			: base(partition, propertyAssignments)
		{
		}
		#endregion
		#region Name domain property code
		
		/// <summary>
		/// Name domain property Id.
		/// </summary>
		public static readonly global::System.Guid NameDomainPropertyId = new global::System.Guid(0x171d6e97, 0x362e, 0x4ae7, 0xa2, 0xa7, 0x9d, 0x18, 0x14, 0x70, 0x9b, 0x1f);
		
		/// <summary>
		/// Storage for Name
		/// </summary>
		private global::System.String namePropertyStorage = string.Empty;
		
		/// <summary>
		/// Gets or sets the value of Name domain property.
		/// Name of the element
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.NamedElement/Name.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.NamedElement/Name.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslModeling::ElementName]
		[DslModeling::DomainObjectId("171d6e97-362e-4ae7-a2a7-9d1814709b1f")]
		public global::System.String Name
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return namePropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				NamePropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the NamedElement.Name domain property.
		/// </summary>
		internal sealed partial class NamePropertyHandler : DslModeling::DomainPropertyValueHandler<NamedElement, global::System.String>
		{
			private NamePropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the NamedElement.Name domain property value handler.
			/// </summary>
			public static readonly NamePropertyHandler Instance = new NamePropertyHandler();
		
			/// <summary>
			/// Gets the Id of the NamedElement.Name domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return NameDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed global::System.String GetValue(NamedElement element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.namePropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(NamedElement element, global::System.String newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				global::System.String oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.namePropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region Description domain property code
		
		/// <summary>
		/// Description domain property Id.
		/// </summary>
		public static readonly global::System.Guid DescriptionDomainPropertyId = new global::System.Guid(0x7e532084, 0x1f9d, 0x4d7a, 0x94, 0x5c, 0xcc, 0x7b, 0x48, 0x48, 0x39, 0xd3);
		
		/// <summary>
		/// Storage for Description
		/// </summary>
		private global::System.String descriptionPropertyStorage = string.Empty;
		
		/// <summary>
		/// Gets or sets the value of Description domain property.
		/// Description of the element. This will appear in a <summary> Xml comment.
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.NamedElement/Description.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.NamedElement/Description.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslModeling::DomainObjectId("7e532084-1f9d-4d7a-945c-cc7b484839d3")]
		public global::System.String Description
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return descriptionPropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				DescriptionPropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the NamedElement.Description domain property.
		/// </summary>
		internal sealed partial class DescriptionPropertyHandler : DslModeling::DomainPropertyValueHandler<NamedElement, global::System.String>
		{
			private DescriptionPropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the NamedElement.Description domain property value handler.
			/// </summary>
			public static readonly DescriptionPropertyHandler Instance = new DescriptionPropertyHandler();
		
			/// <summary>
			/// Gets the Id of the NamedElement.Description domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return DescriptionDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed global::System.String GetValue(NamedElement element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.descriptionPropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(NamedElement element, global::System.String newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				global::System.String oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.descriptionPropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
	}
}
namespace Castle.ActiveWriter
{
	/// <summary>
	/// DomainClass NestedClass
	/// Description for Castle.ActiveWriter.NestedClass
	/// </summary>
	[DslDesign::DisplayNameResource("Castle.ActiveWriter.NestedClass.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
	[DslDesign::DescriptionResource("Castle.ActiveWriter.NestedClass.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
	[DslModeling::DomainModelOwner(typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel))]
	[global::System.CLSCompliant(true)]
	[DslModeling::DomainObjectId("0df14a30-0137-4eb3-9617-f0d296e797db")]
	public partial class NestedClass : NamedElement
	{
		#region Constructors, domain class Id
	
		/// <summary>
		/// NestedClass domain class Id.
		/// </summary>
		public static readonly new global::System.Guid DomainClassId = new global::System.Guid(0x0df14a30, 0x0137, 0x4eb3, 0x96, 0x17, 0xf0, 0xd2, 0x96, 0xe7, 0x97, 0xdb);
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="store">Store where new element is to be created.</param>
		/// <param name="propertyAssignments">List of domain property id/value pairs to set once the element is created.</param>
		public NestedClass(DslModeling::Store store, params DslModeling::PropertyAssignment[] propertyAssignments)
			: this(store != null ? store.DefaultPartitionForClass(DomainClassId) : null, propertyAssignments)
		{
		}
		
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="partition">Partition where new element is to be created.</param>
		/// <param name="propertyAssignments">List of domain property id/value pairs to set once the element is created.</param>
		public NestedClass(DslModeling::Partition partition, params DslModeling::PropertyAssignment[] propertyAssignments)
			: base(partition, propertyAssignments)
		{
		}
		#endregion
		#region ImplementINotifyPropertyChanged domain property code
		
		/// <summary>
		/// ImplementINotifyPropertyChanged domain property Id.
		/// </summary>
		public static readonly global::System.Guid ImplementINotifyPropertyChangedDomainPropertyId = new global::System.Guid(0xc5fefe2c, 0x4d9f, 0x498f, 0xb0, 0xb1, 0x61, 0x9b, 0xfa, 0x9c, 0x21, 0x5d);
		
		/// <summary>
		/// Storage for ImplementINotifyPropertyChanged
		/// </summary>
		private InheritableBoolean implementINotifyPropertyChangedPropertyStorage = InheritableBoolean.Inherit;
		
		/// <summary>
		/// Gets or sets the value of ImplementINotifyPropertyChanged domain property.
		/// Instructs ActiveWriter to implement INotifyPropertyChanged interface in this
		/// class.
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.NestedClass/ImplementINotifyPropertyChanged.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.NestedClass/ImplementINotifyPropertyChanged.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.NestedClass/ImplementINotifyPropertyChanged.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[global::System.ComponentModel.DefaultValue(InheritableBoolean.Inherit)]
		[DslModeling::DomainObjectId("c5fefe2c-4d9f-498f-b0b1-619bfa9c215d")]
		public InheritableBoolean ImplementINotifyPropertyChanged
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return implementINotifyPropertyChangedPropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				ImplementINotifyPropertyChangedPropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the NestedClass.ImplementINotifyPropertyChanged domain property.
		/// </summary>
		internal sealed partial class ImplementINotifyPropertyChangedPropertyHandler : DslModeling::DomainPropertyValueHandler<NestedClass, InheritableBoolean>
		{
			private ImplementINotifyPropertyChangedPropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the NestedClass.ImplementINotifyPropertyChanged domain property value handler.
			/// </summary>
			public static readonly ImplementINotifyPropertyChangedPropertyHandler Instance = new ImplementINotifyPropertyChangedPropertyHandler();
		
			/// <summary>
			/// Gets the Id of the NestedClass.ImplementINotifyPropertyChanged domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return ImplementINotifyPropertyChangedDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed InheritableBoolean GetValue(NestedClass element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.implementINotifyPropertyChangedPropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(NestedClass element, InheritableBoolean newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				InheritableBoolean oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.implementINotifyPropertyChangedPropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region ImplementINotifyPropertyChanging domain property code
		
		/// <summary>
		/// ImplementINotifyPropertyChanging domain property Id.
		/// </summary>
		public static readonly global::System.Guid ImplementINotifyPropertyChangingDomainPropertyId = new global::System.Guid(0x8853df55, 0x40d4, 0x44bc, 0xac, 0x8f, 0x3d, 0x08, 0xc9, 0x8d, 0x33, 0x22);
		
		/// <summary>
		/// Storage for ImplementINotifyPropertyChanging
		/// </summary>
		private InheritableBoolean implementINotifyPropertyChangingPropertyStorage = InheritableBoolean.Inherit;
		
		/// <summary>
		/// Gets or sets the value of ImplementINotifyPropertyChanging domain property.
		/// Instructs ActiveWriter to implement INotifyPropertyChanging interface in this
		/// class.
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.NestedClass/ImplementINotifyPropertyChanging.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.NestedClass/ImplementINotifyPropertyChanging.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.NestedClass/ImplementINotifyPropertyChanging.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[global::System.ComponentModel.DefaultValue(InheritableBoolean.Inherit)]
		[DslModeling::DomainObjectId("8853df55-40d4-44bc-ac8f-3d08c98d3322")]
		public InheritableBoolean ImplementINotifyPropertyChanging
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return implementINotifyPropertyChangingPropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				ImplementINotifyPropertyChangingPropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the NestedClass.ImplementINotifyPropertyChanging domain property.
		/// </summary>
		internal sealed partial class ImplementINotifyPropertyChangingPropertyHandler : DslModeling::DomainPropertyValueHandler<NestedClass, InheritableBoolean>
		{
			private ImplementINotifyPropertyChangingPropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the NestedClass.ImplementINotifyPropertyChanging domain property value handler.
			/// </summary>
			public static readonly ImplementINotifyPropertyChangingPropertyHandler Instance = new ImplementINotifyPropertyChangingPropertyHandler();
		
			/// <summary>
			/// Gets the Id of the NestedClass.ImplementINotifyPropertyChanging domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return ImplementINotifyPropertyChangingDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed InheritableBoolean GetValue(NestedClass element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.implementINotifyPropertyChangingPropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(NestedClass element, InheritableBoolean newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				InheritableBoolean oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.implementINotifyPropertyChangingPropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region Model opposite domain role accessor
		/// <summary>
		/// Gets or sets Model.
		/// Description for Castle.ActiveWriter.ModelHasNestedClasses.NestedClass
		/// </summary>
		public virtual Model Model
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return DslModeling::DomainRoleInfo.GetLinkedElement(this, global::Castle.ActiveWriter.ModelHasNestedClasses.NestedClassDomainRoleId) as Model;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				DslModeling::DomainRoleInfo.SetLinkedElement(this, global::Castle.ActiveWriter.ModelHasNestedClasses.NestedClassDomainRoleId, value);
			}
		}
		#endregion
		#region Properties opposite domain role accessor
		
		/// <summary>
		/// Gets a list of Properties.
		/// Description for Castle.ActiveWriter.NestedClassHasProperties.NestedClass
		/// </summary>
		public virtual DslModeling::LinkedElementCollection<ModelProperty> Properties
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return GetRoleCollection<DslModeling::LinkedElementCollection<ModelProperty>, ModelProperty>(global::Castle.ActiveWriter.NestedClassHasProperties.NestedClassDomainRoleId);
			}
		}
		#endregion
		#region ModelClasses opposite domain role accessor
		
		/// <summary>
		/// Gets a list of ModelClasses.
		/// Description for
		/// Castle.ActiveWriter.NestedClassReferencesModelClasses.NestedClass
		/// </summary>
		public virtual DslModeling::LinkedElementCollection<ModelClass> ModelClasses
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return GetRoleCollection<DslModeling::LinkedElementCollection<ModelClass>, ModelClass>(global::Castle.ActiveWriter.NestedClassReferencesModelClasses.NestedClassDomainRoleId);
			}
		}
		#endregion
		#region ElementGroupPrototype Merge methods
		/// <summary>
		/// Returns a value indicating whether the source element represented by the
		/// specified root ProtoElement can be added to this element.
		/// </summary>
		/// <param name="rootElement">
		/// The root ProtoElement representing a source element.  This can be null, 
		/// in which case the ElementGroupPrototype does not contain an ProtoElements
		/// and the code should inspect the ElementGroupPrototype context information.
		/// </param>
		/// <param name="elementGroupPrototype">The ElementGroupPrototype that contains the root ProtoElement.</param>
		/// <returns>true if the source element represented by the ProtoElement can be added to this target element.</returns>
		protected override bool CanMerge(DslModeling::ProtoElementBase rootElement, DslModeling::ElementGroupPrototype elementGroupPrototype)
		{
			if ( elementGroupPrototype == null ) throw new global::System.ArgumentNullException("elementGroupPrototype");
			
			if (rootElement != null)
			{
				DslModeling::DomainClassInfo rootElementDomainInfo = Partition.DomainDataDirectory.GetDomainClass(rootElement.DomainClassId);
				
				if (rootElementDomainInfo.IsDerivedFrom(global::Castle.ActiveWriter.ModelProperty.DomainClassId)) 
				{
					return true;
				}
			}
			return base.CanMerge(rootElement, elementGroupPrototype);
		}
		
		/// <summary>
		/// Called by the Merge process to create a relationship between 
		/// this target element and the specified source element. 
		/// Typically, a parent-child relationship is established
		/// between the target element (the parent) and the source element 
		/// (the child), but any relationship can be established.
		/// </summary>
		/// <param name="sourceElement">The element that is to be related to this model element.</param>
		/// <param name="elementGroup">The group of source ModelElements that have been rehydrated into the target store.</param>
		/// <remarks>
		/// This method is overriden to create the relationship between the target element and the specified source element.
		/// The base method does nothing.
		/// </remarks>
		protected override void MergeRelate(DslModeling::ModelElement sourceElement, DslModeling::ElementGroup elementGroup)
		{
			// In general, sourceElement is allowed to be null, meaning that the elementGroup must be parsed for special cases.
			// However this is not supported in generated code.  Use double-deriving on this class and then override MergeRelate completely if you 
			// need to support this case.
			if ( sourceElement == null ) throw new global::System.ArgumentNullException("sourceElement");
		
				
			global::Castle.ActiveWriter.ModelProperty sourceModelProperty1 = sourceElement as global::Castle.ActiveWriter.ModelProperty;
			if (sourceModelProperty1 != null)
			{
				// Create link for path NestedClassHasProperties.Properties
				Properties.Add(sourceModelProperty1);

				return;
			}
		
			// Sdk workaround to runtime bug #879350 (DSL: can't copy and paste a MEL that has a MEX). Avoid MergeRelate on ModelElementExtension
			// during a "Paste".
			if (sourceElement is DslModeling::ExtensionElement
				&& sourceElement.Store.TransactionManager.CurrentTransaction.TopLevelTransaction.Context.ContextInfo.ContainsKey("{9DAFD42A-DC0E-4d78-8C3F-8266B2CF8B33}"))
			{
				return;
			}
		
			// Fall through to base class if this class hasn't handled the merge.
			base.MergeRelate(sourceElement, elementGroup);
		}
		
		/// <summary>
		/// Performs operation opposite to MergeRelate - i.e. disconnects a given
		/// element from the current one (removes links created by MergeRelate).
		/// </summary>
		/// <param name="sourceElement">Element to be unmerged/disconnected.</param>
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
		protected override void MergeDisconnect(DslModeling::ModelElement sourceElement)
		{
			if (sourceElement == null) throw new global::System.ArgumentNullException("sourceElement");
				
			global::Castle.ActiveWriter.ModelProperty sourceModelProperty1 = sourceElement as global::Castle.ActiveWriter.ModelProperty;
			if (sourceModelProperty1 != null)
			{
				// Delete link for path NestedClassHasProperties.Properties
				
				foreach (DslModeling::ElementLink link in global::Castle.ActiveWriter.NestedClassHasProperties.GetLinks((global::Castle.ActiveWriter.NestedClass)this, sourceModelProperty1))
				{
					// Delete the link, but without possible delete propagation to the element since it's moving to a new location.
					link.Delete(global::Castle.ActiveWriter.NestedClassHasProperties.NestedClassDomainRoleId, global::Castle.ActiveWriter.NestedClassHasProperties.PropertyDomainRoleId);
				}

				return;
			}
			// Fall through to base class if this class hasn't handled the unmerge.
			base.MergeDisconnect(sourceElement);
		}
		#endregion
	}
}
