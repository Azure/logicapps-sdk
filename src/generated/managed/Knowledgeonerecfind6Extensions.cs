//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Knowledgeonerecfind6
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class Knowledgeonerecfind6Actions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "knowledgeonerecfind6")]
        public IBodyWorkflowAction<QueryListResponse> QueryList(Expression<Func<string>> hostUrl = null, Expression<Func<string>> userName = null)
        {
            var __workflow_hostUrl = WorkflowExpression.Compile(hostUrl, nameof(hostUrl), required: false);
            var __workflow_userName = WorkflowExpression.Compile(userName, nameof(userName), required: false);
            return new DeferredBodyAction<QueryListResponse>(() =>
            {
                var apiCallPath = "/QueryList";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_hostUrl != null)
                    callPayload.Queries["HostUrl"] = ExpressionConverter.Convert(__workflow_hostUrl);
                if (__workflow_userName != null)
                    callPayload.Queries["UserName"] = ExpressionConverter.Convert(__workflow_userName);
                return new ApiConnectionAction<QueryListResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "knowledgeonerecfind6")]
        public IBodyWorkflowAction<JToken[]> QueryTable(Expression<Func<string>> hostUrl = null, Expression<Func<string>> userName = null, Expression<Func<string>> queryName = null, Expression<Func<string>> searchText = null)
        {
            var __workflow_hostUrl = WorkflowExpression.Compile(hostUrl, nameof(hostUrl), required: false);
            var __workflow_userName = WorkflowExpression.Compile(userName, nameof(userName), required: false);
            var __workflow_queryName = WorkflowExpression.Compile(queryName, nameof(queryName), required: false);
            var __workflow_searchText = WorkflowExpression.Compile(searchText, nameof(searchText), required: false);
            return new DeferredBodyAction<JToken[]>(() =>
            {
                var apiCallPath = "/QueryTable";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_hostUrl != null)
                    callPayload.Queries["HostUrl"] = ExpressionConverter.Convert(__workflow_hostUrl);
                if (__workflow_userName != null)
                    callPayload.Queries["UserName"] = ExpressionConverter.Convert(__workflow_userName);
                if (__workflow_queryName != null)
                    callPayload.Queries["QueryName"] = ExpressionConverter.Convert(__workflow_queryName);
                if (__workflow_searchText != null)
                    callPayload.Queries["SearchText"] = ExpressionConverter.Convert(__workflow_searchText);
                return new ApiConnectionAction<JToken[]>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "knowledgeonerecfind6")]
        public IBodyWorkflowAction<QueryDataResponse> QueryData(Expression<Func<string>> hostUrl = null, Expression<Func<string>> userName = null, Expression<Func<string>> queryName = null, Expression<Func<int>> startPosition = null, Expression<Func<int>> numberOfRecords = null, Expression<Func<string>> searchText = null)
        {
            var __workflow_hostUrl = WorkflowExpression.Compile(hostUrl, nameof(hostUrl), required: false);
            var __workflow_userName = WorkflowExpression.Compile(userName, nameof(userName), required: false);
            var __workflow_queryName = WorkflowExpression.Compile(queryName, nameof(queryName), required: false);
            var __workflow_startPosition = WorkflowExpression.Compile(startPosition, nameof(startPosition), required: false);
            var __workflow_numberOfRecords = WorkflowExpression.Compile(numberOfRecords, nameof(numberOfRecords), required: false);
            var __workflow_searchText = WorkflowExpression.Compile(searchText, nameof(searchText), required: false);
            return new DeferredBodyAction<QueryDataResponse>(() =>
            {
                var apiCallPath = "/QueryData";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_hostUrl != null)
                    callPayload.Queries["HostUrl"] = ExpressionConverter.Convert(__workflow_hostUrl);
                if (__workflow_userName != null)
                    callPayload.Queries["UserName"] = ExpressionConverter.Convert(__workflow_userName);
                if (__workflow_queryName != null)
                    callPayload.Queries["QueryName"] = ExpressionConverter.Convert(__workflow_queryName);
                if (__workflow_startPosition != null)
                    callPayload.Queries["StartPosition"] = ExpressionConverter.Convert(__workflow_startPosition);
                if (__workflow_numberOfRecords != null)
                    callPayload.Queries["NumberOfRecords"] = ExpressionConverter.Convert(__workflow_numberOfRecords);
                if (__workflow_searchText != null)
                    callPayload.Queries["SearchText"] = ExpressionConverter.Convert(__workflow_searchText);
                return new ApiConnectionAction<QueryDataResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "knowledgeonerecfind6")]
        public IBodyWorkflowAction<JToken[]> SavedSearch(Expression<Func<string>> hostUrl = null, Expression<Func<string>> userName = null, Expression<Func<string>> savedSearchName = null, Expression<Func<string>> queryParams = null)
        {
            var __workflow_hostUrl = WorkflowExpression.Compile(hostUrl, nameof(hostUrl), required: false);
            var __workflow_userName = WorkflowExpression.Compile(userName, nameof(userName), required: false);
            var __workflow_savedSearchName = WorkflowExpression.Compile(savedSearchName, nameof(savedSearchName), required: false);
            var __workflow_queryParams = WorkflowExpression.Compile(queryParams, nameof(queryParams), required: false);
            return new DeferredBodyAction<JToken[]>(() =>
            {
                var apiCallPath = "/SavedSearch";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_hostUrl != null)
                    callPayload.Queries["HostUrl"] = ExpressionConverter.Convert(__workflow_hostUrl);
                if (__workflow_userName != null)
                    callPayload.Queries["UserName"] = ExpressionConverter.Convert(__workflow_userName);
                if (__workflow_savedSearchName != null)
                    callPayload.Queries["SavedSearchName"] = ExpressionConverter.Convert(__workflow_savedSearchName);
                if (__workflow_queryParams != null)
                    callPayload.Queries["QueryParams"] = ExpressionConverter.Convert(__workflow_queryParams);
                return new ApiConnectionAction<JToken[]>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "knowledgeonerecfind6")]
        public IBodyWorkflowAction<SendFileResponse> SendFile(Expression<Func<string>> hostUrl = null, Expression<Func<string>> userName = null, Expression<Func<string>> bodyfileContents = null, Expression<Func<string>> bodyfileName = null, Expression<Func<string>> bodytitle = null, Expression<Func<string>> bodycreatedDate = null, Expression<Func<string>> bodyeDOCType = null, Expression<Func<bodyextraFieldsInputItem[]>> bodyextraFields = null)
        {
            var __workflow_hostUrl = WorkflowExpression.Compile(hostUrl, nameof(hostUrl), required: false);
            var __workflow_userName = WorkflowExpression.Compile(userName, nameof(userName), required: false);
            var __workflow_bodyfileContents = WorkflowExpression.Compile(bodyfileContents, nameof(bodyfileContents), required: false);
            var __workflow_bodyfileName = WorkflowExpression.Compile(bodyfileName, nameof(bodyfileName), required: false);
            var __workflow_bodytitle = WorkflowExpression.Compile(bodytitle, nameof(bodytitle), required: false);
            var __workflow_bodycreatedDate = WorkflowExpression.Compile(bodycreatedDate, nameof(bodycreatedDate), required: false);
            var __workflow_bodyeDOCType = WorkflowExpression.Compile(bodyeDOCType, nameof(bodyeDOCType), required: false);
            var __workflow_bodyextraFields = WorkflowExpression.Compile(bodyextraFields, nameof(bodyextraFields), required: false);
            return new DeferredBodyAction<SendFileResponse>(() =>
            {
                var apiCallPath = "/SendFile";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_hostUrl != null)
                    callPayload.Queries["HostUrl"] = ExpressionConverter.Convert(__workflow_hostUrl);
                if (__workflow_userName != null)
                    callPayload.Queries["UserName"] = ExpressionConverter.Convert(__workflow_userName);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyfileContents != null)
                {
                    body["FileContents"] = ExpressionConverter.ConvertO(__workflow_bodyfileContents);
                    bodypropCount++;
                }

                if (__workflow_bodyfileName != null)
                {
                    body["FileName"] = ExpressionConverter.ConvertO(__workflow_bodyfileName);
                    bodypropCount++;
                }

                if (__workflow_bodytitle != null)
                {
                    body["Title"] = ExpressionConverter.ConvertO(__workflow_bodytitle);
                    bodypropCount++;
                }

                if (__workflow_bodycreatedDate != null)
                {
                    body["CreatedDate"] = ExpressionConverter.ConvertO(__workflow_bodycreatedDate);
                    bodypropCount++;
                }

                if (__workflow_bodyeDOCType != null)
                {
                    body["EDOCType"] = ExpressionConverter.ConvertO(__workflow_bodyeDOCType);
                    bodypropCount++;
                }

                if (__workflow_bodyextraFields != null)
                {
                    body["ExtraFields"] = ExpressionConverter.ConvertO(__workflow_bodyextraFields);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<SendFileResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }
    }

    public class Knowledgeonerecfind6Triggers([ConnectionName] string connectionId)
    {
    }

    public class QueryListResponse
    {
        [JsonProperty("queries")]
        public QueryListResponseQueriesTypeItem[] Queries { get; set; }

        [JsonProperty("result")]
        public string Result { get; set; }
    }

    public class QueryListResponseQueriesTypeItem
    {
        public string QueryName { get; set; }
        public int FieldCount { get; set; }
    }

    public class QueryDataResponse
    {
        public QueryDataResponseRecordsTypeItem[] Records { get; set; }
        public bool LastPage { get; set; }

        [JsonProperty("result")]
        public string Result { get; set; }
    }

    public class QueryDataResponseRecordsTypeItem
    {
        public int RowCount { get; set; }

        [JsonProperty("Row_id")]
        public string RowId { get; set; }
        public string UrlView { get; set; }
        public string UrlModify { get; set; }

        [JsonProperty("Row_fields")]
        public QueryDataResponseRecordsTypeItemRowFieldsTypeItem[] RowFields { get; set; }
    }

    public class QueryDataResponseRecordsTypeItemRowFieldsTypeItem
    {
        [JsonProperty("Field_name")]
        public string FieldName { get; set; }

        [JsonProperty("Field_value")]
        public string FieldValue { get; set; }
    }

    public class SendFileResponse
    {
        public string URL { get; set; }

        [JsonProperty("result")]
        public string Result { get; set; }
    }

    public class bodyextraFieldsInputItem
    {
        public string FldName { get; set; }
        public string FldValue { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Knowledgeonerecfind6;

    public partial class WorkflowManagedActions
    {
        public Knowledgeonerecfind6Actions Knowledgeonerecfind6(string connectionId) => new Knowledgeonerecfind6Actions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public Knowledgeonerecfind6Triggers Knowledgeonerecfind6(string connectionId) => new Knowledgeonerecfind6Triggers(connectionId);
    }
}
