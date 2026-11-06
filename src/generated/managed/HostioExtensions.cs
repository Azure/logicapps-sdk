//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Hostio
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class HostioActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hostio")]
        public IBodyWorkflowAction<HomepageGetResponse, ApiConnectionActionConfiguration> HomepageGet(Expression<Func<string>> domain)
        {
            var __workflow_domain = WorkflowExpression.Compile(domain, nameof(domain), required: true);
            return new DeferredBodyAction<HomepageGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/web/{0}", __workflow_domain.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<HomepageGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hostio")]
        public IBodyWorkflowAction<DomainGetResponse, ApiConnectionActionConfiguration> DomainGet(Expression<Func<string>> domain)
        {
            var __workflow_domain = WorkflowExpression.Compile(domain, nameof(domain), required: true);
            return new DeferredBodyAction<DomainGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/dns/{0}", __workflow_domain.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<DomainGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hostio")]
        public IBodyWorkflowAction<RelatedGetResponse, ApiConnectionActionConfiguration> RelatedGet(Expression<Func<string>> domain)
        {
            var __workflow_domain = WorkflowExpression.Compile(domain, nameof(domain), required: true);
            return new DeferredBodyAction<RelatedGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/related/{0}", __workflow_domain.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<RelatedGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hostio")]
        public IBodyWorkflowAction<FullGetResponse, ApiConnectionActionConfiguration> FullGet(Expression<Func<string>> domain)
        {
            var __workflow_domain = WorkflowExpression.Compile(domain, nameof(domain), required: true);
            return new DeferredBodyAction<FullGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/full/{0}", __workflow_domain.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<FullGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hostio")]
        public IBodyWorkflowAction<FieldGetResponse, ApiConnectionActionConfiguration> FieldGet(Expression<Func<string>> field, Expression<Func<string>> value, Expression<Func<LimitInput>> limit = null)
        {
            var __workflow_field = WorkflowExpression.Compile(field, nameof(field), required: true);
            var __workflow_value = WorkflowExpression.Compile(value, nameof(value), required: true);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            return new DeferredBodyAction<FieldGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/domains/{0}/{1}", __workflow_field.WithUrlEncoding(1), __workflow_value.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["limit"] = Convert.ToString(25);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                return new ApiConnectionAction<FieldGetResponse>(callPayload);
            });
        }
    }

    public class HostioTriggers([ConnectionName] string connectionId)
    {
    }

    public class HomepageGetResponse
    {
        [JsonProperty("domain")]
        public string Domain { get; set; }

        [JsonProperty("rank")]
        public int Rank { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("ip")]
        public string Ip { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("length")]
        public int Length { get; set; }

        [JsonProperty("encoding")]
        public string Encoding { get; set; }

        [JsonProperty("copyright")]
        public string Copyright { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("links")]
        public string[] Links { get; set; }
    }

    public class DomainGetResponse
    {
        [JsonProperty("domain")]
        public string Domain { get; set; }

        [JsonProperty("a")]
        public string[] A { get; set; }

        [JsonProperty("aaaa")]
        public string[] Aaaa { get; set; }

        [JsonProperty("mx")]
        public string[] Mx { get; set; }

        [JsonProperty("ns")]
        public string[] Ns { get; set; }
    }

    public class RelatedGetResponse
    {
        [JsonProperty("ip")]
        public RelatedGetResponseIpTypeItem[] Ip { get; set; }

        [JsonProperty("redirects")]
        public RelatedGetResponseRedirectsTypeItem[] Redirects { get; set; }

        [JsonProperty("backlinks")]
        public RelatedGetResponseBacklinksTypeItem[] Backlinks { get; set; }

        [JsonProperty("asn")]
        public RelatedGetResponseAsnTypeItem[] Asn { get; set; }
    }

    public class RelatedGetResponseIpTypeItem
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }
    }

    public class RelatedGetResponseRedirectsTypeItem
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }
    }

    public class RelatedGetResponseBacklinksTypeItem
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }
    }

    public class RelatedGetResponseAsnTypeItem
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }
    }

    public class FullGetResponse
    {
        [JsonProperty("domain")]
        public string Domain { get; set; }

        [JsonProperty("web")]
        public FullGetResponseWebType Web { get; set; }

        [JsonProperty("dns")]
        public FullGetResponseDnsType Dns { get; set; }

        [JsonProperty("ipinfo")]
        public FullGetResponseIpinfoType Ipinfo { get; set; }

        [JsonProperty("related")]
        public FullGetResponseRelatedType Related { get; set; }
    }

    public class FullGetResponseWebType
    {
        [JsonProperty("domain")]
        public string Domain { get; set; }

        [JsonProperty("rank")]
        public int Rank { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("ip")]
        public string Ip { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("length")]
        public int Length { get; set; }

        [JsonProperty("encoding")]
        public string Encoding { get; set; }

        [JsonProperty("copyright")]
        public string Copyright { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("links")]
        public string[] Links { get; set; }
    }

    public class FullGetResponseDnsType
    {
        [JsonProperty("domain")]
        public string Domain { get; set; }

        [JsonProperty("a")]
        public string[] A { get; set; }

        [JsonProperty("aaaa")]
        public string[] Aaaa { get; set; }

        [JsonProperty("mx")]
        public string[] Mx { get; set; }

        [JsonProperty("ns")]
        public string[] Ns { get; set; }
    }

    public class FullGetResponseIpinfoType
    {
        [JsonProperty("ip_address")]
        public FullGetResponseIpinfoTypeIpAddressType IpAddress { get; set; }
    }

    public class FullGetResponseIpinfoTypeIpAddressType
    {
        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("loc")]
        public string Loc { get; set; }

        [JsonProperty("postal")]
        public string Postal { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("asn")]
        public FullGetResponseIpinfoTypeIpAddressTypeAsnType Asn { get; set; }
    }

    public class FullGetResponseIpinfoTypeIpAddressTypeAsnType
    {
        [JsonProperty("asn")]
        public string Asn { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("domain")]
        public string Domain { get; set; }

        [JsonProperty("route")]
        public string Route { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class FullGetResponseRelatedType
    {
        [JsonProperty("ip")]
        public FullGetResponseRelatedTypeIpTypeItem[] Ip { get; set; }

        [JsonProperty("asn")]
        public FullGetResponseRelatedTypeAsnTypeItem[] Asn { get; set; }

        [JsonProperty("ns")]
        public FullGetResponseRelatedTypeNsTypeItem[] Ns { get; set; }

        [JsonProperty("mx")]
        public FullGetResponseRelatedTypeMxTypeItem[] Mx { get; set; }

        [JsonProperty("backlinks")]
        public FullGetResponseRelatedTypeBacklinksTypeItem[] Backlinks { get; set; }

        [JsonProperty("redirects")]
        public FullGetResponseRelatedTypeRedirectsTypeItem[] Redirects { get; set; }
    }

    public class FullGetResponseRelatedTypeIpTypeItem
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }
    }

    public class FullGetResponseRelatedTypeAsnTypeItem
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }
    }

    public class FullGetResponseRelatedTypeNsTypeItem
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }
    }

    public class FullGetResponseRelatedTypeMxTypeItem
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }
    }

    public class FullGetResponseRelatedTypeBacklinksTypeItem
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }
    }

    public class FullGetResponseRelatedTypeRedirectsTypeItem
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }
    }

    public class FieldGetResponse
    {
        [JsonProperty("ns")]
        public string Ns { get; set; }

        [JsonProperty("page")]
        public int Page { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("domains")]
        public string[] Domains { get; set; }
    }

    public enum LimitInput
    {
        _25 = 25,
        _0 = 0,
        _1 = 1,
        _5 = 5,
        _10 = 10,
        _100 = 100,
        _250 = 250,
        _1000 = 1000
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Hostio;

    public partial class WorkflowManagedActions
    {
        public HostioActions Hostio(string connectionId) => new HostioActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public HostioTriggers Hostio(string connectionId) => new HostioTriggers(connectionId);
    }
}