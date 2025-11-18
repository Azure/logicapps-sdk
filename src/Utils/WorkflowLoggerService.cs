// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Extensions.Logging;

    /// <summary>
    /// Provides logging services for workflow operations.
    /// </summary>
    public class WorkflowLoggerService
    {
        /// <summary>
        /// Logger.
        /// </summary>
        private ILogger Logger;

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowLoggerService"/> class.
        /// </summary>
        /// <param name="loggerFactory">The logger factory.</param>
        public WorkflowLoggerService(ILoggerFactory loggerFactory)
        {
            this.Logger = loggerFactory?.CreateLogger(categoryName: "Debug");
        }

        /// <summary>
        /// Logs an informational message.
        /// </summary>
        /// <param name="message">The message to log.</param>
        public void LogDebug(string message)
        {
            this.Logger?.LogDebug(message);
        }

        /// <summary>
        /// Logs an informational message.
        /// </summary>
        /// <param name="message">The message to log.</param>
        public void LogInformation(string message)
        {
            this.Logger?.LogInformation(message);
        }

        /// <summary>
        /// Logs an error message with exception details.
        /// </summary>
        /// <param name="message">The error message to log.</param>
        /// <param name="exception">The exception to log.</param>
        public void LogError(string message, Exception exception)
        {
            this.Logger?.LogError(exception, message);
        }
    }
}
