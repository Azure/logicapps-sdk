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
        public IBodyWorkflowAction<GetStoresResponseItem[], ApiConnectionActionConfiguration> GetStores()
        {
            return new DeferredBodyAction<GetStoresResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/stores";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetStoresResponseItem[]>(callPayload);
            });
        }
    }

    public class ZreportsTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<CreateWebhookResponseBody, ApiConnectionTriggerConfiguration> NewDispatchAdvice(Expression<Func<string>> brandId, Expression<Func<NewDispatchAdviceInput>> body, FlowRecurrence recurrence = null)
        {
            var __workflow_brandId = WorkflowExpression.Compile(brandId, nameof(brandId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyTrigger<CreateWebhookResponseBody, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/despatch-advice-hooks", __workflow_brandId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger<CreateWebhookResponseBody>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<CreateWebhookResponseBody, ApiConnectionTriggerConfiguration> NewInvoice(Expression<Func<string>> brandId, Expression<Func<NewInvoiceInput>> body, FlowRecurrence recurrence = null)
        {
            var __workflow_brandId = WorkflowExpression.Compile(brandId, nameof(brandId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyTrigger<CreateWebhookResponseBody, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/invoice-hooks", __workflow_brandId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
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

    public class NewDispatchAdviceInput
    {
        [JsonProperty("storeIds")]
        public string StoreIds { get; set; }

        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Url { get; set; } = "#{listCallbackUrl()}";
    }

    public class NewInvoiceInput
    {
        [JsonProperty("storeIds")]
        public string StoreIds { get; set; }

        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Url { get; set; } = "#{listCallbackUrl()}";
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