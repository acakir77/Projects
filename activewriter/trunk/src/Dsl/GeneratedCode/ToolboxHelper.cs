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
using DslDiagrams = global::Microsoft.VisualStudio.Modeling.Diagrams;

namespace Castle.ActiveWriter
{
	using System;
	using System.Drawing.Design;
	using System.Windows.Forms;

	/// <summary>
	/// Helper class used to create and initialize toolbox items for this DSL.
	/// </summary>
	/// <remarks>
	/// Double-derived class to allow easier code customization.
	/// </remarks>
	public partial class ActiveWriterToolboxHelper : ActiveWriterToolboxHelperBase 
	{
		/// <summary>
		/// Constructs a new ActiveWriterToolboxHelper.
		/// </summary>
		public ActiveWriterToolboxHelper(global::System.IServiceProvider serviceProvider)
			: base(serviceProvider) { }
	}
	
	/// <summary>
	/// Helper class used to create and initialize toolbox items for this DSL.
	/// </summary>
	
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1001:TypesThatOwnDisposableFieldsShouldBeDisposable", Justification = "The store is disposed on domain shut down")]
	public abstract class ActiveWriterToolboxHelperBase
	{
		/// <summary>
		/// Toolbox item filter string used to identify ActiveWriter toolbox items.  
		/// </summary>
		/// <remarks>
		/// See the MSDN documentation for the ToolboxItemFilterAttribute class for more information on toolbox
		/// item filters.
		/// </remarks>
		public const string ToolboxFilterString = "ActiveWriter.10.0";
		/// <summary>
		/// Toolbox item filter string used to identify ManyToOneRelationship connector tool.
		/// </summary>
		public const string ManyToOneRelationshipFilterString = "ManyToOneRelationship.10.0";
		/// <summary>
		/// Toolbox item filter string used to identify ManyToManyRelationship connector tool.
		/// </summary>
		public const string ManyToManyRelationshipFilterString = "ManyToManyRelationship.10.0";
		/// <summary>
		/// Toolbox item filter string used to identify OneToOneRelationship connector tool.
		/// </summary>
		public const string OneToOneRelationshipFilterString = "OneToOneRelationship.10.0";
		/// <summary>
		/// Toolbox item filter string used to identify NestedRelationship connector tool.
		/// </summary>
		public const string NestedRelationshipFilterString = "NestedRelationship.10.0";
		/// <summary>
		/// Toolbox item filter string used to identify InheritanceRelationship connector tool.
		/// </summary>
		public const string InheritanceRelationshipFilterString = "InheritanceRelationship.10.0";

	
		private global::System.Collections.Generic.Dictionary<string, DslDesign::ModelingToolboxItem> toolboxItemCache = new global::System.Collections.Generic.Dictionary<string, DslDesign::ModelingToolboxItem>();
		private DslModeling::Store toolboxStore;
		
		private global::System.IServiceProvider sp;
		
		/// <summary>
		/// Constructs a new ActiveWriterToolboxHelperBase.
		/// </summary>
		protected ActiveWriterToolboxHelperBase(global::System.IServiceProvider serviceProvider)
		{
			if(serviceProvider == null) throw new global::System.ArgumentNullException("serviceProvider");
			
			sp = serviceProvider;
		}
		
		/// <summary>
		/// Serivce provider used to access services from the hosting environment.
		/// </summary>
		protected global::System.IServiceProvider ServiceProvider
		{
			get
			{
				return sp;
			}
		}

		/// <summary>
		/// Returns the display name of the tab that should be opened by default when the editor is opened.
		/// </summary>
		public static string DefaultToolboxTabName
		{
			get
			{
				return global::Castle.ActiveWriter.ActiveWriterDomainModel.SingletonResourceManager.GetString("ActiveWriterToolboxTab", global::System.Globalization.CultureInfo.CurrentUICulture);
			}
		}
		
		
		/// <summary>
		/// Returns the toolbox items count in the default tool box tab.
		/// </summary>
		public static int DefaultToolboxTabToolboxItemsCount
		{
			get
			{
				return 7;
			}
		}
		

		/// <summary>
		/// Returns a list of custom toolbox items to be added dynamically
		/// </summary>
		public virtual global::System.Collections.Generic.IList<DslDesign::ModelingToolboxItem> CreateToolboxItems()
		{
			global::System.Collections.Generic.List<DslDesign::ModelingToolboxItem> toolboxItems = new global::System.Collections.Generic.List<DslDesign::ModelingToolboxItem>();
			return toolboxItems;
		}
		
		/// <summary>
		/// Creates an ElementGroupPrototype for the element tool corresponding to the given domain class id.
		/// Default behavior is to create a prototype containing an instance of the domain class.
		/// Derived classes may override this to add additional information to the prototype.
		/// </summary>
		protected virtual DslModeling::ElementGroupPrototype CreateElementToolPrototype(DslModeling::Store store, global::System.Guid domainClassId)
		{
			DslModeling::ModelElement element = store.ElementFactory.CreateElement(domainClassId);
			DslModeling::ElementGroup elementGroup = new DslModeling::ElementGroup(store.DefaultPartition);
			elementGroup.AddGraph(element, true);
			return elementGroup.CreatePrototype();
		}

		/// <summary>
		/// Returns instance of ModelingToolboxItem based on specified name.
		/// This method must be called from within a Transaction. Failure to do so will result in an exception
		/// </summary>
		/// <param name="itemId">unique name of desired ToolboxItem</param>
		/// <param name="store">Store to perform the operation against</param>
		/// <returns>An instance of ModelingToolboxItem if the itemId can be resolved, null otherwise</returns>
		public virtual DslDesign::ModelingToolboxItem GetToolboxItem(string itemId, DslModeling::Store store)
		{
			DslDesign::ModelingToolboxItem result = null;
			if (string.IsNullOrEmpty(itemId))
			{
				return null;
			}
			if (store == null)
			{
				return null;
			}
			global::System.Resources.ResourceManager resourceManager = global::Castle.ActiveWriter.ActiveWriterDomainModel.SingletonResourceManager;
			global::System.Globalization.CultureInfo resourceCulture = global::System.Globalization.CultureInfo.CurrentUICulture;
			switch(itemId)
			{
				case "Castle.ActiveWriter.ClassToolboxItem":
					// Add Class shape tool.
					result = new DslDesign::ModelingToolboxItem(
						"Castle.ActiveWriter.ClassToolboxItem", // Unique identifier (non-localized) for the toolbox item.
						1, // Position relative to other items in the same toolbox tab.
						resourceManager.GetString("ClassToolboxItem", resourceCulture), // Localized display name for the item.
						(global::System.Drawing.Bitmap)DslDiagrams::ImageHelper.GetImage(resourceManager.GetObject("ClassToolboxBitmap", resourceCulture)), // Image displayed next to the toolbox item.
						"Castle.ActiveWriter.ActiveWriterToolboxTab", // Unique identifier (non-localized) for the toolbox item tab.
						resourceManager.GetString("ActiveWriterToolboxTab", resourceCulture), // Localized display name for the toolbox tab.
						"CreateClassF1Keyword", // F1 help keyword for the toolbox item.
						resourceManager.GetString("ClassToolboxTooltip", resourceCulture), // Localized tooltip text for the toolbox item.
						CreateElementToolPrototype(store, global::Castle.ActiveWriter.ModelClass.DomainClassId), // ElementGroupPrototype (data object) representing model element on the toolbox.
						new global::System.ComponentModel.ToolboxItemFilterAttribute[] { // Collection of ToolboxItemFilterAttribute objects that determine visibility of the toolbox item.
						new global::System.ComponentModel.ToolboxItemFilterAttribute(ToolboxFilterString, global::System.ComponentModel.ToolboxItemFilterType.Require) 
						});
					break;
				case "Castle.ActiveWriter.ManyToOneRelationshipToolboxItem":

					// Add ManyToOneRelationship connector tool.
					result = new DslDesign::ModelingToolboxItem(
						"Castle.ActiveWriter.ManyToOneRelationshipToolboxItem", // Unique identifier (non-localized) for the toolbox item.
						2, // Position relative to other items in the same toolbox tab.
						resourceManager.GetString("ManyToOneRelationshipToolboxItem", resourceCulture), // Localized display name for the item.
						(global::System.Drawing.Bitmap)DslDiagrams::ImageHelper.GetImage(resourceManager.GetObject("ManyToOneRelationshipToolboxBitmap", resourceCulture)), // Image displayed next to the toolbox item.				
						"Castle.ActiveWriter.ActiveWriterToolboxTab", // Unique identifier (non-localized) for the toolbox item tab.
						resourceManager.GetString("ActiveWriterToolboxTab", resourceCulture), // Localized display name for the toolbox tab.
						"ConnectRelationF1Keyword", // F1 help keyword for the toolbox item.
						resourceManager.GetString("ManyToOneRelationshipToolboxTooltip", resourceCulture), // Localized tooltip text for the toolbox item.
						null, // Connector toolbox items do not have an underlying data object.
						new global::System.ComponentModel.ToolboxItemFilterAttribute[] { // Collection of ToolboxItemFilterAttribute objects that determine visibility of the toolbox item.
							new global::System.ComponentModel.ToolboxItemFilterAttribute(ToolboxFilterString, global::System.ComponentModel.ToolboxItemFilterType.Require), 
							new global::System.ComponentModel.ToolboxItemFilterAttribute(ManyToOneRelationshipFilterString)
						});
					break;
				case "Castle.ActiveWriter.ManyToManyRelationshipToolboxItem":

					// Add ManyToManyRelationship connector tool.
					result = new DslDesign::ModelingToolboxItem(
						"Castle.ActiveWriter.ManyToManyRelationshipToolboxItem", // Unique identifier (non-localized) for the toolbox item.
						3, // Position relative to other items in the same toolbox tab.
						resourceManager.GetString("ManyToManyRelationshipToolboxItem", resourceCulture), // Localized display name for the item.
						(global::System.Drawing.Bitmap)DslDiagrams::ImageHelper.GetImage(resourceManager.GetObject("ManyToManyRelationshipToolboxBitmap", resourceCulture)), // Image displayed next to the toolbox item.				
						"Castle.ActiveWriter.ActiveWriterToolboxTab", // Unique identifier (non-localized) for the toolbox item tab.
						resourceManager.GetString("ActiveWriterToolboxTab", resourceCulture), // Localized display name for the toolbox tab.
						"ManyToManyRelationship", // F1 help keyword for the toolbox item.
						resourceManager.GetString("ManyToManyRelationshipToolboxTooltip", resourceCulture), // Localized tooltip text for the toolbox item.
						null, // Connector toolbox items do not have an underlying data object.
						new global::System.ComponentModel.ToolboxItemFilterAttribute[] { // Collection of ToolboxItemFilterAttribute objects that determine visibility of the toolbox item.
							new global::System.ComponentModel.ToolboxItemFilterAttribute(ToolboxFilterString, global::System.ComponentModel.ToolboxItemFilterType.Require), 
							new global::System.ComponentModel.ToolboxItemFilterAttribute(ManyToManyRelationshipFilterString)
						});
					break;
				case "Castle.ActiveWriter.OneToOneRelationshipToolboxItem":

					// Add OneToOneRelationship connector tool.
					result = new DslDesign::ModelingToolboxItem(
						"Castle.ActiveWriter.OneToOneRelationshipToolboxItem", // Unique identifier (non-localized) for the toolbox item.
						4, // Position relative to other items in the same toolbox tab.
						resourceManager.GetString("OneToOneRelationshipToolboxItem", resourceCulture), // Localized display name for the item.
						(global::System.Drawing.Bitmap)DslDiagrams::ImageHelper.GetImage(resourceManager.GetObject("OneToOneRelationshipToolboxBitmap", resourceCulture)), // Image displayed next to the toolbox item.				
						"Castle.ActiveWriter.ActiveWriterToolboxTab", // Unique identifier (non-localized) for the toolbox item tab.
						resourceManager.GetString("ActiveWriterToolboxTab", resourceCulture), // Localized display name for the toolbox tab.
						"OneToOneRelationship", // F1 help keyword for the toolbox item.
						resourceManager.GetString("OneToOneRelationshipToolboxTooltip", resourceCulture), // Localized tooltip text for the toolbox item.
						null, // Connector toolbox items do not have an underlying data object.
						new global::System.ComponentModel.ToolboxItemFilterAttribute[] { // Collection of ToolboxItemFilterAttribute objects that determine visibility of the toolbox item.
							new global::System.ComponentModel.ToolboxItemFilterAttribute(ToolboxFilterString, global::System.ComponentModel.ToolboxItemFilterType.Require), 
							new global::System.ComponentModel.ToolboxItemFilterAttribute(OneToOneRelationshipFilterString)
						});
					break;
				case "Castle.ActiveWriter.NestedClassToolboxItem":
					// Add NestedClass shape tool.
					result = new DslDesign::ModelingToolboxItem(
						"Castle.ActiveWriter.NestedClassToolboxItem", // Unique identifier (non-localized) for the toolbox item.
						5, // Position relative to other items in the same toolbox tab.
						resourceManager.GetString("NestedClassToolboxItem", resourceCulture), // Localized display name for the item.
						(global::System.Drawing.Bitmap)DslDiagrams::ImageHelper.GetImage(resourceManager.GetObject("NestedClassToolboxBitmap", resourceCulture)), // Image displayed next to the toolbox item.
						"Castle.ActiveWriter.ActiveWriterToolboxTab", // Unique identifier (non-localized) for the toolbox item tab.
						resourceManager.GetString("ActiveWriterToolboxTab", resourceCulture), // Localized display name for the toolbox tab.
						"NestedClassF1Keyword", // F1 help keyword for the toolbox item.
						resourceManager.GetString("NestedClassToolboxTooltip", resourceCulture), // Localized tooltip text for the toolbox item.
						CreateElementToolPrototype(store, global::Castle.ActiveWriter.NestedClass.DomainClassId), // ElementGroupPrototype (data object) representing model element on the toolbox.
						new global::System.ComponentModel.ToolboxItemFilterAttribute[] { // Collection of ToolboxItemFilterAttribute objects that determine visibility of the toolbox item.
						new global::System.ComponentModel.ToolboxItemFilterAttribute(ToolboxFilterString, global::System.ComponentModel.ToolboxItemFilterType.Require) 
						});
					break;
				case "Castle.ActiveWriter.NestedRelationshipToolboxItem":

					// Add NestedRelationship connector tool.
					result = new DslDesign::ModelingToolboxItem(
						"Castle.ActiveWriter.NestedRelationshipToolboxItem", // Unique identifier (non-localized) for the toolbox item.
						6, // Position relative to other items in the same toolbox tab.
						resourceManager.GetString("NestedRelationshipToolboxItem", resourceCulture), // Localized display name for the item.
						(global::System.Drawing.Bitmap)DslDiagrams::ImageHelper.GetImage(resourceManager.GetObject("NestedRelationshipToolboxBitmap", resourceCulture)), // Image displayed next to the toolbox item.				
						"Castle.ActiveWriter.ActiveWriterToolboxTab", // Unique identifier (non-localized) for the toolbox item tab.
						resourceManager.GetString("ActiveWriterToolboxTab", resourceCulture), // Localized display name for the toolbox tab.
						"NestedRelationship", // F1 help keyword for the toolbox item.
						resourceManager.GetString("NestedRelationshipToolboxTooltip", resourceCulture), // Localized tooltip text for the toolbox item.
						null, // Connector toolbox items do not have an underlying data object.
						new global::System.ComponentModel.ToolboxItemFilterAttribute[] { // Collection of ToolboxItemFilterAttribute objects that determine visibility of the toolbox item.
							new global::System.ComponentModel.ToolboxItemFilterAttribute(ToolboxFilterString, global::System.ComponentModel.ToolboxItemFilterType.Require), 
							new global::System.ComponentModel.ToolboxItemFilterAttribute(NestedRelationshipFilterString)
						});
					break;
				case "Castle.ActiveWriter.InheritanceRelationshipToolboxItem":

					// Add InheritanceRelationship connector tool.
					result = new DslDesign::ModelingToolboxItem(
						"Castle.ActiveWriter.InheritanceRelationshipToolboxItem", // Unique identifier (non-localized) for the toolbox item.
						7, // Position relative to other items in the same toolbox tab.
						resourceManager.GetString("InheritanceRelationshipToolboxItem", resourceCulture), // Localized display name for the item.
						(global::System.Drawing.Bitmap)DslDiagrams::ImageHelper.GetImage(resourceManager.GetObject("InheritanceRelationshipToolboxBitmap", resourceCulture)), // Image displayed next to the toolbox item.				
						"Castle.ActiveWriter.ActiveWriterToolboxTab", // Unique identifier (non-localized) for the toolbox item tab.
						resourceManager.GetString("ActiveWriterToolboxTab", resourceCulture), // Localized display name for the toolbox tab.
						"InheritanceRelationship", // F1 help keyword for the toolbox item.
						resourceManager.GetString("InheritanceRelationshipToolboxTooltip", resourceCulture), // Localized tooltip text for the toolbox item.
						null, // Connector toolbox items do not have an underlying data object.
						new global::System.ComponentModel.ToolboxItemFilterAttribute[] { // Collection of ToolboxItemFilterAttribute objects that determine visibility of the toolbox item.
							new global::System.ComponentModel.ToolboxItemFilterAttribute(ToolboxFilterString, global::System.ComponentModel.ToolboxItemFilterType.Require), 
							new global::System.ComponentModel.ToolboxItemFilterAttribute(InheritanceRelationshipFilterString)
						});
					break;
				default:
					break;
			} // end switch
			
			return result;
		}
		

		/// <summary>
		/// The store toe be used for all the toolbox item creation
		/// </summary>
		protected DslModeling::Store ToolboxStore
		{
			get
			{ 
				if (toolboxStore==null)
				{
					toolboxStore = new DslModeling::Store(ServiceProvider);
					EventHandler StoreCleanUp = (o, e) =>
					{
						//Since Store implements IDisposable, we need to dispose it when we're finished
						if (toolboxStore != null)
						{
							toolboxStore.Dispose();
						}
						toolboxStore = null;
					};
					//There is no DomainUnload event for the default AppDomain, so we listen for both ProcessExit and DomainUnload
					AppDomain.CurrentDomain.ProcessExit += new EventHandler(StoreCleanUp);
					AppDomain.CurrentDomain.DomainUnload += new EventHandler(StoreCleanUp);
					
					//load the domain model
					toolboxStore.LoadDomainModels(typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel));
					
				}
				return toolboxStore;
			}
		}
		
		/// <summary>
		/// Given a toolbox item "unique ID" returns the the toolbox item using cached dictionary
		/// </summary>
		/// <param name="itemId">The unique ToolboxItem to retrieve</param>
		private DslDesign::ModelingToolboxItem GetToolboxItem(string itemId)
		{
			DslDesign::ModelingToolboxItem item = null;

			if (!toolboxItemCache.TryGetValue(itemId, out item))
			{
				DslModeling::Store store = ToolboxStore;
				
				// Open transaction so we can create model elements corresponding to toolbox items.
				using (DslModeling::Transaction t = store.TransactionManager.BeginTransaction("CreateToolboxItems"))
				{
					// Retrieve the specified ToolboxItem from the DSL
					toolboxItemCache[itemId] = item = GetToolboxItem(itemId, store);
				}
			}

			return item;
		}
		
		/// <summary>
		/// Given a toolbox item "unique ID" and a data format identifier, returns the content of
		/// the data format. 
		/// </summary>
		/// <param name="itemId">The unique ToolboxItem to retrieve data for</param>
		/// <param name="format">The desired format of the resulting data</param>
		public virtual object GetToolboxItemData(string itemId, DataFormats.Format format)
		{
			DslDesign::ModelingToolboxItem item = null;

			global::System.Resources.ResourceManager resourceManager = global::Castle.ActiveWriter.ActiveWriterDomainModel.SingletonResourceManager;
			global::System.Globalization.CultureInfo resourceCulture = global::System.Globalization.CultureInfo.CurrentUICulture;

			System.Windows.Forms.IDataObject tbxDataObj;

			//get the toolbox item
			item = GetToolboxItem(itemId);

			if (item != null)
			{
				ToolboxItemContainer container = new ToolboxItemContainer(item);
				tbxDataObj = container.ToolboxData;

				if (tbxDataObj.GetDataPresent(format.Name))
				{
					return tbxDataObj.GetData(format.Name);
				}
				else 
				{
					string invalidFormatString = resourceManager.GetString("UnsupportedToolboxFormat", resourceCulture);
					throw new InvalidOperationException(string.Format(resourceCulture, invalidFormatString, format.Name));
				}
			}

			string errorFormatString = resourceManager.GetString("UnresolvedToolboxItem", resourceCulture);
			throw new InvalidOperationException(string.Format(resourceCulture, errorFormatString, itemId));
		}		
	}
}
