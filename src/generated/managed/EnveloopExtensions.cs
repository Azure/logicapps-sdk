//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Enveloop
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class EnveloopActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "enveloop")]
        public IBodyWorkflowAction<MessagePostResponse> MessagePost(Expression<Func<string>> bodytemplate = null, Expression<Func<string>> bodyto = null, Expression<Func<string>> bodyfrom = null, Expression<Func<string>> bodysubject = null, Expression<Func<bodytemplateVariablesInputItem[]>> bodytemplateVariables = null)
        {
            var apiCallPath = "/messages";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodytemplate != null)
            {
                body["template"] = ExpressionConverter.ConvertO(bodytemplate);
                bodypropCount++;
            }

            if (bodyto != null)
            {
                body["to"] = ExpressionConverter.ConvertO(bodyto);
                bodypropCount++;
            }

            if (bodyfrom != null)
            {
                body["from"] = ExpressionConverter.ConvertO(bodyfrom);
                bodypropCount++;
            }

            if (bodysubject != null)
            {
                body["subject"] = ExpressionConverter.ConvertO(bodysubject);
                bodypropCount++;
            }

            if (bodytemplateVariables != null)
            {
                body["templateVariables"] = ExpressionConverter.ConvertO(bodytemplateVariables);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<MessagePostResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "enveloop")]
        public IBodyWorkflowAction<TemplateGetResponse> TemplateGet(Expression<Func<string>> templateName)
        {
            var apiCallPath = String.Format("/templates/{0}", ExpressionConverter.ConvertWithUrlEncoding(templateName, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<TemplateGetResponse>(callPayload);
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

    public class bodytemplateVariablesInputItem
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