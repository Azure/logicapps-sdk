//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Korto
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class KortoActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "korto")]
        [WorkflowExpressionFactory(nameof(__BuildGetTag))]
        public IBodyWorkflowAction<QueryTagsResponse> GetTag([WorkflowExpression] Func<int> tagID = null, [WorkflowExpression] Func<string> tagName = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<QueryTagsResponse> __BuildGetTag(WorkflowValue<int> tagID = null, WorkflowValue<string> tagName = null)
        {
            WorkflowValue.Validate(tagID, nameof(tagID), required: false);
            WorkflowValue.Validate(tagName, nameof(tagName), required: false);
            return new DeferredBodyAction<QueryTagsResponse>(() =>
            {
                var apiCallPath = "/Tag/v2";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (tagID != null)
                    callPayload.Queries["tagID"] = ExpressionConverter.Convert(tagID);
                if (tagName != null)
                    callPayload.Queries["tagName"] = ExpressionConverter.Convert(tagName);
                return new ApiConnectionAction<QueryTagsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "korto")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteTag))]
        public IWorkflowAction DeleteTag([WorkflowExpression] Func<int> tagID = null, [WorkflowExpression] Func<string> tagName = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDeleteTag(WorkflowValue<int> tagID = null, WorkflowValue<string> tagName = null)
        {
            WorkflowValue.Validate(tagID, nameof(tagID), required: false);
            WorkflowValue.Validate(tagName, nameof(tagName), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/Tag/v2";
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (tagID != null)
                    callPayload.Queries["tagID"] = ExpressionConverter.Convert(tagID);
                if (tagName != null)
                    callPayload.Queries["tagName"] = ExpressionConverter.Convert(tagName);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "korto")]
        [WorkflowExpressionFactory(nameof(__BuildCreateTag))]
        public IBodyWorkflowAction<QueryTagResponseItem> CreateTag([WorkflowExpression] Func<string> tagName = null, [WorkflowExpression] Func<int> tagType = null, [WorkflowExpression] Func<int> tagValueType = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<QueryTagResponseItem> __BuildCreateTag(WorkflowValue<string> tagName = null, WorkflowValue<int> tagType = null, WorkflowValue<int> tagValueType = null)
        {
            WorkflowValue.Validate(tagName, nameof(tagName), required: false);
            WorkflowValue.Validate(tagType, nameof(tagType), required: false);
            WorkflowValue.Validate(tagValueType, nameof(tagValueType), required: false);
            return new DeferredBodyAction<QueryTagResponseItem>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "korto")]
        [WorkflowExpressionFactory(nameof(__BuildGetRecord))]
        public IBodyWorkflowAction<RecordQueryResponseItem> GetRecord([WorkflowExpression] Func<int> recordID = null, [WorkflowExpression] Func<string> externalRecordID = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<RecordQueryResponseItem> __BuildGetRecord(WorkflowValue<int> recordID = null, WorkflowValue<string> externalRecordID = null)
        {
            WorkflowValue.Validate(recordID, nameof(recordID), required: false);
            WorkflowValue.Validate(externalRecordID, nameof(externalRecordID), required: false);
            return new DeferredBodyAction<RecordQueryResponseItem>(() =>
            {
                var apiCallPath = "/Record/v2";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (recordID != null)
                    callPayload.Queries["recordID"] = ExpressionConverter.Convert(recordID);
                if (externalRecordID != null)
                    callPayload.Queries["externalRecordID"] = ExpressionConverter.Convert(externalRecordID);
                return new ApiConnectionAction<RecordQueryResponseItem>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "korto")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteRecord))]
        public IWorkflowAction DeleteRecord([WorkflowExpression] Func<int> recordID = null, [WorkflowExpression] Func<string> externalRecordID = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDeleteRecord(WorkflowValue<int> recordID = null, WorkflowValue<string> externalRecordID = null)
        {
            WorkflowValue.Validate(recordID, nameof(recordID), required: false);
            WorkflowValue.Validate(externalRecordID, nameof(externalRecordID), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/Record/v2";
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (recordID != null)
                    callPayload.Queries["recordID"] = ExpressionConverter.Convert(recordID);
                if (externalRecordID != null)
                    callPayload.Queries["externalRecordID"] = ExpressionConverter.Convert(externalRecordID);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "korto")]
        [WorkflowExpressionFactory(nameof(__BuildCreateRecord))]
        public IBodyWorkflowAction<RecordQueryResponseItem> CreateRecord([WorkflowExpression] Func<object> file, [WorkflowExpression] Func<string> name = null, [WorkflowExpression] Func<string> actor = null, [WorkflowExpression] Func<string> externalid = null, [WorkflowExpression] Func<string> externalurl = null, [WorkflowExpression] Func<string> createdAt = null, [WorkflowExpression] Func<string> createdBy = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<RecordQueryResponseItem> __BuildCreateRecord(WorkflowValue<object> file, WorkflowValue<string> name = null, WorkflowValue<string> actor = null, WorkflowValue<string> externalid = null, WorkflowValue<string> externalurl = null, WorkflowValue<string> createdAt = null, WorkflowValue<string> createdBy = null)
        {
            WorkflowValue.Validate(file, nameof(file), required: true);
            WorkflowValue.Validate(name, nameof(name), required: false);
            WorkflowValue.Validate(actor, nameof(actor), required: false);
            WorkflowValue.Validate(externalid, nameof(externalid), required: false);
            WorkflowValue.Validate(externalurl, nameof(externalurl), required: false);
            WorkflowValue.Validate(createdAt, nameof(createdAt), required: false);
            WorkflowValue.Validate(createdBy, nameof(createdBy), required: false);
            return new DeferredBodyAction<RecordQueryResponseItem>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "korto")]
        [WorkflowExpressionFactory(nameof(__BuildDownloadRecord))]
        public IBodyWorkflowAction<DownloadUrlMessage> DownloadRecord([WorkflowExpression] Func<int> recordID = null, [WorkflowExpression] Func<string> externalRecordID = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DownloadUrlMessage> __BuildDownloadRecord(WorkflowValue<int> recordID = null, WorkflowValue<string> externalRecordID = null)
        {
            WorkflowValue.Validate(recordID, nameof(recordID), required: false);
            WorkflowValue.Validate(externalRecordID, nameof(externalRecordID), required: false);
            return new DeferredBodyAction<DownloadUrlMessage>(() =>
            {
                var apiCallPath = "/Record/v2/download";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (recordID != null)
                    callPayload.Queries["recordID"] = ExpressionConverter.Convert(recordID);
                if (externalRecordID != null)
                    callPayload.Queries["externalRecordID"] = ExpressionConverter.Convert(externalRecordID);
                return new ApiConnectionAction<DownloadUrlMessage>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "korto")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteTagFromRecord))]
        public IWorkflowAction DeleteTagFromRecord([WorkflowExpression] Func<int> recordID = null, [WorkflowExpression] Func<string> externalRecordID = null, [WorkflowExpression] Func<string> tagName = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDeleteTagFromRecord(WorkflowValue<int> recordID = null, WorkflowValue<string> externalRecordID = null, WorkflowValue<string> tagName = null)
        {
            WorkflowValue.Validate(recordID, nameof(recordID), required: false);
            WorkflowValue.Validate(externalRecordID, nameof(externalRecordID), required: false);
            WorkflowValue.Validate(tagName, nameof(tagName), required: false);
            return new DeferredWorkflowAction(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "korto")]
        [WorkflowExpressionFactory(nameof(__BuildAddTagToRecord))]
        public IBodyWorkflowAction<RecordQueryResponseItem> AddTagToRecord([WorkflowExpression] Func<int> recordID = null, [WorkflowExpression] Func<string> externalRecordID = null, [WorkflowExpression] Func<string> tagName = null, [WorkflowExpression] Func<string> tagValue = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<RecordQueryResponseItem> __BuildAddTagToRecord(WorkflowValue<int> recordID = null, WorkflowValue<string> externalRecordID = null, WorkflowValue<string> tagName = null, WorkflowValue<string> tagValue = null)
        {
            WorkflowValue.Validate(recordID, nameof(recordID), required: false);
            WorkflowValue.Validate(externalRecordID, nameof(externalRecordID), required: false);
            WorkflowValue.Validate(tagName, nameof(tagName), required: false);
            WorkflowValue.Validate(tagValue, nameof(tagValue), required: false);
            return new DeferredBodyAction<RecordQueryResponseItem>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "korto")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateTagOnRecord))]
        public IBodyWorkflowAction<RecordQueryResponseItem> UpdateTagOnRecord([WorkflowExpression] Func<int> recordID = null, [WorkflowExpression] Func<string> externalRecordID = null, [WorkflowExpression] Func<string> tagName = null, [WorkflowExpression] Func<string> tagValue = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<RecordQueryResponseItem> __BuildUpdateTagOnRecord(WorkflowValue<int> recordID = null, WorkflowValue<string> externalRecordID = null, WorkflowValue<string> tagName = null, WorkflowValue<string> tagValue = null)
        {
            WorkflowValue.Validate(recordID, nameof(recordID), required: false);
            WorkflowValue.Validate(externalRecordID, nameof(externalRecordID), required: false);
            WorkflowValue.Validate(tagName, nameof(tagName), required: false);
            WorkflowValue.Validate(tagValue, nameof(tagValue), required: false);
            return new DeferredBodyAction<RecordQueryResponseItem>(() =>
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
