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
        public IBodyWorkflowAction<SendSignRequestResponse> SendSignRequest(Expression<Func<string>> contentType, Expression<Func<string>> accept, Expression<Func<string>> bodygroupCode, Expression<Func<string>> bodynotificationsharedLinkemail, Expression<Func<string>> bodynotificationtext = null, Expression<Func<string>> bodynotificationdetail = null, Expression<Func<string>> bodynotificationsharedLinksubject = null, Expression<Func<string>> bodydocumenttemplateCode = null, Expression<Func<string>> bodycallbackMails = null)
        {
            var apiCallPath = "/documents/api/v3/messages/";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = CSharpExpressionConverter.ConvertO(contentType);
            callPayload.Headers["Accept"] = CSharpExpressionConverter.ConvertO(accept);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["groupCode"] = CSharpExpressionConverter.ConvertToken(bodygroupCode);
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
                notificationObject["text"] = CSharpExpressionConverter.ConvertToken(bodynotificationtext);
                notificationObjectpropCount++;
            }

            if (bodynotificationdetail != null)
            {
                notificationObject["detail"] = CSharpExpressionConverter.ConvertToken(bodynotificationdetail);
                notificationObjectpropCount++;
            }

            var sharedLinkObject = new JObject();
            var sharedLinkObjectpropCount = 0;
            sharedLinkObjectpropCount++;
            sharedLinkObject["email"] = CSharpExpressionConverter.ConvertToken(bodynotificationsharedLinkemail);
            if (bodynotificationsharedLinksubject != null)
            {
                sharedLinkObject["subject"] = CSharpExpressionConverter.ConvertToken(bodynotificationsharedLinksubject);
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
                documentObject["templateCode"] = CSharpExpressionConverter.ConvertToken(bodydocumenttemplateCode);
                documentObjectpropCount++;
            }

            if (documentObjectpropCount > 0)
            {
                body["document"] = documentObject;
                bodypropCount++;
            }

            if (bodycallbackMails != null)
            {
                body["callbackMails"] = CSharpExpressionConverter.ConvertToken(bodycallbackMails);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<SendSignRequestResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "viafirma")]
        public IBodyWorkflowAction<CreateSignRequestResponse> CreateSignRequest(Expression<Func<string>> contentType, Expression<Func<string>> accept, Expression<Func<string>> bodygroupCode, Expression<Func<string>> bodydocumenttemplateCode = null)
        {
            var apiCallPath = "/documents/api/v3/messages/dispatch";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = CSharpExpressionConverter.ConvertO(contentType);
            callPayload.Headers["Accept"] = CSharpExpressionConverter.ConvertO(accept);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["groupCode"] = CSharpExpressionConverter.ConvertToken(bodygroupCode);
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
                documentObject["templateCode"] = CSharpExpressionConverter.ConvertToken(bodydocumenttemplateCode);
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

            return new ApiConnectionAction<CreateSignRequestResponse>(callPayload);
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