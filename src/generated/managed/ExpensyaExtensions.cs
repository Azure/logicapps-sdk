//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Expensya
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ExpensyaActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expensya")]
        [WorkflowExpressionFactory(nameof(__BuildGetExpenseImage))]
        public IBodyWorkflowAction<string> GetExpenseImage([WorkflowExpression] Func<string> expenseId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildGetExpenseImage(WorkflowValue<string> expenseId)
        {
            WorkflowValue.Validate(expenseId, nameof(expenseId), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/expense/{0}/image", ExpressionConverter.ConvertWithUrlEncoding(expenseId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expensya")]
        [WorkflowExpressionFactory(nameof(__BuildExportExpenses))]
        public IBodyWorkflowAction<BaseResultExportResponse> ExportExpenses([WorkflowExpression] Func<string> exportId, [WorkflowExpression] Func<string> reportId = null, [WorkflowExpression] Func<string> categoryId = null, [WorkflowExpression] Func<string> expenseName = null, [WorkflowExpression] Func<string> startDate = null, [WorkflowExpression] Func<string> endDate = null, [WorkflowExpression] Func<string> expenseStates = null, [WorkflowExpression] Func<string> reportStates = null, [WorkflowExpression] Func<string> userIds = null, [WorkflowExpression] Func<string> userMail = null, [WorkflowExpression] Func<string> reportIds = null, [WorkflowExpression] Func<string> expenseIds = null, [WorkflowExpression] Func<string> reportName = null, [WorkflowExpression] Func<string> reportIdShort = null, [WorkflowExpression] Func<int> dateFilterType = null, [WorkflowExpression] Func<string> payId = null, [WorkflowExpression] Func<string> payId2 = null, [WorkflowExpression] Func<string> payId3 = null, [WorkflowExpression] Func<string> accountingPeriod = null, [WorkflowExpression] Func<bool> includeReceipts = null, [WorkflowExpression] Func<int> expenseUseTypes = null, [WorkflowExpression] Func<string> archiveExpenses = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BaseResultExportResponse> __BuildExportExpenses(WorkflowValue<string> exportId, WorkflowValue<string> reportId = null, WorkflowValue<string> categoryId = null, WorkflowValue<string> expenseName = null, WorkflowValue<string> startDate = null, WorkflowValue<string> endDate = null, WorkflowValue<string> expenseStates = null, WorkflowValue<string> reportStates = null, WorkflowValue<string> userIds = null, WorkflowValue<string> userMail = null, WorkflowValue<string> reportIds = null, WorkflowValue<string> expenseIds = null, WorkflowValue<string> reportName = null, WorkflowValue<string> reportIdShort = null, WorkflowValue<int> dateFilterType = null, WorkflowValue<string> payId = null, WorkflowValue<string> payId2 = null, WorkflowValue<string> payId3 = null, WorkflowValue<string> accountingPeriod = null, WorkflowValue<bool> includeReceipts = null, WorkflowValue<int> expenseUseTypes = null, WorkflowValue<string> archiveExpenses = null)
        {
            WorkflowValue.Validate(exportId, nameof(exportId), required: true);
            WorkflowValue.Validate(reportId, nameof(reportId), required: false);
            WorkflowValue.Validate(categoryId, nameof(categoryId), required: false);
            WorkflowValue.Validate(expenseName, nameof(expenseName), required: false);
            WorkflowValue.Validate(startDate, nameof(startDate), required: false);
            WorkflowValue.Validate(endDate, nameof(endDate), required: false);
            WorkflowValue.Validate(expenseStates, nameof(expenseStates), required: false);
            WorkflowValue.Validate(reportStates, nameof(reportStates), required: false);
            WorkflowValue.Validate(userIds, nameof(userIds), required: false);
            WorkflowValue.Validate(userMail, nameof(userMail), required: false);
            WorkflowValue.Validate(reportIds, nameof(reportIds), required: false);
            WorkflowValue.Validate(expenseIds, nameof(expenseIds), required: false);
            WorkflowValue.Validate(reportName, nameof(reportName), required: false);
            WorkflowValue.Validate(reportIdShort, nameof(reportIdShort), required: false);
            WorkflowValue.Validate(dateFilterType, nameof(dateFilterType), required: false);
            WorkflowValue.Validate(payId, nameof(payId), required: false);
            WorkflowValue.Validate(payId2, nameof(payId2), required: false);
            WorkflowValue.Validate(payId3, nameof(payId3), required: false);
            WorkflowValue.Validate(accountingPeriod, nameof(accountingPeriod), required: false);
            WorkflowValue.Validate(includeReceipts, nameof(includeReceipts), required: false);
            WorkflowValue.Validate(expenseUseTypes, nameof(expenseUseTypes), required: false);
            WorkflowValue.Validate(archiveExpenses, nameof(archiveExpenses), required: false);
            return new DeferredBodyAction<BaseResultExportResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/export/expenses/{0}/", ExpressionConverter.ConvertWithUrlEncoding(exportId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (reportId != null)
                    callPayload.Queries["reportId"] = ExpressionConverter.Convert(reportId);
                if (categoryId != null)
                    callPayload.Queries["categoryId"] = ExpressionConverter.Convert(categoryId);
                if (expenseName != null)
                    callPayload.Queries["expenseName"] = ExpressionConverter.Convert(expenseName);
                if (startDate != null)
                    callPayload.Queries["startDate"] = ExpressionConverter.Convert(startDate);
                if (endDate != null)
                    callPayload.Queries["endDate"] = ExpressionConverter.Convert(endDate);
                if (expenseStates != null)
                    callPayload.Queries["expenseStates"] = ExpressionConverter.Convert(expenseStates);
                if (reportStates != null)
                    callPayload.Queries["reportStates"] = ExpressionConverter.Convert(reportStates);
                if (userIds != null)
                    callPayload.Queries["userIds"] = ExpressionConverter.Convert(userIds);
                if (userMail != null)
                    callPayload.Queries["userMail"] = ExpressionConverter.Convert(userMail);
                if (reportIds != null)
                    callPayload.Queries["reportIds"] = ExpressionConverter.Convert(reportIds);
                if (expenseIds != null)
                    callPayload.Queries["expenseIds"] = ExpressionConverter.Convert(expenseIds);
                if (reportName != null)
                    callPayload.Queries["reportName"] = ExpressionConverter.Convert(reportName);
                if (reportIdShort != null)
                    callPayload.Queries["reportIdShort"] = ExpressionConverter.Convert(reportIdShort);
                if (dateFilterType != null)
                    callPayload.Queries["dateFilterType"] = ExpressionConverter.Convert(dateFilterType);
                if (payId != null)
                    callPayload.Queries["payId"] = ExpressionConverter.Convert(payId);
                if (payId2 != null)
                    callPayload.Queries["payId2"] = ExpressionConverter.Convert(payId2);
                if (payId3 != null)
                    callPayload.Queries["payId3"] = ExpressionConverter.Convert(payId3);
                if (accountingPeriod != null)
                    callPayload.Queries["accountingPeriod"] = ExpressionConverter.Convert(accountingPeriod);
                if (includeReceipts != null)
                    callPayload.Queries["includeReceipts"] = ExpressionConverter.Convert(includeReceipts);
                if (expenseUseTypes != null)
                    callPayload.Queries["expenseUseTypes"] = ExpressionConverter.Convert(expenseUseTypes);
                if (archiveExpenses != null)
                    callPayload.Queries["archiveExpenses"] = ExpressionConverter.Convert(archiveExpenses);
                return new ApiConnectionAction<BaseResultExportResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expensya")]
        [WorkflowExpressionFactory(nameof(__BuildPrintMission))]
        public IBodyWorkflowAction<BaseResultExportResponse> PrintMission([WorkflowExpression] Func<string> reportId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BaseResultExportResponse> __BuildPrintMission(WorkflowValue<string> reportId)
        {
            WorkflowValue.Validate(reportId, nameof(reportId), required: true);
            return new DeferredBodyAction<BaseResultExportResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/export/report/{0}/pdf/", ExpressionConverter.ConvertWithUrlEncoding(reportId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<BaseResultExportResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expensya")]
        [WorkflowExpressionFactory(nameof(__BuildExportFormats))]
        public IBodyWorkflowAction<BaseResultListExportFormatResponse> ExportFormats([WorkflowExpression] Func<bool> isForExpenses = null, [WorkflowExpression] Func<int> exportType = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BaseResultListExportFormatResponse> __BuildExportFormats(WorkflowValue<bool> isForExpenses = null, WorkflowValue<int> exportType = null)
        {
            WorkflowValue.Validate(isForExpenses, nameof(isForExpenses), required: false);
            WorkflowValue.Validate(exportType, nameof(exportType), required: false);
            return new DeferredBodyAction<BaseResultListExportFormatResponse>(() =>
            {
                var apiCallPath = "/api/exports/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (isForExpenses != null)
                    callPayload.Queries["isForExpenses"] = ExpressionConverter.Convert(isForExpenses);
                if (exportType != null)
                    callPayload.Queries["exportType"] = ExpressionConverter.Convert(exportType);
                return new ApiConnectionAction<BaseResultListExportFormatResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expensya")]
        [WorkflowExpressionFactory(nameof(__BuildAddProjects))]
        public IBodyWorkflowAction<BaseResultListAddOrUpdateEntityResult> AddProjects([WorkflowExpression] Func<AddOrUpdateProjectInput[]> addOrUpdateProjectInputArray = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BaseResultListAddOrUpdateEntityResult> __BuildAddProjects(WorkflowValue<AddOrUpdateProjectInput[]> addOrUpdateProjectInputArray = null)
        {
            WorkflowValue.Validate(addOrUpdateProjectInputArray, nameof(addOrUpdateProjectInputArray), required: false);
            return new DeferredBodyAction<BaseResultListAddOrUpdateEntityResult>(() =>
            {
                var apiCallPath = "/api/projects/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(addOrUpdateProjectInputArray);
                return new ApiConnectionAction<BaseResultListAddOrUpdateEntityResult>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expensya")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateProjects))]
        public IBodyWorkflowAction<BaseResultListAddOrUpdateEntityResult> UpdateProjects([WorkflowExpression] Func<AddOrUpdateProjectInput[]> addOrUpdateProjectInputArray = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BaseResultListAddOrUpdateEntityResult> __BuildUpdateProjects(WorkflowValue<AddOrUpdateProjectInput[]> addOrUpdateProjectInputArray = null)
        {
            WorkflowValue.Validate(addOrUpdateProjectInputArray, nameof(addOrUpdateProjectInputArray), required: false);
            return new DeferredBodyAction<BaseResultListAddOrUpdateEntityResult>(() =>
            {
                var apiCallPath = "/api/projects/";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(addOrUpdateProjectInputArray);
                return new ApiConnectionAction<BaseResultListAddOrUpdateEntityResult>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expensya")]
        [WorkflowExpressionFactory(nameof(__BuildAddReciept))]
        public IBodyWorkflowAction<BaseResult> AddReciept([WorkflowExpression] Func<string> addReceiptInputuserId, [WorkflowExpression] Func<string> addReceiptInputreceiptContent, [WorkflowExpression] Func<string> addReceiptInputreceiptName)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BaseResult> __BuildAddReciept(WorkflowValue<string> addReceiptInputuserId, WorkflowValue<string> addReceiptInputreceiptContent, WorkflowValue<string> addReceiptInputreceiptName)
        {
            WorkflowValue.Validate(addReceiptInputuserId, nameof(addReceiptInputuserId), required: true);
            WorkflowValue.Validate(addReceiptInputreceiptContent, nameof(addReceiptInputreceiptContent), required: true);
            WorkflowValue.Validate(addReceiptInputreceiptName, nameof(addReceiptInputreceiptName), required: true);
            return new DeferredBodyAction<BaseResult>(() =>
            {
                var apiCallPath = "/api/receipt/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var addReceiptInput = new JObject();
                var addReceiptInputpropCount = 0;
                addReceiptInputpropCount++;
                addReceiptInput["UserId"] = ExpressionConverter.ConvertO(addReceiptInputuserId);
                addReceiptInputpropCount++;
                addReceiptInput["ReceiptContent"] = ExpressionConverter.ConvertO(addReceiptInputreceiptContent);
                addReceiptInputpropCount++;
                addReceiptInput["ReceiptName"] = ExpressionConverter.ConvertO(addReceiptInputreceiptName);
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
        [WorkflowExpressionFactory(nameof(__BuildValidatorReports))]
        public IBodyWorkflowAction<ListAndPagesCountResultReportResponse> ValidatorReports([WorkflowExpression] Func<string> validatorMail, [WorkflowExpression] Func<string> reportName = null, [WorkflowExpression] Func<string> reportStartDate = null, [WorkflowExpression] Func<string> reportEndDate = null, [WorkflowExpression] Func<string> reportStates = null, [WorkflowExpression] Func<string> reportIdShort = null, [WorkflowExpression] Func<string> ownerId = null, [WorkflowExpression] Func<string> ownerPayId2 = null, [WorkflowExpression] Func<string> projectId = null, [WorkflowExpression] Func<int> dateFilterType = null, [WorkflowExpression] Func<int> sortBy = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null, [WorkflowExpression] Func<bool> isDesc = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ListAndPagesCountResultReportResponse> __BuildValidatorReports(WorkflowValue<string> validatorMail, WorkflowValue<string> reportName = null, WorkflowValue<string> reportStartDate = null, WorkflowValue<string> reportEndDate = null, WorkflowValue<string> reportStates = null, WorkflowValue<string> reportIdShort = null, WorkflowValue<string> ownerId = null, WorkflowValue<string> ownerPayId2 = null, WorkflowValue<string> projectId = null, WorkflowValue<int> dateFilterType = null, WorkflowValue<int> sortBy = null, WorkflowValue<int> page = null, WorkflowValue<int> pageSize = null, WorkflowValue<bool> isDesc = null)
        {
            WorkflowValue.Validate(validatorMail, nameof(validatorMail), required: true);
            WorkflowValue.Validate(reportName, nameof(reportName), required: false);
            WorkflowValue.Validate(reportStartDate, nameof(reportStartDate), required: false);
            WorkflowValue.Validate(reportEndDate, nameof(reportEndDate), required: false);
            WorkflowValue.Validate(reportStates, nameof(reportStates), required: false);
            WorkflowValue.Validate(reportIdShort, nameof(reportIdShort), required: false);
            WorkflowValue.Validate(ownerId, nameof(ownerId), required: false);
            WorkflowValue.Validate(ownerPayId2, nameof(ownerPayId2), required: false);
            WorkflowValue.Validate(projectId, nameof(projectId), required: false);
            WorkflowValue.Validate(dateFilterType, nameof(dateFilterType), required: false);
            WorkflowValue.Validate(sortBy, nameof(sortBy), required: false);
            WorkflowValue.Validate(page, nameof(page), required: false);
            WorkflowValue.Validate(pageSize, nameof(pageSize), required: false);
            WorkflowValue.Validate(isDesc, nameof(isDesc), required: false);
            return new DeferredBodyAction<ListAndPagesCountResultReportResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v2/{0}/reports/", ExpressionConverter.ConvertWithUrlEncoding(validatorMail, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (reportName != null)
                    callPayload.Queries["reportName"] = ExpressionConverter.Convert(reportName);
                if (reportStartDate != null)
                    callPayload.Queries["reportStartDate"] = ExpressionConverter.Convert(reportStartDate);
                if (reportEndDate != null)
                    callPayload.Queries["reportEndDate"] = ExpressionConverter.Convert(reportEndDate);
                if (reportStates != null)
                    callPayload.Queries["reportStates"] = ExpressionConverter.Convert(reportStates);
                if (reportIdShort != null)
                    callPayload.Queries["reportIdShort"] = ExpressionConverter.Convert(reportIdShort);
                if (ownerId != null)
                    callPayload.Queries["ownerId"] = ExpressionConverter.Convert(ownerId);
                if (ownerPayId2 != null)
                    callPayload.Queries["ownerPayId2"] = ExpressionConverter.Convert(ownerPayId2);
                if (projectId != null)
                    callPayload.Queries["projectId"] = ExpressionConverter.Convert(projectId);
                if (dateFilterType != null)
                    callPayload.Queries["dateFilterType"] = ExpressionConverter.Convert(dateFilterType);
                if (sortBy != null)
                    callPayload.Queries["sortBy"] = ExpressionConverter.Convert(sortBy);
                if (page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(page);
                if (pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(pageSize);
                if (isDesc != null)
                    callPayload.Queries["isDesc"] = ExpressionConverter.Convert(isDesc);
                return new ApiConnectionAction<ListAndPagesCountResultReportResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expensya")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateReportStatus))]
        public IBodyWorkflowAction<BaseResult> UpdateReportStatus([WorkflowExpression] Func<string> reportId, [WorkflowExpression] Func<reportUpdateStatusInputoperationInput> reportUpdateStatusInputoperation, [WorkflowExpression] Func<string> reportUpdateStatusInputmessage, [WorkflowExpression] Func<string[]> reportUpdateStatusInputinvoiceIdsToReject = null, [WorkflowExpression] Func<string> reportUpdateStatusInputaccountingPeriod = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BaseResult> __BuildUpdateReportStatus(WorkflowValue<string> reportId, WorkflowValue<reportUpdateStatusInputoperationInput> reportUpdateStatusInputoperation, WorkflowValue<string> reportUpdateStatusInputmessage, WorkflowValue<string[]> reportUpdateStatusInputinvoiceIdsToReject = null, WorkflowValue<string> reportUpdateStatusInputaccountingPeriod = null)
        {
            WorkflowValue.Validate(reportId, nameof(reportId), required: true);
            WorkflowValue.Validate(reportUpdateStatusInputoperation, nameof(reportUpdateStatusInputoperation), required: true);
            WorkflowValue.Validate(reportUpdateStatusInputmessage, nameof(reportUpdateStatusInputmessage), required: true);
            WorkflowValue.Validate(reportUpdateStatusInputinvoiceIdsToReject, nameof(reportUpdateStatusInputinvoiceIdsToReject), required: false);
            WorkflowValue.Validate(reportUpdateStatusInputaccountingPeriod, nameof(reportUpdateStatusInputaccountingPeriod), required: false);
            return new DeferredBodyAction<BaseResult>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v2/report/{0}/updateStatus/", ExpressionConverter.ConvertWithUrlEncoding(reportId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var reportUpdateStatusInput = new JObject();
                var reportUpdateStatusInputpropCount = 0;
                reportUpdateStatusInputpropCount++;
                reportUpdateStatusInput["Operation"] = ExpressionConverter.ConvertO(reportUpdateStatusInputoperation);
                reportUpdateStatusInputpropCount++;
                reportUpdateStatusInput["Message"] = ExpressionConverter.ConvertO(reportUpdateStatusInputmessage);
                if (reportUpdateStatusInputinvoiceIdsToReject != null)
                {
                    reportUpdateStatusInput["InvoiceIdsToReject"] = ExpressionConverter.ConvertO(reportUpdateStatusInputinvoiceIdsToReject);
                    reportUpdateStatusInputpropCount++;
                }

                if (reportUpdateStatusInputaccountingPeriod != null)
                {
                    reportUpdateStatusInput["AccountingPeriod"] = ExpressionConverter.ConvertO(reportUpdateStatusInputaccountingPeriod);
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
        [WorkflowExpressionFactory(nameof(__BuildCompanyReports))]
        public IBodyWorkflowAction<ListAndPagesCountResultReportResponse> CompanyReports([WorkflowExpression] Func<string> reportName = null, [WorkflowExpression] Func<string> reportStartDate = null, [WorkflowExpression] Func<string> reportEndDate = null, [WorkflowExpression] Func<string> reportStates = null, [WorkflowExpression] Func<string> reportIdShort = null, [WorkflowExpression] Func<string> ownerId = null, [WorkflowExpression] Func<string> ownerPayId2 = null, [WorkflowExpression] Func<string> projectId = null, [WorkflowExpression] Func<string> tagsNames = null, [WorkflowExpression] Func<int> dateFilterType = null, [WorkflowExpression] Func<int> sortBy = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null, [WorkflowExpression] Func<bool> isDesc = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ListAndPagesCountResultReportResponse> __BuildCompanyReports(WorkflowValue<string> reportName = null, WorkflowValue<string> reportStartDate = null, WorkflowValue<string> reportEndDate = null, WorkflowValue<string> reportStates = null, WorkflowValue<string> reportIdShort = null, WorkflowValue<string> ownerId = null, WorkflowValue<string> ownerPayId2 = null, WorkflowValue<string> projectId = null, WorkflowValue<string> tagsNames = null, WorkflowValue<int> dateFilterType = null, WorkflowValue<int> sortBy = null, WorkflowValue<int> page = null, WorkflowValue<int> pageSize = null, WorkflowValue<bool> isDesc = null)
        {
            WorkflowValue.Validate(reportName, nameof(reportName), required: false);
            WorkflowValue.Validate(reportStartDate, nameof(reportStartDate), required: false);
            WorkflowValue.Validate(reportEndDate, nameof(reportEndDate), required: false);
            WorkflowValue.Validate(reportStates, nameof(reportStates), required: false);
            WorkflowValue.Validate(reportIdShort, nameof(reportIdShort), required: false);
            WorkflowValue.Validate(ownerId, nameof(ownerId), required: false);
            WorkflowValue.Validate(ownerPayId2, nameof(ownerPayId2), required: false);
            WorkflowValue.Validate(projectId, nameof(projectId), required: false);
            WorkflowValue.Validate(tagsNames, nameof(tagsNames), required: false);
            WorkflowValue.Validate(dateFilterType, nameof(dateFilterType), required: false);
            WorkflowValue.Validate(sortBy, nameof(sortBy), required: false);
            WorkflowValue.Validate(page, nameof(page), required: false);
            WorkflowValue.Validate(pageSize, nameof(pageSize), required: false);
            WorkflowValue.Validate(isDesc, nameof(isDesc), required: false);
            return new DeferredBodyAction<ListAndPagesCountResultReportResponse>(() =>
            {
                var apiCallPath = "/api/v2/reports/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (reportName != null)
                    callPayload.Queries["reportName"] = ExpressionConverter.Convert(reportName);
                if (reportStartDate != null)
                    callPayload.Queries["reportStartDate"] = ExpressionConverter.Convert(reportStartDate);
                if (reportEndDate != null)
                    callPayload.Queries["reportEndDate"] = ExpressionConverter.Convert(reportEndDate);
                if (reportStates != null)
                    callPayload.Queries["reportStates"] = ExpressionConverter.Convert(reportStates);
                if (reportIdShort != null)
                    callPayload.Queries["reportIdShort"] = ExpressionConverter.Convert(reportIdShort);
                if (ownerId != null)
                    callPayload.Queries["ownerId"] = ExpressionConverter.Convert(ownerId);
                if (ownerPayId2 != null)
                    callPayload.Queries["ownerPayId2"] = ExpressionConverter.Convert(ownerPayId2);
                if (projectId != null)
                    callPayload.Queries["projectId"] = ExpressionConverter.Convert(projectId);
                if (tagsNames != null)
                    callPayload.Queries["tagsNames"] = ExpressionConverter.Convert(tagsNames);
                if (dateFilterType != null)
                    callPayload.Queries["dateFilterType"] = ExpressionConverter.Convert(dateFilterType);
                if (sortBy != null)
                    callPayload.Queries["sortBy"] = ExpressionConverter.Convert(sortBy);
                if (page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(page);
                if (pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(pageSize);
                if (isDesc != null)
                    callPayload.Queries["isDesc"] = ExpressionConverter.Convert(isDesc);
                return new ApiConnectionAction<ListAndPagesCountResultReportResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expensya")]
        [WorkflowExpressionFactory(nameof(__BuildCompanyUsers))]
        public IBodyWorkflowAction<ListAndPagesCountResultUserResponse> CompanyUsers([WorkflowExpression] Func<string> id = null, [WorkflowExpression] Func<string> firstName = null, [WorkflowExpression] Func<string> lastName = null, [WorkflowExpression] Func<string> mail = null, [WorkflowExpression] Func<string> payId = null, [WorkflowExpression] Func<string> mailOrNameOrPayId = null, [WorkflowExpression] Func<int> type = null, [WorkflowExpression] Func<int> state = null, [WorkflowExpression] Func<string> reviewerId = null, [WorkflowExpression] Func<string> reviewerName = null, [WorkflowExpression] Func<string> managerId = null, [WorkflowExpression] Func<string> managerName = null, [WorkflowExpression] Func<string> userIds = null, [WorkflowExpression] Func<string> userMails = null, [WorkflowExpression] Func<string> tagsNames = null, [WorkflowExpression] Func<string> simpleTagsNames = null, [WorkflowExpression] Func<int> sortBy = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null, [WorkflowExpression] Func<bool> isDesc = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ListAndPagesCountResultUserResponse> __BuildCompanyUsers(WorkflowValue<string> id = null, WorkflowValue<string> firstName = null, WorkflowValue<string> lastName = null, WorkflowValue<string> mail = null, WorkflowValue<string> payId = null, WorkflowValue<string> mailOrNameOrPayId = null, WorkflowValue<int> type = null, WorkflowValue<int> state = null, WorkflowValue<string> reviewerId = null, WorkflowValue<string> reviewerName = null, WorkflowValue<string> managerId = null, WorkflowValue<string> managerName = null, WorkflowValue<string> userIds = null, WorkflowValue<string> userMails = null, WorkflowValue<string> tagsNames = null, WorkflowValue<string> simpleTagsNames = null, WorkflowValue<int> sortBy = null, WorkflowValue<int> page = null, WorkflowValue<int> pageSize = null, WorkflowValue<bool> isDesc = null)
        {
            WorkflowValue.Validate(id, nameof(id), required: false);
            WorkflowValue.Validate(firstName, nameof(firstName), required: false);
            WorkflowValue.Validate(lastName, nameof(lastName), required: false);
            WorkflowValue.Validate(mail, nameof(mail), required: false);
            WorkflowValue.Validate(payId, nameof(payId), required: false);
            WorkflowValue.Validate(mailOrNameOrPayId, nameof(mailOrNameOrPayId), required: false);
            WorkflowValue.Validate(type, nameof(type), required: false);
            WorkflowValue.Validate(state, nameof(state), required: false);
            WorkflowValue.Validate(reviewerId, nameof(reviewerId), required: false);
            WorkflowValue.Validate(reviewerName, nameof(reviewerName), required: false);
            WorkflowValue.Validate(managerId, nameof(managerId), required: false);
            WorkflowValue.Validate(managerName, nameof(managerName), required: false);
            WorkflowValue.Validate(userIds, nameof(userIds), required: false);
            WorkflowValue.Validate(userMails, nameof(userMails), required: false);
            WorkflowValue.Validate(tagsNames, nameof(tagsNames), required: false);
            WorkflowValue.Validate(simpleTagsNames, nameof(simpleTagsNames), required: false);
            WorkflowValue.Validate(sortBy, nameof(sortBy), required: false);
            WorkflowValue.Validate(page, nameof(page), required: false);
            WorkflowValue.Validate(pageSize, nameof(pageSize), required: false);
            WorkflowValue.Validate(isDesc, nameof(isDesc), required: false);
            return new DeferredBodyAction<ListAndPagesCountResultUserResponse>(() =>
            {
                var apiCallPath = "/api/v2/users/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (id != null)
                    callPayload.Queries["id"] = ExpressionConverter.Convert(id);
                if (firstName != null)
                    callPayload.Queries["firstName"] = ExpressionConverter.Convert(firstName);
                if (lastName != null)
                    callPayload.Queries["lastName"] = ExpressionConverter.Convert(lastName);
                if (mail != null)
                    callPayload.Queries["mail"] = ExpressionConverter.Convert(mail);
                if (payId != null)
                    callPayload.Queries["payId"] = ExpressionConverter.Convert(payId);
                if (mailOrNameOrPayId != null)
                    callPayload.Queries["mailOrNameOrPayId"] = ExpressionConverter.Convert(mailOrNameOrPayId);
                if (type != null)
                    callPayload.Queries["type"] = ExpressionConverter.Convert(type);
                if (state != null)
                    callPayload.Queries["state"] = ExpressionConverter.Convert(state);
                if (reviewerId != null)
                    callPayload.Queries["reviewerId"] = ExpressionConverter.Convert(reviewerId);
                if (reviewerName != null)
                    callPayload.Queries["reviewerName"] = ExpressionConverter.Convert(reviewerName);
                if (managerId != null)
                    callPayload.Queries["managerId"] = ExpressionConverter.Convert(managerId);
                if (managerName != null)
                    callPayload.Queries["managerName"] = ExpressionConverter.Convert(managerName);
                if (userIds != null)
                    callPayload.Queries["userIds"] = ExpressionConverter.Convert(userIds);
                if (userMails != null)
                    callPayload.Queries["userMails"] = ExpressionConverter.Convert(userMails);
                if (tagsNames != null)
                    callPayload.Queries["tagsNames"] = ExpressionConverter.Convert(tagsNames);
                if (simpleTagsNames != null)
                    callPayload.Queries["simpleTagsNames"] = ExpressionConverter.Convert(simpleTagsNames);
                if (sortBy != null)
                    callPayload.Queries["sortBy"] = ExpressionConverter.Convert(sortBy);
                if (page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(page);
                if (pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(pageSize);
                if (isDesc != null)
                    callPayload.Queries["isDesc"] = ExpressionConverter.Convert(isDesc);
                return new ApiConnectionAction<ListAndPagesCountResultUserResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expensya")]
        [WorkflowExpressionFactory(nameof(__BuildAddQuickExpense))]
        public IBodyWorkflowAction<BaseResult> AddQuickExpense([WorkflowExpression] Func<string> userId, [WorkflowExpression] Func<string> quickExpenseInputfileToSend, [WorkflowExpression] Func<string> quickExpenseInputtitle = null, [WorkflowExpression] Func<double> quickExpenseInputtransactionAmount = null, [WorkflowExpression] Func<string> quickExpenseInputvatRates = null, [WorkflowExpression] Func<string> quickExpenseInputvatAmounts = null, [WorkflowExpression] Func<string> quickExpenseInputcurrencyCode = null, [WorkflowExpression] Func<string> quickExpenseInputtransactionDate = null, [WorkflowExpression] Func<string> quickExpenseInputmerchantName = null, [WorkflowExpression] Func<string> quickExpenseInputlocationCountry = null, [WorkflowExpression] Func<string> quickExpenseInputlocationCity = null, [WorkflowExpression] Func<string> quickExpenseInputcomment = null, [WorkflowExpression] Func<string> quickExpenseInputmerchantExpenseId = null, [WorkflowExpression] Func<bool> quickExpenseInputisEncrypted = null, [WorkflowExpression] Func<quickExpenseInputexpenseUseTypeInput> quickExpenseInputexpenseUseType = null, [WorkflowExpression] Func<string> quickExpenseInputpaymentTypeCode = null, [WorkflowExpression] Func<string> quickExpenseInputexpenseTypeCode = null, [WorkflowExpression] Func<string> quickExpenseInputfileType = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BaseResult> __BuildAddQuickExpense(WorkflowValue<string> userId, WorkflowValue<string> quickExpenseInputfileToSend, WorkflowValue<string> quickExpenseInputtitle = null, WorkflowValue<double> quickExpenseInputtransactionAmount = null, WorkflowValue<string> quickExpenseInputvatRates = null, WorkflowValue<string> quickExpenseInputvatAmounts = null, WorkflowValue<string> quickExpenseInputcurrencyCode = null, WorkflowValue<string> quickExpenseInputtransactionDate = null, WorkflowValue<string> quickExpenseInputmerchantName = null, WorkflowValue<string> quickExpenseInputlocationCountry = null, WorkflowValue<string> quickExpenseInputlocationCity = null, WorkflowValue<string> quickExpenseInputcomment = null, WorkflowValue<string> quickExpenseInputmerchantExpenseId = null, WorkflowValue<bool> quickExpenseInputisEncrypted = null, WorkflowValue<quickExpenseInputexpenseUseTypeInput> quickExpenseInputexpenseUseType = null, WorkflowValue<string> quickExpenseInputpaymentTypeCode = null, WorkflowValue<string> quickExpenseInputexpenseTypeCode = null, WorkflowValue<string> quickExpenseInputfileType = null)
        {
            WorkflowValue.Validate(userId, nameof(userId), required: true);
            WorkflowValue.Validate(quickExpenseInputfileToSend, nameof(quickExpenseInputfileToSend), required: true);
            WorkflowValue.Validate(quickExpenseInputtitle, nameof(quickExpenseInputtitle), required: false);
            WorkflowValue.Validate(quickExpenseInputtransactionAmount, nameof(quickExpenseInputtransactionAmount), required: false);
            WorkflowValue.Validate(quickExpenseInputvatRates, nameof(quickExpenseInputvatRates), required: false);
            WorkflowValue.Validate(quickExpenseInputvatAmounts, nameof(quickExpenseInputvatAmounts), required: false);
            WorkflowValue.Validate(quickExpenseInputcurrencyCode, nameof(quickExpenseInputcurrencyCode), required: false);
            WorkflowValue.Validate(quickExpenseInputtransactionDate, nameof(quickExpenseInputtransactionDate), required: false);
            WorkflowValue.Validate(quickExpenseInputmerchantName, nameof(quickExpenseInputmerchantName), required: false);
            WorkflowValue.Validate(quickExpenseInputlocationCountry, nameof(quickExpenseInputlocationCountry), required: false);
            WorkflowValue.Validate(quickExpenseInputlocationCity, nameof(quickExpenseInputlocationCity), required: false);
            WorkflowValue.Validate(quickExpenseInputcomment, nameof(quickExpenseInputcomment), required: false);
            WorkflowValue.Validate(quickExpenseInputmerchantExpenseId, nameof(quickExpenseInputmerchantExpenseId), required: false);
            WorkflowValue.Validate(quickExpenseInputisEncrypted, nameof(quickExpenseInputisEncrypted), required: false);
            WorkflowValue.Validate(quickExpenseInputexpenseUseType, nameof(quickExpenseInputexpenseUseType), required: false);
            WorkflowValue.Validate(quickExpenseInputpaymentTypeCode, nameof(quickExpenseInputpaymentTypeCode), required: false);
            WorkflowValue.Validate(quickExpenseInputexpenseTypeCode, nameof(quickExpenseInputexpenseTypeCode), required: false);
            WorkflowValue.Validate(quickExpenseInputfileType, nameof(quickExpenseInputfileType), required: false);
            return new DeferredBodyAction<BaseResult>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v2/quickexpense/{0}/", ExpressionConverter.ConvertWithUrlEncoding(userId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var quickExpenseInput = new JObject();
                var quickExpenseInputpropCount = 0;
                quickExpenseInputpropCount++;
                quickExpenseInput["FileToSend"] = ExpressionConverter.ConvertO(quickExpenseInputfileToSend);
                if (quickExpenseInputtitle != null)
                {
                    quickExpenseInput["Title"] = ExpressionConverter.ConvertO(quickExpenseInputtitle);
                    quickExpenseInputpropCount++;
                }

                if (quickExpenseInputtransactionAmount != null)
                {
                    quickExpenseInput["TransactionAmount"] = ExpressionConverter.ConvertO(quickExpenseInputtransactionAmount);
                    quickExpenseInputpropCount++;
                }

                if (quickExpenseInputvatRates != null)
                {
                    quickExpenseInput["VatRates"] = ExpressionConverter.ConvertO(quickExpenseInputvatRates);
                    quickExpenseInputpropCount++;
                }

                if (quickExpenseInputvatAmounts != null)
                {
                    quickExpenseInput["VatAmounts"] = ExpressionConverter.ConvertO(quickExpenseInputvatAmounts);
                    quickExpenseInputpropCount++;
                }

                if (quickExpenseInputcurrencyCode != null)
                {
                    quickExpenseInput["CurrencyCode"] = ExpressionConverter.ConvertO(quickExpenseInputcurrencyCode);
                    quickExpenseInputpropCount++;
                }

                if (quickExpenseInputtransactionDate != null)
                {
                    quickExpenseInput["TransactionDate"] = ExpressionConverter.ConvertO(quickExpenseInputtransactionDate);
                    quickExpenseInputpropCount++;
                }

                if (quickExpenseInputmerchantName != null)
                {
                    quickExpenseInput["MerchantName"] = ExpressionConverter.ConvertO(quickExpenseInputmerchantName);
                    quickExpenseInputpropCount++;
                }

                if (quickExpenseInputlocationCountry != null)
                {
                    quickExpenseInput["LocationCountry"] = ExpressionConverter.ConvertO(quickExpenseInputlocationCountry);
                    quickExpenseInputpropCount++;
                }

                if (quickExpenseInputlocationCity != null)
                {
                    quickExpenseInput["LocationCity"] = ExpressionConverter.ConvertO(quickExpenseInputlocationCity);
                    quickExpenseInputpropCount++;
                }

                if (quickExpenseInputcomment != null)
                {
                    quickExpenseInput["Comment"] = ExpressionConverter.ConvertO(quickExpenseInputcomment);
                    quickExpenseInputpropCount++;
                }

                if (quickExpenseInputmerchantExpenseId != null)
                {
                    quickExpenseInput["MerchantExpenseId"] = ExpressionConverter.ConvertO(quickExpenseInputmerchantExpenseId);
                    quickExpenseInputpropCount++;
                }

                if (quickExpenseInputisEncrypted != null)
                {
                    quickExpenseInput["IsEncrypted"] = ExpressionConverter.ConvertO(quickExpenseInputisEncrypted);
                    quickExpenseInputpropCount++;
                }

                if (quickExpenseInputexpenseUseType != null)
                {
                    quickExpenseInput["ExpenseUseType"] = ExpressionConverter.ConvertO(quickExpenseInputexpenseUseType);
                    quickExpenseInputpropCount++;
                }

                if (quickExpenseInputpaymentTypeCode != null)
                {
                    quickExpenseInput["PaymentTypeCode"] = ExpressionConverter.ConvertO(quickExpenseInputpaymentTypeCode);
                    quickExpenseInputpropCount++;
                }

                if (quickExpenseInputexpenseTypeCode != null)
                {
                    quickExpenseInput["ExpenseTypeCode"] = ExpressionConverter.ConvertO(quickExpenseInputexpenseTypeCode);
                    quickExpenseInputpropCount++;
                }

                if (quickExpenseInputfileType != null)
                {
                    quickExpenseInput["FileType"] = ExpressionConverter.ConvertO(quickExpenseInputfileType);
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
        [WorkflowExpressionFactory(nameof(__BuildGetCategories))]
        public IBodyWorkflowAction<ListAndPagesCountResultCategoryResponse> GetCategories([WorkflowExpression] Func<string> id = null, [WorkflowExpression] Func<string> categoryName = null, [WorkflowExpression] Func<string> costAccount = null, [WorkflowExpression] Func<string> vatAccount = null, [WorkflowExpression] Func<bool> isActive = null, [WorkflowExpression] Func<string> tagsNames = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null, [WorkflowExpression] Func<int> sortBy = null, [WorkflowExpression] Func<bool> isDesc = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ListAndPagesCountResultCategoryResponse> __BuildGetCategories(WorkflowValue<string> id = null, WorkflowValue<string> categoryName = null, WorkflowValue<string> costAccount = null, WorkflowValue<string> vatAccount = null, WorkflowValue<bool> isActive = null, WorkflowValue<string> tagsNames = null, WorkflowValue<int> page = null, WorkflowValue<int> pageSize = null, WorkflowValue<int> sortBy = null, WorkflowValue<bool> isDesc = null)
        {
            WorkflowValue.Validate(id, nameof(id), required: false);
            WorkflowValue.Validate(categoryName, nameof(categoryName), required: false);
            WorkflowValue.Validate(costAccount, nameof(costAccount), required: false);
            WorkflowValue.Validate(vatAccount, nameof(vatAccount), required: false);
            WorkflowValue.Validate(isActive, nameof(isActive), required: false);
            WorkflowValue.Validate(tagsNames, nameof(tagsNames), required: false);
            WorkflowValue.Validate(page, nameof(page), required: false);
            WorkflowValue.Validate(pageSize, nameof(pageSize), required: false);
            WorkflowValue.Validate(sortBy, nameof(sortBy), required: false);
            WorkflowValue.Validate(isDesc, nameof(isDesc), required: false);
            return new DeferredBodyAction<ListAndPagesCountResultCategoryResponse>(() =>
            {
                var apiCallPath = "/api/v2/categories/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (id != null)
                    callPayload.Queries["id"] = ExpressionConverter.Convert(id);
                if (categoryName != null)
                    callPayload.Queries["categoryName"] = ExpressionConverter.Convert(categoryName);
                if (costAccount != null)
                    callPayload.Queries["costAccount"] = ExpressionConverter.Convert(costAccount);
                if (vatAccount != null)
                    callPayload.Queries["vatAccount"] = ExpressionConverter.Convert(vatAccount);
                if (isActive != null)
                    callPayload.Queries["isActive"] = ExpressionConverter.Convert(isActive);
                if (tagsNames != null)
                    callPayload.Queries["tagsNames"] = ExpressionConverter.Convert(tagsNames);
                if (page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(page);
                if (pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(pageSize);
                if (sortBy != null)
                    callPayload.Queries["sortBy"] = ExpressionConverter.Convert(sortBy);
                if (isDesc != null)
                    callPayload.Queries["isDesc"] = ExpressionConverter.Convert(isDesc);
                return new ApiConnectionAction<ListAndPagesCountResultCategoryResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expensya")]
        [WorkflowExpressionFactory(nameof(__BuildGetExpensesWithPaging))]
        public IBodyWorkflowAction<ListAndPagesCountResultExpenseResponse> GetExpensesWithPaging([WorkflowExpression] Func<string> reportId = null, [WorkflowExpression] Func<string> categoryId = null, [WorkflowExpression] Func<string> expenseName = null, [WorkflowExpression] Func<string> startDate = null, [WorkflowExpression] Func<string> endDate = null, [WorkflowExpression] Func<int> reportState = null, [WorkflowExpression] Func<string> expenseStates = null, [WorkflowExpression] Func<bool> isReimbusable = null, [WorkflowExpression] Func<double> valueInCurrency = null, [WorkflowExpression] Func<string> ownerId = null, [WorkflowExpression] Func<string> ownerMail = null, [WorkflowExpression] Func<string> ownerPayId = null, [WorkflowExpression] Func<string> ownerPayId2 = null, [WorkflowExpression] Func<string> ownerPayId3 = null, [WorkflowExpression] Func<string> ownerPayId4 = null, [WorkflowExpression] Func<string> ownerPayId5 = null, [WorkflowExpression] Func<string> ownerPayId6 = null, [WorkflowExpression] Func<string> projectId = null, [WorkflowExpression] Func<bool> isBillable = null, [WorkflowExpression] Func<int> dateFilterType = null, [WorkflowExpression] Func<string> merchantCountries = null, [WorkflowExpression] Func<string> currencies = null, [WorkflowExpression] Func<string> fileType = null, [WorkflowExpression] Func<string> reportIdShort = null, [WorkflowExpression] Func<string> expenseUseTypes = null, [WorkflowExpression] Func<string> supplierId = null, [WorkflowExpression] Func<string> expenseIds = null, [WorkflowExpression] Func<string> merchantName = null, [WorkflowExpression] Func<string> vatCode = null, [WorkflowExpression] Func<double> valueHTInExpenseCurrency = null, [WorkflowExpression] Func<double> vatRate = null, [WorkflowExpression] Func<double> vatValue = null, [WorkflowExpression] Func<string> reportsIds = null, [WorkflowExpression] Func<int> dateTimeOffset = null, [WorkflowExpression] Func<string> tagsNames = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null, [WorkflowExpression] Func<int> sortBy = null, [WorkflowExpression] Func<bool> isDesc = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ListAndPagesCountResultExpenseResponse> __BuildGetExpensesWithPaging(WorkflowValue<string> reportId = null, WorkflowValue<string> categoryId = null, WorkflowValue<string> expenseName = null, WorkflowValue<string> startDate = null, WorkflowValue<string> endDate = null, WorkflowValue<int> reportState = null, WorkflowValue<string> expenseStates = null, WorkflowValue<bool> isReimbusable = null, WorkflowValue<double> valueInCurrency = null, WorkflowValue<string> ownerId = null, WorkflowValue<string> ownerMail = null, WorkflowValue<string> ownerPayId = null, WorkflowValue<string> ownerPayId2 = null, WorkflowValue<string> ownerPayId3 = null, WorkflowValue<string> ownerPayId4 = null, WorkflowValue<string> ownerPayId5 = null, WorkflowValue<string> ownerPayId6 = null, WorkflowValue<string> projectId = null, WorkflowValue<bool> isBillable = null, WorkflowValue<int> dateFilterType = null, WorkflowValue<string> merchantCountries = null, WorkflowValue<string> currencies = null, WorkflowValue<string> fileType = null, WorkflowValue<string> reportIdShort = null, WorkflowValue<string> expenseUseTypes = null, WorkflowValue<string> supplierId = null, WorkflowValue<string> expenseIds = null, WorkflowValue<string> merchantName = null, WorkflowValue<string> vatCode = null, WorkflowValue<double> valueHTInExpenseCurrency = null, WorkflowValue<double> vatRate = null, WorkflowValue<double> vatValue = null, WorkflowValue<string> reportsIds = null, WorkflowValue<int> dateTimeOffset = null, WorkflowValue<string> tagsNames = null, WorkflowValue<int> page = null, WorkflowValue<int> pageSize = null, WorkflowValue<int> sortBy = null, WorkflowValue<bool> isDesc = null)
        {
            WorkflowValue.Validate(reportId, nameof(reportId), required: false);
            WorkflowValue.Validate(categoryId, nameof(categoryId), required: false);
            WorkflowValue.Validate(expenseName, nameof(expenseName), required: false);
            WorkflowValue.Validate(startDate, nameof(startDate), required: false);
            WorkflowValue.Validate(endDate, nameof(endDate), required: false);
            WorkflowValue.Validate(reportState, nameof(reportState), required: false);
            WorkflowValue.Validate(expenseStates, nameof(expenseStates), required: false);
            WorkflowValue.Validate(isReimbusable, nameof(isReimbusable), required: false);
            WorkflowValue.Validate(valueInCurrency, nameof(valueInCurrency), required: false);
            WorkflowValue.Validate(ownerId, nameof(ownerId), required: false);
            WorkflowValue.Validate(ownerMail, nameof(ownerMail), required: false);
            WorkflowValue.Validate(ownerPayId, nameof(ownerPayId), required: false);
            WorkflowValue.Validate(ownerPayId2, nameof(ownerPayId2), required: false);
            WorkflowValue.Validate(ownerPayId3, nameof(ownerPayId3), required: false);
            WorkflowValue.Validate(ownerPayId4, nameof(ownerPayId4), required: false);
            WorkflowValue.Validate(ownerPayId5, nameof(ownerPayId5), required: false);
            WorkflowValue.Validate(ownerPayId6, nameof(ownerPayId6), required: false);
            WorkflowValue.Validate(projectId, nameof(projectId), required: false);
            WorkflowValue.Validate(isBillable, nameof(isBillable), required: false);
            WorkflowValue.Validate(dateFilterType, nameof(dateFilterType), required: false);
            WorkflowValue.Validate(merchantCountries, nameof(merchantCountries), required: false);
            WorkflowValue.Validate(currencies, nameof(currencies), required: false);
            WorkflowValue.Validate(fileType, nameof(fileType), required: false);
            WorkflowValue.Validate(reportIdShort, nameof(reportIdShort), required: false);
            WorkflowValue.Validate(expenseUseTypes, nameof(expenseUseTypes), required: false);
            WorkflowValue.Validate(supplierId, nameof(supplierId), required: false);
            WorkflowValue.Validate(expenseIds, nameof(expenseIds), required: false);
            WorkflowValue.Validate(merchantName, nameof(merchantName), required: false);
            WorkflowValue.Validate(vatCode, nameof(vatCode), required: false);
            WorkflowValue.Validate(valueHTInExpenseCurrency, nameof(valueHTInExpenseCurrency), required: false);
            WorkflowValue.Validate(vatRate, nameof(vatRate), required: false);
            WorkflowValue.Validate(vatValue, nameof(vatValue), required: false);
            WorkflowValue.Validate(reportsIds, nameof(reportsIds), required: false);
            WorkflowValue.Validate(dateTimeOffset, nameof(dateTimeOffset), required: false);
            WorkflowValue.Validate(tagsNames, nameof(tagsNames), required: false);
            WorkflowValue.Validate(page, nameof(page), required: false);
            WorkflowValue.Validate(pageSize, nameof(pageSize), required: false);
            WorkflowValue.Validate(sortBy, nameof(sortBy), required: false);
            WorkflowValue.Validate(isDesc, nameof(isDesc), required: false);
            return new DeferredBodyAction<ListAndPagesCountResultExpenseResponse>(() =>
            {
                var apiCallPath = "/api/v2/expenses/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (reportId != null)
                    callPayload.Queries["reportId"] = ExpressionConverter.Convert(reportId);
                if (categoryId != null)
                    callPayload.Queries["categoryId"] = ExpressionConverter.Convert(categoryId);
                if (expenseName != null)
                    callPayload.Queries["expenseName"] = ExpressionConverter.Convert(expenseName);
                if (startDate != null)
                    callPayload.Queries["startDate"] = ExpressionConverter.Convert(startDate);
                if (endDate != null)
                    callPayload.Queries["endDate"] = ExpressionConverter.Convert(endDate);
                if (reportState != null)
                    callPayload.Queries["reportState"] = ExpressionConverter.Convert(reportState);
                if (expenseStates != null)
                    callPayload.Queries["expenseStates"] = ExpressionConverter.Convert(expenseStates);
                if (isReimbusable != null)
                    callPayload.Queries["isReimbusable"] = ExpressionConverter.Convert(isReimbusable);
                if (valueInCurrency != null)
                    callPayload.Queries["valueInCurrency"] = ExpressionConverter.Convert(valueInCurrency);
                if (ownerId != null)
                    callPayload.Queries["ownerId"] = ExpressionConverter.Convert(ownerId);
                if (ownerMail != null)
                    callPayload.Queries["ownerMail"] = ExpressionConverter.Convert(ownerMail);
                if (ownerPayId != null)
                    callPayload.Queries["ownerPayId"] = ExpressionConverter.Convert(ownerPayId);
                if (ownerPayId2 != null)
                    callPayload.Queries["ownerPayId2"] = ExpressionConverter.Convert(ownerPayId2);
                if (ownerPayId3 != null)
                    callPayload.Queries["ownerPayId3"] = ExpressionConverter.Convert(ownerPayId3);
                if (ownerPayId4 != null)
                    callPayload.Queries["ownerPayId4"] = ExpressionConverter.Convert(ownerPayId4);
                if (ownerPayId5 != null)
                    callPayload.Queries["ownerPayId5"] = ExpressionConverter.Convert(ownerPayId5);
                if (ownerPayId6 != null)
                    callPayload.Queries["ownerPayId6"] = ExpressionConverter.Convert(ownerPayId6);
                if (projectId != null)
                    callPayload.Queries["projectId"] = ExpressionConverter.Convert(projectId);
                if (isBillable != null)
                    callPayload.Queries["isBillable"] = ExpressionConverter.Convert(isBillable);
                if (dateFilterType != null)
                    callPayload.Queries["dateFilterType"] = ExpressionConverter.Convert(dateFilterType);
                if (merchantCountries != null)
                    callPayload.Queries["merchantCountries"] = ExpressionConverter.Convert(merchantCountries);
                if (currencies != null)
                    callPayload.Queries["currencies"] = ExpressionConverter.Convert(currencies);
                if (fileType != null)
                    callPayload.Queries["fileType"] = ExpressionConverter.Convert(fileType);
                if (reportIdShort != null)
                    callPayload.Queries["reportIdShort"] = ExpressionConverter.Convert(reportIdShort);
                if (expenseUseTypes != null)
                    callPayload.Queries["expenseUseTypes"] = ExpressionConverter.Convert(expenseUseTypes);
                if (supplierId != null)
                    callPayload.Queries["supplierId"] = ExpressionConverter.Convert(supplierId);
                if (expenseIds != null)
                    callPayload.Queries["expenseIds"] = ExpressionConverter.Convert(expenseIds);
                if (merchantName != null)
                    callPayload.Queries["merchantName"] = ExpressionConverter.Convert(merchantName);
                if (vatCode != null)
                    callPayload.Queries["vatCode"] = ExpressionConverter.Convert(vatCode);
                if (valueHTInExpenseCurrency != null)
                    callPayload.Queries["valueHTInExpenseCurrency"] = ExpressionConverter.Convert(valueHTInExpenseCurrency);
                if (vatRate != null)
                    callPayload.Queries["vatRate"] = ExpressionConverter.Convert(vatRate);
                if (vatValue != null)
                    callPayload.Queries["vatValue"] = ExpressionConverter.Convert(vatValue);
                if (reportsIds != null)
                    callPayload.Queries["reportsIds"] = ExpressionConverter.Convert(reportsIds);
                if (dateTimeOffset != null)
                    callPayload.Queries["dateTimeOffset"] = ExpressionConverter.Convert(dateTimeOffset);
                if (tagsNames != null)
                    callPayload.Queries["tagsNames"] = ExpressionConverter.Convert(tagsNames);
                if (page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(page);
                if (pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(pageSize);
                if (sortBy != null)
                    callPayload.Queries["sortBy"] = ExpressionConverter.Convert(sortBy);
                if (isDesc != null)
                    callPayload.Queries["isDesc"] = ExpressionConverter.Convert(isDesc);
                return new ApiConnectionAction<ListAndPagesCountResultExpenseResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expensya")]
        [WorkflowExpressionFactory(nameof(__BuildGetProjectDetails))]
        public IBodyWorkflowAction<BaseResultProjectResponse> GetProjectDetails([WorkflowExpression] Func<string> projectId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BaseResultProjectResponse> __BuildGetProjectDetails(WorkflowValue<string> projectId)
        {
            WorkflowValue.Validate(projectId, nameof(projectId), required: true);
            return new DeferredBodyAction<BaseResultProjectResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v2/project/{0}/", ExpressionConverter.ConvertWithUrlEncoding(projectId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<BaseResultProjectResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expensya")]
        [WorkflowExpressionFactory(nameof(__BuildGetProjects))]
        public IBodyWorkflowAction<ListAndPagesCountResultProjectResponse> GetProjects([WorkflowExpression] Func<string> projectName = null, [WorkflowExpression] Func<string> projectIds = null, [WorkflowExpression] Func<string> validatorName = null, [WorkflowExpression] Func<string> projectReferenceOrExternalId = null, [WorkflowExpression] Func<bool> bringAllProjects = null, [WorkflowExpression] Func<int> projectUseType = null, [WorkflowExpression] Func<bool> isActive = null, [WorkflowExpression] Func<string> tagsNames = null, [WorkflowExpression] Func<string> customFieldsIds = null, [WorkflowExpression] Func<string> expenseDate = null, [WorkflowExpression] Func<string> userId = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null, [WorkflowExpression] Func<int> sortBy = null, [WorkflowExpression] Func<bool> isDesc = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ListAndPagesCountResultProjectResponse> __BuildGetProjects(WorkflowValue<string> projectName = null, WorkflowValue<string> projectIds = null, WorkflowValue<string> validatorName = null, WorkflowValue<string> projectReferenceOrExternalId = null, WorkflowValue<bool> bringAllProjects = null, WorkflowValue<int> projectUseType = null, WorkflowValue<bool> isActive = null, WorkflowValue<string> tagsNames = null, WorkflowValue<string> customFieldsIds = null, WorkflowValue<string> expenseDate = null, WorkflowValue<string> userId = null, WorkflowValue<int> page = null, WorkflowValue<int> pageSize = null, WorkflowValue<int> sortBy = null, WorkflowValue<bool> isDesc = null)
        {
            WorkflowValue.Validate(projectName, nameof(projectName), required: false);
            WorkflowValue.Validate(projectIds, nameof(projectIds), required: false);
            WorkflowValue.Validate(validatorName, nameof(validatorName), required: false);
            WorkflowValue.Validate(projectReferenceOrExternalId, nameof(projectReferenceOrExternalId), required: false);
            WorkflowValue.Validate(bringAllProjects, nameof(bringAllProjects), required: false);
            WorkflowValue.Validate(projectUseType, nameof(projectUseType), required: false);
            WorkflowValue.Validate(isActive, nameof(isActive), required: false);
            WorkflowValue.Validate(tagsNames, nameof(tagsNames), required: false);
            WorkflowValue.Validate(customFieldsIds, nameof(customFieldsIds), required: false);
            WorkflowValue.Validate(expenseDate, nameof(expenseDate), required: false);
            WorkflowValue.Validate(userId, nameof(userId), required: false);
            WorkflowValue.Validate(page, nameof(page), required: false);
            WorkflowValue.Validate(pageSize, nameof(pageSize), required: false);
            WorkflowValue.Validate(sortBy, nameof(sortBy), required: false);
            WorkflowValue.Validate(isDesc, nameof(isDesc), required: false);
            return new DeferredBodyAction<ListAndPagesCountResultProjectResponse>(() =>
            {
                var apiCallPath = "/api/v2/projects/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (projectName != null)
                    callPayload.Queries["projectName"] = ExpressionConverter.Convert(projectName);
                if (projectIds != null)
                    callPayload.Queries["projectIds"] = ExpressionConverter.Convert(projectIds);
                if (validatorName != null)
                    callPayload.Queries["validatorName"] = ExpressionConverter.Convert(validatorName);
                if (projectReferenceOrExternalId != null)
                    callPayload.Queries["projectReferenceOrExternalId"] = ExpressionConverter.Convert(projectReferenceOrExternalId);
                if (bringAllProjects != null)
                    callPayload.Queries["bringAllProjects"] = ExpressionConverter.Convert(bringAllProjects);
                if (projectUseType != null)
                    callPayload.Queries["projectUseType"] = ExpressionConverter.Convert(projectUseType);
                if (isActive != null)
                    callPayload.Queries["isActive"] = ExpressionConverter.Convert(isActive);
                if (tagsNames != null)
                    callPayload.Queries["tagsNames"] = ExpressionConverter.Convert(tagsNames);
                if (customFieldsIds != null)
                    callPayload.Queries["customFieldsIds"] = ExpressionConverter.Convert(customFieldsIds);
                if (expenseDate != null)
                    callPayload.Queries["expenseDate"] = ExpressionConverter.Convert(expenseDate);
                if (userId != null)
                    callPayload.Queries["userId"] = ExpressionConverter.Convert(userId);
                if (page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(page);
                if (pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(pageSize);
                if (sortBy != null)
                    callPayload.Queries["sortBy"] = ExpressionConverter.Convert(sortBy);
                if (isDesc != null)
                    callPayload.Queries["isDesc"] = ExpressionConverter.Convert(isDesc);
                return new ApiConnectionAction<ListAndPagesCountResultProjectResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expensya")]
        [WorkflowExpressionFactory(nameof(__BuildGetReportHistory))]
        public IBodyWorkflowAction<BaseResultListEventResponse> GetReportHistory([WorkflowExpression] Func<string> reportId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BaseResultListEventResponse> __BuildGetReportHistory(WorkflowValue<string> reportId)
        {
            WorkflowValue.Validate(reportId, nameof(reportId), required: true);
            return new DeferredBodyAction<BaseResultListEventResponse>(() =>
            {
                var apiCallPath = "/api/v2/report/history/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["reportId"] = ExpressionConverter.Convert(reportId);
                return new ApiConnectionAction<BaseResultListEventResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expensya")]
        [WorkflowExpressionFactory(nameof(__BuildInviteUser))]
        public IBodyWorkflowAction<BaseResult> InviteUser([WorkflowExpression] Func<string> userInviteInputlastName, [WorkflowExpression] Func<string> userInviteInputfirstName, [WorkflowExpression] Func<string> userInviteInputmail, [WorkflowExpression] Func<string> userInviteInputlanguage, [WorkflowExpression] Func<userInviteInputuserTypeInput> userInviteInputuserType, [WorkflowExpression] Func<userInviteInputuserRoleInput> userInviteInputuserRole, [WorkflowExpression] Func<string> userInviteInputmailAlias = null, [WorkflowExpression] Func<string> userInviteInputpayId = null, [WorkflowExpression] Func<string> userInviteInputpayId2 = null, [WorkflowExpression] Func<string> userInviteInputpayId3 = null, [WorkflowExpression] Func<string> userInviteInputpayId4 = null, [WorkflowExpression] Func<string> userInviteInputpayId5 = null, [WorkflowExpression] Func<string> userInviteInputpayId6 = null, [WorkflowExpression] Func<string> userInviteInputlocalCurrency = null, [WorkflowExpression] Func<string> userInviteInputlocalCountry = null, [WorkflowExpression] Func<string> userInviteInputmanagerId = null, [WorkflowExpression] Func<string> userInviteInputreviewerId = null, [WorkflowExpression] Func<string> userInviteInputvendor = null, [WorkflowExpression] Func<string> userInviteInputdefaultProjectId = null, [WorkflowExpression] Func<string> userInviteInputiKRatesId = null, [WorkflowExpression] Func<ValidatorInput[]> userInviteInputadditionalValidators = null, [WorkflowExpression] Func<string[]> userInviteInputtagsToAssign = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BaseResult> __BuildInviteUser(WorkflowValue<string> userInviteInputlastName, WorkflowValue<string> userInviteInputfirstName, WorkflowValue<string> userInviteInputmail, WorkflowValue<string> userInviteInputlanguage, WorkflowValue<userInviteInputuserTypeInput> userInviteInputuserType, WorkflowValue<userInviteInputuserRoleInput> userInviteInputuserRole, WorkflowValue<string> userInviteInputmailAlias = null, WorkflowValue<string> userInviteInputpayId = null, WorkflowValue<string> userInviteInputpayId2 = null, WorkflowValue<string> userInviteInputpayId3 = null, WorkflowValue<string> userInviteInputpayId4 = null, WorkflowValue<string> userInviteInputpayId5 = null, WorkflowValue<string> userInviteInputpayId6 = null, WorkflowValue<string> userInviteInputlocalCurrency = null, WorkflowValue<string> userInviteInputlocalCountry = null, WorkflowValue<string> userInviteInputmanagerId = null, WorkflowValue<string> userInviteInputreviewerId = null, WorkflowValue<string> userInviteInputvendor = null, WorkflowValue<string> userInviteInputdefaultProjectId = null, WorkflowValue<string> userInviteInputiKRatesId = null, WorkflowValue<ValidatorInput[]> userInviteInputadditionalValidators = null, WorkflowValue<string[]> userInviteInputtagsToAssign = null)
        {
            WorkflowValue.Validate(userInviteInputlastName, nameof(userInviteInputlastName), required: true);
            WorkflowValue.Validate(userInviteInputfirstName, nameof(userInviteInputfirstName), required: true);
            WorkflowValue.Validate(userInviteInputmail, nameof(userInviteInputmail), required: true);
            WorkflowValue.Validate(userInviteInputlanguage, nameof(userInviteInputlanguage), required: true);
            WorkflowValue.Validate(userInviteInputuserType, nameof(userInviteInputuserType), required: true);
            WorkflowValue.Validate(userInviteInputuserRole, nameof(userInviteInputuserRole), required: true);
            WorkflowValue.Validate(userInviteInputmailAlias, nameof(userInviteInputmailAlias), required: false);
            WorkflowValue.Validate(userInviteInputpayId, nameof(userInviteInputpayId), required: false);
            WorkflowValue.Validate(userInviteInputpayId2, nameof(userInviteInputpayId2), required: false);
            WorkflowValue.Validate(userInviteInputpayId3, nameof(userInviteInputpayId3), required: false);
            WorkflowValue.Validate(userInviteInputpayId4, nameof(userInviteInputpayId4), required: false);
            WorkflowValue.Validate(userInviteInputpayId5, nameof(userInviteInputpayId5), required: false);
            WorkflowValue.Validate(userInviteInputpayId6, nameof(userInviteInputpayId6), required: false);
            WorkflowValue.Validate(userInviteInputlocalCurrency, nameof(userInviteInputlocalCurrency), required: false);
            WorkflowValue.Validate(userInviteInputlocalCountry, nameof(userInviteInputlocalCountry), required: false);
            WorkflowValue.Validate(userInviteInputmanagerId, nameof(userInviteInputmanagerId), required: false);
            WorkflowValue.Validate(userInviteInputreviewerId, nameof(userInviteInputreviewerId), required: false);
            WorkflowValue.Validate(userInviteInputvendor, nameof(userInviteInputvendor), required: false);
            WorkflowValue.Validate(userInviteInputdefaultProjectId, nameof(userInviteInputdefaultProjectId), required: false);
            WorkflowValue.Validate(userInviteInputiKRatesId, nameof(userInviteInputiKRatesId), required: false);
            WorkflowValue.Validate(userInviteInputadditionalValidators, nameof(userInviteInputadditionalValidators), required: false);
            WorkflowValue.Validate(userInviteInputtagsToAssign, nameof(userInviteInputtagsToAssign), required: false);
            return new DeferredBodyAction<BaseResult>(() =>
            {
                var apiCallPath = "/api/v2/user/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var userInviteInput = new JObject();
                var userInviteInputpropCount = 0;
                userInviteInputpropCount++;
                userInviteInput["LastName"] = ExpressionConverter.ConvertO(userInviteInputlastName);
                userInviteInputpropCount++;
                userInviteInput["FirstName"] = ExpressionConverter.ConvertO(userInviteInputfirstName);
                userInviteInputpropCount++;
                userInviteInput["Mail"] = ExpressionConverter.ConvertO(userInviteInputmail);
                if (userInviteInputmailAlias != null)
                {
                    userInviteInput["MailAlias"] = ExpressionConverter.ConvertO(userInviteInputmailAlias);
                    userInviteInputpropCount++;
                }

                if (userInviteInputpayId != null)
                {
                    userInviteInput["PayId"] = ExpressionConverter.ConvertO(userInviteInputpayId);
                    userInviteInputpropCount++;
                }

                if (userInviteInputpayId2 != null)
                {
                    userInviteInput["PayId2"] = ExpressionConverter.ConvertO(userInviteInputpayId2);
                    userInviteInputpropCount++;
                }

                if (userInviteInputpayId3 != null)
                {
                    userInviteInput["PayId3"] = ExpressionConverter.ConvertO(userInviteInputpayId3);
                    userInviteInputpropCount++;
                }

                if (userInviteInputpayId4 != null)
                {
                    userInviteInput["PayId4"] = ExpressionConverter.ConvertO(userInviteInputpayId4);
                    userInviteInputpropCount++;
                }

                if (userInviteInputpayId5 != null)
                {
                    userInviteInput["PayId5"] = ExpressionConverter.ConvertO(userInviteInputpayId5);
                    userInviteInputpropCount++;
                }

                if (userInviteInputpayId6 != null)
                {
                    userInviteInput["PayId6"] = ExpressionConverter.ConvertO(userInviteInputpayId6);
                    userInviteInputpropCount++;
                }

                userInviteInputpropCount++;
                userInviteInput["Language"] = ExpressionConverter.ConvertO(userInviteInputlanguage);
                if (userInviteInputlocalCurrency != null)
                {
                    userInviteInput["LocalCurrency"] = ExpressionConverter.ConvertO(userInviteInputlocalCurrency);
                    userInviteInputpropCount++;
                }

                if (userInviteInputlocalCountry != null)
                {
                    userInviteInput["LocalCountry"] = ExpressionConverter.ConvertO(userInviteInputlocalCountry);
                    userInviteInputpropCount++;
                }

                if (userInviteInputmanagerId != null)
                {
                    userInviteInput["ManagerId"] = ExpressionConverter.ConvertO(userInviteInputmanagerId);
                    userInviteInputpropCount++;
                }

                if (userInviteInputreviewerId != null)
                {
                    userInviteInput["ReviewerId"] = ExpressionConverter.ConvertO(userInviteInputreviewerId);
                    userInviteInputpropCount++;
                }

                userInviteInputpropCount++;
                userInviteInput["UserType"] = ExpressionConverter.ConvertO(userInviteInputuserType);
                if (userInviteInputvendor != null)
                {
                    userInviteInput["Vendor"] = ExpressionConverter.ConvertO(userInviteInputvendor);
                    userInviteInputpropCount++;
                }

                userInviteInputpropCount++;
                userInviteInput["UserRole"] = ExpressionConverter.ConvertO(userInviteInputuserRole);
                if (userInviteInputdefaultProjectId != null)
                {
                    userInviteInput["DefaultProjectId"] = ExpressionConverter.ConvertO(userInviteInputdefaultProjectId);
                    userInviteInputpropCount++;
                }

                if (userInviteInputiKRatesId != null)
                {
                    userInviteInput["IKRatesId"] = ExpressionConverter.ConvertO(userInviteInputiKRatesId);
                    userInviteInputpropCount++;
                }

                if (userInviteInputadditionalValidators != null)
                {
                    userInviteInput["AdditionalValidators"] = ExpressionConverter.ConvertO(userInviteInputadditionalValidators);
                    userInviteInputpropCount++;
                }

                if (userInviteInputtagsToAssign != null)
                {
                    userInviteInput["TagsToAssign"] = ExpressionConverter.ConvertO(userInviteInputtagsToAssign);
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
        [WorkflowExpressionFactory(nameof(__BuildUpateUser))]
        public IBodyWorkflowAction<BaseResult> UpateUser([WorkflowExpression] Func<string> userId, [WorkflowExpression] Func<bool> shouldUpdateValidators, [WorkflowExpression] Func<string> userUpdateInputlastName = null, [WorkflowExpression] Func<string> userUpdateInputfirstName = null, [WorkflowExpression] Func<string> userUpdateInputmail = null, [WorkflowExpression] Func<string> userUpdateInputmailAlias = null, [WorkflowExpression] Func<string> userUpdateInputpayId = null, [WorkflowExpression] Func<string> userUpdateInputpayId2 = null, [WorkflowExpression] Func<string> userUpdateInputpayId3 = null, [WorkflowExpression] Func<string> userUpdateInputpayId4 = null, [WorkflowExpression] Func<string> userUpdateInputpayId5 = null, [WorkflowExpression] Func<string> userUpdateInputpayId6 = null, [WorkflowExpression] Func<string> userUpdateInputlanguage = null, [WorkflowExpression] Func<string> userUpdateInputlocalCurrency = null, [WorkflowExpression] Func<string> userUpdateInputlocalCountry = null, [WorkflowExpression] Func<string> userUpdateInputmanagerId = null, [WorkflowExpression] Func<string> userUpdateInputreviewerId = null, [WorkflowExpression] Func<userUpdateInputuserTypeInput> userUpdateInputuserType = null, [WorkflowExpression] Func<string> userUpdateInputvendor = null, [WorkflowExpression] Func<userUpdateInputuserRoleInput> userUpdateInputuserRole = null, [WorkflowExpression] Func<string> userUpdateInputjobTitle = null, [WorkflowExpression] Func<bool> userUpdateInputcanAddPurchase = null, [WorkflowExpression] Func<string> userUpdateInputdefaultProjectId = null, [WorkflowExpression] Func<string> userUpdateInputiKRatesId = null, [WorkflowExpression] Func<ValidatorInput[]> userUpdateInputadditionalValidators = null, [WorkflowExpression] Func<string[]> userUpdateInputtagsToAssign = null, [WorkflowExpression] Func<string[]> userUpdateInputtagsToUnassign = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BaseResult> __BuildUpateUser(WorkflowValue<string> userId, WorkflowValue<bool> shouldUpdateValidators, WorkflowValue<string> userUpdateInputlastName = null, WorkflowValue<string> userUpdateInputfirstName = null, WorkflowValue<string> userUpdateInputmail = null, WorkflowValue<string> userUpdateInputmailAlias = null, WorkflowValue<string> userUpdateInputpayId = null, WorkflowValue<string> userUpdateInputpayId2 = null, WorkflowValue<string> userUpdateInputpayId3 = null, WorkflowValue<string> userUpdateInputpayId4 = null, WorkflowValue<string> userUpdateInputpayId5 = null, WorkflowValue<string> userUpdateInputpayId6 = null, WorkflowValue<string> userUpdateInputlanguage = null, WorkflowValue<string> userUpdateInputlocalCurrency = null, WorkflowValue<string> userUpdateInputlocalCountry = null, WorkflowValue<string> userUpdateInputmanagerId = null, WorkflowValue<string> userUpdateInputreviewerId = null, WorkflowValue<userUpdateInputuserTypeInput> userUpdateInputuserType = null, WorkflowValue<string> userUpdateInputvendor = null, WorkflowValue<userUpdateInputuserRoleInput> userUpdateInputuserRole = null, WorkflowValue<string> userUpdateInputjobTitle = null, WorkflowValue<bool> userUpdateInputcanAddPurchase = null, WorkflowValue<string> userUpdateInputdefaultProjectId = null, WorkflowValue<string> userUpdateInputiKRatesId = null, WorkflowValue<ValidatorInput[]> userUpdateInputadditionalValidators = null, WorkflowValue<string[]> userUpdateInputtagsToAssign = null, WorkflowValue<string[]> userUpdateInputtagsToUnassign = null)
        {
            WorkflowValue.Validate(userId, nameof(userId), required: true);
            WorkflowValue.Validate(shouldUpdateValidators, nameof(shouldUpdateValidators), required: true);
            WorkflowValue.Validate(userUpdateInputlastName, nameof(userUpdateInputlastName), required: false);
            WorkflowValue.Validate(userUpdateInputfirstName, nameof(userUpdateInputfirstName), required: false);
            WorkflowValue.Validate(userUpdateInputmail, nameof(userUpdateInputmail), required: false);
            WorkflowValue.Validate(userUpdateInputmailAlias, nameof(userUpdateInputmailAlias), required: false);
            WorkflowValue.Validate(userUpdateInputpayId, nameof(userUpdateInputpayId), required: false);
            WorkflowValue.Validate(userUpdateInputpayId2, nameof(userUpdateInputpayId2), required: false);
            WorkflowValue.Validate(userUpdateInputpayId3, nameof(userUpdateInputpayId3), required: false);
            WorkflowValue.Validate(userUpdateInputpayId4, nameof(userUpdateInputpayId4), required: false);
            WorkflowValue.Validate(userUpdateInputpayId5, nameof(userUpdateInputpayId5), required: false);
            WorkflowValue.Validate(userUpdateInputpayId6, nameof(userUpdateInputpayId6), required: false);
            WorkflowValue.Validate(userUpdateInputlanguage, nameof(userUpdateInputlanguage), required: false);
            WorkflowValue.Validate(userUpdateInputlocalCurrency, nameof(userUpdateInputlocalCurrency), required: false);
            WorkflowValue.Validate(userUpdateInputlocalCountry, nameof(userUpdateInputlocalCountry), required: false);
            WorkflowValue.Validate(userUpdateInputmanagerId, nameof(userUpdateInputmanagerId), required: false);
            WorkflowValue.Validate(userUpdateInputreviewerId, nameof(userUpdateInputreviewerId), required: false);
            WorkflowValue.Validate(userUpdateInputuserType, nameof(userUpdateInputuserType), required: false);
            WorkflowValue.Validate(userUpdateInputvendor, nameof(userUpdateInputvendor), required: false);
            WorkflowValue.Validate(userUpdateInputuserRole, nameof(userUpdateInputuserRole), required: false);
            WorkflowValue.Validate(userUpdateInputjobTitle, nameof(userUpdateInputjobTitle), required: false);
            WorkflowValue.Validate(userUpdateInputcanAddPurchase, nameof(userUpdateInputcanAddPurchase), required: false);
            WorkflowValue.Validate(userUpdateInputdefaultProjectId, nameof(userUpdateInputdefaultProjectId), required: false);
            WorkflowValue.Validate(userUpdateInputiKRatesId, nameof(userUpdateInputiKRatesId), required: false);
            WorkflowValue.Validate(userUpdateInputadditionalValidators, nameof(userUpdateInputadditionalValidators), required: false);
            WorkflowValue.Validate(userUpdateInputtagsToAssign, nameof(userUpdateInputtagsToAssign), required: false);
            WorkflowValue.Validate(userUpdateInputtagsToUnassign, nameof(userUpdateInputtagsToUnassign), required: false);
            return new DeferredBodyAction<BaseResult>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v2/user/{0}/", ExpressionConverter.ConvertWithUrlEncoding(userId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["shouldUpdateValidators"] = ExpressionConverter.Convert(shouldUpdateValidators);
                var userUpdateInput = new JObject();
                var userUpdateInputpropCount = 0;
                if (userUpdateInputlastName != null)
                {
                    userUpdateInput["LastName"] = ExpressionConverter.ConvertO(userUpdateInputlastName);
                    userUpdateInputpropCount++;
                }

                if (userUpdateInputfirstName != null)
                {
                    userUpdateInput["FirstName"] = ExpressionConverter.ConvertO(userUpdateInputfirstName);
                    userUpdateInputpropCount++;
                }

                if (userUpdateInputmail != null)
                {
                    userUpdateInput["Mail"] = ExpressionConverter.ConvertO(userUpdateInputmail);
                    userUpdateInputpropCount++;
                }

                if (userUpdateInputmailAlias != null)
                {
                    userUpdateInput["MailAlias"] = ExpressionConverter.ConvertO(userUpdateInputmailAlias);
                    userUpdateInputpropCount++;
                }

                if (userUpdateInputpayId != null)
                {
                    userUpdateInput["PayId"] = ExpressionConverter.ConvertO(userUpdateInputpayId);
                    userUpdateInputpropCount++;
                }

                if (userUpdateInputpayId2 != null)
                {
                    userUpdateInput["PayId2"] = ExpressionConverter.ConvertO(userUpdateInputpayId2);
                    userUpdateInputpropCount++;
                }

                if (userUpdateInputpayId3 != null)
                {
                    userUpdateInput["PayId3"] = ExpressionConverter.ConvertO(userUpdateInputpayId3);
                    userUpdateInputpropCount++;
                }

                if (userUpdateInputpayId4 != null)
                {
                    userUpdateInput["PayId4"] = ExpressionConverter.ConvertO(userUpdateInputpayId4);
                    userUpdateInputpropCount++;
                }

                if (userUpdateInputpayId5 != null)
                {
                    userUpdateInput["PayId5"] = ExpressionConverter.ConvertO(userUpdateInputpayId5);
                    userUpdateInputpropCount++;
                }

                if (userUpdateInputpayId6 != null)
                {
                    userUpdateInput["PayId6"] = ExpressionConverter.ConvertO(userUpdateInputpayId6);
                    userUpdateInputpropCount++;
                }

                if (userUpdateInputlanguage != null)
                {
                    userUpdateInput["Language"] = ExpressionConverter.ConvertO(userUpdateInputlanguage);
                    userUpdateInputpropCount++;
                }

                if (userUpdateInputlocalCurrency != null)
                {
                    userUpdateInput["LocalCurrency"] = ExpressionConverter.ConvertO(userUpdateInputlocalCurrency);
                    userUpdateInputpropCount++;
                }

                if (userUpdateInputlocalCountry != null)
                {
                    userUpdateInput["LocalCountry"] = ExpressionConverter.ConvertO(userUpdateInputlocalCountry);
                    userUpdateInputpropCount++;
                }

                if (userUpdateInputmanagerId != null)
                {
                    userUpdateInput["Manager_Id"] = ExpressionConverter.ConvertO(userUpdateInputmanagerId);
                    userUpdateInputpropCount++;
                }

                if (userUpdateInputreviewerId != null)
                {
                    userUpdateInput["Reviewer_Id"] = ExpressionConverter.ConvertO(userUpdateInputreviewerId);
                    userUpdateInputpropCount++;
                }

                if (userUpdateInputuserType != null)
                {
                    userUpdateInput["UserType"] = ExpressionConverter.ConvertO(userUpdateInputuserType);
                    userUpdateInputpropCount++;
                }

                if (userUpdateInputvendor != null)
                {
                    userUpdateInput["Vendor"] = ExpressionConverter.ConvertO(userUpdateInputvendor);
                    userUpdateInputpropCount++;
                }

                if (userUpdateInputuserRole != null)
                {
                    userUpdateInput["UserRole"] = ExpressionConverter.ConvertO(userUpdateInputuserRole);
                    userUpdateInputpropCount++;
                }

                if (userUpdateInputjobTitle != null)
                {
                    userUpdateInput["JobTitle"] = ExpressionConverter.ConvertO(userUpdateInputjobTitle);
                    userUpdateInputpropCount++;
                }

                if (userUpdateInputcanAddPurchase != null)
                {
                    userUpdateInput["CanAddPurchase"] = ExpressionConverter.ConvertO(userUpdateInputcanAddPurchase);
                    userUpdateInputpropCount++;
                }

                if (userUpdateInputdefaultProjectId != null)
                {
                    userUpdateInput["DefaultProjectId"] = ExpressionConverter.ConvertO(userUpdateInputdefaultProjectId);
                    userUpdateInputpropCount++;
                }

                if (userUpdateInputiKRatesId != null)
                {
                    userUpdateInput["IKRates_Id"] = ExpressionConverter.ConvertO(userUpdateInputiKRatesId);
                    userUpdateInputpropCount++;
                }

                if (userUpdateInputadditionalValidators != null)
                {
                    userUpdateInput["AdditionalValidators"] = ExpressionConverter.ConvertO(userUpdateInputadditionalValidators);
                    userUpdateInputpropCount++;
                }

                if (userUpdateInputtagsToAssign != null)
                {
                    userUpdateInput["TagsToAssign"] = ExpressionConverter.ConvertO(userUpdateInputtagsToAssign);
                    userUpdateInputpropCount++;
                }

                if (userUpdateInputtagsToUnassign != null)
                {
                    userUpdateInput["TagsToUnassign"] = ExpressionConverter.ConvertO(userUpdateInputtagsToUnassign);
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
        [WorkflowExpressionFactory(nameof(__BuildUpdateProjectState))]
        public IBodyWorkflowAction<BaseResultListAddOrUpdateEntityResult> UpdateProjectState([WorkflowExpression] Func<string[]> updateProjectStateInputitemIds, [WorkflowExpression] Func<bool> updateProjectStateInputprojectState)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BaseResultListAddOrUpdateEntityResult> __BuildUpdateProjectState(WorkflowValue<string[]> updateProjectStateInputitemIds, WorkflowValue<bool> updateProjectStateInputprojectState)
        {
            WorkflowValue.Validate(updateProjectStateInputitemIds, nameof(updateProjectStateInputitemIds), required: true);
            WorkflowValue.Validate(updateProjectStateInputprojectState, nameof(updateProjectStateInputprojectState), required: true);
            return new DeferredBodyAction<BaseResultListAddOrUpdateEntityResult>(() =>
            {
                var apiCallPath = "/api/v2/projects/states/";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var updateProjectStateInput = new JObject();
                var updateProjectStateInputpropCount = 0;
                updateProjectStateInputpropCount++;
                updateProjectStateInput["ItemIds"] = ExpressionConverter.ConvertO(updateProjectStateInputitemIds);
                updateProjectStateInputpropCount++;
                updateProjectStateInput["ProjectState"] = ExpressionConverter.ConvertO(updateProjectStateInputprojectState);
                if (updateProjectStateInputpropCount > 0)
                {
                    callPayload.Body = updateProjectStateInput;
                }

                return new ApiConnectionAction<BaseResultListAddOrUpdateEntityResult>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expensya")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateUsersState))]
        public IBodyWorkflowAction<BaseResultListUpdateUserResult> UpdateUsersState([WorkflowExpression] Func<UpdateUserStateInput[]> updateUserStateInputArray = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BaseResultListUpdateUserResult> __BuildUpdateUsersState(WorkflowValue<UpdateUserStateInput[]> updateUserStateInputArray = null)
        {
            WorkflowValue.Validate(updateUserStateInputArray, nameof(updateUserStateInputArray), required: false);
            return new DeferredBodyAction<BaseResultListUpdateUserResult>(() =>
            {
                var apiCallPath = "/api/v2/users/state/";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(updateUserStateInputArray);
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

    public enum TagResponseTagTypeType
    {
        [EnumMember(Value = "1")]
        _1,
        [EnumMember(Value = "2")]
        _2
    }

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

    public enum UserResponseUserStateType
    {
        [EnumMember(Value = "0")]
        _0,
        [EnumMember(Value = "1")]
        _1,
        [EnumMember(Value = "2")]
        _2
    }

    public enum UserResponseManagerUserStateType
    {
        [EnumMember(Value = "0")]
        _0,
        [EnumMember(Value = "1")]
        _1,
        [EnumMember(Value = "2")]
        _2
    }

    public enum UserResponseReviewerUserStateType
    {
        [EnumMember(Value = "0")]
        _0,
        [EnumMember(Value = "1")]
        _1,
        [EnumMember(Value = "2")]
        _2
    }

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

    public enum CategoryResponseCategoryUseTypeType
    {
        [EnumMember(Value = "1")]
        _1,
        [EnumMember(Value = "2")]
        _2,
        [EnumMember(Value = "4")]
        _4
    }

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

    public enum VehicleResponseInternalVehicleTypeType
    {
        [EnumMember(Value = "0")]
        _0,
        [EnumMember(Value = "1")]
        _1,
        [EnumMember(Value = "2")]
        _2
    }

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

    public enum VehicleResponseCreationTypeType
    {
        [EnumMember(Value = "0")]
        _0,
        [EnumMember(Value = "1")]
        _1
    }

    public enum ExpenseResponsePerdiemCalculationPeriodTypeType
    {
        [EnumMember(Value = "0")]
        _0,
        [EnumMember(Value = "1")]
        _1
    }

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

    public enum BrokenRuleResponseRuleElementTypeType
    {
        [EnumMember(Value = "0")]
        _0,
        [EnumMember(Value = "1")]
        _1
    }

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
