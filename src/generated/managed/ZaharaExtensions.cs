//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Zahara
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ZaharaActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zahara")]
        public IBodyWorkflowAction<int, ApiConnectionActionConfiguration> CreateInvoice(Expression<Func<CreateInvoiceInput>> model)
        {
            var __workflow_model = WorkflowExpression.Compile(model, nameof(model), required: true);
            return new DeferredBodyAction<int, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/InvoiceIntegration/Add";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_model);
                return new ApiConnectionAction<int>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zahara")]
        public IBodyWorkflowAction<int, ApiConnectionActionConfiguration> CreatePurchaseOrder(Expression<Func<CreatePurchaseOrderInput>> model)
        {
            var __workflow_model = WorkflowExpression.Compile(model, nameof(model), required: true);
            return new DeferredBodyAction<int, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/PurchaseOrderIntegration/Add";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_model);
                return new ApiConnectionAction<int>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zahara")]
        public IBodyWorkflowAction<int, ApiConnectionActionConfiguration> CreateSupplier(Expression<Func<CreateSupplierInput>> model)
        {
            var __workflow_model = WorkflowExpression.Compile(model, nameof(model), required: true);
            return new DeferredBodyAction<int, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/SupplierIntegration/Add";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_model);
                return new ApiConnectionAction<int>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zahara")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> UpdateSupplier(Expression<Func<int>> id, Expression<Func<UpdateSupplierInput>> model)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_model = WorkflowExpression.Compile(model, nameof(model), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/SupplierIntegration/Update";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = ExpressionConverter.Convert(__workflow_id);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_model);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }
    }

    public class ZaharaTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<CostCodeIntegrationModel[], ApiConnectionTriggerConfiguration> NewCostCode(FlowRecurrence recurrence = null)
        {
            return new DeferredBodyTrigger<CostCodeIntegrationModel[], ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/api/CostCodeIntegration/GetAll";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionTrigger<CostCodeIntegrationModel[]>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<ProcessLogIntegrationModel[], ApiConnectionTriggerConfiguration> NewApprovalComment(FlowRecurrence recurrence = null)
        {
            return new DeferredBodyTrigger<ProcessLogIntegrationModel[], ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/api/DocumentsIntegration/GetApprovalComments";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionTrigger<ProcessLogIntegrationModel[]>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<ProcessLogIntegrationModel[], ApiConnectionTriggerConfiguration> NewDocumentApproved(Expression<Func<documentTypeInput>> documentType, FlowRecurrence recurrence = null)
        {
            var __workflow_documentType = WorkflowExpression.Compile(documentType, nameof(documentType), required: true);
            return new DeferredBodyTrigger<ProcessLogIntegrationModel[], ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/api/DocumentsIntegration/GetApproved";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["documentType"] = ExpressionConverter.Convert(__workflow_documentType);
                return new ApiConnectionTrigger<ProcessLogIntegrationModel[]>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<InvoiceIntegrationModel[], ApiConnectionTriggerConfiguration> NewInvoice(FlowRecurrence recurrence = null)
        {
            return new DeferredBodyTrigger<InvoiceIntegrationModel[], ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/api/InvoiceIntegration/GetAll";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionTrigger<InvoiceIntegrationModel[]>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<InvoiceIntegrationModel[], ApiConnectionTriggerConfiguration> NewInvoiceSetAsExported(FlowRecurrence recurrence = null)
        {
            return new DeferredBodyTrigger<InvoiceIntegrationModel[], ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/api/InvoiceIntegration/GetExported";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionTrigger<InvoiceIntegrationModel[]>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<NominalCodeIntegrationModel[], ApiConnectionTriggerConfiguration> NewNominalCode(FlowRecurrence recurrence = null)
        {
            return new DeferredBodyTrigger<NominalCodeIntegrationModel[], ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/api/NominalCodeIntegration/GetAll";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionTrigger<NominalCodeIntegrationModel[]>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<ProjectIntegrationModel[], ApiConnectionTriggerConfiguration> NewProject(FlowRecurrence recurrence = null)
        {
            return new DeferredBodyTrigger<ProjectIntegrationModel[], ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/api/ProjectIntegration/getall";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionTrigger<ProjectIntegrationModel[]>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<PurchaseOrderIntegrationModel[], ApiConnectionTriggerConfiguration> NewPurchaseOrder(FlowRecurrence recurrence = null)
        {
            return new DeferredBodyTrigger<PurchaseOrderIntegrationModel[], ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/api/PurchaseOrderIntegration/GetAll";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionTrigger<PurchaseOrderIntegrationModel[]>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<PurchaseOrderIntegrationModel[], ApiConnectionTriggerConfiguration> NewPurchaseOrderSentToSupplier(FlowRecurrence recurrence = null)
        {
            return new DeferredBodyTrigger<PurchaseOrderIntegrationModel[], ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/api/PurchaseOrderIntegration/GetSentToSupplier";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionTrigger<PurchaseOrderIntegrationModel[]>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<PurchaseRequsitionIntegrationModel[], ApiConnectionTriggerConfiguration> NewPurchaseRequsition(FlowRecurrence recurrence = null)
        {
            return new DeferredBodyTrigger<PurchaseRequsitionIntegrationModel[], ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/api/PurchaseRequsitionIntegration/getall";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionTrigger<PurchaseRequsitionIntegrationModel[]>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<SupplierIntegrationModel[], ApiConnectionTriggerConfiguration> NewSupplier(FlowRecurrence recurrence = null)
        {
            return new DeferredBodyTrigger<SupplierIntegrationModel[], ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/api/SupplierIntegration/GetAll";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionTrigger<SupplierIntegrationModel[]>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<SupplierUpdateIntegrationModel[], ApiConnectionTriggerConfiguration> SupplierAmended(FlowRecurrence recurrence = null)
        {
            return new DeferredBodyTrigger<SupplierUpdateIntegrationModel[], ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/api/SupplierIntegration/GetAllUpdated";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionTrigger<SupplierUpdateIntegrationModel[]>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<TaxCodeIntegrationModel[], ApiConnectionTriggerConfiguration> NewTaxCode(FlowRecurrence recurrence = null)
        {
            return new DeferredBodyTrigger<TaxCodeIntegrationModel[], ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/api/TaxCodeIntegration/getall";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionTrigger<TaxCodeIntegrationModel[]>(callPayload, recurrence: recurrence);
            });
        }
    }

    public class CreateInvoiceInput
    {
        public string InvoiceNumber { get; set; }
        public string PurchaseOrderNumber { get; set; }
        public string RaisedDate { get; set; }
        public string DueDate { get; set; }
        public string SupplierReferenceNumber { get; set; }
        public string Description { get; set; }
        public string Comments { get; set; }
        public string DivisionName { get; set; }
        public string CurrencyCode { get; set; }
        public LineItemAddIntegrationModel[] LineItems { get; set; }
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

    public class CreatePurchaseOrderInput
    {
        public string RequisitorName { get; set; }
        public string RequiredDate { get; set; }
        public string SupplierReferenceNumber { get; set; }
        public string Description { get; set; }
        public string Comments { get; set; }
        public string DivisionName { get; set; }
        public string CurrencyCode { get; set; }
        public LineItemAddIntegrationModel[] LineItems { get; set; }
    }

    public class CreateSupplierInput
    {
        public string AddressLines { get; set; }
        public string ContactName { get; set; }
        public string CountryCode { get; set; }
        public string Email { get; set; }
        public string PostCode { get; set; }
        public string ReferenceNumber { get; set; }
        public string SupplierName { get; set; }
        public string Telephone { get; set; }
        public string Type { get; set; }
    }

    public class UpdateSupplierInput
    {
        public int? Id { get; set; }
        public string AddressLines { get; set; }
        public string ContactName { get; set; }
        public string CountryCode { get; set; }
        public string Email { get; set; }
        public string PostCode { get; set; }
        public string ReferenceNumber { get; set; }
        public string SupplierName { get; set; }
        public string Telephone { get; set; }
        public string Type { get; set; }
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum DocumentSimpleIntegrationModelTypeType
    {
        PurchaseOrder,
        Invoice,
        DeliveryNote,
        CreditNote,
        PurchaseRequisition
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum InvoiceIntegrationModelCurrentExportStatusType
    {
        None,
        ReadyForExport,
        Exporting,
        ExportComplete,
        ExportFailed
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum InvoiceIntegrationModelTypeType
    {
        PurchaseOrder,
        Invoice,
        DeliveryNote,
        CreditNote,
        PurchaseRequisition
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum PurchaseOrderIntegrationModelTypeType
    {
        PurchaseOrder,
        Invoice,
        DeliveryNote,
        CreditNote,
        PurchaseRequisition
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum PurchaseRequsitionIntegrationModelTypeType
    {
        PurchaseOrder,
        Invoice,
        DeliveryNote,
        CreditNote,
        PurchaseRequisition
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

namespace Microsoft.Azure.Workflows.Sdk
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