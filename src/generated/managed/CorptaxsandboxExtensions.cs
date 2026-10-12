//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Corptaxsandbox
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CorptaxsandboxActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "corptaxsandbox")]
        [WorkflowExpressionFactory(nameof(__BuildCorptaxEntityViews))]
        public IWorkflowAction CorptaxEntityViews([WorkflowExpression] Func<string> environmentName, [WorkflowExpression] Func<string> enterpriseName, [WorkflowExpression] Func<string> bodyqualifiedviewName = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildCorptaxEntityViews(WorkflowExpression<string> environmentName, WorkflowExpression<string> enterpriseName, WorkflowExpression<string> bodyqualifiedviewName = null)
        {
            WorkflowExpression.Validate(environmentName, nameof(environmentName), required: true);
            WorkflowExpression.Validate(enterpriseName, nameof(enterpriseName), required: true);
            WorkflowExpression.Validate(bodyqualifiedviewName, nameof(bodyqualifiedviewName), required: false);
            return new DeferredWorkflowAction(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "corptaxsandbox")]
        [WorkflowExpressionFactory(nameof(__BuildDataExchangeLookup))]
        public IWorkflowAction DataExchangeLookup([WorkflowExpression] Func<string> environmentName, [WorkflowExpression] Func<string> enterpriseName, [WorkflowExpression] Func<lookupTypeInput> lookupType, [WorkflowExpression] Func<bool> bodydetails, [WorkflowExpression] Func<string> bodylookupName = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDataExchangeLookup(WorkflowExpression<string> environmentName, WorkflowExpression<string> enterpriseName, WorkflowExpression<lookupTypeInput> lookupType, WorkflowExpression<bool> bodydetails, WorkflowExpression<string> bodylookupName = null)
        {
            WorkflowExpression.Validate(environmentName, nameof(environmentName), required: true);
            WorkflowExpression.Validate(enterpriseName, nameof(enterpriseName), required: true);
            WorkflowExpression.Validate(lookupType, nameof(lookupType), required: true);
            WorkflowExpression.Validate(bodydetails, nameof(bodydetails), required: true);
            WorkflowExpression.Validate(bodylookupName, nameof(bodylookupName), required: false);
            return new DeferredWorkflowAction(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "corptaxsandbox")]
        [WorkflowExpressionFactory(nameof(__BuildEntityList))]
        public IWorkflowAction EntityList([WorkflowExpression] Func<string> environmentName, [WorkflowExpression] Func<string> enterpriseName, [WorkflowExpression] Func<bool> bodyactive = null, [WorkflowExpression] Func<string> bodyperiodName = null, [WorkflowExpression] Func<string> bodyviewName = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildEntityList(WorkflowExpression<string> environmentName, WorkflowExpression<string> enterpriseName, WorkflowExpression<bool> bodyactive = null, WorkflowExpression<string> bodyperiodName = null, WorkflowExpression<string> bodyviewName = null)
        {
            WorkflowExpression.Validate(environmentName, nameof(environmentName), required: true);
            WorkflowExpression.Validate(enterpriseName, nameof(enterpriseName), required: true);
            WorkflowExpression.Validate(bodyactive, nameof(bodyactive), required: false);
            WorkflowExpression.Validate(bodyperiodName, nameof(bodyperiodName), required: false);
            WorkflowExpression.Validate(bodyviewName, nameof(bodyviewName), required: false);
            return new DeferredWorkflowAction(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "corptaxsandbox")]
        [WorkflowExpressionFactory(nameof(__BuildExportData))]
        public IWorkflowAction ExportData([WorkflowExpression] Func<string> environmentName, [WorkflowExpression] Func<string> enterpriseName, [WorkflowExpression] Func<string> bodypackageName, [WorkflowExpression] Func<string> bodynamedContext = null, [WorkflowExpression] Func<string> bodyentityCode = null, [WorkflowExpression] Func<string> bodycaseCode = null, [WorkflowExpression] Func<string> bodyperiodCode = null, [WorkflowExpression] Func<string> bodyjurisdictionCode = null, [WorkflowExpression] Func<string> bodyinternationalTaxName = null, [WorkflowExpression] Func<string> bodyprovisionName = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildExportData(WorkflowExpression<string> environmentName, WorkflowExpression<string> enterpriseName, WorkflowExpression<string> bodypackageName, WorkflowExpression<string> bodynamedContext = null, WorkflowExpression<string> bodyentityCode = null, WorkflowExpression<string> bodycaseCode = null, WorkflowExpression<string> bodyperiodCode = null, WorkflowExpression<string> bodyjurisdictionCode = null, WorkflowExpression<string> bodyinternationalTaxName = null, WorkflowExpression<string> bodyprovisionName = null)
        {
            WorkflowExpression.Validate(environmentName, nameof(environmentName), required: true);
            WorkflowExpression.Validate(enterpriseName, nameof(enterpriseName), required: true);
            WorkflowExpression.Validate(bodypackageName, nameof(bodypackageName), required: true);
            WorkflowExpression.Validate(bodynamedContext, nameof(bodynamedContext), required: false);
            WorkflowExpression.Validate(bodyentityCode, nameof(bodyentityCode), required: false);
            WorkflowExpression.Validate(bodycaseCode, nameof(bodycaseCode), required: false);
            WorkflowExpression.Validate(bodyperiodCode, nameof(bodyperiodCode), required: false);
            WorkflowExpression.Validate(bodyjurisdictionCode, nameof(bodyjurisdictionCode), required: false);
            WorkflowExpression.Validate(bodyinternationalTaxName, nameof(bodyinternationalTaxName), required: false);
            WorkflowExpression.Validate(bodyprovisionName, nameof(bodyprovisionName), required: false);
            return new DeferredWorkflowAction(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "corptaxsandbox")]
        [WorkflowExpressionFactory(nameof(__BuildExportDataWithDataSource))]
        public IWorkflowAction ExportDataWithDataSource([WorkflowExpression] Func<string> environmentName, [WorkflowExpression] Func<string> enterpriseName, [WorkflowExpression] Func<string> bodydataSource, [WorkflowExpression] Func<string> bodynamedContext = null, [WorkflowExpression] Func<string> bodyentityCode = null, [WorkflowExpression] Func<string> bodycaseCode = null, [WorkflowExpression] Func<string> bodyperiodCode = null, [WorkflowExpression] Func<string> bodyjurisdictionCode = null, [WorkflowExpression] Func<string> bodyinternationalTaxName = null, [WorkflowExpression] Func<string> bodyprovisionName = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildExportDataWithDataSource(WorkflowExpression<string> environmentName, WorkflowExpression<string> enterpriseName, WorkflowExpression<string> bodydataSource, WorkflowExpression<string> bodynamedContext = null, WorkflowExpression<string> bodyentityCode = null, WorkflowExpression<string> bodycaseCode = null, WorkflowExpression<string> bodyperiodCode = null, WorkflowExpression<string> bodyjurisdictionCode = null, WorkflowExpression<string> bodyinternationalTaxName = null, WorkflowExpression<string> bodyprovisionName = null)
        {
            WorkflowExpression.Validate(environmentName, nameof(environmentName), required: true);
            WorkflowExpression.Validate(enterpriseName, nameof(enterpriseName), required: true);
            WorkflowExpression.Validate(bodydataSource, nameof(bodydataSource), required: true);
            WorkflowExpression.Validate(bodynamedContext, nameof(bodynamedContext), required: false);
            WorkflowExpression.Validate(bodyentityCode, nameof(bodyentityCode), required: false);
            WorkflowExpression.Validate(bodycaseCode, nameof(bodycaseCode), required: false);
            WorkflowExpression.Validate(bodyperiodCode, nameof(bodyperiodCode), required: false);
            WorkflowExpression.Validate(bodyjurisdictionCode, nameof(bodyjurisdictionCode), required: false);
            WorkflowExpression.Validate(bodyinternationalTaxName, nameof(bodyinternationalTaxName), required: false);
            WorkflowExpression.Validate(bodyprovisionName, nameof(bodyprovisionName), required: false);
            return new DeferredWorkflowAction(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "corptaxsandbox")]
        [WorkflowExpressionFactory(nameof(__BuildTriggerCart))]
        public IBodyWorkflowAction<TriggerCartResponse> TriggerCart([WorkflowExpression] Func<string> environmentName, [WorkflowExpression] Func<string> enterpriseName, [WorkflowExpression] Func<string> bodycartName, [WorkflowExpression] Func<bodytypeOfActionInput> bodytypeOfAction, [WorkflowExpression] Func<string> bodynamedContext = null, [WorkflowExpression] Func<string> bodyentityCode = null, [WorkflowExpression] Func<string> bodycaseCode = null, [WorkflowExpression] Func<string> bodyperiodCode = null, [WorkflowExpression] Func<string> bodyjurisdictionCode = null, [WorkflowExpression] Func<string> bodyledgerName = null, [WorkflowExpression] Func<string> bodyisoCurrencyCode = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TriggerCartResponse> __BuildTriggerCart(WorkflowExpression<string> environmentName, WorkflowExpression<string> enterpriseName, WorkflowExpression<string> bodycartName, WorkflowExpression<bodytypeOfActionInput> bodytypeOfAction, WorkflowExpression<string> bodynamedContext = null, WorkflowExpression<string> bodyentityCode = null, WorkflowExpression<string> bodycaseCode = null, WorkflowExpression<string> bodyperiodCode = null, WorkflowExpression<string> bodyjurisdictionCode = null, WorkflowExpression<string> bodyledgerName = null, WorkflowExpression<string> bodyisoCurrencyCode = null)
        {
            WorkflowExpression.Validate(environmentName, nameof(environmentName), required: true);
            WorkflowExpression.Validate(enterpriseName, nameof(enterpriseName), required: true);
            WorkflowExpression.Validate(bodycartName, nameof(bodycartName), required: true);
            WorkflowExpression.Validate(bodytypeOfAction, nameof(bodytypeOfAction), required: true);
            WorkflowExpression.Validate(bodynamedContext, nameof(bodynamedContext), required: false);
            WorkflowExpression.Validate(bodyentityCode, nameof(bodyentityCode), required: false);
            WorkflowExpression.Validate(bodycaseCode, nameof(bodycaseCode), required: false);
            WorkflowExpression.Validate(bodyperiodCode, nameof(bodyperiodCode), required: false);
            WorkflowExpression.Validate(bodyjurisdictionCode, nameof(bodyjurisdictionCode), required: false);
            WorkflowExpression.Validate(bodyledgerName, nameof(bodyledgerName), required: false);
            WorkflowExpression.Validate(bodyisoCurrencyCode, nameof(bodyisoCurrencyCode), required: false);
            return new DeferredBodyAction<TriggerCartResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "corptaxsandbox")]
        [WorkflowExpressionFactory(nameof(__BuildTriggerReturn))]
        public IBodyWorkflowAction<TriggerReturnResponse> TriggerReturn([WorkflowExpression] Func<string> environmentName, [WorkflowExpression] Func<string> enterpriseName, [WorkflowExpression] Func<string> bodyreturnName, [WorkflowExpression] Func<string> bodytypeOfAction)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TriggerReturnResponse> __BuildTriggerReturn(WorkflowExpression<string> environmentName, WorkflowExpression<string> enterpriseName, WorkflowExpression<string> bodyreturnName, WorkflowExpression<string> bodytypeOfAction)
        {
            WorkflowExpression.Validate(environmentName, nameof(environmentName), required: true);
            WorkflowExpression.Validate(enterpriseName, nameof(enterpriseName), required: true);
            WorkflowExpression.Validate(bodyreturnName, nameof(bodyreturnName), required: true);
            WorkflowExpression.Validate(bodytypeOfAction, nameof(bodytypeOfAction), required: true);
            return new DeferredBodyAction<TriggerReturnResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "corptaxsandbox")]
        [WorkflowExpressionFactory(nameof(__BuildDownloadContents))]
        public IBodyWorkflowAction<DownloadContentsResponseItem[]> DownloadContents([WorkflowExpression] Func<string> environmentName, [WorkflowExpression] Func<string> enterpriseName, [WorkflowExpression] Func<typeOfActionInput> typeOfAction, [WorkflowExpression] Func<string> bodyreturnOrCartName)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DownloadContentsResponseItem[]> __BuildDownloadContents(WorkflowExpression<string> environmentName, WorkflowExpression<string> enterpriseName, WorkflowExpression<typeOfActionInput> typeOfAction, WorkflowExpression<string> bodyreturnOrCartName)
        {
            WorkflowExpression.Validate(environmentName, nameof(environmentName), required: true);
            WorkflowExpression.Validate(enterpriseName, nameof(enterpriseName), required: true);
            WorkflowExpression.Validate(typeOfAction, nameof(typeOfAction), required: true);
            WorkflowExpression.Validate(bodyreturnOrCartName, nameof(bodyreturnOrCartName), required: true);
            return new DeferredBodyAction<DownloadContentsResponseItem[]>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "corptaxsandbox")]
        [WorkflowExpressionFactory(nameof(__BuildCheckTriggerStatus))]
        public IBodyWorkflowAction<CheckTriggerStatusResponse> CheckTriggerStatus([WorkflowExpression] Func<string> environmentName, [WorkflowExpression] Func<string> enterpriseName, [WorkflowExpression] Func<typeOfActionInput> typeOfAction, [WorkflowExpression] Func<string> bodyreturnOrCartName)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CheckTriggerStatusResponse> __BuildCheckTriggerStatus(WorkflowExpression<string> environmentName, WorkflowExpression<string> enterpriseName, WorkflowExpression<typeOfActionInput> typeOfAction, WorkflowExpression<string> bodyreturnOrCartName)
        {
            WorkflowExpression.Validate(environmentName, nameof(environmentName), required: true);
            WorkflowExpression.Validate(enterpriseName, nameof(enterpriseName), required: true);
            WorkflowExpression.Validate(typeOfAction, nameof(typeOfAction), required: true);
            WorkflowExpression.Validate(bodyreturnOrCartName, nameof(bodyreturnOrCartName), required: true);
            return new DeferredBodyAction<CheckTriggerStatusResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "corptaxsandbox")]
        [WorkflowExpressionFactory(nameof(__BuildImportData))]
        public IBodyWorkflowAction<ImportDataResponse> ImportData([WorkflowExpression] Func<string> environmentName, [WorkflowExpression] Func<string> enterpriseName, [WorkflowExpression] Func<string> bodypackageName, [WorkflowExpression] Func<string> bodyfileContents, [WorkflowExpression] Func<string> bodyfileName, [WorkflowExpression] Func<bodyimportTransactionTypeInput> bodyimportTransactionType, [WorkflowExpression] Func<string> bodychartOfAccountsName, [WorkflowExpression] Func<bool> bodyrecognizeFunctionalCurrency, [WorkflowExpression] Func<bool> bodystopOnLookupErrors, [WorkflowExpression] Func<string> bodyentityCode = null, [WorkflowExpression] Func<string> bodycaseCode = null, [WorkflowExpression] Func<string> bodyperiodCode = null, [WorkflowExpression] Func<string> bodyjurisdictionCode = null, [WorkflowExpression] Func<bodyledgerAmountTypeInput> bodyledgerAmountType = null, [WorkflowExpression] Func<string> bodyfunctionalCurrencyValue = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ImportDataResponse> __BuildImportData(WorkflowExpression<string> environmentName, WorkflowExpression<string> enterpriseName, WorkflowExpression<string> bodypackageName, WorkflowExpression<string> bodyfileContents, WorkflowExpression<string> bodyfileName, WorkflowExpression<bodyimportTransactionTypeInput> bodyimportTransactionType, WorkflowExpression<string> bodychartOfAccountsName, WorkflowExpression<bool> bodyrecognizeFunctionalCurrency, WorkflowExpression<bool> bodystopOnLookupErrors, WorkflowExpression<string> bodyentityCode = null, WorkflowExpression<string> bodycaseCode = null, WorkflowExpression<string> bodyperiodCode = null, WorkflowExpression<string> bodyjurisdictionCode = null, WorkflowExpression<bodyledgerAmountTypeInput> bodyledgerAmountType = null, WorkflowExpression<string> bodyfunctionalCurrencyValue = null)
        {
            WorkflowExpression.Validate(environmentName, nameof(environmentName), required: true);
            WorkflowExpression.Validate(enterpriseName, nameof(enterpriseName), required: true);
            WorkflowExpression.Validate(bodypackageName, nameof(bodypackageName), required: true);
            WorkflowExpression.Validate(bodyfileContents, nameof(bodyfileContents), required: true);
            WorkflowExpression.Validate(bodyfileName, nameof(bodyfileName), required: true);
            WorkflowExpression.Validate(bodyimportTransactionType, nameof(bodyimportTransactionType), required: true);
            WorkflowExpression.Validate(bodychartOfAccountsName, nameof(bodychartOfAccountsName), required: true);
            WorkflowExpression.Validate(bodyrecognizeFunctionalCurrency, nameof(bodyrecognizeFunctionalCurrency), required: true);
            WorkflowExpression.Validate(bodystopOnLookupErrors, nameof(bodystopOnLookupErrors), required: true);
            WorkflowExpression.Validate(bodyentityCode, nameof(bodyentityCode), required: false);
            WorkflowExpression.Validate(bodycaseCode, nameof(bodycaseCode), required: false);
            WorkflowExpression.Validate(bodyperiodCode, nameof(bodyperiodCode), required: false);
            WorkflowExpression.Validate(bodyjurisdictionCode, nameof(bodyjurisdictionCode), required: false);
            WorkflowExpression.Validate(bodyledgerAmountType, nameof(bodyledgerAmountType), required: false);
            WorkflowExpression.Validate(bodyfunctionalCurrencyValue, nameof(bodyfunctionalCurrencyValue), required: false);
            return new DeferredBodyAction<ImportDataResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "corptaxsandbox")]
        [WorkflowExpressionFactory(nameof(__BuildCorptaxEfileGroups))]
        public IWorkflowAction CorptaxEfileGroups([WorkflowExpression] Func<string> environmentName, [WorkflowExpression] Func<string> enterpriseName, [WorkflowExpression] Func<string> filingGroup = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildCorptaxEfileGroups(WorkflowExpression<string> environmentName, WorkflowExpression<string> enterpriseName, WorkflowExpression<string> filingGroup = null)
        {
            WorkflowExpression.Validate(environmentName, nameof(environmentName), required: true);
            WorkflowExpression.Validate(enterpriseName, nameof(enterpriseName), required: true);
            WorkflowExpression.Validate(filingGroup, nameof(filingGroup), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/efileGroups";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["environmentName"] = ExpressionConverter.Convert(environmentName);
                callPayload.Headers["enterpriseName"] = ExpressionConverter.Convert(enterpriseName);
                if (filingGroup != null)
                    callPayload.Headers["filingGroup"] = ExpressionConverter.Convert(filingGroup);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "corptaxsandbox")]
        [WorkflowExpressionFactory(nameof(__BuildCorptaxEfilePackage))]
        public IWorkflowAction CorptaxEfilePackage([WorkflowExpression] Func<string> environmentName, [WorkflowExpression] Func<string> enterpriseName, [WorkflowExpression] Func<string> filingGroup, [WorkflowExpression] Func<bool> bodyefilePackageDetails, [WorkflowExpression] Func<string> bodyentityCode = null, [WorkflowExpression] Func<string> bodyform = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildCorptaxEfilePackage(WorkflowExpression<string> environmentName, WorkflowExpression<string> enterpriseName, WorkflowExpression<string> filingGroup, WorkflowExpression<bool> bodyefilePackageDetails, WorkflowExpression<string> bodyentityCode = null, WorkflowExpression<string> bodyform = null)
        {
            WorkflowExpression.Validate(environmentName, nameof(environmentName), required: true);
            WorkflowExpression.Validate(enterpriseName, nameof(enterpriseName), required: true);
            WorkflowExpression.Validate(filingGroup, nameof(filingGroup), required: true);
            WorkflowExpression.Validate(bodyefilePackageDetails, nameof(bodyefilePackageDetails), required: true);
            WorkflowExpression.Validate(bodyentityCode, nameof(bodyentityCode), required: false);
            WorkflowExpression.Validate(bodyform, nameof(bodyform), required: false);
            return new DeferredWorkflowAction(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "corptaxsandbox")]
        [WorkflowExpressionFactory(nameof(__BuildGetJobHistory))]
        public IBodyWorkflowAction<GetJobHistoryResponse> GetJobHistory([WorkflowExpression] Func<string> environmentName, [WorkflowExpression] Func<string> bodyjobToken, [WorkflowExpression] Func<bodyreportInput> bodyreport = null, [WorkflowExpression] Func<bodyreportFormatInput> bodyreportFormat = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetJobHistoryResponse> __BuildGetJobHistory(WorkflowExpression<string> environmentName, WorkflowExpression<string> bodyjobToken, WorkflowExpression<bodyreportInput> bodyreport = null, WorkflowExpression<bodyreportFormatInput> bodyreportFormat = null)
        {
            WorkflowExpression.Validate(environmentName, nameof(environmentName), required: true);
            WorkflowExpression.Validate(bodyjobToken, nameof(bodyjobToken), required: true);
            WorkflowExpression.Validate(bodyreport, nameof(bodyreport), required: false);
            WorkflowExpression.Validate(bodyreportFormat, nameof(bodyreportFormat), required: false);
            return new DeferredBodyAction<GetJobHistoryResponse>(() =>
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
                    if (bodyreport != null)
                    {
                        body["report"] = ExpressionConverter.ConvertO(bodyreport);
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
                        body["reportFormat"] = ExpressionConverter.ConvertO(bodyreportFormat);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "corptaxsandbox")]
        [WorkflowExpressionFactory(nameof(__BuildGetGmtDiagnostics))]
        public IWorkflowAction GetGmtDiagnostics([WorkflowExpression] Func<string> environmentName, [WorkflowExpression] Func<string> enterpriseName, [WorkflowExpression] Func<string> bodygmtSetting, [WorkflowExpression] Func<string> bodygmtDiagnosticName)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildGetGmtDiagnostics(WorkflowExpression<string> environmentName, WorkflowExpression<string> enterpriseName, WorkflowExpression<string> bodygmtSetting, WorkflowExpression<string> bodygmtDiagnosticName)
        {
            WorkflowExpression.Validate(environmentName, nameof(environmentName), required: true);
            WorkflowExpression.Validate(enterpriseName, nameof(enterpriseName), required: true);
            WorkflowExpression.Validate(bodygmtSetting, nameof(bodygmtSetting), required: true);
            WorkflowExpression.Validate(bodygmtDiagnosticName, nameof(bodygmtDiagnosticName), required: true);
            return new DeferredWorkflowAction(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "corptaxsandbox")]
        [WorkflowExpressionFactory(nameof(__BuildReturnCalculationDetails))]
        public IWorkflowAction ReturnCalculationDetails([WorkflowExpression] Func<string> environmentName, [WorkflowExpression] Func<string> enterpriseName, [WorkflowExpression] Func<string> bodyreturnName)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildReturnCalculationDetails(WorkflowExpression<string> environmentName, WorkflowExpression<string> enterpriseName, WorkflowExpression<string> bodyreturnName)
        {
            WorkflowExpression.Validate(environmentName, nameof(environmentName), required: true);
            WorkflowExpression.Validate(enterpriseName, nameof(enterpriseName), required: true);
            WorkflowExpression.Validate(bodyreturnName, nameof(bodyreturnName), required: true);
            return new DeferredWorkflowAction(() =>
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
            });
        }
    }

    public class CorptaxsandboxTriggers([ConnectionName] string connectionId)
    {
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

    public class TriggerCartResponse
    {
        public string OperationId { get; set; }
        public string Name { get; set; }
        public string Message { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyreportInput
    {
        Summary,
        Reject,
        Detail
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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