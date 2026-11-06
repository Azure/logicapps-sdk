//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Companyconnect
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CompanyconnectActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "companyconnect")]
        public IWorkflowAction<ApiConnectionActionConfiguration> ChoicePrompt(Expression<Func<ChoicePromptRequestInput>> request)
        {
            var __workflow_request = WorkflowExpression.Compile(request, nameof(request), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/choicePrompt";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_request);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "companyconnect")]
        public IWorkflowAction<ApiConnectionActionConfiguration> ConfirmPrompt(Expression<Func<ConfirmPromptRequestInput>> request)
        {
            var __workflow_request = WorkflowExpression.Compile(request, nameof(request), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/confirmPrompt";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_request);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "companyconnect")]
        public IWorkflowAction<ApiConnectionActionConfiguration> ProactiveDialogStart(Expression<Func<string>> id, Expression<Func<ProactiveDialogStartBodyInput>> body = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/proactiveDialogs/{0}/start", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "companyconnect")]
        public IWorkflowAction<ApiConnectionActionConfiguration> Reply(Expression<Func<MessageActivityInput>> messageActivity)
        {
            var __workflow_messageActivity = WorkflowExpression.Compile(messageActivity, nameof(messageActivity), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/reply";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_messageActivity);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "companyconnect")]
        public IWorkflowAction<ApiConnectionActionConfiguration> TextPrompt(Expression<Func<TextPromptRequestInput>> request)
        {
            var __workflow_request = WorkflowExpression.Compile(request, nameof(request), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/textPrompt";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_request);
                return new ApiConnectionAction(callPayload);
            });
        }
    }

    public class CompanyconnectTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger<ApiConnectionPollingTriggerConfiguration> ProactiveDialogSubscribe(Expression<Func<ProactiveDialogSubscribeBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/proactiveDialogs";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionPollingTrigger(callPayload);
            });
        }

        public IWorkflowTrigger<ApiConnectionPollingTriggerConfiguration> SmartDialogSubscribe(Expression<Func<SmartDialogSubscribeBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/smartDialogs";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionPollingTrigger(callPayload);
            });
        }

        public IWorkflowTrigger<ApiConnectionPollingTriggerConfiguration> SmartSourceSubscribe(Expression<Func<SmartSourceSubscribeBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/smartSources";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionPollingTrigger(callPayload);
            });
        }
    }

    public class ChoicePromptRequestInput
    {
        [JsonProperty("callbackUri", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string CallbackUri { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty("prompt", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Prompt { get; set; }

        [JsonProperty("choices")]
        public string[] Choices { get; set; }

        [JsonProperty("conversationReference", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ConversationReference { get; set; }
    }

    public class ConfirmPromptRequestInput
    {
        [JsonProperty("callbackUri", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string CallbackUri { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty("prompt", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Prompt { get; set; }

        [JsonProperty("yesText", DefaultValueHandling = DefaultValueHandling.Include)]
        public string YesText { get; set; } = "Yes";

        [JsonProperty("noText", DefaultValueHandling = DefaultValueHandling.Include)]
        public string NoText { get; set; } = "No";

        [JsonProperty("conversationReference", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ConversationReference { get; set; }
    }

    public class ProactiveDialogStartBodyInput
    {
        [JsonProperty("upn", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Upn { get; set; }
    }

    public class MessageActivityInput
    {
        [JsonProperty("text", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Text { get; set; }

        [JsonProperty("conversationReference", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ConversationReference { get; set; }
    }

    public class TextPromptRequestInput
    {
        [JsonProperty("callbackUri", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string CallbackUri { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty("prompt", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Prompt { get; set; }

        [JsonProperty("conversationReference", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ConversationReference { get; set; }
    }

    public class ProactiveDialogSubscribeBodyInput
    {
        [JsonProperty("callbackUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string CallbackUrl { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty("title", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Title { get; set; }
    }

    public class SmartDialogSubscribeBodyInput
    {
        [JsonProperty("appId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string AppId { get; set; }

        [JsonProperty("intent", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Intent { get; set; }

        [JsonProperty("description", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Description { get; set; }

        [JsonProperty("callbackUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string CallbackUrl { get; set; } = "#{listCallbackUrl()}";
    }

    public class SmartSourceSubscribeBodyInput
    {
        [JsonProperty("callbackUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string CallbackUrl { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty("title", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Title { get; set; }

        [JsonProperty("category", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Category { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Companyconnect;

    public partial class WorkflowManagedActions
    {
        public CompanyconnectActions Companyconnect(string connectionId) => new CompanyconnectActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public CompanyconnectTriggers Companyconnect(string connectionId) => new CompanyconnectTriggers(connectionId);
    }
}