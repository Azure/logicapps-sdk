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
        public IBodyWorkflowAction<GetItemOrFileVersionHistoryResponse, ApiConnectionActionConfiguration> GetItemOrFileVersionHistory(Expression<Func<string>> bodysiteURL, Expression<Func<string>> bodylistOrLibrary, Expression<Func<int>> bodyitemId, Expression<Func<int>> bodymaximumUsageUnits, Expression<Func<int>> bodymaximumVersions = null, Expression<Func<string[]>> bodyfieldsToReturn = null, Expression<Func<string>> bodycompareFrom = null, Expression<Func<string>> bodycompareTo = null, Expression<Func<string>> bodypagingToken = null, Expression<Func<bool>> bodyincludeMinorVersions = null, Expression<Func<string>> bodydateFormat = null, Expression<Func<string>> bodytimeFormat = null, Expression<Func<string>> bodytimezone = null)
        {
            var __workflow_bodysiteURL = WorkflowExpression.Compile(bodysiteURL, nameof(bodysiteURL), required: true);
            var __workflow_bodylistOrLibrary = WorkflowExpression.Compile(bodylistOrLibrary, nameof(bodylistOrLibrary), required: true);
            var __workflow_bodyitemId = WorkflowExpression.Compile(bodyitemId, nameof(bodyitemId), required: true);
            var __workflow_bodymaximumUsageUnits = WorkflowExpression.Compile(bodymaximumUsageUnits, nameof(bodymaximumUsageUnits), required: true);
            var __workflow_bodymaximumVersions = WorkflowExpression.Compile(bodymaximumVersions, nameof(bodymaximumVersions), required: false);
            var __workflow_bodyfieldsToReturn = WorkflowExpression.Compile(bodyfieldsToReturn, nameof(bodyfieldsToReturn), required: false);
            var __workflow_bodycompareFrom = WorkflowExpression.Compile(bodycompareFrom, nameof(bodycompareFrom), required: false);
            var __workflow_bodycompareTo = WorkflowExpression.Compile(bodycompareTo, nameof(bodycompareTo), required: false);
            var __workflow_bodypagingToken = WorkflowExpression.Compile(bodypagingToken, nameof(bodypagingToken), required: false);
            var __workflow_bodyincludeMinorVersions = WorkflowExpression.Compile(bodyincludeMinorVersions, nameof(bodyincludeMinorVersions), required: false);
            var __workflow_bodydateFormat = WorkflowExpression.Compile(bodydateFormat, nameof(bodydateFormat), required: false);
            var __workflow_bodytimeFormat = WorkflowExpression.Compile(bodytimeFormat, nameof(bodytimeFormat), required: false);
            var __workflow_bodytimezone = WorkflowExpression.Compile(bodytimezone, nameof(bodytimezone), required: false);
            return new DeferredBodyAction<GetItemOrFileVersionHistoryResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/versionhistory";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["siteUrl"] = ExpressionConverter.ConvertO(__workflow_bodysiteURL);
                bodypropCount++;
                body["listId"] = ExpressionConverter.ConvertO(__workflow_bodylistOrLibrary);
                bodypropCount++;
                body["itemId"] = ExpressionConverter.ConvertO(__workflow_bodyitemId);
                bodypropCount++;
                body["maximumUsageUnits"] = ExpressionConverter.ConvertO(__workflow_bodymaximumUsageUnits);
                if (__workflow_bodymaximumVersions != null)
                {
                    if (__workflow_bodymaximumVersions != null)
                    {
                        body["maximumVersions"] = ExpressionConverter.ConvertO(__workflow_bodymaximumVersions);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["maximumVersions"] = 20;
                    bodypropCount++;
                }

                if (__workflow_bodyfieldsToReturn != null)
                {
                    body["fieldsToReturn"] = ExpressionConverter.ConvertO(__workflow_bodyfieldsToReturn);
                    bodypropCount++;
                }

                if (__workflow_bodycompareFrom != null)
                {
                    body["fromVersion"] = ExpressionConverter.ConvertO(__workflow_bodycompareFrom);
                    bodypropCount++;
                }

                if (__workflow_bodycompareTo != null)
                {
                    body["toVersion"] = ExpressionConverter.ConvertO(__workflow_bodycompareTo);
                    bodypropCount++;
                }

                if (__workflow_bodypagingToken != null)
                {
                    body["continuationToken"] = ExpressionConverter.ConvertO(__workflow_bodypagingToken);
                    bodypropCount++;
                }

                if (__workflow_bodyincludeMinorVersions != null)
                {
                    if (__workflow_bodyincludeMinorVersions != null)
                    {
                        body["includeMinorVersions"] = ExpressionConverter.ConvertO(__workflow_bodyincludeMinorVersions);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["includeMinorVersions"] = false;
                    bodypropCount++;
                }

                if (__workflow_bodydateFormat != null)
                {
                    body["dateFormat"] = ExpressionConverter.ConvertO(__workflow_bodydateFormat);
                    bodypropCount++;
                }

                if (__workflow_bodytimeFormat != null)
                {
                    body["timeFormat"] = ExpressionConverter.ConvertO(__workflow_bodytimeFormat);
                    bodypropCount++;
                }

                if (__workflow_bodytimezone != null)
                {
                    body["timezone"] = ExpressionConverter.ConvertO(__workflow_bodytimezone);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

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