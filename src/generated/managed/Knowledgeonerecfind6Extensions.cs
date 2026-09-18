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
        public IBodyWorkflowAction<QueryListResponse> QueryList([WorkflowExpression] Func<string> hostUrl = null, [WorkflowExpression] Func<string> userName = null)
        {
            SourceExpression.Validate(hostUrl, nameof(hostUrl), required: false);
            SourceExpression.Validate(userName, nameof(userName), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/QueryList";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (hostUrl != null)
                    callPayload.Queries["HostUrl"] = SourceExpressionConverter.ConvertO(hostUrl);
                if (userName != null)
                    callPayload.Queries["UserName"] = SourceExpressionConverter.ConvertO(userName);
                return callPayload;
            }

            return new ApiConnectionAction<QueryListResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "knowledgeonerecfind6")]
        public IBodyWorkflowAction<JToken[]> QueryTable([WorkflowExpression] Func<string> hostUrl = null, [WorkflowExpression] Func<string> userName = null, [WorkflowExpression] Func<string> queryName = null, [WorkflowExpression] Func<string> searchText = null)
        {
            SourceExpression.Validate(hostUrl, nameof(hostUrl), required: false);
            SourceExpression.Validate(userName, nameof(userName), required: false);
            SourceExpression.Validate(queryName, nameof(queryName), required: false);
            SourceExpression.Validate(searchText, nameof(searchText), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/QueryTable";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (hostUrl != null)
                    callPayload.Queries["HostUrl"] = SourceExpressionConverter.ConvertO(hostUrl);
                if (userName != null)
                    callPayload.Queries["UserName"] = SourceExpressionConverter.ConvertO(userName);
                if (queryName != null)
                    callPayload.Queries["QueryName"] = SourceExpressionConverter.ConvertO(queryName);
                if (searchText != null)
                    callPayload.Queries["SearchText"] = SourceExpressionConverter.ConvertO(searchText);
                return callPayload;
            }

            return new ApiConnectionAction<JToken[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "knowledgeonerecfind6")]
        public IBodyWorkflowAction<QueryDataResponse> QueryData([WorkflowExpression] Func<string> hostUrl = null, [WorkflowExpression] Func<string> userName = null, [WorkflowExpression] Func<string> queryName = null, [WorkflowExpression] Func<int> startPosition = null, [WorkflowExpression] Func<int> numberOfRecords = null, [WorkflowExpression] Func<string> searchText = null)
        {
            SourceExpression.Validate(hostUrl, nameof(hostUrl), required: false);
            SourceExpression.Validate(userName, nameof(userName), required: false);
            SourceExpression.Validate(queryName, nameof(queryName), required: false);
            SourceExpression.Validate(startPosition, nameof(startPosition), required: false);
            SourceExpression.Validate(numberOfRecords, nameof(numberOfRecords), required: false);
            SourceExpression.Validate(searchText, nameof(searchText), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/QueryData";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (hostUrl != null)
                    callPayload.Queries["HostUrl"] = SourceExpressionConverter.ConvertO(hostUrl);
                if (userName != null)
                    callPayload.Queries["UserName"] = SourceExpressionConverter.ConvertO(userName);
                if (queryName != null)
                    callPayload.Queries["QueryName"] = SourceExpressionConverter.ConvertO(queryName);
                if (startPosition != null)
                    callPayload.Queries["StartPosition"] = SourceExpressionConverter.ConvertO(startPosition);
                if (numberOfRecords != null)
                    callPayload.Queries["NumberOfRecords"] = SourceExpressionConverter.ConvertO(numberOfRecords);
                if (searchText != null)
                    callPayload.Queries["SearchText"] = SourceExpressionConverter.ConvertO(searchText);
                return callPayload;
            }

            return new ApiConnectionAction<QueryDataResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "knowledgeonerecfind6")]
        public IBodyWorkflowAction<JToken[]> SavedSearch([WorkflowExpression] Func<string> hostUrl = null, [WorkflowExpression] Func<string> userName = null, [WorkflowExpression] Func<string> savedSearchName = null, [WorkflowExpression] Func<string> queryParams = null)
        {
            SourceExpression.Validate(hostUrl, nameof(hostUrl), required: false);
            SourceExpression.Validate(userName, nameof(userName), required: false);
            SourceExpression.Validate(savedSearchName, nameof(savedSearchName), required: false);
            SourceExpression.Validate(queryParams, nameof(queryParams), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/SavedSearch";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (hostUrl != null)
                    callPayload.Queries["HostUrl"] = SourceExpressionConverter.ConvertO(hostUrl);
                if (userName != null)
                    callPayload.Queries["UserName"] = SourceExpressionConverter.ConvertO(userName);
                if (savedSearchName != null)
                    callPayload.Queries["SavedSearchName"] = SourceExpressionConverter.ConvertO(savedSearchName);
                if (queryParams != null)
                    callPayload.Queries["QueryParams"] = SourceExpressionConverter.ConvertO(queryParams);
                return callPayload;
            }

            return new ApiConnectionAction<JToken[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "knowledgeonerecfind6")]
        public IBodyWorkflowAction<SendFileResponse> SendFile([WorkflowExpression] Func<string> hostUrl = null, [WorkflowExpression] Func<string> userName = null, [WorkflowExpression] Func<string> bodyfileContents = null, [WorkflowExpression] Func<string> bodyfileName = null, [WorkflowExpression] Func<string> bodytitle = null, [WorkflowExpression] Func<string> bodycreatedDate = null, [WorkflowExpression] Func<string> bodyeDOCType = null, [WorkflowExpression] Func<bodyextraFieldsInputItem[]> bodyextraFields = null)
        {
            SourceExpression.Validate(hostUrl, nameof(hostUrl), required: false);
            SourceExpression.Validate(userName, nameof(userName), required: false);
            SourceExpression.Validate(bodyfileContents, nameof(bodyfileContents), required: false);
            SourceExpression.Validate(bodyfileName, nameof(bodyfileName), required: false);
            SourceExpression.Validate(bodytitle, nameof(bodytitle), required: false);
            SourceExpression.Validate(bodycreatedDate, nameof(bodycreatedDate), required: false);
            SourceExpression.Validate(bodyeDOCType, nameof(bodyeDOCType), required: false);
            SourceExpression.Validate(bodyextraFields, nameof(bodyextraFields), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/SendFile";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (hostUrl != null)
                    callPayload.Queries["HostUrl"] = SourceExpressionConverter.ConvertO(hostUrl);
                if (userName != null)
                    callPayload.Queries["UserName"] = SourceExpressionConverter.ConvertO(userName);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyfileContents != null)
                {
                    body["FileContents"] = SourceExpressionConverter.ConvertToken(bodyfileContents);
                    bodypropCount++;
                }

                if (bodyfileName != null)
                {
                    body["FileName"] = SourceExpressionConverter.ConvertToken(bodyfileName);
                    bodypropCount++;
                }

                if (bodytitle != null)
                {
                    body["Title"] = SourceExpressionConverter.ConvertToken(bodytitle);
                    bodypropCount++;
                }

                if (bodycreatedDate != null)
                {
                    body["CreatedDate"] = SourceExpressionConverter.ConvertToken(bodycreatedDate);
                    bodypropCount++;
                }

                if (bodyeDOCType != null)
                {
                    body["EDOCType"] = SourceExpressionConverter.ConvertToken(bodyeDOCType);
                    bodypropCount++;
                }

                if (bodyextraFields != null)
                {
                    body["ExtraFields"] = SourceExpressionConverter.ConvertToken(bodyextraFields);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SendFileResponse>(BuildSourceInput);
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