// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using Microsoft.Azure;

namespace Microsoft.Azure.Management.Redis.Models
{
    /// <summary>
    /// The response of redis list keys operation.
    /// </summary>
    public partial class RedisListKeysResponse : AzureOperationResponse
    {
        private string _primaryKey;
        
        /// <summary>
        /// Optional. The current primary key that clients can use to
        /// authenticate with redis cache.
        /// </summary>
        public string PrimaryKey
        {
            get { return this._primaryKey; }
            set { this._primaryKey = value; }
        }
        
        private string _secondaryKey;
        
        /// <summary>
        /// Optional. The current secondary key that clients can use to
        /// authenticate with redis cache.
        /// </summary>
        public string SecondaryKey
        {
            get { return this._secondaryKey; }
            set { this._secondaryKey = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the RedisListKeysResponse class.
        /// </summary>
        public RedisListKeysResponse()
        {
        }
    }
}