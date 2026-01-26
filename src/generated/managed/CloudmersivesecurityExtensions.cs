//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Cloudmersivesecurity
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CloudmersivesecurityActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivesecurity")]
        public IBodyWorkflowAction<StringAutomaticThreatDetection> ContentThreatDetectionAutomaticThreatDetectionString(Expression<Func<string>> value = null)
        {
            var apiCallPath = "/security/threat-detection/content/automatic/detect/string";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertO(value);
            return new ApiConnectionAction<StringAutomaticThreatDetection>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivesecurity")]
        public IBodyWorkflowAction<StringInsecureDeserializationJsonDetection> ContentThreatDetectionDetectInsecureDeserializationJsonString(Expression<Func<string>> value = null)
        {
            var apiCallPath = "/security/threat-detection/content/insecure-deserialization/json/detect/string";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertO(value);
            return new ApiConnectionAction<StringInsecureDeserializationJsonDetection>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivesecurity")]
        public IBodyWorkflowAction<StringSqlInjectionDetectionResult> ContentThreatDetectionCheckSqlInjectionString(Expression<Func<string>> value = null)
        {
            var apiCallPath = "/security/threat-detection/content/sql-injection/detect/string";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertO(value);
            return new ApiConnectionAction<StringSqlInjectionDetectionResult>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivesecurity")]
        public IBodyWorkflowAction<StringXssProtectionResult> ContentThreatDetectionProtectXss(Expression<Func<string>> value = null)
        {
            var apiCallPath = "/security/threat-detection/content/xss/detect/string";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertO(value);
            return new ApiConnectionAction<StringXssProtectionResult>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivesecurity")]
        public IBodyWorkflowAction<StringXxeDetectionResult> ContentThreatDetectionCheckXxe(Expression<Func<string>> value = null)
        {
            var apiCallPath = "/security/threat-detection/content/xxe/detect/xml/string";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertO(value);
            return new ApiConnectionAction<StringXxeDetectionResult>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivesecurity")]
        public IBodyWorkflowAction<UrlSsrfThreatDetectionResponseFull> NetworkThreatDetectionDetectSsrfUrl(Expression<Func<string>> requestURL = null, Expression<Func<string[]>> requestBlockedDomains = null)
        {
            var apiCallPath = "/security/threat-detection/network/url/ssrf/detect";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var request = new JObject();
            var requestpropCount = 0;
            if (requestURL != null)
            {
                request["URL"] = ExpressionConverter.ConvertO(requestURL);
                requestpropCount++;
            }

            if (requestBlockedDomains != null)
            {
                request["BlockedDomains"] = ExpressionConverter.ConvertO(requestBlockedDomains);
                requestpropCount++;
            }

            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionAction<UrlSsrfThreatDetectionResponseFull>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivesecurity")]
        public IBodyWorkflowAction<IPThreatDetectionResponse> NetworkThreatDetectionIsThreat(Expression<Func<string>> value = null)
        {
            var apiCallPath = "/security/threat-detection/network/ip/is-threat";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertO(value);
            return new ApiConnectionAction<IPThreatDetectionResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivesecurity")]
        public IBodyWorkflowAction<ThreatDetectionBotCheckResponse> NetworkThreatDetectionIsBot(Expression<Func<string>> value = null)
        {
            var apiCallPath = "/security/threat-detection/network/ip/is-bot";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertO(value);
            return new ApiConnectionAction<ThreatDetectionBotCheckResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivesecurity")]
        public IBodyWorkflowAction<ThreatDetectionTorNodeResponse> NetworkThreatDetectionIsTorNode(Expression<Func<string>> value = null)
        {
            var apiCallPath = "/security/threat-detection/network/ip/is-tor-node";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertO(value);
            return new ApiConnectionAction<ThreatDetectionTorNodeResponse>(callPayload);
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