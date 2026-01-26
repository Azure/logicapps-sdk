//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Blackbaudfenxtgenera
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class BlackbaudfenxtgeneraActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudfenxtgenera")]
        public IBodyWorkflowAction<GLApiJournalEntryBatchCollection> ListJournalEntryBatches(Expression<Func<statusInput>> status = null, Expression<Func<string>> searchText = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null, Expression<Func<string>> lastModified = null)
        {
            var apiCallPath = "/generalledger/v1/journalentrybatches";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (status != null)
                callPayload.Queries["status"] = ExpressionConverter.Convert(status);
            if (searchText != null)
                callPayload.Queries["search_text"] = ExpressionConverter.Convert(searchText);
            callPayload.Queries["limit"] = Convert.ToString(100);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (offset != null)
                callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
            if (lastModified != null)
                callPayload.Queries["last_modified"] = ExpressionConverter.Convert(lastModified);
            return new ApiConnectionAction<GLApiJournalEntryBatchCollection>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudfenxtgenera")]
        public IBodyWorkflowAction<GLApiCreatedJournalEntryBatch> CreateJournalEntryBatch(Expression<Func<string>> bodydescription, Expression<Func<bodystatusInput>> bodystatus, Expression<Func<bool>> bodycreateAdjustments = null, Expression<Func<bool>> bodyaddInterfundEntries = null, Expression<Func<string>> bodysourceSystemName = null, Expression<Func<string>> bodysourceBaseURL = null)
        {
            var apiCallPath = "/generalledger/v1/journalentrybatches";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["description"] = ExpressionConverter.ConvertO(bodydescription);
            bodypropCount++;
            body["batch_status"] = ExpressionConverter.ConvertO(bodystatus);
            if (bodycreateAdjustments != null)
            {
                body["create_bank_account_adjustments"] = ExpressionConverter.ConvertO(bodycreateAdjustments);
                bodypropCount++;
            }

            if (bodyaddInterfundEntries != null)
            {
                body["create_interfund_sets"] = ExpressionConverter.ConvertO(bodyaddInterfundEntries);
                bodypropCount++;
            }

            if (bodysourceSystemName != null)
            {
                body["source_system_name"] = ExpressionConverter.ConvertO(bodysourceSystemName);
                bodypropCount++;
            }

            if (bodysourceBaseURL != null)
            {
                body["source_base_url"] = ExpressionConverter.ConvertO(bodysourceBaseURL);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<GLApiCreatedJournalEntryBatch>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudfenxtgenera")]
        public IWorkflowAction DeleteJournalEntryBatch(Expression<Func<int>> batchId)
        {
            var apiCallPath = String.Format("/generalledger/v1/journalentrybatches/{0}", ExpressionConverter.ConvertWithUrlEncoding(batchId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudfenxtgenera")]
        public IBodyWorkflowAction<GLApiCreatedJournalEntryBatch> EditJournalEntryBatch(Expression<Func<int>> batchId, Expression<Func<string>> bodydescription = null, Expression<Func<bodystatusInput>> bodystatus = null, Expression<Func<bool>> bodycreateAdjustments = null, Expression<Func<bool>> bodyaddInterfundEntries = null, Expression<Func<string>> bodysourceSystemName = null, Expression<Func<string>> bodysourceBaseURL = null)
        {
            var apiCallPath = String.Format("/generalledger/v1/journalentrybatches/{0}", ExpressionConverter.ConvertWithUrlEncoding(batchId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodydescription != null)
            {
                body["description"] = ExpressionConverter.ConvertO(bodydescription);
                bodypropCount++;
            }

            if (bodystatus != null)
            {
                body["batch_status"] = ExpressionConverter.ConvertO(bodystatus);
                bodypropCount++;
            }

            if (bodycreateAdjustments != null)
            {
                body["create_bank_account_adjustments"] = ExpressionConverter.ConvertO(bodycreateAdjustments);
                bodypropCount++;
            }

            if (bodyaddInterfundEntries != null)
            {
                body["create_interfund_sets"] = ExpressionConverter.ConvertO(bodyaddInterfundEntries);
                bodypropCount++;
            }

            if (bodysourceSystemName != null)
            {
                body["source_system_name"] = ExpressionConverter.ConvertO(bodysourceSystemName);
                bodypropCount++;
            }

            if (bodysourceBaseURL != null)
            {
                body["source_base_url"] = ExpressionConverter.ConvertO(bodysourceBaseURL);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<GLApiCreatedJournalEntryBatch>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudfenxtgenera")]
        public IBodyWorkflowAction<GLApiJournalEntryCollection> ListJournalEntries(Expression<Func<int>> batchId, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null)
        {
            var apiCallPath = String.Format("/generalledger/v1/journalentrybatches/{0}/journalentries", ExpressionConverter.ConvertWithUrlEncoding(batchId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["limit"] = Convert.ToString(100);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (offset != null)
                callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
            return new ApiConnectionAction<GLApiJournalEntryCollection>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudfenxtgenera")]
        public IWorkflowAction ClearJournalEntries(Expression<Func<int>> batchId)
        {
            var apiCallPath = String.Format("/generalledger/v1/journalentrybatches/{0}/journalentries", ExpressionConverter.ConvertWithUrlEncoding(batchId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudfenxtgenera")]
        public IWorkflowAction CreateSimpleJournalEntry(Expression<Func<int>> batchId, Expression<Func<object>> body = null)
        {
            var apiCallPath = String.Format("/generalledger/v1/journalentrybatches/{0}/journalentries", ExpressionConverter.ConvertWithUrlEncoding(batchId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertO(body);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudfenxtgenera")]
        public IBodyWorkflowAction<GLApiValidationResult> PostJournalEntryBatch(Expression<Func<int>> batchId)
        {
            var apiCallPath = String.Format("/generalledger/v1/journalentrybatches/{0}/post", ExpressionConverter.ConvertWithUrlEncoding(batchId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GLApiValidationResult>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudfenxtgenera")]
        public IBodyWorkflowAction<GLApiJournalEntryBatchSummary> GetJournalEntryBatchSummary(Expression<Func<int>> batchId)
        {
            var apiCallPath = String.Format("/generalledger/v1/journalentrybatches/{0}/summary", ExpressionConverter.ConvertWithUrlEncoding(batchId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GLApiJournalEntryBatchSummary>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudfenxtgenera")]
        public IBodyWorkflowAction<GLApiValidationResult> ValidateJournalEntryBatch(Expression<Func<int>> batchId)
        {
            var apiCallPath = String.Format("/generalledger/v1/journalentrybatches/{0}/validate", ExpressionConverter.ConvertWithUrlEncoding(batchId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GLApiValidationResult>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudfenxtgenera")]
        public IBodyWorkflowAction<GLApiCreatedJournalEntryBatchAttachment> CreateJournalEntryBatchAttachment(Expression<Func<int>> bodybatchID, Expression<Func<bodytypeInput>> bodytype, Expression<Func<string>> bodyname, Expression<Func<string>> bodyattachmentType, Expression<Func<string>> bodyuRL = null, Expression<Func<string>> bodyfileContents = null, Expression<Func<string>> bodyfileName = null)
        {
            var apiCallPath = "/generalledger/v1/journalentrybatches/attachments";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["parent_id"] = ExpressionConverter.ConvertO(bodybatchID);
            bodypropCount++;
            body["type"] = ExpressionConverter.ConvertO(bodytype);
            bodypropCount++;
            body["name"] = ExpressionConverter.ConvertO(bodyname);
            if (bodyuRL != null)
            {
                body["url"] = ExpressionConverter.ConvertO(bodyuRL);
                bodypropCount++;
            }

            if (bodyfileContents != null)
            {
                body["file"] = ExpressionConverter.ConvertO(bodyfileContents);
                bodypropCount++;
            }

            if (bodyfileName != null)
            {
                body["file_name"] = ExpressionConverter.ConvertO(bodyfileName);
                bodypropCount++;
            }

            bodypropCount++;
            body["media_type"] = ExpressionConverter.ConvertO(bodyattachmentType);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<GLApiCreatedJournalEntryBatchAttachment>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudfenxtgenera")]
        public IWorkflowAction CreateSplitJournalEntry(Expression<Func<int>> batchId, Expression<Func<object>> body = null)
        {
            var apiCallPath = String.Format("/generalledger/v1/virtual/journalentrybatches/{0}/splitjournalentries", ExpressionConverter.ConvertWithUrlEncoding(batchId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertO(body);
            return new ApiConnectionAction(callPayload);
        }
    }

    public class BlackbaudfenxtgeneraTriggers([ConnectionName] string connectionId)
    {
    }

    public class GLApiJournalEntryBatchCollection
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public GLApiJournalEntryBatch[] Value { get; set; }
    }

    public class GLApiJournalEntryBatch
    {
        [JsonProperty("batch_id")]
        public int BatchID { get; set; }

        [JsonProperty("ui_batch_id")]
        public string UIBatchID { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("batch_status")]
        public GLApiJournalEntryBatchStatusType Status { get; set; }

        [JsonProperty("create_bank_account_adjustments")]
        public bool CreateAdjustments { get; set; }

        [JsonProperty("create_interfund_sets")]
        public bool AddInterfundEntries { get; set; }

        [JsonProperty("source_system_name")]
        public string SourceSystemName { get; set; }

        [JsonProperty("source_base_url")]
        public string SourceBaseURL { get; set; }

        [JsonProperty("date_added")]
        public string DateAdded { get; set; }

        [JsonProperty("added_by")]
        public string AddedBy { get; set; }

        [JsonProperty("date_modified")]
        public string DateModified { get; set; }

        [JsonProperty("modified_by")]
        public string ModifiedBy { get; set; }
    }

    public enum GLApiJournalEntryBatchStatusType
    {
        Open,
        PendingApproval,
        Approved,
        Posted,
        Deleted
    }

    public enum statusInput
    {
        Open,
        PendingApproval,
        Approved,
        Posted,
        Deleted
    }

    public class GLApiCreatedJournalEntryBatch
    {
        [JsonProperty("record_id")]
        public int ID { get; set; }
    }

    public enum bodystatusInput
    {
        Open,
        PendingApproval,
        Approved,
        Posted,
        Deleted
    }

    public class GLApiJournalEntryCollection
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public GLApiJournalEntry[] Value { get; set; }
    }

    public class GLApiJournalEntry
    {
        [JsonProperty("journal_entry_id")]
        public int JournalEntryID { get; set; }
    }

    public class GLApiValidationResult
    {
        [JsonProperty("is_valid")]
        public bool IsValid { get; set; }

        [JsonProperty("errors")]
        public string[] Errors { get; set; }
    }

    public class GLApiJournalEntryBatchSummary
    {
        [JsonProperty("BatchId")]
        public int BatchID { get; set; }

        [JsonProperty("UiBatchId")]
        public string UIBatchID { get; set; }
        public string Description { get; set; }

        [JsonProperty("BatchStatus")]
        public GLApiJournalEntryBatchSummaryStatusType Status { get; set; }

        [JsonProperty("CreateBankAccountAdjustments")]
        public bool CreateAdjustments { get; set; }

        [JsonProperty("CreateInterfundSets")]
        public bool AddInterfundEntries { get; set; }
        public double TotalCredits { get; set; }
        public double TotalDebits { get; set; }

        [JsonProperty("SourceBaseUrl")]
        public string SourceBaseURL { get; set; }
        public string SourceSystemName { get; set; }
        public string DateAdded { get; set; }
        public string AddedBy { get; set; }
        public string DateModified { get; set; }
        public string ModifiedBy { get; set; }
    }

    public enum GLApiJournalEntryBatchSummaryStatusType
    {
        Open,
        PendingApproval,
        Approved,
        Posted,
        Deleted
    }

    public class GLApiCreatedJournalEntryBatchAttachment
    {
        [JsonProperty("record_id")]
        public int ID { get; set; }
    }

    public enum bodytypeInput
    {
        Link,
        Physical
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Blackbaudfenxtgenera;

    public partial class WorkflowManagedActions
    {
        public BlackbaudfenxtgeneraActions Blackbaudfenxtgenera(string connectionId) => new BlackbaudfenxtgeneraActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public BlackbaudfenxtgeneraTriggers Blackbaudfenxtgenera(string connectionId) => new BlackbaudfenxtgeneraTriggers(connectionId);
    }
}