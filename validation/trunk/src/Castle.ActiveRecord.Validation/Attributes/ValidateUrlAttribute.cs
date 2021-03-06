// Copyright 2004-2006 Castle Project - http://www.castleproject.org/
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

using System;
using Castle.Components.Validator.Contrib.Validators;

namespace Castle.Components.Validator.Contrib.Attributes
{
    /// <summary>
    /// Validate the url.
    /// </summary>
    [Serializable, CLSCompliant(false)]
    public class ValidateUrlAttribute : AbstractValidationAttribute
    {
        public ValidateUrlAttribute()
        {
        }

        public ValidateUrlAttribute(string errorMessage) : base(errorMessage)
        {
        }

        public override IValidator Build()
        {
            IValidator validator = new UrlValidator();

            ConfigureValidatorMessage(validator);

            return validator;
        }
    }
}