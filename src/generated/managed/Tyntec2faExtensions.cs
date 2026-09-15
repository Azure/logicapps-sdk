//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Tyntec2fa
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class Tyntec2faActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tyntec2fa")]
        public IBodyWorkflowAction<SendOTPResponse> SendOTP(Expression<Func<string>> number, Expression<Func<string>> text = null, Expression<Func<int>> pinLength = null, Expression<Func<viaInput>> via = null, Expression<Func<int>> applicationId = null, Expression<Func<string>> language = null, Expression<Func<string>> country = null, Expression<Func<string>> otpCode = null, Expression<Func<string>> sender = null, Expression<Func<string>> caller = null)
        {
            var apiCallPath = "/2fa/v1/otp";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["number"] = CSharpExpressionConverter.ConvertO(number);
            if (text != null)
                callPayload.Queries["text"] = CSharpExpressionConverter.ConvertO(text);
            if (pinLength != null)
                callPayload.Queries["pinLength"] = CSharpExpressionConverter.ConvertO(pinLength);
            callPayload.Queries["via"] = Convert.ToString("AUTO");
            if (via != null)
                callPayload.Queries["via"] = CSharpExpressionConverter.Convert(via);
            if (applicationId != null)
                callPayload.Queries["applicationId"] = CSharpExpressionConverter.ConvertO(applicationId);
            if (language != null)
                callPayload.Queries["language"] = CSharpExpressionConverter.ConvertO(language);
            if (country != null)
                callPayload.Queries["country"] = CSharpExpressionConverter.ConvertO(country);
            if (otpCode != null)
                callPayload.Queries["otpCode"] = CSharpExpressionConverter.ConvertO(otpCode);
            if (sender != null)
                callPayload.Queries["Sender"] = CSharpExpressionConverter.ConvertO(sender);
            if (caller != null)
                callPayload.Queries["Caller"] = CSharpExpressionConverter.ConvertO(caller);
            return new ApiConnectionAction<SendOTPResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tyntec2fa")]
        public IBodyWorkflowAction<DeleteOTPResponse> DeleteOTP(Expression<Func<string>> otpID)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/2fa/v1/otp/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(otpID, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<DeleteOTPResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tyntec2fa")]
        public IBodyWorkflowAction<ResendOTPResponse> ResendOTP(Expression<Func<string>> otpID, Expression<Func<viaInput>> via = null, Expression<Func<string>> sender = null, Expression<Func<string>> caller = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/2fa/v1/otp/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(otpID, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["via"] = Convert.ToString("AUTO");
            if (via != null)
                callPayload.Queries["via"] = CSharpExpressionConverter.Convert(via);
            if (sender != null)
                callPayload.Queries["Sender"] = CSharpExpressionConverter.ConvertO(sender);
            if (caller != null)
                callPayload.Queries["Caller"] = CSharpExpressionConverter.ConvertO(caller);
            return new ApiConnectionAction<ResendOTPResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tyntec2fa")]
        public IBodyWorkflowAction<StatusOTPResponse> StatusOTP(Expression<Func<string>> otpID)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/2fa/v1/otp/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(otpID, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<StatusOTPResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tyntec2fa")]
        public IBodyWorkflowAction<VerifyOTPResponse> VerifyOTP(Expression<Func<string>> otpID, Expression<Func<int>> otpCode = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/2fa/v1/otp/{0}/check", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(otpID, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (otpCode != null)
                callPayload.Queries["otpCode"] = CSharpExpressionConverter.ConvertO(otpCode);
            return new ApiConnectionAction<VerifyOTPResponse>(callPayload);
        }
    }

    public class Tyntec2faTriggers([ConnectionName] string connectionId)
    {
    }

    public class SendOTPResponse
    {
        [JsonProperty("otpId")]
        public string OtpId { get; set; }

        [JsonProperty("accountId")]
        public string AccountId { get; set; }

        [JsonProperty("applicationId")]
        public string ApplicationId { get; set; }

        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("attemptCount")]
        public int AttemptCount { get; set; }

        [JsonProperty("otpStatus")]
        public string OtpStatus { get; set; }

        [JsonProperty("expire")]
        public int Expire { get; set; }

        [JsonProperty("created")]
        public int Created { get; set; }

        [JsonProperty("referenceId")]
        public string ReferenceId { get; set; }

        [JsonProperty("timestampCreated")]
        public string TimestampCreated { get; set; }

        [JsonProperty("timestampExpire")]
        public string TimestampExpire { get; set; }
    }

    public enum viaInput
    {
        AUTO,
        VOICE,
        SMS
    }

    public class DeleteOTPResponse
    {
        [JsonProperty("otpId")]
        public string OtpId { get; set; }

        [JsonProperty("accountId")]
        public string AccountId { get; set; }

        [JsonProperty("applicationId")]
        public string ApplicationId { get; set; }

        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("attemptCount")]
        public int AttemptCount { get; set; }

        [JsonProperty("otpStatus")]
        public string OtpStatus { get; set; }

        [JsonProperty("expire")]
        public int Expire { get; set; }

        [JsonProperty("created")]
        public int Created { get; set; }

        [JsonProperty("referenceId")]
        public string ReferenceId { get; set; }

        [JsonProperty("timestampCreated")]
        public string TimestampCreated { get; set; }

        [JsonProperty("timestampExpire")]
        public string TimestampExpire { get; set; }
    }

    public class ResendOTPResponse
    {
        [JsonProperty("otpId")]
        public string OtpId { get; set; }

        [JsonProperty("accountId")]
        public string AccountId { get; set; }

        [JsonProperty("applicationId")]
        public string ApplicationId { get; set; }

        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("attemptCount")]
        public int AttemptCount { get; set; }

        [JsonProperty("otpStatus")]
        public string OtpStatus { get; set; }

        [JsonProperty("expire")]
        public int Expire { get; set; }

        [JsonProperty("created")]
        public int Created { get; set; }

        [JsonProperty("referenceId")]
        public string ReferenceId { get; set; }

        [JsonProperty("timestampCreated")]
        public string TimestampCreated { get; set; }

        [JsonProperty("timestampExpire")]
        public string TimestampExpire { get; set; }
    }

    public class StatusOTPResponse
    {
        [JsonProperty("otpId")]
        public string OtpId { get; set; }

        [JsonProperty("accountId")]
        public string AccountId { get; set; }

        [JsonProperty("applicationId")]
        public string ApplicationId { get; set; }

        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("attemptCount")]
        public int AttemptCount { get; set; }

        [JsonProperty("otpStatus")]
        public string OtpStatus { get; set; }

        [JsonProperty("expire")]
        public int Expire { get; set; }

        [JsonProperty("created")]
        public int Created { get; set; }

        [JsonProperty("referenceId")]
        public string ReferenceId { get; set; }

        [JsonProperty("timestampCreated")]
        public string TimestampCreated { get; set; }

        [JsonProperty("timestampExpire")]
        public string TimestampExpire { get; set; }
    }

    public class VerifyOTPResponse
    {
        [JsonProperty("otpId")]
        public string OtpId { get; set; }

        [JsonProperty("accountId")]
        public string AccountId { get; set; }

        [JsonProperty("applicationId")]
        public string ApplicationId { get; set; }

        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("attemptCount")]
        public int AttemptCount { get; set; }

        [JsonProperty("otpStatus")]
        public string OtpStatus { get; set; }

        [JsonProperty("expire")]
        public int Expire { get; set; }

        [JsonProperty("created")]
        public int Created { get; set; }

        [JsonProperty("referenceId")]
        public string ReferenceId { get; set; }

        [JsonProperty("timestampCreated")]
        public string TimestampCreated { get; set; }

        [JsonProperty("timestampExpire")]
        public string TimestampExpire { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Tyntec2fa;

    public partial class WorkflowManagedActions
    {
        public Tyntec2faActions Tyntec2fa(string connectionId) => new Tyntec2faActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public Tyntec2faTriggers Tyntec2fa(string connectionId) => new Tyntec2faTriggers(connectionId);
    }
}