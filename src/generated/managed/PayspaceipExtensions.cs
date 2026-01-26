//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Payspaceip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class PayspaceipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "payspaceip")]
        public IBodyWorkflowAction<GetACollectionOfEmployeesResponse> GetACollectionOfEmployees(Expression<Func<int>> companyId, Expression<Func<string>> customAuthHeader, Expression<Func<string>> customEnvironmentHeader, Expression<Func<string>> orderby = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, Expression<Func<string>> count = null, Expression<Func<string>> filter = null, Expression<Func<string>> select = null)
        {
            var apiCallPath = String.Format("/odata/v1.1/{0}/Employee", ExpressionConverter.ConvertWithUrlEncoding(companyId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (orderby != null)
                callPayload.Queries["$orderby"] = ExpressionConverter.Convert(orderby);
            if (top != null)
                callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
            if (skip != null)
                callPayload.Queries["$skip"] = ExpressionConverter.Convert(skip);
            if (count != null)
                callPayload.Queries["$count"] = ExpressionConverter.Convert(count);
            if (filter != null)
                callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
            if (select != null)
                callPayload.Queries["$select"] = ExpressionConverter.Convert(select);
            callPayload.Headers["CustomAuthHeader"] = ExpressionConverter.Convert(customAuthHeader);
            callPayload.Headers["CustomEnvironmentHeader"] = ExpressionConverter.Convert(customEnvironmentHeader);
            return new ApiConnectionAction<GetACollectionOfEmployeesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "payspaceip")]
        public IBodyWorkflowAction<CreateASingleEmployeeRecordResponse> CreateASingleEmployeeRecord(Expression<Func<int>> companyId, Expression<Func<string>> customAuthHeader, Expression<Func<string>> customEnvironmentHeader, Expression<Func<string>> body = null)
        {
            var apiCallPath = String.Format("/odata/v1.1/{0}/Employee", ExpressionConverter.ConvertWithUrlEncoding(companyId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["CustomAuthHeader"] = ExpressionConverter.Convert(customAuthHeader);
            callPayload.Headers["CustomEnvironmentHeader"] = ExpressionConverter.Convert(customEnvironmentHeader);
            callPayload.Body = ExpressionConverter.ConvertO(body);
            return new ApiConnectionAction<CreateASingleEmployeeRecordResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "payspaceip")]
        public IBodyWorkflowAction<GetACollectionOfEmployeesAsOfAnEffectiveDateResponse> GetACollectionOfEmployeesAsOfAnEffectiveDate(Expression<Func<int>> companyId, Expression<Func<string>> effectivedate, Expression<Func<int>> skip, Expression<Func<string>> count, Expression<Func<string>> customAuthHeader, Expression<Func<string>> customEnvironmentHeader, Expression<Func<string>> orderby = null, Expression<Func<int>> top = null, Expression<Func<string>> filter = null)
        {
            var apiCallPath = String.Format("/odata/v1.1/{0}/Employee/effective/:{1}", ExpressionConverter.ConvertWithUrlEncoding(companyId, 1), ExpressionConverter.ConvertWithUrlEncoding(effectivedate, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (orderby != null)
                callPayload.Queries["$orderby"] = ExpressionConverter.Convert(orderby);
            if (top != null)
                callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
            callPayload.Queries["$skip"] = ExpressionConverter.Convert(skip);
            callPayload.Queries["$count"] = ExpressionConverter.Convert(count);
            if (filter != null)
                callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
            callPayload.Headers["CustomAuthHeader"] = ExpressionConverter.Convert(customAuthHeader);
            callPayload.Headers["CustomEnvironmentHeader"] = ExpressionConverter.Convert(customEnvironmentHeader);
            return new ApiConnectionAction<GetACollectionOfEmployeesAsOfAnEffectiveDateResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "payspaceip")]
        public IBodyWorkflowAction<GetASingleEmployeeRecordResponse> GetASingleEmployeeRecord(Expression<Func<int>> companyId, Expression<Func<int>> employeeId, Expression<Func<string>> customAuthHeader, Expression<Func<string>> customEnvironmentHeader)
        {
            var apiCallPath = String.Format("/odata/v1.1/{0}/Employee({1})", ExpressionConverter.ConvertWithUrlEncoding(companyId, 1), ExpressionConverter.ConvertWithUrlEncoding(employeeId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["CustomAuthHeader"] = ExpressionConverter.Convert(customAuthHeader);
            callPayload.Headers["CustomEnvironmentHeader"] = ExpressionConverter.Convert(customEnvironmentHeader);
            return new ApiConnectionAction<GetASingleEmployeeRecordResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "payspaceip")]
        public IBodyWorkflowAction<UpdateASingleEmployeeRecordResponse> UpdateASingleEmployeeRecord(Expression<Func<string>> companyId, Expression<Func<string>> employeeId, Expression<Func<string>> customAuthHeader, Expression<Func<string>> customEnvironmentHeader, Expression<Func<string>> body = null)
        {
            var apiCallPath = String.Format("/odata/v1.1/{0}/Employee({1})", ExpressionConverter.ConvertWithUrlEncoding(companyId, 1), ExpressionConverter.ConvertWithUrlEncoding(employeeId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["CustomAuthHeader"] = ExpressionConverter.Convert(customAuthHeader);
            callPayload.Headers["CustomEnvironmentHeader"] = ExpressionConverter.Convert(customEnvironmentHeader);
            callPayload.Body = ExpressionConverter.ConvertO(body);
            return new ApiConnectionAction<UpdateASingleEmployeeRecordResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "payspaceip")]
        public IBodyWorkflowAction<DownloadEmployeePhotoResponse> DownloadEmployeePhoto(Expression<Func<int>> companyId, Expression<Func<int>> employeeId, Expression<Func<string>> customAuthHeader, Expression<Func<string>> customEnvironmentHeader)
        {
            var apiCallPath = String.Format("/odata/v1.1/{0}/Employee/{1}/image/download", ExpressionConverter.ConvertWithUrlEncoding(companyId, 1), ExpressionConverter.ConvertWithUrlEncoding(employeeId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["CustomAuthHeader"] = ExpressionConverter.Convert(customAuthHeader);
            callPayload.Headers["CustomEnvironmentHeader"] = ExpressionConverter.Convert(customEnvironmentHeader);
            return new ApiConnectionAction<DownloadEmployeePhotoResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "payspaceip")]
        public IBodyWorkflowAction<UploadEmployeePhotoResponse> UploadEmployeePhoto(Expression<Func<int>> companyId, Expression<Func<int>> employeeId, Expression<Func<string>> customAuthHeader, Expression<Func<string>> customEnvironmentHeader)
        {
            var apiCallPath = String.Format("/odata/v1.1/{0}/Employee/{1}/image/upload", ExpressionConverter.ConvertWithUrlEncoding(companyId, 1), ExpressionConverter.ConvertWithUrlEncoding(employeeId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["CustomAuthHeader"] = ExpressionConverter.Convert(customAuthHeader);
            callPayload.Headers["CustomEnvironmentHeader"] = ExpressionConverter.Convert(customEnvironmentHeader);
            return new ApiConnectionAction<UploadEmployeePhotoResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "payspaceip")]
        public IBodyWorkflowAction<GetACollectionOfEmploymentStatusesResponse> GetACollectionOfEmploymentStatuses(Expression<Func<int>> skip, Expression<Func<string>> count, Expression<Func<int>> companyId, Expression<Func<string>> customAuthHeader, Expression<Func<string>> customEnvironmentHeader, Expression<Func<string>> orderby = null, Expression<Func<int>> top = null, Expression<Func<string>> filter = null)
        {
            var apiCallPath = String.Format("/odata/v1.1/{0}/EmployeeEmploymentStatus", ExpressionConverter.ConvertWithUrlEncoding(companyId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (orderby != null)
                callPayload.Queries["$orderby"] = ExpressionConverter.Convert(orderby);
            if (top != null)
                callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
            callPayload.Queries["$skip"] = ExpressionConverter.Convert(skip);
            callPayload.Queries["$count"] = ExpressionConverter.Convert(count);
            if (filter != null)
                callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
            callPayload.Headers["CustomAuthHeader"] = ExpressionConverter.Convert(customAuthHeader);
            callPayload.Headers["CustomEnvironmentHeader"] = ExpressionConverter.Convert(customEnvironmentHeader);
            return new ApiConnectionAction<GetACollectionOfEmploymentStatusesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "payspaceip")]
        public IBodyWorkflowAction<CreateASingleEmploymentStatusRecordResponse> CreateASingleEmploymentStatusRecord(Expression<Func<int>> companyId, Expression<Func<string>> customAuthHeader, Expression<Func<string>> customEnvironmentHeader, Expression<Func<string>> body = null)
        {
            var apiCallPath = String.Format("/odata/v1.1/{0}/EmployeeEmploymentStatus", ExpressionConverter.ConvertWithUrlEncoding(companyId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["CustomAuthHeader"] = ExpressionConverter.Convert(customAuthHeader);
            callPayload.Headers["CustomEnvironmentHeader"] = ExpressionConverter.Convert(customEnvironmentHeader);
            callPayload.Body = ExpressionConverter.ConvertO(body);
            return new ApiConnectionAction<CreateASingleEmploymentStatusRecordResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "payspaceip")]
        public IBodyWorkflowAction<GetACollectionOfAllEmploymentStatusesResponse> GetACollectionOfAllEmploymentStatuses(Expression<Func<int>> skip, Expression<Func<string>> count, Expression<Func<int>> companyId, Expression<Func<string>> customAuthHeader, Expression<Func<string>> customEnvironmentHeader, Expression<Func<string>> orderby = null, Expression<Func<int>> top = null, Expression<Func<string>> filter = null)
        {
            var apiCallPath = String.Format("/odata/v1.1/{0}/EmployeeEmploymentStatus/all", ExpressionConverter.ConvertWithUrlEncoding(companyId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (orderby != null)
                callPayload.Queries["$orderby"] = ExpressionConverter.Convert(orderby);
            if (top != null)
                callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
            callPayload.Queries["$skip"] = ExpressionConverter.Convert(skip);
            callPayload.Queries["$count"] = ExpressionConverter.Convert(count);
            if (filter != null)
                callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
            callPayload.Headers["CustomAuthHeader"] = ExpressionConverter.Convert(customAuthHeader);
            callPayload.Headers["CustomEnvironmentHeader"] = ExpressionConverter.Convert(customEnvironmentHeader);
            return new ApiConnectionAction<GetACollectionOfAllEmploymentStatusesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "payspaceip")]
        public IBodyWorkflowAction<GetACollectionOfPositionsResponse> GetACollectionOfPositions(Expression<Func<int>> skip, Expression<Func<string>> count, Expression<Func<string>> expand, Expression<Func<int>> companyId, Expression<Func<string>> customAuthHeader, Expression<Func<string>> customEnvironmentHeader, Expression<Func<int>> top = null, Expression<Func<string>> filter = null)
        {
            var apiCallPath = String.Format("/odata/v1.1/{0}/EmployeePosition", ExpressionConverter.ConvertWithUrlEncoding(companyId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (top != null)
                callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
            callPayload.Queries["$skip"] = ExpressionConverter.Convert(skip);
            callPayload.Queries["$count"] = ExpressionConverter.Convert(count);
            if (filter != null)
                callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
            callPayload.Queries["$expand"] = ExpressionConverter.Convert(expand);
            callPayload.Headers["CustomAuthHeader"] = ExpressionConverter.Convert(customAuthHeader);
            callPayload.Headers["CustomEnvironmentHeader"] = ExpressionConverter.Convert(customEnvironmentHeader);
            return new ApiConnectionAction<GetACollectionOfPositionsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "payspaceip")]
        public IBodyWorkflowAction<CreateASinglePositionRecordResponse> CreateASinglePositionRecord(Expression<Func<int>> companyId, Expression<Func<string>> customAuthHeader, Expression<Func<string>> customEnvironmentHeader, Expression<Func<string>> body = null)
        {
            var apiCallPath = String.Format("/odata/v1.1/{0}/EmployeePosition", ExpressionConverter.ConvertWithUrlEncoding(companyId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["CustomAuthHeader"] = ExpressionConverter.Convert(customAuthHeader);
            callPayload.Headers["CustomEnvironmentHeader"] = ExpressionConverter.Convert(customEnvironmentHeader);
            callPayload.Body = ExpressionConverter.ConvertO(body);
            return new ApiConnectionAction<CreateASinglePositionRecordResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "payspaceip")]
        public IBodyWorkflowAction<GetASinglePositionRecordResponse> GetASinglePositionRecord(Expression<Func<int>> companyId, Expression<Func<int>> employeePositionId, Expression<Func<string>> customAuthHeader, Expression<Func<string>> customEnvironmentHeader)
        {
            var apiCallPath = String.Format("/odata/v1.1/{0}/EmployeePosition({1})", ExpressionConverter.ConvertWithUrlEncoding(companyId, 1), ExpressionConverter.ConvertWithUrlEncoding(employeePositionId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["CustomAuthHeader"] = ExpressionConverter.Convert(customAuthHeader);
            callPayload.Headers["CustomEnvironmentHeader"] = ExpressionConverter.Convert(customEnvironmentHeader);
            return new ApiConnectionAction<GetASinglePositionRecordResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "payspaceip")]
        public IBodyWorkflowAction<JToken> UpdateASinglePositionRecord(Expression<Func<int>> employeePositionId, Expression<Func<int>> companyId, Expression<Func<string>> customAuthHeader, Expression<Func<string>> customEnvironmentHeader, Expression<Func<string>> body = null)
        {
            var apiCallPath = String.Format("/odata/v1.1/{0}/EmployeePosition({1})", ExpressionConverter.ConvertWithUrlEncoding(companyId, 1), ExpressionConverter.ConvertWithUrlEncoding(employeePositionId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["CustomAuthHeader"] = ExpressionConverter.Convert(customAuthHeader);
            callPayload.Headers["CustomEnvironmentHeader"] = ExpressionConverter.Convert(customEnvironmentHeader);
            callPayload.Body = ExpressionConverter.ConvertO(body);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "payspaceip")]
        public IBodyWorkflowAction<GetACollectionOfPositionsAsOfAnEffectiveDateResponse> GetACollectionOfPositionsAsOfAnEffectiveDate(Expression<Func<string>> orderby, Expression<Func<int>> skip, Expression<Func<string>> count, Expression<Func<string>> expand, Expression<Func<int>> companyId, Expression<Func<string>> effectivedate, Expression<Func<string>> customAuthHeader, Expression<Func<string>> customEnvironmentHeader, Expression<Func<int>> top = null)
        {
            var apiCallPath = String.Format("/odata/v1.1/{0}/EmployeePosition/effective/:{1}", ExpressionConverter.ConvertWithUrlEncoding(companyId, 1), ExpressionConverter.ConvertWithUrlEncoding(effectivedate, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["$orderby"] = ExpressionConverter.Convert(orderby);
            if (top != null)
                callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
            callPayload.Queries["$skip"] = ExpressionConverter.Convert(skip);
            callPayload.Queries["$count"] = ExpressionConverter.Convert(count);
            callPayload.Queries["$expand"] = ExpressionConverter.Convert(expand);
            callPayload.Headers["CustomAuthHeader"] = ExpressionConverter.Convert(customAuthHeader);
            callPayload.Headers["CustomEnvironmentHeader"] = ExpressionConverter.Convert(customEnvironmentHeader);
            return new ApiConnectionAction<GetACollectionOfPositionsAsOfAnEffectiveDateResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "payspaceip")]
        public IBodyWorkflowAction<GetACollectionOfEmployeeAttachmentRecordsResponse> GetACollectionOfEmployeeAttachmentRecords(Expression<Func<int>> skip, Expression<Func<string>> count, Expression<Func<int>> companyId, Expression<Func<string>> customAuthHeader, Expression<Func<string>> customEnvironmentHeader, Expression<Func<string>> orderby = null, Expression<Func<int>> top = null, Expression<Func<string>> filter = null)
        {
            var apiCallPath = String.Format("/odata/v1.1/{0}/EmployeeAttachment", ExpressionConverter.ConvertWithUrlEncoding(companyId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["$orderby"] = Convert.ToString("$attachment-field");
            if (orderby != null)
                callPayload.Queries["$orderby"] = ExpressionConverter.Convert(orderby);
            if (top != null)
                callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
            callPayload.Queries["$skip"] = ExpressionConverter.Convert(skip);
            callPayload.Queries["$count"] = ExpressionConverter.Convert(count);
            if (filter != null)
                callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
            callPayload.Headers["CustomAuthHeader"] = ExpressionConverter.Convert(customAuthHeader);
            callPayload.Headers["CustomEnvironmentHeader"] = ExpressionConverter.Convert(customEnvironmentHeader);
            return new ApiConnectionAction<GetACollectionOfEmployeeAttachmentRecordsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "payspaceip")]
        public IBodyWorkflowAction<CreateASingleEmployeeAttachmentRecordResponse> CreateASingleEmployeeAttachmentRecord(Expression<Func<int>> companyId, Expression<Func<string>> customAuthHeader, Expression<Func<string>> customEnvironmentHeader, Expression<Func<string>> body = null)
        {
            var apiCallPath = String.Format("/odata/v1.1/{0}/EmployeeAttachment", ExpressionConverter.ConvertWithUrlEncoding(companyId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["CustomAuthHeader"] = ExpressionConverter.Convert(customAuthHeader);
            callPayload.Headers["CustomEnvironmentHeader"] = ExpressionConverter.Convert(customEnvironmentHeader);
            callPayload.Body = ExpressionConverter.ConvertO(body);
            return new ApiConnectionAction<CreateASingleEmployeeAttachmentRecordResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "payspaceip")]
        public IBodyWorkflowAction<GetASingleEmployeeAttachmentRecordResponse> GetASingleEmployeeAttachmentRecord(Expression<Func<int>> companyId, Expression<Func<int>> attachmentId, Expression<Func<string>> customAuthHeader, Expression<Func<string>> customEnvironmentHeader)
        {
            var apiCallPath = String.Format("/odata/v1.1/{0}/EmployeeAttachment({1})", ExpressionConverter.ConvertWithUrlEncoding(companyId, 1), ExpressionConverter.ConvertWithUrlEncoding(attachmentId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["CustomAuthHeader"] = ExpressionConverter.Convert(customAuthHeader);
            callPayload.Headers["CustomEnvironmentHeader"] = ExpressionConverter.Convert(customEnvironmentHeader);
            return new ApiConnectionAction<GetASingleEmployeeAttachmentRecordResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "payspaceip")]
        public IBodyWorkflowAction<JToken> DeleteASingleEmployeeAttachmentRecord(Expression<Func<int>> companyId, Expression<Func<int>> attachmentId, Expression<Func<string>> customAuthHeader, Expression<Func<string>> customEnvironmentHeader)
        {
            var apiCallPath = String.Format("/odata/v1.1/{0}/EmployeeAttachment({1})", ExpressionConverter.ConvertWithUrlEncoding(companyId, 1), ExpressionConverter.ConvertWithUrlEncoding(attachmentId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["CustomAuthHeader"] = ExpressionConverter.Convert(customAuthHeader);
            callPayload.Headers["CustomEnvironmentHeader"] = ExpressionConverter.Convert(customEnvironmentHeader);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "payspaceip")]
        public IBodyWorkflowAction<JToken> UpdateASingleEmployeeAttachmentRecord(Expression<Func<int>> companyId, Expression<Func<int>> attachmentId, Expression<Func<string>> customAuthHeader, Expression<Func<string>> customEnvironmentHeader, Expression<Func<string>> body = null)
        {
            var apiCallPath = String.Format("/odata/v1.1/{0}/EmployeeAttachment({1})", ExpressionConverter.ConvertWithUrlEncoding(companyId, 1), ExpressionConverter.ConvertWithUrlEncoding(attachmentId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["CustomAuthHeader"] = ExpressionConverter.Convert(customAuthHeader);
            callPayload.Headers["CustomEnvironmentHeader"] = ExpressionConverter.Convert(customEnvironmentHeader);
            callPayload.Body = ExpressionConverter.ConvertO(body);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "payspaceip")]
        public IBodyWorkflowAction<GetACollectionOfBankDetailRecordsResponse> GetACollectionOfBankDetailRecords(Expression<Func<string>> orderby, Expression<Func<string>> skip, Expression<Func<string>> count, Expression<Func<int>> companyId, Expression<Func<string>> customAuthHeader, Expression<Func<string>> customEnvironmentHeader, Expression<Func<string>> top = null, Expression<Func<string>> filter = null)
        {
            var apiCallPath = String.Format("/odata/v1.1/{0}/EmployeeBankDetail", ExpressionConverter.ConvertWithUrlEncoding(companyId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["$orderby"] = ExpressionConverter.Convert(orderby);
            if (top != null)
                callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
            callPayload.Queries["$skip"] = ExpressionConverter.Convert(skip);
            callPayload.Queries["$count"] = ExpressionConverter.Convert(count);
            if (filter != null)
                callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
            callPayload.Headers["CustomAuthHeader"] = ExpressionConverter.Convert(customAuthHeader);
            callPayload.Headers["CustomEnvironmentHeader"] = ExpressionConverter.Convert(customEnvironmentHeader);
            return new ApiConnectionAction<GetACollectionOfBankDetailRecordsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "payspaceip")]
        public IBodyWorkflowAction<CreateASingleBankDetailRecordResponse> CreateASingleBankDetailRecord(Expression<Func<int>> companyId, Expression<Func<string>> customAuthHeader, Expression<Func<string>> customEnvironmentHeader, Expression<Func<string>> body = null)
        {
            var apiCallPath = String.Format("/odata/v1.1/{0}/EmployeeBankDetail", ExpressionConverter.ConvertWithUrlEncoding(companyId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["CustomAuthHeader"] = ExpressionConverter.Convert(customAuthHeader);
            callPayload.Headers["CustomEnvironmentHeader"] = ExpressionConverter.Convert(customEnvironmentHeader);
            callPayload.Body = ExpressionConverter.ConvertO(body);
            return new ApiConnectionAction<CreateASingleBankDetailRecordResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "payspaceip")]
        public IBodyWorkflowAction<GetASingleBankDetailRecordResponse> GetASingleBankDetailRecord(Expression<Func<int>> companyId, Expression<Func<int>> bankDetailId, Expression<Func<string>> customAuthHeader, Expression<Func<string>> customEnvironmentHeader)
        {
            var apiCallPath = String.Format("/odata/v1.1/{0}/EmployeeBankDetail({1})", ExpressionConverter.ConvertWithUrlEncoding(companyId, 1), ExpressionConverter.ConvertWithUrlEncoding(bankDetailId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["CustomAuthHeader"] = ExpressionConverter.Convert(customAuthHeader);
            callPayload.Headers["CustomEnvironmentHeader"] = ExpressionConverter.Convert(customEnvironmentHeader);
            return new ApiConnectionAction<GetASingleBankDetailRecordResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "payspaceip")]
        public IBodyWorkflowAction<JToken> DeleteASingleBankDetailRecord(Expression<Func<int>> companyId, Expression<Func<int>> bankDetailId, Expression<Func<string>> customAuthHeader, Expression<Func<string>> customEnvironmentHeader)
        {
            var apiCallPath = String.Format("/odata/v1.1/{0}/EmployeeBankDetail({1})", ExpressionConverter.ConvertWithUrlEncoding(companyId, 1), ExpressionConverter.ConvertWithUrlEncoding(bankDetailId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["CustomAuthHeader"] = ExpressionConverter.Convert(customAuthHeader);
            callPayload.Headers["CustomEnvironmentHeader"] = ExpressionConverter.Convert(customEnvironmentHeader);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "payspaceip")]
        public IBodyWorkflowAction<JToken> UpdateASingleBankDetailRecord(Expression<Func<int>> companyId, Expression<Func<int>> bankDetailId, Expression<Func<string>> customAuthHeader, Expression<Func<string>> customEnvironmentHeader, Expression<Func<string>> body = null)
        {
            var apiCallPath = String.Format("/odata/v1.1/{0}/EmployeeBankDetail({1})", ExpressionConverter.ConvertWithUrlEncoding(companyId, 1), ExpressionConverter.ConvertWithUrlEncoding(bankDetailId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["CustomAuthHeader"] = ExpressionConverter.Convert(customAuthHeader);
            callPayload.Headers["CustomEnvironmentHeader"] = ExpressionConverter.Convert(customEnvironmentHeader);
            callPayload.Body = ExpressionConverter.ConvertO(body);
            return new ApiConnectionAction<JToken>(callPayload);
        }
    }

    public class PayspaceipTriggers([ConnectionName] string connectionId)
    {
    }

    public class GetACollectionOfEmployeesResponse
    {
        [JsonProperty("@odata.context")]
        public string Context { get; set; }

        [JsonProperty("@odata.count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public GetACollectionOfEmployeesResponseValueTypeItem[] Value { get; set; }
    }

    public class GetACollectionOfEmployeesResponseValueTypeItem
    {
        public int EmployeeId { get; set; }
        public string EmployeeNumber { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PreferredName { get; set; }
        public string MaidenName { get; set; }
        public string MiddleName { get; set; }
        public string Initials { get; set; }
        public string Email { get; set; }
        public string Birthday { get; set; }
        public string HomeNumber { get; set; }
        public string WorkNumber { get; set; }
        public string CellNumber { get; set; }
        public string WorkExtension { get; set; }
        public string Language { get; set; }
        public string Gender { get; set; }
        public string MaritalStatus { get; set; }
        public string Race { get; set; }
        public string Nationality { get; set; }
        public string Citizenship { get; set; }
        public string DisabledType { get; set; }
        public bool ForeignNational { get; set; }
        public string DateCreated { get; set; }
        public string EmergencyContactName { get; set; }
        public string EmergencyContactNumber { get; set; }
        public string EmergencyContactAddress { get; set; }
        public bool IsRetired { get; set; }
        public string CustomFieldValue { get; set; }
        public string CustomFieldValue2 { get; set; }
        public string UifExemption { get; set; }
        public string SdlExemption { get; set; }
        public bool EtiExempt { get; set; }
        public string ImageDownloadUrl { get; set; }
        public GetACollectionOfEmployeesResponseValueTypeItemCustomFieldsTypeItem[] CustomFields { get; set; }
        public GetACollectionOfEmployeesResponseValueTypeItemAddressTypeItem[] Address { get; set; }
    }

    public class GetACollectionOfEmployeesResponseValueTypeItemCustomFieldsTypeItem
    {
        public string Code { get; set; }
        public string Label { get; set; }
        public string Value { get; set; }
    }

    public class GetACollectionOfEmployeesResponseValueTypeItemAddressTypeItem
    {
        public int AddressId { get; set; }
        public string AddressType { get; set; }
        public string EmployeeNumber { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string AddressLine3 { get; set; }
        public string AddressCode { get; set; }
        public string AddressCountry { get; set; }
        public string Province { get; set; }
        public string UnitNumber { get; set; }
        public string Complex { get; set; }
        public string StreetNumber { get; set; }
        public bool SameAsPhysical { get; set; }
        public bool IsCareofAddress { get; set; }
        public string CareOfIntermediary { get; set; }
        public string SpecialServices { get; set; }
    }

    public class CreateASingleEmployeeRecordResponse
    {
        [JsonProperty("@odata.context")]
        public string Context { get; set; }
        public int EmployeeId { get; set; }
        public string EmployeeNumber { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PreferredName { get; set; }
        public string MaidenName { get; set; }
        public string MiddleName { get; set; }
        public string Initials { get; set; }
        public string Email { get; set; }
        public string Birthday { get; set; }
        public string HomeNumber { get; set; }
        public string WorkNumber { get; set; }
        public string CellNumber { get; set; }
        public string WorkExtension { get; set; }
        public string Language { get; set; }
        public string Gender { get; set; }
        public string MaritalStatus { get; set; }
        public string Race { get; set; }
        public string Nationality { get; set; }
        public string Citizenship { get; set; }
        public string DisabledType { get; set; }
        public bool ForeignNational { get; set; }
        public string DateCreated { get; set; }
        public string EmergencyContactName { get; set; }
        public string EmergencyContactNumber { get; set; }
        public string EmergencyContactAddress { get; set; }
        public bool IsRetired { get; set; }
        public string CustomFieldValue { get; set; }
        public string CustomFieldValue2 { get; set; }
        public string UifExemption { get; set; }
        public string SdlExemption { get; set; }
        public bool EtiExempt { get; set; }
        public string ImageDownloadUrl { get; set; }
        public CreateASingleEmployeeRecordResponseCustomFieldsTypeItem[] CustomFields { get; set; }
        public CreateASingleEmployeeRecordResponseAddressTypeItem[] Address { get; set; }
    }

    public class CreateASingleEmployeeRecordResponseCustomFieldsTypeItem
    {
        public string Code { get; set; }
        public string Label { get; set; }
        public string Value { get; set; }
    }

    public class CreateASingleEmployeeRecordResponseAddressTypeItem
    {
        public int AddressId { get; set; }
        public string AddressType { get; set; }
        public string EmployeeNumber { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string AddressLine3 { get; set; }
        public string AddressCode { get; set; }
        public string AddressCountry { get; set; }
        public string Province { get; set; }
        public string UnitNumber { get; set; }
        public string Complex { get; set; }
        public string StreetNumber { get; set; }
        public bool SameAsPhysical { get; set; }
        public bool IsCareofAddress { get; set; }
        public string CareOfIntermediary { get; set; }
        public string SpecialServices { get; set; }
    }

    public class GetACollectionOfEmployeesAsOfAnEffectiveDateResponse
    {
        [JsonProperty("@odata.context")]
        public string Context { get; set; }

        [JsonProperty("@odata.count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public GetACollectionOfEmployeesAsOfAnEffectiveDateResponseValueTypeItem[] Value { get; set; }
    }

    public class GetACollectionOfEmployeesAsOfAnEffectiveDateResponseValueTypeItem
    {
        public int EmployeeId { get; set; }
        public string EmployeeNumber { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PreferredName { get; set; }
        public string MaidenName { get; set; }
        public string MiddleName { get; set; }
        public string Initials { get; set; }
        public string Email { get; set; }
        public string Birthday { get; set; }
        public string HomeNumber { get; set; }
        public string WorkNumber { get; set; }
        public string CellNumber { get; set; }
        public string WorkExtension { get; set; }
        public string Language { get; set; }
        public string Gender { get; set; }
        public string MaritalStatus { get; set; }
        public string Race { get; set; }
        public string Nationality { get; set; }
        public string Citizenship { get; set; }
        public string TaxRefNumber { get; set; }
        public bool Disabled { get; set; }
        public string DisabledType { get; set; }
        public string EthnicGroup { get; set; }
        public bool ForeignNational { get; set; }
        public string GroupDate { get; set; }
        public string DateCreated { get; set; }
        public string EmergencyContactName { get; set; }
        public string EmergencyContactNumber { get; set; }
        public string EmergencyContactAddress { get; set; }
        public bool IsMockEmployee { get; set; }
        public bool IsRetired { get; set; }
        public string CustomFieldValue { get; set; }
        public string CustomFieldValue2 { get; set; }
        public string UifExemption { get; set; }
        public string SdlExemption { get; set; }
        public bool EtiExempt { get; set; }
        public string ImageDownloadUrl { get; set; }
        public GetACollectionOfEmployeesAsOfAnEffectiveDateResponseValueTypeItemCustomFieldsTypeItem[] CustomFields { get; set; }
        public GetACollectionOfEmployeesAsOfAnEffectiveDateResponseValueTypeItemAddressTypeItem[] Address { get; set; }
    }

    public class GetACollectionOfEmployeesAsOfAnEffectiveDateResponseValueTypeItemCustomFieldsTypeItem
    {
        public string Code { get; set; }
        public string Label { get; set; }
        public string Value { get; set; }
    }

    public class GetACollectionOfEmployeesAsOfAnEffectiveDateResponseValueTypeItemAddressTypeItem
    {
        public int AddressId { get; set; }
        public string AddressType { get; set; }
        public string EmployeeNumber { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string AddressLine3 { get; set; }
        public string AddressCode { get; set; }
        public string AddressCountry { get; set; }
        public string Province { get; set; }
        public string UnitNumber { get; set; }
        public string Complex { get; set; }
        public string StreetNumber { get; set; }
        public bool SameAsPhysical { get; set; }
        public bool IsCareofAddress { get; set; }
        public string CareOfIntermediary { get; set; }
        public string SpecialServices { get; set; }
    }

    public class GetASingleEmployeeRecordResponse
    {
        [JsonProperty("@odata.context")]
        public string Context { get; set; }
        public int EmployeeId { get; set; }
        public string EmployeeNumber { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PreferredName { get; set; }
        public string MaidenName { get; set; }
        public string MiddleName { get; set; }
        public string Initials { get; set; }
        public string Email { get; set; }
        public string Birthday { get; set; }
        public string HomeNumber { get; set; }
        public string WorkNumber { get; set; }
        public string CellNumber { get; set; }
        public string WorkExtension { get; set; }
        public string Language { get; set; }
        public string Gender { get; set; }
        public string MaritalStatus { get; set; }
        public string Race { get; set; }
        public string Nationality { get; set; }
        public string Citizenship { get; set; }
        public string DisabledType { get; set; }
        public bool ForeignNational { get; set; }
        public string DateCreated { get; set; }
        public string EmergencyContactName { get; set; }
        public string EmergencyContactNumber { get; set; }
        public string EmergencyContactAddress { get; set; }
        public bool IsRetired { get; set; }
        public string CustomFieldValue { get; set; }
        public string CustomFieldValue2 { get; set; }
        public string UifExemption { get; set; }
        public string SdlExemption { get; set; }
        public bool EtiExempt { get; set; }
        public string ImageDownloadUrl { get; set; }
        public GetASingleEmployeeRecordResponseCustomFieldsTypeItem[] CustomFields { get; set; }
        public GetASingleEmployeeRecordResponseAddressTypeItem[] Address { get; set; }
    }

    public class GetASingleEmployeeRecordResponseCustomFieldsTypeItem
    {
        public string Code { get; set; }
        public string Label { get; set; }
        public string Value { get; set; }
    }

    public class GetASingleEmployeeRecordResponseAddressTypeItem
    {
        public int AddressId { get; set; }
        public string AddressType { get; set; }
        public string EmployeeNumber { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string AddressLine3 { get; set; }
        public string AddressCode { get; set; }
        public string AddressCountry { get; set; }
        public string Province { get; set; }
        public string UnitNumber { get; set; }
        public string Complex { get; set; }
        public string StreetNumber { get; set; }
        public bool SameAsPhysical { get; set; }
        public bool IsCareofAddress { get; set; }
        public string CareOfIntermediary { get; set; }
        public string SpecialServices { get; set; }
    }

    public class UpdateASingleEmployeeRecordResponse
    {
        [JsonProperty("@odata.context")]
        public string Context { get; set; }
        public bool Success { get; set; }
    }

    public class DownloadEmployeePhotoResponse
    {
        [JsonProperty("@odata.context")]
        public string Context { get; set; }
        public bool Success { get; set; }
    }

    public class UploadEmployeePhotoResponse
    {
        [JsonProperty("@odata.context")]
        public string Context { get; set; }
        public bool Success { get; set; }
    }

    public class GetACollectionOfEmploymentStatusesResponse
    {
        [JsonProperty("@odata.context")]
        public string Context { get; set; }

        [JsonProperty("@odata.count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public GetACollectionOfEmploymentStatusesResponseValueTypeItem[] Value { get; set; }
    }

    public class GetACollectionOfEmploymentStatusesResponseValueTypeItem
    {
        public int EmploymentStatusId { get; set; }
        public string EmployeeNumber { get; set; }
        public string GroupJoinDate { get; set; }
        public string EmploymentDate { get; set; }
        public string TerminationDate { get; set; }
        public string TerminationReason { get; set; }
        public string TaxStatus { get; set; }
        public string TaxReferenceNumber { get; set; }
        public string NatureOfPerson { get; set; }
        public int TaxOffice { get; set; }
        public string TaxDirectiveNumber { get; set; }
        public int IT3AReason { get; set; }
        public string EmploymentAction { get; set; }
        public string TerminationCompanyRun { get; set; }
        public string IdentityType { get; set; }
        public string IdNumber { get; set; }
        public string PassportNumber { get; set; }
        public string PercentageAmount { get; set; }
        public int Amount { get; set; }
        public int Percentage { get; set; }
        public int DeemedMonthlyRemuneration { get; set; }
        public bool Deemed75Indicator { get; set; }
        public bool DeemedRecoveryMonthly { get; set; }
        public bool EncashLeave { get; set; }
        public bool Irp30 { get; set; }
        public bool FinalizeIssueTaxCert { get; set; }
        public bool PassportCountry { get; set; }
        public string PassportIssued { get; set; }
        public string PassportExpiry { get; set; }
        public string PermitIssued { get; set; }
        public string PermitExpiry { get; set; }
        public string AdditionalDate { get; set; }
        public string EmploymentCaptureDate { get; set; }
        public string TerminationCaptureDate { get; set; }
        public bool TempWorker { get; set; }
        public string AdditionalDate1 { get; set; }
        public bool NotReEmployable { get; set; }
        public string ReferenceNumber { get; set; }
        public int OldEmployeeId { get; set; }
        public GetACollectionOfEmploymentStatusesResponseValueTypeItemCustomFieldsTypeItem[] CustomFields { get; set; }
    }

    public class GetACollectionOfEmploymentStatusesResponseValueTypeItemCustomFieldsTypeItem
    {
        public string Code { get; set; }
        public string Label { get; set; }
        public string Value { get; set; }
    }

    public class CreateASingleEmploymentStatusRecordResponse
    {
        [JsonProperty("@odata.context")]
        public string Context { get; set; }
        public int EmploymentStatusId { get; set; }
        public string EmployeeNumber { get; set; }
        public string GroupJoinDate { get; set; }
        public string EmploymentDate { get; set; }
        public string TerminationDate { get; set; }
        public string TerminationReason { get; set; }
        public string TaxStatus { get; set; }
        public string TaxReferenceNumber { get; set; }
        public string NatureOfPerson { get; set; }
        public int TaxOffice { get; set; }
        public string TaxDirectiveNumber { get; set; }
        public int IT3AReason { get; set; }
        public string EmploymentAction { get; set; }
        public string TerminationCompanyRun { get; set; }
        public string IdentityType { get; set; }
        public string IdNumber { get; set; }
        public string PassportNumber { get; set; }
        public string PercentageAmount { get; set; }
        public int Amount { get; set; }
        public int Percentage { get; set; }
        public int DeemedMonthlyRemuneration { get; set; }
        public bool Deemed75Indicator { get; set; }
        public bool DeemedRecoveryMonthly { get; set; }
        public bool EncashLeave { get; set; }
        public bool Irp30 { get; set; }
        public bool FinalizeIssueTaxCert { get; set; }
        public bool PassportCountry { get; set; }
        public string PassportIssued { get; set; }
        public string PassportExpiry { get; set; }
        public string PermitIssued { get; set; }
        public string PermitExpiry { get; set; }
        public string AdditionalDate { get; set; }
        public string EmploymentCaptureDate { get; set; }
        public string TerminationCaptureDate { get; set; }
        public bool TempWorker { get; set; }
        public string AdditionalDate1 { get; set; }
        public bool NotReEmployable { get; set; }
        public string ReferenceNumber { get; set; }
        public int OldEmployeeId { get; set; }
    }

    public class GetACollectionOfAllEmploymentStatusesResponse
    {
        [JsonProperty("@odata.context")]
        public string Context { get; set; }

        [JsonProperty("@odata.count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public GetACollectionOfAllEmploymentStatusesResponseValueTypeItem[] Value { get; set; }
    }

    public class GetACollectionOfAllEmploymentStatusesResponseValueTypeItem
    {
        public int EmploymentStatusId { get; set; }
        public string EmployeeNumber { get; set; }
        public string GroupJoinDate { get; set; }
        public string EmploymentDate { get; set; }
        public string TerminationDate { get; set; }
        public string TerminationReason { get; set; }
        public string TaxStatus { get; set; }
        public string TaxReferenceNumber { get; set; }
        public string NatureOfPerson { get; set; }
        public int TaxOffice { get; set; }
        public string TaxDirectiveNumber { get; set; }
        public int IT3AReason { get; set; }
        public string EmploymentAction { get; set; }
        public string TerminationCompanyRun { get; set; }
        public string IdentityType { get; set; }
        public string IdNumber { get; set; }
        public string PassportNumber { get; set; }
        public string PercentageAmount { get; set; }
        public int Amount { get; set; }
        public int Percentage { get; set; }
        public int DeemedMonthlyRemuneration { get; set; }
        public bool Deemed75Indicator { get; set; }
        public bool DeemedRecoveryMonthly { get; set; }
        public bool EncashLeave { get; set; }
        public bool Irp30 { get; set; }
        public bool FinalizeIssueTaxCert { get; set; }
        public bool PassportCountry { get; set; }
        public string PassportIssued { get; set; }
        public string PassportExpiry { get; set; }
        public string PermitIssued { get; set; }
        public string PermitExpiry { get; set; }
        public string AdditionalDate { get; set; }
        public string EmploymentCaptureDate { get; set; }
        public string TerminationCaptureDate { get; set; }
        public bool TempWorker { get; set; }
        public string AdditionalDate1 { get; set; }
        public bool NotReEmployable { get; set; }
        public string ReferenceNumber { get; set; }
        public int OldEmployeeId { get; set; }
        public GetACollectionOfAllEmploymentStatusesResponseValueTypeItemCustomFieldsTypeItem[] CustomFields { get; set; }
    }

    public class GetACollectionOfAllEmploymentStatusesResponseValueTypeItemCustomFieldsTypeItem
    {
        public string Code { get; set; }
        public string Label { get; set; }
        public string Value { get; set; }
    }

    public class GetACollectionOfPositionsResponse
    {
        [JsonProperty("@odata.context")]
        public string Context { get; set; }

        [JsonProperty("@odata.count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public GetACollectionOfPositionsResponseValueTypeItem[] Value { get; set; }
    }

    public class GetACollectionOfPositionsResponseValueTypeItem
    {
        public int EmployeePositionId { get; set; }
        public string EmployeeNumber { get; set; }
        public string FullName { get; set; }
        public string EffectiveDate { get; set; }
        public string OrganizationPosition { get; set; }
        public int OrganizationPositionId { get; set; }
        public string OrganizationPositionWithCode { get; set; }
        public string PositionType { get; set; }
        public string Grade { get; set; }
        public string OccupationalLevel { get; set; }
        public string DirectlyReportsPositionOverride { get; set; }
        public string DirectlyReportsPosition { get; set; }
        public string OrganizationGroup { get; set; }
        public string OrganizationGroupDescription { get; set; }
        public GetACollectionOfPositionsResponseValueTypeItemOrganizationGroupsTypeItem[] OrganizationGroups { get; set; }
        public string OrganizationRegion { get; set; }
        public string PayPoint { get; set; }
        public string DirectlyReportsEmployee { get; set; }
        public string DirectlyReportsEmployeeNumber { get; set; }
        public string EmploymentCategory { get; set; }
        public string EmploymentSubCategory { get; set; }
        public string Administrator { get; set; }
        public string AdministratorEmployeeNumber { get; set; }
        public string WorkflowRole { get; set; }
        public string GeneralLedger { get; set; }
        public string TradeUnion { get; set; }
        public bool IsPromotion { get; set; }
        public string Roster { get; set; }
        public string Job { get; set; }
        public string Comments { get; set; }
        public string AltPositionName { get; set; }
        public string DateAdded { get; set; }
        public string PositionEffectiveDate { get; set; }
        public string CustomTradeUnion { get; set; }
        public GetACollectionOfPositionsResponseValueTypeItemCustomFieldsTypeItem[] CustomFields { get; set; }
    }

    public class GetACollectionOfPositionsResponseValueTypeItemOrganizationGroupsTypeItem
    {
        public int OrganizationUnitId { get; set; }
        public int ParentOrganizationUnitId { get; set; }
        public string UploadCode { get; set; }
        public string Description { get; set; }
        public bool CostCentre { get; set; }
        public string OrganizationLevel { get; set; }
        public string GroupGlKey { get; set; }
        public int Budget { get; set; }
        public string Reference { get; set; }
        public string ManagerEmployeeNumber { get; set; }
        public string InactiveDate { get; set; }
    }

    public class GetACollectionOfPositionsResponseValueTypeItemCustomFieldsTypeItem
    {
        public string Code { get; set; }
        public string Label { get; set; }
        public string Value { get; set; }
    }

    public class CreateASinglePositionRecordResponse
    {
        [JsonProperty("@odata.context")]
        public string Context { get; set; }
        public int EmployeePositionId { get; set; }
        public string EmployeeNumber { get; set; }
        public string EffectiveDate { get; set; }
        public string OrganizationPosition { get; set; }
        public string OrganizationPositionWithCode { get; set; }
        public string PositionType { get; set; }
        public string Grade { get; set; }
        public string OccupationalLevel { get; set; }
        public string DirectlyReportsPositionOverride { get; set; }
        public string DirectlyReportsPosition { get; set; }
        public string OrganizationGroup { get; set; }
        public JToken[] OrganizationGroups { get; set; }
        public string OrganizationRegion { get; set; }
        public string PayPoint { get; set; }
        public string DirectlyReportsEmployee { get; set; }
        public string DirectlyReportsEmployeeNumber { get; set; }
        public string EmploymentCategory { get; set; }
        public string EmploymentSubCategory { get; set; }
        public string Administrator { get; set; }
        public string AdministratorEmployeeNumber { get; set; }
        public string WorkflowRole { get; set; }
        public string GeneralLedger { get; set; }
        public string TradeUnion { get; set; }
        public bool IsPromotion { get; set; }
        public string Roster { get; set; }
        public string Job { get; set; }
        public string Comments { get; set; }
        public string AltPositionName { get; set; }
        public string DateAdded { get; set; }
        public string PositionEffectiveDate { get; set; }
        public string CustomTradeUnion { get; set; }
        public CreateASinglePositionRecordResponseCustomFieldsTypeItem[] CustomFields { get; set; }
    }

    public class CreateASinglePositionRecordResponseCustomFieldsTypeItem
    {
        public string Code { get; set; }
        public string Label { get; set; }
        public string Value { get; set; }
    }

    public class GetASinglePositionRecordResponse
    {
        [JsonProperty("@odata.context")]
        public string Context { get; set; }

        [JsonProperty("@odata.count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public GetASinglePositionRecordResponseValueTypeItem[] Value { get; set; }
    }

    public class GetASinglePositionRecordResponseValueTypeItem
    {
        public int EmployeePositionId { get; set; }
        public string EmployeeNumber { get; set; }
        public string FullName { get; set; }
        public string EffectiveDate { get; set; }
        public string OrganizationPosition { get; set; }
        public int OrganizationPositionId { get; set; }
        public string OrganizationPositionWithCode { get; set; }
        public string PositionType { get; set; }
        public string Grade { get; set; }
        public string OccupationalLevel { get; set; }
        public string DirectlyReportsPositionOverride { get; set; }
        public string DirectlyReportsPosition { get; set; }
        public string OrganizationGroup { get; set; }
        public string OrganizationGroupDescription { get; set; }
        public GetASinglePositionRecordResponseValueTypeItemOrganizationGroupsTypeItem[] OrganizationGroups { get; set; }
        public string OrganizationRegion { get; set; }
        public string PayPoint { get; set; }
        public string DirectlyReportsEmployee { get; set; }
        public string DirectlyReportsEmployeeNumber { get; set; }
        public string EmploymentCategory { get; set; }
        public string EmploymentSubCategory { get; set; }
        public string Administrator { get; set; }
        public string AdministratorEmployeeNumber { get; set; }
        public string WorkflowRole { get; set; }
        public string GeneralLedger { get; set; }
        public string TradeUnion { get; set; }
        public bool IsPromotion { get; set; }
        public string Roster { get; set; }
        public string Job { get; set; }
        public string Comments { get; set; }
        public string AltPositionName { get; set; }
        public string DateAdded { get; set; }
        public string PositionEffectiveDate { get; set; }
        public string CustomTradeUnion { get; set; }
        public GetASinglePositionRecordResponseValueTypeItemCustomFieldsTypeItem[] CustomFields { get; set; }
    }

    public class GetASinglePositionRecordResponseValueTypeItemOrganizationGroupsTypeItem
    {
        public int OrganizationUnitId { get; set; }
        public int ParentOrganizationUnitId { get; set; }
        public string UploadCode { get; set; }
        public string Description { get; set; }
        public bool CostCentre { get; set; }
        public string OrganizationLevel { get; set; }
        public string GroupGlKey { get; set; }
        public int Budget { get; set; }
        public string Reference { get; set; }
        public string ManagerEmployeeNumber { get; set; }
        public string InactiveDate { get; set; }
    }

    public class GetASinglePositionRecordResponseValueTypeItemCustomFieldsTypeItem
    {
        public string Code { get; set; }
        public string Label { get; set; }
        public string Value { get; set; }
    }

    public class GetACollectionOfPositionsAsOfAnEffectiveDateResponse
    {
        [JsonProperty("@odata.context")]
        public string Context { get; set; }

        [JsonProperty("@odata.count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public GetACollectionOfPositionsAsOfAnEffectiveDateResponseValueTypeItem[] Value { get; set; }
    }

    public class GetACollectionOfPositionsAsOfAnEffectiveDateResponseValueTypeItem
    {
        public int EmployeePositionId { get; set; }
        public string EmployeeNumber { get; set; }
        public string FullName { get; set; }
        public string EffectiveDate { get; set; }
        public string OrganizationPosition { get; set; }
        public int OrganizationPositionId { get; set; }
        public string OrganizationPositionWithCode { get; set; }
        public string PositionType { get; set; }
        public string Grade { get; set; }
        public string OccupationalLevel { get; set; }
        public string DirectlyReportsPositionOverride { get; set; }
        public string DirectlyReportsPosition { get; set; }
        public string OrganizationGroup { get; set; }
        public string OrganizationGroupDescription { get; set; }
        public GetACollectionOfPositionsAsOfAnEffectiveDateResponseValueTypeItemOrganizationGroupsTypeItem[] OrganizationGroups { get; set; }
        public string OrganizationRegion { get; set; }
        public string PayPoint { get; set; }
        public string DirectlyReportsEmployee { get; set; }
        public string DirectlyReportsEmployeeNumber { get; set; }
        public string EmploymentCategory { get; set; }
        public string EmploymentSubCategory { get; set; }
        public string Administrator { get; set; }
        public string AdministratorEmployeeNumber { get; set; }
        public string WorkflowRole { get; set; }
        public string GeneralLedger { get; set; }
        public string TradeUnion { get; set; }
        public bool IsPromotion { get; set; }
        public string Roster { get; set; }
        public string Job { get; set; }
        public string Comments { get; set; }
        public string AltPositionName { get; set; }
        public string DateAdded { get; set; }
        public string PositionEffectiveDate { get; set; }
        public string CustomTradeUnion { get; set; }
        public GetACollectionOfPositionsAsOfAnEffectiveDateResponseValueTypeItemCustomFieldsTypeItem[] CustomFields { get; set; }
    }

    public class GetACollectionOfPositionsAsOfAnEffectiveDateResponseValueTypeItemOrganizationGroupsTypeItem
    {
        public int OrganizationUnitId { get; set; }
        public int ParentOrganizationUnitId { get; set; }
        public string UploadCode { get; set; }
        public string Description { get; set; }
        public bool CostCentre { get; set; }
        public string OrganizationLevel { get; set; }
        public string GroupGlKey { get; set; }
        public int Budget { get; set; }
        public string Reference { get; set; }
        public string ManagerEmployeeNumber { get; set; }
        public string InactiveDate { get; set; }
    }

    public class GetACollectionOfPositionsAsOfAnEffectiveDateResponseValueTypeItemCustomFieldsTypeItem
    {
        public string Code { get; set; }
        public string Label { get; set; }
        public string Value { get; set; }
    }

    public class GetACollectionOfEmployeeAttachmentRecordsResponse
    {
        [JsonProperty("@odata.context")]
        public string Context { get; set; }

        [JsonProperty("@odata.count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public GetACollectionOfEmployeeAttachmentRecordsResponseValueTypeItem[] Value { get; set; }
    }

    public class GetACollectionOfEmployeeAttachmentRecordsResponseValueTypeItem
    {
        public int AttachmentId { get; set; }
        public string EmployeeNumber { get; set; }
        public string Classification { get; set; }
        public string AttachmentDescription { get; set; }
        public string AttachmentName { get; set; }
        public string AttachmentUrl { get; set; }
        public string Attachment { get; set; }
        public GetACollectionOfEmployeeAttachmentRecordsResponseValueTypeItemCustomFieldsTypeItem[] CustomFields { get; set; }
    }

    public class GetACollectionOfEmployeeAttachmentRecordsResponseValueTypeItemCustomFieldsTypeItem
    {
        public string Code { get; set; }
        public string Label { get; set; }
        public string Value { get; set; }
    }

    public class CreateASingleEmployeeAttachmentRecordResponse
    {
        [JsonProperty("@odata.context")]
        public string Context { get; set; }
        public int AttachmentId { get; set; }
        public string EmployeeNumber { get; set; }
        public string Classification { get; set; }
        public string AttachmentDescription { get; set; }
        public string AttachmentName { get; set; }
        public string AttachmentUrl { get; set; }
        public string Attachment { get; set; }
        public CreateASingleEmployeeAttachmentRecordResponseCustomFieldsTypeItem[] CustomFields { get; set; }
    }

    public class CreateASingleEmployeeAttachmentRecordResponseCustomFieldsTypeItem
    {
        public string Code { get; set; }
        public string Label { get; set; }
        public string Value { get; set; }
    }

    public class GetASingleEmployeeAttachmentRecordResponse
    {
        [JsonProperty("@odata.context")]
        public string Context { get; set; }
        public int AttachmentId { get; set; }
        public string EmployeeNumber { get; set; }
        public string Classification { get; set; }
        public string AttachmentDescription { get; set; }
        public string AttachmentName { get; set; }
        public string AttachmentUrl { get; set; }
        public string Attachment { get; set; }
        public GetASingleEmployeeAttachmentRecordResponseCustomFieldsTypeItem[] CustomFields { get; set; }
    }

    public class GetASingleEmployeeAttachmentRecordResponseCustomFieldsTypeItem
    {
        public string Code { get; set; }
        public string Label { get; set; }
        public string Value { get; set; }
    }

    public class GetACollectionOfBankDetailRecordsResponse
    {
        [JsonProperty("@odata.context")]
        public string Context { get; set; }

        [JsonProperty("@odata.count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public GetACollectionOfBankDetailRecordsResponseValueTypeItem[] Value { get; set; }
    }

    public class GetACollectionOfBankDetailRecordsResponseValueTypeItem
    {
        public int BankDetailId { get; set; }
        public string EmployeeNumber { get; set; }
        public string PaymentMethod { get; set; }
        public string SplitType { get; set; }
        public string BankAccountOwner { get; set; }
        public string BankAccountOwnerName { get; set; }
        public string AccountType { get; set; }
        public string BankName { get; set; }
        public string BankBranchNo { get; set; }
        public string BankAccountNo { get; set; }
        public string Reference { get; set; }
        public bool IsMainAccount { get; set; }
        public int Amount { get; set; }
        public string Comments { get; set; }
        public string SwiftCode { get; set; }
        public string RoutingCode { get; set; }
        public int ComponentId { get; set; }
    }

    public class CreateASingleBankDetailRecordResponse
    {
        [JsonProperty("@odata.context")]
        public string Context { get; set; }
        public int BankDetailId { get; set; }
        public string EmployeeNumber { get; set; }
        public string PaymentMethod { get; set; }
        public string SplitType { get; set; }
        public string BankAccountOwner { get; set; }
        public string BankAccountOwnerName { get; set; }
        public string AccountType { get; set; }
        public string BankName { get; set; }
        public string BankBranchNo { get; set; }
        public string BankAccountNo { get; set; }
        public string Reference { get; set; }
        public bool IsMainAccount { get; set; }
        public int Amount { get; set; }
        public string Comments { get; set; }
        public string SwiftCode { get; set; }
        public string RoutingCode { get; set; }
        public int ComponentId { get; set; }
    }

    public class GetASingleBankDetailRecordResponse
    {
        [JsonProperty("@odata.context")]
        public string Context { get; set; }
        public int BankDetailId { get; set; }
        public string EmployeeNumber { get; set; }
        public string PaymentMethod { get; set; }
        public string SplitType { get; set; }
        public string BankAccountOwner { get; set; }
        public string BankAccountOwnerName { get; set; }
        public string AccountType { get; set; }
        public string BankName { get; set; }
        public string BankBranchNo { get; set; }
        public string BankAccountNo { get; set; }
        public string Reference { get; set; }
        public bool IsMainAccount { get; set; }
        public int Amount { get; set; }
        public string Comments { get; set; }
        public string SwiftCode { get; set; }
        public string RoutingCode { get; set; }
        public int ComponentId { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Payspaceip;

    public partial class WorkflowManagedActions
    {
        public PayspaceipActions Payspaceip(string connectionId) => new PayspaceipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public PayspaceipTriggers Payspaceip(string connectionId) => new PayspaceipTriggers(connectionId);
    }
}