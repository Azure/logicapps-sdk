// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk
{
    using Newtonsoft.Json.Linq;
    
    public sealed class ControlActionConfiguration :
        ITrackedPropertiesConfiguration
    {
        public IDictionary<string, JToken> TrackedProperties { get; } = new Dictionary<string, JToken>(StringComparer.Ordinal);
    }
}
