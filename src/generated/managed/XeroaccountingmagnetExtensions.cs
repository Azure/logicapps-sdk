//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Xeroaccountingmagnet
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class XeroaccountingmagnetActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "xeroaccountingmagnet")]
        [WorkflowExpressionFactory(nameof(__BuildCreateRecord))]
        public IBodyWorkflowAction<JToken> CreateRecord([WorkflowExpression] Func<string> xeroTenantId, [WorkflowExpression] Func<string> recordType, [WorkflowExpression] Func<object> body = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildCreateRecord(WorkflowValue<string> xeroTenantId, WorkflowValue<string> recordType, WorkflowValue<object> body = null)
        {
            WorkflowValue.Validate(xeroTenantId, nameof(xeroTenantId), required: true);
            WorkflowValue.Validate(recordType, nameof(recordType), required: true);
            WorkflowValue.Validate(body, nameof(body), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/actions/create/{0}", ExpressionConverter.ConvertWithUrlEncoding(recordType, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["xero-tenant-id"] = ExpressionConverter.Convert(xeroTenantId);
                callPayload.Body = ExpressionConverter.ConvertO(body);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "xeroaccountingmagnet")]
        [WorkflowExpressionFactory(nameof(__BuildListRecords))]
        public IBodyWorkflowAction<JToken> ListRecords([WorkflowExpression] Func<string> xeroTenantId, [WorkflowExpression] Func<string> recordType, [WorkflowExpression] Func<string> where = null, [WorkflowExpression] Func<string> order = null, [WorkflowExpression] Func<int> top = null, [WorkflowExpression] Func<object> body = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildListRecords(WorkflowValue<string> xeroTenantId, WorkflowValue<string> recordType, WorkflowValue<string> where = null, WorkflowValue<string> order = null, WorkflowValue<int> top = null, WorkflowValue<object> body = null)
        {
            WorkflowValue.Validate(xeroTenantId, nameof(xeroTenantId), required: true);
            WorkflowValue.Validate(recordType, nameof(recordType), required: true);
            WorkflowValue.Validate(where, nameof(where), required: false);
            WorkflowValue.Validate(order, nameof(order), required: false);
            WorkflowValue.Validate(top, nameof(top), required: false);
            WorkflowValue.Validate(body, nameof(body), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/actions/list/{0}", ExpressionConverter.ConvertWithUrlEncoding(recordType, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (where != null)
                    callPayload.Queries["where"] = ExpressionConverter.Convert(where);
                if (order != null)
                    callPayload.Queries["order"] = ExpressionConverter.Convert(order);
                if (top != null)
                    callPayload.Queries["top"] = ExpressionConverter.Convert(top);
                callPayload.Headers["xero-tenant-id"] = ExpressionConverter.Convert(xeroTenantId);
                callPayload.Body = ExpressionConverter.ConvertO(body);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "xeroaccountingmagnet")]
        [WorkflowExpressionFactory(nameof(__BuildGetRecord))]
        public IBodyWorkflowAction<JToken> GetRecord([WorkflowExpression] Func<string> xeroTenantId, [WorkflowExpression] Func<string> recordType, [WorkflowExpression] Func<string> recordId, [WorkflowExpression] Func<object> body = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildGetRecord(WorkflowValue<string> xeroTenantId, WorkflowValue<string> recordType, WorkflowValue<string> recordId, WorkflowValue<object> body = null)
        {
            WorkflowValue.Validate(xeroTenantId, nameof(xeroTenantId), required: true);
            WorkflowValue.Validate(recordType, nameof(recordType), required: true);
            WorkflowValue.Validate(recordId, nameof(recordId), required: true);
            WorkflowValue.Validate(body, nameof(body), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/actions/get/{0}/{1}", ExpressionConverter.ConvertWithUrlEncoding(recordType, 1), ExpressionConverter.ConvertWithUrlEncoding(recordId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["xero-tenant-id"] = ExpressionConverter.Convert(xeroTenantId);
                callPayload.Body = ExpressionConverter.ConvertO(body);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "xeroaccountingmagnet")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateRecord))]
        public IBodyWorkflowAction<JToken> UpdateRecord([WorkflowExpression] Func<string> xeroTenantId, [WorkflowExpression] Func<string> recordType, [WorkflowExpression] Func<string> recordId, [WorkflowExpression] Func<object> body = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildUpdateRecord(WorkflowValue<string> xeroTenantId, WorkflowValue<string> recordType, WorkflowValue<string> recordId, WorkflowValue<object> body = null)
        {
            WorkflowValue.Validate(xeroTenantId, nameof(xeroTenantId), required: true);
            WorkflowValue.Validate(recordType, nameof(recordType), required: true);
            WorkflowValue.Validate(recordId, nameof(recordId), required: true);
            WorkflowValue.Validate(body, nameof(body), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/actions/update/{0}/{1}", ExpressionConverter.ConvertWithUrlEncoding(recordType, 1), ExpressionConverter.ConvertWithUrlEncoding(recordId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["xero-tenant-id"] = ExpressionConverter.Convert(xeroTenantId);
                callPayload.Body = ExpressionConverter.ConvertO(body);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "xeroaccountingmagnet")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteRecord))]
        public IBodyWorkflowAction<JToken> DeleteRecord([WorkflowExpression] Func<string> xeroTenantId, [WorkflowExpression] Func<string> recordType, [WorkflowExpression] Func<string> recordId, [WorkflowExpression] Func<object> body = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildDeleteRecord(WorkflowValue<string> xeroTenantId, WorkflowValue<string> recordType, WorkflowValue<string> recordId, WorkflowValue<object> body = null)
        {
            WorkflowValue.Validate(xeroTenantId, nameof(xeroTenantId), required: true);
            WorkflowValue.Validate(recordType, nameof(recordType), required: true);
            WorkflowValue.Validate(recordId, nameof(recordId), required: true);
            WorkflowValue.Validate(body, nameof(body), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/actions/delete/{0}/{1}", ExpressionConverter.ConvertWithUrlEncoding(recordType, 1), ExpressionConverter.ConvertWithUrlEncoding(recordId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["xero-tenant-id"] = ExpressionConverter.Convert(xeroTenantId);
                callPayload.Body = ExpressionConverter.ConvertO(body);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "xeroaccountingmagnet")]
        [WorkflowExpressionFactory(nameof(__BuildSendHttpRequest))]
        public IBodyWorkflowAction<SendHttpRequestResponse> SendHttpRequest([WorkflowExpression] Func<string> xeroTenantId, [WorkflowExpression] Func<bodymethodInput> bodymethod, [WorkflowExpression] Func<string> bodyuri, [WorkflowExpression] Func<bodyheadersInputItem[]> bodyheaders = null, [WorkflowExpression] Func<string> bodybody = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SendHttpRequestResponse> __BuildSendHttpRequest(WorkflowValue<string> xeroTenantId, WorkflowValue<bodymethodInput> bodymethod, WorkflowValue<string> bodyuri, WorkflowValue<bodyheadersInputItem[]> bodyheaders = null, WorkflowValue<string> bodybody = null)
        {
            WorkflowValue.Validate(xeroTenantId, nameof(xeroTenantId), required: true);
            WorkflowValue.Validate(bodymethod, nameof(bodymethod), required: true);
            WorkflowValue.Validate(bodyuri, nameof(bodyuri), required: true);
            WorkflowValue.Validate(bodyheaders, nameof(bodyheaders), required: false);
            WorkflowValue.Validate(bodybody, nameof(bodybody), required: false);
            return new DeferredBodyAction<SendHttpRequestResponse>(() =>
            {
                var apiCallPath = "/v1/actions/sendhttprequest";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["xero-tenant-id"] = ExpressionConverter.Convert(xeroTenantId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["method"] = ExpressionConverter.ConvertO(bodymethod);
                bodypropCount++;
                body["uri"] = ExpressionConverter.ConvertO(bodyuri);
                if (bodyheaders != null)
                {
                    body["headers"] = ExpressionConverter.ConvertO(bodyheaders);
                    bodypropCount++;
                }

                if (bodybody != null)
                {
                    body["body"] = ExpressionConverter.ConvertO(bodybody);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<SendHttpRequestResponse>(callPayload);
            });
        }
    }

    public class XeroaccountingmagnetTriggers([ConnectionName] string connectionId)
    {
        [WorkflowExpressionFactory(nameof(__BuildTriggerXero))]
        public IWorkflowTrigger TriggerXero([WorkflowExpression] Func<string> xeroTenantId, [WorkflowExpression] Func<eventTypeInput> eventType, [WorkflowExpression] Func<eventCategoryInput> eventCategory, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildTriggerXero(WorkflowValue<string> xeroTenantId, WorkflowValue<eventTypeInput> eventType, WorkflowValue<eventCategoryInput> eventCategory, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(xeroTenantId, nameof(xeroTenantId), required: true);
            WorkflowValue.Validate(eventType, nameof(eventType), required: true);
            WorkflowValue.Validate(eventCategory, nameof(eventCategory), required: true);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = "/v1/webhook/register";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["eventType"] = ExpressionConverter.Convert(eventType);
                callPayload.Queries["eventCategory"] = ExpressionConverter.Convert(eventCategory);
                callPayload.Headers["xero-tenant-id"] = ExpressionConverter.Convert(xeroTenantId);
                var body = new JObject();
                var bodypropCount = 0;
                body["webhookUrl"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
            }, triggerName);
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

    public enum eventTypeInput
    {
        Create,
        Update,
        [EnumMember(Value = "Create or Update")]
        CreateOrUpdate
    }

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
