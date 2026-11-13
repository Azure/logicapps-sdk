//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Impower
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ImpowerActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impower")]
        public IBodyWorkflowAction<ErrorCodesUsingGetResponseItem[], ApiConnectionActionConfiguration> ErrorCodesUsingGet()
        {
            return new DeferredBodyAction<ErrorCodesUsingGetResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v1/error-codes";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ErrorCodesUsingGetResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impower")]
        public IBodyWorkflowAction<ErrorCodeDetailsDto, ApiConnectionActionConfiguration> ErrorCodeUsingGet(Expression<Func<ValueInput>> value)
        {
            var __workflow_value = WorkflowExpression.Compile(value, nameof(value), required: true);
            return new DeferredBodyAction<ErrorCodeDetailsDto, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/error-codes/{0}", __workflow_value.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ErrorCodeDetailsDto>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impower")]
        public IBodyWorkflowAction<ConnectionDto, ApiConnectionActionConfiguration> UpdateConnectionUsingPut(Expression<Func<int>> connectionIdX, Expression<Func<ConnectionUpdateDtoInput>> connectionUpdateDto = null)
        {
            var __workflow_connectionIdX = WorkflowExpression.Compile(connectionIdX, nameof(connectionIdX), required: true);
            var __workflow_connectionUpdateDto = WorkflowExpression.Compile(connectionUpdateDto, nameof(connectionUpdateDto), required: false);
            return new DeferredBodyAction<ConnectionDto, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/connections/{0}", __workflow_connectionIdX.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_connectionUpdateDto != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_connectionUpdateDto);
                return new ApiConnectionAction<ConnectionDto>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impower")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteConnectionUsingDelete(Expression<Func<int>> connectionIdX)
        {
            var __workflow_connectionIdX = WorkflowExpression.Compile(connectionIdX, nameof(connectionIdX), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/connections/{0}", __workflow_connectionIdX.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impower")]
        public IBodyWorkflowAction<ConnectionDto, ApiConnectionActionConfiguration> GetConnectionUsingGet(Expression<Func<int>> connectionIdX)
        {
            var __workflow_connectionIdX = WorkflowExpression.Compile(connectionIdX, nameof(connectionIdX), required: true);
            return new DeferredBodyAction<ConnectionDto, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/connections/{0}", __workflow_connectionIdX.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ConnectionDto>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impower")]
        public IBodyWorkflowAction<PageOfContactDto, ApiConnectionActionConfiguration> GetContactsByFilterUsingGet(Expression<Func<int[]>> contactIds = null, Expression<Func<string>> email = null, Expression<Func<string>> name = null, Expression<Func<OrderInput>> order = null, Expression<Func<int>> page = null, Expression<Func<int>> size = null, Expression<Func<string>> sort = null)
        {
            var __workflow_contactIds = WorkflowExpression.Compile(contactIds, nameof(contactIds), required: false);
            var __workflow_email = WorkflowExpression.Compile(email, nameof(email), required: false);
            var __workflow_name = WorkflowExpression.Compile(name, nameof(name), required: false);
            var __workflow_order = WorkflowExpression.Compile(order, nameof(order), required: false);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_size = WorkflowExpression.Compile(size, nameof(size), required: false);
            var __workflow_sort = WorkflowExpression.Compile(sort, nameof(sort), required: false);
            return new DeferredBodyAction<PageOfContactDto, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/contacts";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_contactIds != null)
                    callPayload.Queries["contactIds"] = ExpressionConverter.Convert(__workflow_contactIds);
                if (__workflow_email != null)
                    callPayload.Queries["email"] = ExpressionConverter.Convert(__workflow_email);
                if (__workflow_name != null)
                    callPayload.Queries["name"] = ExpressionConverter.Convert(__workflow_name);
                if (__workflow_order != null)
                    callPayload.Queries["order"] = ExpressionConverter.Convert(__workflow_order);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_size != null)
                    callPayload.Queries["size"] = ExpressionConverter.Convert(__workflow_size);
                if (__workflow_sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(__workflow_sort);
                return new ApiConnectionAction<PageOfContactDto>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impower")]
        public IBodyWorkflowAction<ContactDto, ApiConnectionActionConfiguration> GetContactByIdUsingGet(Expression<Func<int>> contactId)
        {
            var __workflow_contactId = WorkflowExpression.Compile(contactId, nameof(contactId), required: true);
            return new DeferredBodyAction<ContactDto, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/contacts/{0}", __workflow_contactId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ContactDto>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impower")]
        public IBodyWorkflowAction<PageOfContractDto, ApiConnectionActionConfiguration> GetContractsByFilterUsingGet(Expression<Func<int>> contactId = null, Expression<Func<int[]>> contractIds = null, Expression<Func<OrderInput>> order = null, Expression<Func<int>> page = null, Expression<Func<int>> propertyId = null, Expression<Func<int>> size = null, Expression<Func<string>> sort = null, Expression<Func<TypeInputItem[]>> type = null, Expression<Func<int>> unitId = null, Expression<Func<string>> validAtDate = null)
        {
            var __workflow_contactId = WorkflowExpression.Compile(contactId, nameof(contactId), required: false);
            var __workflow_contractIds = WorkflowExpression.Compile(contractIds, nameof(contractIds), required: false);
            var __workflow_order = WorkflowExpression.Compile(order, nameof(order), required: false);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_propertyId = WorkflowExpression.Compile(propertyId, nameof(propertyId), required: false);
            var __workflow_size = WorkflowExpression.Compile(size, nameof(size), required: false);
            var __workflow_sort = WorkflowExpression.Compile(sort, nameof(sort), required: false);
            var __workflow_type = WorkflowExpression.Compile(type, nameof(type), required: false);
            var __workflow_unitId = WorkflowExpression.Compile(unitId, nameof(unitId), required: false);
            var __workflow_validAtDate = WorkflowExpression.Compile(validAtDate, nameof(validAtDate), required: false);
            return new DeferredBodyAction<PageOfContractDto, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/contracts";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_contactId != null)
                    callPayload.Queries["contactId"] = ExpressionConverter.Convert(__workflow_contactId);
                if (__workflow_contractIds != null)
                    callPayload.Queries["contractIds"] = ExpressionConverter.Convert(__workflow_contractIds);
                if (__workflow_order != null)
                    callPayload.Queries["order"] = ExpressionConverter.Convert(__workflow_order);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_propertyId != null)
                    callPayload.Queries["propertyId"] = ExpressionConverter.Convert(__workflow_propertyId);
                if (__workflow_size != null)
                    callPayload.Queries["size"] = ExpressionConverter.Convert(__workflow_size);
                if (__workflow_sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(__workflow_sort);
                if (__workflow_type != null)
                    callPayload.Queries["type"] = ExpressionConverter.Convert(__workflow_type);
                if (__workflow_unitId != null)
                    callPayload.Queries["unitId"] = ExpressionConverter.Convert(__workflow_unitId);
                if (__workflow_validAtDate != null)
                    callPayload.Queries["validAtDate"] = ExpressionConverter.Convert(__workflow_validAtDate);
                return new ApiConnectionAction<PageOfContractDto>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impower")]
        public IBodyWorkflowAction<ContractDto, ApiConnectionActionConfiguration> GetContractByIdUsingGet(Expression<Func<int>> contractId)
        {
            var __workflow_contractId = WorkflowExpression.Compile(contractId, nameof(contractId), required: true);
            return new DeferredBodyAction<ContractDto, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/contracts/{0}", __workflow_contractId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ContractDto>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impower")]
        public IBodyWorkflowAction<DocumentTagDto[], ApiConnectionActionConfiguration> GetDocumentTagsUsingGet(Expression<Func<string>> description = null)
        {
            var __workflow_description = WorkflowExpression.Compile(description, nameof(description), required: false);
            return new DeferredBodyAction<DocumentTagDto[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/document-tags";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_description != null)
                    callPayload.Queries["description"] = ExpressionConverter.Convert(__workflow_description);
                return new ApiConnectionAction<DocumentTagDto[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impower")]
        public IBodyWorkflowAction<DocumentTagDto, ApiConnectionActionConfiguration> CreateDocumentTagUsing(Expression<Func<CreateDtoInput>> createDto)
        {
            var __workflow_createDto = WorkflowExpression.Compile(createDto, nameof(createDto), required: true);
            return new DeferredBodyAction<DocumentTagDto, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/document-tags";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_createDto);
                return new ApiConnectionAction<DocumentTagDto>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impower")]
        public IBodyWorkflowAction<DocumentTagDto, ApiConnectionActionConfiguration> UpdateDocumentTagUsingPut(Expression<Func<int>> tagId, Expression<Func<UpdateDocumentTagUsingPutUpdateDtoInput>> updateDto)
        {
            var __workflow_tagId = WorkflowExpression.Compile(tagId, nameof(tagId), required: true);
            var __workflow_updateDto = WorkflowExpression.Compile(updateDto, nameof(updateDto), required: true);
            return new DeferredBodyAction<DocumentTagDto, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/document-tags/{0}", __workflow_tagId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_updateDto);
                return new ApiConnectionAction<DocumentTagDto>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impower")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteDocumentTagUsingDelete(Expression<Func<int>> tagId)
        {
            var __workflow_tagId = WorkflowExpression.Compile(tagId, nameof(tagId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/document-tags/{0}", __workflow_tagId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impower")]
        public IBodyWorkflowAction<PageOfDocumentDto, ApiConnectionActionConfiguration> GetDocumentsByFilterUsingGet(Expression<Func<string>> accountant = null, Expression<Func<string>> administrator = null, Expression<Func<int>> contactId = null, Expression<Func<string>> contractName = null, Expression<Func<int[]>> documentIds = null, Expression<Func<string>> documentName = null, Expression<Func<string>> issuedDate = null, Expression<Func<string>> maxIssuedDate = null, Expression<Func<string>> minIssuedDate = null, Expression<Func<OrderInput>> order = null, Expression<Func<int>> page = null, Expression<Func<string>> propertyHrId = null, Expression<Func<int>> propertyId = null, Expression<Func<string>> propertyName = null, Expression<Func<int>> size = null, Expression<Func<string>> sort = null, Expression<Func<int>> sourceId = null, Expression<Func<SourceTypeInputItem[]>> sourceType = null, Expression<Func<int[]>> tagIds = null, Expression<Func<string>> tagName = null, Expression<Func<int>> unitId = null)
        {
            var __workflow_accountant = WorkflowExpression.Compile(accountant, nameof(accountant), required: false);
            var __workflow_administrator = WorkflowExpression.Compile(administrator, nameof(administrator), required: false);
            var __workflow_contactId = WorkflowExpression.Compile(contactId, nameof(contactId), required: false);
            var __workflow_contractName = WorkflowExpression.Compile(contractName, nameof(contractName), required: false);
            var __workflow_documentIds = WorkflowExpression.Compile(documentIds, nameof(documentIds), required: false);
            var __workflow_documentName = WorkflowExpression.Compile(documentName, nameof(documentName), required: false);
            var __workflow_issuedDate = WorkflowExpression.Compile(issuedDate, nameof(issuedDate), required: false);
            var __workflow_maxIssuedDate = WorkflowExpression.Compile(maxIssuedDate, nameof(maxIssuedDate), required: false);
            var __workflow_minIssuedDate = WorkflowExpression.Compile(minIssuedDate, nameof(minIssuedDate), required: false);
            var __workflow_order = WorkflowExpression.Compile(order, nameof(order), required: false);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_propertyHrId = WorkflowExpression.Compile(propertyHrId, nameof(propertyHrId), required: false);
            var __workflow_propertyId = WorkflowExpression.Compile(propertyId, nameof(propertyId), required: false);
            var __workflow_propertyName = WorkflowExpression.Compile(propertyName, nameof(propertyName), required: false);
            var __workflow_size = WorkflowExpression.Compile(size, nameof(size), required: false);
            var __workflow_sort = WorkflowExpression.Compile(sort, nameof(sort), required: false);
            var __workflow_sourceId = WorkflowExpression.Compile(sourceId, nameof(sourceId), required: false);
            var __workflow_sourceType = WorkflowExpression.Compile(sourceType, nameof(sourceType), required: false);
            var __workflow_tagIds = WorkflowExpression.Compile(tagIds, nameof(tagIds), required: false);
            var __workflow_tagName = WorkflowExpression.Compile(tagName, nameof(tagName), required: false);
            var __workflow_unitId = WorkflowExpression.Compile(unitId, nameof(unitId), required: false);
            return new DeferredBodyAction<PageOfDocumentDto, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/documents";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_accountant != null)
                    callPayload.Queries["accountant"] = ExpressionConverter.Convert(__workflow_accountant);
                if (__workflow_administrator != null)
                    callPayload.Queries["administrator"] = ExpressionConverter.Convert(__workflow_administrator);
                if (__workflow_contactId != null)
                    callPayload.Queries["contactId"] = ExpressionConverter.Convert(__workflow_contactId);
                if (__workflow_contractName != null)
                    callPayload.Queries["contractName"] = ExpressionConverter.Convert(__workflow_contractName);
                if (__workflow_documentIds != null)
                    callPayload.Queries["documentIds"] = ExpressionConverter.Convert(__workflow_documentIds);
                if (__workflow_documentName != null)
                    callPayload.Queries["documentName"] = ExpressionConverter.Convert(__workflow_documentName);
                if (__workflow_issuedDate != null)
                    callPayload.Queries["issuedDate"] = ExpressionConverter.Convert(__workflow_issuedDate);
                if (__workflow_maxIssuedDate != null)
                    callPayload.Queries["maxIssuedDate"] = ExpressionConverter.Convert(__workflow_maxIssuedDate);
                if (__workflow_minIssuedDate != null)
                    callPayload.Queries["minIssuedDate"] = ExpressionConverter.Convert(__workflow_minIssuedDate);
                if (__workflow_order != null)
                    callPayload.Queries["order"] = ExpressionConverter.Convert(__workflow_order);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_propertyHrId != null)
                    callPayload.Queries["propertyHrId"] = ExpressionConverter.Convert(__workflow_propertyHrId);
                if (__workflow_propertyId != null)
                    callPayload.Queries["propertyId"] = ExpressionConverter.Convert(__workflow_propertyId);
                if (__workflow_propertyName != null)
                    callPayload.Queries["propertyName"] = ExpressionConverter.Convert(__workflow_propertyName);
                if (__workflow_size != null)
                    callPayload.Queries["size"] = ExpressionConverter.Convert(__workflow_size);
                if (__workflow_sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(__workflow_sort);
                if (__workflow_sourceId != null)
                    callPayload.Queries["sourceId"] = ExpressionConverter.Convert(__workflow_sourceId);
                if (__workflow_sourceType != null)
                    callPayload.Queries["sourceType"] = ExpressionConverter.Convert(__workflow_sourceType);
                if (__workflow_tagIds != null)
                    callPayload.Queries["tagIds"] = ExpressionConverter.Convert(__workflow_tagIds);
                if (__workflow_tagName != null)
                    callPayload.Queries["tagName"] = ExpressionConverter.Convert(__workflow_tagName);
                if (__workflow_unitId != null)
                    callPayload.Queries["unitId"] = ExpressionConverter.Convert(__workflow_unitId);
                return new ApiConnectionAction<PageOfDocumentDto>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impower")]
        public IBodyWorkflowAction<DocumentDto[], ApiConnectionActionConfiguration> UpdateDocumentsUsingPut(Expression<Func<DocumentUpdateDto[]>> documentUpdateDtos)
        {
            var __workflow_documentUpdateDtos = WorkflowExpression.Compile(documentUpdateDtos, nameof(documentUpdateDtos), required: true);
            return new DeferredBodyAction<DocumentDto[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/documents";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_documentUpdateDtos);
                return new ApiConnectionAction<DocumentDto[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impower")]
        public IBodyWorkflowAction<object, ApiConnectionActionConfiguration> DownloadDocumentsByFilterUsingGet(Expression<Func<string>> accountant = null, Expression<Func<string>> administrator = null, Expression<Func<int>> contactId = null, Expression<Func<string>> contractName = null, Expression<Func<int[]>> documentIds = null, Expression<Func<string>> documentName = null, Expression<Func<string>> issuedDate = null, Expression<Func<string>> maxIssuedDate = null, Expression<Func<string>> minIssuedDate = null, Expression<Func<string>> propertyHrId = null, Expression<Func<int>> propertyId = null, Expression<Func<string>> propertyName = null, Expression<Func<int>> sourceId = null, Expression<Func<SourceTypeInputItem[]>> sourceType = null, Expression<Func<int[]>> tagIds = null, Expression<Func<string>> tagName = null, Expression<Func<int>> unitId = null)
        {
            var __workflow_accountant = WorkflowExpression.Compile(accountant, nameof(accountant), required: false);
            var __workflow_administrator = WorkflowExpression.Compile(administrator, nameof(administrator), required: false);
            var __workflow_contactId = WorkflowExpression.Compile(contactId, nameof(contactId), required: false);
            var __workflow_contractName = WorkflowExpression.Compile(contractName, nameof(contractName), required: false);
            var __workflow_documentIds = WorkflowExpression.Compile(documentIds, nameof(documentIds), required: false);
            var __workflow_documentName = WorkflowExpression.Compile(documentName, nameof(documentName), required: false);
            var __workflow_issuedDate = WorkflowExpression.Compile(issuedDate, nameof(issuedDate), required: false);
            var __workflow_maxIssuedDate = WorkflowExpression.Compile(maxIssuedDate, nameof(maxIssuedDate), required: false);
            var __workflow_minIssuedDate = WorkflowExpression.Compile(minIssuedDate, nameof(minIssuedDate), required: false);
            var __workflow_propertyHrId = WorkflowExpression.Compile(propertyHrId, nameof(propertyHrId), required: false);
            var __workflow_propertyId = WorkflowExpression.Compile(propertyId, nameof(propertyId), required: false);
            var __workflow_propertyName = WorkflowExpression.Compile(propertyName, nameof(propertyName), required: false);
            var __workflow_sourceId = WorkflowExpression.Compile(sourceId, nameof(sourceId), required: false);
            var __workflow_sourceType = WorkflowExpression.Compile(sourceType, nameof(sourceType), required: false);
            var __workflow_tagIds = WorkflowExpression.Compile(tagIds, nameof(tagIds), required: false);
            var __workflow_tagName = WorkflowExpression.Compile(tagName, nameof(tagName), required: false);
            var __workflow_unitId = WorkflowExpression.Compile(unitId, nameof(unitId), required: false);
            return new DeferredBodyAction<object, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/documents/download-zip";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_accountant != null)
                    callPayload.Queries["accountant"] = ExpressionConverter.Convert(__workflow_accountant);
                if (__workflow_administrator != null)
                    callPayload.Queries["administrator"] = ExpressionConverter.Convert(__workflow_administrator);
                if (__workflow_contactId != null)
                    callPayload.Queries["contactId"] = ExpressionConverter.Convert(__workflow_contactId);
                if (__workflow_contractName != null)
                    callPayload.Queries["contractName"] = ExpressionConverter.Convert(__workflow_contractName);
                if (__workflow_documentIds != null)
                    callPayload.Queries["documentIds"] = ExpressionConverter.Convert(__workflow_documentIds);
                if (__workflow_documentName != null)
                    callPayload.Queries["documentName"] = ExpressionConverter.Convert(__workflow_documentName);
                if (__workflow_issuedDate != null)
                    callPayload.Queries["issuedDate"] = ExpressionConverter.Convert(__workflow_issuedDate);
                if (__workflow_maxIssuedDate != null)
                    callPayload.Queries["maxIssuedDate"] = ExpressionConverter.Convert(__workflow_maxIssuedDate);
                if (__workflow_minIssuedDate != null)
                    callPayload.Queries["minIssuedDate"] = ExpressionConverter.Convert(__workflow_minIssuedDate);
                if (__workflow_propertyHrId != null)
                    callPayload.Queries["propertyHrId"] = ExpressionConverter.Convert(__workflow_propertyHrId);
                if (__workflow_propertyId != null)
                    callPayload.Queries["propertyId"] = ExpressionConverter.Convert(__workflow_propertyId);
                if (__workflow_propertyName != null)
                    callPayload.Queries["propertyName"] = ExpressionConverter.Convert(__workflow_propertyName);
                if (__workflow_sourceId != null)
                    callPayload.Queries["sourceId"] = ExpressionConverter.Convert(__workflow_sourceId);
                if (__workflow_sourceType != null)
                    callPayload.Queries["sourceType"] = ExpressionConverter.Convert(__workflow_sourceType);
                if (__workflow_tagIds != null)
                    callPayload.Queries["tagIds"] = ExpressionConverter.Convert(__workflow_tagIds);
                if (__workflow_tagName != null)
                    callPayload.Queries["tagName"] = ExpressionConverter.Convert(__workflow_tagName);
                if (__workflow_unitId != null)
                    callPayload.Queries["unitId"] = ExpressionConverter.Convert(__workflow_unitId);
                return new ApiConnectionAction<object>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impower")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteDocumentUsingDelete(Expression<Func<int>> documentId)
        {
            var __workflow_documentId = WorkflowExpression.Compile(documentId, nameof(documentId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/documents/{0}", __workflow_documentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impower")]
        public IBodyWorkflowAction<object, ApiConnectionActionConfiguration> DownloadUsingGet(Expression<Func<int>> documentId)
        {
            var __workflow_documentId = WorkflowExpression.Compile(documentId, nameof(documentId), required: true);
            return new DeferredBodyAction<object, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/documents/{0}/download", __workflow_documentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<object>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impower")]
        public IBodyWorkflowAction<InvoiceItemDto, ApiConnectionActionConfiguration> UpdateInvoiceItemUsingPut(Expression<Func<int>> invoiceItemId, Expression<Func<UpdateInvoiceItemUsingPutUpdateDtoInput>> updateDto)
        {
            var __workflow_invoiceItemId = WorkflowExpression.Compile(invoiceItemId, nameof(invoiceItemId), required: true);
            var __workflow_updateDto = WorkflowExpression.Compile(updateDto, nameof(updateDto), required: true);
            return new DeferredBodyAction<InvoiceItemDto, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/invoice-items/{0}", __workflow_invoiceItemId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_updateDto);
                return new ApiConnectionAction<InvoiceItemDto>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impower")]
        public IBodyWorkflowAction<PageOfInvoiceDto, ApiConnectionActionConfiguration> GetInvoicesByFilterUsingGet(Expression<Func<int>> counterpartContactId = null, Expression<Func<string>> issuedDate = null, Expression<Func<OrderInput>> order = null, Expression<Func<int>> page = null, Expression<Func<int>> propertyId = null, Expression<Func<int>> size = null, Expression<Func<string>> sort = null, Expression<Func<StatesInputItem[]>> states = null)
        {
            var __workflow_counterpartContactId = WorkflowExpression.Compile(counterpartContactId, nameof(counterpartContactId), required: false);
            var __workflow_issuedDate = WorkflowExpression.Compile(issuedDate, nameof(issuedDate), required: false);
            var __workflow_order = WorkflowExpression.Compile(order, nameof(order), required: false);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_propertyId = WorkflowExpression.Compile(propertyId, nameof(propertyId), required: false);
            var __workflow_size = WorkflowExpression.Compile(size, nameof(size), required: false);
            var __workflow_sort = WorkflowExpression.Compile(sort, nameof(sort), required: false);
            var __workflow_states = WorkflowExpression.Compile(states, nameof(states), required: false);
            return new DeferredBodyAction<PageOfInvoiceDto, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/invoices";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_counterpartContactId != null)
                    callPayload.Queries["counterpartContactId"] = ExpressionConverter.Convert(__workflow_counterpartContactId);
                if (__workflow_issuedDate != null)
                    callPayload.Queries["issuedDate"] = ExpressionConverter.Convert(__workflow_issuedDate);
                if (__workflow_order != null)
                    callPayload.Queries["order"] = ExpressionConverter.Convert(__workflow_order);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_propertyId != null)
                    callPayload.Queries["propertyId"] = ExpressionConverter.Convert(__workflow_propertyId);
                if (__workflow_size != null)
                    callPayload.Queries["size"] = ExpressionConverter.Convert(__workflow_size);
                if (__workflow_sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(__workflow_sort);
                if (__workflow_states != null)
                    callPayload.Queries["states"] = ExpressionConverter.Convert(__workflow_states);
                return new ApiConnectionAction<PageOfInvoiceDto>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impower")]
        public IBodyWorkflowAction<InvoiceDto, ApiConnectionActionConfiguration> GetInvoiceByIdUsingGet(Expression<Func<int>> invoiceId)
        {
            var __workflow_invoiceId = WorkflowExpression.Compile(invoiceId, nameof(invoiceId), required: true);
            return new DeferredBodyAction<InvoiceDto, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/invoices/{0}", __workflow_invoiceId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<InvoiceDto>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impower")]
        public IBodyWorkflowAction<InvoiceDto, ApiConnectionActionConfiguration> UpdateInvoiceUsingPut(Expression<Func<int>> invoiceId, Expression<Func<UpdateInvoiceUsingPutUpdateDtoInput>> updateDto)
        {
            var __workflow_invoiceId = WorkflowExpression.Compile(invoiceId, nameof(invoiceId), required: true);
            var __workflow_updateDto = WorkflowExpression.Compile(updateDto, nameof(updateDto), required: true);
            return new DeferredBodyAction<InvoiceDto, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/invoices/{0}", __workflow_invoiceId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_updateDto);
                return new ApiConnectionAction<InvoiceDto>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impower")]
        public IBodyWorkflowAction<PageOfPropertyDto, ApiConnectionActionConfiguration> GetPropertiesByFilterUsingGet(Expression<Func<string>> name = null, Expression<Func<OrderInput>> order = null, Expression<Func<int>> page = null, Expression<Func<string>> propertyHrId = null, Expression<Func<int>> size = null, Expression<Func<string>> sort = null)
        {
            var __workflow_name = WorkflowExpression.Compile(name, nameof(name), required: false);
            var __workflow_order = WorkflowExpression.Compile(order, nameof(order), required: false);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_propertyHrId = WorkflowExpression.Compile(propertyHrId, nameof(propertyHrId), required: false);
            var __workflow_size = WorkflowExpression.Compile(size, nameof(size), required: false);
            var __workflow_sort = WorkflowExpression.Compile(sort, nameof(sort), required: false);
            return new DeferredBodyAction<PageOfPropertyDto, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/properties";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_name != null)
                    callPayload.Queries["name"] = ExpressionConverter.Convert(__workflow_name);
                if (__workflow_order != null)
                    callPayload.Queries["order"] = ExpressionConverter.Convert(__workflow_order);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_propertyHrId != null)
                    callPayload.Queries["propertyHrId"] = ExpressionConverter.Convert(__workflow_propertyHrId);
                if (__workflow_size != null)
                    callPayload.Queries["size"] = ExpressionConverter.Convert(__workflow_size);
                if (__workflow_sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(__workflow_sort);
                return new ApiConnectionAction<PageOfPropertyDto>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impower")]
        public IBodyWorkflowAction<PropertyDto, ApiConnectionActionConfiguration> GetPropertyByIdUsingGet(Expression<Func<int>> propertyId)
        {
            var __workflow_propertyId = WorkflowExpression.Compile(propertyId, nameof(propertyId), required: true);
            return new DeferredBodyAction<PropertyDto, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/properties/{0}", __workflow_propertyId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<PropertyDto>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impower")]
        public IBodyWorkflowAction<PageOfUnitDto, ApiConnectionActionConfiguration> GetUnitsByFilterUsingGet(Expression<Func<OrderInput>> order = null, Expression<Func<int>> page = null, Expression<Func<int>> propertyId = null, Expression<Func<int>> size = null, Expression<Func<string>> sort = null)
        {
            var __workflow_order = WorkflowExpression.Compile(order, nameof(order), required: false);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_propertyId = WorkflowExpression.Compile(propertyId, nameof(propertyId), required: false);
            var __workflow_size = WorkflowExpression.Compile(size, nameof(size), required: false);
            var __workflow_sort = WorkflowExpression.Compile(sort, nameof(sort), required: false);
            return new DeferredBodyAction<PageOfUnitDto, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/units";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_order != null)
                    callPayload.Queries["order"] = ExpressionConverter.Convert(__workflow_order);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_propertyId != null)
                    callPayload.Queries["propertyId"] = ExpressionConverter.Convert(__workflow_propertyId);
                if (__workflow_size != null)
                    callPayload.Queries["size"] = ExpressionConverter.Convert(__workflow_size);
                if (__workflow_sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(__workflow_sort);
                return new ApiConnectionAction<PageOfUnitDto>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impower")]
        public IBodyWorkflowAction<UnitDto, ApiConnectionActionConfiguration> GetUnitByIdUsingGet(Expression<Func<int>> unitId)
        {
            var __workflow_unitId = WorkflowExpression.Compile(unitId, nameof(unitId), required: true);
            return new DeferredBodyAction<UnitDto, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/units/{0}", __workflow_unitId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<UnitDto>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impower")]
        public IBodyWorkflowAction<LegacyInvoiceDto, ApiConnectionActionConfiguration> GetInvoice(Expression<Func<int>> invoiceId)
        {
            var __workflow_invoiceId = WorkflowExpression.Compile(invoiceId, nameof(invoiceId), required: true);
            return new DeferredBodyAction<LegacyInvoiceDto, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/services/pmp-accounting/api/v1/invoices/id";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["invoiceId"] = ExpressionConverter.Convert(__workflow_invoiceId);
                return new ApiConnectionAction<LegacyInvoiceDto>(callPayload);
            });
        }
    }

    public class ImpowerTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<ConnectionDto, ApiConnectionPollingTriggerConfiguration> CreateConnectionUsingPost()
        {
            return new DeferredBodyTrigger<ConnectionDto, ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/v2/connections";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = new ConnectionCreateDtoInput().ToJToken();
                return new ApiConnectionPollingTrigger<ConnectionDto>(callPayload);
            });
        }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ErrorCodesUsingGetResponseItem
    {
        [EnumMember(Value = "BAD_CONTACT_ADDRESS")]
        BadContactAddress,
        [EnumMember(Value = "BAD_TYPE_OF_EP")]
        BadTypeOfEp,
        [EnumMember(Value = "BAD_STATE_OF_EP")]
        BadStateOfEp,
        [EnumMember(Value = "DUPLICATE_START_DATE")]
        DuplicateStartDate,
        [EnumMember(Value = "MISSING_CORRECTION_BOOKING_DATE")]
        MissingCorrectionBookingDate,
        [EnumMember(Value = "INVALID_ACCOUNT_AMOUNTS")]
        InvalidAccountAmounts,
        [EnumMember(Value = "INVALID_PROPERTY")]
        InvalidProperty,
        [EnumMember(Value = "NOT_FOUND")]
        NotFound,
        [EnumMember(Value = "MUST_REGENERATE_HGA")]
        MustRegenerateHga,
        [EnumMember(Value = "FAILED_RETRIEVING_REQUIRED_DATA")]
        FailedRetrievingRequiredData,
        [EnumMember(Value = "WATERMARK_PDF_MUST_BE_ONE_PAGE")]
        WatermarkPdfMustBeOnePage,
        [EnumMember(Value = "DOCUMENT_DOCUMENT_IS_REFERENCED")]
        DocumentDocumentIsReferenced,
        [EnumMember(Value = "DS_NAME_NOT_UNIQUE")]
        DsNameNotUnique,
        [EnumMember(Value = "DV_INVALID_START_END_DATE_MARKERS")]
        DvInvalidStartEndDateMarkers,
        [EnumMember(Value = "DV_INVALID")]
        DvInvalid,
        [EnumMember(Value = "USER_DOMAIN_ALREADY_EXISTS")]
        UserDomainAlreadyExists,
        [EnumMember(Value = "USER_DOMAIN_REGISTRATION_DISABLED")]
        UserDomainRegistrationDisabled,
        [EnumMember(Value = "COMMON_VALIDATION_INVALID_DATA")]
        CommonValidationInvalidData,
        [EnumMember(Value = "WEG_OWNED_UNIT_CANNOT_HAVE_OWNER_CONTRACT")]
        WegOwnedUnitCannotHaveOwnerContract
    }

    public class ErrorCodeDetailsDto
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ValueInput
    {
        [EnumMember(Value = "BAD_CONTACT_ADDRESS")]
        BadContactAddress,
        [EnumMember(Value = "BAD_TYPE_OF_EP")]
        BadTypeOfEp,
        [EnumMember(Value = "BAD_STATE_OF_EP")]
        BadStateOfEp,
        [EnumMember(Value = "DUPLICATE_START_DATE")]
        DuplicateStartDate,
        [EnumMember(Value = "MISSING_CORRECTION_BOOKING_DATE")]
        MissingCorrectionBookingDate,
        [EnumMember(Value = "INVALID_ACCOUNT_AMOUNTS")]
        InvalidAccountAmounts,
        [EnumMember(Value = "INVALID_PROPERTY")]
        InvalidProperty,
        [EnumMember(Value = "NOT_FOUND")]
        NotFound,
        [EnumMember(Value = "MUST_REGENERATE_HGA")]
        MustRegenerateHga,
        [EnumMember(Value = "FAILED_RETRIEVING_REQUIRED_DATA")]
        FailedRetrievingRequiredData,
        [EnumMember(Value = "WATERMARK_PDF_MUST_BE_ONE_PAGE")]
        WatermarkPdfMustBeOnePage,
        [EnumMember(Value = "DOCUMENT_DOCUMENT_IS_REFERENCED")]
        DocumentDocumentIsReferenced,
        [EnumMember(Value = "DS_NAME_NOT_UNIQUE")]
        DsNameNotUnique,
        [EnumMember(Value = "DV_INVALID_START_END_DATE_MARKERS")]
        DvInvalidStartEndDateMarkers,
        [EnumMember(Value = "DV_INVALID")]
        DvInvalid,
        [EnumMember(Value = "USER_DOMAIN_ALREADY_EXISTS")]
        UserDomainAlreadyExists,
        [EnumMember(Value = "USER_DOMAIN_REGISTRATION_DISABLED")]
        UserDomainRegistrationDisabled,
        [EnumMember(Value = "COMMON_VALIDATION_INVALID_DATA")]
        CommonValidationInvalidData,
        [EnumMember(Value = "WEG_OWNED_UNIT_CANNOT_HAVE_OWNER_CONTRACT")]
        WegOwnedUnitCannotHaveOwnerContract
    }

    public class ConnectionDto
    {
        [JsonProperty("appId")]
        public int IdOfAnApplication { get; set; }

        [JsonProperty("appName")]
        public string NameOfTheApplicationOfTheConnection { get; set; }

        [JsonProperty("created")]
        public string CreationTimeOfTheEntity { get; set; }

        [JsonProperty("id")]
        public int IdOfTheEntity { get; set; }

        [JsonProperty("name")]
        public string NameOfTheConnection { get; set; }

        [JsonProperty("updated")]
        public string LastUpdateTimeOfTheEntity { get; set; }

        [JsonProperty("webhookUrl")]
        public string WebhookUrl { get; set; }
    }

    public class ConnectionUpdateDtoInput
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("webhookUrl")]
        public string WebhookUrl { get; set; }
    }

    public class PageOfContactDto
    {
        [JsonProperty("content")]
        public ContactDto[] Content { get; set; }

        [JsonProperty("empty")]
        public bool Empty { get; set; }

        [JsonProperty("first")]
        public bool First { get; set; }

        [JsonProperty("last")]
        public bool Last { get; set; }

        [JsonProperty("number")]
        public int Number { get; set; }

        [JsonProperty("numberOfElements")]
        public int NumberOfElements { get; set; }

        [JsonProperty("pageable")]
        public Pageable Pageable { get; set; }

        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("sort")]
        public Sort Sort { get; set; }

        [JsonProperty("totalElements")]
        public int TotalElements { get; set; }

        [JsonProperty("totalPages")]
        public int TotalPages { get; set; }
    }

    public class ContactDto
    {
        [JsonProperty("city")]
        public string NameOfTheCity { get; set; }

        [JsonProperty("companyName")]
        public string NameOfTheCompanyInCaseTheContactIsACompany { get; set; }

        [JsonProperty("country")]
        public string CountryCodeAccordingToIso31661Alpha2Standard { get; set; }

        [JsonProperty("created")]
        public string CreationTimeOfTheContact { get; set; }

        [JsonProperty("details")]
        public ContactDetailsDto Details { get; set; }

        [JsonProperty("firstName")]
        public string FirstNameOfTheContactInCaseTheContactIsAPerson { get; set; }

        [JsonProperty("id")]
        public int IdOfTheContactInstance { get; set; }

        [JsonProperty("lastName")]
        public string LastNameOfTheContactInCaseTheContactIsAPerson { get; set; }

        [JsonProperty("number")]
        public string StreetNumber { get; set; }

        [JsonProperty("postalCode")]
        public string PostalCode { get; set; }

        [JsonProperty("recipientName")]
        public string RecipientNameOfTheContact { get; set; }

        [JsonProperty("salutation")]
        public string AStandardFormulaOfWordsUsedToAddressTheContact { get; set; }

        [JsonProperty("state")]
        public string StateNameAlsoCalledProvinceSubdivisionOrRegion { get; set; }

        [JsonProperty("street")]
        public string NameOfTheStreet { get; set; }

        [JsonProperty("title")]
        public string JobTitleOfTheContact { get; set; }

        [JsonProperty("updated")]
        public string LastUpdateTimeOfTheContact { get; set; }
    }

    public class ContactDetailsDto
    {
        [JsonProperty("businessPhoneNumber")]
        public string[] BusinessTelephoneNumberOfTheContact { get; set; }

        [JsonProperty("dateOfBirth")]
        public string DateOfBirthOfTheContact { get; set; }

        [JsonProperty("email")]
        public string[] EmailAddressOfTheContact { get; set; }

        [JsonProperty("fax")]
        public string[] FaxNumberOfTheContact { get; set; }

        [JsonProperty("mobilePhoneNumber")]
        public string[] MobileTelephoneNumberOfTheContact { get; set; }

        [JsonProperty("privatePhoneNumber")]
        public string[] PrivateTelephoneNumberOfTheContact { get; set; }

        [JsonProperty("tradeRegisterNumber")]
        public string TradeRegisterNumber { get; set; }

        [JsonProperty("vatId")]
        public string VatIdOfTheContact { get; set; }

        [JsonProperty("website")]
        public string[] WebsiteOfTheContact { get; set; }
    }

    public class Pageable
    {
        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("pageNumber")]
        public int PageNumber { get; set; }

        [JsonProperty("pageSize")]
        public int PageSize { get; set; }

        [JsonProperty("paged")]
        public bool Paged { get; set; }

        [JsonProperty("sort")]
        public Sort Sort { get; set; }

        [JsonProperty("unpaged")]
        public bool Unpaged { get; set; }
    }

    public class Sort
    {
        [JsonProperty("empty")]
        public bool Empty { get; set; }

        [JsonProperty("sorted")]
        public bool Sorted { get; set; }

        [JsonProperty("unsorted")]
        public bool Unsorted { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum OrderInput
    {
        [EnumMember(Value = "ASC")]
        Asc,
        [EnumMember(Value = "DESC")]
        Desc
    }

    public class PageOfContractDto
    {
        [JsonProperty("content")]
        public ContractDto[] Content { get; set; }

        [JsonProperty("empty")]
        public bool Empty { get; set; }

        [JsonProperty("first")]
        public bool First { get; set; }

        [JsonProperty("last")]
        public bool Last { get; set; }

        [JsonProperty("number")]
        public int Number { get; set; }

        [JsonProperty("numberOfElements")]
        public int NumberOfElements { get; set; }

        [JsonProperty("pageable")]
        public Pageable Pageable { get; set; }

        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("sort")]
        public Sort Sort { get; set; }

        [JsonProperty("totalElements")]
        public int TotalElements { get; set; }

        [JsonProperty("totalPages")]
        public int TotalPages { get; set; }
    }

    public class ContractDto
    {
        [JsonProperty("contacts")]
        public ContactSimpleDto[] ListOfTheContactsAssociatedToTheContract { get; set; }

        [JsonProperty("contractNumber")]
        public string NumberOfTheContract { get; set; }

        [JsonProperty("created")]
        public string CreationTimeOfTheContract { get; set; }

        [JsonProperty("endDate")]
        public string EndDate { get; set; }

        [JsonProperty("id")]
        public int IdOfTheContractInstance { get; set; }

        [JsonProperty("isVacant")]
        public bool IsVacant { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("propertyId")]
        public int IdOfThePropertyInstanceTheContractBelongsTo { get; set; }

        [JsonProperty("startDate")]
        public string StartDate { get; set; }

        [JsonProperty("type")]
        public ContractDtoTypeType Type { get; set; }

        [JsonProperty("unitId")]
        public int IdOfTheUnitInstanceTheContractBelongsTo { get; set; }

        [JsonProperty("updated")]
        public string LastUpdateTimeOfTheContract { get; set; }
    }

    public class ContactSimpleDto
    {
        [JsonProperty("id")]
        public int IdOfTheContactInstance { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ContractDtoTypeType
    {
        [EnumMember(Value = "OWNER")]
        Owner,
        [EnumMember(Value = "TENANT")]
        Tenant,
        [EnumMember(Value = "PROPERTY_OWNER")]
        PropertyOwner
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum TypeInputItem
    {
        [EnumMember(Value = "OWNER")]
        Owner,
        [EnumMember(Value = "TENANT")]
        Tenant,
        [EnumMember(Value = "PROPERTY_OWNER")]
        PropertyOwner
    }

    public class DocumentTagDto
    {
        [JsonProperty("description")]
        public string DescriptionOfTheDocumentTag { get; set; }

        [JsonProperty("id")]
        public int IdOfTheDocumentTag { get; set; }

        [JsonProperty("name")]
        public string NameOfTheDocumentTag { get; set; }
    }

    public class CreateDtoInput
    {
        [JsonProperty("description")]
        public string DescriptionOfTheNewlyCreatedDocumentTag { get; set; }

        [JsonProperty("name")]
        public string NameOfTheNewlyCreatedDocumentTag { get; set; }
    }

    public class UpdateDocumentTagUsingPutUpdateDtoInput
    {
        [JsonProperty("description")]
        public string NewDescriptionOfTheDocumentTag { get; set; }

        [JsonProperty("name")]
        public string NewNameOfTheDocumentTag { get; set; }
    }

    public class PageOfDocumentDto
    {
        [JsonProperty("content")]
        public DocumentDto[] Content { get; set; }

        [JsonProperty("empty")]
        public bool Empty { get; set; }

        [JsonProperty("first")]
        public bool First { get; set; }

        [JsonProperty("last")]
        public bool Last { get; set; }

        [JsonProperty("number")]
        public int Number { get; set; }

        [JsonProperty("numberOfElements")]
        public int NumberOfElements { get; set; }

        [JsonProperty("pageable")]
        public Pageable Pageable { get; set; }

        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("sort")]
        public Sort Sort { get; set; }

        [JsonProperty("totalElements")]
        public int TotalElements { get; set; }

        [JsonProperty("totalPages")]
        public int TotalPages { get; set; }
    }

    public class DocumentDto
    {
        [JsonProperty("amount")]
        public double TotalAmountPresentOnTheDocument { get; set; }

        [JsonProperty("buildingId")]
        public int IdOfTheBuildingTheDocumentBelongsTo { get; set; }

        [JsonProperty("contactId")]
        public int IdOfTheContactTheDocumentBelongsTo { get; set; }

        [JsonProperty("contractId")]
        public int IdOfTheContractTheDocumentBelongsTo { get; set; }

        [JsonProperty("created")]
        public string CreationTimeOfTheDocument { get; set; }

        [JsonProperty("id")]
        public int IdOfTheDocumentInstance { get; set; }

        [JsonProperty("issuedDate")]
        public string IssuedDateOfTheDocument { get; set; }

        [JsonProperty("name")]
        public string NameOfTheDocumentInstance { get; set; }

        [JsonProperty("propertyHrId")]
        public string PropertyHrId { get; set; }

        [JsonProperty("propertyId")]
        public int IdOfThePropertyTheDocumentBelongsTo { get; set; }

        [JsonProperty("propertyName")]
        public string NameOfThePropertyTheDocumentIsAssignedTo { get; set; }

        [JsonProperty("sourceId")]
        public int IdOfTheSourceEntityTheDocumentBelongsTo { get; set; }

        [JsonProperty("sourceType")]
        public DocumentDtoSourceTypeType SourceType { get; set; }

        [JsonProperty("state")]
        public DocumentDtoStateOfTheDocumentType StateOfTheDocument { get; set; }

        [JsonProperty("tags")]
        public DocumentTagSimpleDto[] Tags { get; set; }

        [JsonProperty("unitHrId")]
        public string HumanReadableIdOfTheUnitTheDocumentIsAssignedTo { get; set; }

        [JsonProperty("unitId")]
        public int IdOfTheUnitTheDocumentBelongsTo { get; set; }

        [JsonProperty("updated")]
        public string LastUpdateTimeOfTheDocument { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum DocumentDtoSourceTypeType
    {
        [EnumMember(Value = "HOUSE_MONEY_SETTLEMENT")]
        HouseMoneySettlement,
        [EnumMember(Value = "ECONOMIC_PLAN")]
        EconomicPlan,
        [EnumMember(Value = "BANK_ORDER")]
        BankOrder,
        [EnumMember(Value = "BANK_TRANSACTION")]
        BankTransaction,
        [EnumMember(Value = "HEATING_COST_DISTRIBUTION")]
        HeatingCostDistribution,
        [EnumMember(Value = "INVOICE")]
        Invoice,
        [EnumMember(Value = "SERIAL_LETTER")]
        SerialLetter,
        [EnumMember(Value = "OWNERS_MEETING_INVITATION")]
        OwnersMeetingInvitation,
        [EnumMember(Value = "OWNERS_MEETING_PROTOCOL")]
        OwnersMeetingProtocol,
        [EnumMember(Value = "PROFIT_AND_LOSS")]
        ProfitAndLoss,
        [EnumMember(Value = "OPS_COST_REPORT")]
        OpsCostReport,
        [EnumMember(Value = "SPECIAL_CONTRIBUTION")]
        SpecialContribution,
        [EnumMember(Value = "DUNNING_ANNEX")]
        DunningAnnex,
        [EnumMember(Value = "DUNNING")]
        Dunning,
        [EnumMember(Value = "DUNNING_DD_MANDATE")]
        DunningDdMandate,
        [EnumMember(Value = "WATERMARK")]
        Watermark,
        [EnumMember(Value = "MESSAGE")]
        Message,
        [EnumMember(Value = "OTHER")]
        Other
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum DocumentDtoStateOfTheDocumentType
    {
        [EnumMember(Value = "DRAFT")]
        Draft,
        [EnumMember(Value = "GENERATING")]
        Generating,
        [EnumMember(Value = "READY")]
        Ready,
        [EnumMember(Value = "FAILED")]
        Failed,
        [EnumMember(Value = "DELETED")]
        Deleted
    }

    public class DocumentTagSimpleDto
    {
        [JsonProperty("id")]
        public int UniqueIdentifierOfTheDocumentTag { get; set; }

        [JsonProperty("name")]
        public string NameOfTheDocumentTag { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SourceTypeInputItem
    {
        [EnumMember(Value = "HOUSE_MONEY_SETTLEMENT")]
        HouseMoneySettlement,
        [EnumMember(Value = "ECONOMIC_PLAN")]
        EconomicPlan,
        [EnumMember(Value = "BANK_ORDER")]
        BankOrder,
        [EnumMember(Value = "BANK_TRANSACTION")]
        BankTransaction,
        [EnumMember(Value = "HEATING_COST_DISTRIBUTION")]
        HeatingCostDistribution,
        [EnumMember(Value = "INVOICE")]
        Invoice,
        [EnumMember(Value = "SERIAL_LETTER")]
        SerialLetter,
        [EnumMember(Value = "OWNERS_MEETING_INVITATION")]
        OwnersMeetingInvitation,
        [EnumMember(Value = "OWNERS_MEETING_PROTOCOL")]
        OwnersMeetingProtocol,
        [EnumMember(Value = "PROFIT_AND_LOSS")]
        ProfitAndLoss,
        [EnumMember(Value = "OPS_COST_REPORT")]
        OpsCostReport,
        [EnumMember(Value = "SPECIAL_CONTRIBUTION")]
        SpecialContribution,
        [EnumMember(Value = "DUNNING_ANNEX")]
        DunningAnnex,
        [EnumMember(Value = "DUNNING")]
        Dunning,
        [EnumMember(Value = "DUNNING_DD_MANDATE")]
        DunningDdMandate,
        [EnumMember(Value = "WATERMARK")]
        Watermark,
        [EnumMember(Value = "MESSAGE")]
        Message,
        [EnumMember(Value = "OTHER")]
        Other
    }

    public class DocumentUpdateDto
    {
        public DocumentUpdateDto(int theUniqueIdentifierOfTheDocumentToBeUpdated)
        {
            this.TheUniqueIdentifierOfTheDocumentToBeUpdated = theUniqueIdentifierOfTheDocumentToBeUpdated;
        }

        [JsonProperty("amount")]
        public double? NewValueTheDocumentAmountToBeUpdatedTo { get; set; }

        [JsonProperty("buildingId")]
        public int? NewBuildingBuildingTheDocumentToBeAssignedTo { get; set; }

        [JsonProperty("contactId")]
        public int? NewContactTheDocumentToBeAssignedTo { get; set; }

        [JsonProperty("contractId")]
        public int? NewContractTheDocumentToBeAssignedTo { get; set; }

        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Include)]
        public int TheUniqueIdentifierOfTheDocumentToBeUpdated { get; set; }

        [JsonProperty("issuedDate")]
        public string NewDateTheDocumentIssuedDateToBeUpdatedTo { get; set; }

        [JsonProperty("name")]
        public string NewValueTheDocumentNameToBeUpdatedTo { get; set; }

        [JsonProperty("propertyId")]
        public int? NewPropertyTheDocumentToBeAssignedTo { get; set; }

        [JsonProperty("sourceId")]
        public int? NewSourceProcessIdTheDocumentToBeAssignedTo { get; set; }

        [JsonProperty("tagIds")]
        public int[] IdentifiersOfTagsToBeAssignedToTheDocument { get; set; }

        [JsonProperty("unitId")]
        public int? NewUnitTheDocumentToBeAssignedTo { get; set; }
    }

    public class InvoiceItemDto
    {
        [JsonProperty("accountCode")]
        public string AccountCodeOfTheBookingItem { get; set; }

        [JsonProperty("accountId")]
        public int AccountIdOfTheBookingItem { get; set; }

        [JsonProperty("accountName")]
        public string AccountNameOfTheBookingItem { get; set; }

        [JsonProperty("amount")]
        public double AmountCorrespondingToTheBookingItem { get; set; }

        [JsonProperty("bookingText")]
        public string BookingTextOfTheBookingItem { get; set; }

        [JsonProperty("created")]
        public string CreationTimeOfTheInvoiceItem { get; set; }

        [JsonProperty("id")]
        public int UniqueIdentifierOfTheBookingItem { get; set; }

        [JsonProperty("laborCostAmount")]
        public double LaborCostAmount { get; set; }

        [JsonProperty("laborCostType")]
        public InvoiceItemDtoLaborCostTypeType LaborCostType { get; set; }

        [JsonProperty("updated")]
        public string LastUpdateTimeOfTheInvoiceItem { get; set; }

        [JsonProperty("vatAmount")]
        public double CorrespondingVatAmountOfTheBookingItem { get; set; }

        [JsonProperty("vatPercentage")]
        public double VatPercentage { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum InvoiceItemDtoLaborCostTypeType
    {
        [EnumMember(Value = "HOUSEHOLD_RELATED_SERVICES")]
        HouseholdRelatedServices,
        [EnumMember(Value = "TECHNICIAN_SERVICE")]
        TechnicianService,
        [EnumMember(Value = "MARGINAL_EMPLOYMENT")]
        MarginalEmployment,
        [EnumMember(Value = "INSURABLE_EMPLOYMENT")]
        InsurableEmployment
    }

    public class UpdateInvoiceItemUsingPutUpdateDtoInput
    {
        [JsonProperty("bookingText")]
        public string BookingTextOfTheInvoiceItem { get; set; }
    }

    public class PageOfInvoiceDto
    {
        [JsonProperty("content")]
        public InvoiceDto[] Content { get; set; }

        [JsonProperty("empty")]
        public bool Empty { get; set; }

        [JsonProperty("first")]
        public bool First { get; set; }

        [JsonProperty("last")]
        public bool Last { get; set; }

        [JsonProperty("number")]
        public int Number { get; set; }

        [JsonProperty("numberOfElements")]
        public int NumberOfElements { get; set; }

        [JsonProperty("pageable")]
        public Pageable Pageable { get; set; }

        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("sort")]
        public Sort Sort { get; set; }

        [JsonProperty("totalElements")]
        public int TotalElements { get; set; }

        [JsonProperty("totalPages")]
        public int TotalPages { get; set; }
    }

    public class InvoiceDto
    {
        [JsonProperty("amount")]
        public double AmountToBePayedAccordingToTheInvoice { get; set; }

        [JsonProperty("counterpartContactId")]
        public int IdOfTheCounterpartContactOfTheInvoice { get; set; }

        [JsonProperty("counterpartContactName")]
        public string NameOfTheCounterpartContactOfTheInvoice { get; set; }

        [JsonProperty("created")]
        public string CreationTimeOfTheEntity { get; set; }

        [JsonProperty("id")]
        public int IdOfTheEntity { get; set; }

        [JsonProperty("issuedDate")]
        public string IssuedDateOfTheInvoice { get; set; }

        [JsonProperty("items")]
        public InvoiceItemDto[] Items { get; set; }

        [JsonProperty("name")]
        public string NameOfTheInvoice { get; set; }

        [JsonProperty("orderCounterpartBic")]
        public string BicNumberOfTheCounterpartBankAccount { get; set; }

        [JsonProperty("orderCounterpartIban")]
        public string IbanOfTheCounterpartBankAccount { get; set; }

        [JsonProperty("orderDayOffset")]
        public int OrderDayOffset { get; set; }

        [JsonProperty("orderPropertyBankAccountId")]
        public int UniqueIdentifierOfTheBankAccountOfTheProperty { get; set; }

        [JsonProperty("orderPropertyBic")]
        public string BicNumberOfThePropertyBankAccount { get; set; }

        [JsonProperty("orderPropertyIban")]
        public string IbanOfThePropertyBankAccount { get; set; }

        [JsonProperty("orderRequired")]
        public bool TrueInCaseThereIsACorrespondingOrderOfTheInvoice { get; set; }

        [JsonProperty("orderStatement")]
        public string StatementOfTheGeneratedOrder { get; set; }

        [JsonProperty("propertyHrId")]
        public string HumanReadableIdOfThePropertyTheInvoiceBelongsTo { get; set; }

        [JsonProperty("propertyId")]
        public int IdOfThePropertyTheInvoiceBelongsTo { get; set; }

        [JsonProperty("propertyName")]
        public string NameOfThePropertyTheInvoiceBelongsTo { get; set; }

        [JsonProperty("state")]
        public InvoiceDtoStateType State { get; set; }

        [JsonProperty("updated")]
        public string LastUpdateTimeOfTheEntity { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum InvoiceDtoStateType
    {
        [EnumMember(Value = "DRAFT")]
        Draft,
        [EnumMember(Value = "READY")]
        Ready,
        [EnumMember(Value = "BOOKED")]
        Booked,
        [EnumMember(Value = "SCHEDULED")]
        Scheduled,
        [EnumMember(Value = "REVERSED")]
        Reversed
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum StatesInputItem
    {
        [EnumMember(Value = "DRAFT")]
        Draft,
        [EnumMember(Value = "READY")]
        Ready,
        [EnumMember(Value = "BOOKED")]
        Booked,
        [EnumMember(Value = "SCHEDULED")]
        Scheduled,
        [EnumMember(Value = "REVERSED")]
        Reversed
    }

    public class UpdateInvoiceUsingPutUpdateDtoInput
    {
        [JsonProperty("issuedDate")]
        public string NewIssuedDateOfTheInvoice { get; set; }

        [JsonProperty("name")]
        public string NewNameOfTheInvoice { get; set; }
    }

    public class PageOfPropertyDto
    {
        [JsonProperty("content")]
        public PropertyDto[] Content { get; set; }

        [JsonProperty("empty")]
        public bool Empty { get; set; }

        [JsonProperty("first")]
        public bool First { get; set; }

        [JsonProperty("last")]
        public bool Last { get; set; }

        [JsonProperty("number")]
        public int Number { get; set; }

        [JsonProperty("numberOfElements")]
        public int NumberOfElements { get; set; }

        [JsonProperty("pageable")]
        public Pageable Pageable { get; set; }

        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("sort")]
        public Sort Sort { get; set; }

        [JsonProperty("totalElements")]
        public int TotalElements { get; set; }

        [JsonProperty("totalPages")]
        public int TotalPages { get; set; }
    }

    public class PropertyDto
    {
        [JsonProperty("created")]
        public string CreationTimeOfThePropertyInstance { get; set; }

        [JsonProperty("id")]
        public int IdOfThePropertyInstance { get; set; }

        [JsonProperty("name")]
        public string NameOfThePropertyInstance { get; set; }

        [JsonProperty("propertyHrId")]
        public string HumanReadableIdOfThePropertyInstance { get; set; }

        [JsonProperty("state")]
        public PropertyDtoStateType State { get; set; }

        [JsonProperty("type")]
        public PropertyDtoTypeType Type { get; set; }

        [JsonProperty("updated")]
        public string UpdateTimeOfThePropertyInstance { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum PropertyDtoStateType
    {
        [EnumMember(Value = "DRAFT")]
        Draft,
        [EnumMember(Value = "READY")]
        Ready,
        [EnumMember(Value = "DISABLED")]
        Disabled
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum PropertyDtoTypeType
    {
        [EnumMember(Value = "OWNER")]
        Owner,
        [EnumMember(Value = "RENTAL")]
        Rental
    }

    public class PageOfUnitDto
    {
        [JsonProperty("content")]
        public UnitDto[] Content { get; set; }

        [JsonProperty("empty")]
        public bool Empty { get; set; }

        [JsonProperty("first")]
        public bool First { get; set; }

        [JsonProperty("last")]
        public bool Last { get; set; }

        [JsonProperty("number")]
        public int Number { get; set; }

        [JsonProperty("numberOfElements")]
        public int NumberOfElements { get; set; }

        [JsonProperty("pageable")]
        public Pageable Pageable { get; set; }

        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("sort")]
        public Sort Sort { get; set; }

        [JsonProperty("totalElements")]
        public int TotalElements { get; set; }

        [JsonProperty("totalPages")]
        public int TotalPages { get; set; }
    }

    public class UnitDto
    {
        [JsonProperty("created")]
        public string CreationTimeOfTheUnitInstance { get; set; }

        [JsonProperty("floor")]
        public string FloorTheUnitIsLocatedOn { get; set; }

        [JsonProperty("id")]
        public int IdOfTheUnitInstance { get; set; }

        [JsonProperty("position")]
        public string PositionOfTheUnitWithinTheFloor { get; set; }

        [JsonProperty("propertyId")]
        public int IdOfThePropertyInstanceTheUnitBelongsTo { get; set; }

        [JsonProperty("type")]
        public UnitDtoTypeType Type { get; set; }

        [JsonProperty("unitHrId")]
        public string HumanReadableIdOfTheUnitInstance { get; set; }

        [JsonProperty("unitRank")]
        public int UnitRank { get; set; }

        [JsonProperty("updated")]
        public string UpdateTimeOfTheUnitInstance { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum UnitDtoTypeType
    {
        [EnumMember(Value = "APARTMENT")]
        Apartment,
        [EnumMember(Value = "PARKING")]
        Parking,
        [EnumMember(Value = "OTHER")]
        Other,
        [EnumMember(Value = "COMMERCIAL")]
        Commercial
    }

    public class LegacyInvoiceDto
    {
        [JsonProperty("counterpartBic")]
        public string BicCounterpart { get; set; }

        [JsonProperty("counterpartContactId")]
        public int ContactIdCounterpart { get; set; }

        [JsonProperty("counterpartIban")]
        public string IbanCounterpart { get; set; }

        [JsonProperty("counterpartName")]
        public string Counterpart { get; set; }

        [JsonProperty("created")]
        public string Date { get; set; }

        [JsonProperty("documentUrl")]
        public string InvoiceUrl { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("invoiceDate")]
        public string InvoiceDate { get; set; }

        [JsonProperty("invoiceHrId")]
        public string InvoiceId { get; set; }

        [JsonProperty("invoiceNumber")]
        public string InvoiceNumber { get; set; }

        [JsonProperty("paymentTargetDate")]
        public string PaymentTargetDate { get; set; }

        [JsonProperty("paymentType")]
        public string PaymentType { get; set; }

        [JsonProperty("propertyHrId")]
        public string PropertyNR { get; set; }

        [JsonProperty("propertyId")]
        public int PropertyId { get; set; }

        [JsonProperty("propertyIdInternal")]
        public string PropertyInternalId { get; set; }

        [JsonProperty("propertyName")]
        public string PropertyName { get; set; }

        [JsonProperty("refNr")]
        public string ReferenceNr { get; set; }

        [JsonProperty("state")]
        public LegacyInvoiceDtoStatusOfInvoiceType StatusOfInvoice { get; set; }

        [JsonProperty("totalGross")]
        public double TotalGross { get; set; }

        [JsonProperty("totalNet")]
        public double TotalNet { get; set; }

        [JsonProperty("vatIncluded")]
        public bool VatIncl { get; set; }

        [JsonProperty("vatPercentage")]
        public double VatPercentage { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum LegacyInvoiceDtoStatusOfInvoiceType
    {
        [EnumMember(Value = "NEW")]
        New,
        [EnumMember(Value = "APPROVED")]
        Approved,
        [EnumMember(Value = "RECURRING")]
        Recurring,
        [EnumMember(Value = "RECURRING_STOPPED")]
        RecurringStopped,
        [EnumMember(Value = "DELETED")]
        Deleted
    }

    public class ConnectionCreateDtoInput
    {
        [JsonProperty("appId", DefaultValueHandling = DefaultValueHandling.Include)]
        internal int IdOfTheApplicationToConnectToTheDomain { get; set; } = 4;

        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Name { get; set; } = "Powerautomate webhook";

        [JsonProperty("webhookUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string WebhookUrl { get; set; } = "#{listCallbackUrl()}";
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Impower;

    public partial class WorkflowManagedActions
    {
        public ImpowerActions Impower(string connectionId) => new ImpowerActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public ImpowerTriggers Impower(string connectionId) => new ImpowerTriggers(connectionId);
    }
}