//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Vonage
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class VonageActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vonage")]
        [WorkflowExpressionFactory(nameof(__BuildVerifyRequest))]
        public IBodyWorkflowAction<VerifyRequestResponse> VerifyRequest([WorkflowExpression] Func<formatInput> format, [WorkflowExpression] Func<string> apiKey, [WorkflowExpression] Func<string> apiSecret, [WorkflowExpression] Func<string> number, [WorkflowExpression] Func<string> brand, [WorkflowExpression] Func<string> country = null, [WorkflowExpression] Func<string> senderId = null, [WorkflowExpression] Func<codeLengthInput> codeLength = null, [WorkflowExpression] Func<lgInput> lg = null, [WorkflowExpression] Func<int> pinExpiry = null, [WorkflowExpression] Func<int> nextEventWait = null, [WorkflowExpression] Func<workflowIdInput> workflowId = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vonage")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<VerifyRequestResponse> __BuildVerifyRequest(WorkflowExpression<formatInput> format, WorkflowExpression<string> apiKey, WorkflowExpression<string> apiSecret, WorkflowExpression<string> number, WorkflowExpression<string> brand, WorkflowExpression<string> country = null, WorkflowExpression<string> senderId = null, WorkflowExpression<codeLengthInput> codeLength = null, WorkflowExpression<lgInput> lg = null, WorkflowExpression<int> pinExpiry = null, WorkflowExpression<int> nextEventWait = null, WorkflowExpression<workflowIdInput> workflowId = null)
        {
            WorkflowExpression.Validate(format, nameof(format), required: true);
            WorkflowExpression.Validate(apiKey, nameof(apiKey), required: true);
            WorkflowExpression.Validate(apiSecret, nameof(apiSecret), required: true);
            WorkflowExpression.Validate(number, nameof(number), required: true);
            WorkflowExpression.Validate(brand, nameof(brand), required: true);
            WorkflowExpression.Validate(country, nameof(country), required: false);
            WorkflowExpression.Validate(senderId, nameof(senderId), required: false);
            WorkflowExpression.Validate(codeLength, nameof(codeLength), required: false);
            WorkflowExpression.Validate(lg, nameof(lg), required: false);
            WorkflowExpression.Validate(pinExpiry, nameof(pinExpiry), required: false);
            WorkflowExpression.Validate(nextEventWait, nameof(nextEventWait), required: false);
            WorkflowExpression.Validate(workflowId, nameof(workflowId), required: false);
            return new DeferredBodyAction<VerifyRequestResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/verify/{0}", ExpressionConverter.ConvertWithUrlEncoding(format, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<VerifyRequestResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vonage")]
        [WorkflowExpressionFactory(nameof(__BuildVerifyCheck))]
        public IBodyWorkflowAction<VerifyCheckResponse> VerifyCheck([WorkflowExpression] Func<formatInput> format, [WorkflowExpression] Func<string> apiKey, [WorkflowExpression] Func<string> apiSecret, [WorkflowExpression] Func<string> requestId, [WorkflowExpression] Func<string> code)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vonage")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<VerifyCheckResponse> __BuildVerifyCheck(WorkflowExpression<formatInput> format, WorkflowExpression<string> apiKey, WorkflowExpression<string> apiSecret, WorkflowExpression<string> requestId, WorkflowExpression<string> code)
        {
            WorkflowExpression.Validate(format, nameof(format), required: true);
            WorkflowExpression.Validate(apiKey, nameof(apiKey), required: true);
            WorkflowExpression.Validate(apiSecret, nameof(apiSecret), required: true);
            WorkflowExpression.Validate(requestId, nameof(requestId), required: true);
            WorkflowExpression.Validate(code, nameof(code), required: true);
            return new DeferredBodyAction<VerifyCheckResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/verify/check/{0}", ExpressionConverter.ConvertWithUrlEncoding(format, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<VerifyCheckResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vonage")]
        [WorkflowExpressionFactory(nameof(__BuildBasicNumberInsight))]
        public IBodyWorkflowAction<BasicNumberInsightResponse> BasicNumberInsight([WorkflowExpression] Func<formatInput> format, [WorkflowExpression] Func<string> apiKey, [WorkflowExpression] Func<string> apiSecret, [WorkflowExpression] Func<string> number, [WorkflowExpression] Func<string> country)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vonage")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BasicNumberInsightResponse> __BuildBasicNumberInsight(WorkflowExpression<formatInput> format, WorkflowExpression<string> apiKey, WorkflowExpression<string> apiSecret, WorkflowExpression<string> number, WorkflowExpression<string> country)
        {
            WorkflowExpression.Validate(format, nameof(format), required: true);
            WorkflowExpression.Validate(apiKey, nameof(apiKey), required: true);
            WorkflowExpression.Validate(apiSecret, nameof(apiSecret), required: true);
            WorkflowExpression.Validate(number, nameof(number), required: true);
            WorkflowExpression.Validate(country, nameof(country), required: true);
            return new DeferredBodyAction<BasicNumberInsightResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/ni/basic/{0}", ExpressionConverter.ConvertWithUrlEncoding(format, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api_key"] = ExpressionConverter.Convert(apiKey);
                callPayload.Queries["api_secret"] = ExpressionConverter.Convert(apiSecret);
                callPayload.Queries["number"] = ExpressionConverter.Convert(number);
                callPayload.Queries["country"] = ExpressionConverter.Convert(country);
                return new ApiConnectionAction<BasicNumberInsightResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vonage")]
        [WorkflowExpressionFactory(nameof(__BuildStandardNumberInsight))]
        public IBodyWorkflowAction<StandardNumberInsightResponse> StandardNumberInsight([WorkflowExpression] Func<formatInput> format, [WorkflowExpression] Func<string> apiKey, [WorkflowExpression] Func<string> apiSecret, [WorkflowExpression] Func<string> number, [WorkflowExpression] Func<string> country, [WorkflowExpression] Func<string> cnam = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vonage")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<StandardNumberInsightResponse> __BuildStandardNumberInsight(WorkflowExpression<formatInput> format, WorkflowExpression<string> apiKey, WorkflowExpression<string> apiSecret, WorkflowExpression<string> number, WorkflowExpression<string> country, WorkflowExpression<string> cnam = null)
        {
            WorkflowExpression.Validate(format, nameof(format), required: true);
            WorkflowExpression.Validate(apiKey, nameof(apiKey), required: true);
            WorkflowExpression.Validate(apiSecret, nameof(apiSecret), required: true);
            WorkflowExpression.Validate(number, nameof(number), required: true);
            WorkflowExpression.Validate(country, nameof(country), required: true);
            WorkflowExpression.Validate(cnam, nameof(cnam), required: false);
            return new DeferredBodyAction<StandardNumberInsightResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/ni/standard/{0}", ExpressionConverter.ConvertWithUrlEncoding(format, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api_key"] = ExpressionConverter.Convert(apiKey);
                callPayload.Queries["api_secret"] = ExpressionConverter.Convert(apiSecret);
                callPayload.Queries["number"] = ExpressionConverter.Convert(number);
                callPayload.Queries["country"] = ExpressionConverter.Convert(country);
                if (cnam != null)
                    callPayload.Queries["cnam"] = ExpressionConverter.Convert(cnam);
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

    public enum formatInput
    {
        [EnumMember(Value = "json")]
        Json,
        [EnumMember(Value = "xml")]
        Xml
    }

    public enum codeLengthInput
    {
        [EnumMember(Value = "4")]
        _4,
        [EnumMember(Value = "6")]
        _6
    }

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