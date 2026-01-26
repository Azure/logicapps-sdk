//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Oodrivesign
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class OodrivesignActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "oodrivesign")]
        public IBodyWorkflowAction<Contract[]> ListAllContracts(Expression<Func<int>> size = null, Expression<Func<int>> offset = null, Expression<Func<bool>> getProperties = null, Expression<Func<bool>> getPerimeters = null, Expression<Func<int>> before = null, Expression<Func<int>> after = null, Expression<Func<string>> perimeter = null, Expression<Func<statusInputItem[]>> status = null)
        {
            var apiCallPath = "/contracts";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (size != null)
                callPayload.Queries["size"] = ExpressionConverter.Convert(size);
            if (offset != null)
                callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
            if (getProperties != null)
                callPayload.Queries["get_properties"] = ExpressionConverter.Convert(getProperties);
            if (getPerimeters != null)
                callPayload.Queries["get_perimeters"] = ExpressionConverter.Convert(getPerimeters);
            if (before != null)
                callPayload.Queries["before"] = ExpressionConverter.Convert(before);
            if (after != null)
                callPayload.Queries["after"] = ExpressionConverter.Convert(after);
            if (perimeter != null)
                callPayload.Queries["perimeter"] = ExpressionConverter.Convert(perimeter);
            if (status != null)
                callPayload.Queries["status"] = ExpressionConverter.Convert(status);
            return new ApiConnectionAction<Contract[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "oodrivesign")]
        public IBodyWorkflowAction<Contract> CreateNewContract(Expression<Func<string>> bodynameOfTheContract = null, Expression<Func<int>> bodycontractDefinitionID = null, Expression<Func<string>> bodyvendorEmail = null, Expression<Func<int>> bodydateOfCreation = null, Expression<Func<string>> bodymessageTitle = null, Expression<Func<string>> bodymessageBody = null, Expression<Func<bool>> bodykeepOnMove = null, Expression<Func<int>> bodyautoClose = null, Expression<Func<bool>> bodysequential = null, Expression<Func<string>> bodycustomerNumber = null, Expression<Func<string[]>> bodylistOfPerimeter = null, Expression<Func<bodyoptionInputItem[]>> bodyoption = null, Expression<Func<ContractProperty[]>> bodycustomProperties = null)
        {
            var apiCallPath = "/contracts";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodynameOfTheContract != null)
            {
                body["name"] = ExpressionConverter.ConvertO(bodynameOfTheContract);
                bodypropCount++;
            }

            if (bodycontractDefinitionID != null)
            {
                body["contract_definition_id"] = ExpressionConverter.ConvertO(bodycontractDefinitionID);
                bodypropCount++;
            }

            if (bodyvendorEmail != null)
            {
                body["vendor_email"] = ExpressionConverter.ConvertO(bodyvendorEmail);
                bodypropCount++;
            }

            if (bodydateOfCreation != null)
            {
                body["date"] = ExpressionConverter.ConvertO(bodydateOfCreation);
                bodypropCount++;
            }

            if (bodymessageTitle != null)
            {
                body["message_title"] = ExpressionConverter.ConvertO(bodymessageTitle);
                bodypropCount++;
            }

            if (bodymessageBody != null)
            {
                body["message_body"] = ExpressionConverter.ConvertO(bodymessageBody);
                bodypropCount++;
            }

            if (bodykeepOnMove != null)
            {
                body["keep_on_move"] = ExpressionConverter.ConvertO(bodykeepOnMove);
                bodypropCount++;
            }

            if (bodyautoClose != null)
            {
                body["auto_close"] = ExpressionConverter.ConvertO(bodyautoClose);
                bodypropCount++;
            }

            if (bodysequential != null)
            {
                body["sequential"] = ExpressionConverter.ConvertO(bodysequential);
                bodypropCount++;
            }

            if (bodycustomerNumber != null)
            {
                body["customer_number"] = ExpressionConverter.ConvertO(bodycustomerNumber);
                bodypropCount++;
            }

            if (bodylistOfPerimeter != null)
            {
                body["perimeters"] = ExpressionConverter.ConvertO(bodylistOfPerimeter);
                bodypropCount++;
            }

            if (bodyoption != null)
            {
                body["options"] = ExpressionConverter.ConvertO(bodyoption);
                bodypropCount++;
            }

            if (bodycustomProperties != null)
            {
                body["contract_properties"] = ExpressionConverter.ConvertO(bodycustomProperties);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<Contract>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "oodrivesign")]
        public IBodyWorkflowAction<Transaction> GetContractStatus(Expression<Func<int>> id)
        {
            var apiCallPath = String.Format("/contracts/{0}/transaction/", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<Transaction>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "oodrivesign")]
        public IBodyWorkflowAction<DocumentAdded[]> UploadDocumentAndAttachToContract(Expression<Func<string>> id, Expression<Func<object>> file = null)
        {
            var apiCallPath = String.Format("/contracts/{0}/documents/", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("multipart/form-data; boundary=abcde");
            return new ApiConnectionAction<DocumentAdded[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "oodrivesign")]
        public IBodyWorkflowAction<object> DownloadContractDocuments(Expression<Func<string>> id, Expression<Func<string>> filename = null)
        {
            var apiCallPath = String.Format("/contracts/{0}/documentresult/", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["filename"] = Convert.ToString("contract.pdf");
            if (filename != null)
                callPayload.Queries["filename"] = ExpressionConverter.Convert(filename);
            callPayload.Headers["Accept"] = Convert.ToString("application/pdf");
            return new ApiConnectionAction<object>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "oodrivesign")]
        public IBodyWorkflowAction<ContractRecipient[]> ListContractRecipients(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/contracts/{0}/recipients/", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Accept"] = Convert.ToString("application/json");
            return new ApiConnectionAction<ContractRecipient[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "oodrivesign")]
        public IBodyWorkflowAction<object> DownloadProofFileContract(Expression<Func<string>> id, Expression<Func<string>> filename = null)
        {
            var apiCallPath = String.Format("/contracts/{0}/transaction/prooffiles", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["filename"] = Convert.ToString("proof.zip");
            if (filename != null)
                callPayload.Queries["filename"] = ExpressionConverter.Convert(filename);
            callPayload.Headers["Accept"] = Convert.ToString("application/zip");
            return new ApiConnectionAction<object>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "oodrivesign")]
        public IBodyWorkflowAction<DeleteRecipientForContractResponse> DeleteRecipientForContract(Expression<Func<string>> cfcId)
        {
            var apiCallPath = String.Format("/contracts/recipients/{0}", ExpressionConverter.ConvertWithUrlEncoding(cfcId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<DeleteRecipientForContractResponse>(callPayload);
        }
    }

    public class OodrivesignTriggers([ConnectionName] string connectionId)
    {
    }

    public class Contract
    {
        [JsonProperty("contract_id")]
        public int ContractID { get; set; }

        [JsonProperty("date")]
        public int CreationDate { get; set; }

        [JsonProperty("document_token")]
        public string DocumentToken { get; set; }

        [JsonProperty("vendor_email")]
        public string VendorEMailAddress { get; set; }

        [JsonProperty("closed")]
        public bool IsClosed { get; set; }

        [JsonProperty("status")]
        public string ContractStatus { get; set; }

        [JsonProperty("contract_definition_id")]
        public int ContractDefinitionID { get; set; }

        [JsonProperty("message_title")]
        public string MessageSubject { get; set; }

        [JsonProperty("message_body")]
        public string MessageBody { get; set; }

        [JsonProperty("name")]
        public string ContractName { get; set; }

        [JsonProperty("keep_on_move")]
        public bool OfflineSignatureActivated { get; set; }

        [JsonProperty("closed_date")]
        public int ContractClosedDate { get; set; }

        [JsonProperty("canceled_reason")]
        public string ContractCanceledReason { get; set; }

        [JsonProperty("version_number")]
        public int ContractVersionNumber { get; set; }

        [JsonProperty("size")]
        public int ContractSize { get; set; }

        [JsonProperty("auto_close")]
        public int AutoCloseEnabled { get; set; }

        [JsonProperty("deleted")]
        public int IsDeleted { get; set; }

        [JsonProperty("perimeters")]
        public string[] Perimeters { get; set; }

        [JsonProperty("options")]
        public ContractOption[] Options { get; set; }

        [JsonProperty("contract_properties")]
        public ContractProperty[] CustomProperties { get; set; }
    }

    public class ContractOption
    {
        [JsonProperty("id")]
        public int OptionID { get; set; }

        [JsonProperty("contract_id")]
        public int ContractID { get; set; }

        [JsonProperty("element_definition_id")]
        public int ElementDefinitionID { get; set; }

        [JsonProperty("sync_timer")]
        public int SyncTimer { get; set; }

        [JsonProperty("value")]
        public string OptionValue { get; set; }

        [JsonProperty("last_modification_place")]
        public string LastModificationPlace { get; set; }

        [JsonProperty("control")]
        public string OptionControl { get; set; }
    }

    public class ContractProperty
    {
        [JsonProperty("id")]
        public int PropertyID { get; set; }

        [JsonProperty("key")]
        public string PropertyKey { get; set; }

        [JsonProperty("placeholder")]
        public string PropertyPlaceholder { get; set; }

        [JsonProperty("value")]
        public string PropertyValue { get; set; }

        [JsonProperty("contract_id")]
        public int PropertyContractID { get; set; }

        [JsonProperty("required")]
        public bool PropertyIsRequired { get; set; }

        [JsonProperty("field_type")]
        public ContractPropertyPropertyTypeType PropertyType { get; set; }

        [JsonProperty("input_filter")]
        public string PropertyChoices { get; set; }

        [JsonProperty("logical_removed")]
        public bool PropertyLogicallyRemoved { get; set; }

        [JsonProperty("used_by_contract")]
        public bool PropertyIsUsedByContract { get; set; }
    }

    public enum ContractPropertyPropertyTypeType
    {
        TEXT,
        TEXTAREA,
        NUMBER,
        DATE,
        SINGLE,
        IMAGE
    }

    public enum statusInputItem
    {
        OPEN,
        CLOSED,
        SIGNED,
        PENDING,
        ARCHIVED,
        ABANDONED
    }

    public class bodyoptionInputItem
    {
        [JsonProperty("element_definition_id")]
        public int ElementDefinitionID { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class Transaction
    {
        [JsonProperty("transaction_id")]
        public string TransactionId { get; set; }

        [JsonProperty("is_closed")]
        public bool IsClosed { get; set; }

        [JsonProperty("contract_name")]
        public string ContractName { get; set; }

        [JsonProperty("status")]
        public TransactionStatusType Status { get; set; }
    }

    public enum TransactionStatusType
    {
        OPEN,
        CLOSED,
        SIGNED,
        PENDING,
        ARCHIVED,
        ABANDONED
    }

    public class DocumentAdded
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("rank")]
        public int Rank { get; set; }

        [JsonProperty("has_smart_field")]
        public bool HasSmartField { get; set; }

        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("filename")]
        public string Filename { get; set; }
    }

    public class ContractRecipient
    {
        [JsonProperty("recipient_for_contract_id")]
        public int RecipientForContractId { get; set; }

        [JsonProperty("recipient_id")]
        public int RecipientId { get; set; }

        [JsonProperty("contract_id")]
        public int ContractId { get; set; }

        [JsonProperty("signature_status")]
        public string SignatureStatus { get; set; }

        [JsonProperty("signature_date")]
        public int SignatureDate { get; set; }

        [JsonProperty("signature_mode")]
        public int SignatureMode { get; set; }

        [JsonProperty("message_title")]
        public string MessageTitle { get; set; }

        [JsonProperty("message_body")]
        public string MessageBody { get; set; }

        [JsonProperty("rank")]
        public int Rank { get; set; }

        [JsonProperty("smartrole")]
        public string Smartrole { get; set; }

        [JsonProperty("transport_mode")]
        public int TransportMode { get; set; }

        [JsonProperty("signature_id")]
        public string SignatureId { get; set; }
    }

    public class DeleteRecipientForContractResponse
    {
        [JsonProperty("succeed")]
        public bool Succeed { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Oodrivesign;

    public partial class WorkflowManagedActions
    {
        public OodrivesignActions Oodrivesign(string connectionId) => new OodrivesignActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public OodrivesignTriggers Oodrivesign(string connectionId) => new OodrivesignTriggers(connectionId);
    }
}