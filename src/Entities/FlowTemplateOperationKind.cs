//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    
    /// <summary>
    /// The kind of the flow operation.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum FlowTemplateOperationKind
    {
        /// <summary>
        /// The flow operation kind was not specified.
        /// </summary>
        NotSpecified,

        /// <summary>
        /// The Http operation kind.
        /// </summary>
        Http,
        
        /// <summary>
        /// The Agent operation kind.
        /// </summary>
        Agent,

        /// <summary>
        /// The polling trigger operation kind.
        /// </summary>
        Polling,
    }
}
