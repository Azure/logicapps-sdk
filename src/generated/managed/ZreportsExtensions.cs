//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Zreports
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
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
            var __workflow_brandId = WorkflowExpression.Compile(brandId, nameof(brandId), required: true);
            var __workflow_storeId = WorkflowExpression.Compile(storeId, nameof(storeId), required: true);
            var __workflow_document = WorkflowExpression.Compile(document, nameof(document), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/{1}/documents", __workflow_brandId.WithUrlEncoding(1), __workflow_storeId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }
    }

    public class ZreportsTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<CreateWebhookResponseBody> NewDispatchAdvice(Expression<Func<string>> brandId, Expression<Func<string>> bodystoreIds = null, FlowRecurrence recurrence = null)
        {
            var __workflow_brandId = WorkflowExpression.Compile(brandId, nameof(brandId), required: true);
            var __workflow_bodystoreIds = WorkflowExpression.Compile(bodystoreIds, nameof(bodystoreIds), required: false);
            return new DeferredBodyTrigger<CreateWebhookResponseBody>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/despatch-advice-hooks", __workflow_brandId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodystoreIds != null)
                {
                    body["storeIds"] = ExpressionConverter.ConvertO(__workflow_bodystoreIds);
                    bodypropCount++;
                }

                body["url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger<CreateWebhookResponseBody>(callPayload, recurrence: recurrence);
            }, WorkflowTriggerSettingProfiles.ManagedConnector);
        }

        public IBodyWorkflowTrigger<CreateWebhookResponseBody> NewInvoice(Expression<Func<string>> brandId, Expression<Func<string>> bodystoreIds = null, FlowRecurrence recurrence = null)
        {
            var __workflow_brandId = WorkflowExpression.Compile(brandId, nameof(brandId), required: true);
            var __workflow_bodystoreIds = WorkflowExpression.Compile(bodystoreIds, nameof(bodystoreIds), required: false);
            return new DeferredBodyTrigger<CreateWebhookResponseBody>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/invoice-hooks", __workflow_brandId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodystoreIds != null)
                {
                    body["storeIds"] = ExpressionConverter.ConvertO(__workflow_bodystoreIds);
                    bodypropCount++;
                }

                body["url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger<CreateWebhookResponseBody>(callPayload, recurrence: recurrence);
            }, WorkflowTriggerSettingProfiles.ManagedConnector);
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
