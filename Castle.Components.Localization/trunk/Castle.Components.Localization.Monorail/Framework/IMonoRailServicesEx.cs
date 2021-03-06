﻿
#region License

// Copyright 2004-2007 Castle Project - http://www.castleproject.org/
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

#endregion License

namespace Castle.Components.Localization.MonoRail.Framework
{
	#region Using Directives

	using System;
	using System.Reflection;
	using System.Web;

	using Castle.Core;
	using Castle.Core.Logging;
	using Castle.MonoRail.Framework;
	using Castle.MonoRail.Framework.Container;
	using Castle.MonoRail.Framework.Services;

	#endregion Using Directives

	public interface IMonoRailServicesEx : IMonoRailServices
	{
		/// <summary>
		/// Gets or sets the <see cref="IStaticResourceRegistryEx"/> service.
		/// </summary>
		/// <value>The <see cref="IStaticResourceRegistryEx"/> service.</value>
		IStaticResourceRegistryEx StaticResourceRegistryEx
		{
			get;
			set;
		}

	}
}
