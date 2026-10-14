//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Expensya
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class ExpensyaActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expensya")]
        public IBodyWorkflowAction<string> GetExpenseImage(Expression<Func<string>> expenseId)
        {
            var __workflow_expenseId = expenseId == null ? null : WorkflowExpression.Compile(expenseId);
            WorkflowExpression.Validate(__workflow_expenseId, nameof(expenseId), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/expense/{0}/image", ExpressionConverter.ConvertWithUrlEncoding(__workflow_expenseId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expensya")]
        public IBodyWorkflowAction<BaseResultExportResponse> ExportExpenses(Expression<Func<string>> exportId, Expression<Func<string>> reportId = null, Expression<Func<string>> categoryId = null, Expression<Func<string>> expenseName = null, Expression<Func<string>> startDate = null, Expression<Func<string>> endDate = null, Expression<Func<string>> expenseStates = null, Expression<Func<string>> reportStates = null, Expression<Func<string>> userIds = null, Expression<Func<string>> userMail = null, Expression<Func<string>> reportIds = null, Expression<Func<string>> expenseIds = null, Expression<Func<string>> reportName = null, Expression<Func<string>> reportIdShort = null, Expression<Func<int>> dateFilterType = null, Expression<Func<string>> payId = null, Expression<Func<string>> payId2 = null, Expression<Func<string>> payId3 = null, Expression<Func<string>> accountingPeriod = null, Expression<Func<bool>> includeReceipts = null, Expression<Func<int>> expenseUseTypes = null, Expression<Func<string>> archiveExpenses = null)
        {
            var __workflow_exportId = exportId == null ? null : WorkflowExpression.Compile(exportId);
            WorkflowExpression.Validate(__workflow_exportId, nameof(exportId), required: true);
            var __workflow_reportId = reportId == null ? null : WorkflowExpression.Compile(reportId);
            WorkflowExpression.Validate(__workflow_reportId, nameof(reportId), required: false);
            var __workflow_categoryId = categoryId == null ? null : WorkflowExpression.Compile(categoryId);
            WorkflowExpression.Validate(__workflow_categoryId, nameof(categoryId), required: false);
            var __workflow_expenseName = expenseName == null ? null : WorkflowExpression.Compile(expenseName);
            WorkflowExpression.Validate(__workflow_expenseName, nameof(expenseName), required: false);
            var __workflow_startDate = startDate == null ? null : WorkflowExpression.Compile(startDate);
            WorkflowExpression.Validate(__workflow_startDate, nameof(startDate), required: false);
            var __workflow_endDate = endDate == null ? null : WorkflowExpression.Compile(endDate);
            WorkflowExpression.Validate(__workflow_endDate, nameof(endDate), required: false);
            var __workflow_expenseStates = expenseStates == null ? null : WorkflowExpression.Compile(expenseStates);
            WorkflowExpression.Validate(__workflow_expenseStates, nameof(expenseStates), required: false);
            var __workflow_reportStates = reportStates == null ? null : WorkflowExpression.Compile(reportStates);
            WorkflowExpression.Validate(__workflow_reportStates, nameof(reportStates), required: false);
            var __workflow_userIds = userIds == null ? null : WorkflowExpression.Compile(userIds);
            WorkflowExpression.Validate(__workflow_userIds, nameof(userIds), required: false);
            var __workflow_userMail = userMail == null ? null : WorkflowExpression.Compile(userMail);
            WorkflowExpression.Validate(__workflow_userMail, nameof(userMail), required: false);
            var __workflow_reportIds = reportIds == null ? null : WorkflowExpression.Compile(reportIds);
            WorkflowExpression.Validate(__workflow_reportIds, nameof(reportIds), required: false);
            var __workflow_expenseIds = expenseIds == null ? null : WorkflowExpression.Compile(expenseIds);
            WorkflowExpression.Validate(__workflow_expenseIds, nameof(expenseIds), required: false);
            var __workflow_reportName = reportName == null ? null : WorkflowExpression.Compile(reportName);
            WorkflowExpression.Validate(__workflow_reportName, nameof(reportName), required: false);
            var __workflow_reportIdShort = reportIdShort == null ? null : WorkflowExpression.Compile(reportIdShort);
            WorkflowExpression.Validate(__workflow_reportIdShort, nameof(reportIdShort), required: false);
            var __workflow_dateFilterType = dateFilterType == null ? null : WorkflowExpression.Compile(dateFilterType);
            WorkflowExpression.Validate(__workflow_dateFilterType, nameof(dateFilterType), required: false);
            var __workflow_payId = payId == null ? null : WorkflowExpression.Compile(payId);
            WorkflowExpression.Validate(__workflow_payId, nameof(payId), required: false);
            var __workflow_payId2 = payId2 == null ? null : WorkflowExpression.Compile(payId2);
            WorkflowExpression.Validate(__workflow_payId2, nameof(payId2), required: false);
            var __workflow_payId3 = payId3 == null ? null : WorkflowExpression.Compile(payId3);
            WorkflowExpression.Validate(__workflow_payId3, nameof(payId3), required: false);
            var __workflow_accountingPeriod = accountingPeriod == null ? null : WorkflowExpression.Compile(accountingPeriod);
            WorkflowExpression.Validate(__workflow_accountingPeriod, nameof(accountingPeriod), required: false);
            var __workflow_includeReceipts = includeReceipts == null ? null : WorkflowExpression.Compile(includeReceipts);
            WorkflowExpression.Validate(__workflow_includeReceipts, nameof(includeReceipts), required: false);
            var __workflow_expenseUseTypes = expenseUseTypes == null ? null : WorkflowExpression.Compile(expenseUseTypes);
            WorkflowExpression.Validate(__workflow_expenseUseTypes, nameof(expenseUseTypes), required: false);
            var __workflow_archiveExpenses = archiveExpenses == null ? null : WorkflowExpression.Compile(archiveExpenses);
            WorkflowExpression.Validate(__workflow_archiveExpenses, nameof(archiveExpenses), required: false);
            return new DeferredBodyAction<BaseResultExportResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/export/expenses/{0}/", ExpressionConverter.ConvertWithUrlEncoding(__workflow_exportId, 1));
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
        public IBodyWorkflowAction<BaseResultExportResponse> PrintMission(Expression<Func<string>> reportId)
        {
            var __workflow_reportId = reportId == null ? null : WorkflowExpression.Compile(reportId);
            WorkflowExpression.Validate(__workflow_reportId, nameof(reportId), required: true);
            return new DeferredBodyAction<BaseResultExportResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/export/report/{0}/pdf/", ExpressionConverter.ConvertWithUrlEncoding(__workflow_reportId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<BaseResultExportResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expensya")]
        public IBodyWorkflowAction<BaseResultListExportFormatResponse> ExportFormats(Expression<Func<bool>> isForExpenses = null, Expression<Func<int>> exportType = null)
        {
            var __workflow_isForExpenses = isForExpenses == null ? null : WorkflowExpression.Compile(isForExpenses);
            WorkflowExpression.Validate(__workflow_isForExpenses, nameof(isForExpenses), required: false);
            var __workflow_exportType = exportType == null ? null : WorkflowExpression.Compile(exportType);
            WorkflowExpression.Validate(__workflow_exportType, nameof(exportType), required: false);
            return new DeferredBodyAction<BaseResultListExportFormatResponse>(() =>
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
        public IBodyWorkflowAction<BaseResultListAddOrUpdateEntityResult> AddProjects(Expression<Func<AddOrUpdateProjectInput[]>> addOrUpdateProjectInputArray = null)
        {
            var __workflow_addOrUpdateProjectInputArray = addOrUpdateProjectInputArray == null ? null : WorkflowExpression.Compile(addOrUpdateProjectInputArray);
            WorkflowExpression.Validate(__workflow_addOrUpdateProjectInputArray, nameof(addOrUpdateProjectInputArray), required: false);
            return new DeferredBodyAction<BaseResultListAddOrUpdateEntityResult>(() =>
            {
                var apiCallPath = "/api/projects/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_addOrUpdateProjectInputArray);
                return new ApiConnectionAction<BaseResultListAddOrUpdateEntityResult>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expensya")]
        public IBodyWorkflowAction<BaseResultListAddOrUpdateEntityResult> UpdateProjects(Expression<Func<AddOrUpdateProjectInput[]>> addOrUpdateProjectInputArray = null)
        {
            var __workflow_addOrUpdateProjectInputArray = addOrUpdateProjectInputArray == null ? null : WorkflowExpression.Compile(addOrUpdateProjectInputArray);
            WorkflowExpression.Validate(__workflow_addOrUpdateProjectInputArray, nameof(addOrUpdateProjectInputArray), required: false);
            return new DeferredBodyAction<BaseResultListAddOrUpdateEntityResult>(() =>
            {
                var apiCallPath = "/api/projects/";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_addOrUpdateProjectInputArray);
                return new ApiConnectionAction<BaseResultListAddOrUpdateEntityResult>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expensya")]
        public IBodyWorkflowAction<BaseResult> AddReciept(Expression<Func<string>> addReceiptInputuserId, Expression<Func<string>> addReceiptInputreceiptContent, Expression<Func<string>> addReceiptInputreceiptName)
        {
            var __workflow_addReceiptInputuserId = addReceiptInputuserId == null ? null : WorkflowExpression.Compile(addReceiptInputuserId);
            WorkflowExpression.Validate(__workflow_addReceiptInputuserId, nameof(addReceiptInputuserId), required: true);
            var __workflow_addReceiptInputreceiptContent = addReceiptInputreceiptContent == null ? null : WorkflowExpression.Compile(addReceiptInputreceiptContent);
            WorkflowExpression.Validate(__workflow_addReceiptInputreceiptContent, nameof(addReceiptInputreceiptContent), required: true);
            var __workflow_addReceiptInputreceiptName = addReceiptInputreceiptName == null ? null : WorkflowExpression.Compile(addReceiptInputreceiptName);
            WorkflowExpression.Validate(__workflow_addReceiptInputreceiptName, nameof(addReceiptInputreceiptName), required: true);
            return new DeferredBodyAction<BaseResult>(() =>
            {
                var apiCallPath = "/api/receipt/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var addReceiptInput = new JObject();
                var addReceiptInputpropCount = 0;
                addReceiptInputpropCount++;
                addReceiptInput["UserId"] = ExpressionConverter.ConvertO(__workflow_addReceiptInputuserId);
                addReceiptInputpropCount++;
                addReceiptInput["ReceiptContent"] = ExpressionConverter.ConvertO(__workflow_addReceiptInputreceiptContent);
                addReceiptInputpropCount++;
                addReceiptInput["ReceiptName"] = ExpressionConverter.ConvertO(__workflow_addReceiptInputreceiptName);
                if (addReceiptInputpropCount > 0)
                {
                    callPayload.Body = addReceiptInput;
                }

                return new ApiConnectionAction<BaseResult>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expensya")]
        public IBodyWorkflowAction<BaseResult> RevokeUserToken()
        {
            var apiCallPath = "/api/revokeUserToken/";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<BaseResult>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expensya")]
        public IBodyWorkflowAction<ListAndPagesCountResultReportResponse> ValidatorReports(Expression<Func<string>> validatorMail, Expression<Func<string>> reportName = null, Expression<Func<string>> reportStartDate = null, Expression<Func<string>> reportEndDate = null, Expression<Func<string>> reportStates = null, Expression<Func<string>> reportIdShort = null, Expression<Func<string>> ownerId = null, Expression<Func<string>> ownerPayId2 = null, Expression<Func<string>> projectId = null, Expression<Func<int>> dateFilterType = null, Expression<Func<int>> sortBy = null, Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null, Expression<Func<bool>> isDesc = null)
        {
            var __workflow_validatorMail = validatorMail == null ? null : WorkflowExpression.Compile(validatorMail);
            WorkflowExpression.Validate(__workflow_validatorMail, nameof(validatorMail), required: true);
            var __workflow_reportName = reportName == null ? null : WorkflowExpression.Compile(reportName);
            WorkflowExpression.Validate(__workflow_reportName, nameof(reportName), required: false);
            var __workflow_reportStartDate = reportStartDate == null ? null : WorkflowExpression.Compile(reportStartDate);
            WorkflowExpression.Validate(__workflow_reportStartDate, nameof(reportStartDate), required: false);
            var __workflow_reportEndDate = reportEndDate == null ? null : WorkflowExpression.Compile(reportEndDate);
            WorkflowExpression.Validate(__workflow_reportEndDate, nameof(reportEndDate), required: false);
            var __workflow_reportStates = reportStates == null ? null : WorkflowExpression.Compile(reportStates);
            WorkflowExpression.Validate(__workflow_reportStates, nameof(reportStates), required: false);
            var __workflow_reportIdShort = reportIdShort == null ? null : WorkflowExpression.Compile(reportIdShort);
            WorkflowExpression.Validate(__workflow_reportIdShort, nameof(reportIdShort), required: false);
            var __workflow_ownerId = ownerId == null ? null : WorkflowExpression.Compile(ownerId);
            WorkflowExpression.Validate(__workflow_ownerId, nameof(ownerId), required: false);
            var __workflow_ownerPayId2 = ownerPayId2 == null ? null : WorkflowExpression.Compile(ownerPayId2);
            WorkflowExpression.Validate(__workflow_ownerPayId2, nameof(ownerPayId2), required: false);
            var __workflow_projectId = projectId == null ? null : WorkflowExpression.Compile(projectId);
            WorkflowExpression.Validate(__workflow_projectId, nameof(projectId), required: false);
            var __workflow_dateFilterType = dateFilterType == null ? null : WorkflowExpression.Compile(dateFilterType);
            WorkflowExpression.Validate(__workflow_dateFilterType, nameof(dateFilterType), required: false);
            var __workflow_sortBy = sortBy == null ? null : WorkflowExpression.Compile(sortBy);
            WorkflowExpression.Validate(__workflow_sortBy, nameof(sortBy), required: false);
            var __workflow_page = page == null ? null : WorkflowExpression.Compile(page);
            WorkflowExpression.Validate(__workflow_page, nameof(page), required: false);
            var __workflow_pageSize = pageSize == null ? null : WorkflowExpression.Compile(pageSize);
            WorkflowExpression.Validate(__workflow_pageSize, nameof(pageSize), required: false);
            var __workflow_isDesc = isDesc == null ? null : WorkflowExpression.Compile(isDesc);
            WorkflowExpression.Validate(__workflow_isDesc, nameof(isDesc), required: false);
            return new DeferredBodyAction<ListAndPagesCountResultReportResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v2/{0}/reports/", ExpressionConverter.ConvertWithUrlEncoding(__workflow_validatorMail, 1));
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
        public IBodyWorkflowAction<BaseResult> UpdateReportStatus(Expression<Func<string>> reportId, Expression<Func<reportUpdateStatusInputoperationInput>> reportUpdateStatusInputoperation, Expression<Func<string>> reportUpdateStatusInputmessage, Expression<Func<string[]>> reportUpdateStatusInputinvoiceIdsToReject = null, Expression<Func<string>> reportUpdateStatusInputaccountingPeriod = null)
        {
            var __workflow_reportId = reportId == null ? null : WorkflowExpression.Compile(reportId);
            WorkflowExpression.Validate(__workflow_reportId, nameof(reportId), required: true);
            var __workflow_reportUpdateStatusInputoperation = reportUpdateStatusInputoperation == null ? null : WorkflowExpression.Compile(reportUpdateStatusInputoperation);
            WorkflowExpression.Validate(__workflow_reportUpdateStatusInputoperation, nameof(reportUpdateStatusInputoperation), required: true);
            var __workflow_reportUpdateStatusInputmessage = reportUpdateStatusInputmessage == null ? null : WorkflowExpression.Compile(reportUpdateStatusInputmessage);
            WorkflowExpression.Validate(__workflow_reportUpdateStatusInputmessage, nameof(reportUpdateStatusInputmessage), required: true);
            var __workflow_reportUpdateStatusInputinvoiceIdsToReject = reportUpdateStatusInputinvoiceIdsToReject == null ? null : WorkflowExpression.Compile(reportUpdateStatusInputinvoiceIdsToReject);
            WorkflowExpression.Validate(__workflow_reportUpdateStatusInputinvoiceIdsToReject, nameof(reportUpdateStatusInputinvoiceIdsToReject), required: false);
            var __workflow_reportUpdateStatusInputaccountingPeriod = reportUpdateStatusInputaccountingPeriod == null ? null : WorkflowExpression.Compile(reportUpdateStatusInputaccountingPeriod);
            WorkflowExpression.Validate(__workflow_reportUpdateStatusInputaccountingPeriod, nameof(reportUpdateStatusInputaccountingPeriod), required: false);
            return new DeferredBodyAction<BaseResult>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v2/report/{0}/updateStatus/", ExpressionConverter.ConvertWithUrlEncoding(__workflow_reportId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var reportUpdateStatusInput = new JObject();
                var reportUpdateStatusInputpropCount = 0;
                reportUpdateStatusInputpropCount++;
                reportUpdateStatusInput["Operation"] = ExpressionConverter.ConvertO(__workflow_reportUpdateStatusInputoperation);
                reportUpdateStatusInputpropCount++;
                reportUpdateStatusInput["Message"] = ExpressionConverter.ConvertO(__workflow_reportUpdateStatusInputmessage);
                if (__workflow_reportUpdateStatusInputinvoiceIdsToReject != null)
                {
                    reportUpdateStatusInput["InvoiceIdsToReject"] = ExpressionConverter.ConvertO(__workflow_reportUpdateStatusInputinvoiceIdsToReject);
                    reportUpdateStatusInputpropCount++;
                }

                if (__workflow_reportUpdateStatusInputaccountingPeriod != null)
                {
                    reportUpdateStatusInput["AccountingPeriod"] = ExpressionConverter.ConvertO(__workflow_reportUpdateStatusInputaccountingPeriod);
                    reportUpdateStatusInputpropCount++;
                }

                if (reportUpdateStatusInputpropCount > 0)
                {
                    callPayload.Body = reportUpdateStatusInput;
                }

                return new ApiConnectionAction<BaseResult>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expensya")]
        public IBodyWorkflowAction<ListAndPagesCountResultReportResponse> CompanyReports(Expression<Func<string>> reportName = null, Expression<Func<string>> reportStartDate = null, Expression<Func<string>> reportEndDate = null, Expression<Func<string>> reportStates = null, Expression<Func<string>> reportIdShort = null, Expression<Func<string>> ownerId = null, Expression<Func<string>> ownerPayId2 = null, Expression<Func<string>> projectId = null, Expression<Func<string>> tagsNames = null, Expression<Func<int>> dateFilterType = null, Expression<Func<int>> sortBy = null, Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null, Expression<Func<bool>> isDesc = null)
        {
            var __workflow_reportName = reportName == null ? null : WorkflowExpression.Compile(reportName);
            WorkflowExpression.Validate(__workflow_reportName, nameof(reportName), required: false);
            var __workflow_reportStartDate = reportStartDate == null ? null : WorkflowExpression.Compile(reportStartDate);
            WorkflowExpression.Validate(__workflow_reportStartDate, nameof(reportStartDate), required: false);
            var __workflow_reportEndDate = reportEndDate == null ? null : WorkflowExpression.Compile(reportEndDate);
            WorkflowExpression.Validate(__workflow_reportEndDate, nameof(reportEndDate), required: false);
            var __workflow_reportStates = reportStates == null ? null : WorkflowExpression.Compile(reportStates);
            WorkflowExpression.Validate(__workflow_reportStates, nameof(reportStates), required: false);
            var __workflow_reportIdShort = reportIdShort == null ? null : WorkflowExpression.Compile(reportIdShort);
            WorkflowExpression.Validate(__workflow_reportIdShort, nameof(reportIdShort), required: false);
            var __workflow_ownerId = ownerId == null ? null : WorkflowExpression.Compile(ownerId);
            WorkflowExpression.Validate(__workflow_ownerId, nameof(ownerId), required: false);
            var __workflow_ownerPayId2 = ownerPayId2 == null ? null : WorkflowExpression.Compile(ownerPayId2);
            WorkflowExpression.Validate(__workflow_ownerPayId2, nameof(ownerPayId2), required: false);
            var __workflow_projectId = projectId == null ? null : WorkflowExpression.Compile(projectId);
            WorkflowExpression.Validate(__workflow_projectId, nameof(projectId), required: false);
            var __workflow_tagsNames = tagsNames == null ? null : WorkflowExpression.Compile(tagsNames);
            WorkflowExpression.Validate(__workflow_tagsNames, nameof(tagsNames), required: false);
            var __workflow_dateFilterType = dateFilterType == null ? null : WorkflowExpression.Compile(dateFilterType);
            WorkflowExpression.Validate(__workflow_dateFilterType, nameof(dateFilterType), required: false);
            var __workflow_sortBy = sortBy == null ? null : WorkflowExpression.Compile(sortBy);
            WorkflowExpression.Validate(__workflow_sortBy, nameof(sortBy), required: false);
            var __workflow_page = page == null ? null : WorkflowExpression.Compile(page);
            WorkflowExpression.Validate(__workflow_page, nameof(page), required: false);
            var __workflow_pageSize = pageSize == null ? null : WorkflowExpression.Compile(pageSize);
            WorkflowExpression.Validate(__workflow_pageSize, nameof(pageSize), required: false);
            var __workflow_isDesc = isDesc == null ? null : WorkflowExpression.Compile(isDesc);
            WorkflowExpression.Validate(__workflow_isDesc, nameof(isDesc), required: false);
            return new DeferredBodyAction<ListAndPagesCountResultReportResponse>(() =>
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
        public IBodyWorkflowAction<ListAndPagesCountResultUserResponse> CompanyUsers(Expression<Func<string>> id = null, Expression<Func<string>> firstName = null, Expression<Func<string>> lastName = null, Expression<Func<string>> mail = null, Expression<Func<string>> payId = null, Expression<Func<string>> mailOrNameOrPayId = null, Expression<Func<int>> type = null, Expression<Func<int>> state = null, Expression<Func<string>> reviewerId = null, Expression<Func<string>> reviewerName = null, Expression<Func<string>> managerId = null, Expression<Func<string>> managerName = null, Expression<Func<string>> userIds = null, Expression<Func<string>> userMails = null, Expression<Func<string>> tagsNames = null, Expression<Func<string>> simpleTagsNames = null, Expression<Func<int>> sortBy = null, Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null, Expression<Func<bool>> isDesc = null)
        {
            var __workflow_id = id == null ? null : WorkflowExpression.Compile(id);
            WorkflowExpression.Validate(__workflow_id, nameof(id), required: false);
            var __workflow_firstName = firstName == null ? null : WorkflowExpression.Compile(firstName);
            WorkflowExpression.Validate(__workflow_firstName, nameof(firstName), required: false);
            var __workflow_lastName = lastName == null ? null : WorkflowExpression.Compile(lastName);
            WorkflowExpression.Validate(__workflow_lastName, nameof(lastName), required: false);
            var __workflow_mail = mail == null ? null : WorkflowExpression.Compile(mail);
            WorkflowExpression.Validate(__workflow_mail, nameof(mail), required: false);
            var __workflow_payId = payId == null ? null : WorkflowExpression.Compile(payId);
            WorkflowExpression.Validate(__workflow_payId, nameof(payId), required: false);
            var __workflow_mailOrNameOrPayId = mailOrNameOrPayId == null ? null : WorkflowExpression.Compile(mailOrNameOrPayId);
            WorkflowExpression.Validate(__workflow_mailOrNameOrPayId, nameof(mailOrNameOrPayId), required: false);
            var __workflow_type = type == null ? null : WorkflowExpression.Compile(type);
            WorkflowExpression.Validate(__workflow_type, nameof(type), required: false);
            var __workflow_state = state == null ? null : WorkflowExpression.Compile(state);
            WorkflowExpression.Validate(__workflow_state, nameof(state), required: false);
            var __workflow_reviewerId = reviewerId == null ? null : WorkflowExpression.Compile(reviewerId);
            WorkflowExpression.Validate(__workflow_reviewerId, nameof(reviewerId), required: false);
            var __workflow_reviewerName = reviewerName == null ? null : WorkflowExpression.Compile(reviewerName);
            WorkflowExpression.Validate(__workflow_reviewerName, nameof(reviewerName), required: false);
            var __workflow_managerId = managerId == null ? null : WorkflowExpression.Compile(managerId);
            WorkflowExpression.Validate(__workflow_managerId, nameof(managerId), required: false);
            var __workflow_managerName = managerName == null ? null : WorkflowExpression.Compile(managerName);
            WorkflowExpression.Validate(__workflow_managerName, nameof(managerName), required: false);
            var __workflow_userIds = userIds == null ? null : WorkflowExpression.Compile(userIds);
            WorkflowExpression.Validate(__workflow_userIds, nameof(userIds), required: false);
            var __workflow_userMails = userMails == null ? null : WorkflowExpression.Compile(userMails);
            WorkflowExpression.Validate(__workflow_userMails, nameof(userMails), required: false);
            var __workflow_tagsNames = tagsNames == null ? null : WorkflowExpression.Compile(tagsNames);
            WorkflowExpression.Validate(__workflow_tagsNames, nameof(tagsNames), required: false);
            var __workflow_simpleTagsNames = simpleTagsNames == null ? null : WorkflowExpression.Compile(simpleTagsNames);
            WorkflowExpression.Validate(__workflow_simpleTagsNames, nameof(simpleTagsNames), required: false);
            var __workflow_sortBy = sortBy == null ? null : WorkflowExpression.Compile(sortBy);
            WorkflowExpression.Validate(__workflow_sortBy, nameof(sortBy), required: false);
            var __workflow_page = page == null ? null : WorkflowExpression.Compile(page);
            WorkflowExpression.Validate(__workflow_page, nameof(page), required: false);
            var __workflow_pageSize = pageSize == null ? null : WorkflowExpression.Compile(pageSize);
            WorkflowExpression.Validate(__workflow_pageSize, nameof(pageSize), required: false);
            var __workflow_isDesc = isDesc == null ? null : WorkflowExpression.Compile(isDesc);
            WorkflowExpression.Validate(__workflow_isDesc, nameof(isDesc), required: false);
            return new DeferredBodyAction<ListAndPagesCountResultUserResponse>(() =>
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
        public IBodyWorkflowAction<BaseResult> AddQuickExpense(Expression<Func<string>> userId, Expression<Func<string>> quickExpenseInputfileToSend, Expression<Func<string>> quickExpenseInputtitle = null, Expression<Func<double>> quickExpenseInputtransactionAmount = null, Expression<Func<string>> quickExpenseInputvatRates = null, Expression<Func<string>> quickExpenseInputvatAmounts = null, Expression<Func<string>> quickExpenseInputcurrencyCode = null, Expression<Func<string>> quickExpenseInputtransactionDate = null, Expression<Func<string>> quickExpenseInputmerchantName = null, Expression<Func<string>> quickExpenseInputlocationCountry = null, Expression<Func<string>> quickExpenseInputlocationCity = null, Expression<Func<string>> quickExpenseInputcomment = null, Expression<Func<string>> quickExpenseInputmerchantExpenseId = null, Expression<Func<bool>> quickExpenseInputisEncrypted = null, Expression<Func<quickExpenseInputexpenseUseTypeInput>> quickExpenseInputexpenseUseType = null, Expression<Func<string>> quickExpenseInputpaymentTypeCode = null, Expression<Func<string>> quickExpenseInputexpenseTypeCode = null, Expression<Func<string>> quickExpenseInputfileType = null)
        {
            var __workflow_userId = userId == null ? null : WorkflowExpression.Compile(userId);
            WorkflowExpression.Validate(__workflow_userId, nameof(userId), required: true);
            var __workflow_quickExpenseInputfileToSend = quickExpenseInputfileToSend == null ? null : WorkflowExpression.Compile(quickExpenseInputfileToSend);
            WorkflowExpression.Validate(__workflow_quickExpenseInputfileToSend, nameof(quickExpenseInputfileToSend), required: true);
            var __workflow_quickExpenseInputtitle = quickExpenseInputtitle == null ? null : WorkflowExpression.Compile(quickExpenseInputtitle);
            WorkflowExpression.Validate(__workflow_quickExpenseInputtitle, nameof(quickExpenseInputtitle), required: false);
            var __workflow_quickExpenseInputtransactionAmount = quickExpenseInputtransactionAmount == null ? null : WorkflowExpression.Compile(quickExpenseInputtransactionAmount);
            WorkflowExpression.Validate(__workflow_quickExpenseInputtransactionAmount, nameof(quickExpenseInputtransactionAmount), required: false);
            var __workflow_quickExpenseInputvatRates = quickExpenseInputvatRates == null ? null : WorkflowExpression.Compile(quickExpenseInputvatRates);
            WorkflowExpression.Validate(__workflow_quickExpenseInputvatRates, nameof(quickExpenseInputvatRates), required: false);
            var __workflow_quickExpenseInputvatAmounts = quickExpenseInputvatAmounts == null ? null : WorkflowExpression.Compile(quickExpenseInputvatAmounts);
            WorkflowExpression.Validate(__workflow_quickExpenseInputvatAmounts, nameof(quickExpenseInputvatAmounts), required: false);
            var __workflow_quickExpenseInputcurrencyCode = quickExpenseInputcurrencyCode == null ? null : WorkflowExpression.Compile(quickExpenseInputcurrencyCode);
            WorkflowExpression.Validate(__workflow_quickExpenseInputcurrencyCode, nameof(quickExpenseInputcurrencyCode), required: false);
            var __workflow_quickExpenseInputtransactionDate = quickExpenseInputtransactionDate == null ? null : WorkflowExpression.Compile(quickExpenseInputtransactionDate);
            WorkflowExpression.Validate(__workflow_quickExpenseInputtransactionDate, nameof(quickExpenseInputtransactionDate), required: false);
            var __workflow_quickExpenseInputmerchantName = quickExpenseInputmerchantName == null ? null : WorkflowExpression.Compile(quickExpenseInputmerchantName);
            WorkflowExpression.Validate(__workflow_quickExpenseInputmerchantName, nameof(quickExpenseInputmerchantName), required: false);
            var __workflow_quickExpenseInputlocationCountry = quickExpenseInputlocationCountry == null ? null : WorkflowExpression.Compile(quickExpenseInputlocationCountry);
            WorkflowExpression.Validate(__workflow_quickExpenseInputlocationCountry, nameof(quickExpenseInputlocationCountry), required: false);
            var __workflow_quickExpenseInputlocationCity = quickExpenseInputlocationCity == null ? null : WorkflowExpression.Compile(quickExpenseInputlocationCity);
            WorkflowExpression.Validate(__workflow_quickExpenseInputlocationCity, nameof(quickExpenseInputlocationCity), required: false);
            var __workflow_quickExpenseInputcomment = quickExpenseInputcomment == null ? null : WorkflowExpression.Compile(quickExpenseInputcomment);
            WorkflowExpression.Validate(__workflow_quickExpenseInputcomment, nameof(quickExpenseInputcomment), required: false);
            var __workflow_quickExpenseInputmerchantExpenseId = quickExpenseInputmerchantExpenseId == null ? null : WorkflowExpression.Compile(quickExpenseInputmerchantExpenseId);
            WorkflowExpression.Validate(__workflow_quickExpenseInputmerchantExpenseId, nameof(quickExpenseInputmerchantExpenseId), required: false);
            var __workflow_quickExpenseInputisEncrypted = quickExpenseInputisEncrypted == null ? null : WorkflowExpression.Compile(quickExpenseInputisEncrypted);
            WorkflowExpression.Validate(__workflow_quickExpenseInputisEncrypted, nameof(quickExpenseInputisEncrypted), required: false);
            var __workflow_quickExpenseInputexpenseUseType = quickExpenseInputexpenseUseType == null ? null : WorkflowExpression.Compile(quickExpenseInputexpenseUseType);
            WorkflowExpression.Validate(__workflow_quickExpenseInputexpenseUseType, nameof(quickExpenseInputexpenseUseType), required: false);
            var __workflow_quickExpenseInputpaymentTypeCode = quickExpenseInputpaymentTypeCode == null ? null : WorkflowExpression.Compile(quickExpenseInputpaymentTypeCode);
            WorkflowExpression.Validate(__workflow_quickExpenseInputpaymentTypeCode, nameof(quickExpenseInputpaymentTypeCode), required: false);
            var __workflow_quickExpenseInputexpenseTypeCode = quickExpenseInputexpenseTypeCode == null ? null : WorkflowExpression.Compile(quickExpenseInputexpenseTypeCode);
            WorkflowExpression.Validate(__workflow_quickExpenseInputexpenseTypeCode, nameof(quickExpenseInputexpenseTypeCode), required: false);
            var __workflow_quickExpenseInputfileType = quickExpenseInputfileType == null ? null : WorkflowExpression.Compile(quickExpenseInputfileType);
            WorkflowExpression.Validate(__workflow_quickExpenseInputfileType, nameof(quickExpenseInputfileType), required: false);
            return new DeferredBodyAction<BaseResult>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v2/quickexpense/{0}/", ExpressionConverter.ConvertWithUrlEncoding(__workflow_userId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var quickExpenseInput = new JObject();
                var quickExpenseInputpropCount = 0;
                quickExpenseInputpropCount++;
                quickExpenseInput["FileToSend"] = ExpressionConverter.ConvertO(__workflow_quickExpenseInputfileToSend);
                if (__workflow_quickExpenseInputtitle != null)
                {
                    quickExpenseInput["Title"] = ExpressionConverter.ConvertO(__workflow_quickExpenseInputtitle);
                    quickExpenseInputpropCount++;
                }

                if (__workflow_quickExpenseInputtransactionAmount != null)
                {
                    quickExpenseInput["TransactionAmount"] = ExpressionConverter.ConvertO(__workflow_quickExpenseInputtransactionAmount);
                    quickExpenseInputpropCount++;
                }

                if (__workflow_quickExpenseInputvatRates != null)
                {
                    quickExpenseInput["VatRates"] = ExpressionConverter.ConvertO(__workflow_quickExpenseInputvatRates);
                    quickExpenseInputpropCount++;
                }

                if (__workflow_quickExpenseInputvatAmounts != null)
                {
                    quickExpenseInput["VatAmounts"] = ExpressionConverter.ConvertO(__workflow_quickExpenseInputvatAmounts);
                    quickExpenseInputpropCount++;
                }

                if (__workflow_quickExpenseInputcurrencyCode != null)
                {
                    quickExpenseInput["CurrencyCode"] = ExpressionConverter.ConvertO(__workflow_quickExpenseInputcurrencyCode);
                    quickExpenseInputpropCount++;
                }

                if (__workflow_quickExpenseInputtransactionDate != null)
                {
                    quickExpenseInput["TransactionDate"] = ExpressionConverter.ConvertO(__workflow_quickExpenseInputtransactionDate);
                    quickExpenseInputpropCount++;
                }

                if (__workflow_quickExpenseInputmerchantName != null)
                {
                    quickExpenseInput["MerchantName"] = ExpressionConverter.ConvertO(__workflow_quickExpenseInputmerchantName);
                    quickExpenseInputpropCount++;
                }

                if (__workflow_quickExpenseInputlocationCountry != null)
                {
                    quickExpenseInput["LocationCountry"] = ExpressionConverter.ConvertO(__workflow_quickExpenseInputlocationCountry);
                    quickExpenseInputpropCount++;
                }

                if (__workflow_quickExpenseInputlocationCity != null)
                {
                    quickExpenseInput["LocationCity"] = ExpressionConverter.ConvertO(__workflow_quickExpenseInputlocationCity);
                    quickExpenseInputpropCount++;
                }

                if (__workflow_quickExpenseInputcomment != null)
                {
                    quickExpenseInput["Comment"] = ExpressionConverter.ConvertO(__workflow_quickExpenseInputcomment);
                    quickExpenseInputpropCount++;
                }

                if (__workflow_quickExpenseInputmerchantExpenseId != null)
                {
                    quickExpenseInput["MerchantExpenseId"] = ExpressionConverter.ConvertO(__workflow_quickExpenseInputmerchantExpenseId);
                    quickExpenseInputpropCount++;
                }

                if (__workflow_quickExpenseInputisEncrypted != null)
                {
                    quickExpenseInput["IsEncrypted"] = ExpressionConverter.ConvertO(__workflow_quickExpenseInputisEncrypted);
                    quickExpenseInputpropCount++;
                }

                if (__workflow_quickExpenseInputexpenseUseType != null)
                {
                    quickExpenseInput["ExpenseUseType"] = ExpressionConverter.ConvertO(__workflow_quickExpenseInputexpenseUseType);
                    quickExpenseInputpropCount++;
                }

                if (__workflow_quickExpenseInputpaymentTypeCode != null)
                {
                    quickExpenseInput["PaymentTypeCode"] = ExpressionConverter.ConvertO(__workflow_quickExpenseInputpaymentTypeCode);
                    quickExpenseInputpropCount++;
                }

                if (__workflow_quickExpenseInputexpenseTypeCode != null)
                {
                    quickExpenseInput["ExpenseTypeCode"] = ExpressionConverter.ConvertO(__workflow_quickExpenseInputexpenseTypeCode);
                    quickExpenseInputpropCount++;
                }

                if (__workflow_quickExpenseInputfileType != null)
                {
                    quickExpenseInput["FileType"] = ExpressionConverter.ConvertO(__workflow_quickExpenseInputfileType);
                    quickExpenseInputpropCount++;
                }

                if (quickExpenseInputpropCount > 0)
                {
                    callPayload.Body = quickExpenseInput;
                }

                return new ApiConnectionAction<BaseResult>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expensya")]
        public IBodyWorkflowAction<ListAndPagesCountResultCategoryResponse> GetCategories(Expression<Func<string>> id = null, Expression<Func<string>> categoryName = null, Expression<Func<string>> costAccount = null, Expression<Func<string>> vatAccount = null, Expression<Func<bool>> isActive = null, Expression<Func<string>> tagsNames = null, Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null, Expression<Func<int>> sortBy = null, Expression<Func<bool>> isDesc = null)
        {
            var __workflow_id = id == null ? null : WorkflowExpression.Compile(id);
            WorkflowExpression.Validate(__workflow_id, nameof(id), required: false);
            var __workflow_categoryName = categoryName == null ? null : WorkflowExpression.Compile(categoryName);
            WorkflowExpression.Validate(__workflow_categoryName, nameof(categoryName), required: false);
            var __workflow_costAccount = costAccount == null ? null : WorkflowExpression.Compile(costAccount);
            WorkflowExpression.Validate(__workflow_costAccount, nameof(costAccount), required: false);
            var __workflow_vatAccount = vatAccount == null ? null : WorkflowExpression.Compile(vatAccount);
            WorkflowExpression.Validate(__workflow_vatAccount, nameof(vatAccount), required: false);
            var __workflow_isActive = isActive == null ? null : WorkflowExpression.Compile(isActive);
            WorkflowExpression.Validate(__workflow_isActive, nameof(isActive), required: false);
            var __workflow_tagsNames = tagsNames == null ? null : WorkflowExpression.Compile(tagsNames);
            WorkflowExpression.Validate(__workflow_tagsNames, nameof(tagsNames), required: false);
            var __workflow_page = page == null ? null : WorkflowExpression.Compile(page);
            WorkflowExpression.Validate(__workflow_page, nameof(page), required: false);
            var __workflow_pageSize = pageSize == null ? null : WorkflowExpression.Compile(pageSize);
            WorkflowExpression.Validate(__workflow_pageSize, nameof(pageSize), required: false);
            var __workflow_sortBy = sortBy == null ? null : WorkflowExpression.Compile(sortBy);
            WorkflowExpression.Validate(__workflow_sortBy, nameof(sortBy), required: false);
            var __workflow_isDesc = isDesc == null ? null : WorkflowExpression.Compile(isDesc);
            WorkflowExpression.Validate(__workflow_isDesc, nameof(isDesc), required: false);
            return new DeferredBodyAction<ListAndPagesCountResultCategoryResponse>(() =>
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
        public IBodyWorkflowAction<ListAndPagesCountResultExpenseResponse> GetExpensesWithPaging(Expression<Func<string>> reportId = null, Expression<Func<string>> categoryId = null, Expression<Func<string>> expenseName = null, Expression<Func<string>> startDate = null, Expression<Func<string>> endDate = null, Expression<Func<int>> reportState = null, Expression<Func<string>> expenseStates = null, Expression<Func<bool>> isReimbusable = null, Expression<Func<double>> valueInCurrency = null, Expression<Func<string>> ownerId = null, Expression<Func<string>> ownerMail = null, Expression<Func<string>> ownerPayId = null, Expression<Func<string>> ownerPayId2 = null, Expression<Func<string>> ownerPayId3 = null, Expression<Func<string>> ownerPayId4 = null, Expression<Func<string>> ownerPayId5 = null, Expression<Func<string>> ownerPayId6 = null, Expression<Func<string>> projectId = null, Expression<Func<bool>> isBillable = null, Expression<Func<int>> dateFilterType = null, Expression<Func<string>> merchantCountries = null, Expression<Func<string>> currencies = null, Expression<Func<string>> fileType = null, Expression<Func<string>> reportIdShort = null, Expression<Func<string>> expenseUseTypes = null, Expression<Func<string>> supplierId = null, Expression<Func<string>> expenseIds = null, Expression<Func<string>> merchantName = null, Expression<Func<string>> vatCode = null, Expression<Func<double>> valueHTInExpenseCurrency = null, Expression<Func<double>> vatRate = null, Expression<Func<double>> vatValue = null, Expression<Func<string>> reportsIds = null, Expression<Func<int>> dateTimeOffset = null, Expression<Func<string>> tagsNames = null, Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null, Expression<Func<int>> sortBy = null, Expression<Func<bool>> isDesc = null)
        {
            var __workflow_reportId = reportId == null ? null : WorkflowExpression.Compile(reportId);
            WorkflowExpression.Validate(__workflow_reportId, nameof(reportId), required: false);
            var __workflow_categoryId = categoryId == null ? null : WorkflowExpression.Compile(categoryId);
            WorkflowExpression.Validate(__workflow_categoryId, nameof(categoryId), required: false);
            var __workflow_expenseName = expenseName == null ? null : WorkflowExpression.Compile(expenseName);
            WorkflowExpression.Validate(__workflow_expenseName, nameof(expenseName), required: false);
            var __workflow_startDate = startDate == null ? null : WorkflowExpression.Compile(startDate);
            WorkflowExpression.Validate(__workflow_startDate, nameof(startDate), required: false);
            var __workflow_endDate = endDate == null ? null : WorkflowExpression.Compile(endDate);
            WorkflowExpression.Validate(__workflow_endDate, nameof(endDate), required: false);
            var __workflow_reportState = reportState == null ? null : WorkflowExpression.Compile(reportState);
            WorkflowExpression.Validate(__workflow_reportState, nameof(reportState), required: false);
            var __workflow_expenseStates = expenseStates == null ? null : WorkflowExpression.Compile(expenseStates);
            WorkflowExpression.Validate(__workflow_expenseStates, nameof(expenseStates), required: false);
            var __workflow_isReimbusable = isReimbusable == null ? null : WorkflowExpression.Compile(isReimbusable);
            WorkflowExpression.Validate(__workflow_isReimbusable, nameof(isReimbusable), required: false);
            var __workflow_valueInCurrency = valueInCurrency == null ? null : WorkflowExpression.Compile(valueInCurrency);
            WorkflowExpression.Validate(__workflow_valueInCurrency, nameof(valueInCurrency), required: false);
            var __workflow_ownerId = ownerId == null ? null : WorkflowExpression.Compile(ownerId);
            WorkflowExpression.Validate(__workflow_ownerId, nameof(ownerId), required: false);
            var __workflow_ownerMail = ownerMail == null ? null : WorkflowExpression.Compile(ownerMail);
            WorkflowExpression.Validate(__workflow_ownerMail, nameof(ownerMail), required: false);
            var __workflow_ownerPayId = ownerPayId == null ? null : WorkflowExpression.Compile(ownerPayId);
            WorkflowExpression.Validate(__workflow_ownerPayId, nameof(ownerPayId), required: false);
            var __workflow_ownerPayId2 = ownerPayId2 == null ? null : WorkflowExpression.Compile(ownerPayId2);
            WorkflowExpression.Validate(__workflow_ownerPayId2, nameof(ownerPayId2), required: false);
            var __workflow_ownerPayId3 = ownerPayId3 == null ? null : WorkflowExpression.Compile(ownerPayId3);
            WorkflowExpression.Validate(__workflow_ownerPayId3, nameof(ownerPayId3), required: false);
            var __workflow_ownerPayId4 = ownerPayId4 == null ? null : WorkflowExpression.Compile(ownerPayId4);
            WorkflowExpression.Validate(__workflow_ownerPayId4, nameof(ownerPayId4), required: false);
            var __workflow_ownerPayId5 = ownerPayId5 == null ? null : WorkflowExpression.Compile(ownerPayId5);
            WorkflowExpression.Validate(__workflow_ownerPayId5, nameof(ownerPayId5), required: false);
            var __workflow_ownerPayId6 = ownerPayId6 == null ? null : WorkflowExpression.Compile(ownerPayId6);
            WorkflowExpression.Validate(__workflow_ownerPayId6, nameof(ownerPayId6), required: false);
            var __workflow_projectId = projectId == null ? null : WorkflowExpression.Compile(projectId);
            WorkflowExpression.Validate(__workflow_projectId, nameof(projectId), required: false);
            var __workflow_isBillable = isBillable == null ? null : WorkflowExpression.Compile(isBillable);
            WorkflowExpression.Validate(__workflow_isBillable, nameof(isBillable), required: false);
            var __workflow_dateFilterType = dateFilterType == null ? null : WorkflowExpression.Compile(dateFilterType);
            WorkflowExpression.Validate(__workflow_dateFilterType, nameof(dateFilterType), required: false);
            var __workflow_merchantCountries = merchantCountries == null ? null : WorkflowExpression.Compile(merchantCountries);
            WorkflowExpression.Validate(__workflow_merchantCountries, nameof(merchantCountries), required: false);
            var __workflow_currencies = currencies == null ? null : WorkflowExpression.Compile(currencies);
            WorkflowExpression.Validate(__workflow_currencies, nameof(currencies), required: false);
            var __workflow_fileType = fileType == null ? null : WorkflowExpression.Compile(fileType);
            WorkflowExpression.Validate(__workflow_fileType, nameof(fileType), required: false);
            var __workflow_reportIdShort = reportIdShort == null ? null : WorkflowExpression.Compile(reportIdShort);
            WorkflowExpression.Validate(__workflow_reportIdShort, nameof(reportIdShort), required: false);
            var __workflow_expenseUseTypes = expenseUseTypes == null ? null : WorkflowExpression.Compile(expenseUseTypes);
            WorkflowExpression.Validate(__workflow_expenseUseTypes, nameof(expenseUseTypes), required: false);
            var __workflow_supplierId = supplierId == null ? null : WorkflowExpression.Compile(supplierId);
            WorkflowExpression.Validate(__workflow_supplierId, nameof(supplierId), required: false);
            var __workflow_expenseIds = expenseIds == null ? null : WorkflowExpression.Compile(expenseIds);
            WorkflowExpression.Validate(__workflow_expenseIds, nameof(expenseIds), required: false);
            var __workflow_merchantName = merchantName == null ? null : WorkflowExpression.Compile(merchantName);
            WorkflowExpression.Validate(__workflow_merchantName, nameof(merchantName), required: false);
            var __workflow_vatCode = vatCode == null ? null : WorkflowExpression.Compile(vatCode);
            WorkflowExpression.Validate(__workflow_vatCode, nameof(vatCode), required: false);
            var __workflow_valueHTInExpenseCurrency = valueHTInExpenseCurrency == null ? null : WorkflowExpression.Compile(valueHTInExpenseCurrency);
            WorkflowExpression.Validate(__workflow_valueHTInExpenseCurrency, nameof(valueHTInExpenseCurrency), required: false);
            var __workflow_vatRate = vatRate == null ? null : WorkflowExpression.Compile(vatRate);
            WorkflowExpression.Validate(__workflow_vatRate, nameof(vatRate), required: false);
            var __workflow_vatValue = vatValue == null ? null : WorkflowExpression.Compile(vatValue);
            WorkflowExpression.Validate(__workflow_vatValue, nameof(vatValue), required: false);
            var __workflow_reportsIds = reportsIds == null ? null : WorkflowExpression.Compile(reportsIds);
            WorkflowExpression.Validate(__workflow_reportsIds, nameof(reportsIds), required: false);
            var __workflow_dateTimeOffset = dateTimeOffset == null ? null : WorkflowExpression.Compile(dateTimeOffset);
            WorkflowExpression.Validate(__workflow_dateTimeOffset, nameof(dateTimeOffset), required: false);
            var __workflow_tagsNames = tagsNames == null ? null : WorkflowExpression.Compile(tagsNames);
            WorkflowExpression.Validate(__workflow_tagsNames, nameof(tagsNames), required: false);
            var __workflow_page = page == null ? null : WorkflowExpression.Compile(page);
            WorkflowExpression.Validate(__workflow_page, nameof(page), required: false);
            var __workflow_pageSize = pageSize == null ? null : WorkflowExpression.Compile(pageSize);
            WorkflowExpression.Validate(__workflow_pageSize, nameof(pageSize), required: false);
            var __workflow_sortBy = sortBy == null ? null : WorkflowExpression.Compile(sortBy);
            WorkflowExpression.Validate(__workflow_sortBy, nameof(sortBy), required: false);
            var __workflow_isDesc = isDesc == null ? null : WorkflowExpression.Compile(isDesc);
            WorkflowExpression.Validate(__workflow_isDesc, nameof(isDesc), required: false);
            return new DeferredBodyAction<ListAndPagesCountResultExpenseResponse>(() =>
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
        public IBodyWorkflowAction<BaseResultProjectResponse> GetProjectDetails(Expression<Func<string>> projectId)
        {
            var __workflow_projectId = projectId == null ? null : WorkflowExpression.Compile(projectId);
            WorkflowExpression.Validate(__workflow_projectId, nameof(projectId), required: true);
            return new DeferredBodyAction<BaseResultProjectResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v2/project/{0}/", ExpressionConverter.ConvertWithUrlEncoding(__workflow_projectId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<BaseResultProjectResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expensya")]
        public IBodyWorkflowAction<ListAndPagesCountResultProjectResponse> GetProjects(Expression<Func<string>> projectName = null, Expression<Func<string>> projectIds = null, Expression<Func<string>> validatorName = null, Expression<Func<string>> projectReferenceOrExternalId = null, Expression<Func<bool>> bringAllProjects = null, Expression<Func<int>> projectUseType = null, Expression<Func<bool>> isActive = null, Expression<Func<string>> tagsNames = null, Expression<Func<string>> customFieldsIds = null, Expression<Func<string>> expenseDate = null, Expression<Func<string>> userId = null, Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null, Expression<Func<int>> sortBy = null, Expression<Func<bool>> isDesc = null)
        {
            var __workflow_projectName = projectName == null ? null : WorkflowExpression.Compile(projectName);
            WorkflowExpression.Validate(__workflow_projectName, nameof(projectName), required: false);
            var __workflow_projectIds = projectIds == null ? null : WorkflowExpression.Compile(projectIds);
            WorkflowExpression.Validate(__workflow_projectIds, nameof(projectIds), required: false);
            var __workflow_validatorName = validatorName == null ? null : WorkflowExpression.Compile(validatorName);
            WorkflowExpression.Validate(__workflow_validatorName, nameof(validatorName), required: false);
            var __workflow_projectReferenceOrExternalId = projectReferenceOrExternalId == null ? null : WorkflowExpression.Compile(projectReferenceOrExternalId);
            WorkflowExpression.Validate(__workflow_projectReferenceOrExternalId, nameof(projectReferenceOrExternalId), required: false);
            var __workflow_bringAllProjects = bringAllProjects == null ? null : WorkflowExpression.Compile(bringAllProjects);
            WorkflowExpression.Validate(__workflow_bringAllProjects, nameof(bringAllProjects), required: false);
            var __workflow_projectUseType = projectUseType == null ? null : WorkflowExpression.Compile(projectUseType);
            WorkflowExpression.Validate(__workflow_projectUseType, nameof(projectUseType), required: false);
            var __workflow_isActive = isActive == null ? null : WorkflowExpression.Compile(isActive);
            WorkflowExpression.Validate(__workflow_isActive, nameof(isActive), required: false);
            var __workflow_tagsNames = tagsNames == null ? null : WorkflowExpression.Compile(tagsNames);
            WorkflowExpression.Validate(__workflow_tagsNames, nameof(tagsNames), required: false);
            var __workflow_customFieldsIds = customFieldsIds == null ? null : WorkflowExpression.Compile(customFieldsIds);
            WorkflowExpression.Validate(__workflow_customFieldsIds, nameof(customFieldsIds), required: false);
            var __workflow_expenseDate = expenseDate == null ? null : WorkflowExpression.Compile(expenseDate);
            WorkflowExpression.Validate(__workflow_expenseDate, nameof(expenseDate), required: false);
            var __workflow_userId = userId == null ? null : WorkflowExpression.Compile(userId);
            WorkflowExpression.Validate(__workflow_userId, nameof(userId), required: false);
            var __workflow_page = page == null ? null : WorkflowExpression.Compile(page);
            WorkflowExpression.Validate(__workflow_page, nameof(page), required: false);
            var __workflow_pageSize = pageSize == null ? null : WorkflowExpression.Compile(pageSize);
            WorkflowExpression.Validate(__workflow_pageSize, nameof(pageSize), required: false);
            var __workflow_sortBy = sortBy == null ? null : WorkflowExpression.Compile(sortBy);
            WorkflowExpression.Validate(__workflow_sortBy, nameof(sortBy), required: false);
            var __workflow_isDesc = isDesc == null ? null : WorkflowExpression.Compile(isDesc);
            WorkflowExpression.Validate(__workflow_isDesc, nameof(isDesc), required: false);
            return new DeferredBodyAction<ListAndPagesCountResultProjectResponse>(() =>
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
        public IBodyWorkflowAction<BaseResultListEventResponse> GetReportHistory(Expression<Func<string>> reportId)
        {
            var __workflow_reportId = reportId == null ? null : WorkflowExpression.Compile(reportId);
            WorkflowExpression.Validate(__workflow_reportId, nameof(reportId), required: true);
            return new DeferredBodyAction<BaseResultListEventResponse>(() =>
            {
                var apiCallPath = "/api/v2/report/history/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["reportId"] = ExpressionConverter.Convert(__workflow_reportId);
                return new ApiConnectionAction<BaseResultListEventResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expensya")]
        public IBodyWorkflowAction<BaseResult> InviteUser(Expression<Func<string>> userInviteInputlastName, Expression<Func<string>> userInviteInputfirstName, Expression<Func<string>> userInviteInputmail, Expression<Func<string>> userInviteInputlanguage, Expression<Func<userInviteInputuserTypeInput>> userInviteInputuserType, Expression<Func<userInviteInputuserRoleInput>> userInviteInputuserRole, Expression<Func<string>> userInviteInputmailAlias = null, Expression<Func<string>> userInviteInputpayId = null, Expression<Func<string>> userInviteInputpayId2 = null, Expression<Func<string>> userInviteInputpayId3 = null, Expression<Func<string>> userInviteInputpayId4 = null, Expression<Func<string>> userInviteInputpayId5 = null, Expression<Func<string>> userInviteInputpayId6 = null, Expression<Func<string>> userInviteInputlocalCurrency = null, Expression<Func<string>> userInviteInputlocalCountry = null, Expression<Func<string>> userInviteInputmanagerId = null, Expression<Func<string>> userInviteInputreviewerId = null, Expression<Func<string>> userInviteInputvendor = null, Expression<Func<string>> userInviteInputdefaultProjectId = null, Expression<Func<string>> userInviteInputiKRatesId = null, Expression<Func<ValidatorInput[]>> userInviteInputadditionalValidators = null, Expression<Func<string[]>> userInviteInputtagsToAssign = null)
        {
            var __workflow_userInviteInputlastName = userInviteInputlastName == null ? null : WorkflowExpression.Compile(userInviteInputlastName);
            WorkflowExpression.Validate(__workflow_userInviteInputlastName, nameof(userInviteInputlastName), required: true);
            var __workflow_userInviteInputfirstName = userInviteInputfirstName == null ? null : WorkflowExpression.Compile(userInviteInputfirstName);
            WorkflowExpression.Validate(__workflow_userInviteInputfirstName, nameof(userInviteInputfirstName), required: true);
            var __workflow_userInviteInputmail = userInviteInputmail == null ? null : WorkflowExpression.Compile(userInviteInputmail);
            WorkflowExpression.Validate(__workflow_userInviteInputmail, nameof(userInviteInputmail), required: true);
            var __workflow_userInviteInputlanguage = userInviteInputlanguage == null ? null : WorkflowExpression.Compile(userInviteInputlanguage);
            WorkflowExpression.Validate(__workflow_userInviteInputlanguage, nameof(userInviteInputlanguage), required: true);
            var __workflow_userInviteInputuserType = userInviteInputuserType == null ? null : WorkflowExpression.Compile(userInviteInputuserType);
            WorkflowExpression.Validate(__workflow_userInviteInputuserType, nameof(userInviteInputuserType), required: true);
            var __workflow_userInviteInputuserRole = userInviteInputuserRole == null ? null : WorkflowExpression.Compile(userInviteInputuserRole);
            WorkflowExpression.Validate(__workflow_userInviteInputuserRole, nameof(userInviteInputuserRole), required: true);
            var __workflow_userInviteInputmailAlias = userInviteInputmailAlias == null ? null : WorkflowExpression.Compile(userInviteInputmailAlias);
            WorkflowExpression.Validate(__workflow_userInviteInputmailAlias, nameof(userInviteInputmailAlias), required: false);
            var __workflow_userInviteInputpayId = userInviteInputpayId == null ? null : WorkflowExpression.Compile(userInviteInputpayId);
            WorkflowExpression.Validate(__workflow_userInviteInputpayId, nameof(userInviteInputpayId), required: false);
            var __workflow_userInviteInputpayId2 = userInviteInputpayId2 == null ? null : WorkflowExpression.Compile(userInviteInputpayId2);
            WorkflowExpression.Validate(__workflow_userInviteInputpayId2, nameof(userInviteInputpayId2), required: false);
            var __workflow_userInviteInputpayId3 = userInviteInputpayId3 == null ? null : WorkflowExpression.Compile(userInviteInputpayId3);
            WorkflowExpression.Validate(__workflow_userInviteInputpayId3, nameof(userInviteInputpayId3), required: false);
            var __workflow_userInviteInputpayId4 = userInviteInputpayId4 == null ? null : WorkflowExpression.Compile(userInviteInputpayId4);
            WorkflowExpression.Validate(__workflow_userInviteInputpayId4, nameof(userInviteInputpayId4), required: false);
            var __workflow_userInviteInputpayId5 = userInviteInputpayId5 == null ? null : WorkflowExpression.Compile(userInviteInputpayId5);
            WorkflowExpression.Validate(__workflow_userInviteInputpayId5, nameof(userInviteInputpayId5), required: false);
            var __workflow_userInviteInputpayId6 = userInviteInputpayId6 == null ? null : WorkflowExpression.Compile(userInviteInputpayId6);
            WorkflowExpression.Validate(__workflow_userInviteInputpayId6, nameof(userInviteInputpayId6), required: false);
            var __workflow_userInviteInputlocalCurrency = userInviteInputlocalCurrency == null ? null : WorkflowExpression.Compile(userInviteInputlocalCurrency);
            WorkflowExpression.Validate(__workflow_userInviteInputlocalCurrency, nameof(userInviteInputlocalCurrency), required: false);
            var __workflow_userInviteInputlocalCountry = userInviteInputlocalCountry == null ? null : WorkflowExpression.Compile(userInviteInputlocalCountry);
            WorkflowExpression.Validate(__workflow_userInviteInputlocalCountry, nameof(userInviteInputlocalCountry), required: false);
            var __workflow_userInviteInputmanagerId = userInviteInputmanagerId == null ? null : WorkflowExpression.Compile(userInviteInputmanagerId);
            WorkflowExpression.Validate(__workflow_userInviteInputmanagerId, nameof(userInviteInputmanagerId), required: false);
            var __workflow_userInviteInputreviewerId = userInviteInputreviewerId == null ? null : WorkflowExpression.Compile(userInviteInputreviewerId);
            WorkflowExpression.Validate(__workflow_userInviteInputreviewerId, nameof(userInviteInputreviewerId), required: false);
            var __workflow_userInviteInputvendor = userInviteInputvendor == null ? null : WorkflowExpression.Compile(userInviteInputvendor);
            WorkflowExpression.Validate(__workflow_userInviteInputvendor, nameof(userInviteInputvendor), required: false);
            var __workflow_userInviteInputdefaultProjectId = userInviteInputdefaultProjectId == null ? null : WorkflowExpression.Compile(userInviteInputdefaultProjectId);
            WorkflowExpression.Validate(__workflow_userInviteInputdefaultProjectId, nameof(userInviteInputdefaultProjectId), required: false);
            var __workflow_userInviteInputiKRatesId = userInviteInputiKRatesId == null ? null : WorkflowExpression.Compile(userInviteInputiKRatesId);
            WorkflowExpression.Validate(__workflow_userInviteInputiKRatesId, nameof(userInviteInputiKRatesId), required: false);
            var __workflow_userInviteInputadditionalValidators = userInviteInputadditionalValidators == null ? null : WorkflowExpression.Compile(userInviteInputadditionalValidators);
            WorkflowExpression.Validate(__workflow_userInviteInputadditionalValidators, nameof(userInviteInputadditionalValidators), required: false);
            var __workflow_userInviteInputtagsToAssign = userInviteInputtagsToAssign == null ? null : WorkflowExpression.Compile(userInviteInputtagsToAssign);
            WorkflowExpression.Validate(__workflow_userInviteInputtagsToAssign, nameof(userInviteInputtagsToAssign), required: false);
            return new DeferredBodyAction<BaseResult>(() =>
            {
                var apiCallPath = "/api/v2/user/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var userInviteInput = new JObject();
                var userInviteInputpropCount = 0;
                userInviteInputpropCount++;
                userInviteInput["LastName"] = ExpressionConverter.ConvertO(__workflow_userInviteInputlastName);
                userInviteInputpropCount++;
                userInviteInput["FirstName"] = ExpressionConverter.ConvertO(__workflow_userInviteInputfirstName);
                userInviteInputpropCount++;
                userInviteInput["Mail"] = ExpressionConverter.ConvertO(__workflow_userInviteInputmail);
                if (__workflow_userInviteInputmailAlias != null)
                {
                    userInviteInput["MailAlias"] = ExpressionConverter.ConvertO(__workflow_userInviteInputmailAlias);
                    userInviteInputpropCount++;
                }

                if (__workflow_userInviteInputpayId != null)
                {
                    userInviteInput["PayId"] = ExpressionConverter.ConvertO(__workflow_userInviteInputpayId);
                    userInviteInputpropCount++;
                }

                if (__workflow_userInviteInputpayId2 != null)
                {
                    userInviteInput["PayId2"] = ExpressionConverter.ConvertO(__workflow_userInviteInputpayId2);
                    userInviteInputpropCount++;
                }

                if (__workflow_userInviteInputpayId3 != null)
                {
                    userInviteInput["PayId3"] = ExpressionConverter.ConvertO(__workflow_userInviteInputpayId3);
                    userInviteInputpropCount++;
                }

                if (__workflow_userInviteInputpayId4 != null)
                {
                    userInviteInput["PayId4"] = ExpressionConverter.ConvertO(__workflow_userInviteInputpayId4);
                    userInviteInputpropCount++;
                }

                if (__workflow_userInviteInputpayId5 != null)
                {
                    userInviteInput["PayId5"] = ExpressionConverter.ConvertO(__workflow_userInviteInputpayId5);
                    userInviteInputpropCount++;
                }

                if (__workflow_userInviteInputpayId6 != null)
                {
                    userInviteInput["PayId6"] = ExpressionConverter.ConvertO(__workflow_userInviteInputpayId6);
                    userInviteInputpropCount++;
                }

                userInviteInputpropCount++;
                userInviteInput["Language"] = ExpressionConverter.ConvertO(__workflow_userInviteInputlanguage);
                if (__workflow_userInviteInputlocalCurrency != null)
                {
                    userInviteInput["LocalCurrency"] = ExpressionConverter.ConvertO(__workflow_userInviteInputlocalCurrency);
                    userInviteInputpropCount++;
                }

                if (__workflow_userInviteInputlocalCountry != null)
                {
                    userInviteInput["LocalCountry"] = ExpressionConverter.ConvertO(__workflow_userInviteInputlocalCountry);
                    userInviteInputpropCount++;
                }

                if (__workflow_userInviteInputmanagerId != null)
                {
                    userInviteInput["ManagerId"] = ExpressionConverter.ConvertO(__workflow_userInviteInputmanagerId);
                    userInviteInputpropCount++;
                }

                if (__workflow_userInviteInputreviewerId != null)
                {
                    userInviteInput["ReviewerId"] = ExpressionConverter.ConvertO(__workflow_userInviteInputreviewerId);
                    userInviteInputpropCount++;
                }

                userInviteInputpropCount++;
                userInviteInput["UserType"] = ExpressionConverter.ConvertO(__workflow_userInviteInputuserType);
                if (__workflow_userInviteInputvendor != null)
                {
                    userInviteInput["Vendor"] = ExpressionConverter.ConvertO(__workflow_userInviteInputvendor);
                    userInviteInputpropCount++;
                }

                userInviteInputpropCount++;
                userInviteInput["UserRole"] = ExpressionConverter.ConvertO(__workflow_userInviteInputuserRole);
                if (__workflow_userInviteInputdefaultProjectId != null)
                {
                    userInviteInput["DefaultProjectId"] = ExpressionConverter.ConvertO(__workflow_userInviteInputdefaultProjectId);
                    userInviteInputpropCount++;
                }

                if (__workflow_userInviteInputiKRatesId != null)
                {
                    userInviteInput["IKRatesId"] = ExpressionConverter.ConvertO(__workflow_userInviteInputiKRatesId);
                    userInviteInputpropCount++;
                }

                if (__workflow_userInviteInputadditionalValidators != null)
                {
                    userInviteInput["AdditionalValidators"] = ExpressionConverter.ConvertO(__workflow_userInviteInputadditionalValidators);
                    userInviteInputpropCount++;
                }

                if (__workflow_userInviteInputtagsToAssign != null)
                {
                    userInviteInput["TagsToAssign"] = ExpressionConverter.ConvertO(__workflow_userInviteInputtagsToAssign);
                    userInviteInputpropCount++;
                }

                if (userInviteInputpropCount > 0)
                {
                    callPayload.Body = userInviteInput;
                }

                return new ApiConnectionAction<BaseResult>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expensya")]
        public IBodyWorkflowAction<LoginResponse> RefreshUserToken()
        {
            var apiCallPath = "/api/v2/refreshUserToken/";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<LoginResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expensya")]
        public IBodyWorkflowAction<BaseResult> UpateUser(Expression<Func<string>> userId, Expression<Func<bool>> shouldUpdateValidators, Expression<Func<string>> userUpdateInputlastName = null, Expression<Func<string>> userUpdateInputfirstName = null, Expression<Func<string>> userUpdateInputmail = null, Expression<Func<string>> userUpdateInputmailAlias = null, Expression<Func<string>> userUpdateInputpayId = null, Expression<Func<string>> userUpdateInputpayId2 = null, Expression<Func<string>> userUpdateInputpayId3 = null, Expression<Func<string>> userUpdateInputpayId4 = null, Expression<Func<string>> userUpdateInputpayId5 = null, Expression<Func<string>> userUpdateInputpayId6 = null, Expression<Func<string>> userUpdateInputlanguage = null, Expression<Func<string>> userUpdateInputlocalCurrency = null, Expression<Func<string>> userUpdateInputlocalCountry = null, Expression<Func<string>> userUpdateInputmanagerId = null, Expression<Func<string>> userUpdateInputreviewerId = null, Expression<Func<userUpdateInputuserTypeInput>> userUpdateInputuserType = null, Expression<Func<string>> userUpdateInputvendor = null, Expression<Func<userUpdateInputuserRoleInput>> userUpdateInputuserRole = null, Expression<Func<string>> userUpdateInputjobTitle = null, Expression<Func<bool>> userUpdateInputcanAddPurchase = null, Expression<Func<string>> userUpdateInputdefaultProjectId = null, Expression<Func<string>> userUpdateInputiKRatesId = null, Expression<Func<ValidatorInput[]>> userUpdateInputadditionalValidators = null, Expression<Func<string[]>> userUpdateInputtagsToAssign = null, Expression<Func<string[]>> userUpdateInputtagsToUnassign = null)
        {
            var __workflow_userId = userId == null ? null : WorkflowExpression.Compile(userId);
            WorkflowExpression.Validate(__workflow_userId, nameof(userId), required: true);
            var __workflow_shouldUpdateValidators = shouldUpdateValidators == null ? null : WorkflowExpression.Compile(shouldUpdateValidators);
            WorkflowExpression.Validate(__workflow_shouldUpdateValidators, nameof(shouldUpdateValidators), required: true);
            var __workflow_userUpdateInputlastName = userUpdateInputlastName == null ? null : WorkflowExpression.Compile(userUpdateInputlastName);
            WorkflowExpression.Validate(__workflow_userUpdateInputlastName, nameof(userUpdateInputlastName), required: false);
            var __workflow_userUpdateInputfirstName = userUpdateInputfirstName == null ? null : WorkflowExpression.Compile(userUpdateInputfirstName);
            WorkflowExpression.Validate(__workflow_userUpdateInputfirstName, nameof(userUpdateInputfirstName), required: false);
            var __workflow_userUpdateInputmail = userUpdateInputmail == null ? null : WorkflowExpression.Compile(userUpdateInputmail);
            WorkflowExpression.Validate(__workflow_userUpdateInputmail, nameof(userUpdateInputmail), required: false);
            var __workflow_userUpdateInputmailAlias = userUpdateInputmailAlias == null ? null : WorkflowExpression.Compile(userUpdateInputmailAlias);
            WorkflowExpression.Validate(__workflow_userUpdateInputmailAlias, nameof(userUpdateInputmailAlias), required: false);
            var __workflow_userUpdateInputpayId = userUpdateInputpayId == null ? null : WorkflowExpression.Compile(userUpdateInputpayId);
            WorkflowExpression.Validate(__workflow_userUpdateInputpayId, nameof(userUpdateInputpayId), required: false);
            var __workflow_userUpdateInputpayId2 = userUpdateInputpayId2 == null ? null : WorkflowExpression.Compile(userUpdateInputpayId2);
            WorkflowExpression.Validate(__workflow_userUpdateInputpayId2, nameof(userUpdateInputpayId2), required: false);
            var __workflow_userUpdateInputpayId3 = userUpdateInputpayId3 == null ? null : WorkflowExpression.Compile(userUpdateInputpayId3);
            WorkflowExpression.Validate(__workflow_userUpdateInputpayId3, nameof(userUpdateInputpayId3), required: false);
            var __workflow_userUpdateInputpayId4 = userUpdateInputpayId4 == null ? null : WorkflowExpression.Compile(userUpdateInputpayId4);
            WorkflowExpression.Validate(__workflow_userUpdateInputpayId4, nameof(userUpdateInputpayId4), required: false);
            var __workflow_userUpdateInputpayId5 = userUpdateInputpayId5 == null ? null : WorkflowExpression.Compile(userUpdateInputpayId5);
            WorkflowExpression.Validate(__workflow_userUpdateInputpayId5, nameof(userUpdateInputpayId5), required: false);
            var __workflow_userUpdateInputpayId6 = userUpdateInputpayId6 == null ? null : WorkflowExpression.Compile(userUpdateInputpayId6);
            WorkflowExpression.Validate(__workflow_userUpdateInputpayId6, nameof(userUpdateInputpayId6), required: false);
            var __workflow_userUpdateInputlanguage = userUpdateInputlanguage == null ? null : WorkflowExpression.Compile(userUpdateInputlanguage);
            WorkflowExpression.Validate(__workflow_userUpdateInputlanguage, nameof(userUpdateInputlanguage), required: false);
            var __workflow_userUpdateInputlocalCurrency = userUpdateInputlocalCurrency == null ? null : WorkflowExpression.Compile(userUpdateInputlocalCurrency);
            WorkflowExpression.Validate(__workflow_userUpdateInputlocalCurrency, nameof(userUpdateInputlocalCurrency), required: false);
            var __workflow_userUpdateInputlocalCountry = userUpdateInputlocalCountry == null ? null : WorkflowExpression.Compile(userUpdateInputlocalCountry);
            WorkflowExpression.Validate(__workflow_userUpdateInputlocalCountry, nameof(userUpdateInputlocalCountry), required: false);
            var __workflow_userUpdateInputmanagerId = userUpdateInputmanagerId == null ? null : WorkflowExpression.Compile(userUpdateInputmanagerId);
            WorkflowExpression.Validate(__workflow_userUpdateInputmanagerId, nameof(userUpdateInputmanagerId), required: false);
            var __workflow_userUpdateInputreviewerId = userUpdateInputreviewerId == null ? null : WorkflowExpression.Compile(userUpdateInputreviewerId);
            WorkflowExpression.Validate(__workflow_userUpdateInputreviewerId, nameof(userUpdateInputreviewerId), required: false);
            var __workflow_userUpdateInputuserType = userUpdateInputuserType == null ? null : WorkflowExpression.Compile(userUpdateInputuserType);
            WorkflowExpression.Validate(__workflow_userUpdateInputuserType, nameof(userUpdateInputuserType), required: false);
            var __workflow_userUpdateInputvendor = userUpdateInputvendor == null ? null : WorkflowExpression.Compile(userUpdateInputvendor);
            WorkflowExpression.Validate(__workflow_userUpdateInputvendor, nameof(userUpdateInputvendor), required: false);
            var __workflow_userUpdateInputuserRole = userUpdateInputuserRole == null ? null : WorkflowExpression.Compile(userUpdateInputuserRole);
            WorkflowExpression.Validate(__workflow_userUpdateInputuserRole, nameof(userUpdateInputuserRole), required: false);
            var __workflow_userUpdateInputjobTitle = userUpdateInputjobTitle == null ? null : WorkflowExpression.Compile(userUpdateInputjobTitle);
            WorkflowExpression.Validate(__workflow_userUpdateInputjobTitle, nameof(userUpdateInputjobTitle), required: false);
            var __workflow_userUpdateInputcanAddPurchase = userUpdateInputcanAddPurchase == null ? null : WorkflowExpression.Compile(userUpdateInputcanAddPurchase);
            WorkflowExpression.Validate(__workflow_userUpdateInputcanAddPurchase, nameof(userUpdateInputcanAddPurchase), required: false);
            var __workflow_userUpdateInputdefaultProjectId = userUpdateInputdefaultProjectId == null ? null : WorkflowExpression.Compile(userUpdateInputdefaultProjectId);
            WorkflowExpression.Validate(__workflow_userUpdateInputdefaultProjectId, nameof(userUpdateInputdefaultProjectId), required: false);
            var __workflow_userUpdateInputiKRatesId = userUpdateInputiKRatesId == null ? null : WorkflowExpression.Compile(userUpdateInputiKRatesId);
            WorkflowExpression.Validate(__workflow_userUpdateInputiKRatesId, nameof(userUpdateInputiKRatesId), required: false);
            var __workflow_userUpdateInputadditionalValidators = userUpdateInputadditionalValidators == null ? null : WorkflowExpression.Compile(userUpdateInputadditionalValidators);
            WorkflowExpression.Validate(__workflow_userUpdateInputadditionalValidators, nameof(userUpdateInputadditionalValidators), required: false);
            var __workflow_userUpdateInputtagsToAssign = userUpdateInputtagsToAssign == null ? null : WorkflowExpression.Compile(userUpdateInputtagsToAssign);
            WorkflowExpression.Validate(__workflow_userUpdateInputtagsToAssign, nameof(userUpdateInputtagsToAssign), required: false);
            var __workflow_userUpdateInputtagsToUnassign = userUpdateInputtagsToUnassign == null ? null : WorkflowExpression.Compile(userUpdateInputtagsToUnassign);
            WorkflowExpression.Validate(__workflow_userUpdateInputtagsToUnassign, nameof(userUpdateInputtagsToUnassign), required: false);
            return new DeferredBodyAction<BaseResult>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v2/user/{0}/", ExpressionConverter.ConvertWithUrlEncoding(__workflow_userId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["shouldUpdateValidators"] = ExpressionConverter.Convert(__workflow_shouldUpdateValidators);
                var userUpdateInput = new JObject();
                var userUpdateInputpropCount = 0;
                if (__workflow_userUpdateInputlastName != null)
                {
                    userUpdateInput["LastName"] = ExpressionConverter.ConvertO(__workflow_userUpdateInputlastName);
                    userUpdateInputpropCount++;
                }

                if (__workflow_userUpdateInputfirstName != null)
                {
                    userUpdateInput["FirstName"] = ExpressionConverter.ConvertO(__workflow_userUpdateInputfirstName);
                    userUpdateInputpropCount++;
                }

                if (__workflow_userUpdateInputmail != null)
                {
                    userUpdateInput["Mail"] = ExpressionConverter.ConvertO(__workflow_userUpdateInputmail);
                    userUpdateInputpropCount++;
                }

                if (__workflow_userUpdateInputmailAlias != null)
                {
                    userUpdateInput["MailAlias"] = ExpressionConverter.ConvertO(__workflow_userUpdateInputmailAlias);
                    userUpdateInputpropCount++;
                }

                if (__workflow_userUpdateInputpayId != null)
                {
                    userUpdateInput["PayId"] = ExpressionConverter.ConvertO(__workflow_userUpdateInputpayId);
                    userUpdateInputpropCount++;
                }

                if (__workflow_userUpdateInputpayId2 != null)
                {
                    userUpdateInput["PayId2"] = ExpressionConverter.ConvertO(__workflow_userUpdateInputpayId2);
                    userUpdateInputpropCount++;
                }

                if (__workflow_userUpdateInputpayId3 != null)
                {
                    userUpdateInput["PayId3"] = ExpressionConverter.ConvertO(__workflow_userUpdateInputpayId3);
                    userUpdateInputpropCount++;
                }

                if (__workflow_userUpdateInputpayId4 != null)
                {
                    userUpdateInput["PayId4"] = ExpressionConverter.ConvertO(__workflow_userUpdateInputpayId4);
                    userUpdateInputpropCount++;
                }

                if (__workflow_userUpdateInputpayId5 != null)
                {
                    userUpdateInput["PayId5"] = ExpressionConverter.ConvertO(__workflow_userUpdateInputpayId5);
                    userUpdateInputpropCount++;
                }

                if (__workflow_userUpdateInputpayId6 != null)
                {
                    userUpdateInput["PayId6"] = ExpressionConverter.ConvertO(__workflow_userUpdateInputpayId6);
                    userUpdateInputpropCount++;
                }

                if (__workflow_userUpdateInputlanguage != null)
                {
                    userUpdateInput["Language"] = ExpressionConverter.ConvertO(__workflow_userUpdateInputlanguage);
                    userUpdateInputpropCount++;
                }

                if (__workflow_userUpdateInputlocalCurrency != null)
                {
                    userUpdateInput["LocalCurrency"] = ExpressionConverter.ConvertO(__workflow_userUpdateInputlocalCurrency);
                    userUpdateInputpropCount++;
                }

                if (__workflow_userUpdateInputlocalCountry != null)
                {
                    userUpdateInput["LocalCountry"] = ExpressionConverter.ConvertO(__workflow_userUpdateInputlocalCountry);
                    userUpdateInputpropCount++;
                }

                if (__workflow_userUpdateInputmanagerId != null)
                {
                    userUpdateInput["Manager_Id"] = ExpressionConverter.ConvertO(__workflow_userUpdateInputmanagerId);
                    userUpdateInputpropCount++;
                }

                if (__workflow_userUpdateInputreviewerId != null)
                {
                    userUpdateInput["Reviewer_Id"] = ExpressionConverter.ConvertO(__workflow_userUpdateInputreviewerId);
                    userUpdateInputpropCount++;
                }

                if (__workflow_userUpdateInputuserType != null)
                {
                    userUpdateInput["UserType"] = ExpressionConverter.ConvertO(__workflow_userUpdateInputuserType);
                    userUpdateInputpropCount++;
                }

                if (__workflow_userUpdateInputvendor != null)
                {
                    userUpdateInput["Vendor"] = ExpressionConverter.ConvertO(__workflow_userUpdateInputvendor);
                    userUpdateInputpropCount++;
                }

                if (__workflow_userUpdateInputuserRole != null)
                {
                    userUpdateInput["UserRole"] = ExpressionConverter.ConvertO(__workflow_userUpdateInputuserRole);
                    userUpdateInputpropCount++;
                }

                if (__workflow_userUpdateInputjobTitle != null)
                {
                    userUpdateInput["JobTitle"] = ExpressionConverter.ConvertO(__workflow_userUpdateInputjobTitle);
                    userUpdateInputpropCount++;
                }

                if (__workflow_userUpdateInputcanAddPurchase != null)
                {
                    userUpdateInput["CanAddPurchase"] = ExpressionConverter.ConvertO(__workflow_userUpdateInputcanAddPurchase);
                    userUpdateInputpropCount++;
                }

                if (__workflow_userUpdateInputdefaultProjectId != null)
                {
                    userUpdateInput["DefaultProjectId"] = ExpressionConverter.ConvertO(__workflow_userUpdateInputdefaultProjectId);
                    userUpdateInputpropCount++;
                }

                if (__workflow_userUpdateInputiKRatesId != null)
                {
                    userUpdateInput["IKRates_Id"] = ExpressionConverter.ConvertO(__workflow_userUpdateInputiKRatesId);
                    userUpdateInputpropCount++;
                }

                if (__workflow_userUpdateInputadditionalValidators != null)
                {
                    userUpdateInput["AdditionalValidators"] = ExpressionConverter.ConvertO(__workflow_userUpdateInputadditionalValidators);
                    userUpdateInputpropCount++;
                }

                if (__workflow_userUpdateInputtagsToAssign != null)
                {
                    userUpdateInput["TagsToAssign"] = ExpressionConverter.ConvertO(__workflow_userUpdateInputtagsToAssign);
                    userUpdateInputpropCount++;
                }

                if (__workflow_userUpdateInputtagsToUnassign != null)
                {
                    userUpdateInput["TagsToUnassign"] = ExpressionConverter.ConvertO(__workflow_userUpdateInputtagsToUnassign);
                    userUpdateInputpropCount++;
                }

                if (userUpdateInputpropCount > 0)
                {
                    callPayload.Body = userUpdateInput;
                }

                return new ApiConnectionAction<BaseResult>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expensya")]
        public IBodyWorkflowAction<BaseResultListAddOrUpdateEntityResult> UpdateProjectState(Expression<Func<string[]>> updateProjectStateInputitemIds, Expression<Func<bool>> updateProjectStateInputprojectState)
        {
            var __workflow_updateProjectStateInputitemIds = updateProjectStateInputitemIds == null ? null : WorkflowExpression.Compile(updateProjectStateInputitemIds);
            WorkflowExpression.Validate(__workflow_updateProjectStateInputitemIds, nameof(updateProjectStateInputitemIds), required: true);
            var __workflow_updateProjectStateInputprojectState = updateProjectStateInputprojectState == null ? null : WorkflowExpression.Compile(updateProjectStateInputprojectState);
            WorkflowExpression.Validate(__workflow_updateProjectStateInputprojectState, nameof(updateProjectStateInputprojectState), required: true);
            return new DeferredBodyAction<BaseResultListAddOrUpdateEntityResult>(() =>
            {
                var apiCallPath = "/api/v2/projects/states/";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var updateProjectStateInput = new JObject();
                var updateProjectStateInputpropCount = 0;
                updateProjectStateInputpropCount++;
                updateProjectStateInput["ItemIds"] = ExpressionConverter.ConvertO(__workflow_updateProjectStateInputitemIds);
                updateProjectStateInputpropCount++;
                updateProjectStateInput["ProjectState"] = ExpressionConverter.ConvertO(__workflow_updateProjectStateInputprojectState);
                if (updateProjectStateInputpropCount > 0)
                {
                    callPayload.Body = updateProjectStateInput;
                }

                return new ApiConnectionAction<BaseResultListAddOrUpdateEntityResult>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expensya")]
        public IBodyWorkflowAction<BaseResultListUpdateUserResult> UpdateUsersState(Expression<Func<UpdateUserStateInput[]>> updateUserStateInputArray = null)
        {
            var __workflow_updateUserStateInputArray = updateUserStateInputArray == null ? null : WorkflowExpression.Compile(updateUserStateInputArray);
            WorkflowExpression.Validate(__workflow_updateUserStateInputArray, nameof(updateUserStateInputArray), required: false);
            return new DeferredBodyAction<BaseResultListUpdateUserResult>(() =>
            {
                var apiCallPath = "/api/v2/users/state/";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BaseResultExportResponseResultCodeType
    {
        [EnumMember(Value = "0")]
        _0,
        [EnumMember(Value = "1")]
        _1,
        [EnumMember(Value = "2")]
        _2,
        [EnumMember(Value = "3")]
        _3,
        [EnumMember(Value = "4")]
        _4,
        [EnumMember(Value = "5")]
        _5,
        [EnumMember(Value = "6")]
        _6,
        [EnumMember(Value = "7")]
        _7,
        [EnumMember(Value = "10")]
        _10,
        [EnumMember(Value = "11")]
        _11,
        [EnumMember(Value = "12")]
        _12,
        [EnumMember(Value = "20")]
        _20,
        [EnumMember(Value = "30")]
        _30,
        [EnumMember(Value = "50")]
        _50,
        [EnumMember(Value = "60")]
        _60,
        [EnumMember(Value = "70")]
        _70,
        [EnumMember(Value = "71")]
        _71,
        [EnumMember(Value = "80")]
        _80,
        [EnumMember(Value = "90")]
        _90,
        [EnumMember(Value = "91")]
        _91,
        [EnumMember(Value = "92")]
        _92,
        [EnumMember(Value = "96")]
        _96,
        [EnumMember(Value = "97")]
        _97,
        [EnumMember(Value = "98")]
        _98,
        [EnumMember(Value = "99")]
        _99,
        [EnumMember(Value = "100")]
        _100,
        [EnumMember(Value = "101")]
        _101,
        [EnumMember(Value = "303")]
        _303,
        [EnumMember(Value = "400")]
        _400,
        [EnumMember(Value = "401")]
        _401,
        [EnumMember(Value = "404")]
        _404,
        [EnumMember(Value = "901")]
        _901,
        [EnumMember(Value = "902")]
        _902,
        [EnumMember(Value = "903")]
        _903,
        [EnumMember(Value = "910")]
        _910,
        [EnumMember(Value = "913")]
        _913,
        [EnumMember(Value = "1001")]
        _1001,
        [EnumMember(Value = "1004")]
        _1004,
        [EnumMember(Value = "1005")]
        _1005,
        [EnumMember(Value = "1006")]
        _1006,
        [EnumMember(Value = "2000")]
        _2000,
        [EnumMember(Value = "2001")]
        _2001,
        [EnumMember(Value = "2002")]
        _2002,
        [EnumMember(Value = "2003")]
        _2003,
        [EnumMember(Value = "2004")]
        _2004,
        [EnumMember(Value = "2005")]
        _2005,
        [EnumMember(Value = "2007")]
        _2007,
        [EnumMember(Value = "2008")]
        _2008
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BaseResultListExportFormatResponseResultCodeType
    {
        [EnumMember(Value = "0")]
        _0,
        [EnumMember(Value = "1")]
        _1,
        [EnumMember(Value = "2")]
        _2,
        [EnumMember(Value = "3")]
        _3,
        [EnumMember(Value = "4")]
        _4,
        [EnumMember(Value = "5")]
        _5,
        [EnumMember(Value = "6")]
        _6,
        [EnumMember(Value = "7")]
        _7,
        [EnumMember(Value = "10")]
        _10,
        [EnumMember(Value = "11")]
        _11,
        [EnumMember(Value = "12")]
        _12,
        [EnumMember(Value = "20")]
        _20,
        [EnumMember(Value = "30")]
        _30,
        [EnumMember(Value = "50")]
        _50,
        [EnumMember(Value = "60")]
        _60,
        [EnumMember(Value = "70")]
        _70,
        [EnumMember(Value = "71")]
        _71,
        [EnumMember(Value = "80")]
        _80,
        [EnumMember(Value = "90")]
        _90,
        [EnumMember(Value = "91")]
        _91,
        [EnumMember(Value = "92")]
        _92,
        [EnumMember(Value = "96")]
        _96,
        [EnumMember(Value = "97")]
        _97,
        [EnumMember(Value = "98")]
        _98,
        [EnumMember(Value = "99")]
        _99,
        [EnumMember(Value = "100")]
        _100,
        [EnumMember(Value = "101")]
        _101,
        [EnumMember(Value = "303")]
        _303,
        [EnumMember(Value = "400")]
        _400,
        [EnumMember(Value = "401")]
        _401,
        [EnumMember(Value = "404")]
        _404,
        [EnumMember(Value = "901")]
        _901,
        [EnumMember(Value = "902")]
        _902,
        [EnumMember(Value = "903")]
        _903,
        [EnumMember(Value = "910")]
        _910,
        [EnumMember(Value = "913")]
        _913,
        [EnumMember(Value = "1001")]
        _1001,
        [EnumMember(Value = "1004")]
        _1004,
        [EnumMember(Value = "1005")]
        _1005,
        [EnumMember(Value = "1006")]
        _1006,
        [EnumMember(Value = "2000")]
        _2000,
        [EnumMember(Value = "2001")]
        _2001,
        [EnumMember(Value = "2002")]
        _2002,
        [EnumMember(Value = "2003")]
        _2003,
        [EnumMember(Value = "2004")]
        _2004,
        [EnumMember(Value = "2005")]
        _2005,
        [EnumMember(Value = "2007")]
        _2007,
        [EnumMember(Value = "2008")]
        _2008
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum AddOrUpdateEntityResultResultCodeType
    {
        [EnumMember(Value = "0")]
        _0,
        [EnumMember(Value = "1")]
        _1,
        [EnumMember(Value = "2")]
        _2,
        [EnumMember(Value = "3")]
        _3,
        [EnumMember(Value = "4")]
        _4,
        [EnumMember(Value = "5")]
        _5,
        [EnumMember(Value = "6")]
        _6,
        [EnumMember(Value = "7")]
        _7,
        [EnumMember(Value = "10")]
        _10,
        [EnumMember(Value = "11")]
        _11,
        [EnumMember(Value = "12")]
        _12,
        [EnumMember(Value = "20")]
        _20,
        [EnumMember(Value = "30")]
        _30,
        [EnumMember(Value = "50")]
        _50,
        [EnumMember(Value = "60")]
        _60,
        [EnumMember(Value = "70")]
        _70,
        [EnumMember(Value = "71")]
        _71,
        [EnumMember(Value = "80")]
        _80,
        [EnumMember(Value = "90")]
        _90,
        [EnumMember(Value = "91")]
        _91,
        [EnumMember(Value = "92")]
        _92,
        [EnumMember(Value = "96")]
        _96,
        [EnumMember(Value = "97")]
        _97,
        [EnumMember(Value = "98")]
        _98,
        [EnumMember(Value = "99")]
        _99,
        [EnumMember(Value = "100")]
        _100,
        [EnumMember(Value = "101")]
        _101,
        [EnumMember(Value = "303")]
        _303,
        [EnumMember(Value = "400")]
        _400,
        [EnumMember(Value = "401")]
        _401,
        [EnumMember(Value = "404")]
        _404,
        [EnumMember(Value = "901")]
        _901,
        [EnumMember(Value = "902")]
        _902,
        [EnumMember(Value = "903")]
        _903,
        [EnumMember(Value = "910")]
        _910,
        [EnumMember(Value = "913")]
        _913,
        [EnumMember(Value = "1001")]
        _1001,
        [EnumMember(Value = "1004")]
        _1004,
        [EnumMember(Value = "1005")]
        _1005,
        [EnumMember(Value = "1006")]
        _1006,
        [EnumMember(Value = "2000")]
        _2000,
        [EnumMember(Value = "2001")]
        _2001,
        [EnumMember(Value = "2002")]
        _2002,
        [EnumMember(Value = "2003")]
        _2003,
        [EnumMember(Value = "2004")]
        _2004,
        [EnumMember(Value = "2005")]
        _2005,
        [EnumMember(Value = "2007")]
        _2007,
        [EnumMember(Value = "2008")]
        _2008
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BaseResultListAddOrUpdateEntityResultResultCodeType
    {
        [EnumMember(Value = "0")]
        _0,
        [EnumMember(Value = "1")]
        _1,
        [EnumMember(Value = "2")]
        _2,
        [EnumMember(Value = "3")]
        _3,
        [EnumMember(Value = "4")]
        _4,
        [EnumMember(Value = "5")]
        _5,
        [EnumMember(Value = "6")]
        _6,
        [EnumMember(Value = "7")]
        _7,
        [EnumMember(Value = "10")]
        _10,
        [EnumMember(Value = "11")]
        _11,
        [EnumMember(Value = "12")]
        _12,
        [EnumMember(Value = "20")]
        _20,
        [EnumMember(Value = "30")]
        _30,
        [EnumMember(Value = "50")]
        _50,
        [EnumMember(Value = "60")]
        _60,
        [EnumMember(Value = "70")]
        _70,
        [EnumMember(Value = "71")]
        _71,
        [EnumMember(Value = "80")]
        _80,
        [EnumMember(Value = "90")]
        _90,
        [EnumMember(Value = "91")]
        _91,
        [EnumMember(Value = "92")]
        _92,
        [EnumMember(Value = "96")]
        _96,
        [EnumMember(Value = "97")]
        _97,
        [EnumMember(Value = "98")]
        _98,
        [EnumMember(Value = "99")]
        _99,
        [EnumMember(Value = "100")]
        _100,
        [EnumMember(Value = "101")]
        _101,
        [EnumMember(Value = "303")]
        _303,
        [EnumMember(Value = "400")]
        _400,
        [EnumMember(Value = "401")]
        _401,
        [EnumMember(Value = "404")]
        _404,
        [EnumMember(Value = "901")]
        _901,
        [EnumMember(Value = "902")]
        _902,
        [EnumMember(Value = "903")]
        _903,
        [EnumMember(Value = "910")]
        _910,
        [EnumMember(Value = "913")]
        _913,
        [EnumMember(Value = "1001")]
        _1001,
        [EnumMember(Value = "1004")]
        _1004,
        [EnumMember(Value = "1005")]
        _1005,
        [EnumMember(Value = "1006")]
        _1006,
        [EnumMember(Value = "2000")]
        _2000,
        [EnumMember(Value = "2001")]
        _2001,
        [EnumMember(Value = "2002")]
        _2002,
        [EnumMember(Value = "2003")]
        _2003,
        [EnumMember(Value = "2004")]
        _2004,
        [EnumMember(Value = "2005")]
        _2005,
        [EnumMember(Value = "2007")]
        _2007,
        [EnumMember(Value = "2008")]
        _2008
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum AddOrUpdateProjectInputProjectUseTypeType
    {
        [EnumMember(Value = "1")]
        _1,
        [EnumMember(Value = "2")]
        _2,
        [EnumMember(Value = "4")]
        _4,
        [EnumMember(Value = "8")]
        _8,
        [EnumMember(Value = "16")]
        _16,
        [EnumMember(Value = "32")]
        _32,
        [EnumMember(Value = "64")]
        _64,
        [EnumMember(Value = "128")]
        _128
    }

    public class BaseResult
    {
        public BaseResultResultCodeType ResultCode { get; set; }
        public string Message { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BaseResultResultCodeType
    {
        [EnumMember(Value = "0")]
        _0,
        [EnumMember(Value = "1")]
        _1,
        [EnumMember(Value = "2")]
        _2,
        [EnumMember(Value = "3")]
        _3,
        [EnumMember(Value = "4")]
        _4,
        [EnumMember(Value = "5")]
        _5,
        [EnumMember(Value = "6")]
        _6,
        [EnumMember(Value = "7")]
        _7,
        [EnumMember(Value = "10")]
        _10,
        [EnumMember(Value = "11")]
        _11,
        [EnumMember(Value = "12")]
        _12,
        [EnumMember(Value = "20")]
        _20,
        [EnumMember(Value = "30")]
        _30,
        [EnumMember(Value = "50")]
        _50,
        [EnumMember(Value = "60")]
        _60,
        [EnumMember(Value = "70")]
        _70,
        [EnumMember(Value = "71")]
        _71,
        [EnumMember(Value = "80")]
        _80,
        [EnumMember(Value = "90")]
        _90,
        [EnumMember(Value = "91")]
        _91,
        [EnumMember(Value = "92")]
        _92,
        [EnumMember(Value = "96")]
        _96,
        [EnumMember(Value = "97")]
        _97,
        [EnumMember(Value = "98")]
        _98,
        [EnumMember(Value = "99")]
        _99,
        [EnumMember(Value = "100")]
        _100,
        [EnumMember(Value = "101")]
        _101,
        [EnumMember(Value = "303")]
        _303,
        [EnumMember(Value = "400")]
        _400,
        [EnumMember(Value = "401")]
        _401,
        [EnumMember(Value = "404")]
        _404,
        [EnumMember(Value = "901")]
        _901,
        [EnumMember(Value = "902")]
        _902,
        [EnumMember(Value = "903")]
        _903,
        [EnumMember(Value = "910")]
        _910,
        [EnumMember(Value = "913")]
        _913,
        [EnumMember(Value = "1001")]
        _1001,
        [EnumMember(Value = "1004")]
        _1004,
        [EnumMember(Value = "1005")]
        _1005,
        [EnumMember(Value = "1006")]
        _1006,
        [EnumMember(Value = "2000")]
        _2000,
        [EnumMember(Value = "2001")]
        _2001,
        [EnumMember(Value = "2002")]
        _2002,
        [EnumMember(Value = "2003")]
        _2003,
        [EnumMember(Value = "2004")]
        _2004,
        [EnumMember(Value = "2005")]
        _2005,
        [EnumMember(Value = "2007")]
        _2007,
        [EnumMember(Value = "2008")]
        _2008
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ReportResponseStateType
    {
        [EnumMember(Value = "0")]
        _0,
        [EnumMember(Value = "2")]
        _2,
        [EnumMember(Value = "3")]
        _3,
        [EnumMember(Value = "4")]
        _4,
        [EnumMember(Value = "5")]
        _5,
        [EnumMember(Value = "6")]
        _6,
        [EnumMember(Value = "7")]
        _7,
        [EnumMember(Value = "8")]
        _8,
        [EnumMember(Value = "50")]
        _50
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum TagResponseTagTypeType
    {
        [EnumMember(Value = "1")]
        _1,
        [EnumMember(Value = "2")]
        _2
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum TagResponseUseTypeType
    {
        [EnumMember(Value = "2")]
        _2,
        [EnumMember(Value = "4")]
        _4,
        [EnumMember(Value = "8")]
        _8,
        [EnumMember(Value = "16")]
        _16,
        [EnumMember(Value = "32")]
        _32,
        [EnumMember(Value = "64")]
        _64,
        [EnumMember(Value = "128")]
        _128
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ListAndPagesCountResultReportResponseResultCodeType
    {
        [EnumMember(Value = "0")]
        _0,
        [EnumMember(Value = "1")]
        _1,
        [EnumMember(Value = "2")]
        _2,
        [EnumMember(Value = "3")]
        _3,
        [EnumMember(Value = "4")]
        _4,
        [EnumMember(Value = "5")]
        _5,
        [EnumMember(Value = "6")]
        _6,
        [EnumMember(Value = "7")]
        _7,
        [EnumMember(Value = "10")]
        _10,
        [EnumMember(Value = "11")]
        _11,
        [EnumMember(Value = "12")]
        _12,
        [EnumMember(Value = "20")]
        _20,
        [EnumMember(Value = "30")]
        _30,
        [EnumMember(Value = "50")]
        _50,
        [EnumMember(Value = "60")]
        _60,
        [EnumMember(Value = "70")]
        _70,
        [EnumMember(Value = "71")]
        _71,
        [EnumMember(Value = "80")]
        _80,
        [EnumMember(Value = "90")]
        _90,
        [EnumMember(Value = "91")]
        _91,
        [EnumMember(Value = "92")]
        _92,
        [EnumMember(Value = "96")]
        _96,
        [EnumMember(Value = "97")]
        _97,
        [EnumMember(Value = "98")]
        _98,
        [EnumMember(Value = "99")]
        _99,
        [EnumMember(Value = "100")]
        _100,
        [EnumMember(Value = "101")]
        _101,
        [EnumMember(Value = "303")]
        _303,
        [EnumMember(Value = "400")]
        _400,
        [EnumMember(Value = "401")]
        _401,
        [EnumMember(Value = "404")]
        _404,
        [EnumMember(Value = "901")]
        _901,
        [EnumMember(Value = "902")]
        _902,
        [EnumMember(Value = "903")]
        _903,
        [EnumMember(Value = "910")]
        _910,
        [EnumMember(Value = "913")]
        _913,
        [EnumMember(Value = "1001")]
        _1001,
        [EnumMember(Value = "1004")]
        _1004,
        [EnumMember(Value = "1005")]
        _1005,
        [EnumMember(Value = "1006")]
        _1006,
        [EnumMember(Value = "2000")]
        _2000,
        [EnumMember(Value = "2001")]
        _2001,
        [EnumMember(Value = "2002")]
        _2002,
        [EnumMember(Value = "2003")]
        _2003,
        [EnumMember(Value = "2004")]
        _2004,
        [EnumMember(Value = "2005")]
        _2005,
        [EnumMember(Value = "2007")]
        _2007,
        [EnumMember(Value = "2008")]
        _2008
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum reportUpdateStatusInputoperationInput
    {
        [EnumMember(Value = "0")]
        _0,
        [EnumMember(Value = "2")]
        _2,
        [EnumMember(Value = "3")]
        _3,
        [EnumMember(Value = "4")]
        _4,
        [EnumMember(Value = "5")]
        _5,
        [EnumMember(Value = "6")]
        _6,
        [EnumMember(Value = "7")]
        _7,
        [EnumMember(Value = "8")]
        _8,
        [EnumMember(Value = "9")]
        _9,
        [EnumMember(Value = "10")]
        _10,
        [EnumMember(Value = "11")]
        _11
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum UserResponseUserTypeType
    {
        [EnumMember(Value = "0")]
        _0,
        [EnumMember(Value = "1")]
        _1,
        [EnumMember(Value = "2")]
        _2,
        [EnumMember(Value = "4")]
        _4,
        [EnumMember(Value = "8")]
        _8,
        [EnumMember(Value = "16")]
        _16,
        [EnumMember(Value = "32")]
        _32,
        [EnumMember(Value = "56")]
        _56
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum UserResponseUserStateType
    {
        [EnumMember(Value = "0")]
        _0,
        [EnumMember(Value = "1")]
        _1,
        [EnumMember(Value = "2")]
        _2
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum UserResponseManagerUserStateType
    {
        [EnumMember(Value = "0")]
        _0,
        [EnumMember(Value = "1")]
        _1,
        [EnumMember(Value = "2")]
        _2
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum UserResponseReviewerUserStateType
    {
        [EnumMember(Value = "0")]
        _0,
        [EnumMember(Value = "1")]
        _1,
        [EnumMember(Value = "2")]
        _2
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum UserResponseUserRoleType
    {
        [EnumMember(Value = "0")]
        _0,
        [EnumMember(Value = "2")]
        _2,
        [EnumMember(Value = "4")]
        _4,
        [EnumMember(Value = "8")]
        _8,
        [EnumMember(Value = "16")]
        _16,
        [EnumMember(Value = "32")]
        _32,
        [EnumMember(Value = "64")]
        _64,
        [EnumMember(Value = "128")]
        _128,
        [EnumMember(Value = "256")]
        _256,
        [EnumMember(Value = "512")]
        _512,
        [EnumMember(Value = "1024")]
        _1024,
        [EnumMember(Value = "2048")]
        _2048,
        [EnumMember(Value = "4096")]
        _4096,
        [EnumMember(Value = "8192")]
        _8192,
        [EnumMember(Value = "16384")]
        _16384,
        [EnumMember(Value = "32768")]
        _32768,
        [EnumMember(Value = "65536")]
        _65536,
        [EnumMember(Value = "131072")]
        _131072,
        [EnumMember(Value = "262144")]
        _262144,
        [EnumMember(Value = "524288")]
        _524288,
        [EnumMember(Value = "1048576")]
        _1048576,
        [EnumMember(Value = "2097152")]
        _2097152,
        [EnumMember(Value = "4194304")]
        _4194304,
        [EnumMember(Value = "8388608")]
        _8388608,
        [EnumMember(Value = "16777216")]
        _16777216,
        [EnumMember(Value = "33554432")]
        _33554432,
        [EnumMember(Value = "67108864")]
        _67108864
    }

    public class ValidatorResponse
    {
        public string Mail { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double MinimumAmount { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ListAndPagesCountResultUserResponseResultCodeType
    {
        [EnumMember(Value = "0")]
        _0,
        [EnumMember(Value = "1")]
        _1,
        [EnumMember(Value = "2")]
        _2,
        [EnumMember(Value = "3")]
        _3,
        [EnumMember(Value = "4")]
        _4,
        [EnumMember(Value = "5")]
        _5,
        [EnumMember(Value = "6")]
        _6,
        [EnumMember(Value = "7")]
        _7,
        [EnumMember(Value = "10")]
        _10,
        [EnumMember(Value = "11")]
        _11,
        [EnumMember(Value = "12")]
        _12,
        [EnumMember(Value = "20")]
        _20,
        [EnumMember(Value = "30")]
        _30,
        [EnumMember(Value = "50")]
        _50,
        [EnumMember(Value = "60")]
        _60,
        [EnumMember(Value = "70")]
        _70,
        [EnumMember(Value = "71")]
        _71,
        [EnumMember(Value = "80")]
        _80,
        [EnumMember(Value = "90")]
        _90,
        [EnumMember(Value = "91")]
        _91,
        [EnumMember(Value = "92")]
        _92,
        [EnumMember(Value = "96")]
        _96,
        [EnumMember(Value = "97")]
        _97,
        [EnumMember(Value = "98")]
        _98,
        [EnumMember(Value = "99")]
        _99,
        [EnumMember(Value = "100")]
        _100,
        [EnumMember(Value = "101")]
        _101,
        [EnumMember(Value = "303")]
        _303,
        [EnumMember(Value = "400")]
        _400,
        [EnumMember(Value = "401")]
        _401,
        [EnumMember(Value = "404")]
        _404,
        [EnumMember(Value = "901")]
        _901,
        [EnumMember(Value = "902")]
        _902,
        [EnumMember(Value = "903")]
        _903,
        [EnumMember(Value = "910")]
        _910,
        [EnumMember(Value = "913")]
        _913,
        [EnumMember(Value = "1001")]
        _1001,
        [EnumMember(Value = "1004")]
        _1004,
        [EnumMember(Value = "1005")]
        _1005,
        [EnumMember(Value = "1006")]
        _1006,
        [EnumMember(Value = "2000")]
        _2000,
        [EnumMember(Value = "2001")]
        _2001,
        [EnumMember(Value = "2002")]
        _2002,
        [EnumMember(Value = "2003")]
        _2003,
        [EnumMember(Value = "2004")]
        _2004,
        [EnumMember(Value = "2005")]
        _2005,
        [EnumMember(Value = "2007")]
        _2007,
        [EnumMember(Value = "2008")]
        _2008
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum quickExpenseInputexpenseUseTypeInput
    {
        [EnumMember(Value = "1")]
        _1,
        [EnumMember(Value = "2")]
        _2,
        [EnumMember(Value = "4")]
        _4,
        [EnumMember(Value = "8")]
        _8,
        [EnumMember(Value = "16")]
        _16
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CategoryResponseCategoryUseTypeType
    {
        [EnumMember(Value = "1")]
        _1,
        [EnumMember(Value = "2")]
        _2,
        [EnumMember(Value = "4")]
        _4
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ListAndPagesCountResultCategoryResponseResultCodeType
    {
        [EnumMember(Value = "0")]
        _0,
        [EnumMember(Value = "1")]
        _1,
        [EnumMember(Value = "2")]
        _2,
        [EnumMember(Value = "3")]
        _3,
        [EnumMember(Value = "4")]
        _4,
        [EnumMember(Value = "5")]
        _5,
        [EnumMember(Value = "6")]
        _6,
        [EnumMember(Value = "7")]
        _7,
        [EnumMember(Value = "10")]
        _10,
        [EnumMember(Value = "11")]
        _11,
        [EnumMember(Value = "12")]
        _12,
        [EnumMember(Value = "20")]
        _20,
        [EnumMember(Value = "30")]
        _30,
        [EnumMember(Value = "50")]
        _50,
        [EnumMember(Value = "60")]
        _60,
        [EnumMember(Value = "70")]
        _70,
        [EnumMember(Value = "71")]
        _71,
        [EnumMember(Value = "80")]
        _80,
        [EnumMember(Value = "90")]
        _90,
        [EnumMember(Value = "91")]
        _91,
        [EnumMember(Value = "92")]
        _92,
        [EnumMember(Value = "96")]
        _96,
        [EnumMember(Value = "97")]
        _97,
        [EnumMember(Value = "98")]
        _98,
        [EnumMember(Value = "99")]
        _99,
        [EnumMember(Value = "100")]
        _100,
        [EnumMember(Value = "101")]
        _101,
        [EnumMember(Value = "303")]
        _303,
        [EnumMember(Value = "400")]
        _400,
        [EnumMember(Value = "401")]
        _401,
        [EnumMember(Value = "404")]
        _404,
        [EnumMember(Value = "901")]
        _901,
        [EnumMember(Value = "902")]
        _902,
        [EnumMember(Value = "903")]
        _903,
        [EnumMember(Value = "910")]
        _910,
        [EnumMember(Value = "913")]
        _913,
        [EnumMember(Value = "1001")]
        _1001,
        [EnumMember(Value = "1004")]
        _1004,
        [EnumMember(Value = "1005")]
        _1005,
        [EnumMember(Value = "1006")]
        _1006,
        [EnumMember(Value = "2000")]
        _2000,
        [EnumMember(Value = "2001")]
        _2001,
        [EnumMember(Value = "2002")]
        _2002,
        [EnumMember(Value = "2003")]
        _2003,
        [EnumMember(Value = "2004")]
        _2004,
        [EnumMember(Value = "2005")]
        _2005,
        [EnumMember(Value = "2007")]
        _2007,
        [EnumMember(Value = "2008")]
        _2008
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ExpenseResponseUseTypeType
    {
        [EnumMember(Value = "1")]
        _1,
        [EnumMember(Value = "2")]
        _2,
        [EnumMember(Value = "4")]
        _4,
        [EnumMember(Value = "8")]
        _8,
        [EnumMember(Value = "16")]
        _16
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ExpenseResponseStateType
    {
        [EnumMember(Value = "0")]
        _0,
        [EnumMember(Value = "1")]
        _1,
        [EnumMember(Value = "2")]
        _2,
        [EnumMember(Value = "3")]
        _3,
        [EnumMember(Value = "4")]
        _4,
        [EnumMember(Value = "99")]
        _99
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ProjectResponseProjectUseTypeType
    {
        [EnumMember(Value = "1")]
        _1,
        [EnumMember(Value = "2")]
        _2,
        [EnumMember(Value = "4")]
        _4,
        [EnumMember(Value = "8")]
        _8,
        [EnumMember(Value = "16")]
        _16,
        [EnumMember(Value = "32")]
        _32,
        [EnumMember(Value = "64")]
        _64,
        [EnumMember(Value = "128")]
        _128
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum PaymentInstrumentResponseInstrumentTypeType
    {
        [EnumMember(Value = "0")]
        _0,
        [EnumMember(Value = "1")]
        _1,
        [EnumMember(Value = "2")]
        _2,
        [EnumMember(Value = "3")]
        _3,
        [EnumMember(Value = "4")]
        _4,
        [EnumMember(Value = "5")]
        _5,
        [EnumMember(Value = "6")]
        _6,
        [EnumMember(Value = "99")]
        _99
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum PaymentInstrumentResponseAccountTypeType
    {
        [EnumMember(Value = "0")]
        _0,
        [EnumMember(Value = "1")]
        _1,
        [EnumMember(Value = "2")]
        _2
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum VehicleResponseVehicleTypeType
    {
        [EnumMember(Value = "1")]
        _1,
        [EnumMember(Value = "2")]
        _2,
        [EnumMember(Value = "3")]
        _3,
        [EnumMember(Value = "4")]
        _4,
        [EnumMember(Value = "5")]
        _5
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum VehicleResponseInternalVehicleTypeType
    {
        [EnumMember(Value = "0")]
        _0,
        [EnumMember(Value = "1")]
        _1,
        [EnumMember(Value = "2")]
        _2
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum VehicleResponseStateType
    {
        [EnumMember(Value = "0")]
        _0,
        [EnumMember(Value = "1")]
        _1,
        [EnumMember(Value = "2")]
        _2,
        [EnumMember(Value = "3")]
        _3,
        [EnumMember(Value = "4")]
        _4,
        [EnumMember(Value = "-1")]
        Negative1
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum VehicleResponseCreationTypeType
    {
        [EnumMember(Value = "0")]
        _0,
        [EnumMember(Value = "1")]
        _1
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ExpenseResponsePerdiemCalculationPeriodTypeType
    {
        [EnumMember(Value = "0")]
        _0,
        [EnumMember(Value = "1")]
        _1
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ExpenseResponsePerDiemTypeType
    {
        [EnumMember(Value = "0")]
        _0,
        [EnumMember(Value = "1")]
        _1,
        [EnumMember(Value = "2")]
        _2
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BrokenRuleResponseRuleTypeType
    {
        [EnumMember(Value = "0")]
        _0,
        [EnumMember(Value = "1")]
        _1,
        [EnumMember(Value = "2")]
        _2,
        [EnumMember(Value = "3")]
        _3
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BrokenRuleResponseRuleElementTypeType
    {
        [EnumMember(Value = "0")]
        _0,
        [EnumMember(Value = "1")]
        _1
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BrokenRuleResponseIntervalTypeType
    {
        [EnumMember(Value = "0")]
        _0,
        [EnumMember(Value = "1")]
        _1,
        [EnumMember(Value = "2")]
        _2,
        [EnumMember(Value = "3")]
        _3,
        [EnumMember(Value = "4")]
        _4
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ExpenseResponseSubStatusType
    {
        [EnumMember(Value = "0")]
        _0,
        [EnumMember(Value = "2")]
        _2,
        [EnumMember(Value = "4")]
        _4,
        [EnumMember(Value = "8")]
        _8,
        [EnumMember(Value = "16")]
        _16,
        [EnumMember(Value = "32")]
        _32,
        [EnumMember(Value = "64")]
        _64,
        [EnumMember(Value = "128")]
        _128,
        [EnumMember(Value = "256")]
        _256,
        [EnumMember(Value = "512")]
        _512,
        [EnumMember(Value = "1024")]
        _1024
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ListAndPagesCountResultExpenseResponseResultCodeType
    {
        [EnumMember(Value = "0")]
        _0,
        [EnumMember(Value = "1")]
        _1,
        [EnumMember(Value = "2")]
        _2,
        [EnumMember(Value = "3")]
        _3,
        [EnumMember(Value = "4")]
        _4,
        [EnumMember(Value = "5")]
        _5,
        [EnumMember(Value = "6")]
        _6,
        [EnumMember(Value = "7")]
        _7,
        [EnumMember(Value = "10")]
        _10,
        [EnumMember(Value = "11")]
        _11,
        [EnumMember(Value = "12")]
        _12,
        [EnumMember(Value = "20")]
        _20,
        [EnumMember(Value = "30")]
        _30,
        [EnumMember(Value = "50")]
        _50,
        [EnumMember(Value = "60")]
        _60,
        [EnumMember(Value = "70")]
        _70,
        [EnumMember(Value = "71")]
        _71,
        [EnumMember(Value = "80")]
        _80,
        [EnumMember(Value = "90")]
        _90,
        [EnumMember(Value = "91")]
        _91,
        [EnumMember(Value = "92")]
        _92,
        [EnumMember(Value = "96")]
        _96,
        [EnumMember(Value = "97")]
        _97,
        [EnumMember(Value = "98")]
        _98,
        [EnumMember(Value = "99")]
        _99,
        [EnumMember(Value = "100")]
        _100,
        [EnumMember(Value = "101")]
        _101,
        [EnumMember(Value = "303")]
        _303,
        [EnumMember(Value = "400")]
        _400,
        [EnumMember(Value = "401")]
        _401,
        [EnumMember(Value = "404")]
        _404,
        [EnumMember(Value = "901")]
        _901,
        [EnumMember(Value = "902")]
        _902,
        [EnumMember(Value = "903")]
        _903,
        [EnumMember(Value = "910")]
        _910,
        [EnumMember(Value = "913")]
        _913,
        [EnumMember(Value = "1001")]
        _1001,
        [EnumMember(Value = "1004")]
        _1004,
        [EnumMember(Value = "1005")]
        _1005,
        [EnumMember(Value = "1006")]
        _1006,
        [EnumMember(Value = "2000")]
        _2000,
        [EnumMember(Value = "2001")]
        _2001,
        [EnumMember(Value = "2002")]
        _2002,
        [EnumMember(Value = "2003")]
        _2003,
        [EnumMember(Value = "2004")]
        _2004,
        [EnumMember(Value = "2005")]
        _2005,
        [EnumMember(Value = "2007")]
        _2007,
        [EnumMember(Value = "2008")]
        _2008
    }

    public class BaseResultProjectResponse
    {
        public ProjectResponse ResultItem { get; set; }
        public BaseResultProjectResponseResultCodeType ResultCode { get; set; }
        public string Message { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BaseResultProjectResponseResultCodeType
    {
        [EnumMember(Value = "0")]
        _0,
        [EnumMember(Value = "1")]
        _1,
        [EnumMember(Value = "2")]
        _2,
        [EnumMember(Value = "3")]
        _3,
        [EnumMember(Value = "4")]
        _4,
        [EnumMember(Value = "5")]
        _5,
        [EnumMember(Value = "6")]
        _6,
        [EnumMember(Value = "7")]
        _7,
        [EnumMember(Value = "10")]
        _10,
        [EnumMember(Value = "11")]
        _11,
        [EnumMember(Value = "12")]
        _12,
        [EnumMember(Value = "20")]
        _20,
        [EnumMember(Value = "30")]
        _30,
        [EnumMember(Value = "50")]
        _50,
        [EnumMember(Value = "60")]
        _60,
        [EnumMember(Value = "70")]
        _70,
        [EnumMember(Value = "71")]
        _71,
        [EnumMember(Value = "80")]
        _80,
        [EnumMember(Value = "90")]
        _90,
        [EnumMember(Value = "91")]
        _91,
        [EnumMember(Value = "92")]
        _92,
        [EnumMember(Value = "96")]
        _96,
        [EnumMember(Value = "97")]
        _97,
        [EnumMember(Value = "98")]
        _98,
        [EnumMember(Value = "99")]
        _99,
        [EnumMember(Value = "100")]
        _100,
        [EnumMember(Value = "101")]
        _101,
        [EnumMember(Value = "303")]
        _303,
        [EnumMember(Value = "400")]
        _400,
        [EnumMember(Value = "401")]
        _401,
        [EnumMember(Value = "404")]
        _404,
        [EnumMember(Value = "901")]
        _901,
        [EnumMember(Value = "902")]
        _902,
        [EnumMember(Value = "903")]
        _903,
        [EnumMember(Value = "910")]
        _910,
        [EnumMember(Value = "913")]
        _913,
        [EnumMember(Value = "1001")]
        _1001,
        [EnumMember(Value = "1004")]
        _1004,
        [EnumMember(Value = "1005")]
        _1005,
        [EnumMember(Value = "1006")]
        _1006,
        [EnumMember(Value = "2000")]
        _2000,
        [EnumMember(Value = "2001")]
        _2001,
        [EnumMember(Value = "2002")]
        _2002,
        [EnumMember(Value = "2003")]
        _2003,
        [EnumMember(Value = "2004")]
        _2004,
        [EnumMember(Value = "2005")]
        _2005,
        [EnumMember(Value = "2007")]
        _2007,
        [EnumMember(Value = "2008")]
        _2008
    }

    public class ListAndPagesCountResultProjectResponse
    {
        public ProjectResponse[] List { get; set; }
        public int PagesCount { get; set; }
        public int TotalListCount { get; set; }
        public ListAndPagesCountResultProjectResponseResultCodeType ResultCode { get; set; }
        public string Message { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ListAndPagesCountResultProjectResponseResultCodeType
    {
        [EnumMember(Value = "0")]
        _0,
        [EnumMember(Value = "1")]
        _1,
        [EnumMember(Value = "2")]
        _2,
        [EnumMember(Value = "3")]
        _3,
        [EnumMember(Value = "4")]
        _4,
        [EnumMember(Value = "5")]
        _5,
        [EnumMember(Value = "6")]
        _6,
        [EnumMember(Value = "7")]
        _7,
        [EnumMember(Value = "10")]
        _10,
        [EnumMember(Value = "11")]
        _11,
        [EnumMember(Value = "12")]
        _12,
        [EnumMember(Value = "20")]
        _20,
        [EnumMember(Value = "30")]
        _30,
        [EnumMember(Value = "50")]
        _50,
        [EnumMember(Value = "60")]
        _60,
        [EnumMember(Value = "70")]
        _70,
        [EnumMember(Value = "71")]
        _71,
        [EnumMember(Value = "80")]
        _80,
        [EnumMember(Value = "90")]
        _90,
        [EnumMember(Value = "91")]
        _91,
        [EnumMember(Value = "92")]
        _92,
        [EnumMember(Value = "96")]
        _96,
        [EnumMember(Value = "97")]
        _97,
        [EnumMember(Value = "98")]
        _98,
        [EnumMember(Value = "99")]
        _99,
        [EnumMember(Value = "100")]
        _100,
        [EnumMember(Value = "101")]
        _101,
        [EnumMember(Value = "303")]
        _303,
        [EnumMember(Value = "400")]
        _400,
        [EnumMember(Value = "401")]
        _401,
        [EnumMember(Value = "404")]
        _404,
        [EnumMember(Value = "901")]
        _901,
        [EnumMember(Value = "902")]
        _902,
        [EnumMember(Value = "903")]
        _903,
        [EnumMember(Value = "910")]
        _910,
        [EnumMember(Value = "913")]
        _913,
        [EnumMember(Value = "1001")]
        _1001,
        [EnumMember(Value = "1004")]
        _1004,
        [EnumMember(Value = "1005")]
        _1005,
        [EnumMember(Value = "1006")]
        _1006,
        [EnumMember(Value = "2000")]
        _2000,
        [EnumMember(Value = "2001")]
        _2001,
        [EnumMember(Value = "2002")]
        _2002,
        [EnumMember(Value = "2003")]
        _2003,
        [EnumMember(Value = "2004")]
        _2004,
        [EnumMember(Value = "2005")]
        _2005,
        [EnumMember(Value = "2007")]
        _2007,
        [EnumMember(Value = "2008")]
        _2008
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EventResponseEventTypeType
    {
        [EnumMember(Value = "1")]
        _1,
        [EnumMember(Value = "2")]
        _2,
        [EnumMember(Value = "3")]
        _3,
        [EnumMember(Value = "4")]
        _4,
        [EnumMember(Value = "5")]
        _5,
        [EnumMember(Value = "6")]
        _6,
        [EnumMember(Value = "7")]
        _7,
        [EnumMember(Value = "8")]
        _8,
        [EnumMember(Value = "9")]
        _9,
        [EnumMember(Value = "10")]
        _10,
        [EnumMember(Value = "11")]
        _11,
        [EnumMember(Value = "12")]
        _12,
        [EnumMember(Value = "13")]
        _13,
        [EnumMember(Value = "14")]
        _14,
        [EnumMember(Value = "15")]
        _15,
        [EnumMember(Value = "16")]
        _16,
        [EnumMember(Value = "17")]
        _17,
        [EnumMember(Value = "18")]
        _18,
        [EnumMember(Value = "19")]
        _19,
        [EnumMember(Value = "20")]
        _20,
        [EnumMember(Value = "21")]
        _21,
        [EnumMember(Value = "22")]
        _22,
        [EnumMember(Value = "23")]
        _23,
        [EnumMember(Value = "24")]
        _24,
        [EnumMember(Value = "25")]
        _25,
        [EnumMember(Value = "26")]
        _26,
        [EnumMember(Value = "27")]
        _27,
        [EnumMember(Value = "28")]
        _28,
        [EnumMember(Value = "29")]
        _29,
        [EnumMember(Value = "30")]
        _30,
        [EnumMember(Value = "31")]
        _31,
        [EnumMember(Value = "32")]
        _32,
        [EnumMember(Value = "33")]
        _33,
        [EnumMember(Value = "34")]
        _34,
        [EnumMember(Value = "35")]
        _35,
        [EnumMember(Value = "36")]
        _36,
        [EnumMember(Value = "37")]
        _37,
        [EnumMember(Value = "38")]
        _38,
        [EnumMember(Value = "39")]
        _39,
        [EnumMember(Value = "41")]
        _41,
        [EnumMember(Value = "42")]
        _42,
        [EnumMember(Value = "43")]
        _43,
        [EnumMember(Value = "97")]
        _97,
        [EnumMember(Value = "98")]
        _98,
        [EnumMember(Value = "99")]
        _99,
        [EnumMember(Value = "100")]
        _100,
        [EnumMember(Value = "101")]
        _101,
        [EnumMember(Value = "102")]
        _102,
        [EnumMember(Value = "103")]
        _103,
        [EnumMember(Value = "104")]
        _104,
        [EnumMember(Value = "105")]
        _105,
        [EnumMember(Value = "106")]
        _106,
        [EnumMember(Value = "107")]
        _107,
        [EnumMember(Value = "108")]
        _108,
        [EnumMember(Value = "109")]
        _109,
        [EnumMember(Value = "110")]
        _110,
        [EnumMember(Value = "111")]
        _111,
        [EnumMember(Value = "112")]
        _112,
        [EnumMember(Value = "113")]
        _113,
        [EnumMember(Value = "114")]
        _114,
        [EnumMember(Value = "115")]
        _115,
        [EnumMember(Value = "116")]
        _116,
        [EnumMember(Value = "117")]
        _117,
        [EnumMember(Value = "118")]
        _118,
        [EnumMember(Value = "119")]
        _119,
        [EnumMember(Value = "120")]
        _120,
        [EnumMember(Value = "121")]
        _121,
        [EnumMember(Value = "122")]
        _122,
        [EnumMember(Value = "123")]
        _123,
        [EnumMember(Value = "124")]
        _124,
        [EnumMember(Value = "125")]
        _125,
        [EnumMember(Value = "126")]
        _126,
        [EnumMember(Value = "127")]
        _127,
        [EnumMember(Value = "128")]
        _128,
        [EnumMember(Value = "129")]
        _129
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BaseResultListEventResponseResultCodeType
    {
        [EnumMember(Value = "0")]
        _0,
        [EnumMember(Value = "1")]
        _1,
        [EnumMember(Value = "2")]
        _2,
        [EnumMember(Value = "3")]
        _3,
        [EnumMember(Value = "4")]
        _4,
        [EnumMember(Value = "5")]
        _5,
        [EnumMember(Value = "6")]
        _6,
        [EnumMember(Value = "7")]
        _7,
        [EnumMember(Value = "10")]
        _10,
        [EnumMember(Value = "11")]
        _11,
        [EnumMember(Value = "12")]
        _12,
        [EnumMember(Value = "20")]
        _20,
        [EnumMember(Value = "30")]
        _30,
        [EnumMember(Value = "50")]
        _50,
        [EnumMember(Value = "60")]
        _60,
        [EnumMember(Value = "70")]
        _70,
        [EnumMember(Value = "71")]
        _71,
        [EnumMember(Value = "80")]
        _80,
        [EnumMember(Value = "90")]
        _90,
        [EnumMember(Value = "91")]
        _91,
        [EnumMember(Value = "92")]
        _92,
        [EnumMember(Value = "96")]
        _96,
        [EnumMember(Value = "97")]
        _97,
        [EnumMember(Value = "98")]
        _98,
        [EnumMember(Value = "99")]
        _99,
        [EnumMember(Value = "100")]
        _100,
        [EnumMember(Value = "101")]
        _101,
        [EnumMember(Value = "303")]
        _303,
        [EnumMember(Value = "400")]
        _400,
        [EnumMember(Value = "401")]
        _401,
        [EnumMember(Value = "404")]
        _404,
        [EnumMember(Value = "901")]
        _901,
        [EnumMember(Value = "902")]
        _902,
        [EnumMember(Value = "903")]
        _903,
        [EnumMember(Value = "910")]
        _910,
        [EnumMember(Value = "913")]
        _913,
        [EnumMember(Value = "1001")]
        _1001,
        [EnumMember(Value = "1004")]
        _1004,
        [EnumMember(Value = "1005")]
        _1005,
        [EnumMember(Value = "1006")]
        _1006,
        [EnumMember(Value = "2000")]
        _2000,
        [EnumMember(Value = "2001")]
        _2001,
        [EnumMember(Value = "2002")]
        _2002,
        [EnumMember(Value = "2003")]
        _2003,
        [EnumMember(Value = "2004")]
        _2004,
        [EnumMember(Value = "2005")]
        _2005,
        [EnumMember(Value = "2007")]
        _2007,
        [EnumMember(Value = "2008")]
        _2008
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum userInviteInputuserTypeInput
    {
        [EnumMember(Value = "0")]
        _0,
        [EnumMember(Value = "1")]
        _1,
        [EnumMember(Value = "2")]
        _2,
        [EnumMember(Value = "4")]
        _4,
        [EnumMember(Value = "8")]
        _8,
        [EnumMember(Value = "16")]
        _16,
        [EnumMember(Value = "32")]
        _32,
        [EnumMember(Value = "56")]
        _56
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum userInviteInputuserRoleInput
    {
        [EnumMember(Value = "0")]
        _0,
        [EnumMember(Value = "2")]
        _2,
        [EnumMember(Value = "4")]
        _4,
        [EnumMember(Value = "8")]
        _8,
        [EnumMember(Value = "16")]
        _16,
        [EnumMember(Value = "32")]
        _32,
        [EnumMember(Value = "64")]
        _64,
        [EnumMember(Value = "128")]
        _128,
        [EnumMember(Value = "256")]
        _256,
        [EnumMember(Value = "512")]
        _512,
        [EnumMember(Value = "1024")]
        _1024,
        [EnumMember(Value = "2048")]
        _2048,
        [EnumMember(Value = "4096")]
        _4096,
        [EnumMember(Value = "8192")]
        _8192,
        [EnumMember(Value = "16384")]
        _16384,
        [EnumMember(Value = "32768")]
        _32768,
        [EnumMember(Value = "65536")]
        _65536,
        [EnumMember(Value = "131072")]
        _131072,
        [EnumMember(Value = "262144")]
        _262144,
        [EnumMember(Value = "524288")]
        _524288,
        [EnumMember(Value = "1048576")]
        _1048576,
        [EnumMember(Value = "2097152")]
        _2097152,
        [EnumMember(Value = "4194304")]
        _4194304,
        [EnumMember(Value = "8388608")]
        _8388608,
        [EnumMember(Value = "16777216")]
        _16777216,
        [EnumMember(Value = "33554432")]
        _33554432,
        [EnumMember(Value = "67108864")]
        _67108864
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum LoginResponseResultCodeType
    {
        [EnumMember(Value = "0")]
        _0,
        [EnumMember(Value = "1")]
        _1,
        [EnumMember(Value = "2")]
        _2,
        [EnumMember(Value = "3")]
        _3,
        [EnumMember(Value = "4")]
        _4,
        [EnumMember(Value = "5")]
        _5,
        [EnumMember(Value = "6")]
        _6,
        [EnumMember(Value = "7")]
        _7,
        [EnumMember(Value = "10")]
        _10,
        [EnumMember(Value = "11")]
        _11,
        [EnumMember(Value = "12")]
        _12,
        [EnumMember(Value = "20")]
        _20,
        [EnumMember(Value = "30")]
        _30,
        [EnumMember(Value = "50")]
        _50,
        [EnumMember(Value = "60")]
        _60,
        [EnumMember(Value = "70")]
        _70,
        [EnumMember(Value = "71")]
        _71,
        [EnumMember(Value = "80")]
        _80,
        [EnumMember(Value = "90")]
        _90,
        [EnumMember(Value = "91")]
        _91,
        [EnumMember(Value = "92")]
        _92,
        [EnumMember(Value = "96")]
        _96,
        [EnumMember(Value = "97")]
        _97,
        [EnumMember(Value = "98")]
        _98,
        [EnumMember(Value = "99")]
        _99,
        [EnumMember(Value = "100")]
        _100,
        [EnumMember(Value = "101")]
        _101,
        [EnumMember(Value = "303")]
        _303,
        [EnumMember(Value = "400")]
        _400,
        [EnumMember(Value = "401")]
        _401,
        [EnumMember(Value = "404")]
        _404,
        [EnumMember(Value = "901")]
        _901,
        [EnumMember(Value = "902")]
        _902,
        [EnumMember(Value = "903")]
        _903,
        [EnumMember(Value = "910")]
        _910,
        [EnumMember(Value = "913")]
        _913,
        [EnumMember(Value = "1001")]
        _1001,
        [EnumMember(Value = "1004")]
        _1004,
        [EnumMember(Value = "1005")]
        _1005,
        [EnumMember(Value = "1006")]
        _1006,
        [EnumMember(Value = "2000")]
        _2000,
        [EnumMember(Value = "2001")]
        _2001,
        [EnumMember(Value = "2002")]
        _2002,
        [EnumMember(Value = "2003")]
        _2003,
        [EnumMember(Value = "2004")]
        _2004,
        [EnumMember(Value = "2005")]
        _2005,
        [EnumMember(Value = "2007")]
        _2007,
        [EnumMember(Value = "2008")]
        _2008
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum userUpdateInputuserTypeInput
    {
        [EnumMember(Value = "0")]
        _0,
        [EnumMember(Value = "1")]
        _1,
        [EnumMember(Value = "2")]
        _2,
        [EnumMember(Value = "4")]
        _4,
        [EnumMember(Value = "8")]
        _8,
        [EnumMember(Value = "16")]
        _16,
        [EnumMember(Value = "32")]
        _32,
        [EnumMember(Value = "56")]
        _56
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum userUpdateInputuserRoleInput
    {
        [EnumMember(Value = "0")]
        _0,
        [EnumMember(Value = "2")]
        _2,
        [EnumMember(Value = "4")]
        _4,
        [EnumMember(Value = "8")]
        _8,
        [EnumMember(Value = "16")]
        _16,
        [EnumMember(Value = "32")]
        _32,
        [EnumMember(Value = "64")]
        _64,
        [EnumMember(Value = "128")]
        _128,
        [EnumMember(Value = "256")]
        _256,
        [EnumMember(Value = "512")]
        _512,
        [EnumMember(Value = "1024")]
        _1024,
        [EnumMember(Value = "2048")]
        _2048,
        [EnumMember(Value = "4096")]
        _4096,
        [EnumMember(Value = "8192")]
        _8192,
        [EnumMember(Value = "16384")]
        _16384,
        [EnumMember(Value = "32768")]
        _32768,
        [EnumMember(Value = "65536")]
        _65536,
        [EnumMember(Value = "131072")]
        _131072,
        [EnumMember(Value = "262144")]
        _262144,
        [EnumMember(Value = "524288")]
        _524288,
        [EnumMember(Value = "1048576")]
        _1048576,
        [EnumMember(Value = "2097152")]
        _2097152,
        [EnumMember(Value = "4194304")]
        _4194304,
        [EnumMember(Value = "8388608")]
        _8388608,
        [EnumMember(Value = "16777216")]
        _16777216,
        [EnumMember(Value = "33554432")]
        _33554432,
        [EnumMember(Value = "67108864")]
        _67108864
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum UpdateUserResultResultCodeType
    {
        [EnumMember(Value = "0")]
        _0,
        [EnumMember(Value = "1")]
        _1,
        [EnumMember(Value = "2")]
        _2,
        [EnumMember(Value = "3")]
        _3,
        [EnumMember(Value = "4")]
        _4,
        [EnumMember(Value = "5")]
        _5,
        [EnumMember(Value = "6")]
        _6,
        [EnumMember(Value = "7")]
        _7,
        [EnumMember(Value = "10")]
        _10,
        [EnumMember(Value = "11")]
        _11,
        [EnumMember(Value = "12")]
        _12,
        [EnumMember(Value = "20")]
        _20,
        [EnumMember(Value = "30")]
        _30,
        [EnumMember(Value = "50")]
        _50,
        [EnumMember(Value = "60")]
        _60,
        [EnumMember(Value = "70")]
        _70,
        [EnumMember(Value = "71")]
        _71,
        [EnumMember(Value = "80")]
        _80,
        [EnumMember(Value = "90")]
        _90,
        [EnumMember(Value = "91")]
        _91,
        [EnumMember(Value = "92")]
        _92,
        [EnumMember(Value = "96")]
        _96,
        [EnumMember(Value = "97")]
        _97,
        [EnumMember(Value = "98")]
        _98,
        [EnumMember(Value = "99")]
        _99,
        [EnumMember(Value = "100")]
        _100,
        [EnumMember(Value = "101")]
        _101,
        [EnumMember(Value = "303")]
        _303,
        [EnumMember(Value = "400")]
        _400,
        [EnumMember(Value = "401")]
        _401,
        [EnumMember(Value = "404")]
        _404,
        [EnumMember(Value = "901")]
        _901,
        [EnumMember(Value = "902")]
        _902,
        [EnumMember(Value = "903")]
        _903,
        [EnumMember(Value = "910")]
        _910,
        [EnumMember(Value = "913")]
        _913,
        [EnumMember(Value = "1001")]
        _1001,
        [EnumMember(Value = "1004")]
        _1004,
        [EnumMember(Value = "1005")]
        _1005,
        [EnumMember(Value = "1006")]
        _1006,
        [EnumMember(Value = "2000")]
        _2000,
        [EnumMember(Value = "2001")]
        _2001,
        [EnumMember(Value = "2002")]
        _2002,
        [EnumMember(Value = "2003")]
        _2003,
        [EnumMember(Value = "2004")]
        _2004,
        [EnumMember(Value = "2005")]
        _2005,
        [EnumMember(Value = "2007")]
        _2007,
        [EnumMember(Value = "2008")]
        _2008
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BaseResultListUpdateUserResultResultCodeType
    {
        [EnumMember(Value = "0")]
        _0,
        [EnumMember(Value = "1")]
        _1,
        [EnumMember(Value = "2")]
        _2,
        [EnumMember(Value = "3")]
        _3,
        [EnumMember(Value = "4")]
        _4,
        [EnumMember(Value = "5")]
        _5,
        [EnumMember(Value = "6")]
        _6,
        [EnumMember(Value = "7")]
        _7,
        [EnumMember(Value = "10")]
        _10,
        [EnumMember(Value = "11")]
        _11,
        [EnumMember(Value = "12")]
        _12,
        [EnumMember(Value = "20")]
        _20,
        [EnumMember(Value = "30")]
        _30,
        [EnumMember(Value = "50")]
        _50,
        [EnumMember(Value = "60")]
        _60,
        [EnumMember(Value = "70")]
        _70,
        [EnumMember(Value = "71")]
        _71,
        [EnumMember(Value = "80")]
        _80,
        [EnumMember(Value = "90")]
        _90,
        [EnumMember(Value = "91")]
        _91,
        [EnumMember(Value = "92")]
        _92,
        [EnumMember(Value = "96")]
        _96,
        [EnumMember(Value = "97")]
        _97,
        [EnumMember(Value = "98")]
        _98,
        [EnumMember(Value = "99")]
        _99,
        [EnumMember(Value = "100")]
        _100,
        [EnumMember(Value = "101")]
        _101,
        [EnumMember(Value = "303")]
        _303,
        [EnumMember(Value = "400")]
        _400,
        [EnumMember(Value = "401")]
        _401,
        [EnumMember(Value = "404")]
        _404,
        [EnumMember(Value = "901")]
        _901,
        [EnumMember(Value = "902")]
        _902,
        [EnumMember(Value = "903")]
        _903,
        [EnumMember(Value = "910")]
        _910,
        [EnumMember(Value = "913")]
        _913,
        [EnumMember(Value = "1001")]
        _1001,
        [EnumMember(Value = "1004")]
        _1004,
        [EnumMember(Value = "1005")]
        _1005,
        [EnumMember(Value = "1006")]
        _1006,
        [EnumMember(Value = "2000")]
        _2000,
        [EnumMember(Value = "2001")]
        _2001,
        [EnumMember(Value = "2002")]
        _2002,
        [EnumMember(Value = "2003")]
        _2003,
        [EnumMember(Value = "2004")]
        _2004,
        [EnumMember(Value = "2005")]
        _2005,
        [EnumMember(Value = "2007")]
        _2007,
        [EnumMember(Value = "2008")]
        _2008
    }

    public class UpdateUserStateInput
    {
        public string UserId { get; set; }
        public UpdateUserStateInputOperationType Operation { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum UpdateUserStateInputOperationType
    {
        [EnumMember(Value = "2")]
        _2,
        [EnumMember(Value = "3")]
        _3,
        [EnumMember(Value = "4")]
        _4
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
