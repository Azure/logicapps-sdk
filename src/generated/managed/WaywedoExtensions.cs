//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Waywedo
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class WaywedoActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "waywedo")]
        public IBodyWorkflowAction<ChecklistComment, ApiConnectionActionConfiguration> CommentAdd(Expression<Func<CommentAddInput>> createCommentCommand)
        {
            var __workflow_createCommentCommand = WorkflowExpression.Compile(createCommentCommand, nameof(createCommentCommand), required: true);
            return new DeferredBodyAction<ChecklistComment, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/ChecklistInstanceComments";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_createCommentCommand);
                return new ApiConnectionAction<ChecklistComment>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "waywedo")]
        public IBodyWorkflowAction<ChecklistInstance, ApiConnectionActionConfiguration> ChecklistInstances(Expression<Func<ChecklistInstancesPostInput>> createInstanceCommand)
        {
            var __workflow_createInstanceCommand = WorkflowExpression.Compile(createInstanceCommand, nameof(createInstanceCommand), required: true);
            return new DeferredBodyAction<ChecklistInstance, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/ChecklistInstances";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_createInstanceCommand);
                return new ApiConnectionAction<ChecklistInstance>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "waywedo")]
        public IBodyWorkflowAction<ChecklistInstance, ApiConnectionActionConfiguration> ChecklistInstancesGet(Expression<Func<string>> instanceId)
        {
            var __workflow_instanceId = WorkflowExpression.Compile(instanceId, nameof(instanceId), required: true);
            return new DeferredBodyAction<ChecklistInstance, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/ChecklistInstances/{0}", __workflow_instanceId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ChecklistInstance>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "waywedo")]
        public IBodyWorkflowAction<ChecklistInstancesActivityResponseItem[], ApiConnectionActionConfiguration> ChecklistInstancesActivity(Expression<Func<string>> instanceId)
        {
            var __workflow_instanceId = WorkflowExpression.Compile(instanceId, nameof(instanceId), required: true);
            return new DeferredBodyAction<ChecklistInstancesActivityResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/ChecklistInstances/{0}/Activity", __workflow_instanceId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ChecklistInstancesActivityResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "waywedo")]
        public IBodyWorkflowAction<ChecklistStep[], ApiConnectionActionConfiguration> FindSteps(Expression<Func<string>> instanceId, Expression<Func<string>> query = null)
        {
            var __workflow_instanceId = WorkflowExpression.Compile(instanceId, nameof(instanceId), required: true);
            var __workflow_query = WorkflowExpression.Compile(query, nameof(query), required: false);
            return new DeferredBodyAction<ChecklistStep[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/ChecklistInstances/{0}/Steps", __workflow_instanceId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_query != null)
                    callPayload.Queries["query"] = ExpressionConverter.Convert(__workflow_query);
                return new ApiConnectionAction<ChecklistStep[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "waywedo")]
        public IBodyWorkflowAction<ChecklistStep, ApiConnectionActionConfiguration> ChecklistStepsGet(Expression<Func<string>> instanceId, Expression<Func<string>> stepId)
        {
            var __workflow_instanceId = WorkflowExpression.Compile(instanceId, nameof(instanceId), required: true);
            var __workflow_stepId = WorkflowExpression.Compile(stepId, nameof(stepId), required: true);
            return new DeferredBodyAction<ChecklistStep, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/ChecklistInstances/{0}/Steps/{1}", __workflow_instanceId.WithUrlEncoding(1), __workflow_stepId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ChecklistStep>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "waywedo")]
        public IWorkflowAction<ApiConnectionActionConfiguration> ChecklistStepsComplete(Expression<Func<string>> instanceId, Expression<Func<string>> stepId, Expression<Func<ChecklistStepsCompleteInput>> completeStepCommand = null)
        {
            var __workflow_instanceId = WorkflowExpression.Compile(instanceId, nameof(instanceId), required: true);
            var __workflow_stepId = WorkflowExpression.Compile(stepId, nameof(stepId), required: true);
            var __workflow_completeStepCommand = WorkflowExpression.Compile(completeStepCommand, nameof(completeStepCommand), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/ChecklistInstances/{0}/Steps/{1}/Complete", __workflow_instanceId.WithUrlEncoding(1), __workflow_stepId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_completeStepCommand != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_completeStepCommand);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "waywedo")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> CollaboratorsAdd(Expression<Func<CollaboratorsAddInput>> addCollaboratorsRequest)
        {
            var __workflow_addCollaboratorsRequest = WorkflowExpression.Compile(addCollaboratorsRequest, nameof(addCollaboratorsRequest), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/Collaborators";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_addCollaboratorsRequest);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "waywedo")]
        public IBodyWorkflowAction<Procedure[], ApiConnectionActionConfiguration> FindChecklist(Expression<Func<string>> query = null)
        {
            var __workflow_query = WorkflowExpression.Compile(query, nameof(query), required: false);
            return new DeferredBodyAction<Procedure[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/Procedures";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_query != null)
                    callPayload.Queries["query"] = ExpressionConverter.Convert(__workflow_query);
                callPayload.Queries["type"] = Convert.ToString(2);
                return new ApiConnectionAction<Procedure[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "waywedo")]
        public IBodyWorkflowAction<Procedure, ApiConnectionActionConfiguration> ProceduresGet(Expression<Func<int>> procedureId)
        {
            var __workflow_procedureId = WorkflowExpression.Compile(procedureId, nameof(procedureId), required: true);
            return new DeferredBodyAction<Procedure, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/Procedures/{0}", __workflow_procedureId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Procedure>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "waywedo")]
        public IBodyWorkflowAction<ChecklistInstance[], ApiConnectionActionConfiguration> FindChecklistInstances(Expression<Func<int>> procedureId, Expression<Func<string>> query = null)
        {
            var __workflow_procedureId = WorkflowExpression.Compile(procedureId, nameof(procedureId), required: true);
            var __workflow_query = WorkflowExpression.Compile(query, nameof(query), required: false);
            return new DeferredBodyAction<ChecklistInstance[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/Procedures/{0}/ChecklistInstances", __workflow_procedureId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_query != null)
                    callPayload.Queries["query"] = ExpressionConverter.Convert(__workflow_query);
                return new ApiConnectionAction<ChecklistInstance[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "waywedo")]
        public IBodyWorkflowAction<User[], ApiConnectionActionConfiguration> FindUser(Expression<Func<string>> query = null)
        {
            var __workflow_query = WorkflowExpression.Compile(query, nameof(query), required: false);
            return new DeferredBodyAction<User[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/Users";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_query != null)
                    callPayload.Queries["query"] = ExpressionConverter.Convert(__workflow_query);
                return new ApiConnectionAction<User[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "waywedo")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> Users(Expression<Func<UsersPostInput>> createUserCommand)
        {
            var __workflow_createUserCommand = WorkflowExpression.Compile(createUserCommand, nameof(createUserCommand), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/Users";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_createUserCommand);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }
    }

    public class WaywedoTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<WebhookRegistered, ApiConnectionTriggerConfiguration> ChecklistCreateWebHook(Expression<Func<ChecklistCreateWebHookInput>> webhookRegistration, FlowRecurrence recurrence = null)
        {
            var __workflow_webhookRegistration = WorkflowExpression.Compile(webhookRegistration, nameof(webhookRegistration), required: true);
            return new DeferredBodyTrigger<WebhookRegistered, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/v1/Webhook/events/checklist_start";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_webhookRegistration);
                return new ApiConnectionTrigger<WebhookRegistered>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<WebhookRegistered, ApiConnectionTriggerConfiguration> NewCommentWebHook(Expression<Func<NewCommentWebHookInput>> webhookRegistration, FlowRecurrence recurrence = null)
        {
            var __workflow_webhookRegistration = WorkflowExpression.Compile(webhookRegistration, nameof(webhookRegistration), required: true);
            return new DeferredBodyTrigger<WebhookRegistered, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/v1/Webhook/events/new_comment";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_webhookRegistration);
                return new ApiConnectionTrigger<WebhookRegistered>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<WebhookRegistered, ApiConnectionTriggerConfiguration> FinishChecklistWebHook(Expression<Func<FinishChecklistWebHookInput>> webhookRegistration, FlowRecurrence recurrence = null)
        {
            var __workflow_webhookRegistration = WorkflowExpression.Compile(webhookRegistration, nameof(webhookRegistration), required: true);
            return new DeferredBodyTrigger<WebhookRegistered, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/v1/Webhook/events/checklist_finish";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_webhookRegistration);
                return new ApiConnectionTrigger<WebhookRegistered>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<WebhookRegistered, ApiConnectionTriggerConfiguration> InviteSupervisorWebHook(Expression<Func<InviteSupervisorWebHookInput>> webhookRegistration, FlowRecurrence recurrence = null)
        {
            var __workflow_webhookRegistration = WorkflowExpression.Compile(webhookRegistration, nameof(webhookRegistration), required: true);
            return new DeferredBodyTrigger<WebhookRegistered, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/v1/Webhook/events/supervisor_invite";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_webhookRegistration);
                return new ApiConnectionTrigger<WebhookRegistered>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<WebhookRegistered, ApiConnectionTriggerConfiguration> GenerateAcceptancePDFWebHook(Expression<Func<GenerateAcceptancePDFWebHookInput>> webhookRegistration, FlowRecurrence recurrence = null)
        {
            var __workflow_webhookRegistration = WorkflowExpression.Compile(webhookRegistration, nameof(webhookRegistration), required: true);
            return new DeferredBodyTrigger<WebhookRegistered, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/v1/Webhook/events/generate_acceptance_pdf";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_webhookRegistration);
                return new ApiConnectionTrigger<WebhookRegistered>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<WebhookRegistered, ApiConnectionTriggerConfiguration> ChecklistStepCompletedWebHook(Expression<Func<ChecklistStepCompletedWebHookInput>> webhookRegistration, FlowRecurrence recurrence = null)
        {
            var __workflow_webhookRegistration = WorkflowExpression.Compile(webhookRegistration, nameof(webhookRegistration), required: true);
            return new DeferredBodyTrigger<WebhookRegistered, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/v1/Webhook/events/checklist_step_completed";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_webhookRegistration);
                return new ApiConnectionTrigger<WebhookRegistered>(callPayload, recurrence: recurrence);
            });
        }
    }

    public class ChecklistComment
    {
        [JsonProperty("id")]
        public string CommentId { get; set; }

        [JsonProperty("type")]
        public ChecklistCommentCommentTypeType CommentType { get; set; }

        [JsonProperty("procedureId")]
        public int ProcedureId { get; set; }

        [JsonProperty("procedureTitle")]
        public string ProcedureTitle { get; set; }

        [JsonProperty("instanceId")]
        public string InstanceId { get; set; }

        [JsonProperty("stepId")]
        public string StepId { get; set; }

        [JsonProperty("instanceTitle")]
        public string InstanceTitle { get; set; }

        [JsonProperty("comment")]
        public string CommentText { get; set; }

        [JsonProperty("created")]
        public string CommentDate { get; set; }

        [JsonProperty("createdBy")]
        public string CommentUser { get; set; }

        [JsonProperty("imageUrl")]
        public string CommentAttachmentURL { get; set; }
    }

    public enum ChecklistCommentCommentTypeType
    {
        _1 = 1,
        _2 = 2
    }

    public class CommentAddInput
    {
        [JsonProperty("instanceId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ChecklistInstanceId { get; set; }

        [JsonProperty("stepId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string StepId { get; set; }

        [JsonProperty("userId")]
        public int? UserId { get; set; }

        [JsonProperty("message", DefaultValueHandling = DefaultValueHandling.Include)]
        public string CommentText { get; set; }

        [JsonProperty("bot", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string BotName { get; set; } = "Microsoft Power Automate";
    }

    public class ChecklistInstance
    {
        [JsonProperty("id")]
        public string InstanceId { get; set; }

        [JsonProperty("procedureId")]
        public int ProcedureId { get; set; }

        [JsonProperty("title")]
        public string InstanceTitle { get; set; }

        [JsonProperty("url")]
        public string InstanceURL { get; set; }

        [JsonProperty("created")]
        public string InstanceCreatedDate { get; set; }

        [JsonProperty("createdBy")]
        public string InstanceUser { get; set; }

        [JsonProperty("finished")]
        public string InstanceFinishDate { get; set; }

        [JsonProperty("earliestDue")]
        public string InstanceEarliestDueDate { get; set; }

        [JsonProperty("latestDue")]
        public string InstanceLatestDueDate { get; set; }
    }

    public class ChecklistInstancesPostInput
    {
        [JsonProperty("procedureId", DefaultValueHandling = DefaultValueHandling.Include)]
        public int ProcedureId { get; set; }

        [JsonProperty("title", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Title { get; set; }

        [JsonProperty("userId")]
        public int? UserId { get; set; }

        [JsonProperty("companyRoleId")]
        public int? CompanyRoleId { get; set; }

        [JsonProperty("bot", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string BotName { get; set; } = "Microsoft Power Automate";
    }

    public class ChecklistInstancesActivityResponseItem
    {
        [JsonProperty("occurred")]
        public string Occurred { get; set; }

        [JsonProperty("title")]
        public string Description { get; set; }
    }

    public class ChecklistStep
    {
        [JsonProperty("id")]
        public string StepId { get; set; }

        [JsonProperty("title")]
        public string StepTitle { get; set; }

        [JsonProperty("ordinal")]
        public int StepNumber { get; set; }
    }

    public class ChecklistStepsCompleteInput
    {
        [JsonProperty("userId", DefaultValueHandling = DefaultValueHandling.Include)]
        public int UserId { get; set; }

        [JsonProperty("bot", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string BotName { get; set; } = "Microsoft Power Automate";
    }

    public class CollaboratorsAddInput
    {
        [JsonProperty("checklistInstanceId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ChecklistInstanceId { get; set; }

        [JsonProperty("userIds")]
        public int[] UserIds { get; set; }

        [JsonProperty("companyRoleIds")]
        public int[] CompanyRoleIds { get; set; }
    }

    public class Procedure
    {
        [JsonProperty("id")]
        public int ProcedureId { get; set; }

        [JsonProperty("title")]
        public string ProcedureTitle { get; set; }

        [JsonProperty("status")]
        public string ProcedureStatus { get; set; }

        [JsonProperty("summary")]
        public string ProcedureSummary { get; set; }

        [JsonProperty("createdBy")]
        public string CreatedBy { get; set; }

        [JsonProperty("url")]
        public string ProcedureURL { get; set; }

        [JsonProperty("restricted")]
        public bool Restricted { get; set; }

        [JsonProperty("type")]
        public ProcedureProcedureTypeType ProcedureType { get; set; }
    }

    public enum ProcedureProcedureTypeType
    {
        _1 = 1,
        _2 = 2
    }

    public class User
    {
        [JsonProperty("id")]
        public int UserId { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }
    }

    public class UsersPostInput
    {
        [JsonProperty("firstName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FirstName { get; set; }

        [JsonProperty("lastName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string LastName { get; set; }

        [JsonProperty("email", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Email { get; set; }

        [JsonProperty("securityRole", DefaultValueHandling = DefaultValueHandling.Include)]
        public int SecurityRole { get; set; }

        [JsonProperty("companyRoles")]
        public int[] CompanyRoles { get; set; }

        [JsonProperty("timeZoneId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string TimeZone { get; set; }
    }

    public class WebhookRegistered
    {
        [JsonProperty("id")]
        public int WebhookId { get; set; }

        [JsonProperty("callbackurl")]
        public string CallbackURL { get; set; }

        [JsonProperty("created")]
        public string CreatedDate { get; set; }

        [JsonProperty("webHookEvent")]
        public string WebhookEvent { get; set; }
    }

    public class ChecklistCreateWebHookInput
    {
        [JsonProperty("callbackUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string CallbackURL { get; set; } = "#{listCallbackUrl()}";
    }

    public class NewCommentWebHookInput
    {
        [JsonProperty("callbackUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string CallbackURL { get; set; } = "#{listCallbackUrl()}";
    }

    public class FinishChecklistWebHookInput
    {
        [JsonProperty("callbackUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string CallbackURL { get; set; } = "#{listCallbackUrl()}";
    }

    public class InviteSupervisorWebHookInput
    {
        [JsonProperty("callbackUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string CallbackURL { get; set; } = "#{listCallbackUrl()}";
    }

    public class GenerateAcceptancePDFWebHookInput
    {
        [JsonProperty("callbackUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string CallbackURL { get; set; } = "#{listCallbackUrl()}";
    }

    public class ChecklistStepCompletedWebHookInput
    {
        [JsonProperty("callbackUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string CallbackURL { get; set; } = "#{listCallbackUrl()}";
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Waywedo;

    public partial class WorkflowManagedActions
    {
        public WaywedoActions Waywedo(string connectionId) => new WaywedoActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public WaywedoTriggers Waywedo(string connectionId) => new WaywedoTriggers(connectionId);
    }
}