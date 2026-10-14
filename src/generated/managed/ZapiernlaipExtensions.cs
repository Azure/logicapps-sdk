//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Zapiernlaip
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class ZapiernlaipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zapiernlaip")]
        public IBodyWorkflowAction<ExposedActionResponseSchema> ExposedGet()
        {
            var apiCallPath = "/api/v1/exposed/";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ExposedActionResponseSchema>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zapiernlaip")]
        public IBodyWorkflowAction<ActionPostResponse> Action(Expression<Func<string>> actionId, Expression<Func<string>> bodyinstructions, Expression<Func<bool>> bodypreviewOnly = null)
        {
            var __workflow_actionId = actionId == null ? null : WorkflowExpression.Compile(actionId);
            WorkflowExpression.Validate(__workflow_actionId, nameof(actionId), required: true);
            var __workflow_bodyinstructions = bodyinstructions == null ? null : WorkflowExpression.Compile(bodyinstructions);
            WorkflowExpression.Validate(__workflow_bodyinstructions, nameof(bodyinstructions), required: true);
            var __workflow_bodypreviewOnly = bodypreviewOnly == null ? null : WorkflowExpression.Compile(bodypreviewOnly);
            WorkflowExpression.Validate(__workflow_bodypreviewOnly, nameof(bodypreviewOnly), required: false);
            return new DeferredBodyAction<ActionPostResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v1/dynamic/exposed/{0}/execute/", ExpressionConverter.ConvertWithUrlEncoding(__workflow_actionId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["instructions"] = ExpressionConverter.ConvertO(__workflow_bodyinstructions);
                if (__workflow_bodypreviewOnly != null)
                {
                    if (__workflow_bodypreviewOnly != null)
                    {
                        body["preview_only"] = ExpressionConverter.ConvertO(__workflow_bodypreviewOnly);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["preview_only"] = false;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ActionPostResponse>(callPayload);
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

    public class ActionPostResponse
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
