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
            callPayload.Headers["environmentName"] = CSharpExpressionConverter.ConvertO(environmentName);
            callPayload.Headers["enterpriseName"] = CSharpExpressionConverter.ConvertO(enterpriseName);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyqualifiedviewName != null)
            {
                body["qualifiedviewName"] = CSharpExpressionConverter.ConvertToken(bodyqualifiedviewName);
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
            callPayload.Headers["environmentName"] = CSharpExpressionConverter.ConvertO(environmentName);
            callPayload.Headers["enterpriseName"] = CSharpExpressionConverter.ConvertO(enterpriseName);
            callPayload.Headers["lookupType"] = CSharpExpressionConverter.Convert(lookupType);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodylookupName != null)
            {
                body["lookupName"] = CSharpExpressionConverter.ConvertToken(bodylookupName);
                bodypropCount++;
            }

            bodypropCount++;
            body["details"] = CSharpExpressionConverter.ConvertToken(bodydetails);
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
            callPayload.Headers["environmentName"] = CSharpExpressionConverter.ConvertO(environmentName);
            callPayload.Headers["enterpriseName"] = CSharpExpressionConverter.ConvertO(enterpriseName);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyactive != null)
            {
                body["active"] = CSharpExpressionConverter.ConvertToken(bodyactive);
                bodypropCount++;
            }

            if (bodyperiodName != null)
            {
                body["periodName"] = CSharpExpressionConverter.ConvertToken(bodyperiodName);
                bodypropCount++;
            }

            if (bodyviewName != null)
            {
                body["viewName"] = CSharpExpressionConverter.ConvertToken(bodyviewName);
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
            callPayload.Headers["environmentName"] = CSharpExpressionConverter.ConvertO(environmentName);
            callPayload.Headers["enterpriseName"] = CSharpExpressionConverter.ConvertO(enterpriseName);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodynamedContext != null)
            {
                body["namedContext"] = CSharpExpressionConverter.ConvertToken(bodynamedContext);
                bodypropCount++;
            }

            if (bodyentityCode != null)
            {
                body["entityCode"] = CSharpExpressionConverter.ConvertToken(bodyentityCode);
                bodypropCount++;
            }

            if (bodycaseCode != null)
            {
                body["caseCode"] = CSharpExpressionConverter.ConvertToken(bodycaseCode);
                bodypropCount++;
            }

            if (bodyperiodCode != null)
            {
                body["periodCode"] = CSharpExpressionConverter.ConvertToken(bodyperiodCode);
                bodypropCount++;
            }

            if (bodyjurisdictionCode != null)
            {
                body["jurisdictionCode"] = CSharpExpressionConverter.ConvertToken(bodyjurisdictionCode);
                bodypropCount++;
            }

            bodypropCount++;
            body["packageName"] = CSharpExpressionConverter.ConvertToken(bodypackageName);
            if (bodyinternationalTaxName != null)
            {
                body["internationalTaxName"] = CSharpExpressionConverter.ConvertToken(bodyinternationalTaxName);
                bodypropCount++;
            }

            if (bodyprovisionName != null)
            {
                body["provisionName"] = CSharpExpressionConverter.ConvertToken(bodyprovisionName);
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
            callPayload.Headers["environmentName"] = CSharpExpressionConverter.ConvertO(environmentName);
            callPayload.Headers["enterpriseName"] = CSharpExpressionConverter.ConvertO(enterpriseName);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodynamedContext != null)
            {
                body["namedContext"] = CSharpExpressionConverter.ConvertToken(bodynamedContext);
                bodypropCount++;
            }

            if (bodyentityCode != null)
            {
                body["entityCode"] = CSharpExpressionConverter.ConvertToken(bodyentityCode);
                bodypropCount++;
            }

            if (bodycaseCode != null)
            {
                body["caseCode"] = CSharpExpressionConverter.ConvertToken(bodycaseCode);
                bodypropCount++;
            }

            if (bodyperiodCode != null)
            {
                body["periodCode"] = CSharpExpressionConverter.ConvertToken(bodyperiodCode);
                bodypropCount++;
            }

            if (bodyjurisdictionCode != null)
            {
                body["jurisdictionCode"] = CSharpExpressionConverter.ConvertToken(bodyjurisdictionCode);
                bodypropCount++;
            }

            bodypropCount++;
            body["dataSource"] = CSharpExpressionConverter.ConvertToken(bodydataSource);
            if (bodyinternationalTaxName != null)
            {
                body["internationalTaxName"] = CSharpExpressionConverter.ConvertToken(bodyinternationalTaxName);
                bodypropCount++;
            }

            if (bodyprovisionName != null)
            {
                body["provisionName"] = CSharpExpressionConverter.ConvertToken(bodyprovisionName);
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
            callPayload.Headers["environmentName"] = CSharpExpressionConverter.ConvertO(environmentName);
            callPayload.Headers["enterpriseName"] = CSharpExpressionConverter.ConvertO(enterpriseName);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["cartName"] = CSharpExpressionConverter.ConvertToken(bodycartName);
            bodypropCount++;
            body["typeOfAction"] = CSharpExpressionConverter.Convert(bodytypeOfAction);
            if (bodynamedContext != null)
            {
                body["namedContext"] = CSharpExpressionConverter.ConvertToken(bodynamedContext);
                bodypropCount++;
            }

            if (bodyentityCode != null)
            {
                body["entityCode"] = CSharpExpressionConverter.ConvertToken(bodyentityCode);
                bodypropCount++;
            }

            if (bodycaseCode != null)
            {
                body["caseCode"] = CSharpExpressionConverter.ConvertToken(bodycaseCode);
                bodypropCount++;
            }

            if (bodyperiodCode != null)
            {
                body["periodCode"] = CSharpExpressionConverter.ConvertToken(bodyperiodCode);
                bodypropCount++;
            }

            if (bodyjurisdictionCode != null)
            {
                body["jurisdictionCode"] = CSharpExpressionConverter.ConvertToken(bodyjurisdictionCode);
                bodypropCount++;
            }

            if (bodyledgerName != null)
            {
                body["ledgerName"] = CSharpExpressionConverter.ConvertToken(bodyledgerName);
                bodypropCount++;
            }

            if (bodyisoCurrencyCode != null)
            {
                body["isoCurrencyCode"] = CSharpExpressionConverter.ConvertToken(bodyisoCurrencyCode);
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
            callPayload.Headers["environmentName"] = CSharpExpressionConverter.ConvertO(environmentName);
            callPayload.Headers["enterpriseName"] = CSharpExpressionConverter.ConvertO(enterpriseName);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["returnName"] = CSharpExpressionConverter.ConvertToken(bodyreturnName);
            bodypropCount++;
            body["typeOfAction"] = CSharpExpressionConverter.ConvertToken(bodytypeOfAction);
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
            callPayload.Headers["environmentName"] = CSharpExpressionConverter.ConvertO(environmentName);
            callPayload.Headers["enterpriseName"] = CSharpExpressionConverter.ConvertO(enterpriseName);
            callPayload.Headers["typeOfAction"] = CSharpExpressionConverter.Convert(typeOfAction);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["returnOrCartName"] = CSharpExpressionConverter.ConvertToken(bodyreturnOrCartName);
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
            callPayload.Headers["environmentName"] = CSharpExpressionConverter.ConvertO(environmentName);
            callPayload.Headers["enterpriseName"] = CSharpExpressionConverter.ConvertO(enterpriseName);
            callPayload.Headers["typeOfAction"] = CSharpExpressionConverter.Convert(typeOfAction);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["returnOrCartName"] = CSharpExpressionConverter.ConvertToken(bodyreturnOrCartName);
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
            callPayload.Headers["environmentName"] = CSharpExpressionConverter.ConvertO(environmentName);
            callPayload.Headers["enterpriseName"] = CSharpExpressionConverter.ConvertO(enterpriseName);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyentityCode != null)
            {
                body["entityCode"] = CSharpExpressionConverter.ConvertToken(bodyentityCode);
                bodypropCount++;
            }

            if (bodycaseCode != null)
            {
                body["caseCode"] = CSharpExpressionConverter.ConvertToken(bodycaseCode);
                bodypropCount++;
            }

            if (bodyperiodCode != null)
            {
                body["periodCode"] = CSharpExpressionConverter.ConvertToken(bodyperiodCode);
                bodypropCount++;
            }

            if (bodyjurisdictionCode != null)
            {
                body["jurisdictionCode"] = CSharpExpressionConverter.ConvertToken(bodyjurisdictionCode);
                bodypropCount++;
            }

            bodypropCount++;
            body["packageName"] = CSharpExpressionConverter.ConvertToken(bodypackageName);
            bodypropCount++;
            body["fileContents"] = CSharpExpressionConverter.ConvertToken(bodyfileContents);
            bodypropCount++;
            body["fileName"] = CSharpExpressionConverter.ConvertToken(bodyfileName);
            bodypropCount++;
            body["importTransactionType"] = CSharpExpressionConverter.Convert(bodyimportTransactionType);
            bodypropCount++;
            body["chartOfAccountsName"] = CSharpExpressionConverter.ConvertToken(bodychartOfAccountsName);
            bodypropCount++;
            body["recognizeFunctionalCurrency"] = CSharpExpressionConverter.ConvertToken(bodyrecognizeFunctionalCurrency);
            bodypropCount++;
            body["stopOnLookupErrors"] = CSharpExpressionConverter.ConvertToken(bodystopOnLookupErrors);
            if (bodyledgerAmountType != null)
            {
                body["ledgerAmountType"] = CSharpExpressionConverter.Convert(bodyledgerAmountType);
                bodypropCount++;
            }

            if (bodyfunctionalCurrencyValue != null)
            {
                body["functionalCurrencyValue"] = CSharpExpressionConverter.ConvertToken(bodyfunctionalCurrencyValue);
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
            callPayload.Headers["environmentName"] = CSharpExpressionConverter.ConvertO(environmentName);
            callPayload.Headers["enterpriseName"] = CSharpExpressionConverter.ConvertO(enterpriseName);
            if (filingGroup != null)
                callPayload.Headers["filingGroup"] = CSharpExpressionConverter.ConvertO(filingGroup);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "corptaxsandbox")]
        public IWorkflowAction CorptaxEfilePackage(Expression<Func<string>> environmentName, Expression<Func<string>> enterpriseName, Expression<Func<string>> filingGroup, Expression<Func<bool>> bodyefilePackageDetails, Expression<Func<string>> bodyentityCode = null, Expression<Func<string>> bodyform = null)
        {
            var apiCallPath = "/efilePackage";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["environmentName"] = CSharpExpressionConverter.ConvertO(environmentName);
            callPayload.Headers["enterpriseName"] = CSharpExpressionConverter.ConvertO(enterpriseName);
            callPayload.Headers["filingGroup"] = CSharpExpressionConverter.ConvertO(filingGroup);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyentityCode != null)
            {
                body["entityCode"] = CSharpExpressionConverter.ConvertToken(bodyentityCode);
                bodypropCount++;
            }

            if (bodyform != null)
            {
                body["form"] = CSharpExpressionConverter.ConvertToken(bodyform);
                bodypropCount++;
            }

            bodypropCount++;
            body["efilePackageDetails"] = CSharpExpressionConverter.ConvertToken(bodyefilePackageDetails);
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
            callPayload.Headers["environmentName"] = CSharpExpressionConverter.ConvertO(environmentName);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["jobToken"] = CSharpExpressionConverter.ConvertToken(bodyjobToken);
            if (bodyreport != null)
            {
                if (bodyreport != null)
                {
                    body["report"] = CSharpExpressionConverter.Convert(bodyreport);
                    bodypropCount++;
                }

                bodypropCount++;
            }
            else
            {
                body["report"] = "Summary";
                bodypropCount++;
            }

            if (bodyreportFormat != null)
            {
                if (bodyreportFormat != null)
                {
                    body["reportFormat"] = CSharpExpressionConverter.Convert(bodyreportFormat);
                    bodypropCount++;
                }

                bodypropCount++;
            }
            else
            {
                body["reportFormat"] = "Pdf";
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
            callPayload.Headers["environmentName"] = CSharpExpressionConverter.ConvertO(environmentName);
            callPayload.Headers["enterpriseName"] = CSharpExpressionConverter.ConvertO(enterpriseName);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["gmtSetting"] = CSharpExpressionConverter.ConvertToken(bodygmtSetting);
            bodypropCount++;
            body["gmtDiagnosticName"] = CSharpExpressionConverter.ConvertToken(bodygmtDiagnosticName);
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
            callPayload.Headers["environmentName"] = CSharpExpressionConverter.ConvertO(environmentName);
            callPayload.Headers["enterpriseName"] = CSharpExpressionConverter.ConvertO(enterpriseName);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["returnName"] = CSharpExpressionConverter.ConvertToken(bodyreturnName);
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