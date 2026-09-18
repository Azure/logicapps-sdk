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
        public IBodyWorkflowAction<QueryTagsResponse> GetTag([WorkflowExpression] Func<int> tagID = null, [WorkflowExpression] Func<string> tagName = null)
        {
            SourceExpression.Validate(tagID, nameof(tagID), required: false);
            SourceExpression.Validate(tagName, nameof(tagName), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/Tag/v2";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (tagID != null)
                    callPayload.Queries["tagID"] = SourceExpressionConverter.ConvertO(tagID);
                if (tagName != null)
                    callPayload.Queries["tagName"] = SourceExpressionConverter.ConvertO(tagName);
                return callPayload;
            }

            return new ApiConnectionAction<QueryTagsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "korto")]
        public IWorkflowAction DeleteTag([WorkflowExpression] Func<int> tagID = null, [WorkflowExpression] Func<string> tagName = null)
        {
            SourceExpression.Validate(tagID, nameof(tagID), required: false);
            SourceExpression.Validate(tagName, nameof(tagName), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/Tag/v2";
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (tagID != null)
                    callPayload.Queries["tagID"] = SourceExpressionConverter.ConvertO(tagID);
                if (tagName != null)
                    callPayload.Queries["tagName"] = SourceExpressionConverter.ConvertO(tagName);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "korto")]
        public IBodyWorkflowAction<QueryTagResponseItem> CreateTag([WorkflowExpression] Func<string> tagName = null, [WorkflowExpression] Func<int> tagType = null, [WorkflowExpression] Func<int> tagValueType = null)
        {
            SourceExpression.Validate(tagName, nameof(tagName), required: false);
            SourceExpression.Validate(tagType, nameof(tagType), required: false);
            SourceExpression.Validate(tagValueType, nameof(tagValueType), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/Tag/v2";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (tagName != null)
                    callPayload.Queries["tagName"] = SourceExpressionConverter.ConvertO(tagName);
                callPayload.Queries["tagType"] = Convert.ToString(1);
                if (tagType != null)
                    callPayload.Queries["tagType"] = SourceExpressionConverter.ConvertO(tagType);
                if (tagValueType != null)
                    callPayload.Queries["tagValueType"] = SourceExpressionConverter.ConvertO(tagValueType);
                return callPayload;
            }

            return new ApiConnectionAction<QueryTagResponseItem>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "korto")]
        public IBodyWorkflowAction<RecordQueryResponseItem> GetRecord([WorkflowExpression] Func<int> recordID = null, [WorkflowExpression] Func<string> externalRecordID = null)
        {
            SourceExpression.Validate(recordID, nameof(recordID), required: false);
            SourceExpression.Validate(externalRecordID, nameof(externalRecordID), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/Record/v2";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (recordID != null)
                    callPayload.Queries["recordID"] = SourceExpressionConverter.ConvertO(recordID);
                if (externalRecordID != null)
                    callPayload.Queries["externalRecordID"] = SourceExpressionConverter.ConvertO(externalRecordID);
                return callPayload;
            }

            return new ApiConnectionAction<RecordQueryResponseItem>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "korto")]
        public IWorkflowAction DeleteRecord([WorkflowExpression] Func<int> recordID = null, [WorkflowExpression] Func<string> externalRecordID = null)
        {
            SourceExpression.Validate(recordID, nameof(recordID), required: false);
            SourceExpression.Validate(externalRecordID, nameof(externalRecordID), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/Record/v2";
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (recordID != null)
                    callPayload.Queries["recordID"] = SourceExpressionConverter.ConvertO(recordID);
                if (externalRecordID != null)
                    callPayload.Queries["externalRecordID"] = SourceExpressionConverter.ConvertO(externalRecordID);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "korto")]
        public IBodyWorkflowAction<RecordQueryResponseItem> CreateRecord([WorkflowExpression] Func<object> file, [WorkflowExpression] Func<string> name = null, [WorkflowExpression] Func<string> actor = null, [WorkflowExpression] Func<string> externalid = null, [WorkflowExpression] Func<string> externalurl = null, [WorkflowExpression] Func<string> createdAt = null, [WorkflowExpression] Func<string> createdBy = null)
        {
            SourceExpression.Validate(file, nameof(file), required: true);
            SourceExpression.Validate(name, nameof(name), required: false);
            SourceExpression.Validate(actor, nameof(actor), required: false);
            SourceExpression.Validate(externalid, nameof(externalid), required: false);
            SourceExpression.Validate(externalurl, nameof(externalurl), required: false);
            SourceExpression.Validate(createdAt, nameof(createdAt), required: false);
            SourceExpression.Validate(createdBy, nameof(createdBy), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/Record/v2";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (name != null)
                    callPayload.Queries["name"] = SourceExpressionConverter.ConvertO(name);
                if (actor != null)
                    callPayload.Queries["actor"] = SourceExpressionConverter.ConvertO(actor);
                if (externalid != null)
                    callPayload.Queries["externalid"] = SourceExpressionConverter.ConvertO(externalid);
                if (externalurl != null)
                    callPayload.Queries["externalurl"] = SourceExpressionConverter.ConvertO(externalurl);
                if (createdAt != null)
                    callPayload.Queries["createdAt"] = SourceExpressionConverter.ConvertO(createdAt);
                if (createdBy != null)
                    callPayload.Queries["createdBy"] = SourceExpressionConverter.ConvertO(createdBy);
                return callPayload;
            }

            return new ApiConnectionAction<RecordQueryResponseItem>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "korto")]
        public IBodyWorkflowAction<DownloadUrlMessage> DownloadRecord([WorkflowExpression] Func<int> recordID = null, [WorkflowExpression] Func<string> externalRecordID = null)
        {
            SourceExpression.Validate(recordID, nameof(recordID), required: false);
            SourceExpression.Validate(externalRecordID, nameof(externalRecordID), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/Record/v2/download";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (recordID != null)
                    callPayload.Queries["recordID"] = SourceExpressionConverter.ConvertO(recordID);
                if (externalRecordID != null)
                    callPayload.Queries["externalRecordID"] = SourceExpressionConverter.ConvertO(externalRecordID);
                return callPayload;
            }

            return new ApiConnectionAction<DownloadUrlMessage>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "korto")]
        public IWorkflowAction DeleteTagFromRecord([WorkflowExpression] Func<int> recordID = null, [WorkflowExpression] Func<string> externalRecordID = null, [WorkflowExpression] Func<string> tagName = null)
        {
            SourceExpression.Validate(recordID, nameof(recordID), required: false);
            SourceExpression.Validate(externalRecordID, nameof(externalRecordID), required: false);
            SourceExpression.Validate(tagName, nameof(tagName), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/RecordTagValue/v2";
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (recordID != null)
                    callPayload.Queries["recordID"] = SourceExpressionConverter.ConvertO(recordID);
                if (externalRecordID != null)
                    callPayload.Queries["externalRecordID"] = SourceExpressionConverter.ConvertO(externalRecordID);
                if (tagName != null)
                    callPayload.Queries["tagName"] = SourceExpressionConverter.ConvertO(tagName);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "korto")]
        public IBodyWorkflowAction<RecordQueryResponseItem> AddTagToRecord([WorkflowExpression] Func<int> recordID = null, [WorkflowExpression] Func<string> externalRecordID = null, [WorkflowExpression] Func<string> tagName = null, [WorkflowExpression] Func<string> tagValue = null)
        {
            SourceExpression.Validate(recordID, nameof(recordID), required: false);
            SourceExpression.Validate(externalRecordID, nameof(externalRecordID), required: false);
            SourceExpression.Validate(tagName, nameof(tagName), required: false);
            SourceExpression.Validate(tagValue, nameof(tagValue), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/RecordTagValue/v2";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (recordID != null)
                    callPayload.Queries["recordID"] = SourceExpressionConverter.ConvertO(recordID);
                if (externalRecordID != null)
                    callPayload.Queries["externalRecordID"] = SourceExpressionConverter.ConvertO(externalRecordID);
                if (tagName != null)
                    callPayload.Queries["tagName"] = SourceExpressionConverter.ConvertO(tagName);
                if (tagValue != null)
                    callPayload.Queries["tagValue"] = SourceExpressionConverter.ConvertO(tagValue);
                return callPayload;
            }

            return new ApiConnectionAction<RecordQueryResponseItem>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "korto")]
        public IBodyWorkflowAction<RecordQueryResponseItem> UpdateTagOnRecord([WorkflowExpression] Func<int> recordID = null, [WorkflowExpression] Func<string> externalRecordID = null, [WorkflowExpression] Func<string> tagName = null, [WorkflowExpression] Func<string> tagValue = null)
        {
            SourceExpression.Validate(recordID, nameof(recordID), required: false);
            SourceExpression.Validate(externalRecordID, nameof(externalRecordID), required: false);
            SourceExpression.Validate(tagName, nameof(tagName), required: false);
            SourceExpression.Validate(tagValue, nameof(tagValue), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/RecordTagValue/v2";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (recordID != null)
                    callPayload.Queries["recordID"] = SourceExpressionConverter.ConvertO(recordID);
                if (externalRecordID != null)
                    callPayload.Queries["externalRecordID"] = SourceExpressionConverter.ConvertO(externalRecordID);
                if (tagName != null)
                    callPayload.Queries["tagName"] = SourceExpressionConverter.ConvertO(tagName);
                if (tagValue != null)
                    callPayload.Queries["tagValue"] = SourceExpressionConverter.ConvertO(tagValue);
                return callPayload;
            }

            return new ApiConnectionAction<RecordQueryResponseItem>(BuildSourceInput);
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