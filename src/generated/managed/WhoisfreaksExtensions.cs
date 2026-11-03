//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Whoisfreaks
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class WhoisfreaksActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "whoisfreaks")]
        public IWorkflowAction<ApiConnectionActionConfiguration> LiveWhoisLookup(Expression<Func<string>> domainName, Expression<Func<formatInput>> format)
        {
            var __workflow_domainName = WorkflowExpression.Compile(domainName, nameof(domainName), required: true);
            var __workflow_format = WorkflowExpression.Compile(format, nameof(format), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2.0/whois/live";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["domainName"] = ExpressionConverter.Convert(__workflow_domainName);
                callPayload.Queries["format"] = ExpressionConverter.Convert(__workflow_format);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "whoisfreaks")]
        public IWorkflowAction<ApiConnectionActionConfiguration> HistoricalWhoisLookup(Expression<Func<string>> domainName, Expression<Func<formatInput>> format)
        {
            var __workflow_domainName = WorkflowExpression.Compile(domainName, nameof(domainName), required: true);
            var __workflow_format = WorkflowExpression.Compile(format, nameof(format), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1.0/whois";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["whois"] = Convert.ToString("historical");
                callPayload.Queries["domainName"] = ExpressionConverter.Convert(__workflow_domainName);
                callPayload.Queries["format"] = ExpressionConverter.Convert(__workflow_format);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "whoisfreaks")]
        public IWorkflowAction<ApiConnectionActionConfiguration> LiveDnsLookup(Expression<Func<string>> domainName, Expression<Func<formatInput>> format, Expression<Func<string>> type = null)
        {
            var __workflow_domainName = WorkflowExpression.Compile(domainName, nameof(domainName), required: true);
            var __workflow_format = WorkflowExpression.Compile(format, nameof(format), required: true);
            var __workflow_type = WorkflowExpression.Compile(type, nameof(type), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2.0/dns/live";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["domainName"] = ExpressionConverter.Convert(__workflow_domainName);
                callPayload.Queries["type"] = Convert.ToString("all");
                if (__workflow_type != null)
                    callPayload.Queries["type"] = ExpressionConverter.Convert(__workflow_type);
                callPayload.Queries["format"] = ExpressionConverter.Convert(__workflow_format);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "whoisfreaks")]
        public IWorkflowAction<ApiConnectionActionConfiguration> HitoricalDnsLookup(Expression<Func<string>> domainName, Expression<Func<formatInput>> format, Expression<Func<string>> type = null, Expression<Func<int>> page = null)
        {
            var __workflow_domainName = WorkflowExpression.Compile(domainName, nameof(domainName), required: true);
            var __workflow_format = WorkflowExpression.Compile(format, nameof(format), required: true);
            var __workflow_type = WorkflowExpression.Compile(type, nameof(type), required: false);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2.0/dns/historical";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["domainName"] = ExpressionConverter.Convert(__workflow_domainName);
                callPayload.Queries["type"] = Convert.ToString("all");
                if (__workflow_type != null)
                    callPayload.Queries["type"] = ExpressionConverter.Convert(__workflow_type);
                callPayload.Queries["page"] = Convert.ToString(1);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                callPayload.Queries["format"] = ExpressionConverter.Convert(__workflow_format);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "whoisfreaks")]
        public IWorkflowAction<ApiConnectionActionConfiguration> ReverseDnsLookup(Expression<Func<string>> value, Expression<Func<formatInput>> format, Expression<Func<string>> type = null, Expression<Func<bool>> exact = null, Expression<Func<int>> page = null)
        {
            var __workflow_value = WorkflowExpression.Compile(value, nameof(value), required: true);
            var __workflow_format = WorkflowExpression.Compile(format, nameof(format), required: true);
            var __workflow_type = WorkflowExpression.Compile(type, nameof(type), required: false);
            var __workflow_exact = WorkflowExpression.Compile(exact, nameof(exact), required: false);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2.1/dns/reverse";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["value"] = ExpressionConverter.Convert(__workflow_value);
                callPayload.Queries["type"] = Convert.ToString("a");
                if (__workflow_type != null)
                    callPayload.Queries["type"] = ExpressionConverter.Convert(__workflow_type);
                callPayload.Queries["exact"] = Convert.ToString(true);
                if (__workflow_exact != null)
                    callPayload.Queries["exact"] = ExpressionConverter.Convert(__workflow_exact);
                callPayload.Queries["page"] = Convert.ToString(1);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                callPayload.Queries["format"] = ExpressionConverter.Convert(__workflow_format);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "whoisfreaks")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DomainAvailabilityLookup(Expression<Func<string>> domain, Expression<Func<formatInput>> format, Expression<Func<bool>> sug = null)
        {
            var __workflow_domain = WorkflowExpression.Compile(domain, nameof(domain), required: true);
            var __workflow_format = WorkflowExpression.Compile(format, nameof(format), required: true);
            var __workflow_sug = WorkflowExpression.Compile(sug, nameof(sug), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1.0/domain/availability";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["domain"] = ExpressionConverter.Convert(__workflow_domain);
                callPayload.Queries["sug"] = Convert.ToString(false);
                if (__workflow_sug != null)
                    callPayload.Queries["sug"] = ExpressionConverter.Convert(__workflow_sug);
                callPayload.Queries["format"] = ExpressionConverter.Convert(__workflow_format);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "whoisfreaks")]
        public IWorkflowAction<ApiConnectionActionConfiguration> BulkDomainAvailabilityLookup(Expression<Func<formatInput>> format, Expression<Func<string[]>> bodydomainNames, Expression<Func<string>> contentType = null)
        {
            var __workflow_format = WorkflowExpression.Compile(format, nameof(format), required: true);
            var __workflow_bodydomainNames = WorkflowExpression.Compile(bodydomainNames, nameof(bodydomainNames), required: true);
            var __workflow_contentType = WorkflowExpression.Compile(contentType, nameof(contentType), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1.0/domain/availability";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["format"] = ExpressionConverter.Convert(__workflow_format);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (__workflow_contentType != null)
                    callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(__workflow_contentType);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["domainNames"] = ExpressionConverter.ConvertO(__workflow_bodydomainNames);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "whoisfreaks")]
        public IWorkflowAction<ApiConnectionActionConfiguration> TyposquattingLookup(Expression<Func<string>> keyword)
        {
            var __workflow_keyword = WorkflowExpression.Compile(keyword, nameof(keyword), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v3.0/domain/typos";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["keyword"] = ExpressionConverter.Convert(__workflow_keyword);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "whoisfreaks")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SSLLookup(Expression<Func<string>> domainName, Expression<Func<formatInput>> format, Expression<Func<bool>> chain = null, Expression<Func<bool>> sslRaw = null)
        {
            var __workflow_domainName = WorkflowExpression.Compile(domainName, nameof(domainName), required: true);
            var __workflow_format = WorkflowExpression.Compile(format, nameof(format), required: true);
            var __workflow_chain = WorkflowExpression.Compile(chain, nameof(chain), required: false);
            var __workflow_sslRaw = WorkflowExpression.Compile(sslRaw, nameof(sslRaw), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1.0/ssl/live";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["domainName"] = ExpressionConverter.Convert(__workflow_domainName);
                callPayload.Queries["chain"] = Convert.ToString(true);
                if (__workflow_chain != null)
                    callPayload.Queries["chain"] = ExpressionConverter.Convert(__workflow_chain);
                callPayload.Queries["sslRaw"] = Convert.ToString(false);
                if (__workflow_sslRaw != null)
                    callPayload.Queries["sslRaw"] = ExpressionConverter.Convert(__workflow_sslRaw);
                callPayload.Queries["format"] = ExpressionConverter.Convert(__workflow_format);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "whoisfreaks")]
        public IWorkflowAction<ApiConnectionActionConfiguration> IPGeolocationLookup(Expression<Func<string>> ip)
        {
            var __workflow_ip = WorkflowExpression.Compile(ip, nameof(ip), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1.0/geolocation";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["ip"] = ExpressionConverter.Convert(__workflow_ip);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "whoisfreaks")]
        public IWorkflowAction<ApiConnectionActionConfiguration> BulkIpGeolocationLookup(Expression<Func<string[]>> bodyips, Expression<Func<string>> contentType = null)
        {
            var __workflow_bodyips = WorkflowExpression.Compile(bodyips, nameof(bodyips), required: true);
            var __workflow_contentType = WorkflowExpression.Compile(contentType, nameof(contentType), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1.0/geolocation";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (__workflow_contentType != null)
                    callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(__workflow_contentType);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["ips"] = ExpressionConverter.ConvertO(__workflow_bodyips);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "whoisfreaks")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SubdomainLookup(Expression<Func<string>> domain, Expression<Func<formatInput>> format, Expression<Func<int>> page = null)
        {
            var __workflow_domain = WorkflowExpression.Compile(domain, nameof(domain), required: true);
            var __workflow_format = WorkflowExpression.Compile(format, nameof(format), required: true);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1.0/subdomains";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["domain"] = ExpressionConverter.Convert(__workflow_domain);
                callPayload.Queries["page"] = Convert.ToString(1);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                callPayload.Queries["format"] = ExpressionConverter.Convert(__workflow_format);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "whoisfreaks")]
        public IWorkflowAction<ApiConnectionActionConfiguration> IPReputationLookup(Expression<Func<string>> ip)
        {
            var __workflow_ip = WorkflowExpression.Compile(ip, nameof(ip), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1.0/security";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["ip"] = ExpressionConverter.Convert(__workflow_ip);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "whoisfreaks")]
        public IWorkflowAction<ApiConnectionActionConfiguration> BulkIpReputationLookup(Expression<Func<string[]>> bodyips, Expression<Func<string>> contentType = null)
        {
            var __workflow_bodyips = WorkflowExpression.Compile(bodyips, nameof(bodyips), required: true);
            var __workflow_contentType = WorkflowExpression.Compile(contentType, nameof(contentType), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1.0/security";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (__workflow_contentType != null)
                    callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(__workflow_contentType);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["ips"] = ExpressionConverter.ConvertO(__workflow_bodyips);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "whoisfreaks")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DomainReputationLookup(Expression<Func<string>> domainName, Expression<Func<formatInput>> format)
        {
            var __workflow_domainName = WorkflowExpression.Compile(domainName, nameof(domainName), required: true);
            var __workflow_format = WorkflowExpression.Compile(format, nameof(format), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/domain/security";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["domainName"] = ExpressionConverter.Convert(__workflow_domainName);
                callPayload.Queries["format"] = ExpressionConverter.Convert(__workflow_format);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "whoisfreaks")]
        public IWorkflowAction<ApiConnectionActionConfiguration> ReverseWhoisLookup(Expression<Func<string>> keyword)
        {
            var __workflow_keyword = WorkflowExpression.Compile(keyword, nameof(keyword), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2.0/whois/reverse";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["keyword"] = ExpressionConverter.Convert(__workflow_keyword);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "whoisfreaks")]
        public IWorkflowAction<ApiConnectionActionConfiguration> BulkWhoisLookup(Expression<Func<formatInput>> format, Expression<Func<string[]>> bodydomainNames, Expression<Func<string>> contentType = null)
        {
            var __workflow_format = WorkflowExpression.Compile(format, nameof(format), required: true);
            var __workflow_bodydomainNames = WorkflowExpression.Compile(bodydomainNames, nameof(bodydomainNames), required: true);
            var __workflow_contentType = WorkflowExpression.Compile(contentType, nameof(contentType), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2.0/bulkwhois/live";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["format"] = ExpressionConverter.Convert(__workflow_format);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (__workflow_contentType != null)
                    callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(__workflow_contentType);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["domainNames"] = ExpressionConverter.ConvertO(__workflow_bodydomainNames);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "whoisfreaks")]
        public IWorkflowAction<ApiConnectionActionConfiguration> BulkDomainLookup(Expression<Func<formatInput>> format, Expression<Func<string[]>> bodydomainNames, Expression<Func<string>> type = null, Expression<Func<string>> contentType = null, Expression<Func<string[]>> bodyipAddresses = null)
        {
            var __workflow_format = WorkflowExpression.Compile(format, nameof(format), required: true);
            var __workflow_bodydomainNames = WorkflowExpression.Compile(bodydomainNames, nameof(bodydomainNames), required: true);
            var __workflow_type = WorkflowExpression.Compile(type, nameof(type), required: false);
            var __workflow_contentType = WorkflowExpression.Compile(contentType, nameof(contentType), required: false);
            var __workflow_bodyipAddresses = WorkflowExpression.Compile(bodyipAddresses, nameof(bodyipAddresses), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2.0/dns/bulk/live";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["type"] = Convert.ToString("all");
                if (__workflow_type != null)
                    callPayload.Queries["type"] = ExpressionConverter.Convert(__workflow_type);
                callPayload.Queries["format"] = ExpressionConverter.Convert(__workflow_format);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (__workflow_contentType != null)
                    callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(__workflow_contentType);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["domainNames"] = ExpressionConverter.ConvertO(__workflow_bodydomainNames);
                if (__workflow_bodyipAddresses != null)
                {
                    body["ipAddresses"] = ExpressionConverter.ConvertO(__workflow_bodyipAddresses);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "whoisfreaks")]
        public IWorkflowAction<ApiConnectionActionConfiguration> IPWhois(Expression<Func<string>> ip)
        {
            var __workflow_ip = WorkflowExpression.Compile(ip, nameof(ip), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1.0/ip-whois";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["ip"] = ExpressionConverter.Convert(__workflow_ip);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "whoisfreaks")]
        public IWorkflowAction<ApiConnectionActionConfiguration> AccountUsage()
        {
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1.0/whoisapi/usage";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "whoisfreaks")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DatabaseFileStatus()
        {
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v3.3/status";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "whoisfreaks")]
        public IWorkflowAction<ApiConnectionActionConfiguration> RotateApiKey()
        {
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1.0/api-key/rotate";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "whoisfreaks")]
        public IWorkflowAction<ApiConnectionActionConfiguration> AsnWhois(Expression<Func<string>> asn, Expression<Func<formatInput>> format)
        {
            var __workflow_asn = WorkflowExpression.Compile(asn, nameof(asn), required: true);
            var __workflow_format = WorkflowExpression.Compile(format, nameof(format), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2.0/asn-whois";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["asn"] = ExpressionConverter.Convert(__workflow_asn);
                callPayload.Queries["format"] = ExpressionConverter.Convert(__workflow_format);
                return new ApiConnectionAction(callPayload);
            });
        }
    }

    public class WhoisfreaksTriggers([ConnectionName] string connectionId)
    {
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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