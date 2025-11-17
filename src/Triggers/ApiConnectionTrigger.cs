// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk
{
    /// <summary>
    /// Represents an API connection trigger in a workflow.
    /// </summary>
    public class ApiConnectionTrigger : IWorkflowTrigger
    {
        public string Name { get; private set; }

        private FlowTemplateOperationType _type;
        private object _inputs;

        private FlowRecurrence _recurrence;

        public ApiConnectionTrigger(ApiConnectionNotificationActionInput n)
        {
            this._type = FlowTemplateOperationType.ApiConnectionNotification;
            this._inputs = n;
        }
        
        public ApiConnectionTrigger(ApiConnectionActionInput n)
        {
            this._type = FlowTemplateOperationType.ApiConnection;
            this._inputs = n;
        }

        /// <summary>
        /// Gets the trigger definition as a JToken.
        /// </summary>
        public FlowTemplateTrigger GetTriggerDefinition()
        {
            return new FlowTemplateTrigger
            {
                Type = this._type,
                Inputs = this._inputs,
                Recurrence = this._recurrence
                // SplitOn = apiConnectionTriggerInput.SplitOn,
            };
        }

        public void WithName(string name)
        {
            this.Name = name;
        }

        /// <summary>
        /// Sets the recurrence of the conversational flow trigger.
        /// </summary>
        /// <param name="recurrence">The recurrence object.</param>

        public void WithRecurrence(FlowRecurrence recurrence)
        {
            this._recurrence = recurrence;
        }
    }

    public class ApiConnectionTrigger<T> : ApiConnectionTrigger, IOutputWorkflowTrigger<T>
    {
        public ApiConnectionTrigger(ApiConnectionNotificationActionInput n)
            : base(n)
        { }
        
        public ApiConnectionTrigger(ApiConnectionActionInput n)
            : base(n)
        { }

        public ApiConnectionTrigger(ApiConnectionTriggerInput apiConnectionTriggerInput)
            : base(apiConnectionTriggerInput)
        {
        }

        public T TriggerOutput { get; private set; }
    }
}
