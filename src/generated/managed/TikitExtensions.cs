//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Tikit
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class TikitActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tikit")]
        [WorkflowExpressionFactory(nameof(__BuildGetAllTickets))]
        public IBodyWorkflowAction<ServiceDeskCoreModelsTicketItems> GetAllTickets([WorkflowExpression] Func<string> expand = null, [WorkflowExpression] Func<string> select = null, [WorkflowExpression] Func<string> orderby = null, [WorkflowExpression] Func<int> top = null, [WorkflowExpression] Func<int> skip = null, [WorkflowExpression] Func<bool> count = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tikit")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ServiceDeskCoreModelsTicketItems> __BuildGetAllTickets(WorkflowExpression<string> expand = null, WorkflowExpression<string> select = null, WorkflowExpression<string> orderby = null, WorkflowExpression<int> top = null, WorkflowExpression<int> skip = null, WorkflowExpression<bool> count = null)
        {
            WorkflowExpression.Validate(expand, nameof(expand), required: false);
            WorkflowExpression.Validate(select, nameof(select), required: false);
            WorkflowExpression.Validate(orderby, nameof(orderby), required: false);
            WorkflowExpression.Validate(top, nameof(top), required: false);
            WorkflowExpression.Validate(skip, nameof(skip), required: false);
            WorkflowExpression.Validate(count, nameof(count), required: false);
            return new DeferredBodyAction<ServiceDeskCoreModelsTicketItems>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tikit")]
        [WorkflowExpressionFactory(nameof(__BuildCreateTicket))]
        public IBodyWorkflowAction<ServiceDeskCoreModelsTicket> CreateTicket([WorkflowExpression] Func<string> bodyticketrequest, [WorkflowExpression] Func<string> bodyticketrequesterrequesterEmail, [WorkflowExpression] Func<int> bodyticketstatus, [WorkflowExpression] Func<int> bodyticketpriority, [WorkflowExpression] Func<int> bodyticketticketType, [WorkflowExpression] Func<string> bodyticketassigneeassigneeEmail, [WorkflowExpression] Func<int> bodyticketcategory = null, [WorkflowExpression] Func<int> bodyticketgroup = null, [WorkflowExpression] Func<string> bodyticketdueDate = null, [WorkflowExpression] Func<string> bodyticketresolutionDate = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tikit")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ServiceDeskCoreModelsTicket> __BuildCreateTicket(WorkflowExpression<string> bodyticketrequest, WorkflowExpression<string> bodyticketrequesterrequesterEmail, WorkflowExpression<int> bodyticketstatus, WorkflowExpression<int> bodyticketpriority, WorkflowExpression<int> bodyticketticketType, WorkflowExpression<string> bodyticketassigneeassigneeEmail, WorkflowExpression<int> bodyticketcategory = null, WorkflowExpression<int> bodyticketgroup = null, WorkflowExpression<string> bodyticketdueDate = null, WorkflowExpression<string> bodyticketresolutionDate = null)
        {
            WorkflowExpression.Validate(bodyticketrequest, nameof(bodyticketrequest), required: true);
            WorkflowExpression.Validate(bodyticketrequesterrequesterEmail, nameof(bodyticketrequesterrequesterEmail), required: true);
            WorkflowExpression.Validate(bodyticketstatus, nameof(bodyticketstatus), required: true);
            WorkflowExpression.Validate(bodyticketpriority, nameof(bodyticketpriority), required: true);
            WorkflowExpression.Validate(bodyticketticketType, nameof(bodyticketticketType), required: true);
            WorkflowExpression.Validate(bodyticketassigneeassigneeEmail, nameof(bodyticketassigneeassigneeEmail), required: true);
            WorkflowExpression.Validate(bodyticketcategory, nameof(bodyticketcategory), required: false);
            WorkflowExpression.Validate(bodyticketgroup, nameof(bodyticketgroup), required: false);
            WorkflowExpression.Validate(bodyticketdueDate, nameof(bodyticketdueDate), required: false);
            WorkflowExpression.Validate(bodyticketresolutionDate, nameof(bodyticketresolutionDate), required: false);
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
                ticketObject["Title"] = ExpressionConverter.ConvertO(bodyticketrequest);
                var requesterObject = new JObject();
                var requesterObjectpropCount = 0;
                requesterObjectpropCount++;
                requesterObject["EMailAddress"] = ExpressionConverter.ConvertO(bodyticketrequesterrequesterEmail);
                if (requesterObjectpropCount > 0)
                {
                    ticketObject["Requester"] = requesterObject;
                    ticketObjectpropCount++;
                }

                ticketObjectpropCount++;
                ticketObject["StatusId"] = ExpressionConverter.ConvertO(bodyticketstatus);
                if (bodyticketcategory != null)
                {
                    ticketObject["CategoryId"] = ExpressionConverter.ConvertO(bodyticketcategory);
                    ticketObjectpropCount++;
                }

                ticketObjectpropCount++;
                ticketObject["PriorityId"] = ExpressionConverter.ConvertO(bodyticketpriority);
                ticketObjectpropCount++;
                ticketObject["TicketTypeId"] = ExpressionConverter.ConvertO(bodyticketticketType);
                if (bodyticketgroup != null)
                {
                    ticketObject["SupportGroupId"] = ExpressionConverter.ConvertO(bodyticketgroup);
                    ticketObjectpropCount++;
                }

                if (bodyticketdueDate != null)
                {
                    ticketObject["DueDate"] = ExpressionConverter.ConvertO(bodyticketdueDate);
                    ticketObjectpropCount++;
                }

                if (bodyticketresolutionDate != null)
                {
                    ticketObject["ResolutionDate"] = ExpressionConverter.ConvertO(bodyticketresolutionDate);
                    ticketObjectpropCount++;
                }

                var assigneeObject = new JObject();
                var assigneeObjectpropCount = 0;
                assigneeObjectpropCount++;
                assigneeObject["Email"] = ExpressionConverter.ConvertO(bodyticketassigneeassigneeEmail);
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
        [WorkflowExpressionFactory(nameof(__BuildUpdateTicket))]
        public IBodyWorkflowAction<ServiceDeskCoreModelsTicket> UpdateTicket([WorkflowExpression] Func<int> bodyticketenterTikitId, [WorkflowExpression] Func<string> bodyticketassigneeassigneeEmail, [WorkflowExpression] Func<string> bodyticketchangeRequestInformation = null, [WorkflowExpression] Func<string> bodyticketrequesterrequesterEmail = null, [WorkflowExpression] Func<int> bodyticketstatus = null, [WorkflowExpression] Func<int> bodyticketcategory = null, [WorkflowExpression] Func<int> bodyticketpriority = null, [WorkflowExpression] Func<int> bodyticketticketType = null, [WorkflowExpression] Func<int> bodyticketgroup = null, [WorkflowExpression] Func<string> bodyticketdueDate = null, [WorkflowExpression] Func<string> bodyticketresolutionDate = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tikit")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ServiceDeskCoreModelsTicket> __BuildUpdateTicket(WorkflowExpression<int> bodyticketenterTikitId, WorkflowExpression<string> bodyticketassigneeassigneeEmail, WorkflowExpression<string> bodyticketchangeRequestInformation = null, WorkflowExpression<string> bodyticketrequesterrequesterEmail = null, WorkflowExpression<int> bodyticketstatus = null, WorkflowExpression<int> bodyticketcategory = null, WorkflowExpression<int> bodyticketpriority = null, WorkflowExpression<int> bodyticketticketType = null, WorkflowExpression<int> bodyticketgroup = null, WorkflowExpression<string> bodyticketdueDate = null, WorkflowExpression<string> bodyticketresolutionDate = null)
        {
            WorkflowExpression.Validate(bodyticketenterTikitId, nameof(bodyticketenterTikitId), required: true);
            WorkflowExpression.Validate(bodyticketassigneeassigneeEmail, nameof(bodyticketassigneeassigneeEmail), required: true);
            WorkflowExpression.Validate(bodyticketchangeRequestInformation, nameof(bodyticketchangeRequestInformation), required: false);
            WorkflowExpression.Validate(bodyticketrequesterrequesterEmail, nameof(bodyticketrequesterrequesterEmail), required: false);
            WorkflowExpression.Validate(bodyticketstatus, nameof(bodyticketstatus), required: false);
            WorkflowExpression.Validate(bodyticketcategory, nameof(bodyticketcategory), required: false);
            WorkflowExpression.Validate(bodyticketpriority, nameof(bodyticketpriority), required: false);
            WorkflowExpression.Validate(bodyticketticketType, nameof(bodyticketticketType), required: false);
            WorkflowExpression.Validate(bodyticketgroup, nameof(bodyticketgroup), required: false);
            WorkflowExpression.Validate(bodyticketdueDate, nameof(bodyticketdueDate), required: false);
            WorkflowExpression.Validate(bodyticketresolutionDate, nameof(bodyticketresolutionDate), required: false);
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
                ticketObject["Id"] = ExpressionConverter.ConvertO(bodyticketenterTikitId);
                if (bodyticketchangeRequestInformation != null)
                {
                    ticketObject["Title"] = ExpressionConverter.ConvertO(bodyticketchangeRequestInformation);
                    ticketObjectpropCount++;
                }

                var requesterObject = new JObject();
                var requesterObjectpropCount = 0;
                if (bodyticketrequesterrequesterEmail != null)
                {
                    requesterObject["EMailAddress"] = ExpressionConverter.ConvertO(bodyticketrequesterrequesterEmail);
                    requesterObjectpropCount++;
                }

                if (requesterObjectpropCount > 0)
                {
                    ticketObject["Requester"] = requesterObject;
                    ticketObjectpropCount++;
                }

                if (bodyticketstatus != null)
                {
                    ticketObject["StatusId"] = ExpressionConverter.ConvertO(bodyticketstatus);
                    ticketObjectpropCount++;
                }

                if (bodyticketcategory != null)
                {
                    ticketObject["CategoryId"] = ExpressionConverter.ConvertO(bodyticketcategory);
                    ticketObjectpropCount++;
                }

                if (bodyticketpriority != null)
                {
                    ticketObject["PriorityId"] = ExpressionConverter.ConvertO(bodyticketpriority);
                    ticketObjectpropCount++;
                }

                if (bodyticketticketType != null)
                {
                    ticketObject["TicketTypeId"] = ExpressionConverter.ConvertO(bodyticketticketType);
                    ticketObjectpropCount++;
                }

                if (bodyticketgroup != null)
                {
                    ticketObject["SupportGroupId"] = ExpressionConverter.ConvertO(bodyticketgroup);
                    ticketObjectpropCount++;
                }

                if (bodyticketdueDate != null)
                {
                    ticketObject["DueDate"] = ExpressionConverter.ConvertO(bodyticketdueDate);
                    ticketObjectpropCount++;
                }

                if (bodyticketresolutionDate != null)
                {
                    ticketObject["ResolutionDate"] = ExpressionConverter.ConvertO(bodyticketresolutionDate);
                    ticketObjectpropCount++;
                }

                var assigneeObject = new JObject();
                var assigneeObjectpropCount = 0;
                assigneeObjectpropCount++;
                assigneeObject["Email"] = ExpressionConverter.ConvertO(bodyticketassigneeassigneeEmail);
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
        [WorkflowExpressionFactory(nameof(__BuildGetOneTicket))]
        public IBodyWorkflowAction<ServiceDeskCoreModelsTicket> GetOneTicket([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> select = null, [WorkflowExpression] Func<string> expand = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tikit")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ServiceDeskCoreModelsTicket> __BuildGetOneTicket(WorkflowExpression<string> id, WorkflowExpression<string> select = null, WorkflowExpression<string> expand = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(select, nameof(select), required: false);
            WorkflowExpression.Validate(expand, nameof(expand), required: false);
            return new DeferredBodyAction<ServiceDeskCoreModelsTicket>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/ticket/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(select);
                callPayload.Queries["$expand"] = Convert.ToString("Requester,Assignee");
                if (expand != null)
                    callPayload.Queries["$expand"] = ExpressionConverter.Convert(expand);
                callPayload.Headers["x-requested-by"] = Convert.ToString("PowerAutomate");
                return new ApiConnectionAction<ServiceDeskCoreModelsTicket>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tikit")]
        [WorkflowExpressionFactory(nameof(__BuildAddComment))]
        public IBodyWorkflowAction<AddCommentResponse> AddComment([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodycommentbody = null, [WorkflowExpression] Func<bool> bodycommentisPublic = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tikit")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AddCommentResponse> __BuildAddComment(WorkflowExpression<string> id, WorkflowExpression<string> bodycommentbody = null, WorkflowExpression<bool> bodycommentisPublic = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(bodycommentbody, nameof(bodycommentbody), required: false);
            WorkflowExpression.Validate(bodycommentisPublic, nameof(bodycommentisPublic), required: false);
            return new DeferredBodyAction<AddCommentResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/ticket({0})/AddComment", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-requested-by"] = Convert.ToString("PowerAutomate");
                var body = new JObject();
                var bodypropCount = 0;
                var commentObject = new JObject();
                var commentObjectpropCount = 0;
                if (bodycommentbody != null)
                {
                    commentObject["Body"] = ExpressionConverter.ConvertO(bodycommentbody);
                    commentObjectpropCount++;
                }

                if (bodycommentisPublic != null)
                {
                    commentObject["IsPublic"] = ExpressionConverter.ConvertO(bodycommentisPublic);
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
        [WorkflowExpressionFactory(nameof(__BuildGetFileAttached))]
        public IBodyWorkflowAction<GetFileAttachedResponse> GetFileAttached([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tikit")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetFileAttachedResponse> __BuildGetFileAttached(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<GetFileAttachedResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/ticket/{0}/FileAttachments", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetFileAttachedResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tikit")]
        [WorkflowExpressionFactory(nameof(__BuildGetTasks))]
        public IBodyWorkflowAction<GetTasksResponse> GetTasks([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> lifecycle = null, [WorkflowExpression] Func<string> phase = null, [WorkflowExpression] Func<string> taskName = null, [WorkflowExpression] Func<string> assignee = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tikit")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetTasksResponse> __BuildGetTasks(WorkflowExpression<string> id, WorkflowExpression<string> lifecycle = null, WorkflowExpression<string> phase = null, WorkflowExpression<string> taskName = null, WorkflowExpression<string> assignee = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(lifecycle, nameof(lifecycle), required: false);
            WorkflowExpression.Validate(phase, nameof(phase), required: false);
            WorkflowExpression.Validate(taskName, nameof(taskName), required: false);
            WorkflowExpression.Validate(assignee, nameof(assignee), required: false);
            return new DeferredBodyAction<GetTasksResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/Ticket({0})/GetTasks", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tikit")]
        [WorkflowExpressionFactory(nameof(__BuildGetPowerAutomateTasks))]
        public IBodyWorkflowAction<GetPowerAutomateTasksResponse> GetPowerAutomateTasks([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> lifecycle = null, [WorkflowExpression] Func<string> phase = null, [WorkflowExpression] Func<string> taskName = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tikit")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetPowerAutomateTasksResponse> __BuildGetPowerAutomateTasks(WorkflowExpression<string> id, WorkflowExpression<string> lifecycle = null, WorkflowExpression<string> phase = null, WorkflowExpression<string> taskName = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(lifecycle, nameof(lifecycle), required: false);
            WorkflowExpression.Validate(phase, nameof(phase), required: false);
            WorkflowExpression.Validate(taskName, nameof(taskName), required: false);
            return new DeferredBodyAction<GetPowerAutomateTasksResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/Ticket({0})/GetPowerAutomateTasks", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tikit")]
        [WorkflowExpressionFactory(nameof(__BuildAddTask))]
        public IBodyWorkflowAction<ServiceDeskCoreModelsTicketTask> AddTask([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodytitle, [WorkflowExpression] Func<string> bodylifecycle = null, [WorkflowExpression] Func<string> bodyphase = null, [WorkflowExpression] Func<string> bodyassignee = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tikit")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ServiceDeskCoreModelsTicketTask> __BuildAddTask(WorkflowExpression<string> id, WorkflowExpression<string> bodytitle, WorkflowExpression<string> bodylifecycle = null, WorkflowExpression<string> bodyphase = null, WorkflowExpression<string> bodyassignee = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(bodytitle, nameof(bodytitle), required: true);
            WorkflowExpression.Validate(bodylifecycle, nameof(bodylifecycle), required: false);
            WorkflowExpression.Validate(bodyphase, nameof(bodyphase), required: false);
            WorkflowExpression.Validate(bodyassignee, nameof(bodyassignee), required: false);
            return new DeferredBodyAction<ServiceDeskCoreModelsTicketTask>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/Ticket({0})/AddTask", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
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
                body["Title"] = ExpressionConverter.ConvertO(bodytitle);
                if (bodyassignee != null)
                {
                    body["Assignee"] = ExpressionConverter.ConvertO(bodyassignee);
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
        [WorkflowExpressionFactory(nameof(__BuildUpdateTask))]
        public IBodyWorkflowAction<ServiceDeskCoreModelsTicketTask> UpdateTask([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodytitle = null, [WorkflowExpression] Func<string> bodyassignee = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tikit")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ServiceDeskCoreModelsTicketTask> __BuildUpdateTask(WorkflowExpression<string> id, WorkflowExpression<string> bodytitle = null, WorkflowExpression<string> bodyassignee = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(bodytitle, nameof(bodytitle), required: false);
            WorkflowExpression.Validate(bodyassignee, nameof(bodyassignee), required: false);
            return new DeferredBodyAction<ServiceDeskCoreModelsTicketTask>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/TicketTask({0})/UpdateTask", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-requested-by"] = Convert.ToString("PowerAutomate");
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytitle != null)
                {
                    body["Title"] = ExpressionConverter.ConvertO(bodytitle);
                    bodypropCount++;
                }

                if (bodyassignee != null)
                {
                    body["Assignee"] = ExpressionConverter.ConvertO(bodyassignee);
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
        [WorkflowExpressionFactory(nameof(__BuildUpdatePowerAutomateTask))]
        public IBodyWorkflowAction<ServiceDeskCoreModelsPowerAutomateTask> UpdatePowerAutomateTask([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodystatusId = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tikit")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ServiceDeskCoreModelsPowerAutomateTask> __BuildUpdatePowerAutomateTask(WorkflowExpression<string> id, WorkflowExpression<string> bodystatusId = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(bodystatusId, nameof(bodystatusId), required: false);
            return new DeferredBodyAction<ServiceDeskCoreModelsPowerAutomateTask>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/TicketTask({0})/UpdatePowerAutomateTask", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-requested-by"] = Convert.ToString("PowerAutomate");
                var body = new JObject();
                var bodypropCount = 0;
                if (bodystatusId != null)
                {
                    body["StatusId"] = ExpressionConverter.ConvertO(bodystatusId);
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
        [WorkflowExpressionFactory(nameof(__BuildGetApprovals))]
        public IBodyWorkflowAction<GetApprovalsResponse> GetApprovals([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> lifecycle = null, [WorkflowExpression] Func<string> phase = null, [WorkflowExpression] Func<string> approvalName = null, [WorkflowExpression] Func<string> approvers = null, [WorkflowExpression] Func<string> additionalDetails = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tikit")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetApprovalsResponse> __BuildGetApprovals(WorkflowExpression<string> id, WorkflowExpression<string> lifecycle = null, WorkflowExpression<string> phase = null, WorkflowExpression<string> approvalName = null, WorkflowExpression<string> approvers = null, WorkflowExpression<string> additionalDetails = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(lifecycle, nameof(lifecycle), required: false);
            WorkflowExpression.Validate(phase, nameof(phase), required: false);
            WorkflowExpression.Validate(approvalName, nameof(approvalName), required: false);
            WorkflowExpression.Validate(approvers, nameof(approvers), required: false);
            WorkflowExpression.Validate(additionalDetails, nameof(additionalDetails), required: false);
            return new DeferredBodyAction<GetApprovalsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/Ticket({0})/GetApprovals", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tikit")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateApproval))]
        public IBodyWorkflowAction<ServiceDeskCoreModelsApprovals> UpdateApproval([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodytitle = null, [WorkflowExpression] Func<string> bodyadditionalDetails = null, [WorkflowExpression] Func<bodyrequiredByAllInput> bodyrequiredByAll = null, [WorkflowExpression] Func<string> bodyapprovers = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tikit")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ServiceDeskCoreModelsApprovals> __BuildUpdateApproval(WorkflowExpression<string> id, WorkflowExpression<string> bodytitle = null, WorkflowExpression<string> bodyadditionalDetails = null, WorkflowExpression<bodyrequiredByAllInput> bodyrequiredByAll = null, WorkflowExpression<string> bodyapprovers = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(bodytitle, nameof(bodytitle), required: false);
            WorkflowExpression.Validate(bodyadditionalDetails, nameof(bodyadditionalDetails), required: false);
            WorkflowExpression.Validate(bodyrequiredByAll, nameof(bodyrequiredByAll), required: false);
            WorkflowExpression.Validate(bodyapprovers, nameof(bodyapprovers), required: false);
            return new DeferredBodyAction<ServiceDeskCoreModelsApprovals>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/Approvals({0})/UpdateApproval", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-requested-by"] = Convert.ToString("PowerAutomate");
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytitle != null)
                {
                    body["Title"] = ExpressionConverter.ConvertO(bodytitle);
                    bodypropCount++;
                }

                if (bodyadditionalDetails != null)
                {
                    body["AdditionalDetails"] = ExpressionConverter.ConvertO(bodyadditionalDetails);
                    bodypropCount++;
                }

                if (bodyrequiredByAll != null)
                {
                    body["RequiredByAll"] = ExpressionConverter.ConvertO(bodyrequiredByAll);
                    bodypropCount++;
                }

                if (bodyapprovers != null)
                {
                    body["Approvers"] = ExpressionConverter.ConvertO(bodyapprovers);
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

        [WorkflowExpressionFactory(nameof(__BuildAddTicketWebhookTrigger))]
        public IBodyWorkflowTrigger<ServiceDeskCoreActionsAddWebhookWebhookParam> AddTicketWebhookTrigger([WorkflowExpression] Func<string> bodywebHookrequesters = null, [WorkflowExpression] Func<string> bodywebHookassignees = null, [WorkflowExpression] Func<string> bodywebHooktitle = null, [WorkflowExpression] Func<string> bodywebHookstatus = null, [WorkflowExpression] Func<bodywebHookpriorityInput> bodywebHookpriority = null, [WorkflowExpression] Func<int> bodywebHookgroup = null, [WorkflowExpression] Func<int> bodywebHookselectTemplate = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<ServiceDeskCoreActionsAddWebhookWebhookParam> __BuildAddTicketWebhookTrigger(WorkflowExpression<string> bodywebHookrequesters = null, WorkflowExpression<string> bodywebHookassignees = null, WorkflowExpression<string> bodywebHooktitle = null, WorkflowExpression<string> bodywebHookstatus = null, WorkflowExpression<bodywebHookpriorityInput> bodywebHookpriority = null, WorkflowExpression<int> bodywebHookgroup = null, WorkflowExpression<int> bodywebHookselectTemplate = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(bodywebHookrequesters, nameof(bodywebHookrequesters), required: false);
            WorkflowExpression.Validate(bodywebHookassignees, nameof(bodywebHookassignees), required: false);
            WorkflowExpression.Validate(bodywebHooktitle, nameof(bodywebHooktitle), required: false);
            WorkflowExpression.Validate(bodywebHookstatus, nameof(bodywebHookstatus), required: false);
            WorkflowExpression.Validate(bodywebHookpriority, nameof(bodywebHookpriority), required: false);
            WorkflowExpression.Validate(bodywebHookgroup, nameof(bodywebHookgroup), required: false);
            WorkflowExpression.Validate(bodywebHookselectTemplate, nameof(bodywebHookselectTemplate), required: false);
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
                if (bodywebHookrequesters != null)
                {
                    webHookObject["Requesters"] = ExpressionConverter.ConvertO(bodywebHookrequesters);
                    webHookObjectpropCount++;
                }

                if (bodywebHookassignees != null)
                {
                    webHookObject["Assignees"] = ExpressionConverter.ConvertO(bodywebHookassignees);
                    webHookObjectpropCount++;
                }

                if (bodywebHooktitle != null)
                {
                    webHookObject["Title"] = ExpressionConverter.ConvertO(bodywebHooktitle);
                    webHookObjectpropCount++;
                }

                if (bodywebHookstatus != null)
                {
                    if (bodywebHookstatus != null)
                    {
                        webHookObject["Status"] = ExpressionConverter.ConvertO(bodywebHookstatus);
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
                        webHookObject["Priority"] = ExpressionConverter.ConvertO(bodywebHookpriority);
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
                    webHookObject["GroupId"] = ExpressionConverter.ConvertO(bodywebHookgroup);
                    webHookObjectpropCount++;
                }

                if (bodywebHookselectTemplate != null)
                {
                    webHookObject["TemplateId"] = ExpressionConverter.ConvertO(bodywebHookselectTemplate);
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
            }, triggerName);
        }

        [WorkflowExpressionFactory(nameof(__BuildUpdateTicketWebhookTrigger))]
        public IBodyWorkflowTrigger<ServiceDeskCoreActionsAddWebhookWebhookParam> UpdateTicketWebhookTrigger([WorkflowExpression] Func<string> bodywebHookrequesters = null, [WorkflowExpression] Func<string> bodywebHookassignees = null, [WorkflowExpression] Func<string> bodywebHooktitle = null, [WorkflowExpression] Func<string> bodywebHookstatus = null, [WorkflowExpression] Func<bodywebHookpriorityInput> bodywebHookpriority = null, [WorkflowExpression] Func<int> bodywebHookgroup = null, [WorkflowExpression] Func<int> bodywebHookselectTemplate = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<ServiceDeskCoreActionsAddWebhookWebhookParam> __BuildUpdateTicketWebhookTrigger(WorkflowExpression<string> bodywebHookrequesters = null, WorkflowExpression<string> bodywebHookassignees = null, WorkflowExpression<string> bodywebHooktitle = null, WorkflowExpression<string> bodywebHookstatus = null, WorkflowExpression<bodywebHookpriorityInput> bodywebHookpriority = null, WorkflowExpression<int> bodywebHookgroup = null, WorkflowExpression<int> bodywebHookselectTemplate = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(bodywebHookrequesters, nameof(bodywebHookrequesters), required: false);
            WorkflowExpression.Validate(bodywebHookassignees, nameof(bodywebHookassignees), required: false);
            WorkflowExpression.Validate(bodywebHooktitle, nameof(bodywebHooktitle), required: false);
            WorkflowExpression.Validate(bodywebHookstatus, nameof(bodywebHookstatus), required: false);
            WorkflowExpression.Validate(bodywebHookpriority, nameof(bodywebHookpriority), required: false);
            WorkflowExpression.Validate(bodywebHookgroup, nameof(bodywebHookgroup), required: false);
            WorkflowExpression.Validate(bodywebHookselectTemplate, nameof(bodywebHookselectTemplate), required: false);
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
                if (bodywebHookrequesters != null)
                {
                    webHookObject["Requesters"] = ExpressionConverter.ConvertO(bodywebHookrequesters);
                    webHookObjectpropCount++;
                }

                if (bodywebHookassignees != null)
                {
                    webHookObject["Assignees"] = ExpressionConverter.ConvertO(bodywebHookassignees);
                    webHookObjectpropCount++;
                }

                if (bodywebHooktitle != null)
                {
                    webHookObject["Title"] = ExpressionConverter.ConvertO(bodywebHooktitle);
                    webHookObjectpropCount++;
                }

                if (bodywebHookstatus != null)
                {
                    if (bodywebHookstatus != null)
                    {
                        webHookObject["Status"] = ExpressionConverter.ConvertO(bodywebHookstatus);
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
                        webHookObject["Priority"] = ExpressionConverter.ConvertO(bodywebHookpriority);
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
                    webHookObject["GroupId"] = ExpressionConverter.ConvertO(bodywebHookgroup);
                    webHookObjectpropCount++;
                }

                if (bodywebHookselectTemplate != null)
                {
                    webHookObject["TemplateId"] = ExpressionConverter.ConvertO(bodywebHookselectTemplate);
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
            }, triggerName);
        }

        [WorkflowExpressionFactory(nameof(__BuildAddCommentTicketWebhook))]
        public IBodyWorkflowTrigger<ServiceDeskCoreActionsAddWebhookWebhookParam> AddCommentTicketWebhook([WorkflowExpression] Func<string> bodywebHookcommenter = null, [WorkflowExpression] Func<string> bodywebHookcommentStringContain = null, [WorkflowExpression] Func<bodywebHookisPublicCommentInput> bodywebHookisPublicComment = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<ServiceDeskCoreActionsAddWebhookWebhookParam> __BuildAddCommentTicketWebhook(WorkflowExpression<string> bodywebHookcommenter = null, WorkflowExpression<string> bodywebHookcommentStringContain = null, WorkflowExpression<bodywebHookisPublicCommentInput> bodywebHookisPublicComment = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(bodywebHookcommenter, nameof(bodywebHookcommenter), required: false);
            WorkflowExpression.Validate(bodywebHookcommentStringContain, nameof(bodywebHookcommentStringContain), required: false);
            WorkflowExpression.Validate(bodywebHookisPublicComment, nameof(bodywebHookisPublicComment), required: false);
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
                if (bodywebHookcommenter != null)
                {
                    webHookObject["Commenter"] = ExpressionConverter.ConvertO(bodywebHookcommenter);
                    webHookObjectpropCount++;
                }

                if (bodywebHookcommentStringContain != null)
                {
                    webHookObject["CommentStringContain"] = ExpressionConverter.ConvertO(bodywebHookcommentStringContain);
                    webHookObjectpropCount++;
                }

                if (bodywebHookisPublicComment != null)
                {
                    if (bodywebHookisPublicComment != null)
                    {
                        webHookObject["IsPublicComment"] = ExpressionConverter.ConvertO(bodywebHookisPublicComment);
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
            }, triggerName);
        }

        [WorkflowExpressionFactory(nameof(__BuildActivatePowerAutomateTaskWebhook))]
        public IBodyWorkflowTrigger<ServiceDeskCoreModelsTicketTask> ActivatePowerAutomateTaskWebhook([WorkflowExpression] Func<string> bodywebHooklifecycleId = null, [WorkflowExpression] Func<int> bodywebHooklifecyclePhaseId = null, [WorkflowExpression] Func<string> bodywebHooklifecyclePowerAutomateName = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<ServiceDeskCoreModelsTicketTask> __BuildActivatePowerAutomateTaskWebhook(WorkflowExpression<string> bodywebHooklifecycleId = null, WorkflowExpression<int> bodywebHooklifecyclePhaseId = null, WorkflowExpression<string> bodywebHooklifecyclePowerAutomateName = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(bodywebHooklifecycleId, nameof(bodywebHooklifecycleId), required: false);
            WorkflowExpression.Validate(bodywebHooklifecyclePhaseId, nameof(bodywebHooklifecyclePhaseId), required: false);
            WorkflowExpression.Validate(bodywebHooklifecyclePowerAutomateName, nameof(bodywebHooklifecyclePowerAutomateName), required: false);
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
                if (bodywebHooklifecycleId != null)
                {
                    webHookObject["LifecycleId"] = ExpressionConverter.ConvertO(bodywebHooklifecycleId);
                    webHookObjectpropCount++;
                }

                if (bodywebHooklifecyclePhaseId != null)
                {
                    webHookObject["LifecyclePhaseId"] = ExpressionConverter.ConvertO(bodywebHooklifecyclePhaseId);
                    webHookObjectpropCount++;
                }

                if (bodywebHooklifecyclePowerAutomateName != null)
                {
                    webHookObject["LifecyclePowerAutomateName"] = ExpressionConverter.ConvertO(bodywebHooklifecyclePowerAutomateName);
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
            }, triggerName);
        }

        [WorkflowExpressionFactory(nameof(__BuildChangeLifecyclePhaseWebhook))]
        public IBodyWorkflowTrigger<ServiceDeskCoreActionsAddWebhookWebhookParam> ChangeLifecyclePhaseWebhook([WorkflowExpression] Func<string> bodywebHooklifecycleId = null, [WorkflowExpression] Func<int> bodywebHooklifecyclePhaseId = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<ServiceDeskCoreActionsAddWebhookWebhookParam> __BuildChangeLifecyclePhaseWebhook(WorkflowExpression<string> bodywebHooklifecycleId = null, WorkflowExpression<int> bodywebHooklifecyclePhaseId = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(bodywebHooklifecycleId, nameof(bodywebHooklifecycleId), required: false);
            WorkflowExpression.Validate(bodywebHooklifecyclePhaseId, nameof(bodywebHooklifecyclePhaseId), required: false);
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
                if (bodywebHooklifecycleId != null)
                {
                    webHookObject["LifecycleId"] = ExpressionConverter.ConvertO(bodywebHooklifecycleId);
                    webHookObjectpropCount++;
                }

                if (bodywebHooklifecyclePhaseId != null)
                {
                    webHookObject["LifecyclePhaseId"] = ExpressionConverter.ConvertO(bodywebHooklifecyclePhaseId);
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
            }, triggerName);
        }

        [WorkflowExpressionFactory(nameof(__BuildEngageLifecycleTransitionWebhook))]
        public IBodyWorkflowTrigger<ServiceDeskCoreActionsAddWebhookWebhookParam> EngageLifecycleTransitionWebhook([WorkflowExpression] Func<string> bodywebHooklifecycleId = null, [WorkflowExpression] Func<int> bodywebHooklifecyclePhaseId = null, [WorkflowExpression] Func<int> bodywebHooklifecycleTransitionId = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<ServiceDeskCoreActionsAddWebhookWebhookParam> __BuildEngageLifecycleTransitionWebhook(WorkflowExpression<string> bodywebHooklifecycleId = null, WorkflowExpression<int> bodywebHooklifecyclePhaseId = null, WorkflowExpression<int> bodywebHooklifecycleTransitionId = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(bodywebHooklifecycleId, nameof(bodywebHooklifecycleId), required: false);
            WorkflowExpression.Validate(bodywebHooklifecyclePhaseId, nameof(bodywebHooklifecyclePhaseId), required: false);
            WorkflowExpression.Validate(bodywebHooklifecycleTransitionId, nameof(bodywebHooklifecycleTransitionId), required: false);
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
                if (bodywebHooklifecycleId != null)
                {
                    webHookObject["LifecycleId"] = ExpressionConverter.ConvertO(bodywebHooklifecycleId);
                    webHookObjectpropCount++;
                }

                if (bodywebHooklifecyclePhaseId != null)
                {
                    webHookObject["LifecyclePhaseId"] = ExpressionConverter.ConvertO(bodywebHooklifecyclePhaseId);
                    webHookObjectpropCount++;
                }

                if (bodywebHooklifecycleTransitionId != null)
                {
                    webHookObject["LifecycleTransitionId"] = ExpressionConverter.ConvertO(bodywebHooklifecycleTransitionId);
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
            }, triggerName);
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