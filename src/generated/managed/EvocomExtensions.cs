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
        [WorkflowExpressionFactory(nameof(__BuildGetTeams))]
        public IBodyWorkflowAction<TeamResponseV2[]> GetTeams([WorkflowExpression] Func<string> xEpTenant)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TeamResponseV2[]> __BuildGetTeams(WorkflowValue<string> xEpTenant)
        {
            WorkflowValue.Validate(xEpTenant, nameof(xEpTenant), required: true);
            return new DeferredBodyAction<TeamResponseV2[]>(() =>
            {
                var apiCallPath = "/api/Teams";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-ep-tenant"] = ExpressionConverter.Convert(xEpTenant);
                return new ApiConnectionAction<TeamResponseV2[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "evocom")]
        [WorkflowExpressionFactory(nameof(__BuildGetTemplates))]
        public IBodyWorkflowAction<RouteDefinitionsResponse> GetTemplates([WorkflowExpression] Func<string> xEpTenant, [WorkflowExpression] Func<int> pageIndex = null, [WorkflowExpression] Func<int> itemsPerPage = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<RouteDefinitionsResponse> __BuildGetTemplates(WorkflowValue<string> xEpTenant, WorkflowValue<int> pageIndex = null, WorkflowValue<int> itemsPerPage = null)
        {
            WorkflowValue.Validate(xEpTenant, nameof(xEpTenant), required: true);
            WorkflowValue.Validate(pageIndex, nameof(pageIndex), required: false);
            WorkflowValue.Validate(itemsPerPage, nameof(itemsPerPage), required: false);
            return new DeferredBodyAction<RouteDefinitionsResponse>(() =>
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
            });
        }
    }

    public class EvocomTriggers([ConnectionName] string connectionId)
    {
        [WorkflowExpressionFactory(nameof(__BuildNewTaskTrigger))]
        public IWorkflowTrigger NewTaskTrigger([WorkflowExpression] Func<string> xEpTenant, [WorkflowExpression] Func<int> bodytaskType = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildNewTaskTrigger(WorkflowValue<string> xEpTenant, WorkflowValue<int> bodytaskType = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(xEpTenant, nameof(xEpTenant), required: true);
            WorkflowValue.Validate(bodytaskType, nameof(bodytaskType), required: false);
            return new DeferredWorkflowTrigger(() =>
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
            }, triggerName);
        }

        [WorkflowExpressionFactory(nameof(__BuildChangedTaskTrigger))]
        public IWorkflowTrigger ChangedTaskTrigger([WorkflowExpression] Func<string> xEpTenant, [WorkflowExpression] Func<int> bodychangeType, [WorkflowExpression] Func<int> bodytaskType = null, [WorkflowExpression] Func<int> bodytaskStatus = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildChangedTaskTrigger(WorkflowValue<string> xEpTenant, WorkflowValue<int> bodychangeType, WorkflowValue<int> bodytaskType = null, WorkflowValue<int> bodytaskStatus = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(xEpTenant, nameof(xEpTenant), required: true);
            WorkflowValue.Validate(bodychangeType, nameof(bodychangeType), required: true);
            WorkflowValue.Validate(bodytaskType, nameof(bodytaskType), required: false);
            WorkflowValue.Validate(bodytaskStatus, nameof(bodytaskStatus), required: false);
            return new DeferredWorkflowTrigger(() =>
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
            }, triggerName);
        }

        [WorkflowExpressionFactory(nameof(__BuildNewTeamTrigger))]
        public IWorkflowTrigger NewTeamTrigger([WorkflowExpression] Func<string> xEpTenant, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildNewTeamTrigger(WorkflowValue<string> xEpTenant, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(xEpTenant, nameof(xEpTenant), required: true);
            return new DeferredWorkflowTrigger(() =>
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
            }, triggerName);
        }

        [WorkflowExpressionFactory(nameof(__BuildChangedTeamTrigger))]
        public IWorkflowTrigger ChangedTeamTrigger([WorkflowExpression] Func<string> xEpTenant, [WorkflowExpression] Func<int> bodychangeType, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildChangedTeamTrigger(WorkflowValue<string> xEpTenant, WorkflowValue<int> bodychangeType, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(xEpTenant, nameof(xEpTenant), required: true);
            WorkflowValue.Validate(bodychangeType, nameof(bodychangeType), required: true);
            return new DeferredWorkflowTrigger(() =>
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
            }, triggerName);
        }

        [WorkflowExpressionFactory(nameof(__BuildNewProcessTrigger))]
        public IWorkflowTrigger NewProcessTrigger([WorkflowExpression] Func<string> xEpTenant, [WorkflowExpression] Func<string> bodydefinitionId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildNewProcessTrigger(WorkflowValue<string> xEpTenant, WorkflowValue<string> bodydefinitionId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(xEpTenant, nameof(xEpTenant), required: true);
            WorkflowValue.Validate(bodydefinitionId, nameof(bodydefinitionId), required: true);
            return new DeferredWorkflowTrigger(() =>
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
            }, triggerName);
        }

        [WorkflowExpressionFactory(nameof(__BuildChangedProcessTrigger))]
        public IWorkflowTrigger ChangedProcessTrigger([WorkflowExpression] Func<string> xEpTenant, [WorkflowExpression] Func<int> bodychangeType, [WorkflowExpression] Func<string> bodydefinitionId = null, [WorkflowExpression] Func<string> bodystepId = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildChangedProcessTrigger(WorkflowValue<string> xEpTenant, WorkflowValue<int> bodychangeType, WorkflowValue<string> bodydefinitionId = null, WorkflowValue<string> bodystepId = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(xEpTenant, nameof(xEpTenant), required: true);
            WorkflowValue.Validate(bodychangeType, nameof(bodychangeType), required: true);
            WorkflowValue.Validate(bodydefinitionId, nameof(bodydefinitionId), required: false);
            WorkflowValue.Validate(bodystepId, nameof(bodystepId), required: false);
            return new DeferredWorkflowTrigger(() =>
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
            }, triggerName);
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
