//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Ottobot
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class OttobotActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ottobot")]
        [WorkflowExpressionFactory(nameof(__BuildSendAttachmentsToUrl))]
        public IWorkflowAction SendAttachmentsToUrl([WorkflowExpression] Func<string> bodyaPIURL, [WorkflowExpression] Func<string> bodyattachmentURL, [WorkflowExpression] Func<string> bodyattachmentFileName)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildSendAttachmentsToUrl(WorkflowExpression<string> bodyaPIURL, WorkflowExpression<string> bodyattachmentURL, WorkflowExpression<string> bodyattachmentFileName)
        {
            WorkflowExpression.Validate(bodyaPIURL, nameof(bodyaPIURL), required: true);
            WorkflowExpression.Validate(bodyattachmentURL, nameof(bodyattachmentURL), required: true);
            WorkflowExpression.Validate(bodyattachmentFileName, nameof(bodyattachmentFileName), required: true);
            return new DeferredWorkflowAction(() =>
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
                body["apiUrl"] = ExpressionConverter.ConvertO(bodyaPIURL);
                bodypropCount++;
                body["attachmentUrl"] = ExpressionConverter.ConvertO(bodyattachmentURL);
                bodypropCount++;
                body["filename"] = ExpressionConverter.ConvertO(bodyattachmentFileName);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ottobot")]
        [WorkflowExpressionFactory(nameof(__BuildReturnResultsToBot))]
        public IBodyWorkflowAction<Response> ReturnResultsToBot([WorkflowExpression] Func<string> returnResultURL, [WorkflowExpression] Func<string> bodyadaptiveCardadaptiveCardSchema, [WorkflowExpression] Func<string> bodyadaptiveCardadaptiveCardType, [WorkflowExpression] Func<string> bodyadaptiveCardadaptiveCardVersion, [WorkflowExpression] Func<string> bodytext, [WorkflowExpression] Func<bool> bodyendRequest, [WorkflowExpression] Func<JToken[]> bodyadaptiveCardadaptiveCardActions = null, [WorkflowExpression] Func<JToken[]> bodyadaptiveCardadaptiveCardBody = null, [WorkflowExpression] Func<bool> bodyrenderPreformattedText = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Response> __BuildReturnResultsToBot(WorkflowExpression<string> returnResultURL, WorkflowExpression<string> bodyadaptiveCardadaptiveCardSchema, WorkflowExpression<string> bodyadaptiveCardadaptiveCardType, WorkflowExpression<string> bodyadaptiveCardadaptiveCardVersion, WorkflowExpression<string> bodytext, WorkflowExpression<bool> bodyendRequest, WorkflowExpression<JToken[]> bodyadaptiveCardadaptiveCardActions = null, WorkflowExpression<JToken[]> bodyadaptiveCardadaptiveCardBody = null, WorkflowExpression<bool> bodyrenderPreformattedText = null)
        {
            WorkflowExpression.Validate(returnResultURL, nameof(returnResultURL), required: true);
            WorkflowExpression.Validate(bodyadaptiveCardadaptiveCardSchema, nameof(bodyadaptiveCardadaptiveCardSchema), required: true);
            WorkflowExpression.Validate(bodyadaptiveCardadaptiveCardType, nameof(bodyadaptiveCardadaptiveCardType), required: true);
            WorkflowExpression.Validate(bodyadaptiveCardadaptiveCardVersion, nameof(bodyadaptiveCardadaptiveCardVersion), required: true);
            WorkflowExpression.Validate(bodytext, nameof(bodytext), required: true);
            WorkflowExpression.Validate(bodyendRequest, nameof(bodyendRequest), required: true);
            WorkflowExpression.Validate(bodyadaptiveCardadaptiveCardActions, nameof(bodyadaptiveCardadaptiveCardActions), required: false);
            WorkflowExpression.Validate(bodyadaptiveCardadaptiveCardBody, nameof(bodyadaptiveCardadaptiveCardBody), required: false);
            WorkflowExpression.Validate(bodyrenderPreformattedText, nameof(bodyrenderPreformattedText), required: false);
            return new DeferredBodyAction<Response>(() =>
            {
                var apiCallPath = "/skills/results";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["returnResultURL"] = ExpressionConverter.Convert(returnResultURL);
                var body = new JObject();
                var bodypropCount = 0;
                var adaptiveCardObject = new JObject();
                var adaptiveCardObjectpropCount = 0;
                adaptiveCardObjectpropCount++;
                adaptiveCardObject["$schema"] = ExpressionConverter.ConvertO(bodyadaptiveCardadaptiveCardSchema);
                if (bodyadaptiveCardadaptiveCardActions != null)
                {
                    adaptiveCardObject["actions"] = ExpressionConverter.ConvertO(bodyadaptiveCardadaptiveCardActions);
                    adaptiveCardObjectpropCount++;
                }

                if (bodyadaptiveCardadaptiveCardBody != null)
                {
                    adaptiveCardObject["body"] = ExpressionConverter.ConvertO(bodyadaptiveCardadaptiveCardBody);
                    adaptiveCardObjectpropCount++;
                }

                adaptiveCardObjectpropCount++;
                adaptiveCardObject["type"] = ExpressionConverter.ConvertO(bodyadaptiveCardadaptiveCardType);
                adaptiveCardObjectpropCount++;
                adaptiveCardObject["version"] = ExpressionConverter.ConvertO(bodyadaptiveCardadaptiveCardVersion);
                if (adaptiveCardObjectpropCount > 0)
                {
                    body["adaptiveCard"] = adaptiveCardObject;
                    bodypropCount++;
                }

                if (bodyrenderPreformattedText != null)
                {
                    body["renderPreformattedText"] = ExpressionConverter.ConvertO(bodyrenderPreformattedText);
                    bodypropCount++;
                }

                bodypropCount++;
                body["text"] = ExpressionConverter.ConvertO(bodytext);
                bodypropCount++;
                body["endRequest"] = ExpressionConverter.ConvertO(bodyendRequest);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<Response>(callPayload);
            });
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