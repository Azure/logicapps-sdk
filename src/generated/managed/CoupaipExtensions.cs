//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Coupaip
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CoupaipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "coupaip")]
        public IBodyWorkflowAction<Account[], ApiConnectionActionConfiguration> AcctGetAccounts(Expression<Func<string>> accessToken, Expression<Func<string>> codeContains = null, Expression<Func<string>> nameContains = null, Expression<Func<string>> createdAtGt = null, Expression<Func<string>> updatedAtGt = null, Expression<Func<string>> updatedAtLt = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null, Expression<Func<ReturnObjectInput>> returnObject = null, Expression<Func<string>> filter = null, Expression<Func<string>> orderBy = null, Expression<Func<DirInput>> dir = null)
        {
            var __workflow_accessToken = WorkflowExpression.Compile(accessToken, nameof(accessToken), required: true);
            var __workflow_codeContains = WorkflowExpression.Compile(codeContains, nameof(codeContains), required: false);
            var __workflow_nameContains = WorkflowExpression.Compile(nameContains, nameof(nameContains), required: false);
            var __workflow_createdAtGt = WorkflowExpression.Compile(createdAtGt, nameof(createdAtGt), required: false);
            var __workflow_updatedAtGt = WorkflowExpression.Compile(updatedAtGt, nameof(updatedAtGt), required: false);
            var __workflow_updatedAtLt = WorkflowExpression.Compile(updatedAtLt, nameof(updatedAtLt), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            var __workflow_returnObject = WorkflowExpression.Compile(returnObject, nameof(returnObject), required: false);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_orderBy = WorkflowExpression.Compile(orderBy, nameof(orderBy), required: false);
            var __workflow_dir = WorkflowExpression.Compile(dir, nameof(dir), required: false);
            return new DeferredBodyAction<Account[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/accounts";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_codeContains != null)
                    callPayload.Queries["code[contains]"] = ExpressionConverter.Convert(__workflow_codeContains);
                if (__workflow_nameContains != null)
                    callPayload.Queries["name[contains]"] = ExpressionConverter.Convert(__workflow_nameContains);
                if (__workflow_createdAtGt != null)
                    callPayload.Queries["created-at[gt]"] = ExpressionConverter.Convert(__workflow_createdAtGt);
                if (__workflow_updatedAtGt != null)
                    callPayload.Queries["updated-at[gt]"] = ExpressionConverter.Convert(__workflow_updatedAtGt);
                if (__workflow_updatedAtLt != null)
                    callPayload.Queries["updated-at[lt]"] = ExpressionConverter.Convert(__workflow_updatedAtLt);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                if (__workflow_returnObject != null)
                    callPayload.Queries["return_object"] = ExpressionConverter.Convert(__workflow_returnObject);
                if (__workflow_filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_orderBy != null)
                    callPayload.Queries["order_by"] = ExpressionConverter.Convert(__workflow_orderBy);
                if (__workflow_dir != null)
                    callPayload.Queries["dir"] = ExpressionConverter.Convert(__workflow_dir);
                callPayload.Headers["Access-Token"] = ExpressionConverter.Convert(__workflow_accessToken);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return new ApiConnectionAction<Account[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "coupaip")]
        public IBodyWorkflowAction<Account, ApiConnectionActionConfiguration> AcctGetAccountById(Expression<Func<string>> accessToken, Expression<Func<int>> id, Expression<Func<ReturnObjectInput>> returnObject = null, Expression<Func<string>> fields = null, Expression<Func<string>> filter = null)
        {
            var __workflow_accessToken = WorkflowExpression.Compile(accessToken, nameof(accessToken), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_returnObject = WorkflowExpression.Compile(returnObject, nameof(returnObject), required: false);
            var __workflow_fields = WorkflowExpression.Compile(fields, nameof(fields), required: false);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            return new DeferredBodyAction<Account, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/accounts/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_returnObject != null)
                    callPayload.Queries["return_object"] = ExpressionConverter.Convert(__workflow_returnObject);
                if (__workflow_fields != null)
                    callPayload.Queries["fields"] = ExpressionConverter.Convert(__workflow_fields);
                if (__workflow_filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(__workflow_filter);
                callPayload.Headers["Access-Token"] = ExpressionConverter.Convert(__workflow_accessToken);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return new ApiConnectionAction<Account>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "coupaip")]
        public IBodyWorkflowAction<AddrGetAddressByIdAddressResponse[], ApiConnectionActionConfiguration> AddrGetAddresses(Expression<Func<string>> accessToken, Expression<Func<string>> nameContains = null, Expression<Func<string>> locationCodeContains = null, Expression<Func<string>> cityContains = null, Expression<Func<string>> postalCodeContains = null, Expression<Func<string>> countryNameContains = null, Expression<Func<string>> createdAtGt = null, Expression<Func<string>> updatedAtGt = null, Expression<Func<string>> updatedAtLt = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null, Expression<Func<ReturnObjectInput>> returnObject = null, Expression<Func<string>> filter = null, Expression<Func<string>> orderBy = null, Expression<Func<DirInput>> dir = null)
        {
            var __workflow_accessToken = WorkflowExpression.Compile(accessToken, nameof(accessToken), required: true);
            var __workflow_nameContains = WorkflowExpression.Compile(nameContains, nameof(nameContains), required: false);
            var __workflow_locationCodeContains = WorkflowExpression.Compile(locationCodeContains, nameof(locationCodeContains), required: false);
            var __workflow_cityContains = WorkflowExpression.Compile(cityContains, nameof(cityContains), required: false);
            var __workflow_postalCodeContains = WorkflowExpression.Compile(postalCodeContains, nameof(postalCodeContains), required: false);
            var __workflow_countryNameContains = WorkflowExpression.Compile(countryNameContains, nameof(countryNameContains), required: false);
            var __workflow_createdAtGt = WorkflowExpression.Compile(createdAtGt, nameof(createdAtGt), required: false);
            var __workflow_updatedAtGt = WorkflowExpression.Compile(updatedAtGt, nameof(updatedAtGt), required: false);
            var __workflow_updatedAtLt = WorkflowExpression.Compile(updatedAtLt, nameof(updatedAtLt), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            var __workflow_returnObject = WorkflowExpression.Compile(returnObject, nameof(returnObject), required: false);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_orderBy = WorkflowExpression.Compile(orderBy, nameof(orderBy), required: false);
            var __workflow_dir = WorkflowExpression.Compile(dir, nameof(dir), required: false);
            return new DeferredBodyAction<AddrGetAddressByIdAddressResponse[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/addresses";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_nameContains != null)
                    callPayload.Queries["name[contains]"] = ExpressionConverter.Convert(__workflow_nameContains);
                if (__workflow_locationCodeContains != null)
                    callPayload.Queries["location-code[contains]"] = ExpressionConverter.Convert(__workflow_locationCodeContains);
                if (__workflow_cityContains != null)
                    callPayload.Queries["city[contains]"] = ExpressionConverter.Convert(__workflow_cityContains);
                if (__workflow_postalCodeContains != null)
                    callPayload.Queries["postal-code[contains]"] = ExpressionConverter.Convert(__workflow_postalCodeContains);
                if (__workflow_countryNameContains != null)
                    callPayload.Queries["country[name][contains]"] = ExpressionConverter.Convert(__workflow_countryNameContains);
                if (__workflow_createdAtGt != null)
                    callPayload.Queries["created-at[gt]"] = ExpressionConverter.Convert(__workflow_createdAtGt);
                if (__workflow_updatedAtGt != null)
                    callPayload.Queries["updated-at[gt]"] = ExpressionConverter.Convert(__workflow_updatedAtGt);
                if (__workflow_updatedAtLt != null)
                    callPayload.Queries["updated-at[lt]"] = ExpressionConverter.Convert(__workflow_updatedAtLt);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                if (__workflow_returnObject != null)
                    callPayload.Queries["return_object"] = ExpressionConverter.Convert(__workflow_returnObject);
                if (__workflow_filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_orderBy != null)
                    callPayload.Queries["order_by"] = ExpressionConverter.Convert(__workflow_orderBy);
                if (__workflow_dir != null)
                    callPayload.Queries["dir"] = ExpressionConverter.Convert(__workflow_dir);
                callPayload.Headers["Access-Token"] = ExpressionConverter.Convert(__workflow_accessToken);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return new ApiConnectionAction<AddrGetAddressByIdAddressResponse[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "coupaip")]
        public IBodyWorkflowAction<AddrGetAddressByIdAddressResponse, ApiConnectionActionConfiguration> AddrGetAddressById(Expression<Func<string>> accessToken, Expression<Func<int>> id, Expression<Func<ReturnObjectInput>> returnObject = null, Expression<Func<string>> fields = null, Expression<Func<string>> filter = null)
        {
            var __workflow_accessToken = WorkflowExpression.Compile(accessToken, nameof(accessToken), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_returnObject = WorkflowExpression.Compile(returnObject, nameof(returnObject), required: false);
            var __workflow_fields = WorkflowExpression.Compile(fields, nameof(fields), required: false);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            return new DeferredBodyAction<AddrGetAddressByIdAddressResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/addresses/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_returnObject != null)
                    callPayload.Queries["return_object"] = ExpressionConverter.Convert(__workflow_returnObject);
                if (__workflow_fields != null)
                    callPayload.Queries["fields"] = ExpressionConverter.Convert(__workflow_fields);
                if (__workflow_filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(__workflow_filter);
                callPayload.Headers["Access-Token"] = ExpressionConverter.Convert(__workflow_accessToken);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return new ApiConnectionAction<AddrGetAddressByIdAddressResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "coupaip")]
        public IBodyWorkflowAction<Approval[], ApiConnectionActionConfiguration> ApprvlGetApprovals(Expression<Func<string>> accessToken, Expression<Func<ApprvlGetApprovalsStatusInInput>> statusIn = null, Expression<Func<string>> approverLoginContains = null, Expression<Func<string>> createdAtGt = null, Expression<Func<string>> updatedAtGt = null, Expression<Func<string>> updatedAtLt = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null, Expression<Func<ReturnObjectInput>> returnObject = null, Expression<Func<string>> filter = null, Expression<Func<string>> orderBy = null, Expression<Func<DirInput>> dir = null)
        {
            var __workflow_accessToken = WorkflowExpression.Compile(accessToken, nameof(accessToken), required: true);
            var __workflow_statusIn = WorkflowExpression.Compile(statusIn, nameof(statusIn), required: false);
            var __workflow_approverLoginContains = WorkflowExpression.Compile(approverLoginContains, nameof(approverLoginContains), required: false);
            var __workflow_createdAtGt = WorkflowExpression.Compile(createdAtGt, nameof(createdAtGt), required: false);
            var __workflow_updatedAtGt = WorkflowExpression.Compile(updatedAtGt, nameof(updatedAtGt), required: false);
            var __workflow_updatedAtLt = WorkflowExpression.Compile(updatedAtLt, nameof(updatedAtLt), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            var __workflow_returnObject = WorkflowExpression.Compile(returnObject, nameof(returnObject), required: false);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_orderBy = WorkflowExpression.Compile(orderBy, nameof(orderBy), required: false);
            var __workflow_dir = WorkflowExpression.Compile(dir, nameof(dir), required: false);
            return new DeferredBodyAction<Approval[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/approvals";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_statusIn != null)
                    callPayload.Queries["status[in]"] = ExpressionConverter.Convert(__workflow_statusIn);
                if (__workflow_approverLoginContains != null)
                    callPayload.Queries["approver[login][contains]"] = ExpressionConverter.Convert(__workflow_approverLoginContains);
                if (__workflow_createdAtGt != null)
                    callPayload.Queries["created-at[gt]"] = ExpressionConverter.Convert(__workflow_createdAtGt);
                if (__workflow_updatedAtGt != null)
                    callPayload.Queries["updated-at[gt]"] = ExpressionConverter.Convert(__workflow_updatedAtGt);
                if (__workflow_updatedAtLt != null)
                    callPayload.Queries["updated-at[lt]"] = ExpressionConverter.Convert(__workflow_updatedAtLt);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                if (__workflow_returnObject != null)
                    callPayload.Queries["return_object"] = ExpressionConverter.Convert(__workflow_returnObject);
                if (__workflow_filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_orderBy != null)
                    callPayload.Queries["order_by"] = ExpressionConverter.Convert(__workflow_orderBy);
                if (__workflow_dir != null)
                    callPayload.Queries["dir"] = ExpressionConverter.Convert(__workflow_dir);
                callPayload.Headers["Access-Token"] = ExpressionConverter.Convert(__workflow_accessToken);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return new ApiConnectionAction<Approval[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "coupaip")]
        public IBodyWorkflowAction<Approval, ApiConnectionActionConfiguration> ApprvlGetApprovalById(Expression<Func<string>> accessToken, Expression<Func<int>> id, Expression<Func<ReturnObjectInput>> returnObject = null, Expression<Func<string>> fields = null, Expression<Func<string>> filter = null)
        {
            var __workflow_accessToken = WorkflowExpression.Compile(accessToken, nameof(accessToken), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_returnObject = WorkflowExpression.Compile(returnObject, nameof(returnObject), required: false);
            var __workflow_fields = WorkflowExpression.Compile(fields, nameof(fields), required: false);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            return new DeferredBodyAction<Approval, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/approvals/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_returnObject != null)
                    callPayload.Queries["return_object"] = ExpressionConverter.Convert(__workflow_returnObject);
                if (__workflow_fields != null)
                    callPayload.Queries["fields"] = ExpressionConverter.Convert(__workflow_fields);
                if (__workflow_filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(__workflow_filter);
                callPayload.Headers["Access-Token"] = ExpressionConverter.Convert(__workflow_accessToken);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return new ApiConnectionAction<Approval>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "coupaip")]
        public IBodyWorkflowAction<BudgetLine[], ApiConnectionActionConfiguration> BudgLineGetBudgetLines(Expression<Func<string>> accessToken, Expression<Func<string>> nameContains = null, Expression<Func<bool>> active = null, Expression<Func<string>> createdAtGt = null, Expression<Func<string>> updatedAtGt = null, Expression<Func<string>> updatedAtLt = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null, Expression<Func<ReturnObjectInput>> returnObject = null, Expression<Func<string>> filter = null, Expression<Func<string>> orderBy = null, Expression<Func<DirInput>> dir = null)
        {
            var __workflow_accessToken = WorkflowExpression.Compile(accessToken, nameof(accessToken), required: true);
            var __workflow_nameContains = WorkflowExpression.Compile(nameContains, nameof(nameContains), required: false);
            var __workflow_active = WorkflowExpression.Compile(active, nameof(active), required: false);
            var __workflow_createdAtGt = WorkflowExpression.Compile(createdAtGt, nameof(createdAtGt), required: false);
            var __workflow_updatedAtGt = WorkflowExpression.Compile(updatedAtGt, nameof(updatedAtGt), required: false);
            var __workflow_updatedAtLt = WorkflowExpression.Compile(updatedAtLt, nameof(updatedAtLt), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            var __workflow_returnObject = WorkflowExpression.Compile(returnObject, nameof(returnObject), required: false);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_orderBy = WorkflowExpression.Compile(orderBy, nameof(orderBy), required: false);
            var __workflow_dir = WorkflowExpression.Compile(dir, nameof(dir), required: false);
            return new DeferredBodyAction<BudgetLine[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/budget_lines";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_nameContains != null)
                    callPayload.Queries["name[contains]"] = ExpressionConverter.Convert(__workflow_nameContains);
                if (__workflow_active != null)
                    callPayload.Queries["active"] = ExpressionConverter.Convert(__workflow_active);
                if (__workflow_createdAtGt != null)
                    callPayload.Queries["created-at[gt]"] = ExpressionConverter.Convert(__workflow_createdAtGt);
                if (__workflow_updatedAtGt != null)
                    callPayload.Queries["updated-at[gt]"] = ExpressionConverter.Convert(__workflow_updatedAtGt);
                if (__workflow_updatedAtLt != null)
                    callPayload.Queries["updated-at[lt]"] = ExpressionConverter.Convert(__workflow_updatedAtLt);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                if (__workflow_returnObject != null)
                    callPayload.Queries["return_object"] = ExpressionConverter.Convert(__workflow_returnObject);
                if (__workflow_filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_orderBy != null)
                    callPayload.Queries["order_by"] = ExpressionConverter.Convert(__workflow_orderBy);
                if (__workflow_dir != null)
                    callPayload.Queries["dir"] = ExpressionConverter.Convert(__workflow_dir);
                callPayload.Headers["Access-Token"] = ExpressionConverter.Convert(__workflow_accessToken);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return new ApiConnectionAction<BudgetLine[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "coupaip")]
        public IBodyWorkflowAction<BudgetLine, ApiConnectionActionConfiguration> BudgLineGetBudgetLineById(Expression<Func<string>> accessToken, Expression<Func<int>> id, Expression<Func<ReturnObjectInput>> returnObject = null, Expression<Func<string>> fields = null, Expression<Func<string>> filter = null)
        {
            var __workflow_accessToken = WorkflowExpression.Compile(accessToken, nameof(accessToken), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_returnObject = WorkflowExpression.Compile(returnObject, nameof(returnObject), required: false);
            var __workflow_fields = WorkflowExpression.Compile(fields, nameof(fields), required: false);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            return new DeferredBodyAction<BudgetLine, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/budget_lines/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_returnObject != null)
                    callPayload.Queries["return_object"] = ExpressionConverter.Convert(__workflow_returnObject);
                if (__workflow_fields != null)
                    callPayload.Queries["fields"] = ExpressionConverter.Convert(__workflow_fields);
                if (__workflow_filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(__workflow_filter);
                callPayload.Headers["Access-Token"] = ExpressionConverter.Convert(__workflow_accessToken);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return new ApiConnectionAction<BudgetLine>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "coupaip")]
        public IBodyWorkflowAction<Contract[], ApiConnectionActionConfiguration> CntrGetContracts(Expression<Func<string>> accessToken, Expression<Func<CntrGetContractsStatusInInput>> statusIn = null, Expression<Func<string>> numberContains = null, Expression<Func<string>> nameContains = null, Expression<Func<string>> supplierNameContains = null, Expression<Func<string>> startDateGt = null, Expression<Func<string>> endDateLt = null, Expression<Func<string>> createdAtGt = null, Expression<Func<string>> updatedAtGt = null, Expression<Func<string>> updatedAtLt = null, Expression<Func<string>> supplierId = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null, Expression<Func<ReturnObjectInput>> returnObject = null, Expression<Func<string>> filter = null, Expression<Func<string>> orderBy = null, Expression<Func<DirInput>> dir = null)
        {
            var __workflow_accessToken = WorkflowExpression.Compile(accessToken, nameof(accessToken), required: true);
            var __workflow_statusIn = WorkflowExpression.Compile(statusIn, nameof(statusIn), required: false);
            var __workflow_numberContains = WorkflowExpression.Compile(numberContains, nameof(numberContains), required: false);
            var __workflow_nameContains = WorkflowExpression.Compile(nameContains, nameof(nameContains), required: false);
            var __workflow_supplierNameContains = WorkflowExpression.Compile(supplierNameContains, nameof(supplierNameContains), required: false);
            var __workflow_startDateGt = WorkflowExpression.Compile(startDateGt, nameof(startDateGt), required: false);
            var __workflow_endDateLt = WorkflowExpression.Compile(endDateLt, nameof(endDateLt), required: false);
            var __workflow_createdAtGt = WorkflowExpression.Compile(createdAtGt, nameof(createdAtGt), required: false);
            var __workflow_updatedAtGt = WorkflowExpression.Compile(updatedAtGt, nameof(updatedAtGt), required: false);
            var __workflow_updatedAtLt = WorkflowExpression.Compile(updatedAtLt, nameof(updatedAtLt), required: false);
            var __workflow_supplierId = WorkflowExpression.Compile(supplierId, nameof(supplierId), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            var __workflow_returnObject = WorkflowExpression.Compile(returnObject, nameof(returnObject), required: false);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_orderBy = WorkflowExpression.Compile(orderBy, nameof(orderBy), required: false);
            var __workflow_dir = WorkflowExpression.Compile(dir, nameof(dir), required: false);
            return new DeferredBodyAction<Contract[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/contracts";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_statusIn != null)
                    callPayload.Queries["status[in]"] = ExpressionConverter.Convert(__workflow_statusIn);
                if (__workflow_numberContains != null)
                    callPayload.Queries["number[contains]"] = ExpressionConverter.Convert(__workflow_numberContains);
                if (__workflow_nameContains != null)
                    callPayload.Queries["name[contains]"] = ExpressionConverter.Convert(__workflow_nameContains);
                if (__workflow_supplierNameContains != null)
                    callPayload.Queries["supplier[name][contains]"] = ExpressionConverter.Convert(__workflow_supplierNameContains);
                if (__workflow_startDateGt != null)
                    callPayload.Queries["start-date[gt]"] = ExpressionConverter.Convert(__workflow_startDateGt);
                if (__workflow_endDateLt != null)
                    callPayload.Queries["end-date[lt]"] = ExpressionConverter.Convert(__workflow_endDateLt);
                if (__workflow_createdAtGt != null)
                    callPayload.Queries["created-at[gt]"] = ExpressionConverter.Convert(__workflow_createdAtGt);
                if (__workflow_updatedAtGt != null)
                    callPayload.Queries["updated-at[gt]"] = ExpressionConverter.Convert(__workflow_updatedAtGt);
                if (__workflow_updatedAtLt != null)
                    callPayload.Queries["updated-at[lt]"] = ExpressionConverter.Convert(__workflow_updatedAtLt);
                if (__workflow_supplierId != null)
                    callPayload.Queries["supplier[id]"] = ExpressionConverter.Convert(__workflow_supplierId);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                if (__workflow_returnObject != null)
                    callPayload.Queries["return_object"] = ExpressionConverter.Convert(__workflow_returnObject);
                if (__workflow_filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_orderBy != null)
                    callPayload.Queries["order_by"] = ExpressionConverter.Convert(__workflow_orderBy);
                if (__workflow_dir != null)
                    callPayload.Queries["dir"] = ExpressionConverter.Convert(__workflow_dir);
                callPayload.Headers["Access-Token"] = ExpressionConverter.Convert(__workflow_accessToken);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return new ApiConnectionAction<Contract[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "coupaip")]
        public IBodyWorkflowAction<Attachment[], ApiConnectionActionConfiguration> CntrGetAttachments(Expression<Func<int>> id, Expression<Func<string>> accessToken)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_accessToken = WorkflowExpression.Compile(accessToken, nameof(accessToken), required: true);
            return new DeferredBodyAction<Attachment[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/contracts/{0}/attachments", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["Access-Token"] = ExpressionConverter.Convert(__workflow_accessToken);
                return new ApiConnectionAction<Attachment[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "coupaip")]
        public IBodyWorkflowAction<Contract, ApiConnectionActionConfiguration> CntrGetContractById(Expression<Func<string>> accessToken, Expression<Func<int>> id, Expression<Func<ReturnObjectInput>> returnObject = null, Expression<Func<string>> fields = null, Expression<Func<string>> filter = null)
        {
            var __workflow_accessToken = WorkflowExpression.Compile(accessToken, nameof(accessToken), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_returnObject = WorkflowExpression.Compile(returnObject, nameof(returnObject), required: false);
            var __workflow_fields = WorkflowExpression.Compile(fields, nameof(fields), required: false);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            return new DeferredBodyAction<Contract, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/contracts/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_returnObject != null)
                    callPayload.Queries["return_object"] = ExpressionConverter.Convert(__workflow_returnObject);
                if (__workflow_fields != null)
                    callPayload.Queries["fields"] = ExpressionConverter.Convert(__workflow_fields);
                if (__workflow_filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(__workflow_filter);
                callPayload.Headers["Access-Token"] = ExpressionConverter.Convert(__workflow_accessToken);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return new ApiConnectionAction<Contract>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "coupaip")]
        public IBodyWorkflowAction<CommGetCommoditiesCommodityResponse[], ApiConnectionActionConfiguration> CommGetCommodities(Expression<Func<string>> accessToken, Expression<Func<string>> nameContains = null, Expression<Func<bool>> active = null, Expression<Func<string>> createdAtGt = null, Expression<Func<string>> updatedAtGt = null, Expression<Func<string>> updatedAtLt = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null, Expression<Func<ReturnObjectInput>> returnObject = null, Expression<Func<string>> filter = null, Expression<Func<string>> orderBy = null, Expression<Func<DirInput>> dir = null)
        {
            var __workflow_accessToken = WorkflowExpression.Compile(accessToken, nameof(accessToken), required: true);
            var __workflow_nameContains = WorkflowExpression.Compile(nameContains, nameof(nameContains), required: false);
            var __workflow_active = WorkflowExpression.Compile(active, nameof(active), required: false);
            var __workflow_createdAtGt = WorkflowExpression.Compile(createdAtGt, nameof(createdAtGt), required: false);
            var __workflow_updatedAtGt = WorkflowExpression.Compile(updatedAtGt, nameof(updatedAtGt), required: false);
            var __workflow_updatedAtLt = WorkflowExpression.Compile(updatedAtLt, nameof(updatedAtLt), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            var __workflow_returnObject = WorkflowExpression.Compile(returnObject, nameof(returnObject), required: false);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_orderBy = WorkflowExpression.Compile(orderBy, nameof(orderBy), required: false);
            var __workflow_dir = WorkflowExpression.Compile(dir, nameof(dir), required: false);
            return new DeferredBodyAction<CommGetCommoditiesCommodityResponse[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/commodities";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_nameContains != null)
                    callPayload.Queries["name[contains]"] = ExpressionConverter.Convert(__workflow_nameContains);
                if (__workflow_active != null)
                    callPayload.Queries["active"] = ExpressionConverter.Convert(__workflow_active);
                if (__workflow_createdAtGt != null)
                    callPayload.Queries["created-at[gt]"] = ExpressionConverter.Convert(__workflow_createdAtGt);
                if (__workflow_updatedAtGt != null)
                    callPayload.Queries["updated-at[gt]"] = ExpressionConverter.Convert(__workflow_updatedAtGt);
                if (__workflow_updatedAtLt != null)
                    callPayload.Queries["updated-at[lt]"] = ExpressionConverter.Convert(__workflow_updatedAtLt);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                if (__workflow_returnObject != null)
                    callPayload.Queries["return_object"] = ExpressionConverter.Convert(__workflow_returnObject);
                if (__workflow_filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_orderBy != null)
                    callPayload.Queries["order_by"] = ExpressionConverter.Convert(__workflow_orderBy);
                if (__workflow_dir != null)
                    callPayload.Queries["dir"] = ExpressionConverter.Convert(__workflow_dir);
                callPayload.Headers["Access-Token"] = ExpressionConverter.Convert(__workflow_accessToken);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return new ApiConnectionAction<CommGetCommoditiesCommodityResponse[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "coupaip")]
        public IBodyWorkflowAction<CommGetCommoditiesCommodityResponse, ApiConnectionActionConfiguration> CommGetCommodityById(Expression<Func<string>> accessToken, Expression<Func<int>> id, Expression<Func<ReturnObjectInput>> returnObject = null, Expression<Func<string>> fields = null, Expression<Func<string>> filter = null)
        {
            var __workflow_accessToken = WorkflowExpression.Compile(accessToken, nameof(accessToken), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_returnObject = WorkflowExpression.Compile(returnObject, nameof(returnObject), required: false);
            var __workflow_fields = WorkflowExpression.Compile(fields, nameof(fields), required: false);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            return new DeferredBodyAction<CommGetCommoditiesCommodityResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/commodities/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_returnObject != null)
                    callPayload.Queries["return_object"] = ExpressionConverter.Convert(__workflow_returnObject);
                if (__workflow_fields != null)
                    callPayload.Queries["fields"] = ExpressionConverter.Convert(__workflow_fields);
                if (__workflow_filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(__workflow_filter);
                callPayload.Headers["Access-Token"] = ExpressionConverter.Convert(__workflow_accessToken);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return new ApiConnectionAction<CommGetCommoditiesCommodityResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "coupaip")]
        public IBodyWorkflowAction<DataFileSource[], ApiConnectionActionConfiguration> DataSrcGetDataSources(Expression<Func<string>> accessToken, Expression<Func<string>> fields = null, Expression<Func<string>> fileFileName = null, Expression<Func<string>> progressIn = null, Expression<Func<DirInput>> dir = null, Expression<Func<ReturnObjectInput>> returnObject = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null, Expression<Func<string>> updatedAtGt = null, Expression<Func<string>> updatedAtLt = null)
        {
            var __workflow_accessToken = WorkflowExpression.Compile(accessToken, nameof(accessToken), required: true);
            var __workflow_fields = WorkflowExpression.Compile(fields, nameof(fields), required: false);
            var __workflow_fileFileName = WorkflowExpression.Compile(fileFileName, nameof(fileFileName), required: false);
            var __workflow_progressIn = WorkflowExpression.Compile(progressIn, nameof(progressIn), required: false);
            var __workflow_dir = WorkflowExpression.Compile(dir, nameof(dir), required: false);
            var __workflow_returnObject = WorkflowExpression.Compile(returnObject, nameof(returnObject), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            var __workflow_updatedAtGt = WorkflowExpression.Compile(updatedAtGt, nameof(updatedAtGt), required: false);
            var __workflow_updatedAtLt = WorkflowExpression.Compile(updatedAtLt, nameof(updatedAtLt), required: false);
            return new DeferredBodyAction<DataFileSource[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/data_file_sources";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_fields != null)
                    callPayload.Queries["fields"] = ExpressionConverter.Convert(__workflow_fields);
                if (__workflow_fileFileName != null)
                    callPayload.Queries["file-file-name"] = ExpressionConverter.Convert(__workflow_fileFileName);
                callPayload.Queries["progress[in]"] = Convert.ToString("0,1");
                if (__workflow_progressIn != null)
                    callPayload.Queries["progress[in]"] = ExpressionConverter.Convert(__workflow_progressIn);
                if (__workflow_dir != null)
                    callPayload.Queries["dir"] = ExpressionConverter.Convert(__workflow_dir);
                if (__workflow_returnObject != null)
                    callPayload.Queries["return_object"] = ExpressionConverter.Convert(__workflow_returnObject);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                if (__workflow_updatedAtGt != null)
                    callPayload.Queries["updated-at[gt]"] = ExpressionConverter.Convert(__workflow_updatedAtGt);
                if (__workflow_updatedAtLt != null)
                    callPayload.Queries["updated-at[lt]"] = ExpressionConverter.Convert(__workflow_updatedAtLt);
                callPayload.Headers["Access-Token"] = ExpressionConverter.Convert(__workflow_accessToken);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return new ApiConnectionAction<DataFileSource[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "coupaip")]
        public IBodyWorkflowAction<ExchangeRate[], ApiConnectionActionConfiguration> ExchRateGetExchangeRates(Expression<Func<string>> accessToken, Expression<Func<string>> fromCurrencyCodeContains = null, Expression<Func<string>> toCurrencyCodeContains = null, Expression<Func<string>> rateDateGt = null, Expression<Func<string>> createdAtGt = null, Expression<Func<string>> updatedAtGt = null, Expression<Func<string>> updatedAtLt = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null, Expression<Func<ReturnObjectInput>> returnObject = null, Expression<Func<string>> filter = null, Expression<Func<string>> orderBy = null, Expression<Func<DirInput>> dir = null)
        {
            var __workflow_accessToken = WorkflowExpression.Compile(accessToken, nameof(accessToken), required: true);
            var __workflow_fromCurrencyCodeContains = WorkflowExpression.Compile(fromCurrencyCodeContains, nameof(fromCurrencyCodeContains), required: false);
            var __workflow_toCurrencyCodeContains = WorkflowExpression.Compile(toCurrencyCodeContains, nameof(toCurrencyCodeContains), required: false);
            var __workflow_rateDateGt = WorkflowExpression.Compile(rateDateGt, nameof(rateDateGt), required: false);
            var __workflow_createdAtGt = WorkflowExpression.Compile(createdAtGt, nameof(createdAtGt), required: false);
            var __workflow_updatedAtGt = WorkflowExpression.Compile(updatedAtGt, nameof(updatedAtGt), required: false);
            var __workflow_updatedAtLt = WorkflowExpression.Compile(updatedAtLt, nameof(updatedAtLt), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            var __workflow_returnObject = WorkflowExpression.Compile(returnObject, nameof(returnObject), required: false);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_orderBy = WorkflowExpression.Compile(orderBy, nameof(orderBy), required: false);
            var __workflow_dir = WorkflowExpression.Compile(dir, nameof(dir), required: false);
            return new DeferredBodyAction<ExchangeRate[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/exchange_rates";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_fromCurrencyCodeContains != null)
                    callPayload.Queries["from-currency[code][contains]"] = ExpressionConverter.Convert(__workflow_fromCurrencyCodeContains);
                if (__workflow_toCurrencyCodeContains != null)
                    callPayload.Queries["to-currency[code][contains]"] = ExpressionConverter.Convert(__workflow_toCurrencyCodeContains);
                if (__workflow_rateDateGt != null)
                    callPayload.Queries["rate-date[gt]"] = ExpressionConverter.Convert(__workflow_rateDateGt);
                if (__workflow_createdAtGt != null)
                    callPayload.Queries["created-at[gt]"] = ExpressionConverter.Convert(__workflow_createdAtGt);
                if (__workflow_updatedAtGt != null)
                    callPayload.Queries["updated-at[gt]"] = ExpressionConverter.Convert(__workflow_updatedAtGt);
                if (__workflow_updatedAtLt != null)
                    callPayload.Queries["updated-at[lt]"] = ExpressionConverter.Convert(__workflow_updatedAtLt);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                if (__workflow_returnObject != null)
                    callPayload.Queries["return_object"] = ExpressionConverter.Convert(__workflow_returnObject);
                if (__workflow_filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_orderBy != null)
                    callPayload.Queries["order_by"] = ExpressionConverter.Convert(__workflow_orderBy);
                if (__workflow_dir != null)
                    callPayload.Queries["dir"] = ExpressionConverter.Convert(__workflow_dir);
                callPayload.Headers["Access-Token"] = ExpressionConverter.Convert(__workflow_accessToken);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return new ApiConnectionAction<ExchangeRate[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "coupaip")]
        public IBodyWorkflowAction<ExchangeRate, ApiConnectionActionConfiguration> ExchRateGetExchangeRateById(Expression<Func<string>> accessToken, Expression<Func<int>> id, Expression<Func<ReturnObjectInput>> returnObject = null, Expression<Func<string>> fields = null, Expression<Func<string>> filter = null)
        {
            var __workflow_accessToken = WorkflowExpression.Compile(accessToken, nameof(accessToken), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_returnObject = WorkflowExpression.Compile(returnObject, nameof(returnObject), required: false);
            var __workflow_fields = WorkflowExpression.Compile(fields, nameof(fields), required: false);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            return new DeferredBodyAction<ExchangeRate, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/exchange_rates/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_returnObject != null)
                    callPayload.Queries["return_object"] = ExpressionConverter.Convert(__workflow_returnObject);
                if (__workflow_fields != null)
                    callPayload.Queries["fields"] = ExpressionConverter.Convert(__workflow_fields);
                if (__workflow_filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(__workflow_filter);
                callPayload.Headers["Access-Token"] = ExpressionConverter.Convert(__workflow_accessToken);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return new ApiConnectionAction<ExchangeRate>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "coupaip")]
        public IBodyWorkflowAction<IntegrationRun[], ApiConnectionActionConfiguration> IntRunIntegrationRunQuery(Expression<Func<string>> accessToken, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null, Expression<Func<string>> fields = null, Expression<Func<DirInput>> dir = null, Expression<Func<ReturnObjectInput>> returnObject = null, Expression<Func<string>> updatedAtGt = null, Expression<Func<string>> updatedAtLt = null, Expression<Func<string>> createdAtGt = null, Expression<Func<string>> filter = null, Expression<Func<string>> orderBy = null)
        {
            var __workflow_accessToken = WorkflowExpression.Compile(accessToken, nameof(accessToken), required: true);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            var __workflow_fields = WorkflowExpression.Compile(fields, nameof(fields), required: false);
            var __workflow_dir = WorkflowExpression.Compile(dir, nameof(dir), required: false);
            var __workflow_returnObject = WorkflowExpression.Compile(returnObject, nameof(returnObject), required: false);
            var __workflow_updatedAtGt = WorkflowExpression.Compile(updatedAtGt, nameof(updatedAtGt), required: false);
            var __workflow_updatedAtLt = WorkflowExpression.Compile(updatedAtLt, nameof(updatedAtLt), required: false);
            var __workflow_createdAtGt = WorkflowExpression.Compile(createdAtGt, nameof(createdAtGt), required: false);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_orderBy = WorkflowExpression.Compile(orderBy, nameof(orderBy), required: false);
            return new DeferredBodyAction<IntegrationRun[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/integration_runs";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                if (__workflow_fields != null)
                    callPayload.Queries["fields"] = ExpressionConverter.Convert(__workflow_fields);
                if (__workflow_dir != null)
                    callPayload.Queries["dir"] = ExpressionConverter.Convert(__workflow_dir);
                if (__workflow_returnObject != null)
                    callPayload.Queries["return_object"] = ExpressionConverter.Convert(__workflow_returnObject);
                if (__workflow_updatedAtGt != null)
                    callPayload.Queries["updated-at[gt]"] = ExpressionConverter.Convert(__workflow_updatedAtGt);
                if (__workflow_updatedAtLt != null)
                    callPayload.Queries["updated-at[lt]"] = ExpressionConverter.Convert(__workflow_updatedAtLt);
                if (__workflow_createdAtGt != null)
                    callPayload.Queries["created-at[gt]"] = ExpressionConverter.Convert(__workflow_createdAtGt);
                if (__workflow_filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_orderBy != null)
                    callPayload.Queries["order_by"] = ExpressionConverter.Convert(__workflow_orderBy);
                callPayload.Headers["Access-Token"] = ExpressionConverter.Convert(__workflow_accessToken);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return new ApiConnectionAction<IntegrationRun[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "coupaip")]
        public IBodyWorkflowAction<IntegrationRun, ApiConnectionActionConfiguration> IntRunIntegrationIdQuery(Expression<Func<string>> accessToken, Expression<Func<int>> id, Expression<Func<string>> fields = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null, Expression<Func<DirInput>> dir = null, Expression<Func<ReturnObjectInput>> returnObject = null)
        {
            var __workflow_accessToken = WorkflowExpression.Compile(accessToken, nameof(accessToken), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_fields = WorkflowExpression.Compile(fields, nameof(fields), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            var __workflow_dir = WorkflowExpression.Compile(dir, nameof(dir), required: false);
            var __workflow_returnObject = WorkflowExpression.Compile(returnObject, nameof(returnObject), required: false);
            return new DeferredBodyAction<IntegrationRun, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/integration_runs/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_fields != null)
                    callPayload.Queries["fields"] = ExpressionConverter.Convert(__workflow_fields);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                if (__workflow_dir != null)
                    callPayload.Queries["dir"] = ExpressionConverter.Convert(__workflow_dir);
                if (__workflow_returnObject != null)
                    callPayload.Queries["return_object"] = ExpressionConverter.Convert(__workflow_returnObject);
                callPayload.Headers["Access-Token"] = ExpressionConverter.Convert(__workflow_accessToken);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return new ApiConnectionAction<IntegrationRun>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "coupaip")]
        public IBodyWorkflowAction<Invoice, ApiConnectionActionConfiguration> InvAbandonInvoices(Expression<Func<string>> accessToken, Expression<Func<int>> id, Expression<Func<InvoiceHeaderInput>> invoiceHeader = null, Expression<Func<ReturnObjectInput>> returnObject = null, Expression<Func<string>> filter = null)
        {
            var __workflow_accessToken = WorkflowExpression.Compile(accessToken, nameof(accessToken), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_invoiceHeader = WorkflowExpression.Compile(invoiceHeader, nameof(invoiceHeader), required: false);
            var __workflow_returnObject = WorkflowExpression.Compile(returnObject, nameof(returnObject), required: false);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            return new DeferredBodyAction<Invoice, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/invoices/{0}/abandon", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_returnObject != null)
                    callPayload.Queries["return_object"] = ExpressionConverter.Convert(__workflow_returnObject);
                if (__workflow_filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(__workflow_filter);
                callPayload.Headers["Access-Token"] = ExpressionConverter.Convert(__workflow_accessToken);
                if (__workflow_invoiceHeader != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_invoiceHeader);
                return new ApiConnectionAction<Invoice>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "coupaip")]
        public IBodyWorkflowAction<Invoice, ApiConnectionActionConfiguration> InvUpdateInvoicesAddApprover(Expression<Func<string>> accessToken, Expression<Func<int>> id, Expression<Func<InvoiceHeaderInput>> invoiceHeader = null, Expression<Func<ReturnObjectInput>> returnObject = null, Expression<Func<string>> filter = null)
        {
            var __workflow_accessToken = WorkflowExpression.Compile(accessToken, nameof(accessToken), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_invoiceHeader = WorkflowExpression.Compile(invoiceHeader, nameof(invoiceHeader), required: false);
            var __workflow_returnObject = WorkflowExpression.Compile(returnObject, nameof(returnObject), required: false);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            return new DeferredBodyAction<Invoice, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/invoices/{0}/add_approver", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_returnObject != null)
                    callPayload.Queries["return_object"] = ExpressionConverter.Convert(__workflow_returnObject);
                if (__workflow_filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(__workflow_filter);
                callPayload.Headers["Access-Token"] = ExpressionConverter.Convert(__workflow_accessToken);
                if (__workflow_invoiceHeader != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_invoiceHeader);
                return new ApiConnectionAction<Invoice>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "coupaip")]
        public IBodyWorkflowAction<Invoice, ApiConnectionActionConfiguration> InvBypassApprovalsInvoices(Expression<Func<string>> accessToken, Expression<Func<int>> id, Expression<Func<InvoiceHeaderInput>> invoiceHeader = null, Expression<Func<ReturnObjectInput>> returnObject = null, Expression<Func<string>> filter = null)
        {
            var __workflow_accessToken = WorkflowExpression.Compile(accessToken, nameof(accessToken), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_invoiceHeader = WorkflowExpression.Compile(invoiceHeader, nameof(invoiceHeader), required: false);
            var __workflow_returnObject = WorkflowExpression.Compile(returnObject, nameof(returnObject), required: false);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            return new DeferredBodyAction<Invoice, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/invoices/{0}/bypass_approvals", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_returnObject != null)
                    callPayload.Queries["return_object"] = ExpressionConverter.Convert(__workflow_returnObject);
                if (__workflow_filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(__workflow_filter);
                callPayload.Headers["Access-Token"] = ExpressionConverter.Convert(__workflow_accessToken);
                if (__workflow_invoiceHeader != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_invoiceHeader);
                return new ApiConnectionAction<Invoice>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "coupaip")]
        public IBodyWorkflowAction<Invoice, ApiConnectionActionConfiguration> InvUpdateInvoicesBypassCurrentApproval(Expression<Func<string>> accessToken, Expression<Func<int>> id, Expression<Func<InvoiceHeaderInput>> invoiceHeader = null, Expression<Func<ReturnObjectInput>> returnObject = null, Expression<Func<string>> filter = null)
        {
            var __workflow_accessToken = WorkflowExpression.Compile(accessToken, nameof(accessToken), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_invoiceHeader = WorkflowExpression.Compile(invoiceHeader, nameof(invoiceHeader), required: false);
            var __workflow_returnObject = WorkflowExpression.Compile(returnObject, nameof(returnObject), required: false);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            return new DeferredBodyAction<Invoice, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/invoices/{0}/bypass_current_approval", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_returnObject != null)
                    callPayload.Queries["return_object"] = ExpressionConverter.Convert(__workflow_returnObject);
                if (__workflow_filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(__workflow_filter);
                callPayload.Headers["Access-Token"] = ExpressionConverter.Convert(__workflow_accessToken);
                if (__workflow_invoiceHeader != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_invoiceHeader);
                return new ApiConnectionAction<Invoice>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "coupaip")]
        public IBodyWorkflowAction<Invoice, ApiConnectionActionConfiguration> InvDisputeInvoices(Expression<Func<string>> accessToken, Expression<Func<int>> id, Expression<Func<InvoiceHeaderInput>> invoiceHeader = null, Expression<Func<ReturnObjectInput>> returnObject = null, Expression<Func<string>> filter = null)
        {
            var __workflow_accessToken = WorkflowExpression.Compile(accessToken, nameof(accessToken), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_invoiceHeader = WorkflowExpression.Compile(invoiceHeader, nameof(invoiceHeader), required: false);
            var __workflow_returnObject = WorkflowExpression.Compile(returnObject, nameof(returnObject), required: false);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            return new DeferredBodyAction<Invoice, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/invoices/{0}/dispute", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_returnObject != null)
                    callPayload.Queries["return_object"] = ExpressionConverter.Convert(__workflow_returnObject);
                if (__workflow_filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(__workflow_filter);
                callPayload.Headers["Access-Token"] = ExpressionConverter.Convert(__workflow_accessToken);
                if (__workflow_invoiceHeader != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_invoiceHeader);
                return new ApiConnectionAction<Invoice>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "coupaip")]
        public IBodyWorkflowAction<Invoice, ApiConnectionActionConfiguration> InvGetInvoicesRetrieveLegalInvoicePdf(Expression<Func<string>> accessToken, Expression<Func<int>> id, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null, Expression<Func<string>> orderBy = null, Expression<Func<DirInput>> dir = null, Expression<Func<ReturnObjectInput>> returnObject = null, Expression<Func<string>> filter = null)
        {
            var __workflow_accessToken = WorkflowExpression.Compile(accessToken, nameof(accessToken), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            var __workflow_orderBy = WorkflowExpression.Compile(orderBy, nameof(orderBy), required: false);
            var __workflow_dir = WorkflowExpression.Compile(dir, nameof(dir), required: false);
            var __workflow_returnObject = WorkflowExpression.Compile(returnObject, nameof(returnObject), required: false);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            return new DeferredBodyAction<Invoice, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/invoices/{0}/retrieve_legal_invoice_pdf", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                if (__workflow_orderBy != null)
                    callPayload.Queries["order_by"] = ExpressionConverter.Convert(__workflow_orderBy);
                if (__workflow_dir != null)
                    callPayload.Queries["dir"] = ExpressionConverter.Convert(__workflow_dir);
                if (__workflow_returnObject != null)
                    callPayload.Queries["return_object"] = ExpressionConverter.Convert(__workflow_returnObject);
                if (__workflow_filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(__workflow_filter);
                callPayload.Headers["Access-Token"] = ExpressionConverter.Convert(__workflow_accessToken);
                return new ApiConnectionAction<Invoice>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "coupaip")]
        public IBodyWorkflowAction<Invoice, ApiConnectionActionConfiguration> InvUpdateInvoicesFlipToAdvanceShipNotice(Expression<Func<string>> accessToken, Expression<Func<int>> id, Expression<Func<InvoiceHeaderInput>> invoiceHeader = null, Expression<Func<ReturnObjectInput>> returnObject = null, Expression<Func<string>> filter = null)
        {
            var __workflow_accessToken = WorkflowExpression.Compile(accessToken, nameof(accessToken), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_invoiceHeader = WorkflowExpression.Compile(invoiceHeader, nameof(invoiceHeader), required: false);
            var __workflow_returnObject = WorkflowExpression.Compile(returnObject, nameof(returnObject), required: false);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            return new DeferredBodyAction<Invoice, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/invoices/{0}/flip_to_advance_ship_notice", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_returnObject != null)
                    callPayload.Queries["return_object"] = ExpressionConverter.Convert(__workflow_returnObject);
                if (__workflow_filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(__workflow_filter);
                callPayload.Headers["Access-Token"] = ExpressionConverter.Convert(__workflow_accessToken);
                if (__workflow_invoiceHeader != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_invoiceHeader);
                return new ApiConnectionAction<Invoice>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "coupaip")]
        public IBodyWorkflowAction<Invoice[], ApiConnectionActionConfiguration> InvGetInvoices(Expression<Func<string>> accessToken, Expression<Func<InvGetInvoicesStatusInInput>> statusIn = null, Expression<Func<string>> supplierNameContains = null, Expression<Func<string>> invoiceNumberContains = null, Expression<Func<string>> poNumberContains = null, Expression<Func<string>> createdAtGt = null, Expression<Func<string>> updatedAtGt = null, Expression<Func<string>> updatedAtLt = null, Expression<Func<string>> invoiceDateGt = null, Expression<Func<string>> invoiceDateLt = null, Expression<Func<string>> supplierId = null, Expression<Func<double>> amountGt = null, Expression<Func<double>> amountLt = null, Expression<Func<string>> invoiceLinesSupplierPartNumContains = null, Expression<Func<string>> invoiceLinesSupplierPartNum = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null, Expression<Func<ReturnObjectInput>> returnObject = null, Expression<Func<string>> filter = null, Expression<Func<string>> orderBy = null, Expression<Func<DirInput>> dir = null)
        {
            var __workflow_accessToken = WorkflowExpression.Compile(accessToken, nameof(accessToken), required: true);
            var __workflow_statusIn = WorkflowExpression.Compile(statusIn, nameof(statusIn), required: false);
            var __workflow_supplierNameContains = WorkflowExpression.Compile(supplierNameContains, nameof(supplierNameContains), required: false);
            var __workflow_invoiceNumberContains = WorkflowExpression.Compile(invoiceNumberContains, nameof(invoiceNumberContains), required: false);
            var __workflow_poNumberContains = WorkflowExpression.Compile(poNumberContains, nameof(poNumberContains), required: false);
            var __workflow_createdAtGt = WorkflowExpression.Compile(createdAtGt, nameof(createdAtGt), required: false);
            var __workflow_updatedAtGt = WorkflowExpression.Compile(updatedAtGt, nameof(updatedAtGt), required: false);
            var __workflow_updatedAtLt = WorkflowExpression.Compile(updatedAtLt, nameof(updatedAtLt), required: false);
            var __workflow_invoiceDateGt = WorkflowExpression.Compile(invoiceDateGt, nameof(invoiceDateGt), required: false);
            var __workflow_invoiceDateLt = WorkflowExpression.Compile(invoiceDateLt, nameof(invoiceDateLt), required: false);
            var __workflow_supplierId = WorkflowExpression.Compile(supplierId, nameof(supplierId), required: false);
            var __workflow_amountGt = WorkflowExpression.Compile(amountGt, nameof(amountGt), required: false);
            var __workflow_amountLt = WorkflowExpression.Compile(amountLt, nameof(amountLt), required: false);
            var __workflow_invoiceLinesSupplierPartNumContains = WorkflowExpression.Compile(invoiceLinesSupplierPartNumContains, nameof(invoiceLinesSupplierPartNumContains), required: false);
            var __workflow_invoiceLinesSupplierPartNum = WorkflowExpression.Compile(invoiceLinesSupplierPartNum, nameof(invoiceLinesSupplierPartNum), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            var __workflow_returnObject = WorkflowExpression.Compile(returnObject, nameof(returnObject), required: false);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_orderBy = WorkflowExpression.Compile(orderBy, nameof(orderBy), required: false);
            var __workflow_dir = WorkflowExpression.Compile(dir, nameof(dir), required: false);
            return new DeferredBodyAction<Invoice[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/invoices";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_statusIn != null)
                    callPayload.Queries["status[in]"] = ExpressionConverter.Convert(__workflow_statusIn);
                if (__workflow_supplierNameContains != null)
                    callPayload.Queries["supplier[name][contains]"] = ExpressionConverter.Convert(__workflow_supplierNameContains);
                if (__workflow_invoiceNumberContains != null)
                    callPayload.Queries["invoice-number[contains]"] = ExpressionConverter.Convert(__workflow_invoiceNumberContains);
                if (__workflow_poNumberContains != null)
                    callPayload.Queries["po-number[contains]"] = ExpressionConverter.Convert(__workflow_poNumberContains);
                if (__workflow_createdAtGt != null)
                    callPayload.Queries["created-at[gt]"] = ExpressionConverter.Convert(__workflow_createdAtGt);
                if (__workflow_updatedAtGt != null)
                    callPayload.Queries["updated-at[gt]"] = ExpressionConverter.Convert(__workflow_updatedAtGt);
                if (__workflow_updatedAtLt != null)
                    callPayload.Queries["updated-at[lt]"] = ExpressionConverter.Convert(__workflow_updatedAtLt);
                if (__workflow_invoiceDateGt != null)
                    callPayload.Queries["invoice-date[gt]"] = ExpressionConverter.Convert(__workflow_invoiceDateGt);
                if (__workflow_invoiceDateLt != null)
                    callPayload.Queries["invoice-date[lt]"] = ExpressionConverter.Convert(__workflow_invoiceDateLt);
                if (__workflow_supplierId != null)
                    callPayload.Queries["supplier[id]"] = ExpressionConverter.Convert(__workflow_supplierId);
                if (__workflow_amountGt != null)
                    callPayload.Queries["amount[gt]"] = ExpressionConverter.Convert(__workflow_amountGt);
                if (__workflow_amountLt != null)
                    callPayload.Queries["amount[lt]"] = ExpressionConverter.Convert(__workflow_amountLt);
                if (__workflow_invoiceLinesSupplierPartNumContains != null)
                    callPayload.Queries["invoice_lines[supplier_part_num][contains]"] = ExpressionConverter.Convert(__workflow_invoiceLinesSupplierPartNumContains);
                if (__workflow_invoiceLinesSupplierPartNum != null)
                    callPayload.Queries["invoice_lines[supplier_part_num]"] = ExpressionConverter.Convert(__workflow_invoiceLinesSupplierPartNum);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                if (__workflow_returnObject != null)
                    callPayload.Queries["return_object"] = ExpressionConverter.Convert(__workflow_returnObject);
                if (__workflow_filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_orderBy != null)
                    callPayload.Queries["order_by"] = ExpressionConverter.Convert(__workflow_orderBy);
                if (__workflow_dir != null)
                    callPayload.Queries["dir"] = ExpressionConverter.Convert(__workflow_dir);
                callPayload.Headers["Access-Token"] = ExpressionConverter.Convert(__workflow_accessToken);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return new ApiConnectionAction<Invoice[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "coupaip")]
        public IBodyWorkflowAction<Attachment[], ApiConnectionActionConfiguration> InvGetAttachments(Expression<Func<int>> id, Expression<Func<string>> accessToken)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_accessToken = WorkflowExpression.Compile(accessToken, nameof(accessToken), required: true);
            return new DeferredBodyAction<Attachment[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/invoices/{0}/attachments", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["Access-Token"] = ExpressionConverter.Convert(__workflow_accessToken);
                return new ApiConnectionAction<Attachment[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "coupaip")]
        public IBodyWorkflowAction<Invoice, ApiConnectionActionConfiguration> InvGetInvoiceById(Expression<Func<string>> accessToken, Expression<Func<int>> id, Expression<Func<ReturnObjectInput>> returnObject = null, Expression<Func<string>> fields = null, Expression<Func<string>> filter = null)
        {
            var __workflow_accessToken = WorkflowExpression.Compile(accessToken, nameof(accessToken), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_returnObject = WorkflowExpression.Compile(returnObject, nameof(returnObject), required: false);
            var __workflow_fields = WorkflowExpression.Compile(fields, nameof(fields), required: false);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            return new DeferredBodyAction<Invoice, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/invoices/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_returnObject != null)
                    callPayload.Queries["return_object"] = ExpressionConverter.Convert(__workflow_returnObject);
                if (__workflow_fields != null)
                    callPayload.Queries["fields"] = ExpressionConverter.Convert(__workflow_fields);
                if (__workflow_filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(__workflow_filter);
                callPayload.Headers["Access-Token"] = ExpressionConverter.Convert(__workflow_accessToken);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return new ApiConnectionAction<Invoice>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "coupaip")]
        public IBodyWorkflowAction<Invoice, ApiConnectionActionConfiguration> InvPatchInvoice(Expression<Func<string>> accessToken, Expression<Func<int>> id, Expression<Func<InvoiceHeaderInput>> invoiceHeader = null, Expression<Func<ReturnObjectInput>> returnObject = null, Expression<Func<string>> filter = null)
        {
            var __workflow_accessToken = WorkflowExpression.Compile(accessToken, nameof(accessToken), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_invoiceHeader = WorkflowExpression.Compile(invoiceHeader, nameof(invoiceHeader), required: false);
            var __workflow_returnObject = WorkflowExpression.Compile(returnObject, nameof(returnObject), required: false);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            return new DeferredBodyAction<Invoice, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/invoices/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_returnObject != null)
                    callPayload.Queries["return_object"] = ExpressionConverter.Convert(__workflow_returnObject);
                if (__workflow_filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(__workflow_filter);
                callPayload.Headers["Access-Token"] = ExpressionConverter.Convert(__workflow_accessToken);
                if (__workflow_invoiceHeader != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_invoiceHeader);
                return new ApiConnectionAction<Invoice>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "coupaip")]
        public IBodyWorkflowAction<Invoice, ApiConnectionActionConfiguration> InvPutInvoice(Expression<Func<string>> accessToken, Expression<Func<int>> id, Expression<Func<InvoiceHeaderInput>> invoiceHeader = null, Expression<Func<ReturnObjectInput>> returnObject = null, Expression<Func<string>> filter = null)
        {
            var __workflow_accessToken = WorkflowExpression.Compile(accessToken, nameof(accessToken), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_invoiceHeader = WorkflowExpression.Compile(invoiceHeader, nameof(invoiceHeader), required: false);
            var __workflow_returnObject = WorkflowExpression.Compile(returnObject, nameof(returnObject), required: false);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            return new DeferredBodyAction<Invoice, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/invoices/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_returnObject != null)
                    callPayload.Queries["return_object"] = ExpressionConverter.Convert(__workflow_returnObject);
                if (__workflow_filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(__workflow_filter);
                callPayload.Headers["Access-Token"] = ExpressionConverter.Convert(__workflow_accessToken);
                if (__workflow_invoiceHeader != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_invoiceHeader);
                return new ApiConnectionAction<Invoice>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "coupaip")]
        public IBodyWorkflowAction<Invoice, ApiConnectionActionConfiguration> InvDeleteInvoices(Expression<Func<string>> accessToken, Expression<Func<int>> id)
        {
            var __workflow_accessToken = WorkflowExpression.Compile(accessToken, nameof(accessToken), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<Invoice, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/invoices/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Access-Token"] = ExpressionConverter.Convert(__workflow_accessToken);
                return new ApiConnectionAction<Invoice>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "coupaip")]
        public IBodyWorkflowAction<Comment[], ApiConnectionActionConfiguration> InvGetInvoiceComments(Expression<Func<string>> accessToken, Expression<Func<int>> id, Expression<Func<ReturnObjectInput>> returnObject = null, Expression<Func<string>> fields = null, Expression<Func<string>> filter = null)
        {
            var __workflow_accessToken = WorkflowExpression.Compile(accessToken, nameof(accessToken), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_returnObject = WorkflowExpression.Compile(returnObject, nameof(returnObject), required: false);
            var __workflow_fields = WorkflowExpression.Compile(fields, nameof(fields), required: false);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            return new DeferredBodyAction<Comment[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/invoices/{0}/comments", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_returnObject != null)
                    callPayload.Queries["return_object"] = ExpressionConverter.Convert(__workflow_returnObject);
                if (__workflow_fields != null)
                    callPayload.Queries["fields"] = ExpressionConverter.Convert(__workflow_fields);
                if (__workflow_filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(__workflow_filter);
                callPayload.Headers["Access-Token"] = ExpressionConverter.Convert(__workflow_accessToken);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return new ApiConnectionAction<Comment[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "coupaip")]
        public IBodyWorkflowAction<Comment, ApiConnectionActionConfiguration> InvPostComment(Expression<Func<int>> id, Expression<Func<string>> accessToken, Expression<Func<InvPostCommentBodyInput>> body)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_accessToken = WorkflowExpression.Compile(accessToken, nameof(accessToken), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<Comment, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/invoices/{0}/comments", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["Access-Token"] = ExpressionConverter.Convert(__workflow_accessToken);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<Comment>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "coupaip")]
        public IBodyWorkflowAction<Invoice, ApiConnectionActionConfiguration> InvUpdateInvoicesRemoveApproval(Expression<Func<string>> accessToken, Expression<Func<int>> id, Expression<Func<InvoiceHeaderInput>> invoiceHeader = null, Expression<Func<ReturnObjectInput>> returnObject = null, Expression<Func<string>> filter = null)
        {
            var __workflow_accessToken = WorkflowExpression.Compile(accessToken, nameof(accessToken), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_invoiceHeader = WorkflowExpression.Compile(invoiceHeader, nameof(invoiceHeader), required: false);
            var __workflow_returnObject = WorkflowExpression.Compile(returnObject, nameof(returnObject), required: false);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            return new DeferredBodyAction<Invoice, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/invoices/{0}/remove_approval", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_returnObject != null)
                    callPayload.Queries["return_object"] = ExpressionConverter.Convert(__workflow_returnObject);
                if (__workflow_filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(__workflow_filter);
                callPayload.Headers["Access-Token"] = ExpressionConverter.Convert(__workflow_accessToken);
                if (__workflow_invoiceHeader != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_invoiceHeader);
                return new ApiConnectionAction<Invoice>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "coupaip")]
        public IBodyWorkflowAction<Invoice, ApiConnectionActionConfiguration> InvRestartApprovalsInvoices(Expression<Func<string>> accessToken, Expression<Func<int>> id, Expression<Func<InvoiceHeaderInput>> invoiceHeader = null, Expression<Func<ReturnObjectInput>> returnObject = null, Expression<Func<string>> filter = null)
        {
            var __workflow_accessToken = WorkflowExpression.Compile(accessToken, nameof(accessToken), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_invoiceHeader = WorkflowExpression.Compile(invoiceHeader, nameof(invoiceHeader), required: false);
            var __workflow_returnObject = WorkflowExpression.Compile(returnObject, nameof(returnObject), required: false);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            return new DeferredBodyAction<Invoice, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/invoices/{0}/restart_approvals", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_returnObject != null)
                    callPayload.Queries["return_object"] = ExpressionConverter.Convert(__workflow_returnObject);
                if (__workflow_filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(__workflow_filter);
                callPayload.Headers["Access-Token"] = ExpressionConverter.Convert(__workflow_accessToken);
                if (__workflow_invoiceHeader != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_invoiceHeader);
                return new ApiConnectionAction<Invoice>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "coupaip")]
        public IBodyWorkflowAction<Invoice, ApiConnectionActionConfiguration> InvRevalidateTolerancesInvoices(Expression<Func<string>> accessToken, Expression<Func<int>> id, Expression<Func<InvoiceHeaderInput>> invoiceHeader = null, Expression<Func<ReturnObjectInput>> returnObject = null, Expression<Func<string>> filter = null)
        {
            var __workflow_accessToken = WorkflowExpression.Compile(accessToken, nameof(accessToken), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_invoiceHeader = WorkflowExpression.Compile(invoiceHeader, nameof(invoiceHeader), required: false);
            var __workflow_returnObject = WorkflowExpression.Compile(returnObject, nameof(returnObject), required: false);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            return new DeferredBodyAction<Invoice, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/invoices/{0}/revalidate_tolerances", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_returnObject != null)
                    callPayload.Queries["return_object"] = ExpressionConverter.Convert(__workflow_returnObject);
                if (__workflow_filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(__workflow_filter);
                callPayload.Headers["Access-Token"] = ExpressionConverter.Convert(__workflow_accessToken);
                if (__workflow_invoiceHeader != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_invoiceHeader);
                return new ApiConnectionAction<Invoice>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "coupaip")]
        public IBodyWorkflowAction<Invoice, ApiConnectionActionConfiguration> InvSubmitInvoices(Expression<Func<string>> accessToken, Expression<Func<int>> id, Expression<Func<InvoiceHeaderInput>> invoiceHeader = null, Expression<Func<ReturnObjectInput>> returnObject = null, Expression<Func<string>> filter = null)
        {
            var __workflow_accessToken = WorkflowExpression.Compile(accessToken, nameof(accessToken), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_invoiceHeader = WorkflowExpression.Compile(invoiceHeader, nameof(invoiceHeader), required: false);
            var __workflow_returnObject = WorkflowExpression.Compile(returnObject, nameof(returnObject), required: false);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            return new DeferredBodyAction<Invoice, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/invoices/{0}/submit", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_returnObject != null)
                    callPayload.Queries["return_object"] = ExpressionConverter.Convert(__workflow_returnObject);
                if (__workflow_filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(__workflow_filter);
                callPayload.Headers["Access-Token"] = ExpressionConverter.Convert(__workflow_accessToken);
                if (__workflow_invoiceHeader != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_invoiceHeader);
                return new ApiConnectionAction<Invoice>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "coupaip")]
        public IBodyWorkflowAction<Invoice, ApiConnectionActionConfiguration> InvUpdateInvoicesUpdateLineAccounts(Expression<Func<string>> accessToken, Expression<Func<int>> id, Expression<Func<InvoiceHeaderInput>> invoiceHeader = null, Expression<Func<ReturnObjectInput>> returnObject = null, Expression<Func<string>> filter = null)
        {
            var __workflow_accessToken = WorkflowExpression.Compile(accessToken, nameof(accessToken), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_invoiceHeader = WorkflowExpression.Compile(invoiceHeader, nameof(invoiceHeader), required: false);
            var __workflow_returnObject = WorkflowExpression.Compile(returnObject, nameof(returnObject), required: false);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            return new DeferredBodyAction<Invoice, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/invoices/{0}/update_line_accounts", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_returnObject != null)
                    callPayload.Queries["return_object"] = ExpressionConverter.Convert(__workflow_returnObject);
                if (__workflow_filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(__workflow_filter);
                callPayload.Headers["Access-Token"] = ExpressionConverter.Convert(__workflow_accessToken);
                if (__workflow_invoiceHeader != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_invoiceHeader);
                return new ApiConnectionAction<Invoice>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "coupaip")]
        public IBodyWorkflowAction<Invoice, ApiConnectionActionConfiguration> InvVoidInvoices(Expression<Func<string>> accessToken, Expression<Func<int>> id, Expression<Func<InvoiceHeaderInput>> invoiceHeader = null, Expression<Func<ReturnObjectInput>> returnObject = null, Expression<Func<string>> filter = null)
        {
            var __workflow_accessToken = WorkflowExpression.Compile(accessToken, nameof(accessToken), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_invoiceHeader = WorkflowExpression.Compile(invoiceHeader, nameof(invoiceHeader), required: false);
            var __workflow_returnObject = WorkflowExpression.Compile(returnObject, nameof(returnObject), required: false);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            return new DeferredBodyAction<Invoice, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/invoices/{0}/void", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_returnObject != null)
                    callPayload.Queries["return_object"] = ExpressionConverter.Convert(__workflow_returnObject);
                if (__workflow_filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(__workflow_filter);
                callPayload.Headers["Access-Token"] = ExpressionConverter.Convert(__workflow_accessToken);
                if (__workflow_invoiceHeader != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_invoiceHeader);
                return new ApiConnectionAction<Invoice>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "coupaip")]
        public IBodyWorkflowAction<Invoice, ApiConnectionActionConfiguration> InvUpdateInvoicesWithdrawDispute(Expression<Func<string>> accessToken, Expression<Func<int>> id, Expression<Func<InvoiceHeaderInput>> invoiceHeader = null, Expression<Func<ReturnObjectInput>> returnObject = null, Expression<Func<string>> filter = null)
        {
            var __workflow_accessToken = WorkflowExpression.Compile(accessToken, nameof(accessToken), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_invoiceHeader = WorkflowExpression.Compile(invoiceHeader, nameof(invoiceHeader), required: false);
            var __workflow_returnObject = WorkflowExpression.Compile(returnObject, nameof(returnObject), required: false);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            return new DeferredBodyAction<Invoice, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/invoices/{0}/withdraw_dispute", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_returnObject != null)
                    callPayload.Queries["return_object"] = ExpressionConverter.Convert(__workflow_returnObject);
                if (__workflow_filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(__workflow_filter);
                callPayload.Headers["Access-Token"] = ExpressionConverter.Convert(__workflow_accessToken);
                if (__workflow_invoiceHeader != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_invoiceHeader);
                return new ApiConnectionAction<Invoice>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "coupaip")]
        public IBodyWorkflowAction<InventoryRecord[], ApiConnectionActionConfiguration> InvtryGetInventory(Expression<Func<string>> accessToken, Expression<Func<ReturnObjectInput>> returnObject = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null, Expression<Func<DirInput>> dir = null, Expression<Func<string>> filter = null, Expression<Func<string>> createdAtGt = null, Expression<Func<string>> updatedAtGt = null, Expression<Func<string>> updatedAtLt = null, Expression<Func<string>> orderBy = null, Expression<Func<string>> fields = null)
        {
            var __workflow_accessToken = WorkflowExpression.Compile(accessToken, nameof(accessToken), required: true);
            var __workflow_returnObject = WorkflowExpression.Compile(returnObject, nameof(returnObject), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            var __workflow_dir = WorkflowExpression.Compile(dir, nameof(dir), required: false);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_createdAtGt = WorkflowExpression.Compile(createdAtGt, nameof(createdAtGt), required: false);
            var __workflow_updatedAtGt = WorkflowExpression.Compile(updatedAtGt, nameof(updatedAtGt), required: false);
            var __workflow_updatedAtLt = WorkflowExpression.Compile(updatedAtLt, nameof(updatedAtLt), required: false);
            var __workflow_orderBy = WorkflowExpression.Compile(orderBy, nameof(orderBy), required: false);
            var __workflow_fields = WorkflowExpression.Compile(fields, nameof(fields), required: false);
            return new DeferredBodyAction<InventoryRecord[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/inventory";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_returnObject != null)
                    callPayload.Queries["return_object"] = ExpressionConverter.Convert(__workflow_returnObject);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                if (__workflow_dir != null)
                    callPayload.Queries["dir"] = ExpressionConverter.Convert(__workflow_dir);
                if (__workflow_filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_createdAtGt != null)
                    callPayload.Queries["created-at[gt]"] = ExpressionConverter.Convert(__workflow_createdAtGt);
                if (__workflow_updatedAtGt != null)
                    callPayload.Queries["updated-at[gt]"] = ExpressionConverter.Convert(__workflow_updatedAtGt);
                if (__workflow_updatedAtLt != null)
                    callPayload.Queries["updated-at[lt]"] = ExpressionConverter.Convert(__workflow_updatedAtLt);
                if (__workflow_orderBy != null)
                    callPayload.Queries["order_by"] = ExpressionConverter.Convert(__workflow_orderBy);
                if (__workflow_fields != null)
                    callPayload.Queries["fields"] = ExpressionConverter.Convert(__workflow_fields);
                callPayload.Headers["Access-Token"] = ExpressionConverter.Convert(__workflow_accessToken);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return new ApiConnectionAction<InventoryRecord[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "coupaip")]
        public IBodyWorkflowAction<InventoryRecord, ApiConnectionActionConfiguration> InvtryGetInventoryById(Expression<Func<string>> accessToken, Expression<Func<int>> id, Expression<Func<ReturnObjectInput>> returnObject = null, Expression<Func<string>> fields = null, Expression<Func<string>> filter = null)
        {
            var __workflow_accessToken = WorkflowExpression.Compile(accessToken, nameof(accessToken), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_returnObject = WorkflowExpression.Compile(returnObject, nameof(returnObject), required: false);
            var __workflow_fields = WorkflowExpression.Compile(fields, nameof(fields), required: false);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            return new DeferredBodyAction<InventoryRecord, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/inventory/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_returnObject != null)
                    callPayload.Queries["return_object"] = ExpressionConverter.Convert(__workflow_returnObject);
                if (__workflow_fields != null)
                    callPayload.Queries["fields"] = ExpressionConverter.Convert(__workflow_fields);
                if (__workflow_filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(__workflow_filter);
                callPayload.Headers["Access-Token"] = ExpressionConverter.Convert(__workflow_accessToken);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return new ApiConnectionAction<InventoryRecord>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "coupaip")]
        public IBodyWorkflowAction<InventoryTransaction[], ApiConnectionActionConfiguration> InvTxnGetInventoryTransactions(Expression<Func<string>> accessToken, Expression<Func<ReturnObjectInput>> returnObject = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null, Expression<Func<string>> updatedAtGt = null, Expression<Func<string>> updatedAtLt = null, Expression<Func<string>> createdAtGt = null, Expression<Func<string>> filter = null, Expression<Func<string>> orderBy = null, Expression<Func<DirInput>> dir = null, Expression<Func<string>> fields = null)
        {
            var __workflow_accessToken = WorkflowExpression.Compile(accessToken, nameof(accessToken), required: true);
            var __workflow_returnObject = WorkflowExpression.Compile(returnObject, nameof(returnObject), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            var __workflow_updatedAtGt = WorkflowExpression.Compile(updatedAtGt, nameof(updatedAtGt), required: false);
            var __workflow_updatedAtLt = WorkflowExpression.Compile(updatedAtLt, nameof(updatedAtLt), required: false);
            var __workflow_createdAtGt = WorkflowExpression.Compile(createdAtGt, nameof(createdAtGt), required: false);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_orderBy = WorkflowExpression.Compile(orderBy, nameof(orderBy), required: false);
            var __workflow_dir = WorkflowExpression.Compile(dir, nameof(dir), required: false);
            var __workflow_fields = WorkflowExpression.Compile(fields, nameof(fields), required: false);
            return new DeferredBodyAction<InventoryTransaction[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/inventory_transactions";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_returnObject != null)
                    callPayload.Queries["return_object"] = ExpressionConverter.Convert(__workflow_returnObject);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                if (__workflow_updatedAtGt != null)
                    callPayload.Queries["updated-at[gt]"] = ExpressionConverter.Convert(__workflow_updatedAtGt);
                if (__workflow_updatedAtLt != null)
                    callPayload.Queries["updated-at[lt]"] = ExpressionConverter.Convert(__workflow_updatedAtLt);
                if (__workflow_createdAtGt != null)
                    callPayload.Queries["created-at[gt]"] = ExpressionConverter.Convert(__workflow_createdAtGt);
                if (__workflow_filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_orderBy != null)
                    callPayload.Queries["order_by"] = ExpressionConverter.Convert(__workflow_orderBy);
                if (__workflow_dir != null)
                    callPayload.Queries["dir"] = ExpressionConverter.Convert(__workflow_dir);
                if (__workflow_fields != null)
                    callPayload.Queries["fields"] = ExpressionConverter.Convert(__workflow_fields);
                callPayload.Headers["Access-Token"] = ExpressionConverter.Convert(__workflow_accessToken);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return new ApiConnectionAction<InventoryTransaction[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "coupaip")]
        public IBodyWorkflowAction<InventoryTransaction, ApiConnectionActionConfiguration> InvTxnGetInventoryTransactionById(Expression<Func<string>> accessToken, Expression<Func<int>> id, Expression<Func<ReturnObjectInput>> returnObject = null, Expression<Func<string>> fields = null, Expression<Func<string>> filter = null)
        {
            var __workflow_accessToken = WorkflowExpression.Compile(accessToken, nameof(accessToken), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_returnObject = WorkflowExpression.Compile(returnObject, nameof(returnObject), required: false);
            var __workflow_fields = WorkflowExpression.Compile(fields, nameof(fields), required: false);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            return new DeferredBodyAction<InventoryTransaction, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/inventory_transactions/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_returnObject != null)
                    callPayload.Queries["return_object"] = ExpressionConverter.Convert(__workflow_returnObject);
                if (__workflow_fields != null)
                    callPayload.Queries["fields"] = ExpressionConverter.Convert(__workflow_fields);
                if (__workflow_filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(__workflow_filter);
                callPayload.Headers["Access-Token"] = ExpressionConverter.Convert(__workflow_accessToken);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return new ApiConnectionAction<InventoryTransaction>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "coupaip")]
        public IBodyWorkflowAction<InvAbandonInvoicesItemResponse[], ApiConnectionActionConfiguration> ItemGetItems(Expression<Func<string>> accessToken, Expression<Func<string>> nameContains = null, Expression<Func<string>> descriptionContains = null, Expression<Func<bool>> active = null, Expression<Func<string>> supplierItemsSupplierNameContains = null, Expression<Func<string>> supplierItemsSupplierPartNumContains = null, Expression<Func<string>> createdAtGt = null, Expression<Func<string>> updatedAtGt = null, Expression<Func<string>> updatedAtLt = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null, Expression<Func<ReturnObjectInput>> returnObject = null, Expression<Func<string>> filter = null, Expression<Func<string>> orderBy = null, Expression<Func<DirInput>> dir = null)
        {
            var __workflow_accessToken = WorkflowExpression.Compile(accessToken, nameof(accessToken), required: true);
            var __workflow_nameContains = WorkflowExpression.Compile(nameContains, nameof(nameContains), required: false);
            var __workflow_descriptionContains = WorkflowExpression.Compile(descriptionContains, nameof(descriptionContains), required: false);
            var __workflow_active = WorkflowExpression.Compile(active, nameof(active), required: false);
            var __workflow_supplierItemsSupplierNameContains = WorkflowExpression.Compile(supplierItemsSupplierNameContains, nameof(supplierItemsSupplierNameContains), required: false);
            var __workflow_supplierItemsSupplierPartNumContains = WorkflowExpression.Compile(supplierItemsSupplierPartNumContains, nameof(supplierItemsSupplierPartNumContains), required: false);
            var __workflow_createdAtGt = WorkflowExpression.Compile(createdAtGt, nameof(createdAtGt), required: false);
            var __workflow_updatedAtGt = WorkflowExpression.Compile(updatedAtGt, nameof(updatedAtGt), required: false);
            var __workflow_updatedAtLt = WorkflowExpression.Compile(updatedAtLt, nameof(updatedAtLt), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            var __workflow_returnObject = WorkflowExpression.Compile(returnObject, nameof(returnObject), required: false);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_orderBy = WorkflowExpression.Compile(orderBy, nameof(orderBy), required: false);
            var __workflow_dir = WorkflowExpression.Compile(dir, nameof(dir), required: false);
            return new DeferredBodyAction<InvAbandonInvoicesItemResponse[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/items";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_nameContains != null)
                    callPayload.Queries["name[contains]"] = ExpressionConverter.Convert(__workflow_nameContains);
                if (__workflow_descriptionContains != null)
                    callPayload.Queries["description[contains]"] = ExpressionConverter.Convert(__workflow_descriptionContains);
                if (__workflow_active != null)
                    callPayload.Queries["active"] = ExpressionConverter.Convert(__workflow_active);
                if (__workflow_supplierItemsSupplierNameContains != null)
                    callPayload.Queries["supplier_items[supplier][name][contains]"] = ExpressionConverter.Convert(__workflow_supplierItemsSupplierNameContains);
                if (__workflow_supplierItemsSupplierPartNumContains != null)
                    callPayload.Queries["supplier_items[supplier-part-num][contains]"] = ExpressionConverter.Convert(__workflow_supplierItemsSupplierPartNumContains);
                if (__workflow_createdAtGt != null)
                    callPayload.Queries["created-at[gt]"] = ExpressionConverter.Convert(__workflow_createdAtGt);
                if (__workflow_updatedAtGt != null)
                    callPayload.Queries["updated-at[gt]"] = ExpressionConverter.Convert(__workflow_updatedAtGt);
                if (__workflow_updatedAtLt != null)
                    callPayload.Queries["updated-at[lt]"] = ExpressionConverter.Convert(__workflow_updatedAtLt);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                if (__workflow_returnObject != null)
                    callPayload.Queries["return_object"] = ExpressionConverter.Convert(__workflow_returnObject);
                if (__workflow_filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_orderBy != null)
                    callPayload.Queries["order_by"] = ExpressionConverter.Convert(__workflow_orderBy);
                if (__workflow_dir != null)
                    callPayload.Queries["dir"] = ExpressionConverter.Convert(__workflow_dir);
                callPayload.Headers["Access-Token"] = ExpressionConverter.Convert(__workflow_accessToken);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return new ApiConnectionAction<InvAbandonInvoicesItemResponse[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "coupaip")]
        public IBodyWorkflowAction<InvAbandonInvoicesItemResponse, ApiConnectionActionConfiguration> ItemGetItemById(Expression<Func<string>> accessToken, Expression<Func<int>> id, Expression<Func<ReturnObjectInput>> returnObject = null, Expression<Func<string>> fields = null, Expression<Func<string>> filter = null)
        {
            var __workflow_accessToken = WorkflowExpression.Compile(accessToken, nameof(accessToken), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_returnObject = WorkflowExpression.Compile(returnObject, nameof(returnObject), required: false);
            var __workflow_fields = WorkflowExpression.Compile(fields, nameof(fields), required: false);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            return new DeferredBodyAction<InvAbandonInvoicesItemResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/items/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_returnObject != null)
                    callPayload.Queries["return_object"] = ExpressionConverter.Convert(__workflow_returnObject);
                if (__workflow_fields != null)
                    callPayload.Queries["fields"] = ExpressionConverter.Convert(__workflow_fields);
                if (__workflow_filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(__workflow_filter);
                callPayload.Headers["Access-Token"] = ExpressionConverter.Convert(__workflow_accessToken);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return new ApiConnectionAction<InvAbandonInvoicesItemResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "coupaip")]
        public IBodyWorkflowAction<LkpGetLookupByIdLookupResponse[], ApiConnectionActionConfiguration> LkpGetLookups(Expression<Func<string>> accessToken, Expression<Func<string>> nameContains = null, Expression<Func<string>> createdAtGt = null, Expression<Func<string>> updatedAtGt = null, Expression<Func<string>> updatedAtLt = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null, Expression<Func<ReturnObjectInput>> returnObject = null, Expression<Func<string>> filter = null, Expression<Func<string>> orderBy = null, Expression<Func<DirInput>> dir = null)
        {
            var __workflow_accessToken = WorkflowExpression.Compile(accessToken, nameof(accessToken), required: true);
            var __workflow_nameContains = WorkflowExpression.Compile(nameContains, nameof(nameContains), required: false);
            var __workflow_createdAtGt = WorkflowExpression.Compile(createdAtGt, nameof(createdAtGt), required: false);
            var __workflow_updatedAtGt = WorkflowExpression.Compile(updatedAtGt, nameof(updatedAtGt), required: false);
            var __workflow_updatedAtLt = WorkflowExpression.Compile(updatedAtLt, nameof(updatedAtLt), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            var __workflow_returnObject = WorkflowExpression.Compile(returnObject, nameof(returnObject), required: false);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_orderBy = WorkflowExpression.Compile(orderBy, nameof(orderBy), required: false);
            var __workflow_dir = WorkflowExpression.Compile(dir, nameof(dir), required: false);
            return new DeferredBodyAction<LkpGetLookupByIdLookupResponse[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/lookups";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_nameContains != null)
                    callPayload.Queries["name[contains]"] = ExpressionConverter.Convert(__workflow_nameContains);
                if (__workflow_createdAtGt != null)
                    callPayload.Queries["created-at[gt]"] = ExpressionConverter.Convert(__workflow_createdAtGt);
                if (__workflow_updatedAtGt != null)
                    callPayload.Queries["updated-at[gt]"] = ExpressionConverter.Convert(__workflow_updatedAtGt);
                if (__workflow_updatedAtLt != null)
                    callPayload.Queries["updated-at[lt]"] = ExpressionConverter.Convert(__workflow_updatedAtLt);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                if (__workflow_returnObject != null)
                    callPayload.Queries["return_object"] = ExpressionConverter.Convert(__workflow_returnObject);
                if (__workflow_filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_orderBy != null)
                    callPayload.Queries["order_by"] = ExpressionConverter.Convert(__workflow_orderBy);
                if (__workflow_dir != null)
                    callPayload.Queries["dir"] = ExpressionConverter.Convert(__workflow_dir);
                callPayload.Headers["Access-Token"] = ExpressionConverter.Convert(__workflow_accessToken);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return new ApiConnectionAction<LkpGetLookupByIdLookupResponse[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "coupaip")]
        public IBodyWorkflowAction<LkpGetLookupByIdLookupResponse, ApiConnectionActionConfiguration> LkpGetLookupById(Expression<Func<string>> accessToken, Expression<Func<int>> id, Expression<Func<ReturnObjectInput>> returnObject = null, Expression<Func<string>> fields = null, Expression<Func<string>> filter = null)
        {
            var __workflow_accessToken = WorkflowExpression.Compile(accessToken, nameof(accessToken), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_returnObject = WorkflowExpression.Compile(returnObject, nameof(returnObject), required: false);
            var __workflow_fields = WorkflowExpression.Compile(fields, nameof(fields), required: false);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            return new DeferredBodyAction<LkpGetLookupByIdLookupResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/lookups/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_returnObject != null)
                    callPayload.Queries["return_object"] = ExpressionConverter.Convert(__workflow_returnObject);
                if (__workflow_fields != null)
                    callPayload.Queries["fields"] = ExpressionConverter.Convert(__workflow_fields);
                if (__workflow_filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(__workflow_filter);
                callPayload.Headers["Access-Token"] = ExpressionConverter.Convert(__workflow_accessToken);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return new ApiConnectionAction<LkpGetLookupByIdLookupResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "coupaip")]
        public IBodyWorkflowAction<LookupValue[], ApiConnectionActionConfiguration> LkpValGetLookupValues(Expression<Func<string>> accessToken, Expression<Func<string>> lookupNameContains = null, Expression<Func<string>> nameContains = null, Expression<Func<bool>> active = null, Expression<Func<string>> createdAtGt = null, Expression<Func<string>> updatedAtGt = null, Expression<Func<string>> updatedAtLt = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null, Expression<Func<ReturnObjectInput>> returnObject = null, Expression<Func<string>> filter = null, Expression<Func<string>> orderBy = null, Expression<Func<DirInput>> dir = null)
        {
            var __workflow_accessToken = WorkflowExpression.Compile(accessToken, nameof(accessToken), required: true);
            var __workflow_lookupNameContains = WorkflowExpression.Compile(lookupNameContains, nameof(lookupNameContains), required: false);
            var __workflow_nameContains = WorkflowExpression.Compile(nameContains, nameof(nameContains), required: false);
            var __workflow_active = WorkflowExpression.Compile(active, nameof(active), required: false);
            var __workflow_createdAtGt = WorkflowExpression.Compile(createdAtGt, nameof(createdAtGt), required: false);
            var __workflow_updatedAtGt = WorkflowExpression.Compile(updatedAtGt, nameof(updatedAtGt), required: false);
            var __workflow_updatedAtLt = WorkflowExpression.Compile(updatedAtLt, nameof(updatedAtLt), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            var __workflow_returnObject = WorkflowExpression.Compile(returnObject, nameof(returnObject), required: false);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_orderBy = WorkflowExpression.Compile(orderBy, nameof(orderBy), required: false);
            var __workflow_dir = WorkflowExpression.Compile(dir, nameof(dir), required: false);
            return new DeferredBodyAction<LookupValue[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/lookup_values";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_lookupNameContains != null)
                    callPayload.Queries["lookup[name][contains]"] = ExpressionConverter.Convert(__workflow_lookupNameContains);
                if (__workflow_nameContains != null)
                    callPayload.Queries["name[contains]"] = ExpressionConverter.Convert(__workflow_nameContains);
                if (__workflow_active != null)
                    callPayload.Queries["active"] = ExpressionConverter.Convert(__workflow_active);
                if (__workflow_createdAtGt != null)
                    callPayload.Queries["created-at[gt]"] = ExpressionConverter.Convert(__workflow_createdAtGt);
                if (__workflow_updatedAtGt != null)
                    callPayload.Queries["updated-at[gt]"] = ExpressionConverter.Convert(__workflow_updatedAtGt);
                if (__workflow_updatedAtLt != null)
                    callPayload.Queries["updated-at[lt]"] = ExpressionConverter.Convert(__workflow_updatedAtLt);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                if (__workflow_returnObject != null)
                    callPayload.Queries["return_object"] = ExpressionConverter.Convert(__workflow_returnObject);
                if (__workflow_filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_orderBy != null)
                    callPayload.Queries["order_by"] = ExpressionConverter.Convert(__workflow_orderBy);
                if (__workflow_dir != null)
                    callPayload.Queries["dir"] = ExpressionConverter.Convert(__workflow_dir);
                callPayload.Headers["Access-Token"] = ExpressionConverter.Convert(__workflow_accessToken);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return new ApiConnectionAction<LookupValue[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "coupaip")]
        public IBodyWorkflowAction<LookupValue, ApiConnectionActionConfiguration> LkpValCreateLookupValue(Expression<Func<string>> accessToken, Expression<Func<LkpValCreateLookupValueBodyInput>> body)
        {
            var __workflow_accessToken = WorkflowExpression.Compile(accessToken, nameof(accessToken), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<LookupValue, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/lookup_values";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Access-Token"] = ExpressionConverter.Convert(__workflow_accessToken);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<LookupValue>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "coupaip")]
        public IBodyWorkflowAction<LookupValue, ApiConnectionActionConfiguration> LkpValGetLookupValueById(Expression<Func<string>> accessToken, Expression<Func<int>> id, Expression<Func<ReturnObjectInput>> returnObject = null, Expression<Func<string>> fields = null, Expression<Func<string>> filter = null)
        {
            var __workflow_accessToken = WorkflowExpression.Compile(accessToken, nameof(accessToken), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_returnObject = WorkflowExpression.Compile(returnObject, nameof(returnObject), required: false);
            var __workflow_fields = WorkflowExpression.Compile(fields, nameof(fields), required: false);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            return new DeferredBodyAction<LookupValue, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/lookup_values/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_returnObject != null)
                    callPayload.Queries["return_object"] = ExpressionConverter.Convert(__workflow_returnObject);
                if (__workflow_fields != null)
                    callPayload.Queries["fields"] = ExpressionConverter.Convert(__workflow_fields);
                if (__workflow_filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(__workflow_filter);
                callPayload.Headers["Access-Token"] = ExpressionConverter.Convert(__workflow_accessToken);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return new ApiConnectionAction<LookupValue>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "coupaip")]
        public IBodyWorkflowAction<LookupValue, ApiConnectionActionConfiguration> LkpValUpdateLookupValue(Expression<Func<string>> accessToken, Expression<Func<int>> id, Expression<Func<LkpValCreateLookupValueBodyInput>> body)
        {
            var __workflow_accessToken = WorkflowExpression.Compile(accessToken, nameof(accessToken), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<LookupValue, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/lookup_values/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Access-Token"] = ExpressionConverter.Convert(__workflow_accessToken);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<LookupValue>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "coupaip")]
        public IBodyWorkflowAction<OrderPad[], ApiConnectionActionConfiguration> OrdListGetOrderPads(Expression<Func<string>> accessToken, Expression<Func<string>> nameContains = null, Expression<Func<string>> createdAtGt = null, Expression<Func<string>> updatedAtGt = null, Expression<Func<string>> updatedAtLt = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null, Expression<Func<ReturnObjectInput>> returnObject = null, Expression<Func<string>> filter = null, Expression<Func<string>> orderBy = null, Expression<Func<DirInput>> dir = null)
        {
            var __workflow_accessToken = WorkflowExpression.Compile(accessToken, nameof(accessToken), required: true);
            var __workflow_nameContains = WorkflowExpression.Compile(nameContains, nameof(nameContains), required: false);
            var __workflow_createdAtGt = WorkflowExpression.Compile(createdAtGt, nameof(createdAtGt), required: false);
            var __workflow_updatedAtGt = WorkflowExpression.Compile(updatedAtGt, nameof(updatedAtGt), required: false);
            var __workflow_updatedAtLt = WorkflowExpression.Compile(updatedAtLt, nameof(updatedAtLt), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            var __workflow_returnObject = WorkflowExpression.Compile(returnObject, nameof(returnObject), required: false);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_orderBy = WorkflowExpression.Compile(orderBy, nameof(orderBy), required: false);
            var __workflow_dir = WorkflowExpression.Compile(dir, nameof(dir), required: false);
            return new DeferredBodyAction<OrderPad[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/order_pads";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_nameContains != null)
                    callPayload.Queries["name[contains]"] = ExpressionConverter.Convert(__workflow_nameContains);
                if (__workflow_createdAtGt != null)
                    callPayload.Queries["created-at[gt]"] = ExpressionConverter.Convert(__workflow_createdAtGt);
                if (__workflow_updatedAtGt != null)
                    callPayload.Queries["updated-at[gt]"] = ExpressionConverter.Convert(__workflow_updatedAtGt);
                if (__workflow_updatedAtLt != null)
                    callPayload.Queries["updated-at[lt]"] = ExpressionConverter.Convert(__workflow_updatedAtLt);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                if (__workflow_returnObject != null)
                    callPayload.Queries["return_object"] = ExpressionConverter.Convert(__workflow_returnObject);
                if (__workflow_filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_orderBy != null)
                    callPayload.Queries["order_by"] = ExpressionConverter.Convert(__workflow_orderBy);
                if (__workflow_dir != null)
                    callPayload.Queries["dir"] = ExpressionConverter.Convert(__workflow_dir);
                callPayload.Headers["Access-Token"] = ExpressionConverter.Convert(__workflow_accessToken);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return new ApiConnectionAction<OrderPad[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "coupaip")]
        public IBodyWorkflowAction<OrderPad, ApiConnectionActionConfiguration> OrdListCreateOrderPad(Expression<Func<string>> accessToken, Expression<Func<OrdListCreateOrderPadBodyInput>> body)
        {
            var __workflow_accessToken = WorkflowExpression.Compile(accessToken, nameof(accessToken), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<OrderPad, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/order_pads";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Access-Token"] = ExpressionConverter.Convert(__workflow_accessToken);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<OrderPad>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "coupaip")]
        public IBodyWorkflowAction<OrderPad, ApiConnectionActionConfiguration> OrdListGetOrderPadById(Expression<Func<string>> accessToken, Expression<Func<int>> id, Expression<Func<ReturnObjectInput>> returnObject = null, Expression<Func<string>> fields = null, Expression<Func<string>> filter = null)
        {
            var __workflow_accessToken = WorkflowExpression.Compile(accessToken, nameof(accessToken), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_returnObject = WorkflowExpression.Compile(returnObject, nameof(returnObject), required: false);
            var __workflow_fields = WorkflowExpression.Compile(fields, nameof(fields), required: false);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            return new DeferredBodyAction<OrderPad, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/order_pads/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_returnObject != null)
                    callPayload.Queries["return_object"] = ExpressionConverter.Convert(__workflow_returnObject);
                if (__workflow_fields != null)
                    callPayload.Queries["fields"] = ExpressionConverter.Convert(__workflow_fields);
                if (__workflow_filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(__workflow_filter);
                callPayload.Headers["Access-Token"] = ExpressionConverter.Convert(__workflow_accessToken);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return new ApiConnectionAction<OrderPad>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "coupaip")]
        public IBodyWorkflowAction<OrderPad, ApiConnectionActionConfiguration> OrdListUpdateOrderPad(Expression<Func<string>> accessToken, Expression<Func<int>> id, Expression<Func<OrdListCreateOrderPadBodyInput>> body)
        {
            var __workflow_accessToken = WorkflowExpression.Compile(accessToken, nameof(accessToken), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<OrderPad, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/order_pads/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Access-Token"] = ExpressionConverter.Convert(__workflow_accessToken);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<OrderPad>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "coupaip")]
        public IBodyWorkflowAction<OrdListCreateOrderPadOrderPadLineResponse[], ApiConnectionActionConfiguration> OrdListLineGetOrderPadLines(Expression<Func<string>> accessToken, Expression<Func<int>> orderPadId, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null, Expression<Func<string>> orderBy = null, Expression<Func<DirInput>> dir = null, Expression<Func<ReturnObjectInput>> returnObject = null, Expression<Func<string>> filter = null)
        {
            var __workflow_accessToken = WorkflowExpression.Compile(accessToken, nameof(accessToken), required: true);
            var __workflow_orderPadId = WorkflowExpression.Compile(orderPadId, nameof(orderPadId), required: true);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            var __workflow_orderBy = WorkflowExpression.Compile(orderBy, nameof(orderBy), required: false);
            var __workflow_dir = WorkflowExpression.Compile(dir, nameof(dir), required: false);
            var __workflow_returnObject = WorkflowExpression.Compile(returnObject, nameof(returnObject), required: false);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            return new DeferredBodyAction<OrdListCreateOrderPadOrderPadLineResponse[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/order_pads/{0}/order_pad_lines", __workflow_orderPadId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                if (__workflow_orderBy != null)
                    callPayload.Queries["order_by"] = ExpressionConverter.Convert(__workflow_orderBy);
                if (__workflow_dir != null)
                    callPayload.Queries["dir"] = ExpressionConverter.Convert(__workflow_dir);
                if (__workflow_returnObject != null)
                    callPayload.Queries["return_object"] = ExpressionConverter.Convert(__workflow_returnObject);
                if (__workflow_filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(__workflow_filter);
                callPayload.Headers["Access-Token"] = ExpressionConverter.Convert(__workflow_accessToken);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return new ApiConnectionAction<OrdListCreateOrderPadOrderPadLineResponse[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "coupaip")]
        public IBodyWorkflowAction<OrdListCreateOrderPadOrderPadLineResponse, ApiConnectionActionConfiguration> OrdListLineCreateOrderPadLine(Expression<Func<string>> accessToken, Expression<Func<int>> orderPadId, Expression<Func<OrdListLineCreateOrderPadLineBodyInput>> body)
        {
            var __workflow_accessToken = WorkflowExpression.Compile(accessToken, nameof(accessToken), required: true);
            var __workflow_orderPadId = WorkflowExpression.Compile(orderPadId, nameof(orderPadId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<OrdListCreateOrderPadOrderPadLineResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/order_pads/{0}/order_pad_lines", __workflow_orderPadId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Access-Token"] = ExpressionConverter.Convert(__workflow_accessToken);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<OrdListCreateOrderPadOrderPadLineResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "coupaip")]
        public IBodyWorkflowAction<OrdListCreateOrderPadOrderPadLineResponse, ApiConnectionActionConfiguration> OrdListLineGetOrderPadLineById(Expression<Func<string>> accessToken, Expression<Func<int>> orderPadId, Expression<Func<int>> id, Expression<Func<ReturnObjectInput>> returnObject = null, Expression<Func<string>> fields = null, Expression<Func<string>> filter = null)
        {
            var __workflow_accessToken = WorkflowExpression.Compile(accessToken, nameof(accessToken), required: true);
            var __workflow_orderPadId = WorkflowExpression.Compile(orderPadId, nameof(orderPadId), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_returnObject = WorkflowExpression.Compile(returnObject, nameof(returnObject), required: false);
            var __workflow_fields = WorkflowExpression.Compile(fields, nameof(fields), required: false);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            return new DeferredBodyAction<OrdListCreateOrderPadOrderPadLineResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/order_pads/{0}/order_pad_lines/{1}", __workflow_orderPadId.WithUrlEncoding(1), __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_returnObject != null)
                    callPayload.Queries["return_object"] = ExpressionConverter.Convert(__workflow_returnObject);
                if (__workflow_fields != null)
                    callPayload.Queries["fields"] = ExpressionConverter.Convert(__workflow_fields);
                if (__workflow_filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(__workflow_filter);
                callPayload.Headers["Access-Token"] = ExpressionConverter.Convert(__workflow_accessToken);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return new ApiConnectionAction<OrdListCreateOrderPadOrderPadLineResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "coupaip")]
        public IBodyWorkflowAction<OrdListCreateOrderPadOrderPadLineResponse, ApiConnectionActionConfiguration> OrdListLineUpdateOrderPadLine(Expression<Func<string>> accessToken, Expression<Func<int>> orderPadId, Expression<Func<int>> id, Expression<Func<OrdListLineCreateOrderPadLineBodyInput>> body)
        {
            var __workflow_accessToken = WorkflowExpression.Compile(accessToken, nameof(accessToken), required: true);
            var __workflow_orderPadId = WorkflowExpression.Compile(orderPadId, nameof(orderPadId), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<OrdListCreateOrderPadOrderPadLineResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/order_pads/{0}/order_pad_lines/{1}", __workflow_orderPadId.WithUrlEncoding(1), __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Access-Token"] = ExpressionConverter.Convert(__workflow_accessToken);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<OrdListCreateOrderPadOrderPadLineResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "coupaip")]
        public IBodyWorkflowAction<CntrGetContractByIdPaymentTermResponse[], ApiConnectionActionConfiguration> PmtTermGetPaymentTerms(Expression<Func<string>> accessToken, Expression<Func<string>> codeContains = null, Expression<Func<string>> nameContains = null, Expression<Func<string>> createdAtGt = null, Expression<Func<string>> updatedAtGt = null, Expression<Func<string>> updatedAtLt = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null, Expression<Func<ReturnObjectInput>> returnObject = null, Expression<Func<string>> filter = null, Expression<Func<string>> orderBy = null, Expression<Func<DirInput>> dir = null)
        {
            var __workflow_accessToken = WorkflowExpression.Compile(accessToken, nameof(accessToken), required: true);
            var __workflow_codeContains = WorkflowExpression.Compile(codeContains, nameof(codeContains), required: false);
            var __workflow_nameContains = WorkflowExpression.Compile(nameContains, nameof(nameContains), required: false);
            var __workflow_createdAtGt = WorkflowExpression.Compile(createdAtGt, nameof(createdAtGt), required: false);
            var __workflow_updatedAtGt = WorkflowExpression.Compile(updatedAtGt, nameof(updatedAtGt), required: false);
            var __workflow_updatedAtLt = WorkflowExpression.Compile(updatedAtLt, nameof(updatedAtLt), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            var __workflow_returnObject = WorkflowExpression.Compile(returnObject, nameof(returnObject), required: false);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_orderBy = WorkflowExpression.Compile(orderBy, nameof(orderBy), required: false);
            var __workflow_dir = WorkflowExpression.Compile(dir, nameof(dir), required: false);
            return new DeferredBodyAction<CntrGetContractByIdPaymentTermResponse[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/payment_terms";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_codeContains != null)
                    callPayload.Queries["code[contains]"] = ExpressionConverter.Convert(__workflow_codeContains);
                if (__workflow_nameContains != null)
                    callPayload.Queries["name[contains]"] = ExpressionConverter.Convert(__workflow_nameContains);
                if (__workflow_createdAtGt != null)
                    callPayload.Queries["created-at[gt]"] = ExpressionConverter.Convert(__workflow_createdAtGt);
                if (__workflow_updatedAtGt != null)
                    callPayload.Queries["updated-at[gt]"] = ExpressionConverter.Convert(__workflow_updatedAtGt);
                if (__workflow_updatedAtLt != null)
                    callPayload.Queries["updated-at[lt]"] = ExpressionConverter.Convert(__workflow_updatedAtLt);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                if (__workflow_returnObject != null)
                    callPayload.Queries["return_object"] = ExpressionConverter.Convert(__workflow_returnObject);
                if (__workflow_filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_orderBy != null)
                    callPayload.Queries["order_by"] = ExpressionConverter.Convert(__workflow_orderBy);
                if (__workflow_dir != null)
                    callPayload.Queries["dir"] = ExpressionConverter.Convert(__workflow_dir);
                callPayload.Headers["Access-Token"] = ExpressionConverter.Convert(__workflow_accessToken);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return new ApiConnectionAction<CntrGetContractByIdPaymentTermResponse[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "coupaip")]
        public IBodyWorkflowAction<CntrGetContractByIdPaymentTermResponse, ApiConnectionActionConfiguration> PmtTermGetPaymentTermById(Expression<Func<string>> accessToken, Expression<Func<int>> id, Expression<Func<ReturnObjectInput>> returnObject = null, Expression<Func<string>> fields = null, Expression<Func<string>> filter = null)
        {
            var __workflow_accessToken = WorkflowExpression.Compile(accessToken, nameof(accessToken), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_returnObject = WorkflowExpression.Compile(returnObject, nameof(returnObject), required: false);
            var __workflow_fields = WorkflowExpression.Compile(fields, nameof(fields), required: false);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            return new DeferredBodyAction<CntrGetContractByIdPaymentTermResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/payment_terms/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_returnObject != null)
                    callPayload.Queries["return_object"] = ExpressionConverter.Convert(__workflow_returnObject);
                if (__workflow_fields != null)
                    callPayload.Queries["fields"] = ExpressionConverter.Convert(__workflow_fields);
                if (__workflow_filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(__workflow_filter);
                callPayload.Headers["Access-Token"] = ExpressionConverter.Convert(__workflow_accessToken);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return new ApiConnectionAction<CntrGetContractByIdPaymentTermResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "coupaip")]
        public IBodyWorkflowAction<PurchaseOrder, ApiConnectionActionConfiguration> POCancelPurchaseOrder(Expression<Func<string>> accessToken, Expression<Func<int>> id)
        {
            var __workflow_accessToken = WorkflowExpression.Compile(accessToken, nameof(accessToken), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<PurchaseOrder, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/purchase_orders/{0}/cancel", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Access-Token"] = ExpressionConverter.Convert(__workflow_accessToken);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return new ApiConnectionAction<PurchaseOrder>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "coupaip")]
        public IBodyWorkflowAction<PurchaseOrder, ApiConnectionActionConfiguration> POClosePurchaseOrder(Expression<Func<string>> accessToken, Expression<Func<int>> id)
        {
            var __workflow_accessToken = WorkflowExpression.Compile(accessToken, nameof(accessToken), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<PurchaseOrder, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/purchase_orders/{0}/close", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Access-Token"] = ExpressionConverter.Convert(__workflow_accessToken);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return new ApiConnectionAction<PurchaseOrder>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "coupaip")]
        public IBodyWorkflowAction<PurchaseOrder[], ApiConnectionActionConfiguration> POGetPurchaseOrders(Expression<Func<string>> accessToken, Expression<Func<POGetPurchaseOrdersStatusInInput>> statusIn = null, Expression<Func<string>> supplierNameContains = null, Expression<Func<string>> shipToAttentionContains = null, Expression<Func<string>> createdAtGt = null, Expression<Func<string>> updatedAtGt = null, Expression<Func<string>> updatedAtLt = null, Expression<Func<string>> numberContains = null, Expression<Func<string>> supplierId = null, Expression<Func<string>> currencyCode = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null, Expression<Func<ReturnObjectInput>> returnObject = null, Expression<Func<string>> filter = null, Expression<Func<string>> orderBy = null, Expression<Func<DirInput>> dir = null, Expression<Func<string>> orderLinesSourcePartNumContains = null, Expression<Func<string>> orderLinesSourcePartNum = null)
        {
            var __workflow_accessToken = WorkflowExpression.Compile(accessToken, nameof(accessToken), required: true);
            var __workflow_statusIn = WorkflowExpression.Compile(statusIn, nameof(statusIn), required: false);
            var __workflow_supplierNameContains = WorkflowExpression.Compile(supplierNameContains, nameof(supplierNameContains), required: false);
            var __workflow_shipToAttentionContains = WorkflowExpression.Compile(shipToAttentionContains, nameof(shipToAttentionContains), required: false);
            var __workflow_createdAtGt = WorkflowExpression.Compile(createdAtGt, nameof(createdAtGt), required: false);
            var __workflow_updatedAtGt = WorkflowExpression.Compile(updatedAtGt, nameof(updatedAtGt), required: false);
            var __workflow_updatedAtLt = WorkflowExpression.Compile(updatedAtLt, nameof(updatedAtLt), required: false);
            var __workflow_numberContains = WorkflowExpression.Compile(numberContains, nameof(numberContains), required: false);
            var __workflow_supplierId = WorkflowExpression.Compile(supplierId, nameof(supplierId), required: false);
            var __workflow_currencyCode = WorkflowExpression.Compile(currencyCode, nameof(currencyCode), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            var __workflow_returnObject = WorkflowExpression.Compile(returnObject, nameof(returnObject), required: false);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_orderBy = WorkflowExpression.Compile(orderBy, nameof(orderBy), required: false);
            var __workflow_dir = WorkflowExpression.Compile(dir, nameof(dir), required: false);
            var __workflow_orderLinesSourcePartNumContains = WorkflowExpression.Compile(orderLinesSourcePartNumContains, nameof(orderLinesSourcePartNumContains), required: false);
            var __workflow_orderLinesSourcePartNum = WorkflowExpression.Compile(orderLinesSourcePartNum, nameof(orderLinesSourcePartNum), required: false);
            return new DeferredBodyAction<PurchaseOrder[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/purchase_orders";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_statusIn != null)
                    callPayload.Queries["status[in]"] = ExpressionConverter.Convert(__workflow_statusIn);
                if (__workflow_supplierNameContains != null)
                    callPayload.Queries["supplier[name][contains]"] = ExpressionConverter.Convert(__workflow_supplierNameContains);
                if (__workflow_shipToAttentionContains != null)
                    callPayload.Queries["ship-to-attention[contains]"] = ExpressionConverter.Convert(__workflow_shipToAttentionContains);
                if (__workflow_createdAtGt != null)
                    callPayload.Queries["created-at[gt]"] = ExpressionConverter.Convert(__workflow_createdAtGt);
                if (__workflow_updatedAtGt != null)
                    callPayload.Queries["updated-at[gt]"] = ExpressionConverter.Convert(__workflow_updatedAtGt);
                if (__workflow_updatedAtLt != null)
                    callPayload.Queries["updated-at[lt]"] = ExpressionConverter.Convert(__workflow_updatedAtLt);
                if (__workflow_numberContains != null)
                    callPayload.Queries["number[contains]"] = ExpressionConverter.Convert(__workflow_numberContains);
                if (__workflow_supplierId != null)
                    callPayload.Queries["supplier[id]"] = ExpressionConverter.Convert(__workflow_supplierId);
                if (__workflow_currencyCode != null)
                    callPayload.Queries["currency[code]"] = ExpressionConverter.Convert(__workflow_currencyCode);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                if (__workflow_returnObject != null)
                    callPayload.Queries["return_object"] = ExpressionConverter.Convert(__workflow_returnObject);
                if (__workflow_filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_orderBy != null)
                    callPayload.Queries["order_by"] = ExpressionConverter.Convert(__workflow_orderBy);
                if (__workflow_dir != null)
                    callPayload.Queries["dir"] = ExpressionConverter.Convert(__workflow_dir);
                if (__workflow_orderLinesSourcePartNumContains != null)
                    callPayload.Queries["order_lines[source_part_num][contains]"] = ExpressionConverter.Convert(__workflow_orderLinesSourcePartNumContains);
                if (__workflow_orderLinesSourcePartNum != null)
                    callPayload.Queries["order_lines[source_part_num]"] = ExpressionConverter.Convert(__workflow_orderLinesSourcePartNum);
                callPayload.Headers["Access-Token"] = ExpressionConverter.Convert(__workflow_accessToken);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return new ApiConnectionAction<PurchaseOrder[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "coupaip")]
        public IBodyWorkflowAction<Attachment[], ApiConnectionActionConfiguration> POGetAttachments(Expression<Func<int>> id, Expression<Func<string>> accessToken)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_accessToken = WorkflowExpression.Compile(accessToken, nameof(accessToken), required: true);
            return new DeferredBodyAction<Attachment[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/purchase_orders/{0}/attachments", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["Access-Token"] = ExpressionConverter.Convert(__workflow_accessToken);
                return new ApiConnectionAction<Attachment[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "coupaip")]
        public IBodyWorkflowAction<PurchaseOrder, ApiConnectionActionConfiguration> POGetPurchaseOrderById(Expression<Func<string>> accessToken, Expression<Func<int>> id, Expression<Func<ReturnObjectInput>> returnObject = null, Expression<Func<string>> fields = null, Expression<Func<string>> filter = null)
        {
            var __workflow_accessToken = WorkflowExpression.Compile(accessToken, nameof(accessToken), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_returnObject = WorkflowExpression.Compile(returnObject, nameof(returnObject), required: false);
            var __workflow_fields = WorkflowExpression.Compile(fields, nameof(fields), required: false);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            return new DeferredBodyAction<PurchaseOrder, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/purchase_orders/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_returnObject != null)
                    callPayload.Queries["return_object"] = ExpressionConverter.Convert(__workflow_returnObject);
                if (__workflow_fields != null)
                    callPayload.Queries["fields"] = ExpressionConverter.Convert(__workflow_fields);
                if (__workflow_filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(__workflow_filter);
                callPayload.Headers["Access-Token"] = ExpressionConverter.Convert(__workflow_accessToken);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return new ApiConnectionAction<PurchaseOrder>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "coupaip")]
        public IBodyWorkflowAction<Comment[], ApiConnectionActionConfiguration> POGetPurchaseOrderComments(Expression<Func<string>> accessToken, Expression<Func<int>> id, Expression<Func<ReturnObjectInput>> returnObject = null, Expression<Func<string>> fields = null, Expression<Func<string>> filter = null)
        {
            var __workflow_accessToken = WorkflowExpression.Compile(accessToken, nameof(accessToken), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_returnObject = WorkflowExpression.Compile(returnObject, nameof(returnObject), required: false);
            var __workflow_fields = WorkflowExpression.Compile(fields, nameof(fields), required: false);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            return new DeferredBodyAction<Comment[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/purchase_orders/{0}/comments", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_returnObject != null)
                    callPayload.Queries["return_object"] = ExpressionConverter.Convert(__workflow_returnObject);
                if (__workflow_fields != null)
                    callPayload.Queries["fields"] = ExpressionConverter.Convert(__workflow_fields);
                if (__workflow_filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(__workflow_filter);
                callPayload.Headers["Access-Token"] = ExpressionConverter.Convert(__workflow_accessToken);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return new ApiConnectionAction<Comment[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "coupaip")]
        public IBodyWorkflowAction<Comment, ApiConnectionActionConfiguration> POCommentsPOCreate(Expression<Func<string>> accessToken, Expression<Func<int>> id, Expression<Func<POCommentsPOCreateBodyInput>> body = null)
        {
            var __workflow_accessToken = WorkflowExpression.Compile(accessToken, nameof(accessToken), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<Comment, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/purchase_orders/{0}/comments", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Access-Token"] = ExpressionConverter.Convert(__workflow_accessToken);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<Comment>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "coupaip")]
        public IBodyWorkflowAction<PurchaseOrder, ApiConnectionActionConfiguration> POIssuePurchaseOrder(Expression<Func<string>> accessToken, Expression<Func<int>> id)
        {
            var __workflow_accessToken = WorkflowExpression.Compile(accessToken, nameof(accessToken), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<PurchaseOrder, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/purchase_orders/{0}/issue", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Access-Token"] = ExpressionConverter.Convert(__workflow_accessToken);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return new ApiConnectionAction<PurchaseOrder>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "coupaip")]
        public IBodyWorkflowAction<PurchaseOrder, ApiConnectionActionConfiguration> POReopenPurchaseOrder(Expression<Func<string>> accessToken, Expression<Func<POReopenPurchaseOrderBodyInput>> body, Expression<Func<int>> id)
        {
            var __workflow_accessToken = WorkflowExpression.Compile(accessToken, nameof(accessToken), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<PurchaseOrder, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/purchase_orders/{0}/reopen", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Access-Token"] = ExpressionConverter.Convert(__workflow_accessToken);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PurchaseOrder>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "coupaip")]
        public IBodyWorkflowAction<PurchaseOrderChange[], ApiConnectionActionConfiguration> POChgGetPurchaseOrderChanges(Expression<Func<string>> accessToken, Expression<Func<string>> purchaseOrderId = null, Expression<Func<string>> createdAtGt = null, Expression<Func<string>> updatedAtGt = null, Expression<Func<string>> updatedAtLt = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null, Expression<Func<ReturnObjectInput>> returnObject = null, Expression<Func<string>> filter = null, Expression<Func<string>> orderBy = null, Expression<Func<DirInput>> dir = null, Expression<Func<string>> fields = null)
        {
            var __workflow_accessToken = WorkflowExpression.Compile(accessToken, nameof(accessToken), required: true);
            var __workflow_purchaseOrderId = WorkflowExpression.Compile(purchaseOrderId, nameof(purchaseOrderId), required: false);
            var __workflow_createdAtGt = WorkflowExpression.Compile(createdAtGt, nameof(createdAtGt), required: false);
            var __workflow_updatedAtGt = WorkflowExpression.Compile(updatedAtGt, nameof(updatedAtGt), required: false);
            var __workflow_updatedAtLt = WorkflowExpression.Compile(updatedAtLt, nameof(updatedAtLt), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            var __workflow_returnObject = WorkflowExpression.Compile(returnObject, nameof(returnObject), required: false);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_orderBy = WorkflowExpression.Compile(orderBy, nameof(orderBy), required: false);
            var __workflow_dir = WorkflowExpression.Compile(dir, nameof(dir), required: false);
            var __workflow_fields = WorkflowExpression.Compile(fields, nameof(fields), required: false);
            return new DeferredBodyAction<PurchaseOrderChange[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/purchase_order_changes";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_purchaseOrderId != null)
                    callPayload.Queries["purchase_order[id]"] = ExpressionConverter.Convert(__workflow_purchaseOrderId);
                if (__workflow_createdAtGt != null)
                    callPayload.Queries["created-at[gt]"] = ExpressionConverter.Convert(__workflow_createdAtGt);
                if (__workflow_updatedAtGt != null)
                    callPayload.Queries["updated-at[gt]"] = ExpressionConverter.Convert(__workflow_updatedAtGt);
                if (__workflow_updatedAtLt != null)
                    callPayload.Queries["updated-at[lt]"] = ExpressionConverter.Convert(__workflow_updatedAtLt);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                if (__workflow_returnObject != null)
                    callPayload.Queries["return_object"] = ExpressionConverter.Convert(__workflow_returnObject);
                if (__workflow_filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_orderBy != null)
                    callPayload.Queries["order_by"] = ExpressionConverter.Convert(__workflow_orderBy);
                if (__workflow_dir != null)
                    callPayload.Queries["dir"] = ExpressionConverter.Convert(__workflow_dir);
                if (__workflow_fields != null)
                    callPayload.Queries["fields"] = ExpressionConverter.Convert(__workflow_fields);
                callPayload.Headers["Access-Token"] = ExpressionConverter.Convert(__workflow_accessToken);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return new ApiConnectionAction<PurchaseOrderChange[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "coupaip")]
        public IBodyWorkflowAction<PurchaseOrderChange, ApiConnectionActionConfiguration> POChgGetPurchaseOrderChangeById(Expression<Func<string>> accessToken, Expression<Func<int>> id, Expression<Func<ReturnObjectInput>> returnObject = null, Expression<Func<string>> fields = null, Expression<Func<string>> filter = null)
        {
            var __workflow_accessToken = WorkflowExpression.Compile(accessToken, nameof(accessToken), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_returnObject = WorkflowExpression.Compile(returnObject, nameof(returnObject), required: false);
            var __workflow_fields = WorkflowExpression.Compile(fields, nameof(fields), required: false);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            return new DeferredBodyAction<PurchaseOrderChange, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/purchase_order_changes/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_returnObject != null)
                    callPayload.Queries["return_object"] = ExpressionConverter.Convert(__workflow_returnObject);
                if (__workflow_fields != null)
                    callPayload.Queries["fields"] = ExpressionConverter.Convert(__workflow_fields);
                if (__workflow_filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(__workflow_filter);
                callPayload.Headers["Access-Token"] = ExpressionConverter.Convert(__workflow_accessToken);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return new ApiConnectionAction<PurchaseOrderChange>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "coupaip")]
        public IBodyWorkflowAction<PurchaseOrderLine[], ApiConnectionActionConfiguration> POLineGetPurchaseOrderLines(Expression<Func<string>> accessToken, Expression<Func<string>> orderHeaderId = null, Expression<Func<string>> sourcePartNumContains = null, Expression<Func<string>> sourcePartNum = null, Expression<Func<string>> itemNameContains = null, Expression<Func<string>> status = null, Expression<Func<string>> orderHeaderSupplierId = null, Expression<Func<string>> createdAtGt = null, Expression<Func<string>> updatedAtGt = null, Expression<Func<string>> updatedAtLt = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null, Expression<Func<ReturnObjectInput>> returnObject = null, Expression<Func<string>> orderBy = null, Expression<Func<DirInput>> dir = null)
        {
            var __workflow_accessToken = WorkflowExpression.Compile(accessToken, nameof(accessToken), required: true);
            var __workflow_orderHeaderId = WorkflowExpression.Compile(orderHeaderId, nameof(orderHeaderId), required: false);
            var __workflow_sourcePartNumContains = WorkflowExpression.Compile(sourcePartNumContains, nameof(sourcePartNumContains), required: false);
            var __workflow_sourcePartNum = WorkflowExpression.Compile(sourcePartNum, nameof(sourcePartNum), required: false);
            var __workflow_itemNameContains = WorkflowExpression.Compile(itemNameContains, nameof(itemNameContains), required: false);
            var __workflow_status = WorkflowExpression.Compile(status, nameof(status), required: false);
            var __workflow_orderHeaderSupplierId = WorkflowExpression.Compile(orderHeaderSupplierId, nameof(orderHeaderSupplierId), required: false);
            var __workflow_createdAtGt = WorkflowExpression.Compile(createdAtGt, nameof(createdAtGt), required: false);
            var __workflow_updatedAtGt = WorkflowExpression.Compile(updatedAtGt, nameof(updatedAtGt), required: false);
            var __workflow_updatedAtLt = WorkflowExpression.Compile(updatedAtLt, nameof(updatedAtLt), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            var __workflow_returnObject = WorkflowExpression.Compile(returnObject, nameof(returnObject), required: false);
            var __workflow_orderBy = WorkflowExpression.Compile(orderBy, nameof(orderBy), required: false);
            var __workflow_dir = WorkflowExpression.Compile(dir, nameof(dir), required: false);
            return new DeferredBodyAction<PurchaseOrderLine[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/purchase_order_lines";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_orderHeaderId != null)
                    callPayload.Queries["order_header[id]"] = ExpressionConverter.Convert(__workflow_orderHeaderId);
                if (__workflow_sourcePartNumContains != null)
                    callPayload.Queries["source_part_num[contains]"] = ExpressionConverter.Convert(__workflow_sourcePartNumContains);
                if (__workflow_sourcePartNum != null)
                    callPayload.Queries["source_part_num"] = ExpressionConverter.Convert(__workflow_sourcePartNum);
                if (__workflow_itemNameContains != null)
                    callPayload.Queries["item[name][contains]"] = ExpressionConverter.Convert(__workflow_itemNameContains);
                if (__workflow_status != null)
                    callPayload.Queries["status"] = ExpressionConverter.Convert(__workflow_status);
                if (__workflow_orderHeaderSupplierId != null)
                    callPayload.Queries["order_header[supplier][id]"] = ExpressionConverter.Convert(__workflow_orderHeaderSupplierId);
                if (__workflow_createdAtGt != null)
                    callPayload.Queries["created-at[gt]"] = ExpressionConverter.Convert(__workflow_createdAtGt);
                if (__workflow_updatedAtGt != null)
                    callPayload.Queries["updated-at[gt]"] = ExpressionConverter.Convert(__workflow_updatedAtGt);
                if (__workflow_updatedAtLt != null)
                    callPayload.Queries["updated-at[lt]"] = ExpressionConverter.Convert(__workflow_updatedAtLt);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                if (__workflow_returnObject != null)
                    callPayload.Queries["return_object"] = ExpressionConverter.Convert(__workflow_returnObject);
                if (__workflow_orderBy != null)
                    callPayload.Queries["order_by"] = ExpressionConverter.Convert(__workflow_orderBy);
                if (__workflow_dir != null)
                    callPayload.Queries["dir"] = ExpressionConverter.Convert(__workflow_dir);
                callPayload.Headers["Access-Token"] = ExpressionConverter.Convert(__workflow_accessToken);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return new ApiConnectionAction<PurchaseOrderLine[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "coupaip")]
        public IBodyWorkflowAction<Attachment[], ApiConnectionActionConfiguration> POLineGetAttachments(Expression<Func<int>> id, Expression<Func<string>> accessToken)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_accessToken = WorkflowExpression.Compile(accessToken, nameof(accessToken), required: true);
            return new DeferredBodyAction<Attachment[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/purchase_order_lines/{0}/attachments", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["Access-Token"] = ExpressionConverter.Convert(__workflow_accessToken);
                return new ApiConnectionAction<Attachment[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "coupaip")]
        public IBodyWorkflowAction<PurchaseOrderLine, ApiConnectionActionConfiguration> POLineGetPurchaseOrderLineById(Expression<Func<string>> accessToken, Expression<Func<int>> id, Expression<Func<ReturnObjectInput>> returnObject = null, Expression<Func<string>> fields = null, Expression<Func<string>> filter = null)
        {
            var __workflow_accessToken = WorkflowExpression.Compile(accessToken, nameof(accessToken), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_returnObject = WorkflowExpression.Compile(returnObject, nameof(returnObject), required: false);
            var __workflow_fields = WorkflowExpression.Compile(fields, nameof(fields), required: false);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            return new DeferredBodyAction<PurchaseOrderLine, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/purchase_order_lines/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_returnObject != null)
                    callPayload.Queries["return_object"] = ExpressionConverter.Convert(__workflow_returnObject);
                if (__workflow_fields != null)
                    callPayload.Queries["fields"] = ExpressionConverter.Convert(__workflow_fields);
                if (__workflow_filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(__workflow_filter);
                callPayload.Headers["Access-Token"] = ExpressionConverter.Convert(__workflow_accessToken);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return new ApiConnectionAction<PurchaseOrderLine>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "coupaip")]
        public IBodyWorkflowAction<ReceiptRequest[], ApiConnectionActionConfiguration> RcptReqGetReceiptRequests(Expression<Func<string>> accessToken, Expression<Func<RcptReqGetReceiptRequestsStatusInInput>> statusIn = null, Expression<Func<string>> createdAtGt = null, Expression<Func<string>> updatedAtGt = null, Expression<Func<string>> updatedAtLt = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null, Expression<Func<ReturnObjectInput>> returnObject = null, Expression<Func<string>> filter = null, Expression<Func<string>> orderBy = null, Expression<Func<DirInput>> dir = null)
        {
            var __workflow_accessToken = WorkflowExpression.Compile(accessToken, nameof(accessToken), required: true);
            var __workflow_statusIn = WorkflowExpression.Compile(statusIn, nameof(statusIn), required: false);
            var __workflow_createdAtGt = WorkflowExpression.Compile(createdAtGt, nameof(createdAtGt), required: false);
            var __workflow_updatedAtGt = WorkflowExpression.Compile(updatedAtGt, nameof(updatedAtGt), required: false);
            var __workflow_updatedAtLt = WorkflowExpression.Compile(updatedAtLt, nameof(updatedAtLt), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            var __workflow_returnObject = WorkflowExpression.Compile(returnObject, nameof(returnObject), required: false);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_orderBy = WorkflowExpression.Compile(orderBy, nameof(orderBy), required: false);
            var __workflow_dir = WorkflowExpression.Compile(dir, nameof(dir), required: false);
            return new DeferredBodyAction<ReceiptRequest[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/receipt_requests";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_statusIn != null)
                    callPayload.Queries["status[in]"] = ExpressionConverter.Convert(__workflow_statusIn);
                if (__workflow_createdAtGt != null)
                    callPayload.Queries["created-at[gt]"] = ExpressionConverter.Convert(__workflow_createdAtGt);
                if (__workflow_updatedAtGt != null)
                    callPayload.Queries["updated-at[gt]"] = ExpressionConverter.Convert(__workflow_updatedAtGt);
                if (__workflow_updatedAtLt != null)
                    callPayload.Queries["updated-at[lt]"] = ExpressionConverter.Convert(__workflow_updatedAtLt);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                if (__workflow_returnObject != null)
                    callPayload.Queries["return_object"] = ExpressionConverter.Convert(__workflow_returnObject);
                if (__workflow_filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_orderBy != null)
                    callPayload.Queries["order_by"] = ExpressionConverter.Convert(__workflow_orderBy);
                if (__workflow_dir != null)
                    callPayload.Queries["dir"] = ExpressionConverter.Convert(__workflow_dir);
                callPayload.Headers["Access-Token"] = ExpressionConverter.Convert(__workflow_accessToken);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return new ApiConnectionAction<ReceiptRequest[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "coupaip")]
        public IBodyWorkflowAction<ReceiptRequest, ApiConnectionActionConfiguration> RcptReqGetReceiptRequestById(Expression<Func<string>> accessToken, Expression<Func<int>> id, Expression<Func<ReturnObjectInput>> returnObject = null, Expression<Func<string>> fields = null, Expression<Func<string>> filter = null)
        {
            var __workflow_accessToken = WorkflowExpression.Compile(accessToken, nameof(accessToken), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_returnObject = WorkflowExpression.Compile(returnObject, nameof(returnObject), required: false);
            var __workflow_fields = WorkflowExpression.Compile(fields, nameof(fields), required: false);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            return new DeferredBodyAction<ReceiptRequest, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/receipt_requests/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_returnObject != null)
                    callPayload.Queries["return_object"] = ExpressionConverter.Convert(__workflow_returnObject);
                if (__workflow_fields != null)
                    callPayload.Queries["fields"] = ExpressionConverter.Convert(__workflow_fields);
                if (__workflow_filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(__workflow_filter);
                callPayload.Headers["Access-Token"] = ExpressionConverter.Convert(__workflow_accessToken);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return new ApiConnectionAction<ReceiptRequest>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "coupaip")]
        public IBodyWorkflowAction<ReceivingTransaction[], ApiConnectionActionConfiguration> RcvTxnGetReceivingTransactions(Expression<Func<string>> accessToken, Expression<Func<RcvTxnGetReceivingTransactionsStatusInInput>> statusIn = null, Expression<Func<string>> itemNameContains = null, Expression<Func<string>> orderLineOrderHeaderId = null, Expression<Func<string>> createdAtGt = null, Expression<Func<string>> updatedAtGt = null, Expression<Func<string>> updatedAtLt = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null, Expression<Func<ReturnObjectInput>> returnObject = null, Expression<Func<string>> filter = null, Expression<Func<string>> orderBy = null, Expression<Func<DirInput>> dir = null)
        {
            var __workflow_accessToken = WorkflowExpression.Compile(accessToken, nameof(accessToken), required: true);
            var __workflow_statusIn = WorkflowExpression.Compile(statusIn, nameof(statusIn), required: false);
            var __workflow_itemNameContains = WorkflowExpression.Compile(itemNameContains, nameof(itemNameContains), required: false);
            var __workflow_orderLineOrderHeaderId = WorkflowExpression.Compile(orderLineOrderHeaderId, nameof(orderLineOrderHeaderId), required: false);
            var __workflow_createdAtGt = WorkflowExpression.Compile(createdAtGt, nameof(createdAtGt), required: false);
            var __workflow_updatedAtGt = WorkflowExpression.Compile(updatedAtGt, nameof(updatedAtGt), required: false);
            var __workflow_updatedAtLt = WorkflowExpression.Compile(updatedAtLt, nameof(updatedAtLt), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            var __workflow_returnObject = WorkflowExpression.Compile(returnObject, nameof(returnObject), required: false);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_orderBy = WorkflowExpression.Compile(orderBy, nameof(orderBy), required: false);
            var __workflow_dir = WorkflowExpression.Compile(dir, nameof(dir), required: false);
            return new DeferredBodyAction<ReceivingTransaction[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/receiving_transactions";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_statusIn != null)
                    callPayload.Queries["status[in]"] = ExpressionConverter.Convert(__workflow_statusIn);
                if (__workflow_itemNameContains != null)
                    callPayload.Queries["item[name][contains]"] = ExpressionConverter.Convert(__workflow_itemNameContains);
                if (__workflow_orderLineOrderHeaderId != null)
                    callPayload.Queries["order_line[order_header][id]"] = ExpressionConverter.Convert(__workflow_orderLineOrderHeaderId);
                if (__workflow_createdAtGt != null)
                    callPayload.Queries["created-at[gt]"] = ExpressionConverter.Convert(__workflow_createdAtGt);
                if (__workflow_updatedAtGt != null)
                    callPayload.Queries["updated-at[gt]"] = ExpressionConverter.Convert(__workflow_updatedAtGt);
                if (__workflow_updatedAtLt != null)
                    callPayload.Queries["updated-at[lt]"] = ExpressionConverter.Convert(__workflow_updatedAtLt);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                if (__workflow_returnObject != null)
                    callPayload.Queries["return_object"] = ExpressionConverter.Convert(__workflow_returnObject);
                if (__workflow_filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_orderBy != null)
                    callPayload.Queries["order_by"] = ExpressionConverter.Convert(__workflow_orderBy);
                if (__workflow_dir != null)
                    callPayload.Queries["dir"] = ExpressionConverter.Convert(__workflow_dir);
                callPayload.Headers["Access-Token"] = ExpressionConverter.Convert(__workflow_accessToken);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return new ApiConnectionAction<ReceivingTransaction[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "coupaip")]
        public IBodyWorkflowAction<Attachment[], ApiConnectionActionConfiguration> RcvTxnGetAttachments(Expression<Func<int>> id, Expression<Func<string>> accessToken)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_accessToken = WorkflowExpression.Compile(accessToken, nameof(accessToken), required: true);
            return new DeferredBodyAction<Attachment[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/receiving_transactions/{0}/attachments", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["Access-Token"] = ExpressionConverter.Convert(__workflow_accessToken);
                return new ApiConnectionAction<Attachment[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "coupaip")]
        public IBodyWorkflowAction<ReceivingTransaction, ApiConnectionActionConfiguration> RcvTxnGetReceivingTransactionById(Expression<Func<string>> accessToken, Expression<Func<int>> id, Expression<Func<ReturnObjectInput>> returnObject = null, Expression<Func<string>> fields = null, Expression<Func<string>> filter = null)
        {
            var __workflow_accessToken = WorkflowExpression.Compile(accessToken, nameof(accessToken), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_returnObject = WorkflowExpression.Compile(returnObject, nameof(returnObject), required: false);
            var __workflow_fields = WorkflowExpression.Compile(fields, nameof(fields), required: false);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            return new DeferredBodyAction<ReceivingTransaction, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/receiving_transactions/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_returnObject != null)
                    callPayload.Queries["return_object"] = ExpressionConverter.Convert(__workflow_returnObject);
                if (__workflow_fields != null)
                    callPayload.Queries["fields"] = ExpressionConverter.Convert(__workflow_fields);
                if (__workflow_filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(__workflow_filter);
                callPayload.Headers["Access-Token"] = ExpressionConverter.Convert(__workflow_accessToken);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return new ApiConnectionAction<ReceivingTransaction>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "coupaip")]
        public IBodyWorkflowAction<Requisition[], ApiConnectionActionConfiguration> ReqGetRequisitions(Expression<Func<string>> accessToken, Expression<Func<ReqGetRequisitionsStatusInInput>> statusIn = null, Expression<Func<string>> requestedByLoginContains = null, Expression<Func<string>> reqTitleContains = null, Expression<Func<string>> requisitionLinesItemNameContains = null, Expression<Func<string>> createdAtGt = null, Expression<Func<string>> updatedAtGt = null, Expression<Func<string>> updatedAtLt = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null, Expression<Func<ReturnObjectInput>> returnObject = null, Expression<Func<string>> filter = null, Expression<Func<string>> orderBy = null, Expression<Func<DirInput>> dir = null)
        {
            var __workflow_accessToken = WorkflowExpression.Compile(accessToken, nameof(accessToken), required: true);
            var __workflow_statusIn = WorkflowExpression.Compile(statusIn, nameof(statusIn), required: false);
            var __workflow_requestedByLoginContains = WorkflowExpression.Compile(requestedByLoginContains, nameof(requestedByLoginContains), required: false);
            var __workflow_reqTitleContains = WorkflowExpression.Compile(reqTitleContains, nameof(reqTitleContains), required: false);
            var __workflow_requisitionLinesItemNameContains = WorkflowExpression.Compile(requisitionLinesItemNameContains, nameof(requisitionLinesItemNameContains), required: false);
            var __workflow_createdAtGt = WorkflowExpression.Compile(createdAtGt, nameof(createdAtGt), required: false);
            var __workflow_updatedAtGt = WorkflowExpression.Compile(updatedAtGt, nameof(updatedAtGt), required: false);
            var __workflow_updatedAtLt = WorkflowExpression.Compile(updatedAtLt, nameof(updatedAtLt), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            var __workflow_returnObject = WorkflowExpression.Compile(returnObject, nameof(returnObject), required: false);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_orderBy = WorkflowExpression.Compile(orderBy, nameof(orderBy), required: false);
            var __workflow_dir = WorkflowExpression.Compile(dir, nameof(dir), required: false);
            return new DeferredBodyAction<Requisition[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/requisitions";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_statusIn != null)
                    callPayload.Queries["status[in]"] = ExpressionConverter.Convert(__workflow_statusIn);
                if (__workflow_requestedByLoginContains != null)
                    callPayload.Queries["requested-by[login][contains]"] = ExpressionConverter.Convert(__workflow_requestedByLoginContains);
                if (__workflow_reqTitleContains != null)
                    callPayload.Queries["req-title[contains]"] = ExpressionConverter.Convert(__workflow_reqTitleContains);
                if (__workflow_requisitionLinesItemNameContains != null)
                    callPayload.Queries["requisition-lines[item][name][contains]"] = ExpressionConverter.Convert(__workflow_requisitionLinesItemNameContains);
                if (__workflow_createdAtGt != null)
                    callPayload.Queries["created-at[gt]"] = ExpressionConverter.Convert(__workflow_createdAtGt);
                if (__workflow_updatedAtGt != null)
                    callPayload.Queries["updated-at[gt]"] = ExpressionConverter.Convert(__workflow_updatedAtGt);
                if (__workflow_updatedAtLt != null)
                    callPayload.Queries["updated-at[lt]"] = ExpressionConverter.Convert(__workflow_updatedAtLt);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                if (__workflow_returnObject != null)
                    callPayload.Queries["return_object"] = ExpressionConverter.Convert(__workflow_returnObject);
                if (__workflow_filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_orderBy != null)
                    callPayload.Queries["order_by"] = ExpressionConverter.Convert(__workflow_orderBy);
                if (__workflow_dir != null)
                    callPayload.Queries["dir"] = ExpressionConverter.Convert(__workflow_dir);
                callPayload.Headers["Access-Token"] = ExpressionConverter.Convert(__workflow_accessToken);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return new ApiConnectionAction<Requisition[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "coupaip")]
        public IBodyWorkflowAction<Attachment[], ApiConnectionActionConfiguration> ReqGetAttachments(Expression<Func<int>> id, Expression<Func<string>> accessToken)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_accessToken = WorkflowExpression.Compile(accessToken, nameof(accessToken), required: true);
            return new DeferredBodyAction<Attachment[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/requisitions/{0}/attachments", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["Access-Token"] = ExpressionConverter.Convert(__workflow_accessToken);
                return new ApiConnectionAction<Attachment[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "coupaip")]
        public IBodyWorkflowAction<Requisition, ApiConnectionActionConfiguration> ReqGetRequisitionById(Expression<Func<string>> accessToken, Expression<Func<int>> id, Expression<Func<ReturnObjectInput>> returnObject = null, Expression<Func<string>> fields = null, Expression<Func<string>> filter = null)
        {
            var __workflow_accessToken = WorkflowExpression.Compile(accessToken, nameof(accessToken), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_returnObject = WorkflowExpression.Compile(returnObject, nameof(returnObject), required: false);
            var __workflow_fields = WorkflowExpression.Compile(fields, nameof(fields), required: false);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            return new DeferredBodyAction<Requisition, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/requisitions/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_returnObject != null)
                    callPayload.Queries["return_object"] = ExpressionConverter.Convert(__workflow_returnObject);
                if (__workflow_fields != null)
                    callPayload.Queries["fields"] = ExpressionConverter.Convert(__workflow_fields);
                if (__workflow_filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(__workflow_filter);
                callPayload.Headers["Access-Token"] = ExpressionConverter.Convert(__workflow_accessToken);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return new ApiConnectionAction<Requisition>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "coupaip")]
        public IBodyWorkflowAction<Comment[], ApiConnectionActionConfiguration> ReqGetComments(Expression<Func<int>> id, Expression<Func<string>> accessToken, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_accessToken = WorkflowExpression.Compile(accessToken, nameof(accessToken), required: true);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            return new DeferredBodyAction<Comment[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/requisitions/{0}/comments", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["Access-Token"] = ExpressionConverter.Convert(__workflow_accessToken);
                return new ApiConnectionAction<Comment[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "coupaip")]
        public IBodyWorkflowAction<Comment, ApiConnectionActionConfiguration> ReqPostComment(Expression<Func<int>> id, Expression<Func<string>> accessToken, Expression<Func<InvPostCommentBodyInput>> body)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_accessToken = WorkflowExpression.Compile(accessToken, nameof(accessToken), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<Comment, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/requisitions/{0}/comments", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["Access-Token"] = ExpressionConverter.Convert(__workflow_accessToken);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<Comment>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "coupaip")]
        public IBodyWorkflowAction<Requisition, ApiConnectionActionConfiguration> ReqAddToCartFreeText(Expression<Func<string>> accessToken, Expression<Func<ReqAddToCartFreeTextBodyInput>> body = null)
        {
            var __workflow_accessToken = WorkflowExpression.Compile(accessToken, nameof(accessToken), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<Requisition, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/requisitions/add_to_cart";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Access-Token"] = ExpressionConverter.Convert(__workflow_accessToken);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<Requisition>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "coupaip")]
        public IBodyWorkflowAction<Attachment[], ApiConnectionActionConfiguration> ReqLineGetAttachments(Expression<Func<int>> id, Expression<Func<string>> accessToken)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_accessToken = WorkflowExpression.Compile(accessToken, nameof(accessToken), required: true);
            return new DeferredBodyAction<Attachment[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/requisition_lines/{0}/attachments", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["Access-Token"] = ExpressionConverter.Convert(__workflow_accessToken);
                return new ApiConnectionAction<Attachment[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "coupaip")]
        public IBodyWorkflowAction<QuoteResponse, ApiConnectionActionConfiguration> SrcAwardQuoteResponse(Expression<Func<string>> accessToken, Expression<Func<int>> id, Expression<Func<SrcAwardQuoteResponseBodyInput>> body = null)
        {
            var __workflow_accessToken = WorkflowExpression.Compile(accessToken, nameof(accessToken), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<QuoteResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/quote_responses/{0}/award", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Access-Token"] = ExpressionConverter.Convert(__workflow_accessToken);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<QuoteResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "coupaip")]
        public IBodyWorkflowAction<QuoteResponse, ApiConnectionActionConfiguration> SrcRemoveQuoteResponseAward(Expression<Func<string>> accessToken, Expression<Func<int>> id)
        {
            var __workflow_accessToken = WorkflowExpression.Compile(accessToken, nameof(accessToken), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<QuoteResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/quote_responses/{0}/award", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Access-Token"] = ExpressionConverter.Convert(__workflow_accessToken);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return new ApiConnectionAction<QuoteResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "coupaip")]
        public IBodyWorkflowAction<Attachment[], ApiConnectionActionConfiguration> SrcGetAttachments(Expression<Func<int>> id, Expression<Func<string>> accessToken)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_accessToken = WorkflowExpression.Compile(accessToken, nameof(accessToken), required: true);
            return new DeferredBodyAction<Attachment[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/quote_requests/{0}/attachments", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["Access-Token"] = ExpressionConverter.Convert(__workflow_accessToken);
                return new ApiConnectionAction<Attachment[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "coupaip")]
        public IBodyWorkflowAction<QuoteRequest, ApiConnectionActionConfiguration> SrcGetQuoteRequestById(Expression<Func<string>> accessToken, Expression<Func<int>> id, Expression<Func<ReturnObjectInput>> returnObject = null, Expression<Func<string>> fields = null, Expression<Func<string>> filter = null)
        {
            var __workflow_accessToken = WorkflowExpression.Compile(accessToken, nameof(accessToken), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_returnObject = WorkflowExpression.Compile(returnObject, nameof(returnObject), required: false);
            var __workflow_fields = WorkflowExpression.Compile(fields, nameof(fields), required: false);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            return new DeferredBodyAction<QuoteRequest, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/quote_requests/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_returnObject != null)
                    callPayload.Queries["return_object"] = ExpressionConverter.Convert(__workflow_returnObject);
                if (__workflow_fields != null)
                    callPayload.Queries["fields"] = ExpressionConverter.Convert(__workflow_fields);
                if (__workflow_filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(__workflow_filter);
                callPayload.Headers["Access-Token"] = ExpressionConverter.Convert(__workflow_accessToken);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return new ApiConnectionAction<QuoteRequest>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "coupaip")]
        public IBodyWorkflowAction<QuoteRequest, ApiConnectionActionConfiguration> SrcUpdateQuoteRequest(Expression<Func<string>> accessToken, Expression<Func<int>> id, Expression<Func<SrcCreateQuoteRequestBodyInput>> body)
        {
            var __workflow_accessToken = WorkflowExpression.Compile(accessToken, nameof(accessToken), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<QuoteRequest, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/quote_requests/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Access-Token"] = ExpressionConverter.Convert(__workflow_accessToken);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<QuoteRequest>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "coupaip")]
        public IBodyWorkflowAction<QuoteRequest[], ApiConnectionActionConfiguration> SrcGetQuoteRequests(Expression<Func<string>> accessToken, Expression<Func<string>> descriptionContains = null, Expression<Func<string>> statusIn = null, Expression<Func<string>> eventTypeEq = null, Expression<Func<string>> exported = null, Expression<Func<string>> createdAtGt = null, Expression<Func<string>> updatedAtGt = null, Expression<Func<string>> updatedAtLt = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null, Expression<Func<ReturnObjectInput>> returnObject = null, Expression<Func<string>> filter = null, Expression<Func<string>> orderBy = null, Expression<Func<DirInput>> dir = null)
        {
            var __workflow_accessToken = WorkflowExpression.Compile(accessToken, nameof(accessToken), required: true);
            var __workflow_descriptionContains = WorkflowExpression.Compile(descriptionContains, nameof(descriptionContains), required: false);
            var __workflow_statusIn = WorkflowExpression.Compile(statusIn, nameof(statusIn), required: false);
            var __workflow_eventTypeEq = WorkflowExpression.Compile(eventTypeEq, nameof(eventTypeEq), required: false);
            var __workflow_exported = WorkflowExpression.Compile(exported, nameof(exported), required: false);
            var __workflow_createdAtGt = WorkflowExpression.Compile(createdAtGt, nameof(createdAtGt), required: false);
            var __workflow_updatedAtGt = WorkflowExpression.Compile(updatedAtGt, nameof(updatedAtGt), required: false);
            var __workflow_updatedAtLt = WorkflowExpression.Compile(updatedAtLt, nameof(updatedAtLt), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            var __workflow_returnObject = WorkflowExpression.Compile(returnObject, nameof(returnObject), required: false);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_orderBy = WorkflowExpression.Compile(orderBy, nameof(orderBy), required: false);
            var __workflow_dir = WorkflowExpression.Compile(dir, nameof(dir), required: false);
            return new DeferredBodyAction<QuoteRequest[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/quote_requests";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_descriptionContains != null)
                    callPayload.Queries["description[contains]"] = ExpressionConverter.Convert(__workflow_descriptionContains);
                if (__workflow_statusIn != null)
                    callPayload.Queries["status[in]"] = ExpressionConverter.Convert(__workflow_statusIn);
                if (__workflow_eventTypeEq != null)
                    callPayload.Queries["event-type[eq]"] = ExpressionConverter.Convert(__workflow_eventTypeEq);
                if (__workflow_exported != null)
                    callPayload.Queries["exported"] = ExpressionConverter.Convert(__workflow_exported);
                if (__workflow_createdAtGt != null)
                    callPayload.Queries["created-at[gt]"] = ExpressionConverter.Convert(__workflow_createdAtGt);
                if (__workflow_updatedAtGt != null)
                    callPayload.Queries["updated-at[gt]"] = ExpressionConverter.Convert(__workflow_updatedAtGt);
                if (__workflow_updatedAtLt != null)
                    callPayload.Queries["updated-at[lt]"] = ExpressionConverter.Convert(__workflow_updatedAtLt);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                if (__workflow_returnObject != null)
                    callPayload.Queries["return_object"] = ExpressionConverter.Convert(__workflow_returnObject);
                if (__workflow_filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_orderBy != null)
                    callPayload.Queries["order_by"] = ExpressionConverter.Convert(__workflow_orderBy);
                if (__workflow_dir != null)
                    callPayload.Queries["dir"] = ExpressionConverter.Convert(__workflow_dir);
                callPayload.Headers["Access-Token"] = ExpressionConverter.Convert(__workflow_accessToken);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return new ApiConnectionAction<QuoteRequest[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "coupaip")]
        public IBodyWorkflowAction<QuoteRequest, ApiConnectionActionConfiguration> SrcCreateQuoteRequest(Expression<Func<string>> accessToken, Expression<Func<SrcCreateQuoteRequestBodyInput>> body)
        {
            var __workflow_accessToken = WorkflowExpression.Compile(accessToken, nameof(accessToken), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<QuoteRequest, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/quote_requests";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Access-Token"] = ExpressionConverter.Convert(__workflow_accessToken);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<QuoteRequest>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "coupaip")]
        public IBodyWorkflowAction<QuoteResponse, ApiConnectionActionConfiguration> SrcGetQuoteResponseById(Expression<Func<string>> accessToken, Expression<Func<int>> id, Expression<Func<ReturnObjectInput>> returnObject = null)
        {
            var __workflow_accessToken = WorkflowExpression.Compile(accessToken, nameof(accessToken), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_returnObject = WorkflowExpression.Compile(returnObject, nameof(returnObject), required: false);
            return new DeferredBodyAction<QuoteResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/quote_responses/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_returnObject != null)
                    callPayload.Queries["return_object"] = ExpressionConverter.Convert(__workflow_returnObject);
                callPayload.Headers["Access-Token"] = ExpressionConverter.Convert(__workflow_accessToken);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return new ApiConnectionAction<QuoteResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "coupaip")]
        public IBodyWorkflowAction<QuoteResponse[], ApiConnectionActionConfiguration> SrcGetAllQuoteResponses(Expression<Func<string>> accessToken, Expression<Func<string>> awarded = null, Expression<Func<string>> updatedAtGt = null, Expression<Func<string>> updatedAtLt = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null, Expression<Func<ReturnObjectInput>> returnObject = null, Expression<Func<string>> orderBy = null, Expression<Func<DirInput>> dir = null)
        {
            var __workflow_accessToken = WorkflowExpression.Compile(accessToken, nameof(accessToken), required: true);
            var __workflow_awarded = WorkflowExpression.Compile(awarded, nameof(awarded), required: false);
            var __workflow_updatedAtGt = WorkflowExpression.Compile(updatedAtGt, nameof(updatedAtGt), required: false);
            var __workflow_updatedAtLt = WorkflowExpression.Compile(updatedAtLt, nameof(updatedAtLt), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            var __workflow_returnObject = WorkflowExpression.Compile(returnObject, nameof(returnObject), required: false);
            var __workflow_orderBy = WorkflowExpression.Compile(orderBy, nameof(orderBy), required: false);
            var __workflow_dir = WorkflowExpression.Compile(dir, nameof(dir), required: false);
            return new DeferredBodyAction<QuoteResponse[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/quote_responses";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_awarded != null)
                    callPayload.Queries["awarded"] = ExpressionConverter.Convert(__workflow_awarded);
                if (__workflow_updatedAtGt != null)
                    callPayload.Queries["updated-at[gt]"] = ExpressionConverter.Convert(__workflow_updatedAtGt);
                if (__workflow_updatedAtLt != null)
                    callPayload.Queries["updated-at[lt]"] = ExpressionConverter.Convert(__workflow_updatedAtLt);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                if (__workflow_returnObject != null)
                    callPayload.Queries["return_object"] = ExpressionConverter.Convert(__workflow_returnObject);
                if (__workflow_orderBy != null)
                    callPayload.Queries["order_by"] = ExpressionConverter.Convert(__workflow_orderBy);
                if (__workflow_dir != null)
                    callPayload.Queries["dir"] = ExpressionConverter.Convert(__workflow_dir);
                callPayload.Headers["Access-Token"] = ExpressionConverter.Convert(__workflow_accessToken);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return new ApiConnectionAction<QuoteResponse[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "coupaip")]
        public IBodyWorkflowAction<QuoteResponse[], ApiConnectionActionConfiguration> SrcGetQuoteResponses(Expression<Func<string>> accessToken, Expression<Func<int>> quoteRequestId, Expression<Func<string>> awarded = null, Expression<Func<string>> createdAtGt = null, Expression<Func<string>> updatedAtGt = null, Expression<Func<string>> updatedAtLt = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null, Expression<Func<ReturnObjectInput>> returnObject = null, Expression<Func<string>> orderBy = null, Expression<Func<DirInput>> dir = null)
        {
            var __workflow_accessToken = WorkflowExpression.Compile(accessToken, nameof(accessToken), required: true);
            var __workflow_quoteRequestId = WorkflowExpression.Compile(quoteRequestId, nameof(quoteRequestId), required: true);
            var __workflow_awarded = WorkflowExpression.Compile(awarded, nameof(awarded), required: false);
            var __workflow_createdAtGt = WorkflowExpression.Compile(createdAtGt, nameof(createdAtGt), required: false);
            var __workflow_updatedAtGt = WorkflowExpression.Compile(updatedAtGt, nameof(updatedAtGt), required: false);
            var __workflow_updatedAtLt = WorkflowExpression.Compile(updatedAtLt, nameof(updatedAtLt), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            var __workflow_returnObject = WorkflowExpression.Compile(returnObject, nameof(returnObject), required: false);
            var __workflow_orderBy = WorkflowExpression.Compile(orderBy, nameof(orderBy), required: false);
            var __workflow_dir = WorkflowExpression.Compile(dir, nameof(dir), required: false);
            return new DeferredBodyAction<QuoteResponse[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/quote_requests/{0}/quote_responses", __workflow_quoteRequestId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_awarded != null)
                    callPayload.Queries["awarded"] = ExpressionConverter.Convert(__workflow_awarded);
                if (__workflow_createdAtGt != null)
                    callPayload.Queries["created-at[gt]"] = ExpressionConverter.Convert(__workflow_createdAtGt);
                if (__workflow_updatedAtGt != null)
                    callPayload.Queries["updated-at[gt]"] = ExpressionConverter.Convert(__workflow_updatedAtGt);
                if (__workflow_updatedAtLt != null)
                    callPayload.Queries["updated-at[lt]"] = ExpressionConverter.Convert(__workflow_updatedAtLt);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                if (__workflow_returnObject != null)
                    callPayload.Queries["return_object"] = ExpressionConverter.Convert(__workflow_returnObject);
                if (__workflow_orderBy != null)
                    callPayload.Queries["order_by"] = ExpressionConverter.Convert(__workflow_orderBy);
                if (__workflow_dir != null)
                    callPayload.Queries["dir"] = ExpressionConverter.Convert(__workflow_dir);
                callPayload.Headers["Access-Token"] = ExpressionConverter.Convert(__workflow_accessToken);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return new ApiConnectionAction<QuoteResponse[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "coupaip")]
        public IBodyWorkflowAction<QuoteResponse[], ApiConnectionActionConfiguration> SrcGetAllQuoteResponsesForEvent(Expression<Func<string>> accessToken, Expression<Func<int>> quoteRequestId, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null, Expression<Func<ReturnObjectInput>> returnObject = null)
        {
            var __workflow_accessToken = WorkflowExpression.Compile(accessToken, nameof(accessToken), required: true);
            var __workflow_quoteRequestId = WorkflowExpression.Compile(quoteRequestId, nameof(quoteRequestId), required: true);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            var __workflow_returnObject = WorkflowExpression.Compile(returnObject, nameof(returnObject), required: false);
            return new DeferredBodyAction<QuoteResponse[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/quote_requests/{0}/quote_responses/all", __workflow_quoteRequestId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                if (__workflow_returnObject != null)
                    callPayload.Queries["return_object"] = ExpressionConverter.Convert(__workflow_returnObject);
                callPayload.Headers["Access-Token"] = ExpressionConverter.Convert(__workflow_accessToken);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return new ApiConnectionAction<QuoteResponse[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "coupaip")]
        public IBodyWorkflowAction<QuoteResponse[], ApiConnectionActionConfiguration> SrcGetAllQuoteResponsesIncludingDrafts(Expression<Func<string>> accessToken, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null, Expression<Func<ReturnObjectInput>> returnObject = null, Expression<Func<string>> updatedAtGt = null, Expression<Func<string>> updatedAtLt = null)
        {
            var __workflow_accessToken = WorkflowExpression.Compile(accessToken, nameof(accessToken), required: true);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            var __workflow_returnObject = WorkflowExpression.Compile(returnObject, nameof(returnObject), required: false);
            var __workflow_updatedAtGt = WorkflowExpression.Compile(updatedAtGt, nameof(updatedAtGt), required: false);
            var __workflow_updatedAtLt = WorkflowExpression.Compile(updatedAtLt, nameof(updatedAtLt), required: false);
            return new DeferredBodyAction<QuoteResponse[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/quote_responses/all";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                if (__workflow_returnObject != null)
                    callPayload.Queries["return_object"] = ExpressionConverter.Convert(__workflow_returnObject);
                if (__workflow_updatedAtGt != null)
                    callPayload.Queries["updated-at[gt]"] = ExpressionConverter.Convert(__workflow_updatedAtGt);
                if (__workflow_updatedAtLt != null)
                    callPayload.Queries["updated-at[lt]"] = ExpressionConverter.Convert(__workflow_updatedAtLt);
                callPayload.Headers["Access-Token"] = ExpressionConverter.Convert(__workflow_accessToken);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return new ApiConnectionAction<QuoteResponse[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "coupaip")]
        public IBodyWorkflowAction<CntrGetContractByIdSupplierResponse[], ApiConnectionActionConfiguration> SupGetSuppliers(Expression<Func<string>> accessToken, Expression<Func<string>> nameContains = null, Expression<Func<string>> numberContains = null, Expression<Func<SupGetSuppliersStatusInInput>> statusIn = null, Expression<Func<string>> createdAtGt = null, Expression<Func<string>> updatedAtGt = null, Expression<Func<string>> updatedAtLt = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null, Expression<Func<ReturnObjectInput>> returnObject = null, Expression<Func<string>> filter = null, Expression<Func<string>> orderBy = null, Expression<Func<DirInput>> dir = null)
        {
            var __workflow_accessToken = WorkflowExpression.Compile(accessToken, nameof(accessToken), required: true);
            var __workflow_nameContains = WorkflowExpression.Compile(nameContains, nameof(nameContains), required: false);
            var __workflow_numberContains = WorkflowExpression.Compile(numberContains, nameof(numberContains), required: false);
            var __workflow_statusIn = WorkflowExpression.Compile(statusIn, nameof(statusIn), required: false);
            var __workflow_createdAtGt = WorkflowExpression.Compile(createdAtGt, nameof(createdAtGt), required: false);
            var __workflow_updatedAtGt = WorkflowExpression.Compile(updatedAtGt, nameof(updatedAtGt), required: false);
            var __workflow_updatedAtLt = WorkflowExpression.Compile(updatedAtLt, nameof(updatedAtLt), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            var __workflow_returnObject = WorkflowExpression.Compile(returnObject, nameof(returnObject), required: false);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_orderBy = WorkflowExpression.Compile(orderBy, nameof(orderBy), required: false);
            var __workflow_dir = WorkflowExpression.Compile(dir, nameof(dir), required: false);
            return new DeferredBodyAction<CntrGetContractByIdSupplierResponse[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/suppliers";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_nameContains != null)
                    callPayload.Queries["name[contains]"] = ExpressionConverter.Convert(__workflow_nameContains);
                if (__workflow_numberContains != null)
                    callPayload.Queries["number[contains]"] = ExpressionConverter.Convert(__workflow_numberContains);
                if (__workflow_statusIn != null)
                    callPayload.Queries["status[in]"] = ExpressionConverter.Convert(__workflow_statusIn);
                if (__workflow_createdAtGt != null)
                    callPayload.Queries["created-at[gt]"] = ExpressionConverter.Convert(__workflow_createdAtGt);
                if (__workflow_updatedAtGt != null)
                    callPayload.Queries["updated-at[gt]"] = ExpressionConverter.Convert(__workflow_updatedAtGt);
                if (__workflow_updatedAtLt != null)
                    callPayload.Queries["updated-at[lt]"] = ExpressionConverter.Convert(__workflow_updatedAtLt);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                if (__workflow_returnObject != null)
                    callPayload.Queries["return_object"] = ExpressionConverter.Convert(__workflow_returnObject);
                if (__workflow_filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_orderBy != null)
                    callPayload.Queries["order_by"] = ExpressionConverter.Convert(__workflow_orderBy);
                if (__workflow_dir != null)
                    callPayload.Queries["dir"] = ExpressionConverter.Convert(__workflow_dir);
                callPayload.Headers["Access-Token"] = ExpressionConverter.Convert(__workflow_accessToken);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return new ApiConnectionAction<CntrGetContractByIdSupplierResponse[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "coupaip")]
        public IBodyWorkflowAction<CntrGetContractByIdSupplierResponse, ApiConnectionActionConfiguration> SupGetSupplierById(Expression<Func<string>> accessToken, Expression<Func<int>> id, Expression<Func<ReturnObjectInput>> returnObject = null, Expression<Func<string>> fields = null, Expression<Func<string>> filter = null)
        {
            var __workflow_accessToken = WorkflowExpression.Compile(accessToken, nameof(accessToken), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_returnObject = WorkflowExpression.Compile(returnObject, nameof(returnObject), required: false);
            var __workflow_fields = WorkflowExpression.Compile(fields, nameof(fields), required: false);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            return new DeferredBodyAction<CntrGetContractByIdSupplierResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/suppliers/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_returnObject != null)
                    callPayload.Queries["return_object"] = ExpressionConverter.Convert(__workflow_returnObject);
                if (__workflow_fields != null)
                    callPayload.Queries["fields"] = ExpressionConverter.Convert(__workflow_fields);
                if (__workflow_filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(__workflow_filter);
                callPayload.Headers["Access-Token"] = ExpressionConverter.Convert(__workflow_accessToken);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return new ApiConnectionAction<CntrGetContractByIdSupplierResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "coupaip")]
        public IBodyWorkflowAction<CntrGetContractByIdSupplierResponse, ApiConnectionActionConfiguration> SupUpdateSupplier(Expression<Func<string>> accessToken, Expression<Func<int>> id, Expression<Func<SupUpdateSupplierBodyInput>> body)
        {
            var __workflow_accessToken = WorkflowExpression.Compile(accessToken, nameof(accessToken), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CntrGetContractByIdSupplierResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/suppliers/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Access-Token"] = ExpressionConverter.Convert(__workflow_accessToken);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CntrGetContractByIdSupplierResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "coupaip")]
        public IBodyWorkflowAction<SupplierInformation[], ApiConnectionActionConfiguration> SupInfoGetSupplierInformation(Expression<Func<string>> accessToken, Expression<Func<string>> nameContains = null, Expression<Func<string>> statusIn = null, Expression<Func<string>> updatedAtGt = null, Expression<Func<string>> updatedAtLt = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null, Expression<Func<ReturnObjectInput>> returnObject = null, Expression<Func<string>> filter = null, Expression<Func<string>> orderBy = null, Expression<Func<DirInput>> dir = null)
        {
            var __workflow_accessToken = WorkflowExpression.Compile(accessToken, nameof(accessToken), required: true);
            var __workflow_nameContains = WorkflowExpression.Compile(nameContains, nameof(nameContains), required: false);
            var __workflow_statusIn = WorkflowExpression.Compile(statusIn, nameof(statusIn), required: false);
            var __workflow_updatedAtGt = WorkflowExpression.Compile(updatedAtGt, nameof(updatedAtGt), required: false);
            var __workflow_updatedAtLt = WorkflowExpression.Compile(updatedAtLt, nameof(updatedAtLt), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            var __workflow_returnObject = WorkflowExpression.Compile(returnObject, nameof(returnObject), required: false);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_orderBy = WorkflowExpression.Compile(orderBy, nameof(orderBy), required: false);
            var __workflow_dir = WorkflowExpression.Compile(dir, nameof(dir), required: false);
            return new DeferredBodyAction<SupplierInformation[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/supplier_information";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_nameContains != null)
                    callPayload.Queries["name[contains]"] = ExpressionConverter.Convert(__workflow_nameContains);
                if (__workflow_statusIn != null)
                    callPayload.Queries["status[in]"] = ExpressionConverter.Convert(__workflow_statusIn);
                if (__workflow_updatedAtGt != null)
                    callPayload.Queries["updated-at[gt]"] = ExpressionConverter.Convert(__workflow_updatedAtGt);
                if (__workflow_updatedAtLt != null)
                    callPayload.Queries["updated-at[lt]"] = ExpressionConverter.Convert(__workflow_updatedAtLt);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                if (__workflow_returnObject != null)
                    callPayload.Queries["return_object"] = ExpressionConverter.Convert(__workflow_returnObject);
                if (__workflow_filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_orderBy != null)
                    callPayload.Queries["order_by"] = ExpressionConverter.Convert(__workflow_orderBy);
                if (__workflow_dir != null)
                    callPayload.Queries["dir"] = ExpressionConverter.Convert(__workflow_dir);
                callPayload.Headers["Access-Token"] = ExpressionConverter.Convert(__workflow_accessToken);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return new ApiConnectionAction<SupplierInformation[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "coupaip")]
        public IBodyWorkflowAction<SupplierInformation, ApiConnectionActionConfiguration> SupInfoGetSupplierInformationById(Expression<Func<string>> accessToken, Expression<Func<int>> id, Expression<Func<ReturnObjectInput>> returnObject = null, Expression<Func<string>> fields = null, Expression<Func<string>> filter = null)
        {
            var __workflow_accessToken = WorkflowExpression.Compile(accessToken, nameof(accessToken), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_returnObject = WorkflowExpression.Compile(returnObject, nameof(returnObject), required: false);
            var __workflow_fields = WorkflowExpression.Compile(fields, nameof(fields), required: false);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            return new DeferredBodyAction<SupplierInformation, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/supplier_information/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_returnObject != null)
                    callPayload.Queries["return_object"] = ExpressionConverter.Convert(__workflow_returnObject);
                if (__workflow_fields != null)
                    callPayload.Queries["fields"] = ExpressionConverter.Convert(__workflow_fields);
                if (__workflow_filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(__workflow_filter);
                callPayload.Headers["Access-Token"] = ExpressionConverter.Convert(__workflow_accessToken);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return new ApiConnectionAction<SupplierInformation>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "coupaip")]
        public IBodyWorkflowAction<SupplierItem[], ApiConnectionActionConfiguration> SupItemGetSupplierItems(Expression<Func<string>> accessToken, Expression<Func<string>> itemNameContains = null, Expression<Func<string>> supplierNameContains = null, Expression<Func<string>> supplierPartNumContains = null, Expression<Func<string>> supplierId = null, Expression<Func<string>> createdAtGt = null, Expression<Func<string>> updatedAtGt = null, Expression<Func<string>> updatedAtLt = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null, Expression<Func<ReturnObjectInput>> returnObject = null, Expression<Func<string>> filter = null, Expression<Func<string>> orderBy = null, Expression<Func<DirInput>> dir = null)
        {
            var __workflow_accessToken = WorkflowExpression.Compile(accessToken, nameof(accessToken), required: true);
            var __workflow_itemNameContains = WorkflowExpression.Compile(itemNameContains, nameof(itemNameContains), required: false);
            var __workflow_supplierNameContains = WorkflowExpression.Compile(supplierNameContains, nameof(supplierNameContains), required: false);
            var __workflow_supplierPartNumContains = WorkflowExpression.Compile(supplierPartNumContains, nameof(supplierPartNumContains), required: false);
            var __workflow_supplierId = WorkflowExpression.Compile(supplierId, nameof(supplierId), required: false);
            var __workflow_createdAtGt = WorkflowExpression.Compile(createdAtGt, nameof(createdAtGt), required: false);
            var __workflow_updatedAtGt = WorkflowExpression.Compile(updatedAtGt, nameof(updatedAtGt), required: false);
            var __workflow_updatedAtLt = WorkflowExpression.Compile(updatedAtLt, nameof(updatedAtLt), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            var __workflow_returnObject = WorkflowExpression.Compile(returnObject, nameof(returnObject), required: false);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_orderBy = WorkflowExpression.Compile(orderBy, nameof(orderBy), required: false);
            var __workflow_dir = WorkflowExpression.Compile(dir, nameof(dir), required: false);
            return new DeferredBodyAction<SupplierItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/supplier_items";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_itemNameContains != null)
                    callPayload.Queries["item[name][contains]"] = ExpressionConverter.Convert(__workflow_itemNameContains);
                if (__workflow_supplierNameContains != null)
                    callPayload.Queries["supplier[name][contains]"] = ExpressionConverter.Convert(__workflow_supplierNameContains);
                if (__workflow_supplierPartNumContains != null)
                    callPayload.Queries["supplier-part-num[contains]"] = ExpressionConverter.Convert(__workflow_supplierPartNumContains);
                if (__workflow_supplierId != null)
                    callPayload.Queries["supplier[id]"] = ExpressionConverter.Convert(__workflow_supplierId);
                if (__workflow_createdAtGt != null)
                    callPayload.Queries["created-at[gt]"] = ExpressionConverter.Convert(__workflow_createdAtGt);
                if (__workflow_updatedAtGt != null)
                    callPayload.Queries["updated-at[gt]"] = ExpressionConverter.Convert(__workflow_updatedAtGt);
                if (__workflow_updatedAtLt != null)
                    callPayload.Queries["updated-at[lt]"] = ExpressionConverter.Convert(__workflow_updatedAtLt);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                if (__workflow_returnObject != null)
                    callPayload.Queries["return_object"] = ExpressionConverter.Convert(__workflow_returnObject);
                if (__workflow_filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_orderBy != null)
                    callPayload.Queries["order_by"] = ExpressionConverter.Convert(__workflow_orderBy);
                if (__workflow_dir != null)
                    callPayload.Queries["dir"] = ExpressionConverter.Convert(__workflow_dir);
                callPayload.Headers["Access-Token"] = ExpressionConverter.Convert(__workflow_accessToken);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return new ApiConnectionAction<SupplierItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "coupaip")]
        public IBodyWorkflowAction<SupplierItem, ApiConnectionActionConfiguration> SupItemGetSupplierItemById(Expression<Func<string>> accessToken, Expression<Func<int>> id, Expression<Func<ReturnObjectInput>> returnObject = null, Expression<Func<string>> fields = null, Expression<Func<string>> filter = null)
        {
            var __workflow_accessToken = WorkflowExpression.Compile(accessToken, nameof(accessToken), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_returnObject = WorkflowExpression.Compile(returnObject, nameof(returnObject), required: false);
            var __workflow_fields = WorkflowExpression.Compile(fields, nameof(fields), required: false);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            return new DeferredBodyAction<SupplierItem, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/supplier_items/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_returnObject != null)
                    callPayload.Queries["return_object"] = ExpressionConverter.Convert(__workflow_returnObject);
                if (__workflow_fields != null)
                    callPayload.Queries["fields"] = ExpressionConverter.Convert(__workflow_fields);
                if (__workflow_filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(__workflow_filter);
                callPayload.Headers["Access-Token"] = ExpressionConverter.Convert(__workflow_accessToken);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return new ApiConnectionAction<SupplierItem>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "coupaip")]
        public IBodyWorkflowAction<UserGroup[], ApiConnectionActionConfiguration> UGGetUserGroups(Expression<Func<string>> accessToken, Expression<Func<string>> nameContains = null, Expression<Func<bool>> active = null, Expression<Func<string>> createdAtGt = null, Expression<Func<string>> updatedAtGt = null, Expression<Func<string>> updatedAtLt = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null, Expression<Func<ReturnObjectInput>> returnObject = null, Expression<Func<string>> filter = null, Expression<Func<string>> orderBy = null, Expression<Func<DirInput>> dir = null)
        {
            var __workflow_accessToken = WorkflowExpression.Compile(accessToken, nameof(accessToken), required: true);
            var __workflow_nameContains = WorkflowExpression.Compile(nameContains, nameof(nameContains), required: false);
            var __workflow_active = WorkflowExpression.Compile(active, nameof(active), required: false);
            var __workflow_createdAtGt = WorkflowExpression.Compile(createdAtGt, nameof(createdAtGt), required: false);
            var __workflow_updatedAtGt = WorkflowExpression.Compile(updatedAtGt, nameof(updatedAtGt), required: false);
            var __workflow_updatedAtLt = WorkflowExpression.Compile(updatedAtLt, nameof(updatedAtLt), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            var __workflow_returnObject = WorkflowExpression.Compile(returnObject, nameof(returnObject), required: false);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_orderBy = WorkflowExpression.Compile(orderBy, nameof(orderBy), required: false);
            var __workflow_dir = WorkflowExpression.Compile(dir, nameof(dir), required: false);
            return new DeferredBodyAction<UserGroup[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/user_groups";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_nameContains != null)
                    callPayload.Queries["name[contains]"] = ExpressionConverter.Convert(__workflow_nameContains);
                if (__workflow_active != null)
                    callPayload.Queries["active"] = ExpressionConverter.Convert(__workflow_active);
                if (__workflow_createdAtGt != null)
                    callPayload.Queries["created-at[gt]"] = ExpressionConverter.Convert(__workflow_createdAtGt);
                if (__workflow_updatedAtGt != null)
                    callPayload.Queries["updated-at[gt]"] = ExpressionConverter.Convert(__workflow_updatedAtGt);
                if (__workflow_updatedAtLt != null)
                    callPayload.Queries["updated-at[lt]"] = ExpressionConverter.Convert(__workflow_updatedAtLt);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                if (__workflow_returnObject != null)
                    callPayload.Queries["return_object"] = ExpressionConverter.Convert(__workflow_returnObject);
                if (__workflow_filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_orderBy != null)
                    callPayload.Queries["order_by"] = ExpressionConverter.Convert(__workflow_orderBy);
                if (__workflow_dir != null)
                    callPayload.Queries["dir"] = ExpressionConverter.Convert(__workflow_dir);
                callPayload.Headers["Access-Token"] = ExpressionConverter.Convert(__workflow_accessToken);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return new ApiConnectionAction<UserGroup[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "coupaip")]
        public IBodyWorkflowAction<UserGroup, ApiConnectionActionConfiguration> UGGetUserGroupById(Expression<Func<string>> accessToken, Expression<Func<int>> id, Expression<Func<ReturnObjectInput>> returnObject = null, Expression<Func<string>> fields = null, Expression<Func<string>> filter = null)
        {
            var __workflow_accessToken = WorkflowExpression.Compile(accessToken, nameof(accessToken), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_returnObject = WorkflowExpression.Compile(returnObject, nameof(returnObject), required: false);
            var __workflow_fields = WorkflowExpression.Compile(fields, nameof(fields), required: false);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            return new DeferredBodyAction<UserGroup, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/user_groups/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_returnObject != null)
                    callPayload.Queries["return_object"] = ExpressionConverter.Convert(__workflow_returnObject);
                if (__workflow_fields != null)
                    callPayload.Queries["fields"] = ExpressionConverter.Convert(__workflow_fields);
                if (__workflow_filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(__workflow_filter);
                callPayload.Headers["Access-Token"] = ExpressionConverter.Convert(__workflow_accessToken);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return new ApiConnectionAction<UserGroup>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "coupaip")]
        public IBodyWorkflowAction<UserGroupMembership[], ApiConnectionActionConfiguration> UGMGetUserGroupMemberships(Expression<Func<string>> accessToken, Expression<Func<string>> userLoginContains = null, Expression<Func<string>> userGroupNameContains = null, Expression<Func<string>> createdAtGt = null, Expression<Func<string>> updatedAtGt = null, Expression<Func<string>> updatedAtLt = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null, Expression<Func<ReturnObjectInput>> returnObject = null, Expression<Func<string>> filter = null, Expression<Func<string>> orderBy = null, Expression<Func<DirInput>> dir = null)
        {
            var __workflow_accessToken = WorkflowExpression.Compile(accessToken, nameof(accessToken), required: true);
            var __workflow_userLoginContains = WorkflowExpression.Compile(userLoginContains, nameof(userLoginContains), required: false);
            var __workflow_userGroupNameContains = WorkflowExpression.Compile(userGroupNameContains, nameof(userGroupNameContains), required: false);
            var __workflow_createdAtGt = WorkflowExpression.Compile(createdAtGt, nameof(createdAtGt), required: false);
            var __workflow_updatedAtGt = WorkflowExpression.Compile(updatedAtGt, nameof(updatedAtGt), required: false);
            var __workflow_updatedAtLt = WorkflowExpression.Compile(updatedAtLt, nameof(updatedAtLt), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            var __workflow_returnObject = WorkflowExpression.Compile(returnObject, nameof(returnObject), required: false);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_orderBy = WorkflowExpression.Compile(orderBy, nameof(orderBy), required: false);
            var __workflow_dir = WorkflowExpression.Compile(dir, nameof(dir), required: false);
            return new DeferredBodyAction<UserGroupMembership[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/user_group_memberships";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_userLoginContains != null)
                    callPayload.Queries["user[login][contains]"] = ExpressionConverter.Convert(__workflow_userLoginContains);
                if (__workflow_userGroupNameContains != null)
                    callPayload.Queries["user_group[name][contains]"] = ExpressionConverter.Convert(__workflow_userGroupNameContains);
                if (__workflow_createdAtGt != null)
                    callPayload.Queries["created-at[gt]"] = ExpressionConverter.Convert(__workflow_createdAtGt);
                if (__workflow_updatedAtGt != null)
                    callPayload.Queries["updated-at[gt]"] = ExpressionConverter.Convert(__workflow_updatedAtGt);
                if (__workflow_updatedAtLt != null)
                    callPayload.Queries["updated-at[lt]"] = ExpressionConverter.Convert(__workflow_updatedAtLt);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                if (__workflow_returnObject != null)
                    callPayload.Queries["return_object"] = ExpressionConverter.Convert(__workflow_returnObject);
                if (__workflow_filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_orderBy != null)
                    callPayload.Queries["order_by"] = ExpressionConverter.Convert(__workflow_orderBy);
                if (__workflow_dir != null)
                    callPayload.Queries["dir"] = ExpressionConverter.Convert(__workflow_dir);
                callPayload.Headers["Access-Token"] = ExpressionConverter.Convert(__workflow_accessToken);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return new ApiConnectionAction<UserGroupMembership[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "coupaip")]
        public IBodyWorkflowAction<UserGroupMembership, ApiConnectionActionConfiguration> UGMGetUserGroupMembershipById(Expression<Func<string>> accessToken, Expression<Func<int>> id, Expression<Func<ReturnObjectInput>> returnObject = null, Expression<Func<string>> fields = null, Expression<Func<string>> filter = null)
        {
            var __workflow_accessToken = WorkflowExpression.Compile(accessToken, nameof(accessToken), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_returnObject = WorkflowExpression.Compile(returnObject, nameof(returnObject), required: false);
            var __workflow_fields = WorkflowExpression.Compile(fields, nameof(fields), required: false);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            return new DeferredBodyAction<UserGroupMembership, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/user_group_memberships/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_returnObject != null)
                    callPayload.Queries["return_object"] = ExpressionConverter.Convert(__workflow_returnObject);
                if (__workflow_fields != null)
                    callPayload.Queries["fields"] = ExpressionConverter.Convert(__workflow_fields);
                if (__workflow_filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(__workflow_filter);
                callPayload.Headers["Access-Token"] = ExpressionConverter.Convert(__workflow_accessToken);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return new ApiConnectionAction<UserGroupMembership>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "coupaip")]
        public IBodyWorkflowAction<InvAbandonInvoicesUOMResponse[], ApiConnectionActionConfiguration> UOMGetUOMs(Expression<Func<string>> accessToken, Expression<Func<string>> nameContains = null, Expression<Func<string>> codeContains = null, Expression<Func<bool>> active = null, Expression<Func<string>> createdAtGt = null, Expression<Func<string>> updatedAtGt = null, Expression<Func<string>> updatedAtLt = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null, Expression<Func<ReturnObjectInput>> returnObject = null, Expression<Func<string>> filter = null, Expression<Func<string>> orderBy = null, Expression<Func<DirInput>> dir = null)
        {
            var __workflow_accessToken = WorkflowExpression.Compile(accessToken, nameof(accessToken), required: true);
            var __workflow_nameContains = WorkflowExpression.Compile(nameContains, nameof(nameContains), required: false);
            var __workflow_codeContains = WorkflowExpression.Compile(codeContains, nameof(codeContains), required: false);
            var __workflow_active = WorkflowExpression.Compile(active, nameof(active), required: false);
            var __workflow_createdAtGt = WorkflowExpression.Compile(createdAtGt, nameof(createdAtGt), required: false);
            var __workflow_updatedAtGt = WorkflowExpression.Compile(updatedAtGt, nameof(updatedAtGt), required: false);
            var __workflow_updatedAtLt = WorkflowExpression.Compile(updatedAtLt, nameof(updatedAtLt), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            var __workflow_returnObject = WorkflowExpression.Compile(returnObject, nameof(returnObject), required: false);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_orderBy = WorkflowExpression.Compile(orderBy, nameof(orderBy), required: false);
            var __workflow_dir = WorkflowExpression.Compile(dir, nameof(dir), required: false);
            return new DeferredBodyAction<InvAbandonInvoicesUOMResponse[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/uoms";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_nameContains != null)
                    callPayload.Queries["name[contains]"] = ExpressionConverter.Convert(__workflow_nameContains);
                if (__workflow_codeContains != null)
                    callPayload.Queries["code[contains]"] = ExpressionConverter.Convert(__workflow_codeContains);
                if (__workflow_active != null)
                    callPayload.Queries["active"] = ExpressionConverter.Convert(__workflow_active);
                if (__workflow_createdAtGt != null)
                    callPayload.Queries["created-at[gt]"] = ExpressionConverter.Convert(__workflow_createdAtGt);
                if (__workflow_updatedAtGt != null)
                    callPayload.Queries["updated-at[gt]"] = ExpressionConverter.Convert(__workflow_updatedAtGt);
                if (__workflow_updatedAtLt != null)
                    callPayload.Queries["updated-at[lt]"] = ExpressionConverter.Convert(__workflow_updatedAtLt);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                if (__workflow_returnObject != null)
                    callPayload.Queries["return_object"] = ExpressionConverter.Convert(__workflow_returnObject);
                if (__workflow_filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_orderBy != null)
                    callPayload.Queries["order_by"] = ExpressionConverter.Convert(__workflow_orderBy);
                if (__workflow_dir != null)
                    callPayload.Queries["dir"] = ExpressionConverter.Convert(__workflow_dir);
                callPayload.Headers["Access-Token"] = ExpressionConverter.Convert(__workflow_accessToken);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return new ApiConnectionAction<InvAbandonInvoicesUOMResponse[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "coupaip")]
        public IBodyWorkflowAction<InvAbandonInvoicesUOMResponse, ApiConnectionActionConfiguration> UOMGetUOMById(Expression<Func<string>> accessToken, Expression<Func<int>> id, Expression<Func<ReturnObjectInput>> returnObject = null, Expression<Func<string>> fields = null, Expression<Func<string>> filter = null)
        {
            var __workflow_accessToken = WorkflowExpression.Compile(accessToken, nameof(accessToken), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_returnObject = WorkflowExpression.Compile(returnObject, nameof(returnObject), required: false);
            var __workflow_fields = WorkflowExpression.Compile(fields, nameof(fields), required: false);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            return new DeferredBodyAction<InvAbandonInvoicesUOMResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/uoms/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_returnObject != null)
                    callPayload.Queries["return_object"] = ExpressionConverter.Convert(__workflow_returnObject);
                if (__workflow_fields != null)
                    callPayload.Queries["fields"] = ExpressionConverter.Convert(__workflow_fields);
                if (__workflow_filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(__workflow_filter);
                callPayload.Headers["Access-Token"] = ExpressionConverter.Convert(__workflow_accessToken);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return new ApiConnectionAction<InvAbandonInvoicesUOMResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "coupaip")]
        public IBodyWorkflowAction<ApprvlGetApprovalByIdUserResponse[], ApiConnectionActionConfiguration> UsrGetUsers(Expression<Func<string>> accessToken, Expression<Func<string>> loginContains = null, Expression<Func<string>> emailContains = null, Expression<Func<string>> lastnameContains = null, Expression<Func<bool>> active = null, Expression<Func<string>> createdAtGt = null, Expression<Func<string>> updatedAtGt = null, Expression<Func<string>> updatedAtLt = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null, Expression<Func<ReturnObjectInput>> returnObject = null, Expression<Func<string>> filter = null, Expression<Func<string>> orderBy = null, Expression<Func<DirInput>> dir = null)
        {
            var __workflow_accessToken = WorkflowExpression.Compile(accessToken, nameof(accessToken), required: true);
            var __workflow_loginContains = WorkflowExpression.Compile(loginContains, nameof(loginContains), required: false);
            var __workflow_emailContains = WorkflowExpression.Compile(emailContains, nameof(emailContains), required: false);
            var __workflow_lastnameContains = WorkflowExpression.Compile(lastnameContains, nameof(lastnameContains), required: false);
            var __workflow_active = WorkflowExpression.Compile(active, nameof(active), required: false);
            var __workflow_createdAtGt = WorkflowExpression.Compile(createdAtGt, nameof(createdAtGt), required: false);
            var __workflow_updatedAtGt = WorkflowExpression.Compile(updatedAtGt, nameof(updatedAtGt), required: false);
            var __workflow_updatedAtLt = WorkflowExpression.Compile(updatedAtLt, nameof(updatedAtLt), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            var __workflow_returnObject = WorkflowExpression.Compile(returnObject, nameof(returnObject), required: false);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_orderBy = WorkflowExpression.Compile(orderBy, nameof(orderBy), required: false);
            var __workflow_dir = WorkflowExpression.Compile(dir, nameof(dir), required: false);
            return new DeferredBodyAction<ApprvlGetApprovalByIdUserResponse[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/users";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_loginContains != null)
                    callPayload.Queries["login[contains]"] = ExpressionConverter.Convert(__workflow_loginContains);
                if (__workflow_emailContains != null)
                    callPayload.Queries["email[contains]"] = ExpressionConverter.Convert(__workflow_emailContains);
                if (__workflow_lastnameContains != null)
                    callPayload.Queries["lastname[contains]"] = ExpressionConverter.Convert(__workflow_lastnameContains);
                if (__workflow_active != null)
                    callPayload.Queries["active"] = ExpressionConverter.Convert(__workflow_active);
                if (__workflow_createdAtGt != null)
                    callPayload.Queries["created-at[gt]"] = ExpressionConverter.Convert(__workflow_createdAtGt);
                if (__workflow_updatedAtGt != null)
                    callPayload.Queries["updated-at[gt]"] = ExpressionConverter.Convert(__workflow_updatedAtGt);
                if (__workflow_updatedAtLt != null)
                    callPayload.Queries["updated-at[lt]"] = ExpressionConverter.Convert(__workflow_updatedAtLt);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                if (__workflow_returnObject != null)
                    callPayload.Queries["return_object"] = ExpressionConverter.Convert(__workflow_returnObject);
                if (__workflow_filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_orderBy != null)
                    callPayload.Queries["order_by"] = ExpressionConverter.Convert(__workflow_orderBy);
                if (__workflow_dir != null)
                    callPayload.Queries["dir"] = ExpressionConverter.Convert(__workflow_dir);
                callPayload.Headers["Access-Token"] = ExpressionConverter.Convert(__workflow_accessToken);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return new ApiConnectionAction<ApprvlGetApprovalByIdUserResponse[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "coupaip")]
        public IBodyWorkflowAction<ApprvlGetApprovalByIdUserResponse, ApiConnectionActionConfiguration> UsrGetUserById(Expression<Func<string>> accessToken, Expression<Func<int>> id, Expression<Func<ReturnObjectInput>> returnObject = null, Expression<Func<string>> fields = null, Expression<Func<string>> filter = null)
        {
            var __workflow_accessToken = WorkflowExpression.Compile(accessToken, nameof(accessToken), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_returnObject = WorkflowExpression.Compile(returnObject, nameof(returnObject), required: false);
            var __workflow_fields = WorkflowExpression.Compile(fields, nameof(fields), required: false);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            return new DeferredBodyAction<ApprvlGetApprovalByIdUserResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/users/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_returnObject != null)
                    callPayload.Queries["return_object"] = ExpressionConverter.Convert(__workflow_returnObject);
                if (__workflow_fields != null)
                    callPayload.Queries["fields"] = ExpressionConverter.Convert(__workflow_fields);
                if (__workflow_filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(__workflow_filter);
                callPayload.Headers["Access-Token"] = ExpressionConverter.Convert(__workflow_accessToken);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return new ApiConnectionAction<ApprvlGetApprovalByIdUserResponse>(callPayload);
            });
        }
    }

    public class CoupaipTriggers([ConnectionName] string connectionId)
    {
    }

    public class Account
    {
        [JsonProperty("id")]
        public JToken Id { get; set; }

        [JsonProperty("code")]
        public JToken Code { get; set; }

        [JsonProperty("name")]
        public JToken Name { get; set; }

        [JsonProperty("active")]
        public JToken Active { get; set; }

        [JsonProperty("segment-1")]
        public JToken Segment1 { get; set; }

        [JsonProperty("segment-2")]
        public JToken Segment2 { get; set; }

        [JsonProperty("segment-3")]
        public JToken Segment3 { get; set; }

        [JsonProperty("account-type")]
        public AccountAccountTypeType AccountType { get; set; }

        [JsonProperty("created-at")]
        public JToken CreatedAt { get; set; }

        [JsonProperty("updated-at")]
        public JToken UpdatedAt { get; set; }
    }

    public class AccountAccountTypeType
    {
        [JsonProperty("id")]
        public JToken Id { get; set; }

        [JsonProperty("name")]
        public JToken Name { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ReturnObjectInput
    {
        [EnumMember(Value = "limited")]
        Limited,
        [EnumMember(Value = "shallow")]
        Shallow,
        [EnumMember(Value = "none")]
        None
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum DirInput
    {
        [EnumMember(Value = "asc")]
        Asc,
        [EnumMember(Value = "desc")]
        Desc
    }

    public class AddrGetAddressByIdAddressResponse
    {
        [JsonProperty("id")]
        public JToken Id { get; set; }

        [JsonProperty("name")]
        public JToken Name { get; set; }

        [JsonProperty("location-code")]
        public JToken LocationCode { get; set; }

        [JsonProperty("street1")]
        public JToken Street1 { get; set; }

        [JsonProperty("street2")]
        public JToken Street2 { get; set; }

        [JsonProperty("city")]
        public JToken City { get; set; }

        [JsonProperty("state")]
        public JToken State { get; set; }

        [JsonProperty("postal-code")]
        public JToken PostalCode { get; set; }

        [JsonProperty("country")]
        public AddrGetAddressByIdAddressCountryTypeResponse Country { get; set; }

        [JsonProperty("active")]
        public JToken Active { get; set; }

        [JsonProperty("created-at")]
        public JToken CreatedAt { get; set; }

        [JsonProperty("updated-at")]
        public JToken UpdatedAt { get; set; }
    }

    public class AddrGetAddressByIdAddressCountryTypeResponse
    {
        [JsonProperty("id")]
        public JToken Id { get; set; }

        [JsonProperty("name")]
        public JToken Name { get; set; }

        [JsonProperty("code")]
        public JToken Code { get; set; }
    }

    public class Approval
    {
        [JsonProperty("id")]
        public JToken Id { get; set; }

        [JsonProperty("status")]
        public JToken Status { get; set; }

        [JsonProperty("approval-date")]
        public JToken ApprovalDate { get; set; }

        [JsonProperty("approvable-type")]
        public JToken ApprovableType { get; set; }

        [JsonProperty("approvable-id")]
        public JToken ApprovableId { get; set; }

        [JsonProperty("approver")]
        public ApprvlGetApprovalByIdUserResponse Approver { get; set; }

        [JsonProperty("created-at")]
        public JToken CreatedAt { get; set; }

        [JsonProperty("updated-at")]
        public JToken UpdatedAt { get; set; }
    }

    public class ApprvlGetApprovalByIdUserResponse
    {
        [JsonProperty("id")]
        public JToken Id { get; set; }

        [JsonProperty("login")]
        public JToken Login { get; set; }

        [JsonProperty("email")]
        public JToken Email { get; set; }

        [JsonProperty("firstname")]
        public JToken Firstname { get; set; }

        [JsonProperty("lastname")]
        public JToken Lastname { get; set; }

        [JsonProperty("fullname")]
        public JToken Fullname { get; set; }

        [JsonProperty("employee-number")]
        public JToken EmployeeNumber { get; set; }

        [JsonProperty("active")]
        public JToken Active { get; set; }

        [JsonProperty("department")]
        public ApprvlGetApprovalByIdUserDepartmentTypeResponse Department { get; set; }

        [JsonProperty("default-address")]
        public AddrGetAddressByIdAddressResponse DefaultAddress { get; set; }

        [JsonProperty("roles")]
        public ApprvlGetApprovalByIdUserRolesTypeItemResponse[] Roles { get; set; }

        [JsonProperty("created-at")]
        public JToken CreatedAt { get; set; }

        [JsonProperty("updated-at")]
        public JToken UpdatedAt { get; set; }
    }

    public class ApprvlGetApprovalByIdUserDepartmentTypeResponse
    {
        [JsonProperty("id")]
        public JToken Id { get; set; }

        [JsonProperty("name")]
        public JToken Name { get; set; }
    }

    public class ApprvlGetApprovalByIdUserRolesTypeItemResponse
    {
        [JsonProperty("id")]
        public JToken Id { get; set; }

        [JsonProperty("name")]
        public JToken Name { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ApprvlGetApprovalsStatusInInput
    {
        [EnumMember(Value = "pending_approval")]
        PendingApproval,
        [EnumMember(Value = "approved")]
        Approved,
        [EnumMember(Value = "rejected")]
        Rejected
    }

    public class BudgetLine
    {
        [JsonProperty("id")]
        public JToken Id { get; set; }

        [JsonProperty("name")]
        public JToken Name { get; set; }

        [JsonProperty("description")]
        public JToken Description { get; set; }

        [JsonProperty("amount")]
        public JToken Amount { get; set; }

        [JsonProperty("remaining")]
        public JToken Remaining { get; set; }

        [JsonProperty("active")]
        public JToken Active { get; set; }

        [JsonProperty("period")]
        public BudgetLinePeriodType Period { get; set; }

        [JsonProperty("account")]
        public Account Account { get; set; }

        [JsonProperty("created-at")]
        public JToken CreatedAt { get; set; }

        [JsonProperty("updated-at")]
        public JToken UpdatedAt { get; set; }
    }

    public class BudgetLinePeriodType
    {
        [JsonProperty("id")]
        public JToken Id { get; set; }

        [JsonProperty("name")]
        public JToken Name { get; set; }
    }

    public class Contract
    {
        [JsonProperty("id")]
        public JToken Id { get; set; }

        [JsonProperty("number")]
        public JToken Number { get; set; }

        [JsonProperty("name")]
        public JToken Name { get; set; }

        [JsonProperty("status")]
        public JToken Status { get; set; }

        [JsonProperty("supplier")]
        public CntrGetContractByIdSupplierResponse Supplier { get; set; }

        [JsonProperty("currency")]
        public ContractCurrencyType Currency { get; set; }

        [JsonProperty("start-date")]
        public JToken StartDate { get; set; }

        [JsonProperty("end-date")]
        public JToken EndDate { get; set; }

        [JsonProperty("maximum-value")]
        public JToken MaximumValue { get; set; }

        [JsonProperty("minimum-value")]
        public JToken MinimumValue { get; set; }

        [JsonProperty("committed-value")]
        public JToken CommittedValue { get; set; }

        [JsonProperty("current-value")]
        public JToken CurrentValue { get; set; }

        [JsonProperty("contract-owner")]
        public ApprvlGetApprovalByIdUserResponse ContractOwner { get; set; }

        [JsonProperty("description")]
        public JToken Description { get; set; }

        [JsonProperty("terms")]
        public JToken Terms { get; set; }

        [JsonProperty("is-default")]
        public JToken IsDefault { get; set; }

        [JsonProperty("created-at")]
        public JToken CreatedAt { get; set; }

        [JsonProperty("updated-at")]
        public JToken UpdatedAt { get; set; }

        [JsonProperty("created-by")]
        public ApprvlGetApprovalByIdUserResponse CreatedBy { get; set; }

        [JsonProperty("contract-terms")]
        public ContractTerm[] ContractTerms { get; set; }
    }

    public class CntrGetContractByIdSupplierResponse
    {
        [JsonProperty("id")]
        public JToken Id { get; set; }

        [JsonProperty("name")]
        public JToken Name { get; set; }

        [JsonProperty("display-name")]
        public JToken DisplayName { get; set; }

        [JsonProperty("number")]
        public JToken Number { get; set; }

        [JsonProperty("status")]
        public JToken Status { get; set; }

        [JsonProperty("po-method")]
        public JToken PoMethod { get; set; }

        [JsonProperty("po-email")]
        public JToken PoEmail { get; set; }

        [JsonProperty("payment-method")]
        public JToken PaymentMethod { get; set; }

        [JsonProperty("payment-term")]
        public CntrGetContractByIdPaymentTermResponse PaymentTerm { get; set; }

        [JsonProperty("tax-id")]
        public JToken TaxId { get; set; }

        [JsonProperty("website")]
        public JToken Website { get; set; }

        [JsonProperty("duns")]
        public JToken Duns { get; set; }

        [JsonProperty("on-hold")]
        public JToken OnHold { get; set; }

        [JsonProperty("primary-contact")]
        public ApprvlGetApprovalByIdUserResponse PrimaryContact { get; set; }

        [JsonProperty("primary-address")]
        public AddrGetAddressByIdAddressResponse PrimaryAddress { get; set; }

        [JsonProperty("created-at")]
        public JToken CreatedAt { get; set; }

        [JsonProperty("updated-at")]
        public JToken UpdatedAt { get; set; }
    }

    public class CntrGetContractByIdPaymentTermResponse
    {
        [JsonProperty("id")]
        public JToken Id { get; set; }

        [JsonProperty("code")]
        public JToken Code { get; set; }

        [JsonProperty("name")]
        public JToken Name { get; set; }

        [JsonProperty("net-days")]
        public JToken NetDays { get; set; }

        [JsonProperty("discount-days")]
        public JToken DiscountDays { get; set; }

        [JsonProperty("discount-percent")]
        public JToken DiscountPercent { get; set; }

        [JsonProperty("created-at")]
        public JToken CreatedAt { get; set; }

        [JsonProperty("updated-at")]
        public JToken UpdatedAt { get; set; }
    }

    public class ContractCurrencyType
    {
        [JsonProperty("id")]
        public JToken Id { get; set; }

        [JsonProperty("code")]
        public JToken Code { get; set; }
    }

    public class ContractTerm
    {
        [JsonProperty("id")]
        public JToken Id { get; set; }

        [JsonProperty("name")]
        public JToken Name { get; set; }

        [JsonProperty("description")]
        public JToken Description { get; set; }

        [JsonProperty("created-at")]
        public JToken CreatedAt { get; set; }

        [JsonProperty("updated-at")]
        public JToken UpdatedAt { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CntrGetContractsStatusInInput
    {
        [EnumMember(Value = "draft")]
        Draft,
        [EnumMember(Value = "pending_approval")]
        PendingApproval,
        [EnumMember(Value = "approved")]
        Approved,
        [EnumMember(Value = "expired")]
        Expired,
        [EnumMember(Value = "cancelled")]
        Cancelled
    }

    public class Attachment
    {
        [JsonProperty("id")]
        public JToken Id { get; set; }

        [JsonProperty("file-name")]
        public JToken FileName { get; set; }

        [JsonProperty("file-size")]
        public JToken FileSize { get; set; }

        [JsonProperty("content-type")]
        public JToken ContentType { get; set; }

        [JsonProperty("url")]
        public JToken Url { get; set; }

        [JsonProperty("created-at")]
        public JToken CreatedAt { get; set; }

        [JsonProperty("created-by")]
        public ApprvlGetApprovalByIdUserResponse CreatedBy { get; set; }
    }

    public class CommGetCommoditiesCommodityResponse
    {
        [JsonProperty("id")]
        public JToken Id { get; set; }

        [JsonProperty("name")]
        public JToken Name { get; set; }

        [JsonProperty("active")]
        public JToken Active { get; set; }

        [JsonProperty("parent")]
        public CommGetCommoditiesCommodityParentTypeResponse Parent { get; set; }

        [JsonProperty("level")]
        public JToken Level { get; set; }

        [JsonProperty("created-at")]
        public JToken CreatedAt { get; set; }

        [JsonProperty("updated-at")]
        public JToken UpdatedAt { get; set; }
    }

    public class CommGetCommoditiesCommodityParentTypeResponse
    {
        [JsonProperty("id")]
        public JToken Id { get; set; }

        [JsonProperty("name")]
        public JToken Name { get; set; }
    }

    public class DataFileSource
    {
        [JsonProperty("id")]
        public JToken Id { get; set; }

        [JsonProperty("name")]
        public JToken Name { get; set; }

        [JsonProperty("active")]
        public JToken Active { get; set; }
    }

    public class ExchangeRate
    {
        [JsonProperty("id")]
        public JToken Id { get; set; }

        [JsonProperty("rate")]
        public JToken Rate { get; set; }

        [JsonProperty("rate-date")]
        public JToken RateDate { get; set; }

        [JsonProperty("from-currency")]
        public ExchangeRateFromCurrencyType FromCurrency { get; set; }

        [JsonProperty("to-currency")]
        public ExchangeRateToCurrencyType ToCurrency { get; set; }

        [JsonProperty("created-at")]
        public JToken CreatedAt { get; set; }

        [JsonProperty("updated-at")]
        public JToken UpdatedAt { get; set; }
    }

    public class ExchangeRateFromCurrencyType
    {
        [JsonProperty("code")]
        public JToken Code { get; set; }
    }

    public class ExchangeRateToCurrencyType
    {
        [JsonProperty("code")]
        public JToken Code { get; set; }
    }

    public class IntegrationRun
    {
        [JsonProperty("created-at")]
        public JToken CreatedAt { get; set; }

        [JsonProperty("created-by")]
        public IntRunIntegrationIdQueryUserSimpleResponse CreatedBy { get; set; }

        [JsonProperty("end-time")]
        public JToken EndTime { get; set; }

        [JsonProperty("flow")]
        public Flow Flow { get; set; }

        [JsonProperty("id")]
        public JToken Id { get; set; }

        [JsonProperty("integration")]
        public Integration Integration { get; set; }

        [JsonProperty("integration-errors")]
        public IntegrationError[] IntegrationErrors { get; set; }

        [JsonProperty("records-processed")]
        public JToken RecordsProcessed { get; set; }

        [JsonProperty("start-time")]
        public JToken StartTime { get; set; }

        [JsonProperty("status")]
        public JToken Status { get; set; }

        [JsonProperty("total-records")]
        public JToken TotalRecords { get; set; }

        [JsonProperty("updated-at")]
        public JToken UpdatedAt { get; set; }

        [JsonProperty("updated-by")]
        public IntRunIntegrationIdQueryUserSimpleResponse UpdatedBy { get; set; }
    }

    public class IntRunIntegrationIdQueryUserSimpleResponse
    {
        [JsonProperty("id")]
        public JToken Id { get; set; }

        [JsonProperty("login")]
        public JToken Login { get; set; }

        [JsonProperty("email")]
        public JToken Email { get; set; }

        [JsonProperty("fullname")]
        public JToken Fullname { get; set; }
    }

    public class Flow
    {
        [JsonProperty("id")]
        public JToken Id { get; set; }

        [JsonProperty("name")]
        public JToken Name { get; set; }

        [JsonProperty("created-at")]
        public JToken CreatedAt { get; set; }

        [JsonProperty("updated-at")]
        public JToken UpdatedAt { get; set; }
    }

    public class Integration
    {
        [JsonProperty("business-object")]
        public JToken BusinessObject { get; set; }

        [JsonProperty("code")]
        public JToken Code { get; set; }

        [JsonProperty("created-at")]
        public JToken CreatedAt { get; set; }

        [JsonProperty("created-by")]
        public IntRunIntegrationIdQueryUserSimpleResponse CreatedBy { get; set; }

        [JsonProperty("direction")]
        public JToken Direction { get; set; }

        [JsonProperty("end-system")]
        public JToken EndSystem { get; set; }

        [JsonProperty("end-system-type")]
        public JToken EndSystemType { get; set; }

        [JsonProperty("id")]
        public JToken Id { get; set; }

        [JsonProperty("integration-type")]
        public JToken IntegrationType { get; set; }

        [JsonProperty("name")]
        public JToken Name { get; set; }

        [JsonProperty("standard")]
        public JToken Standard { get; set; }

        [JsonProperty("updated-at")]
        public JToken UpdatedAt { get; set; }

        [JsonProperty("updated-by")]
        public IntRunIntegrationIdQueryUserSimpleResponse UpdatedBy { get; set; }
    }

    public class IntegrationError
    {
        [JsonProperty("contact-alert-type")]
        public JToken ContactAlertType { get; set; }

        [JsonProperty("created-at")]
        public JToken CreatedAt { get; set; }

        [JsonProperty("created-by")]
        public IntRunIntegrationIdQueryUserSimpleResponse CreatedBy { get; set; }

        [JsonProperty("creation-method")]
        public JToken CreationMethod { get; set; }

        [JsonProperty("document-id")]
        public JToken DocumentId { get; set; }

        [JsonProperty("document-revision")]
        public JToken DocumentRevision { get; set; }

        [JsonProperty("document-status")]
        public JToken DocumentStatus { get; set; }

        [JsonProperty("document-type")]
        public JToken DocumentType { get; set; }

        [JsonProperty("external-id")]
        public JToken ExternalId { get; set; }

        [JsonProperty("id")]
        public JToken Id { get; set; }

        [JsonProperty("integration")]
        public Integration Integration { get; set; }

        [JsonProperty("integration-filename")]
        public JToken IntegrationFilename { get; set; }

        [JsonProperty("integration-run")]
        public IntegrationRun IntegrationRun { get; set; }

        [JsonProperty("integration-run-id")]
        public JToken IntegrationRunId { get; set; }

        [JsonProperty("resolved")]
        public JToken Resolved { get; set; }

        [JsonProperty("responses")]
        public IntegrationRecordResponse[] Responses { get; set; }

        [JsonProperty("status")]
        public JToken Status { get; set; }

        [JsonProperty("updated-at")]
        public JToken UpdatedAt { get; set; }

        [JsonProperty("updated-by")]
        public IntRunIntegrationIdQueryUserSimpleResponse UpdatedBy { get; set; }
    }

    public class IntegrationRecordResponse
    {
        [JsonProperty("created-at")]
        public JToken CreatedAt { get; set; }

        [JsonProperty("created-by")]
        public IntRunIntegrationIdQueryUserSimpleResponse CreatedBy { get; set; }

        [JsonProperty("id")]
        public JToken Id { get; set; }

        [JsonProperty("response-code")]
        public JToken ResponseCode { get; set; }

        [JsonProperty("response-message")]
        public JToken ResponseMessage { get; set; }

        [JsonProperty("updated-at")]
        public JToken UpdatedAt { get; set; }

        [JsonProperty("updated-by")]
        public IntRunIntegrationIdQueryUserSimpleResponse UpdatedBy { get; set; }
    }

    public class Invoice
    {
        [JsonProperty("id")]
        public JToken Id { get; set; }

        [JsonProperty("invoice-number")]
        public JToken InvoiceNumber { get; set; }

        [JsonProperty("status")]
        public JToken Status { get; set; }

        [JsonProperty("supplier")]
        public CntrGetContractByIdSupplierResponse Supplier { get; set; }

        [JsonProperty("invoice-date")]
        public JToken InvoiceDate { get; set; }

        [JsonProperty("due-date")]
        public JToken DueDate { get; set; }

        [JsonProperty("payment-date")]
        public JToken PaymentDate { get; set; }

        [JsonProperty("currency")]
        public InvoiceCurrencyType Currency { get; set; }

        [JsonProperty("total")]
        public JToken Total { get; set; }

        [JsonProperty("tax-amount")]
        public JToken TaxAmount { get; set; }

        [JsonProperty("shipping-amount")]
        public JToken ShippingAmount { get; set; }

        [JsonProperty("handling-amount")]
        public JToken HandlingAmount { get; set; }

        [JsonProperty("miscellaneous-amount")]
        public JToken MiscellaneousAmount { get; set; }

        [JsonProperty("payment-term")]
        public CntrGetContractByIdPaymentTermResponse PaymentTerm { get; set; }

        [JsonProperty("ship-to-address")]
        public AddrGetAddressByIdAddressResponse ShipToAddress { get; set; }

        [JsonProperty("remit-to-address")]
        public AddrGetAddressByIdAddressResponse RemitToAddress { get; set; }

        [JsonProperty("bill-to-address")]
        public AddrGetAddressByIdAddressResponse BillToAddress { get; set; }

        [JsonProperty("invoice-lines")]
        public InvoiceLine[] InvoiceLines { get; set; }

        [JsonProperty("po-number")]
        public JToken PoNumber { get; set; }

        [JsonProperty("origin")]
        public JToken Origin { get; set; }

        [JsonProperty("paid")]
        public JToken Paid { get; set; }

        [JsonProperty("document-type")]
        public JToken DocumentType { get; set; }

        [JsonProperty("current-approval")]
        public Approval CurrentApproval { get; set; }

        [JsonProperty("created-at")]
        public JToken CreatedAt { get; set; }

        [JsonProperty("updated-at")]
        public JToken UpdatedAt { get; set; }

        [JsonProperty("created-by")]
        public ApprvlGetApprovalByIdUserResponse CreatedBy { get; set; }

        [JsonProperty("total-with-taxes")]
        public JToken TotalWithTaxes { get; set; }

        [JsonProperty("line-level-taxation")]
        public JToken LineLevelTaxation { get; set; }
    }

    public class InvoiceCurrencyType
    {
        [JsonProperty("id")]
        public JToken Id { get; set; }

        [JsonProperty("code")]
        public JToken Code { get; set; }
    }

    public class InvoiceLine
    {
        [JsonProperty("id")]
        public JToken Id { get; set; }

        [JsonProperty("line-num")]
        public JToken LineNum { get; set; }

        [JsonProperty("status")]
        public JToken Status { get; set; }

        [JsonProperty("description")]
        public JToken Description { get; set; }

        [JsonProperty("total")]
        public JToken Total { get; set; }

        [JsonProperty("price")]
        public JToken Price { get; set; }

        [JsonProperty("quantity")]
        public JToken Quantity { get; set; }

        [JsonProperty("tax-amount")]
        public JToken TaxAmount { get; set; }

        [JsonProperty("order-line-id")]
        public JToken OrderLineId { get; set; }

        [JsonProperty("po-number")]
        public JToken PoNumber { get; set; }

        [JsonProperty("supplier-part-num")]
        public JToken SupplierPartNum { get; set; }

        [JsonProperty("account")]
        public Account Account { get; set; }

        [JsonProperty("item")]
        public InvAbandonInvoicesItemResponse Item { get; set; }

        [JsonProperty("uom")]
        public InvAbandonInvoicesUOMResponse Uom { get; set; }

        [JsonProperty("commodity")]
        public CommGetCommoditiesCommodityResponse Commodity { get; set; }

        [JsonProperty("created-at")]
        public JToken CreatedAt { get; set; }

        [JsonProperty("updated-at")]
        public JToken UpdatedAt { get; set; }
    }

    public class InvAbandonInvoicesItemResponse
    {
        [JsonProperty("id")]
        public JToken Id { get; set; }

        [JsonProperty("name")]
        public JToken Name { get; set; }

        [JsonProperty("description")]
        public JToken Description { get; set; }

        [JsonProperty("item-number")]
        public JToken ItemNumber { get; set; }

        [JsonProperty("active")]
        public JToken Active { get; set; }

        [JsonProperty("uom")]
        public InvAbandonInvoicesUOMResponse Uom { get; set; }

        [JsonProperty("commodity")]
        public CommGetCommoditiesCommodityResponse Commodity { get; set; }

        [JsonProperty("created-at")]
        public JToken CreatedAt { get; set; }

        [JsonProperty("updated-at")]
        public JToken UpdatedAt { get; set; }
    }

    public class InvAbandonInvoicesUOMResponse
    {
        [JsonProperty("id")]
        public JToken Id { get; set; }

        [JsonProperty("name")]
        public JToken Name { get; set; }

        [JsonProperty("code")]
        public JToken Code { get; set; }

        [JsonProperty("active")]
        public JToken Active { get; set; }

        [JsonProperty("allowable-precision")]
        public JToken AllowablePrecision { get; set; }

        [JsonProperty("created-at")]
        public JToken CreatedAt { get; set; }

        [JsonProperty("updated-at")]
        public JToken UpdatedAt { get; set; }
    }

    public class InvoiceHeaderInput
    {
        [JsonProperty("abandon-reason")]
        public AbandonReasonSimple AbandonReason { get; set; }

        [JsonProperty("account-type", DefaultValueHandling = DefaultValueHandling.Include)]
        public InvAbandonInvoicesAccountTypeSimple AccountType { get; set; }

        [JsonProperty("advance-payment-received-amount")]
        public JToken AdvancePaymentReceivedAmount { get; set; }

        [JsonProperty("amount-due")]
        public JToken AmountDue { get; set; }

        [JsonProperty("amount-due-less-discount")]
        public JToken AmountDueLessDiscount { get; set; }

        [JsonProperty("amount-of-advance-payment")]
        public JToken AmountOfAdvancePayment { get; set; }

        [JsonProperty("approvals")]
        public ApprovalSimple[] Approvals { get; set; }

        [JsonProperty("archive-entity-id")]
        public JToken ArchiveEntityId { get; set; }

        [JsonProperty("attachments")]
        public InvAbandonInvoicesAttachmentSimple[] Attachments { get; set; }

        [JsonProperty("bill-to-address", DefaultValueHandling = DefaultValueHandling.Include)]
        public AddressSimple BillToAddress { get; set; }

        [JsonProperty("buyer-representative-name")]
        public JToken BuyerRepresentativeName { get; set; }

        [JsonProperty("buyer-tax-registration", DefaultValueHandling = DefaultValueHandling.Include)]
        public TaxRegistrationSimple2 BuyerTaxRegistration { get; set; }

        [JsonProperty("canceled")]
        public JToken Canceled { get; set; }

        [JsonProperty("cash-accounting-scheme-reference")]
        public JToken CashAccountingSchemeReference { get; set; }

        [JsonProperty("cash-register-operator")]
        public JToken CashRegisterOperator { get; set; }

        [JsonProperty("channel")]
        public JToken Channel { get; set; }

        [JsonProperty("clearance-document")]
        public JToken ClearanceDocument { get; set; }

        [JsonProperty("comments")]
        public JToken Comments { get; set; }

        [JsonProperty("compliant")]
        public JToken Compliant { get; set; }

        [JsonProperty("confirmation")]
        public JToken Confirmation { get; set; }

        [JsonProperty("content-validation")]
        public JToken ContentValidation { get; set; }

        [JsonProperty("contract")]
        public InvAbandonInvoicesContractSimple Contract { get; set; }

        [JsonProperty("correct-value-of-supply")]
        public JToken CorrectValueOfSupply { get; set; }

        [JsonProperty("coupa-accelerate-status")]
        public JToken CoupaAccelerateStatus { get; set; }

        [JsonProperty("created-at")]
        public JToken CreatedAt { get; set; }

        [JsonProperty("created-by")]
        public InvAbandonInvoicesUserSimple CreatedBy { get; set; }

        [JsonProperty("credit-note-differences-with-original-invoice")]
        public JToken CreditNoteDifferencesWithOriginalInvoice { get; set; }

        [JsonProperty("credit-reason")]
        public JToken CreditReason { get; set; }

        [JsonProperty("currency")]
        public InvAbandonInvoicesCurrency Currency { get; set; }

        [JsonProperty("currency-id")]
        public JToken CurrencyId { get; set; }

        [JsonProperty("currency-tax-rounding-mode")]
        public JToken CurrencyTaxRoundingMode { get; set; }

        [JsonProperty("current-integration-history-records")]
        public IntegrationHistorySimple[] CurrentIntegrationHistoryRecords { get; set; }

        [JsonProperty("customer-account-number")]
        public JToken CustomerAccountNumber { get; set; }

        [JsonProperty("customer-accounting-tax")]
        public JToken CustomerAccountingTax { get; set; }

        [JsonProperty("customer-accounting-tax-less-discount")]
        public JToken CustomerAccountingTaxLessDiscount { get; set; }

        [JsonProperty("customs-declaration-date")]
        public JToken CustomsDeclarationDate { get; set; }

        [JsonProperty("customs-declaration-number")]
        public JToken CustomsDeclarationNumber { get; set; }

        [JsonProperty("customs-office")]
        public JToken CustomsOffice { get; set; }

        [JsonProperty("date-of-discovery-of-facts-decisive-for-correction")]
        public JToken DateOfDiscoveryOfFactsDecisiveForCorrection { get; set; }

        [JsonProperty("date-received")]
        public JToken DateReceived { get; set; }

        [JsonProperty("delivery-date")]
        public JToken DeliveryDate { get; set; }

        [JsonProperty("delivery-number")]
        public JToken DeliveryNumber { get; set; }

        [JsonProperty("destination-country")]
        public CountrySimple DestinationCountry { get; set; }

        [JsonProperty("discount-amount")]
        public JToken DiscountAmount { get; set; }

        [JsonProperty("discount-due-date")]
        public JToken DiscountDueDate { get; set; }

        [JsonProperty("discount-percent")]
        public JToken DiscountPercent { get; set; }

        [JsonProperty("dispute-method")]
        public JToken DisputeMethod { get; set; }

        [JsonProperty("dispute-reasons")]
        public DisputeReasonSimple[] DisputeReasons { get; set; }

        [JsonProperty("document-type")]
        public JToken DocumentType { get; set; }

        [JsonProperty("early-payment-provisions")]
        public JToken EarlyPaymentProvisions { get; set; }

        [JsonProperty("endorsement-on-invoices")]
        public JToken EndorsementOnInvoices { get; set; }

        [JsonProperty("exchange-rate")]
        public JToken ExchangeRate { get; set; }

        [JsonProperty("exported")]
        public JToken Exported { get; set; }

        [JsonProperty("failed-tolerances")]
        public FailedToleranceSimple[] FailedTolerances { get; set; }

        [JsonProperty("folio-number")]
        public JToken FolioNumber { get; set; }

        [JsonProperty("form-of-payment")]
        public JToken FormOfPayment { get; set; }

        [JsonProperty("freight-type")]
        public JToken FreightType { get; set; }

        [JsonProperty("gross-total")]
        public JToken GrossTotal { get; set; }

        [JsonProperty("gross-total-less-discount")]
        public JToken GrossTotalLessDiscount { get; set; }

        [JsonProperty("handling-amount")]
        public JToken HandlingAmount { get; set; }

        [JsonProperty("id")]
        public JToken Id { get; set; }

        [JsonProperty("image-scan")]
        public JToken ImageScan { get; set; }

        [JsonProperty("image-scan-content-type")]
        public JToken ImageScanContentType { get; set; }

        [JsonProperty("image-scan-file-name")]
        public JToken ImageScanFileName { get; set; }

        [JsonProperty("image-scan-file-size")]
        public JToken ImageScanFileSize { get; set; }

        [JsonProperty("image-scan-url")]
        public JToken ImageScanUrl { get; set; }

        [JsonProperty("inbound-invoice")]
        public InboundInvoiceSimple InboundInvoice { get; set; }

        [JsonProperty("inbox-name")]
        public JToken InboxName { get; set; }

        [JsonProperty("internal-note")]
        public JToken InternalNote { get; set; }

        [JsonProperty("invoice-charges")]
        public InvoiceChargeSimple[] InvoiceCharges { get; set; }

        [JsonProperty("invoice-date", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken InvoiceDate { get; set; }

        [JsonProperty("invoice-from-address", DefaultValueHandling = DefaultValueHandling.Include)]
        public AddressSimple InvoiceFromAddress { get; set; }

        [JsonProperty("invoice-issuance-time")]
        public JToken InvoiceIssuanceTime { get; set; }

        [JsonProperty("invoice-lines")]
        public InvoiceLineSimple[] InvoiceLines { get; set; }

        [JsonProperty("invoice-number", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken InvoiceNumber { get; set; }

        [JsonProperty("invoice-payment-receipts")]
        public InvoicePaymentReceiptSimple[] InvoicePaymentReceipts { get; set; }

        [JsonProperty("invoice-reference-number")]
        public JToken InvoiceReferenceNumber { get; set; }

        [JsonProperty("is-credit-note")]
        public JToken IsCreditNote { get; set; }

        [JsonProperty("is-ers-invoice")]
        public JToken IsErsInvoice { get; set; }

        [JsonProperty("issuance-place")]
        public JToken IssuancePlace { get; set; }

        [JsonProperty("last-exported-at")]
        public JToken LastExportedAt { get; set; }

        [JsonProperty("late-payment-penalties")]
        public JToken LatePaymentPenalties { get; set; }

        [JsonProperty("legal-destination-country")]
        public CountrySimple LegalDestinationCountry { get; set; }

        [JsonProperty("line-count")]
        public JToken LineCount { get; set; }

        [JsonProperty("line-level-taxation", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken LineLevelTaxation { get; set; }

        [JsonProperty("lock-version-key")]
        public JToken LockVersionKey { get; set; }

        [JsonProperty("margin-scheme")]
        public JToken MarginScheme { get; set; }

        [JsonProperty("means-of-payment")]
        public JToken MeansOfPayment { get; set; }

        [JsonProperty("misc-amount")]
        public JToken MiscAmount { get; set; }

        [JsonProperty("municipal-tax-number")]
        public JToken MunicipalTaxNumber { get; set; }

        [JsonProperty("national-enrollment-of-conveyor")]
        public JToken NationalEnrollmentOfConveyor { get; set; }

        [JsonProperty("nature-of-operation")]
        public JToken NatureOfOperation { get; set; }

        [JsonProperty("net-due-date")]
        public JToken NetDueDate { get; set; }

        [JsonProperty("net-total-less-discount")]
        public JToken NetTotalLessDiscount { get; set; }

        [JsonProperty("new-means-of-transport")]
        public JToken NewMeansOfTransport { get; set; }

        [JsonProperty("origin-country")]
        public CountrySimple OriginCountry { get; set; }

        [JsonProperty("origin-currency")]
        public InvAbandonInvoicesCurrency OriginCurrency { get; set; }

        [JsonProperty("origin-currency-gross", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken OriginCurrencyGross { get; set; }

        [JsonProperty("origin-currency-net", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken OriginCurrencyNet { get; set; }

        [JsonProperty("original-invoice-date", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken OriginalInvoiceDate { get; set; }

        [JsonProperty("original-invoice-number", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken OriginalInvoiceNumber { get; set; }

        [JsonProperty("original-value-of-supply")]
        public JToken OriginalValueOfSupply { get; set; }

        [JsonProperty("override-tax-country")]
        public CountrySimple OverrideTaxCountry { get; set; }

        [JsonProperty("paid")]
        public JToken Paid { get; set; }

        [JsonProperty("pay-invoice")]
        public PayInvoiceSimple PayInvoice { get; set; }

        [JsonProperty("payment-agreement-notes")]
        public PaymentAgreementNoteSimple[] PaymentAgreementNotes { get; set; }

        [JsonProperty("payment-channel")]
        public JToken PaymentChannel { get; set; }

        [JsonProperty("payment-date")]
        public JToken PaymentDate { get; set; }

        [JsonProperty("payment-due-date")]
        public JToken PaymentDueDate { get; set; }

        [JsonProperty("payment-method")]
        public JToken PaymentMethod { get; set; }

        [JsonProperty("payment-notes")]
        public JToken PaymentNotes { get; set; }

        [JsonProperty("payment-order-number")]
        public JToken PaymentOrderNumber { get; set; }

        [JsonProperty("payment-order-reference")]
        public JToken PaymentOrderReference { get; set; }

        [JsonProperty("payment-schedule-terms")]
        public JToken PaymentScheduleTerms { get; set; }

        [JsonProperty("payment-term")]
        public InvAbandonInvoicesPaymentTerm PaymentTerm { get; set; }

        [JsonProperty("payments")]
        public PaymentSimple[] Payments { get; set; }

        [JsonProperty("place-of-issuance")]
        public JToken PlaceOfIssuance { get; set; }

        [JsonProperty("place-of-supply")]
        public JToken PlaceOfSupply { get; set; }

        [JsonProperty("pre-payment-date")]
        public JToken PrePaymentDate { get; set; }

        [JsonProperty("protocol-number")]
        public JToken ProtocolNumber { get; set; }

        [JsonProperty("reconciliation-lines")]
        public ReconciliationLineSimple[] ReconciliationLines { get; set; }

        [JsonProperty("remit-to-address", DefaultValueHandling = DefaultValueHandling.Include)]
        public AddressSimple RemitToAddress { get; set; }

        [JsonProperty("requested-by")]
        public InvAbandonInvoicesUserSimple RequestedBy { get; set; }

        [JsonProperty("requester-email")]
        public JToken RequesterEmail { get; set; }

        [JsonProperty("requester-lookup-name")]
        public JToken RequesterLookupName { get; set; }

        [JsonProperty("requester-name")]
        public JToken RequesterName { get; set; }

        [JsonProperty("resolution-number")]
        public JToken ResolutionNumber { get; set; }

        [JsonProperty("reverse-charge-reference")]
        public JToken ReverseChargeReference { get; set; }

        [JsonProperty("security-code-of-issuer")]
        public JToken SecurityCodeOfIssuer { get; set; }

        [JsonProperty("self-billing-reference")]
        public JToken SelfBillingReference { get; set; }

        [JsonProperty("sender-email")]
        public JToken SenderEmail { get; set; }

        [JsonProperty("serial-code-of-fiscal-invoice")]
        public JToken SerialCodeOfFiscalInvoice { get; set; }

        [JsonProperty("series")]
        public JToken Series { get; set; }

        [JsonProperty("ship-from-address", DefaultValueHandling = DefaultValueHandling.Include)]
        public AddressSimple ShipFromAddress { get; set; }

        [JsonProperty("ship-to-address")]
        public AddressSimple ShipToAddress { get; set; }

        [JsonProperty("shipping-amount")]
        public JToken ShippingAmount { get; set; }

        [JsonProperty("shipping-term")]
        public ShippingTermSimple ShippingTerm { get; set; }

        [JsonProperty("show-tax-information?")]
        public JToken ShowTaxInformation { get; set; }

        [JsonProperty("signed-qr-code")]
        public JToken SignedQrCode { get; set; }

        [JsonProperty("split-payment-mechanism")]
        public JToken SplitPaymentMechanism { get; set; }

        [JsonProperty("state-tax-number")]
        public JToken StateTaxNumber { get; set; }

        [JsonProperty("state-tax-number-for-substitute-taxpayer")]
        public JToken StateTaxNumberForSubstituteTaxpayer { get; set; }

        [JsonProperty("status")]
        public JToken Status { get; set; }

        [JsonProperty("supplier")]
        public InvAbandonInvoicesSupplierSimple Supplier { get; set; }

        [JsonProperty("supplier-created")]
        public JToken SupplierCreated { get; set; }

        [JsonProperty("supplier-invoice-issuer-name")]
        public JToken SupplierInvoiceIssuerName { get; set; }

        [JsonProperty("supplier-invoice-reviewer-name")]
        public JToken SupplierInvoiceReviewerName { get; set; }

        [JsonProperty("supplier-note")]
        public JToken SupplierNote { get; set; }

        [JsonProperty("supplier-payment-collector-name")]
        public JToken SupplierPaymentCollectorName { get; set; }

        [JsonProperty("supplier-remit-to", DefaultValueHandling = DefaultValueHandling.Include)]
        public SupplierSiteSimple SupplierRemitTo { get; set; }

        [JsonProperty("supplier-representative-name")]
        public JToken SupplierRepresentativeName { get; set; }

        [JsonProperty("supplier-site")]
        public SupplierSiteSimple SupplierSite { get; set; }

        [JsonProperty("supplier-tax-registration", DefaultValueHandling = DefaultValueHandling.Include)]
        public TaxRegistrationSimple2 SupplierTaxRegistration { get; set; }

        [JsonProperty("supplier-total")]
        public JToken SupplierTotal { get; set; }

        [JsonProperty("taggings")]
        public TaggingSimple[] Taggings { get; set; }

        [JsonProperty("tags")]
        public TagSimple[] Tags { get; set; }

        [JsonProperty("tax-amount")]
        public JToken TaxAmount { get; set; }

        [JsonProperty("tax-amount-engine")]
        public JToken TaxAmountEngine { get; set; }

        [JsonProperty("tax-code")]
        public TaxCodeSimple TaxCode { get; set; }

        [JsonProperty("tax-code-engine")]
        public JToken TaxCodeEngine { get; set; }

        [JsonProperty("tax-due-to-supplier")]
        public JToken TaxDueToSupplier { get; set; }

        [JsonProperty("tax-lines")]
        public TaxLineSimple[] TaxLines { get; set; }

        [JsonProperty("tax-rate")]
        public JToken TaxRate { get; set; }

        [JsonProperty("tax-rate-engine")]
        public JToken TaxRateEngine { get; set; }

        [JsonProperty("taxes-in-origin-country-currency", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken TaxesInOriginCountryCurrency { get; set; }

        [JsonProperty("tcs-tax-lines")]
        public TaxLineSimple[] TcsTaxLines { get; set; }

        [JsonProperty("tolerance-failures")]
        public JToken ToleranceFailures { get; set; }

        [JsonProperty("total-for-coupa-pay")]
        public JToken TotalForCoupaPay { get; set; }

        [JsonProperty("total-taxes-less-discount")]
        public JToken TotalTaxesLessDiscount { get; set; }

        [JsonProperty("total-with-taxes")]
        public JToken TotalWithTaxes { get; set; }

        [JsonProperty("transaction-notification-date")]
        public JToken TransactionNotificationDate { get; set; }

        [JsonProperty("transaction-uuid")]
        public JToken TransactionUuid { get; set; }

        [JsonProperty("type-of-document")]
        public JToken TypeOfDocument { get; set; }

        [JsonProperty("type-of-operation")]
        public JToken TypeOfOperation { get; set; }

        [JsonProperty("type-of-receipt")]
        public JToken TypeOfReceipt { get; set; }

        [JsonProperty("type-of-relationship")]
        public JToken TypeOfRelationship { get; set; }

        [JsonProperty("unique-identification-code-of-cash-receipt")]
        public JToken UniqueIdentificationCodeOfCashReceipt { get; set; }

        [JsonProperty("updated-at")]
        public JToken UpdatedAt { get; set; }

        [JsonProperty("updated-by")]
        public InvAbandonInvoicesUserSimple UpdatedBy { get; set; }

        [JsonProperty("use-of-invoice")]
        public JToken UseOfInvoice { get; set; }

        [JsonProperty("vat-chargeability-system")]
        public JToken VatChargeabilitySystem { get; set; }

        [JsonProperty("vehicle-license-plate")]
        public JToken VehicleLicensePlate { get; set; }

        [JsonProperty("verification-code")]
        public JToken VerificationCode { get; set; }

        [JsonProperty("volume-amount")]
        public JToken VolumeAmount { get; set; }

        [JsonProperty("volume-brand")]
        public JToken VolumeBrand { get; set; }

        [JsonProperty("volume-gross-weight")]
        public JToken VolumeGrossWeight { get; set; }

        [JsonProperty("volume-liquid-weight")]
        public JToken VolumeLiquidWeight { get; set; }

        [JsonProperty("volume-numbering")]
        public JToken VolumeNumbering { get; set; }

        [JsonProperty("volume-type")]
        public JToken VolumeType { get; set; }

        [JsonProperty("withholding-tax-lines")]
        public TaxLineSimple[] WithholdingTaxLines { get; set; }

        [JsonProperty("withholding-tax-override")]
        public JToken WithholdingTaxOverride { get; set; }
    }

    public class AbandonReasonSimple
    {
        [JsonProperty("id")]
        public JToken Id { get; set; }

        [JsonProperty("reason")]
        public JToken Reason { get; set; }
    }

    public class InvAbandonInvoicesAccountTypeSimple
    {
        [JsonProperty("id")]
        public JToken Id { get; set; }

        [JsonProperty("name")]
        public JToken Name { get; set; }
    }

    public class ApprovalSimple
    {
        [JsonProperty("id")]
        public JToken Id { get; set; }

        [JsonProperty("status")]
        public JToken Status { get; set; }

        [JsonProperty("approver-id")]
        public JToken ApproverId { get; set; }

        [JsonProperty("approver-name")]
        public JToken ApproverName { get; set; }

        [JsonProperty("position")]
        public JToken Position { get; set; }

        [JsonProperty("created-at")]
        public JToken CreatedAt { get; set; }
    }

    public class InvAbandonInvoicesAttachmentSimple
    {
        [JsonProperty("id")]
        public JToken Id { get; set; }

        [JsonProperty("file-name")]
        public JToken FileName { get; set; }

        [JsonProperty("url")]
        public JToken Url { get; set; }

        [JsonProperty("content-type")]
        public JToken ContentType { get; set; }

        [JsonProperty("file-size")]
        public JToken FileSize { get; set; }
    }

    public class AddressSimple
    {
        [JsonProperty("id")]
        public JToken Id { get; set; }

        [JsonProperty("name")]
        public JToken Name { get; set; }

        [JsonProperty("street1")]
        public JToken Street1 { get; set; }

        [JsonProperty("city")]
        public JToken City { get; set; }

        [JsonProperty("postal-code")]
        public JToken PostalCode { get; set; }

        [JsonProperty("country")]
        public JToken Country { get; set; }
    }

    public class TaxRegistrationSimple2
    {
        [JsonProperty("id")]
        public JToken Id { get; set; }

        [JsonProperty("tax-number")]
        public JToken TaxNumber { get; set; }

        [JsonProperty("country")]
        public JToken Country { get; set; }

        [JsonProperty("tax-type")]
        public JToken TaxType { get; set; }
    }

    public class InvAbandonInvoicesContractSimple
    {
        [JsonProperty("id")]
        public JToken Id { get; set; }

        [JsonProperty("name")]
        public JToken Name { get; set; }

        [JsonProperty("number")]
        public JToken Number { get; set; }

        [JsonProperty("status")]
        public JToken Status { get; set; }
    }

    public class InvAbandonInvoicesUserSimple
    {
        [JsonProperty("id")]
        public JToken Id { get; set; }

        [JsonProperty("login", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken Login { get; set; }

        [JsonProperty("email", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken Email { get; set; }

        [JsonProperty("fullname")]
        public JToken Fullname { get; set; }
    }

    public class InvAbandonInvoicesCurrency
    {
        [JsonProperty("id")]
        public JToken Id { get; set; }

        [JsonProperty("code")]
        public JToken Code { get; set; }

        [JsonProperty("name")]
        public JToken Name { get; set; }

        [JsonProperty("enabled")]
        public JToken Enabled { get; set; }
    }

    public class IntegrationHistorySimple
    {
        [JsonProperty("id")]
        public JToken Id { get; set; }

        [JsonProperty("status")]
        public JToken Status { get; set; }

        [JsonProperty("connector")]
        public JToken Connector { get; set; }

        [JsonProperty("created-at")]
        public JToken CreatedAt { get; set; }
    }

    public class CountrySimple
    {
        [JsonProperty("id")]
        public JToken Id { get; set; }

        [JsonProperty("code")]
        public JToken Code { get; set; }

        [JsonProperty("name")]
        public JToken Name { get; set; }
    }

    public class DisputeReasonSimple
    {
        [JsonProperty("id")]
        public JToken Id { get; set; }

        [JsonProperty("reason")]
        public JToken Reason { get; set; }
    }

    public class FailedToleranceSimple
    {
        [JsonProperty("id")]
        public JToken Id { get; set; }

        [JsonProperty("tolerance-type")]
        public JToken ToleranceType { get; set; }

        [JsonProperty("message")]
        public JToken Message { get; set; }
    }

    public class InboundInvoiceSimple
    {
        [JsonProperty("id")]
        public JToken Id { get; set; }

        [JsonProperty("status")]
        public JToken Status { get; set; }

        [JsonProperty("invoice-number")]
        public JToken InvoiceNumber { get; set; }
    }

    public class InvoiceChargeSimple
    {
        [JsonProperty("id")]
        public JToken Id { get; set; }

        [JsonProperty("description")]
        public JToken Description { get; set; }

        [JsonProperty("amount")]
        public JToken Amount { get; set; }

        [JsonProperty("accounting-total")]
        public JToken AccountingTotal { get; set; }

        [JsonProperty("line-num")]
        public JToken LineNum { get; set; }

        [JsonProperty("created-at")]
        public JToken CreatedAt { get; set; }

        [JsonProperty("updated-at")]
        public JToken UpdatedAt { get; set; }
    }

    public class InvoiceLineSimple
    {
        [JsonProperty("id")]
        public JToken Id { get; set; }

        [JsonProperty("line-num")]
        public JToken LineNum { get; set; }

        [JsonProperty("status")]
        public JToken Status { get; set; }

        [JsonProperty("description")]
        public JToken Description { get; set; }

        [JsonProperty("quantity")]
        public JToken Quantity { get; set; }

        [JsonProperty("price")]
        public JToken Price { get; set; }

        [JsonProperty("total")]
        public JToken Total { get; set; }

        [JsonProperty("uom-name")]
        public JToken UomName { get; set; }

        [JsonProperty("account-id")]
        public JToken AccountId { get; set; }

        [JsonProperty("account-code")]
        public JToken AccountCode { get; set; }

        [JsonProperty("order-line-id")]
        public JToken OrderLineId { get; set; }

        [JsonProperty("supplier-part-num")]
        public JToken SupplierPartNum { get; set; }

        [JsonProperty("created-at")]
        public JToken CreatedAt { get; set; }

        [JsonProperty("updated-at")]
        public JToken UpdatedAt { get; set; }
    }

    public class InvoicePaymentReceiptSimple
    {
        [JsonProperty("id")]
        public JToken Id { get; set; }

        [JsonProperty("amount")]
        public JToken Amount { get; set; }

        [JsonProperty("created-at")]
        public JToken CreatedAt { get; set; }
    }

    public class PayInvoiceSimple
    {
        [JsonProperty("id")]
        public JToken Id { get; set; }

        [JsonProperty("status")]
        public JToken Status { get; set; }

        [JsonProperty("amount")]
        public JToken Amount { get; set; }

        [JsonProperty("payment-date")]
        public JToken PaymentDate { get; set; }
    }

    public class PaymentAgreementNoteSimple
    {
        [JsonProperty("id")]
        public JToken Id { get; set; }

        [JsonProperty("note")]
        public JToken Note { get; set; }

        [JsonProperty("created-at")]
        public JToken CreatedAt { get; set; }
    }

    public class InvAbandonInvoicesPaymentTerm
    {
        [JsonProperty("id")]
        public JToken Id { get; set; }

        [JsonProperty("code")]
        public JToken Code { get; set; }

        [JsonProperty("name")]
        public JToken Name { get; set; }

        [JsonProperty("net-days")]
        public JToken NetDays { get; set; }

        [JsonProperty("discount-days")]
        public JToken DiscountDays { get; set; }

        [JsonProperty("discount-percent")]
        public JToken DiscountPercent { get; set; }

        [JsonProperty("created-at")]
        public JToken CreatedAt { get; set; }

        [JsonProperty("updated-at")]
        public JToken UpdatedAt { get; set; }
    }

    public class PaymentSimple
    {
        [JsonProperty("id")]
        public JToken Id { get; set; }

        [JsonProperty("status")]
        public JToken Status { get; set; }

        [JsonProperty("amount")]
        public JToken Amount { get; set; }

        [JsonProperty("payment-date")]
        public JToken PaymentDate { get; set; }
    }

    public class ReconciliationLineSimple
    {
        [JsonProperty("id")]
        public JToken Id { get; set; }

        [JsonProperty("status")]
        public JToken Status { get; set; }

        [JsonProperty("amount")]
        public JToken Amount { get; set; }
    }

    public class ShippingTermSimple
    {
        [JsonProperty("id")]
        public JToken Id { get; set; }

        [JsonProperty("code")]
        public JToken Code { get; set; }

        [JsonProperty("name")]
        public JToken Name { get; set; }
    }

    public class InvAbandonInvoicesSupplierSimple
    {
        [JsonProperty("id")]
        public JToken Id { get; set; }

        [JsonProperty("name")]
        public JToken Name { get; set; }

        [JsonProperty("number")]
        public JToken Number { get; set; }

        [JsonProperty("status")]
        public JToken Status { get; set; }
    }

    public class SupplierSiteSimple
    {
        [JsonProperty("id")]
        public JToken Id { get; set; }

        [JsonProperty("name")]
        public JToken Name { get; set; }

        [JsonProperty("code")]
        public JToken Code { get; set; }

        [JsonProperty("active")]
        public JToken Active { get; set; }
    }

    public class TaggingSimple
    {
        [JsonProperty("id")]
        public JToken Id { get; set; }

        [JsonProperty("tag")]
        public JToken Tag { get; set; }

        [JsonProperty("taggable-type")]
        public JToken TaggableType { get; set; }
    }

    public class TagSimple
    {
        [JsonProperty("id")]
        public JToken Id { get; set; }

        [JsonProperty("name")]
        public JToken Name { get; set; }
    }

    public class TaxCodeSimple
    {
        [JsonProperty("id")]
        public JToken Id { get; set; }

        [JsonProperty("name")]
        public JToken Name { get; set; }

        [JsonProperty("code")]
        public JToken Code { get; set; }
    }

    public class TaxLineSimple
    {
        [JsonProperty("id")]
        public JToken Id { get; set; }

        [JsonProperty("tax-code")]
        public JToken TaxCode { get; set; }

        [JsonProperty("amount")]
        public JToken Amount { get; set; }

        [JsonProperty("rate")]
        public JToken Rate { get; set; }

        [JsonProperty("tax-code-id")]
        public JToken TaxCodeId { get; set; }

        [JsonProperty("created-at")]
        public JToken CreatedAt { get; set; }

        [JsonProperty("updated-at")]
        public JToken UpdatedAt { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum InvGetInvoicesStatusInInput
    {
        [EnumMember(Value = "new")]
        New,
        [EnumMember(Value = "draft")]
        Draft,
        [EnumMember(Value = "pending_receipt")]
        PendingReceipt,
        [EnumMember(Value = "pending_approval")]
        PendingApproval,
        [EnumMember(Value = "ap_hold")]
        ApHold,
        [EnumMember(Value = "on_hold")]
        OnHold,
        [EnumMember(Value = "booking_hold")]
        BookingHold,
        [EnumMember(Value = "disputed")]
        Disputed,
        [EnumMember(Value = "approved")]
        Approved,
        [EnumMember(Value = "voided")]
        Voided,
        [EnumMember(Value = "processing")]
        Processing,
        [EnumMember(Value = "payable_adjustment")]
        PayableAdjustment,
        [EnumMember(Value = "invalid")]
        Invalid,
        [EnumMember(Value = "rejected")]
        Rejected,
        [EnumMember(Value = "abandoned")]
        Abandoned,
        [EnumMember(Value = "pending_action")]
        PendingAction
    }

    public class Comment
    {
        [JsonProperty("id")]
        public JToken Id { get; set; }

        [JsonProperty("text")]
        public JToken Text { get; set; }

        [JsonProperty("commentable-type")]
        public JToken CommentableType { get; set; }

        [JsonProperty("commentable-id")]
        public JToken CommentableId { get; set; }

        [JsonProperty("created-at")]
        public JToken CreatedAt { get; set; }

        [JsonProperty("created-by")]
        public ApprvlGetApprovalByIdUserResponse CreatedBy { get; set; }
    }

    public class InvPostCommentBodyInput
    {
        [JsonProperty("comments", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Comment { get; set; }

        [JsonProperty("to-supplier", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? VisibleToSupplier { get; set; } = false;
    }

    public class InventoryRecord
    {
        [JsonProperty("id")]
        public JToken Id { get; set; }

        [JsonProperty("item")]
        public InvAbandonInvoicesItemResponse Item { get; set; }

        [JsonProperty("quantity")]
        public JToken Quantity { get; set; }

        [JsonProperty("location")]
        public JToken Location { get; set; }

        [JsonProperty("created-at")]
        public JToken CreatedAt { get; set; }

        [JsonProperty("updated-at")]
        public JToken UpdatedAt { get; set; }
    }

    public class InventoryTransaction
    {
        [JsonProperty("id")]
        public JToken Id { get; set; }

        [JsonProperty("transaction-type")]
        public JToken TransactionType { get; set; }

        [JsonProperty("quantity")]
        public JToken Quantity { get; set; }

        [JsonProperty("item")]
        public InvAbandonInvoicesItemResponse Item { get; set; }

        [JsonProperty("created-at")]
        public JToken CreatedAt { get; set; }

        [JsonProperty("updated-at")]
        public JToken UpdatedAt { get; set; }
    }

    public class LkpGetLookupByIdLookupResponse
    {
        [JsonProperty("id")]
        public JToken Id { get; set; }

        [JsonProperty("name")]
        public JToken Name { get; set; }

        [JsonProperty("active")]
        public JToken Active { get; set; }

        [JsonProperty("created-at")]
        public JToken CreatedAt { get; set; }

        [JsonProperty("updated-at")]
        public JToken UpdatedAt { get; set; }
    }

    public class LookupValue
    {
        [JsonProperty("id")]
        public JToken Id { get; set; }

        [JsonProperty("name")]
        public JToken Name { get; set; }

        [JsonProperty("external-ref-code")]
        public JToken ExternalRefCode { get; set; }

        [JsonProperty("active")]
        public JToken Active { get; set; }

        [JsonProperty("lookup")]
        public LkpGetLookupByIdLookupResponse Lookup { get; set; }

        [JsonProperty("parent")]
        public LookupValueParentType Parent { get; set; }

        [JsonProperty("created-at")]
        public JToken CreatedAt { get; set; }

        [JsonProperty("updated-at")]
        public JToken UpdatedAt { get; set; }
    }

    public class LookupValueParentType
    {
        [JsonProperty("id")]
        public JToken Id { get; set; }

        [JsonProperty("name")]
        public JToken Name { get; set; }
    }

    public class LkpValCreateLookupValueBodyInput
    {
        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken Name { get; set; }

        [JsonProperty("external-ref-code")]
        public JToken ExternalRefCode { get; set; }

        [JsonProperty("active")]
        public JToken Active { get; set; }

        [JsonProperty("lookup")]
        public LkpValCreateLookupValueLookup Lookup { get; set; }
    }

    public class LkpValCreateLookupValueLookup
    {
        [JsonProperty("id")]
        public JToken Id { get; set; }

        [JsonProperty("name")]
        public JToken Name { get; set; }

        [JsonProperty("active")]
        public JToken Active { get; set; }

        [JsonProperty("created-at")]
        public JToken CreatedAt { get; set; }

        [JsonProperty("updated-at")]
        public JToken UpdatedAt { get; set; }
    }

    public class OrderPad
    {
        [JsonProperty("id")]
        public JToken Id { get; set; }

        [JsonProperty("name")]
        public JToken Name { get; set; }

        [JsonProperty("order-pad-lines")]
        public OrdListCreateOrderPadOrderPadLineResponse[] OrderPadLines { get; set; }

        [JsonProperty("add-all-items")]
        public JToken AddAllItems { get; set; }

        [JsonProperty("any-supplier")]
        public JToken AnySupplier { get; set; }

        [JsonProperty("base-value")]
        public JToken BaseValue { get; set; }

        [JsonProperty("base-value-currency")]
        public OrdListCreateOrderPadCurrencyResponse BaseValueCurrency { get; set; }

        [JsonProperty("business-groups")]
        public OrderPadBusinessGroupsTypeItem[] BusinessGroups { get; set; }

        [JsonProperty("locked")]
        public JToken Locked { get; set; }

        [JsonProperty("use-base-value")]
        public JToken UseBaseValue { get; set; }

        [JsonProperty("order-pad-sections")]
        public OrdListCreateOrderPadOrderPadSectionResponse[] OrderPadSections { get; set; }

        [JsonProperty("suppliers")]
        public CntrGetContractByIdSupplierResponse[] Suppliers { get; set; }

        [JsonProperty("created-at")]
        public JToken CreatedAt { get; set; }

        [JsonProperty("updated-at")]
        public JToken UpdatedAt { get; set; }

        [JsonProperty("created-by")]
        public ApprvlGetApprovalByIdUserResponse CreatedBy { get; set; }

        [JsonProperty("updated-by")]
        public ApprvlGetApprovalByIdUserResponse UpdatedBy { get; set; }
    }

    public class OrdListCreateOrderPadOrderPadLineResponse
    {
        [JsonProperty("id")]
        public JToken Id { get; set; }

        [JsonProperty("item")]
        public InvAbandonInvoicesItemResponse Item { get; set; }

        [JsonProperty("order-amount-method")]
        public JToken OrderAmountMethod { get; set; }

        [JsonProperty("supplier-id")]
        public JToken SupplierId { get; set; }

        [JsonProperty("par-level")]
        public JToken ParLevel { get; set; }

        [JsonProperty("amount")]
        public JToken Amount { get; set; }

        [JsonProperty("key-item")]
        public JToken KeyItem { get; set; }

        [JsonProperty("order-pad-section")]
        public OrdListCreateOrderPadOrderPadSectionResponse OrderPadSection { get; set; }

        [JsonProperty("position")]
        public JToken Position { get; set; }

        [JsonProperty("created-at")]
        public JToken CreatedAt { get; set; }

        [JsonProperty("updated-at")]
        public JToken UpdatedAt { get; set; }

        [JsonProperty("created-by")]
        public ApprvlGetApprovalByIdUserResponse CreatedBy { get; set; }

        [JsonProperty("updated-by")]
        public ApprvlGetApprovalByIdUserResponse UpdatedBy { get; set; }
    }

    public class OrdListCreateOrderPadOrderPadSectionResponse
    {
        [JsonProperty("id")]
        public JToken Id { get; set; }

        [JsonProperty("name")]
        public JToken Name { get; set; }

        [JsonProperty("position")]
        public JToken Position { get; set; }

        [JsonProperty("created-at")]
        public JToken CreatedAt { get; set; }

        [JsonProperty("updated-at")]
        public JToken UpdatedAt { get; set; }
    }

    public class OrdListCreateOrderPadCurrencyResponse
    {
        [JsonProperty("id")]
        public JToken Id { get; set; }

        [JsonProperty("code")]
        public JToken Code { get; set; }

        [JsonProperty("name")]
        public JToken Name { get; set; }

        [JsonProperty("enabled")]
        public JToken Enabled { get; set; }
    }

    public class OrderPadBusinessGroupsTypeItem
    {
        [JsonProperty("id")]
        public JToken Id { get; set; }

        [JsonProperty("name")]
        public JToken Name { get; set; }
    }

    public class OrdListCreateOrderPadBodyInput
    {
        [JsonProperty("id")]
        public JToken Id { get; set; }

        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken Name { get; set; }

        [JsonProperty("order-pad-lines")]
        public OrdListCreateOrderPadOrderPadLine[] OrderPadLines { get; set; }

        [JsonProperty("add-all-items")]
        public JToken AddAllItems { get; set; }

        [JsonProperty("any-supplier")]
        public JToken AnySupplier { get; set; }

        [JsonProperty("base-value")]
        public JToken BaseValue { get; set; }

        [JsonProperty("base-value-currency")]
        public InvAbandonInvoicesCurrency BaseValueCurrency { get; set; }

        [JsonProperty("business-groups")]
        public BodyInputBusinessGroupsTypeItem[] BusinessGroups { get; set; }

        [JsonProperty("locked")]
        public JToken Locked { get; set; }

        [JsonProperty("use-base-value")]
        public JToken UseBaseValue { get; set; }

        [JsonProperty("order-pad-sections")]
        public OrdListCreateOrderPadOrderPadSection[] OrderPadSections { get; set; }

        [JsonProperty("suppliers")]
        public OrdListCreateOrderPadSupplier[] Suppliers { get; set; }

        [JsonProperty("created-at")]
        public JToken CreatedAt { get; set; }

        [JsonProperty("updated-at")]
        public JToken UpdatedAt { get; set; }

        [JsonProperty("created-by")]
        public OrdListCreateOrderPadUser CreatedBy { get; set; }

        [JsonProperty("updated-by")]
        public OrdListCreateOrderPadUser UpdatedBy { get; set; }
    }

    public class OrdListCreateOrderPadOrderPadLine
    {
        [JsonProperty("id")]
        public JToken Id { get; set; }

        [JsonProperty("item", DefaultValueHandling = DefaultValueHandling.Include)]
        public OrdListCreateOrderPadItem Item { get; set; }

        [JsonProperty("order-amount-method", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken OrderAmountMethod { get; set; }

        [JsonProperty("supplier-id", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken SupplierId { get; set; }

        [JsonProperty("par-level")]
        public JToken ParLevel { get; set; }

        [JsonProperty("amount")]
        public JToken Amount { get; set; }

        [JsonProperty("key-item")]
        public JToken KeyItem { get; set; }

        [JsonProperty("order-pad-section")]
        public OrdListCreateOrderPadOrderPadSection OrderPadSection { get; set; }

        [JsonProperty("position")]
        public JToken Position { get; set; }

        [JsonProperty("created-at")]
        public JToken CreatedAt { get; set; }

        [JsonProperty("updated-at")]
        public JToken UpdatedAt { get; set; }

        [JsonProperty("created-by")]
        public OrdListCreateOrderPadUser CreatedBy { get; set; }

        [JsonProperty("updated-by")]
        public OrdListCreateOrderPadUser UpdatedBy { get; set; }
    }

    public class OrdListCreateOrderPadItem
    {
        [JsonProperty("id")]
        public JToken Id { get; set; }

        [JsonProperty("name")]
        public JToken Name { get; set; }

        [JsonProperty("description")]
        public JToken Description { get; set; }

        [JsonProperty("item-number")]
        public JToken ItemNumber { get; set; }

        [JsonProperty("active")]
        public JToken Active { get; set; }

        [JsonProperty("uom")]
        public OrdListCreateOrderPadUOM Uom { get; set; }

        [JsonProperty("commodity")]
        public OrdListCreateOrderPadCommodity Commodity { get; set; }

        [JsonProperty("created-at")]
        public JToken CreatedAt { get; set; }

        [JsonProperty("updated-at")]
        public JToken UpdatedAt { get; set; }
    }

    public class OrdListCreateOrderPadUOM
    {
        [JsonProperty("id")]
        public JToken Id { get; set; }

        [JsonProperty("name")]
        public JToken Name { get; set; }

        [JsonProperty("code")]
        public JToken Code { get; set; }

        [JsonProperty("active")]
        public JToken Active { get; set; }

        [JsonProperty("allowable-precision")]
        public JToken AllowablePrecision { get; set; }

        [JsonProperty("created-at")]
        public JToken CreatedAt { get; set; }

        [JsonProperty("updated-at")]
        public JToken UpdatedAt { get; set; }
    }

    public class OrdListCreateOrderPadCommodity
    {
        [JsonProperty("id")]
        public JToken Id { get; set; }

        [JsonProperty("name")]
        public JToken Name { get; set; }

        [JsonProperty("active")]
        public JToken Active { get; set; }

        [JsonProperty("parent")]
        public OrdListCreateOrderPadCommodityParentType Parent { get; set; }

        [JsonProperty("level")]
        public JToken Level { get; set; }

        [JsonProperty("created-at")]
        public JToken CreatedAt { get; set; }

        [JsonProperty("updated-at")]
        public JToken UpdatedAt { get; set; }
    }

    public class OrdListCreateOrderPadCommodityParentType
    {
        [JsonProperty("id")]
        public JToken Id { get; set; }

        [JsonProperty("name")]
        public JToken Name { get; set; }
    }

    public class OrdListCreateOrderPadOrderPadSection
    {
        [JsonProperty("id")]
        public JToken Id { get; set; }

        [JsonProperty("name")]
        public JToken Name { get; set; }

        [JsonProperty("position")]
        public JToken Position { get; set; }

        [JsonProperty("created-at")]
        public JToken CreatedAt { get; set; }

        [JsonProperty("updated-at")]
        public JToken UpdatedAt { get; set; }
    }

    public class OrdListCreateOrderPadUser
    {
        [JsonProperty("id")]
        public JToken Id { get; set; }

        [JsonProperty("login")]
        public JToken Login { get; set; }

        [JsonProperty("email")]
        public JToken Email { get; set; }

        [JsonProperty("firstname")]
        public JToken Firstname { get; set; }

        [JsonProperty("lastname")]
        public JToken Lastname { get; set; }

        [JsonProperty("fullname")]
        public JToken Fullname { get; set; }

        [JsonProperty("employee-number")]
        public JToken EmployeeNumber { get; set; }

        [JsonProperty("active")]
        public JToken Active { get; set; }

        [JsonProperty("department")]
        public OrdListCreateOrderPadUserDepartmentType Department { get; set; }

        [JsonProperty("default-address")]
        public OrdListCreateOrderPadAddress DefaultAddress { get; set; }

        [JsonProperty("roles")]
        public OrdListCreateOrderPadUserRolesTypeItem[] Roles { get; set; }

        [JsonProperty("created-at")]
        public JToken CreatedAt { get; set; }

        [JsonProperty("updated-at")]
        public JToken UpdatedAt { get; set; }
    }

    public class OrdListCreateOrderPadUserDepartmentType
    {
        [JsonProperty("id")]
        public JToken Id { get; set; }

        [JsonProperty("name")]
        public JToken Name { get; set; }
    }

    public class OrdListCreateOrderPadAddress
    {
        [JsonProperty("id")]
        public JToken Id { get; set; }

        [JsonProperty("name")]
        public JToken Name { get; set; }

        [JsonProperty("location-code")]
        public JToken LocationCode { get; set; }

        [JsonProperty("street1")]
        public JToken Street1 { get; set; }

        [JsonProperty("street2")]
        public JToken Street2 { get; set; }

        [JsonProperty("city")]
        public JToken City { get; set; }

        [JsonProperty("state")]
        public JToken State { get; set; }

        [JsonProperty("postal-code")]
        public JToken PostalCode { get; set; }

        [JsonProperty("country")]
        public OrdListCreateOrderPadAddressCountryType Country { get; set; }

        [JsonProperty("active")]
        public JToken Active { get; set; }

        [JsonProperty("created-at")]
        public JToken CreatedAt { get; set; }

        [JsonProperty("updated-at")]
        public JToken UpdatedAt { get; set; }
    }

    public class OrdListCreateOrderPadAddressCountryType
    {
        [JsonProperty("id")]
        public JToken Id { get; set; }

        [JsonProperty("name")]
        public JToken Name { get; set; }

        [JsonProperty("code")]
        public JToken Code { get; set; }
    }

    public class OrdListCreateOrderPadUserRolesTypeItem
    {
        [JsonProperty("id")]
        public JToken Id { get; set; }

        [JsonProperty("name")]
        public JToken Name { get; set; }
    }

    public class BodyInputBusinessGroupsTypeItem
    {
        [JsonProperty("id")]
        public JToken Id { get; set; }

        [JsonProperty("name")]
        public JToken Name { get; set; }
    }

    public class OrdListCreateOrderPadSupplier
    {
        [JsonProperty("id")]
        public JToken Id { get; set; }

        [JsonProperty("name")]
        public JToken Name { get; set; }

        [JsonProperty("display-name")]
        public JToken DisplayName { get; set; }

        [JsonProperty("number")]
        public JToken Number { get; set; }

        [JsonProperty("status")]
        public JToken Status { get; set; }

        [JsonProperty("po-method")]
        public JToken PoMethod { get; set; }

        [JsonProperty("po-email")]
        public JToken PoEmail { get; set; }

        [JsonProperty("payment-method")]
        public JToken PaymentMethod { get; set; }

        [JsonProperty("payment-term")]
        public InvAbandonInvoicesPaymentTerm PaymentTerm { get; set; }

        [JsonProperty("tax-id")]
        public JToken TaxId { get; set; }

        [JsonProperty("website")]
        public JToken Website { get; set; }

        [JsonProperty("duns")]
        public JToken Duns { get; set; }

        [JsonProperty("on-hold")]
        public JToken OnHold { get; set; }

        [JsonProperty("primary-contact")]
        public OrdListCreateOrderPadUser PrimaryContact { get; set; }

        [JsonProperty("primary-address")]
        public OrdListCreateOrderPadAddress PrimaryAddress { get; set; }

        [JsonProperty("created-at")]
        public JToken CreatedAt { get; set; }

        [JsonProperty("updated-at")]
        public JToken UpdatedAt { get; set; }
    }

    public class OrdListLineCreateOrderPadLineBodyInput
    {
        [JsonProperty("id")]
        public JToken Id { get; set; }

        [JsonProperty("item", DefaultValueHandling = DefaultValueHandling.Include)]
        public OrdListCreateOrderPadItem Item { get; set; }

        [JsonProperty("order-amount-method", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken OrderAmountMethod { get; set; }

        [JsonProperty("supplier-id", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken SupplierId { get; set; }

        [JsonProperty("par-level")]
        public JToken ParLevel { get; set; }

        [JsonProperty("amount")]
        public JToken Amount { get; set; }

        [JsonProperty("key-item")]
        public JToken KeyItem { get; set; }

        [JsonProperty("order-pad-section")]
        public OrdListCreateOrderPadOrderPadSection OrderPadSection { get; set; }

        [JsonProperty("position")]
        public JToken Position { get; set; }

        [JsonProperty("created-at")]
        public JToken CreatedAt { get; set; }

        [JsonProperty("updated-at")]
        public JToken UpdatedAt { get; set; }

        [JsonProperty("created-by")]
        public OrdListCreateOrderPadUser CreatedBy { get; set; }

        [JsonProperty("updated-by")]
        public OrdListCreateOrderPadUser UpdatedBy { get; set; }
    }

    public class PurchaseOrder
    {
        [JsonProperty("id")]
        public JToken Id { get; set; }

        [JsonProperty("po-number")]
        public JToken PoNumber { get; set; }

        [JsonProperty("number")]
        public JToken Number { get; set; }

        [JsonProperty("status")]
        public JToken Status { get; set; }

        [JsonProperty("version")]
        public JToken Version { get; set; }

        [JsonProperty("supplier")]
        public CntrGetContractByIdSupplierResponse Supplier { get; set; }

        [JsonProperty("currency")]
        public PurchaseOrderCurrencyType Currency { get; set; }

        [JsonProperty("total")]
        public JToken Total { get; set; }

        [JsonProperty("ship-to-address")]
        public AddrGetAddressByIdAddressResponse ShipToAddress { get; set; }

        [JsonProperty("bill-to-address")]
        public AddrGetAddressByIdAddressResponse BillToAddress { get; set; }

        [JsonProperty("payment-term")]
        public CntrGetContractByIdPaymentTermResponse PaymentTerm { get; set; }

        [JsonProperty("ship-to-attention")]
        public JToken ShipToAttention { get; set; }

        [JsonProperty("requester")]
        public ApprvlGetApprovalByIdUserResponse Requester { get; set; }

        [JsonProperty("buyer")]
        public ApprvlGetApprovalByIdUserResponse Buyer { get; set; }

        [JsonProperty("transmission-status")]
        public JToken TransmissionStatus { get; set; }

        [JsonProperty("transmission-date")]
        public JToken TransmissionDate { get; set; }

        [JsonProperty("acknowledged-at")]
        public JToken AcknowledgedAt { get; set; }

        [JsonProperty("order-lines")]
        public OrderLineSummary[] OrderLines { get; set; }

        [JsonProperty("created-at")]
        public JToken CreatedAt { get; set; }

        [JsonProperty("updated-at")]
        public JToken UpdatedAt { get; set; }

        [JsonProperty("created-by")]
        public ApprvlGetApprovalByIdUserResponse CreatedBy { get; set; }

        [JsonProperty("updated-by")]
        public ApprvlGetApprovalByIdUserResponse UpdatedBy { get; set; }
    }

    public class PurchaseOrderCurrencyType
    {
        [JsonProperty("id")]
        public JToken Id { get; set; }

        [JsonProperty("code")]
        public JToken Code { get; set; }
    }

    public class OrderLineSummary
    {
        [JsonProperty("id")]
        public JToken Id { get; set; }

        [JsonProperty("line-num")]
        public JToken LineNum { get; set; }

        [JsonProperty("status")]
        public JToken Status { get; set; }

        [JsonProperty("description")]
        public JToken Description { get; set; }

        [JsonProperty("source-part-num")]
        public JToken SourcePartNum { get; set; }

        [JsonProperty("quantity")]
        public JToken Quantity { get; set; }

        [JsonProperty("price")]
        public JToken Price { get; set; }

        [JsonProperty("total")]
        public JToken Total { get; set; }

        [JsonProperty("order-header-id")]
        public JToken OrderHeaderId { get; set; }

        [JsonProperty("order-header-number")]
        public JToken OrderHeaderNumber { get; set; }

        [JsonProperty("supplier")]
        public POCancelPurchaseOrderSupplierSimpleResponse Supplier { get; set; }

        [JsonProperty("item")]
        public InvAbandonInvoicesItemResponse Item { get; set; }

        [JsonProperty("uom")]
        public InvAbandonInvoicesUOMResponse Uom { get; set; }

        [JsonProperty("need-by-date")]
        public JToken NeedByDate { get; set; }

        [JsonProperty("created-at")]
        public JToken CreatedAt { get; set; }

        [JsonProperty("updated-at")]
        public JToken UpdatedAt { get; set; }
    }

    public class POCancelPurchaseOrderSupplierSimpleResponse
    {
        [JsonProperty("id")]
        public JToken Id { get; set; }

        [JsonProperty("name")]
        public JToken Name { get; set; }

        [JsonProperty("number")]
        public JToken Number { get; set; }

        [JsonProperty("status")]
        public JToken Status { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum POGetPurchaseOrdersStatusInInput
    {
        [EnumMember(Value = "draft")]
        Draft,
        [EnumMember(Value = "pending_buyer_action")]
        PendingBuyerAction,
        [EnumMember(Value = "pending_approval")]
        PendingApproval,
        [EnumMember(Value = "issued")]
        Issued,
        [EnumMember(Value = "soft_closed")]
        SoftClosed,
        [EnumMember(Value = "closed")]
        Closed,
        [EnumMember(Value = "cancelled")]
        Cancelled
    }

    public class POCommentsPOCreateBodyInput
    {
        [JsonProperty("commentable-type", DefaultValueHandling = DefaultValueHandling.Include)]
        public string CommentableType { get; set; } = "OrderHeader";

        [JsonProperty("comments")]
        public string Comments { get; set; }
    }

    public class POReopenPurchaseOrderBodyInput
    {
        [JsonProperty("reason_insight_code")]
        public string ReasonInsightCode { get; set; }

        [JsonProperty("reason-insight-event-comment")]
        public string ReasonInsightEventComment { get; set; }
    }

    public class PurchaseOrderChange
    {
        [JsonProperty("id")]
        public JToken Id { get; set; }

        [JsonProperty("purchase_order")]
        public PurchaseOrder PurchaseOrder { get; set; }

        [JsonProperty("change-reason")]
        public JToken ChangeReason { get; set; }

        [JsonProperty("status")]
        public JToken Status { get; set; }

        [JsonProperty("created-at")]
        public JToken CreatedAt { get; set; }

        [JsonProperty("updated-at")]
        public JToken UpdatedAt { get; set; }
    }

    public class PurchaseOrderLine
    {
        [JsonProperty("id")]
        public JToken Id { get; set; }

        [JsonProperty("line-num")]
        public JToken LineNum { get; set; }

        [JsonProperty("status")]
        public JToken Status { get; set; }

        [JsonProperty("description")]
        public JToken Description { get; set; }

        [JsonProperty("quantity")]
        public JToken Quantity { get; set; }

        [JsonProperty("price")]
        public JToken Price { get; set; }

        [JsonProperty("total")]
        public JToken Total { get; set; }

        [JsonProperty("accounting-total")]
        public JToken AccountingTotal { get; set; }

        [JsonProperty("invoiced")]
        public JToken Invoiced { get; set; }

        [JsonProperty("received")]
        public JToken Received { get; set; }

        [JsonProperty("need-by-date")]
        public JToken NeedByDate { get; set; }

        [JsonProperty("receipt-required")]
        public JToken ReceiptRequired { get; set; }

        [JsonProperty("match-type")]
        public JToken MatchType { get; set; }

        [JsonProperty("source-part-num")]
        public JToken SourcePartNum { get; set; }

        [JsonProperty("supp-aux-part-num")]
        public JToken SuppAuxPartNum { get; set; }

        [JsonProperty("supplier-order-number")]
        public JToken SupplierOrderNumber { get; set; }

        [JsonProperty("order-header-id")]
        public JToken OrderHeaderId { get; set; }

        [JsonProperty("order-header-number")]
        public JToken OrderHeaderNumber { get; set; }

        [JsonProperty("item")]
        public InvAbandonInvoicesItemResponse Item { get; set; }

        [JsonProperty("supplier")]
        public CntrGetContractByIdSupplierResponse Supplier { get; set; }

        [JsonProperty("account")]
        public Account Account { get; set; }

        [JsonProperty("account-allocations")]
        public OrderLineAllocation[] AccountAllocations { get; set; }

        [JsonProperty("requester")]
        public PurchaseOrderLineRequesterType Requester { get; set; }

        [JsonProperty("uom")]
        public InvAbandonInvoicesUOMResponse Uom { get; set; }

        [JsonProperty("commodity")]
        public CommGetCommoditiesCommodityResponse Commodity { get; set; }

        [JsonProperty("currency")]
        public PurchaseOrderLineCurrencyType Currency { get; set; }

        [JsonProperty("custom-fields")]
        public JToken CustomFields { get; set; }

        [JsonProperty("created-at")]
        public JToken CreatedAt { get; set; }

        [JsonProperty("updated-at")]
        public JToken UpdatedAt { get; set; }

        [JsonProperty("created-by")]
        public PurchaseOrderLineCreatedByType CreatedBy { get; set; }

        [JsonProperty("updated-by")]
        public PurchaseOrderLineUpdatedByType UpdatedBy { get; set; }

        [JsonProperty("sub-line-num")]
        public JToken SubLineNum { get; set; }

        [JsonProperty("service-type")]
        public JToken ServiceType { get; set; }

        [JsonProperty("reporting-total")]
        public JToken ReportingTotal { get; set; }

        [JsonProperty("savings-pct")]
        public JToken SavingsPct { get; set; }

        [JsonProperty("minimum-order-quantity")]
        public JToken MinimumOrderQuantity { get; set; }

        [JsonProperty("receipt-approval-required")]
        public JToken ReceiptApprovalRequired { get; set; }

        [JsonProperty("invoice-stop")]
        public JToken InvoiceStop { get; set; }

        [JsonProperty("version")]
        public JToken Version { get; set; }

        [JsonProperty("manufacturer-name")]
        public JToken ManufacturerName { get; set; }

        [JsonProperty("manufacturer-part-number")]
        public JToken ManufacturerPartNumber { get; set; }

        [JsonProperty("external-reference-number")]
        public JToken ExternalReferenceNumber { get; set; }

        [JsonProperty("external-reference-type")]
        public JToken ExternalReferenceType { get; set; }

        [JsonProperty("accounting-total-currency")]
        public OrdListCreateOrderPadCurrencyResponse AccountingTotalCurrency { get; set; }

        [JsonProperty("account-type")]
        public POLineGetPurchaseOrderLineByIdAccountTypeSimpleResponse AccountType { get; set; }

        [JsonProperty("department")]
        public DepartmentSimple Department { get; set; }

        [JsonProperty("contract")]
        public POLineGetPurchaseOrderLineByIdContractSimpleResponse Contract { get; set; }

        [JsonProperty("period")]
        public PeriodSimple Period { get; set; }

        [JsonProperty("attachments")]
        public POLineGetPurchaseOrderLineByIdAttachmentSimpleResponse[] Attachments { get; set; }
    }

    public class OrderLineAllocation
    {
        [JsonProperty("id")]
        public JToken Id { get; set; }

        [JsonProperty("account-id")]
        public JToken AccountId { get; set; }

        [JsonProperty("account-code")]
        public JToken AccountCode { get; set; }

        [JsonProperty("account-name")]
        public JToken AccountName { get; set; }

        [JsonProperty("account-type-id")]
        public JToken AccountTypeId { get; set; }

        [JsonProperty("account-type-name")]
        public JToken AccountTypeName { get; set; }

        [JsonProperty("pct")]
        public JToken Pct { get; set; }

        [JsonProperty("amount")]
        public JToken Amount { get; set; }

        [JsonProperty("period-id")]
        public JToken PeriodId { get; set; }

        [JsonProperty("period-name")]
        public JToken PeriodName { get; set; }

        [JsonProperty("created-at")]
        public JToken CreatedAt { get; set; }

        [JsonProperty("updated-at")]
        public JToken UpdatedAt { get; set; }
    }

    public class PurchaseOrderLineRequesterType
    {
        [JsonProperty("id")]
        public JToken Id { get; set; }

        [JsonProperty("login")]
        public JToken Login { get; set; }

        [JsonProperty("employee-number")]
        public JToken EmployeeNumber { get; set; }
    }

    public class PurchaseOrderLineCurrencyType
    {
        [JsonProperty("id")]
        public JToken Id { get; set; }

        [JsonProperty("code")]
        public JToken Code { get; set; }
    }

    public class PurchaseOrderLineCreatedByType
    {
        [JsonProperty("id")]
        public JToken Id { get; set; }

        [JsonProperty("login")]
        public JToken Login { get; set; }
    }

    public class PurchaseOrderLineUpdatedByType
    {
        [JsonProperty("id")]
        public JToken Id { get; set; }

        [JsonProperty("login")]
        public JToken Login { get; set; }
    }

    public class POLineGetPurchaseOrderLineByIdAccountTypeSimpleResponse
    {
        [JsonProperty("id")]
        public JToken Id { get; set; }

        [JsonProperty("name")]
        public JToken Name { get; set; }
    }

    public class DepartmentSimple
    {
        [JsonProperty("id")]
        public JToken Id { get; set; }

        [JsonProperty("name")]
        public JToken Name { get; set; }
    }

    public class POLineGetPurchaseOrderLineByIdContractSimpleResponse
    {
        [JsonProperty("id")]
        public JToken Id { get; set; }

        [JsonProperty("name")]
        public JToken Name { get; set; }

        [JsonProperty("number")]
        public JToken Number { get; set; }

        [JsonProperty("status")]
        public JToken Status { get; set; }
    }

    public class PeriodSimple
    {
        [JsonProperty("id")]
        public JToken Id { get; set; }

        [JsonProperty("name")]
        public JToken Name { get; set; }

        [JsonProperty("start-date")]
        public JToken StartDate { get; set; }

        [JsonProperty("end-date")]
        public JToken EndDate { get; set; }
    }

    public class POLineGetPurchaseOrderLineByIdAttachmentSimpleResponse
    {
        [JsonProperty("id")]
        public JToken Id { get; set; }

        [JsonProperty("file-name")]
        public JToken FileName { get; set; }

        [JsonProperty("url")]
        public JToken Url { get; set; }

        [JsonProperty("content-type")]
        public JToken ContentType { get; set; }

        [JsonProperty("file-size")]
        public JToken FileSize { get; set; }
    }

    public class ReceiptRequest
    {
        [JsonProperty("id")]
        public JToken Id { get; set; }

        [JsonProperty("status")]
        public JToken Status { get; set; }

        [JsonProperty("created-at")]
        public JToken CreatedAt { get; set; }

        [JsonProperty("updated-at")]
        public JToken UpdatedAt { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum RcptReqGetReceiptRequestsStatusInInput
    {
        [EnumMember(Value = "received")]
        Received,
        [EnumMember(Value = "voided")]
        Voided,
        [EnumMember(Value = "pending")]
        Pending
    }

    public class ReceivingTransaction
    {
        [JsonProperty("id")]
        public JToken Id { get; set; }

        [JsonProperty("status")]
        public JToken Status { get; set; }

        [JsonProperty("quantity")]
        public JToken Quantity { get; set; }

        [JsonProperty("total")]
        public JToken Total { get; set; }

        [JsonProperty("order-line-id")]
        public JToken OrderLineId { get; set; }

        [JsonProperty("order-header-id")]
        public JToken OrderHeaderId { get; set; }

        [JsonProperty("order-header-number")]
        public JToken OrderHeaderNumber { get; set; }

        [JsonProperty("uom")]
        public InvAbandonInvoicesUOMResponse Uom { get; set; }

        [JsonProperty("item")]
        public InvAbandonInvoicesItemResponse Item { get; set; }

        [JsonProperty("receipt-date")]
        public JToken ReceiptDate { get; set; }

        [JsonProperty("received-by")]
        public ApprvlGetApprovalByIdUserResponse ReceivedBy { get; set; }

        [JsonProperty("created-at")]
        public JToken CreatedAt { get; set; }

        [JsonProperty("updated-at")]
        public JToken UpdatedAt { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum RcvTxnGetReceivingTransactionsStatusInInput
    {
        [EnumMember(Value = "received")]
        Received,
        [EnumMember(Value = "voided")]
        Voided
    }

    public class Requisition
    {
        [JsonProperty("id")]
        public JToken Id { get; set; }

        [JsonProperty("req-title")]
        public JToken ReqTitle { get; set; }

        [JsonProperty("status")]
        public JToken Status { get; set; }

        [JsonProperty("requested-by")]
        public ApprvlGetApprovalByIdUserResponse RequestedBy { get; set; }

        [JsonProperty("submitted-by")]
        public ApprvlGetApprovalByIdUserResponse SubmittedBy { get; set; }

        [JsonProperty("submitted-at")]
        public JToken SubmittedAt { get; set; }

        [JsonProperty("current-approval")]
        public Approval CurrentApproval { get; set; }

        [JsonProperty("ship-to-address")]
        public AddrGetAddressByIdAddressResponse ShipToAddress { get; set; }

        [JsonProperty("currency")]
        public RequisitionCurrencyType Currency { get; set; }

        [JsonProperty("total")]
        public JToken Total { get; set; }

        [JsonProperty("requisition-lines")]
        public RequisitionLine[] RequisitionLines { get; set; }

        [JsonProperty("department")]
        public RequisitionDepartmentType Department { get; set; }

        [JsonProperty("justification")]
        public JToken Justification { get; set; }

        [JsonProperty("need-by-date")]
        public JToken NeedByDate { get; set; }

        [JsonProperty("created-at")]
        public JToken CreatedAt { get; set; }

        [JsonProperty("updated-at")]
        public JToken UpdatedAt { get; set; }
    }

    public class RequisitionCurrencyType
    {
        [JsonProperty("id")]
        public JToken Id { get; set; }

        [JsonProperty("code")]
        public JToken Code { get; set; }
    }

    public class RequisitionLine
    {
        [JsonProperty("id")]
        public JToken Id { get; set; }

        [JsonProperty("line-num")]
        public JToken LineNum { get; set; }

        [JsonProperty("status")]
        public JToken Status { get; set; }

        [JsonProperty("description")]
        public JToken Description { get; set; }

        [JsonProperty("quantity")]
        public JToken Quantity { get; set; }

        [JsonProperty("price")]
        public JToken Price { get; set; }

        [JsonProperty("total")]
        public JToken Total { get; set; }

        [JsonProperty("need-by-date")]
        public JToken NeedByDate { get; set; }

        [JsonProperty("line-type")]
        public JToken LineType { get; set; }

        [JsonProperty("supplier-part-num")]
        public JToken SupplierPartNum { get; set; }

        [JsonProperty("supplier-aux-part-num")]
        public JToken SupplierAuxPartNum { get; set; }

        [JsonProperty("item")]
        public InvAbandonInvoicesItemResponse Item { get; set; }

        [JsonProperty("supplier")]
        public CntrGetContractByIdSupplierResponse Supplier { get; set; }

        [JsonProperty("account")]
        public Account Account { get; set; }

        [JsonProperty("uom")]
        public InvAbandonInvoicesUOMResponse Uom { get; set; }

        [JsonProperty("commodity")]
        public CommGetCommoditiesCommodityResponse Commodity { get; set; }

        [JsonProperty("currency")]
        public RequisitionLineCurrencyType Currency { get; set; }

        [JsonProperty("requisition")]
        public RequisitionLineRequisitionType Requisition { get; set; }

        [JsonProperty("created-at")]
        public JToken CreatedAt { get; set; }

        [JsonProperty("updated-at")]
        public JToken UpdatedAt { get; set; }
    }

    public class RequisitionLineCurrencyType
    {
        [JsonProperty("id")]
        public JToken Id { get; set; }

        [JsonProperty("code")]
        public JToken Code { get; set; }
    }

    public class RequisitionLineRequisitionType
    {
        [JsonProperty("id")]
        public JToken Id { get; set; }

        [JsonProperty("req-title")]
        public JToken ReqTitle { get; set; }
    }

    public class RequisitionDepartmentType
    {
        [JsonProperty("id")]
        public JToken Id { get; set; }

        [JsonProperty("name")]
        public JToken Name { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ReqGetRequisitionsStatusInInput
    {
        [EnumMember(Value = "draft")]
        Draft,
        [EnumMember(Value = "pending_approval")]
        PendingApproval,
        [EnumMember(Value = "approved")]
        Approved,
        [EnumMember(Value = "ordered")]
        Ordered,
        [EnumMember(Value = "soft_closed")]
        SoftClosed,
        [EnumMember(Value = "closed")]
        Closed,
        [EnumMember(Value = "cancelled")]
        Cancelled,
        [EnumMember(Value = "rejected")]
        Rejected
    }

    public class ReqAddToCartFreeTextBodyInput
    {
        [JsonProperty("ship-to-address", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputShipToAddressType ShipToAddress { get; set; } = new BodyInputShipToAddressType();

        [JsonProperty("requisition-lines")]
        public BodyInputRequisitionLinesTypeItem[] RequisitionLines { get; set; }

        [JsonProperty("status", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Status { get; set; } = "draft";

        [JsonProperty("requested-by", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputRequestedByType RequestedBy { get; set; } = new BodyInputRequestedByType();

        [JsonProperty("created-by", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputCreatedByType CreatedBy { get; set; } = new BodyInputCreatedByType();

        [JsonProperty("tags")]
        public BodyInputTagsTypeItem[] Tags { get; set; }
    }

    public class BodyInputShipToAddressType
    {
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Id { get; set; } = 1;
    }

    public class BodyInputRequisitionLinesTypeItem
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("quantity", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Quantity { get; set; } = 1;

        [JsonProperty("line-type", DefaultValueHandling = DefaultValueHandling.Include)]
        public string LineType { get; set; } = "RequisitionQuantityLine";

        [JsonProperty("unit-price")]
        public string UnitPrice { get; set; }

        [JsonProperty("source-part-num")]
        public string SourcePartNum { get; set; }

        [JsonProperty("commodity", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputRequisitionLinesTypeItemCommodityType Commodity { get; set; } = new BodyInputRequisitionLinesTypeItemCommodityType();

        [JsonProperty("uom", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputRequisitionLinesTypeItemUomType Uom { get; set; } = new BodyInputRequisitionLinesTypeItemUomType();

        [JsonProperty("supplier", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputRequisitionLinesTypeItemSupplierType Supplier { get; set; } = new BodyInputRequisitionLinesTypeItemSupplierType();
    }

    public class BodyInputRequisitionLinesTypeItemCommodityType
    {
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Id { get; set; } = 67;
    }

    public class BodyInputRequisitionLinesTypeItemUomType
    {
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Id { get; set; } = 1;
    }

    public class BodyInputRequisitionLinesTypeItemSupplierType
    {
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Id { get; set; } = 2;
    }

    public class BodyInputRequestedByType
    {
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Id { get; set; } = 238;
    }

    public class BodyInputCreatedByType
    {
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Id { get; set; } = 238;
    }

    public class BodyInputTagsTypeItem
    {
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Id { get; set; } = 11;
    }

    public class QuoteResponse
    {
        [JsonProperty("id")]
        public JToken Id { get; set; }

        [JsonProperty("state")]
        public JToken State { get; set; }

        [JsonProperty("awarded")]
        public JToken Awarded { get; set; }

        [JsonProperty("position")]
        public JToken Position { get; set; }

        [JsonProperty("promoted")]
        public JToken Promoted { get; set; }

        [JsonProperty("comments")]
        public JToken Comments { get; set; }

        [JsonProperty("quote-request-id")]
        public JToken QuoteRequestId { get; set; }

        [JsonProperty("quote-request-original-id")]
        public JToken QuoteRequestOriginalId { get; set; }

        [JsonProperty("quote-request-revision")]
        public JToken QuoteRequestRevision { get; set; }

        [JsonProperty("submitted-at")]
        public JToken SubmittedAt { get; set; }

        [JsonProperty("created-at")]
        public JToken CreatedAt { get; set; }

        [JsonProperty("updated-at")]
        public JToken UpdatedAt { get; set; }

        [JsonProperty("created-by")]
        public ApprvlGetApprovalByIdUserResponse CreatedBy { get; set; }

        [JsonProperty("updated-by")]
        public ApprvlGetApprovalByIdUserResponse UpdatedBy { get; set; }

        [JsonProperty("quote-supplier")]
        public JToken QuoteSupplier { get; set; }

        [JsonProperty("lines")]
        public QuoteResponseLine[] Lines { get; set; }

        [JsonProperty("quote-request-attachment-response")]
        public JToken QuoteRequestAttachmentResponse { get; set; }
    }

    public class QuoteResponseLine
    {
        [JsonProperty("id")]
        public JToken Id { get; set; }

        [JsonProperty("quantity")]
        public JToken Quantity { get; set; }

        [JsonProperty("reporting-price-amount")]
        public JToken ReportingPriceAmount { get; set; }

        [JsonProperty("quote-request-line-id")]
        public JToken QuoteRequestLineId { get; set; }

        [JsonProperty("lot-id")]
        public JToken LotId { get; set; }

        [JsonProperty("awarded")]
        public JToken Awarded { get; set; }

        [JsonProperty("easy-form-response")]
        public JToken EasyFormResponse { get; set; }

        [JsonProperty("shipping-term")]
        public JToken ShippingTerm { get; set; }

        [JsonProperty("price-amount")]
        public JToken PriceAmount { get; set; }

        [JsonProperty("cost-element-values")]
        public JToken CostElementValues { get; set; }

        [JsonProperty("lead-time")]
        public JToken LeadTime { get; set; }

        [JsonProperty("supplier-item-name")]
        public JToken SupplierItemName { get; set; }

        [JsonProperty("item-part-number")]
        public JToken ItemPartNumber { get; set; }

        [JsonProperty("item-description")]
        public JToken ItemDescription { get; set; }

        [JsonProperty("price-currency")]
        public JToken PriceCurrency { get; set; }

        [JsonProperty("attachments")]
        public JToken[] Attachments { get; set; }

        [JsonProperty("created-at")]
        public JToken CreatedAt { get; set; }

        [JsonProperty("updated-at")]
        public JToken UpdatedAt { get; set; }

        [JsonProperty("created-by")]
        public ApprvlGetApprovalByIdUserResponse CreatedBy { get; set; }

        [JsonProperty("updated-by")]
        public ApprvlGetApprovalByIdUserResponse UpdatedBy { get; set; }
    }

    public class SrcAwardQuoteResponseBodyInput
    {
        [JsonProperty("quote_response_line_ids")]
        public int[] QuoteResponseLineIds { get; set; }
    }

    public class QuoteRequest
    {
        [JsonProperty("id")]
        public JToken Id { get; set; }

        [JsonProperty("description")]
        public JToken Description { get; set; }

        [JsonProperty("event-type")]
        public JToken EventType { get; set; }

        [JsonProperty("status")]
        public JToken Status { get; set; }

        [JsonProperty("allow-award-individual-line-items")]
        public JToken AllowAwardIndividualLineItems { get; set; }

        [JsonProperty("allow-multiple-response")]
        public JToken AllowMultipleResponse { get; set; }

        [JsonProperty("auto-unseal-bid")]
        public JToken AutoUnsealBid { get; set; }

        [JsonProperty("exported")]
        public JToken Exported { get; set; }

        [JsonProperty("end-time")]
        public JToken EndTime { get; set; }

        [JsonProperty("currency")]
        public QuoteRequestCurrencyType Currency { get; set; }

        [JsonProperty("procurement-category")]
        public JToken ProcurementCategory { get; set; }

        [JsonProperty("content-groups")]
        public JToken ContentGroups { get; set; }

        [JsonProperty("attachments")]
        public JToken[] Attachments { get; set; }

        [JsonProperty("comments")]
        public JToken Comments { get; set; }

        [JsonProperty("easy-forms")]
        public JToken EasyForms { get; set; }

        [JsonProperty("custom-fields")]
        public JToken CustomFields { get; set; }

        [JsonProperty("business-partners")]
        public JToken BusinessPartners { get; set; }

        [JsonProperty("created-at")]
        public JToken CreatedAt { get; set; }

        [JsonProperty("updated-at")]
        public JToken UpdatedAt { get; set; }

        [JsonProperty("created-by")]
        public ApprvlGetApprovalByIdUserResponse CreatedBy { get; set; }

        [JsonProperty("updated-by")]
        public ApprvlGetApprovalByIdUserResponse UpdatedBy { get; set; }
    }

    public class QuoteRequestCurrencyType
    {
        [JsonProperty("id")]
        public JToken Id { get; set; }

        [JsonProperty("code")]
        public JToken Code { get; set; }
    }

    public class SrcCreateQuoteRequestBodyInput
    {
        [JsonProperty("id")]
        public JToken Id { get; set; }

        [JsonProperty("description")]
        public JToken Description { get; set; }

        [JsonProperty("event-type")]
        public JToken EventType { get; set; }

        [JsonProperty("status")]
        public JToken Status { get; set; }

        [JsonProperty("allow-award-individual-line-items")]
        public JToken AllowAwardIndividualLineItems { get; set; }

        [JsonProperty("allow-multiple-response")]
        public JToken AllowMultipleResponse { get; set; }

        [JsonProperty("auto-unseal-bid")]
        public JToken AutoUnsealBid { get; set; }

        [JsonProperty("exported")]
        public JToken Exported { get; set; }

        [JsonProperty("end-time")]
        public JToken EndTime { get; set; }

        [JsonProperty("currency")]
        public BodyInputCurrencyType Currency { get; set; }

        [JsonProperty("procurement-category")]
        public JToken ProcurementCategory { get; set; }

        [JsonProperty("content-groups")]
        public JToken ContentGroups { get; set; }

        [JsonProperty("attachments")]
        public JToken[] Attachments { get; set; }

        [JsonProperty("comments")]
        public JToken Comments { get; set; }

        [JsonProperty("easy-forms")]
        public JToken EasyForms { get; set; }

        [JsonProperty("custom-fields")]
        public JToken CustomFields { get; set; }

        [JsonProperty("business-partners")]
        public JToken BusinessPartners { get; set; }

        [JsonProperty("created-at")]
        public JToken CreatedAt { get; set; }

        [JsonProperty("updated-at")]
        public JToken UpdatedAt { get; set; }

        [JsonProperty("created-by")]
        public OrdListCreateOrderPadUser CreatedBy { get; set; }

        [JsonProperty("updated-by")]
        public OrdListCreateOrderPadUser UpdatedBy { get; set; }
    }

    public class BodyInputCurrencyType
    {
        [JsonProperty("id")]
        public JToken Id { get; set; }

        [JsonProperty("code")]
        public JToken Code { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SupGetSuppliersStatusInInput
    {
        [EnumMember(Value = "active")]
        Active,
        [EnumMember(Value = "inactive")]
        Inactive
    }

    public class SupUpdateSupplierBodyInput
    {
        [JsonProperty("id")]
        public JToken Id { get; set; }

        [JsonProperty("name")]
        public JToken Name { get; set; }

        [JsonProperty("display-name")]
        public JToken DisplayName { get; set; }

        [JsonProperty("number")]
        public JToken Number { get; set; }

        [JsonProperty("status")]
        public JToken Status { get; set; }

        [JsonProperty("po-method")]
        public JToken PoMethod { get; set; }

        [JsonProperty("po-email")]
        public JToken PoEmail { get; set; }

        [JsonProperty("payment-method")]
        public JToken PaymentMethod { get; set; }

        [JsonProperty("payment-term")]
        public InvAbandonInvoicesPaymentTerm PaymentTerm { get; set; }

        [JsonProperty("tax-id")]
        public JToken TaxId { get; set; }

        [JsonProperty("website")]
        public JToken Website { get; set; }

        [JsonProperty("duns")]
        public JToken Duns { get; set; }

        [JsonProperty("on-hold")]
        public JToken OnHold { get; set; }

        [JsonProperty("primary-contact")]
        public OrdListCreateOrderPadUser PrimaryContact { get; set; }

        [JsonProperty("primary-address")]
        public OrdListCreateOrderPadAddress PrimaryAddress { get; set; }

        [JsonProperty("created-at")]
        public JToken CreatedAt { get; set; }

        [JsonProperty("updated-at")]
        public JToken UpdatedAt { get; set; }
    }

    public class SupplierInformation
    {
        [JsonProperty("id")]
        public JToken Id { get; set; }

        [JsonProperty("supplier-id")]
        public JToken SupplierId { get; set; }

        [JsonProperty("supplier-name")]
        public JToken SupplierName { get; set; }

        [JsonProperty("name")]
        public JToken Name { get; set; }

        [JsonProperty("status")]
        public JToken Status { get; set; }

        [JsonProperty("display-name")]
        public JToken DisplayName { get; set; }

        [JsonProperty("supplier-number")]
        public JToken SupplierNumber { get; set; }

        [JsonProperty("payment-term")]
        public CntrGetContractByIdPaymentTermResponse PaymentTerm { get; set; }

        [JsonProperty("po-method")]
        public JToken PoMethod { get; set; }

        [JsonProperty("po-email")]
        public JToken PoEmail { get; set; }

        [JsonProperty("website")]
        public JToken Website { get; set; }

        [JsonProperty("created-at")]
        public JToken CreatedAt { get; set; }

        [JsonProperty("updated-at")]
        public JToken UpdatedAt { get; set; }

        [JsonProperty("created-by")]
        public ApprvlGetApprovalByIdUserResponse CreatedBy { get; set; }

        [JsonProperty("updated-by")]
        public ApprvlGetApprovalByIdUserResponse UpdatedBy { get; set; }
    }

    public class SupplierItem
    {
        [JsonProperty("id")]
        public JToken Id { get; set; }

        [JsonProperty("active")]
        public JToken Active { get; set; }

        [JsonProperty("supplier-part-num")]
        public JToken SupplierPartNum { get; set; }

        [JsonProperty("unit-price")]
        public JToken UnitPrice { get; set; }

        [JsonProperty("currency")]
        public SupplierItemCurrencyType Currency { get; set; }

        [JsonProperty("item")]
        public InvAbandonInvoicesItemResponse Item { get; set; }

        [JsonProperty("supplier")]
        public CntrGetContractByIdSupplierResponse Supplier { get; set; }

        [JsonProperty("created-at")]
        public JToken CreatedAt { get; set; }

        [JsonProperty("updated-at")]
        public JToken UpdatedAt { get; set; }
    }

    public class SupplierItemCurrencyType
    {
        [JsonProperty("code")]
        public JToken Code { get; set; }
    }

    public class UserGroup
    {
        [JsonProperty("id")]
        public JToken Id { get; set; }

        [JsonProperty("name")]
        public JToken Name { get; set; }

        [JsonProperty("description")]
        public JToken Description { get; set; }

        [JsonProperty("active")]
        public JToken Active { get; set; }

        [JsonProperty("created-at")]
        public JToken CreatedAt { get; set; }

        [JsonProperty("updated-at")]
        public JToken UpdatedAt { get; set; }
    }

    public class UserGroupMembership
    {
        [JsonProperty("id")]
        public JToken Id { get; set; }

        [JsonProperty("user")]
        public ApprvlGetApprovalByIdUserResponse User { get; set; }

        [JsonProperty("user_group")]
        public UserGroup UserGroup { get; set; }

        [JsonProperty("created-at")]
        public JToken CreatedAt { get; set; }

        [JsonProperty("updated-at")]
        public JToken UpdatedAt { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Coupaip;

    public partial class WorkflowManagedActions
    {
        public CoupaipActions Coupaip(string connectionId) => new CoupaipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public CoupaipTriggers Coupaip(string connectionId) => new CoupaipTriggers(connectionId);
    }
}