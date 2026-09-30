//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Tyntec2fa
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class Tyntec2faActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tyntec2fa")]
        public IBodyWorkflowAction<SendOTPResponse> SendOTP([WorkflowExpression] Func<string> number, [WorkflowExpression] Func<string> text = null, [WorkflowExpression] Func<int> pinLength = null, [WorkflowExpression] Func<viaInput> via = null, [WorkflowExpression] Func<int> applicationId = null, [WorkflowExpression] Func<string> language = null, [WorkflowExpression] Func<string> country = null, [WorkflowExpression] Func<string> otpCode = null, [WorkflowExpression] Func<string> sender = null, [WorkflowExpression] Func<string> caller = null)
        {
            var apiCallPath = "/2fa/v1/otp";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["number"] = ExpressionConverter.Convert(number);
            if (text != null)
                callPayload.Queries["text"] = ExpressionConverter.Convert(text);
            if (pinLength != null)
                callPayload.Queries["pinLength"] = ExpressionConverter.Convert(pinLength);
            callPayload.Queries["via"] = Convert.ToString("AUTO");
            if (via != null)
                callPayload.Queries["via"] = ExpressionConverter.Convert(via);
            if (applicationId != null)
                callPayload.Queries["applicationId"] = ExpressionConverter.Convert(applicationId);
            if (language != null)
                callPayload.Queries["language"] = ExpressionConverter.Convert(language);
            if (country != null)
                callPayload.Queries["country"] = ExpressionConverter.Convert(country);
            if (otpCode != null)
                callPayload.Queries["otpCode"] = ExpressionConverter.Convert(otpCode);
            if (sender != null)
                callPayload.Queries["Sender"] = ExpressionConverter.Convert(sender);
            if (caller != null)
                callPayload.Queries["Caller"] = ExpressionConverter.Convert(caller);
            return new ApiConnectionAction<SendOTPResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tyntec2fa")]
        public IBodyWorkflowAction<DeleteOTPResponse> DeleteOTP([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> otpID)
        {
            var apiCallPath = String.Format("/2fa/v1/otp/{0}", ExpressionConverter.ConvertWithUrlEncoding(otpID, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<DeleteOTPResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tyntec2fa")]
        public IBodyWorkflowAction<ResendOTPResponse> ResendOTP([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> otpID, [WorkflowExpression] Func<viaInput> via = null, [WorkflowExpression] Func<string> sender = null, [WorkflowExpression] Func<string> caller = null)
        {
            var apiCallPath = String.Format("/2fa/v1/otp/{0}", ExpressionConverter.ConvertWithUrlEncoding(otpID, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["via"] = Convert.ToString("AUTO");
            if (via != null)
                callPayload.Queries["via"] = ExpressionConverter.Convert(via);
            if (sender != null)
                callPayload.Queries["Sender"] = ExpressionConverter.Convert(sender);
            if (caller != null)
                callPayload.Queries["Caller"] = ExpressionConverter.Convert(caller);
            return new ApiConnectionAction<ResendOTPResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tyntec2fa")]
        public IBodyWorkflowAction<StatusOTPResponse> StatusOTP([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> otpID)
        {
            var apiCallPath = String.Format("/2fa/v1/otp/{0}", ExpressionConverter.ConvertWithUrlEncoding(otpID, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<StatusOTPResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tyntec2fa")]
        public IBodyWorkflowAction<VerifyOTPResponse> VerifyOTP([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> otpID, [WorkflowExpression] Func<int> otpCode = null)
        {
            var apiCallPath = String.Format("/2fa/v1/otp/{0}/check", ExpressionConverter.ConvertWithUrlEncoding(otpID, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (otpCode != null)
                callPayload.Queries["otpCode"] = ExpressionConverter.Convert(otpCode);
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