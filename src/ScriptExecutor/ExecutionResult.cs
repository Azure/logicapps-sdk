// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk
{
    /// <summary>
    /// The execution result.
    /// </summary>
    public class ExecutionResult
    {
        /// <summary>
        /// Gets or sets the outputs.
        /// </summary>
        public string Outputs { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the invocation succeeded.
        /// </summary>
        public bool Succeeded { get; set; }

        /// <summary>
        /// Gets or sets the exception.
        /// </summary>
        public ScriptErrorResponse Error { get; set; }
    }
}
