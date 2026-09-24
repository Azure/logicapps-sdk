//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Livetilesbots
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class LivetilesbotsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "livetilesbots")]
        public IWorkflowAction PromptString([WorkflowExpression] Func<string> resumptionToken, [WorkflowExpression] Func<string> bodyprompt = null)
        {
            SourceExpression.Validate(resumptionToken, nameof(resumptionToken), required: true);
            SourceExpression.Validate(bodyprompt, nameof(bodyprompt), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/flowCallback/String";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["resumptionToken"] = SourceExpressionConverter.ConvertO(resumptionToken);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyprompt != null)
                {
                    body["prompt"] = SourceExpressionConverter.ConvertToken(bodyprompt);
                    bodypropCount++;
                }

                body["callbackUri"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "livetilesbots")]
        public IWorkflowAction PromptNumber([WorkflowExpression] Func<string> resumptionToken, [WorkflowExpression] Func<string> bodyprompt = null)
        {
            SourceExpression.Validate(resumptionToken, nameof(resumptionToken), required: true);
            SourceExpression.Validate(bodyprompt, nameof(bodyprompt), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/flowCallback/Number";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["resumptionToken"] = SourceExpressionConverter.ConvertO(resumptionToken);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyprompt != null)
                {
                    body["prompt"] = SourceExpressionConverter.ConvertToken(bodyprompt);
                    bodypropCount++;
                }

                body["callbackUri"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "livetilesbots")]
        public IWorkflowAction PromptForm([WorkflowExpression] Func<string> resumptionToken, [WorkflowExpression] Func<bodyformFieldsInputItem[]> bodyformFields, [WorkflowExpression] Func<string> bodyprompt = null, [WorkflowExpression] Func<string> bodytitle = null)
        {
            SourceExpression.Validate(resumptionToken, nameof(resumptionToken), required: true);
            SourceExpression.Validate(bodyformFields, nameof(bodyformFields), required: true);
            SourceExpression.Validate(bodyprompt, nameof(bodyprompt), required: false);
            SourceExpression.Validate(bodytitle, nameof(bodytitle), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/flowCallback/Form";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["resumptionToken"] = SourceExpressionConverter.ConvertO(resumptionToken);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyprompt != null)
                {
                    body["prompt"] = SourceExpressionConverter.ConvertToken(bodyprompt);
                    bodypropCount++;
                }

                body["callbackUri"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodytitle != null)
                {
                    body["title"] = SourceExpressionConverter.ConvertToken(bodytitle);
                    bodypropCount++;
                }

                bodypropCount++;
                body["formFields"] = SourceExpressionConverter.ConvertToken(bodyformFields);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "livetilesbots")]
        public IWorkflowAction PromptBoolean([WorkflowExpression] Func<string> resumptionToken, [WorkflowExpression] Func<string> bodyprompt = null)
        {
            SourceExpression.Validate(resumptionToken, nameof(resumptionToken), required: true);
            SourceExpression.Validate(bodyprompt, nameof(bodyprompt), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/flowCallback/Bool";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["resumptionToken"] = SourceExpressionConverter.ConvertO(resumptionToken);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyprompt != null)
                {
                    body["prompt"] = SourceExpressionConverter.ConvertToken(bodyprompt);
                    bodypropCount++;
                }

                body["callbackUri"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "livetilesbots")]
        public IWorkflowAction PromptChoice([WorkflowExpression] Func<string> resumptionToken, [WorkflowExpression] Func<string> bodyprompt = null, [WorkflowExpression] Func<bodyoptionsInputItem[]> bodyoptions = null)
        {
            SourceExpression.Validate(resumptionToken, nameof(resumptionToken), required: true);
            SourceExpression.Validate(bodyprompt, nameof(bodyprompt), required: false);
            SourceExpression.Validate(bodyoptions, nameof(bodyoptions), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/flowCallback/Choice";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["resumptionToken"] = SourceExpressionConverter.ConvertO(resumptionToken);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyprompt != null)
                {
                    body["prompt"] = SourceExpressionConverter.ConvertToken(bodyprompt);
                    bodypropCount++;
                }

                if (bodyoptions != null)
                {
                    body["options"] = SourceExpressionConverter.ConvertToken(bodyoptions);
                    bodypropCount++;
                }

                body["callbackUri"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "livetilesbots")]
        public IWorkflowAction PromptFile([WorkflowExpression] Func<string> resumptionToken, [WorkflowExpression] Func<string> bodyprompt = null, [WorkflowExpression] Func<string[]> bodycontentTypes = null)
        {
            SourceExpression.Validate(resumptionToken, nameof(resumptionToken), required: true);
            SourceExpression.Validate(bodyprompt, nameof(bodyprompt), required: false);
            SourceExpression.Validate(bodycontentTypes, nameof(bodycontentTypes), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/flowCallback/File";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["resumptionToken"] = SourceExpressionConverter.ConvertO(resumptionToken);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyprompt != null)
                {
                    body["prompt"] = SourceExpressionConverter.ConvertToken(bodyprompt);
                    bodypropCount++;
                }

                if (bodycontentTypes != null)
                {
                    body["contentTypes"] = SourceExpressionConverter.ConvertToken(bodycontentTypes);
                    bodypropCount++;
                }

                body["callbackUri"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "livetilesbots")]
        public IWorkflowAction PostMessage([WorkflowExpression] Func<string> resumptionToken, [WorkflowExpression] Func<string> bodymessage = null, [WorkflowExpression] Func<bodyattachmentsInputItem[]> bodyattachments = null)
        {
            SourceExpression.Validate(resumptionToken, nameof(resumptionToken), required: true);
            SourceExpression.Validate(bodymessage, nameof(bodymessage), required: false);
            SourceExpression.Validate(bodyattachments, nameof(bodyattachments), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/flowCallback/Message";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["resumptionToken"] = SourceExpressionConverter.ConvertO(resumptionToken);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodymessage != null)
                {
                    body["message"] = SourceExpressionConverter.ConvertToken(bodymessage);
                    bodypropCount++;
                }

                if (bodyattachments != null)
                {
                    body["attachments"] = SourceExpressionConverter.ConvertToken(bodyattachments);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "livetilesbots")]
        public IWorkflowAction FlowComplete([WorkflowExpression] Func<string> resumptionToken)
        {
            SourceExpression.Validate(resumptionToken, nameof(resumptionToken), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/flowCallback/Done";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["resumptionToken"] = SourceExpressionConverter.ConvertO(resumptionToken);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }
    }

    public class LivetilesbotsTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger IntentRecognized([WorkflowExpression] Func<string> subscriptionbot, [WorkflowExpression] Func<string> subscriptionflow, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(subscriptionbot, nameof(subscriptionbot), required: true);
            SourceExpression.Validate(subscriptionflow, nameof(subscriptionflow), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/flows/subscribe";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var subscription = new JObject();
                var subscriptionpropCount = 0;
                subscriptionpropCount++;
                subscription["bot"] = SourceExpressionConverter.ConvertToken(subscriptionbot);
                subscriptionpropCount++;
                subscription["key"] = SourceExpressionConverter.ConvertToken(subscriptionflow);
                subscription["callbackUri"] = "#{listCallbackUrl()}";
                subscriptionpropCount++;
                if (subscriptionpropCount > 0)
                {
                    callPayload.Body = subscription;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
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