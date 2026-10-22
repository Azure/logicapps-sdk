// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk
{
    using Newtonsoft.Json.Linq;

    /// <summary>
    /// Provides access to managed API connector actions. Managed connector actions are auto-generated
    /// from Azure connector definitions and are available as extension methods on this class.
    /// Access through <c>WorkflowActions.Managed</c>.
    /// </summary>
    /// <remarks>
    /// This is a partial class. Connector-specific methods are generated in separate source files
    /// under the <c>generated/managed</c> directory.
    /// </remarks>
    /// <seealso cref="WorkflowActions"/>
    public partial class WorkflowManagedActions { }

    #region Action Configurations

    public sealed class ApiConnectionActionConfiguration :
        IWorkflowOperationConfiguration,
        IRetryPolicyConfigurationHolder,
        ITrackedPropertiesConfigurationHolder,
        ISecureInputsConfigurationHolder,
        ISecureOutputsConfigurationHolder
    {
        public RetryPolicy RetryPolicy { get; set; }
        public IDictionary<string, JToken> TrackedProperties { get; } = new Dictionary<string, JToken>(StringComparer.Ordinal);
        public bool SecureInputs { get; set; }
        public bool SecureOutputs { get; set; }
    }

    #endregion
}
