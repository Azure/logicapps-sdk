//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Smartdialog
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SmartdialogActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smartdialog")]
        [WorkflowExpressionFactory(nameof(__BuildSendMessage))]
        public IBodyWorkflowAction<SendMessageResponse> SendMessage([WorkflowExpression] Func<string> customerId, [WorkflowExpression] Func<string> serviceId, [WorkflowExpression] Func<string> requestBodysender, [WorkflowExpression] Func<string> requestBodycontent, [WorkflowExpression] Func<requestBodyprotocolInput> requestBodyprotocol, [WorkflowExpression] Func<requestBodyrecipientsInputItem[]> requestBodyrecipients, [WorkflowExpression] Func<string> requestBodysendDateTime = null, [WorkflowExpression] Func<string> requestBodyattachmentUri = null, [WorkflowExpression] Func<string> requestBodycustomerData = null, [WorkflowExpression] Func<bool> requestBodyadMessage = null, [WorkflowExpression] Func<string> requestBodydlrUrl = null, [WorkflowExpression] Func<string> requestBodyrequestId = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SendMessageResponse> __BuildSendMessage(WorkflowValue<string> customerId, WorkflowValue<string> serviceId, WorkflowValue<string> requestBodysender, WorkflowValue<string> requestBodycontent, WorkflowValue<requestBodyprotocolInput> requestBodyprotocol, WorkflowValue<requestBodyrecipientsInputItem[]> requestBodyrecipients, WorkflowValue<string> requestBodysendDateTime = null, WorkflowValue<string> requestBodyattachmentUri = null, WorkflowValue<string> requestBodycustomerData = null, WorkflowValue<bool> requestBodyadMessage = null, WorkflowValue<string> requestBodydlrUrl = null, WorkflowValue<string> requestBodyrequestId = null)
        {
            WorkflowValue.Validate(customerId, nameof(customerId), required: true);
            WorkflowValue.Validate(serviceId, nameof(serviceId), required: true);
            WorkflowValue.Validate(requestBodysender, nameof(requestBodysender), required: true);
            WorkflowValue.Validate(requestBodycontent, nameof(requestBodycontent), required: true);
            WorkflowValue.Validate(requestBodyprotocol, nameof(requestBodyprotocol), required: true);
            WorkflowValue.Validate(requestBodyrecipients, nameof(requestBodyrecipients), required: true);
            WorkflowValue.Validate(requestBodysendDateTime, nameof(requestBodysendDateTime), required: false);
            WorkflowValue.Validate(requestBodyattachmentUri, nameof(requestBodyattachmentUri), required: false);
            WorkflowValue.Validate(requestBodycustomerData, nameof(requestBodycustomerData), required: false);
            WorkflowValue.Validate(requestBodyadMessage, nameof(requestBodyadMessage), required: false);
            WorkflowValue.Validate(requestBodydlrUrl, nameof(requestBodydlrUrl), required: false);
            WorkflowValue.Validate(requestBodyrequestId, nameof(requestBodyrequestId), required: false);
            return new DeferredBodyAction<SendMessageResponse>(() =>
            {
                var apiCallPath = "/messages";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Customer-Id"] = ExpressionConverter.Convert(customerId);
                callPayload.Headers["Service-Id"] = ExpressionConverter.Convert(serviceId);
                var requestBody = new JObject();
                var requestBodypropCount = 0;
                requestBodypropCount++;
                requestBody["Sender"] = ExpressionConverter.ConvertO(requestBodysender);
                requestBodypropCount++;
                requestBody["Content"] = ExpressionConverter.ConvertO(requestBodycontent);
                requestBodypropCount++;
                requestBody["Protocol"] = ExpressionConverter.ConvertO(requestBodyprotocol);
                if (requestBodysendDateTime != null)
                {
                    requestBody["SendDateTime"] = ExpressionConverter.ConvertO(requestBodysendDateTime);
                    requestBodypropCount++;
                }

                requestBodypropCount++;
                requestBody["Recipients"] = ExpressionConverter.ConvertO(requestBodyrecipients);
                if (requestBodyattachmentUri != null)
                {
                    requestBody["AttachmentUri"] = ExpressionConverter.ConvertO(requestBodyattachmentUri);
                    requestBodypropCount++;
                }

                if (requestBodycustomerData != null)
                {
                    requestBody["CustomerData"] = ExpressionConverter.ConvertO(requestBodycustomerData);
                    requestBodypropCount++;
                }

                if (requestBodyadMessage != null)
                {
                    requestBody["AdMessage"] = ExpressionConverter.ConvertO(requestBodyadMessage);
                    requestBodypropCount++;
                }

                if (requestBodydlrUrl != null)
                {
                    requestBody["DlrUrl"] = ExpressionConverter.ConvertO(requestBodydlrUrl);
                    requestBodypropCount++;
                }

                if (requestBodyrequestId != null)
                {
                    requestBody["RequestId"] = ExpressionConverter.ConvertO(requestBodyrequestId);
                    requestBodypropCount++;
                }

                if (requestBodypropCount > 0)
                {
                    callPayload.Body = requestBody;
                }

                return new ApiConnectionAction<SendMessageResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smartdialog")]
        [WorkflowExpressionFactory(nameof(__BuildSendReplyMessage))]
        public IBodyWorkflowAction<SendReplyMessageResponse> SendReplyMessage([WorkflowExpression] Func<string> parentMessageId, [WorkflowExpression] Func<string> customerId, [WorkflowExpression] Func<string> serviceId, [WorkflowExpression] Func<string> requestBodysender, [WorkflowExpression] Func<string> requestBodycontent, [WorkflowExpression] Func<requestBodyprotocolInput> requestBodyprotocol, [WorkflowExpression] Func<requestBodyrecipientsInputItem[]> requestBodyrecipients, [WorkflowExpression] Func<string> requestBodysendDateTime = null, [WorkflowExpression] Func<string> requestBodyattachmentUri = null, [WorkflowExpression] Func<string> requestBodycustomerData = null, [WorkflowExpression] Func<bool> requestBodyadMessage = null, [WorkflowExpression] Func<string> requestBodydlrUrl = null, [WorkflowExpression] Func<string> requestBodyrequestId = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SendReplyMessageResponse> __BuildSendReplyMessage(WorkflowValue<string> parentMessageId, WorkflowValue<string> customerId, WorkflowValue<string> serviceId, WorkflowValue<string> requestBodysender, WorkflowValue<string> requestBodycontent, WorkflowValue<requestBodyprotocolInput> requestBodyprotocol, WorkflowValue<requestBodyrecipientsInputItem[]> requestBodyrecipients, WorkflowValue<string> requestBodysendDateTime = null, WorkflowValue<string> requestBodyattachmentUri = null, WorkflowValue<string> requestBodycustomerData = null, WorkflowValue<bool> requestBodyadMessage = null, WorkflowValue<string> requestBodydlrUrl = null, WorkflowValue<string> requestBodyrequestId = null)
        {
            WorkflowValue.Validate(parentMessageId, nameof(parentMessageId), required: true);
            WorkflowValue.Validate(customerId, nameof(customerId), required: true);
            WorkflowValue.Validate(serviceId, nameof(serviceId), required: true);
            WorkflowValue.Validate(requestBodysender, nameof(requestBodysender), required: true);
            WorkflowValue.Validate(requestBodycontent, nameof(requestBodycontent), required: true);
            WorkflowValue.Validate(requestBodyprotocol, nameof(requestBodyprotocol), required: true);
            WorkflowValue.Validate(requestBodyrecipients, nameof(requestBodyrecipients), required: true);
            WorkflowValue.Validate(requestBodysendDateTime, nameof(requestBodysendDateTime), required: false);
            WorkflowValue.Validate(requestBodyattachmentUri, nameof(requestBodyattachmentUri), required: false);
            WorkflowValue.Validate(requestBodycustomerData, nameof(requestBodycustomerData), required: false);
            WorkflowValue.Validate(requestBodyadMessage, nameof(requestBodyadMessage), required: false);
            WorkflowValue.Validate(requestBodydlrUrl, nameof(requestBodydlrUrl), required: false);
            WorkflowValue.Validate(requestBodyrequestId, nameof(requestBodyrequestId), required: false);
            return new DeferredBodyAction<SendReplyMessageResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/messages/reply/{0}", ExpressionConverter.ConvertWithUrlEncoding(parentMessageId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Customer-Id"] = ExpressionConverter.Convert(customerId);
                callPayload.Headers["Service-Id"] = ExpressionConverter.Convert(serviceId);
                var requestBody = new JObject();
                var requestBodypropCount = 0;
                requestBodypropCount++;
                requestBody["Sender"] = ExpressionConverter.ConvertO(requestBodysender);
                requestBodypropCount++;
                requestBody["Content"] = ExpressionConverter.ConvertO(requestBodycontent);
                requestBodypropCount++;
                requestBody["Protocol"] = ExpressionConverter.ConvertO(requestBodyprotocol);
                if (requestBodysendDateTime != null)
                {
                    requestBody["SendDateTime"] = ExpressionConverter.ConvertO(requestBodysendDateTime);
                    requestBodypropCount++;
                }

                requestBodypropCount++;
                requestBody["Recipients"] = ExpressionConverter.ConvertO(requestBodyrecipients);
                if (requestBodyattachmentUri != null)
                {
                    requestBody["AttachmentUri"] = ExpressionConverter.ConvertO(requestBodyattachmentUri);
                    requestBodypropCount++;
                }

                if (requestBodycustomerData != null)
                {
                    requestBody["CustomerData"] = ExpressionConverter.ConvertO(requestBodycustomerData);
                    requestBodypropCount++;
                }

                if (requestBodyadMessage != null)
                {
                    requestBody["AdMessage"] = ExpressionConverter.ConvertO(requestBodyadMessage);
                    requestBodypropCount++;
                }

                if (requestBodydlrUrl != null)
                {
                    requestBody["DlrUrl"] = ExpressionConverter.ConvertO(requestBodydlrUrl);
                    requestBodypropCount++;
                }

                if (requestBodyrequestId != null)
                {
                    requestBody["RequestId"] = ExpressionConverter.ConvertO(requestBodyrequestId);
                    requestBodypropCount++;
                }

                if (requestBodypropCount > 0)
                {
                    callPayload.Body = requestBody;
                }

                return new ApiConnectionAction<SendReplyMessageResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smartdialog")]
        [WorkflowExpressionFactory(nameof(__BuildSendDiscussionReplyMessage))]
        public IBodyWorkflowAction<SendDiscussionReplyMessageResponse> SendDiscussionReplyMessage([WorkflowExpression] Func<string> customerId, [WorkflowExpression] Func<string> requestBodythreadId, [WorkflowExpression] Func<string> requestBodycontent, [WorkflowExpression] Func<string> requestBodycustomerData = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SendDiscussionReplyMessageResponse> __BuildSendDiscussionReplyMessage(WorkflowValue<string> customerId, WorkflowValue<string> requestBodythreadId, WorkflowValue<string> requestBodycontent, WorkflowValue<string> requestBodycustomerData = null)
        {
            WorkflowValue.Validate(customerId, nameof(customerId), required: true);
            WorkflowValue.Validate(requestBodythreadId, nameof(requestBodythreadId), required: true);
            WorkflowValue.Validate(requestBodycontent, nameof(requestBodycontent), required: true);
            WorkflowValue.Validate(requestBodycustomerData, nameof(requestBodycustomerData), required: false);
            return new DeferredBodyAction<SendDiscussionReplyMessageResponse>(() =>
            {
                var apiCallPath = "/messages/discussion/reply";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["CustomerId"] = ExpressionConverter.Convert(customerId);
                var requestBody = new JObject();
                var requestBodypropCount = 0;
                requestBodypropCount++;
                requestBody["ThreadId"] = ExpressionConverter.ConvertO(requestBodythreadId);
                requestBodypropCount++;
                requestBody["Content"] = ExpressionConverter.ConvertO(requestBodycontent);
                if (requestBodycustomerData != null)
                {
                    requestBody["CustomerData"] = ExpressionConverter.ConvertO(requestBodycustomerData);
                    requestBodypropCount++;
                }

                if (requestBodypropCount > 0)
                {
                    callPayload.Body = requestBody;
                }

                return new ApiConnectionAction<SendDiscussionReplyMessageResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smartdialog")]
        [WorkflowExpressionFactory(nameof(__BuildCreateWhatsappTemplate))]
        public IWorkflowAction CreateWhatsappTemplate([WorkflowExpression] Func<string> customerId, [WorkflowExpression] Func<string> identityNumber, [WorkflowExpression] Func<string> requestBodydisplayName, [WorkflowExpression] Func<string> requestBodyrawContent, [WorkflowExpression] Func<string> requestBodycategory, [WorkflowExpression] Func<string> requestBodylanguage, [WorkflowExpression] Func<requestBodybuttonsInputItem[]> requestBodybuttons = null, [WorkflowExpression] Func<string> requestBodyattachmentUrl = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildCreateWhatsappTemplate(WorkflowValue<string> customerId, WorkflowValue<string> identityNumber, WorkflowValue<string> requestBodydisplayName, WorkflowValue<string> requestBodyrawContent, WorkflowValue<string> requestBodycategory, WorkflowValue<string> requestBodylanguage, WorkflowValue<requestBodybuttonsInputItem[]> requestBodybuttons = null, WorkflowValue<string> requestBodyattachmentUrl = null)
        {
            WorkflowValue.Validate(customerId, nameof(customerId), required: true);
            WorkflowValue.Validate(identityNumber, nameof(identityNumber), required: true);
            WorkflowValue.Validate(requestBodydisplayName, nameof(requestBodydisplayName), required: true);
            WorkflowValue.Validate(requestBodyrawContent, nameof(requestBodyrawContent), required: true);
            WorkflowValue.Validate(requestBodycategory, nameof(requestBodycategory), required: true);
            WorkflowValue.Validate(requestBodylanguage, nameof(requestBodylanguage), required: true);
            WorkflowValue.Validate(requestBodybuttons, nameof(requestBodybuttons), required: false);
            WorkflowValue.Validate(requestBodyattachmentUrl, nameof(requestBodyattachmentUrl), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/whatsapp/templates/{0}/{1}", ExpressionConverter.ConvertWithUrlEncoding(customerId, 1), ExpressionConverter.ConvertWithUrlEncoding(identityNumber, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var requestBody = new JObject();
                var requestBodypropCount = 0;
                requestBodypropCount++;
                requestBody["DisplayName"] = ExpressionConverter.ConvertO(requestBodydisplayName);
                requestBodypropCount++;
                requestBody["RawContent"] = ExpressionConverter.ConvertO(requestBodyrawContent);
                requestBodypropCount++;
                requestBody["Category"] = ExpressionConverter.ConvertO(requestBodycategory);
                requestBodypropCount++;
                requestBody["Language"] = ExpressionConverter.ConvertO(requestBodylanguage);
                if (requestBodybuttons != null)
                {
                    requestBody["Buttons"] = ExpressionConverter.ConvertO(requestBodybuttons);
                    requestBodypropCount++;
                }

                if (requestBodyattachmentUrl != null)
                {
                    requestBody["AttachmentUrl"] = ExpressionConverter.ConvertO(requestBodyattachmentUrl);
                    requestBodypropCount++;
                }

                if (requestBodypropCount > 0)
                {
                    callPayload.Body = requestBody;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smartdialog")]
        [WorkflowExpressionFactory(nameof(__BuildSendWhatsappTemplateMessage))]
        public IBodyWorkflowAction<SendWhatsappTemplateMessageResponse> SendWhatsappTemplateMessage([WorkflowExpression] Func<string> customerId, [WorkflowExpression] Func<string> serviceId, [WorkflowExpression] Func<string> requestBodytemplateName, [WorkflowExpression] Func<requestBodyrecipientsInputItem2[]> requestBodyrecipients, [WorkflowExpression] Func<string[]> requestBodybodyParameters = null, [WorkflowExpression] Func<string[]> requestBodyheaderParameters = null, [WorkflowExpression] Func<requestBodybuttonsInputItem2[]> requestBodybuttons = null, [WorkflowExpression] Func<string> requestBodysendDateTime = null, [WorkflowExpression] Func<string> requestBodyattachmentUri = null, [WorkflowExpression] Func<bool> requestBodyuseSmsFallback = null, [WorkflowExpression] Func<string> requestBodydlrUrl = null, [WorkflowExpression] Func<string> requestBodycustomerData = null, [WorkflowExpression] Func<string> requestBodyrequestId = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SendWhatsappTemplateMessageResponse> __BuildSendWhatsappTemplateMessage(WorkflowValue<string> customerId, WorkflowValue<string> serviceId, WorkflowValue<string> requestBodytemplateName, WorkflowValue<requestBodyrecipientsInputItem2[]> requestBodyrecipients, WorkflowValue<string[]> requestBodybodyParameters = null, WorkflowValue<string[]> requestBodyheaderParameters = null, WorkflowValue<requestBodybuttonsInputItem2[]> requestBodybuttons = null, WorkflowValue<string> requestBodysendDateTime = null, WorkflowValue<string> requestBodyattachmentUri = null, WorkflowValue<bool> requestBodyuseSmsFallback = null, WorkflowValue<string> requestBodydlrUrl = null, WorkflowValue<string> requestBodycustomerData = null, WorkflowValue<string> requestBodyrequestId = null)
        {
            WorkflowValue.Validate(customerId, nameof(customerId), required: true);
            WorkflowValue.Validate(serviceId, nameof(serviceId), required: true);
            WorkflowValue.Validate(requestBodytemplateName, nameof(requestBodytemplateName), required: true);
            WorkflowValue.Validate(requestBodyrecipients, nameof(requestBodyrecipients), required: true);
            WorkflowValue.Validate(requestBodybodyParameters, nameof(requestBodybodyParameters), required: false);
            WorkflowValue.Validate(requestBodyheaderParameters, nameof(requestBodyheaderParameters), required: false);
            WorkflowValue.Validate(requestBodybuttons, nameof(requestBodybuttons), required: false);
            WorkflowValue.Validate(requestBodysendDateTime, nameof(requestBodysendDateTime), required: false);
            WorkflowValue.Validate(requestBodyattachmentUri, nameof(requestBodyattachmentUri), required: false);
            WorkflowValue.Validate(requestBodyuseSmsFallback, nameof(requestBodyuseSmsFallback), required: false);
            WorkflowValue.Validate(requestBodydlrUrl, nameof(requestBodydlrUrl), required: false);
            WorkflowValue.Validate(requestBodycustomerData, nameof(requestBodycustomerData), required: false);
            WorkflowValue.Validate(requestBodyrequestId, nameof(requestBodyrequestId), required: false);
            return new DeferredBodyAction<SendWhatsappTemplateMessageResponse>(() =>
            {
                var apiCallPath = "/messages/templates/whatsapp";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Customer-Id"] = ExpressionConverter.Convert(customerId);
                callPayload.Headers["Service-Id"] = ExpressionConverter.Convert(serviceId);
                var requestBody = new JObject();
                var requestBodypropCount = 0;
                requestBodypropCount++;
                requestBody["TemplateName"] = ExpressionConverter.ConvertO(requestBodytemplateName);
                requestBodypropCount++;
                requestBody["Recipients"] = ExpressionConverter.ConvertO(requestBodyrecipients);
                if (requestBodybodyParameters != null)
                {
                    requestBody["BodyParameters"] = ExpressionConverter.ConvertO(requestBodybodyParameters);
                    requestBodypropCount++;
                }

                if (requestBodyheaderParameters != null)
                {
                    requestBody["HeaderParameters"] = ExpressionConverter.ConvertO(requestBodyheaderParameters);
                    requestBodypropCount++;
                }

                if (requestBodybuttons != null)
                {
                    requestBody["Buttons"] = ExpressionConverter.ConvertO(requestBodybuttons);
                    requestBodypropCount++;
                }

                if (requestBodysendDateTime != null)
                {
                    requestBody["SendDateTime"] = ExpressionConverter.ConvertO(requestBodysendDateTime);
                    requestBodypropCount++;
                }

                if (requestBodyattachmentUri != null)
                {
                    requestBody["AttachmentUri"] = ExpressionConverter.ConvertO(requestBodyattachmentUri);
                    requestBodypropCount++;
                }

                if (requestBodyuseSmsFallback != null)
                {
                    requestBody["UseSmsFallback"] = ExpressionConverter.ConvertO(requestBodyuseSmsFallback);
                    requestBodypropCount++;
                }

                if (requestBodydlrUrl != null)
                {
                    requestBody["DlrUrl"] = ExpressionConverter.ConvertO(requestBodydlrUrl);
                    requestBodypropCount++;
                }

                if (requestBodycustomerData != null)
                {
                    requestBody["CustomerData"] = ExpressionConverter.ConvertO(requestBodycustomerData);
                    requestBodypropCount++;
                }

                if (requestBodyrequestId != null)
                {
                    requestBody["RequestId"] = ExpressionConverter.ConvertO(requestBodyrequestId);
                    requestBodypropCount++;
                }

                if (requestBodypropCount > 0)
                {
                    callPayload.Body = requestBody;
                }

                return new ApiConnectionAction<SendWhatsappTemplateMessageResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smartdialog")]
        [WorkflowExpressionFactory(nameof(__BuildGetGroupContact))]
        public IBodyWorkflowAction<GetGroupContactResponse> GetGroupContact([WorkflowExpression] Func<string> customer, [WorkflowExpression] Func<string> groupService, [WorkflowExpression] Func<string> phone, [WorkflowExpression] Func<string> region = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetGroupContactResponse> __BuildGetGroupContact(WorkflowValue<string> customer, WorkflowValue<string> groupService, WorkflowValue<string> phone, WorkflowValue<string> region = null)
        {
            WorkflowValue.Validate(customer, nameof(customer), required: true);
            WorkflowValue.Validate(groupService, nameof(groupService), required: true);
            WorkflowValue.Validate(phone, nameof(phone), required: true);
            WorkflowValue.Validate(region, nameof(region), required: false);
            return new DeferredBodyAction<GetGroupContactResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/groupcontact/{0}/{1}/{2}", ExpressionConverter.ConvertWithUrlEncoding(customer, 1), ExpressionConverter.ConvertWithUrlEncoding(groupService, 1), ExpressionConverter.ConvertWithUrlEncoding(phone, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (region != null)
                    callPayload.Queries["Region"] = ExpressionConverter.Convert(region);
                return new ApiConnectionAction<GetGroupContactResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smartdialog")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteGroupContact))]
        public IBodyWorkflowAction<bool> DeleteGroupContact([WorkflowExpression] Func<string> customer, [WorkflowExpression] Func<string> groupService, [WorkflowExpression] Func<string> phone)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<bool> __BuildDeleteGroupContact(WorkflowValue<string> customer, WorkflowValue<string> groupService, WorkflowValue<string> phone)
        {
            WorkflowValue.Validate(customer, nameof(customer), required: true);
            WorkflowValue.Validate(groupService, nameof(groupService), required: true);
            WorkflowValue.Validate(phone, nameof(phone), required: true);
            return new DeferredBodyAction<bool>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/groupcontact/{0}/{1}/{2}", ExpressionConverter.ConvertWithUrlEncoding(customer, 1), ExpressionConverter.ConvertWithUrlEncoding(groupService, 1), ExpressionConverter.ConvertWithUrlEncoding(phone, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<bool>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smartdialog")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateGroupContact))]
        public IBodyWorkflowAction<bool> UpdateGroupContact([WorkflowExpression] Func<string> customer, [WorkflowExpression] Func<string> groupService, [WorkflowExpression] Func<string> phone, [WorkflowExpression] Func<bool> requestBodyactive = null, [WorkflowExpression] Func<string> requestBodyemail = null, [WorkflowExpression] Func<string> requestBodyfirstName = null, [WorkflowExpression] Func<string> requestBodylastName = null, [WorkflowExpression] Func<requestBodygenderInput> requestBodygender = null, [WorkflowExpression] Func<int> requestBodybirthYear = null, [WorkflowExpression] Func<string> requestBodystreetAddress = null, [WorkflowExpression] Func<string> requestBodyzipCode = null, [WorkflowExpression] Func<string> requestBodycity = null, [WorkflowExpression] Func<string> requestBodycountryCode = null, [WorkflowExpression] Func<requestBodycustomContactPropertiesInputItem[]> requestBodycustomContactProperties = null, [WorkflowExpression] Func<string[]> requestBodyphoneNumberRegions = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<bool> __BuildUpdateGroupContact(WorkflowValue<string> customer, WorkflowValue<string> groupService, WorkflowValue<string> phone, WorkflowValue<bool> requestBodyactive = null, WorkflowValue<string> requestBodyemail = null, WorkflowValue<string> requestBodyfirstName = null, WorkflowValue<string> requestBodylastName = null, WorkflowValue<requestBodygenderInput> requestBodygender = null, WorkflowValue<int> requestBodybirthYear = null, WorkflowValue<string> requestBodystreetAddress = null, WorkflowValue<string> requestBodyzipCode = null, WorkflowValue<string> requestBodycity = null, WorkflowValue<string> requestBodycountryCode = null, WorkflowValue<requestBodycustomContactPropertiesInputItem[]> requestBodycustomContactProperties = null, WorkflowValue<string[]> requestBodyphoneNumberRegions = null)
        {
            WorkflowValue.Validate(customer, nameof(customer), required: true);
            WorkflowValue.Validate(groupService, nameof(groupService), required: true);
            WorkflowValue.Validate(phone, nameof(phone), required: true);
            WorkflowValue.Validate(requestBodyactive, nameof(requestBodyactive), required: false);
            WorkflowValue.Validate(requestBodyemail, nameof(requestBodyemail), required: false);
            WorkflowValue.Validate(requestBodyfirstName, nameof(requestBodyfirstName), required: false);
            WorkflowValue.Validate(requestBodylastName, nameof(requestBodylastName), required: false);
            WorkflowValue.Validate(requestBodygender, nameof(requestBodygender), required: false);
            WorkflowValue.Validate(requestBodybirthYear, nameof(requestBodybirthYear), required: false);
            WorkflowValue.Validate(requestBodystreetAddress, nameof(requestBodystreetAddress), required: false);
            WorkflowValue.Validate(requestBodyzipCode, nameof(requestBodyzipCode), required: false);
            WorkflowValue.Validate(requestBodycity, nameof(requestBodycity), required: false);
            WorkflowValue.Validate(requestBodycountryCode, nameof(requestBodycountryCode), required: false);
            WorkflowValue.Validate(requestBodycustomContactProperties, nameof(requestBodycustomContactProperties), required: false);
            WorkflowValue.Validate(requestBodyphoneNumberRegions, nameof(requestBodyphoneNumberRegions), required: false);
            return new DeferredBodyAction<bool>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/groupcontact/{0}/{1}/{2}", ExpressionConverter.ConvertWithUrlEncoding(customer, 1), ExpressionConverter.ConvertWithUrlEncoding(groupService, 1), ExpressionConverter.ConvertWithUrlEncoding(phone, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var requestBody = new JObject();
                var requestBodypropCount = 0;
                if (requestBodyactive != null)
                {
                    if (requestBodyactive != null)
                    {
                        requestBody["active"] = ExpressionConverter.ConvertO(requestBodyactive);
                        requestBodypropCount++;
                    }

                    requestBodypropCount++;
                }
                else
                {
                    requestBody["active"] = true;
                    requestBodypropCount++;
                }

                if (requestBodyemail != null)
                {
                    requestBody["email"] = ExpressionConverter.ConvertO(requestBodyemail);
                    requestBodypropCount++;
                }

                if (requestBodyfirstName != null)
                {
                    requestBody["firstName"] = ExpressionConverter.ConvertO(requestBodyfirstName);
                    requestBodypropCount++;
                }

                if (requestBodylastName != null)
                {
                    requestBody["lastName"] = ExpressionConverter.ConvertO(requestBodylastName);
                    requestBodypropCount++;
                }

                if (requestBodygender != null)
                {
                    requestBody["gender"] = ExpressionConverter.ConvertO(requestBodygender);
                    requestBodypropCount++;
                }

                if (requestBodybirthYear != null)
                {
                    requestBody["birthYear"] = ExpressionConverter.ConvertO(requestBodybirthYear);
                    requestBodypropCount++;
                }

                if (requestBodystreetAddress != null)
                {
                    requestBody["streetAddress"] = ExpressionConverter.ConvertO(requestBodystreetAddress);
                    requestBodypropCount++;
                }

                if (requestBodyzipCode != null)
                {
                    requestBody["zipCode"] = ExpressionConverter.ConvertO(requestBodyzipCode);
                    requestBodypropCount++;
                }

                if (requestBodycity != null)
                {
                    requestBody["city"] = ExpressionConverter.ConvertO(requestBodycity);
                    requestBodypropCount++;
                }

                if (requestBodycountryCode != null)
                {
                    requestBody["countryCode"] = ExpressionConverter.ConvertO(requestBodycountryCode);
                    requestBodypropCount++;
                }

                if (requestBodycustomContactProperties != null)
                {
                    requestBody["customContactProperties"] = ExpressionConverter.ConvertO(requestBodycustomContactProperties);
                    requestBodypropCount++;
                }

                if (requestBodyphoneNumberRegions != null)
                {
                    requestBody["phoneNumberRegions"] = ExpressionConverter.ConvertO(requestBodyphoneNumberRegions);
                    requestBodypropCount++;
                }

                if (requestBodypropCount > 0)
                {
                    callPayload.Body = requestBody;
                }

                return new ApiConnectionAction<bool>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smartdialog")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteAllGroupContacts))]
        public IBodyWorkflowAction<bool> DeleteAllGroupContacts([WorkflowExpression] Func<string> customer, [WorkflowExpression] Func<string> groupService)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<bool> __BuildDeleteAllGroupContacts(WorkflowValue<string> customer, WorkflowValue<string> groupService)
        {
            WorkflowValue.Validate(customer, nameof(customer), required: true);
            WorkflowValue.Validate(groupService, nameof(groupService), required: true);
            return new DeferredBodyAction<bool>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/groupcontact/{0}/{1}", ExpressionConverter.ConvertWithUrlEncoding(customer, 1), ExpressionConverter.ConvertWithUrlEncoding(groupService, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<bool>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smartdialog")]
        [WorkflowExpressionFactory(nameof(__BuildCreateGroupContact))]
        public IBodyWorkflowAction<string> CreateGroupContact([WorkflowExpression] Func<string> customer, [WorkflowExpression] Func<string> groupService, [WorkflowExpression] Func<string> requestBodyphone, [WorkflowExpression] Func<bool> requestBodyactive = null, [WorkflowExpression] Func<string> requestBodyemail = null, [WorkflowExpression] Func<string> requestBodyfirstName = null, [WorkflowExpression] Func<string> requestBodylastName = null, [WorkflowExpression] Func<requestBodygenderInput> requestBodygender = null, [WorkflowExpression] Func<int> requestBodybirthYear = null, [WorkflowExpression] Func<string> requestBodystreetAddress = null, [WorkflowExpression] Func<string> requestBodyzipCode = null, [WorkflowExpression] Func<string> requestBodycity = null, [WorkflowExpression] Func<string> requestBodycountryCode = null, [WorkflowExpression] Func<requestBodycustomContactPropertiesInputItem[]> requestBodycustomContactProperties = null, [WorkflowExpression] Func<string[]> requestBodyphoneNumberRegions = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildCreateGroupContact(WorkflowValue<string> customer, WorkflowValue<string> groupService, WorkflowValue<string> requestBodyphone, WorkflowValue<bool> requestBodyactive = null, WorkflowValue<string> requestBodyemail = null, WorkflowValue<string> requestBodyfirstName = null, WorkflowValue<string> requestBodylastName = null, WorkflowValue<requestBodygenderInput> requestBodygender = null, WorkflowValue<int> requestBodybirthYear = null, WorkflowValue<string> requestBodystreetAddress = null, WorkflowValue<string> requestBodyzipCode = null, WorkflowValue<string> requestBodycity = null, WorkflowValue<string> requestBodycountryCode = null, WorkflowValue<requestBodycustomContactPropertiesInputItem[]> requestBodycustomContactProperties = null, WorkflowValue<string[]> requestBodyphoneNumberRegions = null)
        {
            WorkflowValue.Validate(customer, nameof(customer), required: true);
            WorkflowValue.Validate(groupService, nameof(groupService), required: true);
            WorkflowValue.Validate(requestBodyphone, nameof(requestBodyphone), required: true);
            WorkflowValue.Validate(requestBodyactive, nameof(requestBodyactive), required: false);
            WorkflowValue.Validate(requestBodyemail, nameof(requestBodyemail), required: false);
            WorkflowValue.Validate(requestBodyfirstName, nameof(requestBodyfirstName), required: false);
            WorkflowValue.Validate(requestBodylastName, nameof(requestBodylastName), required: false);
            WorkflowValue.Validate(requestBodygender, nameof(requestBodygender), required: false);
            WorkflowValue.Validate(requestBodybirthYear, nameof(requestBodybirthYear), required: false);
            WorkflowValue.Validate(requestBodystreetAddress, nameof(requestBodystreetAddress), required: false);
            WorkflowValue.Validate(requestBodyzipCode, nameof(requestBodyzipCode), required: false);
            WorkflowValue.Validate(requestBodycity, nameof(requestBodycity), required: false);
            WorkflowValue.Validate(requestBodycountryCode, nameof(requestBodycountryCode), required: false);
            WorkflowValue.Validate(requestBodycustomContactProperties, nameof(requestBodycustomContactProperties), required: false);
            WorkflowValue.Validate(requestBodyphoneNumberRegions, nameof(requestBodyphoneNumberRegions), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/groupcontact/{0}/{1}", ExpressionConverter.ConvertWithUrlEncoding(customer, 1), ExpressionConverter.ConvertWithUrlEncoding(groupService, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var requestBody = new JObject();
                var requestBodypropCount = 0;
                if (requestBodyactive != null)
                {
                    if (requestBodyactive != null)
                    {
                        requestBody["active"] = ExpressionConverter.ConvertO(requestBodyactive);
                        requestBodypropCount++;
                    }

                    requestBodypropCount++;
                }
                else
                {
                    requestBody["active"] = true;
                    requestBodypropCount++;
                }

                requestBodypropCount++;
                requestBody["phone"] = ExpressionConverter.ConvertO(requestBodyphone);
                if (requestBodyemail != null)
                {
                    requestBody["email"] = ExpressionConverter.ConvertO(requestBodyemail);
                    requestBodypropCount++;
                }

                if (requestBodyfirstName != null)
                {
                    requestBody["firstName"] = ExpressionConverter.ConvertO(requestBodyfirstName);
                    requestBodypropCount++;
                }

                if (requestBodylastName != null)
                {
                    requestBody["lastName"] = ExpressionConverter.ConvertO(requestBodylastName);
                    requestBodypropCount++;
                }

                if (requestBodygender != null)
                {
                    requestBody["gender"] = ExpressionConverter.ConvertO(requestBodygender);
                    requestBodypropCount++;
                }

                if (requestBodybirthYear != null)
                {
                    requestBody["birthYear"] = ExpressionConverter.ConvertO(requestBodybirthYear);
                    requestBodypropCount++;
                }

                if (requestBodystreetAddress != null)
                {
                    requestBody["streetAddress"] = ExpressionConverter.ConvertO(requestBodystreetAddress);
                    requestBodypropCount++;
                }

                if (requestBodyzipCode != null)
                {
                    requestBody["zipCode"] = ExpressionConverter.ConvertO(requestBodyzipCode);
                    requestBodypropCount++;
                }

                if (requestBodycity != null)
                {
                    requestBody["city"] = ExpressionConverter.ConvertO(requestBodycity);
                    requestBodypropCount++;
                }

                if (requestBodycountryCode != null)
                {
                    requestBody["countryCode"] = ExpressionConverter.ConvertO(requestBodycountryCode);
                    requestBodypropCount++;
                }

                if (requestBodycustomContactProperties != null)
                {
                    requestBody["customContactProperties"] = ExpressionConverter.ConvertO(requestBodycustomContactProperties);
                    requestBodypropCount++;
                }

                if (requestBodyphoneNumberRegions != null)
                {
                    requestBody["phoneNumberRegions"] = ExpressionConverter.ConvertO(requestBodyphoneNumberRegions);
                    requestBodypropCount++;
                }

                if (requestBodypropCount > 0)
                {
                    callPayload.Body = requestBody;
                }

                return new ApiConnectionAction<string>(callPayload);
            });
        }
    }

    public class SmartdialogTriggers([ConnectionName] string connectionId)
    {
        [WorkflowExpressionFactory(nameof(__BuildNewMessage))]
        public IBodyWorkflowTrigger<NewMessageResponse> NewMessage([WorkflowExpression] Func<string> customer, [WorkflowExpression] Func<string> service, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<NewMessageResponse> __BuildNewMessage(WorkflowValue<string> customer, WorkflowValue<string> service, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(customer, nameof(customer), required: true);
            WorkflowValue.Validate(service, nameof(service), required: true);
            return new DeferredBodyTrigger<NewMessageResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/service/{0}/pipelines/actions", ExpressionConverter.ConvertWithUrlEncoding(service, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Customer"] = ExpressionConverter.Convert(customer);
                var createWebhookRequestBody = new JObject();
                var createWebhookRequestBodypropCount = 0;
                createWebhookRequestBody["name"] = "PowerAutomate (Auto Created Webhook)";
                createWebhookRequestBodypropCount++;
                createWebhookRequestBody["actionType"] = "HttpRequest";
                createWebhookRequestBodypropCount++;
                createWebhookRequestBody["description"] = "PowerAutomate auto-created webhook. Please don't modify. Will be removed by PowerAutomate , when the Flow/Logic App is disabled or removed";
                createWebhookRequestBodypropCount++;
                var optionsObject = new JObject();
                var optionsObjectpropCount = 0;
                optionsObject["endpointUrl"] = "#{listCallbackUrl()}";
                optionsObjectpropCount++;
                optionsObject["httpVerb"] = "POST";
                optionsObjectpropCount++;
                if (optionsObjectpropCount > 0)
                {
                    createWebhookRequestBody["options"] = optionsObject;
                    createWebhookRequestBodypropCount++;
                }

                if (createWebhookRequestBodypropCount > 0)
                {
                    callPayload.Body = createWebhookRequestBody;
                }

                return new ApiConnectionTrigger<NewMessageResponse>(callPayload, triggerName, recurrence);
            }, triggerName);
        }
    }

    public class SendMessageResponse
    {
        public string MessageId { get; set; }
        public int MessagePartCount { get; set; }
        public SendMessageResponseRecipientsTypeItem[] Recipients { get; set; }
    }

    public class SendMessageResponseRecipientsTypeItem
    {
        public string Address { get; set; }
        public string Id { get; set; }
    }

    public enum requestBodyprotocolInput
    {
        SMS
    }

    public class requestBodyrecipientsInputItem
    {
        public string Address { get; set; }
        public JToken Personalization { get; set; }
    }

    public class SendReplyMessageResponse
    {
        public string MessageId { get; set; }
        public int MessagePartCount { get; set; }
        public SendReplyMessageResponseRecipientsTypeItem[] Recipients { get; set; }
    }

    public class SendReplyMessageResponseRecipientsTypeItem
    {
        public string Address { get; set; }
        public string Id { get; set; }
    }

    public class SendDiscussionReplyMessageResponse
    {
        public string MessageId { get; set; }
        public int MessagePartCount { get; set; }
        public SendDiscussionReplyMessageResponseRecipientsTypeItem[] Recipients { get; set; }
        public string ThreadId { get; set; }
    }

    public class SendDiscussionReplyMessageResponseRecipientsTypeItem
    {
        public string Address { get; set; }
        public string Id { get; set; }
    }

    public class requestBodybuttonsInputItem
    {
        public requestBodybuttonsInputItemTypeType Type { get; set; }
        public string Label { get; set; }
        public string Data { get; set; }
    }

    public enum requestBodybuttonsInputItemTypeType
    {
        Call,
        QuickReply,
        Url
    }

    public class SendWhatsappTemplateMessageResponse
    {
        [JsonProperty("messageId")]
        public string MessageId { get; set; }

        [JsonProperty("messagePartCount")]
        public int MessagePartCount { get; set; }

        [JsonProperty("recipients")]
        public SendWhatsappTemplateMessageResponseRecipientsTypeItem[] Recipients { get; set; }
    }

    public class SendWhatsappTemplateMessageResponseRecipientsTypeItem
    {
        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class requestBodyrecipientsInputItem2
    {
        public string Address { get; set; }
    }

    public class requestBodybuttonsInputItem2
    {
        public requestBodybuttonsInputItemTypeType Type { get; set; }
        public string Data { get; set; }
    }

    public class GetGroupContactResponse
    {
        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("gender")]
        public GetGroupContactResponseGenderType Gender { get; set; }

        [JsonProperty("birthYear")]
        public int BirthYear { get; set; }

        [JsonProperty("streetAddress")]
        public string StreetAddress { get; set; }

        [JsonProperty("zipCode")]
        public string ZipCode { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("countryCode")]
        public string CountryCode { get; set; }

        [JsonProperty("failedMessages")]
        public int FailedMessages { get; set; }

        [JsonProperty("customContactProperties")]
        public GetGroupContactResponseCustomContactPropertiesTypeItem[] CustomContactProperties { get; set; }
    }

    public enum GetGroupContactResponseGenderType
    {
        Male,
        Female,
        Other
    }

    public class GetGroupContactResponseCustomContactPropertiesTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public enum requestBodygenderInput
    {
        Male,
        Female,
        Other
    }

    public class requestBodycustomContactPropertiesInputItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class NewMessageResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Smartdialog;

    public partial class WorkflowManagedActions
    {
        public SmartdialogActions Smartdialog(string connectionId) => new SmartdialogActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public SmartdialogTriggers Smartdialog(string connectionId) => new SmartdialogTriggers(connectionId);
    }
}
