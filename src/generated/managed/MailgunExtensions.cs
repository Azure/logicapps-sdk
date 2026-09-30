//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Mailgun
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class MailgunActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mailgun")]
        public IBodyWorkflowAction<GetDomainsResponse> GetDomains([WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> skip = null, [WorkflowExpression] Func<string> state = null, [WorkflowExpression] Func<string> sort = null, [WorkflowExpression] Func<string> authority = null, [WorkflowExpression] Func<string> search = null, [WorkflowExpression] Func<bool> includeSubaccounts = null)
        {
            SourceExpression.Validate(limit, nameof(limit), required: false);
            SourceExpression.Validate(skip, nameof(skip), required: false);
            SourceExpression.Validate(state, nameof(state), required: false);
            SourceExpression.Validate(sort, nameof(sort), required: false);
            SourceExpression.Validate(authority, nameof(authority), required: false);
            SourceExpression.Validate(search, nameof(search), required: false);
            SourceExpression.Validate(includeSubaccounts, nameof(includeSubaccounts), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/econexus/mailgun/v4/domains";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (skip != null)
                    callPayload.Queries["skip"] = SourceExpressionConverter.ConvertO(skip);
                if (state != null)
                    callPayload.Queries["state"] = SourceExpressionConverter.ConvertO(state);
                if (sort != null)
                    callPayload.Queries["sort"] = SourceExpressionConverter.ConvertO(sort);
                if (authority != null)
                    callPayload.Queries["authority"] = SourceExpressionConverter.ConvertO(authority);
                if (search != null)
                    callPayload.Queries["search"] = SourceExpressionConverter.ConvertO(search);
                if (includeSubaccounts != null)
                    callPayload.Queries["include_subaccounts"] = SourceExpressionConverter.ConvertO(includeSubaccounts);
                return callPayload;
            }

            return new ApiConnectionAction<GetDomainsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mailgun")]
        public IBodyWorkflowAction<GetDomainResponse> GetDomain([WorkflowExpression] Func<string> name)
        {
            SourceExpression.Validate(name, nameof(name), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/econexus/mailgun/v4/domains/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(name, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetDomainResponse>(BuildSourceInput);
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