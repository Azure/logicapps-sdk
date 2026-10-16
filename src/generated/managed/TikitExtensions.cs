//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Tikit
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class TikitActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tikit")]
        public IBodyWorkflowAction<ServiceDeskCoreModelsTicketItems> GetAllTickets(Expression<Func<string>> expand = null, Expression<Func<string>> select = null, Expression<Func<string>> orderby = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, Expression<Func<bool>> count = null)
        {
            var __workflow_expand = WorkflowExpression.Compile(expand, nameof(expand), required: false);
            var __workflow_select = WorkflowExpression.Compile(select, nameof(select), required: false);
            var __workflow_orderby = WorkflowExpression.Compile(orderby, nameof(orderby), required: false);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            var __workflow_skip = WorkflowExpression.Compile(skip, nameof(skip), required: false);
            var __workflow_count = WorkflowExpression.Compile(count, nameof(count), required: false);
            return new DeferredBodyAction<ServiceDeskCoreModelsTicketItems>(() =>
            {
                var apiCallPath = "/Ticket";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_expand != null)
                    callPayload.Queries["$expand"] = ExpressionConverter.Convert(__workflow_expand);
                if (__workflow_select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(__workflow_select);
                if (__workflow_orderby != null)
                    callPayload.Queries["$orderby"] = ExpressionConverter.Convert(__workflow_orderby);
                callPayload.Queries["$top"] = Convert.ToString(10);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                if (__workflow_skip != null)
                    callPayload.Queries["$skip"] = ExpressionConverter.Convert(__workflow_skip);
                if (__workflow_count != null)
                    callPayload.Queries["$count"] = ExpressionConverter.Convert(__workflow_count);
                callPayload.Headers["x-requested-by"] = Convert.ToString("PowerAutomate");
                return new ApiConnectionAction<ServiceDeskCoreModelsTicketItems>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tikit")]
        public IBodyWorkflowAction<ServiceDeskCoreModelsTicket> CreateTicket(Expression<Func<string>> bodyticketrequest, Expression<Func<string>> bodyticketrequesterrequesterEmail, Expression<Func<int>> bodyticketstatus, Expression<Func<int>> bodyticketpriority, Expression<Func<int>> bodyticketticketType, Expression<Func<string>> bodyticketassigneeassigneeEmail, Expression<Func<int>> bodyticketcategory = null, Expression<Func<int>> bodyticketgroup = null, Expression<Func<string>> bodyticketdueDate = null, Expression<Func<string>> bodyticketresolutionDate = null)
        {
            var __workflow_bodyticketrequest = WorkflowExpression.Compile(bodyticketrequest, nameof(bodyticketrequest), required: true);
            var __workflow_bodyticketrequesterrequesterEmail = WorkflowExpression.Compile(bodyticketrequesterrequesterEmail, nameof(bodyticketrequesterrequesterEmail), required: true);
            var __workflow_bodyticketstatus = WorkflowExpression.Compile(bodyticketstatus, nameof(bodyticketstatus), required: true);
            var __workflow_bodyticketpriority = WorkflowExpression.Compile(bodyticketpriority, nameof(bodyticketpriority), required: true);
            var __workflow_bodyticketticketType = WorkflowExpression.Compile(bodyticketticketType, nameof(bodyticketticketType), required: true);
            var __workflow_bodyticketassigneeassigneeEmail = WorkflowExpression.Compile(bodyticketassigneeassigneeEmail, nameof(bodyticketassigneeassigneeEmail), required: true);
            var __workflow_bodyticketcategory = WorkflowExpression.Compile(bodyticketcategory, nameof(bodyticketcategory), required: false);
            var __workflow_bodyticketgroup = WorkflowExpression.Compile(bodyticketgroup, nameof(bodyticketgroup), required: false);
            var __workflow_bodyticketdueDate = WorkflowExpression.Compile(bodyticketdueDate, nameof(bodyticketdueDate), required: false);
            var __workflow_bodyticketresolutionDate = WorkflowExpression.Compile(bodyticketresolutionDate, nameof(bodyticketresolutionDate), required: false);
            return new DeferredBodyAction<ServiceDeskCoreModelsTicket>(() =>
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
                ticketObject["Title"] = ExpressionConverter.ConvertO(__workflow_bodyticketrequest);
                var requesterObject = new JObject();
                var requesterObjectpropCount = 0;
                requesterObjectpropCount++;
                requesterObject["EMailAddress"] = ExpressionConverter.ConvertO(__workflow_bodyticketrequesterrequesterEmail);
                if (requesterObjectpropCount > 0)
                {
                    ticketObject["Requester"] = requesterObject;
                    ticketObjectpropCount++;
                }

                ticketObjectpropCount++;
                ticketObject["StatusId"] = ExpressionConverter.ConvertO(__workflow_bodyticketstatus);
                if (__workflow_bodyticketcategory != null)
                {
                    ticketObject["CategoryId"] = ExpressionConverter.ConvertO(__workflow_bodyticketcategory);
                    ticketObjectpropCount++;
                }

                ticketObjectpropCount++;
                ticketObject["PriorityId"] = ExpressionConverter.ConvertO(__workflow_bodyticketpriority);
                ticketObjectpropCount++;
                ticketObject["TicketTypeId"] = ExpressionConverter.ConvertO(__workflow_bodyticketticketType);
                if (__workflow_bodyticketgroup != null)
                {
                    ticketObject["SupportGroupId"] = ExpressionConverter.ConvertO(__workflow_bodyticketgroup);
                    ticketObjectpropCount++;
                }

                if (__workflow_bodyticketdueDate != null)
                {
                    ticketObject["DueDate"] = ExpressionConverter.ConvertO(__workflow_bodyticketdueDate);
                    ticketObjectpropCount++;
                }

                if (__workflow_bodyticketresolutionDate != null)
                {
                    ticketObject["ResolutionDate"] = ExpressionConverter.ConvertO(__workflow_bodyticketresolutionDate);
                    ticketObjectpropCount++;
                }

                var assigneeObject = new JObject();
                var assigneeObjectpropCount = 0;
                assigneeObjectpropCount++;
                assigneeObject["Email"] = ExpressionConverter.ConvertO(__workflow_bodyticketassigneeassigneeEmail);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tikit")]
        public IBodyWorkflowAction<ServiceDeskCoreModelsTicket> UpdateTicket(Expression<Func<int>> bodyticketenterTikitId, Expression<Func<string>> bodyticketassigneeassigneeEmail, Expression<Func<string>> bodyticketchangeRequestInformation = null, Expression<Func<string>> bodyticketrequesterrequesterEmail = null, Expression<Func<int>> bodyticketstatus = null, Expression<Func<int>> bodyticketcategory = null, Expression<Func<int>> bodyticketpriority = null, Expression<Func<int>> bodyticketticketType = null, Expression<Func<int>> bodyticketgroup = null, Expression<Func<string>> bodyticketdueDate = null, Expression<Func<string>> bodyticketresolutionDate = null)
        {
            var __workflow_bodyticketenterTikitId = WorkflowExpression.Compile(bodyticketenterTikitId, nameof(bodyticketenterTikitId), required: true);
            var __workflow_bodyticketassigneeassigneeEmail = WorkflowExpression.Compile(bodyticketassigneeassigneeEmail, nameof(bodyticketassigneeassigneeEmail), required: true);
            var __workflow_bodyticketchangeRequestInformation = WorkflowExpression.Compile(bodyticketchangeRequestInformation, nameof(bodyticketchangeRequestInformation), required: false);
            var __workflow_bodyticketrequesterrequesterEmail = WorkflowExpression.Compile(bodyticketrequesterrequesterEmail, nameof(bodyticketrequesterrequesterEmail), required: false);
            var __workflow_bodyticketstatus = WorkflowExpression.Compile(bodyticketstatus, nameof(bodyticketstatus), required: false);
            var __workflow_bodyticketcategory = WorkflowExpression.Compile(bodyticketcategory, nameof(bodyticketcategory), required: false);
            var __workflow_bodyticketpriority = WorkflowExpression.Compile(bodyticketpriority, nameof(bodyticketpriority), required: false);
            var __workflow_bodyticketticketType = WorkflowExpression.Compile(bodyticketticketType, nameof(bodyticketticketType), required: false);
            var __workflow_bodyticketgroup = WorkflowExpression.Compile(bodyticketgroup, nameof(bodyticketgroup), required: false);
            var __workflow_bodyticketdueDate = WorkflowExpression.Compile(bodyticketdueDate, nameof(bodyticketdueDate), required: false);
            var __workflow_bodyticketresolutionDate = WorkflowExpression.Compile(bodyticketresolutionDate, nameof(bodyticketresolutionDate), required: false);
            return new DeferredBodyAction<ServiceDeskCoreModelsTicket>(() =>
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
                ticketObject["Id"] = ExpressionConverter.ConvertO(__workflow_bodyticketenterTikitId);
                if (__workflow_bodyticketchangeRequestInformation != null)
                {
                    ticketObject["Title"] = ExpressionConverter.ConvertO(__workflow_bodyticketchangeRequestInformation);
                    ticketObjectpropCount++;
                }

                var requesterObject = new JObject();
                var requesterObjectpropCount = 0;
                if (__workflow_bodyticketrequesterrequesterEmail != null)
                {
                    requesterObject["EMailAddress"] = ExpressionConverter.ConvertO(__workflow_bodyticketrequesterrequesterEmail);
                    requesterObjectpropCount++;
                }

                if (requesterObjectpropCount > 0)
                {
                    ticketObject["Requester"] = requesterObject;
                    ticketObjectpropCount++;
                }

                if (__workflow_bodyticketstatus != null)
                {
                    ticketObject["StatusId"] = ExpressionConverter.ConvertO(__workflow_bodyticketstatus);
                    ticketObjectpropCount++;
                }

                if (__workflow_bodyticketcategory != null)
                {
                    ticketObject["CategoryId"] = ExpressionConverter.ConvertO(__workflow_bodyticketcategory);
                    ticketObjectpropCount++;
                }

                if (__workflow_bodyticketpriority != null)
                {
                    ticketObject["PriorityId"] = ExpressionConverter.ConvertO(__workflow_bodyticketpriority);
                    ticketObjectpropCount++;
                }

                if (__workflow_bodyticketticketType != null)
                {
                    ticketObject["TicketTypeId"] = ExpressionConverter.ConvertO(__workflow_bodyticketticketType);
                    ticketObjectpropCount++;
                }

                if (__workflow_bodyticketgroup != null)
                {
                    ticketObject["SupportGroupId"] = ExpressionConverter.ConvertO(__workflow_bodyticketgroup);
                    ticketObjectpropCount++;
                }

                if (__workflow_bodyticketdueDate != null)
                {
                    ticketObject["DueDate"] = ExpressionConverter.ConvertO(__workflow_bodyticketdueDate);
                    ticketObjectpropCount++;
                }

                if (__workflow_bodyticketresolutionDate != null)
                {
                    ticketObject["ResolutionDate"] = ExpressionConverter.ConvertO(__workflow_bodyticketresolutionDate);
                    ticketObjectpropCount++;
                }

                var assigneeObject = new JObject();
                var assigneeObjectpropCount = 0;
                assigneeObjectpropCount++;
                assigneeObject["Email"] = ExpressionConverter.ConvertO(__workflow_bodyticketassigneeassigneeEmail);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tikit")]
        public IBodyWorkflowAction<ServiceDeskCoreModelsTicket> GetOneTicket(Expression<Func<string>> id, Expression<Func<string>> select = null, Expression<Func<string>> expand = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_select = WorkflowExpression.Compile(select, nameof(select), required: false);
            var __workflow_expand = WorkflowExpression.Compile(expand, nameof(expand), required: false);
            return new DeferredBodyAction<ServiceDeskCoreModelsTicket>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/ticket/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(__workflow_select);
                callPayload.Queries["$expand"] = Convert.ToString("Requester,Assignee");
                if (__workflow_expand != null)
                    callPayload.Queries["$expand"] = ExpressionConverter.Convert(__workflow_expand);
                callPayload.Headers["x-requested-by"] = Convert.ToString("PowerAutomate");
                return new ApiConnectionAction<ServiceDeskCoreModelsTicket>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tikit")]
        public IBodyWorkflowAction<AddCommentResponse> AddComment(Expression<Func<string>> id, Expression<Func<string>> bodycommentbody = null, Expression<Func<bool>> bodycommentisPublic = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_bodycommentbody = WorkflowExpression.Compile(bodycommentbody, nameof(bodycommentbody), required: false);
            var __workflow_bodycommentisPublic = WorkflowExpression.Compile(bodycommentisPublic, nameof(bodycommentisPublic), required: false);
            return new DeferredBodyAction<AddCommentResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/ticket({0})/AddComment", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-requested-by"] = Convert.ToString("PowerAutomate");
                var body = new JObject();
                var bodypropCount = 0;
                var commentObject = new JObject();
                var commentObjectpropCount = 0;
                if (__workflow_bodycommentbody != null)
                {
                    commentObject["Body"] = ExpressionConverter.ConvertO(__workflow_bodycommentbody);
                    commentObjectpropCount++;
                }

                if (__workflow_bodycommentisPublic != null)
                {
                    commentObject["IsPublic"] = ExpressionConverter.ConvertO(__workflow_bodycommentisPublic);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tikit")]
        public IBodyWorkflowAction<GetFileAttachedResponse> GetFileAttached(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<GetFileAttachedResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/ticket/{0}/FileAttachments", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetFileAttachedResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tikit")]
        public IBodyWorkflowAction<GetTasksResponse> GetTasks(Expression<Func<string>> id, Expression<Func<string>> lifecycle = null, Expression<Func<string>> phase = null, Expression<Func<string>> taskName = null, Expression<Func<string>> assignee = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_lifecycle = WorkflowExpression.Compile(lifecycle, nameof(lifecycle), required: false);
            var __workflow_phase = WorkflowExpression.Compile(phase, nameof(phase), required: false);
            var __workflow_taskName = WorkflowExpression.Compile(taskName, nameof(taskName), required: false);
            var __workflow_assignee = WorkflowExpression.Compile(assignee, nameof(assignee), required: false);
            return new DeferredBodyAction<GetTasksResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/Ticket({0})/GetTasks", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_lifecycle != null)
                    callPayload.Queries["Lifecycle"] = ExpressionConverter.Convert(__workflow_lifecycle);
                if (__workflow_phase != null)
                    callPayload.Queries["Phase"] = ExpressionConverter.Convert(__workflow_phase);
                if (__workflow_taskName != null)
                    callPayload.Queries["TaskName"] = ExpressionConverter.Convert(__workflow_taskName);
                if (__workflow_assignee != null)
                    callPayload.Queries["Assignee"] = ExpressionConverter.Convert(__workflow_assignee);
                callPayload.Headers["x-requested-by"] = Convert.ToString("PowerAutomate");
                return new ApiConnectionAction<GetTasksResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tikit")]
        public IBodyWorkflowAction<GetPowerAutomateTasksResponse> GetPowerAutomateTasks(Expression<Func<string>> id, Expression<Func<string>> lifecycle = null, Expression<Func<string>> phase = null, Expression<Func<string>> taskName = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_lifecycle = WorkflowExpression.Compile(lifecycle, nameof(lifecycle), required: false);
            var __workflow_phase = WorkflowExpression.Compile(phase, nameof(phase), required: false);
            var __workflow_taskName = WorkflowExpression.Compile(taskName, nameof(taskName), required: false);
            return new DeferredBodyAction<GetPowerAutomateTasksResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/Ticket({0})/GetPowerAutomateTasks", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_lifecycle != null)
                    callPayload.Queries["Lifecycle"] = ExpressionConverter.Convert(__workflow_lifecycle);
                if (__workflow_phase != null)
                    callPayload.Queries["Phase"] = ExpressionConverter.Convert(__workflow_phase);
                if (__workflow_taskName != null)
                    callPayload.Queries["TaskName"] = ExpressionConverter.Convert(__workflow_taskName);
                callPayload.Headers["x-requested-by"] = Convert.ToString("PowerAutomate");
                return new ApiConnectionAction<GetPowerAutomateTasksResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tikit")]
        public IBodyWorkflowAction<ServiceDeskCoreModelsTicketTask> AddTask(Expression<Func<string>> id, Expression<Func<string>> bodytitle, Expression<Func<string>> bodylifecycle = null, Expression<Func<string>> bodyphase = null, Expression<Func<string>> bodyassignee = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_bodytitle = WorkflowExpression.Compile(bodytitle, nameof(bodytitle), required: true);
            var __workflow_bodylifecycle = WorkflowExpression.Compile(bodylifecycle, nameof(bodylifecycle), required: false);
            var __workflow_bodyphase = WorkflowExpression.Compile(bodyphase, nameof(bodyphase), required: false);
            var __workflow_bodyassignee = WorkflowExpression.Compile(bodyassignee, nameof(bodyassignee), required: false);
            return new DeferredBodyAction<ServiceDeskCoreModelsTicketTask>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/Ticket({0})/AddTask", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-requested-by"] = Convert.ToString("PowerAutomate");
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodylifecycle != null)
                {
                    body["Lifecycle"] = ExpressionConverter.ConvertO(__workflow_bodylifecycle);
                    bodypropCount++;
                }

                if (__workflow_bodyphase != null)
                {
                    body["PhaseId"] = ExpressionConverter.ConvertO(__workflow_bodyphase);
                    bodypropCount++;
                }

                bodypropCount++;
                body["Title"] = ExpressionConverter.ConvertO(__workflow_bodytitle);
                if (__workflow_bodyassignee != null)
                {
                    body["Assignee"] = ExpressionConverter.ConvertO(__workflow_bodyassignee);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ServiceDeskCoreModelsTicketTask>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tikit")]
        public IBodyWorkflowAction<ServiceDeskCoreModelsTicketTask> UpdateTask(Expression<Func<string>> id, Expression<Func<string>> bodytitle = null, Expression<Func<string>> bodyassignee = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_bodytitle = WorkflowExpression.Compile(bodytitle, nameof(bodytitle), required: false);
            var __workflow_bodyassignee = WorkflowExpression.Compile(bodyassignee, nameof(bodyassignee), required: false);
            return new DeferredBodyAction<ServiceDeskCoreModelsTicketTask>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/TicketTask({0})/UpdateTask", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-requested-by"] = Convert.ToString("PowerAutomate");
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodytitle != null)
                {
                    body["Title"] = ExpressionConverter.ConvertO(__workflow_bodytitle);
                    bodypropCount++;
                }

                if (__workflow_bodyassignee != null)
                {
                    body["Assignee"] = ExpressionConverter.ConvertO(__workflow_bodyassignee);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ServiceDeskCoreModelsTicketTask>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tikit")]
        public IBodyWorkflowAction<ServiceDeskCoreModelsPowerAutomateTask> UpdatePowerAutomateTask(Expression<Func<string>> id, Expression<Func<string>> bodystatusId = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_bodystatusId = WorkflowExpression.Compile(bodystatusId, nameof(bodystatusId), required: false);
            return new DeferredBodyAction<ServiceDeskCoreModelsPowerAutomateTask>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/TicketTask({0})/UpdatePowerAutomateTask", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-requested-by"] = Convert.ToString("PowerAutomate");
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodystatusId != null)
                {
                    body["StatusId"] = ExpressionConverter.ConvertO(__workflow_bodystatusId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ServiceDeskCoreModelsPowerAutomateTask>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tikit")]
        public IBodyWorkflowAction<GetApprovalsResponse> GetApprovals(Expression<Func<string>> id, Expression<Func<string>> lifecycle = null, Expression<Func<string>> phase = null, Expression<Func<string>> approvalName = null, Expression<Func<string>> approvers = null, Expression<Func<string>> additionalDetails = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_lifecycle = WorkflowExpression.Compile(lifecycle, nameof(lifecycle), required: false);
            var __workflow_phase = WorkflowExpression.Compile(phase, nameof(phase), required: false);
            var __workflow_approvalName = WorkflowExpression.Compile(approvalName, nameof(approvalName), required: false);
            var __workflow_approvers = WorkflowExpression.Compile(approvers, nameof(approvers), required: false);
            var __workflow_additionalDetails = WorkflowExpression.Compile(additionalDetails, nameof(additionalDetails), required: false);
            return new DeferredBodyAction<GetApprovalsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/Ticket({0})/GetApprovals", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_lifecycle != null)
                    callPayload.Queries["Lifecycle"] = ExpressionConverter.Convert(__workflow_lifecycle);
                if (__workflow_phase != null)
                    callPayload.Queries["Phase"] = ExpressionConverter.Convert(__workflow_phase);
                if (__workflow_approvalName != null)
                    callPayload.Queries["ApprovalName"] = ExpressionConverter.Convert(__workflow_approvalName);
                if (__workflow_approvers != null)
                    callPayload.Queries["Approvers"] = ExpressionConverter.Convert(__workflow_approvers);
                if (__workflow_additionalDetails != null)
                    callPayload.Queries["AdditionalDetails"] = ExpressionConverter.Convert(__workflow_additionalDetails);
                callPayload.Headers["x-requested-by"] = Convert.ToString("PowerAutomate");
                return new ApiConnectionAction<GetApprovalsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tikit")]
        public IBodyWorkflowAction<ServiceDeskCoreModelsApprovals> UpdateApproval(Expression<Func<string>> id, Expression<Func<string>> bodytitle = null, Expression<Func<string>> bodyadditionalDetails = null, Expression<Func<bodyrequiredByAllInput>> bodyrequiredByAll = null, Expression<Func<string>> bodyapprovers = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_bodytitle = WorkflowExpression.Compile(bodytitle, nameof(bodytitle), required: false);
            var __workflow_bodyadditionalDetails = WorkflowExpression.Compile(bodyadditionalDetails, nameof(bodyadditionalDetails), required: false);
            var __workflow_bodyrequiredByAll = WorkflowExpression.Compile(bodyrequiredByAll, nameof(bodyrequiredByAll), required: false);
            var __workflow_bodyapprovers = WorkflowExpression.Compile(bodyapprovers, nameof(bodyapprovers), required: false);
            return new DeferredBodyAction<ServiceDeskCoreModelsApprovals>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/Approvals({0})/UpdateApproval", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-requested-by"] = Convert.ToString("PowerAutomate");
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodytitle != null)
                {
                    body["Title"] = ExpressionConverter.ConvertO(__workflow_bodytitle);
                    bodypropCount++;
                }

                if (__workflow_bodyadditionalDetails != null)
                {
                    body["AdditionalDetails"] = ExpressionConverter.ConvertO(__workflow_bodyadditionalDetails);
                    bodypropCount++;
                }

                if (__workflow_bodyrequiredByAll != null)
                {
                    body["RequiredByAll"] = ExpressionConverter.ConvertO(__workflow_bodyrequiredByAll);
                    bodypropCount++;
                }

                if (__workflow_bodyapprovers != null)
                {
                    body["Approvers"] = ExpressionConverter.ConvertO(__workflow_bodyapprovers);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ServiceDeskCoreModelsApprovals>(callPayload);
            });
        }
    }

    public class TikitTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<ServiceDeskCoreActionsAddWebhookWebhookParam> AddTicketWebhookTrigger(Expression<Func<string>> bodywebHookrequesters = null, Expression<Func<string>> bodywebHookassignees = null, Expression<Func<string>> bodywebHooktitle = null, Expression<Func<string>> bodywebHookstatus = null, Expression<Func<bodywebHookpriorityInput>> bodywebHookpriority = null, Expression<Func<int>> bodywebHookgroup = null, Expression<Func<int>> bodywebHookselectTemplate = null, FlowRecurrence recurrence = null)
        {
            var __workflow_bodywebHookrequesters = WorkflowExpression.Compile(bodywebHookrequesters, nameof(bodywebHookrequesters), required: false);
            var __workflow_bodywebHookassignees = WorkflowExpression.Compile(bodywebHookassignees, nameof(bodywebHookassignees), required: false);
            var __workflow_bodywebHooktitle = WorkflowExpression.Compile(bodywebHooktitle, nameof(bodywebHooktitle), required: false);
            var __workflow_bodywebHookstatus = WorkflowExpression.Compile(bodywebHookstatus, nameof(bodywebHookstatus), required: false);
            var __workflow_bodywebHookpriority = WorkflowExpression.Compile(bodywebHookpriority, nameof(bodywebHookpriority), required: false);
            var __workflow_bodywebHookgroup = WorkflowExpression.Compile(bodywebHookgroup, nameof(bodywebHookgroup), required: false);
            var __workflow_bodywebHookselectTemplate = WorkflowExpression.Compile(bodywebHookselectTemplate, nameof(bodywebHookselectTemplate), required: false);
            return new DeferredBodyTrigger<ServiceDeskCoreActionsAddWebhookWebhookParam>(() =>
            {
                var apiCallPath = "/AddTicketWebhook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                var webHookObject = new JObject();
                var webHookObjectpropCount = 0;
                webHookObject["URL"] = "#{listCallbackUrl()}";
                webHookObjectpropCount++;
                if (__workflow_bodywebHookrequesters != null)
                {
                    webHookObject["Requesters"] = ExpressionConverter.ConvertO(__workflow_bodywebHookrequesters);
                    webHookObjectpropCount++;
                }

                if (__workflow_bodywebHookassignees != null)
                {
                    webHookObject["Assignees"] = ExpressionConverter.ConvertO(__workflow_bodywebHookassignees);
                    webHookObjectpropCount++;
                }

                if (__workflow_bodywebHooktitle != null)
                {
                    webHookObject["Title"] = ExpressionConverter.ConvertO(__workflow_bodywebHooktitle);
                    webHookObjectpropCount++;
                }

                if (__workflow_bodywebHookstatus != null)
                {
                    if (__workflow_bodywebHookstatus != null)
                    {
                        webHookObject["Status"] = ExpressionConverter.ConvertO(__workflow_bodywebHookstatus);
                        webHookObjectpropCount++;
                    }

                    webHookObjectpropCount++;
                }
                else
                {
                    webHookObject["Status"] = "Any";
                    webHookObjectpropCount++;
                }

                if (__workflow_bodywebHookpriority != null)
                {
                    if (__workflow_bodywebHookpriority != null)
                    {
                        webHookObject["Priority"] = ExpressionConverter.ConvertO(__workflow_bodywebHookpriority);
                        webHookObjectpropCount++;
                    }

                    webHookObjectpropCount++;
                }
                else
                {
                    webHookObject["Priority"] = "Any";
                    webHookObjectpropCount++;
                }

                if (__workflow_bodywebHookgroup != null)
                {
                    webHookObject["GroupId"] = ExpressionConverter.ConvertO(__workflow_bodywebHookgroup);
                    webHookObjectpropCount++;
                }

                if (__workflow_bodywebHookselectTemplate != null)
                {
                    webHookObject["TemplateId"] = ExpressionConverter.ConvertO(__workflow_bodywebHookselectTemplate);
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

                return new ApiConnectionTrigger<ServiceDeskCoreActionsAddWebhookWebhookParam>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<ServiceDeskCoreActionsAddWebhookWebhookParam> UpdateTicketWebhookTrigger(Expression<Func<string>> bodywebHookrequesters = null, Expression<Func<string>> bodywebHookassignees = null, Expression<Func<string>> bodywebHooktitle = null, Expression<Func<string>> bodywebHookstatus = null, Expression<Func<bodywebHookpriorityInput>> bodywebHookpriority = null, Expression<Func<int>> bodywebHookgroup = null, Expression<Func<int>> bodywebHookselectTemplate = null, FlowRecurrence recurrence = null)
        {
            var __workflow_bodywebHookrequesters = WorkflowExpression.Compile(bodywebHookrequesters, nameof(bodywebHookrequesters), required: false);
            var __workflow_bodywebHookassignees = WorkflowExpression.Compile(bodywebHookassignees, nameof(bodywebHookassignees), required: false);
            var __workflow_bodywebHooktitle = WorkflowExpression.Compile(bodywebHooktitle, nameof(bodywebHooktitle), required: false);
            var __workflow_bodywebHookstatus = WorkflowExpression.Compile(bodywebHookstatus, nameof(bodywebHookstatus), required: false);
            var __workflow_bodywebHookpriority = WorkflowExpression.Compile(bodywebHookpriority, nameof(bodywebHookpriority), required: false);
            var __workflow_bodywebHookgroup = WorkflowExpression.Compile(bodywebHookgroup, nameof(bodywebHookgroup), required: false);
            var __workflow_bodywebHookselectTemplate = WorkflowExpression.Compile(bodywebHookselectTemplate, nameof(bodywebHookselectTemplate), required: false);
            return new DeferredBodyTrigger<ServiceDeskCoreActionsAddWebhookWebhookParam>(() =>
            {
                var apiCallPath = "/UpdateTicketWebhook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                var webHookObject = new JObject();
                var webHookObjectpropCount = 0;
                webHookObject["URL"] = "#{listCallbackUrl()}";
                webHookObjectpropCount++;
                if (__workflow_bodywebHookrequesters != null)
                {
                    webHookObject["Requesters"] = ExpressionConverter.ConvertO(__workflow_bodywebHookrequesters);
                    webHookObjectpropCount++;
                }

                if (__workflow_bodywebHookassignees != null)
                {
                    webHookObject["Assignees"] = ExpressionConverter.ConvertO(__workflow_bodywebHookassignees);
                    webHookObjectpropCount++;
                }

                if (__workflow_bodywebHooktitle != null)
                {
                    webHookObject["Title"] = ExpressionConverter.ConvertO(__workflow_bodywebHooktitle);
                    webHookObjectpropCount++;
                }

                if (__workflow_bodywebHookstatus != null)
                {
                    if (__workflow_bodywebHookstatus != null)
                    {
                        webHookObject["Status"] = ExpressionConverter.ConvertO(__workflow_bodywebHookstatus);
                        webHookObjectpropCount++;
                    }

                    webHookObjectpropCount++;
                }
                else
                {
                    webHookObject["Status"] = "Any";
                    webHookObjectpropCount++;
                }

                if (__workflow_bodywebHookpriority != null)
                {
                    if (__workflow_bodywebHookpriority != null)
                    {
                        webHookObject["Priority"] = ExpressionConverter.ConvertO(__workflow_bodywebHookpriority);
                        webHookObjectpropCount++;
                    }

                    webHookObjectpropCount++;
                }
                else
                {
                    webHookObject["Priority"] = "Any";
                    webHookObjectpropCount++;
                }

                if (__workflow_bodywebHookgroup != null)
                {
                    webHookObject["GroupId"] = ExpressionConverter.ConvertO(__workflow_bodywebHookgroup);
                    webHookObjectpropCount++;
                }

                if (__workflow_bodywebHookselectTemplate != null)
                {
                    webHookObject["TemplateId"] = ExpressionConverter.ConvertO(__workflow_bodywebHookselectTemplate);
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

                return new ApiConnectionTrigger<ServiceDeskCoreActionsAddWebhookWebhookParam>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<ServiceDeskCoreActionsAddWebhookWebhookParam> AddCommentTicketWebhook(Expression<Func<string>> bodywebHookcommenter = null, Expression<Func<string>> bodywebHookcommentStringContain = null, Expression<Func<bodywebHookisPublicCommentInput>> bodywebHookisPublicComment = null, FlowRecurrence recurrence = null)
        {
            var __workflow_bodywebHookcommenter = WorkflowExpression.Compile(bodywebHookcommenter, nameof(bodywebHookcommenter), required: false);
            var __workflow_bodywebHookcommentStringContain = WorkflowExpression.Compile(bodywebHookcommentStringContain, nameof(bodywebHookcommentStringContain), required: false);
            var __workflow_bodywebHookisPublicComment = WorkflowExpression.Compile(bodywebHookisPublicComment, nameof(bodywebHookisPublicComment), required: false);
            return new DeferredBodyTrigger<ServiceDeskCoreActionsAddWebhookWebhookParam>(() =>
            {
                var apiCallPath = "/AddCommentTicketWebhook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                var webHookObject = new JObject();
                var webHookObjectpropCount = 0;
                webHookObject["URL"] = "#{listCallbackUrl()}";
                webHookObjectpropCount++;
                if (__workflow_bodywebHookcommenter != null)
                {
                    webHookObject["Commenter"] = ExpressionConverter.ConvertO(__workflow_bodywebHookcommenter);
                    webHookObjectpropCount++;
                }

                if (__workflow_bodywebHookcommentStringContain != null)
                {
                    webHookObject["CommentStringContain"] = ExpressionConverter.ConvertO(__workflow_bodywebHookcommentStringContain);
                    webHookObjectpropCount++;
                }

                if (__workflow_bodywebHookisPublicComment != null)
                {
                    if (__workflow_bodywebHookisPublicComment != null)
                    {
                        webHookObject["IsPublicComment"] = ExpressionConverter.ConvertO(__workflow_bodywebHookisPublicComment);
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

                return new ApiConnectionTrigger<ServiceDeskCoreActionsAddWebhookWebhookParam>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<ServiceDeskCoreModelsTicketTask> ActivatePowerAutomateTaskWebhook(Expression<Func<string>> bodywebHooklifecycleId = null, Expression<Func<int>> bodywebHooklifecyclePhaseId = null, Expression<Func<string>> bodywebHooklifecyclePowerAutomateName = null, FlowRecurrence recurrence = null)
        {
            var __workflow_bodywebHooklifecycleId = WorkflowExpression.Compile(bodywebHooklifecycleId, nameof(bodywebHooklifecycleId), required: false);
            var __workflow_bodywebHooklifecyclePhaseId = WorkflowExpression.Compile(bodywebHooklifecyclePhaseId, nameof(bodywebHooklifecyclePhaseId), required: false);
            var __workflow_bodywebHooklifecyclePowerAutomateName = WorkflowExpression.Compile(bodywebHooklifecyclePowerAutomateName, nameof(bodywebHooklifecyclePowerAutomateName), required: false);
            return new DeferredBodyTrigger<ServiceDeskCoreModelsTicketTask>(() =>
            {
                var apiCallPath = "/ActivatePowerAutomateTaskWebhook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                var webHookObject = new JObject();
                var webHookObjectpropCount = 0;
                webHookObject["URL"] = "#{listCallbackUrl()}";
                webHookObjectpropCount++;
                if (__workflow_bodywebHooklifecycleId != null)
                {
                    webHookObject["LifecycleId"] = ExpressionConverter.ConvertO(__workflow_bodywebHooklifecycleId);
                    webHookObjectpropCount++;
                }

                if (__workflow_bodywebHooklifecyclePhaseId != null)
                {
                    webHookObject["LifecyclePhaseId"] = ExpressionConverter.ConvertO(__workflow_bodywebHooklifecyclePhaseId);
                    webHookObjectpropCount++;
                }

                if (__workflow_bodywebHooklifecyclePowerAutomateName != null)
                {
                    webHookObject["LifecyclePowerAutomateName"] = ExpressionConverter.ConvertO(__workflow_bodywebHooklifecyclePowerAutomateName);
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

                return new ApiConnectionTrigger<ServiceDeskCoreModelsTicketTask>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<ServiceDeskCoreActionsAddWebhookWebhookParam> ChangeLifecyclePhaseWebhook(Expression<Func<string>> bodywebHooklifecycleId = null, Expression<Func<int>> bodywebHooklifecyclePhaseId = null, FlowRecurrence recurrence = null)
        {
            var __workflow_bodywebHooklifecycleId = WorkflowExpression.Compile(bodywebHooklifecycleId, nameof(bodywebHooklifecycleId), required: false);
            var __workflow_bodywebHooklifecyclePhaseId = WorkflowExpression.Compile(bodywebHooklifecyclePhaseId, nameof(bodywebHooklifecyclePhaseId), required: false);
            return new DeferredBodyTrigger<ServiceDeskCoreActionsAddWebhookWebhookParam>(() =>
            {
                var apiCallPath = "/ChangeLifecyclePhaseWebhook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                var webHookObject = new JObject();
                var webHookObjectpropCount = 0;
                webHookObject["URL"] = "#{listCallbackUrl()}";
                webHookObjectpropCount++;
                if (__workflow_bodywebHooklifecycleId != null)
                {
                    webHookObject["LifecycleId"] = ExpressionConverter.ConvertO(__workflow_bodywebHooklifecycleId);
                    webHookObjectpropCount++;
                }

                if (__workflow_bodywebHooklifecyclePhaseId != null)
                {
                    webHookObject["LifecyclePhaseId"] = ExpressionConverter.ConvertO(__workflow_bodywebHooklifecyclePhaseId);
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

                return new ApiConnectionTrigger<ServiceDeskCoreActionsAddWebhookWebhookParam>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<ServiceDeskCoreActionsAddWebhookWebhookParam> EngageLifecycleTransitionWebhook(Expression<Func<string>> bodywebHooklifecycleId = null, Expression<Func<int>> bodywebHooklifecyclePhaseId = null, Expression<Func<int>> bodywebHooklifecycleTransitionId = null, FlowRecurrence recurrence = null)
        {
            var __workflow_bodywebHooklifecycleId = WorkflowExpression.Compile(bodywebHooklifecycleId, nameof(bodywebHooklifecycleId), required: false);
            var __workflow_bodywebHooklifecyclePhaseId = WorkflowExpression.Compile(bodywebHooklifecyclePhaseId, nameof(bodywebHooklifecyclePhaseId), required: false);
            var __workflow_bodywebHooklifecycleTransitionId = WorkflowExpression.Compile(bodywebHooklifecycleTransitionId, nameof(bodywebHooklifecycleTransitionId), required: false);
            return new DeferredBodyTrigger<ServiceDeskCoreActionsAddWebhookWebhookParam>(() =>
            {
                var apiCallPath = "/EngageLifecycleTransitionWebhook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                var webHookObject = new JObject();
                var webHookObjectpropCount = 0;
                webHookObject["URL"] = "#{listCallbackUrl()}";
                webHookObjectpropCount++;
                if (__workflow_bodywebHooklifecycleId != null)
                {
                    webHookObject["LifecycleId"] = ExpressionConverter.ConvertO(__workflow_bodywebHooklifecycleId);
                    webHookObjectpropCount++;
                }

                if (__workflow_bodywebHooklifecyclePhaseId != null)
                {
                    webHookObject["LifecyclePhaseId"] = ExpressionConverter.ConvertO(__workflow_bodywebHooklifecyclePhaseId);
                    webHookObjectpropCount++;
                }

                if (__workflow_bodywebHooklifecycleTransitionId != null)
                {
                    webHookObject["LifecycleTransitionId"] = ExpressionConverter.ConvertO(__workflow_bodywebHooklifecycleTransitionId);
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

                return new ApiConnectionTrigger<ServiceDeskCoreActionsAddWebhookWebhookParam>(callPayload, recurrence: recurrence);
            });
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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
