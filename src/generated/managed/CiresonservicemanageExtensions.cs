//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Ciresonservicemanage
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CiresonservicemanageActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ciresonservicemanage")]
        public IBodyWorkflowAction<WorkItemGetResponse, ApiConnectionActionConfiguration> GetWorkItem(Expression<Func<string>> workItemId)
        {
            var __workflow_workItemId = WorkflowExpression.Compile(workItemId, nameof(workItemId), required: true);
            return new DeferredBodyAction<WorkItemGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/CloudConnector/WorkItems/{0}", __workflow_workItemId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<WorkItemGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ciresonservicemanage")]
        public IBodyWorkflowAction<DeleteWorkItemResponse, ApiConnectionActionConfiguration> DeleteWorkItem(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<DeleteWorkItemResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/CloudConnector/WorkItems/{0}/", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<DeleteWorkItemResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ciresonservicemanage")]
        public IBodyWorkflowAction<WorkItemCreatedIRResponse, ApiConnectionActionConfiguration> CreateIncident(Expression<Func<CreateIncidentInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<WorkItemCreatedIRResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/CloudConnector/Incident";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<WorkItemCreatedIRResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ciresonservicemanage")]
        public IBodyWorkflowAction<WorkItemCreatedIRResponse, ApiConnectionActionConfiguration> UpdateIncident(Expression<Func<string>> id, Expression<Func<UpdateIncidentInput>> body = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<WorkItemCreatedIRResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/CloudConnector/Incident/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<WorkItemCreatedIRResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ciresonservicemanage")]
        public IBodyWorkflowAction<WorkItemCreatedSRResponse, ApiConnectionActionConfiguration> CreateServiceRequest(Expression<Func<CreateServiceRequestInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<WorkItemCreatedSRResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/CloudConnector/ServiceRequest";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<WorkItemCreatedSRResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ciresonservicemanage")]
        public IBodyWorkflowAction<WorkItemCreatedSRResponse, ApiConnectionActionConfiguration> UpdateServiceRequest(Expression<Func<string>> id, Expression<Func<UpdateServiceRequestInput>> body = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<WorkItemCreatedSRResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/CloudConnector/ServiceRequest/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<WorkItemCreatedSRResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ciresonservicemanage")]
        public IBodyWorkflowAction<WorkItemCreatedSRResponse, ApiConnectionActionConfiguration> CreateChangeRequest(Expression<Func<CreateChangeRequestInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<WorkItemCreatedSRResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/CloudConnector/ChangeRequest";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<WorkItemCreatedSRResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ciresonservicemanage")]
        public IBodyWorkflowAction<WorkItemCreatedSRResponse, ApiConnectionActionConfiguration> UpdateChangeRequest(Expression<Func<string>> id, Expression<Func<UpdateChangeRequestInput>> body = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<WorkItemCreatedSRResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/CloudConnector/ChangeRequest/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<WorkItemCreatedSRResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ciresonservicemanage")]
        public IBodyWorkflowAction<WorkItemCreatedIRResponse, ApiConnectionActionConfiguration> CreateProblem(Expression<Func<CreateProblemInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<WorkItemCreatedIRResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/CloudConnector/Problem";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<WorkItemCreatedIRResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ciresonservicemanage")]
        public IBodyWorkflowAction<WorkItemCreatedIRResponse, ApiConnectionActionConfiguration> UpdateProblem(Expression<Func<string>> id, Expression<Func<UpdateProblemInput>> body = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<WorkItemCreatedIRResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/CloudConnector/Problem/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<WorkItemCreatedIRResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ciresonservicemanage")]
        public IBodyWorkflowAction<WorkItemCreatedSRResponse, ApiConnectionActionConfiguration> CreateReleaseRecord(Expression<Func<CreateReleaseRecordInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<WorkItemCreatedSRResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/CloudConnector/ReleaseRecord";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<WorkItemCreatedSRResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ciresonservicemanage")]
        public IBodyWorkflowAction<WorkItemCreatedSRResponse, ApiConnectionActionConfiguration> UpdateReleaseRecord(Expression<Func<string>> id, Expression<Func<UpdateReleaseRecordInput>> body = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<WorkItemCreatedSRResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/CloudConnector/ReleaseRecord/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<WorkItemCreatedSRResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ciresonservicemanage")]
        public IBodyWorkflowAction<WorkItemActionLogResponse, ApiConnectionActionConfiguration> AddCommentLog(Expression<Func<string>> id, Expression<Func<AddCommentLogInput>> body = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<WorkItemActionLogResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/cloudconnector/workItems/{0}/ActionLogComment", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<WorkItemActionLogResponse>(callPayload);
            });
        }
    }

    public class CiresonservicemanageTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<WebhookSettings, ApiConnectionTriggerConfiguration> CreateWebhook(Expression<Func<CreateWebhookInput>> body = null, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyTrigger<WebhookSettings, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/platform/api/CreateWebhooks";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger<WebhookSettings>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<WebhookSettings, ApiConnectionTriggerConfiguration> CreateActionLogWebhook(Expression<Func<CreateActionLogWebhookInput>> body = null, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyTrigger<WebhookSettings, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/platform/api/CreateActionLogWebhooks";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger<WebhookSettings>(callPayload, recurrence: recurrence);
            });
        }
    }

    public class WorkItemGetResponse
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string PriorityText { get; set; }
        public JToken Classification { get; set; }
        public JToken Urgency { get; set; }
        public JToken Impact { get; set; }
        public JToken Source { get; set; }
        public JToken SupportGroup { get; set; }
        public JToken Status { get; set; }
        public JToken AssignedWorkItem { get; set; }
        public JToken RequestedWorkItem { get; set; }
    }

    public class DeleteWorkItemResponse
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("data")]
        public string Data { get; set; }

        [JsonProperty("exception")]
        public string Exception { get; set; }
        public string BaseId { get; set; }
    }

    public class WorkItemCreatedIRResponse
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Priority { get; set; }
        public JToken Urgency { get; set; }
        public JToken Impact { get; set; }
        public JToken Source { get; set; }
        public JToken SupportGroup { get; set; }
        public JToken Status { get; set; }
        public JToken AssignedWorkItem { get; set; }
        public JToken RequestedWorkItem { get; set; }
    }

    public class CreateIncidentInput
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int? Priority { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Classification { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Urgency { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Impact { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Source { get; set; }
        public string SupportGroup { get; set; }
        public string Status { get; set; }

        [JsonProperty("RequestedWorkItem")]
        public string AffectedUser { get; set; }

        [JsonProperty("AssignedWorkItem")]
        public string AssignedUser { get; set; }
    }

    public class UpdateIncidentInput
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int? Priority { get; set; }
        public string Classification { get; set; }
        public string Urgency { get; set; }
        public string Impact { get; set; }
        public string Source { get; set; }
        public string SupportGroup { get; set; }
        public string Status { get; set; }

        [JsonProperty("RequestedWorkItem")]
        public string AffectedUser { get; set; }

        [JsonProperty("AssignedWorkItem")]
        public string AssignedUser { get; set; }
    }

    public class WorkItemCreatedSRResponse
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public JToken Priority { get; set; }
        public JToken Classification { get; set; }
        public JToken Urgency { get; set; }
        public JToken Impact { get; set; }
        public JToken Source { get; set; }
        public JToken SupportGroup { get; set; }
        public JToken Status { get; set; }
        public JToken AssignedWorkItem { get; set; }
        public JToken RequestedWorkItem { get; set; }
    }

    public class CreateServiceRequestInput
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Priority { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Area { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Urgency { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Source { get; set; }
        public string SupportGroup { get; set; }
        public string Status { get; set; }

        [JsonProperty("RequestedWorkItem")]
        public string AffectedUser { get; set; }

        [JsonProperty("AssignedWorkItem")]
        public string AssignedUser { get; set; }
    }

    public class UpdateServiceRequestInput
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int? Priority { get; set; }
        public string Classification { get; set; }
        public string Urgency { get; set; }
        public string Impact { get; set; }
        public string Source { get; set; }
        public string SupportGroup { get; set; }
        public string Status { get; set; }

        [JsonProperty("RequestedWorkItem")]
        public string AffectedUser { get; set; }

        [JsonProperty("AssignedWorkItem")]
        public string AssignedUser { get; set; }
    }

    public class CreateChangeRequestInput
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Priority { get; set; }
        public string Area { get; set; }
        public string Impact { get; set; }
        public string Risk { get; set; }
        public string Status { get; set; }

        [JsonProperty("AssignedWorkItem")]
        public string AssignedUser { get; set; }
    }

    public class UpdateChangeRequestInput
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Priority { get; set; }
        public string Area { get; set; }
        public string Impact { get; set; }
        public string Risk { get; set; }
        public string Status { get; set; }

        [JsonProperty("AssignedWorkItem")]
        public string AssignedUser { get; set; }
    }

    public class CreateProblemInput
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Priority { get; set; }
        public string Source { get; set; }
        public string Category { get; set; }
        public string Impact { get; set; }
        public string Urgency { get; set; }
        public string Status { get; set; }

        [JsonProperty("AssignedWorkItem")]
        public string AssignedUser { get; set; }
    }

    public class UpdateProblemInput
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Priority { get; set; }
        public string Source { get; set; }
        public string Category { get; set; }
        public string Impact { get; set; }
        public string Urgency { get; set; }
        public string Status { get; set; }

        [JsonProperty("AssignedWorkItem")]
        public string AssignedUser { get; set; }
    }

    public class CreateReleaseRecordInput
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public string Category { get; set; }
        public string Impact { get; set; }
        public string Risk { get; set; }
        public string Priority { get; set; }
        public string Status { get; set; }

        [JsonProperty("AssignedWorkItem")]
        public string AssignedUser { get; set; }
    }

    public class UpdateReleaseRecordInput
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public string Category { get; set; }
        public string Impact { get; set; }
        public string Risk { get; set; }
        public string Priority { get; set; }
        public string Status { get; set; }

        [JsonProperty("AssignedWorkItem")]
        public string AssignedUser { get; set; }
    }

    public class WorkItemActionLogResponse
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public JToken AppliesToTroubleTicket { get; set; }
        public JToken AppliesToWorkItem { get; set; }
    }

    public class AddCommentLogInput
    {
        public string Description { get; set; }
        public string EnteredBy { get; set; }
        public bool? IsPrivate { get; set; }
        public AddCommentLogInputActionTypeType? ActionType { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum AddCommentLogInputActionTypeType
    {
        [EnumMember(Value = "Analyst Comment")]
        AnalystComment,
        [EnumMember(Value = "End User Comment")]
        EndUserComment
    }

    public class WebhookSettings
    {
        [JsonProperty("Guid")]
        public string Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public string ActionType { get; set; }
        public string SaveType { get; set; }
        public bool Enable { get; set; }
        public string WorkItemClassType { get; set; }
        public int WebHookClass { get; set; }
        public bool IsDeleted { get; set; }
        public int ModifiedById { get; set; }
        public string ModifiedDate { get; set; }
        public int CreatedById { get; set; }
        public string CreatedDate { get; set; }
    }

    public class CreateWebhookInput
    {
        [JsonProperty("webhookSettings", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateWebhookInputWebhookSettingsType WebhookSettings { get; set; }
    }

    public class CreateWebhookInputWebhookSettingsType
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Url { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateWebhookInputWebhookSettingsTypeWorkItemClassTypeType WorkItemClassType { get; set; } = CreateWebhookInputWebhookSettingsTypeWorkItemClassTypeType.Incident;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateWebhookInputWebhookSettingsTypeWorkItemClassTypeType
    {
        Incident,
        [EnumMember(Value = "Service Request")]
        ServiceRequest,
        [EnumMember(Value = "Change Request")]
        ChangeRequest,
        Problem,
        [EnumMember(Value = "Release Record")]
        ReleaseRecord
    }

    public class CreateActionLogWebhookInput
    {
        [JsonProperty("webhookSettings", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateActionLogWebhookInputWebhookSettingsType WebhookSettings { get; set; }
    }

    public class CreateActionLogWebhookInputWebhookSettingsType
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Url { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateActionLogWebhookInputWebhookSettingsTypeWorkItemClassTypeType WorkItemClassType { get; set; } = CreateActionLogWebhookInputWebhookSettingsTypeWorkItemClassTypeType.AnalystComment;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateActionLogWebhookInputWebhookSettingsTypeWorkItemClassTypeType
    {
        [EnumMember(Value = "Analyst Comment")]
        AnalystComment,
        [EnumMember(Value = "EndUser Comment")]
        EndUserComment
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Ciresonservicemanage;

    public partial class WorkflowManagedActions
    {
        public CiresonservicemanageActions Ciresonservicemanage(string connectionId) => new CiresonservicemanageActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public CiresonservicemanageTriggers Ciresonservicemanage(string connectionId) => new CiresonservicemanageTriggers(connectionId);
    }
}