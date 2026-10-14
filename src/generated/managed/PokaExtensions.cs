//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Poka
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class PokaActions([ConnectionName] string connectionId)
    {
    }

    public class PokaTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<WebHookDetail> CreateWebhook(Expression<Func<string>> bodyselectALanguage, Expression<Func<string>> item, Expression<Func<string>> operationName, FlowRecurrence recurrence = null)
        {
            var __workflow_bodyselectALanguage = bodyselectALanguage == null ? null : WorkflowExpression.Compile(bodyselectALanguage);
            WorkflowExpression.Validate(__workflow_bodyselectALanguage, nameof(bodyselectALanguage), required: true);
            var __workflow_item = item == null ? null : WorkflowExpression.Compile(item);
            WorkflowExpression.Validate(__workflow_item, nameof(item), required: true);
            var __workflow_operationName = operationName == null ? null : WorkflowExpression.Compile(operationName);
            WorkflowExpression.Validate(__workflow_operationName, nameof(operationName), required: true);
            return new DeferredBodyTrigger<WebHookDetail>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v2.2/web-hooks/register/{0}/{1}/", ExpressionConverter.ConvertWithUrlEncoding(__workflow_item, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_operationName, 1));
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
