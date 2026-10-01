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
        public IBodyWorkflowAction<MessagePostResponse> Message([WorkflowExpression] Func<string> bodytemplate = null, [WorkflowExpression] Func<string> bodyto = null, [WorkflowExpression] Func<string> bodyfrom = null, [WorkflowExpression] Func<string> bodysubject = null, [WorkflowExpression] Func<bodytemplateVariablesInputItem[]> bodytemplateVariables = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/messages";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytemplate != null)
                {
                    body["template"] = SourceExpressionConverter.ConvertToken(bodytemplate);
                    bodypropCount++;
                }

                if (bodyto != null)
                {
                    body["to"] = SourceExpressionConverter.ConvertToken(bodyto);
                    bodypropCount++;
                }

                if (bodyfrom != null)
                {
                    body["from"] = SourceExpressionConverter.ConvertToken(bodyfrom);
                    bodypropCount++;
                }

                if (bodysubject != null)
                {
                    body["subject"] = SourceExpressionConverter.ConvertToken(bodysubject);
                    bodypropCount++;
                }

                if (bodytemplateVariables != null)
                {
                    body["templateVariables"] = SourceExpressionConverter.ConvertToken(bodytemplateVariables);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<MessagePostResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "enveloop")]
        public IBodyWorkflowAction<TemplateGetResponse> TemplateGet([WorkflowExpression] Func<string> templateName)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/templates/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(templateName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<TemplateGetResponse>(BuildSourceInput);
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