//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Cloudmersivesecurity
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CloudmersivesecurityActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivesecurity")]
        [WorkflowExpressionFactory(nameof(__BuildContentThreatDetectionAutomaticThreatDetectionString))]
        public IBodyWorkflowAction<StringAutomaticThreatDetection> ContentThreatDetectionAutomaticThreatDetectionString([WorkflowExpression] Func<string> value = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivesecurity")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<StringAutomaticThreatDetection> __BuildContentThreatDetectionAutomaticThreatDetectionString(WorkflowExpression<string> value = null)
        {
            WorkflowExpression.Validate(value, nameof(value), required: false);
            return new DeferredBodyAction<StringAutomaticThreatDetection>(() =>
            {
                var apiCallPath = "/security/threat-detection/content/automatic/detect/string";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(value);
                return new ApiConnectionAction<StringAutomaticThreatDetection>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivesecurity")]
        [WorkflowExpressionFactory(nameof(__BuildContentThreatDetectionDetectInsecureDeserializationJsonString))]
        public IBodyWorkflowAction<StringInsecureDeserializationJsonDetection> ContentThreatDetectionDetectInsecureDeserializationJsonString([WorkflowExpression] Func<string> value = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivesecurity")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<StringInsecureDeserializationJsonDetection> __BuildContentThreatDetectionDetectInsecureDeserializationJsonString(WorkflowExpression<string> value = null)
        {
            WorkflowExpression.Validate(value, nameof(value), required: false);
            return new DeferredBodyAction<StringInsecureDeserializationJsonDetection>(() =>
            {
                var apiCallPath = "/security/threat-detection/content/insecure-deserialization/json/detect/string";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(value);
                return new ApiConnectionAction<StringInsecureDeserializationJsonDetection>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivesecurity")]
        [WorkflowExpressionFactory(nameof(__BuildContentThreatDetectionCheckSqlInjectionString))]
        public IBodyWorkflowAction<StringSqlInjectionDetectionResult> ContentThreatDetectionCheckSqlInjectionString([WorkflowExpression] Func<string> value = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivesecurity")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<StringSqlInjectionDetectionResult> __BuildContentThreatDetectionCheckSqlInjectionString(WorkflowExpression<string> value = null)
        {
            WorkflowExpression.Validate(value, nameof(value), required: false);
            return new DeferredBodyAction<StringSqlInjectionDetectionResult>(() =>
            {
                var apiCallPath = "/security/threat-detection/content/sql-injection/detect/string";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(value);
                return new ApiConnectionAction<StringSqlInjectionDetectionResult>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivesecurity")]
        [WorkflowExpressionFactory(nameof(__BuildContentThreatDetectionProtectXss))]
        public IBodyWorkflowAction<StringXssProtectionResult> ContentThreatDetectionProtectXss([WorkflowExpression] Func<string> value = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivesecurity")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<StringXssProtectionResult> __BuildContentThreatDetectionProtectXss(WorkflowExpression<string> value = null)
        {
            WorkflowExpression.Validate(value, nameof(value), required: false);
            return new DeferredBodyAction<StringXssProtectionResult>(() =>
            {
                var apiCallPath = "/security/threat-detection/content/xss/detect/string";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(value);
                return new ApiConnectionAction<StringXssProtectionResult>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivesecurity")]
        [WorkflowExpressionFactory(nameof(__BuildContentThreatDetectionCheckXxe))]
        public IBodyWorkflowAction<StringXxeDetectionResult> ContentThreatDetectionCheckXxe([WorkflowExpression] Func<string> value = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivesecurity")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<StringXxeDetectionResult> __BuildContentThreatDetectionCheckXxe(WorkflowExpression<string> value = null)
        {
            WorkflowExpression.Validate(value, nameof(value), required: false);
            return new DeferredBodyAction<StringXxeDetectionResult>(() =>
            {
                var apiCallPath = "/security/threat-detection/content/xxe/detect/xml/string";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(value);
                return new ApiConnectionAction<StringXxeDetectionResult>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivesecurity")]
        [WorkflowExpressionFactory(nameof(__BuildNetworkThreatDetectionDetectSsrfUrl))]
        public IBodyWorkflowAction<UrlSsrfThreatDetectionResponseFull> NetworkThreatDetectionDetectSsrfUrl([WorkflowExpression] Func<string> requestuRL = null, [WorkflowExpression] Func<string[]> requestblockedDomains = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivesecurity")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<UrlSsrfThreatDetectionResponseFull> __BuildNetworkThreatDetectionDetectSsrfUrl(WorkflowExpression<string> requestuRL = null, WorkflowExpression<string[]> requestblockedDomains = null)
        {
            WorkflowExpression.Validate(requestuRL, nameof(requestuRL), required: false);
            WorkflowExpression.Validate(requestblockedDomains, nameof(requestblockedDomains), required: false);
            return new DeferredBodyAction<UrlSsrfThreatDetectionResponseFull>(() =>
            {
                var apiCallPath = "/security/threat-detection/network/url/ssrf/detect";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                if (requestuRL != null)
                {
                    request["URL"] = ExpressionConverter.ConvertO(requestuRL);
                    requestpropCount++;
                }

                if (requestblockedDomains != null)
                {
                    request["BlockedDomains"] = ExpressionConverter.ConvertO(requestblockedDomains);
                    requestpropCount++;
                }

                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }

                return new ApiConnectionAction<UrlSsrfThreatDetectionResponseFull>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivesecurity")]
        [WorkflowExpressionFactory(nameof(__BuildNetworkThreatDetectionIsThreat))]
        public IBodyWorkflowAction<IPThreatDetectionResponse> NetworkThreatDetectionIsThreat([WorkflowExpression] Func<string> value = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivesecurity")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<IPThreatDetectionResponse> __BuildNetworkThreatDetectionIsThreat(WorkflowExpression<string> value = null)
        {
            WorkflowExpression.Validate(value, nameof(value), required: false);
            return new DeferredBodyAction<IPThreatDetectionResponse>(() =>
            {
                var apiCallPath = "/security/threat-detection/network/ip/is-threat";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(value);
                return new ApiConnectionAction<IPThreatDetectionResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivesecurity")]
        [WorkflowExpressionFactory(nameof(__BuildNetworkThreatDetectionIsBot))]
        public IBodyWorkflowAction<ThreatDetectionBotCheckResponse> NetworkThreatDetectionIsBot([WorkflowExpression] Func<string> value = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivesecurity")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ThreatDetectionBotCheckResponse> __BuildNetworkThreatDetectionIsBot(WorkflowExpression<string> value = null)
        {
            WorkflowExpression.Validate(value, nameof(value), required: false);
            return new DeferredBodyAction<ThreatDetectionBotCheckResponse>(() =>
            {
                var apiCallPath = "/security/threat-detection/network/ip/is-bot";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(value);
                return new ApiConnectionAction<ThreatDetectionBotCheckResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivesecurity")]
        [WorkflowExpressionFactory(nameof(__BuildNetworkThreatDetectionIsTorNode))]
        public IBodyWorkflowAction<ThreatDetectionTorNodeResponse> NetworkThreatDetectionIsTorNode([WorkflowExpression] Func<string> value = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivesecurity")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ThreatDetectionTorNodeResponse> __BuildNetworkThreatDetectionIsTorNode(WorkflowExpression<string> value = null)
        {
            WorkflowExpression.Validate(value, nameof(value), required: false);
            return new DeferredBodyAction<ThreatDetectionTorNodeResponse>(() =>
            {
                var apiCallPath = "/security/threat-detection/network/ip/is-tor-node";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(value);
                return new ApiConnectionAction<ThreatDetectionTorNodeResponse>(callPayload);
            });
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