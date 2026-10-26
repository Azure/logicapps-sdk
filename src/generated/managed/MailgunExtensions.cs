//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Mailgun
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class MailgunActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mailgun")]
        public IBodyWorkflowAction<GetDomainsResponse, ApiConnectionActionConfiguration> GetDomains(Expression<Func<int>> limit = null, Expression<Func<int>> skip = null, Expression<Func<string>> state = null, Expression<Func<string>> sort = null, Expression<Func<string>> authority = null, Expression<Func<string>> search = null, Expression<Func<bool>> includeSubaccounts = null)
        {
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_skip = WorkflowExpression.Compile(skip, nameof(skip), required: false);
            var __workflow_state = WorkflowExpression.Compile(state, nameof(state), required: false);
            var __workflow_sort = WorkflowExpression.Compile(sort, nameof(sort), required: false);
            var __workflow_authority = WorkflowExpression.Compile(authority, nameof(authority), required: false);
            var __workflow_search = WorkflowExpression.Compile(search, nameof(search), required: false);
            var __workflow_includeSubaccounts = WorkflowExpression.Compile(includeSubaccounts, nameof(includeSubaccounts), required: false);
            return new DeferredBodyAction<GetDomainsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/econexus/mailgun/v4/domains";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_skip != null)
                    callPayload.Queries["skip"] = ExpressionConverter.Convert(__workflow_skip);
                if (__workflow_state != null)
                    callPayload.Queries["state"] = ExpressionConverter.Convert(__workflow_state);
                if (__workflow_sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(__workflow_sort);
                if (__workflow_authority != null)
                    callPayload.Queries["authority"] = ExpressionConverter.Convert(__workflow_authority);
                if (__workflow_search != null)
                    callPayload.Queries["search"] = ExpressionConverter.Convert(__workflow_search);
                if (__workflow_includeSubaccounts != null)
                    callPayload.Queries["include_subaccounts"] = ExpressionConverter.Convert(__workflow_includeSubaccounts);
                return new ApiConnectionAction<GetDomainsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mailgun")]
        public IBodyWorkflowAction<GetDomainResponse, ApiConnectionActionConfiguration> GetDomain(Expression<Func<string>> name)
        {
            var __workflow_name = WorkflowExpression.Compile(name, nameof(name), required: true);
            return new DeferredBodyAction<GetDomainResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/econexus/mailgun/v4/domains/{0}", __workflow_name.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetDomainResponse>(callPayload);
            });
        }
    }

    public class MailgunTriggers([ConnectionName] string connectionId)
    {
    }

    public class GetDomainsResponse
    {
        [JsonProperty("total_count")]
        public int TotalCount { get; set; }

        [JsonProperty("items")]
        public GetDomainsResponseItemsTypeItem[] Items { get; set; }
    }

    public class GetDomainsResponseItemsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("is_disabled")]
        public bool IsDisabled { get; set; }

        [JsonProperty("require_tls")]
        public bool RequireTls { get; set; }

        [JsonProperty("skip_verification")]
        public bool SkipVerification { get; set; }

        [JsonProperty("smtp_login")]
        public string SmtpLogin { get; set; }

        [JsonProperty("smtp_password")]
        public string SmtpPassword { get; set; }

        [JsonProperty("spam_action")]
        public string SpamAction { get; set; }

        [JsonProperty("wildcard")]
        public bool Wildcard { get; set; }

        [JsonProperty("subaccount_id")]
        public string SubaccountId { get; set; }

        [JsonProperty("tracking_host")]
        public string TrackingHost { get; set; }

        [JsonProperty("use_automatic_sender_security")]
        public bool UseAutomaticSenderSecurity { get; set; }

        [JsonProperty("web_prefix")]
        public string WebPrefix { get; set; }

        [JsonProperty("web_scheme")]
        public string WebScheme { get; set; }

        [JsonProperty("archive_to")]
        public string ArchiveTo { get; set; }

        [JsonProperty("encrypt_incoming_message")]
        public bool EncryptIncomingMessage { get; set; }

        [JsonProperty("message_ttl")]
        public int MessageTtl { get; set; }
    }

    public class GetDomainResponse
    {
        [JsonProperty("domain")]
        public GetDomainResponseDomainType Domain { get; set; }

        [JsonProperty("receiving_dns_records")]
        public GetDomainResponseReceivingDnsRecordsTypeItem[] ReceivingDnsRecords { get; set; }

        [JsonProperty("sending_dns_records")]
        public GetDomainResponseSendingDnsRecordsTypeItem[] SendingDnsRecords { get; set; }
    }

    public class GetDomainResponseDomainType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("is_disabled")]
        public bool IsDisabled { get; set; }

        [JsonProperty("require_tls")]
        public bool RequireTls { get; set; }

        [JsonProperty("skip_verification")]
        public bool SkipVerification { get; set; }

        [JsonProperty("smtp_login")]
        public string SmtpLogin { get; set; }

        [JsonProperty("smtp_password")]
        public string SmtpPassword { get; set; }

        [JsonProperty("spam_action")]
        public string SpamAction { get; set; }

        [JsonProperty("wildcard")]
        public bool Wildcard { get; set; }

        [JsonProperty("subaccount_id")]
        public string SubaccountId { get; set; }

        [JsonProperty("tracking_host")]
        public string TrackingHost { get; set; }

        [JsonProperty("use_automatic_sender_security")]
        public bool UseAutomaticSenderSecurity { get; set; }

        [JsonProperty("web_prefix")]
        public string WebPrefix { get; set; }

        [JsonProperty("web_scheme")]
        public string WebScheme { get; set; }

        [JsonProperty("archive_to")]
        public string ArchiveTo { get; set; }

        [JsonProperty("encrypt_incoming_message")]
        public bool EncryptIncomingMessage { get; set; }

        [JsonProperty("message_ttl")]
        public int MessageTtl { get; set; }
    }

    public class GetDomainResponseReceivingDnsRecordsTypeItem
    {
        [JsonProperty("is_active")]
        public bool IsActive { get; set; }

        [JsonProperty("cached")]
        public string[] Cached { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("priority")]
        public string Priority { get; set; }

        [JsonProperty("record_type")]
        public string RecordType { get; set; }

        [JsonProperty("valid")]
        public string Valid { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class GetDomainResponseSendingDnsRecordsTypeItem
    {
        [JsonProperty("is_active")]
        public bool IsActive { get; set; }

        [JsonProperty("cached")]
        public string[] Cached { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("priority")]
        public string Priority { get; set; }

        [JsonProperty("record_type")]
        public string RecordType { get; set; }

        [JsonProperty("valid")]
        public string Valid { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Mailgun;

    public partial class WorkflowManagedActions
    {
        public MailgunActions Mailgun(string connectionId) => new MailgunActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public MailgunTriggers Mailgun(string connectionId) => new MailgunTriggers(connectionId);
    }
}