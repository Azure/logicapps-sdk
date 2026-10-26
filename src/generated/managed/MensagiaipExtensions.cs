//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Mensagiaip
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class MensagiaipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mensagiaip")]
        public IBodyWorkflowAction<SendSmsResponse, ApiConnectionActionConfiguration> SendSms(Expression<Func<SendSmsInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<SendSmsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/push/simple";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["API-source"] = Convert.ToString("Power-Automate");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SendSmsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mensagiaip")]
        public IBodyWorkflowAction<SendSmsCampaignsResponse, ApiConnectionActionConfiguration> SendSmsCampaigns(Expression<Func<SendSmsCampaignsInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<SendSmsCampaignsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/push/campaigns";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["API-source"] = Convert.ToString("Power-Automate");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SendSmsCampaignsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mensagiaip")]
        public IBodyWorkflowAction<SendTransactionalEmailResponse, ApiConnectionActionConfiguration> SendTransactionalEmail(Expression<Func<SendTransactionalEmailInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<SendTransactionalEmailResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/email/simple";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["Api-source"] = Convert.ToString("Power-Automate");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SendTransactionalEmailResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mensagiaip")]
        public IBodyWorkflowAction<SendVoiceMessageResponse, ApiConnectionActionConfiguration> SendVoiceMessage(Expression<Func<SendVoiceMessageInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<SendVoiceMessageResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/voice/messages";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["API-source"] = Convert.ToString("Power-Automate");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SendVoiceMessageResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mensagiaip")]
        public IBodyWorkflowAction<CreateContactResponse, ApiConnectionActionConfiguration> CreateContact(Expression<Func<CreateContactInput>> body, Expression<Func<bool>> inMailBlacklist = null, Expression<Func<bool>> inSmsBlacklist = null, Expression<Func<bool>> inVoiceBlacklist = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            var __workflow_inMailBlacklist = WorkflowExpression.Compile(inMailBlacklist, nameof(inMailBlacklist), required: false);
            var __workflow_inSmsBlacklist = WorkflowExpression.Compile(inSmsBlacklist, nameof(inSmsBlacklist), required: false);
            var __workflow_inVoiceBlacklist = WorkflowExpression.Compile(inVoiceBlacklist, nameof(inVoiceBlacklist), required: false);
            return new DeferredBodyAction<CreateContactResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/contacts";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["in_mail_blacklist"] = Convert.ToString(false);
                if (__workflow_inMailBlacklist != null)
                    callPayload.Queries["in_mail_blacklist"] = ExpressionConverter.Convert(__workflow_inMailBlacklist);
                callPayload.Queries["in_sms_blacklist"] = Convert.ToString(false);
                if (__workflow_inSmsBlacklist != null)
                    callPayload.Queries["in_sms_blacklist"] = ExpressionConverter.Convert(__workflow_inSmsBlacklist);
                callPayload.Queries["in_voice_blacklist"] = Convert.ToString(false);
                if (__workflow_inVoiceBlacklist != null)
                    callPayload.Queries["in_voice_blacklist"] = ExpressionConverter.Convert(__workflow_inVoiceBlacklist);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["API-source"] = Convert.ToString("Power-Automate");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateContactResponse>(callPayload);
            });
        }
    }

    public class MensagiaipTriggers([ConnectionName] string connectionId)
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

    public class SendSmsInput
    {
        [JsonProperty("configuration_name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ConfigurationName { get; set; }

        [JsonProperty("message", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Message { get; set; }

        [JsonProperty("numbers", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Numbers { get; set; }

        [JsonProperty("start_date")]
        public string StartDate { get; set; }

        [JsonProperty("url_parameters")]
        public string UrlParameters { get; set; }

        [JsonProperty("url_extrafields_mode")]
        public string UrlExtrafieldsMode { get; set; }
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

    public class SendSmsCampaignsInput
    {
        [JsonProperty("configuration_name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ConfigurationName { get; set; }

        [JsonProperty("message", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Message { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("available_groups", DefaultValueHandling = DefaultValueHandling.Include)]
        public string AvailableGroups { get; set; }

        [JsonProperty("start_date")]
        public string StartDate { get; set; }

        [JsonProperty("smsxblock")]
        public int? Smsxblock { get; set; }

        [JsonProperty("minutesxblock")]
        public int? Minutesxblock { get; set; }

        [JsonProperty("days")]
        public string Days { get; set; }

        [JsonProperty("time_intervals")]
        public string TimeIntervals { get; set; }

        [JsonProperty("url_parameters")]
        public string UrlParameters { get; set; }

        [JsonProperty("url_extrafields_mode")]
        public string UrlExtrafieldsMode { get; set; }
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

    public class SendTransactionalEmailInput
    {
        [JsonProperty("from", DefaultValueHandling = DefaultValueHandling.Include)]
        public string From { get; set; }

        [JsonProperty("from_name")]
        public string FromName { get; set; }

        [JsonProperty("to", DefaultValueHandling = DefaultValueHandling.Include)]
        public string To { get; set; }

        [JsonProperty("subject", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Subject { get; set; }

        [JsonProperty("html")]
        public string Html { get; set; }

        [JsonProperty("template_id")]
        public int? TemplateId { get; set; }

        [JsonProperty("start_date")]
        public string StartDate { get; set; }

        [JsonProperty("url_parameters")]
        public string UrlParameters { get; set; }

        [JsonProperty("attachments")]
        public string Attachments { get; set; }
    }

    public class SendVoiceMessageResponse
    {
        [JsonProperty("data")]
        public SendVoiceMessageResponseDataType Data { get; set; }
    }

    public class SendVoiceMessageResponseDataType
    {
        [JsonProperty("configuration_id")]
        public int ConfigurationId { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("active")]
        public int Active { get; set; }

        [JsonProperty("state_id")]
        public int StateId { get; set; }

        [JsonProperty("state_name")]
        public string StateName { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("start_date")]
        public string StartDate { get; set; }

        [JsonProperty("vm_validated_phone_id")]
        public int VmValidatedPhoneId { get; set; }

        [JsonProperty("vm_validated_phone_number")]
        public string VmValidatedPhoneNumber { get; set; }

        [JsonProperty("groups")]
        public SendVoiceMessageResponseDataTypeGroupsTypeItem[] Groups { get; set; }

        [JsonProperty("numbers")]
        public string Numbers { get; set; }

        [JsonProperty("vm_timeout")]
        public int VmTimeout { get; set; }

        [JsonProperty("max_retries")]
        public int MaxRetries { get; set; }

        [JsonProperty("min_retry_minutes")]
        public int MinRetryMinutes { get; set; }

        [JsonProperty("max_retry_minutes")]
        public int MaxRetryMinutes { get; set; }

        [JsonProperty("response_codes")]
        public SendVoiceMessageResponseDataTypeResponseCodesTypeItem[] ResponseCodes { get; set; }

        [JsonProperty("response_codes_timeout")]
        public string ResponseCodesTimeout { get; set; }

        [JsonProperty("callback_url")]
        public string CallbackUrl { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("callsxblock")]
        public int Callsxblock { get; set; }

        [JsonProperty("minutesxblock")]
        public int Minutesxblock { get; set; }

        [JsonProperty("days_allowed")]
        public string[] DaysAllowed { get; set; }

        [JsonProperty("time_intervals_allowed")]
        public string[] TimeIntervalsAllowed { get; set; }

        [JsonProperty("ring_timeout")]
        public int RingTimeout { get; set; }
    }

    public class SendVoiceMessageResponseDataTypeGroupsTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class SendVoiceMessageResponseDataTypeResponseCodesTypeItem
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("action")]
        public string Action { get; set; }

        [JsonProperty("transfer_to")]
        public string TransferTo { get; set; }

        [JsonProperty("vm_validated_phone_id")]
        public string VmValidatedPhoneId { get; set; }
    }

    public class SendVoiceMessageInput
    {
        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("vm_validated_phone_id", DefaultValueHandling = DefaultValueHandling.Include)]
        public int VmValidatedPhoneId { get; set; }

        [JsonProperty("type_locution", DefaultValueHandling = DefaultValueHandling.Include)]
        public SendVoiceMessageInputTypeLocutionType TypeLocution { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("message_language", DefaultValueHandling = DefaultValueHandling.Include)]
        public SendVoiceMessageInputMessageLanguageType? MessageLanguage { get; set; } = SendVoiceMessageInputMessageLanguageType.En;

        [JsonProperty("voice_file_id")]
        public string VoiceFileId { get; set; }

        [JsonProperty("numbers")]
        public string Numbers { get; set; }

        [JsonProperty("available_groups")]
        public string AvailableGroups { get; set; }

        [JsonProperty("vm_timeout", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? VmTimeout { get; set; } = 30;

        [JsonProperty("max_retries", DefaultValueHandling = DefaultValueHandling.Include)]
        public SendVoiceMessageInputMaxRetriesType? MaxRetries { get; set; } = SendVoiceMessageInputMaxRetriesType._0;

        [JsonProperty("minutes_retry_1")]
        public SendVoiceMessageInputMinutesRetry1Type? MinutesRetry1 { get; set; }

        [JsonProperty("minutes_retry_2")]
        public SendVoiceMessageInputMinutesRetry2Type? MinutesRetry2 { get; set; }

        [JsonProperty("minutes_retry_3")]
        public SendVoiceMessageInputMinutesRetry3Type? MinutesRetry3 { get; set; }

        [JsonProperty("minutes_retry_4")]
        public SendVoiceMessageInputMinutesRetry4Type? MinutesRetry4 { get; set; }

        [JsonProperty("ring_timeout")]
        public int? RingTimeout { get; set; }

        [JsonProperty("response_codes")]
        public string ResponseCodes { get; set; }

        [JsonProperty("response_codes_timeout")]
        public int? ResponseCodesTimeout { get; set; }

        [JsonProperty("start_date")]
        public string StartDate { get; set; }

        [JsonProperty("callsxblock")]
        public int? Callsxblock { get; set; }

        [JsonProperty("minutesxblock")]
        public int? Minutesxblock { get; set; }

        [JsonProperty("days")]
        public SendVoiceMessageInputDaysType? Days { get; set; }

        [JsonProperty("time_intervals")]
        public string TimeIntervals { get; set; }
    }

    public class SendVoiceMessageInputTypeLocutionType
    {
        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Include)]
        public SendVoiceMessageInputTypeLocutionTypeTypeType Type { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SendVoiceMessageInputTypeLocutionTypeTypeType
    {
        [EnumMember(Value = "text2speech")]
        Text2speech,
        [EnumMember(Value = "file")]
        File
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SendVoiceMessageInputMessageLanguageType
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

    public enum SendVoiceMessageInputMaxRetriesType
    {
        _0 = 0,
        _1 = 1,
        _2 = 2,
        _3 = 3,
        _4 = 4
    }

    public enum SendVoiceMessageInputMinutesRetry1Type
    {
        _1 = 1,
        _2 = 2,
        _5 = 5,
        _10 = 10,
        _20 = 20,
        _30 = 30,
        _60 = 60,
        _120 = 120,
        _240 = 240,
        _480 = 480,
        _960 = 960,
        _1440 = 1440
    }

    public enum SendVoiceMessageInputMinutesRetry2Type
    {
        _1 = 1,
        _2 = 2,
        _5 = 5,
        _10 = 10,
        _20 = 20,
        _30 = 30,
        _60 = 60,
        _120 = 120,
        _240 = 240,
        _480 = 480,
        _960 = 960,
        _1440 = 1440
    }

    public enum SendVoiceMessageInputMinutesRetry3Type
    {
        _1 = 1,
        _2 = 2,
        _5 = 5,
        _10 = 10,
        _20 = 20,
        _30 = 30,
        _60 = 60,
        _120 = 120,
        _240 = 240,
        _480 = 480,
        _960 = 960,
        _1440 = 1440
    }

    public enum SendVoiceMessageInputMinutesRetry4Type
    {
        _1 = 1,
        _2 = 2,
        _5 = 5,
        _10 = 10,
        _20 = 20,
        _30 = 30,
        _60 = 60,
        _120 = 120,
        _240 = 240,
        _480 = 480,
        _960 = 960,
        _1440 = 1440
    }

    public enum SendVoiceMessageInputDaysType
    {
        _1 = 1,
        _2 = 2,
        _5 = 5,
        _10 = 10,
        _20 = 20,
        _30 = 30,
        _60 = 60,
        _120 = 120,
        _240 = 240,
        _480 = 480,
        _960 = 960,
        _1440 = 1440
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

    public class CreateContactInput
    {
        [JsonProperty("number", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Number { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("email", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Email { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("language", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateContactInputLanguageType? Language { get; set; } = CreateContactInputLanguageType.En;

        [JsonProperty("groups")]
        public string Groups { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateContactInputLanguageType
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
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Mensagiaip;

    public partial class WorkflowManagedActions
    {
        public MensagiaipActions Mensagiaip(string connectionId) => new MensagiaipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public MensagiaipTriggers Mensagiaip(string connectionId) => new MensagiaipTriggers(connectionId);
    }
}