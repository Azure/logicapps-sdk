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
        public IBodyWorkflowAction<StringAutomaticThreatDetection> ContentThreatDetectionAutomaticThreatDetectionString([WorkflowExpression] Func<string> value = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/security/threat-detection/content/automatic/detect/string";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = SourceExpressionConverter.ConvertToken(value);
                return callPayload;
            }

            return new ApiConnectionAction<StringAutomaticThreatDetection>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivesecurity")]
        public IBodyWorkflowAction<StringInsecureDeserializationJsonDetection> ContentThreatDetectionDetectInsecureDeserializationJsonString([WorkflowExpression] Func<string> value = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/security/threat-detection/content/insecure-deserialization/json/detect/string";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = SourceExpressionConverter.ConvertToken(value);
                return callPayload;
            }

            return new ApiConnectionAction<StringInsecureDeserializationJsonDetection>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivesecurity")]
        public IBodyWorkflowAction<StringSqlInjectionDetectionResult> ContentThreatDetectionCheckSqlInjectionString([WorkflowExpression] Func<string> value = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/security/threat-detection/content/sql-injection/detect/string";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = SourceExpressionConverter.ConvertToken(value);
                return callPayload;
            }

            return new ApiConnectionAction<StringSqlInjectionDetectionResult>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivesecurity")]
        public IBodyWorkflowAction<StringXssProtectionResult> ContentThreatDetectionProtectXss([WorkflowExpression] Func<string> value = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/security/threat-detection/content/xss/detect/string";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = SourceExpressionConverter.ConvertToken(value);
                return callPayload;
            }

            return new ApiConnectionAction<StringXssProtectionResult>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivesecurity")]
        public IBodyWorkflowAction<StringXxeDetectionResult> ContentThreatDetectionCheckXxe([WorkflowExpression] Func<string> value = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/security/threat-detection/content/xxe/detect/xml/string";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = SourceExpressionConverter.ConvertToken(value);
                return callPayload;
            }

            return new ApiConnectionAction<StringXxeDetectionResult>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivesecurity")]
        public IBodyWorkflowAction<UrlSsrfThreatDetectionResponseFull> NetworkThreatDetectionDetectSsrfUrl([WorkflowExpression] Func<string> requestuRL = null, [WorkflowExpression] Func<string[]> requestblockedDomains = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/security/threat-detection/network/url/ssrf/detect";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                if (requestuRL != null)
                {
                    request["URL"] = SourceExpressionConverter.ConvertToken(requestuRL);
                    requestpropCount++;
                }

                if (requestblockedDomains != null)
                {
                    request["BlockedDomains"] = SourceExpressionConverter.ConvertToken(requestblockedDomains);
                    requestpropCount++;
                }

                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }
                return callPayload;
            }

            return new ApiConnectionAction<UrlSsrfThreatDetectionResponseFull>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivesecurity")]
        public IBodyWorkflowAction<IPThreatDetectionResponse> NetworkThreatDetectionIsThreat([WorkflowExpression] Func<string> value = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/security/threat-detection/network/ip/is-threat";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = SourceExpressionConverter.ConvertToken(value);
                return callPayload;
            }

            return new ApiConnectionAction<IPThreatDetectionResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivesecurity")]
        public IBodyWorkflowAction<ThreatDetectionBotCheckResponse> NetworkThreatDetectionIsBot([WorkflowExpression] Func<string> value = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/security/threat-detection/network/ip/is-bot";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = SourceExpressionConverter.ConvertToken(value);
                return callPayload;
            }

            return new ApiConnectionAction<ThreatDetectionBotCheckResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersivesecurity")]
        public IBodyWorkflowAction<ThreatDetectionTorNodeResponse> NetworkThreatDetectionIsTorNode([WorkflowExpression] Func<string> value = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/security/threat-detection/network/ip/is-tor-node";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = SourceExpressionConverter.ConvertToken(value);
                return callPayload;
            }

            return new ApiConnectionAction<ThreatDetectionTorNodeResponse>(BuildSourceInput);
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