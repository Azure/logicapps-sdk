//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Viafirma
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class ViafirmaActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "viafirma")]
        public IBodyWorkflowAction<SendSignRequestResponse> SendSignRequest(Expression<Func<string>> contentType, Expression<Func<string>> accept, Expression<Func<string>> bodygroupCode, Expression<Func<string>> bodynotificationsharedLinkemail, Expression<Func<string>> bodynotificationtext = null, Expression<Func<string>> bodynotificationdetail = null, Expression<Func<string>> bodynotificationsharedLinksubject = null, Expression<Func<string>> bodydocumenttemplateCode = null, Expression<Func<string>> bodycallbackMails = null)
        {
            var __workflow_contentType = contentType == null ? null : WorkflowExpression.Compile(contentType);
            WorkflowExpression.Validate(__workflow_contentType, nameof(contentType), required: true);
            var __workflow_accept = accept == null ? null : WorkflowExpression.Compile(accept);
            WorkflowExpression.Validate(__workflow_accept, nameof(accept), required: true);
            var __workflow_bodygroupCode = bodygroupCode == null ? null : WorkflowExpression.Compile(bodygroupCode);
            WorkflowExpression.Validate(__workflow_bodygroupCode, nameof(bodygroupCode), required: true);
            var __workflow_bodynotificationsharedLinkemail = bodynotificationsharedLinkemail == null ? null : WorkflowExpression.Compile(bodynotificationsharedLinkemail);
            WorkflowExpression.Validate(__workflow_bodynotificationsharedLinkemail, nameof(bodynotificationsharedLinkemail), required: true);
            var __workflow_bodynotificationtext = bodynotificationtext == null ? null : WorkflowExpression.Compile(bodynotificationtext);
            WorkflowExpression.Validate(__workflow_bodynotificationtext, nameof(bodynotificationtext), required: false);
            var __workflow_bodynotificationdetail = bodynotificationdetail == null ? null : WorkflowExpression.Compile(bodynotificationdetail);
            WorkflowExpression.Validate(__workflow_bodynotificationdetail, nameof(bodynotificationdetail), required: false);
            var __workflow_bodynotificationsharedLinksubject = bodynotificationsharedLinksubject == null ? null : WorkflowExpression.Compile(bodynotificationsharedLinksubject);
            WorkflowExpression.Validate(__workflow_bodynotificationsharedLinksubject, nameof(bodynotificationsharedLinksubject), required: false);
            var __workflow_bodydocumenttemplateCode = bodydocumenttemplateCode == null ? null : WorkflowExpression.Compile(bodydocumenttemplateCode);
            WorkflowExpression.Validate(__workflow_bodydocumenttemplateCode, nameof(bodydocumenttemplateCode), required: false);
            var __workflow_bodycallbackMails = bodycallbackMails == null ? null : WorkflowExpression.Compile(bodycallbackMails);
            WorkflowExpression.Validate(__workflow_bodycallbackMails, nameof(bodycallbackMails), required: false);
            return new DeferredBodyAction<SendSignRequestResponse>(() =>
            {
                var apiCallPath = "/documents/api/v3/messages/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(__workflow_contentType);
                callPayload.Headers["Accept"] = ExpressionConverter.Convert(__workflow_accept);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["groupCode"] = ExpressionConverter.ConvertO(__workflow_bodygroupCode);
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
                if (__workflow_bodynotificationtext != null)
                {
                    notificationObject["text"] = ExpressionConverter.ConvertO(__workflow_bodynotificationtext);
                    notificationObjectpropCount++;
                }

                if (__workflow_bodynotificationdetail != null)
                {
                    notificationObject["detail"] = ExpressionConverter.ConvertO(__workflow_bodynotificationdetail);
                    notificationObjectpropCount++;
                }

                var sharedLinkObject = new JObject();
                var sharedLinkObjectpropCount = 0;
                sharedLinkObjectpropCount++;
                sharedLinkObject["email"] = ExpressionConverter.ConvertO(__workflow_bodynotificationsharedLinkemail);
                if (__workflow_bodynotificationsharedLinksubject != null)
                {
                    sharedLinkObject["subject"] = ExpressionConverter.ConvertO(__workflow_bodynotificationsharedLinksubject);
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
                if (__workflow_bodydocumenttemplateCode != null)
                {
                    documentObject["templateCode"] = ExpressionConverter.ConvertO(__workflow_bodydocumenttemplateCode);
                    documentObjectpropCount++;
                }

                if (documentObjectpropCount > 0)
                {
                    body["document"] = documentObject;
                    bodypropCount++;
                }

                if (__workflow_bodycallbackMails != null)
                {
                    body["callbackMails"] = ExpressionConverter.ConvertO(__workflow_bodycallbackMails);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<SendSignRequestResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "viafirma")]
        public IBodyWorkflowAction<CreateSignRequestResponse> CreateSignRequest(Expression<Func<string>> contentType, Expression<Func<string>> accept, Expression<Func<string>> bodygroupCode, Expression<Func<string>> bodydocumenttemplateCode = null)
        {
            var __workflow_contentType = contentType == null ? null : WorkflowExpression.Compile(contentType);
            WorkflowExpression.Validate(__workflow_contentType, nameof(contentType), required: true);
            var __workflow_accept = accept == null ? null : WorkflowExpression.Compile(accept);
            WorkflowExpression.Validate(__workflow_accept, nameof(accept), required: true);
            var __workflow_bodygroupCode = bodygroupCode == null ? null : WorkflowExpression.Compile(bodygroupCode);
            WorkflowExpression.Validate(__workflow_bodygroupCode, nameof(bodygroupCode), required: true);
            var __workflow_bodydocumenttemplateCode = bodydocumenttemplateCode == null ? null : WorkflowExpression.Compile(bodydocumenttemplateCode);
            WorkflowExpression.Validate(__workflow_bodydocumenttemplateCode, nameof(bodydocumenttemplateCode), required: false);
            return new DeferredBodyAction<CreateSignRequestResponse>(() =>
            {
                var apiCallPath = "/documents/api/v3/messages/dispatch";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(__workflow_contentType);
                callPayload.Headers["Accept"] = ExpressionConverter.Convert(__workflow_accept);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["groupCode"] = ExpressionConverter.ConvertO(__workflow_bodygroupCode);
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
                if (__workflow_bodydocumenttemplateCode != null)
                {
                    documentObject["templateCode"] = ExpressionConverter.ConvertO(__workflow_bodydocumenttemplateCode);
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
            });
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
