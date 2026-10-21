//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Xeroaccountingmagnet
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class XeroaccountingmagnetActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "xeroaccountingmagnet")]
        public IBodyWorkflowAction<JToken> CreateRecord(Expression<Func<string>> xeroTenantId, Expression<Func<string>> recordType, Expression<Func<object>> body = null)
        {
            var __workflow_xeroTenantId = WorkflowExpression.Compile(xeroTenantId, nameof(xeroTenantId), required: true);
            var __workflow_recordType = WorkflowExpression.Compile(recordType, nameof(recordType), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/actions/create/{0}", __workflow_recordType.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["xero-tenant-id"] = ExpressionConverter.Convert(__workflow_xeroTenantId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<JToken>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "xeroaccountingmagnet")]
        public IBodyWorkflowAction<JToken> ListRecords(Expression<Func<string>> xeroTenantId, Expression<Func<string>> recordType, Expression<Func<string>> where = null, Expression<Func<string>> order = null, Expression<Func<int>> top = null, Expression<Func<object>> body = null)
        {
            var __workflow_xeroTenantId = WorkflowExpression.Compile(xeroTenantId, nameof(xeroTenantId), required: true);
            var __workflow_recordType = WorkflowExpression.Compile(recordType, nameof(recordType), required: true);
            var __workflow_where = WorkflowExpression.Compile(where, nameof(where), required: false);
            var __workflow_order = WorkflowExpression.Compile(order, nameof(order), required: false);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/actions/list/{0}", __workflow_recordType.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_where != null)
                    callPayload.Queries["where"] = ExpressionConverter.Convert(__workflow_where);
                if (__workflow_order != null)
                    callPayload.Queries["order"] = ExpressionConverter.Convert(__workflow_order);
                if (__workflow_top != null)
                    callPayload.Queries["top"] = ExpressionConverter.Convert(__workflow_top);
                callPayload.Headers["xero-tenant-id"] = ExpressionConverter.Convert(__workflow_xeroTenantId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<JToken>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "xeroaccountingmagnet")]
        public IBodyWorkflowAction<JToken> GetRecord(Expression<Func<string>> xeroTenantId, Expression<Func<string>> recordType, Expression<Func<string>> recordId, Expression<Func<object>> body = null)
        {
            var __workflow_xeroTenantId = WorkflowExpression.Compile(xeroTenantId, nameof(xeroTenantId), required: true);
            var __workflow_recordType = WorkflowExpression.Compile(recordType, nameof(recordType), required: true);
            var __workflow_recordId = WorkflowExpression.Compile(recordId, nameof(recordId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/actions/get/{0}/{1}", __workflow_recordType.WithUrlEncoding(1), __workflow_recordId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["xero-tenant-id"] = ExpressionConverter.Convert(__workflow_xeroTenantId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<JToken>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "xeroaccountingmagnet")]
        public IBodyWorkflowAction<JToken> UpdateRecord(Expression<Func<string>> xeroTenantId, Expression<Func<string>> recordType, Expression<Func<string>> recordId, Expression<Func<object>> body = null)
        {
            var __workflow_xeroTenantId = WorkflowExpression.Compile(xeroTenantId, nameof(xeroTenantId), required: true);
            var __workflow_recordType = WorkflowExpression.Compile(recordType, nameof(recordType), required: true);
            var __workflow_recordId = WorkflowExpression.Compile(recordId, nameof(recordId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/actions/update/{0}/{1}", __workflow_recordType.WithUrlEncoding(1), __workflow_recordId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["xero-tenant-id"] = ExpressionConverter.Convert(__workflow_xeroTenantId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<JToken>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "xeroaccountingmagnet")]
        public IBodyWorkflowAction<JToken> DeleteRecord(Expression<Func<string>> xeroTenantId, Expression<Func<string>> recordType, Expression<Func<string>> recordId, Expression<Func<object>> body = null)
        {
            var __workflow_xeroTenantId = WorkflowExpression.Compile(xeroTenantId, nameof(xeroTenantId), required: true);
            var __workflow_recordType = WorkflowExpression.Compile(recordType, nameof(recordType), required: true);
            var __workflow_recordId = WorkflowExpression.Compile(recordId, nameof(recordId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/actions/delete/{0}/{1}", __workflow_recordType.WithUrlEncoding(1), __workflow_recordId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["xero-tenant-id"] = ExpressionConverter.Convert(__workflow_xeroTenantId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<JToken>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "xeroaccountingmagnet")]
        public IBodyWorkflowAction<SendHttpRequestResponse> SendHttpRequest(Expression<Func<string>> xeroTenantId, Expression<Func<bodymethodInput>> bodymethod, Expression<Func<string>> bodyuri, Expression<Func<bodyheadersInputItem[]>> bodyheaders = null, Expression<Func<string>> bodybody = null)
        {
            var __workflow_xeroTenantId = WorkflowExpression.Compile(xeroTenantId, nameof(xeroTenantId), required: true);
            var __workflow_bodymethod = WorkflowExpression.Compile(bodymethod, nameof(bodymethod), required: true);
            var __workflow_bodyuri = WorkflowExpression.Compile(bodyuri, nameof(bodyuri), required: true);
            var __workflow_bodyheaders = WorkflowExpression.Compile(bodyheaders, nameof(bodyheaders), required: false);
            var __workflow_bodybody = WorkflowExpression.Compile(bodybody, nameof(bodybody), required: false);
            return new DeferredBodyAction<SendHttpRequestResponse>(() =>
            {
                var apiCallPath = "/v1/actions/sendhttprequest";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["xero-tenant-id"] = ExpressionConverter.Convert(__workflow_xeroTenantId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["method"] = ExpressionConverter.ConvertO(__workflow_bodymethod);
                bodypropCount++;
                body["uri"] = ExpressionConverter.ConvertO(__workflow_bodyuri);
                if (__workflow_bodyheaders != null)
                {
                    body["headers"] = ExpressionConverter.ConvertO(__workflow_bodyheaders);
                    bodypropCount++;
                }

                if (__workflow_bodybody != null)
                {
                    body["body"] = ExpressionConverter.ConvertO(__workflow_bodybody);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<SendHttpRequestResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }
    }

    public class XeroaccountingmagnetTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger TriggerXero(Expression<Func<string>> xeroTenantId, Expression<Func<eventTypeInput>> eventType, Expression<Func<eventCategoryInput>> eventCategory, FlowRecurrence recurrence = null)
        {
            var __workflow_xeroTenantId = WorkflowExpression.Compile(xeroTenantId, nameof(xeroTenantId), required: true);
            var __workflow_eventType = WorkflowExpression.Compile(eventType, nameof(eventType), required: true);
            var __workflow_eventCategory = WorkflowExpression.Compile(eventCategory, nameof(eventCategory), required: true);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = "/v1/webhook/register";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["eventType"] = ExpressionConverter.Convert(__workflow_eventType);
                callPayload.Queries["eventCategory"] = ExpressionConverter.Convert(__workflow_eventCategory);
                callPayload.Headers["xero-tenant-id"] = ExpressionConverter.Convert(__workflow_xeroTenantId);
                var body = new JObject();
                var bodypropCount = 0;
                body["webhookUrl"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            }, WorkflowTriggerSettingProfiles.ManagedConnector);
        }
    }

    public class SendHttpRequestResponse
    {
        [JsonProperty("body")]
        public string Body { get; set; }

        [JsonProperty("headers")]
        public JToken Headers { get; set; }

        [JsonProperty("statusCode")]
        public int StatusCode { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodymethodInput
    {
        GET,
        POST,
        PUT,
        PATCH,
        DELETE
    }

    public class bodyheadersInputItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum eventTypeInput
    {
        Create,
        Update,
        [EnumMember(Value = "Create or Update")]
        CreateOrUpdate
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum eventCategoryInput
    {
        Invoice,
        Contact
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Xeroaccountingmagnet;

    public partial class WorkflowManagedActions
    {
        public XeroaccountingmagnetActions Xeroaccountingmagnet(string connectionId) => new XeroaccountingmagnetActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public XeroaccountingmagnetTriggers Xeroaccountingmagnet(string connectionId) => new XeroaccountingmagnetTriggers(connectionId);
    }
}
