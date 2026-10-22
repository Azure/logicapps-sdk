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
        public IWorkflowAction<ApiConnectionActionConfiguration> CorptaxEntityViews(Expression<Func<string>> environmentName, Expression<Func<string>> enterpriseName, Expression<Func<string>> bodyqualifiedviewName = null)
        {
            var __workflow_environmentName = WorkflowExpression.Compile(environmentName, nameof(environmentName), required: true);
            var __workflow_enterpriseName = WorkflowExpression.Compile(enterpriseName, nameof(enterpriseName), required: true);
            var __workflow_bodyqualifiedviewName = WorkflowExpression.Compile(bodyqualifiedviewName, nameof(bodyqualifiedviewName), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/entityView";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["environmentName"] = ExpressionConverter.Convert(__workflow_environmentName);
                callPayload.Headers["enterpriseName"] = ExpressionConverter.Convert(__workflow_enterpriseName);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyqualifiedviewName != null)
                {
                    body["qualifiedviewName"] = ExpressionConverter.ConvertO(__workflow_bodyqualifiedviewName);
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
        public IWorkflowAction<ApiConnectionActionConfiguration> DataExchangeLookup(Expression<Func<string>> environmentName, Expression<Func<string>> enterpriseName, Expression<Func<lookupTypeInput>> lookupType, Expression<Func<bool>> bodydetails, Expression<Func<string>> bodylookupName = null)
        {
            var __workflow_environmentName = WorkflowExpression.Compile(environmentName, nameof(environmentName), required: true);
            var __workflow_enterpriseName = WorkflowExpression.Compile(enterpriseName, nameof(enterpriseName), required: true);
            var __workflow_lookupType = WorkflowExpression.Compile(lookupType, nameof(lookupType), required: true);
            var __workflow_bodydetails = WorkflowExpression.Compile(bodydetails, nameof(bodydetails), required: true);
            var __workflow_bodylookupName = WorkflowExpression.Compile(bodylookupName, nameof(bodylookupName), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/DataExchangeLookup";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["environmentName"] = ExpressionConverter.Convert(__workflow_environmentName);
                callPayload.Headers["enterpriseName"] = ExpressionConverter.Convert(__workflow_enterpriseName);
                callPayload.Headers["lookupType"] = ExpressionConverter.Convert(__workflow_lookupType);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodylookupName != null)
                {
                    body["lookupName"] = ExpressionConverter.ConvertO(__workflow_bodylookupName);
                    bodypropCount++;
                }

                bodypropCount++;
                body["details"] = ExpressionConverter.ConvertO(__workflow_bodydetails);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "corptaxsandbox")]
        public IWorkflowAction<ApiConnectionActionConfiguration> EntityList(Expression<Func<string>> environmentName, Expression<Func<string>> enterpriseName, Expression<Func<bool>> bodyactive = null, Expression<Func<string>> bodyperiodName = null, Expression<Func<string>> bodyviewName = null)
        {
            var __workflow_environmentName = WorkflowExpression.Compile(environmentName, nameof(environmentName), required: true);
            var __workflow_enterpriseName = WorkflowExpression.Compile(enterpriseName, nameof(enterpriseName), required: true);
            var __workflow_bodyactive = WorkflowExpression.Compile(bodyactive, nameof(bodyactive), required: false);
            var __workflow_bodyperiodName = WorkflowExpression.Compile(bodyperiodName, nameof(bodyperiodName), required: false);
            var __workflow_bodyviewName = WorkflowExpression.Compile(bodyviewName, nameof(bodyviewName), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/EntityLists";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["environmentName"] = ExpressionConverter.Convert(__workflow_environmentName);
                callPayload.Headers["enterpriseName"] = ExpressionConverter.Convert(__workflow_enterpriseName);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyactive != null)
                {
                    body["active"] = ExpressionConverter.ConvertO(__workflow_bodyactive);
                    bodypropCount++;
                }

                if (__workflow_bodyperiodName != null)
                {
                    body["periodName"] = ExpressionConverter.ConvertO(__workflow_bodyperiodName);
                    bodypropCount++;
                }

                if (__workflow_bodyviewName != null)
                {
                    body["viewName"] = ExpressionConverter.ConvertO(__workflow_bodyviewName);
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
        public IWorkflowAction<ApiConnectionActionConfiguration> ExportData(Expression<Func<string>> environmentName, Expression<Func<string>> enterpriseName, Expression<Func<string>> bodypackageName, Expression<Func<string>> bodynamedContext = null, Expression<Func<string>> bodyentityCode = null, Expression<Func<string>> bodycaseCode = null, Expression<Func<string>> bodyperiodCode = null, Expression<Func<string>> bodyjurisdictionCode = null, Expression<Func<string>> bodyinternationalTaxName = null, Expression<Func<string>> bodyprovisionName = null)
        {
            var __workflow_environmentName = WorkflowExpression.Compile(environmentName, nameof(environmentName), required: true);
            var __workflow_enterpriseName = WorkflowExpression.Compile(enterpriseName, nameof(enterpriseName), required: true);
            var __workflow_bodypackageName = WorkflowExpression.Compile(bodypackageName, nameof(bodypackageName), required: true);
            var __workflow_bodynamedContext = WorkflowExpression.Compile(bodynamedContext, nameof(bodynamedContext), required: false);
            var __workflow_bodyentityCode = WorkflowExpression.Compile(bodyentityCode, nameof(bodyentityCode), required: false);
            var __workflow_bodycaseCode = WorkflowExpression.Compile(bodycaseCode, nameof(bodycaseCode), required: false);
            var __workflow_bodyperiodCode = WorkflowExpression.Compile(bodyperiodCode, nameof(bodyperiodCode), required: false);
            var __workflow_bodyjurisdictionCode = WorkflowExpression.Compile(bodyjurisdictionCode, nameof(bodyjurisdictionCode), required: false);
            var __workflow_bodyinternationalTaxName = WorkflowExpression.Compile(bodyinternationalTaxName, nameof(bodyinternationalTaxName), required: false);
            var __workflow_bodyprovisionName = WorkflowExpression.Compile(bodyprovisionName, nameof(bodyprovisionName), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/dataExport";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["environmentName"] = ExpressionConverter.Convert(__workflow_environmentName);
                callPayload.Headers["enterpriseName"] = ExpressionConverter.Convert(__workflow_enterpriseName);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodynamedContext != null)
                {
                    body["namedContext"] = ExpressionConverter.ConvertO(__workflow_bodynamedContext);
                    bodypropCount++;
                }

                if (__workflow_bodyentityCode != null)
                {
                    body["entityCode"] = ExpressionConverter.ConvertO(__workflow_bodyentityCode);
                    bodypropCount++;
                }

                if (__workflow_bodycaseCode != null)
                {
                    body["caseCode"] = ExpressionConverter.ConvertO(__workflow_bodycaseCode);
                    bodypropCount++;
                }

                if (__workflow_bodyperiodCode != null)
                {
                    body["periodCode"] = ExpressionConverter.ConvertO(__workflow_bodyperiodCode);
                    bodypropCount++;
                }

                if (__workflow_bodyjurisdictionCode != null)
                {
                    body["jurisdictionCode"] = ExpressionConverter.ConvertO(__workflow_bodyjurisdictionCode);
                    bodypropCount++;
                }

                bodypropCount++;
                body["packageName"] = ExpressionConverter.ConvertO(__workflow_bodypackageName);
                if (__workflow_bodyinternationalTaxName != null)
                {
                    body["internationalTaxName"] = ExpressionConverter.ConvertO(__workflow_bodyinternationalTaxName);
                    bodypropCount++;
                }

                if (__workflow_bodyprovisionName != null)
                {
                    body["provisionName"] = ExpressionConverter.ConvertO(__workflow_bodyprovisionName);
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
        public IWorkflowAction<ApiConnectionActionConfiguration> ExportDataWithDataSource(Expression<Func<string>> environmentName, Expression<Func<string>> enterpriseName, Expression<Func<string>> bodydataSource, Expression<Func<string>> bodynamedContext = null, Expression<Func<string>> bodyentityCode = null, Expression<Func<string>> bodycaseCode = null, Expression<Func<string>> bodyperiodCode = null, Expression<Func<string>> bodyjurisdictionCode = null, Expression<Func<string>> bodyinternationalTaxName = null, Expression<Func<string>> bodyprovisionName = null)
        {
            var __workflow_environmentName = WorkflowExpression.Compile(environmentName, nameof(environmentName), required: true);
            var __workflow_enterpriseName = WorkflowExpression.Compile(enterpriseName, nameof(enterpriseName), required: true);
            var __workflow_bodydataSource = WorkflowExpression.Compile(bodydataSource, nameof(bodydataSource), required: true);
            var __workflow_bodynamedContext = WorkflowExpression.Compile(bodynamedContext, nameof(bodynamedContext), required: false);
            var __workflow_bodyentityCode = WorkflowExpression.Compile(bodyentityCode, nameof(bodyentityCode), required: false);
            var __workflow_bodycaseCode = WorkflowExpression.Compile(bodycaseCode, nameof(bodycaseCode), required: false);
            var __workflow_bodyperiodCode = WorkflowExpression.Compile(bodyperiodCode, nameof(bodyperiodCode), required: false);
            var __workflow_bodyjurisdictionCode = WorkflowExpression.Compile(bodyjurisdictionCode, nameof(bodyjurisdictionCode), required: false);
            var __workflow_bodyinternationalTaxName = WorkflowExpression.Compile(bodyinternationalTaxName, nameof(bodyinternationalTaxName), required: false);
            var __workflow_bodyprovisionName = WorkflowExpression.Compile(bodyprovisionName, nameof(bodyprovisionName), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/dataExportWithDataSource";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["environmentName"] = ExpressionConverter.Convert(__workflow_environmentName);
                callPayload.Headers["enterpriseName"] = ExpressionConverter.Convert(__workflow_enterpriseName);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodynamedContext != null)
                {
                    body["namedContext"] = ExpressionConverter.ConvertO(__workflow_bodynamedContext);
                    bodypropCount++;
                }

                if (__workflow_bodyentityCode != null)
                {
                    body["entityCode"] = ExpressionConverter.ConvertO(__workflow_bodyentityCode);
                    bodypropCount++;
                }

                if (__workflow_bodycaseCode != null)
                {
                    body["caseCode"] = ExpressionConverter.ConvertO(__workflow_bodycaseCode);
                    bodypropCount++;
                }

                if (__workflow_bodyperiodCode != null)
                {
                    body["periodCode"] = ExpressionConverter.ConvertO(__workflow_bodyperiodCode);
                    bodypropCount++;
                }

                if (__workflow_bodyjurisdictionCode != null)
                {
                    body["jurisdictionCode"] = ExpressionConverter.ConvertO(__workflow_bodyjurisdictionCode);
                    bodypropCount++;
                }

                bodypropCount++;
                body["dataSource"] = ExpressionConverter.ConvertO(__workflow_bodydataSource);
                if (__workflow_bodyinternationalTaxName != null)
                {
                    body["internationalTaxName"] = ExpressionConverter.ConvertO(__workflow_bodyinternationalTaxName);
                    bodypropCount++;
                }

                if (__workflow_bodyprovisionName != null)
                {
                    body["provisionName"] = ExpressionConverter.ConvertO(__workflow_bodyprovisionName);
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
        public IBodyWorkflowAction<TriggerCartResponse, ApiConnectionActionConfiguration> TriggerCart(Expression<Func<string>> environmentName, Expression<Func<string>> enterpriseName, Expression<Func<string>> bodycartName, Expression<Func<bodytypeOfActionInput>> bodytypeOfAction, Expression<Func<string>> bodynamedContext = null, Expression<Func<string>> bodyentityCode = null, Expression<Func<string>> bodycaseCode = null, Expression<Func<string>> bodyperiodCode = null, Expression<Func<string>> bodyjurisdictionCode = null, Expression<Func<string>> bodyledgerName = null, Expression<Func<string>> bodyisoCurrencyCode = null)
        {
            var __workflow_environmentName = WorkflowExpression.Compile(environmentName, nameof(environmentName), required: true);
            var __workflow_enterpriseName = WorkflowExpression.Compile(enterpriseName, nameof(enterpriseName), required: true);
            var __workflow_bodycartName = WorkflowExpression.Compile(bodycartName, nameof(bodycartName), required: true);
            var __workflow_bodytypeOfAction = WorkflowExpression.Compile(bodytypeOfAction, nameof(bodytypeOfAction), required: true);
            var __workflow_bodynamedContext = WorkflowExpression.Compile(bodynamedContext, nameof(bodynamedContext), required: false);
            var __workflow_bodyentityCode = WorkflowExpression.Compile(bodyentityCode, nameof(bodyentityCode), required: false);
            var __workflow_bodycaseCode = WorkflowExpression.Compile(bodycaseCode, nameof(bodycaseCode), required: false);
            var __workflow_bodyperiodCode = WorkflowExpression.Compile(bodyperiodCode, nameof(bodyperiodCode), required: false);
            var __workflow_bodyjurisdictionCode = WorkflowExpression.Compile(bodyjurisdictionCode, nameof(bodyjurisdictionCode), required: false);
            var __workflow_bodyledgerName = WorkflowExpression.Compile(bodyledgerName, nameof(bodyledgerName), required: false);
            var __workflow_bodyisoCurrencyCode = WorkflowExpression.Compile(bodyisoCurrencyCode, nameof(bodyisoCurrencyCode), required: false);
            return new DeferredBodyAction<TriggerCartResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/triggerCart";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["environmentName"] = ExpressionConverter.Convert(__workflow_environmentName);
                callPayload.Headers["enterpriseName"] = ExpressionConverter.Convert(__workflow_enterpriseName);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["cartName"] = ExpressionConverter.ConvertO(__workflow_bodycartName);
                bodypropCount++;
                body["typeOfAction"] = ExpressionConverter.ConvertO(__workflow_bodytypeOfAction);
                if (__workflow_bodynamedContext != null)
                {
                    body["namedContext"] = ExpressionConverter.ConvertO(__workflow_bodynamedContext);
                    bodypropCount++;
                }

                if (__workflow_bodyentityCode != null)
                {
                    body["entityCode"] = ExpressionConverter.ConvertO(__workflow_bodyentityCode);
                    bodypropCount++;
                }

                if (__workflow_bodycaseCode != null)
                {
                    body["caseCode"] = ExpressionConverter.ConvertO(__workflow_bodycaseCode);
                    bodypropCount++;
                }

                if (__workflow_bodyperiodCode != null)
                {
                    body["periodCode"] = ExpressionConverter.ConvertO(__workflow_bodyperiodCode);
                    bodypropCount++;
                }

                if (__workflow_bodyjurisdictionCode != null)
                {
                    body["jurisdictionCode"] = ExpressionConverter.ConvertO(__workflow_bodyjurisdictionCode);
                    bodypropCount++;
                }

                if (__workflow_bodyledgerName != null)
                {
                    body["ledgerName"] = ExpressionConverter.ConvertO(__workflow_bodyledgerName);
                    bodypropCount++;
                }

                if (__workflow_bodyisoCurrencyCode != null)
                {
                    body["isoCurrencyCode"] = ExpressionConverter.ConvertO(__workflow_bodyisoCurrencyCode);
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
        public IBodyWorkflowAction<TriggerReturnResponse, ApiConnectionActionConfiguration> TriggerReturn(Expression<Func<string>> environmentName, Expression<Func<string>> enterpriseName, Expression<Func<string>> bodyreturnName, Expression<Func<string>> bodytypeOfAction)
        {
            var __workflow_environmentName = WorkflowExpression.Compile(environmentName, nameof(environmentName), required: true);
            var __workflow_enterpriseName = WorkflowExpression.Compile(enterpriseName, nameof(enterpriseName), required: true);
            var __workflow_bodyreturnName = WorkflowExpression.Compile(bodyreturnName, nameof(bodyreturnName), required: true);
            var __workflow_bodytypeOfAction = WorkflowExpression.Compile(bodytypeOfAction, nameof(bodytypeOfAction), required: true);
            return new DeferredBodyAction<TriggerReturnResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/triggerReturn";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["environmentName"] = ExpressionConverter.Convert(__workflow_environmentName);
                callPayload.Headers["enterpriseName"] = ExpressionConverter.Convert(__workflow_enterpriseName);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["returnName"] = ExpressionConverter.ConvertO(__workflow_bodyreturnName);
                bodypropCount++;
                body["typeOfAction"] = ExpressionConverter.ConvertO(__workflow_bodytypeOfAction);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<TriggerReturnResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "corptaxsandbox")]
        public IBodyWorkflowAction<DownloadContentsResponseItem[], ApiConnectionActionConfiguration> DownloadContents(Expression<Func<string>> environmentName, Expression<Func<string>> enterpriseName, Expression<Func<typeOfActionInput>> typeOfAction, Expression<Func<string>> bodyreturnOrCartName)
        {
            var __workflow_environmentName = WorkflowExpression.Compile(environmentName, nameof(environmentName), required: true);
            var __workflow_enterpriseName = WorkflowExpression.Compile(enterpriseName, nameof(enterpriseName), required: true);
            var __workflow_typeOfAction = WorkflowExpression.Compile(typeOfAction, nameof(typeOfAction), required: true);
            var __workflow_bodyreturnOrCartName = WorkflowExpression.Compile(bodyreturnOrCartName, nameof(bodyreturnOrCartName), required: true);
            return new DeferredBodyAction<DownloadContentsResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/downloadContents";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["environmentName"] = ExpressionConverter.Convert(__workflow_environmentName);
                callPayload.Headers["enterpriseName"] = ExpressionConverter.Convert(__workflow_enterpriseName);
                callPayload.Headers["typeOfAction"] = ExpressionConverter.Convert(__workflow_typeOfAction);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["returnOrCartName"] = ExpressionConverter.ConvertO(__workflow_bodyreturnOrCartName);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<DownloadContentsResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "corptaxsandbox")]
        public IBodyWorkflowAction<CheckTriggerStatusResponse, ApiConnectionActionConfiguration> CheckTriggerStatus(Expression<Func<string>> environmentName, Expression<Func<string>> enterpriseName, Expression<Func<typeOfActionInput>> typeOfAction, Expression<Func<string>> bodyreturnOrCartName)
        {
            var __workflow_environmentName = WorkflowExpression.Compile(environmentName, nameof(environmentName), required: true);
            var __workflow_enterpriseName = WorkflowExpression.Compile(enterpriseName, nameof(enterpriseName), required: true);
            var __workflow_typeOfAction = WorkflowExpression.Compile(typeOfAction, nameof(typeOfAction), required: true);
            var __workflow_bodyreturnOrCartName = WorkflowExpression.Compile(bodyreturnOrCartName, nameof(bodyreturnOrCartName), required: true);
            return new DeferredBodyAction<CheckTriggerStatusResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/checkTriggerStatus";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["environmentName"] = ExpressionConverter.Convert(__workflow_environmentName);
                callPayload.Headers["enterpriseName"] = ExpressionConverter.Convert(__workflow_enterpriseName);
                callPayload.Headers["typeOfAction"] = ExpressionConverter.Convert(__workflow_typeOfAction);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["returnOrCartName"] = ExpressionConverter.ConvertO(__workflow_bodyreturnOrCartName);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CheckTriggerStatusResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "corptaxsandbox")]
        public IBodyWorkflowAction<ImportDataResponse, ApiConnectionActionConfiguration> ImportData(Expression<Func<string>> environmentName, Expression<Func<string>> enterpriseName, Expression<Func<string>> bodypackageName, Expression<Func<string>> bodyfileContents, Expression<Func<string>> bodyfileName, Expression<Func<bodyimportTransactionTypeInput>> bodyimportTransactionType, Expression<Func<string>> bodychartOfAccountsName, Expression<Func<bool>> bodyrecognizeFunctionalCurrency, Expression<Func<bool>> bodystopOnLookupErrors, Expression<Func<string>> bodyentityCode = null, Expression<Func<string>> bodycaseCode = null, Expression<Func<string>> bodyperiodCode = null, Expression<Func<string>> bodyjurisdictionCode = null, Expression<Func<bodyledgerAmountTypeInput>> bodyledgerAmountType = null, Expression<Func<string>> bodyfunctionalCurrencyValue = null)
        {
            var __workflow_environmentName = WorkflowExpression.Compile(environmentName, nameof(environmentName), required: true);
            var __workflow_enterpriseName = WorkflowExpression.Compile(enterpriseName, nameof(enterpriseName), required: true);
            var __workflow_bodypackageName = WorkflowExpression.Compile(bodypackageName, nameof(bodypackageName), required: true);
            var __workflow_bodyfileContents = WorkflowExpression.Compile(bodyfileContents, nameof(bodyfileContents), required: true);
            var __workflow_bodyfileName = WorkflowExpression.Compile(bodyfileName, nameof(bodyfileName), required: true);
            var __workflow_bodyimportTransactionType = WorkflowExpression.Compile(bodyimportTransactionType, nameof(bodyimportTransactionType), required: true);
            var __workflow_bodychartOfAccountsName = WorkflowExpression.Compile(bodychartOfAccountsName, nameof(bodychartOfAccountsName), required: true);
            var __workflow_bodyrecognizeFunctionalCurrency = WorkflowExpression.Compile(bodyrecognizeFunctionalCurrency, nameof(bodyrecognizeFunctionalCurrency), required: true);
            var __workflow_bodystopOnLookupErrors = WorkflowExpression.Compile(bodystopOnLookupErrors, nameof(bodystopOnLookupErrors), required: true);
            var __workflow_bodyentityCode = WorkflowExpression.Compile(bodyentityCode, nameof(bodyentityCode), required: false);
            var __workflow_bodycaseCode = WorkflowExpression.Compile(bodycaseCode, nameof(bodycaseCode), required: false);
            var __workflow_bodyperiodCode = WorkflowExpression.Compile(bodyperiodCode, nameof(bodyperiodCode), required: false);
            var __workflow_bodyjurisdictionCode = WorkflowExpression.Compile(bodyjurisdictionCode, nameof(bodyjurisdictionCode), required: false);
            var __workflow_bodyledgerAmountType = WorkflowExpression.Compile(bodyledgerAmountType, nameof(bodyledgerAmountType), required: false);
            var __workflow_bodyfunctionalCurrencyValue = WorkflowExpression.Compile(bodyfunctionalCurrencyValue, nameof(bodyfunctionalCurrencyValue), required: false);
            return new DeferredBodyAction<ImportDataResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/importData";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["environmentName"] = ExpressionConverter.Convert(__workflow_environmentName);
                callPayload.Headers["enterpriseName"] = ExpressionConverter.Convert(__workflow_enterpriseName);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyentityCode != null)
                {
                    body["entityCode"] = ExpressionConverter.ConvertO(__workflow_bodyentityCode);
                    bodypropCount++;
                }

                if (__workflow_bodycaseCode != null)
                {
                    body["caseCode"] = ExpressionConverter.ConvertO(__workflow_bodycaseCode);
                    bodypropCount++;
                }

                if (__workflow_bodyperiodCode != null)
                {
                    body["periodCode"] = ExpressionConverter.ConvertO(__workflow_bodyperiodCode);
                    bodypropCount++;
                }

                if (__workflow_bodyjurisdictionCode != null)
                {
                    body["jurisdictionCode"] = ExpressionConverter.ConvertO(__workflow_bodyjurisdictionCode);
                    bodypropCount++;
                }

                bodypropCount++;
                body["packageName"] = ExpressionConverter.ConvertO(__workflow_bodypackageName);
                bodypropCount++;
                body["fileContents"] = ExpressionConverter.ConvertO(__workflow_bodyfileContents);
                bodypropCount++;
                body["fileName"] = ExpressionConverter.ConvertO(__workflow_bodyfileName);
                bodypropCount++;
                body["importTransactionType"] = ExpressionConverter.ConvertO(__workflow_bodyimportTransactionType);
                bodypropCount++;
                body["chartOfAccountsName"] = ExpressionConverter.ConvertO(__workflow_bodychartOfAccountsName);
                bodypropCount++;
                body["recognizeFunctionalCurrency"] = ExpressionConverter.ConvertO(__workflow_bodyrecognizeFunctionalCurrency);
                bodypropCount++;
                body["stopOnLookupErrors"] = ExpressionConverter.ConvertO(__workflow_bodystopOnLookupErrors);
                if (__workflow_bodyledgerAmountType != null)
                {
                    body["ledgerAmountType"] = ExpressionConverter.ConvertO(__workflow_bodyledgerAmountType);
                    bodypropCount++;
                }

                if (__workflow_bodyfunctionalCurrencyValue != null)
                {
                    body["functionalCurrencyValue"] = ExpressionConverter.ConvertO(__workflow_bodyfunctionalCurrencyValue);
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
        public IWorkflowAction<ApiConnectionActionConfiguration> CorptaxEfilePackage(Expression<Func<string>> environmentName, Expression<Func<string>> enterpriseName, Expression<Func<string>> filingGroup, Expression<Func<bool>> bodyefilePackageDetails, Expression<Func<string>> bodyentityCode = null, Expression<Func<string>> bodyform = null)
        {
            var __workflow_environmentName = WorkflowExpression.Compile(environmentName, nameof(environmentName), required: true);
            var __workflow_enterpriseName = WorkflowExpression.Compile(enterpriseName, nameof(enterpriseName), required: true);
            var __workflow_filingGroup = WorkflowExpression.Compile(filingGroup, nameof(filingGroup), required: true);
            var __workflow_bodyefilePackageDetails = WorkflowExpression.Compile(bodyefilePackageDetails, nameof(bodyefilePackageDetails), required: true);
            var __workflow_bodyentityCode = WorkflowExpression.Compile(bodyentityCode, nameof(bodyentityCode), required: false);
            var __workflow_bodyform = WorkflowExpression.Compile(bodyform, nameof(bodyform), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/efilePackage";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["environmentName"] = ExpressionConverter.Convert(__workflow_environmentName);
                callPayload.Headers["enterpriseName"] = ExpressionConverter.Convert(__workflow_enterpriseName);
                callPayload.Headers["filingGroup"] = ExpressionConverter.Convert(__workflow_filingGroup);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyentityCode != null)
                {
                    body["entityCode"] = ExpressionConverter.ConvertO(__workflow_bodyentityCode);
                    bodypropCount++;
                }

                if (__workflow_bodyform != null)
                {
                    body["form"] = ExpressionConverter.ConvertO(__workflow_bodyform);
                    bodypropCount++;
                }

                bodypropCount++;
                body["efilePackageDetails"] = ExpressionConverter.ConvertO(__workflow_bodyefilePackageDetails);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "corptaxsandbox")]
        public IBodyWorkflowAction<GetJobHistoryResponse, ApiConnectionActionConfiguration> GetJobHistory(Expression<Func<string>> environmentName, Expression<Func<string>> bodyjobToken, Expression<Func<bodyreportInput>> bodyreport = null, Expression<Func<bodyreportFormatInput>> bodyreportFormat = null)
        {
            var __workflow_environmentName = WorkflowExpression.Compile(environmentName, nameof(environmentName), required: true);
            var __workflow_bodyjobToken = WorkflowExpression.Compile(bodyjobToken, nameof(bodyjobToken), required: true);
            var __workflow_bodyreport = WorkflowExpression.Compile(bodyreport, nameof(bodyreport), required: false);
            var __workflow_bodyreportFormat = WorkflowExpression.Compile(bodyreportFormat, nameof(bodyreportFormat), required: false);
            return new DeferredBodyAction<GetJobHistoryResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/JobHistoryReports";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["environmentName"] = ExpressionConverter.Convert(__workflow_environmentName);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["jobToken"] = ExpressionConverter.ConvertO(__workflow_bodyjobToken);
                if (__workflow_bodyreport != null)
                {
                    if (__workflow_bodyreport != null)
                    {
                        body["report"] = ExpressionConverter.ConvertO(__workflow_bodyreport);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["report"] = "Summary";
                    bodypropCount++;
                }

                if (__workflow_bodyreportFormat != null)
                {
                    if (__workflow_bodyreportFormat != null)
                    {
                        body["reportFormat"] = ExpressionConverter.ConvertO(__workflow_bodyreportFormat);
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
        public IWorkflowAction<ApiConnectionActionConfiguration> GetGmtDiagnostics(Expression<Func<string>> environmentName, Expression<Func<string>> enterpriseName, Expression<Func<string>> bodygmtSetting, Expression<Func<string>> bodygmtDiagnosticName)
        {
            var __workflow_environmentName = WorkflowExpression.Compile(environmentName, nameof(environmentName), required: true);
            var __workflow_enterpriseName = WorkflowExpression.Compile(enterpriseName, nameof(enterpriseName), required: true);
            var __workflow_bodygmtSetting = WorkflowExpression.Compile(bodygmtSetting, nameof(bodygmtSetting), required: true);
            var __workflow_bodygmtDiagnosticName = WorkflowExpression.Compile(bodygmtDiagnosticName, nameof(bodygmtDiagnosticName), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/gmtDiagnosticsData";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["environmentName"] = ExpressionConverter.Convert(__workflow_environmentName);
                callPayload.Headers["enterpriseName"] = ExpressionConverter.Convert(__workflow_enterpriseName);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["gmtSetting"] = ExpressionConverter.ConvertO(__workflow_bodygmtSetting);
                bodypropCount++;
                body["gmtDiagnosticName"] = ExpressionConverter.ConvertO(__workflow_bodygmtDiagnosticName);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "corptaxsandbox")]
        public IWorkflowAction<ApiConnectionActionConfiguration> ReturnCalculationDetails(Expression<Func<string>> environmentName, Expression<Func<string>> enterpriseName, Expression<Func<string>> bodyreturnName)
        {
            var __workflow_environmentName = WorkflowExpression.Compile(environmentName, nameof(environmentName), required: true);
            var __workflow_enterpriseName = WorkflowExpression.Compile(enterpriseName, nameof(enterpriseName), required: true);
            var __workflow_bodyreturnName = WorkflowExpression.Compile(bodyreturnName, nameof(bodyreturnName), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/ReturnCalculationDetails";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["environmentName"] = ExpressionConverter.Convert(__workflow_environmentName);
                callPayload.Headers["enterpriseName"] = ExpressionConverter.Convert(__workflow_enterpriseName);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["returnName"] = ExpressionConverter.ConvertO(__workflow_bodyreturnName);
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
