//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Korto
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class KortoActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "korto")]
        public IBodyWorkflowAction<QueryTagsResponse> GetTag(Expression<Func<int>> tagID = null, Expression<Func<string>> tagName = null)
        {
            var __workflow_tagID = WorkflowExpression.Compile(tagID, nameof(tagID), required: false);
            var __workflow_tagName = WorkflowExpression.Compile(tagName, nameof(tagName), required: false);
            return new DeferredBodyAction<QueryTagsResponse>(() =>
            {
                var apiCallPath = "/Tag/v2";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_tagID != null)
                    callPayload.Queries["tagID"] = ExpressionConverter.Convert(__workflow_tagID);
                if (__workflow_tagName != null)
                    callPayload.Queries["tagName"] = ExpressionConverter.Convert(__workflow_tagName);
                return new ApiConnectionAction<QueryTagsResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "korto")]
        public IWorkflowAction DeleteTag(Expression<Func<int>> tagID = null, Expression<Func<string>> tagName = null)
        {
            var __workflow_tagID = WorkflowExpression.Compile(tagID, nameof(tagID), required: false);
            var __workflow_tagName = WorkflowExpression.Compile(tagName, nameof(tagName), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/Tag/v2";
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_tagID != null)
                    callPayload.Queries["tagID"] = ExpressionConverter.Convert(__workflow_tagID);
                if (__workflow_tagName != null)
                    callPayload.Queries["tagName"] = ExpressionConverter.Convert(__workflow_tagName);
                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "korto")]
        public IBodyWorkflowAction<QueryTagResponseItem> CreateTag(Expression<Func<string>> tagName = null, Expression<Func<int>> tagType = null, Expression<Func<int>> tagValueType = null)
        {
            var __workflow_tagName = WorkflowExpression.Compile(tagName, nameof(tagName), required: false);
            var __workflow_tagType = WorkflowExpression.Compile(tagType, nameof(tagType), required: false);
            var __workflow_tagValueType = WorkflowExpression.Compile(tagValueType, nameof(tagValueType), required: false);
            return new DeferredBodyAction<QueryTagResponseItem>(() =>
            {
                var apiCallPath = "/Tag/v2";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_tagName != null)
                    callPayload.Queries["tagName"] = ExpressionConverter.Convert(__workflow_tagName);
                callPayload.Queries["tagType"] = Convert.ToString(1);
                if (__workflow_tagType != null)
                    callPayload.Queries["tagType"] = ExpressionConverter.Convert(__workflow_tagType);
                if (__workflow_tagValueType != null)
                    callPayload.Queries["tagValueType"] = ExpressionConverter.Convert(__workflow_tagValueType);
                return new ApiConnectionAction<QueryTagResponseItem>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "korto")]
        public IBodyWorkflowAction<RecordQueryResponseItem> GetRecord(Expression<Func<int>> recordID = null, Expression<Func<string>> externalRecordID = null)
        {
            var __workflow_recordID = WorkflowExpression.Compile(recordID, nameof(recordID), required: false);
            var __workflow_externalRecordID = WorkflowExpression.Compile(externalRecordID, nameof(externalRecordID), required: false);
            return new DeferredBodyAction<RecordQueryResponseItem>(() =>
            {
                var apiCallPath = "/Record/v2";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_recordID != null)
                    callPayload.Queries["recordID"] = ExpressionConverter.Convert(__workflow_recordID);
                if (__workflow_externalRecordID != null)
                    callPayload.Queries["externalRecordID"] = ExpressionConverter.Convert(__workflow_externalRecordID);
                return new ApiConnectionAction<RecordQueryResponseItem>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "korto")]
        public IWorkflowAction DeleteRecord(Expression<Func<int>> recordID = null, Expression<Func<string>> externalRecordID = null)
        {
            var __workflow_recordID = WorkflowExpression.Compile(recordID, nameof(recordID), required: false);
            var __workflow_externalRecordID = WorkflowExpression.Compile(externalRecordID, nameof(externalRecordID), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/Record/v2";
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_recordID != null)
                    callPayload.Queries["recordID"] = ExpressionConverter.Convert(__workflow_recordID);
                if (__workflow_externalRecordID != null)
                    callPayload.Queries["externalRecordID"] = ExpressionConverter.Convert(__workflow_externalRecordID);
                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "korto")]
        public IBodyWorkflowAction<RecordQueryResponseItem> CreateRecord(Expression<Func<object>> file, Expression<Func<string>> name = null, Expression<Func<string>> actor = null, Expression<Func<string>> externalid = null, Expression<Func<string>> externalurl = null, Expression<Func<string>> createdAt = null, Expression<Func<string>> createdBy = null)
        {
            var __workflow_file = WorkflowExpression.Compile(file, nameof(file), required: true);
            var __workflow_name = WorkflowExpression.Compile(name, nameof(name), required: false);
            var __workflow_actor = WorkflowExpression.Compile(actor, nameof(actor), required: false);
            var __workflow_externalid = WorkflowExpression.Compile(externalid, nameof(externalid), required: false);
            var __workflow_externalurl = WorkflowExpression.Compile(externalurl, nameof(externalurl), required: false);
            var __workflow_createdAt = WorkflowExpression.Compile(createdAt, nameof(createdAt), required: false);
            var __workflow_createdBy = WorkflowExpression.Compile(createdBy, nameof(createdBy), required: false);
            return new DeferredBodyAction<RecordQueryResponseItem>(() =>
            {
                var apiCallPath = "/Record/v2";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_name != null)
                    callPayload.Queries["name"] = ExpressionConverter.Convert(__workflow_name);
                if (__workflow_actor != null)
                    callPayload.Queries["actor"] = ExpressionConverter.Convert(__workflow_actor);
                if (__workflow_externalid != null)
                    callPayload.Queries["externalid"] = ExpressionConverter.Convert(__workflow_externalid);
                if (__workflow_externalurl != null)
                    callPayload.Queries["externalurl"] = ExpressionConverter.Convert(__workflow_externalurl);
                if (__workflow_createdAt != null)
                    callPayload.Queries["createdAt"] = ExpressionConverter.Convert(__workflow_createdAt);
                if (__workflow_createdBy != null)
                    callPayload.Queries["createdBy"] = ExpressionConverter.Convert(__workflow_createdBy);
                return new ApiConnectionAction<RecordQueryResponseItem>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "korto")]
        public IBodyWorkflowAction<DownloadUrlMessage> DownloadRecord(Expression<Func<int>> recordID = null, Expression<Func<string>> externalRecordID = null)
        {
            var __workflow_recordID = WorkflowExpression.Compile(recordID, nameof(recordID), required: false);
            var __workflow_externalRecordID = WorkflowExpression.Compile(externalRecordID, nameof(externalRecordID), required: false);
            return new DeferredBodyAction<DownloadUrlMessage>(() =>
            {
                var apiCallPath = "/Record/v2/download";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_recordID != null)
                    callPayload.Queries["recordID"] = ExpressionConverter.Convert(__workflow_recordID);
                if (__workflow_externalRecordID != null)
                    callPayload.Queries["externalRecordID"] = ExpressionConverter.Convert(__workflow_externalRecordID);
                return new ApiConnectionAction<DownloadUrlMessage>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "korto")]
        public IWorkflowAction DeleteTagFromRecord(Expression<Func<int>> recordID = null, Expression<Func<string>> externalRecordID = null, Expression<Func<string>> tagName = null)
        {
            var __workflow_recordID = WorkflowExpression.Compile(recordID, nameof(recordID), required: false);
            var __workflow_externalRecordID = WorkflowExpression.Compile(externalRecordID, nameof(externalRecordID), required: false);
            var __workflow_tagName = WorkflowExpression.Compile(tagName, nameof(tagName), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/RecordTagValue/v2";
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_recordID != null)
                    callPayload.Queries["recordID"] = ExpressionConverter.Convert(__workflow_recordID);
                if (__workflow_externalRecordID != null)
                    callPayload.Queries["externalRecordID"] = ExpressionConverter.Convert(__workflow_externalRecordID);
                if (__workflow_tagName != null)
                    callPayload.Queries["tagName"] = ExpressionConverter.Convert(__workflow_tagName);
                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "korto")]
        public IBodyWorkflowAction<RecordQueryResponseItem> AddTagToRecord(Expression<Func<int>> recordID = null, Expression<Func<string>> externalRecordID = null, Expression<Func<string>> tagName = null, Expression<Func<string>> tagValue = null)
        {
            var __workflow_recordID = WorkflowExpression.Compile(recordID, nameof(recordID), required: false);
            var __workflow_externalRecordID = WorkflowExpression.Compile(externalRecordID, nameof(externalRecordID), required: false);
            var __workflow_tagName = WorkflowExpression.Compile(tagName, nameof(tagName), required: false);
            var __workflow_tagValue = WorkflowExpression.Compile(tagValue, nameof(tagValue), required: false);
            return new DeferredBodyAction<RecordQueryResponseItem>(() =>
            {
                var apiCallPath = "/RecordTagValue/v2";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_recordID != null)
                    callPayload.Queries["recordID"] = ExpressionConverter.Convert(__workflow_recordID);
                if (__workflow_externalRecordID != null)
                    callPayload.Queries["externalRecordID"] = ExpressionConverter.Convert(__workflow_externalRecordID);
                if (__workflow_tagName != null)
                    callPayload.Queries["tagName"] = ExpressionConverter.Convert(__workflow_tagName);
                if (__workflow_tagValue != null)
                    callPayload.Queries["tagValue"] = ExpressionConverter.Convert(__workflow_tagValue);
                return new ApiConnectionAction<RecordQueryResponseItem>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "korto")]
        public IBodyWorkflowAction<RecordQueryResponseItem> UpdateTagOnRecord(Expression<Func<int>> recordID = null, Expression<Func<string>> externalRecordID = null, Expression<Func<string>> tagName = null, Expression<Func<string>> tagValue = null)
        {
            var __workflow_recordID = WorkflowExpression.Compile(recordID, nameof(recordID), required: false);
            var __workflow_externalRecordID = WorkflowExpression.Compile(externalRecordID, nameof(externalRecordID), required: false);
            var __workflow_tagName = WorkflowExpression.Compile(tagName, nameof(tagName), required: false);
            var __workflow_tagValue = WorkflowExpression.Compile(tagValue, nameof(tagValue), required: false);
            return new DeferredBodyAction<RecordQueryResponseItem>(() =>
            {
                var apiCallPath = "/RecordTagValue/v2";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_recordID != null)
                    callPayload.Queries["recordID"] = ExpressionConverter.Convert(__workflow_recordID);
                if (__workflow_externalRecordID != null)
                    callPayload.Queries["externalRecordID"] = ExpressionConverter.Convert(__workflow_externalRecordID);
                if (__workflow_tagName != null)
                    callPayload.Queries["tagName"] = ExpressionConverter.Convert(__workflow_tagName);
                if (__workflow_tagValue != null)
                    callPayload.Queries["tagValue"] = ExpressionConverter.Convert(__workflow_tagValue);
                return new ApiConnectionAction<RecordQueryResponseItem>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }
    }

    public class KortoTriggers([ConnectionName] string connectionId)
    {
    }

    public class QueryTagsResponse
    {
        [JsonProperty("totalItems")]
        public int TotalItems { get; set; }

        [JsonProperty("data")]
        public QueryTagResponseItem[] Data { get; set; }
    }

    public class QueryTagResponseItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public int Type { get; set; }

        [JsonProperty("valueType")]
        public int ValueType { get; set; }

        [JsonProperty("synonymsCount")]
        public int SynonymsCount { get; set; }

        [JsonProperty("recordsCount")]
        public int RecordsCount { get; set; }

        [JsonProperty("synonymId")]
        public int SynonymId { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("isPredefined")]
        public bool IsPredefined { get; set; }

        [JsonProperty("isRequired")]
        public bool IsRequired { get; set; }

        [JsonProperty("additionalFormattingType")]
        public int AdditionalFormattingType { get; set; }

        [JsonProperty("isRelatedTag")]
        public bool IsRelatedTag { get; set; }
    }

    public class RecordQueryResponseItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("version")]
        public double Version { get; set; }

        [JsonProperty("versions")]
        public RecordVersion[] Versions { get; set; }

        [JsonProperty("tags")]
        public TagResponseMessage[] Tags { get; set; }

        [JsonProperty("actor")]
        public string Actor { get; set; }

        [JsonProperty("externalId")]
        public string ExternalId { get; set; }

        [JsonProperty("checksum")]
        public string Checksum { get; set; }

        [JsonProperty("downloadsCount")]
        public int DownloadsCount { get; set; }

        [JsonProperty("editCount")]
        public int EditCount { get; set; }

        [JsonProperty("createdBy")]
        public string CreatedBy { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }
    }

    public class RecordVersion
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("version")]
        public double Version { get; set; }

        [JsonProperty("actor")]
        public string Actor { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("createdBy")]
        public string CreatedBy { get; set; }

        [JsonProperty("externalId")]
        public string ExternalId { get; set; }
    }

    public class TagResponseMessage
    {
        [JsonProperty("stringValue")]
        public string StringValue { get; set; }

        [JsonProperty("intValue")]
        public int IntValue { get; set; }

        [JsonProperty("decimalValue")]
        public double DecimalValue { get; set; }

        [JsonProperty("dateTimeValue")]
        public string DateTimeValue { get; set; }

        [JsonProperty("boolValue")]
        public bool BoolValue { get; set; }

        [JsonProperty("valueType")]
        public int ValueType { get; set; }

        [JsonProperty("tagId")]
        public int TagId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public int Type { get; set; }

        [JsonProperty("retentionMonth")]
        public int RetentionMonth { get; set; }

        [JsonProperty("isPredefined")]
        public bool IsPredefined { get; set; }

        [JsonProperty("isRequired")]
        public bool IsRequired { get; set; }

        [JsonProperty("additionalFormattingType")]
        public int AdditionalFormattingType { get; set; }
    }

    public class DownloadUrlMessage
    {
        [JsonProperty("url")]
        public string Url { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Korto;

    public partial class WorkflowManagedActions
    {
        public KortoActions Korto(string connectionId) => new KortoActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public KortoTriggers Korto(string connectionId) => new KortoTriggers(connectionId);
    }
}
