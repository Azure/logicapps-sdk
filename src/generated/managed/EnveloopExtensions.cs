//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Enveloop
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class EnveloopActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "enveloop")]
        [WorkflowExpressionFactory(nameof(__BuildMessage))]
        public IBodyWorkflowAction<MessagePostResponse> Message([WorkflowExpression] Func<string> bodytemplate = null, [WorkflowExpression] Func<string> bodyto = null, [WorkflowExpression] Func<string> bodyfrom = null, [WorkflowExpression] Func<string> bodysubject = null, [WorkflowExpression] Func<bodytemplateVariablesInputItem[]> bodytemplateVariables = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MessagePostResponse> __BuildMessage(WorkflowExpression<string> bodytemplate = null, WorkflowExpression<string> bodyto = null, WorkflowExpression<string> bodyfrom = null, WorkflowExpression<string> bodysubject = null, WorkflowExpression<bodytemplateVariablesInputItem[]> bodytemplateVariables = null)
        {
            WorkflowExpression.Validate(bodytemplate, nameof(bodytemplate), required: false);
            WorkflowExpression.Validate(bodyto, nameof(bodyto), required: false);
            WorkflowExpression.Validate(bodyfrom, nameof(bodyfrom), required: false);
            WorkflowExpression.Validate(bodysubject, nameof(bodysubject), required: false);
            WorkflowExpression.Validate(bodytemplateVariables, nameof(bodytemplateVariables), required: false);
            return new DeferredBodyAction<MessagePostResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "enveloop")]
        [WorkflowExpressionFactory(nameof(__BuildTemplateGet))]
        public IBodyWorkflowAction<TemplateGetResponse> TemplateGet([WorkflowExpression] Func<string> templateName)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TemplateGetResponse> __BuildTemplateGet(WorkflowExpression<string> templateName)
        {
            WorkflowExpression.Validate(templateName, nameof(templateName), required: true);
            return new DeferredBodyAction<TemplateGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/templates/{0}", ExpressionConverter.ConvertWithUrlEncoding(templateName, 1));
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