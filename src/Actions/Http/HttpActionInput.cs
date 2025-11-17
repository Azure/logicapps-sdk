//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    /// <summary>
    /// The http action input.
    /// </summary>
    public class HttpActionInput : RetryableActionInput
    {
        /// <summary>
        /// Gets or sets the Uri for the request.
        /// </summary>
        [JsonProperty(Required = Required.Always)]
        public string Uri { get; set; }

        /// <summary>
        /// Gets or sets the method of the request.
        /// </summary>
        [JsonProperty(Required = Required.Always)]
        public string Method { get; set; }

        /// <summary>
        /// Gets or sets the queries of the request.
        /// </summary>
        [JsonProperty(Required = Required.Default)]
        public Dictionary<string, string> Queries { get; set; }

        /// <summary>
        /// Gets or sets the cookie for the request.
        /// </summary>
        [JsonProperty(Required = Required.Default)]
        public string Cookie { get; set; }

        /// <summary>
        /// Gets or sets the body of the request.
        /// </summary>
        [JsonProperty(Required = Required.Default)]
        public JToken Body { get; set; }

        /// <summary>
        /// Gets or sets the headers for the request.
        /// </summary>
        [JsonProperty(Required = Required.Default)]
        public Dictionary<string, string> Headers { get; set; }
    }
}
