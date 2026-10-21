//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Riskiqintelligence
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class RiskiqintelligenceActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqintelligence")]
        public IBodyWorkflowAction<RRSets> PDNSIP(Expression<Func<string>> ip, Expression<Func<string>> max = null, Expression<Func<string>> lastSeenAfter = null, Expression<Func<string>> firstSeenBefore = null)
        {
            var __workflow_ip = WorkflowExpression.Compile(ip, nameof(ip), required: true);
            var __workflow_max = WorkflowExpression.Compile(max, nameof(max), required: false);
            var __workflow_lastSeenAfter = WorkflowExpression.Compile(lastSeenAfter, nameof(lastSeenAfter), required: false);
            var __workflow_firstSeenBefore = WorkflowExpression.Compile(firstSeenBefore, nameof(firstSeenBefore), required: false);
            return new DeferredBodyAction<RRSets>(() =>
            {
                var apiCallPath = "/v0/pdns/data/ip";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["ip"] = ExpressionConverter.Convert(__workflow_ip);
                if (__workflow_max != null)
                    callPayload.Queries["max"] = ExpressionConverter.Convert(__workflow_max);
                if (__workflow_lastSeenAfter != null)
                    callPayload.Queries["lastSeenAfter"] = ExpressionConverter.Convert(__workflow_lastSeenAfter);
                if (__workflow_firstSeenBefore != null)
                    callPayload.Queries["firstSeenBefore"] = ExpressionConverter.Convert(__workflow_firstSeenBefore);
                return new ApiConnectionAction<RRSets>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqintelligence")]
        public IBodyWorkflowAction<RRSets> PDNSRESOURCEDATA(Expression<Func<string>> name, Expression<Func<string>> type = null, Expression<Func<string>> max = null, Expression<Func<string>> lastSeenAfter = null, Expression<Func<string>> firstSeenBefore = null)
        {
            var __workflow_name = WorkflowExpression.Compile(name, nameof(name), required: true);
            var __workflow_type = WorkflowExpression.Compile(type, nameof(type), required: false);
            var __workflow_max = WorkflowExpression.Compile(max, nameof(max), required: false);
            var __workflow_lastSeenAfter = WorkflowExpression.Compile(lastSeenAfter, nameof(lastSeenAfter), required: false);
            var __workflow_firstSeenBefore = WorkflowExpression.Compile(firstSeenBefore, nameof(firstSeenBefore), required: false);
            return new DeferredBodyAction<RRSets>(() =>
            {
                var apiCallPath = "/v0/pdns/data/name";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["name"] = ExpressionConverter.Convert(__workflow_name);
                if (__workflow_type != null)
                    callPayload.Queries["type"] = ExpressionConverter.Convert(__workflow_type);
                if (__workflow_max != null)
                    callPayload.Queries["max"] = ExpressionConverter.Convert(__workflow_max);
                if (__workflow_lastSeenAfter != null)
                    callPayload.Queries["lastSeenAfter"] = ExpressionConverter.Convert(__workflow_lastSeenAfter);
                if (__workflow_firstSeenBefore != null)
                    callPayload.Queries["firstSeenBefore"] = ExpressionConverter.Convert(__workflow_firstSeenBefore);
                return new ApiConnectionAction<RRSets>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqintelligence")]
        public IBodyWorkflowAction<RRSets> PDNSRESOURCEDATAHEX(Expression<Func<string>> hex, Expression<Func<string>> type = null, Expression<Func<string>> max = null, Expression<Func<string>> lastSeenAfter = null, Expression<Func<string>> firstSeenBefore = null)
        {
            var __workflow_hex = WorkflowExpression.Compile(hex, nameof(hex), required: true);
            var __workflow_type = WorkflowExpression.Compile(type, nameof(type), required: false);
            var __workflow_max = WorkflowExpression.Compile(max, nameof(max), required: false);
            var __workflow_lastSeenAfter = WorkflowExpression.Compile(lastSeenAfter, nameof(lastSeenAfter), required: false);
            var __workflow_firstSeenBefore = WorkflowExpression.Compile(firstSeenBefore, nameof(firstSeenBefore), required: false);
            return new DeferredBodyAction<RRSets>(() =>
            {
                var apiCallPath = "/v0/pdns/data/raw";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_type != null)
                    callPayload.Queries["type"] = ExpressionConverter.Convert(__workflow_type);
                if (__workflow_max != null)
                    callPayload.Queries["max"] = ExpressionConverter.Convert(__workflow_max);
                if (__workflow_lastSeenAfter != null)
                    callPayload.Queries["lastSeenAfter"] = ExpressionConverter.Convert(__workflow_lastSeenAfter);
                if (__workflow_firstSeenBefore != null)
                    callPayload.Queries["firstSeenBefore"] = ExpressionConverter.Convert(__workflow_firstSeenBefore);
                callPayload.Queries["hex"] = ExpressionConverter.Convert(__workflow_hex);
                return new ApiConnectionAction<RRSets>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqintelligence")]
        public IBodyWorkflowAction<RRSets> PDNSNAME(Expression<Func<string>> name, Expression<Func<string>> type = null, Expression<Func<string>> max = null, Expression<Func<string>> lastSeenAfter = null, Expression<Func<string>> firstSeenBefore = null)
        {
            var __workflow_name = WorkflowExpression.Compile(name, nameof(name), required: true);
            var __workflow_type = WorkflowExpression.Compile(type, nameof(type), required: false);
            var __workflow_max = WorkflowExpression.Compile(max, nameof(max), required: false);
            var __workflow_lastSeenAfter = WorkflowExpression.Compile(lastSeenAfter, nameof(lastSeenAfter), required: false);
            var __workflow_firstSeenBefore = WorkflowExpression.Compile(firstSeenBefore, nameof(firstSeenBefore), required: false);
            return new DeferredBodyAction<RRSets>(() =>
            {
                var apiCallPath = "/v0/pdns/name";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["name"] = ExpressionConverter.Convert(__workflow_name);
                if (__workflow_type != null)
                    callPayload.Queries["type"] = ExpressionConverter.Convert(__workflow_type);
                if (__workflow_max != null)
                    callPayload.Queries["max"] = ExpressionConverter.Convert(__workflow_max);
                if (__workflow_lastSeenAfter != null)
                    callPayload.Queries["lastSeenAfter"] = ExpressionConverter.Convert(__workflow_lastSeenAfter);
                if (__workflow_firstSeenBefore != null)
                    callPayload.Queries["firstSeenBefore"] = ExpressionConverter.Convert(__workflow_firstSeenBefore);
                return new ApiConnectionAction<RRSets>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqintelligence")]
        public IBodyWorkflowAction<SslCertWithHostPage> SSLBYHOST(Expression<Func<string>> host)
        {
            var __workflow_host = WorkflowExpression.Compile(host, nameof(host), required: true);
            return new DeferredBodyAction<SslCertWithHostPage>(() =>
            {
                var apiCallPath = "/v1/ssl/cert/host";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["host"] = ExpressionConverter.Convert(__workflow_host);
                return new ApiConnectionAction<SslCertWithHostPage>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqintelligence")]
        public IBodyWorkflowAction<SslCertPage> SSLBYSERIAL(Expression<Func<string>> serial)
        {
            var __workflow_serial = WorkflowExpression.Compile(serial, nameof(serial), required: true);
            return new DeferredBodyAction<SslCertPage>(() =>
            {
                var apiCallPath = "/v1/ssl/cert/serial";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["serial"] = ExpressionConverter.Convert(__workflow_serial);
                return new ApiConnectionAction<SslCertPage>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqintelligence")]
        public IBodyWorkflowAction<SslCert> SSLBYSHA1(Expression<Func<string>> sha1)
        {
            var __workflow_sha1 = WorkflowExpression.Compile(sha1, nameof(sha1), required: true);
            return new DeferredBodyAction<SslCert>(() =>
            {
                var apiCallPath = "/v1/ssl/cert/sha1";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["sha1"] = ExpressionConverter.Convert(__workflow_sha1);
                return new ApiConnectionAction<SslCert>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqintelligence")]
        public IBodyWorkflowAction<SslCertHostPage> HOSTSBYSSLSHA1(Expression<Func<string>> certSha1)
        {
            var __workflow_certSha1 = WorkflowExpression.Compile(certSha1, nameof(certSha1), required: true);
            return new DeferredBodyAction<SslCertHostPage>(() =>
            {
                var apiCallPath = "/v1/ssl/host";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["certSha1"] = ExpressionConverter.Convert(__workflow_certSha1);
                return new ApiConnectionAction<SslCertHostPage>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqintelligence")]
        public IBodyWorkflowAction<SslCertPage> SSLBYNAME(Expression<Func<string>> name)
        {
            var __workflow_name = WorkflowExpression.Compile(name, nameof(name), required: true);
            return new DeferredBodyAction<SslCertPage>(() =>
            {
                var apiCallPath = "/v1/ssl/cert/name";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["name"] = ExpressionConverter.Convert(__workflow_name);
                return new ApiConnectionAction<SslCertPage>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqintelligence")]
        public IBodyWorkflowAction<WhoisResult> WHOISIP(Expression<Func<string>> address, Expression<Func<string>> exact = null, Expression<Func<string>> maxResults = null)
        {
            var __workflow_address = WorkflowExpression.Compile(address, nameof(address), required: true);
            var __workflow_exact = WorkflowExpression.Compile(exact, nameof(exact), required: false);
            var __workflow_maxResults = WorkflowExpression.Compile(maxResults, nameof(maxResults), required: false);
            return new DeferredBodyAction<WhoisResult>(() =>
            {
                var apiCallPath = "/v0/whois/address";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["address"] = ExpressionConverter.Convert(__workflow_address);
                if (__workflow_exact != null)
                    callPayload.Queries["exact"] = ExpressionConverter.Convert(__workflow_exact);
                if (__workflow_maxResults != null)
                    callPayload.Queries["maxResults"] = ExpressionConverter.Convert(__workflow_maxResults);
                return new ApiConnectionAction<WhoisResult>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqintelligence")]
        public IBodyWorkflowAction<WhoisResult> WHOISDOMAIN(Expression<Func<string>> domain, Expression<Func<string>> exact = null, Expression<Func<string>> maxResults = null)
        {
            var __workflow_domain = WorkflowExpression.Compile(domain, nameof(domain), required: true);
            var __workflow_exact = WorkflowExpression.Compile(exact, nameof(exact), required: false);
            var __workflow_maxResults = WorkflowExpression.Compile(maxResults, nameof(maxResults), required: false);
            return new DeferredBodyAction<WhoisResult>(() =>
            {
                var apiCallPath = "/v0/whois/domain";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["domain"] = ExpressionConverter.Convert(__workflow_domain);
                if (__workflow_exact != null)
                    callPayload.Queries["exact"] = ExpressionConverter.Convert(__workflow_exact);
                if (__workflow_maxResults != null)
                    callPayload.Queries["maxResults"] = ExpressionConverter.Convert(__workflow_maxResults);
                return new ApiConnectionAction<WhoisResult>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqintelligence")]
        public IBodyWorkflowAction<WhoisResult> WHOISBYEMAIL(Expression<Func<string>> email, Expression<Func<string>> exact = null, Expression<Func<string>> maxResults = null)
        {
            var __workflow_email = WorkflowExpression.Compile(email, nameof(email), required: true);
            var __workflow_exact = WorkflowExpression.Compile(exact, nameof(exact), required: false);
            var __workflow_maxResults = WorkflowExpression.Compile(maxResults, nameof(maxResults), required: false);
            return new DeferredBodyAction<WhoisResult>(() =>
            {
                var apiCallPath = "/v0/whois/email";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["email"] = ExpressionConverter.Convert(__workflow_email);
                if (__workflow_exact != null)
                    callPayload.Queries["exact"] = ExpressionConverter.Convert(__workflow_exact);
                if (__workflow_maxResults != null)
                    callPayload.Queries["maxResults"] = ExpressionConverter.Convert(__workflow_maxResults);
                return new ApiConnectionAction<WhoisResult>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqintelligence")]
        public IBodyWorkflowAction<WhoisResult> WHOISBYNAME(Expression<Func<string>> name, Expression<Func<string>> exact = null, Expression<Func<string>> maxResults = null)
        {
            var __workflow_name = WorkflowExpression.Compile(name, nameof(name), required: true);
            var __workflow_exact = WorkflowExpression.Compile(exact, nameof(exact), required: false);
            var __workflow_maxResults = WorkflowExpression.Compile(maxResults, nameof(maxResults), required: false);
            return new DeferredBodyAction<WhoisResult>(() =>
            {
                var apiCallPath = "/v0/whois/name";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["name"] = ExpressionConverter.Convert(__workflow_name);
                if (__workflow_exact != null)
                    callPayload.Queries["exact"] = ExpressionConverter.Convert(__workflow_exact);
                if (__workflow_maxResults != null)
                    callPayload.Queries["maxResults"] = ExpressionConverter.Convert(__workflow_maxResults);
                return new ApiConnectionAction<WhoisResult>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqintelligence")]
        public IBodyWorkflowAction<WhoisResult> WHOISBYNAMESERVER(Expression<Func<string>> nameserver, Expression<Func<string>> exact = null, Expression<Func<string>> maxResults = null)
        {
            var __workflow_nameserver = WorkflowExpression.Compile(nameserver, nameof(nameserver), required: true);
            var __workflow_exact = WorkflowExpression.Compile(exact, nameof(exact), required: false);
            var __workflow_maxResults = WorkflowExpression.Compile(maxResults, nameof(maxResults), required: false);
            return new DeferredBodyAction<WhoisResult>(() =>
            {
                var apiCallPath = "/v0/whois/nameserver";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["nameserver"] = ExpressionConverter.Convert(__workflow_nameserver);
                if (__workflow_exact != null)
                    callPayload.Queries["exact"] = ExpressionConverter.Convert(__workflow_exact);
                if (__workflow_maxResults != null)
                    callPayload.Queries["maxResults"] = ExpressionConverter.Convert(__workflow_maxResults);
                return new ApiConnectionAction<WhoisResult>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqintelligence")]
        public IBodyWorkflowAction<WhoisResult> WHOISBYORGANIZATION(Expression<Func<string>> org, Expression<Func<string>> exact = null, Expression<Func<string>> maxResults = null)
        {
            var __workflow_org = WorkflowExpression.Compile(org, nameof(org), required: true);
            var __workflow_exact = WorkflowExpression.Compile(exact, nameof(exact), required: false);
            var __workflow_maxResults = WorkflowExpression.Compile(maxResults, nameof(maxResults), required: false);
            return new DeferredBodyAction<WhoisResult>(() =>
            {
                var apiCallPath = "/v0/whois/org";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["org"] = ExpressionConverter.Convert(__workflow_org);
                if (__workflow_exact != null)
                    callPayload.Queries["exact"] = ExpressionConverter.Convert(__workflow_exact);
                if (__workflow_maxResults != null)
                    callPayload.Queries["maxResults"] = ExpressionConverter.Convert(__workflow_maxResults);
                return new ApiConnectionAction<WhoisResult>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqintelligence")]
        public IBodyWorkflowAction<WhoisResult> WHOISBYPHONE(Expression<Func<string>> phone, Expression<Func<string>> exact = null, Expression<Func<string>> maxResults = null)
        {
            var __workflow_phone = WorkflowExpression.Compile(phone, nameof(phone), required: true);
            var __workflow_exact = WorkflowExpression.Compile(exact, nameof(exact), required: false);
            var __workflow_maxResults = WorkflowExpression.Compile(maxResults, nameof(maxResults), required: false);
            return new DeferredBodyAction<WhoisResult>(() =>
            {
                var apiCallPath = "/v0/whois/phone";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["phone"] = ExpressionConverter.Convert(__workflow_phone);
                if (__workflow_exact != null)
                    callPayload.Queries["exact"] = ExpressionConverter.Convert(__workflow_exact);
                if (__workflow_maxResults != null)
                    callPayload.Queries["maxResults"] = ExpressionConverter.Convert(__workflow_maxResults);
                return new ApiConnectionAction<WhoisResult>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqintelligence")]
        public IBodyWorkflowAction<HostAttributeResult> TRACKERSHOST(Expression<Func<string>> host, Expression<Func<int>> size = null, Expression<Func<int>> page = null, Expression<Func<int>> before = null, Expression<Func<int>> after = null, Expression<Func<int>> beforeDay = null, Expression<Func<int>> afterDay = null, Expression<Func<string>> exact = null)
        {
            var __workflow_host = WorkflowExpression.Compile(host, nameof(host), required: true);
            var __workflow_size = WorkflowExpression.Compile(size, nameof(size), required: false);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_before = WorkflowExpression.Compile(before, nameof(before), required: false);
            var __workflow_after = WorkflowExpression.Compile(after, nameof(after), required: false);
            var __workflow_beforeDay = WorkflowExpression.Compile(beforeDay, nameof(beforeDay), required: false);
            var __workflow_afterDay = WorkflowExpression.Compile(afterDay, nameof(afterDay), required: false);
            var __workflow_exact = WorkflowExpression.Compile(exact, nameof(exact), required: false);
            return new DeferredBodyAction<HostAttributeResult>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v0/hostattributes/hosts/trackers/{0}", __workflow_host.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_size != null)
                    callPayload.Queries["size"] = ExpressionConverter.Convert(__workflow_size);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_before != null)
                    callPayload.Queries["before"] = ExpressionConverter.Convert(__workflow_before);
                if (__workflow_after != null)
                    callPayload.Queries["after"] = ExpressionConverter.Convert(__workflow_after);
                if (__workflow_beforeDay != null)
                    callPayload.Queries["beforeDay"] = ExpressionConverter.Convert(__workflow_beforeDay);
                if (__workflow_afterDay != null)
                    callPayload.Queries["afterDay"] = ExpressionConverter.Convert(__workflow_afterDay);
                if (__workflow_exact != null)
                    callPayload.Queries["exact"] = ExpressionConverter.Convert(__workflow_exact);
                return new ApiConnectionAction<HostAttributeResult>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqintelligence")]
        public IBodyWorkflowAction<HostAttributeResult> TRACKERSDOMAIN(Expression<Func<string>> domain, Expression<Func<int>> size = null, Expression<Func<int>> page = null, Expression<Func<int>> before = null, Expression<Func<int>> after = null, Expression<Func<int>> beforeDay = null, Expression<Func<int>> afterDay = null, Expression<Func<string>> exact = null)
        {
            var __workflow_domain = WorkflowExpression.Compile(domain, nameof(domain), required: true);
            var __workflow_size = WorkflowExpression.Compile(size, nameof(size), required: false);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_before = WorkflowExpression.Compile(before, nameof(before), required: false);
            var __workflow_after = WorkflowExpression.Compile(after, nameof(after), required: false);
            var __workflow_beforeDay = WorkflowExpression.Compile(beforeDay, nameof(beforeDay), required: false);
            var __workflow_afterDay = WorkflowExpression.Compile(afterDay, nameof(afterDay), required: false);
            var __workflow_exact = WorkflowExpression.Compile(exact, nameof(exact), required: false);
            return new DeferredBodyAction<HostAttributeResult>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v0/hostattributes/domains/trackers/{0}", __workflow_domain.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_size != null)
                    callPayload.Queries["size"] = ExpressionConverter.Convert(__workflow_size);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_before != null)
                    callPayload.Queries["before"] = ExpressionConverter.Convert(__workflow_before);
                if (__workflow_after != null)
                    callPayload.Queries["after"] = ExpressionConverter.Convert(__workflow_after);
                if (__workflow_beforeDay != null)
                    callPayload.Queries["beforeDay"] = ExpressionConverter.Convert(__workflow_beforeDay);
                if (__workflow_afterDay != null)
                    callPayload.Queries["afterDay"] = ExpressionConverter.Convert(__workflow_afterDay);
                if (__workflow_exact != null)
                    callPayload.Queries["exact"] = ExpressionConverter.Convert(__workflow_exact);
                return new ApiConnectionAction<HostAttributeResult>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqintelligence")]
        public IBodyWorkflowAction<HostAttributeResult> TRACKERSIP(Expression<Func<string>> address, Expression<Func<int>> size = null, Expression<Func<int>> page = null, Expression<Func<int>> before = null, Expression<Func<int>> after = null, Expression<Func<int>> beforeDay = null, Expression<Func<int>> afterDay = null, Expression<Func<string>> exact = null)
        {
            var __workflow_address = WorkflowExpression.Compile(address, nameof(address), required: true);
            var __workflow_size = WorkflowExpression.Compile(size, nameof(size), required: false);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_before = WorkflowExpression.Compile(before, nameof(before), required: false);
            var __workflow_after = WorkflowExpression.Compile(after, nameof(after), required: false);
            var __workflow_beforeDay = WorkflowExpression.Compile(beforeDay, nameof(beforeDay), required: false);
            var __workflow_afterDay = WorkflowExpression.Compile(afterDay, nameof(afterDay), required: false);
            var __workflow_exact = WorkflowExpression.Compile(exact, nameof(exact), required: false);
            return new DeferredBodyAction<HostAttributeResult>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v0/hostattributes/addresses/trackers/{0}", __workflow_address.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_size != null)
                    callPayload.Queries["size"] = ExpressionConverter.Convert(__workflow_size);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_before != null)
                    callPayload.Queries["before"] = ExpressionConverter.Convert(__workflow_before);
                if (__workflow_after != null)
                    callPayload.Queries["after"] = ExpressionConverter.Convert(__workflow_after);
                if (__workflow_beforeDay != null)
                    callPayload.Queries["beforeDay"] = ExpressionConverter.Convert(__workflow_beforeDay);
                if (__workflow_afterDay != null)
                    callPayload.Queries["afterDay"] = ExpressionConverter.Convert(__workflow_afterDay);
                if (__workflow_exact != null)
                    callPayload.Queries["exact"] = ExpressionConverter.Convert(__workflow_exact);
                return new ApiConnectionAction<HostAttributeResult>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqintelligence")]
        public IBodyWorkflowAction<HostPairsResult> HOSTPAIRSCHILD(Expression<Func<string>> host, Expression<Func<int>> size = null, Expression<Func<int>> page = null, Expression<Func<int>> before = null, Expression<Func<int>> after = null, Expression<Func<int>> beforeDay = null, Expression<Func<int>> afterDay = null, Expression<Func<string>> exact = null)
        {
            var __workflow_host = WorkflowExpression.Compile(host, nameof(host), required: true);
            var __workflow_size = WorkflowExpression.Compile(size, nameof(size), required: false);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_before = WorkflowExpression.Compile(before, nameof(before), required: false);
            var __workflow_after = WorkflowExpression.Compile(after, nameof(after), required: false);
            var __workflow_beforeDay = WorkflowExpression.Compile(beforeDay, nameof(beforeDay), required: false);
            var __workflow_afterDay = WorkflowExpression.Compile(afterDay, nameof(afterDay), required: false);
            var __workflow_exact = WorkflowExpression.Compile(exact, nameof(exact), required: false);
            return new DeferredBodyAction<HostPairsResult>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v0/hostattributes/hosts/trackers/children/{0}", __workflow_host.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_size != null)
                    callPayload.Queries["size"] = ExpressionConverter.Convert(__workflow_size);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_before != null)
                    callPayload.Queries["before"] = ExpressionConverter.Convert(__workflow_before);
                if (__workflow_after != null)
                    callPayload.Queries["after"] = ExpressionConverter.Convert(__workflow_after);
                if (__workflow_beforeDay != null)
                    callPayload.Queries["beforeDay"] = ExpressionConverter.Convert(__workflow_beforeDay);
                if (__workflow_afterDay != null)
                    callPayload.Queries["afterDay"] = ExpressionConverter.Convert(__workflow_afterDay);
                if (__workflow_exact != null)
                    callPayload.Queries["exact"] = ExpressionConverter.Convert(__workflow_exact);
                return new ApiConnectionAction<HostPairsResult>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqintelligence")]
        public IBodyWorkflowAction<HostPairsResult> HOSTPAIRSPARENT(Expression<Func<string>> host, Expression<Func<int>> size = null, Expression<Func<int>> page = null, Expression<Func<int>> before = null, Expression<Func<int>> after = null, Expression<Func<int>> beforeDay = null, Expression<Func<int>> afterDay = null, Expression<Func<string>> exact = null)
        {
            var __workflow_host = WorkflowExpression.Compile(host, nameof(host), required: true);
            var __workflow_size = WorkflowExpression.Compile(size, nameof(size), required: false);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_before = WorkflowExpression.Compile(before, nameof(before), required: false);
            var __workflow_after = WorkflowExpression.Compile(after, nameof(after), required: false);
            var __workflow_beforeDay = WorkflowExpression.Compile(beforeDay, nameof(beforeDay), required: false);
            var __workflow_afterDay = WorkflowExpression.Compile(afterDay, nameof(afterDay), required: false);
            var __workflow_exact = WorkflowExpression.Compile(exact, nameof(exact), required: false);
            return new DeferredBodyAction<HostPairsResult>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v0/hostattributes/hosts/trackers/parents/{0}", __workflow_host.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_size != null)
                    callPayload.Queries["size"] = ExpressionConverter.Convert(__workflow_size);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_before != null)
                    callPayload.Queries["before"] = ExpressionConverter.Convert(__workflow_before);
                if (__workflow_after != null)
                    callPayload.Queries["after"] = ExpressionConverter.Convert(__workflow_after);
                if (__workflow_beforeDay != null)
                    callPayload.Queries["beforeDay"] = ExpressionConverter.Convert(__workflow_beforeDay);
                if (__workflow_afterDay != null)
                    callPayload.Queries["afterDay"] = ExpressionConverter.Convert(__workflow_afterDay);
                if (__workflow_exact != null)
                    callPayload.Queries["exact"] = ExpressionConverter.Convert(__workflow_exact);
                return new ApiConnectionAction<HostPairsResult>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqintelligence")]
        public IBodyWorkflowAction<HostComponentsResult> WEBCOMPONENTHOST(Expression<Func<string>> host, Expression<Func<int>> size = null, Expression<Func<int>> page = null, Expression<Func<int>> before = null, Expression<Func<int>> after = null, Expression<Func<int>> beforeDay = null, Expression<Func<int>> afterDay = null, Expression<Func<string>> exact = null)
        {
            var __workflow_host = WorkflowExpression.Compile(host, nameof(host), required: true);
            var __workflow_size = WorkflowExpression.Compile(size, nameof(size), required: false);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_before = WorkflowExpression.Compile(before, nameof(before), required: false);
            var __workflow_after = WorkflowExpression.Compile(after, nameof(after), required: false);
            var __workflow_beforeDay = WorkflowExpression.Compile(beforeDay, nameof(beforeDay), required: false);
            var __workflow_afterDay = WorkflowExpression.Compile(afterDay, nameof(afterDay), required: false);
            var __workflow_exact = WorkflowExpression.Compile(exact, nameof(exact), required: false);
            return new DeferredBodyAction<HostComponentsResult>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v0/hostattributes/hosts/components/{0}", __workflow_host.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_size != null)
                    callPayload.Queries["size"] = ExpressionConverter.Convert(__workflow_size);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_before != null)
                    callPayload.Queries["before"] = ExpressionConverter.Convert(__workflow_before);
                if (__workflow_after != null)
                    callPayload.Queries["after"] = ExpressionConverter.Convert(__workflow_after);
                if (__workflow_beforeDay != null)
                    callPayload.Queries["beforeDay"] = ExpressionConverter.Convert(__workflow_beforeDay);
                if (__workflow_afterDay != null)
                    callPayload.Queries["afterDay"] = ExpressionConverter.Convert(__workflow_afterDay);
                if (__workflow_exact != null)
                    callPayload.Queries["exact"] = ExpressionConverter.Convert(__workflow_exact);
                return new ApiConnectionAction<HostComponentsResult>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqintelligence")]
        public IBodyWorkflowAction<HostComponentsResult> WEBCOMPONENTSDOMAIN(Expression<Func<string>> domain, Expression<Func<int>> size = null, Expression<Func<int>> page = null, Expression<Func<int>> before = null, Expression<Func<int>> after = null, Expression<Func<int>> beforeDay = null, Expression<Func<int>> afterDay = null, Expression<Func<string>> exact = null)
        {
            var __workflow_domain = WorkflowExpression.Compile(domain, nameof(domain), required: true);
            var __workflow_size = WorkflowExpression.Compile(size, nameof(size), required: false);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_before = WorkflowExpression.Compile(before, nameof(before), required: false);
            var __workflow_after = WorkflowExpression.Compile(after, nameof(after), required: false);
            var __workflow_beforeDay = WorkflowExpression.Compile(beforeDay, nameof(beforeDay), required: false);
            var __workflow_afterDay = WorkflowExpression.Compile(afterDay, nameof(afterDay), required: false);
            var __workflow_exact = WorkflowExpression.Compile(exact, nameof(exact), required: false);
            return new DeferredBodyAction<HostComponentsResult>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v0/hostattributes/domains/components/{0}", __workflow_domain.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_size != null)
                    callPayload.Queries["size"] = ExpressionConverter.Convert(__workflow_size);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_before != null)
                    callPayload.Queries["before"] = ExpressionConverter.Convert(__workflow_before);
                if (__workflow_after != null)
                    callPayload.Queries["after"] = ExpressionConverter.Convert(__workflow_after);
                if (__workflow_beforeDay != null)
                    callPayload.Queries["beforeDay"] = ExpressionConverter.Convert(__workflow_beforeDay);
                if (__workflow_afterDay != null)
                    callPayload.Queries["afterDay"] = ExpressionConverter.Convert(__workflow_afterDay);
                if (__workflow_exact != null)
                    callPayload.Queries["exact"] = ExpressionConverter.Convert(__workflow_exact);
                return new ApiConnectionAction<HostComponentsResult>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqintelligence")]
        public IBodyWorkflowAction<HostComponentsResult> WEBCOMPONENTSIP(Expression<Func<string>> address, Expression<Func<int>> size = null, Expression<Func<int>> page = null, Expression<Func<int>> before = null, Expression<Func<int>> after = null, Expression<Func<int>> beforeDay = null, Expression<Func<int>> afterDay = null, Expression<Func<string>> exact = null)
        {
            var __workflow_address = WorkflowExpression.Compile(address, nameof(address), required: true);
            var __workflow_size = WorkflowExpression.Compile(size, nameof(size), required: false);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_before = WorkflowExpression.Compile(before, nameof(before), required: false);
            var __workflow_after = WorkflowExpression.Compile(after, nameof(after), required: false);
            var __workflow_beforeDay = WorkflowExpression.Compile(beforeDay, nameof(beforeDay), required: false);
            var __workflow_afterDay = WorkflowExpression.Compile(afterDay, nameof(afterDay), required: false);
            var __workflow_exact = WorkflowExpression.Compile(exact, nameof(exact), required: false);
            return new DeferredBodyAction<HostComponentsResult>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v0/hostattributes/addresses/components/{0}", __workflow_address.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_size != null)
                    callPayload.Queries["size"] = ExpressionConverter.Convert(__workflow_size);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_before != null)
                    callPayload.Queries["before"] = ExpressionConverter.Convert(__workflow_before);
                if (__workflow_after != null)
                    callPayload.Queries["after"] = ExpressionConverter.Convert(__workflow_after);
                if (__workflow_beforeDay != null)
                    callPayload.Queries["beforeDay"] = ExpressionConverter.Convert(__workflow_beforeDay);
                if (__workflow_afterDay != null)
                    callPayload.Queries["afterDay"] = ExpressionConverter.Convert(__workflow_afterDay);
                if (__workflow_exact != null)
                    callPayload.Queries["exact"] = ExpressionConverter.Convert(__workflow_exact);
                return new ApiConnectionAction<HostComponentsResult>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqintelligence")]
        public IBodyWorkflowAction<HostCookieResult> COOKIESHOST(Expression<Func<string>> host, Expression<Func<int>> size = null, Expression<Func<int>> page = null, Expression<Func<int>> before = null, Expression<Func<int>> after = null, Expression<Func<int>> beforeDay = null, Expression<Func<int>> afterDay = null, Expression<Func<string>> exact = null)
        {
            var __workflow_host = WorkflowExpression.Compile(host, nameof(host), required: true);
            var __workflow_size = WorkflowExpression.Compile(size, nameof(size), required: false);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_before = WorkflowExpression.Compile(before, nameof(before), required: false);
            var __workflow_after = WorkflowExpression.Compile(after, nameof(after), required: false);
            var __workflow_beforeDay = WorkflowExpression.Compile(beforeDay, nameof(beforeDay), required: false);
            var __workflow_afterDay = WorkflowExpression.Compile(afterDay, nameof(afterDay), required: false);
            var __workflow_exact = WorkflowExpression.Compile(exact, nameof(exact), required: false);
            return new DeferredBodyAction<HostCookieResult>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v0/hostattributes/hosts/cookies/{0}", __workflow_host.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_size != null)
                    callPayload.Queries["size"] = ExpressionConverter.Convert(__workflow_size);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_before != null)
                    callPayload.Queries["before"] = ExpressionConverter.Convert(__workflow_before);
                if (__workflow_after != null)
                    callPayload.Queries["after"] = ExpressionConverter.Convert(__workflow_after);
                if (__workflow_beforeDay != null)
                    callPayload.Queries["beforeDay"] = ExpressionConverter.Convert(__workflow_beforeDay);
                if (__workflow_afterDay != null)
                    callPayload.Queries["afterDay"] = ExpressionConverter.Convert(__workflow_afterDay);
                if (__workflow_exact != null)
                    callPayload.Queries["exact"] = ExpressionConverter.Convert(__workflow_exact);
                return new ApiConnectionAction<HostCookieResult>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqintelligence")]
        public IBodyWorkflowAction<HostCookieResult> COOKIESIP(Expression<Func<string>> address, Expression<Func<int>> size = null, Expression<Func<int>> page = null, Expression<Func<int>> before = null, Expression<Func<int>> after = null, Expression<Func<int>> beforeDay = null, Expression<Func<int>> afterDay = null, Expression<Func<string>> exact = null)
        {
            var __workflow_address = WorkflowExpression.Compile(address, nameof(address), required: true);
            var __workflow_size = WorkflowExpression.Compile(size, nameof(size), required: false);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_before = WorkflowExpression.Compile(before, nameof(before), required: false);
            var __workflow_after = WorkflowExpression.Compile(after, nameof(after), required: false);
            var __workflow_beforeDay = WorkflowExpression.Compile(beforeDay, nameof(beforeDay), required: false);
            var __workflow_afterDay = WorkflowExpression.Compile(afterDay, nameof(afterDay), required: false);
            var __workflow_exact = WorkflowExpression.Compile(exact, nameof(exact), required: false);
            return new DeferredBodyAction<HostCookieResult>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v0/hostattributes/addresses/cookies/{0}", __workflow_address.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_size != null)
                    callPayload.Queries["size"] = ExpressionConverter.Convert(__workflow_size);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_before != null)
                    callPayload.Queries["before"] = ExpressionConverter.Convert(__workflow_before);
                if (__workflow_after != null)
                    callPayload.Queries["after"] = ExpressionConverter.Convert(__workflow_after);
                if (__workflow_beforeDay != null)
                    callPayload.Queries["beforeDay"] = ExpressionConverter.Convert(__workflow_beforeDay);
                if (__workflow_afterDay != null)
                    callPayload.Queries["afterDay"] = ExpressionConverter.Convert(__workflow_afterDay);
                if (__workflow_exact != null)
                    callPayload.Queries["exact"] = ExpressionConverter.Convert(__workflow_exact);
                return new ApiConnectionAction<HostCookieResult>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqintelligence")]
        public IBodyWorkflowAction<JToken> ENRICHMENTHOST(Expression<Func<string>> host, Expression<Func<bool>> whois = null, Expression<Func<bool>> hostDetails = null, Expression<Func<bool>> ipDetails = null, Expression<Func<bool>> linkedAssetCounts = null, Expression<Func<bool>> recentPDNS = null, Expression<Func<bool>> subDomainPDNS = null, Expression<Func<bool>> openPorts = null, Expression<Func<bool>> certificates = null)
        {
            var __workflow_host = WorkflowExpression.Compile(host, nameof(host), required: true);
            var __workflow_whois = WorkflowExpression.Compile(whois, nameof(whois), required: false);
            var __workflow_hostDetails = WorkflowExpression.Compile(hostDetails, nameof(hostDetails), required: false);
            var __workflow_ipDetails = WorkflowExpression.Compile(ipDetails, nameof(ipDetails), required: false);
            var __workflow_linkedAssetCounts = WorkflowExpression.Compile(linkedAssetCounts, nameof(linkedAssetCounts), required: false);
            var __workflow_recentPDNS = WorkflowExpression.Compile(recentPDNS, nameof(recentPDNS), required: false);
            var __workflow_subDomainPDNS = WorkflowExpression.Compile(subDomainPDNS, nameof(subDomainPDNS), required: false);
            var __workflow_openPorts = WorkflowExpression.Compile(openPorts, nameof(openPorts), required: false);
            var __workflow_certificates = WorkflowExpression.Compile(certificates, nameof(certificates), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v0/enrich/host/{0}", __workflow_host.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["whois"] = Convert.ToString(true);
                if (__workflow_whois != null)
                    callPayload.Queries["whois"] = ExpressionConverter.Convert(__workflow_whois);
                callPayload.Queries["hostDetails"] = Convert.ToString(true);
                if (__workflow_hostDetails != null)
                    callPayload.Queries["hostDetails"] = ExpressionConverter.Convert(__workflow_hostDetails);
                callPayload.Queries["ipDetails"] = Convert.ToString(true);
                if (__workflow_ipDetails != null)
                    callPayload.Queries["ipDetails"] = ExpressionConverter.Convert(__workflow_ipDetails);
                callPayload.Queries["linkedAssetCounts"] = Convert.ToString(true);
                if (__workflow_linkedAssetCounts != null)
                    callPayload.Queries["linkedAssetCounts"] = ExpressionConverter.Convert(__workflow_linkedAssetCounts);
                callPayload.Queries["recentPDNS"] = Convert.ToString(true);
                if (__workflow_recentPDNS != null)
                    callPayload.Queries["recentPDNS"] = ExpressionConverter.Convert(__workflow_recentPDNS);
                callPayload.Queries["subDomainPDNS"] = Convert.ToString(true);
                if (__workflow_subDomainPDNS != null)
                    callPayload.Queries["subDomainPDNS"] = ExpressionConverter.Convert(__workflow_subDomainPDNS);
                callPayload.Queries["openPorts"] = Convert.ToString(true);
                if (__workflow_openPorts != null)
                    callPayload.Queries["openPorts"] = ExpressionConverter.Convert(__workflow_openPorts);
                callPayload.Queries["certificates"] = Convert.ToString(true);
                if (__workflow_certificates != null)
                    callPayload.Queries["certificates"] = ExpressionConverter.Convert(__workflow_certificates);
                return new ApiConnectionAction<JToken>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqintelligence")]
        public IBodyWorkflowAction<JToken> ENRICHMENTIP(Expression<Func<string>> ip, Expression<Func<bool>> whois = null, Expression<Func<bool>> hostDetails = null, Expression<Func<bool>> linkedAssetCounts = null, Expression<Func<bool>> openPorts = null, Expression<Func<bool>> certificates = null)
        {
            var __workflow_ip = WorkflowExpression.Compile(ip, nameof(ip), required: true);
            var __workflow_whois = WorkflowExpression.Compile(whois, nameof(whois), required: false);
            var __workflow_hostDetails = WorkflowExpression.Compile(hostDetails, nameof(hostDetails), required: false);
            var __workflow_linkedAssetCounts = WorkflowExpression.Compile(linkedAssetCounts, nameof(linkedAssetCounts), required: false);
            var __workflow_openPorts = WorkflowExpression.Compile(openPorts, nameof(openPorts), required: false);
            var __workflow_certificates = WorkflowExpression.Compile(certificates, nameof(certificates), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v0/enrich/ip/{0}", __workflow_ip.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["whois"] = Convert.ToString(true);
                if (__workflow_whois != null)
                    callPayload.Queries["whois"] = ExpressionConverter.Convert(__workflow_whois);
                callPayload.Queries["hostDetails"] = Convert.ToString(true);
                if (__workflow_hostDetails != null)
                    callPayload.Queries["hostDetails"] = ExpressionConverter.Convert(__workflow_hostDetails);
                callPayload.Queries["linkedAssetCounts"] = Convert.ToString(true);
                if (__workflow_linkedAssetCounts != null)
                    callPayload.Queries["linkedAssetCounts"] = ExpressionConverter.Convert(__workflow_linkedAssetCounts);
                callPayload.Queries["openPorts"] = Convert.ToString(true);
                if (__workflow_openPorts != null)
                    callPayload.Queries["openPorts"] = ExpressionConverter.Convert(__workflow_openPorts);
                callPayload.Queries["certificates"] = Convert.ToString(true);
                if (__workflow_certificates != null)
                    callPayload.Queries["certificates"] = ExpressionConverter.Convert(__workflow_certificates);
                return new ApiConnectionAction<JToken>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
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
