//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Evocom
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class EvocomActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "evocom")]
        public IBodyWorkflowAction<TeamResponseV2[]> GetTeams(Expression<Func<string>> xEpTenant)
        {
            var __workflow_xEpTenant = WorkflowExpression.Compile(xEpTenant, nameof(xEpTenant), required: true);
            return new DeferredBodyAction<TeamResponseV2[]>(() =>
            {
                var apiCallPath = "/api/Teams";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-ep-tenant"] = ExpressionConverter.Convert(__workflow_xEpTenant);
                return new ApiConnectionAction<TeamResponseV2[]>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "evocom")]
        public IBodyWorkflowAction<RouteDefinitionsResponse> GetTemplates(Expression<Func<string>> xEpTenant, Expression<Func<int>> pageIndex = null, Expression<Func<int>> itemsPerPage = null)
        {
            var __workflow_xEpTenant = WorkflowExpression.Compile(xEpTenant, nameof(xEpTenant), required: true);
            var __workflow_pageIndex = WorkflowExpression.Compile(pageIndex, nameof(pageIndex), required: false);
            var __workflow_itemsPerPage = WorkflowExpression.Compile(itemsPerPage, nameof(itemsPerPage), required: false);
            return new DeferredBodyAction<RouteDefinitionsResponse>(() =>
            {
                var apiCallPath = "/api/Route/Definitions";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["pageIndex"] = Convert.ToString(0);
                if (__workflow_pageIndex != null)
                    callPayload.Queries["pageIndex"] = ExpressionConverter.Convert(__workflow_pageIndex);
                callPayload.Queries["itemsPerPage"] = Convert.ToString(1000);
                if (__workflow_itemsPerPage != null)
                    callPayload.Queries["itemsPerPage"] = ExpressionConverter.Convert(__workflow_itemsPerPage);
                callPayload.Headers["x-ep-tenant"] = ExpressionConverter.Convert(__workflow_xEpTenant);
                return new ApiConnectionAction<RouteDefinitionsResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }
    }

    public class EvocomTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger NewTaskTrigger(Expression<Func<string>> xEpTenant, Expression<Func<int>> bodytaskType = null, FlowRecurrence recurrence = null)
        {
            var __workflow_xEpTenant = WorkflowExpression.Compile(xEpTenant, nameof(xEpTenant), required: true);
            var __workflow_bodytaskType = WorkflowExpression.Compile(bodytaskType, nameof(bodytaskType), required: false);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = "/hooks/Tasks/New";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-ep-tenant"] = ExpressionConverter.Convert(__workflow_xEpTenant);
                var body = new JObject();
                var bodypropCount = 0;
                body["callbackUrl"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (__workflow_bodytaskType != null)
                {
                    body["taskType"] = ExpressionConverter.ConvertO(__workflow_bodytaskType);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            }, WorkflowTriggerSettingsProfiles.ManagedConnector);
        }

        public IWorkflowTrigger ChangedTaskTrigger(Expression<Func<string>> xEpTenant, Expression<Func<int>> bodychangeType, Expression<Func<int>> bodytaskType = null, Expression<Func<int>> bodytaskStatus = null, FlowRecurrence recurrence = null)
        {
            var __workflow_xEpTenant = WorkflowExpression.Compile(xEpTenant, nameof(xEpTenant), required: true);
            var __workflow_bodychangeType = WorkflowExpression.Compile(bodychangeType, nameof(bodychangeType), required: true);
            var __workflow_bodytaskType = WorkflowExpression.Compile(bodytaskType, nameof(bodytaskType), required: false);
            var __workflow_bodytaskStatus = WorkflowExpression.Compile(bodytaskStatus, nameof(bodytaskStatus), required: false);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = "/hooks/Tasks/Change";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-ep-tenant"] = ExpressionConverter.Convert(__workflow_xEpTenant);
                var body = new JObject();
                var bodypropCount = 0;
                body["callbackUrl"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (__workflow_bodytaskType != null)
                {
                    body["taskType"] = ExpressionConverter.ConvertO(__workflow_bodytaskType);
                    bodypropCount++;
                }

                bodypropCount++;
                body["changeType"] = ExpressionConverter.ConvertO(__workflow_bodychangeType);
                if (__workflow_bodytaskStatus != null)
                {
                    body["taskStatus"] = ExpressionConverter.ConvertO(__workflow_bodytaskStatus);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            }, WorkflowTriggerSettingsProfiles.ManagedConnector);
        }

        public IWorkflowTrigger NewTeamTrigger(Expression<Func<string>> xEpTenant, FlowRecurrence recurrence = null)
        {
            var __workflow_xEpTenant = WorkflowExpression.Compile(xEpTenant, nameof(xEpTenant), required: true);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = "/hooks/Teams/New";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-ep-tenant"] = ExpressionConverter.Convert(__workflow_xEpTenant);
                var body = new JObject();
                var bodypropCount = 0;
                body["callbackUrl"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            }, WorkflowTriggerSettingsProfiles.ManagedConnector);
        }

        public IWorkflowTrigger ChangedTeamTrigger(Expression<Func<string>> xEpTenant, Expression<Func<int>> bodychangeType, FlowRecurrence recurrence = null)
        {
            var __workflow_xEpTenant = WorkflowExpression.Compile(xEpTenant, nameof(xEpTenant), required: true);
            var __workflow_bodychangeType = WorkflowExpression.Compile(bodychangeType, nameof(bodychangeType), required: true);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = "/hooks/Teams/Change";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-ep-tenant"] = ExpressionConverter.Convert(__workflow_xEpTenant);
                var body = new JObject();
                var bodypropCount = 0;
                body["callbackUrl"] = "#{listCallbackUrl()}";
                bodypropCount++;
                bodypropCount++;
                body["changeType"] = ExpressionConverter.ConvertO(__workflow_bodychangeType);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            }, WorkflowTriggerSettingsProfiles.ManagedConnector);
        }

        public IWorkflowTrigger NewProcessTrigger(Expression<Func<string>> xEpTenant, Expression<Func<string>> bodydefinitionId, FlowRecurrence recurrence = null)
        {
            var __workflow_xEpTenant = WorkflowExpression.Compile(xEpTenant, nameof(xEpTenant), required: true);
            var __workflow_bodydefinitionId = WorkflowExpression.Compile(bodydefinitionId, nameof(bodydefinitionId), required: true);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = "/hooks/Processes/New";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-ep-tenant"] = ExpressionConverter.Convert(__workflow_xEpTenant);
                var body = new JObject();
                var bodypropCount = 0;
                body["callbackUrl"] = "#{listCallbackUrl()}";
                bodypropCount++;
                bodypropCount++;
                body["definitionId"] = ExpressionConverter.ConvertO(__workflow_bodydefinitionId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            }, WorkflowTriggerSettingsProfiles.ManagedConnector);
        }

        public IWorkflowTrigger ChangedProcessTrigger(Expression<Func<string>> xEpTenant, Expression<Func<int>> bodychangeType, Expression<Func<string>> bodydefinitionId = null, Expression<Func<string>> bodystepId = null, FlowRecurrence recurrence = null)
        {
            var __workflow_xEpTenant = WorkflowExpression.Compile(xEpTenant, nameof(xEpTenant), required: true);
            var __workflow_bodychangeType = WorkflowExpression.Compile(bodychangeType, nameof(bodychangeType), required: true);
            var __workflow_bodydefinitionId = WorkflowExpression.Compile(bodydefinitionId, nameof(bodydefinitionId), required: false);
            var __workflow_bodystepId = WorkflowExpression.Compile(bodystepId, nameof(bodystepId), required: false);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = "/hooks/Processes/Change";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-ep-tenant"] = ExpressionConverter.Convert(__workflow_xEpTenant);
                var body = new JObject();
                var bodypropCount = 0;
                body["callbackUrl"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (__workflow_bodydefinitionId != null)
                {
                    body["definitionId"] = ExpressionConverter.ConvertO(__workflow_bodydefinitionId);
                    bodypropCount++;
                }

                bodypropCount++;
                body["changeType"] = ExpressionConverter.ConvertO(__workflow_bodychangeType);
                if (__workflow_bodystepId != null)
                {
                    body["stepId"] = ExpressionConverter.ConvertO(__workflow_bodystepId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            }, WorkflowTriggerSettingsProfiles.ManagedConnector);
        }
    }

    public class TeamResponseV2
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("displayTitle")]
        public string DisplayTitle { get; set; }

        [JsonProperty("departmentId")]
        public int DepartmentId { get; set; }

        [JsonProperty("typeId")]
        public int TypeId { get; set; }

        [JsonProperty("country")]
        public CountryResponse Country { get; set; }

        [JsonProperty("location")]
        public LocationResponse Location { get; set; }
    }

    public class CountryResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class LocationResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class RouteDefinitionsResponse
    {
        [JsonProperty("items")]
        public RouteDefinitionResponseV2[] ProcessTemplates { get; set; }
    }

    public class RouteDefinitionResponseV2
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("startUrl")]
        public string StartUrl { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Evocom;

    public partial class WorkflowManagedActions
    {
        public EvocomActions Evocom(string connectionId) => new EvocomActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public EvocomTriggers Evocom(string connectionId) => new EvocomTriggers(connectionId);
    }
}
