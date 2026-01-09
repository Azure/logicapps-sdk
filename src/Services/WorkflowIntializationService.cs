// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Agents.Services
{
    using Microsoft.Extensions.Hosting;

    /// <summary>
    /// Service that initializes workflows on application startup.
    /// </summary>
    public class WorkflowInitializationService : IHostedService
    {
        /// <summary>
        /// Creates and initializes workflows when the service starts.
        /// </summary>
        /// <param name="cancellationToken">The cancellation token.</param>
        public Task StartAsync(CancellationToken cancellationToken)
        {
            WorkflowBuilderFactory.CreateWorkflows(cancellationToken);

            return Task.CompletedTask;
        }

        /// <summary>
        /// Executes cleanup operations when the service stops.
        /// </summary>
        /// <param name="cancellationToken">The cancellation token.</param>
        public Task StopAsync(CancellationToken cancellationToken) => Task.CompletedTask;
    }
}
