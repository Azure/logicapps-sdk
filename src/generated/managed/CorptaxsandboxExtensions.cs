//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Corptaxsandbox
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class CorptaxsandboxActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "corptaxsandbox")]
        public IWorkflowAction CorptaxEntityViews(Expression<Func<string>> environmentName, Expression<Func<string>> enterpriseName, Expression<Func<string>> bodyqualifiedviewName = null)
        {
            var __workflow_environmentName = environmentName == null ? null : WorkflowExpression.Compile(environmentName);
            WorkflowExpression.Validate(__workflow_environmentName, nameof(environmentName), required: true);
            var __workflow_enterpriseName = enterpriseName == null ? null : WorkflowExpression.Compile(enterpriseName);
            WorkflowExpression.Validate(__workflow_enterpriseName, nameof(enterpriseName), required: true);
            var __workflow_bodyqualifiedviewName = bodyqualifiedviewName == null ? null : WorkflowExpression.Compile(bodyqualifiedviewName);
            WorkflowExpression.Validate(__workflow_bodyqualifiedviewName, nameof(bodyqualifiedviewName), required: false);
            return new DeferredWorkflowAction(() =>
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
        public IWorkflowAction DataExchangeLookup(Expression<Func<string>> environmentName, Expression<Func<string>> enterpriseName, Expression<Func<lookupTypeInput>> lookupType, Expression<Func<bool>> bodydetails, Expression<Func<string>> bodylookupName = null)
        {
            var __workflow_environmentName = environmentName == null ? null : WorkflowExpression.Compile(environmentName);
            WorkflowExpression.Validate(__workflow_environmentName, nameof(environmentName), required: true);
            var __workflow_enterpriseName = enterpriseName == null ? null : WorkflowExpression.Compile(enterpriseName);
            WorkflowExpression.Validate(__workflow_enterpriseName, nameof(enterpriseName), required: true);
            var __workflow_lookupType = lookupType == null ? null : WorkflowExpression.Compile(lookupType);
            WorkflowExpression.Validate(__workflow_lookupType, nameof(lookupType), required: true);
            var __workflow_bodydetails = bodydetails == null ? null : WorkflowExpression.Compile(bodydetails);
            WorkflowExpression.Validate(__workflow_bodydetails, nameof(bodydetails), required: true);
            var __workflow_bodylookupName = bodylookupName == null ? null : WorkflowExpression.Compile(bodylookupName);
            WorkflowExpression.Validate(__workflow_bodylookupName, nameof(bodylookupName), required: false);
            return new DeferredWorkflowAction(() =>
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
        public IWorkflowAction EntityList(Expression<Func<string>> environmentName, Expression<Func<string>> enterpriseName, Expression<Func<bool>> bodyactive = null, Expression<Func<string>> bodyperiodName = null, Expression<Func<string>> bodyviewName = null)
        {
            var __workflow_environmentName = environmentName == null ? null : WorkflowExpression.Compile(environmentName);
            WorkflowExpression.Validate(__workflow_environmentName, nameof(environmentName), required: true);
            var __workflow_enterpriseName = enterpriseName == null ? null : WorkflowExpression.Compile(enterpriseName);
            WorkflowExpression.Validate(__workflow_enterpriseName, nameof(enterpriseName), required: true);
            var __workflow_bodyactive = bodyactive == null ? null : WorkflowExpression.Compile(bodyactive);
            WorkflowExpression.Validate(__workflow_bodyactive, nameof(bodyactive), required: false);
            var __workflow_bodyperiodName = bodyperiodName == null ? null : WorkflowExpression.Compile(bodyperiodName);
            WorkflowExpression.Validate(__workflow_bodyperiodName, nameof(bodyperiodName), required: false);
            var __workflow_bodyviewName = bodyviewName == null ? null : WorkflowExpression.Compile(bodyviewName);
            WorkflowExpression.Validate(__workflow_bodyviewName, nameof(bodyviewName), required: false);
            return new DeferredWorkflowAction(() =>
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
        public IWorkflowAction ExportData(Expression<Func<string>> environmentName, Expression<Func<string>> enterpriseName, Expression<Func<string>> bodypackageName, Expression<Func<string>> bodynamedContext = null, Expression<Func<string>> bodyentityCode = null, Expression<Func<string>> bodycaseCode = null, Expression<Func<string>> bodyperiodCode = null, Expression<Func<string>> bodyjurisdictionCode = null, Expression<Func<string>> bodyinternationalTaxName = null, Expression<Func<string>> bodyprovisionName = null)
        {
            var __workflow_environmentName = environmentName == null ? null : WorkflowExpression.Compile(environmentName);
            WorkflowExpression.Validate(__workflow_environmentName, nameof(environmentName), required: true);
            var __workflow_enterpriseName = enterpriseName == null ? null : WorkflowExpression.Compile(enterpriseName);
            WorkflowExpression.Validate(__workflow_enterpriseName, nameof(enterpriseName), required: true);
            var __workflow_bodypackageName = bodypackageName == null ? null : WorkflowExpression.Compile(bodypackageName);
            WorkflowExpression.Validate(__workflow_bodypackageName, nameof(bodypackageName), required: true);
            var __workflow_bodynamedContext = bodynamedContext == null ? null : WorkflowExpression.Compile(bodynamedContext);
            WorkflowExpression.Validate(__workflow_bodynamedContext, nameof(bodynamedContext), required: false);
            var __workflow_bodyentityCode = bodyentityCode == null ? null : WorkflowExpression.Compile(bodyentityCode);
            WorkflowExpression.Validate(__workflow_bodyentityCode, nameof(bodyentityCode), required: false);
            var __workflow_bodycaseCode = bodycaseCode == null ? null : WorkflowExpression.Compile(bodycaseCode);
            WorkflowExpression.Validate(__workflow_bodycaseCode, nameof(bodycaseCode), required: false);
            var __workflow_bodyperiodCode = bodyperiodCode == null ? null : WorkflowExpression.Compile(bodyperiodCode);
            WorkflowExpression.Validate(__workflow_bodyperiodCode, nameof(bodyperiodCode), required: false);
            var __workflow_bodyjurisdictionCode = bodyjurisdictionCode == null ? null : WorkflowExpression.Compile(bodyjurisdictionCode);
            WorkflowExpression.Validate(__workflow_bodyjurisdictionCode, nameof(bodyjurisdictionCode), required: false);
            var __workflow_bodyinternationalTaxName = bodyinternationalTaxName == null ? null : WorkflowExpression.Compile(bodyinternationalTaxName);
            WorkflowExpression.Validate(__workflow_bodyinternationalTaxName, nameof(bodyinternationalTaxName), required: false);
            var __workflow_bodyprovisionName = bodyprovisionName == null ? null : WorkflowExpression.Compile(bodyprovisionName);
            WorkflowExpression.Validate(__workflow_bodyprovisionName, nameof(bodyprovisionName), required: false);
            return new DeferredWorkflowAction(() =>
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
        public IWorkflowAction ExportDataWithDataSource(Expression<Func<string>> environmentName, Expression<Func<string>> enterpriseName, Expression<Func<string>> bodydataSource, Expression<Func<string>> bodynamedContext = null, Expression<Func<string>> bodyentityCode = null, Expression<Func<string>> bodycaseCode = null, Expression<Func<string>> bodyperiodCode = null, Expression<Func<string>> bodyjurisdictionCode = null, Expression<Func<string>> bodyinternationalTaxName = null, Expression<Func<string>> bodyprovisionName = null)
        {
            var __workflow_environmentName = environmentName == null ? null : WorkflowExpression.Compile(environmentName);
            WorkflowExpression.Validate(__workflow_environmentName, nameof(environmentName), required: true);
            var __workflow_enterpriseName = enterpriseName == null ? null : WorkflowExpression.Compile(enterpriseName);
            WorkflowExpression.Validate(__workflow_enterpriseName, nameof(enterpriseName), required: true);
            var __workflow_bodydataSource = bodydataSource == null ? null : WorkflowExpression.Compile(bodydataSource);
            WorkflowExpression.Validate(__workflow_bodydataSource, nameof(bodydataSource), required: true);
            var __workflow_bodynamedContext = bodynamedContext == null ? null : WorkflowExpression.Compile(bodynamedContext);
            WorkflowExpression.Validate(__workflow_bodynamedContext, nameof(bodynamedContext), required: false);
            var __workflow_bodyentityCode = bodyentityCode == null ? null : WorkflowExpression.Compile(bodyentityCode);
            WorkflowExpression.Validate(__workflow_bodyentityCode, nameof(bodyentityCode), required: false);
            var __workflow_bodycaseCode = bodycaseCode == null ? null : WorkflowExpression.Compile(bodycaseCode);
            WorkflowExpression.Validate(__workflow_bodycaseCode, nameof(bodycaseCode), required: false);
            var __workflow_bodyperiodCode = bodyperiodCode == null ? null : WorkflowExpression.Compile(bodyperiodCode);
            WorkflowExpression.Validate(__workflow_bodyperiodCode, nameof(bodyperiodCode), required: false);
            var __workflow_bodyjurisdictionCode = bodyjurisdictionCode == null ? null : WorkflowExpression.Compile(bodyjurisdictionCode);
            WorkflowExpression.Validate(__workflow_bodyjurisdictionCode, nameof(bodyjurisdictionCode), required: false);
            var __workflow_bodyinternationalTaxName = bodyinternationalTaxName == null ? null : WorkflowExpression.Compile(bodyinternationalTaxName);
            WorkflowExpression.Validate(__workflow_bodyinternationalTaxName, nameof(bodyinternationalTaxName), required: false);
            var __workflow_bodyprovisionName = bodyprovisionName == null ? null : WorkflowExpression.Compile(bodyprovisionName);
            WorkflowExpression.Validate(__workflow_bodyprovisionName, nameof(bodyprovisionName), required: false);
            return new DeferredWorkflowAction(() =>
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
        public IBodyWorkflowAction<TriggerCartResponse> TriggerCart(Expression<Func<string>> environmentName, Expression<Func<string>> enterpriseName, Expression<Func<string>> bodycartName, Expression<Func<bodytypeOfActionInput>> bodytypeOfAction, Expression<Func<string>> bodynamedContext = null, Expression<Func<string>> bodyentityCode = null, Expression<Func<string>> bodycaseCode = null, Expression<Func<string>> bodyperiodCode = null, Expression<Func<string>> bodyjurisdictionCode = null, Expression<Func<string>> bodyledgerName = null, Expression<Func<string>> bodyisoCurrencyCode = null)
        {
            var __workflow_environmentName = environmentName == null ? null : WorkflowExpression.Compile(environmentName);
            WorkflowExpression.Validate(__workflow_environmentName, nameof(environmentName), required: true);
            var __workflow_enterpriseName = enterpriseName == null ? null : WorkflowExpression.Compile(enterpriseName);
            WorkflowExpression.Validate(__workflow_enterpriseName, nameof(enterpriseName), required: true);
            var __workflow_bodycartName = bodycartName == null ? null : WorkflowExpression.Compile(bodycartName);
            WorkflowExpression.Validate(__workflow_bodycartName, nameof(bodycartName), required: true);
            var __workflow_bodytypeOfAction = bodytypeOfAction == null ? null : WorkflowExpression.Compile(bodytypeOfAction);
            WorkflowExpression.Validate(__workflow_bodytypeOfAction, nameof(bodytypeOfAction), required: true);
            var __workflow_bodynamedContext = bodynamedContext == null ? null : WorkflowExpression.Compile(bodynamedContext);
            WorkflowExpression.Validate(__workflow_bodynamedContext, nameof(bodynamedContext), required: false);
            var __workflow_bodyentityCode = bodyentityCode == null ? null : WorkflowExpression.Compile(bodyentityCode);
            WorkflowExpression.Validate(__workflow_bodyentityCode, nameof(bodyentityCode), required: false);
            var __workflow_bodycaseCode = bodycaseCode == null ? null : WorkflowExpression.Compile(bodycaseCode);
            WorkflowExpression.Validate(__workflow_bodycaseCode, nameof(bodycaseCode), required: false);
            var __workflow_bodyperiodCode = bodyperiodCode == null ? null : WorkflowExpression.Compile(bodyperiodCode);
            WorkflowExpression.Validate(__workflow_bodyperiodCode, nameof(bodyperiodCode), required: false);
            var __workflow_bodyjurisdictionCode = bodyjurisdictionCode == null ? null : WorkflowExpression.Compile(bodyjurisdictionCode);
            WorkflowExpression.Validate(__workflow_bodyjurisdictionCode, nameof(bodyjurisdictionCode), required: false);
            var __workflow_bodyledgerName = bodyledgerName == null ? null : WorkflowExpression.Compile(bodyledgerName);
            WorkflowExpression.Validate(__workflow_bodyledgerName, nameof(bodyledgerName), required: false);
            var __workflow_bodyisoCurrencyCode = bodyisoCurrencyCode == null ? null : WorkflowExpression.Compile(bodyisoCurrencyCode);
            WorkflowExpression.Validate(__workflow_bodyisoCurrencyCode, nameof(bodyisoCurrencyCode), required: false);
            return new DeferredBodyAction<TriggerCartResponse>(() =>
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
        public IBodyWorkflowAction<TriggerReturnResponse> TriggerReturn(Expression<Func<string>> environmentName, Expression<Func<string>> enterpriseName, Expression<Func<string>> bodyreturnName, Expression<Func<string>> bodytypeOfAction)
        {
            var __workflow_environmentName = environmentName == null ? null : WorkflowExpression.Compile(environmentName);
            WorkflowExpression.Validate(__workflow_environmentName, nameof(environmentName), required: true);
            var __workflow_enterpriseName = enterpriseName == null ? null : WorkflowExpression.Compile(enterpriseName);
            WorkflowExpression.Validate(__workflow_enterpriseName, nameof(enterpriseName), required: true);
            var __workflow_bodyreturnName = bodyreturnName == null ? null : WorkflowExpression.Compile(bodyreturnName);
            WorkflowExpression.Validate(__workflow_bodyreturnName, nameof(bodyreturnName), required: true);
            var __workflow_bodytypeOfAction = bodytypeOfAction == null ? null : WorkflowExpression.Compile(bodytypeOfAction);
            WorkflowExpression.Validate(__workflow_bodytypeOfAction, nameof(bodytypeOfAction), required: true);
            return new DeferredBodyAction<TriggerReturnResponse>(() =>
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
        public IBodyWorkflowAction<DownloadContentsResponseItem[]> DownloadContents(Expression<Func<string>> environmentName, Expression<Func<string>> enterpriseName, Expression<Func<typeOfActionInput>> typeOfAction, Expression<Func<string>> bodyreturnOrCartName)
        {
            var __workflow_environmentName = environmentName == null ? null : WorkflowExpression.Compile(environmentName);
            WorkflowExpression.Validate(__workflow_environmentName, nameof(environmentName), required: true);
            var __workflow_enterpriseName = enterpriseName == null ? null : WorkflowExpression.Compile(enterpriseName);
            WorkflowExpression.Validate(__workflow_enterpriseName, nameof(enterpriseName), required: true);
            var __workflow_typeOfAction = typeOfAction == null ? null : WorkflowExpression.Compile(typeOfAction);
            WorkflowExpression.Validate(__workflow_typeOfAction, nameof(typeOfAction), required: true);
            var __workflow_bodyreturnOrCartName = bodyreturnOrCartName == null ? null : WorkflowExpression.Compile(bodyreturnOrCartName);
            WorkflowExpression.Validate(__workflow_bodyreturnOrCartName, nameof(bodyreturnOrCartName), required: true);
            return new DeferredBodyAction<DownloadContentsResponseItem[]>(() =>
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
        public IBodyWorkflowAction<CheckTriggerStatusResponse> CheckTriggerStatus(Expression<Func<string>> environmentName, Expression<Func<string>> enterpriseName, Expression<Func<typeOfActionInput>> typeOfAction, Expression<Func<string>> bodyreturnOrCartName)
        {
            var __workflow_environmentName = environmentName == null ? null : WorkflowExpression.Compile(environmentName);
            WorkflowExpression.Validate(__workflow_environmentName, nameof(environmentName), required: true);
            var __workflow_enterpriseName = enterpriseName == null ? null : WorkflowExpression.Compile(enterpriseName);
            WorkflowExpression.Validate(__workflow_enterpriseName, nameof(enterpriseName), required: true);
            var __workflow_typeOfAction = typeOfAction == null ? null : WorkflowExpression.Compile(typeOfAction);
            WorkflowExpression.Validate(__workflow_typeOfAction, nameof(typeOfAction), required: true);
            var __workflow_bodyreturnOrCartName = bodyreturnOrCartName == null ? null : WorkflowExpression.Compile(bodyreturnOrCartName);
            WorkflowExpression.Validate(__workflow_bodyreturnOrCartName, nameof(bodyreturnOrCartName), required: true);
            return new DeferredBodyAction<CheckTriggerStatusResponse>(() =>
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
        public IBodyWorkflowAction<ImportDataResponse> ImportData(Expression<Func<string>> environmentName, Expression<Func<string>> enterpriseName, Expression<Func<string>> bodypackageName, Expression<Func<string>> bodyfileContents, Expression<Func<string>> bodyfileName, Expression<Func<bodyimportTransactionTypeInput>> bodyimportTransactionType, Expression<Func<string>> bodychartOfAccountsName, Expression<Func<bool>> bodyrecognizeFunctionalCurrency, Expression<Func<bool>> bodystopOnLookupErrors, Expression<Func<string>> bodyentityCode = null, Expression<Func<string>> bodycaseCode = null, Expression<Func<string>> bodyperiodCode = null, Expression<Func<string>> bodyjurisdictionCode = null, Expression<Func<bodyledgerAmountTypeInput>> bodyledgerAmountType = null, Expression<Func<string>> bodyfunctionalCurrencyValue = null)
        {
            var __workflow_environmentName = environmentName == null ? null : WorkflowExpression.Compile(environmentName);
            WorkflowExpression.Validate(__workflow_environmentName, nameof(environmentName), required: true);
            var __workflow_enterpriseName = enterpriseName == null ? null : WorkflowExpression.Compile(enterpriseName);
            WorkflowExpression.Validate(__workflow_enterpriseName, nameof(enterpriseName), required: true);
            var __workflow_bodypackageName = bodypackageName == null ? null : WorkflowExpression.Compile(bodypackageName);
            WorkflowExpression.Validate(__workflow_bodypackageName, nameof(bodypackageName), required: true);
            var __workflow_bodyfileContents = bodyfileContents == null ? null : WorkflowExpression.Compile(bodyfileContents);
            WorkflowExpression.Validate(__workflow_bodyfileContents, nameof(bodyfileContents), required: true);
            var __workflow_bodyfileName = bodyfileName == null ? null : WorkflowExpression.Compile(bodyfileName);
            WorkflowExpression.Validate(__workflow_bodyfileName, nameof(bodyfileName), required: true);
            var __workflow_bodyimportTransactionType = bodyimportTransactionType == null ? null : WorkflowExpression.Compile(bodyimportTransactionType);
            WorkflowExpression.Validate(__workflow_bodyimportTransactionType, nameof(bodyimportTransactionType), required: true);
            var __workflow_bodychartOfAccountsName = bodychartOfAccountsName == null ? null : WorkflowExpression.Compile(bodychartOfAccountsName);
            WorkflowExpression.Validate(__workflow_bodychartOfAccountsName, nameof(bodychartOfAccountsName), required: true);
            var __workflow_bodyrecognizeFunctionalCurrency = bodyrecognizeFunctionalCurrency == null ? null : WorkflowExpression.Compile(bodyrecognizeFunctionalCurrency);
            WorkflowExpression.Validate(__workflow_bodyrecognizeFunctionalCurrency, nameof(bodyrecognizeFunctionalCurrency), required: true);
            var __workflow_bodystopOnLookupErrors = bodystopOnLookupErrors == null ? null : WorkflowExpression.Compile(bodystopOnLookupErrors);
            WorkflowExpression.Validate(__workflow_bodystopOnLookupErrors, nameof(bodystopOnLookupErrors), required: true);
            var __workflow_bodyentityCode = bodyentityCode == null ? null : WorkflowExpression.Compile(bodyentityCode);
            WorkflowExpression.Validate(__workflow_bodyentityCode, nameof(bodyentityCode), required: false);
            var __workflow_bodycaseCode = bodycaseCode == null ? null : WorkflowExpression.Compile(bodycaseCode);
            WorkflowExpression.Validate(__workflow_bodycaseCode, nameof(bodycaseCode), required: false);
            var __workflow_bodyperiodCode = bodyperiodCode == null ? null : WorkflowExpression.Compile(bodyperiodCode);
            WorkflowExpression.Validate(__workflow_bodyperiodCode, nameof(bodyperiodCode), required: false);
            var __workflow_bodyjurisdictionCode = bodyjurisdictionCode == null ? null : WorkflowExpression.Compile(bodyjurisdictionCode);
            WorkflowExpression.Validate(__workflow_bodyjurisdictionCode, nameof(bodyjurisdictionCode), required: false);
            var __workflow_bodyledgerAmountType = bodyledgerAmountType == null ? null : WorkflowExpression.Compile(bodyledgerAmountType);
            WorkflowExpression.Validate(__workflow_bodyledgerAmountType, nameof(bodyledgerAmountType), required: false);
            var __workflow_bodyfunctionalCurrencyValue = bodyfunctionalCurrencyValue == null ? null : WorkflowExpression.Compile(bodyfunctionalCurrencyValue);
            WorkflowExpression.Validate(__workflow_bodyfunctionalCurrencyValue, nameof(bodyfunctionalCurrencyValue), required: false);
            return new DeferredBodyAction<ImportDataResponse>(() =>
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
        public IWorkflowAction CorptaxEfileGroups(Expression<Func<string>> environmentName, Expression<Func<string>> enterpriseName, Expression<Func<string>> filingGroup = null)
        {
            var __workflow_environmentName = environmentName == null ? null : WorkflowExpression.Compile(environmentName);
            WorkflowExpression.Validate(__workflow_environmentName, nameof(environmentName), required: true);
            var __workflow_enterpriseName = enterpriseName == null ? null : WorkflowExpression.Compile(enterpriseName);
            WorkflowExpression.Validate(__workflow_enterpriseName, nameof(enterpriseName), required: true);
            var __workflow_filingGroup = filingGroup == null ? null : WorkflowExpression.Compile(filingGroup);
            WorkflowExpression.Validate(__workflow_filingGroup, nameof(filingGroup), required: false);
            return new DeferredWorkflowAction(() =>
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
        public IWorkflowAction CorptaxEfilePackage(Expression<Func<string>> environmentName, Expression<Func<string>> enterpriseName, Expression<Func<string>> filingGroup, Expression<Func<bool>> bodyefilePackageDetails, Expression<Func<string>> bodyentityCode = null, Expression<Func<string>> bodyform = null)
        {
            var __workflow_environmentName = environmentName == null ? null : WorkflowExpression.Compile(environmentName);
            WorkflowExpression.Validate(__workflow_environmentName, nameof(environmentName), required: true);
            var __workflow_enterpriseName = enterpriseName == null ? null : WorkflowExpression.Compile(enterpriseName);
            WorkflowExpression.Validate(__workflow_enterpriseName, nameof(enterpriseName), required: true);
            var __workflow_filingGroup = filingGroup == null ? null : WorkflowExpression.Compile(filingGroup);
            WorkflowExpression.Validate(__workflow_filingGroup, nameof(filingGroup), required: true);
            var __workflow_bodyefilePackageDetails = bodyefilePackageDetails == null ? null : WorkflowExpression.Compile(bodyefilePackageDetails);
            WorkflowExpression.Validate(__workflow_bodyefilePackageDetails, nameof(bodyefilePackageDetails), required: true);
            var __workflow_bodyentityCode = bodyentityCode == null ? null : WorkflowExpression.Compile(bodyentityCode);
            WorkflowExpression.Validate(__workflow_bodyentityCode, nameof(bodyentityCode), required: false);
            var __workflow_bodyform = bodyform == null ? null : WorkflowExpression.Compile(bodyform);
            WorkflowExpression.Validate(__workflow_bodyform, nameof(bodyform), required: false);
            return new DeferredWorkflowAction(() =>
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
        public IBodyWorkflowAction<GetJobHistoryResponse> GetJobHistory(Expression<Func<string>> environmentName, Expression<Func<string>> bodyjobToken, Expression<Func<bodyreportInput>> bodyreport = null, Expression<Func<bodyreportFormatInput>> bodyreportFormat = null)
        {
            var __workflow_environmentName = environmentName == null ? null : WorkflowExpression.Compile(environmentName);
            WorkflowExpression.Validate(__workflow_environmentName, nameof(environmentName), required: true);
            var __workflow_bodyjobToken = bodyjobToken == null ? null : WorkflowExpression.Compile(bodyjobToken);
            WorkflowExpression.Validate(__workflow_bodyjobToken, nameof(bodyjobToken), required: true);
            var __workflow_bodyreport = bodyreport == null ? null : WorkflowExpression.Compile(bodyreport);
            WorkflowExpression.Validate(__workflow_bodyreport, nameof(bodyreport), required: false);
            var __workflow_bodyreportFormat = bodyreportFormat == null ? null : WorkflowExpression.Compile(bodyreportFormat);
            WorkflowExpression.Validate(__workflow_bodyreportFormat, nameof(bodyreportFormat), required: false);
            return new DeferredBodyAction<GetJobHistoryResponse>(() =>
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
        public IWorkflowAction GetGmtDiagnostics(Expression<Func<string>> environmentName, Expression<Func<string>> enterpriseName, Expression<Func<string>> bodygmtSetting, Expression<Func<string>> bodygmtDiagnosticName)
        {
            var __workflow_environmentName = environmentName == null ? null : WorkflowExpression.Compile(environmentName);
            WorkflowExpression.Validate(__workflow_environmentName, nameof(environmentName), required: true);
            var __workflow_enterpriseName = enterpriseName == null ? null : WorkflowExpression.Compile(enterpriseName);
            WorkflowExpression.Validate(__workflow_enterpriseName, nameof(enterpriseName), required: true);
            var __workflow_bodygmtSetting = bodygmtSetting == null ? null : WorkflowExpression.Compile(bodygmtSetting);
            WorkflowExpression.Validate(__workflow_bodygmtSetting, nameof(bodygmtSetting), required: true);
            var __workflow_bodygmtDiagnosticName = bodygmtDiagnosticName == null ? null : WorkflowExpression.Compile(bodygmtDiagnosticName);
            WorkflowExpression.Validate(__workflow_bodygmtDiagnosticName, nameof(bodygmtDiagnosticName), required: true);
            return new DeferredWorkflowAction(() =>
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
        public IWorkflowAction ReturnCalculationDetails(Expression<Func<string>> environmentName, Expression<Func<string>> enterpriseName, Expression<Func<string>> bodyreturnName)
        {
            var __workflow_environmentName = environmentName == null ? null : WorkflowExpression.Compile(environmentName);
            WorkflowExpression.Validate(__workflow_environmentName, nameof(environmentName), required: true);
            var __workflow_enterpriseName = enterpriseName == null ? null : WorkflowExpression.Compile(enterpriseName);
            WorkflowExpression.Validate(__workflow_enterpriseName, nameof(enterpriseName), required: true);
            var __workflow_bodyreturnName = bodyreturnName == null ? null : WorkflowExpression.Compile(bodyreturnName);
            WorkflowExpression.Validate(__workflow_bodyreturnName, nameof(bodyreturnName), required: true);
            return new DeferredWorkflowAction(() =>
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
