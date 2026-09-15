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
                callPayload.Queries["$expand"] = CSharpExpressionConverter.ConvertO(expand);
            if (select != null)
                callPayload.Queries["$select"] = CSharpExpressionConverter.ConvertO(select);
            if (orderby != null)
                callPayload.Queries["$orderby"] = CSharpExpressionConverter.ConvertO(orderby);
            callPayload.Queries["$top"] = Convert.ToString(10);
            if (top != null)
                callPayload.Queries["$top"] = CSharpExpressionConverter.ConvertO(top);
            if (skip != null)
                callPayload.Queries["$skip"] = CSharpExpressionConverter.ConvertO(skip);
            if (count != null)
                callPayload.Queries["$count"] = CSharpExpressionConverter.ConvertO(count);
            callPayload.Headers["x-requested-by"] = Convert.ToString("PowerAutomate");
            return new ApiConnectionAction<ServiceDeskCoreModelsTicketItems>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tikit")]
        public IBodyWorkflowAction<ServiceDeskCoreModelsTicket> CreateTicket(Expression<Func<string>> bodyticketrequest, Expression<Func<string>> bodyticketrequesterrequesterEmail, Expression<Func<int>> bodyticketstatus, Expression<Func<int>> bodyticketpriority, Expression<Func<int>> bodyticketticketType, Expression<Func<string>> bodyticketassigneeassigneeEmail, Expression<Func<int>> bodyticketcategory = null, Expression<Func<int>> bodyticketgroup = null, Expression<Func<string>> bodyticketdueDate = null, Expression<Func<string>> bodyticketresolutionDate = null)
        {
            var apiCallPath = "/AddTicket";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["x-requested-by"] = Convert.ToString("PowerAutomate");
            var body = new JObject();
            var bodypropCount = 0;
            var ticketObject = new JObject();
            var ticketObjectpropCount = 0;
            ticketObjectpropCount++;
            ticketObject["Title"] = CSharpExpressionConverter.ConvertToken(bodyticketrequest);
            var requesterObject = new JObject();
            var requesterObjectpropCount = 0;
            requesterObjectpropCount++;
            requesterObject["EMailAddress"] = CSharpExpressionConverter.ConvertToken(bodyticketrequesterrequesterEmail);
            if (requesterObjectpropCount > 0)
            {
                ticketObject["Requester"] = requesterObject;
                ticketObjectpropCount++;
            }

            ticketObjectpropCount++;
            ticketObject["StatusId"] = CSharpExpressionConverter.ConvertToken(bodyticketstatus);
            if (bodyticketcategory != null)
            {
                ticketObject["CategoryId"] = CSharpExpressionConverter.ConvertToken(bodyticketcategory);
                ticketObjectpropCount++;
            }

            ticketObjectpropCount++;
            ticketObject["PriorityId"] = CSharpExpressionConverter.ConvertToken(bodyticketpriority);
            ticketObjectpropCount++;
            ticketObject["TicketTypeId"] = CSharpExpressionConverter.ConvertToken(bodyticketticketType);
            if (bodyticketgroup != null)
            {
                ticketObject["SupportGroupId"] = CSharpExpressionConverter.ConvertToken(bodyticketgroup);
                ticketObjectpropCount++;
            }

            if (bodyticketdueDate != null)
            {
                ticketObject["DueDate"] = CSharpExpressionConverter.ConvertToken(bodyticketdueDate);
                ticketObjectpropCount++;
            }

            if (bodyticketresolutionDate != null)
            {
                ticketObject["ResolutionDate"] = CSharpExpressionConverter.ConvertToken(bodyticketresolutionDate);
                ticketObjectpropCount++;
            }

            var assigneeObject = new JObject();
            var assigneeObjectpropCount = 0;
            assigneeObjectpropCount++;
            assigneeObject["Email"] = CSharpExpressionConverter.ConvertToken(bodyticketassigneeassigneeEmail);
            if (assigneeObjectpropCount > 0)
            {
                ticketObject["Assignee"] = assigneeObject;
                ticketObjectpropCount++;
            }

            if (ticketObjectpropCount > 0)
            {
                body["Ticket"] = ticketObject;
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ServiceDeskCoreModelsTicket>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tikit")]
        public IBodyWorkflowAction<ServiceDeskCoreModelsTicket> UpdateTicket(Expression<Func<int>> bodyticketenterTikitId, Expression<Func<string>> bodyticketassigneeassigneeEmail, Expression<Func<string>> bodyticketchangeRequestInformation = null, Expression<Func<string>> bodyticketrequesterrequesterEmail = null, Expression<Func<int>> bodyticketstatus = null, Expression<Func<int>> bodyticketcategory = null, Expression<Func<int>> bodyticketpriority = null, Expression<Func<int>> bodyticketticketType = null, Expression<Func<int>> bodyticketgroup = null, Expression<Func<string>> bodyticketdueDate = null, Expression<Func<string>> bodyticketresolutionDate = null)
        {
            var apiCallPath = "/UpdateTicket";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["x-requested-by"] = Convert.ToString("PowerAutomate");
            var body = new JObject();
            var bodypropCount = 0;
            var ticketObject = new JObject();
            var ticketObjectpropCount = 0;
            ticketObjectpropCount++;
            ticketObject["Id"] = CSharpExpressionConverter.ConvertToken(bodyticketenterTikitId);
            if (bodyticketchangeRequestInformation != null)
            {
                ticketObject["Title"] = CSharpExpressionConverter.ConvertToken(bodyticketchangeRequestInformation);
                ticketObjectpropCount++;
            }

            var requesterObject = new JObject();
            var requesterObjectpropCount = 0;
            if (bodyticketrequesterrequesterEmail != null)
            {
                requesterObject["EMailAddress"] = CSharpExpressionConverter.ConvertToken(bodyticketrequesterrequesterEmail);
                requesterObjectpropCount++;
            }

            if (requesterObjectpropCount > 0)
            {
                ticketObject["Requester"] = requesterObject;
                ticketObjectpropCount++;
            }

            if (bodyticketstatus != null)
            {
                ticketObject["StatusId"] = CSharpExpressionConverter.ConvertToken(bodyticketstatus);
                ticketObjectpropCount++;
            }

            if (bodyticketcategory != null)
            {
                ticketObject["CategoryId"] = CSharpExpressionConverter.ConvertToken(bodyticketcategory);
                ticketObjectpropCount++;
            }

            if (bodyticketpriority != null)
            {
                ticketObject["PriorityId"] = CSharpExpressionConverter.ConvertToken(bodyticketpriority);
                ticketObjectpropCount++;
            }

            if (bodyticketticketType != null)
            {
                ticketObject["TicketTypeId"] = CSharpExpressionConverter.ConvertToken(bodyticketticketType);
                ticketObjectpropCount++;
            }

            if (bodyticketgroup != null)
            {
                ticketObject["SupportGroupId"] = CSharpExpressionConverter.ConvertToken(bodyticketgroup);
                ticketObjectpropCount++;
            }

            if (bodyticketdueDate != null)
            {
                ticketObject["DueDate"] = CSharpExpressionConverter.ConvertToken(bodyticketdueDate);
                ticketObjectpropCount++;
            }

            if (bodyticketresolutionDate != null)
            {
                ticketObject["ResolutionDate"] = CSharpExpressionConverter.ConvertToken(bodyticketresolutionDate);
                ticketObjectpropCount++;
            }

            var assigneeObject = new JObject();
            var assigneeObjectpropCount = 0;
            assigneeObjectpropCount++;
            assigneeObject["Email"] = CSharpExpressionConverter.ConvertToken(bodyticketassigneeassigneeEmail);
            if (assigneeObjectpropCount > 0)
            {
                ticketObject["Assignee"] = assigneeObject;
                ticketObjectpropCount++;
            }

            if (ticketObjectpropCount > 0)
            {
                body["Ticket"] = ticketObject;
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
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/ticket/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (select != null)
                callPayload.Queries["$select"] = CSharpExpressionConverter.ConvertO(select);
            callPayload.Queries["$expand"] = Convert.ToString("Requester,Assignee");
            if (expand != null)
                callPayload.Queries["$expand"] = CSharpExpressionConverter.ConvertO(expand);
            callPayload.Headers["x-requested-by"] = Convert.ToString("PowerAutomate");
            return new ApiConnectionAction<ServiceDeskCoreModelsTicket>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tikit")]
        public IBodyWorkflowAction<AddCommentResponse> AddComment(Expression<Func<string>> id, Expression<Func<string>> bodycommentbody = null, Expression<Func<bool>> bodycommentisPublic = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/ticket({0})/AddComment", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["x-requested-by"] = Convert.ToString("PowerAutomate");
            var body = new JObject();
            var bodypropCount = 0;
            var commentObject = new JObject();
            var commentObjectpropCount = 0;
            if (bodycommentbody != null)
            {
                commentObject["Body"] = CSharpExpressionConverter.ConvertToken(bodycommentbody);
                commentObjectpropCount++;
            }

            if (bodycommentisPublic != null)
            {
                commentObject["IsPublic"] = CSharpExpressionConverter.ConvertToken(bodycommentisPublic);
                commentObjectpropCount++;
            }

            if (commentObjectpropCount > 0)
            {
                body["Comment"] = commentObject;
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
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/ticket/{0}/FileAttachments", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetFileAttachedResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tikit")]
        public IBodyWorkflowAction<GetTasksResponse> GetTasks(Expression<Func<string>> id, Expression<Func<string>> lifecycle = null, Expression<Func<string>> phase = null, Expression<Func<string>> taskName = null, Expression<Func<string>> assignee = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/Ticket({0})/GetTasks", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (lifecycle != null)
                callPayload.Queries["Lifecycle"] = CSharpExpressionConverter.ConvertO(lifecycle);
            if (phase != null)
                callPayload.Queries["Phase"] = CSharpExpressionConverter.ConvertO(phase);
            if (taskName != null)
                callPayload.Queries["TaskName"] = CSharpExpressionConverter.ConvertO(taskName);
            if (assignee != null)
                callPayload.Queries["Assignee"] = CSharpExpressionConverter.ConvertO(assignee);
            callPayload.Headers["x-requested-by"] = Convert.ToString("PowerAutomate");
            return new ApiConnectionAction<GetTasksResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tikit")]
        public IBodyWorkflowAction<GetPowerAutomateTasksResponse> GetPowerAutomateTasks(Expression<Func<string>> id, Expression<Func<string>> lifecycle = null, Expression<Func<string>> phase = null, Expression<Func<string>> taskName = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/Ticket({0})/GetPowerAutomateTasks", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (lifecycle != null)
                callPayload.Queries["Lifecycle"] = CSharpExpressionConverter.ConvertO(lifecycle);
            if (phase != null)
                callPayload.Queries["Phase"] = CSharpExpressionConverter.ConvertO(phase);
            if (taskName != null)
                callPayload.Queries["TaskName"] = CSharpExpressionConverter.ConvertO(taskName);
            callPayload.Headers["x-requested-by"] = Convert.ToString("PowerAutomate");
            return new ApiConnectionAction<GetPowerAutomateTasksResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tikit")]
        public IBodyWorkflowAction<ServiceDeskCoreModelsTicketTask> AddTask(Expression<Func<string>> id, Expression<Func<string>> bodytitle, Expression<Func<string>> bodylifecycle = null, Expression<Func<string>> bodyphase = null, Expression<Func<string>> bodyassignee = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/Ticket({0})/AddTask", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["x-requested-by"] = Convert.ToString("PowerAutomate");
            var body = new JObject();
            var bodypropCount = 0;
            if (bodylifecycle != null)
            {
                body["Lifecycle"] = CSharpExpressionConverter.ConvertToken(bodylifecycle);
                bodypropCount++;
            }

            if (bodyphase != null)
            {
                body["PhaseId"] = CSharpExpressionConverter.ConvertToken(bodyphase);
                bodypropCount++;
            }

            bodypropCount++;
            body["Title"] = CSharpExpressionConverter.ConvertToken(bodytitle);
            if (bodyassignee != null)
            {
                body["Assignee"] = CSharpExpressionConverter.ConvertToken(bodyassignee);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ServiceDeskCoreModelsTicketTask>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tikit")]
        public IBodyWorkflowAction<ServiceDeskCoreModelsTicketTask> UpdateTask(Expression<Func<string>> id, Expression<Func<string>> bodytitle = null, Expression<Func<string>> bodyassignee = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/TicketTask({0})/UpdateTask", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["x-requested-by"] = Convert.ToString("PowerAutomate");
            var body = new JObject();
            var bodypropCount = 0;
            if (bodytitle != null)
            {
                body["Title"] = CSharpExpressionConverter.ConvertToken(bodytitle);
                bodypropCount++;
            }

            if (bodyassignee != null)
            {
                body["Assignee"] = CSharpExpressionConverter.ConvertToken(bodyassignee);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ServiceDeskCoreModelsTicketTask>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tikit")]
        public IBodyWorkflowAction<ServiceDeskCoreModelsPowerAutomateTask> UpdatePowerAutomateTask(Expression<Func<string>> id, Expression<Func<string>> bodystatusId = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/TicketTask({0})/UpdatePowerAutomateTask", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["x-requested-by"] = Convert.ToString("PowerAutomate");
            var body = new JObject();
            var bodypropCount = 0;
            if (bodystatusId != null)
            {
                body["StatusId"] = CSharpExpressionConverter.ConvertToken(bodystatusId);
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
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/Ticket({0})/GetApprovals", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (lifecycle != null)
                callPayload.Queries["Lifecycle"] = CSharpExpressionConverter.ConvertO(lifecycle);
            if (phase != null)
                callPayload.Queries["Phase"] = CSharpExpressionConverter.ConvertO(phase);
            if (approvalName != null)
                callPayload.Queries["ApprovalName"] = CSharpExpressionConverter.ConvertO(approvalName);
            if (approvers != null)
                callPayload.Queries["Approvers"] = CSharpExpressionConverter.ConvertO(approvers);
            if (additionalDetails != null)
                callPayload.Queries["AdditionalDetails"] = CSharpExpressionConverter.ConvertO(additionalDetails);
            callPayload.Headers["x-requested-by"] = Convert.ToString("PowerAutomate");
            return new ApiConnectionAction<GetApprovalsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tikit")]
        public IBodyWorkflowAction<ServiceDeskCoreModelsApprovals> UpdateApproval(Expression<Func<string>> id, Expression<Func<string>> bodytitle = null, Expression<Func<string>> bodyadditionalDetails = null, Expression<Func<bodyrequiredByAllInput>> bodyrequiredByAll = null, Expression<Func<string>> bodyapprovers = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/Approvals({0})/UpdateApproval", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["x-requested-by"] = Convert.ToString("PowerAutomate");
            var body = new JObject();
            var bodypropCount = 0;
            if (bodytitle != null)
            {
                body["Title"] = CSharpExpressionConverter.ConvertToken(bodytitle);
                bodypropCount++;
            }

            if (bodyadditionalDetails != null)
            {
                body["AdditionalDetails"] = CSharpExpressionConverter.ConvertToken(bodyadditionalDetails);
                bodypropCount++;
            }

            if (bodyrequiredByAll != null)
            {
                body["RequiredByAll"] = CSharpExpressionConverter.Convert(bodyrequiredByAll);
                bodypropCount++;
            }

            if (bodyapprovers != null)
            {
                body["Approvers"] = CSharpExpressionConverter.ConvertToken(bodyapprovers);
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
        public IBodyWorkflowTrigger<ServiceDeskCoreActionsAddWebhookWebhookParam> AddTicketWebhookTrigger(Expression<Func<string>> bodywebHookrequesters = null, Expression<Func<string>> bodywebHookassignees = null, Expression<Func<string>> bodywebHooktitle = null, Expression<Func<string>> bodywebHookstatus = null, Expression<Func<bodywebHookpriorityInput>> bodywebHookpriority = null, Expression<Func<int>> bodywebHookgroup = null, Expression<Func<int>> bodywebHookselectTemplate = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/AddTicketWebhook";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            var body = new JObject();
            var bodypropCount = 0;
            var webHookObject = new JObject();
            var webHookObjectpropCount = 0;
            webHookObject["URL"] = "@listCallbackUrl()";
            webHookObjectpropCount++;
            if (bodywebHookrequesters != null)
            {
                webHookObject["Requesters"] = CSharpExpressionConverter.ConvertToken(bodywebHookrequesters);
                webHookObjectpropCount++;
            }

            if (bodywebHookassignees != null)
            {
                webHookObject["Assignees"] = CSharpExpressionConverter.ConvertToken(bodywebHookassignees);
                webHookObjectpropCount++;
            }

            if (bodywebHooktitle != null)
            {
                webHookObject["Title"] = CSharpExpressionConverter.ConvertToken(bodywebHooktitle);
                webHookObjectpropCount++;
            }

            if (bodywebHookstatus != null)
            {
                if (bodywebHookstatus != null)
                {
                    webHookObject["Status"] = CSharpExpressionConverter.ConvertToken(bodywebHookstatus);
                    webHookObjectpropCount++;
                }

                webHookObjectpropCount++;
            }
            else
            {
                webHookObject["Status"] = "Any";
                webHookObjectpropCount++;
            }

            if (bodywebHookpriority != null)
            {
                if (bodywebHookpriority != null)
                {
                    webHookObject["Priority"] = CSharpExpressionConverter.Convert(bodywebHookpriority);
                    webHookObjectpropCount++;
                }

                webHookObjectpropCount++;
            }
            else
            {
                webHookObject["Priority"] = "Any";
                webHookObjectpropCount++;
            }

            if (bodywebHookgroup != null)
            {
                webHookObject["GroupId"] = CSharpExpressionConverter.ConvertToken(bodywebHookgroup);
                webHookObjectpropCount++;
            }

            if (bodywebHookselectTemplate != null)
            {
                webHookObject["TemplateId"] = CSharpExpressionConverter.ConvertToken(bodywebHookselectTemplate);
                webHookObjectpropCount++;
            }

            if (webHookObjectpropCount > 0)
            {
                body["WebHook"] = webHookObject;
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<ServiceDeskCoreActionsAddWebhookWebhookParam>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<ServiceDeskCoreActionsAddWebhookWebhookParam> UpdateTicketWebhookTrigger(Expression<Func<string>> bodywebHookrequesters = null, Expression<Func<string>> bodywebHookassignees = null, Expression<Func<string>> bodywebHooktitle = null, Expression<Func<string>> bodywebHookstatus = null, Expression<Func<bodywebHookpriorityInput>> bodywebHookpriority = null, Expression<Func<int>> bodywebHookgroup = null, Expression<Func<int>> bodywebHookselectTemplate = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/UpdateTicketWebhook";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            var body = new JObject();
            var bodypropCount = 0;
            var webHookObject = new JObject();
            var webHookObjectpropCount = 0;
            webHookObject["URL"] = "@listCallbackUrl()";
            webHookObjectpropCount++;
            if (bodywebHookrequesters != null)
            {
                webHookObject["Requesters"] = CSharpExpressionConverter.ConvertToken(bodywebHookrequesters);
                webHookObjectpropCount++;
            }

            if (bodywebHookassignees != null)
            {
                webHookObject["Assignees"] = CSharpExpressionConverter.ConvertToken(bodywebHookassignees);
                webHookObjectpropCount++;
            }

            if (bodywebHooktitle != null)
            {
                webHookObject["Title"] = CSharpExpressionConverter.ConvertToken(bodywebHooktitle);
                webHookObjectpropCount++;
            }

            if (bodywebHookstatus != null)
            {
                if (bodywebHookstatus != null)
                {
                    webHookObject["Status"] = CSharpExpressionConverter.ConvertToken(bodywebHookstatus);
                    webHookObjectpropCount++;
                }

                webHookObjectpropCount++;
            }
            else
            {
                webHookObject["Status"] = "Any";
                webHookObjectpropCount++;
            }

            if (bodywebHookpriority != null)
            {
                if (bodywebHookpriority != null)
                {
                    webHookObject["Priority"] = CSharpExpressionConverter.Convert(bodywebHookpriority);
                    webHookObjectpropCount++;
                }

                webHookObjectpropCount++;
            }
            else
            {
                webHookObject["Priority"] = "Any";
                webHookObjectpropCount++;
            }

            if (bodywebHookgroup != null)
            {
                webHookObject["GroupId"] = CSharpExpressionConverter.ConvertToken(bodywebHookgroup);
                webHookObjectpropCount++;
            }

            if (bodywebHookselectTemplate != null)
            {
                webHookObject["TemplateId"] = CSharpExpressionConverter.ConvertToken(bodywebHookselectTemplate);
                webHookObjectpropCount++;
            }

            if (webHookObjectpropCount > 0)
            {
                body["WebHook"] = webHookObject;
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<ServiceDeskCoreActionsAddWebhookWebhookParam>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<ServiceDeskCoreActionsAddWebhookWebhookParam> AddCommentTicketWebhook(Expression<Func<string>> bodywebHookcommenter = null, Expression<Func<string>> bodywebHookcommentStringContain = null, Expression<Func<bodywebHookisPublicCommentInput>> bodywebHookisPublicComment = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/AddCommentTicketWebhook";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            var body = new JObject();
            var bodypropCount = 0;
            var webHookObject = new JObject();
            var webHookObjectpropCount = 0;
            webHookObject["URL"] = "@listCallbackUrl()";
            webHookObjectpropCount++;
            if (bodywebHookcommenter != null)
            {
                webHookObject["Commenter"] = CSharpExpressionConverter.ConvertToken(bodywebHookcommenter);
                webHookObjectpropCount++;
            }

            if (bodywebHookcommentStringContain != null)
            {
                webHookObject["CommentStringContain"] = CSharpExpressionConverter.ConvertToken(bodywebHookcommentStringContain);
                webHookObjectpropCount++;
            }

            if (bodywebHookisPublicComment != null)
            {
                if (bodywebHookisPublicComment != null)
                {
                    webHookObject["IsPublicComment"] = CSharpExpressionConverter.Convert(bodywebHookisPublicComment);
                    webHookObjectpropCount++;
                }

                webHookObjectpropCount++;
            }
            else
            {
                webHookObject["IsPublicComment"] = "Any";
                webHookObjectpropCount++;
            }

            if (webHookObjectpropCount > 0)
            {
                body["WebHook"] = webHookObject;
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<ServiceDeskCoreActionsAddWebhookWebhookParam>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<ServiceDeskCoreModelsTicketTask> ActivatePowerAutomateTaskWebhook(Expression<Func<string>> bodywebHooklifecycleId = null, Expression<Func<int>> bodywebHooklifecyclePhaseId = null, Expression<Func<string>> bodywebHooklifecyclePowerAutomateName = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/ActivatePowerAutomateTaskWebhook";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            var body = new JObject();
            var bodypropCount = 0;
            var webHookObject = new JObject();
            var webHookObjectpropCount = 0;
            webHookObject["URL"] = "@listCallbackUrl()";
            webHookObjectpropCount++;
            if (bodywebHooklifecycleId != null)
            {
                webHookObject["LifecycleId"] = CSharpExpressionConverter.ConvertToken(bodywebHooklifecycleId);
                webHookObjectpropCount++;
            }

            if (bodywebHooklifecyclePhaseId != null)
            {
                webHookObject["LifecyclePhaseId"] = CSharpExpressionConverter.ConvertToken(bodywebHooklifecyclePhaseId);
                webHookObjectpropCount++;
            }

            if (bodywebHooklifecyclePowerAutomateName != null)
            {
                webHookObject["LifecyclePowerAutomateName"] = CSharpExpressionConverter.ConvertToken(bodywebHooklifecyclePowerAutomateName);
                webHookObjectpropCount++;
            }

            if (webHookObjectpropCount > 0)
            {
                body["WebHook"] = webHookObject;
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<ServiceDeskCoreModelsTicketTask>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<ServiceDeskCoreActionsAddWebhookWebhookParam> ChangeLifecyclePhaseWebhook(Expression<Func<string>> bodywebHooklifecycleId = null, Expression<Func<int>> bodywebHooklifecyclePhaseId = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/ChangeLifecyclePhaseWebhook";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            var body = new JObject();
            var bodypropCount = 0;
            var webHookObject = new JObject();
            var webHookObjectpropCount = 0;
            webHookObject["URL"] = "@listCallbackUrl()";
            webHookObjectpropCount++;
            if (bodywebHooklifecycleId != null)
            {
                webHookObject["LifecycleId"] = CSharpExpressionConverter.ConvertToken(bodywebHooklifecycleId);
                webHookObjectpropCount++;
            }

            if (bodywebHooklifecyclePhaseId != null)
            {
                webHookObject["LifecyclePhaseId"] = CSharpExpressionConverter.ConvertToken(bodywebHooklifecyclePhaseId);
                webHookObjectpropCount++;
            }

            if (webHookObjectpropCount > 0)
            {
                body["WebHook"] = webHookObject;
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<ServiceDeskCoreActionsAddWebhookWebhookParam>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<ServiceDeskCoreActionsAddWebhookWebhookParam> EngageLifecycleTransitionWebhook(Expression<Func<string>> bodywebHooklifecycleId = null, Expression<Func<int>> bodywebHooklifecyclePhaseId = null, Expression<Func<int>> bodywebHooklifecycleTransitionId = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/EngageLifecycleTransitionWebhook";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            var body = new JObject();
            var bodypropCount = 0;
            var webHookObject = new JObject();
            var webHookObjectpropCount = 0;
            webHookObject["URL"] = "@listCallbackUrl()";
            webHookObjectpropCount++;
            if (bodywebHooklifecycleId != null)
            {
                webHookObject["LifecycleId"] = CSharpExpressionConverter.ConvertToken(bodywebHooklifecycleId);
                webHookObjectpropCount++;
            }

            if (bodywebHooklifecyclePhaseId != null)
            {
                webHookObject["LifecyclePhaseId"] = CSharpExpressionConverter.ConvertToken(bodywebHooklifecyclePhaseId);
                webHookObjectpropCount++;
            }

            if (bodywebHooklifecycleTransitionId != null)
            {
                webHookObject["LifecycleTransitionId"] = CSharpExpressionConverter.ConvertToken(bodywebHooklifecycleTransitionId);
                webHookObjectpropCount++;
            }

            if (webHookObjectpropCount > 0)
            {
                body["WebHook"] = webHookObject;
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<ServiceDeskCoreActionsAddWebhookWebhookParam>(callPayload, triggerName, recurrence);
        }
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

    public enum bodyrequiredByAllInput
    {
        True,
        False
    }

    public class ServiceDeskCoreActionsAddWebhookWebhookParam
    {
        public ServiceDeskCoreActionsAddWebhookProperties WebHook { get; set; }
    }

    public class ServiceDeskCoreActionsAddWebhookProperties
    {
        public string URL { get; set; }
        public string Requesters { get; set; }
        public string Assignees { get; set; }
        public bool Template { get; set; }
        public bool Title { get; set; }
        public bool Status { get; set; }
        public bool Priority { get; set; }
        public bool Group { get; set; }
        public bool DueDate { get; set; }
        public int LifecylceId { get; set; }
        public int PhaseId { get; set; }
        public int TransitionId { get; set; }
        public int PowerAutomateTaskId { get; set; }
    }

    public enum bodywebHookpriorityInput
    {
        Any,
        [EnumMember(Value = "1 (High)")]
        _1High,
        [EnumMember(Value = "2 (Medium)")]
        _2Medium,
        [EnumMember(Value = "3 (Low)")]
        _3Low
    }

    public enum bodywebHookisPublicCommentInput
    {
        Any,
        Public,
        Private
    }
}

namespace Microsoft.Azure.Workflows.Sdk
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