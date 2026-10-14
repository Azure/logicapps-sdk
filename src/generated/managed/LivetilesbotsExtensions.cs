//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Livetilesbots
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class LivetilesbotsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "livetilesbots")]
        public IWorkflowAction PromptString(Expression<Func<string>> resumptionToken, Expression<Func<string>> bodyprompt = null)
        {
            var __workflow_resumptionToken = resumptionToken == null ? null : WorkflowExpression.Compile(resumptionToken);
            WorkflowExpression.Validate(__workflow_resumptionToken, nameof(resumptionToken), required: true);
            var __workflow_bodyprompt = bodyprompt == null ? null : WorkflowExpression.Compile(bodyprompt);
            WorkflowExpression.Validate(__workflow_bodyprompt, nameof(bodyprompt), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/flowCallback/String";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["resumptionToken"] = ExpressionConverter.Convert(__workflow_resumptionToken);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyprompt != null)
                {
                    body["prompt"] = ExpressionConverter.ConvertO(__workflow_bodyprompt);
                    bodypropCount++;
                }

                body["callbackUri"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "livetilesbots")]
        public IWorkflowAction PromptNumber(Expression<Func<string>> resumptionToken, Expression<Func<string>> bodyprompt = null)
        {
            var __workflow_resumptionToken = resumptionToken == null ? null : WorkflowExpression.Compile(resumptionToken);
            WorkflowExpression.Validate(__workflow_resumptionToken, nameof(resumptionToken), required: true);
            var __workflow_bodyprompt = bodyprompt == null ? null : WorkflowExpression.Compile(bodyprompt);
            WorkflowExpression.Validate(__workflow_bodyprompt, nameof(bodyprompt), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/flowCallback/Number";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["resumptionToken"] = ExpressionConverter.Convert(__workflow_resumptionToken);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyprompt != null)
                {
                    body["prompt"] = ExpressionConverter.ConvertO(__workflow_bodyprompt);
                    bodypropCount++;
                }

                body["callbackUri"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "livetilesbots")]
        public IWorkflowAction PromptForm(Expression<Func<string>> resumptionToken, Expression<Func<bodyformFieldsInputItem[]>> bodyformFields, Expression<Func<string>> bodyprompt = null, Expression<Func<string>> bodytitle = null)
        {
            var __workflow_resumptionToken = resumptionToken == null ? null : WorkflowExpression.Compile(resumptionToken);
            WorkflowExpression.Validate(__workflow_resumptionToken, nameof(resumptionToken), required: true);
            var __workflow_bodyformFields = bodyformFields == null ? null : WorkflowExpression.Compile(bodyformFields);
            WorkflowExpression.Validate(__workflow_bodyformFields, nameof(bodyformFields), required: true);
            var __workflow_bodyprompt = bodyprompt == null ? null : WorkflowExpression.Compile(bodyprompt);
            WorkflowExpression.Validate(__workflow_bodyprompt, nameof(bodyprompt), required: false);
            var __workflow_bodytitle = bodytitle == null ? null : WorkflowExpression.Compile(bodytitle);
            WorkflowExpression.Validate(__workflow_bodytitle, nameof(bodytitle), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/flowCallback/Form";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["resumptionToken"] = ExpressionConverter.Convert(__workflow_resumptionToken);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyprompt != null)
                {
                    body["prompt"] = ExpressionConverter.ConvertO(__workflow_bodyprompt);
                    bodypropCount++;
                }

                body["callbackUri"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (__workflow_bodytitle != null)
                {
                    body["title"] = ExpressionConverter.ConvertO(__workflow_bodytitle);
                    bodypropCount++;
                }

                bodypropCount++;
                body["formFields"] = ExpressionConverter.ConvertO(__workflow_bodyformFields);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "livetilesbots")]
        public IWorkflowAction PromptBoolean(Expression<Func<string>> resumptionToken, Expression<Func<string>> bodyprompt = null)
        {
            var __workflow_resumptionToken = resumptionToken == null ? null : WorkflowExpression.Compile(resumptionToken);
            WorkflowExpression.Validate(__workflow_resumptionToken, nameof(resumptionToken), required: true);
            var __workflow_bodyprompt = bodyprompt == null ? null : WorkflowExpression.Compile(bodyprompt);
            WorkflowExpression.Validate(__workflow_bodyprompt, nameof(bodyprompt), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/flowCallback/Bool";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["resumptionToken"] = ExpressionConverter.Convert(__workflow_resumptionToken);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyprompt != null)
                {
                    body["prompt"] = ExpressionConverter.ConvertO(__workflow_bodyprompt);
                    bodypropCount++;
                }

                body["callbackUri"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "livetilesbots")]
        public IWorkflowAction PromptChoice(Expression<Func<string>> resumptionToken, Expression<Func<string>> bodyprompt = null, Expression<Func<bodyoptionsInputItem[]>> bodyoptions = null)
        {
            var __workflow_resumptionToken = resumptionToken == null ? null : WorkflowExpression.Compile(resumptionToken);
            WorkflowExpression.Validate(__workflow_resumptionToken, nameof(resumptionToken), required: true);
            var __workflow_bodyprompt = bodyprompt == null ? null : WorkflowExpression.Compile(bodyprompt);
            WorkflowExpression.Validate(__workflow_bodyprompt, nameof(bodyprompt), required: false);
            var __workflow_bodyoptions = bodyoptions == null ? null : WorkflowExpression.Compile(bodyoptions);
            WorkflowExpression.Validate(__workflow_bodyoptions, nameof(bodyoptions), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/flowCallback/Choice";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["resumptionToken"] = ExpressionConverter.Convert(__workflow_resumptionToken);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyprompt != null)
                {
                    body["prompt"] = ExpressionConverter.ConvertO(__workflow_bodyprompt);
                    bodypropCount++;
                }

                if (__workflow_bodyoptions != null)
                {
                    body["options"] = ExpressionConverter.ConvertO(__workflow_bodyoptions);
                    bodypropCount++;
                }

                body["callbackUri"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "livetilesbots")]
        public IWorkflowAction PromptFile(Expression<Func<string>> resumptionToken, Expression<Func<string>> bodyprompt = null, Expression<Func<string[]>> bodycontentTypes = null)
        {
            var __workflow_resumptionToken = resumptionToken == null ? null : WorkflowExpression.Compile(resumptionToken);
            WorkflowExpression.Validate(__workflow_resumptionToken, nameof(resumptionToken), required: true);
            var __workflow_bodyprompt = bodyprompt == null ? null : WorkflowExpression.Compile(bodyprompt);
            WorkflowExpression.Validate(__workflow_bodyprompt, nameof(bodyprompt), required: false);
            var __workflow_bodycontentTypes = bodycontentTypes == null ? null : WorkflowExpression.Compile(bodycontentTypes);
            WorkflowExpression.Validate(__workflow_bodycontentTypes, nameof(bodycontentTypes), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/flowCallback/File";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["resumptionToken"] = ExpressionConverter.Convert(__workflow_resumptionToken);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyprompt != null)
                {
                    body["prompt"] = ExpressionConverter.ConvertO(__workflow_bodyprompt);
                    bodypropCount++;
                }

                if (__workflow_bodycontentTypes != null)
                {
                    body["contentTypes"] = ExpressionConverter.ConvertO(__workflow_bodycontentTypes);
                    bodypropCount++;
                }

                body["callbackUri"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "livetilesbots")]
        public IWorkflowAction PostMessage(Expression<Func<string>> resumptionToken, Expression<Func<string>> bodymessage = null, Expression<Func<bodyattachmentsInputItem[]>> bodyattachments = null)
        {
            var __workflow_resumptionToken = resumptionToken == null ? null : WorkflowExpression.Compile(resumptionToken);
            WorkflowExpression.Validate(__workflow_resumptionToken, nameof(resumptionToken), required: true);
            var __workflow_bodymessage = bodymessage == null ? null : WorkflowExpression.Compile(bodymessage);
            WorkflowExpression.Validate(__workflow_bodymessage, nameof(bodymessage), required: false);
            var __workflow_bodyattachments = bodyattachments == null ? null : WorkflowExpression.Compile(bodyattachments);
            WorkflowExpression.Validate(__workflow_bodyattachments, nameof(bodyattachments), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/flowCallback/Message";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["resumptionToken"] = ExpressionConverter.Convert(__workflow_resumptionToken);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodymessage != null)
                {
                    body["message"] = ExpressionConverter.ConvertO(__workflow_bodymessage);
                    bodypropCount++;
                }

                if (__workflow_bodyattachments != null)
                {
                    body["attachments"] = ExpressionConverter.ConvertO(__workflow_bodyattachments);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "livetilesbots")]
        public IWorkflowAction FlowComplete(Expression<Func<string>> resumptionToken)
        {
            var __workflow_resumptionToken = resumptionToken == null ? null : WorkflowExpression.Compile(resumptionToken);
            WorkflowExpression.Validate(__workflow_resumptionToken, nameof(resumptionToken), required: true);
            return new DeferredWorkflowAction(() =>
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
        public IWorkflowTrigger IntentRecognized(Expression<Func<string>> subscriptionbot, Expression<Func<string>> subscriptionflow, FlowRecurrence recurrence = null)
        {
            var __workflow_subscriptionbot = subscriptionbot == null ? null : WorkflowExpression.Compile(subscriptionbot);
            WorkflowExpression.Validate(__workflow_subscriptionbot, nameof(subscriptionbot), required: true);
            var __workflow_subscriptionflow = subscriptionflow == null ? null : WorkflowExpression.Compile(subscriptionflow);
            WorkflowExpression.Validate(__workflow_subscriptionflow, nameof(subscriptionflow), required: true);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = "/flows/subscribe";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var subscription = new JObject();
                var subscriptionpropCount = 0;
                subscriptionpropCount++;
                subscription["bot"] = ExpressionConverter.ConvertO(__workflow_subscriptionbot);
                subscriptionpropCount++;
                subscription["key"] = ExpressionConverter.ConvertO(__workflow_subscriptionflow);
                subscription["callbackUri"] = "#{listCallbackUrl()}";
                subscriptionpropCount++;
                if (subscriptionpropCount > 0)
                {
                    callPayload.Body = subscription;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }
    }

    public class bodyformFieldsInputItem
    {
        [JsonProperty("fieldType")]
        public bodyformFieldsInputItemFieldTypeType FieldType { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("isRequired")]
        public bool IsRequired { get; set; }

        [JsonProperty("isMultiline")]
        public bool IsMultiline { get; set; }

        [JsonProperty("minLength")]
        public double MinLength { get; set; }

        [JsonProperty("maxLength")]
        public double MaxLength { get; set; }

        [JsonProperty("isMultiSelect")]
        public bool IsMultiSelect { get; set; }

        [JsonProperty("choices")]
        public bodyformFieldsInputItemChoicesTypeItem[] Choices { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyformFieldsInputItemFieldTypeType
    {
        Text,
        Number,
        Choice,
        DateTime,
        Boolean
    }

    public class bodyformFieldsInputItemChoicesTypeItem
    {
        [JsonProperty("display")]
        public string Display { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class bodyoptionsInputItem
    {
        [JsonProperty("display")]
        public string Display { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class bodyattachmentsInputItem
    {
        [JsonProperty("contentType")]
        public string ContentType { get; set; }

        [JsonProperty("content")]
        public JToken Content { get; set; }

        [JsonProperty("contentUrl")]
        public string ContentUrl { get; set; }
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
