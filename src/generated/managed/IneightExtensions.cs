//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Ineight
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class IneightActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ineight")]
        public IBodyWorkflowAction<DailyPlanGetResponseItem[], ApiConnectionActionConfiguration> DailyPlanGet(Expression<Func<string>> xIN8TENANTPREFIX, Expression<Func<string>> ocpApimSubscriptionKey, Expression<Func<string>> jobCode = null)
        {
            var __workflow_xIN8TENANTPREFIX = WorkflowExpression.Compile(xIN8TENANTPREFIX, nameof(xIN8TENANTPREFIX), required: true);
            var __workflow_ocpApimSubscriptionKey = WorkflowExpression.Compile(ocpApimSubscriptionKey, nameof(ocpApimSubscriptionKey), required: true);
            var __workflow_jobCode = WorkflowExpression.Compile(jobCode, nameof(jobCode), required: false);
            return new DeferredBodyAction<DailyPlanGetResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/DailyPlan";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_jobCode != null)
                    callPayload.Queries["JobCode"] = ExpressionConverter.Convert(__workflow_jobCode);
                callPayload.Headers["X-IN8-TENANT-PREFIX"] = ExpressionConverter.Convert(__workflow_xIN8TENANTPREFIX);
                callPayload.Headers["Ocp-Apim-Subscription-Key"] = ExpressionConverter.Convert(__workflow_ocpApimSubscriptionKey);
                return new ApiConnectionAction<DailyPlanGetResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ineight")]
        public IBodyWorkflowAction<TimeCardGetResponseItem[], ApiConnectionActionConfiguration> TimeCardGet(Expression<Func<string>> xIN8TENANTPREFIX, Expression<Func<string>> ocpApimSubscriptionKey)
        {
            var __workflow_xIN8TENANTPREFIX = WorkflowExpression.Compile(xIN8TENANTPREFIX, nameof(xIN8TENANTPREFIX), required: true);
            var __workflow_ocpApimSubscriptionKey = WorkflowExpression.Compile(ocpApimSubscriptionKey, nameof(ocpApimSubscriptionKey), required: true);
            return new DeferredBodyAction<TimeCardGetResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/TimeCard";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["X-IN8-TENANT-PREFIX"] = ExpressionConverter.Convert(__workflow_xIN8TENANTPREFIX);
                callPayload.Headers["Ocp-Apim-Subscription-Key"] = ExpressionConverter.Convert(__workflow_ocpApimSubscriptionKey);
                return new ApiConnectionAction<TimeCardGetResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ineight")]
        public IBodyWorkflowAction<JToken[], ApiConnectionActionConfiguration> TimeCardConfirmationImport(Expression<Func<string>> xIN8TENANTPREFIX, Expression<Func<string>> ocpApimSubscriptionKey, Expression<Func<bodyInputItem[]>> body = null)
        {
            var __workflow_xIN8TENANTPREFIX = WorkflowExpression.Compile(xIN8TENANTPREFIX, nameof(xIN8TENANTPREFIX), required: true);
            var __workflow_ocpApimSubscriptionKey = WorkflowExpression.Compile(ocpApimSubscriptionKey, nameof(ocpApimSubscriptionKey), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<JToken[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/TimeCardConfirmation";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["X-IN8-TENANT-PREFIX"] = ExpressionConverter.Convert(__workflow_xIN8TENANTPREFIX);
                callPayload.Headers["Ocp-Apim-Subscription-Key"] = ExpressionConverter.Convert(__workflow_ocpApimSubscriptionKey);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<JToken[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ineight")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> CraftsImport(Expression<Func<string>> xIN8TENANTPREFIX, Expression<Func<string>> ocpApimSubscriptionKey, Expression<Func<bodyInputItem2[]>> body)
        {
            var __workflow_xIN8TENANTPREFIX = WorkflowExpression.Compile(xIN8TENANTPREFIX, nameof(xIN8TENANTPREFIX), required: true);
            var __workflow_ocpApimSubscriptionKey = WorkflowExpression.Compile(ocpApimSubscriptionKey, nameof(ocpApimSubscriptionKey), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Crafts/Import";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["X-IN8-TENANT-PREFIX"] = ExpressionConverter.Convert(__workflow_xIN8TENANTPREFIX);
                callPayload.Headers["Ocp-Apim-Subscription-Key"] = ExpressionConverter.Convert(__workflow_ocpApimSubscriptionKey);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ineight")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> DailyPlanStatusImport(Expression<Func<string>> xIN8TENANTPREFIX, Expression<Func<string>> ocpApimSubscriptionKey, Expression<Func<bodyInputItem22[]>> body = null)
        {
            var __workflow_xIN8TENANTPREFIX = WorkflowExpression.Compile(xIN8TENANTPREFIX, nameof(xIN8TENANTPREFIX), required: true);
            var __workflow_ocpApimSubscriptionKey = WorkflowExpression.Compile(ocpApimSubscriptionKey, nameof(ocpApimSubscriptionKey), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/DailyPlanStatus/Import";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["X-IN8-TENANT-PREFIX"] = ExpressionConverter.Convert(__workflow_xIN8TENANTPREFIX);
                callPayload.Headers["Ocp-Apim-Subscription-Key"] = ExpressionConverter.Convert(__workflow_ocpApimSubscriptionKey);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ineight")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> EmployeesImport(Expression<Func<string>> xIN8TENANTPREFIX, Expression<Func<string>> ocpApimSubscriptionKey, Expression<Func<bodyInputItem222[]>> body)
        {
            var __workflow_xIN8TENANTPREFIX = WorkflowExpression.Compile(xIN8TENANTPREFIX, nameof(xIN8TENANTPREFIX), required: true);
            var __workflow_ocpApimSubscriptionKey = WorkflowExpression.Compile(ocpApimSubscriptionKey, nameof(ocpApimSubscriptionKey), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Employees/Import";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["X-IN8-TENANT-PREFIX"] = ExpressionConverter.Convert(__workflow_xIN8TENANTPREFIX);
                callPayload.Headers["Ocp-Apim-Subscription-Key"] = ExpressionConverter.Convert(__workflow_ocpApimSubscriptionKey);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ineight")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> EquipmentsImport(Expression<Func<string>> xIN8TENANTPREFIX, Expression<Func<string>> ocpApimSubscriptionKey, Expression<Func<bodyInputItem2222[]>> body)
        {
            var __workflow_xIN8TENANTPREFIX = WorkflowExpression.Compile(xIN8TENANTPREFIX, nameof(xIN8TENANTPREFIX), required: true);
            var __workflow_ocpApimSubscriptionKey = WorkflowExpression.Compile(ocpApimSubscriptionKey, nameof(ocpApimSubscriptionKey), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Equipments/Import";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["X-IN8-TENANT-PREFIX"] = ExpressionConverter.Convert(__workflow_xIN8TENANTPREFIX);
                callPayload.Headers["Ocp-Apim-Subscription-Key"] = ExpressionConverter.Convert(__workflow_ocpApimSubscriptionKey);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ineight")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> EquipmentCategoriesImport(Expression<Func<string>> xIN8TENANTPREFIX, Expression<Func<string>> ocpApimSubscriptionKey, Expression<Func<bodyInputItem22222[]>> body)
        {
            var __workflow_xIN8TENANTPREFIX = WorkflowExpression.Compile(xIN8TENANTPREFIX, nameof(xIN8TENANTPREFIX), required: true);
            var __workflow_ocpApimSubscriptionKey = WorkflowExpression.Compile(ocpApimSubscriptionKey, nameof(ocpApimSubscriptionKey), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/EquipmentCategories/Import";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["X-IN8-TENANT-PREFIX"] = ExpressionConverter.Convert(__workflow_xIN8TENANTPREFIX);
                callPayload.Headers["Ocp-Apim-Subscription-Key"] = ExpressionConverter.Convert(__workflow_ocpApimSubscriptionKey);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ineight")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> EquipmentTypesImport(Expression<Func<string>> xIN8TENANTPREFIX, Expression<Func<string>> ocpApimSubscriptionKey, Expression<Func<bodyInputItem222222[]>> body)
        {
            var __workflow_xIN8TENANTPREFIX = WorkflowExpression.Compile(xIN8TENANTPREFIX, nameof(xIN8TENANTPREFIX), required: true);
            var __workflow_ocpApimSubscriptionKey = WorkflowExpression.Compile(ocpApimSubscriptionKey, nameof(ocpApimSubscriptionKey), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/EquipmentTypes/Import";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["X-IN8-TENANT-PREFIX"] = ExpressionConverter.Convert(__workflow_xIN8TENANTPREFIX);
                callPayload.Headers["Ocp-Apim-Subscription-Key"] = ExpressionConverter.Convert(__workflow_ocpApimSubscriptionKey);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ineight")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> RolesImport(Expression<Func<string>> xIN8TENANTPREFIX, Expression<Func<string>> ocpApimSubscriptionKey, Expression<Func<bodyInputItem2222222[]>> body)
        {
            var __workflow_xIN8TENANTPREFIX = WorkflowExpression.Compile(xIN8TENANTPREFIX, nameof(xIN8TENANTPREFIX), required: true);
            var __workflow_ocpApimSubscriptionKey = WorkflowExpression.Compile(ocpApimSubscriptionKey, nameof(ocpApimSubscriptionKey), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Roles/Import";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["X-IN8-TENANT-PREFIX"] = ExpressionConverter.Convert(__workflow_xIN8TENANTPREFIX);
                callPayload.Headers["Ocp-Apim-Subscription-Key"] = ExpressionConverter.Convert(__workflow_ocpApimSubscriptionKey);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ineight")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> TradesImport(Expression<Func<string>> xIN8TENANTPREFIX, Expression<Func<string>> ocpApimSubscriptionKey, Expression<Func<bodyInputItem22222222[]>> body)
        {
            var __workflow_xIN8TENANTPREFIX = WorkflowExpression.Compile(xIN8TENANTPREFIX, nameof(xIN8TENANTPREFIX), required: true);
            var __workflow_ocpApimSubscriptionKey = WorkflowExpression.Compile(ocpApimSubscriptionKey, nameof(ocpApimSubscriptionKey), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Trades/Import";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["X-IN8-TENANT-PREFIX"] = ExpressionConverter.Convert(__workflow_xIN8TENANTPREFIX);
                callPayload.Headers["Ocp-Apim-Subscription-Key"] = ExpressionConverter.Convert(__workflow_ocpApimSubscriptionKey);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ineight")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> UsersImport(Expression<Func<string>> xIN8TENANTPREFIX, Expression<Func<string>> ocpApimSubscriptionKey, Expression<Func<bodyInputItem222222222[]>> body)
        {
            var __workflow_xIN8TENANTPREFIX = WorkflowExpression.Compile(xIN8TENANTPREFIX, nameof(xIN8TENANTPREFIX), required: true);
            var __workflow_ocpApimSubscriptionKey = WorkflowExpression.Compile(ocpApimSubscriptionKey, nameof(ocpApimSubscriptionKey), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Users/Import";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["X-IN8-TENANT-PREFIX"] = ExpressionConverter.Convert(__workflow_xIN8TENANTPREFIX);
                callPayload.Headers["Ocp-Apim-Subscription-Key"] = ExpressionConverter.Convert(__workflow_ocpApimSubscriptionKey);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ineight")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> UserRolesImport(Expression<Func<string>> xIN8TENANTPREFIX, Expression<Func<string>> ocpApimSubscriptionKey, Expression<Func<bodyInputItem2222222222[]>> body)
        {
            var __workflow_xIN8TENANTPREFIX = WorkflowExpression.Compile(xIN8TENANTPREFIX, nameof(xIN8TENANTPREFIX), required: true);
            var __workflow_ocpApimSubscriptionKey = WorkflowExpression.Compile(ocpApimSubscriptionKey, nameof(ocpApimSubscriptionKey), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UserRoles/Import";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["X-IN8-TENANT-PREFIX"] = ExpressionConverter.Convert(__workflow_xIN8TENANTPREFIX);
                callPayload.Headers["Ocp-Apim-Subscription-Key"] = ExpressionConverter.Convert(__workflow_ocpApimSubscriptionKey);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ineight")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> ContactsImport(Expression<Func<string>> xIN8TENANTPREFIX, Expression<Func<string>> ocpApimSubscriptionKey, Expression<Func<bodyInputItem22222222222[]>> body)
        {
            var __workflow_xIN8TENANTPREFIX = WorkflowExpression.Compile(xIN8TENANTPREFIX, nameof(xIN8TENANTPREFIX), required: true);
            var __workflow_ocpApimSubscriptionKey = WorkflowExpression.Compile(ocpApimSubscriptionKey, nameof(ocpApimSubscriptionKey), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Contacts/Import";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["X-IN8-TENANT-PREFIX"] = ExpressionConverter.Convert(__workflow_xIN8TENANTPREFIX);
                callPayload.Headers["Ocp-Apim-Subscription-Key"] = ExpressionConverter.Convert(__workflow_ocpApimSubscriptionKey);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ineight")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> CostCenterImport(Expression<Func<string>> xIN8TENANTPREFIX, Expression<Func<string>> ocpApimSubscriptionKey, Expression<Func<bodyInputItem222222222222[]>> body)
        {
            var __workflow_xIN8TENANTPREFIX = WorkflowExpression.Compile(xIN8TENANTPREFIX, nameof(xIN8TENANTPREFIX), required: true);
            var __workflow_ocpApimSubscriptionKey = WorkflowExpression.Compile(ocpApimSubscriptionKey, nameof(ocpApimSubscriptionKey), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/CostCenters/Import";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["X-IN8-TENANT-PREFIX"] = ExpressionConverter.Convert(__workflow_xIN8TENANTPREFIX);
                callPayload.Headers["Ocp-Apim-Subscription-Key"] = ExpressionConverter.Convert(__workflow_ocpApimSubscriptionKey);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ineight")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> AccountCodeImport(Expression<Func<string>> xIN8TENANTPREFIX, Expression<Func<string>> ocpApimSubscriptionKey, Expression<Func<bodyInputItem2222222222222[]>> body)
        {
            var __workflow_xIN8TENANTPREFIX = WorkflowExpression.Compile(xIN8TENANTPREFIX, nameof(xIN8TENANTPREFIX), required: true);
            var __workflow_ocpApimSubscriptionKey = WorkflowExpression.Compile(ocpApimSubscriptionKey, nameof(ocpApimSubscriptionKey), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/AccountCodes/Import";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["X-IN8-TENANT-PREFIX"] = ExpressionConverter.Convert(__workflow_xIN8TENANTPREFIX);
                callPayload.Headers["Ocp-Apim-Subscription-Key"] = ExpressionConverter.Convert(__workflow_ocpApimSubscriptionKey);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ineight")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> AccountingLedgerImport(Expression<Func<string>> xIN8TENANTPREFIX, Expression<Func<string>> ocpApimSubscriptionKey, Expression<Func<bodyInputItem22222222222222[]>> body)
        {
            var __workflow_xIN8TENANTPREFIX = WorkflowExpression.Compile(xIN8TENANTPREFIX, nameof(xIN8TENANTPREFIX), required: true);
            var __workflow_ocpApimSubscriptionKey = WorkflowExpression.Compile(ocpApimSubscriptionKey, nameof(ocpApimSubscriptionKey), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/AccountingLedger/Import";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["X-IN8-TENANT-PREFIX"] = ExpressionConverter.Convert(__workflow_xIN8TENANTPREFIX);
                callPayload.Headers["Ocp-Apim-Subscription-Key"] = ExpressionConverter.Convert(__workflow_ocpApimSubscriptionKey);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ineight")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> UsersDelete(Expression<Func<string>> xIN8TENANTPREFIX, Expression<Func<string>> ocpApimSubscriptionKey, Expression<Func<bodyInputItem222222222222222[]>> body)
        {
            var __workflow_xIN8TENANTPREFIX = WorkflowExpression.Compile(xIN8TENANTPREFIX, nameof(xIN8TENANTPREFIX), required: true);
            var __workflow_ocpApimSubscriptionKey = WorkflowExpression.Compile(ocpApimSubscriptionKey, nameof(ocpApimSubscriptionKey), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Users/Delete";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["X-IN8-TENANT-PREFIX"] = ExpressionConverter.Convert(__workflow_xIN8TENANTPREFIX);
                callPayload.Headers["Ocp-Apim-Subscription-Key"] = ExpressionConverter.Convert(__workflow_ocpApimSubscriptionKey);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ineight")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> IncoTermsImport(Expression<Func<string>> xIN8TENANTPREFIX, Expression<Func<string>> ocpApimSubscriptionKey, Expression<Func<bodyInputItem2222222222222222[]>> body)
        {
            var __workflow_xIN8TENANTPREFIX = WorkflowExpression.Compile(xIN8TENANTPREFIX, nameof(xIN8TENANTPREFIX), required: true);
            var __workflow_ocpApimSubscriptionKey = WorkflowExpression.Compile(ocpApimSubscriptionKey, nameof(ocpApimSubscriptionKey), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/IncoTerm/Import";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["X-IN8-TENANT-PREFIX"] = ExpressionConverter.Convert(__workflow_xIN8TENANTPREFIX);
                callPayload.Headers["Ocp-Apim-Subscription-Key"] = ExpressionConverter.Convert(__workflow_ocpApimSubscriptionKey);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ineight")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> MarketsImport(Expression<Func<string>> xIN8TENANTPREFIX, Expression<Func<string>> ocpApimSubscriptionKey, Expression<Func<bodyInputItem22222222222222222[]>> body)
        {
            var __workflow_xIN8TENANTPREFIX = WorkflowExpression.Compile(xIN8TENANTPREFIX, nameof(xIN8TENANTPREFIX), required: true);
            var __workflow_ocpApimSubscriptionKey = WorkflowExpression.Compile(ocpApimSubscriptionKey, nameof(ocpApimSubscriptionKey), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Markets/Import";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["X-IN8-TENANT-PREFIX"] = ExpressionConverter.Convert(__workflow_xIN8TENANTPREFIX);
                callPayload.Headers["Ocp-Apim-Subscription-Key"] = ExpressionConverter.Convert(__workflow_ocpApimSubscriptionKey);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ineight")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> MaterialCharacteristicTypeImport(Expression<Func<string>> xIN8TENANTPREFIX, Expression<Func<string>> ocpApimSubscriptionKey, Expression<Func<bodyInputItem222222222222222222[]>> body)
        {
            var __workflow_xIN8TENANTPREFIX = WorkflowExpression.Compile(xIN8TENANTPREFIX, nameof(xIN8TENANTPREFIX), required: true);
            var __workflow_ocpApimSubscriptionKey = WorkflowExpression.Compile(ocpApimSubscriptionKey, nameof(ocpApimSubscriptionKey), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MaterialCharacteristicType/Import";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["X-IN8-TENANT-PREFIX"] = ExpressionConverter.Convert(__workflow_xIN8TENANTPREFIX);
                callPayload.Headers["Ocp-Apim-Subscription-Key"] = ExpressionConverter.Convert(__workflow_ocpApimSubscriptionKey);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ineight")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> MaterialClassImport(Expression<Func<string>> xIN8TENANTPREFIX, Expression<Func<string>> ocpApimSubscriptionKey, Expression<Func<bodyInputItem2222222222222222222[]>> body)
        {
            var __workflow_xIN8TENANTPREFIX = WorkflowExpression.Compile(xIN8TENANTPREFIX, nameof(xIN8TENANTPREFIX), required: true);
            var __workflow_ocpApimSubscriptionKey = WorkflowExpression.Compile(ocpApimSubscriptionKey, nameof(ocpApimSubscriptionKey), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MaterialClass/Import";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["X-IN8-TENANT-PREFIX"] = ExpressionConverter.Convert(__workflow_xIN8TENANTPREFIX);
                callPayload.Headers["Ocp-Apim-Subscription-Key"] = ExpressionConverter.Convert(__workflow_ocpApimSubscriptionKey);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ineight")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> MaterialGroupImport(Expression<Func<string>> xIN8TENANTPREFIX, Expression<Func<string>> ocpApimSubscriptionKey, Expression<Func<bodyInputItem22222222222222222222[]>> body)
        {
            var __workflow_xIN8TENANTPREFIX = WorkflowExpression.Compile(xIN8TENANTPREFIX, nameof(xIN8TENANTPREFIX), required: true);
            var __workflow_ocpApimSubscriptionKey = WorkflowExpression.Compile(ocpApimSubscriptionKey, nameof(ocpApimSubscriptionKey), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MaterialGroup/Import";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["X-IN8-TENANT-PREFIX"] = ExpressionConverter.Convert(__workflow_xIN8TENANTPREFIX);
                callPayload.Headers["Ocp-Apim-Subscription-Key"] = ExpressionConverter.Convert(__workflow_ocpApimSubscriptionKey);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ineight")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> MaterialImport(Expression<Func<string>> xIN8TENANTPREFIX, Expression<Func<string>> ocpApimSubscriptionKey, Expression<Func<bodyInputItem222222222222222222222[]>> body)
        {
            var __workflow_xIN8TENANTPREFIX = WorkflowExpression.Compile(xIN8TENANTPREFIX, nameof(xIN8TENANTPREFIX), required: true);
            var __workflow_ocpApimSubscriptionKey = WorkflowExpression.Compile(ocpApimSubscriptionKey, nameof(ocpApimSubscriptionKey), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Material/Import";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["X-IN8-TENANT-PREFIX"] = ExpressionConverter.Convert(__workflow_xIN8TENANTPREFIX);
                callPayload.Headers["Ocp-Apim-Subscription-Key"] = ExpressionConverter.Convert(__workflow_ocpApimSubscriptionKey);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ineight")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> MaterialSetImport(Expression<Func<string>> xIN8TENANTPREFIX, Expression<Func<string>> ocpApimSubscriptionKey, Expression<Func<bodyInputItem2222222222222222222222[]>> body)
        {
            var __workflow_xIN8TENANTPREFIX = WorkflowExpression.Compile(xIN8TENANTPREFIX, nameof(xIN8TENANTPREFIX), required: true);
            var __workflow_ocpApimSubscriptionKey = WorkflowExpression.Compile(ocpApimSubscriptionKey, nameof(ocpApimSubscriptionKey), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MaterialSet/Import";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["X-IN8-TENANT-PREFIX"] = ExpressionConverter.Convert(__workflow_xIN8TENANTPREFIX);
                callPayload.Headers["Ocp-Apim-Subscription-Key"] = ExpressionConverter.Convert(__workflow_ocpApimSubscriptionKey);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ineight")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> OrganizationsImport(Expression<Func<string>> xIN8TENANTPREFIX, Expression<Func<string>> ocpApimSubscriptionKey, Expression<Func<bodyInputItem22222222222222222222222[]>> body)
        {
            var __workflow_xIN8TENANTPREFIX = WorkflowExpression.Compile(xIN8TENANTPREFIX, nameof(xIN8TENANTPREFIX), required: true);
            var __workflow_ocpApimSubscriptionKey = WorkflowExpression.Compile(ocpApimSubscriptionKey, nameof(ocpApimSubscriptionKey), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Organizations/Import";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["X-IN8-TENANT-PREFIX"] = ExpressionConverter.Convert(__workflow_xIN8TENANTPREFIX);
                callPayload.Headers["Ocp-Apim-Subscription-Key"] = ExpressionConverter.Convert(__workflow_ocpApimSubscriptionKey);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ineight")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> PaymentTermImport(Expression<Func<string>> xIN8TENANTPREFIX, Expression<Func<string>> ocpApimSubscriptionKey, Expression<Func<bodyInputItem222222222222222222222222[]>> body)
        {
            var __workflow_xIN8TENANTPREFIX = WorkflowExpression.Compile(xIN8TENANTPREFIX, nameof(xIN8TENANTPREFIX), required: true);
            var __workflow_ocpApimSubscriptionKey = WorkflowExpression.Compile(ocpApimSubscriptionKey, nameof(ocpApimSubscriptionKey), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PaymentTerm/Import";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["X-IN8-TENANT-PREFIX"] = ExpressionConverter.Convert(__workflow_xIN8TENANTPREFIX);
                callPayload.Headers["Ocp-Apim-Subscription-Key"] = ExpressionConverter.Convert(__workflow_ocpApimSubscriptionKey);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ineight")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> ProjectContactsImport(Expression<Func<string>> xIN8TENANTPREFIX, Expression<Func<string>> ocpApimSubscriptionKey, Expression<Func<bodyInputItem2222222222222222222222222[]>> body)
        {
            var __workflow_xIN8TENANTPREFIX = WorkflowExpression.Compile(xIN8TENANTPREFIX, nameof(xIN8TENANTPREFIX), required: true);
            var __workflow_ocpApimSubscriptionKey = WorkflowExpression.Compile(ocpApimSubscriptionKey, nameof(ocpApimSubscriptionKey), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/ProjectContacts/Import";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["X-IN8-TENANT-PREFIX"] = ExpressionConverter.Convert(__workflow_xIN8TENANTPREFIX);
                callPayload.Headers["Ocp-Apim-Subscription-Key"] = ExpressionConverter.Convert(__workflow_ocpApimSubscriptionKey);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ineight")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> ProjectCraftImport(Expression<Func<string>> xIN8TENANTPREFIX, Expression<Func<string>> ocpApimSubscriptionKey, Expression<Func<bodyInputItem22222222222222222222222222[]>> body)
        {
            var __workflow_xIN8TENANTPREFIX = WorkflowExpression.Compile(xIN8TENANTPREFIX, nameof(xIN8TENANTPREFIX), required: true);
            var __workflow_ocpApimSubscriptionKey = WorkflowExpression.Compile(ocpApimSubscriptionKey, nameof(ocpApimSubscriptionKey), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/ProjectCraft/Import";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["X-IN8-TENANT-PREFIX"] = ExpressionConverter.Convert(__workflow_xIN8TENANTPREFIX);
                callPayload.Headers["Ocp-Apim-Subscription-Key"] = ExpressionConverter.Convert(__workflow_ocpApimSubscriptionKey);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ineight")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> ProjectEmployeeBillingClassesImport(Expression<Func<string>> xIN8TENANTPREFIX, Expression<Func<string>> ocpApimSubscriptionKey, Expression<Func<bodyInputItem222222222222222222222222222[]>> body)
        {
            var __workflow_xIN8TENANTPREFIX = WorkflowExpression.Compile(xIN8TENANTPREFIX, nameof(xIN8TENANTPREFIX), required: true);
            var __workflow_ocpApimSubscriptionKey = WorkflowExpression.Compile(ocpApimSubscriptionKey, nameof(ocpApimSubscriptionKey), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/ProjectEmployeeBillingClasses/Import";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["X-IN8-TENANT-PREFIX"] = ExpressionConverter.Convert(__workflow_xIN8TENANTPREFIX);
                callPayload.Headers["Ocp-Apim-Subscription-Key"] = ExpressionConverter.Convert(__workflow_ocpApimSubscriptionKey);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ineight")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> ProjectEmployeesImport(Expression<Func<string>> xIN8TENANTPREFIX, Expression<Func<string>> ocpApimSubscriptionKey, Expression<Func<bodyInputItem2222222222222222222222222222[]>> body)
        {
            var __workflow_xIN8TENANTPREFIX = WorkflowExpression.Compile(xIN8TENANTPREFIX, nameof(xIN8TENANTPREFIX), required: true);
            var __workflow_ocpApimSubscriptionKey = WorkflowExpression.Compile(ocpApimSubscriptionKey, nameof(ocpApimSubscriptionKey), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/ProjectEmployees/Import";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["X-IN8-TENANT-PREFIX"] = ExpressionConverter.Convert(__workflow_xIN8TENANTPREFIX);
                callPayload.Headers["Ocp-Apim-Subscription-Key"] = ExpressionConverter.Convert(__workflow_ocpApimSubscriptionKey);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ineight")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> ProjectEquipmentBillingClassesImport(Expression<Func<string>> xIN8TENANTPREFIX, Expression<Func<string>> ocpApimSubscriptionKey, Expression<Func<bodyInputItem22222222222222222222222222222[]>> body)
        {
            var __workflow_xIN8TENANTPREFIX = WorkflowExpression.Compile(xIN8TENANTPREFIX, nameof(xIN8TENANTPREFIX), required: true);
            var __workflow_ocpApimSubscriptionKey = WorkflowExpression.Compile(ocpApimSubscriptionKey, nameof(ocpApimSubscriptionKey), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/ProjectEquipmentBillingClasses/Import";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["X-IN8-TENANT-PREFIX"] = ExpressionConverter.Convert(__workflow_xIN8TENANTPREFIX);
                callPayload.Headers["Ocp-Apim-Subscription-Key"] = ExpressionConverter.Convert(__workflow_ocpApimSubscriptionKey);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ineight")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> ProjectEquipmentsImport(Expression<Func<string>> xIN8TENANTPREFIX, Expression<Func<string>> ocpApimSubscriptionKey, Expression<Func<bodyInputItem222222222222222222222222222222[]>> body)
        {
            var __workflow_xIN8TENANTPREFIX = WorkflowExpression.Compile(xIN8TENANTPREFIX, nameof(xIN8TENANTPREFIX), required: true);
            var __workflow_ocpApimSubscriptionKey = WorkflowExpression.Compile(ocpApimSubscriptionKey, nameof(ocpApimSubscriptionKey), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/ProjectEquipments/Import";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["X-IN8-TENANT-PREFIX"] = ExpressionConverter.Convert(__workflow_xIN8TENANTPREFIX);
                callPayload.Headers["Ocp-Apim-Subscription-Key"] = ExpressionConverter.Convert(__workflow_ocpApimSubscriptionKey);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ineight")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> ProjectEquipmentTypeImport(Expression<Func<string>> xIN8TENANTPREFIX, Expression<Func<string>> ocpApimSubscriptionKey, Expression<Func<bodyInputItem2222222222222222222222222222222[]>> body)
        {
            var __workflow_xIN8TENANTPREFIX = WorkflowExpression.Compile(xIN8TENANTPREFIX, nameof(xIN8TENANTPREFIX), required: true);
            var __workflow_ocpApimSubscriptionKey = WorkflowExpression.Compile(ocpApimSubscriptionKey, nameof(ocpApimSubscriptionKey), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/ProjectEquipmentType/Import";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["X-IN8-TENANT-PREFIX"] = ExpressionConverter.Convert(__workflow_xIN8TENANTPREFIX);
                callPayload.Headers["Ocp-Apim-Subscription-Key"] = ExpressionConverter.Convert(__workflow_ocpApimSubscriptionKey);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ineight")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> ProjectImport(Expression<Func<string>> xIN8TENANTPREFIX, Expression<Func<string>> ocpApimSubscriptionKey, Expression<Func<bodyInputItem22222222222222222222222222222222[]>> body)
        {
            var __workflow_xIN8TENANTPREFIX = WorkflowExpression.Compile(xIN8TENANTPREFIX, nameof(xIN8TENANTPREFIX), required: true);
            var __workflow_ocpApimSubscriptionKey = WorkflowExpression.Compile(ocpApimSubscriptionKey, nameof(ocpApimSubscriptionKey), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Projects/Import";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["X-IN8-TENANT-PREFIX"] = ExpressionConverter.Convert(__workflow_xIN8TENANTPREFIX);
                callPayload.Headers["Ocp-Apim-Subscription-Key"] = ExpressionConverter.Convert(__workflow_ocpApimSubscriptionKey);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ineight")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> ProjectSettingsImport(Expression<Func<string>> xIN8TENANTPREFIX, Expression<Func<string>> ocpApimSubscriptionKey, Expression<Func<bodyInputItem222222222222222222222222222222222[]>> body)
        {
            var __workflow_xIN8TENANTPREFIX = WorkflowExpression.Compile(xIN8TENANTPREFIX, nameof(xIN8TENANTPREFIX), required: true);
            var __workflow_ocpApimSubscriptionKey = WorkflowExpression.Compile(ocpApimSubscriptionKey, nameof(ocpApimSubscriptionKey), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/ProjectSettings/Import";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["X-IN8-TENANT-PREFIX"] = ExpressionConverter.Convert(__workflow_xIN8TENANTPREFIX);
                callPayload.Headers["Ocp-Apim-Subscription-Key"] = ExpressionConverter.Convert(__workflow_ocpApimSubscriptionKey);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ineight")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> ProjectVendorsImport(Expression<Func<string>> xIN8TENANTPREFIX, Expression<Func<string>> ocpApimSubscriptionKey, Expression<Func<bodyInputItem2222222222222222222222222222222222[]>> body)
        {
            var __workflow_xIN8TENANTPREFIX = WorkflowExpression.Compile(xIN8TENANTPREFIX, nameof(xIN8TENANTPREFIX), required: true);
            var __workflow_ocpApimSubscriptionKey = WorkflowExpression.Compile(ocpApimSubscriptionKey, nameof(ocpApimSubscriptionKey), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/ProjectVendors/Import";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["X-IN8-TENANT-PREFIX"] = ExpressionConverter.Convert(__workflow_xIN8TENANTPREFIX);
                callPayload.Headers["Ocp-Apim-Subscription-Key"] = ExpressionConverter.Convert(__workflow_ocpApimSubscriptionKey);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ineight")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> UnionImport(Expression<Func<string>> xIN8TENANTPREFIX, Expression<Func<string>> ocpApimSubscriptionKey, Expression<Func<bodyInputItem22222222222222222222222222222222222[]>> body)
        {
            var __workflow_xIN8TENANTPREFIX = WorkflowExpression.Compile(xIN8TENANTPREFIX, nameof(xIN8TENANTPREFIX), required: true);
            var __workflow_ocpApimSubscriptionKey = WorkflowExpression.Compile(ocpApimSubscriptionKey, nameof(ocpApimSubscriptionKey), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Unions/Import";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["X-IN8-TENANT-PREFIX"] = ExpressionConverter.Convert(__workflow_xIN8TENANTPREFIX);
                callPayload.Headers["Ocp-Apim-Subscription-Key"] = ExpressionConverter.Convert(__workflow_ocpApimSubscriptionKey);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ineight")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> VendorsImport(Expression<Func<string>> xIN8TENANTPREFIX, Expression<Func<string>> ocpApimSubscriptionKey, Expression<Func<bodyInputItem222222222222222222222222222222222222[]>> body)
        {
            var __workflow_xIN8TENANTPREFIX = WorkflowExpression.Compile(xIN8TENANTPREFIX, nameof(xIN8TENANTPREFIX), required: true);
            var __workflow_ocpApimSubscriptionKey = WorkflowExpression.Compile(ocpApimSubscriptionKey, nameof(ocpApimSubscriptionKey), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Vendors/Import";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["X-IN8-TENANT-PREFIX"] = ExpressionConverter.Convert(__workflow_xIN8TENANTPREFIX);
                callPayload.Headers["Ocp-Apim-Subscription-Key"] = ExpressionConverter.Convert(__workflow_ocpApimSubscriptionKey);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ineight")]
        public IBodyWorkflowAction<AccountCodeGetResponseItem[], ApiConnectionActionConfiguration> AccountCodeGet(Expression<Func<string>> xIN8TENANTPREFIX, Expression<Func<string>> ocpApimSubscriptionKey, Expression<Func<string>> filter = null, Expression<Func<string>> orderby = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, Expression<Func<int>> count = null)
        {
            var __workflow_xIN8TENANTPREFIX = WorkflowExpression.Compile(xIN8TENANTPREFIX, nameof(xIN8TENANTPREFIX), required: true);
            var __workflow_ocpApimSubscriptionKey = WorkflowExpression.Compile(ocpApimSubscriptionKey, nameof(ocpApimSubscriptionKey), required: true);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_orderby = WorkflowExpression.Compile(orderby, nameof(orderby), required: false);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            var __workflow_skip = WorkflowExpression.Compile(skip, nameof(skip), required: false);
            var __workflow_count = WorkflowExpression.Compile(count, nameof(count), required: false);
            return new DeferredBodyAction<AccountCodeGetResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/AccountCodes";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_orderby != null)
                    callPayload.Queries["$orderby"] = ExpressionConverter.Convert(__workflow_orderby);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                if (__workflow_skip != null)
                    callPayload.Queries["$skip"] = ExpressionConverter.Convert(__workflow_skip);
                if (__workflow_count != null)
                    callPayload.Queries["$count"] = ExpressionConverter.Convert(__workflow_count);
                callPayload.Headers["X-IN8-TENANT-PREFIX"] = ExpressionConverter.Convert(__workflow_xIN8TENANTPREFIX);
                callPayload.Headers["Ocp-Apim-Subscription-Key"] = ExpressionConverter.Convert(__workflow_ocpApimSubscriptionKey);
                return new ApiConnectionAction<AccountCodeGetResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ineight")]
        public IBodyWorkflowAction<ContactsGetResponseItem[], ApiConnectionActionConfiguration> ContactsGet(Expression<Func<string>> xIN8TENANTPREFIX, Expression<Func<string>> ocpApimSubscriptionKey, Expression<Func<string>> filter = null, Expression<Func<string>> orderby = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null)
        {
            var __workflow_xIN8TENANTPREFIX = WorkflowExpression.Compile(xIN8TENANTPREFIX, nameof(xIN8TENANTPREFIX), required: true);
            var __workflow_ocpApimSubscriptionKey = WorkflowExpression.Compile(ocpApimSubscriptionKey, nameof(ocpApimSubscriptionKey), required: true);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_orderby = WorkflowExpression.Compile(orderby, nameof(orderby), required: false);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            var __workflow_skip = WorkflowExpression.Compile(skip, nameof(skip), required: false);
            return new DeferredBodyAction<ContactsGetResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Contacts";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_orderby != null)
                    callPayload.Queries["$orderby"] = ExpressionConverter.Convert(__workflow_orderby);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                if (__workflow_skip != null)
                    callPayload.Queries["$skip"] = ExpressionConverter.Convert(__workflow_skip);
                callPayload.Headers["X-IN8-TENANT-PREFIX"] = ExpressionConverter.Convert(__workflow_xIN8TENANTPREFIX);
                callPayload.Headers["Ocp-Apim-Subscription-Key"] = ExpressionConverter.Convert(__workflow_ocpApimSubscriptionKey);
                return new ApiConnectionAction<ContactsGetResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ineight")]
        public IBodyWorkflowAction<CountryGetResponseItem[], ApiConnectionActionConfiguration> CountryGet(Expression<Func<string>> xIN8TENANTPREFIX, Expression<Func<string>> ocpApimSubscriptionKey, Expression<Func<bool>> includeTranslation, Expression<Func<string>> filter = null, Expression<Func<string>> orderby = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null)
        {
            var __workflow_xIN8TENANTPREFIX = WorkflowExpression.Compile(xIN8TENANTPREFIX, nameof(xIN8TENANTPREFIX), required: true);
            var __workflow_ocpApimSubscriptionKey = WorkflowExpression.Compile(ocpApimSubscriptionKey, nameof(ocpApimSubscriptionKey), required: true);
            var __workflow_includeTranslation = WorkflowExpression.Compile(includeTranslation, nameof(includeTranslation), required: true);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_orderby = WorkflowExpression.Compile(orderby, nameof(orderby), required: false);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            var __workflow_skip = WorkflowExpression.Compile(skip, nameof(skip), required: false);
            return new DeferredBodyAction<CountryGetResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Country/IncludeTranslation={0}", __workflow_includeTranslation.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_orderby != null)
                    callPayload.Queries["$orderby"] = ExpressionConverter.Convert(__workflow_orderby);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                if (__workflow_skip != null)
                    callPayload.Queries["$skip"] = ExpressionConverter.Convert(__workflow_skip);
                callPayload.Headers["X-IN8-TENANT-PREFIX"] = ExpressionConverter.Convert(__workflow_xIN8TENANTPREFIX);
                callPayload.Headers["Ocp-Apim-Subscription-Key"] = ExpressionConverter.Convert(__workflow_ocpApimSubscriptionKey);
                return new ApiConnectionAction<CountryGetResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ineight")]
        public IBodyWorkflowAction<CraftsGetResponseItem[], ApiConnectionActionConfiguration> CraftsGet(Expression<Func<string>> xIN8TENANTPREFIX, Expression<Func<string>> ocpApimSubscriptionKey, Expression<Func<string>> tradeSourceSystemId = null, Expression<Func<string>> filter = null, Expression<Func<string>> orderby = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null)
        {
            var __workflow_xIN8TENANTPREFIX = WorkflowExpression.Compile(xIN8TENANTPREFIX, nameof(xIN8TENANTPREFIX), required: true);
            var __workflow_ocpApimSubscriptionKey = WorkflowExpression.Compile(ocpApimSubscriptionKey, nameof(ocpApimSubscriptionKey), required: true);
            var __workflow_tradeSourceSystemId = WorkflowExpression.Compile(tradeSourceSystemId, nameof(tradeSourceSystemId), required: false);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_orderby = WorkflowExpression.Compile(orderby, nameof(orderby), required: false);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            var __workflow_skip = WorkflowExpression.Compile(skip, nameof(skip), required: false);
            return new DeferredBodyAction<CraftsGetResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Crafts";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_tradeSourceSystemId != null)
                    callPayload.Queries["TradeSourceSystemId"] = ExpressionConverter.Convert(__workflow_tradeSourceSystemId);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_orderby != null)
                    callPayload.Queries["$orderby"] = ExpressionConverter.Convert(__workflow_orderby);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                if (__workflow_skip != null)
                    callPayload.Queries["$skip"] = ExpressionConverter.Convert(__workflow_skip);
                callPayload.Headers["X-IN8-TENANT-PREFIX"] = ExpressionConverter.Convert(__workflow_xIN8TENANTPREFIX);
                callPayload.Headers["Ocp-Apim-Subscription-Key"] = ExpressionConverter.Convert(__workflow_ocpApimSubscriptionKey);
                return new ApiConnectionAction<CraftsGetResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ineight")]
        public IBodyWorkflowAction<CurrenciesGetResponseItem[], ApiConnectionActionConfiguration> CurrenciesGet(Expression<Func<string>> xIN8TENANTPREFIX, Expression<Func<string>> ocpApimSubscriptionKey, Expression<Func<string>> filter = null, Expression<Func<string>> orderby = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, Expression<Func<int>> count = null)
        {
            var __workflow_xIN8TENANTPREFIX = WorkflowExpression.Compile(xIN8TENANTPREFIX, nameof(xIN8TENANTPREFIX), required: true);
            var __workflow_ocpApimSubscriptionKey = WorkflowExpression.Compile(ocpApimSubscriptionKey, nameof(ocpApimSubscriptionKey), required: true);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_orderby = WorkflowExpression.Compile(orderby, nameof(orderby), required: false);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            var __workflow_skip = WorkflowExpression.Compile(skip, nameof(skip), required: false);
            var __workflow_count = WorkflowExpression.Compile(count, nameof(count), required: false);
            return new DeferredBodyAction<CurrenciesGetResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Currencies";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_orderby != null)
                    callPayload.Queries["$orderby"] = ExpressionConverter.Convert(__workflow_orderby);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                if (__workflow_skip != null)
                    callPayload.Queries["$skip"] = ExpressionConverter.Convert(__workflow_skip);
                if (__workflow_count != null)
                    callPayload.Queries["$count"] = ExpressionConverter.Convert(__workflow_count);
                callPayload.Headers["X-IN8-TENANT-PREFIX"] = ExpressionConverter.Convert(__workflow_xIN8TENANTPREFIX);
                callPayload.Headers["Ocp-Apim-Subscription-Key"] = ExpressionConverter.Convert(__workflow_ocpApimSubscriptionKey);
                return new ApiConnectionAction<CurrenciesGetResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ineight")]
        public IBodyWorkflowAction<EmployeesGetResponseItem[], ApiConnectionActionConfiguration> EmployeesGet(Expression<Func<string>> xIN8TENANTPREFIX, Expression<Func<string>> ocpApimSubscriptionKey, Expression<Func<string>> filter = null, Expression<Func<string>> orderby = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null)
        {
            var __workflow_xIN8TENANTPREFIX = WorkflowExpression.Compile(xIN8TENANTPREFIX, nameof(xIN8TENANTPREFIX), required: true);
            var __workflow_ocpApimSubscriptionKey = WorkflowExpression.Compile(ocpApimSubscriptionKey, nameof(ocpApimSubscriptionKey), required: true);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_orderby = WorkflowExpression.Compile(orderby, nameof(orderby), required: false);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            var __workflow_skip = WorkflowExpression.Compile(skip, nameof(skip), required: false);
            return new DeferredBodyAction<EmployeesGetResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Employees";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_orderby != null)
                    callPayload.Queries["$orderby"] = ExpressionConverter.Convert(__workflow_orderby);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                if (__workflow_skip != null)
                    callPayload.Queries["$skip"] = ExpressionConverter.Convert(__workflow_skip);
                callPayload.Headers["X-IN8-TENANT-PREFIX"] = ExpressionConverter.Convert(__workflow_xIN8TENANTPREFIX);
                callPayload.Headers["Ocp-Apim-Subscription-Key"] = ExpressionConverter.Convert(__workflow_ocpApimSubscriptionKey);
                return new ApiConnectionAction<EmployeesGetResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ineight")]
        public IBodyWorkflowAction<EquipmentGetResponseItem[], ApiConnectionActionConfiguration> EquipmentGet(Expression<Func<string>> xIN8TENANTPREFIX, Expression<Func<string>> ocpApimSubscriptionKey, Expression<Func<string>> filter = null, Expression<Func<string>> orderby = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null)
        {
            var __workflow_xIN8TENANTPREFIX = WorkflowExpression.Compile(xIN8TENANTPREFIX, nameof(xIN8TENANTPREFIX), required: true);
            var __workflow_ocpApimSubscriptionKey = WorkflowExpression.Compile(ocpApimSubscriptionKey, nameof(ocpApimSubscriptionKey), required: true);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_orderby = WorkflowExpression.Compile(orderby, nameof(orderby), required: false);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            var __workflow_skip = WorkflowExpression.Compile(skip, nameof(skip), required: false);
            return new DeferredBodyAction<EquipmentGetResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Equipments";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_orderby != null)
                    callPayload.Queries["$orderby"] = ExpressionConverter.Convert(__workflow_orderby);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                if (__workflow_skip != null)
                    callPayload.Queries["$skip"] = ExpressionConverter.Convert(__workflow_skip);
                callPayload.Headers["X-IN8-TENANT-PREFIX"] = ExpressionConverter.Convert(__workflow_xIN8TENANTPREFIX);
                callPayload.Headers["Ocp-Apim-Subscription-Key"] = ExpressionConverter.Convert(__workflow_ocpApimSubscriptionKey);
                return new ApiConnectionAction<EquipmentGetResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ineight")]
        public IBodyWorkflowAction<EquipmentCategoriesGetResponseItem[], ApiConnectionActionConfiguration> EquipmentCategoriesGet(Expression<Func<string>> xIN8TENANTPREFIX, Expression<Func<string>> ocpApimSubscriptionKey, Expression<Func<string>> filter = null, Expression<Func<string>> orderby = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null)
        {
            var __workflow_xIN8TENANTPREFIX = WorkflowExpression.Compile(xIN8TENANTPREFIX, nameof(xIN8TENANTPREFIX), required: true);
            var __workflow_ocpApimSubscriptionKey = WorkflowExpression.Compile(ocpApimSubscriptionKey, nameof(ocpApimSubscriptionKey), required: true);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_orderby = WorkflowExpression.Compile(orderby, nameof(orderby), required: false);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            var __workflow_skip = WorkflowExpression.Compile(skip, nameof(skip), required: false);
            return new DeferredBodyAction<EquipmentCategoriesGetResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/EquipmentCategories";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_orderby != null)
                    callPayload.Queries["$orderby"] = ExpressionConverter.Convert(__workflow_orderby);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                if (__workflow_skip != null)
                    callPayload.Queries["$skip"] = ExpressionConverter.Convert(__workflow_skip);
                callPayload.Headers["X-IN8-TENANT-PREFIX"] = ExpressionConverter.Convert(__workflow_xIN8TENANTPREFIX);
                callPayload.Headers["Ocp-Apim-Subscription-Key"] = ExpressionConverter.Convert(__workflow_ocpApimSubscriptionKey);
                return new ApiConnectionAction<EquipmentCategoriesGetResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ineight")]
        public IBodyWorkflowAction<EquipmentTypesGetResponseItem[], ApiConnectionActionConfiguration> EquipmentTypesGet(Expression<Func<string>> xIN8TENANTPREFIX, Expression<Func<string>> ocpApimSubscriptionKey, Expression<Func<string>> equipmentCategoryId = null, Expression<Func<string>> filter = null, Expression<Func<string>> orderby = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null)
        {
            var __workflow_xIN8TENANTPREFIX = WorkflowExpression.Compile(xIN8TENANTPREFIX, nameof(xIN8TENANTPREFIX), required: true);
            var __workflow_ocpApimSubscriptionKey = WorkflowExpression.Compile(ocpApimSubscriptionKey, nameof(ocpApimSubscriptionKey), required: true);
            var __workflow_equipmentCategoryId = WorkflowExpression.Compile(equipmentCategoryId, nameof(equipmentCategoryId), required: false);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_orderby = WorkflowExpression.Compile(orderby, nameof(orderby), required: false);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            var __workflow_skip = WorkflowExpression.Compile(skip, nameof(skip), required: false);
            return new DeferredBodyAction<EquipmentTypesGetResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/EquipmentTypes";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_equipmentCategoryId != null)
                    callPayload.Queries["EquipmentCategoryId"] = ExpressionConverter.Convert(__workflow_equipmentCategoryId);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_orderby != null)
                    callPayload.Queries["$orderby"] = ExpressionConverter.Convert(__workflow_orderby);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                if (__workflow_skip != null)
                    callPayload.Queries["$skip"] = ExpressionConverter.Convert(__workflow_skip);
                callPayload.Headers["X-IN8-TENANT-PREFIX"] = ExpressionConverter.Convert(__workflow_xIN8TENANTPREFIX);
                callPayload.Headers["Ocp-Apim-Subscription-Key"] = ExpressionConverter.Convert(__workflow_ocpApimSubscriptionKey);
                return new ApiConnectionAction<EquipmentTypesGetResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ineight")]
        public IBodyWorkflowAction<LanguagesGetResponseItem[], ApiConnectionActionConfiguration> LanguagesGet(Expression<Func<string>> xIN8TENANTPREFIX, Expression<Func<string>> ocpApimSubscriptionKey, Expression<Func<string>> filter = null, Expression<Func<string>> orderby = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null)
        {
            var __workflow_xIN8TENANTPREFIX = WorkflowExpression.Compile(xIN8TENANTPREFIX, nameof(xIN8TENANTPREFIX), required: true);
            var __workflow_ocpApimSubscriptionKey = WorkflowExpression.Compile(ocpApimSubscriptionKey, nameof(ocpApimSubscriptionKey), required: true);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_orderby = WorkflowExpression.Compile(orderby, nameof(orderby), required: false);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            var __workflow_skip = WorkflowExpression.Compile(skip, nameof(skip), required: false);
            return new DeferredBodyAction<LanguagesGetResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Languages";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_orderby != null)
                    callPayload.Queries["$orderby"] = ExpressionConverter.Convert(__workflow_orderby);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                if (__workflow_skip != null)
                    callPayload.Queries["$skip"] = ExpressionConverter.Convert(__workflow_skip);
                callPayload.Headers["X-IN8-TENANT-PREFIX"] = ExpressionConverter.Convert(__workflow_xIN8TENANTPREFIX);
                callPayload.Headers["Ocp-Apim-Subscription-Key"] = ExpressionConverter.Convert(__workflow_ocpApimSubscriptionKey);
                return new ApiConnectionAction<LanguagesGetResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ineight")]
        public IBodyWorkflowAction<MarketsGetResponseItem[], ApiConnectionActionConfiguration> MarketsGet(Expression<Func<string>> xIN8TENANTPREFIX, Expression<Func<string>> ocpApimSubscriptionKey, Expression<Func<string>> filter = null, Expression<Func<string>> orderby = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null)
        {
            var __workflow_xIN8TENANTPREFIX = WorkflowExpression.Compile(xIN8TENANTPREFIX, nameof(xIN8TENANTPREFIX), required: true);
            var __workflow_ocpApimSubscriptionKey = WorkflowExpression.Compile(ocpApimSubscriptionKey, nameof(ocpApimSubscriptionKey), required: true);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_orderby = WorkflowExpression.Compile(orderby, nameof(orderby), required: false);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            var __workflow_skip = WorkflowExpression.Compile(skip, nameof(skip), required: false);
            return new DeferredBodyAction<MarketsGetResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Markets";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_orderby != null)
                    callPayload.Queries["$orderby"] = ExpressionConverter.Convert(__workflow_orderby);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                if (__workflow_skip != null)
                    callPayload.Queries["$skip"] = ExpressionConverter.Convert(__workflow_skip);
                callPayload.Headers["X-IN8-TENANT-PREFIX"] = ExpressionConverter.Convert(__workflow_xIN8TENANTPREFIX);
                callPayload.Headers["Ocp-Apim-Subscription-Key"] = ExpressionConverter.Convert(__workflow_ocpApimSubscriptionKey);
                return new ApiConnectionAction<MarketsGetResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ineight")]
        public IBodyWorkflowAction<OrganizationsGetResponseItem[], ApiConnectionActionConfiguration> OrganizationsGet(Expression<Func<string>> xIN8TENANTPREFIX, Expression<Func<string>> ocpApimSubscriptionKey, Expression<Func<string>> sourceSystemId = null, Expression<Func<string>> filter = null, Expression<Func<string>> orderby = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null)
        {
            var __workflow_xIN8TENANTPREFIX = WorkflowExpression.Compile(xIN8TENANTPREFIX, nameof(xIN8TENANTPREFIX), required: true);
            var __workflow_ocpApimSubscriptionKey = WorkflowExpression.Compile(ocpApimSubscriptionKey, nameof(ocpApimSubscriptionKey), required: true);
            var __workflow_sourceSystemId = WorkflowExpression.Compile(sourceSystemId, nameof(sourceSystemId), required: false);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_orderby = WorkflowExpression.Compile(orderby, nameof(orderby), required: false);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            var __workflow_skip = WorkflowExpression.Compile(skip, nameof(skip), required: false);
            return new DeferredBodyAction<OrganizationsGetResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Organizations";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_sourceSystemId != null)
                    callPayload.Queries["SourceSystemId"] = ExpressionConverter.Convert(__workflow_sourceSystemId);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_orderby != null)
                    callPayload.Queries["$orderby"] = ExpressionConverter.Convert(__workflow_orderby);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                if (__workflow_skip != null)
                    callPayload.Queries["$skip"] = ExpressionConverter.Convert(__workflow_skip);
                callPayload.Headers["X-IN8-TENANT-PREFIX"] = ExpressionConverter.Convert(__workflow_xIN8TENANTPREFIX);
                callPayload.Headers["Ocp-Apim-Subscription-Key"] = ExpressionConverter.Convert(__workflow_ocpApimSubscriptionKey);
                return new ApiConnectionAction<OrganizationsGetResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ineight")]
        public IBodyWorkflowAction<ProjectContactsGetResponseItem[], ApiConnectionActionConfiguration> ProjectContactsGet(Expression<Func<string>> projectId, Expression<Func<string>> xIN8TENANTPREFIX, Expression<Func<string>> ocpApimSubscriptionKey, Expression<Func<string>> filter = null, Expression<Func<string>> orderby = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null)
        {
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: true);
            var __workflow_xIN8TENANTPREFIX = WorkflowExpression.Compile(xIN8TENANTPREFIX, nameof(xIN8TENANTPREFIX), required: true);
            var __workflow_ocpApimSubscriptionKey = WorkflowExpression.Compile(ocpApimSubscriptionKey, nameof(ocpApimSubscriptionKey), required: true);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_orderby = WorkflowExpression.Compile(orderby, nameof(orderby), required: false);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            var __workflow_skip = WorkflowExpression.Compile(skip, nameof(skip), required: false);
            return new DeferredBodyAction<ProjectContactsGetResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/ProjectContacts/ProjectId='{0}'", __workflow_projectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_orderby != null)
                    callPayload.Queries["$orderby"] = ExpressionConverter.Convert(__workflow_orderby);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                if (__workflow_skip != null)
                    callPayload.Queries["$skip"] = ExpressionConverter.Convert(__workflow_skip);
                callPayload.Headers["X-IN8-TENANT-PREFIX"] = ExpressionConverter.Convert(__workflow_xIN8TENANTPREFIX);
                callPayload.Headers["Ocp-Apim-Subscription-Key"] = ExpressionConverter.Convert(__workflow_ocpApimSubscriptionKey);
                return new ApiConnectionAction<ProjectContactsGetResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ineight")]
        public IBodyWorkflowAction<ProjectEmployeeBillingClassesGetResponseItem[], ApiConnectionActionConfiguration> ProjectEmployeeBillingClassesGet(Expression<Func<string>> projectId, Expression<Func<string>> xIN8TENANTPREFIX, Expression<Func<string>> ocpApimSubscriptionKey, Expression<Func<string>> filter = null, Expression<Func<string>> orderby = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null)
        {
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: true);
            var __workflow_xIN8TENANTPREFIX = WorkflowExpression.Compile(xIN8TENANTPREFIX, nameof(xIN8TENANTPREFIX), required: true);
            var __workflow_ocpApimSubscriptionKey = WorkflowExpression.Compile(ocpApimSubscriptionKey, nameof(ocpApimSubscriptionKey), required: true);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_orderby = WorkflowExpression.Compile(orderby, nameof(orderby), required: false);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            var __workflow_skip = WorkflowExpression.Compile(skip, nameof(skip), required: false);
            return new DeferredBodyAction<ProjectEmployeeBillingClassesGetResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/ProjectEmployeeBillingClasses/ProjectId='{0}'", __workflow_projectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_orderby != null)
                    callPayload.Queries["$orderby"] = ExpressionConverter.Convert(__workflow_orderby);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                if (__workflow_skip != null)
                    callPayload.Queries["$skip"] = ExpressionConverter.Convert(__workflow_skip);
                callPayload.Headers["X-IN8-TENANT-PREFIX"] = ExpressionConverter.Convert(__workflow_xIN8TENANTPREFIX);
                callPayload.Headers["Ocp-Apim-Subscription-Key"] = ExpressionConverter.Convert(__workflow_ocpApimSubscriptionKey);
                return new ApiConnectionAction<ProjectEmployeeBillingClassesGetResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ineight")]
        public IBodyWorkflowAction<ProjectEmployeesGetResponseItem[], ApiConnectionActionConfiguration> ProjectEmployeesGet(Expression<Func<string>> projectId, Expression<Func<string>> xIN8TENANTPREFIX, Expression<Func<string>> ocpApimSubscriptionKey, Expression<Func<string>> filter = null, Expression<Func<string>> orderby = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null)
        {
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: true);
            var __workflow_xIN8TENANTPREFIX = WorkflowExpression.Compile(xIN8TENANTPREFIX, nameof(xIN8TENANTPREFIX), required: true);
            var __workflow_ocpApimSubscriptionKey = WorkflowExpression.Compile(ocpApimSubscriptionKey, nameof(ocpApimSubscriptionKey), required: true);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_orderby = WorkflowExpression.Compile(orderby, nameof(orderby), required: false);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            var __workflow_skip = WorkflowExpression.Compile(skip, nameof(skip), required: false);
            return new DeferredBodyAction<ProjectEmployeesGetResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/ProjectEmployees/ProjectId='{0}'", __workflow_projectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_orderby != null)
                    callPayload.Queries["$orderby"] = ExpressionConverter.Convert(__workflow_orderby);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                if (__workflow_skip != null)
                    callPayload.Queries["$skip"] = ExpressionConverter.Convert(__workflow_skip);
                callPayload.Headers["X-IN8-TENANT-PREFIX"] = ExpressionConverter.Convert(__workflow_xIN8TENANTPREFIX);
                callPayload.Headers["Ocp-Apim-Subscription-Key"] = ExpressionConverter.Convert(__workflow_ocpApimSubscriptionKey);
                return new ApiConnectionAction<ProjectEmployeesGetResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ineight")]
        public IBodyWorkflowAction<ProjectEquipmentBillingClassesGetResponseItem[], ApiConnectionActionConfiguration> ProjectEquipmentBillingClassesGet(Expression<Func<string>> projectId, Expression<Func<string>> xIN8TENANTPREFIX, Expression<Func<string>> ocpApimSubscriptionKey, Expression<Func<string>> filter = null, Expression<Func<string>> orderby = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null)
        {
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: true);
            var __workflow_xIN8TENANTPREFIX = WorkflowExpression.Compile(xIN8TENANTPREFIX, nameof(xIN8TENANTPREFIX), required: true);
            var __workflow_ocpApimSubscriptionKey = WorkflowExpression.Compile(ocpApimSubscriptionKey, nameof(ocpApimSubscriptionKey), required: true);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_orderby = WorkflowExpression.Compile(orderby, nameof(orderby), required: false);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            var __workflow_skip = WorkflowExpression.Compile(skip, nameof(skip), required: false);
            return new DeferredBodyAction<ProjectEquipmentBillingClassesGetResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/ProjectEquipmentBillingClasses/ProjectId='{0}'", __workflow_projectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_orderby != null)
                    callPayload.Queries["$orderby"] = ExpressionConverter.Convert(__workflow_orderby);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                if (__workflow_skip != null)
                    callPayload.Queries["$skip"] = ExpressionConverter.Convert(__workflow_skip);
                callPayload.Headers["X-IN8-TENANT-PREFIX"] = ExpressionConverter.Convert(__workflow_xIN8TENANTPREFIX);
                callPayload.Headers["Ocp-Apim-Subscription-Key"] = ExpressionConverter.Convert(__workflow_ocpApimSubscriptionKey);
                return new ApiConnectionAction<ProjectEquipmentBillingClassesGetResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ineight")]
        public IBodyWorkflowAction<ProjectEquipmentsGetResponseItem[], ApiConnectionActionConfiguration> ProjectEquipmentsGet(Expression<Func<string>> projectId, Expression<Func<string>> xIN8TENANTPREFIX, Expression<Func<string>> ocpApimSubscriptionKey, Expression<Func<string>> filter = null, Expression<Func<string>> orderby = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null)
        {
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: true);
            var __workflow_xIN8TENANTPREFIX = WorkflowExpression.Compile(xIN8TENANTPREFIX, nameof(xIN8TENANTPREFIX), required: true);
            var __workflow_ocpApimSubscriptionKey = WorkflowExpression.Compile(ocpApimSubscriptionKey, nameof(ocpApimSubscriptionKey), required: true);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_orderby = WorkflowExpression.Compile(orderby, nameof(orderby), required: false);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            var __workflow_skip = WorkflowExpression.Compile(skip, nameof(skip), required: false);
            return new DeferredBodyAction<ProjectEquipmentsGetResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/ProjectEquipments/ProjectId='{0}'", __workflow_projectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_orderby != null)
                    callPayload.Queries["$orderby"] = ExpressionConverter.Convert(__workflow_orderby);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                if (__workflow_skip != null)
                    callPayload.Queries["$skip"] = ExpressionConverter.Convert(__workflow_skip);
                callPayload.Headers["X-IN8-TENANT-PREFIX"] = ExpressionConverter.Convert(__workflow_xIN8TENANTPREFIX);
                callPayload.Headers["Ocp-Apim-Subscription-Key"] = ExpressionConverter.Convert(__workflow_ocpApimSubscriptionKey);
                return new ApiConnectionAction<ProjectEquipmentsGetResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ineight")]
        public IBodyWorkflowAction<ProjectsGetResponseItem[], ApiConnectionActionConfiguration> ProjectsGet(Expression<Func<bool>> includeAttributes, Expression<Func<string>> xIN8TENANTPREFIX, Expression<Func<string>> ocpApimSubscriptionKey, Expression<Func<string>> organizationSourceSystemId = null, Expression<Func<string>> filter = null, Expression<Func<string>> orderby = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null)
        {
            var __workflow_includeAttributes = WorkflowExpression.Compile(includeAttributes, nameof(includeAttributes), required: true);
            var __workflow_xIN8TENANTPREFIX = WorkflowExpression.Compile(xIN8TENANTPREFIX, nameof(xIN8TENANTPREFIX), required: true);
            var __workflow_ocpApimSubscriptionKey = WorkflowExpression.Compile(ocpApimSubscriptionKey, nameof(ocpApimSubscriptionKey), required: true);
            var __workflow_organizationSourceSystemId = WorkflowExpression.Compile(organizationSourceSystemId, nameof(organizationSourceSystemId), required: false);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_orderby = WorkflowExpression.Compile(orderby, nameof(orderby), required: false);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            var __workflow_skip = WorkflowExpression.Compile(skip, nameof(skip), required: false);
            return new DeferredBodyAction<ProjectsGetResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Projects";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["includeAttributes"] = ExpressionConverter.Convert(__workflow_includeAttributes);
                if (__workflow_organizationSourceSystemId != null)
                    callPayload.Queries["OrganizationSourceSystemId"] = ExpressionConverter.Convert(__workflow_organizationSourceSystemId);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_orderby != null)
                    callPayload.Queries["$orderby"] = ExpressionConverter.Convert(__workflow_orderby);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                if (__workflow_skip != null)
                    callPayload.Queries["$skip"] = ExpressionConverter.Convert(__workflow_skip);
                callPayload.Headers["X-IN8-TENANT-PREFIX"] = ExpressionConverter.Convert(__workflow_xIN8TENANTPREFIX);
                callPayload.Headers["Ocp-Apim-Subscription-Key"] = ExpressionConverter.Convert(__workflow_ocpApimSubscriptionKey);
                return new ApiConnectionAction<ProjectsGetResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ineight")]
        public IBodyWorkflowAction<ProjectSettingsGetResponseItem[], ApiConnectionActionConfiguration> ProjectSettingsGet(Expression<Func<string>> projectId, Expression<Func<string>> xIN8TENANTPREFIX, Expression<Func<string>> ocpApimSubscriptionKey)
        {
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: true);
            var __workflow_xIN8TENANTPREFIX = WorkflowExpression.Compile(xIN8TENANTPREFIX, nameof(xIN8TENANTPREFIX), required: true);
            var __workflow_ocpApimSubscriptionKey = WorkflowExpression.Compile(ocpApimSubscriptionKey, nameof(ocpApimSubscriptionKey), required: true);
            return new DeferredBodyAction<ProjectSettingsGetResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/ProjectSettings/ProjectId='{0}'", __workflow_projectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["X-IN8-TENANT-PREFIX"] = ExpressionConverter.Convert(__workflow_xIN8TENANTPREFIX);
                callPayload.Headers["Ocp-Apim-Subscription-Key"] = ExpressionConverter.Convert(__workflow_ocpApimSubscriptionKey);
                return new ApiConnectionAction<ProjectSettingsGetResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ineight")]
        public IBodyWorkflowAction<ProjectVendorsGetResponseItem[], ApiConnectionActionConfiguration> ProjectVendorsGet(Expression<Func<string>> projectId, Expression<Func<string>> xIN8TENANTPREFIX, Expression<Func<string>> ocpApimSubscriptionKey, Expression<Func<string>> filter = null, Expression<Func<string>> orderby = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null)
        {
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: true);
            var __workflow_xIN8TENANTPREFIX = WorkflowExpression.Compile(xIN8TENANTPREFIX, nameof(xIN8TENANTPREFIX), required: true);
            var __workflow_ocpApimSubscriptionKey = WorkflowExpression.Compile(ocpApimSubscriptionKey, nameof(ocpApimSubscriptionKey), required: true);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_orderby = WorkflowExpression.Compile(orderby, nameof(orderby), required: false);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            var __workflow_skip = WorkflowExpression.Compile(skip, nameof(skip), required: false);
            return new DeferredBodyAction<ProjectVendorsGetResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/ProjectVendors/ProjectId='{0}'", __workflow_projectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_orderby != null)
                    callPayload.Queries["$orderby"] = ExpressionConverter.Convert(__workflow_orderby);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                if (__workflow_skip != null)
                    callPayload.Queries["$skip"] = ExpressionConverter.Convert(__workflow_skip);
                callPayload.Headers["X-IN8-TENANT-PREFIX"] = ExpressionConverter.Convert(__workflow_xIN8TENANTPREFIX);
                callPayload.Headers["Ocp-Apim-Subscription-Key"] = ExpressionConverter.Convert(__workflow_ocpApimSubscriptionKey);
                return new ApiConnectionAction<ProjectVendorsGetResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ineight")]
        public IBodyWorkflowAction<RegionsGetResponseItem[], ApiConnectionActionConfiguration> RegionsGet(Expression<Func<includeTranslationInput>> includeTranslation, Expression<Func<string>> xIN8TENANTPREFIX, Expression<Func<string>> ocpApimSubscriptionKey, Expression<Func<string>> countryISOCode = null, Expression<Func<string>> filter = null, Expression<Func<string>> orderby = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null)
        {
            var __workflow_includeTranslation = WorkflowExpression.Compile(includeTranslation, nameof(includeTranslation), required: true);
            var __workflow_xIN8TENANTPREFIX = WorkflowExpression.Compile(xIN8TENANTPREFIX, nameof(xIN8TENANTPREFIX), required: true);
            var __workflow_ocpApimSubscriptionKey = WorkflowExpression.Compile(ocpApimSubscriptionKey, nameof(ocpApimSubscriptionKey), required: true);
            var __workflow_countryISOCode = WorkflowExpression.Compile(countryISOCode, nameof(countryISOCode), required: false);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_orderby = WorkflowExpression.Compile(orderby, nameof(orderby), required: false);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            var __workflow_skip = WorkflowExpression.Compile(skip, nameof(skip), required: false);
            return new DeferredBodyAction<RegionsGetResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Regions";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["includeTranslation"] = ExpressionConverter.Convert(__workflow_includeTranslation);
                if (__workflow_countryISOCode != null)
                    callPayload.Queries["CountryISOCode"] = ExpressionConverter.Convert(__workflow_countryISOCode);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_orderby != null)
                    callPayload.Queries["$orderby"] = ExpressionConverter.Convert(__workflow_orderby);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                if (__workflow_skip != null)
                    callPayload.Queries["$skip"] = ExpressionConverter.Convert(__workflow_skip);
                callPayload.Headers["X-IN8-TENANT-PREFIX"] = ExpressionConverter.Convert(__workflow_xIN8TENANTPREFIX);
                callPayload.Headers["Ocp-Apim-Subscription-Key"] = ExpressionConverter.Convert(__workflow_ocpApimSubscriptionKey);
                return new ApiConnectionAction<RegionsGetResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ineight")]
        public IBodyWorkflowAction<RolesGetResponseItem[], ApiConnectionActionConfiguration> RolesGet(Expression<Func<string>> xIN8TENANTPREFIX, Expression<Func<string>> ocpApimSubscriptionKey, Expression<Func<string>> filter = null, Expression<Func<string>> orderby = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null)
        {
            var __workflow_xIN8TENANTPREFIX = WorkflowExpression.Compile(xIN8TENANTPREFIX, nameof(xIN8TENANTPREFIX), required: true);
            var __workflow_ocpApimSubscriptionKey = WorkflowExpression.Compile(ocpApimSubscriptionKey, nameof(ocpApimSubscriptionKey), required: true);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_orderby = WorkflowExpression.Compile(orderby, nameof(orderby), required: false);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            var __workflow_skip = WorkflowExpression.Compile(skip, nameof(skip), required: false);
            return new DeferredBodyAction<RolesGetResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Roles";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_orderby != null)
                    callPayload.Queries["$orderby"] = ExpressionConverter.Convert(__workflow_orderby);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                if (__workflow_skip != null)
                    callPayload.Queries["$skip"] = ExpressionConverter.Convert(__workflow_skip);
                callPayload.Headers["X-IN8-TENANT-PREFIX"] = ExpressionConverter.Convert(__workflow_xIN8TENANTPREFIX);
                callPayload.Headers["Ocp-Apim-Subscription-Key"] = ExpressionConverter.Convert(__workflow_ocpApimSubscriptionKey);
                return new ApiConnectionAction<RolesGetResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ineight")]
        public IBodyWorkflowAction<TimeZoneGetResponseItem[], ApiConnectionActionConfiguration> TimeZoneGet(Expression<Func<bool>> includeTranslation, Expression<Func<string>> xIN8TENANTPREFIX, Expression<Func<string>> ocpApimSubscriptionKey, Expression<Func<string>> filter = null, Expression<Func<string>> orderby = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null)
        {
            var __workflow_includeTranslation = WorkflowExpression.Compile(includeTranslation, nameof(includeTranslation), required: true);
            var __workflow_xIN8TENANTPREFIX = WorkflowExpression.Compile(xIN8TENANTPREFIX, nameof(xIN8TENANTPREFIX), required: true);
            var __workflow_ocpApimSubscriptionKey = WorkflowExpression.Compile(ocpApimSubscriptionKey, nameof(ocpApimSubscriptionKey), required: true);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_orderby = WorkflowExpression.Compile(orderby, nameof(orderby), required: false);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            var __workflow_skip = WorkflowExpression.Compile(skip, nameof(skip), required: false);
            return new DeferredBodyAction<TimeZoneGetResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/TimeZone/IncludeTranslation={0}", __workflow_includeTranslation.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_orderby != null)
                    callPayload.Queries["$orderby"] = ExpressionConverter.Convert(__workflow_orderby);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                if (__workflow_skip != null)
                    callPayload.Queries["$skip"] = ExpressionConverter.Convert(__workflow_skip);
                callPayload.Headers["X-IN8-TENANT-PREFIX"] = ExpressionConverter.Convert(__workflow_xIN8TENANTPREFIX);
                callPayload.Headers["Ocp-Apim-Subscription-Key"] = ExpressionConverter.Convert(__workflow_ocpApimSubscriptionKey);
                return new ApiConnectionAction<TimeZoneGetResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ineight")]
        public IBodyWorkflowAction<TradesGetResponseItem[], ApiConnectionActionConfiguration> TradesGet(Expression<Func<string>> xIN8TENANTPREFIX, Expression<Func<string>> ocpApimSubscriptionKey, Expression<Func<string>> filter = null, Expression<Func<string>> orderby = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null)
        {
            var __workflow_xIN8TENANTPREFIX = WorkflowExpression.Compile(xIN8TENANTPREFIX, nameof(xIN8TENANTPREFIX), required: true);
            var __workflow_ocpApimSubscriptionKey = WorkflowExpression.Compile(ocpApimSubscriptionKey, nameof(ocpApimSubscriptionKey), required: true);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_orderby = WorkflowExpression.Compile(orderby, nameof(orderby), required: false);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            var __workflow_skip = WorkflowExpression.Compile(skip, nameof(skip), required: false);
            return new DeferredBodyAction<TradesGetResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Trades";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_orderby != null)
                    callPayload.Queries["$orderby"] = ExpressionConverter.Convert(__workflow_orderby);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                if (__workflow_skip != null)
                    callPayload.Queries["$skip"] = ExpressionConverter.Convert(__workflow_skip);
                callPayload.Headers["X-IN8-TENANT-PREFIX"] = ExpressionConverter.Convert(__workflow_xIN8TENANTPREFIX);
                callPayload.Headers["Ocp-Apim-Subscription-Key"] = ExpressionConverter.Convert(__workflow_ocpApimSubscriptionKey);
                return new ApiConnectionAction<TradesGetResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ineight")]
        public IBodyWorkflowAction<UOMsGetResponseItem[], ApiConnectionActionConfiguration> UOMsGet(Expression<Func<string>> xIN8TENANTPREFIX, Expression<Func<string>> ocpApimSubscriptionKey, Expression<Func<string>> filter = null, Expression<Func<string>> orderby = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null)
        {
            var __workflow_xIN8TENANTPREFIX = WorkflowExpression.Compile(xIN8TENANTPREFIX, nameof(xIN8TENANTPREFIX), required: true);
            var __workflow_ocpApimSubscriptionKey = WorkflowExpression.Compile(ocpApimSubscriptionKey, nameof(ocpApimSubscriptionKey), required: true);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_orderby = WorkflowExpression.Compile(orderby, nameof(orderby), required: false);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            var __workflow_skip = WorkflowExpression.Compile(skip, nameof(skip), required: false);
            return new DeferredBodyAction<UOMsGetResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UOMs";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_orderby != null)
                    callPayload.Queries["$orderby"] = ExpressionConverter.Convert(__workflow_orderby);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                if (__workflow_skip != null)
                    callPayload.Queries["$skip"] = ExpressionConverter.Convert(__workflow_skip);
                callPayload.Headers["X-IN8-TENANT-PREFIX"] = ExpressionConverter.Convert(__workflow_xIN8TENANTPREFIX);
                callPayload.Headers["Ocp-Apim-Subscription-Key"] = ExpressionConverter.Convert(__workflow_ocpApimSubscriptionKey);
                return new ApiConnectionAction<UOMsGetResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ineight")]
        public IBodyWorkflowAction<UsersGetResponseItem[], ApiConnectionActionConfiguration> UsersGet(Expression<Func<string>> xIN8TENANTPREFIX, Expression<Func<string>> ocpApimSubscriptionKey, Expression<Func<string>> filter = null, Expression<Func<string>> orderby = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null)
        {
            var __workflow_xIN8TENANTPREFIX = WorkflowExpression.Compile(xIN8TENANTPREFIX, nameof(xIN8TENANTPREFIX), required: true);
            var __workflow_ocpApimSubscriptionKey = WorkflowExpression.Compile(ocpApimSubscriptionKey, nameof(ocpApimSubscriptionKey), required: true);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_orderby = WorkflowExpression.Compile(orderby, nameof(orderby), required: false);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            var __workflow_skip = WorkflowExpression.Compile(skip, nameof(skip), required: false);
            return new DeferredBodyAction<UsersGetResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Users";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_orderby != null)
                    callPayload.Queries["$orderby"] = ExpressionConverter.Convert(__workflow_orderby);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                if (__workflow_skip != null)
                    callPayload.Queries["$skip"] = ExpressionConverter.Convert(__workflow_skip);
                callPayload.Headers["X-IN8-TENANT-PREFIX"] = ExpressionConverter.Convert(__workflow_xIN8TENANTPREFIX);
                callPayload.Headers["Ocp-Apim-Subscription-Key"] = ExpressionConverter.Convert(__workflow_ocpApimSubscriptionKey);
                return new ApiConnectionAction<UsersGetResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ineight")]
        public IBodyWorkflowAction<VendorsGetResponseItem[], ApiConnectionActionConfiguration> VendorsGet(Expression<Func<string>> xIN8TENANTPREFIX, Expression<Func<string>> ocpApimSubscriptionKey, Expression<Func<string>> filter = null, Expression<Func<string>> orderby = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null)
        {
            var __workflow_xIN8TENANTPREFIX = WorkflowExpression.Compile(xIN8TENANTPREFIX, nameof(xIN8TENANTPREFIX), required: true);
            var __workflow_ocpApimSubscriptionKey = WorkflowExpression.Compile(ocpApimSubscriptionKey, nameof(ocpApimSubscriptionKey), required: true);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_orderby = WorkflowExpression.Compile(orderby, nameof(orderby), required: false);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            var __workflow_skip = WorkflowExpression.Compile(skip, nameof(skip), required: false);
            return new DeferredBodyAction<VendorsGetResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Vendors";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_orderby != null)
                    callPayload.Queries["$orderby"] = ExpressionConverter.Convert(__workflow_orderby);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                if (__workflow_skip != null)
                    callPayload.Queries["$skip"] = ExpressionConverter.Convert(__workflow_skip);
                callPayload.Headers["X-IN8-TENANT-PREFIX"] = ExpressionConverter.Convert(__workflow_xIN8TENANTPREFIX);
                callPayload.Headers["Ocp-Apim-Subscription-Key"] = ExpressionConverter.Convert(__workflow_ocpApimSubscriptionKey);
                return new ApiConnectionAction<VendorsGetResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ineight")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> PurchaseOrderImport(Expression<Func<string>> xIN8TENANTPREFIX, Expression<Func<string>> ocpApimSubscriptionKey, Expression<Func<bodyInputItem2222222222222222222222222222222222222[]>> body)
        {
            var __workflow_xIN8TENANTPREFIX = WorkflowExpression.Compile(xIN8TENANTPREFIX, nameof(xIN8TENANTPREFIX), required: true);
            var __workflow_ocpApimSubscriptionKey = WorkflowExpression.Compile(ocpApimSubscriptionKey, nameof(ocpApimSubscriptionKey), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PurchaseOrder/Import";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["X-IN8-TENANT-PREFIX"] = ExpressionConverter.Convert(__workflow_xIN8TENANTPREFIX);
                callPayload.Headers["Ocp-Apim-Subscription-Key"] = ExpressionConverter.Convert(__workflow_ocpApimSubscriptionKey);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ineight")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> PaymentRequestImport(Expression<Func<string>> xIN8TENANTPREFIX, Expression<Func<string>> ocpApimSubscriptionKey, Expression<Func<bodyInputItem22222222222222222222222222222222222222[]>> body)
        {
            var __workflow_xIN8TENANTPREFIX = WorkflowExpression.Compile(xIN8TENANTPREFIX, nameof(xIN8TENANTPREFIX), required: true);
            var __workflow_ocpApimSubscriptionKey = WorkflowExpression.Compile(ocpApimSubscriptionKey, nameof(ocpApimSubscriptionKey), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PaymentRequest/Import";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["X-IN8-TENANT-PREFIX"] = ExpressionConverter.Convert(__workflow_xIN8TENANTPREFIX);
                callPayload.Headers["Ocp-Apim-Subscription-Key"] = ExpressionConverter.Convert(__workflow_ocpApimSubscriptionKey);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ineight")]
        public IWorkflowAction<ApiConnectionActionConfiguration> GoodsReceiptImport(Expression<Func<string>> xIN8TENANTPREFIX, Expression<Func<string>> ocpApimSubscriptionKey, Expression<Func<bodyInputItem222222222222222222222222222222222222222[]>> body)
        {
            var __workflow_xIN8TENANTPREFIX = WorkflowExpression.Compile(xIN8TENANTPREFIX, nameof(xIN8TENANTPREFIX), required: true);
            var __workflow_ocpApimSubscriptionKey = WorkflowExpression.Compile(ocpApimSubscriptionKey, nameof(ocpApimSubscriptionKey), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/GoodsReceipt/Import";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["X-IN8-TENANT-PREFIX"] = ExpressionConverter.Convert(__workflow_xIN8TENANTPREFIX);
                callPayload.Headers["Ocp-Apim-Subscription-Key"] = ExpressionConverter.Convert(__workflow_ocpApimSubscriptionKey);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ineight")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> ContractTaxImport(Expression<Func<string>> xIN8TENANTPREFIX, Expression<Func<string>> ocpApimSubscriptionKey, Expression<Func<bodyInputItem2222222222222222222222222222222222222222[]>> body)
        {
            var __workflow_xIN8TENANTPREFIX = WorkflowExpression.Compile(xIN8TENANTPREFIX, nameof(xIN8TENANTPREFIX), required: true);
            var __workflow_ocpApimSubscriptionKey = WorkflowExpression.Compile(ocpApimSubscriptionKey, nameof(ocpApimSubscriptionKey), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/ContractTax/Import";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["X-IN8-TENANT-PREFIX"] = ExpressionConverter.Convert(__workflow_xIN8TENANTPREFIX);
                callPayload.Headers["Ocp-Apim-Subscription-Key"] = ExpressionConverter.Convert(__workflow_ocpApimSubscriptionKey);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ineight")]
        public IWorkflowAction<ApiConnectionActionConfiguration> StorageLocationsImport(Expression<Func<string>> xIN8TENANTPREFIX, Expression<Func<string>> ocpApimSubscriptionKey, Expression<Func<bodyInputItem22222222222222222222222222222222222222222[]>> body)
        {
            var __workflow_xIN8TENANTPREFIX = WorkflowExpression.Compile(xIN8TENANTPREFIX, nameof(xIN8TENANTPREFIX), required: true);
            var __workflow_ocpApimSubscriptionKey = WorkflowExpression.Compile(ocpApimSubscriptionKey, nameof(ocpApimSubscriptionKey), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/StorageLocations/Import";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["X-IN8-TENANT-PREFIX"] = ExpressionConverter.Convert(__workflow_xIN8TENANTPREFIX);
                callPayload.Headers["Ocp-Apim-Subscription-Key"] = ExpressionConverter.Convert(__workflow_ocpApimSubscriptionKey);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ineight")]
        public IWorkflowAction<ApiConnectionActionConfiguration> ProjectShippingAddressImport(Expression<Func<string>> xIN8TENANTPREFIX, Expression<Func<string>> ocpApimSubscriptionKey, Expression<Func<bodyInputItem222222222222222222222222222222222222222222[]>> body)
        {
            var __workflow_xIN8TENANTPREFIX = WorkflowExpression.Compile(xIN8TENANTPREFIX, nameof(xIN8TENANTPREFIX), required: true);
            var __workflow_ocpApimSubscriptionKey = WorkflowExpression.Compile(ocpApimSubscriptionKey, nameof(ocpApimSubscriptionKey), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/ProjectShippingAddress/Import";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["X-IN8-TENANT-PREFIX"] = ExpressionConverter.Convert(__workflow_xIN8TENANTPREFIX);
                callPayload.Headers["Ocp-Apim-Subscription-Key"] = ExpressionConverter.Convert(__workflow_ocpApimSubscriptionKey);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ineight")]
        public IWorkflowAction<ApiConnectionActionConfiguration> LegalEntitiesImport(Expression<Func<string>> xIN8TENANTPREFIX, Expression<Func<string>> ocpApimSubscriptionKey, Expression<Func<bodyInputItem2222222222222222222222222222222222222222222[]>> body)
        {
            var __workflow_xIN8TENANTPREFIX = WorkflowExpression.Compile(xIN8TENANTPREFIX, nameof(xIN8TENANTPREFIX), required: true);
            var __workflow_ocpApimSubscriptionKey = WorkflowExpression.Compile(ocpApimSubscriptionKey, nameof(ocpApimSubscriptionKey), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/LegalEntities/Import";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["X-IN8-TENANT-PREFIX"] = ExpressionConverter.Convert(__workflow_xIN8TENANTPREFIX);
                callPayload.Headers["Ocp-Apim-Subscription-Key"] = ExpressionConverter.Convert(__workflow_ocpApimSubscriptionKey);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ineight")]
        public IWorkflowAction<ApiConnectionActionConfiguration> ProjectLegalEntityImport(Expression<Func<string>> xIN8TENANTPREFIX, Expression<Func<string>> ocpApimSubscriptionKey, Expression<Func<bodyInputItem22222222222222222222222222222222222222222222[]>> body)
        {
            var __workflow_xIN8TENANTPREFIX = WorkflowExpression.Compile(xIN8TENANTPREFIX, nameof(xIN8TENANTPREFIX), required: true);
            var __workflow_ocpApimSubscriptionKey = WorkflowExpression.Compile(ocpApimSubscriptionKey, nameof(ocpApimSubscriptionKey), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/ProjectLegalEntities/Import";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["X-IN8-TENANT-PREFIX"] = ExpressionConverter.Convert(__workflow_xIN8TENANTPREFIX);
                callPayload.Headers["Ocp-Apim-Subscription-Key"] = ExpressionConverter.Convert(__workflow_ocpApimSubscriptionKey);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ineight")]
        public IWorkflowAction<ApiConnectionActionConfiguration> ProjectStorageLocationImport(Expression<Func<string>> xIN8TENANTPREFIX, Expression<Func<string>> ocpApimSubscriptionKey, Expression<Func<bodyInputItem222222222222222222222222222222222222222222222[]>> body)
        {
            var __workflow_xIN8TENANTPREFIX = WorkflowExpression.Compile(xIN8TENANTPREFIX, nameof(xIN8TENANTPREFIX), required: true);
            var __workflow_ocpApimSubscriptionKey = WorkflowExpression.Compile(ocpApimSubscriptionKey, nameof(ocpApimSubscriptionKey), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/ProjectStorageLocations/Import";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["X-IN8-TENANT-PREFIX"] = ExpressionConverter.Convert(__workflow_xIN8TENANTPREFIX);
                callPayload.Headers["Ocp-Apim-Subscription-Key"] = ExpressionConverter.Convert(__workflow_ocpApimSubscriptionKey);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ineight")]
        public IWorkflowAction<ApiConnectionActionConfiguration> PlantsImport(Expression<Func<string>> xIN8TENANTPREFIX, Expression<Func<string>> ocpApimSubscriptionKey, Expression<Func<bodyInputItem2222222222222222222222222222222222222222222222[]>> body)
        {
            var __workflow_xIN8TENANTPREFIX = WorkflowExpression.Compile(xIN8TENANTPREFIX, nameof(xIN8TENANTPREFIX), required: true);
            var __workflow_ocpApimSubscriptionKey = WorkflowExpression.Compile(ocpApimSubscriptionKey, nameof(ocpApimSubscriptionKey), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Plants/Import";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["X-IN8-TENANT-PREFIX"] = ExpressionConverter.Convert(__workflow_xIN8TENANTPREFIX);
                callPayload.Headers["Ocp-Apim-Subscription-Key"] = ExpressionConverter.Convert(__workflow_ocpApimSubscriptionKey);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ineight")]
        public IWorkflowAction<ApiConnectionActionConfiguration> ContractEquipmentImport(Expression<Func<string>> xIN8TENANTPREFIX, Expression<Func<string>> ocpApimSubscriptionKey, Expression<Func<bodyInputItem22222222222222222222222222222222222222222222222[]>> body)
        {
            var __workflow_xIN8TENANTPREFIX = WorkflowExpression.Compile(xIN8TENANTPREFIX, nameof(xIN8TENANTPREFIX), required: true);
            var __workflow_ocpApimSubscriptionKey = WorkflowExpression.Compile(ocpApimSubscriptionKey, nameof(ocpApimSubscriptionKey), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/ContractEquipment/Import";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["X-IN8-TENANT-PREFIX"] = ExpressionConverter.Convert(__workflow_xIN8TENANTPREFIX);
                callPayload.Headers["Ocp-Apim-Subscription-Key"] = ExpressionConverter.Convert(__workflow_ocpApimSubscriptionKey);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ineight")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> ContractAccrualResponseImport(Expression<Func<string>> xIN8TENANTPREFIX, Expression<Func<string>> ocpApimSubscriptionKey, Expression<Func<bodyInputItem222222222222222222222222222222222222222222222222[]>> body)
        {
            var __workflow_xIN8TENANTPREFIX = WorkflowExpression.Compile(xIN8TENANTPREFIX, nameof(xIN8TENANTPREFIX), required: true);
            var __workflow_ocpApimSubscriptionKey = WorkflowExpression.Compile(ocpApimSubscriptionKey, nameof(ocpApimSubscriptionKey), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/ContractAccrualResponse/Import";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["X-IN8-TENANT-PREFIX"] = ExpressionConverter.Convert(__workflow_xIN8TENANTPREFIX);
                callPayload.Headers["Ocp-Apim-Subscription-Key"] = ExpressionConverter.Convert(__workflow_ocpApimSubscriptionKey);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ineight")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> InvoicesImport(Expression<Func<string>> xIN8TENANTPREFIX, Expression<Func<string>> ocpApimSubscriptionKey, Expression<Func<bodyInputItem2222222222222222222222222222222222222222222222222[]>> body)
        {
            var __workflow_xIN8TENANTPREFIX = WorkflowExpression.Compile(xIN8TENANTPREFIX, nameof(xIN8TENANTPREFIX), required: true);
            var __workflow_ocpApimSubscriptionKey = WorkflowExpression.Compile(ocpApimSubscriptionKey, nameof(ocpApimSubscriptionKey), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Invoices/Import";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["X-IN8-TENANT-PREFIX"] = ExpressionConverter.Convert(__workflow_xIN8TENANTPREFIX);
                callPayload.Headers["Ocp-Apim-Subscription-Key"] = ExpressionConverter.Convert(__workflow_ocpApimSubscriptionKey);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ineight")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> ImportActuals(Expression<Func<string>> xIN8TENANTPREFIX, Expression<Func<string>> ocpApimSubscriptionKey, Expression<Func<ImportActualsInput>> body, Expression<Func<string>> xTaskCompleteCallbackUri = null)
        {
            var __workflow_xIN8TENANTPREFIX = WorkflowExpression.Compile(xIN8TENANTPREFIX, nameof(xIN8TENANTPREFIX), required: true);
            var __workflow_ocpApimSubscriptionKey = WorkflowExpression.Compile(ocpApimSubscriptionKey, nameof(ocpApimSubscriptionKey), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            var __workflow_xTaskCompleteCallbackUri = WorkflowExpression.Compile(xTaskCompleteCallbackUri, nameof(xTaskCompleteCallbackUri), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Actuals/ActualsImport";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["X-IN8-TENANT-PREFIX"] = ExpressionConverter.Convert(__workflow_xIN8TENANTPREFIX);
                callPayload.Headers["Ocp-Apim-Subscription-Key"] = ExpressionConverter.Convert(__workflow_ocpApimSubscriptionKey);
                if (__workflow_xTaskCompleteCallbackUri != null)
                    callPayload.Headers["X-TaskCompleteCallbackUri"] = ExpressionConverter.Convert(__workflow_xTaskCompleteCallbackUri);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ineight")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> MultiProjectActualsImport(Expression<Func<string>> xIN8TENANTPREFIX, Expression<Func<string>> ocpApimSubscriptionKey, Expression<Func<string>> xTaskCompleteCallbackUri = null, Expression<Func<bodyInputItem22222222222222222222222222222222222222222222222222[]>> body = null)
        {
            var __workflow_xIN8TENANTPREFIX = WorkflowExpression.Compile(xIN8TENANTPREFIX, nameof(xIN8TENANTPREFIX), required: true);
            var __workflow_ocpApimSubscriptionKey = WorkflowExpression.Compile(ocpApimSubscriptionKey, nameof(ocpApimSubscriptionKey), required: true);
            var __workflow_xTaskCompleteCallbackUri = WorkflowExpression.Compile(xTaskCompleteCallbackUri, nameof(xTaskCompleteCallbackUri), required: false);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Actuals/MultiProjectActualsImport";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["X-IN8-TENANT-PREFIX"] = ExpressionConverter.Convert(__workflow_xIN8TENANTPREFIX);
                callPayload.Headers["Ocp-Apim-Subscription-Key"] = ExpressionConverter.Convert(__workflow_ocpApimSubscriptionKey);
                if (__workflow_xTaskCompleteCallbackUri != null)
                    callPayload.Headers["X-TaskCompleteCallbackUri"] = ExpressionConverter.Convert(__workflow_xTaskCompleteCallbackUri);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }
    }

    public class IneightTriggers([ConnectionName] string connectionId)
    {
    }

    public class DailyPlanGetResponseItem
    {
        public DailyPlanGetResponseItemDailyPlanCostItemTypeItem[] DailyPlanCostItem { get; set; }
        public DailyPlanGetResponseItemDailyPlanNoteTypeItem[] DailyPlanNote { get; set; }
        public DailyPlanGetResponseItemDailyPlanSignOffTypeItem[] DailyPlanSignOff { get; set; }
        public DailyPlanGetResponseItemDailyPlanSignInsTypeItem[] DailyPlanSignIns { get; set; }
        public DailyPlanGetResponseItemDailyPlanBreaksTypeItem[] DailyPlanBreaks { get; set; }
        public DailyPlanGetResponseItemExecutersTypeItem[] Executers { get; set; }
        public DailyPlanGetResponseItemApproversTypeItem[] Approvers { get; set; }
        public DailyPlanGetResponseItemDailyPlanEmployeePayrollIndicatorTypeItem[] DailyPlanEmployeePayrollIndicator { get; set; }
        public DailyPlanGetResponseItemDailyPlanClientSignOffTypeItem[] DailyPlanClientSignOff { get; set; }
        public int PlanId { get; set; }
        public string CreatedDate { get; set; }
        public string ProjectId { get; set; }
        public string LanguageKey { get; set; }
        public string Location { get; set; }
        public string CreatedById { get; set; }
        public string DeviceKey { get; set; }
        public string Shift { get; set; }
        public string PlanDate { get; set; }
        public string PlanTitle { get; set; }
        public string PlanStatusCode { get; set; }
        public string ModifiedById { get; set; }
        public string ModifiedDate { get; set; }
        public string PlannedDate { get; set; }
        public string PlannedById { get; set; }
        public string ExecutedDate { get; set; }
        public string ExecutedById { get; set; }
        public string ApprovedDate { get; set; }
        public string ApprovedById { get; set; }
        public string ErrorHandlingToken { get; set; }
        public string CommitmentCode { get; set; }
        public int ExternalSyncStatus { get; set; }
        public int CommitmentId { get; set; }
        public DailyPlanGetResponseItemDailyPlanMaintenanceTypeItem[] DailyPlanMaintenance { get; set; }
        public DailyPlanGetResponseItemShiftDetailTypeItem[] ShiftDetail { get; set; }
        public string[] ClientSignoffReportRecipients { get; set; }
    }

    public class DailyPlanGetResponseItemDailyPlanCostItemTypeItem
    {
        public DailyPlanGetResponseItemDailyPlanCostItemTypeItemDailyPlanCostItemEmployeeTypeItem[] DailyPlanCostItemEmployee { get; set; }
        public DailyPlanGetResponseItemDailyPlanCostItemTypeItemDailyPlanCostItemEquipmentTypeItem[] DailyPlanCostItemEquipment { get; set; }
        public DailyPlanGetResponseItemDailyPlanCostItemTypeItemDailyPlanCostItemComponentTypeItem[] DailyPlanCostItemComponent { get; set; }
        public string CostItemId { get; set; }
        public int TaskPriority { get; set; }
        public double PlanQuantity { get; set; }
        public double SubmittedQuantity { get; set; }
        public double ApprovedQuantity { get; set; }
        public string CostItemSourceSystemId { get; set; }
        public string WBSCode { get; set; }
    }

    public class DailyPlanGetResponseItemDailyPlanCostItemTypeItemDailyPlanCostItemEmployeeTypeItem
    {
        public string ResourceId { get; set; }
        public double SubmittedDoubletimeHours { get; set; }
        public double SubmittedOvertimeHours { get; set; }
        public double SubmittedStandardHours { get; set; }
        public double ApprovedDoubletimeHours { get; set; }
        public double ApprovedOvertimeHours { get; set; }
        public double ApprovedStandardHours { get; set; }
        public double PlannedDoubletimeHours { get; set; }
        public double PlannedOvertimeHours { get; set; }
        public double PlannedStandardHours { get; set; }
        public int EmployeeId { get; set; }
        public string CraftCode { get; set; }
        public DailyPlanGetResponseItemDailyPlanCostItemTypeItemDailyPlanCostItemEmployeeTypeItemReasonCodesTypeItem[] ReasonCodes { get; set; }
    }

    public class DailyPlanGetResponseItemDailyPlanCostItemTypeItemDailyPlanCostItemEmployeeTypeItemReasonCodesTypeItem
    {
        public string ReasonCodeId { get; set; }
        public string HourType { get; set; }
        public double Hours { get; set; }
        public string[] Premiums { get; set; }
    }

    public class DailyPlanGetResponseItemDailyPlanCostItemTypeItemDailyPlanCostItemEquipmentTypeItem
    {
        public string ResourceId { get; set; }
        public double SubmittedStandardHours { get; set; }
        public double ApprovedStandardHours { get; set; }
        public double PlannedStandardHours { get; set; }
        public int EquipmentId { get; set; }
        public string EquipmentType { get; set; }
        public DailyPlanGetResponseItemDailyPlanCostItemTypeItemDailyPlanCostItemEquipmentTypeItemReasonCodesTypeItem[] ReasonCodes { get; set; }
    }

    public class DailyPlanGetResponseItemDailyPlanCostItemTypeItemDailyPlanCostItemEquipmentTypeItemReasonCodesTypeItem
    {
        public string OperatedEmployeeId { get; set; }
        public string ReasonCodeId { get; set; }
        public double Hours { get; set; }
    }

    public class DailyPlanGetResponseItemDailyPlanCostItemTypeItemDailyPlanCostItemComponentTypeItem
    {
        public string ResourceId { get; set; }
        public int ComponentId { get; set; }
        public int ProjectEstimatingResourceId { get; set; }
        public string ProjectEstimatingResourceSourceSystemId { get; set; }
        public double InstalledQuantity { get; set; }
        public string ComponentType { get; set; }
    }

    public class DailyPlanGetResponseItemDailyPlanNoteTypeItem
    {
        public DailyPlanGetResponseItemDailyPlanNoteTypeItemDailyPlanNoteEmployeeTypeItem[] DailyPlanNoteEmployee { get; set; }
        public DailyPlanGetResponseItemDailyPlanNoteTypeItemDailyPlanNoteEquipmentTypeItem[] DailyPlanNoteEquipment { get; set; }
        public DailyPlanGetResponseItemDailyPlanNoteTypeItemDailyPlanNoteTagTypeItem[] DailyPlanNoteTag { get; set; }
        public DailyPlanGetResponseItemDailyPlanNoteTypeItemDailyPlanNoteTaskTypeItem[] DailyPlanNoteTask { get; set; }
        public DailyPlanGetResponseItemDailyPlanNoteTypeItemDailyPlanNoteMaintenanceTypeItem[] DailyPlanNoteMaintenance { get; set; }
        public int NoteId { get; set; }
        public string Description { get; set; }
    }

    public class DailyPlanGetResponseItemDailyPlanNoteTypeItemDailyPlanNoteEmployeeTypeItem
    {
        public string EmployeeDisplay { get; set; }
    }

    public class DailyPlanGetResponseItemDailyPlanNoteTypeItemDailyPlanNoteEquipmentTypeItem
    {
        public string EquipmentId { get; set; }
    }

    public class DailyPlanGetResponseItemDailyPlanNoteTypeItemDailyPlanNoteTagTypeItem
    {
        public int DailyPlanNoteTagId { get; set; }
        public string TagCode { get; set; }
    }

    public class DailyPlanGetResponseItemDailyPlanNoteTypeItemDailyPlanNoteTaskTypeItem
    {
        public int CostItemId { get; set; }
    }

    public class DailyPlanGetResponseItemDailyPlanNoteTypeItemDailyPlanNoteMaintenanceTypeItem
    {
        public string MaintenanceEquipmentId { get; set; }
        public string WBSPhaseCode { get; set; }
        public string WorkOrderId { get; set; }
    }

    public class DailyPlanGetResponseItemDailyPlanSignOffTypeItem
    {
        public DailyPlanGetResponseItemDailyPlanSignOffTypeItemDailyPlanSignOffResponseTypeItem[] DailyPlanSignOffResponse { get; set; }
        public string EmployeeId { get; set; }
        public string QuestionnaireKey { get; set; }
        public string SignoffEmployeeId { get; set; }
        public string SignoffDate { get; set; }
        public double SignoffStandardHours { get; set; }
        public double SignoffOvertimeHours { get; set; }
        public double SignoffDoubletimeHours { get; set; }
    }

    public class DailyPlanGetResponseItemDailyPlanSignOffTypeItemDailyPlanSignOffResponseTypeItem
    {
        public string EmployeeId { get; set; }
        public string QuestionKey { get; set; }
        public int DailyPlanSignoffResponseId { get; set; }
        public string ResponseKey { get; set; }
        public string ResponseText { get; set; }
    }

    public class DailyPlanGetResponseItemDailyPlanSignInsTypeItem
    {
        public DailyPlanGetResponseItemDailyPlanSignInsTypeItemDailyPlanSignInResponsesTypeItem[] DailyPlanSignInResponses { get; set; }
        public string EmployeeDisplay { get; set; }
        public string SignedInByEmployeeDisplay { get; set; }
        public string SignedInByUserDisplay { get; set; }
        public string SignedInDate { get; set; }
    }

    public class DailyPlanGetResponseItemDailyPlanSignInsTypeItemDailyPlanSignInResponsesTypeItem
    {
        public int DailyPlanSignInResponseId { get; set; }
        public string QuestionKey { get; set; }
        public string QuestionDescription { get; set; }
        public string ResponseKey { get; set; }
        public string ResponseDescription { get; set; }
    }

    public class DailyPlanGetResponseItemDailyPlanBreaksTypeItem
    {
        public string EmployeeDisplay { get; set; }
        public int BreakNumber { get; set; }
        public string BreakStartTime { get; set; }
        public int BreakInMinutes { get; set; }
    }

    public class DailyPlanGetResponseItemExecutersTypeItem
    {
        public string DisplayId { get; set; }
        public string RoleName { get; set; }
    }

    public class DailyPlanGetResponseItemApproversTypeItem
    {
        public string DisplayId { get; set; }
        public string RoleName { get; set; }
    }

    public class DailyPlanGetResponseItemDailyPlanEmployeePayrollIndicatorTypeItem
    {
        public int DailyPlanEmployeePayrollIndicatorId { get; set; }
        public string EmployeeId { get; set; }
        public int PayrollIndicatorId { get; set; }
        public int DailyPlanNoteId { get; set; }
        public int CostItemId { get; set; }
        public string PayrollIdentifier { get; set; }
        public string WBSPhaseCode { get; set; }
        public string EmployeeSourceSystemId { get; set; }
    }

    public class DailyPlanGetResponseItemDailyPlanClientSignOffTypeItem
    {
        public string Name { get; set; }
        public string Email { get; set; }
    }

    public class DailyPlanGetResponseItemDailyPlanMaintenanceTypeItem
    {
        public string EmployeeId { get; set; }
        public string WorkOrderId { get; set; }
        public string WBSPhaseCode { get; set; }
        public string CostItemSourceSystemId { get; set; }
        public double TotalHours { get; set; }
        public string MaintenanceEquipmentId { get; set; }
        public string Segment1 { get; set; }
        public string Segment2 { get; set; }
        public string Segment3 { get; set; }
        public string Segment4 { get; set; }
        public DailyPlanGetResponseItemDailyPlanMaintenanceTypeItemReasonCodesTypeItem[] ReasonCodes { get; set; }
    }

    public class DailyPlanGetResponseItemDailyPlanMaintenanceTypeItemReasonCodesTypeItem
    {
        public string ReasonCodeId { get; set; }
        public string HourType { get; set; }
        public double Hours { get; set; }
        public string[] Premiums { get; set; }
    }

    public class DailyPlanGetResponseItemShiftDetailTypeItem
    {
        public string Shift { get; set; }
        public string ShiftStartDateTime { get; set; }
        public string ShiftEndDateTime { get; set; }
        public DailyPlanGetResponseItemShiftDetailTypeItemEmployeeShiftDetailsTypeItem[] EmployeeShiftDetails { get; set; }
    }

    public class DailyPlanGetResponseItemShiftDetailTypeItemEmployeeShiftDetailsTypeItem
    {
        public string EmployeeId { get; set; }
        public string ShiftStartDateTime { get; set; }
        public string ShiftEndDateTime { get; set; }
    }

    public class TimeCardGetResponseItem
    {
        public int PlanId { get; set; }
        public string PlanDate { get; set; }
        public string PlanTitle { get; set; }
        public string TimecardId { get; set; }
        public string TimeCardType { get; set; }
        public string CreatedDate { get; set; }
        public string ModifiedDate { get; set; }
        public string Executor { get; set; }
        public TimeCardGetResponseItemShiftDetailsTypeItem[] ShiftDetails { get; set; }
        public string Trade { get; set; }
        public string Craft { get; set; }
        public string EmployeeId { get; set; }
        public string EquipmentId { get; set; }
        public string EmployeeReasonCode { get; set; }
        public string EquipmentReasonCode { get; set; }
        public string LaborHourType { get; set; }
        public double EmployeeHours { get; set; }
        public double EquipmentHours { get; set; }
        public int Version { get; set; }
        public string Segment1 { get; set; }
        public string Segment2 { get; set; }
        public string Segment3 { get; set; }
        public string Segment4 { get; set; }
        public string WorkOrder { get; set; }
        public string MaintenanceEquipmentId { get; set; }
        public string OverrideTrade { get; set; }
        public string OverrideCraft { get; set; }
        public string[] Premiums { get; set; }
        public TimeCardGetResponseItemTimeCardCharacteristicsTypeItem[] TimeCardCharacteristics { get; set; }
        public bool AdditionalPayrollInstructionCodeOverridden { get; set; }
        public bool IsActive { get; set; }
    }

    public class TimeCardGetResponseItemShiftDetailsTypeItem
    {
        public string Shift { get; set; }
        public string ShiftStartDateTime { get; set; }
        public string ShiftEndDateTime { get; set; }
        public TimeCardGetResponseItemShiftDetailsTypeItemEmployeeShiftDetailsTypeItem[] EmployeeShiftDetails { get; set; }
    }

    public class TimeCardGetResponseItemShiftDetailsTypeItemEmployeeShiftDetailsTypeItem
    {
        public string ShiftStartDateTime { get; set; }
        public string ShiftEndDateTime { get; set; }
    }

    public class TimeCardGetResponseItemTimeCardCharacteristicsTypeItem
    {
        public string Name { get; set; }
        public string Value { get; set; }
    }

    public class bodyInputItem
    {
        public string TimeCardId { get; set; }
        public string Version { get; set; }
        public string Status { get; set; }
        public string[] Errors { get; set; }
    }

    public class bodyInputItem2
    {
        public string CraftId { get; set; }
        public string CraftDescription { get; set; }
        public string TradeId { get; set; }
        public string CurrencyCode { get; set; }
        public string VendorCode { get; set; }
        public string SourceSystemId { get; set; }
        public string SourceSystemName { get; set; }
        public string UnionSourceSystemId { get; set; }
        public string UoMName { get; set; }
        public bool UseBaseWageFactors { get; set; }
        public double StraightTimeRate { get; set; }
        public double OverTimeFactor { get; set; }
        public double OverTimeRate { get; set; }
        public double DoubleTimeFactor { get; set; }
        public double DoubleTimeRate { get; set; }
        public bool IsActive { get; set; }
    }

    public class bodyInputItem22
    {
        public int DailyPlanId { get; set; }
        public string PlanStatusCode { get; set; }
        public string ModifiedById { get; set; }
        public string ModifiedDate { get; set; }
        public string DtModifiedDate { get; set; }
        public string ReleasedDate { get; set; }
        public string DtReleasedDate { get; set; }
        public string ReleasedById { get; set; }
        public string[] Errors { get; set; }
    }

    public class bodyInputItem222
    {
        public string CraftId { get; set; }
        public string VendorCode { get; set; }
        public string EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsActive { get; set; }
        public string EmployeePIN { get; set; }
        public bool CanReportTime { get; set; }
        public string SourceSystemId { get; set; }
        public string SourceSystemName { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string CurrencyCode { get; set; }
        public string UOMName { get; set; }
        public double StraightTimeRate { get; set; }
        public double OverTimeFactor { get; set; }
        public double OverTimeRate { get; set; }
        public double DoubleTimeFactor { get; set; }
        public double DoubleTimeRate { get; set; }
        public bool UseBaseWageFactors { get; set; }
        public string UnionSourceSystemId { get; set; }
        public string PrimaryCompany { get; set; }
        public string JobTitle { get; set; }
        public string UnionJobTitle { get; set; }
        public string SupervisorId { get; set; }
        public string CountryISOCode { get; set; }
        public string DefaultCostCenterSourceSystemId { get; set; }
        public string AdditionalPayrollInstructionCode { get; set; }
        public bool IsOverrideAdditionalPayrollInstructionCodeAllowed { get; set; }
        public bool IsAvailableWeeklyTimeSheet { get; set; }
    }

    public class bodyInputItem2222
    {
        public string EquipmentSystemStatus { get; set; }
        public string EquipmentNumber { get; set; }
        public string OwnershipType { get; set; }
        public string EquipmentType { get; set; }
        public string VendorCode { get; set; }
        public string SerialNumber { get; set; }
        public string Manufacturer { get; set; }
        public bool Dot { get; set; }
        public string EquipmentDescription { get; set; }
        public bool IsActive { get; set; }
        public string SourceSystemId { get; set; }
        public string SourceSystemName { get; set; }
        public string CurrencyCode { get; set; }
        public string CostCenterSourceSystemId { get; set; }
        public string Location { get; set; }
        public double UnitCost { get; set; }
        public string UoMName { get; set; }
        public bool IsAvailableDailyPlan { get; set; }
    }

    public class bodyInputItem22222
    {
        public string EquipmentCategoryId { get; set; }
        public string Description { get; set; }
        public string SourceSystemId { get; set; }
        public string SourceSystemName { get; set; }
        public bool IsActive { get; set; }
    }

    public class bodyInputItem222222
    {
        public string EquipmentTypeId { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public string EquipmentCategoryId { get; set; }
        public string SourceSystemId { get; set; }
        public string SourceSystemName { get; set; }
        public string VendorCode { get; set; }
        public string CurrencyCode { get; set; }
        public string UoMName { get; set; }
        public double UnitCost { get; set; }
    }

    public class bodyInputItem2222222
    {
        public string RoleName { get; set; }
        public string Description { get; set; }
        public string AdminLevel { get; set; }
        public string SourceSystemId { get; set; }
        public string SourceSystemName { get; set; }
        public bool IsSystem { get; set; }
        public bool IsActive { get; set; }
    }

    public class bodyInputItem22222222
    {
        public string TradeDisplay { get; set; }
        public string TradeDescription { get; set; }
        public string SourceSystemId { get; set; }
        public string SourceSystemName { get; set; }
        public bool IsActive { get; set; }
    }

    public class bodyInputItem222222222
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsActive { get; set; }
        public string Language { get; set; }
        public string DecimalFormat { get; set; }
        public string DateFormat { get; set; }
        public string EmployeeId { get; set; }
        public string VendorCode { get; set; }
        public string SourceSystemName { get; set; }
        public string SourceSystemId { get; set; }
        public string MobileNumber { get; set; }
        public string WorkNumber { get; set; }
        public string DisplayUserId { get; set; }
        public string EmailAddress { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public bool IsExternalUser { get; set; }
    }

    public class bodyInputItem2222222222
    {
        public string RoleName { get; set; }
        public string UserSourceSystemId { get; set; }
        public bool IsActive { get; set; }
        public string ProjectSourceSystemId { get; set; }
        public string OrganizationSourceSystemId { get; set; }
    }

    public class bodyInputItem22222222222
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Company { get; set; }
        public string PrimaryEmail { get; set; }
        public string SecondaryEmail { get; set; }
        public string SourceSystemId { get; set; }
        public string SourceSystemName { get; set; }
        public string ContactTypeReference { get; set; }
        public string LanguagePreference { get; set; }
        public string VendorSourceSystemId { get; set; }
        public string Department { get; set; }
        public string Title { get; set; }
        public string Position { get; set; }
        public string OfficeNumber { get; set; }
        public string MobileNumber { get; set; }
        public string FaxNumber { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
        public string RegionISOCode { get; set; }
        public string CountryISOCode { get; set; }
        public bool IsActive { get; set; }
    }

    public class bodyInputItem222222222222
    {
        public string CostCenterDisplayId { get; set; }
        public string CostCenterDescription { get; set; }
        public string CostCenterTypeDisplayId { get; set; }
        public bool IsActive { get; set; }
        public string SourceSystemId { get; set; }
        public string SourceSystemName { get; set; }
    }

    public class bodyInputItem2222222222222
    {
        public string SourceSystemId { get; set; }
        public string SourceSystemName { get; set; }
        public string DisplayId { get; set; }
        public string AccountCodeOperationType { get; set; }
        public string AccountCodeDescription { get; set; }
        public string ParentAccountCodeSourceSystemId { get; set; }
        public string ReplaceAccountCodeSourceSystemId { get; set; }
        public bool IsActive { get; set; }
        public bool PrimaryAutoQuantity { get; set; }
        public bool SecondaryAutoQuantity { get; set; }
        public bool IsTerminal { get; set; }
        public string PrimaryUOMReference { get; set; }
        public string CurrencyCode { get; set; }
        public string SecondaryUOMReference { get; set; }
        public bool ContributePrimaryToPrimary { get; set; }
        public bool ContributePrimaryToSecondary { get; set; }
        public bool ContributeSecondaryToSecondary { get; set; }
        public bool FlagAsDisabled { get; set; }
        public string Notes { get; set; }
        public string SafetyNotes { get; set; }
        public string EnvironmentalNotes { get; set; }
        public string QualityNotes { get; set; }
        public string AccountCodeTag1 { get; set; }
        public string AccountCodeTag2 { get; set; }
        public string AccountCodeTag3 { get; set; }
        public string AccountCodeTag4 { get; set; }
        public string AccountCodeTag5 { get; set; }
        public string AccountCodeTag6 { get; set; }
        public string AccountCodeTag7 { get; set; }
        public string AccountCodeTag8 { get; set; }
        public string AccountCodeTag9 { get; set; }
        public string AccountCodeTag10 { get; set; }
        public string AccountCodeTag11 { get; set; }
        public string AccountCodeTag12 { get; set; }
        public string AccountCodeTag13 { get; set; }
        public string AccountCodeTag14 { get; set; }
        public string AccountCodeTag15 { get; set; }
        public string AccountCodeTag16 { get; set; }
        public string AccountCodeTag17 { get; set; }
        public string AccountCodeTag18 { get; set; }
        public string AccountCodeTag19 { get; set; }
        public string AccountCodeTag20 { get; set; }
        public string UserDefinedField1 { get; set; }
        public string UserDefinedField2 { get; set; }
        public string UserDefinedField3 { get; set; }
        public string UserDefinedField4 { get; set; }
        public string UserDefinedField5 { get; set; }
        public string UserDefinedField6 { get; set; }
        public string UserDefinedField7 { get; set; }
        public string UserDefinedField8 { get; set; }
        public string UserDefinedField9 { get; set; }
        public string UserDefinedField10 { get; set; }
    }

    public class bodyInputItem22222222222222
    {
        public string DisplayId { get; set; }
        public string Description { get; set; }
        public string Language { get; set; }
        public string SourceSystemId { get; set; }
        public string SourceSystemName { get; set; }
        public bool IsActive { get; set; }
        public bodyInputItemAccountingLedgerTextTypeItem[] AccountingLedgerText { get; set; }
    }

    public class bodyInputItemAccountingLedgerTextTypeItem
    {
        public string Description { get; set; }
        public string Language { get; set; }
        public bool IsActive { get; set; }
    }

    public class bodyInputItem222222222222222
    {
        public string SourceSystemId { get; set; }
    }

    public class bodyInputItem2222222222222222
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Language { get; set; }
        public string SourceSystemId { get; set; }
        public string SourceSystemName { get; set; }
        public bool IsActive { get; set; }
        public bodyInputItemIncoTermTextTypeItem[] IncoTermText { get; set; }
    }

    public class bodyInputItemIncoTermTextTypeItem
    {
        public string Description { get; set; }
        public string Language { get; set; }
        public bool IsActive { get; set; }
    }

    public class bodyInputItem22222222222222222
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string SourceSystemId { get; set; }
        public string SourceSystemName { get; set; }
        public bool IsActive { get; set; }
    }

    public class bodyInputItem222222222222222222
    {
        public string DisplayId { get; set; }
        public string DefaultCharacteristicName { get; set; }
        public bool IsActive { get; set; }
        public string Language { get; set; }
        public string DefaultCharacteristicDescription { get; set; }
        public string CharacteristicTypeReference { get; set; }
        public string MaterialCharacteristicTypeReference { get; set; }
        public string SourceSystemName { get; set; }
        public bodyInputItemMaterialCharacteristicTypeTextTypeItem[] MaterialCharacteristicTypeText { get; set; }
        public bodyInputItemMaterialCharacteristicTypeElementTypeItem[] MaterialCharacteristicTypeElement { get; set; }
    }

    public class bodyInputItemMaterialCharacteristicTypeTextTypeItem
    {
        public bool IsActive { get; set; }
        public string Language { get; set; }
        public string CharacteristicName { get; set; }
        public string CharacteristicDescription { get; set; }
    }

    public class bodyInputItemMaterialCharacteristicTypeElementTypeItem
    {
        public bool IsActive { get; set; }
        public string Language { get; set; }
        public string DefaultElementValue { get; set; }
        public string DefaultCharacteristicDescription { get; set; }
        public bodyInputItemMaterialCharacteristicTypeElementTypeItemMaterialCharacteristicTypeElementTextTypeItem[] MaterialCharacteristicTypeElementText { get; set; }
    }

    public class bodyInputItemMaterialCharacteristicTypeElementTypeItemMaterialCharacteristicTypeElementTextTypeItem
    {
        public bool IsActive { get; set; }
        public string Language { get; set; }
        public string ElementValue { get; set; }
        public string CharacteristicTypeElementDescription { get; set; }
    }

    public class bodyInputItem2222222222222222222
    {
        public string MaterialSetReference { get; set; }
        public string MaterialReference { get; set; }
        public bool IsActive { get; set; }
        public bodyInputItemMaterialClassCharacteristicTypeTypeItem[] MaterialClassCharacteristicType { get; set; }
        public string SourceSystemName { get; set; }
    }

    public class bodyInputItemMaterialClassCharacteristicTypeTypeItem
    {
        public string MaterialSetCharacteristicTypeReference { get; set; }
        public string DefaultPresetValue { get; set; }
        public string Language { get; set; }
        public bodyInputItemMaterialClassCharacteristicTypeTypeItemMaterialClassCharacteristicTypeTextTypeItem[] MaterialClassCharacteristicTypeText { get; set; }
        public bool IsActive { get; set; }
    }

    public class bodyInputItemMaterialClassCharacteristicTypeTypeItemMaterialClassCharacteristicTypeTextTypeItem
    {
        public string Language { get; set; }
        public string PresetValue { get; set; }
        public bool IsActive { get; set; }
    }

    public class bodyInputItem22222222222222222222
    {
        public string GroupDisplayId { get; set; }
        public string MaterialGroupName { get; set; }
        public string Description { get; set; }
        public string ParentMaterialGroupReference { get; set; }
        public string Language { get; set; }
        public bool IsActive { get; set; }
        public string MaterialGroupReference { get; set; }
        public string SourceSystemName { get; set; }
        public bodyInputItemMaterialGroupTextTypeItem[] MaterialGroupText { get; set; }
    }

    public class bodyInputItemMaterialGroupTextTypeItem
    {
        public string Language { get; set; }
        public string MaterialGroupName { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
    }

    public class bodyInputItem222222222222222222222
    {
        public string DisplayId { get; set; }
        public string MaterialTypeReference { get; set; }
        public string MaterialGroupReference { get; set; }
        public string Language { get; set; }
        public string DefaultMaterialName { get; set; }
        public string DefaultMaterialDescription { get; set; }
        public string PurchasingUnitOfMeasure { get; set; }
        public string ManufacturingPartNumber { get; set; }
        public string BaseUnitOfMeasure { get; set; }
        public bool IsActive { get; set; }
        public string AccountCodeReference { get; set; }
        public bodyInputItemMaterialTextTypeItem[] MaterialText { get; set; }
        public bodyInputItemMaterialClassTypeItem[] MaterialClass { get; set; }
        public string MaterialReference { get; set; }
        public string SourceSystemName { get; set; }
    }

    public class bodyInputItemMaterialTextTypeItem
    {
        public string Language { get; set; }
        public string MaterialDescription { get; set; }
        public string MaterialName { get; set; }
        public bool IsActive { get; set; }
    }

    public class bodyInputItemMaterialClassTypeItem
    {
        public string MaterialSetReference { get; set; }
        public string MaterialReference { get; set; }
        public bool IsActive { get; set; }
        public bodyInputItemMaterialClassTypeItemMaterialClassCharacteristicTypeTypeItem[] MaterialClassCharacteristicType { get; set; }
        public string SourceSystemName { get; set; }
    }

    public class bodyInputItemMaterialClassTypeItemMaterialClassCharacteristicTypeTypeItem
    {
        public string MaterialSetCharacteristicTypeReference { get; set; }
        public string DefaultPresetValue { get; set; }
        public string Language { get; set; }
        public bodyInputItemMaterialClassTypeItemMaterialClassCharacteristicTypeTypeItemMaterialClassCharacteristicTypeTextTypeItem[] MaterialClassCharacteristicTypeText { get; set; }
        public bool IsActive { get; set; }
    }

    public class bodyInputItemMaterialClassTypeItemMaterialClassCharacteristicTypeTypeItemMaterialClassCharacteristicTypeTextTypeItem
    {
        public string Language { get; set; }
        public string PresetValue { get; set; }
        public bool IsActive { get; set; }
    }

    public class bodyInputItem2222222222222222222222
    {
        public string MaterialDimensionReference { get; set; }
        public string ParentMaterialSetReference { get; set; }
        public string Language { get; set; }
        public string MaterialSetReference { get; set; }
        public string MaterialSetName { get; set; }
        public string DefaultSetDescription { get; set; }
        public bodyInputItemMaterialSetTextTypeItem[] MaterialSetText { get; set; }
        public bodyInputItemMaterialSetCharacteristicTypeTypeItem[] MaterialSetCharacteristicType { get; set; }
        public bool IsActive { get; set; }
        public string SourceSystemName { get; set; }
    }

    public class bodyInputItemMaterialSetTextTypeItem
    {
        public string Language { get; set; }
        public string SetDescription { get; set; }
        public string MaterialSetName { get; set; }
        public bool IsActive { get; set; }
    }

    public class bodyInputItemMaterialSetCharacteristicTypeTypeItem
    {
        public string MaterialSetCharacteristicTypeReference { get; set; }
        public string MaterialCharacteristicReference { get; set; }
        public string MaterialDimensionReference { get; set; }
        public string DynamicDescriptionPosition { get; set; }
        public string SourceSystemName { get; set; }
        public bool IsActive { get; set; }
    }

    public class bodyInputItem22222222222222222222222
    {
        public string OrganizationName { get; set; }
        public string SourceSystemName { get; set; }
        public string SourceSystemId { get; set; }
        public string OrganizationDescription { get; set; }
        public string ParentOrganization { get; set; }
        public bool IsActive { get; set; }
    }

    public class bodyInputItem222222222222222222222222
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Language { get; set; }
        public string SourceSystemId { get; set; }
        public string SourceSystemName { get; set; }
        public bool IsActive { get; set; }
        public bool IsProgressEstimateNumberRequired { get; set; }
        public bool IsBillingPeriodRequired { get; set; }
        public int DueDays { get; set; }
        public bodyInputItemPaymentTermTextTypeItem[] PaymentTermText { get; set; }
    }

    public class bodyInputItemPaymentTermTextTypeItem
    {
        public string Description { get; set; }
        public string Language { get; set; }
        public bool IsActive { get; set; }
    }

    public class bodyInputItem2222222222222222222222222
    {
        public string ProjectDisplayId { get; set; }
        public string ContactPrimaryEmail { get; set; }
        public string ContactSourceSystemId { get; set; }
        public string ProjectSourceSystemId { get; set; }
        public bool IsActive { get; set; }
    }

    public class bodyInputItem22222222222222222222222222
    {
        public string ProjectId { get; set; }
        public string CraftId { get; set; }
        public double StraightTimeRate { get; set; }
        public double OverTimeFactor { get; set; }
        public double OverTimeRate { get; set; }
        public double DoubleTimeFactor { get; set; }
        public double DoubleTimeRate { get; set; }
        public bool IsActive { get; set; }
        public bool UseBaseWageFactors { get; set; }
    }

    public class bodyInputItem222222222222222222222222222
    {
        public string ProjectEmployeeBillingClass { get; set; }
        public string SourceSystemId { get; set; }
        public string SourceSystemName { get; set; }
        public string ProjectId { get; set; }
        public string Description { get; set; }
        public string VendorSourceSystemId { get; set; }
        public double BillingRateST { get; set; }
        public double BillingRateDT { get; set; }
        public double BillingRateOT { get; set; }
        public bool IsActive { get; set; }
    }

    public class bodyInputItem2222222222222222222222222222
    {
        public string ProjectId { get; set; }
        public string EmployeeId { get; set; }
        public double StraightTimeRate { get; set; }
        public double OverTimeFactor { get; set; }
        public double OverTimeRate { get; set; }
        public double DoubleTimeFactor { get; set; }
        public double DoubleTimeRate { get; set; }
        public string SourceSystemName { get; set; }
        public bool UseBaseWageFactors { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string SourceSystemId { get; set; }
        public string UnionSourceSystemId { get; set; }
        public string UoMName { get; set; }
        public string ProjectCraftSourcesystemId { get; set; }
        public bool IsActive { get; set; }
        public string BillingClass { get; set; }
        public string ProjectEmployeeBillingClassSourceSystemId { get; set; }
    }

    public class bodyInputItem22222222222222222222222222222
    {
        public string ProjectEquipmentBillingClass { get; set; }
        public string SourceSystemId { get; set; }
        public string SourceSystemName { get; set; }
        public string ProjectId { get; set; }
        public string Description { get; set; }
        public string VendorSourceSystemId { get; set; }
        public double BillingRate { get; set; }
        public bool IsActive { get; set; }
    }

    public class bodyInputItem222222222222222222222222222222
    {
        public string ProjectNumber { get; set; }
        public string EquipmentNumber { get; set; }
        public bool IsActive { get; set; }
        public double UnitCost { get; set; }
        public string SourceSystemName { get; set; }
        public string SourceSystemId { get; set; }
        public bool IsAvailableDailyPlan { get; set; }
        public string EquipmentProjectStartDate { get; set; }
        public string EquipmentProjectEndDate { get; set; }
        public string ContractReference { get; set; }
        public string ContractLineNumberReference { get; set; }
        public string ContractURL { get; set; }
        public string BillingClass { get; set; }
        public string ProjectEquipmentBillingClassSourceSystemId { get; set; }
    }

    public class bodyInputItem2222222222222222222222222222222
    {
        public string ProjectId { get; set; }
        public string EquipmentTypeId { get; set; }
        public double UnitCost { get; set; }
        public bool IsActive { get; set; }
    }

    public class bodyInputItem22222222222222222222222222222222
    {
        public string ProjectDisplayId { get; set; }
        public string SourceSystemId { get; set; }
        public string SourceSystemName { get; set; }
        public string ProjectName { get; set; }
        public string OrganizationSourceSystemId { get; set; }
        public string BaseCurrency { get; set; }
        public string TimeZone { get; set; }
        public string ProjectStatusName { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string City { get; set; }
        public string RegionISOCode { get; set; }
        public string CountryISOCode { get; set; }
        public string ZipCode { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string Notes { get; set; }
        public bool IsActive { get; set; }
        public double OriginalContractAmount { get; set; }
        public string ContractNumber { get; set; }
        public string DateProjectStarted { get; set; }
        public string ContractDate { get; set; }
        public string OriginalContractCompletionDate { get; set; }
        public int OriginalDuration { get; set; }
        public string ForecastStartDate { get; set; }
        public string ForecastCompletionDate { get; set; }
        public int ForecastDuration { get; set; }
        public string ForecastRevisedCompletionDate { get; set; }
        public int ForecastExtensionsReductions { get; set; }
        public int ForecastRevisedDuration { get; set; }
        public string ContractRevisedCompletionDate { get; set; }
        public int ContractExtensionsReductions { get; set; }
        public int ContractRevisedDuration { get; set; }
        public string CertificateOfSubstantialCompletionExpectedDate { get; set; }
        public string CertificateOfSubstantialCompletionAwardedDate { get; set; }
        public string CertificateOfFinalCompletionExpectedDate { get; set; }
        public string CertificateOfFinalCompletionAwardedDate { get; set; }
        public string CompanyLegalName { get; set; }
        public bodyInputItemProjectAttributesTypeItem[] ProjectAttributes { get; set; }
        public string[] Markets { get; set; }
    }

    public class bodyInputItemProjectAttributesTypeItem
    {
        public string AttributeName { get; set; }
        public string AttributeSourceSystemId { get; set; }
        public string AttributeValue { get; set; }
    }

    public class bodyInputItem222222222222222222222222222222222
    {
        public string ProjectSourceSystemId { get; set; }
        public string ProjectSourceSystemName { get; set; }
        public string ProjectDisplayId { get; set; }
        public bodyInputItemGlobalOptionsType GlobalOptions { get; set; }
        public bodyInputItemProjectInformationTagsType ProjectInformationTags { get; set; }
        public bodyInputItemCustomListsTypeItem[] CustomLists { get; set; }
        public bodyInputItemFuelTypesTypeItem[] FuelTypes { get; set; }
    }

    public class bodyInputItemGlobalOptionsType
    {
        public string CostItemIntegrationBehavior { get; set; }
        public bool IsAdvancedWorkAndSchedulingFeaturesEnabled { get; set; }
        public bool IsTemplateProject { get; set; }
        public bool IsValidateEquipmentToProjectCurrency { get; set; }
    }

    public class bodyInputItemProjectInformationTagsType
    {
        public string ProjectInformationTag1 { get; set; }
        public string ProjectInformationTag2 { get; set; }
        public string ProjectInformationTag3 { get; set; }
        public string ProjectInformationTag4 { get; set; }
        public string ProjectInformationTag5 { get; set; }
        public string ProjectInformationTag6 { get; set; }
        public string ProjectInformationTag7 { get; set; }
        public string ProjectInformationTag8 { get; set; }
        public string ProjectInformationTag9 { get; set; }
        public string ProjectInformationTag10 { get; set; }
        public string ProjectInformationTag11 { get; set; }
        public string ProjectInformationTag12 { get; set; }
        public string ProjectInformationTag13 { get; set; }
        public string ProjectInformationTag14 { get; set; }
        public string ProjectInformationTag15 { get; set; }
    }

    public class bodyInputItemCustomListsTypeItem
    {
        public string ListName { get; set; }
        public string[] FieldValues { get; set; }
    }

    public class bodyInputItemFuelTypesTypeItem
    {
        public bool IsEstimatingResourceMapped { get; set; }
        public string FuelTypeDisplay { get; set; }
        public string UOMSourceSystemId { get; set; }
        public string CurrencyCode { get; set; }
        public double UnitCost { get; set; }
        public string AccountCodeReference { get; set; }
        public bool IsActive { get; set; }
        public string SourceSystemId { get; set; }
        public string SourceSystemName { get; set; }
    }

    public class bodyInputItem2222222222222222222222222222222222
    {
        public string ProjectDisplayId { get; set; }
        public string VendorCode { get; set; }
        public string VendorSourceSystemId { get; set; }
        public string ProjectSourceSystemId { get; set; }
        public bool IsActive { get; set; }
    }

    public class bodyInputItem22222222222222222222222222222222222
    {
        public string UnionDisplayId { get; set; }
        public string UnionDescription { get; set; }
        public bool IsActive { get; set; }
        public string SourceSystemId { get; set; }
        public string SourceSystemName { get; set; }
    }

    public class bodyInputItem222222222222222222222222222222222222
    {
        public string SourceSystemId { get; set; }
        public string SourceSystemName { get; set; }
        public string VendorCode { get; set; }
        public string VendorDescription { get; set; }
        public bool IsActive { get; set; }
        public string AlternateName { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
        public string RegionISOCode { get; set; }
        public string CountryISOCode { get; set; }
        public string TelephoneNumber { get; set; }
        public string FaxNumber { get; set; }
        public string DefaultPaymentTerms { get; set; }
        public string DefaultINCOTerms { get; set; }
        public string DefaultINCOTermsLocation { get; set; }
        public string VendorTypeReference { get; set; }
        public string DefaultCurrencyCode { get; set; }
        public string PreferredLanguage { get; set; }
        public string VendorTaxJurisdiction { get; set; }
        public string Status { get; set; }
        public string VendorTaxId { get; set; }
        public bodyInputItemVendorAddressesTypeItem[] VendorAddresses { get; set; }
    }

    public class bodyInputItemVendorAddressesTypeItem
    {
        public string VendorAddressType { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
        public string RegionISOCode { get; set; }
        public string CountryISOCode { get; set; }
        public string TelephoneNumber { get; set; }
        public string FaxNumber { get; set; }
    }

    public class AccountCodeGetResponseItem
    {
        public string SourceSystemId { get; set; }
        public string SourceSystemName { get; set; }
        public string DisplayId { get; set; }
        public string AccountCodeOperationType { get; set; }
        public string AccountCodeDescription { get; set; }
        public string ParentAccountCodeSourceSystemId { get; set; }
        public string ReplaceAccountCodeSourceSystemId { get; set; }
        public bool IsActive { get; set; }
        public bool PrimaryAutoQuantity { get; set; }
        public bool SecondaryAutoQuantity { get; set; }
        public bool IsTerminal { get; set; }
        public string PrimaryUOMReference { get; set; }
        public string CurrencyCode { get; set; }
        public string SecondaryUOMReference { get; set; }
        public bool ContributePrimaryToPrimary { get; set; }
        public bool ContributePrimaryToSecondary { get; set; }
        public bool ContributeSecondaryToSecondary { get; set; }
        public bool FlagAsDisabled { get; set; }
        public string Notes { get; set; }
        public string SafetyNotes { get; set; }
        public string EnvironmentalNotes { get; set; }
        public string QualityNotes { get; set; }
        public string AccountCodeTag1 { get; set; }
        public string AccountCodeTag2 { get; set; }
        public string AccountCodeTag3 { get; set; }
        public string AccountCodeTag4 { get; set; }
        public string AccountCodeTag5 { get; set; }
        public string AccountCodeTag6 { get; set; }
        public string AccountCodeTag7 { get; set; }
        public string AccountCodeTag8 { get; set; }
        public string AccountCodeTag9 { get; set; }
        public string AccountCodeTag10 { get; set; }
        public string AccountCodeTag11 { get; set; }
        public string AccountCodeTag12 { get; set; }
        public string AccountCodeTag13 { get; set; }
        public string AccountCodeTag14 { get; set; }
        public string AccountCodeTag15 { get; set; }
        public string AccountCodeTag16 { get; set; }
        public string AccountCodeTag17 { get; set; }
        public string AccountCodeTag18 { get; set; }
        public string AccountCodeTag19 { get; set; }
        public string AccountCodeTag20 { get; set; }
        public string UserDefinedField1 { get; set; }
        public string UserDefinedField2 { get; set; }
        public string UserDefinedField3 { get; set; }
        public string UserDefinedField4 { get; set; }
        public string UserDefinedField5 { get; set; }
        public string UserDefinedField6 { get; set; }
        public string UserDefinedField7 { get; set; }
        public string UserDefinedField8 { get; set; }
        public string UserDefinedField9 { get; set; }
        public string UserDefinedField10 { get; set; }
    }

    public class ContactsGetResponseItem
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Company { get; set; }
        public string PrimaryEmail { get; set; }
        public string SecondaryEmail { get; set; }
        public string SourceSystemId { get; set; }
        public string SourceSystemName { get; set; }
        public string ContactTypeReference { get; set; }
        public string LanguagePreference { get; set; }
        public string VendorSourceSystemId { get; set; }
        public string Department { get; set; }
        public string Title { get; set; }
        public string Position { get; set; }
        public string OfficeNumber { get; set; }
        public string MobileNumber { get; set; }
        public string FaxNumber { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
        public string RegionISOCode { get; set; }
        public string CountryISOCode { get; set; }
        public bool IsActive { get; set; }
    }

    public class CountryGetResponseItem
    {
        public string Name { get; set; }
        public string ISOCode { get; set; }
        public CountryGetResponseItemCountryTranslationsTypeItem[] CountryTranslations { get; set; }
    }

    public class CountryGetResponseItemCountryTranslationsTypeItem
    {
        public string LanguageDisplayId { get; set; }
        public string CountryName { get; set; }
    }

    public class CraftsGetResponseItem
    {
        public string CraftId { get; set; }
        public string CraftDescription { get; set; }
        public string TradeId { get; set; }
        public string CurrencyCode { get; set; }
        public string VendorCode { get; set; }
        public string UnionSourceSystemId { get; set; }
        public string UOMName { get; set; }
        public bool UseBaseWageFactors { get; set; }
        public double StraightTimeRate { get; set; }
        public double OverTimeFactor { get; set; }
        public double OverTimeRate { get; set; }
        public double DoubleTimeFactor { get; set; }
        public double DoubleTimeRate { get; set; }
        public string SourceSystemId { get; set; }
        public string SourceSystemName { get; set; }
        public bool IsActive { get; set; }
    }

    public class CurrenciesGetResponseItem
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Entity { get; set; }
        public string Symbol { get; set; }
        public string CurrencySubunitName { get; set; }
        public string CurrencyPluralName { get; set; }
        public string CurrencySubunitPluralName { get; set; }
    }

    public class EmployeesGetResponseItem
    {
        public string CraftId { get; set; }
        public string VendorCode { get; set; }
        public string EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsActive { get; set; }
        public string EmployeePIN { get; set; }
        public bool CanReportTime { get; set; }
        public string SourceSystemId { get; set; }
        public string SourceSystemName { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string CurrencyCode { get; set; }
        public string UOMName { get; set; }
        public double StraightTimeRate { get; set; }
        public double OverTimeFactor { get; set; }
        public double OverTimeRate { get; set; }
        public double DoubleTimeFactor { get; set; }
        public double DoubleTimeRate { get; set; }
        public bool UseBaseWageFactors { get; set; }
        public string UnionSourceSystemId { get; set; }
        public string PrimaryCompany { get; set; }
        public string JobTitle { get; set; }
        public string UnionJobTitle { get; set; }
        public string SupervisorId { get; set; }
        public string CountryISOCode { get; set; }
        public string DefaultCostCenterSourceSystemId { get; set; }
        public string AdditionalPayrollInstructionCode { get; set; }
        public bool IsOverrideAdditionalPayrollInstructionCodeAllowed { get; set; }
        public bool IsAvailableWeeklyTimeSheet { get; set; }
    }

    public class EquipmentGetResponseItem
    {
        public string EquipmentSystemStatus { get; set; }
        public string EquipmentNumber { get; set; }
        public string OwnershipType { get; set; }
        public string EquipmentType { get; set; }
        public string VendorCode { get; set; }
        public string SerialNumber { get; set; }
        public string Manufacturer { get; set; }
        public bool Dot { get; set; }
        public string EquipmentDescription { get; set; }
        public bool IsActive { get; set; }
        public string SourceSystemId { get; set; }
        public string SourceSystemName { get; set; }
        public string CurrencyCode { get; set; }
        public string CostCenterSourceSystemId { get; set; }
        public string Location { get; set; }
        public double UnitCost { get; set; }
        public string UoMName { get; set; }
        public bool IsAvailableDailyPlan { get; set; }
    }

    public class EquipmentCategoriesGetResponseItem
    {
        public string EquipmentCategoryId { get; set; }
        public string Description { get; set; }
        public string SourceSystemId { get; set; }
        public string SourceSystemName { get; set; }
        public bool IsActive { get; set; }
    }

    public class EquipmentTypesGetResponseItem
    {
        public string EquipmentTypeId { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public string EquipmentCategoryId { get; set; }
        public string SourceSystemId { get; set; }
        public string SourceSystemName { get; set; }
        public string VendorCode { get; set; }
        public string CurrencyCode { get; set; }
        public double UnitCost { get; set; }
        public string UoMName { get; set; }
    }

    public class LanguagesGetResponseItem
    {
        public string DisplayId { get; set; }
        public string Name { get; set; }
    }

    public class MarketsGetResponseItem
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string SourceSystemId { get; set; }
        public string SourceSystemName { get; set; }
        public bool IsActive { get; set; }
    }

    public class OrganizationsGetResponseItem
    {
        public string OrganizationName { get; set; }
        public string SourceSystemName { get; set; }
        public string SourceSystemId { get; set; }
        public string OrganizationDescription { get; set; }
        public string ParentOrganization { get; set; }
        public bool IsActive { get; set; }
    }

    public class ProjectContactsGetResponseItem
    {
        public string ProjectDisplayId { get; set; }
        public string ContactPrimaryEmail { get; set; }
        public JToken ContactSourceSystemId { get; set; }
        public JToken ProjectSourceSystemId { get; set; }
        public bool IsActive { get; set; }
    }

    public class ProjectEmployeeBillingClassesGetResponseItem
    {
        public string ProjectEmployeeBillingClass { get; set; }
        public string SourceSystemId { get; set; }
        public string SourceSystemName { get; set; }
        public string ProjectId { get; set; }
        public string Description { get; set; }
        public string VendorSourceSystemId { get; set; }
        public double BillingRateST { get; set; }
        public double BillingRateDT { get; set; }
        public double BillingRateOT { get; set; }
        public bool IsActive { get; set; }
    }

    public class ProjectEmployeesGetResponseItem
    {
        public string ProjectId { get; set; }
        public string EmployeeId { get; set; }
        public double StraightTimeRate { get; set; }
        public double OverTimeFactor { get; set; }
        public double OverTimeRate { get; set; }
        public double DoubleTimeFactor { get; set; }
        public double DoubleTimeRate { get; set; }
        public string SourceSystemName { get; set; }
        public bool UseBaseWageFactors { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string SourceSystemId { get; set; }
        public string UoMName { get; set; }
        public string ProjectCraftSourcesystemId { get; set; }
        public bool IsActive { get; set; }
        public string BillingClass { get; set; }
        public string ProjectEmployeeBillingClassSourceSystemId { get; set; }
    }

    public class ProjectEquipmentBillingClassesGetResponseItem
    {
        public string ProjectEquipmentBillingClass { get; set; }
        public string SourceSystemId { get; set; }
        public string SourceSystemName { get; set; }
        public string ProjectId { get; set; }
        public string Description { get; set; }
        public string VendorSourceSystemId { get; set; }
        public double BillingRate { get; set; }
        public bool IsActive { get; set; }
    }

    public class ProjectEquipmentsGetResponseItem
    {
        public string ProjectNumber { get; set; }
        public string EquipmentNumber { get; set; }
        public bool IsActive { get; set; }
        public double UnitCost { get; set; }
        public string SourceSystemName { get; set; }
        public string SourceSystemId { get; set; }
        public string EquipmentProjectStartDate { get; set; }
        public string EquipmentProjectEndDate { get; set; }
        public bool IsAvailableDailyPlan { get; set; }
        public string ContractReference { get; set; }
        public string ContractLineNumberReference { get; set; }
        public string ContractURL { get; set; }
        public string BillingClass { get; set; }
        public string ProjectEquipmentBillingClassSourceSystemId { get; set; }
    }

    public class ProjectsGetResponseItem
    {
        public string ProjectDisplayId { get; set; }
        public string SourceSystemId { get; set; }
        public string SourceSystemName { get; set; }
        public string ProjectName { get; set; }
        public string OrganizationSourceSystemId { get; set; }
        public string BaseCurrency { get; set; }
        public string TimeZone { get; set; }
        public string ProjectStatusName { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string City { get; set; }
        public string RegionISOCode { get; set; }
        public string CountryISOCode { get; set; }
        public string ZipCode { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string Notes { get; set; }
        public bool IsActive { get; set; }
        public double OriginalContractAmount { get; set; }
        public string ContractNumber { get; set; }
        public string DateProjectStarted { get; set; }
        public string ContractDate { get; set; }
        public string OriginalContractCompletionDate { get; set; }
        public int OriginalDuration { get; set; }
        public string ForecastStartDate { get; set; }
        public string ForecastCompletionDate { get; set; }
        public int ForecastDuration { get; set; }
        public string CertificateOfSubstantialCompletionExpectedDate { get; set; }
        public string ForecastRevisedCompletionDate { get; set; }
        public int ForecastExtensionsReductions { get; set; }
        public int ForecastRevisedDuration { get; set; }
        public string ContractRevisedCompletionDate { get; set; }
        public int ContractExtensionsReductions { get; set; }
        public int ContractRevisedDuration { get; set; }
        public string CertificateOfSubstantialCompletionAwardedDate { get; set; }
        public string CertificateOfFinalCompletionExpectedDate { get; set; }
        public string CertificateOfFinalCompletionAwardedDate { get; set; }
        public string CompanyLegalName { get; set; }
        public ProjectsGetResponseItemProjectAttributesTypeItem[] ProjectAttributes { get; set; }
        public string[] Markets { get; set; }
    }

    public class ProjectsGetResponseItemProjectAttributesTypeItem
    {
        public string AttributeName { get; set; }
        public string AttributeSourceSystemId { get; set; }
        public string AttributeValue { get; set; }
    }

    public class ProjectSettingsGetResponseItem
    {
        public string ProjectSourceSystemId { get; set; }
        public string ProjectSourceSystemName { get; set; }
        public string ProjectDisplayId { get; set; }
        public ProjectSettingsGetResponseItemGlobalOptionsType GlobalOptions { get; set; }
        public ProjectSettingsGetResponseItemProjectInformationTagsType ProjectInformationTags { get; set; }
        public ProjectSettingsGetResponseItemCustomListsTypeItem[] CustomLists { get; set; }
        public ProjectSettingsGetResponseItemFuelTypesTypeItem[] FuelTypes { get; set; }
    }

    public class ProjectSettingsGetResponseItemGlobalOptionsType
    {
        public string CostItemIntegrationBehavior { get; set; }
        public bool IsAdvancedWorkAndSchedulingFeaturesEnabled { get; set; }
        public bool IsTemplateProject { get; set; }
        public bool IsValidateEquipmentToProjectCurrency { get; set; }
    }

    public class ProjectSettingsGetResponseItemProjectInformationTagsType
    {
        public string ProjectInformationTag1 { get; set; }
        public string ProjectInformationTag2 { get; set; }
        public string ProjectInformationTag3 { get; set; }
        public string ProjectInformationTag4 { get; set; }
        public string ProjectInformationTag5 { get; set; }
        public string ProjectInformationTag6 { get; set; }
        public string ProjectInformationTag7 { get; set; }
        public string ProjectInformationTag8 { get; set; }
        public string ProjectInformationTag9 { get; set; }
        public string ProjectInformationTag10 { get; set; }
        public string ProjectInformationTag11 { get; set; }
        public string ProjectInformationTag12 { get; set; }
        public string ProjectInformationTag13 { get; set; }
        public string ProjectInformationTag14 { get; set; }
        public string ProjectInformationTag15 { get; set; }
    }

    public class ProjectSettingsGetResponseItemCustomListsTypeItem
    {
        public string ListName { get; set; }
        public string[] FieldValues { get; set; }
    }

    public class ProjectSettingsGetResponseItemFuelTypesTypeItem
    {
        public bool IsEstimatingResourceMapped { get; set; }
        public string FuelTypeDisplay { get; set; }
        public string UOMSourceSystemId { get; set; }
        public string CurrencyCode { get; set; }
        public double UnitCost { get; set; }
        public string AccountCodeReference { get; set; }
        public bool IsActive { get; set; }
        public string SourceSystemId { get; set; }
        public string SourceSystemName { get; set; }
    }

    public class ProjectVendorsGetResponseItem
    {
        public string ProjectDisplayId { get; set; }
        public string VendorCode { get; set; }
        public string VendorSourceSystemId { get; set; }
        public string ProjectSourceSystemId { get; set; }
        public bool IsActive { get; set; }
    }

    public class RegionsGetResponseItem
    {
        public string ISOCode { get; set; }
        public string Name { get; set; }
        public string CountryISOCode { get; set; }
        public RegionsGetResponseItemTranslationsTypeItem[] Translations { get; set; }
    }

    public class RegionsGetResponseItemTranslationsTypeItem
    {
        public string LanguageDisplayId { get; set; }
        public string RegionName { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum includeTranslationInput
    {
        False,
        True
    }

    public class RolesGetResponseItem
    {
        public string RoleName { get; set; }
        public string Description { get; set; }
        public string AdminLevel { get; set; }
        public string SourceSystemId { get; set; }
        public string SourceSystemName { get; set; }
        public bool IsSystem { get; set; }
        public bool IsActive { get; set; }
    }

    public class TimeZoneGetResponseItem
    {
        public string Name { get; set; }
        public string TimeZoneSerialized { get; set; }
        public TimeZoneGetResponseItemTimeZoneTranslationsTypeItem[] TimeZoneTranslations { get; set; }
    }

    public class TimeZoneGetResponseItemTimeZoneTranslationsTypeItem
    {
        public string LanguageDisplayId { get; set; }
        public string TimeZoneName { get; set; }
    }

    public class TradesGetResponseItem
    {
        public string TradeDisplay { get; set; }
        public string TradeDescription { get; set; }
        public bool IsActive { get; set; }
        public string SourceSystemId { get; set; }
        public string SourceSystemName { get; set; }
    }

    public class UOMsGetResponseItem
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string MeasurementTypeName { get; set; }
        public string MeasurementSystemName { get; set; }
        public string AlternateUomSourceSystemId { get; set; }
        public double ConversionFactor { get; set; }
        public string BaseUOMName { get; set; }
        public string DefaultAlternateMeasurement { get; set; }
        public bool IsBaseUoM { get; set; }
        public string SKFUOM { get; set; }
        public string SourceSystemId { get; set; }
        public string SourceSystemName { get; set; }
        public bool IsActive { get; set; }
    }

    public class UsersGetResponseItem
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public bool IsActive { get; set; }
        public string DisplayUserId { get; set; }
        public string WorkNumber { get; set; }
        public string MobileNumber { get; set; }
        public string SourceSystemId { get; set; }
        public string SourceSystemName { get; set; }
        public string VendorCode { get; set; }
        public string EmployeeId { get; set; }
        public string Language { get; set; }
        public bool IsExternalUser { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
    }

    public class VendorsGetResponseItem
    {
        public string SourceSystemId { get; set; }
        public string SourceSystemName { get; set; }
        public string VendorCode { get; set; }
        public string VendorDescription { get; set; }
        public bool IsActive { get; set; }
        public string AlternateName { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
        public string RegionISOCode { get; set; }
        public string CountryISOCode { get; set; }
        public string TelephoneNumber { get; set; }
        public string FaxNumber { get; set; }
        public string DefaultPaymentTerms { get; set; }
        public string DefaultINCOTerms { get; set; }
        public string DefaultINCOTermsLocation { get; set; }
        public string VendorTypeReference { get; set; }
        public string DefaultCurrencyCode { get; set; }
        public string PreferredLanguage { get; set; }
        public string VendorTaxJurisdiction { get; set; }
        public string Status { get; set; }
        public string VendorTaxId { get; set; }
        public VendorsGetResponseItemVendorAddressesTypeItem[] VendorAddresses { get; set; }
    }

    public class VendorsGetResponseItemVendorAddressesTypeItem
    {
        public string VendorAddressType { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
        public string RegionISOCode { get; set; }
        public string CountryISOCode { get; set; }
        public string TelephoneNumber { get; set; }
        public string FaxNumber { get; set; }
    }

    public class bodyInputItem2222222222222222222222222222222222222
    {
        public string ContractReference { get; set; }
        public string CurrentValue { get; set; }
        public string CurrentValueProjectCurrency { get; set; }
        public string LogToken { get; set; }
        public string Status { get; set; }
        public bodyInputItemLoggerTypeItem[] Logger { get; set; }
        public string ContractTypeReference { get; set; }
        public string VendorReference { get; set; }
        public string PurchasingOrganizationReference { get; set; }
        public string PurchasingGroupReference { get; set; }
        public string LegalEntityReference { get; set; }
        public string PaymentTermReference { get; set; }
        public string ProjectCurrencyReference { get; set; }
        public string CurrencyReference { get; set; }
        public string INCOTerms { get; set; }
        public string AgreementNumber { get; set; }
        public string AgreementValue { get; set; }
        public string PurchaseOrderNumber { get; set; }
        public string PurchaseOrderValue { get; set; }
        public string CreatedByReference { get; set; }
        public string CreatedDate { get; set; }
        public string IsExternalCreatedPurchaseOrder { get; set; }
        public string Description { get; set; }
        public string EffectiveDate { get; set; }
        public string ContractStatus { get; set; }
        public string ContractSubTypeReference { get; set; }
        public string InvoicePlanIndicator { get; set; }
        public string Discipline { get; set; }
        public string ScopeOfContract { get; set; }
        public string RetentionPercent { get; set; }
        public string LiquidatedDamageOverallCap { get; set; }
        public string HarmonizedTariffSchedule { get; set; }
        public string CountryOfOrigin { get; set; }
        public string RequsitionNumber { get; set; }
        public string RequsitionValue { get; set; }
        public string CustomList1 { get; set; }
        public string CustomList2 { get; set; }
        public string CustomField1 { get; set; }
        public string CustomField2 { get; set; }
        public string CustomField3 { get; set; }
        public string CustomField4 { get; set; }
        public string CustomField5 { get; set; }
        public string CustomField6 { get; set; }
        public string CustomField7 { get; set; }
        public string CustomField8 { get; set; }
        public string CustomField9 { get; set; }
        public string CustomField10 { get; set; }
        public bodyInputItemShippingAddressTypeItem[] ShippingAddress { get; set; }
        public bodyInputItemContractDetailResponseTypeItem[] ContractDetailResponse { get; set; }
    }

    public class bodyInputItemLoggerTypeItem
    {
        public string Level { get; set; }
        public string Message { get; set; }
    }

    public class bodyInputItemShippingAddressTypeItem
    {
        public string StreetName { get; set; }

        [JsonProperty("DisplayID")]
        public string DisplayId { get; set; }
        public string CityName { get; set; }
        public string Region { get; set; }
        public string CountryCode { get; set; }
        public string PostalCode { get; set; }
        public string TaxJurisdiction { get; set; }
    }

    public class bodyInputItemContractDetailResponseTypeItem
    {
        public string ContractDetailReference { get; set; }
        public string GrossAmount { get; set; }
        public string GrossAmountProjectCurrency { get; set; }
        public string NetValuewithoutTax { get; set; }
        public string NetValueWithoutTaxProjectCurrency { get; set; }
        public string TaxTotal { get; set; }
        public string TaxTotalProjectCurrency { get; set; }
        public string ContractDetailType { get; set; }
        public string Description { get; set; }
        public string MaterialReference { get; set; }
        public string MaterialGroupReference { get; set; }
        public string CreatedByReference { get; set; }
        public string Quantity { get; set; }
        public string UnitOfMeasureReference { get; set; }
        public string NetPrice { get; set; }
        public string UnitsPerPrice { get; set; }
        public string PriceUnitOfMeasureReference { get; set; }
        public string TaxCodeReference { get; set; }
        public string DeliveryDate { get; set; }
        public string OrderDeliveryTolerance { get; set; }
        public string PlantReference { get; set; }
        public string StorageLocation { get; set; }
        public string DeletionIndicator { get; set; }
        public string DeliveryCompleteIndicator { get; set; }
        public string InvoicePlanIndicator { get; set; }
        public string ReturnPOFlag { get; set; }
        public string MaterialCharacteristicReference { get; set; }
        public string AccountAssignmentCategory { get; set; }
        public string CDSSplitMethod { get; set; }
        public string Comments { get; set; }
        public string RetentionPercent { get; set; }
        public string FairMarketValue { get; set; }
        public string EquipmentPrefix { get; set; }
        public string RentalType { get; set; }
        public string NAICScode { get; set; }
        public string WBSCategoryReference { get; set; }
        public string NoFurtherInvoiceIndicator { get; set; }
        public string GoodsReceiptStatus { get; set; }
        public string IsTaxable { get; set; }
        public string LongDescription { get; set; }
        public string CountryOfOrigin { get; set; }
        public string LowerLimit { get; set; }
        public string UpperLimit { get; set; }
        public string ValidThroughDate { get; set; }
        public string CountrofOrigin { get; set; }
        public string DiversityParticipationPercent { get; set; }
        public string DiversityParticipationValue { get; set; }
        public string HarmonizedTariffSchedule { get; set; }
        public string CustomList1 { get; set; }
        public string CustomList2 { get; set; }
        public string CustomField1 { get; set; }
        public string CustomField2 { get; set; }
        public string CustomField3 { get; set; }
        public string CustomField4 { get; set; }
        public string CustomField5 { get; set; }
        public bodyInputItemContractDetailResponseTypeItemContractDetailTaxTypeItem[] ContractDetailTax { get; set; }
        public bodyInputItemContractDetailResponseTypeItemMaterialCharacteristicTypeItem[] MaterialCharacteristic { get; set; }
        public bodyInputItemContractDetailResponseTypeItemShippingAddressTypeItem[] ShippingAddress { get; set; }
        public bodyInputItemContractDetailResponseTypeItemContractDetailCostItemTypeItem[] ContractDetailCostItem { get; set; }
    }

    public class bodyInputItemContractDetailResponseTypeItemContractDetailTaxTypeItem
    {
        public string TaxCode { get; set; }
        public string Description { get; set; }
        public string TaxAmount { get; set; }
        public string TaxRate { get; set; }
        public string CurrencyReference { get; set; }
        public string TaxAmountProjectCurrency { get; set; }
        public string ProjectCurrencyReference { get; set; }
        public string SourceSystemId { get; set; }
    }

    public class bodyInputItemContractDetailResponseTypeItemMaterialCharacteristicTypeItem
    {
        public string MaterialCharacteristicType { get; set; }
        public string MaterialCharacteristicValue { get; set; }
    }

    public class bodyInputItemContractDetailResponseTypeItemShippingAddressTypeItem
    {
        public string StreetName { get; set; }

        [JsonProperty("DisplayID")]
        public string DisplayId { get; set; }
        public string CityName { get; set; }
        public string Region { get; set; }
        public string CountryCode { get; set; }
        public string PostalCode { get; set; }
        public string TaxJurisdiction { get; set; }
    }

    public class bodyInputItemContractDetailResponseTypeItemContractDetailCostItemTypeItem
    {
        public string SplitByValue { get; set; }
        public string AccountAssignmentLineNumber { get; set; }
        public string AccountAssignmentNumber { get; set; }
        public string GLAccountReference { get; set; }
        public string CreatedByReference { get; set; }
    }

    public class bodyInputItem22222222222222222222222222222222222222
    {
        public string PayRequestReference { get; set; }
        public string CreatedDate { get; set; }
        public string PayRequestStatus { get; set; }
        public string ContractReference { get; set; }
        public string LogToken { get; set; }
        public bodyInputItemLoggerTypeItem[] Logger { get; set; }
        public bodyInputItemInvoiceReceiptTypeItem[] InvoiceReceipt { get; set; }
    }

    public class bodyInputItemInvoiceReceiptTypeItem
    {
        public string InvoiceStatus { get; set; }
        public string InvoiceStatusDescription { get; set; }
        public string InvoiceReceiptReference { get; set; }
        public string SourceSystemInvoiceNumber { get; set; }
        public string PostingDate { get; set; }
        public string Amount { get; set; }
        public string CurrencyReference { get; set; }
        public string ProjectCurrencyAmount { get; set; }
        public string ProjectCurrencyReference { get; set; }
        public string VendorInvoiceReference { get; set; }
        public string InvoicingPartyReference { get; set; }
        public string InvoicingPartyName { get; set; }
        public string VendorInvoiceDate { get; set; }
        public string DocumentYear { get; set; }
        public string DebitCreditIndicator { get; set; }
        public string PaymentMethod { get; set; }
        public string PaymentBlock { get; set; }
        public string RetentionReleasedAmount { get; set; }
        public string ProgressEstimateNumber { get; set; }
        public string BillingPeriod { get; set; }
        public string IsCancelled { get; set; }
        public bodyInputItemInvoiceReceiptTypeItemInvoiceReceiptItemTypeItem[] InvoiceReceiptItem { get; set; }
        public bodyInputItemInvoiceReceiptTypeItemInvoiceReceiptPaymentTypeItem[] InvoiceReceiptPayment { get; set; }
    }

    public class bodyInputItemInvoiceReceiptTypeItemInvoiceReceiptItemTypeItem
    {
        public string InvoiceItemNumber { get; set; }
        public string ContractDetailReference { get; set; }
        public string InvoiceLineQuantity { get; set; }
        public string RetentionHeldAmountProjectCurrency { get; set; }
        public string RetentionHeldAmount { get; set; }
        public string ContractLineAmount { get; set; }
        public string ContractLineAmountWithoutTax { get; set; }
        public string ContractLineAmountTax { get; set; }
        public bodyInputItemInvoiceReceiptTypeItemInvoiceReceiptItemTypeItemContractLineAmountTaxDetailTypeItem[] ContractLineAmountTaxDetail { get; set; }
        public string InvoiceLineUoM { get; set; }
        public string ProjectCurrencyLineAmount { get; set; }
        public string ProjectCurrencyLineAmountWithoutTax { get; set; }
        public string ProjectCurrencyLineAmountTax { get; set; }
        public string ProjectCurrencyReference { get; set; }
        public bodyInputItemInvoiceReceiptTypeItemInvoiceReceiptItemTypeItemProjectCurrencyLineAmountTaxDetailTypeItem[] ProjectCurrencyLineAmountTaxDetail { get; set; }
        public string DebitCreditIndicator { get; set; }
    }

    public class bodyInputItemInvoiceReceiptTypeItemInvoiceReceiptItemTypeItemContractLineAmountTaxDetailTypeItem
    {
        public string TaxType { get; set; }
        public string Description { get; set; }
        public string TaxAmount { get; set; }
        public string TaxRate { get; set; }
    }

    public class bodyInputItemInvoiceReceiptTypeItemInvoiceReceiptItemTypeItemProjectCurrencyLineAmountTaxDetailTypeItem
    {
        public string TaxType { get; set; }
        public string Description { get; set; }
        public string TaxAmount { get; set; }
        public string TaxRate { get; set; }
    }

    public class bodyInputItemInvoiceReceiptTypeItemInvoiceReceiptPaymentTypeItem
    {
        public string PaymentReference { get; set; }
        public string PaymentDate { get; set; }
        public string PaymentPaid { get; set; }
        public string CurrencyReference { get; set; }
        public string PaymentIdentification { get; set; }
        public string PaymentVoidDate { get; set; }
        public string ProjectCurrencyPaymentAmount { get; set; }
        public string ProjectCurrencyReference { get; set; }
    }

    public class bodyInputItem222222222222222222222222222222222222222
    {
        public string DocumentReference { get; set; }
        public string DocumentYear { get; set; }
        public string SourceSystemId { get; set; }
        public string LogToken { get; set; }
        public bodyInputItemLoggerTypeItem[] Logger { get; set; }
        public string GoodsReceiptRequestReference { get; set; }
        public string DocumentDate { get; set; }
        public string PostingDate { get; set; }
        public string EntryDate { get; set; }
        public string CreatedByReference { get; set; }
        public string Reference { get; set; }
        public string DocumentText { get; set; }
        public string BillOfLading { get; set; }
        public bodyInputItemGoodsReceiptItemTypeItem[] GoodsReceiptItem { get; set; }
    }

    public class bodyInputItemGoodsReceiptItemTypeItem
    {
        public string GoodsReceiptStatus { get; set; }
        public string ContractTypeReference { get; set; }
        public string DocumentItemReference { get; set; }
        public string ContractReference { get; set; }
        public string ContractDetailReference { get; set; }
        public string MovementType { get; set; }
        public string MaterialReference { get; set; }
        public string PlantReference { get; set; }
        public string StorageLocationRefrence { get; set; }
        public string BatchNumber { get; set; }
        public string DebitCreditIndicator { get; set; }
        public string ContractCurrency { get; set; }
        public string AmountInContractCurrency { get; set; }
        public string AmountWithoutTaxInContractCurrency { get; set; }
        public string TaxAmountInContractCurrency { get; set; }
        public bodyInputItemGoodsReceiptItemTypeItemContractLineAmountTaxDetailTypeItem[] ContractLineAmountTaxDetail { get; set; }
        public string ProjectCurrency { get; set; }
        public string AmountInProjectCurrency { get; set; }
        public string AmountWithoutTaxInProjectCurrency { get; set; }
        public string TaxAmountInProjectCurrency { get; set; }
        public bodyInputItemGoodsReceiptItemTypeItemProjectCurrencyLineAmountTaxDetailTypeItem[] ProjectCurrencyLineAmountTaxDetail { get; set; }
        public string ReceivedQuantity { get; set; }
        public string ReceivedUOM { get; set; }
        public string ReceivedQuantityInBaseUOM { get; set; }
        public string BaseUOM { get; set; }
        public string ReceivedQuantityInPOPriceUOM { get; set; }
        public string POPriceUOM { get; set; }
        public string ReceivedQuantityInPOUOM { get; set; }
        public string POUOM { get; set; }
        public string DeliveryCompletedIndicator { get; set; }
        public string Text { get; set; }
        public string GoodsRecipientUserReference { get; set; }
        public string CostCenter { get; set; }
        public string OrderNumber { get; set; }
        public string MovementIndicator { get; set; }
        public string GRNonValuatedIndicator { get; set; }
        public string ReasonForMovement { get; set; }
        public string ProfitCenter { get; set; }
        public string CostItemReference { get; set; }
        public string AccountingLedgerReference { get; set; }
        public string StockTypeIndicator { get; set; }
        public string OverDeliveryToleranceIndicator { get; set; }
    }

    public class bodyInputItemGoodsReceiptItemTypeItemContractLineAmountTaxDetailTypeItem
    {
        public string TaxType { get; set; }
        public string Description { get; set; }
        public string TaxAmount { get; set; }
        public string TaxRate { get; set; }
    }

    public class bodyInputItemGoodsReceiptItemTypeItemProjectCurrencyLineAmountTaxDetailTypeItem
    {
        public string TaxType { get; set; }
        public string Description { get; set; }
        public string TaxAmount { get; set; }
        public string TaxRate { get; set; }
    }

    public class bodyInputItem2222222222222222222222222222222222222222
    {
        public string ContractReference { get; set; }
        public string CurrentValue { get; set; }
        public string CurrentValueProjectCurrency { get; set; }
        public string LogToken { get; set; }
        public string Status { get; set; }
        public bodyInputItemLoggerTypeItem[] Logger { get; set; }
        public string ContractTypeReference { get; set; }
        public string VendorReference { get; set; }
        public string PurchasingOrganizationReference { get; set; }
        public string PurchasingGroupReference { get; set; }
        public string LegalEntityReference { get; set; }
        public string PaymentTermReference { get; set; }
        public string ProjectCurrencyReference { get; set; }
        public string CurrencyReference { get; set; }
        public string INCOTerms { get; set; }
        public string AgreementNumber { get; set; }
        public string AgreementValue { get; set; }
        public string PurchaseOrderNumber { get; set; }
        public string PurchaseOrderValue { get; set; }
        public string CreatedByReference { get; set; }
        public string CreatedDate { get; set; }
        public bodyInputItemContractDetailResponseTypeItem2[] ContractDetailResponse { get; set; }
    }

    public class bodyInputItemContractDetailResponseTypeItem2
    {
        public string ContractDetailReference { get; set; }
        public string GrossAmount { get; set; }
        public string GrossAmountProjectCurrency { get; set; }
        public string NetValuewithoutTax { get; set; }
        public string NetValueWithoutTaxProjectCurrency { get; set; }
        public string TaxTotal { get; set; }
        public string TaxTotalProjectCurrency { get; set; }
        public string ContractDetailType { get; set; }
        public string Description { get; set; }
        public string MaterialReference { get; set; }
        public string MaterialGroupReference { get; set; }
        public string CreatedByReference { get; set; }
        public string Quantity { get; set; }
        public string UnitOfMeasureReference { get; set; }
        public string NetPrice { get; set; }
        public string UnitsPerPrice { get; set; }
        public string PriceUnitOfMeasureReference { get; set; }
        public string TaxCodeReference { get; set; }
        public string DeliveryDate { get; set; }
        public string OrderDeliveryTolerance { get; set; }
        public string PlantReference { get; set; }
        public string StorageLocation { get; set; }
        public string DeletionIndicator { get; set; }
        public string DeliveryCompleteIndicator { get; set; }
        public string InvoicePlanIndicator { get; set; }
        public string ReturnPOFlag { get; set; }
        public string MaterialCharacteristicReference { get; set; }
        public string AccountAssignmentCategory { get; set; }
        public string CDSSplitMethod { get; set; }
        public string Comments { get; set; }
        public string RetentionPercent { get; set; }
        public string FairMarketValue { get; set; }
        public string EquipmentPrefix { get; set; }
        public string RentalType { get; set; }
        public string NAICScode { get; set; }
        public string WBSCategoryReference { get; set; }
        public string NoFurtherInvoiceIndicator { get; set; }
        public string GoodsReceiptStatus { get; set; }
        public bodyInputItemContractDetailResponseTypeItemContractDetailTaxTypeItem[] ContractDetailTax { get; set; }
        public bodyInputItemContractDetailResponseTypeItemMaterialCharacteristicTypeItem[] MaterialCharacteristic { get; set; }
        public bodyInputItemContractDetailResponseTypeItemShippingAddressTypeItem2[] ShippingAddress { get; set; }
        public bodyInputItemContractDetailResponseTypeItemContractDetailCostItemTypeItem2[] ContractDetailCostItem { get; set; }
    }

    public class bodyInputItemContractDetailResponseTypeItemShippingAddressTypeItem2
    {
        public string StreetName { get; set; }
        public string CityName { get; set; }
        public string Region { get; set; }
        public string CountryCode { get; set; }
        public string PostalCode { get; set; }
        public string TaxJurisdiction { get; set; }
    }

    public class bodyInputItemContractDetailResponseTypeItemContractDetailCostItemTypeItem2
    {
        public string SplitByValue { get; set; }
        public string AccountAssignmentLineNumber { get; set; }
        public string CostCenterReference { get; set; }
        public string AccountingLedgerReference { get; set; }
        public string CostItemSourceSystemId { get; set; }
        public string CostItemReference { get; set; }
        public string DeletionIndicator { get; set; }
        public string CreatedByReference { get; set; }
    }

    public class bodyInputItem22222222222222222222222222222222222222222
    {
        public string PlantReference { get; set; }
        public string StorageLocationReference { get; set; }
        public string Description { get; set; }
        public string SourceSystemId { get; set; }
    }

    public class bodyInputItem222222222222222222222222222222222222222222
    {
        public string SourceSystemId { get; set; }
        public string ProjectSourceSystemId { get; set; }
        public string StreetName { get; set; }
        public string CityName { get; set; }
        public string Region { get; set; }
        public string CountryCode { get; set; }
        public string PostalCode { get; set; }
        public string TaxJurisdiction { get; set; }
        public string IsDefault { get; set; }
        public string IsActive { get; set; }
    }

    public class bodyInputItem2222222222222222222222222222222222222222222
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string CountryReference { get; set; }
        public string Currency { get; set; }
        public string Language { get; set; }
    }

    public class bodyInputItem22222222222222222222222222222222222222222222
    {
        public string SourceSystemId { get; set; }
        public string ProjectSourceSystemId { get; set; }
        public string LegalEntitySourceSystemId { get; set; }
        public string PlantSourceSystemId { get; set; }
        public string IsGRValuated { get; set; }
        public string IsSplitAccountAllowed { get; set; }
        public string IsActive { get; set; }
    }

    public class bodyInputItem222222222222222222222222222222222222222222222
    {
        public string SourceSystemId { get; set; }
        public string ProjectSourceSystemId { get; set; }
        public string PlantSourceSystemId { get; set; }
        public string StorageLocationSourceSystemId { get; set; }
        public string IsDefault { get; set; }
        public string IsActive { get; set; }
    }

    public class bodyInputItem2222222222222222222222222222222222222222222222
    {
        public string PlantReference { get; set; }
        public string Description { get; set; }
        public string LegalEntityReference { get; set; }
        public string IsActive { get; set; }
    }

    public class bodyInputItem22222222222222222222222222222222222222222222222
    {
        public string ProjectReference { get; set; }
        public string ContractReference { get; set; }
        public string LogToken { get; set; }
        public string Status { get; set; }
        public bodyInputItemLoggerTypeItem[] Logger { get; set; }
        public bodyInputItemContractEquipmentDetailTypeItem[] ContractEquipmentDetail { get; set; }
    }

    public class bodyInputItemContractEquipmentDetailTypeItem
    {
        public string ContractDetailReference { get; set; }
        public string EquipmentSourceSystemId { get; set; }
    }

    public class bodyInputItem222222222222222222222222222222222222222222222222
    {
        public string AccrualRequestReference { get; set; }
        public string AccrualRequestStatus { get; set; }
        public string ContractReference { get; set; }
        public string LogToken { get; set; }
        public bodyInputItemLoggerTypeItem[] Logger { get; set; }
        public string AccrualSourceSystemId { get; set; }
        public string ContractDetailReference { get; set; }
        public string DisplayId { get; set; }
    }

    public class bodyInputItem2222222222222222222222222222222222222222222222222
    {
        public string ProjectReference { get; set; }
        public string ContractReference { get; set; }
        public string InvoiceNumber { get; set; }
        public string InvoiceStatus { get; set; }
        public string InvoiceDate { get; set; }
        public string InvoiceAmount { get; set; }
        public string InvoiceTax { get; set; }
        public string RecordId { get; set; }
        public string SourceSystemId { get; set; }
        public string SourceSystemName { get; set; }
        public string InvoiceURL { get; set; }
        public bodyInputItemInvoiceTaxDetailTypeItem[] InvoiceTaxDetail { get; set; }
    }

    public class bodyInputItemInvoiceTaxDetailTypeItem
    {
        public string TaxType { get; set; }
        public string TaxAmount { get; set; }
    }

    public class ImportActualsInput
    {
        public string ProjectDisplay { get; set; }
        public ImportActualsInputActualsTypeItem[] Actuals { get; set; }
        public string SourceSystemId { get; set; }
        public string SourceSystemName { get; set; }
    }

    public class ImportActualsInputActualsTypeItem
    {
        public string CBSPositionCode { get; set; }
        public ImportActualsInputActualsTypeItemCostType Cost { get; set; }
        public string EquipmentHours { get; set; }
        public string ManHours { get; set; }
        public string Notes { get; set; }
        public string PhaseCode { get; set; }
        public string PostingDate { get; set; }
        public string Quantity { get; set; }
    }

    public class ImportActualsInputActualsTypeItemCostType
    {
        public ImportActualsInputActualsTypeItemCostTypeCostCategoriesTypeItem[] CostCategories { get; set; }
    }

    public class ImportActualsInputActualsTypeItemCostTypeCostCategoriesTypeItem
    {
        public string Amount { get; set; }
        public string Name { get; set; }
    }

    public class bodyInputItem22222222222222222222222222222222222222222222222222
    {
        public string ProjectDisplay { get; set; }
        public bodyInputItemActualsTypeItem[] Actuals { get; set; }
        public string SourceSystemId { get; set; }
        public string SourceSystemName { get; set; }
    }

    public class bodyInputItemActualsTypeItem
    {
        public string CBSPositionCode { get; set; }
        public bodyInputItemActualsTypeItemCostType Cost { get; set; }
        public string EquipmentHours { get; set; }
        public string ManHours { get; set; }
        public string Notes { get; set; }
        public string PhaseCode { get; set; }
        public string PostingDate { get; set; }
        public string Quantity { get; set; }
    }

    public class bodyInputItemActualsTypeItemCostType
    {
        public bodyInputItemActualsTypeItemCostTypeCostCategoriesTypeItem[] CostCategories { get; set; }
    }

    public class bodyInputItemActualsTypeItemCostTypeCostCategoriesTypeItem
    {
        public string Amount { get; set; }
        public string Name { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Ineight;

    public partial class WorkflowManagedActions
    {
        public IneightActions Ineight(string connectionId) => new IneightActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public IneightTriggers Ineight(string connectionId) => new IneightTriggers(connectionId);
    }
}