// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

using Newtonsoft.Json;

namespace Microsoft.Azure.Workflows.Sdk
{
    /// <summary>
    /// Represents an API connection trigger in a workflow.
    /// </summary>
    public class ApiConnectionTrigger : IWorkflowTrigger
    {
        /// <summary>
        /// Gets or sets the name of the trigger.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The type of the flow template operation.
        /// </summary>
        private FlowTemplateOperationType _type;

        /// <summary>
        /// The inputs for the trigger.
        /// </summary>
        private object _inputs;

        /// <summary>
        /// Gets the recurrence of the trigger.
        /// </summary>
        FlowRecurrence Recurrence { get; set; }

        /// <summary>
        /// Gets or sets the trigger split on.
        /// </summary>
        [JsonProperty(Required = Required.Default)]
        public string SplitOn { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiConnectionTrigger"/> class with notification input.
        /// </summary>
        /// <param name="input">The API connection notification action input.</param>
        /// <param name="triggerName">The trigger name.</param>
        public ApiConnectionTrigger(
            ApiConnectionNotificationActionInput input,
            string triggerName = null)
        {
            this._type = FlowTemplateOperationType.ApiConnectionNotification;
            this._inputs = input;
            this.Name = triggerName ?? "ApiConnectionTrigger";
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiConnectionTrigger"/> class with action input.
        /// </summary>
        /// <param name="input">The API connection action input.</param>
        /// <param name="triggerName">The trigger name.</param>
        /// <param name="recurrence">The recurrence configuration for the trigger.</param>
        /// <param name="enableSplitOn">Enable spliton trigger</param>
        public ApiConnectionTrigger(
            ApiConnectionActionInput input,
            string triggerName = null,
            FlowRecurrence recurrence = null,
            bool enableSplitOn = false)
        {
            this._type = FlowTemplateOperationType.ApiConnection;
            this.Name = triggerName ?? "ApiConnectionTrigger";
            this._inputs = input;
            this.Recurrence = recurrence ?? new FlowRecurrence
                {
                    Frequency = FlowRecurrenceFrequency.Minute,
                    Interval = 1,
                };
            this.SplitOn = enableSplitOn ? "@triggerOutputs()?['body']" : null;
        }

        /// <summary>
        /// Gets the trigger definition as a flow template trigger.
        /// </summary>
        /// <returns>A <see cref="FlowTemplateTrigger"/> containing the trigger configuration.</returns>
        public FlowTemplateTrigger GetTriggerDefinition()
        {
            return new FlowTemplateTrigger
            {
                Type = this._type,
                Inputs = this._inputs,
                Recurrence = this.Recurrence,
                SplitOn = this.SplitOn,
            };
        }
    }

    /// <summary>
    /// Represents a generic API connection trigger with typed output in a workflow.
    /// </summary>
    /// <typeparam name="T">The type of the trigger output.</typeparam>
    public class ApiConnectionTrigger<T> : ApiConnectionTrigger, IBodyWorkflowTrigger<T>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiConnectionTrigger{T}"/> class with notification input.
        /// </summary>
        /// <param name="input">The API connection notification action input.</param>
        /// <param name="triggerName">The trigger name.</param>
        public ApiConnectionTrigger(ApiConnectionNotificationActionInput input, string triggerName = null)
            : base(input, triggerName)
        { }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiConnectionTrigger{T}"/> class with action input.
        /// </summary>
        /// <param name="n">The API connection action input.</param>
        /// <param name="triggerName">The trigger name.</param>
        /// <param name="recurrence">The recurrence configuration for the trigger.</param>
        /// <param name="enableSplitOn">Enable spliton trigger</param>
        public ApiConnectionTrigger(ApiConnectionActionInput input, string triggerName = null, FlowRecurrence recurrence = null, bool enableSplitOn = false)
            : base(input, triggerName, recurrence, enableSplitOn)
        { 
        }

        /// <summary>
        /// Gets the typed output of the trigger.
        /// </summary>
        public T TriggerBody { get; private set; }
    }
}
