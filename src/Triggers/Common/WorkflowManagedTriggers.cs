// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk
{
    /// <summary>
    /// Provides access to managed API connector triggers. Managed connector triggers are auto-generated
    /// from Azure connector definitions and are available as extension methods on this class.
    /// Access through <c>WorkflowTriggers.Managed</c>.
    /// </summary>
    /// <remarks>
    /// This is a partial class. Connector-specific methods are generated in separate source files
    /// under the <c>generated/managed</c> directory.
    /// </remarks>
    /// <seealso cref="WorkflowTriggers"/>
    public partial class WorkflowManagedTriggers
    {
    }

    #region Trigger Configurations

    public sealed class ApiConnectionTriggerConfiguration :
        IWorkflowOperationConfiguration,
        IRetryPolicyConfigurationHolder,
        ISecureInputsConfigurationHolder,
        ISecureOutputsConfigurationHolder,
        ITriggerConcurrencyConfigurationHolder,
        IClientTrackingIdConfigurationHolder
    {
        public RetryPolicy RetryPolicy { get; set; }
        public bool SecureInputs { get; set; }
        public bool SecureOutputs { get; set; }
        public int? ConcurrentRuns { get; set; }
        public int? MaximumWaitingRuns { get; set; }
        public string ClientTrackingId { get; set; }
    }

    #endregion
}
