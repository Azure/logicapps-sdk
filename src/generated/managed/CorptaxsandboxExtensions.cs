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
        public IWorkflowAction CorptaxEntityViews([WorkflowExpression] Func<string> environmentName, [WorkflowExpression] Func<string> enterpriseName, [WorkflowExpression] Func<string> bodyqualifiedviewName = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/entityView";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["environmentName"] = SourceExpressionConverter.ConvertO(environmentName);
                callPayload.Headers["enterpriseName"] = SourceExpressionConverter.ConvertO(enterpriseName);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyqualifiedviewName != null)
                {
                    body["qualifiedviewName"] = SourceExpressionConverter.ConvertToken(bodyqualifiedviewName);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "corptaxsandbox")]
        public IWorkflowAction DataExchangeLookup([WorkflowExpression] Func<string> environmentName, [WorkflowExpression] Func<string> enterpriseName, [WorkflowExpression] Func<lookupTypeInput> lookupType, [WorkflowExpression] Func<bool> bodydetails, [WorkflowExpression] Func<string> bodylookupName = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/DataExchangeLookup";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["environmentName"] = SourceExpressionConverter.ConvertO(environmentName);
                callPayload.Headers["enterpriseName"] = SourceExpressionConverter.ConvertO(enterpriseName);
                callPayload.Headers["lookupType"] = SourceExpressionConverter.Convert(lookupType);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodylookupName != null)
                {
                    body["lookupName"] = SourceExpressionConverter.ConvertToken(bodylookupName);
                    bodypropCount++;
                }

                bodypropCount++;
                body["details"] = SourceExpressionConverter.ConvertToken(bodydetails);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "corptaxsandbox")]
        public IWorkflowAction EntityList([WorkflowExpression] Func<string> environmentName, [WorkflowExpression] Func<string> enterpriseName, [WorkflowExpression] Func<bool> bodyactive = null, [WorkflowExpression] Func<string> bodyperiodName = null, [WorkflowExpression] Func<string> bodyviewName = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/EntityLists";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["environmentName"] = SourceExpressionConverter.ConvertO(environmentName);
                callPayload.Headers["enterpriseName"] = SourceExpressionConverter.ConvertO(enterpriseName);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyactive != null)
                {
                    body["active"] = SourceExpressionConverter.ConvertToken(bodyactive);
                    bodypropCount++;
                }

                if (bodyperiodName != null)
                {
                    body["periodName"] = SourceExpressionConverter.ConvertToken(bodyperiodName);
                    bodypropCount++;
                }

                if (bodyviewName != null)
                {
                    body["viewName"] = SourceExpressionConverter.ConvertToken(bodyviewName);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "corptaxsandbox")]
        public IWorkflowAction ExportData([WorkflowExpression] Func<string> environmentName, [WorkflowExpression] Func<string> enterpriseName, [WorkflowExpression] Func<string> bodypackageName, [WorkflowExpression] Func<string> bodynamedContext = null, [WorkflowExpression] Func<string> bodyentityCode = null, [WorkflowExpression] Func<string> bodycaseCode = null, [WorkflowExpression] Func<string> bodyperiodCode = null, [WorkflowExpression] Func<string> bodyjurisdictionCode = null, [WorkflowExpression] Func<string> bodyinternationalTaxName = null, [WorkflowExpression] Func<string> bodyprovisionName = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/dataExport";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["environmentName"] = SourceExpressionConverter.ConvertO(environmentName);
                callPayload.Headers["enterpriseName"] = SourceExpressionConverter.ConvertO(enterpriseName);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodynamedContext != null)
                {
                    body["namedContext"] = SourceExpressionConverter.ConvertToken(bodynamedContext);
                    bodypropCount++;
                }

                if (bodyentityCode != null)
                {
                    body["entityCode"] = SourceExpressionConverter.ConvertToken(bodyentityCode);
                    bodypropCount++;
                }

                if (bodycaseCode != null)
                {
                    body["caseCode"] = SourceExpressionConverter.ConvertToken(bodycaseCode);
                    bodypropCount++;
                }

                if (bodyperiodCode != null)
                {
                    body["periodCode"] = SourceExpressionConverter.ConvertToken(bodyperiodCode);
                    bodypropCount++;
                }

                if (bodyjurisdictionCode != null)
                {
                    body["jurisdictionCode"] = SourceExpressionConverter.ConvertToken(bodyjurisdictionCode);
                    bodypropCount++;
                }

                bodypropCount++;
                body["packageName"] = SourceExpressionConverter.ConvertToken(bodypackageName);
                if (bodyinternationalTaxName != null)
                {
                    body["internationalTaxName"] = SourceExpressionConverter.ConvertToken(bodyinternationalTaxName);
                    bodypropCount++;
                }

                if (bodyprovisionName != null)
                {
                    body["provisionName"] = SourceExpressionConverter.ConvertToken(bodyprovisionName);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "corptaxsandbox")]
        public IWorkflowAction ExportDataWithDataSource([WorkflowExpression] Func<string> environmentName, [WorkflowExpression] Func<string> enterpriseName, [WorkflowExpression] Func<string> bodydataSource, [WorkflowExpression] Func<string> bodynamedContext = null, [WorkflowExpression] Func<string> bodyentityCode = null, [WorkflowExpression] Func<string> bodycaseCode = null, [WorkflowExpression] Func<string> bodyperiodCode = null, [WorkflowExpression] Func<string> bodyjurisdictionCode = null, [WorkflowExpression] Func<string> bodyinternationalTaxName = null, [WorkflowExpression] Func<string> bodyprovisionName = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/dataExportWithDataSource";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["environmentName"] = SourceExpressionConverter.ConvertO(environmentName);
                callPayload.Headers["enterpriseName"] = SourceExpressionConverter.ConvertO(enterpriseName);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodynamedContext != null)
                {
                    body["namedContext"] = SourceExpressionConverter.ConvertToken(bodynamedContext);
                    bodypropCount++;
                }

                if (bodyentityCode != null)
                {
                    body["entityCode"] = SourceExpressionConverter.ConvertToken(bodyentityCode);
                    bodypropCount++;
                }

                if (bodycaseCode != null)
                {
                    body["caseCode"] = SourceExpressionConverter.ConvertToken(bodycaseCode);
                    bodypropCount++;
                }

                if (bodyperiodCode != null)
                {
                    body["periodCode"] = SourceExpressionConverter.ConvertToken(bodyperiodCode);
                    bodypropCount++;
                }

                if (bodyjurisdictionCode != null)
                {
                    body["jurisdictionCode"] = SourceExpressionConverter.ConvertToken(bodyjurisdictionCode);
                    bodypropCount++;
                }

                bodypropCount++;
                body["dataSource"] = SourceExpressionConverter.ConvertToken(bodydataSource);
                if (bodyinternationalTaxName != null)
                {
                    body["internationalTaxName"] = SourceExpressionConverter.ConvertToken(bodyinternationalTaxName);
                    bodypropCount++;
                }

                if (bodyprovisionName != null)
                {
                    body["provisionName"] = SourceExpressionConverter.ConvertToken(bodyprovisionName);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "corptaxsandbox")]
        public IBodyWorkflowAction<TriggerCartResponse> TriggerCart([WorkflowExpression] Func<string> environmentName, [WorkflowExpression] Func<string> enterpriseName, [WorkflowExpression] Func<string> bodycartName, [WorkflowExpression] Func<bodytypeOfActionInput> bodytypeOfAction, [WorkflowExpression] Func<string> bodynamedContext = null, [WorkflowExpression] Func<string> bodyentityCode = null, [WorkflowExpression] Func<string> bodycaseCode = null, [WorkflowExpression] Func<string> bodyperiodCode = null, [WorkflowExpression] Func<string> bodyjurisdictionCode = null, [WorkflowExpression] Func<string> bodyledgerName = null, [WorkflowExpression] Func<string> bodyisoCurrencyCode = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/triggerCart";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["environmentName"] = SourceExpressionConverter.ConvertO(environmentName);
                callPayload.Headers["enterpriseName"] = SourceExpressionConverter.ConvertO(enterpriseName);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["cartName"] = SourceExpressionConverter.ConvertToken(bodycartName);
                bodypropCount++;
                body["typeOfAction"] = SourceExpressionConverter.Convert(bodytypeOfAction);
                if (bodynamedContext != null)
                {
                    body["namedContext"] = SourceExpressionConverter.ConvertToken(bodynamedContext);
                    bodypropCount++;
                }

                if (bodyentityCode != null)
                {
                    body["entityCode"] = SourceExpressionConverter.ConvertToken(bodyentityCode);
                    bodypropCount++;
                }

                if (bodycaseCode != null)
                {
                    body["caseCode"] = SourceExpressionConverter.ConvertToken(bodycaseCode);
                    bodypropCount++;
                }

                if (bodyperiodCode != null)
                {
                    body["periodCode"] = SourceExpressionConverter.ConvertToken(bodyperiodCode);
                    bodypropCount++;
                }

                if (bodyjurisdictionCode != null)
                {
                    body["jurisdictionCode"] = SourceExpressionConverter.ConvertToken(bodyjurisdictionCode);
                    bodypropCount++;
                }

                if (bodyledgerName != null)
                {
                    body["ledgerName"] = SourceExpressionConverter.ConvertToken(bodyledgerName);
                    bodypropCount++;
                }

                if (bodyisoCurrencyCode != null)
                {
                    body["isoCurrencyCode"] = SourceExpressionConverter.ConvertToken(bodyisoCurrencyCode);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<TriggerCartResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "corptaxsandbox")]
        public IBodyWorkflowAction<TriggerReturnResponse> TriggerReturn([WorkflowExpression] Func<string> environmentName, [WorkflowExpression] Func<string> enterpriseName, [WorkflowExpression] Func<string> bodyreturnName, [WorkflowExpression] Func<string> bodytypeOfAction)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/triggerReturn";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["environmentName"] = SourceExpressionConverter.ConvertO(environmentName);
                callPayload.Headers["enterpriseName"] = SourceExpressionConverter.ConvertO(enterpriseName);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["returnName"] = SourceExpressionConverter.ConvertToken(bodyreturnName);
                bodypropCount++;
                body["typeOfAction"] = SourceExpressionConverter.ConvertToken(bodytypeOfAction);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<TriggerReturnResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "corptaxsandbox")]
        public IBodyWorkflowAction<DownloadContentsResponseItem[]> DownloadContents([WorkflowExpression] Func<string> environmentName, [WorkflowExpression] Func<string> enterpriseName, [WorkflowExpression] Func<typeOfActionInput> typeOfAction, [WorkflowExpression] Func<string> bodyreturnOrCartName)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/downloadContents";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["environmentName"] = SourceExpressionConverter.ConvertO(environmentName);
                callPayload.Headers["enterpriseName"] = SourceExpressionConverter.ConvertO(enterpriseName);
                callPayload.Headers["typeOfAction"] = SourceExpressionConverter.Convert(typeOfAction);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["returnOrCartName"] = SourceExpressionConverter.ConvertToken(bodyreturnOrCartName);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DownloadContentsResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "corptaxsandbox")]
        public IBodyWorkflowAction<CheckTriggerStatusResponse> CheckTriggerStatus([WorkflowExpression] Func<string> environmentName, [WorkflowExpression] Func<string> enterpriseName, [WorkflowExpression] Func<typeOfActionInput> typeOfAction, [WorkflowExpression] Func<string> bodyreturnOrCartName)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/checkTriggerStatus";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["environmentName"] = SourceExpressionConverter.ConvertO(environmentName);
                callPayload.Headers["enterpriseName"] = SourceExpressionConverter.ConvertO(enterpriseName);
                callPayload.Headers["typeOfAction"] = SourceExpressionConverter.Convert(typeOfAction);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["returnOrCartName"] = SourceExpressionConverter.ConvertToken(bodyreturnOrCartName);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CheckTriggerStatusResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "corptaxsandbox")]
        public IBodyWorkflowAction<ImportDataResponse> ImportData([WorkflowExpression] Func<string> environmentName, [WorkflowExpression] Func<string> enterpriseName, [WorkflowExpression] Func<string> bodypackageName, [WorkflowExpression] Func<string> bodyfileContents, [WorkflowExpression] Func<string> bodyfileName, [WorkflowExpression] Func<bodyimportTransactionTypeInput> bodyimportTransactionType, [WorkflowExpression] Func<string> bodychartOfAccountsName, [WorkflowExpression] Func<bool> bodyrecognizeFunctionalCurrency, [WorkflowExpression] Func<bool> bodystopOnLookupErrors, [WorkflowExpression] Func<string> bodyentityCode = null, [WorkflowExpression] Func<string> bodycaseCode = null, [WorkflowExpression] Func<string> bodyperiodCode = null, [WorkflowExpression] Func<string> bodyjurisdictionCode = null, [WorkflowExpression] Func<bodyledgerAmountTypeInput> bodyledgerAmountType = null, [WorkflowExpression] Func<string> bodyfunctionalCurrencyValue = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/importData";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["environmentName"] = SourceExpressionConverter.ConvertO(environmentName);
                callPayload.Headers["enterpriseName"] = SourceExpressionConverter.ConvertO(enterpriseName);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyentityCode != null)
                {
                    body["entityCode"] = SourceExpressionConverter.ConvertToken(bodyentityCode);
                    bodypropCount++;
                }

                if (bodycaseCode != null)
                {
                    body["caseCode"] = SourceExpressionConverter.ConvertToken(bodycaseCode);
                    bodypropCount++;
                }

                if (bodyperiodCode != null)
                {
                    body["periodCode"] = SourceExpressionConverter.ConvertToken(bodyperiodCode);
                    bodypropCount++;
                }

                if (bodyjurisdictionCode != null)
                {
                    body["jurisdictionCode"] = SourceExpressionConverter.ConvertToken(bodyjurisdictionCode);
                    bodypropCount++;
                }

                bodypropCount++;
                body["packageName"] = SourceExpressionConverter.ConvertToken(bodypackageName);
                bodypropCount++;
                body["fileContents"] = SourceExpressionConverter.ConvertToken(bodyfileContents);
                bodypropCount++;
                body["fileName"] = SourceExpressionConverter.ConvertToken(bodyfileName);
                bodypropCount++;
                body["importTransactionType"] = SourceExpressionConverter.Convert(bodyimportTransactionType);
                bodypropCount++;
                body["chartOfAccountsName"] = SourceExpressionConverter.ConvertToken(bodychartOfAccountsName);
                bodypropCount++;
                body["recognizeFunctionalCurrency"] = SourceExpressionConverter.ConvertToken(bodyrecognizeFunctionalCurrency);
                bodypropCount++;
                body["stopOnLookupErrors"] = SourceExpressionConverter.ConvertToken(bodystopOnLookupErrors);
                if (bodyledgerAmountType != null)
                {
                    body["ledgerAmountType"] = SourceExpressionConverter.Convert(bodyledgerAmountType);
                    bodypropCount++;
                }

                if (bodyfunctionalCurrencyValue != null)
                {
                    body["functionalCurrencyValue"] = SourceExpressionConverter.ConvertToken(bodyfunctionalCurrencyValue);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ImportDataResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "corptaxsandbox")]
        public IWorkflowAction CorptaxEfileGroups([WorkflowExpression] Func<string> environmentName, [WorkflowExpression] Func<string> enterpriseName, [WorkflowExpression] Func<string> filingGroup = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/efileGroups";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["environmentName"] = SourceExpressionConverter.ConvertO(environmentName);
                callPayload.Headers["enterpriseName"] = SourceExpressionConverter.ConvertO(enterpriseName);
                if (filingGroup != null)
                    callPayload.Headers["filingGroup"] = SourceExpressionConverter.ConvertO(filingGroup);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "corptaxsandbox")]
        public IWorkflowAction CorptaxEfilePackage([WorkflowExpression] Func<string> environmentName, [WorkflowExpression] Func<string> enterpriseName, [WorkflowExpression] Func<string> filingGroup, [WorkflowExpression] Func<bool> bodyefilePackageDetails, [WorkflowExpression] Func<string> bodyentityCode = null, [WorkflowExpression] Func<string> bodyform = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/efilePackage";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["environmentName"] = SourceExpressionConverter.ConvertO(environmentName);
                callPayload.Headers["enterpriseName"] = SourceExpressionConverter.ConvertO(enterpriseName);
                callPayload.Headers["filingGroup"] = SourceExpressionConverter.ConvertO(filingGroup);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyentityCode != null)
                {
                    body["entityCode"] = SourceExpressionConverter.ConvertToken(bodyentityCode);
                    bodypropCount++;
                }

                if (bodyform != null)
                {
                    body["form"] = SourceExpressionConverter.ConvertToken(bodyform);
                    bodypropCount++;
                }

                bodypropCount++;
                body["efilePackageDetails"] = SourceExpressionConverter.ConvertToken(bodyefilePackageDetails);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "corptaxsandbox")]
        public IBodyWorkflowAction<GetJobHistoryResponse> GetJobHistory([WorkflowExpression] Func<string> environmentName, [WorkflowExpression] Func<string> bodyjobToken, [WorkflowExpression] Func<bodyreportInput> bodyreport = null, [WorkflowExpression] Func<bodyreportFormatInput> bodyreportFormat = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/JobHistoryReports";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["environmentName"] = SourceExpressionConverter.ConvertO(environmentName);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["jobToken"] = SourceExpressionConverter.ConvertToken(bodyjobToken);
                if (bodyreport != null)
                {
                    if (bodyreport != null)
                    {
                        body["report"] = SourceExpressionConverter.Convert(bodyreport);
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
                        body["reportFormat"] = SourceExpressionConverter.Convert(bodyreportFormat);
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
                return callPayload;
            }

            return new ApiConnectionAction<GetJobHistoryResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "corptaxsandbox")]
        public IWorkflowAction GetGmtDiagnostics([WorkflowExpression] Func<string> environmentName, [WorkflowExpression] Func<string> enterpriseName, [WorkflowExpression] Func<string> bodygmtSetting, [WorkflowExpression] Func<string> bodygmtDiagnosticName)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/gmtDiagnosticsData";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["environmentName"] = SourceExpressionConverter.ConvertO(environmentName);
                callPayload.Headers["enterpriseName"] = SourceExpressionConverter.ConvertO(enterpriseName);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["gmtSetting"] = SourceExpressionConverter.ConvertToken(bodygmtSetting);
                bodypropCount++;
                body["gmtDiagnosticName"] = SourceExpressionConverter.ConvertToken(bodygmtDiagnosticName);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "corptaxsandbox")]
        public IWorkflowAction ReturnCalculationDetails([WorkflowExpression] Func<string> environmentName, [WorkflowExpression] Func<string> enterpriseName, [WorkflowExpression] Func<string> bodyreturnName, [WorkflowExpression] Func<bodyformatInput> bodyformat = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/ReturnCalculationDetails";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["environmentName"] = SourceExpressionConverter.ConvertO(environmentName);
                callPayload.Headers["enterpriseName"] = SourceExpressionConverter.ConvertO(enterpriseName);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["returnName"] = SourceExpressionConverter.ConvertToken(bodyreturnName);
                if (bodyformat != null)
                {
                    if (bodyformat != null)
                    {
                        body["format"] = SourceExpressionConverter.Convert(bodyformat);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["format"] = "JSON";
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
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

    public enum bodyformatInput
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