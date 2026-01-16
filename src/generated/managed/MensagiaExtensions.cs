//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Mensagia
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class MensagiaActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mensagia")]
        public IBodyWorkflowAction<SendSmsResponse> SendSms(Expression<Func<string>> bodyconfigurationName, Expression<Func<string>> bodymessage, Expression<Func<string>> bodynumbers, Expression<Func<string>> bodystartDate = null, Expression<Func<string>> bodyurlParameters = null, Expression<Func<string>> bodyurlExtrafieldsMode = null)
        {
            var apiCallPath = "/push/simple";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Accept"] = Convert.ToString("application/json");
            callPayload.Headers["API-source"] = Convert.ToString("Power-Automate");
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["configuration_name"] = ExpressionConverter.ConvertO(bodyconfigurationName);
            bodypropCount++;
            body["message"] = ExpressionConverter.ConvertO(bodymessage);
            bodypropCount++;
            body["numbers"] = ExpressionConverter.ConvertO(bodynumbers);
            if (bodystartDate != null)
            {
                body["start_date"] = ExpressionConverter.ConvertO(bodystartDate);
                bodypropCount++;
            }

            if (bodyurlParameters != null)
            {
                body["url_parameters"] = ExpressionConverter.ConvertO(bodyurlParameters);
                bodypropCount++;
            }

            if (bodyurlExtrafieldsMode != null)
            {
                body["url_extrafields_mode"] = ExpressionConverter.ConvertO(bodyurlExtrafieldsMode);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<SendSmsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mensagia")]
        public IBodyWorkflowAction<SendSmsCampaignsResponse> SendSmsCampaigns(Expression<Func<string>> bodyconfigurationName, Expression<Func<string>> bodymessage, Expression<Func<string>> bodyavailableGroups, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodystartDate = null, Expression<Func<int>> bodysmsxblock = null, Expression<Func<int>> bodyminutesxblock = null, Expression<Func<string>> bodydays = null, Expression<Func<string>> bodytimeIntervals = null, Expression<Func<string>> bodyurlParameters = null, Expression<Func<string>> bodyurlExtrafieldsMode = null)
        {
            var apiCallPath = "/push/campaigns";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Accept"] = Convert.ToString("application/json");
            callPayload.Headers["API-source"] = Convert.ToString("Power-Automate");
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["configuration_name"] = ExpressionConverter.ConvertO(bodyconfigurationName);
            bodypropCount++;
            body["message"] = ExpressionConverter.ConvertO(bodymessage);
            if (bodyname != null)
            {
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                bodypropCount++;
            }

            bodypropCount++;
            body["available_groups"] = ExpressionConverter.ConvertO(bodyavailableGroups);
            if (bodystartDate != null)
            {
                body["start_date"] = ExpressionConverter.ConvertO(bodystartDate);
                bodypropCount++;
            }

            if (bodysmsxblock != null)
            {
                body["smsxblock"] = ExpressionConverter.ConvertO(bodysmsxblock);
                bodypropCount++;
            }

            if (bodyminutesxblock != null)
            {
                body["minutesxblock"] = ExpressionConverter.ConvertO(bodyminutesxblock);
                bodypropCount++;
            }

            if (bodydays != null)
            {
                body["days"] = ExpressionConverter.ConvertO(bodydays);
                bodypropCount++;
            }

            if (bodytimeIntervals != null)
            {
                body["time_intervals"] = ExpressionConverter.ConvertO(bodytimeIntervals);
                bodypropCount++;
            }

            if (bodyurlParameters != null)
            {
                body["url_parameters"] = ExpressionConverter.ConvertO(bodyurlParameters);
                bodypropCount++;
            }

            if (bodyurlExtrafieldsMode != null)
            {
                body["url_extrafields_mode"] = ExpressionConverter.ConvertO(bodyurlExtrafieldsMode);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<SendSmsCampaignsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mensagia")]
        public IBodyWorkflowAction<SendTransactionalEmailResponse> SendTransactionalEmail(Expression<Func<string>> bodyfrom, Expression<Func<string>> bodyto, Expression<Func<string>> bodysubject, Expression<Func<string>> bodyfromName = null, Expression<Func<string>> bodyhtml = null, Expression<Func<int>> bodytemplateId = null, Expression<Func<string>> bodystartDate = null, Expression<Func<string>> bodyurlParameters = null, Expression<Func<string>> bodyattachments = null)
        {
            var apiCallPath = "/email/simple";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Accept"] = Convert.ToString("application/json");
            callPayload.Headers["API-source"] = Convert.ToString("Power-Automate");
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["from"] = ExpressionConverter.ConvertO(bodyfrom);
            if (bodyfromName != null)
            {
                body["from_name"] = ExpressionConverter.ConvertO(bodyfromName);
                bodypropCount++;
            }

            bodypropCount++;
            body["to"] = ExpressionConverter.ConvertO(bodyto);
            bodypropCount++;
            body["subject"] = ExpressionConverter.ConvertO(bodysubject);
            if (bodyhtml != null)
            {
                body["html"] = ExpressionConverter.ConvertO(bodyhtml);
                bodypropCount++;
            }

            if (bodytemplateId != null)
            {
                body["template_id"] = ExpressionConverter.ConvertO(bodytemplateId);
                bodypropCount++;
            }

            if (bodystartDate != null)
            {
                body["start_date"] = ExpressionConverter.ConvertO(bodystartDate);
                bodypropCount++;
            }

            if (bodyurlParameters != null)
            {
                body["url_parameters"] = ExpressionConverter.ConvertO(bodyurlParameters);
                bodypropCount++;
            }

            if (bodyattachments != null)
            {
                body["attachments"] = ExpressionConverter.ConvertO(bodyattachments);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<SendTransactionalEmailResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mensagia")]
        public IBodyWorkflowAction<CreateContactResponse> CreateContact(Expression<Func<string>> bodynumber, Expression<Func<string>> bodyemail, Expression<Func<bool>> inMailBlacklist = null, Expression<Func<bool>> inSmsBlacklist = null, Expression<Func<bool>> inVoiceBlacklist = null, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodycity = null, Expression<Func<bodylanguageInput>> bodylanguage = null, Expression<Func<string>> bodygroups = null)
        {
            var apiCallPath = "/contacts";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["in_mail_blacklist"] = Convert.ToString(false);
            if (inMailBlacklist != null)
                callPayload.Queries["in_mail_blacklist"] = ExpressionConverter.Convert(inMailBlacklist);
            callPayload.Queries["in_sms_blacklist"] = Convert.ToString(false);
            if (inSmsBlacklist != null)
                callPayload.Queries["in_sms_blacklist"] = ExpressionConverter.Convert(inSmsBlacklist);
            callPayload.Queries["in_voice_blacklist"] = Convert.ToString(false);
            if (inVoiceBlacklist != null)
                callPayload.Queries["in_voice_blacklist"] = ExpressionConverter.Convert(inVoiceBlacklist);
            callPayload.Headers["Accept"] = Convert.ToString("application/json");
            callPayload.Headers["API-source"] = Convert.ToString("Power-Automate");
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["number"] = ExpressionConverter.ConvertO(bodynumber);
            if (bodyname != null)
            {
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                bodypropCount++;
            }

            bodypropCount++;
            body["email"] = ExpressionConverter.ConvertO(bodyemail);
            if (bodycity != null)
            {
                body["city"] = ExpressionConverter.ConvertO(bodycity);
                bodypropCount++;
            }

            if (bodylanguage != null)
            {
                body["language"] = ExpressionConverter.ConvertO(bodylanguage);
                bodypropCount++;
            }

            if (bodygroups != null)
            {
                body["groups"] = ExpressionConverter.ConvertO(bodygroups);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<CreateContactResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mensagia")]
        public IBodyWorkflowAction<Get2WaySmsResponse> Get2WaySms()
        {
            var apiCallPath = "/2-way-sms";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Accept"] = Convert.ToString("application/json");
            callPayload.Headers["API-source"] = Convert.ToString("Power-Automate");
            return new ApiConnectionAction<Get2WaySmsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mensagia")]
        public IBodyWorkflowAction<Get2WaySmsMessagesResponse> Get2WaySmsMessages()
        {
            var apiCallPath = "/2-way-sms/messages";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Accept"] = Convert.ToString("application/json");
            callPayload.Headers["API-source"] = Convert.ToString("Power-Automate");
            return new ApiConnectionAction<Get2WaySmsMessagesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mensagia")]
        public IBodyWorkflowAction<Send2WaySmsResponse> Send2WaySms(Expression<Func<string>> bodynumber, Expression<Func<string>> bodyenduserNumber, Expression<Func<string>> bodymessage)
        {
            var apiCallPath = "/2-way-sms/send";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Accept"] = Convert.ToString("application/json");
            callPayload.Headers["API-source"] = Convert.ToString("Power-Automate");
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["number"] = ExpressionConverter.ConvertO(bodynumber);
            bodypropCount++;
            body["enduser_number"] = ExpressionConverter.ConvertO(bodyenduserNumber);
            bodypropCount++;
            body["message"] = ExpressionConverter.ConvertO(bodymessage);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<Send2WaySmsResponse>(callPayload);
        }
    }

    public class MensagiaTriggers([ConnectionName] string connectionId)
    {
    }

    public class SendSmsResponse
    {
        [JsonProperty("data")]
        public SendSmsResponseDataType Data { get; set; }
    }

    public class SendSmsResponseDataType
    {
        [JsonProperty("configuration_id")]
        public int ConfigurationId { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("price")]
        public double Price { get; set; }

        [JsonProperty("price_with_packs")]
        public double PriceWithPacks { get; set; }

        [JsonProperty("push_sender_name")]
        public string PushSenderName { get; set; }

        [JsonProperty("route_name")]
        public string RouteName { get; set; }

        [JsonProperty("total_messages_sent")]
        public int TotalMessagesSent { get; set; }

        [JsonProperty("total_messages_sent_with_packs")]
        public int TotalMessagesSentWithPacks { get; set; }

        [JsonProperty("dlrs")]
        public SendSmsResponseDataTypeDlrsTypeItem[] Dlrs { get; set; }

        [JsonProperty("callback_url")]
        public string CallbackUrl { get; set; }

        [JsonProperty("start_date")]
        public string StartDate { get; set; }
    }

    public class SendSmsResponseDataTypeDlrsTypeItem
    {
        [JsonProperty("message_id")]
        public string MessageId { get; set; }

        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("messages_sent")]
        public int MessagesSent { get; set; }

        [JsonProperty("in_SMS_blacklist")]
        public bool InSMSBlacklist { get; set; }
    }

    public class SendSmsCampaignsResponse
    {
        [JsonProperty("data")]
        public SendSmsCampaignsResponseDataType Data { get; set; }
    }

    public class SendSmsCampaignsResponseDataType
    {
        [JsonProperty("configuration_id")]
        public int ConfigurationId { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("price")]
        public double Price { get; set; }

        [JsonProperty("price_with_packs")]
        public double PriceWithPacks { get; set; }

        [JsonProperty("push_sender_name")]
        public string PushSenderName { get; set; }

        [JsonProperty("route_name")]
        public string RouteName { get; set; }

        [JsonProperty("total_messages_sent")]
        public int TotalMessagesSent { get; set; }

        [JsonProperty("total_messages_sent_with_packs")]
        public int TotalMessagesSentWithPacks { get; set; }

        [JsonProperty("dlrs")]
        public SendSmsCampaignsResponseDataTypeDlrsTypeItem[] Dlrs { get; set; }

        [JsonProperty("callback_url")]
        public string CallbackUrl { get; set; }

        [JsonProperty("start_date")]
        public string StartDate { get; set; }
    }

    public class SendSmsCampaignsResponseDataTypeDlrsTypeItem
    {
        [JsonProperty("message_id")]
        public string MessageId { get; set; }

        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("messages_sent")]
        public int MessagesSent { get; set; }

        [JsonProperty("in_SMS_blacklist")]
        public bool InSMSBlacklist { get; set; }
    }

    public class SendTransactionalEmailResponse
    {
        [JsonProperty("data")]
        public SendTransactionalEmailResponseDataType Data { get; set; }
    }

    public class SendTransactionalEmailResponseDataType
    {
        [JsonProperty("app_configuration_id")]
        public int AppConfigurationId { get; set; }

        [JsonProperty("start_date")]
        public string StartDate { get; set; }

        [JsonProperty("domain_id")]
        public int DomainId { get; set; }

        [JsonProperty("sender_address_id")]
        public int SenderAddressId { get; set; }

        [JsonProperty("from")]
        public string From { get; set; }

        [JsonProperty("from_name")]
        public string FromName { get; set; }

        [JsonProperty("to")]
        public SendTransactionalEmailResponseDataTypeToType To { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("attachments")]
        public string[] Attachments { get; set; }
    }

    public class SendTransactionalEmailResponseDataTypeToType
    {
        [JsonProperty("valids")]
        public string[] Valids { get; set; }

        [JsonProperty("discardeds")]
        public string[] Discardeds { get; set; }

        [JsonProperty("blacklisteds")]
        public string[] Blacklisteds { get; set; }
    }

    public class CreateContactResponse
    {
        [JsonProperty("data")]
        public CreateContactResponseDataType Data { get; set; }
    }

    public class CreateContactResponseDataType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("push_operator_destination_id")]
        public string PushOperatorDestinationId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("country_id")]
        public int CountryId { get; set; }

        [JsonProperty("country_name")]
        public string CountryName { get; set; }

        [JsonProperty("in_sms_blacklist")]
        public bool InSmsBlacklist { get; set; }

        [JsonProperty("in_voice_blacklist")]
        public bool InVoiceBlacklist { get; set; }

        [JsonProperty("in_mail_blacklist")]
        public bool InMailBlacklist { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("groups")]
        public CreateContactResponseDataTypeGroupsType Groups { get; set; }
    }

    public class CreateContactResponseDataTypeGroupsType
    {
        [JsonProperty("data")]
        public CreateContactResponseDataTypeGroupsTypeDataTypeItem[] Data { get; set; }
    }

    public class CreateContactResponseDataTypeGroupsTypeDataTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("total_users")]
        public int TotalUsers { get; set; }

        [JsonProperty("busy")]
        public int Busy { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }
    }

    public enum bodylanguageInput
    {
        [EnumMember(Value = "en")]
        En,
        [EnumMember(Value = "en-gb")]
        EnGb,
        [EnumMember(Value = "en-au")]
        EnAu,
        [EnumMember(Value = "en-in")]
        EnIn,
        [EnumMember(Value = "en-gb-wls")]
        EnGbWls,
        [EnumMember(Value = "es")]
        Es,
        [EnumMember(Value = "ca")]
        Ca,
        [EnumMember(Value = "zh-cn")]
        ZhCn,
        [EnumMember(Value = "zh-tw")]
        ZhTw,
        [EnumMember(Value = "da")]
        Da,
        [EnumMember(Value = "nl")]
        Nl,
        [EnumMember(Value = "fr")]
        Fr,
        [EnumMember(Value = "de")]
        De,
        [EnumMember(Value = "it")]
        It,
        [EnumMember(Value = "ja")]
        Ja,
        [EnumMember(Value = "ko")]
        Ko,
        [EnumMember(Value = "no")]
        No,
        [EnumMember(Value = "pl")]
        Pl,
        [EnumMember(Value = "pt-pt")]
        PtPt,
        [EnumMember(Value = "pt-br")]
        PtBr,
        [EnumMember(Value = "ru")]
        Ru,
        [EnumMember(Value = "sv")]
        Sv,
        [EnumMember(Value = "fi")]
        Fi,
        [EnumMember(Value = "tr")]
        Tr,
        [EnumMember(Value = "wls")]
        Wls
    }

    public class Get2WaySmsResponse
    {
        [JsonProperty("data")]
        public Get2WaySmsResponseDataTypeItem[] Data { get; set; }

        [JsonProperty("meta")]
        public Get2WaySmsResponseMetaType Meta { get; set; }
    }

    public class Get2WaySmsResponseDataTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("callback_url")]
        public string CallbackUrl { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }
    }

    public class Get2WaySmsResponseMetaType
    {
        [JsonProperty("pagination")]
        public Get2WaySmsResponseMetaTypePaginationType Pagination { get; set; }
    }

    public class Get2WaySmsResponseMetaTypePaginationType
    {
        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("per_page")]
        public int PerPage { get; set; }

        [JsonProperty("current_page")]
        public int CurrentPage { get; set; }

        [JsonProperty("total_pages")]
        public int TotalPages { get; set; }

        [JsonProperty("links")]
        public string[] Links { get; set; }
    }

    public class Get2WaySmsMessagesResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("application_id")]
        public string ApplicationId { get; set; }

        [JsonProperty("configuration_id")]
        public int ConfigurationId { get; set; }

        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("enduser_number")]
        public string EnduserNumber { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }
    }

    public class Send2WaySmsResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("application_id")]
        public string ApplicationId { get; set; }

        [JsonProperty("configuration_id")]
        public int ConfigurationId { get; set; }

        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("enduser_number")]
        public string EnduserNumber { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk.Connectors
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Mensagia;

    public partial class WorkflowManagedActions
    {
        public MensagiaActions Mensagia(string connectionId) => new MensagiaActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public MensagiaTriggers Mensagia(string connectionId) => new MensagiaTriggers(connectionId);
    }
}