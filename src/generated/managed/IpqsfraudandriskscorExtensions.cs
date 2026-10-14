//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Ipqsfraudandriskscor
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class IpqsfraudandriskscorActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ipqsfraudandriskscor")]
        public IBodyWorkflowAction<IPREPUTATIONResponse> IPREPUTATION(Expression<Func<string>> ip, Expression<Func<strictnessInput>> strictness, Expression<Func<string>> userAgent = null, Expression<Func<string>> userLanguage = null, Expression<Func<bool>> fast = null, Expression<Func<bool>> mobile = null, Expression<Func<bool>> allowPublicAccessPoints = null, Expression<Func<bool>> lighterPenalties = null)
        {
            var __workflow_ip = ip == null ? null : WorkflowExpression.Compile(ip);
            WorkflowExpression.Validate(__workflow_ip, nameof(ip), required: true);
            var __workflow_strictness = strictness == null ? null : WorkflowExpression.Compile(strictness);
            WorkflowExpression.Validate(__workflow_strictness, nameof(strictness), required: true);
            var __workflow_userAgent = userAgent == null ? null : WorkflowExpression.Compile(userAgent);
            WorkflowExpression.Validate(__workflow_userAgent, nameof(userAgent), required: false);
            var __workflow_userLanguage = userLanguage == null ? null : WorkflowExpression.Compile(userLanguage);
            WorkflowExpression.Validate(__workflow_userLanguage, nameof(userLanguage), required: false);
            var __workflow_fast = fast == null ? null : WorkflowExpression.Compile(fast);
            WorkflowExpression.Validate(__workflow_fast, nameof(fast), required: false);
            var __workflow_mobile = mobile == null ? null : WorkflowExpression.Compile(mobile);
            WorkflowExpression.Validate(__workflow_mobile, nameof(mobile), required: false);
            var __workflow_allowPublicAccessPoints = allowPublicAccessPoints == null ? null : WorkflowExpression.Compile(allowPublicAccessPoints);
            WorkflowExpression.Validate(__workflow_allowPublicAccessPoints, nameof(allowPublicAccessPoints), required: false);
            var __workflow_lighterPenalties = lighterPenalties == null ? null : WorkflowExpression.Compile(lighterPenalties);
            WorkflowExpression.Validate(__workflow_lighterPenalties, nameof(lighterPenalties), required: false);
            return new DeferredBodyAction<IPREPUTATIONResponse>(() =>
            {
                var apiCallPath = "/ip";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<IPREPUTATIONResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ipqsfraudandriskscor")]
        public IBodyWorkflowAction<EMAILREPUTATIONResponse> EMAILREPUTATION(Expression<Func<string>> email, Expression<Func<abuseStrictnessInput>> abuseStrictness, Expression<Func<bool>> fast = null, Expression<Func<int>> timeout = null, Expression<Func<bool>> suggestDomain = null)
        {
            var __workflow_email = email == null ? null : WorkflowExpression.Compile(email);
            WorkflowExpression.Validate(__workflow_email, nameof(email), required: true);
            var __workflow_abuseStrictness = abuseStrictness == null ? null : WorkflowExpression.Compile(abuseStrictness);
            WorkflowExpression.Validate(__workflow_abuseStrictness, nameof(abuseStrictness), required: true);
            var __workflow_fast = fast == null ? null : WorkflowExpression.Compile(fast);
            WorkflowExpression.Validate(__workflow_fast, nameof(fast), required: false);
            var __workflow_timeout = timeout == null ? null : WorkflowExpression.Compile(timeout);
            WorkflowExpression.Validate(__workflow_timeout, nameof(timeout), required: false);
            var __workflow_suggestDomain = suggestDomain == null ? null : WorkflowExpression.Compile(suggestDomain);
            WorkflowExpression.Validate(__workflow_suggestDomain, nameof(suggestDomain), required: false);
            return new DeferredBodyAction<EMAILREPUTATIONResponse>(() =>
            {
                var apiCallPath = "/email";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<EMAILREPUTATIONResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ipqsfraudandriskscor")]
        public IBodyWorkflowAction<URLREPUTATIONResponse> URLREPUTATION(Expression<Func<string>> url, Expression<Func<strictnessInput>> strictness, Expression<Func<bool>> fast = null)
        {
            var __workflow_url = url == null ? null : WorkflowExpression.Compile(url);
            WorkflowExpression.Validate(__workflow_url, nameof(url), required: true);
            var __workflow_strictness = strictness == null ? null : WorkflowExpression.Compile(strictness);
            WorkflowExpression.Validate(__workflow_strictness, nameof(strictness), required: true);
            var __workflow_fast = fast == null ? null : WorkflowExpression.Compile(fast);
            WorkflowExpression.Validate(__workflow_fast, nameof(fast), required: false);
            return new DeferredBodyAction<URLREPUTATIONResponse>(() =>
            {
                var apiCallPath = "/url";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<URLREPUTATIONResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ipqsfraudandriskscor")]
        public IBodyWorkflowAction<PHONEREPUTATIONResponse> PHONEREPUTATION(Expression<Func<string>> phone, Expression<Func<strictnessInput>> strictness, Expression<Func<string>> country = null)
        {
            var __workflow_phone = phone == null ? null : WorkflowExpression.Compile(phone);
            WorkflowExpression.Validate(__workflow_phone, nameof(phone), required: true);
            var __workflow_strictness = strictness == null ? null : WorkflowExpression.Compile(strictness);
            WorkflowExpression.Validate(__workflow_strictness, nameof(strictness), required: true);
            var __workflow_country = country == null ? null : WorkflowExpression.Compile(country);
            WorkflowExpression.Validate(__workflow_country, nameof(country), required: false);
            return new DeferredBodyAction<PHONEREPUTATIONResponse>(() =>
            {
                var apiCallPath = "/phone";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<PHONEREPUTATIONResponse>(callPayload);
            });
        }
    }

    public class IpqsfraudandriskscorTriggers([ConnectionName] string connectionId)
    {
    }

    public class IPREPUTATIONResponse
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("fraud_score")]
        public int FraudScore { get; set; }

        [JsonProperty("country_code")]
        public string CountryCode { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }
        public string ISP { get; set; }
        public int ASN { get; set; }
        public string Organization { get; set; }

        [JsonProperty("is_crawler")]
        public bool IsCrawler { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("mobile")]
        public bool Mobile { get; set; }

        [JsonProperty("host")]
        public string Host { get; set; }

        [JsonProperty("proxy")]
        public bool Proxy { get; set; }

        [JsonProperty("vpn")]
        public bool Vpn { get; set; }

        [JsonProperty("tor")]
        public bool Tor { get; set; }

        [JsonProperty("active_vpn")]
        public bool ActiveVpn { get; set; }

        [JsonProperty("active_tor")]
        public bool ActiveTor { get; set; }

        [JsonProperty("recent_abuse")]
        public bool RecentAbuse { get; set; }

        [JsonProperty("bot_status")]
        public bool BotStatus { get; set; }

        [JsonProperty("connection_type")]
        public string ConnectionType { get; set; }

        [JsonProperty("abuse_velocity")]
        public string AbuseVelocity { get; set; }

        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        [JsonProperty("longitude")]
        public double Longitude { get; set; }

        [JsonProperty("request_id")]
        public string RequestId { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum strictnessInput
    {
        [EnumMember(Value = "0")]
        _0,
        [EnumMember(Value = "1")]
        _1,
        [EnumMember(Value = "2")]
        _2
    }

    public class EMAILREPUTATIONResponse
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("valid")]
        public bool Valid { get; set; }

        [JsonProperty("disposable")]
        public bool Disposable { get; set; }

        [JsonProperty("smtp_score")]
        public int SmtpScore { get; set; }

        [JsonProperty("overall_score")]
        public int OverallScore { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("generic")]
        public bool Generic { get; set; }

        [JsonProperty("common")]
        public bool Common { get; set; }

        [JsonProperty("dns_valid")]
        public bool DnsValid { get; set; }

        [JsonProperty("honeypot")]
        public bool Honeypot { get; set; }

        [JsonProperty("deliverability")]
        public string Deliverability { get; set; }

        [JsonProperty("frequent_complainer")]
        public bool FrequentComplainer { get; set; }

        [JsonProperty("spam_trap_score")]
        public string SpamTrapScore { get; set; }

        [JsonProperty("catch_all")]
        public bool CatchAll { get; set; }

        [JsonProperty("timed_out")]
        public bool TimedOut { get; set; }

        [JsonProperty("suspect")]
        public bool Suspect { get; set; }

        [JsonProperty("recent_abuse")]
        public bool RecentAbuse { get; set; }

        [JsonProperty("fraud_score")]
        public int FraudScore { get; set; }

        [JsonProperty("suggested_domain")]
        public string SuggestedDomain { get; set; }

        [JsonProperty("leaked")]
        public bool Leaked { get; set; }

        [JsonProperty("domain_age")]
        public EMAILREPUTATIONResponseDomainAgeType DomainAge { get; set; }

        [JsonProperty("first_seen")]
        public EMAILREPUTATIONResponseFirstSeenType FirstSeen { get; set; }

        [JsonProperty("sanitized_email")]
        public string SanitizedEmail { get; set; }

        [JsonProperty("request_id")]
        public string RequestId { get; set; }
    }

    public class EMAILREPUTATIONResponseDomainAgeType
    {
        [JsonProperty("human")]
        public string Human { get; set; }

        [JsonProperty("timestamp")]
        public int Timestamp { get; set; }

        [JsonProperty("iso")]
        public string Iso { get; set; }
    }

    public class EMAILREPUTATIONResponseFirstSeenType
    {
        [JsonProperty("human")]
        public string Human { get; set; }

        [JsonProperty("timestamp")]
        public int Timestamp { get; set; }

        [JsonProperty("iso")]
        public string Iso { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum abuseStrictnessInput
    {
        [EnumMember(Value = "0")]
        _0,
        [EnumMember(Value = "1")]
        _1,
        [EnumMember(Value = "2")]
        _2
    }

    public class URLREPUTATIONResponse
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("unsafe")]
        public bool Unsafe { get; set; }

        [JsonProperty("domain")]
        public string Domain { get; set; }

        [JsonProperty("server")]
        public string Server { get; set; }

        [JsonProperty("content_type")]
        public string ContentType { get; set; }

        [JsonProperty("status_code")]
        public int StatusCode { get; set; }

        [JsonProperty("page_size")]
        public int PageSize { get; set; }

        [JsonProperty("domain_rank")]
        public int DomainRank { get; set; }

        [JsonProperty("dns_valid")]
        public bool DnsValid { get; set; }

        [JsonProperty("parking")]
        public bool Parking { get; set; }

        [JsonProperty("spamming")]
        public bool Spamming { get; set; }

        [JsonProperty("malware")]
        public bool Malware { get; set; }

        [JsonProperty("phishing")]
        public bool Phishing { get; set; }

        [JsonProperty("suspicious")]
        public bool Suspicious { get; set; }

        [JsonProperty("adult")]
        public bool Adult { get; set; }

        [JsonProperty("risk_score")]
        public int RiskScore { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("domain_age")]
        public URLREPUTATIONResponseDomainAgeType DomainAge { get; set; }

        [JsonProperty("request_id")]
        public string RequestId { get; set; }
    }

    public class URLREPUTATIONResponseDomainAgeType
    {
        [JsonProperty("human")]
        public string Human { get; set; }

        [JsonProperty("timestamp")]
        public int Timestamp { get; set; }

        [JsonProperty("iso")]
        public string Iso { get; set; }
    }

    public class PHONEREPUTATIONResponse
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("formatted")]
        public string Formatted { get; set; }

        [JsonProperty("local_format")]
        public string LocalFormat { get; set; }

        [JsonProperty("valid")]
        public bool Valid { get; set; }

        [JsonProperty("fraud_score")]
        public int FraudScore { get; set; }

        [JsonProperty("recent_abuse")]
        public bool RecentAbuse { get; set; }
        public bool VOIP { get; set; }

        [JsonProperty("prepaid")]
        public bool Prepaid { get; set; }

        [JsonProperty("risky")]
        public bool Risky { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("carrier")]
        public string Carrier { get; set; }

        [JsonProperty("line_type")]
        public string LineType { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("zip_code")]
        public string ZipCode { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("dialing_code")]
        public int DialingCode { get; set; }

        [JsonProperty("request_id")]
        public string RequestId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("do_not_call")]
        public bool DoNotCall { get; set; }

        [JsonProperty("active_status")]
        public string ActiveStatus { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Ipqsfraudandriskscor;

    public partial class WorkflowManagedActions
    {
        public IpqsfraudandriskscorActions Ipqsfraudandriskscor(string connectionId) => new IpqsfraudandriskscorActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public IpqsfraudandriskscorTriggers Ipqsfraudandriskscor(string connectionId) => new IpqsfraudandriskscorTriggers(connectionId);
    }
}
