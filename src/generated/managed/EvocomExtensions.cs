//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Evocom
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class EvocomActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "evocom")]
        public IBodyWorkflowAction<TeamResponseV2[]> GetTeams([WorkflowExpression] Func<string> xEpTenant)
        {
            var apiCallPath = "/api/Teams";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["x-ep-tenant"] = ExpressionConverter.Convert(xEpTenant);
            return new ApiConnectionAction<TeamResponseV2[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "evocom")]
        public IBodyWorkflowAction<RouteDefinitionsResponse> GetTemplates([WorkflowExpression] Func<string> xEpTenant, [WorkflowExpression] Func<int> pageIndex = null, [WorkflowExpression] Func<int> itemsPerPage = null)
        {
            var apiCallPath = "/api/Route/Definitions";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["pageIndex"] = Convert.ToString(0);
            if (pageIndex != null)
                callPayload.Queries["pageIndex"] = ExpressionConverter.Convert(pageIndex);
            callPayload.Queries["itemsPerPage"] = Convert.ToString(1000);
            if (itemsPerPage != null)
                callPayload.Queries["itemsPerPage"] = ExpressionConverter.Convert(itemsPerPage);
            callPayload.Headers["x-ep-tenant"] = ExpressionConverter.Convert(xEpTenant);
            return new ApiConnectionAction<RouteDefinitionsResponse>(callPayload);
        }
    }

    public class EvocomTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger NewTaskTrigger([WorkflowExpression] Func<string> xEpTenant, [WorkflowExpression] Func<int> bodytaskType = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/hooks/Tasks/New";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["x-ep-tenant"] = ExpressionConverter.Convert(xEpTenant);
            var body = new JObject();
            var bodypropCount = 0;
            body["callbackUrl"] = "#{listCallbackUrl()}";
            bodypropCount++;
            if (bodytaskType != null)
            {
                body["taskType"] = ExpressionConverter.ConvertO(bodytaskType);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger ChangedTaskTrigger([WorkflowExpression] Func<string> xEpTenant, [WorkflowExpression] Func<int> bodychangeType, [WorkflowExpression] Func<int> bodytaskType = null, [WorkflowExpression] Func<int> bodytaskStatus = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/hooks/Tasks/Change";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["x-ep-tenant"] = ExpressionConverter.Convert(xEpTenant);
            var body = new JObject();
            var bodypropCount = 0;
            body["callbackUrl"] = "#{listCallbackUrl()}";
            bodypropCount++;
            if (bodytaskType != null)
            {
                body["taskType"] = ExpressionConverter.ConvertO(bodytaskType);
                bodypropCount++;
            }

            bodypropCount++;
            body["changeType"] = ExpressionConverter.ConvertO(bodychangeType);
            if (bodytaskStatus != null)
            {
                body["taskStatus"] = ExpressionConverter.ConvertO(bodytaskStatus);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger NewTeamTrigger([WorkflowExpression] Func<string> xEpTenant, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/hooks/Teams/New";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["x-ep-tenant"] = ExpressionConverter.Convert(xEpTenant);
            var body = new JObject();
            var bodypropCount = 0;
            body["callbackUrl"] = "#{listCallbackUrl()}";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger ChangedTeamTrigger([WorkflowExpression] Func<string> xEpTenant, [WorkflowExpression] Func<int> bodychangeType, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/hooks/Teams/Change";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["x-ep-tenant"] = ExpressionConverter.Convert(xEpTenant);
            var body = new JObject();
            var bodypropCount = 0;
            body["callbackUrl"] = "#{listCallbackUrl()}";
            bodypropCount++;
            bodypropCount++;
            body["changeType"] = ExpressionConverter.ConvertO(bodychangeType);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger NewProcessTrigger([WorkflowExpression] Func<string> xEpTenant, [WorkflowExpression] Func<string> bodydefinitionId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/hooks/Processes/New";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["x-ep-tenant"] = ExpressionConverter.Convert(xEpTenant);
            var body = new JObject();
            var bodypropCount = 0;
            body["callbackUrl"] = "#{listCallbackUrl()}";
            bodypropCount++;
            bodypropCount++;
            body["definitionId"] = ExpressionConverter.ConvertO(bodydefinitionId);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger ChangedProcessTrigger([WorkflowExpression] Func<string> xEpTenant, [WorkflowExpression] Func<int> bodychangeType, [WorkflowExpression] Func<string> bodydefinitionId = null, [WorkflowExpression] Func<string> bodystepId = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/hooks/Processes/Change";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["x-ep-tenant"] = ExpressionConverter.Convert(xEpTenant);
            var body = new JObject();
            var bodypropCount = 0;
            body["callbackUrl"] = "#{listCallbackUrl()}";
            bodypropCount++;
            if (bodydefinitionId != null)
            {
                body["definitionId"] = ExpressionConverter.ConvertO(bodydefinitionId);
                bodypropCount++;
            }

            bodypropCount++;
            body["changeType"] = ExpressionConverter.ConvertO(bodychangeType);
            if (bodystepId != null)
            {
                body["stepId"] = ExpressionConverter.ConvertO(bodystepId);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
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