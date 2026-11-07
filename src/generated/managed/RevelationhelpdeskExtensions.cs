//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Revelationhelpdesk
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class RevelationhelpdeskActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "revelationhelpdesk")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> CreateUser(Expression<Func<object>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/User";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "revelationhelpdesk")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> FindUser(Expression<Func<object>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/User/Find";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "revelationhelpdesk")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> CreateAsset(Expression<Func<object>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Asset";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "revelationhelpdesk")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UpdateAsset(Expression<Func<object>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Asset";
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "revelationhelpdesk")]
        public IBodyWorkflowAction<JToken[], ApiConnectionActionConfiguration> SearchAsset(Expression<Func<object>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<JToken[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Asset/Search";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<JToken[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "revelationhelpdesk")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> GetAsset(Expression<Func<int>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Asset/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "revelationhelpdesk")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> GetTicket(Expression<Func<int>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Ticket/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "revelationhelpdesk")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> LogTicket(Expression<Func<object>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Ticket";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "revelationhelpdesk")]
        public IBodyWorkflowAction<bool, ApiConnectionActionConfiguration> SetTicketType(Expression<Func<object>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<bool, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Ticket/Type";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<bool>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "revelationhelpdesk")]
        public IBodyWorkflowAction<bool, ApiConnectionActionConfiguration> AddAction(Expression<Func<object>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<bool, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Ticket/Action";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<bool>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "revelationhelpdesk")]
        public IBodyWorkflowAction<bool, ApiConnectionActionConfiguration> Reassign(Expression<Func<object>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<bool, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Ticket/Reassign";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<bool>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "revelationhelpdesk")]
        public IBodyWorkflowAction<bool, ApiConnectionActionConfiguration> SetStatus(Expression<Func<object>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<bool, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Ticket/SetStatus";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<bool>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "revelationhelpdesk")]
        public IBodyWorkflowAction<bool, ApiConnectionActionConfiguration> SetPriority(Expression<Func<object>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<bool, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Ticket/Priority";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<bool>(callPayload);
            });
        }
    }

    public class RevelationhelpdeskTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<WebhookCreatedResponse, ApiConnectionPollingTriggerConfiguration> TicketLoggedWebhook()
        {
            return new DeferredBodyTrigger<WebhookCreatedResponse, ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/Webhook/Ticket/Created";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = new BodyInput().ToJToken();
                return new ApiConnectionPollingTrigger<WebhookCreatedResponse>(callPayload);
            });
        }

        public IBodyWorkflowTrigger<WebhookCreatedResponse, ApiConnectionPollingTriggerConfiguration> TicketUpdatedWebhook()
        {
            return new DeferredBodyTrigger<WebhookCreatedResponse, ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/Webhook/Ticket/Updated";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = new BodyInput().ToJToken();
                return new ApiConnectionPollingTrigger<WebhookCreatedResponse>(callPayload);
            });
        }

        public IBodyWorkflowTrigger<WebhookCreatedResponse, ApiConnectionPollingTriggerConfiguration> TicketDeletedWebhook()
        {
            return new DeferredBodyTrigger<WebhookCreatedResponse, ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/Webhook/Ticket/Deleted";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = new BodyInput().ToJToken();
                return new ApiConnectionPollingTrigger<WebhookCreatedResponse>(callPayload);
            });
        }

        public IBodyWorkflowTrigger<WebhookCreatedResponse, ApiConnectionPollingTriggerConfiguration> TicketClosedWebhook()
        {
            return new DeferredBodyTrigger<WebhookCreatedResponse, ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/Webhook/Ticket/Closed";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = new BodyInput().ToJToken();
                return new ApiConnectionPollingTrigger<WebhookCreatedResponse>(callPayload);
            });
        }

        public IBodyWorkflowTrigger<WebhookCreatedResponse, ApiConnectionPollingTriggerConfiguration> TicketReopenedWebhook()
        {
            return new DeferredBodyTrigger<WebhookCreatedResponse, ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/Webhook/Ticket/Reopened";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = new BodyInput().ToJToken();
                return new ApiConnectionPollingTrigger<WebhookCreatedResponse>(callPayload);
            });
        }

        public IBodyWorkflowTrigger<WebhookCreatedResponse, ApiConnectionPollingTriggerConfiguration> TicketAtRiskWebhook()
        {
            return new DeferredBodyTrigger<WebhookCreatedResponse, ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/Webhook/Ticket/Atrisk";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = new BodyInput().ToJToken();
                return new ApiConnectionPollingTrigger<WebhookCreatedResponse>(callPayload);
            });
        }

        public IBodyWorkflowTrigger<WebhookCreatedResponse, ApiConnectionPollingTriggerConfiguration> TicketDueWebhook()
        {
            return new DeferredBodyTrigger<WebhookCreatedResponse, ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/Webhook/Ticket/Due";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = new BodyInput().ToJToken();
                return new ApiConnectionPollingTrigger<WebhookCreatedResponse>(callPayload);
            });
        }

        public IBodyWorkflowTrigger<WebhookCreatedResponse, ApiConnectionPollingTriggerConfiguration> ClientCreatedWebhook()
        {
            return new DeferredBodyTrigger<WebhookCreatedResponse, ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/Webhook/Client/Created";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = new BodyInput().ToJToken();
                return new ApiConnectionPollingTrigger<WebhookCreatedResponse>(callPayload);
            });
        }

        public IBodyWorkflowTrigger<WebhookCreatedResponse, ApiConnectionPollingTriggerConfiguration> ClientUpdatedWebhook()
        {
            return new DeferredBodyTrigger<WebhookCreatedResponse, ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/Webhook/Client/Updated";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = new BodyInput().ToJToken();
                return new ApiConnectionPollingTrigger<WebhookCreatedResponse>(callPayload);
            });
        }

        public IBodyWorkflowTrigger<WebhookCreatedResponse, ApiConnectionPollingTriggerConfiguration> OfficeCreatedWebhook()
        {
            return new DeferredBodyTrigger<WebhookCreatedResponse, ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/Webhook/Office/Created";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = new BodyInput().ToJToken();
                return new ApiConnectionPollingTrigger<WebhookCreatedResponse>(callPayload);
            });
        }

        public IBodyWorkflowTrigger<WebhookCreatedResponse, ApiConnectionPollingTriggerConfiguration> OfficeUpdatedWebhook()
        {
            return new DeferredBodyTrigger<WebhookCreatedResponse, ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/Webhook/Office/Updated";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = new BodyInput().ToJToken();
                return new ApiConnectionPollingTrigger<WebhookCreatedResponse>(callPayload);
            });
        }

        public IBodyWorkflowTrigger<WebhookCreatedResponse, ApiConnectionPollingTriggerConfiguration> UserCreatedWebhook()
        {
            return new DeferredBodyTrigger<WebhookCreatedResponse, ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/Webhook/User/Created";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = new BodyInput().ToJToken();
                return new ApiConnectionPollingTrigger<WebhookCreatedResponse>(callPayload);
            });
        }

        public IBodyWorkflowTrigger<WebhookCreatedResponse, ApiConnectionPollingTriggerConfiguration> UserUpdatedWebhook()
        {
            return new DeferredBodyTrigger<WebhookCreatedResponse, ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/Webhook/User/Updated";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = new BodyInput().ToJToken();
                return new ApiConnectionPollingTrigger<WebhookCreatedResponse>(callPayload);
            });
        }

        public IBodyWorkflowTrigger<WebhookCreatedResponse, ApiConnectionPollingTriggerConfiguration> AssetCreatedWebhook()
        {
            return new DeferredBodyTrigger<WebhookCreatedResponse, ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/Webhook/Asset/Created";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = new BodyInput().ToJToken();
                return new ApiConnectionPollingTrigger<WebhookCreatedResponse>(callPayload);
            });
        }

        public IBodyWorkflowTrigger<WebhookCreatedResponse, ApiConnectionPollingTriggerConfiguration> AssetUpdatedWebhook()
        {
            return new DeferredBodyTrigger<WebhookCreatedResponse, ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/Webhook/Asset/Updated";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = new BodyInput().ToJToken();
                return new ApiConnectionPollingTrigger<WebhookCreatedResponse>(callPayload);
            });
        }
    }

    public class WebhookCreatedResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("secret")]
        public string Secret { get; set; }
    }

    public class BodyInput
    {
        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Url { get; set; } = "#{listCallbackUrl()}";
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