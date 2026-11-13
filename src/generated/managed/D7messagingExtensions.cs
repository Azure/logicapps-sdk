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
        public IBodyWorkflowAction<D7BalanceResponse, ApiConnectionActionConfiguration> D7Balance()
        {
            return new DeferredBodyAction<D7BalanceResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/messages/v1/balance";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<D7BalanceResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "d7messaging")]
        public IBodyWorkflowAction<NumberLookupResponse, ApiConnectionActionConfiguration> NumberLookup(Expression<Func<NumberLookupBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<NumberLookupResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/hlr/v1/lookup";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<NumberLookupResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "d7messaging")]
        public IBodyWorkflowAction<OtpSendOtpResponse, ApiConnectionActionConfiguration> OtpSendOtp(Expression<Func<OtpSendOtpBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<OtpSendOtpResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/verify/v1/otp/send-otp";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<OtpSendOtpResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "d7messaging")]
        public IBodyWorkflowAction<OtpResendOtpResponse, ApiConnectionActionConfiguration> OtpResendOtp(Expression<Func<OtpResendOtpBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<OtpResendOtpResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/verify/v1/otp/resend-otp";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<OtpResendOtpResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "d7messaging")]
        public IBodyWorkflowAction<OtpVerifyOtpResponse, ApiConnectionActionConfiguration> OtpVerifyOtp(Expression<Func<OtpVerifyOtpBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<OtpVerifyOtpResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/verify/v1/otp/verify-otp";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<OtpVerifyOtpResponse>(callPayload);
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

    public class NumberLookupBodyInput
    {
        public NumberLookupBodyInput(string recipient)
        {
            this.Recipient = recipient;
        }

        [JsonProperty("recipient", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Recipient { get; set; }
    }

    public class OtpSendOtpResponse
    {
        [JsonProperty("otp_id")]
        public string OtpId { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("expiry")]
        public int Expiry { get; set; }
    }

    public class OtpSendOtpBodyInput
    {
        public OtpSendOtpBodyInput(string originator, string recipient)
        {
            this.Originator = originator;
            this.Recipient = recipient;
        }

        [JsonProperty("originator", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Originator { get; set; }

        [JsonProperty("recipient", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Recipient { get; set; }

        [JsonProperty("content", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Content { get; set; } = "Greetings from D7 API, your mobile verification code is: {}";

        [JsonProperty("data_coding", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputDataCodingType DataCoding { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.D7messaging.BodyInputDataCodingType.Auto;

        [JsonProperty("expiry")]
        public string Expiry { get; set; }

        [JsonProperty("retry_delay")]
        public string RetryDelay { get; set; }

        [JsonProperty("retry_count")]
        public string RetryCount { get; set; }

        [JsonProperty("otp_code_length")]
        public string OtpCodeLength { get; set; }

        [JsonProperty("otp_type")]
        public BodyInputOtpTypeType? OtpType { get; set; }

        [JsonProperty("success_url")]
        public string SuccessUrl { get; set; }

        [JsonProperty("failure_url")]
        public string FailureUrl { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputDataCodingType
    {
        [EnumMember(Value = "auto")]
        Auto,
        [EnumMember(Value = "text")]
        Text,
        [EnumMember(Value = "unicode")]
        Unicode
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputOtpTypeType
    {
        [EnumMember(Value = "numeric")]
        Numeric,
        [EnumMember(Value = "alpha")]
        Alpha,
        [EnumMember(Value = "alphanumeric")]
        Alphanumeric
    }

    public class OtpResendOtpResponse
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

    public class OtpResendOtpBodyInput
    {
        public OtpResendOtpBodyInput(string otpId)
        {
            this.OtpId = otpId;
        }

        [JsonProperty("otp_id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string OtpId { get; set; }
    }

    public class OtpVerifyOtpResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class OtpVerifyOtpBodyInput
    {
        public OtpVerifyOtpBodyInput(string otpCode)
        {
            this.OtpCode = otpCode;
        }

        [JsonProperty("otp_id")]
        public string OtpId { get; set; }

        [JsonProperty("otp_code", DefaultValueHandling = DefaultValueHandling.Include)]
        public string OtpCode { get; set; }
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