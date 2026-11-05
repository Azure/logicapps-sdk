//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Adobeacrobatsignsand
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AdobeacrobatsignsandActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "adobeacrobatsignsand")]
        public IBodyWorkflowAction<AgreementCreationResponseV6, ApiConnectionActionConfiguration> CreateAgreementByFileStream(Expression<Func<CreateAgreementByFileStreamInput>> agreementCreationInfoIdFileStream, Expression<Func<string>> xApiUser = null)
        {
            var __workflow_agreementCreationInfoIdFileStream = WorkflowExpression.Compile(agreementCreationInfoIdFileStream, nameof(agreementCreationInfoIdFileStream), required: true);
            var __workflow_xApiUser = WorkflowExpression.Compile(xApiUser, nameof(xApiUser), required: false);
            return new DeferredBodyAction<AgreementCreationResponseV6, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v6/agreementsByFileStream";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-adobesign-operation-name"] = Convert.ToString("CreateAgreementByFileStream");
                if (__workflow_xApiUser != null)
                    callPayload.Headers["x-api-user"] = ExpressionConverter.Convert(__workflow_xApiUser);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_agreementCreationInfoIdFileStream);
                return new ApiConnectionAction<AgreementCreationResponseV6>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "adobeacrobatsignsand")]
        public IBodyWorkflowAction<AgreementCreationResponseV6, ApiConnectionActionConfiguration> CreateAgreementFromWorkflow(Expression<Func<string>> xApiUser, Expression<Func<string>> groupId, Expression<Func<string>> workflowIdParam, Expression<Func<object>> agreementWorkflowSchema)
        {
            var __workflow_xApiUser = WorkflowExpression.Compile(xApiUser, nameof(xApiUser), required: true);
            var __workflow_groupId = WorkflowExpression.Compile(groupId, nameof(groupId), required: true);
            var __workflow_workflowIdParam = WorkflowExpression.Compile(workflowIdParam, nameof(workflowIdParam), required: true);
            var __workflow_agreementWorkflowSchema = WorkflowExpression.Compile(agreementWorkflowSchema, nameof(agreementWorkflowSchema), required: true);
            return new DeferredBodyAction<AgreementCreationResponseV6, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/createagreementfromworkflow_custom/v6/agreements";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["groupId"] = ExpressionConverter.Convert(__workflow_groupId);
                callPayload.Queries["workflowIdParam"] = ExpressionConverter.Convert(__workflow_workflowIdParam);
                callPayload.Headers["x-adobesign-operation-name"] = Convert.ToString("CreateAgreementFromWorkflow");
                callPayload.Headers["x-api-user"] = ExpressionConverter.Convert(__workflow_xApiUser);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_agreementWorkflowSchema);
                return new ApiConnectionAction<AgreementCreationResponseV6>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "adobeacrobatsignsand")]
        public IWorkflowAction<ApiConnectionActionConfiguration> CancelAgreement(Expression<Func<string>> agreementId, Expression<Func<CancelAgreementInput>> cancelAgreement, Expression<Func<string>> xApiUser = null)
        {
            var __workflow_agreementId = WorkflowExpression.Compile(agreementId, nameof(agreementId), required: true);
            var __workflow_cancelAgreement = WorkflowExpression.Compile(cancelAgreement, nameof(cancelAgreement), required: true);
            var __workflow_xApiUser = WorkflowExpression.Compile(xApiUser, nameof(xApiUser), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v6/agreements/{0}/state", __workflow_agreementId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-adobesign-operation-name"] = Convert.ToString("CancelAgreement");
                if (__workflow_xApiUser != null)
                    callPayload.Headers["x-api-user"] = ExpressionConverter.Convert(__workflow_xApiUser);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_cancelAgreement);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "adobeacrobatsignsand")]
        public IBodyWorkflowAction<SigningUrlResponse, ApiConnectionActionConfiguration> GetSigningUrls(Expression<Func<string>> agreementId, Expression<Func<string>> xApiUser = null)
        {
            var __workflow_agreementId = WorkflowExpression.Compile(agreementId, nameof(agreementId), required: true);
            var __workflow_xApiUser = WorkflowExpression.Compile(xApiUser, nameof(xApiUser), required: false);
            return new DeferredBodyAction<SigningUrlResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v6/agreements/{0}/signingUrls", __workflow_agreementId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-adobesign-operation-name"] = Convert.ToString("GetSigningUrls");
                if (__workflow_xApiUser != null)
                    callPayload.Headers["x-api-user"] = ExpressionConverter.Convert(__workflow_xApiUser);
                return new ApiConnectionAction<SigningUrlResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "adobeacrobatsignsand")]
        public IBodyWorkflowAction<UserWidgetListV6, ApiConnectionActionConfiguration> GetAllWebForms(Expression<Func<string>> cursor = null, Expression<Func<int>> pageSize = null, Expression<Func<string>> xApiUser = null, Expression<Func<string>> groupId = null)
        {
            var __workflow_cursor = WorkflowExpression.Compile(cursor, nameof(cursor), required: false);
            var __workflow_pageSize = WorkflowExpression.Compile(pageSize, nameof(pageSize), required: false);
            var __workflow_xApiUser = WorkflowExpression.Compile(xApiUser, nameof(xApiUser), required: false);
            var __workflow_groupId = WorkflowExpression.Compile(groupId, nameof(groupId), required: false);
            return new DeferredBodyAction<UserWidgetListV6, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v6/widgets";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_cursor != null)
                    callPayload.Queries["cursor"] = ExpressionConverter.Convert(__workflow_cursor);
                if (__workflow_pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(__workflow_pageSize);
                if (__workflow_groupId != null)
                    callPayload.Queries["groupId"] = ExpressionConverter.Convert(__workflow_groupId);
                callPayload.Headers["x-adobesign-operation-name"] = Convert.ToString("GetAllWebForms");
                if (__workflow_xApiUser != null)
                    callPayload.Headers["x-api-user"] = ExpressionConverter.Convert(__workflow_xApiUser);
                return new ApiConnectionAction<UserWidgetListV6>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "adobeacrobatsignsand")]
        public IBodyWorkflowAction<UserWorkflowListV6, ApiConnectionActionConfiguration> GetAllWorkflows(Expression<Func<bool>> includeDraftWorkflows = null, Expression<Func<bool>> includeInactiveWorkflows = null, Expression<Func<string>> xApiUser = null, Expression<Func<string>> groupId = null)
        {
            var __workflow_includeDraftWorkflows = WorkflowExpression.Compile(includeDraftWorkflows, nameof(includeDraftWorkflows), required: false);
            var __workflow_includeInactiveWorkflows = WorkflowExpression.Compile(includeInactiveWorkflows, nameof(includeInactiveWorkflows), required: false);
            var __workflow_xApiUser = WorkflowExpression.Compile(xApiUser, nameof(xApiUser), required: false);
            var __workflow_groupId = WorkflowExpression.Compile(groupId, nameof(groupId), required: false);
            return new DeferredBodyAction<UserWorkflowListV6, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v6/workflows";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["includeDraftWorkflows"] = Convert.ToString(false);
                if (__workflow_includeDraftWorkflows != null)
                    callPayload.Queries["includeDraftWorkflows"] = ExpressionConverter.Convert(__workflow_includeDraftWorkflows);
                callPayload.Queries["includeInactiveWorkflows"] = Convert.ToString(false);
                if (__workflow_includeInactiveWorkflows != null)
                    callPayload.Queries["includeInactiveWorkflows"] = ExpressionConverter.Convert(__workflow_includeInactiveWorkflows);
                if (__workflow_groupId != null)
                    callPayload.Queries["groupId"] = ExpressionConverter.Convert(__workflow_groupId);
                callPayload.Headers["x-adobesign-operation-name"] = Convert.ToString("GetAllWorkflows");
                if (__workflow_xApiUser != null)
                    callPayload.Headers["x-api-user"] = ExpressionConverter.Convert(__workflow_xApiUser);
                return new ApiConnectionAction<UserWorkflowListV6>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "adobeacrobatsignsand")]
        public IBodyWorkflowAction<WorkflowDescriptionV6, ApiConnectionActionConfiguration> GetWorkflowInfo(Expression<Func<string>> workflowId, Expression<Func<string>> xApiUser = null, Expression<Func<string>> groupId = null)
        {
            var __workflow_workflowId = WorkflowExpression.Compile(workflowId, nameof(workflowId), required: true);
            var __workflow_xApiUser = WorkflowExpression.Compile(xApiUser, nameof(xApiUser), required: false);
            var __workflow_groupId = WorkflowExpression.Compile(groupId, nameof(groupId), required: false);
            return new DeferredBodyAction<WorkflowDescriptionV6, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v6/workflows/{0}", __workflow_workflowId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_groupId != null)
                    callPayload.Queries["groupId"] = ExpressionConverter.Convert(__workflow_groupId);
                callPayload.Headers["x-adobesign-operation-name"] = Convert.ToString("GetWorkflowInfo");
                if (__workflow_xApiUser != null)
                    callPayload.Headers["x-api-user"] = ExpressionConverter.Convert(__workflow_xApiUser);
                return new ApiConnectionAction<WorkflowDescriptionV6>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "adobeacrobatsignsand")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> GetAgreementAuditTrail(Expression<Func<string>> agreementId, Expression<Func<string>> xApiUser = null)
        {
            var __workflow_agreementId = WorkflowExpression.Compile(agreementId, nameof(agreementId), required: true);
            var __workflow_xApiUser = WorkflowExpression.Compile(xApiUser, nameof(xApiUser), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v6/agreements/{0}/auditTrail", __workflow_agreementId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-adobesign-operation-name"] = Convert.ToString("GetAgreementAuditTrail");
                if (__workflow_xApiUser != null)
                    callPayload.Headers["x-api-user"] = ExpressionConverter.Convert(__workflow_xApiUser);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "adobeacrobatsignsand")]
        public IBodyWorkflowAction<UserGroupsInfoV6, ApiConnectionActionConfiguration> GetAllUserGroups(Expression<Func<string>> userId, Expression<Func<string>> xApiUser = null)
        {
            var __workflow_userId = WorkflowExpression.Compile(userId, nameof(userId), required: true);
            var __workflow_xApiUser = WorkflowExpression.Compile(xApiUser, nameof(xApiUser), required: false);
            return new DeferredBodyAction<UserGroupsInfoV6, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v6/users/{0}/groups", __workflow_userId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-adobesign-operation-name"] = Convert.ToString("GetAllUserGroups");
                if (__workflow_xApiUser != null)
                    callPayload.Headers["x-api-user"] = ExpressionConverter.Convert(__workflow_xApiUser);
                return new ApiConnectionAction<UserGroupsInfoV6>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "adobeacrobatsignsand")]
        public IBodyWorkflowAction<UserAgreementListV6, ApiConnectionActionConfiguration> SearchAgreements(Expression<Func<SearchAgreementsInput>> searchRequestBody, Expression<Func<string>> xApiUser = null)
        {
            var __workflow_searchRequestBody = WorkflowExpression.Compile(searchRequestBody, nameof(searchRequestBody), required: true);
            var __workflow_xApiUser = WorkflowExpression.Compile(xApiUser, nameof(xApiUser), required: false);
            return new DeferredBodyAction<UserAgreementListV6, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v6/agreements/search";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-adobesign-operation-name"] = Convert.ToString("SearchAgreements");
                if (__workflow_xApiUser != null)
                    callPayload.Headers["x-api-user"] = ExpressionConverter.Convert(__workflow_xApiUser);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_searchRequestBody);
                return new ApiConnectionAction<UserAgreementListV6>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "adobeacrobatsignsand")]
        public IBodyWorkflowAction<AgreementCreationResponseV6, ApiConnectionActionConfiguration> CreateAgreementById(Expression<Func<CreateAgreementByIdV2Input>> agreementCreationInfoIdV6, Expression<Func<string>> xApiUser = null)
        {
            var __workflow_agreementCreationInfoIdV6 = WorkflowExpression.Compile(agreementCreationInfoIdV6, nameof(agreementCreationInfoIdV6), required: true);
            var __workflow_xApiUser = WorkflowExpression.Compile(xApiUser, nameof(xApiUser), required: false);
            return new DeferredBodyAction<AgreementCreationResponseV6, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/createagreementbyid_custom/v6/agreements";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-adobesign-operation-name"] = Convert.ToString("CreateAgreementById_V2");
                if (__workflow_xApiUser != null)
                    callPayload.Headers["x-api-user"] = ExpressionConverter.Convert(__workflow_xApiUser);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_agreementCreationInfoIdV6);
                return new ApiConnectionAction<AgreementCreationResponseV6>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "adobeacrobatsignsand")]
        public IBodyWorkflowAction<AgreementCreationResponseV6, ApiConnectionActionConfiguration> CreateAgreementByTemplate(Expression<Func<CreateAgreementByTemplateV2Input>> agreementCreationInfoTemplateV6, Expression<Func<string>> xApiUser = null)
        {
            var __workflow_agreementCreationInfoTemplateV6 = WorkflowExpression.Compile(agreementCreationInfoTemplateV6, nameof(agreementCreationInfoTemplateV6), required: true);
            var __workflow_xApiUser = WorkflowExpression.Compile(xApiUser, nameof(xApiUser), required: false);
            return new DeferredBodyAction<AgreementCreationResponseV6, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/createagreementbytemplate_custom/v6/agreements";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-adobesign-operation-name"] = Convert.ToString("CreateAgreementByTemplate_V2");
                if (__workflow_xApiUser != null)
                    callPayload.Headers["x-api-user"] = ExpressionConverter.Convert(__workflow_xApiUser);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_agreementCreationInfoTemplateV6);
                return new ApiConnectionAction<AgreementCreationResponseV6>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "adobeacrobatsignsand")]
        public IBodyWorkflowAction<AgreementCreationResponseV6, ApiConnectionActionConfiguration> CreateAgreementByUrl(Expression<Func<CreateAgreementByUrlV2Input>> agreementCreationInfoUrlV6, Expression<Func<string>> xApiUser = null)
        {
            var __workflow_agreementCreationInfoUrlV6 = WorkflowExpression.Compile(agreementCreationInfoUrlV6, nameof(agreementCreationInfoUrlV6), required: true);
            var __workflow_xApiUser = WorkflowExpression.Compile(xApiUser, nameof(xApiUser), required: false);
            return new DeferredBodyAction<AgreementCreationResponseV6, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/createagreementbyurl_custom/v6/agreements";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-adobesign-operation-name"] = Convert.ToString("CreateAgreementByUrl_V2");
                if (__workflow_xApiUser != null)
                    callPayload.Headers["x-api-user"] = ExpressionConverter.Convert(__workflow_xApiUser);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_agreementCreationInfoUrlV6);
                return new ApiConnectionAction<AgreementCreationResponseV6>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "adobeacrobatsignsand")]
        public IBodyWorkflowAction<LibraryDocumentCreationResponseV6, ApiConnectionActionConfiguration> CreateLibraryDocumentById(Expression<Func<CreateLibraryDocumentByIdV2Input>> libraryDocumentInfoId, Expression<Func<string>> xApiUser = null)
        {
            var __workflow_libraryDocumentInfoId = WorkflowExpression.Compile(libraryDocumentInfoId, nameof(libraryDocumentInfoId), required: true);
            var __workflow_xApiUser = WorkflowExpression.Compile(xApiUser, nameof(xApiUser), required: false);
            return new DeferredBodyAction<LibraryDocumentCreationResponseV6, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/createlibrarydocumentbyid_custom/v6/libraryDocuments";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-adobesign-operation-name"] = Convert.ToString("CreateLibraryDocumentById_V2");
                if (__workflow_xApiUser != null)
                    callPayload.Headers["x-api-user"] = ExpressionConverter.Convert(__workflow_xApiUser);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_libraryDocumentInfoId);
                return new ApiConnectionAction<LibraryDocumentCreationResponseV6>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "adobeacrobatsignsand")]
        public IBodyWorkflowAction<LibraryDocumentCreationResponseV6, ApiConnectionActionConfiguration> CreateLibraryDocumentByUrl(Expression<Func<CreateLibraryDocumentByUrlV2Input>> libraryDocumentInfoUrl, Expression<Func<string>> xApiUser = null)
        {
            var __workflow_libraryDocumentInfoUrl = WorkflowExpression.Compile(libraryDocumentInfoUrl, nameof(libraryDocumentInfoUrl), required: true);
            var __workflow_xApiUser = WorkflowExpression.Compile(xApiUser, nameof(xApiUser), required: false);
            return new DeferredBodyAction<LibraryDocumentCreationResponseV6, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/createlibrarydocumentbyurl_custom/v6/libraryDocuments";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-adobesign-operation-name"] = Convert.ToString("CreateLibraryDocumentByUrl_V2");
                if (__workflow_xApiUser != null)
                    callPayload.Headers["x-api-user"] = ExpressionConverter.Convert(__workflow_xApiUser);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_libraryDocumentInfoUrl);
                return new ApiConnectionAction<LibraryDocumentCreationResponseV6>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "adobeacrobatsignsand")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> GetAgreementFormFieldData(Expression<Func<string>> agreementId, Expression<Func<string>> xApiUser = null)
        {
            var __workflow_agreementId = WorkflowExpression.Compile(agreementId, nameof(agreementId), required: true);
            var __workflow_xApiUser = WorkflowExpression.Compile(xApiUser, nameof(xApiUser), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/custom_json/v6/agreements/{0}/formData", __workflow_agreementId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-adobesign-operation-name"] = Convert.ToString("GetAgreementFormFieldData_V3");
                if (__workflow_xApiUser != null)
                    callPayload.Headers["x-api-user"] = ExpressionConverter.Convert(__workflow_xApiUser);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "adobeacrobatsignsand")]
        public IBodyWorkflowAction<AgreementInfoV6, ApiConnectionActionConfiguration> GetAgreementInfo(Expression<Func<string>> agreementId, Expression<Func<string>> xApiUser = null)
        {
            var __workflow_agreementId = WorkflowExpression.Compile(agreementId, nameof(agreementId), required: true);
            var __workflow_xApiUser = WorkflowExpression.Compile(xApiUser, nameof(xApiUser), required: false);
            return new DeferredBodyAction<AgreementInfoV6, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v6/agreements/{0}", __workflow_agreementId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-adobesign-operation-name"] = Convert.ToString("GetAgreementInfo_V2");
                if (__workflow_xApiUser != null)
                    callPayload.Headers["x-api-user"] = ExpressionConverter.Convert(__workflow_xApiUser);
                return new ApiConnectionAction<AgreementInfoV6>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "adobeacrobatsignsand")]
        public IBodyWorkflowAction<UserAgreementListV6, ApiConnectionActionConfiguration> GetAllAgreements(Expression<Func<string>> cursor = null, Expression<Func<int>> pageSize = null, Expression<Func<string>> xApiUser = null, Expression<Func<string>> groupId = null)
        {
            var __workflow_cursor = WorkflowExpression.Compile(cursor, nameof(cursor), required: false);
            var __workflow_pageSize = WorkflowExpression.Compile(pageSize, nameof(pageSize), required: false);
            var __workflow_xApiUser = WorkflowExpression.Compile(xApiUser, nameof(xApiUser), required: false);
            var __workflow_groupId = WorkflowExpression.Compile(groupId, nameof(groupId), required: false);
            return new DeferredBodyAction<UserAgreementListV6, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v6/agreements";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_cursor != null)
                    callPayload.Queries["cursor"] = ExpressionConverter.Convert(__workflow_cursor);
                if (__workflow_pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(__workflow_pageSize);
                if (__workflow_groupId != null)
                    callPayload.Queries["groupId"] = ExpressionConverter.Convert(__workflow_groupId);
                callPayload.Headers["x-adobesign-operation-name"] = Convert.ToString("GetAllAgreements_V2");
                if (__workflow_xApiUser != null)
                    callPayload.Headers["x-api-user"] = ExpressionConverter.Convert(__workflow_xApiUser);
                return new ApiConnectionAction<UserAgreementListV6>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "adobeacrobatsignsand")]
        public IBodyWorkflowAction<AgreementDocumentsV6, ApiConnectionActionConfiguration> GetAllDocumentsofAnAgreement(Expression<Func<string>> agreementId, Expression<Func<supportingDocumentContentFormatInput>> supportingDocumentContentFormat = null, Expression<Func<string>> xApiUser = null)
        {
            var __workflow_agreementId = WorkflowExpression.Compile(agreementId, nameof(agreementId), required: true);
            var __workflow_supportingDocumentContentFormat = WorkflowExpression.Compile(supportingDocumentContentFormat, nameof(supportingDocumentContentFormat), required: false);
            var __workflow_xApiUser = WorkflowExpression.Compile(xApiUser, nameof(xApiUser), required: false);
            return new DeferredBodyAction<AgreementDocumentsV6, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v6/agreements/{0}/documents", __workflow_agreementId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["supportingDocumentContentFormat"] = Convert.ToString("CONVERTED_PDF");
                if (__workflow_supportingDocumentContentFormat != null)
                    callPayload.Queries["supportingDocumentContentFormat"] = ExpressionConverter.Convert(__workflow_supportingDocumentContentFormat);
                callPayload.Headers["x-adobesign-operation-name"] = Convert.ToString("GetAllDocumentsofAnAgreement_V2");
                if (__workflow_xApiUser != null)
                    callPayload.Headers["x-api-user"] = ExpressionConverter.Convert(__workflow_xApiUser);
                return new ApiConnectionAction<AgreementDocumentsV6>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "adobeacrobatsignsand")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> GetCombinedDocument(Expression<Func<string>> agreementId, Expression<Func<bool>> attachSupportingDocuments = null, Expression<Func<bool>> attachAuditReport = null, Expression<Func<string>> xApiUser = null)
        {
            var __workflow_agreementId = WorkflowExpression.Compile(agreementId, nameof(agreementId), required: true);
            var __workflow_attachSupportingDocuments = WorkflowExpression.Compile(attachSupportingDocuments, nameof(attachSupportingDocuments), required: false);
            var __workflow_attachAuditReport = WorkflowExpression.Compile(attachAuditReport, nameof(attachAuditReport), required: false);
            var __workflow_xApiUser = WorkflowExpression.Compile(xApiUser, nameof(xApiUser), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v6/agreements/{0}/combinedDocument", __workflow_agreementId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_attachSupportingDocuments != null)
                    callPayload.Queries["attachSupportingDocuments"] = ExpressionConverter.Convert(__workflow_attachSupportingDocuments);
                if (__workflow_attachAuditReport != null)
                    callPayload.Queries["attachAuditReport"] = ExpressionConverter.Convert(__workflow_attachAuditReport);
                callPayload.Headers["x-adobesign-operation-name"] = Convert.ToString("GetCombinedDocument_V2");
                if (__workflow_xApiUser != null)
                    callPayload.Headers["x-api-user"] = ExpressionConverter.Convert(__workflow_xApiUser);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "adobeacrobatsignsand")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> GetDocument(Expression<Func<string>> agreementId, Expression<Func<string>> documentId, Expression<Func<string>> xApiUser = null)
        {
            var __workflow_agreementId = WorkflowExpression.Compile(agreementId, nameof(agreementId), required: true);
            var __workflow_documentId = WorkflowExpression.Compile(documentId, nameof(documentId), required: true);
            var __workflow_xApiUser = WorkflowExpression.Compile(xApiUser, nameof(xApiUser), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v6/agreements/{0}/documents/{1}", __workflow_agreementId.WithUrlEncoding(1), __workflow_documentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-adobesign-operation-name"] = Convert.ToString("GetDocument_V2");
                if (__workflow_xApiUser != null)
                    callPayload.Headers["x-api-user"] = ExpressionConverter.Convert(__workflow_xApiUser);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "adobeacrobatsignsand")]
        public IBodyWorkflowAction<LibraryDocuments, ApiConnectionActionConfiguration> GetLibraryDocuments(Expression<Func<string>> cursor = null, Expression<Func<int>> pageSize = null, Expression<Func<string>> xApiUser = null, Expression<Func<string>> groupId = null)
        {
            var __workflow_cursor = WorkflowExpression.Compile(cursor, nameof(cursor), required: false);
            var __workflow_pageSize = WorkflowExpression.Compile(pageSize, nameof(pageSize), required: false);
            var __workflow_xApiUser = WorkflowExpression.Compile(xApiUser, nameof(xApiUser), required: false);
            var __workflow_groupId = WorkflowExpression.Compile(groupId, nameof(groupId), required: false);
            return new DeferredBodyAction<LibraryDocuments, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v6/libraryDocuments";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_cursor != null)
                    callPayload.Queries["cursor"] = ExpressionConverter.Convert(__workflow_cursor);
                if (__workflow_pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(__workflow_pageSize);
                if (__workflow_groupId != null)
                    callPayload.Queries["groupId"] = ExpressionConverter.Convert(__workflow_groupId);
                callPayload.Headers["x-adobesign-operation-name"] = Convert.ToString("GetLibraryDocuments_V2");
                if (__workflow_xApiUser != null)
                    callPayload.Headers["x-api-user"] = ExpressionConverter.Convert(__workflow_xApiUser);
                return new ApiConnectionAction<LibraryDocuments>(callPayload);
            });
        }
    }

    public class AdobeacrobatsignsandTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<WebhookCreationResponse, ApiConnectionTriggerConfiguration> CreateWebhookForAgreementCreatedEvent(Expression<Func<CreateWebhookForAgreementCreatedEventInput>> webhookCreationInfo, FlowRecurrence recurrence = null)
        {
            var __workflow_webhookCreationInfo = WorkflowExpression.Compile(webhookCreationInfo, nameof(webhookCreationInfo), required: true);
            return new DeferredBodyTrigger<WebhookCreationResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/createwebhookforAgreementCreatedEvent_custom/v6/webhooks";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-adobesign-operation-name"] = Convert.ToString("CreateWebhookForAgreementCreatedEvent");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_webhookCreationInfo);
                return new ApiConnectionTrigger<WebhookCreationResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<WebhookCreationResponse, ApiConnectionTriggerConfiguration> CreateWebhookForAgreementSignatureRequestedEvent(Expression<Func<CreateWebhookForAgreementSignatureRequestedEventInput>> webhookCreationInfo, FlowRecurrence recurrence = null)
        {
            var __workflow_webhookCreationInfo = WorkflowExpression.Compile(webhookCreationInfo, nameof(webhookCreationInfo), required: true);
            return new DeferredBodyTrigger<WebhookCreationResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/createwebhookforSignatureRquestedEvent_custom/v6/webhooks";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-adobesign-operation-name"] = Convert.ToString("CreateWebhookForAgreementSignatureRequestedEvent");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_webhookCreationInfo);
                return new ApiConnectionTrigger<WebhookCreationResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<WebhookCreationResponse, ApiConnectionTriggerConfiguration> CreateWebhookForAgreementSignedEvent(Expression<Func<CreateWebhookForAgreementSignedEventInput>> webhookCreationInfo, FlowRecurrence recurrence = null)
        {
            var __workflow_webhookCreationInfo = WorkflowExpression.Compile(webhookCreationInfo, nameof(webhookCreationInfo), required: true);
            return new DeferredBodyTrigger<WebhookCreationResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/createwebhookforSignedDocumentEvent_custom/v6/webhooks";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-adobesign-operation-name"] = Convert.ToString("CreateWebhookForAgreementSignedEvent");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_webhookCreationInfo);
                return new ApiConnectionTrigger<WebhookCreationResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<WebhookCreationResponse, ApiConnectionTriggerConfiguration> CreateWebhookForAgreementStatusUpdated(Expression<Func<CreateWebhookForAgreementStatusUpdatedInput>> webhookCreationInfo, FlowRecurrence recurrence = null)
        {
            var __workflow_webhookCreationInfo = WorkflowExpression.Compile(webhookCreationInfo, nameof(webhookCreationInfo), required: true);
            return new DeferredBodyTrigger<WebhookCreationResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/createwebhookforStatusChange_custom/v6/webhooks";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-adobesign-operation-name"] = Convert.ToString("CreateWebhookForAgreementStatusUpdated");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_webhookCreationInfo);
                return new ApiConnectionTrigger<WebhookCreationResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<WebhookCreationResponse, ApiConnectionTriggerConfiguration> CreateWebhookGeneric(Expression<Func<CreateWebhookGenericInput>> webhookCreationInfo, FlowRecurrence recurrence = null)
        {
            var __workflow_webhookCreationInfo = WorkflowExpression.Compile(webhookCreationInfo, nameof(webhookCreationInfo), required: true);
            return new DeferredBodyTrigger<WebhookCreationResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/createwebhookGeneric_custom/v6/webhooks";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-adobesign-operation-name"] = Convert.ToString("CreateWebhookGeneric");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_webhookCreationInfo);
                return new ApiConnectionTrigger<WebhookCreationResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<WebhookCreationResponse, ApiConnectionTriggerConfiguration> CreateWebhookForWebFormAgreementEvent(Expression<Func<CreateWebhookForWebFormAgreementEventInput>> webhookCreationInfo, FlowRecurrence recurrence = null)
        {
            var __workflow_webhookCreationInfo = WorkflowExpression.Compile(webhookCreationInfo, nameof(webhookCreationInfo), required: true);
            return new DeferredBodyTrigger<WebhookCreationResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/createwebhookforWebFormAgreementEvent_custom/v6/webhooks";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-adobesign-operation-name"] = Convert.ToString("CreateWebhookForWebFormAgreementEvent");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_webhookCreationInfo);
                return new ApiConnectionTrigger<WebhookCreationResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<WebhookCreationResponse, ApiConnectionTriggerConfiguration> CreateWebhookForGroupEvent(Expression<Func<CreateWebhookForGroupEventInput>> webhookCreationInfo, FlowRecurrence recurrence = null)
        {
            var __workflow_webhookCreationInfo = WorkflowExpression.Compile(webhookCreationInfo, nameof(webhookCreationInfo), required: true);
            return new DeferredBodyTrigger<WebhookCreationResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/createwebhookForGroupEvent_custom/v6/webhooks";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-adobesign-operation-name"] = Convert.ToString("CreateWebhookForGroupEvent");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_webhookCreationInfo);
                return new ApiConnectionTrigger<WebhookCreationResponse>(callPayload, recurrence: recurrence);
            });
        }
    }

    public class AgreementCreationResponseV6
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class CreateAgreementByFileStreamInput
    {
        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string AgreementName { get; set; }

        [JsonProperty("fileInfos", DefaultValueHandling = DefaultValueHandling.Include)]
        public DocumentFileInfoFileStream[] File { get; set; }

        [JsonProperty("signatureType", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateAgreementByFileStreamInputSignatureTypeType SignatureType { get; set; } = CreateAgreementByFileStreamInputSignatureTypeType.ESIGN;

        [JsonProperty("participantSetsInfo", DefaultValueHandling = DefaultValueHandling.Include)]
        public ParticipantCreateSetInfoV6[] Unnamed { get; set; }

        [JsonProperty("groupId")]
        public string GroupId { get; set; }

        [JsonProperty("message", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Message { get; set; } = "Please review and complete this document";

        [JsonProperty("ccs")]
        public AgreementCcInfo[] CCs { get; set; }

        [JsonProperty("expirationTime")]
        public string ExpirationTime { get; set; }

        [JsonProperty("reminderFrequency")]
        public CreateAgreementByFileStreamInputReminderFrequencyType? ReminderFrequency { get; set; }

        [JsonProperty("securityOption")]
        public CreateAgreementByFileStreamInputSecurityOptionType SecurityOption { get; set; }

        [JsonProperty("mergeFieldInfo")]
        public MergefieldInfo[] FormField { get; set; }

        [JsonProperty("postSignOption")]
        public PostSigningOption PostSignOption { get; set; }

        [JsonProperty("emailOption", DefaultValueHandling = DefaultValueHandling.Include)]
        public EmailOption EmailOption { get; set; } = new EmailOption();

        [JsonProperty("state", DefaultValueHandling = DefaultValueHandling.Include)]
        internal CreateAgreementByFileStreamInputStateType State { get; set; } = CreateAgreementByFileStreamInputStateType.INPROCESS;
    }

    public class DocumentFileInfoFileStream
    {
        [JsonProperty("fileName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("formData", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent Content { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateAgreementByFileStreamInputSignatureTypeType
    {
        ESIGN,
        WRITTEN
    }

    public class ParticipantCreateSetInfoV6
    {
        [JsonProperty("memberInfos", DefaultValueHandling = DefaultValueHandling.Include)]
        public MemberInfosV62[] Unnamed { get; set; }

        [JsonProperty("order", DefaultValueHandling = DefaultValueHandling.Include)]
        public int Order { get; set; } = 1;

        [JsonProperty("role", DefaultValueHandling = DefaultValueHandling.Include)]
        public ParticipantCreateSetInfoV6RoleType Role { get; set; } = ParticipantCreateSetInfoV6RoleType.SIGNER;
    }

    public class MemberInfosV62
    {
        [JsonProperty("email", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ParticipantEmail { get; set; }

        [JsonProperty("securityOption")]
        public MemberInfosV6UnnamedType2 Unnamed { get; set; }
    }

    public class MemberInfosV6UnnamedType2
    {
        [JsonProperty("authenticationMethod")]
        public MemberInfosV6UnnamedTypeAuthenticationType? Authentication { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }

        [JsonProperty("phoneInfo")]
        public MemberInfosV6UnnamedTypeUnnamedType Unnamed { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum MemberInfosV6UnnamedTypeAuthenticationType
    {
        NONE,
        PASSWORD,
        PHONE,
        KBA,
        [EnumMember(Value = "ADOBE_SIGN")]
        ADOBESIGN
    }

    public class MemberInfosV6UnnamedTypeUnnamedType
    {
        [JsonProperty("countryCode")]
        public string CountryCode { get; set; }

        [JsonProperty("phone")]
        public string PhoneNo { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ParticipantCreateSetInfoV6RoleType
    {
        SIGNER,
        APPROVER,
        ACCEPTOR,
        [EnumMember(Value = "CERTIFIED_RECIPIENT")]
        CERTIFIEDRECIPIENT,
        [EnumMember(Value = "FORM_FILLER")]
        FORMFILLER,
        [EnumMember(Value = "DELEGATE_TO_SIGNER")]
        DELEGATETOSIGNER,
        [EnumMember(Value = "DELEGATE_TO_APPROVER")]
        DELEGATETOAPPROVER,
        [EnumMember(Value = "DELEGATE_TO_ACCEPTOR")]
        DELEGATETOACCEPTOR,
        [EnumMember(Value = "DELEGATE_TO_CERTIFIED_RECIPIENT")]
        DELEGATETOCERTIFIEDRECIPIENT,
        [EnumMember(Value = "DELEGATE_TO_FORM_FILLER")]
        DELEGATETOFORMFILLER
    }

    public class AgreementCcInfo
    {
        [JsonProperty("email")]
        public string Email { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateAgreementByFileStreamInputReminderFrequencyType
    {
        [EnumMember(Value = "DAILY_UNTIL_SIGNED")]
        DAILYUNTILSIGNED,
        [EnumMember(Value = "WEEKLY_UNTIL_SIGNED")]
        WEEKLYUNTILSIGNED
    }

    public class CreateAgreementByFileStreamInputSecurityOptionType
    {
        [JsonProperty("openPassword")]
        public string DocumentPassword { get; set; }
    }

    public class MergefieldInfo
    {
        [JsonProperty("fieldName")]
        public string FieldName { get; set; }

        [JsonProperty("defaultValue")]
        public string DefaultValue { get; set; }
    }

    public class PostSigningOption
    {
        [JsonProperty("redirectDelay")]
        public string RedirectDelay { get; set; }

        [JsonProperty("redirectUrl")]
        public string RedirectURL { get; set; }
    }

    public class EmailOption
    {
        [JsonProperty("sendOptions", DefaultValueHandling = DefaultValueHandling.Include)]
        public EmailOptionSendOptionsType SendOptions { get; set; } = new EmailOptionSendOptionsType();
    }

    public class EmailOptionSendOptionsType
    {
        [JsonProperty("initEmails", DefaultValueHandling = DefaultValueHandling.Include)]
        public EmailOptionSendOptionsTypeInitialEmailsType? InitialEmails { get; set; } = EmailOptionSendOptionsTypeInitialEmailsType.ALL;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EmailOptionSendOptionsTypeInitialEmailsType
    {
        ALL,
        NONE
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateAgreementByFileStreamInputStateType
    {
        AUTHORING,
        DRAFT,
        [EnumMember(Value = "IN_PROCESS")]
        INPROCESS
    }

    public class CancelAgreementInput
    {
        [JsonProperty("state", DefaultValueHandling = DefaultValueHandling.Include)]
        public string AgrementState { get; set; } = "CANCELLED";

        [JsonProperty("agreementCancellationInfo", DefaultValueHandling = DefaultValueHandling.Include)]
        public CancelAgreementInputNotifyType Notify { get; set; } = new CancelAgreementInputNotifyType();
    }

    public class CancelAgreementInputNotifyType
    {
        [JsonProperty("comment")]
        public string Comment { get; set; }

        [JsonProperty("notifyOthers", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? Others { get; set; } = false;
    }

    public class SigningUrlResponse
    {
        [JsonProperty("signingUrlSetInfos")]
        public SigningUrlSetInfo[] SigningUrlSetInfos { get; set; }
    }

    public class SigningUrlSetInfo
    {
        [JsonProperty("signingUrls")]
        public SigningUrl[] SigningUrls { get; set; }

        [JsonProperty("signingUrlSetName")]
        public string SigningUrlSetName { get; set; }
    }

    public class SigningUrl
    {
        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("esignUrl")]
        public string EsignUrl { get; set; }
    }

    public class UserWidgetListV6
    {
        [JsonProperty("page")]
        public Page Page { get; set; }

        [JsonProperty("userWidgetList")]
        public UserWidgetV6[] UserWidgetList { get; set; }
    }

    public class Page
    {
        [JsonProperty("nextCursor")]
        public string NextCursor { get; set; }
    }

    public class UserWidgetV6
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("modifiedDate")]
        public string ModifiedDate { get; set; }

        [JsonProperty("hidden")]
        public bool Hidden { get; set; }

        [JsonProperty("groupId")]
        public string GroupId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("status")]
        public UserWidgetV6StatusType Status { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("javascript")]
        public string Javascript { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum UserWidgetV6StatusType
    {
        AUTHORING,
        ACTIVE,
        DRAFT,
        DISABLED
    }

    public class UserWorkflowListV6
    {
        [JsonProperty("userWorkflowList")]
        public UserWorkflowV6[] UserWorkflowList { get; set; }
    }

    public class UserWorkflowV6
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("modified")]
        public string Modified { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("status")]
        public UserWorkflowV6StatusType Status { get; set; }

        [JsonProperty("scope")]
        public UserWorkflowV6ScopeType Scope { get; set; }

        [JsonProperty("originatorId")]
        public string OriginatorId { get; set; }

        [JsonProperty("scopeId")]
        public string ScopeId { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum UserWorkflowV6StatusType
    {
        ACTIVE,
        DRAFT,
        INACTIVE,
        [EnumMember(Value = "HIDDEN")]
        HIdDEN,
        OTHER
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum UserWorkflowV6ScopeType
    {
        ACCOUNT,
        GROUP,
        OTHER
    }

    public class WorkflowDescriptionV6
    {
        [JsonProperty("agreementNameInfo")]
        public JToken AgreementNameInfo { get; set; }

        [JsonProperty("authoringInfo")]
        public JToken AuthoringInfo { get; set; }

        [JsonProperty("ccsListInfo")]
        public CCsListInfoDescriptionV6[] CcsListInfo { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("expirationInfo")]
        public JToken ExpirationInfo { get; set; }

        [JsonProperty("fileInfos")]
        public FileInfosDescriptionV6[] FileInfos { get; set; }

        [JsonProperty("localeInfo")]
        public JToken LocaleInfo { get; set; }

        [JsonProperty("mergeFieldsInfo")]
        public MergeFieldInfoDescriptionV6[] MergeFieldsInfo { get; set; }

        [JsonProperty("messageInfo")]
        public JToken MessageInfo { get; set; }

        [JsonProperty("modified")]
        public string Modified { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("passwordInfo")]
        public JToken PasswordInfo { get; set; }

        [JsonProperty("recipientsListInfo")]
        public RecipientsListInfoDescriptionV6[] RecipientsListInfo { get; set; }

        [JsonProperty("scope")]
        public WorkflowDescriptionV6ScopeType Scope { get; set; }

        [JsonProperty("status")]
        public WorkflowDescriptionV6StatusType Status { get; set; }

        [JsonProperty("originatorId")]
        public string OriginatorId { get; set; }

        [JsonProperty("scopeId")]
        public string ScopeId { get; set; }
    }

    public class CCsListInfoDescriptionV6
    {
        [JsonProperty("defaultValues")]
        public string[] DefaultValues { get; set; }

        [JsonProperty("editable")]
        public bool Editable { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("maxListCount")]
        public int MaxListCount { get; set; }

        [JsonProperty("minListCount")]
        public int MinListCount { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("required")]
        public bool Required { get; set; }

        [JsonProperty("visible")]
        public bool Visible { get; set; }
    }

    public class FileInfosDescriptionV6
    {
        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("required")]
        public bool Required { get; set; }

        [JsonProperty("workflowLibraryDocumentSelectorList")]
        public WorkflowLibraryDocumentV6[] WorkflowLibraryDocumentSelectorList { get; set; }
    }

    public class WorkflowLibraryDocumentV6
    {
        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("modifiedDate")]
        public string ModifiedDate { get; set; }

        [JsonProperty("sharingMode")]
        public WorkflowLibraryDocumentV6SharingModeType SharingMode { get; set; }

        [JsonProperty("templateTypes")]
        public JToken[] TemplateTypes { get; set; }

        [JsonProperty("workflowLibDoc")]
        public string WorkflowLibDoc { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum WorkflowLibraryDocumentV6SharingModeType
    {
        USER,
        GROUP,
        ACCOUNT,
        GLOBAL
    }

    public class MergeFieldInfoDescriptionV6
    {
        [JsonProperty("defaultValue")]
        public string DefaultValue { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("editable")]
        public bool Editable { get; set; }

        [JsonProperty("fieldName")]
        public string FieldName { get; set; }

        [JsonProperty("required")]
        public bool Required { get; set; }

        [JsonProperty("visible")]
        public bool Visible { get; set; }
    }

    public class RecipientsListInfoDescriptionV6
    {
        [JsonProperty("allowSender")]
        public bool AllowSender { get; set; }

        [JsonProperty("allowfax")]
        public bool Allowfax { get; set; }

        [JsonProperty("authenticationMethod")]
        public RecipientsListInfoDescriptionV6AuthenticationMethodType AuthenticationMethod { get; set; }

        [JsonProperty("defaultValue")]
        public string DefaultValue { get; set; }

        [JsonProperty("editable")]
        public bool Editable { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("maxListCount")]
        public int MaxListCount { get; set; }

        [JsonProperty("minListCount")]
        public int MinListCount { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("role")]
        public RecipientsListInfoDescriptionV6RoleType Role { get; set; }

        [JsonProperty("visible")]
        public bool Visible { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum RecipientsListInfoDescriptionV6AuthenticationMethodType
    {
        NONE,
        KBA,
        PASSWORD,
        [EnumMember(Value = "WEB_IDENTITY")]
        WEBIdENTITY,
        PHONE,
        [EnumMember(Value = "ADOBE_SIGN")]
        ADOBESIGN
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum RecipientsListInfoDescriptionV6RoleType
    {
        SIGNER,
        APPROVER,
        ACCEPTOR,
        [EnumMember(Value = "FORM_FILLER")]
        FORMFILLER,
        [EnumMember(Value = "CERTIFIED_RECIPIENT")]
        CERTIFIEDRECIPIENT,
        [EnumMember(Value = "DELEGATE_TO_SIGNER")]
        DELEGATETOSIGNER,
        [EnumMember(Value = "DELEGATE_TO_APPROVER")]
        DELEGATETOAPPROVER,
        [EnumMember(Value = "DELEGATE_TO_ACCEPTOR")]
        DELEGATETOACCEPTOR,
        [EnumMember(Value = "DELEGATE_TO_FORM_FILLER")]
        DELEGATETOFORMFILLER,
        [EnumMember(Value = "DELEGATE_TO_CERTIFIED_RECIPIENT")]
        DELEGATETOCERTIFIEDRECIPIENT
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum WorkflowDescriptionV6ScopeType
    {
        ACCOUNT,
        GROUP,
        OTHER
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum WorkflowDescriptionV6StatusType
    {
        ACTIVE,
        DRAFT,
        INACTIVE,
        [EnumMember(Value = "HIDDEN")]
        HIdDEN,
        OTHER
    }

    public class UserGroupsInfoV6
    {
        [JsonProperty("groupInfoList")]
        public UserGroupInfoV6[] GroupInfoList { get; set; }
    }

    public class UserGroupInfoV6
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("isGroupAdmin")]
        public bool IsGroupAdmin { get; set; }

        [JsonProperty("isPrimaryGroup")]
        public bool IsPrimaryGroup { get; set; }

        [JsonProperty("status")]
        public UserGroupInfoV6StatusType Status { get; set; }

        [JsonProperty("createdDate")]
        public string CreatedDate { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("settings")]
        public SettingsInfoV6 Settings { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum UserGroupInfoV6StatusType
    {
        ACTIVE,
        DELETED
    }

    public class SettingsInfoV6
    {
        [JsonProperty("libaryDocumentCreationVisible")]
        public BooleanSettingInfoV6 LibaryDocumentCreationVisible { get; set; }

        [JsonProperty("sendRestrictedToWorkflows")]
        public BooleanSettingInfoV6 SendRestrictedToWorkflows { get; set; }

        [JsonProperty("userCanSend")]
        public BooleanSettingInfoV6 UserCanSend { get; set; }

        [JsonProperty("widgetCreationVisible")]
        public BooleanSettingInfoV6 WidgetCreationVisible { get; set; }
    }

    public class BooleanSettingInfoV6
    {
        [JsonProperty("value")]
        public bool Value { get; set; }

        [JsonProperty("inherited")]
        public bool Inherited { get; set; }
    }

    public class UserAgreementListV6
    {
        [JsonProperty("page")]
        public Page Page { get; set; }

        [JsonProperty("userAgreementList")]
        public UserAgreementV6[] UserAgreementList { get; set; }
    }

    public class UserAgreementV6
    {
        [JsonProperty("displayParticipantSetInfos")]
        public DisplayUserSetInfo[] DisplayParticipantSetInfos { get; set; }

        [JsonProperty("displayDate")]
        public string DisplayDate { get; set; }

        [JsonProperty("esign")]
        public bool Esign { get; set; }

        [JsonProperty("hidden")]
        public bool Hidden { get; set; }

        [JsonProperty("groupId")]
        public string GroupId { get; set; }

        [JsonProperty("latestVersionId")]
        public string LatestVersionId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("parentId")]
        public string ParentId { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("status")]
        public UserAgreementV6StatusType Status { get; set; }

        [JsonProperty("type")]
        public UserAgreementV6TypeType Type { get; set; }
    }

    public class DisplayUserSetInfo
    {
        [JsonProperty("displayUserSetMemberInfos")]
        public DisplayUserInfo[] DisplayUserSetMemberInfos { get; set; }

        [JsonProperty("displayUserSetName")]
        public string DisplayUserSetName { get; set; }
    }

    public class DisplayUserInfo
    {
        [JsonProperty("company")]
        public string Company { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("fullName")]
        public string FullName { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum UserAgreementV6StatusType
    {
        [EnumMember(Value = "WAITING_FOR_MY_SIGNATURE")]
        WAITINGFORMYSIGNATURE,
        [EnumMember(Value = "WAITING_FOR_MY_APPROVAL")]
        WAITINGFORMYAPPROVAL,
        [EnumMember(Value = "WAITING_FOR_MY_DELEGATION")]
        WAITINGFORMYDELEGATION,
        [EnumMember(Value = "WAITING_FOR_MY_ACKNOWLEDGEMENT")]
        WAITINGFORMYACKNOWLEDGEMENT,
        [EnumMember(Value = "WAITING_FOR_MY_ACCEPTANCE")]
        WAITINGFORMYACCEPTANCE,
        [EnumMember(Value = "WAITING_FOR_MY_FORM_FILLING")]
        WAITINGFORMYFORMFILLING,
        [EnumMember(Value = "OUT_FOR_SIGNATURE")]
        OUTFORSIGNATURE,
        [EnumMember(Value = "OUT_FOR_APPROVAL")]
        OUTFORAPPROVAL,
        [EnumMember(Value = "OUT_FOR_DELIVERY")]
        OUTFORDELIVERY,
        [EnumMember(Value = "OUT_FOR_ACCEPTANCE")]
        OUTFORACCEPTANCE,
        [EnumMember(Value = "OUT_FOR_FORM_FILLING")]
        OUTFORFORMFILLING,
        [EnumMember(Value = "FORM_FILLED")]
        FORMFILLED,
        DELIVERED,
        CANCELLED,
        SIGNED,
        APPROVED,
        RECALLED,
        [EnumMember(Value = "WAITING_FOR_FAXIN")]
        WAITINGFORFAXIN,
        ARCHIVED,
        FORM,
        EXPIRED,
        [EnumMember(Value = "WIDGET")]
        WIdGET,
        [EnumMember(Value = "WAITING_FOR_PREFILL")]
        WAITINGFORPREFILL,
        [EnumMember(Value = "DOCUMENTS_NOT_YET_PROCESSED")]
        DOCUMENTSNOTYETPROCESSED,
        [EnumMember(Value = "WAITING_FOR_MY_VERIFICATION")]
        WAITINGFORMYVERIFICATION,
        [EnumMember(Value = "WAITING_FOR_VERIFICATION")]
        WAITINGFORVERIFICATION,
        [EnumMember(Value = "WAITING_FOR_AUTHORING")]
        WAITINGFORAUTHORING
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum UserAgreementV6TypeType
    {
        AGREEMENT,
        [EnumMember(Value = "MEGASIGN_CHILD")]
        MEGASIGNCHILD,
        [EnumMember(Value = "WIDGET_INSTANCE")]
        WIdGETINSTANCE
    }

    public class SearchAgreementsInput
    {
        [JsonProperty("groupId")]
        public string GroupNameId { get; set; }

        [JsonProperty("workflowId")]
        public string WorkflowNameId { get; set; }

        [JsonProperty("agreementAssetsCriteria")]
        public SearchAgreementsInputAgreementAssetsCriteriaType AgreementAssetsCriteria { get; set; }
    }

    public class SearchAgreementsInputAgreementAssetsCriteriaType
    {
        [JsonProperty("createdDate")]
        public SearchAgreementsInputAgreementAssetsCriteriaTypeCreatedDateType CreatedDate { get; set; }

        [JsonProperty("pageSize")]
        public int? PageSize { get; set; }

        [JsonProperty("startIndex")]
        public int? StartIndex { get; set; }
    }

    public class SearchAgreementsInputAgreementAssetsCriteriaTypeCreatedDateType
    {
        [JsonProperty("range")]
        public SearchAgreementsInputAgreementAssetsCriteriaTypeCreatedDateTypeRangeType Range { get; set; }
    }

    public class SearchAgreementsInputAgreementAssetsCriteriaTypeCreatedDateTypeRangeType
    {
        [JsonProperty("gt")]
        public string Gt { get; set; }

        [JsonProperty("lt")]
        public string Lt { get; set; }
    }

    public class CreateAgreementByIdV2Input
    {
        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string AgreementName { get; set; }

        [JsonProperty("fileInfos", DefaultValueHandling = DefaultValueHandling.Include)]
        public DocumentFileInfoId[] Document { get; set; }

        [JsonProperty("signatureType", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateAgreementByIdV2InputSignatureTypeType SignatureType { get; set; } = CreateAgreementByIdV2InputSignatureTypeType.ESIGN;

        [JsonProperty("participantSetsInfo", DefaultValueHandling = DefaultValueHandling.Include)]
        public ParticipantCreateSetInfoV6[] Unnamed { get; set; }

        [JsonProperty("groupId")]
        public string GroupId { get; set; }

        [JsonProperty("message", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Message { get; set; } = "Please review and complete this document";

        [JsonProperty("ccs")]
        public AgreementCcInfo[] CCs { get; set; }

        [JsonProperty("expirationTime")]
        public string ExpirationTime { get; set; }

        [JsonProperty("reminderFrequency")]
        public CreateAgreementByIdV2InputReminderFrequencyType? ReminderFrequency { get; set; }

        [JsonProperty("securityOption")]
        public CreateAgreementByIdV2InputSecurityOptionType SecurityOption { get; set; }

        [JsonProperty("mergeFieldInfo")]
        public MergefieldInfo[] FormField { get; set; }

        [JsonProperty("postSignOption")]
        public PostSigningOption PostSignOption { get; set; }

        [JsonProperty("emailOption", DefaultValueHandling = DefaultValueHandling.Include)]
        public EmailOption EmailOption { get; set; } = new EmailOption();

        [JsonProperty("state", DefaultValueHandling = DefaultValueHandling.Include)]
        internal CreateAgreementByIdV2InputStateType State { get; set; } = CreateAgreementByIdV2InputStateType.INPROCESS;
    }

    public class DocumentFileInfoId
    {
        [JsonProperty("transientDocumentId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Id { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateAgreementByIdV2InputSignatureTypeType
    {
        ESIGN,
        WRITTEN
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateAgreementByIdV2InputReminderFrequencyType
    {
        [EnumMember(Value = "DAILY_UNTIL_SIGNED")]
        DAILYUNTILSIGNED,
        [EnumMember(Value = "WEEKLY_UNTIL_SIGNED")]
        WEEKLYUNTILSIGNED
    }

    public class CreateAgreementByIdV2InputSecurityOptionType
    {
        [JsonProperty("openPassword")]
        public string DocumentPassword { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateAgreementByIdV2InputStateType
    {
        AUTHORING,
        DRAFT,
        [EnumMember(Value = "IN_PROCESS")]
        INPROCESS
    }

    public class CreateAgreementByTemplateV2Input
    {
        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string AgreementName { get; set; }

        [JsonProperty("fileInfos", DefaultValueHandling = DefaultValueHandling.Include)]
        public DocumentFileInfoTemplate[] Library { get; set; }

        [JsonProperty("signatureType", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateAgreementByTemplateV2InputSignatureTypeType SignatureType { get; set; } = CreateAgreementByTemplateV2InputSignatureTypeType.ESIGN;

        [JsonProperty("participantSetsInfo", DefaultValueHandling = DefaultValueHandling.Include)]
        public ParticipantCreateSetInfoV6[] Unnamed { get; set; }

        [JsonProperty("groupId")]
        public string GroupId { get; set; }

        [JsonProperty("message", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Message { get; set; } = "Please review and complete this document";

        [JsonProperty("ccs")]
        public AgreementCcInfo[] CCs { get; set; }

        [JsonProperty("expirationTime")]
        public string ExpirationTime { get; set; }

        [JsonProperty("reminderFrequency")]
        public CreateAgreementByTemplateV2InputReminderFrequencyType? ReminderFrequency { get; set; }

        [JsonProperty("securityOption")]
        public CreateAgreementByTemplateV2InputSecurityOptionType SecurityOption { get; set; }

        [JsonProperty("mergeFieldInfo")]
        public MergefieldInfo[] FormField { get; set; }

        [JsonProperty("postSignOption")]
        public PostSigningOption PostSignOption { get; set; }

        [JsonProperty("emailOption", DefaultValueHandling = DefaultValueHandling.Include)]
        public EmailOption EmailOption { get; set; } = new EmailOption();

        [JsonProperty("state", DefaultValueHandling = DefaultValueHandling.Include)]
        internal CreateAgreementByTemplateV2InputStateType State { get; set; } = CreateAgreementByTemplateV2InputStateType.INPROCESS;
    }

    public class DocumentFileInfoTemplate
    {
        [JsonProperty("libraryDocumentId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string LibraryDocumentId { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateAgreementByTemplateV2InputSignatureTypeType
    {
        ESIGN,
        WRITTEN
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateAgreementByTemplateV2InputReminderFrequencyType
    {
        [EnumMember(Value = "DAILY_UNTIL_SIGNED")]
        DAILYUNTILSIGNED,
        [EnumMember(Value = "WEEKLY_UNTIL_SIGNED")]
        WEEKLYUNTILSIGNED
    }

    public class CreateAgreementByTemplateV2InputSecurityOptionType
    {
        [JsonProperty("openPassword")]
        public string DocumentPassword { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateAgreementByTemplateV2InputStateType
    {
        AUTHORING,
        DRAFT,
        [EnumMember(Value = "IN_PROCESS")]
        INPROCESS
    }

    public class CreateAgreementByUrlV2Input
    {
        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string AgreementName { get; set; }

        [JsonProperty("fileInfos", DefaultValueHandling = DefaultValueHandling.Include)]
        public DocumentFileInfoUrl[] Document { get; set; }

        [JsonProperty("signatureType", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateAgreementByUrlV2InputSignatureTypeType SignatureType { get; set; } = CreateAgreementByUrlV2InputSignatureTypeType.ESIGN;

        [JsonProperty("participantSetsInfo", DefaultValueHandling = DefaultValueHandling.Include)]
        public ParticipantCreateSetInfoV6[] Unnamed { get; set; }

        [JsonProperty("groupId")]
        public string GroupId { get; set; }

        [JsonProperty("message", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Message { get; set; } = "Please review and complete this document";

        [JsonProperty("ccs")]
        public AgreementCcInfo[] CCs { get; set; }

        [JsonProperty("expirationTime")]
        public string ExpirationTime { get; set; }

        [JsonProperty("reminderFrequency")]
        public CreateAgreementByUrlV2InputReminderFrequencyType? ReminderFrequency { get; set; }

        [JsonProperty("securityOption")]
        public CreateAgreementByUrlV2InputSecurityOptionType SecurityOption { get; set; }

        [JsonProperty("mergeFieldInfo")]
        public MergefieldInfo[] FormField { get; set; }

        [JsonProperty("postSignOption")]
        public PostSigningOption PostSignOption { get; set; }

        [JsonProperty("emailOption", DefaultValueHandling = DefaultValueHandling.Include)]
        public EmailOption EmailOption { get; set; } = new EmailOption();

        [JsonProperty("state", DefaultValueHandling = DefaultValueHandling.Include)]
        internal CreateAgreementByUrlV2InputStateType State { get; set; } = CreateAgreementByUrlV2InputStateType.INPROCESS;
    }

    public class DocumentFileInfoUrl
    {
        [JsonProperty("urlFileInfo", DefaultValueHandling = DefaultValueHandling.Include)]
        public URLFileInfo UrlFileInfo { get; set; }
    }

    public class URLFileInfo
    {
        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Url { get; set; }

        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("mimeType", DefaultValueHandling = DefaultValueHandling.Include)]
        public URLFileInfoMimeTypeType MimeType { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum URLFileInfoMimeTypeType
    {
        [EnumMember(Value = "application/pdf")]
        ApplicationPdf,
        [EnumMember(Value = "application/msword")]
        ApplicationMsword,
        [EnumMember(Value = "application/vnd.openxmlformats-officedocument.wordprocessingml.document")]
        ApplicationVndOpenxmlformatsOfficedocumentWordprocessingmlDocument,
        [EnumMember(Value = "application/vnd.ms-excel")]
        ApplicationVndMsExcel,
        [EnumMember(Value = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet")]
        ApplicationVndOpenxmlformatsOfficedocumentSpreadsheetmlSheet,
        [EnumMember(Value = "application/vnd.ms-powerpoint")]
        ApplicationVndMsPowerpoint,
        [EnumMember(Value = "application/vnd.openxmlformats-officedocument.presentationml.presentation")]
        ApplicationVndOpenxmlformatsOfficedocumentPresentationmlPresentation,
        [EnumMember(Value = "text/plain")]
        TextPlain,
        [EnumMember(Value = "text/rtf")]
        TextRtf,
        [EnumMember(Value = "text/csv")]
        TextCsv,
        [EnumMember(Value = "text/html")]
        TextHtml,
        [EnumMember(Value = "image/tiff")]
        ImageTiff,
        [EnumMember(Value = "image/bmp")]
        ImageBmp,
        [EnumMember(Value = "image/gif")]
        ImageGif,
        [EnumMember(Value = "image/jpeg")]
        ImageJpeg,
        [EnumMember(Value = "image/png")]
        ImagePng
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateAgreementByUrlV2InputSignatureTypeType
    {
        ESIGN,
        WRITTEN
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateAgreementByUrlV2InputReminderFrequencyType
    {
        [EnumMember(Value = "DAILY_UNTIL_SIGNED")]
        DAILYUNTILSIGNED,
        [EnumMember(Value = "WEEKLY_UNTIL_SIGNED")]
        WEEKLYUNTILSIGNED
    }

    public class CreateAgreementByUrlV2InputSecurityOptionType
    {
        [JsonProperty("openPassword")]
        public string DocumentPassword { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateAgreementByUrlV2InputStateType
    {
        AUTHORING,
        DRAFT,
        [EnumMember(Value = "IN_PROCESS")]
        INPROCESS
    }

    public class LibraryDocumentCreationResponseV6
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class CreateLibraryDocumentByIdV2Input
    {
        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string TemplateName { get; set; }

        [JsonProperty("templateTypes", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateLibraryDocumentByIdV2InputTemplateTypeTypeItem[] TemplateType { get; set; } = new CreateLibraryDocumentByIdV2InputTemplateTypeTypeItem[]
        {
            (CreateLibraryDocumentByIdV2InputTemplateTypeTypeItem)0
        };

        [JsonProperty("sharingMode", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateLibraryDocumentByIdV2InputSharingModeType SharingMode { get; set; } = CreateLibraryDocumentByIdV2InputSharingModeType.USER;

        [JsonProperty("fileInfos", DefaultValueHandling = DefaultValueHandling.Include)]
        public LibraryDocumentFileInfoId[] Document { get; set; }

        [JsonProperty("state", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateLibraryDocumentByIdV2InputTemplateStateType TemplateState { get; set; } = CreateLibraryDocumentByIdV2InputTemplateStateType.ACTIVE;

        [JsonProperty("groupId")]
        public string GroupId { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateLibraryDocumentByIdV2InputTemplateTypeTypeItem
    {
        DOCUMENT,
        [EnumMember(Value = "FORM_FIELD_LAYER")]
        FORMFIELDLAYER
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateLibraryDocumentByIdV2InputSharingModeType
    {
        USER,
        GROUP,
        ACCOUNT
    }

    public class LibraryDocumentFileInfoId
    {
        [JsonProperty("transientDocumentId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Id { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateLibraryDocumentByIdV2InputTemplateStateType
    {
        AUTHORING,
        ACTIVE
    }

    public class CreateLibraryDocumentByUrlV2Input
    {
        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string TemplateName { get; set; }

        [JsonProperty("templateTypes", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateLibraryDocumentByUrlV2InputTemplateTypeTypeItem[] TemplateType { get; set; } = new CreateLibraryDocumentByUrlV2InputTemplateTypeTypeItem[]
        {
            (CreateLibraryDocumentByUrlV2InputTemplateTypeTypeItem)0
        };

        [JsonProperty("sharingMode", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateLibraryDocumentByUrlV2InputSharingModeType SharingMode { get; set; } = CreateLibraryDocumentByUrlV2InputSharingModeType.USER;

        [JsonProperty("fileInfos", DefaultValueHandling = DefaultValueHandling.Include)]
        public LibraryDocumentFileInfoUrl[] Document { get; set; }

        [JsonProperty("state", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateLibraryDocumentByUrlV2InputTemplateStateType TemplateState { get; set; } = CreateLibraryDocumentByUrlV2InputTemplateStateType.ACTIVE;

        [JsonProperty("groupId")]
        public string GroupNameId { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateLibraryDocumentByUrlV2InputTemplateTypeTypeItem
    {
        DOCUMENT,
        [EnumMember(Value = "FORM_FIELD_LAYER")]
        FORMFIELDLAYER
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateLibraryDocumentByUrlV2InputSharingModeType
    {
        USER,
        GROUP,
        ACCOUNT
    }

    public class LibraryDocumentFileInfoUrl
    {
        [JsonProperty("urlFileInfo", DefaultValueHandling = DefaultValueHandling.Include)]
        public URLFileInfo UrlFileInfo { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateLibraryDocumentByUrlV2InputTemplateStateType
    {
        AUTHORING,
        ACTIVE
    }

    public class AgreementInfoV6
    {
        [JsonProperty("id")]
        public string AgreementId { get; set; }

        [JsonProperty("createdDate")]
        public string CreatedDate { get; set; }

        [JsonProperty("firstReminderDelay")]
        public int FirstReminderDelay { get; set; }

        [JsonProperty("reminderFrequency")]
        public AgreementInfoV6ReminderFrequencyType ReminderFrequency { get; set; }

        [JsonProperty("expiration")]
        public string ExpirationDate { get; set; }

        [JsonProperty("locale")]
        public string Locale { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("name")]
        public string AgreementName { get; set; }

        [JsonProperty("documentVisibilityEnabled")]
        public bool DocumentVisibility { get; set; }

        [JsonProperty("participantSetsInfo")]
        public ParticipantSetInfoV6[] ParticipantSets { get; set; }

        [JsonProperty("signatureType")]
        public AgreementInfoV6SignatureTypeType SignatureType { get; set; }

        [JsonProperty("securityOptions")]
        public string SecurityOptions { get; set; }

        [JsonProperty("status")]
        public AgreementInfoV6StatusType Status { get; set; }

        [JsonProperty("senderEmail")]
        public string SenderEmail { get; set; }

        [JsonProperty("workflowId")]
        public string WorkflowId { get; set; }

        [JsonProperty("ccs")]
        public CcInfo[] CCs { get; set; }

        [JsonProperty("groupId")]
        public string GroupId { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum AgreementInfoV6ReminderFrequencyType
    {
        [EnumMember(Value = "DAILY_UNTIL_SIGNED")]
        DAILYUNTILSIGNED,
        [EnumMember(Value = "WEEKDAILY_UNTIL_SIGNED")]
        WEEKDAILYUNTILSIGNED,
        [EnumMember(Value = "EVERY_OTHER_DAY_UNTIL_SIGNED")]
        EVERYOTHERDAYUNTILSIGNED,
        [EnumMember(Value = "EVERY_THIRD_DAY_UNTIL_SIGNED")]
        EVERYTHIRDDAYUNTILSIGNED,
        [EnumMember(Value = "EVERY_FIFTH_DAY_UNTIL_SIGNED")]
        EVERYFIFTHDAYUNTILSIGNED,
        [EnumMember(Value = "WEEKLY_UNTIL_SIGNED")]
        WEEKLYUNTILSIGNED
    }

    public class ParticipantSetInfoV6
    {
        [JsonProperty("memberInfos")]
        public MemberInfosV6[] ParticipantSetMemberInfos { get; set; }

        [JsonProperty("order")]
        public int Order { get; set; }

        [JsonProperty("role")]
        public ParticipantSetInfoV6RoleType Role { get; set; }

        [JsonProperty("name")]
        public string ParticipantSetName { get; set; }

        [JsonProperty("privateMessage")]
        public string ParticipantSetPrivateMesssage { get; set; }

        [JsonProperty("visiblePages")]
        public string[] ParticipantSetVisiblePages { get; set; }
    }

    public class MemberInfosV6
    {
        [JsonProperty("email")]
        public string ParticipantEmail { get; set; }

        [JsonProperty("securityOption")]
        public MemberInfosV6UnnamedType Unnamed { get; set; }
    }

    public class MemberInfosV6UnnamedType
    {
        [JsonProperty("authenticationMethod")]
        public MemberInfosV6UnnamedTypeAuthenticationType Authentication { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }

        [JsonProperty("phoneInfo")]
        public MemberInfosV6UnnamedTypeUnnamedType Unnamed { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ParticipantSetInfoV6RoleType
    {
        SIGNER,
        APPROVER,
        ACCEPTOR,
        [EnumMember(Value = "CERTIFIED_RECIPIENT")]
        CERTIFIEDRECIPIENT,
        [EnumMember(Value = "FORM_FILLER")]
        FORMFILLER,
        [EnumMember(Value = "DELEGATE_TO_SIGNER")]
        DELEGATETOSIGNER,
        [EnumMember(Value = "DELEGATE_TO_APPROVER")]
        DELEGATETOAPPROVER,
        [EnumMember(Value = "DELEGATE_TO_ACCEPTOR")]
        DELEGATETOACCEPTOR,
        [EnumMember(Value = "DELEGATE_TO_CERTIFIED_RECIPIENT")]
        DELEGATETOCERTIFIEDRECIPIENT,
        [EnumMember(Value = "DELEGATE_TO_FORM_FILLER")]
        DELEGATETOFORMFILLER,
        SHARE
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum AgreementInfoV6SignatureTypeType
    {
        ESIGN,
        WRITTEN
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum AgreementInfoV6StatusType
    {
        [EnumMember(Value = "OUT_FOR_SIGNATURE")]
        OUTFORSIGNATURE,
        [EnumMember(Value = "OUT_FOR_DELIVERY")]
        OUTFORDELIVERY,
        [EnumMember(Value = "OUT_FOR_ACCEPTANCE")]
        OUTFORACCEPTANCE,
        [EnumMember(Value = "OUT_FOR_FORM_FILLING")]
        OUTFORFORMFILLING,
        [EnumMember(Value = "OUT_FOR_APPROVAL")]
        OUTFORAPPROVAL,
        AUTHORING,
        CANCELLED,
        SIGNED,
        APPROVED,
        DELIVERED,
        ACCEPTED,
        [EnumMember(Value = "FORM_FILLED")]
        FORMFILLED,
        EXPIRED,
        ARCHIVED,
        PREFILL,
        [EnumMember(Value = "WIDGET_WAITING_FOR_VERIFICATION")]
        WIdGETWAITINGFORVERIFICATION,
        DRAFT,
        [EnumMember(Value = "DOCUMENTS_NOT_YET_PROCESSED")]
        DOCUMENTSNOTYETPROCESSED,
        [EnumMember(Value = "WAITING_FOR_FAXIN")]
        WAITINGFORFAXIN,
        [EnumMember(Value = "WAITING_FOR_VERIFICATION")]
        WAITINGFORVERIFICATION
    }

    public class CcInfo
    {
        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("visiblePages")]
        public string[] VisiblePages { get; set; }
    }

    public class AgreementDocumentsV6
    {
        [JsonProperty("documents")]
        public DocumentV6[] Documents { get; set; }

        [JsonProperty("supportingDocuments")]
        public SupportingDocumentV6[] SupportingDocuments { get; set; }
    }

    public class DocumentV6
    {
        [JsonProperty("id")]
        public string DocumentId { get; set; }

        [JsonProperty("mimeType")]
        public string MimeType { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("numPages")]
        public int NumPages { get; set; }
    }

    public class SupportingDocumentV6
    {
        [JsonProperty("displayLabel")]
        public string SupportingDocumentName { get; set; }

        [JsonProperty("fieldName")]
        public string SupportingDocumentFieldName { get; set; }

        [JsonProperty("mimeType")]
        public string SupportingDocumentMimeType { get; set; }

        [JsonProperty("numPages")]
        public int SupportingDocumentPages { get; set; }

        [JsonProperty("id")]
        public string SupportingDocumentId { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum supportingDocumentContentFormatInput
    {
        ORIGINAL,
        [EnumMember(Value = "CONVERTED_PDF")]
        CONVERTEDPDF
    }

    public class LibraryDocuments
    {
        [JsonProperty("page")]
        public Page Page { get; set; }

        [JsonProperty("libraryDocumentList")]
        public LibraryDocument[] LibraryDocumentList { get; set; }
    }

    public class LibraryDocument
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("hidden")]
        public bool Hidden { get; set; }

        [JsonProperty("templateTypes")]
        public LibraryDocumentTemplateTypeSTypeItem[] TemplateTypeS { get; set; }

        [JsonProperty("modifiedDate")]
        public string ModifiedDate { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("sharingMode")]
        public LibraryDocumentSharingModeType SharingMode { get; set; }

        [JsonProperty("creatorEmail")]
        public string CreatorEmail { get; set; }

        [JsonProperty("groupId")]
        public string GroupId { get; set; }

        [JsonProperty("status")]
        public LibraryDocumentStatusType Status { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum LibraryDocumentTemplateTypeSTypeItem
    {
        DOCUMENT,
        [EnumMember(Value = "FORM_FIELD_LAYER")]
        FORMFIELDLAYER
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum LibraryDocumentSharingModeType
    {
        USER,
        GROUP,
        ACCOUNT,
        GLOBAL
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum LibraryDocumentStatusType
    {
        AUTHORING,
        ACTIVE,
        REMOVED
    }

    public class WebhookCreationResponse
    {
        [JsonProperty("webhookId")]
        public string WebhookId { get; set; }
    }

    public class CreateWebhookForAgreementCreatedEventInput
    {
        [JsonProperty("webhookUrlInfo", DefaultValueHandling = DefaultValueHandling.Include)]
        public WebhookUrlInfo WebhookUrlInfo { get; set; } = new WebhookUrlInfo();

        [JsonProperty("state", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string State { get; set; } = "ACTIVE";

        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("scope", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateWebhookForAgreementCreatedEventInputScopeType Scope { get; set; }

        [JsonProperty("webhookSubscriptionEvents", DefaultValueHandling = DefaultValueHandling.Include)]
        internal CreateWebhookForAgreementCreatedEventInputWebhookSubscriptionEventsTypeItem[] WebhookSubscriptionEvents { get; set; } = new CreateWebhookForAgreementCreatedEventInputWebhookSubscriptionEventsTypeItem[]
        {
            (CreateWebhookForAgreementCreatedEventInputWebhookSubscriptionEventsTypeItem)0
        };

        [JsonProperty("webhookConditionalParams", DefaultValueHandling = DefaultValueHandling.Include)]
        public WebhookConditionalParamsForAgreementCreatedEvent WebhookConditionalParams { get; set; } = new WebhookConditionalParamsForAgreementCreatedEvent();
    }

    public class WebhookUrlInfo
    {
        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Url { get; set; } = "#{listCallbackUrl()}";
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateWebhookForAgreementCreatedEventInputScopeType
    {
        [EnumMember(Value = "Any agreement in my account")]
        AnyAgreementInMyAccount,
        [EnumMember(Value = "Any agreement in my group")]
        AnyAgreementInMyGroup,
        [EnumMember(Value = "Any of my agreements")]
        AnyOfMyAgreements
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateWebhookForAgreementCreatedEventInputWebhookSubscriptionEventsTypeItem
    {
        [EnumMember(Value = "AGREEMENT_CREATED")]
        AGREEMENTCREATED
    }

    public class WebhookConditionalParamsForAgreementCreatedEvent
    {
        [JsonProperty("webhookAgreementEvents", DefaultValueHandling = DefaultValueHandling.Include)]
        public WebhookAgreementEventsForAgreementCreatedEvent WebhookAgreementEvents { get; set; } = new WebhookAgreementEventsForAgreementCreatedEvent();
    }

    public class WebhookAgreementEventsForAgreementCreatedEvent
    {
        [JsonProperty("includeDetailedInfo", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? IncludeDetailedInfo { get; set; } = false;

        [JsonProperty("includeParticipantsInfo", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? IncludeParticipantsInfo { get; set; } = false;
    }

    public class CreateWebhookForAgreementSignatureRequestedEventInput
    {
        [JsonProperty("state", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string State { get; set; } = "ACTIVE";

        [JsonProperty("webhookUrlInfo", DefaultValueHandling = DefaultValueHandling.Include)]
        public WebhookUrlInfo WebhookUrlInfo { get; set; } = new WebhookUrlInfo();

        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("scope", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateWebhookForAgreementSignatureRequestedEventInputScopeType Scope { get; set; }

        [JsonProperty("resourceType", DefaultValueHandling = DefaultValueHandling.Include)]
        internal CreateWebhookForAgreementSignatureRequestedEventInputResourceTypeType ResourceType { get; set; } = CreateWebhookForAgreementSignatureRequestedEventInputResourceTypeType.AGREEMENT;

        [JsonProperty("resourceId")]
        public string ResourceId { get; set; }

        [JsonProperty("webhookSubscriptionEvents", DefaultValueHandling = DefaultValueHandling.Include)]
        internal CreateWebhookForAgreementSignatureRequestedEventInputWebhookSubscriptionEventsTypeItem[] WebhookSubscriptionEvents { get; set; } = new CreateWebhookForAgreementSignatureRequestedEventInputWebhookSubscriptionEventsTypeItem[]
        {
            (CreateWebhookForAgreementSignatureRequestedEventInputWebhookSubscriptionEventsTypeItem)0
        };

        [JsonProperty("webhookConditionalParams", DefaultValueHandling = DefaultValueHandling.Include)]
        public WebhookConditionalParams WebhookConditionalParams { get; set; } = new WebhookConditionalParams();
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateWebhookForAgreementSignatureRequestedEventInputScopeType
    {
        [EnumMember(Value = "Any agreement in my account")]
        AnyAgreementInMyAccount,
        [EnumMember(Value = "Any agreement in my group")]
        AnyAgreementInMyGroup,
        [EnumMember(Value = "Any of my agreements")]
        AnyOfMyAgreements,
        [EnumMember(Value = "A specific agreement")]
        ASpecificAgreement
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateWebhookForAgreementSignatureRequestedEventInputResourceTypeType
    {
        AGREEMENT
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateWebhookForAgreementSignatureRequestedEventInputWebhookSubscriptionEventsTypeItem
    {
        [EnumMember(Value = "AGREEMENT_ACTION_REQUESTED")]
        AGREEMENTACTIONREQUESTED
    }

    public class WebhookConditionalParams
    {
        [JsonProperty("webhookAgreementEvents", DefaultValueHandling = DefaultValueHandling.Include)]
        public WebhookAgreementEvents WebhookAgreementEvents { get; set; } = new WebhookAgreementEvents();
    }

    public class WebhookAgreementEvents
    {
        [JsonProperty("includeDetailedInfo", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? IncludeDetailedInfo { get; set; } = false;

        [JsonProperty("includeParticipantsInfo", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? IncludeParticipantsInfo { get; set; } = false;

        [JsonProperty("includeDocumentsInfo", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? IncludeDocumentsInfo { get; set; } = false;
    }

    public class CreateWebhookForAgreementSignedEventInput
    {
        [JsonProperty("state", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string State { get; set; } = "ACTIVE";

        [JsonProperty("webhookUrlInfo", DefaultValueHandling = DefaultValueHandling.Include)]
        public WebhookUrlInfo WebhookUrlInfo { get; set; } = new WebhookUrlInfo();

        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("scope", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateWebhookForAgreementSignedEventInputScopeType Scope { get; set; }

        [JsonProperty("resourceType", DefaultValueHandling = DefaultValueHandling.Include)]
        internal CreateWebhookForAgreementSignedEventInputResourceTypeType ResourceType { get; set; } = CreateWebhookForAgreementSignedEventInputResourceTypeType.AGREEMENT;

        [JsonProperty("resourceId")]
        public string ResourceId { get; set; }

        [JsonProperty("webhookSubscriptionEvents", DefaultValueHandling = DefaultValueHandling.Include)]
        internal CreateWebhookForAgreementSignedEventInputWebhookSubscriptionEventsTypeItem[] WebhookSubscriptionEvents { get; set; } = new CreateWebhookForAgreementSignedEventInputWebhookSubscriptionEventsTypeItem[]
        {
            (CreateWebhookForAgreementSignedEventInputWebhookSubscriptionEventsTypeItem)0
        };

        [JsonProperty("webhookConditionalParams", DefaultValueHandling = DefaultValueHandling.Include)]
        public WebhookConditionalParamsForAgreementSignedEvent WebhookConditionalParams { get; set; } = new WebhookConditionalParamsForAgreementSignedEvent();
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateWebhookForAgreementSignedEventInputScopeType
    {
        [EnumMember(Value = "Any agreement in my account")]
        AnyAgreementInMyAccount,
        [EnumMember(Value = "Any agreement in my group")]
        AnyAgreementInMyGroup,
        [EnumMember(Value = "Any of my agreements")]
        AnyOfMyAgreements,
        [EnumMember(Value = "A specific agreement")]
        ASpecificAgreement
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateWebhookForAgreementSignedEventInputResourceTypeType
    {
        AGREEMENT
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateWebhookForAgreementSignedEventInputWebhookSubscriptionEventsTypeItem
    {
        [EnumMember(Value = "AGREEMENT_WORKFLOW_COMPLETED")]
        AGREEMENTWORKFLOWCOMPLETED
    }

    public class WebhookConditionalParamsForAgreementSignedEvent
    {
        [JsonProperty("webhookAgreementEvents", DefaultValueHandling = DefaultValueHandling.Include)]
        public WebhookAgreementEventsForSignedEvent WebhookAgreementEvents { get; set; } = new WebhookAgreementEventsForSignedEvent();
    }

    public class WebhookAgreementEventsForSignedEvent
    {
        [JsonProperty("includeDetailedInfo", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? IncludeDetailedInfo { get; set; } = false;

        [JsonProperty("includeParticipantsInfo", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? IncludeParticipantsInfo { get; set; } = false;

        [JsonProperty("includeDocumentsInfo", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? IncludeDocumentsInfo { get; set; } = false;

        [JsonProperty("includeSignedDocuments", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? IncludeSignedDocuments { get; set; } = false;
    }

    public class CreateWebhookForAgreementStatusUpdatedInput
    {
        [JsonProperty("state", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string State { get; set; } = "ACTIVE";

        [JsonProperty("webhookUrlInfo", DefaultValueHandling = DefaultValueHandling.Include)]
        public WebhookUrlInfo WebhookUrlInfo { get; set; } = new WebhookUrlInfo();

        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("scope", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateWebhookForAgreementStatusUpdatedInputScopeType Scope { get; set; }

        [JsonProperty("resourceType", DefaultValueHandling = DefaultValueHandling.Include)]
        internal CreateWebhookForAgreementStatusUpdatedInputResourceTypeType ResourceType { get; set; } = CreateWebhookForAgreementStatusUpdatedInputResourceTypeType.AGREEMENT;

        [JsonProperty("resourceId")]
        public string ResourceId { get; set; }

        [JsonProperty("webhookSubscriptionEvents", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateWebhookForAgreementStatusUpdatedInputWebhookSubscriptionEventsTypeItem[] WebhookSubscriptionEvents { get; set; }

        [JsonProperty("webhookConditionalParams", DefaultValueHandling = DefaultValueHandling.Include)]
        public WebhookConditionalParamsForAgreementStatusChange WebhookConditionalParams { get; set; } = new WebhookConditionalParamsForAgreementStatusChange();
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateWebhookForAgreementStatusUpdatedInputScopeType
    {
        [EnumMember(Value = "Any agreement in my account")]
        AnyAgreementInMyAccount,
        [EnumMember(Value = "Any agreement in my group")]
        AnyAgreementInMyGroup,
        [EnumMember(Value = "Any of my agreements")]
        AnyOfMyAgreements,
        [EnumMember(Value = "A specific agreement")]
        ASpecificAgreement
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateWebhookForAgreementStatusUpdatedInputResourceTypeType
    {
        AGREEMENT
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateWebhookForAgreementStatusUpdatedInputWebhookSubscriptionEventsTypeItem
    {
        [EnumMember(Value = "When an agreement is created")]
        WhenAnAgreementIsCreated,
        [EnumMember(Value = "When a participant completes their action")]
        WhenAParticipantCompletesTheirAction,
        [EnumMember(Value = "When an agreement workflow is completed successfully")]
        WhenAnAgreementWorkflowIsCompletedSuccessfully,
        [EnumMember(Value = "When an agreement is cancelled")]
        WhenAnAgreementIsCancelled,
        [EnumMember(Value = "When an agreement is rejected by a participant")]
        WhenAnAgreementIsRejectedByAParticipant,
        [EnumMember(Value = "When an agreement expires")]
        WhenAnAgreementExpires
    }

    public class WebhookConditionalParamsForAgreementStatusChange
    {
        [JsonProperty("webhookAgreementEvents", DefaultValueHandling = DefaultValueHandling.Include)]
        public WebhookAgreementEventsForStatusChange WebhookAgreementEvents { get; set; } = new WebhookAgreementEventsForStatusChange();
    }

    public class WebhookAgreementEventsForStatusChange
    {
        [JsonProperty("includeDetailedInfo", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? IncludeDetailedInfo { get; set; } = false;

        [JsonProperty("includeParticipantsInfo", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? IncludeParticipantsInfo { get; set; } = false;

        [JsonProperty("includeDocumentsInfo", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? IncludeDocumentsInfo { get; set; } = false;

        [JsonProperty("includeSignedDocuments", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? IncludeSignedDocuments { get; set; } = false;
    }

    public class CreateWebhookGenericInput
    {
        [JsonProperty("state", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string State { get; set; } = "ACTIVE";

        [JsonProperty("webhookUrlInfo", DefaultValueHandling = DefaultValueHandling.Include)]
        public WebhookUrlInfo WebhookUrlInfo { get; set; } = new WebhookUrlInfo();

        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("scope", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateWebhookGenericInputScopeType Scope { get; set; }

        [JsonProperty("resourceType")]
        public CreateWebhookGenericInputResourceTypeType? ResourceType { get; set; }

        [JsonProperty("resourceId")]
        public string ResourceId { get; set; }

        [JsonProperty("webhookSubscriptionEvents", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateWebhookGenericInputWebhookSubscriptionEventsTypeItem[] WebhookSubscriptionEvents { get; set; }

        [JsonProperty("webhookConditionalParams")]
        public WebhookConditionalParamsGeneric WebhookConditionalParams { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateWebhookGenericInputScopeType
    {
        [EnumMember(Value = "Any resource in my account")]
        AnyResourceInMyAccount,
        [EnumMember(Value = "Any resource in my group")]
        AnyResourceInMyGroup,
        [EnumMember(Value = "Any of my resource")]
        AnyOfMyResource,
        [EnumMember(Value = "A specific resource")]
        ASpecificResource
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateWebhookGenericInputResourceTypeType
    {
        Agreement,
        [EnumMember(Value = "Mega Sign")]
        MegaSign,
        [EnumMember(Value = "Web Form")]
        WebForm
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateWebhookGenericInputWebhookSubscriptionEventsTypeItem
    {
        [EnumMember(Value = "When any agreement event occurs")]
        WhenAnyAgreementEventOccurs,
        [EnumMember(Value = "When an agreement is created")]
        WhenAnAgreementIsCreated,
        [EnumMember(Value = "When an agreement is sent")]
        WhenAnAgreementIsSent,
        [EnumMember(Value = "When a participant completes their action")]
        WhenAParticipantCompletesTheirAction,
        [EnumMember(Value = "When an agreement workflow is completed successfully")]
        WhenAnAgreementWorkflowIsCompletedSuccessfully,
        [EnumMember(Value = "When an agreement expires")]
        WhenAnAgreementExpires,
        [EnumMember(Value = "When an agreement is deleted")]
        WhenAnAgreementIsDeleted,
        [EnumMember(Value = "When an agreement is cancelled")]
        WhenAnAgreementIsCancelled,
        [EnumMember(Value = "When an agreement is rejected by a participant")]
        WhenAnAgreementIsRejectedByAParticipant,
        [EnumMember(Value = "When an agreement is shared")]
        WhenAnAgreementIsShared,
        [EnumMember(Value = "When an agreement is delegated")]
        WhenAnAgreementIsDelegated,
        [EnumMember(Value = "When an agreement participant is replaced")]
        WhenAnAgreementParticipantIsReplaced,
        [EnumMember(Value = "When an agreement is modified")]
        WhenAnAgreementIsModified,
        [EnumMember(Value = "When an agreement modification is acknowledged")]
        WhenAnAgreementModificationIsAcknowledged,
        [EnumMember(Value = "When an agreement email is viewed by a participant")]
        WhenAnAgreementEmailIsViewedByAParticipant,
        [EnumMember(Value = "When an agreement email gets bounced")]
        WhenAnAgreementEmailGetsBounced,
        [EnumMember(Value = "When an agreement creation fails")]
        WhenAnAgreementCreationFails,
        [EnumMember(Value = "When an offline agreement is synced")]
        WhenAnOfflineAgreementIsSynced,
        [EnumMember(Value = "When an agreement is uploaded by sender")]
        WhenAnAgreementIsUploadedBySender,
        [EnumMember(Value = "When an agreement is vaulted")]
        WhenAnAgreementIsVaulted,
        [EnumMember(Value = "When an agreement participant is authenticated through social identity")]
        WhenAnAgreementParticipantIsAuthenticatedThroughSocialIdentity,
        [EnumMember(Value = "When an agreement participant is authenticated through KBA")]
        WhenAnAgreementParticipantIsAuthenticatedThroughKBA,
        [EnumMember(Value = "When any mega sign event occurs")]
        WhenAnyMegaSignEventOccurs,
        [EnumMember(Value = "When a mega sign is created")]
        WhenAMegaSignIsCreated,
        [EnumMember(Value = "When a mega sign is shared")]
        WhenAMegaSignIsShared,
        [EnumMember(Value = "When a mega sign is recalled")]
        WhenAMegaSignIsRecalled,
        [EnumMember(Value = "When any web form event occurs")]
        WhenAnyWebFormEventOccurs,
        [EnumMember(Value = "When a web form is created")]
        WhenAWebFormIsCreated,
        [EnumMember(Value = "When a web form is enabled")]
        WhenAWebFormIsEnabled,
        [EnumMember(Value = "When a web form is disabled")]
        WhenAWebFormIsDisabled,
        [EnumMember(Value = "When a web form is modified")]
        WhenAWebFormIsModified,
        [EnumMember(Value = "When a web form is shared")]
        WhenAWebFormIsShared,
        [EnumMember(Value = "When a web form creation fails")]
        WhenAWebFormCreationFails
    }

    public class WebhookConditionalParamsGeneric
    {
        [JsonProperty("webhookAgreementEvents")]
        public WebhookAgreementEventsGeneric WebhookAgreementEvents { get; set; }

        [JsonProperty("webhookMegaSignEvents")]
        public WebhookMegaSignEventsGeneric WebhookMegaSignEvents { get; set; }

        [JsonProperty("webhookWidgetEvents")]
        public WebhookWidgetEventsGeneric WebhookWidgetEvents { get; set; }
    }

    public class WebhookAgreementEventsGeneric
    {
        [JsonProperty("includeDetailedInfo")]
        public bool? IncludeDetailedInfo { get; set; }

        [JsonProperty("includeParticipantsInfo")]
        public bool? IncludeParticipantsInfo { get; set; }

        [JsonProperty("includeDocumentsInfo")]
        public bool? IncludeDocumentsInfo { get; set; }

        [JsonProperty("includeSignedDocuments")]
        public bool? IncludeSignedDocuments { get; set; }
    }

    public class WebhookMegaSignEventsGeneric
    {
        [JsonProperty("includeDetailedInfo")]
        public bool? IncludeDetailedInfo { get; set; }
    }

    public class WebhookWidgetEventsGeneric
    {
        [JsonProperty("includeDetailedInfo")]
        public bool? IncludeDetailedInfo { get; set; }

        [JsonProperty("includeParticipantsInfo")]
        public bool? IncludeParticipantsInfo { get; set; }

        [JsonProperty("includeDocumentsInfo")]
        public bool? IncludeDocumentsInfo { get; set; }
    }

    public class CreateWebhookForWebFormAgreementEventInput
    {
        [JsonProperty("state", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string State { get; set; } = "ACTIVE";

        [JsonProperty("webhookUrlInfo", DefaultValueHandling = DefaultValueHandling.Include)]
        public WebhookUrlInfo WebhookUrlInfo { get; set; } = new WebhookUrlInfo();

        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("scope", DefaultValueHandling = DefaultValueHandling.Include)]
        internal CreateWebhookForWebFormAgreementEventInputScopeType Scope { get; set; } = CreateWebhookForWebFormAgreementEventInputScopeType.RESOURCE;

        [JsonProperty("pageSize", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateWebhookForWebFormAgreementEventInputPageSizeType? PageSize { get; set; } = CreateWebhookForWebFormAgreementEventInputPageSizeType._50;

        [JsonProperty("resourceType", DefaultValueHandling = DefaultValueHandling.Include)]
        internal CreateWebhookForWebFormAgreementEventInputResourceTypeType ResourceType { get; set; } = CreateWebhookForWebFormAgreementEventInputResourceTypeType.WIdGET;

        [JsonProperty("resourceId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ResourceId { get; set; }

        [JsonProperty("webhookSubscriptionEvents", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateWebhookForWebFormAgreementEventInputWebhookSubscriptionEventsTypeItem[] WebhookSubscriptionEvents { get; set; }

        [JsonProperty("webhookConditionalParams", DefaultValueHandling = DefaultValueHandling.Include)]
        public WebhookConditionalParamsForAgreementStatusChange WebhookConditionalParams { get; set; } = new WebhookConditionalParamsForAgreementStatusChange();
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateWebhookForWebFormAgreementEventInputScopeType
    {
        RESOURCE
    }

    public enum CreateWebhookForWebFormAgreementEventInputPageSizeType
    {
        _50 = 50,
        _100 = 100,
        _200 = 200,
        _300 = 300,
        _400 = 400,
        _500 = 500
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateWebhookForWebFormAgreementEventInputResourceTypeType
    {
        [EnumMember(Value = "WIDGET")]
        WIdGET
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateWebhookForWebFormAgreementEventInputWebhookSubscriptionEventsTypeItem
    {
        [EnumMember(Value = "When any web form agreement event occurs")]
        WhenAnyWebFormAgreementEventOccurs,
        [EnumMember(Value = "When a web form agreement is created")]
        WhenAWebFormAgreementIsCreated,
        [EnumMember(Value = "When a web form agreement is sent")]
        WhenAWebFormAgreementIsSent,
        [EnumMember(Value = "When a web form agreement participant completes their action")]
        WhenAWebFormAgreementParticipantCompletesTheirAction,
        [EnumMember(Value = "When a web form agreement workflow is completed successfully")]
        WhenAWebFormAgreementWorkflowIsCompletedSuccessfully,
        [EnumMember(Value = "When a web form agreement is cancelled")]
        WhenAWebFormAgreementIsCancelled,
        [EnumMember(Value = "When a web form agreement is rejected by a participant")]
        WhenAWebFormAgreementIsRejectedByAParticipant,
        [EnumMember(Value = "When a web form agreement expires")]
        WhenAWebFormAgreementExpires
    }

    public class CreateWebhookForGroupEventInput
    {
        [JsonProperty("state", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string State { get; set; } = "ACTIVE";

        [JsonProperty("webhookUrlInfo", DefaultValueHandling = DefaultValueHandling.Include)]
        public WebhookUrlInfo WebhookUrlInfo { get; set; } = new WebhookUrlInfo();

        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("scope", DefaultValueHandling = DefaultValueHandling.Include)]
        internal CreateWebhookForGroupEventInputScopeType Scope { get; set; } = CreateWebhookForGroupEventInputScopeType.AnyResourceInMyGroup;

        [JsonProperty("resourceId")]
        public string ResourceId { get; set; }

        [JsonProperty("webhookSubscriptionEvents", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateWebhookForGroupEventInputWebhookSubscriptionEventsTypeItem[] WebhookSubscriptionEvents { get; set; }

        [JsonProperty("webhookConditionalParams")]
        public WebhookConditionalParamsGeneric WebhookConditionalParams { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateWebhookForGroupEventInputScopeType
    {
        [EnumMember(Value = "Any resource in my group")]
        AnyResourceInMyGroup
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateWebhookForGroupEventInputWebhookSubscriptionEventsTypeItem
    {
        [EnumMember(Value = "When any agreement event occurs")]
        WhenAnyAgreementEventOccurs,
        [EnumMember(Value = "When an agreement is created")]
        WhenAnAgreementIsCreated,
        [EnumMember(Value = "When an agreement is sent")]
        WhenAnAgreementIsSent,
        [EnumMember(Value = "When a participant completes their action")]
        WhenAParticipantCompletesTheirAction,
        [EnumMember(Value = "When an agreement workflow is completed successfully")]
        WhenAnAgreementWorkflowIsCompletedSuccessfully,
        [EnumMember(Value = "When an agreement expires")]
        WhenAnAgreementExpires,
        [EnumMember(Value = "When an agreement is deleted")]
        WhenAnAgreementIsDeleted,
        [EnumMember(Value = "When an agreement is cancelled")]
        WhenAnAgreementIsCancelled,
        [EnumMember(Value = "When an agreement is rejected by a participant")]
        WhenAnAgreementIsRejectedByAParticipant,
        [EnumMember(Value = "When an agreement is shared")]
        WhenAnAgreementIsShared,
        [EnumMember(Value = "When an agreement is delegated")]
        WhenAnAgreementIsDelegated,
        [EnumMember(Value = "When an agreement participant is replaced")]
        WhenAnAgreementParticipantIsReplaced,
        [EnumMember(Value = "When an agreement is modified")]
        WhenAnAgreementIsModified,
        [EnumMember(Value = "When an agreement modification is acknowledged")]
        WhenAnAgreementModificationIsAcknowledged,
        [EnumMember(Value = "When an agreement email is viewed by a participant")]
        WhenAnAgreementEmailIsViewedByAParticipant,
        [EnumMember(Value = "When an agreement email gets bounced")]
        WhenAnAgreementEmailGetsBounced,
        [EnumMember(Value = "When an agreement creation fails")]
        WhenAnAgreementCreationFails,
        [EnumMember(Value = "When an offline agreement is synced")]
        WhenAnOfflineAgreementIsSynced,
        [EnumMember(Value = "When an agreement is uploaded by sender")]
        WhenAnAgreementIsUploadedBySender,
        [EnumMember(Value = "When an agreement is vaulted")]
        WhenAnAgreementIsVaulted,
        [EnumMember(Value = "When an agreement participant is authenticated through social identity")]
        WhenAnAgreementParticipantIsAuthenticatedThroughSocialIdentity,
        [EnumMember(Value = "When an agreement participant is authenticated through KBA")]
        WhenAnAgreementParticipantIsAuthenticatedThroughKBA,
        [EnumMember(Value = "When any mega sign event occurs")]
        WhenAnyMegaSignEventOccurs,
        [EnumMember(Value = "When a mega sign is created")]
        WhenAMegaSignIsCreated,
        [EnumMember(Value = "When a mega sign is shared")]
        WhenAMegaSignIsShared,
        [EnumMember(Value = "When a mega sign is recalled")]
        WhenAMegaSignIsRecalled,
        [EnumMember(Value = "When any web form event occurs")]
        WhenAnyWebFormEventOccurs,
        [EnumMember(Value = "When a web form is created")]
        WhenAWebFormIsCreated,
        [EnumMember(Value = "When a web form is enabled")]
        WhenAWebFormIsEnabled,
        [EnumMember(Value = "When a web form is disabled")]
        WhenAWebFormIsDisabled,
        [EnumMember(Value = "When a web form is modified")]
        WhenAWebFormIsModified,
        [EnumMember(Value = "When a web form is shared")]
        WhenAWebFormIsShared,
        [EnumMember(Value = "When a web form creation fails")]
        WhenAWebFormCreationFails
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Adobeacrobatsignsand;

    public partial class WorkflowManagedActions
    {
        public AdobeacrobatsignsandActions Adobeacrobatsignsand(string connectionId) => new AdobeacrobatsignsandActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public AdobeacrobatsignsandTriggers Adobeacrobatsignsand(string connectionId) => new AdobeacrobatsignsandTriggers(connectionId);
    }
}