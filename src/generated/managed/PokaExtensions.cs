//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Poka
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class PokaActions([ConnectionName] string connectionId)
    {
    }

    public class PokaTriggers([ConnectionName] string connectionId)
    {

        [WorkflowExpressionFactory(nameof(__BuildCreateWebhook))]
        public IBodyWorkflowTrigger<WebHookDetail> CreateWebhook([WorkflowExpression] Func<string> bodyselectALanguage, [WorkflowExpression] Func<string> item, [WorkflowExpression] Func<string> operationName, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<WebHookDetail> __BuildCreateWebhook(WorkflowExpression<string> bodyselectALanguage, WorkflowExpression<string> item, WorkflowExpression<string> operationName, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(bodyselectALanguage, nameof(bodyselectALanguage), required: true);
            WorkflowExpression.Validate(item, nameof(item), required: true);
            WorkflowExpression.Validate(operationName, nameof(operationName), required: true);
            return new DeferredBodyTrigger<WebHookDetail>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v2.2/web-hooks/register/{0}/{1}/", ExpressionConverter.ConvertWithUrlEncoding(item, 1), ExpressionConverter.ConvertWithUrlEncoding(operationName, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                bodypropCount++;
                body["language"] = ExpressionConverter.ConvertO(bodyselectALanguage);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger<WebHookDetail>(callPayload, triggerName, recurrence);
            }, triggerName);
        }
    }

    public class WebHookDetail
    {
        [JsonProperty("uuid")]
        public string Uuid { get; set; }

        [JsonProperty("operation_name")]
        public string OperationName { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Poka;

    public partial class WorkflowManagedActions
    {
        public PokaActions Poka(string connectionId) => new PokaActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public PokaTriggers Poka(string connectionId) => new PokaTriggers(connectionId);
    }
}