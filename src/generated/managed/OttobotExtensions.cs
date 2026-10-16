//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Ottobot
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class OttobotActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ottobot")]
        public IWorkflowAction SendAttachmentsToUrl(Expression<Func<string>> bodyaPIURL, Expression<Func<string>> bodyattachmentURL, Expression<Func<string>> bodyattachmentFileName)
        {
            var __workflow_bodyaPIURL = WorkflowExpression.Compile(bodyaPIURL, nameof(bodyaPIURL), required: true);
            var __workflow_bodyattachmentURL = WorkflowExpression.Compile(bodyattachmentURL, nameof(bodyattachmentURL), required: true);
            var __workflow_bodyattachmentFileName = WorkflowExpression.Compile(bodyattachmentFileName, nameof(bodyattachmentFileName), required: true);
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
                body["apiUrl"] = ExpressionConverter.ConvertO(__workflow_bodyaPIURL);
                bodypropCount++;
                body["attachmentUrl"] = ExpressionConverter.ConvertO(__workflow_bodyattachmentURL);
                bodypropCount++;
                body["filename"] = ExpressionConverter.ConvertO(__workflow_bodyattachmentFileName);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ottobot")]
        public IBodyWorkflowAction<Response> ReturnResultsToBot(Expression<Func<string>> returnResultURL, Expression<Func<string>> bodyadaptiveCardadaptiveCardSchema, Expression<Func<string>> bodyadaptiveCardadaptiveCardType, Expression<Func<string>> bodyadaptiveCardadaptiveCardVersion, Expression<Func<string>> bodytext, Expression<Func<bool>> bodyendRequest, Expression<Func<JToken[]>> bodyadaptiveCardadaptiveCardActions = null, Expression<Func<JToken[]>> bodyadaptiveCardadaptiveCardBody = null, Expression<Func<bool>> bodyrenderPreformattedText = null)
        {
            var __workflow_returnResultURL = WorkflowExpression.Compile(returnResultURL, nameof(returnResultURL), required: true);
            var __workflow_bodyadaptiveCardadaptiveCardSchema = WorkflowExpression.Compile(bodyadaptiveCardadaptiveCardSchema, nameof(bodyadaptiveCardadaptiveCardSchema), required: true);
            var __workflow_bodyadaptiveCardadaptiveCardType = WorkflowExpression.Compile(bodyadaptiveCardadaptiveCardType, nameof(bodyadaptiveCardadaptiveCardType), required: true);
            var __workflow_bodyadaptiveCardadaptiveCardVersion = WorkflowExpression.Compile(bodyadaptiveCardadaptiveCardVersion, nameof(bodyadaptiveCardadaptiveCardVersion), required: true);
            var __workflow_bodytext = WorkflowExpression.Compile(bodytext, nameof(bodytext), required: true);
            var __workflow_bodyendRequest = WorkflowExpression.Compile(bodyendRequest, nameof(bodyendRequest), required: true);
            var __workflow_bodyadaptiveCardadaptiveCardActions = WorkflowExpression.Compile(bodyadaptiveCardadaptiveCardActions, nameof(bodyadaptiveCardadaptiveCardActions), required: false);
            var __workflow_bodyadaptiveCardadaptiveCardBody = WorkflowExpression.Compile(bodyadaptiveCardadaptiveCardBody, nameof(bodyadaptiveCardadaptiveCardBody), required: false);
            var __workflow_bodyrenderPreformattedText = WorkflowExpression.Compile(bodyrenderPreformattedText, nameof(bodyrenderPreformattedText), required: false);
            return new DeferredBodyAction<Response>(() =>
            {
                var apiCallPath = "/skills/results";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["returnResultURL"] = ExpressionConverter.Convert(__workflow_returnResultURL);
                var body = new JObject();
                var bodypropCount = 0;
                var adaptiveCardObject = new JObject();
                var adaptiveCardObjectpropCount = 0;
                adaptiveCardObjectpropCount++;
                adaptiveCardObject["$schema"] = ExpressionConverter.ConvertO(__workflow_bodyadaptiveCardadaptiveCardSchema);
                if (__workflow_bodyadaptiveCardadaptiveCardActions != null)
                {
                    adaptiveCardObject["actions"] = ExpressionConverter.ConvertO(__workflow_bodyadaptiveCardadaptiveCardActions);
                    adaptiveCardObjectpropCount++;
                }

                if (__workflow_bodyadaptiveCardadaptiveCardBody != null)
                {
                    adaptiveCardObject["body"] = ExpressionConverter.ConvertO(__workflow_bodyadaptiveCardadaptiveCardBody);
                    adaptiveCardObjectpropCount++;
                }

                adaptiveCardObjectpropCount++;
                adaptiveCardObject["type"] = ExpressionConverter.ConvertO(__workflow_bodyadaptiveCardadaptiveCardType);
                adaptiveCardObjectpropCount++;
                adaptiveCardObject["version"] = ExpressionConverter.ConvertO(__workflow_bodyadaptiveCardadaptiveCardVersion);
                if (adaptiveCardObjectpropCount > 0)
                {
                    body["adaptiveCard"] = adaptiveCardObject;
                    bodypropCount++;
                }

                if (__workflow_bodyrenderPreformattedText != null)
                {
                    body["renderPreformattedText"] = ExpressionConverter.ConvertO(__workflow_bodyrenderPreformattedText);
                    bodypropCount++;
                }

                bodypropCount++;
                body["text"] = ExpressionConverter.ConvertO(__workflow_bodytext);
                bodypropCount++;
                body["endRequest"] = ExpressionConverter.ConvertO(__workflow_bodyendRequest);
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
