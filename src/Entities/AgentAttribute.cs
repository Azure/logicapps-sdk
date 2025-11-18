// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Entities
{
    /// <summary>
    /// Agent attribute class.
    /// </summary>
    public class AgentAttribute : Attribute
    {
        /// <summary>
        /// The connector name.
        /// </summary>
        public string ConnectorName { get; set; }

        /// <summary>
        /// The connector type.
        /// </summary>  
        public ConnectorType Type { get; set; }

        /// <summary>
        /// The connector id.
        /// </summary>
        public string Id { get; set; }
    }
}
