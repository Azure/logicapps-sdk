//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk
{
    using Newtonsoft.Json;

    /// <summary>
    /// The retry-able action input.
    /// </summary>
    /// <remarks>
    /// This input shape is retained for workflow-definition compatibility. Configure retries through
    /// <see cref="WorkflowSettingsExtensions.WithRetryPolicy{TOperation}(TOperation, RetryPolicy)"/>.
    /// </remarks>
    public class RetryableActionInput
    {
        /// <summary>
        /// Gets or sets the operation options.
        /// </summary>
        [JsonProperty(Required = Required.Default)]
        public OperationOptions? OperationOptions { get; set; }

        /// <summary>
        /// Gets or sets the retry policy.
        /// </summary>
        [JsonProperty(Required = Required.Default)]
        public RetryPolicy RetryPolicy { get; set; }
    }
}
