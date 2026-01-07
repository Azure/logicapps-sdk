// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk
{
    using Newtonsoft.Json.Linq;

    /// <summary>
    /// The invocation details.
    /// </summary>
    public class InvocationDetails
    {
        /// <summary>
        /// Gets or sets the inputs.
        /// </summary>
        public JToken Inputs { get; set; }

        /// <summary>
        /// Gets or sets the script file name.
        /// </summary>
        public string ScriptFileName { get; set; }

        /// <summary>
        /// Gets or sets the session id.
        /// </summary>
        public string SessionId { get; set; }

        /// <summary>
        /// Gets or sets the path for assemblies.
        /// </summary>
        public string AssembliesPath { get; set; }
    }
}
