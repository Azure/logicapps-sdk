//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Tyntec2fa
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class Tyntec2faActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tyntec2fa")]
        public IBodyWorkflowAction<SendOTPResponse> SendOTP(Expression<Func<string>> number, Expression<Func<string>> text = null, Expression<Func<int>> pinLength = null, Expression<Func<viaInput>> via = null, Expression<Func<int>> applicationId = null, Expression<Func<string>> language = null, Expression<Func<string>> country = null, Expression<Func<string>> otpCode = null, Expression<Func<string>> sender = null, Expression<Func<string>> caller = null)
        {
            var __workflow_number = number == null ? null : WorkflowExpression.Compile(number);
            WorkflowExpression.Validate(__workflow_number, nameof(number), required: true);
            var __workflow_text = text == null ? null : WorkflowExpression.Compile(text);
            WorkflowExpression.Validate(__workflow_text, nameof(text), required: false);
            var __workflow_pinLength = pinLength == null ? null : WorkflowExpression.Compile(pinLength);
            WorkflowExpression.Validate(__workflow_pinLength, nameof(pinLength), required: false);
            var __workflow_via = via == null ? null : WorkflowExpression.Compile(via);
            WorkflowExpression.Validate(__workflow_via, nameof(via), required: false);
            var __workflow_applicationId = applicationId == null ? null : WorkflowExpression.Compile(applicationId);
            WorkflowExpression.Validate(__workflow_applicationId, nameof(applicationId), required: false);
            var __workflow_language = language == null ? null : WorkflowExpression.Compile(language);
            WorkflowExpression.Validate(__workflow_language, nameof(language), required: false);
            var __workflow_country = country == null ? null : WorkflowExpression.Compile(country);
            WorkflowExpression.Validate(__workflow_country, nameof(country), required: false);
            var __workflow_otpCode = otpCode == null ? null : WorkflowExpression.Compile(otpCode);
            WorkflowExpression.Validate(__workflow_otpCode, nameof(otpCode), required: false);
            var __workflow_sender = sender == null ? null : WorkflowExpression.Compile(sender);
            WorkflowExpression.Validate(__workflow_sender, nameof(sender), required: false);
            var __workflow_caller = caller == null ? null : WorkflowExpression.Compile(caller);
            WorkflowExpression.Validate(__workflow_caller, nameof(caller), required: false);
            return new DeferredBodyAction<SendOTPResponse>(() =>
            {
                var apiCallPath = "/2fa/v1/otp";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["number"] = ExpressionConverter.Convert(__workflow_number);
                if (__workflow_text != null)
                    callPayload.Queries["text"] = ExpressionConverter.Convert(__workflow_text);
                if (__workflow_pinLength != null)
                    callPayload.Queries["pinLength"] = ExpressionConverter.Convert(__workflow_pinLength);
                callPayload.Queries["via"] = Convert.ToString("AUTO");
                if (__workflow_via != null)
                    callPayload.Queries["via"] = ExpressionConverter.Convert(__workflow_via);
                if (__workflow_applicationId != null)
                    callPayload.Queries["applicationId"] = ExpressionConverter.Convert(__workflow_applicationId);
                if (__workflow_language != null)
                    callPayload.Queries["language"] = ExpressionConverter.Convert(__workflow_language);
                if (__workflow_country != null)
                    callPayload.Queries["country"] = ExpressionConverter.Convert(__workflow_country);
                if (__workflow_otpCode != null)
                    callPayload.Queries["otpCode"] = ExpressionConverter.Convert(__workflow_otpCode);
                if (__workflow_sender != null)
                    callPayload.Queries["Sender"] = ExpressionConverter.Convert(__workflow_sender);
                if (__workflow_caller != null)
                    callPayload.Queries["Caller"] = ExpressionConverter.Convert(__workflow_caller);
                return new ApiConnectionAction<SendOTPResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tyntec2fa")]
        public IBodyWorkflowAction<DeleteOTPResponse> DeleteOTP(Expression<Func<string>> otpID)
        {
            var __workflow_otpID = otpID == null ? null : WorkflowExpression.Compile(otpID);
            WorkflowExpression.Validate(__workflow_otpID, nameof(otpID), required: true);
            return new DeferredBodyAction<DeleteOTPResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/2fa/v1/otp/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_otpID, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<DeleteOTPResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tyntec2fa")]
        public IBodyWorkflowAction<ResendOTPResponse> ResendOTP(Expression<Func<string>> otpID, Expression<Func<viaInput>> via = null, Expression<Func<string>> sender = null, Expression<Func<string>> caller = null)
        {
            var __workflow_otpID = otpID == null ? null : WorkflowExpression.Compile(otpID);
            WorkflowExpression.Validate(__workflow_otpID, nameof(otpID), required: true);
            var __workflow_via = via == null ? null : WorkflowExpression.Compile(via);
            WorkflowExpression.Validate(__workflow_via, nameof(via), required: false);
            var __workflow_sender = sender == null ? null : WorkflowExpression.Compile(sender);
            WorkflowExpression.Validate(__workflow_sender, nameof(sender), required: false);
            var __workflow_caller = caller == null ? null : WorkflowExpression.Compile(caller);
            WorkflowExpression.Validate(__workflow_caller, nameof(caller), required: false);
            return new DeferredBodyAction<ResendOTPResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/2fa/v1/otp/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_otpID, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["via"] = Convert.ToString("AUTO");
                if (__workflow_via != null)
                    callPayload.Queries["via"] = ExpressionConverter.Convert(__workflow_via);
                if (__workflow_sender != null)
                    callPayload.Queries["Sender"] = ExpressionConverter.Convert(__workflow_sender);
                if (__workflow_caller != null)
                    callPayload.Queries["Caller"] = ExpressionConverter.Convert(__workflow_caller);
                return new ApiConnectionAction<ResendOTPResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tyntec2fa")]
        public IBodyWorkflowAction<StatusOTPResponse> StatusOTP(Expression<Func<string>> otpID)
        {
            var __workflow_otpID = otpID == null ? null : WorkflowExpression.Compile(otpID);
            WorkflowExpression.Validate(__workflow_otpID, nameof(otpID), required: true);
            return new DeferredBodyAction<StatusOTPResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/2fa/v1/otp/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_otpID, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<StatusOTPResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tyntec2fa")]
        public IBodyWorkflowAction<VerifyOTPResponse> VerifyOTP(Expression<Func<string>> otpID, Expression<Func<int>> otpCode = null)
        {
            var __workflow_otpID = otpID == null ? null : WorkflowExpression.Compile(otpID);
            WorkflowExpression.Validate(__workflow_otpID, nameof(otpID), required: true);
            var __workflow_otpCode = otpCode == null ? null : WorkflowExpression.Compile(otpCode);
            WorkflowExpression.Validate(__workflow_otpCode, nameof(otpCode), required: false);
            return new DeferredBodyAction<VerifyOTPResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/2fa/v1/otp/{0}/check", ExpressionConverter.ConvertWithUrlEncoding(__workflow_otpID, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_otpCode != null)
                    callPayload.Queries["otpCode"] = ExpressionConverter.Convert(__workflow_otpCode);
                return new ApiConnectionAction<VerifyOTPResponse>(callPayload);
            });
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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
