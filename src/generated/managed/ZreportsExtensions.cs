//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Zreports
{
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
        [WorkflowExpressionFactory(nameof(__BuildUploadDocument))]
        public IWorkflowAction UploadDocument([WorkflowExpression] Func<string> brandId, [WorkflowExpression] Func<string> storeId, [WorkflowExpression] Func<object> document)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zreports")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildUploadDocument(WorkflowExpression<string> brandId, WorkflowExpression<string> storeId, WorkflowExpression<object> document)
        {
            WorkflowExpression.Validate(brandId, nameof(brandId), required: true);
            WorkflowExpression.Validate(storeId, nameof(storeId), required: true);
            WorkflowExpression.Validate(document, nameof(document), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/{1}/documents", ExpressionConverter.ConvertWithUrlEncoding(brandId, 1), ExpressionConverter.ConvertWithUrlEncoding(storeId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }
    }

    public class ZreportsTriggers([ConnectionName] string connectionId)
    {

        [WorkflowExpressionFactory(nameof(__BuildNewDispatchAdvice))]
        public IBodyWorkflowTrigger<CreateWebhookResponseBody> NewDispatchAdvice([WorkflowExpression] Func<string> brandId,[WorkflowExpression] Func<string> bodystoreIds = null,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<CreateWebhookResponseBody> __BuildNewDispatchAdvice(WorkflowExpression<string> brandId,WorkflowExpression<string> bodystoreIds = null,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(brandId, nameof(brandId), required: true);
            WorkflowExpression.Validate(bodystoreIds, nameof(bodystoreIds), required: false);
            return new DeferredBodyTrigger<CreateWebhookResponseBody>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/despatch-advice-hooks", ExpressionConverter.ConvertWithUrlEncoding(brandId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodystoreIds != null)
                {
                    body["storeIds"] = ExpressionConverter.ConvertO(bodystoreIds);
                    bodypropCount++;
                }

                body["url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger<CreateWebhookResponseBody>(callPayload, recurrence: recurrence);
            });
        }

        [WorkflowExpressionFactory(nameof(__BuildNewInvoice))]
        public IBodyWorkflowTrigger<CreateWebhookResponseBody> NewInvoice([WorkflowExpression] Func<string> brandId,[WorkflowExpression] Func<string> bodystoreIds = null,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<CreateWebhookResponseBody> __BuildNewInvoice(WorkflowExpression<string> brandId,WorkflowExpression<string> bodystoreIds = null,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(brandId, nameof(brandId), required: true);
            WorkflowExpression.Validate(bodystoreIds, nameof(bodystoreIds), required: false);
            return new DeferredBodyTrigger<CreateWebhookResponseBody>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/invoice-hooks", ExpressionConverter.ConvertWithUrlEncoding(brandId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodystoreIds != null)
                {
                    body["storeIds"] = ExpressionConverter.ConvertO(bodystoreIds);
                    bodypropCount++;
                }

                body["url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger<CreateWebhookResponseBody>(callPayload, recurrence: recurrence);
            });
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