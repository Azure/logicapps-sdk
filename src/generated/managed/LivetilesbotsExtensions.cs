//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Livetilesbots
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class LivetilesbotsActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "livetilesbots")]
        [WorkflowExpressionFactory(nameof(__BuildPromptString))]
        public IWorkflowAction PromptString([WorkflowExpression] Func<string> resumptionToken, [WorkflowExpression] Func<string> bodyprompt = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "livetilesbots")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildPromptString(WorkflowExpression<string> resumptionToken, WorkflowExpression<string> bodyprompt = null)
        {
            WorkflowExpression.Validate(resumptionToken, nameof(resumptionToken), required: true);
            WorkflowExpression.Validate(bodyprompt, nameof(bodyprompt), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/flowCallback/String";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["resumptionToken"] = ExpressionConverter.Convert(resumptionToken);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyprompt != null)
                {
                    body["prompt"] = ExpressionConverter.ConvertO(bodyprompt);
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
        [WorkflowExpressionFactory(nameof(__BuildPromptNumber))]
        public IWorkflowAction PromptNumber([WorkflowExpression] Func<string> resumptionToken, [WorkflowExpression] Func<string> bodyprompt = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "livetilesbots")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildPromptNumber(WorkflowExpression<string> resumptionToken, WorkflowExpression<string> bodyprompt = null)
        {
            WorkflowExpression.Validate(resumptionToken, nameof(resumptionToken), required: true);
            WorkflowExpression.Validate(bodyprompt, nameof(bodyprompt), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/flowCallback/Number";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["resumptionToken"] = ExpressionConverter.Convert(resumptionToken);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyprompt != null)
                {
                    body["prompt"] = ExpressionConverter.ConvertO(bodyprompt);
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
        [WorkflowExpressionFactory(nameof(__BuildPromptForm))]
        public IWorkflowAction PromptForm([WorkflowExpression] Func<string> resumptionToken, [WorkflowExpression] Func<bodyformFieldsInputItem[]> bodyformFields, [WorkflowExpression] Func<string> bodyprompt = null, [WorkflowExpression] Func<string> bodytitle = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "livetilesbots")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildPromptForm(WorkflowExpression<string> resumptionToken, WorkflowExpression<bodyformFieldsInputItem[]> bodyformFields, WorkflowExpression<string> bodyprompt = null, WorkflowExpression<string> bodytitle = null)
        {
            WorkflowExpression.Validate(resumptionToken, nameof(resumptionToken), required: true);
            WorkflowExpression.Validate(bodyformFields, nameof(bodyformFields), required: true);
            WorkflowExpression.Validate(bodyprompt, nameof(bodyprompt), required: false);
            WorkflowExpression.Validate(bodytitle, nameof(bodytitle), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/flowCallback/Form";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["resumptionToken"] = ExpressionConverter.Convert(resumptionToken);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyprompt != null)
                {
                    body["prompt"] = ExpressionConverter.ConvertO(bodyprompt);
                    bodypropCount++;
                }

                body["callbackUri"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodytitle != null)
                {
                    body["title"] = ExpressionConverter.ConvertO(bodytitle);
                    bodypropCount++;
                }

                bodypropCount++;
                body["formFields"] = ExpressionConverter.ConvertO(bodyformFields);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "livetilesbots")]
        [WorkflowExpressionFactory(nameof(__BuildPromptBoolean))]
        public IWorkflowAction PromptBoolean([WorkflowExpression] Func<string> resumptionToken, [WorkflowExpression] Func<string> bodyprompt = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "livetilesbots")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildPromptBoolean(WorkflowExpression<string> resumptionToken, WorkflowExpression<string> bodyprompt = null)
        {
            WorkflowExpression.Validate(resumptionToken, nameof(resumptionToken), required: true);
            WorkflowExpression.Validate(bodyprompt, nameof(bodyprompt), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/flowCallback/Bool";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["resumptionToken"] = ExpressionConverter.Convert(resumptionToken);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyprompt != null)
                {
                    body["prompt"] = ExpressionConverter.ConvertO(bodyprompt);
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
        [WorkflowExpressionFactory(nameof(__BuildPromptChoice))]
        public IWorkflowAction PromptChoice([WorkflowExpression] Func<string> resumptionToken, [WorkflowExpression] Func<string> bodyprompt = null, [WorkflowExpression] Func<bodyoptionsInputItem[]> bodyoptions = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "livetilesbots")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildPromptChoice(WorkflowExpression<string> resumptionToken, WorkflowExpression<string> bodyprompt = null, WorkflowExpression<bodyoptionsInputItem[]> bodyoptions = null)
        {
            WorkflowExpression.Validate(resumptionToken, nameof(resumptionToken), required: true);
            WorkflowExpression.Validate(bodyprompt, nameof(bodyprompt), required: false);
            WorkflowExpression.Validate(bodyoptions, nameof(bodyoptions), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/flowCallback/Choice";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["resumptionToken"] = ExpressionConverter.Convert(resumptionToken);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyprompt != null)
                {
                    body["prompt"] = ExpressionConverter.ConvertO(bodyprompt);
                    bodypropCount++;
                }

                if (bodyoptions != null)
                {
                    body["options"] = ExpressionConverter.ConvertO(bodyoptions);
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
        [WorkflowExpressionFactory(nameof(__BuildPromptFile))]
        public IWorkflowAction PromptFile([WorkflowExpression] Func<string> resumptionToken, [WorkflowExpression] Func<string> bodyprompt = null, [WorkflowExpression] Func<string[]> bodycontentTypes = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "livetilesbots")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildPromptFile(WorkflowExpression<string> resumptionToken, WorkflowExpression<string> bodyprompt = null, WorkflowExpression<string[]> bodycontentTypes = null)
        {
            WorkflowExpression.Validate(resumptionToken, nameof(resumptionToken), required: true);
            WorkflowExpression.Validate(bodyprompt, nameof(bodyprompt), required: false);
            WorkflowExpression.Validate(bodycontentTypes, nameof(bodycontentTypes), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/flowCallback/File";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["resumptionToken"] = ExpressionConverter.Convert(resumptionToken);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyprompt != null)
                {
                    body["prompt"] = ExpressionConverter.ConvertO(bodyprompt);
                    bodypropCount++;
                }

                if (bodycontentTypes != null)
                {
                    body["contentTypes"] = ExpressionConverter.ConvertO(bodycontentTypes);
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
        [WorkflowExpressionFactory(nameof(__BuildPostMessage))]
        public IWorkflowAction PostMessage([WorkflowExpression] Func<string> resumptionToken, [WorkflowExpression] Func<string> bodymessage = null, [WorkflowExpression] Func<bodyattachmentsInputItem[]> bodyattachments = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "livetilesbots")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildPostMessage(WorkflowExpression<string> resumptionToken, WorkflowExpression<string> bodymessage = null, WorkflowExpression<bodyattachmentsInputItem[]> bodyattachments = null)
        {
            WorkflowExpression.Validate(resumptionToken, nameof(resumptionToken), required: true);
            WorkflowExpression.Validate(bodymessage, nameof(bodymessage), required: false);
            WorkflowExpression.Validate(bodyattachments, nameof(bodyattachments), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/flowCallback/Message";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["resumptionToken"] = ExpressionConverter.Convert(resumptionToken);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodymessage != null)
                {
                    body["message"] = ExpressionConverter.ConvertO(bodymessage);
                    bodypropCount++;
                }

                if (bodyattachments != null)
                {
                    body["attachments"] = ExpressionConverter.ConvertO(bodyattachments);
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
        [WorkflowExpressionFactory(nameof(__BuildFlowComplete))]
        public IWorkflowAction FlowComplete([WorkflowExpression] Func<string> resumptionToken)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "livetilesbots")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildFlowComplete(WorkflowExpression<string> resumptionToken)
        {
            WorkflowExpression.Validate(resumptionToken, nameof(resumptionToken), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/flowCallback/Done";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["resumptionToken"] = ExpressionConverter.Convert(resumptionToken);
                return new ApiConnectionAction(callPayload);
            });
        }
    }

    public class LivetilesbotsTriggers([ConnectionName] string connectionId)
    {

        [WorkflowExpressionFactory(nameof(__BuildIntentRecognized))]
        public IWorkflowTrigger IntentRecognized([WorkflowExpression] Func<string> subscriptionbot,[WorkflowExpression] Func<string> subscriptionflow,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildIntentRecognized(WorkflowExpression<string> subscriptionbot,WorkflowExpression<string> subscriptionflow,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(subscriptionbot, nameof(subscriptionbot), required: true);
            WorkflowExpression.Validate(subscriptionflow, nameof(subscriptionflow), required: true);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = "/flows/subscribe";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var subscription = new JObject();
                var subscriptionpropCount = 0;
                subscriptionpropCount++;
                subscription["bot"] = ExpressionConverter.ConvertO(subscriptionbot);
                subscriptionpropCount++;
                subscription["key"] = ExpressionConverter.ConvertO(subscriptionflow);
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