//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Revelationhelpdesk
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class RevelationhelpdeskActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "revelationhelpdesk")]
        public IBodyWorkflowAction<JToken> CreateUser(Expression<Func<object>> body = null)
        {
            var apiCallPath = "/User";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertO(body);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "revelationhelpdesk")]
        public IBodyWorkflowAction<JToken> FindUser(Expression<Func<object>> body = null)
        {
            var apiCallPath = "/User/Find";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertO(body);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "revelationhelpdesk")]
        public IBodyWorkflowAction<JToken> CreateAsset(Expression<Func<object>> body = null)
        {
            var apiCallPath = "/Asset";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertO(body);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "revelationhelpdesk")]
        public IWorkflowAction UpdateAsset(Expression<Func<object>> body = null)
        {
            var apiCallPath = "/Asset";
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertO(body);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "revelationhelpdesk")]
        public IBodyWorkflowAction<JToken[]> SearchAsset(Expression<Func<object>> body = null)
        {
            var apiCallPath = "/Asset/Search";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertO(body);
            return new ApiConnectionAction<JToken[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "revelationhelpdesk")]
        public IBodyWorkflowAction<JToken> GetAsset(Expression<Func<int>> id)
        {
            var apiCallPath = String.Format("/Asset/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "revelationhelpdesk")]
        public IBodyWorkflowAction<JToken> GetTicket(Expression<Func<int>> id)
        {
            var apiCallPath = String.Format("/Ticket/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "revelationhelpdesk")]
        public IBodyWorkflowAction<JToken> LogTicket(Expression<Func<object>> body = null)
        {
            var apiCallPath = "/Ticket";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertO(body);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "revelationhelpdesk")]
        public IBodyWorkflowAction<bool> SetTicketType(Expression<Func<object>> body = null)
        {
            var apiCallPath = "/Ticket/Type";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertO(body);
            return new ApiConnectionAction<bool>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "revelationhelpdesk")]
        public IBodyWorkflowAction<bool> AddAction(Expression<Func<object>> body = null)
        {
            var apiCallPath = "/Ticket/Action";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertO(body);
            return new ApiConnectionAction<bool>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "revelationhelpdesk")]
        public IBodyWorkflowAction<bool> Reassign(Expression<Func<object>> body = null)
        {
            var apiCallPath = "/Ticket/Reassign";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertO(body);
            return new ApiConnectionAction<bool>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "revelationhelpdesk")]
        public IBodyWorkflowAction<bool> SetStatus(Expression<Func<object>> body = null)
        {
            var apiCallPath = "/Ticket/SetStatus";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertO(body);
            return new ApiConnectionAction<bool>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "revelationhelpdesk")]
        public IBodyWorkflowAction<bool> SetPriority(Expression<Func<object>> body = null)
        {
            var apiCallPath = "/Ticket/Priority";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertO(body);
            return new ApiConnectionAction<bool>(callPayload);
        }
    }

    public class RevelationhelpdeskTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<WebhookCreatedResponse> TicketLoggedWebhook(string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/Webhook/Ticket/Created";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["url"] = "@listCallbackUrl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<WebhookCreatedResponse>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<WebhookCreatedResponse> TicketUpdatedWebhook(string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/Webhook/Ticket/Updated";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["url"] = "@listCallbackUrl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<WebhookCreatedResponse>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<WebhookCreatedResponse> TicketDeletedWebhook(string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/Webhook/Ticket/Deleted";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["url"] = "@listCallbackUrl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<WebhookCreatedResponse>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<WebhookCreatedResponse> TicketClosedWebhook(string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/Webhook/Ticket/Closed";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["url"] = "@listCallbackUrl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<WebhookCreatedResponse>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<WebhookCreatedResponse> TicketReopenedWebhook(string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/Webhook/Ticket/Reopened";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["url"] = "@listCallbackUrl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<WebhookCreatedResponse>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<WebhookCreatedResponse> TicketAtRiskWebhook(string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/Webhook/Ticket/Atrisk";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["url"] = "@listCallbackUrl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<WebhookCreatedResponse>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<WebhookCreatedResponse> TicketDueWebhook(string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/Webhook/Ticket/Due";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["url"] = "@listCallbackUrl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<WebhookCreatedResponse>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<WebhookCreatedResponse> ClientCreatedWebhook(string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/Webhook/Client/Created";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["url"] = "@listCallbackUrl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<WebhookCreatedResponse>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<WebhookCreatedResponse> ClientUpdatedWebhook(string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/Webhook/Client/Updated";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["url"] = "@listCallbackUrl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<WebhookCreatedResponse>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<WebhookCreatedResponse> OfficeCreatedWebhook(string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/Webhook/Office/Created";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["url"] = "@listCallbackUrl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<WebhookCreatedResponse>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<WebhookCreatedResponse> OfficeUpdatedWebhook(string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/Webhook/Office/Updated";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["url"] = "@listCallbackUrl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<WebhookCreatedResponse>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<WebhookCreatedResponse> UserCreatedWebhook(string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/Webhook/User/Created";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["url"] = "@listCallbackUrl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<WebhookCreatedResponse>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<WebhookCreatedResponse> UserUpdatedWebhook(string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/Webhook/User/Updated";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["url"] = "@listCallbackUrl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<WebhookCreatedResponse>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<WebhookCreatedResponse> AssetCreatedWebhook(string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/Webhook/Asset/Created";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["url"] = "@listCallbackUrl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<WebhookCreatedResponse>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<WebhookCreatedResponse> AssetUpdatedWebhook(string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/Webhook/Asset/Updated";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["url"] = "@listCallbackUrl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<WebhookCreatedResponse>(callPayload, triggerName, recurrence);
        }
    }

    public class WebhookCreatedResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("secret")]
        public string Secret { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Revelationhelpdesk;

    public partial class WorkflowManagedActions
    {
        public RevelationhelpdeskActions Revelationhelpdesk(string connectionId) => new RevelationhelpdeskActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public RevelationhelpdeskTriggers Revelationhelpdesk(string connectionId) => new RevelationhelpdeskTriggers(connectionId);
    }
}