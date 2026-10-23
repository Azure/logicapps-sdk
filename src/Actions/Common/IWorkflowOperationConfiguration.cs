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
        RetryPolicy RetryPolicy { get; set; }
    }

    public interface ISecureInputsConfiguration :
        IWorkflowOperationConfiguration
    {
        bool SecureInputs { get; set; }
    }

    public interface ISecureOutputsConfiguration :
        IWorkflowOperationConfiguration
    {
        bool SecureOutputs { get; set; }
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
        IDictionary<string, JToken> TrackedProperties { get; }
    }

    public interface IIterationConcurrencyConfiguration :
        IWorkflowOperationConfiguration
    {
        int? MaximumParallelIterations { get; set; }
    }

    #endregion

    #region Trigger configurations

    public interface ITriggerConcurrencyConfiguration :
        IWorkflowOperationConfiguration
    {
        int? ConcurrentRuns { get; set; }

        int? MaximumWaitingRuns { get; set; }
    }

    public interface IClientTrackingIdConfiguration :
        IWorkflowOperationConfiguration
    {
        string ClientTrackingId { get; set; }
    }

    public interface IRequestSchemaValidationConfiguration :
        IWorkflowOperationConfiguration
    {
        bool SchemaValidationEnabled { get; set; }
    }

    #endregion

}
