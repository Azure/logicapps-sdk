//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Smartdialog
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class SmartdialogActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smartdialog")]
        public IBodyWorkflowAction<SendMessageResponse> SendMessage(Expression<Func<string>> customerId, Expression<Func<string>> serviceId, Expression<Func<string>> requestBodysender, Expression<Func<string>> requestBodycontent, Expression<Func<requestBodyprotocolInput>> requestBodyprotocol, Expression<Func<requestBodyrecipientsInputItem[]>> requestBodyrecipients, Expression<Func<string>> requestBodysendDateTime = null, Expression<Func<string>> requestBodyattachmentUri = null, Expression<Func<string>> requestBodycustomerData = null, Expression<Func<bool>> requestBodyadMessage = null, Expression<Func<string>> requestBodydlrUrl = null, Expression<Func<string>> requestBodyrequestId = null)
        {
            var __workflow_customerId = customerId == null ? null : WorkflowExpression.Compile(customerId);
            WorkflowExpression.Validate(__workflow_customerId, nameof(customerId), required: true);
            var __workflow_serviceId = serviceId == null ? null : WorkflowExpression.Compile(serviceId);
            WorkflowExpression.Validate(__workflow_serviceId, nameof(serviceId), required: true);
            var __workflow_requestBodysender = requestBodysender == null ? null : WorkflowExpression.Compile(requestBodysender);
            WorkflowExpression.Validate(__workflow_requestBodysender, nameof(requestBodysender), required: true);
            var __workflow_requestBodycontent = requestBodycontent == null ? null : WorkflowExpression.Compile(requestBodycontent);
            WorkflowExpression.Validate(__workflow_requestBodycontent, nameof(requestBodycontent), required: true);
            var __workflow_requestBodyprotocol = requestBodyprotocol == null ? null : WorkflowExpression.Compile(requestBodyprotocol);
            WorkflowExpression.Validate(__workflow_requestBodyprotocol, nameof(requestBodyprotocol), required: true);
            var __workflow_requestBodyrecipients = requestBodyrecipients == null ? null : WorkflowExpression.Compile(requestBodyrecipients);
            WorkflowExpression.Validate(__workflow_requestBodyrecipients, nameof(requestBodyrecipients), required: true);
            var __workflow_requestBodysendDateTime = requestBodysendDateTime == null ? null : WorkflowExpression.Compile(requestBodysendDateTime);
            WorkflowExpression.Validate(__workflow_requestBodysendDateTime, nameof(requestBodysendDateTime), required: false);
            var __workflow_requestBodyattachmentUri = requestBodyattachmentUri == null ? null : WorkflowExpression.Compile(requestBodyattachmentUri);
            WorkflowExpression.Validate(__workflow_requestBodyattachmentUri, nameof(requestBodyattachmentUri), required: false);
            var __workflow_requestBodycustomerData = requestBodycustomerData == null ? null : WorkflowExpression.Compile(requestBodycustomerData);
            WorkflowExpression.Validate(__workflow_requestBodycustomerData, nameof(requestBodycustomerData), required: false);
            var __workflow_requestBodyadMessage = requestBodyadMessage == null ? null : WorkflowExpression.Compile(requestBodyadMessage);
            WorkflowExpression.Validate(__workflow_requestBodyadMessage, nameof(requestBodyadMessage), required: false);
            var __workflow_requestBodydlrUrl = requestBodydlrUrl == null ? null : WorkflowExpression.Compile(requestBodydlrUrl);
            WorkflowExpression.Validate(__workflow_requestBodydlrUrl, nameof(requestBodydlrUrl), required: false);
            var __workflow_requestBodyrequestId = requestBodyrequestId == null ? null : WorkflowExpression.Compile(requestBodyrequestId);
            WorkflowExpression.Validate(__workflow_requestBodyrequestId, nameof(requestBodyrequestId), required: false);
            return new DeferredBodyAction<SendMessageResponse>(() =>
            {
                var apiCallPath = "/messages";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Customer-Id"] = ExpressionConverter.Convert(__workflow_customerId);
                callPayload.Headers["Service-Id"] = ExpressionConverter.Convert(__workflow_serviceId);
                var requestBody = new JObject();
                var requestBodypropCount = 0;
                requestBodypropCount++;
                requestBody["Sender"] = ExpressionConverter.ConvertO(__workflow_requestBodysender);
                requestBodypropCount++;
                requestBody["Content"] = ExpressionConverter.ConvertO(__workflow_requestBodycontent);
                requestBodypropCount++;
                requestBody["Protocol"] = ExpressionConverter.ConvertO(__workflow_requestBodyprotocol);
                if (__workflow_requestBodysendDateTime != null)
                {
                    requestBody["SendDateTime"] = ExpressionConverter.ConvertO(__workflow_requestBodysendDateTime);
                    requestBodypropCount++;
                }

                requestBodypropCount++;
                requestBody["Recipients"] = ExpressionConverter.ConvertO(__workflow_requestBodyrecipients);
                if (__workflow_requestBodyattachmentUri != null)
                {
                    requestBody["AttachmentUri"] = ExpressionConverter.ConvertO(__workflow_requestBodyattachmentUri);
                    requestBodypropCount++;
                }

                if (__workflow_requestBodycustomerData != null)
                {
                    requestBody["CustomerData"] = ExpressionConverter.ConvertO(__workflow_requestBodycustomerData);
                    requestBodypropCount++;
                }

                if (__workflow_requestBodyadMessage != null)
                {
                    requestBody["AdMessage"] = ExpressionConverter.ConvertO(__workflow_requestBodyadMessage);
                    requestBodypropCount++;
                }

                if (__workflow_requestBodydlrUrl != null)
                {
                    requestBody["DlrUrl"] = ExpressionConverter.ConvertO(__workflow_requestBodydlrUrl);
                    requestBodypropCount++;
                }

                if (__workflow_requestBodyrequestId != null)
                {
                    requestBody["RequestId"] = ExpressionConverter.ConvertO(__workflow_requestBodyrequestId);
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
        public IBodyWorkflowAction<SendReplyMessageResponse> SendReplyMessage(Expression<Func<string>> parentMessageId, Expression<Func<string>> customerId, Expression<Func<string>> serviceId, Expression<Func<string>> requestBodysender, Expression<Func<string>> requestBodycontent, Expression<Func<requestBodyprotocolInput>> requestBodyprotocol, Expression<Func<requestBodyrecipientsInputItem[]>> requestBodyrecipients, Expression<Func<string>> requestBodysendDateTime = null, Expression<Func<string>> requestBodyattachmentUri = null, Expression<Func<string>> requestBodycustomerData = null, Expression<Func<bool>> requestBodyadMessage = null, Expression<Func<string>> requestBodydlrUrl = null, Expression<Func<string>> requestBodyrequestId = null)
        {
            var __workflow_parentMessageId = parentMessageId == null ? null : WorkflowExpression.Compile(parentMessageId);
            WorkflowExpression.Validate(__workflow_parentMessageId, nameof(parentMessageId), required: true);
            var __workflow_customerId = customerId == null ? null : WorkflowExpression.Compile(customerId);
            WorkflowExpression.Validate(__workflow_customerId, nameof(customerId), required: true);
            var __workflow_serviceId = serviceId == null ? null : WorkflowExpression.Compile(serviceId);
            WorkflowExpression.Validate(__workflow_serviceId, nameof(serviceId), required: true);
            var __workflow_requestBodysender = requestBodysender == null ? null : WorkflowExpression.Compile(requestBodysender);
            WorkflowExpression.Validate(__workflow_requestBodysender, nameof(requestBodysender), required: true);
            var __workflow_requestBodycontent = requestBodycontent == null ? null : WorkflowExpression.Compile(requestBodycontent);
            WorkflowExpression.Validate(__workflow_requestBodycontent, nameof(requestBodycontent), required: true);
            var __workflow_requestBodyprotocol = requestBodyprotocol == null ? null : WorkflowExpression.Compile(requestBodyprotocol);
            WorkflowExpression.Validate(__workflow_requestBodyprotocol, nameof(requestBodyprotocol), required: true);
            var __workflow_requestBodyrecipients = requestBodyrecipients == null ? null : WorkflowExpression.Compile(requestBodyrecipients);
            WorkflowExpression.Validate(__workflow_requestBodyrecipients, nameof(requestBodyrecipients), required: true);
            var __workflow_requestBodysendDateTime = requestBodysendDateTime == null ? null : WorkflowExpression.Compile(requestBodysendDateTime);
            WorkflowExpression.Validate(__workflow_requestBodysendDateTime, nameof(requestBodysendDateTime), required: false);
            var __workflow_requestBodyattachmentUri = requestBodyattachmentUri == null ? null : WorkflowExpression.Compile(requestBodyattachmentUri);
            WorkflowExpression.Validate(__workflow_requestBodyattachmentUri, nameof(requestBodyattachmentUri), required: false);
            var __workflow_requestBodycustomerData = requestBodycustomerData == null ? null : WorkflowExpression.Compile(requestBodycustomerData);
            WorkflowExpression.Validate(__workflow_requestBodycustomerData, nameof(requestBodycustomerData), required: false);
            var __workflow_requestBodyadMessage = requestBodyadMessage == null ? null : WorkflowExpression.Compile(requestBodyadMessage);
            WorkflowExpression.Validate(__workflow_requestBodyadMessage, nameof(requestBodyadMessage), required: false);
            var __workflow_requestBodydlrUrl = requestBodydlrUrl == null ? null : WorkflowExpression.Compile(requestBodydlrUrl);
            WorkflowExpression.Validate(__workflow_requestBodydlrUrl, nameof(requestBodydlrUrl), required: false);
            var __workflow_requestBodyrequestId = requestBodyrequestId == null ? null : WorkflowExpression.Compile(requestBodyrequestId);
            WorkflowExpression.Validate(__workflow_requestBodyrequestId, nameof(requestBodyrequestId), required: false);
            return new DeferredBodyAction<SendReplyMessageResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/messages/reply/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_parentMessageId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Customer-Id"] = ExpressionConverter.Convert(__workflow_customerId);
                callPayload.Headers["Service-Id"] = ExpressionConverter.Convert(__workflow_serviceId);
                var requestBody = new JObject();
                var requestBodypropCount = 0;
                requestBodypropCount++;
                requestBody["Sender"] = ExpressionConverter.ConvertO(__workflow_requestBodysender);
                requestBodypropCount++;
                requestBody["Content"] = ExpressionConverter.ConvertO(__workflow_requestBodycontent);
                requestBodypropCount++;
                requestBody["Protocol"] = ExpressionConverter.ConvertO(__workflow_requestBodyprotocol);
                if (__workflow_requestBodysendDateTime != null)
                {
                    requestBody["SendDateTime"] = ExpressionConverter.ConvertO(__workflow_requestBodysendDateTime);
                    requestBodypropCount++;
                }

                requestBodypropCount++;
                requestBody["Recipients"] = ExpressionConverter.ConvertO(__workflow_requestBodyrecipients);
                if (__workflow_requestBodyattachmentUri != null)
                {
                    requestBody["AttachmentUri"] = ExpressionConverter.ConvertO(__workflow_requestBodyattachmentUri);
                    requestBodypropCount++;
                }

                if (__workflow_requestBodycustomerData != null)
                {
                    requestBody["CustomerData"] = ExpressionConverter.ConvertO(__workflow_requestBodycustomerData);
                    requestBodypropCount++;
                }

                if (__workflow_requestBodyadMessage != null)
                {
                    requestBody["AdMessage"] = ExpressionConverter.ConvertO(__workflow_requestBodyadMessage);
                    requestBodypropCount++;
                }

                if (__workflow_requestBodydlrUrl != null)
                {
                    requestBody["DlrUrl"] = ExpressionConverter.ConvertO(__workflow_requestBodydlrUrl);
                    requestBodypropCount++;
                }

                if (__workflow_requestBodyrequestId != null)
                {
                    requestBody["RequestId"] = ExpressionConverter.ConvertO(__workflow_requestBodyrequestId);
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
        public IBodyWorkflowAction<SendDiscussionReplyMessageResponse> SendDiscussionReplyMessage(Expression<Func<string>> customerId, Expression<Func<string>> requestBodythreadId, Expression<Func<string>> requestBodycontent, Expression<Func<string>> requestBodycustomerData = null)
        {
            var __workflow_customerId = customerId == null ? null : WorkflowExpression.Compile(customerId);
            WorkflowExpression.Validate(__workflow_customerId, nameof(customerId), required: true);
            var __workflow_requestBodythreadId = requestBodythreadId == null ? null : WorkflowExpression.Compile(requestBodythreadId);
            WorkflowExpression.Validate(__workflow_requestBodythreadId, nameof(requestBodythreadId), required: true);
            var __workflow_requestBodycontent = requestBodycontent == null ? null : WorkflowExpression.Compile(requestBodycontent);
            WorkflowExpression.Validate(__workflow_requestBodycontent, nameof(requestBodycontent), required: true);
            var __workflow_requestBodycustomerData = requestBodycustomerData == null ? null : WorkflowExpression.Compile(requestBodycustomerData);
            WorkflowExpression.Validate(__workflow_requestBodycustomerData, nameof(requestBodycustomerData), required: false);
            return new DeferredBodyAction<SendDiscussionReplyMessageResponse>(() =>
            {
                var apiCallPath = "/messages/discussion/reply";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["CustomerId"] = ExpressionConverter.Convert(__workflow_customerId);
                var requestBody = new JObject();
                var requestBodypropCount = 0;
                requestBodypropCount++;
                requestBody["ThreadId"] = ExpressionConverter.ConvertO(__workflow_requestBodythreadId);
                requestBodypropCount++;
                requestBody["Content"] = ExpressionConverter.ConvertO(__workflow_requestBodycontent);
                if (__workflow_requestBodycustomerData != null)
                {
                    requestBody["CustomerData"] = ExpressionConverter.ConvertO(__workflow_requestBodycustomerData);
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
        public IWorkflowAction CreateWhatsappTemplate(Expression<Func<string>> customerId, Expression<Func<string>> identityNumber, Expression<Func<string>> requestBodydisplayName, Expression<Func<string>> requestBodyrawContent, Expression<Func<string>> requestBodycategory, Expression<Func<string>> requestBodylanguage, Expression<Func<requestBodybuttonsInputItem[]>> requestBodybuttons = null, Expression<Func<string>> requestBodyattachmentUrl = null)
        {
            var __workflow_customerId = customerId == null ? null : WorkflowExpression.Compile(customerId);
            WorkflowExpression.Validate(__workflow_customerId, nameof(customerId), required: true);
            var __workflow_identityNumber = identityNumber == null ? null : WorkflowExpression.Compile(identityNumber);
            WorkflowExpression.Validate(__workflow_identityNumber, nameof(identityNumber), required: true);
            var __workflow_requestBodydisplayName = requestBodydisplayName == null ? null : WorkflowExpression.Compile(requestBodydisplayName);
            WorkflowExpression.Validate(__workflow_requestBodydisplayName, nameof(requestBodydisplayName), required: true);
            var __workflow_requestBodyrawContent = requestBodyrawContent == null ? null : WorkflowExpression.Compile(requestBodyrawContent);
            WorkflowExpression.Validate(__workflow_requestBodyrawContent, nameof(requestBodyrawContent), required: true);
            var __workflow_requestBodycategory = requestBodycategory == null ? null : WorkflowExpression.Compile(requestBodycategory);
            WorkflowExpression.Validate(__workflow_requestBodycategory, nameof(requestBodycategory), required: true);
            var __workflow_requestBodylanguage = requestBodylanguage == null ? null : WorkflowExpression.Compile(requestBodylanguage);
            WorkflowExpression.Validate(__workflow_requestBodylanguage, nameof(requestBodylanguage), required: true);
            var __workflow_requestBodybuttons = requestBodybuttons == null ? null : WorkflowExpression.Compile(requestBodybuttons);
            WorkflowExpression.Validate(__workflow_requestBodybuttons, nameof(requestBodybuttons), required: false);
            var __workflow_requestBodyattachmentUrl = requestBodyattachmentUrl == null ? null : WorkflowExpression.Compile(requestBodyattachmentUrl);
            WorkflowExpression.Validate(__workflow_requestBodyattachmentUrl, nameof(requestBodyattachmentUrl), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/whatsapp/templates/{0}/{1}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_customerId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_identityNumber, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var requestBody = new JObject();
                var requestBodypropCount = 0;
                requestBodypropCount++;
                requestBody["DisplayName"] = ExpressionConverter.ConvertO(__workflow_requestBodydisplayName);
                requestBodypropCount++;
                requestBody["RawContent"] = ExpressionConverter.ConvertO(__workflow_requestBodyrawContent);
                requestBodypropCount++;
                requestBody["Category"] = ExpressionConverter.ConvertO(__workflow_requestBodycategory);
                requestBodypropCount++;
                requestBody["Language"] = ExpressionConverter.ConvertO(__workflow_requestBodylanguage);
                if (__workflow_requestBodybuttons != null)
                {
                    requestBody["Buttons"] = ExpressionConverter.ConvertO(__workflow_requestBodybuttons);
                    requestBodypropCount++;
                }

                if (__workflow_requestBodyattachmentUrl != null)
                {
                    requestBody["AttachmentUrl"] = ExpressionConverter.ConvertO(__workflow_requestBodyattachmentUrl);
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
        public IBodyWorkflowAction<SendWhatsappTemplateMessageResponse> SendWhatsappTemplateMessage(Expression<Func<string>> customerId, Expression<Func<string>> serviceId, Expression<Func<string>> requestBodytemplateName, Expression<Func<requestBodyrecipientsInputItem2[]>> requestBodyrecipients, Expression<Func<string[]>> requestBodybodyParameters = null, Expression<Func<string[]>> requestBodyheaderParameters = null, Expression<Func<requestBodybuttonsInputItem2[]>> requestBodybuttons = null, Expression<Func<string>> requestBodysendDateTime = null, Expression<Func<string>> requestBodyattachmentUri = null, Expression<Func<bool>> requestBodyuseSmsFallback = null, Expression<Func<string>> requestBodydlrUrl = null, Expression<Func<string>> requestBodycustomerData = null, Expression<Func<string>> requestBodyrequestId = null)
        {
            var __workflow_customerId = customerId == null ? null : WorkflowExpression.Compile(customerId);
            WorkflowExpression.Validate(__workflow_customerId, nameof(customerId), required: true);
            var __workflow_serviceId = serviceId == null ? null : WorkflowExpression.Compile(serviceId);
            WorkflowExpression.Validate(__workflow_serviceId, nameof(serviceId), required: true);
            var __workflow_requestBodytemplateName = requestBodytemplateName == null ? null : WorkflowExpression.Compile(requestBodytemplateName);
            WorkflowExpression.Validate(__workflow_requestBodytemplateName, nameof(requestBodytemplateName), required: true);
            var __workflow_requestBodyrecipients = requestBodyrecipients == null ? null : WorkflowExpression.Compile(requestBodyrecipients);
            WorkflowExpression.Validate(__workflow_requestBodyrecipients, nameof(requestBodyrecipients), required: true);
            var __workflow_requestBodybodyParameters = requestBodybodyParameters == null ? null : WorkflowExpression.Compile(requestBodybodyParameters);
            WorkflowExpression.Validate(__workflow_requestBodybodyParameters, nameof(requestBodybodyParameters), required: false);
            var __workflow_requestBodyheaderParameters = requestBodyheaderParameters == null ? null : WorkflowExpression.Compile(requestBodyheaderParameters);
            WorkflowExpression.Validate(__workflow_requestBodyheaderParameters, nameof(requestBodyheaderParameters), required: false);
            var __workflow_requestBodybuttons = requestBodybuttons == null ? null : WorkflowExpression.Compile(requestBodybuttons);
            WorkflowExpression.Validate(__workflow_requestBodybuttons, nameof(requestBodybuttons), required: false);
            var __workflow_requestBodysendDateTime = requestBodysendDateTime == null ? null : WorkflowExpression.Compile(requestBodysendDateTime);
            WorkflowExpression.Validate(__workflow_requestBodysendDateTime, nameof(requestBodysendDateTime), required: false);
            var __workflow_requestBodyattachmentUri = requestBodyattachmentUri == null ? null : WorkflowExpression.Compile(requestBodyattachmentUri);
            WorkflowExpression.Validate(__workflow_requestBodyattachmentUri, nameof(requestBodyattachmentUri), required: false);
            var __workflow_requestBodyuseSmsFallback = requestBodyuseSmsFallback == null ? null : WorkflowExpression.Compile(requestBodyuseSmsFallback);
            WorkflowExpression.Validate(__workflow_requestBodyuseSmsFallback, nameof(requestBodyuseSmsFallback), required: false);
            var __workflow_requestBodydlrUrl = requestBodydlrUrl == null ? null : WorkflowExpression.Compile(requestBodydlrUrl);
            WorkflowExpression.Validate(__workflow_requestBodydlrUrl, nameof(requestBodydlrUrl), required: false);
            var __workflow_requestBodycustomerData = requestBodycustomerData == null ? null : WorkflowExpression.Compile(requestBodycustomerData);
            WorkflowExpression.Validate(__workflow_requestBodycustomerData, nameof(requestBodycustomerData), required: false);
            var __workflow_requestBodyrequestId = requestBodyrequestId == null ? null : WorkflowExpression.Compile(requestBodyrequestId);
            WorkflowExpression.Validate(__workflow_requestBodyrequestId, nameof(requestBodyrequestId), required: false);
            return new DeferredBodyAction<SendWhatsappTemplateMessageResponse>(() =>
            {
                var apiCallPath = "/messages/templates/whatsapp";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Customer-Id"] = ExpressionConverter.Convert(__workflow_customerId);
                callPayload.Headers["Service-Id"] = ExpressionConverter.Convert(__workflow_serviceId);
                var requestBody = new JObject();
                var requestBodypropCount = 0;
                requestBodypropCount++;
                requestBody["TemplateName"] = ExpressionConverter.ConvertO(__workflow_requestBodytemplateName);
                requestBodypropCount++;
                requestBody["Recipients"] = ExpressionConverter.ConvertO(__workflow_requestBodyrecipients);
                if (__workflow_requestBodybodyParameters != null)
                {
                    requestBody["BodyParameters"] = ExpressionConverter.ConvertO(__workflow_requestBodybodyParameters);
                    requestBodypropCount++;
                }

                if (__workflow_requestBodyheaderParameters != null)
                {
                    requestBody["HeaderParameters"] = ExpressionConverter.ConvertO(__workflow_requestBodyheaderParameters);
                    requestBodypropCount++;
                }

                if (__workflow_requestBodybuttons != null)
                {
                    requestBody["Buttons"] = ExpressionConverter.ConvertO(__workflow_requestBodybuttons);
                    requestBodypropCount++;
                }

                if (__workflow_requestBodysendDateTime != null)
                {
                    requestBody["SendDateTime"] = ExpressionConverter.ConvertO(__workflow_requestBodysendDateTime);
                    requestBodypropCount++;
                }

                if (__workflow_requestBodyattachmentUri != null)
                {
                    requestBody["AttachmentUri"] = ExpressionConverter.ConvertO(__workflow_requestBodyattachmentUri);
                    requestBodypropCount++;
                }

                if (__workflow_requestBodyuseSmsFallback != null)
                {
                    requestBody["UseSmsFallback"] = ExpressionConverter.ConvertO(__workflow_requestBodyuseSmsFallback);
                    requestBodypropCount++;
                }

                if (__workflow_requestBodydlrUrl != null)
                {
                    requestBody["DlrUrl"] = ExpressionConverter.ConvertO(__workflow_requestBodydlrUrl);
                    requestBodypropCount++;
                }

                if (__workflow_requestBodycustomerData != null)
                {
                    requestBody["CustomerData"] = ExpressionConverter.ConvertO(__workflow_requestBodycustomerData);
                    requestBodypropCount++;
                }

                if (__workflow_requestBodyrequestId != null)
                {
                    requestBody["RequestId"] = ExpressionConverter.ConvertO(__workflow_requestBodyrequestId);
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
        public IBodyWorkflowAction<GetGroupContactResponse> GetGroupContact(Expression<Func<string>> customer, Expression<Func<string>> groupService, Expression<Func<string>> phone, Expression<Func<string>> region = null)
        {
            var __workflow_customer = customer == null ? null : WorkflowExpression.Compile(customer);
            WorkflowExpression.Validate(__workflow_customer, nameof(customer), required: true);
            var __workflow_groupService = groupService == null ? null : WorkflowExpression.Compile(groupService);
            WorkflowExpression.Validate(__workflow_groupService, nameof(groupService), required: true);
            var __workflow_phone = phone == null ? null : WorkflowExpression.Compile(phone);
            WorkflowExpression.Validate(__workflow_phone, nameof(phone), required: true);
            var __workflow_region = region == null ? null : WorkflowExpression.Compile(region);
            WorkflowExpression.Validate(__workflow_region, nameof(region), required: false);
            return new DeferredBodyAction<GetGroupContactResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/groupcontact/{0}/{1}/{2}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_customer, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_groupService, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_phone, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_region != null)
                    callPayload.Queries["Region"] = ExpressionConverter.Convert(__workflow_region);
                return new ApiConnectionAction<GetGroupContactResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smartdialog")]
        public IBodyWorkflowAction<bool> DeleteGroupContact(Expression<Func<string>> customer, Expression<Func<string>> groupService, Expression<Func<string>> phone)
        {
            var __workflow_customer = customer == null ? null : WorkflowExpression.Compile(customer);
            WorkflowExpression.Validate(__workflow_customer, nameof(customer), required: true);
            var __workflow_groupService = groupService == null ? null : WorkflowExpression.Compile(groupService);
            WorkflowExpression.Validate(__workflow_groupService, nameof(groupService), required: true);
            var __workflow_phone = phone == null ? null : WorkflowExpression.Compile(phone);
            WorkflowExpression.Validate(__workflow_phone, nameof(phone), required: true);
            return new DeferredBodyAction<bool>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/groupcontact/{0}/{1}/{2}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_customer, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_groupService, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_phone, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<bool>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smartdialog")]
        public IBodyWorkflowAction<bool> UpdateGroupContact(Expression<Func<string>> customer, Expression<Func<string>> groupService, Expression<Func<string>> phone, Expression<Func<bool>> requestBodyactive = null, Expression<Func<string>> requestBodyemail = null, Expression<Func<string>> requestBodyfirstName = null, Expression<Func<string>> requestBodylastName = null, Expression<Func<requestBodygenderInput>> requestBodygender = null, Expression<Func<int>> requestBodybirthYear = null, Expression<Func<string>> requestBodystreetAddress = null, Expression<Func<string>> requestBodyzipCode = null, Expression<Func<string>> requestBodycity = null, Expression<Func<string>> requestBodycountryCode = null, Expression<Func<requestBodycustomContactPropertiesInputItem[]>> requestBodycustomContactProperties = null, Expression<Func<string[]>> requestBodyphoneNumberRegions = null)
        {
            var __workflow_customer = customer == null ? null : WorkflowExpression.Compile(customer);
            WorkflowExpression.Validate(__workflow_customer, nameof(customer), required: true);
            var __workflow_groupService = groupService == null ? null : WorkflowExpression.Compile(groupService);
            WorkflowExpression.Validate(__workflow_groupService, nameof(groupService), required: true);
            var __workflow_phone = phone == null ? null : WorkflowExpression.Compile(phone);
            WorkflowExpression.Validate(__workflow_phone, nameof(phone), required: true);
            var __workflow_requestBodyactive = requestBodyactive == null ? null : WorkflowExpression.Compile(requestBodyactive);
            WorkflowExpression.Validate(__workflow_requestBodyactive, nameof(requestBodyactive), required: false);
            var __workflow_requestBodyemail = requestBodyemail == null ? null : WorkflowExpression.Compile(requestBodyemail);
            WorkflowExpression.Validate(__workflow_requestBodyemail, nameof(requestBodyemail), required: false);
            var __workflow_requestBodyfirstName = requestBodyfirstName == null ? null : WorkflowExpression.Compile(requestBodyfirstName);
            WorkflowExpression.Validate(__workflow_requestBodyfirstName, nameof(requestBodyfirstName), required: false);
            var __workflow_requestBodylastName = requestBodylastName == null ? null : WorkflowExpression.Compile(requestBodylastName);
            WorkflowExpression.Validate(__workflow_requestBodylastName, nameof(requestBodylastName), required: false);
            var __workflow_requestBodygender = requestBodygender == null ? null : WorkflowExpression.Compile(requestBodygender);
            WorkflowExpression.Validate(__workflow_requestBodygender, nameof(requestBodygender), required: false);
            var __workflow_requestBodybirthYear = requestBodybirthYear == null ? null : WorkflowExpression.Compile(requestBodybirthYear);
            WorkflowExpression.Validate(__workflow_requestBodybirthYear, nameof(requestBodybirthYear), required: false);
            var __workflow_requestBodystreetAddress = requestBodystreetAddress == null ? null : WorkflowExpression.Compile(requestBodystreetAddress);
            WorkflowExpression.Validate(__workflow_requestBodystreetAddress, nameof(requestBodystreetAddress), required: false);
            var __workflow_requestBodyzipCode = requestBodyzipCode == null ? null : WorkflowExpression.Compile(requestBodyzipCode);
            WorkflowExpression.Validate(__workflow_requestBodyzipCode, nameof(requestBodyzipCode), required: false);
            var __workflow_requestBodycity = requestBodycity == null ? null : WorkflowExpression.Compile(requestBodycity);
            WorkflowExpression.Validate(__workflow_requestBodycity, nameof(requestBodycity), required: false);
            var __workflow_requestBodycountryCode = requestBodycountryCode == null ? null : WorkflowExpression.Compile(requestBodycountryCode);
            WorkflowExpression.Validate(__workflow_requestBodycountryCode, nameof(requestBodycountryCode), required: false);
            var __workflow_requestBodycustomContactProperties = requestBodycustomContactProperties == null ? null : WorkflowExpression.Compile(requestBodycustomContactProperties);
            WorkflowExpression.Validate(__workflow_requestBodycustomContactProperties, nameof(requestBodycustomContactProperties), required: false);
            var __workflow_requestBodyphoneNumberRegions = requestBodyphoneNumberRegions == null ? null : WorkflowExpression.Compile(requestBodyphoneNumberRegions);
            WorkflowExpression.Validate(__workflow_requestBodyphoneNumberRegions, nameof(requestBodyphoneNumberRegions), required: false);
            return new DeferredBodyAction<bool>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/groupcontact/{0}/{1}/{2}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_customer, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_groupService, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_phone, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var requestBody = new JObject();
                var requestBodypropCount = 0;
                if (__workflow_requestBodyactive != null)
                {
                    if (__workflow_requestBodyactive != null)
                    {
                        requestBody["active"] = ExpressionConverter.ConvertO(__workflow_requestBodyactive);
                        requestBodypropCount++;
                    }

                    requestBodypropCount++;
                }
                else
                {
                    requestBody["active"] = true;
                    requestBodypropCount++;
                }

                if (__workflow_requestBodyemail != null)
                {
                    requestBody["email"] = ExpressionConverter.ConvertO(__workflow_requestBodyemail);
                    requestBodypropCount++;
                }

                if (__workflow_requestBodyfirstName != null)
                {
                    requestBody["firstName"] = ExpressionConverter.ConvertO(__workflow_requestBodyfirstName);
                    requestBodypropCount++;
                }

                if (__workflow_requestBodylastName != null)
                {
                    requestBody["lastName"] = ExpressionConverter.ConvertO(__workflow_requestBodylastName);
                    requestBodypropCount++;
                }

                if (__workflow_requestBodygender != null)
                {
                    requestBody["gender"] = ExpressionConverter.ConvertO(__workflow_requestBodygender);
                    requestBodypropCount++;
                }

                if (__workflow_requestBodybirthYear != null)
                {
                    requestBody["birthYear"] = ExpressionConverter.ConvertO(__workflow_requestBodybirthYear);
                    requestBodypropCount++;
                }

                if (__workflow_requestBodystreetAddress != null)
                {
                    requestBody["streetAddress"] = ExpressionConverter.ConvertO(__workflow_requestBodystreetAddress);
                    requestBodypropCount++;
                }

                if (__workflow_requestBodyzipCode != null)
                {
                    requestBody["zipCode"] = ExpressionConverter.ConvertO(__workflow_requestBodyzipCode);
                    requestBodypropCount++;
                }

                if (__workflow_requestBodycity != null)
                {
                    requestBody["city"] = ExpressionConverter.ConvertO(__workflow_requestBodycity);
                    requestBodypropCount++;
                }

                if (__workflow_requestBodycountryCode != null)
                {
                    requestBody["countryCode"] = ExpressionConverter.ConvertO(__workflow_requestBodycountryCode);
                    requestBodypropCount++;
                }

                if (__workflow_requestBodycustomContactProperties != null)
                {
                    requestBody["customContactProperties"] = ExpressionConverter.ConvertO(__workflow_requestBodycustomContactProperties);
                    requestBodypropCount++;
                }

                if (__workflow_requestBodyphoneNumberRegions != null)
                {
                    requestBody["phoneNumberRegions"] = ExpressionConverter.ConvertO(__workflow_requestBodyphoneNumberRegions);
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
        public IBodyWorkflowAction<bool> DeleteAllGroupContacts(Expression<Func<string>> customer, Expression<Func<string>> groupService)
        {
            var __workflow_customer = customer == null ? null : WorkflowExpression.Compile(customer);
            WorkflowExpression.Validate(__workflow_customer, nameof(customer), required: true);
            var __workflow_groupService = groupService == null ? null : WorkflowExpression.Compile(groupService);
            WorkflowExpression.Validate(__workflow_groupService, nameof(groupService), required: true);
            return new DeferredBodyAction<bool>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/groupcontact/{0}/{1}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_customer, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_groupService, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<bool>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smartdialog")]
        public IBodyWorkflowAction<string> CreateGroupContact(Expression<Func<string>> customer, Expression<Func<string>> groupService, Expression<Func<string>> requestBodyphone, Expression<Func<bool>> requestBodyactive = null, Expression<Func<string>> requestBodyemail = null, Expression<Func<string>> requestBodyfirstName = null, Expression<Func<string>> requestBodylastName = null, Expression<Func<requestBodygenderInput>> requestBodygender = null, Expression<Func<int>> requestBodybirthYear = null, Expression<Func<string>> requestBodystreetAddress = null, Expression<Func<string>> requestBodyzipCode = null, Expression<Func<string>> requestBodycity = null, Expression<Func<string>> requestBodycountryCode = null, Expression<Func<requestBodycustomContactPropertiesInputItem[]>> requestBodycustomContactProperties = null, Expression<Func<string[]>> requestBodyphoneNumberRegions = null)
        {
            var __workflow_customer = customer == null ? null : WorkflowExpression.Compile(customer);
            WorkflowExpression.Validate(__workflow_customer, nameof(customer), required: true);
            var __workflow_groupService = groupService == null ? null : WorkflowExpression.Compile(groupService);
            WorkflowExpression.Validate(__workflow_groupService, nameof(groupService), required: true);
            var __workflow_requestBodyphone = requestBodyphone == null ? null : WorkflowExpression.Compile(requestBodyphone);
            WorkflowExpression.Validate(__workflow_requestBodyphone, nameof(requestBodyphone), required: true);
            var __workflow_requestBodyactive = requestBodyactive == null ? null : WorkflowExpression.Compile(requestBodyactive);
            WorkflowExpression.Validate(__workflow_requestBodyactive, nameof(requestBodyactive), required: false);
            var __workflow_requestBodyemail = requestBodyemail == null ? null : WorkflowExpression.Compile(requestBodyemail);
            WorkflowExpression.Validate(__workflow_requestBodyemail, nameof(requestBodyemail), required: false);
            var __workflow_requestBodyfirstName = requestBodyfirstName == null ? null : WorkflowExpression.Compile(requestBodyfirstName);
            WorkflowExpression.Validate(__workflow_requestBodyfirstName, nameof(requestBodyfirstName), required: false);
            var __workflow_requestBodylastName = requestBodylastName == null ? null : WorkflowExpression.Compile(requestBodylastName);
            WorkflowExpression.Validate(__workflow_requestBodylastName, nameof(requestBodylastName), required: false);
            var __workflow_requestBodygender = requestBodygender == null ? null : WorkflowExpression.Compile(requestBodygender);
            WorkflowExpression.Validate(__workflow_requestBodygender, nameof(requestBodygender), required: false);
            var __workflow_requestBodybirthYear = requestBodybirthYear == null ? null : WorkflowExpression.Compile(requestBodybirthYear);
            WorkflowExpression.Validate(__workflow_requestBodybirthYear, nameof(requestBodybirthYear), required: false);
            var __workflow_requestBodystreetAddress = requestBodystreetAddress == null ? null : WorkflowExpression.Compile(requestBodystreetAddress);
            WorkflowExpression.Validate(__workflow_requestBodystreetAddress, nameof(requestBodystreetAddress), required: false);
            var __workflow_requestBodyzipCode = requestBodyzipCode == null ? null : WorkflowExpression.Compile(requestBodyzipCode);
            WorkflowExpression.Validate(__workflow_requestBodyzipCode, nameof(requestBodyzipCode), required: false);
            var __workflow_requestBodycity = requestBodycity == null ? null : WorkflowExpression.Compile(requestBodycity);
            WorkflowExpression.Validate(__workflow_requestBodycity, nameof(requestBodycity), required: false);
            var __workflow_requestBodycountryCode = requestBodycountryCode == null ? null : WorkflowExpression.Compile(requestBodycountryCode);
            WorkflowExpression.Validate(__workflow_requestBodycountryCode, nameof(requestBodycountryCode), required: false);
            var __workflow_requestBodycustomContactProperties = requestBodycustomContactProperties == null ? null : WorkflowExpression.Compile(requestBodycustomContactProperties);
            WorkflowExpression.Validate(__workflow_requestBodycustomContactProperties, nameof(requestBodycustomContactProperties), required: false);
            var __workflow_requestBodyphoneNumberRegions = requestBodyphoneNumberRegions == null ? null : WorkflowExpression.Compile(requestBodyphoneNumberRegions);
            WorkflowExpression.Validate(__workflow_requestBodyphoneNumberRegions, nameof(requestBodyphoneNumberRegions), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/groupcontact/{0}/{1}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_customer, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_groupService, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var requestBody = new JObject();
                var requestBodypropCount = 0;
                if (__workflow_requestBodyactive != null)
                {
                    if (__workflow_requestBodyactive != null)
                    {
                        requestBody["active"] = ExpressionConverter.ConvertO(__workflow_requestBodyactive);
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
                requestBody["phone"] = ExpressionConverter.ConvertO(__workflow_requestBodyphone);
                if (__workflow_requestBodyemail != null)
                {
                    requestBody["email"] = ExpressionConverter.ConvertO(__workflow_requestBodyemail);
                    requestBodypropCount++;
                }

                if (__workflow_requestBodyfirstName != null)
                {
                    requestBody["firstName"] = ExpressionConverter.ConvertO(__workflow_requestBodyfirstName);
                    requestBodypropCount++;
                }

                if (__workflow_requestBodylastName != null)
                {
                    requestBody["lastName"] = ExpressionConverter.ConvertO(__workflow_requestBodylastName);
                    requestBodypropCount++;
                }

                if (__workflow_requestBodygender != null)
                {
                    requestBody["gender"] = ExpressionConverter.ConvertO(__workflow_requestBodygender);
                    requestBodypropCount++;
                }

                if (__workflow_requestBodybirthYear != null)
                {
                    requestBody["birthYear"] = ExpressionConverter.ConvertO(__workflow_requestBodybirthYear);
                    requestBodypropCount++;
                }

                if (__workflow_requestBodystreetAddress != null)
                {
                    requestBody["streetAddress"] = ExpressionConverter.ConvertO(__workflow_requestBodystreetAddress);
                    requestBodypropCount++;
                }

                if (__workflow_requestBodyzipCode != null)
                {
                    requestBody["zipCode"] = ExpressionConverter.ConvertO(__workflow_requestBodyzipCode);
                    requestBodypropCount++;
                }

                if (__workflow_requestBodycity != null)
                {
                    requestBody["city"] = ExpressionConverter.ConvertO(__workflow_requestBodycity);
                    requestBodypropCount++;
                }

                if (__workflow_requestBodycountryCode != null)
                {
                    requestBody["countryCode"] = ExpressionConverter.ConvertO(__workflow_requestBodycountryCode);
                    requestBodypropCount++;
                }

                if (__workflow_requestBodycustomContactProperties != null)
                {
                    requestBody["customContactProperties"] = ExpressionConverter.ConvertO(__workflow_requestBodycustomContactProperties);
                    requestBodypropCount++;
                }

                if (__workflow_requestBodyphoneNumberRegions != null)
                {
                    requestBody["phoneNumberRegions"] = ExpressionConverter.ConvertO(__workflow_requestBodyphoneNumberRegions);
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
        public IBodyWorkflowTrigger<NewMessageResponse> NewMessage(Expression<Func<string>> customer, Expression<Func<string>> service, FlowRecurrence recurrence = null)
        {
            var __workflow_customer = customer == null ? null : WorkflowExpression.Compile(customer);
            WorkflowExpression.Validate(__workflow_customer, nameof(customer), required: true);
            var __workflow_service = service == null ? null : WorkflowExpression.Compile(service);
            WorkflowExpression.Validate(__workflow_service, nameof(service), required: true);
            return new DeferredBodyTrigger<NewMessageResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/service/{0}/pipelines/actions", ExpressionConverter.ConvertWithUrlEncoding(__workflow_service, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Customer"] = ExpressionConverter.Convert(__workflow_customer);
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

                return new ApiConnectionTrigger<NewMessageResponse>(callPayload, recurrence: recurrence);
            });
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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
