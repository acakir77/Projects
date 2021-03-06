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

using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Castle.FlexBridge.Serialization.AMF
{
    /// <summary>
    /// Exception type thrown when errors occur during AMF processing.
    /// </summary>
    [Serializable]
    public class AMFException : Exception
    {
        /// <summary>
        /// Creates an exception.
        /// </summary>
        /// <param name="message">The exception message</param>
        public AMFException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Creates an exception.
        /// </summary>
        /// <param name="message">The exception message</param>
        /// <param name="inner">The inner exception or null if none</param>
        public AMFException(string message, Exception inner)
            : base(message, inner)
        {
        }

        /// <summary>
        /// Creates an exception from serialization data.
        /// </summary>
        /// <param name="info">The serialization info</param>
        /// <param name="context">The streaming context</param>
        protected AMFException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }
}
