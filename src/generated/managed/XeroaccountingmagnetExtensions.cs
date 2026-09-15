//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Xeroaccountingmagnet
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class XeroaccountingmagnetActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "xeroaccountingmagnet")]
        public IBodyWorkflowAction<JToken> CreateRecord(Expression<Func<string>> xeroTenantId, Expression<Func<string>> recordType, Expression<Func<object>> body = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/v1/actions/create/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(recordType, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["xero-tenant-id"] = CSharpExpressionConverter.ConvertO(xeroTenantId);
            callPayload.Body = CSharpExpressionConverter.ConvertToken(body);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "xeroaccountingmagnet")]
        public IBodyWorkflowAction<JToken> ListRecords(Expression<Func<string>> xeroTenantId, Expression<Func<string>> recordType, Expression<Func<string>> where = null, Expression<Func<string>> order = null, Expression<Func<int>> top = null, Expression<Func<object>> body = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/v1/actions/list/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(recordType, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (where != null)
                callPayload.Queries["where"] = CSharpExpressionConverter.ConvertO(where);
            if (order != null)
                callPayload.Queries["order"] = CSharpExpressionConverter.ConvertO(order);
            if (top != null)
                callPayload.Queries["top"] = CSharpExpressionConverter.ConvertO(top);
            callPayload.Headers["xero-tenant-id"] = CSharpExpressionConverter.ConvertO(xeroTenantId);
            callPayload.Body = CSharpExpressionConverter.ConvertToken(body);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "xeroaccountingmagnet")]
        public IBodyWorkflowAction<JToken> GetRecord(Expression<Func<string>> xeroTenantId, Expression<Func<string>> recordType, Expression<Func<string>> recordId, Expression<Func<object>> body = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/v1/actions/get/{0}/{1}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(recordType, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(recordId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["xero-tenant-id"] = CSharpExpressionConverter.ConvertO(xeroTenantId);
            callPayload.Body = CSharpExpressionConverter.ConvertToken(body);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "xeroaccountingmagnet")]
        public IBodyWorkflowAction<JToken> UpdateRecord(Expression<Func<string>> xeroTenantId, Expression<Func<string>> recordType, Expression<Func<string>> recordId, Expression<Func<object>> body = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/v1/actions/update/{0}/{1}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(recordType, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(recordId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["xero-tenant-id"] = CSharpExpressionConverter.ConvertO(xeroTenantId);
            callPayload.Body = CSharpExpressionConverter.ConvertToken(body);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "xeroaccountingmagnet")]
        public IBodyWorkflowAction<JToken> DeleteRecord(Expression<Func<string>> xeroTenantId, Expression<Func<string>> recordType, Expression<Func<string>> recordId, Expression<Func<object>> body = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/v1/actions/delete/{0}/{1}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(recordType, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(recordId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["xero-tenant-id"] = CSharpExpressionConverter.ConvertO(xeroTenantId);
            callPayload.Body = CSharpExpressionConverter.ConvertToken(body);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "xeroaccountingmagnet")]
        public IBodyWorkflowAction<SendHttpRequestResponse> SendHttpRequest(Expression<Func<string>> xeroTenantId, Expression<Func<bodymethodInput>> bodymethod, Expression<Func<string>> bodyuri, Expression<Func<bodyheadersInputItem[]>> bodyheaders = null, Expression<Func<string>> bodybody = null)
        {
            var apiCallPath = "/v1/actions/sendhttprequest";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["xero-tenant-id"] = CSharpExpressionConverter.ConvertO(xeroTenantId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["method"] = CSharpExpressionConverter.Convert(bodymethod);
            bodypropCount++;
            body["uri"] = CSharpExpressionConverter.ConvertToken(bodyuri);
            if (bodyheaders != null)
            {
                body["headers"] = CSharpExpressionConverter.ConvertToken(bodyheaders);
                bodypropCount++;
            }

            if (bodybody != null)
            {
                body["body"] = CSharpExpressionConverter.ConvertToken(bodybody);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<SendHttpRequestResponse>(callPayload);
        }
    }

    public class XeroaccountingmagnetTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger TriggerXero(Expression<Func<string>> xeroTenantId, Expression<Func<eventTypeInput>> eventType, Expression<Func<eventCategoryInput>> eventCategory, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/v1/webhook/register";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["eventType"] = CSharpExpressionConverter.Convert(eventType);
            callPayload.Queries["eventCategory"] = CSharpExpressionConverter.Convert(eventCategory);
            callPayload.Headers["xero-tenant-id"] = CSharpExpressionConverter.ConvertO(xeroTenantId);
            var body = new JObject();
            var bodypropCount = 0;
            body["webhookUrl"] = "@listCallbackUrl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
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