//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Riskiqintelligence
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class RiskiqintelligenceActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqintelligence")]
        public IBodyWorkflowAction<RRSets> PDNSIP([WorkflowExpression] Func<string> ip, [WorkflowExpression] Func<string> max = null, [WorkflowExpression] Func<string> lastSeenAfter = null, [WorkflowExpression] Func<string> firstSeenBefore = null)
        {
            SourceExpression.Validate(ip, nameof(ip), required: true);
            SourceExpression.Validate(max, nameof(max), required: false);
            SourceExpression.Validate(lastSeenAfter, nameof(lastSeenAfter), required: false);
            SourceExpression.Validate(firstSeenBefore, nameof(firstSeenBefore), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v0/pdns/data/ip";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["ip"] = SourceExpressionConverter.ConvertO(ip);
                if (max != null)
                    callPayload.Queries["max"] = SourceExpressionConverter.ConvertO(max);
                if (lastSeenAfter != null)
                    callPayload.Queries["lastSeenAfter"] = SourceExpressionConverter.ConvertO(lastSeenAfter);
                if (firstSeenBefore != null)
                    callPayload.Queries["firstSeenBefore"] = SourceExpressionConverter.ConvertO(firstSeenBefore);
                return callPayload;
            }

            return new ApiConnectionAction<RRSets>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqintelligence")]
        public IBodyWorkflowAction<RRSets> PDNSRESOURCEDATA([WorkflowExpression] Func<string> name, [WorkflowExpression] Func<string> type = null, [WorkflowExpression] Func<string> max = null, [WorkflowExpression] Func<string> lastSeenAfter = null, [WorkflowExpression] Func<string> firstSeenBefore = null)
        {
            SourceExpression.Validate(name, nameof(name), required: true);
            SourceExpression.Validate(type, nameof(type), required: false);
            SourceExpression.Validate(max, nameof(max), required: false);
            SourceExpression.Validate(lastSeenAfter, nameof(lastSeenAfter), required: false);
            SourceExpression.Validate(firstSeenBefore, nameof(firstSeenBefore), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v0/pdns/data/name";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["name"] = SourceExpressionConverter.ConvertO(name);
                if (type != null)
                    callPayload.Queries["type"] = SourceExpressionConverter.ConvertO(type);
                if (max != null)
                    callPayload.Queries["max"] = SourceExpressionConverter.ConvertO(max);
                if (lastSeenAfter != null)
                    callPayload.Queries["lastSeenAfter"] = SourceExpressionConverter.ConvertO(lastSeenAfter);
                if (firstSeenBefore != null)
                    callPayload.Queries["firstSeenBefore"] = SourceExpressionConverter.ConvertO(firstSeenBefore);
                return callPayload;
            }

            return new ApiConnectionAction<RRSets>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqintelligence")]
        public IBodyWorkflowAction<RRSets> PDNSRESOURCEDATAHEX([WorkflowExpression] Func<string> hex, [WorkflowExpression] Func<string> type = null, [WorkflowExpression] Func<string> max = null, [WorkflowExpression] Func<string> lastSeenAfter = null, [WorkflowExpression] Func<string> firstSeenBefore = null)
        {
            SourceExpression.Validate(hex, nameof(hex), required: true);
            SourceExpression.Validate(type, nameof(type), required: false);
            SourceExpression.Validate(max, nameof(max), required: false);
            SourceExpression.Validate(lastSeenAfter, nameof(lastSeenAfter), required: false);
            SourceExpression.Validate(firstSeenBefore, nameof(firstSeenBefore), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v0/pdns/data/raw";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (type != null)
                    callPayload.Queries["type"] = SourceExpressionConverter.ConvertO(type);
                if (max != null)
                    callPayload.Queries["max"] = SourceExpressionConverter.ConvertO(max);
                if (lastSeenAfter != null)
                    callPayload.Queries["lastSeenAfter"] = SourceExpressionConverter.ConvertO(lastSeenAfter);
                if (firstSeenBefore != null)
                    callPayload.Queries["firstSeenBefore"] = SourceExpressionConverter.ConvertO(firstSeenBefore);
                callPayload.Queries["hex"] = SourceExpressionConverter.ConvertO(hex);
                return callPayload;
            }

            return new ApiConnectionAction<RRSets>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqintelligence")]
        public IBodyWorkflowAction<RRSets> PDNSNAME([WorkflowExpression] Func<string> name, [WorkflowExpression] Func<string> type = null, [WorkflowExpression] Func<string> max = null, [WorkflowExpression] Func<string> lastSeenAfter = null, [WorkflowExpression] Func<string> firstSeenBefore = null)
        {
            SourceExpression.Validate(name, nameof(name), required: true);
            SourceExpression.Validate(type, nameof(type), required: false);
            SourceExpression.Validate(max, nameof(max), required: false);
            SourceExpression.Validate(lastSeenAfter, nameof(lastSeenAfter), required: false);
            SourceExpression.Validate(firstSeenBefore, nameof(firstSeenBefore), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v0/pdns/name";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["name"] = SourceExpressionConverter.ConvertO(name);
                if (type != null)
                    callPayload.Queries["type"] = SourceExpressionConverter.ConvertO(type);
                if (max != null)
                    callPayload.Queries["max"] = SourceExpressionConverter.ConvertO(max);
                if (lastSeenAfter != null)
                    callPayload.Queries["lastSeenAfter"] = SourceExpressionConverter.ConvertO(lastSeenAfter);
                if (firstSeenBefore != null)
                    callPayload.Queries["firstSeenBefore"] = SourceExpressionConverter.ConvertO(firstSeenBefore);
                return callPayload;
            }

            return new ApiConnectionAction<RRSets>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqintelligence")]
        public IBodyWorkflowAction<SslCertWithHostPage> SSLBYHOST([WorkflowExpression] Func<string> host)
        {
            SourceExpression.Validate(host, nameof(host), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/ssl/cert/host";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["host"] = SourceExpressionConverter.ConvertO(host);
                return callPayload;
            }

            return new ApiConnectionAction<SslCertWithHostPage>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqintelligence")]
        public IBodyWorkflowAction<SslCertPage> SSLBYSERIAL([WorkflowExpression] Func<string> serial)
        {
            SourceExpression.Validate(serial, nameof(serial), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/ssl/cert/serial";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["serial"] = SourceExpressionConverter.ConvertO(serial);
                return callPayload;
            }

            return new ApiConnectionAction<SslCertPage>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqintelligence")]
        public IBodyWorkflowAction<SslCert> SSLBYSHA1([WorkflowExpression] Func<string> sha1)
        {
            SourceExpression.Validate(sha1, nameof(sha1), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/ssl/cert/sha1";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["sha1"] = SourceExpressionConverter.ConvertO(sha1);
                return callPayload;
            }

            return new ApiConnectionAction<SslCert>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqintelligence")]
        public IBodyWorkflowAction<SslCertHostPage> HOSTSBYSSLSHA1([WorkflowExpression] Func<string> certSha1)
        {
            SourceExpression.Validate(certSha1, nameof(certSha1), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/ssl/host";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["certSha1"] = SourceExpressionConverter.ConvertO(certSha1);
                return callPayload;
            }

            return new ApiConnectionAction<SslCertHostPage>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqintelligence")]
        public IBodyWorkflowAction<SslCertPage> SSLBYNAME([WorkflowExpression] Func<string> name)
        {
            SourceExpression.Validate(name, nameof(name), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/ssl/cert/name";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["name"] = SourceExpressionConverter.ConvertO(name);
                return callPayload;
            }

            return new ApiConnectionAction<SslCertPage>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqintelligence")]
        public IBodyWorkflowAction<WhoisResult> WHOISIP([WorkflowExpression] Func<string> address, [WorkflowExpression] Func<string> exact = null, [WorkflowExpression] Func<string> maxResults = null)
        {
            SourceExpression.Validate(address, nameof(address), required: true);
            SourceExpression.Validate(exact, nameof(exact), required: false);
            SourceExpression.Validate(maxResults, nameof(maxResults), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v0/whois/address";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["address"] = SourceExpressionConverter.ConvertO(address);
                if (exact != null)
                    callPayload.Queries["exact"] = SourceExpressionConverter.ConvertO(exact);
                if (maxResults != null)
                    callPayload.Queries["maxResults"] = SourceExpressionConverter.ConvertO(maxResults);
                return callPayload;
            }

            return new ApiConnectionAction<WhoisResult>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqintelligence")]
        public IBodyWorkflowAction<WhoisResult> WHOISDOMAIN([WorkflowExpression] Func<string> domain, [WorkflowExpression] Func<string> exact = null, [WorkflowExpression] Func<string> maxResults = null)
        {
            SourceExpression.Validate(domain, nameof(domain), required: true);
            SourceExpression.Validate(exact, nameof(exact), required: false);
            SourceExpression.Validate(maxResults, nameof(maxResults), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v0/whois/domain";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["domain"] = SourceExpressionConverter.ConvertO(domain);
                if (exact != null)
                    callPayload.Queries["exact"] = SourceExpressionConverter.ConvertO(exact);
                if (maxResults != null)
                    callPayload.Queries["maxResults"] = SourceExpressionConverter.ConvertO(maxResults);
                return callPayload;
            }

            return new ApiConnectionAction<WhoisResult>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqintelligence")]
        public IBodyWorkflowAction<WhoisResult> WHOISBYEMAIL([WorkflowExpression] Func<string> email, [WorkflowExpression] Func<string> exact = null, [WorkflowExpression] Func<string> maxResults = null)
        {
            SourceExpression.Validate(email, nameof(email), required: true);
            SourceExpression.Validate(exact, nameof(exact), required: false);
            SourceExpression.Validate(maxResults, nameof(maxResults), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v0/whois/email";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["email"] = SourceExpressionConverter.ConvertO(email);
                if (exact != null)
                    callPayload.Queries["exact"] = SourceExpressionConverter.ConvertO(exact);
                if (maxResults != null)
                    callPayload.Queries["maxResults"] = SourceExpressionConverter.ConvertO(maxResults);
                return callPayload;
            }

            return new ApiConnectionAction<WhoisResult>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqintelligence")]
        public IBodyWorkflowAction<WhoisResult> WHOISBYNAME([WorkflowExpression] Func<string> name, [WorkflowExpression] Func<string> exact = null, [WorkflowExpression] Func<string> maxResults = null)
        {
            SourceExpression.Validate(name, nameof(name), required: true);
            SourceExpression.Validate(exact, nameof(exact), required: false);
            SourceExpression.Validate(maxResults, nameof(maxResults), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v0/whois/name";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["name"] = SourceExpressionConverter.ConvertO(name);
                if (exact != null)
                    callPayload.Queries["exact"] = SourceExpressionConverter.ConvertO(exact);
                if (maxResults != null)
                    callPayload.Queries["maxResults"] = SourceExpressionConverter.ConvertO(maxResults);
                return callPayload;
            }

            return new ApiConnectionAction<WhoisResult>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqintelligence")]
        public IBodyWorkflowAction<WhoisResult> WHOISBYNAMESERVER([WorkflowExpression] Func<string> nameserver, [WorkflowExpression] Func<string> exact = null, [WorkflowExpression] Func<string> maxResults = null)
        {
            SourceExpression.Validate(nameserver, nameof(nameserver), required: true);
            SourceExpression.Validate(exact, nameof(exact), required: false);
            SourceExpression.Validate(maxResults, nameof(maxResults), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v0/whois/nameserver";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["nameserver"] = SourceExpressionConverter.ConvertO(nameserver);
                if (exact != null)
                    callPayload.Queries["exact"] = SourceExpressionConverter.ConvertO(exact);
                if (maxResults != null)
                    callPayload.Queries["maxResults"] = SourceExpressionConverter.ConvertO(maxResults);
                return callPayload;
            }

            return new ApiConnectionAction<WhoisResult>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqintelligence")]
        public IBodyWorkflowAction<WhoisResult> WHOISBYORGANIZATION([WorkflowExpression] Func<string> org, [WorkflowExpression] Func<string> exact = null, [WorkflowExpression] Func<string> maxResults = null)
        {
            SourceExpression.Validate(org, nameof(org), required: true);
            SourceExpression.Validate(exact, nameof(exact), required: false);
            SourceExpression.Validate(maxResults, nameof(maxResults), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v0/whois/org";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["org"] = SourceExpressionConverter.ConvertO(org);
                if (exact != null)
                    callPayload.Queries["exact"] = SourceExpressionConverter.ConvertO(exact);
                if (maxResults != null)
                    callPayload.Queries["maxResults"] = SourceExpressionConverter.ConvertO(maxResults);
                return callPayload;
            }

            return new ApiConnectionAction<WhoisResult>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqintelligence")]
        public IBodyWorkflowAction<WhoisResult> WHOISBYPHONE([WorkflowExpression] Func<string> phone, [WorkflowExpression] Func<string> exact = null, [WorkflowExpression] Func<string> maxResults = null)
        {
            SourceExpression.Validate(phone, nameof(phone), required: true);
            SourceExpression.Validate(exact, nameof(exact), required: false);
            SourceExpression.Validate(maxResults, nameof(maxResults), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v0/whois/phone";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["phone"] = SourceExpressionConverter.ConvertO(phone);
                if (exact != null)
                    callPayload.Queries["exact"] = SourceExpressionConverter.ConvertO(exact);
                if (maxResults != null)
                    callPayload.Queries["maxResults"] = SourceExpressionConverter.ConvertO(maxResults);
                return callPayload;
            }

            return new ApiConnectionAction<WhoisResult>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqintelligence")]
        public IBodyWorkflowAction<HostAttributeResult> TRACKERSHOST([WorkflowExpression] Func<string> host, [WorkflowExpression] Func<int> size = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> before = null, [WorkflowExpression] Func<int> after = null, [WorkflowExpression] Func<int> beforeDay = null, [WorkflowExpression] Func<int> afterDay = null, [WorkflowExpression] Func<string> exact = null)
        {
            SourceExpression.Validate(host, nameof(host), required: true);
            SourceExpression.Validate(size, nameof(size), required: false);
            SourceExpression.Validate(page, nameof(page), required: false);
            SourceExpression.Validate(before, nameof(before), required: false);
            SourceExpression.Validate(after, nameof(after), required: false);
            SourceExpression.Validate(beforeDay, nameof(beforeDay), required: false);
            SourceExpression.Validate(afterDay, nameof(afterDay), required: false);
            SourceExpression.Validate(exact, nameof(exact), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v0/hostattributes/hosts/trackers/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(host, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (size != null)
                    callPayload.Queries["size"] = SourceExpressionConverter.ConvertO(size);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (before != null)
                    callPayload.Queries["before"] = SourceExpressionConverter.ConvertO(before);
                if (after != null)
                    callPayload.Queries["after"] = SourceExpressionConverter.ConvertO(after);
                if (beforeDay != null)
                    callPayload.Queries["beforeDay"] = SourceExpressionConverter.ConvertO(beforeDay);
                if (afterDay != null)
                    callPayload.Queries["afterDay"] = SourceExpressionConverter.ConvertO(afterDay);
                if (exact != null)
                    callPayload.Queries["exact"] = SourceExpressionConverter.ConvertO(exact);
                return callPayload;
            }

            return new ApiConnectionAction<HostAttributeResult>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqintelligence")]
        public IBodyWorkflowAction<HostAttributeResult> TRACKERSDOMAIN([WorkflowExpression] Func<string> domain, [WorkflowExpression] Func<int> size = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> before = null, [WorkflowExpression] Func<int> after = null, [WorkflowExpression] Func<int> beforeDay = null, [WorkflowExpression] Func<int> afterDay = null, [WorkflowExpression] Func<string> exact = null)
        {
            SourceExpression.Validate(domain, nameof(domain), required: true);
            SourceExpression.Validate(size, nameof(size), required: false);
            SourceExpression.Validate(page, nameof(page), required: false);
            SourceExpression.Validate(before, nameof(before), required: false);
            SourceExpression.Validate(after, nameof(after), required: false);
            SourceExpression.Validate(beforeDay, nameof(beforeDay), required: false);
            SourceExpression.Validate(afterDay, nameof(afterDay), required: false);
            SourceExpression.Validate(exact, nameof(exact), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v0/hostattributes/domains/trackers/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(domain, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (size != null)
                    callPayload.Queries["size"] = SourceExpressionConverter.ConvertO(size);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (before != null)
                    callPayload.Queries["before"] = SourceExpressionConverter.ConvertO(before);
                if (after != null)
                    callPayload.Queries["after"] = SourceExpressionConverter.ConvertO(after);
                if (beforeDay != null)
                    callPayload.Queries["beforeDay"] = SourceExpressionConverter.ConvertO(beforeDay);
                if (afterDay != null)
                    callPayload.Queries["afterDay"] = SourceExpressionConverter.ConvertO(afterDay);
                if (exact != null)
                    callPayload.Queries["exact"] = SourceExpressionConverter.ConvertO(exact);
                return callPayload;
            }

            return new ApiConnectionAction<HostAttributeResult>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqintelligence")]
        public IBodyWorkflowAction<HostAttributeResult> TRACKERSIP([WorkflowExpression] Func<string> address, [WorkflowExpression] Func<int> size = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> before = null, [WorkflowExpression] Func<int> after = null, [WorkflowExpression] Func<int> beforeDay = null, [WorkflowExpression] Func<int> afterDay = null, [WorkflowExpression] Func<string> exact = null)
        {
            SourceExpression.Validate(address, nameof(address), required: true);
            SourceExpression.Validate(size, nameof(size), required: false);
            SourceExpression.Validate(page, nameof(page), required: false);
            SourceExpression.Validate(before, nameof(before), required: false);
            SourceExpression.Validate(after, nameof(after), required: false);
            SourceExpression.Validate(beforeDay, nameof(beforeDay), required: false);
            SourceExpression.Validate(afterDay, nameof(afterDay), required: false);
            SourceExpression.Validate(exact, nameof(exact), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v0/hostattributes/addresses/trackers/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(address, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (size != null)
                    callPayload.Queries["size"] = SourceExpressionConverter.ConvertO(size);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (before != null)
                    callPayload.Queries["before"] = SourceExpressionConverter.ConvertO(before);
                if (after != null)
                    callPayload.Queries["after"] = SourceExpressionConverter.ConvertO(after);
                if (beforeDay != null)
                    callPayload.Queries["beforeDay"] = SourceExpressionConverter.ConvertO(beforeDay);
                if (afterDay != null)
                    callPayload.Queries["afterDay"] = SourceExpressionConverter.ConvertO(afterDay);
                if (exact != null)
                    callPayload.Queries["exact"] = SourceExpressionConverter.ConvertO(exact);
                return callPayload;
            }

            return new ApiConnectionAction<HostAttributeResult>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqintelligence")]
        public IBodyWorkflowAction<HostPairsResult> HOSTPAIRSCHILD([WorkflowExpression] Func<string> host, [WorkflowExpression] Func<int> size = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> before = null, [WorkflowExpression] Func<int> after = null, [WorkflowExpression] Func<int> beforeDay = null, [WorkflowExpression] Func<int> afterDay = null, [WorkflowExpression] Func<string> exact = null)
        {
            SourceExpression.Validate(host, nameof(host), required: true);
            SourceExpression.Validate(size, nameof(size), required: false);
            SourceExpression.Validate(page, nameof(page), required: false);
            SourceExpression.Validate(before, nameof(before), required: false);
            SourceExpression.Validate(after, nameof(after), required: false);
            SourceExpression.Validate(beforeDay, nameof(beforeDay), required: false);
            SourceExpression.Validate(afterDay, nameof(afterDay), required: false);
            SourceExpression.Validate(exact, nameof(exact), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v0/hostattributes/hosts/trackers/children/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(host, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (size != null)
                    callPayload.Queries["size"] = SourceExpressionConverter.ConvertO(size);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (before != null)
                    callPayload.Queries["before"] = SourceExpressionConverter.ConvertO(before);
                if (after != null)
                    callPayload.Queries["after"] = SourceExpressionConverter.ConvertO(after);
                if (beforeDay != null)
                    callPayload.Queries["beforeDay"] = SourceExpressionConverter.ConvertO(beforeDay);
                if (afterDay != null)
                    callPayload.Queries["afterDay"] = SourceExpressionConverter.ConvertO(afterDay);
                if (exact != null)
                    callPayload.Queries["exact"] = SourceExpressionConverter.ConvertO(exact);
                return callPayload;
            }

            return new ApiConnectionAction<HostPairsResult>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqintelligence")]
        public IBodyWorkflowAction<HostPairsResult> HOSTPAIRSPARENT([WorkflowExpression] Func<string> host, [WorkflowExpression] Func<int> size = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> before = null, [WorkflowExpression] Func<int> after = null, [WorkflowExpression] Func<int> beforeDay = null, [WorkflowExpression] Func<int> afterDay = null, [WorkflowExpression] Func<string> exact = null)
        {
            SourceExpression.Validate(host, nameof(host), required: true);
            SourceExpression.Validate(size, nameof(size), required: false);
            SourceExpression.Validate(page, nameof(page), required: false);
            SourceExpression.Validate(before, nameof(before), required: false);
            SourceExpression.Validate(after, nameof(after), required: false);
            SourceExpression.Validate(beforeDay, nameof(beforeDay), required: false);
            SourceExpression.Validate(afterDay, nameof(afterDay), required: false);
            SourceExpression.Validate(exact, nameof(exact), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v0/hostattributes/hosts/trackers/parents/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(host, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (size != null)
                    callPayload.Queries["size"] = SourceExpressionConverter.ConvertO(size);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (before != null)
                    callPayload.Queries["before"] = SourceExpressionConverter.ConvertO(before);
                if (after != null)
                    callPayload.Queries["after"] = SourceExpressionConverter.ConvertO(after);
                if (beforeDay != null)
                    callPayload.Queries["beforeDay"] = SourceExpressionConverter.ConvertO(beforeDay);
                if (afterDay != null)
                    callPayload.Queries["afterDay"] = SourceExpressionConverter.ConvertO(afterDay);
                if (exact != null)
                    callPayload.Queries["exact"] = SourceExpressionConverter.ConvertO(exact);
                return callPayload;
            }

            return new ApiConnectionAction<HostPairsResult>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqintelligence")]
        public IBodyWorkflowAction<HostComponentsResult> WEBCOMPONENTHOST([WorkflowExpression] Func<string> host, [WorkflowExpression] Func<int> size = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> before = null, [WorkflowExpression] Func<int> after = null, [WorkflowExpression] Func<int> beforeDay = null, [WorkflowExpression] Func<int> afterDay = null, [WorkflowExpression] Func<string> exact = null)
        {
            SourceExpression.Validate(host, nameof(host), required: true);
            SourceExpression.Validate(size, nameof(size), required: false);
            SourceExpression.Validate(page, nameof(page), required: false);
            SourceExpression.Validate(before, nameof(before), required: false);
            SourceExpression.Validate(after, nameof(after), required: false);
            SourceExpression.Validate(beforeDay, nameof(beforeDay), required: false);
            SourceExpression.Validate(afterDay, nameof(afterDay), required: false);
            SourceExpression.Validate(exact, nameof(exact), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v0/hostattributes/hosts/components/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(host, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (size != null)
                    callPayload.Queries["size"] = SourceExpressionConverter.ConvertO(size);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (before != null)
                    callPayload.Queries["before"] = SourceExpressionConverter.ConvertO(before);
                if (after != null)
                    callPayload.Queries["after"] = SourceExpressionConverter.ConvertO(after);
                if (beforeDay != null)
                    callPayload.Queries["beforeDay"] = SourceExpressionConverter.ConvertO(beforeDay);
                if (afterDay != null)
                    callPayload.Queries["afterDay"] = SourceExpressionConverter.ConvertO(afterDay);
                if (exact != null)
                    callPayload.Queries["exact"] = SourceExpressionConverter.ConvertO(exact);
                return callPayload;
            }

            return new ApiConnectionAction<HostComponentsResult>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqintelligence")]
        public IBodyWorkflowAction<HostComponentsResult> WEBCOMPONENTSDOMAIN([WorkflowExpression] Func<string> domain, [WorkflowExpression] Func<int> size = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> before = null, [WorkflowExpression] Func<int> after = null, [WorkflowExpression] Func<int> beforeDay = null, [WorkflowExpression] Func<int> afterDay = null, [WorkflowExpression] Func<string> exact = null)
        {
            SourceExpression.Validate(domain, nameof(domain), required: true);
            SourceExpression.Validate(size, nameof(size), required: false);
            SourceExpression.Validate(page, nameof(page), required: false);
            SourceExpression.Validate(before, nameof(before), required: false);
            SourceExpression.Validate(after, nameof(after), required: false);
            SourceExpression.Validate(beforeDay, nameof(beforeDay), required: false);
            SourceExpression.Validate(afterDay, nameof(afterDay), required: false);
            SourceExpression.Validate(exact, nameof(exact), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v0/hostattributes/domains/components/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(domain, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (size != null)
                    callPayload.Queries["size"] = SourceExpressionConverter.ConvertO(size);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (before != null)
                    callPayload.Queries["before"] = SourceExpressionConverter.ConvertO(before);
                if (after != null)
                    callPayload.Queries["after"] = SourceExpressionConverter.ConvertO(after);
                if (beforeDay != null)
                    callPayload.Queries["beforeDay"] = SourceExpressionConverter.ConvertO(beforeDay);
                if (afterDay != null)
                    callPayload.Queries["afterDay"] = SourceExpressionConverter.ConvertO(afterDay);
                if (exact != null)
                    callPayload.Queries["exact"] = SourceExpressionConverter.ConvertO(exact);
                return callPayload;
            }

            return new ApiConnectionAction<HostComponentsResult>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqintelligence")]
        public IBodyWorkflowAction<HostComponentsResult> WEBCOMPONENTSIP([WorkflowExpression] Func<string> address, [WorkflowExpression] Func<int> size = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> before = null, [WorkflowExpression] Func<int> after = null, [WorkflowExpression] Func<int> beforeDay = null, [WorkflowExpression] Func<int> afterDay = null, [WorkflowExpression] Func<string> exact = null)
        {
            SourceExpression.Validate(address, nameof(address), required: true);
            SourceExpression.Validate(size, nameof(size), required: false);
            SourceExpression.Validate(page, nameof(page), required: false);
            SourceExpression.Validate(before, nameof(before), required: false);
            SourceExpression.Validate(after, nameof(after), required: false);
            SourceExpression.Validate(beforeDay, nameof(beforeDay), required: false);
            SourceExpression.Validate(afterDay, nameof(afterDay), required: false);
            SourceExpression.Validate(exact, nameof(exact), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v0/hostattributes/addresses/components/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(address, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (size != null)
                    callPayload.Queries["size"] = SourceExpressionConverter.ConvertO(size);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (before != null)
                    callPayload.Queries["before"] = SourceExpressionConverter.ConvertO(before);
                if (after != null)
                    callPayload.Queries["after"] = SourceExpressionConverter.ConvertO(after);
                if (beforeDay != null)
                    callPayload.Queries["beforeDay"] = SourceExpressionConverter.ConvertO(beforeDay);
                if (afterDay != null)
                    callPayload.Queries["afterDay"] = SourceExpressionConverter.ConvertO(afterDay);
                if (exact != null)
                    callPayload.Queries["exact"] = SourceExpressionConverter.ConvertO(exact);
                return callPayload;
            }

            return new ApiConnectionAction<HostComponentsResult>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqintelligence")]
        public IBodyWorkflowAction<HostCookieResult> COOKIESHOST([WorkflowExpression] Func<string> host, [WorkflowExpression] Func<int> size = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> before = null, [WorkflowExpression] Func<int> after = null, [WorkflowExpression] Func<int> beforeDay = null, [WorkflowExpression] Func<int> afterDay = null, [WorkflowExpression] Func<string> exact = null)
        {
            SourceExpression.Validate(host, nameof(host), required: true);
            SourceExpression.Validate(size, nameof(size), required: false);
            SourceExpression.Validate(page, nameof(page), required: false);
            SourceExpression.Validate(before, nameof(before), required: false);
            SourceExpression.Validate(after, nameof(after), required: false);
            SourceExpression.Validate(beforeDay, nameof(beforeDay), required: false);
            SourceExpression.Validate(afterDay, nameof(afterDay), required: false);
            SourceExpression.Validate(exact, nameof(exact), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v0/hostattributes/hosts/cookies/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(host, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (size != null)
                    callPayload.Queries["size"] = SourceExpressionConverter.ConvertO(size);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (before != null)
                    callPayload.Queries["before"] = SourceExpressionConverter.ConvertO(before);
                if (after != null)
                    callPayload.Queries["after"] = SourceExpressionConverter.ConvertO(after);
                if (beforeDay != null)
                    callPayload.Queries["beforeDay"] = SourceExpressionConverter.ConvertO(beforeDay);
                if (afterDay != null)
                    callPayload.Queries["afterDay"] = SourceExpressionConverter.ConvertO(afterDay);
                if (exact != null)
                    callPayload.Queries["exact"] = SourceExpressionConverter.ConvertO(exact);
                return callPayload;
            }

            return new ApiConnectionAction<HostCookieResult>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqintelligence")]
        public IBodyWorkflowAction<HostCookieResult> COOKIESIP([WorkflowExpression] Func<string> address, [WorkflowExpression] Func<int> size = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> before = null, [WorkflowExpression] Func<int> after = null, [WorkflowExpression] Func<int> beforeDay = null, [WorkflowExpression] Func<int> afterDay = null, [WorkflowExpression] Func<string> exact = null)
        {
            SourceExpression.Validate(address, nameof(address), required: true);
            SourceExpression.Validate(size, nameof(size), required: false);
            SourceExpression.Validate(page, nameof(page), required: false);
            SourceExpression.Validate(before, nameof(before), required: false);
            SourceExpression.Validate(after, nameof(after), required: false);
            SourceExpression.Validate(beforeDay, nameof(beforeDay), required: false);
            SourceExpression.Validate(afterDay, nameof(afterDay), required: false);
            SourceExpression.Validate(exact, nameof(exact), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v0/hostattributes/addresses/cookies/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(address, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (size != null)
                    callPayload.Queries["size"] = SourceExpressionConverter.ConvertO(size);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (before != null)
                    callPayload.Queries["before"] = SourceExpressionConverter.ConvertO(before);
                if (after != null)
                    callPayload.Queries["after"] = SourceExpressionConverter.ConvertO(after);
                if (beforeDay != null)
                    callPayload.Queries["beforeDay"] = SourceExpressionConverter.ConvertO(beforeDay);
                if (afterDay != null)
                    callPayload.Queries["afterDay"] = SourceExpressionConverter.ConvertO(afterDay);
                if (exact != null)
                    callPayload.Queries["exact"] = SourceExpressionConverter.ConvertO(exact);
                return callPayload;
            }

            return new ApiConnectionAction<HostCookieResult>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqintelligence")]
        public IBodyWorkflowAction<JToken> ENRICHMENTHOST([WorkflowExpression] Func<string> host, [WorkflowExpression] Func<bool> whois = null, [WorkflowExpression] Func<bool> hostDetails = null, [WorkflowExpression] Func<bool> ipDetails = null, [WorkflowExpression] Func<bool> linkedAssetCounts = null, [WorkflowExpression] Func<bool> recentPDNS = null, [WorkflowExpression] Func<bool> subDomainPDNS = null, [WorkflowExpression] Func<bool> openPorts = null, [WorkflowExpression] Func<bool> certificates = null)
        {
            SourceExpression.Validate(host, nameof(host), required: true);
            SourceExpression.Validate(whois, nameof(whois), required: false);
            SourceExpression.Validate(hostDetails, nameof(hostDetails), required: false);
            SourceExpression.Validate(ipDetails, nameof(ipDetails), required: false);
            SourceExpression.Validate(linkedAssetCounts, nameof(linkedAssetCounts), required: false);
            SourceExpression.Validate(recentPDNS, nameof(recentPDNS), required: false);
            SourceExpression.Validate(subDomainPDNS, nameof(subDomainPDNS), required: false);
            SourceExpression.Validate(openPorts, nameof(openPorts), required: false);
            SourceExpression.Validate(certificates, nameof(certificates), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v0/enrich/host/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(host, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["whois"] = Convert.ToString(true);
                if (whois != null)
                    callPayload.Queries["whois"] = SourceExpressionConverter.ConvertO(whois);
                callPayload.Queries["hostDetails"] = Convert.ToString(true);
                if (hostDetails != null)
                    callPayload.Queries["hostDetails"] = SourceExpressionConverter.ConvertO(hostDetails);
                callPayload.Queries["ipDetails"] = Convert.ToString(true);
                if (ipDetails != null)
                    callPayload.Queries["ipDetails"] = SourceExpressionConverter.ConvertO(ipDetails);
                callPayload.Queries["linkedAssetCounts"] = Convert.ToString(true);
                if (linkedAssetCounts != null)
                    callPayload.Queries["linkedAssetCounts"] = SourceExpressionConverter.ConvertO(linkedAssetCounts);
                callPayload.Queries["recentPDNS"] = Convert.ToString(true);
                if (recentPDNS != null)
                    callPayload.Queries["recentPDNS"] = SourceExpressionConverter.ConvertO(recentPDNS);
                callPayload.Queries["subDomainPDNS"] = Convert.ToString(true);
                if (subDomainPDNS != null)
                    callPayload.Queries["subDomainPDNS"] = SourceExpressionConverter.ConvertO(subDomainPDNS);
                callPayload.Queries["openPorts"] = Convert.ToString(true);
                if (openPorts != null)
                    callPayload.Queries["openPorts"] = SourceExpressionConverter.ConvertO(openPorts);
                callPayload.Queries["certificates"] = Convert.ToString(true);
                if (certificates != null)
                    callPayload.Queries["certificates"] = SourceExpressionConverter.ConvertO(certificates);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqintelligence")]
        public IBodyWorkflowAction<JToken> ENRICHMENTIP([WorkflowExpression] Func<string> ip, [WorkflowExpression] Func<bool> whois = null, [WorkflowExpression] Func<bool> hostDetails = null, [WorkflowExpression] Func<bool> linkedAssetCounts = null, [WorkflowExpression] Func<bool> openPorts = null, [WorkflowExpression] Func<bool> certificates = null)
        {
            SourceExpression.Validate(ip, nameof(ip), required: true);
            SourceExpression.Validate(whois, nameof(whois), required: false);
            SourceExpression.Validate(hostDetails, nameof(hostDetails), required: false);
            SourceExpression.Validate(linkedAssetCounts, nameof(linkedAssetCounts), required: false);
            SourceExpression.Validate(openPorts, nameof(openPorts), required: false);
            SourceExpression.Validate(certificates, nameof(certificates), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v0/enrich/ip/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(ip, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["whois"] = Convert.ToString(true);
                if (whois != null)
                    callPayload.Queries["whois"] = SourceExpressionConverter.ConvertO(whois);
                callPayload.Queries["hostDetails"] = Convert.ToString(true);
                if (hostDetails != null)
                    callPayload.Queries["hostDetails"] = SourceExpressionConverter.ConvertO(hostDetails);
                callPayload.Queries["linkedAssetCounts"] = Convert.ToString(true);
                if (linkedAssetCounts != null)
                    callPayload.Queries["linkedAssetCounts"] = SourceExpressionConverter.ConvertO(linkedAssetCounts);
                callPayload.Queries["openPorts"] = Convert.ToString(true);
                if (openPorts != null)
                    callPayload.Queries["openPorts"] = SourceExpressionConverter.ConvertO(openPorts);
                callPayload.Queries["certificates"] = Convert.ToString(true);
                if (certificates != null)
                    callPayload.Queries["certificates"] = SourceExpressionConverter.ConvertO(certificates);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }
    }

    public class RiskiqintelligenceTriggers([ConnectionName] string connectionId)
    {
    }

    public class RRSets
    {
        [JsonProperty("recordCount")]
        public int RecordCount { get; set; }

        [JsonProperty("records")]
        public RRSet[] Records { get; set; }
    }

    public class RRSet
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("firstSeen")]
        public string FirstSeen { get; set; }

        [JsonProperty("lastSeen")]
        public string LastSeen { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("data")]
        public string[] Data { get; set; }

        [JsonProperty("rrtype")]
        public string Rrtype { get; set; }
    }

    public class SslCertWithHostPage
    {
        [JsonProperty("content")]
        public SslCertWithHostPageContentTypeItem[] Content { get; set; }
    }

    public class SslCertWithHostPageContentTypeItem
    {
        [JsonProperty("firstSeen")]
        public int FirstSeen { get; set; }

        [JsonProperty("lastSeen")]
        public int LastSeen { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("asn")]
        public string Asn { get; set; }

        [JsonProperty("bgpPrefix")]
        public string BgpPrefix { get; set; }

        [JsonProperty("port")]
        public int Port { get; set; }

        [JsonProperty("sha1")]
        public string Sha1 { get; set; }

        [JsonProperty("cert")]
        public SslCert Cert { get; set; }
    }

    public class SslCert
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("firstSeen")]
        public int FirstSeen { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("issuer")]
        public CertTypedName[] Issuer { get; set; }

        [JsonProperty("issuerAlternativeNames")]
        public CertTypedName[] IssuerAlternativeNames { get; set; }

        [JsonProperty("issuerID")]
        public string IssuerID { get; set; }

        [JsonProperty("lastSeen")]
        public int LastSeen { get; set; }

        [JsonProperty("notAfter")]
        public int NotAfter { get; set; }

        [JsonProperty("notBefore")]
        public int NotBefore { get; set; }

        [JsonProperty("publicKeyAlgorithm")]
        public string PublicKeyAlgorithm { get; set; }

        [JsonProperty("serialNumber")]
        public string SerialNumber { get; set; }

        [JsonProperty("sha1")]
        public string Sha1 { get; set; }

        [JsonProperty("signatureAlgorithm")]
        public string SignatureAlgorithm { get; set; }

        [JsonProperty("signatureAlgorithmOid")]
        public string SignatureAlgorithmOid { get; set; }

        [JsonProperty("subject")]
        public CertTypedName[] Subject { get; set; }

        [JsonProperty("subjectAlternativeNames")]
        public CertTypedName[] SubjectAlternativeNames { get; set; }

        [JsonProperty("subjectID")]
        public string SubjectID { get; set; }

        [JsonProperty("version")]
        public int Version { get; set; }
    }

    public class CertTypedName
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class SslCertPage
    {
        [JsonProperty("content")]
        public SslCert[] Content { get; set; }

        [JsonProperty("first")]
        public bool First { get; set; }

        [JsonProperty("last")]
        public bool Last { get; set; }

        [JsonProperty("number")]
        public int Number { get; set; }

        [JsonProperty("numberOfElements")]
        public int NumberOfElements { get; set; }

        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("sort")]
        public SslCertPageSortType Sort { get; set; }

        [JsonProperty("totalElements")]
        public int TotalElements { get; set; }

        [JsonProperty("totalPages")]
        public int TotalPages { get; set; }
    }

    public class SslCertPageSortType
    {
        [JsonProperty("sorted")]
        public bool Sorted { get; set; }

        [JsonProperty("unsorted")]
        public bool Unsorted { get; set; }

        [JsonProperty("empty")]
        public bool Empty { get; set; }
    }

    public class SslCertHostPage
    {
        [JsonProperty("content")]
        public SslCertHost[] Content { get; set; }

        [JsonProperty("first")]
        public bool First { get; set; }

        [JsonProperty("last")]
        public bool Last { get; set; }

        [JsonProperty("number")]
        public int Number { get; set; }

        [JsonProperty("numberOfElements")]
        public int NumberOfElements { get; set; }

        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("sort")]
        public SslCertHostPageSortType Sort { get; set; }

        [JsonProperty("totalElements")]
        public int TotalElements { get; set; }

        [JsonProperty("totalPages")]
        public int TotalPages { get; set; }
    }

    public class SslCertHost
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("firstSeen")]
        public int FirstSeen { get; set; }

        [JsonProperty("host")]
        public string Host { get; set; }

        [JsonProperty("lastSeen")]
        public int LastSeen { get; set; }

        [JsonProperty("port")]
        public int Port { get; set; }
    }

    public class SslCertHostPageSortType
    {
        [JsonProperty("sorted")]
        public bool Sorted { get; set; }

        [JsonProperty("unsorted")]
        public bool Unsorted { get; set; }

        [JsonProperty("empty")]
        public bool Empty { get; set; }
    }

    public class WhoisResult
    {
        [JsonProperty("results")]
        public int Results { get; set; }

        [JsonProperty("domains")]
        public WhoisDomain[] Domains { get; set; }
    }

    public class WhoisDomain
    {
        [JsonProperty("domain")]
        public string Domain { get; set; }

        [JsonProperty("registrar")]
        public string Registrar { get; set; }

        [JsonProperty("whoisServer")]
        public string WhoisServer { get; set; }

        [JsonProperty("registered")]
        public string Registered { get; set; }

        [JsonProperty("registryUpdatedAt")]
        public string RegistryUpdatedAt { get; set; }

        [JsonProperty("expiresAt")]
        public string ExpiresAt { get; set; }

        [JsonProperty("contactEmail")]
        public string ContactEmail { get; set; }

        [JsonProperty("nameServers")]
        public string[] NameServers { get; set; }

        [JsonProperty("registrant")]
        public WhoisContact Registrant { get; set; }

        [JsonProperty("admin")]
        public WhoisContact Admin { get; set; }

        [JsonProperty("billing")]
        public WhoisContact Billing { get; set; }

        [JsonProperty("tech")]
        public WhoisContact Tech { get; set; }

        [JsonProperty("zone")]
        public JToken Zone { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("lastLoadedAt")]
        public string LastLoadedAt { get; set; }
    }

    public class WhoisContact
    {
        [JsonProperty("domain")]
        public string Domain { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("organization")]
        public string Organization { get; set; }

        [JsonProperty("street")]
        public string Street { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("postalCode")]
        public string PostalCode { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("telephone")]
        public string Telephone { get; set; }
    }

    public class HostAttributeResult
    {
        [JsonProperty("content")]
        public HostAttributeContentResult[] Content { get; set; }

        [JsonProperty("facetResultPages")]
        public string[] FacetResultPages { get; set; }

        [JsonProperty("facetQueryResult")]
        public HostAttributeFacetQueryResult FacetQueryResult { get; set; }

        [JsonProperty("highlighted")]
        public string[] Highlighted { get; set; }

        [JsonProperty("maxScore")]
        public double MaxScore { get; set; }

        [JsonProperty("facetFields")]
        public string[] FacetFields { get; set; }

        [JsonProperty("facetPivotFields")]
        public string[] FacetPivotFields { get; set; }

        [JsonProperty("totalElements")]
        public int TotalElements { get; set; }

        [JsonProperty("totalPages")]
        public int TotalPages { get; set; }

        [JsonProperty("last")]
        public bool Last { get; set; }

        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("number")]
        public int Number { get; set; }

        [JsonProperty("sort")]
        public HostAttributeResultSortType Sort { get; set; }

        [JsonProperty("numberOfElements")]
        public int NumberOfElements { get; set; }

        [JsonProperty("first")]
        public bool First { get; set; }
    }

    public class HostAttributeContentResult
    {
        [JsonProperty("firstSeen")]
        public int FirstSeen { get; set; }

        [JsonProperty("lastSeen")]
        public int LastSeen { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("hostname")]
        public string Hostname { get; set; }

        [JsonProperty("domain")]
        public string Domain { get; set; }

        [JsonProperty("attributeValue")]
        public string AttributeValue { get; set; }

        [JsonProperty("attributeType")]
        public string AttributeType { get; set; }
    }

    public class HostAttributeFacetQueryResult
    {
        [JsonProperty("content")]
        public string[] Content { get; set; }

        [JsonProperty("last")]
        public bool Last { get; set; }

        [JsonProperty("totalElements")]
        public int TotalElements { get; set; }

        [JsonProperty("totalPages")]
        public int TotalPages { get; set; }

        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("sort")]
        public HostAttributeFacetQueryResultSortType Sort { get; set; }

        [JsonProperty("numberOfElements")]
        public int NumberOfElements { get; set; }

        [JsonProperty("first")]
        public bool First { get; set; }
    }

    public class HostAttributeFacetQueryResultSortType
    {
        [JsonProperty("sorted")]
        public bool Sorted { get; set; }

        [JsonProperty("unsorted")]
        public bool Unsorted { get; set; }

        [JsonProperty("empty")]
        public bool Empty { get; set; }
    }

    public class HostAttributeResultSortType
    {
        [JsonProperty("sorted")]
        public bool Sorted { get; set; }

        [JsonProperty("unsorted")]
        public bool Unsorted { get; set; }

        [JsonProperty("empty")]
        public bool Empty { get; set; }
    }

    public class HostPairsResult
    {
        [JsonProperty("content")]
        public HostPairsContentResult[] Content { get; set; }

        [JsonProperty("facetResultPages")]
        public string[] FacetResultPages { get; set; }

        [JsonProperty("facetQueryResult")]
        public HostAttributeFacetQueryResult FacetQueryResult { get; set; }

        [JsonProperty("highlighted")]
        public string[] Highlighted { get; set; }

        [JsonProperty("maxScore")]
        public double MaxScore { get; set; }

        [JsonProperty("facetFields")]
        public string[] FacetFields { get; set; }

        [JsonProperty("facetPivotFields")]
        public string[] FacetPivotFields { get; set; }

        [JsonProperty("totalElements")]
        public int TotalElements { get; set; }

        [JsonProperty("totalPages")]
        public int TotalPages { get; set; }

        [JsonProperty("last")]
        public bool Last { get; set; }

        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("number")]
        public int Number { get; set; }

        [JsonProperty("sort")]
        public HostPairsResultSortType Sort { get; set; }

        [JsonProperty("numberOfElements")]
        public int NumberOfElements { get; set; }

        [JsonProperty("first")]
        public bool First { get; set; }
    }

    public class HostPairsContentResult
    {
        [JsonProperty("firstSeen")]
        public int FirstSeen { get; set; }

        [JsonProperty("lastSeen")]
        public int LastSeen { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("cause")]
        public string Cause { get; set; }

        [JsonProperty("childCount")]
        public int ChildCount { get; set; }

        [JsonProperty("childHostname")]
        public string ChildHostname { get; set; }

        [JsonProperty("childScore")]
        public double ChildScore { get; set; }

        [JsonProperty("pairScore")]
        public double PairScore { get; set; }

        [JsonProperty("parentCount")]
        public int ParentCount { get; set; }

        [JsonProperty("parentHostname")]
        public string ParentHostname { get; set; }

        [JsonProperty("parentScore")]
        public double ParentScore { get; set; }
    }

    public class HostPairsResultSortType
    {
        [JsonProperty("sorted")]
        public bool Sorted { get; set; }

        [JsonProperty("unsorted")]
        public bool Unsorted { get; set; }

        [JsonProperty("empty")]
        public bool Empty { get; set; }
    }

    public class HostComponentsResult
    {
        [JsonProperty("content")]
        public HostComponentContentResult[] Content { get; set; }

        [JsonProperty("facetResultPages")]
        public string[] FacetResultPages { get; set; }

        [JsonProperty("facetQueryResult")]
        public HostAttributeFacetQueryResult FacetQueryResult { get; set; }

        [JsonProperty("highlighted")]
        public string[] Highlighted { get; set; }

        [JsonProperty("maxScore")]
        public double MaxScore { get; set; }

        [JsonProperty("facetFields")]
        public string[] FacetFields { get; set; }

        [JsonProperty("facetPivotFields")]
        public string[] FacetPivotFields { get; set; }

        [JsonProperty("totalElements")]
        public int TotalElements { get; set; }

        [JsonProperty("totalPages")]
        public int TotalPages { get; set; }

        [JsonProperty("last")]
        public bool Last { get; set; }

        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("number")]
        public int Number { get; set; }

        [JsonProperty("sort")]
        public HostComponentsResultSortType Sort { get; set; }

        [JsonProperty("numberOfElements")]
        public int NumberOfElements { get; set; }

        [JsonProperty("first")]
        public bool First { get; set; }
    }

    public class HostComponentContentResult
    {
        [JsonProperty("firstSeen")]
        public int FirstSeen { get; set; }

        [JsonProperty("lastSeen")]
        public int LastSeen { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("hostname")]
        public string Hostname { get; set; }

        [JsonProperty("domain")]
        public string Domain { get; set; }

        [JsonProperty("webComponentVersion")]
        public string WebComponentVersion { get; set; }

        [JsonProperty("webComponentName")]
        public string WebComponentName { get; set; }

        [JsonProperty("webComponentCategory")]
        public string WebComponentCategory { get; set; }
    }

    public class HostComponentsResultSortType
    {
        [JsonProperty("sorted")]
        public bool Sorted { get; set; }

        [JsonProperty("unsorted")]
        public bool Unsorted { get; set; }

        [JsonProperty("empty")]
        public bool Empty { get; set; }
    }

    public class HostCookieResult
    {
        [JsonProperty("content")]
        public HostCacheContentResult[] Content { get; set; }

        [JsonProperty("facetResultPages")]
        public string[] FacetResultPages { get; set; }

        [JsonProperty("facetQueryResult")]
        public HostAttributeFacetQueryResult FacetQueryResult { get; set; }

        [JsonProperty("highlighted")]
        public string[] Highlighted { get; set; }

        [JsonProperty("maxScore")]
        public double MaxScore { get; set; }

        [JsonProperty("facetFields")]
        public string[] FacetFields { get; set; }

        [JsonProperty("facetPivotFields")]
        public string[] FacetPivotFields { get; set; }

        [JsonProperty("totalElements")]
        public int TotalElements { get; set; }

        [JsonProperty("totalPages")]
        public int TotalPages { get; set; }

        [JsonProperty("last")]
        public bool Last { get; set; }

        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("number")]
        public int Number { get; set; }

        [JsonProperty("sort")]
        public HostCookieResultSortType Sort { get; set; }

        [JsonProperty("numberOfElements")]
        public int NumberOfElements { get; set; }

        [JsonProperty("first")]
        public bool First { get; set; }
    }

    public class HostCacheContentResult
    {
        [JsonProperty("firstSeen")]
        public int FirstSeen { get; set; }

        [JsonProperty("lastSeen")]
        public int LastSeen { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("hostname")]
        public string Hostname { get; set; }

        [JsonProperty("domain")]
        public string Domain { get; set; }

        [JsonProperty("cookieDomain")]
        public string CookieDomain { get; set; }

        [JsonProperty("cookieName")]
        public string CookieName { get; set; }
    }

    public class HostCookieResultSortType
    {
        [JsonProperty("sorted")]
        public bool Sorted { get; set; }

        [JsonProperty("unsorted")]
        public bool Unsorted { get; set; }

        [JsonProperty("empty")]
        public bool Empty { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Riskiqintelligence;

    public partial class WorkflowManagedActions
    {
        public RiskiqintelligenceActions Riskiqintelligence(string connectionId) => new RiskiqintelligenceActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public RiskiqintelligenceTriggers Riskiqintelligence(string connectionId) => new RiskiqintelligenceTriggers(connectionId);
    }
}