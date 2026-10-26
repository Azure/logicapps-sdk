//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Alertrelay
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AlertrelayActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "alertrelay")]
        public IBodyWorkflowAction<GetItemOrFileVersionHistoryResponse, ApiConnectionActionConfiguration> GetItemOrFileVersionHistory(Expression<Func<GetItemOrFileVersionHistoryInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<GetItemOrFileVersionHistoryResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/versionhistory";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<GetItemOrFileVersionHistoryResponse>(callPayload);
            });
        }
    }

    public class AlertrelayTriggers([ConnectionName] string connectionId)
    {
    }

    public class GetItemOrFileVersionHistoryResponse
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("itemId")]
        public int ItemId { get; set; }

        [JsonProperty("itemTitle")]
        public string ItemTitle { get; set; }

        [JsonProperty("versionsReturned")]
        public int VersionsReturned { get; set; }

        [JsonProperty("pageNumber")]
        public int PageNumber { get; set; }

        [JsonProperty("versionsReturnedTotal")]
        public int VersionsReturnedTotal { get; set; }

        [JsonProperty("fieldsReturned")]
        public int FieldsReturned { get; set; }

        [JsonProperty("usageUnitsCharged")]
        public int UsageUnitsCharged { get; set; }

        [JsonProperty("cumulativeUsageUnitsCharged")]
        public int CumulativeUsageUnitsCharged { get; set; }

        [JsonProperty("usageUnitLimit")]
        public int UsageUnitLimit { get; set; }

        [JsonProperty("hasMore")]
        public bool HasMore { get; set; }

        [JsonProperty("canContinue")]
        public bool CanContinue { get; set; }

        [JsonProperty("continuationToken")]
        public string PagingToken { get; set; }

        [JsonProperty("nextLink")]
        public string NextLink { get; set; }

        [JsonProperty("continuationExpiresAt")]
        public string PagingTokenExpiresAt { get; set; }

        [JsonProperty("truncationReason")]
        public string TruncationReason { get; set; }

        [JsonProperty("fromVersionResolution")]
        public string FromVersionResolution { get; set; }

        [JsonProperty("toVersionResolution")]
        public string ToVersionResolution { get; set; }

        [JsonProperty("resolvedFromVersionLabel")]
        public string ResolvedFromVersionLabel { get; set; }

        [JsonProperty("resolvedToVersionLabel")]
        public string ResolvedToVersionLabel { get; set; }

        [JsonProperty("errorCode")]
        public string ErrorCode { get; set; }

        [JsonProperty("minimumUsageUnitsRequired")]
        public int MinimumUsageUnitsRequired { get; set; }

        [JsonProperty("historyChangedDuringPaging")]
        public bool HistoryChangedDuringPaging { get; set; }

        [JsonProperty("shouldDisplayUserNotice")]
        public bool DisplayUserNotice { get; set; }

        [JsonProperty("userNoticeCode")]
        public string UserNoticeCode { get; set; }

        [JsonProperty("userNoticeSeverity")]
        public GetItemOrFileVersionHistoryResponseUserNoticeSeverityType UserNoticeSeverity { get; set; }

        [JsonProperty("userNotice")]
        public string UserNotice { get; set; }

        [JsonProperty("userNoticeCallToAction")]
        public string UserNoticeCallToAction { get; set; }

        [JsonProperty("value")]
        public GetItemOrFileVersionHistoryResponseVersionsTypeItem[] Versions { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GetItemOrFileVersionHistoryResponseUserNoticeSeverityType
    {
        [EnumMember(Value = "information")]
        Information,
        [EnumMember(Value = "warning")]
        Warning,
        [EnumMember(Value = "critical")]
        Critical
    }

    public class GetItemOrFileVersionHistoryResponseVersionsTypeItem
    {
        [JsonProperty("versionHistoryInfo")]
        public GetItemOrFileVersionHistoryResponseVersionsTypeItemVersionHistoryInformationType VersionHistoryInformation { get; set; }
    }

    public class GetItemOrFileVersionHistoryResponseVersionsTypeItemVersionHistoryInformationType
    {
        [JsonProperty("cumulativeUsageUnitsCharged")]
        public int CumulativeUsageUnitsCharged { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("hasMore")]
        public bool HasMore { get; set; }

        [JsonProperty("canContinue")]
        public bool CanContinue { get; set; }

        [JsonProperty("truncationReason")]
        public string TruncationReason { get; set; }

        [JsonProperty("continuationToken")]
        public string PagingToken { get; set; }

        [JsonProperty("continuationExpiresAt")]
        public string PagingTokenExpiresAt { get; set; }

        [JsonProperty("fromVersionResolution")]
        public string FromVersionResolution { get; set; }

        [JsonProperty("toVersionResolution")]
        public string ToVersionResolution { get; set; }

        [JsonProperty("historyChangedDuringPaging")]
        public bool HistoryChangedDuringPaging { get; set; }
    }

    public class GetItemOrFileVersionHistoryInput
    {
        [JsonProperty("siteUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SiteURL { get; set; }

        [JsonProperty("listId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ListOrLibrary { get; set; }

        [JsonProperty("itemId", DefaultValueHandling = DefaultValueHandling.Include)]
        public int ItemId { get; set; }

        [JsonProperty("maximumUsageUnits", DefaultValueHandling = DefaultValueHandling.Include)]
        public int MaximumUsageUnits { get; set; } = 1;

        [JsonProperty("maximumVersions", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaximumVersions { get; set; } = 20;

        [JsonProperty("fieldsToReturn")]
        public string[] FieldsToReturn { get; set; }

        [JsonProperty("fromVersion")]
        public string CompareFrom { get; set; }

        [JsonProperty("toVersion")]
        public string CompareTo { get; set; }

        [JsonProperty("continuationToken")]
        public string PagingToken { get; set; }

        [JsonProperty("includeMinorVersions", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? IncludeMinorVersions { get; set; } = false;

        [JsonProperty("dateFormat")]
        public string DateFormat { get; set; }

        [JsonProperty("timeFormat")]
        public string TimeFormat { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Alertrelay;

    public partial class WorkflowManagedActions
    {
        public AlertrelayActions Alertrelay(string connectionId) => new AlertrelayActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public AlertrelayTriggers Alertrelay(string connectionId) => new AlertrelayTriggers(connectionId);
    }
}