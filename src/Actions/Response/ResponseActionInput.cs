//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    /// <summary>
    /// The <c>Response</c> action input.
    /// </summary>
    public class ResponseActionInput
    {
        /// <summary>
        /// Gets or sets the status code for the response.
        /// </summary>
        [JsonProperty(Required = Required.Always)]
        public int StatusCode { get; set; }

        /// <summary>
        /// Gets or sets the headers for the response.
        /// </summary>
        [JsonProperty(Required = Required.Default)]
        public Dictionary<string, string> Headers { get; set; }

        /// <summary>
        /// Gets or sets the body of the response.
        /// </summary>
        [JsonProperty(Required = Required.Default)]
        public JToken Body { get; set; }

        /// <summary>
        /// Gets or sets the schema of the response.
        /// </summary>
        [JsonProperty(Required = Required.Default)]
        public JToken Schema { get; set; }
    }
}
