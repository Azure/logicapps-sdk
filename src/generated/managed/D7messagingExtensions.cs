//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.D7messaging
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class D7messagingActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "d7messaging")]
        public IBodyWorkflowAction<D7BalanceResponse> D7Balance()
        {
            var apiCallPath = "/messages/v1/balance";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<D7BalanceResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "d7messaging")]
        public IBodyWorkflowAction<NumberLookupResponse> NumberLookup(Expression<Func<string>> bodyrecipient)
        {
            var __workflow_bodyrecipient = WorkflowExpression.Compile(bodyrecipient, nameof(bodyrecipient), required: true);
            return new DeferredBodyAction<NumberLookupResponse>(() =>
            {
                var apiCallPath = "/hlr/v1/lookup";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["recipient"] = ExpressionConverter.ConvertO(__workflow_bodyrecipient);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<NumberLookupResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "d7messaging")]
        public IBodyWorkflowAction<OTPSendOTPResponse> OTPSendOTP(Expression<Func<string>> bodyoriginator, Expression<Func<string>> bodyrecipient, Expression<Func<string>> bodycontent, Expression<Func<bodydataCodingInput>> bodydataCoding, Expression<Func<string>> bodyexpiry = null, Expression<Func<string>> bodyretryDelay = null, Expression<Func<string>> bodyretryCount = null, Expression<Func<string>> bodyotpCodeLength = null, Expression<Func<bodyotpTypeInput>> bodyotpType = null, Expression<Func<string>> bodysuccessUrl = null, Expression<Func<string>> bodyfailureUrl = null)
        {
            var __workflow_bodyoriginator = WorkflowExpression.Compile(bodyoriginator, nameof(bodyoriginator), required: true);
            var __workflow_bodyrecipient = WorkflowExpression.Compile(bodyrecipient, nameof(bodyrecipient), required: true);
            var __workflow_bodycontent = WorkflowExpression.Compile(bodycontent, nameof(bodycontent), required: true);
            var __workflow_bodydataCoding = WorkflowExpression.Compile(bodydataCoding, nameof(bodydataCoding), required: true);
            var __workflow_bodyexpiry = WorkflowExpression.Compile(bodyexpiry, nameof(bodyexpiry), required: false);
            var __workflow_bodyretryDelay = WorkflowExpression.Compile(bodyretryDelay, nameof(bodyretryDelay), required: false);
            var __workflow_bodyretryCount = WorkflowExpression.Compile(bodyretryCount, nameof(bodyretryCount), required: false);
            var __workflow_bodyotpCodeLength = WorkflowExpression.Compile(bodyotpCodeLength, nameof(bodyotpCodeLength), required: false);
            var __workflow_bodyotpType = WorkflowExpression.Compile(bodyotpType, nameof(bodyotpType), required: false);
            var __workflow_bodysuccessUrl = WorkflowExpression.Compile(bodysuccessUrl, nameof(bodysuccessUrl), required: false);
            var __workflow_bodyfailureUrl = WorkflowExpression.Compile(bodyfailureUrl, nameof(bodyfailureUrl), required: false);
            return new DeferredBodyAction<OTPSendOTPResponse>(() =>
            {
                var apiCallPath = "/verify/v1/otp/send-otp";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["originator"] = ExpressionConverter.ConvertO(__workflow_bodyoriginator);
                bodypropCount++;
                body["recipient"] = ExpressionConverter.ConvertO(__workflow_bodyrecipient);
                bodypropCount++;
                body["content"] = ExpressionConverter.ConvertO(__workflow_bodycontent);
                bodypropCount++;
                body["data_coding"] = ExpressionConverter.ConvertO(__workflow_bodydataCoding);
                if (__workflow_bodyexpiry != null)
                {
                    body["expiry"] = ExpressionConverter.ConvertO(__workflow_bodyexpiry);
                    bodypropCount++;
                }

                if (__workflow_bodyretryDelay != null)
                {
                    body["retry_delay"] = ExpressionConverter.ConvertO(__workflow_bodyretryDelay);
                    bodypropCount++;
                }

                if (__workflow_bodyretryCount != null)
                {
                    body["retry_count"] = ExpressionConverter.ConvertO(__workflow_bodyretryCount);
                    bodypropCount++;
                }

                if (__workflow_bodyotpCodeLength != null)
                {
                    body["otp_code_length"] = ExpressionConverter.ConvertO(__workflow_bodyotpCodeLength);
                    bodypropCount++;
                }

                if (__workflow_bodyotpType != null)
                {
                    body["otp_type"] = ExpressionConverter.ConvertO(__workflow_bodyotpType);
                    bodypropCount++;
                }

                if (__workflow_bodysuccessUrl != null)
                {
                    body["success_url"] = ExpressionConverter.ConvertO(__workflow_bodysuccessUrl);
                    bodypropCount++;
                }

                if (__workflow_bodyfailureUrl != null)
                {
                    body["failure_url"] = ExpressionConverter.ConvertO(__workflow_bodyfailureUrl);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<OTPSendOTPResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "d7messaging")]
        public IBodyWorkflowAction<OTPResendOTPResponse> OTPResendOTP(Expression<Func<string>> bodyotpId)
        {
            var __workflow_bodyotpId = WorkflowExpression.Compile(bodyotpId, nameof(bodyotpId), required: true);
            return new DeferredBodyAction<OTPResendOTPResponse>(() =>
            {
                var apiCallPath = "/verify/v1/otp/resend-otp";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["otp_id"] = ExpressionConverter.ConvertO(__workflow_bodyotpId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<OTPResendOTPResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "d7messaging")]
        public IBodyWorkflowAction<OTPVerifyOTPResponse> OTPVerifyOTP(Expression<Func<string>> bodyotpCode, Expression<Func<string>> bodyotpId = null)
        {
            var __workflow_bodyotpCode = WorkflowExpression.Compile(bodyotpCode, nameof(bodyotpCode), required: true);
            var __workflow_bodyotpId = WorkflowExpression.Compile(bodyotpId, nameof(bodyotpId), required: false);
            return new DeferredBodyAction<OTPVerifyOTPResponse>(() =>
            {
                var apiCallPath = "/verify/v1/otp/verify-otp";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyotpId != null)
                {
                    body["otp_id"] = ExpressionConverter.ConvertO(__workflow_bodyotpId);
                    bodypropCount++;
                }

                bodypropCount++;
                body["otp_code"] = ExpressionConverter.ConvertO(__workflow_bodyotpCode);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<OTPVerifyOTPResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }
    }

    public class D7messagingTriggers([ConnectionName] string connectionId)
    {
    }

    public class D7BalanceResponse
    {
        [JsonProperty("balance")]
        public double Balance { get; set; }
    }

    public class NumberLookupResponse
    {
        [JsonProperty("country_code")]
        public string CountryCode { get; set; }

        [JsonProperty("country_code_iso3")]
        public string CountryCodeIso3 { get; set; }

        [JsonProperty("recipient")]
        public string Recipient { get; set; }

        [JsonProperty("reachable")]
        public string Reachable { get; set; }

        [JsonProperty("network")]
        public string Network { get; set; }

        [JsonProperty("mcc")]
        public int Mcc { get; set; }

        [JsonProperty("mnc")]
        public int Mnc { get; set; }

        [JsonProperty("ported")]
        public bool Ported { get; set; }

        [JsonProperty("cic")]
        public string Cic { get; set; }

        [JsonProperty("imsi")]
        public string Imsi { get; set; }

        [JsonProperty("ocn")]
        public string Ocn { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("request_id")]
        public string RequestId { get; set; }

        [JsonProperty("status_code")]
        public int StatusCode { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class OTPSendOTPResponse
    {
        [JsonProperty("otp_id")]
        public string OtpId { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("expiry")]
        public int Expiry { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodydataCodingInput
    {
        [EnumMember(Value = "auto")]
        Auto,
        [EnumMember(Value = "text")]
        Text,
        [EnumMember(Value = "unicode")]
        Unicode
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyotpTypeInput
    {
        [EnumMember(Value = "numeric")]
        Numeric,
        [EnumMember(Value = "alpha")]
        Alpha,
        [EnumMember(Value = "alphanumeric")]
        Alphanumeric
    }

    public class OTPResendOTPResponse
    {
        [JsonProperty("otp_id")]
        public string OtpId { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("expiry")]
        public int Expiry { get; set; }

        [JsonProperty("resend_count")]
        public int ResendCount { get; set; }
    }

    public class OTPVerifyOTPResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.D7messaging;

    public partial class WorkflowManagedActions
    {
        public D7messagingActions D7messaging(string connectionId) => new D7messagingActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public D7messagingTriggers D7messaging(string connectionId) => new D7messagingTriggers(connectionId);
    }
}
