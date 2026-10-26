//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Ramquestactions
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class RamquestactionsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ramquestactions")]
        public IBodyWorkflowAction<TitleOrderV5, ApiConnectionActionConfiguration> GetTitleOrder(Expression<Func<string>> orderId)
        {
            var __workflow_orderId = WorkflowExpression.Compile(orderId, nameof(orderId), required: true);
            return new DeferredBodyAction<TitleOrderV5, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/pubcs-titleorder/v2/order/{0}", __workflow_orderId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<TitleOrderV5>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ramquestactions")]
        public IWorkflowAction<ApiConnectionActionConfiguration> AddNoteByOrder(Expression<Func<string>> orderId, Expression<Func<string>> note)
        {
            var __workflow_orderId = WorkflowExpression.Compile(orderId, nameof(orderId), required: true);
            var __workflow_note = WorkflowExpression.Compile(note, nameof(note), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/pubcs-titleorder/v1/order/{0}/note", __workflow_orderId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_note);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ramquestactions")]
        public IWorkflowAction<ApiConnectionActionConfiguration> AddDocumentToOrder(Expression<Func<string>> orderId, Expression<Func<string>> fileName, Expression<Func<string>> fileContent, Expression<Func<string>> documentCategory = null)
        {
            var __workflow_orderId = WorkflowExpression.Compile(orderId, nameof(orderId), required: true);
            var __workflow_fileName = WorkflowExpression.Compile(fileName, nameof(fileName), required: true);
            var __workflow_fileContent = WorkflowExpression.Compile(fileContent, nameof(fileContent), required: true);
            var __workflow_documentCategory = WorkflowExpression.Compile(documentCategory, nameof(documentCategory), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/pubcs-titleorder/v2/orders/{0}/documents", __workflow_orderId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["fileName"] = ExpressionConverter.Convert(__workflow_fileName);
                if (__workflow_documentCategory != null)
                    callPayload.Queries["documentCategory"] = ExpressionConverter.Convert(__workflow_documentCategory);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_fileContent);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ramquestactions")]
        public IBodyWorkflowAction<GetDocumentFromOrderResponse, ApiConnectionActionConfiguration> GetDocumentFromOrder(Expression<Func<string>> orderId, Expression<Func<string>> documentId)
        {
            var __workflow_orderId = WorkflowExpression.Compile(orderId, nameof(orderId), required: true);
            var __workflow_documentId = WorkflowExpression.Compile(documentId, nameof(documentId), required: true);
            return new DeferredBodyAction<GetDocumentFromOrderResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/pubcs-titleorder/v1/orders/{0}/documents/{1}", __workflow_orderId.WithUrlEncoding(1), __workflow_documentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetDocumentFromOrderResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ramquestactions")]
        public IBodyWorkflowAction<OrderWorkflowTask[], ApiConnectionActionConfiguration> GetTask(Expression<Func<string>> orderId, Expression<Func<string>> taskId = null)
        {
            var __workflow_orderId = WorkflowExpression.Compile(orderId, nameof(orderId), required: true);
            var __workflow_taskId = WorkflowExpression.Compile(taskId, nameof(taskId), required: false);
            return new DeferredBodyAction<OrderWorkflowTask[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/pubcs-titleorder/v1/{0}/tasks", __workflow_orderId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_taskId != null)
                    callPayload.Queries["taskId"] = ExpressionConverter.Convert(__workflow_taskId);
                return new ApiConnectionAction<OrderWorkflowTask[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ramquestactions")]
        public IWorkflowAction<ApiConnectionActionConfiguration> AddTask(Expression<Func<string>> orderId, Expression<Func<AddTaskInput>> body)
        {
            var __workflow_orderId = WorkflowExpression.Compile(orderId, nameof(orderId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/pubcs-titleorder/v1/task";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["orderId"] = ExpressionConverter.Convert(__workflow_orderId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ramquestactions")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UpdateTask(Expression<Func<string>> orderId, Expression<Func<UpdateTaskInput>> body)
        {
            var __workflow_orderId = WorkflowExpression.Compile(orderId, nameof(orderId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/pubcs-titleorder/v1/task";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["orderId"] = ExpressionConverter.Convert(__workflow_orderId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ramquestactions")]
        public IBodyWorkflowAction<CreateIdentitySearchResponse, ApiConnectionActionConfiguration> CreateIdentitySearch(Expression<Func<string>> smSourceFileId, Expression<Func<PubCSTitleOrderApiModelsIdentitySearchInput[]>> body)
        {
            var __workflow_smSourceFileId = WorkflowExpression.Compile(smSourceFileId, nameof(smSourceFileId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CreateIdentitySearchResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/patriot-search/v3/search";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["pdf"] = Convert.ToString(false);
                callPayload.Headers["sm-source-file-id"] = ExpressionConverter.Convert(__workflow_smSourceFileId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateIdentitySearchResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ramquestactions")]
        public IBodyWorkflowAction<object, ApiConnectionActionConfiguration> CreateIdentitySearchPDF(Expression<Func<string>> smSourceFileId, Expression<Func<PubCSTitleOrderApiModelsIdentitySearchInput[]>> body)
        {
            var __workflow_smSourceFileId = WorkflowExpression.Compile(smSourceFileId, nameof(smSourceFileId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<object, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/patriot-search/v3//search";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["pdf"] = Convert.ToString(true);
                callPayload.Headers["sm-source-file-id"] = ExpressionConverter.Convert(__workflow_smSourceFileId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<object>(callPayload);
            });
        }
    }

    public class RamquestactionsTriggers([ConnectionName] string connectionId)
    {
    }

    public class TitleOrderV5
    {
        [JsonProperty("commitment")]
        public TitleOrderV5CommitmentType Commitment { get; set; }

        [JsonProperty("detail")]
        public TitleOrderV5DetailType Detail { get; set; }

        [JsonProperty("documents")]
        public TitleOrderV5DocumentsTypeItem[] Documents { get; set; }

        [JsonProperty("financial")]
        public TitleOrderV5FinancialType Financial { get; set; }

        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("notes")]
        public TitleOrderV5NotesTypeItem[] Notes { get; set; }

        [JsonProperty("parties")]
        public TitleOrderV5PartiesTypeItem[] Parties { get; set; }

        [JsonProperty("policy")]
        public TitleOrderV5PolicyType Policy { get; set; }

        [JsonProperty("products")]
        public TitleOrderV5ProductsTypeItem[] Products { get; set; }

        [JsonProperty("properties")]
        public TitleOrderV5PropertiesTypeItem[] Properties { get; set; }

        [JsonProperty("transactionParties")]
        public TitleOrderV5TransactionPartiesType TransactionParties { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }
    }

    public class TitleOrderV5CommitmentType
    {
        [JsonProperty("attributes")]
        public JToken Attributes { get; set; }

        [JsonProperty("scheduleA")]
        public TitleOrderV5CommitmentTypeScheduleATypeItem[] ScheduleA { get; set; }

        [JsonProperty("scheduleB")]
        public TitleOrderV5CommitmentTypeScheduleBTypeItem[] ScheduleB { get; set; }

        [JsonProperty("scheduleCD")]
        public TitleOrderV5CommitmentTypeScheduleCDTypeItem[] ScheduleCD { get; set; }
    }

    public class TitleOrderV5CommitmentTypeScheduleATypeItem
    {
        [JsonProperty("binderNumber")]
        public string BinderNumber { get; set; }

        [JsonProperty("commitmentNumber")]
        public string CommitmentNumber { get; set; }

        [JsonProperty("currentHolders")]
        public string CurrentHolders { get; set; }

        [JsonProperty("dates")]
        public TitleOrderV5CommitmentTypeScheduleATypeItemDatesTypeItem[] Dates { get; set; }

        [JsonProperty("interestInLand")]
        public string InterestInLand { get; set; }

        [JsonProperty("legalDescription")]
        public string LegalDescription { get; set; }

        [JsonProperty("lienDescription")]
        public string LienDescription { get; set; }

        [JsonProperty("ownerInsured")]
        public string OwnerInsured { get; set; }

        [JsonProperty("sequence")]
        public string Sequence { get; set; }
    }

    public class TitleOrderV5CommitmentTypeScheduleATypeItemDatesTypeItem
    {
        public TitleOrderV5CommitmentTypeScheduleATypeItemDatesTypeItemTypeType Type { get; set; }
        public string Value { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum TitleOrderV5CommitmentTypeScheduleATypeItemDatesTypeItemTypeType
    {
        Application,
        Canceled,
        Closing,
        Commit,
        Created,
        Expiration,
        Effective,
        Opened,
        Other,
        Policy,
        Published,
        Remit,
        Report,
        Submit,
        Updated,
        Ordered,
        Fulfilled,
        Completed,
        Due,
        Delivered,
        Accepted,
        Failed,
        Funding,
        Issued
    }

    public class TitleOrderV5CommitmentTypeScheduleBTypeItem
    {
        [JsonProperty("assignedLanguage")]
        public TitleOrderV5CommitmentTypeScheduleBTypeItemAssignedLanguageTypeItem[] AssignedLanguage { get; set; }

        [JsonProperty("borrower")]
        public string Borrower { get; set; }

        [JsonProperty("county")]
        public TitleOrderV5CommitmentTypeScheduleBTypeItemCountyType County { get; set; }

        [JsonProperty("insured")]
        public string Insured { get; set; }

        [JsonProperty("loanSequenceId")]
        public int LoanSequenceId { get; set; }

        [JsonProperty("propertyType")]
        public string PropertyType { get; set; }

        [JsonProperty("sequence")]
        public int Sequence { get; set; }

        [JsonProperty("signatory")]
        public string Signatory { get; set; }

        [JsonProperty("standbyYear")]
        public int StandbyYear { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("survey")]
        public TitleOrderV5CommitmentTypeScheduleBTypeItemSurveyType Survey { get; set; }

        [JsonProperty("titleVestedIn")]
        public string TitleVestedIn { get; set; }
    }

    public class TitleOrderV5CommitmentTypeScheduleBTypeItemAssignedLanguageTypeItem
    {
        [JsonProperty("appliesTo")]
        public TitleOrderV5CommitmentTypeScheduleBTypeItemAssignedLanguageTypeItemAppliesToType AppliesTo { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("rtf")]
        public string Rtf { get; set; }

        [JsonProperty("sequence")]
        public int Sequence { get; set; }

        [JsonProperty("type")]
        public TitleOrderV5CommitmentTypeScheduleBTypeItemAssignedLanguageTypeItemTypeType Type { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum TitleOrderV5CommitmentTypeScheduleBTypeItemAssignedLanguageTypeItemAppliesToType
    {
        None,
        Mortgage,
        Owner,
        All
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum TitleOrderV5CommitmentTypeScheduleBTypeItemAssignedLanguageTypeItemTypeType
    {
        Exceptions,
        SubordinateLiens,
        RestrictiveCovenants,
        RequiredDocuments,
        Requirements,
        PolicyInsuredMortgage,
        PolicyExceptions,
        PolicyRestrictiveCovenants,
        PolicySubordinateLiens,
        PolicyOwnerScheduleB,
        Custom,
        NotesToCloser,
        Unknown
    }

    public class TitleOrderV5CommitmentTypeScheduleBTypeItemCountyType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("fips")]
        public string Fips { get; set; }

        [JsonProperty("statecode")]
        public int Statecode { get; set; }

        [JsonProperty("countycode")]
        public int Countycode { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum TitleOrderV5CommitmentTypeScheduleBTypeItemSurveyType
    {
        None,
        Need,
        Have
    }

    public class TitleOrderV5CommitmentTypeScheduleCDTypeItem
    {
        [JsonProperty("assignedLanguage")]
        public TitleOrderV5CommitmentTypeScheduleCDTypeItemAssignedLanguageTypeItem[] AssignedLanguage { get; set; }

        [JsonProperty("loanSequenceId")]
        public int LoanSequenceId { get; set; }

        [JsonProperty("sequence")]
        public int Sequence { get; set; }
    }

    public class TitleOrderV5CommitmentTypeScheduleCDTypeItemAssignedLanguageTypeItem
    {
        [JsonProperty("appliesTo")]
        public TitleOrderV5CommitmentTypeScheduleCDTypeItemAssignedLanguageTypeItemAppliesToType AppliesTo { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("rtf")]
        public string Rtf { get; set; }

        [JsonProperty("sequence")]
        public int Sequence { get; set; }

        [JsonProperty("type")]
        public TitleOrderV5CommitmentTypeScheduleCDTypeItemAssignedLanguageTypeItemTypeType Type { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum TitleOrderV5CommitmentTypeScheduleCDTypeItemAssignedLanguageTypeItemAppliesToType
    {
        None,
        Mortgage,
        Owner,
        All
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum TitleOrderV5CommitmentTypeScheduleCDTypeItemAssignedLanguageTypeItemTypeType
    {
        Exceptions,
        SubordinateLiens,
        RestrictiveCovenants,
        RequiredDocuments,
        Requirements,
        PolicyInsuredMortgage,
        PolicyExceptions,
        PolicyRestrictiveCovenants,
        PolicySubordinateLiens,
        PolicyOwnerScheduleB,
        Custom,
        NotesToCloser,
        Unknown
    }

    public class TitleOrderV5DetailType
    {
        [JsonProperty("agents")]
        public JToken Agents { get; set; }

        [JsonProperty("association")]
        public TitleOrderV5DetailTypeAssociationType Association { get; set; }

        [JsonProperty("attributes")]
        public JToken Attributes { get; set; }

        [JsonProperty("branch")]
        public string Branch { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("dates")]
        public TitleOrderV5DetailTypeDatesTypeItem[] Dates { get; set; }

        [JsonProperty("escrowBank")]
        public TitleOrderV5DetailTypeEscrowBankType EscrowBank { get; set; }

        [JsonProperty("fileNumber")]
        public string FileNumber { get; set; }

        [JsonProperty("otherEnterpriseFileNumber")]
        public string OtherEnterpriseFileNumber { get; set; }

        [JsonProperty("referenceKey")]
        public string ReferenceKey { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("service")]
        public TitleOrderV5DetailTypeServiceType Service { get; set; }

        [JsonProperty("sourceOfBusiness")]
        public string SourceOfBusiness { get; set; }

        [JsonProperty("status")]
        public TitleOrderV5DetailTypeStatusType Status { get; set; }

        [JsonProperty("template")]
        public string Template { get; set; }

        [JsonProperty("titleCompany")]
        public TitleOrderV5DetailTypeTitleCompanyType TitleCompany { get; set; }

        [JsonProperty("transactionId")]
        public string TransactionId { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("underwriter")]
        public TitleOrderV5DetailTypeUnderwriterType Underwriter { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum TitleOrderV5DetailTypeAssociationType
    {
        TLTA,
        ALTA
    }

    public class TitleOrderV5DetailTypeDatesTypeItem
    {
        public TitleOrderV5DetailTypeDatesTypeItemTypeType Type { get; set; }
        public string Value { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum TitleOrderV5DetailTypeDatesTypeItemTypeType
    {
        Application,
        Canceled,
        Closing,
        Commit,
        Created,
        Expiration,
        Effective,
        Opened,
        Other,
        Policy,
        Published,
        Remit,
        Report,
        Submit,
        Updated,
        Ordered,
        Fulfilled,
        Completed,
        Due,
        Delivered,
        Accepted,
        Failed,
        Funding,
        Issued
    }

    public class TitleOrderV5DetailTypeEscrowBankType
    {
        public string NickName { get; set; }
        public string PartyIdReference { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum TitleOrderV5DetailTypeServiceType
    {
        Other,
        Owner,
        OwnerNonResidential,
        Mortgage,
        Simultaneous,
        SimultaneousNonResidential,
        Binder,
        TitleGuarantee,
        ConstructionLoan,
        Undefined
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum TitleOrderV5DetailTypeStatusType
    {
        Cancelled,
        Open,
        Closed,
        Undefined,
        New,
        Template,
        [EnumMember(Value = "On Hold")]
        OnHold,
        Old,
        Legacy
    }

    public class TitleOrderV5DetailTypeTitleCompanyType
    {
        public string NickName { get; set; }
        public string PartyIdReference { get; set; }
    }

    public class TitleOrderV5DetailTypeUnderwriterType
    {
        public string NickName { get; set; }
        public string PartyIdReference { get; set; }
    }

    public class TitleOrderV5DocumentsTypeItem
    {
        [JsonProperty("attributes")]
        public JToken Attributes { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("date")]
        public TitleOrderV5DocumentsTypeItemDateType Date { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("documentBase64")]
        public string DocumentBase64 { get; set; }

        [JsonProperty("fileName")]
        public string FileName { get; set; }

        [JsonProperty("format")]
        public TitleOrderV5DocumentsTypeItemFormatType Format { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("publisher")]
        public string Publisher { get; set; }

        [JsonProperty("submissionReference")]
        public string SubmissionReference { get; set; }
    }

    public class TitleOrderV5DocumentsTypeItemDateType
    {
        public TitleOrderV5DocumentsTypeItemDateTypeTypeType Type { get; set; }
        public string Value { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum TitleOrderV5DocumentsTypeItemDateTypeTypeType
    {
        Application,
        Canceled,
        Closing,
        Commit,
        Created,
        Expiration,
        Effective,
        Opened,
        Other,
        Policy,
        Published,
        Remit,
        Report,
        Submit,
        Updated,
        Ordered,
        Fulfilled,
        Completed,
        Due,
        Delivered,
        Accepted,
        Failed,
        Funding,
        Issued
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum TitleOrderV5DocumentsTypeItemFormatType
    {
        JPEG,
        PNG,
        DOC,
        DOCX,
        XLS,
        XLSX,
        TXT,
        RTF,
        PDF,
        CSV,
        XML
    }

    public class TitleOrderV5FinancialType
    {
        [JsonProperty("attributes")]
        public JToken Attributes { get; set; }

        [JsonProperty("cashOutAmount")]
        public double CashOutAmount { get; set; }

        [JsonProperty("downPayment")]
        public double DownPayment { get; set; }

        [JsonProperty("earnestMoney")]
        public double EarnestMoney { get; set; }

        [JsonProperty("loanPolicyLiabilityOverride")]
        public double LoanPolicyLiabilityOverride { get; set; }

        [JsonProperty("loans")]
        public TitleOrderV5FinancialTypeLoansTypeItem[] Loans { get; set; }

        [JsonProperty("ownerPolicyLiabilityOverride")]
        public double OwnerPolicyLiabilityOverride { get; set; }

        [JsonProperty("purchasePrice")]
        public double PurchasePrice { get; set; }

        [JsonProperty("purpose")]
        public string Purpose { get; set; }

        [JsonProperty("transactionType")]
        public TitleOrderV5FinancialTypeTransactionTypeType TransactionType { get; set; }
    }

    public class TitleOrderV5FinancialTypeLoansTypeItem
    {
        [JsonProperty("amount")]
        public double Amount { get; set; }

        [JsonProperty("attributes")]
        public JToken Attributes { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("lender")]
        public TitleOrderV5FinancialTypeLoansTypeItemLenderType Lender { get; set; }

        [JsonProperty("loanDetail")]
        public TitleOrderV5FinancialTypeLoansTypeItemLoanDetailType LoanDetail { get; set; }

        [JsonProperty("loanNumber")]
        public string LoanNumber { get; set; }

        [JsonProperty("loanPolicyLiability")]
        public double LoanPolicyLiability { get; set; }

        [JsonProperty("mortgageBroker")]
        public TitleOrderV5FinancialTypeLoansTypeItemMortgageBrokerType MortgageBroker { get; set; }

        [JsonProperty("mortgageInsuranceCase")]
        public string MortgageInsuranceCase { get; set; }

        [JsonProperty("sequence")]
        public int Sequence { get; set; }
    }

    public class TitleOrderV5FinancialTypeLoansTypeItemLenderType
    {
        public string NickName { get; set; }
        public string PartyIdReference { get; set; }
    }

    public class TitleOrderV5FinancialTypeLoansTypeItemLoanDetailType
    {
        [JsonProperty("apr")]
        public double Apr { get; set; }

        [JsonProperty("payment")]
        public TitleOrderV5FinancialTypeLoansTypeItemLoanDetailTypePaymentType Payment { get; set; }

        [JsonProperty("rate")]
        public double Rate { get; set; }

        [JsonProperty("term")]
        public int Term { get; set; }
    }

    public class TitleOrderV5FinancialTypeLoansTypeItemLoanDetailTypePaymentType
    {
        [JsonProperty("hoa")]
        public double Hoa { get; set; }

        [JsonProperty("interest")]
        public double Interest { get; set; }

        [JsonProperty("mortgageInsurance")]
        public double MortgageInsurance { get; set; }

        [JsonProperty("principal")]
        public double Principal { get; set; }

        [JsonProperty("taxes")]
        public double Taxes { get; set; }

        [JsonProperty("totalMonthly")]
        public double TotalMonthly { get; set; }
    }

    public class TitleOrderV5FinancialTypeLoansTypeItemMortgageBrokerType
    {
        public string NickName { get; set; }
        public string PartyIdReference { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum TitleOrderV5FinancialTypeTransactionTypeType
    {
        Purchase,
        Refinance,
        HomeEquity
    }

    public class TitleOrderV5NotesTypeItem
    {
        [JsonProperty("date")]
        public TitleOrderV5NotesTypeItemDateType Date { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("publisher")]
        public string Publisher { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }

    public class TitleOrderV5NotesTypeItemDateType
    {
        public TitleOrderV5NotesTypeItemDateTypeTypeType Type { get; set; }
        public string Value { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum TitleOrderV5NotesTypeItemDateTypeTypeType
    {
        Application,
        Canceled,
        Closing,
        Commit,
        Created,
        Expiration,
        Effective,
        Opened,
        Other,
        Policy,
        Published,
        Remit,
        Report,
        Submit,
        Updated,
        Ordered,
        Fulfilled,
        Completed,
        Due,
        Delivered,
        Accepted,
        Failed,
        Funding,
        Issued
    }

    public class TitleOrderV5PartiesTypeItem
    {
        [JsonProperty("addresses")]
        public JToken[] Addresses { get; set; }

        [JsonProperty("attributes")]
        public JToken Attributes { get; set; }

        [JsonProperty("communications")]
        public TitleOrderV5PartiesTypeItemCommunicationsTypeItem[] Communications { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public JToken Name { get; set; }

        [JsonProperty("partyId")]
        public int PartyId { get; set; }

        [JsonProperty("role")]
        public TitleOrderV5PartiesTypeItemRoleType Role { get; set; }

        [JsonProperty("roleType")]
        public string RoleType { get; set; }
    }

    public class TitleOrderV5PartiesTypeItemCommunicationsTypeItem
    {
        [JsonProperty("foreign")]
        public bool Foreign { get; set; }

        [JsonProperty("primary")]
        public bool Primary { get; set; }

        [JsonProperty("type")]
        public TitleOrderV5PartiesTypeItemCommunicationsTypeItemTypeType Type { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum TitleOrderV5PartiesTypeItemCommunicationsTypeItemTypeType
    {
        Unspecified,
        Cellular,
        Home,
        Fax,
        Email,
        Website,
        BusinessPhone,
        BusinessFax,
        BusinessEmail,
        Other
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum TitleOrderV5PartiesTypeItemRoleType
    {
        Buyer,
        Seller,
        Lender,
        Broker,
        Realtor,
        Attorney,
        Agent,
        Other
    }

    public class TitleOrderV5PolicyType
    {
        public TitleOrderV5PolicyTypeLoanPoliciesTypeItem[] LoanPolicies { get; set; }
        public TitleOrderV5PolicyTypeOwnerPoliciesTypeItem[] OwnerPolicies { get; set; }

        [JsonProperty("attributes")]
        public JToken Attributes { get; set; }
    }

    public class TitleOrderV5PolicyTypeLoanPoliciesTypeItem
    {
        public int LoanSequenceId { get; set; }
        public int Sequence { get; set; }
    }

    public class TitleOrderV5PolicyTypeOwnerPoliciesTypeItem
    {
        public string TitleVestedIn { get; set; }
    }

    public class TitleOrderV5ProductsTypeItem
    {
        [JsonProperty("attributes")]
        public JToken Attributes { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("dates")]
        public TitleOrderV5ProductsTypeItemDatesTypeItem[] Dates { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("productReferenceKey")]
        public string ProductReferenceKey { get; set; }

        [JsonProperty("submissionReference")]
        public string SubmissionReference { get; set; }
    }

    public class TitleOrderV5ProductsTypeItemDatesTypeItem
    {
        public TitleOrderV5ProductsTypeItemDatesTypeItemTypeType Type { get; set; }
        public string Value { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum TitleOrderV5ProductsTypeItemDatesTypeItemTypeType
    {
        Application,
        Canceled,
        Closing,
        Commit,
        Created,
        Expiration,
        Effective,
        Opened,
        Other,
        Policy,
        Published,
        Remit,
        Report,
        Submit,
        Updated,
        Ordered,
        Fulfilled,
        Completed,
        Due,
        Delivered,
        Accepted,
        Failed,
        Funding,
        Issued
    }

    public class TitleOrderV5PropertiesTypeItem
    {
        [JsonProperty("propertyType")]
        public TitleOrderV5PropertiesTypeItemPropertyTypeType PropertyType { get; set; }

        [JsonProperty("attributes")]
        public JToken Attributes { get; set; }

        [JsonProperty("sequence")]
        public int Sequence { get; set; }

        [JsonProperty("taxIdentifier")]
        public string TaxIdentifier { get; set; }

        [JsonProperty("address")]
        public TitleOrderV5PropertiesTypeItemAddressType Address { get; set; }

        [JsonProperty("parcel")]
        public string[] Parcel { get; set; }

        [JsonProperty("taxes")]
        public TitleOrderV5PropertiesTypeItemTaxesTypeItem[] Taxes { get; set; }

        [JsonProperty("legalDescription")]
        public string LegalDescription { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum TitleOrderV5PropertiesTypeItemPropertyTypeType
    {
        SingleFamily,
        MultiFamily,
        ManufacturedHome,
        Commercial,
        Land,
        Townhome,
        CondoOrApartment,
        NewConstruction,
        PUD,
        Duplex,
        Triplex
    }

    public class TitleOrderV5PropertiesTypeItemAddressType
    {
        [JsonProperty("type")]
        public TitleOrderV5PropertiesTypeItemAddressTypeTypeType Type { get; set; }

        [JsonProperty("line1")]
        public string Line1 { get; set; }

        [JsonProperty("line2")]
        public string Line2 { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("zip")]
        public string Zip { get; set; }

        [JsonProperty("county")]
        public TitleOrderV5PropertiesTypeItemAddressTypeCountyType County { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum TitleOrderV5PropertiesTypeItemAddressTypeTypeType
    {
        Business,
        Forwarding,
        Present,
        Mailing,
        Work,
        TransactionProperty,
        Other
    }

    public class TitleOrderV5PropertiesTypeItemAddressTypeCountyType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("fips")]
        public string Fips { get; set; }

        [JsonProperty("statecode")]
        public int Statecode { get; set; }

        [JsonProperty("countycode")]
        public int Countycode { get; set; }
    }

    public class TitleOrderV5PropertiesTypeItemTaxesTypeItem
    {
        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("payee")]
        public string Payee { get; set; }

        [JsonProperty("amount")]
        public double Amount { get; set; }
    }

    public class TitleOrderV5TransactionPartiesType
    {
        [JsonProperty("buyers")]
        public TitleOrderV5TransactionPartiesTypeBuyersTypeItem[] Buyers { get; set; }

        [JsonProperty("sellers")]
        public TitleOrderV5TransactionPartiesTypeSellersTypeItem[] Sellers { get; set; }
    }

    public class TitleOrderV5TransactionPartiesTypeBuyersTypeItem
    {
        public TitleOrderV5TransactionPartiesTypeBuyersTypeItemTax1099Type Tax1099 { get; set; }

        [JsonProperty("attorney")]
        public TitleOrderV5TransactionPartiesTypeBuyersTypeItemAttorneyType Attorney { get; set; }

        [JsonProperty("attributes")]
        public JToken Attributes { get; set; }

        [JsonProperty("businessName")]
        public TitleOrderV5TransactionPartiesTypeBuyersTypeItemBusinessNameType BusinessName { get; set; }

        [JsonProperty("communications")]
        public TitleOrderV5TransactionPartiesTypeBuyersTypeItemCommunicationsTypeItem[] Communications { get; set; }

        [JsonProperty("currentAddress")]
        public JToken CurrentAddress { get; set; }

        [JsonProperty("forwardingAddress")]
        public JToken ForwardingAddress { get; set; }

        [JsonProperty("primaryName")]
        public TitleOrderV5TransactionPartiesTypeBuyersTypeItemPrimaryNameType PrimaryName { get; set; }

        [JsonProperty("realtor")]
        public TitleOrderV5TransactionPartiesTypeBuyersTypeItemRealtorType Realtor { get; set; }

        [JsonProperty("relationship")]
        public string Relationship { get; set; }

        [JsonProperty("secondaryName")]
        public TitleOrderV5TransactionPartiesTypeBuyersTypeItemSecondaryNameType SecondaryName { get; set; }

        [JsonProperty("sequence")]
        public int Sequence { get; set; }
    }

    public class TitleOrderV5TransactionPartiesTypeBuyersTypeItemTax1099Type
    {
        [JsonProperty("allocationAmount")]
        public double AllocationAmount { get; set; }

        [JsonProperty("allocationPercent")]
        public double AllocationPercent { get; set; }

        [JsonProperty("generate1099")]
        public bool Generate1099 { get; set; }

        [JsonProperty("id")]
        public double Id { get; set; }

        [JsonProperty("overrideAutoProceedDistribution")]
        public bool OverrideAutoProceedDistribution { get; set; }

        [JsonProperty("propertyOrServicesReceived")]
        public string PropertyOrServicesReceived { get; set; }
    }

    public class TitleOrderV5TransactionPartiesTypeBuyersTypeItemAttorneyType
    {
        public string NickName { get; set; }
        public string PartyIdReference { get; set; }
    }

    public class TitleOrderV5TransactionPartiesTypeBuyersTypeItemBusinessNameType
    {
        public string NickName { get; set; }
        public string PartyIdReference { get; set; }
    }

    public class TitleOrderV5TransactionPartiesTypeBuyersTypeItemCommunicationsTypeItem
    {
        [JsonProperty("foreign")]
        public bool Foreign { get; set; }

        [JsonProperty("primary")]
        public bool Primary { get; set; }

        [JsonProperty("type")]
        public TitleOrderV5TransactionPartiesTypeBuyersTypeItemCommunicationsTypeItemTypeType Type { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum TitleOrderV5TransactionPartiesTypeBuyersTypeItemCommunicationsTypeItemTypeType
    {
        Unspecified,
        Cellular,
        Home,
        Fax,
        Email,
        Website,
        BusinessPhone,
        BusinessFax,
        BusinessEmail,
        Other
    }

    public class TitleOrderV5TransactionPartiesTypeBuyersTypeItemPrimaryNameType
    {
        public string NickName { get; set; }
        public string PartyIdReference { get; set; }
    }

    public class TitleOrderV5TransactionPartiesTypeBuyersTypeItemRealtorType
    {
        public string NickName { get; set; }
        public string PartyIdReference { get; set; }
    }

    public class TitleOrderV5TransactionPartiesTypeBuyersTypeItemSecondaryNameType
    {
        public string NickName { get; set; }
        public string PartyIdReference { get; set; }
    }

    public class TitleOrderV5TransactionPartiesTypeSellersTypeItem
    {
        public TitleOrderV5TransactionPartiesTypeSellersTypeItemTax1099Type Tax1099 { get; set; }

        [JsonProperty("attorney")]
        public TitleOrderV5TransactionPartiesTypeSellersTypeItemAttorneyType Attorney { get; set; }

        [JsonProperty("attributes")]
        public JToken Attributes { get; set; }

        [JsonProperty("businessName")]
        public TitleOrderV5TransactionPartiesTypeSellersTypeItemBusinessNameType BusinessName { get; set; }

        [JsonProperty("communications")]
        public TitleOrderV5TransactionPartiesTypeSellersTypeItemCommunicationsTypeItem[] Communications { get; set; }

        [JsonProperty("currentAddress")]
        public JToken CurrentAddress { get; set; }

        [JsonProperty("forwardingAddress")]
        public JToken ForwardingAddress { get; set; }

        [JsonProperty("primaryName")]
        public TitleOrderV5TransactionPartiesTypeSellersTypeItemPrimaryNameType PrimaryName { get; set; }

        [JsonProperty("realtor")]
        public TitleOrderV5TransactionPartiesTypeSellersTypeItemRealtorType Realtor { get; set; }

        [JsonProperty("relationship")]
        public string Relationship { get; set; }

        [JsonProperty("secondaryName")]
        public TitleOrderV5TransactionPartiesTypeSellersTypeItemSecondaryNameType SecondaryName { get; set; }

        [JsonProperty("sequence")]
        public int Sequence { get; set; }
    }

    public class TitleOrderV5TransactionPartiesTypeSellersTypeItemTax1099Type
    {
        [JsonProperty("allocationAmount")]
        public double AllocationAmount { get; set; }

        [JsonProperty("allocationPercent")]
        public double AllocationPercent { get; set; }

        [JsonProperty("generate1099")]
        public bool Generate1099 { get; set; }

        [JsonProperty("id")]
        public double Id { get; set; }

        [JsonProperty("overrideAutoProceedDistribution")]
        public bool OverrideAutoProceedDistribution { get; set; }

        [JsonProperty("propertyOrServicesReceived")]
        public string PropertyOrServicesReceived { get; set; }
    }

    public class TitleOrderV5TransactionPartiesTypeSellersTypeItemAttorneyType
    {
        public string NickName { get; set; }
        public string PartyIdReference { get; set; }
    }

    public class TitleOrderV5TransactionPartiesTypeSellersTypeItemBusinessNameType
    {
        public string NickName { get; set; }
        public string PartyIdReference { get; set; }
    }

    public class TitleOrderV5TransactionPartiesTypeSellersTypeItemCommunicationsTypeItem
    {
        [JsonProperty("foreign")]
        public bool Foreign { get; set; }

        [JsonProperty("primary")]
        public bool Primary { get; set; }

        [JsonProperty("type")]
        public TitleOrderV5TransactionPartiesTypeSellersTypeItemCommunicationsTypeItemTypeType Type { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum TitleOrderV5TransactionPartiesTypeSellersTypeItemCommunicationsTypeItemTypeType
    {
        Unspecified,
        Cellular,
        Home,
        Fax,
        Email,
        Website,
        BusinessPhone,
        BusinessFax,
        BusinessEmail,
        Other
    }

    public class TitleOrderV5TransactionPartiesTypeSellersTypeItemPrimaryNameType
    {
        public string NickName { get; set; }
        public string PartyIdReference { get; set; }
    }

    public class TitleOrderV5TransactionPartiesTypeSellersTypeItemRealtorType
    {
        public string NickName { get; set; }
        public string PartyIdReference { get; set; }
    }

    public class TitleOrderV5TransactionPartiesTypeSellersTypeItemSecondaryNameType
    {
        public string NickName { get; set; }
        public string PartyIdReference { get; set; }
    }

    public class GetDocumentFromOrderResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("format")]
        public string Format { get; set; }

        [JsonProperty("fileName")]
        public string FileName { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("date")]
        public PubCSTitleOrderApiModelsDate Date { get; set; }

        [JsonProperty("publisher")]
        public string Publisher { get; set; }

        [JsonProperty("documentBase64")]
        public string DocumentBase64 { get; set; }
    }

    public class PubCSTitleOrderApiModelsDate
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class OrderWorkflowTask
    {
        [JsonProperty("gfno")]
        public string Gfno { get; set; }

        [JsonProperty("taskName")]
        public string TaskName { get; set; }

        [JsonProperty("taskId")]
        public int TaskId { get; set; }

        [JsonProperty("subItemId")]
        public string SubItemId { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }

        [JsonProperty("dueDate")]
        public string DueDate { get; set; }

        [JsonProperty("completedDate")]
        public string CompletedDate { get; set; }

        [JsonProperty("completedBy")]
        public string CompletedBy { get; set; }

        [JsonProperty("startDate")]
        public string StartDate { get; set; }

        [JsonProperty("isPublished")]
        public bool IsPublished { get; set; }

        [JsonProperty("isApplicable")]
        public bool IsApplicable { get; set; }
    }

    public class AddTaskInput
    {
        [JsonProperty("workflowTaskId", DefaultValueHandling = DefaultValueHandling.Include)]
        public int WorkflowTaskId { get; set; }

        [JsonProperty("taskNote", DefaultValueHandling = DefaultValueHandling.Include)]
        public string TaskNote { get; set; }

        [JsonProperty("targetStatus")]
        public AddTaskInputTargetStatusType? TargetStatus { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum AddTaskInputTargetStatusType
    {
        None,
        Complete,
        Open
    }

    public class UpdateTaskInput
    {
        [JsonProperty("workflowTaskId", DefaultValueHandling = DefaultValueHandling.Include)]
        public int WorkflowTaskId { get; set; }

        [JsonProperty("taskNote", DefaultValueHandling = DefaultValueHandling.Include)]
        public string TaskNote { get; set; }

        [JsonProperty("targetStatus")]
        public UpdateTaskInputTargetStatusType? TargetStatus { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum UpdateTaskInputTargetStatusType
    {
        None,
        Complete,
        Open
    }

    public class CreateIdentitySearchResponse
    {
        [JsonProperty("searchResults")]
        public PatriotSearchApiModelsSearchResult[] SearchResults { get; set; }
    }

    public class PatriotSearchApiModelsSearchResult
    {
        [JsonProperty("searchType")]
        public string SearchType { get; set; }

        [JsonProperty("entityType")]
        public string EntityType { get; set; }

        [JsonProperty("acronym")]
        public string Acronym { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("searchResultDetails")]
        public PatriotSearchApiModelsSearchResultDetail[] SearchResultDetails { get; set; }
    }

    public class PatriotSearchApiModelsSearchResultDetail
    {
        [JsonProperty("entityId")]
        public string EntityId { get; set; }

        [JsonProperty("entityType")]
        public string EntityType { get; set; }

        [JsonProperty("dataSourceName")]
        public string DataSourceName { get; set; }

        [JsonProperty("dataSourceType")]
        public string DataSourceType { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("fax")]
        public string Fax { get; set; }

        [JsonProperty("website")]
        public string Website { get; set; }

        [JsonProperty("dateOfBirthOrEstablishedDate")]
        public double DateOfBirthOrEstablishedDate { get; set; }

        [JsonProperty("dateOfBirthOrEstablishedDateFormatted")]
        public string DateOfBirthOrEstablishedDateFormatted { get; set; }

        [JsonProperty("lastUpdatedDate")]
        public double LastUpdatedDate { get; set; }

        [JsonProperty("lastUpdatedDateFormatted")]
        public string LastUpdatedDateFormatted { get; set; }

        [JsonProperty("matchedType")]
        public string MatchedType { get; set; }

        [JsonProperty("matchedName")]
        public string MatchedName { get; set; }

        [JsonProperty("entityAddresses")]
        public PatriotSearchApiModelsEntityAddress[] EntityAddresses { get; set; }

        [JsonProperty("entityNames")]
        public PatriotSearchApiModelsEntityName[] EntityNames { get; set; }
    }

    public class PatriotSearchApiModelsEntityAddress
    {
        [JsonProperty("address1")]
        public string Address1 { get; set; }

        [JsonProperty("address2")]
        public string Address2 { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("zip")]
        public string Zip { get; set; }

        [JsonProperty("county")]
        public string County { get; set; }
    }

    public class PatriotSearchApiModelsEntityName
    {
        [JsonProperty("nameType")]
        public string NameType { get; set; }

        [JsonProperty("nameValue")]
        public string NameValue { get; set; }

        [JsonProperty("lastUpdatedDate")]
        public string LastUpdatedDate { get; set; }
    }

    public class PubCSTitleOrderApiModelsIdentitySearchInput
    {
        [JsonProperty("name")]
        public PubCSTitleOrderApiModelsIdentitySearchInputNameType Name { get; set; }
    }

    public class PubCSTitleOrderApiModelsIdentitySearchInputNameType
    {
        [JsonProperty("business")]
        public string Business { get; set; }

        [JsonProperty("full")]
        public string Full { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Ramquestactions;

    public partial class WorkflowManagedActions
    {
        public RamquestactionsActions Ramquestactions(string connectionId) => new RamquestactionsActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public RamquestactionsTriggers Ramquestactions(string connectionId) => new RamquestactionsTriggers(connectionId);
    }
}