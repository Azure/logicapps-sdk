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
        public IBodyWorkflowAction<RRSets> PDNSIP(Expression<Func<string>> ip, Expression<Func<string>> max = null, Expression<Func<string>> lastSeenAfter = null, Expression<Func<string>> firstSeenBefore = null)
        {
            var apiCallPath = "/v0/pdns/data/ip";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["ip"] = ExpressionConverter.Convert(ip);
            if (max != null)
                callPayload.Queries["max"] = ExpressionConverter.Convert(max);
            if (lastSeenAfter != null)
                callPayload.Queries["lastSeenAfter"] = ExpressionConverter.Convert(lastSeenAfter);
            if (firstSeenBefore != null)
                callPayload.Queries["firstSeenBefore"] = ExpressionConverter.Convert(firstSeenBefore);
            return new ApiConnectionAction<RRSets>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqintelligence")]
        public IBodyWorkflowAction<RRSets> PDNSRESOURCEDATA(Expression<Func<string>> name, Expression<Func<string>> type = null, Expression<Func<string>> max = null, Expression<Func<string>> lastSeenAfter = null, Expression<Func<string>> firstSeenBefore = null)
        {
            var apiCallPath = "/v0/pdns/data/name";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["name"] = ExpressionConverter.Convert(name);
            if (type != null)
                callPayload.Queries["type"] = ExpressionConverter.Convert(type);
            if (max != null)
                callPayload.Queries["max"] = ExpressionConverter.Convert(max);
            if (lastSeenAfter != null)
                callPayload.Queries["lastSeenAfter"] = ExpressionConverter.Convert(lastSeenAfter);
            if (firstSeenBefore != null)
                callPayload.Queries["firstSeenBefore"] = ExpressionConverter.Convert(firstSeenBefore);
            return new ApiConnectionAction<RRSets>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqintelligence")]
        public IBodyWorkflowAction<RRSets> PDNSRESOURCEDATAHEX(Expression<Func<string>> hex, Expression<Func<string>> type = null, Expression<Func<string>> max = null, Expression<Func<string>> lastSeenAfter = null, Expression<Func<string>> firstSeenBefore = null)
        {
            var apiCallPath = "/v0/pdns/data/raw";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (type != null)
                callPayload.Queries["type"] = ExpressionConverter.Convert(type);
            if (max != null)
                callPayload.Queries["max"] = ExpressionConverter.Convert(max);
            if (lastSeenAfter != null)
                callPayload.Queries["lastSeenAfter"] = ExpressionConverter.Convert(lastSeenAfter);
            if (firstSeenBefore != null)
                callPayload.Queries["firstSeenBefore"] = ExpressionConverter.Convert(firstSeenBefore);
            callPayload.Queries["hex"] = ExpressionConverter.Convert(hex);
            return new ApiConnectionAction<RRSets>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqintelligence")]
        public IBodyWorkflowAction<RRSets> PDNSNAME(Expression<Func<string>> name, Expression<Func<string>> type = null, Expression<Func<string>> max = null, Expression<Func<string>> lastSeenAfter = null, Expression<Func<string>> firstSeenBefore = null)
        {
            var apiCallPath = "/v0/pdns/name";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["name"] = ExpressionConverter.Convert(name);
            if (type != null)
                callPayload.Queries["type"] = ExpressionConverter.Convert(type);
            if (max != null)
                callPayload.Queries["max"] = ExpressionConverter.Convert(max);
            if (lastSeenAfter != null)
                callPayload.Queries["lastSeenAfter"] = ExpressionConverter.Convert(lastSeenAfter);
            if (firstSeenBefore != null)
                callPayload.Queries["firstSeenBefore"] = ExpressionConverter.Convert(firstSeenBefore);
            return new ApiConnectionAction<RRSets>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqintelligence")]
        public IBodyWorkflowAction<SslCertWithHostPage> SSLBYHOST(Expression<Func<string>> host)
        {
            var apiCallPath = "/v1/ssl/cert/host";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["host"] = ExpressionConverter.Convert(host);
            return new ApiConnectionAction<SslCertWithHostPage>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqintelligence")]
        public IBodyWorkflowAction<SslCertPage> SSLBYSERIAL(Expression<Func<string>> serial)
        {
            var apiCallPath = "/v1/ssl/cert/serial";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["serial"] = ExpressionConverter.Convert(serial);
            return new ApiConnectionAction<SslCertPage>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqintelligence")]
        public IBodyWorkflowAction<SslCert> SSLBYSHA1(Expression<Func<string>> sha1)
        {
            var apiCallPath = "/v1/ssl/cert/sha1";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["sha1"] = ExpressionConverter.Convert(sha1);
            return new ApiConnectionAction<SslCert>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqintelligence")]
        public IBodyWorkflowAction<SslCertHostPage> HOSTSBYSSLSHA1(Expression<Func<string>> certSha1)
        {
            var apiCallPath = "/v1/ssl/host";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["certSha1"] = ExpressionConverter.Convert(certSha1);
            return new ApiConnectionAction<SslCertHostPage>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqintelligence")]
        public IBodyWorkflowAction<SslCertPage> SSLBYNAME(Expression<Func<string>> name)
        {
            var apiCallPath = "/v1/ssl/cert/name";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["name"] = ExpressionConverter.Convert(name);
            return new ApiConnectionAction<SslCertPage>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqintelligence")]
        public IBodyWorkflowAction<WhoisResult> WHOISIP(Expression<Func<string>> address, Expression<Func<string>> exact = null, Expression<Func<string>> maxResults = null)
        {
            var apiCallPath = "/v0/whois/address";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["address"] = ExpressionConverter.Convert(address);
            if (exact != null)
                callPayload.Queries["exact"] = ExpressionConverter.Convert(exact);
            if (maxResults != null)
                callPayload.Queries["maxResults"] = ExpressionConverter.Convert(maxResults);
            return new ApiConnectionAction<WhoisResult>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqintelligence")]
        public IBodyWorkflowAction<WhoisResult> WHOISDOMAIN(Expression<Func<string>> domain, Expression<Func<string>> exact = null, Expression<Func<string>> maxResults = null)
        {
            var apiCallPath = "/v0/whois/domain";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["domain"] = ExpressionConverter.Convert(domain);
            if (exact != null)
                callPayload.Queries["exact"] = ExpressionConverter.Convert(exact);
            if (maxResults != null)
                callPayload.Queries["maxResults"] = ExpressionConverter.Convert(maxResults);
            return new ApiConnectionAction<WhoisResult>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqintelligence")]
        public IBodyWorkflowAction<WhoisResult> WHOISBYEMAIL(Expression<Func<string>> email, Expression<Func<string>> exact = null, Expression<Func<string>> maxResults = null)
        {
            var apiCallPath = "/v0/whois/email";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["email"] = ExpressionConverter.Convert(email);
            if (exact != null)
                callPayload.Queries["exact"] = ExpressionConverter.Convert(exact);
            if (maxResults != null)
                callPayload.Queries["maxResults"] = ExpressionConverter.Convert(maxResults);
            return new ApiConnectionAction<WhoisResult>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqintelligence")]
        public IBodyWorkflowAction<WhoisResult> WHOISBYNAME(Expression<Func<string>> name, Expression<Func<string>> exact = null, Expression<Func<string>> maxResults = null)
        {
            var apiCallPath = "/v0/whois/name";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["name"] = ExpressionConverter.Convert(name);
            if (exact != null)
                callPayload.Queries["exact"] = ExpressionConverter.Convert(exact);
            if (maxResults != null)
                callPayload.Queries["maxResults"] = ExpressionConverter.Convert(maxResults);
            return new ApiConnectionAction<WhoisResult>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqintelligence")]
        public IBodyWorkflowAction<WhoisResult> WHOISBYNAMESERVER(Expression<Func<string>> nameserver, Expression<Func<string>> exact = null, Expression<Func<string>> maxResults = null)
        {
            var apiCallPath = "/v0/whois/nameserver";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["nameserver"] = ExpressionConverter.Convert(nameserver);
            if (exact != null)
                callPayload.Queries["exact"] = ExpressionConverter.Convert(exact);
            if (maxResults != null)
                callPayload.Queries["maxResults"] = ExpressionConverter.Convert(maxResults);
            return new ApiConnectionAction<WhoisResult>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqintelligence")]
        public IBodyWorkflowAction<WhoisResult> WHOISBYORGANIZATION(Expression<Func<string>> org, Expression<Func<string>> exact = null, Expression<Func<string>> maxResults = null)
        {
            var apiCallPath = "/v0/whois/org";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["org"] = ExpressionConverter.Convert(org);
            if (exact != null)
                callPayload.Queries["exact"] = ExpressionConverter.Convert(exact);
            if (maxResults != null)
                callPayload.Queries["maxResults"] = ExpressionConverter.Convert(maxResults);
            return new ApiConnectionAction<WhoisResult>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqintelligence")]
        public IBodyWorkflowAction<WhoisResult> WHOISBYPHONE(Expression<Func<string>> phone, Expression<Func<string>> exact = null, Expression<Func<string>> maxResults = null)
        {
            var apiCallPath = "/v0/whois/phone";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["phone"] = ExpressionConverter.Convert(phone);
            if (exact != null)
                callPayload.Queries["exact"] = ExpressionConverter.Convert(exact);
            if (maxResults != null)
                callPayload.Queries["maxResults"] = ExpressionConverter.Convert(maxResults);
            return new ApiConnectionAction<WhoisResult>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqintelligence")]
        public IBodyWorkflowAction<HostAttributeResult> TRACKERSHOST(Expression<Func<string>> host, Expression<Func<int>> size = null, Expression<Func<int>> page = null, Expression<Func<int>> before = null, Expression<Func<int>> after = null, Expression<Func<int>> beforeDay = null, Expression<Func<int>> afterDay = null, Expression<Func<string>> exact = null)
        {
            var apiCallPath = String.Format("/v0/hostattributes/hosts/trackers/{0}", ExpressionConverter.ConvertWithUrlEncoding(host, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (size != null)
                callPayload.Queries["size"] = ExpressionConverter.Convert(size);
            if (page != null)
                callPayload.Queries["page"] = ExpressionConverter.Convert(page);
            if (before != null)
                callPayload.Queries["before"] = ExpressionConverter.Convert(before);
            if (after != null)
                callPayload.Queries["after"] = ExpressionConverter.Convert(after);
            if (beforeDay != null)
                callPayload.Queries["beforeDay"] = ExpressionConverter.Convert(beforeDay);
            if (afterDay != null)
                callPayload.Queries["afterDay"] = ExpressionConverter.Convert(afterDay);
            if (exact != null)
                callPayload.Queries["exact"] = ExpressionConverter.Convert(exact);
            return new ApiConnectionAction<HostAttributeResult>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqintelligence")]
        public IBodyWorkflowAction<HostAttributeResult> TRACKERSDOMAIN(Expression<Func<string>> domain, Expression<Func<int>> size = null, Expression<Func<int>> page = null, Expression<Func<int>> before = null, Expression<Func<int>> after = null, Expression<Func<int>> beforeDay = null, Expression<Func<int>> afterDay = null, Expression<Func<string>> exact = null)
        {
            var apiCallPath = String.Format("/v0/hostattributes/domains/trackers/{0}", ExpressionConverter.ConvertWithUrlEncoding(domain, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (size != null)
                callPayload.Queries["size"] = ExpressionConverter.Convert(size);
            if (page != null)
                callPayload.Queries["page"] = ExpressionConverter.Convert(page);
            if (before != null)
                callPayload.Queries["before"] = ExpressionConverter.Convert(before);
            if (after != null)
                callPayload.Queries["after"] = ExpressionConverter.Convert(after);
            if (beforeDay != null)
                callPayload.Queries["beforeDay"] = ExpressionConverter.Convert(beforeDay);
            if (afterDay != null)
                callPayload.Queries["afterDay"] = ExpressionConverter.Convert(afterDay);
            if (exact != null)
                callPayload.Queries["exact"] = ExpressionConverter.Convert(exact);
            return new ApiConnectionAction<HostAttributeResult>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqintelligence")]
        public IBodyWorkflowAction<HostAttributeResult> TRACKERSIP(Expression<Func<string>> address, Expression<Func<int>> size = null, Expression<Func<int>> page = null, Expression<Func<int>> before = null, Expression<Func<int>> after = null, Expression<Func<int>> beforeDay = null, Expression<Func<int>> afterDay = null, Expression<Func<string>> exact = null)
        {
            var apiCallPath = String.Format("/v0/hostattributes/addresses/trackers/{0}", ExpressionConverter.ConvertWithUrlEncoding(address, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (size != null)
                callPayload.Queries["size"] = ExpressionConverter.Convert(size);
            if (page != null)
                callPayload.Queries["page"] = ExpressionConverter.Convert(page);
            if (before != null)
                callPayload.Queries["before"] = ExpressionConverter.Convert(before);
            if (after != null)
                callPayload.Queries["after"] = ExpressionConverter.Convert(after);
            if (beforeDay != null)
                callPayload.Queries["beforeDay"] = ExpressionConverter.Convert(beforeDay);
            if (afterDay != null)
                callPayload.Queries["afterDay"] = ExpressionConverter.Convert(afterDay);
            if (exact != null)
                callPayload.Queries["exact"] = ExpressionConverter.Convert(exact);
            return new ApiConnectionAction<HostAttributeResult>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqintelligence")]
        public IBodyWorkflowAction<HostPairsResult> HOSTPAIRSCHILD(Expression<Func<string>> host, Expression<Func<int>> size = null, Expression<Func<int>> page = null, Expression<Func<int>> before = null, Expression<Func<int>> after = null, Expression<Func<int>> beforeDay = null, Expression<Func<int>> afterDay = null, Expression<Func<string>> exact = null)
        {
            var apiCallPath = String.Format("/v0/hostattributes/hosts/trackers/children/{0}", ExpressionConverter.ConvertWithUrlEncoding(host, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (size != null)
                callPayload.Queries["size"] = ExpressionConverter.Convert(size);
            if (page != null)
                callPayload.Queries["page"] = ExpressionConverter.Convert(page);
            if (before != null)
                callPayload.Queries["before"] = ExpressionConverter.Convert(before);
            if (after != null)
                callPayload.Queries["after"] = ExpressionConverter.Convert(after);
            if (beforeDay != null)
                callPayload.Queries["beforeDay"] = ExpressionConverter.Convert(beforeDay);
            if (afterDay != null)
                callPayload.Queries["afterDay"] = ExpressionConverter.Convert(afterDay);
            if (exact != null)
                callPayload.Queries["exact"] = ExpressionConverter.Convert(exact);
            return new ApiConnectionAction<HostPairsResult>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqintelligence")]
        public IBodyWorkflowAction<HostPairsResult> HOSTPAIRSPARENT(Expression<Func<string>> host, Expression<Func<int>> size = null, Expression<Func<int>> page = null, Expression<Func<int>> before = null, Expression<Func<int>> after = null, Expression<Func<int>> beforeDay = null, Expression<Func<int>> afterDay = null, Expression<Func<string>> exact = null)
        {
            var apiCallPath = String.Format("/v0/hostattributes/hosts/trackers/parents/{0}", ExpressionConverter.ConvertWithUrlEncoding(host, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (size != null)
                callPayload.Queries["size"] = ExpressionConverter.Convert(size);
            if (page != null)
                callPayload.Queries["page"] = ExpressionConverter.Convert(page);
            if (before != null)
                callPayload.Queries["before"] = ExpressionConverter.Convert(before);
            if (after != null)
                callPayload.Queries["after"] = ExpressionConverter.Convert(after);
            if (beforeDay != null)
                callPayload.Queries["beforeDay"] = ExpressionConverter.Convert(beforeDay);
            if (afterDay != null)
                callPayload.Queries["afterDay"] = ExpressionConverter.Convert(afterDay);
            if (exact != null)
                callPayload.Queries["exact"] = ExpressionConverter.Convert(exact);
            return new ApiConnectionAction<HostPairsResult>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqintelligence")]
        public IBodyWorkflowAction<HostComponentsResult> WEBCOMPONENTHOST(Expression<Func<string>> host, Expression<Func<int>> size = null, Expression<Func<int>> page = null, Expression<Func<int>> before = null, Expression<Func<int>> after = null, Expression<Func<int>> beforeDay = null, Expression<Func<int>> afterDay = null, Expression<Func<string>> exact = null)
        {
            var apiCallPath = String.Format("/v0/hostattributes/hosts/components/{0}", ExpressionConverter.ConvertWithUrlEncoding(host, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (size != null)
                callPayload.Queries["size"] = ExpressionConverter.Convert(size);
            if (page != null)
                callPayload.Queries["page"] = ExpressionConverter.Convert(page);
            if (before != null)
                callPayload.Queries["before"] = ExpressionConverter.Convert(before);
            if (after != null)
                callPayload.Queries["after"] = ExpressionConverter.Convert(after);
            if (beforeDay != null)
                callPayload.Queries["beforeDay"] = ExpressionConverter.Convert(beforeDay);
            if (afterDay != null)
                callPayload.Queries["afterDay"] = ExpressionConverter.Convert(afterDay);
            if (exact != null)
                callPayload.Queries["exact"] = ExpressionConverter.Convert(exact);
            return new ApiConnectionAction<HostComponentsResult>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqintelligence")]
        public IBodyWorkflowAction<HostComponentsResult> WEBCOMPONENTSDOMAIN(Expression<Func<string>> domain, Expression<Func<int>> size = null, Expression<Func<int>> page = null, Expression<Func<int>> before = null, Expression<Func<int>> after = null, Expression<Func<int>> beforeDay = null, Expression<Func<int>> afterDay = null, Expression<Func<string>> exact = null)
        {
            var apiCallPath = String.Format("/v0/hostattributes/domains/components/{0}", ExpressionConverter.ConvertWithUrlEncoding(domain, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (size != null)
                callPayload.Queries["size"] = ExpressionConverter.Convert(size);
            if (page != null)
                callPayload.Queries["page"] = ExpressionConverter.Convert(page);
            if (before != null)
                callPayload.Queries["before"] = ExpressionConverter.Convert(before);
            if (after != null)
                callPayload.Queries["after"] = ExpressionConverter.Convert(after);
            if (beforeDay != null)
                callPayload.Queries["beforeDay"] = ExpressionConverter.Convert(beforeDay);
            if (afterDay != null)
                callPayload.Queries["afterDay"] = ExpressionConverter.Convert(afterDay);
            if (exact != null)
                callPayload.Queries["exact"] = ExpressionConverter.Convert(exact);
            return new ApiConnectionAction<HostComponentsResult>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqintelligence")]
        public IBodyWorkflowAction<HostComponentsResult> WEBCOMPONENTSIP(Expression<Func<string>> address, Expression<Func<int>> size = null, Expression<Func<int>> page = null, Expression<Func<int>> before = null, Expression<Func<int>> after = null, Expression<Func<int>> beforeDay = null, Expression<Func<int>> afterDay = null, Expression<Func<string>> exact = null)
        {
            var apiCallPath = String.Format("/v0/hostattributes/addresses/components/{0}", ExpressionConverter.ConvertWithUrlEncoding(address, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (size != null)
                callPayload.Queries["size"] = ExpressionConverter.Convert(size);
            if (page != null)
                callPayload.Queries["page"] = ExpressionConverter.Convert(page);
            if (before != null)
                callPayload.Queries["before"] = ExpressionConverter.Convert(before);
            if (after != null)
                callPayload.Queries["after"] = ExpressionConverter.Convert(after);
            if (beforeDay != null)
                callPayload.Queries["beforeDay"] = ExpressionConverter.Convert(beforeDay);
            if (afterDay != null)
                callPayload.Queries["afterDay"] = ExpressionConverter.Convert(afterDay);
            if (exact != null)
                callPayload.Queries["exact"] = ExpressionConverter.Convert(exact);
            return new ApiConnectionAction<HostComponentsResult>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqintelligence")]
        public IBodyWorkflowAction<HostCookieResult> COOKIESHOST(Expression<Func<string>> host, Expression<Func<int>> size = null, Expression<Func<int>> page = null, Expression<Func<int>> before = null, Expression<Func<int>> after = null, Expression<Func<int>> beforeDay = null, Expression<Func<int>> afterDay = null, Expression<Func<string>> exact = null)
        {
            var apiCallPath = String.Format("/v0/hostattributes/hosts/cookies/{0}", ExpressionConverter.ConvertWithUrlEncoding(host, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (size != null)
                callPayload.Queries["size"] = ExpressionConverter.Convert(size);
            if (page != null)
                callPayload.Queries["page"] = ExpressionConverter.Convert(page);
            if (before != null)
                callPayload.Queries["before"] = ExpressionConverter.Convert(before);
            if (after != null)
                callPayload.Queries["after"] = ExpressionConverter.Convert(after);
            if (beforeDay != null)
                callPayload.Queries["beforeDay"] = ExpressionConverter.Convert(beforeDay);
            if (afterDay != null)
                callPayload.Queries["afterDay"] = ExpressionConverter.Convert(afterDay);
            if (exact != null)
                callPayload.Queries["exact"] = ExpressionConverter.Convert(exact);
            return new ApiConnectionAction<HostCookieResult>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqintelligence")]
        public IBodyWorkflowAction<HostCookieResult> COOKIESIP(Expression<Func<string>> address, Expression<Func<int>> size = null, Expression<Func<int>> page = null, Expression<Func<int>> before = null, Expression<Func<int>> after = null, Expression<Func<int>> beforeDay = null, Expression<Func<int>> afterDay = null, Expression<Func<string>> exact = null)
        {
            var apiCallPath = String.Format("/v0/hostattributes/addresses/cookies/{0}", ExpressionConverter.ConvertWithUrlEncoding(address, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (size != null)
                callPayload.Queries["size"] = ExpressionConverter.Convert(size);
            if (page != null)
                callPayload.Queries["page"] = ExpressionConverter.Convert(page);
            if (before != null)
                callPayload.Queries["before"] = ExpressionConverter.Convert(before);
            if (after != null)
                callPayload.Queries["after"] = ExpressionConverter.Convert(after);
            if (beforeDay != null)
                callPayload.Queries["beforeDay"] = ExpressionConverter.Convert(beforeDay);
            if (afterDay != null)
                callPayload.Queries["afterDay"] = ExpressionConverter.Convert(afterDay);
            if (exact != null)
                callPayload.Queries["exact"] = ExpressionConverter.Convert(exact);
            return new ApiConnectionAction<HostCookieResult>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqintelligence")]
        public IBodyWorkflowAction<JToken> ENRICHMENTHOST(Expression<Func<string>> host, Expression<Func<bool>> whois = null, Expression<Func<bool>> hostDetails = null, Expression<Func<bool>> ipDetails = null, Expression<Func<bool>> linkedAssetCounts = null, Expression<Func<bool>> recentPDNS = null, Expression<Func<bool>> subDomainPDNS = null, Expression<Func<bool>> openPorts = null, Expression<Func<bool>> certificates = null)
        {
            var apiCallPath = String.Format("/v0/enrich/host/{0}", ExpressionConverter.ConvertWithUrlEncoding(host, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["whois"] = Convert.ToString(true);
            if (whois != null)
                callPayload.Queries["whois"] = ExpressionConverter.Convert(whois);
            callPayload.Queries["hostDetails"] = Convert.ToString(true);
            if (hostDetails != null)
                callPayload.Queries["hostDetails"] = ExpressionConverter.Convert(hostDetails);
            callPayload.Queries["ipDetails"] = Convert.ToString(true);
            if (ipDetails != null)
                callPayload.Queries["ipDetails"] = ExpressionConverter.Convert(ipDetails);
            callPayload.Queries["linkedAssetCounts"] = Convert.ToString(true);
            if (linkedAssetCounts != null)
                callPayload.Queries["linkedAssetCounts"] = ExpressionConverter.Convert(linkedAssetCounts);
            callPayload.Queries["recentPDNS"] = Convert.ToString(true);
            if (recentPDNS != null)
                callPayload.Queries["recentPDNS"] = ExpressionConverter.Convert(recentPDNS);
            callPayload.Queries["subDomainPDNS"] = Convert.ToString(true);
            if (subDomainPDNS != null)
                callPayload.Queries["subDomainPDNS"] = ExpressionConverter.Convert(subDomainPDNS);
            callPayload.Queries["openPorts"] = Convert.ToString(true);
            if (openPorts != null)
                callPayload.Queries["openPorts"] = ExpressionConverter.Convert(openPorts);
            callPayload.Queries["certificates"] = Convert.ToString(true);
            if (certificates != null)
                callPayload.Queries["certificates"] = ExpressionConverter.Convert(certificates);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqintelligence")]
        public IBodyWorkflowAction<JToken> ENRICHMENTIP(Expression<Func<string>> ip, Expression<Func<bool>> whois = null, Expression<Func<bool>> hostDetails = null, Expression<Func<bool>> linkedAssetCounts = null, Expression<Func<bool>> openPorts = null, Expression<Func<bool>> certificates = null)
        {
            var apiCallPath = String.Format("/v0/enrich/ip/{0}", ExpressionConverter.ConvertWithUrlEncoding(ip, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["whois"] = Convert.ToString(true);
            if (whois != null)
                callPayload.Queries["whois"] = ExpressionConverter.Convert(whois);
            callPayload.Queries["hostDetails"] = Convert.ToString(true);
            if (hostDetails != null)
                callPayload.Queries["hostDetails"] = ExpressionConverter.Convert(hostDetails);
            callPayload.Queries["linkedAssetCounts"] = Convert.ToString(true);
            if (linkedAssetCounts != null)
                callPayload.Queries["linkedAssetCounts"] = ExpressionConverter.Convert(linkedAssetCounts);
            callPayload.Queries["openPorts"] = Convert.ToString(true);
            if (openPorts != null)
                callPayload.Queries["openPorts"] = ExpressionConverter.Convert(openPorts);
            callPayload.Queries["certificates"] = Convert.ToString(true);
            if (certificates != null)
                callPayload.Queries["certificates"] = ExpressionConverter.Convert(certificates);
            return new ApiConnectionAction<JToken>(callPayload);
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