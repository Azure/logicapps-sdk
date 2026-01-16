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
        public IOutputWorkflowTrigger<WebHookDetail> CreateWebhook(Expression<Func<string>> bodyselectALanguage, Expression<Func<string>> item, Expression<Func<string>> operationName, string triggerName = null)
        {
            var apiCallPath = String.Format("/api/v2.2/web-hooks/register/{0}/{1}/", ExpressionConverter.ConvertWithUrlEncoding(item, 1), ExpressionConverter.ConvertWithUrlEncoding(operationName, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["url"] = "@listcallbackurl()";
            bodypropCount++;
            bodypropCount++;
            body["language"] = ExpressionConverter.ConvertO(bodyselectALanguage);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<WebHookDetail>(callPayload);
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

namespace Microsoft.Azure.Workflows.Sdk.Connectors
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