//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Partnerlinq
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class PartnerlinqActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "partnerlinq")]
        [WorkflowExpressionFactory(nameof(__BuildPartnerLinqGet))]
        public IBodyWorkflowAction<PartnerLinqGetResponse> PartnerLinqGet([WorkflowExpression] Func<string> code, [WorkflowExpression] Func<string> environment, [WorkflowExpression] Func<string> tennatId, [WorkflowExpression] Func<string> companyId, [WorkflowExpression] Func<string> process, [WorkflowExpression] Func<string> partnerId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "partnerlinq")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PartnerLinqGetResponse> __BuildPartnerLinqGet(WorkflowExpression<string> code, WorkflowExpression<string> environment, WorkflowExpression<string> tennatId, WorkflowExpression<string> companyId, WorkflowExpression<string> process, WorkflowExpression<string> partnerId)
        {
            WorkflowExpression.Validate(code, nameof(code), required: true);
            WorkflowExpression.Validate(environment, nameof(environment), required: true);
            WorkflowExpression.Validate(tennatId, nameof(tennatId), required: true);
            WorkflowExpression.Validate(companyId, nameof(companyId), required: true);
            WorkflowExpression.Validate(process, nameof(process), required: true);
            WorkflowExpression.Validate(partnerId, nameof(partnerId), required: true);
            return new DeferredBodyAction<PartnerLinqGetResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "partnerlinq")]
        [WorkflowExpressionFactory(nameof(__BuildPartnerLinq))]
        public IBodyWorkflowAction<PartnerLinqPostResponse> PartnerLinq([WorkflowExpression] Func<string> code, [WorkflowExpression] Func<string> environment, [WorkflowExpression] Func<string> tenantId, [WorkflowExpression] Func<string> companyId, [WorkflowExpression] Func<string> process, [WorkflowExpression] Func<string> partnerId, [WorkflowExpression] Func<string> bodydata = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "partnerlinq")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PartnerLinqPostResponse> __BuildPartnerLinq(WorkflowExpression<string> code, WorkflowExpression<string> environment, WorkflowExpression<string> tenantId, WorkflowExpression<string> companyId, WorkflowExpression<string> process, WorkflowExpression<string> partnerId, WorkflowExpression<string> bodydata = null)
        {
            WorkflowExpression.Validate(code, nameof(code), required: true);
            WorkflowExpression.Validate(environment, nameof(environment), required: true);
            WorkflowExpression.Validate(tenantId, nameof(tenantId), required: true);
            WorkflowExpression.Validate(companyId, nameof(companyId), required: true);
            WorkflowExpression.Validate(process, nameof(process), required: true);
            WorkflowExpression.Validate(partnerId, nameof(partnerId), required: true);
            WorkflowExpression.Validate(bodydata, nameof(bodydata), required: false);
            return new DeferredBodyAction<PartnerLinqPostResponse>(() =>
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