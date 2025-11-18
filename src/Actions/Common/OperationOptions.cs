//-----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//-----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk
{
    using System;

    /// <summary>
    /// The operation options.
    /// </summary>
    [Flags]
    public enum OperationOptions
    {
        /// <summary>
        /// No operation options are specified.
        /// </summary>
        None = 0,

        /// <summary>
        /// Do not to use async pattern.
        /// </summary>
        DisableAsyncPattern = 1 << 0,

        /// <summary>
        /// Execute in sequential manner.
        /// </summary>
        Sequential = 1 << 1,

        /// <summary>
        /// Execute single instance mode.
        /// </summary>
        SingleInstance = 1 << 2,

        /// <summary>
        /// Execute in asynchronous mode.
        /// </summary>
        Asynchronous = 1 << 3,

        /// <summary>
        /// Do not to use automatic decompression.
        /// </summary>
        DisableAutomaticDecompression = 1 << 4,

        /// <summary>
        /// Enable trigger input schema validation.
        /// </summary>
        EnableSchemaValidation = 1 << 5,

        /// <summary>
        /// Suppress the workflow headers.
        /// </summary>
        SuppressWorkflowHeaders = 1 << 6,

        /// <summary>
        /// Fail when the limits reached.
        /// </summary>
        FailWhenLimitsReached = 1 << 7,

        /// <summary>
        /// Suppress the workflow headers on response.
        /// </summary>
        SuppressWorkflowHeadersOnResponse = 1 << 8,

        /// <summary>
        /// Includes the authorization headers in outputs.
        /// </summary>
        IncludeAuthorizationHeadersInOutputs = 1 << 9,

        /// <summary>
        /// Persists request context for concurrency controlled runs.
        /// </summary>
        PersistRequestContextForConcurrencyControl = 1 << 10,

        /// <summary>
        /// Fail when current iteration of until iteration.
        /// </summary>
        FailWhenIterationFailed = 1 << 11,

        /// <summary>
        /// Persist the HTTP content and don't apply implicit JSON formatting for example for JSON payload and treat the content as binary.
        /// </summary>
        PreserveHttpContent = 1 << 12,
    }
}
