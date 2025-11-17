//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    /// <summary>
    /// Represents the output parameters for an HTTP trigger.
    /// </summary>
    public class HttpRequestTriggerOutput : ITriggerOutput
    {
        /// <summary>
        /// Gets or sets the queries of the request.
        /// </summary>
        [JsonProperty(Required = Required.Default)]
        public Dictionary<string, string> Queries { get; set; }

        /// <summary>
        /// Gets or sets the headers for the request.
        /// </summary>
        [JsonProperty(Required = Required.Default)]
        public Dictionary<string, string> Headers { get; set; }

        /// <summary>
        /// Gets or sets the body of the request.
        /// </summary>
        [JsonProperty(Required = Required.Default)]
        public JToken Body { get; set; }
    }
}
