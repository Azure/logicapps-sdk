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
            var __workflow_code = code == null ? null : WorkflowExpression.Compile(code);
            WorkflowExpression.Validate(__workflow_code, nameof(code), required: true);
            var __workflow_environment = environment == null ? null : WorkflowExpression.Compile(environment);
            WorkflowExpression.Validate(__workflow_environment, nameof(environment), required: true);
            var __workflow_tennatId = tennatId == null ? null : WorkflowExpression.Compile(tennatId);
            WorkflowExpression.Validate(__workflow_tennatId, nameof(tennatId), required: true);
            var __workflow_companyId = companyId == null ? null : WorkflowExpression.Compile(companyId);
            WorkflowExpression.Validate(__workflow_companyId, nameof(companyId), required: true);
            var __workflow_process = process == null ? null : WorkflowExpression.Compile(process);
            WorkflowExpression.Validate(__workflow_process, nameof(process), required: true);
            var __workflow_partnerId = partnerId == null ? null : WorkflowExpression.Compile(partnerId);
            WorkflowExpression.Validate(__workflow_partnerId, nameof(partnerId), required: true);
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
            var __workflow_code = code == null ? null : WorkflowExpression.Compile(code);
            WorkflowExpression.Validate(__workflow_code, nameof(code), required: true);
            var __workflow_environment = environment == null ? null : WorkflowExpression.Compile(environment);
            WorkflowExpression.Validate(__workflow_environment, nameof(environment), required: true);
            var __workflow_tenantId = tenantId == null ? null : WorkflowExpression.Compile(tenantId);
            WorkflowExpression.Validate(__workflow_tenantId, nameof(tenantId), required: true);
            var __workflow_companyId = companyId == null ? null : WorkflowExpression.Compile(companyId);
            WorkflowExpression.Validate(__workflow_companyId, nameof(companyId), required: true);
            var __workflow_process = process == null ? null : WorkflowExpression.Compile(process);
            WorkflowExpression.Validate(__workflow_process, nameof(process), required: true);
            var __workflow_partnerId = partnerId == null ? null : WorkflowExpression.Compile(partnerId);
            WorkflowExpression.Validate(__workflow_partnerId, nameof(partnerId), required: true);
            var __workflow_bodydata = bodydata == null ? null : WorkflowExpression.Compile(bodydata);
            WorkflowExpression.Validate(__workflow_bodydata, nameof(bodydata), required: false);
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
