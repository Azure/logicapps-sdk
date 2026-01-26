//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Waywedo
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class WaywedoActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "waywedo")]
        public IBodyWorkflowAction<ChecklistComment> CommentAdd(Expression<Func<string>> createCommentCommandchecklistInstanceID, Expression<Func<string>> createCommentCommandstepID, Expression<Func<string>> createCommentCommandcommentText, Expression<Func<int>> createCommentCommanduserID = null)
        {
            var apiCallPath = "/v1/ChecklistInstanceComments";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var createCommentCommand = new JObject();
            var createCommentCommandpropCount = 0;
            createCommentCommandpropCount++;
            createCommentCommand["instanceId"] = ExpressionConverter.ConvertO(createCommentCommandchecklistInstanceID);
            createCommentCommandpropCount++;
            createCommentCommand["stepId"] = ExpressionConverter.ConvertO(createCommentCommandstepID);
            if (createCommentCommanduserID != null)
            {
                createCommentCommand["userId"] = ExpressionConverter.ConvertO(createCommentCommanduserID);
                createCommentCommandpropCount++;
            }

            createCommentCommandpropCount++;
            createCommentCommand["message"] = ExpressionConverter.ConvertO(createCommentCommandcommentText);
            createCommentCommand["bot"] = "Microsoft Power Automate";
            createCommentCommandpropCount++;
            if (createCommentCommandpropCount > 0)
            {
                callPayload.Body = createCommentCommand;
            }

            return new ApiConnectionAction<ChecklistComment>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "waywedo")]
        public IBodyWorkflowAction<ChecklistInstance> ChecklistInstancesPost(Expression<Func<int>> createInstanceCommandprocedureID, Expression<Func<string>> createInstanceCommandtitle, Expression<Func<int>> createInstanceCommanduserID = null, Expression<Func<int>> createInstanceCommandcompanyRoleID = null)
        {
            var apiCallPath = "/v1/ChecklistInstances";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var createInstanceCommand = new JObject();
            var createInstanceCommandpropCount = 0;
            createInstanceCommandpropCount++;
            createInstanceCommand["procedureId"] = ExpressionConverter.ConvertO(createInstanceCommandprocedureID);
            createInstanceCommandpropCount++;
            createInstanceCommand["title"] = ExpressionConverter.ConvertO(createInstanceCommandtitle);
            if (createInstanceCommanduserID != null)
            {
                createInstanceCommand["userId"] = ExpressionConverter.ConvertO(createInstanceCommanduserID);
                createInstanceCommandpropCount++;
            }

            if (createInstanceCommandcompanyRoleID != null)
            {
                createInstanceCommand["companyRoleId"] = ExpressionConverter.ConvertO(createInstanceCommandcompanyRoleID);
                createInstanceCommandpropCount++;
            }

            createInstanceCommand["bot"] = "Microsoft Power Automate";
            createInstanceCommandpropCount++;
            if (createInstanceCommandpropCount > 0)
            {
                callPayload.Body = createInstanceCommand;
            }

            return new ApiConnectionAction<ChecklistInstance>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "waywedo")]
        public IBodyWorkflowAction<ChecklistInstance> ChecklistInstancesGet(Expression<Func<string>> instanceId)
        {
            var apiCallPath = String.Format("/v1/ChecklistInstances/{0}", ExpressionConverter.ConvertWithUrlEncoding(instanceId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ChecklistInstance>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "waywedo")]
        public IBodyWorkflowAction<ChecklistInstancesActivityResponseItem[]> ChecklistInstancesActivity(Expression<Func<string>> instanceId)
        {
            var apiCallPath = String.Format("/v1/ChecklistInstances/{0}/Activity", ExpressionConverter.ConvertWithUrlEncoding(instanceId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ChecklistInstancesActivityResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "waywedo")]
        public IBodyWorkflowAction<ChecklistStep[]> FindSteps(Expression<Func<string>> instanceId, Expression<Func<string>> query = null)
        {
            var apiCallPath = String.Format("/v1/ChecklistInstances/{0}/Steps", ExpressionConverter.ConvertWithUrlEncoding(instanceId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (query != null)
                callPayload.Queries["query"] = ExpressionConverter.Convert(query);
            return new ApiConnectionAction<ChecklistStep[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "waywedo")]
        public IBodyWorkflowAction<ChecklistStep> ChecklistStepsGet(Expression<Func<string>> instanceId, Expression<Func<string>> stepId)
        {
            var apiCallPath = String.Format("/v1/ChecklistInstances/{0}/Steps/{1}", ExpressionConverter.ConvertWithUrlEncoding(instanceId, 1), ExpressionConverter.ConvertWithUrlEncoding(stepId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ChecklistStep>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "waywedo")]
        public IWorkflowAction ChecklistStepsComplete(Expression<Func<string>> instanceId, Expression<Func<string>> stepId, Expression<Func<int>> completeStepCommanduserID)
        {
            var apiCallPath = String.Format("/v1/ChecklistInstances/{0}/Steps/{1}/Complete", ExpressionConverter.ConvertWithUrlEncoding(instanceId, 1), ExpressionConverter.ConvertWithUrlEncoding(stepId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var completeStepCommand = new JObject();
            var completeStepCommandpropCount = 0;
            completeStepCommandpropCount++;
            completeStepCommand["userId"] = ExpressionConverter.ConvertO(completeStepCommanduserID);
            completeStepCommand["bot"] = "Microsoft Power Automate";
            completeStepCommandpropCount++;
            if (completeStepCommandpropCount > 0)
            {
                callPayload.Body = completeStepCommand;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "waywedo")]
        public IBodyWorkflowAction<JToken> CollaboratorsAdd(Expression<Func<string>> addCollaboratorsRequestchecklistInstanceID, Expression<Func<int[]>> addCollaboratorsRequestuserIds = null, Expression<Func<int[]>> addCollaboratorsRequestcompanyRoleIds = null)
        {
            var apiCallPath = "/v1/Collaborators";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var addCollaboratorsRequest = new JObject();
            var addCollaboratorsRequestpropCount = 0;
            addCollaboratorsRequestpropCount++;
            addCollaboratorsRequest["checklistInstanceId"] = ExpressionConverter.ConvertO(addCollaboratorsRequestchecklistInstanceID);
            if (addCollaboratorsRequestuserIds != null)
            {
                addCollaboratorsRequest["userIds"] = ExpressionConverter.ConvertO(addCollaboratorsRequestuserIds);
                addCollaboratorsRequestpropCount++;
            }

            if (addCollaboratorsRequestcompanyRoleIds != null)
            {
                addCollaboratorsRequest["companyRoleIds"] = ExpressionConverter.ConvertO(addCollaboratorsRequestcompanyRoleIds);
                addCollaboratorsRequestpropCount++;
            }

            if (addCollaboratorsRequestpropCount > 0)
            {
                callPayload.Body = addCollaboratorsRequest;
            }

            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "waywedo")]
        public IBodyWorkflowAction<Procedure[]> FindChecklist(Expression<Func<string>> query = null)
        {
            var apiCallPath = "/v1/Procedures";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (query != null)
                callPayload.Queries["query"] = ExpressionConverter.Convert(query);
            callPayload.Queries["type"] = Convert.ToString(2);
            return new ApiConnectionAction<Procedure[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "waywedo")]
        public IBodyWorkflowAction<Procedure> ProceduresGet(Expression<Func<int>> procedureId)
        {
            var apiCallPath = String.Format("/v1/Procedures/{0}", ExpressionConverter.ConvertWithUrlEncoding(procedureId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<Procedure>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "waywedo")]
        public IBodyWorkflowAction<ChecklistInstance[]> FindChecklistInstances(Expression<Func<int>> procedureId, Expression<Func<string>> query = null)
        {
            var apiCallPath = String.Format("/v1/Procedures/{0}/ChecklistInstances", ExpressionConverter.ConvertWithUrlEncoding(procedureId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (query != null)
                callPayload.Queries["query"] = ExpressionConverter.Convert(query);
            return new ApiConnectionAction<ChecklistInstance[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "waywedo")]
        public IBodyWorkflowAction<User[]> FindUser(Expression<Func<string>> query = null)
        {
            var apiCallPath = "/v1/Users";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (query != null)
                callPayload.Queries["query"] = ExpressionConverter.Convert(query);
            return new ApiConnectionAction<User[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "waywedo")]
        public IBodyWorkflowAction<JToken> UsersPost(Expression<Func<string>> createUserCommandfirstName, Expression<Func<string>> createUserCommandlastName, Expression<Func<string>> createUserCommandemail, Expression<Func<int>> createUserCommandsecurityRole, Expression<Func<string>> createUserCommandtimeZone, Expression<Func<int[]>> createUserCommandcompanyRoles = null)
        {
            var apiCallPath = "/v1/Users";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var createUserCommand = new JObject();
            var createUserCommandpropCount = 0;
            createUserCommandpropCount++;
            createUserCommand["firstName"] = ExpressionConverter.ConvertO(createUserCommandfirstName);
            createUserCommandpropCount++;
            createUserCommand["lastName"] = ExpressionConverter.ConvertO(createUserCommandlastName);
            createUserCommandpropCount++;
            createUserCommand["email"] = ExpressionConverter.ConvertO(createUserCommandemail);
            createUserCommandpropCount++;
            createUserCommand["securityRole"] = ExpressionConverter.ConvertO(createUserCommandsecurityRole);
            if (createUserCommandcompanyRoles != null)
            {
                createUserCommand["companyRoles"] = ExpressionConverter.ConvertO(createUserCommandcompanyRoles);
                createUserCommandpropCount++;
            }

            createUserCommandpropCount++;
            createUserCommand["timeZoneId"] = ExpressionConverter.ConvertO(createUserCommandtimeZone);
            if (createUserCommandpropCount > 0)
            {
                callPayload.Body = createUserCommand;
            }

            return new ApiConnectionAction<JToken>(callPayload);
        }
    }

    public class WaywedoTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<WebhookRegistered> ChecklistCreateWebHook(string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/v1/Webhook/events/checklist_start";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var webhookRegistration = new JObject();
            var webhookRegistrationpropCount = 0;
            webhookRegistration["callbackUrl"] = "@listCallbackUrl()";
            webhookRegistrationpropCount++;
            if (webhookRegistrationpropCount > 0)
            {
                callPayload.Body = webhookRegistration;
            }

            return new ApiConnectionTrigger<WebhookRegistered>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<WebhookRegistered> NewCommentWebHook(string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/v1/Webhook/events/new_comment";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var webhookRegistration = new JObject();
            var webhookRegistrationpropCount = 0;
            webhookRegistration["callbackUrl"] = "@listCallbackUrl()";
            webhookRegistrationpropCount++;
            if (webhookRegistrationpropCount > 0)
            {
                callPayload.Body = webhookRegistration;
            }

            return new ApiConnectionTrigger<WebhookRegistered>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<WebhookRegistered> FinishChecklistWebHook(string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/v1/Webhook/events/checklist_finish";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var webhookRegistration = new JObject();
            var webhookRegistrationpropCount = 0;
            webhookRegistration["callbackUrl"] = "@listCallbackUrl()";
            webhookRegistrationpropCount++;
            if (webhookRegistrationpropCount > 0)
            {
                callPayload.Body = webhookRegistration;
            }

            return new ApiConnectionTrigger<WebhookRegistered>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<WebhookRegistered> InviteSupervisorWebHook(string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/v1/Webhook/events/supervisor_invite";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var webhookRegistration = new JObject();
            var webhookRegistrationpropCount = 0;
            webhookRegistration["callbackUrl"] = "@listCallbackUrl()";
            webhookRegistrationpropCount++;
            if (webhookRegistrationpropCount > 0)
            {
                callPayload.Body = webhookRegistration;
            }

            return new ApiConnectionTrigger<WebhookRegistered>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<WebhookRegistered> GenerateAcceptancePDFWebHook(string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/v1/Webhook/events/generate_acceptance_pdf";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var webhookRegistration = new JObject();
            var webhookRegistrationpropCount = 0;
            webhookRegistration["callbackUrl"] = "@listCallbackUrl()";
            webhookRegistrationpropCount++;
            if (webhookRegistrationpropCount > 0)
            {
                callPayload.Body = webhookRegistration;
            }

            return new ApiConnectionTrigger<WebhookRegistered>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<WebhookRegistered> ChecklistStepCompletedWebHook(string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/v1/Webhook/events/checklist_step_completed";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var webhookRegistration = new JObject();
            var webhookRegistrationpropCount = 0;
            webhookRegistration["callbackUrl"] = "@listCallbackUrl()";
            webhookRegistrationpropCount++;
            if (webhookRegistrationpropCount > 0)
            {
                callPayload.Body = webhookRegistration;
            }

            return new ApiConnectionTrigger<WebhookRegistered>(callPayload, triggerName, recurrence);
        }
    }

    public class ChecklistComment
    {
        [JsonProperty("id")]
        public string CommentID { get; set; }

        [JsonProperty("type")]
        public ChecklistCommentCommentTypeType CommentType { get; set; }

        [JsonProperty("procedureId")]
        public int ProcedureID { get; set; }

        [JsonProperty("procedureTitle")]
        public string ProcedureTitle { get; set; }

        [JsonProperty("instanceId")]
        public string InstanceID { get; set; }

        [JsonProperty("stepId")]
        public string StepID { get; set; }

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
        [EnumMember(Value = "1")]
        _1,
        [EnumMember(Value = "2")]
        _2
    }

    public class ChecklistInstance
    {
        [JsonProperty("id")]
        public string InstanceID { get; set; }

        [JsonProperty("procedureId")]
        public int ProcedureID { get; set; }

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
        public string StepID { get; set; }

        [JsonProperty("title")]
        public string StepTitle { get; set; }

        [JsonProperty("ordinal")]
        public int StepNumber { get; set; }
    }

    public class Procedure
    {
        [JsonProperty("id")]
        public int ProcedureID { get; set; }

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
        [EnumMember(Value = "1")]
        _1,
        [EnumMember(Value = "2")]
        _2
    }

    public class User
    {
        [JsonProperty("id")]
        public int UserID { get; set; }

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
        public int WebhookID { get; set; }

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