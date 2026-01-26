//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Deskdirector
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class DeskdirectorActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deskdirector")]
        public IBodyWorkflowAction<JToken> FindTicketTaskTemplates(Expression<Func<object>> req = null)
        {
            var apiCallPath = "/api/v2/automate/connector/ticket-task-templates/find";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertO(req);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deskdirector")]
        public IBodyWorkflowAction<JToken> GetTicketTasks(Expression<Func<int>> ticketId)
        {
            var apiCallPath = String.Format("/api/v2/automate/connector/tickets/{0}/tasks", ExpressionConverter.ConvertWithUrlEncoding(ticketId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deskdirector")]
        public IBodyWorkflowAction<JToken> CreateTicketTasks(Expression<Func<int>> ticketId, Expression<Func<object>> req = null)
        {
            var apiCallPath = String.Format("/api/v2/automate/connector/tickets/{0}/tasks", ExpressionConverter.ConvertWithUrlEncoding(ticketId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertO(req);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deskdirector")]
        public IBodyWorkflowAction<JToken> FindCompanies(Expression<Func<object>> req = null)
        {
            var apiCallPath = "/api/v2/automate/connector/companies/find";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertO(req);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deskdirector")]
        public IBodyWorkflowAction<JToken> GetCompany(Expression<Func<int>> companyId)
        {
            var apiCallPath = String.Format("/api/v2/automate/connector/companies/{0}", ExpressionConverter.ConvertWithUrlEncoding(companyId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deskdirector")]
        public IBodyWorkflowAction<JToken> FindUserGroups(Expression<Func<object>> req = null)
        {
            var apiCallPath = "/api/v2/automate/connector/user-groups/find";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertO(req);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deskdirector")]
        public IBodyWorkflowAction<JToken> CreateContact(Expression<Func<object>> req = null)
        {
            var apiCallPath = "/api/v2/automate/connector/contacts";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertO(req);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deskdirector")]
        public IBodyWorkflowAction<JToken> FindContacts(Expression<Func<object>> req = null)
        {
            var apiCallPath = "/api/v2/automate/connector/contacts/find";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertO(req);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deskdirector")]
        public IBodyWorkflowAction<JToken> GetContact(Expression<Func<int>> contactId)
        {
            var apiCallPath = String.Format("/api/v2/automate/connector/contacts/{0}", ExpressionConverter.ConvertWithUrlEncoding(contactId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deskdirector")]
        public IBodyWorkflowAction<JToken> GenerateEmailFromTemplate(Expression<Func<string>> emailTemplateId, Expression<Func<object>> req = null)
        {
            var apiCallPath = String.Format("/api/v2/automate/connector/email-templates/{0}/render", ExpressionConverter.ConvertWithUrlEncoding(emailTemplateId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertO(req);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deskdirector")]
        public IBodyWorkflowAction<JToken> FindMembers(Expression<Func<object>> req = null)
        {
            var apiCallPath = "/api/v2/automate/connector/members/find";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertO(req);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deskdirector")]
        public IBodyWorkflowAction<JToken> GetMember(Expression<Func<int>> memberId)
        {
            var apiCallPath = String.Format("/api/v2/automate/connector/members/{0}", ExpressionConverter.ConvertWithUrlEncoding(memberId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deskdirector")]
        public IBodyWorkflowAction<JToken> CreateContactNotification(Expression<Func<int>> contactId, Expression<Func<object>> req = null)
        {
            var apiCallPath = String.Format("/api/v2/automate/connector/contacts/{0}/notifications", ExpressionConverter.ConvertWithUrlEncoding(contactId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertO(req);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deskdirector")]
        public IBodyWorkflowAction<JToken> CreateMemberNotification(Expression<Func<int>> memberId, Expression<Func<object>> req = null)
        {
            var apiCallPath = String.Format("/api/v2/automate/connector/members/{0}/notifications", ExpressionConverter.ConvertWithUrlEncoding(memberId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertO(req);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deskdirector")]
        public IBodyWorkflowAction<JToken> CreateTicket(Expression<Func<int>> requestTypeId, Expression<Func<object>> req = null)
        {
            var apiCallPath = "/api/v2/automate/connector/tickets";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["requestTypeId"] = ExpressionConverter.Convert(requestTypeId);
            callPayload.Body = ExpressionConverter.ConvertO(req);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deskdirector")]
        public IBodyWorkflowAction<JToken> FindTickets(Expression<Func<object>> req = null)
        {
            var apiCallPath = "/api/v2/automate/connector/tickets/find";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertO(req);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deskdirector")]
        public IBodyWorkflowAction<JToken> GetTicket(Expression<Func<int>> ticketId)
        {
            var apiCallPath = String.Format("/api/v2/automate/connector/tickets/{0}", ExpressionConverter.ConvertWithUrlEncoding(ticketId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deskdirector")]
        public IBodyWorkflowAction<JToken> UpdateTicket(Expression<Func<int>> ticketId, Expression<Func<object>> req = null)
        {
            var apiCallPath = String.Format("/api/v2/automate/connector/tickets/{0}", ExpressionConverter.ConvertWithUrlEncoding(ticketId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertO(req);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deskdirector")]
        public IBodyWorkflowAction<JToken> GetChatSession(Expression<Func<string>> sessionId)
        {
            var apiCallPath = String.Format("/api/v2/automate/connector/chat-sessions/{0}", ExpressionConverter.ConvertWithUrlEncoding(sessionId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deskdirector")]
        public IBodyWorkflowAction<JToken> AddChatSystemMessage(Expression<Func<string>> sessionId, Expression<Func<object>> req = null)
        {
            var apiCallPath = String.Format("/api/v2/automate/connector/chat-sessions/{0}/system-messages", ExpressionConverter.ConvertWithUrlEncoding(sessionId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertO(req);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deskdirector")]
        public IBodyWorkflowAction<JToken> InviteUsersToChat(Expression<Func<string>> sessionId, Expression<Func<object>> req = null)
        {
            var apiCallPath = String.Format("/api/v2/automate/connector/chat-sessions/{0}/invite", ExpressionConverter.ConvertWithUrlEncoding(sessionId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertO(req);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deskdirector")]
        public IBodyWorkflowAction<JToken> GetFormResultV2(Expression<Func<int>> formId, Expression<Func<int>> resultId)
        {
            var apiCallPath = String.Format("/api/v2/automate/connector/v2/forms/{0}/results/{1}", ExpressionConverter.ConvertWithUrlEncoding(formId, 1), ExpressionConverter.ConvertWithUrlEncoding(resultId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deskdirector")]
        public IBodyWorkflowAction<JToken> CallAdvancedAction(Expression<Func<string>> category, Expression<Func<string>> function, Expression<Func<object>> req = null)
        {
            var apiCallPath = String.Format("/api/v2/automate/connector/functions/{0}", ExpressionConverter.ConvertWithUrlEncoding(function, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["category"] = ExpressionConverter.Convert(category);
            callPayload.Body = ExpressionConverter.ConvertO(req);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deskdirector")]
        public IBodyWorkflowAction<JToken> AdvancedEventResponseHandle(Expression<Func<string>> category, Expression<Func<string>> eventType, Expression<Func<string>> eventId, Expression<Func<object>> req = null)
        {
            var apiCallPath = String.Format("/api/v2/automate/connector/events/{0}/{1}/response", ExpressionConverter.ConvertWithUrlEncoding(eventType, 1), ExpressionConverter.ConvertWithUrlEncoding(eventId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["category"] = ExpressionConverter.Convert(category);
            callPayload.Body = ExpressionConverter.ConvertO(req);
            return new ApiConnectionAction<JToken>(callPayload);
        }
    }

    public class DeskdirectorTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<JToken> CreateChatWebhook(Expression<Func<string>> type, Expression<Func<object>> reqparameters, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/api/v2/automate/connector/chat-workflows";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["type"] = ExpressionConverter.Convert(type);
            var req = new JObject();
            var reqpropCount = 0;
            reqpropCount++;
            req["parameters"] = ExpressionConverter.ConvertO(reqparameters);
            req["url"] = "@listCallbackUrl()";
            reqpropCount++;
            if (reqpropCount > 0)
            {
                callPayload.Body = req;
            }

            return new ApiConnectionTrigger<JToken>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<JToken> CreateTicketWorkflow(Expression<Func<string>> type, Expression<Func<string>> reqdescription, Expression<Func<object>> reqadvancedFilters, Expression<Func<int>> reqboard = null, Expression<Func<int>> reqstatus = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/api/v2/automate/connector/ticket-workflows";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["type"] = ExpressionConverter.Convert(type);
            var req = new JObject();
            var reqpropCount = 0;
            reqpropCount++;
            req["description"] = ExpressionConverter.ConvertO(reqdescription);
            if (reqboard != null)
            {
                req["boardId"] = ExpressionConverter.ConvertO(reqboard);
                reqpropCount++;
            }

            if (reqstatus != null)
            {
                req["statusId"] = ExpressionConverter.ConvertO(reqstatus);
                reqpropCount++;
            }

            reqpropCount++;
            req["advancedFilters"] = ExpressionConverter.ConvertO(reqadvancedFilters);
            req["url"] = "@listCallbackUrl()";
            reqpropCount++;
            if (reqpropCount > 0)
            {
                callPayload.Body = req;
            }

            return new ApiConnectionTrigger<JToken>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<JToken> SubscribeToWorkflow(Expression<Func<string>> type, Expression<Func<string>> workflowId, Expression<Func<object>> reqparameters, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = String.Format("/api/v2/automate/connector/workflows/{0}/actions", ExpressionConverter.ConvertWithUrlEncoding(workflowId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["type"] = ExpressionConverter.Convert(type);
            var req = new JObject();
            var reqpropCount = 0;
            req["url"] = "@listCallbackUrl()";
            reqpropCount++;
            reqpropCount++;
            req["parameters"] = ExpressionConverter.ConvertO(reqparameters);
            if (reqpropCount > 0)
            {
                callPayload.Body = req;
            }

            return new ApiConnectionTrigger<JToken>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<JToken> AdvancedEventSubscribe(Expression<Func<string>> category, Expression<Func<string>> eventType, Expression<Func<object>> reqparameters, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = String.Format("/api/v2/automate/connector/events/{0}/subscriptions", ExpressionConverter.ConvertWithUrlEncoding(eventType, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["category"] = ExpressionConverter.Convert(category);
            var req = new JObject();
            var reqpropCount = 0;
            req["url"] = "@listCallbackUrl()";
            reqpropCount++;
            reqpropCount++;
            req["parameters"] = ExpressionConverter.ConvertO(reqparameters);
            if (reqpropCount > 0)
            {
                callPayload.Body = req;
            }

            return new ApiConnectionTrigger<JToken>(callPayload, triggerName, recurrence);
        }
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