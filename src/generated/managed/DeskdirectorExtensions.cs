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
        public IBodyWorkflowAction<JToken> FindTicketTaskTemplates([WorkflowExpression] Func<object> req = null)
        {
            SourceExpression.Validate(req, nameof(req), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/v2/automate/connector/ticket-task-templates/find";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = SourceExpressionConverter.ConvertToken(req);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deskdirector")]
        public IBodyWorkflowAction<JToken> GetTicketTasks([WorkflowExpression] Func<int> ticketId)
        {
            SourceExpression.Validate(ticketId, nameof(ticketId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v2/automate/connector/tickets/{0}/tasks", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(ticketId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deskdirector")]
        public IBodyWorkflowAction<JToken> CreateTicketTasks([WorkflowExpression] Func<int> ticketId, [WorkflowExpression] Func<object> req = null)
        {
            SourceExpression.Validate(ticketId, nameof(ticketId), required: true);
            SourceExpression.Validate(req, nameof(req), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v2/automate/connector/tickets/{0}/tasks", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(ticketId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = SourceExpressionConverter.ConvertToken(req);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deskdirector")]
        public IBodyWorkflowAction<JToken> FindCompanies([WorkflowExpression] Func<object> req = null)
        {
            SourceExpression.Validate(req, nameof(req), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/v2/automate/connector/companies/find";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = SourceExpressionConverter.ConvertToken(req);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deskdirector")]
        public IBodyWorkflowAction<JToken> GetCompany([WorkflowExpression] Func<int> companyId)
        {
            SourceExpression.Validate(companyId, nameof(companyId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v2/automate/connector/companies/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(companyId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deskdirector")]
        public IBodyWorkflowAction<JToken> FindUserGroups([WorkflowExpression] Func<object> req = null)
        {
            SourceExpression.Validate(req, nameof(req), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/v2/automate/connector/user-groups/find";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = SourceExpressionConverter.ConvertToken(req);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deskdirector")]
        public IBodyWorkflowAction<JToken> CreateContact([WorkflowExpression] Func<object> req = null)
        {
            SourceExpression.Validate(req, nameof(req), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/v2/automate/connector/contacts";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = SourceExpressionConverter.ConvertToken(req);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deskdirector")]
        public IBodyWorkflowAction<JToken> FindContacts([WorkflowExpression] Func<object> req = null)
        {
            SourceExpression.Validate(req, nameof(req), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/v2/automate/connector/contacts/find";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = SourceExpressionConverter.ConvertToken(req);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deskdirector")]
        public IBodyWorkflowAction<JToken> GetContact([WorkflowExpression] Func<int> contactId)
        {
            SourceExpression.Validate(contactId, nameof(contactId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v2/automate/connector/contacts/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(contactId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deskdirector")]
        public IBodyWorkflowAction<JToken> GenerateEmailFromTemplate([WorkflowExpression] Func<string> emailTemplateId, [WorkflowExpression] Func<object> req = null)
        {
            SourceExpression.Validate(emailTemplateId, nameof(emailTemplateId), required: true);
            SourceExpression.Validate(req, nameof(req), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v2/automate/connector/email-templates/{0}/render", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(emailTemplateId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = SourceExpressionConverter.ConvertToken(req);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deskdirector")]
        public IBodyWorkflowAction<JToken> FindMembers([WorkflowExpression] Func<object> req = null)
        {
            SourceExpression.Validate(req, nameof(req), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/v2/automate/connector/members/find";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = SourceExpressionConverter.ConvertToken(req);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deskdirector")]
        public IBodyWorkflowAction<JToken> GetMember([WorkflowExpression] Func<int> memberId)
        {
            SourceExpression.Validate(memberId, nameof(memberId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v2/automate/connector/members/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(memberId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deskdirector")]
        public IBodyWorkflowAction<JToken> CreateContactNotification([WorkflowExpression] Func<int> contactId, [WorkflowExpression] Func<object> req = null)
        {
            SourceExpression.Validate(contactId, nameof(contactId), required: true);
            SourceExpression.Validate(req, nameof(req), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v2/automate/connector/contacts/{0}/notifications", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(contactId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = SourceExpressionConverter.ConvertToken(req);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deskdirector")]
        public IBodyWorkflowAction<JToken> CreateMemberNotification([WorkflowExpression] Func<int> memberId, [WorkflowExpression] Func<object> req = null)
        {
            SourceExpression.Validate(memberId, nameof(memberId), required: true);
            SourceExpression.Validate(req, nameof(req), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v2/automate/connector/members/{0}/notifications", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(memberId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = SourceExpressionConverter.ConvertToken(req);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deskdirector")]
        public IBodyWorkflowAction<JToken> CreateTicket([WorkflowExpression] Func<int> requestTypeId, [WorkflowExpression] Func<object> req = null)
        {
            SourceExpression.Validate(requestTypeId, nameof(requestTypeId), required: true);
            SourceExpression.Validate(req, nameof(req), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/v2/automate/connector/tickets";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["requestTypeId"] = SourceExpressionConverter.ConvertO(requestTypeId);
                callPayload.Body = SourceExpressionConverter.ConvertToken(req);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deskdirector")]
        public IBodyWorkflowAction<JToken> FindTickets([WorkflowExpression] Func<object> req = null)
        {
            SourceExpression.Validate(req, nameof(req), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/v2/automate/connector/tickets/find";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = SourceExpressionConverter.ConvertToken(req);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deskdirector")]
        public IBodyWorkflowAction<JToken> GetTicket([WorkflowExpression] Func<int> ticketId)
        {
            SourceExpression.Validate(ticketId, nameof(ticketId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v2/automate/connector/tickets/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(ticketId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deskdirector")]
        public IBodyWorkflowAction<JToken> UpdateTicket([WorkflowExpression] Func<int> ticketId, [WorkflowExpression] Func<object> req = null)
        {
            SourceExpression.Validate(ticketId, nameof(ticketId), required: true);
            SourceExpression.Validate(req, nameof(req), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v2/automate/connector/tickets/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(ticketId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = SourceExpressionConverter.ConvertToken(req);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deskdirector")]
        public IBodyWorkflowAction<JToken> GetChatSession([WorkflowExpression] Func<string> sessionId)
        {
            SourceExpression.Validate(sessionId, nameof(sessionId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v2/automate/connector/chat-sessions/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(sessionId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deskdirector")]
        public IBodyWorkflowAction<JToken> AddChatSystemMessage([WorkflowExpression] Func<string> sessionId, [WorkflowExpression] Func<object> req = null)
        {
            SourceExpression.Validate(sessionId, nameof(sessionId), required: true);
            SourceExpression.Validate(req, nameof(req), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v2/automate/connector/chat-sessions/{0}/system-messages", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(sessionId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = SourceExpressionConverter.ConvertToken(req);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deskdirector")]
        public IBodyWorkflowAction<JToken> InviteUsersToChat([WorkflowExpression] Func<string> sessionId, [WorkflowExpression] Func<object> req = null)
        {
            SourceExpression.Validate(sessionId, nameof(sessionId), required: true);
            SourceExpression.Validate(req, nameof(req), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v2/automate/connector/chat-sessions/{0}/invite", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(sessionId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = SourceExpressionConverter.ConvertToken(req);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deskdirector")]
        public IBodyWorkflowAction<JToken> CallAdvancedAction([WorkflowExpression] Func<string> category, [WorkflowExpression] Func<string> function, [WorkflowExpression] Func<object> req = null)
        {
            SourceExpression.Validate(category, nameof(category), required: true);
            SourceExpression.Validate(function, nameof(function), required: true);
            SourceExpression.Validate(req, nameof(req), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v2/automate/connector/functions/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(function, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["category"] = SourceExpressionConverter.ConvertO(category);
                callPayload.Body = SourceExpressionConverter.ConvertToken(req);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deskdirector")]
        public IBodyWorkflowAction<JToken> AdvancedEventResponseHandle([WorkflowExpression] Func<string> category, [WorkflowExpression] Func<string> eventType, [WorkflowExpression] Func<string> eventId, [WorkflowExpression] Func<object> req = null)
        {
            SourceExpression.Validate(category, nameof(category), required: true);
            SourceExpression.Validate(eventType, nameof(eventType), required: true);
            SourceExpression.Validate(eventId, nameof(eventId), required: true);
            SourceExpression.Validate(req, nameof(req), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v2/automate/connector/events/{0}/{1}/response", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(eventType, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(eventId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["category"] = SourceExpressionConverter.ConvertO(category);
                callPayload.Body = SourceExpressionConverter.ConvertToken(req);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deskdirector")]
        public IBodyWorkflowAction<JToken> GetFormResult([WorkflowExpression] Func<int> formId, [WorkflowExpression] Func<int> resultId)
        {
            SourceExpression.Validate(formId, nameof(formId), required: true);
            SourceExpression.Validate(resultId, nameof(resultId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v2/automate/connector/v2/forms/{0}/results/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(formId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(resultId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }
    }

    public class DeskdirectorTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<JToken> CreateChatWebhook([WorkflowExpression] Func<string> type, [WorkflowExpression] Func<object> reqparameters, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(type, nameof(type), required: true);
            SourceExpression.Validate(reqparameters, nameof(reqparameters), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/v2/automate/connector/chat-workflows";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["type"] = SourceExpressionConverter.ConvertO(type);
                var req = new JObject();
                var reqpropCount = 0;
                reqpropCount++;
                req["parameters"] = SourceExpressionConverter.ConvertToken(reqparameters);
                req["url"] = "#{listCallbackUrl()}";
                reqpropCount++;
                if (reqpropCount > 0)
                {
                    callPayload.Body = req;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger<JToken>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<JToken> CreateTicketWorkflow([WorkflowExpression] Func<string> type, [WorkflowExpression] Func<string> reqdescription, [WorkflowExpression] Func<object> reqadvancedFilters, [WorkflowExpression] Func<int> reqboard = null, [WorkflowExpression] Func<int> reqstatus = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(type, nameof(type), required: true);
            SourceExpression.Validate(reqdescription, nameof(reqdescription), required: true);
            SourceExpression.Validate(reqadvancedFilters, nameof(reqadvancedFilters), required: true);
            SourceExpression.Validate(reqboard, nameof(reqboard), required: false);
            SourceExpression.Validate(reqstatus, nameof(reqstatus), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/v2/automate/connector/ticket-workflows";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["type"] = SourceExpressionConverter.ConvertO(type);
                var req = new JObject();
                var reqpropCount = 0;
                reqpropCount++;
                req["description"] = SourceExpressionConverter.ConvertToken(reqdescription);
                if (reqboard != null)
                {
                    req["boardId"] = SourceExpressionConverter.ConvertToken(reqboard);
                    reqpropCount++;
                }

                if (reqstatus != null)
                {
                    req["statusId"] = SourceExpressionConverter.ConvertToken(reqstatus);
                    reqpropCount++;
                }

                reqpropCount++;
                req["advancedFilters"] = SourceExpressionConverter.ConvertToken(reqadvancedFilters);
                req["url"] = "#{listCallbackUrl()}";
                reqpropCount++;
                if (reqpropCount > 0)
                {
                    callPayload.Body = req;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger<JToken>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<JToken> SubscribeToWorkflow([WorkflowExpression] Func<string> type, [WorkflowExpression] Func<string> workflowId, [WorkflowExpression] Func<object> reqparameters, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(type, nameof(type), required: true);
            SourceExpression.Validate(workflowId, nameof(workflowId), required: true);
            SourceExpression.Validate(reqparameters, nameof(reqparameters), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v2/automate/connector/workflows/{0}/actions", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(workflowId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["type"] = SourceExpressionConverter.ConvertO(type);
                var req = new JObject();
                var reqpropCount = 0;
                req["url"] = "#{listCallbackUrl()}";
                reqpropCount++;
                reqpropCount++;
                req["parameters"] = SourceExpressionConverter.ConvertToken(reqparameters);
                if (reqpropCount > 0)
                {
                    callPayload.Body = req;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger<JToken>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<JToken> AdvancedEventSubscribe([WorkflowExpression] Func<string> category, [WorkflowExpression] Func<string> eventType, [WorkflowExpression] Func<object> reqparameters, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(category, nameof(category), required: true);
            SourceExpression.Validate(eventType, nameof(eventType), required: true);
            SourceExpression.Validate(reqparameters, nameof(reqparameters), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v2/automate/connector/events/{0}/subscriptions", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(eventType, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["category"] = SourceExpressionConverter.ConvertO(category);
                var req = new JObject();
                var reqpropCount = 0;
                req["url"] = "#{listCallbackUrl()}";
                reqpropCount++;
                reqpropCount++;
                req["parameters"] = SourceExpressionConverter.ConvertToken(reqparameters);
                if (reqpropCount > 0)
                {
                    callPayload.Body = req;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger<JToken>(BuildSourceInput, triggerName, recurrence);
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