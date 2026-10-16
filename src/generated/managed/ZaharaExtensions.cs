//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Zahara
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class ZaharaActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zahara")]
        public IBodyWorkflowAction<int> CreateDraftInvoice(Expression<Func<string>> senderEmail, Expression<Func<string>> recipientEmail, Expression<Func<string>> raisedDate = null, Expression<Func<object>> file = null)
        {
            var __workflow_senderEmail = WorkflowExpression.Compile(senderEmail, nameof(senderEmail), required: true);
            var __workflow_recipientEmail = WorkflowExpression.Compile(recipientEmail, nameof(recipientEmail), required: true);
            var __workflow_raisedDate = WorkflowExpression.Compile(raisedDate, nameof(raisedDate), required: false);
            var __workflow_file = WorkflowExpression.Compile(file, nameof(file), required: false);
            return new DeferredBodyAction<int>(() =>
            {
                var apiCallPath = "/api/DraftInvoiceIntegration/Add";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<int>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zahara")]
        public IBodyWorkflowAction<int> CreateInvoice(Expression<Func<string>> modelinvoiceNumber = null, Expression<Func<string>> modelpurchaseOrderNumber = null, Expression<Func<string>> modelraisedDate = null, Expression<Func<string>> modeldueDate = null, Expression<Func<string>> modelsupplierReferenceNumber = null, Expression<Func<string>> modeldescription = null, Expression<Func<string>> modelcomments = null, Expression<Func<string>> modeldivisionName = null, Expression<Func<string>> modelcurrencyCode = null, Expression<Func<LineItemAddIntegrationModel[]>> modellineItems = null)
        {
            var __workflow_modelinvoiceNumber = WorkflowExpression.Compile(modelinvoiceNumber, nameof(modelinvoiceNumber), required: false);
            var __workflow_modelpurchaseOrderNumber = WorkflowExpression.Compile(modelpurchaseOrderNumber, nameof(modelpurchaseOrderNumber), required: false);
            var __workflow_modelraisedDate = WorkflowExpression.Compile(modelraisedDate, nameof(modelraisedDate), required: false);
            var __workflow_modeldueDate = WorkflowExpression.Compile(modeldueDate, nameof(modeldueDate), required: false);
            var __workflow_modelsupplierReferenceNumber = WorkflowExpression.Compile(modelsupplierReferenceNumber, nameof(modelsupplierReferenceNumber), required: false);
            var __workflow_modeldescription = WorkflowExpression.Compile(modeldescription, nameof(modeldescription), required: false);
            var __workflow_modelcomments = WorkflowExpression.Compile(modelcomments, nameof(modelcomments), required: false);
            var __workflow_modeldivisionName = WorkflowExpression.Compile(modeldivisionName, nameof(modeldivisionName), required: false);
            var __workflow_modelcurrencyCode = WorkflowExpression.Compile(modelcurrencyCode, nameof(modelcurrencyCode), required: false);
            var __workflow_modellineItems = WorkflowExpression.Compile(modellineItems, nameof(modellineItems), required: false);
            return new DeferredBodyAction<int>(() =>
            {
                var apiCallPath = "/api/InvoiceIntegration/Add";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var model = new JObject();
                var modelpropCount = 0;
                if (__workflow_modelinvoiceNumber != null)
                {
                    model["InvoiceNumber"] = ExpressionConverter.ConvertO(__workflow_modelinvoiceNumber);
                    modelpropCount++;
                }

                if (__workflow_modelpurchaseOrderNumber != null)
                {
                    model["PurchaseOrderNumber"] = ExpressionConverter.ConvertO(__workflow_modelpurchaseOrderNumber);
                    modelpropCount++;
                }

                if (__workflow_modelraisedDate != null)
                {
                    model["RaisedDate"] = ExpressionConverter.ConvertO(__workflow_modelraisedDate);
                    modelpropCount++;
                }

                if (__workflow_modeldueDate != null)
                {
                    model["DueDate"] = ExpressionConverter.ConvertO(__workflow_modeldueDate);
                    modelpropCount++;
                }

                if (__workflow_modelsupplierReferenceNumber != null)
                {
                    model["SupplierReferenceNumber"] = ExpressionConverter.ConvertO(__workflow_modelsupplierReferenceNumber);
                    modelpropCount++;
                }

                if (__workflow_modeldescription != null)
                {
                    model["Description"] = ExpressionConverter.ConvertO(__workflow_modeldescription);
                    modelpropCount++;
                }

                if (__workflow_modelcomments != null)
                {
                    model["Comments"] = ExpressionConverter.ConvertO(__workflow_modelcomments);
                    modelpropCount++;
                }

                if (__workflow_modeldivisionName != null)
                {
                    model["DivisionName"] = ExpressionConverter.ConvertO(__workflow_modeldivisionName);
                    modelpropCount++;
                }

                if (__workflow_modelcurrencyCode != null)
                {
                    model["CurrencyCode"] = ExpressionConverter.ConvertO(__workflow_modelcurrencyCode);
                    modelpropCount++;
                }

                if (__workflow_modellineItems != null)
                {
                    model["LineItems"] = ExpressionConverter.ConvertO(__workflow_modellineItems);
                    modelpropCount++;
                }

                if (modelpropCount > 0)
                {
                    callPayload.Body = model;
                }

                return new ApiConnectionAction<int>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zahara")]
        public IBodyWorkflowAction<int> CreatePurchaseOrder(Expression<Func<string>> modelrequisitorName = null, Expression<Func<string>> modelrequiredDate = null, Expression<Func<string>> modelsupplierReferenceNumber = null, Expression<Func<string>> modeldescription = null, Expression<Func<string>> modelcomments = null, Expression<Func<string>> modeldivisionName = null, Expression<Func<string>> modelcurrencyCode = null, Expression<Func<LineItemAddIntegrationModel[]>> modellineItems = null)
        {
            var __workflow_modelrequisitorName = WorkflowExpression.Compile(modelrequisitorName, nameof(modelrequisitorName), required: false);
            var __workflow_modelrequiredDate = WorkflowExpression.Compile(modelrequiredDate, nameof(modelrequiredDate), required: false);
            var __workflow_modelsupplierReferenceNumber = WorkflowExpression.Compile(modelsupplierReferenceNumber, nameof(modelsupplierReferenceNumber), required: false);
            var __workflow_modeldescription = WorkflowExpression.Compile(modeldescription, nameof(modeldescription), required: false);
            var __workflow_modelcomments = WorkflowExpression.Compile(modelcomments, nameof(modelcomments), required: false);
            var __workflow_modeldivisionName = WorkflowExpression.Compile(modeldivisionName, nameof(modeldivisionName), required: false);
            var __workflow_modelcurrencyCode = WorkflowExpression.Compile(modelcurrencyCode, nameof(modelcurrencyCode), required: false);
            var __workflow_modellineItems = WorkflowExpression.Compile(modellineItems, nameof(modellineItems), required: false);
            return new DeferredBodyAction<int>(() =>
            {
                var apiCallPath = "/api/PurchaseOrderIntegration/Add";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var model = new JObject();
                var modelpropCount = 0;
                if (__workflow_modelrequisitorName != null)
                {
                    model["RequisitorName"] = ExpressionConverter.ConvertO(__workflow_modelrequisitorName);
                    modelpropCount++;
                }

                if (__workflow_modelrequiredDate != null)
                {
                    model["RequiredDate"] = ExpressionConverter.ConvertO(__workflow_modelrequiredDate);
                    modelpropCount++;
                }

                if (__workflow_modelsupplierReferenceNumber != null)
                {
                    model["SupplierReferenceNumber"] = ExpressionConverter.ConvertO(__workflow_modelsupplierReferenceNumber);
                    modelpropCount++;
                }

                if (__workflow_modeldescription != null)
                {
                    model["Description"] = ExpressionConverter.ConvertO(__workflow_modeldescription);
                    modelpropCount++;
                }

                if (__workflow_modelcomments != null)
                {
                    model["Comments"] = ExpressionConverter.ConvertO(__workflow_modelcomments);
                    modelpropCount++;
                }

                if (__workflow_modeldivisionName != null)
                {
                    model["DivisionName"] = ExpressionConverter.ConvertO(__workflow_modeldivisionName);
                    modelpropCount++;
                }

                if (__workflow_modelcurrencyCode != null)
                {
                    model["CurrencyCode"] = ExpressionConverter.ConvertO(__workflow_modelcurrencyCode);
                    modelpropCount++;
                }

                if (__workflow_modellineItems != null)
                {
                    model["LineItems"] = ExpressionConverter.ConvertO(__workflow_modellineItems);
                    modelpropCount++;
                }

                if (modelpropCount > 0)
                {
                    callPayload.Body = model;
                }

                return new ApiConnectionAction<int>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zahara")]
        public IBodyWorkflowAction<int> CreateSupplier(Expression<Func<string>> modeladdressLines = null, Expression<Func<string>> modelcontactName = null, Expression<Func<string>> modelcountryCode = null, Expression<Func<string>> modelemail = null, Expression<Func<string>> modelpostCode = null, Expression<Func<string>> modelreferenceNumber = null, Expression<Func<string>> modelsupplierName = null, Expression<Func<string>> modeltelephone = null, Expression<Func<string>> modeltype = null)
        {
            var __workflow_modeladdressLines = WorkflowExpression.Compile(modeladdressLines, nameof(modeladdressLines), required: false);
            var __workflow_modelcontactName = WorkflowExpression.Compile(modelcontactName, nameof(modelcontactName), required: false);
            var __workflow_modelcountryCode = WorkflowExpression.Compile(modelcountryCode, nameof(modelcountryCode), required: false);
            var __workflow_modelemail = WorkflowExpression.Compile(modelemail, nameof(modelemail), required: false);
            var __workflow_modelpostCode = WorkflowExpression.Compile(modelpostCode, nameof(modelpostCode), required: false);
            var __workflow_modelreferenceNumber = WorkflowExpression.Compile(modelreferenceNumber, nameof(modelreferenceNumber), required: false);
            var __workflow_modelsupplierName = WorkflowExpression.Compile(modelsupplierName, nameof(modelsupplierName), required: false);
            var __workflow_modeltelephone = WorkflowExpression.Compile(modeltelephone, nameof(modeltelephone), required: false);
            var __workflow_modeltype = WorkflowExpression.Compile(modeltype, nameof(modeltype), required: false);
            return new DeferredBodyAction<int>(() =>
            {
                var apiCallPath = "/api/SupplierIntegration/Add";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var model = new JObject();
                var modelpropCount = 0;
                if (__workflow_modeladdressLines != null)
                {
                    model["AddressLines"] = ExpressionConverter.ConvertO(__workflow_modeladdressLines);
                    modelpropCount++;
                }

                if (__workflow_modelcontactName != null)
                {
                    model["ContactName"] = ExpressionConverter.ConvertO(__workflow_modelcontactName);
                    modelpropCount++;
                }

                if (__workflow_modelcountryCode != null)
                {
                    model["CountryCode"] = ExpressionConverter.ConvertO(__workflow_modelcountryCode);
                    modelpropCount++;
                }

                if (__workflow_modelemail != null)
                {
                    model["Email"] = ExpressionConverter.ConvertO(__workflow_modelemail);
                    modelpropCount++;
                }

                if (__workflow_modelpostCode != null)
                {
                    model["PostCode"] = ExpressionConverter.ConvertO(__workflow_modelpostCode);
                    modelpropCount++;
                }

                if (__workflow_modelreferenceNumber != null)
                {
                    model["ReferenceNumber"] = ExpressionConverter.ConvertO(__workflow_modelreferenceNumber);
                    modelpropCount++;
                }

                if (__workflow_modelsupplierName != null)
                {
                    model["SupplierName"] = ExpressionConverter.ConvertO(__workflow_modelsupplierName);
                    modelpropCount++;
                }

                if (__workflow_modeltelephone != null)
                {
                    model["Telephone"] = ExpressionConverter.ConvertO(__workflow_modeltelephone);
                    modelpropCount++;
                }

                if (__workflow_modeltype != null)
                {
                    model["Type"] = ExpressionConverter.ConvertO(__workflow_modeltype);
                    modelpropCount++;
                }

                if (modelpropCount > 0)
                {
                    callPayload.Body = model;
                }

                return new ApiConnectionAction<int>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zahara")]
        public IBodyWorkflowAction<JToken> UpdateSupplier(Expression<Func<int>> id, Expression<Func<int>> modelid = null, Expression<Func<string>> modeladdressLines = null, Expression<Func<string>> modelcontactName = null, Expression<Func<string>> modelcountryCode = null, Expression<Func<string>> modelemail = null, Expression<Func<string>> modelpostCode = null, Expression<Func<string>> modelreferenceNumber = null, Expression<Func<string>> modelsupplierName = null, Expression<Func<string>> modeltelephone = null, Expression<Func<string>> modeltype = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_modelid = WorkflowExpression.Compile(modelid, nameof(modelid), required: false);
            var __workflow_modeladdressLines = WorkflowExpression.Compile(modeladdressLines, nameof(modeladdressLines), required: false);
            var __workflow_modelcontactName = WorkflowExpression.Compile(modelcontactName, nameof(modelcontactName), required: false);
            var __workflow_modelcountryCode = WorkflowExpression.Compile(modelcountryCode, nameof(modelcountryCode), required: false);
            var __workflow_modelemail = WorkflowExpression.Compile(modelemail, nameof(modelemail), required: false);
            var __workflow_modelpostCode = WorkflowExpression.Compile(modelpostCode, nameof(modelpostCode), required: false);
            var __workflow_modelreferenceNumber = WorkflowExpression.Compile(modelreferenceNumber, nameof(modelreferenceNumber), required: false);
            var __workflow_modelsupplierName = WorkflowExpression.Compile(modelsupplierName, nameof(modelsupplierName), required: false);
            var __workflow_modeltelephone = WorkflowExpression.Compile(modeltelephone, nameof(modeltelephone), required: false);
            var __workflow_modeltype = WorkflowExpression.Compile(modeltype, nameof(modeltype), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = "/api/SupplierIntegration/Update";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = ExpressionConverter.Convert(__workflow_id);
                var model = new JObject();
                var modelpropCount = 0;
                if (__workflow_modelid != null)
                {
                    model["Id"] = ExpressionConverter.ConvertO(__workflow_modelid);
                    modelpropCount++;
                }

                if (__workflow_modeladdressLines != null)
                {
                    model["AddressLines"] = ExpressionConverter.ConvertO(__workflow_modeladdressLines);
                    modelpropCount++;
                }

                if (__workflow_modelcontactName != null)
                {
                    model["ContactName"] = ExpressionConverter.ConvertO(__workflow_modelcontactName);
                    modelpropCount++;
                }

                if (__workflow_modelcountryCode != null)
                {
                    model["CountryCode"] = ExpressionConverter.ConvertO(__workflow_modelcountryCode);
                    modelpropCount++;
                }

                if (__workflow_modelemail != null)
                {
                    model["Email"] = ExpressionConverter.ConvertO(__workflow_modelemail);
                    modelpropCount++;
                }

                if (__workflow_modelpostCode != null)
                {
                    model["PostCode"] = ExpressionConverter.ConvertO(__workflow_modelpostCode);
                    modelpropCount++;
                }

                if (__workflow_modelreferenceNumber != null)
                {
                    model["ReferenceNumber"] = ExpressionConverter.ConvertO(__workflow_modelreferenceNumber);
                    modelpropCount++;
                }

                if (__workflow_modelsupplierName != null)
                {
                    model["SupplierName"] = ExpressionConverter.ConvertO(__workflow_modelsupplierName);
                    modelpropCount++;
                }

                if (__workflow_modeltelephone != null)
                {
                    model["Telephone"] = ExpressionConverter.ConvertO(__workflow_modeltelephone);
                    modelpropCount++;
                }

                if (__workflow_modeltype != null)
                {
                    model["Type"] = ExpressionConverter.ConvertO(__workflow_modeltype);
                    modelpropCount++;
                }

                if (modelpropCount > 0)
                {
                    callPayload.Body = model;
                }

                return new ApiConnectionAction<JToken>(callPayload);
            });
        }
    }

    public class ZaharaTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<CostCodeIntegrationModel[]> NewCostCode(FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/api/CostCodeIntegration/GetAll";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<CostCodeIntegrationModel[]>(callPayload, recurrence: recurrence);
        }

        public IBodyWorkflowTrigger<ProcessLogIntegrationModel[]> NewApprovalComment(FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/api/DocumentsIntegration/GetApprovalComments";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<ProcessLogIntegrationModel[]>(callPayload, recurrence: recurrence);
        }

        public IBodyWorkflowTrigger<ProcessLogIntegrationModel[]> NewDocumentApproved(Expression<Func<documentTypeInput>> documentType, FlowRecurrence recurrence = null)
        {
            var __workflow_documentType = WorkflowExpression.Compile(documentType, nameof(documentType), required: true);
            return new DeferredBodyTrigger<ProcessLogIntegrationModel[]>(() =>
            {
                var apiCallPath = "/api/DocumentsIntegration/GetApproved";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["documentType"] = ExpressionConverter.Convert(__workflow_documentType);
                return new ApiConnectionTrigger<ProcessLogIntegrationModel[]>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<InvoiceIntegrationModel[]> NewInvoice(FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/api/InvoiceIntegration/GetAll";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<InvoiceIntegrationModel[]>(callPayload, recurrence: recurrence);
        }

        public IBodyWorkflowTrigger<InvoiceIntegrationModel[]> NewInvoiceSetAsExported(FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/api/InvoiceIntegration/GetExported";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<InvoiceIntegrationModel[]>(callPayload, recurrence: recurrence);
        }

        public IBodyWorkflowTrigger<NominalCodeIntegrationModel[]> NewNominalCode(FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/api/NominalCodeIntegration/GetAll";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<NominalCodeIntegrationModel[]>(callPayload, recurrence: recurrence);
        }

        public IBodyWorkflowTrigger<ProjectIntegrationModel[]> NewProject(FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/api/ProjectIntegration/getall";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<ProjectIntegrationModel[]>(callPayload, recurrence: recurrence);
        }

        public IBodyWorkflowTrigger<PurchaseOrderIntegrationModel[]> NewPurchaseOrder(FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/api/PurchaseOrderIntegration/GetAll";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<PurchaseOrderIntegrationModel[]>(callPayload, recurrence: recurrence);
        }

        public IBodyWorkflowTrigger<PurchaseOrderIntegrationModel[]> NewPurchaseOrderSentToSupplier(FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/api/PurchaseOrderIntegration/GetSentToSupplier";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<PurchaseOrderIntegrationModel[]>(callPayload, recurrence: recurrence);
        }

        public IBodyWorkflowTrigger<PurchaseRequsitionIntegrationModel[]> NewPurchaseRequsition(FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/api/PurchaseRequsitionIntegration/getall";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<PurchaseRequsitionIntegrationModel[]>(callPayload, recurrence: recurrence);
        }

        public IBodyWorkflowTrigger<SupplierIntegrationModel[]> NewSupplier(FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/api/SupplierIntegration/GetAll";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<SupplierIntegrationModel[]>(callPayload, recurrence: recurrence);
        }

        public IBodyWorkflowTrigger<SupplierUpdateIntegrationModel[]> SupplierAmended(FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/api/SupplierIntegration/GetAllUpdated";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<SupplierUpdateIntegrationModel[]>(callPayload, recurrence: recurrence);
        }

        public IBodyWorkflowTrigger<TaxCodeIntegrationModel[]> NewTaxCode(FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/api/TaxCodeIntegration/getall";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<TaxCodeIntegrationModel[]>(callPayload, recurrence: recurrence);
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
