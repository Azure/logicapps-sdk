//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Poka
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class PokaActions([ConnectionName] string connectionId)
    {
    }

    public class PokaTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<WebHookDetail> CreateWebhook([WorkflowExpression] Func<string> bodyselectALanguage, [WorkflowExpression] Func<string> item, [WorkflowExpression] Func<string> operationName, string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v2.2/web-hooks/register/{0}/{1}/", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(item, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(operationName, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                bodypropCount++;
                body["language"] = SourceExpressionConverter.ConvertToken(bodyselectALanguage);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger<WebHookDetail>(BuildSourceInput, triggerName, recurrence);
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