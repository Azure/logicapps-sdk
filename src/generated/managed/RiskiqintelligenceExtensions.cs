//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Riskiqintelligence
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class RiskiqintelligenceActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqintelligence")]
        [WorkflowExpressionFactory(nameof(__BuildPDNSIP))]
        public IBodyWorkflowAction<RRSets> PDNSIP([WorkflowExpression] Func<string> ip, [WorkflowExpression] Func<string> max = null, [WorkflowExpression] Func<string> lastSeenAfter = null, [WorkflowExpression] Func<string> firstSeenBefore = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<RRSets> __BuildPDNSIP(WorkflowValue<string> ip, WorkflowValue<string> max = null, WorkflowValue<string> lastSeenAfter = null, WorkflowValue<string> firstSeenBefore = null)
        {
            WorkflowValue.Validate(ip, nameof(ip), required: true);
            WorkflowValue.Validate(max, nameof(max), required: false);
            WorkflowValue.Validate(lastSeenAfter, nameof(lastSeenAfter), required: false);
            WorkflowValue.Validate(firstSeenBefore, nameof(firstSeenBefore), required: false);
            return new DeferredBodyAction<RRSets>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqintelligence")]
        [WorkflowExpressionFactory(nameof(__BuildPDNSRESOURCEDATA))]
        public IBodyWorkflowAction<RRSets> PDNSRESOURCEDATA([WorkflowExpression] Func<string> name, [WorkflowExpression] Func<string> type = null, [WorkflowExpression] Func<string> max = null, [WorkflowExpression] Func<string> lastSeenAfter = null, [WorkflowExpression] Func<string> firstSeenBefore = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<RRSets> __BuildPDNSRESOURCEDATA(WorkflowValue<string> name, WorkflowValue<string> type = null, WorkflowValue<string> max = null, WorkflowValue<string> lastSeenAfter = null, WorkflowValue<string> firstSeenBefore = null)
        {
            WorkflowValue.Validate(name, nameof(name), required: true);
            WorkflowValue.Validate(type, nameof(type), required: false);
            WorkflowValue.Validate(max, nameof(max), required: false);
            WorkflowValue.Validate(lastSeenAfter, nameof(lastSeenAfter), required: false);
            WorkflowValue.Validate(firstSeenBefore, nameof(firstSeenBefore), required: false);
            return new DeferredBodyAction<RRSets>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqintelligence")]
        [WorkflowExpressionFactory(nameof(__BuildPDNSRESOURCEDATAHEX))]
        public IBodyWorkflowAction<RRSets> PDNSRESOURCEDATAHEX([WorkflowExpression] Func<string> hex, [WorkflowExpression] Func<string> type = null, [WorkflowExpression] Func<string> max = null, [WorkflowExpression] Func<string> lastSeenAfter = null, [WorkflowExpression] Func<string> firstSeenBefore = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<RRSets> __BuildPDNSRESOURCEDATAHEX(WorkflowValue<string> hex, WorkflowValue<string> type = null, WorkflowValue<string> max = null, WorkflowValue<string> lastSeenAfter = null, WorkflowValue<string> firstSeenBefore = null)
        {
            WorkflowValue.Validate(hex, nameof(hex), required: true);
            WorkflowValue.Validate(type, nameof(type), required: false);
            WorkflowValue.Validate(max, nameof(max), required: false);
            WorkflowValue.Validate(lastSeenAfter, nameof(lastSeenAfter), required: false);
            WorkflowValue.Validate(firstSeenBefore, nameof(firstSeenBefore), required: false);
            return new DeferredBodyAction<RRSets>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqintelligence")]
        [WorkflowExpressionFactory(nameof(__BuildPDNSNAME))]
        public IBodyWorkflowAction<RRSets> PDNSNAME([WorkflowExpression] Func<string> name, [WorkflowExpression] Func<string> type = null, [WorkflowExpression] Func<string> max = null, [WorkflowExpression] Func<string> lastSeenAfter = null, [WorkflowExpression] Func<string> firstSeenBefore = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<RRSets> __BuildPDNSNAME(WorkflowValue<string> name, WorkflowValue<string> type = null, WorkflowValue<string> max = null, WorkflowValue<string> lastSeenAfter = null, WorkflowValue<string> firstSeenBefore = null)
        {
            WorkflowValue.Validate(name, nameof(name), required: true);
            WorkflowValue.Validate(type, nameof(type), required: false);
            WorkflowValue.Validate(max, nameof(max), required: false);
            WorkflowValue.Validate(lastSeenAfter, nameof(lastSeenAfter), required: false);
            WorkflowValue.Validate(firstSeenBefore, nameof(firstSeenBefore), required: false);
            return new DeferredBodyAction<RRSets>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqintelligence")]
        [WorkflowExpressionFactory(nameof(__BuildSSLBYHOST))]
        public IBodyWorkflowAction<SslCertWithHostPage> SSLBYHOST([WorkflowExpression] Func<string> host)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SslCertWithHostPage> __BuildSSLBYHOST(WorkflowValue<string> host)
        {
            WorkflowValue.Validate(host, nameof(host), required: true);
            return new DeferredBodyAction<SslCertWithHostPage>(() =>
            {
                var apiCallPath = "/v1/ssl/cert/host";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["host"] = ExpressionConverter.Convert(host);
                return new ApiConnectionAction<SslCertWithHostPage>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqintelligence")]
        [WorkflowExpressionFactory(nameof(__BuildSSLBYSERIAL))]
        public IBodyWorkflowAction<SslCertPage> SSLBYSERIAL([WorkflowExpression] Func<string> serial)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SslCertPage> __BuildSSLBYSERIAL(WorkflowValue<string> serial)
        {
            WorkflowValue.Validate(serial, nameof(serial), required: true);
            return new DeferredBodyAction<SslCertPage>(() =>
            {
                var apiCallPath = "/v1/ssl/cert/serial";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["serial"] = ExpressionConverter.Convert(serial);
                return new ApiConnectionAction<SslCertPage>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqintelligence")]
        [WorkflowExpressionFactory(nameof(__BuildSSLBYSHA1))]
        public IBodyWorkflowAction<SslCert> SSLBYSHA1([WorkflowExpression] Func<string> sha1)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SslCert> __BuildSSLBYSHA1(WorkflowValue<string> sha1)
        {
            WorkflowValue.Validate(sha1, nameof(sha1), required: true);
            return new DeferredBodyAction<SslCert>(() =>
            {
                var apiCallPath = "/v1/ssl/cert/sha1";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["sha1"] = ExpressionConverter.Convert(sha1);
                return new ApiConnectionAction<SslCert>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqintelligence")]
        [WorkflowExpressionFactory(nameof(__BuildHOSTSBYSSLSHA1))]
        public IBodyWorkflowAction<SslCertHostPage> HOSTSBYSSLSHA1([WorkflowExpression] Func<string> certSha1)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SslCertHostPage> __BuildHOSTSBYSSLSHA1(WorkflowValue<string> certSha1)
        {
            WorkflowValue.Validate(certSha1, nameof(certSha1), required: true);
            return new DeferredBodyAction<SslCertHostPage>(() =>
            {
                var apiCallPath = "/v1/ssl/host";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["certSha1"] = ExpressionConverter.Convert(certSha1);
                return new ApiConnectionAction<SslCertHostPage>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqintelligence")]
        [WorkflowExpressionFactory(nameof(__BuildSSLBYNAME))]
        public IBodyWorkflowAction<SslCertPage> SSLBYNAME([WorkflowExpression] Func<string> name)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SslCertPage> __BuildSSLBYNAME(WorkflowValue<string> name)
        {
            WorkflowValue.Validate(name, nameof(name), required: true);
            return new DeferredBodyAction<SslCertPage>(() =>
            {
                var apiCallPath = "/v1/ssl/cert/name";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["name"] = ExpressionConverter.Convert(name);
                return new ApiConnectionAction<SslCertPage>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqintelligence")]
        [WorkflowExpressionFactory(nameof(__BuildWHOISIP))]
        public IBodyWorkflowAction<WhoisResult> WHOISIP([WorkflowExpression] Func<string> address, [WorkflowExpression] Func<string> exact = null, [WorkflowExpression] Func<string> maxResults = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<WhoisResult> __BuildWHOISIP(WorkflowValue<string> address, WorkflowValue<string> exact = null, WorkflowValue<string> maxResults = null)
        {
            WorkflowValue.Validate(address, nameof(address), required: true);
            WorkflowValue.Validate(exact, nameof(exact), required: false);
            WorkflowValue.Validate(maxResults, nameof(maxResults), required: false);
            return new DeferredBodyAction<WhoisResult>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqintelligence")]
        [WorkflowExpressionFactory(nameof(__BuildWHOISDOMAIN))]
        public IBodyWorkflowAction<WhoisResult> WHOISDOMAIN([WorkflowExpression] Func<string> domain, [WorkflowExpression] Func<string> exact = null, [WorkflowExpression] Func<string> maxResults = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<WhoisResult> __BuildWHOISDOMAIN(WorkflowValue<string> domain, WorkflowValue<string> exact = null, WorkflowValue<string> maxResults = null)
        {
            WorkflowValue.Validate(domain, nameof(domain), required: true);
            WorkflowValue.Validate(exact, nameof(exact), required: false);
            WorkflowValue.Validate(maxResults, nameof(maxResults), required: false);
            return new DeferredBodyAction<WhoisResult>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqintelligence")]
        [WorkflowExpressionFactory(nameof(__BuildWHOISBYEMAIL))]
        public IBodyWorkflowAction<WhoisResult> WHOISBYEMAIL([WorkflowExpression] Func<string> email, [WorkflowExpression] Func<string> exact = null, [WorkflowExpression] Func<string> maxResults = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<WhoisResult> __BuildWHOISBYEMAIL(WorkflowValue<string> email, WorkflowValue<string> exact = null, WorkflowValue<string> maxResults = null)
        {
            WorkflowValue.Validate(email, nameof(email), required: true);
            WorkflowValue.Validate(exact, nameof(exact), required: false);
            WorkflowValue.Validate(maxResults, nameof(maxResults), required: false);
            return new DeferredBodyAction<WhoisResult>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqintelligence")]
        [WorkflowExpressionFactory(nameof(__BuildWHOISBYNAME))]
        public IBodyWorkflowAction<WhoisResult> WHOISBYNAME([WorkflowExpression] Func<string> name, [WorkflowExpression] Func<string> exact = null, [WorkflowExpression] Func<string> maxResults = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<WhoisResult> __BuildWHOISBYNAME(WorkflowValue<string> name, WorkflowValue<string> exact = null, WorkflowValue<string> maxResults = null)
        {
            WorkflowValue.Validate(name, nameof(name), required: true);
            WorkflowValue.Validate(exact, nameof(exact), required: false);
            WorkflowValue.Validate(maxResults, nameof(maxResults), required: false);
            return new DeferredBodyAction<WhoisResult>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqintelligence")]
        [WorkflowExpressionFactory(nameof(__BuildWHOISBYNAMESERVER))]
        public IBodyWorkflowAction<WhoisResult> WHOISBYNAMESERVER([WorkflowExpression] Func<string> nameserver, [WorkflowExpression] Func<string> exact = null, [WorkflowExpression] Func<string> maxResults = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<WhoisResult> __BuildWHOISBYNAMESERVER(WorkflowValue<string> nameserver, WorkflowValue<string> exact = null, WorkflowValue<string> maxResults = null)
        {
            WorkflowValue.Validate(nameserver, nameof(nameserver), required: true);
            WorkflowValue.Validate(exact, nameof(exact), required: false);
            WorkflowValue.Validate(maxResults, nameof(maxResults), required: false);
            return new DeferredBodyAction<WhoisResult>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqintelligence")]
        [WorkflowExpressionFactory(nameof(__BuildWHOISBYORGANIZATION))]
        public IBodyWorkflowAction<WhoisResult> WHOISBYORGANIZATION([WorkflowExpression] Func<string> org, [WorkflowExpression] Func<string> exact = null, [WorkflowExpression] Func<string> maxResults = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<WhoisResult> __BuildWHOISBYORGANIZATION(WorkflowValue<string> org, WorkflowValue<string> exact = null, WorkflowValue<string> maxResults = null)
        {
            WorkflowValue.Validate(org, nameof(org), required: true);
            WorkflowValue.Validate(exact, nameof(exact), required: false);
            WorkflowValue.Validate(maxResults, nameof(maxResults), required: false);
            return new DeferredBodyAction<WhoisResult>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqintelligence")]
        [WorkflowExpressionFactory(nameof(__BuildWHOISBYPHONE))]
        public IBodyWorkflowAction<WhoisResult> WHOISBYPHONE([WorkflowExpression] Func<string> phone, [WorkflowExpression] Func<string> exact = null, [WorkflowExpression] Func<string> maxResults = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<WhoisResult> __BuildWHOISBYPHONE(WorkflowValue<string> phone, WorkflowValue<string> exact = null, WorkflowValue<string> maxResults = null)
        {
            WorkflowValue.Validate(phone, nameof(phone), required: true);
            WorkflowValue.Validate(exact, nameof(exact), required: false);
            WorkflowValue.Validate(maxResults, nameof(maxResults), required: false);
            return new DeferredBodyAction<WhoisResult>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqintelligence")]
        [WorkflowExpressionFactory(nameof(__BuildTRACKERSHOST))]
        public IBodyWorkflowAction<HostAttributeResult> TRACKERSHOST([WorkflowExpression] Func<string> host, [WorkflowExpression] Func<int> size = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> before = null, [WorkflowExpression] Func<int> after = null, [WorkflowExpression] Func<int> beforeDay = null, [WorkflowExpression] Func<int> afterDay = null, [WorkflowExpression] Func<string> exact = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<HostAttributeResult> __BuildTRACKERSHOST(WorkflowValue<string> host, WorkflowValue<int> size = null, WorkflowValue<int> page = null, WorkflowValue<int> before = null, WorkflowValue<int> after = null, WorkflowValue<int> beforeDay = null, WorkflowValue<int> afterDay = null, WorkflowValue<string> exact = null)
        {
            WorkflowValue.Validate(host, nameof(host), required: true);
            WorkflowValue.Validate(size, nameof(size), required: false);
            WorkflowValue.Validate(page, nameof(page), required: false);
            WorkflowValue.Validate(before, nameof(before), required: false);
            WorkflowValue.Validate(after, nameof(after), required: false);
            WorkflowValue.Validate(beforeDay, nameof(beforeDay), required: false);
            WorkflowValue.Validate(afterDay, nameof(afterDay), required: false);
            WorkflowValue.Validate(exact, nameof(exact), required: false);
            return new DeferredBodyAction<HostAttributeResult>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v0/hostattributes/hosts/trackers/{0}", ExpressionConverter.ConvertWithUrlEncoding(host, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqintelligence")]
        [WorkflowExpressionFactory(nameof(__BuildTRACKERSDOMAIN))]
        public IBodyWorkflowAction<HostAttributeResult> TRACKERSDOMAIN([WorkflowExpression] Func<string> domain, [WorkflowExpression] Func<int> size = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> before = null, [WorkflowExpression] Func<int> after = null, [WorkflowExpression] Func<int> beforeDay = null, [WorkflowExpression] Func<int> afterDay = null, [WorkflowExpression] Func<string> exact = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<HostAttributeResult> __BuildTRACKERSDOMAIN(WorkflowValue<string> domain, WorkflowValue<int> size = null, WorkflowValue<int> page = null, WorkflowValue<int> before = null, WorkflowValue<int> after = null, WorkflowValue<int> beforeDay = null, WorkflowValue<int> afterDay = null, WorkflowValue<string> exact = null)
        {
            WorkflowValue.Validate(domain, nameof(domain), required: true);
            WorkflowValue.Validate(size, nameof(size), required: false);
            WorkflowValue.Validate(page, nameof(page), required: false);
            WorkflowValue.Validate(before, nameof(before), required: false);
            WorkflowValue.Validate(after, nameof(after), required: false);
            WorkflowValue.Validate(beforeDay, nameof(beforeDay), required: false);
            WorkflowValue.Validate(afterDay, nameof(afterDay), required: false);
            WorkflowValue.Validate(exact, nameof(exact), required: false);
            return new DeferredBodyAction<HostAttributeResult>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v0/hostattributes/domains/trackers/{0}", ExpressionConverter.ConvertWithUrlEncoding(domain, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqintelligence")]
        [WorkflowExpressionFactory(nameof(__BuildTRACKERSIP))]
        public IBodyWorkflowAction<HostAttributeResult> TRACKERSIP([WorkflowExpression] Func<string> address, [WorkflowExpression] Func<int> size = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> before = null, [WorkflowExpression] Func<int> after = null, [WorkflowExpression] Func<int> beforeDay = null, [WorkflowExpression] Func<int> afterDay = null, [WorkflowExpression] Func<string> exact = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<HostAttributeResult> __BuildTRACKERSIP(WorkflowValue<string> address, WorkflowValue<int> size = null, WorkflowValue<int> page = null, WorkflowValue<int> before = null, WorkflowValue<int> after = null, WorkflowValue<int> beforeDay = null, WorkflowValue<int> afterDay = null, WorkflowValue<string> exact = null)
        {
            WorkflowValue.Validate(address, nameof(address), required: true);
            WorkflowValue.Validate(size, nameof(size), required: false);
            WorkflowValue.Validate(page, nameof(page), required: false);
            WorkflowValue.Validate(before, nameof(before), required: false);
            WorkflowValue.Validate(after, nameof(after), required: false);
            WorkflowValue.Validate(beforeDay, nameof(beforeDay), required: false);
            WorkflowValue.Validate(afterDay, nameof(afterDay), required: false);
            WorkflowValue.Validate(exact, nameof(exact), required: false);
            return new DeferredBodyAction<HostAttributeResult>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v0/hostattributes/addresses/trackers/{0}", ExpressionConverter.ConvertWithUrlEncoding(address, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqintelligence")]
        [WorkflowExpressionFactory(nameof(__BuildHOSTPAIRSCHILD))]
        public IBodyWorkflowAction<HostPairsResult> HOSTPAIRSCHILD([WorkflowExpression] Func<string> host, [WorkflowExpression] Func<int> size = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> before = null, [WorkflowExpression] Func<int> after = null, [WorkflowExpression] Func<int> beforeDay = null, [WorkflowExpression] Func<int> afterDay = null, [WorkflowExpression] Func<string> exact = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<HostPairsResult> __BuildHOSTPAIRSCHILD(WorkflowValue<string> host, WorkflowValue<int> size = null, WorkflowValue<int> page = null, WorkflowValue<int> before = null, WorkflowValue<int> after = null, WorkflowValue<int> beforeDay = null, WorkflowValue<int> afterDay = null, WorkflowValue<string> exact = null)
        {
            WorkflowValue.Validate(host, nameof(host), required: true);
            WorkflowValue.Validate(size, nameof(size), required: false);
            WorkflowValue.Validate(page, nameof(page), required: false);
            WorkflowValue.Validate(before, nameof(before), required: false);
            WorkflowValue.Validate(after, nameof(after), required: false);
            WorkflowValue.Validate(beforeDay, nameof(beforeDay), required: false);
            WorkflowValue.Validate(afterDay, nameof(afterDay), required: false);
            WorkflowValue.Validate(exact, nameof(exact), required: false);
            return new DeferredBodyAction<HostPairsResult>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v0/hostattributes/hosts/trackers/children/{0}", ExpressionConverter.ConvertWithUrlEncoding(host, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqintelligence")]
        [WorkflowExpressionFactory(nameof(__BuildHOSTPAIRSPARENT))]
        public IBodyWorkflowAction<HostPairsResult> HOSTPAIRSPARENT([WorkflowExpression] Func<string> host, [WorkflowExpression] Func<int> size = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> before = null, [WorkflowExpression] Func<int> after = null, [WorkflowExpression] Func<int> beforeDay = null, [WorkflowExpression] Func<int> afterDay = null, [WorkflowExpression] Func<string> exact = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<HostPairsResult> __BuildHOSTPAIRSPARENT(WorkflowValue<string> host, WorkflowValue<int> size = null, WorkflowValue<int> page = null, WorkflowValue<int> before = null, WorkflowValue<int> after = null, WorkflowValue<int> beforeDay = null, WorkflowValue<int> afterDay = null, WorkflowValue<string> exact = null)
        {
            WorkflowValue.Validate(host, nameof(host), required: true);
            WorkflowValue.Validate(size, nameof(size), required: false);
            WorkflowValue.Validate(page, nameof(page), required: false);
            WorkflowValue.Validate(before, nameof(before), required: false);
            WorkflowValue.Validate(after, nameof(after), required: false);
            WorkflowValue.Validate(beforeDay, nameof(beforeDay), required: false);
            WorkflowValue.Validate(afterDay, nameof(afterDay), required: false);
            WorkflowValue.Validate(exact, nameof(exact), required: false);
            return new DeferredBodyAction<HostPairsResult>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v0/hostattributes/hosts/trackers/parents/{0}", ExpressionConverter.ConvertWithUrlEncoding(host, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqintelligence")]
        [WorkflowExpressionFactory(nameof(__BuildWEBCOMPONENTHOST))]
        public IBodyWorkflowAction<HostComponentsResult> WEBCOMPONENTHOST([WorkflowExpression] Func<string> host, [WorkflowExpression] Func<int> size = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> before = null, [WorkflowExpression] Func<int> after = null, [WorkflowExpression] Func<int> beforeDay = null, [WorkflowExpression] Func<int> afterDay = null, [WorkflowExpression] Func<string> exact = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<HostComponentsResult> __BuildWEBCOMPONENTHOST(WorkflowValue<string> host, WorkflowValue<int> size = null, WorkflowValue<int> page = null, WorkflowValue<int> before = null, WorkflowValue<int> after = null, WorkflowValue<int> beforeDay = null, WorkflowValue<int> afterDay = null, WorkflowValue<string> exact = null)
        {
            WorkflowValue.Validate(host, nameof(host), required: true);
            WorkflowValue.Validate(size, nameof(size), required: false);
            WorkflowValue.Validate(page, nameof(page), required: false);
            WorkflowValue.Validate(before, nameof(before), required: false);
            WorkflowValue.Validate(after, nameof(after), required: false);
            WorkflowValue.Validate(beforeDay, nameof(beforeDay), required: false);
            WorkflowValue.Validate(afterDay, nameof(afterDay), required: false);
            WorkflowValue.Validate(exact, nameof(exact), required: false);
            return new DeferredBodyAction<HostComponentsResult>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v0/hostattributes/hosts/components/{0}", ExpressionConverter.ConvertWithUrlEncoding(host, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqintelligence")]
        [WorkflowExpressionFactory(nameof(__BuildWEBCOMPONENTSDOMAIN))]
        public IBodyWorkflowAction<HostComponentsResult> WEBCOMPONENTSDOMAIN([WorkflowExpression] Func<string> domain, [WorkflowExpression] Func<int> size = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> before = null, [WorkflowExpression] Func<int> after = null, [WorkflowExpression] Func<int> beforeDay = null, [WorkflowExpression] Func<int> afterDay = null, [WorkflowExpression] Func<string> exact = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<HostComponentsResult> __BuildWEBCOMPONENTSDOMAIN(WorkflowValue<string> domain, WorkflowValue<int> size = null, WorkflowValue<int> page = null, WorkflowValue<int> before = null, WorkflowValue<int> after = null, WorkflowValue<int> beforeDay = null, WorkflowValue<int> afterDay = null, WorkflowValue<string> exact = null)
        {
            WorkflowValue.Validate(domain, nameof(domain), required: true);
            WorkflowValue.Validate(size, nameof(size), required: false);
            WorkflowValue.Validate(page, nameof(page), required: false);
            WorkflowValue.Validate(before, nameof(before), required: false);
            WorkflowValue.Validate(after, nameof(after), required: false);
            WorkflowValue.Validate(beforeDay, nameof(beforeDay), required: false);
            WorkflowValue.Validate(afterDay, nameof(afterDay), required: false);
            WorkflowValue.Validate(exact, nameof(exact), required: false);
            return new DeferredBodyAction<HostComponentsResult>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v0/hostattributes/domains/components/{0}", ExpressionConverter.ConvertWithUrlEncoding(domain, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqintelligence")]
        [WorkflowExpressionFactory(nameof(__BuildWEBCOMPONENTSIP))]
        public IBodyWorkflowAction<HostComponentsResult> WEBCOMPONENTSIP([WorkflowExpression] Func<string> address, [WorkflowExpression] Func<int> size = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> before = null, [WorkflowExpression] Func<int> after = null, [WorkflowExpression] Func<int> beforeDay = null, [WorkflowExpression] Func<int> afterDay = null, [WorkflowExpression] Func<string> exact = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<HostComponentsResult> __BuildWEBCOMPONENTSIP(WorkflowValue<string> address, WorkflowValue<int> size = null, WorkflowValue<int> page = null, WorkflowValue<int> before = null, WorkflowValue<int> after = null, WorkflowValue<int> beforeDay = null, WorkflowValue<int> afterDay = null, WorkflowValue<string> exact = null)
        {
            WorkflowValue.Validate(address, nameof(address), required: true);
            WorkflowValue.Validate(size, nameof(size), required: false);
            WorkflowValue.Validate(page, nameof(page), required: false);
            WorkflowValue.Validate(before, nameof(before), required: false);
            WorkflowValue.Validate(after, nameof(after), required: false);
            WorkflowValue.Validate(beforeDay, nameof(beforeDay), required: false);
            WorkflowValue.Validate(afterDay, nameof(afterDay), required: false);
            WorkflowValue.Validate(exact, nameof(exact), required: false);
            return new DeferredBodyAction<HostComponentsResult>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v0/hostattributes/addresses/components/{0}", ExpressionConverter.ConvertWithUrlEncoding(address, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqintelligence")]
        [WorkflowExpressionFactory(nameof(__BuildCOOKIESHOST))]
        public IBodyWorkflowAction<HostCookieResult> COOKIESHOST([WorkflowExpression] Func<string> host, [WorkflowExpression] Func<int> size = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> before = null, [WorkflowExpression] Func<int> after = null, [WorkflowExpression] Func<int> beforeDay = null, [WorkflowExpression] Func<int> afterDay = null, [WorkflowExpression] Func<string> exact = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<HostCookieResult> __BuildCOOKIESHOST(WorkflowValue<string> host, WorkflowValue<int> size = null, WorkflowValue<int> page = null, WorkflowValue<int> before = null, WorkflowValue<int> after = null, WorkflowValue<int> beforeDay = null, WorkflowValue<int> afterDay = null, WorkflowValue<string> exact = null)
        {
            WorkflowValue.Validate(host, nameof(host), required: true);
            WorkflowValue.Validate(size, nameof(size), required: false);
            WorkflowValue.Validate(page, nameof(page), required: false);
            WorkflowValue.Validate(before, nameof(before), required: false);
            WorkflowValue.Validate(after, nameof(after), required: false);
            WorkflowValue.Validate(beforeDay, nameof(beforeDay), required: false);
            WorkflowValue.Validate(afterDay, nameof(afterDay), required: false);
            WorkflowValue.Validate(exact, nameof(exact), required: false);
            return new DeferredBodyAction<HostCookieResult>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v0/hostattributes/hosts/cookies/{0}", ExpressionConverter.ConvertWithUrlEncoding(host, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqintelligence")]
        [WorkflowExpressionFactory(nameof(__BuildCOOKIESIP))]
        public IBodyWorkflowAction<HostCookieResult> COOKIESIP([WorkflowExpression] Func<string> address, [WorkflowExpression] Func<int> size = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> before = null, [WorkflowExpression] Func<int> after = null, [WorkflowExpression] Func<int> beforeDay = null, [WorkflowExpression] Func<int> afterDay = null, [WorkflowExpression] Func<string> exact = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<HostCookieResult> __BuildCOOKIESIP(WorkflowValue<string> address, WorkflowValue<int> size = null, WorkflowValue<int> page = null, WorkflowValue<int> before = null, WorkflowValue<int> after = null, WorkflowValue<int> beforeDay = null, WorkflowValue<int> afterDay = null, WorkflowValue<string> exact = null)
        {
            WorkflowValue.Validate(address, nameof(address), required: true);
            WorkflowValue.Validate(size, nameof(size), required: false);
            WorkflowValue.Validate(page, nameof(page), required: false);
            WorkflowValue.Validate(before, nameof(before), required: false);
            WorkflowValue.Validate(after, nameof(after), required: false);
            WorkflowValue.Validate(beforeDay, nameof(beforeDay), required: false);
            WorkflowValue.Validate(afterDay, nameof(afterDay), required: false);
            WorkflowValue.Validate(exact, nameof(exact), required: false);
            return new DeferredBodyAction<HostCookieResult>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v0/hostattributes/addresses/cookies/{0}", ExpressionConverter.ConvertWithUrlEncoding(address, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqintelligence")]
        [WorkflowExpressionFactory(nameof(__BuildENRICHMENTHOST))]
        public IBodyWorkflowAction<JToken> ENRICHMENTHOST([WorkflowExpression] Func<string> host, [WorkflowExpression] Func<bool> whois = null, [WorkflowExpression] Func<bool> hostDetails = null, [WorkflowExpression] Func<bool> ipDetails = null, [WorkflowExpression] Func<bool> linkedAssetCounts = null, [WorkflowExpression] Func<bool> recentPDNS = null, [WorkflowExpression] Func<bool> subDomainPDNS = null, [WorkflowExpression] Func<bool> openPorts = null, [WorkflowExpression] Func<bool> certificates = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildENRICHMENTHOST(WorkflowValue<string> host, WorkflowValue<bool> whois = null, WorkflowValue<bool> hostDetails = null, WorkflowValue<bool> ipDetails = null, WorkflowValue<bool> linkedAssetCounts = null, WorkflowValue<bool> recentPDNS = null, WorkflowValue<bool> subDomainPDNS = null, WorkflowValue<bool> openPorts = null, WorkflowValue<bool> certificates = null)
        {
            WorkflowValue.Validate(host, nameof(host), required: true);
            WorkflowValue.Validate(whois, nameof(whois), required: false);
            WorkflowValue.Validate(hostDetails, nameof(hostDetails), required: false);
            WorkflowValue.Validate(ipDetails, nameof(ipDetails), required: false);
            WorkflowValue.Validate(linkedAssetCounts, nameof(linkedAssetCounts), required: false);
            WorkflowValue.Validate(recentPDNS, nameof(recentPDNS), required: false);
            WorkflowValue.Validate(subDomainPDNS, nameof(subDomainPDNS), required: false);
            WorkflowValue.Validate(openPorts, nameof(openPorts), required: false);
            WorkflowValue.Validate(certificates, nameof(certificates), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v0/enrich/host/{0}", ExpressionConverter.ConvertWithUrlEncoding(host, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqintelligence")]
        [WorkflowExpressionFactory(nameof(__BuildENRICHMENTIP))]
        public IBodyWorkflowAction<JToken> ENRICHMENTIP([WorkflowExpression] Func<string> ip, [WorkflowExpression] Func<bool> whois = null, [WorkflowExpression] Func<bool> hostDetails = null, [WorkflowExpression] Func<bool> linkedAssetCounts = null, [WorkflowExpression] Func<bool> openPorts = null, [WorkflowExpression] Func<bool> certificates = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildENRICHMENTIP(WorkflowValue<string> ip, WorkflowValue<bool> whois = null, WorkflowValue<bool> hostDetails = null, WorkflowValue<bool> linkedAssetCounts = null, WorkflowValue<bool> openPorts = null, WorkflowValue<bool> certificates = null)
        {
            WorkflowValue.Validate(ip, nameof(ip), required: true);
            WorkflowValue.Validate(whois, nameof(whois), required: false);
            WorkflowValue.Validate(hostDetails, nameof(hostDetails), required: false);
            WorkflowValue.Validate(linkedAssetCounts, nameof(linkedAssetCounts), required: false);
            WorkflowValue.Validate(openPorts, nameof(openPorts), required: false);
            WorkflowValue.Validate(certificates, nameof(certificates), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v0/enrich/ip/{0}", ExpressionConverter.ConvertWithUrlEncoding(ip, 1));
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
            });
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
