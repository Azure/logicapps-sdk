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
        public IBodyWorkflowAction<JToken> CreateRecord([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> xeroTenantId, [WorkflowExpression] Func<string> recordType, [WorkflowExpression] Func<object> body = null)
        {
            var apiCallPath = String.Format("/v1/actions/create/{0}", ExpressionConverter.ConvertWithUrlEncoding(recordType, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["xero-tenant-id"] = ExpressionConverter.Convert(xeroTenantId);
            callPayload.Body = ExpressionConverter.ConvertO(body);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "xeroaccountingmagnet")]
        public IBodyWorkflowAction<JToken> ListRecords([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> xeroTenantId, [WorkflowExpression] Func<string> recordType, [WorkflowExpression] Func<string> where = null, [WorkflowExpression] Func<string> order = null, [WorkflowExpression] Func<int> top = null, [WorkflowExpression] Func<object> body = null)
        {
            var apiCallPath = String.Format("/v1/actions/list/{0}", ExpressionConverter.ConvertWithUrlEncoding(recordType, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "xeroaccountingmagnet")]
        public IBodyWorkflowAction<JToken> GetRecord([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> xeroTenantId, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> recordType, [WorkflowExpression] Func<string> recordId, [WorkflowExpression] Func<object> body = null)
        {
            var apiCallPath = String.Format("/v1/actions/get/{0}/{1}", ExpressionConverter.ConvertWithUrlEncoding(recordType, 1), ExpressionConverter.ConvertWithUrlEncoding(recordId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["xero-tenant-id"] = ExpressionConverter.Convert(xeroTenantId);
            callPayload.Body = ExpressionConverter.ConvertO(body);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "xeroaccountingmagnet")]
        public IBodyWorkflowAction<JToken> UpdateRecord([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> xeroTenantId, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> recordType, [WorkflowExpression] Func<string> recordId, [WorkflowExpression] Func<object> body = null)
        {
            var apiCallPath = String.Format("/v1/actions/update/{0}/{1}", ExpressionConverter.ConvertWithUrlEncoding(recordType, 1), ExpressionConverter.ConvertWithUrlEncoding(recordId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["xero-tenant-id"] = ExpressionConverter.Convert(xeroTenantId);
            callPayload.Body = ExpressionConverter.ConvertO(body);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "xeroaccountingmagnet")]
        public IBodyWorkflowAction<JToken> DeleteRecord([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> xeroTenantId, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> recordType, [WorkflowExpression] Func<string> recordId, [WorkflowExpression] Func<object> body = null)
        {
            var apiCallPath = String.Format("/v1/actions/delete/{0}/{1}", ExpressionConverter.ConvertWithUrlEncoding(recordType, 1), ExpressionConverter.ConvertWithUrlEncoding(recordId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["xero-tenant-id"] = ExpressionConverter.Convert(xeroTenantId);
            callPayload.Body = ExpressionConverter.ConvertO(body);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "xeroaccountingmagnet")]
        public IBodyWorkflowAction<SendHttpRequestResponse> SendHttpRequest([WorkflowExpression] Func<string> xeroTenantId, [WorkflowExpression] Func<bodymethodInput> bodymethod, [WorkflowExpression] Func<string> bodyuri, [WorkflowExpression] Func<bodyheadersInputItem[]> bodyheaders = null, [WorkflowExpression] Func<string> bodybody = null)
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
        }
    }

    public class XeroaccountingmagnetTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger TriggerXero([WorkflowExpression] Func<string> xeroTenantId, [WorkflowExpression] Func<eventTypeInput> eventType, [WorkflowExpression] Func<eventCategoryInput> eventCategory, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/v1/webhook/register";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["eventType"] = ExpressionConverter.Convert(eventType);
            callPayload.Queries["eventCategory"] = ExpressionConverter.Convert(eventCategory);
            callPayload.Headers["xero-tenant-id"] = ExpressionConverter.Convert(xeroTenantId);
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