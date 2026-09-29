// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk
{
    /// <summary>
    /// Provides the top-level entry point for creating workflow actions. Use the <see cref="BuiltIn"/>
    /// property to access built-in action types (HTTP, Compose, Response, Custom Code, etc.) and the
    /// <see cref="Managed"/> and <see cref="ServiceProviders"/> properties to access connector actions.
    /// </summary>
    /// <example>
    /// <code>
    /// // Create a built-in Compose action
    /// var compose = WorkflowActions.BuiltIn.Compose(inputs: () => "Hello").WithName("Greet");
    ///
    /// // Create a managed connector action
    /// var sharepoint = WorkflowActions.Managed.Sharepointonline("sharepoint").GetItems(
    ///     dataset: () => "https://example.sharepoint.com",
    ///     table: () => "my-list-id");
    /// </code>
    /// </example>
    /// <seealso cref="WorkflowBuiltInActions"/>
    /// <seealso cref="WorkflowManagedActions"/>
    public static class WorkflowActions
    {
        /// <summary>
        /// Gets the factory for built-in workflow actions such as HTTP, Compose, Response, Custom Code,
        /// and Nested Workflow actions.
        /// </summary>
        public static WorkflowBuiltInActions BuiltIn = new WorkflowBuiltInActions();

        /// <summary>
        /// Gets the factory for managed connector actions (e.g., SharePoint, Service Bus, SQL Server).
        /// Managed connector actions are auto-generated from connector definitions and available as
        /// extension methods on this instance.
        /// </summary>
        public static WorkflowManagedActions Managed = new WorkflowManagedActions();

        /// <summary>
        /// Gets the factory for service provider actions (e.g., SQL, Service Bus, Azure Blob).
        /// Service provider actions are auto-generated from operation manifests.
        /// </summary>
        public static WorkflowServiceProviderActions ServiceProviders = new WorkflowServiceProviderActions();
    }
}
