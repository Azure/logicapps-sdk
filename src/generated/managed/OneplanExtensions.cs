//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Oneplan
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class OneplanActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "oneplan")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> GetPlan(Expression<Func<string>> planId)
        {
            var __workflow_planId = WorkflowExpression.Compile(planId, nameof(planId), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/workplan/{0}/flow/", __workflow_planId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "oneplan")]
        public IBodyWorkflowAction<CreatePlanResponse, ApiConnectionActionConfiguration> CreatePlan(Expression<Func<CreatePlanIntegrationPostInput>> integrationPost)
        {
            var __workflow_integrationPost = WorkflowExpression.Compile(integrationPost, nameof(integrationPost), required: true);
            return new DeferredBodyAction<CreatePlanResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/workplan/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_integrationPost);
                return new ApiConnectionAction<CreatePlanResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "oneplan")]
        public IWorkflowAction<ApiConnectionActionConfiguration> StampMapping(Expression<Func<bool>> isImport, Expression<Func<StampMappingIntegrationPostInput>> integrationPost)
        {
            var __workflow_isImport = WorkflowExpression.Compile(isImport, nameof(isImport), required: true);
            var __workflow_integrationPost = WorkflowExpression.Compile(integrationPost, nameof(integrationPost), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/integration/updateplanintegration";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["IsImport"] = ExpressionConverter.Convert(__workflow_isImport);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_integrationPost);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "oneplan")]
        public IBodyWorkflowAction<bool, ApiConnectionActionConfiguration> RespondToOnePlan(Expression<Func<RespondToOnePlanBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<bool, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/automation/powerautomate/response";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<bool>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "oneplan")]
        public IWorkflowAction<ApiConnectionActionConfiguration> GetResourceId(Expression<Func<string>> name = null, Expression<Func<string>> email = null)
        {
            var __workflow_name = WorkflowExpression.Compile(name, nameof(name), required: false);
            var __workflow_email = WorkflowExpression.Compile(email, nameof(email), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/resources/GetResourceId";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_name != null)
                    callPayload.Queries["Name"] = ExpressionConverter.Convert(__workflow_name);
                if (__workflow_email != null)
                    callPayload.Queries["Email "] = ExpressionConverter.Convert(__workflow_email);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "oneplan")]
        public IWorkflowAction<ApiConnectionActionConfiguration> QueryTasks(Expression<Func<string>> id, Expression<Func<string>> filterField, Expression<Func<string>> filterValue, Expression<Func<bool>> builtInField)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_filterField = WorkflowExpression.Compile(filterField, nameof(filterField), required: true);
            var __workflow_filterValue = WorkflowExpression.Compile(filterValue, nameof(filterValue), required: true);
            var __workflow_builtInField = WorkflowExpression.Compile(builtInField, nameof(builtInField), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/workplan/{0}/tasks", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["FilterField"] = ExpressionConverter.Convert(__workflow_filterField);
                callPayload.Queries["FilterValue"] = ExpressionConverter.Convert(__workflow_filterValue);
                callPayload.Queries["BuiltInField"] = ExpressionConverter.Convert(__workflow_builtInField);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "oneplan")]
        public IWorkflowAction<ApiConnectionActionConfiguration> CreateTask(Expression<Func<string>> id, Expression<Func<CreateTaskIntegrationPostInput>> integrationPost, Expression<Func<string>> name = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_integrationPost = WorkflowExpression.Compile(integrationPost, nameof(integrationPost), required: true);
            var __workflow_name = WorkflowExpression.Compile(name, nameof(name), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/workplan/{0}/tasks", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_name != null)
                    callPayload.Queries["Name"] = ExpressionConverter.Convert(__workflow_name);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_integrationPost);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "oneplan")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UpdateTask(Expression<Func<string>> id, Expression<Func<string>> taskid, Expression<Func<UpdateTaskIntegrationPostInput>> integrationPost)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_taskid = WorkflowExpression.Compile(taskid, nameof(taskid), required: true);
            var __workflow_integrationPost = WorkflowExpression.Compile(integrationPost, nameof(integrationPost), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/workplan/{0}/tasks/{1}", __workflow_id.WithUrlEncoding(1), __workflow_taskid.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_integrationPost);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "oneplan")]
        public IBodyWorkflowAction<GetTaskFieldsResponseItem[], ApiConnectionActionConfiguration> GetTaskFields()
        {
            return new DeferredBodyAction<GetTaskFieldsResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/tasks/fields/flow";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetTaskFieldsResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "oneplan")]
        public IWorkflowAction<ApiConnectionActionConfiguration> PlanStatusReport(Expression<Func<string>> planId)
        {
            var __workflow_planId = WorkflowExpression.Compile(planId, nameof(planId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/statusreports/{0}", __workflow_planId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "oneplan")]
        public IWorkflowAction<ApiConnectionActionConfiguration> StatusReportDoc(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/statusreports/{0}/doc", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "oneplan")]
        public IWorkflowAction<ApiConnectionActionConfiguration> QueryPlan(Expression<Func<string>> filterField, Expression<Func<string>> filterValue, Expression<Func<bool>> builtInField)
        {
            var __workflow_filterField = WorkflowExpression.Compile(filterField, nameof(filterField), required: true);
            var __workflow_filterValue = WorkflowExpression.Compile(filterValue, nameof(filterValue), required: true);
            var __workflow_builtInField = WorkflowExpression.Compile(builtInField, nameof(builtInField), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/workplan";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["FilterField"] = ExpressionConverter.Convert(__workflow_filterField);
                callPayload.Queries["FilterValue"] = ExpressionConverter.Convert(__workflow_filterValue);
                callPayload.Queries["BuiltInField"] = ExpressionConverter.Convert(__workflow_builtInField);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "oneplan")]
        public IBodyWorkflowAction<GetFieldListResponseItem[], ApiConnectionActionConfiguration> GetFieldList()
        {
            return new DeferredBodyAction<GetFieldListResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/workplan/fields/flowFields";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetFieldListResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "oneplan")]
        public IWorkflowAction<ApiConnectionActionConfiguration> GetTaskField()
        {
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/tasks/fields";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "oneplan")]
        public IWorkflowAction<ApiConnectionActionConfiguration> GetResourceField()
        {
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/resources/fields";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "oneplan")]
        public IWorkflowAction<ApiConnectionActionConfiguration> GetWorkPlanField()
        {
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/workplan/fields";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "oneplan")]
        public IBodyWorkflowAction<GetFieldListTasksResponseItem[], ApiConnectionActionConfiguration> GetFieldListTasks()
        {
            return new DeferredBodyAction<GetFieldListTasksResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/tasks/fields/flowFields";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetFieldListTasksResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "oneplan")]
        public IWorkflowAction<ApiConnectionActionConfiguration> GetResourceById(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/resources/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "oneplan")]
        public IWorkflowAction<ApiConnectionActionConfiguration> GetPlanTypeGuidByName(Expression<Func<string>> name)
        {
            var __workflow_name = WorkflowExpression.Compile(name, nameof(name), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/config/GetPlanTypeGuidByName";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Name"] = ExpressionConverter.Convert(__workflow_name);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "oneplan")]
        public IWorkflowAction<ApiConnectionActionConfiguration> GetMappedItem(Expression<Func<string>> integrationId, Expression<Func<string>> externalItemId)
        {
            var __workflow_integrationId = WorkflowExpression.Compile(integrationId, nameof(integrationId), required: true);
            var __workflow_externalItemId = WorkflowExpression.Compile(externalItemId, nameof(externalItemId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/integration/getintegratedplanId";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["IntegrationId"] = ExpressionConverter.Convert(__workflow_integrationId);
                callPayload.Queries["ExternalItemId"] = ExpressionConverter.Convert(__workflow_externalItemId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "oneplan")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UpdatePlan(Expression<Func<string>> id, Expression<Func<object>> workPlan)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_workPlan = WorkflowExpression.Compile(workPlan, nameof(workPlan), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/workplan/{0}/flow", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_workPlan);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "oneplan")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> StepUpdate(Expression<Func<string>> id, Expression<Func<string>> stepName = null, Expression<Func<string>> stepId = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_stepName = WorkflowExpression.Compile(stepName, nameof(stepName), required: false);
            var __workflow_stepId = WorkflowExpression.Compile(stepId, nameof(stepId), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/workplan/{0}/step", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_stepName != null)
                    callPayload.Queries["StepName"] = ExpressionConverter.Convert(__workflow_stepName);
                if (__workflow_stepId != null)
                    callPayload.Queries["StepId"] = ExpressionConverter.Convert(__workflow_stepId);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "oneplan")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> Approve(Expression<Func<string>> id, Expression<Func<StateInput>> state, Expression<Func<string>> comment = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_state = WorkflowExpression.Compile(state, nameof(state), required: true);
            var __workflow_comment = WorkflowExpression.Compile(comment, nameof(comment), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/workplan/{0}/step/approve", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["state"] = ExpressionConverter.Convert(__workflow_state);
                if (__workflow_comment != null)
                    callPayload.Queries["comment"] = ExpressionConverter.Convert(__workflow_comment);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }
    }

    public class OneplanTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger<ApiConnectionPollingTriggerConfiguration> StepUpdateTrigger(Expression<Func<StepUpdateTriggerBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/events/bylist/1";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionPollingTrigger(callPayload);
            });
        }

        public IWorkflowTrigger<ApiConnectionPollingTriggerConfiguration> StepAddTrigger(Expression<Func<StepAddTriggerBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/events/bylist/{0}", WorkflowExpression.Literal(0).WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionPollingTrigger(callPayload);
            });
        }

        public IWorkflowTrigger<ApiConnectionPollingTriggerConfiguration> PlanUpdateTrigger(Expression<Func<PlanUpdateTriggerBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/events/bylist/0";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionPollingTrigger(callPayload);
            });
        }

        public IWorkflowTrigger<ApiConnectionPollingTriggerConfiguration> AutomationTrigger(Expression<Func<AutomationTriggerBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/events/bylist/5";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionPollingTrigger(callPayload);
            });
        }
    }

    public class CreatePlanResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class CreatePlanIntegrationPostInput
    {
        public CreatePlanIntegrationPostInput(IntegrationPostInputWorkPlanType workPlan)
        {
            this.WorkPlan = workPlan;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public IntegrationPostInputWorkPlanType WorkPlan { get; set; }
    }

    public class IntegrationPostInputWorkPlanType
    {
        public IntegrationPostInputWorkPlanType(string planName, string planOwner, string planTypeId, JToken fields)
        {
            this.PlanName = planName;
            this.PlanOwner = planOwner;
            this.PlanTypeId = planTypeId;
            this.Fields = fields;
        }

        [JsonProperty("Name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string PlanName { get; set; }

        [JsonProperty("Owner", DefaultValueHandling = DefaultValueHandling.Include)]
        public string PlanOwner { get; set; }

        [JsonProperty("PlanType", DefaultValueHandling = DefaultValueHandling.Include)]
        public string PlanTypeId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken Fields { get; set; }
    }

    public class StampMappingIntegrationPostInput
    {
        public StampMappingIntegrationPostInput(string planId, string flowId, string externalSystemId, string externalSystemURL)
        {
            this.PlanId = planId;
            this.FlowId = flowId;
            this.ExternalSystemId = externalSystemId;
            this.ExternalSystemURL = externalSystemURL;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string PlanId { get; set; }

        [JsonProperty("IntegrationId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FlowId { get; set; }

        [JsonProperty("ItemId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ExternalSystemId { get; set; }

        [JsonProperty("ItemUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ExternalSystemURL { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        internal int IntegrationVersion { get; set; } = 0;
    }

    public class RespondToOnePlanBodyInput
    {
        public RespondToOnePlanBodyInput(string automationProcessId, string actionId, string configurationId, BodyInputStatusType status)
        {
            this.AutomationProcessId = automationProcessId;
            this.ActionId = actionId;
            this.ConfigurationId = configurationId;
            this.Status = status;
        }

        [JsonProperty("automationProcessId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string AutomationProcessId { get; set; }

        [JsonProperty("actionId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ActionId { get; set; }

        [JsonProperty("configId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ConfigurationId { get; set; }

        [JsonProperty("status", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputStatusType Status { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputStatusType
    {
        Success,
        Cancelled
    }

    public class CreateTaskIntegrationPostInput
    {
        public CreateTaskIntegrationPostInput(string taskName, JToken fields)
        {
            this.TaskName = taskName;
            this.Fields = fields;
        }

        [JsonProperty("Name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string TaskName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken Fields { get; set; }
    }

    public class UpdateTaskIntegrationPostInput
    {
        public UpdateTaskIntegrationPostInput(JToken fields)
        {
            this.Fields = fields;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken Fields { get; set; }
    }

    public class GetTaskFieldsResponseItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }
    }

    public class GetFieldListResponseItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }
    }

    public class GetFieldListTasksResponseItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum StateInput
    {
        Approved,
        Pending,
        Rejected
    }

    public class StepUpdateTriggerBodyInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        internal string EventUrl { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        internal int List { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Strategy { get; set; } = "Power Automate Step Change Trigger";

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        internal int EventURLType { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        internal int[] Triggers { get; set; } = new int[]
        {
            1
        };
    }

    public class StepAddTriggerBodyInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        internal string EventUrl { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        internal int List { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Strategy { get; set; } = "Power Automate Plan Added Trigger";

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        internal int EventURLType { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        internal int[] Triggers { get; set; } = new int[]
        {
            0
        };
    }

    public class PlanUpdateTriggerBodyInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        internal string EventUrl { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Strategy { get; set; } = "Power Automate Plan Update Trigger";

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        internal int EventURLType { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        internal int[] Triggers { get; set; } = new int[]
        {
            1
        };
    }

    public class AutomationTriggerBodyInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        internal string EventUrl { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        internal int List { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Strategy { get; set; } = "Power Automate Automation Trigger";

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        internal int EventURLType { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        internal int[] Triggers { get; set; } = new int[]
        {
            1
        };
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Oneplan;

    public partial class WorkflowManagedActions
    {
        public OneplanActions Oneplan(string connectionId) => new OneplanActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public OneplanTriggers Oneplan(string connectionId) => new OneplanTriggers(connectionId);
    }
}