//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Knowledgeonerecfind6
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class Knowledgeonerecfind6Actions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "knowledgeonerecfind6")]
        public IBodyWorkflowAction<QueryListResponse> QueryList(Expression<Func<string>> hostUrl = null, Expression<Func<string>> userName = null)
        {
            var apiCallPath = "/QueryList";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (hostUrl != null)
                callPayload.Queries["HostUrl"] = ExpressionConverter.Convert(hostUrl);
            if (userName != null)
                callPayload.Queries["UserName"] = ExpressionConverter.Convert(userName);
            return new ApiConnectionAction<QueryListResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "knowledgeonerecfind6")]
        public IBodyWorkflowAction<JToken[]> QueryTable(Expression<Func<string>> hostUrl = null, Expression<Func<string>> userName = null, Expression<Func<string>> queryName = null, Expression<Func<string>> searchText = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "knowledgeonerecfind6")]
        public IBodyWorkflowAction<QueryDataResponse> QueryData(Expression<Func<string>> hostUrl = null, Expression<Func<string>> userName = null, Expression<Func<string>> queryName = null, Expression<Func<int>> startPosition = null, Expression<Func<int>> numberOfRecords = null, Expression<Func<string>> searchText = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "knowledgeonerecfind6")]
        public IBodyWorkflowAction<JToken[]> SavedSearch(Expression<Func<string>> hostUrl = null, Expression<Func<string>> userName = null, Expression<Func<string>> savedSearchName = null, Expression<Func<string>> queryParams = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "knowledgeonerecfind6")]
        public IBodyWorkflowAction<SendFileResponse> SendFile(Expression<Func<string>> hostUrl = null, Expression<Func<string>> userName = null, Expression<Func<string>> bodyfileContents = null, Expression<Func<string>> bodyfileName = null, Expression<Func<string>> bodytitle = null, Expression<Func<string>> bodycreatedDate = null, Expression<Func<string>> bodyeDOCType = null, Expression<Func<bodyextraFieldsInputItem[]>> bodyextraFields = null)
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