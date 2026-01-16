//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Tikit
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class TikitActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tikit")]
        public IBodyWorkflowAction<ServiceDeskCoreModelsTicketItems> GetAllTickets(Expression<Func<string>> expand = null, Expression<Func<string>> select = null, Expression<Func<string>> orderby = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, Expression<Func<bool>> count = null)
        {
            var apiCallPath = "/Ticket";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (expand != null)
                callPayload.Queries["$expand"] = ExpressionConverter.Convert(expand);
            if (select != null)
                callPayload.Queries["$select"] = ExpressionConverter.Convert(select);
            if (orderby != null)
                callPayload.Queries["$orderby"] = ExpressionConverter.Convert(orderby);
            callPayload.Queries["$top"] = Convert.ToString(10);
            if (top != null)
                callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
            if (skip != null)
                callPayload.Queries["$skip"] = ExpressionConverter.Convert(skip);
            if (count != null)
                callPayload.Queries["$count"] = ExpressionConverter.Convert(count);
            callPayload.Headers["x-requested-by"] = Convert.ToString("PowerAutomate");
            return new ApiConnectionAction<ServiceDeskCoreModelsTicketItems>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tikit")]
        public IBodyWorkflowAction<ServiceDeskCoreModelsTicket> CreateTicket(Expression<Func<string>> bodyTicketrequest, Expression<Func<string>> bodyTicketRequesterrequesterEmail, Expression<Func<int>> bodyTicketstatus, Expression<Func<int>> bodyTicketpriority, Expression<Func<int>> bodyTicketticketType, Expression<Func<string>> bodyTicketAssigneeassigneeEmail, Expression<Func<int>> bodyTicketcategory = null, Expression<Func<int>> bodyTicketgroup = null, Expression<Func<string>> bodyTicketDueDate = null, Expression<Func<string>> bodyTicketResolutionDate = null)
        {
            var apiCallPath = "/AddTicket";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["x-requested-by"] = Convert.ToString("PowerAutomate");
            var body = new JObject();
            var bodypropCount = 0;
            var TicketObject = new JObject();
            var TicketObjectpropCount = 0;
            TicketObjectpropCount++;
            TicketObject["Title"] = ExpressionConverter.ConvertO(bodyTicketrequest);
            var RequesterObject = new JObject();
            var RequesterObjectpropCount = 0;
            RequesterObjectpropCount++;
            RequesterObject["EMailAddress"] = ExpressionConverter.ConvertO(bodyTicketRequesterrequesterEmail);
            if (RequesterObjectpropCount > 0)
            {
                TicketObject["Requester"] = RequesterObject;
                TicketObjectpropCount++;
            }

            TicketObjectpropCount++;
            TicketObject["StatusId"] = ExpressionConverter.ConvertO(bodyTicketstatus);
            if (bodyTicketcategory != null)
            {
                TicketObject["CategoryId"] = ExpressionConverter.ConvertO(bodyTicketcategory);
                TicketObjectpropCount++;
            }

            TicketObjectpropCount++;
            TicketObject["PriorityId"] = ExpressionConverter.ConvertO(bodyTicketpriority);
            TicketObjectpropCount++;
            TicketObject["TicketTypeId"] = ExpressionConverter.ConvertO(bodyTicketticketType);
            if (bodyTicketgroup != null)
            {
                TicketObject["SupportGroupId"] = ExpressionConverter.ConvertO(bodyTicketgroup);
                TicketObjectpropCount++;
            }

            if (bodyTicketDueDate != null)
            {
                TicketObject["DueDate"] = ExpressionConverter.ConvertO(bodyTicketDueDate);
                TicketObjectpropCount++;
            }

            if (bodyTicketResolutionDate != null)
            {
                TicketObject["ResolutionDate"] = ExpressionConverter.ConvertO(bodyTicketResolutionDate);
                TicketObjectpropCount++;
            }

            var AssigneeObject = new JObject();
            var AssigneeObjectpropCount = 0;
            AssigneeObjectpropCount++;
            AssigneeObject["Email"] = ExpressionConverter.ConvertO(bodyTicketAssigneeassigneeEmail);
            if (AssigneeObjectpropCount > 0)
            {
                TicketObject["Assignee"] = AssigneeObject;
                TicketObjectpropCount++;
            }

            if (TicketObjectpropCount > 0)
            {
                body["Ticket"] = TicketObject;
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ServiceDeskCoreModelsTicket>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tikit")]
        public IBodyWorkflowAction<ServiceDeskCoreModelsTicket> UpdateTicket(Expression<Func<int>> bodyTicketenterTikitId, Expression<Func<string>> bodyTicketAssigneeassigneeEmail, Expression<Func<string>> bodyTicketchangeRequestInformation = null, Expression<Func<string>> bodyTicketRequesterrequesterEmail = null, Expression<Func<int>> bodyTicketstatus = null, Expression<Func<int>> bodyTicketcategory = null, Expression<Func<int>> bodyTicketpriority = null, Expression<Func<int>> bodyTicketticketType = null, Expression<Func<int>> bodyTicketgroup = null, Expression<Func<string>> bodyTicketDueDate = null, Expression<Func<string>> bodyTicketResolutionDate = null)
        {
            var apiCallPath = "/UpdateTicket";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["x-requested-by"] = Convert.ToString("PowerAutomate");
            var body = new JObject();
            var bodypropCount = 0;
            var TicketObject = new JObject();
            var TicketObjectpropCount = 0;
            TicketObjectpropCount++;
            TicketObject["Id"] = ExpressionConverter.ConvertO(bodyTicketenterTikitId);
            if (bodyTicketchangeRequestInformation != null)
            {
                TicketObject["Title"] = ExpressionConverter.ConvertO(bodyTicketchangeRequestInformation);
                TicketObjectpropCount++;
            }

            var RequesterObject = new JObject();
            var RequesterObjectpropCount = 0;
            if (bodyTicketRequesterrequesterEmail != null)
            {
                RequesterObject["EMailAddress"] = ExpressionConverter.ConvertO(bodyTicketRequesterrequesterEmail);
                RequesterObjectpropCount++;
            }

            if (RequesterObjectpropCount > 0)
            {
                TicketObject["Requester"] = RequesterObject;
                TicketObjectpropCount++;
            }

            if (bodyTicketstatus != null)
            {
                TicketObject["StatusId"] = ExpressionConverter.ConvertO(bodyTicketstatus);
                TicketObjectpropCount++;
            }

            if (bodyTicketcategory != null)
            {
                TicketObject["CategoryId"] = ExpressionConverter.ConvertO(bodyTicketcategory);
                TicketObjectpropCount++;
            }

            if (bodyTicketpriority != null)
            {
                TicketObject["PriorityId"] = ExpressionConverter.ConvertO(bodyTicketpriority);
                TicketObjectpropCount++;
            }

            if (bodyTicketticketType != null)
            {
                TicketObject["TicketTypeId"] = ExpressionConverter.ConvertO(bodyTicketticketType);
                TicketObjectpropCount++;
            }

            if (bodyTicketgroup != null)
            {
                TicketObject["SupportGroupId"] = ExpressionConverter.ConvertO(bodyTicketgroup);
                TicketObjectpropCount++;
            }

            if (bodyTicketDueDate != null)
            {
                TicketObject["DueDate"] = ExpressionConverter.ConvertO(bodyTicketDueDate);
                TicketObjectpropCount++;
            }

            if (bodyTicketResolutionDate != null)
            {
                TicketObject["ResolutionDate"] = ExpressionConverter.ConvertO(bodyTicketResolutionDate);
                TicketObjectpropCount++;
            }

            var AssigneeObject = new JObject();
            var AssigneeObjectpropCount = 0;
            AssigneeObjectpropCount++;
            AssigneeObject["Email"] = ExpressionConverter.ConvertO(bodyTicketAssigneeassigneeEmail);
            if (AssigneeObjectpropCount > 0)
            {
                TicketObject["Assignee"] = AssigneeObject;
                TicketObjectpropCount++;
            }

            if (TicketObjectpropCount > 0)
            {
                body["Ticket"] = TicketObject;
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ServiceDeskCoreModelsTicket>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tikit")]
        public IBodyWorkflowAction<ServiceDeskCoreModelsTicket> GetOneTicket(Expression<Func<string>> id, Expression<Func<string>> select = null, Expression<Func<string>> expand = null)
        {
            var apiCallPath = String.Format("/ticket/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (select != null)
                callPayload.Queries["$select"] = ExpressionConverter.Convert(select);
            callPayload.Queries["$expand"] = Convert.ToString("Requester,Assignee");
            if (expand != null)
                callPayload.Queries["$expand"] = ExpressionConverter.Convert(expand);
            callPayload.Headers["x-requested-by"] = Convert.ToString("PowerAutomate");
            return new ApiConnectionAction<ServiceDeskCoreModelsTicket>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tikit")]
        public IBodyWorkflowAction<AddCommentResponse> AddComment(Expression<Func<string>> id, Expression<Func<string>> bodyCommentBody = null, Expression<Func<bool>> bodyCommentIsPublic = null)
        {
            var apiCallPath = String.Format("/ticket({0})/AddComment", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["x-requested-by"] = Convert.ToString("PowerAutomate");
            var body = new JObject();
            var bodypropCount = 0;
            var CommentObject = new JObject();
            var CommentObjectpropCount = 0;
            if (bodyCommentBody != null)
            {
                CommentObject["Body"] = ExpressionConverter.ConvertO(bodyCommentBody);
                CommentObjectpropCount++;
            }

            if (bodyCommentIsPublic != null)
            {
                CommentObject["IsPublic"] = ExpressionConverter.ConvertO(bodyCommentIsPublic);
                CommentObjectpropCount++;
            }

            if (CommentObjectpropCount > 0)
            {
                body["Comment"] = CommentObject;
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<AddCommentResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tikit")]
        public IBodyWorkflowAction<GetFileAttachedResponse> GetFileAttached(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/ticket/{0}/FileAttachments", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetFileAttachedResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tikit")]
        public IBodyWorkflowAction<GetTasksResponse> GetTasks(Expression<Func<string>> id, Expression<Func<string>> lifecycle = null, Expression<Func<string>> phase = null, Expression<Func<string>> taskName = null, Expression<Func<string>> assignee = null)
        {
            var apiCallPath = String.Format("/Ticket({0})/GetTasks", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (lifecycle != null)
                callPayload.Queries["Lifecycle"] = ExpressionConverter.Convert(lifecycle);
            if (phase != null)
                callPayload.Queries["Phase"] = ExpressionConverter.Convert(phase);
            if (taskName != null)
                callPayload.Queries["TaskName"] = ExpressionConverter.Convert(taskName);
            if (assignee != null)
                callPayload.Queries["Assignee"] = ExpressionConverter.Convert(assignee);
            callPayload.Headers["x-requested-by"] = Convert.ToString("PowerAutomate");
            return new ApiConnectionAction<GetTasksResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tikit")]
        public IBodyWorkflowAction<GetPowerAutomateTasksResponse> GetPowerAutomateTasks(Expression<Func<string>> id, Expression<Func<string>> lifecycle = null, Expression<Func<string>> phase = null, Expression<Func<string>> taskName = null)
        {
            var apiCallPath = String.Format("/Ticket({0})/GetPowerAutomateTasks", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (lifecycle != null)
                callPayload.Queries["Lifecycle"] = ExpressionConverter.Convert(lifecycle);
            if (phase != null)
                callPayload.Queries["Phase"] = ExpressionConverter.Convert(phase);
            if (taskName != null)
                callPayload.Queries["TaskName"] = ExpressionConverter.Convert(taskName);
            callPayload.Headers["x-requested-by"] = Convert.ToString("PowerAutomate");
            return new ApiConnectionAction<GetPowerAutomateTasksResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tikit")]
        public IBodyWorkflowAction<ServiceDeskCoreModelsTicketTask> AddTask(Expression<Func<string>> id, Expression<Func<string>> bodyTitle, Expression<Func<string>> bodylifecycle = null, Expression<Func<string>> bodyphase = null, Expression<Func<string>> bodyAssignee = null)
        {
            var apiCallPath = String.Format("/Ticket({0})/AddTask", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["x-requested-by"] = Convert.ToString("PowerAutomate");
            var body = new JObject();
            var bodypropCount = 0;
            if (bodylifecycle != null)
            {
                body["Lifecycle"] = ExpressionConverter.ConvertO(bodylifecycle);
                bodypropCount++;
            }

            if (bodyphase != null)
            {
                body["PhaseId"] = ExpressionConverter.ConvertO(bodyphase);
                bodypropCount++;
            }

            bodypropCount++;
            body["Title"] = ExpressionConverter.ConvertO(bodyTitle);
            if (bodyAssignee != null)
            {
                body["Assignee"] = ExpressionConverter.ConvertO(bodyAssignee);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ServiceDeskCoreModelsTicketTask>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tikit")]
        public IBodyWorkflowAction<ServiceDeskCoreModelsTicketTask> UpdateTask(Expression<Func<string>> id, Expression<Func<string>> bodyTitle = null, Expression<Func<string>> bodyAssignee = null)
        {
            var apiCallPath = String.Format("/TicketTask({0})/UpdateTask", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["x-requested-by"] = Convert.ToString("PowerAutomate");
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyTitle != null)
            {
                body["Title"] = ExpressionConverter.ConvertO(bodyTitle);
                bodypropCount++;
            }

            if (bodyAssignee != null)
            {
                body["Assignee"] = ExpressionConverter.ConvertO(bodyAssignee);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ServiceDeskCoreModelsTicketTask>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tikit")]
        public IBodyWorkflowAction<ServiceDeskCoreModelsPowerAutomateTask> UpdatePowerAutomateTask(Expression<Func<string>> id, Expression<Func<string>> bodyStatusId = null)
        {
            var apiCallPath = String.Format("/TicketTask({0})/UpdatePowerAutomateTask", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["x-requested-by"] = Convert.ToString("PowerAutomate");
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyStatusId != null)
            {
                body["StatusId"] = ExpressionConverter.ConvertO(bodyStatusId);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ServiceDeskCoreModelsPowerAutomateTask>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tikit")]
        public IBodyWorkflowAction<GetApprovalsResponse> GetApprovals(Expression<Func<string>> id, Expression<Func<string>> lifecycle = null, Expression<Func<string>> phase = null, Expression<Func<string>> approvalName = null, Expression<Func<string>> approvers = null, Expression<Func<string>> additionalDetails = null)
        {
            var apiCallPath = String.Format("/Ticket({0})/GetApprovals", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (lifecycle != null)
                callPayload.Queries["Lifecycle"] = ExpressionConverter.Convert(lifecycle);
            if (phase != null)
                callPayload.Queries["Phase"] = ExpressionConverter.Convert(phase);
            if (approvalName != null)
                callPayload.Queries["ApprovalName"] = ExpressionConverter.Convert(approvalName);
            if (approvers != null)
                callPayload.Queries["Approvers"] = ExpressionConverter.Convert(approvers);
            if (additionalDetails != null)
                callPayload.Queries["AdditionalDetails"] = ExpressionConverter.Convert(additionalDetails);
            callPayload.Headers["x-requested-by"] = Convert.ToString("PowerAutomate");
            return new ApiConnectionAction<GetApprovalsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tikit")]
        public IBodyWorkflowAction<ServiceDeskCoreModelsApprovals> UpdateApproval(Expression<Func<string>> id, Expression<Func<string>> bodyTitle = null, Expression<Func<string>> bodyAdditionalDetails = null, Expression<Func<bodyRequiredByAllInput>> bodyRequiredByAll = null, Expression<Func<string>> bodyApprovers = null)
        {
            var apiCallPath = String.Format("/Approvals({0})/UpdateApproval", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["x-requested-by"] = Convert.ToString("PowerAutomate");
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyTitle != null)
            {
                body["Title"] = ExpressionConverter.ConvertO(bodyTitle);
                bodypropCount++;
            }

            if (bodyAdditionalDetails != null)
            {
                body["AdditionalDetails"] = ExpressionConverter.ConvertO(bodyAdditionalDetails);
                bodypropCount++;
            }

            if (bodyRequiredByAll != null)
            {
                body["RequiredByAll"] = ExpressionConverter.ConvertO(bodyRequiredByAll);
                bodypropCount++;
            }

            if (bodyApprovers != null)
            {
                body["Approvers"] = ExpressionConverter.ConvertO(bodyApprovers);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ServiceDeskCoreModelsApprovals>(callPayload);
        }
    }

    public class TikitTriggers([ConnectionName] string connectionId)
    {
    }

    public class ServiceDeskCoreModelsTicketItems
    {
        [JsonProperty("value")]
        public ServiceDeskCoreModelsTicketItemsValueTypeItem[] Value { get; set; }
    }

    public class ServiceDeskCoreModelsTicketItemsValueTypeItem
    {
        public int RequesterId { get; set; }
        public string Title { get; set; }
        public bool Closed { get; set; }
        public string DueDate { get; set; }
        public string ResolutionDate { get; set; }
        public string Description { get; set; }
        public int AssigneeId { get; set; }
        public int SupportGroupId { get; set; }
        public int GroupId { get; set; }
        public int EscalationId { get; set; }
        public int CategoryId { get; set; }
        public int PriorityId { get; set; }
        public int SourceId { get; set; }
        public int StatusId { get; set; }
        public int UrgencyId { get; set; }
        public string TriageConversationId { get; set; }
        public string TriageActivityId { get; set; }
        public string LinkToMessage { get; set; }
        public int TemplateId { get; set; }
        public string CardTemplateJson { get; set; }
        public string CardAnswerJson { get; set; }
        public int TicketTypeId { get; set; }

        [JsonProperty("Guid")]
        public string Id { get; set; }
        public string ModifiedDate { get; set; }

        [JsonProperty("ModifiedById")]
        public int ModifiedBy { get; set; }
        public string CreatedDate { get; set; }
        public int CreatedById { get; set; }
        public bool IsDeleted { get; set; }
    }

    public class ServiceDeskCoreModelsTicket
    {
        public ServiceDeskCoreModelsRequester Requester { get; set; }
        public string Title { get; set; }
        public bool Closed { get; set; }
        public string DueDate { get; set; }
        public string ResolutionDate { get; set; }
        public string Description { get; set; }
        public ServiceDeskCoreModelsAssignee Assignee { get; set; }
        public int SupportGroupId { get; set; }
        public int GroupId { get; set; }
        public int EscalationId { get; set; }
        public int CategoryId { get; set; }
        public int ImpactId { get; set; }
        public int PriorityId { get; set; }
        public int SourceId { get; set; }
        public int StatusId { get; set; }
        public int UrgencyId { get; set; }
        public string TriageConversationId { get; set; }
        public string TriageActivityId { get; set; }
        public string LinkToMessage { get; set; }
        public int TemplateId { get; set; }
        public string CardAnswerJson { get; set; }

        [JsonProperty("Guid")]
        public string Id { get; set; }
        public string ModifiedDate { get; set; }
        public int ModifiedById { get; set; }
        public string CreatedDate { get; set; }
        public int CreatedById { get; set; }
        public bool IsDeleted { get; set; }
    }

    public class ServiceDeskCoreModelsRequester
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string AadObjectId { get; set; }
        public string UserName { get; set; }
    }

    public class ServiceDeskCoreModelsAssignee
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string AadObjectId { get; set; }
        public string UserName { get; set; }
    }

    public class AddCommentResponse
    {
        [JsonProperty("Guid")]
        public string Id { get; set; }
        public string ModifiedDate { get; set; }
        public int ModifiedById { get; set; }
        public string CreatedDate { get; set; }
        public int CreatedById { get; set; }
        public bool IsDeleted { get; set; }
        public string Body { get; set; }
        public bool IsPublic { get; set; }
    }

    public class GetFileAttachedResponse
    {
        [JsonProperty("value")]
        public GetFileAttachedResponseValueTypeItem[] Value { get; set; }
    }

    public class GetFileAttachedResponseValueTypeItem
    {
        public string FileName { get; set; }
        public double FileSize { get; set; }
        public string FileExtension { get; set; }

        [JsonProperty("Guid")]
        public string Id { get; set; }
        public string ModifiedDate { get; set; }
        public int ModifiedById { get; set; }
        public string CreatedDate { get; set; }
        public int CreatedById { get; set; }
        public bool IsDeleted { get; set; }
        public string DownladUrl { get; set; }
        public string DriveItemGroupId { get; set; }
        public string DriveItemId { get; set; }
    }

    public class GetTasksResponse
    {
        [JsonProperty("value")]
        public ServiceDeskCoreModelsTicketTask[] Value { get; set; }
    }

    public class ServiceDeskCoreModelsTicketTask
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int AssigneeId { get; set; }
        public string Assignee { get; set; }
        public string AssigneeAadObjectId { get; set; }
        public string AssigneeEmail { get; set; }
        public int StatusId { get; set; }
        public string Status { get; set; }
        public int TicketId { get; set; }
        public int LifeCycleId { get; set; }
        public string LifeCycleTitle { get; set; }
        public int PhaseId { get; set; }
        public string PhaseTitle { get; set; }
    }

    public class GetPowerAutomateTasksResponse
    {
        [JsonProperty("value")]
        public ServiceDeskCoreModelsPowerAutomateTask[] Value { get; set; }
    }

    public class ServiceDeskCoreModelsPowerAutomateTask
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int StatusId { get; set; }
        public string Status { get; set; }
        public int TicketId { get; set; }
        public int LifeCycleId { get; set; }
        public string LifeCycleTitle { get; set; }
        public int PhaseId { get; set; }
        public string PhaseTitle { get; set; }
    }

    public class GetApprovalsResponse
    {
        [JsonProperty("value")]
        public ServiceDeskCoreModelsApprovals[] Value { get; set; }
    }

    public class ServiceDeskCoreModelsApprovals
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string AdditionalDetails { get; set; }
        public bool IsRequiredByAll { get; set; }
        public ServiceDeskCoreModelsApprover[] Approvers { get; set; }
        public int TicketId { get; set; }
        public int LifeCycleId { get; set; }
        public string LifeCycleTitle { get; set; }
        public int PhaseId { get; set; }
        public string PhaseTitle { get; set; }
    }

    public class ServiceDeskCoreModelsApprover
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string AadObjectId { get; set; }
        public string UserName { get; set; }
    }

    public enum bodyRequiredByAllInput
    {
        True,
        False
    }
}

namespace Microsoft.Azure.Workflows.Sdk.Connectors
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Tikit;

    public partial class WorkflowManagedActions
    {
        public TikitActions Tikit(string connectionId) => new TikitActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public TikitTriggers Tikit(string connectionId) => new TikitTriggers(connectionId);
    }
}