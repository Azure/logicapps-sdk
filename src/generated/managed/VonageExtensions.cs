//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Vonage
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class VonageActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vonage")]
        public IBodyWorkflowAction<VerifyRequestResponse> VerifyRequest(Expression<Func<formatInput>> format, Expression<Func<string>> apiKey, Expression<Func<string>> apiSecret, Expression<Func<string>> number, Expression<Func<string>> brand, Expression<Func<string>> country = null, Expression<Func<string>> senderId = null, Expression<Func<codeLengthInput>> codeLength = null, Expression<Func<lgInput>> lg = null, Expression<Func<int>> pinExpiry = null, Expression<Func<int>> nextEventWait = null, Expression<Func<workflowIdInput>> workflowId = null)
        {
            var __workflow_format = WorkflowExpression.Compile(format, nameof(format), required: true);
            var __workflow_apiKey = WorkflowExpression.Compile(apiKey, nameof(apiKey), required: true);
            var __workflow_apiSecret = WorkflowExpression.Compile(apiSecret, nameof(apiSecret), required: true);
            var __workflow_number = WorkflowExpression.Compile(number, nameof(number), required: true);
            var __workflow_brand = WorkflowExpression.Compile(brand, nameof(brand), required: true);
            var __workflow_country = WorkflowExpression.Compile(country, nameof(country), required: false);
            var __workflow_senderId = WorkflowExpression.Compile(senderId, nameof(senderId), required: false);
            var __workflow_codeLength = WorkflowExpression.Compile(codeLength, nameof(codeLength), required: false);
            var __workflow_lg = WorkflowExpression.Compile(lg, nameof(lg), required: false);
            var __workflow_pinExpiry = WorkflowExpression.Compile(pinExpiry, nameof(pinExpiry), required: false);
            var __workflow_nextEventWait = WorkflowExpression.Compile(nextEventWait, nameof(nextEventWait), required: false);
            var __workflow_workflowId = WorkflowExpression.Compile(workflowId, nameof(workflowId), required: false);
            return new DeferredBodyAction<VerifyRequestResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/verify/{0}", __workflow_format.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<VerifyRequestResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vonage")]
        public IBodyWorkflowAction<VerifyCheckResponse> VerifyCheck(Expression<Func<formatInput>> format, Expression<Func<string>> apiKey, Expression<Func<string>> apiSecret, Expression<Func<string>> requestId, Expression<Func<string>> code)
        {
            var __workflow_format = WorkflowExpression.Compile(format, nameof(format), required: true);
            var __workflow_apiKey = WorkflowExpression.Compile(apiKey, nameof(apiKey), required: true);
            var __workflow_apiSecret = WorkflowExpression.Compile(apiSecret, nameof(apiSecret), required: true);
            var __workflow_requestId = WorkflowExpression.Compile(requestId, nameof(requestId), required: true);
            var __workflow_code = WorkflowExpression.Compile(code, nameof(code), required: true);
            return new DeferredBodyAction<VerifyCheckResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/verify/check/{0}", __workflow_format.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<VerifyCheckResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vonage")]
        public IBodyWorkflowAction<BasicNumberInsightResponse> BasicNumberInsight(Expression<Func<formatInput>> format, Expression<Func<string>> apiKey, Expression<Func<string>> apiSecret, Expression<Func<string>> number, Expression<Func<string>> country)
        {
            var __workflow_format = WorkflowExpression.Compile(format, nameof(format), required: true);
            var __workflow_apiKey = WorkflowExpression.Compile(apiKey, nameof(apiKey), required: true);
            var __workflow_apiSecret = WorkflowExpression.Compile(apiSecret, nameof(apiSecret), required: true);
            var __workflow_number = WorkflowExpression.Compile(number, nameof(number), required: true);
            var __workflow_country = WorkflowExpression.Compile(country, nameof(country), required: true);
            return new DeferredBodyAction<BasicNumberInsightResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/ni/basic/{0}", __workflow_format.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api_key"] = ExpressionConverter.Convert(__workflow_apiKey);
                callPayload.Queries["api_secret"] = ExpressionConverter.Convert(__workflow_apiSecret);
                callPayload.Queries["number"] = ExpressionConverter.Convert(__workflow_number);
                callPayload.Queries["country"] = ExpressionConverter.Convert(__workflow_country);
                return new ApiConnectionAction<BasicNumberInsightResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vonage")]
        public IBodyWorkflowAction<StandardNumberInsightResponse> StandardNumberInsight(Expression<Func<formatInput>> format, Expression<Func<string>> apiKey, Expression<Func<string>> apiSecret, Expression<Func<string>> number, Expression<Func<string>> country, Expression<Func<string>> cnam = null)
        {
            var __workflow_format = WorkflowExpression.Compile(format, nameof(format), required: true);
            var __workflow_apiKey = WorkflowExpression.Compile(apiKey, nameof(apiKey), required: true);
            var __workflow_apiSecret = WorkflowExpression.Compile(apiSecret, nameof(apiSecret), required: true);
            var __workflow_number = WorkflowExpression.Compile(number, nameof(number), required: true);
            var __workflow_country = WorkflowExpression.Compile(country, nameof(country), required: true);
            var __workflow_cnam = WorkflowExpression.Compile(cnam, nameof(cnam), required: false);
            return new DeferredBodyAction<StandardNumberInsightResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/ni/standard/{0}", __workflow_format.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api_key"] = ExpressionConverter.Convert(__workflow_apiKey);
                callPayload.Queries["api_secret"] = ExpressionConverter.Convert(__workflow_apiSecret);
                callPayload.Queries["number"] = ExpressionConverter.Convert(__workflow_number);
                callPayload.Queries["country"] = ExpressionConverter.Convert(__workflow_country);
                if (__workflow_cnam != null)
                    callPayload.Queries["cnam"] = ExpressionConverter.Convert(__workflow_cnam);
                return new ApiConnectionAction<StandardNumberInsightResponse>(callPayload);
            });
        }
    }

    public class VonageTriggers([ConnectionName] string connectionId)
    {
    }

    public class VerifyRequestResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("request_id")]
        public string RequestId { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum formatInput
    {
        [EnumMember(Value = "json")]
        Json,
        [EnumMember(Value = "xml")]
        Xml
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum codeLengthInput
    {
        [EnumMember(Value = "4")]
        _4,
        [EnumMember(Value = "6")]
        _6
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum lgInput
    {
        [EnumMember(Value = "ar-xa")]
        ArXa,
        [EnumMember(Value = "cs-cz")]
        CsCz,
        [EnumMember(Value = "cy-cy")]
        CyCy,
        [EnumMember(Value = "cy-gb")]
        CyGb,
        [EnumMember(Value = "da-dk")]
        DaDk,
        [EnumMember(Value = "de-de")]
        DeDe,
        [EnumMember(Value = "el-gr")]
        ElGr,
        [EnumMember(Value = "en-au")]
        EnAu,
        [EnumMember(Value = "en-gb")]
        EnGb,
        [EnumMember(Value = "en-in")]
        EnIn,
        [EnumMember(Value = "en-us")]
        EnUs,
        [EnumMember(Value = "es-es")]
        EsEs,
        [EnumMember(Value = "es-mx")]
        EsMx,
        [EnumMember(Value = "es-us")]
        EsUs,
        [EnumMember(Value = "fi-fi")]
        FiFi,
        [EnumMember(Value = "fil-ph")]
        FilPh,
        [EnumMember(Value = "fr-ca")]
        FrCa,
        [EnumMember(Value = "fr-fr")]
        FrFr,
        [EnumMember(Value = "hi-in")]
        HiIn,
        [EnumMember(Value = "hu-hu")]
        HuHu,
        [EnumMember(Value = "id-id")]
        IdId,
        [EnumMember(Value = "is-is")]
        IsIs,
        [EnumMember(Value = "it-it")]
        ItIt,
        [EnumMember(Value = "ja-jp")]
        JaJp,
        [EnumMember(Value = "ko-kr")]
        KoKr,
        [EnumMember(Value = "nb-no")]
        NbNo,
        [EnumMember(Value = "nl-nl")]
        NlNl,
        [EnumMember(Value = "pl-pl")]
        PlPl,
        [EnumMember(Value = "pt-br")]
        PtBr,
        [EnumMember(Value = "pt-pt")]
        PtPt,
        [EnumMember(Value = "ro-ro")]
        RoRo,
        [EnumMember(Value = "ru-ru")]
        RuRu,
        [EnumMember(Value = "sv-se")]
        SvSe,
        [EnumMember(Value = "th-th")]
        ThTh,
        [EnumMember(Value = "tr-tr")]
        TrTr,
        [EnumMember(Value = "vi-vn")]
        ViVn,
        [EnumMember(Value = "yue-cn")]
        YueCn,
        [EnumMember(Value = "zh-cn")]
        ZhCn,
        [EnumMember(Value = "zh-tw")]
        ZhTw
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum workflowIdInput
    {
        [EnumMember(Value = "1")]
        _1,
        [EnumMember(Value = "2")]
        _2,
        [EnumMember(Value = "3")]
        _3,
        [EnumMember(Value = "4")]
        _4,
        [EnumMember(Value = "5")]
        _5,
        [EnumMember(Value = "6")]
        _6,
        [EnumMember(Value = "7")]
        _7
    }

    public class VerifyCheckResponse
    {
        [JsonProperty("request_id")]
        public string RequestId { get; set; }

        [JsonProperty("event_id")]
        public string EventId { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("price")]
        public string Price { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("estimated_price_messages_sent")]
        public string EstimatedPriceMessagesSent { get; set; }
    }

    public class BasicNumberInsightResponse
    {
        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("status_message")]
        public string StatusMessage { get; set; }

        [JsonProperty("request_id")]
        public string RequestId { get; set; }

        [JsonProperty("international_format_number")]
        public string InternationalFormatNumber { get; set; }

        [JsonProperty("national_format_number")]
        public string NationalFormatNumber { get; set; }

        [JsonProperty("country_code")]
        public string CountryCode { get; set; }

        [JsonProperty("country_code_iso3")]
        public string CountryCodeIso3 { get; set; }

        [JsonProperty("country_name")]
        public string CountryName { get; set; }

        [JsonProperty("country_prefix")]
        public string CountryPrefix { get; set; }
    }

    public class StandardNumberInsightResponse
    {
        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("status_message")]
        public string StatusMessage { get; set; }

        [JsonProperty("request_id")]
        public string RequestId { get; set; }

        [JsonProperty("international_format_number")]
        public string InternationalFormatNumber { get; set; }

        [JsonProperty("national_format_number")]
        public string NationalFormatNumber { get; set; }

        [JsonProperty("country_code")]
        public string CountryCode { get; set; }

        [JsonProperty("country_code_iso3")]
        public string CountryCodeIso3 { get; set; }

        [JsonProperty("country_name")]
        public string CountryName { get; set; }

        [JsonProperty("country_prefix")]
        public string CountryPrefix { get; set; }

        [JsonProperty("request_price")]
        public string RequestPrice { get; set; }

        [JsonProperty("refund_price")]
        public string RefundPrice { get; set; }

        [JsonProperty("remaining_balance")]
        public string RemainingBalance { get; set; }

        [JsonProperty("current_carrier")]
        public StandardNumberInsightResponseCurrentCarrierType CurrentCarrier { get; set; }

        [JsonProperty("original_carrier")]
        public StandardNumberInsightResponseOriginalCarrierType OriginalCarrier { get; set; }

        [JsonProperty("ported")]
        public string Ported { get; set; }

        [JsonProperty("caller_identity")]
        public StandardNumberInsightResponseCallerIdentityType CallerIdentity { get; set; }

        [JsonProperty("caller_name")]
        public string CallerName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("caller_type")]
        public string CallerType { get; set; }
    }

    public class StandardNumberInsightResponseCurrentCarrierType
    {
        [JsonProperty("network_code")]
        public string NetworkCode { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("network_type")]
        public string NetworkType { get; set; }
    }

    public class StandardNumberInsightResponseOriginalCarrierType
    {
        [JsonProperty("network_code")]
        public string NetworkCode { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("network_type")]
        public string NetworkType { get; set; }
    }

    public class StandardNumberInsightResponseCallerIdentityType
    {
        [JsonProperty("caller_type")]
        public string CallerType { get; set; }

        [JsonProperty("caller_name")]
        public string CallerName { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Vonage;

    public partial class WorkflowManagedActions
    {
        public VonageActions Vonage(string connectionId) => new VonageActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public VonageTriggers Vonage(string connectionId) => new VonageTriggers(connectionId);
    }
}
