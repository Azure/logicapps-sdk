//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Smartdialog
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SmartdialogActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smartdialog")]
        public IBodyWorkflowAction<SendMessageResponse> SendMessage(Expression<Func<string>> customerId, Expression<Func<string>> serviceId, Expression<Func<string>> requestBodysender, Expression<Func<string>> requestBodycontent, Expression<Func<requestBodyprotocolInput>> requestBodyprotocol, Expression<Func<requestBodyrecipientsInputItem[]>> requestBodyrecipients, Expression<Func<string>> requestBodysendDateTime = null, Expression<Func<string>> requestBodyattachmentUri = null, Expression<Func<string>> requestBodycustomerData = null, Expression<Func<bool>> requestBodyadMessage = null, Expression<Func<string>> requestBodydlrUrl = null, Expression<Func<string>> requestBodyrequestId = null)
        {
            var apiCallPath = "/messages";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Customer-Id"] = CSharpExpressionConverter.ConvertO(customerId);
            callPayload.Headers["Service-Id"] = CSharpExpressionConverter.ConvertO(serviceId);
            var requestBody = new JObject();
            var requestBodypropCount = 0;
            requestBodypropCount++;
            requestBody["Sender"] = CSharpExpressionConverter.ConvertToken(requestBodysender);
            requestBodypropCount++;
            requestBody["Content"] = CSharpExpressionConverter.ConvertToken(requestBodycontent);
            requestBodypropCount++;
            requestBody["Protocol"] = CSharpExpressionConverter.Convert(requestBodyprotocol);
            if (requestBodysendDateTime != null)
            {
                requestBody["SendDateTime"] = CSharpExpressionConverter.ConvertToken(requestBodysendDateTime);
                requestBodypropCount++;
            }

            requestBodypropCount++;
            requestBody["Recipients"] = CSharpExpressionConverter.ConvertToken(requestBodyrecipients);
            if (requestBodyattachmentUri != null)
            {
                requestBody["AttachmentUri"] = CSharpExpressionConverter.ConvertToken(requestBodyattachmentUri);
                requestBodypropCount++;
            }

            if (requestBodycustomerData != null)
            {
                requestBody["CustomerData"] = CSharpExpressionConverter.ConvertToken(requestBodycustomerData);
                requestBodypropCount++;
            }

            if (requestBodyadMessage != null)
            {
                requestBody["AdMessage"] = CSharpExpressionConverter.ConvertToken(requestBodyadMessage);
                requestBodypropCount++;
            }

            if (requestBodydlrUrl != null)
            {
                requestBody["DlrUrl"] = CSharpExpressionConverter.ConvertToken(requestBodydlrUrl);
                requestBodypropCount++;
            }

            if (requestBodyrequestId != null)
            {
                requestBody["RequestId"] = CSharpExpressionConverter.ConvertToken(requestBodyrequestId);
                requestBodypropCount++;
            }

            if (requestBodypropCount > 0)
            {
                callPayload.Body = requestBody;
            }

            return new ApiConnectionAction<SendMessageResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smartdialog")]
        public IBodyWorkflowAction<SendReplyMessageResponse> SendReplyMessage(Expression<Func<string>> parentMessageId, Expression<Func<string>> customerId, Expression<Func<string>> serviceId, Expression<Func<string>> requestBodysender, Expression<Func<string>> requestBodycontent, Expression<Func<requestBodyprotocolInput>> requestBodyprotocol, Expression<Func<requestBodyrecipientsInputItem[]>> requestBodyrecipients, Expression<Func<string>> requestBodysendDateTime = null, Expression<Func<string>> requestBodyattachmentUri = null, Expression<Func<string>> requestBodycustomerData = null, Expression<Func<bool>> requestBodyadMessage = null, Expression<Func<string>> requestBodydlrUrl = null, Expression<Func<string>> requestBodyrequestId = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/messages/reply/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(parentMessageId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Customer-Id"] = CSharpExpressionConverter.ConvertO(customerId);
            callPayload.Headers["Service-Id"] = CSharpExpressionConverter.ConvertO(serviceId);
            var requestBody = new JObject();
            var requestBodypropCount = 0;
            requestBodypropCount++;
            requestBody["Sender"] = CSharpExpressionConverter.ConvertToken(requestBodysender);
            requestBodypropCount++;
            requestBody["Content"] = CSharpExpressionConverter.ConvertToken(requestBodycontent);
            requestBodypropCount++;
            requestBody["Protocol"] = CSharpExpressionConverter.Convert(requestBodyprotocol);
            if (requestBodysendDateTime != null)
            {
                requestBody["SendDateTime"] = CSharpExpressionConverter.ConvertToken(requestBodysendDateTime);
                requestBodypropCount++;
            }

            requestBodypropCount++;
            requestBody["Recipients"] = CSharpExpressionConverter.ConvertToken(requestBodyrecipients);
            if (requestBodyattachmentUri != null)
            {
                requestBody["AttachmentUri"] = CSharpExpressionConverter.ConvertToken(requestBodyattachmentUri);
                requestBodypropCount++;
            }

            if (requestBodycustomerData != null)
            {
                requestBody["CustomerData"] = CSharpExpressionConverter.ConvertToken(requestBodycustomerData);
                requestBodypropCount++;
            }

            if (requestBodyadMessage != null)
            {
                requestBody["AdMessage"] = CSharpExpressionConverter.ConvertToken(requestBodyadMessage);
                requestBodypropCount++;
            }

            if (requestBodydlrUrl != null)
            {
                requestBody["DlrUrl"] = CSharpExpressionConverter.ConvertToken(requestBodydlrUrl);
                requestBodypropCount++;
            }

            if (requestBodyrequestId != null)
            {
                requestBody["RequestId"] = CSharpExpressionConverter.ConvertToken(requestBodyrequestId);
                requestBodypropCount++;
            }

            if (requestBodypropCount > 0)
            {
                callPayload.Body = requestBody;
            }

            return new ApiConnectionAction<SendReplyMessageResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smartdialog")]
        public IBodyWorkflowAction<SendDiscussionReplyMessageResponse> SendDiscussionReplyMessage(Expression<Func<string>> customerId, Expression<Func<string>> requestBodythreadId, Expression<Func<string>> requestBodycontent, Expression<Func<string>> requestBodycustomerData = null)
        {
            var apiCallPath = "/messages/discussion/reply";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["CustomerId"] = CSharpExpressionConverter.ConvertO(customerId);
            var requestBody = new JObject();
            var requestBodypropCount = 0;
            requestBodypropCount++;
            requestBody["ThreadId"] = CSharpExpressionConverter.ConvertToken(requestBodythreadId);
            requestBodypropCount++;
            requestBody["Content"] = CSharpExpressionConverter.ConvertToken(requestBodycontent);
            if (requestBodycustomerData != null)
            {
                requestBody["CustomerData"] = CSharpExpressionConverter.ConvertToken(requestBodycustomerData);
                requestBodypropCount++;
            }

            if (requestBodypropCount > 0)
            {
                callPayload.Body = requestBody;
            }

            return new ApiConnectionAction<SendDiscussionReplyMessageResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smartdialog")]
        public IWorkflowAction CreateWhatsappTemplate(Expression<Func<string>> customerId, Expression<Func<string>> identityNumber, Expression<Func<string>> requestBodydisplayName, Expression<Func<string>> requestBodyrawContent, Expression<Func<string>> requestBodycategory, Expression<Func<string>> requestBodylanguage, Expression<Func<requestBodybuttonsInputItem[]>> requestBodybuttons = null, Expression<Func<string>> requestBodyattachmentUrl = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/whatsapp/templates/{0}/{1}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(customerId, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(identityNumber, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var requestBody = new JObject();
            var requestBodypropCount = 0;
            requestBodypropCount++;
            requestBody["DisplayName"] = CSharpExpressionConverter.ConvertToken(requestBodydisplayName);
            requestBodypropCount++;
            requestBody["RawContent"] = CSharpExpressionConverter.ConvertToken(requestBodyrawContent);
            requestBodypropCount++;
            requestBody["Category"] = CSharpExpressionConverter.ConvertToken(requestBodycategory);
            requestBodypropCount++;
            requestBody["Language"] = CSharpExpressionConverter.ConvertToken(requestBodylanguage);
            if (requestBodybuttons != null)
            {
                requestBody["Buttons"] = CSharpExpressionConverter.ConvertToken(requestBodybuttons);
                requestBodypropCount++;
            }

            if (requestBodyattachmentUrl != null)
            {
                requestBody["AttachmentUrl"] = CSharpExpressionConverter.ConvertToken(requestBodyattachmentUrl);
                requestBodypropCount++;
            }

            if (requestBodypropCount > 0)
            {
                callPayload.Body = requestBody;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smartdialog")]
        public IBodyWorkflowAction<SendWhatsappTemplateMessageResponse> SendWhatsappTemplateMessage(Expression<Func<string>> customerId, Expression<Func<string>> serviceId, Expression<Func<string>> requestBodytemplateName, Expression<Func<requestBodyrecipientsInputItem2[]>> requestBodyrecipients, Expression<Func<string[]>> requestBodybodyParameters = null, Expression<Func<string[]>> requestBodyheaderParameters = null, Expression<Func<requestBodybuttonsInputItem2[]>> requestBodybuttons = null, Expression<Func<string>> requestBodysendDateTime = null, Expression<Func<string>> requestBodyattachmentUri = null, Expression<Func<bool>> requestBodyuseSmsFallback = null, Expression<Func<string>> requestBodydlrUrl = null, Expression<Func<string>> requestBodycustomerData = null, Expression<Func<string>> requestBodyrequestId = null)
        {
            var apiCallPath = "/messages/templates/whatsapp";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Customer-Id"] = CSharpExpressionConverter.ConvertO(customerId);
            callPayload.Headers["Service-Id"] = CSharpExpressionConverter.ConvertO(serviceId);
            var requestBody = new JObject();
            var requestBodypropCount = 0;
            requestBodypropCount++;
            requestBody["TemplateName"] = CSharpExpressionConverter.ConvertToken(requestBodytemplateName);
            requestBodypropCount++;
            requestBody["Recipients"] = CSharpExpressionConverter.ConvertToken(requestBodyrecipients);
            if (requestBodybodyParameters != null)
            {
                requestBody["BodyParameters"] = CSharpExpressionConverter.ConvertToken(requestBodybodyParameters);
                requestBodypropCount++;
            }

            if (requestBodyheaderParameters != null)
            {
                requestBody["HeaderParameters"] = CSharpExpressionConverter.ConvertToken(requestBodyheaderParameters);
                requestBodypropCount++;
            }

            if (requestBodybuttons != null)
            {
                requestBody["Buttons"] = CSharpExpressionConverter.ConvertToken(requestBodybuttons);
                requestBodypropCount++;
            }

            if (requestBodysendDateTime != null)
            {
                requestBody["SendDateTime"] = CSharpExpressionConverter.ConvertToken(requestBodysendDateTime);
                requestBodypropCount++;
            }

            if (requestBodyattachmentUri != null)
            {
                requestBody["AttachmentUri"] = CSharpExpressionConverter.ConvertToken(requestBodyattachmentUri);
                requestBodypropCount++;
            }

            if (requestBodyuseSmsFallback != null)
            {
                requestBody["UseSmsFallback"] = CSharpExpressionConverter.ConvertToken(requestBodyuseSmsFallback);
                requestBodypropCount++;
            }

            if (requestBodydlrUrl != null)
            {
                requestBody["DlrUrl"] = CSharpExpressionConverter.ConvertToken(requestBodydlrUrl);
                requestBodypropCount++;
            }

            if (requestBodycustomerData != null)
            {
                requestBody["CustomerData"] = CSharpExpressionConverter.ConvertToken(requestBodycustomerData);
                requestBodypropCount++;
            }

            if (requestBodyrequestId != null)
            {
                requestBody["RequestId"] = CSharpExpressionConverter.ConvertToken(requestBodyrequestId);
                requestBodypropCount++;
            }

            if (requestBodypropCount > 0)
            {
                callPayload.Body = requestBody;
            }

            return new ApiConnectionAction<SendWhatsappTemplateMessageResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smartdialog")]
        public IBodyWorkflowAction<GetGroupContactResponse> GetGroupContact(Expression<Func<string>> customer, Expression<Func<string>> groupService, Expression<Func<string>> phone, Expression<Func<string>> region = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/groupcontact/{0}/{1}/{2}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(customer, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(groupService, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(phone, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (region != null)
                callPayload.Queries["Region"] = CSharpExpressionConverter.ConvertO(region);
            return new ApiConnectionAction<GetGroupContactResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smartdialog")]
        public IBodyWorkflowAction<bool> DeleteGroupContact(Expression<Func<string>> customer, Expression<Func<string>> groupService, Expression<Func<string>> phone)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/groupcontact/{0}/{1}/{2}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(customer, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(groupService, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(phone, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<bool>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smartdialog")]
        public IBodyWorkflowAction<bool> UpdateGroupContact(Expression<Func<string>> customer, Expression<Func<string>> groupService, Expression<Func<string>> phone, Expression<Func<bool>> requestBodyactive = null, Expression<Func<string>> requestBodyemail = null, Expression<Func<string>> requestBodyfirstName = null, Expression<Func<string>> requestBodylastName = null, Expression<Func<requestBodygenderInput>> requestBodygender = null, Expression<Func<int>> requestBodybirthYear = null, Expression<Func<string>> requestBodystreetAddress = null, Expression<Func<string>> requestBodyzipCode = null, Expression<Func<string>> requestBodycity = null, Expression<Func<string>> requestBodycountryCode = null, Expression<Func<requestBodycustomContactPropertiesInputItem[]>> requestBodycustomContactProperties = null, Expression<Func<string[]>> requestBodyphoneNumberRegions = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/groupcontact/{0}/{1}/{2}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(customer, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(groupService, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(phone, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var requestBody = new JObject();
            var requestBodypropCount = 0;
            if (requestBodyactive != null)
            {
                if (requestBodyactive != null)
                {
                    requestBody["active"] = CSharpExpressionConverter.ConvertToken(requestBodyactive);
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
                requestBody["email"] = CSharpExpressionConverter.ConvertToken(requestBodyemail);
                requestBodypropCount++;
            }

            if (requestBodyfirstName != null)
            {
                requestBody["firstName"] = CSharpExpressionConverter.ConvertToken(requestBodyfirstName);
                requestBodypropCount++;
            }

            if (requestBodylastName != null)
            {
                requestBody["lastName"] = CSharpExpressionConverter.ConvertToken(requestBodylastName);
                requestBodypropCount++;
            }

            if (requestBodygender != null)
            {
                requestBody["gender"] = CSharpExpressionConverter.Convert(requestBodygender);
                requestBodypropCount++;
            }

            if (requestBodybirthYear != null)
            {
                requestBody["birthYear"] = CSharpExpressionConverter.ConvertToken(requestBodybirthYear);
                requestBodypropCount++;
            }

            if (requestBodystreetAddress != null)
            {
                requestBody["streetAddress"] = CSharpExpressionConverter.ConvertToken(requestBodystreetAddress);
                requestBodypropCount++;
            }

            if (requestBodyzipCode != null)
            {
                requestBody["zipCode"] = CSharpExpressionConverter.ConvertToken(requestBodyzipCode);
                requestBodypropCount++;
            }

            if (requestBodycity != null)
            {
                requestBody["city"] = CSharpExpressionConverter.ConvertToken(requestBodycity);
                requestBodypropCount++;
            }

            if (requestBodycountryCode != null)
            {
                requestBody["countryCode"] = CSharpExpressionConverter.ConvertToken(requestBodycountryCode);
                requestBodypropCount++;
            }

            if (requestBodycustomContactProperties != null)
            {
                requestBody["customContactProperties"] = CSharpExpressionConverter.ConvertToken(requestBodycustomContactProperties);
                requestBodypropCount++;
            }

            if (requestBodyphoneNumberRegions != null)
            {
                requestBody["phoneNumberRegions"] = CSharpExpressionConverter.ConvertToken(requestBodyphoneNumberRegions);
                requestBodypropCount++;
            }

            if (requestBodypropCount > 0)
            {
                callPayload.Body = requestBody;
            }

            return new ApiConnectionAction<bool>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smartdialog")]
        public IBodyWorkflowAction<bool> DeleteAllGroupContacts(Expression<Func<string>> customer, Expression<Func<string>> groupService)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/groupcontact/{0}/{1}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(customer, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(groupService, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<bool>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smartdialog")]
        public IBodyWorkflowAction<string> CreateGroupContact(Expression<Func<string>> customer, Expression<Func<string>> groupService, Expression<Func<string>> requestBodyphone, Expression<Func<bool>> requestBodyactive = null, Expression<Func<string>> requestBodyemail = null, Expression<Func<string>> requestBodyfirstName = null, Expression<Func<string>> requestBodylastName = null, Expression<Func<requestBodygenderInput>> requestBodygender = null, Expression<Func<int>> requestBodybirthYear = null, Expression<Func<string>> requestBodystreetAddress = null, Expression<Func<string>> requestBodyzipCode = null, Expression<Func<string>> requestBodycity = null, Expression<Func<string>> requestBodycountryCode = null, Expression<Func<requestBodycustomContactPropertiesInputItem[]>> requestBodycustomContactProperties = null, Expression<Func<string[]>> requestBodyphoneNumberRegions = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/groupcontact/{0}/{1}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(customer, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(groupService, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var requestBody = new JObject();
            var requestBodypropCount = 0;
            if (requestBodyactive != null)
            {
                if (requestBodyactive != null)
                {
                    requestBody["active"] = CSharpExpressionConverter.ConvertToken(requestBodyactive);
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
            requestBody["phone"] = CSharpExpressionConverter.ConvertToken(requestBodyphone);
            if (requestBodyemail != null)
            {
                requestBody["email"] = CSharpExpressionConverter.ConvertToken(requestBodyemail);
                requestBodypropCount++;
            }

            if (requestBodyfirstName != null)
            {
                requestBody["firstName"] = CSharpExpressionConverter.ConvertToken(requestBodyfirstName);
                requestBodypropCount++;
            }

            if (requestBodylastName != null)
            {
                requestBody["lastName"] = CSharpExpressionConverter.ConvertToken(requestBodylastName);
                requestBodypropCount++;
            }

            if (requestBodygender != null)
            {
                requestBody["gender"] = CSharpExpressionConverter.Convert(requestBodygender);
                requestBodypropCount++;
            }

            if (requestBodybirthYear != null)
            {
                requestBody["birthYear"] = CSharpExpressionConverter.ConvertToken(requestBodybirthYear);
                requestBodypropCount++;
            }

            if (requestBodystreetAddress != null)
            {
                requestBody["streetAddress"] = CSharpExpressionConverter.ConvertToken(requestBodystreetAddress);
                requestBodypropCount++;
            }

            if (requestBodyzipCode != null)
            {
                requestBody["zipCode"] = CSharpExpressionConverter.ConvertToken(requestBodyzipCode);
                requestBodypropCount++;
            }

            if (requestBodycity != null)
            {
                requestBody["city"] = CSharpExpressionConverter.ConvertToken(requestBodycity);
                requestBodypropCount++;
            }

            if (requestBodycountryCode != null)
            {
                requestBody["countryCode"] = CSharpExpressionConverter.ConvertToken(requestBodycountryCode);
                requestBodypropCount++;
            }

            if (requestBodycustomContactProperties != null)
            {
                requestBody["customContactProperties"] = CSharpExpressionConverter.ConvertToken(requestBodycustomContactProperties);
                requestBodypropCount++;
            }

            if (requestBodyphoneNumberRegions != null)
            {
                requestBody["phoneNumberRegions"] = CSharpExpressionConverter.ConvertToken(requestBodyphoneNumberRegions);
                requestBodypropCount++;
            }

            if (requestBodypropCount > 0)
            {
                callPayload.Body = requestBody;
            }

            return new ApiConnectionAction<string>(callPayload);
        }
    }

    public class SmartdialogTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<NewMessageResponse> NewMessage(Expression<Func<string>> customer, Expression<Func<string>> service, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/service/{0}/pipelines/actions", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(service, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Customer"] = CSharpExpressionConverter.ConvertO(customer);
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
            optionsObject["endpointUrl"] = "@listCallbackUrl()";
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