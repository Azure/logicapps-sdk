//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Alertrelay
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AlertrelayActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "alertrelay")]
        public IBodyWorkflowAction<GetItemOrFileVersionHistoryResponse> GetItemOrFileVersionHistory([WorkflowExpression] Func<string> bodysiteURL, [WorkflowExpression] Func<string> bodylistOrLibrary, [WorkflowExpression] Func<int> bodyitemId, [WorkflowExpression] Func<int> bodymaximumUsageUnits, [WorkflowExpression] Func<int> bodymaximumVersions = null, [WorkflowExpression] Func<string[]> bodyfieldsToReturn = null, [WorkflowExpression] Func<string> bodycompareFrom = null, [WorkflowExpression] Func<string> bodycompareTo = null, [WorkflowExpression] Func<string> bodypagingToken = null, [WorkflowExpression] Func<bool> bodyincludeMinorVersions = null, [WorkflowExpression] Func<string> bodydateFormat = null, [WorkflowExpression] Func<string> bodytimeFormat = null, [WorkflowExpression] Func<string> bodytimezone = null)
        {
            SourceExpression.Validate(bodysiteURL, nameof(bodysiteURL), required: true);
            SourceExpression.Validate(bodylistOrLibrary, nameof(bodylistOrLibrary), required: true);
            SourceExpression.Validate(bodyitemId, nameof(bodyitemId), required: true);
            SourceExpression.Validate(bodymaximumUsageUnits, nameof(bodymaximumUsageUnits), required: true);
            SourceExpression.Validate(bodymaximumVersions, nameof(bodymaximumVersions), required: false);
            SourceExpression.Validate(bodyfieldsToReturn, nameof(bodyfieldsToReturn), required: false);
            SourceExpression.Validate(bodycompareFrom, nameof(bodycompareFrom), required: false);
            SourceExpression.Validate(bodycompareTo, nameof(bodycompareTo), required: false);
            SourceExpression.Validate(bodypagingToken, nameof(bodypagingToken), required: false);
            SourceExpression.Validate(bodyincludeMinorVersions, nameof(bodyincludeMinorVersions), required: false);
            SourceExpression.Validate(bodydateFormat, nameof(bodydateFormat), required: false);
            SourceExpression.Validate(bodytimeFormat, nameof(bodytimeFormat), required: false);
            SourceExpression.Validate(bodytimezone, nameof(bodytimezone), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/versionhistory";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["siteUrl"] = SourceExpressionConverter.ConvertToken(bodysiteURL);
                bodypropCount++;
                body["listId"] = SourceExpressionConverter.ConvertToken(bodylistOrLibrary);
                bodypropCount++;
                body["itemId"] = SourceExpressionConverter.ConvertToken(bodyitemId);
                bodypropCount++;
                body["maximumUsageUnits"] = SourceExpressionConverter.ConvertToken(bodymaximumUsageUnits);
                if (bodymaximumVersions != null)
                {
                    if (bodymaximumVersions != null)
                    {
                        body["maximumVersions"] = SourceExpressionConverter.ConvertToken(bodymaximumVersions);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["maximumVersions"] = 20;
                    bodypropCount++;
                }

                if (bodyfieldsToReturn != null)
                {
                    body["fieldsToReturn"] = SourceExpressionConverter.ConvertToken(bodyfieldsToReturn);
                    bodypropCount++;
                }

                if (bodycompareFrom != null)
                {
                    body["fromVersion"] = SourceExpressionConverter.ConvertToken(bodycompareFrom);
                    bodypropCount++;
                }

                if (bodycompareTo != null)
                {
                    body["toVersion"] = SourceExpressionConverter.ConvertToken(bodycompareTo);
                    bodypropCount++;
                }

                if (bodypagingToken != null)
                {
                    body["continuationToken"] = SourceExpressionConverter.ConvertToken(bodypagingToken);
                    bodypropCount++;
                }

                if (bodyincludeMinorVersions != null)
                {
                    if (bodyincludeMinorVersions != null)
                    {
                        body["includeMinorVersions"] = SourceExpressionConverter.ConvertToken(bodyincludeMinorVersions);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["includeMinorVersions"] = false;
                    bodypropCount++;
                }

                if (bodydateFormat != null)
                {
                    body["dateFormat"] = SourceExpressionConverter.ConvertToken(bodydateFormat);
                    bodypropCount++;
                }

                if (bodytimeFormat != null)
                {
                    body["timeFormat"] = SourceExpressionConverter.ConvertToken(bodytimeFormat);
                    bodypropCount++;
                }

                if (bodytimezone != null)
                {
                    body["timezone"] = SourceExpressionConverter.ConvertToken(bodytimezone);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<GetItemOrFileVersionHistoryResponse>(BuildSourceInput);
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
        public int ItemID { get; set; }

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