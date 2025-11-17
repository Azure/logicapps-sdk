//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    
    /// <summary>
    /// Indicates the flow kind.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum FlowKind
    {
        /// <summary>
        /// Indicates that the flow kind is not specified.
        /// </summary>
        NotSpecified,

        /// <summary>
        /// The stateful flow kind.
        /// </summary>
        Stateful,

        /// <summary>
        /// The stateless flow kind.
        /// </summary>
        Stateless,

        /// <summary>
        /// The agentic flow kind.
        /// </summary>
        Agentic,

        /// <summary>
        /// The agent flow kind.
        /// </summary>
        Agent,
    }
}
