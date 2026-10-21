//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Cloudmersivesecurity
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CloudmersivesecurityActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivesecurity")]
        public IBodyWorkflowAction<StringAutomaticThreatDetection> ContentThreatDetectionAutomaticThreatDetectionString(Expression<Func<string>> value = null)
        {
            var __workflow_value = WorkflowExpression.Compile(value, nameof(value), required: false);
            return new DeferredBodyAction<StringAutomaticThreatDetection>(() =>
            {
                var apiCallPath = "/security/threat-detection/content/automatic/detect/string";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_value);
                return new ApiConnectionAction<StringAutomaticThreatDetection>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivesecurity")]
        public IBodyWorkflowAction<StringInsecureDeserializationJsonDetection> ContentThreatDetectionDetectInsecureDeserializationJsonString(Expression<Func<string>> value = null)
        {
            var __workflow_value = WorkflowExpression.Compile(value, nameof(value), required: false);
            return new DeferredBodyAction<StringInsecureDeserializationJsonDetection>(() =>
            {
                var apiCallPath = "/security/threat-detection/content/insecure-deserialization/json/detect/string";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_value);
                return new ApiConnectionAction<StringInsecureDeserializationJsonDetection>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivesecurity")]
        public IBodyWorkflowAction<StringSqlInjectionDetectionResult> ContentThreatDetectionCheckSqlInjectionString(Expression<Func<string>> value = null)
        {
            var __workflow_value = WorkflowExpression.Compile(value, nameof(value), required: false);
            return new DeferredBodyAction<StringSqlInjectionDetectionResult>(() =>
            {
                var apiCallPath = "/security/threat-detection/content/sql-injection/detect/string";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_value);
                return new ApiConnectionAction<StringSqlInjectionDetectionResult>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivesecurity")]
        public IBodyWorkflowAction<StringXssProtectionResult> ContentThreatDetectionProtectXss(Expression<Func<string>> value = null)
        {
            var __workflow_value = WorkflowExpression.Compile(value, nameof(value), required: false);
            return new DeferredBodyAction<StringXssProtectionResult>(() =>
            {
                var apiCallPath = "/security/threat-detection/content/xss/detect/string";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_value);
                return new ApiConnectionAction<StringXssProtectionResult>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivesecurity")]
        public IBodyWorkflowAction<StringXxeDetectionResult> ContentThreatDetectionCheckXxe(Expression<Func<string>> value = null)
        {
            var __workflow_value = WorkflowExpression.Compile(value, nameof(value), required: false);
            return new DeferredBodyAction<StringXxeDetectionResult>(() =>
            {
                var apiCallPath = "/security/threat-detection/content/xxe/detect/xml/string";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_value);
                return new ApiConnectionAction<StringXxeDetectionResult>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivesecurity")]
        public IBodyWorkflowAction<UrlSsrfThreatDetectionResponseFull> NetworkThreatDetectionDetectSsrfUrl(Expression<Func<string>> requestuRL = null, Expression<Func<string[]>> requestblockedDomains = null)
        {
            var __workflow_requestuRL = WorkflowExpression.Compile(requestuRL, nameof(requestuRL), required: false);
            var __workflow_requestblockedDomains = WorkflowExpression.Compile(requestblockedDomains, nameof(requestblockedDomains), required: false);
            return new DeferredBodyAction<UrlSsrfThreatDetectionResponseFull>(() =>
            {
                var apiCallPath = "/security/threat-detection/network/url/ssrf/detect";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                if (__workflow_requestuRL != null)
                {
                    request["URL"] = ExpressionConverter.ConvertO(__workflow_requestuRL);
                    requestpropCount++;
                }

                if (__workflow_requestblockedDomains != null)
                {
                    request["BlockedDomains"] = ExpressionConverter.ConvertO(__workflow_requestblockedDomains);
                    requestpropCount++;
                }

                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }

                return new ApiConnectionAction<UrlSsrfThreatDetectionResponseFull>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivesecurity")]
        public IBodyWorkflowAction<IPThreatDetectionResponse> NetworkThreatDetectionIsThreat(Expression<Func<string>> value = null)
        {
            var __workflow_value = WorkflowExpression.Compile(value, nameof(value), required: false);
            return new DeferredBodyAction<IPThreatDetectionResponse>(() =>
            {
                var apiCallPath = "/security/threat-detection/network/ip/is-threat";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_value);
                return new ApiConnectionAction<IPThreatDetectionResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivesecurity")]
        public IBodyWorkflowAction<ThreatDetectionBotCheckResponse> NetworkThreatDetectionIsBot(Expression<Func<string>> value = null)
        {
            var __workflow_value = WorkflowExpression.Compile(value, nameof(value), required: false);
            return new DeferredBodyAction<ThreatDetectionBotCheckResponse>(() =>
            {
                var apiCallPath = "/security/threat-detection/network/ip/is-bot";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_value);
                return new ApiConnectionAction<ThreatDetectionBotCheckResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivesecurity")]
        public IBodyWorkflowAction<ThreatDetectionTorNodeResponse> NetworkThreatDetectionIsTorNode(Expression<Func<string>> value = null)
        {
            var __workflow_value = WorkflowExpression.Compile(value, nameof(value), required: false);
            return new DeferredBodyAction<ThreatDetectionTorNodeResponse>(() =>
            {
                var apiCallPath = "/security/threat-detection/network/ip/is-tor-node";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_value);
                return new ApiConnectionAction<ThreatDetectionTorNodeResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }
    }

    public class CloudmersivesecurityTriggers([ConnectionName] string connectionId)
    {
    }

    public class StringAutomaticThreatDetection
    {
        public bool Successful { get; set; }
        public bool CleanResult { get; set; }
        public bool ContainedJsonInsecureDeserializationAttack { get; set; }
        public bool ContainedXssThreat { get; set; }
        public bool ContainedXxeThreat { get; set; }
        public bool ContainedSqlInjectionThreat { get; set; }
        public bool ContainedSsrfThreat { get; set; }
        public bool IsXML { get; set; }
        public bool IsJSON { get; set; }
        public bool IsURL { get; set; }
        public string OriginalInput { get; set; }
    }

    public class StringInsecureDeserializationJsonDetection
    {
        public bool Successful { get; set; }
        public bool ContainedJsonInsecureDeserializationAttack { get; set; }
        public string OriginalInput { get; set; }
    }

    public class StringSqlInjectionDetectionResult
    {
        public bool Successful { get; set; }
        public bool ContainedSqlInjectionAttack { get; set; }
        public string OriginalInput { get; set; }
    }

    public class StringXssProtectionResult
    {
        public bool Successful { get; set; }
        public bool ContainedXss { get; set; }
        public string OriginalInput { get; set; }
        public string NormalizedResult { get; set; }
    }

    public class StringXxeDetectionResult
    {
        public bool Successful { get; set; }
        public bool ContainedXxe { get; set; }
    }

    public class UrlSsrfThreatDetectionResponseFull
    {
        public bool CleanURL { get; set; }
        public string ThreatLevel { get; set; }
    }

    public class IPThreatDetectionResponse
    {
        public bool IsThreat { get; set; }
        public string ThreatType { get; set; }
    }

    public class ThreatDetectionBotCheckResponse
    {
        public bool IsBot { get; set; }
    }

    public class ThreatDetectionTorNodeResponse
    {
        public bool IsTorNode { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Cloudmersivesecurity;

    public partial class WorkflowManagedActions
    {
        public CloudmersivesecurityActions Cloudmersivesecurity(string connectionId) => new CloudmersivesecurityActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public CloudmersivesecurityTriggers Cloudmersivesecurity(string connectionId) => new CloudmersivesecurityTriggers(connectionId);
    }
}
