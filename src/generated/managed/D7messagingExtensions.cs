//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.D7messaging
{
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
        [WorkflowExpressionFactory(nameof(__BuildNumberLookup))]
        public IBodyWorkflowAction<NumberLookupResponse> NumberLookup([WorkflowExpression] Func<string> bodyrecipient)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "d7messaging")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<NumberLookupResponse> __BuildNumberLookup(WorkflowExpression<string> bodyrecipient)
        {
            WorkflowExpression.Validate(bodyrecipient, nameof(bodyrecipient), required: true);
            return new DeferredBodyAction<NumberLookupResponse>(() =>
            {
                var apiCallPath = "/hlr/v1/lookup";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["recipient"] = ExpressionConverter.ConvertO(bodyrecipient);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<NumberLookupResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "d7messaging")]
        [WorkflowExpressionFactory(nameof(__BuildOTPSendOTP))]
        public IBodyWorkflowAction<OTPSendOTPResponse> OTPSendOTP([WorkflowExpression] Func<string> bodyoriginator, [WorkflowExpression] Func<string> bodyrecipient, [WorkflowExpression] Func<string> bodycontent, [WorkflowExpression] Func<bodydataCodingInput> bodydataCoding, [WorkflowExpression] Func<string> bodyexpiry = null, [WorkflowExpression] Func<string> bodyretryDelay = null, [WorkflowExpression] Func<string> bodyretryCount = null, [WorkflowExpression] Func<string> bodyotpCodeLength = null, [WorkflowExpression] Func<bodyotpTypeInput> bodyotpType = null, [WorkflowExpression] Func<string> bodysuccessUrl = null, [WorkflowExpression] Func<string> bodyfailureUrl = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "d7messaging")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<OTPSendOTPResponse> __BuildOTPSendOTP(WorkflowExpression<string> bodyoriginator, WorkflowExpression<string> bodyrecipient, WorkflowExpression<string> bodycontent, WorkflowExpression<bodydataCodingInput> bodydataCoding, WorkflowExpression<string> bodyexpiry = null, WorkflowExpression<string> bodyretryDelay = null, WorkflowExpression<string> bodyretryCount = null, WorkflowExpression<string> bodyotpCodeLength = null, WorkflowExpression<bodyotpTypeInput> bodyotpType = null, WorkflowExpression<string> bodysuccessUrl = null, WorkflowExpression<string> bodyfailureUrl = null)
        {
            WorkflowExpression.Validate(bodyoriginator, nameof(bodyoriginator), required: true);
            WorkflowExpression.Validate(bodyrecipient, nameof(bodyrecipient), required: true);
            WorkflowExpression.Validate(bodycontent, nameof(bodycontent), required: true);
            WorkflowExpression.Validate(bodydataCoding, nameof(bodydataCoding), required: true);
            WorkflowExpression.Validate(bodyexpiry, nameof(bodyexpiry), required: false);
            WorkflowExpression.Validate(bodyretryDelay, nameof(bodyretryDelay), required: false);
            WorkflowExpression.Validate(bodyretryCount, nameof(bodyretryCount), required: false);
            WorkflowExpression.Validate(bodyotpCodeLength, nameof(bodyotpCodeLength), required: false);
            WorkflowExpression.Validate(bodyotpType, nameof(bodyotpType), required: false);
            WorkflowExpression.Validate(bodysuccessUrl, nameof(bodysuccessUrl), required: false);
            WorkflowExpression.Validate(bodyfailureUrl, nameof(bodyfailureUrl), required: false);
            return new DeferredBodyAction<OTPSendOTPResponse>(() =>
            {
                var apiCallPath = "/verify/v1/otp/send-otp";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["originator"] = ExpressionConverter.ConvertO(bodyoriginator);
                bodypropCount++;
                body["recipient"] = ExpressionConverter.ConvertO(bodyrecipient);
                bodypropCount++;
                body["content"] = ExpressionConverter.ConvertO(bodycontent);
                bodypropCount++;
                body["data_coding"] = ExpressionConverter.ConvertO(bodydataCoding);
                if (bodyexpiry != null)
                {
                    body["expiry"] = ExpressionConverter.ConvertO(bodyexpiry);
                    bodypropCount++;
                }

                if (bodyretryDelay != null)
                {
                    body["retry_delay"] = ExpressionConverter.ConvertO(bodyretryDelay);
                    bodypropCount++;
                }

                if (bodyretryCount != null)
                {
                    body["retry_count"] = ExpressionConverter.ConvertO(bodyretryCount);
                    bodypropCount++;
                }

                if (bodyotpCodeLength != null)
                {
                    body["otp_code_length"] = ExpressionConverter.ConvertO(bodyotpCodeLength);
                    bodypropCount++;
                }

                if (bodyotpType != null)
                {
                    body["otp_type"] = ExpressionConverter.ConvertO(bodyotpType);
                    bodypropCount++;
                }

                if (bodysuccessUrl != null)
                {
                    body["success_url"] = ExpressionConverter.ConvertO(bodysuccessUrl);
                    bodypropCount++;
                }

                if (bodyfailureUrl != null)
                {
                    body["failure_url"] = ExpressionConverter.ConvertO(bodyfailureUrl);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<OTPSendOTPResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "d7messaging")]
        [WorkflowExpressionFactory(nameof(__BuildOTPResendOTP))]
        public IBodyWorkflowAction<OTPResendOTPResponse> OTPResendOTP([WorkflowExpression] Func<string> bodyotpId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "d7messaging")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<OTPResendOTPResponse> __BuildOTPResendOTP(WorkflowExpression<string> bodyotpId)
        {
            WorkflowExpression.Validate(bodyotpId, nameof(bodyotpId), required: true);
            return new DeferredBodyAction<OTPResendOTPResponse>(() =>
            {
                var apiCallPath = "/verify/v1/otp/resend-otp";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["otp_id"] = ExpressionConverter.ConvertO(bodyotpId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<OTPResendOTPResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "d7messaging")]
        [WorkflowExpressionFactory(nameof(__BuildOTPVerifyOTP))]
        public IBodyWorkflowAction<OTPVerifyOTPResponse> OTPVerifyOTP([WorkflowExpression] Func<string> bodyotpCode, [WorkflowExpression] Func<string> bodyotpId = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "d7messaging")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<OTPVerifyOTPResponse> __BuildOTPVerifyOTP(WorkflowExpression<string> bodyotpCode, WorkflowExpression<string> bodyotpId = null)
        {
            WorkflowExpression.Validate(bodyotpCode, nameof(bodyotpCode), required: true);
            WorkflowExpression.Validate(bodyotpId, nameof(bodyotpId), required: false);
            return new DeferredBodyAction<OTPVerifyOTPResponse>(() =>
            {
                var apiCallPath = "/verify/v1/otp/verify-otp";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyotpId != null)
                {
                    body["otp_id"] = ExpressionConverter.ConvertO(bodyotpId);
                    bodypropCount++;
                }

                bodypropCount++;
                body["otp_code"] = ExpressionConverter.ConvertO(bodyotpCode);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<OTPVerifyOTPResponse>(callPayload);
            });
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