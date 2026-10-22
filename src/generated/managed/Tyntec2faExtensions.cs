//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Tyntec2fa
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class Tyntec2faActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tyntec2fa")]
        public IBodyWorkflowAction<SendOTPResponse, ApiConnectionActionConfiguration> SendOTP(Expression<Func<string>> number, Expression<Func<string>> text = null, Expression<Func<int>> pinLength = null, Expression<Func<viaInput>> via = null, Expression<Func<int>> applicationId = null, Expression<Func<string>> language = null, Expression<Func<string>> country = null, Expression<Func<string>> otpCode = null, Expression<Func<string>> sender = null, Expression<Func<string>> caller = null)
        {
            var __workflow_number = WorkflowExpression.Compile(number, nameof(number), required: true);
            var __workflow_text = WorkflowExpression.Compile(text, nameof(text), required: false);
            var __workflow_pinLength = WorkflowExpression.Compile(pinLength, nameof(pinLength), required: false);
            var __workflow_via = WorkflowExpression.Compile(via, nameof(via), required: false);
            var __workflow_applicationId = WorkflowExpression.Compile(applicationId, nameof(applicationId), required: false);
            var __workflow_language = WorkflowExpression.Compile(language, nameof(language), required: false);
            var __workflow_country = WorkflowExpression.Compile(country, nameof(country), required: false);
            var __workflow_otpCode = WorkflowExpression.Compile(otpCode, nameof(otpCode), required: false);
            var __workflow_sender = WorkflowExpression.Compile(sender, nameof(sender), required: false);
            var __workflow_caller = WorkflowExpression.Compile(caller, nameof(caller), required: false);
            return new DeferredBodyAction<SendOTPResponse, ApiConnectionActionConfiguration>(() =>
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
        public IBodyWorkflowAction<DeleteOTPResponse, ApiConnectionActionConfiguration> DeleteOTP(Expression<Func<string>> otpID)
        {
            var __workflow_otpID = WorkflowExpression.Compile(otpID, nameof(otpID), required: true);
            return new DeferredBodyAction<DeleteOTPResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/2fa/v1/otp/{0}", __workflow_otpID.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<DeleteOTPResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tyntec2fa")]
        public IBodyWorkflowAction<ResendOTPResponse, ApiConnectionActionConfiguration> ResendOTP(Expression<Func<string>> otpID, Expression<Func<viaInput>> via = null, Expression<Func<string>> sender = null, Expression<Func<string>> caller = null)
        {
            var __workflow_otpID = WorkflowExpression.Compile(otpID, nameof(otpID), required: true);
            var __workflow_via = WorkflowExpression.Compile(via, nameof(via), required: false);
            var __workflow_sender = WorkflowExpression.Compile(sender, nameof(sender), required: false);
            var __workflow_caller = WorkflowExpression.Compile(caller, nameof(caller), required: false);
            return new DeferredBodyAction<ResendOTPResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/2fa/v1/otp/{0}", __workflow_otpID.WithUrlEncoding(1)));
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
        public IBodyWorkflowAction<StatusOTPResponse, ApiConnectionActionConfiguration> StatusOTP(Expression<Func<string>> otpID)
        {
            var __workflow_otpID = WorkflowExpression.Compile(otpID, nameof(otpID), required: true);
            return new DeferredBodyAction<StatusOTPResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/2fa/v1/otp/{0}", __workflow_otpID.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<StatusOTPResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tyntec2fa")]
        public IBodyWorkflowAction<VerifyOTPResponse, ApiConnectionActionConfiguration> VerifyOTP(Expression<Func<string>> otpID, Expression<Func<int>> otpCode = null)
        {
            var __workflow_otpID = WorkflowExpression.Compile(otpID, nameof(otpID), required: true);
            var __workflow_otpCode = WorkflowExpression.Compile(otpCode, nameof(otpCode), required: false);
            return new DeferredBodyAction<VerifyOTPResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/2fa/v1/otp/{0}/check", __workflow_otpID.WithUrlEncoding(1)));
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
