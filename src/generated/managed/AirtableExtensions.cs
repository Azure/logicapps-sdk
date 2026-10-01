//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Airtable
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AirtableActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "airtable")]
        public IBodyWorkflowAction<ListRecordsResponse> ListRecords([WorkflowExpression] Func<string> baseId, [WorkflowExpression] Func<string> table, [WorkflowExpression] Func<string> filterByFormula = null, [WorkflowExpression] Func<int> maxRecords = null, [WorkflowExpression] Func<int> pageSize = null, [WorkflowExpression] Func<string> view = null, [WorkflowExpression] Func<string> cellFormat = null, [WorkflowExpression] Func<string> timeZone = null, [WorkflowExpression] Func<string> userLocale = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(baseId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (filterByFormula != null)
                    callPayload.Queries["filterByFormula"] = SourceExpressionConverter.ConvertO(filterByFormula);
                if (maxRecords != null)
                    callPayload.Queries["maxRecords"] = SourceExpressionConverter.ConvertO(maxRecords);
                if (pageSize != null)
                    callPayload.Queries["pageSize"] = SourceExpressionConverter.ConvertO(pageSize);
                if (view != null)
                    callPayload.Queries["view"] = SourceExpressionConverter.ConvertO(view);
                if (cellFormat != null)
                    callPayload.Queries["cellFormat"] = SourceExpressionConverter.ConvertO(cellFormat);
                if (timeZone != null)
                    callPayload.Queries["timeZone"] = SourceExpressionConverter.ConvertO(timeZone);
                if (userLocale != null)
                    callPayload.Queries["userLocale"] = SourceExpressionConverter.ConvertO(userLocale);
                return callPayload;
            }

            return new ApiConnectionAction<ListRecordsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "airtable")]
        public IBodyWorkflowAction<CreateaRecordResponse> CreateaRecord([WorkflowExpression] Func<string> baseId, [WorkflowExpression] Func<string> table)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(baseId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CreateaRecordResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "airtable")]
        public IBodyWorkflowAction<RetrieveaRecordResponse> RetrieveaRecord([WorkflowExpression] Func<string> baseId, [WorkflowExpression] Func<string> table, [WorkflowExpression] Func<string> recordId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/{1}/{2}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(baseId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(recordId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<RetrieveaRecordResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "airtable")]
        public IBodyWorkflowAction<DeleteaRecordResponse> DeleteaRecord([WorkflowExpression] Func<string> baseId, [WorkflowExpression] Func<string> table, [WorkflowExpression] Func<string> recordId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/{1}/{2}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(baseId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(recordId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<DeleteaRecordResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "airtable")]
        public IBodyWorkflowAction<UpdateaRecordResponse> UpdateaRecord([WorkflowExpression] Func<string> baseId, [WorkflowExpression] Func<string> table, [WorkflowExpression] Func<string> recordId, [WorkflowExpression] Func<string> contentType = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/{1}/{2}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(baseId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(recordId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (contentType != null)
                    callPayload.Headers["Content-Type"] = SourceExpressionConverter.ConvertO(contentType);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<UpdateaRecordResponse>(BuildSourceInput);
        }
    }

    public class AirtableTriggers([ConnectionName] string connectionId)
    {
    }

    public class ListRecordsResponse
    {
        [JsonProperty("records")]
        public ListRecordsResponseRecordsTypeItem[] Records { get; set; }
    }

    public class ListRecordsResponseRecordsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("createdTime")]
        public string CreatedTime { get; set; }
    }

    public class CreateaRecordResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("createdTime")]
        public string CreatedTime { get; set; }
    }

    public class RetrieveaRecordResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("createdTime")]
        public string CreatedTime { get; set; }
    }

    public class DeleteaRecordResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("deleted")]
        public bool Deleted { get; set; }

        [JsonProperty("error")]
        public DeleteaRecordResponseErrorType Error { get; set; }
    }

    public class DeleteaRecordResponseErrorType
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public class UpdateaRecordResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("createdTime")]
        public string CreatedTime { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Airtable;

    public partial class WorkflowManagedActions
    {
        public AirtableActions Airtable(string connectionId) => new AirtableActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public AirtableTriggers Airtable(string connectionId) => new AirtableTriggers(connectionId);
    }
}