//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Zahara
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ZaharaActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zahara")]
        public IBodyWorkflowAction<int> CreateDraftInvoice(Expression<Func<string>> senderEmail, Expression<Func<string>> recipientEmail, Expression<Func<string>> raisedDate = null, Expression<Func<object>> file = null)
        {
            var apiCallPath = "/api/DraftInvoiceIntegration/Add";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<int>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zahara")]
        public IBodyWorkflowAction<int> CreateInvoice(Expression<Func<string>> modelInvoiceNumber = null, Expression<Func<string>> modelPurchaseOrderNumber = null, Expression<Func<string>> modelRaisedDate = null, Expression<Func<string>> modelDueDate = null, Expression<Func<string>> modelSupplierReferenceNumber = null, Expression<Func<string>> modelDescription = null, Expression<Func<string>> modelComments = null, Expression<Func<string>> modelDivisionName = null, Expression<Func<string>> modelCurrencyCode = null, Expression<Func<LineItemAddIntegrationModel[]>> modelLineItems = null)
        {
            var apiCallPath = "/api/InvoiceIntegration/Add";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var model = new JObject();
            var modelpropCount = 0;
            if (modelInvoiceNumber != null)
            {
                model["InvoiceNumber"] = ExpressionConverter.ConvertO(modelInvoiceNumber);
                modelpropCount++;
            }

            if (modelPurchaseOrderNumber != null)
            {
                model["PurchaseOrderNumber"] = ExpressionConverter.ConvertO(modelPurchaseOrderNumber);
                modelpropCount++;
            }

            if (modelRaisedDate != null)
            {
                model["RaisedDate"] = ExpressionConverter.ConvertO(modelRaisedDate);
                modelpropCount++;
            }

            if (modelDueDate != null)
            {
                model["DueDate"] = ExpressionConverter.ConvertO(modelDueDate);
                modelpropCount++;
            }

            if (modelSupplierReferenceNumber != null)
            {
                model["SupplierReferenceNumber"] = ExpressionConverter.ConvertO(modelSupplierReferenceNumber);
                modelpropCount++;
            }

            if (modelDescription != null)
            {
                model["Description"] = ExpressionConverter.ConvertO(modelDescription);
                modelpropCount++;
            }

            if (modelComments != null)
            {
                model["Comments"] = ExpressionConverter.ConvertO(modelComments);
                modelpropCount++;
            }

            if (modelDivisionName != null)
            {
                model["DivisionName"] = ExpressionConverter.ConvertO(modelDivisionName);
                modelpropCount++;
            }

            if (modelCurrencyCode != null)
            {
                model["CurrencyCode"] = ExpressionConverter.ConvertO(modelCurrencyCode);
                modelpropCount++;
            }

            if (modelLineItems != null)
            {
                model["LineItems"] = ExpressionConverter.ConvertO(modelLineItems);
                modelpropCount++;
            }

            if (modelpropCount > 0)
            {
                callPayload.Body = model;
            }

            return new ApiConnectionAction<int>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zahara")]
        public IBodyWorkflowAction<int> CreatePurchaseOrder(Expression<Func<string>> modelRequisitorName = null, Expression<Func<string>> modelRequiredDate = null, Expression<Func<string>> modelSupplierReferenceNumber = null, Expression<Func<string>> modelDescription = null, Expression<Func<string>> modelComments = null, Expression<Func<string>> modelDivisionName = null, Expression<Func<string>> modelCurrencyCode = null, Expression<Func<LineItemAddIntegrationModel[]>> modelLineItems = null)
        {
            var apiCallPath = "/api/PurchaseOrderIntegration/Add";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var model = new JObject();
            var modelpropCount = 0;
            if (modelRequisitorName != null)
            {
                model["RequisitorName"] = ExpressionConverter.ConvertO(modelRequisitorName);
                modelpropCount++;
            }

            if (modelRequiredDate != null)
            {
                model["RequiredDate"] = ExpressionConverter.ConvertO(modelRequiredDate);
                modelpropCount++;
            }

            if (modelSupplierReferenceNumber != null)
            {
                model["SupplierReferenceNumber"] = ExpressionConverter.ConvertO(modelSupplierReferenceNumber);
                modelpropCount++;
            }

            if (modelDescription != null)
            {
                model["Description"] = ExpressionConverter.ConvertO(modelDescription);
                modelpropCount++;
            }

            if (modelComments != null)
            {
                model["Comments"] = ExpressionConverter.ConvertO(modelComments);
                modelpropCount++;
            }

            if (modelDivisionName != null)
            {
                model["DivisionName"] = ExpressionConverter.ConvertO(modelDivisionName);
                modelpropCount++;
            }

            if (modelCurrencyCode != null)
            {
                model["CurrencyCode"] = ExpressionConverter.ConvertO(modelCurrencyCode);
                modelpropCount++;
            }

            if (modelLineItems != null)
            {
                model["LineItems"] = ExpressionConverter.ConvertO(modelLineItems);
                modelpropCount++;
            }

            if (modelpropCount > 0)
            {
                callPayload.Body = model;
            }

            return new ApiConnectionAction<int>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zahara")]
        public IBodyWorkflowAction<int> CreateSupplier(Expression<Func<string>> modelAddressLines = null, Expression<Func<string>> modelContactName = null, Expression<Func<string>> modelCountryCode = null, Expression<Func<string>> modelEmail = null, Expression<Func<string>> modelPostCode = null, Expression<Func<string>> modelReferenceNumber = null, Expression<Func<string>> modelSupplierName = null, Expression<Func<string>> modelTelephone = null, Expression<Func<string>> modelType = null)
        {
            var apiCallPath = "/api/SupplierIntegration/Add";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var model = new JObject();
            var modelpropCount = 0;
            if (modelAddressLines != null)
            {
                model["AddressLines"] = ExpressionConverter.ConvertO(modelAddressLines);
                modelpropCount++;
            }

            if (modelContactName != null)
            {
                model["ContactName"] = ExpressionConverter.ConvertO(modelContactName);
                modelpropCount++;
            }

            if (modelCountryCode != null)
            {
                model["CountryCode"] = ExpressionConverter.ConvertO(modelCountryCode);
                modelpropCount++;
            }

            if (modelEmail != null)
            {
                model["Email"] = ExpressionConverter.ConvertO(modelEmail);
                modelpropCount++;
            }

            if (modelPostCode != null)
            {
                model["PostCode"] = ExpressionConverter.ConvertO(modelPostCode);
                modelpropCount++;
            }

            if (modelReferenceNumber != null)
            {
                model["ReferenceNumber"] = ExpressionConverter.ConvertO(modelReferenceNumber);
                modelpropCount++;
            }

            if (modelSupplierName != null)
            {
                model["SupplierName"] = ExpressionConverter.ConvertO(modelSupplierName);
                modelpropCount++;
            }

            if (modelTelephone != null)
            {
                model["Telephone"] = ExpressionConverter.ConvertO(modelTelephone);
                modelpropCount++;
            }

            if (modelType != null)
            {
                model["Type"] = ExpressionConverter.ConvertO(modelType);
                modelpropCount++;
            }

            if (modelpropCount > 0)
            {
                callPayload.Body = model;
            }

            return new ApiConnectionAction<int>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zahara")]
        public IBodyWorkflowAction<JToken> UpdateSupplier(Expression<Func<int>> id, Expression<Func<int>> modelId = null, Expression<Func<string>> modelAddressLines = null, Expression<Func<string>> modelContactName = null, Expression<Func<string>> modelCountryCode = null, Expression<Func<string>> modelEmail = null, Expression<Func<string>> modelPostCode = null, Expression<Func<string>> modelReferenceNumber = null, Expression<Func<string>> modelSupplierName = null, Expression<Func<string>> modelTelephone = null, Expression<Func<string>> modelType = null)
        {
            var apiCallPath = "/api/SupplierIntegration/Update";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["id"] = ExpressionConverter.Convert(id);
            var model = new JObject();
            var modelpropCount = 0;
            if (modelId != null)
            {
                model["Id"] = ExpressionConverter.ConvertO(modelId);
                modelpropCount++;
            }

            if (modelAddressLines != null)
            {
                model["AddressLines"] = ExpressionConverter.ConvertO(modelAddressLines);
                modelpropCount++;
            }

            if (modelContactName != null)
            {
                model["ContactName"] = ExpressionConverter.ConvertO(modelContactName);
                modelpropCount++;
            }

            if (modelCountryCode != null)
            {
                model["CountryCode"] = ExpressionConverter.ConvertO(modelCountryCode);
                modelpropCount++;
            }

            if (modelEmail != null)
            {
                model["Email"] = ExpressionConverter.ConvertO(modelEmail);
                modelpropCount++;
            }

            if (modelPostCode != null)
            {
                model["PostCode"] = ExpressionConverter.ConvertO(modelPostCode);
                modelpropCount++;
            }

            if (modelReferenceNumber != null)
            {
                model["ReferenceNumber"] = ExpressionConverter.ConvertO(modelReferenceNumber);
                modelpropCount++;
            }

            if (modelSupplierName != null)
            {
                model["SupplierName"] = ExpressionConverter.ConvertO(modelSupplierName);
                modelpropCount++;
            }

            if (modelTelephone != null)
            {
                model["Telephone"] = ExpressionConverter.ConvertO(modelTelephone);
                modelpropCount++;
            }

            if (modelType != null)
            {
                model["Type"] = ExpressionConverter.ConvertO(modelType);
                modelpropCount++;
            }

            if (modelpropCount > 0)
            {
                callPayload.Body = model;
            }

            return new ApiConnectionAction<JToken>(callPayload);
        }
    }

    public class ZaharaTriggers([ConnectionName] string connectionId)
    {
        public IOutputWorkflowTrigger<CostCodeIntegrationModel[]> NewCostCode(string triggerName = null)
        {
            var apiCallPath = "/api/CostCodeIntegration/GetAll";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<CostCodeIntegrationModel[]>(callPayload);
        }

        public IOutputWorkflowTrigger<ProcessLogIntegrationModel[]> NewApprovalComment(string triggerName = null)
        {
            var apiCallPath = "/api/DocumentsIntegration/GetApprovalComments";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<ProcessLogIntegrationModel[]>(callPayload);
        }

        public IOutputWorkflowTrigger<ProcessLogIntegrationModel[]> NewDocumentApproved(Expression<Func<documentTypeInput>> documentType, string triggerName = null)
        {
            var apiCallPath = "/api/DocumentsIntegration/GetApproved";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["documentType"] = ExpressionConverter.Convert(documentType);
            return new ApiConnectionTrigger<ProcessLogIntegrationModel[]>(callPayload);
        }

        public IOutputWorkflowTrigger<InvoiceIntegrationModel[]> NewInvoice(string triggerName = null)
        {
            var apiCallPath = "/api/InvoiceIntegration/GetAll";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<InvoiceIntegrationModel[]>(callPayload);
        }

        public IOutputWorkflowTrigger<InvoiceIntegrationModel[]> NewInvoiceSetAsExported(string triggerName = null)
        {
            var apiCallPath = "/api/InvoiceIntegration/GetExported";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<InvoiceIntegrationModel[]>(callPayload);
        }

        public IOutputWorkflowTrigger<NominalCodeIntegrationModel[]> NewNominalCode(string triggerName = null)
        {
            var apiCallPath = "/api/NominalCodeIntegration/GetAll";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<NominalCodeIntegrationModel[]>(callPayload);
        }

        public IOutputWorkflowTrigger<ProjectIntegrationModel[]> NewProject(string triggerName = null)
        {
            var apiCallPath = "/api/ProjectIntegration/getall";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<ProjectIntegrationModel[]>(callPayload);
        }

        public IOutputWorkflowTrigger<PurchaseOrderIntegrationModel[]> NewPurchaseOrder(string triggerName = null)
        {
            var apiCallPath = "/api/PurchaseOrderIntegration/GetAll";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<PurchaseOrderIntegrationModel[]>(callPayload);
        }

        public IOutputWorkflowTrigger<PurchaseOrderIntegrationModel[]> NewPurchaseOrderSentToSupplier(string triggerName = null)
        {
            var apiCallPath = "/api/PurchaseOrderIntegration/GetSentToSupplier";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<PurchaseOrderIntegrationModel[]>(callPayload);
        }

        public IOutputWorkflowTrigger<PurchaseRequsitionIntegrationModel[]> NewPurchaseRequsition(string triggerName = null)
        {
            var apiCallPath = "/api/PurchaseRequsitionIntegration/getall";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<PurchaseRequsitionIntegrationModel[]>(callPayload);
        }

        public IOutputWorkflowTrigger<SupplierIntegrationModel[]> NewSupplier(string triggerName = null)
        {
            var apiCallPath = "/api/SupplierIntegration/GetAll";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<SupplierIntegrationModel[]>(callPayload);
        }

        public IOutputWorkflowTrigger<SupplierUpdateIntegrationModel[]> SupplierAmended(string triggerName = null)
        {
            var apiCallPath = "/api/SupplierIntegration/GetAllUpdated";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<SupplierUpdateIntegrationModel[]>(callPayload);
        }

        public IOutputWorkflowTrigger<TaxCodeIntegrationModel[]> NewTaxCode(string triggerName = null)
        {
            var apiCallPath = "/api/TaxCodeIntegration/getall";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<TaxCodeIntegrationModel[]>(callPayload);
        }
    }

    public class LineItemAddIntegrationModel
    {
        public string CostCode { get; set; }
        public double Quantity { get; set; }
        public double Price { get; set; }
        public string LineDescription { get; set; }
        public string NominalCode { get; set; }
        public string TaxCode { get; set; }
        public double TaxValue { get; set; }
        public double DiscountPercentage { get; set; }
        public string ProductCode { get; set; }
        public string ProjectCode { get; set; }
    }

    public class CostCodeIntegrationModel
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string DateCreated { get; set; }
        public bool IsActive { get; set; }
    }

    public class ProcessLogIntegrationModel
    {
        public string ProcessToken { get; set; }
        public ProcessLogIntegrationModelStepResultType StepResult { get; set; }
        public string Message { get; set; }
        public bool Approved { get; set; }
        public string ActionDate { get; set; }
        public string DateCreated { get; set; }
        public string Comment { get; set; }
        public DocumentSimpleIntegrationModel Document { get; set; }
        public UserIntegrationModel ApprovedBy { get; set; }
    }

    public enum ProcessLogIntegrationModelStepResultType
    {
        None,
        Success,
        Failure,
        WaitForAction,
        ToReprocess,
        ProcessingWait,
        FailedToSendToSupplier
    }

    public class DocumentSimpleIntegrationModel
    {
        public string DocumentNumber { get; set; }
        public DocumentSimpleIntegrationModelTypeType Type { get; set; }
        public DocumentSimpleIntegrationModelStatusType Status { get; set; }
        public string DivisionName { get; set; }
        public string CurrencyCode { get; set; }
    }

    public enum DocumentSimpleIntegrationModelTypeType
    {
        PurchaseOrder,
        Invoice,
        DeliveryNote,
        CreditNote,
        PurchaseRequisition
    }

    public enum DocumentSimpleIntegrationModelStatusType
    {
        Created,
        Approved,
        Rejected,
        SentToSupplier,
        Completed,
        Closed,
        Draft,
        ExportOnHold,
        AdHocWorkflowNotFinished,
        SendToSupplierStepFailed
    }

    public class UserIntegrationModel
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public string JobTitle { get; set; }
        public string TelephoneNumber { get; set; }
    }

    public enum documentTypeInput
    {
        PurchaseOrder,
        Invoice,
        PurchaseRequisition
    }

    public class InvoiceIntegrationModel
    {
        public string DocumentNumber { get; set; }
        public string PurchaseOrderNumber { get; set; }
        public double TotalNetValue { get; set; }
        public double TotalGrossValue { get; set; }
        public double TotalTaxValue { get; set; }
        public bool IsCreditNote { get; set; }
        public string RaisedDate { get; set; }
        public string DueDate { get; set; }
        public bool IsBasedOnAnyOrder { get; set; }
        public InvoiceIntegrationModelCurrentExportStatusType CurrentExportStatus { get; set; }
        public string SyncDate { get; set; }
        public InvoiceIntegrationModelSyncTypeType SyncType { get; set; }
        public AddressIntegrationModel BillingAddress { get; set; }
        public int DocumentId { get; set; }
        public string Description { get; set; }
        public string LastUpdated { get; set; }
        public string DateCreated { get; set; }
        public AddressIntegrationModel DeliveryAddress { get; set; }
        public SupplierSimpleIntegrationModel Supplier { get; set; }
        public LineItemIntegrationModel[] LineItems { get; set; }
        public InvoiceIntegrationModelTypeType Type { get; set; }
        public InvoiceIntegrationModelStatusType Status { get; set; }
        public string DivisionName { get; set; }
        public string CurrencyCode { get; set; }
    }

    public enum InvoiceIntegrationModelCurrentExportStatusType
    {
        None,
        ReadyForExport,
        Exporting,
        ExportComplete,
        ExportFailed
    }

    public enum InvoiceIntegrationModelSyncTypeType
    {
        None,
        Csv,
        Sage50,
        Sage200,
        Xero,
        QuickBooks,
        MindYourOwnBusiness,
        SapBusinessByDesign,
        KashFlow,
        SmartInvoice,
        QuickBooksOnline
    }

    public class AddressIntegrationModel
    {
        public string AddressLines { get; set; }
        public string Postcode { get; set; }
        public string CountryCode { get; set; }
    }

    public class SupplierSimpleIntegrationModel
    {
        public string SupplierName { get; set; }
        public string ReferenceNumber { get; set; }
    }

    public class LineItemIntegrationModel
    {
        public double Quantity { get; set; }
        public string Description { get; set; }
        public string NominalCode { get; set; }
        public string TaxCode { get; set; }
        public double TaxPercentage { get; set; }
        public double TaxValue { get; set; }
        public double DiscountPercentage { get; set; }
        public double NetValue { get; set; }
        public double QuantityReceived { get; set; }
        public string ProductCode { get; set; }
        public double GrossValue { get; set; }
        public bool IsEmpty { get; set; }
        public string CostCode { get; set; }
        public double Price { get; set; }
        public string ProjectCode { get; set; }
        public string SupplierName { get; set; }
        public string ReferenceNumber { get; set; }
    }

    public enum InvoiceIntegrationModelTypeType
    {
        PurchaseOrder,
        Invoice,
        DeliveryNote,
        CreditNote,
        PurchaseRequisition
    }

    public enum InvoiceIntegrationModelStatusType
    {
        Created,
        Approved,
        Rejected,
        SentToSupplier,
        Completed,
        Closed,
        Draft,
        ExportOnHold,
        AdHocWorkflowNotFinished,
        SendToSupplierStepFailed
    }

    public class NominalCodeIntegrationModel
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public string DateCreated { get; set; }
    }

    public class ProjectIntegrationModel
    {
        public int Id { get; set; }
        public string ProjectName { get; set; }
        public string ProjectCode { get; set; }
        public string Description { get; set; }
        public string Start { get; set; }
        public string End { get; set; }
        public ProjectIntegrationModelStatusType Status { get; set; }
        public string DateCreated { get; set; }
    }

    public enum ProjectIntegrationModelStatusType
    {
        Active,
        Inactive,
        OnHold,
        Completed
    }

    public class PurchaseOrderIntegrationModel
    {
        public string DocumentNumber { get; set; }
        public string RequiredDate { get; set; }
        public double TotalNetValue { get; set; }
        public double TotalGrossValue { get; set; }
        public double TotalTaxValue { get; set; }
        public string SupplierComment { get; set; }
        public bool SentToSupplier { get; set; }
        public bool EverSentToSupplier { get; set; }
        public bool AcceptedBySupplier { get; set; }
        public string ReportStatus { get; set; }
        public bool IsFullyReceived { get; set; }
        public bool IsReceivedInExcess { get; set; }
        public bool IsNotReceivedAtAll { get; set; }
        public UserIntegrationModel Requisitor { get; set; }
        public int DocumentId { get; set; }
        public string Description { get; set; }
        public string LastUpdated { get; set; }
        public string DateCreated { get; set; }
        public AddressIntegrationModel DeliveryAddress { get; set; }
        public SupplierSimpleIntegrationModel Supplier { get; set; }
        public LineItemIntegrationModel[] LineItems { get; set; }
        public PurchaseOrderIntegrationModelTypeType Type { get; set; }
        public PurchaseOrderIntegrationModelStatusType Status { get; set; }
        public string DivisionName { get; set; }
        public string CurrencyCode { get; set; }
    }

    public enum PurchaseOrderIntegrationModelTypeType
    {
        PurchaseOrder,
        Invoice,
        DeliveryNote,
        CreditNote,
        PurchaseRequisition
    }

    public enum PurchaseOrderIntegrationModelStatusType
    {
        Created,
        Approved,
        Rejected,
        SentToSupplier,
        Completed,
        Closed,
        Draft,
        ExportOnHold,
        AdHocWorkflowNotFinished,
        SendToSupplierStepFailed
    }

    public class PurchaseRequsitionIntegrationModel
    {
        public string DocumentNumber { get; set; }
        public string RequiredDate { get; set; }
        public double TotalNetValue { get; set; }
        public double TotalGrossValue { get; set; }
        public string UsersToNotify { get; set; }
        public bool WasPoGenerated { get; set; }
        public UserIntegrationModel Requisitor { get; set; }
        public int DocumentId { get; set; }
        public string Description { get; set; }
        public string LastUpdated { get; set; }
        public string DateCreated { get; set; }
        public AddressIntegrationModel DeliveryAddress { get; set; }
        public SupplierSimpleIntegrationModel Supplier { get; set; }
        public LineItemIntegrationModel[] LineItems { get; set; }
        public PurchaseRequsitionIntegrationModelTypeType Type { get; set; }
        public PurchaseRequsitionIntegrationModelStatusType Status { get; set; }
        public string DivisionName { get; set; }
        public string CurrencyCode { get; set; }
    }

    public enum PurchaseRequsitionIntegrationModelTypeType
    {
        PurchaseOrder,
        Invoice,
        DeliveryNote,
        CreditNote,
        PurchaseRequisition
    }

    public enum PurchaseRequsitionIntegrationModelStatusType
    {
        Created,
        Approved,
        Rejected,
        SentToSupplier,
        Completed,
        Closed,
        Draft,
        ExportOnHold,
        AdHocWorkflowNotFinished,
        SendToSupplierStepFailed
    }

    public class SupplierIntegrationModel
    {
        public int Id { get; set; }
        public string ContactName { get; set; }
        public string Email { get; set; }
        public string LastUpdated { get; set; }
        public string DateCreated { get; set; }
        public string Telephone { get; set; }
        public string VatReg { get; set; }
        public string DefaultNominalCode { get; set; }
        public string DefaultTaxCode { get; set; }
        public string DefaultCostCode { get; set; }
        public int DefaultPaymentTerms { get; set; }
        public string Notes { get; set; }
        public string Terms { get; set; }
        public string Type { get; set; }
        public bool IsActive { get; set; }
        public AddressIntegrationModel Address { get; set; }
        public string SupplierName { get; set; }
        public string ReferenceNumber { get; set; }
    }

    public class SupplierUpdateIntegrationModel
    {
        public int OriginalId { get; set; }
        public int Id { get; set; }
        public string ContactName { get; set; }
        public string Email { get; set; }
        public string LastUpdated { get; set; }
        public string DateCreated { get; set; }
        public string Telephone { get; set; }
        public string VatReg { get; set; }
        public string DefaultNominalCode { get; set; }
        public string DefaultTaxCode { get; set; }
        public string DefaultCostCode { get; set; }
        public int DefaultPaymentTerms { get; set; }
        public string Notes { get; set; }
        public string Terms { get; set; }
        public string Type { get; set; }
        public bool IsActive { get; set; }
        public AddressIntegrationModel Address { get; set; }
        public string SupplierName { get; set; }
        public string ReferenceNumber { get; set; }
    }

    public class TaxCodeIntegrationModel
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string CodeName { get; set; }
        public double TaxPercentage { get; set; }
        public bool Display { get; set; }
        public string DateCreated { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk.Connectors
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Zahara;

    public partial class WorkflowManagedActions
    {
        public ZaharaActions Zahara(string connectionId) => new ZaharaActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public ZaharaTriggers Zahara(string connectionId) => new ZaharaTriggers(connectionId);
    }
}