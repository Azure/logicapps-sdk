//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Zapiernlaip
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

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
        [WorkflowExpressionFactory(nameof(__BuildAction))]
        public IBodyWorkflowAction<ActionPostResponse> Action([WorkflowExpression] Func<string> actionId, [WorkflowExpression] Func<string> bodyinstructions, [WorkflowExpression] Func<bool> bodypreviewOnly = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zapiernlaip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ActionPostResponse> __BuildAction(WorkflowExpression<string> actionId, WorkflowExpression<string> bodyinstructions, WorkflowExpression<bool> bodypreviewOnly = null)
        {
            WorkflowExpression.Validate(actionId, nameof(actionId), required: true);
            WorkflowExpression.Validate(bodyinstructions, nameof(bodyinstructions), required: true);
            WorkflowExpression.Validate(bodypreviewOnly, nameof(bodypreviewOnly), required: false);
            return new DeferredBodyAction<ActionPostResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v1/dynamic/exposed/{0}/execute/", ExpressionConverter.ConvertWithUrlEncoding(actionId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["instructions"] = ExpressionConverter.ConvertO(bodyinstructions);
                if (bodypreviewOnly != null)
                {
                    if (bodypreviewOnly != null)
                    {
                        body["preview_only"] = ExpressionConverter.ConvertO(bodypreviewOnly);
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