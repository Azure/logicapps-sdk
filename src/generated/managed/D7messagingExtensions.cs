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
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/messages/v1/balance";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<D7BalanceResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "d7messaging")]
        public IBodyWorkflowAction<NumberLookupResponse> NumberLookup([WorkflowExpression] Func<string> bodyrecipient)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/hlr/v1/lookup";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["recipient"] = SourceExpressionConverter.ConvertToken(bodyrecipient);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<NumberLookupResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "d7messaging")]
        public IBodyWorkflowAction<OTPSendOTPResponse> OTPSendOTP([WorkflowExpression] Func<string> bodyoriginator, [WorkflowExpression] Func<string> bodyrecipient, [WorkflowExpression] Func<string> bodycontent, [WorkflowExpression] Func<bodydataCodingInput> bodydataCoding, [WorkflowExpression] Func<string> bodyexpiry = null, [WorkflowExpression] Func<string> bodyretryDelay = null, [WorkflowExpression] Func<string> bodyretryCount = null, [WorkflowExpression] Func<string> bodyotpCodeLength = null, [WorkflowExpression] Func<bodyotpTypeInput> bodyotpType = null, [WorkflowExpression] Func<string> bodysuccessUrl = null, [WorkflowExpression] Func<string> bodyfailureUrl = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/verify/v1/otp/send-otp";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["originator"] = SourceExpressionConverter.ConvertToken(bodyoriginator);
                bodypropCount++;
                body["recipient"] = SourceExpressionConverter.ConvertToken(bodyrecipient);
                bodypropCount++;
                body["content"] = SourceExpressionConverter.ConvertToken(bodycontent);
                bodypropCount++;
                body["data_coding"] = SourceExpressionConverter.Convert(bodydataCoding);
                if (bodyexpiry != null)
                {
                    body["expiry"] = SourceExpressionConverter.ConvertToken(bodyexpiry);
                    bodypropCount++;
                }

                if (bodyretryDelay != null)
                {
                    body["retry_delay"] = SourceExpressionConverter.ConvertToken(bodyretryDelay);
                    bodypropCount++;
                }

                if (bodyretryCount != null)
                {
                    body["retry_count"] = SourceExpressionConverter.ConvertToken(bodyretryCount);
                    bodypropCount++;
                }

                if (bodyotpCodeLength != null)
                {
                    body["otp_code_length"] = SourceExpressionConverter.ConvertToken(bodyotpCodeLength);
                    bodypropCount++;
                }

                if (bodyotpType != null)
                {
                    body["otp_type"] = SourceExpressionConverter.Convert(bodyotpType);
                    bodypropCount++;
                }

                if (bodysuccessUrl != null)
                {
                    body["success_url"] = SourceExpressionConverter.ConvertToken(bodysuccessUrl);
                    bodypropCount++;
                }

                if (bodyfailureUrl != null)
                {
                    body["failure_url"] = SourceExpressionConverter.ConvertToken(bodyfailureUrl);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<OTPSendOTPResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "d7messaging")]
        public IBodyWorkflowAction<OTPResendOTPResponse> OTPResendOTP([WorkflowExpression] Func<string> bodyotpId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/verify/v1/otp/resend-otp";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["otp_id"] = SourceExpressionConverter.ConvertToken(bodyotpId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<OTPResendOTPResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "d7messaging")]
        public IBodyWorkflowAction<OTPVerifyOTPResponse> OTPVerifyOTP([WorkflowExpression] Func<string> bodyotpCode, [WorkflowExpression] Func<string> bodyotpId = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/verify/v1/otp/verify-otp";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyotpId != null)
                {
                    body["otp_id"] = SourceExpressionConverter.ConvertToken(bodyotpId);
                    bodypropCount++;
                }

                bodypropCount++;
                body["otp_code"] = SourceExpressionConverter.ConvertToken(bodyotpCode);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<OTPVerifyOTPResponse>(BuildSourceInput);
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