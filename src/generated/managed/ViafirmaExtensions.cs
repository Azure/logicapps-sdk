//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Viafirma
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ViafirmaActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "viafirma")]
        public IBodyWorkflowAction<SendSignRequestResponse> SendSignRequest([WorkflowExpression] Func<string> contentType, [WorkflowExpression] Func<string> accept, [WorkflowExpression] Func<string> bodygroupCode, [WorkflowExpression] Func<string> bodynotificationsharedLinkemail, [WorkflowExpression] Func<string> bodynotificationtext = null, [WorkflowExpression] Func<string> bodynotificationdetail = null, [WorkflowExpression] Func<string> bodynotificationsharedLinksubject = null, [WorkflowExpression] Func<string> bodydocumenttemplateCode = null, [WorkflowExpression] Func<string> bodycallbackMails = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/documents/api/v3/messages/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = SourceExpressionConverter.ConvertO(contentType);
                callPayload.Headers["Accept"] = SourceExpressionConverter.ConvertO(accept);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["groupCode"] = SourceExpressionConverter.ConvertToken(bodygroupCode);
                var workflowObject = new JObject();
                var workflowObjectpropCount = 0;
                workflowObject["type"] = "WEB";
                workflowObjectpropCount++;
                if (workflowObjectpropCount > 0)
                {
                    body["workflow"] = workflowObject;
                    bodypropCount++;
                }

                var notificationObject = new JObject();
                var notificationObjectpropCount = 0;
                if (bodynotificationtext != null)
                {
                    notificationObject["text"] = SourceExpressionConverter.ConvertToken(bodynotificationtext);
                    notificationObjectpropCount++;
                }

                if (bodynotificationdetail != null)
                {
                    notificationObject["detail"] = SourceExpressionConverter.ConvertToken(bodynotificationdetail);
                    notificationObjectpropCount++;
                }

                var sharedLinkObject = new JObject();
                var sharedLinkObjectpropCount = 0;
                sharedLinkObjectpropCount++;
                sharedLinkObject["email"] = SourceExpressionConverter.ConvertToken(bodynotificationsharedLinkemail);
                if (bodynotificationsharedLinksubject != null)
                {
                    sharedLinkObject["subject"] = SourceExpressionConverter.ConvertToken(bodynotificationsharedLinksubject);
                    sharedLinkObjectpropCount++;
                }

                if (sharedLinkObjectpropCount > 0)
                {
                    notificationObject["sharedLink"] = sharedLinkObject;
                    notificationObjectpropCount++;
                }

                if (notificationObjectpropCount > 0)
                {
                    body["notification"] = notificationObject;
                    bodypropCount++;
                }

                var documentObject = new JObject();
                var documentObjectpropCount = 0;
                if (bodydocumenttemplateCode != null)
                {
                    documentObject["templateCode"] = SourceExpressionConverter.ConvertToken(bodydocumenttemplateCode);
                    documentObjectpropCount++;
                }

                if (documentObjectpropCount > 0)
                {
                    body["document"] = documentObject;
                    bodypropCount++;
                }

                if (bodycallbackMails != null)
                {
                    body["callbackMails"] = SourceExpressionConverter.ConvertToken(bodycallbackMails);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SendSignRequestResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "viafirma")]
        public IBodyWorkflowAction<CreateSignRequestResponse> CreateSignRequest([WorkflowExpression] Func<string> contentType, [WorkflowExpression] Func<string> accept, [WorkflowExpression] Func<string> bodygroupCode, [WorkflowExpression] Func<string> bodydocumenttemplateCode = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/documents/api/v3/messages/dispatch";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = SourceExpressionConverter.ConvertO(contentType);
                callPayload.Headers["Accept"] = SourceExpressionConverter.ConvertO(accept);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["groupCode"] = SourceExpressionConverter.ConvertToken(bodygroupCode);
                var workflowObject = new JObject();
                var workflowObjectpropCount = 0;
                workflowObject["type"] = "PRESENTIAL";
                workflowObjectpropCount++;
                if (workflowObjectpropCount > 0)
                {
                    body["workflow"] = workflowObject;
                    bodypropCount++;
                }

                var documentObject = new JObject();
                var documentObjectpropCount = 0;
                if (bodydocumenttemplateCode != null)
                {
                    documentObject["templateCode"] = SourceExpressionConverter.ConvertToken(bodydocumenttemplateCode);
                    documentObjectpropCount++;
                }

                if (documentObjectpropCount > 0)
                {
                    body["document"] = documentObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CreateSignRequestResponse>(BuildSourceInput);
        }
    }

    public class ViafirmaTriggers([ConnectionName] string connectionId)
    {
    }

    public class SendSignRequestResponse
    {
        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class CreateSignRequestResponse
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Viafirma;

    public partial class WorkflowManagedActions
    {
        public ViafirmaActions Viafirma(string connectionId) => new ViafirmaActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public ViafirmaTriggers Viafirma(string connectionId) => new ViafirmaTriggers(connectionId);
    }
}