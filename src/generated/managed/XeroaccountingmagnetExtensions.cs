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
        public IBodyWorkflowAction<JToken> CreateRecord([WorkflowExpression] Func<string> xeroTenantId, [WorkflowExpression] Func<string> recordType, [WorkflowExpression] Func<object> body = null)
        {
            SourceExpression.Validate(xeroTenantId, nameof(xeroTenantId), required: true);
            SourceExpression.Validate(recordType, nameof(recordType), required: true);
            SourceExpression.Validate(body, nameof(body), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/actions/create/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(recordType, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["xero-tenant-id"] = SourceExpressionConverter.ConvertO(xeroTenantId);
                callPayload.Body = SourceExpressionConverter.ConvertToken(body);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "xeroaccountingmagnet")]
        public IBodyWorkflowAction<JToken> ListRecords([WorkflowExpression] Func<string> xeroTenantId, [WorkflowExpression] Func<string> recordType, [WorkflowExpression] Func<string> where = null, [WorkflowExpression] Func<string> order = null, [WorkflowExpression] Func<int> top = null, [WorkflowExpression] Func<object> body = null)
        {
            SourceExpression.Validate(xeroTenantId, nameof(xeroTenantId), required: true);
            SourceExpression.Validate(recordType, nameof(recordType), required: true);
            SourceExpression.Validate(where, nameof(where), required: false);
            SourceExpression.Validate(order, nameof(order), required: false);
            SourceExpression.Validate(top, nameof(top), required: false);
            SourceExpression.Validate(body, nameof(body), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/actions/list/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(recordType, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (where != null)
                    callPayload.Queries["where"] = SourceExpressionConverter.ConvertO(where);
                if (order != null)
                    callPayload.Queries["order"] = SourceExpressionConverter.ConvertO(order);
                if (top != null)
                    callPayload.Queries["top"] = SourceExpressionConverter.ConvertO(top);
                callPayload.Headers["xero-tenant-id"] = SourceExpressionConverter.ConvertO(xeroTenantId);
                callPayload.Body = SourceExpressionConverter.ConvertToken(body);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "xeroaccountingmagnet")]
        public IBodyWorkflowAction<JToken> GetRecord([WorkflowExpression] Func<string> xeroTenantId, [WorkflowExpression] Func<string> recordType, [WorkflowExpression] Func<string> recordId, [WorkflowExpression] Func<object> body = null)
        {
            SourceExpression.Validate(xeroTenantId, nameof(xeroTenantId), required: true);
            SourceExpression.Validate(recordType, nameof(recordType), required: true);
            SourceExpression.Validate(recordId, nameof(recordId), required: true);
            SourceExpression.Validate(body, nameof(body), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/actions/get/{0}/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(recordType, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(recordId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["xero-tenant-id"] = SourceExpressionConverter.ConvertO(xeroTenantId);
                callPayload.Body = SourceExpressionConverter.ConvertToken(body);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "xeroaccountingmagnet")]
        public IBodyWorkflowAction<JToken> UpdateRecord([WorkflowExpression] Func<string> xeroTenantId, [WorkflowExpression] Func<string> recordType, [WorkflowExpression] Func<string> recordId, [WorkflowExpression] Func<object> body = null)
        {
            SourceExpression.Validate(xeroTenantId, nameof(xeroTenantId), required: true);
            SourceExpression.Validate(recordType, nameof(recordType), required: true);
            SourceExpression.Validate(recordId, nameof(recordId), required: true);
            SourceExpression.Validate(body, nameof(body), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/actions/update/{0}/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(recordType, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(recordId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["xero-tenant-id"] = SourceExpressionConverter.ConvertO(xeroTenantId);
                callPayload.Body = SourceExpressionConverter.ConvertToken(body);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "xeroaccountingmagnet")]
        public IBodyWorkflowAction<JToken> DeleteRecord([WorkflowExpression] Func<string> xeroTenantId, [WorkflowExpression] Func<string> recordType, [WorkflowExpression] Func<string> recordId, [WorkflowExpression] Func<object> body = null)
        {
            SourceExpression.Validate(xeroTenantId, nameof(xeroTenantId), required: true);
            SourceExpression.Validate(recordType, nameof(recordType), required: true);
            SourceExpression.Validate(recordId, nameof(recordId), required: true);
            SourceExpression.Validate(body, nameof(body), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/actions/delete/{0}/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(recordType, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(recordId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["xero-tenant-id"] = SourceExpressionConverter.ConvertO(xeroTenantId);
                callPayload.Body = SourceExpressionConverter.ConvertToken(body);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "xeroaccountingmagnet")]
        public IBodyWorkflowAction<SendHttpRequestResponse> SendHttpRequest([WorkflowExpression] Func<string> xeroTenantId, [WorkflowExpression] Func<bodymethodInput> bodymethod, [WorkflowExpression] Func<string> bodyuri, [WorkflowExpression] Func<bodyheadersInputItem[]> bodyheaders = null, [WorkflowExpression] Func<string> bodybody = null)
        {
            SourceExpression.Validate(xeroTenantId, nameof(xeroTenantId), required: true);
            SourceExpression.Validate(bodymethod, nameof(bodymethod), required: true);
            SourceExpression.Validate(bodyuri, nameof(bodyuri), required: true);
            SourceExpression.Validate(bodyheaders, nameof(bodyheaders), required: false);
            SourceExpression.Validate(bodybody, nameof(bodybody), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/actions/sendhttprequest";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["xero-tenant-id"] = SourceExpressionConverter.ConvertO(xeroTenantId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["method"] = SourceExpressionConverter.Convert(bodymethod);
                bodypropCount++;
                body["uri"] = SourceExpressionConverter.ConvertToken(bodyuri);
                if (bodyheaders != null)
                {
                    body["headers"] = SourceExpressionConverter.ConvertToken(bodyheaders);
                    bodypropCount++;
                }

                if (bodybody != null)
                {
                    body["body"] = SourceExpressionConverter.ConvertToken(bodybody);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SendHttpRequestResponse>(BuildSourceInput);
        }
    }

    public class XeroaccountingmagnetTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger TriggerXero([WorkflowExpression] Func<string> xeroTenantId, [WorkflowExpression] Func<eventTypeInput> eventType, [WorkflowExpression] Func<eventCategoryInput> eventCategory, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(xeroTenantId, nameof(xeroTenantId), required: true);
            SourceExpression.Validate(eventType, nameof(eventType), required: true);
            SourceExpression.Validate(eventCategory, nameof(eventCategory), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/webhook/register";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["eventType"] = SourceExpressionConverter.Convert(eventType);
                callPayload.Queries["eventCategory"] = SourceExpressionConverter.Convert(eventCategory);
                callPayload.Headers["xero-tenant-id"] = SourceExpressionConverter.ConvertO(xeroTenantId);
                var body = new JObject();
                var bodypropCount = 0;
                body["webhookUrl"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
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