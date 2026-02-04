//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Corptaxsandbox
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CorptaxsandboxActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "corptaxsandbox")]
        public IWorkflowAction CorptaxEntityViews(Expression<Func<string>> environmentName, Expression<Func<string>> enterpriseName, Expression<Func<string>> bodyqualifiedviewName = null)
        {
            var apiCallPath = "/entityView";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["environmentName"] = ExpressionConverter.Convert(environmentName);
            callPayload.Headers["enterpriseName"] = ExpressionConverter.Convert(enterpriseName);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyqualifiedviewName != null)
            {
                body["qualifiedviewName"] = ExpressionConverter.ConvertO(bodyqualifiedviewName);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "corptaxsandbox")]
        public IWorkflowAction DataExchangeLookup(Expression<Func<string>> environmentName, Expression<Func<string>> enterpriseName, Expression<Func<lookupTypeInput>> lookupType, Expression<Func<bool>> bodydetails, Expression<Func<string>> bodylookupName = null)
        {
            var apiCallPath = "/DataExchangeLookup";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["environmentName"] = ExpressionConverter.Convert(environmentName);
            callPayload.Headers["enterpriseName"] = ExpressionConverter.Convert(enterpriseName);
            callPayload.Headers["lookupType"] = ExpressionConverter.Convert(lookupType);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodylookupName != null)
            {
                body["lookupName"] = ExpressionConverter.ConvertO(bodylookupName);
                bodypropCount++;
            }

            bodypropCount++;
            body["details"] = ExpressionConverter.ConvertO(bodydetails);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "corptaxsandbox")]
        public IWorkflowAction EntityList(Expression<Func<string>> environmentName, Expression<Func<string>> enterpriseName, Expression<Func<bool>> bodyactive = null, Expression<Func<string>> bodyperiodName = null, Expression<Func<string>> bodyviewName = null)
        {
            var apiCallPath = "/EntityLists";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["environmentName"] = ExpressionConverter.Convert(environmentName);
            callPayload.Headers["enterpriseName"] = ExpressionConverter.Convert(enterpriseName);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyactive != null)
            {
                body["active"] = ExpressionConverter.ConvertO(bodyactive);
                bodypropCount++;
            }

            if (bodyperiodName != null)
            {
                body["periodName"] = ExpressionConverter.ConvertO(bodyperiodName);
                bodypropCount++;
            }

            if (bodyviewName != null)
            {
                body["viewName"] = ExpressionConverter.ConvertO(bodyviewName);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "corptaxsandbox")]
        public IWorkflowAction ExportData(Expression<Func<string>> environmentName, Expression<Func<string>> enterpriseName, Expression<Func<string>> bodypackageName, Expression<Func<string>> bodynamedContext = null, Expression<Func<string>> bodyentityCode = null, Expression<Func<string>> bodycaseCode = null, Expression<Func<string>> bodyperiodCode = null, Expression<Func<string>> bodyjurisdictionCode = null, Expression<Func<string>> bodyinternationalTaxName = null, Expression<Func<string>> bodyprovisionName = null)
        {
            var apiCallPath = "/dataExport";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["environmentName"] = ExpressionConverter.Convert(environmentName);
            callPayload.Headers["enterpriseName"] = ExpressionConverter.Convert(enterpriseName);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodynamedContext != null)
            {
                body["namedContext"] = ExpressionConverter.ConvertO(bodynamedContext);
                bodypropCount++;
            }

            if (bodyentityCode != null)
            {
                body["entityCode"] = ExpressionConverter.ConvertO(bodyentityCode);
                bodypropCount++;
            }

            if (bodycaseCode != null)
            {
                body["caseCode"] = ExpressionConverter.ConvertO(bodycaseCode);
                bodypropCount++;
            }

            if (bodyperiodCode != null)
            {
                body["periodCode"] = ExpressionConverter.ConvertO(bodyperiodCode);
                bodypropCount++;
            }

            if (bodyjurisdictionCode != null)
            {
                body["jurisdictionCode"] = ExpressionConverter.ConvertO(bodyjurisdictionCode);
                bodypropCount++;
            }

            bodypropCount++;
            body["packageName"] = ExpressionConverter.ConvertO(bodypackageName);
            if (bodyinternationalTaxName != null)
            {
                body["internationalTaxName"] = ExpressionConverter.ConvertO(bodyinternationalTaxName);
                bodypropCount++;
            }

            if (bodyprovisionName != null)
            {
                body["provisionName"] = ExpressionConverter.ConvertO(bodyprovisionName);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "corptaxsandbox")]
        public IWorkflowAction ExportDataWithDataSource(Expression<Func<string>> environmentName, Expression<Func<string>> enterpriseName, Expression<Func<string>> bodydataSource, Expression<Func<string>> bodynamedContext = null, Expression<Func<string>> bodyentityCode = null, Expression<Func<string>> bodycaseCode = null, Expression<Func<string>> bodyperiodCode = null, Expression<Func<string>> bodyjurisdictionCode = null, Expression<Func<string>> bodyinternationalTaxName = null, Expression<Func<string>> bodyprovisionName = null)
        {
            var apiCallPath = "/dataExportWithDataSource";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["environmentName"] = ExpressionConverter.Convert(environmentName);
            callPayload.Headers["enterpriseName"] = ExpressionConverter.Convert(enterpriseName);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodynamedContext != null)
            {
                body["namedContext"] = ExpressionConverter.ConvertO(bodynamedContext);
                bodypropCount++;
            }

            if (bodyentityCode != null)
            {
                body["entityCode"] = ExpressionConverter.ConvertO(bodyentityCode);
                bodypropCount++;
            }

            if (bodycaseCode != null)
            {
                body["caseCode"] = ExpressionConverter.ConvertO(bodycaseCode);
                bodypropCount++;
            }

            if (bodyperiodCode != null)
            {
                body["periodCode"] = ExpressionConverter.ConvertO(bodyperiodCode);
                bodypropCount++;
            }

            if (bodyjurisdictionCode != null)
            {
                body["jurisdictionCode"] = ExpressionConverter.ConvertO(bodyjurisdictionCode);
                bodypropCount++;
            }

            bodypropCount++;
            body["dataSource"] = ExpressionConverter.ConvertO(bodydataSource);
            if (bodyinternationalTaxName != null)
            {
                body["internationalTaxName"] = ExpressionConverter.ConvertO(bodyinternationalTaxName);
                bodypropCount++;
            }

            if (bodyprovisionName != null)
            {
                body["provisionName"] = ExpressionConverter.ConvertO(bodyprovisionName);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "corptaxsandbox")]
        public IBodyWorkflowAction<TriggerCartResponse> TriggerCart(Expression<Func<string>> environmentName, Expression<Func<string>> enterpriseName, Expression<Func<string>> bodycartName, Expression<Func<bodytypeOfActionInput>> bodytypeOfAction, Expression<Func<string>> bodynamedContext = null, Expression<Func<string>> bodyentityCode = null, Expression<Func<string>> bodycaseCode = null, Expression<Func<string>> bodyperiodCode = null, Expression<Func<string>> bodyjurisdictionCode = null, Expression<Func<string>> bodyledgerName = null, Expression<Func<string>> bodyisoCurrencyCode = null)
        {
            var apiCallPath = "/triggerCart";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["environmentName"] = ExpressionConverter.Convert(environmentName);
            callPayload.Headers["enterpriseName"] = ExpressionConverter.Convert(enterpriseName);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["cartName"] = ExpressionConverter.ConvertO(bodycartName);
            bodypropCount++;
            body["typeOfAction"] = ExpressionConverter.ConvertO(bodytypeOfAction);
            if (bodynamedContext != null)
            {
                body["namedContext"] = ExpressionConverter.ConvertO(bodynamedContext);
                bodypropCount++;
            }

            if (bodyentityCode != null)
            {
                body["entityCode"] = ExpressionConverter.ConvertO(bodyentityCode);
                bodypropCount++;
            }

            if (bodycaseCode != null)
            {
                body["caseCode"] = ExpressionConverter.ConvertO(bodycaseCode);
                bodypropCount++;
            }

            if (bodyperiodCode != null)
            {
                body["periodCode"] = ExpressionConverter.ConvertO(bodyperiodCode);
                bodypropCount++;
            }

            if (bodyjurisdictionCode != null)
            {
                body["jurisdictionCode"] = ExpressionConverter.ConvertO(bodyjurisdictionCode);
                bodypropCount++;
            }

            if (bodyledgerName != null)
            {
                body["ledgerName"] = ExpressionConverter.ConvertO(bodyledgerName);
                bodypropCount++;
            }

            if (bodyisoCurrencyCode != null)
            {
                body["isoCurrencyCode"] = ExpressionConverter.ConvertO(bodyisoCurrencyCode);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<TriggerCartResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "corptaxsandbox")]
        public IBodyWorkflowAction<TriggerReturnResponse> TriggerReturn(Expression<Func<string>> environmentName, Expression<Func<string>> enterpriseName, Expression<Func<string>> bodyreturnName, Expression<Func<string>> bodytypeOfAction)
        {
            var apiCallPath = "/triggerReturn";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["environmentName"] = ExpressionConverter.Convert(environmentName);
            callPayload.Headers["enterpriseName"] = ExpressionConverter.Convert(enterpriseName);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["returnName"] = ExpressionConverter.ConvertO(bodyreturnName);
            bodypropCount++;
            body["typeOfAction"] = ExpressionConverter.ConvertO(bodytypeOfAction);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<TriggerReturnResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "corptaxsandbox")]
        public IBodyWorkflowAction<DownloadContentsResponseItem[]> DownloadContents(Expression<Func<string>> environmentName, Expression<Func<string>> enterpriseName, Expression<Func<typeOfActionInput>> typeOfAction, Expression<Func<string>> bodyreturnOrCartName)
        {
            var apiCallPath = "/downloadContents";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["environmentName"] = ExpressionConverter.Convert(environmentName);
            callPayload.Headers["enterpriseName"] = ExpressionConverter.Convert(enterpriseName);
            callPayload.Headers["typeOfAction"] = ExpressionConverter.Convert(typeOfAction);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["returnOrCartName"] = ExpressionConverter.ConvertO(bodyreturnOrCartName);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<DownloadContentsResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "corptaxsandbox")]
        public IBodyWorkflowAction<CheckTriggerStatusResponse> CheckTriggerStatus(Expression<Func<string>> environmentName, Expression<Func<string>> enterpriseName, Expression<Func<typeOfActionInput>> typeOfAction, Expression<Func<string>> bodyreturnOrCartName)
        {
            var apiCallPath = "/checkTriggerStatus";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["environmentName"] = ExpressionConverter.Convert(environmentName);
            callPayload.Headers["enterpriseName"] = ExpressionConverter.Convert(enterpriseName);
            callPayload.Headers["typeOfAction"] = ExpressionConverter.Convert(typeOfAction);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["returnOrCartName"] = ExpressionConverter.ConvertO(bodyreturnOrCartName);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<CheckTriggerStatusResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "corptaxsandbox")]
        public IBodyWorkflowAction<ImportDataResponse> ImportData(Expression<Func<string>> environmentName, Expression<Func<string>> enterpriseName, Expression<Func<string>> bodypackageName, Expression<Func<string>> bodyfileContents, Expression<Func<string>> bodyfileName, Expression<Func<bodyimportTransactionTypeInput>> bodyimportTransactionType, Expression<Func<string>> bodychartOfAccountsName, Expression<Func<bool>> bodyrecognizeFunctionalCurrency, Expression<Func<bool>> bodystopOnLookupErrors, Expression<Func<string>> bodyentityCode = null, Expression<Func<string>> bodycaseCode = null, Expression<Func<string>> bodyperiodCode = null, Expression<Func<string>> bodyjurisdictionCode = null, Expression<Func<bodyledgerAmountTypeInput>> bodyledgerAmountType = null, Expression<Func<string>> bodyfunctionalCurrencyValue = null)
        {
            var apiCallPath = "/importData";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["environmentName"] = ExpressionConverter.Convert(environmentName);
            callPayload.Headers["enterpriseName"] = ExpressionConverter.Convert(enterpriseName);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyentityCode != null)
            {
                body["entityCode"] = ExpressionConverter.ConvertO(bodyentityCode);
                bodypropCount++;
            }

            if (bodycaseCode != null)
            {
                body["caseCode"] = ExpressionConverter.ConvertO(bodycaseCode);
                bodypropCount++;
            }

            if (bodyperiodCode != null)
            {
                body["periodCode"] = ExpressionConverter.ConvertO(bodyperiodCode);
                bodypropCount++;
            }

            if (bodyjurisdictionCode != null)
            {
                body["jurisdictionCode"] = ExpressionConverter.ConvertO(bodyjurisdictionCode);
                bodypropCount++;
            }

            bodypropCount++;
            body["packageName"] = ExpressionConverter.ConvertO(bodypackageName);
            bodypropCount++;
            body["fileContents"] = ExpressionConverter.ConvertO(bodyfileContents);
            bodypropCount++;
            body["fileName"] = ExpressionConverter.ConvertO(bodyfileName);
            bodypropCount++;
            body["importTransactionType"] = ExpressionConverter.ConvertO(bodyimportTransactionType);
            bodypropCount++;
            body["chartOfAccountsName"] = ExpressionConverter.ConvertO(bodychartOfAccountsName);
            bodypropCount++;
            body["recognizeFunctionalCurrency"] = ExpressionConverter.ConvertO(bodyrecognizeFunctionalCurrency);
            bodypropCount++;
            body["stopOnLookupErrors"] = ExpressionConverter.ConvertO(bodystopOnLookupErrors);
            if (bodyledgerAmountType != null)
            {
                body["ledgerAmountType"] = ExpressionConverter.ConvertO(bodyledgerAmountType);
                bodypropCount++;
            }

            if (bodyfunctionalCurrencyValue != null)
            {
                body["functionalCurrencyValue"] = ExpressionConverter.ConvertO(bodyfunctionalCurrencyValue);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ImportDataResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "corptaxsandbox")]
        public IWorkflowAction CorptaxEfileGroups(Expression<Func<string>> environmentName, Expression<Func<string>> enterpriseName, Expression<Func<string>> filingGroup = null)
        {
            var apiCallPath = "/efileGroups";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["environmentName"] = ExpressionConverter.Convert(environmentName);
            callPayload.Headers["enterpriseName"] = ExpressionConverter.Convert(enterpriseName);
            if (filingGroup != null)
                callPayload.Headers["filingGroup"] = ExpressionConverter.Convert(filingGroup);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "corptaxsandbox")]
        public IWorkflowAction CorptaxEfilePackage(Expression<Func<string>> environmentName, Expression<Func<string>> enterpriseName, Expression<Func<string>> filingGroup, Expression<Func<bool>> bodyefilePackageDetails, Expression<Func<string>> bodyentityCode = null, Expression<Func<string>> bodyform = null)
        {
            var apiCallPath = "/efilePackage";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["environmentName"] = ExpressionConverter.Convert(environmentName);
            callPayload.Headers["enterpriseName"] = ExpressionConverter.Convert(enterpriseName);
            callPayload.Headers["filingGroup"] = ExpressionConverter.Convert(filingGroup);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyentityCode != null)
            {
                body["entityCode"] = ExpressionConverter.ConvertO(bodyentityCode);
                bodypropCount++;
            }

            if (bodyform != null)
            {
                body["form"] = ExpressionConverter.ConvertO(bodyform);
                bodypropCount++;
            }

            bodypropCount++;
            body["efilePackageDetails"] = ExpressionConverter.ConvertO(bodyefilePackageDetails);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "corptaxsandbox")]
        public IBodyWorkflowAction<GetJobHistoryResponse> GetJobHistory(Expression<Func<string>> environmentName, Expression<Func<string>> bodyjobToken, Expression<Func<bodyreportInput>> bodyreport = null, Expression<Func<bodyreportFormatInput>> bodyreportFormat = null)
        {
            var apiCallPath = "/JobHistoryReports";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["environmentName"] = ExpressionConverter.Convert(environmentName);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["jobToken"] = ExpressionConverter.ConvertO(bodyjobToken);
            if (bodyreport != null)
            {
                body["report"] = ExpressionConverter.ConvertO(bodyreport);
                bodypropCount++;
            }

            if (bodyreportFormat != null)
            {
                body["reportFormat"] = ExpressionConverter.ConvertO(bodyreportFormat);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<GetJobHistoryResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "corptaxsandbox")]
        public IWorkflowAction GetGmtDiagnostics(Expression<Func<string>> environmentName, Expression<Func<string>> enterpriseName, Expression<Func<string>> bodygmtSetting, Expression<Func<string>> bodygmtDiagnosticName)
        {
            var apiCallPath = "/gmtDiagnosticsData";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["environmentName"] = ExpressionConverter.Convert(environmentName);
            callPayload.Headers["enterpriseName"] = ExpressionConverter.Convert(enterpriseName);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["gmtSetting"] = ExpressionConverter.ConvertO(bodygmtSetting);
            bodypropCount++;
            body["gmtDiagnosticName"] = ExpressionConverter.ConvertO(bodygmtDiagnosticName);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "corptaxsandbox")]
        public IWorkflowAction ReturnCalculationDetails(Expression<Func<string>> environmentName, Expression<Func<string>> enterpriseName, Expression<Func<string>> bodyreturnName)
        {
            var apiCallPath = "/ReturnCalculationDetails";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["environmentName"] = ExpressionConverter.Convert(environmentName);
            callPayload.Headers["enterpriseName"] = ExpressionConverter.Convert(enterpriseName);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["returnName"] = ExpressionConverter.ConvertO(bodyreturnName);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }
    }

    public class CorptaxsandboxTriggers([ConnectionName] string connectionId)
    {
    }

    public enum lookupTypeInput
    {
        Account,
        Entity,
        Case,
        Location,
        Jurisdiction
    }

    public class TriggerCartResponse
    {
        public string OperationId { get; set; }
        public string Name { get; set; }
        public string Message { get; set; }
    }

    public enum bodytypeOfActionInput
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

    public class DownloadContentsResponseItem
    {
        [JsonProperty("File Name")]
        public string FileName { get; set; }
        public string Status { get; set; }
        public string Processed { get; set; }
        public string Content { get; set; }
    }

    public enum typeOfActionInput
    {
        Cart,
        Return
    }

    public class CheckTriggerStatusResponse
    {
        public string OperationId { get; set; }
        public string Status { get; set; }
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

    public enum bodyimportTransactionTypeInput
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

    public enum bodyledgerAmountTypeInput
    {
        None,
        Gross,
        [EnumMember(Value = "Tax Effected")]
        TaxEffected
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

    public enum bodyreportInput
    {
        Summary,
        Reject,
        Detail
    }

    public enum bodyreportFormatInput
    {
        Xml,
        Pdf
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