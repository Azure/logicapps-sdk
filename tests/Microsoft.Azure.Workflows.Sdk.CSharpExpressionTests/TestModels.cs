// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.CSharpExpressionTests
{
    using Newtonsoft.Json;

    /// <summary>
    /// Input model for source-compiled structural JSON, including renamed properties.
    /// </summary>
    public class Poco
    {
        public string Name { get; set; }

        public int Count { get; set; }

        [JsonProperty("renamed")]
        public string Tag { get; set; }
    }
}
