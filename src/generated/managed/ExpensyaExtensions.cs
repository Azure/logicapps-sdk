//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Expensya
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ExpensyaActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expensya")]
        public IBodyWorkflowAction<string> GetExpenseImage([WorkflowExpression] Func<string> expenseId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/expense/{0}/image", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(expenseId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expensya")]
        public IBodyWorkflowAction<BaseResultExportResponse> ExportExpenses([WorkflowExpression] Func<string> exportId, [WorkflowExpression] Func<string> reportId = null, [WorkflowExpression] Func<string> categoryId = null, [WorkflowExpression] Func<string> expenseName = null, [WorkflowExpression] Func<string> startDate = null, [WorkflowExpression] Func<string> endDate = null, [WorkflowExpression] Func<string> expenseStates = null, [WorkflowExpression] Func<string> reportStates = null, [WorkflowExpression] Func<string> userIds = null, [WorkflowExpression] Func<string> userMail = null, [WorkflowExpression] Func<string> reportIds = null, [WorkflowExpression] Func<string> expenseIds = null, [WorkflowExpression] Func<string> reportName = null, [WorkflowExpression] Func<string> reportIdShort = null, [WorkflowExpression] Func<int> dateFilterType = null, [WorkflowExpression] Func<string> payId = null, [WorkflowExpression] Func<string> payId2 = null, [WorkflowExpression] Func<string> payId3 = null, [WorkflowExpression] Func<string> accountingPeriod = null, [WorkflowExpression] Func<bool> includeReceipts = null, [WorkflowExpression] Func<int> expenseUseTypes = null, [WorkflowExpression] Func<string> archiveExpenses = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/export/expenses/{0}/", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(exportId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (reportId != null)
                    callPayload.Queries["reportId"] = SourceExpressionConverter.ConvertO(reportId);
                if (categoryId != null)
                    callPayload.Queries["categoryId"] = SourceExpressionConverter.ConvertO(categoryId);
                if (expenseName != null)
                    callPayload.Queries["expenseName"] = SourceExpressionConverter.ConvertO(expenseName);
                if (startDate != null)
                    callPayload.Queries["startDate"] = SourceExpressionConverter.ConvertO(startDate);
                if (endDate != null)
                    callPayload.Queries["endDate"] = SourceExpressionConverter.ConvertO(endDate);
                if (expenseStates != null)
                    callPayload.Queries["expenseStates"] = SourceExpressionConverter.ConvertO(expenseStates);
                if (reportStates != null)
                    callPayload.Queries["reportStates"] = SourceExpressionConverter.ConvertO(reportStates);
                if (userIds != null)
                    callPayload.Queries["userIds"] = SourceExpressionConverter.ConvertO(userIds);
                if (userMail != null)
                    callPayload.Queries["userMail"] = SourceExpressionConverter.ConvertO(userMail);
                if (reportIds != null)
                    callPayload.Queries["reportIds"] = SourceExpressionConverter.ConvertO(reportIds);
                if (expenseIds != null)
                    callPayload.Queries["expenseIds"] = SourceExpressionConverter.ConvertO(expenseIds);
                if (reportName != null)
                    callPayload.Queries["reportName"] = SourceExpressionConverter.ConvertO(reportName);
                if (reportIdShort != null)
                    callPayload.Queries["reportIdShort"] = SourceExpressionConverter.ConvertO(reportIdShort);
                if (dateFilterType != null)
                    callPayload.Queries["dateFilterType"] = SourceExpressionConverter.ConvertO(dateFilterType);
                if (payId != null)
                    callPayload.Queries["payId"] = SourceExpressionConverter.ConvertO(payId);
                if (payId2 != null)
                    callPayload.Queries["payId2"] = SourceExpressionConverter.ConvertO(payId2);
                if (payId3 != null)
                    callPayload.Queries["payId3"] = SourceExpressionConverter.ConvertO(payId3);
                if (accountingPeriod != null)
                    callPayload.Queries["accountingPeriod"] = SourceExpressionConverter.ConvertO(accountingPeriod);
                if (includeReceipts != null)
                    callPayload.Queries["includeReceipts"] = SourceExpressionConverter.ConvertO(includeReceipts);
                if (expenseUseTypes != null)
                    callPayload.Queries["expenseUseTypes"] = SourceExpressionConverter.ConvertO(expenseUseTypes);
                if (archiveExpenses != null)
                    callPayload.Queries["archiveExpenses"] = SourceExpressionConverter.ConvertO(archiveExpenses);
                return callPayload;
            }

            return new ApiConnectionAction<BaseResultExportResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expensya")]
        public IBodyWorkflowAction<BaseResultExportResponse> PrintMission([WorkflowExpression] Func<string> reportId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/export/report/{0}/pdf/", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(reportId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<BaseResultExportResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expensya")]
        public IBodyWorkflowAction<BaseResultListExportFormatResponse> ExportFormats([WorkflowExpression] Func<bool> isForExpenses = null, [WorkflowExpression] Func<int> exportType = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/exports/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (isForExpenses != null)
                    callPayload.Queries["isForExpenses"] = SourceExpressionConverter.ConvertO(isForExpenses);
                if (exportType != null)
                    callPayload.Queries["exportType"] = SourceExpressionConverter.ConvertO(exportType);
                return callPayload;
            }

            return new ApiConnectionAction<BaseResultListExportFormatResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expensya")]
        public IBodyWorkflowAction<BaseResultListAddOrUpdateEntityResult> AddProjects([WorkflowExpression] Func<AddOrUpdateProjectInput[]> addOrUpdateProjectInputArray = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/projects/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = SourceExpressionConverter.ConvertToken(addOrUpdateProjectInputArray);
                return callPayload;
            }

            return new ApiConnectionAction<BaseResultListAddOrUpdateEntityResult>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expensya")]
        public IBodyWorkflowAction<BaseResultListAddOrUpdateEntityResult> UpdateProjects([WorkflowExpression] Func<AddOrUpdateProjectInput[]> addOrUpdateProjectInputArray = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/projects/";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = SourceExpressionConverter.ConvertToken(addOrUpdateProjectInputArray);
                return callPayload;
            }

            return new ApiConnectionAction<BaseResultListAddOrUpdateEntityResult>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expensya")]
        public IBodyWorkflowAction<BaseResult> AddReciept([WorkflowExpression] Func<string> addReceiptInputuserId, [WorkflowExpression] Func<string> addReceiptInputreceiptContent, [WorkflowExpression] Func<string> addReceiptInputreceiptName)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/receipt/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var addReceiptInput = new JObject();
                var addReceiptInputpropCount = 0;
                addReceiptInputpropCount++;
                addReceiptInput["UserId"] = SourceExpressionConverter.ConvertToken(addReceiptInputuserId);
                addReceiptInputpropCount++;
                addReceiptInput["ReceiptContent"] = SourceExpressionConverter.ConvertToken(addReceiptInputreceiptContent);
                addReceiptInputpropCount++;
                addReceiptInput["ReceiptName"] = SourceExpressionConverter.ConvertToken(addReceiptInputreceiptName);
                if (addReceiptInputpropCount > 0)
                {
                    callPayload.Body = addReceiptInput;
                }
                return callPayload;
            }

            return new ApiConnectionAction<BaseResult>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expensya")]
        public IBodyWorkflowAction<BaseResult> RevokeUserToken()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/revokeUserToken/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<BaseResult>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expensya")]
        public IBodyWorkflowAction<ListAndPagesCountResultReportResponse> ValidatorReports([WorkflowExpression] Func<string> validatorMail, [WorkflowExpression] Func<string> reportName = null, [WorkflowExpression] Func<string> reportStartDate = null, [WorkflowExpression] Func<string> reportEndDate = null, [WorkflowExpression] Func<string> reportStates = null, [WorkflowExpression] Func<string> reportIdShort = null, [WorkflowExpression] Func<string> ownerId = null, [WorkflowExpression] Func<string> ownerPayId2 = null, [WorkflowExpression] Func<string> projectId = null, [WorkflowExpression] Func<int> dateFilterType = null, [WorkflowExpression] Func<int> sortBy = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null, [WorkflowExpression] Func<bool> isDesc = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v2/{0}/reports/", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(validatorMail, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (reportName != null)
                    callPayload.Queries["reportName"] = SourceExpressionConverter.ConvertO(reportName);
                if (reportStartDate != null)
                    callPayload.Queries["reportStartDate"] = SourceExpressionConverter.ConvertO(reportStartDate);
                if (reportEndDate != null)
                    callPayload.Queries["reportEndDate"] = SourceExpressionConverter.ConvertO(reportEndDate);
                if (reportStates != null)
                    callPayload.Queries["reportStates"] = SourceExpressionConverter.ConvertO(reportStates);
                if (reportIdShort != null)
                    callPayload.Queries["reportIdShort"] = SourceExpressionConverter.ConvertO(reportIdShort);
                if (ownerId != null)
                    callPayload.Queries["ownerId"] = SourceExpressionConverter.ConvertO(ownerId);
                if (ownerPayId2 != null)
                    callPayload.Queries["ownerPayId2"] = SourceExpressionConverter.ConvertO(ownerPayId2);
                if (projectId != null)
                    callPayload.Queries["projectId"] = SourceExpressionConverter.ConvertO(projectId);
                if (dateFilterType != null)
                    callPayload.Queries["dateFilterType"] = SourceExpressionConverter.ConvertO(dateFilterType);
                if (sortBy != null)
                    callPayload.Queries["sortBy"] = SourceExpressionConverter.ConvertO(sortBy);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (pageSize != null)
                    callPayload.Queries["pageSize"] = SourceExpressionConverter.ConvertO(pageSize);
                if (isDesc != null)
                    callPayload.Queries["isDesc"] = SourceExpressionConverter.ConvertO(isDesc);
                return callPayload;
            }

            return new ApiConnectionAction<ListAndPagesCountResultReportResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expensya")]
        public IBodyWorkflowAction<BaseResult> UpdateReportStatus([WorkflowExpression] Func<string> reportId, [WorkflowExpression] Func<reportUpdateStatusInputoperationInput> reportUpdateStatusInputoperation, [WorkflowExpression] Func<string> reportUpdateStatusInputmessage, [WorkflowExpression] Func<string[]> reportUpdateStatusInputinvoiceIdsToReject = null, [WorkflowExpression] Func<string> reportUpdateStatusInputaccountingPeriod = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v2/report/{0}/updateStatus/", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(reportId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var reportUpdateStatusInput = new JObject();
                var reportUpdateStatusInputpropCount = 0;
                reportUpdateStatusInputpropCount++;
                reportUpdateStatusInput["Operation"] = SourceExpressionConverter.Convert(reportUpdateStatusInputoperation);
                reportUpdateStatusInputpropCount++;
                reportUpdateStatusInput["Message"] = SourceExpressionConverter.ConvertToken(reportUpdateStatusInputmessage);
                if (reportUpdateStatusInputinvoiceIdsToReject != null)
                {
                    reportUpdateStatusInput["InvoiceIdsToReject"] = SourceExpressionConverter.ConvertToken(reportUpdateStatusInputinvoiceIdsToReject);
                    reportUpdateStatusInputpropCount++;
                }

                if (reportUpdateStatusInputaccountingPeriod != null)
                {
                    reportUpdateStatusInput["AccountingPeriod"] = SourceExpressionConverter.ConvertToken(reportUpdateStatusInputaccountingPeriod);
                    reportUpdateStatusInputpropCount++;
                }

                if (reportUpdateStatusInputpropCount > 0)
                {
                    callPayload.Body = reportUpdateStatusInput;
                }
                return callPayload;
            }

            return new ApiConnectionAction<BaseResult>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expensya")]
        public IBodyWorkflowAction<ListAndPagesCountResultReportResponse> CompanyReports([WorkflowExpression] Func<string> reportName = null, [WorkflowExpression] Func<string> reportStartDate = null, [WorkflowExpression] Func<string> reportEndDate = null, [WorkflowExpression] Func<string> reportStates = null, [WorkflowExpression] Func<string> reportIdShort = null, [WorkflowExpression] Func<string> ownerId = null, [WorkflowExpression] Func<string> ownerPayId2 = null, [WorkflowExpression] Func<string> projectId = null, [WorkflowExpression] Func<string> tagsNames = null, [WorkflowExpression] Func<int> dateFilterType = null, [WorkflowExpression] Func<int> sortBy = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null, [WorkflowExpression] Func<bool> isDesc = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/v2/reports/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (reportName != null)
                    callPayload.Queries["reportName"] = SourceExpressionConverter.ConvertO(reportName);
                if (reportStartDate != null)
                    callPayload.Queries["reportStartDate"] = SourceExpressionConverter.ConvertO(reportStartDate);
                if (reportEndDate != null)
                    callPayload.Queries["reportEndDate"] = SourceExpressionConverter.ConvertO(reportEndDate);
                if (reportStates != null)
                    callPayload.Queries["reportStates"] = SourceExpressionConverter.ConvertO(reportStates);
                if (reportIdShort != null)
                    callPayload.Queries["reportIdShort"] = SourceExpressionConverter.ConvertO(reportIdShort);
                if (ownerId != null)
                    callPayload.Queries["ownerId"] = SourceExpressionConverter.ConvertO(ownerId);
                if (ownerPayId2 != null)
                    callPayload.Queries["ownerPayId2"] = SourceExpressionConverter.ConvertO(ownerPayId2);
                if (projectId != null)
                    callPayload.Queries["projectId"] = SourceExpressionConverter.ConvertO(projectId);
                if (tagsNames != null)
                    callPayload.Queries["tagsNames"] = SourceExpressionConverter.ConvertO(tagsNames);
                if (dateFilterType != null)
                    callPayload.Queries["dateFilterType"] = SourceExpressionConverter.ConvertO(dateFilterType);
                if (sortBy != null)
                    callPayload.Queries["sortBy"] = SourceExpressionConverter.ConvertO(sortBy);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (pageSize != null)
                    callPayload.Queries["pageSize"] = SourceExpressionConverter.ConvertO(pageSize);
                if (isDesc != null)
                    callPayload.Queries["isDesc"] = SourceExpressionConverter.ConvertO(isDesc);
                return callPayload;
            }

            return new ApiConnectionAction<ListAndPagesCountResultReportResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expensya")]
        public IBodyWorkflowAction<ListAndPagesCountResultUserResponse> CompanyUsers([WorkflowExpression] Func<string> id = null, [WorkflowExpression] Func<string> firstName = null, [WorkflowExpression] Func<string> lastName = null, [WorkflowExpression] Func<string> mail = null, [WorkflowExpression] Func<string> payId = null, [WorkflowExpression] Func<string> mailOrNameOrPayId = null, [WorkflowExpression] Func<int> type = null, [WorkflowExpression] Func<int> state = null, [WorkflowExpression] Func<string> reviewerId = null, [WorkflowExpression] Func<string> reviewerName = null, [WorkflowExpression] Func<string> managerId = null, [WorkflowExpression] Func<string> managerName = null, [WorkflowExpression] Func<string> userIds = null, [WorkflowExpression] Func<string> userMails = null, [WorkflowExpression] Func<string> tagsNames = null, [WorkflowExpression] Func<string> simpleTagsNames = null, [WorkflowExpression] Func<int> sortBy = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null, [WorkflowExpression] Func<bool> isDesc = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/v2/users/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (id != null)
                    callPayload.Queries["id"] = SourceExpressionConverter.ConvertO(id);
                if (firstName != null)
                    callPayload.Queries["firstName"] = SourceExpressionConverter.ConvertO(firstName);
                if (lastName != null)
                    callPayload.Queries["lastName"] = SourceExpressionConverter.ConvertO(lastName);
                if (mail != null)
                    callPayload.Queries["mail"] = SourceExpressionConverter.ConvertO(mail);
                if (payId != null)
                    callPayload.Queries["payId"] = SourceExpressionConverter.ConvertO(payId);
                if (mailOrNameOrPayId != null)
                    callPayload.Queries["mailOrNameOrPayId"] = SourceExpressionConverter.ConvertO(mailOrNameOrPayId);
                if (type != null)
                    callPayload.Queries["type"] = SourceExpressionConverter.ConvertO(type);
                if (state != null)
                    callPayload.Queries["state"] = SourceExpressionConverter.ConvertO(state);
                if (reviewerId != null)
                    callPayload.Queries["reviewerId"] = SourceExpressionConverter.ConvertO(reviewerId);
                if (reviewerName != null)
                    callPayload.Queries["reviewerName"] = SourceExpressionConverter.ConvertO(reviewerName);
                if (managerId != null)
                    callPayload.Queries["managerId"] = SourceExpressionConverter.ConvertO(managerId);
                if (managerName != null)
                    callPayload.Queries["managerName"] = SourceExpressionConverter.ConvertO(managerName);
                if (userIds != null)
                    callPayload.Queries["userIds"] = SourceExpressionConverter.ConvertO(userIds);
                if (userMails != null)
                    callPayload.Queries["userMails"] = SourceExpressionConverter.ConvertO(userMails);
                if (tagsNames != null)
                    callPayload.Queries["tagsNames"] = SourceExpressionConverter.ConvertO(tagsNames);
                if (simpleTagsNames != null)
                    callPayload.Queries["simpleTagsNames"] = SourceExpressionConverter.ConvertO(simpleTagsNames);
                if (sortBy != null)
                    callPayload.Queries["sortBy"] = SourceExpressionConverter.ConvertO(sortBy);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (pageSize != null)
                    callPayload.Queries["pageSize"] = SourceExpressionConverter.ConvertO(pageSize);
                if (isDesc != null)
                    callPayload.Queries["isDesc"] = SourceExpressionConverter.ConvertO(isDesc);
                return callPayload;
            }

            return new ApiConnectionAction<ListAndPagesCountResultUserResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expensya")]
        public IBodyWorkflowAction<BaseResult> AddQuickExpense([WorkflowExpression] Func<string> userId, [WorkflowExpression] Func<string> quickExpenseInputfileToSend, [WorkflowExpression] Func<string> quickExpenseInputtitle = null, [WorkflowExpression] Func<double> quickExpenseInputtransactionAmount = null, [WorkflowExpression] Func<string> quickExpenseInputvatRates = null, [WorkflowExpression] Func<string> quickExpenseInputvatAmounts = null, [WorkflowExpression] Func<string> quickExpenseInputcurrencyCode = null, [WorkflowExpression] Func<string> quickExpenseInputtransactionDate = null, [WorkflowExpression] Func<string> quickExpenseInputmerchantName = null, [WorkflowExpression] Func<string> quickExpenseInputlocationCountry = null, [WorkflowExpression] Func<string> quickExpenseInputlocationCity = null, [WorkflowExpression] Func<string> quickExpenseInputcomment = null, [WorkflowExpression] Func<string> quickExpenseInputmerchantExpenseId = null, [WorkflowExpression] Func<bool> quickExpenseInputisEncrypted = null, [WorkflowExpression] Func<quickExpenseInputexpenseUseTypeInput> quickExpenseInputexpenseUseType = null, [WorkflowExpression] Func<string> quickExpenseInputpaymentTypeCode = null, [WorkflowExpression] Func<string> quickExpenseInputexpenseTypeCode = null, [WorkflowExpression] Func<string> quickExpenseInputfileType = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v2/quickexpense/{0}/", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(userId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var quickExpenseInput = new JObject();
                var quickExpenseInputpropCount = 0;
                quickExpenseInputpropCount++;
                quickExpenseInput["FileToSend"] = SourceExpressionConverter.ConvertToken(quickExpenseInputfileToSend);
                if (quickExpenseInputtitle != null)
                {
                    quickExpenseInput["Title"] = SourceExpressionConverter.ConvertToken(quickExpenseInputtitle);
                    quickExpenseInputpropCount++;
                }

                if (quickExpenseInputtransactionAmount != null)
                {
                    quickExpenseInput["TransactionAmount"] = SourceExpressionConverter.ConvertToken(quickExpenseInputtransactionAmount);
                    quickExpenseInputpropCount++;
                }

                if (quickExpenseInputvatRates != null)
                {
                    quickExpenseInput["VatRates"] = SourceExpressionConverter.ConvertToken(quickExpenseInputvatRates);
                    quickExpenseInputpropCount++;
                }

                if (quickExpenseInputvatAmounts != null)
                {
                    quickExpenseInput["VatAmounts"] = SourceExpressionConverter.ConvertToken(quickExpenseInputvatAmounts);
                    quickExpenseInputpropCount++;
                }

                if (quickExpenseInputcurrencyCode != null)
                {
                    quickExpenseInput["CurrencyCode"] = SourceExpressionConverter.ConvertToken(quickExpenseInputcurrencyCode);
                    quickExpenseInputpropCount++;
                }

                if (quickExpenseInputtransactionDate != null)
                {
                    quickExpenseInput["TransactionDate"] = SourceExpressionConverter.ConvertToken(quickExpenseInputtransactionDate);
                    quickExpenseInputpropCount++;
                }

                if (quickExpenseInputmerchantName != null)
                {
                    quickExpenseInput["MerchantName"] = SourceExpressionConverter.ConvertToken(quickExpenseInputmerchantName);
                    quickExpenseInputpropCount++;
                }

                if (quickExpenseInputlocationCountry != null)
                {
                    quickExpenseInput["LocationCountry"] = SourceExpressionConverter.ConvertToken(quickExpenseInputlocationCountry);
                    quickExpenseInputpropCount++;
                }

                if (quickExpenseInputlocationCity != null)
                {
                    quickExpenseInput["LocationCity"] = SourceExpressionConverter.ConvertToken(quickExpenseInputlocationCity);
                    quickExpenseInputpropCount++;
                }

                if (quickExpenseInputcomment != null)
                {
                    quickExpenseInput["Comment"] = SourceExpressionConverter.ConvertToken(quickExpenseInputcomment);
                    quickExpenseInputpropCount++;
                }

                if (quickExpenseInputmerchantExpenseId != null)
                {
                    quickExpenseInput["MerchantExpenseId"] = SourceExpressionConverter.ConvertToken(quickExpenseInputmerchantExpenseId);
                    quickExpenseInputpropCount++;
                }

                if (quickExpenseInputisEncrypted != null)
                {
                    quickExpenseInput["IsEncrypted"] = SourceExpressionConverter.ConvertToken(quickExpenseInputisEncrypted);
                    quickExpenseInputpropCount++;
                }

                if (quickExpenseInputexpenseUseType != null)
                {
                    quickExpenseInput["ExpenseUseType"] = SourceExpressionConverter.Convert(quickExpenseInputexpenseUseType);
                    quickExpenseInputpropCount++;
                }

                if (quickExpenseInputpaymentTypeCode != null)
                {
                    quickExpenseInput["PaymentTypeCode"] = SourceExpressionConverter.ConvertToken(quickExpenseInputpaymentTypeCode);
                    quickExpenseInputpropCount++;
                }

                if (quickExpenseInputexpenseTypeCode != null)
                {
                    quickExpenseInput["ExpenseTypeCode"] = SourceExpressionConverter.ConvertToken(quickExpenseInputexpenseTypeCode);
                    quickExpenseInputpropCount++;
                }

                if (quickExpenseInputfileType != null)
                {
                    quickExpenseInput["FileType"] = SourceExpressionConverter.ConvertToken(quickExpenseInputfileType);
                    quickExpenseInputpropCount++;
                }

                if (quickExpenseInputpropCount > 0)
                {
                    callPayload.Body = quickExpenseInput;
                }
                return callPayload;
            }

            return new ApiConnectionAction<BaseResult>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expensya")]
        public IBodyWorkflowAction<ListAndPagesCountResultCategoryResponse> GetCategories([WorkflowExpression] Func<string> id = null, [WorkflowExpression] Func<string> categoryName = null, [WorkflowExpression] Func<string> costAccount = null, [WorkflowExpression] Func<string> vatAccount = null, [WorkflowExpression] Func<bool> isActive = null, [WorkflowExpression] Func<string> tagsNames = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null, [WorkflowExpression] Func<int> sortBy = null, [WorkflowExpression] Func<bool> isDesc = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/v2/categories/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (id != null)
                    callPayload.Queries["id"] = SourceExpressionConverter.ConvertO(id);
                if (categoryName != null)
                    callPayload.Queries["categoryName"] = SourceExpressionConverter.ConvertO(categoryName);
                if (costAccount != null)
                    callPayload.Queries["costAccount"] = SourceExpressionConverter.ConvertO(costAccount);
                if (vatAccount != null)
                    callPayload.Queries["vatAccount"] = SourceExpressionConverter.ConvertO(vatAccount);
                if (isActive != null)
                    callPayload.Queries["isActive"] = SourceExpressionConverter.ConvertO(isActive);
                if (tagsNames != null)
                    callPayload.Queries["tagsNames"] = SourceExpressionConverter.ConvertO(tagsNames);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (pageSize != null)
                    callPayload.Queries["pageSize"] = SourceExpressionConverter.ConvertO(pageSize);
                if (sortBy != null)
                    callPayload.Queries["sortBy"] = SourceExpressionConverter.ConvertO(sortBy);
                if (isDesc != null)
                    callPayload.Queries["isDesc"] = SourceExpressionConverter.ConvertO(isDesc);
                return callPayload;
            }

            return new ApiConnectionAction<ListAndPagesCountResultCategoryResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expensya")]
        public IBodyWorkflowAction<ListAndPagesCountResultExpenseResponse> GetExpensesWithPaging([WorkflowExpression] Func<string> reportId = null, [WorkflowExpression] Func<string> categoryId = null, [WorkflowExpression] Func<string> expenseName = null, [WorkflowExpression] Func<string> startDate = null, [WorkflowExpression] Func<string> endDate = null, [WorkflowExpression] Func<int> reportState = null, [WorkflowExpression] Func<string> expenseStates = null, [WorkflowExpression] Func<bool> isReimbusable = null, [WorkflowExpression] Func<double> valueInCurrency = null, [WorkflowExpression] Func<string> ownerId = null, [WorkflowExpression] Func<string> ownerMail = null, [WorkflowExpression] Func<string> ownerPayId = null, [WorkflowExpression] Func<string> ownerPayId2 = null, [WorkflowExpression] Func<string> ownerPayId3 = null, [WorkflowExpression] Func<string> ownerPayId4 = null, [WorkflowExpression] Func<string> ownerPayId5 = null, [WorkflowExpression] Func<string> ownerPayId6 = null, [WorkflowExpression] Func<string> projectId = null, [WorkflowExpression] Func<bool> isBillable = null, [WorkflowExpression] Func<int> dateFilterType = null, [WorkflowExpression] Func<string> merchantCountries = null, [WorkflowExpression] Func<string> currencies = null, [WorkflowExpression] Func<string> fileType = null, [WorkflowExpression] Func<string> reportIdShort = null, [WorkflowExpression] Func<string> expenseUseTypes = null, [WorkflowExpression] Func<string> supplierId = null, [WorkflowExpression] Func<string> expenseIds = null, [WorkflowExpression] Func<string> merchantName = null, [WorkflowExpression] Func<string> vatCode = null, [WorkflowExpression] Func<double> valueHTInExpenseCurrency = null, [WorkflowExpression] Func<double> vatRate = null, [WorkflowExpression] Func<double> vatValue = null, [WorkflowExpression] Func<string> reportsIds = null, [WorkflowExpression] Func<int> dateTimeOffset = null, [WorkflowExpression] Func<string> tagsNames = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null, [WorkflowExpression] Func<int> sortBy = null, [WorkflowExpression] Func<bool> isDesc = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/v2/expenses/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (reportId != null)
                    callPayload.Queries["reportId"] = SourceExpressionConverter.ConvertO(reportId);
                if (categoryId != null)
                    callPayload.Queries["categoryId"] = SourceExpressionConverter.ConvertO(categoryId);
                if (expenseName != null)
                    callPayload.Queries["expenseName"] = SourceExpressionConverter.ConvertO(expenseName);
                if (startDate != null)
                    callPayload.Queries["startDate"] = SourceExpressionConverter.ConvertO(startDate);
                if (endDate != null)
                    callPayload.Queries["endDate"] = SourceExpressionConverter.ConvertO(endDate);
                if (reportState != null)
                    callPayload.Queries["reportState"] = SourceExpressionConverter.ConvertO(reportState);
                if (expenseStates != null)
                    callPayload.Queries["expenseStates"] = SourceExpressionConverter.ConvertO(expenseStates);
                if (isReimbusable != null)
                    callPayload.Queries["isReimbusable"] = SourceExpressionConverter.ConvertO(isReimbusable);
                if (valueInCurrency != null)
                    callPayload.Queries["valueInCurrency"] = SourceExpressionConverter.ConvertO(valueInCurrency);
                if (ownerId != null)
                    callPayload.Queries["ownerId"] = SourceExpressionConverter.ConvertO(ownerId);
                if (ownerMail != null)
                    callPayload.Queries["ownerMail"] = SourceExpressionConverter.ConvertO(ownerMail);
                if (ownerPayId != null)
                    callPayload.Queries["ownerPayId"] = SourceExpressionConverter.ConvertO(ownerPayId);
                if (ownerPayId2 != null)
                    callPayload.Queries["ownerPayId2"] = SourceExpressionConverter.ConvertO(ownerPayId2);
                if (ownerPayId3 != null)
                    callPayload.Queries["ownerPayId3"] = SourceExpressionConverter.ConvertO(ownerPayId3);
                if (ownerPayId4 != null)
                    callPayload.Queries["ownerPayId4"] = SourceExpressionConverter.ConvertO(ownerPayId4);
                if (ownerPayId5 != null)
                    callPayload.Queries["ownerPayId5"] = SourceExpressionConverter.ConvertO(ownerPayId5);
                if (ownerPayId6 != null)
                    callPayload.Queries["ownerPayId6"] = SourceExpressionConverter.ConvertO(ownerPayId6);
                if (projectId != null)
                    callPayload.Queries["projectId"] = SourceExpressionConverter.ConvertO(projectId);
                if (isBillable != null)
                    callPayload.Queries["isBillable"] = SourceExpressionConverter.ConvertO(isBillable);
                if (dateFilterType != null)
                    callPayload.Queries["dateFilterType"] = SourceExpressionConverter.ConvertO(dateFilterType);
                if (merchantCountries != null)
                    callPayload.Queries["merchantCountries"] = SourceExpressionConverter.ConvertO(merchantCountries);
                if (currencies != null)
                    callPayload.Queries["currencies"] = SourceExpressionConverter.ConvertO(currencies);
                if (fileType != null)
                    callPayload.Queries["fileType"] = SourceExpressionConverter.ConvertO(fileType);
                if (reportIdShort != null)
                    callPayload.Queries["reportIdShort"] = SourceExpressionConverter.ConvertO(reportIdShort);
                if (expenseUseTypes != null)
                    callPayload.Queries["expenseUseTypes"] = SourceExpressionConverter.ConvertO(expenseUseTypes);
                if (supplierId != null)
                    callPayload.Queries["supplierId"] = SourceExpressionConverter.ConvertO(supplierId);
                if (expenseIds != null)
                    callPayload.Queries["expenseIds"] = SourceExpressionConverter.ConvertO(expenseIds);
                if (merchantName != null)
                    callPayload.Queries["merchantName"] = SourceExpressionConverter.ConvertO(merchantName);
                if (vatCode != null)
                    callPayload.Queries["vatCode"] = SourceExpressionConverter.ConvertO(vatCode);
                if (valueHTInExpenseCurrency != null)
                    callPayload.Queries["valueHTInExpenseCurrency"] = SourceExpressionConverter.ConvertO(valueHTInExpenseCurrency);
                if (vatRate != null)
                    callPayload.Queries["vatRate"] = SourceExpressionConverter.ConvertO(vatRate);
                if (vatValue != null)
                    callPayload.Queries["vatValue"] = SourceExpressionConverter.ConvertO(vatValue);
                if (reportsIds != null)
                    callPayload.Queries["reportsIds"] = SourceExpressionConverter.ConvertO(reportsIds);
                if (dateTimeOffset != null)
                    callPayload.Queries["dateTimeOffset"] = SourceExpressionConverter.ConvertO(dateTimeOffset);
                if (tagsNames != null)
                    callPayload.Queries["tagsNames"] = SourceExpressionConverter.ConvertO(tagsNames);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (pageSize != null)
                    callPayload.Queries["pageSize"] = SourceExpressionConverter.ConvertO(pageSize);
                if (sortBy != null)
                    callPayload.Queries["sortBy"] = SourceExpressionConverter.ConvertO(sortBy);
                if (isDesc != null)
                    callPayload.Queries["isDesc"] = SourceExpressionConverter.ConvertO(isDesc);
                return callPayload;
            }

            return new ApiConnectionAction<ListAndPagesCountResultExpenseResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expensya")]
        public IBodyWorkflowAction<BaseResultProjectResponse> GetProjectDetails([WorkflowExpression] Func<string> projectId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v2/project/{0}/", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(projectId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<BaseResultProjectResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expensya")]
        public IBodyWorkflowAction<ListAndPagesCountResultProjectResponse> GetProjects([WorkflowExpression] Func<string> projectName = null, [WorkflowExpression] Func<string> projectIds = null, [WorkflowExpression] Func<string> validatorName = null, [WorkflowExpression] Func<string> projectReferenceOrExternalId = null, [WorkflowExpression] Func<bool> bringAllProjects = null, [WorkflowExpression] Func<int> projectUseType = null, [WorkflowExpression] Func<bool> isActive = null, [WorkflowExpression] Func<string> tagsNames = null, [WorkflowExpression] Func<string> customFieldsIds = null, [WorkflowExpression] Func<string> expenseDate = null, [WorkflowExpression] Func<string> userId = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null, [WorkflowExpression] Func<int> sortBy = null, [WorkflowExpression] Func<bool> isDesc = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/v2/projects/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (projectName != null)
                    callPayload.Queries["projectName"] = SourceExpressionConverter.ConvertO(projectName);
                if (projectIds != null)
                    callPayload.Queries["projectIds"] = SourceExpressionConverter.ConvertO(projectIds);
                if (validatorName != null)
                    callPayload.Queries["validatorName"] = SourceExpressionConverter.ConvertO(validatorName);
                if (projectReferenceOrExternalId != null)
                    callPayload.Queries["projectReferenceOrExternalId"] = SourceExpressionConverter.ConvertO(projectReferenceOrExternalId);
                if (bringAllProjects != null)
                    callPayload.Queries["bringAllProjects"] = SourceExpressionConverter.ConvertO(bringAllProjects);
                if (projectUseType != null)
                    callPayload.Queries["projectUseType"] = SourceExpressionConverter.ConvertO(projectUseType);
                if (isActive != null)
                    callPayload.Queries["isActive"] = SourceExpressionConverter.ConvertO(isActive);
                if (tagsNames != null)
                    callPayload.Queries["tagsNames"] = SourceExpressionConverter.ConvertO(tagsNames);
                if (customFieldsIds != null)
                    callPayload.Queries["customFieldsIds"] = SourceExpressionConverter.ConvertO(customFieldsIds);
                if (expenseDate != null)
                    callPayload.Queries["expenseDate"] = SourceExpressionConverter.ConvertO(expenseDate);
                if (userId != null)
                    callPayload.Queries["userId"] = SourceExpressionConverter.ConvertO(userId);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (pageSize != null)
                    callPayload.Queries["pageSize"] = SourceExpressionConverter.ConvertO(pageSize);
                if (sortBy != null)
                    callPayload.Queries["sortBy"] = SourceExpressionConverter.ConvertO(sortBy);
                if (isDesc != null)
                    callPayload.Queries["isDesc"] = SourceExpressionConverter.ConvertO(isDesc);
                return callPayload;
            }

            return new ApiConnectionAction<ListAndPagesCountResultProjectResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expensya")]
        public IBodyWorkflowAction<BaseResultListEventResponse> GetReportHistory([WorkflowExpression] Func<string> reportId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/v2/report/history/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["reportId"] = SourceExpressionConverter.ConvertO(reportId);
                return callPayload;
            }

            return new ApiConnectionAction<BaseResultListEventResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expensya")]
        public IBodyWorkflowAction<BaseResult> InviteUser([WorkflowExpression] Func<string> userInviteInputlastName, [WorkflowExpression] Func<string> userInviteInputfirstName, [WorkflowExpression] Func<string> userInviteInputmail, [WorkflowExpression] Func<string> userInviteInputlanguage, [WorkflowExpression] Func<userInviteInputuserTypeInput> userInviteInputuserType, [WorkflowExpression] Func<userInviteInputuserRoleInput> userInviteInputuserRole, [WorkflowExpression] Func<string> userInviteInputmailAlias = null, [WorkflowExpression] Func<string> userInviteInputpayId = null, [WorkflowExpression] Func<string> userInviteInputpayId2 = null, [WorkflowExpression] Func<string> userInviteInputpayId3 = null, [WorkflowExpression] Func<string> userInviteInputpayId4 = null, [WorkflowExpression] Func<string> userInviteInputpayId5 = null, [WorkflowExpression] Func<string> userInviteInputpayId6 = null, [WorkflowExpression] Func<string> userInviteInputlocalCurrency = null, [WorkflowExpression] Func<string> userInviteInputlocalCountry = null, [WorkflowExpression] Func<string> userInviteInputmanagerId = null, [WorkflowExpression] Func<string> userInviteInputreviewerId = null, [WorkflowExpression] Func<string> userInviteInputvendor = null, [WorkflowExpression] Func<string> userInviteInputdefaultProjectId = null, [WorkflowExpression] Func<string> userInviteInputiKRatesId = null, [WorkflowExpression] Func<ValidatorInput[]> userInviteInputadditionalValidators = null, [WorkflowExpression] Func<string[]> userInviteInputtagsToAssign = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/v2/user/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var userInviteInput = new JObject();
                var userInviteInputpropCount = 0;
                userInviteInputpropCount++;
                userInviteInput["LastName"] = SourceExpressionConverter.ConvertToken(userInviteInputlastName);
                userInviteInputpropCount++;
                userInviteInput["FirstName"] = SourceExpressionConverter.ConvertToken(userInviteInputfirstName);
                userInviteInputpropCount++;
                userInviteInput["Mail"] = SourceExpressionConverter.ConvertToken(userInviteInputmail);
                if (userInviteInputmailAlias != null)
                {
                    userInviteInput["MailAlias"] = SourceExpressionConverter.ConvertToken(userInviteInputmailAlias);
                    userInviteInputpropCount++;
                }

                if (userInviteInputpayId != null)
                {
                    userInviteInput["PayId"] = SourceExpressionConverter.ConvertToken(userInviteInputpayId);
                    userInviteInputpropCount++;
                }

                if (userInviteInputpayId2 != null)
                {
                    userInviteInput["PayId2"] = SourceExpressionConverter.ConvertToken(userInviteInputpayId2);
                    userInviteInputpropCount++;
                }

                if (userInviteInputpayId3 != null)
                {
                    userInviteInput["PayId3"] = SourceExpressionConverter.ConvertToken(userInviteInputpayId3);
                    userInviteInputpropCount++;
                }

                if (userInviteInputpayId4 != null)
                {
                    userInviteInput["PayId4"] = SourceExpressionConverter.ConvertToken(userInviteInputpayId4);
                    userInviteInputpropCount++;
                }

                if (userInviteInputpayId5 != null)
                {
                    userInviteInput["PayId5"] = SourceExpressionConverter.ConvertToken(userInviteInputpayId5);
                    userInviteInputpropCount++;
                }

                if (userInviteInputpayId6 != null)
                {
                    userInviteInput["PayId6"] = SourceExpressionConverter.ConvertToken(userInviteInputpayId6);
                    userInviteInputpropCount++;
                }

                userInviteInputpropCount++;
                userInviteInput["Language"] = SourceExpressionConverter.ConvertToken(userInviteInputlanguage);
                if (userInviteInputlocalCurrency != null)
                {
                    userInviteInput["LocalCurrency"] = SourceExpressionConverter.ConvertToken(userInviteInputlocalCurrency);
                    userInviteInputpropCount++;
                }

                if (userInviteInputlocalCountry != null)
                {
                    userInviteInput["LocalCountry"] = SourceExpressionConverter.ConvertToken(userInviteInputlocalCountry);
                    userInviteInputpropCount++;
                }

                if (userInviteInputmanagerId != null)
                {
                    userInviteInput["ManagerId"] = SourceExpressionConverter.ConvertToken(userInviteInputmanagerId);
                    userInviteInputpropCount++;
                }

                if (userInviteInputreviewerId != null)
                {
                    userInviteInput["ReviewerId"] = SourceExpressionConverter.ConvertToken(userInviteInputreviewerId);
                    userInviteInputpropCount++;
                }

                userInviteInputpropCount++;
                userInviteInput["UserType"] = SourceExpressionConverter.Convert(userInviteInputuserType);
                if (userInviteInputvendor != null)
                {
                    userInviteInput["Vendor"] = SourceExpressionConverter.ConvertToken(userInviteInputvendor);
                    userInviteInputpropCount++;
                }

                userInviteInputpropCount++;
                userInviteInput["UserRole"] = SourceExpressionConverter.Convert(userInviteInputuserRole);
                if (userInviteInputdefaultProjectId != null)
                {
                    userInviteInput["DefaultProjectId"] = SourceExpressionConverter.ConvertToken(userInviteInputdefaultProjectId);
                    userInviteInputpropCount++;
                }

                if (userInviteInputiKRatesId != null)
                {
                    userInviteInput["IKRatesId"] = SourceExpressionConverter.ConvertToken(userInviteInputiKRatesId);
                    userInviteInputpropCount++;
                }

                if (userInviteInputadditionalValidators != null)
                {
                    userInviteInput["AdditionalValidators"] = SourceExpressionConverter.ConvertToken(userInviteInputadditionalValidators);
                    userInviteInputpropCount++;
                }

                if (userInviteInputtagsToAssign != null)
                {
                    userInviteInput["TagsToAssign"] = SourceExpressionConverter.ConvertToken(userInviteInputtagsToAssign);
                    userInviteInputpropCount++;
                }

                if (userInviteInputpropCount > 0)
                {
                    callPayload.Body = userInviteInput;
                }
                return callPayload;
            }

            return new ApiConnectionAction<BaseResult>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expensya")]
        public IBodyWorkflowAction<LoginResponse> RefreshUserToken()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/v2/refreshUserToken/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<LoginResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expensya")]
        public IBodyWorkflowAction<BaseResult> UpateUser([WorkflowExpression] Func<string> userId, [WorkflowExpression] Func<bool> shouldUpdateValidators, [WorkflowExpression] Func<string> userUpdateInputlastName = null, [WorkflowExpression] Func<string> userUpdateInputfirstName = null, [WorkflowExpression] Func<string> userUpdateInputmail = null, [WorkflowExpression] Func<string> userUpdateInputmailAlias = null, [WorkflowExpression] Func<string> userUpdateInputpayId = null, [WorkflowExpression] Func<string> userUpdateInputpayId2 = null, [WorkflowExpression] Func<string> userUpdateInputpayId3 = null, [WorkflowExpression] Func<string> userUpdateInputpayId4 = null, [WorkflowExpression] Func<string> userUpdateInputpayId5 = null, [WorkflowExpression] Func<string> userUpdateInputpayId6 = null, [WorkflowExpression] Func<string> userUpdateInputlanguage = null, [WorkflowExpression] Func<string> userUpdateInputlocalCurrency = null, [WorkflowExpression] Func<string> userUpdateInputlocalCountry = null, [WorkflowExpression] Func<string> userUpdateInputmanagerId = null, [WorkflowExpression] Func<string> userUpdateInputreviewerId = null, [WorkflowExpression] Func<userUpdateInputuserTypeInput> userUpdateInputuserType = null, [WorkflowExpression] Func<string> userUpdateInputvendor = null, [WorkflowExpression] Func<userUpdateInputuserRoleInput> userUpdateInputuserRole = null, [WorkflowExpression] Func<string> userUpdateInputjobTitle = null, [WorkflowExpression] Func<bool> userUpdateInputcanAddPurchase = null, [WorkflowExpression] Func<string> userUpdateInputdefaultProjectId = null, [WorkflowExpression] Func<string> userUpdateInputiKRatesId = null, [WorkflowExpression] Func<ValidatorInput[]> userUpdateInputadditionalValidators = null, [WorkflowExpression] Func<string[]> userUpdateInputtagsToAssign = null, [WorkflowExpression] Func<string[]> userUpdateInputtagsToUnassign = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v2/user/{0}/", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(userId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["shouldUpdateValidators"] = SourceExpressionConverter.ConvertO(shouldUpdateValidators);
                var userUpdateInput = new JObject();
                var userUpdateInputpropCount = 0;
                if (userUpdateInputlastName != null)
                {
                    userUpdateInput["LastName"] = SourceExpressionConverter.ConvertToken(userUpdateInputlastName);
                    userUpdateInputpropCount++;
                }

                if (userUpdateInputfirstName != null)
                {
                    userUpdateInput["FirstName"] = SourceExpressionConverter.ConvertToken(userUpdateInputfirstName);
                    userUpdateInputpropCount++;
                }

                if (userUpdateInputmail != null)
                {
                    userUpdateInput["Mail"] = SourceExpressionConverter.ConvertToken(userUpdateInputmail);
                    userUpdateInputpropCount++;
                }

                if (userUpdateInputmailAlias != null)
                {
                    userUpdateInput["MailAlias"] = SourceExpressionConverter.ConvertToken(userUpdateInputmailAlias);
                    userUpdateInputpropCount++;
                }

                if (userUpdateInputpayId != null)
                {
                    userUpdateInput["PayId"] = SourceExpressionConverter.ConvertToken(userUpdateInputpayId);
                    userUpdateInputpropCount++;
                }

                if (userUpdateInputpayId2 != null)
                {
                    userUpdateInput["PayId2"] = SourceExpressionConverter.ConvertToken(userUpdateInputpayId2);
                    userUpdateInputpropCount++;
                }

                if (userUpdateInputpayId3 != null)
                {
                    userUpdateInput["PayId3"] = SourceExpressionConverter.ConvertToken(userUpdateInputpayId3);
                    userUpdateInputpropCount++;
                }

                if (userUpdateInputpayId4 != null)
                {
                    userUpdateInput["PayId4"] = SourceExpressionConverter.ConvertToken(userUpdateInputpayId4);
                    userUpdateInputpropCount++;
                }

                if (userUpdateInputpayId5 != null)
                {
                    userUpdateInput["PayId5"] = SourceExpressionConverter.ConvertToken(userUpdateInputpayId5);
                    userUpdateInputpropCount++;
                }

                if (userUpdateInputpayId6 != null)
                {
                    userUpdateInput["PayId6"] = SourceExpressionConverter.ConvertToken(userUpdateInputpayId6);
                    userUpdateInputpropCount++;
                }

                if (userUpdateInputlanguage != null)
                {
                    userUpdateInput["Language"] = SourceExpressionConverter.ConvertToken(userUpdateInputlanguage);
                    userUpdateInputpropCount++;
                }

                if (userUpdateInputlocalCurrency != null)
                {
                    userUpdateInput["LocalCurrency"] = SourceExpressionConverter.ConvertToken(userUpdateInputlocalCurrency);
                    userUpdateInputpropCount++;
                }

                if (userUpdateInputlocalCountry != null)
                {
                    userUpdateInput["LocalCountry"] = SourceExpressionConverter.ConvertToken(userUpdateInputlocalCountry);
                    userUpdateInputpropCount++;
                }

                if (userUpdateInputmanagerId != null)
                {
                    userUpdateInput["Manager_Id"] = SourceExpressionConverter.ConvertToken(userUpdateInputmanagerId);
                    userUpdateInputpropCount++;
                }

                if (userUpdateInputreviewerId != null)
                {
                    userUpdateInput["Reviewer_Id"] = SourceExpressionConverter.ConvertToken(userUpdateInputreviewerId);
                    userUpdateInputpropCount++;
                }

                if (userUpdateInputuserType != null)
                {
                    userUpdateInput["UserType"] = SourceExpressionConverter.Convert(userUpdateInputuserType);
                    userUpdateInputpropCount++;
                }

                if (userUpdateInputvendor != null)
                {
                    userUpdateInput["Vendor"] = SourceExpressionConverter.ConvertToken(userUpdateInputvendor);
                    userUpdateInputpropCount++;
                }

                if (userUpdateInputuserRole != null)
                {
                    userUpdateInput["UserRole"] = SourceExpressionConverter.Convert(userUpdateInputuserRole);
                    userUpdateInputpropCount++;
                }

                if (userUpdateInputjobTitle != null)
                {
                    userUpdateInput["JobTitle"] = SourceExpressionConverter.ConvertToken(userUpdateInputjobTitle);
                    userUpdateInputpropCount++;
                }

                if (userUpdateInputcanAddPurchase != null)
                {
                    userUpdateInput["CanAddPurchase"] = SourceExpressionConverter.ConvertToken(userUpdateInputcanAddPurchase);
                    userUpdateInputpropCount++;
                }

                if (userUpdateInputdefaultProjectId != null)
                {
                    userUpdateInput["DefaultProjectId"] = SourceExpressionConverter.ConvertToken(userUpdateInputdefaultProjectId);
                    userUpdateInputpropCount++;
                }

                if (userUpdateInputiKRatesId != null)
                {
                    userUpdateInput["IKRates_Id"] = SourceExpressionConverter.ConvertToken(userUpdateInputiKRatesId);
                    userUpdateInputpropCount++;
                }

                if (userUpdateInputadditionalValidators != null)
                {
                    userUpdateInput["AdditionalValidators"] = SourceExpressionConverter.ConvertToken(userUpdateInputadditionalValidators);
                    userUpdateInputpropCount++;
                }

                if (userUpdateInputtagsToAssign != null)
                {
                    userUpdateInput["TagsToAssign"] = SourceExpressionConverter.ConvertToken(userUpdateInputtagsToAssign);
                    userUpdateInputpropCount++;
                }

                if (userUpdateInputtagsToUnassign != null)
                {
                    userUpdateInput["TagsToUnassign"] = SourceExpressionConverter.ConvertToken(userUpdateInputtagsToUnassign);
                    userUpdateInputpropCount++;
                }

                if (userUpdateInputpropCount > 0)
                {
                    callPayload.Body = userUpdateInput;
                }
                return callPayload;
            }

            return new ApiConnectionAction<BaseResult>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expensya")]
        public IBodyWorkflowAction<BaseResultListAddOrUpdateEntityResult> UpdateProjectState([WorkflowExpression] Func<string[]> updateProjectStateInputitemIds, [WorkflowExpression] Func<bool> updateProjectStateInputprojectState)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/v2/projects/states/";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var updateProjectStateInput = new JObject();
                var updateProjectStateInputpropCount = 0;
                updateProjectStateInputpropCount++;
                updateProjectStateInput["ItemIds"] = SourceExpressionConverter.ConvertToken(updateProjectStateInputitemIds);
                updateProjectStateInputpropCount++;
                updateProjectStateInput["ProjectState"] = SourceExpressionConverter.ConvertToken(updateProjectStateInputprojectState);
                if (updateProjectStateInputpropCount > 0)
                {
                    callPayload.Body = updateProjectStateInput;
                }
                return callPayload;
            }

            return new ApiConnectionAction<BaseResultListAddOrUpdateEntityResult>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expensya")]
        public IBodyWorkflowAction<BaseResultListUpdateUserResult> UpdateUsersState([WorkflowExpression] Func<UpdateUserStateInput[]> updateUserStateInputArray = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/v2/users/state/";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = SourceExpressionConverter.ConvertToken(updateUserStateInputArray);
                return callPayload;
            }

            return new ApiConnectionAction<BaseResultListUpdateUserResult>(BuildSourceInput);
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

    public enum reportUpdateStatusInputoperationInput
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

    public enum quickExpenseInputexpenseUseTypeInput
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

    public enum userInviteInputuserTypeInput
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

    public enum userInviteInputuserRoleInput
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

    public enum userUpdateInputuserTypeInput
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

    public enum userUpdateInputuserRoleInput
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