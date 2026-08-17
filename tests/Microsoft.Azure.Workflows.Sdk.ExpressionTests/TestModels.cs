// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.ExpressionTests
{
    using Newtonsoft.Json;

    /// <summary>
    /// Simple POCO used to exercise object/member-init conversion paths.
    /// </summary>
    public class Poco
    {
        public string Name { get; set; }

        public int Count { get; set; }

        [JsonProperty("renamed")]
        public string Tag { get; set; }
    }
}
