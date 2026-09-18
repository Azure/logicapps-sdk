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
        public IBodyWorkflowAction<ServiceDeskCoreModelsTicketItems> GetAllTickets([WorkflowExpression] Func<string> expand = null, [WorkflowExpression] Func<string> select = null, [WorkflowExpression] Func<string> orderby = null, [WorkflowExpression] Func<int> top = null, [WorkflowExpression] Func<int> skip = null, [WorkflowExpression] Func<bool> count = null)
        {
            SourceExpression.Validate(expand, nameof(expand), required: false);
            SourceExpression.Validate(select, nameof(select), required: false);
            SourceExpression.Validate(orderby, nameof(orderby), required: false);
            SourceExpression.Validate(top, nameof(top), required: false);
            SourceExpression.Validate(skip, nameof(skip), required: false);
            SourceExpression.Validate(count, nameof(count), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/Ticket";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (expand != null)
                    callPayload.Queries["$expand"] = SourceExpressionConverter.ConvertO(expand);
                if (select != null)
                    callPayload.Queries["$select"] = SourceExpressionConverter.ConvertO(select);
                if (orderby != null)
                    callPayload.Queries["$orderby"] = SourceExpressionConverter.ConvertO(orderby);
                callPayload.Queries["$top"] = Convert.ToString(10);
                if (top != null)
                    callPayload.Queries["$top"] = SourceExpressionConverter.ConvertO(top);
                if (skip != null)
                    callPayload.Queries["$skip"] = SourceExpressionConverter.ConvertO(skip);
                if (count != null)
                    callPayload.Queries["$count"] = SourceExpressionConverter.ConvertO(count);
                callPayload.Headers["x-requested-by"] = Convert.ToString("PowerAutomate");
                return callPayload;
            }

            return new ApiConnectionAction<ServiceDeskCoreModelsTicketItems>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tikit")]
        public IBodyWorkflowAction<ServiceDeskCoreModelsTicket> CreateTicket([WorkflowExpression] Func<string> bodyticketrequest, [WorkflowExpression] Func<string> bodyticketrequesterrequesterEmail, [WorkflowExpression] Func<int> bodyticketstatus, [WorkflowExpression] Func<int> bodyticketpriority, [WorkflowExpression] Func<int> bodyticketticketType, [WorkflowExpression] Func<string> bodyticketassigneeassigneeEmail, [WorkflowExpression] Func<int> bodyticketcategory = null, [WorkflowExpression] Func<int> bodyticketgroup = null, [WorkflowExpression] Func<string> bodyticketdueDate = null, [WorkflowExpression] Func<string> bodyticketresolutionDate = null)
        {
            SourceExpression.Validate(bodyticketrequest, nameof(bodyticketrequest), required: true);
            SourceExpression.Validate(bodyticketrequesterrequesterEmail, nameof(bodyticketrequesterrequesterEmail), required: true);
            SourceExpression.Validate(bodyticketstatus, nameof(bodyticketstatus), required: true);
            SourceExpression.Validate(bodyticketpriority, nameof(bodyticketpriority), required: true);
            SourceExpression.Validate(bodyticketticketType, nameof(bodyticketticketType), required: true);
            SourceExpression.Validate(bodyticketassigneeassigneeEmail, nameof(bodyticketassigneeassigneeEmail), required: true);
            SourceExpression.Validate(bodyticketcategory, nameof(bodyticketcategory), required: false);
            SourceExpression.Validate(bodyticketgroup, nameof(bodyticketgroup), required: false);
            SourceExpression.Validate(bodyticketdueDate, nameof(bodyticketdueDate), required: false);
            SourceExpression.Validate(bodyticketresolutionDate, nameof(bodyticketresolutionDate), required: false);
            ApiConnectionActionInput BuildSourceInput()
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
                ticketObject["Title"] = SourceExpressionConverter.ConvertToken(bodyticketrequest);
                var requesterObject = new JObject();
                var requesterObjectpropCount = 0;
                requesterObjectpropCount++;
                requesterObject["EMailAddress"] = SourceExpressionConverter.ConvertToken(bodyticketrequesterrequesterEmail);
                if (requesterObjectpropCount > 0)
                {
                    ticketObject["Requester"] = requesterObject;
                    ticketObjectpropCount++;
                }

                ticketObjectpropCount++;
                ticketObject["StatusId"] = SourceExpressionConverter.ConvertToken(bodyticketstatus);
                if (bodyticketcategory != null)
                {
                    ticketObject["CategoryId"] = SourceExpressionConverter.ConvertToken(bodyticketcategory);
                    ticketObjectpropCount++;
                }

                ticketObjectpropCount++;
                ticketObject["PriorityId"] = SourceExpressionConverter.ConvertToken(bodyticketpriority);
                ticketObjectpropCount++;
                ticketObject["TicketTypeId"] = SourceExpressionConverter.ConvertToken(bodyticketticketType);
                if (bodyticketgroup != null)
                {
                    ticketObject["SupportGroupId"] = SourceExpressionConverter.ConvertToken(bodyticketgroup);
                    ticketObjectpropCount++;
                }

                if (bodyticketdueDate != null)
                {
                    ticketObject["DueDate"] = SourceExpressionConverter.ConvertToken(bodyticketdueDate);
                    ticketObjectpropCount++;
                }

                if (bodyticketresolutionDate != null)
                {
                    ticketObject["ResolutionDate"] = SourceExpressionConverter.ConvertToken(bodyticketresolutionDate);
                    ticketObjectpropCount++;
                }

                var assigneeObject = new JObject();
                var assigneeObjectpropCount = 0;
                assigneeObjectpropCount++;
                assigneeObject["Email"] = SourceExpressionConverter.ConvertToken(bodyticketassigneeassigneeEmail);
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
                return callPayload;
            }

            return new ApiConnectionAction<ServiceDeskCoreModelsTicket>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tikit")]
        public IBodyWorkflowAction<ServiceDeskCoreModelsTicket> UpdateTicket([WorkflowExpression] Func<int> bodyticketenterTikitId, [WorkflowExpression] Func<string> bodyticketassigneeassigneeEmail, [WorkflowExpression] Func<string> bodyticketchangeRequestInformation = null, [WorkflowExpression] Func<string> bodyticketrequesterrequesterEmail = null, [WorkflowExpression] Func<int> bodyticketstatus = null, [WorkflowExpression] Func<int> bodyticketcategory = null, [WorkflowExpression] Func<int> bodyticketpriority = null, [WorkflowExpression] Func<int> bodyticketticketType = null, [WorkflowExpression] Func<int> bodyticketgroup = null, [WorkflowExpression] Func<string> bodyticketdueDate = null, [WorkflowExpression] Func<string> bodyticketresolutionDate = null)
        {
            SourceExpression.Validate(bodyticketenterTikitId, nameof(bodyticketenterTikitId), required: true);
            SourceExpression.Validate(bodyticketassigneeassigneeEmail, nameof(bodyticketassigneeassigneeEmail), required: true);
            SourceExpression.Validate(bodyticketchangeRequestInformation, nameof(bodyticketchangeRequestInformation), required: false);
            SourceExpression.Validate(bodyticketrequesterrequesterEmail, nameof(bodyticketrequesterrequesterEmail), required: false);
            SourceExpression.Validate(bodyticketstatus, nameof(bodyticketstatus), required: false);
            SourceExpression.Validate(bodyticketcategory, nameof(bodyticketcategory), required: false);
            SourceExpression.Validate(bodyticketpriority, nameof(bodyticketpriority), required: false);
            SourceExpression.Validate(bodyticketticketType, nameof(bodyticketticketType), required: false);
            SourceExpression.Validate(bodyticketgroup, nameof(bodyticketgroup), required: false);
            SourceExpression.Validate(bodyticketdueDate, nameof(bodyticketdueDate), required: false);
            SourceExpression.Validate(bodyticketresolutionDate, nameof(bodyticketresolutionDate), required: false);
            ApiConnectionActionInput BuildSourceInput()
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
                ticketObject["Id"] = SourceExpressionConverter.ConvertToken(bodyticketenterTikitId);
                if (bodyticketchangeRequestInformation != null)
                {
                    ticketObject["Title"] = SourceExpressionConverter.ConvertToken(bodyticketchangeRequestInformation);
                    ticketObjectpropCount++;
                }

                var requesterObject = new JObject();
                var requesterObjectpropCount = 0;
                if (bodyticketrequesterrequesterEmail != null)
                {
                    requesterObject["EMailAddress"] = SourceExpressionConverter.ConvertToken(bodyticketrequesterrequesterEmail);
                    requesterObjectpropCount++;
                }

                if (requesterObjectpropCount > 0)
                {
                    ticketObject["Requester"] = requesterObject;
                    ticketObjectpropCount++;
                }

                if (bodyticketstatus != null)
                {
                    ticketObject["StatusId"] = SourceExpressionConverter.ConvertToken(bodyticketstatus);
                    ticketObjectpropCount++;
                }

                if (bodyticketcategory != null)
                {
                    ticketObject["CategoryId"] = SourceExpressionConverter.ConvertToken(bodyticketcategory);
                    ticketObjectpropCount++;
                }

                if (bodyticketpriority != null)
                {
                    ticketObject["PriorityId"] = SourceExpressionConverter.ConvertToken(bodyticketpriority);
                    ticketObjectpropCount++;
                }

                if (bodyticketticketType != null)
                {
                    ticketObject["TicketTypeId"] = SourceExpressionConverter.ConvertToken(bodyticketticketType);
                    ticketObjectpropCount++;
                }

                if (bodyticketgroup != null)
                {
                    ticketObject["SupportGroupId"] = SourceExpressionConverter.ConvertToken(bodyticketgroup);
                    ticketObjectpropCount++;
                }

                if (bodyticketdueDate != null)
                {
                    ticketObject["DueDate"] = SourceExpressionConverter.ConvertToken(bodyticketdueDate);
                    ticketObjectpropCount++;
                }

                if (bodyticketresolutionDate != null)
                {
                    ticketObject["ResolutionDate"] = SourceExpressionConverter.ConvertToken(bodyticketresolutionDate);
                    ticketObjectpropCount++;
                }

                var assigneeObject = new JObject();
                var assigneeObjectpropCount = 0;
                assigneeObjectpropCount++;
                assigneeObject["Email"] = SourceExpressionConverter.ConvertToken(bodyticketassigneeassigneeEmail);
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
                return callPayload;
            }

            return new ApiConnectionAction<ServiceDeskCoreModelsTicket>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tikit")]
        public IBodyWorkflowAction<ServiceDeskCoreModelsTicket> GetOneTicket([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> select = null, [WorkflowExpression] Func<string> expand = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(select, nameof(select), required: false);
            SourceExpression.Validate(expand, nameof(expand), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/ticket/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (select != null)
                    callPayload.Queries["$select"] = SourceExpressionConverter.ConvertO(select);
                callPayload.Queries["$expand"] = Convert.ToString("Requester,Assignee");
                if (expand != null)
                    callPayload.Queries["$expand"] = SourceExpressionConverter.ConvertO(expand);
                callPayload.Headers["x-requested-by"] = Convert.ToString("PowerAutomate");
                return callPayload;
            }

            return new ApiConnectionAction<ServiceDeskCoreModelsTicket>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tikit")]
        public IBodyWorkflowAction<AddCommentResponse> AddComment([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodycommentbody = null, [WorkflowExpression] Func<bool> bodycommentisPublic = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(bodycommentbody, nameof(bodycommentbody), required: false);
            SourceExpression.Validate(bodycommentisPublic, nameof(bodycommentisPublic), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/ticket({0})/AddComment", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-requested-by"] = Convert.ToString("PowerAutomate");
                var body = new JObject();
                var bodypropCount = 0;
                var commentObject = new JObject();
                var commentObjectpropCount = 0;
                if (bodycommentbody != null)
                {
                    commentObject["Body"] = SourceExpressionConverter.ConvertToken(bodycommentbody);
                    commentObjectpropCount++;
                }

                if (bodycommentisPublic != null)
                {
                    commentObject["IsPublic"] = SourceExpressionConverter.ConvertToken(bodycommentisPublic);
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
                return callPayload;
            }

            return new ApiConnectionAction<AddCommentResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tikit")]
        public IBodyWorkflowAction<GetFileAttachedResponse> GetFileAttached([WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/ticket/{0}/FileAttachments", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetFileAttachedResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tikit")]
        public IBodyWorkflowAction<GetTasksResponse> GetTasks([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> lifecycle = null, [WorkflowExpression] Func<string> phase = null, [WorkflowExpression] Func<string> taskName = null, [WorkflowExpression] Func<string> assignee = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(lifecycle, nameof(lifecycle), required: false);
            SourceExpression.Validate(phase, nameof(phase), required: false);
            SourceExpression.Validate(taskName, nameof(taskName), required: false);
            SourceExpression.Validate(assignee, nameof(assignee), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/Ticket({0})/GetTasks", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (lifecycle != null)
                    callPayload.Queries["Lifecycle"] = SourceExpressionConverter.ConvertO(lifecycle);
                if (phase != null)
                    callPayload.Queries["Phase"] = SourceExpressionConverter.ConvertO(phase);
                if (taskName != null)
                    callPayload.Queries["TaskName"] = SourceExpressionConverter.ConvertO(taskName);
                if (assignee != null)
                    callPayload.Queries["Assignee"] = SourceExpressionConverter.ConvertO(assignee);
                callPayload.Headers["x-requested-by"] = Convert.ToString("PowerAutomate");
                return callPayload;
            }

            return new ApiConnectionAction<GetTasksResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tikit")]
        public IBodyWorkflowAction<GetPowerAutomateTasksResponse> GetPowerAutomateTasks([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> lifecycle = null, [WorkflowExpression] Func<string> phase = null, [WorkflowExpression] Func<string> taskName = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(lifecycle, nameof(lifecycle), required: false);
            SourceExpression.Validate(phase, nameof(phase), required: false);
            SourceExpression.Validate(taskName, nameof(taskName), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/Ticket({0})/GetPowerAutomateTasks", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (lifecycle != null)
                    callPayload.Queries["Lifecycle"] = SourceExpressionConverter.ConvertO(lifecycle);
                if (phase != null)
                    callPayload.Queries["Phase"] = SourceExpressionConverter.ConvertO(phase);
                if (taskName != null)
                    callPayload.Queries["TaskName"] = SourceExpressionConverter.ConvertO(taskName);
                callPayload.Headers["x-requested-by"] = Convert.ToString("PowerAutomate");
                return callPayload;
            }

            return new ApiConnectionAction<GetPowerAutomateTasksResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tikit")]
        public IBodyWorkflowAction<ServiceDeskCoreModelsTicketTask> AddTask([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodytitle, [WorkflowExpression] Func<string> bodylifecycle = null, [WorkflowExpression] Func<string> bodyphase = null, [WorkflowExpression] Func<string> bodyassignee = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(bodytitle, nameof(bodytitle), required: true);
            SourceExpression.Validate(bodylifecycle, nameof(bodylifecycle), required: false);
            SourceExpression.Validate(bodyphase, nameof(bodyphase), required: false);
            SourceExpression.Validate(bodyassignee, nameof(bodyassignee), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/Ticket({0})/AddTask", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-requested-by"] = Convert.ToString("PowerAutomate");
                var body = new JObject();
                var bodypropCount = 0;
                if (bodylifecycle != null)
                {
                    body["Lifecycle"] = SourceExpressionConverter.ConvertToken(bodylifecycle);
                    bodypropCount++;
                }

                if (bodyphase != null)
                {
                    body["PhaseId"] = SourceExpressionConverter.ConvertToken(bodyphase);
                    bodypropCount++;
                }

                bodypropCount++;
                body["Title"] = SourceExpressionConverter.ConvertToken(bodytitle);
                if (bodyassignee != null)
                {
                    body["Assignee"] = SourceExpressionConverter.ConvertToken(bodyassignee);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ServiceDeskCoreModelsTicketTask>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tikit")]
        public IBodyWorkflowAction<ServiceDeskCoreModelsTicketTask> UpdateTask([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodytitle = null, [WorkflowExpression] Func<string> bodyassignee = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(bodytitle, nameof(bodytitle), required: false);
            SourceExpression.Validate(bodyassignee, nameof(bodyassignee), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/TicketTask({0})/UpdateTask", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-requested-by"] = Convert.ToString("PowerAutomate");
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytitle != null)
                {
                    body["Title"] = SourceExpressionConverter.ConvertToken(bodytitle);
                    bodypropCount++;
                }

                if (bodyassignee != null)
                {
                    body["Assignee"] = SourceExpressionConverter.ConvertToken(bodyassignee);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ServiceDeskCoreModelsTicketTask>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tikit")]
        public IBodyWorkflowAction<ServiceDeskCoreModelsPowerAutomateTask> UpdatePowerAutomateTask([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodystatusId = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(bodystatusId, nameof(bodystatusId), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/TicketTask({0})/UpdatePowerAutomateTask", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-requested-by"] = Convert.ToString("PowerAutomate");
                var body = new JObject();
                var bodypropCount = 0;
                if (bodystatusId != null)
                {
                    body["StatusId"] = SourceExpressionConverter.ConvertToken(bodystatusId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ServiceDeskCoreModelsPowerAutomateTask>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tikit")]
        public IBodyWorkflowAction<GetApprovalsResponse> GetApprovals([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> lifecycle = null, [WorkflowExpression] Func<string> phase = null, [WorkflowExpression] Func<string> approvalName = null, [WorkflowExpression] Func<string> approvers = null, [WorkflowExpression] Func<string> additionalDetails = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(lifecycle, nameof(lifecycle), required: false);
            SourceExpression.Validate(phase, nameof(phase), required: false);
            SourceExpression.Validate(approvalName, nameof(approvalName), required: false);
            SourceExpression.Validate(approvers, nameof(approvers), required: false);
            SourceExpression.Validate(additionalDetails, nameof(additionalDetails), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/Ticket({0})/GetApprovals", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (lifecycle != null)
                    callPayload.Queries["Lifecycle"] = SourceExpressionConverter.ConvertO(lifecycle);
                if (phase != null)
                    callPayload.Queries["Phase"] = SourceExpressionConverter.ConvertO(phase);
                if (approvalName != null)
                    callPayload.Queries["ApprovalName"] = SourceExpressionConverter.ConvertO(approvalName);
                if (approvers != null)
                    callPayload.Queries["Approvers"] = SourceExpressionConverter.ConvertO(approvers);
                if (additionalDetails != null)
                    callPayload.Queries["AdditionalDetails"] = SourceExpressionConverter.ConvertO(additionalDetails);
                callPayload.Headers["x-requested-by"] = Convert.ToString("PowerAutomate");
                return callPayload;
            }

            return new ApiConnectionAction<GetApprovalsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tikit")]
        public IBodyWorkflowAction<ServiceDeskCoreModelsApprovals> UpdateApproval([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodytitle = null, [WorkflowExpression] Func<string> bodyadditionalDetails = null, [WorkflowExpression] Func<bodyrequiredByAllInput> bodyrequiredByAll = null, [WorkflowExpression] Func<string> bodyapprovers = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(bodytitle, nameof(bodytitle), required: false);
            SourceExpression.Validate(bodyadditionalDetails, nameof(bodyadditionalDetails), required: false);
            SourceExpression.Validate(bodyrequiredByAll, nameof(bodyrequiredByAll), required: false);
            SourceExpression.Validate(bodyapprovers, nameof(bodyapprovers), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/Approvals({0})/UpdateApproval", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-requested-by"] = Convert.ToString("PowerAutomate");
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytitle != null)
                {
                    body["Title"] = SourceExpressionConverter.ConvertToken(bodytitle);
                    bodypropCount++;
                }

                if (bodyadditionalDetails != null)
                {
                    body["AdditionalDetails"] = SourceExpressionConverter.ConvertToken(bodyadditionalDetails);
                    bodypropCount++;
                }

                if (bodyrequiredByAll != null)
                {
                    body["RequiredByAll"] = SourceExpressionConverter.Convert(bodyrequiredByAll);
                    bodypropCount++;
                }

                if (bodyapprovers != null)
                {
                    body["Approvers"] = SourceExpressionConverter.ConvertToken(bodyapprovers);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ServiceDeskCoreModelsApprovals>(BuildSourceInput);
        }
    }

    public class TikitTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<ServiceDeskCoreActionsAddWebhookWebhookParam> AddTicketWebhookTrigger([WorkflowExpression] Func<string> bodywebHookrequesters = null, [WorkflowExpression] Func<string> bodywebHookassignees = null, [WorkflowExpression] Func<string> bodywebHooktitle = null, [WorkflowExpression] Func<string> bodywebHookstatus = null, [WorkflowExpression] Func<bodywebHookpriorityInput> bodywebHookpriority = null, [WorkflowExpression] Func<int> bodywebHookgroup = null, [WorkflowExpression] Func<int> bodywebHookselectTemplate = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(bodywebHookrequesters, nameof(bodywebHookrequesters), required: false);
            SourceExpression.Validate(bodywebHookassignees, nameof(bodywebHookassignees), required: false);
            SourceExpression.Validate(bodywebHooktitle, nameof(bodywebHooktitle), required: false);
            SourceExpression.Validate(bodywebHookstatus, nameof(bodywebHookstatus), required: false);
            SourceExpression.Validate(bodywebHookpriority, nameof(bodywebHookpriority), required: false);
            SourceExpression.Validate(bodywebHookgroup, nameof(bodywebHookgroup), required: false);
            SourceExpression.Validate(bodywebHookselectTemplate, nameof(bodywebHookselectTemplate), required: false);
            ApiConnectionActionInput BuildSourceInput()
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
                    webHookObject["Requesters"] = SourceExpressionConverter.ConvertToken(bodywebHookrequesters);
                    webHookObjectpropCount++;
                }

                if (bodywebHookassignees != null)
                {
                    webHookObject["Assignees"] = SourceExpressionConverter.ConvertToken(bodywebHookassignees);
                    webHookObjectpropCount++;
                }

                if (bodywebHooktitle != null)
                {
                    webHookObject["Title"] = SourceExpressionConverter.ConvertToken(bodywebHooktitle);
                    webHookObjectpropCount++;
                }

                if (bodywebHookstatus != null)
                {
                    if (bodywebHookstatus != null)
                    {
                        webHookObject["Status"] = SourceExpressionConverter.ConvertToken(bodywebHookstatus);
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
                        webHookObject["Priority"] = SourceExpressionConverter.Convert(bodywebHookpriority);
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
                    webHookObject["GroupId"] = SourceExpressionConverter.ConvertToken(bodywebHookgroup);
                    webHookObjectpropCount++;
                }

                if (bodywebHookselectTemplate != null)
                {
                    webHookObject["TemplateId"] = SourceExpressionConverter.ConvertToken(bodywebHookselectTemplate);
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
                return callPayload;
            }

            return new ApiConnectionTrigger<ServiceDeskCoreActionsAddWebhookWebhookParam>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<ServiceDeskCoreActionsAddWebhookWebhookParam> UpdateTicketWebhookTrigger([WorkflowExpression] Func<string> bodywebHookrequesters = null, [WorkflowExpression] Func<string> bodywebHookassignees = null, [WorkflowExpression] Func<string> bodywebHooktitle = null, [WorkflowExpression] Func<string> bodywebHookstatus = null, [WorkflowExpression] Func<bodywebHookpriorityInput> bodywebHookpriority = null, [WorkflowExpression] Func<int> bodywebHookgroup = null, [WorkflowExpression] Func<int> bodywebHookselectTemplate = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(bodywebHookrequesters, nameof(bodywebHookrequesters), required: false);
            SourceExpression.Validate(bodywebHookassignees, nameof(bodywebHookassignees), required: false);
            SourceExpression.Validate(bodywebHooktitle, nameof(bodywebHooktitle), required: false);
            SourceExpression.Validate(bodywebHookstatus, nameof(bodywebHookstatus), required: false);
            SourceExpression.Validate(bodywebHookpriority, nameof(bodywebHookpriority), required: false);
            SourceExpression.Validate(bodywebHookgroup, nameof(bodywebHookgroup), required: false);
            SourceExpression.Validate(bodywebHookselectTemplate, nameof(bodywebHookselectTemplate), required: false);
            ApiConnectionActionInput BuildSourceInput()
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
                    webHookObject["Requesters"] = SourceExpressionConverter.ConvertToken(bodywebHookrequesters);
                    webHookObjectpropCount++;
                }

                if (bodywebHookassignees != null)
                {
                    webHookObject["Assignees"] = SourceExpressionConverter.ConvertToken(bodywebHookassignees);
                    webHookObjectpropCount++;
                }

                if (bodywebHooktitle != null)
                {
                    webHookObject["Title"] = SourceExpressionConverter.ConvertToken(bodywebHooktitle);
                    webHookObjectpropCount++;
                }

                if (bodywebHookstatus != null)
                {
                    if (bodywebHookstatus != null)
                    {
                        webHookObject["Status"] = SourceExpressionConverter.ConvertToken(bodywebHookstatus);
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
                        webHookObject["Priority"] = SourceExpressionConverter.Convert(bodywebHookpriority);
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
                    webHookObject["GroupId"] = SourceExpressionConverter.ConvertToken(bodywebHookgroup);
                    webHookObjectpropCount++;
                }

                if (bodywebHookselectTemplate != null)
                {
                    webHookObject["TemplateId"] = SourceExpressionConverter.ConvertToken(bodywebHookselectTemplate);
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
                return callPayload;
            }

            return new ApiConnectionTrigger<ServiceDeskCoreActionsAddWebhookWebhookParam>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<ServiceDeskCoreActionsAddWebhookWebhookParam> AddCommentTicketWebhook([WorkflowExpression] Func<string> bodywebHookcommenter = null, [WorkflowExpression] Func<string> bodywebHookcommentStringContain = null, [WorkflowExpression] Func<bodywebHookisPublicCommentInput> bodywebHookisPublicComment = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(bodywebHookcommenter, nameof(bodywebHookcommenter), required: false);
            SourceExpression.Validate(bodywebHookcommentStringContain, nameof(bodywebHookcommentStringContain), required: false);
            SourceExpression.Validate(bodywebHookisPublicComment, nameof(bodywebHookisPublicComment), required: false);
            ApiConnectionActionInput BuildSourceInput()
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
                    webHookObject["Commenter"] = SourceExpressionConverter.ConvertToken(bodywebHookcommenter);
                    webHookObjectpropCount++;
                }

                if (bodywebHookcommentStringContain != null)
                {
                    webHookObject["CommentStringContain"] = SourceExpressionConverter.ConvertToken(bodywebHookcommentStringContain);
                    webHookObjectpropCount++;
                }

                if (bodywebHookisPublicComment != null)
                {
                    if (bodywebHookisPublicComment != null)
                    {
                        webHookObject["IsPublicComment"] = SourceExpressionConverter.Convert(bodywebHookisPublicComment);
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
                return callPayload;
            }

            return new ApiConnectionTrigger<ServiceDeskCoreActionsAddWebhookWebhookParam>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<ServiceDeskCoreModelsTicketTask> ActivatePowerAutomateTaskWebhook([WorkflowExpression] Func<string> bodywebHooklifecycleId = null, [WorkflowExpression] Func<int> bodywebHooklifecyclePhaseId = null, [WorkflowExpression] Func<string> bodywebHooklifecyclePowerAutomateName = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(bodywebHooklifecycleId, nameof(bodywebHooklifecycleId), required: false);
            SourceExpression.Validate(bodywebHooklifecyclePhaseId, nameof(bodywebHooklifecyclePhaseId), required: false);
            SourceExpression.Validate(bodywebHooklifecyclePowerAutomateName, nameof(bodywebHooklifecyclePowerAutomateName), required: false);
            ApiConnectionActionInput BuildSourceInput()
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
                    webHookObject["LifecycleId"] = SourceExpressionConverter.ConvertToken(bodywebHooklifecycleId);
                    webHookObjectpropCount++;
                }

                if (bodywebHooklifecyclePhaseId != null)
                {
                    webHookObject["LifecyclePhaseId"] = SourceExpressionConverter.ConvertToken(bodywebHooklifecyclePhaseId);
                    webHookObjectpropCount++;
                }

                if (bodywebHooklifecyclePowerAutomateName != null)
                {
                    webHookObject["LifecyclePowerAutomateName"] = SourceExpressionConverter.ConvertToken(bodywebHooklifecyclePowerAutomateName);
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
                return callPayload;
            }

            return new ApiConnectionTrigger<ServiceDeskCoreModelsTicketTask>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<ServiceDeskCoreActionsAddWebhookWebhookParam> ChangeLifecyclePhaseWebhook([WorkflowExpression] Func<string> bodywebHooklifecycleId = null, [WorkflowExpression] Func<int> bodywebHooklifecyclePhaseId = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(bodywebHooklifecycleId, nameof(bodywebHooklifecycleId), required: false);
            SourceExpression.Validate(bodywebHooklifecyclePhaseId, nameof(bodywebHooklifecyclePhaseId), required: false);
            ApiConnectionActionInput BuildSourceInput()
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
                    webHookObject["LifecycleId"] = SourceExpressionConverter.ConvertToken(bodywebHooklifecycleId);
                    webHookObjectpropCount++;
                }

                if (bodywebHooklifecyclePhaseId != null)
                {
                    webHookObject["LifecyclePhaseId"] = SourceExpressionConverter.ConvertToken(bodywebHooklifecyclePhaseId);
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
                return callPayload;
            }

            return new ApiConnectionTrigger<ServiceDeskCoreActionsAddWebhookWebhookParam>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<ServiceDeskCoreActionsAddWebhookWebhookParam> EngageLifecycleTransitionWebhook([WorkflowExpression] Func<string> bodywebHooklifecycleId = null, [WorkflowExpression] Func<int> bodywebHooklifecyclePhaseId = null, [WorkflowExpression] Func<int> bodywebHooklifecycleTransitionId = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(bodywebHooklifecycleId, nameof(bodywebHooklifecycleId), required: false);
            SourceExpression.Validate(bodywebHooklifecyclePhaseId, nameof(bodywebHooklifecyclePhaseId), required: false);
            SourceExpression.Validate(bodywebHooklifecycleTransitionId, nameof(bodywebHooklifecycleTransitionId), required: false);
            ApiConnectionActionInput BuildSourceInput()
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
                    webHookObject["LifecycleId"] = SourceExpressionConverter.ConvertToken(bodywebHooklifecycleId);
                    webHookObjectpropCount++;
                }

                if (bodywebHooklifecyclePhaseId != null)
                {
                    webHookObject["LifecyclePhaseId"] = SourceExpressionConverter.ConvertToken(bodywebHooklifecyclePhaseId);
                    webHookObjectpropCount++;
                }

                if (bodywebHooklifecycleTransitionId != null)
                {
                    webHookObject["LifecycleTransitionId"] = SourceExpressionConverter.ConvertToken(bodywebHooklifecycleTransitionId);
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
                return callPayload;
            }

            return new ApiConnectionTrigger<ServiceDeskCoreActionsAddWebhookWebhookParam>(BuildSourceInput, triggerName, recurrence);
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