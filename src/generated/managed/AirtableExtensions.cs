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
        [WorkflowExpressionFactory(nameof(__BuildListRecords))]
        public IBodyWorkflowAction<ListRecordsResponse> ListRecords([WorkflowExpression] Func<string> baseID, [WorkflowExpression] Func<string> table, [WorkflowExpression] Func<string> filterByFormula = null, [WorkflowExpression] Func<int> maxRecords = null, [WorkflowExpression] Func<int> pageSize = null, [WorkflowExpression] Func<string> view = null, [WorkflowExpression] Func<string> cellFormat = null, [WorkflowExpression] Func<string> timeZone = null, [WorkflowExpression] Func<string> userLocale = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ListRecordsResponse> __BuildListRecords(WorkflowExpression<string> baseID, WorkflowExpression<string> table, WorkflowExpression<string> filterByFormula = null, WorkflowExpression<int> maxRecords = null, WorkflowExpression<int> pageSize = null, WorkflowExpression<string> view = null, WorkflowExpression<string> cellFormat = null, WorkflowExpression<string> timeZone = null, WorkflowExpression<string> userLocale = null)
        {
            WorkflowExpression.Validate(baseID, nameof(baseID), required: true);
            WorkflowExpression.Validate(table, nameof(table), required: true);
            WorkflowExpression.Validate(filterByFormula, nameof(filterByFormula), required: false);
            WorkflowExpression.Validate(maxRecords, nameof(maxRecords), required: false);
            WorkflowExpression.Validate(pageSize, nameof(pageSize), required: false);
            WorkflowExpression.Validate(view, nameof(view), required: false);
            WorkflowExpression.Validate(cellFormat, nameof(cellFormat), required: false);
            WorkflowExpression.Validate(timeZone, nameof(timeZone), required: false);
            WorkflowExpression.Validate(userLocale, nameof(userLocale), required: false);
            return new DeferredBodyAction<ListRecordsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/{1}", ExpressionConverter.ConvertWithUrlEncoding(baseID, 1), ExpressionConverter.ConvertWithUrlEncoding(table, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "airtable")]
        [WorkflowExpressionFactory(nameof(__BuildCreateaRecord))]
        public IBodyWorkflowAction<CreateaRecordResponse> CreateaRecord([WorkflowExpression] Func<string> baseID, [WorkflowExpression] Func<string> table)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateaRecordResponse> __BuildCreateaRecord(WorkflowExpression<string> baseID, WorkflowExpression<string> table)
        {
            WorkflowExpression.Validate(baseID, nameof(baseID), required: true);
            WorkflowExpression.Validate(table, nameof(table), required: true);
            return new DeferredBodyAction<CreateaRecordResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/{1}", ExpressionConverter.ConvertWithUrlEncoding(baseID, 1), ExpressionConverter.ConvertWithUrlEncoding(table, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "airtable")]
        [WorkflowExpressionFactory(nameof(__BuildRetrieveaRecord))]
        public IBodyWorkflowAction<RetrieveaRecordResponse> RetrieveaRecord([WorkflowExpression] Func<string> baseID, [WorkflowExpression] Func<string> table, [WorkflowExpression] Func<string> recordID)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<RetrieveaRecordResponse> __BuildRetrieveaRecord(WorkflowExpression<string> baseID, WorkflowExpression<string> table, WorkflowExpression<string> recordID)
        {
            WorkflowExpression.Validate(baseID, nameof(baseID), required: true);
            WorkflowExpression.Validate(table, nameof(table), required: true);
            WorkflowExpression.Validate(recordID, nameof(recordID), required: true);
            return new DeferredBodyAction<RetrieveaRecordResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/{1}/{2}", ExpressionConverter.ConvertWithUrlEncoding(baseID, 1), ExpressionConverter.ConvertWithUrlEncoding(table, 1), ExpressionConverter.ConvertWithUrlEncoding(recordID, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<RetrieveaRecordResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "airtable")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteaRecord))]
        public IBodyWorkflowAction<DeleteaRecordResponse> DeleteaRecord([WorkflowExpression] Func<string> baseID, [WorkflowExpression] Func<string> table, [WorkflowExpression] Func<string> recordID)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DeleteaRecordResponse> __BuildDeleteaRecord(WorkflowExpression<string> baseID, WorkflowExpression<string> table, WorkflowExpression<string> recordID)
        {
            WorkflowExpression.Validate(baseID, nameof(baseID), required: true);
            WorkflowExpression.Validate(table, nameof(table), required: true);
            WorkflowExpression.Validate(recordID, nameof(recordID), required: true);
            return new DeferredBodyAction<DeleteaRecordResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/{1}/{2}", ExpressionConverter.ConvertWithUrlEncoding(baseID, 1), ExpressionConverter.ConvertWithUrlEncoding(table, 1), ExpressionConverter.ConvertWithUrlEncoding(recordID, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<DeleteaRecordResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "airtable")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateaRecord))]
        public IBodyWorkflowAction<UpdateaRecordResponse> UpdateaRecord([WorkflowExpression] Func<string> baseID, [WorkflowExpression] Func<string> table, [WorkflowExpression] Func<string> recordID, [WorkflowExpression] Func<string> contentType = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<UpdateaRecordResponse> __BuildUpdateaRecord(WorkflowExpression<string> baseID, WorkflowExpression<string> table, WorkflowExpression<string> recordID, WorkflowExpression<string> contentType = null)
        {
            WorkflowExpression.Validate(baseID, nameof(baseID), required: true);
            WorkflowExpression.Validate(table, nameof(table), required: true);
            WorkflowExpression.Validate(recordID, nameof(recordID), required: true);
            WorkflowExpression.Validate(contentType, nameof(contentType), required: false);
            return new DeferredBodyAction<UpdateaRecordResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/{1}/{2}", ExpressionConverter.ConvertWithUrlEncoding(baseID, 1), ExpressionConverter.ConvertWithUrlEncoding(table, 1), ExpressionConverter.ConvertWithUrlEncoding(recordID, 1));
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
            });
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