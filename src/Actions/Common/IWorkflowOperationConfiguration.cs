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

    public interface IRetryPolicyConfigurationHolder
    {
        RetryPolicy RetryPolicy { get; set; }
    }

    public interface ISecureInputsConfigurationHolder
    {
        bool SecureInputs { get; set; }
    }

    public interface ISecureOutputsConfigurationHolder
    {
        bool SecureOutputs { get; set; }
    }

    public interface ISecureInputsAndOutputsConfigurationHolder :
        ISecureInputsConfigurationHolder
    {
    }

    #endregion

    #region Action configurations

    public interface ITrackedPropertiesConfigurationHolder
    {
        IDictionary<string, JToken> TrackedProperties { get; }
    }

    public interface IIterationConcurrencyConfigurationHolder
    {
        int? MaximumParallelIterations { get; set; }
    }

    #endregion

    #region Trigger configurations

    public interface ITriggerConcurrencyConfigurationHolder
    {
        int? ConcurrentRuns { get; set; }

        int? MaximumWaitingRuns { get; set; }
    }

    public interface IClientTrackingIdConfigurationHolder
    {
        string ClientTrackingId { get; set; }
    }

    public interface IRequestSchemaValidationConfigurationHolder
    {
        bool SchemaValidationEnabled { get; set; }
    }

    #endregion

}
