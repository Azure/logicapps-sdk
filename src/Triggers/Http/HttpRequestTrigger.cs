// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk
{
    using Newtonsoft.Json.Linq;

    public sealed class HttpRequestTriggerConfiguration :
        IWorkflowOperationConfiguration,
        ISecureInputsConfigurationHolder,
        ISecureOutputsConfigurationHolder,
        ITriggerConcurrencyConfigurationHolder,
        IClientTrackingIdConfigurationHolder,
        IRequestSchemaValidationConfigurationHolder
    {
        public bool SecureInputs { get; set; }
        public bool SecureOutputs { get; set; }
        public int? ConcurrentRuns { get; set; }
        public int? MaximumWaitingRuns { get; set; }
        public string ClientTrackingId { get; set; }
        public bool SchemaValidationEnabled { get; set; }
    }

    /// <summary>
    /// Represents a workflow trigger for HTTP requests, providing a strongly-typed output.
    /// </summary>
    public class HttpRequestTrigger : WorkflowTriggerBase<HttpRequestTriggerConfiguration>, IOutputWorkflowTrigger<HttpRequestTriggerOutput>
    {
        /// <summary>
        /// The request input parameters.
        /// </summary>
        private HttpRequestTriggerInput input;

        /// <summary>
        /// Initializes a new instance of the <see cref="HttpRequestTrigger"/> class.
        /// </summary>
        /// <param name="method">The HTTP method to use for the request (optional).</param>
        /// <param name="requestBodyJsonSchema">The request body JSON schema (optional).</param>
        /// <param name="relativePath">The relative path (optional).</param>
        internal HttpRequestTrigger(
            HttpMethod method = null,
            JToken requestBodyJsonSchema = null,
            string relativePath = null)
        {
            this.Name = "when_an_HTTP_request_is_received";

            if (method != null || requestBodyJsonSchema != null || relativePath != null)
            {
                this.input = new HttpRequestTriggerInput
                {
                    Method = method?.ToString(),
                    Schema = requestBodyJsonSchema,
                    RelativePath = relativePath
                };
            }
            
        }

        /// <summary>
        /// Gets the trigger definition for the HTTP request trigger.
        /// </summary>
        /// <returns>
        /// A <see cref="FlowTemplateTrigger"/> configured for HTTP request operations.
        /// </returns>
        internal override FlowTemplateTrigger BuildTriggerDefinition(FlowKind? flowKind = null)
        {
            // Implementation for getting the trigger definition
            return new FlowTemplateTrigger
            {
                Type = FlowTemplateOperationType.Request,
                Kind = FlowTemplateOperationKind.Http,
                Inputs = this.input?.ToJToken(),
            };
        }

        /// <summary>
        /// Gets the output parameters for the HTTP trigger.
        /// </summary>
        public HttpRequestTriggerOutput TriggerOutput { get; private set; } = new HttpRequestTriggerOutput();
    }
}
