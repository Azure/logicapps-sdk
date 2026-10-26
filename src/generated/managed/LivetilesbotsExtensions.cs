//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Livetilesbots
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class LivetilesbotsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "livetilesbots")]
        public IWorkflowAction<ApiConnectionActionConfiguration> PromptString(Expression<Func<string>> resumptionToken, Expression<Func<PromptStringInput>> body)
        {
            var __workflow_resumptionToken = WorkflowExpression.Compile(resumptionToken, nameof(resumptionToken), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/flowCallback/String";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["resumptionToken"] = ExpressionConverter.Convert(__workflow_resumptionToken);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "livetilesbots")]
        public IWorkflowAction<ApiConnectionActionConfiguration> PromptNumber(Expression<Func<string>> resumptionToken, Expression<Func<PromptNumberInput>> body)
        {
            var __workflow_resumptionToken = WorkflowExpression.Compile(resumptionToken, nameof(resumptionToken), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/flowCallback/Number";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["resumptionToken"] = ExpressionConverter.Convert(__workflow_resumptionToken);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "livetilesbots")]
        public IWorkflowAction<ApiConnectionActionConfiguration> PromptForm(Expression<Func<string>> resumptionToken, Expression<Func<PromptFormInput>> body)
        {
            var __workflow_resumptionToken = WorkflowExpression.Compile(resumptionToken, nameof(resumptionToken), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/flowCallback/Form";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["resumptionToken"] = ExpressionConverter.Convert(__workflow_resumptionToken);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "livetilesbots")]
        public IWorkflowAction<ApiConnectionActionConfiguration> PromptBoolean(Expression<Func<string>> resumptionToken, Expression<Func<PromptBooleanInput>> body)
        {
            var __workflow_resumptionToken = WorkflowExpression.Compile(resumptionToken, nameof(resumptionToken), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/flowCallback/Bool";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["resumptionToken"] = ExpressionConverter.Convert(__workflow_resumptionToken);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "livetilesbots")]
        public IWorkflowAction<ApiConnectionActionConfiguration> PromptChoice(Expression<Func<string>> resumptionToken, Expression<Func<PromptChoiceInput>> body)
        {
            var __workflow_resumptionToken = WorkflowExpression.Compile(resumptionToken, nameof(resumptionToken), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/flowCallback/Choice";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["resumptionToken"] = ExpressionConverter.Convert(__workflow_resumptionToken);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "livetilesbots")]
        public IWorkflowAction<ApiConnectionActionConfiguration> PromptFile(Expression<Func<string>> resumptionToken, Expression<Func<PromptFileInput>> body)
        {
            var __workflow_resumptionToken = WorkflowExpression.Compile(resumptionToken, nameof(resumptionToken), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/flowCallback/File";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["resumptionToken"] = ExpressionConverter.Convert(__workflow_resumptionToken);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "livetilesbots")]
        public IWorkflowAction<ApiConnectionActionConfiguration> PostMessage(Expression<Func<string>> resumptionToken, Expression<Func<PostMessageInput>> body)
        {
            var __workflow_resumptionToken = WorkflowExpression.Compile(resumptionToken, nameof(resumptionToken), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/flowCallback/Message";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["resumptionToken"] = ExpressionConverter.Convert(__workflow_resumptionToken);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "livetilesbots")]
        public IWorkflowAction<ApiConnectionActionConfiguration> FlowComplete(Expression<Func<string>> resumptionToken)
        {
            var __workflow_resumptionToken = WorkflowExpression.Compile(resumptionToken, nameof(resumptionToken), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/flowCallback/Done";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["resumptionToken"] = ExpressionConverter.Convert(__workflow_resumptionToken);
                return new ApiConnectionAction(callPayload);
            });
        }
    }

    public class LivetilesbotsTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> IntentRecognized(Expression<Func<IntentRecognizedInput>> subscription, FlowRecurrence recurrence = null)
        {
            var __workflow_subscription = WorkflowExpression.Compile(subscription, nameof(subscription), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/flows/subscribe";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_subscription);
                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }
    }

    public class PromptStringInput
    {
        [JsonProperty("prompt")]
        public string Prompt { get; set; }

        [JsonProperty("callbackUri", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string CallbackUri { get; set; } = "#{listCallbackUrl()}";
    }

    public class PromptNumberInput
    {
        [JsonProperty("prompt")]
        public string Prompt { get; set; }

        [JsonProperty("callbackUri", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string CallbackUri { get; set; } = "#{listCallbackUrl()}";
    }

    public class PromptFormInput
    {
        [JsonProperty("prompt")]
        public string Prompt { get; set; }

        [JsonProperty("callbackUri", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string CallbackUri { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("formFields", DefaultValueHandling = DefaultValueHandling.Include)]
        public PromptFormInputFormFieldsTypeItem[] FormFields { get; set; }
    }

    public class PromptFormInputFormFieldsTypeItem
    {
        [JsonProperty("fieldType")]
        public PromptFormInputFormFieldsTypeItemFieldTypeType? FieldType { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("isRequired")]
        public bool? IsRequired { get; set; }

        [JsonProperty("isMultiline")]
        public bool? IsMultiline { get; set; }

        [JsonProperty("minLength")]
        public double? MinLength { get; set; }

        [JsonProperty("maxLength")]
        public double? MaxLength { get; set; }

        [JsonProperty("isMultiSelect")]
        public bool? IsMultiSelect { get; set; }

        [JsonProperty("choices")]
        public PromptFormInputFormFieldsTypeItemChoicesTypeItem[] Choices { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum PromptFormInputFormFieldsTypeItemFieldTypeType
    {
        Text,
        Number,
        Choice,
        DateTime,
        Boolean
    }

    public class PromptFormInputFormFieldsTypeItemChoicesTypeItem
    {
        [JsonProperty("display")]
        public string Display { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class PromptBooleanInput
    {
        [JsonProperty("prompt")]
        public string Prompt { get; set; }

        [JsonProperty("callbackUri", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string CallbackUri { get; set; } = "#{listCallbackUrl()}";
    }

    public class PromptChoiceInput
    {
        [JsonProperty("prompt")]
        public string Prompt { get; set; }

        [JsonProperty("options")]
        public PromptChoiceInputOptionsTypeItem[] Options { get; set; }

        [JsonProperty("callbackUri", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string CallbackUri { get; set; } = "#{listCallbackUrl()}";
    }

    public class PromptChoiceInputOptionsTypeItem
    {
        [JsonProperty("display")]
        public string Display { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class PromptFileInput
    {
        [JsonProperty("prompt")]
        public string Prompt { get; set; }

        [JsonProperty("contentTypes")]
        public string[] ContentTypes { get; set; }

        [JsonProperty("callbackUri", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string CallbackUri { get; set; } = "#{listCallbackUrl()}";
    }

    public class PostMessageInput
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("attachments")]
        public PostMessageInputAttachmentsTypeItem[] Attachments { get; set; }
    }

    public class PostMessageInputAttachmentsTypeItem
    {
        [JsonProperty("contentType")]
        public string ContentType { get; set; }

        [JsonProperty("content")]
        public JToken Content { get; set; }

        [JsonProperty("contentUrl")]
        public string ContentUrl { get; set; }
    }

    public class IntentRecognizedInput
    {
        [JsonProperty("bot", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Bot { get; set; }

        [JsonProperty("key", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Flow { get; set; }

        [JsonProperty("callbackUri", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string CallbackUri { get; set; } = "#{listCallbackUrl()}";
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Livetilesbots;

    public partial class WorkflowManagedActions
    {
        public LivetilesbotsActions Livetilesbots(string connectionId) => new LivetilesbotsActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public LivetilesbotsTriggers Livetilesbots(string connectionId) => new LivetilesbotsTriggers(connectionId);
    }
}