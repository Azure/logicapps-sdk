//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Zreports
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ZreportsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zreports")]
        public IBodyWorkflowAction<GetStoresResponseItem[]> GetStores()
        {
            var apiCallPath = "/stores";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetStoresResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zreports")]
        public IWorkflowAction UploadDocument(Expression<Func<string>> brandId, Expression<Func<string>> storeId, Expression<Func<object>> document)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/{0}/{1}/documents", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(brandId, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(storeId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }
    }

    public class ZreportsTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<CreateWebhookResponseBody> NewDispatchAdvice(Expression<Func<string>> brandId, Expression<Func<string>> bodystoreIds = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/{0}/despatch-advice-hooks", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(brandId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodystoreIds != null)
            {
                body["storeIds"] = CSharpExpressionConverter.ConvertToken(bodystoreIds);
                bodypropCount++;
            }

            body["url"] = "@listCallbackUrl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<CreateWebhookResponseBody>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<CreateWebhookResponseBody> NewInvoice(Expression<Func<string>> brandId, Expression<Func<string>> bodystoreIds = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/{0}/invoice-hooks", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(brandId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodystoreIds != null)
            {
                body["storeIds"] = CSharpExpressionConverter.ConvertToken(bodystoreIds);
                bodypropCount++;
            }

            body["url"] = "@listCallbackUrl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<CreateWebhookResponseBody>(callPayload, triggerName, recurrence);
        }
    }

    public class GetStoresResponseItem
    {
        [JsonProperty("brandId")]
        public string BrandId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("storeId")]
        public string StoreId { get; set; }
    }

    public class CreateWebhookResponseBody
    {
        [JsonProperty("event")]
        public string Event { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Zreports;

    public partial class WorkflowManagedActions
    {
        public ZreportsActions Zreports(string connectionId) => new ZreportsActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public ZreportsTriggers Zreports(string connectionId) => new ZreportsTriggers(connectionId);
    }
}