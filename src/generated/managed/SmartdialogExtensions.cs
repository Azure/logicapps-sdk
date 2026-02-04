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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smartdialog")]
        public IBodyWorkflowAction<SendReplyMessageResponse> SendReplyMessage(Expression<Func<string>> parentMessageId, Expression<Func<string>> customerId, Expression<Func<string>> serviceId, Expression<Func<string>> requestBodysender, Expression<Func<string>> requestBodycontent, Expression<Func<requestBodyprotocolInput>> requestBodyprotocol, Expression<Func<requestBodyrecipientsInputItem[]>> requestBodyrecipients, Expression<Func<string>> requestBodysendDateTime = null, Expression<Func<string>> requestBodyattachmentUri = null, Expression<Func<string>> requestBodycustomerData = null, Expression<Func<bool>> requestBodyadMessage = null, Expression<Func<string>> requestBodydlrUrl = null, Expression<Func<string>> requestBodyrequestId = null)
        {
            var apiCallPath = String.Format("/messages/reply/{0}", ExpressionConverter.ConvertWithUrlEncoding(parentMessageId, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smartdialog")]
        public IBodyWorkflowAction<SendDiscussionReplyMessageResponse> SendDiscussionReplyMessage(Expression<Func<string>> customerId, Expression<Func<string>> requestBodythreadId, Expression<Func<string>> requestBodycontent, Expression<Func<string>> requestBodycustomerData = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smartdialog")]
        public IWorkflowAction CreateWhatsappTemplate(Expression<Func<string>> customerId, Expression<Func<string>> identityNumber, Expression<Func<string>> requestBodydisplayName, Expression<Func<string>> requestBodyrawContent, Expression<Func<string>> requestBodycategory, Expression<Func<string>> requestBodylanguage, Expression<Func<requestBodybuttonsInputItem[]>> requestBodybuttons = null, Expression<Func<string>> requestBodyattachmentUrl = null)
        {
            var apiCallPath = String.Format("/whatsapp/templates/{0}/{1}", ExpressionConverter.ConvertWithUrlEncoding(customerId, 1), ExpressionConverter.ConvertWithUrlEncoding(identityNumber, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smartdialog")]
        public IBodyWorkflowAction<SendWhatsappTemplateMessageResponse> SendWhatsappTemplateMessage(Expression<Func<string>> customerId, Expression<Func<string>> serviceId, Expression<Func<string>> requestBodytemplateName, Expression<Func<requestBodyrecipientsInputItem2[]>> requestBodyrecipients, Expression<Func<string[]>> requestBodybodyParameters = null, Expression<Func<string[]>> requestBodyheaderParameters = null, Expression<Func<requestBodybuttonsInputItem2[]>> requestBodybuttons = null, Expression<Func<string>> requestBodysendDateTime = null, Expression<Func<string>> requestBodyattachmentUri = null, Expression<Func<bool>> requestBodyuseSmsFallback = null, Expression<Func<string>> requestBodydlrUrl = null, Expression<Func<string>> requestBodycustomerData = null, Expression<Func<string>> requestBodyrequestId = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smartdialog")]
        public IBodyWorkflowAction<GetGroupContactResponse> GetGroupContact(Expression<Func<string>> customer, Expression<Func<string>> groupService, Expression<Func<string>> phone, Expression<Func<string>> region = null)
        {
            var apiCallPath = String.Format("/groupcontact/{0}/{1}/{2}", ExpressionConverter.ConvertWithUrlEncoding(customer, 1), ExpressionConverter.ConvertWithUrlEncoding(groupService, 1), ExpressionConverter.ConvertWithUrlEncoding(phone, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (region != null)
                callPayload.Queries["Region"] = ExpressionConverter.Convert(region);
            return new ApiConnectionAction<GetGroupContactResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smartdialog")]
        public IBodyWorkflowAction<bool> DeleteGroupContact(Expression<Func<string>> customer, Expression<Func<string>> groupService, Expression<Func<string>> phone)
        {
            var apiCallPath = String.Format("/groupcontact/{0}/{1}/{2}", ExpressionConverter.ConvertWithUrlEncoding(customer, 1), ExpressionConverter.ConvertWithUrlEncoding(groupService, 1), ExpressionConverter.ConvertWithUrlEncoding(phone, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<bool>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smartdialog")]
        public IBodyWorkflowAction<bool> UpdateGroupContact(Expression<Func<string>> customer, Expression<Func<string>> groupService, Expression<Func<string>> phone, Expression<Func<bool>> requestBodyactive = null, Expression<Func<string>> requestBodyemail = null, Expression<Func<string>> requestBodyfirstName = null, Expression<Func<string>> requestBodylastName = null, Expression<Func<requestBodygenderInput>> requestBodygender = null, Expression<Func<int>> requestBodybirthYear = null, Expression<Func<string>> requestBodystreetAddress = null, Expression<Func<string>> requestBodyzipCode = null, Expression<Func<string>> requestBodycity = null, Expression<Func<string>> requestBodycountryCode = null, Expression<Func<requestBodycustomContactPropertiesInputItem[]>> requestBodycustomContactProperties = null, Expression<Func<string[]>> requestBodyphoneNumberRegions = null)
        {
            var apiCallPath = String.Format("/groupcontact/{0}/{1}/{2}", ExpressionConverter.ConvertWithUrlEncoding(customer, 1), ExpressionConverter.ConvertWithUrlEncoding(groupService, 1), ExpressionConverter.ConvertWithUrlEncoding(phone, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var requestBody = new JObject();
            var requestBodypropCount = 0;
            if (requestBodyactive != null)
            {
                requestBody["active"] = ExpressionConverter.ConvertO(requestBodyactive);
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smartdialog")]
        public IBodyWorkflowAction<bool> DeleteAllGroupContacts(Expression<Func<string>> customer, Expression<Func<string>> groupService)
        {
            var apiCallPath = String.Format("/groupcontact/{0}/{1}", ExpressionConverter.ConvertWithUrlEncoding(customer, 1), ExpressionConverter.ConvertWithUrlEncoding(groupService, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<bool>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smartdialog")]
        public IBodyWorkflowAction<string> CreateGroupContact(Expression<Func<string>> customer, Expression<Func<string>> groupService, Expression<Func<string>> requestBodyphone, Expression<Func<bool>> requestBodyactive = null, Expression<Func<string>> requestBodyemail = null, Expression<Func<string>> requestBodyfirstName = null, Expression<Func<string>> requestBodylastName = null, Expression<Func<requestBodygenderInput>> requestBodygender = null, Expression<Func<int>> requestBodybirthYear = null, Expression<Func<string>> requestBodystreetAddress = null, Expression<Func<string>> requestBodyzipCode = null, Expression<Func<string>> requestBodycity = null, Expression<Func<string>> requestBodycountryCode = null, Expression<Func<requestBodycustomContactPropertiesInputItem[]>> requestBodycustomContactProperties = null, Expression<Func<string[]>> requestBodyphoneNumberRegions = null)
        {
            var apiCallPath = String.Format("/groupcontact/{0}/{1}", ExpressionConverter.ConvertWithUrlEncoding(customer, 1), ExpressionConverter.ConvertWithUrlEncoding(groupService, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var requestBody = new JObject();
            var requestBodypropCount = 0;
            if (requestBodyactive != null)
            {
                requestBody["active"] = ExpressionConverter.ConvertO(requestBodyactive);
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
        }
    }

    public class SmartdialogTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<NewMessageResponse> NewMessage(Expression<Func<string>> customer, Expression<Func<string>> service, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = String.Format("/service/{0}/pipelines/actions", ExpressionConverter.ConvertWithUrlEncoding(service, 1));
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