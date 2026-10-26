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
        public IBodyWorkflowAction<MessagePostResponse, ApiConnectionActionConfiguration> Message(Expression<Func<string>> bodytemplate = null, Expression<Func<string>> bodyto = null, Expression<Func<string>> bodyfrom = null, Expression<Func<string>> bodysubject = null, Expression<Func<bodytemplateVariablesInputItem[]>> bodytemplateVariables = null)
        {
            var __workflow_bodytemplate = WorkflowExpression.Compile(bodytemplate, nameof(bodytemplate), required: false);
            var __workflow_bodyto = WorkflowExpression.Compile(bodyto, nameof(bodyto), required: false);
            var __workflow_bodyfrom = WorkflowExpression.Compile(bodyfrom, nameof(bodyfrom), required: false);
            var __workflow_bodysubject = WorkflowExpression.Compile(bodysubject, nameof(bodysubject), required: false);
            var __workflow_bodytemplateVariables = WorkflowExpression.Compile(bodytemplateVariables, nameof(bodytemplateVariables), required: false);
            return new DeferredBodyAction<MessagePostResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/messages";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodytemplate != null)
                {
                    body["template"] = ExpressionConverter.ConvertO(__workflow_bodytemplate);
                    bodypropCount++;
                }

                if (__workflow_bodyto != null)
                {
                    body["to"] = ExpressionConverter.ConvertO(__workflow_bodyto);
                    bodypropCount++;
                }

                if (__workflow_bodyfrom != null)
                {
                    body["from"] = ExpressionConverter.ConvertO(__workflow_bodyfrom);
                    bodypropCount++;
                }

                if (__workflow_bodysubject != null)
                {
                    body["subject"] = ExpressionConverter.ConvertO(__workflow_bodysubject);
                    bodypropCount++;
                }

                if (__workflow_bodytemplateVariables != null)
                {
                    body["templateVariables"] = ExpressionConverter.ConvertO(__workflow_bodytemplateVariables);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

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