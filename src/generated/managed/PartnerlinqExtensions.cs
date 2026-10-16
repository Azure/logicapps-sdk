//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Partnerlinq
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class PartnerlinqActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "partnerlinq")]
        public IBodyWorkflowAction<PartnerLinqGetResponse> PartnerLinqGet(Expression<Func<string>> code, Expression<Func<string>> environment, Expression<Func<string>> tennatId, Expression<Func<string>> companyId, Expression<Func<string>> process, Expression<Func<string>> partnerId)
        {
            var __workflow_code = WorkflowExpression.Compile(code, nameof(code), required: true);
            var __workflow_environment = WorkflowExpression.Compile(environment, nameof(environment), required: true);
            var __workflow_tennatId = WorkflowExpression.Compile(tennatId, nameof(tennatId), required: true);
            var __workflow_companyId = WorkflowExpression.Compile(companyId, nameof(companyId), required: true);
            var __workflow_process = WorkflowExpression.Compile(process, nameof(process), required: true);
            var __workflow_partnerId = WorkflowExpression.Compile(partnerId, nameof(partnerId), required: true);
            return new DeferredBodyAction<PartnerLinqGetResponse>(() =>
            {
                var apiCallPath = "/api/FUNC_HTTP_DATA_SEND";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["code"] = ExpressionConverter.Convert(__workflow_code);
                callPayload.Headers["Environment"] = ExpressionConverter.Convert(__workflow_environment);
                callPayload.Headers["TennatId"] = ExpressionConverter.Convert(__workflow_tennatId);
                callPayload.Headers["CompanyId"] = ExpressionConverter.Convert(__workflow_companyId);
                callPayload.Headers["Process"] = ExpressionConverter.Convert(__workflow_process);
                callPayload.Headers["PartnerId"] = ExpressionConverter.Convert(__workflow_partnerId);
                return new ApiConnectionAction<PartnerLinqGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "partnerlinq")]
        public IBodyWorkflowAction<PartnerLinqPostResponse> PartnerLinq(Expression<Func<string>> code, Expression<Func<string>> environment, Expression<Func<string>> tenantId, Expression<Func<string>> companyId, Expression<Func<string>> process, Expression<Func<string>> partnerId, Expression<Func<string>> bodydata = null)
        {
            var __workflow_code = WorkflowExpression.Compile(code, nameof(code), required: true);
            var __workflow_environment = WorkflowExpression.Compile(environment, nameof(environment), required: true);
            var __workflow_tenantId = WorkflowExpression.Compile(tenantId, nameof(tenantId), required: true);
            var __workflow_companyId = WorkflowExpression.Compile(companyId, nameof(companyId), required: true);
            var __workflow_process = WorkflowExpression.Compile(process, nameof(process), required: true);
            var __workflow_partnerId = WorkflowExpression.Compile(partnerId, nameof(partnerId), required: true);
            var __workflow_bodydata = WorkflowExpression.Compile(bodydata, nameof(bodydata), required: false);
            return new DeferredBodyAction<PartnerLinqPostResponse>(() =>
            {
                var apiCallPath = "/api/FUNC_HTTP_DATA_RECEIVE";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["code"] = ExpressionConverter.Convert(__workflow_code);
                callPayload.Headers["Environment"] = ExpressionConverter.Convert(__workflow_environment);
                callPayload.Headers["TenantId"] = ExpressionConverter.Convert(__workflow_tenantId);
                callPayload.Headers["CompanyId"] = ExpressionConverter.Convert(__workflow_companyId);
                callPayload.Headers["Process"] = ExpressionConverter.Convert(__workflow_process);
                callPayload.Headers["PartnerId"] = ExpressionConverter.Convert(__workflow_partnerId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodydata != null)
                {
                    body["data"] = ExpressionConverter.ConvertO(__workflow_bodydata);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<PartnerLinqPostResponse>(callPayload);
            });
        }
    }

    public class PartnerlinqTriggers([ConnectionName] string connectionId)
    {
    }

    public class PartnerLinqGetResponse
    {
        [JsonProperty("data")]
        public string Data { get; set; }
    }

    public class PartnerLinqPostResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("response")]
        public string Response { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Partnerlinq;

    public partial class WorkflowManagedActions
    {
        public PartnerlinqActions Partnerlinq(string connectionId) => new PartnerlinqActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public PartnerlinqTriggers Partnerlinq(string connectionId) => new PartnerlinqTriggers(connectionId);
    }
}
