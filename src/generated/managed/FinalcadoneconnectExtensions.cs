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
        public IBodyWorkflowAction<GetOrganizationsResponseItem[], ApiConnectionActionConfiguration> GetOrganizations(Expression<Func<string>> acceptLanguage = null, Expression<Func<string>> xTimeZone = null)
        {
            var __workflow_acceptLanguage = WorkflowExpression.Compile(acceptLanguage, nameof(acceptLanguage), required: false);
            var __workflow_xTimeZone = WorkflowExpression.Compile(xTimeZone, nameof(xTimeZone), required: false);
            return new DeferredBodyAction<GetOrganizationsResponseItem[], ApiConnectionActionConfiguration>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "finalcadoneconnect")]
        public IBodyWorkflowAction<InitParametersResponse, ApiConnectionActionConfiguration> InitParameters(Expression<Func<string>> bodylanguage = null, Expression<Func<string>> bodytheUserSTimeZoneInIANAFormat = null)
        {
            var __workflow_bodylanguage = WorkflowExpression.Compile(bodylanguage, nameof(bodylanguage), required: false);
            var __workflow_bodytheUserSTimeZoneInIANAFormat = WorkflowExpression.Compile(bodytheUserSTimeZoneInIANAFormat, nameof(bodytheUserSTimeZoneInIANAFormat), required: false);
            return new DeferredBodyAction<InitParametersResponse, ApiConnectionActionConfiguration>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "finalcadoneconnect")]
        public IBodyWorkflowAction<InitResponse, ApiConnectionActionConfiguration> Init(Expression<Func<string>> bodyorganizationId = null, Expression<Func<string>> bodyprojectId = null)
        {
            var __workflow_bodyorganizationId = WorkflowExpression.Compile(bodyorganizationId, nameof(bodyorganizationId), required: false);
            var __workflow_bodyprojectId = WorkflowExpression.Compile(bodyprojectId, nameof(bodyprojectId), required: false);
            return new DeferredBodyAction<InitResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/init";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyorganizationId != null)
                {
                    body["business_organization_id"] = ExpressionConverter.ConvertO(__workflow_bodyorganizationId);
                    bodypropCount++;
                }

                if (__workflow_bodyprojectId != null)
                {
                    body["project_id"] = ExpressionConverter.ConvertO(__workflow_bodyprojectId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<InitResponse>(callPayload);
            });
        }
    }

    public class FinalcadoneconnectTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> ThenObsCreated(Expression<Func<string>> bodyorganizationId, Expression<Func<string>> bodyprojectId, FlowRecurrence recurrence = null)
        {
            var __workflow_bodyorganizationId = WorkflowExpression.Compile(bodyorganizationId, nameof(bodyorganizationId), required: true);
            var __workflow_bodyprojectId = WorkflowExpression.Compile(bodyprojectId, nameof(bodyprojectId), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/webhooks/ev/201";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["business_organization_id"] = ExpressionConverter.ConvertO(__workflow_bodyorganizationId);
                bodypropCount++;
                body["project_id"] = ExpressionConverter.ConvertO(__workflow_bodyprojectId);
                body["client_url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> ThenObsUpdated(Expression<Func<string>> bodyorganizationId, Expression<Func<string>> bodyprojectId, FlowRecurrence recurrence = null)
        {
            var __workflow_bodyorganizationId = WorkflowExpression.Compile(bodyorganizationId, nameof(bodyorganizationId), required: true);
            var __workflow_bodyprojectId = WorkflowExpression.Compile(bodyprojectId, nameof(bodyprojectId), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/webhooks/ev/202";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["business_organization_id"] = ExpressionConverter.ConvertO(__workflow_bodyorganizationId);
                bodypropCount++;
                body["project_id"] = ExpressionConverter.ConvertO(__workflow_bodyprojectId);
                body["client_url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> ThenFormCreated(Expression<Func<string>> bodyorganizationId, Expression<Func<string>> bodyprojectId, FlowRecurrence recurrence = null)
        {
            var __workflow_bodyorganizationId = WorkflowExpression.Compile(bodyorganizationId, nameof(bodyorganizationId), required: true);
            var __workflow_bodyprojectId = WorkflowExpression.Compile(bodyprojectId, nameof(bodyprojectId), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/webhooks/ev/301";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["business_organization_id"] = ExpressionConverter.ConvertO(__workflow_bodyorganizationId);
                bodypropCount++;
                body["project_id"] = ExpressionConverter.ConvertO(__workflow_bodyprojectId);
                body["client_url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> ThenFormUpdated(Expression<Func<string>> bodyorganizationId, Expression<Func<string>> bodyprojectId, FlowRecurrence recurrence = null)
        {
            var __workflow_bodyorganizationId = WorkflowExpression.Compile(bodyorganizationId, nameof(bodyorganizationId), required: true);
            var __workflow_bodyprojectId = WorkflowExpression.Compile(bodyprojectId, nameof(bodyprojectId), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/webhooks/ev/302";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["business_organization_id"] = ExpressionConverter.ConvertO(__workflow_bodyorganizationId);
                bodypropCount++;
                body["project_id"] = ExpressionConverter.ConvertO(__workflow_bodyprojectId);
                body["client_url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> ThenDocumentCreated(Expression<Func<string>> bodyorganizationId, Expression<Func<string>> bodyprojectId, FlowRecurrence recurrence = null)
        {
            var __workflow_bodyorganizationId = WorkflowExpression.Compile(bodyorganizationId, nameof(bodyorganizationId), required: true);
            var __workflow_bodyprojectId = WorkflowExpression.Compile(bodyprojectId, nameof(bodyprojectId), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/webhooks/ev/401";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["business_organization_id"] = ExpressionConverter.ConvertO(__workflow_bodyorganizationId);
                bodypropCount++;
                body["project_id"] = ExpressionConverter.ConvertO(__workflow_bodyprojectId);
                body["client_url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
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