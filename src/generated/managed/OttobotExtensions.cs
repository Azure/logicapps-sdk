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
        public IWorkflowAction SendAttachmentsToUrl(Expression<Func<string>> bodyaPIURL, Expression<Func<string>> bodyattachmentURL, Expression<Func<string>> bodyattachmentFileName)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ottobot")]
        public IBodyWorkflowAction<Response> ReturnResultsToBot(Expression<Func<string>> returnResultURL, Expression<Func<string>> bodyadaptiveCardadaptiveCardSchema, Expression<Func<string>> bodyadaptiveCardadaptiveCardType, Expression<Func<string>> bodyadaptiveCardadaptiveCardVersion, Expression<Func<string>> bodytext, Expression<Func<bool>> bodyendRequest, Expression<Func<JToken[]>> bodyadaptiveCardadaptiveCardActions = null, Expression<Func<JToken[]>> bodyadaptiveCardadaptiveCardBody = null, Expression<Func<bool>> bodyrenderPreformattedText = null)
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

namespace Microsoft.Azure.Workflows.Sdk.Connectors
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