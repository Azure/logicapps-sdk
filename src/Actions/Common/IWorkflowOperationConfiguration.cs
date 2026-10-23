// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk
{
    using Newtonsoft.Json.Linq;

    public interface IWorkflowOperationConfiguration
    {
    }

    #region Shared Configurations

    public interface IRetryPolicyConfiguration :
        IWorkflowOperationConfiguration
    {
        internal RetryPolicy RetryPolicy { get; set; }
    }

    public interface ISecureInputsConfiguration :
        IWorkflowOperationConfiguration
    {
        internal bool SecureInputs { get; set; }
    }

    public interface ISecureOutputsConfiguration :
        IWorkflowOperationConfiguration
    {
        internal bool SecureOutputs { get; set; }
    }

    public interface ISecureInputsAndOutputsConfiguration :
        ISecureInputsConfiguration
    {
    }

    #endregion

    #region Action configurations

    public interface ITrackedPropertiesConfiguration :
        IWorkflowOperationConfiguration
    {
        internal IDictionary<string, Func<JToken>> TrackedProperties { get; }
    }

    public interface IIterationConcurrencyConfiguration :
        IWorkflowOperationConfiguration
    {
        internal int? MaximumParallelIterations { get; set; }
    }

    #endregion

    #region Trigger configurations

    public interface ITriggerConcurrencyConfiguration :
        IWorkflowOperationConfiguration
    {
        internal int? ConcurrentRuns { get; set; }

        internal int? MaximumWaitingRuns { get; set; }
    }

    public interface IClientTrackingIdConfiguration :
        IWorkflowOperationConfiguration
    {
        internal Func<string> ClientTrackingId { get; set; }
    }

    public interface IRequestSchemaValidationConfiguration :
        IWorkflowOperationConfiguration
    {
        internal bool SchemaValidationEnabled { get; set; }
    }

    #endregion

}
