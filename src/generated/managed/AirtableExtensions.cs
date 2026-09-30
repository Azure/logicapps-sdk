//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Airtable
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AirtableActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "airtable")]
        public IBodyWorkflowAction<ListRecordsResponse> ListRecords([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> baseID, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> table, [WorkflowExpression] Func<string> filterByFormula = null, [WorkflowExpression] Func<int> maxRecords = null, [WorkflowExpression] Func<int> pageSize = null, [WorkflowExpression] Func<string> view = null, [WorkflowExpression] Func<string> cellFormat = null, [WorkflowExpression] Func<string> timeZone = null, [WorkflowExpression] Func<string> userLocale = null)
        {
            var apiCallPath = String.Format("/{0}/{1}", ExpressionConverter.ConvertWithUrlEncoding(baseID, 1), ExpressionConverter.ConvertWithUrlEncoding(table, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (filterByFormula != null)
                callPayload.Queries["filterByFormula"] = ExpressionConverter.Convert(filterByFormula);
            if (maxRecords != null)
                callPayload.Queries["maxRecords"] = ExpressionConverter.Convert(maxRecords);
            if (pageSize != null)
                callPayload.Queries["pageSize"] = ExpressionConverter.Convert(pageSize);
            if (view != null)
                callPayload.Queries["view"] = ExpressionConverter.Convert(view);
            if (cellFormat != null)
                callPayload.Queries["cellFormat"] = ExpressionConverter.Convert(cellFormat);
            if (timeZone != null)
                callPayload.Queries["timeZone"] = ExpressionConverter.Convert(timeZone);
            if (userLocale != null)
                callPayload.Queries["userLocale"] = ExpressionConverter.Convert(userLocale);
            return new ApiConnectionAction<ListRecordsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "airtable")]
        public IBodyWorkflowAction<CreateaRecordResponse> CreateaRecord([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> baseID, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> table)
        {
            var apiCallPath = String.Format("/{0}/{1}", ExpressionConverter.ConvertWithUrlEncoding(baseID, 1), ExpressionConverter.ConvertWithUrlEncoding(table, 1));
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
        public IBodyWorkflowAction<RetrieveaRecordResponse> RetrieveaRecord([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> baseID, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> table, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> recordID)
        {
            var apiCallPath = String.Format("/{0}/{1}/{2}", ExpressionConverter.ConvertWithUrlEncoding(baseID, 1), ExpressionConverter.ConvertWithUrlEncoding(table, 1), ExpressionConverter.ConvertWithUrlEncoding(recordID, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<RetrieveaRecordResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "airtable")]
        public IBodyWorkflowAction<DeleteaRecordResponse> DeleteaRecord([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> baseID, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> table, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> recordID)
        {
            var apiCallPath = String.Format("/{0}/{1}/{2}", ExpressionConverter.ConvertWithUrlEncoding(baseID, 1), ExpressionConverter.ConvertWithUrlEncoding(table, 1), ExpressionConverter.ConvertWithUrlEncoding(recordID, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<DeleteaRecordResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "airtable")]
        public IBodyWorkflowAction<UpdateaRecordResponse> UpdateaRecord([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> baseID, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> table, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> recordID, [WorkflowExpression] Func<string> contentType = null)
        {
            var apiCallPath = String.Format("/{0}/{1}/{2}", ExpressionConverter.ConvertWithUrlEncoding(baseID, 1), ExpressionConverter.ConvertWithUrlEncoding(table, 1), ExpressionConverter.ConvertWithUrlEncoding(recordID, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (contentType != null)
                callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(contentType);
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