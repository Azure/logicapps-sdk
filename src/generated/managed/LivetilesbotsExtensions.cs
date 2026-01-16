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
        public IWorkflowAction PromptString(Expression<Func<string>> resumptionToken, Expression<Func<string>> bodyprompt = null)
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

            body["callbackUri"] = "@listcallbackurl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "livetilesbots")]
        public IWorkflowAction PromptNumber(Expression<Func<string>> resumptionToken, Expression<Func<string>> bodyprompt = null)
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

            body["callbackUri"] = "@listcallbackurl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "livetilesbots")]
        public IWorkflowAction PromptForm(Expression<Func<string>> resumptionToken, Expression<Func<bodyformFieldsInputItem[]>> bodyformFields, Expression<Func<string>> bodyprompt = null, Expression<Func<string>> bodytitle = null)
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

            body["callbackUri"] = "@listcallbackurl()";
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "livetilesbots")]
        public IWorkflowAction PromptBoolean(Expression<Func<string>> resumptionToken, Expression<Func<string>> bodyprompt = null)
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

            body["callbackUri"] = "@listcallbackurl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "livetilesbots")]
        public IWorkflowAction PromptChoice(Expression<Func<string>> resumptionToken, Expression<Func<string>> bodyprompt = null, Expression<Func<bodyoptionsInputItem[]>> bodyoptions = null)
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

            body["callbackUri"] = "@listcallbackurl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "livetilesbots")]
        public IWorkflowAction PromptFile(Expression<Func<string>> resumptionToken, Expression<Func<string>> bodyprompt = null, Expression<Func<string[]>> bodycontentTypes = null)
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

            body["callbackUri"] = "@listcallbackurl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "livetilesbots")]
        public IWorkflowAction PostMessage(Expression<Func<string>> resumptionToken, Expression<Func<string>> bodymessage = null, Expression<Func<bodyattachmentsInputItem[]>> bodyattachments = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "livetilesbots")]
        public IWorkflowAction FlowComplete(Expression<Func<string>> resumptionToken)
        {
            var apiCallPath = "/flowCallback/Done";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["resumptionToken"] = ExpressionConverter.Convert(resumptionToken);
            return new ApiConnectionAction(callPayload);
        }
    }

    public class LivetilesbotsTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger IntentRecognized(Expression<Func<string>> subscriptionbot, Expression<Func<string>> subscriptionflow, string triggerName = null)
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
            subscription["callbackUri"] = "@listcallbackurl()";
            subscriptionpropCount++;
            if (subscriptionpropCount > 0)
            {
                callPayload.Body = subscription;
            }

            return new ApiConnectionTrigger(callPayload);
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