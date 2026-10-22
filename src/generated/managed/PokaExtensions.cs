//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Poka
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class PokaActions([ConnectionName] string connectionId)
    {
    }

    public class PokaTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<WebHookDetail, ApiConnectionTriggerConfiguration> CreateWebhook(Expression<Func<string>> bodyselectALanguage, Expression<Func<string>> item, Expression<Func<string>> operationName, FlowRecurrence recurrence = null)
        {
            var __workflow_bodyselectALanguage = WorkflowExpression.Compile(bodyselectALanguage, nameof(bodyselectALanguage), required: true);
            var __workflow_item = WorkflowExpression.Compile(item, nameof(item), required: true);
            var __workflow_operationName = WorkflowExpression.Compile(operationName, nameof(operationName), required: true);
            return new DeferredBodyTrigger<WebHookDetail, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v2.2/web-hooks/register/{0}/{1}/", __workflow_item.WithUrlEncoding(1), __workflow_operationName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                bodypropCount++;
                body["language"] = ExpressionConverter.ConvertO(__workflow_bodyselectALanguage);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger<WebHookDetail>(callPayload, recurrence: recurrence);
            });
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
