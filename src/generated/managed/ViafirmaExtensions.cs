//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Viafirma
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ViafirmaActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "viafirma")]
        [WorkflowExpressionFactory(nameof(__BuildSendSignRequest))]
        public IBodyWorkflowAction<SendSignRequestResponse> SendSignRequest([WorkflowExpression] Func<string> contentType, [WorkflowExpression] Func<string> accept, [WorkflowExpression] Func<string> bodygroupCode, [WorkflowExpression] Func<string> bodynotificationsharedLinkemail, [WorkflowExpression] Func<string> bodynotificationtext = null, [WorkflowExpression] Func<string> bodynotificationdetail = null, [WorkflowExpression] Func<string> bodynotificationsharedLinksubject = null, [WorkflowExpression] Func<string> bodydocumenttemplateCode = null, [WorkflowExpression] Func<string> bodycallbackMails = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SendSignRequestResponse> __BuildSendSignRequest(WorkflowValue<string> contentType, WorkflowValue<string> accept, WorkflowValue<string> bodygroupCode, WorkflowValue<string> bodynotificationsharedLinkemail, WorkflowValue<string> bodynotificationtext = null, WorkflowValue<string> bodynotificationdetail = null, WorkflowValue<string> bodynotificationsharedLinksubject = null, WorkflowValue<string> bodydocumenttemplateCode = null, WorkflowValue<string> bodycallbackMails = null)
        {
            WorkflowValue.Validate(contentType, nameof(contentType), required: true);
            WorkflowValue.Validate(accept, nameof(accept), required: true);
            WorkflowValue.Validate(bodygroupCode, nameof(bodygroupCode), required: true);
            WorkflowValue.Validate(bodynotificationsharedLinkemail, nameof(bodynotificationsharedLinkemail), required: true);
            WorkflowValue.Validate(bodynotificationtext, nameof(bodynotificationtext), required: false);
            WorkflowValue.Validate(bodynotificationdetail, nameof(bodynotificationdetail), required: false);
            WorkflowValue.Validate(bodynotificationsharedLinksubject, nameof(bodynotificationsharedLinksubject), required: false);
            WorkflowValue.Validate(bodydocumenttemplateCode, nameof(bodydocumenttemplateCode), required: false);
            WorkflowValue.Validate(bodycallbackMails, nameof(bodycallbackMails), required: false);
            return new DeferredBodyAction<SendSignRequestResponse>(() =>
            {
                var apiCallPath = "/documents/api/v3/messages/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(contentType);
                callPayload.Headers["Accept"] = ExpressionConverter.Convert(accept);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["groupCode"] = ExpressionConverter.ConvertO(bodygroupCode);
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
                    notificationObject["text"] = ExpressionConverter.ConvertO(bodynotificationtext);
                    notificationObjectpropCount++;
                }

                if (bodynotificationdetail != null)
                {
                    notificationObject["detail"] = ExpressionConverter.ConvertO(bodynotificationdetail);
                    notificationObjectpropCount++;
                }

                var sharedLinkObject = new JObject();
                var sharedLinkObjectpropCount = 0;
                sharedLinkObjectpropCount++;
                sharedLinkObject["email"] = ExpressionConverter.ConvertO(bodynotificationsharedLinkemail);
                if (bodynotificationsharedLinksubject != null)
                {
                    sharedLinkObject["subject"] = ExpressionConverter.ConvertO(bodynotificationsharedLinksubject);
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
                    documentObject["templateCode"] = ExpressionConverter.ConvertO(bodydocumenttemplateCode);
                    documentObjectpropCount++;
                }

                if (documentObjectpropCount > 0)
                {
                    body["document"] = documentObject;
                    bodypropCount++;
                }

                if (bodycallbackMails != null)
                {
                    body["callbackMails"] = ExpressionConverter.ConvertO(bodycallbackMails);
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
        [WorkflowExpressionFactory(nameof(__BuildCreateSignRequest))]
        public IBodyWorkflowAction<CreateSignRequestResponse> CreateSignRequest([WorkflowExpression] Func<string> contentType, [WorkflowExpression] Func<string> accept, [WorkflowExpression] Func<string> bodygroupCode, [WorkflowExpression] Func<string> bodydocumenttemplateCode = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateSignRequestResponse> __BuildCreateSignRequest(WorkflowValue<string> contentType, WorkflowValue<string> accept, WorkflowValue<string> bodygroupCode, WorkflowValue<string> bodydocumenttemplateCode = null)
        {
            WorkflowValue.Validate(contentType, nameof(contentType), required: true);
            WorkflowValue.Validate(accept, nameof(accept), required: true);
            WorkflowValue.Validate(bodygroupCode, nameof(bodygroupCode), required: true);
            WorkflowValue.Validate(bodydocumenttemplateCode, nameof(bodydocumenttemplateCode), required: false);
            return new DeferredBodyAction<CreateSignRequestResponse>(() =>
            {
                var apiCallPath = "/documents/api/v3/messages/dispatch";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(contentType);
                callPayload.Headers["Accept"] = ExpressionConverter.Convert(accept);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["groupCode"] = ExpressionConverter.ConvertO(bodygroupCode);
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
                    documentObject["templateCode"] = ExpressionConverter.ConvertO(bodydocumenttemplateCode);
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
