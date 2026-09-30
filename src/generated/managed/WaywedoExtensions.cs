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
        public IBodyWorkflowAction<ChecklistComment> CommentAdd([WorkflowExpression] Func<string> createCommentCommandchecklistInstanceId, [WorkflowExpression] Func<string> createCommentCommandstepId, [WorkflowExpression] Func<string> createCommentCommandcommentText, [WorkflowExpression] Func<int> createCommentCommanduserId = null)
        {
            SourceExpression.Validate(createCommentCommandchecklistInstanceId, nameof(createCommentCommandchecklistInstanceId), required: true);
            SourceExpression.Validate(createCommentCommandstepId, nameof(createCommentCommandstepId), required: true);
            SourceExpression.Validate(createCommentCommandcommentText, nameof(createCommentCommandcommentText), required: true);
            SourceExpression.Validate(createCommentCommanduserId, nameof(createCommentCommanduserId), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/ChecklistInstanceComments";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var createCommentCommand = new JObject();
                var createCommentCommandpropCount = 0;
                createCommentCommandpropCount++;
                createCommentCommand["instanceId"] = SourceExpressionConverter.ConvertToken(createCommentCommandchecklistInstanceId);
                createCommentCommandpropCount++;
                createCommentCommand["stepId"] = SourceExpressionConverter.ConvertToken(createCommentCommandstepId);
                if (createCommentCommanduserId != null)
                {
                    createCommentCommand["userId"] = SourceExpressionConverter.ConvertToken(createCommentCommanduserId);
                    createCommentCommandpropCount++;
                }

                createCommentCommandpropCount++;
                createCommentCommand["message"] = SourceExpressionConverter.ConvertToken(createCommentCommandcommentText);
                createCommentCommand["bot"] = "Microsoft Power Automate";
                createCommentCommandpropCount++;
                if (createCommentCommandpropCount > 0)
                {
                    callPayload.Body = createCommentCommand;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ChecklistComment>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "waywedo")]
        public IBodyWorkflowAction<ChecklistInstance> ChecklistInstances([WorkflowExpression] Func<int> createInstanceCommandprocedureId, [WorkflowExpression] Func<string> createInstanceCommandtitle, [WorkflowExpression] Func<int> createInstanceCommanduserId = null, [WorkflowExpression] Func<int> createInstanceCommandcompanyRoleId = null)
        {
            SourceExpression.Validate(createInstanceCommandprocedureId, nameof(createInstanceCommandprocedureId), required: true);
            SourceExpression.Validate(createInstanceCommandtitle, nameof(createInstanceCommandtitle), required: true);
            SourceExpression.Validate(createInstanceCommanduserId, nameof(createInstanceCommanduserId), required: false);
            SourceExpression.Validate(createInstanceCommandcompanyRoleId, nameof(createInstanceCommandcompanyRoleId), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/ChecklistInstances";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var createInstanceCommand = new JObject();
                var createInstanceCommandpropCount = 0;
                createInstanceCommandpropCount++;
                createInstanceCommand["procedureId"] = SourceExpressionConverter.ConvertToken(createInstanceCommandprocedureId);
                createInstanceCommandpropCount++;
                createInstanceCommand["title"] = SourceExpressionConverter.ConvertToken(createInstanceCommandtitle);
                if (createInstanceCommanduserId != null)
                {
                    createInstanceCommand["userId"] = SourceExpressionConverter.ConvertToken(createInstanceCommanduserId);
                    createInstanceCommandpropCount++;
                }

                if (createInstanceCommandcompanyRoleId != null)
                {
                    createInstanceCommand["companyRoleId"] = SourceExpressionConverter.ConvertToken(createInstanceCommandcompanyRoleId);
                    createInstanceCommandpropCount++;
                }

                createInstanceCommand["bot"] = "Microsoft Power Automate";
                createInstanceCommandpropCount++;
                if (createInstanceCommandpropCount > 0)
                {
                    callPayload.Body = createInstanceCommand;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ChecklistInstance>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "waywedo")]
        public IBodyWorkflowAction<ChecklistInstance> ChecklistInstancesGet([WorkflowExpression] Func<string> instanceId)
        {
            SourceExpression.Validate(instanceId, nameof(instanceId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/ChecklistInstances/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(instanceId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ChecklistInstance>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "waywedo")]
        public IBodyWorkflowAction<ChecklistInstancesActivityResponseItem[]> ChecklistInstancesActivity([WorkflowExpression] Func<string> instanceId)
        {
            SourceExpression.Validate(instanceId, nameof(instanceId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/ChecklistInstances/{0}/Activity", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(instanceId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ChecklistInstancesActivityResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "waywedo")]
        public IBodyWorkflowAction<ChecklistStep[]> FindSteps([WorkflowExpression] Func<string> instanceId, [WorkflowExpression] Func<string> query = null)
        {
            SourceExpression.Validate(instanceId, nameof(instanceId), required: true);
            SourceExpression.Validate(query, nameof(query), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/ChecklistInstances/{0}/Steps", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(instanceId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (query != null)
                    callPayload.Queries["query"] = SourceExpressionConverter.ConvertO(query);
                return callPayload;
            }

            return new ApiConnectionAction<ChecklistStep[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "waywedo")]
        public IBodyWorkflowAction<ChecklistStep> ChecklistStepsGet([WorkflowExpression] Func<string> instanceId, [WorkflowExpression] Func<string> stepId)
        {
            SourceExpression.Validate(instanceId, nameof(instanceId), required: true);
            SourceExpression.Validate(stepId, nameof(stepId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/ChecklistInstances/{0}/Steps/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(instanceId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(stepId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ChecklistStep>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "waywedo")]
        public IWorkflowAction ChecklistStepsComplete([WorkflowExpression] Func<string> instanceId, [WorkflowExpression] Func<string> stepId, [WorkflowExpression] Func<int> completeStepCommanduserId)
        {
            SourceExpression.Validate(instanceId, nameof(instanceId), required: true);
            SourceExpression.Validate(stepId, nameof(stepId), required: true);
            SourceExpression.Validate(completeStepCommanduserId, nameof(completeStepCommanduserId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/ChecklistInstances/{0}/Steps/{1}/Complete", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(instanceId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(stepId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var completeStepCommand = new JObject();
                var completeStepCommandpropCount = 0;
                completeStepCommandpropCount++;
                completeStepCommand["userId"] = SourceExpressionConverter.ConvertToken(completeStepCommanduserId);
                completeStepCommand["bot"] = "Microsoft Power Automate";
                completeStepCommandpropCount++;
                if (completeStepCommandpropCount > 0)
                {
                    callPayload.Body = completeStepCommand;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "waywedo")]
        public IBodyWorkflowAction<JToken> CollaboratorsAdd([WorkflowExpression] Func<string> addCollaboratorsRequestchecklistInstanceId, [WorkflowExpression] Func<int[]> addCollaboratorsRequestuserIds = null, [WorkflowExpression] Func<int[]> addCollaboratorsRequestcompanyRoleIds = null)
        {
            SourceExpression.Validate(addCollaboratorsRequestchecklistInstanceId, nameof(addCollaboratorsRequestchecklistInstanceId), required: true);
            SourceExpression.Validate(addCollaboratorsRequestuserIds, nameof(addCollaboratorsRequestuserIds), required: false);
            SourceExpression.Validate(addCollaboratorsRequestcompanyRoleIds, nameof(addCollaboratorsRequestcompanyRoleIds), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/Collaborators";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var addCollaboratorsRequest = new JObject();
                var addCollaboratorsRequestpropCount = 0;
                addCollaboratorsRequestpropCount++;
                addCollaboratorsRequest["checklistInstanceId"] = SourceExpressionConverter.ConvertToken(addCollaboratorsRequestchecklistInstanceId);
                if (addCollaboratorsRequestuserIds != null)
                {
                    addCollaboratorsRequest["userIds"] = SourceExpressionConverter.ConvertToken(addCollaboratorsRequestuserIds);
                    addCollaboratorsRequestpropCount++;
                }

                if (addCollaboratorsRequestcompanyRoleIds != null)
                {
                    addCollaboratorsRequest["companyRoleIds"] = SourceExpressionConverter.ConvertToken(addCollaboratorsRequestcompanyRoleIds);
                    addCollaboratorsRequestpropCount++;
                }

                if (addCollaboratorsRequestpropCount > 0)
                {
                    callPayload.Body = addCollaboratorsRequest;
                }
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "waywedo")]
        public IBodyWorkflowAction<Procedure[]> FindChecklist([WorkflowExpression] Func<string> query = null)
        {
            SourceExpression.Validate(query, nameof(query), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/Procedures";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (query != null)
                    callPayload.Queries["query"] = SourceExpressionConverter.ConvertO(query);
                callPayload.Queries["type"] = Convert.ToString(2);
                return callPayload;
            }

            return new ApiConnectionAction<Procedure[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "waywedo")]
        public IBodyWorkflowAction<Procedure> ProceduresGet([WorkflowExpression] Func<int> procedureId)
        {
            SourceExpression.Validate(procedureId, nameof(procedureId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/Procedures/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(procedureId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<Procedure>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "waywedo")]
        public IBodyWorkflowAction<ChecklistInstance[]> FindChecklistInstances([WorkflowExpression] Func<int> procedureId, [WorkflowExpression] Func<string> query = null)
        {
            SourceExpression.Validate(procedureId, nameof(procedureId), required: true);
            SourceExpression.Validate(query, nameof(query), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/Procedures/{0}/ChecklistInstances", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(procedureId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (query != null)
                    callPayload.Queries["query"] = SourceExpressionConverter.ConvertO(query);
                return callPayload;
            }

            return new ApiConnectionAction<ChecklistInstance[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "waywedo")]
        public IBodyWorkflowAction<User[]> FindUser([WorkflowExpression] Func<string> query = null)
        {
            SourceExpression.Validate(query, nameof(query), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/Users";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (query != null)
                    callPayload.Queries["query"] = SourceExpressionConverter.ConvertO(query);
                return callPayload;
            }

            return new ApiConnectionAction<User[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "waywedo")]
        public IBodyWorkflowAction<JToken> Users([WorkflowExpression] Func<string> createUserCommandfirstName, [WorkflowExpression] Func<string> createUserCommandlastName, [WorkflowExpression] Func<string> createUserCommandemail, [WorkflowExpression] Func<int> createUserCommandsecurityRole, [WorkflowExpression] Func<string> createUserCommandtimeZone, [WorkflowExpression] Func<int[]> createUserCommandcompanyRoles = null)
        {
            SourceExpression.Validate(createUserCommandfirstName, nameof(createUserCommandfirstName), required: true);
            SourceExpression.Validate(createUserCommandlastName, nameof(createUserCommandlastName), required: true);
            SourceExpression.Validate(createUserCommandemail, nameof(createUserCommandemail), required: true);
            SourceExpression.Validate(createUserCommandsecurityRole, nameof(createUserCommandsecurityRole), required: true);
            SourceExpression.Validate(createUserCommandtimeZone, nameof(createUserCommandtimeZone), required: true);
            SourceExpression.Validate(createUserCommandcompanyRoles, nameof(createUserCommandcompanyRoles), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/Users";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var createUserCommand = new JObject();
                var createUserCommandpropCount = 0;
                createUserCommandpropCount++;
                createUserCommand["firstName"] = SourceExpressionConverter.ConvertToken(createUserCommandfirstName);
                createUserCommandpropCount++;
                createUserCommand["lastName"] = SourceExpressionConverter.ConvertToken(createUserCommandlastName);
                createUserCommandpropCount++;
                createUserCommand["email"] = SourceExpressionConverter.ConvertToken(createUserCommandemail);
                createUserCommandpropCount++;
                createUserCommand["securityRole"] = SourceExpressionConverter.ConvertToken(createUserCommandsecurityRole);
                if (createUserCommandcompanyRoles != null)
                {
                    createUserCommand["companyRoles"] = SourceExpressionConverter.ConvertToken(createUserCommandcompanyRoles);
                    createUserCommandpropCount++;
                }

                createUserCommandpropCount++;
                createUserCommand["timeZoneId"] = SourceExpressionConverter.ConvertToken(createUserCommandtimeZone);
                if (createUserCommandpropCount > 0)
                {
                    callPayload.Body = createUserCommand;
                }
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }
    }

    public class WaywedoTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<WebhookRegistered> ChecklistCreateWebHook(string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
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
                return callPayload;
            }

            return new ApiConnectionTrigger<WebhookRegistered>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<WebhookRegistered> NewCommentWebHook(string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
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
                return callPayload;
            }

            return new ApiConnectionTrigger<WebhookRegistered>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<WebhookRegistered> FinishChecklistWebHook(string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
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
                return callPayload;
            }

            return new ApiConnectionTrigger<WebhookRegistered>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<WebhookRegistered> InviteSupervisorWebHook(string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
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
                return callPayload;
            }

            return new ApiConnectionTrigger<WebhookRegistered>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<WebhookRegistered> GenerateAcceptancePDFWebHook(string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
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
                return callPayload;
            }

            return new ApiConnectionTrigger<WebhookRegistered>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<WebhookRegistered> ChecklistStepCompletedWebHook(string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
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
                return callPayload;
            }

            return new ApiConnectionTrigger<WebhookRegistered>(BuildSourceInput, triggerName, recurrence);
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
        _1 = 1,
        _2 = 2
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
        _1 = 1,
        _2 = 2
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