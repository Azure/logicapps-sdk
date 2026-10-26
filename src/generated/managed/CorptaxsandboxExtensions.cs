//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Corptaxsandbox
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CorptaxsandboxActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "corptaxsandbox")]
        public IWorkflowAction<ApiConnectionActionConfiguration> CorptaxEntityViews(Expression<Func<string>> environmentName, Expression<Func<string>> enterpriseName, Expression<Func<CorptaxEntityViewsInput>> body)
        {
            var __workflow_environmentName = WorkflowExpression.Compile(environmentName, nameof(environmentName), required: true);
            var __workflow_enterpriseName = WorkflowExpression.Compile(enterpriseName, nameof(enterpriseName), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/entityView";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["environmentName"] = ExpressionConverter.Convert(__workflow_environmentName);
                callPayload.Headers["enterpriseName"] = ExpressionConverter.Convert(__workflow_enterpriseName);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "corptaxsandbox")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DataExchangeLookup(Expression<Func<string>> environmentName, Expression<Func<string>> enterpriseName, Expression<Func<lookupTypeInput>> lookupType, Expression<Func<DataExchangeLookupInput>> body)
        {
            var __workflow_environmentName = WorkflowExpression.Compile(environmentName, nameof(environmentName), required: true);
            var __workflow_enterpriseName = WorkflowExpression.Compile(enterpriseName, nameof(enterpriseName), required: true);
            var __workflow_lookupType = WorkflowExpression.Compile(lookupType, nameof(lookupType), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/DataExchangeLookup";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["environmentName"] = ExpressionConverter.Convert(__workflow_environmentName);
                callPayload.Headers["enterpriseName"] = ExpressionConverter.Convert(__workflow_enterpriseName);
                callPayload.Headers["lookupType"] = ExpressionConverter.Convert(__workflow_lookupType);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "corptaxsandbox")]
        public IWorkflowAction<ApiConnectionActionConfiguration> EntityList(Expression<Func<string>> environmentName, Expression<Func<string>> enterpriseName, Expression<Func<EntityListInput>> body)
        {
            var __workflow_environmentName = WorkflowExpression.Compile(environmentName, nameof(environmentName), required: true);
            var __workflow_enterpriseName = WorkflowExpression.Compile(enterpriseName, nameof(enterpriseName), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/EntityLists";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["environmentName"] = ExpressionConverter.Convert(__workflow_environmentName);
                callPayload.Headers["enterpriseName"] = ExpressionConverter.Convert(__workflow_enterpriseName);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "corptaxsandbox")]
        public IWorkflowAction<ApiConnectionActionConfiguration> ExportData(Expression<Func<string>> environmentName, Expression<Func<string>> enterpriseName, Expression<Func<ExportDataInput>> body)
        {
            var __workflow_environmentName = WorkflowExpression.Compile(environmentName, nameof(environmentName), required: true);
            var __workflow_enterpriseName = WorkflowExpression.Compile(enterpriseName, nameof(enterpriseName), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/dataExport";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["environmentName"] = ExpressionConverter.Convert(__workflow_environmentName);
                callPayload.Headers["enterpriseName"] = ExpressionConverter.Convert(__workflow_enterpriseName);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "corptaxsandbox")]
        public IWorkflowAction<ApiConnectionActionConfiguration> ExportDataWithDataSource(Expression<Func<string>> environmentName, Expression<Func<string>> enterpriseName, Expression<Func<ExportDataWithDataSourceInput>> body)
        {
            var __workflow_environmentName = WorkflowExpression.Compile(environmentName, nameof(environmentName), required: true);
            var __workflow_enterpriseName = WorkflowExpression.Compile(enterpriseName, nameof(enterpriseName), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/dataExportWithDataSource";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["environmentName"] = ExpressionConverter.Convert(__workflow_environmentName);
                callPayload.Headers["enterpriseName"] = ExpressionConverter.Convert(__workflow_enterpriseName);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "corptaxsandbox")]
        public IBodyWorkflowAction<TriggerCartResponse, ApiConnectionActionConfiguration> TriggerCart(Expression<Func<string>> environmentName, Expression<Func<string>> enterpriseName, Expression<Func<TriggerCartInput>> body)
        {
            var __workflow_environmentName = WorkflowExpression.Compile(environmentName, nameof(environmentName), required: true);
            var __workflow_enterpriseName = WorkflowExpression.Compile(enterpriseName, nameof(enterpriseName), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<TriggerCartResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/triggerCart";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["environmentName"] = ExpressionConverter.Convert(__workflow_environmentName);
                callPayload.Headers["enterpriseName"] = ExpressionConverter.Convert(__workflow_enterpriseName);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<TriggerCartResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "corptaxsandbox")]
        public IBodyWorkflowAction<TriggerReturnResponse, ApiConnectionActionConfiguration> TriggerReturn(Expression<Func<string>> environmentName, Expression<Func<string>> enterpriseName, Expression<Func<TriggerReturnInput>> body)
        {
            var __workflow_environmentName = WorkflowExpression.Compile(environmentName, nameof(environmentName), required: true);
            var __workflow_enterpriseName = WorkflowExpression.Compile(enterpriseName, nameof(enterpriseName), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<TriggerReturnResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/triggerReturn";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["environmentName"] = ExpressionConverter.Convert(__workflow_environmentName);
                callPayload.Headers["enterpriseName"] = ExpressionConverter.Convert(__workflow_enterpriseName);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<TriggerReturnResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "corptaxsandbox")]
        public IBodyWorkflowAction<DownloadContentsResponseItem[], ApiConnectionActionConfiguration> DownloadContents(Expression<Func<string>> environmentName, Expression<Func<string>> enterpriseName, Expression<Func<typeOfActionInput>> typeOfAction, Expression<Func<DownloadContentsInput>> body)
        {
            var __workflow_environmentName = WorkflowExpression.Compile(environmentName, nameof(environmentName), required: true);
            var __workflow_enterpriseName = WorkflowExpression.Compile(enterpriseName, nameof(enterpriseName), required: true);
            var __workflow_typeOfAction = WorkflowExpression.Compile(typeOfAction, nameof(typeOfAction), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<DownloadContentsResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/downloadContents";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["environmentName"] = ExpressionConverter.Convert(__workflow_environmentName);
                callPayload.Headers["enterpriseName"] = ExpressionConverter.Convert(__workflow_enterpriseName);
                callPayload.Headers["typeOfAction"] = ExpressionConverter.Convert(__workflow_typeOfAction);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<DownloadContentsResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "corptaxsandbox")]
        public IBodyWorkflowAction<CheckTriggerStatusResponse, ApiConnectionActionConfiguration> CheckTriggerStatus(Expression<Func<string>> environmentName, Expression<Func<string>> enterpriseName, Expression<Func<typeOfActionInput>> typeOfAction, Expression<Func<CheckTriggerStatusInput>> body)
        {
            var __workflow_environmentName = WorkflowExpression.Compile(environmentName, nameof(environmentName), required: true);
            var __workflow_enterpriseName = WorkflowExpression.Compile(enterpriseName, nameof(enterpriseName), required: true);
            var __workflow_typeOfAction = WorkflowExpression.Compile(typeOfAction, nameof(typeOfAction), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CheckTriggerStatusResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/checkTriggerStatus";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["environmentName"] = ExpressionConverter.Convert(__workflow_environmentName);
                callPayload.Headers["enterpriseName"] = ExpressionConverter.Convert(__workflow_enterpriseName);
                callPayload.Headers["typeOfAction"] = ExpressionConverter.Convert(__workflow_typeOfAction);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CheckTriggerStatusResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "corptaxsandbox")]
        public IBodyWorkflowAction<ImportDataResponse, ApiConnectionActionConfiguration> ImportData(Expression<Func<string>> environmentName, Expression<Func<string>> enterpriseName, Expression<Func<ImportDataInput>> body)
        {
            var __workflow_environmentName = WorkflowExpression.Compile(environmentName, nameof(environmentName), required: true);
            var __workflow_enterpriseName = WorkflowExpression.Compile(enterpriseName, nameof(enterpriseName), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ImportDataResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/importData";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["environmentName"] = ExpressionConverter.Convert(__workflow_environmentName);
                callPayload.Headers["enterpriseName"] = ExpressionConverter.Convert(__workflow_enterpriseName);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ImportDataResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "corptaxsandbox")]
        public IWorkflowAction<ApiConnectionActionConfiguration> CorptaxEfileGroups(Expression<Func<string>> environmentName, Expression<Func<string>> enterpriseName, Expression<Func<string>> filingGroup = null)
        {
            var __workflow_environmentName = WorkflowExpression.Compile(environmentName, nameof(environmentName), required: true);
            var __workflow_enterpriseName = WorkflowExpression.Compile(enterpriseName, nameof(enterpriseName), required: true);
            var __workflow_filingGroup = WorkflowExpression.Compile(filingGroup, nameof(filingGroup), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/efileGroups";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["environmentName"] = ExpressionConverter.Convert(__workflow_environmentName);
                callPayload.Headers["enterpriseName"] = ExpressionConverter.Convert(__workflow_enterpriseName);
                if (__workflow_filingGroup != null)
                    callPayload.Headers["filingGroup"] = ExpressionConverter.Convert(__workflow_filingGroup);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "corptaxsandbox")]
        public IWorkflowAction<ApiConnectionActionConfiguration> CorptaxEfilePackage(Expression<Func<string>> environmentName, Expression<Func<string>> enterpriseName, Expression<Func<string>> filingGroup, Expression<Func<CorptaxEfilePackageInput>> body)
        {
            var __workflow_environmentName = WorkflowExpression.Compile(environmentName, nameof(environmentName), required: true);
            var __workflow_enterpriseName = WorkflowExpression.Compile(enterpriseName, nameof(enterpriseName), required: true);
            var __workflow_filingGroup = WorkflowExpression.Compile(filingGroup, nameof(filingGroup), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/efilePackage";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["environmentName"] = ExpressionConverter.Convert(__workflow_environmentName);
                callPayload.Headers["enterpriseName"] = ExpressionConverter.Convert(__workflow_enterpriseName);
                callPayload.Headers["filingGroup"] = ExpressionConverter.Convert(__workflow_filingGroup);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "corptaxsandbox")]
        public IBodyWorkflowAction<GetJobHistoryResponse, ApiConnectionActionConfiguration> GetJobHistory(Expression<Func<string>> environmentName, Expression<Func<GetJobHistoryInput>> body)
        {
            var __workflow_environmentName = WorkflowExpression.Compile(environmentName, nameof(environmentName), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<GetJobHistoryResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/JobHistoryReports";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["environmentName"] = ExpressionConverter.Convert(__workflow_environmentName);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<GetJobHistoryResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "corptaxsandbox")]
        public IWorkflowAction<ApiConnectionActionConfiguration> GetGmtDiagnostics(Expression<Func<string>> environmentName, Expression<Func<string>> enterpriseName, Expression<Func<GetGmtDiagnosticsInput>> body)
        {
            var __workflow_environmentName = WorkflowExpression.Compile(environmentName, nameof(environmentName), required: true);
            var __workflow_enterpriseName = WorkflowExpression.Compile(enterpriseName, nameof(enterpriseName), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/gmtDiagnosticsData";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["environmentName"] = ExpressionConverter.Convert(__workflow_environmentName);
                callPayload.Headers["enterpriseName"] = ExpressionConverter.Convert(__workflow_enterpriseName);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "corptaxsandbox")]
        public IWorkflowAction<ApiConnectionActionConfiguration> ReturnCalculationDetails(Expression<Func<string>> environmentName, Expression<Func<string>> enterpriseName, Expression<Func<ReturnCalculationDetailsInput>> body)
        {
            var __workflow_environmentName = WorkflowExpression.Compile(environmentName, nameof(environmentName), required: true);
            var __workflow_enterpriseName = WorkflowExpression.Compile(enterpriseName, nameof(enterpriseName), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/ReturnCalculationDetails";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["environmentName"] = ExpressionConverter.Convert(__workflow_environmentName);
                callPayload.Headers["enterpriseName"] = ExpressionConverter.Convert(__workflow_enterpriseName);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }
    }

    public class CorptaxsandboxTriggers([ConnectionName] string connectionId)
    {
    }

    public class CorptaxEntityViewsInput
    {
        [JsonProperty("qualifiedviewName")]
        public string QualifiedviewName { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum lookupTypeInput
    {
        Account,
        Entity,
        Case,
        Location,
        Jurisdiction
    }

    public class DataExchangeLookupInput
    {
        [JsonProperty("lookupName")]
        public string LookupName { get; set; }

        [JsonProperty("details", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool Details { get; set; }
    }

    public class EntityListInput
    {
        [JsonProperty("active")]
        public bool? Active { get; set; }

        [JsonProperty("periodName")]
        public string PeriodName { get; set; }

        [JsonProperty("viewName")]
        public string ViewName { get; set; }
    }

    public class ExportDataInput
    {
        [JsonProperty("namedContext")]
        public string NamedContext { get; set; }

        [JsonProperty("entityCode")]
        public string EntityCode { get; set; }

        [JsonProperty("caseCode")]
        public string CaseCode { get; set; }

        [JsonProperty("periodCode")]
        public string PeriodCode { get; set; }

        [JsonProperty("jurisdictionCode")]
        public string JurisdictionCode { get; set; }

        [JsonProperty("packageName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string PackageName { get; set; }

        [JsonProperty("internationalTaxName")]
        public string InternationalTaxName { get; set; }

        [JsonProperty("provisionName")]
        public string ProvisionName { get; set; }
    }

    public class ExportDataWithDataSourceInput
    {
        [JsonProperty("namedContext")]
        public string NamedContext { get; set; }

        [JsonProperty("entityCode")]
        public string EntityCode { get; set; }

        [JsonProperty("caseCode")]
        public string CaseCode { get; set; }

        [JsonProperty("periodCode")]
        public string PeriodCode { get; set; }

        [JsonProperty("jurisdictionCode")]
        public string JurisdictionCode { get; set; }

        [JsonProperty("dataSource", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DataSource { get; set; }

        [JsonProperty("internationalTaxName")]
        public string InternationalTaxName { get; set; }

        [JsonProperty("provisionName")]
        public string ProvisionName { get; set; }
    }

    public class TriggerCartResponse
    {
        public string OperationId { get; set; }
        public string Name { get; set; }
        public string Message { get; set; }
    }

    public class TriggerCartInput
    {
        [JsonProperty("cartName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string CartName { get; set; }

        [JsonProperty("typeOfAction", DefaultValueHandling = DefaultValueHandling.Include)]
        public TriggerCartInputTypeOfActionType TypeOfAction { get; set; }

        [JsonProperty("namedContext")]
        public string NamedContext { get; set; }

        [JsonProperty("entityCode")]
        public string EntityCode { get; set; }

        [JsonProperty("caseCode")]
        public string CaseCode { get; set; }

        [JsonProperty("periodCode")]
        public string PeriodCode { get; set; }

        [JsonProperty("jurisdictionCode")]
        public string JurisdictionCode { get; set; }

        [JsonProperty("ledgerName")]
        public string LedgerName { get; set; }

        [JsonProperty("isoCurrencyCode")]
        public string IsoCurrencyCode { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum TriggerCartInputTypeOfActionType
    {
        Post,
        Print,
        Run
    }

    public class TriggerReturnResponse
    {
        public string OperationId { get; set; }
        public string Name { get; set; }
        public string Message { get; set; }
    }

    public class TriggerReturnInput
    {
        [JsonProperty("returnName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ReturnName { get; set; }

        [JsonProperty("typeOfAction", DefaultValueHandling = DefaultValueHandling.Include)]
        public string TypeOfAction { get; set; }
    }

    public class DownloadContentsResponseItem
    {
        [JsonProperty("File Name")]
        public string FileName { get; set; }
        public string Status { get; set; }
        public string Processed { get; set; }
        public string Content { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum typeOfActionInput
    {
        Cart,
        Return
    }

    public class DownloadContentsInput
    {
        [JsonProperty("returnOrCartName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ReturnOrCartName { get; set; }
    }

    public class CheckTriggerStatusResponse
    {
        public string OperationId { get; set; }
        public string Status { get; set; }
    }

    public class CheckTriggerStatusInput
    {
        [JsonProperty("returnOrCartName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ReturnOrCartName { get; set; }
    }

    public class ImportDataResponse
    {
        public string JobToken { get; set; }
        public ImportDataResponseErrorsTypeItem[] Errors { get; set; }
    }

    public class ImportDataResponseErrorsTypeItem
    {
        public int Type { get; set; }
        public string Reference { get; set; }
        public string Message { get; set; }
    }

    public class ImportDataInput
    {
        [JsonProperty("entityCode")]
        public string EntityCode { get; set; }

        [JsonProperty("caseCode")]
        public string CaseCode { get; set; }

        [JsonProperty("periodCode")]
        public string PeriodCode { get; set; }

        [JsonProperty("jurisdictionCode")]
        public string JurisdictionCode { get; set; }

        [JsonProperty("packageName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string PackageName { get; set; }

        [JsonProperty("fileContents", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FileContents { get; set; }

        [JsonProperty("fileName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FileName { get; set; }

        [JsonProperty("importTransactionType", DefaultValueHandling = DefaultValueHandling.Include)]
        public ImportDataInputImportTransactionTypeType ImportTransactionType { get; set; }

        [JsonProperty("chartOfAccountsName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ChartOfAccountsName { get; set; } = "Corptax.ChartOfAccounts.System";

        [JsonProperty("recognizeFunctionalCurrency", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool RecognizeFunctionalCurrency { get; set; }

        [JsonProperty("stopOnLookupErrors", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool StopOnLookupErrors { get; set; }

        [JsonProperty("ledgerAmountType")]
        public ImportDataInputLedgerAmountTypeType? LedgerAmountType { get; set; }

        [JsonProperty("functionalCurrencyValue")]
        public string FunctionalCurrencyValue { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ImportDataInputImportTransactionTypeType
    {
        Transaction,
        [EnumMember(Value = "Balance Replace")]
        BalanceReplace,
        [EnumMember(Value = "Balance Reject Duplicates")]
        BalanceRejectDuplicates,
        [EnumMember(Value = "Balance Delete Existing All")]
        BalanceDeleteExistingAll,
        [EnumMember(Value = "Balance Delete Existing Book")]
        BalanceDeleteExistingBook,
        [EnumMember(Value = "Calc Update Back")]
        CalcUpdateBack,
        Replace,
        Merge,
        [EnumMember(Value = "Update Existing Only")]
        UpdateExistingOnly,
        [EnumMember(Value = "Insert New Only")]
        InsertNewOnly,
        [EnumMember(Value = "Balance Delete Existing Adjustment")]
        BalanceDeleteExistingAdjustment
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ImportDataInputLedgerAmountTypeType
    {
        None,
        Gross,
        [EnumMember(Value = "Tax Effected")]
        TaxEffected
    }

    public class CorptaxEfilePackageInput
    {
        [JsonProperty("entityCode")]
        public string EntityCode { get; set; }

        [JsonProperty("form")]
        public string Form { get; set; }

        [JsonProperty("efilePackageDetails", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool EfilePackageDetails { get; set; } = false;
    }

    public class GetJobHistoryResponse
    {
        public string JobToken { get; set; }
        public int ReportType { get; set; }
        public GetJobHistoryResponseContentType Content { get; set; }
        public GetJobHistoryResponseErrorsTypeItem[] Errors { get; set; }
    }

    public class GetJobHistoryResponseContentType
    {
        public int ContentType { get; set; }
        public string ContentBytes { get; set; }
        public bool HasContent { get; set; }
    }

    public class GetJobHistoryResponseErrorsTypeItem
    {
        public int Type { get; set; }
        public string Reference { get; set; }
        public string Message { get; set; }
    }

    public class GetJobHistoryInput
    {
        [JsonProperty("jobToken", DefaultValueHandling = DefaultValueHandling.Include)]
        public string JobToken { get; set; }

        [JsonProperty("report", DefaultValueHandling = DefaultValueHandling.Include)]
        public GetJobHistoryInputReportType? Report { get; set; } = GetJobHistoryInputReportType.Summary;

        [JsonProperty("reportFormat", DefaultValueHandling = DefaultValueHandling.Include)]
        public GetJobHistoryInputReportFormatType? ReportFormat { get; set; } = GetJobHistoryInputReportFormatType.Pdf;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GetJobHistoryInputReportType
    {
        Summary,
        Reject,
        Detail
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GetJobHistoryInputReportFormatType
    {
        Xml,
        Pdf
    }

    public class GetGmtDiagnosticsInput
    {
        [JsonProperty("gmtSetting", DefaultValueHandling = DefaultValueHandling.Include)]
        public string GmtSetting { get; set; }

        [JsonProperty("gmtDiagnosticName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string GmtDiagnosticName { get; set; }
    }

    public class ReturnCalculationDetailsInput
    {
        [JsonProperty("returnName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ReturnName { get; set; }

        [JsonProperty("format", DefaultValueHandling = DefaultValueHandling.Include)]
        public ReturnCalculationDetailsInputFormatType? Format { get; set; } = ReturnCalculationDetailsInputFormatType.JSON;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ReturnCalculationDetailsInputFormatType
    {
        JSON,
        CSV
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Corptaxsandbox;

    public partial class WorkflowManagedActions
    {
        public CorptaxsandboxActions Corptaxsandbox(string connectionId) => new CorptaxsandboxActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public CorptaxsandboxTriggers Corptaxsandbox(string connectionId) => new CorptaxsandboxTriggers(connectionId);
    }
}