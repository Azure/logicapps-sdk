//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Lexpowersign
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class LexpowersignActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lexpowersign")]
        public IBodyWorkflowAction<ConsentPage, ApiConnectionActionConfiguration> RetrieveConsentPage(Expression<Func<string>> cpId, Expression<Func<string>> contentType)
        {
            var __workflow_cpId = WorkflowExpression.Compile(cpId, nameof(cpId), required: true);
            var __workflow_contentType = WorkflowExpression.Compile(contentType, nameof(contentType), required: true);
            return new DeferredBodyAction<ConsentPage, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/consentPages/{0}", __workflow_cpId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(__workflow_contentType);
                return new ApiConnectionAction<ConsentPage>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lexpowersign")]
        public IBodyWorkflowAction<ConsentPages, ApiConnectionActionConfiguration> SearchConsentPages(Expression<Func<string>> text = null, Expression<Func<string>> itemsIsDefault = null, Expression<Func<string>> itemsIsDisabled = null, Expression<Func<string>> itemsName = null, Expression<Func<string>> itemsStepType = null, Expression<Func<string>> itemsClientId = null, Expression<Func<string>> itemsCreated = null, Expression<Func<string>> itemsUpdated = null, Expression<Func<string>> sortBy = null, Expression<Func<string>> sortOrder = null, Expression<Func<string>> itemsPerPage = null, Expression<Func<string>> pageIndex = null)
        {
            var __workflow_text = WorkflowExpression.Compile(text, nameof(text), required: false);
            var __workflow_itemsIsDefault = WorkflowExpression.Compile(itemsIsDefault, nameof(itemsIsDefault), required: false);
            var __workflow_itemsIsDisabled = WorkflowExpression.Compile(itemsIsDisabled, nameof(itemsIsDisabled), required: false);
            var __workflow_itemsName = WorkflowExpression.Compile(itemsName, nameof(itemsName), required: false);
            var __workflow_itemsStepType = WorkflowExpression.Compile(itemsStepType, nameof(itemsStepType), required: false);
            var __workflow_itemsClientId = WorkflowExpression.Compile(itemsClientId, nameof(itemsClientId), required: false);
            var __workflow_itemsCreated = WorkflowExpression.Compile(itemsCreated, nameof(itemsCreated), required: false);
            var __workflow_itemsUpdated = WorkflowExpression.Compile(itemsUpdated, nameof(itemsUpdated), required: false);
            var __workflow_sortBy = WorkflowExpression.Compile(sortBy, nameof(sortBy), required: false);
            var __workflow_sortOrder = WorkflowExpression.Compile(sortOrder, nameof(sortOrder), required: false);
            var __workflow_itemsPerPage = WorkflowExpression.Compile(itemsPerPage, nameof(itemsPerPage), required: false);
            var __workflow_pageIndex = WorkflowExpression.Compile(pageIndex, nameof(pageIndex), required: false);
            return new DeferredBodyAction<ConsentPages, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/consentPages";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_text != null)
                    callPayload.Queries["text"] = ExpressionConverter.Convert(__workflow_text);
                if (__workflow_itemsIsDefault != null)
                    callPayload.Queries["items.isDefault"] = ExpressionConverter.Convert(__workflow_itemsIsDefault);
                if (__workflow_itemsIsDisabled != null)
                    callPayload.Queries["items.isDisabled"] = ExpressionConverter.Convert(__workflow_itemsIsDisabled);
                if (__workflow_itemsName != null)
                    callPayload.Queries["items.name"] = ExpressionConverter.Convert(__workflow_itemsName);
                if (__workflow_itemsStepType != null)
                    callPayload.Queries["items.stepType"] = ExpressionConverter.Convert(__workflow_itemsStepType);
                if (__workflow_itemsClientId != null)
                    callPayload.Queries["items.clientId"] = ExpressionConverter.Convert(__workflow_itemsClientId);
                if (__workflow_itemsCreated != null)
                    callPayload.Queries["items.created"] = ExpressionConverter.Convert(__workflow_itemsCreated);
                if (__workflow_itemsUpdated != null)
                    callPayload.Queries["items.updated"] = ExpressionConverter.Convert(__workflow_itemsUpdated);
                if (__workflow_sortBy != null)
                    callPayload.Queries["sortBy"] = ExpressionConverter.Convert(__workflow_sortBy);
                if (__workflow_sortOrder != null)
                    callPayload.Queries["sortOrder"] = ExpressionConverter.Convert(__workflow_sortOrder);
                if (__workflow_itemsPerPage != null)
                    callPayload.Queries["itemsPerPage"] = ExpressionConverter.Convert(__workflow_itemsPerPage);
                if (__workflow_pageIndex != null)
                    callPayload.Queries["pageIndex"] = ExpressionConverter.Convert(__workflow_pageIndex);
                return new ApiConnectionAction<ConsentPages>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lexpowersign")]
        public IBodyWorkflowAction<Contact, ApiConnectionActionConfiguration> CreateContact(Expression<Func<string>> userId, Expression<Func<string>> contentType, Expression<Func<CreateContactBodyInput>> body)
        {
            var __workflow_userId = WorkflowExpression.Compile(userId, nameof(userId), required: true);
            var __workflow_contentType = WorkflowExpression.Compile(contentType, nameof(contentType), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<Contact, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/users/{0}/contacts", __workflow_userId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(__workflow_contentType);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<Contact>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lexpowersign")]
        public IBodyWorkflowAction<Contact, ApiConnectionActionConfiguration> RetrieveContact(Expression<Func<string>> contactId, Expression<Func<string>> contentType)
        {
            var __workflow_contactId = WorkflowExpression.Compile(contactId, nameof(contactId), required: true);
            var __workflow_contentType = WorkflowExpression.Compile(contentType, nameof(contentType), required: true);
            return new DeferredBodyAction<Contact, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/contacts/{0}", __workflow_contactId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(__workflow_contentType);
                return new ApiConnectionAction<Contact>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lexpowersign")]
        public IBodyWorkflowAction<Contact, ApiConnectionActionConfiguration> DeleteContact(Expression<Func<string>> contactId, Expression<Func<string>> contentType)
        {
            var __workflow_contactId = WorkflowExpression.Compile(contactId, nameof(contactId), required: true);
            var __workflow_contentType = WorkflowExpression.Compile(contentType, nameof(contentType), required: true);
            return new DeferredBodyAction<Contact, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/contacts/{0}", __workflow_contactId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(__workflow_contentType);
                return new ApiConnectionAction<Contact>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lexpowersign")]
        public IBodyWorkflowAction<Contact, ApiConnectionActionConfiguration> UpdateContact(Expression<Func<string>> contactId, Expression<Func<string>> contentType, Expression<Func<UpdateContactBodyInput>> body)
        {
            var __workflow_contactId = WorkflowExpression.Compile(contactId, nameof(contactId), required: true);
            var __workflow_contentType = WorkflowExpression.Compile(contentType, nameof(contentType), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<Contact, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/contacts/{0}", __workflow_contactId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(__workflow_contentType);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<Contact>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lexpowersign")]
        public IBodyWorkflowAction<Contacts, ApiConnectionActionConfiguration> SearchContacts(Expression<Func<string>> text = null, Expression<Func<string>> itemsEmail = null, Expression<Func<string>> itemsPhoneNumber = null, Expression<Func<string>> itemsFisrtName = null, Expression<Func<string>> itemsLastName = null, Expression<Func<string>> itemsCountry = null, Expression<Func<double>> itemsPerPage = null, Expression<Func<double>> pageIndex = null)
        {
            var __workflow_text = WorkflowExpression.Compile(text, nameof(text), required: false);
            var __workflow_itemsEmail = WorkflowExpression.Compile(itemsEmail, nameof(itemsEmail), required: false);
            var __workflow_itemsPhoneNumber = WorkflowExpression.Compile(itemsPhoneNumber, nameof(itemsPhoneNumber), required: false);
            var __workflow_itemsFisrtName = WorkflowExpression.Compile(itemsFisrtName, nameof(itemsFisrtName), required: false);
            var __workflow_itemsLastName = WorkflowExpression.Compile(itemsLastName, nameof(itemsLastName), required: false);
            var __workflow_itemsCountry = WorkflowExpression.Compile(itemsCountry, nameof(itemsCountry), required: false);
            var __workflow_itemsPerPage = WorkflowExpression.Compile(itemsPerPage, nameof(itemsPerPage), required: false);
            var __workflow_pageIndex = WorkflowExpression.Compile(pageIndex, nameof(pageIndex), required: false);
            return new DeferredBodyAction<Contacts, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/contacts";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_text != null)
                    callPayload.Queries["text"] = ExpressionConverter.Convert(__workflow_text);
                if (__workflow_itemsEmail != null)
                    callPayload.Queries["items.email"] = ExpressionConverter.Convert(__workflow_itemsEmail);
                if (__workflow_itemsPhoneNumber != null)
                    callPayload.Queries["items.phoneNumber"] = ExpressionConverter.Convert(__workflow_itemsPhoneNumber);
                if (__workflow_itemsFisrtName != null)
                    callPayload.Queries["items.fisrtName"] = ExpressionConverter.Convert(__workflow_itemsFisrtName);
                if (__workflow_itemsLastName != null)
                    callPayload.Queries["items.lastName"] = ExpressionConverter.Convert(__workflow_itemsLastName);
                if (__workflow_itemsCountry != null)
                    callPayload.Queries["items.country"] = ExpressionConverter.Convert(__workflow_itemsCountry);
                if (__workflow_itemsPerPage != null)
                    callPayload.Queries["itemsPerPage"] = ExpressionConverter.Convert(__workflow_itemsPerPage);
                if (__workflow_pageIndex != null)
                    callPayload.Queries["pageIndex"] = ExpressionConverter.Convert(__workflow_pageIndex);
                return new ApiConnectionAction<Contacts>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lexpowersign")]
        public IBodyWorkflowAction<DataMapping, ApiConnectionActionConfiguration> GetDataMapping(Expression<Func<string>> tenantId)
        {
            var __workflow_tenantId = WorkflowExpression.Compile(tenantId, nameof(tenantId), required: true);
            return new DeferredBodyAction<DataMapping, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/tenants/{0}/dataMapping", __workflow_tenantId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<DataMapping>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lexpowersign")]
        public IBodyWorkflowAction<SignatureProfile, ApiConnectionActionConfiguration> CreateSignatureProfile(Expression<Func<string>> tenantId, Expression<Func<string>> contentType, Expression<Func<CreateSignatureProfileBodyInput>> body)
        {
            var __workflow_tenantId = WorkflowExpression.Compile(tenantId, nameof(tenantId), required: true);
            var __workflow_contentType = WorkflowExpression.Compile(contentType, nameof(contentType), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<SignatureProfile, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/tenants/{0}/signatureProfiles", __workflow_tenantId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(__workflow_contentType);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SignatureProfile>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lexpowersign")]
        public IBodyWorkflowAction<SignatureProfile, ApiConnectionActionConfiguration> RetrieveSignatureProfile(Expression<Func<string>> spId)
        {
            var __workflow_spId = WorkflowExpression.Compile(spId, nameof(spId), required: true);
            return new DeferredBodyAction<SignatureProfile, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/signatureProfiles/{0}", __workflow_spId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<SignatureProfile>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lexpowersign")]
        public IBodyWorkflowAction<SignatureProfile, ApiConnectionActionConfiguration> UpdateSignatureProfile(Expression<Func<string>> spId, Expression<Func<string>> contentType, Expression<Func<UpdateSignatureProfileBodyInput>> body)
        {
            var __workflow_spId = WorkflowExpression.Compile(spId, nameof(spId), required: true);
            var __workflow_contentType = WorkflowExpression.Compile(contentType, nameof(contentType), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<SignatureProfile, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/signatureProfiles/{0}", __workflow_spId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(__workflow_contentType);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SignatureProfile>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lexpowersign")]
        public IBodyWorkflowAction<SignatureProfiles, ApiConnectionActionConfiguration> SearchSignatureProfiles(Expression<Func<string>> text = null, Expression<Func<string>> itemsIsDefault = null, Expression<Func<string>> itemsIsDisabled = null, Expression<Func<string>> itemsName = null, Expression<Func<string>> itemsDocumentType = null, Expression<Func<string>> itemsSignatureType = null, Expression<Func<string>> itemsCreated = null, Expression<Func<string>> itemsUpdated = null, Expression<Func<string>> sortBy = null, Expression<Func<string>> sortOrder = null, Expression<Func<string>> itemsPerPage = null, Expression<Func<string>> pageIndex = null)
        {
            var __workflow_text = WorkflowExpression.Compile(text, nameof(text), required: false);
            var __workflow_itemsIsDefault = WorkflowExpression.Compile(itemsIsDefault, nameof(itemsIsDefault), required: false);
            var __workflow_itemsIsDisabled = WorkflowExpression.Compile(itemsIsDisabled, nameof(itemsIsDisabled), required: false);
            var __workflow_itemsName = WorkflowExpression.Compile(itemsName, nameof(itemsName), required: false);
            var __workflow_itemsDocumentType = WorkflowExpression.Compile(itemsDocumentType, nameof(itemsDocumentType), required: false);
            var __workflow_itemsSignatureType = WorkflowExpression.Compile(itemsSignatureType, nameof(itemsSignatureType), required: false);
            var __workflow_itemsCreated = WorkflowExpression.Compile(itemsCreated, nameof(itemsCreated), required: false);
            var __workflow_itemsUpdated = WorkflowExpression.Compile(itemsUpdated, nameof(itemsUpdated), required: false);
            var __workflow_sortBy = WorkflowExpression.Compile(sortBy, nameof(sortBy), required: false);
            var __workflow_sortOrder = WorkflowExpression.Compile(sortOrder, nameof(sortOrder), required: false);
            var __workflow_itemsPerPage = WorkflowExpression.Compile(itemsPerPage, nameof(itemsPerPage), required: false);
            var __workflow_pageIndex = WorkflowExpression.Compile(pageIndex, nameof(pageIndex), required: false);
            return new DeferredBodyAction<SignatureProfiles, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/signatureProfiles";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_text != null)
                    callPayload.Queries["text"] = ExpressionConverter.Convert(__workflow_text);
                if (__workflow_itemsIsDefault != null)
                    callPayload.Queries["items.isDefault"] = ExpressionConverter.Convert(__workflow_itemsIsDefault);
                if (__workflow_itemsIsDisabled != null)
                    callPayload.Queries["items.isDisabled"] = ExpressionConverter.Convert(__workflow_itemsIsDisabled);
                if (__workflow_itemsName != null)
                    callPayload.Queries["items.name"] = ExpressionConverter.Convert(__workflow_itemsName);
                if (__workflow_itemsDocumentType != null)
                    callPayload.Queries["items.documentType"] = ExpressionConverter.Convert(__workflow_itemsDocumentType);
                if (__workflow_itemsSignatureType != null)
                    callPayload.Queries["items.signatureType"] = ExpressionConverter.Convert(__workflow_itemsSignatureType);
                if (__workflow_itemsCreated != null)
                    callPayload.Queries["items.created"] = ExpressionConverter.Convert(__workflow_itemsCreated);
                if (__workflow_itemsUpdated != null)
                    callPayload.Queries["items.updated"] = ExpressionConverter.Convert(__workflow_itemsUpdated);
                if (__workflow_sortBy != null)
                    callPayload.Queries["sortBy"] = ExpressionConverter.Convert(__workflow_sortBy);
                if (__workflow_sortOrder != null)
                    callPayload.Queries["sortOrder"] = ExpressionConverter.Convert(__workflow_sortOrder);
                if (__workflow_itemsPerPage != null)
                    callPayload.Queries["itemsPerPage"] = ExpressionConverter.Convert(__workflow_itemsPerPage);
                if (__workflow_pageIndex != null)
                    callPayload.Queries["pageIndex"] = ExpressionConverter.Convert(__workflow_pageIndex);
                return new ApiConnectionAction<SignatureProfiles>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lexpowersign")]
        public IBodyWorkflowAction<User, ApiConnectionActionConfiguration> RetrieveMe()
        {
            return new DeferredBodyAction<User, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/users/me";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<User>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lexpowersign")]
        public IBodyWorkflowAction<Workflow, ApiConnectionActionConfiguration> CreateWorkflow(Expression<Func<string>> userId, Expression<Func<CreateWorkflowBodyInput>> body, Expression<Func<string>> contentType = null)
        {
            var __workflow_userId = WorkflowExpression.Compile(userId, nameof(userId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            var __workflow_contentType = WorkflowExpression.Compile(contentType, nameof(contentType), required: false);
            return new DeferredBodyAction<Workflow, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/users/{0}/workflows", __workflow_userId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (__workflow_contentType != null)
                    callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(__workflow_contentType);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<Workflow>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lexpowersign")]
        public IBodyWorkflowAction<Workflow, ApiConnectionActionConfiguration> RetrieveWorkflow(Expression<Func<string>> workflowId)
        {
            var __workflow_workflowId = WorkflowExpression.Compile(workflowId, nameof(workflowId), required: true);
            return new DeferredBodyAction<Workflow, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/workflows/{0}", __workflow_workflowId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Workflow>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lexpowersign")]
        public IBodyWorkflowAction<Workflow, ApiConnectionActionConfiguration> DeleteWorkflow(Expression<Func<string>> workflowId)
        {
            var __workflow_workflowId = WorkflowExpression.Compile(workflowId, nameof(workflowId), required: true);
            return new DeferredBodyAction<Workflow, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/workflows/{0}", __workflow_workflowId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Workflow>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lexpowersign")]
        public IBodyWorkflowAction<Workflow, ApiConnectionActionConfiguration> UpdateWorkflow(Expression<Func<string>> workflowId, Expression<Func<UpdateWorkflowBodyInput>> body, Expression<Func<string>> contentType = null)
        {
            var __workflow_workflowId = WorkflowExpression.Compile(workflowId, nameof(workflowId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            var __workflow_contentType = WorkflowExpression.Compile(contentType, nameof(contentType), required: false);
            return new DeferredBodyAction<Workflow, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/workflows/{0}", __workflow_workflowId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (__workflow_contentType != null)
                    callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(__workflow_contentType);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<Workflow>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lexpowersign")]
        public IBodyWorkflowAction<Workflows, ApiConnectionActionConfiguration> SearchWorkflows(Expression<Func<string>> accept = null, Expression<Func<string>> text = null, Expression<Func<string>> itemsLayoutId = null, Expression<Func<string>> itemsTemplateId = null, Expression<Func<string>> itemsGroupId = null, Expression<Func<string>> itemsUserId = null, Expression<Func<string>> itemsEmail = null, Expression<Func<string>> itemsFirstname = null, Expression<Func<string>> itemsLastname = null, Expression<Func<string>> itemsWorkflowStatus = null, Expression<Func<string>> itemsData1 = null, Expression<Func<string>> itemsData2 = null, Expression<Func<string>> itemsData3 = null, Expression<Func<string>> itemsData4 = null, Expression<Func<string>> itemsData5 = null, Expression<Func<string>> itemsData6 = null, Expression<Func<string>> itemsData7 = null, Expression<Func<string>> itemsData8 = null, Expression<Func<string>> itemsCreated = null, Expression<Func<string>> itemsUpdated = null, Expression<Func<string>> itemsStarted = null, Expression<Func<string>> sortBy = null, Expression<Func<string>> sortOrder = null, Expression<Func<string>> itemsPerPage = null, Expression<Func<string>> pageIndex = null)
        {
            var __workflow_accept = WorkflowExpression.Compile(accept, nameof(accept), required: false);
            var __workflow_text = WorkflowExpression.Compile(text, nameof(text), required: false);
            var __workflow_itemsLayoutId = WorkflowExpression.Compile(itemsLayoutId, nameof(itemsLayoutId), required: false);
            var __workflow_itemsTemplateId = WorkflowExpression.Compile(itemsTemplateId, nameof(itemsTemplateId), required: false);
            var __workflow_itemsGroupId = WorkflowExpression.Compile(itemsGroupId, nameof(itemsGroupId), required: false);
            var __workflow_itemsUserId = WorkflowExpression.Compile(itemsUserId, nameof(itemsUserId), required: false);
            var __workflow_itemsEmail = WorkflowExpression.Compile(itemsEmail, nameof(itemsEmail), required: false);
            var __workflow_itemsFirstname = WorkflowExpression.Compile(itemsFirstname, nameof(itemsFirstname), required: false);
            var __workflow_itemsLastname = WorkflowExpression.Compile(itemsLastname, nameof(itemsLastname), required: false);
            var __workflow_itemsWorkflowStatus = WorkflowExpression.Compile(itemsWorkflowStatus, nameof(itemsWorkflowStatus), required: false);
            var __workflow_itemsData1 = WorkflowExpression.Compile(itemsData1, nameof(itemsData1), required: false);
            var __workflow_itemsData2 = WorkflowExpression.Compile(itemsData2, nameof(itemsData2), required: false);
            var __workflow_itemsData3 = WorkflowExpression.Compile(itemsData3, nameof(itemsData3), required: false);
            var __workflow_itemsData4 = WorkflowExpression.Compile(itemsData4, nameof(itemsData4), required: false);
            var __workflow_itemsData5 = WorkflowExpression.Compile(itemsData5, nameof(itemsData5), required: false);
            var __workflow_itemsData6 = WorkflowExpression.Compile(itemsData6, nameof(itemsData6), required: false);
            var __workflow_itemsData7 = WorkflowExpression.Compile(itemsData7, nameof(itemsData7), required: false);
            var __workflow_itemsData8 = WorkflowExpression.Compile(itemsData8, nameof(itemsData8), required: false);
            var __workflow_itemsCreated = WorkflowExpression.Compile(itemsCreated, nameof(itemsCreated), required: false);
            var __workflow_itemsUpdated = WorkflowExpression.Compile(itemsUpdated, nameof(itemsUpdated), required: false);
            var __workflow_itemsStarted = WorkflowExpression.Compile(itemsStarted, nameof(itemsStarted), required: false);
            var __workflow_sortBy = WorkflowExpression.Compile(sortBy, nameof(sortBy), required: false);
            var __workflow_sortOrder = WorkflowExpression.Compile(sortOrder, nameof(sortOrder), required: false);
            var __workflow_itemsPerPage = WorkflowExpression.Compile(itemsPerPage, nameof(itemsPerPage), required: false);
            var __workflow_pageIndex = WorkflowExpression.Compile(pageIndex, nameof(pageIndex), required: false);
            return new DeferredBodyAction<Workflows, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/workflows";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_text != null)
                    callPayload.Queries["text"] = ExpressionConverter.Convert(__workflow_text);
                if (__workflow_itemsLayoutId != null)
                    callPayload.Queries["items.layoutId"] = ExpressionConverter.Convert(__workflow_itemsLayoutId);
                if (__workflow_itemsTemplateId != null)
                    callPayload.Queries["items.templateId"] = ExpressionConverter.Convert(__workflow_itemsTemplateId);
                if (__workflow_itemsGroupId != null)
                    callPayload.Queries["items.groupId"] = ExpressionConverter.Convert(__workflow_itemsGroupId);
                if (__workflow_itemsUserId != null)
                    callPayload.Queries["items.userId"] = ExpressionConverter.Convert(__workflow_itemsUserId);
                if (__workflow_itemsEmail != null)
                    callPayload.Queries["items.email"] = ExpressionConverter.Convert(__workflow_itemsEmail);
                if (__workflow_itemsFirstname != null)
                    callPayload.Queries["items.firstname"] = ExpressionConverter.Convert(__workflow_itemsFirstname);
                if (__workflow_itemsLastname != null)
                    callPayload.Queries["items.lastname"] = ExpressionConverter.Convert(__workflow_itemsLastname);
                if (__workflow_itemsWorkflowStatus != null)
                    callPayload.Queries["items.workflowStatus"] = ExpressionConverter.Convert(__workflow_itemsWorkflowStatus);
                if (__workflow_itemsData1 != null)
                    callPayload.Queries["items.data1"] = ExpressionConverter.Convert(__workflow_itemsData1);
                if (__workflow_itemsData2 != null)
                    callPayload.Queries["items.data2"] = ExpressionConverter.Convert(__workflow_itemsData2);
                if (__workflow_itemsData3 != null)
                    callPayload.Queries["items.data3"] = ExpressionConverter.Convert(__workflow_itemsData3);
                if (__workflow_itemsData4 != null)
                    callPayload.Queries["items.data4"] = ExpressionConverter.Convert(__workflow_itemsData4);
                if (__workflow_itemsData5 != null)
                    callPayload.Queries["items.data5"] = ExpressionConverter.Convert(__workflow_itemsData5);
                if (__workflow_itemsData6 != null)
                    callPayload.Queries["items.data6"] = ExpressionConverter.Convert(__workflow_itemsData6);
                if (__workflow_itemsData7 != null)
                    callPayload.Queries["items.data7"] = ExpressionConverter.Convert(__workflow_itemsData7);
                if (__workflow_itemsData8 != null)
                    callPayload.Queries["items.data8"] = ExpressionConverter.Convert(__workflow_itemsData8);
                if (__workflow_itemsCreated != null)
                    callPayload.Queries["items.created"] = ExpressionConverter.Convert(__workflow_itemsCreated);
                if (__workflow_itemsUpdated != null)
                    callPayload.Queries["items.updated"] = ExpressionConverter.Convert(__workflow_itemsUpdated);
                if (__workflow_itemsStarted != null)
                    callPayload.Queries["items.started"] = ExpressionConverter.Convert(__workflow_itemsStarted);
                if (__workflow_sortBy != null)
                    callPayload.Queries["sortBy"] = ExpressionConverter.Convert(__workflow_sortBy);
                if (__workflow_sortOrder != null)
                    callPayload.Queries["sortOrder"] = ExpressionConverter.Convert(__workflow_sortOrder);
                if (__workflow_itemsPerPage != null)
                    callPayload.Queries["itemsPerPage"] = ExpressionConverter.Convert(__workflow_itemsPerPage);
                if (__workflow_pageIndex != null)
                    callPayload.Queries["pageIndex"] = ExpressionConverter.Convert(__workflow_pageIndex);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                if (__workflow_accept != null)
                    callPayload.Headers["Accept"] = ExpressionConverter.Convert(__workflow_accept);
                return new ApiConnectionAction<Workflows>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lexpowersign")]
        public IBodyWorkflowAction<WorkflowInviteResponse, ApiConnectionActionConfiguration> WorkflowInvite(Expression<Func<string>> workflowId, Expression<Func<WorkflowInviteBodyInput>> body)
        {
            var __workflow_workflowId = WorkflowExpression.Compile(workflowId, nameof(workflowId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<WorkflowInviteResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/workflows/{0}/invite", __workflow_workflowId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<WorkflowInviteResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lexpowersign")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> WorkflowEvidences(Expression<Func<string>> workflowId, Expression<Func<string>> accept)
        {
            var __workflow_workflowId = WorkflowExpression.Compile(workflowId, nameof(workflowId), required: true);
            var __workflow_accept = WorkflowExpression.Compile(accept, nameof(accept), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/workflows/{0}/downloadEvidences", __workflow_workflowId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = ExpressionConverter.Convert(__workflow_accept);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lexpowersign")]
        public IBodyWorkflowAction<CreatePartResponse, ApiConnectionActionConfiguration> CreatePart(Expression<Func<string>> workflowId, Expression<Func<string>> contentType, Expression<Func<string>> contentDisposition, Expression<Func<string>> document, Expression<Func<string>> createDocuments = null, Expression<Func<string>> ignoreAttachments = null, Expression<Func<string>> signatureProfileId = null, Expression<Func<string>> unzip = null, Expression<Func<string>> pdf2pdfa = null)
        {
            var __workflow_workflowId = WorkflowExpression.Compile(workflowId, nameof(workflowId), required: true);
            var __workflow_contentType = WorkflowExpression.Compile(contentType, nameof(contentType), required: true);
            var __workflow_contentDisposition = WorkflowExpression.Compile(contentDisposition, nameof(contentDisposition), required: true);
            var __workflow_document = WorkflowExpression.Compile(document, nameof(document), required: true);
            var __workflow_createDocuments = WorkflowExpression.Compile(createDocuments, nameof(createDocuments), required: false);
            var __workflow_ignoreAttachments = WorkflowExpression.Compile(ignoreAttachments, nameof(ignoreAttachments), required: false);
            var __workflow_signatureProfileId = WorkflowExpression.Compile(signatureProfileId, nameof(signatureProfileId), required: false);
            var __workflow_unzip = WorkflowExpression.Compile(unzip, nameof(unzip), required: false);
            var __workflow_pdf2pdfa = WorkflowExpression.Compile(pdf2pdfa, nameof(pdf2pdfa), required: false);
            return new DeferredBodyAction<CreatePartResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/workflows/{0}/parts", __workflow_workflowId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["createDocuments"] = Convert.ToString("true");
                if (__workflow_createDocuments != null)
                    callPayload.Queries["createDocuments"] = ExpressionConverter.Convert(__workflow_createDocuments);
                callPayload.Queries["ignoreAttachments"] = Convert.ToString("true");
                if (__workflow_ignoreAttachments != null)
                    callPayload.Queries["ignoreAttachments"] = ExpressionConverter.Convert(__workflow_ignoreAttachments);
                if (__workflow_signatureProfileId != null)
                    callPayload.Queries["signatureProfileId"] = ExpressionConverter.Convert(__workflow_signatureProfileId);
                callPayload.Queries["unzip"] = Convert.ToString("false");
                if (__workflow_unzip != null)
                    callPayload.Queries["unzip"] = ExpressionConverter.Convert(__workflow_unzip);
                callPayload.Queries["pdf2pdfa"] = Convert.ToString("auto");
                if (__workflow_pdf2pdfa != null)
                    callPayload.Queries["pdf2pdfa"] = ExpressionConverter.Convert(__workflow_pdf2pdfa);
                callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(__workflow_contentType);
                callPayload.Headers["Content-Disposition"] = ExpressionConverter.Convert(__workflow_contentDisposition);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_document);
                return new ApiConnectionAction<CreatePartResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lexpowersign")]
        public IBodyWorkflowAction<Document, ApiConnectionActionConfiguration> CreateDocument(Expression<Func<string>> workflowId, Expression<Func<string>> contentType, Expression<Func<CreateDocumentBodyInput>> body)
        {
            var __workflow_workflowId = WorkflowExpression.Compile(workflowId, nameof(workflowId), required: true);
            var __workflow_contentType = WorkflowExpression.Compile(contentType, nameof(contentType), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<Document, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/workflows/{0}/documents", __workflow_workflowId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(__workflow_contentType);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<Document>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lexpowersign")]
        public IBodyWorkflowAction<Document, ApiConnectionActionConfiguration> RetrieveDocument(Expression<Func<string>> documentId)
        {
            var __workflow_documentId = WorkflowExpression.Compile(documentId, nameof(documentId), required: true);
            return new DeferredBodyAction<Document, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/documents/{0}", __workflow_documentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Document>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lexpowersign")]
        public IBodyWorkflowAction<Document, ApiConnectionActionConfiguration> DeleteDocument(Expression<Func<string>> documentId)
        {
            var __workflow_documentId = WorkflowExpression.Compile(documentId, nameof(documentId), required: true);
            return new DeferredBodyAction<Document, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/documents/{0}", __workflow_documentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Document>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lexpowersign")]
        public IBodyWorkflowAction<Document, ApiConnectionActionConfiguration> UpdateDocument(Expression<Func<string>> documentId, Expression<Func<string>> contentType, Expression<Func<UpdateDocumentBodyInput>> body)
        {
            var __workflow_documentId = WorkflowExpression.Compile(documentId, nameof(documentId), required: true);
            var __workflow_contentType = WorkflowExpression.Compile(contentType, nameof(contentType), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<Document, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/documents/{0}", __workflow_documentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(__workflow_contentType);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<Document>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lexpowersign")]
        public IBodyWorkflowAction<SearchDocumentsResponse, ApiConnectionActionConfiguration> SearchDocuments(Expression<Func<string>> text = null, Expression<Func<string>> itemsLayoutId = null, Expression<Func<string>> itemsGroupId = null, Expression<Func<string>> itemsUserId = null, Expression<Func<string>> itemsWorkflowId = null, Expression<Func<string>> itemsWorkflowName = null, Expression<Func<string>> itemsData1 = null, Expression<Func<string>> itemsData2 = null, Expression<Func<string>> itemsData3 = null, Expression<Func<string>> itemsData4 = null, Expression<Func<string>> itemsData5 = null, Expression<Func<string>> itemsData6 = null, Expression<Func<string>> itemsData7 = null, Expression<Func<string>> itemsData8 = null, Expression<Func<string>> itemsSignatureProfileId = null, Expression<Func<string>> itemsCreated = null, Expression<Func<string>> itemsUpdated = null, Expression<Func<string>> sortBy = null, Expression<Func<string>> sortOrder = null, Expression<Func<string>> itemsPerPage = null, Expression<Func<string>> pageIndex = null)
        {
            var __workflow_text = WorkflowExpression.Compile(text, nameof(text), required: false);
            var __workflow_itemsLayoutId = WorkflowExpression.Compile(itemsLayoutId, nameof(itemsLayoutId), required: false);
            var __workflow_itemsGroupId = WorkflowExpression.Compile(itemsGroupId, nameof(itemsGroupId), required: false);
            var __workflow_itemsUserId = WorkflowExpression.Compile(itemsUserId, nameof(itemsUserId), required: false);
            var __workflow_itemsWorkflowId = WorkflowExpression.Compile(itemsWorkflowId, nameof(itemsWorkflowId), required: false);
            var __workflow_itemsWorkflowName = WorkflowExpression.Compile(itemsWorkflowName, nameof(itemsWorkflowName), required: false);
            var __workflow_itemsData1 = WorkflowExpression.Compile(itemsData1, nameof(itemsData1), required: false);
            var __workflow_itemsData2 = WorkflowExpression.Compile(itemsData2, nameof(itemsData2), required: false);
            var __workflow_itemsData3 = WorkflowExpression.Compile(itemsData3, nameof(itemsData3), required: false);
            var __workflow_itemsData4 = WorkflowExpression.Compile(itemsData4, nameof(itemsData4), required: false);
            var __workflow_itemsData5 = WorkflowExpression.Compile(itemsData5, nameof(itemsData5), required: false);
            var __workflow_itemsData6 = WorkflowExpression.Compile(itemsData6, nameof(itemsData6), required: false);
            var __workflow_itemsData7 = WorkflowExpression.Compile(itemsData7, nameof(itemsData7), required: false);
            var __workflow_itemsData8 = WorkflowExpression.Compile(itemsData8, nameof(itemsData8), required: false);
            var __workflow_itemsSignatureProfileId = WorkflowExpression.Compile(itemsSignatureProfileId, nameof(itemsSignatureProfileId), required: false);
            var __workflow_itemsCreated = WorkflowExpression.Compile(itemsCreated, nameof(itemsCreated), required: false);
            var __workflow_itemsUpdated = WorkflowExpression.Compile(itemsUpdated, nameof(itemsUpdated), required: false);
            var __workflow_sortBy = WorkflowExpression.Compile(sortBy, nameof(sortBy), required: false);
            var __workflow_sortOrder = WorkflowExpression.Compile(sortOrder, nameof(sortOrder), required: false);
            var __workflow_itemsPerPage = WorkflowExpression.Compile(itemsPerPage, nameof(itemsPerPage), required: false);
            var __workflow_pageIndex = WorkflowExpression.Compile(pageIndex, nameof(pageIndex), required: false);
            return new DeferredBodyAction<SearchDocumentsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/documents";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_text != null)
                    callPayload.Queries["text"] = ExpressionConverter.Convert(__workflow_text);
                if (__workflow_itemsLayoutId != null)
                    callPayload.Queries["items.layoutId"] = ExpressionConverter.Convert(__workflow_itemsLayoutId);
                if (__workflow_itemsGroupId != null)
                    callPayload.Queries["items.groupId"] = ExpressionConverter.Convert(__workflow_itemsGroupId);
                if (__workflow_itemsUserId != null)
                    callPayload.Queries["items.userId"] = ExpressionConverter.Convert(__workflow_itemsUserId);
                if (__workflow_itemsWorkflowId != null)
                    callPayload.Queries["items.workflowId"] = ExpressionConverter.Convert(__workflow_itemsWorkflowId);
                if (__workflow_itemsWorkflowName != null)
                    callPayload.Queries["items.workflowName"] = ExpressionConverter.Convert(__workflow_itemsWorkflowName);
                if (__workflow_itemsData1 != null)
                    callPayload.Queries["items.data1"] = ExpressionConverter.Convert(__workflow_itemsData1);
                if (__workflow_itemsData2 != null)
                    callPayload.Queries["items.data2"] = ExpressionConverter.Convert(__workflow_itemsData2);
                if (__workflow_itemsData3 != null)
                    callPayload.Queries["items.data3"] = ExpressionConverter.Convert(__workflow_itemsData3);
                if (__workflow_itemsData4 != null)
                    callPayload.Queries["items.data4"] = ExpressionConverter.Convert(__workflow_itemsData4);
                if (__workflow_itemsData5 != null)
                    callPayload.Queries["items.data5"] = ExpressionConverter.Convert(__workflow_itemsData5);
                if (__workflow_itemsData6 != null)
                    callPayload.Queries["items.data6"] = ExpressionConverter.Convert(__workflow_itemsData6);
                if (__workflow_itemsData7 != null)
                    callPayload.Queries["items.data7"] = ExpressionConverter.Convert(__workflow_itemsData7);
                if (__workflow_itemsData8 != null)
                    callPayload.Queries["items.data8"] = ExpressionConverter.Convert(__workflow_itemsData8);
                if (__workflow_itemsSignatureProfileId != null)
                    callPayload.Queries["items.signatureProfileId"] = ExpressionConverter.Convert(__workflow_itemsSignatureProfileId);
                if (__workflow_itemsCreated != null)
                    callPayload.Queries["items.created"] = ExpressionConverter.Convert(__workflow_itemsCreated);
                if (__workflow_itemsUpdated != null)
                    callPayload.Queries["items.updated"] = ExpressionConverter.Convert(__workflow_itemsUpdated);
                if (__workflow_sortBy != null)
                    callPayload.Queries["sortBy"] = ExpressionConverter.Convert(__workflow_sortBy);
                if (__workflow_sortOrder != null)
                    callPayload.Queries["sortOrder"] = ExpressionConverter.Convert(__workflow_sortOrder);
                if (__workflow_itemsPerPage != null)
                    callPayload.Queries["itemsPerPage"] = ExpressionConverter.Convert(__workflow_itemsPerPage);
                if (__workflow_pageIndex != null)
                    callPayload.Queries["pageIndex"] = ExpressionConverter.Convert(__workflow_pageIndex);
                return new ApiConnectionAction<SearchDocumentsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lexpowersign")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> DownloadDocuments(Expression<Func<string>> workflowId)
        {
            var __workflow_workflowId = WorkflowExpression.Compile(workflowId, nameof(workflowId), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/workflows/{0}/downloadDocuments", __workflow_workflowId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lexpowersign")]
        public IBodyWorkflowAction<Layout, ApiConnectionActionConfiguration> CreateLayout(Expression<Func<string>> tenantId, Expression<Func<string>> contentType, Expression<Func<CreateLayoutBodyInput>> body)
        {
            var __workflow_tenantId = WorkflowExpression.Compile(tenantId, nameof(tenantId), required: true);
            var __workflow_contentType = WorkflowExpression.Compile(contentType, nameof(contentType), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<Layout, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/tenants/{0}/layouts", __workflow_tenantId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(__workflow_contentType);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<Layout>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lexpowersign")]
        public IBodyWorkflowAction<Layout, ApiConnectionActionConfiguration> RetrieveLayout(Expression<Func<string>> layoutId)
        {
            var __workflow_layoutId = WorkflowExpression.Compile(layoutId, nameof(layoutId), required: true);
            return new DeferredBodyAction<Layout, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/layouts/{0}", __workflow_layoutId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Layout>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lexpowersign")]
        public IBodyWorkflowAction<Layout, ApiConnectionActionConfiguration> UpdateLayout(Expression<Func<string>> layoutId, Expression<Func<string>> contentType, Expression<Func<CreateLayoutBodyInput>> body)
        {
            var __workflow_layoutId = WorkflowExpression.Compile(layoutId, nameof(layoutId), required: true);
            var __workflow_contentType = WorkflowExpression.Compile(contentType, nameof(contentType), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<Layout, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/layouts/{0}", __workflow_layoutId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(__workflow_contentType);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<Layout>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lexpowersign")]
        public IBodyWorkflowAction<SearchLayoutsResponse, ApiConnectionActionConfiguration> SearchLayouts(Expression<Func<string>> text = null, Expression<Func<string>> itemsIsDisabled = null, Expression<Func<string>> itemsName = null, Expression<Func<string>> itemsDataConfigurationsSlot = null, Expression<Func<string>> itemsCreated = null, Expression<Func<string>> itemsUpdated = null, Expression<Func<string>> sortBy = null, Expression<Func<string>> sortOrder = null, Expression<Func<string>> itemsPerPage = null, Expression<Func<string>> pageIndex = null)
        {
            var __workflow_text = WorkflowExpression.Compile(text, nameof(text), required: false);
            var __workflow_itemsIsDisabled = WorkflowExpression.Compile(itemsIsDisabled, nameof(itemsIsDisabled), required: false);
            var __workflow_itemsName = WorkflowExpression.Compile(itemsName, nameof(itemsName), required: false);
            var __workflow_itemsDataConfigurationsSlot = WorkflowExpression.Compile(itemsDataConfigurationsSlot, nameof(itemsDataConfigurationsSlot), required: false);
            var __workflow_itemsCreated = WorkflowExpression.Compile(itemsCreated, nameof(itemsCreated), required: false);
            var __workflow_itemsUpdated = WorkflowExpression.Compile(itemsUpdated, nameof(itemsUpdated), required: false);
            var __workflow_sortBy = WorkflowExpression.Compile(sortBy, nameof(sortBy), required: false);
            var __workflow_sortOrder = WorkflowExpression.Compile(sortOrder, nameof(sortOrder), required: false);
            var __workflow_itemsPerPage = WorkflowExpression.Compile(itemsPerPage, nameof(itemsPerPage), required: false);
            var __workflow_pageIndex = WorkflowExpression.Compile(pageIndex, nameof(pageIndex), required: false);
            return new DeferredBodyAction<SearchLayoutsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/layouts";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_text != null)
                    callPayload.Queries["text"] = ExpressionConverter.Convert(__workflow_text);
                if (__workflow_itemsIsDisabled != null)
                    callPayload.Queries["items.isDisabled"] = ExpressionConverter.Convert(__workflow_itemsIsDisabled);
                if (__workflow_itemsName != null)
                    callPayload.Queries["items.name"] = ExpressionConverter.Convert(__workflow_itemsName);
                if (__workflow_itemsDataConfigurationsSlot != null)
                    callPayload.Queries["items.dataConfigurations.slot"] = ExpressionConverter.Convert(__workflow_itemsDataConfigurationsSlot);
                if (__workflow_itemsCreated != null)
                    callPayload.Queries["items.created"] = ExpressionConverter.Convert(__workflow_itemsCreated);
                if (__workflow_itemsUpdated != null)
                    callPayload.Queries["items.updated"] = ExpressionConverter.Convert(__workflow_itemsUpdated);
                if (__workflow_sortBy != null)
                    callPayload.Queries["sortBy"] = ExpressionConverter.Convert(__workflow_sortBy);
                if (__workflow_sortOrder != null)
                    callPayload.Queries["sortOrder"] = ExpressionConverter.Convert(__workflow_sortOrder);
                if (__workflow_itemsPerPage != null)
                    callPayload.Queries["itemsPerPage"] = ExpressionConverter.Convert(__workflow_itemsPerPage);
                if (__workflow_pageIndex != null)
                    callPayload.Queries["pageIndex"] = ExpressionConverter.Convert(__workflow_pageIndex);
                return new ApiConnectionAction<SearchLayoutsResponse>(callPayload);
            });
        }
    }

    public class LexpowersignTriggers([ConnectionName] string connectionId)
    {
    }

    public class ConsentPage
    {
        [JsonProperty("allowOrganization")]
        public bool AllowOrganization { get; set; }

        [JsonProperty("authenticateUser")]
        public bool AuthenticateUser { get; set; }

        [JsonProperty("clientId")]
        public string ClientId { get; set; }

        [JsonProperty("created")]
        public double Created { get; set; }

        [JsonProperty("emUrl")]
        public string EmUrl { get; set; }

        [JsonProperty("hideDownloads")]
        public bool HideDownloads { get; set; }

        [JsonProperty("hideMobileQrCode")]
        public bool HideMobileQrCode { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("isCountryRequired")]
        public bool IsCountryRequired { get; set; }

        [JsonProperty("isDisabled")]
        public bool IsDisabled { get; set; }

        [JsonProperty("logoResourceId")]
        public string LogoResourceId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("primaryColor")]
        public string PrimaryColor { get; set; }

        [JsonProperty("secondaryColor")]
        public string SecondaryColor { get; set; }

        [JsonProperty("sharedPassphrase")]
        public string SharedPassphrase { get; set; }

        [JsonProperty("signing mode")]
        public string SigningMode { get; set; }

        [JsonProperty("stepType")]
        public string StepType { get; set; }

        [JsonProperty("tenantId")]
        public string TenantId { get; set; }

        [JsonProperty("tsaUrl")]
        public string TsaUrl { get; set; }

        [JsonProperty("updated")]
        public double Updated { get; set; }

        [JsonProperty("verifyEmail")]
        public bool VerifyEmail { get; set; }

        [JsonProperty("verifyPhoneNumber")]
        public bool VerifyPhoneNumber { get; set; }
    }

    public class ConsentPages
    {
        [JsonProperty("items")]
        public ConsentPage[] Items { get; set; }

        [JsonProperty("itemsPerPage")]
        public int ItemsPerPage { get; set; }

        [JsonProperty("pageIndex")]
        public int PageIndex { get; set; }

        [JsonProperty("totalItems")]
        public int TotalItems { get; set; }
    }

    public class Contact
    {
        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("created")]
        public int Created { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("phoneNumber")]
        public string PhoneNumber { get; set; }

        [JsonProperty("tenantId")]
        public string TenantId { get; set; }

        [JsonProperty("updated")]
        public int Updated { get; set; }

        [JsonProperty("userId")]
        public string UserId { get; set; }
    }

    public class CreateContactBodyInput
    {
        [JsonProperty("email", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ContactEmail { get; set; }

        [JsonProperty("phoneNumber")]
        public string ContatctPhoneNumber { get; set; }

        [JsonProperty("firstName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ContactFirstName { get; set; }

        [JsonProperty("lastName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ContactLastName { get; set; }

        [JsonProperty("country")]
        public string ContactCountry { get; set; }
    }

    public class UpdateContactBodyInput
    {
        [JsonProperty("email")]
        public string EmailOfTheContact { get; set; }

        [JsonProperty("phoneNumber")]
        public string PhoneNumberOfTheContact { get; set; }

        [JsonProperty("firstName")]
        public string FirstNameOfTheContact { get; set; }

        [JsonProperty("lastName")]
        public string LastNameOfTheContact { get; set; }

        [JsonProperty("country")]
        public string CountryOfTheContact { get; set; }
    }

    public class Contacts
    {
        [JsonProperty("items")]
        public Contact[] Items { get; set; }

        [JsonProperty("itemsPerPage")]
        public int ItemsPerPage { get; set; }

        [JsonProperty("pageIndex")]
        public int PageIndex { get; set; }

        [JsonProperty("totalItems")]
        public int TotalItems { get; set; }
    }

    public class DataMapping
    {
        [JsonProperty("data1")]
        public DataMappingData1Type Data1 { get; set; }

        [JsonProperty("data2")]
        public DataMappingData2Type Data2 { get; set; }

        [JsonProperty("data3")]
        public DataMappingData3Type Data3 { get; set; }

        [JsonProperty("data4")]
        public DataMappingData4Type Data4 { get; set; }

        [JsonProperty("data5")]
        public DataMappingData5Type Data5 { get; set; }

        [JsonProperty("data6")]
        public DataMappingData6Type Data6 { get; set; }

        [JsonProperty("data7")]
        public DataMappingData7Type Data7 { get; set; }

        [JsonProperty("data8")]
        public DataMappingData8Type Data8 { get; set; }
    }

    public class DataMappingData1Type
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("pattern")]
        public string Pattern { get; set; }

        [JsonProperty("options")]
        public DataMappingData1TypeOptionsTypeItem[] Options { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class DataMappingData1TypeOptionsTypeItem
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class DataMappingData2Type
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("pattern")]
        public string Pattern { get; set; }

        [JsonProperty("options")]
        public DataMappingData2TypeOptionsTypeItem[] Options { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class DataMappingData2TypeOptionsTypeItem
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class DataMappingData3Type
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("pattern")]
        public string Pattern { get; set; }

        [JsonProperty("options")]
        public DataMappingData3TypeOptionsTypeItem[] Options { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class DataMappingData3TypeOptionsTypeItem
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class DataMappingData4Type
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("pattern")]
        public string Pattern { get; set; }

        [JsonProperty("options")]
        public DataMappingData4TypeOptionsTypeItem[] Options { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class DataMappingData4TypeOptionsTypeItem
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class DataMappingData5Type
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("pattern")]
        public string Pattern { get; set; }

        [JsonProperty("options")]
        public DataMappingData5TypeOptionsTypeItem[] Options { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class DataMappingData5TypeOptionsTypeItem
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class DataMappingData6Type
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("pattern")]
        public string Pattern { get; set; }

        [JsonProperty("options")]
        public DataMappingData6TypeOptionsTypeItem[] Options { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class DataMappingData6TypeOptionsTypeItem
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class DataMappingData7Type
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("pattern")]
        public string Pattern { get; set; }

        [JsonProperty("options")]
        public DataMappingData7TypeOptionsTypeItem[] Options { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class DataMappingData7TypeOptionsTypeItem
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class DataMappingData8Type
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("pattern")]
        public string Pattern { get; set; }

        [JsonProperty("options")]
        public DataMappingData8TypeOptionsTypeItem[] Options { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class DataMappingData8TypeOptionsTypeItem
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class SignatureProfile
    {
        [JsonProperty("created")]
        public double Created { get; set; }

        [JsonProperty("documentType")]
        public string DocumentType { get; set; }

        [JsonProperty("forceScrollDocument")]
        public bool ForceScrollDocument { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("isDefault")]
        public bool IsDefault { get; set; }

        [JsonProperty("isDisabled")]
        public bool IsDisabled { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("pdfSignatureImageText")]
        public string PdfSignatureImageText { get; set; }

        [JsonProperty("pdfSignatureImageTextColor")]
        public string PdfSignatureImageTextColor { get; set; }

        [JsonProperty("pdfSignatureImageTextSize")]
        public double PdfSignatureImageTextSize { get; set; }

        [JsonProperty("pdfVisibleSignatureMode")]
        public string PdfVisibleSignatureMode { get; set; }

        [JsonProperty("signatureType")]
        public string SignatureType { get; set; }

        [JsonProperty("tenantId")]
        public string TenantId { get; set; }

        [JsonProperty("updated")]
        public double Updated { get; set; }
    }

    public class CreateSignatureProfileBodyInput
    {
        [JsonProperty("isDefault", DefaultValueHandling = DefaultValueHandling.Include)]
        public string IsDefault { get; set; }

        [JsonProperty("isDisabled")]
        public string IsDisabled { get; set; }

        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("documentType", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DocumentType { get; set; }

        [JsonProperty("signatureType", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SignatureType { get; set; }

        [JsonProperty("forceScrollDocument", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool ForceToScrollToTheBottomOfTheDocument { get; set; }

        [JsonProperty("pdfVisibleSignatureMode")]
        public string VisibleSignatureMode { get; set; }

        [JsonProperty("pdfSignatureImageText")]
        public string SignatureText { get; set; }

        [JsonProperty("pdfSignatureImageTextColor")]
        public string SignatureTextColor { get; set; }

        [JsonProperty("pdfSignatureImageTextSize")]
        public double? SignatureTextSize { get; set; }
    }

    public class UpdateSignatureProfileBodyInput
    {
        [JsonProperty("isDefault")]
        public string IsDefault { get; set; }

        [JsonProperty("isDisabled")]
        public string IsDisabled { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("signatureType")]
        public string SignatureType { get; set; }

        [JsonProperty("forceScrollDocument")]
        public bool? ForceToScrollToTheBottomOfTheDocument { get; set; }

        [JsonProperty("pdfVisibleSignatureMode")]
        public string VisibleSignatureMode { get; set; }

        [JsonProperty("pdfSignatureImageText")]
        public string SignatureText { get; set; }

        [JsonProperty("pdfSignatureImageTextColor")]
        public string SignatureTextColor { get; set; }

        [JsonProperty("pdfSignatureImageTextSize")]
        public double? SignatureTextSize { get; set; }
    }

    public class SignatureProfiles
    {
        [JsonProperty("items")]
        public SignatureProfile[] Items { get; set; }

        [JsonProperty("itemsPerPage")]
        public double ItemsPerPage { get; set; }

        [JsonProperty("pageIndex")]
        public double PageIndex { get; set; }

        [JsonProperty("totalItems")]
        public double TotalItems { get; set; }
    }

    public class User
    {
        [JsonProperty("approveAllowed")]
        public bool ApproveAllowed { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("created")]
        public int Created { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("groupId")]
        public string GroupId { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("isDisabled")]
        public bool IsDisabled { get; set; }

        [JsonProperty("lastLogin")]
        public int LastLogin { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("organizationTitles")]
        public JToken[] OrganizationTitles { get; set; }

        [JsonProperty("phoneNumber")]
        public string PhoneNumber { get; set; }

        [JsonProperty("signAllowed")]
        public bool SignAllowed { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("tenantId")]
        public string TenantId { get; set; }

        [JsonProperty("updated")]
        public int Updated { get; set; }

        [JsonProperty("viewAuthorizedGroups")]
        public string[] ViewAuthorizedGroups { get; set; }
    }

    public class Workflow
    {
        [JsonProperty("created")]
        public int Created { get; set; }

        [JsonProperty("currentRecipientEmails")]
        public JToken[] CurrentRecipientEmails { get; set; }

        [JsonProperty("currentRecipientUsers")]
        public JToken[] CurrentRecipientUsers { get; set; }

        [JsonProperty("data1")]
        public string Data1 { get; set; }

        [JsonProperty("data2")]
        public string Data2 { get; set; }

        [JsonProperty("data3")]
        public string Data3 { get; set; }

        [JsonProperty("data4")]
        public string Data4 { get; set; }

        [JsonProperty("data5")]
        public string Data5 { get; set; }

        [JsonProperty("data6")]
        public string Data6 { get; set; }

        [JsonProperty("data7")]
        public string Data7 { get; set; }

        [JsonProperty("data8")]
        public string Data8 { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("groupId")]
        public string GroupId { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("layoutId")]
        public string LayoutId { get; set; }

        [JsonProperty("logs")]
        public JToken[] Logs { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("notifiedEvents")]
        public string[] NotifiedEvents { get; set; }

        [JsonProperty("progress")]
        public int Progress { get; set; }

        [JsonProperty("steps")]
        public WorkflowStepsTypeItem[] Steps { get; set; }

        [JsonProperty("tenantId")]
        public string TenantId { get; set; }

        [JsonProperty("updated")]
        public int Updated { get; set; }

        [JsonProperty("userId")]
        public string UserId { get; set; }

        [JsonProperty("viewAuthorizedGroups")]
        public string[] ViewAuthorizedGroups { get; set; }

        [JsonProperty("viewAuthorizedUsers")]
        public string[] ViewAuthorizedUsers { get; set; }

        [JsonProperty("watchers")]
        public WorkflowWatchersTypeItem[] Watchers { get; set; }

        [JsonProperty("workflowStatus")]
        public string WorkflowStatus { get; set; }
    }

    public class WorkflowStepsTypeItem
    {
        [JsonProperty("allowComments")]
        public bool AllowComments { get; set; }

        [JsonProperty("hideAttachments")]
        public bool HideAttachments { get; set; }

        [JsonProperty("hideWorkflowRecipients")]
        public bool HideWorkflowRecipients { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("invitePeriod")]
        public int InvitePeriod { get; set; }

        [JsonProperty("isFinished")]
        public bool IsFinished { get; set; }

        [JsonProperty("isStarted")]
        public bool IsStarted { get; set; }

        [JsonProperty("logs")]
        public JToken[] Logs { get; set; }

        [JsonProperty("maxInvites")]
        public int MaxInvites { get; set; }

        [JsonProperty("recipients")]
        public WorkflowStepsTypeItemRecipientsTypeItem[] Recipients { get; set; }

        [JsonProperty("requiredRecipients")]
        public int RequiredRecipients { get; set; }

        [JsonProperty("sendDownloadLink")]
        public bool SendDownloadLink { get; set; }

        [JsonProperty("stepType")]
        public string StepType { get; set; }

        [JsonProperty("validityPeriod")]
        public int ValidityPeriod { get; set; }
    }

    public class WorkflowStepsTypeItemRecipientsTypeItem
    {
        [JsonProperty("consentPageId")]
        public string ConsentPageId { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("phoneNumber")]
        public string PhoneNumber { get; set; }

        [JsonProperty("userId")]
        public string UserId { get; set; }
    }

    public class WorkflowWatchersTypeItem
    {
        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("notifiedEvents")]
        public string[] NotifiedEvents { get; set; }

        [JsonProperty("userId")]
        public string UserId { get; set; }
    }

    public class CreateWorkflowBodyInput
    {
        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("steps")]
        public Step[] Steps { get; set; }

        [JsonProperty("notifiedEvents")]
        public string[] NotifiedEvents { get; set; }

        [JsonProperty("watchers")]
        public BodyInputWatchersTypeItem[] Watchers { get; set; }

        [JsonProperty("templateId")]
        public string TemplateId { get; set; }

        [JsonProperty("layoutId")]
        public string LayoutId { get; set; }

        [JsonProperty("data1")]
        public string Data1 { get; set; }

        [JsonProperty("data2")]
        public string Data2 { get; set; }

        [JsonProperty("data3")]
        public string Data3 { get; set; }

        [JsonProperty("data4")]
        public string Data4 { get; set; }

        [JsonProperty("data5")]
        public string Data5 { get; set; }

        [JsonProperty("data6")]
        public string Data6 { get; set; }

        [JsonProperty("data7")]
        public string Data7 { get; set; }

        [JsonProperty("data8")]
        public string Data8 { get; set; }
    }

    public class Step
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("stepType")]
        public string StepType { get; set; }

        [JsonProperty("recipients")]
        public Recipient[] Recipients { get; set; }

        [JsonProperty("requiredRecipients")]
        public double? RequiredRecipients { get; set; }

        [JsonProperty("validityPeriod")]
        public double? ValidityPeriod { get; set; }

        [JsonProperty("inviteperiod")]
        public double? Inviteperiod { get; set; }

        [JsonProperty("maxInvites")]
        public double? MaxInvites { get; set; }

        [JsonProperty("sendDownloadLink")]
        public bool? SendDownloadLink { get; set; }

        [JsonProperty("allowComments")]
        public bool? AllowComments { get; set; }

        [JsonProperty("hideAttachments")]
        public bool? HideAttachments { get; set; }

        [JsonProperty("hideWorkflowRecipients")]
        public bool? HideWorkflowRecipients { get; set; }
    }

    public class Recipient
    {
        [JsonProperty("consentPageId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ConsentPageId { get; set; }

        [JsonProperty("email", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Email { get; set; }

        [JsonProperty("userId")]
        public string UserId { get; set; }

        [JsonProperty("phoneNumber")]
        public string PhoneNumber { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("preferredLocale")]
        public string PreferredLocale { get; set; }

        [JsonProperty("organizationId")]
        public string OrganizationId { get; set; }
    }

    public class BodyInputWatchersTypeItem
    {
        [JsonProperty("userId")]
        public string UserId { get; set; }

        [JsonProperty("notifiedEvents")]
        public string[] NotifiedEvents { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }
    }

    public class UpdateWorkflowBodyInput
    {
        [JsonProperty("userId")]
        public string UserId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("steps")]
        public Step[] Steps { get; set; }

        [JsonProperty("notifiedEvents")]
        public string[] NotifiedEvents { get; set; }

        [JsonProperty("watchers")]
        public BodyInputWatchersTypeItem[] Watchers { get; set; }

        [JsonProperty("workflowStatus")]
        public string WorkflowStatus { get; set; }

        [JsonProperty("data1")]
        public string Data1 { get; set; }

        [JsonProperty("data2")]
        public string Data2 { get; set; }

        [JsonProperty("data3")]
        public string Data3 { get; set; }

        [JsonProperty("data4")]
        public string Data4 { get; set; }

        [JsonProperty("data5")]
        public string Data5 { get; set; }

        [JsonProperty("data6")]
        public string Data6 { get; set; }

        [JsonProperty("data7")]
        public string Data7 { get; set; }

        [JsonProperty("data8")]
        public string Data8 { get; set; }
    }

    public class Workflows
    {
        [JsonProperty("items")]
        public Workflow[] Items { get; set; }

        [JsonProperty("itemsPerPage")]
        public int ItemsPerPage { get; set; }

        [JsonProperty("pageIndex")]
        public int PageIndex { get; set; }

        [JsonProperty("totalItems")]
        public int TotalItems { get; set; }
    }

    public class WorkflowInviteResponse
    {
        [JsonProperty("inviteUrl")]
        public string TheConsentPageUrlForTheConcernedRecipient { get; set; }
    }

    public class WorkflowInviteBodyInput
    {
        [JsonProperty("recipientEmail")]
        public string RecipientEmail { get; set; }
    }

    public class CreatePartResponse
    {
        [JsonProperty("documents")]
        public Document[] Documents { get; set; }

        [JsonProperty("ignoredAttachments")]
        public int IgnoredAttachments { get; set; }

        [JsonProperty("parts")]
        public CreateDocumentPartResponse[] Parts { get; set; }
    }

    public class Document
    {
        [JsonProperty("created")]
        public int Created { get; set; }

        [JsonProperty("groupId")]
        public string GroupId { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("parts")]
        public CreateDocumentPartResponse[] Parts { get; set; }

        [JsonProperty("pdfSignatureFields")]
        public CreateDocumentPdfSigFieldResponse[] PdfSignatureFields { get; set; }

        [JsonProperty("signatureProfileId")]
        public string SignatureProfileId { get; set; }

        [JsonProperty("tenantId")]
        public string TenantId { get; set; }

        [JsonProperty("updated")]
        public int Updated { get; set; }

        [JsonProperty("userId")]
        public string UserId { get; set; }

        [JsonProperty("viewAuthorizedGroups")]
        public string[] ViewAuthorizedGroups { get; set; }

        [JsonProperty("viewAuthorizedUsers")]
        public string[] ViewAuthorizedUsers { get; set; }

        [JsonProperty("workflowId")]
        public string WorkflowId { get; set; }

        [JsonProperty("workflowName")]
        public string WorkflowName { get; set; }
    }

    public class CreateDocumentPartResponse
    {
        [JsonProperty("contentType")]
        public string ContentType { get; set; }

        [JsonProperty("filename")]
        public string Filename { get; set; }

        [JsonProperty("hash")]
        public string Hash { get; set; }

        [JsonProperty("size")]
        public int Size { get; set; }
    }

    public class CreateDocumentPdfSigFieldResponse
    {
        [JsonProperty("imageHeight")]
        public double ImageHeight { get; set; }

        [JsonProperty("imagePage")]
        public double ImagePage { get; set; }

        [JsonProperty("imageWidth")]
        public double ImageWidth { get; set; }

        [JsonProperty("imageX")]
        public double ImageX { get; set; }

        [JsonProperty("imageY")]
        public double ImageY { get; set; }
    }

    public class CreateDocumentBodyInput
    {
        [JsonProperty("parts")]
        public CreateDocumentPart[] Parts { get; set; }

        [JsonProperty("signatureProfileId")]
        public string SignatureProfileId { get; set; }
    }

    public class CreateDocumentPart
    {
        [JsonProperty("contentType")]
        public string ContentType { get; set; }

        [JsonProperty("filename")]
        public string Filename { get; set; }

        [JsonProperty("hash")]
        public string Hash { get; set; }

        [JsonProperty("size")]
        public int? Size { get; set; }
    }

    public class UpdateDocumentBodyInput
    {
        [JsonProperty("signatureProfileId")]
        public string SignatureProfileId { get; set; }

        [JsonProperty("pdfSignatureFields")]
        public UpdateDocumentPdfSigField[] PdfSignatureFields { get; set; }
    }

    public class UpdateDocumentPdfSigField
    {
        [JsonProperty("imageHeight")]
        public double? ImageHeight { get; set; }

        [JsonProperty("imagePage")]
        public double? ImagePage { get; set; }

        [JsonProperty("imageWidth")]
        public double? ImageWidth { get; set; }

        [JsonProperty("imageX")]
        public double? ImageX { get; set; }

        [JsonProperty("imageY")]
        public double? ImageY { get; set; }
    }

    public class SearchDocumentsResponse
    {
        [JsonProperty("items")]
        public Documents Items { get; set; }
    }

    public class Documents
    {
        [JsonProperty("items")]
        public Document[] Items { get; set; }

        [JsonProperty("itemsPerPage")]
        public int ItemsPerPage { get; set; }

        [JsonProperty("pageIndex")]
        public int PageIndex { get; set; }

        [JsonProperty("totalItems")]
        public int TotalItems { get; set; }
    }

    public class Layout
    {
        [JsonProperty("created")]
        public double Created { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("isDisabled")]
        public bool IsDisabled { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("tenantId")]
        public string TenantId { get; set; }

        [JsonProperty("updated")]
        public double Updated { get; set; }

        [JsonProperty("dataConfigurations")]
        public LayoutDataConfigurationsTypeItem[] DataConfigurations { get; set; }
    }

    public class LayoutDataConfigurationsTypeItem
    {
        [JsonProperty("slot")]
        public string Slot { get; set; }

        [JsonProperty("default")]
        public string Default { get; set; }

        [JsonProperty("optional")]
        public bool Optional { get; set; }

        [JsonProperty("readonly")]
        public bool Readonly { get; set; }

        [JsonProperty("rememberLastValue")]
        public bool RememberLastValue { get; set; }
    }

    public class CreateLayoutBodyInput
    {
        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("isDisabled")]
        public bool? IsDisabled { get; set; }

        [JsonProperty("dataConfigurations")]
        public BodyInputDataConfigurationsTypeItem[] DataConfigurations { get; set; }
    }

    public class BodyInputDataConfigurationsTypeItem
    {
        [JsonProperty("slot")]
        public string Slot { get; set; }

        [JsonProperty("default")]
        public string Default { get; set; }

        [JsonProperty("optional")]
        public bool? Optional { get; set; }

        [JsonProperty("readonly")]
        public bool? Readonly { get; set; }

        [JsonProperty("rememberLastValue")]
        public bool? RememberLastValue { get; set; }
    }

    public class SearchLayoutsResponse
    {
        [JsonProperty("items")]
        public Layouts Items { get; set; }
    }

    public class Layouts
    {
        [JsonProperty("items")]
        public LayoutsItemsTypeItem[] Items { get; set; }

        [JsonProperty("itemsPerPage")]
        public double ItemsPerPage { get; set; }

        [JsonProperty("pageIndex")]
        public double PageIndex { get; set; }

        [JsonProperty("totalItems")]
        public double TotalItems { get; set; }
    }

    public class LayoutsItemsTypeItem
    {
        [JsonProperty("created")]
        public double Created { get; set; }

        [JsonProperty("dataConfigurations")]
        public Layout[] DataConfigurations { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Lexpowersign;

    public partial class WorkflowManagedActions
    {
        public LexpowersignActions Lexpowersign(string connectionId) => new LexpowersignActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public LexpowersignTriggers Lexpowersign(string connectionId) => new LexpowersignTriggers(connectionId);
    }
}