// Copyright 2007 Castle Project - http://www.castleproject.org/
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

package castle.flexbridge.kernel
{
	/**
	 * Models a single dependency that a component has on a service
	 * or parameter value.
	 */
	public class DependencyModel
	{
		private var _dependencyKey:String;
		private var _dependencyType:Class;
		private var _isOptional:Boolean;
		
		/**
		 * Creates a dependency model.
		 */
		public function DependencyModel(dependencyKey:String,
			dependencyType:Class, isOptional:Boolean = false)
		{
			_dependencyKey = dependencyKey;
			_dependencyType = dependencyType;
			_isOptional = isOptional;
		}
		
		/**
		 * Gets or sets the dependency key.
		 */
		public function get dependencyKey():String
		{
			return _dependencyKey;
		}
		
		public function set dependencyKey(value:String):void
		{
			_dependencyKey = value;
		}
		
		/**
		 * Gets or sets the type of the service or parameter consumed
		 * by the dependency.
		 */
		public function get dependencyType():Class
		{
			return _dependencyType;
		}
		
		public function set dependencyType(value:Class):void
		{
			_dependencyType = value;
		}
		
		/**
		 * Gets or sets whether the dependency is optional.
		 */
		public function get isOptional():Boolean
		{
			return _isOptional;
		}
		
		public function set isOptional(value:Boolean):void
		{
			_isOptional = value;
		}
	}
}