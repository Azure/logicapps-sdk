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
        public IBodyWorkflowAction<string> GetExpenseImage(Expression<Func<string>> expenseId)
        {
            var apiCallPath = String.Format("/api/expense/{0}/image", ExpressionConverter.ConvertWithUrlEncoding(expenseId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expensya")]
        public IBodyWorkflowAction<BaseResultExportResponse> ExportExpenses(Expression<Func<string>> exportId, Expression<Func<string>> reportId = null, Expression<Func<string>> categoryId = null, Expression<Func<string>> expenseName = null, Expression<Func<string>> startDate = null, Expression<Func<string>> endDate = null, Expression<Func<string>> expenseStates = null, Expression<Func<string>> reportStates = null, Expression<Func<string>> userIds = null, Expression<Func<string>> userMail = null, Expression<Func<string>> reportIds = null, Expression<Func<string>> expenseIds = null, Expression<Func<string>> reportName = null, Expression<Func<string>> reportIdShort = null, Expression<Func<int>> dateFilterType = null, Expression<Func<string>> payId = null, Expression<Func<string>> payId2 = null, Expression<Func<string>> payId3 = null, Expression<Func<string>> accountingPeriod = null, Expression<Func<bool>> includeReceipts = null, Expression<Func<int>> expenseUseTypes = null, Expression<Func<string>> archiveExpenses = null)
        {
            var apiCallPath = String.Format("/api/export/expenses/{0}/", ExpressionConverter.ConvertWithUrlEncoding(exportId, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expensya")]
        public IBodyWorkflowAction<BaseResultExportResponse> PrintMission(Expression<Func<string>> reportId)
        {
            var apiCallPath = String.Format("/api/export/report/{0}/pdf/", ExpressionConverter.ConvertWithUrlEncoding(reportId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<BaseResultExportResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expensya")]
        public IBodyWorkflowAction<BaseResultListExportFormatResponse> ExportFormats(Expression<Func<bool>> isForExpenses = null, Expression<Func<int>> exportType = null)
        {
            var apiCallPath = "/api/exports/";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (isForExpenses != null)
                callPayload.Queries["isForExpenses"] = ExpressionConverter.Convert(isForExpenses);
            if (exportType != null)
                callPayload.Queries["exportType"] = ExpressionConverter.Convert(exportType);
            return new ApiConnectionAction<BaseResultListExportFormatResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expensya")]
        public IBodyWorkflowAction<BaseResultListAddOrUpdateEntityResult> AddProjects(Expression<Func<AddOrUpdateProjectInput[]>> addOrUpdateProjectInputArray = null)
        {
            var apiCallPath = "/api/projects/";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertO(addOrUpdateProjectInputArray);
            return new ApiConnectionAction<BaseResultListAddOrUpdateEntityResult>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expensya")]
        public IBodyWorkflowAction<BaseResultListAddOrUpdateEntityResult> UpdateProjects(Expression<Func<AddOrUpdateProjectInput[]>> addOrUpdateProjectInputArray = null)
        {
            var apiCallPath = "/api/projects/";
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertO(addOrUpdateProjectInputArray);
            return new ApiConnectionAction<BaseResultListAddOrUpdateEntityResult>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expensya")]
        public IBodyWorkflowAction<BaseResult> AddReciept(Expression<Func<string>> addReceiptInputuserId, Expression<Func<string>> addReceiptInputreceiptContent, Expression<Func<string>> addReceiptInputreceiptName)
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
            var apiCallPath = String.Format("/api/v2/{0}/reports/", ExpressionConverter.ConvertWithUrlEncoding(validatorMail, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expensya")]
        public IBodyWorkflowAction<ListAndPagesCountResultCategoryResponse> GetCategoriesV2(Expression<Func<string>> id = null, Expression<Func<string>> categoryName = null, Expression<Func<string>> costAccount = null, Expression<Func<string>> vatAccount = null, Expression<Func<bool>> isActive = null, Expression<Func<string>> tagsNames = null, Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null, Expression<Func<int>> sortBy = null, Expression<Func<bool>> isDesc = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expensya")]
        public IBodyWorkflowAction<ListAndPagesCountResultExpenseResponse> GetExpensesWithPagingV2(Expression<Func<string>> reportId = null, Expression<Func<string>> categoryId = null, Expression<Func<string>> expenseName = null, Expression<Func<string>> startDate = null, Expression<Func<string>> endDate = null, Expression<Func<int>> reportState = null, Expression<Func<string>> expenseStates = null, Expression<Func<bool>> isReimbusable = null, Expression<Func<double>> valueInCurrency = null, Expression<Func<string>> ownerId = null, Expression<Func<string>> ownerMail = null, Expression<Func<string>> ownerPayId = null, Expression<Func<string>> ownerPayId2 = null, Expression<Func<string>> ownerPayId3 = null, Expression<Func<string>> ownerPayId4 = null, Expression<Func<string>> ownerPayId5 = null, Expression<Func<string>> ownerPayId6 = null, Expression<Func<string>> projectId = null, Expression<Func<bool>> isBillable = null, Expression<Func<int>> dateFilterType = null, Expression<Func<string>> merchantCountries = null, Expression<Func<string>> currencies = null, Expression<Func<string>> fileType = null, Expression<Func<string>> reportIdShort = null, Expression<Func<string>> expenseUseTypes = null, Expression<Func<string>> supplierId = null, Expression<Func<string>> expenseIds = null, Expression<Func<string>> merchantName = null, Expression<Func<string>> vatCode = null, Expression<Func<double>> valueHTInExpenseCurrency = null, Expression<Func<double>> vatRate = null, Expression<Func<double>> vatValue = null, Expression<Func<string>> reportsIds = null, Expression<Func<int>> dateTimeOffset = null, Expression<Func<string>> tagsNames = null, Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null, Expression<Func<int>> sortBy = null, Expression<Func<bool>> isDesc = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expensya")]
        public IBodyWorkflowAction<BaseResultProjectResponse> GetProjectDetailsV2(Expression<Func<string>> projectId)
        {
            var apiCallPath = String.Format("/api/v2/project/{0}/", ExpressionConverter.ConvertWithUrlEncoding(projectId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<BaseResultProjectResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expensya")]
        public IBodyWorkflowAction<ListAndPagesCountResultProjectResponse> GetProjectsV2(Expression<Func<string>> projectName = null, Expression<Func<string>> projectIds = null, Expression<Func<string>> validatorName = null, Expression<Func<string>> projectReferenceOrExternalId = null, Expression<Func<bool>> bringAllProjects = null, Expression<Func<int>> projectUseType = null, Expression<Func<bool>> isActive = null, Expression<Func<string>> tagsNames = null, Expression<Func<string>> customFieldsIds = null, Expression<Func<string>> expenseDate = null, Expression<Func<string>> userId = null, Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null, Expression<Func<int>> sortBy = null, Expression<Func<bool>> isDesc = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expensya")]
        public IBodyWorkflowAction<BaseResultListAddOrUpdateEntityResult> UpdateProjectStateV2(Expression<Func<string[]>> updateProjectStateInputitemIds, Expression<Func<bool>> updateProjectStateInputprojectState)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expensya")]
        public IBodyWorkflowAction<BaseResult> AddQuickExpenseV2(Expression<Func<string>> userId, Expression<Func<string>> quickExpenseInputfileToSend, Expression<Func<string>> quickExpenseInputtitle = null, Expression<Func<double>> quickExpenseInputtransactionAmount = null, Expression<Func<string>> quickExpenseInputvatRates = null, Expression<Func<string>> quickExpenseInputvatAmounts = null, Expression<Func<string>> quickExpenseInputcurrencyCode = null, Expression<Func<string>> quickExpenseInputtransactionDate = null, Expression<Func<string>> quickExpenseInputmerchantName = null, Expression<Func<string>> quickExpenseInputlocationCountry = null, Expression<Func<string>> quickExpenseInputlocationCity = null, Expression<Func<string>> quickExpenseInputcomment = null, Expression<Func<string>> quickExpenseInputmerchantExpenseId = null, Expression<Func<bool>> quickExpenseInputisEncrypted = null, Expression<Func<quickExpenseInputexpenseUseTypeInput>> quickExpenseInputexpenseUseType = null, Expression<Func<string>> quickExpenseInputpaymentTypeCode = null, Expression<Func<string>> quickExpenseInputexpenseTypeCode = null, Expression<Func<string>> quickExpenseInputfileType = null)
        {
            var apiCallPath = String.Format("/api/v2/quickexpense/{0}/", ExpressionConverter.ConvertWithUrlEncoding(userId, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expensya")]
        public IBodyWorkflowAction<LoginResponse> RefreshUserTokenV2()
        {
            var apiCallPath = "/api/v2/refreshUserToken/";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<LoginResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expensya")]
        public IBodyWorkflowAction<BaseResult> UpdateReportStatus(Expression<Func<string>> reportId, Expression<Func<reportUpdateStatusInputoperationInput>> reportUpdateStatusInputoperation, Expression<Func<string>> reportUpdateStatusInputmessage, Expression<Func<string[]>> reportUpdateStatusInputinvoiceIdsToReject = null, Expression<Func<string>> reportUpdateStatusInputaccountingPeriod = null)
        {
            var apiCallPath = String.Format("/api/v2/report/{0}/updateStatus/", ExpressionConverter.ConvertWithUrlEncoding(reportId, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expensya")]
        public IBodyWorkflowAction<BaseResultListEventResponse> GetReportHistoryV2(Expression<Func<string>> reportId)
        {
            var apiCallPath = "/api/v2/report/history/";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["reportId"] = ExpressionConverter.Convert(reportId);
            return new ApiConnectionAction<BaseResultListEventResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expensya")]
        public IBodyWorkflowAction<ListAndPagesCountResultReportResponse> CompanyReports(Expression<Func<string>> reportName = null, Expression<Func<string>> reportStartDate = null, Expression<Func<string>> reportEndDate = null, Expression<Func<string>> reportStates = null, Expression<Func<string>> reportIdShort = null, Expression<Func<string>> ownerId = null, Expression<Func<string>> ownerPayId2 = null, Expression<Func<string>> projectId = null, Expression<Func<string>> tagsNames = null, Expression<Func<int>> dateFilterType = null, Expression<Func<int>> sortBy = null, Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null, Expression<Func<bool>> isDesc = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expensya")]
        public IBodyWorkflowAction<BaseResult> InviteUserV2(Expression<Func<string>> userInviteInputlastName, Expression<Func<string>> userInviteInputfirstName, Expression<Func<string>> userInviteInputmail, Expression<Func<string>> userInviteInputlanguage, Expression<Func<userInviteInputuserTypeInput>> userInviteInputuserType, Expression<Func<userInviteInputuserRoleInput>> userInviteInputuserRole, Expression<Func<string>> userInviteInputmailAlias = null, Expression<Func<string>> userInviteInputpayId = null, Expression<Func<string>> userInviteInputpayId2 = null, Expression<Func<string>> userInviteInputpayId3 = null, Expression<Func<string>> userInviteInputpayId4 = null, Expression<Func<string>> userInviteInputpayId5 = null, Expression<Func<string>> userInviteInputpayId6 = null, Expression<Func<string>> userInviteInputlocalCurrency = null, Expression<Func<string>> userInviteInputlocalCountry = null, Expression<Func<string>> userInviteInputmanagerId = null, Expression<Func<string>> userInviteInputreviewerId = null, Expression<Func<string>> userInviteInputvendor = null, Expression<Func<string>> userInviteInputdefaultProjectId = null, Expression<Func<string>> userInviteInputiKRatesId = null, Expression<Func<ValidatorInput[]>> userInviteInputadditionalValidators = null, Expression<Func<string[]>> userInviteInputtagsToAssign = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expensya")]
        public IBodyWorkflowAction<BaseResult> UpateUserV2(Expression<Func<string>> userId, Expression<Func<bool>> shouldUpdateValidators, Expression<Func<string>> userUpdateInputlastName = null, Expression<Func<string>> userUpdateInputfirstName = null, Expression<Func<string>> userUpdateInputmail = null, Expression<Func<string>> userUpdateInputmailAlias = null, Expression<Func<string>> userUpdateInputpayId = null, Expression<Func<string>> userUpdateInputpayId2 = null, Expression<Func<string>> userUpdateInputpayId3 = null, Expression<Func<string>> userUpdateInputpayId4 = null, Expression<Func<string>> userUpdateInputpayId5 = null, Expression<Func<string>> userUpdateInputpayId6 = null, Expression<Func<string>> userUpdateInputlanguage = null, Expression<Func<string>> userUpdateInputlocalCurrency = null, Expression<Func<string>> userUpdateInputlocalCountry = null, Expression<Func<string>> userUpdateInputmanagerId = null, Expression<Func<string>> userUpdateInputreviewerId = null, Expression<Func<userUpdateInputuserTypeInput>> userUpdateInputuserType = null, Expression<Func<string>> userUpdateInputvendor = null, Expression<Func<userUpdateInputuserRoleInput>> userUpdateInputuserRole = null, Expression<Func<string>> userUpdateInputjobTitle = null, Expression<Func<bool>> userUpdateInputcanAddPurchase = null, Expression<Func<string>> userUpdateInputdefaultProjectId = null, Expression<Func<string>> userUpdateInputiKRatesId = null, Expression<Func<ValidatorInput[]>> userUpdateInputadditionalValidators = null, Expression<Func<string[]>> userUpdateInputtagsToAssign = null, Expression<Func<string[]>> userUpdateInputtagsToUnassign = null)
        {
            var apiCallPath = String.Format("/api/v2/user/{0}/", ExpressionConverter.ConvertWithUrlEncoding(userId, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expensya")]
        public IBodyWorkflowAction<ListAndPagesCountResultUserResponse> CompanyUsers(Expression<Func<string>> id = null, Expression<Func<string>> firstName = null, Expression<Func<string>> lastName = null, Expression<Func<string>> mail = null, Expression<Func<string>> payId = null, Expression<Func<string>> mailOrNameOrPayId = null, Expression<Func<int>> type = null, Expression<Func<int>> state = null, Expression<Func<string>> reviewerId = null, Expression<Func<string>> reviewerName = null, Expression<Func<string>> managerId = null, Expression<Func<string>> managerName = null, Expression<Func<string>> userIds = null, Expression<Func<string>> userMails = null, Expression<Func<string>> tagsNames = null, Expression<Func<string>> simpleTagsNames = null, Expression<Func<int>> sortBy = null, Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null, Expression<Func<bool>> isDesc = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expensya")]
        public IBodyWorkflowAction<BaseResultListUpdateUserResult> UpdateUsersStateV2(Expression<Func<UpdateUserStateInput[]>> updateUserStateInputArray = null)
        {
            var apiCallPath = "/api/v2/users/state/";
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertO(updateUserStateInputArray);
            return new ApiConnectionAction<BaseResultListUpdateUserResult>(callPayload);
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