//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.D7messaging
{
    using System.Linq.Expressions;
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
            var apiCallPath = "/hlr/v1/lookup";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["recipient"] = CSharpExpressionConverter.ConvertToken(bodyrecipient);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<NumberLookupResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "d7messaging")]
        public IBodyWorkflowAction<OTPSendOTPResponse> OTPSendOTP(Expression<Func<string>> bodyoriginator, Expression<Func<string>> bodyrecipient, Expression<Func<string>> bodycontent, Expression<Func<bodydataCodingInput>> bodydataCoding, Expression<Func<string>> bodyexpiry = null, Expression<Func<string>> bodyretryDelay = null, Expression<Func<string>> bodyretryCount = null, Expression<Func<string>> bodyotpCodeLength = null, Expression<Func<bodyotpTypeInput>> bodyotpType = null, Expression<Func<string>> bodysuccessUrl = null, Expression<Func<string>> bodyfailureUrl = null)
        {
            var apiCallPath = "/verify/v1/otp/send-otp";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["originator"] = CSharpExpressionConverter.ConvertToken(bodyoriginator);
            bodypropCount++;
            body["recipient"] = CSharpExpressionConverter.ConvertToken(bodyrecipient);
            bodypropCount++;
            body["content"] = CSharpExpressionConverter.ConvertToken(bodycontent);
            bodypropCount++;
            body["data_coding"] = CSharpExpressionConverter.Convert(bodydataCoding);
            if (bodyexpiry != null)
            {
                body["expiry"] = CSharpExpressionConverter.ConvertToken(bodyexpiry);
                bodypropCount++;
            }

            if (bodyretryDelay != null)
            {
                body["retry_delay"] = CSharpExpressionConverter.ConvertToken(bodyretryDelay);
                bodypropCount++;
            }

            if (bodyretryCount != null)
            {
                body["retry_count"] = CSharpExpressionConverter.ConvertToken(bodyretryCount);
                bodypropCount++;
            }

            if (bodyotpCodeLength != null)
            {
                body["otp_code_length"] = CSharpExpressionConverter.ConvertToken(bodyotpCodeLength);
                bodypropCount++;
            }

            if (bodyotpType != null)
            {
                body["otp_type"] = CSharpExpressionConverter.Convert(bodyotpType);
                bodypropCount++;
            }

            if (bodysuccessUrl != null)
            {
                body["success_url"] = CSharpExpressionConverter.ConvertToken(bodysuccessUrl);
                bodypropCount++;
            }

            if (bodyfailureUrl != null)
            {
                body["failure_url"] = CSharpExpressionConverter.ConvertToken(bodyfailureUrl);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<OTPSendOTPResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "d7messaging")]
        public IBodyWorkflowAction<OTPResendOTPResponse> OTPResendOTP(Expression<Func<string>> bodyotpId)
        {
            var apiCallPath = "/verify/v1/otp/resend-otp";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["otp_id"] = CSharpExpressionConverter.ConvertToken(bodyotpId);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<OTPResendOTPResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "d7messaging")]
        public IBodyWorkflowAction<OTPVerifyOTPResponse> OTPVerifyOTP(Expression<Func<string>> bodyotpCode, Expression<Func<string>> bodyotpId = null)
        {
            var apiCallPath = "/verify/v1/otp/verify-otp";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyotpId != null)
            {
                body["otp_id"] = CSharpExpressionConverter.ConvertToken(bodyotpId);
                bodypropCount++;
            }

            bodypropCount++;
            body["otp_code"] = CSharpExpressionConverter.ConvertToken(bodyotpCode);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<OTPVerifyOTPResponse>(callPayload);
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

    public enum bodydataCodingInput
    {
        [EnumMember(Value = "auto")]
        Auto,
        [EnumMember(Value = "text")]
        Text,
        [EnumMember(Value = "unicode")]
        Unicode
    }

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