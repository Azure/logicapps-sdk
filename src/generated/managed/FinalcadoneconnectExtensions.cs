//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Finalcadoneconnect
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class FinalcadoneconnectActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "finalcadoneconnect")]
        public IBodyWorkflowAction<GetOrganizationsResponseItem[]> GetOrganizations(Expression<Func<string>> acceptLanguage = null, Expression<Func<string>> xTimeZone = null)
        {
            var __workflow_acceptLanguage = WorkflowExpression.Compile(acceptLanguage, nameof(acceptLanguage), required: false);
            var __workflow_xTimeZone = WorkflowExpression.Compile(xTimeZone, nameof(xTimeZone), required: false);
            return new DeferredBodyAction<GetOrganizationsResponseItem[]>(() =>
            {
                var apiCallPath = "/organizations";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept-Language"] = Convert.ToString("en");
                if (__workflow_acceptLanguage != null)
                    callPayload.Headers["Accept-Language"] = ExpressionConverter.Convert(__workflow_acceptLanguage);
                callPayload.Headers["X-TimeZone"] = Convert.ToString("");
                if (__workflow_xTimeZone != null)
                    callPayload.Headers["X-TimeZone"] = ExpressionConverter.Convert(__workflow_xTimeZone);
                return new ApiConnectionAction<GetOrganizationsResponseItem[]>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "finalcadoneconnect")]
        public IBodyWorkflowAction<InitParametersResponse> InitParameters(Expression<Func<string>> bodylanguage = null, Expression<Func<string>> bodytheUserSTimeZoneInIANAFormat = null)
        {
            var __workflow_bodylanguage = WorkflowExpression.Compile(bodylanguage, nameof(bodylanguage), required: false);
            var __workflow_bodytheUserSTimeZoneInIANAFormat = WorkflowExpression.Compile(bodytheUserSTimeZoneInIANAFormat, nameof(bodytheUserSTimeZoneInIANAFormat), required: false);
            return new DeferredBodyAction<InitParametersResponse>(() =>
            {
                var apiCallPath = "/InitParameters";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodylanguage != null)
                {
                    if (__workflow_bodylanguage != null)
                    {
                        body["language"] = ExpressionConverter.ConvertO(__workflow_bodylanguage);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["language"] = "fr";
                    bodypropCount++;
                }

                if (__workflow_bodytheUserSTimeZoneInIANAFormat != null)
                {
                    body["timezone"] = ExpressionConverter.ConvertO(__workflow_bodytheUserSTimeZoneInIANAFormat);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<InitParametersResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "finalcadoneconnect")]
        public IBodyWorkflowAction<InitResponse> Init(Expression<Func<string>> bodyorganizationID = null, Expression<Func<string>> bodyprojectID = null)
        {
            var __workflow_bodyorganizationID = WorkflowExpression.Compile(bodyorganizationID, nameof(bodyorganizationID), required: false);
            var __workflow_bodyprojectID = WorkflowExpression.Compile(bodyprojectID, nameof(bodyprojectID), required: false);
            return new DeferredBodyAction<InitResponse>(() =>
            {
                var apiCallPath = "/init";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyorganizationID != null)
                {
                    body["business_organization_id"] = ExpressionConverter.ConvertO(__workflow_bodyorganizationID);
                    bodypropCount++;
                }

                if (__workflow_bodyprojectID != null)
                {
                    body["project_id"] = ExpressionConverter.ConvertO(__workflow_bodyprojectID);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<InitResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }
    }

    public class FinalcadoneconnectTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger ThenObsCreated(Expression<Func<string>> bodyorganizationID, Expression<Func<string>> bodyprojectID, FlowRecurrence recurrence = null)
        {
            var __workflow_bodyorganizationID = WorkflowExpression.Compile(bodyorganizationID, nameof(bodyorganizationID), required: true);
            var __workflow_bodyprojectID = WorkflowExpression.Compile(bodyprojectID, nameof(bodyprojectID), required: true);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = "/webhooks/ev/201";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["business_organization_id"] = ExpressionConverter.ConvertO(__workflow_bodyorganizationID);
                bodypropCount++;
                body["project_id"] = ExpressionConverter.ConvertO(__workflow_bodyprojectID);
                body["client_url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            }, WorkflowTriggerSettingProfiles.ManagedConnector);
        }

        public IWorkflowTrigger ThenObsUpdated(Expression<Func<string>> bodyorganizationID, Expression<Func<string>> bodyprojectID, FlowRecurrence recurrence = null)
        {
            var __workflow_bodyorganizationID = WorkflowExpression.Compile(bodyorganizationID, nameof(bodyorganizationID), required: true);
            var __workflow_bodyprojectID = WorkflowExpression.Compile(bodyprojectID, nameof(bodyprojectID), required: true);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = "/webhooks/ev/202";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["business_organization_id"] = ExpressionConverter.ConvertO(__workflow_bodyorganizationID);
                bodypropCount++;
                body["project_id"] = ExpressionConverter.ConvertO(__workflow_bodyprojectID);
                body["client_url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            }, WorkflowTriggerSettingProfiles.ManagedConnector);
        }

        public IWorkflowTrigger ThenFormCreated(Expression<Func<string>> bodyorganizationID, Expression<Func<string>> bodyprojectID, FlowRecurrence recurrence = null)
        {
            var __workflow_bodyorganizationID = WorkflowExpression.Compile(bodyorganizationID, nameof(bodyorganizationID), required: true);
            var __workflow_bodyprojectID = WorkflowExpression.Compile(bodyprojectID, nameof(bodyprojectID), required: true);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = "/webhooks/ev/301";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["business_organization_id"] = ExpressionConverter.ConvertO(__workflow_bodyorganizationID);
                bodypropCount++;
                body["project_id"] = ExpressionConverter.ConvertO(__workflow_bodyprojectID);
                body["client_url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            }, WorkflowTriggerSettingProfiles.ManagedConnector);
        }

        public IWorkflowTrigger ThenFormUpdated(Expression<Func<string>> bodyorganizationID, Expression<Func<string>> bodyprojectID, FlowRecurrence recurrence = null)
        {
            var __workflow_bodyorganizationID = WorkflowExpression.Compile(bodyorganizationID, nameof(bodyorganizationID), required: true);
            var __workflow_bodyprojectID = WorkflowExpression.Compile(bodyprojectID, nameof(bodyprojectID), required: true);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = "/webhooks/ev/302";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["business_organization_id"] = ExpressionConverter.ConvertO(__workflow_bodyorganizationID);
                bodypropCount++;
                body["project_id"] = ExpressionConverter.ConvertO(__workflow_bodyprojectID);
                body["client_url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            }, WorkflowTriggerSettingProfiles.ManagedConnector);
        }

        public IWorkflowTrigger ThenDocumentCreated(Expression<Func<string>> bodyorganizationID, Expression<Func<string>> bodyprojectID, FlowRecurrence recurrence = null)
        {
            var __workflow_bodyorganizationID = WorkflowExpression.Compile(bodyorganizationID, nameof(bodyorganizationID), required: true);
            var __workflow_bodyprojectID = WorkflowExpression.Compile(bodyprojectID, nameof(bodyprojectID), required: true);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = "/webhooks/ev/401";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["business_organization_id"] = ExpressionConverter.ConvertO(__workflow_bodyorganizationID);
                bodypropCount++;
                body["project_id"] = ExpressionConverter.ConvertO(__workflow_bodyprojectID);
                body["client_url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            }, WorkflowTriggerSettingProfiles.ManagedConnector);
        }
    }

    public class GetOrganizationsResponseItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class InitParametersResponse
    {
        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }
    }

    public class InitResponse
    {
        [JsonProperty("business_organization_id")]
        public string BusinessOrganizationId { get; set; }

        [JsonProperty("project_id")]
        public string ProjectId { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Finalcadoneconnect;

    public partial class WorkflowManagedActions
    {
        public FinalcadoneconnectActions Finalcadoneconnect(string connectionId) => new FinalcadoneconnectActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public FinalcadoneconnectTriggers Finalcadoneconnect(string connectionId) => new FinalcadoneconnectTriggers(connectionId);
    }
}
