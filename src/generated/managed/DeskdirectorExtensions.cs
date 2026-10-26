//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Deskdirector
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class DeskdirectorActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deskdirector")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> FindTicketTaskTemplates(Expression<Func<object>> req)
        {
            var __workflow_req = WorkflowExpression.Compile(req, nameof(req), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v2/automate/connector/ticket-task-templates/find";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_req);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deskdirector")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> GetTicketTasks(Expression<Func<int>> ticketId)
        {
            var __workflow_ticketId = WorkflowExpression.Compile(ticketId, nameof(ticketId), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v2/automate/connector/tickets/{0}/tasks", __workflow_ticketId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deskdirector")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> CreateTicketTasks(Expression<Func<int>> ticketId, Expression<Func<object>> req)
        {
            var __workflow_ticketId = WorkflowExpression.Compile(ticketId, nameof(ticketId), required: true);
            var __workflow_req = WorkflowExpression.Compile(req, nameof(req), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v2/automate/connector/tickets/{0}/tasks", __workflow_ticketId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_req);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deskdirector")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> FindCompanies(Expression<Func<object>> req)
        {
            var __workflow_req = WorkflowExpression.Compile(req, nameof(req), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v2/automate/connector/companies/find";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_req);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deskdirector")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> GetCompany(Expression<Func<int>> companyId)
        {
            var __workflow_companyId = WorkflowExpression.Compile(companyId, nameof(companyId), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v2/automate/connector/companies/{0}", __workflow_companyId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deskdirector")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> FindUserGroups(Expression<Func<object>> req)
        {
            var __workflow_req = WorkflowExpression.Compile(req, nameof(req), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v2/automate/connector/user-groups/find";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_req);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deskdirector")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> CreateContact(Expression<Func<object>> req)
        {
            var __workflow_req = WorkflowExpression.Compile(req, nameof(req), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v2/automate/connector/contacts";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_req);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deskdirector")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> FindContacts(Expression<Func<object>> req)
        {
            var __workflow_req = WorkflowExpression.Compile(req, nameof(req), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v2/automate/connector/contacts/find";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_req);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deskdirector")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> GetContact(Expression<Func<int>> contactId)
        {
            var __workflow_contactId = WorkflowExpression.Compile(contactId, nameof(contactId), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v2/automate/connector/contacts/{0}", __workflow_contactId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deskdirector")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> GenerateEmailFromTemplate(Expression<Func<string>> emailTemplateId, Expression<Func<object>> req)
        {
            var __workflow_emailTemplateId = WorkflowExpression.Compile(emailTemplateId, nameof(emailTemplateId), required: true);
            var __workflow_req = WorkflowExpression.Compile(req, nameof(req), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v2/automate/connector/email-templates/{0}/render", __workflow_emailTemplateId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_req);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deskdirector")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> FindMembers(Expression<Func<object>> req)
        {
            var __workflow_req = WorkflowExpression.Compile(req, nameof(req), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v2/automate/connector/members/find";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_req);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deskdirector")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> GetMember(Expression<Func<int>> memberId)
        {
            var __workflow_memberId = WorkflowExpression.Compile(memberId, nameof(memberId), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v2/automate/connector/members/{0}", __workflow_memberId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deskdirector")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> CreateContactNotification(Expression<Func<int>> contactId, Expression<Func<object>> req)
        {
            var __workflow_contactId = WorkflowExpression.Compile(contactId, nameof(contactId), required: true);
            var __workflow_req = WorkflowExpression.Compile(req, nameof(req), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v2/automate/connector/contacts/{0}/notifications", __workflow_contactId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_req);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deskdirector")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> CreateMemberNotification(Expression<Func<int>> memberId, Expression<Func<object>> req)
        {
            var __workflow_memberId = WorkflowExpression.Compile(memberId, nameof(memberId), required: true);
            var __workflow_req = WorkflowExpression.Compile(req, nameof(req), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v2/automate/connector/members/{0}/notifications", __workflow_memberId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_req);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deskdirector")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> CreateTicket(Expression<Func<int>> requestTypeId, Expression<Func<object>> req)
        {
            var __workflow_requestTypeId = WorkflowExpression.Compile(requestTypeId, nameof(requestTypeId), required: true);
            var __workflow_req = WorkflowExpression.Compile(req, nameof(req), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v2/automate/connector/tickets";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["requestTypeId"] = ExpressionConverter.Convert(__workflow_requestTypeId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_req);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deskdirector")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> FindTickets(Expression<Func<object>> req)
        {
            var __workflow_req = WorkflowExpression.Compile(req, nameof(req), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v2/automate/connector/tickets/find";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_req);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deskdirector")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> GetTicket(Expression<Func<int>> ticketId)
        {
            var __workflow_ticketId = WorkflowExpression.Compile(ticketId, nameof(ticketId), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v2/automate/connector/tickets/{0}", __workflow_ticketId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deskdirector")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> UpdateTicket(Expression<Func<object>> req, Expression<Func<int>> ticketId)
        {
            var __workflow_req = WorkflowExpression.Compile(req, nameof(req), required: true);
            var __workflow_ticketId = WorkflowExpression.Compile(ticketId, nameof(ticketId), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v2/automate/connector/tickets/{0}", __workflow_ticketId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_req);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deskdirector")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> GetChatSession(Expression<Func<string>> sessionId)
        {
            var __workflow_sessionId = WorkflowExpression.Compile(sessionId, nameof(sessionId), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v2/automate/connector/chat-sessions/{0}", __workflow_sessionId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deskdirector")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> AddChatSystemMessage(Expression<Func<string>> sessionId, Expression<Func<object>> req)
        {
            var __workflow_sessionId = WorkflowExpression.Compile(sessionId, nameof(sessionId), required: true);
            var __workflow_req = WorkflowExpression.Compile(req, nameof(req), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v2/automate/connector/chat-sessions/{0}/system-messages", __workflow_sessionId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_req);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deskdirector")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> InviteUsersToChat(Expression<Func<string>> sessionId, Expression<Func<object>> req)
        {
            var __workflow_sessionId = WorkflowExpression.Compile(sessionId, nameof(sessionId), required: true);
            var __workflow_req = WorkflowExpression.Compile(req, nameof(req), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v2/automate/connector/chat-sessions/{0}/invite", __workflow_sessionId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_req);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deskdirector")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> CallAdvancedAction(Expression<Func<string>> category, Expression<Func<string>> function, Expression<Func<object>> req)
        {
            var __workflow_category = WorkflowExpression.Compile(category, nameof(category), required: true);
            var __workflow_function = WorkflowExpression.Compile(function, nameof(function), required: true);
            var __workflow_req = WorkflowExpression.Compile(req, nameof(req), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v2/automate/connector/functions/{0}", __workflow_function.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["category"] = ExpressionConverter.Convert(__workflow_category);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_req);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deskdirector")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> AdvancedEventResponseHandle(Expression<Func<string>> category, Expression<Func<string>> eventType, Expression<Func<string>> eventId, Expression<Func<object>> req)
        {
            var __workflow_category = WorkflowExpression.Compile(category, nameof(category), required: true);
            var __workflow_eventType = WorkflowExpression.Compile(eventType, nameof(eventType), required: true);
            var __workflow_eventId = WorkflowExpression.Compile(eventId, nameof(eventId), required: true);
            var __workflow_req = WorkflowExpression.Compile(req, nameof(req), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v2/automate/connector/events/{0}/{1}/response", __workflow_eventType.WithUrlEncoding(1), __workflow_eventId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["category"] = ExpressionConverter.Convert(__workflow_category);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_req);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deskdirector")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> GetFormResult(Expression<Func<int>> formId, Expression<Func<int>> resultId)
        {
            var __workflow_formId = WorkflowExpression.Compile(formId, nameof(formId), required: true);
            var __workflow_resultId = WorkflowExpression.Compile(resultId, nameof(resultId), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v2/automate/connector/v2/forms/{0}/results/{1}", __workflow_formId.WithUrlEncoding(1), __workflow_resultId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }
    }

    public class DeskdirectorTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<JToken, ApiConnectionTriggerConfiguration> CreateChatWebhook(Expression<Func<string>> type, Expression<Func<CreateChatWebhookInput>> req, FlowRecurrence recurrence = null)
        {
            var __workflow_type = WorkflowExpression.Compile(type, nameof(type), required: true);
            var __workflow_req = WorkflowExpression.Compile(req, nameof(req), required: true);
            return new DeferredBodyTrigger<JToken, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/api/v2/automate/connector/chat-workflows";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["type"] = ExpressionConverter.Convert(__workflow_type);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_req);
                return new ApiConnectionTrigger<JToken>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<JToken, ApiConnectionTriggerConfiguration> CreateTicketWorkflow(Expression<Func<string>> type, Expression<Func<CreateTicketWorkflowInput>> req, FlowRecurrence recurrence = null)
        {
            var __workflow_type = WorkflowExpression.Compile(type, nameof(type), required: true);
            var __workflow_req = WorkflowExpression.Compile(req, nameof(req), required: true);
            return new DeferredBodyTrigger<JToken, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/api/v2/automate/connector/ticket-workflows";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["type"] = ExpressionConverter.Convert(__workflow_type);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_req);
                return new ApiConnectionTrigger<JToken>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<JToken, ApiConnectionTriggerConfiguration> SubscribeToWorkflow(Expression<Func<string>> type, Expression<Func<string>> workflowId, Expression<Func<SubscribeToWorkflowInput>> req, FlowRecurrence recurrence = null)
        {
            var __workflow_type = WorkflowExpression.Compile(type, nameof(type), required: true);
            var __workflow_workflowId = WorkflowExpression.Compile(workflowId, nameof(workflowId), required: true);
            var __workflow_req = WorkflowExpression.Compile(req, nameof(req), required: true);
            return new DeferredBodyTrigger<JToken, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v2/automate/connector/workflows/{0}/actions", __workflow_workflowId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["type"] = ExpressionConverter.Convert(__workflow_type);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_req);
                return new ApiConnectionTrigger<JToken>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<JToken, ApiConnectionTriggerConfiguration> AdvancedEventSubscribe(Expression<Func<string>> category, Expression<Func<string>> eventType, Expression<Func<AdvancedEventSubscribeInput>> req, FlowRecurrence recurrence = null)
        {
            var __workflow_category = WorkflowExpression.Compile(category, nameof(category), required: true);
            var __workflow_eventType = WorkflowExpression.Compile(eventType, nameof(eventType), required: true);
            var __workflow_req = WorkflowExpression.Compile(req, nameof(req), required: true);
            return new DeferredBodyTrigger<JToken, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v2/automate/connector/events/{0}/subscriptions", __workflow_eventType.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["category"] = ExpressionConverter.Convert(__workflow_category);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_req);
                return new ApiConnectionTrigger<JToken>(callPayload, recurrence: recurrence);
            });
        }
    }

    public class CreateChatWebhookInput
    {
        [JsonProperty("parameters", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken Parameters { get; set; }

        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string URL { get; set; } = "#{listCallbackUrl()}";
    }

    public class CreateTicketWorkflowInput
    {
        [JsonProperty("description", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Description { get; set; }

        [JsonProperty("boardId")]
        public int? Board { get; set; }

        [JsonProperty("statusId")]
        public int? Status { get; set; }

        [JsonProperty("advancedFilters", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken AdvancedFilters { get; set; }

        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string URL { get; set; } = "#{listCallbackUrl()}";
    }

    public class SubscribeToWorkflowInput
    {
        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Url { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty("parameters", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken Parameters { get; set; }
    }

    public class AdvancedEventSubscribeInput
    {
        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Url { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty("parameters", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken Parameters { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Deskdirector;

    public partial class WorkflowManagedActions
    {
        public DeskdirectorActions Deskdirector(string connectionId) => new DeskdirectorActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public DeskdirectorTriggers Deskdirector(string connectionId) => new DeskdirectorTriggers(connectionId);
    }
}