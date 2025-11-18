//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    /// <summary>
    /// The HTTP trigger input.
    /// </summary>
    public class HttpRequestTriggerInput
    {
        /// <summary>
        /// Gets or sets the schema of Manual action input.
        /// </summary>
        [JsonProperty(Required = Required.Default)]
        public JToken Schema { get; set; }

        /// <summary>
        /// Gets or sets the relative path.
        /// </summary>
        [JsonProperty(Required = Required.Default)]
        public string RelativePath { get; set; }

        /// <summary>
        /// Gets or sets the method.
        /// </summary>
        [JsonProperty(Required = Required.Default)]
        public HttpMethod Method { get; set; }
    }
}
