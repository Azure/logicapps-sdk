// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk
{
    /// <summary>
    /// Codeful workflows artifacts.
    /// </summary>
    public class CodefulWorkflowsArtifacts
    {
        /// <summary>
        /// Collection of flow templates.
        /// </summary>
        public Dictionary<string, FlowPropertiesDefinition> Flows { get; set; }

        /// <summary>
        /// Collection of API connections.
        /// </summary>
        public ConnectionsArtifacts Connections { get; set; }
    }
}
