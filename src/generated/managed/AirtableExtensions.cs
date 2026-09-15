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
        public IBodyWorkflowAction<ListRecordsResponse> ListRecords(Expression<Func<string>> baseID, Expression<Func<string>> table, Expression<Func<string>> filterByFormula = null, Expression<Func<int>> maxRecords = null, Expression<Func<int>> pageSize = null, Expression<Func<string>> view = null, Expression<Func<string>> cellFormat = null, Expression<Func<string>> timeZone = null, Expression<Func<string>> userLocale = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/{0}/{1}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(baseID, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (filterByFormula != null)
                callPayload.Queries["filterByFormula"] = CSharpExpressionConverter.ConvertO(filterByFormula);
            if (maxRecords != null)
                callPayload.Queries["maxRecords"] = CSharpExpressionConverter.ConvertO(maxRecords);
            if (pageSize != null)
                callPayload.Queries["pageSize"] = CSharpExpressionConverter.ConvertO(pageSize);
            if (view != null)
                callPayload.Queries["view"] = CSharpExpressionConverter.ConvertO(view);
            if (cellFormat != null)
                callPayload.Queries["cellFormat"] = CSharpExpressionConverter.ConvertO(cellFormat);
            if (timeZone != null)
                callPayload.Queries["timeZone"] = CSharpExpressionConverter.ConvertO(timeZone);
            if (userLocale != null)
                callPayload.Queries["userLocale"] = CSharpExpressionConverter.ConvertO(userLocale);
            return new ApiConnectionAction<ListRecordsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "airtable")]
        public IBodyWorkflowAction<CreateaRecordResponse> CreateaRecord(Expression<Func<string>> baseID, Expression<Func<string>> table)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/{0}/{1}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(baseID, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            var body = new JObject();
            var bodypropCount = 0;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<CreateaRecordResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "airtable")]
        public IBodyWorkflowAction<RetrieveaRecordResponse> RetrieveaRecord(Expression<Func<string>> baseID, Expression<Func<string>> table, Expression<Func<string>> recordID)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/{0}/{1}/{2}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(baseID, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(recordID, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<RetrieveaRecordResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "airtable")]
        public IBodyWorkflowAction<DeleteaRecordResponse> DeleteaRecord(Expression<Func<string>> baseID, Expression<Func<string>> table, Expression<Func<string>> recordID)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/{0}/{1}/{2}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(baseID, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(recordID, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<DeleteaRecordResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "airtable")]
        public IBodyWorkflowAction<UpdateaRecordResponse> UpdateaRecord(Expression<Func<string>> baseID, Expression<Func<string>> table, Expression<Func<string>> recordID, Expression<Func<string>> contentType = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/{0}/{1}/{2}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(baseID, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(recordID, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (contentType != null)
                callPayload.Headers["Content-Type"] = CSharpExpressionConverter.ConvertO(contentType);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<UpdateaRecordResponse>(callPayload);
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