//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Zapiernlaip
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ZapiernlaipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zapiernlaip")]
        public IBodyWorkflowAction<ExposedActionResponseSchema, ApiConnectionActionConfiguration> ExposedGet()
        {
            return new DeferredBodyAction<ExposedActionResponseSchema, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v1/exposed/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ExposedActionResponseSchema>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zapiernlaip")]
        public IBodyWorkflowAction<ActionResponse, ApiConnectionActionConfiguration> Action(Expression<Func<string>> actionId, Expression<Func<BodyInput>> body)
        {
            var __workflow_actionId = WorkflowExpression.Compile(actionId, nameof(actionId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ActionResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/dynamic/exposed/{0}/execute/", __workflow_actionId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ActionResponse>(callPayload);
            });
        }
    }

    public class ZapiernlaipTriggers([ConnectionName] string connectionId)
    {
    }

    public class ExposedActionResponseSchema
    {
        [JsonProperty("results")]
        public ExposedActionSchema[] Results { get; set; }

        [JsonProperty("configuration_link")]
        public string ConfigurationLink { get; set; }
    }

    public class ExposedActionSchema
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("operation_id")]
        public string OperationId { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("params")]
        public JToken Params { get; set; }
    }

    public class ActionResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("action_used")]
        public string ActionUsed { get; set; }

        [JsonProperty("input_params")]
        public JToken InputParams { get; set; }

        [JsonProperty("review_url")]
        public string ReviewUrl { get; set; }

        [JsonProperty("result")]
        public JToken Result { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("error")]
        public string Error { get; set; }
    }

    public class BodyInput
    {
        public BodyInput(string instructions)
        {
            this.Instructions = instructions;
        }

        [JsonProperty("instructions", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Instructions { get; set; }

        [JsonProperty("preview_only", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? PreviewOnly { get; set; } = false;
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Zapiernlaip;

    public partial class WorkflowManagedActions
    {
        public ZapiernlaipActions Zapiernlaip(string connectionId) => new ZapiernlaipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public ZapiernlaipTriggers Zapiernlaip(string connectionId) => new ZapiernlaipTriggers(connectionId);
    }
}