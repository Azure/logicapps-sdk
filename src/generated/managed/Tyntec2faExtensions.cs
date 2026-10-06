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
        public IBodyWorkflowAction<SendOTPResponse> SendOTP([WorkflowExpression] Func<string> number, [WorkflowExpression] Func<string> text = null, [WorkflowExpression] Func<int> pinLength = null, [WorkflowExpression] Func<viaInput> via = null, [WorkflowExpression] Func<int> applicationId = null, [WorkflowExpression] Func<string> language = null, [WorkflowExpression] Func<string> country = null, [WorkflowExpression] Func<string> otpCode = null, [WorkflowExpression] Func<string> sender = null, [WorkflowExpression] Func<string> caller = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/2fa/v1/otp";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["number"] = SourceExpressionConverter.ConvertO(number);
                if (text != null)
                    callPayload.Queries["text"] = SourceExpressionConverter.ConvertO(text);
                if (pinLength != null)
                    callPayload.Queries["pinLength"] = SourceExpressionConverter.ConvertO(pinLength);
                callPayload.Queries["via"] = Convert.ToString("AUTO");
                if (via != null)
                    callPayload.Queries["via"] = SourceExpressionConverter.Convert(via);
                if (applicationId != null)
                    callPayload.Queries["applicationId"] = SourceExpressionConverter.ConvertO(applicationId);
                if (language != null)
                    callPayload.Queries["language"] = SourceExpressionConverter.ConvertO(language);
                if (country != null)
                    callPayload.Queries["country"] = SourceExpressionConverter.ConvertO(country);
                if (otpCode != null)
                    callPayload.Queries["otpCode"] = SourceExpressionConverter.ConvertO(otpCode);
                if (sender != null)
                    callPayload.Queries["Sender"] = SourceExpressionConverter.ConvertO(sender);
                if (caller != null)
                    callPayload.Queries["Caller"] = SourceExpressionConverter.ConvertO(caller);
                return callPayload;
            }

            return new ApiConnectionAction<SendOTPResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tyntec2fa")]
        public IBodyWorkflowAction<DeleteOTPResponse> DeleteOTP([WorkflowExpression] Func<string> otpId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/2fa/v1/otp/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(otpId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<DeleteOTPResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tyntec2fa")]
        public IBodyWorkflowAction<ResendOTPResponse> ResendOTP([WorkflowExpression] Func<string> otpId, [WorkflowExpression] Func<viaInput> via = null, [WorkflowExpression] Func<string> sender = null, [WorkflowExpression] Func<string> caller = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/2fa/v1/otp/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(otpId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["via"] = Convert.ToString("AUTO");
                if (via != null)
                    callPayload.Queries["via"] = SourceExpressionConverter.Convert(via);
                if (sender != null)
                    callPayload.Queries["Sender"] = SourceExpressionConverter.ConvertO(sender);
                if (caller != null)
                    callPayload.Queries["Caller"] = SourceExpressionConverter.ConvertO(caller);
                return callPayload;
            }

            return new ApiConnectionAction<ResendOTPResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tyntec2fa")]
        public IBodyWorkflowAction<StatusOTPResponse> StatusOTP([WorkflowExpression] Func<string> otpId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/2fa/v1/otp/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(otpId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<StatusOTPResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tyntec2fa")]
        public IBodyWorkflowAction<VerifyOTPResponse> VerifyOTP([WorkflowExpression] Func<string> otpId, [WorkflowExpression] Func<int> otpCode = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/2fa/v1/otp/{0}/check", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(otpId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (otpCode != null)
                    callPayload.Queries["otpCode"] = SourceExpressionConverter.ConvertO(otpCode);
                return callPayload;
            }

            return new ApiConnectionAction<VerifyOTPResponse>(BuildSourceInput);
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