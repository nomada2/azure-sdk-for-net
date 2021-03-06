// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.DataLake.Analytics.Models
{
    using Analytics;
    using Azure;
    using DataLake;
    using Management;
    using Azure;
    using Management;
    using DataLake;
    using Analytics;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Hive job properties used when submitting and retrieving Hive jobs.
    /// </summary>
    [Newtonsoft.Json.JsonObject("Hive")]
    public partial class HiveJobProperties : JobProperties
    {
        /// <summary>
        /// Initializes a new instance of the HiveJobProperties class.
        /// </summary>
        public HiveJobProperties() { }

        /// <summary>
        /// Initializes a new instance of the HiveJobProperties class.
        /// </summary>
        /// <param name="script">the script to run</param>
        /// <param name="runtimeVersion">the runtime version of the Data Lake
        /// Analytics engine to use for the specific type of job being
        /// run.</param>
        /// <param name="logsLocation">the Hive logs location</param>
        /// <param name="outputLocation">the location of Hive job output files
        /// (both execution output and results)</param>
        /// <param name="statementCount">the number of statements that will be
        /// run based on the script</param>
        /// <param name="executedStatementCount">the number of statements that
        /// have been run based on the script</param>
        public HiveJobProperties(string script, string runtimeVersion = default(string), string logsLocation = default(string), string outputLocation = default(string), int? statementCount = default(int?), int? executedStatementCount = default(int?))
            : base(script, runtimeVersion)
        {
            LogsLocation = logsLocation;
            OutputLocation = outputLocation;
            StatementCount = statementCount;
            ExecutedStatementCount = executedStatementCount;
        }

        /// <summary>
        /// Gets the Hive logs location
        /// </summary>
        [JsonProperty(PropertyName = "logsLocation")]
        public string LogsLocation { get; protected set; }

        /// <summary>
        /// Gets the location of Hive job output files (both execution output
        /// and results)
        /// </summary>
        [JsonProperty(PropertyName = "outputLocation")]
        public string OutputLocation { get; protected set; }

        /// <summary>
        /// Gets the number of statements that will be run based on the script
        /// </summary>
        [JsonProperty(PropertyName = "statementCount")]
        public int? StatementCount { get; protected set; }

        /// <summary>
        /// Gets the number of statements that have been run based on the
        /// script
        /// </summary>
        [JsonProperty(PropertyName = "executedStatementCount")]
        public int? ExecutedStatementCount { get; protected set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
        }
    }
}


