// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Batch.Protocol.Models
{
    using System.Linq;

    /// <summary>
    /// How the Batch service should respond if a task exits with a particular
    /// exit code.
    /// </summary>
    public partial class ExitCodeMapping
    {
        /// <summary>
        /// Initializes a new instance of the ExitCodeMapping class.
        /// </summary>
        public ExitCodeMapping() { }

        /// <summary>
        /// Initializes a new instance of the ExitCodeMapping class.
        /// </summary>
        /// <param name="code">A process exit code.</param>
        /// <param name="exitOptions">How the Batch service should respond if
        /// the task exits with this exit code.</param>
        public ExitCodeMapping(int code, ExitOptions exitOptions)
        {
            Code = code;
            ExitOptions = exitOptions;
        }

        /// <summary>
        /// Gets or sets a process exit code.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "code")]
        public int Code { get; set; }

        /// <summary>
        /// Gets or sets how the Batch service should respond if the task
        /// exits with this exit code.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "exitOptions")]
        public ExitOptions ExitOptions { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (ExitOptions == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "ExitOptions");
            }
        }
    }
}
