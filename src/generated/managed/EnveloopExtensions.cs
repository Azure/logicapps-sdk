//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Enveloop
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class EnveloopActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "enveloop")]
        public IBodyWorkflowAction<MessagePostResponse, ApiConnectionActionConfiguration> Message(Expression<Func<MessagePostInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<MessagePostResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/messages";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<MessagePostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "enveloop")]
        public IBodyWorkflowAction<TemplateGetResponse, ApiConnectionActionConfiguration> TemplateGet(Expression<Func<string>> templateName)
        {
            var __workflow_templateName = WorkflowExpression.Compile(templateName, nameof(templateName), required: true);
            return new DeferredBodyAction<TemplateGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/templates/{0}", __workflow_templateName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<TemplateGetResponse>(callPayload);
            });
        }
    }

    public class EnveloopTriggers([ConnectionName] string connectionId)
    {
    }

    public class MessagePostResponse
    {
        [JsonProperty("messageId")]
        public string MessageId { get; set; }

        [JsonProperty("from")]
        public string From { get; set; }

        [JsonProperty("to")]
        public string To { get; set; }

        [JsonProperty("body")]
        public string Body { get; set; }
    }

    public class MessagePostInput
    {
        [JsonProperty("template")]
        public string Template { get; set; }

        [JsonProperty("to")]
        public string To { get; set; }

        [JsonProperty("from")]
        public string From { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("templateVariables")]
        public MessagePostInputTemplateVariablesTypeItem[] TemplateVariables { get; set; }
    }

    public class MessagePostInputTemplateVariablesTypeItem
    {
        [JsonProperty("variableName")]
        public string VariableName { get; set; }

        [JsonProperty("variableValue")]
        public string VariableValue { get; set; }
    }

    public class TemplateGetResponse
    {
        [JsonProperty("templateVariables")]
        public string[] TemplateVariables { get; set; }

        [JsonProperty("body")]
        public string Body { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Enveloop;

    public partial class WorkflowManagedActions
    {
        public EnveloopActions Enveloop(string connectionId) => new EnveloopActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public EnveloopTriggers Enveloop(string connectionId) => new EnveloopTriggers(connectionId);
    }
}