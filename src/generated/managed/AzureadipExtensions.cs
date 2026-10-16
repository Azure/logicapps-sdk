//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Azureadip
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AzureadipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureadip")]
        public IBodyWorkflowAction<GetRiskUserResult> GetRiskUser(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<GetRiskUserResult>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/beta/riskyUsers/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetRiskUserResult>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureadip")]
        public IWorkflowAction ConfirmRiskUser(Expression<Func<string[]>> bodyuserIds = null)
        {
            var __workflow_bodyuserIds = WorkflowExpression.Compile(bodyuserIds, nameof(bodyuserIds), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/beta/riskyUsers/confirmCompromised";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyuserIds != null)
                {
                    body["userIds"] = ExpressionConverter.ConvertO(__workflow_bodyuserIds);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureadip")]
        public IBodyWorkflowAction<GetRiskDetection> RiskDetections(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<GetRiskDetection>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/beta/riskDetections/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetRiskDetection>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureadip")]
        public IWorkflowAction DismissRiskUser(Expression<Func<string[]>> bodyuserIds = null)
        {
            var __workflow_bodyuserIds = WorkflowExpression.Compile(bodyuserIds, nameof(bodyuserIds), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/beta/riskyUsers/dismiss";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyuserIds != null)
                {
                    body["userIds"] = ExpressionConverter.ConvertO(__workflow_bodyuserIds);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureadip")]
        public IBodyWorkflowAction<GetRiskHistory> GetRiskUserHistory(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<GetRiskHistory>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/beta/riskyUsers/{0}/history", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetRiskHistory>(callPayload);
            });
        }
    }

    public class AzureadipTriggers([ConnectionName] string connectionId)
    {
    }

    public class GetRiskUserResult
    {
        [JsonProperty("@@odata.context")]
        public string OdataContext { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("isDeleted")]
        public bool IsDeleted { get; set; }

        [JsonProperty("isProcessing")]
        public bool IsProcessing { get; set; }

        [JsonProperty("riskLevel")]
        public string RiskLevel { get; set; }

        [JsonProperty("riskState")]
        public string RiskState { get; set; }

        [JsonProperty("riskDetail")]
        public string RiskDetail { get; set; }

        [JsonProperty("riskLastUpdatedDateTime")]
        public string RiskLastUpdatedDateTime { get; set; }

        [JsonProperty("userDisplayName")]
        public string UserDisplayName { get; set; }

        [JsonProperty("userPrincipalName")]
        public string UserPrincipalName { get; set; }
    }

    public class GetRiskDetection
    {
        [JsonProperty("@@odata.type")]
        public string OdataType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("requestId")]
        public string RequestId { get; set; }

        [JsonProperty("correlationId")]
        public string CorrelationId { get; set; }

        [JsonProperty("riskEventType")]
        public string RiskEventType { get; set; }

        [JsonProperty("riskState")]
        public string RiskState { get; set; }

        [JsonProperty("riskLevel")]
        public string RiskLevel { get; set; }

        [JsonProperty("riskDetail")]
        public string RiskDetail { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("detectionTimingType")]
        public string DetectionTimingType { get; set; }

        [JsonProperty("activity")]
        public string Activity { get; set; }

        [JsonProperty("tokenIssuerType")]
        public string TokenIssuerType { get; set; }

        [JsonProperty("ipAddress")]
        public string IpAddress { get; set; }

        [JsonProperty("location")]
        public GetRiskDetectionLocationType Location { get; set; }

        [JsonProperty("activityDateTime")]
        public string ActivityDateTime { get; set; }

        [JsonProperty("detectedDateTime")]
        public string DetectedDateTime { get; set; }

        [JsonProperty("lastUpdatedDateTime")]
        public string LastUpdatedDateTime { get; set; }

        [JsonProperty("userId")]
        public string UserId { get; set; }

        [JsonProperty("userDisplayName")]
        public string UserDisplayName { get; set; }

        [JsonProperty("userPrincipalName")]
        public string UserPrincipalName { get; set; }

        [JsonProperty("additionalInfo")]
        public string AdditionalInfo { get; set; }
    }

    public class GetRiskDetectionLocationType
    {
        [JsonProperty("@@odata.type")]
        public string OdataType { get; set; }
    }

    public class GetRiskHistory
    {
        [JsonProperty("@@odata.type")]
        public string OdataType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("isDeleted")]
        public string IsDeleted { get; set; }

        [JsonProperty("isProcessing")]
        public string IsProcessing { get; set; }

        [JsonProperty("riskLastUpdatedDateTime")]
        public string RiskLastUpdatedDateTime { get; set; }

        [JsonProperty("riskLevel")]
        public string RiskLevel { get; set; }

        [JsonProperty("riskState")]
        public string RiskState { get; set; }

        [JsonProperty("riskDetail")]
        public string RiskDetail { get; set; }

        [JsonProperty("userDisplayName")]
        public string UserDisplayName { get; set; }

        [JsonProperty("userPrincipalName")]
        public string UserPrincipalName { get; set; }

        [JsonProperty("userId")]
        public string UserId { get; set; }

        [JsonProperty("initiatedBy")]
        public string InitiatedBy { get; set; }

        [JsonProperty("activity")]
        public GetRiskHistoryActivityType Activity { get; set; }
    }

    public class GetRiskHistoryActivityType
    {
        [JsonProperty("@@odata.type")]
        public string OdataType { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Azureadip;

    public partial class WorkflowManagedActions
    {
        public AzureadipActions Azureadip(string connectionId) => new AzureadipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public AzureadipTriggers Azureadip(string connectionId) => new AzureadipTriggers(connectionId);
    }
}
