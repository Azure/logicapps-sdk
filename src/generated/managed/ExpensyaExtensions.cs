//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Expensya
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ExpensyaActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expensya")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> GetExpenseImage(Expression<Func<string>> expenseId)
        {
            var __workflow_expenseId = WorkflowExpression.Compile(expenseId, nameof(expenseId), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/expense/{0}/image", __workflow_expenseId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expensya")]
        public IBodyWorkflowAction<BaseResultExportResponse, ApiConnectionActionConfiguration> ExportExpenses(Expression<Func<string>> exportId, Expression<Func<string>> reportId = null, Expression<Func<string>> categoryId = null, Expression<Func<string>> expenseName = null, Expression<Func<string>> startDate = null, Expression<Func<string>> endDate = null, Expression<Func<string>> expenseStates = null, Expression<Func<string>> reportStates = null, Expression<Func<string>> userIds = null, Expression<Func<string>> userMail = null, Expression<Func<string>> reportIds = null, Expression<Func<string>> expenseIds = null, Expression<Func<string>> reportName = null, Expression<Func<string>> reportIdShort = null, Expression<Func<int>> dateFilterType = null, Expression<Func<string>> payId = null, Expression<Func<string>> payId2 = null, Expression<Func<string>> payId3 = null, Expression<Func<string>> accountingPeriod = null, Expression<Func<bool>> includeReceipts = null, Expression<Func<int>> expenseUseTypes = null, Expression<Func<string>> archiveExpenses = null)
        {
            var __workflow_exportId = WorkflowExpression.Compile(exportId, nameof(exportId), required: true);
            var __workflow_reportId = WorkflowExpression.Compile(reportId, nameof(reportId), required: false);
            var __workflow_categoryId = WorkflowExpression.Compile(categoryId, nameof(categoryId), required: false);
            var __workflow_expenseName = WorkflowExpression.Compile(expenseName, nameof(expenseName), required: false);
            var __workflow_startDate = WorkflowExpression.Compile(startDate, nameof(startDate), required: false);
            var __workflow_endDate = WorkflowExpression.Compile(endDate, nameof(endDate), required: false);
            var __workflow_expenseStates = WorkflowExpression.Compile(expenseStates, nameof(expenseStates), required: false);
            var __workflow_reportStates = WorkflowExpression.Compile(reportStates, nameof(reportStates), required: false);
            var __workflow_userIds = WorkflowExpression.Compile(userIds, nameof(userIds), required: false);
            var __workflow_userMail = WorkflowExpression.Compile(userMail, nameof(userMail), required: false);
            var __workflow_reportIds = WorkflowExpression.Compile(reportIds, nameof(reportIds), required: false);
            var __workflow_expenseIds = WorkflowExpression.Compile(expenseIds, nameof(expenseIds), required: false);
            var __workflow_reportName = WorkflowExpression.Compile(reportName, nameof(reportName), required: false);
            var __workflow_reportIdShort = WorkflowExpression.Compile(reportIdShort, nameof(reportIdShort), required: false);
            var __workflow_dateFilterType = WorkflowExpression.Compile(dateFilterType, nameof(dateFilterType), required: false);
            var __workflow_payId = WorkflowExpression.Compile(payId, nameof(payId), required: false);
            var __workflow_payId2 = WorkflowExpression.Compile(payId2, nameof(payId2), required: false);
            var __workflow_payId3 = WorkflowExpression.Compile(payId3, nameof(payId3), required: false);
            var __workflow_accountingPeriod = WorkflowExpression.Compile(accountingPeriod, nameof(accountingPeriod), required: false);
            var __workflow_includeReceipts = WorkflowExpression.Compile(includeReceipts, nameof(includeReceipts), required: false);
            var __workflow_expenseUseTypes = WorkflowExpression.Compile(expenseUseTypes, nameof(expenseUseTypes), required: false);
            var __workflow_archiveExpenses = WorkflowExpression.Compile(archiveExpenses, nameof(archiveExpenses), required: false);
            return new DeferredBodyAction<BaseResultExportResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/export/expenses/{0}/", __workflow_exportId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_reportId != null)
                    callPayload.Queries["reportId"] = ExpressionConverter.Convert(__workflow_reportId);
                if (__workflow_categoryId != null)
                    callPayload.Queries["categoryId"] = ExpressionConverter.Convert(__workflow_categoryId);
                if (__workflow_expenseName != null)
                    callPayload.Queries["expenseName"] = ExpressionConverter.Convert(__workflow_expenseName);
                if (__workflow_startDate != null)
                    callPayload.Queries["startDate"] = ExpressionConverter.Convert(__workflow_startDate);
                if (__workflow_endDate != null)
                    callPayload.Queries["endDate"] = ExpressionConverter.Convert(__workflow_endDate);
                if (__workflow_expenseStates != null)
                    callPayload.Queries["expenseStates"] = ExpressionConverter.Convert(__workflow_expenseStates);
                if (__workflow_reportStates != null)
                    callPayload.Queries["reportStates"] = ExpressionConverter.Convert(__workflow_reportStates);
                if (__workflow_userIds != null)
                    callPayload.Queries["userIds"] = ExpressionConverter.Convert(__workflow_userIds);
                if (__workflow_userMail != null)
                    callPayload.Queries["userMail"] = ExpressionConverter.Convert(__workflow_userMail);
                if (__workflow_reportIds != null)
                    callPayload.Queries["reportIds"] = ExpressionConverter.Convert(__workflow_reportIds);
                if (__workflow_expenseIds != null)
                    callPayload.Queries["expenseIds"] = ExpressionConverter.Convert(__workflow_expenseIds);
                if (__workflow_reportName != null)
                    callPayload.Queries["reportName"] = ExpressionConverter.Convert(__workflow_reportName);
                if (__workflow_reportIdShort != null)
                    callPayload.Queries["reportIdShort"] = ExpressionConverter.Convert(__workflow_reportIdShort);
                if (__workflow_dateFilterType != null)
                    callPayload.Queries["dateFilterType"] = ExpressionConverter.Convert(__workflow_dateFilterType);
                if (__workflow_payId != null)
                    callPayload.Queries["payId"] = ExpressionConverter.Convert(__workflow_payId);
                if (__workflow_payId2 != null)
                    callPayload.Queries["payId2"] = ExpressionConverter.Convert(__workflow_payId2);
                if (__workflow_payId3 != null)
                    callPayload.Queries["payId3"] = ExpressionConverter.Convert(__workflow_payId3);
                if (__workflow_accountingPeriod != null)
                    callPayload.Queries["accountingPeriod"] = ExpressionConverter.Convert(__workflow_accountingPeriod);
                if (__workflow_includeReceipts != null)
                    callPayload.Queries["includeReceipts"] = ExpressionConverter.Convert(__workflow_includeReceipts);
                if (__workflow_expenseUseTypes != null)
                    callPayload.Queries["expenseUseTypes"] = ExpressionConverter.Convert(__workflow_expenseUseTypes);
                if (__workflow_archiveExpenses != null)
                    callPayload.Queries["archiveExpenses"] = ExpressionConverter.Convert(__workflow_archiveExpenses);
                return new ApiConnectionAction<BaseResultExportResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expensya")]
        public IBodyWorkflowAction<BaseResultExportResponse, ApiConnectionActionConfiguration> PrintMission(Expression<Func<string>> reportId)
        {
            var __workflow_reportId = WorkflowExpression.Compile(reportId, nameof(reportId), required: true);
            return new DeferredBodyAction<BaseResultExportResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/export/report/{0}/pdf/", __workflow_reportId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<BaseResultExportResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expensya")]
        public IBodyWorkflowAction<BaseResultListExportFormatResponse, ApiConnectionActionConfiguration> ExportFormats(Expression<Func<bool>> isForExpenses = null, Expression<Func<int>> exportType = null)
        {
            var __workflow_isForExpenses = WorkflowExpression.Compile(isForExpenses, nameof(isForExpenses), required: false);
            var __workflow_exportType = WorkflowExpression.Compile(exportType, nameof(exportType), required: false);
            return new DeferredBodyAction<BaseResultListExportFormatResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/exports/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_isForExpenses != null)
                    callPayload.Queries["isForExpenses"] = ExpressionConverter.Convert(__workflow_isForExpenses);
                if (__workflow_exportType != null)
                    callPayload.Queries["exportType"] = ExpressionConverter.Convert(__workflow_exportType);
                return new ApiConnectionAction<BaseResultListExportFormatResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expensya")]
        public IBodyWorkflowAction<BaseResultListAddOrUpdateEntityResult, ApiConnectionActionConfiguration> AddProjects(Expression<Func<AddOrUpdateProjectInput[]>> addOrUpdateProjectInputArray = null)
        {
            var __workflow_addOrUpdateProjectInputArray = WorkflowExpression.Compile(addOrUpdateProjectInputArray, nameof(addOrUpdateProjectInputArray), required: false);
            return new DeferredBodyAction<BaseResultListAddOrUpdateEntityResult, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/projects/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_addOrUpdateProjectInputArray != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_addOrUpdateProjectInputArray);
                return new ApiConnectionAction<BaseResultListAddOrUpdateEntityResult>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expensya")]
        public IBodyWorkflowAction<BaseResultListAddOrUpdateEntityResult, ApiConnectionActionConfiguration> UpdateProjects(Expression<Func<AddOrUpdateProjectInput[]>> addOrUpdateProjectInputArray = null)
        {
            var __workflow_addOrUpdateProjectInputArray = WorkflowExpression.Compile(addOrUpdateProjectInputArray, nameof(addOrUpdateProjectInputArray), required: false);
            return new DeferredBodyAction<BaseResultListAddOrUpdateEntityResult, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/projects/";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_addOrUpdateProjectInputArray != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_addOrUpdateProjectInputArray);
                return new ApiConnectionAction<BaseResultListAddOrUpdateEntityResult>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expensya")]
        public IBodyWorkflowAction<BaseResult, ApiConnectionActionConfiguration> AddReciept(Expression<Func<AddRecieptInput>> addReceiptInput = null)
        {
            var __workflow_addReceiptInput = WorkflowExpression.Compile(addReceiptInput, nameof(addReceiptInput), required: false);
            return new DeferredBodyAction<BaseResult, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/receipt/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_addReceiptInput != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_addReceiptInput);
                return new ApiConnectionAction<BaseResult>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expensya")]
        public IBodyWorkflowAction<BaseResult, ApiConnectionActionConfiguration> RevokeUserToken()
        {
            return new DeferredBodyAction<BaseResult, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/revokeUserToken/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<BaseResult>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expensya")]
        public IBodyWorkflowAction<ListAndPagesCountResultReportResponse, ApiConnectionActionConfiguration> ValidatorReports(Expression<Func<string>> validatorMail, Expression<Func<string>> reportName = null, Expression<Func<string>> reportStartDate = null, Expression<Func<string>> reportEndDate = null, Expression<Func<string>> reportStates = null, Expression<Func<string>> reportIdShort = null, Expression<Func<string>> ownerId = null, Expression<Func<string>> ownerPayId2 = null, Expression<Func<string>> projectId = null, Expression<Func<int>> dateFilterType = null, Expression<Func<int>> sortBy = null, Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null, Expression<Func<bool>> isDesc = null)
        {
            var __workflow_validatorMail = WorkflowExpression.Compile(validatorMail, nameof(validatorMail), required: true);
            var __workflow_reportName = WorkflowExpression.Compile(reportName, nameof(reportName), required: false);
            var __workflow_reportStartDate = WorkflowExpression.Compile(reportStartDate, nameof(reportStartDate), required: false);
            var __workflow_reportEndDate = WorkflowExpression.Compile(reportEndDate, nameof(reportEndDate), required: false);
            var __workflow_reportStates = WorkflowExpression.Compile(reportStates, nameof(reportStates), required: false);
            var __workflow_reportIdShort = WorkflowExpression.Compile(reportIdShort, nameof(reportIdShort), required: false);
            var __workflow_ownerId = WorkflowExpression.Compile(ownerId, nameof(ownerId), required: false);
            var __workflow_ownerPayId2 = WorkflowExpression.Compile(ownerPayId2, nameof(ownerPayId2), required: false);
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: false);
            var __workflow_dateFilterType = WorkflowExpression.Compile(dateFilterType, nameof(dateFilterType), required: false);
            var __workflow_sortBy = WorkflowExpression.Compile(sortBy, nameof(sortBy), required: false);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_pageSize = WorkflowExpression.Compile(pageSize, nameof(pageSize), required: false);
            var __workflow_isDesc = WorkflowExpression.Compile(isDesc, nameof(isDesc), required: false);
            return new DeferredBodyAction<ListAndPagesCountResultReportResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v2/{0}/reports/", __workflow_validatorMail.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_reportName != null)
                    callPayload.Queries["reportName"] = ExpressionConverter.Convert(__workflow_reportName);
                if (__workflow_reportStartDate != null)
                    callPayload.Queries["reportStartDate"] = ExpressionConverter.Convert(__workflow_reportStartDate);
                if (__workflow_reportEndDate != null)
                    callPayload.Queries["reportEndDate"] = ExpressionConverter.Convert(__workflow_reportEndDate);
                if (__workflow_reportStates != null)
                    callPayload.Queries["reportStates"] = ExpressionConverter.Convert(__workflow_reportStates);
                if (__workflow_reportIdShort != null)
                    callPayload.Queries["reportIdShort"] = ExpressionConverter.Convert(__workflow_reportIdShort);
                if (__workflow_ownerId != null)
                    callPayload.Queries["ownerId"] = ExpressionConverter.Convert(__workflow_ownerId);
                if (__workflow_ownerPayId2 != null)
                    callPayload.Queries["ownerPayId2"] = ExpressionConverter.Convert(__workflow_ownerPayId2);
                if (__workflow_projectId != null)
                    callPayload.Queries["projectId"] = ExpressionConverter.Convert(__workflow_projectId);
                if (__workflow_dateFilterType != null)
                    callPayload.Queries["dateFilterType"] = ExpressionConverter.Convert(__workflow_dateFilterType);
                if (__workflow_sortBy != null)
                    callPayload.Queries["sortBy"] = ExpressionConverter.Convert(__workflow_sortBy);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(__workflow_pageSize);
                if (__workflow_isDesc != null)
                    callPayload.Queries["isDesc"] = ExpressionConverter.Convert(__workflow_isDesc);
                return new ApiConnectionAction<ListAndPagesCountResultReportResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expensya")]
        public IBodyWorkflowAction<BaseResult, ApiConnectionActionConfiguration> UpdateReportStatus(Expression<Func<string>> reportId, Expression<Func<UpdateReportStatusInput>> reportUpdateStatusInput = null)
        {
            var __workflow_reportId = WorkflowExpression.Compile(reportId, nameof(reportId), required: true);
            var __workflow_reportUpdateStatusInput = WorkflowExpression.Compile(reportUpdateStatusInput, nameof(reportUpdateStatusInput), required: false);
            return new DeferredBodyAction<BaseResult, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v2/report/{0}/updateStatus/", __workflow_reportId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_reportUpdateStatusInput != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_reportUpdateStatusInput);
                return new ApiConnectionAction<BaseResult>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expensya")]
        public IBodyWorkflowAction<ListAndPagesCountResultReportResponse, ApiConnectionActionConfiguration> CompanyReports(Expression<Func<string>> reportName = null, Expression<Func<string>> reportStartDate = null, Expression<Func<string>> reportEndDate = null, Expression<Func<string>> reportStates = null, Expression<Func<string>> reportIdShort = null, Expression<Func<string>> ownerId = null, Expression<Func<string>> ownerPayId2 = null, Expression<Func<string>> projectId = null, Expression<Func<string>> tagsNames = null, Expression<Func<int>> dateFilterType = null, Expression<Func<int>> sortBy = null, Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null, Expression<Func<bool>> isDesc = null)
        {
            var __workflow_reportName = WorkflowExpression.Compile(reportName, nameof(reportName), required: false);
            var __workflow_reportStartDate = WorkflowExpression.Compile(reportStartDate, nameof(reportStartDate), required: false);
            var __workflow_reportEndDate = WorkflowExpression.Compile(reportEndDate, nameof(reportEndDate), required: false);
            var __workflow_reportStates = WorkflowExpression.Compile(reportStates, nameof(reportStates), required: false);
            var __workflow_reportIdShort = WorkflowExpression.Compile(reportIdShort, nameof(reportIdShort), required: false);
            var __workflow_ownerId = WorkflowExpression.Compile(ownerId, nameof(ownerId), required: false);
            var __workflow_ownerPayId2 = WorkflowExpression.Compile(ownerPayId2, nameof(ownerPayId2), required: false);
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: false);
            var __workflow_tagsNames = WorkflowExpression.Compile(tagsNames, nameof(tagsNames), required: false);
            var __workflow_dateFilterType = WorkflowExpression.Compile(dateFilterType, nameof(dateFilterType), required: false);
            var __workflow_sortBy = WorkflowExpression.Compile(sortBy, nameof(sortBy), required: false);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_pageSize = WorkflowExpression.Compile(pageSize, nameof(pageSize), required: false);
            var __workflow_isDesc = WorkflowExpression.Compile(isDesc, nameof(isDesc), required: false);
            return new DeferredBodyAction<ListAndPagesCountResultReportResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v2/reports/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_reportName != null)
                    callPayload.Queries["reportName"] = ExpressionConverter.Convert(__workflow_reportName);
                if (__workflow_reportStartDate != null)
                    callPayload.Queries["reportStartDate"] = ExpressionConverter.Convert(__workflow_reportStartDate);
                if (__workflow_reportEndDate != null)
                    callPayload.Queries["reportEndDate"] = ExpressionConverter.Convert(__workflow_reportEndDate);
                if (__workflow_reportStates != null)
                    callPayload.Queries["reportStates"] = ExpressionConverter.Convert(__workflow_reportStates);
                if (__workflow_reportIdShort != null)
                    callPayload.Queries["reportIdShort"] = ExpressionConverter.Convert(__workflow_reportIdShort);
                if (__workflow_ownerId != null)
                    callPayload.Queries["ownerId"] = ExpressionConverter.Convert(__workflow_ownerId);
                if (__workflow_ownerPayId2 != null)
                    callPayload.Queries["ownerPayId2"] = ExpressionConverter.Convert(__workflow_ownerPayId2);
                if (__workflow_projectId != null)
                    callPayload.Queries["projectId"] = ExpressionConverter.Convert(__workflow_projectId);
                if (__workflow_tagsNames != null)
                    callPayload.Queries["tagsNames"] = ExpressionConverter.Convert(__workflow_tagsNames);
                if (__workflow_dateFilterType != null)
                    callPayload.Queries["dateFilterType"] = ExpressionConverter.Convert(__workflow_dateFilterType);
                if (__workflow_sortBy != null)
                    callPayload.Queries["sortBy"] = ExpressionConverter.Convert(__workflow_sortBy);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(__workflow_pageSize);
                if (__workflow_isDesc != null)
                    callPayload.Queries["isDesc"] = ExpressionConverter.Convert(__workflow_isDesc);
                return new ApiConnectionAction<ListAndPagesCountResultReportResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expensya")]
        public IBodyWorkflowAction<ListAndPagesCountResultUserResponse, ApiConnectionActionConfiguration> CompanyUsers(Expression<Func<string>> id = null, Expression<Func<string>> firstName = null, Expression<Func<string>> lastName = null, Expression<Func<string>> mail = null, Expression<Func<string>> payId = null, Expression<Func<string>> mailOrNameOrPayId = null, Expression<Func<int>> type = null, Expression<Func<int>> state = null, Expression<Func<string>> reviewerId = null, Expression<Func<string>> reviewerName = null, Expression<Func<string>> managerId = null, Expression<Func<string>> managerName = null, Expression<Func<string>> userIds = null, Expression<Func<string>> userMails = null, Expression<Func<string>> tagsNames = null, Expression<Func<string>> simpleTagsNames = null, Expression<Func<int>> sortBy = null, Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null, Expression<Func<bool>> isDesc = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: false);
            var __workflow_firstName = WorkflowExpression.Compile(firstName, nameof(firstName), required: false);
            var __workflow_lastName = WorkflowExpression.Compile(lastName, nameof(lastName), required: false);
            var __workflow_mail = WorkflowExpression.Compile(mail, nameof(mail), required: false);
            var __workflow_payId = WorkflowExpression.Compile(payId, nameof(payId), required: false);
            var __workflow_mailOrNameOrPayId = WorkflowExpression.Compile(mailOrNameOrPayId, nameof(mailOrNameOrPayId), required: false);
            var __workflow_type = WorkflowExpression.Compile(type, nameof(type), required: false);
            var __workflow_state = WorkflowExpression.Compile(state, nameof(state), required: false);
            var __workflow_reviewerId = WorkflowExpression.Compile(reviewerId, nameof(reviewerId), required: false);
            var __workflow_reviewerName = WorkflowExpression.Compile(reviewerName, nameof(reviewerName), required: false);
            var __workflow_managerId = WorkflowExpression.Compile(managerId, nameof(managerId), required: false);
            var __workflow_managerName = WorkflowExpression.Compile(managerName, nameof(managerName), required: false);
            var __workflow_userIds = WorkflowExpression.Compile(userIds, nameof(userIds), required: false);
            var __workflow_userMails = WorkflowExpression.Compile(userMails, nameof(userMails), required: false);
            var __workflow_tagsNames = WorkflowExpression.Compile(tagsNames, nameof(tagsNames), required: false);
            var __workflow_simpleTagsNames = WorkflowExpression.Compile(simpleTagsNames, nameof(simpleTagsNames), required: false);
            var __workflow_sortBy = WorkflowExpression.Compile(sortBy, nameof(sortBy), required: false);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_pageSize = WorkflowExpression.Compile(pageSize, nameof(pageSize), required: false);
            var __workflow_isDesc = WorkflowExpression.Compile(isDesc, nameof(isDesc), required: false);
            return new DeferredBodyAction<ListAndPagesCountResultUserResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v2/users/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_id != null)
                    callPayload.Queries["id"] = ExpressionConverter.Convert(__workflow_id);
                if (__workflow_firstName != null)
                    callPayload.Queries["firstName"] = ExpressionConverter.Convert(__workflow_firstName);
                if (__workflow_lastName != null)
                    callPayload.Queries["lastName"] = ExpressionConverter.Convert(__workflow_lastName);
                if (__workflow_mail != null)
                    callPayload.Queries["mail"] = ExpressionConverter.Convert(__workflow_mail);
                if (__workflow_payId != null)
                    callPayload.Queries["payId"] = ExpressionConverter.Convert(__workflow_payId);
                if (__workflow_mailOrNameOrPayId != null)
                    callPayload.Queries["mailOrNameOrPayId"] = ExpressionConverter.Convert(__workflow_mailOrNameOrPayId);
                if (__workflow_type != null)
                    callPayload.Queries["type"] = ExpressionConverter.Convert(__workflow_type);
                if (__workflow_state != null)
                    callPayload.Queries["state"] = ExpressionConverter.Convert(__workflow_state);
                if (__workflow_reviewerId != null)
                    callPayload.Queries["reviewerId"] = ExpressionConverter.Convert(__workflow_reviewerId);
                if (__workflow_reviewerName != null)
                    callPayload.Queries["reviewerName"] = ExpressionConverter.Convert(__workflow_reviewerName);
                if (__workflow_managerId != null)
                    callPayload.Queries["managerId"] = ExpressionConverter.Convert(__workflow_managerId);
                if (__workflow_managerName != null)
                    callPayload.Queries["managerName"] = ExpressionConverter.Convert(__workflow_managerName);
                if (__workflow_userIds != null)
                    callPayload.Queries["userIds"] = ExpressionConverter.Convert(__workflow_userIds);
                if (__workflow_userMails != null)
                    callPayload.Queries["userMails"] = ExpressionConverter.Convert(__workflow_userMails);
                if (__workflow_tagsNames != null)
                    callPayload.Queries["tagsNames"] = ExpressionConverter.Convert(__workflow_tagsNames);
                if (__workflow_simpleTagsNames != null)
                    callPayload.Queries["simpleTagsNames"] = ExpressionConverter.Convert(__workflow_simpleTagsNames);
                if (__workflow_sortBy != null)
                    callPayload.Queries["sortBy"] = ExpressionConverter.Convert(__workflow_sortBy);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(__workflow_pageSize);
                if (__workflow_isDesc != null)
                    callPayload.Queries["isDesc"] = ExpressionConverter.Convert(__workflow_isDesc);
                return new ApiConnectionAction<ListAndPagesCountResultUserResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expensya")]
        public IBodyWorkflowAction<BaseResult, ApiConnectionActionConfiguration> AddQuickExpense(Expression<Func<string>> userId, Expression<Func<AddQuickExpenseV2Input>> quickExpenseInput = null)
        {
            var __workflow_userId = WorkflowExpression.Compile(userId, nameof(userId), required: true);
            var __workflow_quickExpenseInput = WorkflowExpression.Compile(quickExpenseInput, nameof(quickExpenseInput), required: false);
            return new DeferredBodyAction<BaseResult, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v2/quickexpense/{0}/", __workflow_userId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_quickExpenseInput != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_quickExpenseInput);
                return new ApiConnectionAction<BaseResult>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expensya")]
        public IBodyWorkflowAction<ListAndPagesCountResultCategoryResponse, ApiConnectionActionConfiguration> GetCategories(Expression<Func<string>> id = null, Expression<Func<string>> categoryName = null, Expression<Func<string>> costAccount = null, Expression<Func<string>> vatAccount = null, Expression<Func<bool>> isActive = null, Expression<Func<string>> tagsNames = null, Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null, Expression<Func<int>> sortBy = null, Expression<Func<bool>> isDesc = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: false);
            var __workflow_categoryName = WorkflowExpression.Compile(categoryName, nameof(categoryName), required: false);
            var __workflow_costAccount = WorkflowExpression.Compile(costAccount, nameof(costAccount), required: false);
            var __workflow_vatAccount = WorkflowExpression.Compile(vatAccount, nameof(vatAccount), required: false);
            var __workflow_isActive = WorkflowExpression.Compile(isActive, nameof(isActive), required: false);
            var __workflow_tagsNames = WorkflowExpression.Compile(tagsNames, nameof(tagsNames), required: false);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_pageSize = WorkflowExpression.Compile(pageSize, nameof(pageSize), required: false);
            var __workflow_sortBy = WorkflowExpression.Compile(sortBy, nameof(sortBy), required: false);
            var __workflow_isDesc = WorkflowExpression.Compile(isDesc, nameof(isDesc), required: false);
            return new DeferredBodyAction<ListAndPagesCountResultCategoryResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v2/categories/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_id != null)
                    callPayload.Queries["id"] = ExpressionConverter.Convert(__workflow_id);
                if (__workflow_categoryName != null)
                    callPayload.Queries["categoryName"] = ExpressionConverter.Convert(__workflow_categoryName);
                if (__workflow_costAccount != null)
                    callPayload.Queries["costAccount"] = ExpressionConverter.Convert(__workflow_costAccount);
                if (__workflow_vatAccount != null)
                    callPayload.Queries["vatAccount"] = ExpressionConverter.Convert(__workflow_vatAccount);
                if (__workflow_isActive != null)
                    callPayload.Queries["isActive"] = ExpressionConverter.Convert(__workflow_isActive);
                if (__workflow_tagsNames != null)
                    callPayload.Queries["tagsNames"] = ExpressionConverter.Convert(__workflow_tagsNames);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(__workflow_pageSize);
                if (__workflow_sortBy != null)
                    callPayload.Queries["sortBy"] = ExpressionConverter.Convert(__workflow_sortBy);
                if (__workflow_isDesc != null)
                    callPayload.Queries["isDesc"] = ExpressionConverter.Convert(__workflow_isDesc);
                return new ApiConnectionAction<ListAndPagesCountResultCategoryResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expensya")]
        public IBodyWorkflowAction<ListAndPagesCountResultExpenseResponse, ApiConnectionActionConfiguration> GetExpensesWithPaging(Expression<Func<string>> reportId = null, Expression<Func<string>> categoryId = null, Expression<Func<string>> expenseName = null, Expression<Func<string>> startDate = null, Expression<Func<string>> endDate = null, Expression<Func<int>> reportState = null, Expression<Func<string>> expenseStates = null, Expression<Func<bool>> isReimbusable = null, Expression<Func<double>> valueInCurrency = null, Expression<Func<string>> ownerId = null, Expression<Func<string>> ownerMail = null, Expression<Func<string>> ownerPayId = null, Expression<Func<string>> ownerPayId2 = null, Expression<Func<string>> ownerPayId3 = null, Expression<Func<string>> ownerPayId4 = null, Expression<Func<string>> ownerPayId5 = null, Expression<Func<string>> ownerPayId6 = null, Expression<Func<string>> projectId = null, Expression<Func<bool>> isBillable = null, Expression<Func<int>> dateFilterType = null, Expression<Func<string>> merchantCountries = null, Expression<Func<string>> currencies = null, Expression<Func<string>> fileType = null, Expression<Func<string>> reportIdShort = null, Expression<Func<string>> expenseUseTypes = null, Expression<Func<string>> supplierId = null, Expression<Func<string>> expenseIds = null, Expression<Func<string>> merchantName = null, Expression<Func<string>> vatCode = null, Expression<Func<double>> valueHTInExpenseCurrency = null, Expression<Func<double>> vatRate = null, Expression<Func<double>> vatValue = null, Expression<Func<string>> reportsIds = null, Expression<Func<int>> dateTimeOffset = null, Expression<Func<string>> tagsNames = null, Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null, Expression<Func<int>> sortBy = null, Expression<Func<bool>> isDesc = null)
        {
            var __workflow_reportId = WorkflowExpression.Compile(reportId, nameof(reportId), required: false);
            var __workflow_categoryId = WorkflowExpression.Compile(categoryId, nameof(categoryId), required: false);
            var __workflow_expenseName = WorkflowExpression.Compile(expenseName, nameof(expenseName), required: false);
            var __workflow_startDate = WorkflowExpression.Compile(startDate, nameof(startDate), required: false);
            var __workflow_endDate = WorkflowExpression.Compile(endDate, nameof(endDate), required: false);
            var __workflow_reportState = WorkflowExpression.Compile(reportState, nameof(reportState), required: false);
            var __workflow_expenseStates = WorkflowExpression.Compile(expenseStates, nameof(expenseStates), required: false);
            var __workflow_isReimbusable = WorkflowExpression.Compile(isReimbusable, nameof(isReimbusable), required: false);
            var __workflow_valueInCurrency = WorkflowExpression.Compile(valueInCurrency, nameof(valueInCurrency), required: false);
            var __workflow_ownerId = WorkflowExpression.Compile(ownerId, nameof(ownerId), required: false);
            var __workflow_ownerMail = WorkflowExpression.Compile(ownerMail, nameof(ownerMail), required: false);
            var __workflow_ownerPayId = WorkflowExpression.Compile(ownerPayId, nameof(ownerPayId), required: false);
            var __workflow_ownerPayId2 = WorkflowExpression.Compile(ownerPayId2, nameof(ownerPayId2), required: false);
            var __workflow_ownerPayId3 = WorkflowExpression.Compile(ownerPayId3, nameof(ownerPayId3), required: false);
            var __workflow_ownerPayId4 = WorkflowExpression.Compile(ownerPayId4, nameof(ownerPayId4), required: false);
            var __workflow_ownerPayId5 = WorkflowExpression.Compile(ownerPayId5, nameof(ownerPayId5), required: false);
            var __workflow_ownerPayId6 = WorkflowExpression.Compile(ownerPayId6, nameof(ownerPayId6), required: false);
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: false);
            var __workflow_isBillable = WorkflowExpression.Compile(isBillable, nameof(isBillable), required: false);
            var __workflow_dateFilterType = WorkflowExpression.Compile(dateFilterType, nameof(dateFilterType), required: false);
            var __workflow_merchantCountries = WorkflowExpression.Compile(merchantCountries, nameof(merchantCountries), required: false);
            var __workflow_currencies = WorkflowExpression.Compile(currencies, nameof(currencies), required: false);
            var __workflow_fileType = WorkflowExpression.Compile(fileType, nameof(fileType), required: false);
            var __workflow_reportIdShort = WorkflowExpression.Compile(reportIdShort, nameof(reportIdShort), required: false);
            var __workflow_expenseUseTypes = WorkflowExpression.Compile(expenseUseTypes, nameof(expenseUseTypes), required: false);
            var __workflow_supplierId = WorkflowExpression.Compile(supplierId, nameof(supplierId), required: false);
            var __workflow_expenseIds = WorkflowExpression.Compile(expenseIds, nameof(expenseIds), required: false);
            var __workflow_merchantName = WorkflowExpression.Compile(merchantName, nameof(merchantName), required: false);
            var __workflow_vatCode = WorkflowExpression.Compile(vatCode, nameof(vatCode), required: false);
            var __workflow_valueHTInExpenseCurrency = WorkflowExpression.Compile(valueHTInExpenseCurrency, nameof(valueHTInExpenseCurrency), required: false);
            var __workflow_vatRate = WorkflowExpression.Compile(vatRate, nameof(vatRate), required: false);
            var __workflow_vatValue = WorkflowExpression.Compile(vatValue, nameof(vatValue), required: false);
            var __workflow_reportsIds = WorkflowExpression.Compile(reportsIds, nameof(reportsIds), required: false);
            var __workflow_dateTimeOffset = WorkflowExpression.Compile(dateTimeOffset, nameof(dateTimeOffset), required: false);
            var __workflow_tagsNames = WorkflowExpression.Compile(tagsNames, nameof(tagsNames), required: false);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_pageSize = WorkflowExpression.Compile(pageSize, nameof(pageSize), required: false);
            var __workflow_sortBy = WorkflowExpression.Compile(sortBy, nameof(sortBy), required: false);
            var __workflow_isDesc = WorkflowExpression.Compile(isDesc, nameof(isDesc), required: false);
            return new DeferredBodyAction<ListAndPagesCountResultExpenseResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v2/expenses/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_reportId != null)
                    callPayload.Queries["reportId"] = ExpressionConverter.Convert(__workflow_reportId);
                if (__workflow_categoryId != null)
                    callPayload.Queries["categoryId"] = ExpressionConverter.Convert(__workflow_categoryId);
                if (__workflow_expenseName != null)
                    callPayload.Queries["expenseName"] = ExpressionConverter.Convert(__workflow_expenseName);
                if (__workflow_startDate != null)
                    callPayload.Queries["startDate"] = ExpressionConverter.Convert(__workflow_startDate);
                if (__workflow_endDate != null)
                    callPayload.Queries["endDate"] = ExpressionConverter.Convert(__workflow_endDate);
                if (__workflow_reportState != null)
                    callPayload.Queries["reportState"] = ExpressionConverter.Convert(__workflow_reportState);
                if (__workflow_expenseStates != null)
                    callPayload.Queries["expenseStates"] = ExpressionConverter.Convert(__workflow_expenseStates);
                if (__workflow_isReimbusable != null)
                    callPayload.Queries["isReimbusable"] = ExpressionConverter.Convert(__workflow_isReimbusable);
                if (__workflow_valueInCurrency != null)
                    callPayload.Queries["valueInCurrency"] = ExpressionConverter.Convert(__workflow_valueInCurrency);
                if (__workflow_ownerId != null)
                    callPayload.Queries["ownerId"] = ExpressionConverter.Convert(__workflow_ownerId);
                if (__workflow_ownerMail != null)
                    callPayload.Queries["ownerMail"] = ExpressionConverter.Convert(__workflow_ownerMail);
                if (__workflow_ownerPayId != null)
                    callPayload.Queries["ownerPayId"] = ExpressionConverter.Convert(__workflow_ownerPayId);
                if (__workflow_ownerPayId2 != null)
                    callPayload.Queries["ownerPayId2"] = ExpressionConverter.Convert(__workflow_ownerPayId2);
                if (__workflow_ownerPayId3 != null)
                    callPayload.Queries["ownerPayId3"] = ExpressionConverter.Convert(__workflow_ownerPayId3);
                if (__workflow_ownerPayId4 != null)
                    callPayload.Queries["ownerPayId4"] = ExpressionConverter.Convert(__workflow_ownerPayId4);
                if (__workflow_ownerPayId5 != null)
                    callPayload.Queries["ownerPayId5"] = ExpressionConverter.Convert(__workflow_ownerPayId5);
                if (__workflow_ownerPayId6 != null)
                    callPayload.Queries["ownerPayId6"] = ExpressionConverter.Convert(__workflow_ownerPayId6);
                if (__workflow_projectId != null)
                    callPayload.Queries["projectId"] = ExpressionConverter.Convert(__workflow_projectId);
                if (__workflow_isBillable != null)
                    callPayload.Queries["isBillable"] = ExpressionConverter.Convert(__workflow_isBillable);
                if (__workflow_dateFilterType != null)
                    callPayload.Queries["dateFilterType"] = ExpressionConverter.Convert(__workflow_dateFilterType);
                if (__workflow_merchantCountries != null)
                    callPayload.Queries["merchantCountries"] = ExpressionConverter.Convert(__workflow_merchantCountries);
                if (__workflow_currencies != null)
                    callPayload.Queries["currencies"] = ExpressionConverter.Convert(__workflow_currencies);
                if (__workflow_fileType != null)
                    callPayload.Queries["fileType"] = ExpressionConverter.Convert(__workflow_fileType);
                if (__workflow_reportIdShort != null)
                    callPayload.Queries["reportIdShort"] = ExpressionConverter.Convert(__workflow_reportIdShort);
                if (__workflow_expenseUseTypes != null)
                    callPayload.Queries["expenseUseTypes"] = ExpressionConverter.Convert(__workflow_expenseUseTypes);
                if (__workflow_supplierId != null)
                    callPayload.Queries["supplierId"] = ExpressionConverter.Convert(__workflow_supplierId);
                if (__workflow_expenseIds != null)
                    callPayload.Queries["expenseIds"] = ExpressionConverter.Convert(__workflow_expenseIds);
                if (__workflow_merchantName != null)
                    callPayload.Queries["merchantName"] = ExpressionConverter.Convert(__workflow_merchantName);
                if (__workflow_vatCode != null)
                    callPayload.Queries["vatCode"] = ExpressionConverter.Convert(__workflow_vatCode);
                if (__workflow_valueHTInExpenseCurrency != null)
                    callPayload.Queries["valueHTInExpenseCurrency"] = ExpressionConverter.Convert(__workflow_valueHTInExpenseCurrency);
                if (__workflow_vatRate != null)
                    callPayload.Queries["vatRate"] = ExpressionConverter.Convert(__workflow_vatRate);
                if (__workflow_vatValue != null)
                    callPayload.Queries["vatValue"] = ExpressionConverter.Convert(__workflow_vatValue);
                if (__workflow_reportsIds != null)
                    callPayload.Queries["reportsIds"] = ExpressionConverter.Convert(__workflow_reportsIds);
                if (__workflow_dateTimeOffset != null)
                    callPayload.Queries["dateTimeOffset"] = ExpressionConverter.Convert(__workflow_dateTimeOffset);
                if (__workflow_tagsNames != null)
                    callPayload.Queries["tagsNames"] = ExpressionConverter.Convert(__workflow_tagsNames);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(__workflow_pageSize);
                if (__workflow_sortBy != null)
                    callPayload.Queries["sortBy"] = ExpressionConverter.Convert(__workflow_sortBy);
                if (__workflow_isDesc != null)
                    callPayload.Queries["isDesc"] = ExpressionConverter.Convert(__workflow_isDesc);
                return new ApiConnectionAction<ListAndPagesCountResultExpenseResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expensya")]
        public IBodyWorkflowAction<BaseResultProjectResponse, ApiConnectionActionConfiguration> GetProjectDetails(Expression<Func<string>> projectId)
        {
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: true);
            return new DeferredBodyAction<BaseResultProjectResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v2/project/{0}/", __workflow_projectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<BaseResultProjectResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expensya")]
        public IBodyWorkflowAction<ListAndPagesCountResultProjectResponse, ApiConnectionActionConfiguration> GetProjects(Expression<Func<string>> projectName = null, Expression<Func<string>> projectIds = null, Expression<Func<string>> validatorName = null, Expression<Func<string>> projectReferenceOrExternalId = null, Expression<Func<bool>> bringAllProjects = null, Expression<Func<int>> projectUseType = null, Expression<Func<bool>> isActive = null, Expression<Func<string>> tagsNames = null, Expression<Func<string>> customFieldsIds = null, Expression<Func<string>> expenseDate = null, Expression<Func<string>> userId = null, Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null, Expression<Func<int>> sortBy = null, Expression<Func<bool>> isDesc = null)
        {
            var __workflow_projectName = WorkflowExpression.Compile(projectName, nameof(projectName), required: false);
            var __workflow_projectIds = WorkflowExpression.Compile(projectIds, nameof(projectIds), required: false);
            var __workflow_validatorName = WorkflowExpression.Compile(validatorName, nameof(validatorName), required: false);
            var __workflow_projectReferenceOrExternalId = WorkflowExpression.Compile(projectReferenceOrExternalId, nameof(projectReferenceOrExternalId), required: false);
            var __workflow_bringAllProjects = WorkflowExpression.Compile(bringAllProjects, nameof(bringAllProjects), required: false);
            var __workflow_projectUseType = WorkflowExpression.Compile(projectUseType, nameof(projectUseType), required: false);
            var __workflow_isActive = WorkflowExpression.Compile(isActive, nameof(isActive), required: false);
            var __workflow_tagsNames = WorkflowExpression.Compile(tagsNames, nameof(tagsNames), required: false);
            var __workflow_customFieldsIds = WorkflowExpression.Compile(customFieldsIds, nameof(customFieldsIds), required: false);
            var __workflow_expenseDate = WorkflowExpression.Compile(expenseDate, nameof(expenseDate), required: false);
            var __workflow_userId = WorkflowExpression.Compile(userId, nameof(userId), required: false);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_pageSize = WorkflowExpression.Compile(pageSize, nameof(pageSize), required: false);
            var __workflow_sortBy = WorkflowExpression.Compile(sortBy, nameof(sortBy), required: false);
            var __workflow_isDesc = WorkflowExpression.Compile(isDesc, nameof(isDesc), required: false);
            return new DeferredBodyAction<ListAndPagesCountResultProjectResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v2/projects/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_projectName != null)
                    callPayload.Queries["projectName"] = ExpressionConverter.Convert(__workflow_projectName);
                if (__workflow_projectIds != null)
                    callPayload.Queries["projectIds"] = ExpressionConverter.Convert(__workflow_projectIds);
                if (__workflow_validatorName != null)
                    callPayload.Queries["validatorName"] = ExpressionConverter.Convert(__workflow_validatorName);
                if (__workflow_projectReferenceOrExternalId != null)
                    callPayload.Queries["projectReferenceOrExternalId"] = ExpressionConverter.Convert(__workflow_projectReferenceOrExternalId);
                if (__workflow_bringAllProjects != null)
                    callPayload.Queries["bringAllProjects"] = ExpressionConverter.Convert(__workflow_bringAllProjects);
                if (__workflow_projectUseType != null)
                    callPayload.Queries["projectUseType"] = ExpressionConverter.Convert(__workflow_projectUseType);
                if (__workflow_isActive != null)
                    callPayload.Queries["isActive"] = ExpressionConverter.Convert(__workflow_isActive);
                if (__workflow_tagsNames != null)
                    callPayload.Queries["tagsNames"] = ExpressionConverter.Convert(__workflow_tagsNames);
                if (__workflow_customFieldsIds != null)
                    callPayload.Queries["customFieldsIds"] = ExpressionConverter.Convert(__workflow_customFieldsIds);
                if (__workflow_expenseDate != null)
                    callPayload.Queries["expenseDate"] = ExpressionConverter.Convert(__workflow_expenseDate);
                if (__workflow_userId != null)
                    callPayload.Queries["userId"] = ExpressionConverter.Convert(__workflow_userId);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(__workflow_pageSize);
                if (__workflow_sortBy != null)
                    callPayload.Queries["sortBy"] = ExpressionConverter.Convert(__workflow_sortBy);
                if (__workflow_isDesc != null)
                    callPayload.Queries["isDesc"] = ExpressionConverter.Convert(__workflow_isDesc);
                return new ApiConnectionAction<ListAndPagesCountResultProjectResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expensya")]
        public IBodyWorkflowAction<BaseResultListEventResponse, ApiConnectionActionConfiguration> GetReportHistory(Expression<Func<string>> reportId)
        {
            var __workflow_reportId = WorkflowExpression.Compile(reportId, nameof(reportId), required: true);
            return new DeferredBodyAction<BaseResultListEventResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v2/report/history/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["reportId"] = ExpressionConverter.Convert(__workflow_reportId);
                return new ApiConnectionAction<BaseResultListEventResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expensya")]
        public IBodyWorkflowAction<BaseResult, ApiConnectionActionConfiguration> InviteUser(Expression<Func<InviteUserV2Input>> userInviteInput = null)
        {
            var __workflow_userInviteInput = WorkflowExpression.Compile(userInviteInput, nameof(userInviteInput), required: false);
            return new DeferredBodyAction<BaseResult, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v2/user/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_userInviteInput != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_userInviteInput);
                return new ApiConnectionAction<BaseResult>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expensya")]
        public IBodyWorkflowAction<LoginResponse, ApiConnectionActionConfiguration> RefreshUserToken()
        {
            return new DeferredBodyAction<LoginResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v2/refreshUserToken/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<LoginResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expensya")]
        public IBodyWorkflowAction<BaseResult, ApiConnectionActionConfiguration> UpateUser(Expression<Func<string>> userId, Expression<Func<bool>> shouldUpdateValidators, Expression<Func<UpateUserV2Input>> userUpdateInput = null)
        {
            var __workflow_userId = WorkflowExpression.Compile(userId, nameof(userId), required: true);
            var __workflow_shouldUpdateValidators = WorkflowExpression.Compile(shouldUpdateValidators, nameof(shouldUpdateValidators), required: true);
            var __workflow_userUpdateInput = WorkflowExpression.Compile(userUpdateInput, nameof(userUpdateInput), required: false);
            return new DeferredBodyAction<BaseResult, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v2/user/{0}/", __workflow_userId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["shouldUpdateValidators"] = ExpressionConverter.Convert(__workflow_shouldUpdateValidators);
                if (__workflow_userUpdateInput != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_userUpdateInput);
                return new ApiConnectionAction<BaseResult>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expensya")]
        public IBodyWorkflowAction<BaseResultListAddOrUpdateEntityResult, ApiConnectionActionConfiguration> UpdateProjectState(Expression<Func<UpdateProjectStateV2Input>> updateProjectStateInput = null)
        {
            var __workflow_updateProjectStateInput = WorkflowExpression.Compile(updateProjectStateInput, nameof(updateProjectStateInput), required: false);
            return new DeferredBodyAction<BaseResultListAddOrUpdateEntityResult, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v2/projects/states/";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_updateProjectStateInput != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_updateProjectStateInput);
                return new ApiConnectionAction<BaseResultListAddOrUpdateEntityResult>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expensya")]
        public IBodyWorkflowAction<BaseResultListUpdateUserResult, ApiConnectionActionConfiguration> UpdateUsersState(Expression<Func<UpdateUserStateInput[]>> updateUserStateInputArray = null)
        {
            var __workflow_updateUserStateInputArray = WorkflowExpression.Compile(updateUserStateInputArray, nameof(updateUserStateInputArray), required: false);
            return new DeferredBodyAction<BaseResultListUpdateUserResult, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v2/users/state/";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_updateUserStateInputArray != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_updateUserStateInputArray);
                return new ApiConnectionAction<BaseResultListUpdateUserResult>(callPayload);
            });
        }
    }

    public class ExpensyaTriggers([ConnectionName] string connectionId)
    {
    }

    public class BaseResultExportResponse
    {
        public ExportResponse ResultItem { get; set; }
        public BaseResultExportResponseResultCodeType ResultCode { get; set; }
        public string Message { get; set; }
    }

    public class ExportResponse
    {
        public string FileUrl { get; set; }
        public string FileExtension { get; set; }
        public string FileName { get; set; }
    }

    public enum BaseResultExportResponseResultCodeType
    {
        _0 = 0,
        _1 = 1,
        _2 = 2,
        _3 = 3,
        _4 = 4,
        _5 = 5,
        _6 = 6,
        _7 = 7,
        _10 = 10,
        _11 = 11,
        _12 = 12,
        _20 = 20,
        _30 = 30,
        _50 = 50,
        _60 = 60,
        _70 = 70,
        _71 = 71,
        _80 = 80,
        _90 = 90,
        _91 = 91,
        _92 = 92,
        _96 = 96,
        _97 = 97,
        _98 = 98,
        _99 = 99,
        _100 = 100,
        _101 = 101,
        _303 = 303,
        _400 = 400,
        _401 = 401,
        _404 = 404,
        _901 = 901,
        _902 = 902,
        _903 = 903,
        _910 = 910,
        _913 = 913,
        _1001 = 1001,
        _1004 = 1004,
        _1005 = 1005,
        _1006 = 1006,
        _2000 = 2000,
        _2001 = 2001,
        _2002 = 2002,
        _2003 = 2003,
        _2004 = 2004,
        _2005 = 2005,
        _2007 = 2007,
        _2008 = 2008
    }

    public class BaseResultListExportFormatResponse
    {
        public ExportFormatResponse[] ResultItem { get; set; }
        public BaseResultListExportFormatResponseResultCodeType ResultCode { get; set; }
        public string Message { get; set; }
    }

    public class ExportFormatResponse
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Extension { get; set; }
        public string CodePath { get; set; }
        public bool MissionExport { get; set; }
        public bool InvoicesExport { get; set; }
        public bool AutoExport { get; set; }
        public string LastAutoExportDate { get; set; }
    }

    public enum BaseResultListExportFormatResponseResultCodeType
    {
        _0 = 0,
        _1 = 1,
        _2 = 2,
        _3 = 3,
        _4 = 4,
        _5 = 5,
        _6 = 6,
        _7 = 7,
        _10 = 10,
        _11 = 11,
        _12 = 12,
        _20 = 20,
        _30 = 30,
        _50 = 50,
        _60 = 60,
        _70 = 70,
        _71 = 71,
        _80 = 80,
        _90 = 90,
        _91 = 91,
        _92 = 92,
        _96 = 96,
        _97 = 97,
        _98 = 98,
        _99 = 99,
        _100 = 100,
        _101 = 101,
        _303 = 303,
        _400 = 400,
        _401 = 401,
        _404 = 404,
        _901 = 901,
        _902 = 902,
        _903 = 903,
        _910 = 910,
        _913 = 913,
        _1001 = 1001,
        _1004 = 1004,
        _1005 = 1005,
        _1006 = 1006,
        _2000 = 2000,
        _2001 = 2001,
        _2002 = 2002,
        _2003 = 2003,
        _2004 = 2004,
        _2005 = 2005,
        _2007 = 2007,
        _2008 = 2008
    }

    public class BaseResultListAddOrUpdateEntityResult
    {
        public AddOrUpdateEntityResult[] ResultItem { get; set; }
        public BaseResultListAddOrUpdateEntityResultResultCodeType ResultCode { get; set; }
        public string Message { get; set; }
    }

    public class AddOrUpdateEntityResult
    {
        public string Id { get; set; }
        public string ExternalId { get; set; }
        public AddOrUpdateEntityResultResultCodeType ResultCode { get; set; }
        public string Message { get; set; }
    }

    public enum AddOrUpdateEntityResultResultCodeType
    {
        _0 = 0,
        _1 = 1,
        _2 = 2,
        _3 = 3,
        _4 = 4,
        _5 = 5,
        _6 = 6,
        _7 = 7,
        _10 = 10,
        _11 = 11,
        _12 = 12,
        _20 = 20,
        _30 = 30,
        _50 = 50,
        _60 = 60,
        _70 = 70,
        _71 = 71,
        _80 = 80,
        _90 = 90,
        _91 = 91,
        _92 = 92,
        _96 = 96,
        _97 = 97,
        _98 = 98,
        _99 = 99,
        _100 = 100,
        _101 = 101,
        _303 = 303,
        _400 = 400,
        _401 = 401,
        _404 = 404,
        _901 = 901,
        _902 = 902,
        _903 = 903,
        _910 = 910,
        _913 = 913,
        _1001 = 1001,
        _1004 = 1004,
        _1005 = 1005,
        _1006 = 1006,
        _2000 = 2000,
        _2001 = 2001,
        _2002 = 2002,
        _2003 = 2003,
        _2004 = 2004,
        _2005 = 2005,
        _2007 = 2007,
        _2008 = 2008
    }

    public enum BaseResultListAddOrUpdateEntityResultResultCodeType
    {
        _0 = 0,
        _1 = 1,
        _2 = 2,
        _3 = 3,
        _4 = 4,
        _5 = 5,
        _6 = 6,
        _7 = 7,
        _10 = 10,
        _11 = 11,
        _12 = 12,
        _20 = 20,
        _30 = 30,
        _50 = 50,
        _60 = 60,
        _70 = 70,
        _71 = 71,
        _80 = 80,
        _90 = 90,
        _91 = 91,
        _92 = 92,
        _96 = 96,
        _97 = 97,
        _98 = 98,
        _99 = 99,
        _100 = 100,
        _101 = 101,
        _303 = 303,
        _400 = 400,
        _401 = 401,
        _404 = 404,
        _901 = 901,
        _902 = 902,
        _903 = 903,
        _910 = 910,
        _913 = 913,
        _1001 = 1001,
        _1004 = 1004,
        _1005 = 1005,
        _1006 = 1006,
        _2000 = 2000,
        _2001 = 2001,
        _2002 = 2002,
        _2003 = 2003,
        _2004 = 2004,
        _2005 = 2005,
        _2007 = 2007,
        _2008 = 2008
    }

    public class AddOrUpdateProjectInput
    {
        public bool HasBillable { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public bool IsActive { get; set; }
        public string MileageConfigurations { get; set; }
        public string Address { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
        public string ExternalId { get; set; }
        public string Name { get; set; }
        public string ProjectRef { get; set; }

        [JsonProperty("Validator_Id")]
        public string ValidatorId { get; set; }

        [JsonProperty("Reviewer_Id")]
        public string ReviewerId { get; set; }
        public string ClientName { get; set; }
        public bool ForAllCompany { get; set; }
        public bool IsBillableDefaultValue { get; set; }
        public string PayId2 { get; set; }
        public string Currency { get; set; }
        public string ExtraData { get; set; }
        public AddOrUpdateProjectInputProjectUseTypeType ProjectUseType { get; set; }
        public string Description { get; set; }
        public string CategoriesIds { get; set; }
        public string[] TagsToAssign { get; set; }
        public string[] TagsToUnassign { get; set; }
    }

    public enum AddOrUpdateProjectInputProjectUseTypeType
    {
        _1 = 1,
        _2 = 2,
        _4 = 4,
        _8 = 8,
        _16 = 16,
        _32 = 32,
        _64 = 64,
        _128 = 128
    }

    public class BaseResult
    {
        public BaseResultResultCodeType ResultCode { get; set; }
        public string Message { get; set; }
    }

    public enum BaseResultResultCodeType
    {
        _0 = 0,
        _1 = 1,
        _2 = 2,
        _3 = 3,
        _4 = 4,
        _5 = 5,
        _6 = 6,
        _7 = 7,
        _10 = 10,
        _11 = 11,
        _12 = 12,
        _20 = 20,
        _30 = 30,
        _50 = 50,
        _60 = 60,
        _70 = 70,
        _71 = 71,
        _80 = 80,
        _90 = 90,
        _91 = 91,
        _92 = 92,
        _96 = 96,
        _97 = 97,
        _98 = 98,
        _99 = 99,
        _100 = 100,
        _101 = 101,
        _303 = 303,
        _400 = 400,
        _401 = 401,
        _404 = 404,
        _901 = 901,
        _902 = 902,
        _903 = 903,
        _910 = 910,
        _913 = 913,
        _1001 = 1001,
        _1004 = 1004,
        _1005 = 1005,
        _1006 = 1006,
        _2000 = 2000,
        _2001 = 2001,
        _2002 = 2002,
        _2003 = 2003,
        _2004 = 2004,
        _2005 = 2005,
        _2007 = 2007,
        _2008 = 2008
    }

    public class AddRecieptInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string UserId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string ReceiptContent { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string ReceiptName { get; set; }
    }

    public class ListAndPagesCountResultReportResponse
    {
        public ReportResponse[] List { get; set; }
        public int PagesCount { get; set; }
        public int TotalListCount { get; set; }
        public ListAndPagesCountResultReportResponseResultCodeType ResultCode { get; set; }
        public string Message { get; set; }
    }

    public class ReportResponse
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string DateCreation { get; set; }
        public double Budget { get; set; }
        public ReportResponseStateType State { get; set; }

        [JsonProperty("User_Id")]
        public string UserId { get; set; }
        public string UserLastName { get; set; }
        public string UserFirstName { get; set; }
        public string UserMail { get; set; }

        [JsonProperty("Manager_Id")]
        public string ManagerId { get; set; }

        [JsonProperty("Accountant_Id")]
        public string AccountantId { get; set; }

        [JsonProperty("Reviewer_Id")]
        public string ReviewerId { get; set; }
        public int InvoicesCount { get; set; }
        public double Value { get; set; }
        public double ValueToReimburse { get; set; }
        public double ValueInLocalCurrency { get; set; }
        public double ValueToReimburseInLocalCurrency { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string UserCurrency { get; set; }
        public string UserLocalCurrency { get; set; }
        public string IdShort { get; set; }

        [JsonProperty("CurrentValidator_Id")]
        public string CurrentValidatorId { get; set; }
        public int InvoiceAttachedFilesCount { get; set; }
        public TagResponse[] ReportTags { get; set; }
    }

    public enum ReportResponseStateType
    {
        _0 = 0,
        _2 = 2,
        _3 = 3,
        _4 = 4,
        _5 = 5,
        _6 = 6,
        _7 = 7,
        _8 = 8,
        _50 = 50
    }

    public class TagResponse
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string CreationDate { get; set; }
        public bool IsActive { get; set; }
        public TagResponseTagTypeType TagType { get; set; }
        public string DefinitionStr { get; set; }
        public TagResponseUseTypeType UseType { get; set; }
    }

    public enum TagResponseTagTypeType
    {
        _1 = 1,
        _2 = 2
    }

    public enum TagResponseUseTypeType
    {
        _2 = 2,
        _4 = 4,
        _8 = 8,
        _16 = 16,
        _32 = 32,
        _64 = 64,
        _128 = 128
    }

    public enum ListAndPagesCountResultReportResponseResultCodeType
    {
        _0 = 0,
        _1 = 1,
        _2 = 2,
        _3 = 3,
        _4 = 4,
        _5 = 5,
        _6 = 6,
        _7 = 7,
        _10 = 10,
        _11 = 11,
        _12 = 12,
        _20 = 20,
        _30 = 30,
        _50 = 50,
        _60 = 60,
        _70 = 70,
        _71 = 71,
        _80 = 80,
        _90 = 90,
        _91 = 91,
        _92 = 92,
        _96 = 96,
        _97 = 97,
        _98 = 98,
        _99 = 99,
        _100 = 100,
        _101 = 101,
        _303 = 303,
        _400 = 400,
        _401 = 401,
        _404 = 404,
        _901 = 901,
        _902 = 902,
        _903 = 903,
        _910 = 910,
        _913 = 913,
        _1001 = 1001,
        _1004 = 1004,
        _1005 = 1005,
        _1006 = 1006,
        _2000 = 2000,
        _2001 = 2001,
        _2002 = 2002,
        _2003 = 2003,
        _2004 = 2004,
        _2005 = 2005,
        _2007 = 2007,
        _2008 = 2008
    }

    public class UpdateReportStatusInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public UpdateReportStatusInputOperationType Operation { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Message { get; set; }
        public string[] InvoiceIdsToReject { get; set; }
        public string AccountingPeriod { get; set; }
    }

    public enum UpdateReportStatusInputOperationType
    {
        _0 = 0,
        _2 = 2,
        _3 = 3,
        _4 = 4,
        _5 = 5,
        _6 = 6,
        _7 = 7,
        _8 = 8,
        _9 = 9,
        _10 = 10,
        _11 = 11
    }

    public class ListAndPagesCountResultUserResponse
    {
        public UserResponse[] List { get; set; }
        public int PagesCount { get; set; }
        public int TotalListCount { get; set; }
        public ListAndPagesCountResultUserResponseResultCodeType ResultCode { get; set; }
        public string Message { get; set; }
    }

    public class UserResponse
    {
        public string Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Mail { get; set; }
        public string MailAlias { get; set; }
        public string ZipCode { get; set; }
        public string FaxNumber { get; set; }
        public string CreationDate { get; set; }
        public string CountryCode { get; set; }
        public string Language { get; set; }
        public string Currency { get; set; }
        public string LocalCurrency { get; set; }
        public string LocalCountry { get; set; }
        public bool CanCreateCategories { get; set; }

        [JsonProperty("Manager_Id")]
        public string ManagerId { get; set; }
        public string AccountantMail { get; set; }
        public string AccountantPayId { get; set; }
        public UserResponseUserTypeType UserType { get; set; }
        public UserResponseUserStateType UserState { get; set; }
        public string PayId { get; set; }
        public string PayId2 { get; set; }
        public string PayId3 { get; set; }
        public string PayId4 { get; set; }
        public string PayId5 { get; set; }
        public string PayId6 { get; set; }
        public string ManagerFirstName { get; set; }
        public string ManagerLastName { get; set; }
        public string ManagerMail { get; set; }
        public string ManagerPayId { get; set; }
        public UserResponseManagerUserStateType ManagerUserState { get; set; }

        [JsonProperty("Reviewer_Id")]
        public string ReviewerId { get; set; }
        public string ReviewerFirstName { get; set; }
        public string ReviewerLastName { get; set; }
        public string ReviewerMail { get; set; }
        public string ReviewerPayId { get; set; }
        public UserResponseReviewerUserStateType ReviewerUserState { get; set; }
        public string JobTitle { get; set; }
        public string Vendor { get; set; }
        public string MileageConfigurationsStr { get; set; }
        public string PerDiemConfigName { get; set; }
        public UserResponseUserRoleType UserRole { get; set; }
        public string ConfigurationSettingsStr { get; set; }
        public string ConfigurationSettingsReference { get; set; }
        public string LastLoginDate { get; set; }
        public string LastSignInDate { get; set; }
        public ValidatorResponse[] Validators { get; set; }
        public TagResponse[] UserSimpleTags { get; set; }
        public TagResponse[] UserTags { get; set; }
        public TagResponse[] RestrictedTags { get; set; }
    }

    public enum UserResponseUserTypeType
    {
        _0 = 0,
        _1 = 1,
        _2 = 2,
        _4 = 4,
        _8 = 8,
        _16 = 16,
        _32 = 32,
        _56 = 56
    }

    public enum UserResponseUserStateType
    {
        _0 = 0,
        _1 = 1,
        _2 = 2
    }

    public enum UserResponseManagerUserStateType
    {
        _0 = 0,
        _1 = 1,
        _2 = 2
    }

    public enum UserResponseReviewerUserStateType
    {
        _0 = 0,
        _1 = 1,
        _2 = 2
    }

    public enum UserResponseUserRoleType
    {
        _0 = 0,
        _2 = 2,
        _4 = 4,
        _8 = 8,
        _16 = 16,
        _32 = 32,
        _64 = 64,
        _128 = 128,
        _256 = 256,
        _512 = 512,
        _1024 = 1024,
        _2048 = 2048,
        _4096 = 4096,
        _8192 = 8192,
        _16384 = 16384,
        _32768 = 32768,
        _65536 = 65536,
        _131072 = 131072,
        _262144 = 262144,
        _524288 = 524288,
        _1048576 = 1048576,
        _2097152 = 2097152,
        _4194304 = 4194304,
        _8388608 = 8388608,
        _16777216 = 16777216,
        _33554432 = 33554432,
        _67108864 = 67108864
    }

    public class ValidatorResponse
    {
        public string Mail { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double MinimumAmount { get; set; }
    }

    public enum ListAndPagesCountResultUserResponseResultCodeType
    {
        _0 = 0,
        _1 = 1,
        _2 = 2,
        _3 = 3,
        _4 = 4,
        _5 = 5,
        _6 = 6,
        _7 = 7,
        _10 = 10,
        _11 = 11,
        _12 = 12,
        _20 = 20,
        _30 = 30,
        _50 = 50,
        _60 = 60,
        _70 = 70,
        _71 = 71,
        _80 = 80,
        _90 = 90,
        _91 = 91,
        _92 = 92,
        _96 = 96,
        _97 = 97,
        _98 = 98,
        _99 = 99,
        _100 = 100,
        _101 = 101,
        _303 = 303,
        _400 = 400,
        _401 = 401,
        _404 = 404,
        _901 = 901,
        _902 = 902,
        _903 = 903,
        _910 = 910,
        _913 = 913,
        _1001 = 1001,
        _1004 = 1004,
        _1005 = 1005,
        _1006 = 1006,
        _2000 = 2000,
        _2001 = 2001,
        _2002 = 2002,
        _2003 = 2003,
        _2004 = 2004,
        _2005 = 2005,
        _2007 = 2007,
        _2008 = 2008
    }

    public class AddQuickExpenseV2Input
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string FileToSend { get; set; }
        public string Title { get; set; }
        public double? TransactionAmount { get; set; }
        public string VatRates { get; set; }
        public string VatAmounts { get; set; }
        public string CurrencyCode { get; set; }
        public string TransactionDate { get; set; }
        public string MerchantName { get; set; }
        public string LocationCountry { get; set; }
        public string LocationCity { get; set; }
        public string Comment { get; set; }
        public string MerchantExpenseId { get; set; }
        public bool? IsEncrypted { get; set; }
        public AddQuickExpenseV2InputExpenseUseTypeType? ExpenseUseType { get; set; }
        public string PaymentTypeCode { get; set; }
        public string ExpenseTypeCode { get; set; }
        public string FileType { get; set; }
    }

    public enum AddQuickExpenseV2InputExpenseUseTypeType
    {
        _1 = 1,
        _2 = 2,
        _4 = 4,
        _8 = 8,
        _16 = 16
    }

    public class ListAndPagesCountResultCategoryResponse
    {
        public CategoryResponse[] List { get; set; }
        public int PagesCount { get; set; }
        public int TotalListCount { get; set; }
        public ListAndPagesCountResultCategoryResponseResultCodeType ResultCode { get; set; }
        public string Message { get; set; }
    }

    public class CategoryResponse
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string EntityName { get; set; }
        public string Parent { get; set; }
        public string Description { get; set; }
        public string PrimitiveCategories { get; set; }

        [JsonProperty("ParentCategory_Id")]
        public string ParentCategoryId { get; set; }
        public bool IsActive { get; set; }
        public bool IsActiveAsDefault { get; set; }
        public string CostAccount { get; set; }
        public string VatAccount { get; set; }
        public string ExtraData { get; set; }
        public string CreationDate { get; set; }
        public double VatClaimRate { get; set; }
        public string VatClaimRates { get; set; }
        public CategoryResponseCategoryUseTypeType CategoryUseType { get; set; }
        public string ExternalId { get; set; }
        public bool IsReadOnly { get; set; }
        public TagResponse[] CategoryTags { get; set; }
    }

    public enum CategoryResponseCategoryUseTypeType
    {
        _1 = 1,
        _2 = 2,
        _4 = 4
    }

    public enum ListAndPagesCountResultCategoryResponseResultCodeType
    {
        _0 = 0,
        _1 = 1,
        _2 = 2,
        _3 = 3,
        _4 = 4,
        _5 = 5,
        _6 = 6,
        _7 = 7,
        _10 = 10,
        _11 = 11,
        _12 = 12,
        _20 = 20,
        _30 = 30,
        _50 = 50,
        _60 = 60,
        _70 = 70,
        _71 = 71,
        _80 = 80,
        _90 = 90,
        _91 = 91,
        _92 = 92,
        _96 = 96,
        _97 = 97,
        _98 = 98,
        _99 = 99,
        _100 = 100,
        _101 = 101,
        _303 = 303,
        _400 = 400,
        _401 = 401,
        _404 = 404,
        _901 = 901,
        _902 = 902,
        _903 = 903,
        _910 = 910,
        _913 = 913,
        _1001 = 1001,
        _1004 = 1004,
        _1005 = 1005,
        _1006 = 1006,
        _2000 = 2000,
        _2001 = 2001,
        _2002 = 2002,
        _2003 = 2003,
        _2004 = 2004,
        _2005 = 2005,
        _2007 = 2007,
        _2008 = 2008
    }

    public class ListAndPagesCountResultExpenseResponse
    {
        public ExpenseResponse[] List { get; set; }
        public int PagesCount { get; set; }
        public int TotalListCount { get; set; }
        public ListAndPagesCountResultExpenseResponseResultCodeType ResultCode { get; set; }
        public string Message { get; set; }
    }

    public class ExpenseResponse
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public double Value { get; set; }
        public double ValueToReimburse { get; set; }
        public double ReimbursementRate { get; set; }
        public string Description { get; set; }
        public ExpenseResponseUseTypeType UseType { get; set; }
        public string DateCreation { get; set; }
        public string DateInvoice { get; set; }
        public double DateUtcOffset { get; set; }
        public bool HasPhoto { get; set; }
        public string Currency { get; set; }
        public double ValueInCurrency { get; set; }
        public double ValueInLocalCurrency { get; set; }
        public string MerchantInvoiceId { get; set; }
        public string MerchantCountry { get; set; }
        public string MerchantCity { get; set; }
        public string MerchantZipCode { get; set; }
        public string MerchantAddress { get; set; }
        public string MerchantName { get; set; }
        public string MerchantVatNumber { get; set; }
        public double Units { get; set; }
        public ExpenseResponseStateType State { get; set; }
        public VATResponse VAT { get; set; }
        public double VATAvgRate { get; set; }
        public int AttachedFilesCount { get; set; }
        public bool ToReimburse { get; set; }
        public bool IsBillable { get; set; }
        public JToken CustomFields { get; set; }
        public string FileType { get; set; }
        public double DefaultRate { get; set; }

        [JsonProperty("CreditSource_Id")]
        public string CreditSourceId { get; set; }

        [JsonProperty("User_Id")]
        public string UserId { get; set; }
        public ProjectResponse Project { get; set; }
        public ReportResponse Report { get; set; }
        public PaymentInstrumentResponse PaymentInstrument { get; set; }
        public VehicleResponse Vehicle { get; set; }
        public double TransactionsSumValue { get; set; }
        public double TransactionsSumInCurrency { get; set; }
        public double TransactionsSumInLocalCurrency { get; set; }
        public string PerdiemCountry { get; set; }
        public ExpenseResponsePerdiemCalculationPeriodTypeType PerdiemCalculationPeriodType { get; set; }
        public ExpenseResponsePerDiemTypeType PerDiemType { get; set; }
        public CategoryResponse Category { get; set; }
        public BrokenRuleResponse[] BrokenRules { get; set; }
        public bool IsMileage { get; set; }
        public string CategoryExtraDataStr { get; set; }
        public GuestResponse[] Guests { get; set; }
        public ExpenseResponseSubStatusType SubStatus { get; set; }
        public string OwnerPayId { get; set; }
        public string OwnerPayId2 { get; set; }
        public string OwnerPayId3 { get; set; }
        public string OwnerPayId4 { get; set; }
        public string OwnerPayId5 { get; set; }
        public string OwnerPayId6 { get; set; }
        public TagResponse[] ExpenseTags { get; set; }
    }

    public enum ExpenseResponseUseTypeType
    {
        _1 = 1,
        _2 = 2,
        _4 = 4,
        _8 = 8,
        _16 = 16
    }

    public enum ExpenseResponseStateType
    {
        _0 = 0,
        _1 = 1,
        _2 = 2,
        _3 = 3,
        _4 = 4,
        _99 = 99
    }

    public class VATResponse
    {
        public double[] Rates { get; set; }
        public double[] Values { get; set; }
        public double VatFreeAmount { get; set; }
        public double Tips { get; set; }
    }

    public class ProjectResponse
    {
        public string Id { get; set; }
        public bool HasBillable { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public bool IsActive { get; set; }
        public string MileageConfigurationsStr { get; set; }
        public string Address { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
        public string ExternalId { get; set; }
        public string Name { get; set; }
        public string ProjectRef { get; set; }

        [JsonProperty("Validator_Id")]
        public string ValidatorId { get; set; }

        [JsonProperty("Reviewer_Id")]
        public string ReviewerId { get; set; }
        public string ClientName { get; set; }
        public bool ForAllCompany { get; set; }
        public bool IsBillableDefaultValue { get; set; }
        public string PayId2 { get; set; }
        public string Currency { get; set; }
        public string ExtraData { get; set; }
        public ProjectResponseProjectUseTypeType ProjectUseType { get; set; }

        [JsonProperty("CustomField_Id")]
        public string CustomFieldId { get; set; }

        [JsonProperty("CustomFieldParent_Id")]
        public string CustomFieldParentId { get; set; }
        public string CategoriesIdsStr { get; set; }
        public string ValidatorFullName { get; set; }
        public string ValidatorMail { get; set; }
        public string ReviewerFullName { get; set; }
        public string ReviewerMail { get; set; }
        public bool IsReadOnly { get; set; }
        public TagResponse[] ProjectTags { get; set; }
    }

    public enum ProjectResponseProjectUseTypeType
    {
        _1 = 1,
        _2 = 2,
        _4 = 4,
        _8 = 8,
        _16 = 16,
        _32 = 32,
        _64 = 64,
        _128 = 128
    }

    public class PaymentInstrumentResponse
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public PaymentInstrumentResponseInstrumentTypeType InstrumentType { get; set; }
        public PaymentInstrumentResponseAccountTypeType AccountType { get; set; }
        public string LastDigits { get; set; }
        public string CardKey { get; set; }
        public string JournalCode { get; set; }
        public string Auxiliary { get; set; }
        public string AccountNumber { get; set; }
    }

    public enum PaymentInstrumentResponseInstrumentTypeType
    {
        _0 = 0,
        _1 = 1,
        _2 = 2,
        _3 = 3,
        _4 = 4,
        _5 = 5,
        _6 = 6,
        _99 = 99
    }

    public enum PaymentInstrumentResponseAccountTypeType
    {
        _0 = 0,
        _1 = 1,
        _2 = 2
    }

    public class VehicleResponse
    {
        public string Name { get; set; }
        public string DateCreation { get; set; }
        public double CreationYearKm { get; set; }
        public double CreationYearMiles { get; set; }
        public double LastYearDistanceKm { get; set; }
        public int LastUpdatedYear { get; set; }
        public VehicleResponseVehicleTypeType VehicleType { get; set; }
        public VehicleResponseInternalVehicleTypeType InternalVehicleType { get; set; }

        [JsonProperty("CurrentValidator_Id")]
        public string CurrentValidatorId { get; set; }
        public string LastValidatorReminderDate { get; set; }
        public string Comments { get; set; }
        public VehicleResponseStateType State { get; set; }
        public string ExternalId { get; set; }
        public int AdministrativePower { get; set; }
        public bool IsActive { get; set; }
        public int AttachedFilesCount { get; set; }
        public VehicleResponseCreationTypeType CreationType { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
    }

    public enum VehicleResponseVehicleTypeType
    {
        _1 = 1,
        _2 = 2,
        _3 = 3,
        _4 = 4,
        _5 = 5
    }

    public enum VehicleResponseInternalVehicleTypeType
    {
        _0 = 0,
        _1 = 1,
        _2 = 2
    }

    public enum VehicleResponseStateType
    {
        _0 = 0,
        _1 = 1,
        _2 = 2,
        _3 = 3,
        _4 = 4,
        Negative1 = -1
    }

    public enum VehicleResponseCreationTypeType
    {
        _0 = 0,
        _1 = 1
    }

    public enum ExpenseResponsePerdiemCalculationPeriodTypeType
    {
        _0 = 0,
        _1 = 1
    }

    public enum ExpenseResponsePerDiemTypeType
    {
        _0 = 0,
        _1 = 1,
        _2 = 2
    }

    public class BrokenRuleResponse
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string DescriptionForCredit { get; set; }
        public double Budget { get; set; }
        public BrokenRuleResponseRuleTypeType RuleType { get; set; }
        public string Currency { get; set; }
        public bool AllowExceptions { get; set; }
        public BrokenRuleResponseRuleElementTypeType RuleElementType { get; set; }
        public BrokenRuleResponseIntervalTypeType IntervalType { get; set; }
        public string Language { get; set; }
        public TupleStringDecimal RuleCurrenciesWithBudget { get; set; }
        public bool ForAllCompany { get; set; }
    }

    public enum BrokenRuleResponseRuleTypeType
    {
        _0 = 0,
        _1 = 1,
        _2 = 2,
        _3 = 3
    }

    public enum BrokenRuleResponseRuleElementTypeType
    {
        _0 = 0,
        _1 = 1
    }

    public enum BrokenRuleResponseIntervalTypeType
    {
        _0 = 0,
        _1 = 1,
        _2 = 2,
        _3 = 3,
        _4 = 4
    }

    public class TupleStringDecimal
    {
        public string Item1 { get; set; }
        public double Item2 { get; set; }
    }

    public class GuestResponse
    {
        public string Mail { get; set; }
        public string FullName { get; set; }
        public string Id { get; set; }
        public bool IsCoworker { get; set; }
    }

    public enum ExpenseResponseSubStatusType
    {
        _0 = 0,
        _2 = 2,
        _4 = 4,
        _8 = 8,
        _16 = 16,
        _32 = 32,
        _64 = 64,
        _128 = 128,
        _256 = 256,
        _512 = 512,
        _1024 = 1024
    }

    public enum ListAndPagesCountResultExpenseResponseResultCodeType
    {
        _0 = 0,
        _1 = 1,
        _2 = 2,
        _3 = 3,
        _4 = 4,
        _5 = 5,
        _6 = 6,
        _7 = 7,
        _10 = 10,
        _11 = 11,
        _12 = 12,
        _20 = 20,
        _30 = 30,
        _50 = 50,
        _60 = 60,
        _70 = 70,
        _71 = 71,
        _80 = 80,
        _90 = 90,
        _91 = 91,
        _92 = 92,
        _96 = 96,
        _97 = 97,
        _98 = 98,
        _99 = 99,
        _100 = 100,
        _101 = 101,
        _303 = 303,
        _400 = 400,
        _401 = 401,
        _404 = 404,
        _901 = 901,
        _902 = 902,
        _903 = 903,
        _910 = 910,
        _913 = 913,
        _1001 = 1001,
        _1004 = 1004,
        _1005 = 1005,
        _1006 = 1006,
        _2000 = 2000,
        _2001 = 2001,
        _2002 = 2002,
        _2003 = 2003,
        _2004 = 2004,
        _2005 = 2005,
        _2007 = 2007,
        _2008 = 2008
    }

    public class BaseResultProjectResponse
    {
        public ProjectResponse ResultItem { get; set; }
        public BaseResultProjectResponseResultCodeType ResultCode { get; set; }
        public string Message { get; set; }
    }

    public enum BaseResultProjectResponseResultCodeType
    {
        _0 = 0,
        _1 = 1,
        _2 = 2,
        _3 = 3,
        _4 = 4,
        _5 = 5,
        _6 = 6,
        _7 = 7,
        _10 = 10,
        _11 = 11,
        _12 = 12,
        _20 = 20,
        _30 = 30,
        _50 = 50,
        _60 = 60,
        _70 = 70,
        _71 = 71,
        _80 = 80,
        _90 = 90,
        _91 = 91,
        _92 = 92,
        _96 = 96,
        _97 = 97,
        _98 = 98,
        _99 = 99,
        _100 = 100,
        _101 = 101,
        _303 = 303,
        _400 = 400,
        _401 = 401,
        _404 = 404,
        _901 = 901,
        _902 = 902,
        _903 = 903,
        _910 = 910,
        _913 = 913,
        _1001 = 1001,
        _1004 = 1004,
        _1005 = 1005,
        _1006 = 1006,
        _2000 = 2000,
        _2001 = 2001,
        _2002 = 2002,
        _2003 = 2003,
        _2004 = 2004,
        _2005 = 2005,
        _2007 = 2007,
        _2008 = 2008
    }

    public class ListAndPagesCountResultProjectResponse
    {
        public ProjectResponse[] List { get; set; }
        public int PagesCount { get; set; }
        public int TotalListCount { get; set; }
        public ListAndPagesCountResultProjectResponseResultCodeType ResultCode { get; set; }
        public string Message { get; set; }
    }

    public enum ListAndPagesCountResultProjectResponseResultCodeType
    {
        _0 = 0,
        _1 = 1,
        _2 = 2,
        _3 = 3,
        _4 = 4,
        _5 = 5,
        _6 = 6,
        _7 = 7,
        _10 = 10,
        _11 = 11,
        _12 = 12,
        _20 = 20,
        _30 = 30,
        _50 = 50,
        _60 = 60,
        _70 = 70,
        _71 = 71,
        _80 = 80,
        _90 = 90,
        _91 = 91,
        _92 = 92,
        _96 = 96,
        _97 = 97,
        _98 = 98,
        _99 = 99,
        _100 = 100,
        _101 = 101,
        _303 = 303,
        _400 = 400,
        _401 = 401,
        _404 = 404,
        _901 = 901,
        _902 = 902,
        _903 = 903,
        _910 = 910,
        _913 = 913,
        _1001 = 1001,
        _1004 = 1004,
        _1005 = 1005,
        _1006 = 1006,
        _2000 = 2000,
        _2001 = 2001,
        _2002 = 2002,
        _2003 = 2003,
        _2004 = 2004,
        _2005 = 2005,
        _2007 = 2007,
        _2008 = 2008
    }

    public class BaseResultListEventResponse
    {
        public EventResponse[] ResultItem { get; set; }
        public BaseResultListEventResponseResultCodeType ResultCode { get; set; }
        public string Message { get; set; }
    }

    public class EventResponse
    {
        public string EventDate { get; set; }
        public EventResponseEventTypeType EventType { get; set; }
        public string UserId { get; set; }
        public string UserLastName { get; set; }
        public string UserFirstName { get; set; }
        public string UserMail { get; set; }
        public string Description { get; set; }
    }

    public enum EventResponseEventTypeType
    {
        _1 = 1,
        _2 = 2,
        _3 = 3,
        _4 = 4,
        _5 = 5,
        _6 = 6,
        _7 = 7,
        _8 = 8,
        _9 = 9,
        _10 = 10,
        _11 = 11,
        _12 = 12,
        _13 = 13,
        _14 = 14,
        _15 = 15,
        _16 = 16,
        _17 = 17,
        _18 = 18,
        _19 = 19,
        _20 = 20,
        _21 = 21,
        _22 = 22,
        _23 = 23,
        _24 = 24,
        _25 = 25,
        _26 = 26,
        _27 = 27,
        _28 = 28,
        _29 = 29,
        _30 = 30,
        _31 = 31,
        _32 = 32,
        _33 = 33,
        _34 = 34,
        _35 = 35,
        _36 = 36,
        _37 = 37,
        _38 = 38,
        _39 = 39,
        _41 = 41,
        _42 = 42,
        _43 = 43,
        _97 = 97,
        _98 = 98,
        _99 = 99,
        _100 = 100,
        _101 = 101,
        _102 = 102,
        _103 = 103,
        _104 = 104,
        _105 = 105,
        _106 = 106,
        _107 = 107,
        _108 = 108,
        _109 = 109,
        _110 = 110,
        _111 = 111,
        _112 = 112,
        _113 = 113,
        _114 = 114,
        _115 = 115,
        _116 = 116,
        _117 = 117,
        _118 = 118,
        _119 = 119,
        _120 = 120,
        _121 = 121,
        _122 = 122,
        _123 = 123,
        _124 = 124,
        _125 = 125,
        _126 = 126,
        _127 = 127,
        _128 = 128,
        _129 = 129
    }

    public enum BaseResultListEventResponseResultCodeType
    {
        _0 = 0,
        _1 = 1,
        _2 = 2,
        _3 = 3,
        _4 = 4,
        _5 = 5,
        _6 = 6,
        _7 = 7,
        _10 = 10,
        _11 = 11,
        _12 = 12,
        _20 = 20,
        _30 = 30,
        _50 = 50,
        _60 = 60,
        _70 = 70,
        _71 = 71,
        _80 = 80,
        _90 = 90,
        _91 = 91,
        _92 = 92,
        _96 = 96,
        _97 = 97,
        _98 = 98,
        _99 = 99,
        _100 = 100,
        _101 = 101,
        _303 = 303,
        _400 = 400,
        _401 = 401,
        _404 = 404,
        _901 = 901,
        _902 = 902,
        _903 = 903,
        _910 = 910,
        _913 = 913,
        _1001 = 1001,
        _1004 = 1004,
        _1005 = 1005,
        _1006 = 1006,
        _2000 = 2000,
        _2001 = 2001,
        _2002 = 2002,
        _2003 = 2003,
        _2004 = 2004,
        _2005 = 2005,
        _2007 = 2007,
        _2008 = 2008
    }

    public class InviteUserV2Input
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string LastName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string FirstName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Mail { get; set; }
        public string MailAlias { get; set; }
        public string PayId { get; set; }
        public string PayId2 { get; set; }
        public string PayId3 { get; set; }
        public string PayId4 { get; set; }
        public string PayId5 { get; set; }
        public string PayId6 { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Language { get; set; }
        public string LocalCurrency { get; set; }
        public string LocalCountry { get; set; }
        public string ManagerId { get; set; }
        public string ReviewerId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public InviteUserV2InputUserTypeType UserType { get; set; }
        public string Vendor { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public InviteUserV2InputUserRoleType UserRole { get; set; }
        public string DefaultProjectId { get; set; }
        public string IKRatesId { get; set; }
        public ValidatorInput[] AdditionalValidators { get; set; }
        public string[] TagsToAssign { get; set; }
    }

    public enum InviteUserV2InputUserTypeType
    {
        _0 = 0,
        _1 = 1,
        _2 = 2,
        _4 = 4,
        _8 = 8,
        _16 = 16,
        _32 = 32,
        _56 = 56
    }

    public enum InviteUserV2InputUserRoleType
    {
        _0 = 0,
        _2 = 2,
        _4 = 4,
        _8 = 8,
        _16 = 16,
        _32 = 32,
        _64 = 64,
        _128 = 128,
        _256 = 256,
        _512 = 512,
        _1024 = 1024,
        _2048 = 2048,
        _4096 = 4096,
        _8192 = 8192,
        _16384 = 16384,
        _32768 = 32768,
        _65536 = 65536,
        _131072 = 131072,
        _262144 = 262144,
        _524288 = 524288,
        _1048576 = 1048576,
        _2097152 = 2097152,
        _4194304 = 4194304,
        _8388608 = 8388608,
        _16777216 = 16777216,
        _33554432 = 33554432,
        _67108864 = 67108864
    }

    public class ValidatorInput
    {
        public string Mail { get; set; }
        public double MinimumAmount { get; set; }
    }

    public class LoginResponse
    {
        public string Id { get; set; }
        public string UserToken { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string PhoneNumber { get; set; }
        public string Mail { get; set; }
        public string ZipCode { get; set; }
        public string MailAlias { get; set; }
        public string Language { get; set; }
        public string CreationDate { get; set; }
        public string CountryCode { get; set; }
        public string FaxNumber { get; set; }
        public string Currency { get; set; }
        public int ShemaVersion { get; set; }

        [JsonProperty("Company_Id")]
        public string CompanyId { get; set; }

        [JsonProperty("Login_Id")]
        public string LoginId { get; set; }

        [JsonProperty("Manager_Id")]
        public string ManagerId { get; set; }
        public int UserType { get; set; }
        public int UserRole { get; set; }
        public int UserTokenDurationSeconds { get; set; }
        public LoginResponseResultCodeType ResultCode { get; set; }
        public string Message { get; set; }
    }

    public enum LoginResponseResultCodeType
    {
        _0 = 0,
        _1 = 1,
        _2 = 2,
        _3 = 3,
        _4 = 4,
        _5 = 5,
        _6 = 6,
        _7 = 7,
        _10 = 10,
        _11 = 11,
        _12 = 12,
        _20 = 20,
        _30 = 30,
        _50 = 50,
        _60 = 60,
        _70 = 70,
        _71 = 71,
        _80 = 80,
        _90 = 90,
        _91 = 91,
        _92 = 92,
        _96 = 96,
        _97 = 97,
        _98 = 98,
        _99 = 99,
        _100 = 100,
        _101 = 101,
        _303 = 303,
        _400 = 400,
        _401 = 401,
        _404 = 404,
        _901 = 901,
        _902 = 902,
        _903 = 903,
        _910 = 910,
        _913 = 913,
        _1001 = 1001,
        _1004 = 1004,
        _1005 = 1005,
        _1006 = 1006,
        _2000 = 2000,
        _2001 = 2001,
        _2002 = 2002,
        _2003 = 2003,
        _2004 = 2004,
        _2005 = 2005,
        _2007 = 2007,
        _2008 = 2008
    }

    public class UpateUserV2Input
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Mail { get; set; }
        public string MailAlias { get; set; }
        public string PayId { get; set; }
        public string PayId2 { get; set; }
        public string PayId3 { get; set; }
        public string PayId4 { get; set; }
        public string PayId5 { get; set; }
        public string PayId6 { get; set; }
        public string Language { get; set; }
        public string LocalCurrency { get; set; }
        public string LocalCountry { get; set; }

        [JsonProperty("Manager_Id")]
        public string ManagerId { get; set; }

        [JsonProperty("Reviewer_Id")]
        public string ReviewerId { get; set; }
        public UpateUserV2InputUserTypeType? UserType { get; set; }
        public string Vendor { get; set; }
        public UpateUserV2InputUserRoleType? UserRole { get; set; }
        public string JobTitle { get; set; }
        public bool? CanAddPurchase { get; set; }
        public string DefaultProjectId { get; set; }

        [JsonProperty("IKRates_Id")]
        public string IKRatesId { get; set; }
        public ValidatorInput[] AdditionalValidators { get; set; }
        public string[] TagsToAssign { get; set; }
        public string[] TagsToUnassign { get; set; }
    }

    public enum UpateUserV2InputUserTypeType
    {
        _0 = 0,
        _1 = 1,
        _2 = 2,
        _4 = 4,
        _8 = 8,
        _16 = 16,
        _32 = 32,
        _56 = 56
    }

    public enum UpateUserV2InputUserRoleType
    {
        _0 = 0,
        _2 = 2,
        _4 = 4,
        _8 = 8,
        _16 = 16,
        _32 = 32,
        _64 = 64,
        _128 = 128,
        _256 = 256,
        _512 = 512,
        _1024 = 1024,
        _2048 = 2048,
        _4096 = 4096,
        _8192 = 8192,
        _16384 = 16384,
        _32768 = 32768,
        _65536 = 65536,
        _131072 = 131072,
        _262144 = 262144,
        _524288 = 524288,
        _1048576 = 1048576,
        _2097152 = 2097152,
        _4194304 = 4194304,
        _8388608 = 8388608,
        _16777216 = 16777216,
        _33554432 = 33554432,
        _67108864 = 67108864
    }

    public class UpdateProjectStateV2Input
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string[] ItemIds { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool ProjectState { get; set; }
    }

    public class BaseResultListUpdateUserResult
    {
        public UpdateUserResult[] ResultItem { get; set; }
        public BaseResultListUpdateUserResultResultCodeType ResultCode { get; set; }
        public string Message { get; set; }
    }

    public class UpdateUserResult
    {
        public UserResponse UserResponse { get; set; }
        public UpdateUserResultResultCodeType ResultCode { get; set; }
        public string Message { get; set; }
    }

    public enum UpdateUserResultResultCodeType
    {
        _0 = 0,
        _1 = 1,
        _2 = 2,
        _3 = 3,
        _4 = 4,
        _5 = 5,
        _6 = 6,
        _7 = 7,
        _10 = 10,
        _11 = 11,
        _12 = 12,
        _20 = 20,
        _30 = 30,
        _50 = 50,
        _60 = 60,
        _70 = 70,
        _71 = 71,
        _80 = 80,
        _90 = 90,
        _91 = 91,
        _92 = 92,
        _96 = 96,
        _97 = 97,
        _98 = 98,
        _99 = 99,
        _100 = 100,
        _101 = 101,
        _303 = 303,
        _400 = 400,
        _401 = 401,
        _404 = 404,
        _901 = 901,
        _902 = 902,
        _903 = 903,
        _910 = 910,
        _913 = 913,
        _1001 = 1001,
        _1004 = 1004,
        _1005 = 1005,
        _1006 = 1006,
        _2000 = 2000,
        _2001 = 2001,
        _2002 = 2002,
        _2003 = 2003,
        _2004 = 2004,
        _2005 = 2005,
        _2007 = 2007,
        _2008 = 2008
    }

    public enum BaseResultListUpdateUserResultResultCodeType
    {
        _0 = 0,
        _1 = 1,
        _2 = 2,
        _3 = 3,
        _4 = 4,
        _5 = 5,
        _6 = 6,
        _7 = 7,
        _10 = 10,
        _11 = 11,
        _12 = 12,
        _20 = 20,
        _30 = 30,
        _50 = 50,
        _60 = 60,
        _70 = 70,
        _71 = 71,
        _80 = 80,
        _90 = 90,
        _91 = 91,
        _92 = 92,
        _96 = 96,
        _97 = 97,
        _98 = 98,
        _99 = 99,
        _100 = 100,
        _101 = 101,
        _303 = 303,
        _400 = 400,
        _401 = 401,
        _404 = 404,
        _901 = 901,
        _902 = 902,
        _903 = 903,
        _910 = 910,
        _913 = 913,
        _1001 = 1001,
        _1004 = 1004,
        _1005 = 1005,
        _1006 = 1006,
        _2000 = 2000,
        _2001 = 2001,
        _2002 = 2002,
        _2003 = 2003,
        _2004 = 2004,
        _2005 = 2005,
        _2007 = 2007,
        _2008 = 2008
    }

    public class UpdateUserStateInput
    {
        public string UserId { get; set; }
        public UpdateUserStateInputOperationType Operation { get; set; }
    }

    public enum UpdateUserStateInputOperationType
    {
        _2 = 2,
        _3 = 3,
        _4 = 4
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Expensya;

    public partial class WorkflowManagedActions
    {
        public ExpensyaActions Expensya(string connectionId) => new ExpensyaActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public ExpensyaTriggers Expensya(string connectionId) => new ExpensyaTriggers(connectionId);
    }
}