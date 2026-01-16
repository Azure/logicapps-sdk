//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Korto
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class KortoActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "korto")]
        public IBodyWorkflowAction<QueryTagsResponse> GetTag(Expression<Func<int>> tagID = null, Expression<Func<string>> tagName = null)
        {
            var apiCallPath = "/Tag/v2";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (tagID != null)
                callPayload.Queries["tagID"] = ExpressionConverter.Convert(tagID);
            if (tagName != null)
                callPayload.Queries["tagName"] = ExpressionConverter.Convert(tagName);
            return new ApiConnectionAction<QueryTagsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "korto")]
        public IWorkflowAction DeleteTag(Expression<Func<int>> tagID = null, Expression<Func<string>> tagName = null)
        {
            var apiCallPath = "/Tag/v2";
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (tagID != null)
                callPayload.Queries["tagID"] = ExpressionConverter.Convert(tagID);
            if (tagName != null)
                callPayload.Queries["tagName"] = ExpressionConverter.Convert(tagName);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "korto")]
        public IBodyWorkflowAction<QueryTagResponseItem> CreateTag(Expression<Func<string>> tagName = null, Expression<Func<int>> tagType = null, Expression<Func<int>> tagValueType = null)
        {
            var apiCallPath = "/Tag/v2";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (tagName != null)
                callPayload.Queries["tagName"] = ExpressionConverter.Convert(tagName);
            callPayload.Queries["tagType"] = Convert.ToString(1);
            if (tagType != null)
                callPayload.Queries["tagType"] = ExpressionConverter.Convert(tagType);
            if (tagValueType != null)
                callPayload.Queries["tagValueType"] = ExpressionConverter.Convert(tagValueType);
            return new ApiConnectionAction<QueryTagResponseItem>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "korto")]
        public IBodyWorkflowAction<RecordQueryResponseItem> GetRecord(Expression<Func<int>> recordID = null, Expression<Func<string>> externalRecordID = null)
        {
            var apiCallPath = "/Record/v2";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (recordID != null)
                callPayload.Queries["recordID"] = ExpressionConverter.Convert(recordID);
            if (externalRecordID != null)
                callPayload.Queries["externalRecordID"] = ExpressionConverter.Convert(externalRecordID);
            return new ApiConnectionAction<RecordQueryResponseItem>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "korto")]
        public IWorkflowAction DeleteRecord(Expression<Func<int>> recordID = null, Expression<Func<string>> externalRecordID = null)
        {
            var apiCallPath = "/Record/v2";
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (recordID != null)
                callPayload.Queries["recordID"] = ExpressionConverter.Convert(recordID);
            if (externalRecordID != null)
                callPayload.Queries["externalRecordID"] = ExpressionConverter.Convert(externalRecordID);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "korto")]
        public IBodyWorkflowAction<RecordQueryResponseItem> CreateRecord(Expression<Func<object>> file, Expression<Func<string>> name = null, Expression<Func<string>> actor = null, Expression<Func<string>> externalid = null, Expression<Func<string>> externalurl = null, Expression<Func<string>> createdAt = null, Expression<Func<string>> createdBy = null)
        {
            var apiCallPath = "/Record/v2";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (name != null)
                callPayload.Queries["name"] = ExpressionConverter.Convert(name);
            if (actor != null)
                callPayload.Queries["actor"] = ExpressionConverter.Convert(actor);
            if (externalid != null)
                callPayload.Queries["externalid"] = ExpressionConverter.Convert(externalid);
            if (externalurl != null)
                callPayload.Queries["externalurl"] = ExpressionConverter.Convert(externalurl);
            if (createdAt != null)
                callPayload.Queries["createdAt"] = ExpressionConverter.Convert(createdAt);
            if (createdBy != null)
                callPayload.Queries["createdBy"] = ExpressionConverter.Convert(createdBy);
            return new ApiConnectionAction<RecordQueryResponseItem>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "korto")]
        public IBodyWorkflowAction<DownloadUrlMessage> DownloadRecord(Expression<Func<int>> recordID = null, Expression<Func<string>> externalRecordID = null)
        {
            var apiCallPath = "/Record/v2/download";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (recordID != null)
                callPayload.Queries["recordID"] = ExpressionConverter.Convert(recordID);
            if (externalRecordID != null)
                callPayload.Queries["externalRecordID"] = ExpressionConverter.Convert(externalRecordID);
            return new ApiConnectionAction<DownloadUrlMessage>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "korto")]
        public IWorkflowAction DeleteTagFromRecord(Expression<Func<int>> recordID = null, Expression<Func<string>> externalRecordID = null, Expression<Func<string>> tagName = null)
        {
            var apiCallPath = "/RecordTagValue/v2";
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (recordID != null)
                callPayload.Queries["recordID"] = ExpressionConverter.Convert(recordID);
            if (externalRecordID != null)
                callPayload.Queries["externalRecordID"] = ExpressionConverter.Convert(externalRecordID);
            if (tagName != null)
                callPayload.Queries["tagName"] = ExpressionConverter.Convert(tagName);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "korto")]
        public IBodyWorkflowAction<RecordQueryResponseItem> AddTagToRecord(Expression<Func<int>> recordID = null, Expression<Func<string>> externalRecordID = null, Expression<Func<string>> tagName = null, Expression<Func<string>> tagValue = null)
        {
            var apiCallPath = "/RecordTagValue/v2";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (recordID != null)
                callPayload.Queries["recordID"] = ExpressionConverter.Convert(recordID);
            if (externalRecordID != null)
                callPayload.Queries["externalRecordID"] = ExpressionConverter.Convert(externalRecordID);
            if (tagName != null)
                callPayload.Queries["tagName"] = ExpressionConverter.Convert(tagName);
            if (tagValue != null)
                callPayload.Queries["tagValue"] = ExpressionConverter.Convert(tagValue);
            return new ApiConnectionAction<RecordQueryResponseItem>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "korto")]
        public IBodyWorkflowAction<RecordQueryResponseItem> UpdateTagOnRecord(Expression<Func<int>> recordID = null, Expression<Func<string>> externalRecordID = null, Expression<Func<string>> tagName = null, Expression<Func<string>> tagValue = null)
        {
            var apiCallPath = "/RecordTagValue/v2";
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (recordID != null)
                callPayload.Queries["recordID"] = ExpressionConverter.Convert(recordID);
            if (externalRecordID != null)
                callPayload.Queries["externalRecordID"] = ExpressionConverter.Convert(externalRecordID);
            if (tagName != null)
                callPayload.Queries["tagName"] = ExpressionConverter.Convert(tagName);
            if (tagValue != null)
                callPayload.Queries["tagValue"] = ExpressionConverter.Convert(tagValue);
            return new ApiConnectionAction<RecordQueryResponseItem>(callPayload);
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