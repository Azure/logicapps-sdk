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
        public IBodyWorkflowAction<QueryTagsResponse, ApiConnectionActionConfiguration> GetTag(Expression<Func<int>> tagId = null, Expression<Func<string>> tagName = null)
        {
            var __workflow_tagId = WorkflowExpression.Compile(tagId, nameof(tagId), required: false);
            var __workflow_tagName = WorkflowExpression.Compile(tagName, nameof(tagName), required: false);
            return new DeferredBodyAction<QueryTagsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Tag/v2";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_tagId != null)
                    callPayload.Queries["tagID"] = ExpressionConverter.Convert(__workflow_tagId);
                if (__workflow_tagName != null)
                    callPayload.Queries["tagName"] = ExpressionConverter.Convert(__workflow_tagName);
                return new ApiConnectionAction<QueryTagsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "korto")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteTag(Expression<Func<int>> tagId = null, Expression<Func<string>> tagName = null)
        {
            var __workflow_tagId = WorkflowExpression.Compile(tagId, nameof(tagId), required: false);
            var __workflow_tagName = WorkflowExpression.Compile(tagName, nameof(tagName), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Tag/v2";
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_tagId != null)
                    callPayload.Queries["tagID"] = ExpressionConverter.Convert(__workflow_tagId);
                if (__workflow_tagName != null)
                    callPayload.Queries["tagName"] = ExpressionConverter.Convert(__workflow_tagName);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "korto")]
        public IBodyWorkflowAction<QueryTagResponseItem, ApiConnectionActionConfiguration> CreateTag(Expression<Func<string>> tagName = null, Expression<Func<int>> tagType = null, Expression<Func<int>> tagValueType = null)
        {
            var __workflow_tagName = WorkflowExpression.Compile(tagName, nameof(tagName), required: false);
            var __workflow_tagType = WorkflowExpression.Compile(tagType, nameof(tagType), required: false);
            var __workflow_tagValueType = WorkflowExpression.Compile(tagValueType, nameof(tagValueType), required: false);
            return new DeferredBodyAction<QueryTagResponseItem, ApiConnectionActionConfiguration>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "korto")]
        public IBodyWorkflowAction<RecordQueryResponseItem, ApiConnectionActionConfiguration> GetRecord(Expression<Func<int>> recordId = null, Expression<Func<string>> externalRecordId = null)
        {
            var __workflow_recordId = WorkflowExpression.Compile(recordId, nameof(recordId), required: false);
            var __workflow_externalRecordId = WorkflowExpression.Compile(externalRecordId, nameof(externalRecordId), required: false);
            return new DeferredBodyAction<RecordQueryResponseItem, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Record/v2";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_recordId != null)
                    callPayload.Queries["recordID"] = ExpressionConverter.Convert(__workflow_recordId);
                if (__workflow_externalRecordId != null)
                    callPayload.Queries["externalRecordID"] = ExpressionConverter.Convert(__workflow_externalRecordId);
                return new ApiConnectionAction<RecordQueryResponseItem>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "korto")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteRecord(Expression<Func<int>> recordId = null, Expression<Func<string>> externalRecordId = null)
        {
            var __workflow_recordId = WorkflowExpression.Compile(recordId, nameof(recordId), required: false);
            var __workflow_externalRecordId = WorkflowExpression.Compile(externalRecordId, nameof(externalRecordId), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Record/v2";
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_recordId != null)
                    callPayload.Queries["recordID"] = ExpressionConverter.Convert(__workflow_recordId);
                if (__workflow_externalRecordId != null)
                    callPayload.Queries["externalRecordID"] = ExpressionConverter.Convert(__workflow_externalRecordId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "korto")]
        public IBodyWorkflowAction<DownloadUrlMessage, ApiConnectionActionConfiguration> DownloadRecord(Expression<Func<int>> recordId = null, Expression<Func<string>> externalRecordId = null)
        {
            var __workflow_recordId = WorkflowExpression.Compile(recordId, nameof(recordId), required: false);
            var __workflow_externalRecordId = WorkflowExpression.Compile(externalRecordId, nameof(externalRecordId), required: false);
            return new DeferredBodyAction<DownloadUrlMessage, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Record/v2/download";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_recordId != null)
                    callPayload.Queries["recordID"] = ExpressionConverter.Convert(__workflow_recordId);
                if (__workflow_externalRecordId != null)
                    callPayload.Queries["externalRecordID"] = ExpressionConverter.Convert(__workflow_externalRecordId);
                return new ApiConnectionAction<DownloadUrlMessage>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "korto")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteTagFromRecord(Expression<Func<int>> recordId = null, Expression<Func<string>> externalRecordId = null, Expression<Func<string>> tagName = null)
        {
            var __workflow_recordId = WorkflowExpression.Compile(recordId, nameof(recordId), required: false);
            var __workflow_externalRecordId = WorkflowExpression.Compile(externalRecordId, nameof(externalRecordId), required: false);
            var __workflow_tagName = WorkflowExpression.Compile(tagName, nameof(tagName), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/RecordTagValue/v2";
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_recordId != null)
                    callPayload.Queries["recordID"] = ExpressionConverter.Convert(__workflow_recordId);
                if (__workflow_externalRecordId != null)
                    callPayload.Queries["externalRecordID"] = ExpressionConverter.Convert(__workflow_externalRecordId);
                if (__workflow_tagName != null)
                    callPayload.Queries["tagName"] = ExpressionConverter.Convert(__workflow_tagName);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "korto")]
        public IBodyWorkflowAction<RecordQueryResponseItem, ApiConnectionActionConfiguration> AddTagToRecord(Expression<Func<int>> recordId = null, Expression<Func<string>> externalRecordId = null, Expression<Func<string>> tagName = null, Expression<Func<string>> tagValue = null)
        {
            var __workflow_recordId = WorkflowExpression.Compile(recordId, nameof(recordId), required: false);
            var __workflow_externalRecordId = WorkflowExpression.Compile(externalRecordId, nameof(externalRecordId), required: false);
            var __workflow_tagName = WorkflowExpression.Compile(tagName, nameof(tagName), required: false);
            var __workflow_tagValue = WorkflowExpression.Compile(tagValue, nameof(tagValue), required: false);
            return new DeferredBodyAction<RecordQueryResponseItem, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/RecordTagValue/v2";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_recordId != null)
                    callPayload.Queries["recordID"] = ExpressionConverter.Convert(__workflow_recordId);
                if (__workflow_externalRecordId != null)
                    callPayload.Queries["externalRecordID"] = ExpressionConverter.Convert(__workflow_externalRecordId);
                if (__workflow_tagName != null)
                    callPayload.Queries["tagName"] = ExpressionConverter.Convert(__workflow_tagName);
                if (__workflow_tagValue != null)
                    callPayload.Queries["tagValue"] = ExpressionConverter.Convert(__workflow_tagValue);
                return new ApiConnectionAction<RecordQueryResponseItem>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "korto")]
        public IBodyWorkflowAction<RecordQueryResponseItem, ApiConnectionActionConfiguration> UpdateTagOnRecord(Expression<Func<int>> recordId = null, Expression<Func<string>> externalRecordId = null, Expression<Func<string>> tagName = null, Expression<Func<string>> tagValue = null)
        {
            var __workflow_recordId = WorkflowExpression.Compile(recordId, nameof(recordId), required: false);
            var __workflow_externalRecordId = WorkflowExpression.Compile(externalRecordId, nameof(externalRecordId), required: false);
            var __workflow_tagName = WorkflowExpression.Compile(tagName, nameof(tagName), required: false);
            var __workflow_tagValue = WorkflowExpression.Compile(tagValue, nameof(tagValue), required: false);
            return new DeferredBodyAction<RecordQueryResponseItem, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/RecordTagValue/v2";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_recordId != null)
                    callPayload.Queries["recordID"] = ExpressionConverter.Convert(__workflow_recordId);
                if (__workflow_externalRecordId != null)
                    callPayload.Queries["externalRecordID"] = ExpressionConverter.Convert(__workflow_externalRecordId);
                if (__workflow_tagName != null)
                    callPayload.Queries["tagName"] = ExpressionConverter.Convert(__workflow_tagName);
                if (__workflow_tagValue != null)
                    callPayload.Queries["tagValue"] = ExpressionConverter.Convert(__workflow_tagValue);
                return new ApiConnectionAction<RecordQueryResponseItem>(callPayload);
            });
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