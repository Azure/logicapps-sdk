// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.CSharpExpressionTests
{
    using Newtonsoft.Json;

    /// <summary>
    /// Simple POCO used to exercise object/member-init conversion paths.
    /// Mirrors the model in the Logic App expression test project.
    /// </summary>
    public class Poco
    {
        public string Name { get; set; }

        public int Count { get; set; }

        [JsonProperty("renamed")]
        public string Tag { get; set; }
    }
}
