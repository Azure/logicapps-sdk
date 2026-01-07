// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk
{
    using Newtonsoft.Json;

    /// <summary>
    /// CSharp script code input.
    /// </summary>
    public class CSharpScriptCodeActionInput
    {
        /// <summary>
        /// Gets or sets the user code file.
        /// </summary>
        [JsonProperty(Required = Required.Always)]
        public string CodeFile { get; set; }
    }
}
