//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Partnerlinq
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class PartnerlinqActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "partnerlinq")]
        public IBodyWorkflowAction<PartnerLinqGetResponse> PartnerLinqGet(Expression<Func<string>> code, Expression<Func<string>> environment, Expression<Func<string>> tennatId, Expression<Func<string>> companyId, Expression<Func<string>> process, Expression<Func<string>> partnerId)
        {
            var apiCallPath = "/api/FUNC_HTTP_DATA_SEND";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["code"] = ExpressionConverter.Convert(code);
            callPayload.Headers["Environment"] = ExpressionConverter.Convert(environment);
            callPayload.Headers["TennatId"] = ExpressionConverter.Convert(tennatId);
            callPayload.Headers["CompanyId"] = ExpressionConverter.Convert(companyId);
            callPayload.Headers["Process"] = ExpressionConverter.Convert(process);
            callPayload.Headers["PartnerId"] = ExpressionConverter.Convert(partnerId);
            return new ApiConnectionAction<PartnerLinqGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "partnerlinq")]
        public IBodyWorkflowAction<PartnerLinqPostResponse> PartnerLinqPost(Expression<Func<string>> code, Expression<Func<string>> environment, Expression<Func<string>> tenantId, Expression<Func<string>> companyId, Expression<Func<string>> process, Expression<Func<string>> partnerId, Expression<Func<string>> bodydata = null)
        {
            var apiCallPath = "/api/FUNC_HTTP_DATA_RECEIVE";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["code"] = ExpressionConverter.Convert(code);
            callPayload.Headers["Environment"] = ExpressionConverter.Convert(environment);
            callPayload.Headers["TenantId"] = ExpressionConverter.Convert(tenantId);
            callPayload.Headers["CompanyId"] = ExpressionConverter.Convert(companyId);
            callPayload.Headers["Process"] = ExpressionConverter.Convert(process);
            callPayload.Headers["PartnerId"] = ExpressionConverter.Convert(partnerId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodydata != null)
            {
                body["data"] = ExpressionConverter.ConvertO(bodydata);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<PartnerLinqPostResponse>(callPayload);
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
    using Microsoft.Azure.Workflows.Sdk.Partnerlinq;

    public partial class WorkflowManagedActions
    {
        public PartnerlinqActions Partnerlinq(string connectionId) => new PartnerlinqActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public PartnerlinqTriggers Partnerlinq(string connectionId) => new PartnerlinqTriggers(connectionId);
    }
}