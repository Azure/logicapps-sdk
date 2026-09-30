//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Whoisfreaks
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class WhoisfreaksActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "whoisfreaks")]
        public IWorkflowAction LiveWhoisLookup([WorkflowExpression] Func<string> domainName, [WorkflowExpression] Func<formatInput> format)
        {
            SourceExpression.Validate(domainName, nameof(domainName), required: true);
            SourceExpression.Validate(format, nameof(format), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v2.0/whois/live";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["domainName"] = SourceExpressionConverter.ConvertO(domainName);
                callPayload.Queries["format"] = SourceExpressionConverter.Convert(format);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "whoisfreaks")]
        public IWorkflowAction HistoricalWhoisLookup([WorkflowExpression] Func<string> domainName, [WorkflowExpression] Func<formatInput> format)
        {
            SourceExpression.Validate(domainName, nameof(domainName), required: true);
            SourceExpression.Validate(format, nameof(format), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1.0/whois";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["whois"] = Convert.ToString("historical");
                callPayload.Queries["domainName"] = SourceExpressionConverter.ConvertO(domainName);
                callPayload.Queries["format"] = SourceExpressionConverter.Convert(format);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "whoisfreaks")]
        public IWorkflowAction LiveDnsLookup([WorkflowExpression] Func<string> domainName, [WorkflowExpression] Func<formatInput> format, [WorkflowExpression] Func<string> type = null)
        {
            SourceExpression.Validate(domainName, nameof(domainName), required: true);
            SourceExpression.Validate(format, nameof(format), required: true);
            SourceExpression.Validate(type, nameof(type), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v2.0/dns/live";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["domainName"] = SourceExpressionConverter.ConvertO(domainName);
                callPayload.Queries["type"] = Convert.ToString("all");
                if (type != null)
                    callPayload.Queries["type"] = SourceExpressionConverter.ConvertO(type);
                callPayload.Queries["format"] = SourceExpressionConverter.Convert(format);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "whoisfreaks")]
        public IWorkflowAction HitoricalDnsLookup([WorkflowExpression] Func<string> domainName, [WorkflowExpression] Func<formatInput> format, [WorkflowExpression] Func<string> type = null, [WorkflowExpression] Func<int> page = null)
        {
            SourceExpression.Validate(domainName, nameof(domainName), required: true);
            SourceExpression.Validate(format, nameof(format), required: true);
            SourceExpression.Validate(type, nameof(type), required: false);
            SourceExpression.Validate(page, nameof(page), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v2.0/dns/historical";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["domainName"] = SourceExpressionConverter.ConvertO(domainName);
                callPayload.Queries["type"] = Convert.ToString("all");
                if (type != null)
                    callPayload.Queries["type"] = SourceExpressionConverter.ConvertO(type);
                callPayload.Queries["page"] = Convert.ToString(1);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                callPayload.Queries["format"] = SourceExpressionConverter.Convert(format);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "whoisfreaks")]
        public IWorkflowAction ReverseDnsLookup([WorkflowExpression] Func<string> value, [WorkflowExpression] Func<formatInput> format, [WorkflowExpression] Func<string> type = null, [WorkflowExpression] Func<bool> exact = null, [WorkflowExpression] Func<int> page = null)
        {
            SourceExpression.Validate(value, nameof(value), required: true);
            SourceExpression.Validate(format, nameof(format), required: true);
            SourceExpression.Validate(type, nameof(type), required: false);
            SourceExpression.Validate(exact, nameof(exact), required: false);
            SourceExpression.Validate(page, nameof(page), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v2.1/dns/reverse";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["value"] = SourceExpressionConverter.ConvertO(value);
                callPayload.Queries["type"] = Convert.ToString("a");
                if (type != null)
                    callPayload.Queries["type"] = SourceExpressionConverter.ConvertO(type);
                callPayload.Queries["exact"] = Convert.ToString(true);
                if (exact != null)
                    callPayload.Queries["exact"] = SourceExpressionConverter.ConvertO(exact);
                callPayload.Queries["page"] = Convert.ToString(1);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                callPayload.Queries["format"] = SourceExpressionConverter.Convert(format);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "whoisfreaks")]
        public IWorkflowAction DomainAvailabilityLookup([WorkflowExpression] Func<string> domain, [WorkflowExpression] Func<formatInput> format, [WorkflowExpression] Func<bool> sug = null)
        {
            SourceExpression.Validate(domain, nameof(domain), required: true);
            SourceExpression.Validate(format, nameof(format), required: true);
            SourceExpression.Validate(sug, nameof(sug), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1.0/domain/availability";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["domain"] = SourceExpressionConverter.ConvertO(domain);
                callPayload.Queries["sug"] = Convert.ToString(false);
                if (sug != null)
                    callPayload.Queries["sug"] = SourceExpressionConverter.ConvertO(sug);
                callPayload.Queries["format"] = SourceExpressionConverter.Convert(format);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "whoisfreaks")]
        public IWorkflowAction BulkDomainAvailabilityLookup([WorkflowExpression] Func<formatInput> format, [WorkflowExpression] Func<string[]> bodydomainNames, [WorkflowExpression] Func<string> contentType = null)
        {
            SourceExpression.Validate(format, nameof(format), required: true);
            SourceExpression.Validate(bodydomainNames, nameof(bodydomainNames), required: true);
            SourceExpression.Validate(contentType, nameof(contentType), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1.0/domain/availability";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["format"] = SourceExpressionConverter.Convert(format);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (contentType != null)
                    callPayload.Headers["Content-Type"] = SourceExpressionConverter.ConvertO(contentType);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["domainNames"] = SourceExpressionConverter.ConvertToken(bodydomainNames);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "whoisfreaks")]
        public IWorkflowAction TyposquattingLookup([WorkflowExpression] Func<string> keyword)
        {
            SourceExpression.Validate(keyword, nameof(keyword), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3.0/domain/typos";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["keyword"] = SourceExpressionConverter.ConvertO(keyword);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "whoisfreaks")]
        public IWorkflowAction SSLLookup([WorkflowExpression] Func<string> domainName, [WorkflowExpression] Func<formatInput> format, [WorkflowExpression] Func<bool> chain = null, [WorkflowExpression] Func<bool> sslRaw = null)
        {
            SourceExpression.Validate(domainName, nameof(domainName), required: true);
            SourceExpression.Validate(format, nameof(format), required: true);
            SourceExpression.Validate(chain, nameof(chain), required: false);
            SourceExpression.Validate(sslRaw, nameof(sslRaw), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1.0/ssl/live";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["domainName"] = SourceExpressionConverter.ConvertO(domainName);
                callPayload.Queries["chain"] = Convert.ToString(true);
                if (chain != null)
                    callPayload.Queries["chain"] = SourceExpressionConverter.ConvertO(chain);
                callPayload.Queries["sslRaw"] = Convert.ToString(false);
                if (sslRaw != null)
                    callPayload.Queries["sslRaw"] = SourceExpressionConverter.ConvertO(sslRaw);
                callPayload.Queries["format"] = SourceExpressionConverter.Convert(format);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "whoisfreaks")]
        public IWorkflowAction IPGeolocationLookup([WorkflowExpression] Func<string> ip)
        {
            SourceExpression.Validate(ip, nameof(ip), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1.0/geolocation";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["ip"] = SourceExpressionConverter.ConvertO(ip);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "whoisfreaks")]
        public IWorkflowAction BulkIpGeolocationLookup([WorkflowExpression] Func<string[]> bodyips, [WorkflowExpression] Func<string> contentType = null)
        {
            SourceExpression.Validate(bodyips, nameof(bodyips), required: true);
            SourceExpression.Validate(contentType, nameof(contentType), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1.0/geolocation";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (contentType != null)
                    callPayload.Headers["Content-Type"] = SourceExpressionConverter.ConvertO(contentType);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["ips"] = SourceExpressionConverter.ConvertToken(bodyips);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "whoisfreaks")]
        public IWorkflowAction SubdomainLookup([WorkflowExpression] Func<string> domain, [WorkflowExpression] Func<formatInput> format, [WorkflowExpression] Func<int> page = null)
        {
            SourceExpression.Validate(domain, nameof(domain), required: true);
            SourceExpression.Validate(format, nameof(format), required: true);
            SourceExpression.Validate(page, nameof(page), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1.0/subdomains";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["domain"] = SourceExpressionConverter.ConvertO(domain);
                callPayload.Queries["page"] = Convert.ToString(1);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                callPayload.Queries["format"] = SourceExpressionConverter.Convert(format);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "whoisfreaks")]
        public IWorkflowAction IPReputationLookup([WorkflowExpression] Func<string> ip)
        {
            SourceExpression.Validate(ip, nameof(ip), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1.0/security";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["ip"] = SourceExpressionConverter.ConvertO(ip);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "whoisfreaks")]
        public IWorkflowAction BulkIpReputationLookup([WorkflowExpression] Func<string[]> bodyips, [WorkflowExpression] Func<string> contentType = null)
        {
            SourceExpression.Validate(bodyips, nameof(bodyips), required: true);
            SourceExpression.Validate(contentType, nameof(contentType), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1.0/security";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (contentType != null)
                    callPayload.Headers["Content-Type"] = SourceExpressionConverter.ConvertO(contentType);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["ips"] = SourceExpressionConverter.ConvertToken(bodyips);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "whoisfreaks")]
        public IWorkflowAction DomainReputationLookup([WorkflowExpression] Func<string> domainName, [WorkflowExpression] Func<formatInput> format)
        {
            SourceExpression.Validate(domainName, nameof(domainName), required: true);
            SourceExpression.Validate(format, nameof(format), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/domain/security";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["domainName"] = SourceExpressionConverter.ConvertO(domainName);
                callPayload.Queries["format"] = SourceExpressionConverter.Convert(format);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "whoisfreaks")]
        public IWorkflowAction ReverseWhoisLookup([WorkflowExpression] Func<string> keyword)
        {
            SourceExpression.Validate(keyword, nameof(keyword), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v2.0/whois/reverse";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["keyword"] = SourceExpressionConverter.ConvertO(keyword);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "whoisfreaks")]
        public IWorkflowAction BulkWhoisLookup([WorkflowExpression] Func<formatInput> format, [WorkflowExpression] Func<string[]> bodydomainNames, [WorkflowExpression] Func<string> contentType = null)
        {
            SourceExpression.Validate(format, nameof(format), required: true);
            SourceExpression.Validate(bodydomainNames, nameof(bodydomainNames), required: true);
            SourceExpression.Validate(contentType, nameof(contentType), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v2.0/bulkwhois/live";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["format"] = SourceExpressionConverter.Convert(format);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (contentType != null)
                    callPayload.Headers["Content-Type"] = SourceExpressionConverter.ConvertO(contentType);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["domainNames"] = SourceExpressionConverter.ConvertToken(bodydomainNames);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "whoisfreaks")]
        public IWorkflowAction BulkDomainLookup([WorkflowExpression] Func<formatInput> format, [WorkflowExpression] Func<string[]> bodydomainNames, [WorkflowExpression] Func<string> type = null, [WorkflowExpression] Func<string> contentType = null, [WorkflowExpression] Func<string[]> bodyipAddresses = null)
        {
            SourceExpression.Validate(format, nameof(format), required: true);
            SourceExpression.Validate(bodydomainNames, nameof(bodydomainNames), required: true);
            SourceExpression.Validate(type, nameof(type), required: false);
            SourceExpression.Validate(contentType, nameof(contentType), required: false);
            SourceExpression.Validate(bodyipAddresses, nameof(bodyipAddresses), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v2.0/dns/bulk/live";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["type"] = Convert.ToString("all");
                if (type != null)
                    callPayload.Queries["type"] = SourceExpressionConverter.ConvertO(type);
                callPayload.Queries["format"] = SourceExpressionConverter.Convert(format);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (contentType != null)
                    callPayload.Headers["Content-Type"] = SourceExpressionConverter.ConvertO(contentType);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["domainNames"] = SourceExpressionConverter.ConvertToken(bodydomainNames);
                if (bodyipAddresses != null)
                {
                    body["ipAddresses"] = SourceExpressionConverter.ConvertToken(bodyipAddresses);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "whoisfreaks")]
        public IWorkflowAction IPWhois([WorkflowExpression] Func<string> ip)
        {
            SourceExpression.Validate(ip, nameof(ip), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1.0/ip-whois";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["ip"] = SourceExpressionConverter.ConvertO(ip);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "whoisfreaks")]
        public IWorkflowAction AccountUsage()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1.0/whoisapi/usage";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "whoisfreaks")]
        public IWorkflowAction DatabaseFileStatus()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3.3/status";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "whoisfreaks")]
        public IWorkflowAction RotateApiKey()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1.0/api-key/rotate";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "whoisfreaks")]
        public IWorkflowAction AsnWhois([WorkflowExpression] Func<string> asn, [WorkflowExpression] Func<formatInput> format)
        {
            SourceExpression.Validate(asn, nameof(asn), required: true);
            SourceExpression.Validate(format, nameof(format), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v2.0/asn-whois";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["asn"] = SourceExpressionConverter.ConvertO(asn);
                callPayload.Queries["format"] = SourceExpressionConverter.Convert(format);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }
    }

    public class WhoisfreaksTriggers([ConnectionName] string connectionId)
    {
    }

    public enum formatInput
    {
        [EnumMember(Value = "xml")]
        Xml,
        [EnumMember(Value = "json")]
        Json
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Whoisfreaks;

    public partial class WorkflowManagedActions
    {
        public WhoisfreaksActions Whoisfreaks(string connectionId) => new WhoisfreaksActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public WhoisfreaksTriggers Whoisfreaks(string connectionId) => new WhoisfreaksTriggers(connectionId);
    }
}