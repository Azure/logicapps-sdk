//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Knowledgeonerecfind6
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class Knowledgeonerecfind6Actions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "knowledgeonerecfind6")]
        [WorkflowExpressionFactory(nameof(__BuildQueryList))]
        public IBodyWorkflowAction<QueryListResponse> QueryList([WorkflowExpression] Func<string> hostUrl = null, [WorkflowExpression] Func<string> userName = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "knowledgeonerecfind6")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<QueryListResponse> __BuildQueryList(WorkflowExpression<string> hostUrl = null, WorkflowExpression<string> userName = null)
        {
            WorkflowExpression.Validate(hostUrl, nameof(hostUrl), required: false);
            WorkflowExpression.Validate(userName, nameof(userName), required: false);
            return new DeferredBodyAction<QueryListResponse>(() =>
            {
                var apiCallPath = "/QueryList";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (hostUrl != null)
                    callPayload.Queries["HostUrl"] = ExpressionConverter.Convert(hostUrl);
                if (userName != null)
                    callPayload.Queries["UserName"] = ExpressionConverter.Convert(userName);
                return new ApiConnectionAction<QueryListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "knowledgeonerecfind6")]
        [WorkflowExpressionFactory(nameof(__BuildQueryTable))]
        public IBodyWorkflowAction<JToken[]> QueryTable([WorkflowExpression] Func<string> hostUrl = null, [WorkflowExpression] Func<string> userName = null, [WorkflowExpression] Func<string> queryName = null, [WorkflowExpression] Func<string> searchText = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "knowledgeonerecfind6")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken[]> __BuildQueryTable(WorkflowExpression<string> hostUrl = null, WorkflowExpression<string> userName = null, WorkflowExpression<string> queryName = null, WorkflowExpression<string> searchText = null)
        {
            WorkflowExpression.Validate(hostUrl, nameof(hostUrl), required: false);
            WorkflowExpression.Validate(userName, nameof(userName), required: false);
            WorkflowExpression.Validate(queryName, nameof(queryName), required: false);
            WorkflowExpression.Validate(searchText, nameof(searchText), required: false);
            return new DeferredBodyAction<JToken[]>(() =>
            {
                var apiCallPath = "/QueryTable";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (hostUrl != null)
                    callPayload.Queries["HostUrl"] = ExpressionConverter.Convert(hostUrl);
                if (userName != null)
                    callPayload.Queries["UserName"] = ExpressionConverter.Convert(userName);
                if (queryName != null)
                    callPayload.Queries["QueryName"] = ExpressionConverter.Convert(queryName);
                if (searchText != null)
                    callPayload.Queries["SearchText"] = ExpressionConverter.Convert(searchText);
                return new ApiConnectionAction<JToken[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "knowledgeonerecfind6")]
        [WorkflowExpressionFactory(nameof(__BuildQueryData))]
        public IBodyWorkflowAction<QueryDataResponse> QueryData([WorkflowExpression] Func<string> hostUrl = null, [WorkflowExpression] Func<string> userName = null, [WorkflowExpression] Func<string> queryName = null, [WorkflowExpression] Func<int> startPosition = null, [WorkflowExpression] Func<int> numberOfRecords = null, [WorkflowExpression] Func<string> searchText = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "knowledgeonerecfind6")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<QueryDataResponse> __BuildQueryData(WorkflowExpression<string> hostUrl = null, WorkflowExpression<string> userName = null, WorkflowExpression<string> queryName = null, WorkflowExpression<int> startPosition = null, WorkflowExpression<int> numberOfRecords = null, WorkflowExpression<string> searchText = null)
        {
            WorkflowExpression.Validate(hostUrl, nameof(hostUrl), required: false);
            WorkflowExpression.Validate(userName, nameof(userName), required: false);
            WorkflowExpression.Validate(queryName, nameof(queryName), required: false);
            WorkflowExpression.Validate(startPosition, nameof(startPosition), required: false);
            WorkflowExpression.Validate(numberOfRecords, nameof(numberOfRecords), required: false);
            WorkflowExpression.Validate(searchText, nameof(searchText), required: false);
            return new DeferredBodyAction<QueryDataResponse>(() =>
            {
                var apiCallPath = "/QueryData";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (hostUrl != null)
                    callPayload.Queries["HostUrl"] = ExpressionConverter.Convert(hostUrl);
                if (userName != null)
                    callPayload.Queries["UserName"] = ExpressionConverter.Convert(userName);
                if (queryName != null)
                    callPayload.Queries["QueryName"] = ExpressionConverter.Convert(queryName);
                if (startPosition != null)
                    callPayload.Queries["StartPosition"] = ExpressionConverter.Convert(startPosition);
                if (numberOfRecords != null)
                    callPayload.Queries["NumberOfRecords"] = ExpressionConverter.Convert(numberOfRecords);
                if (searchText != null)
                    callPayload.Queries["SearchText"] = ExpressionConverter.Convert(searchText);
                return new ApiConnectionAction<QueryDataResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "knowledgeonerecfind6")]
        [WorkflowExpressionFactory(nameof(__BuildSavedSearch))]
        public IBodyWorkflowAction<JToken[]> SavedSearch([WorkflowExpression] Func<string> hostUrl = null, [WorkflowExpression] Func<string> userName = null, [WorkflowExpression] Func<string> savedSearchName = null, [WorkflowExpression] Func<string> queryParams = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "knowledgeonerecfind6")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken[]> __BuildSavedSearch(WorkflowExpression<string> hostUrl = null, WorkflowExpression<string> userName = null, WorkflowExpression<string> savedSearchName = null, WorkflowExpression<string> queryParams = null)
        {
            WorkflowExpression.Validate(hostUrl, nameof(hostUrl), required: false);
            WorkflowExpression.Validate(userName, nameof(userName), required: false);
            WorkflowExpression.Validate(savedSearchName, nameof(savedSearchName), required: false);
            WorkflowExpression.Validate(queryParams, nameof(queryParams), required: false);
            return new DeferredBodyAction<JToken[]>(() =>
            {
                var apiCallPath = "/SavedSearch";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (hostUrl != null)
                    callPayload.Queries["HostUrl"] = ExpressionConverter.Convert(hostUrl);
                if (userName != null)
                    callPayload.Queries["UserName"] = ExpressionConverter.Convert(userName);
                if (savedSearchName != null)
                    callPayload.Queries["SavedSearchName"] = ExpressionConverter.Convert(savedSearchName);
                if (queryParams != null)
                    callPayload.Queries["QueryParams"] = ExpressionConverter.Convert(queryParams);
                return new ApiConnectionAction<JToken[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "knowledgeonerecfind6")]
        [WorkflowExpressionFactory(nameof(__BuildSendFile))]
        public IBodyWorkflowAction<SendFileResponse> SendFile([WorkflowExpression] Func<string> hostUrl = null, [WorkflowExpression] Func<string> userName = null, [WorkflowExpression] Func<string> bodyfileContents = null, [WorkflowExpression] Func<string> bodyfileName = null, [WorkflowExpression] Func<string> bodytitle = null, [WorkflowExpression] Func<string> bodycreatedDate = null, [WorkflowExpression] Func<string> bodyeDOCType = null, [WorkflowExpression] Func<bodyextraFieldsInputItem[]> bodyextraFields = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "knowledgeonerecfind6")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SendFileResponse> __BuildSendFile(WorkflowExpression<string> hostUrl = null, WorkflowExpression<string> userName = null, WorkflowExpression<string> bodyfileContents = null, WorkflowExpression<string> bodyfileName = null, WorkflowExpression<string> bodytitle = null, WorkflowExpression<string> bodycreatedDate = null, WorkflowExpression<string> bodyeDOCType = null, WorkflowExpression<bodyextraFieldsInputItem[]> bodyextraFields = null)
        {
            WorkflowExpression.Validate(hostUrl, nameof(hostUrl), required: false);
            WorkflowExpression.Validate(userName, nameof(userName), required: false);
            WorkflowExpression.Validate(bodyfileContents, nameof(bodyfileContents), required: false);
            WorkflowExpression.Validate(bodyfileName, nameof(bodyfileName), required: false);
            WorkflowExpression.Validate(bodytitle, nameof(bodytitle), required: false);
            WorkflowExpression.Validate(bodycreatedDate, nameof(bodycreatedDate), required: false);
            WorkflowExpression.Validate(bodyeDOCType, nameof(bodyeDOCType), required: false);
            WorkflowExpression.Validate(bodyextraFields, nameof(bodyextraFields), required: false);
            return new DeferredBodyAction<SendFileResponse>(() =>
            {
                var apiCallPath = "/SendFile";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (hostUrl != null)
                    callPayload.Queries["HostUrl"] = ExpressionConverter.Convert(hostUrl);
                if (userName != null)
                    callPayload.Queries["UserName"] = ExpressionConverter.Convert(userName);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyfileContents != null)
                {
                    body["FileContents"] = ExpressionConverter.ConvertO(bodyfileContents);
                    bodypropCount++;
                }

                if (bodyfileName != null)
                {
                    body["FileName"] = ExpressionConverter.ConvertO(bodyfileName);
                    bodypropCount++;
                }

                if (bodytitle != null)
                {
                    body["Title"] = ExpressionConverter.ConvertO(bodytitle);
                    bodypropCount++;
                }

                if (bodycreatedDate != null)
                {
                    body["CreatedDate"] = ExpressionConverter.ConvertO(bodycreatedDate);
                    bodypropCount++;
                }

                if (bodyeDOCType != null)
                {
                    body["EDOCType"] = ExpressionConverter.ConvertO(bodyeDOCType);
                    bodypropCount++;
                }

                if (bodyextraFields != null)
                {
                    body["ExtraFields"] = ExpressionConverter.ConvertO(bodyextraFields);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<SendFileResponse>(callPayload);
            });
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