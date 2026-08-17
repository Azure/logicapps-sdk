// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.ExpressionEvaluationTests
{
    using Newtonsoft.Json;

    /// <summary>
    /// POCO payload type used by object-serialization expressions. Mirrors the model used in
    /// the converter goal tests (Tag carries a [JsonProperty] rename).
    /// </summary>
    public class Poco
    {
        public string Name { get; set; }

        public int Count { get; set; }

        [JsonProperty("renamed")]
        public string Tag { get; set; }
    }
}
