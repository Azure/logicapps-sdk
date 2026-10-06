//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Ottobot
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class OttobotActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ottobot")]
        public IWorkflowAction SendAttachmentsToUrl([WorkflowExpression] Func<string> bodyaPIURL, [WorkflowExpression] Func<string> bodyattachmentURL, [WorkflowExpression] Func<string> bodyattachmentFileName)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/attachments";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var additionalParametersObject = new JObject();
                var additionalParametersObjectpropCount = 0;
                if (additionalParametersObjectpropCount > 0)
                {
                    body["additionalParameters"] = additionalParametersObject;
                    bodypropCount++;
                }

                var apiRequestHeadersObject = new JObject();
                var apiRequestHeadersObjectpropCount = 0;
                if (apiRequestHeadersObjectpropCount > 0)
                {
                    body["apiRequestHeaders"] = apiRequestHeadersObject;
                    bodypropCount++;
                }

                bodypropCount++;
                body["apiUrl"] = SourceExpressionConverter.ConvertToken(bodyaPIURL);
                bodypropCount++;
                body["attachmentUrl"] = SourceExpressionConverter.ConvertToken(bodyattachmentURL);
                bodypropCount++;
                body["filename"] = SourceExpressionConverter.ConvertToken(bodyattachmentFileName);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ottobot")]
        public IBodyWorkflowAction<Response> ReturnResultsToBot([WorkflowExpression] Func<string> returnResultURL, [WorkflowExpression] Func<string> bodyadaptiveCardadaptiveCardSchema, [WorkflowExpression] Func<string> bodyadaptiveCardadaptiveCardType, [WorkflowExpression] Func<string> bodyadaptiveCardadaptiveCardVersion, [WorkflowExpression] Func<string> bodytext, [WorkflowExpression] Func<bool> bodyendRequest, [WorkflowExpression] Func<JToken[]> bodyadaptiveCardadaptiveCardActions = null, [WorkflowExpression] Func<JToken[]> bodyadaptiveCardadaptiveCardBody = null, [WorkflowExpression] Func<bool> bodyrenderPreformattedText = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/skills/results";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["returnResultURL"] = SourceExpressionConverter.ConvertO(returnResultURL);
                var body = new JObject();
                var bodypropCount = 0;
                var adaptiveCardObject = new JObject();
                var adaptiveCardObjectpropCount = 0;
                adaptiveCardObjectpropCount++;
                adaptiveCardObject["$schema"] = SourceExpressionConverter.ConvertToken(bodyadaptiveCardadaptiveCardSchema);
                if (bodyadaptiveCardadaptiveCardActions != null)
                {
                    adaptiveCardObject["actions"] = SourceExpressionConverter.ConvertToken(bodyadaptiveCardadaptiveCardActions);
                    adaptiveCardObjectpropCount++;
                }

                if (bodyadaptiveCardadaptiveCardBody != null)
                {
                    adaptiveCardObject["body"] = SourceExpressionConverter.ConvertToken(bodyadaptiveCardadaptiveCardBody);
                    adaptiveCardObjectpropCount++;
                }

                adaptiveCardObjectpropCount++;
                adaptiveCardObject["type"] = SourceExpressionConverter.ConvertToken(bodyadaptiveCardadaptiveCardType);
                adaptiveCardObjectpropCount++;
                adaptiveCardObject["version"] = SourceExpressionConverter.ConvertToken(bodyadaptiveCardadaptiveCardVersion);
                if (adaptiveCardObjectpropCount > 0)
                {
                    body["adaptiveCard"] = adaptiveCardObject;
                    bodypropCount++;
                }

                if (bodyrenderPreformattedText != null)
                {
                    body["renderPreformattedText"] = SourceExpressionConverter.ConvertToken(bodyrenderPreformattedText);
                    bodypropCount++;
                }

                bodypropCount++;
                body["text"] = SourceExpressionConverter.ConvertToken(bodytext);
                bodypropCount++;
                body["endRequest"] = SourceExpressionConverter.ConvertToken(bodyendRequest);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<Response>(BuildSourceInput);
        }
    }

    public class OttobotTriggers([ConnectionName] string connectionId)
    {
    }

    public class Response
    {
        [JsonProperty("message")]
        public string ResultMessage { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Ottobot;

    public partial class WorkflowManagedActions
    {
        public OttobotActions Ottobot(string connectionId) => new OttobotActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public OttobotTriggers Ottobot(string connectionId) => new OttobotTriggers(connectionId);
    }
}