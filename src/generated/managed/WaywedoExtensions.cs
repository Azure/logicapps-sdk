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
        public IBodyWorkflowAction<ChecklistComment, ApiConnectionActionConfiguration> CommentAdd(Expression<Func<string>> createCommentCommandchecklistInstanceId, Expression<Func<string>> createCommentCommandstepId, Expression<Func<string>> createCommentCommandcommentText, Expression<Func<int>> createCommentCommanduserId = null)
        {
            var __workflow_createCommentCommandchecklistInstanceId = WorkflowExpression.Compile(createCommentCommandchecklistInstanceId, nameof(createCommentCommandchecklistInstanceId), required: true);
            var __workflow_createCommentCommandstepId = WorkflowExpression.Compile(createCommentCommandstepId, nameof(createCommentCommandstepId), required: true);
            var __workflow_createCommentCommandcommentText = WorkflowExpression.Compile(createCommentCommandcommentText, nameof(createCommentCommandcommentText), required: true);
            var __workflow_createCommentCommanduserId = WorkflowExpression.Compile(createCommentCommanduserId, nameof(createCommentCommanduserId), required: false);
            return new DeferredBodyAction<ChecklistComment, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/ChecklistInstanceComments";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var createCommentCommand = new JObject();
                var createCommentCommandpropCount = 0;
                createCommentCommandpropCount++;
                createCommentCommand["instanceId"] = ExpressionConverter.ConvertO(__workflow_createCommentCommandchecklistInstanceId);
                createCommentCommandpropCount++;
                createCommentCommand["stepId"] = ExpressionConverter.ConvertO(__workflow_createCommentCommandstepId);
                if (__workflow_createCommentCommanduserId != null)
                {
                    createCommentCommand["userId"] = ExpressionConverter.ConvertO(__workflow_createCommentCommanduserId);
                    createCommentCommandpropCount++;
                }

                createCommentCommandpropCount++;
                createCommentCommand["message"] = ExpressionConverter.ConvertO(__workflow_createCommentCommandcommentText);
                createCommentCommand["bot"] = "Microsoft Power Automate";
                createCommentCommandpropCount++;
                if (createCommentCommandpropCount > 0)
                {
                    callPayload.Body = createCommentCommand;
                }

                return new ApiConnectionAction<ChecklistComment>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "waywedo")]
        public IBodyWorkflowAction<ChecklistInstance, ApiConnectionActionConfiguration> ChecklistInstances(Expression<Func<int>> createInstanceCommandprocedureId, Expression<Func<string>> createInstanceCommandtitle, Expression<Func<int>> createInstanceCommanduserId = null, Expression<Func<int>> createInstanceCommandcompanyRoleId = null)
        {
            var __workflow_createInstanceCommandprocedureId = WorkflowExpression.Compile(createInstanceCommandprocedureId, nameof(createInstanceCommandprocedureId), required: true);
            var __workflow_createInstanceCommandtitle = WorkflowExpression.Compile(createInstanceCommandtitle, nameof(createInstanceCommandtitle), required: true);
            var __workflow_createInstanceCommanduserId = WorkflowExpression.Compile(createInstanceCommanduserId, nameof(createInstanceCommanduserId), required: false);
            var __workflow_createInstanceCommandcompanyRoleId = WorkflowExpression.Compile(createInstanceCommandcompanyRoleId, nameof(createInstanceCommandcompanyRoleId), required: false);
            return new DeferredBodyAction<ChecklistInstance, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/ChecklistInstances";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var createInstanceCommand = new JObject();
                var createInstanceCommandpropCount = 0;
                createInstanceCommandpropCount++;
                createInstanceCommand["procedureId"] = ExpressionConverter.ConvertO(__workflow_createInstanceCommandprocedureId);
                createInstanceCommandpropCount++;
                createInstanceCommand["title"] = ExpressionConverter.ConvertO(__workflow_createInstanceCommandtitle);
                if (__workflow_createInstanceCommanduserId != null)
                {
                    createInstanceCommand["userId"] = ExpressionConverter.ConvertO(__workflow_createInstanceCommanduserId);
                    createInstanceCommandpropCount++;
                }

                if (__workflow_createInstanceCommandcompanyRoleId != null)
                {
                    createInstanceCommand["companyRoleId"] = ExpressionConverter.ConvertO(__workflow_createInstanceCommandcompanyRoleId);
                    createInstanceCommandpropCount++;
                }

                createInstanceCommand["bot"] = "Microsoft Power Automate";
                createInstanceCommandpropCount++;
                if (createInstanceCommandpropCount > 0)
                {
                    callPayload.Body = createInstanceCommand;
                }

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
        public IWorkflowAction<ApiConnectionActionConfiguration> ChecklistStepsComplete(Expression<Func<string>> instanceId, Expression<Func<string>> stepId, Expression<Func<int>> completeStepCommanduserId)
        {
            var __workflow_instanceId = WorkflowExpression.Compile(instanceId, nameof(instanceId), required: true);
            var __workflow_stepId = WorkflowExpression.Compile(stepId, nameof(stepId), required: true);
            var __workflow_completeStepCommanduserId = WorkflowExpression.Compile(completeStepCommanduserId, nameof(completeStepCommanduserId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/ChecklistInstances/{0}/Steps/{1}/Complete", __workflow_instanceId.WithUrlEncoding(1), __workflow_stepId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var completeStepCommand = new JObject();
                var completeStepCommandpropCount = 0;
                completeStepCommandpropCount++;
                completeStepCommand["userId"] = ExpressionConverter.ConvertO(__workflow_completeStepCommanduserId);
                completeStepCommand["bot"] = "Microsoft Power Automate";
                completeStepCommandpropCount++;
                if (completeStepCommandpropCount > 0)
                {
                    callPayload.Body = completeStepCommand;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "waywedo")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> CollaboratorsAdd(Expression<Func<string>> addCollaboratorsRequestchecklistInstanceId, Expression<Func<int[]>> addCollaboratorsRequestuserIds = null, Expression<Func<int[]>> addCollaboratorsRequestcompanyRoleIds = null)
        {
            var __workflow_addCollaboratorsRequestchecklistInstanceId = WorkflowExpression.Compile(addCollaboratorsRequestchecklistInstanceId, nameof(addCollaboratorsRequestchecklistInstanceId), required: true);
            var __workflow_addCollaboratorsRequestuserIds = WorkflowExpression.Compile(addCollaboratorsRequestuserIds, nameof(addCollaboratorsRequestuserIds), required: false);
            var __workflow_addCollaboratorsRequestcompanyRoleIds = WorkflowExpression.Compile(addCollaboratorsRequestcompanyRoleIds, nameof(addCollaboratorsRequestcompanyRoleIds), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/Collaborators";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var addCollaboratorsRequest = new JObject();
                var addCollaboratorsRequestpropCount = 0;
                addCollaboratorsRequestpropCount++;
                addCollaboratorsRequest["checklistInstanceId"] = ExpressionConverter.ConvertO(__workflow_addCollaboratorsRequestchecklistInstanceId);
                if (__workflow_addCollaboratorsRequestuserIds != null)
                {
                    addCollaboratorsRequest["userIds"] = ExpressionConverter.ConvertO(__workflow_addCollaboratorsRequestuserIds);
                    addCollaboratorsRequestpropCount++;
                }

                if (__workflow_addCollaboratorsRequestcompanyRoleIds != null)
                {
                    addCollaboratorsRequest["companyRoleIds"] = ExpressionConverter.ConvertO(__workflow_addCollaboratorsRequestcompanyRoleIds);
                    addCollaboratorsRequestpropCount++;
                }

                if (addCollaboratorsRequestpropCount > 0)
                {
                    callPayload.Body = addCollaboratorsRequest;
                }

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
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> Users(Expression<Func<string>> createUserCommandfirstName, Expression<Func<string>> createUserCommandlastName, Expression<Func<string>> createUserCommandemail, Expression<Func<int>> createUserCommandsecurityRole, Expression<Func<string>> createUserCommandtimeZone, Expression<Func<int[]>> createUserCommandcompanyRoles = null)
        {
            var __workflow_createUserCommandfirstName = WorkflowExpression.Compile(createUserCommandfirstName, nameof(createUserCommandfirstName), required: true);
            var __workflow_createUserCommandlastName = WorkflowExpression.Compile(createUserCommandlastName, nameof(createUserCommandlastName), required: true);
            var __workflow_createUserCommandemail = WorkflowExpression.Compile(createUserCommandemail, nameof(createUserCommandemail), required: true);
            var __workflow_createUserCommandsecurityRole = WorkflowExpression.Compile(createUserCommandsecurityRole, nameof(createUserCommandsecurityRole), required: true);
            var __workflow_createUserCommandtimeZone = WorkflowExpression.Compile(createUserCommandtimeZone, nameof(createUserCommandtimeZone), required: true);
            var __workflow_createUserCommandcompanyRoles = WorkflowExpression.Compile(createUserCommandcompanyRoles, nameof(createUserCommandcompanyRoles), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/Users";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var createUserCommand = new JObject();
                var createUserCommandpropCount = 0;
                createUserCommandpropCount++;
                createUserCommand["firstName"] = ExpressionConverter.ConvertO(__workflow_createUserCommandfirstName);
                createUserCommandpropCount++;
                createUserCommand["lastName"] = ExpressionConverter.ConvertO(__workflow_createUserCommandlastName);
                createUserCommandpropCount++;
                createUserCommand["email"] = ExpressionConverter.ConvertO(__workflow_createUserCommandemail);
                createUserCommandpropCount++;
                createUserCommand["securityRole"] = ExpressionConverter.ConvertO(__workflow_createUserCommandsecurityRole);
                if (__workflow_createUserCommandcompanyRoles != null)
                {
                    createUserCommand["companyRoles"] = ExpressionConverter.ConvertO(__workflow_createUserCommandcompanyRoles);
                    createUserCommandpropCount++;
                }

                createUserCommandpropCount++;
                createUserCommand["timeZoneId"] = ExpressionConverter.ConvertO(__workflow_createUserCommandtimeZone);
                if (createUserCommandpropCount > 0)
                {
                    callPayload.Body = createUserCommand;
                }

                return new ApiConnectionAction<JToken>(callPayload);
            });
        }
    }

    public class WaywedoTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<WebhookRegistered, ApiConnectionTriggerConfiguration> ChecklistCreateWebHook(FlowRecurrence recurrence = null)
        {
            return new DeferredBodyTrigger<WebhookRegistered, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/v1/Webhook/events/checklist_start";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var webhookRegistration = new JObject();
                var webhookRegistrationpropCount = 0;
                webhookRegistration["callbackUrl"] = "#{listCallbackUrl()}";
                webhookRegistrationpropCount++;
                if (webhookRegistrationpropCount > 0)
                {
                    callPayload.Body = webhookRegistration;
                }

                return new ApiConnectionTrigger<WebhookRegistered>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<WebhookRegistered, ApiConnectionTriggerConfiguration> NewCommentWebHook(FlowRecurrence recurrence = null)
        {
            return new DeferredBodyTrigger<WebhookRegistered, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/v1/Webhook/events/new_comment";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var webhookRegistration = new JObject();
                var webhookRegistrationpropCount = 0;
                webhookRegistration["callbackUrl"] = "#{listCallbackUrl()}";
                webhookRegistrationpropCount++;
                if (webhookRegistrationpropCount > 0)
                {
                    callPayload.Body = webhookRegistration;
                }

                return new ApiConnectionTrigger<WebhookRegistered>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<WebhookRegistered, ApiConnectionTriggerConfiguration> FinishChecklistWebHook(FlowRecurrence recurrence = null)
        {
            return new DeferredBodyTrigger<WebhookRegistered, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/v1/Webhook/events/checklist_finish";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var webhookRegistration = new JObject();
                var webhookRegistrationpropCount = 0;
                webhookRegistration["callbackUrl"] = "#{listCallbackUrl()}";
                webhookRegistrationpropCount++;
                if (webhookRegistrationpropCount > 0)
                {
                    callPayload.Body = webhookRegistration;
                }

                return new ApiConnectionTrigger<WebhookRegistered>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<WebhookRegistered, ApiConnectionTriggerConfiguration> InviteSupervisorWebHook(FlowRecurrence recurrence = null)
        {
            return new DeferredBodyTrigger<WebhookRegistered, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/v1/Webhook/events/supervisor_invite";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var webhookRegistration = new JObject();
                var webhookRegistrationpropCount = 0;
                webhookRegistration["callbackUrl"] = "#{listCallbackUrl()}";
                webhookRegistrationpropCount++;
                if (webhookRegistrationpropCount > 0)
                {
                    callPayload.Body = webhookRegistration;
                }

                return new ApiConnectionTrigger<WebhookRegistered>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<WebhookRegistered, ApiConnectionTriggerConfiguration> GenerateAcceptancePDFWebHook(FlowRecurrence recurrence = null)
        {
            return new DeferredBodyTrigger<WebhookRegistered, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/v1/Webhook/events/generate_acceptance_pdf";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var webhookRegistration = new JObject();
                var webhookRegistrationpropCount = 0;
                webhookRegistration["callbackUrl"] = "#{listCallbackUrl()}";
                webhookRegistrationpropCount++;
                if (webhookRegistrationpropCount > 0)
                {
                    callPayload.Body = webhookRegistration;
                }

                return new ApiConnectionTrigger<WebhookRegistered>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<WebhookRegistered, ApiConnectionTriggerConfiguration> ChecklistStepCompletedWebHook(FlowRecurrence recurrence = null)
        {
            return new DeferredBodyTrigger<WebhookRegistered, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/v1/Webhook/events/checklist_step_completed";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var webhookRegistration = new JObject();
                var webhookRegistrationpropCount = 0;
                webhookRegistration["callbackUrl"] = "#{listCallbackUrl()}";
                webhookRegistrationpropCount++;
                if (webhookRegistrationpropCount > 0)
                {
                    callPayload.Body = webhookRegistration;
                }

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