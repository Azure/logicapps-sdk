//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Partnerlinq
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class PartnerlinqActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "partnerlinq")]
        public IBodyWorkflowAction<PartnerLinqGetResponse> PartnerLinqGet([WorkflowExpression] Func<string> code, [WorkflowExpression] Func<string> environment, [WorkflowExpression] Func<string> tennatId, [WorkflowExpression] Func<string> companyId, [WorkflowExpression] Func<string> process, [WorkflowExpression] Func<string> partnerId)
        {
            SourceExpression.Validate(code, nameof(code), required: true);
            SourceExpression.Validate(environment, nameof(environment), required: true);
            SourceExpression.Validate(tennatId, nameof(tennatId), required: true);
            SourceExpression.Validate(companyId, nameof(companyId), required: true);
            SourceExpression.Validate(process, nameof(process), required: true);
            SourceExpression.Validate(partnerId, nameof(partnerId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/FUNC_HTTP_DATA_SEND";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["code"] = SourceExpressionConverter.ConvertO(code);
                callPayload.Headers["Environment"] = SourceExpressionConverter.ConvertO(environment);
                callPayload.Headers["TennatId"] = SourceExpressionConverter.ConvertO(tennatId);
                callPayload.Headers["CompanyId"] = SourceExpressionConverter.ConvertO(companyId);
                callPayload.Headers["Process"] = SourceExpressionConverter.ConvertO(process);
                callPayload.Headers["PartnerId"] = SourceExpressionConverter.ConvertO(partnerId);
                return callPayload;
            }

            return new ApiConnectionAction<PartnerLinqGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "partnerlinq")]
        public IBodyWorkflowAction<PartnerLinqPostResponse> PartnerLinq([WorkflowExpression] Func<string> code, [WorkflowExpression] Func<string> environment, [WorkflowExpression] Func<string> tenantId, [WorkflowExpression] Func<string> companyId, [WorkflowExpression] Func<string> process, [WorkflowExpression] Func<string> partnerId, [WorkflowExpression] Func<string> bodydata = null)
        {
            SourceExpression.Validate(code, nameof(code), required: true);
            SourceExpression.Validate(environment, nameof(environment), required: true);
            SourceExpression.Validate(tenantId, nameof(tenantId), required: true);
            SourceExpression.Validate(companyId, nameof(companyId), required: true);
            SourceExpression.Validate(process, nameof(process), required: true);
            SourceExpression.Validate(partnerId, nameof(partnerId), required: true);
            SourceExpression.Validate(bodydata, nameof(bodydata), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/FUNC_HTTP_DATA_RECEIVE";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["code"] = SourceExpressionConverter.ConvertO(code);
                callPayload.Headers["Environment"] = SourceExpressionConverter.ConvertO(environment);
                callPayload.Headers["TenantId"] = SourceExpressionConverter.ConvertO(tenantId);
                callPayload.Headers["CompanyId"] = SourceExpressionConverter.ConvertO(companyId);
                callPayload.Headers["Process"] = SourceExpressionConverter.ConvertO(process);
                callPayload.Headers["PartnerId"] = SourceExpressionConverter.ConvertO(partnerId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodydata != null)
                {
                    body["data"] = SourceExpressionConverter.ConvertToken(bodydata);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<PartnerLinqPostResponse>(BuildSourceInput);
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