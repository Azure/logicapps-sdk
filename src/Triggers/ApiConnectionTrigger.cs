// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

using Newtonsoft.Json;

namespace Microsoft.Azure.Workflows.Sdk
{
    public sealed class ApiConnectionTriggerConfiguration :
        IRetryPolicyConfiguration,
        ISecureInputsConfiguration,
        ISecureOutputsConfiguration,
        ITriggerConcurrencyConfiguration,
        IClientTrackingIdConfiguration
    {
        RetryPolicy IRetryPolicyConfiguration.RetryPolicy { get; set; }
        bool ISecureInputsConfiguration.SecureInputs { get; set; }
        bool ISecureOutputsConfiguration.SecureOutputs { get; set; }
        int? ITriggerConcurrencyConfiguration.ConcurrentRuns { get; set; }
        int? ITriggerConcurrencyConfiguration.MaximumWaitingRuns { get; set; }
        Func<string> IClientTrackingIdConfiguration.ClientTrackingId { get; set; }
    }

    public sealed class ApiConnectionPollingTriggerConfiguration :
        IRetryPolicyConfiguration,
        ISecureInputsConfiguration,
        ISecureOutputsConfiguration,
        ITriggerConcurrencyConfiguration,
        IClientTrackingIdConfiguration,
        IRecurrenceConfiguration
    {
        RetryPolicy IRetryPolicyConfiguration.RetryPolicy { get; set; }
        bool ISecureInputsConfiguration.SecureInputs { get; set; }
        bool ISecureOutputsConfiguration.SecureOutputs { get; set; }
        int? ITriggerConcurrencyConfiguration.ConcurrentRuns { get; set; }
        int? ITriggerConcurrencyConfiguration.MaximumWaitingRuns { get; set; }
        Func<string> IClientTrackingIdConfiguration.ClientTrackingId { get; set; }
        FlowRecurrence IRecurrenceConfiguration.Recurrence { get; set; }
    }

    /// <summary>
    /// Represents an API connection trigger in a workflow.
    /// </summary>
    public class ApiConnectionTrigger : WorkflowTriggerBase<ApiConnectionTriggerConfiguration>
    {
        /// <summary>
        /// The type of the flow template operation.
        /// </summary>
        private FlowTemplateOperationType _type;

        /// <summary>
        /// The inputs for the trigger.
        /// </summary>
        private object _inputs;

        /// <summary>
        /// Gets or sets the trigger split on.
        /// </summary>
        [JsonProperty(Required = Required.Default)]
        public string SplitOn { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiConnectionTrigger"/> class with notification input.
        /// </summary>
        /// <param name="input">The API connection notification action input.</param>
        internal ApiConnectionTrigger(ApiConnectionNotificationActionInput input)
        {
            this._type = FlowTemplateOperationType.ApiConnectionNotification;
            this._inputs = input;
        }

        /// <summary>
        /// Gets the trigger definition as a flow template trigger.
        /// </summary>
        /// <returns>A <see cref="FlowTemplateTrigger"/> containing the trigger configuration.</returns>
        internal override FlowTemplateTrigger BuildTriggerDefinition(FlowKind? flowKind = null)
        {
            return new FlowTemplateTrigger
            {
                Type = this._type,
                Inputs = this._inputs,
                SplitOn = this.SplitOn,
            };
        }
    }

    /// <summary>
    /// Represents a generic API connection trigger with typed output in a workflow.
    /// </summary>
    /// <typeparam name="T">The type of the trigger output.</typeparam>
    public class ApiConnectionTrigger<T> :
        ApiConnectionTrigger,
        IBodyWorkflowTrigger<T, ApiConnectionTriggerConfiguration>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiConnectionTrigger{T}"/> class with notification input.
        /// </summary>
        /// <param name="input">The API connection notification action input.</param>
        internal ApiConnectionTrigger(ApiConnectionNotificationActionInput input)
            : base(input)
        { }

        /// <summary>
        /// Gets the typed output of the trigger.
        /// </summary>
        public T TriggerBody { get; private set; }
    }

    /// <summary>
    /// Represents a polling API connection trigger in a workflow.
    /// </summary>
    internal class ApiConnectionPollingTrigger :
        WorkflowTriggerBase<ApiConnectionPollingTriggerConfiguration>
    {
        private readonly ApiConnectionActionInput input;

        /// <summary>
        /// Gets or sets the trigger split on.
        /// </summary>
        [JsonProperty(Required = Required.Default)]
        public string SplitOn { get; set; }

        internal ApiConnectionPollingTrigger(
            ApiConnectionActionInput input,
            bool enableSplitOn = false)
        {
            this.input = input;
            this.SplitOn = enableSplitOn ? "@triggerOutputs()?['body']" : null;
        }

        internal override FlowTemplateTrigger BuildTriggerDefinition(FlowKind? flowKind = null)
        {
            return new FlowTemplateTrigger
            {
                Type = FlowTemplateOperationType.ApiConnection,
                Inputs = this.input,
                SplitOn = this.SplitOn,
            };
        }
    }

    /// <summary>
    /// Represents a polling API connection trigger with typed output in a workflow.
    /// </summary>
    /// <typeparam name="T">The type of the trigger output.</typeparam>
    internal sealed class ApiConnectionPollingTrigger<T> :
        ApiConnectionPollingTrigger,
        IBodyWorkflowTrigger<T, ApiConnectionPollingTriggerConfiguration>
    {
        internal ApiConnectionPollingTrigger(
            ApiConnectionActionInput input,
            bool enableSplitOn = false)
            : base(input, enableSplitOn)
        {
        }

        /// <summary>
        /// Gets the typed output of the trigger.
        /// </summary>
        public T TriggerBody { get; private set; }
    }
}
