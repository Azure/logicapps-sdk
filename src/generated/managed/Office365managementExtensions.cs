//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Office365management
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class Office365managementActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365management")]
        public IBodyWorkflowAction<ContentDetails[]> ListContentDetails(Expression<Func<string>> tenant, Expression<Func<string>> contentId)
        {
            var apiCallPath = String.Format("/api/v1.0/{0}/activity/feed/audit/{1}", ExpressionConverter.ConvertWithUrlEncoding(tenant, 1), ExpressionConverter.ConvertWithUrlEncoding(contentId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ContentDetails[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365management")]
        public IBodyWorkflowAction<ContentCluster[]> ListContentClusters(Expression<Func<string>> tenant, Expression<Func<string>> publisherIdentifier, Expression<Func<contentTypeInput>> contentType = null, Expression<Func<string>> contentType = null, Expression<Func<string>> startTime = null, Expression<Func<string>> endTime = null)
        {
            var apiCallPath = String.Format("/api/v1.0/{0}/activity/feed/subscriptions/content", ExpressionConverter.ConvertWithUrlEncoding(tenant, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["contentType"] = Convert.ToString("Audit.General");
            if (contentType != null)
                callPayload.Queries["contentType"] = ExpressionConverter.Convert(contentType);
            callPayload.Queries["PublisherIdentifier"] = ExpressionConverter.Convert(publisherIdentifier);
            if (startTime != null)
                callPayload.Queries["startTime"] = ExpressionConverter.Convert(startTime);
            if (endTime != null)
                callPayload.Queries["endTime"] = ExpressionConverter.Convert(endTime);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json; utf-8");
            if (contentType != null)
                callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(contentType);
            return new ApiConnectionAction<ContentCluster[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365management")]
        public IBodyWorkflowAction<Subscription[]> ListSubscriptions(Expression<Func<string>> tenant)
        {
            var apiCallPath = String.Format("/api/v1.0/{0}/activity/feed/subscriptions/list", ExpressionConverter.ConvertWithUrlEncoding(tenant, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<Subscription[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365management")]
        public IBodyWorkflowAction<string> StopSubscription(Expression<Func<string>> tenant, Expression<Func<string>> publisherIdentifier, Expression<Func<string>> contentType = null)
        {
            var apiCallPath = String.Format("/api/v1.0/{0}/activity/feed/subscriptions/stop", ExpressionConverter.ConvertWithUrlEncoding(tenant, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["PublisherIdentifier"] = ExpressionConverter.Convert(publisherIdentifier);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json; utf-8");
            if (contentType != null)
                callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(contentType);
            return new ApiConnectionAction<string>(callPayload);
        }
    }

    public class Office365managementTriggers([ConnectionName] string connectionId)
    {
    }

    public class ContentDetails
    {
        public string AdditionalInfo { get; set; }
        public string AppName { get; set; }
        public string ClientIP { get; set; }
        public string CorrelationId { get; set; }
        public string CreationTime { get; set; }
        public string CrmOrganizationUniqueName { get; set; }
        public string EntityId { get; set; }
        public string EntityName { get; set; }
        public string Id { get; set; }
        public string InstanceUrl { get; set; }
        public string ItemType { get; set; }
        public string ItemUrl { get; set; }
        public string Message { get; set; }
        public string ObjectId { get; set; }
        public string Operation { get; set; }
        public string OrganizationId { get; set; }
        public string PrimaryFieldValue { get; set; }
        public string Query { get; set; }
        public string QueryResults { get; set; }
        public int RecordType { get; set; }
        public string ResultStatus { get; set; }
        public string ServiceContextId { get; set; }
        public string ServiceContextIdType { get; set; }
        public string ServiceName { get; set; }
        public string SystemUserId { get; set; }
        public string UserAgent { get; set; }
        public string UserId { get; set; }
        public string UserKey { get; set; }
        public int UserType { get; set; }
        public string UserUpn { get; set; }
        public int Version { get; set; }
        public string Workload { get; set; }
    }

    public class ContentCluster
    {
        [JsonProperty("contentCreated")]
        public string ContentCreated { get; set; }

        [JsonProperty("contentExpiration")]
        public string ContentExpiration { get; set; }

        [JsonProperty("contentId")]
        public string ContentId { get; set; }

        [JsonProperty("contentType")]
        public string ContentType { get; set; }

        [JsonProperty("contentUri")]
        public string ContentUri { get; set; }
    }

    public enum contentTypeInput
    {
        [EnumMember(Value = "Audit.AzureActiveDirectory")]
        AuditAzureActiveDirectory,
        [EnumMember(Value = "Audit.Exchange")]
        AuditExchange,
        [EnumMember(Value = "Audit.SharePoint")]
        AuditSharePoint,
        [EnumMember(Value = "Audit.General")]
        AuditGeneral,
        [EnumMember(Value = "DLP.All")]
        DLPAll
    }

    public class Subscription
    {
        [JsonProperty("contentType")]
        public string ContentType { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("webhook")]
        public SubscriptionWebhookType Webhook { get; set; }
    }

    public class SubscriptionWebhookType
    {
        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("authId")]
        public string AuthId { get; set; }

        [JsonProperty("expiration")]
        public string Expiration { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Office365management;

    public partial class WorkflowManagedActions
    {
        public Office365managementActions Office365management(string connectionId) => new Office365managementActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public Office365managementTriggers Office365management(string connectionId) => new Office365managementTriggers(connectionId);
    }
}